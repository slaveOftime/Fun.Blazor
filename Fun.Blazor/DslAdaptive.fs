[<AutoOpen>]
module Fun.Blazor.DslAdaptive

open System
open System.Collections.Generic
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


let adaptiveComp = AaptiveBuilder()

