#r "nuget: FSharp.Data"

open System
open FSharp.Data

type HtmxReference = HtmlProvider<"https://htmx.org/reference/">

let references = HtmxReference.GetSample()

references.Tables.``#Event Reference``.Rows
|> Seq.iter (fun row ->
    let name = row.Event.Substring(row.Event.IndexOf ":" + 1)
    let key = name.Replace(":", "_")
    let name =
        name
        |> Seq.mapi (fun i c ->
            match Char.IsUpper c, i = 0 with
            | true, true -> [Char.ToLower c]
            | true, false -> ['-'; Char.ToLower c]
            | _ -> [c]
        )
        |> Seq.concat
        |> String.Concat
    printfn $"""/// {row.Description}
    [<Literal>]
    let {key} = "{name}"
"""
)