namespace rec Blazor.DragDrop.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Blazor.DragDrop.DslInternals


type DropzoneBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(DropzoneBuilder<'FunBlazorGeneric, 'TItem>())
    [<CustomOperation("Accepts")>] member _.Accepts (render: AttrRenderFragment, fn) = render ==> ("Accepts" => (System.Func<'TItem, 'TItem, System.Boolean>fn))
    [<CustomOperation("AllowsDrag")>] member _.AllowsDrag (render: AttrRenderFragment, fn) = render ==> ("AllowsDrag" => (System.Func<'TItem, System.Boolean>fn))
    [<CustomOperation("DragEnd")>] member _.DragEnd (render: AttrRenderFragment, fn) = render ==> ("DragEnd" => (System.Action<'TItem>fn))
    [<CustomOperation("OnItemDropRejected")>] member _.OnItemDropRejected (render: AttrRenderFragment, fn) = render ==> html.callback<'TItem>("OnItemDropRejected", fn)
    [<CustomOperation("OnItemDrop")>] member _.OnItemDrop (render: AttrRenderFragment, fn) = render ==> html.callback<'TItem>("OnItemDrop", fn)
    [<CustomOperation("OnReplacedItemDrop")>] member _.OnReplacedItemDrop (render: AttrRenderFragment, fn) = render ==> html.callback<'TItem>("OnReplacedItemDrop", fn)
    [<CustomOperation("InstantReplace")>] member _.InstantReplace (render: AttrRenderFragment, x: System.Boolean) = render ==> ("InstantReplace" => x)
    [<CustomOperation("Items")>] member _.Items (render: AttrRenderFragment, x: System.Collections.Generic.IList<'TItem>) = render ==> ("Items" => x)
    [<CustomOperation("MaxItems")>] member _.MaxItems (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxItems" => x)
    [<CustomOperation("OnItemDropRejectedByMaxItemLimit")>] member _.OnItemDropRejectedByMaxItemLimit (render: AttrRenderFragment, fn) = render ==> html.callback<'TItem>("OnItemDropRejectedByMaxItemLimit", fn)
    [<CustomOperation("ChildContent")>] member _.ChildContent (render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("Classes")>] member _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Id")>] member _.Id (render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    [<CustomOperation("ItemWrapperClass")>] member _.ItemWrapperClass (render: AttrRenderFragment, fn) = render ==> ("ItemWrapperClass" => (System.Func<'TItem, System.String>fn))
    [<CustomOperation("CopyItem")>] member _.CopyItem (render: AttrRenderFragment, fn) = render ==> ("CopyItem" => (System.Func<'TItem, 'TItem>fn))
                
            

// =======================================================================================================================

namespace Blazor.DragDrop

[<AutoOpen>]
module DslCE =

    open Blazor.DragDrop.DslInternals

    type Dropzone'<'TItem>() = inherit DropzoneBuilder<Plk.Blazor.DragDrop.Dropzone<'TItem>, 'TItem>()
            