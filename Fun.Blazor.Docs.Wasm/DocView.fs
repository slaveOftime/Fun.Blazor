// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DocView

open FSharp.Data.Adaptive
open Fun.Result
open Fun.Blazor
open MudBlazor
open Fun.Blazor.Docs.Controls


let docView (doc: DocBrief) =
    html.inject (
        doc,
        fun (hook: IComponentHook) ->
            let langStr = "en"
            let segments = doc.LangSegments |> Map.tryFind langStr |> Option.defaultValue []

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
