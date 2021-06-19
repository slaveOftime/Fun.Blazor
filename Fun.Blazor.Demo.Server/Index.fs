namespace Fun.Blazor.Demo

open Bolero.Server.Html
open Fun.Blazor


type Index () =

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
                    attr.children [
                        html.bolero rootComp<Wasm.App>
                        html.bolero boleroScript
                
                        html.script "_content/MatBlazor/dist/matBlazor.js"
                        html.stylesheet "_content/MatBlazor/dist/matBlazor.css"

                        html.script "_content/AntDesign/js/ant-design-blazor.js"
                        html.stylesheet "_content/AntDesign/css/ant-design-blazor.css"

                        html.script [
                            attr.src "https://unpkg.com/@fluentui/web-components"
                            attr.type' "module"
                        ]
                    ]
                ]
            ])
            |> html.toBolero
        ]
