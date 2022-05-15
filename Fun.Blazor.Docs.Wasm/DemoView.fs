// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoView

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.JSInterop
open Fun.Result
open Fun.Blazor
open MudBlazor
open Fun.Blazor.Docs.Wasm


let demoView (demo: Demo) =
    html.inject (
        demo,
        fun (hook: IComponentHook, js: IJSRuntime) ->
            let showCode = cval false
            let codeLoadedCount = cval 0


            hook.OnFirstAfterRender.Add(fun () ->
                hook.AddDisposes [
                    codeLoadedCount.AddInstantCallback(fun _ ->
                        task {
                            do! Task.Delay 100
                            do! js.highlightCode ()
                        }
                        |> ignore
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
                            StartIcon(if showCode then Icons.Filled.HideSource else Icons.Filled.Source)
                            if showCode then "Hide source code" else "Show source code"
                        }
                    }
                }
                adaptiview () {
                    match! showCode with
                    | false -> ()
                    | true ->
                        match! hook.GetOrLoadDemoCodeHtml demo.Source with
                        | LoadingState.NotStartYet
                        | LoadingState.Loading -> linearProgress
                        | LoadingState.Loaded sourceCode
                        | LoadingState.Reloading sourceCode ->
                            codeLoadedCount.Publish((+) 1)
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
