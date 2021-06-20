namespace Fun.Blazor.Demo

open Microsoft.AspNetCore
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Bolero.Server
open MudBlazor.Services
open MatBlazor


type Startup() =

    member this.ConfigureServices(services: IServiceCollection) =
        services.AddControllersWithViews() |> ignore
        services
            .AddServerSideBlazor().Services
            .AddBoleroHost(true, true)
            .AddFunBlazor()
            .AddMudServices()
            .AddAntDesign()
            .AddMatBlazor()


    member this.Configure(app: IApplicationBuilder, env: IWebHostEnvironment) =
        app
            .UseStaticFiles()
            .UseRouting()
            .UseEndpoints(fun endpoints ->
                endpoints.MapBlazorHub() |> ignore
                endpoints.MapFallbackToBolero(Index.page) |> ignore)
        |> ignore


module Program =

    [<EntryPoint>]
    let main args =
        WebHost
            .CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build()
            .Run()
        0
