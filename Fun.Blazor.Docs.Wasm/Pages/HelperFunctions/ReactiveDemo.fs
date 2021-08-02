[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.ReactiveDemo

open System
open FSharp.Data.Adaptive
open FSharp.Control.Reactive
open Fun.Blazor
open MudBlazor

let reactiveDemo = html.inject (fun (hook: IComponentHook) ->
    let store1 = cval 1
    let isVisible = hook.UseStore false

    hook.OnFirstAfterRender.Add (fun () ->
        TimeSpan.FromSeconds 1.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> store1.Publish ((+) 1))
        |> hook.AddDispose
    )
    
    MudPaper'(){
        Styles [ style.padding 20 ]
        childContent [
            reactive {
                let! s1 = store1
                MudText'(){
                    Typo Typo.subtitle1
                    childContent $"Store1 {s1}"
                }
                MudButton'(){
                    OnClick (fun _ -> isVisible.Publish true)
                    childContent "Open Dialog"
                }
                reactive {
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
                                    MudButton'(){
                                        OnClick (fun _ -> isVisible.Publish false)
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
