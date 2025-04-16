namespace rec Radzen.Blazor.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// Base class of Radzen Blazor components.
///             
type RadzenComponentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Specifies additional custom attributes that will be rendered by the component.
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    /// A callback that will be invoked when the user hovers the component. Commonly used to display a tooltip via 
    /// Open.
    [<CustomOperation("MouseEnter")>] member inline _.MouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.ElementReference -> unit) = render ==> html.callback("MouseEnter", fn)
    /// A callback that will be invoked when the user hovers the component. Commonly used to display a tooltip via 
    /// Open.
    [<CustomOperation("MouseEnter")>] member inline _.MouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.ElementReference -> Task<unit>) = render ==> html.callbackTask("MouseEnter", fn)
    /// A callback that will be invoked when the user moves the mouse out of the component. Commonly used to hide a tooltip via 
    /// Close.
    [<CustomOperation("MouseLeave")>] member inline _.MouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.ElementReference -> unit) = render ==> html.callback("MouseLeave", fn)
    /// A callback that will be invoked when the user moves the mouse out of the component. Commonly used to hide a tooltip via 
    /// Close.
    [<CustomOperation("MouseLeave")>] member inline _.MouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.ElementReference -> Task<unit>) = render ==> html.callbackTask("MouseLeave", fn)
    /// A callback that will be invoked when the user right-clicks the component. Commonly used to display a context menu via 
    /// Open.
    [<CustomOperation("ContextMenu")>] member inline _.ContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("ContextMenu", fn)
    /// A callback that will be invoked when the user right-clicks the component. Commonly used to display a context menu via 
    /// Open.
    [<CustomOperation("ContextMenu")>] member inline _.ContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("ContextMenu", fn)
    /// Gets or sets the culture used to display localizable data (numbers, dates). Set by default to CurrentCulture.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// Gets or sets a value indicating whether this RadzenComponent is visible. Invisible components are not rendered.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenComponent is visible. Invisible components are not rendered.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

/// A base class of components that have child content.
type RadzenComponentWithChildrenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()


/// A base class of row/col components.
type RadzenFlexComponentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the content justify.
    [<CustomOperation("JustifyContent")>] member inline _.JustifyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.JustifyContent) = render ==> ("JustifyContent" => x)
    /// Gets or sets the items alignment.
    [<CustomOperation("AlignItems")>] member inline _.AlignItems ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.AlignItems) = render ==> ("AlignItems" => x)

            
namespace rec Radzen.Blazor.DslInternals.Blazor

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// RadzenCard component.
type RadzenRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenFlexComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the gap.
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)
    /// Gets or sets the row gap.
    [<CustomOperation("RowGap")>] member inline _.RowGap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowGap" => x)

/// RadzenStack component.
type RadzenStackBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenFlexComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the wrap.
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FlexWrap) = render ==> ("Wrap" => x)
    /// Gets or sets the orientation.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the spacing
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)
    /// Gets or sets the reverse
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Reverse" =>>> true)
    /// Gets or sets the reverse
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Reverse" =>>> x)

/// RadzenAlert component.
type RadzenAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether close is allowed. Set to true by default.
    [<CustomOperation("AllowClose")>] member inline _.AllowClose ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowClose" =>>> true)
    /// Gets or sets a value indicating whether close is allowed. Set to true by default.
    [<CustomOperation("AllowClose")>] member inline _.AllowClose ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowClose" =>>> x)
    /// Gets or sets a value indicating whether icon should be shown. Set to true by default.
    [<CustomOperation("ShowIcon")>] member inline _.ShowIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowIcon" =>>> true)
    /// Gets or sets a value indicating whether icon should be shown. Set to true by default.
    [<CustomOperation("ShowIcon")>] member inline _.ShowIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowIcon" =>>> x)
    /// Gets or sets the title.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the text of the alert. Overriden by ChildContent.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the severity.
    [<CustomOperation("AlertStyle")>] member inline _.AlertStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.AlertStyle) = render ==> ("AlertStyle" => x)
    /// Gets or sets the design variant of the alert.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("Variant" => x)
    /// Gets or sets the color shade of the alert.
    [<CustomOperation("Shade")>] member inline _.Shade ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Shade) = render ==> ("Shade" => x)
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.AlertSize) = render ==> ("Size" => x)
    /// Gets or sets the callback which is invoked when the alert is shown or hidden.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    /// Gets or sets the callback which is invoked when the alert is shown or hidden.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)
    /// Gets or sets the callback which is invoked when the alert is closed by the user.
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Close", fn)
    /// Gets or sets the callback which is invoked when the alert is closed by the user.
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Close", fn)

/// RadzenBody component.
type RadzenBodyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether this RadzenBody is expanded.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Gets or sets a value indicating whether this RadzenBody is expanded.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Gets or sets a value indicating whether this RadzenBody is expanded.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Gets or sets a callback raised when the component is expanded or collapsed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Gets or sets a callback raised when the component is expanded or collapsed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)

/// A component to display a Bread Crumb style menu
type RadzenBreadCrumbBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// An optional RenderFragment that is rendered per Item
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenBreadCrumbItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)

/// RadzenCard component.
type RadzenCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the card variant.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("Variant" => x)

/// RadzenCardGroup component.
type RadzenCardGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Toggles the responsive mode of the component. If set to true (the default) the component will be 
    /// expanded on larger displays and collapsed on touch devices. Set to false if you want to disable this behavior.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Responsive" =>>> true)
    /// Toggles the responsive mode of the component. If set to true (the default) the component will be 
    /// expanded on larger displays and collapsed on touch devices. Set to false if you want to disable this behavior.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Responsive" =>>> x)

/// RadzenColumn component.
type RadzenColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Size" => x)
    /// Gets or sets the XS size.
    [<CustomOperation("SizeXS")>] member inline _.SizeXS ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("SizeXS" => x)
    /// Gets or sets the SM size.
    [<CustomOperation("SizeSM")>] member inline _.SizeSM ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("SizeSM" => x)
    /// Gets or sets the MD size.
    [<CustomOperation("SizeMD")>] member inline _.SizeMD ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("SizeMD" => x)
    /// Gets or sets the LG size.
    [<CustomOperation("SizeLG")>] member inline _.SizeLG ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("SizeLG" => x)
    /// Gets or sets the XL size.
    [<CustomOperation("SizeXL")>] member inline _.SizeXL ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("SizeXL" => x)
    /// Gets or sets the XX size.
    [<CustomOperation("SizeXX")>] member inline _.SizeXX ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("SizeXX" => x)
    /// Gets or sets the offset.
    [<CustomOperation("Offset")>] member inline _.Offset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Offset" => x)
    /// Gets or sets the XS offset.
    [<CustomOperation("OffsetXS")>] member inline _.OffsetXS ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OffsetXS" => x)
    /// Gets or sets the SM offset.
    [<CustomOperation("OffsetSM")>] member inline _.OffsetSM ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OffsetSM" => x)
    /// Gets or sets the MD offset.
    [<CustomOperation("OffsetMD")>] member inline _.OffsetMD ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OffsetMD" => x)
    /// Gets or sets the LG offset.
    [<CustomOperation("OffsetLG")>] member inline _.OffsetLG ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OffsetLG" => x)
    /// Gets or sets the XL offset.
    [<CustomOperation("OffsetXL")>] member inline _.OffsetXL ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OffsetXL" => x)
    /// Gets or sets the XX offset.
    [<CustomOperation("OffsetXX")>] member inline _.OffsetXX ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OffsetXX" => x)
    /// Gets or sets the order.
    [<CustomOperation("Order")>] member inline _.Order ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Order" => x)
    /// Gets or sets the XS order.
    [<CustomOperation("OrderXS")>] member inline _.OrderXS ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OrderXS" => x)
    /// Gets or sets the SM order.
    [<CustomOperation("OrderSM")>] member inline _.OrderSM ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OrderSM" => x)
    /// Gets or sets the MD order.
    [<CustomOperation("OrderMD")>] member inline _.OrderMD ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OrderMD" => x)
    /// Gets or sets the LG order.
    [<CustomOperation("OrderLG")>] member inline _.OrderLG ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OrderLG" => x)
    /// Gets or sets the XL order.
    [<CustomOperation("OrderXL")>] member inline _.OrderXL ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OrderXL" => x)
    /// Gets or sets the XX order.
    [<CustomOperation("OrderXX")>] member inline _.OrderXX ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OrderXX" => x)

/// RadzenContent component.
type RadzenContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the container.
    [<CustomOperation("Container")>] member inline _.Container ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Container" => x)

/// RadzenContentContainer component.
type RadzenContentContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the name.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)

/// RadzenDropZone component.
type RadzenDropZoneBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the zone value used to compare items in container Selector function.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Gets or sets the Footer Templated
    /// The Footer Template is rendered below the items in the RadzenDropZone`1
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Footer", fragment)
    /// Gets or sets the Footer Templated
    /// The Footer Template is rendered below the items in the RadzenDropZone`1
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Footer", fragment { yield! fragments })
    /// Gets or sets the Footer Templated
    /// The Footer Template is rendered below the items in the RadzenDropZone`1
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Footer", html.text x)
    /// Gets or sets the Footer Templated
    /// The Footer Template is rendered below the items in the RadzenDropZone`1
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Footer", html.text x)
    /// Gets or sets the Footer Templated
    /// The Footer Template is rendered below the items in the RadzenDropZone`1
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Footer", html.text x)

/// RadzenDropZoneContainer component.
type RadzenDropZoneContainerBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the data.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Data" => x)
    /// Gets or sets the selector function for zone items.
    [<CustomOperation("ItemSelector")>] member inline _.ItemSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemSelector" => (System.Func<'TItem, Radzen.Blazor.RadzenDropZone<'TItem>, System.Boolean>fn))
    /// Gets or sets the function that checks if the item can be dropped in specific zone or item.
    [<CustomOperation("CanDrop")>] member inline _.CanDrop ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CanDrop" => (System.Func<Radzen.RadzenDropZoneItemEventArgs<'TItem>, System.Boolean>fn))
    /// Gets or sets the row render callback. Use it to set row attributes.
    [<CustomOperation("ItemRender")>] member inline _.ItemRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemRender" => (System.Action<Radzen.RadzenDropZoneItemRenderEventArgs<'TItem>>fn))
    /// Gets or sets the template for zone items.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// The event callback raised on item drop.
    [<CustomOperation("Drop")>] member inline _.Drop ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.RadzenDropZoneItemEventArgs<'TItem> -> unit) = render ==> html.callback("Drop", fn)
    /// The event callback raised on item drop.
    [<CustomOperation("Drop")>] member inline _.Drop ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.RadzenDropZoneItemEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("Drop", fn)

/// RadzenFooter component.
type RadzenFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


/// RadzenHeader component.
type RadzenHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


/// RadzenImage component.
type RadzenImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the path.
    [<CustomOperation("Path")>] member inline _.Path ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Path" => x)
    /// Gets or sets the text.
    [<CustomOperation("AlternateText")>] member inline _.AlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AlternateText" => x)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("Click", fn)

/// RadzenLayout component.
type RadzenLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


/// RadzenMenu component.
type RadzenMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether this RadzenMenu is responsive.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Responsive" =>>> true)
    /// Gets or sets a value indicating whether this RadzenMenu is responsive.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Responsive" =>>> x)
    /// Gets or sets a value indicating whether this RadzenMenu should open item on click or on hover.
    [<CustomOperation("ClickToOpen")>] member inline _.ClickToOpen ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ClickToOpen" =>>> true)
    /// Gets or sets a value indicating whether this RadzenMenu should open item on click or on hover.
    [<CustomOperation("ClickToOpen")>] member inline _.ClickToOpen ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ClickToOpen" =>>> x)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.MenuItemEventArgs -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("Click", fn)
    /// Gets or sets the add button aria-label attribute.
    [<CustomOperation("ToggleAriaLabel")>] member inline _.ToggleAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggleAriaLabel" => x)

/// RadzenPanel component.
type RadzenPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether collapsing is allowed. Set to false by default.
    [<CustomOperation("AllowCollapse")>] member inline _.AllowCollapse ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowCollapse" =>>> true)
    /// Gets or sets a value indicating whether collapsing is allowed. Set to false by default.
    [<CustomOperation("AllowCollapse")>] member inline _.AllowCollapse ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowCollapse" =>>> x)
    /// Gets or sets a value indicating whether this RadzenPanel is collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsed" =>>> true)
    /// Gets or sets a value indicating whether this RadzenPanel is collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsed" =>>> x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("SummaryTemplate", fragment)
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("SummaryTemplate", fragment { yield! fragments })
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the expand callback.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Expand", fn)
    /// Gets or sets the expand callback.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Expand", fn)
    /// Gets or sets the collapse callback.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Collapse", fn)
    /// Gets or sets the collapse callback.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Collapse", fn)
    /// Gets or sets the title attribute of the expand button.
    [<CustomOperation("ExpandTitle")>] member inline _.ExpandTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandTitle" => x)
    /// Gets or sets the title attribute of the collapse button.
    [<CustomOperation("CollapseTitle")>] member inline _.CollapseTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseTitle" => x)
    /// Gets or sets the aria-label attribute of the expand button.
    [<CustomOperation("ExpandAriaLabel")>] member inline _.ExpandAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandAriaLabel" => x)
    /// Gets or sets the aria-label attribute of the collapse button.
    [<CustomOperation("CollapseAriaLabel")>] member inline _.CollapseAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseAriaLabel" => x)

/// RadzenPanelMenu component.
type RadzenPanelMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether multiple items can be expanded.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// Gets or sets a value indicating whether multiple items can be expanded.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.MenuItemEventArgs -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("Click", fn)
    /// Gets or sets a value representing the URL matching behavior.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// Gets or sets the display style.
    [<CustomOperation("DisplayStyle")>] member inline _.DisplayStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.MenuItemDisplayStyle) = render ==> ("DisplayStyle" => x)
    /// Gets or sets the show arrow.
    [<CustomOperation("ShowArrow")>] member inline _.ShowArrow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowArrow" =>>> true)
    /// Gets or sets the show arrow.
    [<CustomOperation("ShowArrow")>] member inline _.ShowArrow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowArrow" =>>> x)

/// RadzenProfileMenu component.
type RadzenProfileMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Template", fragment)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Template", fragment { yield! fragments })
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenProfileMenuItem -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenProfileMenuItem -> Task<unit>) = render ==> html.callbackTask("Click", fn)
    /// Show/Hide the "arrow down" icon
    [<CustomOperation("ShowIcon")>] member inline _.ShowIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowIcon" =>>> true)
    /// Show/Hide the "arrow down" icon
    [<CustomOperation("ShowIcon")>] member inline _.ShowIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowIcon" =>>> x)

/// RadzenSidebar component.
type RadzenSidebarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Toggles the responsive mode of the component. If set to true (the default) the component will be 
    /// expanded on larger displays and collapsed on touch devices. Set to false if you want to disable this behavior.
    /// Responsive mode is only available when RadzenSidebar is inside RadzenLayout.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Responsive" =>>> true)
    /// Toggles the responsive mode of the component. If set to true (the default) the component will be 
    /// expanded on larger displays and collapsed on touch devices. Set to false if you want to disable this behavior.
    /// Responsive mode is only available when RadzenSidebar is inside RadzenLayout.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Responsive" =>>> x)
    /// Gets or sets a value indicating whether this RadzenSidebar is expanded.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSidebar is expanded.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Gets or sets a value indicating whether this RadzenSidebar is expanded.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Gets or sets the expanded changed callback.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Gets or sets the expanded changed callback.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)

/// RadzenSplitButton component.
type RadzenSplitButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the child content.
    [<CustomOperation("ButtonContent")>] member inline _.ButtonContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ButtonContent", fragment)
    /// Gets or sets the child content.
    [<CustomOperation("ButtonContent")>] member inline _.ButtonContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ButtonContent", fragment { yield! fragments })
    /// Gets or sets the child content.
    [<CustomOperation("ButtonContent")>] member inline _.ButtonContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ButtonContent", html.text x)
    /// Gets or sets the child content.
    [<CustomOperation("ButtonContent")>] member inline _.ButtonContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ButtonContent", html.text x)
    /// Gets or sets the child content.
    [<CustomOperation("ButtonContent")>] member inline _.ButtonContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ButtonContent", html.text x)
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the image.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the button style.
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonStyle) = render ==> ("ButtonStyle" => x)
    /// Gets or sets the design variant of the button.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("Variant" => x)
    /// Gets or sets the color shade of the button.
    [<CustomOperation("Shade")>] member inline _.Shade ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Shade) = render ==> ("Shade" => x)
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonSize) = render ==> ("Size" => x)
    /// Gets or sets a value indicating whether this instance busy text is shown.
    [<CustomOperation("IsBusy")>] member inline _.IsBusy ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsBusy" =>>> true)
    /// Gets or sets a value indicating whether this instance busy text is shown.
    [<CustomOperation("IsBusy")>] member inline _.IsBusy ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsBusy" =>>> x)
    /// Gets or sets the busy text.
    [<CustomOperation("BusyText")>] member inline _.BusyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BusyText" => x)
    /// Gets or sets a value indicating whether this RadzenSplitButton is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSplitButton is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the value indication behaviour to always open popup with item on click and not invoke Click event.
    [<CustomOperation("AlwaysOpenPopup")>] member inline _.AlwaysOpenPopup ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AlwaysOpenPopup" =>>> true)
    /// Gets or sets the value indication behaviour to always open popup with item on click and not invoke Click event.
    [<CustomOperation("AlwaysOpenPopup")>] member inline _.AlwaysOpenPopup ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AlwaysOpenPopup" =>>> x)
    /// Gets or sets the open button aria-label attribute.
    [<CustomOperation("OpenAriaLabel")>] member inline _.OpenAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenAriaLabel" => x)
    /// Gets or sets the icon of the drop down.
    [<CustomOperation("DropDownIcon")>] member inline _.DropDownIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropDownIcon" => x)
    /// Gets or sets the index of the tab.
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TabIndex" => x)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenSplitButtonItem -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenSplitButtonItem -> Task<unit>) = render ==> html.callbackTask("Click", fn)
    /// Gets or sets the add button aria-label attribute.
    [<CustomOperation("ButtonAriaLabel")>] member inline _.ButtonAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonAriaLabel" => x)

/// RadzenTable component.
type RadzenTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the grid lines.
    [<CustomOperation("GridLines")>] member inline _.GridLines ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.DataGridGridLines) = render ==> ("GridLines" => x)
    /// Gets or sets a value indicating whether RadzenTable should use alternating row styles.
    [<CustomOperation("AllowAlternatingRows")>] member inline _.AllowAlternatingRows ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowAlternatingRows" =>>> true)
    /// Gets or sets a value indicating whether RadzenTable should use alternating row styles.
    [<CustomOperation("AllowAlternatingRows")>] member inline _.AllowAlternatingRows ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowAlternatingRows" =>>> x)

/// RadzenTableBody component.
type RadzenTableBodyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


/// RadzenTableRow component.
type RadzenTableCellBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


/// RadzenTableHeader component.
type RadzenTableHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


/// RadzenTableRow component.
type RadzenTableHeaderCellBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


/// RadzenTableRow component.
type RadzenTableHeaderRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


/// RadzenTableRow component.
type RadzenTableRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()


type RadzenMenuItemWrapperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentWithChildrenBuilder<'FunBlazorGeneric>()
    /// Gets or sets the menu item.
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenMenuItem) = render ==> ("Item" => x)

/// Base class of Radzen validator components.
type ValidatorBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Specifies the component which this validator should validate. Must be set to the Name of an existing component.
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Component" => x)
    /// Specifies the message displayed when the validator is invalid.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Determines if the validator is displayed as a popup or not. Set to false by default.
    [<CustomOperation("Popup")>] member inline _.Popup ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Popup" =>>> true)
    /// Determines if the validator is displayed as a popup or not. Set to false by default.
    [<CustomOperation("Popup")>] member inline _.Popup ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Popup" =>>> x)

/// A validator component which compares a component value with a specified value.
/// Must be placed inside a RadzenTemplateForm`1
type RadzenCompareValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.ValidatorBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the message displayed when the component is invalid. Set to "Value should match" by default.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the value to compare with.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Specifies the comparison operator. Set to CompareOperator.Equal by default.
    [<CustomOperation("Operator")>] member inline _.Operator ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.CompareOperator) = render ==> ("Operator" => x)
    /// Gets or sets a value indicating whether this RadzenCompareValidator should be validated on value change of the specified Component.
    [<CustomOperation("ValidateOnComponentValueChange")>] member inline _.ValidateOnComponentValueChange ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ValidateOnComponentValueChange" =>>> true)
    /// Gets or sets a value indicating whether this RadzenCompareValidator should be validated on value change of the specified Component.
    [<CustomOperation("ValidateOnComponentValueChange")>] member inline _.ValidateOnComponentValueChange ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ValidateOnComponentValueChange" =>>> x)

/// A validator component which compares a component value with a specified value.
/// Must be placed inside a RadzenTemplateForm`1
type RadzenCustomValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.ValidatorBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the message displayed when the component is invalid. Set to "Value should match" by default.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the function which validates the component value. Must return true if the component is valid.
    [<CustomOperation("Validator")>] member inline _.Validator ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Validator" => (System.Func<System.Boolean>fn))

/// A validator component which validates a component value using the data annotations
/// defined on the corresponding model property.
/// Must be placed inside a RadzenTemplateForm`1
type RadzenDataAnnotationValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.ValidatorBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the message displayed when the component is invalid.
    /// The message is generated from the data annotation attributes applied to the model property.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the separator used to join multiple validation messages.
    [<CustomOperation("MessageSeparator")>] member inline _.MessageSeparator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MessageSeparator" => x)

/// A validator component which checks if a component value is a valid email address.
/// Must be placed inside a RadzenTemplateForm`1
type RadzenEmailValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.ValidatorBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the message displayed when the component is invalid. Set to "Invalid email" by default.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)

/// A validator component which checks if then component value length is within a specified range.
/// Must be placed inside a RadzenTemplateForm`1
type RadzenLengthValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.ValidatorBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the message displayed when the component is invalid. Set to "Invalid length" by default.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the minimum accepted length. The component value length should be greater than the minimum in order to be valid.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Min" => x)
    /// Specifies the maximum accepted length. The component value length should be less than the maximum in order to be valid.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Max" => x)

/// A validator component which checks if a component value is within a specified range.
/// Must be placed inside a RadzenTemplateForm`1
type RadzenNumericRangeValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.ValidatorBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the message displayed when the component is invalid. Set to "Not in the valid range" by default.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the minimum value. The component value should be greater than the minimum in order to be valid.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.IComparable) = render ==> ("Min" => x)
    /// Specifies the maximum value. The component value should be less than the maximum in order to be valid.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.IComparable) = render ==> ("Max" => x)
    /// Specifies if value can be null. If true, a null component value will be accepted.
    [<CustomOperation("AllowNull")>] member inline _.AllowNull ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowNull" =>>> true)
    /// Specifies if value can be null. If true, a null component value will be accepted.
    [<CustomOperation("AllowNull")>] member inline _.AllowNull ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowNull" =>>> x)

/// A validator component which matches a component value against a specified regular expression pattern.
/// Must be placed inside a RadzenTemplateForm`1
type RadzenRegexValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.ValidatorBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the message displayed when the component is invalid. Set to "Value should match" by default.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the regular expression pattern which the component value should match in order to be valid.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)

/// A validator component which checks if a component has value.
/// Must be placed inside a RadzenTemplateForm`1
type RadzenRequiredValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.ValidatorBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the message displayed when the component is invalid. Set to "Required" by default.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies a default value. If the component value is equal to DefaultValue it is considered invalid.
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("DefaultValue" => x)

/// RadzenProgressBar component.
type RadzenProgressBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Template", fragment)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Template", fragment { yield! fragments })
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the mode.
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ProgressBarMode) = render ==> ("Mode" => x)
    /// Gets or sets the unit.
    [<CustomOperation("Unit")>] member inline _.Unit ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Unit" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Double * (System.Double -> unit)) = render ==> html.bind("Value", valueFn)
    /// Determines the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    /// Determines the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    /// Gets or sets a value indicating whether value is shown.
    [<CustomOperation("ShowValue")>] member inline _.ShowValue ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowValue" =>>> true)
    /// Gets or sets a value indicating whether value is shown.
    [<CustomOperation("ShowValue")>] member inline _.ShowValue ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowValue" =>>> x)
    /// Gets or sets the value changed callback.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ValueChanged" => (System.Action<System.Double>fn))
    /// Gets or sets the progress bar style.
    [<CustomOperation("ProgressBarStyle")>] member inline _.ProgressBarStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ProgressBarStyle) = render ==> ("ProgressBarStyle" => x)

/// RadzenProgressBarCircular component.
type RadzenProgressBarCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenProgressBarBuilder<'FunBlazorGeneric>()
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ProgressBarCircularSize) = render ==> ("Size" => x)

/// Displays line, area, donut, pie, bar or column series.
type RadzenChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the color scheme used to render the series.
    [<CustomOperation("ColorScheme")>] member inline _.ColorScheme ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.ColorScheme) = render ==> ("ColorScheme" => x)
    /// A callback that will be invoked when the user clicks on a series.
    [<CustomOperation("SeriesClick")>] member inline _.SeriesClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SeriesClickEventArgs -> unit) = render ==> html.callback("SeriesClick", fn)
    /// A callback that will be invoked when the user clicks on a series.
    [<CustomOperation("SeriesClick")>] member inline _.SeriesClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SeriesClickEventArgs -> Task<unit>) = render ==> html.callbackTask("SeriesClick", fn)
    /// A callback that will be invoked when the user clicks on a legend.
    [<CustomOperation("LegendClick")>] member inline _.LegendClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.LegendClickEventArgs -> unit) = render ==> html.callback("LegendClick", fn)
    /// A callback that will be invoked when the user clicks on a legend.
    [<CustomOperation("LegendClick")>] member inline _.LegendClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.LegendClickEventArgs -> Task<unit>) = render ==> html.callbackTask("LegendClick", fn)
    /// The minimum pixel distance from a data point to the mouse cursor required for the SeriesClick event to fire. Set to 25 by default.
    [<CustomOperation("ClickTolerance")>] member inline _.ClickTolerance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ClickTolerance" => x)
    /// The minimum pixel distance from a data point to the mouse cursor required by the tooltip to show. Set to 25 by default.
    [<CustomOperation("TooltipTolerance")>] member inline _.TooltipTolerance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TooltipTolerance" => x)

/// A sparkline is a small chart that provides a simple way to visualize trends in data.
type RadzenSparklineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartBuilder<'FunBlazorGeneric>()


/// RadzenButton component.
type RadzenButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the index of the tab.
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TabIndex" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the image.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the button style.
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonStyle) = render ==> ("ButtonStyle" => x)
    /// Gets or sets the type of the button.
    [<CustomOperation("ButtonType")>] member inline _.ButtonType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonType) = render ==> ("ButtonType" => x)
    /// Gets or sets the design variant of the button.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("Variant" => x)
    /// Gets or sets the color shade of the button.
    [<CustomOperation("Shade")>] member inline _.Shade ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Shade) = render ==> ("Shade" => x)
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonSize) = render ==> ("Size" => x)
    /// Gets or sets a value indicating whether this RadzenButton is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenButton is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("Click", fn)
    /// Gets or sets a value indicating whether this instance busy text is shown.
    [<CustomOperation("IsBusy")>] member inline _.IsBusy ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsBusy" =>>> true)
    /// Gets or sets a value indicating whether this instance busy text is shown.
    [<CustomOperation("IsBusy")>] member inline _.IsBusy ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsBusy" =>>> x)
    /// Gets or sets the busy text.
    [<CustomOperation("BusyText")>] member inline _.BusyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BusyText" => x)

/// RadzenButton component.
type RadzenToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenButtonBuilder<'FunBlazorGeneric>()
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets the name.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the placeholder.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Gets or sets the toggle icon.
    [<CustomOperation("ToggleIcon")>] member inline _.ToggleIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggleIcon" => x)
    /// Gets or sets the value changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Gets or sets the value changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Value" =>>> true)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Value" =>>> x)
    /// Gets or sets the value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Value", valueFn)
    /// Gets or sets the change.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("Change", fn)
    /// Gets or sets the change.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// Gets or sets the value expression.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = render ==> ("ValueExpression" => x)
    /// Gets or sets the ToggleButton style.
    [<CustomOperation("ToggleButtonStyle")>] member inline _.ToggleButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonStyle) = render ==> ("ToggleButtonStyle" => x)
    /// Gets or sets the ToggleButton shade.
    [<CustomOperation("ToggleShade")>] member inline _.ToggleShade ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Shade) = render ==> ("ToggleShade" => x)

/// Class GaugeBase.
/// Implements the RadzenComponent
type GaugeBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()


type RadzenArcGaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.GaugeBaseBuilder<'FunBlazorGeneric>()


type RadzenRadialGaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.GaugeBaseBuilder<'FunBlazorGeneric>()


            
namespace rec Radzen.Blazor.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// Class DataBoundFormComponent.
/// Implements the RadzenComponent
/// Implements the IRadzenFormComponent
type DataBoundFormComponentBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the index of the tab.
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TabIndex" => x)
    /// Gets or sets the filter case sensitivity.
    [<CustomOperation("FilterCaseSensitivity")>] member inline _.FilterCaseSensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FilterCaseSensitivity) = render ==> ("FilterCaseSensitivity" => x)
    /// Gets or sets the filter operator.
    [<CustomOperation("FilterOperator")>] member inline _.FilterOperator ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.StringFilterOperator) = render ==> ("FilterOperator" => x)
    /// Gets or sets the name.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the placeholder.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Gets or sets a value indicating whether this DataBoundFormComponent`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this DataBoundFormComponent`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the change.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> unit) = render ==> html.callback("Change", fn)
    /// Gets or sets the change.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// Gets or sets the load data.
    [<CustomOperation("LoadData")>] member inline _.LoadData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.LoadDataArgs -> unit) = render ==> html.callback("LoadData", fn)
    /// Gets or sets the load data.
    [<CustomOperation("LoadData")>] member inline _.LoadData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.LoadDataArgs -> Task<unit>) = render ==> html.callbackTask("LoadData", fn)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("Value", valueFn)
    /// Gets or sets the value changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Gets or sets the value changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Gets or sets the text property.
    [<CustomOperation("TextProperty")>] member inline _.TextProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextProperty" => x)
    /// Gets or sets the data.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.IEnumerable) = render ==> ("Data" => x)
    /// Gets or sets the search text
    [<CustomOperation("SearchText")>] member inline _.SearchText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SearchText" => x)
    /// Gets or sets the search text
    [<CustomOperation("SearchText'")>] member inline _.SearchText' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("SearchText", valueFn)
    /// Gets or sets the search text changed.
    [<CustomOperation("SearchTextChanged")>] member inline _.SearchTextChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("SearchTextChanged", fn)
    /// Gets or sets the search text changed.
    [<CustomOperation("SearchTextChanged")>] member inline _.SearchTextChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("SearchTextChanged", fn)
    /// Gets or sets the value expression.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T>>) = render ==> ("ValueExpression" => x)

/// Base class of components that display a list of items.
type DropDownBaseBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DataBoundFormComponentBuilder<'FunBlazorGeneric, 'T>()
    /// Gets or sets a value that determines how many additional items will be rendered before and after the visible region. This help to reduce the frequency of rendering during scrolling. However, higher values mean that more elements will be present in the page.
    [<CustomOperation("VirtualizationOverscanCount")>] member inline _.VirtualizationOverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VirtualizationOverscanCount" => x)
    /// Specifies the total number of items in the data source.
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    /// Specifies wether virtualization is enabled. Set to false by default.
    [<CustomOperation("AllowVirtualization")>] member inline _.AllowVirtualization ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowVirtualization" =>>> true)
    /// Specifies wether virtualization is enabled. Set to false by default.
    [<CustomOperation("AllowVirtualization")>] member inline _.AllowVirtualization ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowVirtualization" =>>> x)
    /// Specifies the default page size. Set to 5 by default.
    [<CustomOperation("PageSize")>] member inline _.PageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageSize" => x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets a value indicating whether filtering is allowed. Set to false by default.
    [<CustomOperation("AllowFiltering")>] member inline _.AllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowFiltering" =>>> true)
    /// Gets or sets a value indicating whether filtering is allowed. Set to false by default.
    [<CustomOperation("AllowFiltering")>] member inline _.AllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowFiltering" =>>> x)
    /// Gets or sets a value indicating whether filtering is allowed as you type. Set to true by default.
    [<CustomOperation("FilterAsYouType")>] member inline _.FilterAsYouType ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FilterAsYouType" =>>> true)
    /// Gets or sets a value indicating whether filtering is allowed as you type. Set to true by default.
    [<CustomOperation("FilterAsYouType")>] member inline _.FilterAsYouType ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FilterAsYouType" =>>> x)
    /// Gets or sets a value indicating whether the user can clear the value. Set to false by default.
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowClear" =>>> true)
    /// Gets or sets a value indicating whether the user can clear the value. Set to false by default.
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowClear" =>>> x)
    /// Gets or sets a value indicating whether this DropDownBase`1 is multiple.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// Gets or sets a value indicating whether this DropDownBase`1 is multiple.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// Gets or sets a value indicating whether the user can select all values in multiple selection. Set to true by default.
    [<CustomOperation("AllowSelectAll")>] member inline _.AllowSelectAll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowSelectAll" =>>> true)
    /// Gets or sets a value indicating whether the user can select all values in multiple selection. Set to true by default.
    [<CustomOperation("AllowSelectAll")>] member inline _.AllowSelectAll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowSelectAll" =>>> x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the value property.
    [<CustomOperation("ValueProperty")>] member inline _.ValueProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueProperty" => x)
    /// Gets or sets the disabled property.
    [<CustomOperation("DisabledProperty")>] member inline _.DisabledProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledProperty" => x)
    /// Gets or sets the remove chip button title.
    [<CustomOperation("RemoveChipTitle")>] member inline _.RemoveChipTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RemoveChipTitle" => x)
    /// Gets or sets the search aria label text.
    [<CustomOperation("SearchAriaLabel")>] member inline _.SearchAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SearchAriaLabel" => x)
    /// Gets or sets the empty value aria label text.
    [<CustomOperation("EmptyAriaLabel")>] member inline _.EmptyAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EmptyAriaLabel" => x)
    /// Gets or sets the selected item changed.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Gets or sets the selected item changed.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// Gets or sets the data.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.IEnumerable) = render ==> ("Data" => x)
    /// Gets or sets the filter delay.
    [<CustomOperation("FilterDelay")>] member inline _.FilterDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("FilterDelay" => x)
    /// Gets or sets the selected item.
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("SelectedItem" => x)
    /// Gets or sets the selected item.
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Gets or sets the item separator for Multiple dropdown.
    [<CustomOperation("Separator")>] member inline _.Separator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Separator" => x)
    /// For lists of objects, an IEqualityComparer to control how selected items are determined
    [<CustomOperation("ItemComparer")>] member inline _.ItemComparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<System.Object>) = render ==> ("ItemComparer" => x)

            
namespace rec Radzen.Blazor.DslInternals.Blazor

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// RadzenDropDown component.
type RadzenDropDownBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DropDownBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Gets or sets the value template.
    [<CustomOperation("ValueTemplate")>] member inline _.ValueTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> NodeRenderFragment) = render ==> html.renderFragment("ValueTemplate", fn)
    /// Gets or sets the empty template.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("EmptyTemplate", fragment)
    /// Gets or sets the empty template.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("EmptyTemplate", fragment { yield! fragments })
    /// Gets or sets the empty template.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the empty template.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the empty template.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets a value indicating whether popup should open on focus. Set to false by default.
    [<CustomOperation("OpenOnFocus")>] member inline _.OpenOnFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OpenOnFocus" =>>> true)
    /// Gets or sets a value indicating whether popup should open on focus. Set to false by default.
    [<CustomOperation("OpenOnFocus")>] member inline _.OpenOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OpenOnFocus" =>>> x)
    /// Gets or sets a value indicating whether search field need to be cleared after selection. Set to false by default.
    [<CustomOperation("ClearSearchAfterSelection")>] member inline _.ClearSearchAfterSelection ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ClearSearchAfterSelection" =>>> true)
    /// Gets or sets a value indicating whether search field need to be cleared after selection. Set to false by default.
    [<CustomOperation("ClearSearchAfterSelection")>] member inline _.ClearSearchAfterSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ClearSearchAfterSelection" =>>> x)
    /// Gets or sets the filter placeholder.
    [<CustomOperation("FilterPlaceholder")>] member inline _.FilterPlaceholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterPlaceholder" => x)
    /// Gets or Sets the filter autocomplete type.
    [<CustomOperation("FilterAutoCompleteType")>] member inline _.FilterAutoCompleteType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.AutoCompleteType) = render ==> ("FilterAutoCompleteType" => x)
    /// Gets or sets the row render callback. Use it to set row attributes.
    [<CustomOperation("ItemRender")>] member inline _.ItemRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemRender" => (System.Action<Radzen.DropDownItemRenderEventArgs<'TValue>>fn))
    /// Gets or sets the number of maximum selected labels.
    [<CustomOperation("MaxSelectedLabels")>] member inline _.MaxSelectedLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxSelectedLabels" => x)
    /// Gets or sets the Popup height.
    [<CustomOperation("PopupStyle")>] member inline _.PopupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupStyle" => x)
    /// Gets or sets a value indicating whether the selected items will be displayed as chips. Set to false by default.
    /// Requires Multiple to be set to true.
    [<CustomOperation("Chips")>] member inline _.Chips ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Chips" =>>> true)
    /// Gets or sets a value indicating whether the selected items will be displayed as chips. Set to false by default.
    /// Requires Multiple to be set to true.
    [<CustomOperation("Chips")>] member inline _.Chips ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Chips" =>>> x)
    /// Gets or sets the selected items text.
    [<CustomOperation("SelectedItemsText")>] member inline _.SelectedItemsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedItemsText" => x)
    /// Gets or sets the select all text.
    [<CustomOperation("SelectAllText")>] member inline _.SelectAllText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    /// Callback for when a dropdown is opened.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Open", fn)
    /// Callback for when a dropdown is opened.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Open", fn)
    /// Callback for when a dropdown is closed.
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Close", fn)
    /// Callback for when a dropdown is closed.
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Close", fn)

/// RadzenDropDownDataGrid component.
type RadzenDropDownDataGridBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DropDownBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets the row render callback. Use it to set row attributes.
    [<CustomOperation("RowRender")>] member inline _.RowRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowRender" => (System.Action<Radzen.RowRenderEventArgs<System.Object>>fn))
    /// Gets or sets the cell render callback. Use it to set cell attributes.
    [<CustomOperation("CellRender")>] member inline _.CellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CellRender" => (System.Action<Radzen.DataGridCellRenderEventArgs<System.Object>>fn))
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets a value indicating whether the selected items will be displayed as chips. Set to false by default.
    /// Requires Multiple to be set to true.
    [<CustomOperation("Chips")>] member inline _.Chips ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Chips" =>>> true)
    /// Gets or sets a value indicating whether the selected items will be displayed as chips. Set to false by default.
    /// Requires Multiple to be set to true.
    [<CustomOperation("Chips")>] member inline _.Chips ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Chips" =>>> x)
    /// Gets or sets the Popup style.
    [<CustomOperation("PopupStyle")>] member inline _.PopupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupStyle" => x)
    /// Gets or sets a value indicating whether popup should open on focus. Set to false by default.
    [<CustomOperation("OpenOnFocus")>] member inline _.OpenOnFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OpenOnFocus" =>>> true)
    /// Gets or sets a value indicating whether popup should open on focus. Set to false by default.
    [<CustomOperation("OpenOnFocus")>] member inline _.OpenOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OpenOnFocus" =>>> x)
    /// Gets or sets the value template.
    [<CustomOperation("ValueTemplate")>] member inline _.ValueTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> NodeRenderFragment) = render ==> html.renderFragment("ValueTemplate", fn)
    /// Gets or sets a value indicating DataGrid density.
    [<CustomOperation("Density")>] member inline _.Density ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Density) = render ==> ("Density" => x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("EmptyTemplate", fragment)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("EmptyTemplate", fragment { yield! fragments })
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets a value indicating whether pager is visible even when not enough data for paging.
    [<CustomOperation("PagerAlwaysVisible")>] member inline _.PagerAlwaysVisible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PagerAlwaysVisible" =>>> true)
    /// Gets or sets a value indicating whether pager is visible even when not enough data for paging.
    [<CustomOperation("PagerAlwaysVisible")>] member inline _.PagerAlwaysVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PagerAlwaysVisible" =>>> x)
    /// Gets or sets the horizontal align.
    [<CustomOperation("PagerHorizontalAlign")>] member inline _.PagerHorizontalAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.HorizontalAlign) = render ==> ("PagerHorizontalAlign" => x)
    /// Gets or sets a value indicating whether column resizing is allowed.
    [<CustomOperation("AllowColumnResize")>] member inline _.AllowColumnResize ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowColumnResize" =>>> true)
    /// Gets or sets a value indicating whether column resizing is allowed.
    [<CustomOperation("AllowColumnResize")>] member inline _.AllowColumnResize ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowColumnResize" =>>> x)
    /// Gets or sets the width of all columns.
    [<CustomOperation("ColumnWidth")>] member inline _.ColumnWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ColumnWidth" => x)
    /// Gets or sets a value indicating whether this RadzenDropDownDataGrid`1 is responsive.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Responsive" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDropDownDataGrid`1 is responsive.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Responsive" =>>> x)
    /// Gets or sets a value indicating whether search button is shown.
    [<CustomOperation("ShowSearch")>] member inline _.ShowSearch ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowSearch" =>>> true)
    /// Gets or sets a value indicating whether search button is shown.
    [<CustomOperation("ShowSearch")>] member inline _.ShowSearch ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowSearch" =>>> x)
    /// Gets or sets the action to be executed when the Add button is clicked.
    [<CustomOperation("Add")>] member inline _.Add ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("Add", fn)
    /// Gets or sets the action to be executed when the Add button is clicked.
    [<CustomOperation("Add")>] member inline _.Add ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("Add", fn)
    /// Gets or sets a value indicating whether the create button is shown.
    [<CustomOperation("ShowAdd")>] member inline _.ShowAdd ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowAdd" =>>> true)
    /// Gets or sets a value indicating whether the create button is shown.
    [<CustomOperation("ShowAdd")>] member inline _.ShowAdd ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowAdd" =>>> x)
    /// Gets or sets preserving the selected row index on pageing.
    [<CustomOperation("PreserveRowSelectionOnPaging")>] member inline _.PreserveRowSelectionOnPaging ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreserveRowSelectionOnPaging" =>>> true)
    /// Gets or sets preserving the selected row index on pageing.
    [<CustomOperation("PreserveRowSelectionOnPaging")>] member inline _.PreserveRowSelectionOnPaging ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreserveRowSelectionOnPaging" =>>> x)
    /// Gets or sets the page numbers count.
    [<CustomOperation("PageNumbersCount")>] member inline _.PageNumbersCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageNumbersCount" => x)
    /// Gets or sets the pager summary visibility.
    [<CustomOperation("ShowPagingSummary")>] member inline _.ShowPagingSummary ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowPagingSummary" =>>> true)
    /// Gets or sets the pager summary visibility.
    [<CustomOperation("ShowPagingSummary")>] member inline _.ShowPagingSummary ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowPagingSummary" =>>> x)
    /// Gets or sets the pager summary format.
    [<CustomOperation("PagingSummaryFormat")>] member inline _.PagingSummaryFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PagingSummaryFormat" => x)
    /// Gets or sets the pager's first page button's title attribute.
    [<CustomOperation("FirstPageTitle")>] member inline _.FirstPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstPageTitle" => x)
    /// Gets or sets the pager's first page button's aria-label attribute.
    [<CustomOperation("FirstPageAriaLabel")>] member inline _.FirstPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstPageAriaLabel" => x)
    /// Gets or sets the pager's previous page button's title attribute.
    [<CustomOperation("PrevPageTitle")>] member inline _.PrevPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevPageTitle" => x)
    /// Gets or sets the pager's previous page button's aria-label attribute.
    [<CustomOperation("PrevPageAriaLabel")>] member inline _.PrevPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevPageAriaLabel" => x)
    /// Gets or sets the pager's last page button's title attribute.
    [<CustomOperation("LastPageTitle")>] member inline _.LastPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastPageTitle" => x)
    /// Gets or sets the pager's last page button's aria-label attribute.
    [<CustomOperation("LastPageAriaLabel")>] member inline _.LastPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastPageAriaLabel" => x)
    /// Gets or sets the pager's next page button's title attribute.
    [<CustomOperation("NextPageTitle")>] member inline _.NextPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextPageTitle" => x)
    /// Gets or sets the pager's next page button's aria-label attribute.
    [<CustomOperation("NextPageAriaLabel")>] member inline _.NextPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextPageAriaLabel" => x)
    /// Gets or sets the pager's numeric page number buttons' title attributes.
    [<CustomOperation("PageTitleFormat")>] member inline _.PageTitleFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PageTitleFormat" => x)
    /// Gets or sets the pager's numeric page number buttons' aria-label attributes.
    [<CustomOperation("PageAriaLabelFormat")>] member inline _.PageAriaLabelFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PageAriaLabelFormat" => x)
    /// Gets or sets the empty text.
    [<CustomOperation("EmptyText")>] member inline _.EmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EmptyText" => x)
    /// Gets or sets the search input placeholder text.
    [<CustomOperation("SearchTextPlaceholder")>] member inline _.SearchTextPlaceholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SearchTextPlaceholder" => x)
    /// Gets or sets the add button aria-label attribute.
    [<CustomOperation("AddAriaLabel")>] member inline _.AddAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddAriaLabel" => x)
    /// Gets or sets the selected value.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("SelectedValue" => x)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Columns", fragment)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Columns", fragment { yield! fragments })
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Columns", html.text x)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Columns", html.text x)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Columns", html.text x)
    /// Gets or sets the number of maximum selected labels.
    [<CustomOperation("MaxSelectedLabels")>] member inline _.MaxSelectedLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxSelectedLabels" => x)
    /// Gets or sets the selected items text.
    [<CustomOperation("SelectedItemsText")>] member inline _.SelectedItemsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedItemsText" => x)
    /// Gets or sets whether popup automatically focuses on filter input.
    [<CustomOperation("FocusFilterOnPopup")>] member inline _.FocusFilterOnPopup ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FocusFilterOnPopup" =>>> true)
    /// Gets or sets whether popup automatically focuses on filter input.
    [<CustomOperation("FocusFilterOnPopup")>] member inline _.FocusFilterOnPopup ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FocusFilterOnPopup" =>>> x)
    /// Gets or sets a value indicating whether this instance loading indicator is shown.
    [<CustomOperation("IsLoading")>] member inline _.IsLoading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsLoading" =>>> true)
    /// Gets or sets a value indicating whether this instance loading indicator is shown.
    [<CustomOperation("IsLoading")>] member inline _.IsLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsLoading" =>>> x)
    /// Gets or sets a value indicating whether sorting is allowed.
    [<CustomOperation("AllowSorting")>] member inline _.AllowSorting ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowSorting" =>>> true)
    /// Gets or sets a value indicating whether sorting is allowed.
    [<CustomOperation("AllowSorting")>] member inline _.AllowSorting ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowSorting" =>>> x)
    /// Gets or sets a value indicating whether filtering is allowed.
    [<CustomOperation("AllowFiltering")>] member inline _.AllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowFiltering" =>>> true)
    /// Gets or sets a value indicating whether filtering is allowed.
    [<CustomOperation("AllowFiltering")>] member inline _.AllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowFiltering" =>>> x)
    /// Gets or sets a value indicating whether filtering by all string columns is allowed.
    [<CustomOperation("AllowFilteringByAllStringColumns")>] member inline _.AllowFilteringByAllStringColumns ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowFilteringByAllStringColumns" =>>> true)
    /// Gets or sets a value indicating whether filtering by all string columns is allowed.
    [<CustomOperation("AllowFilteringByAllStringColumns")>] member inline _.AllowFilteringByAllStringColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowFilteringByAllStringColumns" =>>> x)
    /// Gets or sets a value indicating whether filtering by each entered word in the search term, sperated by a space, is allowed.
    [<CustomOperation("AllowFilteringByWord")>] member inline _.AllowFilteringByWord ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowFilteringByWord" =>>> true)
    /// Gets or sets a value indicating whether filtering by each entered word in the search term, sperated by a space, is allowed.
    [<CustomOperation("AllowFilteringByWord")>] member inline _.AllowFilteringByWord ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowFilteringByWord" =>>> x)
    /// Gets or sets a value indicating whether DataGrid row can be selected on row click.
    [<CustomOperation("AllowRowSelectOnRowClick")>] member inline _.AllowRowSelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowRowSelectOnRowClick" =>>> true)
    /// Gets or sets a value indicating whether DataGrid row can be selected on row click.
    [<CustomOperation("AllowRowSelectOnRowClick")>] member inline _.AllowRowSelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowRowSelectOnRowClick" =>>> x)

/// RadzenListBox component.
type RadzenListBoxBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DropDownBaseBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the select all text.
    [<CustomOperation("SelectAllText")>] member inline _.SelectAllText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets the row render callback. Use it to set row attributes.
    [<CustomOperation("ItemRender")>] member inline _.ItemRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemRender" => (System.Action<Radzen.ListBoxItemRenderEventArgs<'TValue>>fn))
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)

/// RadzenAutoComplete component.
type RadzenAutoCompleteBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DataBoundFormComponentBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets the selected item.
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("SelectedItem" => x)
    /// Gets or sets the selected item.
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Gets or sets the selected item changed.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Gets or sets the selected item changed.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets a value indicating whether this RadzenAutoComplete is multiline.
    [<CustomOperation("Multiline")>] member inline _.Multiline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiline" =>>> true)
    /// Gets or sets a value indicating whether this RadzenAutoComplete is multiline.
    [<CustomOperation("Multiline")>] member inline _.Multiline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiline" =>>> x)
    /// Gets or sets a value indicating whether popup should open on focus. Set to false by default.
    [<CustomOperation("OpenOnFocus")>] member inline _.OpenOnFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OpenOnFocus" =>>> true)
    /// Gets or sets a value indicating whether popup should open on focus. Set to false by default.
    [<CustomOperation("OpenOnFocus")>] member inline _.OpenOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OpenOnFocus" =>>> x)
    /// Gets or sets the Popup height.
    [<CustomOperation("PopupStyle")>] member inline _.PopupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupStyle" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the minimum length.
    [<CustomOperation("MinLength")>] member inline _.MinLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinLength" => x)
    /// Gets or sets the filter delay.
    [<CustomOperation("FilterDelay")>] member inline _.FilterDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("FilterDelay" => x)
    /// Gets or sets the underlying input type.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputType" => x)
    /// Gets or sets the underlying max length.
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int64>) = render ==> ("MaxLength" => x)

            
namespace rec Radzen.Blazor.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// Class FormComponent.
/// Implements the RadzenComponent
/// Implements the IRadzenFormComponent
type FormComponentBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the name.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the index of the tab.
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TabIndex" => x)
    /// Gets or sets the placeholder.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Gets or sets a value indicating whether this FormComponent`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this FormComponent`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the value changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Gets or sets the value changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// Gets or sets the change.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("Change", fn)
    /// Gets or sets the change.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// Gets or sets the value expression.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T>>) = render ==> ("ValueExpression" => x)

/// Class FormComponentWithAutoComplete.
type FormComponentWithAutoCompleteBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, 'T>()
    /// Gets or sets a value indicating the type of built-in autocomplete
    /// the browser should use.
    /// AutoCompleteType
    [<CustomOperation("AutoCompleteType")>] member inline _.AutoCompleteType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.AutoCompleteType) = render ==> ("AutoCompleteType" => x)

            
namespace rec Radzen.Blazor.DslInternals.Blazor

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// RadzenMask component.
type RadzenMaskBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentWithAutoCompleteBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Gets or sets the maximum length.
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int64>) = render ==> ("MaxLength" => x)
    /// Gets or sets the mask.
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Mask" => x)
    /// Gets or sets the pattern that will be used to replace all invalid characters with regular expression.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Gets or sets the pattern that will be used to match all valid characters with regular expression. If both Pattern and CharacterPattern are set CharacterPattern will be used.
    [<CustomOperation("CharacterPattern")>] member inline _.CharacterPattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CharacterPattern" => x)

/// RadzenNumeric component.
type RadzenNumericBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentWithAutoCompleteBuilder<'FunBlazorGeneric, 'TValue>()
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Gets or sets the format.
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
    /// Gets or sets the step.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Step" => x)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Gets or sets the maximum allowed text length.
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int64>) = render ==> ("MaxLength" => x)
    /// Gets or sets a value indicating whether up down buttons are shown.
    [<CustomOperation("ShowUpDown")>] member inline _.ShowUpDown ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowUpDown" =>>> true)
    /// Gets or sets a value indicating whether up down buttons are shown.
    [<CustomOperation("ShowUpDown")>] member inline _.ShowUpDown ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowUpDown" =>>> x)
    /// Gets or sets the text align.
    [<CustomOperation("TextAlign")>] member inline _.TextAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.TextAlign) = render ==> ("TextAlign" => x)
    /// Gets or sets the function which returns TValue from string.
    [<CustomOperation("ConvertValue")>] member inline _.ConvertValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ConvertValue" => (System.Func<System.String, 'TValue>fn))
    /// Determines the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Decimal>) = render ==> ("Min" => x)
    /// Determines the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Decimal>) = render ==> ("Max" => x)
    /// Gets or sets the up button aria-label attribute.
    [<CustomOperation("UpAriaLabel")>] member inline _.UpAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UpAriaLabel" => x)
    /// Gets or sets the down button aria-label attribute.
    [<CustomOperation("DownAriaLabel")>] member inline _.DownAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DownAriaLabel" => x)

/// RadzenPassword component.
type RadzenPasswordBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentWithAutoCompleteBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)

/// An input component for single line text entry.
type RadzenTextBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentWithAutoCompleteBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Gets or sets the maximum allowed text length.
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int64>) = render ==> ("MaxLength" => x)
    /// Specifies whether to remove any leading or trailing whitespace from the value. Set to false by default.
    [<CustomOperation("Trim")>] member inline _.Trim ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Trim" =>>> true)
    /// Specifies whether to remove any leading or trailing whitespace from the value. Set to false by default.
    [<CustomOperation("Trim")>] member inline _.Trim ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Trim" =>>> x)

/// RadzenCheckBox component.
type RadzenCheckBoxBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, 'TValue>()
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets a value indicating whether is tri-state (true, false or null).
    [<CustomOperation("TriState")>] member inline _.TriState ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TriState" =>>> true)
    /// Gets or sets a value indicating whether is tri-state (true, false or null).
    [<CustomOperation("TriState")>] member inline _.TriState ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TriState" =>>> x)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)

/// RadzenCheckBoxList component.
type RadzenCheckBoxListBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TValue>>()
    /// Gets or sets the value property.
    [<CustomOperation("ValueProperty")>] member inline _.ValueProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueProperty" => x)
    /// Gets or sets the text property.
    [<CustomOperation("TextProperty")>] member inline _.TextProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextProperty" => x)
    /// Gets or sets the disabled property.
    [<CustomOperation("DisabledProperty")>] member inline _.DisabledProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledProperty" => x)
    /// Gets or sets the read-only property.
    [<CustomOperation("ReadOnlyProperty")>] member inline _.ReadOnlyProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ReadOnlyProperty" => x)
    /// Gets or sets a value indicating whether the user can select all values. Set to false by default.
    [<CustomOperation("AllowSelectAll")>] member inline _.AllowSelectAll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowSelectAll" =>>> true)
    /// Gets or sets a value indicating whether the user can select all values. Set to false by default.
    [<CustomOperation("AllowSelectAll")>] member inline _.AllowSelectAll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowSelectAll" =>>> x)
    /// Gets or sets the select all text.
    [<CustomOperation("SelectAllText")>] member inline _.SelectAllText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    /// Gets or sets the data used to generate items.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.IEnumerable) = render ==> ("Data" => x)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Gets or sets the orientation.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the items that will be concatenated with generated items from Data.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Items", fragment)
    /// Gets or sets the items that will be concatenated with generated items from Data.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Items", fragment { yield! fragments })
    /// Gets or sets the items that will be concatenated with generated items from Data.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items that will be concatenated with generated items from Data.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items that will be concatenated with generated items from Data.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Items", html.text x)

/// RadzenColorPicker component.
type RadzenColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets the toggle popup aria label text.
    [<CustomOperation("ToggleAriaLabel")>] member inline _.ToggleAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggleAriaLabel" => x)
    /// Gets or sets the open callback.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Open", fn)
    /// Gets or sets the open callback.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Open", fn)
    /// Gets or sets the close callback.
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Close", fn)
    /// Gets or sets the close callback.
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Close", fn)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the hexadecimal color label text.
    [<CustomOperation("HexText")>] member inline _.HexText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HexText" => x)
    /// Gets or sets the red color label text.
    [<CustomOperation("RedText")>] member inline _.RedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RedText" => x)
    /// Gets or sets the green color label text.
    [<CustomOperation("GreenText")>] member inline _.GreenText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GreenText" => x)
    /// Gets or sets the blue color label text.
    [<CustomOperation("BlueText")>] member inline _.BlueText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BlueText" => x)
    /// Gets or sets the alpha label text.
    [<CustomOperation("AlphaText")>] member inline _.AlphaText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AlphaText" => x)
    /// Gets or sets the button text.
    [<CustomOperation("ButtonText")>] member inline _.ButtonText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonText" => x)
    /// Gets or sets a value indicating whether button is shown.
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowButton" =>>> true)
    /// Gets or sets a value indicating whether button is shown.
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowButton" =>>> x)
    /// Gets or sets a value indicating whether HSV is shown.
    [<CustomOperation("ShowHSV")>] member inline _.ShowHSV ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowHSV" =>>> true)
    /// Gets or sets a value indicating whether HSV is shown.
    [<CustomOperation("ShowHSV")>] member inline _.ShowHSV ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowHSV" =>>> x)
    /// Gets or sets a value indicating whether RGBA is shown.
    [<CustomOperation("ShowRGBA")>] member inline _.ShowRGBA ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowRGBA" =>>> true)
    /// Gets or sets a value indicating whether RGBA is shown.
    [<CustomOperation("ShowRGBA")>] member inline _.ShowRGBA ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowRGBA" =>>> x)
    /// Gets or sets a value indicating whether colors are shown.
    [<CustomOperation("ShowColors")>] member inline _.ShowColors ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowColors" =>>> true)
    /// Gets or sets a value indicating whether colors are shown.
    [<CustomOperation("ShowColors")>] member inline _.ShowColors ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowColors" =>>> x)
    /// Gets or sets the render mode.
    [<CustomOperation("PopupRenderMode")>] member inline _.PopupRenderMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.PopupRenderMode) = render ==> ("PopupRenderMode" => x)

/// RadzenFileInput component.
type RadzenFileInputBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, 'TValue>()
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets the choose button text.
    [<CustomOperation("ChooseText")>] member inline _.ChooseText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ChooseText" => x)
    /// Gets or sets the delete button text.
    [<CustomOperation("DeleteText")>] member inline _.DeleteText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DeleteText" => x)
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Gets or sets the title.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the error callback.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadErrorEventArgs -> unit) = render ==> html.callback("Error", fn)
    /// Gets or sets the error callback.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadErrorEventArgs -> Task<unit>) = render ==> html.callbackTask("Error", fn)
    /// Gets or sets the image click callback.
    [<CustomOperation("ImageClick")>] member inline _.ImageClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("ImageClick", fn)
    /// Gets or sets the image click callback.
    [<CustomOperation("ImageClick")>] member inline _.ImageClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("ImageClick", fn)
    /// Gets or sets the comma-separated accepted MIME types.
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    /// Gets or sets the maximum size of the file.
    [<CustomOperation("MaxFileSize")>] member inline _.MaxFileSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxFileSize" => x)
    /// Gets or sets the maximum width of the file, keeping aspect ratio.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxWidth" => x)
    /// Gets or sets the maximum height of the file, keeping aspect ratio.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    /// Gets or sets the image style.
    [<CustomOperation("ImageStyle")>] member inline _.ImageStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageStyle" => x)
    /// Gets or sets the image file name.
    [<CustomOperation("FileName")>] member inline _.FileName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FileName" => x)
    /// Gets or sets the image file name.
    [<CustomOperation("FileName'")>] member inline _.FileName' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("FileName", valueFn)
    /// Gets or sets the FileName changed.
    [<CustomOperation("FileNameChanged")>] member inline _.FileNameChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("FileNameChanged", fn)
    /// Gets or sets the FileName changed.
    [<CustomOperation("FileNameChanged")>] member inline _.FileNameChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("FileNameChanged", fn)
    /// Gets or sets the image file size.
    [<CustomOperation("FileSize")>] member inline _.FileSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int64>) = render ==> ("FileSize" => x)
    /// Gets or sets the image file size.
    [<CustomOperation("FileSize'")>] member inline _.FileSize' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.Int64> * (System.Nullable<System.Int64> -> unit)) = render ==> html.bind("FileSize", valueFn)
    /// Gets or sets the FileSize changed.
    [<CustomOperation("FileSizeChanged")>] member inline _.FileSizeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int64> -> unit) = render ==> html.callback("FileSizeChanged", fn)
    /// Gets or sets the FileSize changed.
    [<CustomOperation("FileSizeChanged")>] member inline _.FileSizeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int64> -> Task<unit>) = render ==> html.callbackTask("FileSizeChanged", fn)

/// A component which edits HTML content. Provides built-in upload capabilities.
type RadzenHtmlEditorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, System.String>()
    /// Specifies whether to show the toolbar. Set it to false to hide the toolbar. Default value is true.
    [<CustomOperation("ShowToolbar")>] member inline _.ShowToolbar ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowToolbar" =>>> true)
    /// Specifies whether to show the toolbar. Set it to false to hide the toolbar. Default value is true.
    [<CustomOperation("ShowToolbar")>] member inline _.ShowToolbar ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowToolbar" =>>> x)
    /// Gets or sets the mode of the editor.
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.HtmlEditorMode) = render ==> ("Mode" => x)
    /// Specifies custom headers that will be submit during uploads.
    [<CustomOperation("UploadHeaders")>] member inline _.UploadHeaders ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.String>) = render ==> ("UploadHeaders" => x)
    /// Gets or sets the input.
    [<CustomOperation("Input")>] member inline _.Input ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("Input", fn)
    /// Gets or sets the input.
    [<CustomOperation("Input")>] member inline _.Input ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("Input", fn)
    /// A callback that will be invoked when the user pastes content in the editor. Commonly used to filter unwanted HTML.
    [<CustomOperation("Paste")>] member inline _.Paste ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.HtmlEditorPasteEventArgs -> unit) = render ==> html.callback("Paste", fn)
    /// A callback that will be invoked when the user pastes content in the editor. Commonly used to filter unwanted HTML.
    [<CustomOperation("Paste")>] member inline _.Paste ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.HtmlEditorPasteEventArgs -> Task<unit>) = render ==> html.callbackTask("Paste", fn)
    /// A callback that will be invoked when there is an error during upload.
    [<CustomOperation("UploadError")>] member inline _.UploadError ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadErrorEventArgs -> unit) = render ==> html.callback("UploadError", fn)
    /// A callback that will be invoked when there is an error during upload.
    [<CustomOperation("UploadError")>] member inline _.UploadError ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadErrorEventArgs -> Task<unit>) = render ==> html.callbackTask("UploadError", fn)
    /// A callback that will be invoked when the user executes a command of the editor (e.g. by clicking one of the tools).
    [<CustomOperation("Execute")>] member inline _.Execute ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.HtmlEditorExecuteEventArgs -> unit) = render ==> html.callback("Execute", fn)
    /// A callback that will be invoked when the user executes a command of the editor (e.g. by clicking one of the tools).
    [<CustomOperation("Execute")>] member inline _.Execute ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.HtmlEditorExecuteEventArgs -> Task<unit>) = render ==> html.callbackTask("Execute", fn)
    /// Specifies the URL to which RadzenHtmlEditor will submit files.
    [<CustomOperation("UploadUrl")>] member inline _.UploadUrl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UploadUrl" => x)
    /// Gets or sets the callback which when a file is uploaded.
    [<CustomOperation("UploadComplete")>] member inline _.UploadComplete ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadCompleteEventArgs -> unit) = render ==> html.callback("UploadComplete", fn)
    /// Gets or sets the callback which when a file is uploaded.
    [<CustomOperation("UploadComplete")>] member inline _.UploadComplete ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadCompleteEventArgs -> Task<unit>) = render ==> html.callbackTask("UploadComplete", fn)

/// RadzenRadioButtonList component.
type RadzenRadioButtonListBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the value property.
    [<CustomOperation("ValueProperty")>] member inline _.ValueProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueProperty" => x)
    /// Gets or sets the text property.
    [<CustomOperation("TextProperty")>] member inline _.TextProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextProperty" => x)
    /// Gets or sets the disabled property.
    [<CustomOperation("DisabledProperty")>] member inline _.DisabledProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledProperty" => x)
    /// Gets or sets the visible property.
    [<CustomOperation("VisibleProperty")>] member inline _.VisibleProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("VisibleProperty" => x)
    /// Gets or sets the data.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.IEnumerable) = render ==> ("Data" => x)
    /// Gets or sets the orientation.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Items", fragment)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Items", fragment { yield! fragments })
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Items", html.text x)

/// RadzenRating component.
type RadzenRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, System.Int32>()
    /// Gets or sets the number of stars.
    [<CustomOperation("Stars")>] member inline _.Stars ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Stars" => x)
    /// Gets or sets the clear aria label text.
    [<CustomOperation("ClearAriaLabel")>] member inline _.ClearAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearAriaLabel" => x)
    /// Gets or sets the rate aria label text.
    [<CustomOperation("RateAriaLabel")>] member inline _.RateAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RateAriaLabel" => x)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)

/// RadzenRating component.
type RadzenSecurityCodeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets the number of input.
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    /// Gets or sets the number of input.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.SecurityCodeType) = render ==> ("Type" => x)
    /// Gets or sets the spacing between inputs
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)

/// RadzenSelectBar component.
type RadzenSelectBarBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, 'TValue>()
    /// Gets or sets the size. Set to ButtonSize.Medium by default.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonSize) = render ==> ("Size" => x)
    /// Gets or sets the orientation. Set to Orientation.Horizontal by default.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the value property.
    [<CustomOperation("ValueProperty")>] member inline _.ValueProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueProperty" => x)
    /// Gets or sets the text property.
    [<CustomOperation("TextProperty")>] member inline _.TextProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextProperty" => x)
    /// Gets or sets the data.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.IEnumerable) = render ==> ("Data" => x)
    /// Gets or sets a value indicating whether this RadzenSelectBar`1 is multiple.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSelectBar`1 is multiple.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Items", fragment)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Items", fragment { yield! fragments })
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Items", html.text x)

/// RadzenSlider component.
type RadzenSliderBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, 'TValue>()
    /// Specifies the orientation. Set to Orientation.Horizontal by default.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Gets or sets the step.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Step" => x)
    /// Gets or sets a value indicating whether this RadzenSlider`1 is range.
    [<CustomOperation("Range")>] member inline _.Range ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Range" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSlider`1 is range.
    [<CustomOperation("Range")>] member inline _.Range ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Range" =>>> x)
    /// Determines the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Decimal) = render ==> ("Min" => x)
    /// Determines the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Decimal) = render ==> ("Max" => x)

/// RadzenSwitch component.
type RadzenSwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, System.Boolean>()
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)

/// RadzenTextArea component.
type RadzenTextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FormComponentBuilder<'FunBlazorGeneric, System.String>()
    /// Gets or sets the maximum length.
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int64>) = render ==> ("MaxLength" => x)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Gets or sets the number of rows.
    [<CustomOperation("Rows")>] member inline _.Rows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Rows" => x)
    /// Gets or sets the number of cols.
    [<CustomOperation("Cols")>] member inline _.Cols ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Cols" => x)

            
namespace rec Radzen.Blazor.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// Base classes of components that support paging.
type PagedDataBoundComponentBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the pager position. Set to PagerPosition.Bottom by default.
    [<CustomOperation("PagerPosition")>] member inline _.PagerPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.PagerPosition) = render ==> ("PagerPosition" => x)
    /// Gets or sets a value indicating whether pager is visible even when not enough data for paging.
    [<CustomOperation("PagerAlwaysVisible")>] member inline _.PagerAlwaysVisible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PagerAlwaysVisible" =>>> true)
    /// Gets or sets a value indicating whether pager is visible even when not enough data for paging.
    [<CustomOperation("PagerAlwaysVisible")>] member inline _.PagerAlwaysVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PagerAlwaysVisible" =>>> x)
    /// Gets or sets the horizontal align.
    [<CustomOperation("PagerHorizontalAlign")>] member inline _.PagerHorizontalAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.HorizontalAlign) = render ==> ("PagerHorizontalAlign" => x)
    /// Gets or sets a value indicating pager density.
    [<CustomOperation("Density")>] member inline _.Density ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Density) = render ==> ("Density" => x)
    /// Gets or sets a value indicating whether paging is allowed. Set to false by default.
    [<CustomOperation("AllowPaging")>] member inline _.AllowPaging ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowPaging" =>>> true)
    /// Gets or sets a value indicating whether paging is allowed. Set to false by default.
    [<CustomOperation("AllowPaging")>] member inline _.AllowPaging ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowPaging" =>>> x)
    /// Gets or sets the size of the page.
    [<CustomOperation("PageSize")>] member inline _.PageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageSize" => x)
    /// Gets or sets the page numbers count.
    [<CustomOperation("PageNumbersCount")>] member inline _.PageNumbersCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageNumbersCount" => x)
    /// Gets or sets the count.
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the loading template.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LoadingTemplate", fragment)
    /// Gets or sets the loading template.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LoadingTemplate", fragment { yield! fragments })
    /// Gets or sets the loading template.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the loading template.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the loading template.
    [<CustomOperation("LoadingTemplate")>] member inline _.LoadingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingTemplate", html.text x)
    /// Gets or sets the data.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Data" => x)
    /// Gets or sets the page size options.
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.Int32>) = render ==> ("PageSizeOptions" => x)
    /// Gets or sets the page size description text.
    [<CustomOperation("PageSizeText")>] member inline _.PageSizeText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PageSizeText" => x)
    /// Gets or sets the pager summary visibility.
    [<CustomOperation("ShowPagingSummary")>] member inline _.ShowPagingSummary ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowPagingSummary" =>>> true)
    /// Gets or sets the pager summary visibility.
    [<CustomOperation("ShowPagingSummary")>] member inline _.ShowPagingSummary ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowPagingSummary" =>>> x)
    /// Gets or sets the pager summary format.
    [<CustomOperation("PagingSummaryFormat")>] member inline _.PagingSummaryFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PagingSummaryFormat" => x)
    /// Gets or sets the pager summary template.
    [<CustomOperation("PagingSummaryTemplate")>] member inline _.PagingSummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.PagingInformation -> NodeRenderFragment) = render ==> html.renderFragment("PagingSummaryTemplate", fn)
    /// Gets or sets the pager's first page button's title attribute.
    [<CustomOperation("FirstPageTitle")>] member inline _.FirstPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstPageTitle" => x)
    /// Gets or sets the pager's first page button's aria-label attribute.
    [<CustomOperation("FirstPageAriaLabel")>] member inline _.FirstPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstPageAriaLabel" => x)
    /// Gets or sets the pager's optional previous page button's label text.
    [<CustomOperation("PrevPageLabel")>] member inline _.PrevPageLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevPageLabel" => x)
    /// Gets or sets the pager's previous page button's title attribute.
    [<CustomOperation("PrevPageTitle")>] member inline _.PrevPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevPageTitle" => x)
    /// Gets or sets the pager's previous page button's aria-label attribute.
    [<CustomOperation("PrevPageAriaLabel")>] member inline _.PrevPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevPageAriaLabel" => x)
    /// Gets or sets the pager's last page button's title attribute.
    [<CustomOperation("LastPageTitle")>] member inline _.LastPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastPageTitle" => x)
    /// Gets or sets the pager's last page button's aria-label attribute.
    [<CustomOperation("LastPageAriaLabel")>] member inline _.LastPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastPageAriaLabel" => x)
    /// Gets or sets the pager's optional next page button's label text.
    [<CustomOperation("NextPageLabel")>] member inline _.NextPageLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextPageLabel" => x)
    /// Gets or sets the pager's next page button's title attribute.
    [<CustomOperation("NextPageTitle")>] member inline _.NextPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextPageTitle" => x)
    /// Gets or sets the pager's next page button's aria-label attribute.
    [<CustomOperation("NextPageAriaLabel")>] member inline _.NextPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextPageAriaLabel" => x)
    /// Gets or sets the pager's numeric page number buttons' title attributes.
    [<CustomOperation("PageTitleFormat")>] member inline _.PageTitleFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PageTitleFormat" => x)
    /// Gets or sets the pager's numeric page number buttons' aria-label attributes.
    [<CustomOperation("PageAriaLabelFormat")>] member inline _.PageAriaLabelFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PageAriaLabelFormat" => x)
    /// Gets or sets the load data.
    [<CustomOperation("LoadData")>] member inline _.LoadData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.LoadDataArgs -> unit) = render ==> html.callback("LoadData", fn)
    /// Gets or sets the load data.
    [<CustomOperation("LoadData")>] member inline _.LoadData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.LoadDataArgs -> Task<unit>) = render ==> html.callbackTask("LoadData", fn)
    /// Gets or sets the page callback.
    [<CustomOperation("Page")>] member inline _.Page ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.PagerEventArgs -> unit) = render ==> html.callback("Page", fn)
    /// Gets or sets the page callback.
    [<CustomOperation("Page")>] member inline _.Page ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.PagerEventArgs -> Task<unit>) = render ==> html.callbackTask("Page", fn)

            
namespace rec Radzen.Blazor.DslInternals.Blazor

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// RadzenDataGrid component.
type RadzenDataGridBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit PagedDataBoundComponentBuilder<'FunBlazorGeneric, 'TItem>()
    /// Gets or sets a value indicating whether this instance is virtualized.
    [<CustomOperation("AllowVirtualization")>] member inline _.AllowVirtualization ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowVirtualization" =>>> true)
    /// Gets or sets a value indicating whether this instance is virtualized.
    [<CustomOperation("AllowVirtualization")>] member inline _.AllowVirtualization ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowVirtualization" =>>> x)
    /// Gets or sets a value that determines how many additional items will be rendered before and after the visible region. This help to reduce the frequency of rendering during scrolling. However, higher values mean that more elements will be present in the page.
    [<CustomOperation("VirtualizationOverscanCount")>] member inline _.VirtualizationOverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VirtualizationOverscanCount" => x)
    /// Gets or sets the callback used to load column filter data for DataGrid FilterMode.CheckBoxList filter mode.
    [<CustomOperation("LoadColumnFilterData")>] member inline _.LoadColumnFilterData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridLoadColumnFilterDataEventArgs<'TItem> -> unit) = render ==> html.callback("LoadColumnFilterData", fn)
    /// Gets or sets the callback used to load column filter data for DataGrid FilterMode.CheckBoxList filter mode.
    [<CustomOperation("LoadColumnFilterData")>] member inline _.LoadColumnFilterData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridLoadColumnFilterDataEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("LoadColumnFilterData", fn)
    /// Gets or sets the load child data callback.
    [<CustomOperation("LoadChildData")>] member inline _.LoadChildData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridLoadChildDataEventArgs<'TItem> -> unit) = render ==> html.callback("LoadChildData", fn)
    /// Gets or sets the load child data callback.
    [<CustomOperation("LoadChildData")>] member inline _.LoadChildData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridLoadChildDataEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("LoadChildData", fn)
    /// Gets or sets the expand child item aria label text.
    [<CustomOperation("ExpandChildItemAriaLabel")>] member inline _.ExpandChildItemAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandChildItemAriaLabel" => x)
    /// Gets or sets the expand group aria label text.
    [<CustomOperation("ExpandGroupAriaLabel")>] member inline _.ExpandGroupAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandGroupAriaLabel" => x)
    /// Gets or sets the date simple filter toggle aria label text.
    [<CustomOperation("FilterToggleAriaLabel")>] member inline _.FilterToggleAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterToggleAriaLabel" => x)
    /// Gets or sets a value indicating whether DataGrid data cells will follow the header cells structure in composite columns.
    [<CustomOperation("AllowCompositeDataCells")>] member inline _.AllowCompositeDataCells ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowCompositeDataCells" =>>> true)
    /// Gets or sets a value indicating whether DataGrid data cells will follow the header cells structure in composite columns.
    [<CustomOperation("AllowCompositeDataCells")>] member inline _.AllowCompositeDataCells ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowCompositeDataCells" =>>> x)
    /// Gets or sets a value indicating whether DataGrid data body show empty message.
    [<CustomOperation("ShowEmptyMessage")>] member inline _.ShowEmptyMessage ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowEmptyMessage" =>>> true)
    /// Gets or sets a value indicating whether DataGrid data body show empty message.
    [<CustomOperation("ShowEmptyMessage")>] member inline _.ShowEmptyMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowEmptyMessage" =>>> x)
    /// Gets or sets value if headers are shown.
    [<CustomOperation("ShowHeader")>] member inline _.ShowHeader ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowHeader" =>>> true)
    /// Gets or sets value if headers are shown.
    [<CustomOperation("ShowHeader")>] member inline _.ShowHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowHeader" =>>> x)
    /// Gets or sets a value indicating whether DataGrid is responsive.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Responsive" =>>> true)
    /// Gets or sets a value indicating whether DataGrid is responsive.
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Responsive" =>>> x)
    /// Allows to define a custom function for enums DisplayAttribute Description property value translation in datagrid
    /// Enum filters.
    [<CustomOperation("EnumFilterTranslationFunc")>] member inline _.EnumFilterTranslationFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("EnumFilterTranslationFunc" => (System.Func<System.String, System.String>fn))
    /// Gets or sets the column group callback.
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnGroupEventArgs<'TItem> -> unit) = render ==> html.callback("Group", fn)
    /// Gets or sets the column group callback.
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnGroupEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("Group", fn)
    /// Gets or sets key down callback.
    [<CustomOperation("KeyDown")>] member inline _.KeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("KeyDown", fn)
    /// Gets or sets key down callback.
    [<CustomOperation("KeyDown")>] member inline _.KeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("KeyDown", fn)
    /// Gives the grid a custom header, allowing the adding of components to create custom tool bars in addtion to column grouping and column picker
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    /// Gives the grid a custom header, allowing the adding of components to create custom tool bars in addtion to column grouping and column picker
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    /// Gives the grid a custom header, allowing the adding of components to create custom tool bars in addtion to column grouping and column picker
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gives the grid a custom header, allowing the adding of components to create custom tool bars in addtion to column grouping and column picker
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gives the grid a custom header, allowing the adding of components to create custom tool bars in addtion to column grouping and column picker
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gives the grid a custom footer, allowing the adding of components to create custom tool bars or custom pagination
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    /// Gives the grid a custom footer, allowing the adding of components to create custom tool bars or custom pagination
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    /// Gives the grid a custom footer, allowing the adding of components to create custom tool bars or custom pagination
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gives the grid a custom footer, allowing the adding of components to create custom tool bars or custom pagination
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gives the grid a custom footer, allowing the adding of components to create custom tool bars or custom pagination
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Columns", fragment)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Columns", fragment { yield! fragments })
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Columns", html.text x)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Columns", html.text x)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Columns", html.text x)
    /// Gets or sets the picked columns changed callback.
    [<CustomOperation("PickedColumnsChanged")>] member inline _.PickedColumnsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridPickedColumnsChangedEventArgs<'TItem> -> unit) = render ==> html.callback("PickedColumnsChanged", fn)
    /// Gets or sets the picked columns changed callback.
    [<CustomOperation("PickedColumnsChanged")>] member inline _.PickedColumnsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridPickedColumnsChangedEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("PickedColumnsChanged", fn)
    /// Gets or sets the column sort callback.
    [<CustomOperation("Sort")>] member inline _.Sort ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnSortEventArgs<'TItem> -> unit) = render ==> html.callback("Sort", fn)
    /// Gets or sets the column sort callback.
    [<CustomOperation("Sort")>] member inline _.Sort ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnSortEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("Sort", fn)
    /// Gets or sets the column filter callback.
    [<CustomOperation("Filter")>] member inline _.Filter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnFilterEventArgs<'TItem> -> unit) = render ==> html.callback("Filter", fn)
    /// Gets or sets the column filter callback.
    [<CustomOperation("Filter")>] member inline _.Filter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnFilterEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("Filter", fn)
    /// Gets or sets the column filter cleared callback.
    [<CustomOperation("FilterCleared")>] member inline _.FilterCleared ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnFilterEventArgs<'TItem> -> unit) = render ==> html.callback("FilterCleared", fn)
    /// Gets or sets the column filter cleared callback.
    [<CustomOperation("FilterCleared")>] member inline _.FilterCleared ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnFilterEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("FilterCleared", fn)
    /// Gets or sets the render mode.
    [<CustomOperation("FilterPopupRenderMode")>] member inline _.FilterPopupRenderMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.PopupRenderMode) = render ==> ("FilterPopupRenderMode" => x)
    /// Gets or sets the logical filter operator.
    [<CustomOperation("LogicalFilterOperator")>] member inline _.LogicalFilterOperator ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.LogicalFilterOperator) = render ==> ("LogicalFilterOperator" => x)
    /// Gets or sets the filter mode.
    [<CustomOperation("FilterMode")>] member inline _.FilterMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FilterMode) = render ==> ("FilterMode" => x)
    /// Gets or sets the expand mode.
    [<CustomOperation("ExpandMode")>] member inline _.ExpandMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.DataGridExpandMode) = render ==> ("ExpandMode" => x)
    /// Gets or sets whether the expandable indicator column is visible.
    [<CustomOperation("ShowExpandColumn")>] member inline _.ShowExpandColumn ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowExpandColumn" =>>> true)
    /// Gets or sets whether the expandable indicator column is visible.
    [<CustomOperation("ShowExpandColumn")>] member inline _.ShowExpandColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowExpandColumn" =>>> x)
    /// Gets or sets the edit mode.
    [<CustomOperation("EditMode")>] member inline _.EditMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.DataGridEditMode) = render ==> ("EditMode" => x)
    /// Gets or set the filter icon to use.
    [<CustomOperation("FilterIcon")>] member inline _.FilterIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterIcon" => x)
    /// Gets or sets the filter text.
    [<CustomOperation("FilterText")>] member inline _.FilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterText" => x)
    /// Gets or sets the enum filter select text.
    [<CustomOperation("EnumFilterSelectText")>] member inline _.EnumFilterSelectText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EnumFilterSelectText" => x)
    /// Gets or sets the nullable enum for null value filter text.
    [<CustomOperation("EnumNullFilterText")>] member inline _.EnumNullFilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EnumNullFilterText" => x)
    /// Gets or sets the and operator text.
    [<CustomOperation("AndOperatorText")>] member inline _.AndOperatorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AndOperatorText" => x)
    /// Gets or sets the or operator text.
    [<CustomOperation("OrOperatorText")>] member inline _.OrOperatorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OrOperatorText" => x)
    /// Gets or sets the apply filter text.
    [<CustomOperation("ApplyFilterText")>] member inline _.ApplyFilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ApplyFilterText" => x)
    /// Gets or sets the clear filter text.
    [<CustomOperation("ClearFilterText")>] member inline _.ClearFilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearFilterText" => x)
    /// Gets or sets the equals text.
    [<CustomOperation("EqualsText")>] member inline _.EqualsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EqualsText" => x)
    /// Gets or sets the not equals text.
    [<CustomOperation("NotEqualsText")>] member inline _.NotEqualsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NotEqualsText" => x)
    /// Gets or sets the less than text.
    [<CustomOperation("LessThanText")>] member inline _.LessThanText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LessThanText" => x)
    /// Gets or sets the less than or equals text.
    [<CustomOperation("LessThanOrEqualsText")>] member inline _.LessThanOrEqualsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LessThanOrEqualsText" => x)
    /// Gets or sets the greater than text.
    [<CustomOperation("GreaterThanText")>] member inline _.GreaterThanText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GreaterThanText" => x)
    /// Gets or sets the greater than or equals text.
    [<CustomOperation("GreaterThanOrEqualsText")>] member inline _.GreaterThanOrEqualsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GreaterThanOrEqualsText" => x)
    /// Gets or sets the ends with text.
    [<CustomOperation("EndsWithText")>] member inline _.EndsWithText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndsWithText" => x)
    /// Gets or sets the contains text.
    [<CustomOperation("ContainsText")>] member inline _.ContainsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContainsText" => x)
    /// Gets or sets the does not contain text.
    [<CustomOperation("DoesNotContainText")>] member inline _.DoesNotContainText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DoesNotContainText" => x)
    /// Gets or sets the in operator text.
    [<CustomOperation("InText")>] member inline _.InText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InText" => x)
    /// Gets or sets the not in operator text.
    [<CustomOperation("NotInText")>] member inline _.NotInText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NotInText" => x)
    /// Gets or sets the starts with text.
    [<CustomOperation("StartsWithText")>] member inline _.StartsWithText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartsWithText" => x)
    /// Gets or sets the not null text.
    [<CustomOperation("IsNotNullText")>] member inline _.IsNotNullText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IsNotNullText" => x)
    /// Gets or sets the is null text.
    [<CustomOperation("IsNullText")>] member inline _.IsNullText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IsNullText" => x)
    /// Gets or sets the is empty text.
    [<CustomOperation("IsEmptyText")>] member inline _.IsEmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IsEmptyText" => x)
    /// Gets or sets the is not empty text.
    [<CustomOperation("IsNotEmptyText")>] member inline _.IsNotEmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IsNotEmptyText" => x)
    /// Gets or sets the custom filter operator text.
    [<CustomOperation("CustomText")>] member inline _.CustomText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomText" => x)
    /// Gets or sets the filter case sensitivity.
    [<CustomOperation("FilterCaseSensitivity")>] member inline _.FilterCaseSensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FilterCaseSensitivity) = render ==> ("FilterCaseSensitivity" => x)
    /// Gets or sets the filter delay.
    [<CustomOperation("FilterDelay")>] member inline _.FilterDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("FilterDelay" => x)
    /// Gets or sets the filter date format.
    [<CustomOperation("FilterDateFormat")>] member inline _.FilterDateFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterDateFormat" => x)
    /// Gets or sets a value indicating whether input is allowed in filter DatePicker.
    [<CustomOperation("AllowFilterDateInput")>] member inline _.AllowFilterDateInput ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowFilterDateInput" =>>> true)
    /// Gets or sets a value indicating whether input is allowed in filter DatePicker.
    [<CustomOperation("AllowFilterDateInput")>] member inline _.AllowFilterDateInput ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowFilterDateInput" =>>> x)
    /// Gets or sets the width of all columns.
    [<CustomOperation("ColumnWidth")>] member inline _.ColumnWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ColumnWidth" => x)
    /// Gets or sets the empty text shown when Data is empty collection.
    [<CustomOperation("EmptyText")>] member inline _.EmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EmptyText" => x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("EmptyTemplate", fragment)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("EmptyTemplate", fragment { yield! fragments })
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the edit template.
    [<CustomOperation("EditTemplate")>] member inline _.EditTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    /// Gets or sets a value indicating whether this instance loading indicator is shown.
    [<CustomOperation("IsLoading")>] member inline _.IsLoading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsLoading" =>>> true)
    /// Gets or sets a value indicating whether this instance loading indicator is shown.
    [<CustomOperation("IsLoading")>] member inline _.IsLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsLoading" =>>> x)
    /// Gets or sets a value indicating whether sorting is allowed.
    [<CustomOperation("AllowSorting")>] member inline _.AllowSorting ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowSorting" =>>> true)
    /// Gets or sets a value indicating whether sorting is allowed.
    [<CustomOperation("AllowSorting")>] member inline _.AllowSorting ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowSorting" =>>> x)
    /// Gets or sets a value indicating whether multi column sorting is allowed.
    [<CustomOperation("AllowMultiColumnSorting")>] member inline _.AllowMultiColumnSorting ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowMultiColumnSorting" =>>> true)
    /// Gets or sets a value indicating whether multi column sorting is allowed.
    [<CustomOperation("AllowMultiColumnSorting")>] member inline _.AllowMultiColumnSorting ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowMultiColumnSorting" =>>> x)
    /// Gets or sets a value indicating whether multi column sorting index is shown.
    [<CustomOperation("ShowMultiColumnSortingIndex")>] member inline _.ShowMultiColumnSortingIndex ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowMultiColumnSortingIndex" =>>> true)
    /// Gets or sets a value indicating whether multi column sorting index is shown.
    [<CustomOperation("ShowMultiColumnSortingIndex")>] member inline _.ShowMultiColumnSortingIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowMultiColumnSortingIndex" =>>> x)
    /// Gets or sets a value indicating whether filtering is allowed.
    [<CustomOperation("AllowFiltering")>] member inline _.AllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowFiltering" =>>> true)
    /// Gets or sets a value indicating whether filtering is allowed.
    [<CustomOperation("AllowFiltering")>] member inline _.AllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowFiltering" =>>> x)
    /// Gets or sets a value indicating whether column resizing is allowed.
    [<CustomOperation("AllowColumnResize")>] member inline _.AllowColumnResize ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowColumnResize" =>>> true)
    /// Gets or sets a value indicating whether column resizing is allowed.
    [<CustomOperation("AllowColumnResize")>] member inline _.AllowColumnResize ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowColumnResize" =>>> x)
    /// Gets or sets a value indicating whether column reorder is allowed.
    [<CustomOperation("AllowColumnReorder")>] member inline _.AllowColumnReorder ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowColumnReorder" =>>> true)
    /// Gets or sets a value indicating whether column reorder is allowed.
    [<CustomOperation("AllowColumnReorder")>] member inline _.AllowColumnReorder ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowColumnReorder" =>>> x)
    /// Gets or sets a value indicating whether column picking is allowed.
    [<CustomOperation("AllowColumnPicking")>] member inline _.AllowColumnPicking ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowColumnPicking" =>>> true)
    /// Gets or sets a value indicating whether column picking is allowed.
    [<CustomOperation("AllowColumnPicking")>] member inline _.AllowColumnPicking ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowColumnPicking" =>>> x)
    /// Gets or sets a value indicating whether cell data should be shown as tooltip.
    [<CustomOperation("ShowCellDataAsTooltip")>] member inline _.ShowCellDataAsTooltip ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowCellDataAsTooltip" =>>> true)
    /// Gets or sets a value indicating whether cell data should be shown as tooltip.
    [<CustomOperation("ShowCellDataAsTooltip")>] member inline _.ShowCellDataAsTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowCellDataAsTooltip" =>>> x)
    /// Gets or sets a value indicating whether column title should be shown as tooltip.
    [<CustomOperation("ShowColumnTitleAsTooltip")>] member inline _.ShowColumnTitleAsTooltip ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowColumnTitleAsTooltip" =>>> true)
    /// Gets or sets a value indicating whether column title should be shown as tooltip.
    [<CustomOperation("ShowColumnTitleAsTooltip")>] member inline _.ShowColumnTitleAsTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowColumnTitleAsTooltip" =>>> x)
    /// Gets or sets the column picker columns showing text.
    [<CustomOperation("ColumnsShowingText")>] member inline _.ColumnsShowingText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ColumnsShowingText" => x)
    /// Gets or sets the column picker max selected labels.
    [<CustomOperation("ColumnsPickerMaxSelectedLabels")>] member inline _.ColumnsPickerMaxSelectedLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ColumnsPickerMaxSelectedLabels" => x)
    /// Gets or sets the column picker all columns text.
    [<CustomOperation("AllColumnsText")>] member inline _.AllColumnsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AllColumnsText" => x)
    /// Gets or sets the column picker columns text.
    [<CustomOperation("ColumnsText")>] member inline _.ColumnsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ColumnsText" => x)
    /// Gets or sets the remove group button aria label text.
    [<CustomOperation("RemoveGroupAriaLabel")>] member inline _.RemoveGroupAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RemoveGroupAriaLabel" => x)
    /// Gets or sets the select visible columns aria label text.
    [<CustomOperation("SelectVisibleColumnsAriaLabel")>] member inline _.SelectVisibleColumnsAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectVisibleColumnsAriaLabel" => x)
    /// Gets or sets the column logical filter value aria label text.
    [<CustomOperation("LogicalOperatorAriaLabel")>] member inline _.LogicalOperatorAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LogicalOperatorAriaLabel" => x)
    /// Gets or sets the column filter value aria label text.
    [<CustomOperation("FilterOperatorAriaLabel")>] member inline _.FilterOperatorAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterOperatorAriaLabel" => x)
    /// Gets or sets the column filter value aria label text.
    [<CustomOperation("SecondFilterOperatorAriaLabel")>] member inline _.SecondFilterOperatorAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SecondFilterOperatorAriaLabel" => x)
    /// Gets or sets the column filter value aria label text.
    [<CustomOperation("FilterValueAriaLabel")>] member inline _.FilterValueAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterValueAriaLabel" => x)
    /// Gets or sets the column filter value aria label text.
    [<CustomOperation("SecondFilterValueAriaLabel")>] member inline _.SecondFilterValueAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SecondFilterValueAriaLabel" => x)
    /// Gets or sets a value indicating whether user can pick all columns in column picker.
    [<CustomOperation("AllowPickAllColumns")>] member inline _.AllowPickAllColumns ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowPickAllColumns" =>>> true)
    /// Gets or sets a value indicating whether user can pick all columns in column picker.
    [<CustomOperation("AllowPickAllColumns")>] member inline _.AllowPickAllColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowPickAllColumns" =>>> x)
    /// Gets or sets a value indicating whether user can filter columns in column picker.
    [<CustomOperation("ColumnsPickerAllowFiltering")>] member inline _.ColumnsPickerAllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ColumnsPickerAllowFiltering" =>>> true)
    /// Gets or sets a value indicating whether user can filter columns in column picker.
    [<CustomOperation("ColumnsPickerAllowFiltering")>] member inline _.ColumnsPickerAllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ColumnsPickerAllowFiltering" =>>> x)
    /// Gets or sets a value indicating whether grouping is allowed.
    [<CustomOperation("AllowGrouping")>] member inline _.AllowGrouping ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowGrouping" =>>> true)
    /// Gets or sets a value indicating whether grouping is allowed.
    [<CustomOperation("AllowGrouping")>] member inline _.AllowGrouping ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowGrouping" =>>> x)
    /// Gets or sets a value indicating whether grouped column should be hidden.
    [<CustomOperation("HideGroupedColumn")>] member inline _.HideGroupedColumn ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideGroupedColumn" =>>> true)
    /// Gets or sets a value indicating whether grouped column should be hidden.
    [<CustomOperation("HideGroupedColumn")>] member inline _.HideGroupedColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideGroupedColumn" =>>> x)
    /// Gets or sets a value indicating whether group footers are visible even when the group is collapsed.
    [<CustomOperation("GroupFootersAlwaysVisible")>] member inline _.GroupFootersAlwaysVisible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GroupFootersAlwaysVisible" =>>> true)
    /// Gets or sets a value indicating whether group footers are visible even when the group is collapsed.
    [<CustomOperation("GroupFootersAlwaysVisible")>] member inline _.GroupFootersAlwaysVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GroupFootersAlwaysVisible" =>>> x)
    /// Gets or sets the group header template.
    [<CustomOperation("GroupHeaderTemplate")>] member inline _.GroupHeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Group -> NodeRenderFragment) = render ==> html.renderFragment("GroupHeaderTemplate", fn)
    /// Gets or sets the group header with option to add custom toggle visibility button template.
    [<CustomOperation("GroupHeaderToggleTemplate")>] member inline _.GroupHeaderToggleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Radzen.Group, Radzen.Blazor.RadzenDataGridGroupRow<'TItem>> -> NodeRenderFragment) = render ==> html.renderFragment("GroupHeaderToggleTemplate", fn)
    /// Gets or sets the group panel text.
    [<CustomOperation("GroupPanelText")>] member inline _.GroupPanelText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupPanelText" => x)
    /// Gets or sets the column resized callback.
    [<CustomOperation("ColumnResized")>] member inline _.ColumnResized ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnResizedEventArgs<'TItem> -> unit) = render ==> html.callback("ColumnResized", fn)
    /// Gets or sets the column resized callback.
    [<CustomOperation("ColumnResized")>] member inline _.ColumnResized ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnResizedEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("ColumnResized", fn)
    /// Gets or sets the column reordering callback.
    [<CustomOperation("ColumnReordering")>] member inline _.ColumnReordering ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnReorderingEventArgs<'TItem> -> unit) = render ==> html.callback("ColumnReordering", fn)
    /// Gets or sets the column reordering callback.
    [<CustomOperation("ColumnReordering")>] member inline _.ColumnReordering ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnReorderingEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("ColumnReordering", fn)
    /// Gets or sets the column reordered callback.
    [<CustomOperation("ColumnReordered")>] member inline _.ColumnReordered ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnReorderedEventArgs<'TItem> -> unit) = render ==> html.callback("ColumnReordered", fn)
    /// Gets or sets the column reordered callback.
    [<CustomOperation("ColumnReordered")>] member inline _.ColumnReordered ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridColumnReorderedEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("ColumnReordered", fn)
    /// Gets or sets the selected item.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<'TItem>) = render ==> ("Value" => x)
    /// Gets or sets the selected item.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IList<'TItem> * (System.Collections.Generic.IList<'TItem> -> unit)) = render ==> html.bind("Value", valueFn)
    /// Gets or sets the value changed callback.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IList<'TItem> -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Gets or sets the value changed callback.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IList<'TItem> -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Gets or sets the row select callback.
    [<CustomOperation("RowSelect")>] member inline _.RowSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> unit) = render ==> html.callback("RowSelect", fn)
    /// Gets or sets the row select callback.
    [<CustomOperation("RowSelect")>] member inline _.RowSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("RowSelect", fn)
    /// Gets or sets the row deselect callback.
    [<CustomOperation("RowDeselect")>] member inline _.RowDeselect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> unit) = render ==> html.callback("RowDeselect", fn)
    /// Gets or sets the row deselect callback.
    [<CustomOperation("RowDeselect")>] member inline _.RowDeselect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("RowDeselect", fn)
    /// Gets or sets the row click callback.
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridRowMouseEventArgs<'TItem> -> unit) = render ==> html.callback("RowClick", fn)
    /// Gets or sets the row click callback.
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridRowMouseEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("RowClick", fn)
    /// Gets or sets the row double click callback.
    [<CustomOperation("RowDoubleClick")>] member inline _.RowDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridRowMouseEventArgs<'TItem> -> unit) = render ==> html.callback("RowDoubleClick", fn)
    /// Gets or sets the row double click callback.
    [<CustomOperation("RowDoubleClick")>] member inline _.RowDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridRowMouseEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("RowDoubleClick", fn)
    /// Gets or sets the cell click callback.
    [<CustomOperation("CellClick")>] member inline _.CellClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridCellMouseEventArgs<'TItem> -> unit) = render ==> html.callback("CellClick", fn)
    /// Gets or sets the cell click callback.
    [<CustomOperation("CellClick")>] member inline _.CellClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridCellMouseEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("CellClick", fn)
    /// Gets or sets the cell double click callback.
    [<CustomOperation("CellDoubleClick")>] member inline _.CellDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridCellMouseEventArgs<'TItem> -> unit) = render ==> html.callback("CellDoubleClick", fn)
    /// Gets or sets the cell double click callback.
    [<CustomOperation("CellDoubleClick")>] member inline _.CellDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridCellMouseEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("CellDoubleClick", fn)
    /// Gets or sets the row click callback.
    [<CustomOperation("CellContextMenu")>] member inline _.CellContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridCellMouseEventArgs<'TItem> -> unit) = render ==> html.callback("CellContextMenu", fn)
    /// Gets or sets the row click callback.
    [<CustomOperation("CellContextMenu")>] member inline _.CellContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridCellMouseEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("CellContextMenu", fn)
    /// Gets or sets the row expand callback.
    [<CustomOperation("RowExpand")>] member inline _.RowExpand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> unit) = render ==> html.callback("RowExpand", fn)
    /// Gets or sets the row expand callback.
    [<CustomOperation("RowExpand")>] member inline _.RowExpand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("RowExpand", fn)
    /// Gets or sets the group row expand callback.
    [<CustomOperation("GroupRowExpand")>] member inline _.GroupRowExpand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Group -> unit) = render ==> html.callback("GroupRowExpand", fn)
    /// Gets or sets the group row expand callback.
    [<CustomOperation("GroupRowExpand")>] member inline _.GroupRowExpand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Group -> Task<unit>) = render ==> html.callbackTask("GroupRowExpand", fn)
    /// Gets or sets the row collapse callback.
    [<CustomOperation("RowCollapse")>] member inline _.RowCollapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> unit) = render ==> html.callback("RowCollapse", fn)
    /// Gets or sets the row collapse callback.
    [<CustomOperation("RowCollapse")>] member inline _.RowCollapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("RowCollapse", fn)
    /// Gets or sets the group row collapse callback.
    [<CustomOperation("GroupRowCollapse")>] member inline _.GroupRowCollapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Group -> unit) = render ==> html.callback("GroupRowCollapse", fn)
    /// Gets or sets the group row collapse callback.
    [<CustomOperation("GroupRowCollapse")>] member inline _.GroupRowCollapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Group -> Task<unit>) = render ==> html.callbackTask("GroupRowCollapse", fn)
    /// Gets or sets the row render callback. Use it to set row attributes.
    [<CustomOperation("RowRender")>] member inline _.RowRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowRender" => (System.Action<Radzen.RowRenderEventArgs<'TItem>>fn))
    /// Gets or sets the group row render callback. Use it to set group row attributes.
    [<CustomOperation("GroupRowRender")>] member inline _.GroupRowRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupRowRender" => (System.Action<Radzen.GroupRowRenderEventArgs>fn))
    /// Gets or sets the cell render callback. Use it to set cell attributes.
    [<CustomOperation("CellRender")>] member inline _.CellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CellRender" => (System.Action<Radzen.DataGridCellRenderEventArgs<'TItem>>fn))
    /// Gets or sets the header cell render callback. Use it to set header cell attributes.
    [<CustomOperation("HeaderCellRender")>] member inline _.HeaderCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderCellRender" => (System.Action<Radzen.DataGridCellRenderEventArgs<'TItem>>fn))
    /// Gets or sets the footer cell render callback. Use it to set footer cell attributes.
    [<CustomOperation("FooterCellRender")>] member inline _.FooterCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FooterCellRender" => (System.Action<Radzen.DataGridCellRenderEventArgs<'TItem>>fn))
    /// Gets or sets the render callback.
    [<CustomOperation("Render")>] member inline _.Render ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Render" => (System.Action<Radzen.DataGridRenderEventArgs<'TItem>>fn))
    /// Gets or sets the render async callback.
    [<CustomOperation("RenderAsync")>] member inline _.RenderAsync ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RenderAsync" => (System.Func<Radzen.DataGridRenderEventArgs<'TItem>, System.Threading.Tasks.Task>fn))
    /// Gets or sets the load settings callback.
    [<CustomOperation("LoadSettings")>] member inline _.LoadSettings ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("LoadSettings" => (System.Action<Radzen.DataGridLoadSettingsEventArgs>fn))
    /// Gets or sets a value indicating whether all groups should be expanded when DataGrid is grouped.
    [<CustomOperation("AllGroupsExpanded")>] member inline _.AllGroupsExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("AllGroupsExpanded" => x)
    /// Gets or sets a value indicating whether all groups should be expanded when DataGrid is grouped.
    [<CustomOperation("AllGroupsExpanded'")>] member inline _.AllGroupsExpanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.Boolean> * (System.Nullable<System.Boolean> -> unit)) = render ==> html.bind("AllGroupsExpanded", valueFn)
    /// Gets or sets the AllGroupsExpanded changed callback.
    [<CustomOperation("AllGroupsExpandedChanged")>] member inline _.AllGroupsExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Boolean> -> unit) = render ==> html.callback("AllGroupsExpandedChanged", fn)
    /// Gets or sets the AllGroupsExpanded changed callback.
    [<CustomOperation("AllGroupsExpandedChanged")>] member inline _.AllGroupsExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Boolean> -> Task<unit>) = render ==> html.callbackTask("AllGroupsExpandedChanged", fn)
    /// Gets or sets the key property.
    [<CustomOperation("KeyProperty")>] member inline _.KeyProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("KeyProperty" => x)
    /// Gets or sets a value indicating whether DataGrid row can be selected on row click.
    [<CustomOperation("AllowRowSelectOnRowClick")>] member inline _.AllowRowSelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowRowSelectOnRowClick" =>>> true)
    /// Gets or sets a value indicating whether DataGrid row can be selected on row click.
    [<CustomOperation("AllowRowSelectOnRowClick")>] member inline _.AllowRowSelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowRowSelectOnRowClick" =>>> x)
    /// Gets or sets a value indicating whether DataGrid should use alternating row styles.
    [<CustomOperation("AllowAlternatingRows")>] member inline _.AllowAlternatingRows ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowAlternatingRows" =>>> true)
    /// Gets or sets a value indicating whether DataGrid should use alternating row styles.
    [<CustomOperation("AllowAlternatingRows")>] member inline _.AllowAlternatingRows ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowAlternatingRows" =>>> x)
    /// Gets or sets a value indicating whether to show group visibility column
    [<CustomOperation("ShowGroupExpandColumn")>] member inline _.ShowGroupExpandColumn ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowGroupExpandColumn" =>>> true)
    /// Gets or sets a value indicating whether to show group visibility column
    [<CustomOperation("ShowGroupExpandColumn")>] member inline _.ShowGroupExpandColumn ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowGroupExpandColumn" =>>> x)
    /// Gets or sets the grid lines.
    [<CustomOperation("GridLines")>] member inline _.GridLines ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.DataGridGridLines) = render ==> ("GridLines" => x)
    /// Gets or sets the ability to automatically goto the first page when sorting is changed.
    [<CustomOperation("GotoFirstPageOnSort")>] member inline _.GotoFirstPageOnSort ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GotoFirstPageOnSort" =>>> true)
    /// Gets or sets the ability to automatically goto the first page when sorting is changed.
    [<CustomOperation("GotoFirstPageOnSort")>] member inline _.GotoFirstPageOnSort ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GotoFirstPageOnSort" =>>> x)
    /// Gets or sets the selection mode.
    [<CustomOperation("SelectionMode")>] member inline _.SelectionMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.DataGridSelectionMode) = render ==> ("SelectionMode" => x)
    /// Gets or sets the row edit callback.
    [<CustomOperation("RowEdit")>] member inline _.RowEdit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> unit) = render ==> html.callback("RowEdit", fn)
    /// Gets or sets the row edit callback.
    [<CustomOperation("RowEdit")>] member inline _.RowEdit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("RowEdit", fn)
    /// Gets or sets the row update callback.
    [<CustomOperation("RowUpdate")>] member inline _.RowUpdate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> unit) = render ==> html.callback("RowUpdate", fn)
    /// Gets or sets the row update callback.
    [<CustomOperation("RowUpdate")>] member inline _.RowUpdate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("RowUpdate", fn)
    /// Gets or sets the row create callback.
    [<CustomOperation("RowCreate")>] member inline _.RowCreate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> unit) = render ==> html.callback("RowCreate", fn)
    /// Gets or sets the row create callback.
    [<CustomOperation("RowCreate")>] member inline _.RowCreate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("RowCreate", fn)
    /// Gets or sets the page size changed callback.
    [<CustomOperation("PageSizeChanged")>] member inline _.PageSizeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("PageSizeChanged", fn)
    /// Gets or sets the page size changed callback.
    [<CustomOperation("PageSizeChanged")>] member inline _.PageSizeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("PageSizeChanged", fn)
    /// Gets or sets DataGrid settings.
    [<CustomOperation("Settings")>] member inline _.Settings ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.DataGridSettings) = render ==> ("Settings" => x)
    /// Gets or sets DataGrid settings.
    [<CustomOperation("Settings'")>] member inline _.Settings' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: Radzen.DataGridSettings * (Radzen.DataGridSettings -> unit)) = render ==> html.bind("Settings", valueFn)
    /// Gets or sets the settings changed callback.
    [<CustomOperation("SettingsChanged")>] member inline _.SettingsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridSettings -> unit) = render ==> html.callback("SettingsChanged", fn)
    /// Gets or sets the settings changed callback.
    [<CustomOperation("SettingsChanged")>] member inline _.SettingsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.DataGridSettings -> Task<unit>) = render ==> html.callbackTask("SettingsChanged", fn)

/// RadzenDataList component.
type RadzenDataListBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit PagedDataBoundComponentBuilder<'FunBlazorGeneric, 'TItem>()
    /// Gets or sets a value indicating whether DataList should show empty message.
    [<CustomOperation("ShowEmptyMessage")>] member inline _.ShowEmptyMessage ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowEmptyMessage" =>>> true)
    /// Gets or sets a value indicating whether DataList should show empty message.
    [<CustomOperation("ShowEmptyMessage")>] member inline _.ShowEmptyMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowEmptyMessage" =>>> x)
    /// Gets or sets the empty text shown when Data is empty collection.
    [<CustomOperation("EmptyText")>] member inline _.EmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EmptyText" => x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("EmptyTemplate", fragment)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("EmptyTemplate", fragment { yield! fragments })
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets the empty template shown when Data is empty collection.
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    /// Gets or sets a value indicating whether to wrap items.
    [<CustomOperation("WrapItems")>] member inline _.WrapItems ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("WrapItems" =>>> true)
    /// Gets or sets a value indicating whether to wrap items.
    [<CustomOperation("WrapItems")>] member inline _.WrapItems ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("WrapItems" =>>> x)
    /// Gets or sets a value indicating whether this instance is virtualized.
    [<CustomOperation("AllowVirtualization")>] member inline _.AllowVirtualization ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowVirtualization" =>>> true)
    /// Gets or sets a value indicating whether this instance is virtualized.
    [<CustomOperation("AllowVirtualization")>] member inline _.AllowVirtualization ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowVirtualization" =>>> x)
    /// Gets or sets a value indicating whether this instance loading indicator is shown.
    [<CustomOperation("IsLoading")>] member inline _.IsLoading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsLoading" =>>> true)
    /// Gets or sets a value indicating whether this instance loading indicator is shown.
    [<CustomOperation("IsLoading")>] member inline _.IsLoading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsLoading" =>>> x)

/// RadzenAccordion component.
type RadzenAccordionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether multiple items can be expanded.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// Gets or sets a value indicating whether multiple items can be expanded.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// Gets or sets the index of the selected item.
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// Gets or sets the index of the selected item.
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    /// Gets or sets the value changed.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("SelectedIndexChanged", fn)
    /// Gets or sets the value changed.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedIndexChanged", fn)
    /// Gets or sets a callback raised when the item is expanded.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("Expand", fn)
    /// Gets or sets a callback raised when the item is expanded.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("Expand", fn)
    /// Gets or sets a callback raised when the item is collapsed.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("Collapse", fn)
    /// Gets or sets a callback raised when the item is collapsed.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("Collapse", fn)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Items", fragment)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Items", fragment { yield! fragments })
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Items", html.text x)

/// Class RadzenAccordionItem.
type RadzenAccordionItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets a value indicating whether this RadzenAccordionItem is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Gets or sets a value indicating whether this RadzenAccordionItem is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Gets or sets a value indicating whether this RadzenAccordionItem is selected.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Gets or sets the value changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Gets or sets the value changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
    /// Gets or sets a value indicating whether this RadzenAccordionItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenAccordionItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the title attribute of the expand button.
    [<CustomOperation("ExpandTitle")>] member inline _.ExpandTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandTitle" => x)
    /// Gets or sets the title attribute of the collapse button.
    [<CustomOperation("CollapseTitle")>] member inline _.CollapseTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseTitle" => x)
    /// Gets or sets the aria-label attribute of the expand button.
    [<CustomOperation("ExpandAriaLabel")>] member inline _.ExpandAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandAriaLabel" => x)
    /// Gets or sets the aria-label attribute of the collapse button.
    [<CustomOperation("CollapseAriaLabel")>] member inline _.CollapseAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseAriaLabel" => x)
    /// Gets or sets the header content.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Template", fragment)
    /// Gets or sets the header content.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Template", fragment { yield! fragments })
    /// Gets or sets the header content.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the header content.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the header content.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets a value indicating whether this RadzenAccordionItem is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenAccordionItem is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

/// Dark or light theme switch. Requires ThemeService to be registered in the DI container.
type RadzenAppearanceToggleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the switch button variant.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("Variant" => x)
    /// Gets or sets the switch button style.
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonStyle) = render ==> ("ButtonStyle" => x)
    /// Gets or sets the switch button toggled shade.
    [<CustomOperation("ToggleShade")>] member inline _.ToggleShade ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Shade) = render ==> ("ToggleShade" => x)
    /// Gets or sets the switch button toggled style.
    [<CustomOperation("ToggleButtonStyle")>] member inline _.ToggleButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonStyle) = render ==> ("ToggleButtonStyle" => x)
    /// Gets or sets the light theme. Not set by default - the component uses the light version of the current theme.
    [<CustomOperation("LightTheme")>] member inline _.LightTheme ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LightTheme" => x)
    /// Gets or sets the dark theme. Not set by default - the component uses the dark version of the current theme.
    [<CustomOperation("DarkTheme")>] member inline _.DarkTheme ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DarkTheme" => x)

/// RadzenBadge component.
type RadzenBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the badge style.
    [<CustomOperation("BadgeStyle")>] member inline _.BadgeStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.BadgeStyle) = render ==> ("BadgeStyle" => x)
    /// Gets or sets the badge variant.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("Variant" => x)
    /// Gets or sets the badge shade color.
    [<CustomOperation("Shade")>] member inline _.Shade ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Shade) = render ==> ("Shade" => x)
    /// Gets or sets a value indicating whether this instance is pill.
    [<CustomOperation("IsPill")>] member inline _.IsPill ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsPill" =>>> true)
    /// Gets or sets a value indicating whether this instance is pill.
    [<CustomOperation("IsPill")>] member inline _.IsPill ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsPill" =>>> x)

/// Bread Crumb Item Component
type RadzenBreadCrumbItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// The Displayed Text
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// An optional Link to be rendendered
    [<CustomOperation("Path")>] member inline _.Path ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Path" => x)
    /// An optional Icon to be rendered
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)

/// RadzenCarousel component.
type RadzenCarouselBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Items", fragment)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Items", fragment { yield! fragments })
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the selected index.
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// Gets or sets the selected index.
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    /// Gets or sets the selected index changed callback.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("SelectedIndexChanged", fn)
    /// Gets or sets the selected index changed callback.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedIndexChanged", fn)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("Change", fn)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// Gets or sets a value indicating whether this RadzenCarousel cycle is automatic.
    [<CustomOperation("Auto")>] member inline _.Auto ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Auto" =>>> true)
    /// Gets or sets a value indicating whether this RadzenCarousel cycle is automatic.
    [<CustomOperation("Auto")>] member inline _.Auto ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Auto" =>>> x)
    /// Gets or sets the auto-cycle interval in milliseconds.
    [<CustomOperation("Interval")>] member inline _.Interval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Interval" => x)
    /// Gets or sets the pager position. Set to PagerPosition.Bottom by default.
    [<CustomOperation("PagerPosition")>] member inline _.PagerPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.PagerPosition) = render ==> ("PagerPosition" => x)
    /// Gets or sets a value indicating whether pager overlays the carousel items. Set to true by default.
    [<CustomOperation("PagerOverlay")>] member inline _.PagerOverlay ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PagerOverlay" =>>> true)
    /// Gets or sets a value indicating whether pager overlays the carousel items. Set to true by default.
    [<CustomOperation("PagerOverlay")>] member inline _.PagerOverlay ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PagerOverlay" =>>> x)
    /// Gets or sets a value indicating whether paging is allowed. Set to true by default.
    [<CustomOperation("AllowPaging")>] member inline _.AllowPaging ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowPaging" =>>> true)
    /// Gets or sets a value indicating whether paging is allowed. Set to true by default.
    [<CustomOperation("AllowPaging")>] member inline _.AllowPaging ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowPaging" =>>> x)
    /// Gets or sets a value indicating whether previous/next navigation is allowed. Set to true by default.
    [<CustomOperation("AllowNavigation")>] member inline _.AllowNavigation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowNavigation" =>>> true)
    /// Gets or sets a value indicating whether previous/next navigation is allowed. Set to true by default.
    [<CustomOperation("AllowNavigation")>] member inline _.AllowNavigation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowNavigation" =>>> x)
    /// Gets or sets the buttons style
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonStyle) = render ==> ("ButtonStyle" => x)
    /// Gets or sets the design variant of the buttons.
    [<CustomOperation("ButtonVariant")>] member inline _.ButtonVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("ButtonVariant" => x)
    /// Gets or sets the color shade of the buttons.
    [<CustomOperation("ButtonShade")>] member inline _.ButtonShade ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Shade) = render ==> ("ButtonShade" => x)
    /// Gets or sets the buttons size.
    [<CustomOperation("ButtonSize")>] member inline _.ButtonSize ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonSize) = render ==> ("ButtonSize" => x)
    /// Gets or sets the next button text.
    [<CustomOperation("NextText")>] member inline _.NextText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextText" => x)
    /// Gets or sets the previous button text.
    [<CustomOperation("PrevText")>] member inline _.PrevText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevText" => x)
    /// Gets or sets the next button icon.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// Gets or sets the previous button icon.
    [<CustomOperation("PrevIcon")>] member inline _.PrevIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevIcon" => x)

/// RadzenCheckBoxListItem component.
type RadzenCheckBoxListItemBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenCheckBoxListItem<'TValue> -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Gets or sets a value indicating whether this RadzenCheckBoxListItem`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenCheckBoxListItem`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)

/// RadzenDataFilter component.
type RadzenDataFilterBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the properties.
    [<CustomOperation("Properties")>] member inline _.Properties ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Properties", fragment)
    /// Gets or sets the properties.
    [<CustomOperation("Properties")>] member inline _.Properties ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Properties", fragment { yield! fragments })
    /// Gets or sets the properties.
    [<CustomOperation("Properties")>] member inline _.Properties ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Properties", html.text x)
    /// Gets or sets the properties.
    [<CustomOperation("Properties")>] member inline _.Properties ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Properties", html.text x)
    /// Gets or sets the properties.
    [<CustomOperation("Properties")>] member inline _.Properties ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Properties", html.text x)
    /// Gets or sets the data.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Data" => x)
    /// Gets or sets a value indicating whether this filter is automatic.
    [<CustomOperation("Auto")>] member inline _.Auto ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Auto" =>>> true)
    /// Gets or sets a value indicating whether this filter is automatic.
    [<CustomOperation("Auto")>] member inline _.Auto ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Auto" =>>> x)
    /// Gets or sets the logical filter operator.
    [<CustomOperation("LogicalFilterOperator")>] member inline _.LogicalFilterOperator ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.LogicalFilterOperator) = render ==> ("LogicalFilterOperator" => x)
    /// Gets or sets the filter case sensitivity.
    [<CustomOperation("FilterCaseSensitivity")>] member inline _.FilterCaseSensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FilterCaseSensitivity) = render ==> ("FilterCaseSensitivity" => x)
    /// Gets or sets the filter text.
    [<CustomOperation("FilterText")>] member inline _.FilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterText" => x)
    /// Gets or sets the enum filter select text.
    [<CustomOperation("EnumFilterSelectText")>] member inline _.EnumFilterSelectText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EnumFilterSelectText" => x)
    /// Gets or sets the and operator text.
    [<CustomOperation("AndOperatorText")>] member inline _.AndOperatorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AndOperatorText" => x)
    /// Gets or sets the or operator text.
    [<CustomOperation("OrOperatorText")>] member inline _.OrOperatorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OrOperatorText" => x)
    /// Gets or sets the apply filter text.
    [<CustomOperation("ApplyFilterText")>] member inline _.ApplyFilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ApplyFilterText" => x)
    /// Gets or sets the clear filter text.
    [<CustomOperation("ClearFilterText")>] member inline _.ClearFilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearFilterText" => x)
    /// Gets or sets the add filter text.
    [<CustomOperation("AddFilterText")>] member inline _.AddFilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddFilterText" => x)
    /// Gets or sets the remove filter text.
    [<CustomOperation("RemoveFilterText")>] member inline _.RemoveFilterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RemoveFilterText" => x)
    /// Gets or sets the add filter group text.
    [<CustomOperation("AddFilterGroupText")>] member inline _.AddFilterGroupText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddFilterGroupText" => x)
    /// Gets or sets the equals text.
    [<CustomOperation("EqualsText")>] member inline _.EqualsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EqualsText" => x)
    /// Gets or sets the not equals text.
    [<CustomOperation("NotEqualsText")>] member inline _.NotEqualsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NotEqualsText" => x)
    /// Gets or sets the less than text.
    [<CustomOperation("LessThanText")>] member inline _.LessThanText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LessThanText" => x)
    /// Gets or sets the less than or equals text.
    [<CustomOperation("LessThanOrEqualsText")>] member inline _.LessThanOrEqualsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LessThanOrEqualsText" => x)
    /// Gets or sets the greater than text.
    [<CustomOperation("GreaterThanText")>] member inline _.GreaterThanText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GreaterThanText" => x)
    /// Gets or sets the greater than or equals text.
    [<CustomOperation("GreaterThanOrEqualsText")>] member inline _.GreaterThanOrEqualsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GreaterThanOrEqualsText" => x)
    /// Gets or sets the ends with text.
    [<CustomOperation("EndsWithText")>] member inline _.EndsWithText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndsWithText" => x)
    /// Gets or sets the contains text.
    [<CustomOperation("ContainsText")>] member inline _.ContainsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContainsText" => x)
    /// Gets or sets the does not contain text.
    [<CustomOperation("DoesNotContainText")>] member inline _.DoesNotContainText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DoesNotContainText" => x)
    /// Gets or sets the in operator text.
    [<CustomOperation("InText")>] member inline _.InText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InText" => x)
    /// Gets or sets the not in operator text.
    [<CustomOperation("NotInText")>] member inline _.NotInText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NotInText" => x)
    /// Gets or sets the starts with text.
    [<CustomOperation("StartsWithText")>] member inline _.StartsWithText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartsWithText" => x)
    /// Gets or sets the not null text.
    [<CustomOperation("IsNotNullText")>] member inline _.IsNotNullText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IsNotNullText" => x)
    /// Gets or sets the is null text.
    [<CustomOperation("IsNullText")>] member inline _.IsNullText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IsNullText" => x)
    /// Gets or sets the is empty text.
    [<CustomOperation("IsEmptyText")>] member inline _.IsEmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IsEmptyText" => x)
    /// Gets or sets the is not empty text.
    [<CustomOperation("IsNotEmptyText")>] member inline _.IsNotEmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IsNotEmptyText" => x)
    /// Gets or sets the custom filter operator text.
    [<CustomOperation("CustomText")>] member inline _.CustomText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomText" => x)
    /// Gets or sets a value indicating whether the columns can be filtered.
    [<CustomOperation("AllowColumnFiltering")>] member inline _.AllowColumnFiltering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowColumnFiltering" =>>> true)
    /// Gets or sets a value indicating whether the columns can be filtered.
    [<CustomOperation("AllowColumnFiltering")>] member inline _.AllowColumnFiltering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowColumnFiltering" =>>> x)
    /// Gets or sets a value indicating whether properties can be reused in the filter.
    [<CustomOperation("UniqueFilters")>] member inline _.UniqueFilters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UniqueFilters" =>>> true)
    /// Gets or sets a value indicating whether properties can be reused in the filter.
    [<CustomOperation("UniqueFilters")>] member inline _.UniqueFilters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UniqueFilters" =>>> x)
    /// Gets or sets the view changed callback.
    [<CustomOperation("ViewChanged")>] member inline _.ViewChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Linq.IQueryable<'TItem> -> unit) = render ==> html.callback("ViewChanged", fn)
    /// Gets or sets the view changed callback.
    [<CustomOperation("ViewChanged")>] member inline _.ViewChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Linq.IQueryable<'TItem> -> Task<unit>) = render ==> html.callbackTask("ViewChanged", fn)
    /// Gets or sets the filter date format.
    [<CustomOperation("FilterDateFormat")>] member inline _.FilterDateFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterDateFormat" => x)

/// RadzenDatePicker component.
type RadzenDatePickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether calendar week will be shown.
    [<CustomOperation("ShowCalendarWeek")>] member inline _.ShowCalendarWeek ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowCalendarWeek" =>>> true)
    /// Gets or sets a value indicating whether calendar week will be shown.
    [<CustomOperation("ShowCalendarWeek")>] member inline _.ShowCalendarWeek ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowCalendarWeek" =>>> x)
    /// Gets or sets the previous month aria label text.
    [<CustomOperation("CalendarWeekTitle")>] member inline _.CalendarWeekTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CalendarWeekTitle" => x)
    /// Gets or sets the toggle popup aria label text.
    [<CustomOperation("ToggleAriaLabel")>] member inline _.ToggleAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggleAriaLabel" => x)
    /// Gets or sets the OK button aria label text.
    [<CustomOperation("OkAriaLabel")>] member inline _.OkAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OkAriaLabel" => x)
    /// Gets or sets the previous month aria label text.
    [<CustomOperation("PrevMonthAriaLabel")>] member inline _.PrevMonthAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevMonthAriaLabel" => x)
    /// Gets or sets the next month aria label text.
    [<CustomOperation("NextMonthAriaLabel")>] member inline _.NextMonthAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextMonthAriaLabel" => x)
    /// Gets or sets the toggle Am/Pm aria label text.
    [<CustomOperation("ToggleAmPmAriaLabel")>] member inline _.ToggleAmPmAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggleAmPmAriaLabel" => x)
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets the year formatter. Set to FormatYear by default.
    /// If set, this function will take precedence over YearFormat.
    [<CustomOperation("YearFormatter")>] member inline _.YearFormatter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("YearFormatter" => (System.Func<System.Int32, System.String>fn))
    /// Gets ot sets the year format. Set to yyyy by default.
    [<CustomOperation("YearFormat")>] member inline _.YearFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("YearFormat" => x)
    /// Gets or sets a value indicating whether value can be cleared.
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowClear" =>>> true)
    /// Gets or sets a value indicating whether value can be cleared.
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowClear" =>>> x)
    /// Gets or sets the tab index.
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TabIndex" => x)
    /// Gets or sets the name of the form component.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets the input CSS class.
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// Gets or sets the button CSS class.
    [<CustomOperation("ButtonClass")>] member inline _.ButtonClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonClass" => x)
    /// Gets or sets the Minimum Selectable Date.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Min" => x)
    /// Gets or sets the Maximum Selectable Date.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Max" => x)
    /// Gets or sets the Initial Date/Month View.
    [<CustomOperation("InitialViewDate")>] member inline _.InitialViewDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("InitialViewDate" => x)
    /// Gets or sets the date render callback. Use it to set attributes.
    [<CustomOperation("DateRender")>] member inline _.DateRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DateRender" => (System.Action<Radzen.DateRenderEventArgs>fn))
    /// Gets or sets the kind of DateTime bind to control
    [<CustomOperation("Kind")>] member inline _.Kind ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTimeKind) = render ==> ("Kind" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("Value", valueFn)
    /// Gets or set the current date changed callback.
    [<CustomOperation("CurrentDateChanged")>] member inline _.CurrentDateChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.DateTime -> unit) = render ==> html.callback("CurrentDateChanged", fn)
    /// Gets or set the current date changed callback.
    [<CustomOperation("CurrentDateChanged")>] member inline _.CurrentDateChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.DateTime -> Task<unit>) = render ==> html.callbackTask("CurrentDateChanged", fn)
    /// Parse the input using an function outside the Radzen-library
    [<CustomOperation("ParseInput")>] member inline _.ParseInput ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ParseInput" => (System.Func<System.String, System.Nullable<System.DateTime>>fn))
    /// Gets or sets a value indicating whether this RadzenDatePicker`1 is inline - only Calender.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Inline" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDatePicker`1 is inline - only Calender.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Inline" =>>> x)
    /// Gets or sets a value indicating whether time only can be set.
    [<CustomOperation("TimeOnly")>] member inline _.TimeOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TimeOnly" =>>> true)
    /// Gets or sets a value indicating whether time only can be set.
    [<CustomOperation("TimeOnly")>] member inline _.TimeOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TimeOnly" =>>> x)
    /// Gets or sets a value indicating whether read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Gets or sets a value indicating whether read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Gets or sets a value indicating whether input is allowed.
    [<CustomOperation("AllowInput")>] member inline _.AllowInput ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowInput" =>>> true)
    /// Gets or sets a value indicating whether input is allowed.
    [<CustomOperation("AllowInput")>] member inline _.AllowInput ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowInput" =>>> x)
    /// Gets or sets a value indicating whether popup datepicker button is shown.
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowButton" =>>> true)
    /// Gets or sets a value indicating whether popup datepicker button is shown.
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowButton" =>>> x)
    /// Gets or sets a value indicating whether the input box is shown. Ignored if ShowButton is false.
    [<CustomOperation("ShowInput")>] member inline _.ShowInput ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowInput" =>>> true)
    /// Gets or sets a value indicating whether the input box is shown. Ignored if ShowButton is false.
    [<CustomOperation("ShowInput")>] member inline _.ShowInput ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowInput" =>>> x)
    /// Gets or sets a value indicating whether this RadzenDatePicker`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDatePicker`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets a value indicating whether days part is shown.
    [<CustomOperation("ShowDays")>] member inline _.ShowDays ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowDays" =>>> true)
    /// Gets or sets a value indicating whether days part is shown.
    [<CustomOperation("ShowDays")>] member inline _.ShowDays ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowDays" =>>> x)
    /// Gets or sets a value indicating whether time part is shown.
    [<CustomOperation("ShowTime")>] member inline _.ShowTime ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowTime" =>>> true)
    /// Gets or sets a value indicating whether time part is shown.
    [<CustomOperation("ShowTime")>] member inline _.ShowTime ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowTime" =>>> x)
    /// Gets or sets a value indicating whether seconds are shown.
    [<CustomOperation("ShowSeconds")>] member inline _.ShowSeconds ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowSeconds" =>>> true)
    /// Gets or sets a value indicating whether seconds are shown.
    [<CustomOperation("ShowSeconds")>] member inline _.ShowSeconds ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowSeconds" =>>> x)
    /// Gets or sets the hours step.
    [<CustomOperation("HoursStep")>] member inline _.HoursStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HoursStep" => x)
    /// Gets or sets the minutes step.
    [<CustomOperation("MinutesStep")>] member inline _.MinutesStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinutesStep" => x)
    /// Gets or sets the seconds step.
    [<CustomOperation("SecondsStep")>] member inline _.SecondsStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SecondsStep" => x)
    /// Gets or sets a value indicating whether the hour picker is padded with a leading zero.
    [<CustomOperation("PadHours")>] member inline _.PadHours ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PadHours" =>>> true)
    /// Gets or sets a value indicating whether the hour picker is padded with a leading zero.
    [<CustomOperation("PadHours")>] member inline _.PadHours ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PadHours" =>>> x)
    /// Gets or sets a value indicating whether the minute picker is padded with a leading zero.
    [<CustomOperation("PadMinutes")>] member inline _.PadMinutes ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PadMinutes" =>>> true)
    /// Gets or sets a value indicating whether the minute picker is padded with a leading zero.
    [<CustomOperation("PadMinutes")>] member inline _.PadMinutes ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PadMinutes" =>>> x)
    /// Gets or sets a value indicating whether the second picker is padded with a leading zero.
    [<CustomOperation("PadSeconds")>] member inline _.PadSeconds ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PadSeconds" =>>> true)
    /// Gets or sets a value indicating whether the second picker is padded with a leading zero.
    [<CustomOperation("PadSeconds")>] member inline _.PadSeconds ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PadSeconds" =>>> x)
    /// Gets or sets a value indicating whether time ok button is shown.
    [<CustomOperation("ShowTimeOkButton")>] member inline _.ShowTimeOkButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowTimeOkButton" =>>> true)
    /// Gets or sets a value indicating whether time ok button is shown.
    [<CustomOperation("ShowTimeOkButton")>] member inline _.ShowTimeOkButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowTimeOkButton" =>>> x)
    /// Gets or sets the date format.
    [<CustomOperation("DateFormat")>] member inline _.DateFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DateFormat" => x)
    /// Gets or sets the year range.
    [<CustomOperation("YearRange")>] member inline _.YearRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("YearRange" => x)
    /// Gets or sets the hour format.
    [<CustomOperation("HourFormat")>] member inline _.HourFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HourFormat" => x)
    /// Gets or sets the input placeholder.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.DateTime> -> unit) = render ==> html.callback("Change", fn)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.DateTime> -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// Gets or sets the value changed callback.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TValue -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Gets or sets the value changed callback.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the value expression.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("ValueExpression" => x)
    /// Gets or sets the render mode.
    [<CustomOperation("PopupRenderMode")>] member inline _.PopupRenderMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.PopupRenderMode) = render ==> ("PopupRenderMode" => x)

/// RadzenDropZoneItem component.
type RadzenDropZoneItemBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()


/// RadzenFieldset component.
type RadzenFieldsetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether collapsing is allowed. Set to false by default.
    [<CustomOperation("AllowCollapse")>] member inline _.AllowCollapse ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowCollapse" =>>> true)
    /// Gets or sets a value indicating whether collapsing is allowed. Set to false by default.
    [<CustomOperation("AllowCollapse")>] member inline _.AllowCollapse ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowCollapse" =>>> x)
    /// Gets or sets a value indicating whether this RadzenFieldset is collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsed" =>>> true)
    /// Gets or sets a value indicating whether this RadzenFieldset is collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsed" =>>> x)
    /// Gets or sets the title attribute of the expand button.
    [<CustomOperation("ExpandTitle")>] member inline _.ExpandTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandTitle" => x)
    /// Gets or sets the title attribute of the collapse button.
    [<CustomOperation("CollapseTitle")>] member inline _.CollapseTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseTitle" => x)
    /// Gets or sets the aria-label attribute of the expand button.
    [<CustomOperation("ExpandAriaLabel")>] member inline _.ExpandAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandAriaLabel" => x)
    /// Gets or sets the aria-label attribute of the collapse button.
    [<CustomOperation("CollapseAriaLabel")>] member inline _.CollapseAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseAriaLabel" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("SummaryTemplate", fragment)
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("SummaryTemplate", fragment { yield! fragments })
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Gets or sets the summary template.
    [<CustomOperation("SummaryTemplate")>] member inline _.SummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SummaryTemplate", html.text x)
    /// Gets or sets the expand callback.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Expand", fn)
    /// Gets or sets the expand callback.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Expand", fn)
    /// Gets or sets the collapse callback.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Collapse", fn)
    /// Gets or sets the collapse callback.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Collapse", fn)

/// A Blazor component that wraps another component and adds a label, helper text, start and end content.
type RadzenFormFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the optional content that will be rendered before the child content. Usually used with RadzenIcon.
    [<CustomOperation("Start")>] member inline _.Start ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Start", fragment)
    /// Gets or sets the optional content that will be rendered before the child content. Usually used with RadzenIcon.
    [<CustomOperation("Start")>] member inline _.Start ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Start", fragment { yield! fragments })
    /// Gets or sets the optional content that will be rendered before the child content. Usually used with RadzenIcon.
    [<CustomOperation("Start")>] member inline _.Start ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Start", html.text x)
    /// Gets or sets the optional content that will be rendered before the child content. Usually used with RadzenIcon.
    [<CustomOperation("Start")>] member inline _.Start ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Start", html.text x)
    /// Gets or sets the optional content that will be rendered before the child content. Usually used with RadzenIcon.
    [<CustomOperation("Start")>] member inline _.Start ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Start", html.text x)
    /// Gets or sets the optional content that will be rendered after the child content. Usually used with RadzenIcon.
    [<CustomOperation("End")>] member inline _.End ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("End", fragment)
    /// Gets or sets the optional content that will be rendered after the child content. Usually used with RadzenIcon.
    [<CustomOperation("End")>] member inline _.End ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("End", fragment { yield! fragments })
    /// Gets or sets the optional content that will be rendered after the child content. Usually used with RadzenIcon.
    [<CustomOperation("End")>] member inline _.End ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("End", html.text x)
    /// Gets or sets the optional content that will be rendered after the child content. Usually used with RadzenIcon.
    [<CustomOperation("End")>] member inline _.End ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("End", html.text x)
    /// Gets or sets the optional content that will be rendered after the child content. Usually used with RadzenIcon.
    [<CustomOperation("End")>] member inline _.End ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("End", html.text x)
    /// Gets or sets the optional content that will be rendered below the child content. Used with a validator or to display some additional information.
    [<CustomOperation("Helper")>] member inline _.Helper ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Helper", fragment)
    /// Gets or sets the optional content that will be rendered below the child content. Used with a validator or to display some additional information.
    [<CustomOperation("Helper")>] member inline _.Helper ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Helper", fragment { yield! fragments })
    /// Gets or sets the optional content that will be rendered below the child content. Used with a validator or to display some additional information.
    [<CustomOperation("Helper")>] member inline _.Helper ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Helper", html.text x)
    /// Gets or sets the optional content that will be rendered below the child content. Used with a validator or to display some additional information.
    [<CustomOperation("Helper")>] member inline _.Helper ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Helper", html.text x)
    /// Gets or sets the optional content that will be rendered below the child content. Used with a validator or to display some additional information.
    [<CustomOperation("Helper")>] member inline _.Helper ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Helper", html.text x)
    /// Gets or sets the label text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets a value indicating whether the label is floating or fixed on top.
    [<CustomOperation("AllowFloatingLabel")>] member inline _.AllowFloatingLabel ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowFloatingLabel" =>>> true)
    /// Gets or sets a value indicating whether the label is floating or fixed on top.
    [<CustomOperation("AllowFloatingLabel")>] member inline _.AllowFloatingLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowFloatingLabel" =>>> x)
    /// Gets or sets the name of the form field. Used to associate the label with a component.
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Component" => x)
    /// Gets or sets the design variant of the form field.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("Variant" => x)

/// RadzenGoogleMap component.
type RadzenGoogleMapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the data - collection of RadzenGoogleMapMarker.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Radzen.Blazor.RadzenGoogleMapMarker>) = render ==> ("Data" => x)
    /// Gets or sets the map click callback.
    [<CustomOperation("MapClick")>] member inline _.MapClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.GoogleMapClickEventArgs -> unit) = render ==> html.callback("MapClick", fn)
    /// Gets or sets the map click callback.
    [<CustomOperation("MapClick")>] member inline _.MapClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.GoogleMapClickEventArgs -> Task<unit>) = render ==> html.callbackTask("MapClick", fn)
    /// Gets or sets the marker click callback.
    [<CustomOperation("MarkerClick")>] member inline _.MarkerClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenGoogleMapMarker -> unit) = render ==> html.callback("MarkerClick", fn)
    /// Gets or sets the marker click callback.
    [<CustomOperation("MarkerClick")>] member inline _.MarkerClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenGoogleMapMarker -> Task<unit>) = render ==> html.callbackTask("MarkerClick", fn)
    /// Gets or sets the Google API key.
    [<CustomOperation("ApiKey")>] member inline _.ApiKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ApiKey" => x)
    /// Gets or sets the Google Map Id.
    [<CustomOperation("MapId")>] member inline _.MapId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MapId" => x)
    /// Gets or sets the Google map options: https://developers.google.com/maps/documentation/javascript/reference/map#MapOptions.
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("Options" => x)
    /// Gets or sets the zoom.
    [<CustomOperation("Zoom")>] member inline _.Zoom ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Zoom" => x)
    /// Flag indicating whether map will be zoomed to marker bounds on update or not.
    [<CustomOperation("FitBoundsToMarkersOnUpdate")>] member inline _.FitBoundsToMarkersOnUpdate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FitBoundsToMarkersOnUpdate" =>>> true)
    /// Flag indicating whether map will be zoomed to marker bounds on update or not.
    [<CustomOperation("FitBoundsToMarkersOnUpdate")>] member inline _.FitBoundsToMarkersOnUpdate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FitBoundsToMarkersOnUpdate" =>>> x)
    /// Gets or sets the center map position.
    [<CustomOperation("Center")>] member inline _.Center ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.GoogleMapPosition) = render ==> ("Center" => x)
    /// Gets or sets the markers.
    [<CustomOperation("Markers")>] member inline _.Markers ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Markers", fragment)
    /// Gets or sets the markers.
    [<CustomOperation("Markers")>] member inline _.Markers ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Markers", fragment { yield! fragments })
    /// Gets or sets the markers.
    [<CustomOperation("Markers")>] member inline _.Markers ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Markers", html.text x)
    /// Gets or sets the markers.
    [<CustomOperation("Markers")>] member inline _.Markers ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Markers", html.text x)
    /// Gets or sets the markers.
    [<CustomOperation("Markers")>] member inline _.Markers ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Markers", html.text x)

/// RadzenGoogleMapMarker component.
type RadzenGoogleMapMarkerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the position.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.GoogleMapPosition) = render ==> ("Position" => x)
    /// Gets or sets the title.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the label.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)

/// RadzenGravatar component.
type RadzenGravatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the email.
    [<CustomOperation("Email")>] member inline _.Email ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Email" => x)
    /// Gets or sets the text.
    [<CustomOperation("AlternateText")>] member inline _.AlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AlternateText" => x)
    /// Gets or sets the size. Defaulted to 36 (pixels). 
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Size" => x)

/// RadzenHeading component.
type RadzenHeadingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)

/// RadzenIcon component. Displays icon from Material Symbols variable font.
type RadzenIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Specifies the display style of the icon.
    [<CustomOperation("IconStyle")>] member inline _.IconStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Radzen.IconStyle>) = render ==> ("IconStyle" => x)

/// RadzenLabel component.
type RadzenLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the component name for the label.
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Component" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)

/// RadzenLink component.
type RadzenLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Gets or sets the target.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the image.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the path.
    [<CustomOperation("Path")>] member inline _.Path ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Path" => x)
    /// Gets or sets the navigation link match.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// Gets or sets whether the link is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets whether the link is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// RadzenLogin component. Must be placed in RadzenTemplateForm.
type RadzenLoginBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether automatic complete of inputs is enabled.
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoComplete" =>>> true)
    /// Gets or sets a value indicating whether automatic complete of inputs is enabled.
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoComplete" =>>> x)
    /// Gets or sets a value indicating the type of built-in autocomplete
    /// the browser should use.
    /// AutoCompleteType
    [<CustomOperation("UserNameAutoCompleteType")>] member inline _.UserNameAutoCompleteType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.AutoCompleteType) = render ==> ("UserNameAutoCompleteType" => x)
    /// Gets or sets a value indicating the type of built-in autocomplete
    /// the browser should use.
    /// AutoCompleteType
    [<CustomOperation("PasswordAutoCompleteType")>] member inline _.PasswordAutoCompleteType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.AutoCompleteType) = render ==> ("PasswordAutoCompleteType" => x)
    /// Gets or sets the design variant of the form field.
    [<CustomOperation("FormFieldVariant")>] member inline _.FormFieldVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Radzen.Variant>) = render ==> ("FormFieldVariant" => x)
    /// Gets or sets the username.
    [<CustomOperation("Username")>] member inline _.Username ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Username" => x)
    /// Gets or sets the password.
    [<CustomOperation("Password")>] member inline _.Password ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Password" => x)
    /// Sets the initial value of the remember me switch.
    [<CustomOperation("RememberMe")>] member inline _.RememberMe ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("RememberMe" =>>> true)
    /// Sets the initial value of the remember me switch.
    [<CustomOperation("RememberMe")>] member inline _.RememberMe ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("RememberMe" =>>> x)
    /// Gets or sets the login callback.
    [<CustomOperation("Login")>] member inline _.Login ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.LoginArgs -> unit) = render ==> html.callback("Login", fn)
    /// Gets or sets the login callback.
    [<CustomOperation("Login")>] member inline _.Login ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.LoginArgs -> Task<unit>) = render ==> html.callbackTask("Login", fn)
    /// Gets or sets the register callback.
    [<CustomOperation("Register")>] member inline _.Register ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Register", fn)
    /// Gets or sets the register callback.
    [<CustomOperation("Register")>] member inline _.Register ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Register", fn)
    /// Gets or sets the reset password callback.
    [<CustomOperation("ResetPassword")>] member inline _.ResetPassword ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("ResetPassword", fn)
    /// Gets or sets the reset password callback.
    [<CustomOperation("ResetPassword")>] member inline _.ResetPassword ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("ResetPassword", fn)
    /// Gets or sets a value indicating whether register is allowed.
    [<CustomOperation("AllowRegister")>] member inline _.AllowRegister ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowRegister" =>>> true)
    /// Gets or sets a value indicating whether register is allowed.
    [<CustomOperation("AllowRegister")>] member inline _.AllowRegister ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowRegister" =>>> x)
    /// Asks the user whether to remember their credentials. Set to false by default.
    [<CustomOperation("AllowRememberMe")>] member inline _.AllowRememberMe ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowRememberMe" =>>> true)
    /// Asks the user whether to remember their credentials. Set to false by default.
    [<CustomOperation("AllowRememberMe")>] member inline _.AllowRememberMe ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowRememberMe" =>>> x)
    /// Gets or sets a value indicating whether reset password is allowed.
    [<CustomOperation("AllowResetPassword")>] member inline _.AllowResetPassword ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowResetPassword" =>>> true)
    /// Gets or sets a value indicating whether reset password is allowed.
    [<CustomOperation("AllowResetPassword")>] member inline _.AllowResetPassword ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowResetPassword" =>>> x)
    /// Gets or sets a value indicating whether default login button is shown.
    [<CustomOperation("ShowLoginButton")>] member inline _.ShowLoginButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowLoginButton" =>>> true)
    /// Gets or sets a value indicating whether default login button is shown.
    [<CustomOperation("ShowLoginButton")>] member inline _.ShowLoginButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowLoginButton" =>>> x)
    /// Gets or sets the login text.
    [<CustomOperation("LoginText")>] member inline _.LoginText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LoginText" => x)
    /// Gets or sets the register text.
    [<CustomOperation("RegisterText")>] member inline _.RegisterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RegisterText" => x)
    /// Gets or sets the remember me text.
    [<CustomOperation("RememberMeText")>] member inline _.RememberMeText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RememberMeText" => x)
    /// Gets or sets the register message text.
    [<CustomOperation("RegisterMessageText")>] member inline _.RegisterMessageText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RegisterMessageText" => x)
    /// Gets or sets the reset password text.
    [<CustomOperation("ResetPasswordText")>] member inline _.ResetPasswordText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ResetPasswordText" => x)
    /// Gets or sets the user text.
    [<CustomOperation("UserText")>] member inline _.UserText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UserText" => x)
    /// Gets or sets the user required text.
    [<CustomOperation("UserRequired")>] member inline _.UserRequired ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UserRequired" => x)
    /// Gets or sets the password text.
    [<CustomOperation("PasswordText")>] member inline _.PasswordText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PasswordText" => x)
    /// Gets or sets the password required.
    [<CustomOperation("PasswordRequired")>] member inline _.PasswordRequired ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PasswordRequired" => x)

/// A component which renders markdown content.
type RadzenMarkdownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether to allow HTML content in the markdown. Certain dangerous HTML tags (script, style, object, iframe) and attributes are removed.
    /// Set to true by default.
    [<CustomOperation("AllowHtml")>] member inline _.AllowHtml ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowHtml" =>>> true)
    /// Gets or sets a value indicating whether to allow HTML content in the markdown. Certain dangerous HTML tags (script, style, object, iframe) and attributes are removed.
    /// Set to true by default.
    [<CustomOperation("AllowHtml")>] member inline _.AllowHtml ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowHtml" =>>> x)
    /// Gets or sets a list of allowed HTML tags. If set, only these tags will be allowed in the markdown content. By default would use a list of safe HTML tags.
    /// Considered only if AllowHtml is set to true.
    [<CustomOperation("AllowedHtmlTags")>] member inline _.AllowedHtmlTags ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("AllowedHtmlTags" => x)
    /// Gets or sets a list of allowed HTML attributes. If set, only these attributes will be allowed in the markdown content. By default would use a list of safe HTML attributes.
    /// Considered only if AllowHtml is set to true.
    [<CustomOperation("AllowedHtmlAttributes")>] member inline _.AllowedHtmlAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("AllowedHtmlAttributes" => x)
    /// Gets or sets the markdown content as a string. Overrides ChildContent if set.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The maximum heading depth to create anchor links for. Set to 0 to disable auto-linking.
    [<CustomOperation("AutoLinkHeadingDepth")>] member inline _.AutoLinkHeadingDepth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("AutoLinkHeadingDepth" => x)

/// RadzenMenuItem component.
type RadzenMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets a value indicating whether this instance is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets a value indicating whether this instance is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the target.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Gets or sets the path.
    [<CustomOperation("Path")>] member inline _.Path ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Path" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the image.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the image style.
    [<CustomOperation("ImageStyle")>] member inline _.ImageStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageStyle" => x)
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Gets or sets the navigation link match.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Template", fragment)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Template", fragment { yield! fragments })
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.MenuItemEventArgs -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("Click", fn)

/// RadzenPager component.
type RadzenPagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the pager's first page button's title attribute.
    [<CustomOperation("FirstPageTitle")>] member inline _.FirstPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstPageTitle" => x)
    /// Gets or sets the pager's first page button's aria-label attribute.
    [<CustomOperation("FirstPageAriaLabel")>] member inline _.FirstPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstPageAriaLabel" => x)
    /// Gets or sets the pager's optional previous page button's label text.
    [<CustomOperation("PrevPageLabel")>] member inline _.PrevPageLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevPageLabel" => x)
    /// Gets or sets the pager's previous page button's title attribute.
    [<CustomOperation("PrevPageTitle")>] member inline _.PrevPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevPageTitle" => x)
    /// Gets or sets the pager's previous page button's aria-label attribute.
    [<CustomOperation("PrevPageAriaLabel")>] member inline _.PrevPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevPageAriaLabel" => x)
    /// Gets or sets the pager's last page button's title attribute.
    [<CustomOperation("LastPageTitle")>] member inline _.LastPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastPageTitle" => x)
    /// Gets or sets the pager's last page button's aria-label attribute.
    [<CustomOperation("LastPageAriaLabel")>] member inline _.LastPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastPageAriaLabel" => x)
    /// Gets or sets the pager's optional next page button's label text.
    [<CustomOperation("NextPageLabel")>] member inline _.NextPageLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextPageLabel" => x)
    /// Gets or sets the pager's next page button's title attribute.
    [<CustomOperation("NextPageTitle")>] member inline _.NextPageTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextPageTitle" => x)
    /// Gets or sets the pager's next page button's aria-label attribute.
    [<CustomOperation("NextPageAriaLabel")>] member inline _.NextPageAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextPageAriaLabel" => x)
    /// Gets or sets the pager's numeric page number buttons' title attributes.
    [<CustomOperation("PageTitleFormat")>] member inline _.PageTitleFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PageTitleFormat" => x)
    /// Gets or sets the pager's numeric page number buttons' aria-label attributes.
    [<CustomOperation("PageAriaLabelFormat")>] member inline _.PageAriaLabelFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PageAriaLabelFormat" => x)
    /// Gets or sets the horizontal align.
    [<CustomOperation("HorizontalAlign")>] member inline _.HorizontalAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.HorizontalAlign) = render ==> ("HorizontalAlign" => x)
    /// Gets or sets a value indicating Pager density.
    [<CustomOperation("Density")>] member inline _.Density ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Density) = render ==> ("Density" => x)
    /// Gets or sets the page size.
    [<CustomOperation("PageSize")>] member inline _.PageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageSize" => x)
    /// Gets or sets the page size.
    [<CustomOperation("PageSize'")>] member inline _.PageSize' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("PageSize", valueFn)
    /// Gets or sets the page size changed callback.
    [<CustomOperation("PageSizeChanged")>] member inline _.PageSizeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("PageSizeChanged", fn)
    /// Gets or sets the page size changed callback.
    [<CustomOperation("PageSizeChanged")>] member inline _.PageSizeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("PageSizeChanged", fn)
    /// Gets or sets the page size options.
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.Int32>) = render ==> ("PageSizeOptions" => x)
    /// Gets or sets the page size description text.
    [<CustomOperation("PageSizeText")>] member inline _.PageSizeText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PageSizeText" => x)
    /// Gets or sets the pager summary visibility.
    [<CustomOperation("ShowPagingSummary")>] member inline _.ShowPagingSummary ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowPagingSummary" =>>> true)
    /// Gets or sets the pager summary visibility.
    [<CustomOperation("ShowPagingSummary")>] member inline _.ShowPagingSummary ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowPagingSummary" =>>> x)
    /// Gets or sets the pager summary format.
    [<CustomOperation("PagingSummaryFormat")>] member inline _.PagingSummaryFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PagingSummaryFormat" => x)
    /// Gets or sets the pager summary template.
    [<CustomOperation("PagingSummaryTemplate")>] member inline _.PagingSummaryTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.PagingInformation -> NodeRenderFragment) = render ==> html.renderFragment("PagingSummaryTemplate", fn)
    /// Gets or sets the page numbers count.
    [<CustomOperation("PageNumbersCount")>] member inline _.PageNumbersCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageNumbersCount" => x)
    /// Gets or sets the total items count.
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    /// Gets or sets a value indicating whether pager is visible even when not enough data for paging.
    [<CustomOperation("AlwaysVisible")>] member inline _.AlwaysVisible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AlwaysVisible" =>>> true)
    /// Gets or sets a value indicating whether pager is visible even when not enough data for paging.
    [<CustomOperation("AlwaysVisible")>] member inline _.AlwaysVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AlwaysVisible" =>>> x)
    /// Gets or sets the page changed callback.
    [<CustomOperation("PageChanged")>] member inline _.PageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.PagerEventArgs -> unit) = render ==> html.callback("PageChanged", fn)
    /// Gets or sets the page changed callback.
    [<CustomOperation("PageChanged")>] member inline _.PageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.PagerEventArgs -> Task<unit>) = render ==> html.callbackTask("PageChanged", fn)

/// RadzenPanelMenuItem component.
type RadzenPanelMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the target.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Gets or sets the expanded changed callback.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Gets or sets the expanded changed callback.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Gets or sets the path.
    [<CustomOperation("Path")>] member inline _.Path ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Path" => x)
    /// Gets or sets the navigation link match.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the image.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Template", fragment)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Template", fragment { yield! fragments })
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Template", html.text x)
    /// Gets or sets a value indicating whether this RadzenPanelMenuItem is expanded.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Gets or sets a value indicating whether this RadzenPanelMenuItem is expanded.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Gets or sets a value indicating whether this RadzenPanelMenuItem is expanded.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Gets or sets a value indicating whether this RadzenPanelMenuItem is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Gets or sets a value indicating whether this RadzenPanelMenuItem is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.MenuItemEventArgs -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.MenuItemEventArgs -> Task<unit>) = render ==> html.callbackTask("Click", fn)

/// RadzenCard component.
type RadzenPickListBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether it is allowed to move all items.
    [<CustomOperation("AllowMoveAll")>] member inline _.AllowMoveAll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowMoveAll" =>>> true)
    /// Gets or sets a value indicating whether it is allowed to move all items.
    [<CustomOperation("AllowMoveAll")>] member inline _.AllowMoveAll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowMoveAll" =>>> x)
    /// Gets or sets a value indicating whether it is allowed to move all items from source to target.
    [<CustomOperation("AllowMoveAllSourceToTarget")>] member inline _.AllowMoveAllSourceToTarget ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowMoveAllSourceToTarget" =>>> true)
    /// Gets or sets a value indicating whether it is allowed to move all items from source to target.
    [<CustomOperation("AllowMoveAllSourceToTarget")>] member inline _.AllowMoveAllSourceToTarget ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowMoveAllSourceToTarget" =>>> x)
    /// Gets or sets a value indicating whether it is allowed to move all items from target to source.
    [<CustomOperation("AllowMoveAllTargetToSource")>] member inline _.AllowMoveAllTargetToSource ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowMoveAllTargetToSource" =>>> true)
    /// Gets or sets a value indicating whether it is allowed to move all items from target to source.
    [<CustomOperation("AllowMoveAllTargetToSource")>] member inline _.AllowMoveAllTargetToSource ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowMoveAllTargetToSource" =>>> x)
    /// Gets or sets a value indicating whether multiple selection is allowed.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// Gets or sets a value indicating whether multiple selection is allowed.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// Gets or sets a value indicating whether selecting all items is allowed.
    [<CustomOperation("AllowSelectAll")>] member inline _.AllowSelectAll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowSelectAll" =>>> true)
    /// Gets or sets a value indicating whether selecting all items is allowed.
    [<CustomOperation("AllowSelectAll")>] member inline _.AllowSelectAll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowSelectAll" =>>> x)
    /// Gets or sets a value indicating whether component is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether component is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the source header
    [<CustomOperation("SourceHeader")>] member inline _.SourceHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("SourceHeader", fragment)
    /// Gets or sets the source header
    [<CustomOperation("SourceHeader")>] member inline _.SourceHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("SourceHeader", fragment { yield! fragments })
    /// Gets or sets the source header
    [<CustomOperation("SourceHeader")>] member inline _.SourceHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SourceHeader", html.text x)
    /// Gets or sets the source header
    [<CustomOperation("SourceHeader")>] member inline _.SourceHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SourceHeader", html.text x)
    /// Gets or sets the source header
    [<CustomOperation("SourceHeader")>] member inline _.SourceHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SourceHeader", html.text x)
    /// Gets or sets the target header
    [<CustomOperation("TargetHeader")>] member inline _.TargetHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TargetHeader", fragment)
    /// Gets or sets the target header
    [<CustomOperation("TargetHeader")>] member inline _.TargetHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TargetHeader", fragment { yield! fragments })
    /// Gets or sets the target header
    [<CustomOperation("TargetHeader")>] member inline _.TargetHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TargetHeader", html.text x)
    /// Gets or sets the target header
    [<CustomOperation("TargetHeader")>] member inline _.TargetHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TargetHeader", html.text x)
    /// Gets or sets the target header
    [<CustomOperation("TargetHeader")>] member inline _.TargetHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TargetHeader", html.text x)
    /// Gets or sets the common placeholder
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Gets or sets the source placeholder
    [<CustomOperation("SourcePlaceholder")>] member inline _.SourcePlaceholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SourcePlaceholder" => x)
    /// Gets or sets the target placeholder
    [<CustomOperation("TargetPlaceholder")>] member inline _.TargetPlaceholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TargetPlaceholder" => x)
    /// Gets or sets the text property
    [<CustomOperation("TextProperty")>] member inline _.TextProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextProperty" => x)
    /// Gets or sets the disabled property
    [<CustomOperation("DisabledProperty")>] member inline _.DisabledProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledProperty" => x)
    /// Gets or sets the source template
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the select all text.
    [<CustomOperation("SelectAllText")>] member inline _.SelectAllText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    /// Gets or sets the row render callback. Use it to set row attributes.
    [<CustomOperation("ItemRender")>] member inline _.ItemRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemRender" => (System.Action<Radzen.PickListItemRenderEventArgs<'TItem>>fn))
    /// Gets or sets value if filtering is allowed.
    [<CustomOperation("AllowFiltering")>] member inline _.AllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowFiltering" =>>> true)
    /// Gets or sets value if filtering is allowed.
    [<CustomOperation("AllowFiltering")>] member inline _.AllowFiltering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowFiltering" =>>> x)
    /// Gets or sets value if headers are shown.
    [<CustomOperation("ShowHeader")>] member inline _.ShowHeader ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowHeader" =>>> true)
    /// Gets or sets value if headers are shown.
    [<CustomOperation("ShowHeader")>] member inline _.ShowHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowHeader" =>>> x)
    /// Gets or sets the buttons spacing
    [<CustomOperation("ButtonGap")>] member inline _.ButtonGap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonGap" => x)
    /// Gets or sets the orientation
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the buttons style
    [<CustomOperation("ButtonJustifyContent")>] member inline _.ButtonJustifyContent ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.JustifyContent) = render ==> ("ButtonJustifyContent" => x)
    /// Gets or sets the buttons style
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonStyle) = render ==> ("ButtonStyle" => x)
    /// Gets or sets the design variant of the buttons.
    [<CustomOperation("ButtonVariant")>] member inline _.ButtonVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("ButtonVariant" => x)
    /// Gets or sets the color shade of the buttons.
    [<CustomOperation("ButtonShade")>] member inline _.ButtonShade ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Shade) = render ==> ("ButtonShade" => x)
    /// Gets or sets the buttons size.
    [<CustomOperation("ButtonSize")>] member inline _.ButtonSize ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonSize) = render ==> ("ButtonSize" => x)
    /// Gets or sets the source to target title
    [<CustomOperation("SourceToTargetTitle")>] member inline _.SourceToTargetTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SourceToTargetTitle" => x)
    /// Gets or sets the selected source to target title
    [<CustomOperation("SelectedSourceToTargetTitle")>] member inline _.SelectedSourceToTargetTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedSourceToTargetTitle" => x)
    /// Gets or sets the target to source title
    [<CustomOperation("TargetToSourceTitle")>] member inline _.TargetToSourceTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TargetToSourceTitle" => x)
    /// Gets or sets the selected target to source  title
    [<CustomOperation("SelectedTargetToSourceTitle")>] member inline _.SelectedTargetToSourceTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedTargetToSourceTitle" => x)
    /// Gets or sets the source to target icon
    [<CustomOperation("SourceToTargetIcon")>] member inline _.SourceToTargetIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SourceToTargetIcon" => x)
    /// Gets or sets the selected source to target icon
    [<CustomOperation("SelectedSourceToTargetIcon")>] member inline _.SelectedSourceToTargetIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedSourceToTargetIcon" => x)
    /// Gets or sets the target to source icon
    [<CustomOperation("TargetToSourceIcon")>] member inline _.TargetToSourceIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TargetToSourceIcon" => x)
    /// Gets or sets the selected target to source  icon
    [<CustomOperation("SelectedTargetToSourceIcon")>] member inline _.SelectedTargetToSourceIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedTargetToSourceIcon" => x)
    /// Gets or sets the source collection.
    [<CustomOperation("Source")>] member inline _.Source ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Source" => x)
    /// Gets or sets the source collection.
    [<CustomOperation("Source'")>] member inline _.Source' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TItem> * (System.Collections.Generic.IEnumerable<'TItem> -> unit)) = render ==> html.bind("Source", valueFn)
    /// Gets or sets the source changed.
    [<CustomOperation("SourceChanged")>] member inline _.SourceChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TItem> -> unit) = render ==> html.callback("SourceChanged", fn)
    /// Gets or sets the source changed.
    [<CustomOperation("SourceChanged")>] member inline _.SourceChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TItem> -> Task<unit>) = render ==> html.callbackTask("SourceChanged", fn)
    /// Gets or sets the target collection.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Target" => x)
    /// Gets or sets the target collection.
    [<CustomOperation("Target'")>] member inline _.Target' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TItem> * (System.Collections.Generic.IEnumerable<'TItem> -> unit)) = render ==> html.bind("Target", valueFn)
    /// Gets or sets the target changed.
    [<CustomOperation("TargetChanged")>] member inline _.TargetChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TItem> -> unit) = render ==> html.callback("TargetChanged", fn)
    /// Gets or sets the target changed.
    [<CustomOperation("TargetChanged")>] member inline _.TargetChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'TItem> -> Task<unit>) = render ==> html.callbackTask("TargetChanged", fn)

/// RadzenProfileMenuItem component.
type RadzenProfileMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Gets or sets the target.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Gets or sets the path.
    [<CustomOperation("Path")>] member inline _.Path ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Path" => x)
    /// Gets or sets the navigation link match.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the image.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

/// RadzenRadioButtonListItem component.
type RadzenRadioButtonListItemBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenRadioButtonListItem<'TValue> -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Gets or sets a value indicating whether this RadzenRadioButtonListItem`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenRadioButtonListItem`1 is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// Displays a collection of AppointmentData in day, week or month view.
type RadzenSchedulerBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template used to render appointments.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the additional content to be rendered in place of the default navigation buttons in the scheduler.
    /// This property allows for complete customization of the navigation controls, replacing the native date navigation buttons (such as year, month, and day) with user-defined content or buttons.
    /// Use this to add custom controls or interactive elements that better suit your application's requirements.
    /// This requires that the ShowHeader parameter to be set to true (enabled by default).
    [<CustomOperation("NavigationTemplate")>] member inline _.NavigationTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NavigationTemplate", fragment)
    /// Gets or sets the additional content to be rendered in place of the default navigation buttons in the scheduler.
    /// This property allows for complete customization of the navigation controls, replacing the native date navigation buttons (such as year, month, and day) with user-defined content or buttons.
    /// Use this to add custom controls or interactive elements that better suit your application's requirements.
    /// This requires that the ShowHeader parameter to be set to true (enabled by default).
    [<CustomOperation("NavigationTemplate")>] member inline _.NavigationTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NavigationTemplate", fragment { yield! fragments })
    /// Gets or sets the additional content to be rendered in place of the default navigation buttons in the scheduler.
    /// This property allows for complete customization of the navigation controls, replacing the native date navigation buttons (such as year, month, and day) with user-defined content or buttons.
    /// Use this to add custom controls or interactive elements that better suit your application's requirements.
    /// This requires that the ShowHeader parameter to be set to true (enabled by default).
    [<CustomOperation("NavigationTemplate")>] member inline _.NavigationTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NavigationTemplate", html.text x)
    /// Gets or sets the additional content to be rendered in place of the default navigation buttons in the scheduler.
    /// This property allows for complete customization of the navigation controls, replacing the native date navigation buttons (such as year, month, and day) with user-defined content or buttons.
    /// Use this to add custom controls or interactive elements that better suit your application's requirements.
    /// This requires that the ShowHeader parameter to be set to true (enabled by default).
    [<CustomOperation("NavigationTemplate")>] member inline _.NavigationTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NavigationTemplate", html.text x)
    /// Gets or sets the additional content to be rendered in place of the default navigation buttons in the scheduler.
    /// This property allows for complete customization of the navigation controls, replacing the native date navigation buttons (such as year, month, and day) with user-defined content or buttons.
    /// Use this to add custom controls or interactive elements that better suit your application's requirements.
    /// This requires that the ShowHeader parameter to be set to true (enabled by default).
    [<CustomOperation("NavigationTemplate")>] member inline _.NavigationTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NavigationTemplate", html.text x)
    /// Gets or sets the data of RadzenScheduler. It will display an appointment for every item of the collection which is within the current view date range.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Data" => x)
    /// Specifies the property of  which will set Start.
    [<CustomOperation("StartProperty")>] member inline _.StartProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartProperty" => x)
    /// Specifies the property of  which will set End.
    [<CustomOperation("EndProperty")>] member inline _.EndProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndProperty" => x)
    /// Specifies the initially selected view.
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// Gets or sets the text of the today button. Set to Today by default.
    [<CustomOperation("TodayText")>] member inline _.TodayText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TodayText" => x)
    /// Gets or sets the text of the next button. Set to Next by default.
    [<CustomOperation("NextText")>] member inline _.NextText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextText" => x)
    /// Gets or sets the text of the previous button. Set to Previous by default.
    [<CustomOperation("PrevText")>] member inline _.PrevText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevText" => x)
    /// Gets or sets the initial date displayed by the selected view. Set to DateTime.Today by default.
    [<CustomOperation("Date")>] member inline _.Date ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("Date" => x)
    /// Specifies the property of  which will set Text.
    [<CustomOperation("TextProperty")>] member inline _.TextProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextProperty" => x)
    /// Specifies whether to Show or Hide the Scheduler Header. Defaults to true />.
    [<CustomOperation("ShowHeader")>] member inline _.ShowHeader ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowHeader" =>>> true)
    /// Specifies whether to Show or Hide the Scheduler Header. Defaults to true />.
    [<CustomOperation("ShowHeader")>] member inline _.ShowHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowHeader" =>>> x)
    /// A callback that will be invoked when the user clicks a slot in the current view. Commonly used to add new appointments.
    [<CustomOperation("SlotSelect")>] member inline _.SlotSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerSlotSelectEventArgs -> unit) = render ==> html.callback("SlotSelect", fn)
    /// A callback that will be invoked when the user clicks a slot in the current view. Commonly used to add new appointments.
    [<CustomOperation("SlotSelect")>] member inline _.SlotSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerSlotSelectEventArgs -> Task<unit>) = render ==> html.callbackTask("SlotSelect", fn)
    /// A callback that will be invoked when the user clicks the Today button.
    [<CustomOperation("TodaySelect")>] member inline _.TodaySelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerTodaySelectEventArgs -> unit) = render ==> html.callback("TodaySelect", fn)
    /// A callback that will be invoked when the user clicks the Today button.
    [<CustomOperation("TodaySelect")>] member inline _.TodaySelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerTodaySelectEventArgs -> Task<unit>) = render ==> html.callbackTask("TodaySelect", fn)
    /// A callback that will be invoked when the user clicks a month header button.
    [<CustomOperation("MonthSelect")>] member inline _.MonthSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerMonthSelectEventArgs -> unit) = render ==> html.callback("MonthSelect", fn)
    /// A callback that will be invoked when the user clicks a month header button.
    [<CustomOperation("MonthSelect")>] member inline _.MonthSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerMonthSelectEventArgs -> Task<unit>) = render ==> html.callbackTask("MonthSelect", fn)
    /// A callback that will be invoked when the user clicks a day header button or the day number in a MonthView.
    [<CustomOperation("DaySelect")>] member inline _.DaySelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerDaySelectEventArgs -> unit) = render ==> html.callback("DaySelect", fn)
    /// A callback that will be invoked when the user clicks a day header button or the day number in a MonthView.
    [<CustomOperation("DaySelect")>] member inline _.DaySelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerDaySelectEventArgs -> Task<unit>) = render ==> html.callbackTask("DaySelect", fn)
    /// A callback that will be invoked when the user clicks an appointment in the current view. Commonly used to edit existing appointments.
    [<CustomOperation("AppointmentSelect")>] member inline _.AppointmentSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerAppointmentSelectEventArgs<'TItem> -> unit) = render ==> html.callback("AppointmentSelect", fn)
    /// A callback that will be invoked when the user clicks an appointment in the current view. Commonly used to edit existing appointments.
    [<CustomOperation("AppointmentSelect")>] member inline _.AppointmentSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerAppointmentSelectEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("AppointmentSelect", fn)
    /// A callback that will be invoked when the user moves the mouse over an appointment in the current view.
    [<CustomOperation("AppointmentMouseEnter")>] member inline _.AppointmentMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.SchedulerAppointmentMouseEventArgs<'TItem> -> unit) = render ==> html.callback("AppointmentMouseEnter", fn)
    /// A callback that will be invoked when the user moves the mouse over an appointment in the current view.
    [<CustomOperation("AppointmentMouseEnter")>] member inline _.AppointmentMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.SchedulerAppointmentMouseEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("AppointmentMouseEnter", fn)
    /// A callback that will be invoked when the user moves the mouse out of an appointment in the current view.
    [<CustomOperation("AppointmentMouseLeave")>] member inline _.AppointmentMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.SchedulerAppointmentMouseEventArgs<'TItem> -> unit) = render ==> html.callback("AppointmentMouseLeave", fn)
    /// A callback that will be invoked when the user moves the mouse out of an appointment in the current view.
    [<CustomOperation("AppointmentMouseLeave")>] member inline _.AppointmentMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.SchedulerAppointmentMouseEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("AppointmentMouseLeave", fn)
    /// A callback that will be invoked when the user clicks the more text in the current view. Commonly used to view additional appointments.
    /// Invoke the PreventDefault method to prevent the default action (showing the additional appointments).
    [<CustomOperation("MoreSelect")>] member inline _.MoreSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerMoreSelectEventArgs -> unit) = render ==> html.callback("MoreSelect", fn)
    /// A callback that will be invoked when the user clicks the more text in the current view. Commonly used to view additional appointments.
    /// Invoke the PreventDefault method to prevent the default action (showing the additional appointments).
    [<CustomOperation("MoreSelect")>] member inline _.MoreSelect ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerMoreSelectEventArgs -> Task<unit>) = render ==> html.callbackTask("MoreSelect", fn)
    /// An action that will be invoked when the current view renders an appointment. Never call StateHasChanged when handling AppointmentRender.
    [<CustomOperation("AppointmentRender")>] member inline _.AppointmentRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("AppointmentRender" => (System.Action<Radzen.SchedulerAppointmentRenderEventArgs<'TItem>>fn))
    /// An action that will be invoked when the current view renders an slot. Never call StateHasChanged when handling SlotRender.
    [<CustomOperation("SlotRender")>] member inline _.SlotRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SlotRender" => (System.Action<Radzen.SchedulerSlotRenderEventArgs>fn))
    /// A callback that will be invoked when the scheduler needs data for the current view. Commonly used to filter the
    /// data assigned to Data.
    [<CustomOperation("LoadData")>] member inline _.LoadData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerLoadDataEventArgs -> unit) = render ==> html.callback("LoadData", fn)
    /// A callback that will be invoked when the scheduler needs data for the current view. Commonly used to filter the
    /// data assigned to Data.
    [<CustomOperation("LoadData")>] member inline _.LoadData ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerLoadDataEventArgs -> Task<unit>) = render ==> html.callbackTask("LoadData", fn)
    /// A callback that will be invoked when an appointment is being dragged and then dropped on a different slot.
    /// Commonly used to change it to a different timeslot.
    [<CustomOperation("AppointmentMove")>] member inline _.AppointmentMove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerAppointmentMoveEventArgs -> unit) = render ==> html.callback("AppointmentMove", fn)
    /// A callback that will be invoked when an appointment is being dragged and then dropped on a different slot.
    /// Commonly used to change it to a different timeslot.
    [<CustomOperation("AppointmentMove")>] member inline _.AppointmentMove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerAppointmentMoveEventArgs -> Task<unit>) = render ==> html.callbackTask("AppointmentMove", fn)

/// RadzenSelectBarItem component.
type RadzenSelectBarItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenSelectBarItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the image.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Gets or sets the image style.
    [<CustomOperation("ImageStyle")>] member inline _.ImageStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageStyle" => x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Gets or sets a value indicating whether this RadzenSelectBarItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSelectBarItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// RadzenSidebarToggle component.
type RadzenSidebarToggleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.EventArgs -> unit) = render ==> html.callback("Click", fn)
    /// Gets or sets the click callback.
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.EventArgs -> Task<unit>) = render ==> html.callbackTask("Click", fn)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the add button aria-label attribute.
    [<CustomOperation("ToggleAriaLabel")>] member inline _.ToggleAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggleAriaLabel" => x)

/// RadzenSpeechToTextButton component. Enables speech to text functionality.
/// This is only supported on select browsers. See https://caniuse.com/?search=SpeechRecognition
/// 
/// 
/// <RadzenSpeechToTextButton Change=@(args => Console.WriteLine($"Value: {args}")) />
type RadzenSpeechToTextButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the button style.
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.ButtonStyle) = render ==> ("ButtonStyle" => x)
    /// Gets or sets the icon displayed while not recording.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the icon displayed while recording.
    [<CustomOperation("StopIcon")>] member inline _.StopIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StopIcon" => x)
    /// Gets or sets the message displayed when user hovers the button and it is not recording.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the message displayed when user hovers the button and it is recording.
    [<CustomOperation("StopTitle")>] member inline _.StopTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StopTitle" => x)
    /// Callback which provides results from the speech recognition API.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("Change", fn)
    /// Callback which provides results from the speech recognition API.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// Gets or sets the icon displayed while recording.
    [<CustomOperation("Language")>] member inline _.Language ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Language" => x)

/// RadzenSplitButtonItem component.
type RadzenSplitButtonItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Gets or sets a value indicating whether this RadzenSplitButtonItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSplitButtonItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// RadzenSplitter component.
type RadzenSplitterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the orientation.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the collapse callback.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.RadzenSplitterEventArgs -> unit) = render ==> html.callback("Collapse", fn)
    /// Gets or sets the collapse callback.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.RadzenSplitterEventArgs -> Task<unit>) = render ==> html.callbackTask("Collapse", fn)
    /// Gets or sets the expand callback.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.RadzenSplitterEventArgs -> unit) = render ==> html.callback("Expand", fn)
    /// Gets or sets the expand callback.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.RadzenSplitterEventArgs -> Task<unit>) = render ==> html.callbackTask("Expand", fn)
    /// Gets or sets the resize callback.
    [<CustomOperation("Resize")>] member inline _.Resize ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.RadzenSplitterResizeEventArgs -> unit) = render ==> html.callback("Resize", fn)
    /// Gets or sets the resize callback.
    [<CustomOperation("Resize")>] member inline _.Resize ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.RadzenSplitterResizeEventArgs -> Task<unit>) = render ==> html.callbackTask("Resize", fn)

/// RadzenSplitterPane component.
type RadzenSplitterPaneBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether this RadzenSplitterPane is collapsible.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSplitterPane is collapsible.
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsible" =>>> x)
    /// Gets or sets a value indicating whether this RadzenSplitterPane is collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Collapsed" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSplitterPane is collapsed.
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Collapsed" =>>> x)
    /// Gets or sets a value indicating whether this RadzenSplitterPane is resizable.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Resizable" =>>> true)
    /// Gets or sets a value indicating whether this RadzenSplitterPane is resizable.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Resizable" =>>> x)
    /// Determines the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Max" => x)
    /// Determines the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Min" => x)
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    /// Gets or sets the visibility of the splitter bar.
    [<CustomOperation("BarVisible")>] member inline _.BarVisible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("BarVisible" =>>> true)
    /// Gets or sets the visibility of the splitter bar.
    [<CustomOperation("BarVisible")>] member inline _.BarVisible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("BarVisible" =>>> x)

/// RadzenSSRSViewer component.
type RadzenSSRSViewerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether to use proxy.
    [<CustomOperation("UseProxy")>] member inline _.UseProxy ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseProxy" =>>> true)
    /// Gets or sets a value indicating whether to use proxy.
    [<CustomOperation("UseProxy")>] member inline _.UseProxy ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseProxy" =>>> x)
    /// Gets or sets the report server URL.
    [<CustomOperation("ReportServer")>] member inline _.ReportServer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ReportServer" => x)
    /// Gets or sets the local server URL.
    [<CustomOperation("LocalServer")>] member inline _.LocalServer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LocalServer" => x)
    /// Gets or sets the name of the report.
    [<CustomOperation("ReportName")>] member inline _.ReportName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ReportName" => x)
    /// Gets or sets the parameters.
    [<CustomOperation("Parameters")>] member inline _.Parameters ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Parameters", fragment)
    /// Gets or sets the parameters.
    [<CustomOperation("Parameters")>] member inline _.Parameters ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Parameters", fragment { yield! fragments })
    /// Gets or sets the parameters.
    [<CustomOperation("Parameters")>] member inline _.Parameters ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Parameters", html.text x)
    /// Gets or sets the parameters.
    [<CustomOperation("Parameters")>] member inline _.Parameters ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Parameters", html.text x)
    /// Gets or sets the parameters.
    [<CustomOperation("Parameters")>] member inline _.Parameters ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Parameters", html.text x)
    /// Gets or sets the load callback.
    [<CustomOperation("Load")>] member inline _.Load ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.ProgressEventArgs -> unit) = render ==> html.callback("Load", fn)
    /// Gets or sets the load callback.
    [<CustomOperation("Load")>] member inline _.Load ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.ProgressEventArgs -> Task<unit>) = render ==> html.callbackTask("Load", fn)

/// RadzenSteps component.
type RadzenStepsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether to show steps buttons.
    [<CustomOperation("ShowStepsButtons")>] member inline _.ShowStepsButtons ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowStepsButtons" =>>> true)
    /// Gets or sets a value indicating whether to show steps buttons.
    [<CustomOperation("ShowStepsButtons")>] member inline _.ShowStepsButtons ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowStepsButtons" =>>> x)
    /// Gets or sets the selected index.
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// Gets or sets the selected index.
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    /// Gets or sets the selected index changed callback.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("SelectedIndexChanged", fn)
    /// Gets or sets the selected index changed callback.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedIndexChanged", fn)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("Change", fn)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// A callback that will be invoked when the user tries to change the step.
    /// Invoke the PreventDefault method to prevent this change.
    [<CustomOperation("CanChange")>] member inline _.CanChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.StepsCanChangeEventArgs -> unit) = render ==> html.callback("CanChange", fn)
    /// A callback that will be invoked when the user tries to change the step.
    /// Invoke the PreventDefault method to prevent this change.
    [<CustomOperation("CanChange")>] member inline _.CanChange ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.StepsCanChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("CanChange", fn)
    /// Gets or sets the next button text.
    [<CustomOperation("NextText")>] member inline _.NextText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextText" => x)
    /// Gets or sets the previous button text.
    [<CustomOperation("PreviousText")>] member inline _.PreviousText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviousText" => x)
    /// Gets or sets the next button title attribute.
    [<CustomOperation("NextTitle")>] member inline _.NextTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextTitle" => x)
    /// Gets or sets the previous button title attribute.
    [<CustomOperation("PreviousTitle")>] member inline _.PreviousTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviousTitle" => x)
    /// Gets or sets the steps.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Steps", fragment)
    /// Gets or sets the steps.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Steps", fragment { yield! fragments })
    /// Gets or sets the steps.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Steps", html.text x)
    /// Gets or sets the steps.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Steps", html.text x)
    /// Gets or sets the steps.
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Steps", html.text x)
    [<CustomOperation("AllowStepSelect")>] member inline _.AllowStepSelect ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowStepSelect" =>>> true)
    [<CustomOperation("AllowStepSelect")>] member inline _.AllowStepSelect ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowStepSelect" =>>> x)

/// RadzenStepsItem component.
type RadzenStepsItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets text of the next button.
    [<CustomOperation("NextText")>] member inline _.NextText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextText" => x)
    /// Gets or sets text of the previous button.
    [<CustomOperation("PreviousText")>] member inline _.PreviousText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviousText" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenStepsItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets a value indicating whether this RadzenStepsItem is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Gets or sets a value indicating whether this RadzenStepsItem is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Gets or sets a value indicating whether this RadzenComponent is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenComponent is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets a value indicating whether this RadzenStepsItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenStepsItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// RadzenTabs component.
type RadzenTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the render mode.
    [<CustomOperation("RenderMode")>] member inline _.RenderMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.TabRenderMode) = render ==> ("RenderMode" => x)
    /// Gets or sets the tab position.
    [<CustomOperation("TabPosition")>] member inline _.TabPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.TabPosition) = render ==> ("TabPosition" => x)
    /// Gets or sets the selected index.
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// Gets or sets the selected index.
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    /// Gets or sets the selected index changed callback.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("SelectedIndexChanged", fn)
    /// Gets or sets the selected index changed callback.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedIndexChanged", fn)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("Change", fn)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// Gets or sets the tabs.
    [<CustomOperation("Tabs")>] member inline _.Tabs ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Tabs", fragment)
    /// Gets or sets the tabs.
    [<CustomOperation("Tabs")>] member inline _.Tabs ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Tabs", fragment { yield! fragments })
    /// Gets or sets the tabs.
    [<CustomOperation("Tabs")>] member inline _.Tabs ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Tabs", html.text x)
    /// Gets or sets the tabs.
    [<CustomOperation("Tabs")>] member inline _.Tabs ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Tabs", html.text x)
    /// Gets or sets the tabs.
    [<CustomOperation("Tabs")>] member inline _.Tabs ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Tabs", html.text x)

/// A component which represents a form. Provides validation support.
type RadzenTemplateFormBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Specifies the model of the form. Required to support validation.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("Data" => x)
    /// Gets or sets the child content.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.EditContext -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// A callback that will be invoked when the user submits the form and IsValid is true.
    [<CustomOperation("Submit")>] member inline _.Submit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> unit) = render ==> html.callback("Submit", fn)
    /// A callback that will be invoked when the user submits the form and IsValid is true.
    [<CustomOperation("Submit")>] member inline _.Submit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("Submit", fn)
    /// Obsolete. Use InvalidSubmit instead.
    [<CustomOperation("OnInvalidSubmit")>] member inline _.OnInvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.FormInvalidSubmitEventArgs -> unit) = render ==> html.callback("OnInvalidSubmit", fn)
    /// Obsolete. Use InvalidSubmit instead.
    [<CustomOperation("OnInvalidSubmit")>] member inline _.OnInvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.FormInvalidSubmitEventArgs -> Task<unit>) = render ==> html.callbackTask("OnInvalidSubmit", fn)
    /// A callback that will be invoked when the user submits the form and IsValid is false.
    [<CustomOperation("InvalidSubmit")>] member inline _.InvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.FormInvalidSubmitEventArgs -> unit) = render ==> html.callback("InvalidSubmit", fn)
    /// A callback that will be invoked when the user submits the form and IsValid is false.
    [<CustomOperation("InvalidSubmit")>] member inline _.InvalidSubmit ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.FormInvalidSubmitEventArgs -> Task<unit>) = render ==> html.callbackTask("InvalidSubmit", fn)
    /// Specifies the form method attribute. Used together with Action.
    [<CustomOperation("Method")>] member inline _.Method ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Method" => x)
    /// Specifies the form action attribute. When set the form submits to the specified URL.
    [<CustomOperation("Action")>] member inline _.Action ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Action" => x)
    /// Gets or sets the edit context.
    [<CustomOperation("EditContext")>] member inline _.EditContext ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Forms.EditContext) = render ==> ("EditContext" => x)

/// A component which displays text or makup with predefined styling.
type RadzenTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// The text that will be displayed.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The style of the text. Set to Body1 by default.
    [<CustomOperation("TextStyle")>] member inline _.TextStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.TextStyle) = render ==> ("TextStyle" => x)
    /// The horozontal alignment of the text.
    [<CustomOperation("TextAlign")>] member inline _.TextAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.TextAlign) = render ==> ("TextAlign" => x)
    /// The tag name of the element that will be rendered. Set to Auto which uses a default tag name depending on the current TextStyle.
    [<CustomOperation("TagName")>] member inline _.TagName ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.TagName) = render ==> ("TagName" => x)
    /// Gets or sets the anchor name. If set an additional anchor will be rendered. Clicking on the anchor will scroll the page to the element with the same id.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Anchor" => x)

/// RadzenTimeline component is a graphical representation used to display a chronological sequence of events or data points.
type RadzenTimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Items", fragment)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Items", fragment { yield! fragments })
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Items", html.text x)
    /// Gets or sets the items.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Items", html.text x)
    /// Specifies the orientation - whether items flow in horizontal or vertical direction. Set to Orientation.Vertical by default.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Specifies the line position. Set to LinePosition.Center by default.
    [<CustomOperation("LinePosition")>] member inline _.LinePosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.LinePosition) = render ==> ("LinePosition" => x)
    /// Specifies if the LinePosition is reversed.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Reverse" =>>> true)
    /// Specifies if the LinePosition is reversed.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Reverse" =>>> x)
    /// Specifies the alignment of LabelContent, PointContent and ChildContent inside TimelineItems. Set to AlignItems.Center by default.
    [<CustomOperation("AlignItems")>] member inline _.AlignItems ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.AlignItems) = render ==> ("AlignItems" => x)

/// RadzenTimeline item.
type RadzenTimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the label content.
    [<CustomOperation("LabelContent")>] member inline _.LabelContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LabelContent", fragment)
    /// Gets or sets the label content.
    [<CustomOperation("LabelContent")>] member inline _.LabelContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LabelContent", fragment { yield! fragments })
    /// Gets or sets the label content.
    [<CustomOperation("LabelContent")>] member inline _.LabelContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelContent", html.text x)
    /// Gets or sets the label content.
    [<CustomOperation("LabelContent")>] member inline _.LabelContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelContent", html.text x)
    /// Gets or sets the label content.
    [<CustomOperation("LabelContent")>] member inline _.LabelContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelContent", html.text x)
    /// Gets or sets the label.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets the content inside a point on the timeline.
    [<CustomOperation("PointContent")>] member inline _.PointContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("PointContent", fragment)
    /// Gets or sets the content inside a point on the timeline.
    [<CustomOperation("PointContent")>] member inline _.PointContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("PointContent", fragment { yield! fragments })
    /// Gets or sets the content inside a point on the timeline.
    [<CustomOperation("PointContent")>] member inline _.PointContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PointContent", html.text x)
    /// Gets or sets the content inside a point on the timeline.
    [<CustomOperation("PointContent")>] member inline _.PointContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PointContent", html.text x)
    /// Gets or sets the content inside a point on the timeline.
    [<CustomOperation("PointContent")>] member inline _.PointContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PointContent", html.text x)
    /// Specifies the Point size from ExtraSmall to Large. Set to PointSize.Medium by default.
    [<CustomOperation("PointSize")>] member inline _.PointSize ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.PointSize) = render ==> ("PointSize" => x)
    /// Gets or sets the Point style. Set to PointStyle.Base by default.
    [<CustomOperation("PointStyle")>] member inline _.PointStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.PointStyle) = render ==> ("PointStyle" => x)
    /// Specifies if the Point variant is filled, flat, outlined or text only. Set to Variant.Filled by default.
    [<CustomOperation("PointVariant")>] member inline _.PointVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Variant) = render ==> ("PointVariant" => x)
    /// Specifies the Shadow level from 0 (no shadow) to 10. Set to 1 by default.
    [<CustomOperation("PointShadow")>] member inline _.PointShadow ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PointShadow" => x)

/// RadzenTimeSpanPicker component.
type RadzenTimeSpanPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Specifies the value of the component.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    /// Specifies the value of the component.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TValue * ('TValue -> unit)) = render ==> html.bind("Value", valueFn)
    /// Specifies the minimum time stamp allowed.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("Min" => x)
    /// Specifies the maximum time stamp allowed.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("Max" => x)
    /// Specifies whether the value can be cleared.
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowClear" =>>> true)
    /// Specifies whether the value can be cleared.
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowClear" =>>> x)
    /// Specifies whether input in the input field is allowed.
    /// Set to true by default.
    [<CustomOperation("AllowInput")>] member inline _.AllowInput ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowInput" =>>> true)
    /// Specifies whether input in the input field is allowed.
    /// Set to true by default.
    [<CustomOperation("AllowInput")>] member inline _.AllowInput ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowInput" =>>> x)
    /// Specifies whether the input field is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Specifies whether the input field is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Specifies whether the input field is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Specifies whether the input field is read only.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Specifies whether to display popup icon button in the input field.
    [<CustomOperation("ShowPopupButton")>] member inline _.ShowPopupButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowPopupButton" =>>> true)
    /// Specifies whether to display popup icon button in the input field.
    [<CustomOperation("ShowPopupButton")>] member inline _.ShowPopupButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowPopupButton" =>>> x)
    /// Specifies the popup toggle button CSS classes, separated with spaces.
    [<CustomOperation("PopupButtonClass")>] member inline _.PopupButtonClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupButtonClass" => x)
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Specifies the input CSS classes, separated with spaces.
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// Specifies the name of the input field.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Specifies the tab index.
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TabIndex" => x)
    /// Specifies the time span format in the input field.
    /// For more details, see the documentation of
    /// standard
    /// and custom
    /// time span format strings.
    [<CustomOperation("TimeSpanFormat")>] member inline _.TimeSpanFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeSpanFormat" => x)
    /// Specifies custom function to parse the input.
    /// If it's not defined or the function it returns null, a built-in parser us used instead.
    [<CustomOperation("ParseInput")>] member inline _.ParseInput ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ParseInput" => (System.Func<System.String, System.Nullable<System.TimeSpan>>fn))
    /// Specifies the input placeholder.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Specifies the aria label for the toggle popup button.
    [<CustomOperation("TogglePopupAriaLabel")>] member inline _.TogglePopupAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TogglePopupAriaLabel" => x)
    /// Specifies the render mode of the popup.
    [<CustomOperation("PopupRenderMode")>] member inline _.PopupRenderMode ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.PopupRenderMode) = render ==> ("PopupRenderMode" => x)
    /// Specifies whether the component is inline or shows a popup.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Inline" =>>> true)
    /// Specifies whether the component is inline or shows a popup.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Inline" =>>> x)
    /// Specifies whether to display the confirmation button in the panel to accept changes.
    [<CustomOperation("ShowConfirmationButton")>] member inline _.ShowConfirmationButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowConfirmationButton" =>>> true)
    /// Specifies whether to display the confirmation button in the panel to accept changes.
    [<CustomOperation("ShowConfirmationButton")>] member inline _.ShowConfirmationButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowConfirmationButton" =>>> x)
    /// Specifies whether the time fields in the panel, except for the days field, are padded with leading zeros.
    [<CustomOperation("PadTimeValues")>] member inline _.PadTimeValues ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PadTimeValues" =>>> true)
    /// Specifies whether the time fields in the panel, except for the days field, are padded with leading zeros.
    [<CustomOperation("PadTimeValues")>] member inline _.PadTimeValues ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PadTimeValues" =>>> x)
    /// Specifies the most precise time unit field in the picker panel. Set to Second by default.
    [<CustomOperation("FieldPrecision")>] member inline _.FieldPrecision ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.TimeSpanUnit) = render ==> ("FieldPrecision" => x)
    /// Specifies the step of the days field in the picker panel.
    [<CustomOperation("DaysStep")>] member inline _.DaysStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DaysStep" => x)
    /// Specifies the step of the hours field in the picker panel.
    [<CustomOperation("HoursStep")>] member inline _.HoursStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HoursStep" => x)
    /// Specifies the step of the minutes field in the picker panel.
    [<CustomOperation("MinutesStep")>] member inline _.MinutesStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinutesStep" => x)
    /// Specifies the step of the seconds field in the picker panel.
    [<CustomOperation("SecondsStep")>] member inline _.SecondsStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SecondsStep" => x)
    /// Specifies the step of the milliseconds field in the picker panel.
    [<CustomOperation("MillisecondsStep")>] member inline _.MillisecondsStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MillisecondsStep" => x)
    /// Specifies the step of the microseconds field in the picker panel.
    [<CustomOperation("MicrosecondsStep")>] member inline _.MicrosecondsStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MicrosecondsStep" => x)
    /// Specifies the text of the confirmation button. Used only if ShowConfirmationButton is true.
    [<CustomOperation("ConfirmationButtonText")>] member inline _.ConfirmationButtonText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ConfirmationButtonText" => x)
    /// Specifies the text of the positive value button.
    [<CustomOperation("PositiveButtonText")>] member inline _.PositiveButtonText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PositiveButtonText" => x)
    /// Specifies the text of the negative value button.
    [<CustomOperation("NegativeButtonText")>] member inline _.NegativeButtonText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NegativeButtonText" => x)
    /// Specifies the text displayed next to the fields in the panel when the value is positive and there's no sign picker.
    [<CustomOperation("PositiveValueText")>] member inline _.PositiveValueText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PositiveValueText" => x)
    /// Specifies the text displayed next to the fields in the panel when the value is negative and there's no sign picker.
    [<CustomOperation("NegativeValueText")>] member inline _.NegativeValueText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NegativeValueText" => x)
    /// Specifies the days label text.
    [<CustomOperation("DaysUnitText")>] member inline _.DaysUnitText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DaysUnitText" => x)
    /// Specifies the hours label text.
    [<CustomOperation("HoursUnitText")>] member inline _.HoursUnitText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HoursUnitText" => x)
    /// Specifies the minutes label text.
    [<CustomOperation("MinutesUnitText")>] member inline _.MinutesUnitText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinutesUnitText" => x)
    /// Specifies the seconds label text.
    [<CustomOperation("SecondsUnitText")>] member inline _.SecondsUnitText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SecondsUnitText" => x)
    /// Specifies the milliseconds label text.
    [<CustomOperation("MillisecondsUnitText")>] member inline _.MillisecondsUnitText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MillisecondsUnitText" => x)
    /// Specifies the microseconds label text.
    [<CustomOperation("MicrosecondsUnitText")>] member inline _.MicrosecondsUnitText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MicrosecondsUnitText" => x)
    /// Specifies the value expression used while creating the FieldIdentifier.
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("ValueExpression" => x)
    /// Specifies the callback of the value change.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TValue -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Specifies the callback of the value change.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Specifies the callback of the underlying nullable TimeSpan value.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.TimeSpan> -> unit) = render ==> html.callback("Change", fn)
    /// Specifies the callback of the underlying nullable TimeSpan value.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.TimeSpan> -> Task<unit>) = render ==> html.callbackTask("Change", fn)

/// Displays a table of contents for a page.
type RadzenTocBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the orientation of the table of contents.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Orientation) = render ==> ("Orientation" => x)
    /// Gets or sets the CSS selector of the element to monitor for scroll events. By default the entire page is monitored.
    [<CustomOperation("Selector")>] member inline _.Selector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)

/// A component which displays a hierarchy of items. Supports inline definition and data-binding.
type RadzenTreeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the open button aria-label attribute.
    [<CustomOperation("SelectItemAriaLabel")>] member inline _.SelectItemAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectItemAriaLabel" => x)
    /// A callback that will be invoked when the user selects an item.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.TreeEventArgs -> unit) = render ==> html.callback("Change", fn)
    /// A callback that will be invoked when the user selects an item.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.TreeEventArgs -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// A callback that will be invoked when the user expands an item.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.TreeExpandEventArgs -> unit) = render ==> html.callback("Expand", fn)
    /// A callback that will be invoked when the user expands an item.
    [<CustomOperation("Expand")>] member inline _.Expand ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.TreeExpandEventArgs -> Task<unit>) = render ==> html.callbackTask("Expand", fn)
    /// A callback that will be invoked when the user collapse an item.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.TreeEventArgs -> unit) = render ==> html.callback("Collapse", fn)
    /// A callback that will be invoked when the user collapse an item.
    [<CustomOperation("Collapse")>] member inline _.Collapse ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.TreeEventArgs -> Task<unit>) = render ==> html.callbackTask("Collapse", fn)
    /// A callback that will be invoked when item is rendered.
    [<CustomOperation("ItemRender")>] member inline _.ItemRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemRender" => (System.Action<Radzen.TreeItemRenderEventArgs>fn))
    /// Gets or sets the context menu callback.
    [<CustomOperation("ItemContextMenu")>] member inline _.ItemContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.TreeItemContextMenuEventArgs -> unit) = render ==> html.callback("ItemContextMenu", fn)
    /// Gets or sets the context menu callback.
    [<CustomOperation("ItemContextMenu")>] member inline _.ItemContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.TreeItemContextMenuEventArgs -> Task<unit>) = render ==> html.callbackTask("ItemContextMenu", fn)
    /// Specifies the collection of data items which RadzenTree will create its items from.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.IEnumerable) = render ==> ("Data" => x)
    /// Specifies the selected value. Use with @bind-Value to sync it with a property.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Specifies the selected value. Use with @bind-Value to sync it with a property.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Object * (System.Object -> unit)) = render ==> html.bind("Value", valueFn)
    /// A callback which will be invoked when Value changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> unit) = render ==> html.callback("ValueChanged", fn)
    /// A callback which will be invoked when Value changes.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Specifies whether RadzenTree displays check boxes. Set to false by default.
    [<CustomOperation("AllowCheckBoxes")>] member inline _.AllowCheckBoxes ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowCheckBoxes" =>>> true)
    /// Specifies whether RadzenTree displays check boxes. Set to false by default.
    [<CustomOperation("AllowCheckBoxes")>] member inline _.AllowCheckBoxes ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowCheckBoxes" =>>> x)
    /// Specifies what happens when a parent item is checked. If set to true checking parent items also checks all of its children.
    [<CustomOperation("AllowCheckChildren")>] member inline _.AllowCheckChildren ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowCheckChildren" =>>> true)
    /// Specifies what happens when a parent item is checked. If set to true checking parent items also checks all of its children.
    [<CustomOperation("AllowCheckChildren")>] member inline _.AllowCheckChildren ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowCheckChildren" =>>> x)
    /// Specifies what happens with a parent item when one of its children is checked. If set to true checking a child item will affect the checked state of its parents.
    [<CustomOperation("AllowCheckParents")>] member inline _.AllowCheckParents ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowCheckParents" =>>> true)
    /// Specifies what happens with a parent item when one of its children is checked. If set to true checking a child item will affect the checked state of its parents.
    [<CustomOperation("AllowCheckParents")>] member inline _.AllowCheckParents ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowCheckParents" =>>> x)
    /// Specifies whether siblings items are collapsed. Set to false by default.
    [<CustomOperation("SingleExpand")>] member inline _.SingleExpand ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SingleExpand" =>>> true)
    /// Specifies whether siblings items are collapsed. Set to false by default.
    [<CustomOperation("SingleExpand")>] member inline _.SingleExpand ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SingleExpand" =>>> x)
    /// Gets or sets the checked values. Use with @bind-CheckedValues to sync it with a property.
    [<CustomOperation("CheckedValues")>] member inline _.CheckedValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.Object>) = render ==> ("CheckedValues" => x)
    /// Gets or sets the checked values. Use with @bind-CheckedValues to sync it with a property.
    [<CustomOperation("CheckedValues'")>] member inline _.CheckedValues' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<System.Object> * (System.Collections.Generic.IEnumerable<System.Object> -> unit)) = render ==> html.bind("CheckedValues", valueFn)
    /// Gets or sets the CSS classes added to the item content.
    [<CustomOperation("ItemContentCssClass")>] member inline _.ItemContentCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ItemContentCssClass" => x)
    /// Gets or sets the CSS classes added to the item icon.
    [<CustomOperation("ItemIconCssClass")>] member inline _.ItemIconCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ItemIconCssClass" => x)
    /// Gets or sets the CSS classes added to the item label.
    [<CustomOperation("ItemLabelCssClass")>] member inline _.ItemLabelCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ItemLabelCssClass" => x)
    /// A callback which will be invoked when CheckedValues changes.
    [<CustomOperation("CheckedValuesChanged")>] member inline _.CheckedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<System.Object> -> unit) = render ==> html.callback("CheckedValuesChanged", fn)
    /// A callback which will be invoked when CheckedValues changes.
    [<CustomOperation("CheckedValuesChanged")>] member inline _.CheckedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<System.Object> -> Task<unit>) = render ==> html.callbackTask("CheckedValuesChanged", fn)

/// RadzenUpload component.
type RadzenUploadBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text.
    [<CustomOperation("ImageAlternateText")>] member inline _.ImageAlternateText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageAlternateText" => x)
    /// Specifies additional custom attributes that will be rendered by the input.
    [<CustomOperation("InputAttributes")>] member inline _.InputAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("InputAttributes" => x)
    /// Gets or sets the name.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Gets or sets a value indicating whether this RadzenUpload upload is automatic.
    [<CustomOperation("Auto")>] member inline _.Auto ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Auto" =>>> true)
    /// Gets or sets a value indicating whether this RadzenUpload upload is automatic.
    [<CustomOperation("Auto")>] member inline _.Auto ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Auto" =>>> x)
    /// Gets or sets the choose button text.
    [<CustomOperation("ChooseText")>] member inline _.ChooseText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ChooseText" => x)
    /// Gets or sets the choose button text.
    [<CustomOperation("DeleteText")>] member inline _.DeleteText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DeleteText" => x)
    /// Gets or sets the URL.
    [<CustomOperation("Url")>] member inline _.Url ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Url" => x)
    /// Gets or sets the parameter name. If not set 'file' parameter name will be used for single file and 'files' for multiple files.
    [<CustomOperation("ParameterName")>] member inline _.ParameterName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ParameterName" => x)
    /// Gets or sets the accepted MIME types.
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    /// Gets or sets a value indicating whether this RadzenUpload is multiple.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Multiple" =>>> true)
    /// Gets or sets a value indicating whether this RadzenUpload is multiple.
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Multiple" =>>> x)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets the maximum number of files.
    [<CustomOperation("MaxFileCount")>] member inline _.MaxFileCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxFileCount" => x)
    /// Gets or sets a value indicating whether this RadzenUpload is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenUpload is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadChangeEventArgs -> unit) = render ==> html.callback("Change", fn)
    /// Gets or sets the change callback.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    /// Gets or sets the progress callback.
    [<CustomOperation("Progress")>] member inline _.Progress ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadProgressArgs -> unit) = render ==> html.callback("Progress", fn)
    /// Gets or sets the progress callback.
    [<CustomOperation("Progress")>] member inline _.Progress ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadProgressArgs -> Task<unit>) = render ==> html.callbackTask("Progress", fn)
    /// Gets or sets the complete callback.
    [<CustomOperation("Complete")>] member inline _.Complete ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadCompleteEventArgs -> unit) = render ==> html.callback("Complete", fn)
    /// Gets or sets the complete callback.
    [<CustomOperation("Complete")>] member inline _.Complete ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadCompleteEventArgs -> Task<unit>) = render ==> html.callbackTask("Complete", fn)
    /// Gets or sets the error callback.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadErrorEventArgs -> unit) = render ==> html.callback("Error", fn)
    /// Gets or sets the error callback.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.UploadErrorEventArgs -> Task<unit>) = render ==> html.callbackTask("Error", fn)

            
namespace rec Radzen.Blazor.DslInternals.Blazor.Rendering

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

type DraggableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DragStart")>] member inline _.DragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.Rendering.DraggableEventArgs -> unit) = render ==> html.callback("DragStart", fn)
    [<CustomOperation("DragStart")>] member inline _.DragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.Rendering.DraggableEventArgs -> Task<unit>) = render ==> html.callbackTask("DragStart", fn)
    [<CustomOperation("DragEnd")>] member inline _.DragEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.Rendering.DraggableEventArgs -> unit) = render ==> html.callback("DragEnd", fn)
    [<CustomOperation("DragEnd")>] member inline _.DragEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.Rendering.DraggableEventArgs -> Task<unit>) = render ==> html.callbackTask("DragEnd", fn)
    [<CustomOperation("Drag")>] member inline _.Drag ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.Rendering.DraggableEventArgs -> unit) = render ==> html.callback("Drag", fn)
    [<CustomOperation("Drag")>] member inline _.Drag ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.Rendering.DraggableEventArgs -> Task<unit>) = render ==> html.callbackTask("Drag", fn)

type EditorDropDownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("PopupStyle")>] member inline _.PopupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupStyle" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("EnabledModes")>] member inline _.EnabledModes ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.HtmlEditorMode) = render ==> ("EnabledModes" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("Change", fn)
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("Change", fn)

type PopupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadzenComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Lazy")>] member inline _.Lazy ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Lazy" =>>> true)
    [<CustomOperation("Lazy")>] member inline _.Lazy ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Lazy" =>>> x)
    /// Gets or sets a value indicating whether to focus the first focusable HTML element. Set to true by default.
    [<CustomOperation("AutoFocusFirstElement")>] member inline _.AutoFocusFirstElement ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFocusFirstElement" =>>> true)
    /// Gets or sets a value indicating whether to focus the first focusable HTML element. Set to true by default.
    [<CustomOperation("AutoFocusFirstElement")>] member inline _.AutoFocusFirstElement ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFocusFirstElement" =>>> x)
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventDefault" =>>> true)
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventDefault" =>>> x)
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Open", fn)
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Open", fn)
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Close", fn)
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Close", fn)

            
namespace rec Radzen.Blazor.DslInternals.Blazor

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// Base class of components that are rendered inside a RadzenChart.
type RadzenChartComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


/// Grid line configuration of IChartAxis.
type RadzenGridLinesBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the color of the grid lines.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies the pixel width of the grid lines. Set to 1 by default.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Specifies the type of line used to render the grid lines.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Specifies whether to display grid lines or not. Set to false by default.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Specifies whether to display grid lines or not. Set to false by default.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

type RadzenSeriesValueLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenGridLinesBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    [<CustomOperation("TooltipTemplate")>] member inline _.TooltipTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Double -> NodeRenderFragment) = render ==> html.renderFragment("TooltipTemplate", fn)

/// Displays the mean of a chart series.
type RadzenSeriesMeanLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenSeriesValueLineBuilder<'FunBlazorGeneric>()


/// Displays the median of a chart series.
type RadzenSeriesMedianLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenSeriesValueLineBuilder<'FunBlazorGeneric>()


/// Displays the mode of a chart series.
type RadzenSeriesModeLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenSeriesValueLineBuilder<'FunBlazorGeneric>()


/// Displays the trend of a chart series.
type RadzenSeriesTrendLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenGridLinesBuilder<'FunBlazorGeneric>()


/// Base class for an axis in RadzenChart.
type AxisBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the stroke (line color) of the axis.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Gets or sets the pixel width of axis.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the format string used to display the axis values.
    [<CustomOperation("FormatString")>] member inline _.FormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormatString" => x)
    /// Gets or sets a formatter function that formats the axis values.
    [<CustomOperation("Formatter")>] member inline _.Formatter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Formatter" => (System.Func<System.Object, System.String>fn))
    /// Gets or sets the type of the line used to display the axis.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Gets or sets the pixel distance between axis ticks. It is used to calculate the number of visible ticks depending on the available space. Set to 100 by default;
    /// Setting Step will override this value.
    [<CustomOperation("TickDistance")>] member inline _.TickDistance ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TickDistance" => x)
    /// Specifies the minimum value of the axis.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Min" => x)
    /// Specifies the maximum value of the axis.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Max" => x)
    /// Specifies the step of the axis.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Step" => x)
    /// Gets or sets a value indicating whether this AxisBase is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this AxisBase is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Specifies the label rotation angle in degrees. Set to null by default which means no rotation is applied. Has higher precedence than LabelAutoRotation.
    [<CustomOperation("LabelRotation")>] member inline _.LabelRotation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("LabelRotation" => x)
    /// Specifies the automatic label rotation angle in degrees. If set RadzenChart will automatically rotate the labels to fit the available space by the specified value. Has lower precedence than LabelRotation.
    [<CustomOperation("LabelAutoRotation")>] member inline _.LabelAutoRotation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("LabelAutoRotation" => x)

type RadzenCategoryAxisBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.AxisBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Padding")>] member inline _.Padding ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Padding" => x)

type RadzenValueAxisBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.AxisBaseBuilder<'FunBlazorGeneric>()


/// Base class of RadzenChart series.
type CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the title of the series. The title is displayed in tooltips and the legend.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the tooltip template.
    [<CustomOperation("TooltipTemplate")>] member inline _.TooltipTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("TooltipTemplate", fn)
    /// The name of the property of  that provides the X axis (a.k.a. category axis) values.
    [<CustomOperation("CategoryProperty")>] member inline _.CategoryProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CategoryProperty" => x)
    /// Gets or sets a value indicating whether this CartesianSeries`1 is visible.
    /// Invisible series do not appear in the legend and cannot be shown by the user.
    /// Use the Visible property to programatically show or hide a series.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this CartesianSeries`1 is visible.
    /// Invisible series do not appear in the legend and cannot be shown by the user.
    /// Use the Visible property to programatically show or hide a series.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets a value indicating whether this CartesianSeries`1 is hidden.
    /// Hidden series are initially invisible and the user can show them by clicking on their label in the legend.
    /// Use the Hidden property to hide certain series from your users but still allow them to see them.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hidden" =>>> true)
    /// Gets or sets a value indicating whether this CartesianSeries`1 is hidden.
    /// Hidden series are initially invisible and the user can show them by clicking on their label in the legend.
    /// Use the Hidden property to hide certain series from your users but still allow them to see them.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hidden" =>>> x)
    /// The name of the property of  that provides the Y axis (a.k.a. value axis) values.
    [<CustomOperation("ValueProperty")>] member inline _.ValueProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueProperty" => x)
    /// Gets or sets the rendering order.
    [<CustomOperation("RenderingOrder")>] member inline _.RenderingOrder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RenderingOrder" => x)
    /// Gets or sets the data of the series. The data is enumerated and its items are displayed by the series.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Data" => x)

/// Renders area series in RadzenChart.
type RadzenAreaSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Specifies the color of the line.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies the fill (background color) of the area series.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets the pixel width of the line. Set to 2 by default.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Specifies the line type.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Specifies whether to render a smooth line. Set to false by default.
    [<CustomOperation("Smooth")>] member inline _.Smooth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Smooth" =>>> true)
    /// Specifies whether to render a smooth line. Set to false by default.
    [<CustomOperation("Smooth")>] member inline _.Smooth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Smooth" =>>> x)
    /// Specifies how to render lines between data points. Set to Line by default
    [<CustomOperation("Interpolation")>] member inline _.Interpolation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.Interpolation) = render ==> ("Interpolation" => x)

/// Renders bar series in RadzenChart.
type RadzenBarSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Specifies the fill (background color) of the bar series.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Specifies a list of colors that will be used to set the individual bar backgrounds.
    [<CustomOperation("Fills")>] member inline _.Fills ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Fills" => x)
    /// Specifies the stroke (border color) of the bar series.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies a list of colors that will be used to set the individual bar borders.
    [<CustomOperation("Strokes")>] member inline _.Strokes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Strokes" => x)
    /// Gets or sets the width of the stroke (border).
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the type of the line used to render the bar border.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Gets or sets the color range of the fill.
    [<CustomOperation("FillRange")>] member inline _.FillRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = render ==> ("FillRange" => x)
    /// Gets or sets the color range of the stroke.
    [<CustomOperation("StrokeRange")>] member inline _.StrokeRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = render ==> ("StrokeRange" => x)

/// Renders column series in RadzenChart
type RadzenColumnSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Specifies the fill (background color) of the column series.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Specifies a list of colors that will be used to set the individual column backgrounds.
    [<CustomOperation("Fills")>] member inline _.Fills ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Fills" => x)
    /// Specifies the stroke (border color) of the column series.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies a list of colors that will be used to set the individual column borders.
    [<CustomOperation("Strokes")>] member inline _.Strokes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Strokes" => x)
    /// Gets or sets the width of the stroke (border).
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the type of the line used to render the column border.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Gets or sets the color range of the fill.
    [<CustomOperation("FillRange")>] member inline _.FillRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = render ==> ("FillRange" => x)
    /// Gets or sets the color range of the stroke.
    [<CustomOperation("StrokeRange")>] member inline _.StrokeRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = render ==> ("StrokeRange" => x)

/// Renders line series in RadzenChart.
type RadzenLineSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Specifies the color of the line.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies the pixel width of the line. Set to 2 by default.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Specifies the line type.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Specifies whether to render a smooth line. Set to false by default.
    [<CustomOperation("Smooth")>] member inline _.Smooth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Smooth" =>>> true)
    /// Specifies whether to render a smooth line. Set to false by default.
    [<CustomOperation("Smooth")>] member inline _.Smooth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Smooth" =>>> x)
    /// Specifies how to render lines between data points. Set to Line by default
    [<CustomOperation("Interpolation")>] member inline _.Interpolation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.Interpolation) = render ==> ("Interpolation" => x)

/// Renders pie series in RadzenChart.
type RadzenPieSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Specifies the x coordinate of the pie center. Not set by default which centers pie horizontally.
    [<CustomOperation("X")>] member inline _.X ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("X" => x)
    /// Specifies the y coordinate of the pie center. Not set by default which centers pie vertically.
    [<CustomOperation("Y")>] member inline _.Y ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Y" => x)
    /// Specifies the radius of the pie. Not set by default - the pie takes as much size of the chart as possible.
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Radius" => x)
    /// The fill colors of the pie segments. Used as the background of the segments.
    [<CustomOperation("Fills")>] member inline _.Fills ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Fills" => x)
    /// The stroke colors of the pie segments.
    [<CustomOperation("Strokes")>] member inline _.Strokes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Strokes" => x)
    /// The stroke width of the segments in pixels. By default set to 0.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the start angle from which segments are rendered (clockwise). Set to 90 by default.
    /// Top is 90, right is 0, bottom is 270, left is 180.
    [<CustomOperation("StartAngle")>] member inline _.StartAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StartAngle" => x)
    /// Gets or sets the total angle of the pie in degrees. Set to 360 by default which renders a full circle.
    /// Set to 180 to render a half circle or
    [<CustomOperation("TotalAngle")>] member inline _.TotalAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("TotalAngle" => x)

/// Renders donut series in RadzenChart.
type RadzenDonutSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenPieSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Gets or sets the inner radius of the donut.
    [<CustomOperation("InnerRadius")>] member inline _.InnerRadius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("InnerRadius" => x)
    /// Gets or sets the title template.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    /// Gets or sets the title template.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    /// Gets or sets the title template.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Gets or sets the title template.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    /// Gets or sets the title template.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)

/// Renders stacked area series in RadzenChart.
type RadzenStackedAreaSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Specifies the color of the line.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies the fill (background color) of the area series.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets the pixel width of the line. Set to 2 by default.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Specifies the line type.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Specifies whether to render a smooth line. Set to false by default.
    [<CustomOperation("Smooth")>] member inline _.Smooth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Smooth" =>>> true)
    /// Specifies whether to render a smooth line. Set to false by default.
    [<CustomOperation("Smooth")>] member inline _.Smooth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Smooth" =>>> x)
    /// Specifies how to render lines between data points. Set to Line by default
    [<CustomOperation("Interpolation")>] member inline _.Interpolation ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.Interpolation) = render ==> ("Interpolation" => x)

/// Renders bar series in RadzenChart.
type RadzenStackedBarSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Specifies the fill (background color) of the bar series.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Specifies a list of colors that will be used to set the individual bar backgrounds.
    [<CustomOperation("Fills")>] member inline _.Fills ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Fills" => x)
    /// Specifies the stroke (border color) of the bar series.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies a list of colors that will be used to set the individual bar borders.
    [<CustomOperation("Strokes")>] member inline _.Strokes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Strokes" => x)
    /// Gets or sets the width of the stroke (border).
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the type of the line used to render the bar border.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Gets or sets the color range of the fill.
    [<CustomOperation("FillRange")>] member inline _.FillRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = render ==> ("FillRange" => x)
    /// Gets or sets the color range of the stroke.
    [<CustomOperation("StrokeRange")>] member inline _.StrokeRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = render ==> ("StrokeRange" => x)

/// Renders column series in RadzenChart
type RadzenStackedColumnSeriesBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.CartesianSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Specifies the fill (background color) of the column series.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Specifies a list of colors that will be used to set the individual column backgrounds.
    [<CustomOperation("Fills")>] member inline _.Fills ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Fills" => x)
    /// Specifies the stroke (border color) of the column series.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies a list of colors that will be used to set the individual column borders.
    [<CustomOperation("Strokes")>] member inline _.Strokes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("Strokes" => x)
    /// Gets or sets the width of the stroke (border).
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the type of the line used to render the column border.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Gets or sets the color range of the fill.
    [<CustomOperation("FillRange")>] member inline _.FillRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = render ==> ("FillRange" => x)
    /// Gets or sets the color range of the stroke.
    [<CustomOperation("StrokeRange")>] member inline _.StrokeRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.SeriesColorRange>) = render ==> ("StrokeRange" => x)

/// Represents the title configuration of a AxisBase.
type RadzenAxisTitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text displayed by the title.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)

/// Common configuration of RadzenBarSeries`1.
type RadzenBarOptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the border radius of the bars. 
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Radius" => x)
    /// Gets or sets the margin between bars.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Margin" => x)
    /// Gets or sets the height of all bars in pixels. By default it is automatically calculated depending on the chart height.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Height" => x)

/// Contains RadzenChart tooltip configuration.
type RadzenChartTooltipOptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether to show tooltips. By default RadzenChart displays tooltips.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether to show tooltips. By default RadzenChart displays tooltips.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Enable or disable shared tooltips (one tooltip displaying data for all values for the same category). By default set to false (a separate tooltip is shown for each point in the category).
    [<CustomOperation("Shared")>] member inline _.Shared ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Shared" =>>> true)
    /// Enable or disable shared tooltips (one tooltip displaying data for all values for the same category). By default set to false (a separate tooltip is shown for each point in the category).
    [<CustomOperation("Shared")>] member inline _.Shared ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Shared" =>>> x)

/// Common configuration of RadzenColumnSeries`1.
type RadzenColumnOptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the border radius of the bars. 
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Radius" => x)
    /// Gets or sets the margin between columns.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Margin" => x)
    /// Gets or sets the width of all columns in pixels. By default it is automatically calculated depending on the chart width.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Width" => x)

/// Class RadzenLegend.
type RadzenLegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the position.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LegendPosition) = render ==> ("Position" => x)
    /// Gets or sets a value indicating whether this RadzenLegend is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenLegend is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

/// Class RadzenMarkers.
type RadzenMarkersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets whether marker is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets whether marker is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets the fill.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets the stroke.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Gets or sets the width of the stroke.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the size.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Size" => x)
    /// Gets or sets the type of the marker.
    [<CustomOperation("MarkerType")>] member inline _.MarkerType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.MarkerType) = render ==> ("MarkerType" => x)

/// Displays a text label for the specified data item from the series.
type RadzenSeriesAnnotationBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// The data item from the series this annotation applies to.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("Data" => x)
    /// The text to display in the annotation.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Horizontal offset from the default position. 
    [<CustomOperation("OffsetX")>] member inline _.OffsetX ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("OffsetX" => x)
    /// Vertical offset from the default position. 
    [<CustomOperation("OffsetY")>] member inline _.OffsetY ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("OffsetY" => x)
    /// The color of the annotation text. 
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Determines whether the annotation is visible. Set to true by default.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Determines whether the annotation is visible. Set to true by default.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

/// Displays the series values as text labels.
type RadzenSeriesDataLabelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    /// Horizontal offset from the default position. 
    [<CustomOperation("OffsetX")>] member inline _.OffsetX ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("OffsetX" => x)
    /// Vertical offset from the default position. 
    [<CustomOperation("OffsetY")>] member inline _.OffsetY ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("OffsetY" => x)
    /// Determines the visibility of the data labels. Set to true by default.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Determines the visibility of the data labels. Set to true by default.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Defines the fill color of the component.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)

            
namespace rec Radzen.Blazor.DslInternals.Blazor.Rendering

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

type CategoryAxisBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()


type ClipPathBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()


type ValueAxisBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()


type ValueAxisTitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenChartComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("X")>] member inline _.X ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X" => x)
    [<CustomOperation("Y")>] member inline _.Y ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y" => x)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)

            
namespace rec Radzen.Blazor.DslInternals.Blazor

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// Base class that RadzenHtmlEditor color picker tools inherit from.
type RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Specifies the shortcut for the command. Can be in the form of "Ctrl+X" or "Alt+Shift+Z".
    [<CustomOperation("Shortcut")>] member inline _.Shortcut ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shortcut" => x)

/// Base class that RadzenHtmlEditor color picker tools inherit from.
type RadzenHtmlEditorColorBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Sets ShowHSV of the built-in RadzenColorPicker.
    [<CustomOperation("ShowHSV")>] member inline _.ShowHSV ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowHSV" =>>> true)
    /// Sets ShowHSV of the built-in RadzenColorPicker.
    [<CustomOperation("ShowHSV")>] member inline _.ShowHSV ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowHSV" =>>> x)
    /// Sets ShowRGBA of the built-in RadzenColorPicker.
    [<CustomOperation("ShowRGBA")>] member inline _.ShowRGBA ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowRGBA" =>>> true)
    /// Sets ShowRGBA of the built-in RadzenColorPicker.
    [<CustomOperation("ShowRGBA")>] member inline _.ShowRGBA ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowRGBA" =>>> x)
    /// Sets ShowColors of the built-in RadzenColorPicker.
    [<CustomOperation("ShowColors")>] member inline _.ShowColors ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowColors" =>>> true)
    /// Sets ShowColors of the built-in RadzenColorPicker.
    [<CustomOperation("ShowColors")>] member inline _.ShowColors ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowColors" =>>> x)
    /// Sets ShowButton of the built-in RadzenColorPicker.
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowButton" =>>> true)
    /// Sets ShowButton of the built-in RadzenColorPicker.
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowButton" =>>> x)
    /// Sets HexText of the built-in RadzenColorPicker.
    [<CustomOperation("HexText")>] member inline _.HexText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HexText" => x)
    /// Sets RedText of the built-in RadzenColorPicker.
    [<CustomOperation("RedText")>] member inline _.RedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RedText" => x)
    /// Sets GreenText of the built-in RadzenColorPicker.
    [<CustomOperation("GreenText")>] member inline _.GreenText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GreenText" => x)
    /// Sets BlueText of the built-in RadzenColorPicker.
    [<CustomOperation("BlueText")>] member inline _.BlueText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BlueText" => x)
    /// Sets AlphaText of the built-in RadzenColorPicker.
    [<CustomOperation("AlphaText")>] member inline _.AlphaText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AlphaText" => x)
    /// Sets ButtonText of the built-in RadzenColorPicker.
    [<CustomOperation("ButtonText")>] member inline _.ButtonText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonText" => x)

/// A RadzenHtmlEditor tool which sets the background color of the selection.
type RadzenHtmlEditorBackgroundBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorColorBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the default background color. Set to "rgb(0, 0, 255)" by default;
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Background color" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which sets the text color of the selection.
type RadzenHtmlEditorColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorColorBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the default text color. Set to "rgb(255, 0, 0)" by default;
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Text color" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which centers the selection.
type RadzenHtmlEditorAlignCenterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Align center" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which aligns the selection to the left.
type RadzenHtmlEditorAlignLeftBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Align left" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which aligns the selection to the right.
type RadzenHtmlEditorAlignRightBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Align right" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which bolds the selection.
type RadzenHtmlEditorBoldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Bold" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Specifies the shortcut for the command. Set to "Ctrl+B" by default.
    [<CustomOperation("Shortcut")>] member inline _.Shortcut ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shortcut" => x)

/// A tool which inserts and uploads images in a RadzenHtmlEditor.
type RadzenHtmlEditorImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Insert image" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Specifies the text of the label suggesting the user to select a file for upload. Set to "Select image file to upload" by default.
    [<CustomOperation("SelectText")>] member inline _.SelectText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectText" => x)
    /// Specifies the text of the upload label. Set to "Browse" by default.
    [<CustomOperation("UploadChooseText")>] member inline _.UploadChooseText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UploadChooseText" => x)
    /// Specifies the text of the label suggesting the user to enter a web address. Set to "or enter a web address" by default.
    [<CustomOperation("UrlText")>] member inline _.UrlText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UrlText" => x)
    /// Specifies the text of the label suggesting the user to enter a alternative text (alt) for the image. Set to "Alternative text" by default.
    [<CustomOperation("AltText")>] member inline _.AltText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AltText" => x)
    /// Specifies the text of button which inserts the image. Set to "OK" by default.
    [<CustomOperation("OkText")>] member inline _.OkText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OkText" => x)
    /// Specifies the text of button which cancels image insertion and closes the dialog. Set to "Cancel" by default.
    [<CustomOperation("CancelText")>] member inline _.CancelText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelText" => x)
    /// Specifies the text of label for image width. Set to "Image Width" by default.
    [<CustomOperation("WidthText")>] member inline _.WidthText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("WidthText" => x)
    /// Specifies the text of label for image height. Set to "Image Height" by default.
    [<CustomOperation("HeightText")>] member inline _.HeightText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeightText" => x)
    /// Specifies whether to show the image width section. Set it to false to hide it. Default value is true.
    [<CustomOperation("ShowWidth")>] member inline _.ShowWidth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowWidth" =>>> true)
    /// Specifies whether to show the image width section. Set it to false to hide it. Default value is true.
    [<CustomOperation("ShowWidth")>] member inline _.ShowWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowWidth" =>>> x)
    /// Specifies whether to show the image height section. Set it to false to hide it. Default value is true.
    [<CustomOperation("ShowHeight")>] member inline _.ShowHeight ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowHeight" =>>> true)
    /// Specifies whether to show the image height section. Set it to false to hide it. Default value is true.
    [<CustomOperation("ShowHeight")>] member inline _.ShowHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowHeight" =>>> x)
    /// Specifies whether to show the web address section. Set it to false to hide it. Default value is true.
    [<CustomOperation("ShowSrc")>] member inline _.ShowSrc ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowSrc" =>>> true)
    /// Specifies whether to show the web address section. Set it to false to hide it. Default value is true.
    [<CustomOperation("ShowSrc")>] member inline _.ShowSrc ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowSrc" =>>> x)
    /// Specifies whether to show the alternative text section. Set it to false to hide it. Default value is true.
    [<CustomOperation("ShowAlt")>] member inline _.ShowAlt ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowAlt" =>>> true)
    /// Specifies whether to show the alternative text section. Set it to false to hide it. Default value is true.
    [<CustomOperation("ShowAlt")>] member inline _.ShowAlt ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowAlt" =>>> x)

/// A RadzenHtmlEditor tool which indents the selection.
type RadzenHtmlEditorIndentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Indent" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which makes the selection italic.
type RadzenHtmlEditorItalicBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Italic" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Specifies the shortcut for the command. Set to "Ctrl+I" by default.
    [<CustomOperation("Shortcut")>] member inline _.Shortcut ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shortcut" => x)

/// A RadzenHtmlEditor tool which justifies the selection.
type RadzenHtmlEditorJustifyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Justify" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A tool which creates links from the selection of a RadzenHtmlEditor.
type RadzenHtmlEditorLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Insert link" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Specifies the text of the label suggesting the user to enter a web address. Set to "Web address" by default.
    [<CustomOperation("UrlText")>] member inline _.UrlText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UrlText" => x)
    /// Specifies the text of the checkbox that opens the link in new window. Set to "Open in new window" by default.
    [<CustomOperation("OpenInNewWindowText")>] member inline _.OpenInNewWindowText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenInNewWindowText" => x)
    /// Specifies the text of the label suggesting the user to change the text of the link. Set to "Text" by default.
    [<CustomOperation("LinkText")>] member inline _.LinkText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LinkText" => x)
    /// Specifies the text of button which inserts the image. Set to "OK" by default.
    [<CustomOperation("OkText")>] member inline _.OkText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OkText" => x)
    /// Specifies the text of button which cancels image insertion and closes the dialog. Set to "Cancel" by default.
    [<CustomOperation("CancelText")>] member inline _.CancelText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelText" => x)
    /// Specifies the shortcut for the command. Set to "Ctrl+K" by default.
    [<CustomOperation("Shortcut")>] member inline _.Shortcut ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shortcut" => x)

/// A RadzenHtmlEditor tool which inserts an ordered list (ol).
type RadzenHtmlEditorOrderedListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Ordered list" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which outdents the selection.
type RadzenHtmlEditorOutdentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Outdent" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which repeats the last undone command.
type RadzenHtmlEditorRedoBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Redo" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which removes the styling of the selection.
type RadzenHtmlEditorRemoveFormatBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Remove styling" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A tool which switches between rendered and source views in RadzenHtmlEditor.
type RadzenHtmlEditorSourceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "View source" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which applies "strike through" styling to the selection.
type RadzenHtmlEditorStrikeThroughBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Strikethrough" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which formats the selection as subscript.
type RadzenHtmlEditorSubscriptBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Subscript" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which formats the selection as superscript.
type RadzenHtmlEditorSuperscriptBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Superscript" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which underlines the selection.
type RadzenHtmlEditorUnderlineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Underline" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Specifies the shortcut for the command. Set to "Ctrl+U" by default.
    [<CustomOperation("Shortcut")>] member inline _.Shortcut ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shortcut" => x)

/// A RadzenHtmlEditor tool which reverts the last edit operation.
type RadzenHtmlEditorUndoBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Undo" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which removes a link.
type RadzenHtmlEditorUnlinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Remove link" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A RadzenHtmlEditor tool which inserts a bullet list (ul).
type RadzenHtmlEditorUnorderedListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenHtmlEditorButtonBaseBuilder<'FunBlazorGeneric>()
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Bullet list" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A base class for RadzenScheduler`1 views.
type SchedulerViewBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


/// A base class for RadzenScheduler`1 views.
type SchedulerYearViewBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.SchedulerViewBaseBuilder<'FunBlazorGeneric>()


/// Displays the appointments in a month day in RadzenScheduler`1
type RadzenYearPlannerViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.SchedulerYearViewBaseBuilder<'FunBlazorGeneric>()
    /// Gets the text of the view. It is displayed in the view switching UI.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the maximum appointnments to render in a slot.
    [<CustomOperation("MaxAppointmentsInSlot")>] member inline _.MaxAppointmentsInSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxAppointmentsInSlot" => x)
    /// Specifies the text displayed when there are more appointments in a slot than MaxAppointmentsInSlot.
    [<CustomOperation("MoreText")>] member inline _.MoreText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MoreText" => x)
    /// Gets or sets the start month for the year views />.
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Month) = render ==> ("StartMonth" => x)

/// Displays the appointments in a month day in RadzenScheduler`1
type RadzenYearTimelineViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.SchedulerYearViewBaseBuilder<'FunBlazorGeneric>()
    /// Gets the text of the view. It is displayed in the view switching UI.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the maximum appointnments to render in a slot.
    [<CustomOperation("MaxAppointmentsInSlot")>] member inline _.MaxAppointmentsInSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxAppointmentsInSlot" => x)
    /// Specifies the text displayed when there are more appointments in a slot than MaxAppointmentsInSlot.
    [<CustomOperation("MoreText")>] member inline _.MoreText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MoreText" => x)
    /// Gets or sets the start month for the year views />.
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Month) = render ==> ("StartMonth" => x)

/// Displays the appointments in a month day in RadzenScheduler`1
type RadzenYearViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.SchedulerYearViewBaseBuilder<'FunBlazorGeneric>()
    /// Gets the text of the view. It is displayed in the view switching UI.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the text displayed when there are more appointments in a slot than MaxAppointmentsInSlot.
    [<CustomOperation("MoreText")>] member inline _.MoreText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MoreText" => x)
    /// Specifies the text displayed when the user clicks on a day with no events in the year view
    [<CustomOperation("NoDayEventsText")>] member inline _.NoDayEventsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoDayEventsText" => x)
    /// Gets or sets the start month for the year views />.
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Month) = render ==> ("StartMonth" => x)

/// Displays the appointments in a single day in RadzenScheduler`1
type RadzenDayViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.SchedulerViewBaseBuilder<'FunBlazorGeneric>()
    /// Gets the text of the view. It is displayed in the view switching UI.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the time format.
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    /// Gets or sets the start time.
    [<CustomOperation("StartTime")>] member inline _.StartTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("StartTime" => x)
    /// Gets or sets the end time.
    [<CustomOperation("EndTime")>] member inline _.EndTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("EndTime" => x)
    /// Gets or sets slot size in minutes. Set to 30 by default.
    [<CustomOperation("MinutesPerSlot")>] member inline _.MinutesPerSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinutesPerSlot" => x)

/// Displays the appointments in a month day in RadzenScheduler`1
type RadzenMonthViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.SchedulerViewBaseBuilder<'FunBlazorGeneric>()
    /// Gets the text of the view. It is displayed in the view switching UI.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Specifies the maximum appointnments to render in a slot.
    [<CustomOperation("MaxAppointmentsInSlot")>] member inline _.MaxAppointmentsInSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxAppointmentsInSlot" => x)
    /// Specifies the text displayed when there are more appointments in a slot than MaxAppointmentsInSlot.
    [<CustomOperation("MoreText")>] member inline _.MoreText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MoreText" => x)

/// Displays the appointments in a multi-day view in RadzenScheduler`1
type RadzenMultiDayViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.SchedulerViewBaseBuilder<'FunBlazorGeneric>()
    /// Gets the text of the view. It is displayed in the view switching UI.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the time format.
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    /// Gets or sets the format used to display the header text.
    [<CustomOperation("HeaderFormat")>] member inline _.HeaderFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderFormat" => x)
    /// Gets or sets the start time.
    [<CustomOperation("StartTime")>] member inline _.StartTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("StartTime" => x)
    /// Gets or sets the end time.
    [<CustomOperation("EndTime")>] member inline _.EndTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("EndTime" => x)
    /// Gets or sets slot size in minutes. Set to 30 by default.
    [<CustomOperation("MinutesPerSlot")>] member inline _.MinutesPerSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinutesPerSlot" => x)
    /// Gets or sets number of days to view. Set to 2 by default.
    [<CustomOperation("NumberOfDays")>] member inline _.NumberOfDays ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("NumberOfDays" => x)
    /// Gets or sets number of days to advance when using prev / next. Set to 1 by default.
    [<CustomOperation("AdvanceDays")>] member inline _.AdvanceDays ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("AdvanceDays" => x)

/// Displays the appointments in a week day in RadzenScheduler`1
type RadzenWeekViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.SchedulerViewBaseBuilder<'FunBlazorGeneric>()
    /// Gets the text of the view. It is displayed in the view switching UI.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the time format.
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    /// Gets or sets the format used to display the header text.
    [<CustomOperation("HeaderFormat")>] member inline _.HeaderFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderFormat" => x)
    /// Gets or sets the start time.
    [<CustomOperation("StartTime")>] member inline _.StartTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("StartTime" => x)
    /// Gets or sets the end time.
    [<CustomOperation("EndTime")>] member inline _.EndTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("EndTime" => x)
    /// Gets or sets slot size in minutes. Set to 30 by default.
    [<CustomOperation("MinutesPerSlot")>] member inline _.MinutesPerSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinutesPerSlot" => x)

            
namespace rec Radzen.Blazor.DslInternals.Blazor.Rendering

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// Base component for all chart ticks. 
type TickBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the X coordinate. 
    [<CustomOperation("X")>] member inline _.X ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X" => x)
    /// Gets or sets the Y coordinate. 
    [<CustomOperation("Y")>] member inline _.Y ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y" => x)
    /// Gets or sets the stroke (line color) of the tick. 
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Gets or sets the pixel width of the tick. 
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the type of the line used to display the tick. 
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Gets or sets the text of the tick. 
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)

type CategoryAxisTickBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.Rendering.TickBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Rotate")>] member inline _.Rotate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Rotate" => x)

type ValueAxisTickBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.Rendering.TickBuilder<'FunBlazorGeneric>()


/// A base class for MonthView DayView WeekView YearPlannerView YearTimelineView views.
type DropableViewBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the appointment move event callback.
    [<CustomOperation("AppointmentMove")>] member inline _.AppointmentMove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerAppointmentMoveEventArgs -> unit) = render ==> html.callback("AppointmentMove", fn)
    /// Gets or sets the appointment move event callback.
    [<CustomOperation("AppointmentMove")>] member inline _.AppointmentMove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.SchedulerAppointmentMoveEventArgs -> Task<unit>) = render ==> html.callbackTask("AppointmentMove", fn)

type DayViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.Rendering.DropableViewBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartDate")>] member inline _.StartDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("StartDate" => x)
    [<CustomOperation("StartTime")>] member inline _.StartTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("StartTime" => x)
    [<CustomOperation("EndDate")>] member inline _.EndDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("EndDate" => x)
    [<CustomOperation("EndTime")>] member inline _.EndTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("EndTime" => x)
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    [<CustomOperation("MinutesPerSlot")>] member inline _.MinutesPerSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinutesPerSlot" => x)
    [<CustomOperation("Appointments")>] member inline _.Appointments ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>) = render ==> ("Appointments" => x)

type MonthViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.Rendering.DropableViewBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartDate")>] member inline _.StartDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("StartDate" => x)
    [<CustomOperation("EndDate")>] member inline _.EndDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("EndDate" => x)
    [<CustomOperation("MaxAppointmentsInSlot")>] member inline _.MaxAppointmentsInSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxAppointmentsInSlot" => x)
    [<CustomOperation("MoreText")>] member inline _.MoreText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MoreText" => x)
    [<CustomOperation("Appointments")>] member inline _.Appointments ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>) = render ==> ("Appointments" => x)

type WeekViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.Rendering.DropableViewBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartDate")>] member inline _.StartDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("StartDate" => x)
    [<CustomOperation("EndDate")>] member inline _.EndDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("EndDate" => x)
    [<CustomOperation("StartTime")>] member inline _.StartTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("StartTime" => x)
    [<CustomOperation("EndTime")>] member inline _.EndTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("EndTime" => x)
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    [<CustomOperation("HeaderFormat")>] member inline _.HeaderFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderFormat" => x)
    [<CustomOperation("MinutesPerSlot")>] member inline _.MinutesPerSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinutesPerSlot" => x)
    [<CustomOperation("Appointments")>] member inline _.Appointments ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>) = render ==> ("Appointments" => x)

type YearPlannerViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.Rendering.DropableViewBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartDate")>] member inline _.StartDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("StartDate" => x)
    [<CustomOperation("EndDate")>] member inline _.EndDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("EndDate" => x)
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Month) = render ==> ("StartMonth" => x)
    [<CustomOperation("MaxAppointmentsInSlot")>] member inline _.MaxAppointmentsInSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxAppointmentsInSlot" => x)
    [<CustomOperation("MoreText")>] member inline _.MoreText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MoreText" => x)
    [<CustomOperation("Appointments")>] member inline _.Appointments ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>) = render ==> ("Appointments" => x)

type YearTimelineViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.Rendering.DropableViewBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartDate")>] member inline _.StartDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("StartDate" => x)
    [<CustomOperation("EndDate")>] member inline _.EndDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("EndDate" => x)
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Month) = render ==> ("StartMonth" => x)
    [<CustomOperation("MaxAppointmentsInSlot")>] member inline _.MaxAppointmentsInSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxAppointmentsInSlot" => x)
    [<CustomOperation("MoreText")>] member inline _.MoreText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MoreText" => x)
    [<CustomOperation("Appointments")>] member inline _.Appointments ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>) = render ==> ("Appointments" => x)

            
namespace rec Radzen.Blazor.DslInternals.Blazor

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

/// RadzenArcGaugeScale component.
type RadzenArcGaugeScaleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the stroke.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Gets or sets the width of the stroke.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the length of the tick.
    [<CustomOperation("TickLength")>] member inline _.TickLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("TickLength" => x)
    /// Gets or sets the length of the minor tick.
    [<CustomOperation("MinorTickLength")>] member inline _.MinorTickLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MinorTickLength" => x)
    /// Gets or sets the tick label offset.
    [<CustomOperation("TickLabelOffset")>] member inline _.TickLabelOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("TickLabelOffset" => x)
    /// Gets or sets the format string.
    [<CustomOperation("FormatString")>] member inline _.FormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormatString" => x)
    /// Gets or sets the fill.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets the height.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Height" => x)
    /// Gets or sets the formatter.
    [<CustomOperation("Formatter")>] member inline _.Formatter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Formatter" => (System.Func<System.Double, System.String>fn))
    /// Gets or sets the start angle.
    [<CustomOperation("StartAngle")>] member inline _.StartAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StartAngle" => x)
    /// Gets or sets the tick position.
    [<CustomOperation("TickPosition")>] member inline _.TickPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.GaugeTickPosition) = render ==> ("TickPosition" => x)
    /// Gets or sets the end angle.
    [<CustomOperation("EndAngle")>] member inline _.EndAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("EndAngle" => x)
    /// Gets or sets the radius.
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Radius" => x)
    /// Gets or sets a value indicating whether first tick is shown.
    [<CustomOperation("ShowFirstTick")>] member inline _.ShowFirstTick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowFirstTick" =>>> true)
    /// Gets or sets a value indicating whether first tick is shown.
    [<CustomOperation("ShowFirstTick")>] member inline _.ShowFirstTick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowFirstTick" =>>> x)
    /// Gets or sets a value indicating whether last tick is shown.
    [<CustomOperation("ShowLastTick")>] member inline _.ShowLastTick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowLastTick" =>>> true)
    /// Gets or sets a value indicating whether last tick is shown.
    [<CustomOperation("ShowLastTick")>] member inline _.ShowLastTick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowLastTick" =>>> x)
    /// Gets or sets a value indicating whether to show tick labels.
    [<CustomOperation("ShowTickLabels")>] member inline _.ShowTickLabels ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowTickLabels" =>>> true)
    /// Gets or sets a value indicating whether to show tick labels.
    [<CustomOperation("ShowTickLabels")>] member inline _.ShowTickLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowTickLabels" =>>> x)
    /// Gets or sets the x.
    [<CustomOperation("X")>] member inline _.X ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X" => x)
    /// Determines the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    /// Determines the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    /// Gets or sets the step.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Step" => x)
    /// Gets or sets the minor step.
    [<CustomOperation("MinorStep")>] member inline _.MinorStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MinorStep" => x)
    /// Gets or sets the y.
    [<CustomOperation("Y")>] member inline _.Y ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y" => x)
    /// Gets or sets the margin.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Margin" => x)

/// RadzenArcGaugeScaleValue component.
type RadzenArcGaugeScaleValueBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    /// Gets or sets the stroke.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Gets or sets the width of the stroke.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the fill.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets a value indicating whether to show value.
    [<CustomOperation("ShowValue")>] member inline _.ShowValue ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowValue" =>>> true)
    /// Gets or sets a value indicating whether to show value.
    [<CustomOperation("ShowValue")>] member inline _.ShowValue ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowValue" =>>> x)
    /// Gets or sets the format string.
    [<CustomOperation("FormatString")>] member inline _.FormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormatString" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenArcGaugeScaleValue -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)

/// RadzenCarouselItem component.
type RadzenCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the arbitrary attributes.
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)

/// RadzenColorPickerItem component.
type RadzenColorPickerItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

/// RadzenContextMenu component.
type RadzenContextMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


/// RadzenDataFilterProperty component.
/// Must be placed inside a RadzenDataFilter`1
type RadzenDataFilterPropertyBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the format string.
    [<CustomOperation("FormatString")>] member inline _.FormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormatString" => x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets the title.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the property name.
    [<CustomOperation("Property")>] member inline _.Property ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Property" => x)
    /// Gets or sets the filter property name.
    [<CustomOperation("FilterProperty")>] member inline _.FilterProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterProperty" => x)
    /// Gets or sets a value indicating whether this property is selected in the filter.
    [<CustomOperation("IsSelected")>] member inline _.IsSelected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsSelected" =>>> true)
    /// Gets or sets a value indicating whether this property is selected in the filter.
    [<CustomOperation("IsSelected")>] member inline _.IsSelected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsSelected" =>>> x)
    /// Gets or sets the filter value.
    [<CustomOperation("FilterValue")>] member inline _.FilterValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("FilterValue" => x)
    /// Gets or sets the filter template.
    [<CustomOperation("FilterTemplate")>] member inline _.FilterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.CompositeFilterDescriptor -> NodeRenderFragment) = render ==> html.renderFragment("FilterTemplate", fn)
    /// Gets or sets the data type.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Type) = render ==> ("Type" => x)
    /// Gets or sets the filter operator.
    [<CustomOperation("FilterOperator")>] member inline _.FilterOperator ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FilterOperator) = render ==> ("FilterOperator" => x)
    /// Gets or sets the filter operators.
    [<CustomOperation("FilterOperators")>] member inline _.FilterOperators ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Radzen.FilterOperator>) = render ==> ("FilterOperators" => x)

/// RadzenDataGridColumn component.
/// Must be placed inside a RadzenDataGrid`1
type RadzenDataGridColumnBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Columns", fragment)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Columns", fragment { yield! fragments })
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Columns", html.text x)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Columns", html.text x)
    /// Gets or sets the columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Columns", html.text x)
    /// Specifies wether CheckBoxList filter list virtualization is enabled. Set to true by default.
    [<CustomOperation("AllowCheckBoxListVirtualization")>] member inline _.AllowCheckBoxListVirtualization ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowCheckBoxListVirtualization" =>>> true)
    /// Specifies wether CheckBoxList filter list virtualization is enabled. Set to true by default.
    [<CustomOperation("AllowCheckBoxListVirtualization")>] member inline _.AllowCheckBoxListVirtualization ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowCheckBoxListVirtualization" =>>> x)
    /// Gets or sets the column filter mode.
    [<CustomOperation("FilterMode")>] member inline _.FilterMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Radzen.FilterMode>) = render ==> ("FilterMode" => x)
    /// Gets or sets the unique identifier.
    [<CustomOperation("UniqueID")>] member inline _.UniqueID ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UniqueID" => x)
    /// Gets or sets the order index.
    [<CustomOperation("OrderIndex")>] member inline _.OrderIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OrderIndex" => x)
    /// Gets or sets the sort order.
    [<CustomOperation("SortOrder")>] member inline _.SortOrder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Radzen.SortOrder>) = render ==> ("SortOrder" => x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets the header tooltip.
    [<CustomOperation("HeaderTooltip")>] member inline _.HeaderTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderTooltip" => x)
    /// Gets or sets the title.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Gets or sets the title in column picker.
    /// Value of Title is used when ColumnPickerTitle is not set
    [<CustomOperation("ColumnPickerTitle")>] member inline _.ColumnPickerTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ColumnPickerTitle" => x)
    /// Gets or sets the property name.
    [<CustomOperation("Property")>] member inline _.Property ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Property" => x)
    /// Gets or sets the sort property name.
    [<CustomOperation("SortProperty")>] member inline _.SortProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortProperty" => x)
    /// Gets or sets the group property name.
    [<CustomOperation("GroupProperty")>] member inline _.GroupProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupProperty" => x)
    /// Gets or sets the filter property name.
    [<CustomOperation("FilterProperty")>] member inline _.FilterProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterProperty" => x)
    /// Gets or sets the filter value.
    [<CustomOperation("FilterValue")>] member inline _.FilterValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("FilterValue" => x)
    /// Gets or sets the filter placeholder.
    [<CustomOperation("FilterPlaceholder")>] member inline _.FilterPlaceholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FilterPlaceholder" => x)
    /// Gets or sets the custom filter dynamic Linq dictionary.
    [<CustomOperation("CustomFilterExpression")>] member inline _.CustomFilterExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomFilterExpression" => x)
    /// Gets or sets the second filter value.
    [<CustomOperation("SecondFilterValue")>] member inline _.SecondFilterValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("SecondFilterValue" => x)
    /// Gets or sets the width.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Gets or sets the min-width.
    [<CustomOperation("MinWidth")>] member inline _.MinWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinWidth" => x)
    /// Gets or sets the max-width.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    /// Gets or sets the format string.
    [<CustomOperation("FormatString")>] member inline _.FormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormatString" => x)
    /// Gets or sets the CSS class applied to data cells.
    [<CustomOperation("CssClass")>] member inline _.CssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CssClass" => x)
    /// Gets or sets a function that calculates the CSS class based on the  value.
    [<CustomOperation("CalculatedCssClass")>] member inline _.CalculatedCssClass ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CalculatedCssClass" => (System.Func<Radzen.Blazor.RadzenDataGridColumn<'TItem>, 'TItem, System.String>fn))
    /// Gets or sets the header CSS class applied to header cell.
    [<CustomOperation("HeaderCssClass")>] member inline _.HeaderCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderCssClass" => x)
    /// Gets or sets the footer CSS class applied to footer cell.
    [<CustomOperation("FooterCssClass")>] member inline _.FooterCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterCssClass" => x)
    /// Gets or sets the group footer CSS class applied to group footer cell.
    [<CustomOperation("GroupFooterCssClass")>] member inline _.GroupFooterCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterCssClass" => x)
    /// Gets or sets the header white space style.
    [<CustomOperation("HeaderWhiteSpace")>] member inline _.HeaderWhiteSpace ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.WhiteSpace) = render ==> ("HeaderWhiteSpace" => x)
    /// Gets or sets the white space style.
    [<CustomOperation("WhiteSpace")>] member inline _.WhiteSpace ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.WhiteSpace) = render ==> ("WhiteSpace" => x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is filterable.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Filterable" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is filterable.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Filterable" =>>> x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is sortable.
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Sortable" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is sortable.
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Sortable" =>>> x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is frozen.
    [<CustomOperation("Frozen")>] member inline _.Frozen ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Frozen" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is frozen.
    [<CustomOperation("Frozen")>] member inline _.Frozen ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Frozen" =>>> x)
    /// Gets or sets the frozen position this RadzenDataGridColumn`1
    [<CustomOperation("FrozenPosition")>] member inline _.FrozenPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FrozenColumnPosition) = render ==> ("FrozenPosition" => x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is resizable.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Resizable" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is resizable.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Resizable" =>>> x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is reorderable.
    [<CustomOperation("Reorderable")>] member inline _.Reorderable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Reorderable" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is reorderable.
    [<CustomOperation("Reorderable")>] member inline _.Reorderable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Reorderable" =>>> x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is groupable.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Groupable" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is groupable.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Groupable" =>>> x)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is pickable - listed when DataGrid AllowColumnPicking is set to true.
    [<CustomOperation("Pickable")>] member inline _.Pickable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Pickable" =>>> true)
    /// Gets or sets a value indicating whether this RadzenDataGridColumn`1 is pickable - listed when DataGrid AllowColumnPicking is set to true.
    [<CustomOperation("Pickable")>] member inline _.Pickable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Pickable" =>>> x)
    /// Gets or sets the text align.
    [<CustomOperation("TextAlign")>] member inline _.TextAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.TextAlign) = render ==> ("TextAlign" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the edit template.
    [<CustomOperation("EditTemplate")>] member inline _.EditTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    /// Allows the column to override whether or not this column's the EditTemplate is visible at runtime.
    [<CustomOperation("IsInEditMode")>] member inline _.IsInEditMode ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IsInEditMode" => (System.Func<System.String, 'TItem, System.Boolean>fn))
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the header template.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the footer template.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    /// Gets or sets the group footer template.
    [<CustomOperation("GroupFooterTemplate")>] member inline _.GroupFooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Group -> NodeRenderFragment) = render ==> html.renderFragment("GroupFooterTemplate", fn)
    /// Gets or sets the filter template.
    [<CustomOperation("FilterTemplate")>] member inline _.FilterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenDataGridColumn<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("FilterTemplate", fn)
    /// Gets or sets the filter value template.
    [<CustomOperation("FilterValueTemplate")>] member inline _.FilterValueTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenDataGridColumn<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("FilterValueTemplate", fn)
    /// Gets or sets the second filter value template.
    [<CustomOperation("SecondFilterValueTemplate")>] member inline _.SecondFilterValueTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenDataGridColumn<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("SecondFilterValueTemplate", fn)
    /// Gets or sets the logical filter operator.
    [<CustomOperation("LogicalFilterOperator")>] member inline _.LogicalFilterOperator ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.LogicalFilterOperator) = render ==> ("LogicalFilterOperator" => x)
    /// Gets or sets the data type.
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Type) = render ==> ("Type" => x)
    /// Gets or sets the IFormatProvider used for FormatString.
    [<CustomOperation("FormatProvider")>] member inline _.FormatProvider ([<InlineIfLambda>] render: AttrRenderFragment, x: System.IFormatProvider) = render ==> ("FormatProvider" => x)
    /// Gets or sets the filter operator.
    [<CustomOperation("FilterOperator")>] member inline _.FilterOperator ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FilterOperator) = render ==> ("FilterOperator" => x)
    /// Gets or sets the filter operators.
    [<CustomOperation("FilterOperators")>] member inline _.FilterOperators ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Radzen.FilterOperator>) = render ==> ("FilterOperators" => x)
    /// Gets or sets the second filter operator.
    [<CustomOperation("SecondFilterOperator")>] member inline _.SecondFilterOperator ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.FilterOperator) = render ==> ("SecondFilterOperator" => x)

type RadzenDropDownDataGridColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Blazor.RadzenDataGridColumnBuilder<'FunBlazorGeneric, System.Object>()


/// RadzenDataGridRow.
type RadzenDataGridRowBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.RadzenDataGridColumn<'TItem>>) = render ==> ("Columns" => x)
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("Item" => x)
    [<CustomOperation("Index")>] member inline _.Index ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Index" => x)
    [<CustomOperation("Grid")>] member inline _.Grid ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGrid<'TItem>) = render ==> ("Grid" => x)
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("CssClass")>] member inline _.CssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CssClass" => x)
    [<CustomOperation("InEditMode")>] member inline _.InEditMode ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("InEditMode" =>>> true)
    [<CustomOperation("InEditMode")>] member inline _.InEditMode ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("InEditMode" =>>> x)
    [<CustomOperation("EditContext")>] member inline _.EditContext ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Forms.EditContext) = render ==> ("EditContext" => x)

/// RadzenHtml component.
type RadzenHtmlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets a value indicating whether this RadzenHtml is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenHtml is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

/// Adds a custom color to RadzenHtmlEditorBackground.
type RadzenHtmlEditorBackgroundItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// The custom color to add.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

/// Adds a custom color to RadzenHtmlEditorColor.
type RadzenHtmlEditorColorItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// The custom color to add.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

/// A custom tool in RadzenHtmlEditor
type RadzenHtmlEditorCustomToolBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Determines if the tools is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Determines if the tools is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Specifies the icon of the tool. Set to "settings" by default.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Specifies the modes that this tool will be enabled in.
    [<CustomOperation("EnabledModes")>] member inline _.EnabledModes ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.HtmlEditorMode) = render ==> ("EnabledModes" => x)
    /// The template of the tool. Use to render a custom tool.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenHtmlEditor -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Specifies whether the tool is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Specifies whether the tool is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Specifies whether the tool is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Specifies whether the tool is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    [<CustomOperation("CommandName")>] member inline _.CommandName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CommandName" => x)
    /// Specifies the title (tooltip) displayed when the user hovers the tool.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A tool which changes the font of the selected text.
type RadzenHtmlEditorFontNameBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Specifies the placeholder displayed to the user. Set to "Font" by default.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Font name" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// Adds a custom font to a RadzenHtmlEditorFontName.
type RadzenHtmlEditorFontNameItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// The name of the font e.g. "Times New Roman".
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The CSS value of the font. Use quotes if it contains spaces.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

/// A tool which changes the font size of the selected text.
type RadzenHtmlEditorFontSizeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Specifies the placeholder displayed to the user. Set to "Font size" by default.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Font size" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

/// A tool which changes the style of a the selected text by making it a heading or paragraph.
type RadzenHtmlEditorFormatBlockBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Specifies the placeholder displayed to the user. Set to "Format block" by default.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Specifies the title (tooltip) displayed when the user hovers the tool. Set to "Text style" by default.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Specifies the text displayed for the normal text example. Set to "Normal" by default.
    [<CustomOperation("NormalText")>] member inline _.NormalText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NormalText" => x)
    /// Specifies the text displayed for the h1 example. Set to "Heading 1" by default.
    [<CustomOperation("Heading1Text")>] member inline _.Heading1Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Heading1Text" => x)
    /// Specifies the text displayed for the h2 example. Set to "Heading 2" by default.
    [<CustomOperation("Heading2Text")>] member inline _.Heading2Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Heading2Text" => x)
    /// Specifies the text displayed for the h3 example. Set to "Heading 3" by default.
    [<CustomOperation("Heading3Text")>] member inline _.Heading3Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Heading3Text" => x)
    /// Specifies the text displayed for the h4 example. Set to "Heading 4" by default.
    [<CustomOperation("Heading4Text")>] member inline _.Heading4Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Heading4Text" => x)
    /// Specifies the text displayed for the h5 example. Set to "Heading 5" by default.
    [<CustomOperation("Heading5Text")>] member inline _.Heading5Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Heading5Text" => x)
    /// Specifies the text displayed for the h6 example. Set to "Heading 6" by default.
    [<CustomOperation("Heading6Text")>] member inline _.Heading6Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Heading6Text" => x)

/// A RadzenHtmlEditor visual separator.
type RadzenHtmlEditorSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


/// RadzenMediaQuery fires its Change event when the media query specified via Query matches or not.
type RadzenMediaQueryBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// The CSS media query this component will listen for.
    [<CustomOperation("Query")>] member inline _.Query ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Query" => x)
    /// A callback that will be invoked when the status of the media query changes - to either match or not.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("Change", fn)
    /// A callback that will be invoked when the status of the media query changes - to either match or not.
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("Change", fn)

/// RadzenRadialGaugeScale component.
type RadzenRadialGaugeScaleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the stroke.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Gets or sets the width of the stroke.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the length of the tick.
    [<CustomOperation("TickLength")>] member inline _.TickLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("TickLength" => x)
    /// Gets or sets the length of the minor tick.
    [<CustomOperation("MinorTickLength")>] member inline _.MinorTickLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MinorTickLength" => x)
    /// Gets or sets the tick label offset.
    [<CustomOperation("TickLabelOffset")>] member inline _.TickLabelOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("TickLabelOffset" => x)
    /// Gets or sets the format string.
    [<CustomOperation("FormatString")>] member inline _.FormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormatString" => x)
    /// Gets or sets the formatter function.
    [<CustomOperation("Formatter")>] member inline _.Formatter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Formatter" => (System.Func<System.Double, System.String>fn))
    /// Gets or sets the start angle.
    [<CustomOperation("StartAngle")>] member inline _.StartAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StartAngle" => x)
    /// Gets or sets the tick position.
    [<CustomOperation("TickPosition")>] member inline _.TickPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.GaugeTickPosition) = render ==> ("TickPosition" => x)
    /// Gets or sets the end angle.
    [<CustomOperation("EndAngle")>] member inline _.EndAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("EndAngle" => x)
    /// Gets or sets the radius.
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Radius" => x)
    /// Gets or sets a value indicating whether to show first tick.
    [<CustomOperation("ShowFirstTick")>] member inline _.ShowFirstTick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowFirstTick" =>>> true)
    /// Gets or sets a value indicating whether to show first tick.
    [<CustomOperation("ShowFirstTick")>] member inline _.ShowFirstTick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowFirstTick" =>>> x)
    /// Gets or sets a value indicating whether to show last tick.
    [<CustomOperation("ShowLastTick")>] member inline _.ShowLastTick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowLastTick" =>>> true)
    /// Gets or sets a value indicating whether to show last tick.
    [<CustomOperation("ShowLastTick")>] member inline _.ShowLastTick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowLastTick" =>>> x)
    /// Gets or sets a value indicating whether to show tick labels.
    [<CustomOperation("ShowTickLabels")>] member inline _.ShowTickLabels ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowTickLabels" =>>> true)
    /// Gets or sets a value indicating whether to show tick labels.
    [<CustomOperation("ShowTickLabels")>] member inline _.ShowTickLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowTickLabels" =>>> x)
    /// Gets or sets the x.
    [<CustomOperation("X")>] member inline _.X ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X" => x)
    /// Determines the minimum value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    /// Determines the maximum value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    /// Gets or sets the step.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Step" => x)
    /// Gets or sets the minor step.
    [<CustomOperation("MinorStep")>] member inline _.MinorStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MinorStep" => x)
    /// Gets or sets the y.
    [<CustomOperation("Y")>] member inline _.Y ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y" => x)
    /// Gets or sets the margin.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Margin" => x)

/// RadzenRadialGaugeScalePointer component.
type RadzenRadialGaugeScalePointerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the fill.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    /// Gets or sets a value indicating whether to show value.
    [<CustomOperation("ShowValue")>] member inline _.ShowValue ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowValue" =>>> true)
    /// Gets or sets a value indicating whether to show value.
    [<CustomOperation("ShowValue")>] member inline _.ShowValue ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowValue" =>>> x)
    /// Gets or sets the radius.
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Radius" => x)
    /// Gets or sets the width.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Width" => x)
    /// Gets or sets the length.
    [<CustomOperation("Length")>] member inline _.Length ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Length" => x)
    /// Gets or sets the format string.
    [<CustomOperation("FormatString")>] member inline _.FormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormatString" => x)
    /// Gets or sets the stroke.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Gets or sets the width of the stroke.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenRadialGaugeScalePointer -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)

/// RadzenRadialGaugeScaleRange component.
type RadzenRadialGaugeScaleRangeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets from.
    [<CustomOperation("From")>] member inline _.From ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("From" => x)
    /// Gets or sets to position.
    [<CustomOperation("To")>] member inline _.To ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("To" => x)
    /// Gets or sets the fill.
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    /// Gets or sets the stroke.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Gets or sets the width of the stroke.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Gets or sets the height.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Height" => x)

/// RadzenSSRSViewerParameter component.
type RadzenSSRSViewerParameterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the name of the parameter.
    [<CustomOperation("ParameterName")>] member inline _.ParameterName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ParameterName" => x)
    /// Gets or sets the value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

/// RadzenTabsItem component.
type RadzenTabsItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the arbitrary attributes.
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    /// Gets or sets a value indicating whether this RadzenTabsItem is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Gets or sets a value indicating whether this RadzenTabsItem is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Gets or sets the text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenTabsItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the icon.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    /// Gets or sets a value indicating whether this RadzenTabsItem is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Gets or sets a value indicating whether this RadzenTabsItem is selected.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Gets or sets a value indicating whether this RadzenTabsItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Gets or sets a value indicating whether this RadzenTabsItem is disabled.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// Registers and manages the current theme. Requires ThemeService to be registered in the DI container.
type RadzenThemeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the theme.
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Theme" => x)
    /// Enables WCAG contrast requirements. If set to true additional CSS file will be loaded.
    [<CustomOperation("Wcag")>] member inline _.Wcag ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Wcag" =>>> true)
    /// Enables WCAG contrast requirements. If set to true additional CSS file will be loaded.
    [<CustomOperation("Wcag")>] member inline _.Wcag ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Wcag" =>>> x)

/// Tick configuration of IChartAxis. 
type RadzenTicksBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Specifies the color of the ticks lines.
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    /// Specifies the width of the tick lines. Set to 1 by default.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    /// Specifies the type of line used to render the ticks.
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.TickTemplateContext -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)

/// Represents a table of contents item.
type RadzenTocItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the text displayed in the table of contents.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets the CSS selector of the element to scroll to.
    [<CustomOperation("Selector")>] member inline _.Selector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)

/// A component which is an item in a RadzenTree
type RadzenTreeItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Specifies additional custom attributes that will be rendered by the component.
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    /// Gets or sets the template. Use it to customize the appearance of a tree item.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenTreeItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)
    /// Gets or sets the text displayed by the tree item.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Gets or sets value indicating if the tree item checkbox can be checked.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Checkable" =>>> true)
    /// Gets or sets value indicating if the tree item checkbox can be checked.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Checkable" =>>> x)
    /// Specifies whether this item is expanded. Set to false by default.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Specifies whether this item is expanded. Set to false by default.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Gets or sets the value of the tree item.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    /// Gets or sets a value indicating whether this instance has children.
    [<CustomOperation("HasChildren")>] member inline _.HasChildren ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HasChildren" =>>> true)
    /// Gets or sets a value indicating whether this instance has children.
    [<CustomOperation("HasChildren")>] member inline _.HasChildren ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HasChildren" =>>> x)
    /// Specifies whether this item is selected or not. Set to false by default.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Specifies whether this item is selected or not. Set to false by default.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// The children data.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.IEnumerable) = render ==> ("Data" => x)
    /// Gets or sets the CSS classes added to the content.
    [<CustomOperation("ContentCssClass")>] member inline _.ContentCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContentCssClass" => x)
    /// Gets or sets the CSS classes added to the icon.
    [<CustomOperation("IconCssClass")>] member inline _.IconCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconCssClass" => x)
    /// Gets or sets the CSS classes added to the label.
    [<CustomOperation("LabelCssClass")>] member inline _.LabelCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelCssClass" => x)

/// Configures a level of nodes in a RadzenTree during data-binding.
type RadzenTreeLevelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Specifies the name of the property which provides values for the Text property of the child items.
    [<CustomOperation("TextProperty")>] member inline _.TextProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextProperty" => x)
    /// Specifies the name of the property which provides values for the Checkable property of the child items.
    [<CustomOperation("CheckableProperty")>] member inline _.CheckableProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckableProperty" => x)
    /// Specifies the name of the property which returns child data. The value returned by that property should be IEnumerable
    [<CustomOperation("ChildrenProperty")>] member inline _.ChildrenProperty ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ChildrenProperty" => x)
    /// Determines if a child item has children or not. Set to value => true by default.
    [<CustomOperation("HasChildren")>] member inline _.HasChildren ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HasChildren" => (System.Func<System.Object, System.Boolean>fn))
    /// Determines if a child item is expanded or not. Set to value => false by default.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Expanded" => (System.Func<System.Object, System.Boolean>fn))
    /// Determines if a child item is selected or not. Set to value => false by default.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Selected" => (System.Func<System.Object, System.Boolean>fn))
    /// Determines the text of a child item.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Text" => (System.Func<System.Object, System.String>fn))
    /// Determines the if the checkbox of the child item can be checked.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Checkable" => (System.Func<System.Object, System.Boolean>fn))
    /// Gets or sets the template.
    [<CustomOperation("Template")>] member inline _.Template ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.RadzenTreeItem -> NodeRenderFragment) = render ==> html.renderFragment("Template", fn)

type RadzenChartTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


type RadzenComponentsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Specifies additional custom attributes that will be rendered by the component.
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)

type RadzenDataFilterItemBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataFilter")>] member inline _.DataFilter ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataFilter<'TItem>) = render ==> ("DataFilter" => x)
    [<CustomOperation("Parent")>] member inline _.Parent ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataFilterItem<'TItem>) = render ==> ("Parent" => x)
    [<CustomOperation("Filter")>] member inline _.Filter ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.CompositeFilterDescriptor) = render ==> ("Filter" => x)

type RadzenDataGridFilterMenuBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGridColumn<'TItem>) = render ==> ("Column" => x)
    [<CustomOperation("Grid")>] member inline _.Grid ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGrid<'TItem>) = render ==> ("Grid" => x)

type RadzenDataGridFooterCellBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGridColumn<'TItem>) = render ==> ("Column" => x)
    [<CustomOperation("RowIndex")>] member inline _.RowIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowIndex" => x)
    [<CustomOperation("Grid")>] member inline _.Grid ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGrid<'TItem>) = render ==> ("Grid" => x)
    [<CustomOperation("CssClass")>] member inline _.CssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CssClass" => x)

type RadzenDataGridGroupFooterCellBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Group) = render ==> ("Group" => x)
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGridColumn<'TItem>) = render ==> ("Column" => x)
    [<CustomOperation("RowIndex")>] member inline _.RowIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowIndex" => x)
    [<CustomOperation("Grid")>] member inline _.Grid ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGrid<'TItem>) = render ==> ("Grid" => x)
    [<CustomOperation("CssClass")>] member inline _.CssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CssClass" => x)

type RadzenDataGridGroupFooterRowBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.RadzenDataGridColumn<'TItem>>) = render ==> ("Columns" => x)
    [<CustomOperation("GroupResult")>] member inline _.GroupResult ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.GroupResult) = render ==> ("GroupResult" => x)
    [<CustomOperation("Grid")>] member inline _.Grid ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGrid<'TItem>) = render ==> ("Grid" => x)
    [<CustomOperation("Parent")>] member inline _.Parent ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGridGroupRow<'TItem>) = render ==> ("Parent" => x)
    [<CustomOperation("Builder")>] member inline _.Builder ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder) = render ==> ("Builder" => x)

type RadzenDataGridGroupRowBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.RadzenDataGridColumn<'TItem>>) = render ==> ("Columns" => x)
    [<CustomOperation("GroupResult")>] member inline _.GroupResult ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.GroupResult) = render ==> ("GroupResult" => x)
    [<CustomOperation("Grid")>] member inline _.Grid ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGrid<'TItem>) = render ==> ("Grid" => x)
    [<CustomOperation("Parent")>] member inline _.Parent ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGridGroupRow<'TItem>) = render ==> ("Parent" => x)
    [<CustomOperation("Builder")>] member inline _.Builder ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder) = render ==> ("Builder" => x)

type RadzenDataGridHeaderCellBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGridColumn<'TItem>) = render ==> ("Column" => x)
    [<CustomOperation("ColumnIndex")>] member inline _.ColumnIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ColumnIndex" => x)
    [<CustomOperation("RowIndex")>] member inline _.RowIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowIndex" => x)
    [<CustomOperation("Grid")>] member inline _.Grid ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataGrid<'TItem>) = render ==> ("Grid" => x)
    [<CustomOperation("CssClass")>] member inline _.CssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CssClass" => x)

type RadzenDataListRowBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataList")>] member inline _.DataList ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDataList<'TItem>) = render ==> ("DataList" => x)
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("Item" => x)

type RadzenDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the close side dialog aria label text.
    [<CustomOperation("CloseSideDialogAriaLabel")>] member inline _.CloseSideDialogAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseSideDialogAriaLabel" => x)

type RadzenDropDownItemBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("DropDown")>] member inline _.DropDown ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenDropDown<'TValue>) = render ==> ("DropDown" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Item" => x)

type RadzenGridRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("CssClass")>] member inline _.CssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CssClass" => x)
    [<CustomOperation("InEditMode")>] member inline _.InEditMode ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("InEditMode" =>>> true)
    [<CustomOperation("InEditMode")>] member inline _.InEditMode ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("InEditMode" =>>> x)

type RadzenListBoxItemBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("ListBox")>] member inline _.ListBox ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.RadzenListBox<'TValue>) = render ==> ("ListBox" => x)
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Item" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

type RadzenNotificationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


type RadzenNotificationMessageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.NotificationMessage) = render ==> ("Message" => x)

type RadzenTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


type RadzenUploadHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

            
namespace rec Radzen.Blazor.DslInternals.Blazor.Rendering

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Radzen.Blazor.DslInternals

type AppointmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CssClass")>] member inline _.CssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CssClass" => x)
    [<CustomOperation("Top")>] member inline _.Top ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Top" => x)
    [<CustomOperation("Left")>] member inline _.Left ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Left" => x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Height" => x)
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.AppointmentData -> unit) = render ==> html.callback("Click", fn)
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.AppointmentData -> Task<unit>) = render ==> html.callbackTask("Click", fn)
    [<CustomOperation("DragStart")>] member inline _.DragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.AppointmentData -> unit) = render ==> html.callback("DragStart", fn)
    [<CustomOperation("DragStart")>] member inline _.DragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.AppointmentData -> Task<unit>) = render ==> html.callbackTask("DragStart", fn)
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.AppointmentData) = render ==> ("Data" => x)
    [<CustomOperation("ShowAppointmentContent")>] member inline _.ShowAppointmentContent ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowAppointmentContent" =>>> true)
    [<CustomOperation("ShowAppointmentContent")>] member inline _.ShowAppointmentContent ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowAppointmentContent" =>>> x)

type CategoryAxisTitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("X")>] member inline _.X ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X" => x)
    [<CustomOperation("Y")>] member inline _.Y ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y" => x)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)

type ChartSharedTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)

type ChartSharedTooltipItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("LegendItem")>] member inline _.LegendItem ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LegendItem", fragment)
    [<CustomOperation("LegendItem")>] member inline _.LegendItem ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LegendItem", fragment { yield! fragments })
    [<CustomOperation("LegendItem")>] member inline _.LegendItem ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LegendItem", html.text x)
    [<CustomOperation("LegendItem")>] member inline _.LegendItem ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LegendItem", html.text x)
    [<CustomOperation("LegendItem")>] member inline _.LegendItem ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LegendItem", html.text x)

type ChartTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)

type DaySlotEventsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CurrentAppointment")>] member inline _.CurrentAppointment ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentAppointment" => x)
    [<CustomOperation("CurrentDate")>] member inline _.CurrentDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("CurrentDate" => x)
    [<CustomOperation("StartDate")>] member inline _.StartDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("StartDate" => x)
    [<CustomOperation("EndDate")>] member inline _.EndDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("EndDate" => x)
    [<CustomOperation("MinutesPerSlot")>] member inline _.MinutesPerSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinutesPerSlot" => x)
    [<CustomOperation("AppointmentDragStart")>] member inline _.AppointmentDragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.AppointmentData -> unit) = render ==> html.callback("AppointmentDragStart", fn)
    [<CustomOperation("AppointmentDragStart")>] member inline _.AppointmentDragStart ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.AppointmentData -> Task<unit>) = render ==> html.callbackTask("AppointmentDragStart", fn)
    [<CustomOperation("Appointments")>] member inline _.Appointments ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Radzen.Blazor.AppointmentData>) = render ==> ("Appointments" => x)

type DialogContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Dialog")>] member inline _.Dialog ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Dialog) = render ==> ("Dialog" => x)
    [<CustomOperation("ShowMask")>] member inline _.ShowMask ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowMask" =>>> true)
    [<CustomOperation("ShowMask")>] member inline _.ShowMask ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowMask" =>>> x)

type EditorButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Shortcut")>] member inline _.Shortcut ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shortcut" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    [<CustomOperation("PreventBlur")>] member inline _.PreventBlur ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventBlur" =>>> true)
    [<CustomOperation("PreventBlur")>] member inline _.PreventBlur ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventBlur" =>>> x)
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Gets or sets the icon color.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    [<CustomOperation("EnabledModes")>] member inline _.EnabledModes ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.HtmlEditorMode) = render ==> ("EnabledModes" => x)
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Click", fn)
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Click", fn)

type EditorColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconColor" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("EnabledModes")>] member inline _.EnabledModes ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.HtmlEditorMode) = render ==> ("EnabledModes" => x)
    [<CustomOperation("ShowHSV")>] member inline _.ShowHSV ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowHSV" =>>> true)
    [<CustomOperation("ShowHSV")>] member inline _.ShowHSV ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowHSV" =>>> x)
    [<CustomOperation("ShowRGBA")>] member inline _.ShowRGBA ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowRGBA" =>>> true)
    [<CustomOperation("ShowRGBA")>] member inline _.ShowRGBA ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowRGBA" =>>> x)
    [<CustomOperation("ShowColors")>] member inline _.ShowColors ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowColors" =>>> true)
    [<CustomOperation("ShowColors")>] member inline _.ShowColors ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowColors" =>>> x)
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowButton" =>>> true)
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowButton" =>>> x)
    [<CustomOperation("HexText")>] member inline _.HexText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HexText" => x)
    [<CustomOperation("RedText")>] member inline _.RedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RedText" => x)
    [<CustomOperation("GreenText")>] member inline _.GreenText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GreenText" => x)
    [<CustomOperation("BlueText")>] member inline _.BlueText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BlueText" => x)
    [<CustomOperation("AlphaText")>] member inline _.AlphaText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AlphaText" => x)
    [<CustomOperation("ButtonText")>] member inline _.ButtonText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ButtonText" => x)
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("Change", fn)
    [<CustomOperation("Change")>] member inline _.Change ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("Change", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)

type EditorDropDownItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Radzen.Blazor.Rendering.EditorDropDownItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

type GaugeBandBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartAngle")>] member inline _.StartAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StartAngle" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("EndAngle")>] member inline _.EndAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("EndAngle" => x)
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("From")>] member inline _.From ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("From" => x)
    [<CustomOperation("To")>] member inline _.To ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("To" => x)
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Radius" => x)
    [<CustomOperation("Center")>] member inline _.Center ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.Point) = render ==> ("Center" => x)
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Size" => x)

type GaugePointerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Radius" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("StartAngle")>] member inline _.StartAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StartAngle" => x)
    [<CustomOperation("EndAngle")>] member inline _.EndAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("EndAngle" => x)
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Width" => x)
    [<CustomOperation("Length")>] member inline _.Length ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Length" => x)
    [<CustomOperation("Center")>] member inline _.Center ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.Point) = render ==> ("Center" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)

type GaugeScaleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartAngle")>] member inline _.StartAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StartAngle" => x)
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("TickLength")>] member inline _.TickLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("TickLength" => x)
    [<CustomOperation("MinorTickLength")>] member inline _.MinorTickLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MinorTickLength" => x)
    [<CustomOperation("TickLabelOffset")>] member inline _.TickLabelOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("TickLabelOffset" => x)
    [<CustomOperation("EndAngle")>] member inline _.EndAngle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("EndAngle" => x)
    [<CustomOperation("Radius")>] member inline _.Radius ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Radius" => x)
    [<CustomOperation("Center")>] member inline _.Center ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.Point) = render ==> ("Center" => x)
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("ShowFirstTick")>] member inline _.ShowFirstTick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowFirstTick" =>>> true)
    [<CustomOperation("ShowFirstTick")>] member inline _.ShowFirstTick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowFirstTick" =>>> x)
    [<CustomOperation("ShowLastTick")>] member inline _.ShowLastTick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowLastTick" =>>> true)
    [<CustomOperation("ShowLastTick")>] member inline _.ShowLastTick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowLastTick" =>>> x)
    [<CustomOperation("ShowTickLabels")>] member inline _.ShowTickLabels ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowTickLabels" =>>> true)
    [<CustomOperation("ShowTickLabels")>] member inline _.ShowTickLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowTickLabels" =>>> x)
    [<CustomOperation("TickPosition")>] member inline _.TickPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.GaugeTickPosition) = render ==> ("TickPosition" => x)
    [<CustomOperation("FormatString")>] member inline _.FormatString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FormatString" => x)
    [<CustomOperation("Formatter")>] member inline _.Formatter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Formatter" => (System.Func<System.Double, System.String>fn))
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Step" => x)
    [<CustomOperation("MinorStep")>] member inline _.MinorStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MinorStep" => x)

type HoursBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Start")>] member inline _.Start ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("Start" => x)
    [<CustomOperation("End")>] member inline _.End ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("End" => x)
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    [<CustomOperation("MinutesPerSlot")>] member inline _.MinutesPerSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinutesPerSlot" => x)

type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


type LegendItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("MarkerType")>] member inline _.MarkerType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.MarkerType) = render ==> ("MarkerType" => x)
    [<CustomOperation("MarkerSize")>] member inline _.MarkerSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MarkerSize" => x)
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Click", fn)
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Click", fn)
    [<CustomOperation("Clickable")>] member inline _.Clickable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clickable" =>>> true)
    [<CustomOperation("Clickable")>] member inline _.Clickable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clickable" =>>> x)
    [<CustomOperation("Index")>] member inline _.Index ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Index" => x)

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("X1")>] member inline _.X1 ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X1" => x)
    [<CustomOperation("X2")>] member inline _.X2 ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X2" => x)
    [<CustomOperation("Y1")>] member inline _.Y1 ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y1" => x)
    [<CustomOperation("Y2")>] member inline _.Y2 ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y2" => x)
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)

type MarkerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("X")>] member inline _.X ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.MarkerType) = render ==> ("Type" => x)
    [<CustomOperation("Y")>] member inline _.Y ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y" => x)
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Size" => x)
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("Click", fn)
    [<CustomOperation("Click")>] member inline _.Click ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("Click", fn)

type MarkersBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Series")>] member inline _.Series ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.IChartSeries) = render ==> ("Series" => x)
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Radzen.Blazor.Point<'TItem>>) = render ==> ("Data" => x)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    [<CustomOperation("MarkerType")>] member inline _.MarkerType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.MarkerType) = render ==> ("MarkerType" => x)
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Size" => x)

type PathBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("D")>] member inline _.D ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("D" => x)
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Stroke" => x)
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("LineType")>] member inline _.LineType ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.LineType) = render ==> ("LineType" => x)

type TextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Blazor.Point) = render ==> ("Position" => x)
    [<CustomOperation("TextAnchor")>] member inline _.TextAnchor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextAnchor" => x)
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)

type YearViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("StartDate")>] member inline _.StartDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("StartDate" => x)
    [<CustomOperation("EndDate")>] member inline _.EndDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("EndDate" => x)
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: Radzen.Month) = render ==> ("StartMonth" => x)
    [<CustomOperation("MaxAppointmentsInSlot")>] member inline _.MaxAppointmentsInSlot ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxAppointmentsInSlot" => x)
    [<CustomOperation("MoreText")>] member inline _.MoreText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MoreText" => x)
    [<CustomOperation("NoDayEventsText")>] member inline _.NoDayEventsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoDayEventsText" => x)
    [<CustomOperation("Appointments")>] member inline _.Appointments ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<Radzen.Blazor.AppointmentData>) = render ==> ("Appointments" => x)

            

// =======================================================================================================================

namespace Radzen.Blazor

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Radzen.Blazor.DslInternals


    /// Base class of Radzen Blazor components.
    ///             
    type RadzenComponent' 
        /// Base class of Radzen Blazor components.
        ///             
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.RadzenComponent>)>] () = inherit RadzenComponentBuilder<Radzen.RadzenComponent>()

    /// A base class of components that have child content.
    type RadzenComponentWithChildren' 
        /// A base class of components that have child content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.RadzenComponentWithChildren>)>] () = inherit RadzenComponentWithChildrenBuilder<Radzen.RadzenComponentWithChildren>()

    /// A base class of row/col components.
    type RadzenFlexComponent' 
        /// A base class of row/col components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.RadzenFlexComponent>)>] () = inherit RadzenFlexComponentBuilder<Radzen.RadzenFlexComponent>()

    /// Class DataBoundFormComponent.
    /// Implements the RadzenComponent
    /// Implements the IRadzenFormComponent
    type DataBoundFormComponent'<'T> 
        /// Class DataBoundFormComponent.
        /// Implements the RadzenComponent
        /// Implements the IRadzenFormComponent
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.DataBoundFormComponent<_>>)>] () = inherit DataBoundFormComponentBuilder<Radzen.DataBoundFormComponent<'T>, 'T>()

    /// Base class of components that display a list of items.
    type DropDownBase'<'T> 
        /// Base class of components that display a list of items.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.DropDownBase<_>>)>] () = inherit DropDownBaseBuilder<Radzen.DropDownBase<'T>, 'T>()

    /// Class FormComponent.
    /// Implements the RadzenComponent
    /// Implements the IRadzenFormComponent
    type FormComponent'<'T> 
        /// Class FormComponent.
        /// Implements the RadzenComponent
        /// Implements the IRadzenFormComponent
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.FormComponent<_>>)>] () = inherit FormComponentBuilder<Radzen.FormComponent<'T>, 'T>()

    /// Class FormComponentWithAutoComplete.
    type FormComponentWithAutoComplete'<'T> 
        /// Class FormComponentWithAutoComplete.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.FormComponentWithAutoComplete<_>>)>] () = inherit FormComponentWithAutoCompleteBuilder<Radzen.FormComponentWithAutoComplete<'T>, 'T>()

    /// Base classes of components that support paging.
    type PagedDataBoundComponent'<'T> 
        /// Base classes of components that support paging.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.PagedDataBoundComponent<_>>)>] () = inherit PagedDataBoundComponentBuilder<Radzen.PagedDataBoundComponent<'T>, 'T>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Radzen.Blazor.DslInternals

    let RadzenComponent'' = RadzenComponent'()
    let RadzenComponentWithChildren'' = RadzenComponentWithChildren'()
    let RadzenFlexComponent'' = RadzenFlexComponent'()
    let DataBoundFormComponent''<'T> = DataBoundFormComponent'<'T>()
    let DropDownBase''<'T> = DropDownBase'<'T>()
    let FormComponent''<'T> = FormComponent'<'T>()
    let FormComponentWithAutoComplete''<'T> = FormComponentWithAutoComplete'<'T>()
    let PagedDataBoundComponent''<'T> = PagedDataBoundComponent'<'T>()
            
namespace Radzen.Blazor.Blazor

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Radzen.Blazor.DslInternals.Blazor


    /// RadzenCard component.
    type RadzenRow' 
        /// RadzenCard component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRow>)>] () = inherit RadzenRowBuilder<Radzen.Blazor.RadzenRow>()

    /// RadzenStack component.
    type RadzenStack' 
        /// RadzenStack component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenStack>)>] () = inherit RadzenStackBuilder<Radzen.Blazor.RadzenStack>()

    /// RadzenAlert component.
    type RadzenAlert' 
        /// RadzenAlert component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenAlert>)>] () = inherit RadzenAlertBuilder<Radzen.Blazor.RadzenAlert>()

    /// RadzenBody component.
    type RadzenBody' 
        /// RadzenBody component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenBody>)>] () = inherit RadzenBodyBuilder<Radzen.Blazor.RadzenBody>()

    /// A component to display a Bread Crumb style menu
    type RadzenBreadCrumb' 
        /// A component to display a Bread Crumb style menu
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenBreadCrumb>)>] () = inherit RadzenBreadCrumbBuilder<Radzen.Blazor.RadzenBreadCrumb>()

    /// RadzenCard component.
    type RadzenCard' 
        /// RadzenCard component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCard>)>] () = inherit RadzenCardBuilder<Radzen.Blazor.RadzenCard>()

    /// RadzenCardGroup component.
    type RadzenCardGroup' 
        /// RadzenCardGroup component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCardGroup>)>] () = inherit RadzenCardGroupBuilder<Radzen.Blazor.RadzenCardGroup>()

    /// RadzenColumn component.
    type RadzenColumn' 
        /// RadzenColumn component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenColumn>)>] () = inherit RadzenColumnBuilder<Radzen.Blazor.RadzenColumn>()

    /// RadzenContent component.
    type RadzenContent' 
        /// RadzenContent component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenContent>)>] () = inherit RadzenContentBuilder<Radzen.Blazor.RadzenContent>()

    /// RadzenContentContainer component.
    type RadzenContentContainer' 
        /// RadzenContentContainer component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenContentContainer>)>] () = inherit RadzenContentContainerBuilder<Radzen.Blazor.RadzenContentContainer>()

    /// RadzenDropZone component.
    type RadzenDropZone'<'TItem> 
        /// RadzenDropZone component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDropZone<_>>)>] () = inherit RadzenDropZoneBuilder<Radzen.Blazor.RadzenDropZone<'TItem>, 'TItem>()

    /// RadzenDropZoneContainer component.
    type RadzenDropZoneContainer'<'TItem> 
        /// RadzenDropZoneContainer component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDropZoneContainer<_>>)>] () = inherit RadzenDropZoneContainerBuilder<Radzen.Blazor.RadzenDropZoneContainer<'TItem>, 'TItem>()

    /// RadzenFooter component.
    type RadzenFooter' 
        /// RadzenFooter component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenFooter>)>] () = inherit RadzenFooterBuilder<Radzen.Blazor.RadzenFooter>()

    /// RadzenHeader component.
    type RadzenHeader' 
        /// RadzenHeader component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHeader>)>] () = inherit RadzenHeaderBuilder<Radzen.Blazor.RadzenHeader>()

    /// RadzenImage component.
    type RadzenImage' 
        /// RadzenImage component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenImage>)>] () = inherit RadzenImageBuilder<Radzen.Blazor.RadzenImage>()

    /// RadzenLayout component.
    type RadzenLayout' 
        /// RadzenLayout component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenLayout>)>] () = inherit RadzenLayoutBuilder<Radzen.Blazor.RadzenLayout>()

    /// RadzenMenu component.
    type RadzenMenu' 
        /// RadzenMenu component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMenu>)>] () = inherit RadzenMenuBuilder<Radzen.Blazor.RadzenMenu>()

    /// RadzenPanel component.
    type RadzenPanel' 
        /// RadzenPanel component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenPanel>)>] () = inherit RadzenPanelBuilder<Radzen.Blazor.RadzenPanel>()

    /// RadzenPanelMenu component.
    type RadzenPanelMenu' 
        /// RadzenPanelMenu component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenPanelMenu>)>] () = inherit RadzenPanelMenuBuilder<Radzen.Blazor.RadzenPanelMenu>()

    /// RadzenProfileMenu component.
    type RadzenProfileMenu' 
        /// RadzenProfileMenu component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenProfileMenu>)>] () = inherit RadzenProfileMenuBuilder<Radzen.Blazor.RadzenProfileMenu>()

    /// RadzenSidebar component.
    type RadzenSidebar' 
        /// RadzenSidebar component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSidebar>)>] () = inherit RadzenSidebarBuilder<Radzen.Blazor.RadzenSidebar>()

    /// RadzenSplitButton component.
    type RadzenSplitButton' 
        /// RadzenSplitButton component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSplitButton>)>] () = inherit RadzenSplitButtonBuilder<Radzen.Blazor.RadzenSplitButton>()

    /// RadzenTable component.
    type RadzenTable' 
        /// RadzenTable component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTable>)>] () = inherit RadzenTableBuilder<Radzen.Blazor.RadzenTable>()

    /// RadzenTableBody component.
    type RadzenTableBody' 
        /// RadzenTableBody component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTableBody>)>] () = inherit RadzenTableBodyBuilder<Radzen.Blazor.RadzenTableBody>()

    /// RadzenTableRow component.
    type RadzenTableCell' 
        /// RadzenTableRow component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTableCell>)>] () = inherit RadzenTableCellBuilder<Radzen.Blazor.RadzenTableCell>()

    /// RadzenTableHeader component.
    type RadzenTableHeader' 
        /// RadzenTableHeader component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTableHeader>)>] () = inherit RadzenTableHeaderBuilder<Radzen.Blazor.RadzenTableHeader>()

    /// RadzenTableRow component.
    type RadzenTableHeaderCell' 
        /// RadzenTableRow component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTableHeaderCell>)>] () = inherit RadzenTableHeaderCellBuilder<Radzen.Blazor.RadzenTableHeaderCell>()

    /// RadzenTableRow component.
    type RadzenTableHeaderRow' 
        /// RadzenTableRow component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTableHeaderRow>)>] () = inherit RadzenTableHeaderRowBuilder<Radzen.Blazor.RadzenTableHeaderRow>()

    /// RadzenTableRow component.
    type RadzenTableRow' 
        /// RadzenTableRow component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTableRow>)>] () = inherit RadzenTableRowBuilder<Radzen.Blazor.RadzenTableRow>()
    type RadzenMenuItemWrapper' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMenuItemWrapper>)>] () = inherit RadzenMenuItemWrapperBuilder<Radzen.Blazor.RadzenMenuItemWrapper>()

    /// Base class of Radzen validator components.
    type ValidatorBase' 
        /// Base class of Radzen validator components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.ValidatorBase>)>] () = inherit ValidatorBaseBuilder<Radzen.Blazor.ValidatorBase>()

    /// A validator component which compares a component value with a specified value.
    /// Must be placed inside a RadzenTemplateForm`1
    type RadzenCompareValidator' 
        /// A validator component which compares a component value with a specified value.
        /// Must be placed inside a RadzenTemplateForm`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCompareValidator>)>] () = inherit RadzenCompareValidatorBuilder<Radzen.Blazor.RadzenCompareValidator>()

    /// A validator component which compares a component value with a specified value.
    /// Must be placed inside a RadzenTemplateForm`1
    type RadzenCustomValidator' 
        /// A validator component which compares a component value with a specified value.
        /// Must be placed inside a RadzenTemplateForm`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCustomValidator>)>] () = inherit RadzenCustomValidatorBuilder<Radzen.Blazor.RadzenCustomValidator>()

    /// A validator component which validates a component value using the data annotations
    /// defined on the corresponding model property.
    /// Must be placed inside a RadzenTemplateForm`1
    type RadzenDataAnnotationValidator' 
        /// A validator component which validates a component value using the data annotations
        /// defined on the corresponding model property.
        /// Must be placed inside a RadzenTemplateForm`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataAnnotationValidator>)>] () = inherit RadzenDataAnnotationValidatorBuilder<Radzen.Blazor.RadzenDataAnnotationValidator>()

    /// A validator component which checks if a component value is a valid email address.
    /// Must be placed inside a RadzenTemplateForm`1
    type RadzenEmailValidator' 
        /// A validator component which checks if a component value is a valid email address.
        /// Must be placed inside a RadzenTemplateForm`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenEmailValidator>)>] () = inherit RadzenEmailValidatorBuilder<Radzen.Blazor.RadzenEmailValidator>()

    /// A validator component which checks if then component value length is within a specified range.
    /// Must be placed inside a RadzenTemplateForm`1
    type RadzenLengthValidator' 
        /// A validator component which checks if then component value length is within a specified range.
        /// Must be placed inside a RadzenTemplateForm`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenLengthValidator>)>] () = inherit RadzenLengthValidatorBuilder<Radzen.Blazor.RadzenLengthValidator>()

    /// A validator component which checks if a component value is within a specified range.
    /// Must be placed inside a RadzenTemplateForm`1
    type RadzenNumericRangeValidator' 
        /// A validator component which checks if a component value is within a specified range.
        /// Must be placed inside a RadzenTemplateForm`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenNumericRangeValidator>)>] () = inherit RadzenNumericRangeValidatorBuilder<Radzen.Blazor.RadzenNumericRangeValidator>()

    /// A validator component which matches a component value against a specified regular expression pattern.
    /// Must be placed inside a RadzenTemplateForm`1
    type RadzenRegexValidator' 
        /// A validator component which matches a component value against a specified regular expression pattern.
        /// Must be placed inside a RadzenTemplateForm`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRegexValidator>)>] () = inherit RadzenRegexValidatorBuilder<Radzen.Blazor.RadzenRegexValidator>()

    /// A validator component which checks if a component has value.
    /// Must be placed inside a RadzenTemplateForm`1
    type RadzenRequiredValidator' 
        /// A validator component which checks if a component has value.
        /// Must be placed inside a RadzenTemplateForm`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRequiredValidator>)>] () = inherit RadzenRequiredValidatorBuilder<Radzen.Blazor.RadzenRequiredValidator>()

    /// RadzenProgressBar component.
    type RadzenProgressBar' 
        /// RadzenProgressBar component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenProgressBar>)>] () = inherit RadzenProgressBarBuilder<Radzen.Blazor.RadzenProgressBar>()

    /// RadzenProgressBarCircular component.
    type RadzenProgressBarCircular' 
        /// RadzenProgressBarCircular component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenProgressBarCircular>)>] () = inherit RadzenProgressBarCircularBuilder<Radzen.Blazor.RadzenProgressBarCircular>()

    /// Displays line, area, donut, pie, bar or column series.
    type RadzenChart' 
        /// Displays line, area, donut, pie, bar or column series.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenChart>)>] () = inherit RadzenChartBuilder<Radzen.Blazor.RadzenChart>()

    /// A sparkline is a small chart that provides a simple way to visualize trends in data.
    type RadzenSparkline' 
        /// A sparkline is a small chart that provides a simple way to visualize trends in data.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSparkline>)>] () = inherit RadzenSparklineBuilder<Radzen.Blazor.RadzenSparkline>()

    /// RadzenButton component.
    type RadzenButton' 
        /// RadzenButton component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenButton>)>] () = inherit RadzenButtonBuilder<Radzen.Blazor.RadzenButton>()

    /// RadzenButton component.
    type RadzenToggleButton' 
        /// RadzenButton component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenToggleButton>)>] () = inherit RadzenToggleButtonBuilder<Radzen.Blazor.RadzenToggleButton>()

    /// Class GaugeBase.
    /// Implements the RadzenComponent
    type GaugeBase' 
        /// Class GaugeBase.
        /// Implements the RadzenComponent
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.GaugeBase>)>] () = inherit GaugeBaseBuilder<Radzen.Blazor.GaugeBase>()
    type RadzenArcGauge' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenArcGauge>)>] () = inherit RadzenArcGaugeBuilder<Radzen.Blazor.RadzenArcGauge>()
    type RadzenRadialGauge' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRadialGauge>)>] () = inherit RadzenRadialGaugeBuilder<Radzen.Blazor.RadzenRadialGauge>()

    /// RadzenDropDown component.
    type RadzenDropDown'<'TValue> 
        /// RadzenDropDown component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDropDown<_>>)>] () = inherit RadzenDropDownBuilder<Radzen.Blazor.RadzenDropDown<'TValue>, 'TValue>()

    /// RadzenDropDownDataGrid component.
    type RadzenDropDownDataGrid'<'TValue> 
        /// RadzenDropDownDataGrid component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDropDownDataGrid<_>>)>] () = inherit RadzenDropDownDataGridBuilder<Radzen.Blazor.RadzenDropDownDataGrid<'TValue>, 'TValue>()

    /// RadzenListBox component.
    type RadzenListBox'<'TValue> 
        /// RadzenListBox component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenListBox<_>>)>] () = inherit RadzenListBoxBuilder<Radzen.Blazor.RadzenListBox<'TValue>, 'TValue>()

    /// RadzenAutoComplete component.
    type RadzenAutoComplete' 
        /// RadzenAutoComplete component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenAutoComplete>)>] () = inherit RadzenAutoCompleteBuilder<Radzen.Blazor.RadzenAutoComplete>()

    /// RadzenMask component.
    type RadzenMask' 
        /// RadzenMask component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMask>)>] () = inherit RadzenMaskBuilder<Radzen.Blazor.RadzenMask>()

    /// RadzenNumeric component.
    type RadzenNumeric'<'TValue> 
        /// RadzenNumeric component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenNumeric<_>>)>] () = inherit RadzenNumericBuilder<Radzen.Blazor.RadzenNumeric<'TValue>, 'TValue>()

    /// RadzenPassword component.
    type RadzenPassword' 
        /// RadzenPassword component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenPassword>)>] () = inherit RadzenPasswordBuilder<Radzen.Blazor.RadzenPassword>()

    /// An input component for single line text entry.
    type RadzenTextBox' 
        /// An input component for single line text entry.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTextBox>)>] () = inherit RadzenTextBoxBuilder<Radzen.Blazor.RadzenTextBox>()

    /// RadzenCheckBox component.
    type RadzenCheckBox'<'TValue> 
        /// RadzenCheckBox component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCheckBox<_>>)>] () = inherit RadzenCheckBoxBuilder<Radzen.Blazor.RadzenCheckBox<'TValue>, 'TValue>()

    /// RadzenCheckBoxList component.
    type RadzenCheckBoxList'<'TValue> 
        /// RadzenCheckBoxList component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCheckBoxList<_>>)>] () = inherit RadzenCheckBoxListBuilder<Radzen.Blazor.RadzenCheckBoxList<'TValue>, 'TValue>()

    /// RadzenColorPicker component.
    type RadzenColorPicker' 
        /// RadzenColorPicker component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenColorPicker>)>] () = inherit RadzenColorPickerBuilder<Radzen.Blazor.RadzenColorPicker>()

    /// RadzenFileInput component.
    type RadzenFileInput'<'TValue> 
        /// RadzenFileInput component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenFileInput<_>>)>] () = inherit RadzenFileInputBuilder<Radzen.Blazor.RadzenFileInput<'TValue>, 'TValue>()

    /// A component which edits HTML content. Provides built-in upload capabilities.
    type RadzenHtmlEditor' 
        /// A component which edits HTML content. Provides built-in upload capabilities.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditor>)>] () = inherit RadzenHtmlEditorBuilder<Radzen.Blazor.RadzenHtmlEditor>()

    /// RadzenRadioButtonList component.
    type RadzenRadioButtonList'<'TValue> 
        /// RadzenRadioButtonList component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRadioButtonList<_>>)>] () = inherit RadzenRadioButtonListBuilder<Radzen.Blazor.RadzenRadioButtonList<'TValue>, 'TValue>()

    /// RadzenRating component.
    type RadzenRating' 
        /// RadzenRating component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRating>)>] () = inherit RadzenRatingBuilder<Radzen.Blazor.RadzenRating>()

    /// RadzenRating component.
    type RadzenSecurityCode' 
        /// RadzenRating component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSecurityCode>)>] () = inherit RadzenSecurityCodeBuilder<Radzen.Blazor.RadzenSecurityCode>()

    /// RadzenSelectBar component.
    type RadzenSelectBar'<'TValue> 
        /// RadzenSelectBar component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSelectBar<_>>)>] () = inherit RadzenSelectBarBuilder<Radzen.Blazor.RadzenSelectBar<'TValue>, 'TValue>()

    /// RadzenSlider component.
    type RadzenSlider'<'TValue> 
        /// RadzenSlider component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSlider<_>>)>] () = inherit RadzenSliderBuilder<Radzen.Blazor.RadzenSlider<'TValue>, 'TValue>()

    /// RadzenSwitch component.
    type RadzenSwitch' 
        /// RadzenSwitch component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSwitch>)>] () = inherit RadzenSwitchBuilder<Radzen.Blazor.RadzenSwitch>()

    /// RadzenTextArea component.
    type RadzenTextArea' 
        /// RadzenTextArea component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTextArea>)>] () = inherit RadzenTextAreaBuilder<Radzen.Blazor.RadzenTextArea>()

    /// RadzenDataGrid component.
    type RadzenDataGrid'<'TItem> 
        /// RadzenDataGrid component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGrid<_>>)>] () = inherit RadzenDataGridBuilder<Radzen.Blazor.RadzenDataGrid<'TItem>, 'TItem>()

    /// RadzenDataList component.
    type RadzenDataList'<'TItem> 
        /// RadzenDataList component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataList<_>>)>] () = inherit RadzenDataListBuilder<Radzen.Blazor.RadzenDataList<'TItem>, 'TItem>()

    /// RadzenAccordion component.
    type RadzenAccordion' 
        /// RadzenAccordion component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenAccordion>)>] () = inherit RadzenAccordionBuilder<Radzen.Blazor.RadzenAccordion>()

    /// Class RadzenAccordionItem.
    type RadzenAccordionItem' 
        /// Class RadzenAccordionItem.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenAccordionItem>)>] () = inherit RadzenAccordionItemBuilder<Radzen.Blazor.RadzenAccordionItem>()

    /// Dark or light theme switch. Requires ThemeService to be registered in the DI container.
    type RadzenAppearanceToggle' 
        /// Dark or light theme switch. Requires ThemeService to be registered in the DI container.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenAppearanceToggle>)>] () = inherit RadzenAppearanceToggleBuilder<Radzen.Blazor.RadzenAppearanceToggle>()

    /// RadzenBadge component.
    type RadzenBadge' 
        /// RadzenBadge component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenBadge>)>] () = inherit RadzenBadgeBuilder<Radzen.Blazor.RadzenBadge>()

    /// Bread Crumb Item Component
    type RadzenBreadCrumbItem' 
        /// Bread Crumb Item Component
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenBreadCrumbItem>)>] () = inherit RadzenBreadCrumbItemBuilder<Radzen.Blazor.RadzenBreadCrumbItem>()

    /// RadzenCarousel component.
    type RadzenCarousel' 
        /// RadzenCarousel component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCarousel>)>] () = inherit RadzenCarouselBuilder<Radzen.Blazor.RadzenCarousel>()

    /// RadzenCheckBoxListItem component.
    type RadzenCheckBoxListItem'<'TValue> 
        /// RadzenCheckBoxListItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCheckBoxListItem<_>>)>] () = inherit RadzenCheckBoxListItemBuilder<Radzen.Blazor.RadzenCheckBoxListItem<'TValue>, 'TValue>()

    /// RadzenDataFilter component.
    type RadzenDataFilter'<'TItem> 
        /// RadzenDataFilter component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataFilter<_>>)>] () = inherit RadzenDataFilterBuilder<Radzen.Blazor.RadzenDataFilter<'TItem>, 'TItem>()

    /// RadzenDatePicker component.
    type RadzenDatePicker'<'TValue> 
        /// RadzenDatePicker component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDatePicker<_>>)>] () = inherit RadzenDatePickerBuilder<Radzen.Blazor.RadzenDatePicker<'TValue>, 'TValue>()

    /// RadzenDropZoneItem component.
    type RadzenDropZoneItem'<'TItem> 
        /// RadzenDropZoneItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDropZoneItem<_>>)>] () = inherit RadzenDropZoneItemBuilder<Radzen.Blazor.RadzenDropZoneItem<'TItem>, 'TItem>()

    /// RadzenFieldset component.
    type RadzenFieldset' 
        /// RadzenFieldset component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenFieldset>)>] () = inherit RadzenFieldsetBuilder<Radzen.Blazor.RadzenFieldset>()

    /// A Blazor component that wraps another component and adds a label, helper text, start and end content.
    type RadzenFormField' 
        /// A Blazor component that wraps another component and adds a label, helper text, start and end content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenFormField>)>] () = inherit RadzenFormFieldBuilder<Radzen.Blazor.RadzenFormField>()

    /// RadzenGoogleMap component.
    type RadzenGoogleMap' 
        /// RadzenGoogleMap component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenGoogleMap>)>] () = inherit RadzenGoogleMapBuilder<Radzen.Blazor.RadzenGoogleMap>()

    /// RadzenGoogleMapMarker component.
    type RadzenGoogleMapMarker' 
        /// RadzenGoogleMapMarker component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenGoogleMapMarker>)>] () = inherit RadzenGoogleMapMarkerBuilder<Radzen.Blazor.RadzenGoogleMapMarker>()

    /// RadzenGravatar component.
    type RadzenGravatar' 
        /// RadzenGravatar component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenGravatar>)>] () = inherit RadzenGravatarBuilder<Radzen.Blazor.RadzenGravatar>()

    /// RadzenHeading component.
    type RadzenHeading' 
        /// RadzenHeading component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHeading>)>] () = inherit RadzenHeadingBuilder<Radzen.Blazor.RadzenHeading>()

    /// RadzenIcon component. Displays icon from Material Symbols variable font.
    type RadzenIcon' 
        /// RadzenIcon component. Displays icon from Material Symbols variable font.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenIcon>)>] () = inherit RadzenIconBuilder<Radzen.Blazor.RadzenIcon>()

    /// RadzenLabel component.
    type RadzenLabel' 
        /// RadzenLabel component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenLabel>)>] () = inherit RadzenLabelBuilder<Radzen.Blazor.RadzenLabel>()

    /// RadzenLink component.
    type RadzenLink' 
        /// RadzenLink component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenLink>)>] () = inherit RadzenLinkBuilder<Radzen.Blazor.RadzenLink>()

    /// RadzenLogin component. Must be placed in RadzenTemplateForm.
    type RadzenLogin' 
        /// RadzenLogin component. Must be placed in RadzenTemplateForm.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenLogin>)>] () = inherit RadzenLoginBuilder<Radzen.Blazor.RadzenLogin>()

    /// A component which renders markdown content.
    type RadzenMarkdown' 
        /// A component which renders markdown content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMarkdown>)>] () = inherit RadzenMarkdownBuilder<Radzen.Blazor.RadzenMarkdown>()

    /// RadzenMenuItem component.
    type RadzenMenuItem' 
        /// RadzenMenuItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMenuItem>)>] () = inherit RadzenMenuItemBuilder<Radzen.Blazor.RadzenMenuItem>()

    /// RadzenPager component.
    type RadzenPager' 
        /// RadzenPager component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenPager>)>] () = inherit RadzenPagerBuilder<Radzen.Blazor.RadzenPager>()

    /// RadzenPanelMenuItem component.
    type RadzenPanelMenuItem' 
        /// RadzenPanelMenuItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenPanelMenuItem>)>] () = inherit RadzenPanelMenuItemBuilder<Radzen.Blazor.RadzenPanelMenuItem>()

    /// RadzenCard component.
    type RadzenPickList'<'TItem> 
        /// RadzenCard component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenPickList<_>>)>] () = inherit RadzenPickListBuilder<Radzen.Blazor.RadzenPickList<'TItem>, 'TItem>()

    /// RadzenProfileMenuItem component.
    type RadzenProfileMenuItem' 
        /// RadzenProfileMenuItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenProfileMenuItem>)>] () = inherit RadzenProfileMenuItemBuilder<Radzen.Blazor.RadzenProfileMenuItem>()

    /// RadzenRadioButtonListItem component.
    type RadzenRadioButtonListItem'<'TValue> 
        /// RadzenRadioButtonListItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRadioButtonListItem<_>>)>] () = inherit RadzenRadioButtonListItemBuilder<Radzen.Blazor.RadzenRadioButtonListItem<'TValue>, 'TValue>()

    /// Displays a collection of AppointmentData in day, week or month view.
    type RadzenScheduler'<'TItem> 
        /// Displays a collection of AppointmentData in day, week or month view.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenScheduler<_>>)>] () = inherit RadzenSchedulerBuilder<Radzen.Blazor.RadzenScheduler<'TItem>, 'TItem>()

    /// RadzenSelectBarItem component.
    type RadzenSelectBarItem' 
        /// RadzenSelectBarItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSelectBarItem>)>] () = inherit RadzenSelectBarItemBuilder<Radzen.Blazor.RadzenSelectBarItem>()

    /// RadzenSidebarToggle component.
    type RadzenSidebarToggle' 
        /// RadzenSidebarToggle component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSidebarToggle>)>] () = inherit RadzenSidebarToggleBuilder<Radzen.Blazor.RadzenSidebarToggle>()

    /// RadzenSpeechToTextButton component. Enables speech to text functionality.
    /// This is only supported on select browsers. See https://caniuse.com/?search=SpeechRecognition
    /// 
    /// 
    /// <RadzenSpeechToTextButton Change=@(args => Console.WriteLine($"Value: {args}")) />
    type RadzenSpeechToTextButton' 
        /// RadzenSpeechToTextButton component. Enables speech to text functionality.
        /// This is only supported on select browsers. See https://caniuse.com/?search=SpeechRecognition
        /// 
        /// 
        /// <RadzenSpeechToTextButton Change=@(args => Console.WriteLine($"Value: {args}")) />
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSpeechToTextButton>)>] () = inherit RadzenSpeechToTextButtonBuilder<Radzen.Blazor.RadzenSpeechToTextButton>()

    /// RadzenSplitButtonItem component.
    type RadzenSplitButtonItem' 
        /// RadzenSplitButtonItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSplitButtonItem>)>] () = inherit RadzenSplitButtonItemBuilder<Radzen.Blazor.RadzenSplitButtonItem>()

    /// RadzenSplitter component.
    type RadzenSplitter' 
        /// RadzenSplitter component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSplitter>)>] () = inherit RadzenSplitterBuilder<Radzen.Blazor.RadzenSplitter>()

    /// RadzenSplitterPane component.
    type RadzenSplitterPane' 
        /// RadzenSplitterPane component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSplitterPane>)>] () = inherit RadzenSplitterPaneBuilder<Radzen.Blazor.RadzenSplitterPane>()

    /// RadzenSSRSViewer component.
    type RadzenSSRSViewer' 
        /// RadzenSSRSViewer component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSSRSViewer>)>] () = inherit RadzenSSRSViewerBuilder<Radzen.Blazor.RadzenSSRSViewer>()

    /// RadzenSteps component.
    type RadzenSteps' 
        /// RadzenSteps component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSteps>)>] () = inherit RadzenStepsBuilder<Radzen.Blazor.RadzenSteps>()

    /// RadzenStepsItem component.
    type RadzenStepsItem' 
        /// RadzenStepsItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenStepsItem>)>] () = inherit RadzenStepsItemBuilder<Radzen.Blazor.RadzenStepsItem>()

    /// RadzenTabs component.
    type RadzenTabs' 
        /// RadzenTabs component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTabs>)>] () = inherit RadzenTabsBuilder<Radzen.Blazor.RadzenTabs>()

    /// A component which represents a form. Provides validation support.
    type RadzenTemplateForm'<'TItem> 
        /// A component which represents a form. Provides validation support.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTemplateForm<_>>)>] () = inherit RadzenTemplateFormBuilder<Radzen.Blazor.RadzenTemplateForm<'TItem>, 'TItem>()

    /// A component which displays text or makup with predefined styling.
    type RadzenText' 
        /// A component which displays text or makup with predefined styling.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenText>)>] () = inherit RadzenTextBuilder<Radzen.Blazor.RadzenText>()

    /// RadzenTimeline component is a graphical representation used to display a chronological sequence of events or data points.
    type RadzenTimeline' 
        /// RadzenTimeline component is a graphical representation used to display a chronological sequence of events or data points.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTimeline>)>] () = inherit RadzenTimelineBuilder<Radzen.Blazor.RadzenTimeline>()

    /// RadzenTimeline item.
    type RadzenTimelineItem' 
        /// RadzenTimeline item.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTimelineItem>)>] () = inherit RadzenTimelineItemBuilder<Radzen.Blazor.RadzenTimelineItem>()

    /// RadzenTimeSpanPicker component.
    type RadzenTimeSpanPicker'<'TValue> 
        /// RadzenTimeSpanPicker component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTimeSpanPicker<_>>)>] () = inherit RadzenTimeSpanPickerBuilder<Radzen.Blazor.RadzenTimeSpanPicker<'TValue>, 'TValue>()

    /// Displays a table of contents for a page.
    type RadzenToc' 
        /// Displays a table of contents for a page.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenToc>)>] () = inherit RadzenTocBuilder<Radzen.Blazor.RadzenToc>()

    /// A component which displays a hierarchy of items. Supports inline definition and data-binding.
    type RadzenTree' 
        /// A component which displays a hierarchy of items. Supports inline definition and data-binding.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTree>)>] () = inherit RadzenTreeBuilder<Radzen.Blazor.RadzenTree>()

    /// RadzenUpload component.
    type RadzenUpload' 
        /// RadzenUpload component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenUpload>)>] () = inherit RadzenUploadBuilder<Radzen.Blazor.RadzenUpload>()

    /// Base class of components that are rendered inside a RadzenChart.
    type RadzenChartComponentBase' 
        /// Base class of components that are rendered inside a RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenChartComponentBase>)>] () = inherit RadzenChartComponentBaseBuilder<Radzen.Blazor.RadzenChartComponentBase>()

    /// Grid line configuration of IChartAxis.
    type RadzenGridLines' 
        /// Grid line configuration of IChartAxis.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenGridLines>)>] () = inherit RadzenGridLinesBuilder<Radzen.Blazor.RadzenGridLines>()
    type RadzenSeriesValueLine' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSeriesValueLine>)>] () = inherit RadzenSeriesValueLineBuilder<Radzen.Blazor.RadzenSeriesValueLine>()

    /// Displays the mean of a chart series.
    type RadzenSeriesMeanLine' 
        /// Displays the mean of a chart series.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSeriesMeanLine>)>] () = inherit RadzenSeriesMeanLineBuilder<Radzen.Blazor.RadzenSeriesMeanLine>()

    /// Displays the median of a chart series.
    type RadzenSeriesMedianLine' 
        /// Displays the median of a chart series.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSeriesMedianLine>)>] () = inherit RadzenSeriesMedianLineBuilder<Radzen.Blazor.RadzenSeriesMedianLine>()

    /// Displays the mode of a chart series.
    type RadzenSeriesModeLine' 
        /// Displays the mode of a chart series.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSeriesModeLine>)>] () = inherit RadzenSeriesModeLineBuilder<Radzen.Blazor.RadzenSeriesModeLine>()

    /// Displays the trend of a chart series.
    type RadzenSeriesTrendLine' 
        /// Displays the trend of a chart series.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSeriesTrendLine>)>] () = inherit RadzenSeriesTrendLineBuilder<Radzen.Blazor.RadzenSeriesTrendLine>()

    /// Base class for an axis in RadzenChart.
    type AxisBase' 
        /// Base class for an axis in RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.AxisBase>)>] () = inherit AxisBaseBuilder<Radzen.Blazor.AxisBase>()
    type RadzenCategoryAxis' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCategoryAxis>)>] () = inherit RadzenCategoryAxisBuilder<Radzen.Blazor.RadzenCategoryAxis>()
    type RadzenValueAxis' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenValueAxis>)>] () = inherit RadzenValueAxisBuilder<Radzen.Blazor.RadzenValueAxis>()

    /// Base class of RadzenChart series.
    type CartesianSeries'<'TItem> 
        /// Base class of RadzenChart series.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.CartesianSeries<_>>)>] () = inherit CartesianSeriesBuilder<Radzen.Blazor.CartesianSeries<'TItem>, 'TItem>()

    /// Renders area series in RadzenChart.
    type RadzenAreaSeries'<'TItem> 
        /// Renders area series in RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenAreaSeries<_>>)>] () = inherit RadzenAreaSeriesBuilder<Radzen.Blazor.RadzenAreaSeries<'TItem>, 'TItem>()

    /// Renders bar series in RadzenChart.
    type RadzenBarSeries'<'TItem> 
        /// Renders bar series in RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenBarSeries<_>>)>] () = inherit RadzenBarSeriesBuilder<Radzen.Blazor.RadzenBarSeries<'TItem>, 'TItem>()

    /// Renders column series in RadzenChart
    type RadzenColumnSeries'<'TItem> 
        /// Renders column series in RadzenChart
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenColumnSeries<_>>)>] () = inherit RadzenColumnSeriesBuilder<Radzen.Blazor.RadzenColumnSeries<'TItem>, 'TItem>()

    /// Renders line series in RadzenChart.
    type RadzenLineSeries'<'TItem> 
        /// Renders line series in RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenLineSeries<_>>)>] () = inherit RadzenLineSeriesBuilder<Radzen.Blazor.RadzenLineSeries<'TItem>, 'TItem>()

    /// Renders pie series in RadzenChart.
    type RadzenPieSeries'<'TItem> 
        /// Renders pie series in RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenPieSeries<_>>)>] () = inherit RadzenPieSeriesBuilder<Radzen.Blazor.RadzenPieSeries<'TItem>, 'TItem>()

    /// Renders donut series in RadzenChart.
    type RadzenDonutSeries'<'TItem> 
        /// Renders donut series in RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDonutSeries<_>>)>] () = inherit RadzenDonutSeriesBuilder<Radzen.Blazor.RadzenDonutSeries<'TItem>, 'TItem>()

    /// Renders stacked area series in RadzenChart.
    type RadzenStackedAreaSeries'<'TItem> 
        /// Renders stacked area series in RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenStackedAreaSeries<_>>)>] () = inherit RadzenStackedAreaSeriesBuilder<Radzen.Blazor.RadzenStackedAreaSeries<'TItem>, 'TItem>()

    /// Renders bar series in RadzenChart.
    type RadzenStackedBarSeries'<'TItem> 
        /// Renders bar series in RadzenChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenStackedBarSeries<_>>)>] () = inherit RadzenStackedBarSeriesBuilder<Radzen.Blazor.RadzenStackedBarSeries<'TItem>, 'TItem>()

    /// Renders column series in RadzenChart
    type RadzenStackedColumnSeries'<'TItem> 
        /// Renders column series in RadzenChart
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenStackedColumnSeries<_>>)>] () = inherit RadzenStackedColumnSeriesBuilder<Radzen.Blazor.RadzenStackedColumnSeries<'TItem>, 'TItem>()

    /// Represents the title configuration of a AxisBase.
    type RadzenAxisTitle' 
        /// Represents the title configuration of a AxisBase.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenAxisTitle>)>] () = inherit RadzenAxisTitleBuilder<Radzen.Blazor.RadzenAxisTitle>()

    /// Common configuration of RadzenBarSeries`1.
    type RadzenBarOptions' 
        /// Common configuration of RadzenBarSeries`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenBarOptions>)>] () = inherit RadzenBarOptionsBuilder<Radzen.Blazor.RadzenBarOptions>()

    /// Contains RadzenChart tooltip configuration.
    type RadzenChartTooltipOptions' 
        /// Contains RadzenChart tooltip configuration.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenChartTooltipOptions>)>] () = inherit RadzenChartTooltipOptionsBuilder<Radzen.Blazor.RadzenChartTooltipOptions>()

    /// Common configuration of RadzenColumnSeries`1.
    type RadzenColumnOptions' 
        /// Common configuration of RadzenColumnSeries`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenColumnOptions>)>] () = inherit RadzenColumnOptionsBuilder<Radzen.Blazor.RadzenColumnOptions>()

    /// Class RadzenLegend.
    type RadzenLegend' 
        /// Class RadzenLegend.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenLegend>)>] () = inherit RadzenLegendBuilder<Radzen.Blazor.RadzenLegend>()

    /// Class RadzenMarkers.
    type RadzenMarkers' 
        /// Class RadzenMarkers.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMarkers>)>] () = inherit RadzenMarkersBuilder<Radzen.Blazor.RadzenMarkers>()

    /// Displays a text label for the specified data item from the series.
    type RadzenSeriesAnnotation'<'TItem> 
        /// Displays a text label for the specified data item from the series.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSeriesAnnotation<_>>)>] () = inherit RadzenSeriesAnnotationBuilder<Radzen.Blazor.RadzenSeriesAnnotation<'TItem>, 'TItem>()

    /// Displays the series values as text labels.
    type RadzenSeriesDataLabels' 
        /// Displays the series values as text labels.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSeriesDataLabels>)>] () = inherit RadzenSeriesDataLabelsBuilder<Radzen.Blazor.RadzenSeriesDataLabels>()

    /// Base class that RadzenHtmlEditor color picker tools inherit from.
    type RadzenHtmlEditorButtonBase' 
        /// Base class that RadzenHtmlEditor color picker tools inherit from.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorButtonBase>)>] () = inherit RadzenHtmlEditorButtonBaseBuilder<Radzen.Blazor.RadzenHtmlEditorButtonBase>()

    /// Base class that RadzenHtmlEditor color picker tools inherit from.
    type RadzenHtmlEditorColorBase' 
        /// Base class that RadzenHtmlEditor color picker tools inherit from.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorColorBase>)>] () = inherit RadzenHtmlEditorColorBaseBuilder<Radzen.Blazor.RadzenHtmlEditorColorBase>()

    /// A RadzenHtmlEditor tool which sets the background color of the selection.
    type RadzenHtmlEditorBackground' 
        /// A RadzenHtmlEditor tool which sets the background color of the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorBackground>)>] () = inherit RadzenHtmlEditorBackgroundBuilder<Radzen.Blazor.RadzenHtmlEditorBackground>()

    /// A RadzenHtmlEditor tool which sets the text color of the selection.
    type RadzenHtmlEditorColor' 
        /// A RadzenHtmlEditor tool which sets the text color of the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorColor>)>] () = inherit RadzenHtmlEditorColorBuilder<Radzen.Blazor.RadzenHtmlEditorColor>()

    /// A RadzenHtmlEditor tool which centers the selection.
    type RadzenHtmlEditorAlignCenter' 
        /// A RadzenHtmlEditor tool which centers the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorAlignCenter>)>] () = inherit RadzenHtmlEditorAlignCenterBuilder<Radzen.Blazor.RadzenHtmlEditorAlignCenter>()

    /// A RadzenHtmlEditor tool which aligns the selection to the left.
    type RadzenHtmlEditorAlignLeft' 
        /// A RadzenHtmlEditor tool which aligns the selection to the left.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorAlignLeft>)>] () = inherit RadzenHtmlEditorAlignLeftBuilder<Radzen.Blazor.RadzenHtmlEditorAlignLeft>()

    /// A RadzenHtmlEditor tool which aligns the selection to the right.
    type RadzenHtmlEditorAlignRight' 
        /// A RadzenHtmlEditor tool which aligns the selection to the right.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorAlignRight>)>] () = inherit RadzenHtmlEditorAlignRightBuilder<Radzen.Blazor.RadzenHtmlEditorAlignRight>()

    /// A RadzenHtmlEditor tool which bolds the selection.
    type RadzenHtmlEditorBold' 
        /// A RadzenHtmlEditor tool which bolds the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorBold>)>] () = inherit RadzenHtmlEditorBoldBuilder<Radzen.Blazor.RadzenHtmlEditorBold>()

    /// A tool which inserts and uploads images in a RadzenHtmlEditor.
    type RadzenHtmlEditorImage' 
        /// A tool which inserts and uploads images in a RadzenHtmlEditor.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorImage>)>] () = inherit RadzenHtmlEditorImageBuilder<Radzen.Blazor.RadzenHtmlEditorImage>()

    /// A RadzenHtmlEditor tool which indents the selection.
    type RadzenHtmlEditorIndent' 
        /// A RadzenHtmlEditor tool which indents the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorIndent>)>] () = inherit RadzenHtmlEditorIndentBuilder<Radzen.Blazor.RadzenHtmlEditorIndent>()

    /// A RadzenHtmlEditor tool which makes the selection italic.
    type RadzenHtmlEditorItalic' 
        /// A RadzenHtmlEditor tool which makes the selection italic.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorItalic>)>] () = inherit RadzenHtmlEditorItalicBuilder<Radzen.Blazor.RadzenHtmlEditorItalic>()

    /// A RadzenHtmlEditor tool which justifies the selection.
    type RadzenHtmlEditorJustify' 
        /// A RadzenHtmlEditor tool which justifies the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorJustify>)>] () = inherit RadzenHtmlEditorJustifyBuilder<Radzen.Blazor.RadzenHtmlEditorJustify>()

    /// A tool which creates links from the selection of a RadzenHtmlEditor.
    type RadzenHtmlEditorLink' 
        /// A tool which creates links from the selection of a RadzenHtmlEditor.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorLink>)>] () = inherit RadzenHtmlEditorLinkBuilder<Radzen.Blazor.RadzenHtmlEditorLink>()

    /// A RadzenHtmlEditor tool which inserts an ordered list (ol).
    type RadzenHtmlEditorOrderedList' 
        /// A RadzenHtmlEditor tool which inserts an ordered list (ol).
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorOrderedList>)>] () = inherit RadzenHtmlEditorOrderedListBuilder<Radzen.Blazor.RadzenHtmlEditorOrderedList>()

    /// A RadzenHtmlEditor tool which outdents the selection.
    type RadzenHtmlEditorOutdent' 
        /// A RadzenHtmlEditor tool which outdents the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorOutdent>)>] () = inherit RadzenHtmlEditorOutdentBuilder<Radzen.Blazor.RadzenHtmlEditorOutdent>()

    /// A RadzenHtmlEditor tool which repeats the last undone command.
    type RadzenHtmlEditorRedo' 
        /// A RadzenHtmlEditor tool which repeats the last undone command.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorRedo>)>] () = inherit RadzenHtmlEditorRedoBuilder<Radzen.Blazor.RadzenHtmlEditorRedo>()

    /// A RadzenHtmlEditor tool which removes the styling of the selection.
    type RadzenHtmlEditorRemoveFormat' 
        /// A RadzenHtmlEditor tool which removes the styling of the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorRemoveFormat>)>] () = inherit RadzenHtmlEditorRemoveFormatBuilder<Radzen.Blazor.RadzenHtmlEditorRemoveFormat>()

    /// A tool which switches between rendered and source views in RadzenHtmlEditor.
    type RadzenHtmlEditorSource' 
        /// A tool which switches between rendered and source views in RadzenHtmlEditor.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorSource>)>] () = inherit RadzenHtmlEditorSourceBuilder<Radzen.Blazor.RadzenHtmlEditorSource>()

    /// A RadzenHtmlEditor tool which applies "strike through" styling to the selection.
    type RadzenHtmlEditorStrikeThrough' 
        /// A RadzenHtmlEditor tool which applies "strike through" styling to the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorStrikeThrough>)>] () = inherit RadzenHtmlEditorStrikeThroughBuilder<Radzen.Blazor.RadzenHtmlEditorStrikeThrough>()

    /// A RadzenHtmlEditor tool which formats the selection as subscript.
    type RadzenHtmlEditorSubscript' 
        /// A RadzenHtmlEditor tool which formats the selection as subscript.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorSubscript>)>] () = inherit RadzenHtmlEditorSubscriptBuilder<Radzen.Blazor.RadzenHtmlEditorSubscript>()

    /// A RadzenHtmlEditor tool which formats the selection as superscript.
    type RadzenHtmlEditorSuperscript' 
        /// A RadzenHtmlEditor tool which formats the selection as superscript.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorSuperscript>)>] () = inherit RadzenHtmlEditorSuperscriptBuilder<Radzen.Blazor.RadzenHtmlEditorSuperscript>()

    /// A RadzenHtmlEditor tool which underlines the selection.
    type RadzenHtmlEditorUnderline' 
        /// A RadzenHtmlEditor tool which underlines the selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorUnderline>)>] () = inherit RadzenHtmlEditorUnderlineBuilder<Radzen.Blazor.RadzenHtmlEditorUnderline>()

    /// A RadzenHtmlEditor tool which reverts the last edit operation.
    type RadzenHtmlEditorUndo' 
        /// A RadzenHtmlEditor tool which reverts the last edit operation.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorUndo>)>] () = inherit RadzenHtmlEditorUndoBuilder<Radzen.Blazor.RadzenHtmlEditorUndo>()

    /// A RadzenHtmlEditor tool which removes a link.
    type RadzenHtmlEditorUnlink' 
        /// A RadzenHtmlEditor tool which removes a link.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorUnlink>)>] () = inherit RadzenHtmlEditorUnlinkBuilder<Radzen.Blazor.RadzenHtmlEditorUnlink>()

    /// A RadzenHtmlEditor tool which inserts a bullet list (ul).
    type RadzenHtmlEditorUnorderedList' 
        /// A RadzenHtmlEditor tool which inserts a bullet list (ul).
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorUnorderedList>)>] () = inherit RadzenHtmlEditorUnorderedListBuilder<Radzen.Blazor.RadzenHtmlEditorUnorderedList>()

    /// A base class for RadzenScheduler`1 views.
    type SchedulerViewBase' 
        /// A base class for RadzenScheduler`1 views.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.SchedulerViewBase>)>] () = inherit SchedulerViewBaseBuilder<Radzen.Blazor.SchedulerViewBase>()

    /// A base class for RadzenScheduler`1 views.
    type SchedulerYearViewBase' 
        /// A base class for RadzenScheduler`1 views.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.SchedulerYearViewBase>)>] () = inherit SchedulerYearViewBaseBuilder<Radzen.Blazor.SchedulerYearViewBase>()

    /// Displays the appointments in a month day in RadzenScheduler`1
    type RadzenYearPlannerView' 
        /// Displays the appointments in a month day in RadzenScheduler`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenYearPlannerView>)>] () = inherit RadzenYearPlannerViewBuilder<Radzen.Blazor.RadzenYearPlannerView>()

    /// Displays the appointments in a month day in RadzenScheduler`1
    type RadzenYearTimelineView' 
        /// Displays the appointments in a month day in RadzenScheduler`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenYearTimelineView>)>] () = inherit RadzenYearTimelineViewBuilder<Radzen.Blazor.RadzenYearTimelineView>()

    /// Displays the appointments in a month day in RadzenScheduler`1
    type RadzenYearView' 
        /// Displays the appointments in a month day in RadzenScheduler`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenYearView>)>] () = inherit RadzenYearViewBuilder<Radzen.Blazor.RadzenYearView>()

    /// Displays the appointments in a single day in RadzenScheduler`1
    type RadzenDayView' 
        /// Displays the appointments in a single day in RadzenScheduler`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDayView>)>] () = inherit RadzenDayViewBuilder<Radzen.Blazor.RadzenDayView>()

    /// Displays the appointments in a month day in RadzenScheduler`1
    type RadzenMonthView' 
        /// Displays the appointments in a month day in RadzenScheduler`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMonthView>)>] () = inherit RadzenMonthViewBuilder<Radzen.Blazor.RadzenMonthView>()

    /// Displays the appointments in a multi-day view in RadzenScheduler`1
    type RadzenMultiDayView' 
        /// Displays the appointments in a multi-day view in RadzenScheduler`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMultiDayView>)>] () = inherit RadzenMultiDayViewBuilder<Radzen.Blazor.RadzenMultiDayView>()

    /// Displays the appointments in a week day in RadzenScheduler`1
    type RadzenWeekView' 
        /// Displays the appointments in a week day in RadzenScheduler`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenWeekView>)>] () = inherit RadzenWeekViewBuilder<Radzen.Blazor.RadzenWeekView>()

    /// RadzenArcGaugeScale component.
    type RadzenArcGaugeScale' 
        /// RadzenArcGaugeScale component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenArcGaugeScale>)>] () = inherit RadzenArcGaugeScaleBuilder<Radzen.Blazor.RadzenArcGaugeScale>()

    /// RadzenArcGaugeScaleValue component.
    type RadzenArcGaugeScaleValue' 
        /// RadzenArcGaugeScaleValue component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenArcGaugeScaleValue>)>] () = inherit RadzenArcGaugeScaleValueBuilder<Radzen.Blazor.RadzenArcGaugeScaleValue>()

    /// RadzenCarouselItem component.
    type RadzenCarouselItem' 
        /// RadzenCarouselItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenCarouselItem>)>] () = inherit RadzenCarouselItemBuilder<Radzen.Blazor.RadzenCarouselItem>()

    /// RadzenColorPickerItem component.
    type RadzenColorPickerItem' 
        /// RadzenColorPickerItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenColorPickerItem>)>] () = inherit RadzenColorPickerItemBuilder<Radzen.Blazor.RadzenColorPickerItem>()

    /// RadzenContextMenu component.
    type RadzenContextMenu' 
        /// RadzenContextMenu component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenContextMenu>)>] () = inherit RadzenContextMenuBuilder<Radzen.Blazor.RadzenContextMenu>()

    /// RadzenDataFilterProperty component.
    /// Must be placed inside a RadzenDataFilter`1
    type RadzenDataFilterProperty'<'TItem> 
        /// RadzenDataFilterProperty component.
        /// Must be placed inside a RadzenDataFilter`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataFilterProperty<_>>)>] () = inherit RadzenDataFilterPropertyBuilder<Radzen.Blazor.RadzenDataFilterProperty<'TItem>, 'TItem>()

    /// RadzenDataGridColumn component.
    /// Must be placed inside a RadzenDataGrid`1
    type RadzenDataGridColumn'<'TItem> 
        /// RadzenDataGridColumn component.
        /// Must be placed inside a RadzenDataGrid`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGridColumn<_>>)>] () = inherit RadzenDataGridColumnBuilder<Radzen.Blazor.RadzenDataGridColumn<'TItem>, 'TItem>()
    type RadzenDropDownDataGridColumn' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDropDownDataGridColumn>)>] () = inherit RadzenDropDownDataGridColumnBuilder<Radzen.Blazor.RadzenDropDownDataGridColumn>()

    /// RadzenDataGridRow.
    type RadzenDataGridRow'<'TItem> 
        /// RadzenDataGridRow.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGridRow<_>>)>] () = inherit RadzenDataGridRowBuilder<Radzen.Blazor.RadzenDataGridRow<'TItem>, 'TItem>()

    /// RadzenHtml component.
    type RadzenHtml' 
        /// RadzenHtml component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtml>)>] () = inherit RadzenHtmlBuilder<Radzen.Blazor.RadzenHtml>()

    /// Adds a custom color to RadzenHtmlEditorBackground.
    type RadzenHtmlEditorBackgroundItem' 
        /// Adds a custom color to RadzenHtmlEditorBackground.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorBackgroundItem>)>] () = inherit RadzenHtmlEditorBackgroundItemBuilder<Radzen.Blazor.RadzenHtmlEditorBackgroundItem>()

    /// Adds a custom color to RadzenHtmlEditorColor.
    type RadzenHtmlEditorColorItem' 
        /// Adds a custom color to RadzenHtmlEditorColor.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorColorItem>)>] () = inherit RadzenHtmlEditorColorItemBuilder<Radzen.Blazor.RadzenHtmlEditorColorItem>()

    /// A custom tool in RadzenHtmlEditor
    type RadzenHtmlEditorCustomTool' 
        /// A custom tool in RadzenHtmlEditor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorCustomTool>)>] () = inherit RadzenHtmlEditorCustomToolBuilder<Radzen.Blazor.RadzenHtmlEditorCustomTool>()

    /// A tool which changes the font of the selected text.
    type RadzenHtmlEditorFontName' 
        /// A tool which changes the font of the selected text.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorFontName>)>] () = inherit RadzenHtmlEditorFontNameBuilder<Radzen.Blazor.RadzenHtmlEditorFontName>()

    /// Adds a custom font to a RadzenHtmlEditorFontName.
    type RadzenHtmlEditorFontNameItem' 
        /// Adds a custom font to a RadzenHtmlEditorFontName.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorFontNameItem>)>] () = inherit RadzenHtmlEditorFontNameItemBuilder<Radzen.Blazor.RadzenHtmlEditorFontNameItem>()

    /// A tool which changes the font size of the selected text.
    type RadzenHtmlEditorFontSize' 
        /// A tool which changes the font size of the selected text.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorFontSize>)>] () = inherit RadzenHtmlEditorFontSizeBuilder<Radzen.Blazor.RadzenHtmlEditorFontSize>()

    /// A tool which changes the style of a the selected text by making it a heading or paragraph.
    type RadzenHtmlEditorFormatBlock' 
        /// A tool which changes the style of a the selected text by making it a heading or paragraph.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorFormatBlock>)>] () = inherit RadzenHtmlEditorFormatBlockBuilder<Radzen.Blazor.RadzenHtmlEditorFormatBlock>()

    /// A RadzenHtmlEditor visual separator.
    type RadzenHtmlEditorSeparator' 
        /// A RadzenHtmlEditor visual separator.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenHtmlEditorSeparator>)>] () = inherit RadzenHtmlEditorSeparatorBuilder<Radzen.Blazor.RadzenHtmlEditorSeparator>()

    /// RadzenMediaQuery fires its Change event when the media query specified via Query matches or not.
    type RadzenMediaQuery' 
        /// RadzenMediaQuery fires its Change event when the media query specified via Query matches or not.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenMediaQuery>)>] () = inherit RadzenMediaQueryBuilder<Radzen.Blazor.RadzenMediaQuery>()

    /// RadzenRadialGaugeScale component.
    type RadzenRadialGaugeScale' 
        /// RadzenRadialGaugeScale component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRadialGaugeScale>)>] () = inherit RadzenRadialGaugeScaleBuilder<Radzen.Blazor.RadzenRadialGaugeScale>()

    /// RadzenRadialGaugeScalePointer component.
    type RadzenRadialGaugeScalePointer' 
        /// RadzenRadialGaugeScalePointer component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRadialGaugeScalePointer>)>] () = inherit RadzenRadialGaugeScalePointerBuilder<Radzen.Blazor.RadzenRadialGaugeScalePointer>()

    /// RadzenRadialGaugeScaleRange component.
    type RadzenRadialGaugeScaleRange' 
        /// RadzenRadialGaugeScaleRange component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenRadialGaugeScaleRange>)>] () = inherit RadzenRadialGaugeScaleRangeBuilder<Radzen.Blazor.RadzenRadialGaugeScaleRange>()

    /// RadzenSSRSViewerParameter component.
    type RadzenSSRSViewerParameter' 
        /// RadzenSSRSViewerParameter component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenSSRSViewerParameter>)>] () = inherit RadzenSSRSViewerParameterBuilder<Radzen.Blazor.RadzenSSRSViewerParameter>()

    /// RadzenTabsItem component.
    type RadzenTabsItem' 
        /// RadzenTabsItem component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTabsItem>)>] () = inherit RadzenTabsItemBuilder<Radzen.Blazor.RadzenTabsItem>()

    /// Registers and manages the current theme. Requires ThemeService to be registered in the DI container.
    type RadzenTheme' 
        /// Registers and manages the current theme. Requires ThemeService to be registered in the DI container.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTheme>)>] () = inherit RadzenThemeBuilder<Radzen.Blazor.RadzenTheme>()

    /// Tick configuration of IChartAxis. 
    type RadzenTicks' 
        /// Tick configuration of IChartAxis. 
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTicks>)>] () = inherit RadzenTicksBuilder<Radzen.Blazor.RadzenTicks>()

    /// Represents a table of contents item.
    type RadzenTocItem' 
        /// Represents a table of contents item.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTocItem>)>] () = inherit RadzenTocItemBuilder<Radzen.Blazor.RadzenTocItem>()

    /// A component which is an item in a RadzenTree
    type RadzenTreeItem' 
        /// A component which is an item in a RadzenTree
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTreeItem>)>] () = inherit RadzenTreeItemBuilder<Radzen.Blazor.RadzenTreeItem>()

    /// Configures a level of nodes in a RadzenTree during data-binding.
    type RadzenTreeLevel' 
        /// Configures a level of nodes in a RadzenTree during data-binding.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTreeLevel>)>] () = inherit RadzenTreeLevelBuilder<Radzen.Blazor.RadzenTreeLevel>()
    type RadzenChartTooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenChartTooltip>)>] () = inherit RadzenChartTooltipBuilder<Radzen.Blazor.RadzenChartTooltip>()
    type RadzenComponents' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenComponents>)>] () = inherit RadzenComponentsBuilder<Radzen.Blazor.RadzenComponents>()
    type RadzenDataFilterItem'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataFilterItem<_>>)>] () = inherit RadzenDataFilterItemBuilder<Radzen.Blazor.RadzenDataFilterItem<'TItem>, 'TItem>()
    type RadzenDataGridFilterMenu'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGridFilterMenu<_>>)>] () = inherit RadzenDataGridFilterMenuBuilder<Radzen.Blazor.RadzenDataGridFilterMenu<'TItem>, 'TItem>()
    type RadzenDataGridFooterCell'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGridFooterCell<_>>)>] () = inherit RadzenDataGridFooterCellBuilder<Radzen.Blazor.RadzenDataGridFooterCell<'TItem>, 'TItem>()
    type RadzenDataGridGroupFooterCell'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGridGroupFooterCell<_>>)>] () = inherit RadzenDataGridGroupFooterCellBuilder<Radzen.Blazor.RadzenDataGridGroupFooterCell<'TItem>, 'TItem>()
    type RadzenDataGridGroupFooterRow'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGridGroupFooterRow<_>>)>] () = inherit RadzenDataGridGroupFooterRowBuilder<Radzen.Blazor.RadzenDataGridGroupFooterRow<'TItem>, 'TItem>()
    type RadzenDataGridGroupRow'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGridGroupRow<_>>)>] () = inherit RadzenDataGridGroupRowBuilder<Radzen.Blazor.RadzenDataGridGroupRow<'TItem>, 'TItem>()
    type RadzenDataGridHeaderCell'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataGridHeaderCell<_>>)>] () = inherit RadzenDataGridHeaderCellBuilder<Radzen.Blazor.RadzenDataGridHeaderCell<'TItem>, 'TItem>()
    type RadzenDataListRow'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDataListRow<_>>)>] () = inherit RadzenDataListRowBuilder<Radzen.Blazor.RadzenDataListRow<'TItem>, 'TItem>()
    type RadzenDialog' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDialog>)>] () = inherit RadzenDialogBuilder<Radzen.Blazor.RadzenDialog>()
    type RadzenDropDownItem'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenDropDownItem<_>>)>] () = inherit RadzenDropDownItemBuilder<Radzen.Blazor.RadzenDropDownItem<'TValue>, 'TValue>()
    type RadzenGridRow' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenGridRow>)>] () = inherit RadzenGridRowBuilder<Radzen.Blazor.RadzenGridRow>()
    type RadzenListBoxItem'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenListBoxItem<_>>)>] () = inherit RadzenListBoxItemBuilder<Radzen.Blazor.RadzenListBoxItem<'TValue>, 'TValue>()
    type RadzenNotification' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenNotification>)>] () = inherit RadzenNotificationBuilder<Radzen.Blazor.RadzenNotification>()
    type RadzenNotificationMessage' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenNotificationMessage>)>] () = inherit RadzenNotificationMessageBuilder<Radzen.Blazor.RadzenNotificationMessage>()
    type RadzenTooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenTooltip>)>] () = inherit RadzenTooltipBuilder<Radzen.Blazor.RadzenTooltip>()
    type RadzenUploadHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.RadzenUploadHeader>)>] () = inherit RadzenUploadHeaderBuilder<Radzen.Blazor.RadzenUploadHeader>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Radzen.Blazor.DslInternals.Blazor

    let RadzenRow'' = RadzenRow'()
    let RadzenStack'' = RadzenStack'()
    let RadzenAlert'' = RadzenAlert'()
    let RadzenBody'' = RadzenBody'()
    let RadzenBreadCrumb'' = RadzenBreadCrumb'()
    let RadzenCard'' = RadzenCard'()
    let RadzenCardGroup'' = RadzenCardGroup'()
    let RadzenColumn'' = RadzenColumn'()
    let RadzenContent'' = RadzenContent'()
    let RadzenContentContainer'' = RadzenContentContainer'()
    let RadzenDropZone''<'TItem> = RadzenDropZone'<'TItem>()
    let RadzenDropZoneContainer''<'TItem> = RadzenDropZoneContainer'<'TItem>()
    let RadzenFooter'' = RadzenFooter'()
    let RadzenHeader'' = RadzenHeader'()
    let RadzenImage'' = RadzenImage'()
    let RadzenLayout'' = RadzenLayout'()
    let RadzenMenu'' = RadzenMenu'()
    let RadzenPanel'' = RadzenPanel'()
    let RadzenPanelMenu'' = RadzenPanelMenu'()
    let RadzenProfileMenu'' = RadzenProfileMenu'()
    let RadzenSidebar'' = RadzenSidebar'()
    let RadzenSplitButton'' = RadzenSplitButton'()
    let RadzenTable'' = RadzenTable'()
    let RadzenTableBody'' = RadzenTableBody'()
    let RadzenTableCell'' = RadzenTableCell'()
    let RadzenTableHeader'' = RadzenTableHeader'()
    let RadzenTableHeaderCell'' = RadzenTableHeaderCell'()
    let RadzenTableHeaderRow'' = RadzenTableHeaderRow'()
    let RadzenTableRow'' = RadzenTableRow'()
    let RadzenMenuItemWrapper'' = RadzenMenuItemWrapper'()
    let ValidatorBase'' = ValidatorBase'()
    let RadzenCompareValidator'' = RadzenCompareValidator'()
    let RadzenCustomValidator'' = RadzenCustomValidator'()
    let RadzenDataAnnotationValidator'' = RadzenDataAnnotationValidator'()
    let RadzenEmailValidator'' = RadzenEmailValidator'()
    let RadzenLengthValidator'' = RadzenLengthValidator'()
    let RadzenNumericRangeValidator'' = RadzenNumericRangeValidator'()
    let RadzenRegexValidator'' = RadzenRegexValidator'()
    let RadzenRequiredValidator'' = RadzenRequiredValidator'()
    let RadzenProgressBar'' = RadzenProgressBar'()
    let RadzenProgressBarCircular'' = RadzenProgressBarCircular'()
    let RadzenChart'' = RadzenChart'()
    let RadzenSparkline'' = RadzenSparkline'()
    let RadzenButton'' = RadzenButton'()
    let RadzenToggleButton'' = RadzenToggleButton'()
    let GaugeBase'' = GaugeBase'()
    let RadzenArcGauge'' = RadzenArcGauge'()
    let RadzenRadialGauge'' = RadzenRadialGauge'()
    let RadzenDropDown''<'TValue> = RadzenDropDown'<'TValue>()
    let RadzenDropDownDataGrid''<'TValue> = RadzenDropDownDataGrid'<'TValue>()
    let RadzenListBox''<'TValue> = RadzenListBox'<'TValue>()
    let RadzenAutoComplete'' = RadzenAutoComplete'()
    let RadzenMask'' = RadzenMask'()
    let RadzenNumeric''<'TValue> = RadzenNumeric'<'TValue>()
    let RadzenPassword'' = RadzenPassword'()
    let RadzenTextBox'' = RadzenTextBox'()
    let RadzenCheckBox''<'TValue> = RadzenCheckBox'<'TValue>()
    let RadzenCheckBoxList''<'TValue> = RadzenCheckBoxList'<'TValue>()
    let RadzenColorPicker'' = RadzenColorPicker'()
    let RadzenFileInput''<'TValue> = RadzenFileInput'<'TValue>()
    let RadzenHtmlEditor'' = RadzenHtmlEditor'()
    let RadzenRadioButtonList''<'TValue> = RadzenRadioButtonList'<'TValue>()
    let RadzenRating'' = RadzenRating'()
    let RadzenSecurityCode'' = RadzenSecurityCode'()
    let RadzenSelectBar''<'TValue> = RadzenSelectBar'<'TValue>()
    let RadzenSlider''<'TValue> = RadzenSlider'<'TValue>()
    let RadzenSwitch'' = RadzenSwitch'()
    let RadzenTextArea'' = RadzenTextArea'()
    let RadzenDataGrid''<'TItem> = RadzenDataGrid'<'TItem>()
    let RadzenDataList''<'TItem> = RadzenDataList'<'TItem>()
    let RadzenAccordion'' = RadzenAccordion'()
    let RadzenAccordionItem'' = RadzenAccordionItem'()
    let RadzenAppearanceToggle'' = RadzenAppearanceToggle'()
    let RadzenBadge'' = RadzenBadge'()
    let RadzenBreadCrumbItem'' = RadzenBreadCrumbItem'()
    let RadzenCarousel'' = RadzenCarousel'()
    let RadzenCheckBoxListItem''<'TValue> = RadzenCheckBoxListItem'<'TValue>()
    let RadzenDataFilter''<'TItem> = RadzenDataFilter'<'TItem>()
    let RadzenDatePicker''<'TValue> = RadzenDatePicker'<'TValue>()
    let RadzenDropZoneItem''<'TItem> = RadzenDropZoneItem'<'TItem>()
    let RadzenFieldset'' = RadzenFieldset'()
    let RadzenFormField'' = RadzenFormField'()
    let RadzenGoogleMap'' = RadzenGoogleMap'()
    let RadzenGoogleMapMarker'' = RadzenGoogleMapMarker'()
    let RadzenGravatar'' = RadzenGravatar'()
    let RadzenHeading'' = RadzenHeading'()
    let RadzenIcon'' = RadzenIcon'()
    let RadzenLabel'' = RadzenLabel'()
    let RadzenLink'' = RadzenLink'()
    let RadzenLogin'' = RadzenLogin'()
    let RadzenMarkdown'' = RadzenMarkdown'()
    let RadzenMenuItem'' = RadzenMenuItem'()
    let RadzenPager'' = RadzenPager'()
    let RadzenPanelMenuItem'' = RadzenPanelMenuItem'()
    let RadzenPickList''<'TItem> = RadzenPickList'<'TItem>()
    let RadzenProfileMenuItem'' = RadzenProfileMenuItem'()
    let RadzenRadioButtonListItem''<'TValue> = RadzenRadioButtonListItem'<'TValue>()
    let RadzenScheduler''<'TItem> = RadzenScheduler'<'TItem>()
    let RadzenSelectBarItem'' = RadzenSelectBarItem'()
    let RadzenSidebarToggle'' = RadzenSidebarToggle'()
    let RadzenSpeechToTextButton'' = RadzenSpeechToTextButton'()
    let RadzenSplitButtonItem'' = RadzenSplitButtonItem'()
    let RadzenSplitter'' = RadzenSplitter'()
    let RadzenSplitterPane'' = RadzenSplitterPane'()
    let RadzenSSRSViewer'' = RadzenSSRSViewer'()
    let RadzenSteps'' = RadzenSteps'()
    let RadzenStepsItem'' = RadzenStepsItem'()
    let RadzenTabs'' = RadzenTabs'()
    let RadzenTemplateForm''<'TItem> = RadzenTemplateForm'<'TItem>()
    let RadzenText'' = RadzenText'()
    let RadzenTimeline'' = RadzenTimeline'()
    let RadzenTimelineItem'' = RadzenTimelineItem'()
    let RadzenTimeSpanPicker''<'TValue> = RadzenTimeSpanPicker'<'TValue>()
    let RadzenToc'' = RadzenToc'()
    let RadzenTree'' = RadzenTree'()
    let RadzenUpload'' = RadzenUpload'()
    let RadzenChartComponentBase'' = RadzenChartComponentBase'()
    let RadzenGridLines'' = RadzenGridLines'()
    let RadzenSeriesValueLine'' = RadzenSeriesValueLine'()
    let RadzenSeriesMeanLine'' = RadzenSeriesMeanLine'()
    let RadzenSeriesMedianLine'' = RadzenSeriesMedianLine'()
    let RadzenSeriesModeLine'' = RadzenSeriesModeLine'()
    let RadzenSeriesTrendLine'' = RadzenSeriesTrendLine'()
    let AxisBase'' = AxisBase'()
    let RadzenCategoryAxis'' = RadzenCategoryAxis'()
    let RadzenValueAxis'' = RadzenValueAxis'()
    let CartesianSeries''<'TItem> = CartesianSeries'<'TItem>()
    let RadzenAreaSeries''<'TItem> = RadzenAreaSeries'<'TItem>()
    let RadzenBarSeries''<'TItem> = RadzenBarSeries'<'TItem>()
    let RadzenColumnSeries''<'TItem> = RadzenColumnSeries'<'TItem>()
    let RadzenLineSeries''<'TItem> = RadzenLineSeries'<'TItem>()
    let RadzenPieSeries''<'TItem> = RadzenPieSeries'<'TItem>()
    let RadzenDonutSeries''<'TItem> = RadzenDonutSeries'<'TItem>()
    let RadzenStackedAreaSeries''<'TItem> = RadzenStackedAreaSeries'<'TItem>()
    let RadzenStackedBarSeries''<'TItem> = RadzenStackedBarSeries'<'TItem>()
    let RadzenStackedColumnSeries''<'TItem> = RadzenStackedColumnSeries'<'TItem>()
    let RadzenAxisTitle'' = RadzenAxisTitle'()
    let RadzenBarOptions'' = RadzenBarOptions'()
    let RadzenChartTooltipOptions'' = RadzenChartTooltipOptions'()
    let RadzenColumnOptions'' = RadzenColumnOptions'()
    let RadzenLegend'' = RadzenLegend'()
    let RadzenMarkers'' = RadzenMarkers'()
    let RadzenSeriesAnnotation''<'TItem> = RadzenSeriesAnnotation'<'TItem>()
    let RadzenSeriesDataLabels'' = RadzenSeriesDataLabels'()
    let RadzenHtmlEditorButtonBase'' = RadzenHtmlEditorButtonBase'()
    let RadzenHtmlEditorColorBase'' = RadzenHtmlEditorColorBase'()
    let RadzenHtmlEditorBackground'' = RadzenHtmlEditorBackground'()
    let RadzenHtmlEditorColor'' = RadzenHtmlEditorColor'()
    let RadzenHtmlEditorAlignCenter'' = RadzenHtmlEditorAlignCenter'()
    let RadzenHtmlEditorAlignLeft'' = RadzenHtmlEditorAlignLeft'()
    let RadzenHtmlEditorAlignRight'' = RadzenHtmlEditorAlignRight'()
    let RadzenHtmlEditorBold'' = RadzenHtmlEditorBold'()
    let RadzenHtmlEditorImage'' = RadzenHtmlEditorImage'()
    let RadzenHtmlEditorIndent'' = RadzenHtmlEditorIndent'()
    let RadzenHtmlEditorItalic'' = RadzenHtmlEditorItalic'()
    let RadzenHtmlEditorJustify'' = RadzenHtmlEditorJustify'()
    let RadzenHtmlEditorLink'' = RadzenHtmlEditorLink'()
    let RadzenHtmlEditorOrderedList'' = RadzenHtmlEditorOrderedList'()
    let RadzenHtmlEditorOutdent'' = RadzenHtmlEditorOutdent'()
    let RadzenHtmlEditorRedo'' = RadzenHtmlEditorRedo'()
    let RadzenHtmlEditorRemoveFormat'' = RadzenHtmlEditorRemoveFormat'()
    let RadzenHtmlEditorSource'' = RadzenHtmlEditorSource'()
    let RadzenHtmlEditorStrikeThrough'' = RadzenHtmlEditorStrikeThrough'()
    let RadzenHtmlEditorSubscript'' = RadzenHtmlEditorSubscript'()
    let RadzenHtmlEditorSuperscript'' = RadzenHtmlEditorSuperscript'()
    let RadzenHtmlEditorUnderline'' = RadzenHtmlEditorUnderline'()
    let RadzenHtmlEditorUndo'' = RadzenHtmlEditorUndo'()
    let RadzenHtmlEditorUnlink'' = RadzenHtmlEditorUnlink'()
    let RadzenHtmlEditorUnorderedList'' = RadzenHtmlEditorUnorderedList'()
    let SchedulerViewBase'' = SchedulerViewBase'()
    let SchedulerYearViewBase'' = SchedulerYearViewBase'()
    let RadzenYearPlannerView'' = RadzenYearPlannerView'()
    let RadzenYearTimelineView'' = RadzenYearTimelineView'()
    let RadzenYearView'' = RadzenYearView'()
    let RadzenDayView'' = RadzenDayView'()
    let RadzenMonthView'' = RadzenMonthView'()
    let RadzenMultiDayView'' = RadzenMultiDayView'()
    let RadzenWeekView'' = RadzenWeekView'()
    let RadzenArcGaugeScale'' = RadzenArcGaugeScale'()
    let RadzenArcGaugeScaleValue'' = RadzenArcGaugeScaleValue'()
    let RadzenCarouselItem'' = RadzenCarouselItem'()
    let RadzenColorPickerItem'' = RadzenColorPickerItem'()
    let RadzenContextMenu'' = RadzenContextMenu'()
    let RadzenDataFilterProperty''<'TItem> = RadzenDataFilterProperty'<'TItem>()
    let RadzenDataGridColumn''<'TItem> = RadzenDataGridColumn'<'TItem>()
    let RadzenDropDownDataGridColumn'' = RadzenDropDownDataGridColumn'()
    let RadzenDataGridRow''<'TItem> = RadzenDataGridRow'<'TItem>()
    let RadzenHtml'' = RadzenHtml'()
    let RadzenHtmlEditorBackgroundItem'' = RadzenHtmlEditorBackgroundItem'()
    let RadzenHtmlEditorColorItem'' = RadzenHtmlEditorColorItem'()
    let RadzenHtmlEditorCustomTool'' = RadzenHtmlEditorCustomTool'()
    let RadzenHtmlEditorFontName'' = RadzenHtmlEditorFontName'()
    let RadzenHtmlEditorFontNameItem'' = RadzenHtmlEditorFontNameItem'()
    let RadzenHtmlEditorFontSize'' = RadzenHtmlEditorFontSize'()
    let RadzenHtmlEditorFormatBlock'' = RadzenHtmlEditorFormatBlock'()
    let RadzenHtmlEditorSeparator'' = RadzenHtmlEditorSeparator'()
    let RadzenMediaQuery'' = RadzenMediaQuery'()
    let RadzenRadialGaugeScale'' = RadzenRadialGaugeScale'()
    let RadzenRadialGaugeScalePointer'' = RadzenRadialGaugeScalePointer'()
    let RadzenRadialGaugeScaleRange'' = RadzenRadialGaugeScaleRange'()
    let RadzenSSRSViewerParameter'' = RadzenSSRSViewerParameter'()
    let RadzenTabsItem'' = RadzenTabsItem'()
    let RadzenTheme'' = RadzenTheme'()
    let RadzenTicks'' = RadzenTicks'()
    let RadzenTocItem'' = RadzenTocItem'()
    let RadzenTreeItem'' = RadzenTreeItem'()
    let RadzenTreeLevel'' = RadzenTreeLevel'()
    let RadzenChartTooltip'' = RadzenChartTooltip'()
    let RadzenComponents'' = RadzenComponents'()
    let RadzenDataFilterItem''<'TItem> = RadzenDataFilterItem'<'TItem>()
    let RadzenDataGridFilterMenu''<'TItem> = RadzenDataGridFilterMenu'<'TItem>()
    let RadzenDataGridFooterCell''<'TItem> = RadzenDataGridFooterCell'<'TItem>()
    let RadzenDataGridGroupFooterCell''<'TItem> = RadzenDataGridGroupFooterCell'<'TItem>()
    let RadzenDataGridGroupFooterRow''<'TItem> = RadzenDataGridGroupFooterRow'<'TItem>()
    let RadzenDataGridGroupRow''<'TItem> = RadzenDataGridGroupRow'<'TItem>()
    let RadzenDataGridHeaderCell''<'TItem> = RadzenDataGridHeaderCell'<'TItem>()
    let RadzenDataListRow''<'TItem> = RadzenDataListRow'<'TItem>()
    let RadzenDialog'' = RadzenDialog'()
    let RadzenDropDownItem''<'TValue> = RadzenDropDownItem'<'TValue>()
    let RadzenGridRow'' = RadzenGridRow'()
    let RadzenListBoxItem''<'TValue> = RadzenListBoxItem'<'TValue>()
    let RadzenNotification'' = RadzenNotification'()
    let RadzenNotificationMessage'' = RadzenNotificationMessage'()
    let RadzenTooltip'' = RadzenTooltip'()
    let RadzenUploadHeader'' = RadzenUploadHeader'()
            
namespace Radzen.Blazor.Blazor.Rendering

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Radzen.Blazor.DslInternals.Blazor.Rendering

    type Draggable' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Draggable>)>] () = inherit DraggableBuilder<Radzen.Blazor.Rendering.Draggable>()
    type EditorDropDown' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.EditorDropDown>)>] () = inherit EditorDropDownBuilder<Radzen.Blazor.Rendering.EditorDropDown>()
    type Popup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Popup>)>] () = inherit PopupBuilder<Radzen.Blazor.Rendering.Popup>()
    type CategoryAxis' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.CategoryAxis>)>] () = inherit CategoryAxisBuilder<Radzen.Blazor.Rendering.CategoryAxis>()
    type ClipPath' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.ClipPath>)>] () = inherit ClipPathBuilder<Radzen.Blazor.Rendering.ClipPath>()
    type ValueAxis' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.ValueAxis>)>] () = inherit ValueAxisBuilder<Radzen.Blazor.Rendering.ValueAxis>()
    type ValueAxisTitle' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.ValueAxisTitle>)>] () = inherit ValueAxisTitleBuilder<Radzen.Blazor.Rendering.ValueAxisTitle>()

    /// Base component for all chart ticks. 
    type Tick' 
        /// Base component for all chart ticks. 
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Tick>)>] () = inherit TickBuilder<Radzen.Blazor.Rendering.Tick>()
    type CategoryAxisTick' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.CategoryAxisTick>)>] () = inherit CategoryAxisTickBuilder<Radzen.Blazor.Rendering.CategoryAxisTick>()
    type ValueAxisTick' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.ValueAxisTick>)>] () = inherit ValueAxisTickBuilder<Radzen.Blazor.Rendering.ValueAxisTick>()

    /// A base class for MonthView DayView WeekView YearPlannerView YearTimelineView views.
    type DropableViewBase' 
        /// A base class for MonthView DayView WeekView YearPlannerView YearTimelineView views.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.DropableViewBase>)>] () = inherit DropableViewBaseBuilder<Radzen.Blazor.Rendering.DropableViewBase>()
    type DayView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.DayView>)>] () = inherit DayViewBuilder<Radzen.Blazor.Rendering.DayView>()
    type MonthView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.MonthView>)>] () = inherit MonthViewBuilder<Radzen.Blazor.Rendering.MonthView>()
    type WeekView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.WeekView>)>] () = inherit WeekViewBuilder<Radzen.Blazor.Rendering.WeekView>()
    type YearPlannerView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.YearPlannerView>)>] () = inherit YearPlannerViewBuilder<Radzen.Blazor.Rendering.YearPlannerView>()
    type YearTimelineView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.YearTimelineView>)>] () = inherit YearTimelineViewBuilder<Radzen.Blazor.Rendering.YearTimelineView>()
    type Appointment' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Appointment>)>] () = inherit AppointmentBuilder<Radzen.Blazor.Rendering.Appointment>()
    type CategoryAxisTitle' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.CategoryAxisTitle>)>] () = inherit CategoryAxisTitleBuilder<Radzen.Blazor.Rendering.CategoryAxisTitle>()
    type ChartSharedTooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.ChartSharedTooltip>)>] () = inherit ChartSharedTooltipBuilder<Radzen.Blazor.Rendering.ChartSharedTooltip>()
    type ChartSharedTooltipItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.ChartSharedTooltipItem>)>] () = inherit ChartSharedTooltipItemBuilder<Radzen.Blazor.Rendering.ChartSharedTooltipItem>()
    type ChartTooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.ChartTooltip>)>] () = inherit ChartTooltipBuilder<Radzen.Blazor.Rendering.ChartTooltip>()
    type DaySlotEvents' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.DaySlotEvents>)>] () = inherit DaySlotEventsBuilder<Radzen.Blazor.Rendering.DaySlotEvents>()
    type DialogContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.DialogContainer>)>] () = inherit DialogContainerBuilder<Radzen.Blazor.Rendering.DialogContainer>()
    type EditorButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.EditorButton>)>] () = inherit EditorButtonBuilder<Radzen.Blazor.Rendering.EditorButton>()
    type EditorColorPicker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.EditorColorPicker>)>] () = inherit EditorColorPickerBuilder<Radzen.Blazor.Rendering.EditorColorPicker>()
    type EditorDropDownItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.EditorDropDownItem>)>] () = inherit EditorDropDownItemBuilder<Radzen.Blazor.Rendering.EditorDropDownItem>()
    type GaugeBand' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.GaugeBand>)>] () = inherit GaugeBandBuilder<Radzen.Blazor.Rendering.GaugeBand>()
    type GaugePointer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.GaugePointer>)>] () = inherit GaugePointerBuilder<Radzen.Blazor.Rendering.GaugePointer>()
    type GaugeScale' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.GaugeScale>)>] () = inherit GaugeScaleBuilder<Radzen.Blazor.Rendering.GaugeScale>()
    type Hours' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Hours>)>] () = inherit HoursBuilder<Radzen.Blazor.Rendering.Hours>()
    type Legend' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Legend>)>] () = inherit LegendBuilder<Radzen.Blazor.Rendering.Legend>()
    type LegendItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.LegendItem>)>] () = inherit LegendItemBuilder<Radzen.Blazor.Rendering.LegendItem>()
    type Line' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Line>)>] () = inherit LineBuilder<Radzen.Blazor.Rendering.Line>()
    type Marker' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Marker>)>] () = inherit MarkerBuilder<Radzen.Blazor.Rendering.Marker>()
    type Markers'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Markers<_>>)>] () = inherit MarkersBuilder<Radzen.Blazor.Rendering.Markers<'TItem>, 'TItem>()
    type Path' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Path>)>] () = inherit PathBuilder<Radzen.Blazor.Rendering.Path>()
    type Text' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.Text>)>] () = inherit TextBuilder<Radzen.Blazor.Rendering.Text>()
    type YearView' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Radzen.Blazor.Rendering.YearView>)>] () = inherit YearViewBuilder<Radzen.Blazor.Rendering.YearView>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Radzen.Blazor.DslInternals.Blazor.Rendering

    let Draggable'' = Draggable'()
    let EditorDropDown'' = EditorDropDown'()
    let Popup'' = Popup'()
    let CategoryAxis'' = CategoryAxis'()
    let ClipPath'' = ClipPath'()
    let ValueAxis'' = ValueAxis'()
    let ValueAxisTitle'' = ValueAxisTitle'()
    let Tick'' = Tick'()
    let CategoryAxisTick'' = CategoryAxisTick'()
    let ValueAxisTick'' = ValueAxisTick'()
    let DropableViewBase'' = DropableViewBase'()
    let DayView'' = DayView'()
    let MonthView'' = MonthView'()
    let WeekView'' = WeekView'()
    let YearPlannerView'' = YearPlannerView'()
    let YearTimelineView'' = YearTimelineView'()
    let Appointment'' = Appointment'()
    let CategoryAxisTitle'' = CategoryAxisTitle'()
    let ChartSharedTooltip'' = ChartSharedTooltip'()
    let ChartSharedTooltipItem'' = ChartSharedTooltipItem'()
    let ChartTooltip'' = ChartTooltip'()
    let DaySlotEvents'' = DaySlotEvents'()
    let DialogContainer'' = DialogContainer'()
    let EditorButton'' = EditorButton'()
    let EditorColorPicker'' = EditorColorPicker'()
    let EditorDropDownItem'' = EditorDropDownItem'()
    let GaugeBand'' = GaugeBand'()
    let GaugePointer'' = GaugePointer'()
    let GaugeScale'' = GaugeScale'()
    let Hours'' = Hours'()
    let Legend'' = Legend'()
    let LegendItem'' = LegendItem'()
    let Line'' = Line'()
    let Marker'' = Marker'()
    let Markers''<'TItem> = Markers'<'TItem>()
    let Path'' = Path'()
    let Text'' = Text'()
    let YearView'' = YearView'()
            