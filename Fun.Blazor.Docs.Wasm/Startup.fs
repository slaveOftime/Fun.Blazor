namespace Fun.Blazor.Docs.Wasm

open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open MudBlazor.Services


module Program =

    [<EntryPoint>]
    let Main args =
        let builder = WebAssemblyHostBuilder.CreateDefault(args)
        
        builder.RootComponents.Add<App>("#app")

        builder.Services
            .AddFunBlazor()
            .AddAntDesign()
            .AddMudServices()
            |> ignore
        
        builder.Build().RunAsync() |> ignore
        0

