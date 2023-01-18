namespace Fun.Htmx

open System.Text
open Fun.Result


[<RequireQualifiedAccess>]
type HxQueue =
    | First
    | Last
    | All
    | None


[<RequireQualifiedAccess>]
module hxEvt =

    /// Triggered on load (useful for lazy-loading something)
    [<Literal>]
    let load = "load"

    /// Triggered when an element is scrolled into the viewport (also useful for lazy-loading). If you are using overflow in css like overflow-y: scroll you should use intersect once instead of revealed.
    [<Literal>]
    let revealed = "revealed"

    /// Fires once when an element first intersects the viewport.
    /// This supports two additional options:
    ///
    /// - root:<selector> - a CSS selector of the root element for intersection.
    /// - threshold:<float> - a floating point number between 0.0 and 1.0, indicating what amount of intersection to fire the event on.
    [<Literal>]
    let intersect = "intersect"


    module drag =

        /// Script to be run when an element is dragged
        [<Literal>]
        let drag = "drag"

        /// Script to be run at the end of a drag operation
        [<Literal>]
        let dragend = "dragend"

        /// Script to be run when an element has been dragged to a valid drop target
        [<Literal>]
        let dragenter = "dragenter"

        /// Script to be run when an element leaves a valid drop target
        [<Literal>]
        let dragleave = "dragleave"

        /// Script to be run when an element is being dragged over a valid drop target
        [<Literal>]
        let dragover = "dragover"

        /// Script to be run at the start of a drag operation
        [<Literal>]
        let dragstart = "dragstart"

        /// Script to be run when dragged element is being dropped
        [<Literal>]
        let drop = "drop"

        /// Script to be run when an element's scrollbar is being scrolled
        [<Literal>]
        let scroll = "scroll"

    module clipboard =

        /// Fires when the user copies the content of an element
        [<Literal>]
        let copy = "copy"

        /// Fires when the user cuts the content of an element
        [<Literal>]
        let cut = "cut"

        /// Fires when the user pastes some content in an element
        [<Literal>]
        let paste = "paste"

    module form =

        /// Fires the moment that the element loses focus
        [<Literal>]
        let blur = "blur"

        /// Fires the moment when the value of the element is changed
        [<Literal>]
        let change = "change"

        /// Script to be run when a context menu is triggered
        [<Literal>]
        let contextmenu = "contextmenu"

        /// Fires the moment when the element gets focus
        [<Literal>]
        let focus = "focus"

        /// Script to be run when an element gets user input
        [<Literal>]
        let input = "input"

        /// Script to be run when an element is invalid
        [<Literal>]
        let invalid = "invalid"

        /// Fires when the Reset button in a form is clicked
        [<Literal>]
        let reset = "reset"

        /// Fires when the user writes something in a search field (for <input="search">)
        [<Literal>]
        let search = "search"

        /// Fires after some text has been selected in an element
        [<Literal>]
        let select = "select"

        /// Fires when a form is submitted
        [<Literal>]
        let submit = "submit"

    module keyboard =

        /// Fires when a user is pressing a key
        [<Literal>]
        let keydown = "keydown"

        /// Fires when a user presses a key
        [<Literal>]
        let keypress = "keypress"

        /// Fires when a user releases a key
        [<Literal>]
        let keyup = "keyup"

    module media =

        /// Script to be run on abort
        [<Literal>]
        let abort = "abort"

        /// Script to be run when a file is ready to start playing (when it has buffered enough to begin)
        [<Literal>]
        let canplay = "canplay"

        /// Script to be run when a file can be played all the way to the end without pausing for buffering
        [<Literal>]
        let canplaythrough = "canplaythrough"

        /// Script to be run when the cue changes in a <track> element
        [<Literal>]
        let cuechange = "cuechange"

        /// Script to be run when the length of the media changes
        [<Literal>]
        let durationchange = "durationchange"

        /// Script to be run when something bad happens and the file is suddenly unavailable (like unexpectedly disconnects)
        [<Literal>]
        let emptied = "emptied"

        /// Script to be run when the media has reach the end (a useful event for messages like "thanks for listening")
        [<Literal>]
        let ended = "ended"

        /// Script to be run when an error occurs when the file is being loaded
        [<Literal>]
        let error = "error"

        /// Script to be run when media data is loaded
        [<Literal>]
        let loadeddata = "loadeddata"

        /// Script to be run when meta data (like dimensions and duration) are loaded
        [<Literal>]
        let loadedmetadata = "loadedmetadata"

        /// Script to be run just as the file begins to load before anything is actually loaded
        [<Literal>]
        let loadstart = "loadstart"

        /// Script to be run when the media is paused either by the user or programmatically
        [<Literal>]
        let pause = "pause"

        /// Script to be run when the media is ready to start playing
        [<Literal>]
        let play = "play"

        /// Script to be run when the media actually has started playing
        [<Literal>]
        let playing = "playing"

        /// Script to be run when the browser is in the process of getting the media data
        [<Literal>]
        let progress = "progress"

        /// Script to be run each time the playback rate changes (like when a user switches to a slow motion or fast forward mode)
        [<Literal>]
        let ratechange = "ratechange"

        /// Script to be run when the seeking attribute is set to false indicating that seeking has ended
        [<Literal>]
        let seeked = "seeked"

        /// Script to be run when the seeking attribute is set to true indicating that seeking is active
        [<Literal>]
        let seeking = "seeking"

        /// Script to be run when the browser is unable to fetch the media data for whatever reason
        [<Literal>]
        let stalled = "stalled"

        /// Script to be run when fetching the media data is stopped before it is completely loaded for whatever reason
        [<Literal>]
        let suspend = "suspend"

        /// Script to be run when the playing position has changed (like when the user fast forwards to a different point in the media)
        [<Literal>]
        let timeupdate = "timeupdate"

        /// Script to be run each time the volume is changed which (includes setting the volume to "mute")
        [<Literal>]
        let volumechange = "volumechange"

        /// Script to be run when the media has paused but is expected to resume (like when the media pauses to buffer more data)
        [<Literal>]
        let waiting = "waiting"

    module misc =

        /// Fires when the user opens or closes the <details> element
        [<Literal>]
        let toggle = "toggle"

    module mouse =

        /// Fires on a mouse click on the element
        [<Literal>]
        let click = "click"

        /// Fires on a mouse double-click on the element
        [<Literal>]
        let dblclick = "dblclick"

        /// Fires when a mouse button is pressed down on an element
        [<Literal>]
        let mousedown = "mousedown"

        /// Fires when the mouse pointer is moving while it is over an element
        [<Literal>]
        let mousemove = "mousemove"

        /// Fires when the mouse pointer moves out of an element
        [<Literal>]
        let mouseout = "mouseout"

        /// Fires when the mouse pointer moves over an element
        [<Literal>]
        let mouseover = "mouseover"

        /// Fires when a mouse button is released over an element
        [<Literal>]
        let mouseup = "mouseup"

        /// Deprecated. Use the onwheel attribute instead
        [<Literal>]
        let mousewheel = "mousewheel"

        /// Fires when the mouse wheel rolls up or down over an element
        [<Literal>]
        let wheel = "wheel"

    module window =

        /// Script to be run after the document is printed
        [<Literal>]
        let afterprint = "afterprint"

        /// Script to be run before the document is printed
        [<Literal>]
        let beforeprint = "beforeprint"

        /// Script to be run when the document is about to be unloaded
        [<Literal>]
        let beforeunload = "beforeunload"

        /// Script to be run when an error occurs
        [<Literal>]
        let error = "error"

        /// Script to be run when there has been changes to the anchor part of the a URL
        [<Literal>]
        let hashchange = "hashchange"

        // Fires after the page is finished loading
        //[<Literal>]
        //let load = "load"

        /// Script to be run when the message is triggered
        [<Literal>]
        let message = "message"

        /// Script to be run when the browser starts to work offline
        [<Literal>]
        let offline = "offline"

        /// Script to be run when the browser starts to work online
        [<Literal>]
        let online = "online"

        /// Script to be run when a user navigates away from a page
        [<Literal>]
        let pagehide = "pagehide"

        /// Script to be run when a user navigates to a page
        [<Literal>]
        let pageshow = "pageshow"

        /// Script to be run when the window's history changes
        [<Literal>]
        let popstate = "popstate"

        /// Fires when the browser window is resized
        [<Literal>]
        let resize = "resize"

        /// Script to be run when a Web Storage area is updated
        [<Literal>]
        let storage = "storage"

        /// Fires once a page has unloaded (or the browser window has been closed)
        [<Literal>]
        let unload = "unload"


