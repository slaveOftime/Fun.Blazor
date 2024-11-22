namespace Fun.Blazor.Docs.Server

open FSharp.Control
open MudBlazor
open Fun.Result
open Fun.Blazor
open Fun.Htmx


type HtmxSseStockDemo() =
    inherit HxSseComponent()

    static member val ProgressEventName = "event-progress"

    override this.GetNodes() = taskSeq {
        this.EventName <- HtmxSseStockDemo.ProgressEventName
        MudText'' {
            Color Color.Warning
            "Event started"
        }


        let endIndex = 10

        let startIndex =
            match this.LastEventId with
            | null -> 0
            | INT32 x -> if x >= endIndex then 0 else x + 1
            | _ -> 0

        for productId in startIndex..endIndex do
            this.EventId <- string productId
            this.EventName <- HxSseComponent.NewNodeEventName
            div {
                "stock: "
                MudChip'' {
                    Variant Variant.Filled
                    Color(if productId % 2 = 0 then Color.Primary else Color.Secondary)
                    "Product #"
                    productId
                    ": "
                    System.Random.Shared.Next(100, 200)
                    "$"
                }
            }
            do! Async.Sleep 1000


        this.EventId <- null
        this.EventName <- HtmxSseStockDemo.ProgressEventName
        MudText'' {
            Color Color.Warning
            "Event finished"
        }
    }


type HtmxDemo =
    static member Create() = MudPaper'' {
        style {
            padding 12
            margin 20
        }
        section {
            hxSseConnectComp (QueryBuilder<HtmxSseStockDemo>())
            hxSseCloseOnComp
            "Htmx SSE demo: supposed to display the latest stock info"
            div { hxSseSwapOnComp }
            div { 
                hxSseSwap HtmxSseStockDemo.ProgressEventName
                "Stock status"
            }
        }
        MudDivider'' { style { margin 20 0 } }
        section {
            "Htmx SSE demo: supposed to display a list of all stock info"
            html.sse<HtmxSseStockDemo> (attrs = domAttr { hxSwap_afterbegin })
        }
    }
