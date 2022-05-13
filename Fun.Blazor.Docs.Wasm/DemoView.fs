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


let demoView (demo: Demo) =
    html.inject (
        demo,
        fun (hook: IComponentHook, js: IJSRuntime) ->
            let showCode = cval false

            MudPaper'() {
                style { padding 20 }
                Elevation 5
                demo.View
                div {
                    style {
                        displayFlex
                        alignItemsCenter
                        justifyContentCenter
                    }
                    adaptiview () {
                        let! showCode, setShowCode = showCode.WithSetter()
                        MudButton'() {
                            OnClick(fun _ -> 
                                task {
                                    setShowCode (not showCode)
                                    //do! js.highlightCode()
                                    do! Task.Delay 500
                                    do! js.highlightCode()
                                } |> ignore
                            )
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
                            div {
                                style {backgroundColor "#011627"; padding 5 }
                                article {
                                    html.raw sourceCode
                                }
                            }
                }
            }
    )
