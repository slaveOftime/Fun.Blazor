[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.Router.RouterDemo

open Fun.Blazor

let routerDemo =
    html.route (function
        | [ "router" ]
        | [ _; "router" ] -> html.text "Router"

        | _ -> html.text "QuickStart.QuickStart.quickStart"
    )
