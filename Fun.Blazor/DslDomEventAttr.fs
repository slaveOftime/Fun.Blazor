namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web

[<AutoOpen>]
module DslDomEventAttr =

    type DomAttrBuilder with

        [<CustomOperation("onfocus")>]
        member inline this.onfocus([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
            this.callback (render, "onfocus", callback)
        [<CustomOperation("onfocus")>]
        member inline this.onfocus([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
            this.callback (render, "onfocus", callback)
        [<CustomOperation("onfocus")>]
        member inline this.onfocus([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) =
            this.callback (render, "onfocus", callback)

        [<CustomOperation("onblur")>]
        member inline this.onblur([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
            this.callback (render, "onblur", callback)
        [<CustomOperation("onblur")>]
        member inline this.onblur([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
            this.callback (render, "onblur", callback)
        [<CustomOperation("onblur")>]
        member inline this.onblur([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) =
            this.callback (render, "onblur", callback)

        [<CustomOperation("onfocusin")>]
        member inline this.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
            this.callback (render, "onfocusin", callback)
        [<CustomOperation("onfocusin")>]
        member inline this.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
            this.callback (render, "onfocusin", callback)
        [<CustomOperation("onfocusin")>]
        member inline this.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) =
            this.callback (render, "onfocusin", callback)

        [<CustomOperation("onfocusout")>]
        member inline this.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
            this.callback (render, "onfocusout", callback)
        [<CustomOperation("onfocusout")>]
        member inline this.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
            this.callback (render, "onfocusout", callback)
        [<CustomOperation("onfocusout")>]
        member inline this.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) =
            this.callback (render, "onfocusout", callback)

        [<CustomOperation("onmouseover")>]
        member inline this.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "onmouseover", callback)
        [<CustomOperation("onmouseover")>]
        member inline this.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "onmouseover", callback)
        [<CustomOperation("onmouseover")>]
        member inline this.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "onmouseover", callback)

        [<CustomOperation("onmouseout")>]
        member inline this.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "onmouseout", callback)
        [<CustomOperation("onmouseout")>]
        member inline this.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "onmouseout", callback)
        [<CustomOperation("onmouseout")>]
        member inline this.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "onmouseout", callback)

        [<CustomOperation("onmousemove")>]
        member inline this.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "onmousemove", callback)
        [<CustomOperation("onmousemove")>]
        member inline this.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "onmousemove", callback)
        [<CustomOperation("onmousemove")>]
        member inline this.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "onmousemove", callback)

        [<CustomOperation("onmousedown")>]
        member inline this.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "onmousedown", callback)
        [<CustomOperation("onmousedown")>]
        member inline this.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "onmousedown", callback)
        [<CustomOperation("onmousedown")>]
        member inline this.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "onmousedown", callback)

        [<CustomOperation("onmouseup")>]
        member inline this.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "onmouseup", callback)
        [<CustomOperation("onmouseup")>]
        member inline this.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "onmouseup", callback)
        [<CustomOperation("onmouseup")>]
        member inline this.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "onmouseup", callback)

        [<CustomOperation("onclick")>]
        member inline this.onclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "onclick", callback)
        [<CustomOperation("onclick")>]
        member inline this.onclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "onclick", callback)
        [<CustomOperation("onclick")>]
        member inline this.onclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "onclick", callback)

        [<CustomOperation("ondblclick")>]
        member inline this.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "ondblclick", callback)
        [<CustomOperation("ondblclick")>]
        member inline this.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "ondblclick", callback)
        [<CustomOperation("ondblclick")>]
        member inline this.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "ondblclick", callback)

        [<CustomOperation("onwheel")>]
        member inline this.onwheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "onwheel", callback)
        [<CustomOperation("onwheel")>]
        member inline this.onwheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "onwheel", callback)
        [<CustomOperation("onwheel")>]
        member inline this.onwheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "onwheel", callback)

        [<CustomOperation("onmousewheel")>]
        member inline this.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "onmousewheel", callback)
        [<CustomOperation("onmousewheel")>]
        member inline this.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "onmousewheel", callback)
        [<CustomOperation("onmousewheel")>]
        member inline this.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "onmousewheel", callback)

        [<CustomOperation("oncontextmenu")>]
        member inline this.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            this.callback (render, "oncontextmenu", callback)
        [<CustomOperation("oncontextmenu")>]
        member inline this.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            this.callback (render, "oncontextmenu", callback)
        [<CustomOperation("oncontextmenu")>]
        member inline this.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            this.callback (render, "oncontextmenu", callback)

        [<CustomOperation("ondrag")>]
        member inline this.ondrag([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            this.callback (render, "ondrag", callback)
        [<CustomOperation("ondrag")>]
        member inline this.ondrag([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            this.callback (render, "ondrag", callback)
        [<CustomOperation("ondrag")>]
        member inline this.ondrag([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            this.callback (render, "ondrag", callback)

        [<CustomOperation("ondragend")>]
        member inline this.ondragend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            this.callback (render, "ondragend", callback)
        [<CustomOperation("ondragend")>]
        member inline this.ondragend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            this.callback (render, "ondragend", callback)
        [<CustomOperation("ondragend")>]
        member inline this.ondragend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            this.callback (render, "ondragend", callback)

        [<CustomOperation("ondragenter")>]
        member inline this.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            this.callback (render, "ondragenter", callback)
        [<CustomOperation("ondragenter")>]
        member inline this.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            this.callback (render, "ondragenter", callback)
        [<CustomOperation("ondragenter")>]
        member inline this.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            this.callback (render, "ondragenter", callback)

        [<CustomOperation("ondragleave")>]
        member inline this.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            this.callback (render, "ondragleave", callback)
        [<CustomOperation("ondragleave")>]
        member inline this.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            this.callback (render, "ondragleave", callback)
        [<CustomOperation("ondragleave")>]
        member inline this.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            this.callback (render, "ondragleave", callback)

        [<CustomOperation("ondragover")>]
        member inline this.ondragover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            this.callback (render, "ondragover", callback)
        [<CustomOperation("ondragover")>]
        member inline this.ondragover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            this.callback (render, "ondragover", callback)
        [<CustomOperation("ondragover")>]
        member inline this.ondragover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            this.callback (render, "ondragover", callback)

        [<CustomOperation("ondragstart")>]
        member inline this.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            this.callback (render, "ondragstart", callback)
        [<CustomOperation("ondragstart")>]
        member inline this.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            this.callback (render, "ondragstart", callback)
        [<CustomOperation("ondragstart")>]
        member inline this.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            this.callback (render, "ondragstart", callback)

        [<CustomOperation("ondrop")>]
        member inline this.ondrop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            this.callback (render, "ondrop", callback)
        [<CustomOperation("ondrop")>]
        member inline this.ondrop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            this.callback (render, "ondrop", callback)
        [<CustomOperation("ondrop")>]
        member inline this.ondrop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            this.callback (render, "ondrop", callback)

        [<CustomOperation("onkeydown")>]
        member inline this.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
            this.callback (render, "onkeydown", callback)
        [<CustomOperation("onkeydown")>]
        member inline this.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
            this.callback (render, "onkeydown", callback)
        [<CustomOperation("onkeydown")>]
        member inline this.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) =
            this.callback (render, "onkeydown", callback)

        [<CustomOperation("onkeyup")>]
        member inline this.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
            this.callback (render, "onkeyup", callback)
        [<CustomOperation("onkeyup")>]
        member inline this.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
            this.callback (render, "onkeyup", callback)
        [<CustomOperation("onkeyup")>]
        member inline this.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) =
            this.callback (render, "onkeyup", callback)

        [<CustomOperation("onkeypress")>]
        member inline this.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
            this.callback (render, "onkeypress", callback)
        [<CustomOperation("onkeypress")>]
        member inline this.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
            this.callback (render, "onkeypress", callback)
        [<CustomOperation("onkeypress")>]
        member inline this.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) =
            this.callback (render, "onkeypress", callback)

        [<CustomOperation("onchange")>]
        member inline this.onchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> unit) =
            this.callback (render, "onchange", callback)
        [<CustomOperation("onchange")>]
        member inline this.onchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task) =
            this.callback (render, "onchange", callback)
        [<CustomOperation("onchange")>]
        member inline this.onchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task<unit>) =
            this.callback (render, "onchange", callback)

        [<CustomOperation("oninput")>]
        member inline this.oninput([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> unit) =
            this.callback (render, "oninput", callback)
        [<CustomOperation("oninput")>]
        member inline this.oninput([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task) =
            this.callback (render, "oninput", callback)
        [<CustomOperation("oninput")>]
        member inline this.oninput([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task<unit>) =
            this.callback (render, "oninput", callback)

        [<CustomOperation("oninvalid")>]
        member inline this.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "oninvalid", callback)
        [<CustomOperation("oninvalid")>]
        member inline this.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "oninvalid", callback)
        [<CustomOperation("oninvalid")>]
        member inline this.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "oninvalid", callback)

        [<CustomOperation("onreset")>]
        member inline this.onreset([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onreset", callback)
        [<CustomOperation("onreset")>]
        member inline this.onreset([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onreset", callback)
        [<CustomOperation("onreset")>]
        member inline this.onreset([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onreset", callback)

        [<CustomOperation("onselect")>]
        member inline this.onselect([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onselect", callback)
        [<CustomOperation("onselect")>]
        member inline this.onselect([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onselect", callback)
        [<CustomOperation("onselect")>]
        member inline this.onselect([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onselect", callback)

        [<CustomOperation("onselectstart")>]
        member inline this.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onselectstart", callback)
        [<CustomOperation("onselectstart")>]
        member inline this.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onselectstart", callback)
        [<CustomOperation("onselectstart")>]
        member inline this.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onselectstart", callback)

        [<CustomOperation("onselectionchange")>]
        member inline this.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onselectionchange", callback)
        [<CustomOperation("onselectionchange")>]
        member inline this.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onselectionchange", callback)
        [<CustomOperation("onselectionchange")>]
        member inline this.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onselectionchange", callback)

        [<CustomOperation("onsubmit")>]
        member inline this.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onsubmit", callback)
        [<CustomOperation("onsubmit")>]
        member inline this.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onsubmit", callback)
        [<CustomOperation("onsubmit")>]
        member inline this.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onsubmit", callback)

        [<CustomOperation("onbeforecopy")>]
        member inline this.onbeforecopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onbeforecopy", callback)
        [<CustomOperation("onbeforecopy")>]
        member inline this.onbeforecopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onbeforecopy", callback)
        [<CustomOperation("onbeforecopy")>]
        member inline this.onbeforecopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onbeforecopy", callback)

        [<CustomOperation("onbeforecut")>]
        member inline this.onbeforecut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onbeforecut", callback)
        [<CustomOperation("onbeforecut")>]
        member inline this.onbeforecut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onbeforecut", callback)
        [<CustomOperation("onbeforecut")>]
        member inline this.onbeforecut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onbeforecut", callback)

        [<CustomOperation("onbeforepaste")>]
        member inline this.onbeforepaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onbeforepaste", callback)
        [<CustomOperation("onbeforepaste")>]
        member inline this.onbeforepaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onbeforepaste", callback)
        [<CustomOperation("onbeforepaste")>]
        member inline this.onbeforepaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onbeforepaste", callback)

        [<CustomOperation("oncopy")>]
        member inline this.oncopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
            this.callback (render, "oncopy", callback)
        [<CustomOperation("oncopy")>]
        member inline this.oncopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
            this.callback (render, "oncopy", callback)
        [<CustomOperation("oncopy")>]
        member inline this.oncopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) =
            this.callback (render, "oncopy", callback)

        [<CustomOperation("oncut")>]
        member inline this.oncut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
            this.callback (render, "oncut", callback)
        [<CustomOperation("oncut")>]
        member inline this.oncut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
            this.callback (render, "oncut", callback)
        [<CustomOperation("oncut")>]
        member inline this.oncut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) =
            this.callback (render, "oncut", callback)

        [<CustomOperation("onpaste")>]
        member inline this.onpaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
            this.callback (render, "onpaste", callback)
        [<CustomOperation("onpaste")>]
        member inline this.onpaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
            this.callback (render, "onpaste", callback)
        [<CustomOperation("onpaste")>]
        member inline this.onpaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) =
            this.callback (render, "onpaste", callback)

        [<CustomOperation("ontouchcancel")>]
        member inline this.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            this.callback (render, "ontouchcancel", callback)
        [<CustomOperation("ontouchcancel")>]
        member inline this.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            this.callback (render, "ontouchcancel", callback)
        [<CustomOperation("ontouchcancel")>]
        member inline this.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            this.callback (render, "ontouchcancel", callback)

        [<CustomOperation("ontouchend")>]
        member inline this.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            this.callback (render, "ontouchend", callback)
        [<CustomOperation("ontouchend")>]
        member inline this.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            this.callback (render, "ontouchend", callback)
        [<CustomOperation("ontouchend")>]
        member inline this.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            this.callback (render, "ontouchend", callback)

        [<CustomOperation("ontouchmove")>]
        member inline this.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            this.callback (render, "ontouchmove", callback)
        [<CustomOperation("ontouchmove")>]
        member inline this.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            this.callback (render, "ontouchmove", callback)
        [<CustomOperation("ontouchmove")>]
        member inline this.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            this.callback (render, "ontouchmove", callback)

        [<CustomOperation("ontouchstart")>]
        member inline this.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            this.callback (render, "ontouchstart", callback)
        [<CustomOperation("ontouchstart")>]
        member inline this.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            this.callback (render, "ontouchstart", callback)
        [<CustomOperation("ontouchstart")>]
        member inline this.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            this.callback (render, "ontouchstart", callback)

        [<CustomOperation("ontouchenter")>]
        member inline this.ontouchenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            this.callback (render, "ontouchenter", callback)
        [<CustomOperation("ontouchenter")>]
        member inline this.ontouchenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            this.callback (render, "ontouchenter", callback)
        [<CustomOperation("ontouchenter")>]
        member inline this.ontouchenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            this.callback (render, "ontouchenter", callback)

        [<CustomOperation("ontouchleave")>]
        member inline this.ontouchleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            this.callback (render, "ontouchleave", callback)
        [<CustomOperation("ontouchleave")>]
        member inline this.ontouchleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            this.callback (render, "ontouchleave", callback)
        [<CustomOperation("ontouchleave")>]
        member inline this.ontouchleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            this.callback (render, "ontouchleave", callback)

        [<CustomOperation("onpointercapture")>]
        member inline this.onpointercapture([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointercapture", callback)
        [<CustomOperation("onpointercapture")>]
        member inline this.onpointercapture([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointercapture", callback)
        [<CustomOperation("onpointercapture")>]
        member inline this.onpointercapture
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            this.callback (render, "onpointercapture", callback)

        [<CustomOperation("onlostpointercapture")>]
        member inline this.onlostpointercapture
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> unit
            )
            =
            this.callback (render, "onlostpointercapture", callback)
        [<CustomOperation("onlostpointercapture")>]
        member inline this.onlostpointercapture
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task
            )
            =
            this.callback (render, "onlostpointercapture", callback)
        [<CustomOperation("onlostpointercapture")>]
        member inline this.onlostpointercapture
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            this.callback (render, "onlostpointercapture", callback)

        [<CustomOperation("onpointercancel")>]
        member inline this.onpointercancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointercancel", callback)
        [<CustomOperation("onpointercancel")>]
        member inline this.onpointercancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointercancel", callback)
        [<CustomOperation("onpointercancel")>]
        member inline this.onpointercancel
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            this.callback (render, "onpointercancel", callback)

        [<CustomOperation("onpointerdown")>]
        member inline this.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointerdown", callback)
        [<CustomOperation("onpointerdown")>]
        member inline this.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointerdown", callback)
        [<CustomOperation("onpointerdown")>]
        member inline this.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            this.callback (render, "onpointerdown", callback)

        [<CustomOperation("onpointerenter")>]
        member inline this.onpointerenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointerenter", callback)
        [<CustomOperation("onpointerenter")>]
        member inline this.onpointerenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointerenter", callback)
        [<CustomOperation("onpointerenter")>]
        member inline this.onpointerenter
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            this.callback (render, "onpointerenter", callback)

        [<CustomOperation("onpointerleave")>]
        member inline this.onpointerleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointerleave", callback)
        [<CustomOperation("onpointerleave")>]
        member inline this.onpointerleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointerleave", callback)
        [<CustomOperation("onpointerleave")>]
        member inline this.onpointerleave
            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            this.callback (render, "onpointerleave", callback)

        [<CustomOperation("onpointermove")>]
        member inline this.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointermove", callback)
        [<CustomOperation("onpointermove")>]
        member inline this.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointermove", callback)
        [<CustomOperation("onpointermove")>]
        member inline this.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            this.callback (render, "onpointermove", callback)

        [<CustomOperation("onpointerout")>]
        member inline this.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointerout", callback)
        [<CustomOperation("onpointerout")>]
        member inline this.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointerout", callback)
        [<CustomOperation("onpointerout")>]
        member inline this.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            this.callback (render, "onpointerout", callback)

        [<CustomOperation("onpointerover")>]
        member inline this.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointerover", callback)
        [<CustomOperation("onpointerover")>]
        member inline this.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointerover", callback)
        [<CustomOperation("onpointerover")>]
        member inline this.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            this.callback (render, "onpointerover", callback)

        [<CustomOperation("onpointerup")>]
        member inline this.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            this.callback (render, "onpointerup", callback)
        [<CustomOperation("onpointerup")>]
        member inline this.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            this.callback (render, "onpointerup", callback)
        [<CustomOperation("onpointerup")>]
        member inline this.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            this.callback (render, "onpointerup", callback)

        [<CustomOperation("oncanplay")>]
        member inline this.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "oncanplay", callback)
        [<CustomOperation("oncanplay")>]
        member inline this.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "oncanplay", callback)
        [<CustomOperation("oncanplay")>]
        member inline this.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "oncanplay", callback)

        [<CustomOperation("oncanplaythrough")>]
        member inline this.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "oncanplaythrough", callback)
        [<CustomOperation("oncanplaythrough")>]
        member inline this.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "oncanplaythrough", callback)
        [<CustomOperation("oncanplaythrough")>]
        member inline this.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "oncanplaythrough", callback)

        [<CustomOperation("oncuechange")>]
        member inline this.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "oncuechange", callback)
        [<CustomOperation("oncuechange")>]
        member inline this.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "oncuechange", callback)
        [<CustomOperation("oncuechange")>]
        member inline this.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "oncuechange", callback)

        [<CustomOperation("ondurationchange")>]
        member inline this.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "ondurationchange", callback)
        [<CustomOperation("ondurationchange")>]
        member inline this.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "ondurationchange", callback)
        [<CustomOperation("ondurationchange")>]
        member inline this.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "ondurationchange", callback)

        [<CustomOperation("onemptied")>]
        member inline this.onemptied([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onemptied", callback)
        [<CustomOperation("onemptied")>]
        member inline this.onemptied([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onemptied", callback)
        [<CustomOperation("onemptied")>]
        member inline this.onemptied([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onemptied", callback)

        [<CustomOperation("onpause")>]
        member inline this.onpause([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onpause", callback)
        [<CustomOperation("onpause")>]
        member inline this.onpause([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onpause", callback)
        [<CustomOperation("onpause")>]
        member inline this.onpause([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onpause", callback)

        [<CustomOperation("onplay")>]
        member inline this.onplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onplay", callback)
        [<CustomOperation("onplay")>]
        member inline this.onplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onplay", callback)
        [<CustomOperation("onplay")>]
        member inline this.onplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onplay", callback)

        [<CustomOperation("onplaying")>]
        member inline this.onplaying([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onplaying", callback)
        [<CustomOperation("onplaying")>]
        member inline this.onplaying([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onplaying", callback)
        [<CustomOperation("onplaying")>]
        member inline this.onplaying([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onplaying", callback)

        [<CustomOperation("onratechange")>]
        member inline this.onratechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onratechange", callback)
        [<CustomOperation("onratechange")>]
        member inline this.onratechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onratechange", callback)
        [<CustomOperation("onratechange")>]
        member inline this.onratechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onratechange", callback)

        [<CustomOperation("onseeked")>]
        member inline this.onseeked([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onseeked", callback)
        [<CustomOperation("onseeked")>]
        member inline this.onseeked([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onseeked", callback)
        [<CustomOperation("onseeked")>]
        member inline this.onseeked([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onseeked", callback)

        [<CustomOperation("onseeking")>]
        member inline this.onseeking([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onseeking", callback)
        [<CustomOperation("onseeking")>]
        member inline this.onseeking([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onseeking", callback)
        [<CustomOperation("onseeking")>]
        member inline this.onseeking([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onseeking", callback)

        [<CustomOperation("onstalled")>]
        member inline this.onstalled([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onstalled", callback)
        [<CustomOperation("onstalled")>]
        member inline this.onstalled([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onstalled", callback)
        [<CustomOperation("onstalled")>]
        member inline this.onstalled([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onstalled", callback)

        [<CustomOperation("onstop")>]
        member inline this.onstop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onstop", callback)
        [<CustomOperation("onstop")>]
        member inline this.onstop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onstop", callback)
        [<CustomOperation("onstop")>]
        member inline this.onstop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onstop", callback)

        [<CustomOperation("onsuspend")>]
        member inline this.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onsuspend", callback)
        [<CustomOperation("onsuspend")>]
        member inline this.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onsuspend", callback)
        [<CustomOperation("onsuspend")>]
        member inline this.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onsuspend", callback)

        [<CustomOperation("ontimeupdate")>]
        member inline this.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "ontimeupdate", callback)
        [<CustomOperation("ontimeupdate")>]
        member inline this.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "ontimeupdate", callback)
        [<CustomOperation("ontimeupdate")>]
        member inline this.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "ontimeupdate", callback)

        [<CustomOperation("onvolumechange")>]
        member inline this.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onvolumechange", callback)
        [<CustomOperation("onvolumechange")>]
        member inline this.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onvolumechange", callback)
        [<CustomOperation("onvolumechange")>]
        member inline this.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onvolumechange", callback)

        [<CustomOperation("onwaiting")>]
        member inline this.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onwaiting", callback)
        [<CustomOperation("onwaiting")>]
        member inline this.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onwaiting", callback)
        [<CustomOperation("onwaiting")>]
        member inline this.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onwaiting", callback)

        [<CustomOperation("onloadstart")>]
        member inline this.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            this.callback (render, "onloadstart", callback)
        [<CustomOperation("onloadstart")>]
        member inline this.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            this.callback (render, "onloadstart", callback)
        [<CustomOperation("onloadstart")>]
        member inline this.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            this.callback (render, "onloadstart", callback)

        [<CustomOperation("ontimeout")>]
        member inline this.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            this.callback (render, "ontimeout", callback)
        [<CustomOperation("ontimeout")>]
        member inline this.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            this.callback (render, "ontimeout", callback)
        [<CustomOperation("ontimeout")>]
        member inline this.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            this.callback (render, "ontimeout", callback)

        [<CustomOperation("onabort")>]
        member inline this.onabort([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            this.callback (render, "onabort", callback)
        [<CustomOperation("onabort")>]
        member inline this.onabort([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            this.callback (render, "onabort", callback)
        [<CustomOperation("onabort")>]
        member inline this.onabort([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            this.callback (render, "onabort", callback)

        [<CustomOperation("onload")>]
        member inline this.onload([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            this.callback (render, "onload", callback)
        [<CustomOperation("onload")>]
        member inline this.onload([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            this.callback (render, "onload", callback)
        [<CustomOperation("onload")>]
        member inline this.onload([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            this.callback (render, "onload", callback)

        [<CustomOperation("onloadend")>]
        member inline this.onloadend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            this.callback (render, "onloadend", callback)
        [<CustomOperation("onloadend")>]
        member inline this.onloadend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            this.callback (render, "onloadend", callback)
        [<CustomOperation("onloadend")>]
        member inline this.onloadend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            this.callback (render, "onloadend", callback)

        [<CustomOperation("onprogress")>]
        member inline this.onprogress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            this.callback (render, "onprogress", callback)
        [<CustomOperation("onprogress")>]
        member inline this.onprogress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            this.callback (render, "onprogress", callback)
        [<CustomOperation("onprogress")>]
        member inline this.onprogress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            this.callback (render, "onprogress", callback)

        [<CustomOperation("onerror")>]
        member inline this.onerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ErrorEventArgs -> unit) =
            this.callback (render, "onerror", callback)
        [<CustomOperation("onerror")>]
        member inline this.onerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ErrorEventArgs -> Task) =
            this.callback (render, "onerror", callback)
        [<CustomOperation("onerror")>]
        member inline this.onerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ErrorEventArgs -> Task<unit>) =
            this.callback (render, "onerror", callback)

        [<CustomOperation("onactivate")>]
        member inline this.onactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onactivate", callback)
        [<CustomOperation("onactivate")>]
        member inline this.onactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onactivate", callback)
        [<CustomOperation("onactivate")>]
        member inline this.onactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onactivate", callback)

        [<CustomOperation("onbeforeactivate")>]
        member inline this.onbeforeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onbeforeactivate", callback)
        [<CustomOperation("onbeforeactivate")>]
        member inline this.onbeforeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onbeforeactivate", callback)
        [<CustomOperation("onbeforeactivate")>]
        member inline this.onbeforeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onbeforeactivate", callback)

        [<CustomOperation("onbeforedeactivate")>]
        member inline this.onbeforedeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onbeforedeactivate", callback)
        [<CustomOperation("onbeforedeactivate")>]
        member inline this.onbeforedeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onbeforedeactivate", callback)
        [<CustomOperation("onbeforedeactivate")>]
        member inline this.onbeforedeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onbeforedeactivate", callback)

        [<CustomOperation("ondeactivate")>]
        member inline this.ondeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "ondeactivate", callback)
        [<CustomOperation("ondeactivate")>]
        member inline this.ondeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "ondeactivate", callback)
        [<CustomOperation("ondeactivate")>]
        member inline this.ondeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "ondeactivate", callback)

        [<CustomOperation("onended")>]
        member inline this.onended([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onended", callback)
        [<CustomOperation("onended")>]
        member inline this.onended([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onended", callback)
        [<CustomOperation("onended")>]
        member inline this.onended([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onended", callback)

        [<CustomOperation("onfullscreenchange")>]
        member inline this.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onfullscreenchange", callback)
        [<CustomOperation("onfullscreenchange")>]
        member inline this.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onfullscreenchange", callback)
        [<CustomOperation("onfullscreenchange")>]
        member inline this.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onfullscreenchange", callback)

        [<CustomOperation("onfullscreenerror")>]
        member inline this.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onfullscreenerror", callback)
        [<CustomOperation("onfullscreenerror")>]
        member inline this.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onfullscreenerror", callback)
        [<CustomOperation("onfullscreenerror")>]
        member inline this.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onfullscreenerror", callback)

        [<CustomOperation("onloadeddata")>]
        member inline this.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onloadeddata", callback)
        [<CustomOperation("onloadeddata")>]
        member inline this.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onloadeddata", callback)
        [<CustomOperation("onloadeddata")>]
        member inline this.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onloadeddata", callback)

        [<CustomOperation("onloadedmetadata")>]
        member inline this.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onloadedmetadata", callback)
        [<CustomOperation("onloadedmetadata")>]
        member inline this.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onloadedmetadata", callback)
        [<CustomOperation("onloadedmetadata")>]
        member inline this.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onloadedmetadata", callback)

        [<CustomOperation("onpointerlockchange")>]
        member inline this.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onpointerlockchange", callback)
        [<CustomOperation("onpointerlockchange")>]
        member inline this.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onpointerlockchange", callback)
        [<CustomOperation("onpointerlockchange")>]
        member inline this.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onpointerlockchange", callback)

        [<CustomOperation("onpointerlockerror")>]
        member inline this.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onpointerlockerror", callback)
        [<CustomOperation("onpointerlockerror")>]
        member inline this.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onpointerlockerror", callback)
        [<CustomOperation("onpointerlockerror")>]
        member inline this.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onpointerlockerror", callback)

        [<CustomOperation("onreadystatechange")>]
        member inline this.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onreadystatechange", callback)
        [<CustomOperation("onreadystatechange")>]
        member inline this.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onreadystatechange", callback)
        [<CustomOperation("onreadystatechange")>]
        member inline this.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onreadystatechange", callback)

        [<CustomOperation("onscroll")>]
        member inline this.onscroll([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            this.callback (render, "onscroll", callback)
        [<CustomOperation("onscroll")>]
        member inline this.onscroll([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            this.callback (render, "onscroll", callback)
        [<CustomOperation("onscroll")>]
        member inline this.onscroll([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            this.callback (render, "onscroll", callback)


namespace Fun.Blazor.Unsafe

open Fun.Blazor
open Operators

[<AutoOpen>]
module Events =

    type DomAttrBuilder with

        [<CustomOperation("onabort")>]
        member inline _.onabort([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onabort" => js)

        [<CustomOperation("onended")>]
        member inline _.onended([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onended" => js)

        [<CustomOperation("onaddtrack")>]
        member inline _.onaddtrack([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onaddtrack" => js)

        [<CustomOperation("onchange")>]
        member inline _.onchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onchange" => js)

        [<CustomOperation("onremovetrack")>]
        member inline _.onremovetrack([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onremovetrack" => js)

        [<CustomOperation("onmessageerror")>]
        member inline _.onmessageerror([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmessageerror" => js)

        [<CustomOperation("onmessage")>]
        member inline _.onmessage([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmessage" => js)

        [<CustomOperation("onanimationcancel")>]
        member inline _.onanimationcancel([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onanimationcancel" => js)

        [<CustomOperation("onanimationend")>]
        member inline _.onanimationend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onanimationend" => js)

        [<CustomOperation("onanimationiteration")>]
        member inline _.onanimationiteration([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onanimationiteration" => js)

        [<CustomOperation("onanimationstart")>]
        member inline _.onanimationstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onanimationstart" => js)

        [<CustomOperation("oncopy")>]
        member inline _.oncopy([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncopy" => js)

        [<CustomOperation("oncut")>]
        member inline _.oncut([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncut" => js)

        [<CustomOperation("onDOMContentLoaded")>]
        member inline _.onDOMContentLoaded([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onDOMContentLoaded" => js)

        [<CustomOperation("ondragend")>]
        member inline _.ondragend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondragend" => js)

        [<CustomOperation("ondragenter")>]
        member inline _.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondragenter" => js)

        [<CustomOperation("ondragleave")>]
        member inline _.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondragleave" => js)

        [<CustomOperation("ondragover")>]
        member inline _.ondragover([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondragover" => js)

        [<CustomOperation("ondragstart")>]
        member inline _.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondragstart" => js)

        [<CustomOperation("ondrag")>]
        member inline _.ondrag([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondrag" => js)

        [<CustomOperation("ondrop")>]
        member inline _.ondrop([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondrop" => js)

        [<CustomOperation("onfullscreenchange")>]
        member inline _.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onfullscreenchange" => js)

        [<CustomOperation("onfullscreenerror")>]
        member inline _.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onfullscreenerror" => js)

        [<CustomOperation("ongotpointercapture")>]
        member inline _.ongotpointercapture([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ongotpointercapture" => js)

        [<CustomOperation("onkeydown")>]
        member inline _.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onkeydown" => js)

        [<CustomOperation("onkeypress")>]
        member inline _.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onkeypress" => js)

        [<CustomOperation("onkeyup")>]
        member inline _.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onkeyup" => js)


        [<CustomOperation("onlostpointercapture")>]
        member inline _.onlostpointercapture([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onlostpointercapture" => js)

        [<CustomOperation("onpaste")>]
        member inline _.onpaste([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpaste" => js)

        [<CustomOperation("onpointercancel")>]
        member inline _.onpointercancel([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointercancel" => js)

        [<CustomOperation("onpointerdown")>]
        member inline _.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointerdown" => js)

        [<CustomOperation("onpointerenter")>]
        member inline _.onpointerenter([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointerenter" => js)

        [<CustomOperation("onpointerleave")>]
        member inline _.onpointerleave([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointerleave" => js)

        [<CustomOperation("onpointerlockchange")>]
        member inline _.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointerlockchange" => js)

        [<CustomOperation("onpointerlockerror")>]
        member inline _.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointerlockerror" => js)

        [<CustomOperation("onpointermove")>]
        member inline _.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointermove" => js)

        [<CustomOperation("onpointerout")>]
        member inline _.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointerout" => js)

        [<CustomOperation("onpointerover")>]
        member inline _.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointerover" => js)

        [<CustomOperation("onpointerup")>]
        member inline _.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpointerup" => js)

        [<CustomOperation("onreadystatechange")>]
        member inline _.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onreadystatechange" => js)

        [<CustomOperation("onscroll")>]
        member inline _.onscroll([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onscroll" => js)

        [<CustomOperation("onselectionchange")>]
        member inline _.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onselectionchange" => js)

        [<CustomOperation("ontouchcancel")>]
        member inline _.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontouchcancel" => js)

        [<CustomOperation("ontouchend")>]
        member inline _.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontouchend" => js)

        [<CustomOperation("ontouchmove")>]
        member inline _.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontouchmove" => js)

        [<CustomOperation("ontouchstart")>]
        member inline _.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontouchstart" => js)

        [<CustomOperation("ontransitioncancel")>]
        member inline _.ontransitioncancel([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontransitioncancel" => js)

        [<CustomOperation("ontransitionend")>]
        member inline _.ontransitionend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontransitionend" => js)

        [<CustomOperation("ontransitionrun")>]
        member inline _.ontransitionrun([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontransitionrun" => js)

        [<CustomOperation("ontransitionstart")>]
        member inline _.ontransitionstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontransitionstart" => js)

        [<CustomOperation("onvisibilitychange")>]
        member inline _.onvisibilitychange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvisibilitychange" => js)

        [<CustomOperation("onwheel")>]
        member inline _.onwheel([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onwheel" => js)

        [<CustomOperation("onafterscriptexecute")>]
        member inline _.onafterscriptexecute([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onafterscriptexecute" => js)

        [<CustomOperation("onauxclick")>]
        member inline _.onauxclick([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onauxclick" => js)

        [<CustomOperation("onbeforescriptexecute")>]
        member inline _.onbeforescriptexecute([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onbeforescriptexecute" => js)

        [<CustomOperation("onblur")>]
        member inline _.onblur([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onblur" => js)

        [<CustomOperation("onclick")>]
        member inline _.onclick([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onclick" => js)

        [<CustomOperation("oncompositionend")>]
        member inline _.oncompositionend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncompositionend" => js)

        [<CustomOperation("oncompositionstart")>]
        member inline _.oncompositionstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncompositionstart" => js)

        [<CustomOperation("oncompositionupdate")>]
        member inline _.oncompositionupdate([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncompositionupdate" => js)

        [<CustomOperation("oncontextmenu")>]
        member inline _.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncontextmenu" => js)

        [<CustomOperation("ondblclick")>]
        member inline _.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondblclick" => js)

        [<CustomOperation("onDOMActivate")>]
        member inline _.onDOMActivate([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onDOMActivate" => js)

        [<CustomOperation("onDOMMouseScroll")>]
        member inline _.onDOMMouseScroll([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onDOMMouseScroll" => js)

        [<CustomOperation("onerror")>]
        member inline _.onerror([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onerror" => js)

        [<CustomOperation("onfocusin")>]
        member inline _.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onfocusin" => js)

        [<CustomOperation("onfocusout")>]
        member inline _.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onfocusout" => js)

        [<CustomOperation("onfocus")>]
        member inline _.onfocus([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onfocus" => js)

        [<CustomOperation("ongesturechange")>]
        member inline _.ongesturechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ongesturechange" => js)

        [<CustomOperation("ongestureend")>]
        member inline _.ongestureend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ongestureend" => js)

        [<CustomOperation("ongesturestart")>]
        member inline _.ongesturestart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ongesturestart" => js)

        [<CustomOperation("onmousedown")>]
        member inline _.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmousedown" => js)

        [<CustomOperation("onmouseenter")>]
        member inline _.onmouseenter([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmouseenter" => js)

        [<CustomOperation("onmouseleave")>]
        member inline _.onmouseleave([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmouseleave" => js)

        [<CustomOperation("onmousemove")>]
        member inline _.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmousemove" => js)

        [<CustomOperation("onmouseout")>]
        member inline _.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmouseout" => js)

        [<CustomOperation("onmouseover")>]
        member inline _.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmouseover" => js)

        [<CustomOperation("onmouseup")>]
        member inline _.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmouseup" => js)

        [<CustomOperation("onmousewheel")>]
        member inline _.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmousewheel" => js)

        [<CustomOperation("onselect")>]
        member inline _.onselect([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onselect" => js)

        [<CustomOperation("onwebkitmouseforcechanged")>]
        member inline _.onwebkitmouseforcechanged([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onwebkitmouseforcechanged" => js)

        [<CustomOperation("onwebkitmouseforcedown")>]
        member inline _.onwebkitmouseforcedown([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onwebkitmouseforcedown" => js)

        [<CustomOperation("onwebkitmouseforceup")>]
        member inline _.onwebkitmouseforceup([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onwebkitmouseforceup" => js)

        [<CustomOperation("onwebkitmouseforcewillbegin")>]
        member inline _.onwebkitmouseforcewillbegin([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onwebkitmouseforcewillbegin" => js)

        [<CustomOperation("oncancel")>]
        member inline _.oncancel([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncancel" => js)

        [<CustomOperation("onopen")>]
        member inline _.onopen([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onopen" => js)

        [<CustomOperation("onloadend")>]
        member inline _.onloadend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onloadend" => js)

        [<CustomOperation("onloadstart")>]
        member inline _.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onloadstart" => js)

        [<CustomOperation("onload")>]
        member inline _.onload([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onload" => js)

        [<CustomOperation("onprogress")>]
        member inline _.onprogress([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onprogress" => js)

        [<CustomOperation("onwebglcontextcreationerror")>]
        member inline _.onwebglcontextcreationerror([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onwebglcontextcreationerror" => js)

        [<CustomOperation("onwebglcontextlost")>]
        member inline _.onwebglcontextlost([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onwebglcontextlost" => js)

        [<CustomOperation("onwebglcontextrestored")>]
        member inline _.onwebglcontextrestored([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onwebglcontextrestored" => js)

        [<CustomOperation("ontoggle")>]
        member inline _.ontoggle([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontoggle" => js)

        [<CustomOperation("onclose")>]
        member inline _.onclose([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onclose" => js)

        [<CustomOperation("onbeforeinput")>]
        member inline _.onbeforeinput([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onbeforeinput" => js)

        [<CustomOperation("oninput")>]
        member inline _.oninput([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oninput" => js)

        [<CustomOperation("onformdata")>]
        member inline _.onformdata([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onformdata" => js)

        [<CustomOperation("onreset")>]
        member inline _.onreset([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onreset" => js)

        [<CustomOperation("onsubmit")>]
        member inline _.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsubmit" => js)

        [<CustomOperation("oninvalid")>]
        member inline _.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oninvalid" => js)

        [<CustomOperation("onsearch")>]
        member inline _.onsearch([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsearch" => js)

        [<CustomOperation("oncanplaythrough")>]
        member inline _.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncanplaythrough" => js)

        [<CustomOperation("oncanplay")>]
        member inline _.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncanplay" => js)

        [<CustomOperation("ondurationchange")>]
        member inline _.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondurationchange" => js)

        [<CustomOperation("onemptied")>]
        member inline _.onemptied([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onemptied" => js)

        [<CustomOperation("onloadeddata")>]
        member inline _.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onloadeddata" => js)

        [<CustomOperation("onloadedmetadata")>]
        member inline _.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onloadedmetadata" => js)

        [<CustomOperation("onpause")>]
        member inline _.onpause([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpause" => js)

        [<CustomOperation("onplaying")>]
        member inline _.onplaying([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onplaying" => js)

        [<CustomOperation("onplay")>]
        member inline _.onplay([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onplay" => js)

        [<CustomOperation("onratechange")>]
        member inline _.onratechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onratechange" => js)

        [<CustomOperation("onseeked")>]
        member inline _.onseeked([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onseeked" => js)

        [<CustomOperation("onseeking")>]
        member inline _.onseeking([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onseeking" => js)

        [<CustomOperation("onstalled")>]
        member inline _.onstalled([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onstalled" => js)

        [<CustomOperation("onsuspend")>]
        member inline _.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsuspend" => js)

        [<CustomOperation("ontimeupdate")>]
        member inline _.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontimeupdate" => js)

        [<CustomOperation("onvolumechange")>]
        member inline _.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvolumechange" => js)

        [<CustomOperation("onwaiting")>]
        member inline _.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onwaiting" => js)

        [<CustomOperation("onslotchange")>]
        member inline _.onslotchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onslotchange" => js)

        [<CustomOperation("oncuechange")>]
        member inline _.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncuechange" => js)

        [<CustomOperation("onenterpictureinpicture")>]
        member inline _.onenterpictureinpicture([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onenterpictureinpicture" => js)

        [<CustomOperation("onleavepictureinpicture")>]
        member inline _.onleavepictureinpicture([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onleavepictureinpicture" => js)

        [<CustomOperation("onversionchange")>]
        member inline _.onversionchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onversionchange" => js)

        [<CustomOperation("onblocked")>]
        member inline _.onblocked([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onblocked" => js)

        [<CustomOperation("onupgradeneeded")>]
        member inline _.onupgradeneeded([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onupgradeneeded" => js)

        [<CustomOperation("onsuccess")>]
        member inline _.onsuccess([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsuccess" => js)

        [<CustomOperation("oncomplete")>]
        member inline _.oncomplete([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncomplete" => js)

        [<CustomOperation("ondevicechange")>]
        member inline _.ondevicechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondevicechange" => js)

        [<CustomOperation("onmute")>]
        member inline _.onmute([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmute" => js)

        [<CustomOperation("onunmute")>]
        member inline _.onunmute([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onunmute" => js)

        [<CustomOperation("onmerchantvalidation")>]
        member inline _.onmerchantvalidation([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmerchantvalidation" => js)

        [<CustomOperation("onpaymentmethodchange")>]
        member inline _.onpaymentmethodchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpaymentmethodchange" => js)

        [<CustomOperation("onshippingaddresschange")>]
        member inline _.onshippingaddresschange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onshippingaddresschange" => js)

        [<CustomOperation("onshippingoptionchange")>]
        member inline _.onshippingoptionchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onshippingoptionchange" => js)

        [<CustomOperation("onpayerdetailchange")>]
        member inline _.onpayerdetailchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpayerdetailchange" => js)

        [<CustomOperation("onresourcetimingbufferfull")>]
        member inline _.onresourcetimingbufferfull([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onresourcetimingbufferfull" => js)

        [<CustomOperation("onresize")>]
        member inline _.onresize([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onresize" => js)

        [<CustomOperation("onbufferedamountlow")>]
        member inline _.onbufferedamountlow([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onbufferedamountlow" => js)

        [<CustomOperation("onclosing")>]
        member inline _.onclosing([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onclosing" => js)

        [<CustomOperation("ontonechange")>]
        member inline _.ontonechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontonechange" => js)

        [<CustomOperation("ongatheringstatechange")>]
        member inline _.ongatheringstatechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("ongatheringstatechange" => js)

        [<CustomOperation("onselectedcandidatepairchange")>]
        member inline _.onselectedcandidatepairchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onselectedcandidatepairchange" => js)

        [<CustomOperation("onstatechange")>]
        member inline _.onstatechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onstatechange" => js)

        [<CustomOperation("onaddstream")>]
        member inline _.onaddstream([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onaddstream" => js)

        [<CustomOperation("onconnectionstatechange")>]
        member inline _.onconnectionstatechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onconnectionstatechange" => js)

        [<CustomOperation("ondatachannel")>]
        member inline _.ondatachannel([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondatachannel" => js)

        [<CustomOperation("onicecandidateerror")>]
        member inline _.onicecandidateerror([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onicecandidateerror" => js)

        [<CustomOperation("onicecandidate")>]
        member inline _.onicecandidate([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onicecandidate" => js)

        [<CustomOperation("oniceconnectionstatechange")>]
        member inline _.oniceconnectionstatechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("oniceconnectionstatechange" => js)

        [<CustomOperation("onicegatheringstatechange")>]
        member inline _.onicegatheringstatechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onicegatheringstatechange" => js)

        [<CustomOperation("onnegotiationneeded")>]
        member inline _.onnegotiationneeded([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onnegotiationneeded" => js)

        [<CustomOperation("onremovestream")>]
        member inline _.onremovestream([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onremovestream" => js)

        [<CustomOperation("onsignalingstatechange")>]
        member inline _.onsignalingstatechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onsignalingstatechange" => js)

        [<CustomOperation("ontrack")>]
        member inline _.ontrack([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontrack" => js)

        [<CustomOperation("onaudioprocess")>]
        member inline _.onaudioprocess([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onaudioprocess" => js)

        [<CustomOperation("onactivate")>]
        member inline _.onactivate([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onactivate" => js)

        [<CustomOperation("oncontentdelete")>]
        member inline _.oncontentdelete([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oncontentdelete" => js)

        [<CustomOperation("oninstall")>]
        member inline _.oninstall([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oninstall" => js)

        [<CustomOperation("onnotificationclick")>]
        member inline _.onnotificationclick([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onnotificationclick" => js)

        [<CustomOperation("onpushsubscriptionchange")>]
        member inline _.onpushsubscriptionchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onpushsubscriptionchange" => js)

        [<CustomOperation("onpush")>]
        member inline _.onpush([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpush" => js)

        [<CustomOperation("onconnect")>]
        member inline _.onconnect([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onconnect" => js)

        [<CustomOperation("onaudioend")>]
        member inline _.onaudioend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onaudioend" => js)

        [<CustomOperation("onaudiostart")>]
        member inline _.onaudiostart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onaudiostart" => js)

        [<CustomOperation("onend")>]
        member inline _.onend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onend" => js)

        [<CustomOperation("onnomatch")>]
        member inline _.onnomatch([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onnomatch" => js)

        [<CustomOperation("onresult")>]
        member inline _.onresult([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onresult" => js)

        [<CustomOperation("onsoundend")>]
        member inline _.onsoundend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsoundend" => js)

        [<CustomOperation("onsoundstart")>]
        member inline _.onsoundstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsoundstart" => js)

        [<CustomOperation("onspeechend")>]
        member inline _.onspeechend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onspeechend" => js)

        [<CustomOperation("onspeechstart")>]
        member inline _.onspeechstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onspeechstart" => js)

        [<CustomOperation("onstart")>]
        member inline _.onstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onstart" => js)

        [<CustomOperation("onvoiceschanged")>]
        member inline _.onvoiceschanged([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvoiceschanged" => js)

        [<CustomOperation("onboundary")>]
        member inline _.onboundary([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onboundary" => js)

        [<CustomOperation("onmark")>]
        member inline _.onmark([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onmark" => js)

        [<CustomOperation("onresume")>]
        member inline _.onresume([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onresume" => js)

        [<CustomOperation("onbeginEvent")>]
        member inline _.onbeginEvent([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onbeginEvent" => js)

        [<CustomOperation("onendEvent")>]
        member inline _.onendEvent([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onendEvent" => js)

        [<CustomOperation("onrepeatEvent")>]
        member inline _.onrepeatEvent([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onrepeatEvent" => js)

        [<CustomOperation("onunload")>]
        member inline _.onunload([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onunload" => js)

        [<CustomOperation("onremoveTrack")>]
        member inline _.onremoveTrack([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onremoveTrack" => js)

        [<CustomOperation("onafterprint")>]
        member inline _.onafterprint([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onafterprint" => js)

        [<CustomOperation("onappinstalled")>]
        member inline _.onappinstalled([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onappinstalled" => js)

        [<CustomOperation("onbeforeprint")>]
        member inline _.onbeforeprint([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onbeforeprint" => js)

        [<CustomOperation("onbeforeunload")>]
        member inline _.onbeforeunload([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onbeforeunload" => js)

        [<CustomOperation("ondevicemotion")>]
        member inline _.ondevicemotion([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondevicemotion" => js)

        [<CustomOperation("ondeviceorientation")>]
        member inline _.ondeviceorientation([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ondeviceorientation" => js)

        [<CustomOperation("ongamepadconnected")>]
        member inline _.ongamepadconnected([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ongamepadconnected" => js)

        [<CustomOperation("ongamepaddisconnected")>]
        member inline _.ongamepaddisconnected([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ongamepaddisconnected" => js)

        [<CustomOperation("onhashchange")>]
        member inline _.onhashchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onhashchange" => js)

        [<CustomOperation("onlanguagechange")>]
        member inline _.onlanguagechange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onlanguagechange" => js)

        [<CustomOperation("onoffline")>]
        member inline _.onoffline([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onoffline" => js)

        [<CustomOperation("ononline")>]
        member inline _.ononline([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ononline" => js)

        [<CustomOperation("onorientationchange")>]
        member inline _.onorientationchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onorientationchange" => js)

        [<CustomOperation("onpagehide")>]
        member inline _.onpagehide([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpagehide" => js)

        [<CustomOperation("onpageshow")>]
        member inline _.onpageshow([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpageshow" => js)

        [<CustomOperation("onpopstate")>]
        member inline _.onpopstate([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onpopstate" => js)

        [<CustomOperation("onrejectionhandled")>]
        member inline _.onrejectionhandled([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onrejectionhandled" => js)

        [<CustomOperation("onstorage")>]
        member inline _.onstorage([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onstorage" => js)

        [<CustomOperation("onunhandledrejection")>]
        member inline _.onunhandledrejection([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onunhandledrejection" => js)

        [<CustomOperation("onvrdisplayactivate")>]
        member inline _.onvrdisplayactivate([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvrdisplayactivate" => js)

        [<CustomOperation("onvrdisplayblur")>]
        member inline _.onvrdisplayblur([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvrdisplayblur" => js)

        [<CustomOperation("onvrdisplayconnect")>]
        member inline _.onvrdisplayconnect([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvrdisplayconnect" => js)

        [<CustomOperation("onvrdisplaydeactivate")>]
        member inline _.onvrdisplaydeactivate([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvrdisplaydeactivate" => js)

        [<CustomOperation("onvrdisplaydisconnect")>]
        member inline _.onvrdisplaydisconnect([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvrdisplaydisconnect" => js)

        [<CustomOperation("onvrdisplayfocus")>]
        member inline _.onvrdisplayfocus([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onvrdisplayfocus" => js)

        [<CustomOperation("onvrdisplaypointerrestricted")>]
        member inline _.onvrdisplaypointerrestricted([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onvrdisplaypointerrestricted" => js)

        [<CustomOperation("onvrdisplaypointerunrestricted")>]
        member inline _.onvrdisplaypointerunrestricted([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onvrdisplaypointerunrestricted" => js)

        [<CustomOperation("onvrdisplaypresentchange")>]
        member inline _.onvrdisplaypresentchange([<InlineIfLambda>] render: AttrRenderFragment, js: string) =
            render ==> ("onvrdisplaypresentchange" => js)

        [<CustomOperation("ontimeout")>]
        member inline _.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("ontimeout" => js)

        [<CustomOperation("oninputsourceschange")>]
        member inline _.oninputsourceschange([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("oninputsourceschange" => js)

        [<CustomOperation("onselectend")>]
        member inline _.onselectend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onselectend" => js)

        [<CustomOperation("onselectstart")>]
        member inline _.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onselectstart" => js)

        [<CustomOperation("onsqueezeend")>]
        member inline _.onsqueezeend([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsqueezeend" => js)

        [<CustomOperation("onsqueezestart")>]
        member inline _.onsqueezestart([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsqueezestart" => js)

        [<CustomOperation("onsqueeze")>]
        member inline _.onsqueeze([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onsqueeze" => js)
