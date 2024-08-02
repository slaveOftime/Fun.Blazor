namespace rec AntDesign.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type AntComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("RefBack")>] member inline _.RefBack ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ForwardRef) = render ==> ("RefBack" => x)

type AntDomComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Id")>] member inline _.Id ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member inline _.Styles ([<InlineIfLambda>] render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x

            
namespace rec AntDesign.DslInternals.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type OverlayTriggerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("BoundaryAdjustMode")>] member inline _.BoundaryAdjustMode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TriggerBoundaryAdjustMode) = render ==> ("BoundaryAdjustMode" => x)
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member inline _.ComplexAutoCloseAndVisible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ComplexAutoCloseAndVisible" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("HiddenMode")>] member inline _.HiddenMode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HiddenMode" => (defaultArg x true))
    [<CustomOperation("InlineFlexMode")>] member inline _.InlineFlexMode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("InlineFlexMode" => (defaultArg x true))
    [<CustomOperation("IsButton")>] member inline _.IsButton ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsButton" => (defaultArg x true))
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("OnMaskClick")>] member inline _.OnMaskClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnMaskClick", fn)
    [<CustomOperation("OnMaskClick")>] member inline _.OnMaskClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnMaskClick", fn)
    [<CustomOperation("OnMouseEnter")>] member inline _.OnMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnMouseEnter", fn)
    [<CustomOperation("OnMouseEnter")>] member inline _.OnMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnMouseEnter", fn)
    [<CustomOperation("OnMouseLeave")>] member inline _.OnMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnMouseLeave", fn)
    [<CustomOperation("OnMouseLeave")>] member inline _.OnMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnMouseLeave", fn)
    [<CustomOperation("OnOverlayHiding")>] member inline _.OnOverlayHiding ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnOverlayHiding", fn)
    [<CustomOperation("OnOverlayHiding")>] member inline _.OnOverlayHiding ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnOverlayHiding", fn)
    [<CustomOperation("OnVisibleChange")>] member inline _.OnVisibleChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnVisibleChange", fn)
    [<CustomOperation("OnVisibleChange")>] member inline _.OnVisibleChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnVisibleChange", fn)
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Overlay", fragment)
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Overlay", fragment { yield! fragments })
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Overlay", html.text x)
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Overlay", html.text x)
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Overlay", html.text x)
    [<CustomOperation("OverlayClassName")>] member inline _.OverlayClassName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OverlayClassName" => x)
    [<CustomOperation("OverlayEnterCls")>] member inline _.OverlayEnterCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OverlayEnterCls" => x)
    [<CustomOperation("OverlayHiddenCls")>] member inline _.OverlayHiddenCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OverlayHiddenCls" => x)
    [<CustomOperation("OverlayLeaveCls")>] member inline _.OverlayLeaveCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OverlayLeaveCls" => x)
    [<CustomOperation("OverlayStyle")>] member inline _.OverlayStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OverlayStyle" => x)
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Placement) = render ==> ("Placement" => x)
    [<CustomOperation("PlacementCls")>] member inline _.PlacementCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PlacementCls" => x)
    [<CustomOperation("PopupContainerSelector")>] member inline _.PopupContainerSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupContainerSelector" => x)
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Trigger[]) = render ==> ("Trigger" => x)
    [<CustomOperation("TriggerCls")>] member inline _.TriggerCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TriggerCls" => x)
    [<CustomOperation("TriggerReference")>] member inline _.TriggerReference ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.ElementReference) = render ==> ("TriggerReference" => x)
    [<CustomOperation("Unbound")>] member inline _.Unbound ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.ForwardRef -> NodeRenderFragment) = render ==> html.renderFragment("Unbound", fn)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))

            
namespace rec AntDesign.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type DropdownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Arrow")>] member inline _.Arrow ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Arrow" => (defaultArg x true))
    [<CustomOperation("ArrowPointAtCenter")>] member inline _.ArrowPointAtCenter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ArrowPointAtCenter" => (defaultArg x true))

type DropdownButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DropdownBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Block" => (defaultArg x true))
    [<CustomOperation("ButtonsRender")>] member inline _.ButtonsRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ButtonsRender" => (System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("ButtonsClass")>] member inline _.ButtonsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = render ==> ("ButtonsClass" => x)
    [<CustomOperation("ButtonsStyle")>] member inline _.ButtonsStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = render ==> ("ButtonsStyle" => x)
    [<CustomOperation("Danger")>] member inline _.Danger ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Danger" => (defaultArg x true))
    [<CustomOperation("Ghost")>] member inline _.Ghost ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Ghost" => (defaultArg x true))
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = render ==> ("Type" => x)

type PopconfirmBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("CancelText")>] member inline _.CancelText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelText" => x)
    [<CustomOperation("OkText")>] member inline _.OkText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OkText" => x)
    [<CustomOperation("OkType")>] member inline _.OkType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OkType" => x)
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.PopconfirmLocale) = render ==> ("Locale" => x)
    [<CustomOperation("OkButtonProps")>] member inline _.OkButtonProps ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ButtonProps) = render ==> ("OkButtonProps" => x)
    [<CustomOperation("CancelButtonProps")>] member inline _.CancelButtonProps ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ButtonProps) = render ==> ("CancelButtonProps" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("IconTemplate", fragment)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("IconTemplate", fragment { yield! fragments })
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("IconTemplate", html.text x)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("IconTemplate", html.text x)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("IconTemplate", html.text x)
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnCancel", fn)
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCancel", fn)
    [<CustomOperation("OnConfirm")>] member inline _.OnConfirm ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnConfirm", fn)
    [<CustomOperation("OnConfirm")>] member inline _.OnConfirm ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnConfirm", fn)
    [<CustomOperation("ArrowPointAtCenter")>] member inline _.ArrowPointAtCenter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ArrowPointAtCenter" => (defaultArg x true))
    [<CustomOperation("MouseEnterDelay")>] member inline _.MouseEnterDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MouseEnterDelay" => x)
    [<CustomOperation("MouseLeaveDelay")>] member inline _.MouseLeaveDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MouseLeaveDelay" => x)

type PopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Content" => x)
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ContentTemplate", fragment)
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ContentTemplate", fragment { yield! fragments })
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ContentTemplate", html.text x)
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ContentTemplate", html.text x)
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ContentTemplate", html.text x)
    [<CustomOperation("ArrowPointAtCenter")>] member inline _.ArrowPointAtCenter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ArrowPointAtCenter" => (defaultArg x true))
    [<CustomOperation("MouseEnterDelay")>] member inline _.MouseEnterDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MouseEnterDelay" => x)
    [<CustomOperation("MouseLeaveDelay")>] member inline _.MouseLeaveDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MouseLeaveDelay" => x)

type TooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("ArrowPointAtCenter")>] member inline _.ArrowPointAtCenter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ArrowPointAtCenter" => (defaultArg x true))
    [<CustomOperation("MouseEnterDelay")>] member inline _.MouseEnterDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MouseEnterDelay" => x)
    [<CustomOperation("MouseLeaveDelay")>] member inline _.MouseLeaveDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("MouseLeaveDelay" => x)
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TabIndex" => x)

            
namespace rec AntDesign.DslInternals.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type SubMenuTriggerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    [<CustomOperation("TriggerClass")>] member inline _.TriggerClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TriggerClass" => x)

            
namespace rec AntDesign.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type ColumnBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("RowSpan")>] member inline _.RowSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowSpan" => x)
    [<CustomOperation("ColSpan")>] member inline _.ColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ColSpan" => x)
    [<CustomOperation("HeaderColSpan")>] member inline _.HeaderColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HeaderColSpan" => x)
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fixed" => x)
    [<CustomOperation("Ellipsis")>] member inline _.Ellipsis ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Ellipsis" => (defaultArg x true))
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hidden" => (defaultArg x true))
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ColumnAlign) = render ==> ("Align" => x)

type ActionColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CellRender")>] member inline _.CellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.CellData -> NodeRenderFragment) = render ==> html.renderFragment("CellRender", fn)

type ColumnDefinitionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ActionColumnBuilder<'FunBlazorGeneric>()


type TableCellBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ActionColumnBuilder<'FunBlazorGeneric>()


type SimpleTableHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ActionColumnBuilder<'FunBlazorGeneric>()


type ColumnBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TData -> unit) = render ==> html.callback("FieldChanged", fn)
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TData -> Task<unit>) = render ==> html.callbackTask("FieldChanged", fn)
    [<CustomOperation("FieldExpression")>] member inline _.FieldExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TData>>) = render ==> ("FieldExpression" => x)
    [<CustomOperation("FilterDropdown")>] member inline _.FilterDropdown ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FilterDropdown", fragment)
    [<CustomOperation("FilterDropdown")>] member inline _.FilterDropdown ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FilterDropdown", fragment { yield! fragments })
    [<CustomOperation("FilterDropdown")>] member inline _.FilterDropdown ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FilterDropdown", html.text x)
    [<CustomOperation("FilterDropdown")>] member inline _.FilterDropdown ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FilterDropdown", html.text x)
    [<CustomOperation("FilterDropdown")>] member inline _.FilterDropdown ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FilterDropdown", html.text x)
    [<CustomOperation("Field")>] member inline _.Field ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TData) = render ==> ("Field" => x)
    [<CustomOperation("Field'")>] member inline _.Field' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TData * ('TData -> unit)) = render ==> html.bind("Field", valueFn)
    [<CustomOperation("DataIndex")>] member inline _.DataIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataIndex" => x)
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Sortable" => (defaultArg x true))
    [<CustomOperation("SorterCompare")>] member inline _.SorterCompare ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SorterCompare" => (System.Func<'TData, 'TData, System.Int32>fn))
    [<CustomOperation("SorterMultiple")>] member inline _.SorterMultiple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SorterMultiple" => x)
    [<CustomOperation("ShowSorterTooltip")>] member inline _.ShowSorterTooltip ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSorterTooltip" => (defaultArg x true))
    [<CustomOperation("SortDirections")>] member inline _.SortDirections ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.SortDirection[]) = render ==> ("SortDirections" => x)
    [<CustomOperation("DefaultSortOrder")>] member inline _.DefaultSortOrder ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.SortDirection) = render ==> ("DefaultSortOrder" => x)
    [<CustomOperation("OnCell")>] member inline _.OnCell ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnCell" => (System.Func<AntDesign.TableModels.CellData, System.Collections.Generic.Dictionary<System.String, System.Object>>fn))
    [<CustomOperation("OnHeaderCell")>] member inline _.OnHeaderCell ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnHeaderCell" => (System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>fn))
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Filterable" => (defaultArg x true))
    [<CustomOperation("Grouping")>] member inline _.Grouping ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Grouping" => (defaultArg x true))
    [<CustomOperation("GroupBy")>] member inline _.GroupBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupBy" => (System.Func<'TData, System.Object>fn))
    [<CustomOperation("Filters")>] member inline _.Filters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = render ==> ("Filters" => x)
    [<CustomOperation("DefaultFilters")>] member inline _.DefaultFilters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter>) = render ==> ("DefaultFilters" => x)
    [<CustomOperation("FilterMultiple")>] member inline _.FilterMultiple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FilterMultiple" => (defaultArg x true))
    [<CustomOperation("FieldFilterType")>] member inline _.FieldFilterType ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Filters.IFieldFilterType) = render ==> ("FieldFilterType" => x)
    [<CustomOperation("OnFilter")>] member inline _.OnFilter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = render ==> ("OnFilter" => x)
    [<CustomOperation("Filtered")>] member inline _.Filtered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Filtered" => (defaultArg x true))
    [<CustomOperation("CellRender")>] member inline _.CellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.CellData<'TData> -> NodeRenderFragment) = render ==> html.renderFragment("CellRender", fn)

type PropertyColumnBuilder<'FunBlazorGeneric, 'TItem, 'TProp when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBuilder<'FunBlazorGeneric, 'TProp>()
    [<CustomOperation("Property")>] member inline _.Property ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TItem, 'TProp>>) = render ==> ("Property" => x)

type TableHeaderBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBuilder<'FunBlazorGeneric, 'TData>()


type SelectionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Key")>] member inline _.Key ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Key" => x)
    [<CustomOperation("CheckStrictly")>] member inline _.CheckStrictly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CheckStrictly" => (defaultArg x true))
    [<CustomOperation("CellRender")>] member inline _.CellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.CellData -> NodeRenderFragment) = render ==> html.renderFragment("CellRender", fn)

type SummaryCellBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CellRender")>] member inline _.CellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.CellData -> NodeRenderFragment) = render ==> html.renderFragment("CellRender", fn)

            
namespace rec AntDesign.DslInternals.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type PickerPanelBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnSelect" => (System.Action<System.DateTime, System.Int32>fn))
    [<CustomOperation("PickerIndex")>] member inline _.PickerIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PickerIndex" => x)

            
namespace rec AntDesign.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.PickerPanelBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("Picker")>] member inline _.Picker ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Picker" => x)
    [<CustomOperation("IsRange")>] member inline _.IsRange ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsRange" => (defaultArg x true))
    [<CustomOperation("IsCalendar")>] member inline _.IsCalendar ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsCalendar" => (defaultArg x true))
    [<CustomOperation("IsShowHeader")>] member inline _.IsShowHeader ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsShowHeader" => (defaultArg x true))
    [<CustomOperation("IsShowTime")>] member inline _.IsShowTime ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsShowTime" => (defaultArg x true))
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.DatePickerLocale) = render ==> ("Locale" => x)
    [<CustomOperation("CultureInfo")>] member inline _.CultureInfo ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("CultureInfo" => x)
    [<CustomOperation("ClosePanel")>] member inline _.ClosePanel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Action) = render ==> ("ClosePanel" => x)
    [<CustomOperation("ChangePickerValue")>] member inline _.ChangePickerValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ChangePickerValue" => (System.Action<System.DateTime, System.Nullable<System.Int32>>fn))
    [<CustomOperation("ChangeValue")>] member inline _.ChangeValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ChangeValue" => (System.Action<System.DateTime, System.Int32>fn))
    [<CustomOperation("ChangePickerType")>] member inline _.ChangePickerType ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ChangePickerType" => (System.Action<System.String, System.Int32>fn))
    [<CustomOperation("GetIndexPickerValue")>] member inline _.GetIndexPickerValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GetIndexPickerValue" => (System.Func<System.Int32, System.DateTime>fn))
    [<CustomOperation("GetIndexValue")>] member inline _.GetIndexValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GetIndexValue" => (System.Func<System.Int32, System.Nullable<System.DateTime>>fn))
    [<CustomOperation("DisabledDate")>] member inline _.DisabledDate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn))
    [<CustomOperation("DateRender")>] member inline _.DateRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DateRender" => (System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("MonthCellRender")>] member inline _.MonthCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("MonthCellRender" => (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("CalendarDateRender")>] member inline _.CalendarDateRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CalendarDateRender" => (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("CalendarMonthCellRender")>] member inline _.CalendarMonthCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CalendarMonthCellRender" => (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("RenderExtraFooter", fragment)
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("RenderExtraFooter", fragment { yield! fragments })
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("RenderExtraFooter", html.text x)
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("RenderExtraFooter", html.text x)
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("RenderExtraFooter", html.text x)
    [<CustomOperation("Use12Hours")>] member inline _.Use12Hours ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Use12Hours" => (defaultArg x true))

            
namespace rec AntDesign.DslInternals.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type DatePickerDatetimePanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("ShowToday")>] member inline _.ShowToday ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowToday" => (defaultArg x true))
    [<CustomOperation("ShowTimeFormat")>] member inline _.ShowTimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ShowTimeFormat" => x)
    [<CustomOperation("Ranges")>] member inline _.Ranges ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Nullable<System.DateTime>[]>) = render ==> ("Ranges" => x)
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
    [<CustomOperation("DisabledHours")>] member inline _.DisabledHours ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledHours" => (System.Func<System.DateTime, System.Int32[]>fn))
    [<CustomOperation("DisabledMinutes")>] member inline _.DisabledMinutes ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledMinutes" => (System.Func<System.DateTime, System.Int32[]>fn))
    [<CustomOperation("DisabledSeconds")>] member inline _.DisabledSeconds ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledSeconds" => (System.Func<System.DateTime, System.Int32[]>fn))
    [<CustomOperation("DisabledTime")>] member inline _.DisabledTime ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledTime" => (System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>fn))
    [<CustomOperation("OnOkClick")>] member inline _.OnOkClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnOkClick", fn)
    [<CustomOperation("OnOkClick")>] member inline _.OnOkClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnOkClick", fn)
    [<CustomOperation("OnNowClick")>] member inline _.OnNowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnNowClick", fn)
    [<CustomOperation("OnNowClick")>] member inline _.OnNowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnNowClick", fn)
    [<CustomOperation("OnRangeItemOver")>] member inline _.OnRangeItemOver ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime>[] -> unit) = render ==> html.callback("OnRangeItemOver", fn)
    [<CustomOperation("OnRangeItemOver")>] member inline _.OnRangeItemOver ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime>[] -> Task<unit>) = render ==> html.callbackTask("OnRangeItemOver", fn)
    [<CustomOperation("OnRangeItemOut")>] member inline _.OnRangeItemOut ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime>[] -> unit) = render ==> html.callback("OnRangeItemOut", fn)
    [<CustomOperation("OnRangeItemOut")>] member inline _.OnRangeItemOut ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime>[] -> Task<unit>) = render ==> html.callbackTask("OnRangeItemOut", fn)
    [<CustomOperation("OnRangeItemClicked")>] member inline _.OnRangeItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime>[] -> unit) = render ==> html.callback("OnRangeItemClicked", fn)
    [<CustomOperation("OnRangeItemClicked")>] member inline _.OnRangeItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Nullable<System.DateTime>[] -> Task<unit>) = render ==> html.callbackTask("OnRangeItemClicked", fn)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnOpenChange", fn)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnOpenChange", fn)

type DatePickerTemplateBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("RenderPickerHeader")>] member inline _.RenderPickerHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("RenderPickerHeader", fragment)
    [<CustomOperation("RenderPickerHeader")>] member inline _.RenderPickerHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("RenderPickerHeader", fragment { yield! fragments })
    [<CustomOperation("RenderPickerHeader")>] member inline _.RenderPickerHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("RenderPickerHeader", html.text x)
    [<CustomOperation("RenderPickerHeader")>] member inline _.RenderPickerHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("RenderPickerHeader", html.text x)
    [<CustomOperation("RenderPickerHeader")>] member inline _.RenderPickerHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("RenderPickerHeader", html.text x)
    [<CustomOperation("RenderTableHeader")>] member inline _.RenderTableHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("RenderTableHeader", fragment)
    [<CustomOperation("RenderTableHeader")>] member inline _.RenderTableHeader ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("RenderTableHeader", fragment { yield! fragments })
    [<CustomOperation("RenderTableHeader")>] member inline _.RenderTableHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("RenderTableHeader", html.text x)
    [<CustomOperation("RenderTableHeader")>] member inline _.RenderTableHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("RenderTableHeader", html.text x)
    [<CustomOperation("RenderTableHeader")>] member inline _.RenderTableHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("RenderTableHeader", html.text x)
    [<CustomOperation("RenderFirstCol")>] member inline _.RenderFirstCol ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.DateTime -> NodeRenderFragment) = render ==> html.renderFragment("RenderFirstCol", fn)
    [<CustomOperation("RenderColValue")>] member inline _.RenderColValue ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.DateTime -> NodeRenderFragment) = render ==> html.renderFragment("RenderColValue", fn)
    [<CustomOperation("RenderLastCol")>] member inline _.RenderLastCol ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.DateTime -> NodeRenderFragment) = render ==> html.renderFragment("RenderLastCol", fn)
    [<CustomOperation("ViewStartDate")>] member inline _.ViewStartDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("ViewStartDate" => x)
    [<CustomOperation("GetColTitle")>] member inline _.GetColTitle ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GetColTitle" => (System.Func<System.DateTime, System.String>fn))
    [<CustomOperation("GetRowClass")>] member inline _.GetRowClass ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GetRowClass" => (System.Func<System.DateTime, System.String>fn))
    [<CustomOperation("GetNextColValue")>] member inline _.GetNextColValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GetNextColValue" => (System.Func<System.DateTime, System.DateTime>fn))
    [<CustomOperation("IsInView")>] member inline _.IsInView ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IsInView" => (System.Func<System.DateTime, System.Boolean>fn))
    [<CustomOperation("IsToday")>] member inline _.IsToday ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IsToday" => (System.Func<System.DateTime, System.Boolean>fn))
    [<CustomOperation("IsSelected")>] member inline _.IsSelected ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IsSelected" => (System.Func<System.DateTime, System.Boolean>fn))
    [<CustomOperation("OnRowSelect")>] member inline _.OnRowSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnRowSelect" => (System.Action<System.DateTime>fn))
    [<CustomOperation("OnValueSelect")>] member inline _.OnValueSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnValueSelect" => (System.Action<System.DateTime>fn))
    [<CustomOperation("ShowFooter")>] member inline _.ShowFooter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowFooter" => (defaultArg x true))
    [<CustomOperation("MaxRow")>] member inline _.MaxRow ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxRow" => x)
    [<CustomOperation("MaxCol")>] member inline _.MaxCol ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxCol" => x)
    [<CustomOperation("SkipDays")>] member inline _.SkipDays ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SkipDays" => x)

type DatePickerDatePanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("IsWeek")>] member inline _.IsWeek ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsWeek" => (defaultArg x true))
    [<CustomOperation("ShowToday")>] member inline _.ShowToday ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowToday" => (defaultArg x true))

type DatePickerDecadePanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()


type DatePickerFooterBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()


type DatePickerHeaderBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("SuperChangeDateInterval")>] member inline _.SuperChangeDateInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SuperChangeDateInterval" => x)
    [<CustomOperation("ChangeDateInterval")>] member inline _.ChangeDateInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ChangeDateInterval" => x)
    [<CustomOperation("ShowSuperPreChange")>] member inline _.ShowSuperPreChange ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSuperPreChange" => (defaultArg x true))
    [<CustomOperation("ShowPreChange")>] member inline _.ShowPreChange ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowPreChange" => (defaultArg x true))
    [<CustomOperation("ShowNextChange")>] member inline _.ShowNextChange ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowNextChange" => (defaultArg x true))
    [<CustomOperation("ShowSuperNextChange")>] member inline _.ShowSuperNextChange ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSuperNextChange" => (defaultArg x true))

type DatePickerMonthPanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()


type DatePickerQuarterPanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()


type DatePickerYearPanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()


            
namespace rec AntDesign.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type ButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Color) = render ==> ("Color" => x)
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Block" => (defaultArg x true))
    [<CustomOperation("Danger")>] member inline _.Danger ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Danger" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Ghost")>] member inline _.Ghost ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Ghost" => (defaultArg x true))
    [<CustomOperation("HtmlType")>] member inline _.HtmlType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HtmlType" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("OnClickStopPropagation")>] member inline _.OnClickStopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("OnClickStopPropagation" => (defaultArg x true))
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shape" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("NoSpanWrap")>] member inline _.NoSpanWrap ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("NoSpanWrap" => (defaultArg x true))

type DownloadButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ButtonBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Url")>] member inline _.Url ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Url" => x)
    [<CustomOperation("FileName")>] member inline _.FileName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FileName" => x)

type ColBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Flex")>] member inline _.Flex ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("Flex" => x)
    [<CustomOperation("Span")>] member inline _.Span ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("Span" => x)
    [<CustomOperation("Order")>] member inline _.Order ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("Order" => x)
    [<CustomOperation("Offset")>] member inline _.Offset ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("Offset" => x)
    [<CustomOperation("Push")>] member inline _.Push ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("Push" => x)
    [<CustomOperation("Pull")>] member inline _.Pull ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("Pull" => x)
    [<CustomOperation("Xs")>] member inline _.Xs ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = render ==> ("Xs" => x)
    [<CustomOperation("Sm")>] member inline _.Sm ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = render ==> ("Sm" => x)
    [<CustomOperation("Md")>] member inline _.Md ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = render ==> ("Md" => x)
    [<CustomOperation("Lg")>] member inline _.Lg ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = render ==> ("Lg" => x)
    [<CustomOperation("Xl")>] member inline _.Xl ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = render ==> ("Xl" => x)
    [<CustomOperation("Xxl")>] member inline _.Xxl ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = render ==> ("Xxl" => x)

type GridColBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColBuilder<'FunBlazorGeneric>()


type RowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Align" => x)
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Justify" => x)
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Wrap" => (defaultArg x true))
    [<CustomOperation("Gutter")>] member inline _.Gutter ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Collections.Generic.Dictionary<System.String, System.Int32>>>) = render ==> ("Gutter" => x)
    [<CustomOperation("OnBreakpoint")>] member inline _.OnBreakpoint ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.BreakpointType -> unit) = render ==> html.callback("OnBreakpoint", fn)
    [<CustomOperation("OnBreakpoint")>] member inline _.OnBreakpoint ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.BreakpointType -> Task<unit>) = render ==> html.callbackTask("OnBreakpoint", fn)
    [<CustomOperation("DefaultBreakpoint")>] member inline _.DefaultBreakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.BreakpointType>) = render ==> ("DefaultBreakpoint" => x)

type GridRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RowBuilder<'FunBlazorGeneric>()


type IconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Alt")>] member inline _.Alt ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Alt" => x)
    [<CustomOperation("Role")>] member inline _.Role ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Role" => x)
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    [<CustomOperation("Spin")>] member inline _.Spin ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Spin" => (defaultArg x true))
    [<CustomOperation("Rotate")>] member inline _.Rotate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Rotate" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Theme" => x)
    [<CustomOperation("TwotoneColor")>] member inline _.TwotoneColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TwotoneColor" => x)
    [<CustomOperation("IconFont")>] member inline _.IconFont ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconFont" => x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("Fill")>] member inline _.Fill ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fill" => x)
    [<CustomOperation("TabIndex")>] member inline _.TabIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabIndex" => x)
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("StopPropagation" => (defaultArg x true))
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Component", fragment)
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Component", fragment { yield! fragments })
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Component", html.text x)
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Component", html.text x)
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Component", html.text x)

type IconFontBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit IconBuilder<'FunBlazorGeneric>()


type NotificationBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type NotificationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit NotificationBaseBuilder<'FunBlazorGeneric>()


type NotificationItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit NotificationBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Config")>] member inline _.Config ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.NotificationConfig) = render ==> ("Config" => x)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnClose" => (System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>fn))

type TypographyBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Code")>] member inline _.Code ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Code" => (defaultArg x true))
    [<CustomOperation("Copyable")>] member inline _.Copyable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Copyable" => (defaultArg x true))
    [<CustomOperation("CopyConfig")>] member inline _.CopyConfig ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TypographyCopyableConfig) = render ==> ("CopyConfig" => x)
    [<CustomOperation("Delete")>] member inline _.Delete ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Delete" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Editable" => (defaultArg x true))
    [<CustomOperation("EditConfig")>] member inline _.EditConfig ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TypographyEditableConfig) = render ==> ("EditConfig" => x)
    [<CustomOperation("Ellipsis")>] member inline _.Ellipsis ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Ellipsis" => (defaultArg x true))
    [<CustomOperation("EllipsisConfig")>] member inline _.EllipsisConfig ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TypographyEllipsisConfig) = render ==> ("EllipsisConfig" => x)
    [<CustomOperation("Mark")>] member inline _.Mark ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Mark" => (defaultArg x true))
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Underline" => (defaultArg x true))
    [<CustomOperation("Strong")>] member inline _.Strong ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Strong" => (defaultArg x true))
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Action) = render ==> ("OnChange" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)

type LinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Keyboard")>] member inline _.Keyboard ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Keyboard" => (defaultArg x true))

type ParagraphBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()


type TextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Keyboard")>] member inline _.Keyboard ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Keyboard" => (defaultArg x true))

type TitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Level")>] member inline _.Level ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Level" => x)

type AffixBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OffsetBottom")>] member inline _.OffsetBottom ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OffsetBottom" => x)
    [<CustomOperation("OffsetTop")>] member inline _.OffsetTop ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OffsetTop" => x)
    [<CustomOperation("TargetSelector")>] member inline _.TargetSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TargetSelector" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)

type AlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AfterClose")>] member inline _.AfterClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("AfterClose", fn)
    [<CustomOperation("AfterClose")>] member inline _.AfterClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("AfterClose", fn)
    [<CustomOperation("Banner")>] member inline _.Banner ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Banner" => (defaultArg x true))
    [<CustomOperation("Closable")>] member inline _.Closable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Closable" => (defaultArg x true))
    [<CustomOperation("CloseText")>] member inline _.CloseText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseText" => x)
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Description" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Icon", fragment)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Icon", fragment { yield! fragments })
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Icon", html.text x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Icon", html.text x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Icon", html.text x)
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Message" => x)
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MessageTemplate", fragment)
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MessageTemplate", fragment { yield! fragments })
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MessageTemplate", html.text x)
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MessageTemplate", html.text x)
    [<CustomOperation("MessageTemplate")>] member inline _.MessageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MessageTemplate", html.text x)
    [<CustomOperation("ShowIcon")>] member inline _.ShowIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowIcon" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClose", fn)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)

type AnchorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Key")>] member inline _.Key ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Key" => x)
    [<CustomOperation("Affix")>] member inline _.Affix ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Affix" => (defaultArg x true))
    [<CustomOperation("Bounds")>] member inline _.Bounds ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Bounds" => x)
    [<CustomOperation("GetContainer")>] member inline _.GetContainer ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GetContainer" => (System.Func<System.String>fn))
    [<CustomOperation("OffsetBottom")>] member inline _.OffsetBottom ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OffsetBottom" => x)
    [<CustomOperation("OffsetTop")>] member inline _.OffsetTop ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("OffsetTop" => x)
    [<CustomOperation("ShowInkInFixed")>] member inline _.ShowInkInFixed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowInkInFixed" => (defaultArg x true))
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink> -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink> -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("GetCurrentAnchor")>] member inline _.GetCurrentAnchor ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GetCurrentAnchor" => (System.Func<System.String>fn))
    [<CustomOperation("TargetOffset")>] member inline _.TargetOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("TargetOffset" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)

type AnchorLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)

type AutoCompleteOptGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("LabelFragment")>] member inline _.LabelFragment ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LabelFragment", fragment)
    [<CustomOperation("LabelFragment")>] member inline _.LabelFragment ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LabelFragment", fragment { yield! fragments })
    [<CustomOperation("LabelFragment")>] member inline _.LabelFragment ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelFragment", html.text x)
    [<CustomOperation("LabelFragment")>] member inline _.LabelFragment ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelFragment", html.text x)
    [<CustomOperation("LabelFragment")>] member inline _.LabelFragment ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelFragment", html.text x)

type AutoCompleteOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Value" => x)
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.IAutoCompleteRef) = render ==> ("AutoComplete" => x)

type AvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shape" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Src")>] member inline _.Src ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Src" => x)
    [<CustomOperation("SrcSet")>] member inline _.SrcSet ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SrcSet" => x)
    [<CustomOperation("Alt")>] member inline _.Alt ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Alt" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("OnError")>] member inline _.OnError ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.ErrorEventArgs -> unit) = render ==> html.callback("OnError", fn)
    [<CustomOperation("OnError")>] member inline _.OnError ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.ErrorEventArgs -> Task<unit>) = render ==> html.callbackTask("OnError", fn)

type AvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("MaxCount")>] member inline _.MaxCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxCount" => x)
    [<CustomOperation("MaxStyle")>] member inline _.MaxStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxStyle" => x)
    [<CustomOperation("MaxPopoverPlacement")>] member inline _.MaxPopoverPlacement ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Placement) = render ==> ("MaxPopoverPlacement" => x)

type BackTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("VisibilityHeight")>] member inline _.VisibilityHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("VisibilityHeight" => x)
    [<CustomOperation("TargetSelector")>] member inline _.TargetSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TargetSelector" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type BadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    [<CustomOperation("PresetColor")>] member inline _.PresetColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.PresetColor>) = render ==> ("PresetColor" => x)
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Count" => x)
    [<CustomOperation("CountTemplate")>] member inline _.CountTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CountTemplate", fragment)
    [<CustomOperation("CountTemplate")>] member inline _.CountTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CountTemplate", fragment { yield! fragments })
    [<CustomOperation("CountTemplate")>] member inline _.CountTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CountTemplate", html.text x)
    [<CustomOperation("CountTemplate")>] member inline _.CountTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CountTemplate", html.text x)
    [<CustomOperation("CountTemplate")>] member inline _.CountTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CountTemplate", html.text x)
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dot" => (defaultArg x true))
    [<CustomOperation("Offset")>] member inline _.Offset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.ValueTuple<System.Int32, System.Int32>) = render ==> ("Offset" => x)
    [<CustomOperation("OverflowCount")>] member inline _.OverflowCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverflowCount" => x)
    [<CustomOperation("ShowZero")>] member inline _.ShowZero ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowZero" => (defaultArg x true))
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Status" => x)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)

type BadgeRibbonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("TextTemplate")>] member inline _.TextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TextTemplate", fragment)
    [<CustomOperation("TextTemplate")>] member inline _.TextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TextTemplate", fragment { yield! fragments })
    [<CustomOperation("TextTemplate")>] member inline _.TextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TextTemplate", html.text x)
    [<CustomOperation("TextTemplate")>] member inline _.TextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TextTemplate", html.text x)
    [<CustomOperation("TextTemplate")>] member inline _.TextTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TextTemplate", html.text x)
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placement" => x)

type BreadcrumbBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AutoGenerate")>] member inline _.AutoGenerate ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoGenerate" => (defaultArg x true))
    [<CustomOperation("Separator")>] member inline _.Separator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Separator" => x)
    [<CustomOperation("RouteLabel")>] member inline _.RouteLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RouteLabel" => x)

type ButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)

type CalendarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("Value" => x)
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime) = render ==> ("DefaultValue" => x)
    [<CustomOperation("ValidRange")>] member inline _.ValidRange ([<InlineIfLambda>] render: AttrRenderFragment, x: System.DateTime[]) = render ==> ("ValidRange" => x)
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Mode" => x)
    [<CustomOperation("FullScreen")>] member inline _.FullScreen ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("FullScreen" => (defaultArg x true))
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.DateTime -> unit) = render ==> html.callback("OnSelect", fn)
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.DateTime -> Task<unit>) = render ==> html.callbackTask("OnSelect", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.DateTime -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.DateTime -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("HeaderRender")>] member inline _.HeaderRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderRender" => (System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("DateCellRender")>] member inline _.DateCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DateCellRender" => (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("DateFullCellRender")>] member inline _.DateFullCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DateFullCellRender" => (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("MonthCellRender")>] member inline _.MonthCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("MonthCellRender" => (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("MonthFullCellRender")>] member inline _.MonthFullCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("MonthFullCellRender" => (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("OnPanelChange")>] member inline _.OnPanelChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnPanelChange" => (System.Action<System.DateTime, System.String>fn))
    [<CustomOperation("DisabledDate")>] member inline _.DisabledDate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn))
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.DatePickerLocale) = render ==> ("Locale" => x)
    [<CustomOperation("CultureInfo")>] member inline _.CultureInfo ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("CultureInfo" => x)

type CardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Body", fragment)
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Body", fragment { yield! fragments })
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Body", html.text x)
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Body", html.text x)
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Body", html.text x)
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ActionTemplate", fragment)
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ActionTemplate", fragment { yield! fragments })
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ActionTemplate", html.text x)
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ActionTemplate", html.text x)
    [<CustomOperation("ActionTemplate")>] member inline _.ActionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ActionTemplate", html.text x)
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("Hoverable")>] member inline _.Hoverable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hoverable" => (defaultArg x true))
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("BodyStyle")>] member inline _.BodyStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BodyStyle" => x)
    [<CustomOperation("Cover")>] member inline _.Cover ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Cover", fragment)
    [<CustomOperation("Cover")>] member inline _.Cover ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Cover", fragment { yield! fragments })
    [<CustomOperation("Cover")>] member inline _.Cover ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Cover", html.text x)
    [<CustomOperation("Cover")>] member inline _.Cover ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Cover", html.text x)
    [<CustomOperation("Cover")>] member inline _.Cover ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Cover", html.text x)
    [<CustomOperation("Actions")>] member inline _.Actions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Actions" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Extra", fragment)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Extra", fragment { yield! fragments })
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("CardTabs")>] member inline _.CardTabs ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CardTabs", fragment)
    [<CustomOperation("CardTabs")>] member inline _.CardTabs ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CardTabs", fragment { yield! fragments })
    [<CustomOperation("CardTabs")>] member inline _.CardTabs ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardTabs", html.text x)
    [<CustomOperation("CardTabs")>] member inline _.CardTabs ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardTabs", html.text x)
    [<CustomOperation("CardTabs")>] member inline _.CardTabs ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardTabs", html.text x)

type CardActionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type CardGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Hoverable")>] member inline _.Hoverable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Hoverable" => (defaultArg x true))

type CarouselBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DotPosition")>] member inline _.DotPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DotPosition" => x)
    [<CustomOperation("Autoplay")>] member inline _.Autoplay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("Autoplay" => x)
    [<CustomOperation("Effect")>] member inline _.Effect ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Effect" => x)

type CarouselSlickBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type CollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Accordion")>] member inline _.Accordion ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Accordion" => (defaultArg x true))
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("ExpandIconPosition")>] member inline _.ExpandIconPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIconPosition" => x)
    [<CustomOperation("DefaultActiveKey")>] member inline _.DefaultActiveKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("DefaultActiveKey" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
    [<CustomOperation("ExpandIconTemplate")>] member inline _.ExpandIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("ExpandIconTemplate", fn)
    [<CustomOperation("Animation")>] member inline _.Animation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Animation" => (defaultArg x true))

type PanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Active")>] member inline _.Active ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Active" => (defaultArg x true))
    [<CustomOperation("Key")>] member inline _.Key ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Key" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("ShowArrow")>] member inline _.ShowArrow ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowArrow" => (defaultArg x true))
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Extra" => x)
    [<CustomOperation("ExtraTemplate")>] member inline _.ExtraTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ExtraTemplate", fragment)
    [<CustomOperation("ExtraTemplate")>] member inline _.ExtraTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ExtraTemplate", fragment { yield! fragments })
    [<CustomOperation("ExtraTemplate")>] member inline _.ExtraTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ExtraTemplate", html.text x)
    [<CustomOperation("ExtraTemplate")>] member inline _.ExtraTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ExtraTemplate", html.text x)
    [<CustomOperation("ExtraTemplate")>] member inline _.ExtraTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ExtraTemplate", html.text x)
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Header" => x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderTemplate", fragment)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("HeaderTemplate", fragment { yield! fragments })
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderTemplate", html.text x)
    [<CustomOperation("OnActiveChange")>] member inline _.OnActiveChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnActiveChange", fn)
    [<CustomOperation("OnActiveChange")>] member inline _.OnActiveChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnActiveChange", fn)

type CommentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Author")>] member inline _.Author ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Author" => x)
    [<CustomOperation("AuthorTemplate")>] member inline _.AuthorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AuthorTemplate", fragment)
    [<CustomOperation("AuthorTemplate")>] member inline _.AuthorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AuthorTemplate", fragment { yield! fragments })
    [<CustomOperation("AuthorTemplate")>] member inline _.AuthorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AuthorTemplate", html.text x)
    [<CustomOperation("AuthorTemplate")>] member inline _.AuthorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AuthorTemplate", html.text x)
    [<CustomOperation("AuthorTemplate")>] member inline _.AuthorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AuthorTemplate", html.text x)
    [<CustomOperation("Avatar")>] member inline _.Avatar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AvatarTemplate", fragment)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AvatarTemplate", fragment { yield! fragments })
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AvatarTemplate", html.text x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AvatarTemplate", html.text x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AvatarTemplate", html.text x)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Content" => x)
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ContentTemplate", fragment)
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ContentTemplate", fragment { yield! fragments })
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ContentTemplate", html.text x)
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ContentTemplate", html.text x)
    [<CustomOperation("ContentTemplate")>] member inline _.ContentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ContentTemplate", html.text x)
    [<CustomOperation("Datetime")>] member inline _.Datetime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Datetime" => x)
    [<CustomOperation("DatetimeTemplate")>] member inline _.DatetimeTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DatetimeTemplate", fragment)
    [<CustomOperation("DatetimeTemplate")>] member inline _.DatetimeTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DatetimeTemplate", fragment { yield! fragments })
    [<CustomOperation("DatetimeTemplate")>] member inline _.DatetimeTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DatetimeTemplate", html.text x)
    [<CustomOperation("DatetimeTemplate")>] member inline _.DatetimeTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DatetimeTemplate", html.text x)
    [<CustomOperation("DatetimeTemplate")>] member inline _.DatetimeTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DatetimeTemplate", html.text x)
    [<CustomOperation("Actions")>] member inline _.Actions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Actions" => x)
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placement" => x)

type AntContainerComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Tag")>] member inline _.Tag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tag" => x)

type AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TValue * ('TValue -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("ValueExpression")>] member inline _.ValueExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = render ==> ("ValueExpression" => x)
    [<CustomOperation("ValuesExpression")>] member inline _.ValuesExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = render ==> ("ValuesExpression" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("CultureInfo")>] member inline _.CultureInfo ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("CultureInfo" => x)

type AntInputBoolComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, System.Boolean>()
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoFocus" => (defaultArg x true))
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Checked" => (defaultArg x true))
    [<CustomOperation("Checked'")>] member inline _.Checked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Checked", valueFn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("CheckedChanged", fn)
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CheckedChanged", fn)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))

type CheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("CheckedChange")>] member inline _.CheckedChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("CheckedChange", fn)
    [<CustomOperation("CheckedChange")>] member inline _.CheckedChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CheckedChange", fn)
    [<CustomOperation("CheckedExpression")>] member inline _.CheckedExpression ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = render ==> ("CheckedExpression" => x)
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Indeterminate" => (defaultArg x true))
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)

type SwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("CheckedChildren")>] member inline _.CheckedChildren ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedChildren" => x)
    [<CustomOperation("CheckedChildrenTemplate")>] member inline _.CheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CheckedChildrenTemplate", fragment)
    [<CustomOperation("CheckedChildrenTemplate")>] member inline _.CheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CheckedChildrenTemplate", fragment { yield! fragments })
    [<CustomOperation("CheckedChildrenTemplate")>] member inline _.CheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CheckedChildrenTemplate", html.text x)
    [<CustomOperation("CheckedChildrenTemplate")>] member inline _.CheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CheckedChildrenTemplate", html.text x)
    [<CustomOperation("CheckedChildrenTemplate")>] member inline _.CheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CheckedChildrenTemplate", html.text x)
    [<CustomOperation("Control")>] member inline _.Control ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Control" => (defaultArg x true))
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("UnCheckedChildren")>] member inline _.UnCheckedChildren ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UnCheckedChildren" => x)
    [<CustomOperation("UnCheckedChildrenTemplate")>] member inline _.UnCheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("UnCheckedChildrenTemplate", fragment)
    [<CustomOperation("UnCheckedChildrenTemplate")>] member inline _.UnCheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("UnCheckedChildrenTemplate", fragment { yield! fragments })
    [<CustomOperation("UnCheckedChildrenTemplate")>] member inline _.UnCheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("UnCheckedChildrenTemplate", html.text x)
    [<CustomOperation("UnCheckedChildrenTemplate")>] member inline _.UnCheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("UnCheckedChildrenTemplate", html.text x)
    [<CustomOperation("UnCheckedChildrenTemplate")>] member inline _.UnCheckedChildrenTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("UnCheckedChildrenTemplate", html.text x)

type AutoCompleteBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, System.String>()
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("DefaultActiveFirstOption")>] member inline _.DefaultActiveFirstOption ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultActiveFirstOption" => (defaultArg x true))
    [<CustomOperation("Backfill")>] member inline _.Backfill ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Backfill" => (defaultArg x true))
    [<CustomOperation("DebounceMilliseconds")>] member inline _.DebounceMilliseconds ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DebounceMilliseconds" => x)
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TOption>) = render ==> ("Options" => x)
    [<CustomOperation("OptionDataItems")>] member inline _.OptionDataItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = render ==> ("OptionDataItems" => x)
    [<CustomOperation("OnSelectionChange")>] member inline _.OnSelectionChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.AutoCompleteOption -> unit) = render ==> html.callback("OnSelectionChange", fn)
    [<CustomOperation("OnSelectionChange")>] member inline _.OnSelectionChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.AutoCompleteOption -> Task<unit>) = render ==> html.callbackTask("OnSelectionChange", fn)
    [<CustomOperation("OnActiveChange")>] member inline _.OnActiveChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.AutoCompleteOption -> unit) = render ==> html.callback("OnActiveChange", fn)
    [<CustomOperation("OnActiveChange")>] member inline _.OnActiveChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.AutoCompleteOption -> Task<unit>) = render ==> html.callbackTask("OnActiveChange", fn)
    [<CustomOperation("OnInput")>] member inline _.OnInput ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> unit) = render ==> html.callback("OnInput", fn)
    [<CustomOperation("OnInput")>] member inline _.OnInput ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnInput", fn)
    [<CustomOperation("OnPanelVisibleChange")>] member inline _.OnPanelVisibleChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnPanelVisibleChange", fn)
    [<CustomOperation("OnPanelVisibleChange")>] member inline _.OnPanelVisibleChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnPanelVisibleChange", fn)
    [<CustomOperation("OptionTemplate")>] member inline _.OptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.AutoCompleteDataItem<'TOption> -> NodeRenderFragment) = render ==> html.renderFragment("OptionTemplate", fn)
    [<CustomOperation("OptionFormat")>] member inline _.OptionFormat ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OptionFormat" => (System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>fn))
    [<CustomOperation("OverlayTemplate")>] member inline _.OverlayTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("OverlayTemplate", fragment)
    [<CustomOperation("OverlayTemplate")>] member inline _.OverlayTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("OverlayTemplate", fragment { yield! fragments })
    [<CustomOperation("OverlayTemplate")>] member inline _.OverlayTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("OverlayTemplate", html.text x)
    [<CustomOperation("OverlayTemplate")>] member inline _.OverlayTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("OverlayTemplate", html.text x)
    [<CustomOperation("OverlayTemplate")>] member inline _.OverlayTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("OverlayTemplate", html.text x)
    [<CustomOperation("CompareWith")>] member inline _.CompareWith ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CompareWith" => (System.Func<System.Object, System.Object, System.Boolean>fn))
    [<CustomOperation("FilterExpression")>] member inline _.FilterExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FilterExpression" => (System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>fn))
    [<CustomOperation("AllowFilter")>] member inline _.AllowFilter ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowFilter" => (defaultArg x true))
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = render ==> ("Width" => x)
    [<CustomOperation("OverlayClassName")>] member inline _.OverlayClassName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OverlayClassName" => x)
    [<CustomOperation("OverlayStyle")>] member inline _.OverlayStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OverlayStyle" => x)
    [<CustomOperation("PopupContainerSelector")>] member inline _.PopupContainerSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupContainerSelector" => x)
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.AutoCompleteOption) = render ==> ("SelectedItem" => x)
    [<CustomOperation("BoundaryAdjustMode")>] member inline _.BoundaryAdjustMode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TriggerBoundaryAdjustMode) = render ==> ("BoundaryAdjustMode" => x)
    [<CustomOperation("ShowPanel")>] member inline _.ShowPanel ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowPanel" => (defaultArg x true))

type CascaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, System.String>()
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowClear" => (defaultArg x true))
    [<CustomOperation("BoundaryAdjustMode")>] member inline _.BoundaryAdjustMode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TriggerBoundaryAdjustMode) = render ==> ("BoundaryAdjustMode" => x)
    [<CustomOperation("ChangeOnSelect")>] member inline _.ChangeOnSelect ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ChangeOnSelect" => (defaultArg x true))
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DefaultValue" => x)
    [<CustomOperation("ExpandTrigger")>] member inline _.ExpandTrigger ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandTrigger" => x)
    [<CustomOperation("NotFoundContent")>] member inline _.NotFoundContent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NotFoundContent" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("PopupContainerSelector")>] member inline _.PopupContainerSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupContainerSelector" => x)
    [<CustomOperation("ShowSearch")>] member inline _.ShowSearch ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSearch" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnChange" => (System.Action<System.Collections.Generic.List<AntDesign.CascaderNode>, System.String, System.String>fn))
    [<CustomOperation("SelectedNodesChanged")>] member inline _.SelectedNodesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.CascaderNode[] -> unit) = render ==> html.callback("SelectedNodesChanged", fn)
    [<CustomOperation("SelectedNodesChanged")>] member inline _.SelectedNodesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.CascaderNode[] -> Task<unit>) = render ==> html.callbackTask("SelectedNodesChanged", fn)
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = render ==> ("Options" => x)

type CheckboxGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue[]>()
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<AntDesign.CheckboxOption<'TValue>[], 'TValue[]>) = render ==> ("Options" => x)
    [<CustomOperation("MixedMode")>] member inline _.MixedMode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.CheckboxGroupMixedMode) = render ==> ("MixedMode" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue[] -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue[] -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))

type EnumCheckboxGroupBuilder<'FunBlazorGeneric, 'TEnum when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit CheckboxGroupBuilder<'FunBlazorGeneric, 'TEnum>()


type DatePickerBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("ChangeOnClose")>] member inline _.ChangeOnClose ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ChangeOnClose" => (defaultArg x true))
    [<CustomOperation("Picker")>] member inline _.Picker ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Picker" => x)
    [<CustomOperation("PopupContainerSelector")>] member inline _.PopupContainerSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupContainerSelector" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Boolean, System.Boolean[]>) = render ==> ("Disabled" => x)
    [<CustomOperation("BoundaryAdjustMode")>] member inline _.BoundaryAdjustMode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TriggerBoundaryAdjustMode) = render ==> ("BoundaryAdjustMode" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoFocus" => (defaultArg x true))
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Open" => (defaultArg x true))
    [<CustomOperation("InputReadOnly")>] member inline _.InputReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("InputReadOnly" => (defaultArg x true))
    [<CustomOperation("ShowToday")>] member inline _.ShowToday ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowToday" => (defaultArg x true))
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Mask" => x)
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.DatePickerLocale) = render ==> ("Locale" => x)
    [<CustomOperation("CultureInfo")>] member inline _.CultureInfo ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("CultureInfo" => x)
    [<CustomOperation("ShowTime")>] member inline _.ShowTime ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Boolean, System.String>) = render ==> ("ShowTime" => x)
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowClear" => (defaultArg x true))
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.String[]>) = render ==> ("Placeholder" => x)
    [<CustomOperation("PopupStyle")>] member inline _.PopupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupStyle" => x)
    [<CustomOperation("ClassName")>] member inline _.ClassName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClassName" => x)
    [<CustomOperation("DropdownClassName")>] member inline _.DropdownClassName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropdownClassName" => x)
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("DefaultValue" => x)
    [<CustomOperation("DefaultPickerValue")>] member inline _.DefaultPickerValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("DefaultPickerValue" => x)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SuffixIcon", fragment)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SuffixIcon", fragment { yield! fragments })
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("Ranges")>] member inline _.Ranges ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Nullable<System.DateTime>[]>) = render ==> ("Ranges" => x)
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("RenderExtraFooter", fragment)
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("RenderExtraFooter", fragment { yield! fragments })
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("RenderExtraFooter", html.text x)
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("RenderExtraFooter", html.text x)
    [<CustomOperation("RenderExtraFooter")>] member inline _.RenderExtraFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("RenderExtraFooter", html.text x)
    [<CustomOperation("OnClearClick")>] member inline _.OnClearClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClearClick", fn)
    [<CustomOperation("OnClearClick")>] member inline _.OnClearClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClearClick", fn)
    [<CustomOperation("OnClear")>] member inline _.OnClear ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClear", fn)
    [<CustomOperation("OnClear")>] member inline _.OnClear ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClear", fn)
    [<CustomOperation("OnOk")>] member inline _.OnOk ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnOk", fn)
    [<CustomOperation("OnOk")>] member inline _.OnOk ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnOk", fn)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnOpenChange", fn)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnOpenChange", fn)
    [<CustomOperation("OnPanelChange")>] member inline _.OnPanelChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.DateTimeChangedEventArgs<'TValue> -> unit) = render ==> html.callback("OnPanelChange", fn)
    [<CustomOperation("OnPanelChange")>] member inline _.OnPanelChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.DateTimeChangedEventArgs<'TValue> -> Task<unit>) = render ==> html.callbackTask("OnPanelChange", fn)
    [<CustomOperation("DisabledDate")>] member inline _.DisabledDate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn))
    [<CustomOperation("DisabledHours")>] member inline _.DisabledHours ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledHours" => (System.Func<System.DateTime, System.Int32[]>fn))
    [<CustomOperation("DisabledMinutes")>] member inline _.DisabledMinutes ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledMinutes" => (System.Func<System.DateTime, System.Int32[]>fn))
    [<CustomOperation("DisabledSeconds")>] member inline _.DisabledSeconds ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledSeconds" => (System.Func<System.DateTime, System.Int32[]>fn))
    [<CustomOperation("DisabledTime")>] member inline _.DisabledTime ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledTime" => (System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>fn))
    [<CustomOperation("DateRender")>] member inline _.DateRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DateRender" => (System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("MonthCellRender")>] member inline _.MonthCellRender ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("MonthCellRender" => (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("Use12Hours")>] member inline _.Use12Hours ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Use12Hours" => (defaultArg x true))
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Placement) = render ==> ("Placement" => x)

type DatePickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.DateTimeChangedEventArgs<'TValue> -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.DateTimeChangedEventArgs<'TValue> -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)

type MonthPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()


type QuarterPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()


type WeekPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()


type YearPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()


type TimePickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()


type RangePickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.DateRangeChangedEventArgs<'TValue> -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.DateRangeChangedEventArgs<'TValue> -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("DisabledDate")>] member inline _.DisabledDate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn))

type InputNumberBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("Precision")>] member inline _.Precision ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Precision" => x)
    [<CustomOperation("Formatter")>] member inline _.Formatter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Formatter" => (System.Func<'TValue, System.String>fn))
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
    [<CustomOperation("Parser")>] member inline _.Parser ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Parser" => (System.Func<System.String, System.String>fn))
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Step" => x)
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("DefaultValue" => x)
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Max" => x)
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Min" => x)
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxLength" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnFocus", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFocus", fn)
    [<CustomOperation("PlaceHolder")>] member inline _.PlaceHolder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PlaceHolder" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Prefix" => x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)

type InputBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("AddOnBefore")>] member inline _.AddOnBefore ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AddOnBefore", fragment)
    [<CustomOperation("AddOnBefore")>] member inline _.AddOnBefore ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AddOnBefore", fragment { yield! fragments })
    [<CustomOperation("AddOnBefore")>] member inline _.AddOnBefore ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AddOnBefore", html.text x)
    [<CustomOperation("AddOnBefore")>] member inline _.AddOnBefore ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AddOnBefore", html.text x)
    [<CustomOperation("AddOnBefore")>] member inline _.AddOnBefore ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AddOnBefore", html.text x)
    [<CustomOperation("AddOnAfter")>] member inline _.AddOnAfter ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AddOnAfter", fragment)
    [<CustomOperation("AddOnAfter")>] member inline _.AddOnAfter ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AddOnAfter", fragment { yield! fragments })
    [<CustomOperation("AddOnAfter")>] member inline _.AddOnAfter ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AddOnAfter", html.text x)
    [<CustomOperation("AddOnAfter")>] member inline _.AddOnAfter ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AddOnAfter", html.text x)
    [<CustomOperation("AddOnAfter")>] member inline _.AddOnAfter ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AddOnAfter", html.text x)
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowClear" => (defaultArg x true))
    [<CustomOperation("OnClear")>] member inline _.OnClear ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClear", fn)
    [<CustomOperation("OnClear")>] member inline _.OnClear ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClear", fn)
    [<CustomOperation("AutoComplete")>] member inline _.AutoComplete ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoComplete" => (defaultArg x true))
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoFocus" => (defaultArg x true))
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("BindOnInput")>] member inline _.BindOnInput ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("BindOnInput" => (defaultArg x true))
    [<CustomOperation("DebounceMilliseconds")>] member inline _.DebounceMilliseconds ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DebounceMilliseconds" => x)
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("DefaultValue" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("InputElementSuffixClass")>] member inline _.InputElementSuffixClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputElementSuffixClass" => x)
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLength" => x)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnBlur", fn)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnBlur", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnFocus", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFocus", fn)
    [<CustomOperation("OnInput")>] member inline _.OnInput ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> unit) = render ==> html.callback("OnInput", fn)
    [<CustomOperation("OnInput")>] member inline _.OnInput ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnInput", fn)
    [<CustomOperation("OnkeyDown")>] member inline _.OnkeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnkeyDown", fn)
    [<CustomOperation("OnkeyDown")>] member inline _.OnkeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnkeyDown", fn)
    [<CustomOperation("OnkeyUp")>] member inline _.OnkeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnkeyUp", fn)
    [<CustomOperation("OnkeyUp")>] member inline _.OnkeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnkeyUp", fn)
    [<CustomOperation("OnMouseUp")>] member inline _.OnMouseUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnMouseUp", fn)
    [<CustomOperation("OnMouseUp")>] member inline _.OnMouseUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnMouseUp", fn)
    [<CustomOperation("OnPressEnter")>] member inline _.OnPressEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnPressEnter", fn)
    [<CustomOperation("OnPressEnter")>] member inline _.OnPressEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnPressEnter", fn)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Prefix", fragment)
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Prefix", fragment { yield! fragments })
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Prefix", html.text x)
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Prefix", html.text x)
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Prefix", html.text x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    [<CustomOperation("StopPropagation")>] member inline _.StopPropagation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("StopPropagation" => (defaultArg x true))
    [<CustomOperation("Suffix")>] member inline _.Suffix ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Suffix", fragment)
    [<CustomOperation("Suffix")>] member inline _.Suffix ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Suffix", fragment { yield! fragments })
    [<CustomOperation("Suffix")>] member inline _.Suffix ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Suffix", html.text x)
    [<CustomOperation("Suffix")>] member inline _.Suffix ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Suffix", html.text x)
    [<CustomOperation("Suffix")>] member inline _.Suffix ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Suffix", html.text x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("WrapperStyle")>] member inline _.WrapperStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("WrapperStyle" => x)
    [<CustomOperation("ShowCount")>] member inline _.ShowCount ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowCount" => (defaultArg x true))
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)

type SearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBuilder<'FunBlazorGeneric, System.String>()
    [<CustomOperation("ClassicSearchIcon")>] member inline _.ClassicSearchIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ClassicSearchIcon" => (defaultArg x true))
    [<CustomOperation("EnterButton")>] member inline _.EnterButton ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Boolean, System.String>) = render ==> ("EnterButton" => x)
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("OnSearch")>] member inline _.OnSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("OnSearch", fn)
    [<CustomOperation("OnSearch")>] member inline _.OnSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnSearch", fn)

type AutoCompleteSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SearchBuilder<'FunBlazorGeneric>()


type AutoCompleteInputBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBuilder<'FunBlazorGeneric, 'TValue>()


type InputPasswordBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBuilder<'FunBlazorGeneric, System.String>()
    [<CustomOperation("IconRender")>] member inline _.IconRender ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("IconRender", fragment)
    [<CustomOperation("IconRender")>] member inline _.IconRender ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("IconRender", fragment { yield! fragments })
    [<CustomOperation("IconRender")>] member inline _.IconRender ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("IconRender", html.text x)
    [<CustomOperation("IconRender")>] member inline _.IconRender ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("IconRender", html.text x)
    [<CustomOperation("IconRender")>] member inline _.IconRender ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("IconRender", html.text x)
    [<CustomOperation("ShowPassword")>] member inline _.ShowPassword ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowPassword" => (defaultArg x true))
    [<CustomOperation("VisibilityToggle")>] member inline _.VisibilityToggle ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("VisibilityToggle" => (defaultArg x true))

type TextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBuilder<'FunBlazorGeneric, System.String>()
    [<CustomOperation("AutoSize")>] member inline _.AutoSize ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoSize" => (defaultArg x true))
    [<CustomOperation("DefaultToEmptyString")>] member inline _.DefaultToEmptyString ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultToEmptyString" => (defaultArg x true))
    [<CustomOperation("MaxRows")>] member inline _.MaxRows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.UInt32) = render ==> ("MaxRows" => x)
    [<CustomOperation("MinRows")>] member inline _.MinRows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.UInt32) = render ==> ("MinRows" => x)
    [<CustomOperation("Rows")>] member inline _.Rows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.UInt32) = render ==> ("Rows" => x)
    [<CustomOperation("OnResize")>] member inline _.OnResize ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.OnResizeEventArgs -> unit) = render ==> html.callback("OnResize", fn)
    [<CustomOperation("OnResize")>] member inline _.OnResize ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.OnResizeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnResize", fn)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

type RadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("ButtonStyle")>] member inline _.ButtonStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.RadioButtonStyle>) = render ==> ("ButtonStyle" => x)
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("DefaultValue" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String[], AntDesign.RadioOption<'TValue>[]>) = render ==> ("Options" => x)

type EnumRadioGroupBuilder<'FunBlazorGeneric, 'TEnum when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit RadioGroupBuilder<'FunBlazorGeneric, 'TEnum>()


type SelectBaseBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TItemValue>()
    [<CustomOperation("BoundaryAdjustMode")>] member inline _.BoundaryAdjustMode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TriggerBoundaryAdjustMode) = render ==> ("BoundaryAdjustMode" => x)
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowClear" => (defaultArg x true))
    [<CustomOperation("AutoClearSearchValue")>] member inline _.AutoClearSearchValue ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoClearSearchValue" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Mode" => x)
    [<CustomOperation("EnableSearch")>] member inline _.EnableSearch ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("EnableSearch" => (defaultArg x true))
    [<CustomOperation("SearchDebounceMilliseconds")>] member inline _.SearchDebounceMilliseconds ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SearchDebounceMilliseconds" => x)
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Open" => (defaultArg x true))
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnFocus", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnFocus", fn)
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoFocus" => (defaultArg x true))
    [<CustomOperation("SortByGroup")>] member inline _.SortByGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.SortDirection) = render ==> ("SortByGroup" => x)
    [<CustomOperation("SortByLabel")>] member inline _.SortByLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.SortDirection) = render ==> ("SortByLabel" => x)
    [<CustomOperation("HideSelected")>] member inline _.HideSelected ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideSelected" => (defaultArg x true))
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItemValue -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItemValue -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("ValuesChanged")>] member inline _.ValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TItemValue> -> unit) = render ==> html.callback("ValuesChanged", fn)
    [<CustomOperation("ValuesChanged")>] member inline _.ValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TItemValue> -> Task<unit>) = render ==> html.callbackTask("ValuesChanged", fn)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SuffixIcon", fragment)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SuffixIcon", fragment { yield! fragments })
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("PrefixIcon")>] member inline _.PrefixIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PrefixIcon", fragment)
    [<CustomOperation("PrefixIcon")>] member inline _.PrefixIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PrefixIcon", fragment { yield! fragments })
    [<CustomOperation("PrefixIcon")>] member inline _.PrefixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PrefixIcon", html.text x)
    [<CustomOperation("PrefixIcon")>] member inline _.PrefixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PrefixIcon", html.text x)
    [<CustomOperation("PrefixIcon")>] member inline _.PrefixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PrefixIcon", html.text x)
    [<CustomOperation("AccessKey")>] member inline _.AccessKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AccessKey" => x)
    [<CustomOperation("DefaultValues")>] member inline _.DefaultValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItemValue>) = render ==> ("DefaultValues" => x)
    [<CustomOperation("OnClearSelected")>] member inline _.OnClearSelected ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClearSelected", fn)
    [<CustomOperation("OnClearSelected")>] member inline _.OnClearSelected ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClearSelected", fn)
    [<CustomOperation("OnSelectedItemChanged")>] member inline _.OnSelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> unit) = render ==> html.callback("OnSelectedItemChanged", fn)
    [<CustomOperation("OnSelectedItemChanged")>] member inline _.OnSelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("OnSelectedItemChanged", fn)
    [<CustomOperation("OnSelectedItemsChanged")>] member inline _.OnSelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TItem> -> unit) = render ==> html.callback("OnSelectedItemsChanged", fn)
    [<CustomOperation("OnSelectedItemsChanged")>] member inline _.OnSelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnSelectedItemsChanged", fn)
    [<CustomOperation("Values")>] member inline _.Values ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItemValue>) = render ==> ("Values" => x)
    [<CustomOperation("Values'")>] member inline _.Values' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TItemValue> * (System.Collections.Generic.IEnumerable<'TItemValue> -> unit)) = render ==> html.bind("Values", valueFn)
    [<CustomOperation("CustomTagLabelToValue")>] member inline _.CustomTagLabelToValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CustomTagLabelToValue" => (System.Func<System.String, 'TItemValue>fn))
    [<CustomOperation("SelectOptions")>] member inline _.SelectOptions ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SelectOptions", fragment)
    [<CustomOperation("SelectOptions")>] member inline _.SelectOptions ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SelectOptions", fragment { yield! fragments })
    [<CustomOperation("SelectOptions")>] member inline _.SelectOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SelectOptions", html.text x)
    [<CustomOperation("SelectOptions")>] member inline _.SelectOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SelectOptions", html.text x)
    [<CustomOperation("SelectOptions")>] member inline _.SelectOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SelectOptions", html.text x)
    [<CustomOperation("MaxTagTextLength")>] member inline _.MaxTagTextLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxTagTextLength" => x)
    [<CustomOperation("LabelInValue")>] member inline _.LabelInValue ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("LabelInValue" => (defaultArg x true))
    [<CustomOperation("MaxTagCount")>] member inline _.MaxTagCount ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = render ==> ("MaxTagCount" => x)
    [<CustomOperation("ValueOnClear")>] member inline _.ValueOnClear ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItemValue) = render ==> ("ValueOnClear" => x)
    [<CustomOperation("ItemLabel")>] member inline _.ItemLabel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemLabel" => (System.Func<'TItem, System.String>fn))
    [<CustomOperation("ItemValue")>] member inline _.ItemValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemValue" => (System.Func<'TItem, 'TItemValue>fn))
    [<CustomOperation("LabelName")>] member inline _.LabelName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelName" => x)
    [<CustomOperation("ValueName")>] member inline _.ValueName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueName" => x)
    [<CustomOperation("OnMouseEnter")>] member inline _.OnMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Action) = render ==> ("OnMouseEnter" => x)
    [<CustomOperation("OnMouseLeave")>] member inline _.OnMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Action) = render ==> ("OnMouseLeave" => x)
    [<CustomOperation("PopupContainerSelector")>] member inline _.PopupContainerSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupContainerSelector" => x)
    [<CustomOperation("DropdownRender")>] member inline _.DropdownRender ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.RenderFragment -> NodeRenderFragment) = render ==> html.renderFragment("DropdownRender", fn)
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("LabelTemplate", fn)
    [<CustomOperation("MaxTagPlaceholder")>] member inline _.MaxTagPlaceholder ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("MaxTagPlaceholder", fn)
    [<CustomOperation("ShowSearchIcon")>] member inline _.ShowSearchIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSearchIcon" => (defaultArg x true))
    [<CustomOperation("ShowArrowIcon")>] member inline _.ShowArrowIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowArrowIcon" => (defaultArg x true))

type SelectBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SelectBaseBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem>()
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("EnableVirtualization")>] member inline _.EnableVirtualization ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("EnableVirtualization" => (defaultArg x true))
    [<CustomOperation("DataSource")>] member inline _.DataSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("DataSource" => x)
    [<CustomOperation("DataSourceEqualityComparer")>] member inline _.DataSourceEqualityComparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'TItem>) = render ==> ("DataSourceEqualityComparer" => x)
    [<CustomOperation("DefaultActiveFirstOption")>] member inline _.DefaultActiveFirstOption ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultActiveFirstOption" => (defaultArg x true))
    [<CustomOperation("DisabledName")>] member inline _.DisabledName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledName" => x)
    [<CustomOperation("DropdownMatchSelectWidth")>] member inline _.DropdownMatchSelectWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Boolean, System.String>) = render ==> ("DropdownMatchSelectWidth" => x)
    [<CustomOperation("DropdownMaxWidth")>] member inline _.DropdownMaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropdownMaxWidth" => x)
    [<CustomOperation("GroupName")>] member inline _.GroupName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupName" => x)
    [<CustomOperation("IgnoreItemChanges")>] member inline _.IgnoreItemChanges ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IgnoreItemChanges" => (defaultArg x true))
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    [<CustomOperation("NotFoundContent")>] member inline _.NotFoundContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("NotFoundContent", fragment)
    [<CustomOperation("NotFoundContent")>] member inline _.NotFoundContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("NotFoundContent", fragment { yield! fragments })
    [<CustomOperation("NotFoundContent")>] member inline _.NotFoundContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NotFoundContent", html.text x)
    [<CustomOperation("NotFoundContent")>] member inline _.NotFoundContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NotFoundContent", html.text x)
    [<CustomOperation("NotFoundContent")>] member inline _.NotFoundContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NotFoundContent", html.text x)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Action) = render ==> ("OnBlur" => x)
    [<CustomOperation("OnCreateCustomTag")>] member inline _.OnCreateCustomTag ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnCreateCustomTag" => (System.Action<System.String>fn))
    [<CustomOperation("OnDataSourceChanged")>] member inline _.OnDataSourceChanged ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Action) = render ==> ("OnDataSourceChanged" => x)
    [<CustomOperation("OnDropdownVisibleChange")>] member inline _.OnDropdownVisibleChange ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnDropdownVisibleChange" => (System.Action<System.Boolean>fn))
    [<CustomOperation("OnSearch")>] member inline _.OnSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnSearch" => (System.Action<System.String>fn))
    [<CustomOperation("FilterExpression")>] member inline _.FilterExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FilterExpression" => (System.Func<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>, System.String, System.Boolean>fn))
    [<CustomOperation("PopupContainerMaxHeight")>] member inline _.PopupContainerMaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupContainerMaxHeight" => x)
    [<CustomOperation("ShowArrowIcon")>] member inline _.ShowArrowIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowArrowIcon" => (defaultArg x true))
    [<CustomOperation("TokenSeparators")>] member inline _.TokenSeparators ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Char[]) = render ==> ("TokenSeparators" => x)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItemValue -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItemValue -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItemValue) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TItemValue * ('TItemValue -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("LabelProperty")>] member inline _.LabelProperty ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("LabelProperty" => (System.Func<'TItem, System.String>fn))
    [<CustomOperation("ValueProperty")>] member inline _.ValueProperty ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ValueProperty" => (System.Func<'TItem, 'TItemValue>fn))
    [<CustomOperation("DisabledPredicate")>] member inline _.DisabledPredicate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledPredicate" => (System.Func<'TItem, System.Boolean>fn))
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItemValue) = render ==> ("DefaultValue" => x)
    [<CustomOperation("ListboxStyle")>] member inline _.ListboxStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListboxStyle" => x)

type EnumSelectBuilder<'FunBlazorGeneric, 'TEnum when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SelectBuilder<'FunBlazorGeneric, 'TEnum, 'TEnum>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TEnum) = render ==> ("Value" => x)
    [<CustomOperation("Values")>] member inline _.Values ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TEnum>) = render ==> ("Values" => x)

type SimpleSelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SelectBuilder<'FunBlazorGeneric, System.String, System.String>()


type TreeSelectBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SelectBaseBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem>()
    [<CustomOperation("ShowExpand")>] member inline _.ShowExpand ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowExpand" => (defaultArg x true))
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Multiple" => (defaultArg x true))
    [<CustomOperation("TreeCheckable")>] member inline _.TreeCheckable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("TreeCheckable" => (defaultArg x true))
    [<CustomOperation("TreeCheckStrictly")>] member inline _.TreeCheckStrictly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("TreeCheckStrictly" => (defaultArg x true))
    [<CustomOperation("ShowCheckedStrategy")>] member inline _.ShowCheckedStrategy ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TreeCheckedStrategy) = render ==> ("ShowCheckedStrategy" => x)
    [<CustomOperation("CheckOnClickNode")>] member inline _.CheckOnClickNode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CheckOnClickNode" => (defaultArg x true))
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Action) = render ==> ("OnBlur" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("TitleTemplate", fn)
    [<CustomOperation("TitleIconTemplate")>] member inline _.TitleIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("TitleIconTemplate", fn)
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TreeNode<'TItem>[]) = render ==> ("Nodes" => x)
    [<CustomOperation("DataSource")>] member inline _.DataSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("DataSource" => x)
    [<CustomOperation("TreeDefaultExpandAll")>] member inline _.TreeDefaultExpandAll ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("TreeDefaultExpandAll" => (defaultArg x true))
    [<CustomOperation("TreeDefaultExpandParent")>] member inline _.TreeDefaultExpandParent ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("TreeDefaultExpandParent" => (defaultArg x true))
    [<CustomOperation("TreeDefaultExpandedKeys")>] member inline _.TreeDefaultExpandedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("TreeDefaultExpandedKeys" => x)
    [<CustomOperation("ExpandOnClickNode")>] member inline _.ExpandOnClickNode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ExpandOnClickNode" => (defaultArg x true))
    [<CustomOperation("SearchExpression")>] member inline _.SearchExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SearchExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn))
    [<CustomOperation("OnSearch")>] member inline _.OnSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("OnSearch", fn)
    [<CustomOperation("OnSearch")>] member inline _.OnSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnSearch", fn)
    [<CustomOperation("MatchedStyle")>] member inline _.MatchedStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MatchedStyle" => x)
    [<CustomOperation("MatchedClass")>] member inline _.MatchedClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MatchedClass" => x)
    [<CustomOperation("RootValue")>] member inline _.RootValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootValue" => x)
    [<CustomOperation("DropdownMatchSelectWidth")>] member inline _.DropdownMatchSelectWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Boolean, System.String>) = render ==> ("DropdownMatchSelectWidth" => x)
    [<CustomOperation("DropdownMaxWidth")>] member inline _.DropdownMaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropdownMaxWidth" => x)
    [<CustomOperation("PopupContainerMaxHeight")>] member inline _.PopupContainerMaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupContainerMaxHeight" => x)
    [<CustomOperation("DropdownStyle")>] member inline _.DropdownStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropdownStyle" => x)
    [<CustomOperation("ShowTreeLine")>] member inline _.ShowTreeLine ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowTreeLine" => (defaultArg x true))
    [<CustomOperation("ShowIcon")>] member inline _.ShowIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowIcon" => (defaultArg x true))
    [<CustomOperation("ShowLeafIcon")>] member inline _.ShowLeafIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowLeafIcon" => (defaultArg x true))
    [<CustomOperation("TreeAttributes")>] member inline _.TreeAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = render ==> ("TreeAttributes" => x)
    [<CustomOperation("OnNodeLoadDelayAsync")>] member inline _.OnNodeLoadDelayAsync ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnNodeLoadDelayAsync", fn)
    [<CustomOperation("OnNodeLoadDelayAsync")>] member inline _.OnNodeLoadDelayAsync ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnNodeLoadDelayAsync", fn)
    [<CustomOperation("OnTreeNodeSelect")>] member inline _.OnTreeNodeSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnTreeNodeSelect", fn)
    [<CustomOperation("OnTreeNodeSelect")>] member inline _.OnTreeNodeSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnTreeNodeSelect", fn)
    [<CustomOperation("TitleExpression")>] member inline _.TitleExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("TitleExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn))
    [<CustomOperation("KeyExpression")>] member inline _.KeyExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("KeyExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn))
    [<CustomOperation("IconExpression")>] member inline _.IconExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IconExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn))
    [<CustomOperation("IsLeafExpression")>] member inline _.IsLeafExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IsLeafExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn))
    [<CustomOperation("ChildrenExpression")>] member inline _.ChildrenExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ChildrenExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IEnumerable<'TItem>>fn))
    [<CustomOperation("DisabledExpression")>] member inline _.DisabledExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn))
    [<CustomOperation("CheckableExpression")>] member inline _.CheckableExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CheckableExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn))
    [<CustomOperation("ExpandedKeys")>] member inline _.ExpandedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("ExpandedKeys" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItemValue) = render ==> ("Value" => x)
    [<CustomOperation("Values")>] member inline _.Values ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItemValue>) = render ==> ("Values" => x)

type SliderBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("DefaultValue" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Dots")>] member inline _.Dots ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dots" => (defaultArg x true))
    [<CustomOperation("Included")>] member inline _.Included ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Included" => (defaultArg x true))
    [<CustomOperation("Marks")>] member inline _.Marks ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.SliderMark[]) = render ==> ("Marks" => x)
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Reverse" => (defaultArg x true))
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Step" => x)
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Vertical" => (defaultArg x true))
    [<CustomOperation("OnAfterChange")>] member inline _.OnAfterChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> unit) = render ==> html.callback("OnAfterChange", fn)
    [<CustomOperation("OnAfterChange")>] member inline _.OnAfterChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("OnAfterChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("HasTooltip")>] member inline _.HasTooltip ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HasTooltip" => (defaultArg x true))
    [<CustomOperation("TipFormatter")>] member inline _.TipFormatter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("TipFormatter" => (System.Func<System.Double, System.String>fn))
    [<CustomOperation("TooltipPlacement")>] member inline _.TooltipPlacement ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Placement) = render ==> ("TooltipPlacement" => x)
    [<CustomOperation("TooltipVisible")>] member inline _.TooltipVisible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("TooltipVisible" => (defaultArg x true))
    [<CustomOperation("GetTooltipPopupContainer")>] member inline _.GetTooltipPopupContainer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("GetTooltipPopupContainer" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)

type DescriptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("Layout")>] member inline _.Layout ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Layout" => x)
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>) = render ==> ("Column" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Colon")>] member inline _.Colon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Colon" => (defaultArg x true))

type DescriptionsItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Span")>] member inline _.Span ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Span" => x)
    [<CustomOperation("LabelStyle")>] member inline _.LabelStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelStyle" => x)
    [<CustomOperation("ContentStyle")>] member inline _.ContentStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)

type DividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    [<CustomOperation("Plain")>] member inline _.Plain ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Plain" => (defaultArg x true))
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.DirectionVHType) = render ==> ("Type" => x)
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Orientation" => x)
    [<CustomOperation("Dashed")>] member inline _.Dashed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Dashed" => (defaultArg x true))

type DrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = render ==> ("Content" => x)
    [<CustomOperation("Closable")>] member inline _.Closable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Closable" => (defaultArg x true))
    [<CustomOperation("MaskClosable")>] member inline _.MaskClosable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MaskClosable" => (defaultArg x true))
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Mask" => (defaultArg x true))
    [<CustomOperation("MaskStyle")>] member inline _.MaskStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaskStyle" => x)
    [<CustomOperation("Keyboard")>] member inline _.Keyboard ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Keyboard" => (defaultArg x true))
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = render ==> ("Title" => x)
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placement" => x)
    [<CustomOperation("BodyStyle")>] member inline _.BodyStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BodyStyle" => x)
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    [<CustomOperation("WrapClassName")>] member inline _.WrapClassName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("WrapClassName" => x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Height" => x)
    [<CustomOperation("ZIndex")>] member inline _.ZIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ZIndex" => x)
    [<CustomOperation("OffsetX")>] member inline _.OffsetX ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OffsetX" => x)
    [<CustomOperation("OffsetY")>] member inline _.OffsetY ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OffsetY" => x)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)
    [<CustomOperation("OnOpen")>] member inline _.OnOpen ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnOpen" => (System.Func<System.Threading.Tasks.Task>fn))
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClose", fn)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)
    [<CustomOperation("Handler")>] member inline _.Handler ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Handler", fragment)
    [<CustomOperation("Handler")>] member inline _.Handler ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Handler", fragment { yield! fragments })
    [<CustomOperation("Handler")>] member inline _.Handler ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Handler", html.text x)
    [<CustomOperation("Handler")>] member inline _.Handler ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Handler", html.text x)
    [<CustomOperation("Handler")>] member inline _.Handler ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Handler", html.text x)

type DrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type EmptyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("ImageStyle")>] member inline _.ImageStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImageStyle" => x)
    [<CustomOperation("Small")>] member inline _.Small ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Small" => (defaultArg x true))
    [<CustomOperation("Simple")>] member inline _.Simple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Simple" => (defaultArg x true))
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = render ==> ("Description" => x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DescriptionTemplate", fragment)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DescriptionTemplate", fragment { yield! fragments })
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    [<CustomOperation("ImageTemplate")>] member inline _.ImageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ImageTemplate", fragment)
    [<CustomOperation("ImageTemplate")>] member inline _.ImageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ImageTemplate", fragment { yield! fragments })
    [<CustomOperation("ImageTemplate")>] member inline _.ImageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ImageTemplate", html.text x)
    [<CustomOperation("ImageTemplate")>] member inline _.ImageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ImageTemplate", html.text x)
    [<CustomOperation("ImageTemplate")>] member inline _.ImageTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ImageTemplate", html.text x)

type FlexBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Vertical" => (defaultArg x true))
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Wrap" => x)
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Justify" => x)
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Align" => x)
    [<CustomOperation("FlexCss")>] member inline _.FlexCss ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FlexCss" => x)
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Gap" => x)
    [<CustomOperation("Component")>] member inline _.Component ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Component" => x)

type FormBuilder<'FunBlazorGeneric, 'TModel when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("RequiredMark")>] member inline _.RequiredMark ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.FormRequiredMark) = render ==> ("RequiredMark" => x)
    [<CustomOperation("Layout")>] member inline _.Layout ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Layout" => x)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TModel -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("LabelCol")>] member inline _.LabelCol ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ColLayoutParam) = render ==> ("LabelCol" => x)
    [<CustomOperation("LabelAlign")>] member inline _.LabelAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.AntLabelAlignType>) = render ==> ("LabelAlign" => x)
    [<CustomOperation("LabelColSpan")>] member inline _.LabelColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("LabelColSpan" => x)
    [<CustomOperation("LabelColOffset")>] member inline _.LabelColOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("LabelColOffset" => x)
    [<CustomOperation("WrapperCol")>] member inline _.WrapperCol ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ColLayoutParam) = render ==> ("WrapperCol" => x)
    [<CustomOperation("WrapperColSpan")>] member inline _.WrapperColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("WrapperColSpan" => x)
    [<CustomOperation("WrapperColOffset")>] member inline _.WrapperColOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("WrapperColOffset" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("Method")>] member inline _.Method ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Method" => x)
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TModel) = render ==> ("Model" => x)
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("OnFinish")>] member inline _.OnFinish ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.EditContext -> unit) = render ==> html.callback("OnFinish", fn)
    [<CustomOperation("OnFinish")>] member inline _.OnFinish ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.EditContext -> Task<unit>) = render ==> html.callbackTask("OnFinish", fn)
    [<CustomOperation("OnFinishFailed")>] member inline _.OnFinishFailed ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.EditContext -> unit) = render ==> html.callback("OnFinishFailed", fn)
    [<CustomOperation("OnFinishFailed")>] member inline _.OnFinishFailed ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.EditContext -> Task<unit>) = render ==> html.callbackTask("OnFinishFailed", fn)
    [<CustomOperation("OnFieldChanged")>] member inline _.OnFieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.FieldChangedEventArgs -> unit) = render ==> html.callback("OnFieldChanged", fn)
    [<CustomOperation("OnFieldChanged")>] member inline _.OnFieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.FieldChangedEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFieldChanged", fn)
    [<CustomOperation("OnValidationRequested")>] member inline _.OnValidationRequested ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.ValidationRequestedEventArgs -> unit) = render ==> html.callback("OnValidationRequested", fn)
    [<CustomOperation("OnValidationRequested")>] member inline _.OnValidationRequested ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.ValidationRequestedEventArgs -> Task<unit>) = render ==> html.callbackTask("OnValidationRequested", fn)
    [<CustomOperation("OnValidationStateChanged")>] member inline _.OnValidationStateChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.ValidationStateChangedEventArgs -> unit) = render ==> html.callback("OnValidationStateChanged", fn)
    [<CustomOperation("OnValidationStateChanged")>] member inline _.OnValidationStateChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Forms.ValidationStateChangedEventArgs -> Task<unit>) = render ==> html.callbackTask("OnValidationStateChanged", fn)
    [<CustomOperation("Validator")>] member inline _.Validator ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Validator", fragment)
    [<CustomOperation("Validator")>] member inline _.Validator ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Validator", fragment { yield! fragments })
    [<CustomOperation("Validator")>] member inline _.Validator ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Validator", html.text x)
    [<CustomOperation("Validator")>] member inline _.Validator ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Validator", html.text x)
    [<CustomOperation("Validator")>] member inline _.Validator ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Validator", html.text x)
    [<CustomOperation("ValidateOnChange")>] member inline _.ValidateOnChange ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ValidateOnChange" => (defaultArg x true))
    [<CustomOperation("ValidateMode")>] member inline _.ValidateMode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.FormValidateMode) = render ==> ("ValidateMode" => x)
    [<CustomOperation("ValidateMessages")>] member inline _.ValidateMessages ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.FormValidateErrorMessages) = render ==> ("ValidateMessages" => x)
    [<CustomOperation("Enhance")>] member inline _.Enhance ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Enhance" => (defaultArg x true))
    [<CustomOperation("Autocomplete")>] member inline _.Autocomplete ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Autocomplete" => x)

type FormItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LabelTemplate", fragment)
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LabelTemplate", fragment { yield! fragments })
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LabelTemplate", html.text x)
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LabelTemplate", html.text x)
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LabelTemplate", html.text x)
    [<CustomOperation("LabelCol")>] member inline _.LabelCol ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ColLayoutParam) = render ==> ("LabelCol" => x)
    [<CustomOperation("LabelAlign")>] member inline _.LabelAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.AntLabelAlignType>) = render ==> ("LabelAlign" => x)
    [<CustomOperation("LabelColSpan")>] member inline _.LabelColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("LabelColSpan" => x)
    [<CustomOperation("LabelColOffset")>] member inline _.LabelColOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("LabelColOffset" => x)
    [<CustomOperation("WrapperCol")>] member inline _.WrapperCol ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ColLayoutParam) = render ==> ("WrapperCol" => x)
    [<CustomOperation("WrapperColSpan")>] member inline _.WrapperColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("WrapperColSpan" => x)
    [<CustomOperation("WrapperColOffset")>] member inline _.WrapperColOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Int32>) = render ==> ("WrapperColOffset" => x)
    [<CustomOperation("NoStyle")>] member inline _.NoStyle ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("NoStyle" => (defaultArg x true))
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Required" => (defaultArg x true))
    [<CustomOperation("LabelStyle")>] member inline _.LabelStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelStyle" => x)
    [<CustomOperation("Rules")>] member inline _.Rules ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.FormValidationRule[]) = render ==> ("Rules" => x)
    [<CustomOperation("HasFeedback")>] member inline _.HasFeedback ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HasFeedback" => (defaultArg x true))
    [<CustomOperation("ShowFeedbackOnError")>] member inline _.ShowFeedbackOnError ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowFeedbackOnError" => (defaultArg x true))
    [<CustomOperation("ValidateStatus")>] member inline _.ValidateStatus ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.FormValidateStatus) = render ==> ("ValidateStatus" => x)
    [<CustomOperation("Help")>] member inline _.Help ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Help" => x)

type ImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Alt")>] member inline _.Alt ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Alt" => x)
    [<CustomOperation("Fallback")>] member inline _.Fallback ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Fallback" => x)
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Placeholder", fragment)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Placeholder", fragment { yield! fragments })
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Placeholder", html.text x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Placeholder", html.text x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Placeholder", html.text x)
    [<CustomOperation("Preview")>] member inline _.Preview ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Preview" => (defaultArg x true))
    [<CustomOperation("PreviewVisible")>] member inline _.PreviewVisible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("PreviewVisible" => (defaultArg x true))
    [<CustomOperation("PreviewVisible'")>] member inline _.PreviewVisible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("PreviewVisible", valueFn)
    [<CustomOperation("Src")>] member inline _.Src ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Src" => x)
    [<CustomOperation("PreviewSrc")>] member inline _.PreviewSrc ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviewSrc" => x)
    [<CustomOperation("PreviewVisibleChanged")>] member inline _.PreviewVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("PreviewVisibleChanged", fn)
    [<CustomOperation("PreviewVisibleChanged")>] member inline _.PreviewVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("PreviewVisibleChanged", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ImageLocale) = render ==> ("Locale" => x)

type ImagePreviewContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type InputGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Compact")>] member inline _.Compact ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Compact" => (defaultArg x true))
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)

type SiderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Collapsible")>] member inline _.Collapsible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Collapsible" => (defaultArg x true))
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Trigger", fragment)
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Trigger", fragment { yield! fragments })
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Trigger", html.text x)
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Trigger", html.text x)
    [<CustomOperation("Trigger")>] member inline _.Trigger ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Trigger", html.text x)
    [<CustomOperation("NoTrigger")>] member inline _.NoTrigger ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("NoTrigger" => (defaultArg x true))
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.BreakpointType>) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.SiderTheme) = render ==> ("Theme" => x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Width" => x)
    [<CustomOperation("CollapsedWidth")>] member inline _.CollapsedWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("CollapsedWidth" => x)
    [<CustomOperation("Collapsed")>] member inline _.Collapsed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Collapsed" => (defaultArg x true))
    [<CustomOperation("Collapsed'")>] member inline _.Collapsed' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Collapsed", valueFn)
    [<CustomOperation("CollapsedChanged")>] member inline _.CollapsedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("CollapsedChanged", fn)
    [<CustomOperation("CollapsedChanged")>] member inline _.CollapsedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CollapsedChanged", fn)
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnCollapse", fn)
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnCollapse", fn)
    [<CustomOperation("OnBreakpoint")>] member inline _.OnBreakpoint ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnBreakpoint", fn)
    [<CustomOperation("OnBreakpoint")>] member inline _.OnBreakpoint ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnBreakpoint", fn)
    [<CustomOperation("DefaultCollapsed")>] member inline _.DefaultCollapsed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultCollapsed" => (defaultArg x true))

type AntListBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataSource")>] member inline _.DataSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("DataSource" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Header", fragment)
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Footer", fragment)
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Footer", fragment { yield! fragments })
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Footer", html.text x)
    [<CustomOperation("LoadMore")>] member inline _.LoadMore ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LoadMore", fragment)
    [<CustomOperation("LoadMore")>] member inline _.LoadMore ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LoadMore", fragment { yield! fragments })
    [<CustomOperation("LoadMore")>] member inline _.LoadMore ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadMore", html.text x)
    [<CustomOperation("LoadMore")>] member inline _.LoadMore ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadMore", html.text x)
    [<CustomOperation("LoadMore")>] member inline _.LoadMore ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadMore", html.text x)
    [<CustomOperation("ItemLayout")>] member inline _.ItemLayout ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ListItemLayout) = render ==> ("ItemLayout" => x)
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("NoResult")>] member inline _.NoResult ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoResult" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Split")>] member inline _.Split ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Split" => (defaultArg x true))
    [<CustomOperation("Grid")>] member inline _.Grid ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ListGridType) = render ==> ("Grid" => x)
    [<CustomOperation("Pagination")>] member inline _.Pagination ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.PaginationOptions) = render ==> ("Pagination" => x)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)

type ListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Content" => x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Extra", fragment)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Extra", fragment { yield! fragments })
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Actions")>] member inline _.Actions ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.RenderFragment[]) = render ==> ("Actions" => x)
    [<CustomOperation("ColStyle")>] member inline _.ColStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ColStyle" => x)
    [<CustomOperation("ItemCount")>] member inline _.ItemCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ItemCount" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("NoFlex")>] member inline _.NoFlex ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("NoFlex" => (defaultArg x true))

type ListItemMetaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Avatar")>] member inline _.Avatar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AvatarTemplate", fragment)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AvatarTemplate", fragment { yield! fragments })
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AvatarTemplate", html.text x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AvatarTemplate", html.text x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AvatarTemplate", html.text x)
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Description" => x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DescriptionTemplate", fragment)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DescriptionTemplate", fragment { yield! fragments })
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DescriptionTemplate", html.text x)

type MentionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Disable")>] member inline _.Disable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disable" => (defaultArg x true))
    [<CustomOperation("Rows")>] member inline _.Rows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.UInt32) = render ==> ("Rows" => x)
    [<CustomOperation("Focused")>] member inline _.Focused ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Focused" => (defaultArg x true))
    [<CustomOperation("Readonly")>] member inline _.Readonly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Readonly" => (defaultArg x true))
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("LoadOptions")>] member inline _.LoadOptions ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("LoadOptions" => (System.Func<System.String, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<AntDesign.MentionsDynamicOption>>>fn))
    [<CustomOperation("TextareaTemplate")>] member inline _.TextareaTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.MentionsTextareaTemplateOptions -> NodeRenderFragment) = render ==> html.renderFragment("TextareaTemplate", fn)
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Prefix" => x)

type MentionsOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)

type MenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.MenuTheme) = render ==> ("Theme" => x)
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnSubmenuClicked")>] member inline _.OnSubmenuClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.SubMenu -> unit) = render ==> html.callback("OnSubmenuClicked", fn)
    [<CustomOperation("OnSubmenuClicked")>] member inline _.OnSubmenuClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.SubMenu -> Task<unit>) = render ==> html.callbackTask("OnSubmenuClicked", fn)
    [<CustomOperation("OnMenuItemClicked")>] member inline _.OnMenuItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.MenuItem -> unit) = render ==> html.callback("OnMenuItemClicked", fn)
    [<CustomOperation("OnMenuItemClicked")>] member inline _.OnMenuItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.MenuItem -> Task<unit>) = render ==> html.callbackTask("OnMenuItemClicked", fn)
    [<CustomOperation("Accordion")>] member inline _.Accordion ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Accordion" => (defaultArg x true))
    [<CustomOperation("Selectable")>] member inline _.Selectable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Selectable" => (defaultArg x true))
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Multiple" => (defaultArg x true))
    [<CustomOperation("InlineCollapsed")>] member inline _.InlineCollapsed ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("InlineCollapsed" => (defaultArg x true))
    [<CustomOperation("InlineIndent")>] member inline _.InlineIndent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("InlineIndent" => x)
    [<CustomOperation("AutoCloseDropdown")>] member inline _.AutoCloseDropdown ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoCloseDropdown" => (defaultArg x true))
    [<CustomOperation("DefaultSelectedKeys")>] member inline _.DefaultSelectedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("DefaultSelectedKeys" => x)
    [<CustomOperation("DefaultOpenKeys")>] member inline _.DefaultOpenKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("DefaultOpenKeys" => x)
    [<CustomOperation("OpenKeys")>] member inline _.OpenKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
    [<CustomOperation("OpenKeys'")>] member inline _.OpenKeys' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("OpenKeys", valueFn)
    [<CustomOperation("OpenKeysChanged")>] member inline _.OpenKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> unit) = render ==> html.callback("OpenKeysChanged", fn)
    [<CustomOperation("OpenKeysChanged")>] member inline _.OpenKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("OpenKeysChanged", fn)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> unit) = render ==> html.callback("OnOpenChange", fn)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("OnOpenChange", fn)
    [<CustomOperation("SelectedKeys")>] member inline _.SelectedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("SelectedKeys" => x)
    [<CustomOperation("SelectedKeys'")>] member inline _.SelectedKeys' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("SelectedKeys", valueFn)
    [<CustomOperation("SelectedKeysChanged")>] member inline _.SelectedKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> unit) = render ==> html.callback("SelectedKeysChanged", fn)
    [<CustomOperation("SelectedKeysChanged")>] member inline _.SelectedKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("SelectedKeysChanged", fn)
    [<CustomOperation("TriggerSubMenuAction")>] member inline _.TriggerSubMenuAction ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Trigger) = render ==> ("TriggerSubMenuAction" => x)
    [<CustomOperation("ShowCollapsedTooltip")>] member inline _.ShowCollapsedTooltip ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowCollapsedTooltip" => (defaultArg x true))
    [<CustomOperation("Animation")>] member inline _.Animation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Animation" => (defaultArg x true))

type MenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Key")>] member inline _.Key ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Key" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("RouterLink")>] member inline _.RouterLink ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RouterLink" => x)
    [<CustomOperation("RouterMatch")>] member inline _.RouterMatch ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("RouterMatch" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("IconTemplate", fragment)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("IconTemplate", fragment { yield! fragments })
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("IconTemplate", html.text x)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("IconTemplate", html.text x)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("IconTemplate", html.text x)

type MenuItemGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Key")>] member inline _.Key ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Key" => x)

type MenuLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("Attributes" => x)
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)

type SubMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.Placement>) = render ==> ("Placement" => x)
    [<CustomOperation("PopupClassName")>] member inline _.PopupClassName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopupClassName" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Key")>] member inline _.Key ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Key" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("IsOpen")>] member inline _.IsOpen ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsOpen" => (defaultArg x true))
    [<CustomOperation("OnTitleClick")>] member inline _.OnTitleClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnTitleClick", fn)
    [<CustomOperation("OnTitleClick")>] member inline _.OnTitleClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnTitleClick", fn)

type MessageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type MessageItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Config")>] member inline _.Config ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.MessageConfig) = render ==> ("Config" => x)

type ComfirmContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type ConfirmBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Config")>] member inline _.Config ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ConfirmOptions) = render ==> ("Config" => x)
    [<CustomOperation("ConfirmRef")>] member inline _.ConfirmRef ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ConfirmRef) = render ==> ("ConfirmRef" => x)
    [<CustomOperation("OnRemove")>] member inline _.OnRemove ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.ConfirmRef -> unit) = render ==> html.callback("OnRemove", fn)
    [<CustomOperation("OnRemove")>] member inline _.OnRemove ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.ConfirmRef -> Task<unit>) = render ==> html.callbackTask("OnRemove", fn)

type DialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Config")>] member inline _.Config ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.DialogOptions) = render ==> ("Config" => x)
    [<CustomOperation("AdditionalContent")>] member inline _.AdditionalContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AdditionalContent", fragment)
    [<CustomOperation("AdditionalContent")>] member inline _.AdditionalContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AdditionalContent", fragment { yield! fragments })
    [<CustomOperation("AdditionalContent")>] member inline _.AdditionalContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AdditionalContent", html.text x)
    [<CustomOperation("AdditionalContent")>] member inline _.AdditionalContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AdditionalContent", html.text x)
    [<CustomOperation("AdditionalContent")>] member inline _.AdditionalContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AdditionalContent", html.text x)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)

type DialogWrapperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Config")>] member inline _.Config ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.DialogOptions) = render ==> ("Config" => x)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
    [<CustomOperation("OnBeforeDestroy")>] member inline _.OnBeforeDestroy ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.ComponentModel.CancelEventArgs -> unit) = render ==> html.callback("OnBeforeDestroy", fn)
    [<CustomOperation("OnBeforeDestroy")>] member inline _.OnBeforeDestroy ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.ComponentModel.CancelEventArgs -> Task<unit>) = render ==> html.callbackTask("OnBeforeDestroy", fn)
    [<CustomOperation("OnAfterShow")>] member inline _.OnAfterShow ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnAfterShow", fn)
    [<CustomOperation("OnAfterShow")>] member inline _.OnAfterShow ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnAfterShow", fn)
    [<CustomOperation("OnAfterHide")>] member inline _.OnAfterHide ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnAfterHide", fn)
    [<CustomOperation("OnAfterHide")>] member inline _.OnAfterHide ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnAfterHide", fn)

type ModalBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ModalRef")>] member inline _.ModalRef ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ModalRef) = render ==> ("ModalRef" => x)
    [<CustomOperation("AfterClose")>] member inline _.AfterClose ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("AfterClose" => (System.Func<System.Threading.Tasks.Task>fn))
    [<CustomOperation("BodyStyle")>] member inline _.BodyStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BodyStyle" => x)
    [<CustomOperation("CancelText")>] member inline _.CancelText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = render ==> ("CancelText" => x)
    [<CustomOperation("Centered")>] member inline _.Centered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Centered" => (defaultArg x true))
    [<CustomOperation("Closable")>] member inline _.Closable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Closable" => (defaultArg x true))
    [<CustomOperation("Draggable")>] member inline _.Draggable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Draggable" => (defaultArg x true))
    [<CustomOperation("DragInViewport")>] member inline _.DragInViewport ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DragInViewport" => (defaultArg x true))
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CloseIcon", fragment)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CloseIcon", fragment { yield! fragments })
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CloseIcon", html.text x)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CloseIcon", html.text x)
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CloseIcon", html.text x)
    [<CustomOperation("ConfirmLoading")>] member inline _.ConfirmLoading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ConfirmLoading" => (defaultArg x true))
    [<CustomOperation("DestroyOnClose")>] member inline _.DestroyOnClose ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DestroyOnClose" => (defaultArg x true))
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Header", fragment)
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = render ==> ("Footer" => x)
    [<CustomOperation("GetContainer")>] member inline _.GetContainer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = render ==> ("GetContainer" => x)
    [<CustomOperation("Keyboard")>] member inline _.Keyboard ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Keyboard" => (defaultArg x true))
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Mask" => (defaultArg x true))
    [<CustomOperation("MaskClosable")>] member inline _.MaskClosable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("MaskClosable" => (defaultArg x true))
    [<CustomOperation("MaskStyle")>] member inline _.MaskStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaskStyle" => x)
    [<CustomOperation("OkText")>] member inline _.OkText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = render ==> ("OkText" => x)
    [<CustomOperation("OkType")>] member inline _.OkType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OkType" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Double>) = render ==> ("Width" => x)
    [<CustomOperation("WrapClassName")>] member inline _.WrapClassName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("WrapClassName" => x)
    [<CustomOperation("ZIndex")>] member inline _.ZIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ZIndex" => x)
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnCancel", fn)
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCancel", fn)
    [<CustomOperation("OnOk")>] member inline _.OnOk ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnOk", fn)
    [<CustomOperation("OnOk")>] member inline _.OnOk ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnOk", fn)
    [<CustomOperation("OkButtonProps")>] member inline _.OkButtonProps ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ButtonProps) = render ==> ("OkButtonProps" => x)
    [<CustomOperation("CancelButtonProps")>] member inline _.CancelButtonProps ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ButtonProps) = render ==> ("CancelButtonProps" => x)
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ModalLocale) = render ==> ("Locale" => x)
    [<CustomOperation("MaxBodyHeight")>] member inline _.MaxBodyHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxBodyHeight" => x)
    [<CustomOperation("Maximizable")>] member inline _.Maximizable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Maximizable" => (defaultArg x true))
    [<CustomOperation("MaximizeBtnIcon")>] member inline _.MaximizeBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MaximizeBtnIcon", fragment)
    [<CustomOperation("MaximizeBtnIcon")>] member inline _.MaximizeBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MaximizeBtnIcon", fragment { yield! fragments })
    [<CustomOperation("MaximizeBtnIcon")>] member inline _.MaximizeBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MaximizeBtnIcon", html.text x)
    [<CustomOperation("MaximizeBtnIcon")>] member inline _.MaximizeBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MaximizeBtnIcon", html.text x)
    [<CustomOperation("MaximizeBtnIcon")>] member inline _.MaximizeBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MaximizeBtnIcon", html.text x)
    [<CustomOperation("RestoreBtnIcon")>] member inline _.RestoreBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("RestoreBtnIcon", fragment)
    [<CustomOperation("RestoreBtnIcon")>] member inline _.RestoreBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("RestoreBtnIcon", fragment { yield! fragments })
    [<CustomOperation("RestoreBtnIcon")>] member inline _.RestoreBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("RestoreBtnIcon", html.text x)
    [<CustomOperation("RestoreBtnIcon")>] member inline _.RestoreBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("RestoreBtnIcon", html.text x)
    [<CustomOperation("RestoreBtnIcon")>] member inline _.RestoreBtnIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("RestoreBtnIcon", html.text x)
    [<CustomOperation("DefaultMaximized")>] member inline _.DefaultMaximized ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultMaximized" => (defaultArg x true))
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Resizable" => (defaultArg x true))

type ModalCancelFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type ModalContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type ModalFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type ModalOkFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type PageHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Ghost")>] member inline _.Ghost ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Ghost" => (defaultArg x true))
    [<CustomOperation("BackIcon")>] member inline _.BackIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = render ==> ("BackIcon" => x)
    [<CustomOperation("BackIconTemplate")>] member inline _.BackIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("BackIconTemplate", fragment)
    [<CustomOperation("BackIconTemplate")>] member inline _.BackIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("BackIconTemplate", fragment { yield! fragments })
    [<CustomOperation("BackIconTemplate")>] member inline _.BackIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("BackIconTemplate", html.text x)
    [<CustomOperation("BackIconTemplate")>] member inline _.BackIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("BackIconTemplate", html.text x)
    [<CustomOperation("BackIconTemplate")>] member inline _.BackIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("BackIconTemplate", html.text x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Subtitle")>] member inline _.Subtitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Subtitle" => x)
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SubtitleTemplate", fragment)
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SubtitleTemplate", fragment { yield! fragments })
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SubtitleTemplate", html.text x)
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SubtitleTemplate", html.text x)
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SubtitleTemplate", html.text x)
    [<CustomOperation("OnBack")>] member inline _.OnBack ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnBack", fn)
    [<CustomOperation("OnBack")>] member inline _.OnBack ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnBack", fn)
    [<CustomOperation("PageHeaderContent")>] member inline _.PageHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PageHeaderContent", fragment)
    [<CustomOperation("PageHeaderContent")>] member inline _.PageHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PageHeaderContent", fragment { yield! fragments })
    [<CustomOperation("PageHeaderContent")>] member inline _.PageHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PageHeaderContent", html.text x)
    [<CustomOperation("PageHeaderContent")>] member inline _.PageHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PageHeaderContent", html.text x)
    [<CustomOperation("PageHeaderContent")>] member inline _.PageHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PageHeaderContent", html.text x)
    [<CustomOperation("PageHeaderFooter")>] member inline _.PageHeaderFooter ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PageHeaderFooter", fragment)
    [<CustomOperation("PageHeaderFooter")>] member inline _.PageHeaderFooter ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PageHeaderFooter", fragment { yield! fragments })
    [<CustomOperation("PageHeaderFooter")>] member inline _.PageHeaderFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PageHeaderFooter", html.text x)
    [<CustomOperation("PageHeaderFooter")>] member inline _.PageHeaderFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PageHeaderFooter", html.text x)
    [<CustomOperation("PageHeaderFooter")>] member inline _.PageHeaderFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PageHeaderFooter", html.text x)
    [<CustomOperation("PageHeaderBreadcrumb")>] member inline _.PageHeaderBreadcrumb ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PageHeaderBreadcrumb", fragment)
    [<CustomOperation("PageHeaderBreadcrumb")>] member inline _.PageHeaderBreadcrumb ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PageHeaderBreadcrumb", fragment { yield! fragments })
    [<CustomOperation("PageHeaderBreadcrumb")>] member inline _.PageHeaderBreadcrumb ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PageHeaderBreadcrumb", html.text x)
    [<CustomOperation("PageHeaderBreadcrumb")>] member inline _.PageHeaderBreadcrumb ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PageHeaderBreadcrumb", html.text x)
    [<CustomOperation("PageHeaderBreadcrumb")>] member inline _.PageHeaderBreadcrumb ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PageHeaderBreadcrumb", html.text x)
    [<CustomOperation("PageHeaderAvatar")>] member inline _.PageHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PageHeaderAvatar", fragment)
    [<CustomOperation("PageHeaderAvatar")>] member inline _.PageHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PageHeaderAvatar", fragment { yield! fragments })
    [<CustomOperation("PageHeaderAvatar")>] member inline _.PageHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PageHeaderAvatar", html.text x)
    [<CustomOperation("PageHeaderAvatar")>] member inline _.PageHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PageHeaderAvatar", html.text x)
    [<CustomOperation("PageHeaderAvatar")>] member inline _.PageHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PageHeaderAvatar", html.text x)
    [<CustomOperation("PageHeaderTitle")>] member inline _.PageHeaderTitle ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PageHeaderTitle", fragment)
    [<CustomOperation("PageHeaderTitle")>] member inline _.PageHeaderTitle ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PageHeaderTitle", fragment { yield! fragments })
    [<CustomOperation("PageHeaderTitle")>] member inline _.PageHeaderTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PageHeaderTitle", html.text x)
    [<CustomOperation("PageHeaderTitle")>] member inline _.PageHeaderTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PageHeaderTitle", html.text x)
    [<CustomOperation("PageHeaderTitle")>] member inline _.PageHeaderTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PageHeaderTitle", html.text x)
    [<CustomOperation("PageHeaderSubtitle")>] member inline _.PageHeaderSubtitle ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PageHeaderSubtitle", fragment)
    [<CustomOperation("PageHeaderSubtitle")>] member inline _.PageHeaderSubtitle ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PageHeaderSubtitle", fragment { yield! fragments })
    [<CustomOperation("PageHeaderSubtitle")>] member inline _.PageHeaderSubtitle ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PageHeaderSubtitle", html.text x)
    [<CustomOperation("PageHeaderSubtitle")>] member inline _.PageHeaderSubtitle ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PageHeaderSubtitle", html.text x)
    [<CustomOperation("PageHeaderSubtitle")>] member inline _.PageHeaderSubtitle ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PageHeaderSubtitle", html.text x)
    [<CustomOperation("PageHeaderTags")>] member inline _.PageHeaderTags ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PageHeaderTags", fragment)
    [<CustomOperation("PageHeaderTags")>] member inline _.PageHeaderTags ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PageHeaderTags", fragment { yield! fragments })
    [<CustomOperation("PageHeaderTags")>] member inline _.PageHeaderTags ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PageHeaderTags", html.text x)
    [<CustomOperation("PageHeaderTags")>] member inline _.PageHeaderTags ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PageHeaderTags", html.text x)
    [<CustomOperation("PageHeaderTags")>] member inline _.PageHeaderTags ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PageHeaderTags", html.text x)
    [<CustomOperation("PageHeaderExtra")>] member inline _.PageHeaderExtra ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PageHeaderExtra", fragment)
    [<CustomOperation("PageHeaderExtra")>] member inline _.PageHeaderExtra ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PageHeaderExtra", fragment { yield! fragments })
    [<CustomOperation("PageHeaderExtra")>] member inline _.PageHeaderExtra ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PageHeaderExtra", html.text x)
    [<CustomOperation("PageHeaderExtra")>] member inline _.PageHeaderExtra ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PageHeaderExtra", html.text x)
    [<CustomOperation("PageHeaderExtra")>] member inline _.PageHeaderExtra ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PageHeaderExtra", html.text x)

type PaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Total")>] member inline _.Total ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Total" => x)
    [<CustomOperation("DefaultCurrent")>] member inline _.DefaultCurrent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DefaultCurrent" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Current")>] member inline _.Current ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Current" => x)
    [<CustomOperation("DefaultPageSize")>] member inline _.DefaultPageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DefaultPageSize" => x)
    [<CustomOperation("PageSize")>] member inline _.PageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageSize" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationEventArgs -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationEventArgs -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("HideOnSinglePage")>] member inline _.HideOnSinglePage ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideOnSinglePage" => (defaultArg x true))
    [<CustomOperation("ShowSizeChanger")>] member inline _.ShowSizeChanger ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSizeChanger" => (defaultArg x true))
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    [<CustomOperation("OnShowSizeChange")>] member inline _.OnShowSizeChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationEventArgs -> unit) = render ==> html.callback("OnShowSizeChange", fn)
    [<CustomOperation("OnShowSizeChange")>] member inline _.OnShowSizeChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationEventArgs -> Task<unit>) = render ==> html.callbackTask("OnShowSizeChange", fn)
    [<CustomOperation("ShowQuickJumper")>] member inline _.ShowQuickJumper ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowQuickJumper" => (defaultArg x true))
    [<CustomOperation("GoButton")>] member inline _.GoButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("GoButton", fragment)
    [<CustomOperation("GoButton")>] member inline _.GoButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("GoButton", fragment { yield! fragments })
    [<CustomOperation("GoButton")>] member inline _.GoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("GoButton", html.text x)
    [<CustomOperation("GoButton")>] member inline _.GoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("GoButton", html.text x)
    [<CustomOperation("GoButton")>] member inline _.GoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("GoButton", html.text x)
    [<CustomOperation("ShowTitle")>] member inline _.ShowTitle ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowTitle" => (defaultArg x true))
    [<CustomOperation("ShowTotal")>] member inline _.ShowTotal ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = render ==> ("ShowTotal" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.PaginationSize) = render ==> ("Size" => x)
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Responsive" => (defaultArg x true))
    [<CustomOperation("Simple")>] member inline _.Simple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Simple" => (defaultArg x true))
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.PaginationLocale) = render ==> ("Locale" => x)
    [<CustomOperation("ItemRender")>] member inline _.ItemRender ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = render ==> html.renderFragment("ItemRender", fn)
    [<CustomOperation("ShowLessItems")>] member inline _.ShowLessItems ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowLessItems" => (defaultArg x true))
    [<CustomOperation("ShowPrevNextJumpers")>] member inline _.ShowPrevNextJumpers ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowPrevNextJumpers" => (defaultArg x true))
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Direction" => x)
    [<CustomOperation("PrevIcon")>] member inline _.PrevIcon ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = render ==> html.renderFragment("PrevIcon", fn)
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = render ==> html.renderFragment("NextIcon", fn)
    [<CustomOperation("JumpPrevIcon")>] member inline _.JumpPrevIcon ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = render ==> html.renderFragment("JumpPrevIcon", fn)
    [<CustomOperation("JumpNextIcon")>] member inline _.JumpNextIcon ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = render ==> html.renderFragment("JumpNextIcon", fn)
    [<CustomOperation("TotalBoundaryShowSizeChanger")>] member inline _.TotalBoundaryShowSizeChanger ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TotalBoundaryShowSizeChanger" => x)
    [<CustomOperation("UnmatchedAttributes")>] member inline _.UnmatchedAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("UnmatchedAttributes" => x)

type PaginationOptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("IsSmall")>] member inline _.IsSmall ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsSmall" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("RootPrefixCls")>] member inline _.RootPrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootPrefixCls" => x)
    [<CustomOperation("ChangeSize")>] member inline _.ChangeSize ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("ChangeSize", fn)
    [<CustomOperation("ChangeSize")>] member inline _.ChangeSize ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ChangeSize", fn)
    [<CustomOperation("Current")>] member inline _.Current ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Current" => x)
    [<CustomOperation("PageSize")>] member inline _.PageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageSize" => x)
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    [<CustomOperation("QuickGo")>] member inline _.QuickGo ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("QuickGo", fn)
    [<CustomOperation("QuickGo")>] member inline _.QuickGo ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("QuickGo", fn)
    [<CustomOperation("GoButton")>] member inline _.GoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = render ==> ("GoButton" => x)
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.PaginationLocale) = render ==> ("Locale" => x)

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ProgressSize) = render ==> ("Size" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ProgressType) = render ==> ("Type" => x)
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Format" => (System.Func<System.Double, System.String>fn))
    [<CustomOperation("Percent")>] member inline _.Percent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Percent" => x)
    [<CustomOperation("ShowInfo")>] member inline _.ShowInfo ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowInfo" => (defaultArg x true))
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ProgressStatus) = render ==> ("Status" => x)
    [<CustomOperation("StrokeLinecap")>] member inline _.StrokeLinecap ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ProgressStrokeLinecap) = render ==> ("StrokeLinecap" => x)
    [<CustomOperation("SuccessPercent")>] member inline _.SuccessPercent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("SuccessPercent" => x)
    [<CustomOperation("TrailColor")>] member inline _.TrailColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TrailColor" => x)
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)
    [<CustomOperation("StrokeColor")>] member inline _.StrokeColor ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>) = render ==> ("StrokeColor" => x)
    [<CustomOperation("Steps")>] member inline _.Steps ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Steps" => x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Width" => x)
    [<CustomOperation("GapDegree")>] member inline _.GapDegree ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("GapDegree" => x)
    [<CustomOperation("GapPosition")>] member inline _.GapPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ProgressGapPosition) = render ==> ("GapPosition" => x)

type RadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoFocus" => (defaultArg x true))
    [<CustomOperation("RadioButton")>] member inline _.RadioButton ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("RadioButton" => (defaultArg x true))
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Checked" => (defaultArg x true))
    [<CustomOperation("Checked'")>] member inline _.Checked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Checked", valueFn)
    [<CustomOperation("DefaultChecked")>] member inline _.DefaultChecked ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultChecked" => (defaultArg x true))
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("CheckedChanged", fn)
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CheckedChanged", fn)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("CheckedChange")>] member inline _.CheckedChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("CheckedChange", fn)
    [<CustomOperation("CheckedChange")>] member inline _.CheckedChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CheckedChange", fn)

type RateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowClear" => (defaultArg x true))
    [<CustomOperation("AllowHalf")>] member inline _.AllowHalf ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowHalf" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoFocus" => (defaultArg x true))
    [<CustomOperation("Character")>] member inline _.Character ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.RateItemRenderContext -> NodeRenderFragment) = render ==> html.renderFragment("Character", fn)
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Decimal) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Decimal * (System.Decimal -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Decimal -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Decimal -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Decimal) = render ==> ("DefaultValue" => x)
    [<CustomOperation("Tooltips")>] member inline _.Tooltips ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("Tooltips" => x)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnBlur", fn)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnBlur", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnFocus", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFocus", fn)

type RateItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AllowHalf")>] member inline _.AllowHalf ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowHalf" => (defaultArg x true))
    [<CustomOperation("OnItemHover")>] member inline _.OnItemHover ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnItemHover", fn)
    [<CustomOperation("OnItemHover")>] member inline _.OnItemHover ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnItemHover", fn)
    [<CustomOperation("OnItemClick")>] member inline _.OnItemClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("OnItemClick", fn)
    [<CustomOperation("OnItemClick")>] member inline _.OnItemClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnItemClick", fn)
    [<CustomOperation("Tooltip")>] member inline _.Tooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tooltip" => x)
    [<CustomOperation("IndexOfGroup")>] member inline _.IndexOfGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("IndexOfGroup" => x)
    [<CustomOperation("HoverValue")>] member inline _.HoverValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HoverValue" => x)
    [<CustomOperation("HasHalf")>] member inline _.HasHalf ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HasHalf" => (defaultArg x true))
    [<CustomOperation("IsFocused")>] member inline _.IsFocused ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsFocused" => (defaultArg x true))

type ResultBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("SubTitle")>] member inline _.SubTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SubTitle" => x)
    [<CustomOperation("SubTitleTemplate")>] member inline _.SubTitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SubTitleTemplate", fragment)
    [<CustomOperation("SubTitleTemplate")>] member inline _.SubTitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SubTitleTemplate", fragment { yield! fragments })
    [<CustomOperation("SubTitleTemplate")>] member inline _.SubTitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SubTitleTemplate", html.text x)
    [<CustomOperation("SubTitleTemplate")>] member inline _.SubTitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SubTitleTemplate", html.text x)
    [<CustomOperation("SubTitleTemplate")>] member inline _.SubTitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SubTitleTemplate", html.text x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Extra", fragment)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Extra", fragment { yield! fragments })
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Extra")>] member inline _.Extra ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Status" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IsShowIcon")>] member inline _.IsShowIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsShowIcon" => (defaultArg x true))

type SegmentedBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("DefaultValue" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<AntDesign.SegmentedOption<'TValue>>) = render ==> ("Options" => x)
    [<CustomOperation("Labels")>] member inline _.Labels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TValue>) = render ==> ("Labels" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.SegmentedSize) = render ==> ("Size" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TValue * ('TValue -> unit)) = render ==> html.bind("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> unit) = render ==> html.callback("ValueChanged", fn)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TValue -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    [<CustomOperation("Block")>] member inline _.Block ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Block" => (defaultArg x true))

type SegmentedItemBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TValue) = render ==> ("Value" => x)
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)

type SelectOptionBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItemValue) = render ==> ("Value" => x)
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("Item" => x)

type SimpleSelectOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SelectOptionBuilder<'FunBlazorGeneric, System.String, System.String>()


type SkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Active")>] member inline _.Active ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Active" => (defaultArg x true))
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Title" => (defaultArg x true))
    [<CustomOperation("TitleWidth")>] member inline _.TitleWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = render ==> ("TitleWidth" => x)
    [<CustomOperation("Avatar")>] member inline _.Avatar ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Avatar" => (defaultArg x true))
    [<CustomOperation("AvatarSize")>] member inline _.AvatarSize ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = render ==> ("AvatarSize" => x)
    [<CustomOperation("AvatarShape")>] member inline _.AvatarShape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AvatarShape" => x)
    [<CustomOperation("Paragraph")>] member inline _.Paragraph ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Paragraph" => (defaultArg x true))
    [<CustomOperation("ParagraphRows")>] member inline _.ParagraphRows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("ParagraphRows" => x)
    [<CustomOperation("ParagraphWidth")>] member inline _.ParagraphWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IList<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = render ==> ("ParagraphWidth" => x)

type SkeletonElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Active")>] member inline _.Active ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Active" => (defaultArg x true))
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = render ==> ("Size" => x)
    [<CustomOperation("Shape")>] member inline _.Shape ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Shape" => x)

type SpaceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Align" => x)
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.DirectionVHType) = render ==> ("Direction" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = render ==> ("Size" => x)
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Wrap" => (defaultArg x true))
    [<CustomOperation("Split")>] member inline _.Split ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Split", fragment)
    [<CustomOperation("Split")>] member inline _.Split ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Split", fragment { yield! fragments })
    [<CustomOperation("Split")>] member inline _.Split ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Split", html.text x)
    [<CustomOperation("Split")>] member inline _.Split ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Split", html.text x)
    [<CustomOperation("Split")>] member inline _.Split ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Split", html.text x)

type SpaceItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type SpinBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Tip")>] member inline _.Tip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tip" => x)
    [<CustomOperation("Delay'")>] member inline _.Delay' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Delay" => x)
    [<CustomOperation("Spinning")>] member inline _.Spinning ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Spinning" => (defaultArg x true))
    [<CustomOperation("WrapperClassName")>] member inline _.WrapperClassName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("WrapperClassName" => x)
    [<CustomOperation("Indicator")>] member inline _.Indicator ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Indicator", fragment)
    [<CustomOperation("Indicator")>] member inline _.Indicator ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Indicator", fragment { yield! fragments })
    [<CustomOperation("Indicator")>] member inline _.Indicator ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Indicator", html.text x)
    [<CustomOperation("Indicator")>] member inline _.Indicator ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Indicator", html.text x)
    [<CustomOperation("Indicator")>] member inline _.Indicator ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Indicator", html.text x)

type StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Prefix" => x)
    [<CustomOperation("PrefixTemplate")>] member inline _.PrefixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PrefixTemplate", fragment)
    [<CustomOperation("PrefixTemplate")>] member inline _.PrefixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PrefixTemplate", fragment { yield! fragments })
    [<CustomOperation("PrefixTemplate")>] member inline _.PrefixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PrefixTemplate", html.text x)
    [<CustomOperation("PrefixTemplate")>] member inline _.PrefixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PrefixTemplate", html.text x)
    [<CustomOperation("PrefixTemplate")>] member inline _.PrefixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PrefixTemplate", html.text x)
    [<CustomOperation("Suffix")>] member inline _.Suffix ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Suffix" => x)
    [<CustomOperation("SuffixTemplate")>] member inline _.SuffixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SuffixTemplate", fragment)
    [<CustomOperation("SuffixTemplate")>] member inline _.SuffixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SuffixTemplate", fragment { yield! fragments })
    [<CustomOperation("SuffixTemplate")>] member inline _.SuffixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SuffixTemplate", html.text x)
    [<CustomOperation("SuffixTemplate")>] member inline _.SuffixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SuffixTemplate", html.text x)
    [<CustomOperation("SuffixTemplate")>] member inline _.SuffixTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SuffixTemplate", html.text x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    [<CustomOperation("ValueStyle")>] member inline _.ValueStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueStyle" => x)

type CountDownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit StatisticComponentBaseBuilder<'FunBlazorGeneric, System.DateTime>()
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
    [<CustomOperation("OnFinish")>] member inline _.OnFinish ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnFinish", fn)
    [<CustomOperation("OnFinish")>] member inline _.OnFinish ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnFinish", fn)
    [<CustomOperation("RefreshInterval")>] member inline _.RefreshInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RefreshInterval" => x)

type StatisticBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit StatisticComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    [<CustomOperation("DecimalSeparator")>] member inline _.DecimalSeparator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DecimalSeparator" => x)
    [<CustomOperation("GroupSeparator")>] member inline _.GroupSeparator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupSeparator" => x)
    [<CustomOperation("Precision")>] member inline _.Precision ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Precision" => x)
    [<CustomOperation("CultureInfo")>] member inline _.CultureInfo ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("CultureInfo" => x)

type StepBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Status" => x)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Subtitle")>] member inline _.Subtitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Subtitle" => x)
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SubtitleTemplate", fragment)
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SubtitleTemplate", fragment { yield! fragments })
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SubtitleTemplate", html.text x)
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SubtitleTemplate", html.text x)
    [<CustomOperation("SubtitleTemplate")>] member inline _.SubtitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SubtitleTemplate", html.text x)
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Description" => x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DescriptionTemplate", fragment)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DescriptionTemplate", fragment { yield! fragments })
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))

type StepsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Current")>] member inline _.Current ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Current" => x)
    [<CustomOperation("Percent")>] member inline _.Percent ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Percent" => x)
    [<CustomOperation("ProgressDot")>] member inline _.ProgressDot ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ProgressDot", fragment)
    [<CustomOperation("ProgressDot")>] member inline _.ProgressDot ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ProgressDot", fragment { yield! fragments })
    [<CustomOperation("ProgressDot")>] member inline _.ProgressDot ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ProgressDot", html.text x)
    [<CustomOperation("ProgressDot")>] member inline _.ProgressDot ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ProgressDot", html.text x)
    [<CustomOperation("ProgressDot")>] member inline _.ProgressDot ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ProgressDot", html.text x)
    [<CustomOperation("ShowProgressDot")>] member inline _.ShowProgressDot ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowProgressDot" => (defaultArg x true))
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Direction" => x)
    [<CustomOperation("LabelPlacement")>] member inline _.LabelPlacement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LabelPlacement" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Type" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("StartIndex")>] member inline _.StartIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("StartIndex" => x)
    [<CustomOperation("Status")>] member inline _.Status ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Status" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)

type TableBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("RerenderStrategy")>] member inline _.RerenderStrategy ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.RerenderStrategy) = render ==> ("RerenderStrategy" => x)
    [<CustomOperation("DataSource")>] member inline _.DataSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("DataSource" => x)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("RowTemplate")>] member inline _.RowTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.RowData<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("RowTemplate", fn)
    [<CustomOperation("ColumnDefinitions")>] member inline _.ColumnDefinitions ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ColumnDefinitions", fn)
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    [<CustomOperation("ExpandTemplate")>] member inline _.ExpandTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.RowData<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("ExpandTemplate", fn)
    [<CustomOperation("DefaultExpandAllRows")>] member inline _.DefaultExpandAllRows ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultExpandAllRows" => (defaultArg x true))
    [<CustomOperation("DefaultExpandMaxLevel")>] member inline _.DefaultExpandMaxLevel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DefaultExpandMaxLevel" => x)
    [<CustomOperation("RowExpandable")>] member inline _.RowExpandable ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowExpandable" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>fn))
    [<CustomOperation("TreeChildren")>] member inline _.TreeChildren ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("TreeChildren" => (System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>fn))
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.QueryModel<'TItem> -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.QueryModel<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("OnRow")>] member inline _.OnRow ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnRow" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.Dictionary<System.String, System.Object>>fn))
    [<CustomOperation("OnHeaderRow")>] member inline _.OnHeaderRow ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnHeaderRow" => (System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>fn))
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Footer" => x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TableSize) = render ==> ("Size" => x)
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TableLocale) = render ==> ("Locale" => x)
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Bordered" => (defaultArg x true))
    [<CustomOperation("ScrollX")>] member inline _.ScrollX ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ScrollX" => x)
    [<CustomOperation("ScrollY")>] member inline _.ScrollY ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ScrollY" => x)
    [<CustomOperation("ScrollBarWidth")>] member inline _.ScrollBarWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ScrollBarWidth" => x)
    [<CustomOperation("IndentSize")>] member inline _.IndentSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("IndentSize" => x)
    [<CustomOperation("ExpandIconColumnIndex")>] member inline _.ExpandIconColumnIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ExpandIconColumnIndex" => x)
    [<CustomOperation("RowClassName")>] member inline _.RowClassName ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClassName" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>fn))
    [<CustomOperation("ExpandedRowClassName")>] member inline _.ExpandedRowClassName ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ExpandedRowClassName" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>fn))
    [<CustomOperation("OnExpand")>] member inline _.OnExpand ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.RowData<'TItem> -> unit) = render ==> html.callback("OnExpand", fn)
    [<CustomOperation("OnExpand")>] member inline _.OnExpand ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.RowData<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnExpand", fn)
    [<CustomOperation("SortDirections")>] member inline _.SortDirections ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.SortDirection[]) = render ==> ("SortDirections" => x)
    [<CustomOperation("TableLayout")>] member inline _.TableLayout ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TableLayout" => x)
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.RowData<'TItem> -> unit) = render ==> html.callback("OnRowClick", fn)
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TableModels.RowData<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)
    [<CustomOperation("RemoteDataSource")>] member inline _.RemoteDataSource ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("RemoteDataSource" => (defaultArg x true))
    [<CustomOperation("Responsive")>] member inline _.Responsive ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Responsive" => (defaultArg x true))
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("EmptyTemplate", fragment)
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("EmptyTemplate", fragment { yield! fragments })
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    [<CustomOperation("EmptyTemplate")>] member inline _.EmptyTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("EmptyTemplate", html.text x)
    [<CustomOperation("RowKey")>] member inline _.RowKey ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowKey" => (System.Func<'TItem, System.Object>fn))
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Resizable" => (defaultArg x true))
    [<CustomOperation("FieldFilterTypeResolver")>] member inline _.FieldFilterTypeResolver ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Filters.IFieldFilterTypeResolver) = render ==> ("FieldFilterTypeResolver" => x)
    [<CustomOperation("EnableVirtualization")>] member inline _.EnableVirtualization ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("EnableVirtualization" => (defaultArg x true))
    [<CustomOperation("HidePagination")>] member inline _.HidePagination ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HidePagination" => (defaultArg x true))
    [<CustomOperation("PaginationPosition")>] member inline _.PaginationPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PaginationPosition" => x)
    [<CustomOperation("PaginationTemplate")>] member inline _.PaginationTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.ValueTuple<System.Int32, System.Int32, System.Int32, System.String, Microsoft.AspNetCore.Components.EventCallback<AntDesign.PaginationEventArgs>> -> NodeRenderFragment) = render ==> html.renderFragment("PaginationTemplate", fn)
    [<CustomOperation("Total")>] member inline _.Total ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Total" => x)
    [<CustomOperation("Total'")>] member inline _.Total' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("Total", valueFn)
    [<CustomOperation("TotalChanged")>] member inline _.TotalChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("TotalChanged", fn)
    [<CustomOperation("TotalChanged")>] member inline _.TotalChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("TotalChanged", fn)
    [<CustomOperation("PageIndex")>] member inline _.PageIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageIndex" => x)
    [<CustomOperation("PageIndex'")>] member inline _.PageIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("PageIndex", valueFn)
    [<CustomOperation("PageIndexChanged")>] member inline _.PageIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("PageIndexChanged", fn)
    [<CustomOperation("PageIndexChanged")>] member inline _.PageIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("PageIndexChanged", fn)
    [<CustomOperation("PageSize")>] member inline _.PageSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PageSize" => x)
    [<CustomOperation("PageSize'")>] member inline _.PageSize' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("PageSize", valueFn)
    [<CustomOperation("PageSizeChanged")>] member inline _.PageSizeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("PageSizeChanged", fn)
    [<CustomOperation("PageSizeChanged")>] member inline _.PageSizeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("PageSizeChanged", fn)
    [<CustomOperation("OnPageIndexChange")>] member inline _.OnPageIndexChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationEventArgs -> unit) = render ==> html.callback("OnPageIndexChange", fn)
    [<CustomOperation("OnPageIndexChange")>] member inline _.OnPageIndexChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationEventArgs -> Task<unit>) = render ==> html.callbackTask("OnPageIndexChange", fn)
    [<CustomOperation("OnPageSizeChange")>] member inline _.OnPageSizeChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationEventArgs -> unit) = render ==> html.callback("OnPageSizeChange", fn)
    [<CustomOperation("OnPageSizeChange")>] member inline _.OnPageSizeChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationEventArgs -> Task<unit>) = render ==> html.callbackTask("OnPageSizeChange", fn)
    [<CustomOperation("SelectedRows")>] member inline _.SelectedRows ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("SelectedRows" => x)
    [<CustomOperation("SelectedRows'")>] member inline _.SelectedRows' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'TItem> * (System.Collections.Generic.IEnumerable<'TItem> -> unit)) = render ==> html.bind("SelectedRows", valueFn)
    [<CustomOperation("SelectedRowsChanged")>] member inline _.SelectedRowsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TItem> -> unit) = render ==> html.callback("SelectedRowsChanged", fn)
    [<CustomOperation("SelectedRowsChanged")>] member inline _.SelectedRowsChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.IEnumerable<'TItem> -> Task<unit>) = render ==> html.callbackTask("SelectedRowsChanged", fn)

type ReuseTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("TabPaneClass")>] member inline _.TabPaneClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabPaneClass" => x)
    [<CustomOperation("Draggable")>] member inline _.Draggable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Draggable" => (defaultArg x true))
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TabSize) = render ==> ("Size" => x)
    [<CustomOperation("Body")>] member inline _.Body ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.ReuseTabsPageItem -> NodeRenderFragment) = render ==> html.renderFragment("Body", fn)
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ReuseTabsLocale) = render ==> ("Locale" => x)
    [<CustomOperation("HidePages")>] member inline _.HidePages ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HidePages" => (defaultArg x true))
    [<CustomOperation("ReuseTabsRouteData")>] member inline _.ReuseTabsRouteData ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ReuseTabsRouteData) = render ==> ("ReuseTabsRouteData" => x)

type TabPaneBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ForceRender")>] member inline _.ForceRender ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ForceRender" => (defaultArg x true))
    [<CustomOperation("Key")>] member inline _.Key ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Key" => x)
    [<CustomOperation("Tab")>] member inline _.Tab ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Tab" => x)
    [<CustomOperation("TabTemplate")>] member inline _.TabTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TabTemplate", fragment)
    [<CustomOperation("TabTemplate")>] member inline _.TabTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TabTemplate", fragment { yield! fragments })
    [<CustomOperation("TabTemplate")>] member inline _.TabTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TabTemplate", html.text x)
    [<CustomOperation("TabTemplate")>] member inline _.TabTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TabTemplate", html.text x)
    [<CustomOperation("TabTemplate")>] member inline _.TabTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TabTemplate", html.text x)
    [<CustomOperation("TabContextMenu")>] member inline _.TabContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TabContextMenu", fragment)
    [<CustomOperation("TabContextMenu")>] member inline _.TabContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TabContextMenu", fragment { yield! fragments })
    [<CustomOperation("TabContextMenu")>] member inline _.TabContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TabContextMenu", html.text x)
    [<CustomOperation("TabContextMenu")>] member inline _.TabContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TabContextMenu", html.text x)
    [<CustomOperation("TabContextMenu")>] member inline _.TabContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TabContextMenu", html.text x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Closable")>] member inline _.Closable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Closable" => (defaultArg x true))

type TabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ActiveKey")>] member inline _.ActiveKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveKey" => x)
    [<CustomOperation("ActiveKey'")>] member inline _.ActiveKey' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ActiveKey", valueFn)
    [<CustomOperation("ActiveKeyChanged")>] member inline _.ActiveKeyChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("ActiveKeyChanged", fn)
    [<CustomOperation("ActiveKeyChanged")>] member inline _.ActiveKeyChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("ActiveKeyChanged", fn)
    [<CustomOperation("Animated")>] member inline _.Animated ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Animated" => (defaultArg x true))
    [<CustomOperation("InkBarAnimated")>] member inline _.InkBarAnimated ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("InkBarAnimated" => (defaultArg x true))
    [<CustomOperation("RenderTabBar")>] member inline _.RenderTabBar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("RenderTabBar" => x)
    [<CustomOperation("DefaultActiveKey")>] member inline _.DefaultActiveKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DefaultActiveKey" => x)
    [<CustomOperation("HideAdd")>] member inline _.HideAdd ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideAdd" => (defaultArg x true))
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TabSize) = render ==> ("Size" => x)
    [<CustomOperation("TabBarExtraContent")>] member inline _.TabBarExtraContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TabBarExtraContent", fragment)
    [<CustomOperation("TabBarExtraContent")>] member inline _.TabBarExtraContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TabBarExtraContent", fragment { yield! fragments })
    [<CustomOperation("TabBarExtraContent")>] member inline _.TabBarExtraContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TabBarExtraContent", html.text x)
    [<CustomOperation("TabBarExtraContent")>] member inline _.TabBarExtraContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TabBarExtraContent", html.text x)
    [<CustomOperation("TabBarExtraContent")>] member inline _.TabBarExtraContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TabBarExtraContent", html.text x)
    [<CustomOperation("TabBarExtraContentLeft")>] member inline _.TabBarExtraContentLeft ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TabBarExtraContentLeft", fragment)
    [<CustomOperation("TabBarExtraContentLeft")>] member inline _.TabBarExtraContentLeft ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TabBarExtraContentLeft", fragment { yield! fragments })
    [<CustomOperation("TabBarExtraContentLeft")>] member inline _.TabBarExtraContentLeft ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TabBarExtraContentLeft", html.text x)
    [<CustomOperation("TabBarExtraContentLeft")>] member inline _.TabBarExtraContentLeft ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TabBarExtraContentLeft", html.text x)
    [<CustomOperation("TabBarExtraContentLeft")>] member inline _.TabBarExtraContentLeft ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TabBarExtraContentLeft", html.text x)
    [<CustomOperation("TabBarExtraContentRight")>] member inline _.TabBarExtraContentRight ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TabBarExtraContentRight", fragment)
    [<CustomOperation("TabBarExtraContentRight")>] member inline _.TabBarExtraContentRight ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TabBarExtraContentRight", fragment { yield! fragments })
    [<CustomOperation("TabBarExtraContentRight")>] member inline _.TabBarExtraContentRight ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TabBarExtraContentRight", html.text x)
    [<CustomOperation("TabBarExtraContentRight")>] member inline _.TabBarExtraContentRight ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TabBarExtraContentRight", html.text x)
    [<CustomOperation("TabBarExtraContentRight")>] member inline _.TabBarExtraContentRight ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TabBarExtraContentRight", html.text x)
    [<CustomOperation("TabBarGutter")>] member inline _.TabBarGutter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TabBarGutter" => x)
    [<CustomOperation("TabBarStyle")>] member inline _.TabBarStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabBarStyle" => x)
    [<CustomOperation("TabBarClass")>] member inline _.TabBarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabBarClass" => x)
    [<CustomOperation("TabPosition")>] member inline _.TabPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TabPosition) = render ==> ("TabPosition" => x)
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TabType) = render ==> ("Type" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("OnEdit")>] member inline _.OnEdit ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnEdit" => (System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>fn))
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("OnClose", fn)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)
    [<CustomOperation("OnAddClick")>] member inline _.OnAddClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnAddClick", fn)
    [<CustomOperation("OnAddClick")>] member inline _.OnAddClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnAddClick", fn)
    [<CustomOperation("AfterTabCreated")>] member inline _.AfterTabCreated ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("AfterTabCreated", fn)
    [<CustomOperation("AfterTabCreated")>] member inline _.AfterTabCreated ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("AfterTabCreated", fn)
    [<CustomOperation("OnTabClick")>] member inline _.OnTabClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("OnTabClick", fn)
    [<CustomOperation("OnTabClick")>] member inline _.OnTabClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnTabClick", fn)
    [<CustomOperation("Draggable")>] member inline _.Draggable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Draggable" => (defaultArg x true))
    [<CustomOperation("Centered")>] member inline _.Centered ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Centered" => (defaultArg x true))

type TagBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Closable")>] member inline _.Closable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Closable" => (defaultArg x true))
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Checkable" => (defaultArg x true))
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Checked" => (defaultArg x true))
    [<CustomOperation("Checked'")>] member inline _.Checked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Checked", valueFn)
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("CheckedChanged", fn)
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CheckedChanged", fn)
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    [<CustomOperation("PresetColor")>] member inline _.PresetColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.PresetColor>) = render ==> ("PresetColor" => x)
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("NoAnimation")>] member inline _.NoAnimation ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("NoAnimation" => (defaultArg x true))
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClose", fn)
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)
    [<CustomOperation("OnClosing")>] member inline _.OnClosing ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs> -> unit) = render ==> html.callback("OnClosing", fn)
    [<CustomOperation("OnClosing")>] member inline _.OnClosing ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs> -> Task<unit>) = render ==> html.callbackTask("OnClosing", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Visible" => (defaultArg x true))

type TimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<AntDesign.TimelineMode>) = render ==> ("Mode" => x)
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Reverse" => (defaultArg x true))
    [<CustomOperation("Pending")>] member inline _.Pending ([<InlineIfLambda>] render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Pending" => x)
    [<CustomOperation("PendingDot")>] member inline _.PendingDot ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("PendingDot", fragment)
    [<CustomOperation("PendingDot")>] member inline _.PendingDot ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("PendingDot", fragment { yield! fragments })
    [<CustomOperation("PendingDot")>] member inline _.PendingDot ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PendingDot", html.text x)
    [<CustomOperation("PendingDot")>] member inline _.PendingDot ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PendingDot", html.text x)
    [<CustomOperation("PendingDot")>] member inline _.PendingDot ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PendingDot", html.text x)

type TimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Dot", fragment)
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Dot", fragment { yield! fragments })
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Dot", html.text x)
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Dot", html.text x)
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Dot", html.text x)
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)

type TransferBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataSource")>] member inline _.DataSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<AntDesign.TransferItem>) = render ==> ("DataSource" => x)
    [<CustomOperation("Titles")>] member inline _.Titles ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("Titles" => x)
    [<CustomOperation("Operations")>] member inline _.Operations ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("Operations" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("ShowSearch")>] member inline _.ShowSearch ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSearch" => (defaultArg x true))
    [<CustomOperation("ShowSelectAll")>] member inline _.ShowSelectAll ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSelectAll" => (defaultArg x true))
    [<CustomOperation("TargetKeys")>] member inline _.TargetKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("TargetKeys" => x)
    [<CustomOperation("SelectedKeys")>] member inline _.SelectedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("SelectedKeys" => x)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TransferChangeArgs -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TransferChangeArgs -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("OnScroll")>] member inline _.OnScroll ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TransferScrollArgs -> unit) = render ==> html.callback("OnScroll", fn)
    [<CustomOperation("OnScroll")>] member inline _.OnScroll ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TransferScrollArgs -> Task<unit>) = render ==> html.callbackTask("OnScroll", fn)
    [<CustomOperation("OnSearch")>] member inline _.OnSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TransferSearchArgs -> unit) = render ==> html.callback("OnSearch", fn)
    [<CustomOperation("OnSearch")>] member inline _.OnSearch ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TransferSearchArgs -> Task<unit>) = render ==> html.callbackTask("OnSearch", fn)
    [<CustomOperation("OnSelectChange")>] member inline _.OnSelectChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TransferSelectChangeArgs -> unit) = render ==> html.callback("OnSelectChange", fn)
    [<CustomOperation("OnSelectChange")>] member inline _.OnSelectChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TransferSelectChangeArgs -> Task<unit>) = render ==> html.callbackTask("OnSelectChange", fn)
    [<CustomOperation("Render")>] member inline _.Render ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Render" => (System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>fn))
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TransferLocale) = render ==> ("Locale" => x)
    [<CustomOperation("Footer")>] member inline _.Footer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Footer" => x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterTemplate", fragment)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FooterTemplate", fragment { yield! fragments })
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterTemplate", html.text x)
    [<CustomOperation("ListStyle")>] member inline _.ListStyle ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ListStyle" => (System.Func<AntDesign.TransferDirection, System.String>fn))

type TreeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ShowExpand")>] member inline _.ShowExpand ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowExpand" => (defaultArg x true))
    [<CustomOperation("ShowLine")>] member inline _.ShowLine ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowLine" => (defaultArg x true))
    [<CustomOperation("ShowIcon")>] member inline _.ShowIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowIcon" => (defaultArg x true))
    [<CustomOperation("BlockNode")>] member inline _.BlockNode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("BlockNode" => (defaultArg x true))
    [<CustomOperation("Draggable")>] member inline _.Draggable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Draggable" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("ShowLeafIcon")>] member inline _.ShowLeafIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowLeafIcon" => (defaultArg x true))
    [<CustomOperation("SwitcherIcon")>] member inline _.SwitcherIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SwitcherIcon" => x)
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Nodes", fragment)
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Nodes", fragment { yield! fragments })
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Nodes", html.text x)
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Nodes", html.text x)
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Nodes", html.text x)
    [<CustomOperation("Selectable")>] member inline _.Selectable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Selectable" => (defaultArg x true))
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Multiple" => (defaultArg x true))
    [<CustomOperation("DefaultSelectedKeys")>] member inline _.DefaultSelectedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("DefaultSelectedKeys" => x)
    [<CustomOperation("DefaultSelectedKey")>] member inline _.DefaultSelectedKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DefaultSelectedKey" => x)
    [<CustomOperation("SelectedKey")>] member inline _.SelectedKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedKey" => x)
    [<CustomOperation("SelectedKey'")>] member inline _.SelectedKey' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("SelectedKey", valueFn)
    [<CustomOperation("SelectedKeyChanged")>] member inline _.SelectedKeyChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("SelectedKeyChanged", fn)
    [<CustomOperation("SelectedKeyChanged")>] member inline _.SelectedKeyChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("SelectedKeyChanged", fn)
    [<CustomOperation("SelectedNode")>] member inline _.SelectedNode ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TreeNode<'TItem>) = render ==> ("SelectedNode" => x)
    [<CustomOperation("SelectedNode'")>] member inline _.SelectedNode' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: AntDesign.TreeNode<'TItem> * (AntDesign.TreeNode<'TItem> -> unit)) = render ==> html.bind("SelectedNode", valueFn)
    [<CustomOperation("SelectedNodeChanged")>] member inline _.SelectedNodeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> unit) = render ==> html.callback("SelectedNodeChanged", fn)
    [<CustomOperation("SelectedNodeChanged")>] member inline _.SelectedNodeChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> Task<unit>) = render ==> html.callbackTask("SelectedNodeChanged", fn)
    [<CustomOperation("SelectedData")>] member inline _.SelectedData ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("SelectedData" => x)
    [<CustomOperation("SelectedData'")>] member inline _.SelectedData' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TItem * ('TItem -> unit)) = render ==> html.bind("SelectedData", valueFn)
    [<CustomOperation("SelectedDataChanged")>] member inline _.SelectedDataChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> unit) = render ==> html.callback("SelectedDataChanged", fn)
    [<CustomOperation("SelectedDataChanged")>] member inline _.SelectedDataChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> Task<unit>) = render ==> html.callbackTask("SelectedDataChanged", fn)
    [<CustomOperation("SelectedKeys")>] member inline _.SelectedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("SelectedKeys" => x)
    [<CustomOperation("SelectedKeys'")>] member inline _.SelectedKeys' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("SelectedKeys", valueFn)
    [<CustomOperation("SelectedKeysChanged")>] member inline _.SelectedKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> unit) = render ==> html.callback("SelectedKeysChanged", fn)
    [<CustomOperation("SelectedKeysChanged")>] member inline _.SelectedKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("SelectedKeysChanged", fn)
    [<CustomOperation("SelectedNodes")>] member inline _.SelectedNodes ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TreeNode<'TItem>[]) = render ==> ("SelectedNodes" => x)
    [<CustomOperation("SelectedNodes'")>] member inline _.SelectedNodes' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: AntDesign.TreeNode<'TItem>[] * (AntDesign.TreeNode<'TItem>[] -> unit)) = render ==> html.bind("SelectedNodes", valueFn)
    [<CustomOperation("SelectedNodesChanged")>] member inline _.SelectedNodesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem>[] -> unit) = render ==> html.callback("SelectedNodesChanged", fn)
    [<CustomOperation("SelectedNodesChanged")>] member inline _.SelectedNodesChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem>[] -> Task<unit>) = render ==> html.callbackTask("SelectedNodesChanged", fn)
    [<CustomOperation("SelectedDatas")>] member inline _.SelectedDatas ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem[]) = render ==> ("SelectedDatas" => x)
    [<CustomOperation("SelectedDatas'")>] member inline _.SelectedDatas' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'TItem[] * ('TItem[] -> unit)) = render ==> html.bind("SelectedDatas", valueFn)
    [<CustomOperation("SelectedDatasChanged")>] member inline _.SelectedDatasChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem[] -> unit) = render ==> html.callback("SelectedDatasChanged", fn)
    [<CustomOperation("SelectedDatasChanged")>] member inline _.SelectedDatasChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem[] -> Task<unit>) = render ==> html.callbackTask("SelectedDatasChanged", fn)
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Checkable" => (defaultArg x true))
    [<CustomOperation("CheckOnClickNode")>] member inline _.CheckOnClickNode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CheckOnClickNode" => (defaultArg x true))
    [<CustomOperation("CheckStrictly")>] member inline _.CheckStrictly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("CheckStrictly" => (defaultArg x true))
    [<CustomOperation("CheckedKeys")>] member inline _.CheckedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("CheckedKeys" => x)
    [<CustomOperation("CheckedKeys'")>] member inline _.CheckedKeys' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("CheckedKeys", valueFn)
    [<CustomOperation("CheckedKeysChanged")>] member inline _.CheckedKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> unit) = render ==> html.callback("CheckedKeysChanged", fn)
    [<CustomOperation("CheckedKeysChanged")>] member inline _.CheckedKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("CheckedKeysChanged", fn)
    [<CustomOperation("DefaultCheckedKeys")>] member inline _.DefaultCheckedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("DefaultCheckedKeys" => x)
    [<CustomOperation("SearchValue")>] member inline _.SearchValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SearchValue" => x)
    [<CustomOperation("SearchExpression")>] member inline _.SearchExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SearchExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn))
    [<CustomOperation("MatchedStyle")>] member inline _.MatchedStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MatchedStyle" => x)
    [<CustomOperation("MatchedClass")>] member inline _.MatchedClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MatchedClass" => x)
    [<CustomOperation("HideUnmatched")>] member inline _.HideUnmatched ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HideUnmatched" => (defaultArg x true))
    [<CustomOperation("DataSource")>] member inline _.DataSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("DataSource" => x)
    [<CustomOperation("TitleExpression")>] member inline _.TitleExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("TitleExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn))
    [<CustomOperation("KeyExpression")>] member inline _.KeyExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("KeyExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn))
    [<CustomOperation("IconExpression")>] member inline _.IconExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IconExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn))
    [<CustomOperation("IsLeafExpression")>] member inline _.IsLeafExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IsLeafExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn))
    [<CustomOperation("ChildrenExpression")>] member inline _.ChildrenExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ChildrenExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IEnumerable<'TItem>>fn))
    [<CustomOperation("DisabledExpression")>] member inline _.DisabledExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DisabledExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn))
    [<CustomOperation("CheckableExpression")>] member inline _.CheckableExpression ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CheckableExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn))
    [<CustomOperation("OnNodeLoadDelayAsync")>] member inline _.OnNodeLoadDelayAsync ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnNodeLoadDelayAsync", fn)
    [<CustomOperation("OnNodeLoadDelayAsync")>] member inline _.OnNodeLoadDelayAsync ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnNodeLoadDelayAsync", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("OnDblClick")>] member inline _.OnDblClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnDblClick", fn)
    [<CustomOperation("OnDblClick")>] member inline _.OnDblClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDblClick", fn)
    [<CustomOperation("OnContextMenu")>] member inline _.OnContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnContextMenu", fn)
    [<CustomOperation("OnContextMenu")>] member inline _.OnContextMenu ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnContextMenu", fn)
    [<CustomOperation("OnCheck")>] member inline _.OnCheck ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnCheck", fn)
    [<CustomOperation("OnCheck")>] member inline _.OnCheck ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnCheck", fn)
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnSelect", fn)
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnSelect", fn)
    [<CustomOperation("OnUnselect")>] member inline _.OnUnselect ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnUnselect", fn)
    [<CustomOperation("OnUnselect")>] member inline _.OnUnselect ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnUnselect", fn)
    [<CustomOperation("OnExpandChanged")>] member inline _.OnExpandChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnExpandChanged", fn)
    [<CustomOperation("OnExpandChanged")>] member inline _.OnExpandChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnExpandChanged", fn)
    [<CustomOperation("IndentTemplate")>] member inline _.IndentTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("IndentTemplate", fn)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("TitleTemplate", fn)
    [<CustomOperation("TitleIconTemplate")>] member inline _.TitleIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("TitleIconTemplate", fn)
    [<CustomOperation("SwitcherIconTemplate")>] member inline _.SwitcherIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("SwitcherIconTemplate", fn)
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragStart", fn)
    [<CustomOperation("OnDragStart")>] member inline _.OnDragStart ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragStart", fn)
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragEnter", fn)
    [<CustomOperation("OnDragEnter")>] member inline _.OnDragEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragEnter", fn)
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragLeave", fn)
    [<CustomOperation("OnDragLeave")>] member inline _.OnDragLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragLeave", fn)
    [<CustomOperation("OnDrop")>] member inline _.OnDrop ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnDrop", fn)
    [<CustomOperation("OnDrop")>] member inline _.OnDrop ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDrop", fn)
    [<CustomOperation("OnDragEnd")>] member inline _.OnDragEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> unit) = render ==> html.callback("OnDragEnd", fn)
    [<CustomOperation("OnDragEnd")>] member inline _.OnDragEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeEventArgs<'TItem> -> Task<unit>) = render ==> html.callbackTask("OnDragEnd", fn)
    [<CustomOperation("ExpandOnClickNode")>] member inline _.ExpandOnClickNode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ExpandOnClickNode" => (defaultArg x true))
    [<CustomOperation("DefaultExpandAll")>] member inline _.DefaultExpandAll ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultExpandAll" => (defaultArg x true))
    [<CustomOperation("DefaultExpandParent")>] member inline _.DefaultExpandParent ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DefaultExpandParent" => (defaultArg x true))
    [<CustomOperation("DefaultExpandedKeys")>] member inline _.DefaultExpandedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("DefaultExpandedKeys" => x)
    [<CustomOperation("ExpandedKeys")>] member inline _.ExpandedKeys ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("ExpandedKeys" => x)
    [<CustomOperation("ExpandedKeys'")>] member inline _.ExpandedKeys' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("ExpandedKeys", valueFn)
    [<CustomOperation("ExpandedKeysChanged")>] member inline _.ExpandedKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> unit) = render ==> html.callback("ExpandedKeysChanged", fn)
    [<CustomOperation("ExpandedKeysChanged")>] member inline _.ExpandedKeysChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("ExpandedKeysChanged", fn)
    [<CustomOperation("OnExpand")>] member inline _.OnExpand ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.ValueTuple<System.String[], AntDesign.TreeNode<'TItem>, System.Boolean> -> unit) = render ==> html.callback("OnExpand", fn)
    [<CustomOperation("OnExpand")>] member inline _.OnExpand ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.ValueTuple<System.String[], AntDesign.TreeNode<'TItem>, System.Boolean> -> Task<unit>) = render ==> html.callbackTask("OnExpand", fn)
    [<CustomOperation("AutoExpandParent")>] member inline _.AutoExpandParent ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoExpandParent" => (defaultArg x true))

type DirectoryTreeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TreeBuilder<'FunBlazorGeneric, 'TItem>()


type TreeNodeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Nodes", fragment)
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Nodes", fragment { yield! fragments })
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Nodes", html.text x)
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Nodes", html.text x)
    [<CustomOperation("Nodes")>] member inline _.Nodes ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Nodes", html.text x)
    [<CustomOperation("Key")>] member inline _.Key ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Key" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Selected" => (defaultArg x true))
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Loading" => (defaultArg x true))
    [<CustomOperation("IsLeaf")>] member inline _.IsLeaf ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsLeaf" => (defaultArg x true))
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Expanded" => (defaultArg x true))
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Checked" => (defaultArg x true))
    [<CustomOperation("Checked'")>] member inline _.Checked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Checked", valueFn)
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("CheckedChanged", fn)
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CheckedChanged", fn)
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Checkable" => (defaultArg x true))
    [<CustomOperation("DisableCheckbox")>] member inline _.DisableCheckbox ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("DisableCheckbox" => (defaultArg x true))
    [<CustomOperation("Draggable")>] member inline _.Draggable ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Draggable" => (defaultArg x true))
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    [<CustomOperation("IconTemplate")>] member inline _.IconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("IconTemplate", fn)
    [<CustomOperation("SwitcherIcon")>] member inline _.SwitcherIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SwitcherIcon" => x)
    [<CustomOperation("SwitcherIconTemplate")>] member inline _.SwitcherIconTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("SwitcherIconTemplate", fn)
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("DataItem")>] member inline _.DataItem ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TItem) = render ==> ("DataItem" => x)

type UploadBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("BeforeUpload")>] member inline _.BeforeUpload ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("BeforeUpload" => (System.Func<AntDesign.UploadFileItem, System.Boolean>fn))
    [<CustomOperation("BeforeAllUploadAsync")>] member inline _.BeforeAllUploadAsync ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("BeforeAllUploadAsync" => (System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>fn))
    [<CustomOperation("BeforeAllUpload")>] member inline _.BeforeAllUpload ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("BeforeAllUpload" => (System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Boolean>fn))
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("Action")>] member inline _.Action ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Action" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("Data" => x)
    [<CustomOperation("ListType")>] member inline _.ListType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListType" => x)
    [<CustomOperation("Directory")>] member inline _.Directory ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Directory" => (defaultArg x true))
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Multiple" => (defaultArg x true))
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    [<CustomOperation("ShowUploadList")>] member inline _.ShowUploadList ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowUploadList" => (defaultArg x true))
    [<CustomOperation("ShowDownloadIcon")>] member inline _.ShowDownloadIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowDownloadIcon" => (defaultArg x true))
    [<CustomOperation("ShowPreviewIcon")>] member inline _.ShowPreviewIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowPreviewIcon" => (defaultArg x true))
    [<CustomOperation("ShowRemoveIcon")>] member inline _.ShowRemoveIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowRemoveIcon" => (defaultArg x true))
    [<CustomOperation("FileList")>] member inline _.FileList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = render ==> ("FileList" => x)
    [<CustomOperation("FileList'")>] member inline _.FileList' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.List<AntDesign.UploadFileItem> * (System.Collections.Generic.List<AntDesign.UploadFileItem> -> unit)) = render ==> html.bind("FileList", valueFn)
    [<CustomOperation("Locale")>] member inline _.Locale ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.UploadLocale) = render ==> ("Locale" => x)
    [<CustomOperation("FileListChanged")>] member inline _.FileListChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.List<AntDesign.UploadFileItem> -> unit) = render ==> html.callback("FileListChanged", fn)
    [<CustomOperation("FileListChanged")>] member inline _.FileListChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Collections.Generic.List<AntDesign.UploadFileItem> -> Task<unit>) = render ==> html.callbackTask("FileListChanged", fn)
    [<CustomOperation("DefaultFileList")>] member inline _.DefaultFileList ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = render ==> ("DefaultFileList" => x)
    [<CustomOperation("Headers")>] member inline _.Headers ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.String>) = render ==> ("Headers" => x)
    [<CustomOperation("OnSingleCompleted")>] member inline _.OnSingleCompleted ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadInfo -> unit) = render ==> html.callback("OnSingleCompleted", fn)
    [<CustomOperation("OnSingleCompleted")>] member inline _.OnSingleCompleted ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadInfo -> Task<unit>) = render ==> html.callbackTask("OnSingleCompleted", fn)
    [<CustomOperation("OnCompleted")>] member inline _.OnCompleted ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadInfo -> unit) = render ==> html.callback("OnCompleted", fn)
    [<CustomOperation("OnCompleted")>] member inline _.OnCompleted ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadInfo -> Task<unit>) = render ==> html.callbackTask("OnCompleted", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadInfo -> unit) = render ==> html.callback("OnChange", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadInfo -> Task<unit>) = render ==> html.callbackTask("OnChange", fn)
    [<CustomOperation("OnRemove")>] member inline _.OnRemove ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnRemove" => (System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>fn))
    [<CustomOperation("OnPreview")>] member inline _.OnPreview ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadFileItem -> unit) = render ==> html.callback("OnPreview", fn)
    [<CustomOperation("OnPreview")>] member inline _.OnPreview ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadFileItem -> Task<unit>) = render ==> html.callbackTask("OnPreview", fn)
    [<CustomOperation("OnDownload")>] member inline _.OnDownload ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadFileItem -> unit) = render ==> html.callback("OnDownload", fn)
    [<CustomOperation("OnDownload")>] member inline _.OnDownload ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.UploadFileItem -> Task<unit>) = render ==> html.callbackTask("OnDownload", fn)
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowButton" => (defaultArg x true))
    [<CustomOperation("Drag")>] member inline _.Drag ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Drag" => (defaultArg x true))
    [<CustomOperation("Method")>] member inline _.Method ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Method" => x)

type WatermarkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Height" => x)
    [<CustomOperation("Rotate")>] member inline _.Rotate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Rotate" => x)
    [<CustomOperation("Alpha")>] member inline _.Alpha ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("Alpha" => x)
    [<CustomOperation("FontSize")>] member inline _.FontSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("FontSize" => x)
    [<CustomOperation("FontColor")>] member inline _.FontColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FontColor" => x)
    [<CustomOperation("FontFamily")>] member inline _.FontFamily ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FontFamily" => x)
    [<CustomOperation("FontWeight")>] member inline _.FontWeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FontWeight" => x)
    [<CustomOperation("FontStyle")>] member inline _.FontStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FontStyle" => x)
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Content" => x)
    [<CustomOperation("Contents")>] member inline _.Contents ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("Contents" => x)
    [<CustomOperation("ZIndex")>] member inline _.ZIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ZIndex" => x)
    [<CustomOperation("Gap")>] member inline _.Gap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.ValueTuple<System.Int32, System.Int32>) = render ==> ("Gap" => x)
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    [<CustomOperation("Offset")>] member inline _.Offset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.ValueTuple<System.Int32, System.Int32>) = render ==> ("Offset" => x)
    [<CustomOperation("LineSpace")>] member inline _.LineSpace ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("LineSpace" => x)
    [<CustomOperation("Scrolling")>] member inline _.Scrolling ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Scrolling" => (defaultArg x true))
    [<CustomOperation("ScrollingSpeed")>] member inline _.ScrollingSpeed ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ScrollingSpeed" => x)
    [<CustomOperation("Repeat")>] member inline _.Repeat ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Repeat" => (defaultArg x true))
    [<CustomOperation("Grayscale")>] member inline _.Grayscale ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Grayscale" => (defaultArg x true))

type BreadcrumbItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Overlay", fragment)
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Overlay", fragment { yield! fragments })
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Overlay", html.text x)
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Overlay", html.text x)
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Overlay", html.text x)
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

type CalendarHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type CardMetaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("TitleTemplate", fragment)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("TitleTemplate", fragment { yield! fragments })
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleTemplate", html.text x)
    [<CustomOperation("Description")>] member inline _.Description ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Description" => x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("DescriptionTemplate", fragment)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("DescriptionTemplate", fragment { yield! fragments })
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("DescriptionTemplate")>] member inline _.DescriptionTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DescriptionTemplate", html.text x)
    [<CustomOperation("Avatar")>] member inline _.Avatar ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("AvatarTemplate", fragment)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("AvatarTemplate", fragment { yield! fragments })
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AvatarTemplate", html.text x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AvatarTemplate", html.text x)
    [<CustomOperation("AvatarTemplate")>] member inline _.AvatarTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AvatarTemplate", html.text x)

type AntContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type TemplateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("If")>] member inline _.If ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("If" => (System.Func<System.Boolean>fn))

type EmptyDefaultImgBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)

type EmptySimpleImgBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)

type ContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type FooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type HeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type LayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type MenuDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


type PaginationPagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ShowTitle")>] member inline _.ShowTitle ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowTitle" => (defaultArg x true))
    [<CustomOperation("Page")>] member inline _.Page ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Page" => x)
    [<CustomOperation("RootPrefixCls")>] member inline _.RootPrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootPrefixCls" => x)
    [<CustomOperation("Active")>] member inline _.Active ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Active" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("OnKeyPress")>] member inline _.OnKeyPress ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action> -> unit) = render ==> html.callback("OnKeyPress", fn)
    [<CustomOperation("OnKeyPress")>] member inline _.OnKeyPress ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action> -> Task<unit>) = render ==> html.callbackTask("OnKeyPress", fn)
    [<CustomOperation("ItemRender")>] member inline _.ItemRender ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = render ==> html.renderFragment("ItemRender", fn)
    [<CustomOperation("UnmatchedAttributes")>] member inline _.UnmatchedAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("UnmatchedAttributes" => x)

type TableRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("AdditionalAttributes")>] member inline _.AdditionalAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("AdditionalAttributes" => x)

            
namespace rec AntDesign.DslInternals.Select.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type SelectContentBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Prefix")>] member inline _.Prefix ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Prefix" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("IsOverlayShow")>] member inline _.IsOverlayShow ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsOverlayShow" => (defaultArg x true))
    [<CustomOperation("MaxTagCount")>] member inline _.MaxTagCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxTagCount" => x)
    [<CustomOperation("OnInput")>] member inline _.OnInput ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> unit) = render ==> html.callback("OnInput", fn)
    [<CustomOperation("OnInput")>] member inline _.OnInput ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnInput", fn)
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyUp", fn)
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyUp", fn)
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyDown", fn)
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyDown", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnFocus", fn)
    [<CustomOperation("OnFocus")>] member inline _.OnFocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFocus", fn)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnBlur", fn)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnBlur", fn)
    [<CustomOperation("OnClearClick")>] member inline _.OnClearClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearClick", fn)
    [<CustomOperation("OnClearClick")>] member inline _.OnClearClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearClick", fn)
    [<CustomOperation("OnRemoveSelected")>] member inline _.OnRemoveSelected ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem> -> unit) = render ==> html.callback("OnRemoveSelected", fn)
    [<CustomOperation("OnRemoveSelected")>] member inline _.OnRemoveSelected ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem> -> Task<unit>) = render ==> html.callbackTask("OnRemoveSelected", fn)
    [<CustomOperation("SearchValue")>] member inline _.SearchValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SearchValue" => x)
    [<CustomOperation("SearchDebounceMilliseconds")>] member inline _.SearchDebounceMilliseconds ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SearchDebounceMilliseconds" => x)

type SelectOptionGroupBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()


            
namespace rec AntDesign.DslInternals.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type CalendarPanelChooserBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Calendar")>] member inline _.Calendar ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.Calendar) = render ==> ("Calendar" => x)
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnSelect" => (System.Action<System.DateTime, System.Int32>fn))
    [<CustomOperation("PickerIndex")>] member inline _.PickerIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PickerIndex" => x)

type ElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("HtmlTag")>] member inline _.HtmlTag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    [<CustomOperation("RefChanged")>] member inline _.RefChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ElementReference -> unit) = render ==> html.callback("RefChanged", fn)
    [<CustomOperation("RefChanged")>] member inline _.RefChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ElementReference -> Task<unit>) = render ==> html.callbackTask("RefChanged", fn)
    [<CustomOperation("Attributes")>] member inline _.Attributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("Attributes" => x)

type OverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnOverlayMouseEnter")>] member inline _.OnOverlayMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnOverlayMouseEnter", fn)
    [<CustomOperation("OnOverlayMouseEnter")>] member inline _.OnOverlayMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnOverlayMouseEnter", fn)
    [<CustomOperation("OnOverlayMouseLeave")>] member inline _.OnOverlayMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnOverlayMouseLeave", fn)
    [<CustomOperation("OnOverlayMouseLeave")>] member inline _.OnOverlayMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnOverlayMouseLeave", fn)
    [<CustomOperation("OnOverlayMouseUp")>] member inline _.OnOverlayMouseUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnOverlayMouseUp", fn)
    [<CustomOperation("OnOverlayMouseUp")>] member inline _.OnOverlayMouseUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnOverlayMouseUp", fn)
    [<CustomOperation("OnShow")>] member inline _.OnShow ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnShow", fn)
    [<CustomOperation("OnShow")>] member inline _.OnShow ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnShow", fn)
    [<CustomOperation("OnHide")>] member inline _.OnHide ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnHide", fn)
    [<CustomOperation("OnHide")>] member inline _.OnHide ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnHide", fn)
    [<CustomOperation("OverlayChildPrefixCls")>] member inline _.OverlayChildPrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OverlayChildPrefixCls" => x)
    [<CustomOperation("HideMillisecondsDelay")>] member inline _.HideMillisecondsDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HideMillisecondsDelay" => x)
    [<CustomOperation("WaitForHideAnimMilliseconds")>] member inline _.WaitForHideAnimMilliseconds ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("WaitForHideAnimMilliseconds" => x)
    [<CustomOperation("VerticalOffset")>] member inline _.VerticalOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("VerticalOffset" => x)
    [<CustomOperation("HorizontalOffset")>] member inline _.HorizontalOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HorizontalOffset" => x)
    [<CustomOperation("HiddenMode")>] member inline _.HiddenMode ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("HiddenMode" => (defaultArg x true))

type DatePickerPanelChooserBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DatePicker")>] member inline _.DatePicker ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.DatePickerBase<'TValue>) = render ==> ("DatePicker" => x)
    [<CustomOperation("OnSelect")>] member inline _.OnSelect ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnSelect" => (System.Action<System.DateTime, System.Int32>fn))
    [<CustomOperation("PickerIndex")>] member inline _.PickerIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("PickerIndex" => x)

type UploadButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ListType")>] member inline _.ListType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListType" => x)
    [<CustomOperation("ShowButton")>] member inline _.ShowButton ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowButton" => (defaultArg x true))
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("Directory")>] member inline _.Directory ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Directory" => (defaultArg x true))
    [<CustomOperation("Multiple")>] member inline _.Multiple ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Multiple" => (defaultArg x true))
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("Data" => x)
    [<CustomOperation("Headers")>] member inline _.Headers ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.String>) = render ==> ("Headers" => x)
    [<CustomOperation("Action")>] member inline _.Action ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Action" => x)
    [<CustomOperation("Method")>] member inline _.Method ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Method" => x)
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))

type DatePickerInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Size" => x)
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ReadOnly" => (defaultArg x true))
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Mask" => x)
    [<CustomOperation("IsRange")>] member inline _.IsRange ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsRange" => (defaultArg x true))
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Disabled" => (defaultArg x true))
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AutoFocus" => (defaultArg x true))
    [<CustomOperation("ShowSuffixIcon")>] member inline _.ShowSuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSuffixIcon" => (defaultArg x true))
    [<CustomOperation("ShowTime")>] member inline _.ShowTime ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowTime" => (defaultArg x true))
    [<CustomOperation("HtmlInputSize")>] member inline _.HtmlInputSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HtmlInputSize" => x)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("SuffixIcon", fragment)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("SuffixIcon", fragment { yield! fragments })
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("SuffixIcon")>] member inline _.SuffixIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SuffixIcon", html.text x)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClick", fn)
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    [<CustomOperation("Onfocus")>] member inline _.Onfocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("Onfocus", fn)
    [<CustomOperation("Onfocus")>] member inline _.Onfocus ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("Onfocus", fn)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnBlur", fn)
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnBlur", fn)
    [<CustomOperation("Onfocusout")>] member inline _.Onfocusout ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("Onfocusout", fn)
    [<CustomOperation("Onfocusout")>] member inline _.Onfocusout ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("Onfocusout", fn)
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyUp", fn)
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyUp", fn)
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyDown", fn)
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyDown", fn)
    [<CustomOperation("OnInput")>] member inline _.OnInput ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> unit) = render ==> html.callback("OnInput", fn)
    [<CustomOperation("OnInput")>] member inline _.OnInput ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnInput", fn)
    [<CustomOperation("AllowClear")>] member inline _.AllowClear ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("AllowClear" => (defaultArg x true))
    [<CustomOperation("OnClickClear")>] member inline _.OnClickClear ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnClickClear", fn)
    [<CustomOperation("OnClickClear")>] member inline _.OnClickClear ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClickClear", fn)
    [<CustomOperation("OnSuffixIconClick")>] member inline _.OnSuffixIconClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> unit) = render ==> html.callback("OnSuffixIconClick", fn)
    [<CustomOperation("OnSuffixIconClick")>] member inline _.OnSuffixIconClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: unit -> Task<unit>) = render ==> html.callbackTask("OnSuffixIconClick", fn)
    [<CustomOperation("FeedbackIcon")>] member inline _.FeedbackIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FeedbackIcon", fragment)
    [<CustomOperation("FeedbackIcon")>] member inline _.FeedbackIcon ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FeedbackIcon", fragment { yield! fragments })
    [<CustomOperation("FeedbackIcon")>] member inline _.FeedbackIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FeedbackIcon", html.text x)
    [<CustomOperation("FeedbackIcon")>] member inline _.FeedbackIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FeedbackIcon", html.text x)
    [<CustomOperation("FeedbackIcon")>] member inline _.FeedbackIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FeedbackIcon", html.text x)
    [<CustomOperation("Active")>] member inline _.Active ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Active" => (defaultArg x true))

type DropdownGroupButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("LeftButton")>] member inline _.LeftButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("LeftButton", fragment)
    [<CustomOperation("LeftButton")>] member inline _.LeftButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("LeftButton", fragment { yield! fragments })
    [<CustomOperation("LeftButton")>] member inline _.LeftButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LeftButton", html.text x)
    [<CustomOperation("LeftButton")>] member inline _.LeftButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LeftButton", html.text x)
    [<CustomOperation("LeftButton")>] member inline _.LeftButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LeftButton", html.text x)
    [<CustomOperation("RightButton")>] member inline _.RightButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment) = render ==> html.renderFragment("RightButton", fragment)
    [<CustomOperation("RightButton")>] member inline _.RightButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments) = render ==> html.renderFragment("RightButton", fragment { yield! fragments })
    [<CustomOperation("RightButton")>] member inline _.RightButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("RightButton", html.text x)
    [<CustomOperation("RightButton")>] member inline _.RightButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("RightButton", html.text x)
    [<CustomOperation("RightButton")>] member inline _.RightButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("RightButton", html.text x)

            
namespace rec AntDesign.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type ConfigProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Direction")>] member inline _.Direction ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Direction" => x)
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.GlobalTheme) = render ==> ("Theme" => x)
    [<CustomOperation("Form")>] member inline _.Form ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.FormConfig) = render ==> ("Form" => x)

type TemplateComponentBaseBuilder<'FunBlazorGeneric, 'TComponentOptions when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: 'TComponentOptions) = render ==> ("Options" => x)

type FeedbackComponentBuilder<'FunBlazorGeneric, 'TComponentOptions when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TemplateComponentBaseBuilder<'FunBlazorGeneric, 'TComponentOptions>()
    [<CustomOperation("FeedbackRef")>] member inline _.FeedbackRef ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.IFeedbackRef) = render ==> ("FeedbackRef" => x)

type FeedbackComponentBuilder2<'FunBlazorGeneric, 'TComponentOptions, 'TResult when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FeedbackComponentBuilder<'FunBlazorGeneric, 'TComponentOptions>()


type FormProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnFormFinish")>] member inline _.OnFormFinish ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.FormProviderFinishEventArgs -> unit) = render ==> html.callback("OnFormFinish", fn)
    [<CustomOperation("OnFormFinish")>] member inline _.OnFormFinish ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.FormProviderFinishEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFormFinish", fn)

            
namespace rec AntDesign.DslInternals.Core.Component.ResizeObserver

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type ResizeObserverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnResize")>] member inline _.OnResize ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.JsInterop.DomRect -> unit) = render ==> html.callback("OnResize", fn)
    [<CustomOperation("OnResize")>] member inline _.OnResize ([<InlineIfLambda>] render: AttrRenderFragment, fn: AntDesign.JsInterop.DomRect -> Task<unit>) = render ==> html.callbackTask("OnResize", fn)

            
namespace rec AntDesign.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type ComponentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Type")>] member inline _.Type ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Type) = render ==> ("Type" => x)
    [<CustomOperation("TypeName")>] member inline _.TypeName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TypeName" => x)
    [<CustomOperation("Parameters")>] member inline _.Parameters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Object>) = render ==> ("Parameters" => x)

type ForeachLoopBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Items" => x)
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)

type GenerateFormItemBuilder<'FunBlazorGeneric, 'TModel when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ValidateRules")>] member inline _.ValidateRules ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ValidateRules" => (System.Func<System.String, AntDesign.FormValidationRule[]>fn))
    [<CustomOperation("Definitions")>] member inline _.Definitions ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Definitions" => (System.Func<System.String, Microsoft.AspNetCore.Components.RenderFragment>fn))
    [<CustomOperation("NotGenerate")>] member inline _.NotGenerate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("NotGenerate" => (System.Func<System.String, System.Boolean>fn))
    [<CustomOperation("SubformStyle")>] member inline _.SubformStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SubformStyle" => x)

type ImagePreviewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ImageRef")>] member inline _.ImageRef ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ImageRef) = render ==> ("ImageRef" => x)

type ImagePreviewGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PreviewVisible")>] member inline _.PreviewVisible ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("PreviewVisible" => (defaultArg x true))
    [<CustomOperation("PreviewVisible'")>] member inline _.PreviewVisible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("PreviewVisible", valueFn)
    [<CustomOperation("PreviewVisibleChanged")>] member inline _.PreviewVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> unit) = render ==> html.callback("PreviewVisibleChanged", fn)
    [<CustomOperation("PreviewVisibleChanged")>] member inline _.PreviewVisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("PreviewVisibleChanged", fn)

type GenerateColumnsBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Range")>] member inline _.Range ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Range>) = render ==> ("Range" => x)
    [<CustomOperation("HideColumnsByName")>] member inline _.HideColumnsByName ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("HideColumnsByName" => x)
    [<CustomOperation("Definitions")>] member inline _.Definitions ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Definitions" => (System.Action<System.String, AntDesign.IFieldColumn>fn))

type TreeIndentBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("TreeLevel")>] member inline _.TreeLevel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TreeLevel" => x)

type TreeNodeCheckboxBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnCheckBoxClick")>] member inline _.OnCheckBoxClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnCheckBoxClick", fn)
    [<CustomOperation("OnCheckBoxClick")>] member inline _.OnCheckBoxClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCheckBoxClick", fn)

type TreeNodeSwitcherBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("OnSwitcherClick")>] member inline _.OnSwitcherClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnSwitcherClick", fn)
    [<CustomOperation("OnSwitcherClick")>] member inline _.OnSwitcherClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnSwitcherClick", fn)

type TreeNodeTitleBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type SummaryRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type ReusePagesBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Reuse")>] member inline _.Reuse ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("Reuse" => (defaultArg x true))
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member inline _.Styles ([<InlineIfLambda>] render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    [<CustomOperation("ActivedUri")>] member inline _.ActivedUri ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActivedUri" => x)
    [<CustomOperation("ActivedUri'")>] member inline _.ActivedUri' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("ActivedUri", valueFn)
    [<CustomOperation("ActivedUriChanged")>] member inline _.ActivedUriChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> unit) = render ==> html.callback("ActivedUriChanged", fn)
    [<CustomOperation("ActivedUriChanged")>] member inline _.ActivedUriChanged ([<InlineIfLambda>] render: AttrRenderFragment, fn: System.String -> Task<unit>) = render ==> html.callbackTask("ActivedUriChanged", fn)

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            
namespace rec AntDesign.DslInternals.statistic

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            
namespace rec AntDesign.DslInternals.Filters

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type FilterInputsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            
namespace rec AntDesign.DslInternals.Select

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type LabelTemplateItemBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("LabelTemplateItemContent")>] member inline _.LabelTemplateItemContent ([<InlineIfLambda>] render: AttrRenderFragment, fn: 'TItem -> NodeRenderFragment) = render ==> html.renderFragment("LabelTemplateItemContent", fn)
    [<CustomOperation("Styles")>] member inline _.Styles ([<InlineIfLambda>] render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
    [<CustomOperation("Classes")>] member inline _.Classes ([<InlineIfLambda>] render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("ContentStyle")>] member inline _.ContentStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)
    [<CustomOperation("ContentClass")>] member inline _.ContentClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContentClass" => x)
    [<CustomOperation("RemoveIconStyle")>] member inline _.RemoveIconStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RemoveIconStyle" => x)
    [<CustomOperation("RemoveIconClass")>] member inline _.RemoveIconClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RemoveIconClass" => x)
    [<CustomOperation("RefBack")>] member inline _.RefBack ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.ForwardRef) = render ==> ("RefBack" => x)

            
