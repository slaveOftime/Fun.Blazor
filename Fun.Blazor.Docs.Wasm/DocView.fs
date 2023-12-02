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
open Fun.Blazor.Docs.Wasm


let docView (doc: DocBrief) =
    html.inject (
        doc,
        fun (hook: IComponentHook, js: IJSRuntime) ->
            adaptiview () {
                let! lang = hook.Lang

                let segments =
                    doc.LangSegments
                    |> Map.tryFind lang
                    |> function
                        | None -> doc.LangSegments |> Map.tryFind "en"
                        | Some x -> Some x
                    |> Option.defaultValue []

                let langStr = if doc.LangSegments |> Map.containsKey lang then lang else "en"

                let docSegmentsCount =
                    segments
                    |> Seq.filter (
                        function
                        | Segment.Html _ -> true
                        | _ -> false
                    )
                    |> Seq.length

                let docSegmentLoadedCount = cval 0


                hook.SetPrerenderStore(fun _ ->
                    for segment in segments do
                        match segment with
                        | Segment.Html key -> hook.SetDataToPrerenderStore(hook.MakeDocHtmlKey(langStr, key), hook.DocHtml(langStr, key).Value)
                        | _ -> ()
                )

                hook.OnFirstAfterRender.Add(fun () ->
                    let mutable isCodeHighlighted = false
                    hook.AddDisposes [
                        docSegmentLoadedCount.AddInstantCallback(
                            function
                            | x when x >= docSegmentsCount && not isCodeHighlighted ->
                                task {
                                    do! Task.Delay 100
                                    do! js.highlightCode ()
                                    isCodeHighlighted <- true
                                }
                                |> ignore
                            | _ -> ()
                        )
                    ]
                )


                MudContainer'() {
                    for segment in segments do
                        match segment with
                        | Segment.Demo key -> demos |> Map.tryFind key |> Option.map demoView |> Option.defaultValue notFound

                        | Segment.Html key ->
                            adaptiview () {
                                match! hook.GetOrLoadDocHtml(langStr, key, "cacheKey=" + string doc.LastModified.Ticks) with
                                | LoadingState.NotStartYet -> notFound
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
                }
            }
    )
