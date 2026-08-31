#nowarn "0020"

namespace Fun.Blazor.HotReload

open System
open System.Collections.Generic
open System.Collections.Concurrent
open FSharp.Data.Adaptive
open Microsoft.JSInterop
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.SignalR.Client
open MessagePack
open Fun.Blazor


/// Self-contained JS for the hot-reload feedback UI: a bottom snackbar
/// (ready/indexed/applied) and a pulsing "watching" dot in the corner. Injected at
/// runtime by HotReloadComponent when the host page didn't include hotReloadJSInterop.
/// Hovering the toast or the dot shows a tip explaining hot reload.
[<AutoOpen>]
module HotReloadUI =
    let UIScript =
        """
            // Minimal hot-reload feedback UI: a bottom snackbar (ready/indexed/applied)
            // and a small pulsing dot in the corner while a change is being applied.
            window.hotReloadUI = (() => {
                const STYLE_ID = "fun-blazor-hot-reload-ui-style"
                const ensureStyle = () => {
                    if (document.getElementById(STYLE_ID)) return
                    const s = document.createElement("style")
                    s.id = STYLE_ID
                    s.innerText = `
                        .fb-hr-toast {
                            position: fixed; left: 50%; bottom: 24px; transform: translateX(-50%) translateY(20px);
                            background: rgba(30,30,30,.95); color: #fff; padding: 8px 16px; border-radius: 6px;
                            font: 13px/1.4 system-ui, sans-serif; box-shadow: 0 2px 10px rgba(0,0,0,.4);
                            opacity: 0; transition: opacity .2s, transform .2s; pointer-events: none; z-index: 99999;
                            display: flex; align-items: center; gap: 8px; white-space: nowrap;
                        }
                        .fb-hr-toast.fb-hr-show { opacity: 1; transform: translateX(-50%) translateY(0); }
                        .fb-hr-dot { width: 8px; height: 8px; border-radius: 50%; flex: 0 0 auto; }
                        .fb-hr-dot.ready { background: #4caf50; }
                        .fb-hr-dot.info  { background: #2196f3; }
                        .fb-hr-watch {
                            position: fixed; right: 16px; bottom: 16px; width: 12px; height: 12px; border-radius: 50%;
                            background: #ff9800; z-index: 99999; pointer-events: none;
                            animation: fb-hr-pulse 1s ease-in-out infinite;
                        }
                        @keyframes fb-hr-pulse { 0%,100% { opacity: 1; transform: scale(1); } 50% { opacity: .35; transform: scale(1.35); } }
                    `
                    document.head.appendChild(s)
                }
                const TIP = "Fun.Blazor hot reload: edit a file marked // hot-reload and save to apply changes in place."
                let toastTimer = null
                const toast = (msg, kind) => {
                    ensureStyle()
                    let el = document.querySelector(".fb-hr-toast")
                    if (!el) { el = document.createElement("div"); el.className = "fb-hr-toast"; el.title = TIP; document.body.appendChild(el) }
                    el.innerHTML = ""
                    const dot = document.createElement("span")
                    dot.className = "fb-hr-dot " + (kind || "info")
                    el.appendChild(dot)
                    el.appendChild(document.createTextNode(msg))
                    el.classList.add("fb-hr-show")
                    if (toastTimer) clearTimeout(toastTimer)
                    toastTimer = setTimeout(() => el.classList.remove("fb-hr-show"), 3000)
                }
                const setWatching = (on) => {
                    ensureStyle()
                    let el = document.querySelector(".fb-hr-watch")
                    if (on && !el) {
                        el = document.createElement("div")
                        el.className = "fb-hr-watch"
                        el.title = TIP
                        el.style.pointerEvents = "auto"
                        document.body.appendChild(el)
                    }
                    else if (!on && el) el.remove()
                }
                return {
                    ready:   () => toast("Hot reload ready — edits will be applied", "ready"),
                    indexed: () => toast("Hot reload indexed", "ready"),
                    applied: () => { setWatching(false); toast("Hot reload applied", "ready") },
                    watching: () => setWatching(true)
                }
            })()
        """


type private CssChanges = { Name: string; Css: string }

type private HubBundle =
    {
        Hub: HubConnection
        CodeObserver: aval<(string * FSharp.Compiler.PortaCode.CodeModel.DFile) []>
        CssObserver: aval<CssChanges>
    }