/// This will build a trigger.
/// You can yield this in your html CE builder like: div { HxTrigger(hxEvt.load) } or div { hxTrigger'(hxEvt.load) }. 
type HxTrigger(event: string, ?sse, ?once, ?filter, ?changed, ?delayMs, ?throttleMs, ?from, ?target, ?consume, ?queue, ?root, ?threshold) as this =
    let sb = new StringBuilder()

    do
        this.AddTrigger(
            event,
            sse = defaultArg sse false,
            once = defaultArg once false,
            filter = defaultArg filter "",
            changed = defaultArg changed false,
            delayMs = defaultArg delayMs 0,
            throttleMs = defaultArg throttleMs 0,
            from = defaultArg from "",
            target = defaultArg target "",
            consume = defaultArg consume false,
            queue = defaultArg queue HxQueue.None,
            root = defaultArg root "",
            threshold = defaultArg threshold 0.
        )
        |> ignore


    member this.AddTrigger
        (
            event: string,
            ?sse: bool,
            ?filter: string,
            ?once: bool,
            ?changed: bool,
            ?delayMs: int,
            ?throttleMs: int,
            ?from: string,
            ?target: string,
            ?consume: bool,
            ?queue: HxQueue,
            ?root: string,
            ?threshold: float
        )
        =
        if sb.Length > 0 then sb.Append(", ") |> ignore

        match sse with
        | Some true -> sb.Append("sse:") |> ignore
        | _ -> ()

        sb.Append(event) |> ignore

        match filter with
        | Some (SafeString f) -> sb.Append("[").Append(f).Append("]") |> ignore
        | _ -> ()

        match once with
        | Some true -> sb.Append(" once") |> ignore
        | _ -> ()

        match changed with
        | Some true -> sb.Append(" changed") |> ignore
        | _ -> ()

        match delayMs with
        | Some d when d > 0 -> sb.Append(" delay:").Append(d).Append("ms") |> ignore
        | _ -> ()

        match throttleMs with
        | Some t when t > 0 -> sb.Append(" throttle:").Append(t).Append("ms") |> ignore
        | _ -> ()

        match from with
        | Some (SafeString f) -> sb.Append(" from:").Append(f) |> ignore
        | _ -> ()

        match target with
        | Some (SafeString t) -> sb.Append(" target:").Append(t) |> ignore
        | _ -> ()

        match consume with
        | Some true -> sb.Append(" consume") |> ignore
        | _ -> ()

        match queue with
        | Some HxQueue.None -> ()
        | Some q -> sb.Append(" queue:").Append(q.ToString().ToLower()) |> ignore
        | _ -> ()

        if event = hxEvt.intersect then
            match root with
            | Some (SafeString x) -> sb.Append(" root:").Append(x) |> ignore
            | _ -> ()

            match threshold with
            | Some x when 0. < x && x < 1. -> sb.Append(" threshold:").Append(x) |> ignore
            | _ -> ()

        this


    override _.ToString() = sb.ToString()

