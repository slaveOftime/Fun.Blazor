[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.InjectDemo

open System
open FSharp.Control.Reactive
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components

//                                        Here we provide a key
//                                        If we do not provide a key, then every time we call externalDemo1 we will create a new component
//                                        And its internal state will be erased
let externalDemo1 extenalX = html.inject ("externalDemo1", fun (hook: IComponentHook) ->
    // Below code will only be executed once
    // No matter how extenalX is changed it will not trigger rerender

    let store1 = hook.UseStore 10
    
    hook.OnFirstAfterRender.Add (fun () ->
        TimeSpan.FromSeconds 1.
        |> Observable.interval
        |> Observable.subscribe (fun _ -> store1.Publish ((+) 1))
        |> hook.AddDispose
    )

    MudPaper'(){
        Styles [ style.padding 10 ]
        childContent [
            MudText'.create "externalDemo1"
            spaceV3
            html.div $"extenalX = %d{extenalX}" // It will never change
            spaceV2
            html.watch (store1, fun s1 ->
                html.div $"Store: {s1}"
            )
        ]
    })


// html.inject is mainly to provide the services defined in asp.net core DI
// and the IComponentHook etc.
// You can inject multiple services with tuple
let injectDemo = html.inject (fun (hook: IComponentHook, snackbar: ISnackbar) ->
    let store = hook.UseStore 0

    hook.OnFirstAfterRender.Add (fun () ->
        TimeSpan.FromSeconds 3.
        |> Observable.interval
        |> Observable.subscribe (fun _ ->
            if store.Current > 2 then
                snackbar.Add ($"Current value is {store.Current}", Severity.Info) |> ignore
            store.Publish ((+) 1))
        |> hook.AddDispose
    )

    MudPaper'(){
        Styles [ style.padding 15 ]
        childContent [
            spaceV3
            html.watch (store, fun s1 -> [
                // Because we specified a key for externalDemo1 when we define it
                // So we will not recreate a new blazor component every time and its state will not be erased
                externalDemo1 s1
                spaceV2
                MudText'.create $"Store will be updated here: {s1}"
            ])
            // Because these code will only be execute one time, so below string will not change
            MudText'.create $"Store will not be updated here: {store.Current}"
        ]
    })
