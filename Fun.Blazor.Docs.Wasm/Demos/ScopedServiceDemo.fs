// hot-reload
namespace Fun.Blazor.Docs.Wasm.Demos

open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open MudBlazor
open Fun.Blazor
open Fun.Blazor.Docs.Controls


type ScopedDemoService() =
    member val Count = cval 0 with get, set


module ScopedServiceDemo =

    let entry =
        html.inject (fun (demo1: ScopedDemoService) ->
            let view (demo: ScopedDemoService) msg =
                adaptiview () {
                    let! count, setCount = demo.Count.WithSetter()
                    html.fragment [|
                        div.create [|
                            button {
                                onclick (fun _ -> setCount (count + 1))
                                "Increase"
                            }
                            div { $"{msg}: {count}" }
                        |]
                        spaceV2
                    |]
                }

            MudPaper'' {
                style { padding 10 }
                Elevation 2
                childContent [|
                    view demo1 "Count from normal scope"
                    html.scoped [|
                        html.inject (fun (hook: IComponentHook) -> view (hook.ScopedServiceProvider.GetService<ScopedDemoService>()) "Count from scope1")
                        html.inject (fun (hook: IComponentHook) -> view (hook.ScopedServiceProvider.GetService<ScopedDemoService>()) "Count from scope1")
                    |]
                    html.scoped [|
                        html.inject (fun (hook: IComponentHook) -> view (hook.ScopedServiceProvider.GetService<ScopedDemoService>()) "Count from scope2")
                    |]
                |]
            }
        )
