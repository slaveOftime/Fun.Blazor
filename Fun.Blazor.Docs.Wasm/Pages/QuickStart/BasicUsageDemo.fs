[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.QuickStart.BasicUsageDemo

open Fun.Blazor

let private demo1 =
    div {
        style { margin 10 }
        "Hello baisc usage1"
    }

let private demo2 =
    div {
        style { margin 10 }
        "Hello baisc usage 2"
    }

let basicUsageDemo =
    div {
        demo1
        demo2
    }
