[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.ReactiveDemo

open System
open FSharp.Control.Reactive
open Fun.Blazor
open MudBlazor

let reactiveDemo = html.inject (fun (hook: IComponentHook) ->
    let store1 = hook.UseStore 1
    let store2 = hook.UseStore 100

    hook.OnFirstAfterRender.Add (fun () ->
        TimeSpan.FromSeconds 1.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> store1.Publish ((+) 1))
        |> hook.AddDispose

        TimeSpan.FromSeconds 3.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> store2.Publish ((+) 1))
        |> hook.AddDispose
    )
    
    MudPaper'(){
        Styles [ style.padding 20 ]
        childContent [
            html.watch2 (store1, store2, fun s1 s2 -> [
                MudText'(){
                    Typo Typo.subtitle1
                    childContent $"Store1 {s1}"
                }
                MudText'(){
                    Typo Typo.subtitle1
                    childContent $"Store2 {s2}"
                }
            ])
        ]
    })
