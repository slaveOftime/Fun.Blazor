[<AutoOpen>]
module Fun.Blazor.Utils

open System
open Bolero


let inline (!!) (node: Attr) = FelizNode.create node


let internal _childContentKey = "_childContent"


let internal getAttrsAndChildren (attrs: Attr seq) =
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


type internal Util =
    static member inline asString(x: string): string = x
    static member inline asString(x: int): string = string x
    static member inline asString(x: int option): string = match x with Some x -> Util.asString x | None -> ""
    static member inline asString(x: float): string = string x
    static member inline asString(x: Guid): string = string x
