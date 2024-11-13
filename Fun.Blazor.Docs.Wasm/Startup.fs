namespace Fun.Blazor.Docs.Wasm

#nowarn "0020"

open System
open System.Net.Http
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open MudBlazor.Services
open Fun.Blazor.Docs.Wasm


type Program =

    static member ConfigureServices(services: IServiceCollection, baseAddress: string) =
        services
            .AddFunBlazorWasm()
            .AddMudServices()
            .AddScoped<Demos.ScopedDemoService>()
            .AddScoped<HttpClient>(fun _ ->
                let http = new HttpClient()
                http.BaseAddress <- Uri baseAddress
                http
            )
        ()


    static member Main(args: string[]) =
        let builder = WebAssemblyHostBuilder.CreateDefault(args)

        builder.RootComponents.RegisterCustomElementForFunBlazor<Demos.CustomElementDemo.DemoCounter>()

        if builder.RootComponents.Count = 0 then
            builder.RootComponents.Add<App>("#app")

        Program.ConfigureServices(builder.Services, builder.HostEnvironment.BaseAddress)

        builder.Build().RunAsync()

        -1


module Startup =

    [<EntryPoint>]
    let main args = Program.Main args
