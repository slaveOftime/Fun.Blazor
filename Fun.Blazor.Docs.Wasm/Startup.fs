#nowarn "0020"

open System
open System.Net.Http
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open MudBlazor.Services
open Fun.Blazor
open Fun.Blazor.Docs.Wasm


let builder = WebAssemblyHostBuilder.CreateDefault(Environment.GetCommandLineArgs())

builder
#if DEBUG
    .AddFunBlazor("#app", html.hotReloadComp (app, "Fun.Blazor.Docs.Wasm.App.app"))
#else
    .AddFunBlazor("#app", app)
#endif

builder
    .Services
    .AddFunBlazorWasm()
    .AddMudServices()
    .AddScoped<Fun.Blazor.Docs.Wasm.Demos.ScopedDemoService>()
    .AddScoped<HttpClient>(fun _ ->
        let http = new HttpClient()
        http.BaseAddress <-
#if DEBUG
            Uri(builder.HostEnvironment.BaseAddress)
#else
            Uri(builder.HostEnvironment.BaseAddress + "/Fun.Blazor.Docs")
#endif
        http
    )

builder.Build().RunAsync()
