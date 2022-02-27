namespace Fun.Blazor

open System
open System.IO
open FSharp.Control.Reactive
open Microsoft.JSInterop
open Microsoft.Extensions.Hosting
open Microsoft.AspNetCore.Components
open Fun.Blazor


/// This should be used for root component of your application.
/// Currently it is only usable for server side mode blazor in debug mode.
/// renderEntryName: should be the full name of the initRender. ("Demo.App.app", app).
/// I use IGlobalStore to create a store "--fun-blazor-hot-reload-store" to receive the code changes, so you should not create any store named like that.
/// You should use it together with Fun.Blazor.Cli.
type HotReloadComponent(renderEntryName, initRender, ?staticAssetsDir) as this =
    inherit FunBlazorComponent()

    let mutable disposes: IDisposable list = []
    let mutable render = initRender


    let setRender r =
        render <- r
        this.ForceRerender()


    let makeCssWatcher dir =
        let watcher = new FileSystemWatcher(dir)

        watcher.NotifyFilter <-
            NotifyFilters.Attributes
            ||| NotifyFilters.CreationTime
            ||| NotifyFilters.DirectoryName
            ||| NotifyFilters.FileName
            ||| NotifyFilters.LastAccess
            ||| NotifyFilters.LastWrite
            ||| NotifyFilters.Security
            ||| NotifyFilters.Size

        watcher.Filter <- "*.css"
        watcher.IncludeSubdirectories <- true
        watcher.EnableRaisingEvents <- true
        watcher


    let mkCssId (x: string) = $"hot-reload-css-{x.GetHashCode()}"

    let handleChanges dir (name: string) =
        printfn "CSS changed %s" name
        use fs =
            File.Open(Path.Combine(dir, name), FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
        use sr = new StreamReader(fs)
        this.JS.InvokeAsync("hotReloadStyle", mkCssId name, sr.ReadToEnd()) |> ignore

    let handleDelete (name: string) =
        printfn "CSS deleted %s" name
        this.JS.InvokeAsync("hotReloadStyle", mkCssId name, "") |> ignore


    static member HotReloadStoreName = "--fun-blazor-hot-reload-store"


    [<Inject>]
    member val GlobalStore = Unchecked.defaultof<IGlobalStore> with get, set

    [<Inject>]
    member val JS: IJSRuntime = Unchecked.defaultof<IJSRuntime> with get, set

    [<Inject>]
    member val HostingEnv = Unchecked.defaultof<IHostEnvironment> with get, set


    override _.Render() = render


    override _.OnAfterRender(firstRender) =
        if firstRender then
            let dir =
                match staticAssetsDir with
                | Some x -> x
                | None -> System.IO.Path.Combine(this.HostingEnv.ContentRootPath, "wwwroot")

            disposes <-
                [
                    this
                        .GlobalStore
                        .CreateCVal(HotReloadComponent.HotReloadStoreName, "[]")
                        .AddInstantCallback(fun codeData ->
                            let sw = System.Diagnostics.Stopwatch.StartNew()
                            printfn "Received code changes, applying"
                            Server.HotReload.reload renderEntryName codeData setRender |> ignore
                            printfn "Code changes applied in %d ms" sw.ElapsedMilliseconds
                        )

                    if Directory.Exists dir |> not then
                        printfn "Static assets folder is not found, hot reload may not work for them. %s" dir
                    else
                        let cssWatcher = makeCssWatcher dir
                        cssWatcher.Changed
                        |> Observable.throttle (TimeSpan.FromMilliseconds 300)
                        |> Observable.subscribe (fun x -> handleChanges dir x.Name)

                        cssWatcher.Renamed
                        |> Observable.throttle (TimeSpan.FromMilliseconds 300)
                        |> Observable.subscribe (fun x -> handleChanges dir x.Name)

                        cssWatcher.Deleted |> Observable.subscribe (fun x -> handleDelete x.Name)

                        cssWatcher
                ]


    interface IDisposable with
        member _.Dispose() = disposes |> List.iter (fun x -> x.Dispose())