/// This will build a trigger.
/// You can yield this in your html CE builder like: div { hxTrigger'(hxEvt.load) }. 
type hxTrigger' = HxTrigger


/// Allows you to specify that some content in a response should be swapped into the DOM somewhere other than the target, that is "Out of Band". This allows you to piggy back updates to other element updates on a response
type OOB = 
    /// Allows you to specify that some content in a response should be swapped into the DOM somewhere other than the target, that is "Out of Band". This allows you to piggy back updates to other element updates on a response
    | OOB
    | NONE_OOB

[<RequireQualifiedAccess>]
module hxSwapTypes =
    [<Literal>]
    let innerHTML = "innerHTML"
    
    [<Literal>]
    let outerHTML = "outerHTML"
    
    [<Literal>]
    let afterbegin = "afterbegin"
    
    [<Literal>]
    let beforebegin = "beforebegin"
    
    [<Literal>]
    let beforeend = "beforeend"
    
    [<Literal>]
    let afterend = "afterend"
    
    [<Literal>]
    let delete = "delete"
    
    [<Literal>]
    let none = "none"


/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { HxSwapAndModifier(hxSwapTypes.innerHTML) }
type HxSwapAndModifier(ty: string, ?oob: OOB) =
    let dicts = System.Collections.Generic.Dictionary<string, string>()

    member _.Type = ty
    member _.OOB = oob

    /// You can modify the amount of time that htmx will wait after receiving a response to swap the content by including a swap modifier
    member this.Swap(ms: int) =
        dicts["swap"] <- string ms
        this

    /// You can modify the time between the swap and the settle logic by including a settle modifier
    member this.Settle(ms: int) =
        dicts["settle"] <- string ms
        this


    member this.ScrollTop(?target: string) =
        dicts["scroll"] <-
            match target with
            | Some (SafeString x) -> x + ":top"
            | _ -> "top"
        this

    member this.ScrollBottom(?target: string) =
        dicts["scroll"] <-
            match target with
            | Some (SafeString x) -> x + ":bottom"
            | _ -> "bottom"
        this

    member this.ShowTop(?target: string) =
        dicts["show"] <-
            match target with
            | Some (SafeString x) -> x + ":top"
            | _ -> "top"
        this

    member this.ShowBottom(?target: string) =
        dicts["show"] <-
            match target with
            | Some (SafeString x) -> x + ":bottom"
            | _ -> "bottom"
        this


    member this.FocusScroll(x: bool) =
        dicts["focus-scroll"] <- if x then "true" else "false"
        this


    override _.ToString() =
        let sb = new StringBuilder()
        sb.Append(ty) |> ignore
        for KeyValue (k, v) in dicts do
            if sb.Length > 0 then sb.Append(" ") |> ignore
            sb.Append(k).Append(":").Append(v) |> ignore
        sb.ToString()


