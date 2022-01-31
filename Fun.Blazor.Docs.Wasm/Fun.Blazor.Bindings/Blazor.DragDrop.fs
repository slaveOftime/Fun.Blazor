namespace rec Blazor.DragDrop.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Blazor.DragDrop.DslInternals


type DropzoneBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    static member inline create () = DropzoneBuilder<'FunBlazorGeneric, 'TItem>()
    [<CustomOperation("Accepts")>] member inline _.Accepts (render: AttrRenderFragment, fn) = render ==> ("Accepts" => (System.Func<'TItem, 'TItem, System.Boolean>fn))
    [<CustomOperation("AllowsDrag")>] member inline _.AllowsDrag (render: AttrRenderFragment, fn) = render ==> ("AllowsDrag" => (System.Func<'TItem, System.Boolean>fn))
    [<CustomOperation("DragEnd")>] member inline _.DragEnd (render: AttrRenderFragment, fn) = render ==> ("DragEnd" => (System.Action<'TItem>fn))
    [<CustomOperation("OnItemDropRejected")>] member inline _.OnItemDropRejected (render: AttrRenderFragment, fn) = render ==> html.callback<'TItem>("OnItemDropRejected", fn)
    [<CustomOperation("OnItemDrop")>] member inline _.OnItemDrop (render: AttrRenderFragment, fn) = render ==> html.callback<'TItem>("OnItemDrop", fn)
    [<CustomOperation("OnReplacedItemDrop")>] member inline _.OnReplacedItemDrop (render: AttrRenderFragment, fn) = render ==> html.callback<'TItem>("OnReplacedItemDrop", fn)
    [<CustomOperation("InstantReplace")>] member inline _.InstantReplace (render: AttrRenderFragment, x: System.Boolean) = render ==> ("InstantReplace" => x)
    [<CustomOperation("Items")>] member inline _.Items (render: AttrRenderFragment, x: System.Collections.Generic.IList<'TItem>) = render ==> ("Items" => x)
    [<CustomOperation("MaxItems")>] member inline _.MaxItems (render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxItems" => x)
    [<CustomOperation("OnItemDropRejectedByMaxItemLimit")>] member inline _.OnItemDropRejectedByMaxItemLimit (render: AttrRenderFragment, fn) = render ==> html.callback<'TItem>("OnItemDropRejectedByMaxItemLimit", fn)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent (render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("Classes")>] member inline _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Id")>] member inline _.Id (render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    [<CustomOperation("ItemWrapperClass")>] member inline _.ItemWrapperClass (render: AttrRenderFragment, fn) = render ==> ("ItemWrapperClass" => (System.Func<'TItem, System.String>fn))
    [<CustomOperation("CopyItem")>] member inline _.CopyItem (render: AttrRenderFragment, fn) = render ==> ("CopyItem" => (System.Func<'TItem, 'TItem>fn))
                
            

// =======================================================================================================================

namespace Blazor.DragDrop

[<AutoOpen>]
module DslCE =

    open Blazor.DragDrop.DslInternals

    type Dropzone'<'TItem>() = inherit DropzoneBuilder<Plk.Blazor.DragDrop.Dropzone<'TItem>, 'TItem>()
            