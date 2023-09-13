[<AutoOpen>]
module Fun.Blazor.Docs.Server.Index

open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Components.Web
open Microsoft.Extensions.DependencyInjection
open Fun.Blazor
open Fun.Blazor.Docs.Wasm


let index (ctx: HttpContext) =
    let store = ctx.RequestServices.GetService<IShareStore>()
    store.IsServerSideRendering.Publish true

    fragment {
        doctype "html"
        html' {
            lang "en"
            head {
                meta { charset "utf-8" }
                meta {
                    name "viewport"
                    content "width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"
                }
                title { "Fun Blazor" }
                baseUrl "/"
                stylesheet "_content/MudBlazor/MudBlazor.min.css"
                CustomElement.lazyBlazorJs (hasBlazorJs = true)
            }
            body {
                html.blazor<App> RenderMode.Server

                script { src "_content/MudBlazor/MudBlazor.min.js" }
                script { src "_framework/blazor.web.js" }

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
