#nowarn "0020"

namespace Fun.Blazor.HotReload

open System
open System.Threading
open Microsoft.JSInterop
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.SignalR.Client
open Fun.Blazor


type HotReloadComponent() as this =
    inherit FunBlazorComponent()

    let mutable disposes: IDisposable list = []
    let tokenSource = new CancellationTokenSource()


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
            let hub = HubConnectionBuilder().WithUrl($"{this.Host}/hot-reload-hub").Build()

            hub.On<string>(
                "CodeChanged",
                fun code ->
                    printfn "Code changed"
                    Utils.reload this.RenderEntryName code setRender
                    printfn "Code changes applied"
            )

            hub.On<string, string>(
                "CssChanged",
                fun name code ->
                    printfn "css %s changed" name
                    this.JS.InvokeAsync("hotReloadStyle", $"hot-reload-css-{name.GetHashCode()}", code)
                    printfn "css %s changes applied" name
            )

            task {
                printfn "Start hot-reload hub"
                do! hub.StartAsync(tokenSource.Token)
                printfn "Started hot-reload hub"
            }
            |> ignore


    interface IDisposable with
        member _.Dispose() =
            tokenSource.Cancel()
            tokenSource.Dispose()
            disposes |> List.iter (fun x -> x.Dispose())
