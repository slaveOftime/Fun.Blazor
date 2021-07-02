[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.Router.RouterDemo

open MudBlazor
open Fun.Blazor

let routerDemo =
    html.div [
        mudText() {
            typo Typo.subtitle1
            childContentStr "The reason we have something like [ \"router\" ] and [ _; \"router\" ] is because we host WASM on github and it has a sub folder url. We also host this on a blazor server side mode on another machine which all the content is under the root of domain."
            CAST
        }
        mudText() {
            typo Typo.subtitle2
            color Color.Secondary
            childContent [
                html.route (function
                    | [ "router" ]
                    | [ _; "router" ] -> html.text "Router"
                                
                    | [ "router"; Route.Query [ "name", name; "age", Route.Int age ] ]
                    | [ _; "router"; Route.Query [ "name", name; "age", Route.Int age ] ] -> html.text $"name is: {name}, age is: {age}"

                    | _ -> html.text "Not my concern."
                )
            ]
            CAST
        }
        mudLink() {
            href "./router?name=albert&age=123"
            childContentStr "Try to navigate"
            CAST
        }
    ]
