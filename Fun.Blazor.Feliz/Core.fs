namespace Fun.Blazor

open FSharp.Data.Adaptive
open Bolero


/// Little wrapper node for feliz style DSL
[<Struct>]
type FelizNode<'T> =
    { Attrs: Attr seq }

    static member concat (nodes: FelizNode<'T> seq) = nodes |> Seq.map (fun x -> x.Attrs) |> Seq.concat |> Seq.toList

    static member create x: FelizNode<'T> = { Attrs = [x] }
    static member create x: FelizNode<'T> = { Attrs = x }

    static member create (name, value: IStore<'V>) =
        FelizNode<'T>.create [
            name => value.Current
            Bolero.Html.attr.callback<'V> $"{name}Changed" (fun (x: 'V) -> value.Publish x)
        ]

    static member create (name, value: cval<'V>) =
        FelizNode<'T>.create [
            name => AVal.force value
            Bolero.Html.attr.callback<'V> $"{name}Changed" (fun x-> transact(fun _ -> value.Value <- x))
        ]

    static member create (name, (value: 'V, fn)) =
        FelizNode<'T>.create [
            name => value
            Bolero.Html.attr.callback<'V> $"{name}Changed" fn
        ]
