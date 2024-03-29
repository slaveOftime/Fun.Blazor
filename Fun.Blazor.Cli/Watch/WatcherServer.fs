﻿module Fun.Blazor.Cli.Watch.WatcherServer

#nowarn "0020"

open System
open System.IO
open System.Threading.Tasks
open FSharp.Control.Reactive
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.AspNetCore.SignalR
open Fun.Blazor.Cli
open Fun.Blazor.Cli.Watch


type HotReloadHub() =
    inherit Hub()


type CodeWatcher(scf: IServiceScopeFactory) =
    inherit BackgroundService()

    override _.ExecuteAsync(token) = task {
        let sp = scf.CreateScope().ServiceProvider
        let settings = sp.GetService<WatchSettings>()
        let hotReloadHub = sp.GetService<IHubContext<HotReloadHub>>()

        let fsharpProj =
            if File.Exists settings.Project then
                settings.Project
            else if Directory.Exists settings.Project then
                let projs = Directory.GetFiles(settings.Project, "*.fsproj")
                if projs.Length = 1 then
                    projs[0]
                else
                    failwith "Found multiple fsharp projects, please specify one."
            else
                failwith "No fsharp project found."

        let sendCode (x: byte[]) = hotReloadHub.Clients.All.SendAsync("CodeChanged", x).Wait()

        printfn "Start code watcher"

        use _ = process' sendCode (Source.FSharpProj fsharpProj) []

        while not token.IsCancellationRequested do
            do! Task.Delay 2000

        printfn "Code watcher exited."
    }


type StaticAssetsWatcher(scf: IServiceScopeFactory) =
    inherit BackgroundService()

    let mutable cssWatcher = ValueNone

    let makeCssWatcher dir =
        let watcher = new FileSystemWatcher(dir)

        watcher.NotifyFilter <-
            NotifyFilters.CreationTime
            ||| NotifyFilters.DirectoryName
            ||| NotifyFilters.FileName
            ||| NotifyFilters.LastWrite
            ||| NotifyFilters.Size

        watcher.Filter <- "*.css"
        watcher.IncludeSubdirectories <- true
        watcher.EnableRaisingEvents <- true
        watcher


    override _.ExecuteAsync(token) = task {
        let sp = scf.CreateScope().ServiceProvider
        let settings = sp.GetService<WatchSettings>()
        let hotReloadHub = sp.GetService<IHubContext<HotReloadHub>>()

        let dir =
            if String.IsNullOrEmpty settings.StaticAssetsDir then
                Path.Combine(Path.GetDirectoryName(Path.GetFullPath(settings.Project)), "wwwroot")
            else
                Path.GetFullPath settings.StaticAssetsDir

        let sendCode (name: string) =
            printfn "css changed: %s" name
            use fs =
                File.Open(Path.Combine(dir, name), FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
            use sr = new StreamReader(fs)
            hotReloadHub.Clients.All.SendAsync("CssChanged", name, sr.ReadToEnd()).Wait()
            printfn "css changes is sent: %s" name

        let sendEmptyCode (name: string) =
            printfn "css removed: %s" name
            hotReloadHub.Clients.All.SendAsync("CssChanged", name, "").Wait()


        if Directory.Exists dir then
            printfn "Start static assests watching %s" dir

            cssWatcher <- ValueSome(makeCssWatcher dir)

            cssWatcher.Value.Changed
            |> Observable.throttle (TimeSpan.FromMilliseconds 300)
            |> Observable.subscribe (fun x -> sendCode x.Name)

            cssWatcher.Value.Created
            |> Observable.throttle (TimeSpan.FromMilliseconds 300)
            |> Observable.subscribe (fun x -> sendCode x.Name)

            cssWatcher.Value.Created
            |> Observable.throttle (TimeSpan.FromMilliseconds 300)
            |> Observable.subscribe (fun x -> sendCode x.Name)

            cssWatcher.Value.Renamed
            |> Observable.throttle (TimeSpan.FromMilliseconds 300)
            |> Observable.subscribe (fun x -> sendCode x.Name)

            cssWatcher.Value.Deleted |> Observable.subscribe (fun x -> sendEmptyCode x.Name)

        else
            printfn "Static assets folder is not exist."


        while not token.IsCancellationRequested && Directory.Exists dir do
            do! Task.Delay 2000

        match cssWatcher with
        | ValueSome x -> x.Dispose()
        | _ -> ()

        printfn "CSS watcher exited."
    }


let runServer (setting: WatchSettings) =
    Host
        .CreateDefaultBuilder()
        .ConfigureHostConfiguration(fun builder -> builder.Sources.Clear())
        .ConfigureWebHostDefaults(fun webBuilder ->
            webBuilder
                .ConfigureServices(fun services ->
                    services.AddSingleton(setting)
                    services.AddHostedService<CodeWatcher>()
                    services.AddHostedService<StaticAssetsWatcher>()
                    services.AddCors()
                    services.AddSignalR() |> ignore
                )
                .Configure(fun app ->
                    app.UseCors(fun option -> option.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod() |> ignore)
                    app.UseRouting()
                    app.UseEndpoints(fun route -> route.MapHub<HotReloadHub>("/hot-reload-hub") |> ignore) |> ignore
                )
                .UseUrls([| setting.Server |])
            |> ignore
        )
        .Build()
        .Run()
