namespace rec AntDesign.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type antComponentBase<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<AntDesign.AntComponentBase>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AntComponentBase>

    static member ref x = attr.ref<AntDesign.AntComponentBase> x
    static member refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type antDomComponentBase<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AntDomComponentBase>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AntDomComponentBase>

    static member ref x = attr.ref<AntDesign.AntDomComponentBase> x
    static member id (x: System.String) = "Id" => x |> FelizNode<'FunBlazorGeneric>.create
    static member classes (x: string list) = attr.classes x |> FelizNode<'FunBlazorGeneric>.create
    static member styles (x: (string * string) list) = attr.styles x |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type overlayTrigger<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Internal.OverlayTrigger>
    static member ref x = attr.ref<AntDesign.Internal.OverlayTrigger> x
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hiddenMode (x: System.Boolean) = "HiddenMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isButton (x: System.Boolean) = "IsButton" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onMaskClick fn = attr.callbackOfUnit("OnMaskClick", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onMouseEnter fn = attr.callbackOfUnit("OnMouseEnter", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onMouseLeave fn = attr.callbackOfUnit("OnMouseLeave", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onOverlayHiding fn = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member overlay (node) = Bolero.Html.attr.fragment "Overlay" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member overlayClassName (x: System.String) = "OverlayClassName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member overlayEnterCls (x: System.String) = "OverlayEnterCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member overlayStyle (x: System.String) = "OverlayStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placement (x: AntDesign.Placement) = "Placement" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placementCls (x: System.String) = "PlacementCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> FelizNode<'FunBlazorGeneric>.create
    static member trigger (x: AntDesign.Trigger[]) = "Trigger" => x |> FelizNode<'FunBlazorGeneric>.create
    static member triggerCls (x: System.String) = "TriggerCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> FelizNode<'FunBlazorGeneric>.create
    static member unbound (render: AntDesign.ForwardRef -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member visible (x: System.Boolean) = "Visible" => x |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type dropdown<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Dropdown>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Dropdown>

    static member ref x = attr.ref<AntDesign.Dropdown> x

                    

type dropdownButton<'FunBlazorGeneric> =
    inherit dropdown<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.DropdownButton>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.DropdownButton>

    static member ref x = attr.ref<AntDesign.DropdownButton> x
    static member block (x: System.Boolean) = "Block" => x |> FelizNode<'FunBlazorGeneric>.create
    static member buttonsRender (fn) = Bolero.FragmentAttr ("ButtonsRender", fun render -> box (System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1 x2))))) |> FelizNode<'FunBlazorGeneric>.create
    static member buttonsClass (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "ButtonsClass" => x |> FelizNode<'FunBlazorGeneric>.create
    static member buttonsStyle (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "ButtonsStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member danger (x: System.Boolean) = "Danger" => x |> FelizNode<'FunBlazorGeneric>.create
    static member ghost (x: System.Boolean) = "Ghost" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type popconfirm<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Popconfirm>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Popconfirm>

    static member ref x = attr.ref<AntDesign.Popconfirm> x
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member cancelText (x: System.String) = "CancelText" => x |> FelizNode<'FunBlazorGeneric>.create
    static member okText (x: System.String) = "OkText" => x |> FelizNode<'FunBlazorGeneric>.create
    static member okType (x: System.String) = "OkType" => x |> FelizNode<'FunBlazorGeneric>.create
    static member okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member iconTemplate (x: string) = Bolero.Html.attr.fragment "IconTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member iconTemplate (node) = Bolero.Html.attr.fragment "IconTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member iconTemplate (nodes) = Bolero.Html.attr.fragment "IconTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onCancel fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onConfirm fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnConfirm" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type popover<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Popover>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Popover>

    static member ref x = attr.ref<AntDesign.Popover> x
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member content (x: System.String) = "Content" => x |> FelizNode<'FunBlazorGeneric>.create
    static member contentTemplate (x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member contentTemplate (node) = Bolero.Html.attr.fragment "ContentTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member contentTemplate (nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type tooltip<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Tooltip>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Tooltip>

    static member ref x = attr.ref<AntDesign.Tooltip> x
    static member title (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type subMenuTrigger<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.SubMenuTrigger>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.SubMenuTrigger>

    static member ref x = attr.ref<AntDesign.Internal.SubMenuTrigger> x
    static member triggerClass (x: System.String) = "TriggerClass" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type pickerPanelBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.PickerPanelBase>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.PickerPanelBase>

    static member ref x = attr.ref<AntDesign.Internal.PickerPanelBase> x
    static member onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member pickerIndex (x: System.Int32) = "PickerIndex" => x |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type datePickerPanelBase<'FunBlazorGeneric, 'TValue> =
    inherit Internal.pickerPanelBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.DatePickerPanelBase<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.DatePickerPanelBase<'TValue>>

    static member ref x = attr.ref<AntDesign.DatePickerPanelBase<'TValue>> x
    static member prefixCls (x: System.String) = "PrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member picker (x: System.String) = "Picker" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isRange (x: System.Boolean) = "IsRange" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isCalendar (x: System.Boolean) = "IsCalendar" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isShowHeader (x: System.Boolean) = "IsShowHeader" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isShowTime (x: System.Boolean) = "IsShowTime" => x |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> FelizNode<'FunBlazorGeneric>.create
    static member closePanel (x: System.Action) = "ClosePanel" => x |> FelizNode<'FunBlazorGeneric>.create
    static member changePickerValue (fn) = "ChangePickerValue" => (System.Action<System.DateTime, System.Nullable<System.Int32>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member changeValue (fn) = "ChangeValue" => (System.Action<System.DateTime, System.Int32>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member changePickerType (fn) = "ChangePickerType" => (System.Action<System.String, System.Int32>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member getIndexPickerValue (fn) = "GetIndexPickerValue" => (System.Func<System.Int32, System.DateTime>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member getIndexValue (fn) = "GetIndexValue" => (System.Func<System.Int32, System.Nullable<System.DateTime>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member dateRender (fn) = Bolero.FragmentAttr ("DateRender", fun render -> box (System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1 x2))))) |> FelizNode<'FunBlazorGeneric>.create
    static member monthCellRender (fn) = Bolero.FragmentAttr ("MonthCellRender", fun render -> box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member calendarDateRender (fn) = Bolero.FragmentAttr ("CalendarDateRender", fun render -> box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member calendarMonthCellRender (fn) = Bolero.FragmentAttr ("CalendarMonthCellRender", fun render -> box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type datePickerDatetimePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerDatetimePanel<'TValue>> x
    static member showToday (x: System.Boolean) = "ShowToday" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showTimeFormat (x: System.String) = "ShowTimeFormat" => x |> FelizNode<'FunBlazorGeneric>.create
    static member format (x: System.String) = "Format" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabledHours (fn) = "DisabledHours" => (System.Func<System.DateTime, System.Int32[]>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledMinutes (fn) = "DisabledMinutes" => (System.Func<System.DateTime, System.Int32[]>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledSeconds (fn) = "DisabledSeconds" => (System.Func<System.DateTime, System.Int32[]>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledTime (fn) = "DisabledTime" => (System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onOkClick fn = attr.callbackOfUnit("OnOkClick", fn) |> FelizNode<'FunBlazorGeneric>.create
                    

type datePickerTemplate<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerTemplate<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerTemplate<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerTemplate<'TValue>> x
    static member renderPickerHeader (x: string) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member renderPickerHeader (node) = Bolero.Html.attr.fragment "RenderPickerHeader" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member renderPickerHeader (nodes) = Bolero.Html.attr.fragment "RenderPickerHeader" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member renderTableHeader (x: string) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member renderTableHeader (node) = Bolero.Html.attr.fragment "RenderTableHeader" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member renderTableHeader (nodes) = Bolero.Html.attr.fragment "RenderTableHeader" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member renderFirstCol (render: System.DateTime -> Bolero.Node) = Bolero.Html.attr.fragmentWith "RenderFirstCol" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member renderColValue (render: System.DateTime -> Bolero.Node) = Bolero.Html.attr.fragmentWith "RenderColValue" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member renderLastCol (render: System.DateTime -> Bolero.Node) = Bolero.Html.attr.fragmentWith "RenderLastCol" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member viewStartDate (x: System.DateTime) = "ViewStartDate" => x |> FelizNode<'FunBlazorGeneric>.create
    static member getColTitle (fn) = "GetColTitle" => (System.Func<System.DateTime, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member getRowClass (fn) = "GetRowClass" => (System.Func<System.DateTime, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member getNextColValue (fn) = "GetNextColValue" => (System.Func<System.DateTime, System.DateTime>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member isInView (fn) = "IsInView" => (System.Func<System.DateTime, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member isToday (fn) = "IsToday" => (System.Func<System.DateTime, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member isSelected (fn) = "IsSelected" => (System.Func<System.DateTime, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onRowSelect (fn) = "OnRowSelect" => (System.Action<System.DateTime>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onValueSelect (fn) = "OnValueSelect" => (System.Action<System.DateTime>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member showFooter (x: System.Boolean) = "ShowFooter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maxRow (x: System.Int32) = "MaxRow" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maxCol (x: System.Int32) = "MaxCol" => x |> FelizNode<'FunBlazorGeneric>.create
    static member skipDays (x: System.Int32) = "SkipDays" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type datePickerDatePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerDatePanel<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerDatePanel<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerDatePanel<'TValue>> x
    static member isWeek (x: System.Boolean) = "IsWeek" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showToday (x: System.Boolean) = "ShowToday" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type datePickerDecadePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerDecadePanel<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerDecadePanel<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerDecadePanel<'TValue>> x

                    

type datePickerFooter<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerFooter<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerFooter<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerFooter<'TValue>> x

                    

type datePickerHeader<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerHeader<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerHeader<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerHeader<'TValue>> x
    static member superChangeDateInterval (x: System.Int32) = "SuperChangeDateInterval" => x |> FelizNode<'FunBlazorGeneric>.create
    static member changeDateInterval (x: System.Int32) = "ChangeDateInterval" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSuperPreChange (x: System.Boolean) = "ShowSuperPreChange" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showPreChange (x: System.Boolean) = "ShowPreChange" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showNextChange (x: System.Boolean) = "ShowNextChange" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSuperNextChange (x: System.Boolean) = "ShowSuperNextChange" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type datePickerMonthPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerMonthPanel<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerMonthPanel<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerMonthPanel<'TValue>> x

                    

type datePickerQuarterPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerQuarterPanel<'TValue>> x

                    

type datePickerYearPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerYearPanel<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerYearPanel<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerYearPanel<'TValue>> x

                    
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type col<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Col>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Col>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Col>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Col>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Col>
    static member ref x = attr.ref<AntDesign.Col> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member flex (x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> FelizNode<'FunBlazorGeneric>.create
    static member span (x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> FelizNode<'FunBlazorGeneric>.create
    static member order (x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> FelizNode<'FunBlazorGeneric>.create
    static member offset (x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member push (x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pull (x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> FelizNode<'FunBlazorGeneric>.create
    static member xs (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> FelizNode<'FunBlazorGeneric>.create
    static member sm (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> FelizNode<'FunBlazorGeneric>.create
    static member md (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> FelizNode<'FunBlazorGeneric>.create
    static member lg (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> FelizNode<'FunBlazorGeneric>.create
    static member xl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> FelizNode<'FunBlazorGeneric>.create
    static member xxl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type gridCol<'FunBlazorGeneric> =
    inherit col<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.GridCol>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.GridCol>

    static member ref x = attr.ref<AntDesign.GridCol> x

                    

type icon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Icon>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Icon>

    static member ref x = attr.ref<AntDesign.Icon> x
    static member spin (x: System.Boolean) = "Spin" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rotate (x: System.Int32) = "Rotate" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member theme (x: System.String) = "Theme" => x |> FelizNode<'FunBlazorGeneric>.create
    static member twotoneColor (x: System.String) = "TwotoneColor" => x |> FelizNode<'FunBlazorGeneric>.create
    static member iconFont (x: System.String) = "IconFont" => x |> FelizNode<'FunBlazorGeneric>.create
    static member width (x: System.String) = "Width" => x |> FelizNode<'FunBlazorGeneric>.create
    static member height (x: System.String) = "Height" => x |> FelizNode<'FunBlazorGeneric>.create
    static member fill (x: System.String) = "Fill" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tabIndex (x: System.String) = "TabIndex" => x |> FelizNode<'FunBlazorGeneric>.create
    static member stopPropagation (x: System.Boolean) = "StopPropagation" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member component' (x: string) = Bolero.Html.attr.fragment "Component" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member component' (node) = Bolero.Html.attr.fragment "Component" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member component' (nodes) = Bolero.Html.attr.fragment "Component" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type iconFont<'FunBlazorGeneric> =
    inherit icon<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.IconFont>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.IconFont>

    static member ref x = attr.ref<AntDesign.IconFont> x

                    

type notificationBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.NotificationBase>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.NotificationBase>

    static member ref x = attr.ref<AntDesign.NotificationBase> x

                    

type notification<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Notification>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Notification>

    static member ref x = attr.ref<AntDesign.Notification> x

                    

type notificationItem<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.NotificationItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.NotificationItem>

    static member ref x = attr.ref<AntDesign.NotificationItem> x
    static member config (x: AntDesign.NotificationConfig) = "Config" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClose (fn) = "OnClose" => (System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>fn) |> FelizNode<'FunBlazorGeneric>.create
                    

type columnBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ColumnBase>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ColumnBase>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.ColumnBase>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.ColumnBase>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.ColumnBase>
    static member ref x = attr.ref<AntDesign.ColumnBase> x
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member width (x: System.String) = "Width" => x |> FelizNode<'FunBlazorGeneric>.create
    static member headerStyle (x: System.String) = "HeaderStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rowSpan (x: System.Int32) = "RowSpan" => x |> FelizNode<'FunBlazorGeneric>.create
    static member colSpan (x: System.Int32) = "ColSpan" => x |> FelizNode<'FunBlazorGeneric>.create
    static member headerColSpan (x: System.Int32) = "HeaderColSpan" => x |> FelizNode<'FunBlazorGeneric>.create
    static member fixed' (x: System.String) = "Fixed" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member ellipsis (x: System.Boolean) = "Ellipsis" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hidden (x: System.Boolean) = "Hidden" => x |> FelizNode<'FunBlazorGeneric>.create
    static member align (x: AntDesign.ColumnAlign) = "Align" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cellRender (render: AntDesign.TableModels.CellData -> Bolero.Node) = Bolero.Html.attr.fragmentWith "CellRender" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
                    

type actionColumn<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ActionColumn>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ActionColumn>

    static member ref x = attr.ref<AntDesign.ActionColumn> x

                    

type column<'FunBlazorGeneric, 'TData> =
    inherit columnBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Column<'TData>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Column<'TData>>

    static member ref x = attr.ref<AntDesign.Column<'TData>> x
    static member fieldChanged fn = (Bolero.Html.attr.callback<'TData> "FieldChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member fieldExpression (x: System.Linq.Expressions.Expression<System.Func<'TData>>) = "FieldExpression" => x |> FelizNode<'FunBlazorGeneric>.create
    static member field (x: 'TData) = "Field" => x |> FelizNode<'FunBlazorGeneric>.create
    static member field' (value: IStore<'TData>) = FelizNode<'FunBlazorGeneric>.create("Field", value)
    static member field' (value: cval<'TData>) = FelizNode<'FunBlazorGeneric>.create("Field", value)
    static member field' (valueFn: 'TData * ('TData -> unit)) = FelizNode<'FunBlazorGeneric>.create("Field", valueFn)
    static member dataIndex (x: System.String) = "DataIndex" => x |> FelizNode<'FunBlazorGeneric>.create
    static member format (x: System.String) = "Format" => x |> FelizNode<'FunBlazorGeneric>.create
    static member sortable (x: System.Boolean) = "Sortable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member sorterCompare (fn) = "SorterCompare" => (System.Func<'TData, 'TData, System.Int32>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member sorterMultiple (x: System.Int32) = "SorterMultiple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSorterTooltip (x: System.Boolean) = "ShowSorterTooltip" => x |> FelizNode<'FunBlazorGeneric>.create
    static member sortDirections (x: AntDesign.SortDirection[]) = "SortDirections" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultSortOrder (x: AntDesign.SortDirection) = "DefaultSortOrder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onCell (fn) = "OnCell" => (System.Func<AntDesign.TableModels.CellData, System.Collections.Generic.Dictionary<System.String, System.Object>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onHeaderCell (fn) = "OnHeaderCell" => (System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member filterable (x: System.Boolean) = "Filterable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member filters (x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = "Filters" => x |> FelizNode<'FunBlazorGeneric>.create
    static member filterMultiple (x: System.Boolean) = "FilterMultiple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onFilter (x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = "OnFilter" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type selection<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Selection>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Selection>

    static member ref x = attr.ref<AntDesign.Selection> x
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member key (x: System.String) = "Key" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkStrictly (x: System.Boolean) = "CheckStrictly" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type summaryCell<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.SummaryCell>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SummaryCell>

    static member ref x = attr.ref<AntDesign.SummaryCell> x

                    

type typographyBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.TypographyBase>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TypographyBase>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.TypographyBase>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.TypographyBase>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.TypographyBase>
    static member ref x = attr.ref<AntDesign.TypographyBase> x
    static member copyable (x: System.Boolean) = "Copyable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> FelizNode<'FunBlazorGeneric>.create
    static member delete (x: System.Boolean) = "Delete" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member editable (x: System.Boolean) = "Editable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> FelizNode<'FunBlazorGeneric>.create
    static member ellipsis (x: System.Boolean) = "Ellipsis" => x |> FelizNode<'FunBlazorGeneric>.create
    static member ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mark (x: System.Boolean) = "Mark" => x |> FelizNode<'FunBlazorGeneric>.create
    static member underline (x: System.Boolean) = "Underline" => x |> FelizNode<'FunBlazorGeneric>.create
    static member strong (x: System.Boolean) = "Strong" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange (x: System.Action) = "OnChange" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type link<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Link>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Link>

    static member ref x = attr.ref<AntDesign.Link> x
    static member code (x: System.Boolean) = "Code" => x |> FelizNode<'FunBlazorGeneric>.create
    static member keyboard (x: System.Boolean) = "Keyboard" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type paragraph<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Paragraph>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Paragraph>

    static member ref x = attr.ref<AntDesign.Paragraph> x
    static member code (x: System.Boolean) = "Code" => x |> FelizNode<'FunBlazorGeneric>.create
    static member keyboard (x: System.Boolean) = "Keyboard" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type text<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Text>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Text>

    static member ref x = attr.ref<AntDesign.Text> x
    static member code (x: System.Boolean) = "Code" => x |> FelizNode<'FunBlazorGeneric>.create
    static member keyboard (x: System.Boolean) = "Keyboard" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type title<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Title>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Title>

    static member ref x = attr.ref<AntDesign.Title> x
    static member level (x: System.Int32) = "Level" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type affix<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Affix>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Affix>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Affix>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Affix>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Affix>
    static member ref x = attr.ref<AntDesign.Affix> x
    static member offsetBottom (x: System.Int32) = "OffsetBottom" => x |> FelizNode<'FunBlazorGeneric>.create
    static member offsetTop (x: System.Int32) = "OffsetTop" => x |> FelizNode<'FunBlazorGeneric>.create
    static member targetSelector (x: System.String) = "TargetSelector" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type alert<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Alert>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Alert>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Alert>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Alert>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Alert>
    static member ref x = attr.ref<AntDesign.Alert> x
    static member afterClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AfterClose" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member banner (x: System.Boolean) = "Banner" => x |> FelizNode<'FunBlazorGeneric>.create
    static member closable (x: System.Boolean) = "Closable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member closeText (x: System.String) = "CloseText" => x |> FelizNode<'FunBlazorGeneric>.create
    static member description (x: System.String) = "Description" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: string) = Bolero.Html.attr.fragment "Icon" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member icon (node) = Bolero.Html.attr.fragment "Icon" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member icon (nodes) = Bolero.Html.attr.fragment "Icon" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member message (x: System.String) = "Message" => x |> FelizNode<'FunBlazorGeneric>.create
    static member messageTemplate (x: string) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member messageTemplate (node) = Bolero.Html.attr.fragment "MessageTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member messageTemplate (nodes) = Bolero.Html.attr.fragment "MessageTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member showIcon (x: System.Nullable<System.Boolean>) = "ShowIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type anchor<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Anchor>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Anchor>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Anchor>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Anchor>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Anchor>
    static member ref x = attr.ref<AntDesign.Anchor> x
    static member key (x: System.String) = "Key" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member affix (x: System.Boolean) = "Affix" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bounds (x: System.Int32) = "Bounds" => x |> FelizNode<'FunBlazorGeneric>.create
    static member getContainer (fn) = "GetContainer" => (System.Func<System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member offsetBottom (x: System.Nullable<System.Int32>) = "OffsetBottom" => x |> FelizNode<'FunBlazorGeneric>.create
    static member offsetTop (x: System.Nullable<System.Int32>) = "OffsetTop" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showInkInFixed (x: System.Boolean) = "ShowInkInFixed" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink>> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member getCurrentAnchor (fn) = "GetCurrentAnchor" => (System.Func<System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member targetOffset (x: System.Nullable<System.Int32>) = "TargetOffset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type anchorLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AnchorLink>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AnchorLink>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.AnchorLink>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.AnchorLink>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.AnchorLink>
    static member ref x = attr.ref<AntDesign.AnchorLink> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member href (x: System.String) = "Href" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member target (x: System.String) = "Target" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type autoCompleteOptGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.AutoCompleteOptGroup>
    static member ref x = attr.ref<AntDesign.AutoCompleteOptGroup> x
    static member label (x: System.String) = "Label" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelFragment (x: string) = Bolero.Html.attr.fragment "LabelFragment" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member labelFragment (node) = Bolero.Html.attr.fragment "LabelFragment" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member labelFragment (nodes) = Bolero.Html.attr.fragment "LabelFragment" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type autoCompleteOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AutoCompleteOption>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AutoCompleteOption>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.AutoCompleteOption>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.AutoCompleteOption>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.AutoCompleteOption>
    static member ref x = attr.ref<AntDesign.AutoCompleteOption> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: System.Object) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member label (x: System.String) = "Label" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoComplete (x: AntDesign.IAutoCompleteRef) = "AutoComplete" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type avatar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Avatar>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Avatar>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Avatar>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Avatar>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Avatar>
    static member ref x = attr.ref<AntDesign.Avatar> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member shape (x: System.String) = "Shape" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member text (x: System.String) = "Text" => x |> FelizNode<'FunBlazorGeneric>.create
    static member src (x: System.String) = "Src" => x |> FelizNode<'FunBlazorGeneric>.create
    static member srcSet (x: System.String) = "SrcSet" => x |> FelizNode<'FunBlazorGeneric>.create
    static member alt (x: System.String) = "Alt" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onError fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.ErrorEventArgs> "OnError" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type avatarGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AvatarGroup>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AvatarGroup>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.AvatarGroup>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.AvatarGroup>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.AvatarGroup>
    static member ref x = attr.ref<AntDesign.AvatarGroup> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member maxCount (x: System.Int32) = "MaxCount" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maxStyle (x: System.String) = "MaxStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maxPopoverPlacement (x: AntDesign.Placement) = "MaxPopoverPlacement" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type backTop<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.BackTop>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.BackTop>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.BackTop>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.BackTop>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.BackTop>
    static member ref x = attr.ref<AntDesign.BackTop> x
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member visibilityHeight (x: System.Double) = "VisibilityHeight" => x |> FelizNode<'FunBlazorGeneric>.create
    static member targetSelector (x: System.String) = "TargetSelector" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = attr.callbackOfUnit("OnClick", fn) |> FelizNode<'FunBlazorGeneric>.create
                    

type badge<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Badge>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Badge>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Badge>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Badge>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Badge>
    static member ref x = attr.ref<AntDesign.Badge> x
    static member color (x: System.String) = "Color" => x |> FelizNode<'FunBlazorGeneric>.create
    static member presetColor (x: System.Nullable<AntDesign.PresetColor>) = "PresetColor" => x |> FelizNode<'FunBlazorGeneric>.create
    static member count (x: System.Nullable<System.Int32>) = "Count" => x |> FelizNode<'FunBlazorGeneric>.create
    static member countTemplate (x: string) = Bolero.Html.attr.fragment "CountTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member countTemplate (node) = Bolero.Html.attr.fragment "CountTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member countTemplate (nodes) = Bolero.Html.attr.fragment "CountTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member dot (x: System.Boolean) = "Dot" => x |> FelizNode<'FunBlazorGeneric>.create
    static member offset (x: System.ValueTuple<System.Int32, System.Int32>) = "Offset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member overflowCount (x: System.Int32) = "OverflowCount" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showZero (x: System.Boolean) = "ShowZero" => x |> FelizNode<'FunBlazorGeneric>.create
    static member status (x: System.String) = "Status" => x |> FelizNode<'FunBlazorGeneric>.create
    static member text (x: System.String) = "Text" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type badgeRibbon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.BadgeRibbon>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.BadgeRibbon>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.BadgeRibbon>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.BadgeRibbon>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.BadgeRibbon>
    static member ref x = attr.ref<AntDesign.BadgeRibbon> x
    static member color (x: System.String) = "Color" => x |> FelizNode<'FunBlazorGeneric>.create
    static member text (x: System.String) = "Text" => x |> FelizNode<'FunBlazorGeneric>.create
    static member textTemplate (x: string) = Bolero.Html.attr.fragment "TextTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member textTemplate (node) = Bolero.Html.attr.fragment "TextTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member textTemplate (nodes) = Bolero.Html.attr.fragment "TextTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member placement (x: System.String) = "Placement" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type breadcrumb<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Breadcrumb>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Breadcrumb>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Breadcrumb>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Breadcrumb>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Breadcrumb>
    static member ref x = attr.ref<AntDesign.Breadcrumb> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member autoGenerate (x: System.Boolean) = "AutoGenerate" => x |> FelizNode<'FunBlazorGeneric>.create
    static member separator (x: System.String) = "Separator" => x |> FelizNode<'FunBlazorGeneric>.create
    static member routeLabel (x: System.String) = "RouteLabel" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type button<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Button>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Button>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Button>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Button>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Button>
    static member ref x = attr.ref<AntDesign.Button> x
    static member color (x: AntDesign.Color) = "Color" => x |> FelizNode<'FunBlazorGeneric>.create
    static member block (x: System.Boolean) = "Block" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member danger (x: System.Boolean) = "Danger" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member ghost (x: System.Boolean) = "Ghost" => x |> FelizNode<'FunBlazorGeneric>.create
    static member htmlType (x: System.String) = "HtmlType" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x |> FelizNode<'FunBlazorGeneric>.create
    static member shape (x: System.String) = "Shape" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member noSpanWrap (x: System.Boolean) = "NoSpanWrap" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type buttonGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ButtonGroup>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ButtonGroup>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.ButtonGroup>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.ButtonGroup>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.ButtonGroup>
    static member ref x = attr.ref<AntDesign.ButtonGroup> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type calendar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Calendar>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Calendar>

    static member ref x = attr.ref<AntDesign.Calendar> x
    static member value (x: System.DateTime) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValue (x: System.DateTime) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member validRange (x: System.DateTime[]) = "ValidRange" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mode (x: System.String) = "Mode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member fullScreen (x: System.Boolean) = "FullScreen" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onSelect fn = (Bolero.Html.attr.callback<System.DateTime> "OnSelect" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<System.DateTime> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member headerRender (fn) = Bolero.FragmentAttr ("HeaderRender", fun render -> box (System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member dateCellRender (fn) = Bolero.FragmentAttr ("DateCellRender", fun render -> box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member dateFullCellRender (fn) = Bolero.FragmentAttr ("DateFullCellRender", fun render -> box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member monthCellRender (fn) = Bolero.FragmentAttr ("MonthCellRender", fun render -> box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member monthFullCellRender (fn) = Bolero.FragmentAttr ("MonthFullCellRender", fun render -> box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member onPanelChange (fn) = "OnPanelChange" => (System.Action<System.DateTime, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type card<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Card>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Card>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Card>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Card>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Card>
    static member ref x = attr.ref<AntDesign.Card> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member body (x: string) = Bolero.Html.attr.fragment "Body" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member body (node) = Bolero.Html.attr.fragment "Body" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member body (nodes) = Bolero.Html.attr.fragment "Body" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member actionTemplate (x: string) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member actionTemplate (node) = Bolero.Html.attr.fragment "ActionTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member actionTemplate (nodes) = Bolero.Html.attr.fragment "ActionTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member bordered (x: System.Boolean) = "Bordered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hoverable (x: System.Boolean) = "Hoverable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bodyStyle (x: System.String) = "BodyStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cover (x: string) = Bolero.Html.attr.fragment "Cover" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member cover (node) = Bolero.Html.attr.fragment "Cover" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member cover (nodes) = Bolero.Html.attr.fragment "Cover" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member actions (x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member extra (x: string) = Bolero.Html.attr.fragment "Extra" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member extra (node) = Bolero.Html.attr.fragment "Extra" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member extra (nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member cardTabs (x: string) = Bolero.Html.attr.fragment "CardTabs" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member cardTabs (node) = Bolero.Html.attr.fragment "CardTabs" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member cardTabs (nodes) = Bolero.Html.attr.fragment "CardTabs" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type cardAction<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.CardAction>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.CardAction>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.CardAction>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.CardAction>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.CardAction>
    static member ref x = attr.ref<AntDesign.CardAction> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type cardGrid<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.CardGrid>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.CardGrid>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.CardGrid>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.CardGrid>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.CardGrid>
    static member ref x = attr.ref<AntDesign.CardGrid> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member hoverable (x: System.Boolean) = "Hoverable" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type carousel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Carousel>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Carousel>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Carousel>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Carousel>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Carousel>
    static member ref x = attr.ref<AntDesign.Carousel> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member dotPosition (x: System.String) = "DotPosition" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoplay (x: System.TimeSpan) = "Autoplay" => x |> FelizNode<'FunBlazorGeneric>.create
    static member effect (x: System.String) = "Effect" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type carouselSlick<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.CarouselSlick>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.CarouselSlick>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.CarouselSlick>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.CarouselSlick>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.CarouselSlick>
    static member ref x = attr.ref<AntDesign.CarouselSlick> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type collapse<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Collapse>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Collapse>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Collapse>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Collapse>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Collapse>
    static member ref x = attr.ref<AntDesign.Collapse> x
    static member accordion (x: System.Boolean) = "Accordion" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bordered (x: System.Boolean) = "Bordered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member expandIconPosition (x: System.String) = "ExpandIconPosition" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultActiveKey (x: System.String[]) = "DefaultActiveKey" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member expandIcon (x: System.String) = "ExpandIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member expandIconTemplate (render: System.Boolean -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ExpandIconTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type panel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Panel>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Panel>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Panel>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Panel>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Panel>
    static member ref x = attr.ref<AntDesign.Panel> x
    static member active (x: System.Boolean) = "Active" => x |> FelizNode<'FunBlazorGeneric>.create
    static member key (x: System.String) = "Key" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showArrow (x: System.Boolean) = "ShowArrow" => x |> FelizNode<'FunBlazorGeneric>.create
    static member extra (x: System.String) = "Extra" => x |> FelizNode<'FunBlazorGeneric>.create
    static member extraTemplate (x: string) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member extraTemplate (node) = Bolero.Html.attr.fragment "ExtraTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member extraTemplate (nodes) = Bolero.Html.attr.fragment "ExtraTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member header (x: System.String) = "Header" => x |> FelizNode<'FunBlazorGeneric>.create
    static member headerTemplate (x: string) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member headerTemplate (node) = Bolero.Html.attr.fragment "HeaderTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member headerTemplate (nodes) = Bolero.Html.attr.fragment "HeaderTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onActiveChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnActiveChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type comment<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Comment>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Comment>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Comment>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Comment>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Comment>
    static member ref x = attr.ref<AntDesign.Comment> x
    static member author (x: System.String) = "Author" => x |> FelizNode<'FunBlazorGeneric>.create
    static member authorTemplate (x: string) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member authorTemplate (node) = Bolero.Html.attr.fragment "AuthorTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member authorTemplate (nodes) = Bolero.Html.attr.fragment "AuthorTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member avatar (x: System.String) = "Avatar" => x |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (node) = Bolero.Html.attr.fragment "AvatarTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member content (x: System.String) = "Content" => x |> FelizNode<'FunBlazorGeneric>.create
    static member contentTemplate (x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member contentTemplate (node) = Bolero.Html.attr.fragment "ContentTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member contentTemplate (nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member datetime (x: System.String) = "Datetime" => x |> FelizNode<'FunBlazorGeneric>.create
    static member datetimeTemplate (x: string) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member datetimeTemplate (node) = Bolero.Html.attr.fragment "DatetimeTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member datetimeTemplate (nodes) = Bolero.Html.attr.fragment "DatetimeTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member actions (x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type antContainerComponentBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AntContainerComponentBase>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AntContainerComponentBase>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.AntContainerComponentBase>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.AntContainerComponentBase>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.AntContainerComponentBase>
    static member ref x = attr.ref<AntDesign.AntContainerComponentBase> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member tag (x: System.String) = "Tag" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type antInputComponentBase<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AntInputComponentBase<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AntInputComponentBase<'TValue>>

    static member ref x = attr.ref<AntDesign.AntInputComponentBase<'TValue>> x
    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: 'TValue) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value' (value: IStore<'TValue>) = FelizNode<'FunBlazorGeneric>.create("Value", value)
    static member value' (value: cval<'TValue>) = FelizNode<'FunBlazorGeneric>.create("Value", value)
    static member value' (valueFn: 'TValue * ('TValue -> unit)) = FelizNode<'FunBlazorGeneric>.create("Value", valueFn)
    static member valueChanged fn = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> FelizNode<'FunBlazorGeneric>.create
    static member valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type antInputBoolComponentBase<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.Boolean>
    static member create () = [] |> html.blazor<AntDesign.AntInputBoolComponentBase>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AntInputBoolComponentBase>

    static member ref x = attr.ref<AntDesign.AntInputBoolComponentBase> x
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checked' (x: System.Boolean) = "Checked" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checked'' (value: IStore<System.Boolean>) = FelizNode<'FunBlazorGeneric>.create("Checked", value)
    static member checked'' (value: cval<System.Boolean>) = FelizNode<'FunBlazorGeneric>.create("Checked", value)
    static member checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = FelizNode<'FunBlazorGeneric>.create("Checked", valueFn)
    static member onChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type checkbox<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Checkbox>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Checkbox>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Checkbox>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Checkbox>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Checkbox>
    static member ref x = attr.ref<AntDesign.Checkbox> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member checkedChange fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member checkedExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "CheckedExpression" => x |> FelizNode<'FunBlazorGeneric>.create
    static member indeterminate (x: System.Boolean) = "Indeterminate" => x |> FelizNode<'FunBlazorGeneric>.create
    static member label (x: System.String) = "Label" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type switch<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Switch>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Switch>

    static member ref x = attr.ref<AntDesign.Switch> x
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkedChildren (x: System.String) = "CheckedChildren" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkedChildrenTemplate (x: string) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member checkedChildrenTemplate (node) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member checkedChildrenTemplate (nodes) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member control (x: System.Boolean) = "Control" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = attr.callbackOfUnit("OnClick", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member unCheckedChildren (x: System.String) = "UnCheckedChildren" => x |> FelizNode<'FunBlazorGeneric>.create
    static member unCheckedChildrenTemplate (x: string) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member unCheckedChildrenTemplate (node) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member unCheckedChildrenTemplate (nodes) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type autoComplete<'FunBlazorGeneric, 'TOption> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.AutoComplete<'TOption>>
    static member ref x = attr.ref<AntDesign.AutoComplete<'TOption>> x
    static member placeholder (x: System.String) = "Placeholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x |> FelizNode<'FunBlazorGeneric>.create
    static member backfill (x: System.Boolean) = "Backfill" => x |> FelizNode<'FunBlazorGeneric>.create
    static member options (x: System.Collections.Generic.IEnumerable<'TOption>) = "Options" => x |> FelizNode<'FunBlazorGeneric>.create
    static member optionDataItems (x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionDataItems" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onSelectionChange fn = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnSelectionChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onActiveChange fn = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnActiveChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onPanelVisibleChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnPanelVisibleChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member optionTemplate (render: AntDesign.AutoCompleteDataItem<'TOption> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "OptionTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member optionFormat (fn) = "OptionFormat" => (System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member overlayTemplate (x: string) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member overlayTemplate (node) = Bolero.Html.attr.fragment "OverlayTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member overlayTemplate (nodes) = Bolero.Html.attr.fragment "OverlayTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member compareWith (fn) = "CompareWith" => (System.Func<System.Object, System.Object, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member filterExpression (fn) = "FilterExpression" => (System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member allowFilter (x: System.Boolean) = "AllowFilter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member width (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Width" => x |> FelizNode<'FunBlazorGeneric>.create
    static member overlayClassName (x: System.String) = "OverlayClassName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member overlayStyle (x: System.String) = "OverlayStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedItem (x: AntDesign.AutoCompleteOption) = "SelectedItem" => x |> FelizNode<'FunBlazorGeneric>.create
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showPanel (x: System.Boolean) = "ShowPanel" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type cascader<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<AntDesign.Cascader>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Cascader>

    static member ref x = attr.ref<AntDesign.Cascader> x
    static member allowClear (x: System.Boolean) = "AllowClear" => x |> FelizNode<'FunBlazorGeneric>.create
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member changeOnSelect (x: System.Boolean) = "ChangeOnSelect" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValue (x: System.String) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member expandTrigger (x: System.String) = "ExpandTrigger" => x |> FelizNode<'FunBlazorGeneric>.create
    static member notFoundContent (x: System.String) = "NotFoundContent" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSearch (x: System.Boolean) = "ShowSearch" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange (fn) = "OnChange" => (System.Action<System.Collections.Generic.List<AntDesign.CascaderNode>, System.String, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member selectedNodesChanged fn = (Bolero.Html.attr.callback<AntDesign.CascaderNode[]> "SelectedNodesChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member options (x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = "Options" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type checkboxGroup<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String[]>
    static member create () = [] |> html.blazor<AntDesign.CheckboxGroup>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.CheckboxGroup>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.CheckboxGroup>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.CheckboxGroup>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.CheckboxGroup>
    static member ref x = attr.ref<AntDesign.CheckboxGroup> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member options (x: OneOf.OneOf<AntDesign.CheckboxOption[], System.String[]>) = "Options" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mixedMode (x: AntDesign.CheckboxGroupMixedMode) = "MixedMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type datePickerBase<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.DatePickerBase<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.DatePickerBase<'TValue>>

    static member ref x = attr.ref<AntDesign.DatePickerBase<'TValue>> x
    static member prefixCls (x: System.String) = "PrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member picker (x: System.String) = "Picker" => x |> FelizNode<'FunBlazorGeneric>.create
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: OneOf.OneOf<System.Boolean, System.Boolean[]>) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bordered (x: System.Boolean) = "Bordered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member open' (x: System.Boolean) = "Open" => x |> FelizNode<'FunBlazorGeneric>.create
    static member inputReadOnly (x: System.Boolean) = "InputReadOnly" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showToday (x: System.Boolean) = "ShowToday" => x |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.DatePickerLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> FelizNode<'FunBlazorGeneric>.create
    static member allowClear (x: System.Boolean) = "AllowClear" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member popupStyle (x: System.String) = "PopupStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member className (x: System.String) = "ClassName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dropdownClassName (x: System.String) = "DropdownClassName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member format (x: System.String) = "Format" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValue (x: 'TValue) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member renderExtraFooter (x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member renderExtraFooter (node) = Bolero.Html.attr.fragment "RenderExtraFooter" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member renderExtraFooter (nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onClearClick fn = attr.callbackOfUnit("OnClearClick", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onOpenChange fn = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onPanelChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledHours (fn) = "DisabledHours" => (System.Func<System.DateTime, System.Int32[]>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledMinutes (fn) = "DisabledMinutes" => (System.Func<System.DateTime, System.Int32[]>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledSeconds (fn) = "DisabledSeconds" => (System.Func<System.DateTime, System.Int32[]>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledTime (fn) = "DisabledTime" => (System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member dateRender (fn) = Bolero.FragmentAttr ("DateRender", fun render -> box (System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1 x2))))) |> FelizNode<'FunBlazorGeneric>.create
    static member monthCellRender (fn) = Bolero.FragmentAttr ("MonthCellRender", fun render -> box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
                    

type datePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.DatePicker<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.DatePicker<'TValue>>

    static member ref x = attr.ref<AntDesign.DatePicker<'TValue>> x
    static member onChange fn = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type monthPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.MonthPicker<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.MonthPicker<'TValue>>

    static member ref x = attr.ref<AntDesign.MonthPicker<'TValue>> x

                    

type quarterPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.QuarterPicker<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.QuarterPicker<'TValue>>

    static member ref x = attr.ref<AntDesign.QuarterPicker<'TValue>> x

                    

type weekPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.WeekPicker<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.WeekPicker<'TValue>>

    static member ref x = attr.ref<AntDesign.WeekPicker<'TValue>> x

                    

type yearPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.YearPicker<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.YearPicker<'TValue>>

    static member ref x = attr.ref<AntDesign.YearPicker<'TValue>> x

                    

type timePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.TimePicker<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TimePicker<'TValue>>

    static member ref x = attr.ref<AntDesign.TimePicker<'TValue>> x

                    

type rangePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.RangePicker<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.RangePicker<'TValue>>

    static member ref x = attr.ref<AntDesign.RangePicker<'TValue>> x
    static member value (x: 'TValue) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<AntDesign.DateRangeChangedEventArgs> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type inputNumber<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.InputNumber<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.InputNumber<'TValue>>

    static member ref x = attr.ref<AntDesign.InputNumber<'TValue>> x
    static member formatter (fn) = "Formatter" => (System.Func<'TValue, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member parser (fn) = "Parser" => (System.Func<System.String, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member step (x: 'TValue) = "Step" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValue (x: 'TValue) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member max (x: 'TValue) = "Max" => x |> FelizNode<'FunBlazorGeneric>.create
    static member min (x: 'TValue) = "Min" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type input<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Input<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Input<'TValue>>

    static member ref x = attr.ref<AntDesign.Input<'TValue>> x
    static member addOnBefore (x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member addOnBefore (node) = Bolero.Html.attr.fragment "AddOnBefore" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member addOnBefore (nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member addOnAfter (x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member addOnAfter (node) = Bolero.Html.attr.fragment "AddOnAfter" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member addOnAfter (nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member allowClear (x: System.Boolean) = "AllowClear" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoComplete (x: System.Boolean) = "AutoComplete" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bordered (x: System.Boolean) = "Bordered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValue (x: 'TValue) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maxLength (x: System.Int32) = "MaxLength" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onkeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onkeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onMouseUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onPressEnter fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member prefix (x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member prefix (node) = Bolero.Html.attr.fragment "Prefix" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member prefix (nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member readOnly (x: System.Boolean) = "ReadOnly" => x |> FelizNode<'FunBlazorGeneric>.create
    static member stopPropagation (x: System.Boolean) = "StopPropagation" => x |> FelizNode<'FunBlazorGeneric>.create
    static member suffix (x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member suffix (node) = Bolero.Html.attr.fragment "Suffix" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member suffix (nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapperStyle (x: System.String) = "WrapperStyle" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type search<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<AntDesign.Search>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Search>

    static member ref x = attr.ref<AntDesign.Search> x
    static member classicSearchIcon (x: System.Boolean) = "ClassicSearchIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member enterButton (x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onSearch fn = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type autoCompleteSearch<'FunBlazorGeneric> =
    inherit search<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AutoCompleteSearch>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AutoCompleteSearch>

    static member ref x = attr.ref<AntDesign.AutoCompleteSearch> x

                    

type autoCompleteInput<'FunBlazorGeneric, 'TValue> =
    inherit input<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.AutoCompleteInput<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AutoCompleteInput<'TValue>>

    static member ref x = attr.ref<AntDesign.AutoCompleteInput<'TValue>> x

                    

type inputPassword<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<AntDesign.InputPassword>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.InputPassword>

    static member ref x = attr.ref<AntDesign.InputPassword> x
    static member iconRender (x: string) = Bolero.Html.attr.fragment "IconRender" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member iconRender (node) = Bolero.Html.attr.fragment "IconRender" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member iconRender (nodes) = Bolero.Html.attr.fragment "IconRender" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member showPassword (x: System.Boolean) = "ShowPassword" => x |> FelizNode<'FunBlazorGeneric>.create
    static member visibilityToggle (x: System.Boolean) = "VisibilityToggle" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type textArea<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member create () = [] |> html.blazor<AntDesign.TextArea>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TextArea>

    static member ref x = attr.ref<AntDesign.TextArea> x
    static member autoSize (x: System.Boolean) = "AutoSize" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultToEmptyString (x: System.Boolean) = "DefaultToEmptyString" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maxRows (x: System.UInt32) = "MaxRows" => x |> FelizNode<'FunBlazorGeneric>.create
    static member minRows (x: System.UInt32) = "MinRows" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rows (x: System.UInt32) = "Rows" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onResize fn = (Bolero.Html.attr.callback<AntDesign.OnResizeEventArgs> "OnResize" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member showCount (x: System.Boolean) = "ShowCount" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: System.String) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type radioGroup<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.RadioGroup<'TValue>>
    static member ref x = attr.ref<AntDesign.RadioGroup<'TValue>> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member buttonStyle (x: AntDesign.RadioButtonStyle) = "ButtonStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member name (x: System.String) = "Name" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValue (x: 'TValue) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member options (x: OneOf.OneOf<System.String[], AntDesign.RadioOption<'TValue>[]>) = "Options" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type enumRadioGroup<'FunBlazorGeneric, 'TEnum> =
    inherit radioGroup<'FunBlazorGeneric, 'TEnum>
    static member create () = [] |> html.blazor<AntDesign.EnumRadioGroup<'TEnum>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.EnumRadioGroup<'TEnum>>

    static member ref x = attr.ref<AntDesign.EnumRadioGroup<'TEnum>> x

                    

type selectBase<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TItemValue>
    static member create () = [] |> html.blazor<AntDesign.SelectBase<'TItemValue, 'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SelectBase<'TItemValue, 'TItem>>

    static member ref x = attr.ref<AntDesign.SelectBase<'TItemValue, 'TItem>> x
    static member allowClear (x: System.Boolean) = "AllowClear" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoClearSearchValue (x: System.Boolean) = "AutoClearSearchValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mode (x: System.String) = "Mode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member enableSearch (x: System.Boolean) = "EnableSearch" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member open' (x: System.Boolean) = "Open" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onFocus (x: System.Action) = "OnFocus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member sortByGroup (x: AntDesign.SortDirection) = "SortByGroup" => x |> FelizNode<'FunBlazorGeneric>.create
    static member sortByLabel (x: AntDesign.SortDirection) = "SortByLabel" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hideSelected (x: System.Boolean) = "HideSelected" => x |> FelizNode<'FunBlazorGeneric>.create
    static member valueChanged fn = (Bolero.Html.attr.callback<'TItemValue> "ValueChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member valuesChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItemValue>> "ValuesChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member prefixIcon (x: string) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member prefixIcon (node) = Bolero.Html.attr.fragment "PrefixIcon" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member prefixIcon (nodes) = Bolero.Html.attr.fragment "PrefixIcon" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValues (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "DefaultValues" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClearSelected (x: System.Action) = "OnClearSelected" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onSelectedItemChanged (fn) = "OnSelectedItemChanged" => (System.Action<'TItem>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onSelectedItemsChanged (fn) = "OnSelectedItemsChanged" => (System.Action<System.Collections.Generic.IEnumerable<'TItem>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member values (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "Values" => x |> FelizNode<'FunBlazorGeneric>.create
    static member values' (value: IStore<System.Collections.Generic.IEnumerable<'TItemValue>>) = FelizNode<'FunBlazorGeneric>.create("Values", value)
    static member values' (value: cval<System.Collections.Generic.IEnumerable<'TItemValue>>) = FelizNode<'FunBlazorGeneric>.create("Values", value)
    static member values' (valueFn: System.Collections.Generic.IEnumerable<'TItemValue> * (System.Collections.Generic.IEnumerable<'TItemValue> -> unit)) = FelizNode<'FunBlazorGeneric>.create("Values", valueFn)
    static member customTagLabelToValue (fn) = "CustomTagLabelToValue" => (System.Func<System.String, 'TItemValue>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member selectOptions (x: string) = Bolero.Html.attr.fragment "SelectOptions" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member selectOptions (node) = Bolero.Html.attr.fragment "SelectOptions" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member selectOptions (nodes) = Bolero.Html.attr.fragment "SelectOptions" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member maxTagTextLength (x: System.Int32) = "MaxTagTextLength" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelInValue (x: System.Boolean) = "LabelInValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maxTagCount (x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> FelizNode<'FunBlazorGeneric>.create
    static member valueOnClear (x: 'TItemValue) = "ValueOnClear" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type select'<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit selectBase<'FunBlazorGeneric, 'TItemValue, 'TItem>
    static member create () = [] |> html.blazor<AntDesign.Select<'TItemValue, 'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Select<'TItemValue, 'TItem>>

    static member ref x = attr.ref<AntDesign.Select<'TItemValue, 'TItem>> x
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bordered (x: System.Boolean) = "Bordered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dataSourceEqualityComparer (x: System.Collections.Generic.IEqualityComparer<'TItem>) = "DataSourceEqualityComparer" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabledName (x: System.String) = "DisabledName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dropdownRender (fn) = Bolero.FragmentAttr ("DropdownRender", fun render -> box (System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun rt -> render rt (fn x1))))) |> FelizNode<'FunBlazorGeneric>.create
    static member groupName (x: System.String) = "GroupName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member ignoreItemChanges (x: System.Boolean) = "IgnoreItemChanges" => x |> FelizNode<'FunBlazorGeneric>.create
    static member itemTemplate (render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member labelName (x: System.String) = "LabelName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelTemplate (render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member maxTagPlaceholder (render: System.Collections.Generic.IEnumerable<'TItem> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "MaxTagPlaceholder" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member notFoundContent (x: string) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member notFoundContent (node) = Bolero.Html.attr.fragment "NotFoundContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member notFoundContent (nodes) = Bolero.Html.attr.fragment "NotFoundContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onBlur (x: System.Action) = "OnBlur" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onCreateCustomTag (fn) = "OnCreateCustomTag" => (System.Action<System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onDataSourceChanged (x: System.Action) = "OnDataSourceChanged" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onDropdownVisibleChange (fn) = "OnDropdownVisibleChange" => (System.Action<System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onSearch (fn) = "OnSearch" => (System.Action<System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x |> FelizNode<'FunBlazorGeneric>.create
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tokenSeparators (x: System.Char[]) = "TokenSeparators" => x |> FelizNode<'FunBlazorGeneric>.create
    static member valueChanged fn = (Bolero.Html.attr.callback<'TItemValue> "ValueChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member valueName (x: System.String) = "ValueName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: 'TItemValue) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value' (value: IStore<'TItemValue>) = FelizNode<'FunBlazorGeneric>.create("Value", value)
    static member value' (value: cval<'TItemValue>) = FelizNode<'FunBlazorGeneric>.create("Value", value)
    static member value' (valueFn: 'TItemValue * ('TItemValue -> unit)) = FelizNode<'FunBlazorGeneric>.create("Value", valueFn)
    static member defaultValue (x: 'TItemValue) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type enumSelect<'FunBlazorGeneric, 'TEnum> =
    inherit select'<'FunBlazorGeneric, 'TEnum, 'TEnum>
    static member create () = [] |> html.blazor<AntDesign.EnumSelect<'TEnum>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.EnumSelect<'TEnum>>

    static member ref x = attr.ref<AntDesign.EnumSelect<'TEnum>> x

                    

type simpleSelect<'FunBlazorGeneric> =
    inherit select'<'FunBlazorGeneric, System.String, System.String>
    static member create () = [] |> html.blazor<AntDesign.SimpleSelect>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SimpleSelect>

    static member ref x = attr.ref<AntDesign.SimpleSelect> x

                    

type treeSelect<'FunBlazorGeneric, 'TItem when 'TItem : not struct> =
    inherit selectBase<'FunBlazorGeneric, System.String, 'TItem>
    static member create () = [] |> html.blazor<AntDesign.TreeSelect<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TreeSelect<'TItem>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.TreeSelect<'TItem>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.TreeSelect<'TItem>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.TreeSelect<'TItem>>
    static member ref x = attr.ref<AntDesign.TreeSelect<'TItem>> x
    static member showExpand (x: System.Boolean) = "ShowExpand" => x |> FelizNode<'FunBlazorGeneric>.create
    static member multiple (x: System.Boolean) = "Multiple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member treeCheckable (x: System.Boolean) = "TreeCheckable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onMouseEnter (x: System.Action) = "OnMouseEnter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onMouseLeave (x: System.Action) = "OnMouseLeave" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelTemplate (render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member nodes (x: AntDesign.TreeNode<'TItem>[]) = "Nodes" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member treeDefaultExpandAll (x: System.Boolean) = "TreeDefaultExpandAll" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dataItemExpression (fn) = "DataItemExpression" => (System.Func<System.Collections.Generic.IEnumerable<'TItem>, System.String, 'TItem>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member dataItemsExpression (fn) = "DataItemsExpression" => (System.Func<System.Collections.Generic.IList<'TItem>, System.Collections.Generic.IEnumerable<System.String>, System.Collections.Generic.IEnumerable<'TItem>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member rootValue (x: System.String) = "RootValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleExpression (fn) = "TitleExpression" => (System.Func<'TItem, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member keyExpression (fn) = "KeyExpression" => (System.Func<'TItem, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member iconExpression (fn) = "IconExpression" => (System.Func<'TItem, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member isLeafExpression (fn) = "IsLeafExpression" => (System.Func<'TItem, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member childrenExpression (fn) = "ChildrenExpression" => (System.Func<'TItem, System.Collections.Generic.IList<'TItem>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledExpression (fn) = "DisabledExpression" => (System.Func<'TItem, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type simpleTreeSelect<'FunBlazorGeneric, 'TItem when 'TItem : not struct> =
    inherit treeSelect<'FunBlazorGeneric, 'TItem>
    static member create () = [] |> html.blazor<AntDesign.SimpleTreeSelect<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SimpleTreeSelect<'TItem>>

    static member ref x = attr.ref<AntDesign.SimpleTreeSelect<'TItem>> x
    static member childrenMethodExpression (fn) = "ChildrenMethodExpression" => (System.Func<System.String, System.Collections.Generic.IList<'TItem>>fn) |> FelizNode<'FunBlazorGeneric>.create
                    

type slider<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Slider<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Slider<'TValue>>

    static member ref x = attr.ref<AntDesign.Slider<'TValue>> x
    static member defaultValue (x: 'TValue) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dots (x: System.Boolean) = "Dots" => x |> FelizNode<'FunBlazorGeneric>.create
    static member included (x: System.Boolean) = "Included" => x |> FelizNode<'FunBlazorGeneric>.create
    static member marks (x: AntDesign.SliderMark[]) = "Marks" => x |> FelizNode<'FunBlazorGeneric>.create
    static member max (x: System.Double) = "Max" => x |> FelizNode<'FunBlazorGeneric>.create
    static member min (x: System.Double) = "Min" => x |> FelizNode<'FunBlazorGeneric>.create
    static member reverse (x: System.Boolean) = "Reverse" => x |> FelizNode<'FunBlazorGeneric>.create
    static member step (x: System.Nullable<System.Double>) = "Step" => x |> FelizNode<'FunBlazorGeneric>.create
    static member vertical (x: System.Boolean) = "Vertical" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onAfterChange (fn) = "OnAfterChange" => (System.Action<'TValue>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onChange (fn) = "OnChange" => (System.Action<'TValue>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member hasTooltip (x: System.Boolean) = "HasTooltip" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tipFormatter (fn) = "TipFormatter" => (System.Func<System.Double, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member tooltipPlacement (x: AntDesign.Placement) = "TooltipPlacement" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tooltipVisible (x: System.Boolean) = "TooltipVisible" => x |> FelizNode<'FunBlazorGeneric>.create
    static member getTooltipPopupContainer (x: System.Object) = "GetTooltipPopupContainer" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: 'TValue) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type descriptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Descriptions>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Descriptions>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Descriptions>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Descriptions>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Descriptions>
    static member ref x = attr.ref<AntDesign.Descriptions> x
    static member bordered (x: System.Boolean) = "Bordered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member layout (x: System.String) = "Layout" => x |> FelizNode<'FunBlazorGeneric>.create
    static member column (x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>) = "Column" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member colon (x: System.Boolean) = "Colon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type descriptionsItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.DescriptionsItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.DescriptionsItem>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.DescriptionsItem>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.DescriptionsItem>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.DescriptionsItem>
    static member ref x = attr.ref<AntDesign.DescriptionsItem> x
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member span (x: System.Int32) = "Span" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type divider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Divider>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Divider>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Divider>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Divider>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Divider>
    static member ref x = attr.ref<AntDesign.Divider> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member text (x: System.String) = "Text" => x |> FelizNode<'FunBlazorGeneric>.create
    static member plain (x: System.Boolean) = "Plain" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: AntDesign.DirectionVHType) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member orientation (x: System.String) = "Orientation" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dashed (x: System.Boolean) = "Dashed" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type drawer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Drawer>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Drawer>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Drawer>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Drawer>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Drawer>
    static member ref x = attr.ref<AntDesign.Drawer> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member content (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Content" => x |> FelizNode<'FunBlazorGeneric>.create
    static member closable (x: System.Boolean) = "Closable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maskClosable (x: System.Boolean) = "MaskClosable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mask (x: System.Boolean) = "Mask" => x |> FelizNode<'FunBlazorGeneric>.create
    static member keyboard (x: System.Boolean) = "Keyboard" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placement (x: System.String) = "Placement" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maskStyle (x: System.String) = "MaskStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bodyStyle (x: System.String) = "BodyStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapClassName (x: System.String) = "WrapClassName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member width (x: System.Int32) = "Width" => x |> FelizNode<'FunBlazorGeneric>.create
    static member height (x: System.Int32) = "Height" => x |> FelizNode<'FunBlazorGeneric>.create
    static member zIndex (x: System.Int32) = "ZIndex" => x |> FelizNode<'FunBlazorGeneric>.create
    static member offsetX (x: System.Int32) = "OffsetX" => x |> FelizNode<'FunBlazorGeneric>.create
    static member offsetY (x: System.Int32) = "OffsetY" => x |> FelizNode<'FunBlazorGeneric>.create
    static member visible (x: System.Boolean) = "Visible" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClose fn = attr.callbackOfUnit("OnClose", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member handler (x: string) = Bolero.Html.attr.fragment "Handler" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member handler (node) = Bolero.Html.attr.fragment "Handler" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member handler (nodes) = Bolero.Html.attr.fragment "Handler" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type drawerContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.DrawerContainer>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.DrawerContainer>

    static member ref x = attr.ref<AntDesign.DrawerContainer> x

                    

type empty<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Empty>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Empty>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Empty>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Empty>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Empty>
    static member ref x = attr.ref<AntDesign.Empty> x
    static member prefixCls (x: System.String) = "PrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member imageStyle (x: System.String) = "ImageStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member small (x: System.Boolean) = "Small" => x |> FelizNode<'FunBlazorGeneric>.create
    static member simple (x: System.Boolean) = "Simple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member description (x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = "Description" => x |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (node) = Bolero.Html.attr.fragment "DescriptionTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member image (x: System.String) = "Image" => x |> FelizNode<'FunBlazorGeneric>.create
    static member imageTemplate (x: string) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member imageTemplate (node) = Bolero.Html.attr.fragment "ImageTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member imageTemplate (nodes) = Bolero.Html.attr.fragment "ImageTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type form<'FunBlazorGeneric, 'TModel> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Form<'TModel>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Form<'TModel>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Form<'TModel>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Form<'TModel>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Form<'TModel>>
    static member ref x = attr.ref<AntDesign.Form<'TModel>> x
    static member layout (x: System.String) = "Layout" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (render: 'TModel -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member name (x: System.String) = "Name" => x |> FelizNode<'FunBlazorGeneric>.create
    static member model (x: 'TModel) = "Model" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onFinish fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinish" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onFinishFailed fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinishFailed" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onFieldChanged fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.FieldChangedEventArgs> "OnFieldChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onValidationRequested fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.ValidationRequestedEventArgs> "OnValidationRequested" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onValidationStateChanged fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.ValidationStateChangedEventArgs> "OnValidationStateChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member validator (x: string) = Bolero.Html.attr.fragment "Validator" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member validator (node) = Bolero.Html.attr.fragment "Validator" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member validator (nodes) = Bolero.Html.attr.fragment "Validator" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member validateOnChange (x: System.Boolean) = "ValidateOnChange" => x |> FelizNode<'FunBlazorGeneric>.create
    static member validateMode (x: AntDesign.FormValidateMode) = "ValidateMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member validateMessages (x: AntDesign.FormValidateErrorMessages) = "ValidateMessages" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type formItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.FormItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.FormItem>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.FormItem>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.FormItem>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.FormItem>
    static member ref x = attr.ref<AntDesign.FormItem> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member label (x: System.String) = "Label" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelTemplate (x: string) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member labelTemplate (node) = Bolero.Html.attr.fragment "LabelTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member labelTemplate (nodes) = Bolero.Html.attr.fragment "LabelTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member noStyle (x: System.Boolean) = "NoStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member required (x: System.Boolean) = "Required" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelStyle (x: System.String) = "LabelStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rules (x: AntDesign.FormValidationRule[]) = "Rules" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hasFeedback (x: System.Boolean) = "HasFeedback" => x |> FelizNode<'FunBlazorGeneric>.create
    static member validateStatus (x: AntDesign.FormValidateStatus) = "ValidateStatus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member help (x: System.String) = "Help" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type row<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Row>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Row>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Row>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Row>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Row>
    static member ref x = attr.ref<AntDesign.Row> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member align (x: System.String) = "Align" => x |> FelizNode<'FunBlazorGeneric>.create
    static member justify (x: System.String) = "Justify" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrap (x: System.Boolean) = "Wrap" => x |> FelizNode<'FunBlazorGeneric>.create
    static member gutter (x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Collections.Generic.Dictionary<System.String, System.Int32>>>) = "Gutter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onBreakpoint fn = (Bolero.Html.attr.callback<AntDesign.BreakpointType> "OnBreakpoint" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member defaultBreakpoint (x: System.Nullable<AntDesign.BreakpointType>) = "DefaultBreakpoint" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type image<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Image>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Image>

    static member ref x = attr.ref<AntDesign.Image> x
    static member alt (x: System.String) = "Alt" => x |> FelizNode<'FunBlazorGeneric>.create
    static member fallback (x: System.String) = "Fallback" => x |> FelizNode<'FunBlazorGeneric>.create
    static member height (x: System.String) = "Height" => x |> FelizNode<'FunBlazorGeneric>.create
    static member width (x: System.String) = "Width" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (x: string) = Bolero.Html.attr.fragment "Placeholder" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (node) = Bolero.Html.attr.fragment "Placeholder" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (nodes) = Bolero.Html.attr.fragment "Placeholder" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member preview (x: System.Boolean) = "Preview" => x |> FelizNode<'FunBlazorGeneric>.create
    static member previewVisible (x: System.Boolean) = "PreviewVisible" => x |> FelizNode<'FunBlazorGeneric>.create
    static member src (x: System.String) = "Src" => x |> FelizNode<'FunBlazorGeneric>.create
    static member previewSrc (x: System.String) = "PreviewSrc" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.ImageLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type imagePreviewContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ImagePreviewContainer>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ImagePreviewContainer>

    static member ref x = attr.ref<AntDesign.ImagePreviewContainer> x

                    

type inputGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.InputGroup>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.InputGroup>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.InputGroup>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.InputGroup>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.InputGroup>
    static member ref x = attr.ref<AntDesign.InputGroup> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member compact (x: System.Boolean) = "Compact" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type sider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Sider>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Sider>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Sider>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Sider>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Sider>
    static member ref x = attr.ref<AntDesign.Sider> x
    static member collapsible (x: System.Boolean) = "Collapsible" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member trigger (x: string) = Bolero.Html.attr.fragment "Trigger" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member trigger (node) = Bolero.Html.attr.fragment "Trigger" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member trigger (nodes) = Bolero.Html.attr.fragment "Trigger" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member noTrigger (x: System.Boolean) = "NoTrigger" => x |> FelizNode<'FunBlazorGeneric>.create
    static member breakpoint (x: System.Nullable<AntDesign.BreakpointType>) = "Breakpoint" => x |> FelizNode<'FunBlazorGeneric>.create
    static member theme (x: AntDesign.SiderTheme) = "Theme" => x |> FelizNode<'FunBlazorGeneric>.create
    static member width (x: System.Int32) = "Width" => x |> FelizNode<'FunBlazorGeneric>.create
    static member collapsedWidth (x: System.Int32) = "CollapsedWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member collapsed (x: System.Boolean) = "Collapsed" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onCollapse fn = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onBreakpoint fn = (Bolero.Html.attr.callback<System.Boolean> "OnBreakpoint" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type antList<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AntList<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AntList<'TItem>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.AntList<'TItem>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.AntList<'TItem>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.AntList<'TItem>>
    static member ref x = attr.ref<AntDesign.AntList<'TItem>> x
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bordered (x: System.Boolean) = "Bordered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member header (x: string) = Bolero.Html.attr.fragment "Header" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member header (node) = Bolero.Html.attr.fragment "Header" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member header (nodes) = Bolero.Html.attr.fragment "Header" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member footer (x: string) = Bolero.Html.attr.fragment "Footer" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member footer (node) = Bolero.Html.attr.fragment "Footer" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member footer (nodes) = Bolero.Html.attr.fragment "Footer" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member loadMore (x: string) = Bolero.Html.attr.fragment "LoadMore" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member loadMore (node) = Bolero.Html.attr.fragment "LoadMore" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member loadMore (nodes) = Bolero.Html.attr.fragment "LoadMore" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member itemLayout (x: AntDesign.ListItemLayout) = "ItemLayout" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member noResult (x: System.String) = "NoResult" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member split (x: System.Boolean) = "Split" => x |> FelizNode<'FunBlazorGeneric>.create
    static member grid (x: AntDesign.ListGridType) = "Grid" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pagination (x: AntDesign.PaginationOptions) = "Pagination" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
                    

type listItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ListItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ListItem>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.ListItem>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.ListItem>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.ListItem>
    static member ref x = attr.ref<AntDesign.ListItem> x
    static member content (x: System.String) = "Content" => x |> FelizNode<'FunBlazorGeneric>.create
    static member extra (x: string) = Bolero.Html.attr.fragment "Extra" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member extra (node) = Bolero.Html.attr.fragment "Extra" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member extra (nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member actions (x: Microsoft.AspNetCore.Components.RenderFragment[]) = "Actions" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member colStyle (x: System.String) = "ColStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member itemCount (x: System.Int32) = "ItemCount" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = attr.callbackOfUnit("OnClick", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member noFlex (x: System.Boolean) = "NoFlex" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type listItemMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ListItemMeta>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ListItemMeta>

    static member ref x = attr.ref<AntDesign.ListItemMeta> x
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member avatar (x: System.String) = "Avatar" => x |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (node) = Bolero.Html.attr.fragment "AvatarTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member description (x: System.String) = "Description" => x |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (node) = Bolero.Html.attr.fragment "DescriptionTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type mentions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Mentions>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Mentions>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Mentions>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Mentions>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Mentions>
    static member ref x = attr.ref<AntDesign.Mentions> x
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disable (x: System.Boolean) = "Disable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member readonly (x: System.Boolean) = "Readonly" => x |> FelizNode<'FunBlazorGeneric>.create
    static member prefix (x: System.String) = "Prefix" => x |> FelizNode<'FunBlazorGeneric>.create
    static member split (x: System.String) = "Split" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValue (x: System.String) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: System.String) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placement (x: System.String) = "Placement" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rows (x: System.Int32) = "Rows" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member valueChange fn = (Bolero.Html.attr.callback<System.String> "ValueChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onSearch fn = (Bolero.Html.attr.callback<System.EventArgs> "OnSearch" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member noFoundContent (x: string) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member noFoundContent (node) = Bolero.Html.attr.fragment "NoFoundContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member noFoundContent (nodes) = Bolero.Html.attr.fragment "NoFoundContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type mentionsOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.MentionsOption>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.MentionsOption>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.MentionsOption>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.MentionsOption>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.MentionsOption>
    static member ref x = attr.ref<AntDesign.MentionsOption> x
    static member value (x: System.String) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disable (x: System.Boolean) = "Disable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type menu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Menu>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Menu>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Menu>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Menu>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Menu>
    static member ref x = attr.ref<AntDesign.Menu> x
    static member theme (x: AntDesign.MenuTheme) = "Theme" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mode (x: AntDesign.MenuMode) = "Mode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onSubmenuClicked fn = (Bolero.Html.attr.callback<AntDesign.SubMenu> "OnSubmenuClicked" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onMenuItemClicked fn = (Bolero.Html.attr.callback<AntDesign.MenuItem> "OnMenuItemClicked" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member accordion (x: System.Boolean) = "Accordion" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectable (x: System.Boolean) = "Selectable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member multiple (x: System.Boolean) = "Multiple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member inlineCollapsed (x: System.Boolean) = "InlineCollapsed" => x |> FelizNode<'FunBlazorGeneric>.create
    static member inlineIndent (x: System.Int32) = "InlineIndent" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoCloseDropdown (x: System.Boolean) = "AutoCloseDropdown" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultSelectedKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultSelectedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultOpenKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultOpenKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member openKeys (x: System.String[]) = "OpenKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member openKeys' (value: IStore<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("OpenKeys", value)
    static member openKeys' (value: cval<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("OpenKeys", value)
    static member openKeys' (valueFn: System.String[] * (System.String[] -> unit)) = FelizNode<'FunBlazorGeneric>.create("OpenKeys", valueFn)
    static member openKeysChanged fn = (Bolero.Html.attr.callback<System.String[]> "OpenKeysChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onOpenChange fn = (Bolero.Html.attr.callback<System.String[]> "OnOpenChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member selectedKeys (x: System.String[]) = "SelectedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedKeys' (value: IStore<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("SelectedKeys", value)
    static member selectedKeys' (value: cval<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("SelectedKeys", value)
    static member selectedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = FelizNode<'FunBlazorGeneric>.create("SelectedKeys", valueFn)
    static member selectedKeysChanged fn = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member triggerSubMenuAction (x: AntDesign.Trigger) = "TriggerSubMenuAction" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type menuItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.MenuItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.MenuItem>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.MenuItem>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.MenuItem>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.MenuItem>
    static member ref x = attr.ref<AntDesign.MenuItem> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member key (x: System.String) = "Key" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member routerLink (x: System.String) = "RouterLink" => x |> FelizNode<'FunBlazorGeneric>.create
    static member routerMatch (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "RouterMatch" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member iconTemplate (x: string) = Bolero.Html.attr.fragment "IconTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member iconTemplate (node) = Bolero.Html.attr.fragment "IconTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member iconTemplate (nodes) = Bolero.Html.attr.fragment "IconTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type menuItemGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.MenuItemGroup>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.MenuItemGroup>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.MenuItemGroup>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.MenuItemGroup>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.MenuItemGroup>
    static member ref x = attr.ref<AntDesign.MenuItemGroup> x
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member key (x: System.String) = "Key" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type menuLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.MenuLink>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.MenuLink>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.MenuLink>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.MenuLink>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.MenuLink>
    static member ref x = attr.ref<AntDesign.MenuLink> x
    static member activeClass (x: System.String) = "ActiveClass" => x |> FelizNode<'FunBlazorGeneric>.create
    static member href (x: System.String) = "Href" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member attributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> FelizNode<'FunBlazorGeneric>.create
    static member match' (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type subMenu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.SubMenu>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SubMenu>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.SubMenu>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.SubMenu>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.SubMenu>
    static member ref x = attr.ref<AntDesign.SubMenu> x
    static member placement (x: System.Nullable<AntDesign.Placement>) = "Placement" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member key (x: System.String) = "Key" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isOpen (x: System.Boolean) = "IsOpen" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onTitleClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnTitleClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type message<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Message>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Message>

    static member ref x = attr.ref<AntDesign.Message> x

                    

type messageItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.MessageItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.MessageItem>

    static member ref x = attr.ref<AntDesign.MessageItem> x
    static member config (x: AntDesign.MessageConfig) = "Config" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type comfirmContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ComfirmContainer>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ComfirmContainer>

    static member ref x = attr.ref<AntDesign.ComfirmContainer> x

                    

type confirm<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Confirm>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Confirm>

    static member ref x = attr.ref<AntDesign.Confirm> x
    static member config (x: AntDesign.ConfirmOptions) = "Config" => x |> FelizNode<'FunBlazorGeneric>.create
    static member confirmRef (x: AntDesign.ConfirmRef) = "ConfirmRef" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onRemove fn = (Bolero.Html.attr.callback<AntDesign.ConfirmRef> "OnRemove" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type dialog<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Dialog>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Dialog>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Dialog>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Dialog>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Dialog>
    static member ref x = attr.ref<AntDesign.Dialog> x
    static member config (x: AntDesign.DialogOptions) = "Config" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member visible (x: System.Boolean) = "Visible" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type dialogWrapper<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.DialogWrapper>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.DialogWrapper>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.DialogWrapper>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.DialogWrapper>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.DialogWrapper>
    static member ref x = attr.ref<AntDesign.DialogWrapper> x
    static member config (x: AntDesign.DialogOptions) = "Config" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x |> FelizNode<'FunBlazorGeneric>.create
    static member visible (x: System.Boolean) = "Visible" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onBeforeDestroy fn = (Bolero.Html.attr.callback<System.ComponentModel.CancelEventArgs> "OnBeforeDestroy" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onAfterShow fn = attr.callbackOfUnit("OnAfterShow", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onAfterHide fn = attr.callbackOfUnit("OnAfterHide", fn) |> FelizNode<'FunBlazorGeneric>.create
                    

type modal<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Modal>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Modal>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Modal>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Modal>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Modal>
    static member ref x = attr.ref<AntDesign.Modal> x
    static member modalRef (x: AntDesign.ModalRef) = "ModalRef" => x |> FelizNode<'FunBlazorGeneric>.create
    static member afterClose (fn) = "AfterClose" => (System.Func<System.Threading.Tasks.Task>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member bodyStyle (x: System.String) = "BodyStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cancelText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "CancelText" => x |> FelizNode<'FunBlazorGeneric>.create
    static member centered (x: System.Boolean) = "Centered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member closable (x: System.Boolean) = "Closable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member draggable (x: System.Boolean) = "Draggable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dragInViewport (x: System.Boolean) = "DragInViewport" => x |> FelizNode<'FunBlazorGeneric>.create
    static member closeIcon (x: string) = Bolero.Html.attr.fragment "CloseIcon" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member closeIcon (node) = Bolero.Html.attr.fragment "CloseIcon" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member closeIcon (nodes) = Bolero.Html.attr.fragment "CloseIcon" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member confirmLoading (x: System.Boolean) = "ConfirmLoading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x |> FelizNode<'FunBlazorGeneric>.create
    static member footer (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Footer" => x |> FelizNode<'FunBlazorGeneric>.create
    static member getContainer (x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "GetContainer" => x |> FelizNode<'FunBlazorGeneric>.create
    static member keyboard (x: System.Boolean) = "Keyboard" => x |> FelizNode<'FunBlazorGeneric>.create
    static member mask (x: System.Boolean) = "Mask" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maskClosable (x: System.Boolean) = "MaskClosable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maskStyle (x: System.String) = "MaskStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member okText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "OkText" => x |> FelizNode<'FunBlazorGeneric>.create
    static member okType (x: System.String) = "OkType" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member visible (x: System.Boolean) = "Visible" => x |> FelizNode<'FunBlazorGeneric>.create
    static member width (x: OneOf.OneOf<System.String, System.Double>) = "Width" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapClassName (x: System.String) = "WrapClassName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member zIndex (x: System.Int32) = "ZIndex" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onCancel fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onOk fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnOk" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x |> FelizNode<'FunBlazorGeneric>.create
    static member cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.ModalLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type modalContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ModalContainer>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ModalContainer>

    static member ref x = attr.ref<AntDesign.ModalContainer> x

                    

type modalFooter<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ModalFooter>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ModalFooter>

    static member ref x = attr.ref<AntDesign.ModalFooter> x

                    

type pageHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.PageHeader>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.PageHeader>

    static member ref x = attr.ref<AntDesign.PageHeader> x
    static member ghost (x: System.Boolean) = "Ghost" => x |> FelizNode<'FunBlazorGeneric>.create
    static member backIcon (x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = "BackIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member backIconTemplate (x: string) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member backIconTemplate (node) = Bolero.Html.attr.fragment "BackIconTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member backIconTemplate (nodes) = Bolero.Html.attr.fragment "BackIconTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member subtitle (x: System.String) = "Subtitle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member subtitleTemplate (x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member subtitleTemplate (node) = Bolero.Html.attr.fragment "SubtitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member subtitleTemplate (nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onBack fn = attr.callbackOfUnit("OnBack", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderContent (x: string) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderContent (node) = Bolero.Html.attr.fragment "PageHeaderContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderContent (nodes) = Bolero.Html.attr.fragment "PageHeaderContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderFooter (x: string) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderFooter (node) = Bolero.Html.attr.fragment "PageHeaderFooter" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderFooter (nodes) = Bolero.Html.attr.fragment "PageHeaderFooter" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderBreadcrumb (x: string) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderBreadcrumb (node) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderBreadcrumb (nodes) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderAvatar (x: string) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderAvatar (node) = Bolero.Html.attr.fragment "PageHeaderAvatar" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderAvatar (nodes) = Bolero.Html.attr.fragment "PageHeaderAvatar" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderTitle (x: string) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderTitle (node) = Bolero.Html.attr.fragment "PageHeaderTitle" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderTitle (nodes) = Bolero.Html.attr.fragment "PageHeaderTitle" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderSubtitle (x: string) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderSubtitle (node) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderSubtitle (nodes) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderTags (x: string) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderTags (node) = Bolero.Html.attr.fragment "PageHeaderTags" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderTags (nodes) = Bolero.Html.attr.fragment "PageHeaderTags" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderExtra (x: string) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderExtra (node) = Bolero.Html.attr.fragment "PageHeaderExtra" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pageHeaderExtra (nodes) = Bolero.Html.attr.fragment "PageHeaderExtra" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type pagination<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Pagination>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Pagination>

    static member ref x = attr.ref<AntDesign.Pagination> x
    static member total (x: System.Int32) = "Total" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultCurrent (x: System.Int32) = "DefaultCurrent" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member current (x: System.Int32) = "Current" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultPageSize (x: System.Int32) = "DefaultPageSize" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pageSize (x: System.Int32) = "PageSize" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member hideOnSinglePage (x: System.Boolean) = "HideOnSinglePage" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSizeChanger (x: System.Boolean) = "ShowSizeChanger" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onShowSizeChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnShowSizeChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member showQuickJumper (x: System.Boolean) = "ShowQuickJumper" => x |> FelizNode<'FunBlazorGeneric>.create
    static member goButton (x: string) = Bolero.Html.attr.fragment "GoButton" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member goButton (node) = Bolero.Html.attr.fragment "GoButton" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member goButton (nodes) = Bolero.Html.attr.fragment "GoButton" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member showTitle (x: System.Boolean) = "ShowTitle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showTotal (x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = "ShowTotal" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member responsive (x: System.Boolean) = "Responsive" => x |> FelizNode<'FunBlazorGeneric>.create
    static member simple (x: System.Boolean) = "Simple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.PaginationLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
    static member itemRender (render: AntDesign.PaginationItemRenderContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member showLessItems (x: System.Boolean) = "ShowLessItems" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showPrevNextJumpers (x: System.Boolean) = "ShowPrevNextJumpers" => x |> FelizNode<'FunBlazorGeneric>.create
    static member direction (x: System.String) = "Direction" => x |> FelizNode<'FunBlazorGeneric>.create
    static member prevIcon (render: AntDesign.PaginationItemRenderContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "PrevIcon" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member nextIcon (render: AntDesign.PaginationItemRenderContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "NextIcon" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member jumpPrevIcon (render: AntDesign.PaginationItemRenderContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "JumpPrevIcon" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member jumpNextIcon (render: AntDesign.PaginationItemRenderContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "JumpNextIcon" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member totalBoundaryShowSizeChanger (x: System.Int32) = "TotalBoundaryShowSizeChanger" => x |> FelizNode<'FunBlazorGeneric>.create
    static member unmatchedAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type paginationOptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.PaginationOptions>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.PaginationOptions>

    static member ref x = attr.ref<AntDesign.PaginationOptions> x
    static member isSmall (x: System.Boolean) = "IsSmall" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rootPrefixCls (x: System.String) = "RootPrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member changeSize fn = (Bolero.Html.attr.callback<System.Int32> "ChangeSize" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member current (x: System.Int32) = "Current" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pageSize (x: System.Int32) = "PageSize" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x |> FelizNode<'FunBlazorGeneric>.create
    static member quickGo fn = (Bolero.Html.attr.callback<System.Int32> "QuickGo" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member goButton (x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = "GoButton" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type progress<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Progress>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Progress>

    static member ref x = attr.ref<AntDesign.Progress> x
    static member size (x: AntDesign.ProgressSize) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: AntDesign.ProgressType) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member format (fn) = "Format" => (System.Func<System.Double, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member percent (x: System.Double) = "Percent" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showInfo (x: System.Boolean) = "ShowInfo" => x |> FelizNode<'FunBlazorGeneric>.create
    static member status (x: AntDesign.ProgressStatus) = "Status" => x |> FelizNode<'FunBlazorGeneric>.create
    static member strokeLinecap (x: AntDesign.ProgressStrokeLinecap) = "StrokeLinecap" => x |> FelizNode<'FunBlazorGeneric>.create
    static member successPercent (x: System.Double) = "SuccessPercent" => x |> FelizNode<'FunBlazorGeneric>.create
    static member trailColor (x: System.String) = "TrailColor" => x |> FelizNode<'FunBlazorGeneric>.create
    static member strokeWidth (x: System.Int32) = "StrokeWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member strokeColor (x: OneOf.OneOf<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>) = "StrokeColor" => x |> FelizNode<'FunBlazorGeneric>.create
    static member steps (x: System.Int32) = "Steps" => x |> FelizNode<'FunBlazorGeneric>.create
    static member width (x: System.Int32) = "Width" => x |> FelizNode<'FunBlazorGeneric>.create
    static member gapDegree (x: System.Int32) = "GapDegree" => x |> FelizNode<'FunBlazorGeneric>.create
    static member gapPosition (x: AntDesign.ProgressGapPosition) = "GapPosition" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type radio<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Radio<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Radio<'TValue>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Radio<'TValue>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Radio<'TValue>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Radio<'TValue>>
    static member ref x = attr.ref<AntDesign.Radio<'TValue>> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: 'TValue) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member radioButton (x: System.Boolean) = "RadioButton" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checked' (x: System.Boolean) = "Checked" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checked'' (value: IStore<System.Boolean>) = FelizNode<'FunBlazorGeneric>.create("Checked", value)
    static member checked'' (value: cval<System.Boolean>) = FelizNode<'FunBlazorGeneric>.create("Checked", value)
    static member checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = FelizNode<'FunBlazorGeneric>.create("Checked", valueFn)
    static member defaultChecked (x: System.Boolean) = "DefaultChecked" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkedChange fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type rate<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Rate>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Rate>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Rate>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Rate>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Rate>
    static member ref x = attr.ref<AntDesign.Rate> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member allowClear (x: System.Boolean) = "AllowClear" => x |> FelizNode<'FunBlazorGeneric>.create
    static member allowHalf (x: System.Boolean) = "AllowHalf" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member character (render: AntDesign.RateItemRenderContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Character" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member count (x: System.Int32) = "Count" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: System.Decimal) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value' (value: IStore<System.Decimal>) = FelizNode<'FunBlazorGeneric>.create("Value", value)
    static member value' (value: cval<System.Decimal>) = FelizNode<'FunBlazorGeneric>.create("Value", value)
    static member value' (valueFn: System.Decimal * (System.Decimal -> unit)) = FelizNode<'FunBlazorGeneric>.create("Value", valueFn)
    static member valueChanged fn = (Bolero.Html.attr.callback<System.Decimal> "ValueChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member defaultValue (x: System.Decimal) = "DefaultValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tooltips (x: System.String[]) = "Tooltips" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type rateItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.RateItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.RateItem>

    static member ref x = attr.ref<AntDesign.RateItem> x
    static member allowHalf (x: System.Boolean) = "AllowHalf" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onItemHover fn = (Bolero.Html.attr.callback<System.Boolean> "OnItemHover" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onItemClick fn = (Bolero.Html.attr.callback<System.Boolean> "OnItemClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member tooltip (x: System.String) = "Tooltip" => x |> FelizNode<'FunBlazorGeneric>.create
    static member indexOfGroup (x: System.Int32) = "IndexOfGroup" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hoverValue (x: System.Int32) = "HoverValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hasHalf (x: System.Boolean) = "HasHalf" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isFocused (x: System.Boolean) = "IsFocused" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type result<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Result>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Result>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Result>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Result>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Result>
    static member ref x = attr.ref<AntDesign.Result> x
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member subTitle (x: System.String) = "SubTitle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member subTitleTemplate (x: string) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member subTitleTemplate (node) = Bolero.Html.attr.fragment "SubTitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member subTitleTemplate (nodes) = Bolero.Html.attr.fragment "SubTitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member extra (x: string) = Bolero.Html.attr.fragment "Extra" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member extra (node) = Bolero.Html.attr.fragment "Extra" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member extra (nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member status (x: System.String) = "Status" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isShowIcon (x: System.Boolean) = "IsShowIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type selectOption<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.SelectOption<'TItemValue, 'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SelectOption<'TItemValue, 'TItem>>

    static member ref x = attr.ref<AntDesign.SelectOption<'TItemValue, 'TItem>> x
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member label (x: System.String) = "Label" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: 'TItemValue) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type simpleSelectOption<'FunBlazorGeneric> =
    inherit selectOption<'FunBlazorGeneric, System.String, System.String>
    static member create () = [] |> html.blazor<AntDesign.SimpleSelectOption>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SimpleSelectOption>

    static member ref x = attr.ref<AntDesign.SimpleSelectOption> x

                    

type skeleton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Skeleton>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Skeleton>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Skeleton>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Skeleton>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Skeleton>
    static member ref x = attr.ref<AntDesign.Skeleton> x
    static member active (x: System.Boolean) = "Active" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.Boolean) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "TitleWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member avatar (x: System.Boolean) = "Avatar" => x |> FelizNode<'FunBlazorGeneric>.create
    static member avatarSize (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "AvatarSize" => x |> FelizNode<'FunBlazorGeneric>.create
    static member avatarShape (x: System.String) = "AvatarShape" => x |> FelizNode<'FunBlazorGeneric>.create
    static member paragraph (x: System.Boolean) = "Paragraph" => x |> FelizNode<'FunBlazorGeneric>.create
    static member paragraphRows (x: System.Nullable<System.Int32>) = "ParagraphRows" => x |> FelizNode<'FunBlazorGeneric>.create
    static member paragraphWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IList<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = "ParagraphWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type skeletonElement<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.SkeletonElement>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SkeletonElement>

    static member ref x = attr.ref<AntDesign.SkeletonElement> x
    static member active (x: System.Boolean) = "Active" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member shape (x: System.String) = "Shape" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type space<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Space>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Space>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Space>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Space>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Space>
    static member ref x = attr.ref<AntDesign.Space> x
    static member align (x: System.String) = "Align" => x |> FelizNode<'FunBlazorGeneric>.create
    static member direction (x: AntDesign.DirectionVHType) = "Direction" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrap (x: System.Boolean) = "Wrap" => x |> FelizNode<'FunBlazorGeneric>.create
    static member split (x: string) = Bolero.Html.attr.fragment "Split" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member split (node) = Bolero.Html.attr.fragment "Split" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member split (nodes) = Bolero.Html.attr.fragment "Split" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type spaceItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.SpaceItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SpaceItem>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.SpaceItem>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.SpaceItem>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.SpaceItem>
    static member ref x = attr.ref<AntDesign.SpaceItem> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type spin<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Spin>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Spin>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Spin>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Spin>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Spin>
    static member ref x = attr.ref<AntDesign.Spin> x
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tip (x: System.String) = "Tip" => x |> FelizNode<'FunBlazorGeneric>.create
    static member delay (x: System.Int32) = "Delay" => x |> FelizNode<'FunBlazorGeneric>.create
    static member spinning (x: System.Boolean) = "Spinning" => x |> FelizNode<'FunBlazorGeneric>.create
    static member wrapperClassName (x: System.String) = "WrapperClassName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member indicator (x: string) = Bolero.Html.attr.fragment "Indicator" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member indicator (node) = Bolero.Html.attr.fragment "Indicator" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member indicator (nodes) = Bolero.Html.attr.fragment "Indicator" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type statisticComponentBase<'FunBlazorGeneric, 'T> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.StatisticComponentBase<'T>>
    static member ref x = attr.ref<AntDesign.StatisticComponentBase<'T>> x
    static member prefix (x: System.String) = "Prefix" => x |> FelizNode<'FunBlazorGeneric>.create
    static member prefixTemplate (x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member prefixTemplate (node) = Bolero.Html.attr.fragment "PrefixTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member prefixTemplate (nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member suffix (x: System.String) = "Suffix" => x |> FelizNode<'FunBlazorGeneric>.create
    static member suffixTemplate (x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixTemplate (node) = Bolero.Html.attr.fragment "SuffixTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixTemplate (nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: 'T) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member valueStyle (x: System.String) = "ValueStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type countDown<'FunBlazorGeneric> =
    inherit statisticComponentBase<'FunBlazorGeneric, System.DateTime>
    static member create () = [] |> html.blazor<AntDesign.CountDown>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.CountDown>

    static member ref x = attr.ref<AntDesign.CountDown> x
    static member format (x: System.String) = "Format" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onFinish fn = attr.callbackOfUnit("OnFinish", fn) |> FelizNode<'FunBlazorGeneric>.create
                    

type statistic<'FunBlazorGeneric, 'TValue> =
    inherit statisticComponentBase<'FunBlazorGeneric, 'TValue>
    static member create () = [] |> html.blazor<AntDesign.Statistic<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Statistic<'TValue>>

    static member ref x = attr.ref<AntDesign.Statistic<'TValue>> x
    static member decimalSeparator (x: System.String) = "DecimalSeparator" => x |> FelizNode<'FunBlazorGeneric>.create
    static member groupSeparator (x: System.String) = "GroupSeparator" => x |> FelizNode<'FunBlazorGeneric>.create
    static member precision (x: System.Int32) = "Precision" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type step<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Step>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Step>

    static member ref x = attr.ref<AntDesign.Step> x
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member status (x: System.String) = "Status" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member subtitle (x: System.String) = "Subtitle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member subtitleTemplate (x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member subtitleTemplate (node) = Bolero.Html.attr.fragment "SubtitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member subtitleTemplate (nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member description (x: System.String) = "Description" => x |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (node) = Bolero.Html.attr.fragment "DescriptionTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type steps<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Steps>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Steps>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Steps>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Steps>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Steps>
    static member ref x = attr.ref<AntDesign.Steps> x
    static member current (x: System.Int32) = "Current" => x |> FelizNode<'FunBlazorGeneric>.create
    static member percent (x: System.Nullable<System.Double>) = "Percent" => x |> FelizNode<'FunBlazorGeneric>.create
    static member progressDot (x: string) = Bolero.Html.attr.fragment "ProgressDot" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member progressDot (node) = Bolero.Html.attr.fragment "ProgressDot" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member progressDot (nodes) = Bolero.Html.attr.fragment "ProgressDot" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member showProgressDot (x: System.Boolean) = "ShowProgressDot" => x |> FelizNode<'FunBlazorGeneric>.create
    static member direction (x: System.String) = "Direction" => x |> FelizNode<'FunBlazorGeneric>.create
    static member labelPlacement (x: System.String) = "LabelPlacement" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: System.String) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member startIndex (x: System.Int32) = "StartIndex" => x |> FelizNode<'FunBlazorGeneric>.create
    static member status (x: System.String) = "Status" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<System.Int32> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type table<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Table<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Table<'TItem>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Table<'TItem>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Table<'TItem>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Table<'TItem>>
    static member ref x = attr.ref<AntDesign.Table<'TItem>> x
    static member renderMode (x: AntDesign.RenderMode) = "RenderMode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member rowTemplate (render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member expandTemplate (render: AntDesign.TableModels.RowData<'TItem> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ExpandTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member defaultExpandAllRows (x: System.Boolean) = "DefaultExpandAllRows" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rowExpandable (fn) = "RowExpandable" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member treeChildren (fn) = "TreeChildren" => (System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<AntDesign.TableModels.QueryModel<'TItem>> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onRow (fn) = "OnRow" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.Dictionary<System.String, System.Object>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onHeaderRow (fn) = "OnHeaderRow" => (System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member footer (x: System.String) = "Footer" => x |> FelizNode<'FunBlazorGeneric>.create
    static member footerTemplate (x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member footerTemplate (node) = Bolero.Html.attr.fragment "FooterTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member footerTemplate (nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: AntDesign.TableSize) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.TableLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
    static member bordered (x: System.Boolean) = "Bordered" => x |> FelizNode<'FunBlazorGeneric>.create
    static member scrollX (x: System.String) = "ScrollX" => x |> FelizNode<'FunBlazorGeneric>.create
    static member scrollY (x: System.String) = "ScrollY" => x |> FelizNode<'FunBlazorGeneric>.create
    static member scrollBarWidth (x: System.Int32) = "ScrollBarWidth" => x |> FelizNode<'FunBlazorGeneric>.create
    static member indentSize (x: System.Int32) = "IndentSize" => x |> FelizNode<'FunBlazorGeneric>.create
    static member expandIconColumnIndex (x: System.Int32) = "ExpandIconColumnIndex" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rowClassName (fn) = "RowClassName" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member expandedRowClassName (fn) = "ExpandedRowClassName" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onExpand fn = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnExpand" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member sortDirections (x: AntDesign.SortDirection[]) = "SortDirections" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tableLayout (x: System.String) = "TableLayout" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onRowClick fn = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnRowClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member remoteDataSource (x: System.Boolean) = "RemoteDataSource" => x |> FelizNode<'FunBlazorGeneric>.create
    static member responsive (x: System.Boolean) = "Responsive" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hidePagination (x: System.Boolean) = "HidePagination" => x |> FelizNode<'FunBlazorGeneric>.create
    static member paginationPosition (x: System.String) = "PaginationPosition" => x |> FelizNode<'FunBlazorGeneric>.create
    static member paginationTemplate (x: string) = Bolero.Html.attr.fragment "PaginationTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member paginationTemplate (node) = Bolero.Html.attr.fragment "PaginationTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member paginationTemplate (nodes) = Bolero.Html.attr.fragment "PaginationTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member total (x: System.Int32) = "Total" => x |> FelizNode<'FunBlazorGeneric>.create
    static member total' (value: IStore<System.Int32>) = FelizNode<'FunBlazorGeneric>.create("Total", value)
    static member total' (value: cval<System.Int32>) = FelizNode<'FunBlazorGeneric>.create("Total", value)
    static member total' (valueFn: System.Int32 * (System.Int32 -> unit)) = FelizNode<'FunBlazorGeneric>.create("Total", valueFn)
    static member totalChanged fn = (Bolero.Html.attr.callback<System.Int32> "TotalChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member pageIndex (x: System.Int32) = "PageIndex" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pageIndex' (value: IStore<System.Int32>) = FelizNode<'FunBlazorGeneric>.create("PageIndex", value)
    static member pageIndex' (value: cval<System.Int32>) = FelizNode<'FunBlazorGeneric>.create("PageIndex", value)
    static member pageIndex' (valueFn: System.Int32 * (System.Int32 -> unit)) = FelizNode<'FunBlazorGeneric>.create("PageIndex", valueFn)
    static member pageIndexChanged fn = (Bolero.Html.attr.callback<System.Int32> "PageIndexChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member pageSize (x: System.Int32) = "PageSize" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pageSize' (value: IStore<System.Int32>) = FelizNode<'FunBlazorGeneric>.create("PageSize", value)
    static member pageSize' (value: cval<System.Int32>) = FelizNode<'FunBlazorGeneric>.create("PageSize", value)
    static member pageSize' (valueFn: System.Int32 * (System.Int32 -> unit)) = FelizNode<'FunBlazorGeneric>.create("PageSize", valueFn)
    static member pageSizeChanged fn = (Bolero.Html.attr.callback<System.Int32> "PageSizeChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onPageIndexChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageIndexChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onPageSizeChange fn = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageSizeChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member selectedRows (x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedRows" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedRows' (value: IStore<System.Collections.Generic.IEnumerable<'TItem>>) = FelizNode<'FunBlazorGeneric>.create("SelectedRows", value)
    static member selectedRows' (value: cval<System.Collections.Generic.IEnumerable<'TItem>>) = FelizNode<'FunBlazorGeneric>.create("SelectedRows", value)
    static member selectedRows' (valueFn: System.Collections.Generic.IEnumerable<'TItem> * (System.Collections.Generic.IEnumerable<'TItem> -> unit)) = FelizNode<'FunBlazorGeneric>.create("SelectedRows", valueFn)
    static member selectedRowsChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItem>> "SelectedRowsChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type reuseTabs<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ReuseTabs>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ReuseTabs>

    static member ref x = attr.ref<AntDesign.ReuseTabs> x
    static member tabPaneClass (x: System.String) = "TabPaneClass" => x |> FelizNode<'FunBlazorGeneric>.create
    static member draggable (x: System.Boolean) = "Draggable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: AntDesign.TabSize) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member body (render: AntDesign.ReuseTabsPageItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Body" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.ReuseTabsLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type tabPane<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.TabPane>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TabPane>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.TabPane>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.TabPane>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.TabPane>
    static member ref x = attr.ref<AntDesign.TabPane> x
    static member forceRender (x: System.Boolean) = "ForceRender" => x |> FelizNode<'FunBlazorGeneric>.create
    static member key (x: System.String) = "Key" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tab (x: System.String) = "Tab" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tabTemplate (x: string) = Bolero.Html.attr.fragment "TabTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member tabTemplate (node) = Bolero.Html.attr.fragment "TabTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member tabTemplate (nodes) = Bolero.Html.attr.fragment "TabTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member tabContextMenu (x: string) = Bolero.Html.attr.fragment "TabContextMenu" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member tabContextMenu (node) = Bolero.Html.attr.fragment "TabContextMenu" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member tabContextMenu (nodes) = Bolero.Html.attr.fragment "TabContextMenu" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member closable (x: System.Boolean) = "Closable" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type tabs<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Tabs>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Tabs>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Tabs>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Tabs>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Tabs>
    static member ref x = attr.ref<AntDesign.Tabs> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member activeKey (x: System.String) = "ActiveKey" => x |> FelizNode<'FunBlazorGeneric>.create
    static member activeKey' (value: IStore<System.String>) = FelizNode<'FunBlazorGeneric>.create("ActiveKey", value)
    static member activeKey' (value: cval<System.String>) = FelizNode<'FunBlazorGeneric>.create("ActiveKey", value)
    static member activeKey' (valueFn: System.String * (System.String -> unit)) = FelizNode<'FunBlazorGeneric>.create("ActiveKey", valueFn)
    static member activeKeyChanged fn = (Bolero.Html.attr.callback<System.String> "ActiveKeyChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member animated (x: System.Boolean) = "Animated" => x |> FelizNode<'FunBlazorGeneric>.create
    static member inkBarAnimated (x: System.Boolean) = "InkBarAnimated" => x |> FelizNode<'FunBlazorGeneric>.create
    static member renderTabBar (x: System.Object) = "RenderTabBar" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultActiveKey (x: System.String) = "DefaultActiveKey" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hideAdd (x: System.Boolean) = "HideAdd" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: AntDesign.TabSize) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContent (x: string) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContent (node) = Bolero.Html.attr.fragment "TabBarExtraContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContent (nodes) = Bolero.Html.attr.fragment "TabBarExtraContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContentLeft (x: string) = Bolero.Html.attr.fragment "TabBarExtraContentLeft" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContentLeft (node) = Bolero.Html.attr.fragment "TabBarExtraContentLeft" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContentLeft (nodes) = Bolero.Html.attr.fragment "TabBarExtraContentLeft" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContentRight (x: string) = Bolero.Html.attr.fragment "TabBarExtraContentRight" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContentRight (node) = Bolero.Html.attr.fragment "TabBarExtraContentRight" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarExtraContentRight (nodes) = Bolero.Html.attr.fragment "TabBarExtraContentRight" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarGutter (x: System.Int32) = "TabBarGutter" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tabBarStyle (x: System.String) = "TabBarStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member tabPosition (x: AntDesign.TabPosition) = "TabPosition" => x |> FelizNode<'FunBlazorGeneric>.create
    static member type' (x: AntDesign.TabType) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onEdit (fn) = "OnEdit" => (System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onClose fn = (Bolero.Html.attr.callback<System.String> "OnClose" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onAddClick fn = attr.callbackOfUnit("OnAddClick", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member afterTabCreated fn = (Bolero.Html.attr.callback<System.String> "AfterTabCreated" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onTabClick fn = (Bolero.Html.attr.callback<System.String> "OnTabClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member draggable (x: System.Boolean) = "Draggable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member centered (x: System.Boolean) = "Centered" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type tag<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Tag>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Tag>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Tag>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Tag>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Tag>
    static member ref x = attr.ref<AntDesign.Tag> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member closable (x: System.Boolean) = "Closable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkable (x: System.Boolean) = "Checkable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checked' (x: System.Boolean) = "Checked" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checked'' (value: IStore<System.Boolean>) = FelizNode<'FunBlazorGeneric>.create("Checked", value)
    static member checked'' (value: cval<System.Boolean>) = FelizNode<'FunBlazorGeneric>.create("Checked", value)
    static member checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = FelizNode<'FunBlazorGeneric>.create("Checked", valueFn)
    static member checkedChanged fn = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member color (x: System.String) = "Color" => x |> FelizNode<'FunBlazorGeneric>.create
    static member presetColor (x: System.Nullable<AntDesign.PresetColor>) = "PresetColor" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member noAnimation (x: System.Boolean) = "NoAnimation" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClose fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onClosing fn = (Bolero.Html.attr.callback<AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs>> "OnClosing" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = attr.callbackOfUnit("OnClick", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member visible (x: System.Boolean) = "Visible" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type timeline<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Timeline>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Timeline>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Timeline>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Timeline>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Timeline>
    static member ref x = attr.ref<AntDesign.Timeline> x
    static member mode (x: System.Nullable<AntDesign.TimelineMode>) = "Mode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member reverse (x: System.Boolean) = "Reverse" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pending (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Pending" => x |> FelizNode<'FunBlazorGeneric>.create
    static member pendingDot (x: string) = Bolero.Html.attr.fragment "PendingDot" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member pendingDot (node) = Bolero.Html.attr.fragment "PendingDot" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member pendingDot (nodes) = Bolero.Html.attr.fragment "PendingDot" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type timelineItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.TimelineItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TimelineItem>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.TimelineItem>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.TimelineItem>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.TimelineItem>
    static member ref x = attr.ref<AntDesign.TimelineItem> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member dot (x: string) = Bolero.Html.attr.fragment "Dot" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member dot (node) = Bolero.Html.attr.fragment "Dot" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member dot (nodes) = Bolero.Html.attr.fragment "Dot" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member color (x: System.String) = "Color" => x |> FelizNode<'FunBlazorGeneric>.create
    static member label (x: System.String) = "Label" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type transfer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Transfer>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Transfer>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Transfer>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Transfer>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Transfer>
    static member ref x = attr.ref<AntDesign.Transfer> x
    static member dataSource (x: System.Collections.Generic.IList<AntDesign.TransferItem>) = "DataSource" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titles (x: System.String[]) = "Titles" => x |> FelizNode<'FunBlazorGeneric>.create
    static member operations (x: System.String[]) = "Operations" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSearch (x: System.Boolean) = "ShowSearch" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSelectAll (x: System.Boolean) = "ShowSelectAll" => x |> FelizNode<'FunBlazorGeneric>.create
    static member targetKeys (x: System.String[]) = "TargetKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedKeys (x: System.String[]) = "SelectedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<AntDesign.TransferChangeArgs> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onScroll fn = (Bolero.Html.attr.callback<AntDesign.TransferScrollArgs> "OnScroll" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onSearch fn = (Bolero.Html.attr.callback<AntDesign.TransferSearchArgs> "OnSearch" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onSelectChange fn = (Bolero.Html.attr.callback<AntDesign.TransferSelectChangeArgs> "OnSelectChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member render (fn) = "Render" => (System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member locale (x: AntDesign.TransferLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
    static member footer (x: System.String) = "Footer" => x |> FelizNode<'FunBlazorGeneric>.create
    static member footerTemplate (x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member footerTemplate (node) = Bolero.Html.attr.fragment "FooterTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member footerTemplate (nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type tree<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Tree<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Tree<'TItem>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Tree<'TItem>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Tree<'TItem>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Tree<'TItem>>
    static member ref x = attr.ref<AntDesign.Tree<'TItem>> x
    static member showExpand (x: System.Boolean) = "ShowExpand" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showLine (x: System.Boolean) = "ShowLine" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showIcon (x: System.Boolean) = "ShowIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member blockNode (x: System.Boolean) = "BlockNode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member draggable (x: System.Boolean) = "Draggable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showLeafIcon (x: System.Boolean) = "ShowLeafIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member switcherIcon (x: System.String) = "SwitcherIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member nodes (x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member nodes (node) = Bolero.Html.attr.fragment "Nodes" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member nodes (nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member selectable (x: System.Boolean) = "Selectable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member multiple (x: System.Boolean) = "Multiple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultSelectedKeys (x: System.String[]) = "DefaultSelectedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedKey (x: System.String) = "SelectedKey" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedKey' (value: IStore<System.String>) = FelizNode<'FunBlazorGeneric>.create("SelectedKey", value)
    static member selectedKey' (value: cval<System.String>) = FelizNode<'FunBlazorGeneric>.create("SelectedKey", value)
    static member selectedKey' (valueFn: System.String * (System.String -> unit)) = FelizNode<'FunBlazorGeneric>.create("SelectedKey", valueFn)
    static member selectedKeyChanged fn = (Bolero.Html.attr.callback<System.String> "SelectedKeyChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member selectedNode (x: AntDesign.TreeNode<'TItem>) = "SelectedNode" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedNode' (value: IStore<AntDesign.TreeNode<'TItem>>) = FelizNode<'FunBlazorGeneric>.create("SelectedNode", value)
    static member selectedNode' (value: cval<AntDesign.TreeNode<'TItem>>) = FelizNode<'FunBlazorGeneric>.create("SelectedNode", value)
    static member selectedNode' (valueFn: AntDesign.TreeNode<'TItem> * (AntDesign.TreeNode<'TItem> -> unit)) = FelizNode<'FunBlazorGeneric>.create("SelectedNode", valueFn)
    static member selectedNodeChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeNode<'TItem>> "SelectedNodeChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member selectedData (x: 'TItem) = "SelectedData" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedData' (value: IStore<'TItem>) = FelizNode<'FunBlazorGeneric>.create("SelectedData", value)
    static member selectedData' (value: cval<'TItem>) = FelizNode<'FunBlazorGeneric>.create("SelectedData", value)
    static member selectedData' (valueFn: 'TItem * ('TItem -> unit)) = FelizNode<'FunBlazorGeneric>.create("SelectedData", valueFn)
    static member selectedDataChanged fn = (Bolero.Html.attr.callback<'TItem> "SelectedDataChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member selectedKeys (x: System.String[]) = "SelectedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedKeys' (value: IStore<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("SelectedKeys", value)
    static member selectedKeys' (value: cval<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("SelectedKeys", value)
    static member selectedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = FelizNode<'FunBlazorGeneric>.create("SelectedKeys", valueFn)
    static member selectedKeysChanged fn = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member selectedNodes (x: AntDesign.TreeNode<'TItem>[]) = "SelectedNodes" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selectedDatas (x: 'TItem[]) = "SelectedDatas" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkable (x: System.Boolean) = "Checkable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkStrictly (x: System.Boolean) = "CheckStrictly" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkedKeys (x: System.String[]) = "CheckedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checkedKeys' (value: IStore<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("CheckedKeys", value)
    static member checkedKeys' (value: cval<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("CheckedKeys", value)
    static member checkedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = FelizNode<'FunBlazorGeneric>.create("CheckedKeys", valueFn)
    static member checkedKeysChanged fn = (Bolero.Html.attr.callback<System.String[]> "CheckedKeysChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member defaultCheckedKeys (x: System.String[]) = "DefaultCheckedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member searchValue (x: System.String) = "SearchValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member searchExpression (fn) = "SearchExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member matchedStyle (x: System.String) = "MatchedStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member matchedClass (x: System.String) = "MatchedClass" => x |> FelizNode<'FunBlazorGeneric>.create
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleExpression (fn) = "TitleExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member keyExpression (fn) = "KeyExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member iconExpression (fn) = "IconExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member isLeafExpression (fn) = "IsLeafExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member childrenExpression (fn) = "ChildrenExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IList<'TItem>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member disabledExpression (fn) = "DisabledExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onNodeLoadDelayAsync fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnNodeLoadDelayAsync" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onDblClick fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDblClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onContextMenu fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnContextMenu" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onCheck fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnCheck" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onSelect fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnSelect" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onUnSelect fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnUnSelect" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onExpandChanged fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnExpandChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member indentTemplate (render: AntDesign.TreeNode<'TItem> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "IndentTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (render: AntDesign.TreeNode<'TItem> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "TitleTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleIconTemplate (render: AntDesign.TreeNode<'TItem> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "TitleIconTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member switcherIconTemplate (render: AntDesign.TreeNode<'TItem> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "SwitcherIconTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member onDragStart fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDragStart" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onDragEnter fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDragEnter" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onDragLeave fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDragLeave" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onDrop fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDrop" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onDragEnd fn = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDragEnd" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member defaultExpandAll (x: System.Boolean) = "DefaultExpandAll" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultExpandParent (x: System.Boolean) = "DefaultExpandParent" => x |> FelizNode<'FunBlazorGeneric>.create
    static member defaultExpandedKeys (x: System.String[]) = "DefaultExpandedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member expandedKeys (x: System.String[]) = "ExpandedKeys" => x |> FelizNode<'FunBlazorGeneric>.create
    static member expandedKeys' (value: IStore<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("ExpandedKeys", value)
    static member expandedKeys' (value: cval<System.String[]>) = FelizNode<'FunBlazorGeneric>.create("ExpandedKeys", value)
    static member expandedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = FelizNode<'FunBlazorGeneric>.create("ExpandedKeys", valueFn)
    static member expandedKeysChanged fn = (Bolero.Html.attr.callback<System.String[]> "ExpandedKeysChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onExpand fn = (Bolero.Html.attr.callback<System.ValueTuple<System.String[], AntDesign.TreeNode<'TItem>, System.Boolean>> "OnExpand" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member autoExpandParent (x: System.Boolean) = "AutoExpandParent" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type directoryTree<'FunBlazorGeneric, 'TItem> =
    inherit tree<'FunBlazorGeneric, 'TItem>
    static member create () = [] |> html.blazor<AntDesign.DirectoryTree<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.DirectoryTree<'TItem>>

    static member ref x = attr.ref<AntDesign.DirectoryTree<'TItem>> x

                    

type treeNode<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.TreeNode<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TreeNode<'TItem>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.TreeNode<'TItem>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.TreeNode<'TItem>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.TreeNode<'TItem>>
    static member ref x = attr.ref<AntDesign.TreeNode<'TItem>> x
    static member nodes (x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member nodes (node) = Bolero.Html.attr.fragment "Nodes" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member nodes (nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member key (x: System.String) = "Key" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member selected (x: System.Boolean) = "Selected" => x |> FelizNode<'FunBlazorGeneric>.create
    static member loading (x: System.Boolean) = "Loading" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isLeaf (x: System.Boolean) = "IsLeaf" => x |> FelizNode<'FunBlazorGeneric>.create
    static member expanded (x: System.Boolean) = "Expanded" => x |> FelizNode<'FunBlazorGeneric>.create
    static member checked' (x: System.Boolean) = "Checked" => x |> FelizNode<'FunBlazorGeneric>.create
    static member indeterminate (x: System.Boolean) = "Indeterminate" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disableCheckbox (x: System.Boolean) = "DisableCheckbox" => x |> FelizNode<'FunBlazorGeneric>.create
    static member draggable (x: System.Boolean) = "Draggable" => x |> FelizNode<'FunBlazorGeneric>.create
    static member icon (x: System.String) = "Icon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member iconTemplate (render: AntDesign.TreeNode<'TItem> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "IconTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member switcherIcon (x: System.String) = "SwitcherIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member switcherIconTemplate (render: AntDesign.TreeNode<'TItem> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "SwitcherIconTemplate" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member dataItem (x: 'TItem) = "DataItem" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type upload<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Upload>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Upload>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Upload>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Upload>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Upload>
    static member ref x = attr.ref<AntDesign.Upload> x
    static member beforeUpload (fn) = "BeforeUpload" => (System.Func<AntDesign.UploadFileItem, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member beforeAllUploadAsync (fn) = "BeforeAllUploadAsync" => (System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member beforeAllUpload (fn) = "BeforeAllUpload" => (System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member name (x: System.String) = "Name" => x |> FelizNode<'FunBlazorGeneric>.create
    static member action (x: System.String) = "Action" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member data (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> FelizNode<'FunBlazorGeneric>.create
    static member listType (x: System.String) = "ListType" => x |> FelizNode<'FunBlazorGeneric>.create
    static member directory (x: System.Boolean) = "Directory" => x |> FelizNode<'FunBlazorGeneric>.create
    static member multiple (x: System.Boolean) = "Multiple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member accept (x: System.String) = "Accept" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showUploadList (x: System.Boolean) = "ShowUploadList" => x |> FelizNode<'FunBlazorGeneric>.create
    static member fileList (x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "FileList" => x |> FelizNode<'FunBlazorGeneric>.create
    static member fileList' (value: IStore<System.Collections.Generic.List<AntDesign.UploadFileItem>>) = FelizNode<'FunBlazorGeneric>.create("FileList", value)
    static member fileList' (value: cval<System.Collections.Generic.List<AntDesign.UploadFileItem>>) = FelizNode<'FunBlazorGeneric>.create("FileList", value)
    static member fileList' (valueFn: System.Collections.Generic.List<AntDesign.UploadFileItem> * (System.Collections.Generic.List<AntDesign.UploadFileItem> -> unit)) = FelizNode<'FunBlazorGeneric>.create("FileList", valueFn)
    static member locale (x: AntDesign.UploadLocale) = "Locale" => x |> FelizNode<'FunBlazorGeneric>.create
    static member fileListChanged fn = (Bolero.Html.attr.callback<System.Collections.Generic.List<AntDesign.UploadFileItem>> "FileListChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member defaultFileList (x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "DefaultFileList" => x |> FelizNode<'FunBlazorGeneric>.create
    static member headers (x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onSingleCompleted fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnSingleCompleted" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onCompleted fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnCompleted" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onChange fn = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnChange" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onRemove (fn) = "OnRemove" => (System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onPreview fn = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnPreview" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onDownload fn = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnDownload" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member showButton (x: System.Boolean) = "ShowButton" => x |> FelizNode<'FunBlazorGeneric>.create
    static member drag (x: System.Boolean) = "Drag" => x |> FelizNode<'FunBlazorGeneric>.create
    static member method (x: System.String) = "Method" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type breadcrumbItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.BreadcrumbItem>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.BreadcrumbItem>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.BreadcrumbItem>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.BreadcrumbItem>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.BreadcrumbItem>
    static member ref x = attr.ref<AntDesign.BreadcrumbItem> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member overlay (x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member overlay (node) = Bolero.Html.attr.fragment "Overlay" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member overlay (nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member href (x: System.String) = "Href" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type calendarHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.CalendarHeader>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.CalendarHeader>

    static member ref x = attr.ref<AntDesign.CalendarHeader> x

                    

type cardMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.CardMeta>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.CardMeta>

    static member ref x = attr.ref<AntDesign.CardMeta> x
    static member title (x: System.String) = "Title" => x |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (node) = Bolero.Html.attr.fragment "TitleTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member titleTemplate (nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member description (x: System.String) = "Description" => x |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (node) = Bolero.Html.attr.fragment "DescriptionTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member descriptionTemplate (nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member avatar (x: System.String) = "Avatar" => x |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (node) = Bolero.Html.attr.fragment "AvatarTemplate" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member avatarTemplate (nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type antContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.AntContainer>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.AntContainer>

    static member ref x = attr.ref<AntDesign.AntContainer> x

                    

type template<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Template>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Template>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Template>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Template>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Template>
    static member ref x = attr.ref<AntDesign.Template> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member if' (fn) = "If" => (System.Func<System.Boolean>fn) |> FelizNode<'FunBlazorGeneric>.create
                    

type emptyDefaultImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.EmptyDefaultImg>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.EmptyDefaultImg>

    static member ref x = attr.ref<AntDesign.EmptyDefaultImg> x
    static member prefixCls (x: System.String) = "PrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type emptySimpleImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.EmptySimpleImg>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.EmptySimpleImg>

    static member ref x = attr.ref<AntDesign.EmptySimpleImg> x
    static member prefixCls (x: System.String) = "PrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type content<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Content>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Content>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Content>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Content>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Content>
    static member ref x = attr.ref<AntDesign.Content> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type footer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Footer>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Footer>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Footer>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Footer>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Footer>
    static member ref x = attr.ref<AntDesign.Footer> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type header<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Header>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Header>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Header>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Header>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Header>
    static member ref x = attr.ref<AntDesign.Header> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type layout<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Layout>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Layout>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Layout>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Layout>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Layout>
    static member ref x = attr.ref<AntDesign.Layout> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type menuDivider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.MenuDivider>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.MenuDivider>

    static member ref x = attr.ref<AntDesign.MenuDivider> x

                    

type paginationPager<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.PaginationPager>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.PaginationPager>

    static member ref x = attr.ref<AntDesign.PaginationPager> x
    static member showTitle (x: System.Boolean) = "ShowTitle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member page (x: System.Int32) = "Page" => x |> FelizNode<'FunBlazorGeneric>.create
    static member rootPrefixCls (x: System.String) = "RootPrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member active (x: System.Boolean) = "Active" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = (Bolero.Html.attr.callback<System.Int32> "OnClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onKeyPress fn = (Bolero.Html.attr.callback<System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action>> "OnKeyPress" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member itemRender (render: AntDesign.PaginationItemRenderContext -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member unmatchedAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals.Select.Internal

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type selectOptionGroup<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>

    static member ref x = attr.ref<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>> x

                    
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type calendarPanelChooser<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.CalendarPanelChooser>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.CalendarPanelChooser>

    static member ref x = attr.ref<AntDesign.Internal.CalendarPanelChooser> x
    static member calendar (x: AntDesign.Calendar) = "Calendar" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member pickerIndex (x: System.Int32) = "PickerIndex" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type element<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.Element>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.Element>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Internal.Element>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Internal.Element>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Internal.Element>
    static member ref x = attr.ref<AntDesign.Internal.Element> x
    static member htmlTag (x: System.String) = "HtmlTag" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member refChanged fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member attributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type overlay<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.Overlay>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.Overlay>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Internal.Overlay>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Internal.Overlay>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Internal.Overlay>
    static member ref x = attr.ref<AntDesign.Internal.Overlay> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onOverlayMouseEnter fn = attr.callbackOfUnit("OnOverlayMouseEnter", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onOverlayMouseLeave fn = attr.callbackOfUnit("OnOverlayMouseLeave", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onOverlayMouseUp fn = attr.callbackOfUnit("OnOverlayMouseUp", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onShow fn = attr.callbackOfUnit("OnShow", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onHide fn = attr.callbackOfUnit("OnHide", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member overlayChildPrefixCls (x: System.String) = "OverlayChildPrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hideMillisecondsDelay (x: System.Int32) = "HideMillisecondsDelay" => x |> FelizNode<'FunBlazorGeneric>.create
    static member waitForHideAnimMilliseconds (x: System.Int32) = "WaitForHideAnimMilliseconds" => x |> FelizNode<'FunBlazorGeneric>.create
    static member verticalOffset (x: System.Int32) = "VerticalOffset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member horizontalOffset (x: System.Int32) = "HorizontalOffset" => x |> FelizNode<'FunBlazorGeneric>.create
    static member hiddenMode (x: System.Boolean) = "HiddenMode" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type datePickerPanelChooser<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerPanelChooser<'TValue>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerPanelChooser<'TValue>>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerPanelChooser<'TValue>> x
    static member datePicker (x: AntDesign.DatePickerBase<'TValue>) = "DatePicker" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn) |> FelizNode<'FunBlazorGeneric>.create
    static member pickerIndex (x: System.Int32) = "PickerIndex" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type uploadButton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.UploadButton>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.UploadButton>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Internal.UploadButton>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Internal.UploadButton>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Internal.UploadButton>
    static member ref x = attr.ref<AntDesign.Internal.UploadButton> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member listType (x: System.String) = "ListType" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showButton (x: System.Boolean) = "ShowButton" => x |> FelizNode<'FunBlazorGeneric>.create
    static member name (x: System.String) = "Name" => x |> FelizNode<'FunBlazorGeneric>.create
    static member directory (x: System.Boolean) = "Directory" => x |> FelizNode<'FunBlazorGeneric>.create
    static member multiple (x: System.Boolean) = "Multiple" => x |> FelizNode<'FunBlazorGeneric>.create
    static member accept (x: System.String) = "Accept" => x |> FelizNode<'FunBlazorGeneric>.create
    static member data (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> FelizNode<'FunBlazorGeneric>.create
    static member headers (x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> FelizNode<'FunBlazorGeneric>.create
    static member action (x: System.String) = "Action" => x |> FelizNode<'FunBlazorGeneric>.create
    static member method (x: System.String) = "Method" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type datePickerInput<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.DatePickerInput>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DatePickerInput>

    static member ref x = attr.ref<AntDesign.Internal.DatePickerInput> x
    static member prefixCls (x: System.String) = "PrefixCls" => x |> FelizNode<'FunBlazorGeneric>.create
    static member size (x: System.String) = "Size" => x |> FelizNode<'FunBlazorGeneric>.create
    static member value (x: System.String) = "Value" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member readOnly (x: System.Boolean) = "ReadOnly" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isRange (x: System.Boolean) = "IsRange" => x |> FelizNode<'FunBlazorGeneric>.create
    static member disabled (x: System.Boolean) = "Disabled" => x |> FelizNode<'FunBlazorGeneric>.create
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showSuffixIcon (x: System.Boolean) = "ShowSuffixIcon" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showTime (x: System.Boolean) = "ShowTime" => x |> FelizNode<'FunBlazorGeneric>.create
    static member htmlInputSize (x: System.Int32) = "HtmlInputSize" => x |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (node) = Bolero.Html.attr.fragment "SuffixIcon" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member suffixIcon (nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member onClick fn = attr.callbackOfUnit("OnClick", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onfocus fn = attr.callbackOfUnit("Onfocus", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onBlur fn = attr.callbackOfUnit("OnBlur", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onfocusout fn = attr.callbackOfUnit("Onfocusout", fn) |> FelizNode<'FunBlazorGeneric>.create
    static member onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member allowClear (x: System.Boolean) = "AllowClear" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onClickClear fn = attr.callbackOfUnit("OnClickClear", fn) |> FelizNode<'FunBlazorGeneric>.create
                    

type dropdownGroupButton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.DropdownGroupButton>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.DropdownGroupButton>

    static member ref x = attr.ref<AntDesign.Internal.DropdownGroupButton> x
    static member leftButton (x: string) = Bolero.Html.attr.fragment "LeftButton" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member leftButton (node) = Bolero.Html.attr.fragment "LeftButton" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member leftButton (nodes) = Bolero.Html.attr.fragment "LeftButton" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member rightButton (x: string) = Bolero.Html.attr.fragment "RightButton" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member rightButton (node) = Bolero.Html.attr.fragment "RightButton" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member rightButton (nodes) = Bolero.Html.attr.fragment "RightButton" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type tableRow<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.Internal.TableRow<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.TableRow<'TItem>>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.Internal.TableRow<'TItem>>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.Internal.TableRow<'TItem>>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.Internal.TableRow<'TItem>>
    static member ref x = attr.ref<AntDesign.Internal.TableRow<'TItem>> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type configProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.ConfigProvider>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ConfigProvider>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.ConfigProvider>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.ConfigProvider>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.ConfigProvider>
    static member ref x = attr.ref<AntDesign.ConfigProvider> x
    static member direction (x: System.String) = "Direction" => x |> FelizNode<'FunBlazorGeneric>.create
    static member form (x: AntDesign.FormConfig) = "Form" => x |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type templateComponentBase<'FunBlazorGeneric, 'TComponentOptions> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.TemplateComponentBase<'TComponentOptions>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TemplateComponentBase<'TComponentOptions>>

    static member ref x = attr.ref<AntDesign.TemplateComponentBase<'TComponentOptions>> x
    static member options (x: 'TComponentOptions) = "Options" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions> =
    inherit templateComponentBase<'FunBlazorGeneric, 'TComponentOptions>
    static member create () = [] |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions>>

    static member ref x = attr.ref<AntDesign.FeedbackComponent<'TComponentOptions>> x
    static member feedbackRef (x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions, 'TResult> =
    inherit feedbackComponent<'FunBlazorGeneric, 'TComponentOptions>
    static member create () = [] |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>

    static member ref x = attr.ref<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>> x

                    

type formProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member create () = [] |> html.blazor<AntDesign.FormProvider>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.FormProvider>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.FormProvider>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.FormProvider>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.FormProvider>
    static member ref x = attr.ref<AntDesign.FormProvider> x
    static member onFormFinish fn = (Bolero.Html.attr.callback<AntDesign.FormProviderFinishEventArgs> "OnFormFinish" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    

type component'<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<AntDesign.Component>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Component>

    static member ref x = attr.ref<AntDesign.Component> x
    static member type' (x: System.Type) = "Type" => x |> FelizNode<'FunBlazorGeneric>.create
    static member typeName (x: System.String) = "TypeName" => x |> FelizNode<'FunBlazorGeneric>.create
    static member parameters (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "Parameters" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type imagePreview<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<AntDesign.ImagePreview>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ImagePreview>

    static member ref x = attr.ref<AntDesign.ImagePreview> x
    static member imageRef (x: AntDesign.ImageRef) = "ImageRef" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type imagePreviewGroup<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<AntDesign.ImagePreviewGroup>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.ImagePreviewGroup>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.ImagePreviewGroup>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.ImagePreviewGroup>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.ImagePreviewGroup>
    static member ref x = attr.ref<AntDesign.ImagePreviewGroup> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
    static member previewVisible (x: System.Boolean) = "PreviewVisible" => x |> FelizNode<'FunBlazorGeneric>.create
    static member previewVisible' (value: IStore<System.Boolean>) = FelizNode<'FunBlazorGeneric>.create("PreviewVisible", value)
    static member previewVisible' (value: cval<System.Boolean>) = FelizNode<'FunBlazorGeneric>.create("PreviewVisible", value)
    static member previewVisible' (valueFn: System.Boolean * (System.Boolean -> unit)) = FelizNode<'FunBlazorGeneric>.create("PreviewVisible", valueFn)
    static member previewVisibleChanged fn = (Bolero.Html.attr.callback<System.Boolean> "PreviewVisibleChanged" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type treeIndent<'FunBlazorGeneric, 'TItem> =
    
    static member create () = [] |> html.blazor<AntDesign.TreeIndent<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TreeIndent<'TItem>>

    static member ref x = attr.ref<AntDesign.TreeIndent<'TItem>> x
    static member treeLevel (x: System.Int32) = "TreeLevel" => x |> FelizNode<'FunBlazorGeneric>.create
                    

type treeNodeCheckbox<'FunBlazorGeneric, 'TItem> =
    
    static member create () = [] |> html.blazor<AntDesign.TreeNodeCheckbox<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TreeNodeCheckbox<'TItem>>

    static member ref x = attr.ref<AntDesign.TreeNodeCheckbox<'TItem>> x
    static member onCheckBoxClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCheckBoxClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type treeNodeSwitcher<'FunBlazorGeneric, 'TItem> =
    
    static member create () = [] |> html.blazor<AntDesign.TreeNodeSwitcher<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TreeNodeSwitcher<'TItem>>

    static member ref x = attr.ref<AntDesign.TreeNodeSwitcher<'TItem>> x
    static member onSwitcherClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnSwitcherClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
                    

type treeNodeTitle<'FunBlazorGeneric, 'TItem> =
    
    static member create () = [] |> html.blazor<AntDesign.TreeNodeTitle<'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.TreeNodeTitle<'TItem>>

    static member ref x = attr.ref<AntDesign.TreeNodeTitle<'TItem>> x

                    

type cardLoading<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<AntDesign.CardLoading>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.CardLoading>

    static member ref x = attr.ref<AntDesign.CardLoading> x

                    

type summaryRow<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<AntDesign.SummaryRow>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.SummaryRow>
    static member create (nodes: Bolero.Node list) = [ attr.childContent nodes ] |> html.blazor<AntDesign.SummaryRow>
    static member create (node: Bolero.Node) = [ attr.childContent [ node ] ] |> html.blazor<AntDesign.SummaryRow>
    static member create (x: string) = [ attr.childContent [ html.text x ] ] |> html.blazor<AntDesign.SummaryRow>
    static member ref x = attr.ref<AntDesign.SummaryRow> x
    static member childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (node) = Bolero.Html.attr.fragment "ChildContent" (node) |> FelizNode<'FunBlazorGeneric>.create
    static member childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment) |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals.statistic

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type statisticComponentBase<'FunBlazorGeneric, 'T> =
    
    static member create () = [] |> html.blazor<AntDesign.statistic.StatisticComponentBase<'T>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.statistic.StatisticComponentBase<'T>>

    static member ref x = attr.ref<AntDesign.statistic.StatisticComponentBase<'T>> x

                    
            
namespace rec AntDesign.DslInternals.Select

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type labelTemplateItem<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member create () = [] |> html.blazor<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>

    static member ref x = attr.ref<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>> x
    static member labelTemplateItemContent (render: 'TItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "LabelTemplateItemContent" (fun x -> render x) |> FelizNode<'FunBlazorGeneric>.create
    static member styles (x: (string * string) list) = attr.styles x |> FelizNode<'FunBlazorGeneric>.create
    static member classes (x: string list) = attr.classes x |> FelizNode<'FunBlazorGeneric>.create
    static member contentStyle (x: System.String) = "ContentStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member contentClass (x: System.String) = "ContentClass" => x |> FelizNode<'FunBlazorGeneric>.create
    static member removeIconStyle (x: System.String) = "RemoveIconStyle" => x |> FelizNode<'FunBlazorGeneric>.create
    static member removeIconClass (x: System.String) = "RemoveIconClass" => x |> FelizNode<'FunBlazorGeneric>.create
    static member refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals.Select.Internal

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type selectContent<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member create () = [] |> html.blazor<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>

    static member ref x = attr.ref<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>> x
    static member prefix (x: System.String) = "Prefix" => x |> FelizNode<'FunBlazorGeneric>.create
    static member placeholder (x: System.String) = "Placeholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member isOverlayShow (x: System.Boolean) = "IsOverlayShow" => x |> FelizNode<'FunBlazorGeneric>.create
    static member showPlaceholder (x: System.Boolean) = "ShowPlaceholder" => x |> FelizNode<'FunBlazorGeneric>.create
    static member maxTagCount (x: System.Int32) = "MaxTagCount" => x |> FelizNode<'FunBlazorGeneric>.create
    static member onInput fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onKeyUp fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onKeyDown fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onFocus fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onBlur fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onClearClick fn = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearClick" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member onRemoveSelected fn = (Bolero.Html.attr.callback<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>> "OnRemoveSelected" (fun e -> fn e)) |> FelizNode<'FunBlazorGeneric>.create
    static member searchValue (x: System.String) = "SearchValue" => x |> FelizNode<'FunBlazorGeneric>.create
    static member refBack (x: AntDesign.ForwardRef) = "RefBack" => x |> FelizNode<'FunBlazorGeneric>.create
                    
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type formRulesValidator<'FunBlazorGeneric> =
    
    static member create () = [] |> html.blazor<AntDesign.Internal.FormRulesValidator>
    static member create (nodes) = FelizNode<'FunBlazorGeneric>.concat nodes |> html.blazor<AntDesign.Internal.FormRulesValidator>

    static member ref x = attr.ref<AntDesign.Internal.FormRulesValidator> x

                    
            

// =======================================================================================================================

namespace AntDesign

open AntDesign.DslInternals


type IAntComponentBaseNode = interface end
type antComponentBase =
    class
        inherit antComponentBase<IAntComponentBaseNode>
    end
                    

type IAntDomComponentBaseNode = interface end
type antDomComponentBase =
    class
        inherit antDomComponentBase<IAntDomComponentBaseNode>
    end
                    
            
namespace AntDesign.Internal

open AntDesign.DslInternals


type IOverlayTriggerNode = interface end
type overlayTrigger =
    class
        inherit Internal.overlayTrigger<IOverlayTriggerNode>
    end
                    
            
namespace AntDesign

open AntDesign.DslInternals


type IDropdownNode = interface end
type dropdown =
    class
        inherit dropdown<IDropdownNode>
    end
                    

type IDropdownButtonNode = interface end
type dropdownButton =
    class
        inherit dropdownButton<IDropdownButtonNode>
    end
                    

type IPopconfirmNode = interface end
type popconfirm =
    class
        inherit popconfirm<IPopconfirmNode>
    end
                    

type IPopoverNode = interface end
type popover =
    class
        inherit popover<IPopoverNode>
    end
                    

type ITooltipNode = interface end
type tooltip =
    class
        inherit tooltip<ITooltipNode>
    end
                    
            
namespace AntDesign.Internal

open AntDesign.DslInternals


type ISubMenuTriggerNode = interface end
type subMenuTrigger =
    class
        inherit Internal.subMenuTrigger<ISubMenuTriggerNode>
    end
                    

type IPickerPanelBaseNode = interface end
type pickerPanelBase =
    class
        inherit Internal.pickerPanelBase<IPickerPanelBaseNode>
    end
                    
            
namespace AntDesign

open AntDesign.DslInternals


type IDatePickerPanelBaseNode<'TValue> = interface end
type datePickerPanelBase<'TValue> =
    class
        inherit datePickerPanelBase<IDatePickerPanelBaseNode<'TValue>, 'TValue>
    end
                    
            
namespace AntDesign.Internal

open AntDesign.DslInternals


type IDatePickerDatetimePanelNode<'TValue> = interface end
type datePickerDatetimePanel<'TValue> =
    class
        inherit Internal.datePickerDatetimePanel<IDatePickerDatetimePanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerTemplateNode<'TValue> = interface end
type datePickerTemplate<'TValue> =
    class
        inherit Internal.datePickerTemplate<IDatePickerTemplateNode<'TValue>, 'TValue>
    end
                    

type IDatePickerDatePanelNode<'TValue> = interface end
type datePickerDatePanel<'TValue> =
    class
        inherit Internal.datePickerDatePanel<IDatePickerDatePanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerDecadePanelNode<'TValue> = interface end
type datePickerDecadePanel<'TValue> =
    class
        inherit Internal.datePickerDecadePanel<IDatePickerDecadePanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerFooterNode<'TValue> = interface end
type datePickerFooter<'TValue> =
    class
        inherit Internal.datePickerFooter<IDatePickerFooterNode<'TValue>, 'TValue>
    end
                    

type IDatePickerHeaderNode<'TValue> = interface end
type datePickerHeader<'TValue> =
    class
        inherit Internal.datePickerHeader<IDatePickerHeaderNode<'TValue>, 'TValue>
    end
                    

type IDatePickerMonthPanelNode<'TValue> = interface end
type datePickerMonthPanel<'TValue> =
    class
        inherit Internal.datePickerMonthPanel<IDatePickerMonthPanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerQuarterPanelNode<'TValue> = interface end
type datePickerQuarterPanel<'TValue> =
    class
        inherit Internal.datePickerQuarterPanel<IDatePickerQuarterPanelNode<'TValue>, 'TValue>
    end
                    

type IDatePickerYearPanelNode<'TValue> = interface end
type datePickerYearPanel<'TValue> =
    class
        inherit Internal.datePickerYearPanel<IDatePickerYearPanelNode<'TValue>, 'TValue>
    end
                    
            
namespace AntDesign

open AntDesign.DslInternals


type IColNode = interface end
type col =
    class
        inherit col<IColNode>
    end
                    

type IGridColNode = interface end
type gridCol =
    class
        inherit gridCol<IGridColNode>
    end
                    

type IIconNode = interface end
type icon =
    class
        inherit icon<IIconNode>
    end
                    

type IIconFontNode = interface end
type iconFont =
    class
        inherit iconFont<IIconFontNode>
    end
                    

type INotificationBaseNode = interface end
type notificationBase =
    class
        inherit notificationBase<INotificationBaseNode>
    end
                    

type INotificationNode = interface end
type notification =
    class
        inherit notification<INotificationNode>
    end
                    

type INotificationItemNode = interface end
type notificationItem =
    class
        inherit notificationItem<INotificationItemNode>
    end
                    

type IColumnBaseNode = interface end
type columnBase =
    class
        inherit columnBase<IColumnBaseNode>
    end
                    

type IActionColumnNode = interface end
type actionColumn =
    class
        inherit actionColumn<IActionColumnNode>
    end
                    

type IColumnNode<'TData> = interface end
type column<'TData> =
    class
        inherit column<IColumnNode<'TData>, 'TData>
    end
                    

type ISelectionNode = interface end
type selection =
    class
        inherit selection<ISelectionNode>
    end
                    

type ISummaryCellNode = interface end
type summaryCell =
    class
        inherit summaryCell<ISummaryCellNode>
    end
                    

type ITypographyBaseNode = interface end
type typographyBase =
    class
        inherit typographyBase<ITypographyBaseNode>
    end
                    

type ILinkNode = interface end
type link =
    class
        inherit link<ILinkNode>
    end
                    

type IParagraphNode = interface end
type paragraph =
    class
        inherit paragraph<IParagraphNode>
    end
                    

type ITextNode = interface end
type text =
    class
        inherit text<ITextNode>
    end
                    

type ITitleNode = interface end
type title =
    class
        inherit title<ITitleNode>
    end
                    

type IAffixNode = interface end
type affix =
    class
        inherit affix<IAffixNode>
    end
                    

type IAlertNode = interface end
type alert =
    class
        inherit alert<IAlertNode>
    end
                    

type IAnchorNode = interface end
type anchor =
    class
        inherit anchor<IAnchorNode>
    end
                    

type IAnchorLinkNode = interface end
type anchorLink =
    class
        inherit anchorLink<IAnchorLinkNode>
    end
                    

type IAutoCompleteOptGroupNode = interface end
type autoCompleteOptGroup =
    class
        inherit autoCompleteOptGroup<IAutoCompleteOptGroupNode>
    end
                    

type IAutoCompleteOptionNode = interface end
type autoCompleteOption =
    class
        inherit autoCompleteOption<IAutoCompleteOptionNode>
    end
                    

type IAvatarNode = interface end
type avatar =
    class
        inherit avatar<IAvatarNode>
    end
                    

type IAvatarGroupNode = interface end
type avatarGroup =
    class
        inherit avatarGroup<IAvatarGroupNode>
    end
                    

type IBackTopNode = interface end
type backTop =
    class
        inherit backTop<IBackTopNode>
    end
                    

type IBadgeNode = interface end
type badge =
    class
        inherit badge<IBadgeNode>
    end
                    

type IBadgeRibbonNode = interface end
type badgeRibbon =
    class
        inherit badgeRibbon<IBadgeRibbonNode>
    end
                    

type IBreadcrumbNode = interface end
type breadcrumb =
    class
        inherit breadcrumb<IBreadcrumbNode>
    end
                    

type IButtonNode = interface end
type button =
    class
        inherit button<IButtonNode>
    end
                    

type IButtonGroupNode = interface end
type buttonGroup =
    class
        inherit buttonGroup<IButtonGroupNode>
    end
                    

type ICalendarNode = interface end
type calendar =
    class
        inherit calendar<ICalendarNode>
    end
                    

type ICardNode = interface end
type card =
    class
        inherit card<ICardNode>
    end
                    

type ICardActionNode = interface end
type cardAction =
    class
        inherit cardAction<ICardActionNode>
    end
                    

type ICardGridNode = interface end
type cardGrid =
    class
        inherit cardGrid<ICardGridNode>
    end
                    

type ICarouselNode = interface end
type carousel =
    class
        inherit carousel<ICarouselNode>
    end
                    

type ICarouselSlickNode = interface end
type carouselSlick =
    class
        inherit carouselSlick<ICarouselSlickNode>
    end
                    

type ICollapseNode = interface end
type collapse =
    class
        inherit collapse<ICollapseNode>
    end
                    

type IPanelNode = interface end
type panel =
    class
        inherit panel<IPanelNode>
    end
                    

type ICommentNode = interface end
type comment =
    class
        inherit comment<ICommentNode>
    end
                    

type IAntContainerComponentBaseNode = interface end
type antContainerComponentBase =
    class
        inherit antContainerComponentBase<IAntContainerComponentBaseNode>
    end
                    

type IAntInputComponentBaseNode<'TValue> = interface end
type antInputComponentBase<'TValue> =
    class
        inherit antInputComponentBase<IAntInputComponentBaseNode<'TValue>, 'TValue>
    end
                    

type IAntInputBoolComponentBaseNode = interface end
type antInputBoolComponentBase =
    class
        inherit antInputBoolComponentBase<IAntInputBoolComponentBaseNode>
    end
                    

type ICheckboxNode = interface end
type checkbox =
    class
        inherit checkbox<ICheckboxNode>
    end
                    

type ISwitchNode = interface end
type switch =
    class
        inherit switch<ISwitchNode>
    end
                    

type IAutoCompleteNode<'TOption> = interface end
type autoComplete<'TOption> =
    class
        inherit autoComplete<IAutoCompleteNode<'TOption>, 'TOption>
    end
                    

type ICascaderNode = interface end
type cascader =
    class
        inherit cascader<ICascaderNode>
    end
                    

type ICheckboxGroupNode = interface end
type checkboxGroup =
    class
        inherit checkboxGroup<ICheckboxGroupNode>
    end
                    

type IDatePickerBaseNode<'TValue> = interface end
type datePickerBase<'TValue> =
    class
        inherit datePickerBase<IDatePickerBaseNode<'TValue>, 'TValue>
    end
                    

type IDatePickerNode<'TValue> = interface end
type datePicker<'TValue> =
    class
        inherit datePicker<IDatePickerNode<'TValue>, 'TValue>
    end
                    

type IMonthPickerNode<'TValue> = interface end
type monthPicker<'TValue> =
    class
        inherit monthPicker<IMonthPickerNode<'TValue>, 'TValue>
    end
                    

type IQuarterPickerNode<'TValue> = interface end
type quarterPicker<'TValue> =
    class
        inherit quarterPicker<IQuarterPickerNode<'TValue>, 'TValue>
    end
                    

type IWeekPickerNode<'TValue> = interface end
type weekPicker<'TValue> =
    class
        inherit weekPicker<IWeekPickerNode<'TValue>, 'TValue>
    end
                    

type IYearPickerNode<'TValue> = interface end
type yearPicker<'TValue> =
    class
        inherit yearPicker<IYearPickerNode<'TValue>, 'TValue>
    end
                    

type ITimePickerNode<'TValue> = interface end
type timePicker<'TValue> =
    class
        inherit timePicker<ITimePickerNode<'TValue>, 'TValue>
    end
                    

type IRangePickerNode<'TValue> = interface end
type rangePicker<'TValue> =
    class
        inherit rangePicker<IRangePickerNode<'TValue>, 'TValue>
    end
                    

type IInputNumberNode<'TValue> = interface end
type inputNumber<'TValue> =
    class
        inherit inputNumber<IInputNumberNode<'TValue>, 'TValue>
    end
                    

type IInputNode<'TValue> = interface end
type input<'TValue> =
    class
        inherit input<IInputNode<'TValue>, 'TValue>
    end
                    

type ISearchNode = interface end
type search =
    class
        inherit search<ISearchNode>
    end
                    

type IAutoCompleteSearchNode = interface end
type autoCompleteSearch =
    class
        inherit autoCompleteSearch<IAutoCompleteSearchNode>
    end
                    

type IAutoCompleteInputNode<'TValue> = interface end
type autoCompleteInput<'TValue> =
    class
        inherit autoCompleteInput<IAutoCompleteInputNode<'TValue>, 'TValue>
    end
                    

type IInputPasswordNode = interface end
type inputPassword =
    class
        inherit inputPassword<IInputPasswordNode>
    end
                    

type ITextAreaNode = interface end
type textArea =
    class
        inherit textArea<ITextAreaNode>
    end
                    

type IRadioGroupNode<'TValue> = interface end
type radioGroup<'TValue> =
    class
        inherit radioGroup<IRadioGroupNode<'TValue>, 'TValue>
    end
                    

type IEnumRadioGroupNode<'TEnum> = interface end
type enumRadioGroup<'TEnum> =
    class
        inherit enumRadioGroup<IEnumRadioGroupNode<'TEnum>, 'TEnum>
    end
                    

type ISelectBaseNode<'TItemValue, 'TItem> = interface end
type selectBase<'TItemValue, 'TItem> =
    class
        inherit selectBase<ISelectBaseNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    

type ISelectNode<'TItemValue, 'TItem> = interface end
type select'<'TItemValue, 'TItem> =
    class
        inherit select'<ISelectNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    

type IEnumSelectNode<'TEnum> = interface end
type enumSelect<'TEnum> =
    class
        inherit enumSelect<IEnumSelectNode<'TEnum>, 'TEnum>
    end
                    

type ISimpleSelectNode = interface end
type simpleSelect =
    class
        inherit simpleSelect<ISimpleSelectNode>
    end
                    

type ITreeSelectNode<'TItem> = interface end
type treeSelect<'TItem when 'TItem : not struct> =
    class
        inherit treeSelect<ITreeSelectNode<'TItem>, 'TItem>
    end
                    

type ISimpleTreeSelectNode<'TItem> = interface end
type simpleTreeSelect<'TItem when 'TItem : not struct> =
    class
        inherit simpleTreeSelect<ISimpleTreeSelectNode<'TItem>, 'TItem>
    end
                    

type ISliderNode<'TValue> = interface end
type slider<'TValue> =
    class
        inherit slider<ISliderNode<'TValue>, 'TValue>
    end
                    

type IDescriptionsNode = interface end
type descriptions =
    class
        inherit descriptions<IDescriptionsNode>
    end
                    

type IDescriptionsItemNode = interface end
type descriptionsItem =
    class
        inherit descriptionsItem<IDescriptionsItemNode>
    end
                    

type IDividerNode = interface end
type divider =
    class
        inherit divider<IDividerNode>
    end
                    

type IDrawerNode = interface end
type drawer =
    class
        inherit drawer<IDrawerNode>
    end
                    

type IDrawerContainerNode = interface end
type drawerContainer =
    class
        inherit drawerContainer<IDrawerContainerNode>
    end
                    

type IEmptyNode = interface end
type empty =
    class
        inherit empty<IEmptyNode>
    end
                    

type IFormNode<'TModel> = interface end
type form<'TModel> =
    class
        inherit form<IFormNode<'TModel>, 'TModel>
    end
                    

type IFormItemNode = interface end
type formItem =
    class
        inherit formItem<IFormItemNode>
    end
                    

type IRowNode = interface end
type row =
    class
        inherit row<IRowNode>
    end
                    

type IImageNode = interface end
type image =
    class
        inherit image<IImageNode>
    end
                    

type IImagePreviewContainerNode = interface end
type imagePreviewContainer =
    class
        inherit imagePreviewContainer<IImagePreviewContainerNode>
    end
                    

type IInputGroupNode = interface end
type inputGroup =
    class
        inherit inputGroup<IInputGroupNode>
    end
                    

type ISiderNode = interface end
type sider =
    class
        inherit sider<ISiderNode>
    end
                    

type IAntListNode<'TItem> = interface end
type antList<'TItem> =
    class
        inherit antList<IAntListNode<'TItem>, 'TItem>
    end
                    

type IListItemNode = interface end
type listItem =
    class
        inherit listItem<IListItemNode>
    end
                    

type IListItemMetaNode = interface end
type listItemMeta =
    class
        inherit listItemMeta<IListItemMetaNode>
    end
                    

type IMentionsNode = interface end
type mentions =
    class
        inherit mentions<IMentionsNode>
    end
                    

type IMentionsOptionNode = interface end
type mentionsOption =
    class
        inherit mentionsOption<IMentionsOptionNode>
    end
                    

type IMenuNode = interface end
type menu =
    class
        inherit menu<IMenuNode>
    end
                    

type IMenuItemNode = interface end
type menuItem =
    class
        inherit menuItem<IMenuItemNode>
    end
                    

type IMenuItemGroupNode = interface end
type menuItemGroup =
    class
        inherit menuItemGroup<IMenuItemGroupNode>
    end
                    

type IMenuLinkNode = interface end
type menuLink =
    class
        inherit menuLink<IMenuLinkNode>
    end
                    

type ISubMenuNode = interface end
type subMenu =
    class
        inherit subMenu<ISubMenuNode>
    end
                    

type IMessageNode = interface end
type message =
    class
        inherit message<IMessageNode>
    end
                    

type IMessageItemNode = interface end
type messageItem =
    class
        inherit messageItem<IMessageItemNode>
    end
                    

type IComfirmContainerNode = interface end
type comfirmContainer =
    class
        inherit comfirmContainer<IComfirmContainerNode>
    end
                    

type IConfirmNode = interface end
type confirm =
    class
        inherit confirm<IConfirmNode>
    end
                    

type IDialogNode = interface end
type dialog =
    class
        inherit dialog<IDialogNode>
    end
                    

type IDialogWrapperNode = interface end
type dialogWrapper =
    class
        inherit dialogWrapper<IDialogWrapperNode>
    end
                    

type IModalNode = interface end
type modal =
    class
        inherit modal<IModalNode>
    end
                    

type IModalContainerNode = interface end
type modalContainer =
    class
        inherit modalContainer<IModalContainerNode>
    end
                    

type IModalFooterNode = interface end
type modalFooter =
    class
        inherit modalFooter<IModalFooterNode>
    end
                    

type IPageHeaderNode = interface end
type pageHeader =
    class
        inherit pageHeader<IPageHeaderNode>
    end
                    

type IPaginationNode = interface end
type pagination =
    class
        inherit pagination<IPaginationNode>
    end
                    

type IPaginationOptionsNode = interface end
type paginationOptions =
    class
        inherit paginationOptions<IPaginationOptionsNode>
    end
                    

type IProgressNode = interface end
type progress =
    class
        inherit progress<IProgressNode>
    end
                    

type IRadioNode<'TValue> = interface end
type radio<'TValue> =
    class
        inherit radio<IRadioNode<'TValue>, 'TValue>
    end
                    

type IRateNode = interface end
type rate =
    class
        inherit rate<IRateNode>
    end
                    

type IRateItemNode = interface end
type rateItem =
    class
        inherit rateItem<IRateItemNode>
    end
                    

type IResultNode = interface end
type result =
    class
        inherit result<IResultNode>
    end
                    

type ISelectOptionNode<'TItemValue, 'TItem> = interface end
type selectOption<'TItemValue, 'TItem> =
    class
        inherit selectOption<ISelectOptionNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    

type ISimpleSelectOptionNode = interface end
type simpleSelectOption =
    class
        inherit simpleSelectOption<ISimpleSelectOptionNode>
    end
                    

type ISkeletonNode = interface end
type skeleton =
    class
        inherit skeleton<ISkeletonNode>
    end
                    

type ISkeletonElementNode = interface end
type skeletonElement =
    class
        inherit skeletonElement<ISkeletonElementNode>
    end
                    

type ISpaceNode = interface end
type space =
    class
        inherit space<ISpaceNode>
    end
                    

type ISpaceItemNode = interface end
type spaceItem =
    class
        inherit spaceItem<ISpaceItemNode>
    end
                    

type ISpinNode = interface end
type spin =
    class
        inherit spin<ISpinNode>
    end
                    

type IStatisticComponentBaseNode<'T> = interface end
type statisticComponentBase<'T> =
    class
        inherit statisticComponentBase<IStatisticComponentBaseNode<'T>, 'T>
    end
                    

type ICountDownNode = interface end
type countDown =
    class
        inherit countDown<ICountDownNode>
    end
                    

type IStatisticNode<'TValue> = interface end
type statistic<'TValue> =
    class
        inherit statistic<IStatisticNode<'TValue>, 'TValue>
    end
                    

type IStepNode = interface end
type step =
    class
        inherit step<IStepNode>
    end
                    

type IStepsNode = interface end
type steps =
    class
        inherit steps<IStepsNode>
    end
                    

type ITableNode<'TItem> = interface end
type table<'TItem> =
    class
        inherit table<ITableNode<'TItem>, 'TItem>
    end
                    

type IReuseTabsNode = interface end
type reuseTabs =
    class
        inherit reuseTabs<IReuseTabsNode>
    end
                    

type ITabPaneNode = interface end
type tabPane =
    class
        inherit tabPane<ITabPaneNode>
    end
                    

type ITabsNode = interface end
type tabs =
    class
        inherit tabs<ITabsNode>
    end
                    

type ITagNode = interface end
type tag =
    class
        inherit tag<ITagNode>
    end
                    

type ITimelineNode = interface end
type timeline =
    class
        inherit timeline<ITimelineNode>
    end
                    

type ITimelineItemNode = interface end
type timelineItem =
    class
        inherit timelineItem<ITimelineItemNode>
    end
                    

type ITransferNode = interface end
type transfer =
    class
        inherit transfer<ITransferNode>
    end
                    

type ITreeNode<'TItem> = interface end
type tree<'TItem> =
    class
        inherit tree<ITreeNode<'TItem>, 'TItem>
    end
                    

type IDirectoryTreeNode<'TItem> = interface end
type directoryTree<'TItem> =
    class
        inherit directoryTree<IDirectoryTreeNode<'TItem>, 'TItem>
    end
                    

type ITreeNodeNode<'TItem> = interface end
type treeNode<'TItem> =
    class
        inherit treeNode<ITreeNodeNode<'TItem>, 'TItem>
    end
                    

type IUploadNode = interface end
type upload =
    class
        inherit upload<IUploadNode>
    end
                    

type IBreadcrumbItemNode = interface end
type breadcrumbItem =
    class
        inherit breadcrumbItem<IBreadcrumbItemNode>
    end
                    

type ICalendarHeaderNode = interface end
type calendarHeader =
    class
        inherit calendarHeader<ICalendarHeaderNode>
    end
                    

type ICardMetaNode = interface end
type cardMeta =
    class
        inherit cardMeta<ICardMetaNode>
    end
                    

type IAntContainerNode = interface end
type antContainer =
    class
        inherit antContainer<IAntContainerNode>
    end
                    

type ITemplateNode = interface end
type template =
    class
        inherit template<ITemplateNode>
    end
                    

type IEmptyDefaultImgNode = interface end
type emptyDefaultImg =
    class
        inherit emptyDefaultImg<IEmptyDefaultImgNode>
    end
                    

type IEmptySimpleImgNode = interface end
type emptySimpleImg =
    class
        inherit emptySimpleImg<IEmptySimpleImgNode>
    end
                    

type IContentNode = interface end
type content =
    class
        inherit content<IContentNode>
    end
                    

type IFooterNode = interface end
type footer =
    class
        inherit footer<IFooterNode>
    end
                    

type IHeaderNode = interface end
type header =
    class
        inherit header<IHeaderNode>
    end
                    

type ILayoutNode = interface end
type layout =
    class
        inherit layout<ILayoutNode>
    end
                    

type IMenuDividerNode = interface end
type menuDivider =
    class
        inherit menuDivider<IMenuDividerNode>
    end
                    

type IPaginationPagerNode = interface end
type paginationPager =
    class
        inherit paginationPager<IPaginationPagerNode>
    end
                    
            
namespace AntDesign.Select.Internal

open AntDesign.DslInternals


type ISelectOptionGroupNode<'TItemValue, 'TItem> = interface end
type selectOptionGroup<'TItemValue, 'TItem> =
    class
        inherit Select.Internal.selectOptionGroup<ISelectOptionGroupNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    
            
namespace AntDesign.Internal

open AntDesign.DslInternals


type ICalendarPanelChooserNode = interface end
type calendarPanelChooser =
    class
        inherit Internal.calendarPanelChooser<ICalendarPanelChooserNode>
    end
                    

type IElementNode = interface end
type element =
    class
        inherit Internal.element<IElementNode>
    end
                    

type IOverlayNode = interface end
type overlay =
    class
        inherit Internal.overlay<IOverlayNode>
    end
                    

type IDatePickerPanelChooserNode<'TValue> = interface end
type datePickerPanelChooser<'TValue> =
    class
        inherit Internal.datePickerPanelChooser<IDatePickerPanelChooserNode<'TValue>, 'TValue>
    end
                    

type IUploadButtonNode = interface end
type uploadButton =
    class
        inherit Internal.uploadButton<IUploadButtonNode>
    end
                    

type IDatePickerInputNode = interface end
type datePickerInput =
    class
        inherit Internal.datePickerInput<IDatePickerInputNode>
    end
                    

type IDropdownGroupButtonNode = interface end
type dropdownGroupButton =
    class
        inherit Internal.dropdownGroupButton<IDropdownGroupButtonNode>
    end
                    

type ITableRowNode<'TItem> = interface end
type tableRow<'TItem> =
    class
        inherit Internal.tableRow<ITableRowNode<'TItem>, 'TItem>
    end
                    
            
namespace AntDesign

open AntDesign.DslInternals


type IConfigProviderNode = interface end
type configProvider =
    class
        inherit configProvider<IConfigProviderNode>
    end
                    

type ITemplateComponentBaseNode<'TComponentOptions> = interface end
type templateComponentBase<'TComponentOptions> =
    class
        inherit templateComponentBase<ITemplateComponentBaseNode<'TComponentOptions>, 'TComponentOptions>
    end
                    

type IFeedbackComponentNode<'TComponentOptions> = interface end
type feedbackComponent<'TComponentOptions> =
    class
        inherit feedbackComponent<IFeedbackComponentNode<'TComponentOptions>, 'TComponentOptions>
    end
                    

type IFeedbackComponentNode<'TComponentOptions, 'TResult> = interface end
type feedbackComponent<'TComponentOptions, 'TResult> =
    class
        inherit feedbackComponent<IFeedbackComponentNode<'TComponentOptions, 'TResult>, 'TComponentOptions, 'TResult>
    end
                    

type IFormProviderNode = interface end
type formProvider =
    class
        inherit formProvider<IFormProviderNode>
    end
                    

type IComponentNode = interface end
type component' =
    class
        inherit component'<IComponentNode>
    end
                    

type IImagePreviewNode = interface end
type imagePreview =
    class
        inherit imagePreview<IImagePreviewNode>
    end
                    

type IImagePreviewGroupNode = interface end
type imagePreviewGroup =
    class
        inherit imagePreviewGroup<IImagePreviewGroupNode>
    end
                    

type ITreeIndentNode<'TItem> = interface end
type treeIndent<'TItem> =
    class
        inherit treeIndent<ITreeIndentNode<'TItem>, 'TItem>
    end
                    

type ITreeNodeCheckboxNode<'TItem> = interface end
type treeNodeCheckbox<'TItem> =
    class
        inherit treeNodeCheckbox<ITreeNodeCheckboxNode<'TItem>, 'TItem>
    end
                    

type ITreeNodeSwitcherNode<'TItem> = interface end
type treeNodeSwitcher<'TItem> =
    class
        inherit treeNodeSwitcher<ITreeNodeSwitcherNode<'TItem>, 'TItem>
    end
                    

type ITreeNodeTitleNode<'TItem> = interface end
type treeNodeTitle<'TItem> =
    class
        inherit treeNodeTitle<ITreeNodeTitleNode<'TItem>, 'TItem>
    end
                    

type ICardLoadingNode = interface end
type cardLoading =
    class
        inherit cardLoading<ICardLoadingNode>
    end
                    

type ISummaryRowNode = interface end
type summaryRow =
    class
        inherit summaryRow<ISummaryRowNode>
    end
                    
            
namespace AntDesign.statistic

open AntDesign.DslInternals


type IStatisticComponentBaseNode<'T> = interface end
type statisticComponentBase<'T> =
    class
        inherit statistic.statisticComponentBase<IStatisticComponentBaseNode<'T>, 'T>
    end
                    
            
namespace AntDesign.Select

open AntDesign.DslInternals


type ILabelTemplateItemNode<'TItemValue, 'TItem> = interface end
type labelTemplateItem<'TItemValue, 'TItem> =
    class
        inherit Select.labelTemplateItem<ILabelTemplateItemNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    
            
namespace AntDesign.Select.Internal

open AntDesign.DslInternals


type ISelectContentNode<'TItemValue, 'TItem> = interface end
type selectContent<'TItemValue, 'TItem> =
    class
        inherit Select.Internal.selectContent<ISelectContentNode<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    end
                    
            
namespace AntDesign.Internal

open AntDesign.DslInternals


type IFormRulesValidatorNode = interface end
type formRulesValidator =
    class
        inherit Internal.formRulesValidator<IFormRulesValidatorNode>
    end
                    
            