﻿[<AutoOpen>]
module Fun.Blazor.DslAdaptive

open System.Runtime.CompilerServices
open FSharp.Data.Adaptive
open Bolero.Html
open Fun.Blazor



/// This will generate an alist<IFunBlazorNode> as a Node parameter.
/// When the isStatic is not set to true, every time when you call this it will trigger OnParametersSet,
/// so when you write code like below:
/// ```fsharp
///     adaptiview(){
///         1. change hanpend
///         adaptiview(){
///             2. this will init again, so if you want to keep the state of x you should move the definition upper or set isStatic to true
///             let! x = cval 123
///         }
///     }
/// ```
type AdaptiviewBuilder(?key: obj, ?isStatic: bool) =
    inherit AListBuilder()

    member _.Run (x: alist<IFunBlazorNode>) =
        html.bolero 
            (Bolero.Node.BlazorComponent<AdaptiveComponent>
                ([
                    "Node" => x
                    match isStatic with
                    | Some true -> "IsStatic" => true
                    | _ -> ()
                    match key with
                    | Some key -> Bolero.Key key
                    | None -> ()
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


type adaptiview = AdaptiviewBuilder


[<System.Obsolete "Use adaptiview for explicity instead">]
let adapt = AdaptiviewBuilder()