/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { hxSwap_innerHTML'() }
type hxSwap_innerHTML'(?oob) =
    inherit HxSwapAndModifier("innerHTML", defaultArg oob NONE_OOB)

/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { hxSwap_outerHTML'() }
type hxSwap_outerHTML'(?oob) =
    inherit HxSwapAndModifier("outerHTML", defaultArg oob NONE_OOB)

/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { hxSwap_afterbegin'() }
type hxSwap_afterbegin'(?oob) =
    inherit HxSwapAndModifier("afterbegin", defaultArg oob NONE_OOB)

/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { hxSwap_beforebegin'() }
type hxSwap_beforebegin'(?oob) =
    inherit HxSwapAndModifier("beforebegin", defaultArg oob NONE_OOB)

/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { hxSwap_beforeend'() }
type hxSwap_beforeend'(?oob) =
    inherit HxSwapAndModifier("beforeend", defaultArg oob NONE_OOB)

/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { hxSwap_afterend'() }
type hxSwap_afterend'(?oob) =
    inherit HxSwapAndModifier("afterend", defaultArg oob NONE_OOB)

/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { hxSwap_delete'() }
type hxSwap_delete'(?oob) =
    inherit HxSwapAndModifier("delete", defaultArg oob NONE_OOB)

/// It will build a swap value.
/// You can yield this in the target html CE builder like: div { hxSwap_none'() }
type hxSwap_none'(?oob) =
    inherit HxSwapAndModifier("none", defaultArg oob NONE_OOB)
