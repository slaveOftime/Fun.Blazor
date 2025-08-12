namespace Fun.Blazor.Docs.Server

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Fun.Blazor
open Fun.Blazor.Router
open Fun.Blazor.Docs.Wasm
open System.Reflection

// ImportMap can now only work with normal blazor route,
// in the future we may find its underline service to hook for html.route.
// but currently use blazor route as demo
[<Route("/{*path}"); FunInteractiveServer>]
type Entry() =
    inherit FunComponent()

    [<Parameter>]
    member val Path = "" with get, set

    override _.Render() =
        html.route [|
            routeCi "/htmx-demo" (HtmxDemo.Create())
            routeCi "/custom-elements-demo" (CustomElementsDemo.Create())
            routeAny (html.blazor<App> RenderMode.InteractiveServer)
        |]

type Routes() =
    inherit FunComponent()

    override _.Render() = Router'' {
        AppAssembly(Assembly.GetExecutingAssembly())
        Found(fun routeData -> RouteView'' { RouteData routeData })
    }

type Index() as this =
    inherit FunComponent()

    override _.Render() = fragment {
        doctype "html"
        html' {
            lang "en"
            head {
                title { "Fun Blazor" }
                chartsetUTF8
                baseUrl "/"
                viewport "width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"
                stylesheet (this.MapAsset "_content/MudBlazor/MudBlazor.min.css")
                stylesheet (this.MapAsset "css/app.css")
                html.blazor<ImportMap> ()
                HeadOutlet'' { interactiveServer }
                CustomElement.lazyBlazorJs (hasBlazorJs = true)
            }
            body {
                App.theme

                html.blazor<Routes> ()

                script { src (this.MapAsset "_content/MudBlazor/MudBlazor.min.js") }
                script { src (this.MapAsset "_framework/blazor.server.js") }

                script { src "https://unpkg.com/htmx.org@2.0.3" }
                script { src "https://unpkg.com/htmx-ext-sse@2.2.2/sse.js" }

                stylesheet (this.MapAsset "css/google-font.css")
                stylesheet (this.MapAsset "css/prism-vsc-dark-plus.css")

                script { src "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/components/prism-core.min.js" }
                script { src "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/plugins/autoloader/prism-autoloader.min.js" }
            }
        }
    }
