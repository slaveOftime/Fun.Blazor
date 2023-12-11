#r "nuget: FSharp.Data"
#r "nuget: Fun.Build"

open System
open FSharp.Data
open Fun.Build

type HtmxReference = HtmlProvider<"https://htmx.org/reference/">
type HtmlAriaAttributes = HtmlProvider<"https://developer.mozilla.org/docs/Web/Accessibility/ARIA/Attributes">
type HtmlEvents = HtmlProvider<"https://developer.mozilla.org/en-US/docs/Web/Events">


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

pipeline "event" {
    stage "" {
        run (fun _ ->
            let lists = System.Collections.Generic.HashSet<string>()
            for value in HtmlEvents.GetSample().Lists.``Event listing``.Values do
                let index = value.LastIndexOf " event"
                if index > 0 then
                    let name = value.Substring(0, index)
                    if lists.Contains name |> not then
                        lists.Add name |> ignore
                        printfn
                            $"""        [<CustomOperation("on{name}")>]
        member inline _.on{name}([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("on{name}" => js)
                        """
        )
    }
}

tryPrintPipelineCommandHelp ()
