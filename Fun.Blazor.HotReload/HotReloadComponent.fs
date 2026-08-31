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


/// Self-contained JS for the hot-reload feedback UI: a status banner fixed to the
/// bottom of the page that logs timestamped messages, so the developer can see what is
/// happening behind the scenes. Injected at runtime by HotReloadComponent when the host
/// page didn't include hotReloadJSInterop. Toggle visibility with Ctrl+Alt+H.
[<AutoOpen>]
module HotReloadUI =
    let UIScript =
        """
            // Hot-reload status banner: a fixed bottom bar that logs timestamped messages
            // (connecting, indexed, applying, applied). Toggle with Ctrl+Alt+H.
            window.hotReloadUI = (() => {
                const STYLE_ID = "fun-blazor-hot-reload-ui-style"
                const BANNER_ID = "fun-blazor-hot-reload-banner"
                const ensureStyle = () => {
                    if (document.getElementById(STYLE_ID)) return
                    const s = document.createElement("style")
                    s.id = STYLE_ID
                    s.innerText = `
                        #${BANNER_ID} {
                            position: fixed; left: 0; right: 0; bottom: 0; z-index: 99999;
                            background: rgba(24,24,24,.97); color: #d4d4d4;
                            font: 12px/1.5 ui-monospace, SFMono-Regular, Menlo, Consolas, monospace;
                            border-top: 1px solid #3a3a3a; box-shadow: 0 -2px 12px rgba(0,0,0,.4);
                            display: flex; flex-direction: column; max-height: 132px;
                        }
                        #${BANNER_ID} .fb-hr-head {
                            display: flex; align-items: center; gap: 8px; padding: 4px 12px;
                            background: rgba(45,45,45,.9); color: #fff; flex: 0 0 auto; cursor: pointer; user-select: none;
                        }
                        #${BANNER_ID} .fb-hr-head .fb-hr-dot { width: 8px; height: 8px; border-radius: 50%; background: #888; flex: 0 0 auto; }
                        #${BANNER_ID}[data-state="ready"]    .fb-hr-head .fb-hr-dot { background: #4caf50; }
                        #${BANNER_ID}[data-state="watching"] .fb-hr-head .fb-hr-dot { background: #ff9800; animation: fb-hr-pulse 1s ease-in-out infinite; }
                        #${BANNER_ID}[data-state="error"]    .fb-hr-head .fb-hr-dot { background: #f44336; }
                        #${BANNER_ID} .fb-hr-head .fb-hr-title { font-weight: 600; letter-spacing: .3px; }
                        #${BANNER_ID} .fb-hr-head .fb-hr-state { margin-left: auto; color: #aaa; }
                        #${BANNER_ID} .fb-hr-head .fb-hr-hint { color: #777; font-size: 11px; }
                        #${BANNER_ID} .fb-hr-log { overflow-y: auto; padding: 4px 12px 8px; flex: 1 1 auto; }
                        #${BANNER_ID} .fb-hr-log .fb-hr-line { white-space: pre-wrap; word-break: break-word; }
                        #${BANNER_ID} .fb-hr-log .fb-hr-time { color: #6a9955; margin-right: 8px; }
                        #${BANNER_ID} .fb-hr-log .fb-hr-line.error { color: #f48771; }
                        #${BANNER_ID} .fb-hr-log .fb-hr-line.ok { color: #4ec9b0; }
                        @keyframes fb-hr-pulse { 0%,100% { opacity: 1; } 50% { opacity: .3; } }
                    `
                    document.head.appendChild(s)
                }
                const banner = () => {
                    ensureStyle()
                    let b = document.getElementById(BANNER_ID)
                    if (b) return b
                    b = document.createElement("div")
                    b.id = BANNER_ID
                    b.setAttribute("data-state", "init")
                    b.innerHTML = `
                        <div class="fb-hr-head" title="Click to collapse / expand">
                            <span class="fb-hr-dot"></span>
                            <span class="fb-hr-title">Fun.Blazor Hot Reload</span>
                            <span class="fb-hr-hint">Ctrl+Alt+H to hide</span>
                            <span class="fb-hr-state">connecting…</span>
                        </div>
                        <div class="fb-hr-log"></div>
                    `
                    b.querySelector(".fb-hr-head").addEventListener("click", () => {
                        const log = b.querySelector(".fb-hr-log")
                        log.style.display = log.style.display === "none" ? "" : "none"
                    })
                    document.body.appendChild(b)
                    return b
                }
                const setState = (state, label) => {
                    const b = banner()
                    b.setAttribute("data-state", state)
                    b.querySelector(".fb-hr-state").textContent = label
                }
                const log = (msg, cls) => {
                    const b = banner()
                    const logEl = b.querySelector(".fb-hr-log")
                    const line = document.createElement("div")
                    line.className = "fb-hr-line" + (cls ? " " + cls : "")
                    const time = document.createElement("span")
                    time.className = "fb-hr-time"
                    time.textContent = new Date().toLocaleTimeString()
                    line.appendChild(time)
                    line.appendChild(document.createTextNode(msg))
                    logEl.appendChild(line)
                    logEl.scrollTop = logEl.scrollHeight
                    while (logEl.children.length > 100) logEl.removeChild(logEl.firstChild)
                }
                // Toggle banner visibility with Ctrl+Alt+H.
                if (!window.__fbHrHotkeyBound) {
                    window.__fbHrHotkeyBound = true
                    document.addEventListener("keydown", (e) => {
                        if (e.ctrlKey && e.altKey && (e.key === "h" || e.key === "H")) {
                            e.preventDefault()
                            const b = document.getElementById(BANNER_ID)
                            if (b) b.style.display = b.style.display === "none" ? "" : "none"
                        }
                    })
                }
                return {
                    ready:   () => { setState("ready", "ready — edits will be applied"); log("Connected to watcher. Edit a file marked // hot-reload and save to apply changes in place.", "ok") },
                    waiting: () => { if (!document.getElementById(BANNER_ID)) { setState("init", "waiting for watcher…"); log("Hot-reload entry is live but the watcher is not reachable yet. Start it with: fun-blazor watch <project.fsproj>. This banner hides again when the watcher connects.") } },
                    indexing: () => { setState("init", "indexing…"); log("Watcher connected, indexing source files (PortaCode cache warming). Edits won't apply until indexing finishes.") },
                    indexed: () => { setState("ready", "ready — edits will be applied"); log("Project indexed: PortaCode cache is warm. Edits to hot-reload files will now be applied in place.", "ok") },
                    watching: () => { setState("watching", "applying changes…"); const b = banner(); if (b.style.display === "none") b.style.display = ""; log("Change detected — re-checking and applying…") },
                    applied: (ms) => { setState("ready", "ready — edits will be applied"); log("Applied" + (ms ? " in " + ms + " ms" : "") + ".", "ok") },
                    error:   (msg) => { setState("error", "error"); log(msg || "Hot reload error", "error") }
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
    member private this.invokeUI(fn: string, [<System.ParamArray>] args: obj []) =
        task {
            try
                let! exists = this.JS.InvokeAsync<bool>("eval", "typeof window.hotReloadUI !== 'undefined'").AsTask()
                if not exists then
                    do! this.JS.InvokeAsync<obj>("eval", UIScript).AsTask() :> System.Threading.Tasks.Task
                do! this.JS.InvokeAsync<obj>(fn, args).AsTask() :> System.Threading.Tasks.Task
            with
            | _ -> ()
        }
        |> ignore


    override _.OnAfterRender(firstRender) =
        if firstRender then
            let hubBundle = Cache.getHubBundle this.Host

            // The server tells us when its one-time startup indexing has finished (and
            // replies with the current state when we RegisterEntry). Only then may the
            // banner claim "ready" — edits sent before indexing completes are dropped.
            hubBundle.Hub.On<bool>(
                "IndexingState",
                fun isDone ->
                    if isDone then
                        this.invokeUI("hotReloadUI.indexed")
                    else
                        this.invokeUI("hotReloadUI.indexing")
            )
            |> ignore

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
                            // Connected and the entry is registered. The server replies
                            // via "IndexingState" with whether its cache is already warm,
                            // which drives the banner's indexing/indexed message.
                            this.invokeUI("hotReloadUI.ready")
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

            // If the watcher is still not connected shortly after startup (e.g. the CLI
            // isn't running), show a one-time hint instead of leaving the page silent.
            task {
                do! System.Threading.Tasks.Task.Delay 5000
                if hubBundle.Hub.State <> HubConnectionState.Connected then
                    this.invokeUI("hotReloadUI.waiting")
            }
            |> ignore

            disposes <-
                [
                    hubBundle.CodeObserver.AddInstantCallback(fun code ->
                        // The observer fires once with its initial empty value when the
                        // callback is attached — that's not a real change, so skip it to
                        // avoid a bogus "Change detected" message when no watcher is up.
                        if not (Array.isEmpty code) then
                            // A change arrived from the watcher: show the banner in the
                            // "applying" state until the new render is applied.
                            this.invokeUI("hotReloadUI.watching")
                            let sw = System.Diagnostics.Stopwatch.StartNew()
                            try
                                Utils.reload<'T>
                                    this.RenderEntryName
                                    code
                                    (fun x ->
                                        Cache.lastRenderFns.AddOrUpdate(this.RenderEntryName, (fun _ -> box x), (fun _ _ -> box x))
                                        setRender x
                                        this.invokeUI("hotReloadUI.applied", box sw.ElapsedMilliseconds)
                                    )
                            with
                            | ex ->
                                printfn "LiveUpdate failed: %s" ex.Message
                                this.invokeUI("hotReloadUI.error", box ($"Apply failed: {ex.Message}. See browser console for details."))
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
