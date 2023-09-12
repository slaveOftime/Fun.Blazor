namespace Fun.Blazor.Docs.Server

open Microsoft.AspNetCore.Components
open Fun.Blazor
open Fun.Blazor.Docs.Wasm


[<Route "/">]
type Index() =
    inherit FunBlazorComponent()

    [<Inject>]
    member val Store = Unchecked.defaultof<IShareStore> with get, set

    override this.Render() =
        this.Store.IsServerSideRendering.Publish true

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
                    CustomElement.lazyBlazorJs (hasBlazorJs = true)
                }
                body {
                    App'() { renderMode_Auto }

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
