// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.SimpleInjectionDemo

open System
open FSharp.Control.Reactive
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Docs.Wasm

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
            // Below code will only be executed once
            // No matter how extenalX is changed, it will not trigger rerender

            let store1 = hook.UseStore 10

            hook.OnFirstAfterRender.Add(fun () ->
                TimeSpan.FromSeconds 1.
                |> Observable.interval
                |> Observable.subscribe (fun _ -> store1.Publish((+) 1))
                |> hook.AddDispose
            )

            MudPaper'() {
                style { padding 10 }
                childContent [
                    MudText'.create "externalDemo1"
                    spaceV3
                    div { "extenalX = %d{extenalX}" }
                    spaceV2
                    html.watch (store1, (fun s1 -> div.create $"Store: {s1}"))
                ]
            }
    )
