namespace Fun.Blazor.Demo.Wasm

open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open MatBlazor


module Program =

    [<EntryPoint>]
    let Main args =
        let builder = WebAssemblyHostBuilder.CreateDefault(args)
        
        builder.RootComponents.Add<App>("#app")

        builder.Services
            .AddFunBlazor()
            .AddAntDesign()
            .AddMatBlazor() |> ignore
        
        builder.Build().RunAsync() |> ignore
        0

