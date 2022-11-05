namespace Fun.Blazor.Docs.Wasm

#nowarn "0020"

open System
open System.Net.Http
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.Components.WebAssembly.Hosting
open MudBlazor.Services
open Fun.Blazor
open Fun.Blazor.Docs.Wasm


type PrerenderApp() =
    inherit FunBlazorComponent()

    override _.Render() = App.app


type Program =

    static member ConfigureServices(services: IServiceCollection, baseAddress: string) =
        services
            .AddFunBlazorWasm()
            .AddMudServices()
            .AddScoped<Fun.Blazor.Docs.Wasm.Demos.ScopedDemoService>()
            .AddScoped<HttpClient>(fun _ ->
                let http = new HttpClient()
                http.BaseAddress <- Uri baseAddress
                http
            )
        ()


    static member Main(args: string[]) =
        let builder = WebAssemblyHostBuilder.CreateDefault(args)

        builder.RootComponents.RegisterForFunBlazor()

#if DEBUG
        builder.AddFunBlazor("#app", html.hotReloadComp (app, "Fun.Blazor.Docs.Wasm.App.app"))
#else
        if builder.RootComponents.Count = 0 then
            builder.RootComponents.Add<PrerenderApp>("#app")
#endif

        Program.ConfigureServices(builder.Services, builder.HostEnvironment.BaseAddress)

        builder.Build().RunAsync()

        -1


module Startup =

    [<EntryPoint>]
    let main args = Program.Main args
    