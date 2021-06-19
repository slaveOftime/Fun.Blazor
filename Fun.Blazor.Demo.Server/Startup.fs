namespace Fun.Blazor.Demo

open Microsoft.AspNetCore
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.DependencyInjection
open Bolero.Server
open MatBlazor


type Startup() =

    member this.ConfigureServices(services: IServiceCollection) =
        services.AddControllersWithViews() |> ignore
        services.AddServerSideBlazor() |> ignore
        services.AddBoleroHost(true, true) |> ignore
        services.AddMatBlazor() |> ignore
        services.AddAntDesign() |> ignore
        services.AddFunBlazor() |> ignore

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
