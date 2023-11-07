#r "nuget: FSharp.Data"

open FSharp.Data

type HtmxReference = HtmlProvider<"https://htmx.org/reference/">

let references = HtmxReference.GetSample()

references.Tables.``#Event Reference``.Rows
|> Seq.iter (fun row ->
    let name = row.Event.Substring(row.Event.IndexOf ":" + 1)
    let key = name.Replace(":", "_")
    printfn $"""/// {row.Description}
[<Literal>]
let {key} = "{name}"
"""
)