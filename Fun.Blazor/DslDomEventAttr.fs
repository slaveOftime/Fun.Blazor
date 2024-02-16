namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators

[<AutoOpen>]
module DslDomEventAttr =

    type on =

        static member inline focus([<InlineIfLambda>] callback: FocusEventArgs -> unit) = html.callback ("onfocus", callback)
        static member inline focus([<InlineIfLambda>] callback: FocusEventArgs -> Task) = html.callbackTask ("onfocus", callback)
        static member inline focus([<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) = html.callbackTask ("onfocus", callback)

        static member inline blur([<InlineIfLambda>] callback: FocusEventArgs -> unit) = html.callback ("onblur", callback)
        static member inline blur([<InlineIfLambda>] callback: FocusEventArgs -> Task) = html.callbackTask ("onblur", callback)
        static member inline blur([<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) = html.callbackTask ("onblur", callback)

        static member inline focusin([<InlineIfLambda>] callback: FocusEventArgs -> unit) = html.callback ("onfocusin", callback)
        static member inline focusin([<InlineIfLambda>] callback: FocusEventArgs -> Task) = html.callbackTask ("onfocusin", callback)
        static member inline focusin([<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) = html.callbackTask ("onfocusin", callback)

        static member inline focusout([<InlineIfLambda>] callback: FocusEventArgs -> unit) = html.callback ("onfocusout", callback)
        static member inline focusout([<InlineIfLambda>] callback: FocusEventArgs -> Task) = html.callbackTask ("onfocusout", callback)
        static member inline focusout([<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) = html.callbackTask ("onfocusout", callback)

        static member inline mouseover([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("onmouseover", callback)
        static member inline mouseover([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("onmouseover", callback)
        static member inline mouseover([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("onmouseover", callback)

        static member inline mouseout([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("onmouseout", callback)
        static member inline mouseout([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("onmouseout", callback)
        static member inline mouseout([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("onmouseout", callback)

        static member inline mousemove([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("onmousemove", callback)
        static member inline mousemove([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("onmousemove", callback)
        static member inline mousemove([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("onmousemove", callback)

        static member inline mousedown([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("onmousedown", callback)
        static member inline mousedown([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("onmousedown", callback)
        static member inline mousedown([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("onmousedown", callback)

        static member inline mouseup([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("onmouseup", callback)
        static member inline mouseup([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("onmouseup", callback)
        static member inline mouseup([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("onmouseup", callback)

        static member inline click([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("onclick", callback)
        static member inline click([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("onclick", callback)
        static member inline click([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("onclick", callback)

        static member inline dblclick([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("ondblclick", callback)
        static member inline dblclick([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("ondblclick", callback)
        static member inline dblclick([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("ondblclick", callback)

        static member inline wheel([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("onwheel", callback)
        static member inline wheel([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("onwheel", callback)
        static member inline wheel([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("onwheel", callback)

        static member inline mousewheel([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("onmousewheel", callback)
        static member inline mousewheel([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("onmousewheel", callback)
        static member inline mousewheel([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("onmousewheel", callback)

        static member inline contextmenu([<InlineIfLambda>] callback: MouseEventArgs -> unit) = html.callback ("oncontextmenu", callback)
        static member inline contextmenu([<InlineIfLambda>] callback: MouseEventArgs -> Task) = html.callbackTask ("oncontextmenu", callback)
        static member inline contextmenu([<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) = html.callbackTask ("oncontextmenu", callback)

        static member inline drag([<InlineIfLambda>] callback: DragEventArgs -> unit) = html.callback ("ondrag", callback)
        static member inline drag([<InlineIfLambda>] callback: DragEventArgs -> Task) = html.callbackTask ("ondrag", callback)
        static member inline drag([<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) = html.callbackTask ("ondrag", callback)

        static member inline dragend([<InlineIfLambda>] callback: DragEventArgs -> unit) = html.callback ("ondragend", callback)
        static member inline dragend([<InlineIfLambda>] callback: DragEventArgs -> Task) = html.callbackTask ("ondragend", callback)
        static member inline dragend([<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) = html.callbackTask ("ondragend", callback)

        static member inline dragenter([<InlineIfLambda>] callback: DragEventArgs -> unit) = html.callback ("ondragenter", callback)
        static member inline dragenter([<InlineIfLambda>] callback: DragEventArgs -> Task) = html.callbackTask ("ondragenter", callback)
        static member inline dragenter([<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) = html.callbackTask ("ondragenter", callback)

        static member inline dragleave([<InlineIfLambda>] callback: DragEventArgs -> unit) = html.callback ("ondragleave", callback)
        static member inline dragleave([<InlineIfLambda>] callback: DragEventArgs -> Task) = html.callbackTask ("ondragleave", callback)
        static member inline dragleave([<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) = html.callbackTask ("ondragleave", callback)

        static member inline dragover([<InlineIfLambda>] callback: DragEventArgs -> unit) = html.callback ("ondragover", callback)
        static member inline dragover([<InlineIfLambda>] callback: DragEventArgs -> Task) = html.callbackTask ("ondragover", callback)
        static member inline dragover([<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) = html.callbackTask ("ondragover", callback)

        static member inline dragstart([<InlineIfLambda>] callback: DragEventArgs -> unit) = html.callback ("ondragstart", callback)
        static member inline dragstart([<InlineIfLambda>] callback: DragEventArgs -> Task) = html.callbackTask ("ondragstart", callback)
        static member inline dragstart([<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) = html.callbackTask ("ondragstart", callback)

        static member inline drop([<InlineIfLambda>] callback: DragEventArgs -> unit) = html.callback ("ondrop", callback)
        static member inline drop([<InlineIfLambda>] callback: DragEventArgs -> Task) = html.callbackTask ("ondrop", callback)
        static member inline drop([<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) = html.callbackTask ("ondrop", callback)

        static member inline keydown([<InlineIfLambda>] callback: KeyboardEventArgs -> unit) = html.callback ("onkeydown", callback)
        static member inline keydown([<InlineIfLambda>] callback: KeyboardEventArgs -> Task) = html.callbackTask ("onkeydown", callback)
        static member inline keydown([<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) = html.callbackTask ("onkeydown", callback)

        static member inline keyup([<InlineIfLambda>] callback: KeyboardEventArgs -> unit) = html.callback ("onkeyup", callback)
        static member inline keyup([<InlineIfLambda>] callback: KeyboardEventArgs -> Task) = html.callbackTask ("onkeyup", callback)
        static member inline keyup([<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) = html.callbackTask ("onkeyup", callback)

        static member inline keypress([<InlineIfLambda>] callback: KeyboardEventArgs -> unit) = html.callback ("onkeypress", callback)
        static member inline keypress([<InlineIfLambda>] callback: KeyboardEventArgs -> Task) = html.callbackTask ("onkeypress", callback)
        static member inline keypress([<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) = html.callbackTask ("onkeypress", callback)

        static member inline change([<InlineIfLambda>] callback: ChangeEventArgs -> unit) = html.callback ("onchange", callback)
        static member inline change([<InlineIfLambda>] callback: ChangeEventArgs -> Task) = html.callbackTask ("onchange", callback)
        static member inline change([<InlineIfLambda>] callback: ChangeEventArgs -> Task<unit>) = html.callbackTask ("onchange", callback)

        static member inline input([<InlineIfLambda>] callback: ChangeEventArgs -> unit) = html.callback ("oninput", callback)
        static member inline input([<InlineIfLambda>] callback: ChangeEventArgs -> Task) = html.callbackTask ("oninput", callback)
        static member inline input([<InlineIfLambda>] callback: ChangeEventArgs -> Task<unit>) = html.callbackTask ("oninput", callback)

        static member inline invalid([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("oninvalid", callback)
        static member inline invalid([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("oninvalid", callback)
        static member inline invalid([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("oninvalid", callback)

        static member inline reset([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onreset", callback)
        static member inline reset([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onreset", callback)
        static member inline reset([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onreset", callback)

        static member inline select([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onselect", callback)
        static member inline select([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onselect", callback)
        static member inline select([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onselect", callback)

        static member inline selectstart([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onselectstart", callback)
        static member inline selectstart([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onselectstart", callback)
        static member inline selectstart([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onselectstart", callback)

        static member inline selectionchange([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onselectionchange", callback)
        static member inline selectionchange([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onselectionchange", callback)
        static member inline selectionchange([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onselectionchange", callback)

        static member inline submit([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onsubmit", callback)
        static member inline submit([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onsubmit", callback)
        static member inline submit([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onsubmit", callback)

        static member inline beforecopy([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onbeforecopy", callback)
        static member inline beforecopy([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onbeforecopy", callback)
        static member inline beforecopy([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onbeforecopy", callback)

        static member inline beforecut([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onbeforecut", callback)
        static member inline beforecut([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onbeforecut", callback)
        static member inline beforecut([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onbeforecut", callback)

        static member inline beforepaste([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onbeforepaste", callback)
        static member inline beforepaste([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onbeforepaste", callback)
        static member inline beforepaste([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onbeforepaste", callback)

        static member inline copy([<InlineIfLambda>] callback: ClipboardEventArgs -> unit) = html.callback ("oncopy", callback)
        static member inline copy([<InlineIfLambda>] callback: ClipboardEventArgs -> Task) = html.callbackTask ("oncopy", callback)
        static member inline copy([<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) = html.callbackTask ("oncopy", callback)

        static member inline cut([<InlineIfLambda>] callback: ClipboardEventArgs -> unit) = html.callback ("oncut", callback)
        static member inline cut([<InlineIfLambda>] callback: ClipboardEventArgs -> Task) = html.callbackTask ("oncut", callback)
        static member inline cut([<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) = html.callbackTask ("oncut", callback)

        static member inline paste([<InlineIfLambda>] callback: ClipboardEventArgs -> unit) = html.callback ("onpaste", callback)
        static member inline paste([<InlineIfLambda>] callback: ClipboardEventArgs -> Task) = html.callbackTask ("onpaste", callback)
        static member inline paste([<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) = html.callbackTask ("onpaste", callback)

        static member inline touchcancel([<InlineIfLambda>] callback: TouchEventArgs -> unit) = html.callback ("ontouchcancel", callback)
        static member inline touchcancel([<InlineIfLambda>] callback: TouchEventArgs -> Task) = html.callbackTask ("ontouchcancel", callback)
        static member inline touchcancel([<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) = html.callbackTask ("ontouchcancel", callback)

        static member inline touchend([<InlineIfLambda>] callback: TouchEventArgs -> unit) = html.callback ("ontouchend", callback)
        static member inline touchend([<InlineIfLambda>] callback: TouchEventArgs -> Task) = html.callbackTask ("ontouchend", callback)
        static member inline touchend([<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) = html.callbackTask ("ontouchend", callback)

        static member inline touchmove([<InlineIfLambda>] callback: TouchEventArgs -> unit) = html.callback ("ontouchmove", callback)
        static member inline touchmove([<InlineIfLambda>] callback: TouchEventArgs -> Task) = html.callbackTask ("ontouchmove", callback)
        static member inline touchmove([<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) = html.callbackTask ("ontouchmove", callback)

        static member inline touchstart([<InlineIfLambda>] callback: TouchEventArgs -> unit) = html.callback ("ontouchstart", callback)
        static member inline touchstart([<InlineIfLambda>] callback: TouchEventArgs -> Task) = html.callbackTask ("ontouchstart", callback)
        static member inline touchstart([<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) = html.callbackTask ("ontouchstart", callback)

        static member inline touchenter([<InlineIfLambda>] callback: TouchEventArgs -> unit) = html.callback ("ontouchenter", callback)
        static member inline touchenter([<InlineIfLambda>] callback: TouchEventArgs -> Task) = html.callbackTask ("ontouchenter", callback)
        static member inline touchenter([<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) = html.callbackTask ("ontouchenter", callback)

        static member inline touchleave([<InlineIfLambda>] callback: TouchEventArgs -> unit) = html.callback ("ontouchleave", callback)
        static member inline touchleave([<InlineIfLambda>] callback: TouchEventArgs -> Task) = html.callbackTask ("ontouchleave", callback)
        static member inline touchleave([<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) = html.callbackTask ("ontouchleave", callback)

        static member inline pointercapture([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointercapture", callback)
        static member inline pointercapture([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointercapture", callback)
        static member inline pointercapture
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            html.callbackTask ("onpointercapture", callback)

        static member inline lostpointercapture
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> unit
            )
            =
            html.callback ("onlostpointercapture", callback)
        static member inline lostpointercapture
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task
            )
            =
            html.callbackTask ("onlostpointercapture", callback)
        static member inline lostpointercapture
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            html.callbackTask ("onlostpointercapture", callback)

        static member inline pointercancel([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointercancel", callback)
        static member inline pointercancel([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointercancel", callback)
        static member inline pointercancel
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            html.callbackTask ("onpointercancel", callback)

        static member inline pointerdown([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointerdown", callback)
        static member inline pointerdown([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointerdown", callback)
        static member inline pointerdown([<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) = html.callbackTask ("onpointerdown", callback)

        static member inline pointerenter([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointerenter", callback)
        static member inline pointerenter([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointerenter", callback)
        static member inline pointerenter
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            html.callbackTask ("onpointerenter", callback)

        static member inline pointerleave([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointerleave", callback)
        static member inline pointerleave([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointerleave", callback)
        static member inline pointerleave
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            html.callbackTask ("onpointerleave", callback)

        static member inline pointermove([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointermove", callback)
        static member inline pointermove([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointermove", callback)
        static member inline pointermove([<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) = html.callbackTask ("onpointermove", callback)

        static member inline pointerout([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointerout", callback)
        static member inline pointerout([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointerout", callback)
        static member inline pointerout([<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) = html.callbackTask ("onpointerout", callback)

        static member inline pointerover([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointerover", callback)
        static member inline pointerover([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointerover", callback)
        static member inline pointerover([<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) = html.callbackTask ("onpointerover", callback)

        static member inline pointerup([<InlineIfLambda>] callback: PointerEventArgs -> unit) = html.callback ("onpointerup", callback)
        static member inline pointerup([<InlineIfLambda>] callback: PointerEventArgs -> Task) = html.callbackTask ("onpointerup", callback)
        static member inline pointerup([<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) = html.callbackTask ("onpointerup", callback)

        static member inline canplay([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("oncanplay", callback)
        static member inline canplay([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("oncanplay", callback)
        static member inline canplay([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("oncanplay", callback)

        static member inline canplaythrough([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("oncanplaythrough", callback)
        static member inline canplaythrough([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("oncanplaythrough", callback)
        static member inline canplaythrough([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("oncanplaythrough", callback)

        static member inline cuechange([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("oncuechange", callback)
        static member inline cuechange([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("oncuechange", callback)
        static member inline cuechange([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("oncuechange", callback)

        static member inline durationchange([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("ondurationchange", callback)
        static member inline durationchange([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("ondurationchange", callback)
        static member inline durationchange([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("ondurationchange", callback)

        static member inline emptied([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onemptied", callback)
        static member inline emptied([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onemptied", callback)
        static member inline emptied([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onemptied", callback)

        static member inline pause([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onpause", callback)
        static member inline pause([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onpause", callback)
        static member inline pause([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onpause", callback)

        static member inline play([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onplay", callback)
        static member inline play([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onplay", callback)
        static member inline play([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onplay", callback)

        static member inline playing([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onplaying", callback)
        static member inline playing([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onplaying", callback)
        static member inline playing([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onplaying", callback)

        static member inline ratechange([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onratechange", callback)
        static member inline ratechange([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onratechange", callback)
        static member inline ratechange([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onratechange", callback)

        static member inline seeked([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onseeked", callback)
        static member inline seeked([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onseeked", callback)
        static member inline seeked([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onseeked", callback)

        static member inline seeking([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onseeking", callback)
        static member inline seeking([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onseeking", callback)
        static member inline seeking([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onseeking", callback)

        static member inline stalled([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onstalled", callback)
        static member inline stalled([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onstalled", callback)
        static member inline stalled([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onstalled", callback)

        static member inline stop([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onstop", callback)
        static member inline stop([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onstop", callback)
        static member inline stop([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onstop", callback)

        static member inline suspend([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onsuspend", callback)
        static member inline suspend([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onsuspend", callback)
        static member inline suspend([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onsuspend", callback)

        static member inline timeupdate([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("ontimeupdate", callback)
        static member inline timeupdate([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("ontimeupdate", callback)
        static member inline timeupdate([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("ontimeupdate", callback)

        static member inline volumechange([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onvolumechange", callback)
        static member inline volumechange([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onvolumechange", callback)
        static member inline volumechange([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onvolumechange", callback)

        static member inline waiting([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onwaiting", callback)
        static member inline waiting([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onwaiting", callback)
        static member inline waiting([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onwaiting", callback)

        static member inline loadstart([<InlineIfLambda>] callback: ProgressEventArgs -> unit) = html.callback ("onloadstart", callback)
        static member inline loadstart([<InlineIfLambda>] callback: ProgressEventArgs -> Task) = html.callbackTask ("onloadstart", callback)
        static member inline loadstart([<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) = html.callbackTask ("onloadstart", callback)

        static member inline timeout([<InlineIfLambda>] callback: ProgressEventArgs -> unit) = html.callback ("ontimeout", callback)
        static member inline timeout([<InlineIfLambda>] callback: ProgressEventArgs -> Task) = html.callbackTask ("ontimeout", callback)
        static member inline timeout([<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) = html.callbackTask ("ontimeout", callback)

        static member inline abort([<InlineIfLambda>] callback: ProgressEventArgs -> unit) = html.callback ("onabort", callback)
        static member inline abort([<InlineIfLambda>] callback: ProgressEventArgs -> Task) = html.callbackTask ("onabort", callback)
        static member inline abort([<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) = html.callbackTask ("onabort", callback)

        static member inline load([<InlineIfLambda>] callback: ProgressEventArgs -> unit) = html.callback ("onload", callback)
        static member inline load([<InlineIfLambda>] callback: ProgressEventArgs -> Task) = html.callbackTask ("onload", callback)
        static member inline load([<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) = html.callbackTask ("onload", callback)

        static member inline loadend([<InlineIfLambda>] callback: ProgressEventArgs -> unit) = html.callback ("onloadend", callback)
        static member inline loadend([<InlineIfLambda>] callback: ProgressEventArgs -> Task) = html.callbackTask ("onloadend", callback)
        static member inline loadend([<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) = html.callbackTask ("onloadend", callback)

        static member inline progress([<InlineIfLambda>] callback: ProgressEventArgs -> unit) = html.callback ("onprogress", callback)
        static member inline progress([<InlineIfLambda>] callback: ProgressEventArgs -> Task) = html.callbackTask ("onprogress", callback)
        static member inline progress([<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) = html.callbackTask ("onprogress", callback)

        static member inline error([<InlineIfLambda>] callback: ErrorEventArgs -> unit) = html.callback ("onerror", callback)
        static member inline error([<InlineIfLambda>] callback: ErrorEventArgs -> Task) = html.callbackTask ("onerror", callback)
        static member inline error([<InlineIfLambda>] callback: ErrorEventArgs -> Task<unit>) = html.callbackTask ("onerror", callback)

        static member inline activate([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onactivate", callback)
        static member inline activate([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onactivate", callback)
        static member inline activate([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onactivate", callback)

        static member inline beforeactivate([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onbeforeactivate", callback)
        static member inline beforeactivate([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onbeforeactivate", callback)
        static member inline beforeactivate([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onbeforeactivate", callback)

        static member inline beforedeactivate([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onbeforedeactivate", callback)
        static member inline beforedeactivate([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onbeforedeactivate", callback)
        static member inline beforedeactivate([<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            html.callbackTask ("onbeforedeactivate", callback)

        static member inline deactivate([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("ondeactivate", callback)
        static member inline deactivate([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("ondeactivate", callback)
        static member inline deactivate([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("ondeactivate", callback)

        static member inline ended([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onended", callback)
        static member inline ended([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onended", callback)
        static member inline ended([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onended", callback)

        static member inline fullscreenchange([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onfullscreenchange", callback)
        static member inline fullscreenchange([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onfullscreenchange", callback)
        static member inline fullscreenchange([<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            html.callbackTask ("onfullscreenchange", callback)

        static member inline fullscreenerror([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onfullscreenerror", callback)
        static member inline fullscreenerror([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onfullscreenerror", callback)
        static member inline fullscreenerror([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onfullscreenerror", callback)

        static member inline loadeddata([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onloadeddata", callback)
        static member inline loadeddata([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onloadeddata", callback)
        static member inline loadeddata([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onloadeddata", callback)

        static member inline loadedmetadata([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onloadedmetadata", callback)
        static member inline loadedmetadata([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onloadedmetadata", callback)
        static member inline loadedmetadata([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onloadedmetadata", callback)

        static member inline pointerlockchange([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onpointerlockchange", callback)
        static member inline pointerlockchange([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onpointerlockchange", callback)
        static member inline pointerlockchange([<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            html.callbackTask ("onpointerlockchange", callback)

        static member inline pointerlockerror([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onpointerlockerror", callback)
        static member inline pointerlockerror([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onpointerlockerror", callback)
        static member inline pointerlockerror([<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            html.callbackTask ("onpointerlockerror", callback)

        static member inline readystatechange([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onreadystatechange", callback)
        static member inline readystatechange([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onreadystatechange", callback)
        static member inline readystatechange([<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            html.callbackTask ("onreadystatechange", callback)

        static member inline scroll([<InlineIfLambda>] callback: EventArgs -> unit) = html.callback ("onscroll", callback)
        static member inline scroll([<InlineIfLambda>] callback: EventArgs -> Task) = html.callbackTask ("onscroll", callback)
        static member inline scroll([<InlineIfLambda>] callback: EventArgs -> Task<unit>) = html.callbackTask ("onscroll", callback)


        static member inline abort(js: string) = ("onabort" => js)

        static member inline ended(js: string) = ("onended" => js)

        static member inline addtrack(js: string) = ("onaddtrack" => js)

        static member inline change(js: string) = ("onchange" => js)

        static member inline removetrack(js: string) = ("onremovetrack" => js)

        static member inline messageerror(js: string) = ("onmessageerror" => js)

        static member inline message(js: string) = ("onmessage" => js)

        static member inline animationcancel(js: string) = ("onanimationcancel" => js)

        static member inline animationend(js: string) = ("onanimationend" => js)

        static member inline animationiteration(js: string) = ("onanimationiteration" => js)

        static member inline animationstart(js: string) = ("onanimationstart" => js)

        static member inline copy(js: string) = ("oncopy" => js)

        static member inline cut(js: string) = ("oncut" => js)

        static member inline DOMContentLoaded(js: string) = ("onDOMContentLoaded" => js)

        static member inline dragend(js: string) = ("ondragend" => js)

        static member inline dragenter(js: string) = ("ondragenter" => js)

        static member inline dragleave(js: string) = ("ondragleave" => js)

        static member inline dragover(js: string) = ("ondragover" => js)

        static member inline dragstart(js: string) = ("ondragstart" => js)

        static member inline drag(js: string) = ("ondrag" => js)

        static member inline drop(js: string) = ("ondrop" => js)

        static member inline fullscreenchange(js: string) = ("onfullscreenchange" => js)

        static member inline fullscreenerror(js: string) = ("onfullscreenerror" => js)

        static member inline gotpointercapture(js: string) = ("ongotpointercapture" => js)

        static member inline keydown(js: string) = ("onkeydown" => js)

        static member inline keypress(js: string) = ("onkeypress" => js)

        static member inline keyup(js: string) = ("onkeyup" => js)


        static member inline lostpointercapture(js: string) = ("onlostpointercapture" => js)

        static member inline paste(js: string) = ("onpaste" => js)

        static member inline pointercancel(js: string) = ("onpointercancel" => js)

        static member inline pointerdown(js: string) = ("onpointerdown" => js)

        static member inline pointerenter(js: string) = ("onpointerenter" => js)

        static member inline pointerleave(js: string) = ("onpointerleave" => js)

        static member inline pointerlockchange(js: string) = ("onpointerlockchange" => js)

        static member inline pointerlockerror(js: string) = ("onpointerlockerror" => js)

        static member inline pointermove(js: string) = ("onpointermove" => js)

        static member inline pointerout(js: string) = ("onpointerout" => js)

        static member inline pointerover(js: string) = ("onpointerover" => js)

        static member inline pointerup(js: string) = ("onpointerup" => js)

        static member inline readystatechange(js: string) = ("onreadystatechange" => js)

        static member inline scroll(js: string) = ("onscroll" => js)

        static member inline selectionchange(js: string) = ("onselectionchange" => js)

        static member inline touchcancel(js: string) = ("ontouchcancel" => js)

        static member inline touchend(js: string) = ("ontouchend" => js)

        static member inline touchmove(js: string) = ("ontouchmove" => js)

        static member inline touchstart(js: string) = ("ontouchstart" => js)

        static member inline transitioncancel(js: string) = ("ontransitioncancel" => js)

        static member inline transitionend(js: string) = ("ontransitionend" => js)

        static member inline transitionrun(js: string) = ("ontransitionrun" => js)

        static member inline transitionstart(js: string) = ("ontransitionstart" => js)

        static member inline visibilitychange(js: string) = ("onvisibilitychange" => js)

        static member inline wheel(js: string) = ("onwheel" => js)

        static member inline afterscriptexecute(js: string) = ("onafterscriptexecute" => js)

        static member inline auxclick(js: string) = ("onauxclick" => js)

        static member inline beforescriptexecute(js: string) = ("onbeforescriptexecute" => js)

        static member inline blur(js: string) = ("onblur" => js)

        static member inline click(js: string) = ("onclick" => js)

        static member inline compositionend(js: string) = ("oncompositionend" => js)

        static member inline compositionstart(js: string) = ("oncompositionstart" => js)

        static member inline compositionupdate(js: string) = ("oncompositionupdate" => js)

        static member inline contextmenu(js: string) = ("oncontextmenu" => js)

        static member inline dblclick(js: string) = ("ondblclick" => js)

        static member inline DOMActivate(js: string) = ("onDOMActivate" => js)

        static member inline DOMMouseScroll(js: string) = ("onDOMMouseScroll" => js)

        static member inline error(js: string) = ("onerror" => js)

        static member inline focusin(js: string) = ("onfocusin" => js)

        static member inline focusout(js: string) = ("onfocusout" => js)


        static member inline focus(js: string) = ("onfocus" => js)

        static member inline gesturechange(js: string) = ("ongesturechange" => js)

        static member inline gestureend(js: string) = ("ongestureend" => js)

        static member inline gesturestart(js: string) = ("ongesturestart" => js)

        static member inline mousedown(js: string) = ("onmousedown" => js)

        static member inline mouseenter(js: string) = ("onmouseenter" => js)

        static member inline mouseleave(js: string) = ("onmouseleave" => js)

        static member inline mousemove(js: string) = ("onmousemove" => js)

        static member inline mouseout(js: string) = ("onmouseout" => js)

        static member inline mouseover(js: string) = ("onmouseover" => js)

        static member inline mouseup(js: string) = ("onmouseup" => js)

        static member inline mousewheel(js: string) = ("onmousewheel" => js)

        static member inline select(js: string) = ("onselect" => js)

        static member inline webkitmouseforcechanged(js: string) = ("onwebkitmouseforcechanged" => js)

        static member inline webkitmouseforcedown(js: string) = ("onwebkitmouseforcedown" => js)

        static member inline webkitmouseforceup(js: string) = ("onwebkitmouseforceup" => js)

        static member inline webkitmouseforcewillbegin(js: string) = ("onwebkitmouseforcewillbegin" => js)

        static member inline cancel(js: string) = ("oncancel" => js)

        static member inline open'(js: string) = ("onopen" => js)

        static member inline loadend(js: string) = ("onloadend" => js)

        static member inline loadstart(js: string) = ("onloadstart" => js)

        static member inline load(js: string) = ("onload" => js)

        static member inline progress(js: string) = ("onprogress" => js)

        static member inline webglcontextcreationerror(js: string) = ("onwebglcontextcreationerror" => js)

        static member inline webglcontextlost(js: string) = ("onwebglcontextlost" => js)

        static member inline webglcontextrestored(js: string) = ("onwebglcontextrestored" => js)

        static member inline toggle(js: string) = ("ontoggle" => js)

        static member inline close(js: string) = ("onclose" => js)

        static member inline beforeinput(js: string) = ("onbeforeinput" => js)

        static member inline input(js: string) = ("oninput" => js)

        static member inline formdata(js: string) = ("onformdata" => js)

        static member inline reset(js: string) = ("onreset" => js)

        static member inline submit(js: string) = ("onsubmit" => js)

        static member inline invalid(js: string) = ("oninvalid" => js)

        static member inline search(js: string) = ("onsearch" => js)

        static member inline canplaythrough(js: string) = ("oncanplaythrough" => js)

        static member inline canplay(js: string) = ("oncanplay" => js)

        static member inline durationchange(js: string) = ("ondurationchange" => js)

        static member inline emptied(js: string) = ("onemptied" => js)

        static member inline loadeddata(js: string) = ("onloadeddata" => js)

        static member inline loadedmetadata(js: string) = ("onloadedmetadata" => js)

        static member inline pause(js: string) = ("onpause" => js)

        static member inline playing(js: string) = ("onplaying" => js)

        static member inline play(js: string) = ("onplay" => js)

        static member inline ratechange(js: string) = ("onratechange" => js)

        static member inline seeked(js: string) = ("onseeked" => js)

        static member inline seeking(js: string) = ("onseeking" => js)

        static member inline stalled(js: string) = ("onstalled" => js)

        static member inline suspend(js: string) = ("onsuspend" => js)

        static member inline timeupdate(js: string) = ("ontimeupdate" => js)

        static member inline volumechange(js: string) = ("onvolumechange" => js)

        static member inline waiting(js: string) = ("onwaiting" => js)

        static member inline slotchange(js: string) = ("onslotchange" => js)

        static member inline cuechange(js: string) = ("oncuechange" => js)

        static member inline enterpictureinpicture(js: string) = ("onenterpictureinpicture" => js)

        static member inline leavepictureinpicture(js: string) = ("onleavepictureinpicture" => js)

        static member inline versionchange(js: string) = ("onversionchange" => js)

        static member inline blocked(js: string) = ("onblocked" => js)

        static member inline upgradeneeded(js: string) = ("onupgradeneeded" => js)

        static member inline success(js: string) = ("onsuccess" => js)

        static member inline complete(js: string) = ("oncomplete" => js)

        static member inline devicechange(js: string) = ("ondevicechange" => js)

        static member inline mute(js: string) = ("onmute" => js)

        static member inline unmute(js: string) = ("onunmute" => js)

        static member inline merchantvalidation(js: string) = ("onmerchantvalidation" => js)

        static member inline paymentmethodchange(js: string) = ("onpaymentmethodchange" => js)

        static member inline shippingaddresschange(js: string) = ("onshippingaddresschange" => js)

        static member inline shippingoptionchange(js: string) = ("onshippingoptionchange" => js)

        static member inline payerdetailchange(js: string) = ("onpayerdetailchange" => js)

        static member inline resourcetimingbufferfull(js: string) = ("onresourcetimingbufferfull" => js)

        static member inline resize(js: string) = ("onresize" => js)

        static member inline bufferedamountlow(js: string) = ("onbufferedamountlow" => js)

        static member inline closing(js: string) = ("onclosing" => js)

        static member inline tonechange(js: string) = ("ontonechange" => js)

        static member inline gatheringstatechange(js: string) = ("ongatheringstatechange" => js)

        static member inline selectedcandidatepairchange(js: string) = ("onselectedcandidatepairchange" => js)

        static member inline statechange(js: string) = ("onstatechange" => js)

        static member inline addstream(js: string) = ("onaddstream" => js)

        static member inline connectionstatechange(js: string) = ("onconnectionstatechange" => js)

        static member inline datachannel(js: string) = ("ondatachannel" => js)

        static member inline icecandidateerror(js: string) = ("onicecandidateerror" => js)

        static member inline icecandidate(js: string) = ("onicecandidate" => js)

        static member inline iceconnectionstatechange(js: string) = ("oniceconnectionstatechange" => js)

        static member inline icegatheringstatechange(js: string) = ("onicegatheringstatechange" => js)

        static member inline negotiationneeded(js: string) = ("onnegotiationneeded" => js)

        static member inline removestream(js: string) = ("onremovestream" => js)

        static member inline signalingstatechange(js: string) = ("onsignalingstatechange" => js)

        static member inline track(js: string) = ("ontrack" => js)

        static member inline audioprocess(js: string) = ("onaudioprocess" => js)

        static member inline activate(js: string) = ("onactivate" => js)

        static member inline contentdelete(js: string) = ("oncontentdelete" => js)

        static member inline install(js: string) = ("oninstall" => js)

        static member inline notificationclick(js: string) = ("onnotificationclick" => js)

        static member inline pushsubscriptionchange(js: string) = ("onpushsubscriptionchange" => js)

        static member inline push(js: string) = ("onpush" => js)

        static member inline connect(js: string) = ("onconnect" => js)

        static member inline audioend(js: string) = ("onaudioend" => js)

        static member inline audiostart(js: string) = ("onaudiostart" => js)

        static member inline end'(js: string) = ("onend" => js)

        static member inline nomatch(js: string) = ("onnomatch" => js)

        static member inline result(js: string) = ("onresult" => js)

        static member inline soundend(js: string) = ("onsoundend" => js)

        static member inline soundstart(js: string) = ("onsoundstart" => js)

        static member inline speechend(js: string) = ("onspeechend" => js)

        static member inline speechstart(js: string) = ("onspeechstart" => js)

        static member inline start(js: string) = ("onstart" => js)

        static member inline voiceschanged(js: string) = ("onvoiceschanged" => js)

        static member inline boundary(js: string) = ("onboundary" => js)

        static member inline mark(js: string) = ("onmark" => js)

        static member inline resume(js: string) = ("onresume" => js)

        static member inline beginEvent(js: string) = ("onbeginEvent" => js)

        static member inline endEvent(js: string) = ("onendEvent" => js)

        static member inline repeatEvent(js: string) = ("onrepeatEvent" => js)

        static member inline unload(js: string) = ("onunload" => js)

        static member inline removeTrack(js: string) = ("onremoveTrack" => js)

        static member inline afterprint(js: string) = ("onafterprint" => js)

        static member inline appinstalled(js: string) = ("onappinstalled" => js)

        static member inline beforeprint(js: string) = ("onbeforeprint" => js)

        static member inline beforeunload(js: string) = ("onbeforeunload" => js)

        static member inline devicemotion(js: string) = ("ondevicemotion" => js)

        static member inline deviceorientation(js: string) = ("ondeviceorientation" => js)

        static member inline gamepadconnected(js: string) = ("ongamepadconnected" => js)

        static member inline gamepaddisconnected(js: string) = ("ongamepaddisconnected" => js)

        static member inline hashchange(js: string) = ("onhashchange" => js)

        static member inline languagechange(js: string) = ("onlanguagechange" => js)

        static member inline offline(js: string) = ("onoffline" => js)

        static member inline online(js: string) = ("ononline" => js)

        static member inline orientationchange(js: string) = ("onorientationchange" => js)

        static member inline pagehide(js: string) = ("onpagehide" => js)

        static member inline pageshow(js: string) = ("onpageshow" => js)

        static member inline popstate(js: string) = ("onpopstate" => js)

        static member inline rejectionhandled(js: string) = ("onrejectionhandled" => js)

        static member inline storage(js: string) = ("onstorage" => js)

        static member inline unhandledrejection(js: string) = ("onunhandledrejection" => js)

        static member inline vrdisplayactivate(js: string) = ("onvrdisplayactivate" => js)

        static member inline vrdisplayblur(js: string) = ("onvrdisplayblur" => js)

        static member inline vrdisplayconnect(js: string) = ("onvrdisplayconnect" => js)

        static member inline vrdisplaydeactivate(js: string) = ("onvrdisplaydeactivate" => js)

        static member inline vrdisplaydisconnect(js: string) = ("onvrdisplaydisconnect" => js)

        static member inline vrdisplayfocus(js: string) = ("onvrdisplayfocus" => js)

        static member inline vrdisplaypointerrestricted(js: string) = ("onvrdisplaypointerrestricted" => js)

        static member inline vrdisplaypointerunrestricted(js: string) = ("onvrdisplaypointerunrestricted" => js)

        static member inline vrdisplaypresentchange(js: string) = ("onvrdisplaypresentchange" => js)

        static member inline timeout(js: string) = ("ontimeout" => js)

        static member inline inputsourceschange(js: string) = ("oninputsourceschange" => js)

        static member inline selectend(js: string) = ("onselectend" => js)

        static member inline selectstart(js: string) = ("onselectstart" => js)

        static member inline squeezeend(js: string) = ("onsqueezeend" => js)

        static member inline squeezestart(js: string) = ("onsqueezestart" => js)

        static member inline squeeze(js: string) = ("onsqueeze" => js)