namespace rec AntDesign.DslInternals.Select.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type SelectSuffixIconBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("IsOverlayShow")>] member inline _.IsOverlayShow ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("IsOverlayShow" => (defaultArg x true))
    [<CustomOperation("ShowSearchIcon")>] member inline _.ShowSearchIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowSearchIcon" => (defaultArg x true))
    [<CustomOperation("ShowArrowIcon")>] member inline _.ShowArrowIcon ([<InlineIfLambda>] render: AttrRenderFragment, ?x: bool) = render ==> ("ShowArrowIcon" => (defaultArg x true))
    [<CustomOperation("OnClearClick")>] member inline _.OnClearClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearClick", fn)
    [<CustomOperation("OnClearClick")>] member inline _.OnClearClick ([<InlineIfLambda>] render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearClick", fn)

            
namespace rec AntDesign.DslInternals.core

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            
namespace rec AntDesign.DslInternals.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type FormRulesValidatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type TableRowWrapperBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("RowData")>] member inline _.RowData ([<InlineIfLambda>] render: AttrRenderFragment, x: AntDesign.TableModels.RowData<'TItem>) = render ==> ("RowData" => x)

            
namespace rec AntDesign.DslInternals.Internal.ModalDialog

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals

type ModalHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            

// =======================================================================================================================

namespace AntDesign

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals

    type AntComponentBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AntComponentBase>)>] () = inherit AntComponentBaseBuilder<AntDesign.AntComponentBase>()
    let AntComponentBase'' = AntComponentBase'()
    
    type AntDomComponentBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AntDomComponentBase>)>] () = inherit AntDomComponentBaseBuilder<AntDesign.AntDomComponentBase>()
    let AntDomComponentBase'' = AntDomComponentBase'()
    
    type Dropdown' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Dropdown>)>] () = inherit DropdownBuilder<AntDesign.Dropdown>()
    let Dropdown'' = Dropdown'()
    
    type DropdownButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DropdownButton>)>] () = inherit DropdownButtonBuilder<AntDesign.DropdownButton>()
    let DropdownButton'' = DropdownButton'()
    
    type Popconfirm' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Popconfirm>)>] () = inherit PopconfirmBuilder<AntDesign.Popconfirm>()
    let Popconfirm'' = Popconfirm'()
    
    type Popover' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Popover>)>] () = inherit PopoverBuilder<AntDesign.Popover>()
    let Popover'' = Popover'()
    
    type Tooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Tooltip>)>] () = inherit TooltipBuilder<AntDesign.Tooltip>()
    let Tooltip'' = Tooltip'()
    
    type ColumnBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ColumnBase>)>] () = inherit ColumnBaseBuilder<AntDesign.ColumnBase>()
    let ColumnBase'' = ColumnBase'()
    
    type ActionColumn' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ActionColumn>)>] () = inherit ActionColumnBuilder<AntDesign.ActionColumn>()
    let ActionColumn'' = ActionColumn'()
    
    type ColumnDefinition' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ColumnDefinition>)>] () = inherit ColumnDefinitionBuilder<AntDesign.ColumnDefinition>()
    let ColumnDefinition'' = ColumnDefinition'()
    
    type TableCell' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TableCell>)>] () = inherit TableCellBuilder<AntDesign.TableCell>()
    let TableCell'' = TableCell'()
    
    type SimpleTableHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SimpleTableHeader>)>] () = inherit SimpleTableHeaderBuilder<AntDesign.SimpleTableHeader>()
    let SimpleTableHeader'' = SimpleTableHeader'()
    
    type Column'<'TData> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Column<_>>)>] () = inherit ColumnBuilder<AntDesign.Column<'TData>, 'TData>()
    let Column''<'TData> = Column'<'TData>()
    
    type PropertyColumn'<'TItem, 'TProp> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.PropertyColumn<_, _>>)>] () = inherit PropertyColumnBuilder<AntDesign.PropertyColumn<'TItem, 'TProp>, 'TItem, 'TProp>()
    let PropertyColumn''<'TItem, 'TProp> = PropertyColumn'<'TItem, 'TProp>()
    
    type TableHeader'<'TData> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TableHeader<_>>)>] () = inherit TableHeaderBuilder<AntDesign.TableHeader<'TData>, 'TData>()
    let TableHeader''<'TData> = TableHeader'<'TData>()
    
    type Selection' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Selection>)>] () = inherit SelectionBuilder<AntDesign.Selection>()
    let Selection'' = Selection'()
    
    type SummaryCell' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SummaryCell>)>] () = inherit SummaryCellBuilder<AntDesign.SummaryCell>()
    let SummaryCell'' = SummaryCell'()
    
    type DatePickerPanelBase'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DatePickerPanelBase<_>>)>] () = inherit DatePickerPanelBaseBuilder<AntDesign.DatePickerPanelBase<'TValue>, 'TValue>()
    let DatePickerPanelBase''<'TValue> = DatePickerPanelBase'<'TValue>()
    
    type Button' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Button>)>] () = inherit ButtonBuilder<AntDesign.Button>()
    let Button'' = Button'()
    
    type DownloadButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DownloadButton>)>] () = inherit DownloadButtonBuilder<AntDesign.DownloadButton>()
    let DownloadButton'' = DownloadButton'()
    
    type Col' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Col>)>] () = inherit ColBuilder<AntDesign.Col>()
    let Col'' = Col'()
    
    type GridCol' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.GridCol>)>] () = inherit GridColBuilder<AntDesign.GridCol>()
    let GridCol'' = GridCol'()
    
    type Row' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Row>)>] () = inherit RowBuilder<AntDesign.Row>()
    let Row'' = Row'()
    
    type GridRow' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.GridRow>)>] () = inherit GridRowBuilder<AntDesign.GridRow>()
    let GridRow'' = GridRow'()
    
    type Icon' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Icon>)>] () = inherit IconBuilder<AntDesign.Icon>()
    let Icon'' = Icon'()
    
    type IconFont' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.IconFont>)>] () = inherit IconFontBuilder<AntDesign.IconFont>()
    let IconFont'' = IconFont'()
    
    type NotificationBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.NotificationBase>)>] () = inherit NotificationBaseBuilder<AntDesign.NotificationBase>()
    let NotificationBase'' = NotificationBase'()
    
    type Notification' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Notification>)>] () = inherit NotificationBuilder<AntDesign.Notification>()
    let Notification'' = Notification'()
    
    type NotificationItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.NotificationItem>)>] () = inherit NotificationItemBuilder<AntDesign.NotificationItem>()
    let NotificationItem'' = NotificationItem'()
    
    type TypographyBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TypographyBase>)>] () = inherit TypographyBaseBuilder<AntDesign.TypographyBase>()
    let TypographyBase'' = TypographyBase'()
    
    type Link' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Link>)>] () = inherit LinkBuilder<AntDesign.Link>()
    let Link'' = Link'()
    
    type Paragraph' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Paragraph>)>] () = inherit ParagraphBuilder<AntDesign.Paragraph>()
    let Paragraph'' = Paragraph'()
    
    type Text' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Text>)>] () = inherit TextBuilder<AntDesign.Text>()
    let Text'' = Text'()
    
    type Title' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Title>)>] () = inherit TitleBuilder<AntDesign.Title>()
    let Title'' = Title'()
    
    type Affix' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Affix>)>] () = inherit AffixBuilder<AntDesign.Affix>()
    let Affix'' = Affix'()
    
    type Alert' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Alert>)>] () = inherit AlertBuilder<AntDesign.Alert>()
    let Alert'' = Alert'()
    
    type Anchor' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Anchor>)>] () = inherit AnchorBuilder<AntDesign.Anchor>()
    let Anchor'' = Anchor'()
    
    type AnchorLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AnchorLink>)>] () = inherit AnchorLinkBuilder<AntDesign.AnchorLink>()
    let AnchorLink'' = AnchorLink'()
    
    type AutoCompleteOptGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AutoCompleteOptGroup>)>] () = inherit AutoCompleteOptGroupBuilder<AntDesign.AutoCompleteOptGroup>()
    let AutoCompleteOptGroup'' = AutoCompleteOptGroup'()
    
    type AutoCompleteOption' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AutoCompleteOption>)>] () = inherit AutoCompleteOptionBuilder<AntDesign.AutoCompleteOption>()
    let AutoCompleteOption'' = AutoCompleteOption'()
    
    type Avatar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Avatar>)>] () = inherit AvatarBuilder<AntDesign.Avatar>()
    let Avatar'' = Avatar'()
    
    type AvatarGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AvatarGroup>)>] () = inherit AvatarGroupBuilder<AntDesign.AvatarGroup>()
    let AvatarGroup'' = AvatarGroup'()
    
    type BackTop' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.BackTop>)>] () = inherit BackTopBuilder<AntDesign.BackTop>()
    let BackTop'' = BackTop'()
    
    type Badge' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Badge>)>] () = inherit BadgeBuilder<AntDesign.Badge>()
    let Badge'' = Badge'()
    
    type BadgeRibbon' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.BadgeRibbon>)>] () = inherit BadgeRibbonBuilder<AntDesign.BadgeRibbon>()
    let BadgeRibbon'' = BadgeRibbon'()
    
    type Breadcrumb' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Breadcrumb>)>] () = inherit BreadcrumbBuilder<AntDesign.Breadcrumb>()
    let Breadcrumb'' = Breadcrumb'()
    
    type ButtonGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ButtonGroup>)>] () = inherit ButtonGroupBuilder<AntDesign.ButtonGroup>()
    let ButtonGroup'' = ButtonGroup'()
    
    type Calendar' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Calendar>)>] () = inherit CalendarBuilder<AntDesign.Calendar>()
    let Calendar'' = Calendar'()
    
    type Card' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Card>)>] () = inherit CardBuilder<AntDesign.Card>()
    let Card'' = Card'()
    
    type CardAction' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.CardAction>)>] () = inherit CardActionBuilder<AntDesign.CardAction>()
    let CardAction'' = CardAction'()
    
    type CardGrid' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.CardGrid>)>] () = inherit CardGridBuilder<AntDesign.CardGrid>()
    let CardGrid'' = CardGrid'()
    
    type Carousel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Carousel>)>] () = inherit CarouselBuilder<AntDesign.Carousel>()
    let Carousel'' = Carousel'()
    
    type CarouselSlick' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.CarouselSlick>)>] () = inherit CarouselSlickBuilder<AntDesign.CarouselSlick>()
    let CarouselSlick'' = CarouselSlick'()
    
    type Collapse' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Collapse>)>] () = inherit CollapseBuilder<AntDesign.Collapse>()
    let Collapse'' = Collapse'()
    
    type Panel' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Panel>)>] () = inherit PanelBuilder<AntDesign.Panel>()
    let Panel'' = Panel'()
    
    type Comment' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Comment>)>] () = inherit CommentBuilder<AntDesign.Comment>()
    let Comment'' = Comment'()
    
    type AntContainerComponentBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AntContainerComponentBase>)>] () = inherit AntContainerComponentBaseBuilder<AntDesign.AntContainerComponentBase>()
    let AntContainerComponentBase'' = AntContainerComponentBase'()
    
    type AntInputComponentBase'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AntInputComponentBase<_>>)>] () = inherit AntInputComponentBaseBuilder<AntDesign.AntInputComponentBase<'TValue>, 'TValue>()
    let AntInputComponentBase''<'TValue> = AntInputComponentBase'<'TValue>()
    
    type AntInputBoolComponentBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AntInputBoolComponentBase>)>] () = inherit AntInputBoolComponentBaseBuilder<AntDesign.AntInputBoolComponentBase>()
    let AntInputBoolComponentBase'' = AntInputBoolComponentBase'()
    
    type Checkbox' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Checkbox>)>] () = inherit CheckboxBuilder<AntDesign.Checkbox>()
    let Checkbox'' = Checkbox'()
    
    type Switch' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Switch>)>] () = inherit SwitchBuilder<AntDesign.Switch>()
    let Switch'' = Switch'()
    
    type AutoComplete'<'TOption> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AutoComplete<_>>)>] () = inherit AutoCompleteBuilder<AntDesign.AutoComplete<'TOption>, 'TOption>()
    let AutoComplete''<'TOption> = AutoComplete'<'TOption>()
    
    type Cascader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Cascader>)>] () = inherit CascaderBuilder<AntDesign.Cascader>()
    let Cascader'' = Cascader'()
    
    type CheckboxGroup'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.CheckboxGroup<_>>)>] () = inherit CheckboxGroupBuilder<AntDesign.CheckboxGroup<'TValue>, 'TValue>()
    let CheckboxGroup''<'TValue> = CheckboxGroup'<'TValue>()
    
    type EnumCheckboxGroup'<'TEnum> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.EnumCheckboxGroup<_>>)>] () = inherit EnumCheckboxGroupBuilder<AntDesign.EnumCheckboxGroup<'TEnum>, 'TEnum>()
    let EnumCheckboxGroup''<'TEnum> = EnumCheckboxGroup'<'TEnum>()
    
    type DatePickerBase'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DatePickerBase<_>>)>] () = inherit DatePickerBaseBuilder<AntDesign.DatePickerBase<'TValue>, 'TValue>()
    let DatePickerBase''<'TValue> = DatePickerBase'<'TValue>()
    
    type DatePicker'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DatePicker<_>>)>] () = inherit DatePickerBuilder<AntDesign.DatePicker<'TValue>, 'TValue>()
    let DatePicker''<'TValue> = DatePicker'<'TValue>()
    
    type MonthPicker'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.MonthPicker<_>>)>] () = inherit MonthPickerBuilder<AntDesign.MonthPicker<'TValue>, 'TValue>()
    let MonthPicker''<'TValue> = MonthPicker'<'TValue>()
    
    type QuarterPicker'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.QuarterPicker<_>>)>] () = inherit QuarterPickerBuilder<AntDesign.QuarterPicker<'TValue>, 'TValue>()
    let QuarterPicker''<'TValue> = QuarterPicker'<'TValue>()
    
    type WeekPicker'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.WeekPicker<_>>)>] () = inherit WeekPickerBuilder<AntDesign.WeekPicker<'TValue>, 'TValue>()
    let WeekPicker''<'TValue> = WeekPicker'<'TValue>()
    
    type YearPicker'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.YearPicker<_>>)>] () = inherit YearPickerBuilder<AntDesign.YearPicker<'TValue>, 'TValue>()
    let YearPicker''<'TValue> = YearPicker'<'TValue>()
    
    type TimePicker'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TimePicker<_>>)>] () = inherit TimePickerBuilder<AntDesign.TimePicker<'TValue>, 'TValue>()
    let TimePicker''<'TValue> = TimePicker'<'TValue>()
    
    type RangePicker'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.RangePicker<_>>)>] () = inherit RangePickerBuilder<AntDesign.RangePicker<'TValue>, 'TValue>()
    let RangePicker''<'TValue> = RangePicker'<'TValue>()
    
    type InputNumber'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.InputNumber<_>>)>] () = inherit InputNumberBuilder<AntDesign.InputNumber<'TValue>, 'TValue>()
    let InputNumber''<'TValue> = InputNumber'<'TValue>()
    
    type Input'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Input<_>>)>] () = inherit InputBuilder<AntDesign.Input<'TValue>, 'TValue>()
    let Input''<'TValue> = Input'<'TValue>()
    
    type Search' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Search>)>] () = inherit SearchBuilder<AntDesign.Search>()
    let Search'' = Search'()
    
    type AutoCompleteSearch' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AutoCompleteSearch>)>] () = inherit AutoCompleteSearchBuilder<AntDesign.AutoCompleteSearch>()
    let AutoCompleteSearch'' = AutoCompleteSearch'()
    
    type AutoCompleteInput'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AutoCompleteInput<_>>)>] () = inherit AutoCompleteInputBuilder<AntDesign.AutoCompleteInput<'TValue>, 'TValue>()
    let AutoCompleteInput''<'TValue> = AutoCompleteInput'<'TValue>()
    
    type InputPassword' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.InputPassword>)>] () = inherit InputPasswordBuilder<AntDesign.InputPassword>()
    let InputPassword'' = InputPassword'()
    
    type TextArea' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TextArea>)>] () = inherit TextAreaBuilder<AntDesign.TextArea>()
    let TextArea'' = TextArea'()
    
    type RadioGroup'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.RadioGroup<_>>)>] () = inherit RadioGroupBuilder<AntDesign.RadioGroup<'TValue>, 'TValue>()
    let RadioGroup''<'TValue> = RadioGroup'<'TValue>()
    
    type EnumRadioGroup'<'TEnum> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.EnumRadioGroup<_>>)>] () = inherit EnumRadioGroupBuilder<AntDesign.EnumRadioGroup<'TEnum>, 'TEnum>()
    let EnumRadioGroup''<'TEnum> = EnumRadioGroup'<'TEnum>()
    
    type SelectBase'<'TItemValue, 'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SelectBase<_, _>>)>] () = inherit SelectBaseBuilder<AntDesign.SelectBase<'TItemValue, 'TItem>, 'TItemValue, 'TItem>()
    let SelectBase''<'TItemValue, 'TItem> = SelectBase'<'TItemValue, 'TItem>()
    
    type Select'<'TItemValue, 'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Select<_, _>>)>] () = inherit SelectBuilder<AntDesign.Select<'TItemValue, 'TItem>, 'TItemValue, 'TItem>()
    let Select''<'TItemValue, 'TItem> = Select'<'TItemValue, 'TItem>()
    
    type EnumSelect'<'TEnum> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.EnumSelect<_>>)>] () = inherit EnumSelectBuilder<AntDesign.EnumSelect<'TEnum>, 'TEnum>()
    let EnumSelect''<'TEnum> = EnumSelect'<'TEnum>()
    
    type SimpleSelect' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SimpleSelect>)>] () = inherit SimpleSelectBuilder<AntDesign.SimpleSelect>()
    let SimpleSelect'' = SimpleSelect'()
    
    type TreeSelect'<'TItemValue, 'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TreeSelect<_, _>>)>] () = inherit TreeSelectBuilder<AntDesign.TreeSelect<'TItemValue, 'TItem>, 'TItemValue, 'TItem>()
    let TreeSelect''<'TItemValue, 'TItem> = TreeSelect'<'TItemValue, 'TItem>()
    
    type Slider'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Slider<_>>)>] () = inherit SliderBuilder<AntDesign.Slider<'TValue>, 'TValue>()
    let Slider''<'TValue> = Slider'<'TValue>()
    
    type Descriptions' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Descriptions>)>] () = inherit DescriptionsBuilder<AntDesign.Descriptions>()
    let Descriptions'' = Descriptions'()
    
    type DescriptionsItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DescriptionsItem>)>] () = inherit DescriptionsItemBuilder<AntDesign.DescriptionsItem>()
    let DescriptionsItem'' = DescriptionsItem'()
    
    type Divider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Divider>)>] () = inherit DividerBuilder<AntDesign.Divider>()
    let Divider'' = Divider'()
    
    type Drawer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Drawer>)>] () = inherit DrawerBuilder<AntDesign.Drawer>()
    let Drawer'' = Drawer'()
    
    type DrawerContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DrawerContainer>)>] () = inherit DrawerContainerBuilder<AntDesign.DrawerContainer>()
    let DrawerContainer'' = DrawerContainer'()
    
    type Empty' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Empty>)>] () = inherit EmptyBuilder<AntDesign.Empty>()
    let Empty'' = Empty'()
    
    type Flex' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Flex>)>] () = inherit FlexBuilder<AntDesign.Flex>()
    let Flex'' = Flex'()
    
    type Form'<'TModel> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Form<_>>)>] () = inherit FormBuilder<AntDesign.Form<'TModel>, 'TModel>()
    let Form''<'TModel> = Form'<'TModel>()
    
    type FormItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.FormItem>)>] () = inherit FormItemBuilder<AntDesign.FormItem>()
    let FormItem'' = FormItem'()
    
    type Image' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Image>)>] () = inherit ImageBuilder<AntDesign.Image>()
    let Image'' = Image'()
    
    type ImagePreviewContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ImagePreviewContainer>)>] () = inherit ImagePreviewContainerBuilder<AntDesign.ImagePreviewContainer>()
    let ImagePreviewContainer'' = ImagePreviewContainer'()
    
    type InputGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.InputGroup>)>] () = inherit InputGroupBuilder<AntDesign.InputGroup>()
    let InputGroup'' = InputGroup'()
    
    type Sider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Sider>)>] () = inherit SiderBuilder<AntDesign.Sider>()
    let Sider'' = Sider'()
    
    type AntList'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AntList<_>>)>] () = inherit AntListBuilder<AntDesign.AntList<'TItem>, 'TItem>()
    let AntList''<'TItem> = AntList'<'TItem>()
    
    type ListItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ListItem>)>] () = inherit ListItemBuilder<AntDesign.ListItem>()
    let ListItem'' = ListItem'()
    
    type ListItemMeta' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ListItemMeta>)>] () = inherit ListItemMetaBuilder<AntDesign.ListItemMeta>()
    let ListItemMeta'' = ListItemMeta'()
    
    type Mentions' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Mentions>)>] () = inherit MentionsBuilder<AntDesign.Mentions>()
    let Mentions'' = Mentions'()
    
    type MentionsOption' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.MentionsOption>)>] () = inherit MentionsOptionBuilder<AntDesign.MentionsOption>()
    let MentionsOption'' = MentionsOption'()
    
    type Menu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Menu>)>] () = inherit MenuBuilder<AntDesign.Menu>()
    let Menu'' = Menu'()
    
    type MenuItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.MenuItem>)>] () = inherit MenuItemBuilder<AntDesign.MenuItem>()
    let MenuItem'' = MenuItem'()
    
    type MenuItemGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.MenuItemGroup>)>] () = inherit MenuItemGroupBuilder<AntDesign.MenuItemGroup>()
    let MenuItemGroup'' = MenuItemGroup'()
    
    type MenuLink' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.MenuLink>)>] () = inherit MenuLinkBuilder<AntDesign.MenuLink>()
    let MenuLink'' = MenuLink'()
    
    type SubMenu' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SubMenu>)>] () = inherit SubMenuBuilder<AntDesign.SubMenu>()
    let SubMenu'' = SubMenu'()
    
    type Message' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Message>)>] () = inherit MessageBuilder<AntDesign.Message>()
    let Message'' = Message'()
    
    type MessageItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.MessageItem>)>] () = inherit MessageItemBuilder<AntDesign.MessageItem>()
    let MessageItem'' = MessageItem'()
    
    type ComfirmContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ComfirmContainer>)>] () = inherit ComfirmContainerBuilder<AntDesign.ComfirmContainer>()
    let ComfirmContainer'' = ComfirmContainer'()
    
    type Confirm' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Confirm>)>] () = inherit ConfirmBuilder<AntDesign.Confirm>()
    let Confirm'' = Confirm'()
    
    type Dialog' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Dialog>)>] () = inherit DialogBuilder<AntDesign.Dialog>()
    let Dialog'' = Dialog'()
    
    type DialogWrapper' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DialogWrapper>)>] () = inherit DialogWrapperBuilder<AntDesign.DialogWrapper>()
    let DialogWrapper'' = DialogWrapper'()
    
    type Modal' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Modal>)>] () = inherit ModalBuilder<AntDesign.Modal>()
    let Modal'' = Modal'()
    
    type ModalCancelFooter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ModalCancelFooter>)>] () = inherit ModalCancelFooterBuilder<AntDesign.ModalCancelFooter>()
    let ModalCancelFooter'' = ModalCancelFooter'()
    
    type ModalContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ModalContainer>)>] () = inherit ModalContainerBuilder<AntDesign.ModalContainer>()
    let ModalContainer'' = ModalContainer'()
    
    type ModalFooter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ModalFooter>)>] () = inherit ModalFooterBuilder<AntDesign.ModalFooter>()
    let ModalFooter'' = ModalFooter'()
    
    type ModalOkFooter' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ModalOkFooter>)>] () = inherit ModalOkFooterBuilder<AntDesign.ModalOkFooter>()
    let ModalOkFooter'' = ModalOkFooter'()
    
    type PageHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.PageHeader>)>] () = inherit PageHeaderBuilder<AntDesign.PageHeader>()
    let PageHeader'' = PageHeader'()
    
    type Pagination' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Pagination>)>] () = inherit PaginationBuilder<AntDesign.Pagination>()
    let Pagination'' = Pagination'()
    
    type PaginationOptions' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.PaginationOptions>)>] () = inherit PaginationOptionsBuilder<AntDesign.PaginationOptions>()
    let PaginationOptions'' = PaginationOptions'()
    
    type Progress' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Progress>)>] () = inherit ProgressBuilder<AntDesign.Progress>()
    let Progress'' = Progress'()
    
    type Radio'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Radio<_>>)>] () = inherit RadioBuilder<AntDesign.Radio<'TValue>, 'TValue>()
    let Radio''<'TValue> = Radio'<'TValue>()
    
    type Rate' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Rate>)>] () = inherit RateBuilder<AntDesign.Rate>()
    let Rate'' = Rate'()
    
    type RateItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.RateItem>)>] () = inherit RateItemBuilder<AntDesign.RateItem>()
    let RateItem'' = RateItem'()
    
    type Result' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Result>)>] () = inherit ResultBuilder<AntDesign.Result>()
    let Result'' = Result'()
    
    type Segmented'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Segmented<_>>)>] () = inherit SegmentedBuilder<AntDesign.Segmented<'TValue>, 'TValue>()
    let Segmented''<'TValue> = Segmented'<'TValue>()
    
    type SegmentedItem'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SegmentedItem<_>>)>] () = inherit SegmentedItemBuilder<AntDesign.SegmentedItem<'TValue>, 'TValue>()
    let SegmentedItem''<'TValue> = SegmentedItem'<'TValue>()
    
    type SelectOption'<'TItemValue, 'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SelectOption<_, _>>)>] () = inherit SelectOptionBuilder<AntDesign.SelectOption<'TItemValue, 'TItem>, 'TItemValue, 'TItem>()
    let SelectOption''<'TItemValue, 'TItem> = SelectOption'<'TItemValue, 'TItem>()
    
    type SimpleSelectOption' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SimpleSelectOption>)>] () = inherit SimpleSelectOptionBuilder<AntDesign.SimpleSelectOption>()
    let SimpleSelectOption'' = SimpleSelectOption'()
    
    type Skeleton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Skeleton>)>] () = inherit SkeletonBuilder<AntDesign.Skeleton>()
    let Skeleton'' = Skeleton'()
    
    type SkeletonElement' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SkeletonElement>)>] () = inherit SkeletonElementBuilder<AntDesign.SkeletonElement>()
    let SkeletonElement'' = SkeletonElement'()
    
    type Space' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Space>)>] () = inherit SpaceBuilder<AntDesign.Space>()
    let Space'' = Space'()
    
    type SpaceItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SpaceItem>)>] () = inherit SpaceItemBuilder<AntDesign.SpaceItem>()
    let SpaceItem'' = SpaceItem'()
    
    type Spin' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Spin>)>] () = inherit SpinBuilder<AntDesign.Spin>()
    let Spin'' = Spin'()
    
    type StatisticComponentBase'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.StatisticComponentBase<_>>)>] () = inherit StatisticComponentBaseBuilder<AntDesign.StatisticComponentBase<'T>, 'T>()
    let StatisticComponentBase''<'T> = StatisticComponentBase'<'T>()
    
    type CountDown' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.CountDown>)>] () = inherit CountDownBuilder<AntDesign.CountDown>()
    let CountDown'' = CountDown'()
    
    type Statistic'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Statistic<_>>)>] () = inherit StatisticBuilder<AntDesign.Statistic<'TValue>, 'TValue>()
    let Statistic''<'TValue> = Statistic'<'TValue>()
    
    type Step' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Step>)>] () = inherit StepBuilder<AntDesign.Step>()
    let Step'' = Step'()
    
    type Steps' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Steps>)>] () = inherit StepsBuilder<AntDesign.Steps>()
    let Steps'' = Steps'()
    
    type Table'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Table<_>>)>] () = inherit TableBuilder<AntDesign.Table<'TItem>, 'TItem>()
    let Table''<'TItem> = Table'<'TItem>()
    
    type ReuseTabs' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ReuseTabs>)>] () = inherit ReuseTabsBuilder<AntDesign.ReuseTabs>()
    let ReuseTabs'' = ReuseTabs'()
    
    type TabPane' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TabPane>)>] () = inherit TabPaneBuilder<AntDesign.TabPane>()
    let TabPane'' = TabPane'()
    
    type Tabs' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Tabs>)>] () = inherit TabsBuilder<AntDesign.Tabs>()
    let Tabs'' = Tabs'()
    
    type Tag' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Tag>)>] () = inherit TagBuilder<AntDesign.Tag>()
    let Tag'' = Tag'()
    
    type Timeline' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Timeline>)>] () = inherit TimelineBuilder<AntDesign.Timeline>()
    let Timeline'' = Timeline'()
    
    type TimelineItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TimelineItem>)>] () = inherit TimelineItemBuilder<AntDesign.TimelineItem>()
    let TimelineItem'' = TimelineItem'()
    
    type Transfer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Transfer>)>] () = inherit TransferBuilder<AntDesign.Transfer>()
    let Transfer'' = Transfer'()
    
    type Tree'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Tree<_>>)>] () = inherit TreeBuilder<AntDesign.Tree<'TItem>, 'TItem>()
    let Tree''<'TItem> = Tree'<'TItem>()
    
    type DirectoryTree'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.DirectoryTree<_>>)>] () = inherit DirectoryTreeBuilder<AntDesign.DirectoryTree<'TItem>, 'TItem>()
    let DirectoryTree''<'TItem> = DirectoryTree'<'TItem>()
    
    type TreeNode'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TreeNode<_>>)>] () = inherit TreeNodeBuilder<AntDesign.TreeNode<'TItem>, 'TItem>()
    let TreeNode''<'TItem> = TreeNode'<'TItem>()
    
    type Upload' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Upload>)>] () = inherit UploadBuilder<AntDesign.Upload>()
    let Upload'' = Upload'()
    
    type Watermark' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Watermark>)>] () = inherit WatermarkBuilder<AntDesign.Watermark>()
    let Watermark'' = Watermark'()
    
    type BreadcrumbItem' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.BreadcrumbItem>)>] () = inherit BreadcrumbItemBuilder<AntDesign.BreadcrumbItem>()
    let BreadcrumbItem'' = BreadcrumbItem'()
    
    type CalendarHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.CalendarHeader>)>] () = inherit CalendarHeaderBuilder<AntDesign.CalendarHeader>()
    let CalendarHeader'' = CalendarHeader'()
    
    type CardMeta' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.CardMeta>)>] () = inherit CardMetaBuilder<AntDesign.CardMeta>()
    let CardMeta'' = CardMeta'()
    
    type AntContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.AntContainer>)>] () = inherit AntContainerBuilder<AntDesign.AntContainer>()
    let AntContainer'' = AntContainer'()
    
    type Template' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Template>)>] () = inherit TemplateBuilder<AntDesign.Template>()
    let Template'' = Template'()
    
    type EmptyDefaultImg' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.EmptyDefaultImg>)>] () = inherit EmptyDefaultImgBuilder<AntDesign.EmptyDefaultImg>()
    let EmptyDefaultImg'' = EmptyDefaultImg'()
    
    type EmptySimpleImg' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.EmptySimpleImg>)>] () = inherit EmptySimpleImgBuilder<AntDesign.EmptySimpleImg>()
    let EmptySimpleImg'' = EmptySimpleImg'()
    
    type Content' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Content>)>] () = inherit ContentBuilder<AntDesign.Content>()
    let Content'' = Content'()
    
    type Footer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Footer>)>] () = inherit FooterBuilder<AntDesign.Footer>()
    let Footer'' = Footer'()
    
    type Header' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Header>)>] () = inherit HeaderBuilder<AntDesign.Header>()
    let Header'' = Header'()
    
    type Layout' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Layout>)>] () = inherit LayoutBuilder<AntDesign.Layout>()
    let Layout'' = Layout'()
    
    type MenuDivider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.MenuDivider>)>] () = inherit MenuDividerBuilder<AntDesign.MenuDivider>()
    let MenuDivider'' = MenuDivider'()
    
    type PaginationPager' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.PaginationPager>)>] () = inherit PaginationPagerBuilder<AntDesign.PaginationPager>()
    let PaginationPager'' = PaginationPager'()
    
    type TableRow' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TableRow>)>] () = inherit TableRowBuilder<AntDesign.TableRow>()
    let TableRow'' = TableRow'()
    
    type ConfigProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ConfigProvider>)>] () = inherit ConfigProviderBuilder<AntDesign.ConfigProvider>()
    let ConfigProvider'' = ConfigProvider'()
    
    type TemplateComponentBase'<'TComponentOptions> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TemplateComponentBase<_>>)>] () = inherit TemplateComponentBaseBuilder<AntDesign.TemplateComponentBase<'TComponentOptions>, 'TComponentOptions>()
    let TemplateComponentBase''<'TComponentOptions> = TemplateComponentBase'<'TComponentOptions>()
    
    type FeedbackComponent'<'TComponentOptions> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.FeedbackComponent<_>>)>] () = inherit FeedbackComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions>, 'TComponentOptions>()
    let FeedbackComponent''<'TComponentOptions> = FeedbackComponent'<'TComponentOptions>()
    
    type FeedbackComponent'<'TComponentOptions, 'TResult> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.FeedbackComponent<_, _>>)>] () = inherit FeedbackComponentBuilder2<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>, 'TComponentOptions, 'TResult>()
    let FeedbackComponent''<'TComponentOptions, 'TResult> = FeedbackComponent'<'TComponentOptions, 'TResult>()
    
    type FormProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.FormProvider>)>] () = inherit FormProviderBuilder<AntDesign.FormProvider>()
    let FormProvider'' = FormProvider'()
    
    type Component' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Component>)>] () = inherit ComponentBuilder<AntDesign.Component>()
    let Component'' = Component'()
    
    type ForeachLoop'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ForeachLoop<_>>)>] () = inherit ForeachLoopBuilder<AntDesign.ForeachLoop<'TItem>, 'TItem>()
    let ForeachLoop''<'TItem> = ForeachLoop'<'TItem>()
    
    type GenerateFormItem'<'TModel> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.GenerateFormItem<_>>)>] () = inherit GenerateFormItemBuilder<AntDesign.GenerateFormItem<'TModel>, 'TModel>()
    let GenerateFormItem''<'TModel> = GenerateFormItem'<'TModel>()
    
    type ImagePreview' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ImagePreview>)>] () = inherit ImagePreviewBuilder<AntDesign.ImagePreview>()
    let ImagePreview'' = ImagePreview'()
    
    type ImagePreviewGroup' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ImagePreviewGroup>)>] () = inherit ImagePreviewGroupBuilder<AntDesign.ImagePreviewGroup>()
    let ImagePreviewGroup'' = ImagePreviewGroup'()
    
    type GenerateColumns'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.GenerateColumns<_>>)>] () = inherit GenerateColumnsBuilder<AntDesign.GenerateColumns<'TItem>, 'TItem>()
    let GenerateColumns''<'TItem> = GenerateColumns'<'TItem>()
    
    type TreeIndent'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TreeIndent<_>>)>] () = inherit TreeIndentBuilder<AntDesign.TreeIndent<'TItem>, 'TItem>()
    let TreeIndent''<'TItem> = TreeIndent'<'TItem>()
    
    type TreeNodeCheckbox'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TreeNodeCheckbox<_>>)>] () = inherit TreeNodeCheckboxBuilder<AntDesign.TreeNodeCheckbox<'TItem>, 'TItem>()
    let TreeNodeCheckbox''<'TItem> = TreeNodeCheckbox'<'TItem>()
    
    type TreeNodeSwitcher'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TreeNodeSwitcher<_>>)>] () = inherit TreeNodeSwitcherBuilder<AntDesign.TreeNodeSwitcher<'TItem>, 'TItem>()
    let TreeNodeSwitcher''<'TItem> = TreeNodeSwitcher'<'TItem>()
    
    type TreeNodeTitle'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.TreeNodeTitle<_>>)>] () = inherit TreeNodeTitleBuilder<AntDesign.TreeNodeTitle<'TItem>, 'TItem>()
    let TreeNodeTitle''<'TItem> = TreeNodeTitle'<'TItem>()
    
    type SummaryRow' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.SummaryRow>)>] () = inherit SummaryRowBuilder<AntDesign.SummaryRow>()
    let SummaryRow'' = SummaryRow'()
    
    type ReusePages' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.ReusePages>)>] () = inherit ReusePagesBuilder<AntDesign.ReusePages>()
    let ReusePages'' = ReusePages'()
    
    type _Imports' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign._Imports>)>] () = inherit _ImportsBuilder<AntDesign._Imports>()
    let _Imports'' = _Imports'()
    
            
namespace AntDesign.Internal

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals.Internal

    type OverlayTrigger' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.OverlayTrigger>)>] () = inherit OverlayTriggerBuilder<AntDesign.Internal.OverlayTrigger>()
    let OverlayTrigger'' = OverlayTrigger'()
    
    type SubMenuTrigger' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.SubMenuTrigger>)>] () = inherit SubMenuTriggerBuilder<AntDesign.Internal.SubMenuTrigger>()
    let SubMenuTrigger'' = SubMenuTrigger'()
    
    type PickerPanelBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.PickerPanelBase>)>] () = inherit PickerPanelBaseBuilder<AntDesign.Internal.PickerPanelBase>()
    let PickerPanelBase'' = PickerPanelBase'()
    
    type DatePickerDatetimePanel'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerDatetimePanel<_>>)>] () = inherit DatePickerDatetimePanelBuilder<AntDesign.Internal.DatePickerDatetimePanel<'TValue>, 'TValue>()
    let DatePickerDatetimePanel''<'TValue> = DatePickerDatetimePanel'<'TValue>()
    
    type DatePickerTemplate'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerTemplate<_>>)>] () = inherit DatePickerTemplateBuilder<AntDesign.Internal.DatePickerTemplate<'TValue>, 'TValue>()
    let DatePickerTemplate''<'TValue> = DatePickerTemplate'<'TValue>()
    
    type DatePickerDatePanel'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerDatePanel<_>>)>] () = inherit DatePickerDatePanelBuilder<AntDesign.Internal.DatePickerDatePanel<'TValue>, 'TValue>()
    let DatePickerDatePanel''<'TValue> = DatePickerDatePanel'<'TValue>()
    
    type DatePickerDecadePanel'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerDecadePanel<_>>)>] () = inherit DatePickerDecadePanelBuilder<AntDesign.Internal.DatePickerDecadePanel<'TValue>, 'TValue>()
    let DatePickerDecadePanel''<'TValue> = DatePickerDecadePanel'<'TValue>()
    
    type DatePickerFooter'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerFooter<_>>)>] () = inherit DatePickerFooterBuilder<AntDesign.Internal.DatePickerFooter<'TValue>, 'TValue>()
    let DatePickerFooter''<'TValue> = DatePickerFooter'<'TValue>()
    
    type DatePickerHeader'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerHeader<_>>)>] () = inherit DatePickerHeaderBuilder<AntDesign.Internal.DatePickerHeader<'TValue>, 'TValue>()
    let DatePickerHeader''<'TValue> = DatePickerHeader'<'TValue>()
    
    type DatePickerMonthPanel'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerMonthPanel<_>>)>] () = inherit DatePickerMonthPanelBuilder<AntDesign.Internal.DatePickerMonthPanel<'TValue>, 'TValue>()
    let DatePickerMonthPanel''<'TValue> = DatePickerMonthPanel'<'TValue>()
    
    type DatePickerQuarterPanel'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerQuarterPanel<_>>)>] () = inherit DatePickerQuarterPanelBuilder<AntDesign.Internal.DatePickerQuarterPanel<'TValue>, 'TValue>()
    let DatePickerQuarterPanel''<'TValue> = DatePickerQuarterPanel'<'TValue>()
    
    type DatePickerYearPanel'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerYearPanel<_>>)>] () = inherit DatePickerYearPanelBuilder<AntDesign.Internal.DatePickerYearPanel<'TValue>, 'TValue>()
    let DatePickerYearPanel''<'TValue> = DatePickerYearPanel'<'TValue>()
    
    type CalendarPanelChooser' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.CalendarPanelChooser>)>] () = inherit CalendarPanelChooserBuilder<AntDesign.Internal.CalendarPanelChooser>()
    let CalendarPanelChooser'' = CalendarPanelChooser'()
    
    type Element' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.Element>)>] () = inherit ElementBuilder<AntDesign.Internal.Element>()
    let Element'' = Element'()
    
    type Overlay' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.Overlay>)>] () = inherit OverlayBuilder<AntDesign.Internal.Overlay>()
    let Overlay'' = Overlay'()
    
    type DatePickerPanelChooser'<'TValue> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerPanelChooser<_>>)>] () = inherit DatePickerPanelChooserBuilder<AntDesign.Internal.DatePickerPanelChooser<'TValue>, 'TValue>()
    let DatePickerPanelChooser''<'TValue> = DatePickerPanelChooser'<'TValue>()
    
    type UploadButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.UploadButton>)>] () = inherit UploadButtonBuilder<AntDesign.Internal.UploadButton>()
    let UploadButton'' = UploadButton'()
    
    type DatePickerInput' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DatePickerInput>)>] () = inherit DatePickerInputBuilder<AntDesign.Internal.DatePickerInput>()
    let DatePickerInput'' = DatePickerInput'()
    
    type DropdownGroupButton' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.DropdownGroupButton>)>] () = inherit DropdownGroupButtonBuilder<AntDesign.Internal.DropdownGroupButton>()
    let DropdownGroupButton'' = DropdownGroupButton'()
    
    type FormRulesValidator' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.FormRulesValidator>)>] () = inherit FormRulesValidatorBuilder<AntDesign.Internal.FormRulesValidator>()
    let FormRulesValidator'' = FormRulesValidator'()
    
    type TableRowWrapper'<'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.TableRowWrapper<_>>)>] () = inherit TableRowWrapperBuilder<AntDesign.Internal.TableRowWrapper<'TItem>, 'TItem>()
    let TableRowWrapper''<'TItem> = TableRowWrapper'<'TItem>()
    
            
namespace AntDesign.Select.Internal

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals.Select.Internal

    type SelectContent'<'TItemValue, 'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Select.Internal.SelectContent<_, _>>)>] () = inherit SelectContentBuilder<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>, 'TItemValue, 'TItem>()
    let SelectContent''<'TItemValue, 'TItem> = SelectContent'<'TItemValue, 'TItem>()
    
    type SelectOptionGroup'<'TItemValue, 'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Select.Internal.SelectOptionGroup<_, _>>)>] () = inherit SelectOptionGroupBuilder<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>, 'TItemValue, 'TItem>()
    let SelectOptionGroup''<'TItemValue, 'TItem> = SelectOptionGroup'<'TItemValue, 'TItem>()
    
    type SelectSuffixIcon'<'TItemValue, 'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Select.Internal.SelectSuffixIcon<_, _>>)>] () = inherit SelectSuffixIconBuilder<AntDesign.Select.Internal.SelectSuffixIcon<'TItemValue, 'TItem>, 'TItemValue, 'TItem>()
    let SelectSuffixIcon''<'TItemValue, 'TItem> = SelectSuffixIcon'<'TItemValue, 'TItem>()
    
            
namespace AntDesign.Core.Component.ResizeObserver

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals.Core.Component.ResizeObserver

    type ResizeObserver' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Core.Component.ResizeObserver.ResizeObserver>)>] () = inherit ResizeObserverBuilder<AntDesign.Core.Component.ResizeObserver.ResizeObserver>()
    let ResizeObserver'' = ResizeObserver'()
    
            
namespace AntDesign.statistic

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals.statistic

    type StatisticComponentBase'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.statistic.StatisticComponentBase<_>>)>] () = inherit StatisticComponentBaseBuilder<AntDesign.statistic.StatisticComponentBase<'T>, 'T>()
    let StatisticComponentBase''<'T> = StatisticComponentBase'<'T>()
    
            
namespace AntDesign.Filters

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals.Filters

    type FilterInputs' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Filters.FilterInputs>)>] () = inherit FilterInputsBuilder<AntDesign.Filters.FilterInputs>()
    let FilterInputs'' = FilterInputs'()
    
            
namespace AntDesign.Select

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals.Select

    type LabelTemplateItem'<'TItemValue, 'TItem> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Select.LabelTemplateItem<_, _>>)>] () = inherit LabelTemplateItemBuilder<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>, 'TItemValue, 'TItem>()
    let LabelTemplateItem''<'TItemValue, 'TItem> = LabelTemplateItem'<'TItemValue, 'TItem>()
    
            
namespace AntDesign.core

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals.core

    type _Imports' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.core._Imports>)>] () = inherit _ImportsBuilder<AntDesign.core._Imports>()
    let _Imports'' = _Imports'()
    
            
namespace AntDesign.Internal.ModalDialog

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open AntDesign.DslInternals.Internal.ModalDialog

    type ModalHeader' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AntDesign.Internal.ModalDialog.ModalHeader>)>] () = inherit ModalHeaderBuilder<AntDesign.Internal.ModalDialog.ModalHeader>()
    let ModalHeader'' = ModalHeader'()
    
            