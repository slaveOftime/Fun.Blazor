open System
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open MudBlazor.Services
open Fun.Blazor.Docs.Wasm


let builder = WebAssemblyHostBuilder.CreateDefault(Environment.GetCommandLineArgs())
        
builder
    .AddFunBlazorNode("#app", app)
    .Services
        .AddFunBlazor()
        .AddAntDesign()
        .AddMudServices()
    |> ignore
        
builder.Build().RunAsync() |> ignore
