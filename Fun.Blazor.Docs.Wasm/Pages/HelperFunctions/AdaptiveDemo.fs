[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.AdaptiveDemo

open System
open FSharp.Data.Adaptive
open FSharp.Control.Reactive
open Fun.Blazor
open MudBlazor

let adaptiveDemo = html.inject (fun (hook: IComponentHook) ->
    let store1 = cval 10
    let store2 = cval 100
    let store3 = cval "Hi world"
    let store4 = hook.UseStore 1000
    let isVisible = cval false

    hook.OnFirstAfterRender.Add (fun () ->
        TimeSpan.FromSeconds 3.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> store1.Publish ((+) 1))
        |> hook.AddDispose

        TimeSpan.FromSeconds 1.
        |> Observable.interval
        |> Observable.subscribe (fun _ ->
            store2.Publish ((+) 1)
            store4.Publish ((+) 1))
        |> hook.AddDispose
    )
    
    MudPaper'(){
        Styles [ style.padding 20 ]
        childContent [
            MudAlert'(){
                Severity Severity.Info
                childContent "Actually the reactive CE is same with the adaptiveComp CE. Under the hook it is powered by FSharp.Data.Adaptive"
            }
            adaptiveComp {
                let! s1 = store1
                let! s2 = store2
                let! s3 = store3
                let! s4 = store4
                if s1 > 11 then
                    MudText'(){
                        Typo Typo.subtitle1
                        childContent $"Store1 {s1}"
                    }
                MudText'(){
                    Typo Typo.subtitle1
                    childContent $"Store2 {s2}"
                }
                MudText'(){
                    Typo Typo.subtitle1
                    childContent $"Store3 {s3}"
                }
                MudText'(){
                    Typo Typo.subtitle1
                    childContent $"Store4 {s4}"
                }
                MudButton'(){
                    OnClick (fun _ -> transact (fun _ -> isVisible.Value <- true))
                    childContent "Open Dialog"
                }
                adaptiveComp {
                    let! store1 = store1
                    let! isVisible' = isVisible
                    MudOverlay'(){
                        Visible isVisible'
                        childContent [
                            MudPaper'(){
                                Styles [ style.padding 10 ]
                                childContent [
                                    MudText'(){
                                        Typo Typo.h5
                                        childContent "Cool right?"
                                    }
                                    MudText'.create $"Store1: {s1} when open dialog"
                                    MudText'.create $"Store1: {store1}"
                                    MudButton'(){
                                        OnClick (fun _ -> transact (fun _ -> isVisible.Value <- false))
                                        Variant Variant.Filled
                                        childContent "Close"
                                    }
                                ]
                            }
                        ]
                    }
                }
            }
        ]
    })
