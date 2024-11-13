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

let internal caches = ConcurrentDictionary<string, NodeItem list>()


let buildNodes (str: string) (args: obj[]) =
    let matches = formatHoleRegex.Matches str
    seq {
        if matches.Count = 0 then
            if String.IsNullOrEmpty str |> not then Node(html.text str)
        else
            let mutable strIndex = 0
            for m in matches do
                let txt = str.Substring(strIndex, m.Index - strIndex)
                if String.IsNullOrEmpty txt |> not then Node(html.text txt)

                strIndex <- m.Index + m.Length

                let argIndex = int m.Groups.[1].Value

                let isNode =
                    match args.[argIndex] with
                    | :? NodeRenderFragment -> true
                    | _ -> false

                NodeMk(fun args ->
                    NodeRenderFragment(fun comp builder index ->
                        let arg = args.[argIndex]
                        if isNode then
                            (arg :?> NodeRenderFragment).Invoke(comp, builder, index)
                        else
                            builder.AddContent(index, arg)
                            index + 1
                    )
                )
    }


let buildRawNodes (str: string) =
    let matches = formatHoleRegex.Matches str
    [
        if matches.Count = 0 then
            if String.IsNullOrEmpty str |> not then Node(html.raw str)
        else
            NodeMk(fun args ->
                NodeRenderFragment(fun comp builder index ->
                    let sb = stringBuilderPool.Get()
                    let mutable strIndex = 0
                    for m in matches do
                        let txt = str.Substring(strIndex, m.Index - strIndex)
                        if String.IsNullOrEmpty txt |> not then sb.Append txt |> ignore

                        let argIndex = int m.Groups.[1].Value
                        sb.Append(string args.[argIndex]) |> ignore

                        strIndex <- m.Index + m.Length

                    let node = html.raw(sb.ToString()).Invoke(comp, builder, index)
                    stringBuilderPool.Return sb
                    node
                )
            )
    ]


let buildAttrs (name: string, value: string) (args: obj []) =
    let inline invokeFunction (fn: obj) (x: obj) = fn.GetType().InvokeMember("Invoke", Reflection.BindingFlags.InvokeMethod, null, fn, [| x |])

    let nameMatches = formatHoleRegex.Matches name
    let valueMatches = formatHoleRegex.Matches value

    let makeName =
        if nameMatches.Count > 0 then
            fun (args: obj []) ->
                let sb = stringBuilderPool.Get()
                let mutable strIndex = 0
                for m in nameMatches do
                    let txt = value.Substring(strIndex, m.Index - strIndex)
                    if String.IsNullOrEmpty txt |> not then sb.Append txt |> ignore

                    strIndex <- m.Index + m.Length

                    let argIndex = int m.Groups.[1].Value
                    let arg = args.[argIndex]
                    sb.Append(string arg) |> ignore

                let result = sb.ToString()
                stringBuilderPool.Return sb
                result

        else
            fun _ -> name

    if valueMatches.Count = 1 && valueMatches.[0].Index = 0 && valueMatches.[0].Length = value.Length then
        let argIndex = int valueMatches.[0].Groups.[1].Value
        let isNormalAttr =
            match args[argIndex] with
            | :? ArgMkAttrWithName 
            | :? AttrRenderFragment -> false
            | _ -> true
        let isEvent = 
            if isNormalAttr then
                let name = makeName args
                name.StartsWith "on"
            else
                false
        AttrMk(fun args ->
            AttrRenderFragment(fun comp builder index ->
                let name = makeName args
                let arg = args.[argIndex]
                if String.IsNullOrEmpty name then
                    index
                else
                    // Try avoid type checking at runtime to avoid performance penalty
                    if isEvent then
                        builder.AddAttribute(index, name, EventCallback.Factory.Create(comp, Action(invokeFunction arg >> ignore)))
                        index + 1
                    else if isNormalAttr then 
                        builder.AddAttribute(index, name, arg)
                        index + 1
                    else
                        match arg with
                        | :? ArgMkAttrWithName as fn -> (fn name).Invoke(comp, builder, index)
                        | :? AttrRenderFragment as fn -> fn.Invoke(comp, builder, index)
                        | _ when name.StartsWith "on" ->
                            builder.AddAttribute(index, name, EventCallback.Factory.Create(comp, Action(invokeFunction arg >> ignore)))
                            index + 1
                        | _ -> 
                            builder.AddAttribute(index, name, arg)
                            index + 1
            )
        )
    elif valueMatches.Count > 0 then
        AttrMk(fun args ->
            let sb = stringBuilderPool.Get()
            let mutable strIndex = 0
            for m in valueMatches do
                let txt = value.Substring(strIndex, m.Index - strIndex)
                if String.IsNullOrEmpty txt |> not then sb.Append txt |> ignore

                strIndex <- m.Index + m.Length

                let argIndex = int m.Groups.[1].Value
                let arg = args.[argIndex]
                sb.Append(string arg) |> ignore

            let name = makeName args
            if String.IsNullOrEmpty name then html.emptyAttr
            else 
                let result = name => (sb.ToString())
                stringBuilderPool.Return sb
                result
        )
    elif nameMatches.Count > 0 then
        AttrMk(fun args ->
            let name = makeName args
            if String.IsNullOrEmpty name then html.emptyAttr else name => value
        )
    else
        Attr(name => value)


