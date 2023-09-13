#nowarn "0020"

open System
open System.Net.Http
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open MudBlazor.Services
open Fun.Blazor
open Fun.Blazor.Docs.Server
open Microsoft.AspNetCore.Components.Endpoints


let builder = WebApplication.CreateBuilder(Environment.GetCommandLineArgs())
let services = builder.Services

services.AddControllersWithViews()
services.AddServerSideBlazor(fun options ->
    options.RootComponents.RegisterForFunBlazor()
    options.RootComponents.RegisterCustomElementForFunBlazor<Fun.Blazor.Docs.Wasm.Demos.CustomElementDemo.DemoCounter>()
    options.RootComponents.RegisterCustomElementForFunBlazor(typeof<Fun.Blazor.Docs.Wasm.Demos.CustomElementDemo.DemoCounter>.Assembly)
)
services.AddRazorComponents().AddServerComponents().AddWebAssemblyComponents()
services.AddFunBlazorServer()
services.AddMudServices()
services.AddScoped<Fun.Blazor.Docs.Wasm.Demos.ScopedDemoService>()

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

app.MapRazorComponents<Index>().AddServerRenderMode().AddWebAssemblyRenderMode()
app.MapGet("/demo", Func<_>(fun () -> div { $"{DateTime.Now}" })).AddFunBlazor()
app.MapFunBlazor(index)

app.Run()
