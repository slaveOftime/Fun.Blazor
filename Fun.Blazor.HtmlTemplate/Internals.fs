module Fun.Blazor.HtmlTemplate.Internals

open System
open System.IO
open System.Text
open System.Text.RegularExpressions
open System.Collections.Concurrent
open FSharp.Data


let formatHoleRegex = Regex("\{([\d]*)\}")

let internal caches = ConcurrentDictionary<int, Bolero.Node list>()

type MkAttr = obj [] -> Bolero.Attr list
type MkNode = obj [] -> Bolero.Node

type PlacerHolderNode =
    interface
    end

let placeholderAttrKey = "__placeholder__"
let placeholderAttr (mk: MkAttr) = Bolero.Attr(placeholderAttrKey, mk)

let placeholderNodeType = typeof<PlacerHolderNode>

let placeholderNode (mk: MkNode) =
    Bolero.Match(placeholderNodeType, mk, Bolero.Empty)


let buildNodes (str: string) =
    [
        let matches = formatHoleRegex.Matches str
        if matches.Count = 0 then
            let trimedTxt = str.Trim()
            if String.IsNullOrEmpty trimedTxt |> not then Bolero.Text trimedTxt
        else
            let mutable strIndex = 0
            for m in matches do
                let txt = str.Substring(strIndex, m.Index - strIndex)
                let trimedTxt = txt.Trim()
                if String.IsNullOrEmpty trimedTxt |> not then Bolero.Text trimedTxt

                strIndex <- m.Index + m.Length

                let argIndex = int m.Groups.[1].Value
                placeholderNode (fun args ->
                    let arg = args.[argIndex]
                    match arg with
                    | :? Bolero.Node as n -> n
                    | x -> Bolero.Text(string x)
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

    if name.StartsWith "on" && valueMatches.Count = 1 then
        let argIndex = int valueMatches.[0].Groups.[1].Value
        placeholderAttr (fun args ->
            let arg = args.[argIndex]
            let name = makeName args
            if String.IsNullOrEmpty name then
                List.empty
            else
                [ Bolero.Html.attr.callback name (fun x -> invokeFunction arg x :?> unit) ]
        )
    elif valueMatches.Count = 1 && valueMatches.[0].Index = 0 && valueMatches.[0].Length = value.Length then
        let argIndex = int valueMatches.[0].Groups.[1].Value
        placeholderAttr (fun args ->
            let name = makeName args
            if String.IsNullOrEmpty name then
                List.empty
            else
                [ Bolero.Attr(name, args.[argIndex]) ]
        )
    elif valueMatches.Count > 0 then
        placeholderAttr (fun args ->
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
            if String.IsNullOrEmpty name then
                List.empty
            else
                [ Bolero.Attr(name, sb.ToString()) ]
        )
    else if nameMatches.Count > 0 then
        placeholderAttr (fun args ->
            let name = makeName args
            if String.IsNullOrEmpty name then List.empty else [ Bolero.Attr(name, value) ]
        )
    else
        Bolero.Attr(name, value)


let rec buildNodeTree (args: obj []) (nodes: Bolero.Node list) =
    [
        for node in nodes do
            match node with
            | Bolero.Elt (n, attrs, childs) ->
                let newAttrs =
                    [
                        for attr in attrs do
                            match attr with
                            | Bolero.Attr (key, mk) when key = placeholderAttrKey -> yield! (unbox<MkAttr> mk) args
                            | _ -> attr
                    ]
                let newNodes = buildNodeTree args childs
                Bolero.Elt(n, newAttrs, newNodes)
            | Bolero.Match (ty, mk, _) when ty = placeholderNodeType -> (unbox<MkNode> mk) args
            | _ -> node
    ]


let parseNodes (str: string) =
    use stream = new MemoryStream(Encoding.UTF8.GetBytes str)
    let doc = HtmlDocument.Load stream

    let rec loop (nodes: HtmlNode seq) =
        [
            for node in nodes do
                let name = node.Name()
                if String.IsNullOrEmpty name then
                    yield! buildNodes (node.ToString())
                else
                    Bolero.Elt(
                        name,
                        [
                            for attr in node.Attributes() do
                                buildAttrs (attr.Name(), attr.Value())
                        ],
                        loop (node.Elements())
                    )
        ]

    doc.Elements() |> loop
