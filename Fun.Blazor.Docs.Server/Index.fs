namespace Fun.Blazor.Docs.Server

open Bolero.Server.Html
open Fun.Blazor


type Index () =
    inherit Bolero.Component()

    override this.Render() = Docs.Wasm.App.app.ToBolero()


    static member page =
        doctypeHtml [] [
            html.html ("en", [
                html.head [
                    html.title "Fun Blazor"
                    html.baseUrl "/"
                    html.meta [ attr.charsetUtf8 ]
                    html.meta [ attr.name "viewport"; attr.content "width=device-width, initial-scale=1.0" ]
                ]
                html.body [
                    attr.styles [ style.margin 0 ]
                    attr.childContent [
                        html.bolero rootComp<Index>
                        html.bolero Bolero.Server.Html.boleroScript
                    ]
                    
                    html.stylesheet "css/google-font.css"
                    html.stylesheet "_content/MudBlazor/MudBlazor.min.css"
                    html.script "_content/MudBlazor/MudBlazor.min.js"
                ]
            ])
            |> html.toBolero
        ]
