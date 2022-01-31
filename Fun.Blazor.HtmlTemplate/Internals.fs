module Fun.Blazor.HtmlTemplate.Internals

open System
open System.Text
open System.Text.RegularExpressions
open System.Collections.Concurrent
open Microsoft.AspNetCore.Components
open System.Xml
open Fun.Blazor
open Fun.Blazor.Operators


type MakeAttrWithName = string -> AttrRenderFragment


let formatHoleRegex = Regex("\{([\d]*)\}")

let internal caches = ConcurrentDictionary<int, obj [] -> NodeRenderFragment>()



let buildNodes (args: obj []) (str: string) =
    let matches = formatHoleRegex.Matches str
    fragment {
        if matches.Count = 0 then
            let trimedTxt = str.Trim()
            if String.IsNullOrEmpty trimedTxt |> not then html.text trimedTxt
        else
            let mutable strIndex = 0
            for m in matches do
                let txt = str.Substring(strIndex, m.Index - strIndex)
                let trimedTxt = txt.Trim()
                if String.IsNullOrEmpty trimedTxt |> not then html.text trimedTxt

                strIndex <- m.Index + m.Length

                let argIndex = int m.Groups.[1].Value

                NodeRenderFragment(fun comp builder index ->
                    let arg = args.[argIndex]
                    match arg with
                    | :? NodeRenderFragment as n -> n.Invoke(comp, builder, index)
                    | x -> html.text(string x).Invoke(comp, builder, index)
                )
    }


let buildRawNodes (args: obj []) (str: string) =
    let matches = formatHoleRegex.Matches str
    fragment {
        if matches.Count = 0 then
            let trimedTxt = str.Trim()
            if String.IsNullOrEmpty trimedTxt |> not then html.raw trimedTxt
        else
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
    }


let buildAttrs (args: obj []) (name: string, value: string) =
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
        AttrRenderFragment(fun comp builder index ->
            let name = makeName args
            let arg = args.[argIndex]
            if String.IsNullOrEmpty name then
                index
            else
                match arg with
                | :? MakeAttrWithName as fn -> (fn name).Invoke(comp, builder ,index)
                | :? AttrRenderFragment as fn -> fn.Invoke(comp, builder ,index)
                | _ -> (name => arg).Invoke(comp, builder, index)
        )
    elif valueMatches.Count > 0 then
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
        if String.IsNullOrEmpty name then emptyAttr else name => (sb.ToString())
    elif nameMatches.Count > 0 then
        let name = makeName args
        if String.IsNullOrEmpty name then emptyAttr else name => value
    else
        name => value


let parseNodes (str: string) =
    let doc = XmlDocument()

    doc.LoadXml str

    let rec loopNodes (args: obj []) (nodes: XmlNodeList) : NodeRenderFragment =
        fragment {
            for i in 0 .. nodes.Count - 1 do
                let node = nodes.Item i
                let nodeName = node.Name
                if String.IsNullOrEmpty nodeName then
                    buildNodes args (node.ToString())
                else
                    EltBuilder nodeName {
                        for k in 0 .. node.Attributes.Count - 1 do
                            let attr = node.Attributes.Item k
                            buildAttrs args (attr.Name, attr.Value)

                        if nodeName = "script" || nodeName = "style" then
                            for j in 0 .. node.ChildNodes.Count - 1 do
                                buildRawNodes args ((node.ChildNodes.Item j).ToString())
                        else
                            loopNodes args nodes
                    }
        }

    fun (args: obj []) -> loopNodes args doc.ChildNodes
