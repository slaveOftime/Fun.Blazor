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
