[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.AdaptiveDemo

open System
open FSharp.Data.Adaptive
open FSharp.Control.Reactive
open Fun.Blazor
open MudBlazor

let adaptiveDemo1 = html.inject (fun (hook: IComponentHook) ->
    let store1 = cval 0
    let store2 = cval 0
    let store3 = cval 0
    let store4 = cval Guid.Empty
    let isVisible = cval false

    hook.OnFirstAfterRender.Add (fun () ->
        TimeSpan.FromSeconds 1.
        |> Observable.interval
        |> Observable.subscribe (fun _ ->
            // With this we can do batch update
            transact(fun () ->
                store1.Value <- store1.Value + 1
                store2.Value <- store2.Value + 1
                store3.Value <- store3.Value + 1
                store4.Value <- Guid.NewGuid()
            )
        )
        |> hook.AddDispose

        TimeSpan.FromSeconds 2.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> store2.Publish ((+) 1))
        |> hook.AddDispose
    )
    
    MudPaper'(){
        Styles [ style.padding 20 ]
        childContent [
            adapt{
                // let! will let the reactive to listen to related source(IStore<_>, aval<_>) changes, and trigger render accordingly
                let! s1 = store1
                let! s2 = store2
                let! s4 = store4
                MudText'.create $"Store1 {s1}"
                MudText'.create $"Store4 {s4}"
                if (s1 > 5  && s1 < 10) || s2 > 15  then
                    adapt{
                        let! s3 = store3
                        MudText'.create $"Store2 {s2}"
                        MudText'.create $"Store3 {s3}"
                    }
                for i in 0..s1 do
                    if i % 2 = 0 then
                        adapt {
                            let! s3 = store3
                            MudText'.create $"Seq {i} {s3}"
                        }
                MudButton'(){
                    OnClick (fun _ -> isVisible.Publish true)
                    childContent "Open Dialog"
                }
                adapt{
                    let! isVisible' = isVisible
                    MudOverlay'(){
                        Visible isVisible'
                        DarkBackground true
                        childContent [
                            MudPaper'(){
                                Styles [ style.padding 10; style.width 200; style.height 80 ]
                                childContent [
                                    MudText'.create $"Store1 {s1}"
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


/// With this we can have nicer code than html.watch when you got a lot of changing data and their pripority is same
let adaptiveDemo2 = html.inject <| fun (hook: IComponentHook, store: IShareStore) ->
    let number1 = cval 1
    let number2, setNumber2 = hook.UseAVal (store.Create("number-share-1", 1))
    let number3 = hook.UseAVal (0L, Observable.interval (TimeSpan.FromSeconds 2))
    let number4 = hook.UseAVal (0L, Observable.interval (TimeSpan.FromSeconds 3))
    let number5 = hook.UseAVal (0L, Observable.interval (TimeSpan.FromSeconds 4))
    let number6 = hook.UseAVal (0L, Observable.interval (TimeSpan.FromSeconds 5))

    adapt{
        let! n1 = number1
        let! n2 = number2

        html.div $"Number1 = {n1}"
        html.div $"Number2 = {n2}"
        adapt{
            let! n3 = number3
            let! n4 = number4
            let! n5 = number5
            let! n6 = number6
            html.div $"Number3 = {n3}; Number4 = {n4}; Number5 = {n5}; Number6 = {n6}"
        }
        MudButtonGroup'(){
            Variant Variant.Filled
            childContent [
                MudButton'(){
                    OnClick (fun _ -> number1.Publish ((+) 1))
                    childContent "Increase Number1"
                }
                MudButton'(){
                    OnClick (fun _ -> setNumber2 (n2 + 1))
                    childContent "Increase Number2"
                }
            ]
        }
    }

let adaptiveDemo =
    html.div [
        adaptiveDemo2
        adaptiveDemo1
    ]