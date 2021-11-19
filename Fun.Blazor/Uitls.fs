[<AutoOpen>]
module Fun.Blazor.Uitls

open System
open System.Reactive.Linq
open System.Threading.Tasks
open Bolero


let inline (!!) (node: Attr) = FelizNode.create node


let internal _childContentKey = "_childContent"


let getAttrsAndChildren (attrs: Attr seq) =
    attrs
    |> Seq.indexed
    |> Seq.tryPick (fun (i, attr) ->
        match attr with
        | Attr.Attr (name, child) when name = _childContentKey -> Some (i, child)
        | _ -> None)
    |> function
        | None -> Seq.toList attrs, []
        | Some (index, child) ->
            let childContent = child |> unbox<Node seq> |> Seq.toList
            let attrs = attrs |> Seq.removeAt index |> Seq.toList
            attrs, childContent


module Observable =
    let ofTask (x: Task<_>) = Observable.FromAsync (fun (token: Threading.CancellationToken) -> x)
