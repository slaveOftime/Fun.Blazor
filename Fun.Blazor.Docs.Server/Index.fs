namespace Fun.Blazor.Docs.Server

open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc.Rendering
open Fun.Blazor


type Index() =

#if DEBUG
    inherit HotReloadComponent("Fun.Blazor.Docs.Wasm.App.app", Fun.Blazor.Docs.Wasm.App.app)
#else
    inherit FunBlazorComponent()
    override _.Render() = Fun.Blazor.Docs.Wasm.App.app
#endif


    static member page(ctx: HttpContext) =
        fragment {
            doctype "html"
            html' {
                head {
                    meta { charset "utf-8" }
                    meta {
                        name "viewport"
                        content "width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"
                    }
                    title { "Fun Blazor" }
                    baseUrl "/"
                    stylesheet "_content/MudBlazor/MudBlazor.min.css"
                }
                body {
                    rootComp<Index> ctx RenderMode.ServerPrerendered

                    script { src "_content/MudBlazor/MudBlazor.min.js" }
                    script { src "_framework/blazor.server.js" }

                    stylesheet "css/google-font.css"
                    stylesheet "css/drag-drop.css"

                    stylesheet "css/github-markdown.css"
                    stylesheet "css/prism-night-owl.css"
                    script { src "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/components/prism-core.min.js" }
                    script { src "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/plugins/autoloader/prism-autoloader.min.js" }

                    stylesheet "https://cdn.jsdelivr.net/npm/mobile-drag-drop@2.3.0-rc.2/default.css"
                    script { src "https://cdn.jsdelivr.net/npm/mobile-drag-drop@2.3.0-rc.2/index.min.js" }

                    script { src "_content/AntDesign/js/ant-design-blazor.js" }
                    script { src "https://unpkg.com/@antv/g2plot@latest/dist/g2plot.min.js" }
                    script { src "_content/AntDesign.Charts/ant-design-charts-blazor.js" }

                    script {
                        src "https://unpkg.com/@fluentui/web-components"
                        type' "module"
                    }
                }
            }
        }


    static member page2 ctx =
        Template.html $"""
            <!DOCTYPE html>
            <html>

            <head>
                <meta charset="utf-8" />
                <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no" />
                <title>Fun Blazor</title>
                <base href="/" />
                <link rel="stylesheet" href="_content/MudBlazor/MudBlazor.min.css" />
            </head>

            <body>
                {rootComp<Index> ctx RenderMode.ServerPrerendered}

                <script src="_content/MudBlazor/MudBlazor.min.js"></script>
                <script src="_framework/blazor.server.js"></script>

                <link rel="stylesheet" href="css/google-font.css" />
                <link rel="stylesheet" href="css/drag-drop.css" />

                <link rel="stylesheet" href="css/github-markdown.css" />
                <link rel="stylesheet" href="css/prism-night-owl.css" />
                <script src="https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/components/prism-core.min.js"></script>
                <script src="https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/plugins/autoloader/prism-autoloader.min.js"></script>

                <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/mobile-drag-drop@2.3.0-rc.2/default.css">
                <script src="https://cdn.jsdelivr.net/npm/mobile-drag-drop@2.3.0-rc.2/index.min.js"></script>

                <script src="_content/AntDesign/js/ant-design-blazor.js"></script>
                <script src="https://unpkg.com/@antv/g2plot@latest/dist/g2plot.min.js"></script>
                <script src="_content/AntDesign.Charts/ant-design-charts-blazor.js"></script>

                <script src="https://unpkg.com/@fluentui/web-components" type="module"></script>
            </body>

            </html>
        """
