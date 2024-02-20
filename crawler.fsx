#r "nuget: FSharp.Data"
#r "nuget: Fun.Build"

open System
open FSharp.Data
open Fun.Build

type HtmxReference = HtmlProvider<"https://htmx.org/reference/">
type HtmlAriaAttributes = HtmlProvider<"https://developer.mozilla.org/docs/Web/Accessibility/ARIA/Attributes">
type HtmlEvents = HtmlProvider<"https://developer.mozilla.org/en-US/docs/Web/Events">
type HtmlAttributes = HtmlProvider<"https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes">
type HtmlGlobalAttributes = HtmlProvider<"https://developer.mozilla.org/en-US/docs/Web/HTML/Global_attributes">
type HtmlElements = HtmlProvider<"https://developer.mozilla.org/en-US/docs/Web/HTML/Element">


pipeline "htmx" {
    stage "events" {
        run (fun _ ->
            let references = HtmxReference.GetSample()

            references.Tables.``#Event Reference``.Rows
            |> Seq.iter (fun row ->
                let name = row.Event.Substring(row.Event.IndexOf ":" + 1)
                let key = name.Replace(":", "_")
                let name =
                    name
                    |> Seq.mapi (fun i c ->
                        match Char.IsUpper c, i = 0 with
                        | true, true -> [ Char.ToLower c ]
                        | true, false -> [ '-'; Char.ToLower c ]
                        | _ -> [ c ]
                    )
                    |> Seq.concat
                    |> String.Concat
                printfn
                    $"""/// {row.Description}
    [<Literal>]
    let {key} = "{name}"
"""
            )
        )
    }
    runIfOnlySpecified
}


pipeline "aria" {
    stage "" {
        run (fun _ ->
            let sample = HtmlAriaAttributes.GetSample()

            let keys = System.Collections.Generic.HashSet<string>()

            sample.Lists.``ARIA attribute types``.Values |> Seq.iter (keys.Add >> ignore)

            sample.Lists.``Global ARIA attributes``.Values |> Seq.iter (keys.Add >> ignore)

            keys
            |> Seq.iter (fun key ->
                if key.Contains " " |> not && key.Contains "-" then
                    let name = key.Replace("-", "_").Substring(5)
                    printfn $"    let inline {name} x = \"{key}\", string x"
            )
        )
    }
}

// pipeline "event" {
//     stage "" {
//         run (fun _ ->
//             let lists = System.Collections.Generic.HashSet<string>()
//             for value in HtmlEvents.GetSample().Lists.``Event listing``.Values do
//                 let index = value.LastIndexOf " event"
//                 if index > 0 then
//                     let name = value.Substring(0, index)
//                     if lists.Contains name |> not then
//                         lists.Add name |> ignore
//                         printfn
//                             $"""        [<CustomOperation("on{name}")>]
//         member inline _.on{name}([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("on{name}" => js)
//                         """
//         )
//     }
// }

type Bundle = {| Name: string; Description: string; IsBool: bool |}

