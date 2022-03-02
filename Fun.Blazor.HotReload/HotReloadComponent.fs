#nowarn "0020"

namespace Fun.Blazor.HotReload

open System
open System.Collections.Concurrent
open Microsoft.JSInterop
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.SignalR.Client
open Fun.Blazor


module private Cache =
    let private jsonOptions = Newtonsoft.Json.JsonSerializerSettings()
    jsonOptions.MaxDepth <- 1000

    let mutable lastRenderFns = ConcurrentDictionary<string, NodeRenderFragment>()

    let private hubLocker = obj ()
    let mutable private hubConnection = Option<HubConnection>.None

    /// Support multiple hot-reload entries for fsharp code changes
    let private codeChangeStore =
        new Store<(string * FSharp.Compiler.PortaCode.CodeModel.DFile) []>([||]) :> IStore<_>

    /// Only need one callback for css
    let mutable changeCssCallback = fun (name: string) (css: string) -> ()

    let private makeHub (host: string) =
        let hub = HubConnectionBuilder().WithUrl($"{host}/hot-reload-hub").Build()
        hubConnection <- Some hub
        task {
            printfn "Starting hot-reload hub"
            hub.On(
                "CodeChanged",
                fun code ->
                    let sw = System.Diagnostics.Stopwatch.StartNew()
                    printfn "Received raw code changes"
                    let result =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<(string * FSharp.Compiler.PortaCode.CodeModel.DFile) []>(code, jsonOptions)
                    printfn "Code changes deserialized in %d ms" sw.ElapsedMilliseconds
                    codeChangeStore.Publish result
            )
            hub.On<string, string>(
                "CssChanged",
                fun name code ->
                    printfn "Received css %s changes" name
                    changeCssCallback name code
                    printfn "css %s changes applied" name
            )
            do! hub.StartAsync()
            printfn "Started hot-reload hub"
        }

    let getCodeChangesObserver (host: string) =
        lock
            hubLocker
            (fun () ->
                match hubConnection with
                | Some h when
                    h.State = HubConnectionState.Connected
                    || h.State = HubConnectionState.Connecting
                    || h.State = HubConnectionState.Reconnecting
                    ->
                    ()

                | Some h ->
                    h.DisposeAsync() |> ignore
                    makeHub (host) |> ignore

                | None -> makeHub (host) |> ignore
            )

        codeChangeStore.Observable


type HotReloadComponent() as this =
    inherit FunBlazorComponent()

    let mutable disposes: IDisposable list = []


    let setRender r =
        this.RenderFn <- r
        this.ForceRerender()


    [<Parameter>]
    member val RenderFn = html.none with get, set

    [<Parameter>]
    member val RenderEntryName = "" with get, set

    [<Parameter>]
    member val Host = "" with get, set


    [<Inject>]
    member val GlobalStore = Unchecked.defaultof<IGlobalStore> with get, set

    [<Inject>]
    member val JS: IJSRuntime = Unchecked.defaultof<IJSRuntime> with get, set


    override _.Render() = this.RenderFn


    override _.OnAfterRender(firstRender) =
        if firstRender then
            let codeChangedObserver = Cache.getCodeChangesObserver this.Host

            disposes <-
                [
                    codeChangedObserver.Subscribe(fun code ->
                        Utils.reload
                            this.RenderEntryName
                            code
                            (fun x ->
                                Cache.lastRenderFns.AddOrUpdate(this.RenderEntryName, (fun _ -> x), (fun _ _ -> x))
                                setRender x
                            )
                    )
                ]

            Cache.changeCssCallback <- fun name code -> this.JS.InvokeAsync("hotReloadStyle", $"hot-reload-css-{name.GetHashCode()}", code) |> ignore

            match Cache.lastRenderFns.TryGetValue this.RenderEntryName with
            | true, x -> setRender x
            | _ -> ()


    interface IDisposable with
        member _.Dispose() = disposes |> List.iter (fun x -> x.Dispose())
