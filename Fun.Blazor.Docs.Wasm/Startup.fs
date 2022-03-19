#nowarn "0020"

open System
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

builder.Build().RunAsync()
