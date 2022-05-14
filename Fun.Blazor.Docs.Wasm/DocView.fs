// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DocView

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.JSInterop
open Fun.Result
open Fun.Blazor
open MudBlazor
open Fun.Blazor.Docs.Controls


let docView (doc: DocBrief) =
    html.inject (
        doc,
        fun (hook: IComponentHook, js: IJSRuntime) ->
            let langStr = "en"
            let segments = doc.LangSegments |> Map.tryFind langStr |> Option.defaultValue []
            let docSegmentLoadedCount = cval 0


            hook.OnFirstAfterRender.Add(fun () ->
                hook.AddDisposes [
                    docSegmentLoadedCount.AddInstantCallback(fun _ ->
                        task {
                            do! Task.Delay 100
                            do! js.highlightCode ()
                        }
                        |> ignore
                    )
                ]
            )


            MudContainer'() {
                childContent [
                    for segment in segments do
                        match segment with
                        | Segment.Demo key -> demos |> Map.tryFind key |> Option.map demoView |> Option.defaultValue notFound

                        | Segment.Html key ->
                            adaptiview () {
                                match! hook.GetOrLoadDocHtml(langStr, key, "cacheKey=" + string doc.LastModified.Ticks) with
                                | LoadingState.NotStartYet
                                | LoadingState.Loading -> linearProgress
                                | LoadingState.Loaded docHtml
                                | LoadingState.Reloading docHtml ->
                                    docSegmentLoadedCount.Publish((+) 1)
                                    div {
                                        article {
                                            class' "markdown-body"
                                            html.raw docHtml
                                        }
                                    }
                            }
                        spaceV4
                ]
            }
    )
