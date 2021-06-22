namespace Fun.Blazor.Docs.Server

open Fun.Blazor
open Fun.Blazor.Server


type Index () =
    inherit Bolero.Component()

    override this.Render() = Docs.Wasm.App.app.ToBolero()


    static member page =
        html.doctypeHtml [
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
                        html.root<Index>()
                        html.bolero Bolero.Server.Html.boleroScript
                    ]
                ]
            ])
        ]
