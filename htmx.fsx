#r "nuget: FSharp.Data"

open FSharp.Data

type HtmxReference = HtmlProvider<"https://htmx.org/reference/">

let references = HtmxReference.GetSample()

references.Tables.``#Event Reference``.Rows
|> Seq.iter (fun row ->
    let name = row.Event.Split(":")[1]
    printfn $"""/// {row.Description}
let {name} = "{name}"
"""
)