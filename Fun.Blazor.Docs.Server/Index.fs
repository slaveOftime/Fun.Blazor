namespace Fun.Blazor.Docs.Server

open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc.Rendering
open Fun.Blazor
open Fun.Blazor.Docs.Wasm


type Index() =
    inherit FunBlazorComponent()

    override _.Render() =
#if DEBUG
        html.hotReloadComp (Fun.Blazor.Docs.Wasm.App.app, "Fun.Blazor.Docs.Wasm.App.app")
#else
        Fun.Blazor.Docs.Wasm.App.app
#endif

    static member page(ctx: HttpContext) =
        let store = ctx.RequestServices.GetMultipleServices<IShareStore>()
        store.IsServerSideRendering.Publish true

        // Must defined as a variable and use it later for SSR 
        let root = rootComp<Index> ctx RenderMode.ServerPrerendered

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
                    root

                    script { src "_content/MudBlazor/MudBlazor.min.js" }
                    script { src "_framework/blazor.server.js" }

                    stylesheet "css/google-font.css"
                    stylesheet "css/github-markdown-dark.css"
                    stylesheet "css/prism-vsc-dark-plus.css"
                    script { src "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/components/prism-core.min.js" }
                    script { src "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/plugins/autoloader/prism-autoloader.min.js" }

#if DEBUG
                    html.hotReloadJSInterop
#endif
                }
            }
        }

