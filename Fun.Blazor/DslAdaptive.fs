[<AutoOpen>]
module Fun.Blazor.DslAdaptive

open System
open System.Collections.Generic
open System.Runtime.CompilerServices
open FSharp.Data.Adaptive
open Bolero.Html
open Fun.Blazor


type AaptiveBuilder() =
    inherit AValBuilder()

    let subscriptions = List<IDisposable>()


    member _.Run (x: aval<IFunBlazorNode>) =
        html.bolero 
            (Bolero.Node.BlazorComponent<AdaptiveComponent>
                ([
                    "RenderFn" => x
                    "OnDisposeFn" => fun () -> subscriptions |> Seq.iter (fun d -> d.Dispose())
                ]
                ,[]))


    member _.Bind (store: IStore<'T1>, fn: 'T1 -> aval<'T2>) =
        let data = AVal.init store.Current

        store.Observable.Subscribe(fun x -> transact(fun () -> data.Value <- x))
        |> subscriptions.Add
        
        data |> AVal.bind fn


[<Extension>]
type Extensions =
    [<Extension>]
    static member Publish (this: cval<'T>, x: 'T) = transact(fun () -> this.Value <- x)
    
    [<Extension>]
    static member Publish (this: cval<'T>, fn: 'T -> 'T) = transact(fun () -> this.Value <- fn this.Value)


let adaptiveComp = AaptiveBuilder()

