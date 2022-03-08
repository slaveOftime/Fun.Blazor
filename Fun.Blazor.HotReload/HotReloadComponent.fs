#nowarn "0020"

namespace Fun.Blazor.HotReload

open System
open System.Collections.Generic
open System.Collections.Concurrent
open Microsoft.JSInterop
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.SignalR.Client
open MessagePack
open Fun.Blazor


type private CssChanges = { Name: string; Css: string }

type private HubBundle =
    {
        Hub: HubConnection
        CodeObserver: IObservable<(string * FSharp.Compiler.PortaCode.CodeModel.DFile) []>
        CssObserver: IObservable<CssChanges>
    }


module private Cache =

    let mutable lastRenderFns = ConcurrentDictionary<string, NodeRenderFragment>()

    let private hubLocker = obj ()

    let mutable private hubConnections = Dictionary<string, HubBundle>()


    let private makeHubBundle (host: string) =
        let hub = HubConnectionBuilder().WithUrl($"{host}/hot-reload-hub").Build()
        let codeStore = new Store<(string * FSharp.Compiler.PortaCode.CodeModel.DFile) []>([||]) :> IStore<_>
        let cssStore = new Store<CssChanges>({ Name = ""; Css = "" }) :> IStore<_>

        task {
            printfn "Starting hot-reload hub: %s" host
            hub.On(
                "CodeChanged",
                fun (code: byte []) ->
                    let sw = System.Diagnostics.Stopwatch.StartNew()
                    printfn "Received raw code changes: %s. Length: %d" host code.Length
                    try
                        let result = FSharp.Compiler.PortaCode.CodeModel.CodeChangesPack.FromBytes code
                        printfn "Code changes deserialized in %d ms: %s" sw.ElapsedMilliseconds host
                        codeStore.Publish result.Changes
                    with
                        | ex -> printfn "Process code changes failed: %s" ex.Message
            )
            hub.On<string, string>(
                "CssChanged",
                fun name code ->
                    printfn "Received css %s changes: %s" name host
                    cssStore.Publish { Name = name; Css = code }
                    printfn "css %s changes applied: %s" name host
            )
            do! hub.StartAsync()
            printfn "Started hot-reload hub: %s" host
        }

        {
            Hub = hub
            CodeObserver = codeStore.Observable
            CssObserver = cssStore.Observable
        }


    let getHubBundle (host: string) =
        let makeNew () =
            let bundle = makeHubBundle host
            hubConnections.[host] <- bundle
            bundle

        lock
            hubLocker
            (fun () ->
                match hubConnections.TryGetValue host with
                | true, bundle ->
                    if bundle.Hub.State = HubConnectionState.Connected
                       || bundle.Hub.State = HubConnectionState.Connecting
                       || bundle.Hub.State = HubConnectionState.Reconnecting then
                        bundle
                    else
                        bundle.Hub.DisposeAsync() |> ignore
                        makeNew ()
                | _ -> makeNew ()
            )


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
            let hubBundle = Cache.getHubBundle this.Host

            disposes <-
                [
                    hubBundle.CodeObserver.Subscribe(fun code ->
                        Utils.reload
                            this.RenderEntryName
                            code
                            (fun x ->
                                Cache.lastRenderFns.AddOrUpdate(this.RenderEntryName, (fun _ -> x), (fun _ _ -> x))
                                setRender x
                            )
                    )

                    hubBundle.CssObserver.Subscribe(fun data ->
                        this.JS.InvokeAsync("hotReloadStyle", $"hot-reload-css-{this.Host.GetHashCode()}-{data.Name.GetHashCode()}", data.Css)
                        |> ignore
                    )
                ]

            match Cache.lastRenderFns.TryGetValue this.RenderEntryName with
            | true, x -> setRender x
            | _ -> ()


    interface IDisposable with
        member _.Dispose() = disposes |> List.iter (fun x -> x.Dispose())
