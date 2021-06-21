namespace Fun.Blazor.Docs

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Bolero.Server
open MudBlazor.Services


[<AutoOpen>]
module Configs =

    let configureService (services: IServiceCollection) =
        services.AddControllersWithViews() |> ignore
        services
            .AddServerSideBlazor().Services
            .AddBoleroHost(true, true)
            .AddFunBlazor()
            .AddMudServices()
            .AddAntDesign()
            |> ignore


    let configureApplication(application: IApplicationBuilder) =
        application
            .UseStaticFiles()
            .UseRouting()
            .UseEndpoints(fun endpoints ->
                endpoints.MapBlazorHub() |> ignore
                endpoints.MapFallbackToBolero(Index.page) |> ignore)
            |> ignore


module Program =

    [<EntryPoint>]
    let main args =
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(fun builder ->
                builder
                    .ConfigureServices(configureService)
                    .Configure(configureApplication)
                    |> ignore)
            .Build()
            .Run()
        0
