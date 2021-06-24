open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open MudBlazor.Services
open Fun.Blazor.Docs.Server
open Bolero.Server


Host.CreateDefaultBuilder(Environment.GetCommandLineArgs())
    .ConfigureWebHostDefaults(fun builder ->
        builder
            .ConfigureServices(fun (services: IServiceCollection) ->
                services.AddControllersWithViews() |> ignore
                services
                    .AddServerSideBlazor().Services
                    .AddBoleroHost(true, true)
                    .AddFunBlazor()
                    .AddMudServices()
                    .AddAntDesign() |> ignore)
            .Configure(fun (application: IApplicationBuilder) ->
                application
                    .UseStaticFiles()
                    .UseRouting()
                    .UseEndpoints(fun endpoints ->
                        endpoints.MapBlazorHub() |> ignore
                        endpoints.MapFallbackToBolero(Index.page) |> ignore) |> ignore) |> ignore)
    .Build()
    .Run()

