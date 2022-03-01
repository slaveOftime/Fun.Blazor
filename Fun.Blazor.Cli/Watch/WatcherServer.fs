module Fun.Blazor.Cli.Watch.WatcherServer

#nowarn "0020"

open System
open System.Linq
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.ResponseCompression
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.SignalR
open Fun.Blazor.Cli


type WatcherHub() =
    inherit Hub()

    member this.SendCode(code: string) =
        task {
            printfn "Sending code"
            do! this.Clients.All.SendAsync("ReceiveCode", code)
            printfn "Sent code"
        }

type WatcherBackgroundService(scf: IServiceScopeFactory) =
    inherit BackgroundService()


    override _.ExecuteAsync (token) =
        task {
            let sp = scf.CreateScope().ServiceProvider
            let watcherHub = sp.GetService<IHubContext<WatcherHub>>()

            // let sendCode x = watcherHub.

            FSharp.Compiler.PortaCode.ProcessCommandLine.ProcessCommandLine [|
                "watch"
                settings.Project
                $"--send:{settings.Server}/fun-blazor-hot-reload"
                "--livecheck"
            |]
        }


let runServer (setting: WatchSettings) =
    let builder = WebApplication.CreateBuilder()

    builder.Services.AddSignalR()
    builder.Services.AddResponseCompression(fun opts ->
        opts.MimeTypes <- ResponseCompressionDefaults.MimeTypes.Concat (
            [| "application/octet-stream" |]
    ))

    let app = builder.Build()
    app.UseResponseCompression()
    app.MapHub<WatcherHub>("/WatcherHub")

    app.Run()
     