// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.SimpleInjectionDemo

open System
open FSharp.Control.Reactive
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Docs.Controls

// Here we provide a key
// If we do not provide a key, then every time we call this we will create a new component
// And its internal state will be erased
// Be careful when you provided a key: because when define things like: let entry arg1 arg2 = ....
// If the arg1 and arg2 are reference type then it should be ok, but if it is value type then it will not take effect when you change arg1/arg2.
// For example, if you define lambda like onChanged as arguments, then you may get unexpected result.
let entry =
    html.inject (
        "externalDemo1",
        fun (hook: IComponentHook) ->
            let mutable count = 0

            hook.OnFirstAfterRender.Add(fun () ->
                TimeSpan.FromSeconds 1.
                |> Observable.interval
                |> Observable.subscribe (fun _ -> 
                    count <- count + 1
                    hook.StateHasChanged()
                )
                |> hook.AddDispose
            )

            MudPaper'' {
                style { padding 10 }
                childContent [|
                    MudText'.create "externalDemo1"
                    spaceV3
                    div { "extenalX = %d{extenalX}" }
                    spaceV2
                    div { $"Count = {count}" }
                |]
            }
    )
