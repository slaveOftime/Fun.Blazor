namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators

[<AutoOpen>]
module DslDomEventAttr =

    type DomAttrBuilder with

        [<CustomOperation("onfocus")>]
        member inline _.onfocus([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
            render ==> html.callback ("onfocus", callback)

        [<CustomOperation("onfocus")>]
        member inline _.onfocus([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
            render ==> html.callbackTask ("onfocus", callback)

        [<CustomOperation("onfocus")>]
        member inline _.onfocus([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onfocus", callback)


        [<CustomOperation("onblur")>]
        member inline _.onblur([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
            render ==> html.callback ("onblur", callback)

        [<CustomOperation("onblur")>]
        member inline _.onblur([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
            render ==> html.callbackTask ("onblur", callback)

        [<CustomOperation("onblur")>]
        member inline _.onblur([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onblur", callback)


        [<CustomOperation("onfocusin")>]
        member inline _.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
            render ==> html.callback ("onfocusin", callback)

        [<CustomOperation("onfocusin")>]
        member inline _.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
            render ==> html.callbackTask ("onfocusin", callback)

        [<CustomOperation("onfocusin")>]
        member inline _.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onfocusin", callback)


        [<CustomOperation("onfocusout")>]
        member inline _.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
            render ==> html.callback ("onfocusout", callback)

        [<CustomOperation("onfocusout")>]
        member inline _.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
            render ==> html.callbackTask ("onfocusout", callback)

        [<CustomOperation("onfocusout")>]
        member inline _.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onfocusout", callback)


        [<CustomOperation("onmouseover")>]
        member inline _.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("onmouseover", callback)

        [<CustomOperation("onmouseover")>]
        member inline _.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("onmouseover", callback)

        [<CustomOperation("onmouseover")>]
        member inline _.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onmouseover", callback)


        [<CustomOperation("onmouseout")>]
        member inline _.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("onmouseout", callback)

        [<CustomOperation("onmouseout")>]
        member inline _.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("onmouseout", callback)

        [<CustomOperation("onmouseout")>]
        member inline _.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onmouseout", callback)


        [<CustomOperation("onmousemove")>]
        member inline _.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("onmousemove", callback)

        [<CustomOperation("onmousemove")>]
        member inline _.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("onmousemove", callback)

        [<CustomOperation("onmousemove")>]
        member inline _.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onmousemove", callback)


        [<CustomOperation("onmousedown")>]
        member inline _.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("onmousedown", callback)

        [<CustomOperation("onmousedown")>]
        member inline _.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("onmousedown", callback)

        [<CustomOperation("onmousedown")>]
        member inline _.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onmousedown", callback)


        [<CustomOperation("onmouseup")>]
        member inline _.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("onmouseup", callback)

        [<CustomOperation("onmouseup")>]
        member inline _.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("onmouseup", callback)

        [<CustomOperation("onmouseup")>]
        member inline _.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onmouseup", callback)


        [<CustomOperation("onclick")>]
        member inline _.onclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("onclick", callback)

        [<CustomOperation("onclick")>]
        member inline _.onclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("onclick", callback)

        [<CustomOperation("onclick")>]
        member inline _.onclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onclick", callback)


        [<CustomOperation("ondblclick")>]
        member inline _.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("ondblclick", callback)

        [<CustomOperation("ondblclick")>]
        member inline _.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("ondblclick", callback)

        [<CustomOperation("ondblclick")>]
        member inline _.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondblclick", callback)


        [<CustomOperation("onwheel")>]
        member inline _.onwheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("onwheel", callback)

        [<CustomOperation("onwheel")>]
        member inline _.onwheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("onwheel", callback)

        [<CustomOperation("onwheel")>]
        member inline _.onwheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onwheel", callback)


        [<CustomOperation("onmousewheel")>]
        member inline _.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("onmousewheel", callback)

        [<CustomOperation("onmousewheel")>]
        member inline _.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("onmousewheel", callback)

        [<CustomOperation("onmousewheel")>]
        member inline _.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onmousewheel", callback)


        [<CustomOperation("oncontextmenu")>]
        member inline _.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
            render ==> html.callback ("oncontextmenu", callback)

        [<CustomOperation("oncontextmenu")>]
        member inline _.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
            render ==> html.callbackTask ("oncontextmenu", callback)

        [<CustomOperation("oncontextmenu")>]
        member inline _.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("oncontextmenu", callback)


        [<CustomOperation("ondrag")>]
        member inline _.ondrag([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            render ==> html.callback ("ondrag", callback)

        [<CustomOperation("ondrag")>]
        member inline _.ondrag([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            render ==> html.callbackTask ("ondrag", callback)

        [<CustomOperation("ondrag")>]
        member inline _.ondrag([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondrag", callback)


        [<CustomOperation("ondragend")>]
        member inline _.ondragend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            render ==> html.callback ("ondragend", callback)

        [<CustomOperation("ondragend")>]
        member inline _.ondragend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            render ==> html.callbackTask ("ondragend", callback)

        [<CustomOperation("ondragend")>]
        member inline _.ondragend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondragend", callback)


        [<CustomOperation("ondragenter")>]
        member inline _.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            render ==> html.callback ("ondragenter", callback)

        [<CustomOperation("ondragenter")>]
        member inline _.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            render ==> html.callbackTask ("ondragenter", callback)

        [<CustomOperation("ondragenter")>]
        member inline _.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondragenter", callback)


        [<CustomOperation("ondragleave")>]
        member inline _.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            render ==> html.callback ("ondragleave", callback)

        [<CustomOperation("ondragleave")>]
        member inline _.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            render ==> html.callbackTask ("ondragleave", callback)

        [<CustomOperation("ondragleave")>]
        member inline _.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondragleave", callback)


        [<CustomOperation("ondragover")>]
        member inline _.ondragover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            render ==> html.callback ("ondragover", callback)

        [<CustomOperation("ondragover")>]
        member inline _.ondragover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            render ==> html.callbackTask ("ondragover", callback)

        [<CustomOperation("ondragover")>]
        member inline _.ondragover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondragover", callback)


        [<CustomOperation("ondragstart")>]
        member inline _.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            render ==> html.callback ("ondragstart", callback)

        [<CustomOperation("ondragstart")>]
        member inline _.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            render ==> html.callbackTask ("ondragstart", callback)

        [<CustomOperation("ondragstart")>]
        member inline _.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondragstart", callback)


        [<CustomOperation("ondrop")>]
        member inline _.ondrop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
            render ==> html.callback ("ondrop", callback)

        [<CustomOperation("ondrop")>]
        member inline _.ondrop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
            render ==> html.callbackTask ("ondrop", callback)

        [<CustomOperation("ondrop")>]
        member inline _.ondrop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondrop", callback)


        [<CustomOperation("onkeydown")>]
        member inline _.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
            render ==> html.callback ("onkeydown", callback)

        [<CustomOperation("onkeydown")>]
        member inline _.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
            render ==> html.callbackTask ("onkeydown", callback)

        [<CustomOperation("onkeydown")>]
        member inline _.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onkeydown", callback)


        [<CustomOperation("onkeyup")>]
        member inline _.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
            render ==> html.callback ("onkeyup", callback)

        [<CustomOperation("onkeyup")>]
        member inline _.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
            render ==> html.callbackTask ("onkeyup", callback)

        [<CustomOperation("onkeyup")>]
        member inline _.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onkeyup", callback)


        [<CustomOperation("onkeypress")>]
        member inline _.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
            render ==> html.callback ("onkeypress", callback)

        [<CustomOperation("onkeypress")>]
        member inline _.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
            render ==> html.callbackTask ("onkeypress", callback)

        [<CustomOperation("onkeypress")>]
        member inline _.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onkeypress", callback)


        [<CustomOperation("onchange")>]
        member inline _.onchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> unit) =
            render ==> html.callback ("onchange", callback)

        [<CustomOperation("onchange")>]
        member inline _.onchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task) =
            render ==> html.callbackTask ("onchange", callback)

        [<CustomOperation("onchange")>]
        member inline _.onchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onchange", callback)


        [<CustomOperation("oninput")>]
        member inline _.oninput([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> unit) =
            render ==> html.callback ("oninput", callback)

        [<CustomOperation("oninput")>]
        member inline _.oninput([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task) =
            render ==> html.callbackTask ("oninput", callback)

        [<CustomOperation("oninput")>]
        member inline _.oninput([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("oninput", callback)


        [<CustomOperation("oninvalid")>]
        member inline _.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("oninvalid", callback)

        [<CustomOperation("oninvalid")>]
        member inline _.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("oninvalid", callback)

        [<CustomOperation("oninvalid")>]
        member inline _.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("oninvalid", callback)


        [<CustomOperation("onreset")>]
        member inline _.onreset([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onreset", callback)

        [<CustomOperation("onreset")>]
        member inline _.onreset([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onreset", callback)

        [<CustomOperation("onreset")>]
        member inline _.onreset([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onreset", callback)


        [<CustomOperation("onselect")>]
        member inline _.onselect([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onselect", callback)

        [<CustomOperation("onselect")>]
        member inline _.onselect([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onselect", callback)

        [<CustomOperation("onselect")>]
        member inline _.onselect([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onselect", callback)


        [<CustomOperation("onselectstart")>]
        member inline _.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onselectstart", callback)

        [<CustomOperation("onselectstart")>]
        member inline _.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onselectstart", callback)

        [<CustomOperation("onselectstart")>]
        member inline _.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onselectstart", callback)


        [<CustomOperation("onselectionchange")>]
        member inline _.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onselectionchange", callback)

        [<CustomOperation("onselectionchange")>]
        member inline _.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onselectionchange", callback)

        [<CustomOperation("onselectionchange")>]
        member inline _.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onselectionchange", callback)


        [<CustomOperation("onsubmit")>]
        member inline _.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onsubmit", callback)

        [<CustomOperation("onsubmit")>]
        member inline _.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onsubmit", callback)

        [<CustomOperation("onsubmit")>]
        member inline _.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onsubmit", callback)


        [<CustomOperation("onbeforecopy")>]
        member inline _.onbeforecopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onbeforecopy", callback)

        [<CustomOperation("onbeforecopy")>]
        member inline _.onbeforecopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onbeforecopy", callback)

        [<CustomOperation("onbeforecopy")>]
        member inline _.onbeforecopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onbeforecopy", callback)


        [<CustomOperation("onbeforecut")>]
        member inline _.onbeforecut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onbeforecut", callback)

        [<CustomOperation("onbeforecut")>]
        member inline _.onbeforecut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onbeforecut", callback)

        [<CustomOperation("onbeforecut")>]
        member inline _.onbeforecut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onbeforecut", callback)


        [<CustomOperation("onbeforepaste")>]
        member inline _.onbeforepaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onbeforepaste", callback)

        [<CustomOperation("onbeforepaste")>]
        member inline _.onbeforepaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onbeforepaste", callback)

        [<CustomOperation("onbeforepaste")>]
        member inline _.onbeforepaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onbeforepaste", callback)


        [<CustomOperation("oncopy")>]
        member inline _.oncopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
            render ==> html.callback ("oncopy", callback)

        [<CustomOperation("oncopy")>]
        member inline _.oncopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
            render ==> html.callbackTask ("oncopy", callback)

        [<CustomOperation("oncopy")>]
        member inline _.oncopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("oncopy", callback)


        [<CustomOperation("oncut")>]
        member inline _.oncut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
            render ==> html.callback ("oncut", callback)

        [<CustomOperation("oncut")>]
        member inline _.oncut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
            render ==> html.callbackTask ("oncut", callback)

        [<CustomOperation("oncut")>]
        member inline _.oncut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("oncut", callback)


        [<CustomOperation("onpaste")>]
        member inline _.onpaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
            render ==> html.callback ("onpaste", callback)

        [<CustomOperation("onpaste")>]
        member inline _.onpaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
            render ==> html.callbackTask ("onpaste", callback)

        [<CustomOperation("onpaste")>]
        member inline _.onpaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onpaste", callback)


        [<CustomOperation("ontouchcancel")>]
        member inline _.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            render ==> html.callback ("ontouchcancel", callback)

        [<CustomOperation("ontouchcancel")>]
        member inline _.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            render ==> html.callbackTask ("ontouchcancel", callback)

        [<CustomOperation("ontouchcancel")>]
        member inline _.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ontouchcancel", callback)


        [<CustomOperation("ontouchend")>]
        member inline _.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            render ==> html.callback ("ontouchend", callback)

        [<CustomOperation("ontouchend")>]
        member inline _.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            render ==> html.callbackTask ("ontouchend", callback)

        [<CustomOperation("ontouchend")>]
        member inline _.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ontouchend", callback)


        [<CustomOperation("ontouchmove")>]
        member inline _.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            render ==> html.callback ("ontouchmove", callback)

        [<CustomOperation("ontouchmove")>]
        member inline _.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            render ==> html.callbackTask ("ontouchmove", callback)

        [<CustomOperation("ontouchmove")>]
        member inline _.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ontouchmove", callback)


        [<CustomOperation("ontouchstart")>]
        member inline _.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            render ==> html.callback ("ontouchstart", callback)

        [<CustomOperation("ontouchstart")>]
        member inline _.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            render ==> html.callbackTask ("ontouchstart", callback)

        [<CustomOperation("ontouchstart")>]
        member inline _.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ontouchstart", callback)


        [<CustomOperation("ontouchenter")>]
        member inline _.ontouchenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            render ==> html.callback ("ontouchenter", callback)

        [<CustomOperation("ontouchenter")>]
        member inline _.ontouchenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            render ==> html.callbackTask ("ontouchenter", callback)

        [<CustomOperation("ontouchenter")>]
        member inline _.ontouchenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ontouchenter", callback)


        [<CustomOperation("ontouchleave")>]
        member inline _.ontouchleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
            render ==> html.callback ("ontouchleave", callback)

        [<CustomOperation("ontouchleave")>]
        member inline _.ontouchleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
            render ==> html.callbackTask ("ontouchleave", callback)

        [<CustomOperation("ontouchleave")>]
        member inline _.ontouchleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ontouchleave", callback)


        [<CustomOperation("onpointercapture")>]
        member inline _.onpointercapture([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointercapture", callback)

        [<CustomOperation("onpointercapture")>]
        member inline _.onpointercapture([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointercapture", callback)

        [<CustomOperation("onpointercapture")>]
        member inline _.onpointercapture

            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            render ==> html.callbackTask ("onpointercapture", callback)

        [<CustomOperation("onlostpointercapture")>]
        member inline _.onlostpointercapture

            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> unit
            )
            =
            render ==> html.callback ("onlostpointercapture", callback)
        [<CustomOperation("onlostpointercapture")>]
        member inline _.onlostpointercapture

            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task
            )
            =
            render ==> html.callbackTask ("onlostpointercapture", callback)
        [<CustomOperation("onlostpointercapture")>]
        member inline _.onlostpointercapture

            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            render ==> html.callbackTask ("onlostpointercapture", callback)

        [<CustomOperation("onpointercancel")>]
        member inline _.onpointercancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointercancel", callback)

        [<CustomOperation("onpointercancel")>]
        member inline _.onpointercancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointercancel", callback)

        [<CustomOperation("onpointercancel")>]
        member inline _.onpointercancel

            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            render ==> html.callbackTask ("onpointercancel", callback)

        [<CustomOperation("onpointerdown")>]
        member inline _.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointerdown", callback)

        [<CustomOperation("onpointerdown")>]
        member inline _.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointerdown", callback)

        [<CustomOperation("onpointerdown")>]
        member inline _.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onpointerdown", callback)


        [<CustomOperation("onpointerenter")>]
        member inline _.onpointerenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointerenter", callback)

        [<CustomOperation("onpointerenter")>]
        member inline _.onpointerenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointerenter", callback)

        [<CustomOperation("onpointerenter")>]
        member inline _.onpointerenter

            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            render ==> html.callbackTask ("onpointerenter", callback)

        [<CustomOperation("onpointerleave")>]
        member inline _.onpointerleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointerleave", callback)

        [<CustomOperation("onpointerleave")>]
        member inline _.onpointerleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointerleave", callback)

        [<CustomOperation("onpointerleave")>]
        member inline _.onpointerleave

            (
                [<InlineIfLambda>] render: AttrRenderFragment,
                [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>
            )
            =
            render ==> html.callbackTask ("onpointerleave", callback)

        [<CustomOperation("onpointermove")>]
        member inline _.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointermove", callback)

        [<CustomOperation("onpointermove")>]
        member inline _.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointermove", callback)

        [<CustomOperation("onpointermove")>]
        member inline _.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onpointermove", callback)


        [<CustomOperation("onpointerout")>]
        member inline _.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointerout", callback)

        [<CustomOperation("onpointerout")>]
        member inline _.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointerout", callback)

        [<CustomOperation("onpointerout")>]
        member inline _.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onpointerout", callback)


        [<CustomOperation("onpointerover")>]
        member inline _.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointerover", callback)

        [<CustomOperation("onpointerover")>]
        member inline _.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointerover", callback)

        [<CustomOperation("onpointerover")>]
        member inline _.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onpointerover", callback)


        [<CustomOperation("onpointerup")>]
        member inline _.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
            render ==> html.callback ("onpointerup", callback)

        [<CustomOperation("onpointerup")>]
        member inline _.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
            render ==> html.callbackTask ("onpointerup", callback)

        [<CustomOperation("onpointerup")>]
        member inline _.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onpointerup", callback)


        [<CustomOperation("oncanplay")>]
        member inline _.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("oncanplay", callback)

        [<CustomOperation("oncanplay")>]
        member inline _.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("oncanplay", callback)

        [<CustomOperation("oncanplay")>]
        member inline _.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("oncanplay", callback)


        [<CustomOperation("oncanplaythrough")>]
        member inline _.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("oncanplaythrough", callback)

        [<CustomOperation("oncanplaythrough")>]
        member inline _.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("oncanplaythrough", callback)

        [<CustomOperation("oncanplaythrough")>]
        member inline _.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("oncanplaythrough", callback)


        [<CustomOperation("oncuechange")>]
        member inline _.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("oncuechange", callback)

        [<CustomOperation("oncuechange")>]
        member inline _.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("oncuechange", callback)

        [<CustomOperation("oncuechange")>]
        member inline _.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("oncuechange", callback)


        [<CustomOperation("ondurationchange")>]
        member inline _.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("ondurationchange", callback)

        [<CustomOperation("ondurationchange")>]
        member inline _.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("ondurationchange", callback)

        [<CustomOperation("ondurationchange")>]
        member inline _.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondurationchange", callback)


        [<CustomOperation("onemptied")>]
        member inline _.onemptied([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onemptied", callback)

        [<CustomOperation("onemptied")>]
        member inline _.onemptied([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onemptied", callback)

        [<CustomOperation("onemptied")>]
        member inline _.onemptied([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onemptied", callback)


        [<CustomOperation("onpause")>]
        member inline _.onpause([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onpause", callback)

        [<CustomOperation("onpause")>]
        member inline _.onpause([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onpause", callback)

        [<CustomOperation("onpause")>]
        member inline _.onpause([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onpause", callback)


        [<CustomOperation("onplay")>]
        member inline _.onplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onplay", callback)

        [<CustomOperation("onplay")>]
        member inline _.onplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onplay", callback)

        [<CustomOperation("onplay")>]
        member inline _.onplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onplay", callback)


        [<CustomOperation("onplaying")>]
        member inline _.onplaying([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onplaying", callback)

        [<CustomOperation("onplaying")>]
        member inline _.onplaying([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onplaying", callback)

        [<CustomOperation("onplaying")>]
        member inline _.onplaying([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onplaying", callback)


        [<CustomOperation("onratechange")>]
        member inline _.onratechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onratechange", callback)

        [<CustomOperation("onratechange")>]
        member inline _.onratechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onratechange", callback)

        [<CustomOperation("onratechange")>]
        member inline _.onratechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onratechange", callback)


        [<CustomOperation("onseeked")>]
        member inline _.onseeked([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onseeked", callback)

        [<CustomOperation("onseeked")>]
        member inline _.onseeked([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onseeked", callback)

        [<CustomOperation("onseeked")>]
        member inline _.onseeked([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onseeked", callback)


        [<CustomOperation("onseeking")>]
        member inline _.onseeking([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onseeking", callback)

        [<CustomOperation("onseeking")>]
        member inline _.onseeking([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onseeking", callback)

        [<CustomOperation("onseeking")>]
        member inline _.onseeking([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onseeking", callback)


        [<CustomOperation("onstalled")>]
        member inline _.onstalled([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onstalled", callback)

        [<CustomOperation("onstalled")>]
        member inline _.onstalled([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onstalled", callback)

        [<CustomOperation("onstalled")>]
        member inline _.onstalled([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onstalled", callback)


        [<CustomOperation("onstop")>]
        member inline _.onstop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onstop", callback)

        [<CustomOperation("onstop")>]
        member inline _.onstop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onstop", callback)

        [<CustomOperation("onstop")>]
        member inline _.onstop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onstop", callback)


        [<CustomOperation("onsuspend")>]
        member inline _.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onsuspend", callback)

        [<CustomOperation("onsuspend")>]
        member inline _.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onsuspend", callback)

        [<CustomOperation("onsuspend")>]
        member inline _.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onsuspend", callback)


        [<CustomOperation("ontimeupdate")>]
        member inline _.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("ontimeupdate", callback)

        [<CustomOperation("ontimeupdate")>]
        member inline _.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("ontimeupdate", callback)

        [<CustomOperation("ontimeupdate")>]
        member inline _.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ontimeupdate", callback)


        [<CustomOperation("onvolumechange")>]
        member inline _.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onvolumechange", callback)

        [<CustomOperation("onvolumechange")>]
        member inline _.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onvolumechange", callback)

        [<CustomOperation("onvolumechange")>]
        member inline _.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onvolumechange", callback)


        [<CustomOperation("onwaiting")>]
        member inline _.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onwaiting", callback)

        [<CustomOperation("onwaiting")>]
        member inline _.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onwaiting", callback)

        [<CustomOperation("onwaiting")>]
        member inline _.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onwaiting", callback)


        [<CustomOperation("onloadstart")>]
        member inline _.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            render ==> html.callback ("onloadstart", callback)

        [<CustomOperation("onloadstart")>]
        member inline _.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            render ==> html.callbackTask ("onloadstart", callback)

        [<CustomOperation("onloadstart")>]
        member inline _.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onloadstart", callback)


        [<CustomOperation("ontimeout")>]
        member inline _.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            render ==> html.callback ("ontimeout", callback)

        [<CustomOperation("ontimeout")>]
        member inline _.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            render ==> html.callbackTask ("ontimeout", callback)

        [<CustomOperation("ontimeout")>]
        member inline _.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ontimeout", callback)


        [<CustomOperation("onabort")>]
        member inline _.onabort([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            render ==> html.callback ("onabort", callback)

        [<CustomOperation("onabort")>]
        member inline _.onabort([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            render ==> html.callbackTask ("onabort", callback)

        [<CustomOperation("onabort")>]
        member inline _.onabort([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onabort", callback)


        [<CustomOperation("onload")>]
        member inline _.onload([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            render ==> html.callback ("onload", callback)

        [<CustomOperation("onload")>]
        member inline _.onload([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            render ==> html.callbackTask ("onload", callback)

        [<CustomOperation("onload")>]
        member inline _.onload([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onload", callback)


        [<CustomOperation("onloadend")>]
        member inline _.onloadend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            render ==> html.callback ("onloadend", callback)

        [<CustomOperation("onloadend")>]
        member inline _.onloadend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            render ==> html.callbackTask ("onloadend", callback)

        [<CustomOperation("onloadend")>]
        member inline _.onloadend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onloadend", callback)


        [<CustomOperation("onprogress")>]
        member inline _.onprogress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
            render ==> html.callback ("onprogress", callback)

        [<CustomOperation("onprogress")>]
        member inline _.onprogress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
            render ==> html.callbackTask ("onprogress", callback)

        [<CustomOperation("onprogress")>]
        member inline _.onprogress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onprogress", callback)


        [<CustomOperation("onerror")>]
        member inline _.onerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ErrorEventArgs -> unit) =
            render ==> html.callback ("onerror", callback)

        [<CustomOperation("onerror")>]
        member inline _.onerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ErrorEventArgs -> Task) =
            render ==> html.callbackTask ("onerror", callback)

        [<CustomOperation("onerror")>]
        member inline _.onerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ErrorEventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onerror", callback)


        [<CustomOperation("onactivate")>]
        member inline _.onactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onactivate", callback)

        [<CustomOperation("onactivate")>]
        member inline _.onactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onactivate", callback)

        [<CustomOperation("onactivate")>]
        member inline _.onactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onactivate", callback)


        [<CustomOperation("onbeforeactivate")>]
        member inline _.onbeforeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onbeforeactivate", callback)

        [<CustomOperation("onbeforeactivate")>]
        member inline _.onbeforeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onbeforeactivate", callback)

        [<CustomOperation("onbeforeactivate")>]
        member inline _.onbeforeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onbeforeactivate", callback)


        [<CustomOperation("onbeforedeactivate")>]
        member inline _.onbeforedeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onbeforedeactivate", callback)

        [<CustomOperation("onbeforedeactivate")>]
        member inline _.onbeforedeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onbeforedeactivate", callback)

        [<CustomOperation("onbeforedeactivate")>]
        member inline _.onbeforedeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =

            render ==> html.callbackTask ("onbeforedeactivate", callback)

        [<CustomOperation("ondeactivate")>]
        member inline _.ondeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("ondeactivate", callback)

        [<CustomOperation("ondeactivate")>]
        member inline _.ondeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("ondeactivate", callback)

        [<CustomOperation("ondeactivate")>]
        member inline _.ondeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("ondeactivate", callback)


        [<CustomOperation("onended")>]
        member inline _.onended([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onended", callback)

        [<CustomOperation("onended")>]
        member inline _.onended([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onended", callback)

        [<CustomOperation("onended")>]
        member inline _.onended([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onended", callback)


        [<CustomOperation("onfullscreenchange")>]
        member inline _.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onfullscreenchange", callback)

        [<CustomOperation("onfullscreenchange")>]
        member inline _.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onfullscreenchange", callback)

        [<CustomOperation("onfullscreenchange")>]
        member inline _.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =

            render ==> html.callbackTask ("onfullscreenchange", callback)

        [<CustomOperation("onfullscreenerror")>]
        member inline _.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onfullscreenerror", callback)

        [<CustomOperation("onfullscreenerror")>]
        member inline _.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onfullscreenerror", callback)

        [<CustomOperation("onfullscreenerror")>]
        member inline _.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onfullscreenerror", callback)


        [<CustomOperation("onloadeddata")>]
        member inline _.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onloadeddata", callback)

        [<CustomOperation("onloadeddata")>]
        member inline _.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onloadeddata", callback)

        [<CustomOperation("onloadeddata")>]
        member inline _.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onloadeddata", callback)


        [<CustomOperation("onloadedmetadata")>]
        member inline _.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onloadedmetadata", callback)

        [<CustomOperation("onloadedmetadata")>]
        member inline _.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onloadedmetadata", callback)

        [<CustomOperation("onloadedmetadata")>]
        member inline _.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onloadedmetadata", callback)


        [<CustomOperation("onpointerlockchange")>]
        member inline _.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onpointerlockchange", callback)

        [<CustomOperation("onpointerlockchange")>]
        member inline _.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onpointerlockchange", callback)

        [<CustomOperation("onpointerlockchange")>]
        member inline _.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =

            render ==> html.callbackTask ("onpointerlockchange", callback)

        [<CustomOperation("onpointerlockerror")>]
        member inline _.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onpointerlockerror", callback)

        [<CustomOperation("onpointerlockerror")>]
        member inline _.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onpointerlockerror", callback)

        [<CustomOperation("onpointerlockerror")>]
        member inline _.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =

            render ==> html.callbackTask ("onpointerlockerror", callback)

        [<CustomOperation("onreadystatechange")>]
        member inline _.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onreadystatechange", callback)

        [<CustomOperation("onreadystatechange")>]
        member inline _.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onreadystatechange", callback)

        [<CustomOperation("onreadystatechange")>]
        member inline _.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =

            render ==> html.callbackTask ("onreadystatechange", callback)

        [<CustomOperation("onscroll")>]
        member inline _.onscroll([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
            render ==> html.callback ("onscroll", callback)

        [<CustomOperation("onscroll")>]
        member inline _.onscroll([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
            render ==> html.callbackTask ("onscroll", callback)

        [<CustomOperation("onscroll")>]
        member inline _.onscroll([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task<unit>) =
            render ==> html.callbackTask ("onscroll", callback)



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


        [<CustomOperation("onopen'")>]
        member inline _.onopen'([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onopen" => js)


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


        [<CustomOperation("onend'")>]
        member inline _.onend'([<InlineIfLambda>] render: AttrRenderFragment, js: string) = render ==> ("onend" => js)


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


    [<Obsolete "Please use onxxx directly, this will be removed in the future">]
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
