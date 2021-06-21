[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.QuickStart.BasicUsageDemo

open Fun.Blazor

let private demo1 =
    html.div [
        attr.styles [
            style.margin 10
        ]
        attr.childContent [
            html.text "Hello baisc usage1"

        ]
    ]

let private demo2 =
    html.div [
        attr.styles [
            style.margin 10
        ]
        html.text "Hello baisc usage 2"
    ]

let basicUsageDemo =
    html.div [
        demo1
        demo2
    ]
