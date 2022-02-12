module Fun.Blazor.HtmlTemplate.Internals

open System
open System.Text
open System.Text.RegularExpressions
open System.Collections.Generic
open System.Collections.Concurrent
open Microsoft.AspNetCore.Components
open FSharp.Data
open Fun.Blazor
open Operators
open Internal


type AttrItem =
    | Attr of attr: AttrRenderFragment
    | AttrMk of attrMk: (obj [] -> AttrRenderFragment)

type NodeItem =
    | Node of node: NodeRenderFragment
    | NodeMk of ndoeMk: (obj [] -> NodeRenderFragment)
    | NodeElt of name: string * attrs: AttrItem list * nodes: NodeItem list


type ArgMkAttrWithName = string -> AttrRenderFragment


let formatHoleRegex = Regex("\{([\d]*)\}")

let internal caches = ConcurrentDictionary<int, NodeItem list>()


let buildNodes (str: string) =
    let matches = formatHoleRegex.Matches str
    [
        if matches.Count = 0 then
            let trimedTxt = str.Trim()
            if String.IsNullOrEmpty trimedTxt |> not then Node(html.text trimedTxt)
        else
            let mutable strIndex = 0
            for m in matches do
                let txt = str.Substring(strIndex, m.Index - strIndex)
                let trimedTxt = txt.Trim()
                if String.IsNullOrEmpty trimedTxt |> not then Node(html.text trimedTxt)

                strIndex <- m.Index + m.Length

                let argIndex = int m.Groups.[1].Value

                NodeMk(fun args ->
                    NodeRenderFragment(fun comp builder index ->
                        let arg = args.[argIndex]
                        match arg with
                        | :? NodeRenderFragment as n -> n.Invoke(comp, builder, index)
                        | x -> html.text(string x).Invoke(comp, builder, index)
                    )
                )
    ]


let buildRawNodes (str: string) =
    let matches = formatHoleRegex.Matches str
    [
        if matches.Count = 0 then
            let trimedTxt = str.Trim()
            if String.IsNullOrEmpty trimedTxt |> not then Node(html.raw trimedTxt)
        else
            NodeMk(fun args ->
                NodeRenderFragment(fun comp builder index ->
                    let sb = StringBuilder()
                    let mutable strIndex = 0
                    for m in matches do
                        let txt = str.Substring(strIndex, m.Index - strIndex)
                        let trimedTxt = txt.Trim()
                        if String.IsNullOrEmpty trimedTxt |> not then sb.Append trimedTxt |> ignore

                        let argIndex = int m.Groups.[1].Value
                        sb.Append(string args.[argIndex]) |> ignore

                        strIndex <- m.Index + m.Length

                    html.raw(sb.ToString()).Invoke(comp, builder, index)
                )
            )
    ]


