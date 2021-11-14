namespace Fun.Blazor

open System
open System.Threading.Tasks
open System.Globalization

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web

open Bolero
open Bolero.Html


/// Event handlers.
module evt =
    let inline boleroCallback<'T> name callback =
        attr.callback<'T> name callback
        |> FunBlazorNode.BoleroAttr

    let inline callbackOfUnit name fn =
        ExplicitAttr (Func<_,_,_,_>(fun builder sequence receiver ->
            builder.AddAttribute(sequence, name, EventCallback.Factory.Create(receiver, Action(fn)))
            sequence + 1))
        |> FunBlazorNode.BoleroAttr

    /// Create a handler for a HTML event of type EventArgs.
    let inline event<'T when 'T :> EventArgs> eventName (callback: ^T -> unit) =
        boleroCallback<'T> ("on" + eventName) callback

    /// Prevent the default event behavior for a given HTML event.
    let inline preventDefault eventName (value: bool) =
        ExplicitAttr (Func<_,_,_,_>(fun builder sequence _receiver ->
            builder.AddEventPreventDefaultAttribute(sequence, eventName, value)
            sequence + 1
        ))

    /// Stop the propagation to parent elements of a given HTML event.
    let inline stopPropagation eventName (value: bool) =
        ExplicitAttr (Func<_,_,_,_>(fun builder sequence _receiver ->
            builder.AddEventStopPropagationAttribute(sequence, eventName, value)
            sequence + 1
        ))

