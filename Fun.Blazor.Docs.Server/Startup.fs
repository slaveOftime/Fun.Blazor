#nowarn "0020"

open System
open System.Net.Http
open System.Reflection
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Components.Web
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open MudBlazor.Services
open Fun.Blazor
open Fun.Blazor.Router
open Fun.Blazor.Docs.Wasm
open Fun.Blazor.Docs.Server


let builder = WebApplication.CreateBuilder(Environment.GetCommandLineArgs())
let services = builder.Services

services.AddServerSideBlazor(fun options ->
    //options.RootComponents.RegisterCustomElementForFunBlazor<Demos.CustomElementDemo.DemoCounter>()
    //options.RootComponents.RegisterCustomElementForFunBlazor(typeof<Demos.CustomElementDemo.DemoCounter>.Assembly)
    options.RootComponents.RegisterCustomElementForFunBlazor(Assembly.GetExecutingAssembly())
)
services.AddRazorComponents().AddInteractiveServerComponents().AddInteractiveWebAssemblyComponents()
services.AddFunBlazorServer()
services.AddMudServices()
services.AddScoped<Demos.ScopedDemoService>()

services.AddScoped<HttpClient>(fun (sp) ->
    let httpContext = sp.GetService<IHttpContextAccessor>()
    let baseUrl =
        httpContext.HttpContext.Request.Scheme + "://" + httpContext.HttpContext.Request.Host.ToString()
    let http = new HttpClient()
    http.BaseAddress <- Uri baseUrl
    http
)


let app = builder.Build()

app.UseStaticFiles()

app.MapRazorComponents().AddInteractiveServerRenderMode().AddInteractiveWebAssemblyRenderMode()
app.MapRazorComponentsForSSR(Assembly.GetExecutingAssembly(), notFoundNode = div { "ERROR: not found" })
app.MapCustomElementsForSSR(Assembly.GetExecutingAssembly(), notFoundNode = div { "ERROR: not found" })
app.MapCustomElementsForSSR(Assembly.GetExecutingAssembly(), notFoundNode = div { "ERROR: not found" })


app.MapFunBlazor(fun ctx ->
    let store = ctx.RequestServices.GetService<IShareStore>()
    store.IsServerSideRendering.Publish true

    fragment {
        doctype "html"
        html' {
            lang "en"
            head {
                title { "Fun Blazor" }
                chartsetUTF8
                baseUrl "/"
                viewport "width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no"
                stylesheet "_content/MudBlazor/MudBlazor.min.css"
                stylesheet "css/app.css"
                HeadOutlet'' { }
                CustomElement.lazyBlazorJs (hasBlazorJs = true)
            }
            body {
                App.theme

                html.route [|
                    routeCi "/htmx-demo" (HtmxDemo.Create())
                    routeCi "/custom-elements-demo" (CustomElementsDemo.Create())
                    routeAny (html.blazor<App> RenderMode.InteractiveServer)
                |]

                script { src "_content/MudBlazor/MudBlazor.min.js" }
                script { src "_framework/blazor.server.js" }
                
                script { src "https://unpkg.com/htmx.org@2.0.3" }
                script { src "https://unpkg.com/htmx-ext-sse@2.2.2/sse.js" }

                stylesheet "css/google-font.css"
                stylesheet "css/prism-vsc-dark-plus.css"

                script { src "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/components/prism-core.min.js" }
                script { src "https://cdnjs.cloudflare.com/ajax/libs/prism/1.23.0/plugins/autoloader/prism-autoloader.min.js" }
            }
        }
    }
)

app.Run()
