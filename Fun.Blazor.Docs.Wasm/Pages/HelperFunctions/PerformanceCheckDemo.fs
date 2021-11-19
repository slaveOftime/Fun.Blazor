[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.PerformanceCheckDemo

open System.Diagnostics
open FSharp.Data.Adaptive
open Microsoft.Extensions.Logging
open MudBlazor
open Fun.Blazor
open Fun.Blazor.DslCE
open Bolero


let bigListCreation = html.inject <| fun (hook: IComponentHook, loggerFac: ILoggerFactory) ->
    let logger = loggerFac.CreateLogger("PerformanceCheckDemo")
    let watch = Stopwatch.StartNew()
    let lists = cval []


    logger.LogDebug $"bigListCreation component start creating: {watch.ElapsedMilliseconds}"

    hook.OnAfterRender.Add <| fun _ ->
        logger.LogDebug $"bigListCreation component rendered {watch.ElapsedMilliseconds}"


    div(){
        styles [ style.padding 10 ]
        childContent [
            adaptiview(){
                let! items = lists
                logger.LogDebug $"List changed"

                MudButton'(){
                    Variant Variant.Filled
                    OnClick (fun _ -> lists.Publish [1..10_000])
                    childContent "Create list"
                }
                //html.bolero (
                //    Html.div [
                //        Html.attr.style "max-height: 100; overflow-y: auto"
                //    ] [
                //        for item in items do
                //            Html.div [] [ Html.text $"item {item}" ]
                //    ]
                //)
                div(){
                    styles [ style.maxHeight 100; style.overflowYAuto ]
                    childContent [
                        for item in items do
                            html.div $"item {item}"
                    ]
                }
            }
        ]
    }


let performanceCheckDemo =
    html.div [
        bigListCreation
    ]