module private Cache =

    let mutable lastRenderFns = ConcurrentDictionary<string, obj>()

    let private hubLocker = obj ()

    let mutable private hubConnections = Dictionary<string, HubBundle>()


    let private makeHubBundle (host: string) =
        let hub = HubConnectionBuilder().WithUrl($"{host}/hot-reload-hub").Build()
        let codeStore = cval<(string * FSharp.Compiler.PortaCode.CodeModel.DFile) []> ([||])
        let cssStore = cval<CssChanges> ({ Name = ""; Css = "" })

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
            CodeObserver = codeStore
            CssObserver = cssStore
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


type HotReloadComponent<'T>() as this =
    inherit FunComponent()

    let mutable disposes: IDisposable list = []


    let setRender r =
        this.RenderFn <- r
        this.ForceRerender()


    [<Parameter>]
    member val RenderFn = fun (_: 'T) -> html.none with get, set

    [<Parameter>]
    member val RenderFnArg = Unchecked.defaultof<'T> with get, set

    [<Parameter>]
    member val RenderEntryName = "" with get, set

    [<Parameter>]
    member val Host = "" with get, set


    [<Inject>]
    member val GlobalStore = Unchecked.defaultof<IGlobalStore> with get, set

    [<Inject>]
    member val JS: IJSRuntime = Unchecked.defaultof<IJSRuntime> with get, set


    override _.Render() = this.RenderFn this.RenderFnArg

    // Fire-and-forget JS UI feedback. Injects the feedback UI once if the host page
    // didn't include the hotReloadJSInterop script, so it works out of the box.
    // No-ops silently if JS interop isn't available yet (e.g. prerendering).
    member private this.invokeUI(fn: string) =
        task {
            try
                let! exists = this.JS.InvokeAsync<bool>("eval", "typeof window.hotReloadUI !== 'undefined'").AsTask()
                if not exists then
                    do! this.JS.InvokeAsync<obj>("eval", UIScript).AsTask() :> System.Threading.Tasks.Task
                do! this.JS.InvokeAsync<obj>(fn).AsTask() :> System.Threading.Tasks.Task
            with
            | _ -> ()
        }
        |> ignore


    override _.OnAfterRender(firstRender) =
        if firstRender then
            let hubBundle = Cache.getHubBundle this.Host

            // Tell the watch server which render entry this component owns, so the server
            // re-sends the entry's file when one of its helper files changes (keeping the
            // per-save re-check small instead of re-checking every hot-reload file). The
            // hub connects asynchronously, so wait for it to be connected (and re-register
            // on reconnect).
            let registerEntry () =
                task {
                    try
                        if hubBundle.Hub.State = HubConnectionState.Connected then
                            do! hubBundle.Hub.InvokeAsync("RegisterEntry", this.RenderEntryName)
                            // Connected and the entry is registered: the server has indexed
                            // the project and this entry will receive edits.
                            this.invokeUI "hotReloadUI.ready"
                            this.invokeUI "hotReloadUI.indexed"
                    with
                    | ex -> printfn "RegisterEntry failed: %s" ex.Message
                }

            // Wait until the (async) connection is up, then register; also re-register on reconnect.
            let rec waitAndRegister attempts =
                task {
                    if hubBundle.Hub.State = HubConnectionState.Connected then
                        do! registerEntry ()
                    elif attempts > 0 then
                        do! System.Threading.Tasks.Task.Delay 500
                        do! waitAndRegister (attempts - 1)
                }

            waitAndRegister 60 |> ignore
            hubBundle.Hub.add_Reconnected (fun _ -> task { do! registerEntry () } :> System.Threading.Tasks.Task)

            disposes <-
                [
                    hubBundle.CodeObserver.AddInstantCallback(fun code ->
                        // A change arrived from the watcher: show the "watching" indicator
                        // until the new render is applied.
                        this.invokeUI "hotReloadUI.watching"
                        Utils.reload<'T>
                            this.RenderEntryName
                            code
                            (fun x ->
                                Cache.lastRenderFns.AddOrUpdate(this.RenderEntryName, (fun _ -> box x), (fun _ _ -> box x))
                                setRender x
                                this.invokeUI "hotReloadUI.applied"
                            )
                    )

                    hubBundle.CssObserver.AddInstantCallback(fun data ->
                        this.JS.InvokeAsync("hotReloadStyle", $"hot-reload-css-{this.Host.GetHashCode()}-{data.Name.GetHashCode()}", data.Css)
                        |> ignore
                    )
                ]

            match Cache.lastRenderFns.TryGetValue this.RenderEntryName with
            | true, x -> setRender (unbox x)
            | _ -> ()


    interface IDisposable with
        member _.Dispose() = disposes |> List.iter (fun x -> x.Dispose())
