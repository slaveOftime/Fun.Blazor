[<AutoOpen>]
module Fun.Blazor.DslAdaptive

open System.Runtime.CompilerServices
open FSharp.Data.Adaptive
open Bolero.Html
open Fun.Blazor


type AdaptiveBuilder() =
    inherit AListBuilder()

    member _.Run (x: alist<IFunBlazorNode>) =
        html.bolero 
            (Bolero.Node.BlazorComponent<AdaptiveComponent>
                ([
                    "Node" => x
                ]
                ,[]))

    member _.Delay (fn: unit -> alist<_>) = fn()

    member _.Combine (c1, c2) = AList.append c1 c2

    member _.Yield x = AList.single x

    member _.Zero () = AList.empty



[<Extension>]
type Extensions =
    [<Extension>]
    static member Publish (this: cval<'T>, x: 'T) = transact(fun () -> this.Value <- x)
    
    [<Extension>]
    static member Publish (this: cval<'T>, fn: 'T -> 'T) = transact(fun () -> this.Value <- fn this.Value)
    
    [<Extension>]
    static member AsAVal (this: cval<'T>) =
        let setValue x = transact(fun () -> this.Value <- x)
        this |> AVal.map (fun x -> x, setValue)


[<RequireQualifiedAccess>]
module Adapt =
    let withSetter (this: cval<'T>) =
        let setValue x = transact(fun () -> this.Value <- x)
        this |> AVal.map (fun x -> x, setValue)


let adapt = AdaptiveBuilder()