let buildAttrs (name: string, value: string) =
    let inline invokeFunction (fn: obj) (x: obj) =
        fn.GetType().InvokeMember("Invoke", Reflection.BindingFlags.InvokeMethod, null, fn, [| x |])

    let nameMatches = formatHoleRegex.Matches name
    let valueMatches = formatHoleRegex.Matches value

    let makeName =
        if nameMatches.Count > 0 then
            fun (args: obj []) ->
                let sb = StringBuilder()
                let mutable strIndex = 0
                for m in nameMatches do
                    let txt = value.Substring(strIndex, m.Index - strIndex)
                    if String.IsNullOrEmpty txt |> not then sb.Append txt |> ignore

                    strIndex <- m.Index + m.Length

                    let argIndex = int m.Groups.[1].Value
                    let arg = args.[argIndex]
                    sb.Append(string arg) |> ignore
                sb.ToString()

        else
            fun _ -> name

    if valueMatches.Count = 1 && valueMatches.[0].Index = 0 && valueMatches.[0].Length = value.Length then
        let argIndex = int valueMatches.[0].Groups.[1].Value
        AttrMk(fun args ->
            AttrRenderFragment(fun comp builder index ->
                let name = makeName args
                let arg = args.[argIndex]
                if String.IsNullOrEmpty name then
                    index
                else
                    match arg with
                    | :? ArgMkAttrWithName as fn -> (fn name).Invoke(comp, builder, index)
                    | :? AttrRenderFragment as fn -> fn.Invoke(comp, builder, index)
                    | _ when name.StartsWith "on" -> html.callback(name, (fun x -> invokeFunction arg x :?> unit)).Invoke(comp, builder, index)
                    | _ -> (name => arg).Invoke(comp, builder, index)
            )
        )
    elif valueMatches.Count > 0 then
        AttrMk(fun args ->
            let sb = StringBuilder()
            let mutable strIndex = 0
            for m in valueMatches do
                let txt = value.Substring(strIndex, m.Index - strIndex)
                if String.IsNullOrEmpty txt |> not then sb.Append txt |> ignore

                strIndex <- m.Index + m.Length

                let argIndex = int m.Groups.[1].Value
                let arg = args.[argIndex]
                sb.Append(string arg) |> ignore

            let name = makeName args
            if String.IsNullOrEmpty name then emptyAttr() else name => (sb.ToString())
        )
    elif nameMatches.Count > 0 then
        AttrMk(fun args ->
            let name = makeName args
            if String.IsNullOrEmpty name then emptyAttr() else name => value
        )
    else
        Attr(name => value)


let mergeNodes (items: NodeItem seq) =
    let list = List()
    for item in items do
        match Seq.tryLast list, item with
        | Some (Node pre), Node current -> list.[list.Count - 1] <- Node(pre >=> current)
        | _ -> list.Add item
    Seq.toList list

let mergeAttrs (items: AttrItem seq) =
    let list = List()
    for item in items do
        match Seq.tryLast list, item with
        | Some (Attr pre), Attr current -> list.[list.Count - 1] <- Attr(pre ==> current)
        | _ -> list.Add item
    Seq.toList list


let rebuildNodes (nodes: NodeItem seq) (args: obj []) =
    let rec loopNodes (nodes: NodeItem seq) : NodeRenderFragment =
        fragment {
            for node in nodes do
                match node with
                | Node x -> x
                | NodeMk mk -> mk args
                | NodeElt (name, attrs, nodes) ->
                    EltWithChildBuilder name {
                        html.mergeAttrs [
                            for attr in attrs do
                                match attr with
                                | Attr x -> x
                                | AttrMk mk -> mk args
                        ]
                        loopNodes nodes
                    }
        }

    loopNodes nodes


let parseNodes (str: string) =
    let doc = HtmlDocument.Parse str

    let rec loopNodes (nodes: HtmlNode seq) =
        [
            for node in nodes do
                let nodeName = node.Name()
                if String.IsNullOrEmpty nodeName then
                    yield! buildNodes (node.ToString())

                else
                    let attrs =
                        [
                            for attr in node.Attributes() do
                                buildAttrs (attr.Name(), attr.Value())
                        ]
                        |> mergeAttrs

                    let nodes =
                        if nodeName = "script" || nodeName = "style" then
                            [
                                for ele in node.Elements() do
                                    yield! buildRawNodes (ele.ToString())
                            ]
                            |> mergeNodes
                        else
                            loopNodes (node.Elements())

                    match attrs, nodes with
                    | [ Attr attr ], [] -> Node(EltWithChildBuilder nodeName { attr })
                    | [], [ Node node ] -> Node(EltWithChildBuilder nodeName { node })
                    | [ Attr attr ], [ Node node ] ->
                        Node(
                            EltWithChildBuilder nodeName {
                                attr
                                node
                            }
                        )
                    | _ -> NodeElt(nodeName, attrs, nodes)
        ]
        |> mergeNodes

    loopNodes (doc.Elements())
