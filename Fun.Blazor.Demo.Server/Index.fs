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
                
                        html.stylesheet "https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"
                        html.stylesheet "_content/MudBlazor/MudBlazor.min.css"
                        html.script "_content/MudBlazor/MudBlazor.min.js"

                        html.script "_content/MatBlazor/dist/matBlazor.js"
                        html.stylesheet "_content/MatBlazor/dist/matBlazor.css"

                        html.script "_content/AntDesign/js/ant-design-blazor.js"
                        html.stylesheet "_content/AntDesign/css/ant-design-blazor.css"

                        html.script [
                            attr.src "https://unpkg.com/@fluentui/web-components"
                            attr.type' "module"
                        ]

                        html.stylesheet "css/github-markdown.css"
                        html.stylesheet "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/themes/prism-solarizedlight.min.css"
                        html.script "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/components/prism-core.min.js"
                        html.script "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/plugins/autoloader/prism-autoloader.min.js"
                    ]
                ]
            ])
            |> html.toBolero
        ]