let mergeNodes (items: NodeItem seq) = seq {
    let mutable last = ValueNone
    for item in items do
        match last, item with
        | ValueSome (Node pre), Node current -> 
            let item = Node(pre >=> current)
            last <- ValueSome item
            item
        | _ -> 
            last <- ValueSome item
            item
}

let mergeAttrs (items: AttrItem seq) = seq {
    let mutable last = ValueNone
    for item in items do
        match last, item with
        | ValueSome (Attr pre), Attr current -> 
            let item = Attr(pre ==> current)
            last <- ValueSome item
            item
        | _ -> 
            last <- ValueSome item
            item
}


let rec rebuildNodes (nodes: NodeItem seq) (args: obj []): NodeRenderFragment =
    NodeRenderFragment(fun comp builder i ->
        let mutable i = i
        for node in nodes do
            match node with
            | Node x -> i <- x.Invoke(comp, builder, i)
            | NodeMk mk -> i <- mk(args).Invoke(comp, builder, i)
            | NodeElt (name, attrs, nodes) ->
                builder.OpenElement(i, name)
                i <- i + 1
                for attr in attrs do
                    match attr with
                    | AttrItem.Attr attr -> i <- attr.Invoke(comp, builder, i)
                    | AttrItem.AttrMk mk -> i <- mk(args).Invoke(comp, builder, i)
                if nodes.Length > 0 then
                    i <- (rebuildNodes nodes args).Invoke(comp, builder, i)
                builder.CloseElement()
        i
    )


let parseNodes (str: string) (args: obj []) =
    let doc = HtmlDocument.Parse str

    let rec loopNodes (nodes: HtmlNode seq) =
        mergeNodes (seq {
            for node in nodes do
                let nodeName = node.Name()
                let nodeText = node.ToString()

                if String.IsNullOrEmpty nodeName then
                    yield! buildNodes nodeText args

                else if formatHoleRegex.IsMatch nodeText |> not then
                    Node(html.raw nodeText)
                
                else
                    let attrs =
                        mergeAttrs (seq {
                            for attr in node.Attributes() do
                                buildAttrs (attr.Name(), attr.Value()) args
                        })

                    let nodes =
                        if nodeName = "script" || nodeName = "style" then
                            mergeNodes (seq {
                                for ele in node.Elements() do
                                    yield! buildRawNodes (ele.ToString())
                            })
                        else
                            loopNodes (node.Elements())

                    match Seq.toList attrs, Seq.toList nodes with
                    | [ Attr attr ], [] -> Node(EltWithChildBuilder nodeName { attr })
                    | [], [ Node node ] -> Node(EltWithChildBuilder nodeName { node })
                    | [ Attr attr ], [ Node node ] ->
                        Node(
                            EltWithChildBuilder nodeName {
                                attr
                                node
                            }
                        )
                    | attrs, nodes -> NodeElt(nodeName, attrs, nodes)
        })

    loopNodes (doc.Elements()) |> Seq.toList