// BEGIN EVENTS
    /// Create a handler for HTML event `focus`.
    let inline focus (callback: FocusEventArgs -> unit) =
        boleroCallback<FocusEventArgs> ("onfocus") callback

    /// Create a handler for HTML event `blur`.
    let inline blur (callback: FocusEventArgs -> unit) =
        boleroCallback<FocusEventArgs> ("onblur") callback

    /// Create a handler for HTML event `focusin`.
    let inline focusin (callback: FocusEventArgs -> unit) =
        boleroCallback<FocusEventArgs> ("onfocusin") callback

    /// Create a handler for HTML event `focusout`.
    let inline focusout (callback: FocusEventArgs -> unit) =
        boleroCallback<FocusEventArgs> ("onfocusout") callback

    /// Create a handler for HTML event `mouseover`.
    let inline mouseover (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("onmouseover") callback

    /// Create a handler for HTML event `mouseout`.
    let inline mouseout (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("onmouseout") callback

    /// Create a handler for HTML event `mousemove`.
    let inline mousemove (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("onmousemove") callback

    /// Create a handler for HTML event `mousedown`.
    let inline mousedown (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("onmousedown") callback

    /// Create a handler for HTML event `mouseup`.
    let inline mouseup (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("onmouseup") callback

    /// Create a handler for HTML event `click`.
    let inline click (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("onclick") callback

    /// Create a handler for HTML event `dblclick`.
    let inline dblclick (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("ondblclick") callback

    /// Create a handler for HTML event `wheel`.
    let inline wheel (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("onwheel") callback

    /// Create a handler for HTML event `mousewheel`.
    let inline mousewheel (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("onmousewheel") callback

    /// Create a handler for HTML event `contextmenu`.
    let inline contextmenu (callback: MouseEventArgs -> unit) =
        boleroCallback<MouseEventArgs> ("oncontextmenu") callback

    /// Create a handler for HTML event `drag`.
    let inline drag (callback: DragEventArgs -> unit) =
        boleroCallback<DragEventArgs> ("ondrag") callback

    /// Create a handler for HTML event `dragend`.
    let inline dragend (callback: DragEventArgs -> unit) =
        boleroCallback<DragEventArgs> ("ondragend") callback

    /// Create a handler for HTML event `dragenter`.
    let inline dragenter (callback: DragEventArgs -> unit) =
        boleroCallback<DragEventArgs> ("ondragenter") callback

    /// Create a handler for HTML event `dragleave`.
    let inline dragleave (callback: DragEventArgs -> unit) =
        boleroCallback<DragEventArgs> ("ondragleave") callback

    /// Create a handler for HTML event `dragover`.
    let inline dragover (callback: DragEventArgs -> unit) =
        boleroCallback<DragEventArgs> ("ondragover") callback

    /// Create a handler for HTML event `dragstart`.
    let inline dragstart (callback: DragEventArgs -> unit) =
        boleroCallback<DragEventArgs> ("ondragstart") callback

    /// Create a handler for HTML event `drop`.
    let inline drop (callback: DragEventArgs -> unit) =
        boleroCallback<DragEventArgs> ("ondrop") callback

    /// Create a handler for HTML event `keydown`.
    let inline keydown (callback: KeyboardEventArgs -> unit) =
        boleroCallback<KeyboardEventArgs> ("onkeydown") callback

    /// Create a handler for HTML event `keyup`.
    let inline keyup (callback: KeyboardEventArgs -> unit) =
        boleroCallback<KeyboardEventArgs> ("onkeyup") callback

    /// Create a handler for HTML event `keypress`.
    let inline keypress (callback: KeyboardEventArgs -> unit) =
        boleroCallback<KeyboardEventArgs> ("onkeypress") callback

    /// Create a handler for HTML event `change`.
    let inline change (callback: ChangeEventArgs -> unit) =
        boleroCallback<ChangeEventArgs> ("onchange") callback

    /// Create a handler for HTML event `input`.
    let inline input (callback: ChangeEventArgs -> unit) =
        boleroCallback<ChangeEventArgs> ("oninput") callback

    /// Create a handler for HTML event `invalid`.
    let inline invalid (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("oninvalid") callback

    /// Create a handler for HTML event `reset`.
    let inline reset (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onreset") callback

    /// Create a handler for HTML event `select`.
    let inline select (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onselect") callback

    /// Create a handler for HTML event `selectstart`.
    let inline selectstart (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onselectstart") callback

    /// Create a handler for HTML event `selectionchange`.
    let inline selectionchange (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onselectionchange") callback

    /// Create a handler for HTML event `submit`.
    let inline submit (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onsubmit") callback

    /// Create a handler for HTML event `beforecopy`.
    let inline beforecopy (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onbeforecopy") callback

    /// Create a handler for HTML event `beforecut`.
    let inline beforecut (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onbeforecut") callback

    /// Create a handler for HTML event `beforepaste`.
    let inline beforepaste (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onbeforepaste") callback

    /// Create a handler for HTML event `copy`.
    let inline copy (callback: ClipboardEventArgs -> unit) =
        boleroCallback<ClipboardEventArgs> ("oncopy") callback

    /// Create a handler for HTML event `cut`.
    let inline cut (callback: ClipboardEventArgs -> unit) =
        boleroCallback<ClipboardEventArgs> ("oncut") callback

    /// Create a handler for HTML event `paste`.
    let inline paste (callback: ClipboardEventArgs -> unit) =
        boleroCallback<ClipboardEventArgs> ("onpaste") callback

    /// Create a handler for HTML event `touchcancel`.
    let inline touchcancel (callback: TouchEventArgs -> unit) =
        boleroCallback<TouchEventArgs> ("ontouchcancel") callback

    /// Create a handler for HTML event `touchend`.
    let inline touchend (callback: TouchEventArgs -> unit) =
        boleroCallback<TouchEventArgs> ("ontouchend") callback

    /// Create a handler for HTML event `touchmove`.
    let inline touchmove (callback: TouchEventArgs -> unit) =
        boleroCallback<TouchEventArgs> ("ontouchmove") callback

    /// Create a handler for HTML event `touchstart`.
    let inline touchstart (callback: TouchEventArgs -> unit) =
        boleroCallback<TouchEventArgs> ("ontouchstart") callback

    /// Create a handler for HTML event `touchenter`.
    let inline touchenter (callback: TouchEventArgs -> unit) =
        boleroCallback<TouchEventArgs> ("ontouchenter") callback

    /// Create a handler for HTML event `touchleave`.
    let inline touchleave (callback: TouchEventArgs -> unit) =
        boleroCallback<TouchEventArgs> ("ontouchleave") callback

    /// Create a handler for HTML event `pointercapture`.
    let inline pointercapture (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointercapture") callback

    /// Create a handler for HTML event `lostpointercapture`.
    let inline lostpointercapture (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onlostpointercapture") callback

    /// Create a handler for HTML event `pointercancel`.
    let inline pointercancel (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointercancel") callback

    /// Create a handler for HTML event `pointerdown`.
    let inline pointerdown (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointerdown") callback

    /// Create a handler for HTML event `pointerenter`.
    let inline pointerenter (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointerenter") callback

    /// Create a handler for HTML event `pointerleave`.
    let inline pointerleave (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointerleave") callback

    /// Create a handler for HTML event `pointermove`.
    let inline pointermove (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointermove") callback

    /// Create a handler for HTML event `pointerout`.
    let inline pointerout (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointerout") callback

    /// Create a handler for HTML event `pointerover`.
    let inline pointerover (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointerover") callback

    /// Create a handler for HTML event `pointerup`.
    let inline pointerup (callback: PointerEventArgs -> unit) =
        boleroCallback<PointerEventArgs> ("onpointerup") callback

    /// Create a handler for HTML event `canplay`.
    let inline canplay (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("oncanplay") callback

    /// Create a handler for HTML event `canplaythrough`.
    let inline canplaythrough (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("oncanplaythrough") callback

    /// Create a handler for HTML event `cuechange`.
    let inline cuechange (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("oncuechange") callback

    /// Create a handler for HTML event `durationchange`.
    let inline durationchange (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("ondurationchange") callback

    /// Create a handler for HTML event `emptied`.
    let inline emptied (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onemptied") callback

    /// Create a handler for HTML event `pause`.
    let inline pause (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onpause") callback

    /// Create a handler for HTML event `play`.
    let inline play (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onplay") callback

    /// Create a handler for HTML event `playing`.
    let inline playing (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onplaying") callback

    /// Create a handler for HTML event `ratechange`.
    let inline ratechange (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onratechange") callback

    /// Create a handler for HTML event `seeked`.
    let inline seeked (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onseeked") callback

    /// Create a handler for HTML event `seeking`.
    let inline seeking (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onseeking") callback

    /// Create a handler for HTML event `stalled`.
    let inline stalled (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onstalled") callback

    /// Create a handler for HTML event `stop`.
    let inline stop (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onstop") callback

    /// Create a handler for HTML event `suspend`.
    let inline suspend (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onsuspend") callback

    /// Create a handler for HTML event `timeupdate`.
    let inline timeupdate (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("ontimeupdate") callback

    /// Create a handler for HTML event `volumechange`.
    let inline volumechange (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onvolumechange") callback

    /// Create a handler for HTML event `waiting`.
    let inline waiting (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onwaiting") callback

    /// Create a handler for HTML event `loadstart`.
    let inline loadstart (callback: ProgressEventArgs -> unit) =
        boleroCallback<ProgressEventArgs> ("onloadstart") callback

    /// Create a handler for HTML event `timeout`.
    let inline timeout (callback: ProgressEventArgs -> unit) =
        boleroCallback<ProgressEventArgs> ("ontimeout") callback

    /// Create a handler for HTML event `abort`.
    let inline abort (callback: ProgressEventArgs -> unit) =
        boleroCallback<ProgressEventArgs> ("onabort") callback

    /// Create a handler for HTML event `load`.
    let inline load (callback: ProgressEventArgs -> unit) =
        boleroCallback<ProgressEventArgs> ("onload") callback

    /// Create a handler for HTML event `loadend`.
    let inline loadend (callback: ProgressEventArgs -> unit) =
        boleroCallback<ProgressEventArgs> ("onloadend") callback

    /// Create a handler for HTML event `progress`.
    let inline progress (callback: ProgressEventArgs -> unit) =
        boleroCallback<ProgressEventArgs> ("onprogress") callback

    /// Create a handler for HTML event `error`.
    let inline error (callback: ProgressEventArgs -> unit) =
        boleroCallback<ProgressEventArgs> ("onerror") callback

    /// Create a handler for HTML event `activate`.
    let inline activate (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onactivate") callback

    /// Create a handler for HTML event `beforeactivate`.
    let inline beforeactivate (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onbeforeactivate") callback

    /// Create a handler for HTML event `beforedeactivate`.
    let inline beforedeactivate (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onbeforedeactivate") callback

    /// Create a handler for HTML event `deactivate`.
    let inline deactivate (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("ondeactivate") callback

    /// Create a handler for HTML event `ended`.
    let inline ended (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onended") callback

    /// Create a handler for HTML event `fullscreenchange`.
    let inline fullscreenchange (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onfullscreenchange") callback

    /// Create a handler for HTML event `fullscreenerror`.
    let inline fullscreenerror (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onfullscreenerror") callback

    /// Create a handler for HTML event `loadeddata`.
    let inline loadeddata (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onloadeddata") callback

    /// Create a handler for HTML event `loadedmetadata`.
    let inline loadedmetadata (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onloadedmetadata") callback

    /// Create a handler for HTML event `pointerlockchange`.
    let inline pointerlockchange (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onpointerlockchange") callback

    /// Create a handler for HTML event `pointerlockerror`.
    let inline pointerlockerror (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onpointerlockerror") callback

    /// Create a handler for HTML event `readystatechange`.
    let inline readystatechange (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onreadystatechange") callback

    /// Create a handler for HTML event `scroll`.
    let inline scroll (callback: EventArgs -> unit) =
        boleroCallback<EventArgs> ("onscroll") callback

// END EVENTS

    /// Event handlers returning type `Async<unit>`.
    module async =

        /// Create an asynchronous handler for a HTML event of type EventArgs.
        let inline event<'T> eventName (callback: 'T -> Async<unit>) =
            attr.async.callback<'T> ("on" + eventName) callback

// BEGIN ASYNCEVENTS
        /// Create an asynchronous handler for HTML event `focus`.
        let inline focus (callback: FocusEventArgs -> Async<unit>) =
            attr.async.callback<FocusEventArgs> "onfocus" callback
        /// Create an asynchronous handler for HTML event `blur`.
        let inline blur (callback: FocusEventArgs -> Async<unit>) =
            attr.async.callback<FocusEventArgs> "onblur" callback
        /// Create an asynchronous handler for HTML event `focusin`.
        let inline focusin (callback: FocusEventArgs -> Async<unit>) =
            attr.async.callback<FocusEventArgs> "onfocusin" callback
        /// Create an asynchronous handler for HTML event `focusout`.
        let inline focusout (callback: FocusEventArgs -> Async<unit>) =
            attr.async.callback<FocusEventArgs> "onfocusout" callback
        /// Create an asynchronous handler for HTML event `mouseover`.
        let inline mouseover (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "onmouseover" callback
        /// Create an asynchronous handler for HTML event `mouseout`.
        let inline mouseout (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "onmouseout" callback
        /// Create an asynchronous handler for HTML event `mousemove`.
        let inline mousemove (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "onmousemove" callback
        /// Create an asynchronous handler for HTML event `mousedown`.
        let inline mousedown (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "onmousedown" callback
        /// Create an asynchronous handler for HTML event `mouseup`.
        let inline mouseup (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "onmouseup" callback
        /// Create an asynchronous handler for HTML event `click`.
        let inline click (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "onclick" callback
        /// Create an asynchronous handler for HTML event `dblclick`.
        let inline dblclick (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "ondblclick" callback
        /// Create an asynchronous handler for HTML event `wheel`.
        let inline wheel (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "onwheel" callback
        /// Create an asynchronous handler for HTML event `mousewheel`.
        let inline mousewheel (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "onmousewheel" callback
        /// Create an asynchronous handler for HTML event `contextmenu`.
        let inline contextmenu (callback: MouseEventArgs -> Async<unit>) =
            attr.async.callback<MouseEventArgs> "oncontextmenu" callback
        /// Create an asynchronous handler for HTML event `drag`.
        let inline drag (callback: DragEventArgs -> Async<unit>) =
            attr.async.callback<DragEventArgs> "ondrag" callback
        /// Create an asynchronous handler for HTML event `dragend`.
        let inline dragend (callback: DragEventArgs -> Async<unit>) =
            attr.async.callback<DragEventArgs> "ondragend" callback
        /// Create an asynchronous handler for HTML event `dragenter`.
        let inline dragenter (callback: DragEventArgs -> Async<unit>) =
            attr.async.callback<DragEventArgs> "ondragenter" callback
        /// Create an asynchronous handler for HTML event `dragleave`.
        let inline dragleave (callback: DragEventArgs -> Async<unit>) =
            attr.async.callback<DragEventArgs> "ondragleave" callback
        /// Create an asynchronous handler for HTML event `dragover`.
        let inline dragover (callback: DragEventArgs -> Async<unit>) =
            attr.async.callback<DragEventArgs> "ondragover" callback
        /// Create an asynchronous handler for HTML event `dragstart`.
        let inline dragstart (callback: DragEventArgs -> Async<unit>) =
            attr.async.callback<DragEventArgs> "ondragstart" callback
        /// Create an asynchronous handler for HTML event `drop`.
        let inline drop (callback: DragEventArgs -> Async<unit>) =
            attr.async.callback<DragEventArgs> "ondrop" callback
        /// Create an asynchronous handler for HTML event `keydown`.
        let inline keydown (callback: KeyboardEventArgs -> Async<unit>) =
            attr.async.callback<KeyboardEventArgs> "onkeydown" callback
        /// Create an asynchronous handler for HTML event `keyup`.
        let inline keyup (callback: KeyboardEventArgs -> Async<unit>) =
            attr.async.callback<KeyboardEventArgs> "onkeyup" callback
        /// Create an asynchronous handler for HTML event `keypress`.
        let inline keypress (callback: KeyboardEventArgs -> Async<unit>) =
            attr.async.callback<KeyboardEventArgs> "onkeypress" callback
        /// Create an asynchronous handler for HTML event `change`.
        let inline change (callback: ChangeEventArgs -> Async<unit>) =
            attr.async.callback<ChangeEventArgs> "onchange" callback
        /// Create an asynchronous handler for HTML event `input`.
        let inline input (callback: ChangeEventArgs -> Async<unit>) =
            attr.async.callback<ChangeEventArgs> "oninput" callback
        /// Create an asynchronous handler for HTML event `invalid`.
        let inline invalid (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "oninvalid" callback
        /// Create an asynchronous handler for HTML event `reset`.
        let inline reset (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onreset" callback
        /// Create an asynchronous handler for HTML event `select`.
        let inline select (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onselect" callback
        /// Create an asynchronous handler for HTML event `selectstart`.
        let inline selectstart (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onselectstart" callback
        /// Create an asynchronous handler for HTML event `selectionchange`.
        let inline selectionchange (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onselectionchange" callback
        /// Create an asynchronous handler for HTML event `submit`.
        let inline submit (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onsubmit" callback
        /// Create an asynchronous handler for HTML event `beforecopy`.
        let inline beforecopy (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onbeforecopy" callback
        /// Create an asynchronous handler for HTML event `beforecut`.
        let inline beforecut (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onbeforecut" callback
        /// Create an asynchronous handler for HTML event `beforepaste`.
        let inline beforepaste (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onbeforepaste" callback
        /// Create an asynchronous handler for HTML event `copy`.
        let inline copy (callback: ClipboardEventArgs -> Async<unit>) =
            attr.async.callback<ClipboardEventArgs> "oncopy" callback
        /// Create an asynchronous handler for HTML event `cut`.
        let inline cut (callback: ClipboardEventArgs -> Async<unit>) =
            attr.async.callback<ClipboardEventArgs> "oncut" callback
        /// Create an asynchronous handler for HTML event `paste`.
        let inline paste (callback: ClipboardEventArgs -> Async<unit>) =
            attr.async.callback<ClipboardEventArgs> "onpaste" callback
        /// Create an asynchronous handler for HTML event `touchcancel`.
        let inline touchcancel (callback: TouchEventArgs -> Async<unit>) =
            attr.async.callback<TouchEventArgs> "ontouchcancel" callback
        /// Create an asynchronous handler for HTML event `touchend`.
        let inline touchend (callback: TouchEventArgs -> Async<unit>) =
            attr.async.callback<TouchEventArgs> "ontouchend" callback
        /// Create an asynchronous handler for HTML event `touchmove`.
        let inline touchmove (callback: TouchEventArgs -> Async<unit>) =
            attr.async.callback<TouchEventArgs> "ontouchmove" callback
        /// Create an asynchronous handler for HTML event `touchstart`.
        let inline touchstart (callback: TouchEventArgs -> Async<unit>) =
            attr.async.callback<TouchEventArgs> "ontouchstart" callback
        /// Create an asynchronous handler for HTML event `touchenter`.
        let inline touchenter (callback: TouchEventArgs -> Async<unit>) =
            attr.async.callback<TouchEventArgs> "ontouchenter" callback
        /// Create an asynchronous handler for HTML event `touchleave`.
        let inline touchleave (callback: TouchEventArgs -> Async<unit>) =
            attr.async.callback<TouchEventArgs> "ontouchleave" callback
        /// Create an asynchronous handler for HTML event `pointercapture`.
        let inline pointercapture (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointercapture" callback
        /// Create an asynchronous handler for HTML event `lostpointercapture`.
        let inline lostpointercapture (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onlostpointercapture" callback
        /// Create an asynchronous handler for HTML event `pointercancel`.
        let inline pointercancel (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointercancel" callback
        /// Create an asynchronous handler for HTML event `pointerdown`.
        let inline pointerdown (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointerdown" callback
        /// Create an asynchronous handler for HTML event `pointerenter`.
        let inline pointerenter (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointerenter" callback
        /// Create an asynchronous handler for HTML event `pointerleave`.
        let inline pointerleave (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointerleave" callback
        /// Create an asynchronous handler for HTML event `pointermove`.
        let inline pointermove (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointermove" callback
        /// Create an asynchronous handler for HTML event `pointerout`.
        let inline pointerout (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointerout" callback
        /// Create an asynchronous handler for HTML event `pointerover`.
        let inline pointerover (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointerover" callback
        /// Create an asynchronous handler for HTML event `pointerup`.
        let inline pointerup (callback: PointerEventArgs -> Async<unit>) =
            attr.async.callback<PointerEventArgs> "onpointerup" callback
        /// Create an asynchronous handler for HTML event `canplay`.
        let inline canplay (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "oncanplay" callback
        /// Create an asynchronous handler for HTML event `canplaythrough`.
        let inline canplaythrough (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "oncanplaythrough" callback
        /// Create an asynchronous handler for HTML event `cuechange`.
        let inline cuechange (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "oncuechange" callback
        /// Create an asynchronous handler for HTML event `durationchange`.
        let inline durationchange (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "ondurationchange" callback
        /// Create an asynchronous handler for HTML event `emptied`.
        let inline emptied (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onemptied" callback
        /// Create an asynchronous handler for HTML event `pause`.
        let inline pause (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onpause" callback
        /// Create an asynchronous handler for HTML event `play`.
        let inline play (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onplay" callback
        /// Create an asynchronous handler for HTML event `playing`.
        let inline playing (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onplaying" callback
        /// Create an asynchronous handler for HTML event `ratechange`.
        let inline ratechange (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onratechange" callback
        /// Create an asynchronous handler for HTML event `seeked`.
        let inline seeked (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onseeked" callback
        /// Create an asynchronous handler for HTML event `seeking`.
        let inline seeking (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onseeking" callback
        /// Create an asynchronous handler for HTML event `stalled`.
        let inline stalled (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onstalled" callback
        /// Create an asynchronous handler for HTML event `stop`.
        let inline stop (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onstop" callback
        /// Create an asynchronous handler for HTML event `suspend`.
        let inline suspend (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onsuspend" callback
        /// Create an asynchronous handler for HTML event `timeupdate`.
        let inline timeupdate (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "ontimeupdate" callback
        /// Create an asynchronous handler for HTML event `volumechange`.
        let inline volumechange (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onvolumechange" callback
        /// Create an asynchronous handler for HTML event `waiting`.
        let inline waiting (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onwaiting" callback
        /// Create an asynchronous handler for HTML event `loadstart`.
        let inline loadstart (callback: ProgressEventArgs -> Async<unit>) =
            attr.async.callback<ProgressEventArgs> "onloadstart" callback
        /// Create an asynchronous handler for HTML event `timeout`.
        let inline timeout (callback: ProgressEventArgs -> Async<unit>) =
            attr.async.callback<ProgressEventArgs> "ontimeout" callback
        /// Create an asynchronous handler for HTML event `abort`.
        let inline abort (callback: ProgressEventArgs -> Async<unit>) =
            attr.async.callback<ProgressEventArgs> "onabort" callback
        /// Create an asynchronous handler for HTML event `load`.
        let inline load (callback: ProgressEventArgs -> Async<unit>) =
            attr.async.callback<ProgressEventArgs> "onload" callback
        /// Create an asynchronous handler for HTML event `loadend`.
        let inline loadend (callback: ProgressEventArgs -> Async<unit>) =
            attr.async.callback<ProgressEventArgs> "onloadend" callback
        /// Create an asynchronous handler for HTML event `progress`.
        let inline progress (callback: ProgressEventArgs -> Async<unit>) =
            attr.async.callback<ProgressEventArgs> "onprogress" callback
        /// Create an asynchronous handler for HTML event `error`.
        let inline error (callback: ProgressEventArgs -> Async<unit>) =
            attr.async.callback<ProgressEventArgs> "onerror" callback
        /// Create an asynchronous handler for HTML event `activate`.
        let inline activate (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onactivate" callback
        /// Create an asynchronous handler for HTML event `beforeactivate`.
        let inline beforeactivate (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onbeforeactivate" callback
        /// Create an asynchronous handler for HTML event `beforedeactivate`.
        let inline beforedeactivate (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onbeforedeactivate" callback
        /// Create an asynchronous handler for HTML event `deactivate`.
        let inline deactivate (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "ondeactivate" callback
        /// Create an asynchronous handler for HTML event `ended`.
        let inline ended (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onended" callback
        /// Create an asynchronous handler for HTML event `fullscreenchange`.
        let inline fullscreenchange (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onfullscreenchange" callback
        /// Create an asynchronous handler for HTML event `fullscreenerror`.
        let inline fullscreenerror (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onfullscreenerror" callback
        /// Create an asynchronous handler for HTML event `loadeddata`.
        let inline loadeddata (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onloadeddata" callback
        /// Create an asynchronous handler for HTML event `loadedmetadata`.
        let inline loadedmetadata (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onloadedmetadata" callback
        /// Create an asynchronous handler for HTML event `pointerlockchange`.
        let inline pointerlockchange (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onpointerlockchange" callback
        /// Create an asynchronous handler for HTML event `pointerlockerror`.
        let inline pointerlockerror (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onpointerlockerror" callback
        /// Create an asynchronous handler for HTML event `readystatechange`.
        let inline readystatechange (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onreadystatechange" callback
        /// Create an asynchronous handler for HTML event `scroll`.
        let inline scroll (callback: EventArgs -> Async<unit>) =
            attr.async.callback<EventArgs> "onscroll" callback
// END ASYNCEVENTS

    /// Event handlers returning type `Task`.
    module task =

        /// Create an asynchronous handler for a HTML event of type EventArgs.
        let inline event<'T> eventName (callback: 'T -> Task) =
            attr.task.callback<'T> ("on" + eventName) callback

// BEGIN TASKEVENTS
        /// Create an asynchronous handler for HTML event `focus`.
        let inline focus (callback: FocusEventArgs -> Task) =
            attr.task.callback<FocusEventArgs> "onfocus" callback
        /// Create an asynchronous handler for HTML event `blur`.
        let inline blur (callback: FocusEventArgs -> Task) =
            attr.task.callback<FocusEventArgs> "onblur" callback
        /// Create an asynchronous handler for HTML event `focusin`.
        let inline focusin (callback: FocusEventArgs -> Task) =
            attr.task.callback<FocusEventArgs> "onfocusin" callback
        /// Create an asynchronous handler for HTML event `focusout`.
        let inline focusout (callback: FocusEventArgs -> Task) =
            attr.task.callback<FocusEventArgs> "onfocusout" callback
        /// Create an asynchronous handler for HTML event `mouseover`.
        let inline mouseover (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "onmouseover" callback
        /// Create an asynchronous handler for HTML event `mouseout`.
        let inline mouseout (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "onmouseout" callback
        /// Create an asynchronous handler for HTML event `mousemove`.
        let inline mousemove (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "onmousemove" callback
        /// Create an asynchronous handler for HTML event `mousedown`.
        let inline mousedown (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "onmousedown" callback
        /// Create an asynchronous handler for HTML event `mouseup`.
        let inline mouseup (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "onmouseup" callback
        /// Create an asynchronous handler for HTML event `click`.
        let inline click (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "onclick" callback
        /// Create an asynchronous handler for HTML event `dblclick`.
        let inline dblclick (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "ondblclick" callback
        /// Create an asynchronous handler for HTML event `wheel`.
        let inline wheel (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "onwheel" callback
        /// Create an asynchronous handler for HTML event `mousewheel`.
        let inline mousewheel (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "onmousewheel" callback
        /// Create an asynchronous handler for HTML event `contextmenu`.
        let inline contextmenu (callback: MouseEventArgs -> Task) =
            attr.task.callback<MouseEventArgs> "oncontextmenu" callback
        /// Create an asynchronous handler for HTML event `drag`.
        let inline drag (callback: DragEventArgs -> Task) =
            attr.task.callback<DragEventArgs> "ondrag" callback
        /// Create an asynchronous handler for HTML event `dragend`.
        let inline dragend (callback: DragEventArgs -> Task) =
            attr.task.callback<DragEventArgs> "ondragend" callback
        /// Create an asynchronous handler for HTML event `dragenter`.
        let inline dragenter (callback: DragEventArgs -> Task) =
            attr.task.callback<DragEventArgs> "ondragenter" callback
        /// Create an asynchronous handler for HTML event `dragleave`.
        let inline dragleave (callback: DragEventArgs -> Task) =
            attr.task.callback<DragEventArgs> "ondragleave" callback
        /// Create an asynchronous handler for HTML event `dragover`.
        let inline dragover (callback: DragEventArgs -> Task) =
            attr.task.callback<DragEventArgs> "ondragover" callback
        /// Create an asynchronous handler for HTML event `dragstart`.
        let inline dragstart (callback: DragEventArgs -> Task) =
            attr.task.callback<DragEventArgs> "ondragstart" callback
        /// Create an asynchronous handler for HTML event `drop`.
        let inline drop (callback: DragEventArgs -> Task) =
            attr.task.callback<DragEventArgs> "ondrop" callback
        /// Create an asynchronous handler for HTML event `keydown`.
        let inline keydown (callback: KeyboardEventArgs -> Task) =
            attr.task.callback<KeyboardEventArgs> "onkeydown" callback
        /// Create an asynchronous handler for HTML event `keyup`.
        let inline keyup (callback: KeyboardEventArgs -> Task) =
            attr.task.callback<KeyboardEventArgs> "onkeyup" callback
        /// Create an asynchronous handler for HTML event `keypress`.
        let inline keypress (callback: KeyboardEventArgs -> Task) =
            attr.task.callback<KeyboardEventArgs> "onkeypress" callback
        /// Create an asynchronous handler for HTML event `change`.
        let inline change (callback: ChangeEventArgs -> Task) =
            attr.task.callback<ChangeEventArgs> "onchange" callback
        /// Create an asynchronous handler for HTML event `input`.
        let inline input (callback: ChangeEventArgs -> Task) =
            attr.task.callback<ChangeEventArgs> "oninput" callback
        /// Create an asynchronous handler for HTML event `invalid`.
        let inline invalid (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "oninvalid" callback
        /// Create an asynchronous handler for HTML event `reset`.
        let inline reset (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onreset" callback
        /// Create an asynchronous handler for HTML event `select`.
        let inline select (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onselect" callback
        /// Create an asynchronous handler for HTML event `selectstart`.
        let inline selectstart (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onselectstart" callback
        /// Create an asynchronous handler for HTML event `selectionchange`.
        let inline selectionchange (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onselectionchange" callback
        /// Create an asynchronous handler for HTML event `submit`.
        let inline submit (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onsubmit" callback
        /// Create an asynchronous handler for HTML event `beforecopy`.
        let inline beforecopy (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onbeforecopy" callback
        /// Create an asynchronous handler for HTML event `beforecut`.
        let inline beforecut (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onbeforecut" callback
        /// Create an asynchronous handler for HTML event `beforepaste`.
        let inline beforepaste (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onbeforepaste" callback
        /// Create an asynchronous handler for HTML event `copy`.
        let inline copy (callback: ClipboardEventArgs -> Task) =
            attr.task.callback<ClipboardEventArgs> "oncopy" callback
        /// Create an asynchronous handler for HTML event `cut`.
        let inline cut (callback: ClipboardEventArgs -> Task) =
            attr.task.callback<ClipboardEventArgs> "oncut" callback
        /// Create an asynchronous handler for HTML event `paste`.
        let inline paste (callback: ClipboardEventArgs -> Task) =
            attr.task.callback<ClipboardEventArgs> "onpaste" callback
        /// Create an asynchronous handler for HTML event `touchcancel`.
        let inline touchcancel (callback: TouchEventArgs -> Task) =
            attr.task.callback<TouchEventArgs> "ontouchcancel" callback
        /// Create an asynchronous handler for HTML event `touchend`.
        let inline touchend (callback: TouchEventArgs -> Task) =
            attr.task.callback<TouchEventArgs> "ontouchend" callback
        /// Create an asynchronous handler for HTML event `touchmove`.
        let inline touchmove (callback: TouchEventArgs -> Task) =
            attr.task.callback<TouchEventArgs> "ontouchmove" callback
        /// Create an asynchronous handler for HTML event `touchstart`.
        let inline touchstart (callback: TouchEventArgs -> Task) =
            attr.task.callback<TouchEventArgs> "ontouchstart" callback
        /// Create an asynchronous handler for HTML event `touchenter`.
        let inline touchenter (callback: TouchEventArgs -> Task) =
            attr.task.callback<TouchEventArgs> "ontouchenter" callback
        /// Create an asynchronous handler for HTML event `touchleave`.
        let inline touchleave (callback: TouchEventArgs -> Task) =
            attr.task.callback<TouchEventArgs> "ontouchleave" callback
        /// Create an asynchronous handler for HTML event `pointercapture`.
        let inline pointercapture (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointercapture" callback
        /// Create an asynchronous handler for HTML event `lostpointercapture`.
        let inline lostpointercapture (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onlostpointercapture" callback
        /// Create an asynchronous handler for HTML event `pointercancel`.
        let inline pointercancel (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointercancel" callback
        /// Create an asynchronous handler for HTML event `pointerdown`.
        let inline pointerdown (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointerdown" callback
        /// Create an asynchronous handler for HTML event `pointerenter`.
        let inline pointerenter (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointerenter" callback
        /// Create an asynchronous handler for HTML event `pointerleave`.
        let inline pointerleave (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointerleave" callback
        /// Create an asynchronous handler for HTML event `pointermove`.
        let inline pointermove (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointermove" callback
        /// Create an asynchronous handler for HTML event `pointerout`.
        let inline pointerout (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointerout" callback
        /// Create an asynchronous handler for HTML event `pointerover`.
        let inline pointerover (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointerover" callback
        /// Create an asynchronous handler for HTML event `pointerup`.
        let inline pointerup (callback: PointerEventArgs -> Task) =
            attr.task.callback<PointerEventArgs> "onpointerup" callback
        /// Create an asynchronous handler for HTML event `canplay`.
        let inline canplay (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "oncanplay" callback
        /// Create an asynchronous handler for HTML event `canplaythrough`.
        let inline canplaythrough (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "oncanplaythrough" callback
        /// Create an asynchronous handler for HTML event `cuechange`.
        let inline cuechange (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "oncuechange" callback
        /// Create an asynchronous handler for HTML event `durationchange`.
        let inline durationchange (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "ondurationchange" callback
        /// Create an asynchronous handler for HTML event `emptied`.
        let inline emptied (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onemptied" callback
        /// Create an asynchronous handler for HTML event `pause`.
        let inline pause (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onpause" callback
        /// Create an asynchronous handler for HTML event `play`.
        let inline play (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onplay" callback
        /// Create an asynchronous handler for HTML event `playing`.
        let inline playing (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onplaying" callback
        /// Create an asynchronous handler for HTML event `ratechange`.
        let inline ratechange (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onratechange" callback
        /// Create an asynchronous handler for HTML event `seeked`.
        let inline seeked (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onseeked" callback
        /// Create an asynchronous handler for HTML event `seeking`.
        let inline seeking (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onseeking" callback
        /// Create an asynchronous handler for HTML event `stalled`.
        let inline stalled (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onstalled" callback
        /// Create an asynchronous handler for HTML event `stop`.
        let inline stop (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onstop" callback
        /// Create an asynchronous handler for HTML event `suspend`.
        let inline suspend (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onsuspend" callback
        /// Create an asynchronous handler for HTML event `timeupdate`.
        let inline timeupdate (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "ontimeupdate" callback
        /// Create an asynchronous handler for HTML event `volumechange`.
        let inline volumechange (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onvolumechange" callback
        /// Create an asynchronous handler for HTML event `waiting`.
        let inline waiting (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onwaiting" callback
        /// Create an asynchronous handler for HTML event `loadstart`.
        let inline loadstart (callback: ProgressEventArgs -> Task) =
            attr.task.callback<ProgressEventArgs> "onloadstart" callback
        /// Create an asynchronous handler for HTML event `timeout`.
        let inline timeout (callback: ProgressEventArgs -> Task) =
            attr.task.callback<ProgressEventArgs> "ontimeout" callback
        /// Create an asynchronous handler for HTML event `abort`.
        let inline abort (callback: ProgressEventArgs -> Task) =
            attr.task.callback<ProgressEventArgs> "onabort" callback
        /// Create an asynchronous handler for HTML event `load`.
        let inline load (callback: ProgressEventArgs -> Task) =
            attr.task.callback<ProgressEventArgs> "onload" callback
        /// Create an asynchronous handler for HTML event `loadend`.
        let inline loadend (callback: ProgressEventArgs -> Task) =
            attr.task.callback<ProgressEventArgs> "onloadend" callback
        /// Create an asynchronous handler for HTML event `progress`.
        let inline progress (callback: ProgressEventArgs -> Task) =
            attr.task.callback<ProgressEventArgs> "onprogress" callback
        /// Create an asynchronous handler for HTML event `error`.
        let inline error (callback: ProgressEventArgs -> Task) =
            attr.task.callback<ProgressEventArgs> "onerror" callback
        /// Create an asynchronous handler for HTML event `activate`.
        let inline activate (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onactivate" callback
        /// Create an asynchronous handler for HTML event `beforeactivate`.
        let inline beforeactivate (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onbeforeactivate" callback
        /// Create an asynchronous handler for HTML event `beforedeactivate`.
        let inline beforedeactivate (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onbeforedeactivate" callback
        /// Create an asynchronous handler for HTML event `deactivate`.
        let inline deactivate (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "ondeactivate" callback
        /// Create an asynchronous handler for HTML event `ended`.
        let inline ended (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onended" callback
        /// Create an asynchronous handler for HTML event `fullscreenchange`.
        let inline fullscreenchange (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onfullscreenchange" callback
        /// Create an asynchronous handler for HTML event `fullscreenerror`.
        let inline fullscreenerror (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onfullscreenerror" callback
        /// Create an asynchronous handler for HTML event `loadeddata`.
        let inline loadeddata (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onloadeddata" callback
        /// Create an asynchronous handler for HTML event `loadedmetadata`.
        let inline loadedmetadata (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onloadedmetadata" callback
        /// Create an asynchronous handler for HTML event `pointerlockchange`.
        let inline pointerlockchange (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onpointerlockchange" callback
        /// Create an asynchronous handler for HTML event `pointerlockerror`.
        let inline pointerlockerror (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onpointerlockerror" callback
        /// Create an asynchronous handler for HTML event `readystatechange`.
        let inline readystatechange (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onreadystatechange" callback
        /// Create an asynchronous handler for HTML event `scroll`.
        let inline scroll (callback: EventArgs -> Task) =
            attr.task.callback<EventArgs> "onscroll" callback
// END TASKEVENTS
