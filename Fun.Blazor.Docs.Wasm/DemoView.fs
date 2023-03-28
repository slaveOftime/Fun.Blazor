// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoView

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.JSInterop
open Fun.Result
open Fun.Blazor
open MudBlazor
open Fun.Blazor.Docs.Controls
open Fun.Blazor.Docs.Wasm


let demoView (demo: Demo) =
    html.inject (
        demo,
        fun (hook: IComponentHook, js: IJSRuntime) ->
            let codeHtml = hook.GetOrLoadDemoCodeHtml demo.Source
            let showCode = cval false

            let shouldHightLight =
                adaptive {
                    let! codeHtml = codeHtml
                    let! showCode = showCode
                    return codeHtml.Value.IsSome && showCode
                }


            hook.OnFirstAfterRender.Add(fun () ->
                hook.AddDisposes [
                    shouldHightLight.AddInstantCallback(
                        function
                        | true ->
                            task {
                                do! Task.Delay 100
                                do! js.highlightCode ()
                            }
                            |> ignore
                        | _ -> ()
                    )
                ]
            )


            MudPaper'() {
                style { padding 20 }
                Elevation 5
                demo.View
                spaceV2
                div {
                    style {
                        displayFlex
                        alignItemsCenter
                        justifyContentCenter
                    }
                    adaptiview () {
                        let! showCode, setShowCode = showCode.WithSetter()
                        MudButton'() {
                            OnClick(fun _ -> setShowCode (not showCode))
                            StartIcon(if showCode then Icons.Material.Filled.HideSource else Icons.Material.Filled.Source)
                            if showCode then "Hide source code" else "Show source code"
                        }
                    }
                }
                adaptiview () {
                    match! showCode with
                    | false -> ()
                    | true ->
                        match! codeHtml with
                        | LoadingState.NotStartYet -> notFound
                        | LoadingState.Loading -> linearProgress
                        | LoadingState.Loaded sourceCode
                        | LoadingState.Reloading sourceCode ->
                            spaceV2
                            div {
                                style {
                                    backgroundColor "#151522"
                                    padding 5
                                }
                                article { html.raw sourceCode }
                            }
                }
            }
    )
