[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.Router.GiraffeStyleRouterDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.Router
open Fun.Blazor.MudBlazor

let giraffeStyleRouterDemo =
    let formatQueries = Map.toList >> List.map (fun (k, v) -> $"key = {k}, value = {v}") >> String.concat "; "

    let route = 
        subRouteCi "/router" [
            routeCi "/document" (html.text "Dcoument page")
            routeCif "/document/%i" (fun x -> html.text $"Document {x}")
            routeCiWithQueries "/documents" (fun queries -> html.text $"Documents with query: {formatQueries queries}")
            routeCifWithQueries "/documents/%s" (fun param queries -> html.text $"Documents(Param: {param}) with query: {formatQueries queries}")
        ]

    let link (href: string) (name: string) =
        mudLink.create [
            mudLink.href href
            mudLink.childContent name
            mudLink.underline Underline.Always
            mudLink.styles [ style.marginRight 10 ]
        ]

    html.div [
        mudText.create [
            mudText.typo Typo.subtitle1
            mudText.childContent ""
        ]
        mudText.create [
            mudText.typo Typo.subtitle2
            mudText.color Color.Secondary
            mudText.childContent [
                html.route [
                    route
                    subRouteCi "/Fun.Blazor" [ route ] // For github-pages hosting
                    routeAny (html.text "Not my concern.")
                ]
            ]
        ]
        link "./router/document" "Route to document"
        link "./router/document/12" "Route to document 12"
        link "./router/documents?filter=test&q2=2" "Route to documents with query"
        link "./router/documents/fun-blazor?filter=test&q2=2" "Route to documents with query"
    ]
