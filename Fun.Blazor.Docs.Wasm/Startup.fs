open System
open Microsoft.Extensions.Logging
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open Majorsoft.Blazor.WebAssembly.Logging.Console
open MudBlazor.Services
open Fun.Blazor.Docs.Wasm

let builder = WebAssemblyHostBuilder.CreateDefault(Environment.GetCommandLineArgs())
        
builder
    .AddFunBlazorNode("#app", app)
    .Logging.AddBrowserConsole().SetMinimumLevel(LogLevel.Debug)
    .Services
        .AddFunBlazor()
        .AddAntDesign()
        .AddMudServices()
    |> ignore
        
builder.Build().RunAsync() |> ignore
