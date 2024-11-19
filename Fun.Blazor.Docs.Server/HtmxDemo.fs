namespace Fun.Blazor.Docs.Server

open FSharp.Control
open MudBlazor
open Fun.Blazor
open Fun.Htmx


type HtmxSseStockDemo() =
    inherit HxSseComponent()

    override _.GetNodes() = taskSeq {
        for productId in 1..5 do
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
        }
        MudDivider'' { style { margin 20 0 } }
        section {
            "Htmx SSE demo: supposed to display a list of all stock info"
            html.sse<HtmxSseStockDemo> (attrs = domAttr { hxSwap_afterbegin })
        }
    }
