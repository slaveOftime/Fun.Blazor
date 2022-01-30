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
//                                        Be careful when you provided a key: because the changes of externalX will not be used in the component, only the first one will be used
//                                        so if you have lambda like onChanged, then you may get unexpected result.
let externalDemo1 extenalX =
    html.inject (
        "externalDemo1",
        fun (hook: IComponentHook) ->
            // Below code will only be executed once
            // No matter how extenalX is changed it will not trigger rerender

            let store1 = hook.UseStore 10

            hook.OnFirstAfterRender.Add(fun () ->
                TimeSpan.FromSeconds 1.
                |> Observable.interval
                |> Observable.subscribe (fun _ -> store1.Publish((+) 1))
                |> hook.AddDispose
            )

            MudPaper' {
                Styles [ styl.padding 10 ]
                MudText' { "externalDemo1" }
                spaceV3
                div { $"extenalX = %d{extenalX}" }
                spaceV2
                html.watch (store1, (fun s1 -> div { $"Store: {s1}" }))
            }
    )


// html.inject is mainly to provide the services defined in asp.net core DI
// and the IComponentHook etc.
// You can inject multiple services with tuple
let injectDemo =
    html.inject (fun (hook: IComponentHook, snackbar: ISnackbar) ->
        let store = hook.UseStore 0

        hook.OnFirstAfterRender.Add(fun () ->
            TimeSpan.FromSeconds 3.
            |> Observable.interval
            |> Observable.subscribe (fun _ ->
                if store.Current > 2 then
                    snackbar.Add($"Current value is {store.Current}", Severity.Info) |> ignore
                store.Publish((+) 1)
            )
            |> hook.AddDispose
        )

        MudPaper' {
            Styles [ styl.padding 15 ]
            spaceV3
            html.watch (
                store,
                fun s1 ->
                    [
                        // Because we specified a key for externalDemo1 when we define it
                        // So we will not recreate a new blazor component every time and its state will not be erased
                        externalDemo1 s1
                        spaceV2
                        MudText' { $"Store will be updated here: {s1}" }
                    ]
            )
            // Because these code will only be execute one time, so below string will not change
            MudText' { $"Store will not be updated here: {store.Current}" }
        }
    )
