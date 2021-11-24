namespace rec Blazor.DragDrop.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open Blazor.DragDrop.DslInternals


type DropzoneBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = DropzoneBuilder<'FunBlazorGeneric, 'TItem>().CreateNode()
    [<CustomOperation("Accepts")>] member this.Accepts (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "Accepts" => (System.Func<'TItem, 'TItem, System.Boolean>fn) |> this.AddAttr
    [<CustomOperation("AllowsDrag")>] member this.AllowsDrag (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "AllowsDrag" => (System.Func<'TItem, System.Boolean>fn) |> this.AddAttr
    [<CustomOperation("DragEnd")>] member this.DragEnd (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "DragEnd" => (System.Action<'TItem>fn) |> this.AddAttr
    [<CustomOperation("OnItemDropRejected")>] member this.OnItemDropRejected (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TItem> "OnItemDropRejected" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnItemDrop")>] member this.OnItemDrop (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TItem> "OnItemDrop" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnReplacedItemDrop")>] member this.OnReplacedItemDrop (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TItem> "OnReplacedItemDrop" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("InstantReplace")>] member this.InstantReplace (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "InstantReplace" => x |> this.AddAttr
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IList<'TItem>) = "Items" => x |> this.AddAttr
    [<CustomOperation("MaxItems")>] member this.MaxItems (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxItems" => x |> this.AddAttr
    [<CustomOperation("OnItemDropRejectedByMaxItemLimit")>] member this.OnItemDropRejectedByMaxItemLimit (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TItem> "OnItemDropRejectedByMaxItemLimit" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddAttr
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Id" => x |> this.AddAttr
    [<CustomOperation("ItemWrapperClass")>] member this.ItemWrapperClass (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "ItemWrapperClass" => (System.Func<'TItem, System.String>fn) |> this.AddAttr
    [<CustomOperation("CopyItem")>] member this.CopyItem (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "CopyItem" => (System.Func<'TItem, 'TItem>fn) |> this.AddAttr
                
            

// =======================================================================================================================

namespace Blazor.DragDrop

[<AutoOpen>]
module DslCE =

    open Blazor.DragDrop.DslInternals

    type Dropzone'<'TItem>() = inherit DropzoneBuilder<Plk.Blazor.DragDrop.Dropzone<'TItem>, 'TItem>()
            