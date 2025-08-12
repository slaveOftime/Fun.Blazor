#nowarn "0020"

open System
open System.Net.Http
open System.Reflection
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open MudBlazor.Services
open Fun.Blazor
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

app.MapStaticAssets()

app.UseAntiforgery()

app.MapRazorComponents<Index>().AddInteractiveServerRenderMode().AddInteractiveWebAssemblyRenderMode()
app.MapRazorComponentsForSSR(Assembly.GetExecutingAssembly(), notFoundNode = div { "ERROR: not found" })
app.MapCustomElementsForSSR(Assembly.GetExecutingAssembly(), notFoundNode = div { "ERROR: not found" })
app.MapCustomElementsForSSR(Assembly.GetExecutingAssembly(), notFoundNode = div { "ERROR: not found" })


app.Run()