pipeline "elements" {
    stage "" {
        run (fun _ ->
            let elements =
                Collections.Generic.HashSet<{| Name: string; Description: string |}>()

            let elementsTables = HtmlElements.GetSample().Tables
            let parseElementName (x: string) = x.Replace("<", "").Replace(">", "").Trim()
             
            elementsTables.Table1.Rows  |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table2.Rows  |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table3.Rows  |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table4.Rows  |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table5.Rows  |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table6.Rows  |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table7.Rows  |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table8.Rows  |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table10.Rows |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table11.Rows |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table12.Rows |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table13.Rows |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table14.Rows |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)
            elementsTables.Table15.Rows |> Seq.iter (fun row -> elements.Add({| Name = parseElementName row.Element; Description = row.Description |}) |> ignore)

            let elements =
                elements
                |> Seq.map (fun x ->
                    x.Name.Split ","  |> Seq.map (fun n ->  {| x with Name = n.Trim() |})
                )
                |> Seq.concat
                |> Seq.filter (fun x -> x.Name <> "style")

            let generatedElements = Collections.Generic.HashSet<string>()

            let tables = HtmlAttributes.GetSample().Tables

            let bundles =
                Collections.Generic.Dictionary<string, Collections.Generic.HashSet<Bundle>>()

            tables.Table1.Rows
            |> Seq.iter (fun row ->
                let name = row.``Attribute Name``
                let isBool =
                    row.Description.Contains("whether", StringComparison.OrdinalIgnoreCase)
                    || row.Description.Contains("Indicates", StringComparison.OrdinalIgnoreCase)
                let elements =
                    row.Elements.Split(",")
                    |> Seq.map parseElementName
                    |> Seq.toList
                for element in elements do
                    let attrs =
                        if bundles.ContainsKey element then
                            bundles[element]
                        else
                            bundles[element] <- Collections.Generic.HashSet()
                            bundles[element]
                    
                    if name <> "style" then
                        attrs.Add {|
                            Name = name
                            Description = row.Description
                            IsBool = isBool
                        |}
                        |> ignore
            )

            let elementBuilderSb = Text.StringBuilder()
            let globalAttrsSb = Text.StringBuilder()
            let elementsSb = Text.StringBuilder()

            let appendForElementBuilder (x: string) = elementBuilderSb.AppendLine(x) |> ignore
            let appendForElements (x: string) = elementsSb.AppendLine(x) |> ignore

            globalAttrsSb.AppendLine "[<AutoOpen>]
module DslElementsBuilder_global =

    open Operators
"
            |> ignore

            appendForElementBuilder
                "module DslElementBuilder_generated =

    open Operators
"

            appendForElements
                "[<AutoOpen>]
module DslElements_generated =

    open DslElementBuilder_generated
"

                        
            let processAttrs appendLine (bundles: Bundle seq) =
                for attr in bundles |> Seq.sortBy (fun x -> x.Name) do
                    let comment =
                        if String.IsNullOrEmpty attr.Description then "" else $"/// {attr.Description}"
                    if
                        attr.Name.Contains("Deprecated", StringComparison.OrdinalIgnoreCase)
                        || attr.Name = "class"
                        || attr.Name = "style"
                        || attr.Name = "value"
                    then
                        ()
                    else if attr.Name.StartsWith "data-" then
                        appendLine
                            $"""        {comment}
        [<CustomOperation("data")>]
        member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, k, v) = render ==> ("data-" + k => v)

        {comment}
        [<CustomOperation("data")>]
        member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("data" => v)
"""
                    else if attr.Name <> "data" then
                        let name =
                            if List.contains attr.Name [ "class"; "open"; "for"; "type"; "default"; "checked"; "title"; "as" ] 
                                || elements |> Seq.exists (fun x -> x.Name = attr.Name)
                            then
                                attr.Name + "'"
                            else if attr.Name = "accept-charset" then
                                "acceptCharset"
                            else if attr.Name = "http-equiv" then
                                "httpEquiv"
                            else
                                attr.Name
                        let isBool = attr.IsBool || attr.Name = "autoplay"
                        let optionPrefix = if isBool || attr.Name = "autocomplete" then "?" else ""
                        let value =
                            if attr.Name = "autocomplete" then """=>> (if defaultArg v true then "on" else "off")"""
                            else if List.contains attr.Name [ "min"; "max"; "formaction" ] then "=> v"
                            else if isBool then "=>>> defaultArg v true"
                            else "=> v"
                        appendLine
                            $"""        {comment}
        [<CustomOperation("{name}")>]
        member inline _.{name}([<InlineIfLambda>] render: AttrRenderFragment, {optionPrefix}v) = render ==> ("{attr.Name}" {value})
"""

            
            let filteredBundles =
                bundles 
                |> Seq.filter (fun x -> x.Key.Contains("global", StringComparison.OrdinalIgnoreCase) |> not) 
                |> Seq.sortBy (fun x -> x.Key)

            let allAttrs =
                bundles 
                |> Seq.map (fun x -> x.Value)
                |> Seq.concat
                |> Seq.distinctBy (fun x -> x.Name)
                |> Seq.sortBy (fun x -> x.Name)

            globalAttrsSb.AppendLine $"    type DomAttrBuilder with
"
            |> ignore

            processAttrs (globalAttrsSb.AppendLine >> ignore) allAttrs
            globalAttrsSb.AppendLine """        [<CustomOperation("autocomplete")>]
        member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" =>> v)
"""
            |> ignore

            for bundle in filteredBundles do
                generatedElements.Add bundle.Key |> ignore

                if bundle.Key = "script" then
//                     globalAttrsSb.AppendLine $"    type EltBuilder_script with
// "
//                     |> ignore
//                     processAttrs (globalAttrsSb.AppendLine >> ignore) bundle.Value
                    ()

                else
                    appendForElementBuilder $"""    type EltBuilder_{bundle.Key}() =
        inherit EltWithChildBuilder("{bundle.Key}")
"""

//                     processAttrs appendForElementBuilder bundle.Value

//                     if bundle.Key = "input" then
//                         appendForElementBuilder """        [<CustomOperation("autocomplete")>]
//         member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" =>> v)
// """


            for element in elements |> Seq.sortBy (fun x -> x.Name) do
                let elementName =
                    if List.contains element.Name [ "base"; "html" ] then
                        element.Name + "'"
                    else
                        element.Name

                if generatedElements.Contains element.Name then
                    appendForElements $"    /// {element.Description}
    let {elementName} = EltBuilder_{element.Name}()
"
                else
                    appendForElements $"    /// {element.Description}
    let {elementName} = EltWithChildBuilder(\"{element.Name}\")
"

            System.IO.File.WriteAllText("./Fun.Blazor/DslElementBuilder.generated.fs", 
                "namespace Fun.Blazor"
                + "\n"
                + "\n"
                + globalAttrsSb.ToString()
                + "\n"
                + elementBuilderSb.ToString()
                + "\n"
                + elementsSb.ToString()
            )
        )
    }
    runIfOnlySpecified
}


tryPrintPipelineCommandHelp ()
