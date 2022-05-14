[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Utils

open System
open System.Net


let private isNameEqualPath (name: string) (path: string) = name.Equals(WebUtility.UrlDecode path, StringComparison.OrdinalIgnoreCase)


let rec findDoc (docs: DocTreeNode list) (paths: string list) =
    match paths with
    | [] -> None
    | [ p ] ->
        docs
        |> Seq.tryPick (
            function
            | DocTreeNode.Category (doc, _, _)
            | DocTreeNode.Doc doc when isNameEqualPath doc.Name p -> Some doc
            | _ -> None
        )
    | p :: paths ->
        docs
        |> Seq.tryPick (
            function
            | DocTreeNode.Category (doc, docs, childs) when isNameEqualPath doc.Name p ->
                match paths with
                | [ p ] ->
                    let doc = docs |> Seq.tryFind (fun x -> isNameEqualPath x.Name p)
                    if doc.IsNone then findDoc childs paths else doc
                | _ -> findDoc childs paths
            | _ -> None
        )
