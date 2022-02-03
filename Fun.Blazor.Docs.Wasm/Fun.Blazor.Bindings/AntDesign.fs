namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type antComponentBase<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AntComponentBase>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntComponentBase>() { yield! attrs }

    static member refBack (x: AntDesign.ForwardRef) = "RefBack" => x
                    

type antDomComponentBase<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AntDomComponentBase>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntDomComponentBase>() { yield! attrs }

    static member id (x: System.String) = "Id" => x
    static member classes (x: string list) = html.classes x
    static member styles (x: (string * string) seq) = html.styles x
                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type overlayTrigger<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.OverlayTrigger>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.OverlayTrigger>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Internal.OverlayTrigger>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Internal.OverlayTrigger>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Internal.OverlayTrigger>(){ x }
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member hiddenMode (x: System.Boolean) = "HiddenMode" => x
    static member inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x
    static member isButton (x: System.Boolean) = "IsButton" => x
    static member onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member onMaskClick fn = html.callback<unit>("OnMaskClick", fn)
    static member onMouseEnter fn = html.callback<unit>("OnMouseEnter", fn)
    static member onMouseLeave fn = html.callback<unit>("OnMouseLeave", fn)
    static member onOverlayHiding fn = html.callback<System.Boolean>("OnOverlayHiding", fn)
    static member onVisibleChange fn = html.callback<System.Boolean>("OnVisibleChange", fn)
    static member overlay (x: string) = html.renderFragment("Overlay", html.text x)
    static member overlay (node) = html.renderFragment("Overlay", node)
    static member overlay (nodes) = html.renderFragment("Overlay", fragment { yield! nodes })
    static member overlayClassName (x: System.String) = "OverlayClassName" => x
    static member overlayEnterCls (x: System.String) = "OverlayEnterCls" => x
    static member overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x
    static member overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x
    static member overlayStyle (x: System.String) = "OverlayStyle" => x
    static member placement (x: AntDesign.Placement) = "Placement" => x
    static member placementCls (x: System.String) = "PlacementCls" => x
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member trigger (x: AntDesign.Trigger[]) = "Trigger" => x
    static member triggerCls (x: System.String) = "TriggerCls" => x
    static member triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x
    static member unbound (render: AntDesign.ForwardRef -> NodeRenderFragment) = html.renderFragment("Unbound", render)
    static member visible (x: System.Boolean) = "Visible" => x
                    
            
namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type dropdown<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Dropdown>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Dropdown>() { yield! attrs }


                    

type dropdownButton<'FunBlazorGeneric> =
    inherit dropdown<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.DropdownButton>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DropdownButton>() { yield! attrs }

    static member block (x: System.Boolean) = "Block" => x
    static member buttonsRender (fn: _ -> _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "ButtonsRender", box (System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1 x2).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member buttonsClass (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "ButtonsClass" => x
    static member buttonsStyle (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "ButtonsStyle" => x
    static member danger (x: System.Boolean) = "Danger" => x
    static member ghost (x: System.Boolean) = "Ghost" => x
    static member icon (x: System.String) = "Icon" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member size (x: System.String) = "Size" => x
    static member type' (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Type" => x
                    

type popconfirm<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Popconfirm>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Popconfirm>() { yield! attrs }

    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member cancelText (x: System.String) = "CancelText" => x
    static member okText (x: System.String) = "OkText" => x
    static member okType (x: System.String) = "OkType" => x
    static member okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x
    static member cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x
    static member icon (x: System.String) = "Icon" => x
    static member iconTemplate (x: string) = html.renderFragment("IconTemplate", html.text x)
    static member iconTemplate (node) = html.renderFragment("IconTemplate", node)
    static member iconTemplate (nodes) = html.renderFragment("IconTemplate", fragment { yield! nodes })
    static member onCancel fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCancel", fn)
    static member onConfirm fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnConfirm", fn)
    static member arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x
    static member mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x
    static member mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x
                    

type popover<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Popover>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Popover>() { yield! attrs }

    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member content (x: System.String) = "Content" => x
    static member contentTemplate (x: string) = html.renderFragment("ContentTemplate", html.text x)
    static member contentTemplate (node) = html.renderFragment("ContentTemplate", node)
    static member contentTemplate (nodes) = html.renderFragment("ContentTemplate", fragment { yield! nodes })
    static member arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x
    static member mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x
    static member mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x
                    

type tooltip<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Tooltip>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Tooltip>() { yield! attrs }

    static member title (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>) = "Title" => x
    static member arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x
    static member mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x
    static member mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x
                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type subMenuTrigger<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.SubMenuTrigger>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.SubMenuTrigger>() { yield! attrs }

    static member triggerClass (x: System.String) = "TriggerClass" => x
                    

type pickerPanelBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.PickerPanelBase>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.PickerPanelBase>() { yield! attrs }

    static member onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn)
    static member pickerIndex (x: System.Int32) = "PickerIndex" => x
                    
            
namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type datePickerPanelBase<'FunBlazorGeneric, 'TValue> =
    inherit Internal.pickerPanelBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.DatePickerPanelBase<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DatePickerPanelBase<'TValue>>() { yield! attrs }

    static member prefixCls (x: System.String) = "PrefixCls" => x
    static member picker (x: System.String) = "Picker" => x
    static member isRange (x: System.Boolean) = "IsRange" => x
    static member isCalendar (x: System.Boolean) = "IsCalendar" => x
    static member isShowHeader (x: System.Boolean) = "IsShowHeader" => x
    static member isShowTime (x: System.Boolean) = "IsShowTime" => x
    static member locale (x: AntDesign.DatePickerLocale) = "Locale" => x
    static member cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x
    static member closePanel (x: System.Action) = "ClosePanel" => x
    static member changePickerValue (fn) = "ChangePickerValue" => (System.Action<System.DateTime, System.Nullable<System.Int32>>fn)
    static member changeValue (fn) = "ChangeValue" => (System.Action<System.DateTime, System.Int32>fn)
    static member changePickerType (fn) = "ChangePickerType" => (System.Action<System.String, System.Int32>fn)
    static member getIndexPickerValue (fn) = "GetIndexPickerValue" => (System.Func<System.Int32, System.DateTime>fn)
    static member getIndexValue (fn) = "GetIndexValue" => (System.Func<System.Int32, System.Nullable<System.DateTime>>fn)
    static member disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn)
    static member dateRender (fn: _ -> _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DateRender", box (System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1 x2).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member monthCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "MonthCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member calendarDateRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "CalendarDateRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member calendarMonthCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "CalendarMonthCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member renderExtraFooter (x: string) = html.renderFragment("RenderExtraFooter", html.text x)
    static member renderExtraFooter (node) = html.renderFragment("RenderExtraFooter", node)
    static member renderExtraFooter (nodes) = html.renderFragment("RenderExtraFooter", fragment { yield! nodes })
                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type datePickerDatetimePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>() { yield! attrs }

    static member showToday (x: System.Boolean) = "ShowToday" => x
    static member showTimeFormat (x: System.String) = "ShowTimeFormat" => x
    static member format (x: System.String) = "Format" => x
    static member disabledHours (fn) = "DisabledHours" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member disabledMinutes (fn) = "DisabledMinutes" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member disabledSeconds (fn) = "DisabledSeconds" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member disabledTime (fn) = "DisabledTime" => (System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>fn)
    static member onOkClick fn = html.callback<unit>("OnOkClick", fn)
                    

type datePickerTemplate<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerTemplate<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerTemplate<'TValue>>() { yield! attrs }

    static member renderPickerHeader (x: string) = html.renderFragment("RenderPickerHeader", html.text x)
    static member renderPickerHeader (node) = html.renderFragment("RenderPickerHeader", node)
    static member renderPickerHeader (nodes) = html.renderFragment("RenderPickerHeader", fragment { yield! nodes })
    static member renderTableHeader (x: string) = html.renderFragment("RenderTableHeader", html.text x)
    static member renderTableHeader (node) = html.renderFragment("RenderTableHeader", node)
    static member renderTableHeader (nodes) = html.renderFragment("RenderTableHeader", fragment { yield! nodes })
    static member renderFirstCol (render: System.DateTime -> NodeRenderFragment) = html.renderFragment("RenderFirstCol", render)
    static member renderColValue (render: System.DateTime -> NodeRenderFragment) = html.renderFragment("RenderColValue", render)
    static member renderLastCol (render: System.DateTime -> NodeRenderFragment) = html.renderFragment("RenderLastCol", render)
    static member viewStartDate (x: System.DateTime) = "ViewStartDate" => x
    static member getColTitle (fn) = "GetColTitle" => (System.Func<System.DateTime, System.String>fn)
    static member getRowClass (fn) = "GetRowClass" => (System.Func<System.DateTime, System.String>fn)
    static member getNextColValue (fn) = "GetNextColValue" => (System.Func<System.DateTime, System.DateTime>fn)
    static member isInView (fn) = "IsInView" => (System.Func<System.DateTime, System.Boolean>fn)
    static member isToday (fn) = "IsToday" => (System.Func<System.DateTime, System.Boolean>fn)
    static member isSelected (fn) = "IsSelected" => (System.Func<System.DateTime, System.Boolean>fn)
    static member onRowSelect (fn) = "OnRowSelect" => (System.Action<System.DateTime>fn)
    static member onValueSelect (fn) = "OnValueSelect" => (System.Action<System.DateTime>fn)
    static member showFooter (x: System.Boolean) = "ShowFooter" => x
    static member maxRow (x: System.Int32) = "MaxRow" => x
    static member maxCol (x: System.Int32) = "MaxCol" => x
    static member skipDays (x: System.Int32) = "SkipDays" => x
                    

type datePickerDatePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerDatePanel<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerDatePanel<'TValue>>() { yield! attrs }

    static member isWeek (x: System.Boolean) = "IsWeek" => x
    static member showToday (x: System.Boolean) = "ShowToday" => x
                    

type datePickerDecadePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerDecadePanel<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerDecadePanel<'TValue>>() { yield! attrs }


                    

type datePickerFooter<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerFooter<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerFooter<'TValue>>() { yield! attrs }


                    

type datePickerHeader<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerHeader<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerHeader<'TValue>>() { yield! attrs }

    static member superChangeDateInterval (x: System.Int32) = "SuperChangeDateInterval" => x
    static member changeDateInterval (x: System.Int32) = "ChangeDateInterval" => x
    static member showSuperPreChange (x: System.Boolean) = "ShowSuperPreChange" => x
    static member showPreChange (x: System.Boolean) = "ShowPreChange" => x
    static member showNextChange (x: System.Boolean) = "ShowNextChange" => x
    static member showSuperNextChange (x: System.Boolean) = "ShowSuperNextChange" => x
                    

type datePickerMonthPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerMonthPanel<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerMonthPanel<'TValue>>() { yield! attrs }


                    

type datePickerQuarterPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>() { yield! attrs }


                    

type datePickerYearPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerYearPanel<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerYearPanel<'TValue>>() { yield! attrs }


                    
            
namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type col<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Col>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Col>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Col>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Col>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Col>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member flex (x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x
    static member span (x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x
    static member order (x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x
    static member offset (x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x
    static member push (x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x
    static member pull (x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x
    static member xs (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x
    static member sm (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x
    static member md (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x
    static member lg (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x
    static member xl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x
    static member xxl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x
                    

type gridCol<'FunBlazorGeneric> =
    inherit col<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.GridCol>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.GridCol>() { yield! attrs }


                    

type icon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Icon>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Icon>() { yield! attrs }

    static member spin (x: System.Boolean) = "Spin" => x
    static member rotate (x: System.Int32) = "Rotate" => x
    static member type' (x: System.String) = "Type" => x
    static member theme (x: System.String) = "Theme" => x
    static member twotoneColor (x: System.String) = "TwotoneColor" => x
    static member iconFont (x: System.String) = "IconFont" => x
    static member width (x: System.String) = "Width" => x
    static member height (x: System.String) = "Height" => x
    static member fill (x: System.String) = "Fill" => x
    static member tabIndex (x: System.String) = "TabIndex" => x
    static member stopPropagation (x: System.Boolean) = "StopPropagation" => x
    static member onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member component' (x: string) = html.renderFragment("Component", html.text x)
    static member component' (node) = html.renderFragment("Component", node)
    static member component' (nodes) = html.renderFragment("Component", fragment { yield! nodes })
                    

type iconFont<'FunBlazorGeneric> =
    inherit icon<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.IconFont>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.IconFont>() { yield! attrs }


                    

type notificationBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.NotificationBase>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.NotificationBase>() { yield! attrs }


                    

type notification<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Notification>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Notification>() { yield! attrs }


                    

type notificationItem<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.NotificationItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.NotificationItem>() { yield! attrs }

    static member config (x: AntDesign.NotificationConfig) = "Config" => x
    static member onClose (fn) = "OnClose" => (System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>fn)
                    

type columnBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ColumnBase>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ColumnBase>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.ColumnBase>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.ColumnBase>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.ColumnBase>(){ x }
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member width (x: System.String) = "Width" => x
    static member headerStyle (x: System.String) = "HeaderStyle" => x
    static member rowSpan (x: System.Int32) = "RowSpan" => x
    static member colSpan (x: System.Int32) = "ColSpan" => x
    static member headerColSpan (x: System.Int32) = "HeaderColSpan" => x
    static member fixed' (x: System.String) = "Fixed" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member ellipsis (x: System.Boolean) = "Ellipsis" => x
    static member hidden (x: System.Boolean) = "Hidden" => x
    static member align (x: AntDesign.ColumnAlign) = "Align" => x
    static member cellRender (render: AntDesign.TableModels.CellData -> NodeRenderFragment) = html.renderFragment("CellRender", render)
                    

type actionColumn<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ActionColumn>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ActionColumn>() { yield! attrs }


                    

type column<'FunBlazorGeneric, 'TData> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Column<'TData>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Column<'TData>>() { yield! attrs }

    static member fieldChanged fn = html.callback<'TData>("FieldChanged", fn)
    static member fieldExpression (x: System.Linq.Expressions.Expression<System.Func<'TData>>) = "FieldExpression" => x
    static member field (x: 'TData) = "Field" => x
    static member field' (value: IStore<'TData>) = html.bind("Field", value)
    static member field' (value: cval<'TData>) = html.bind("Field", value)
    static member field' (valueFn: 'TData * ('TData -> unit)) = html.bind("Field", valueFn)
    static member dataIndex (x: System.String) = "DataIndex" => x
    static member format (x: System.String) = "Format" => x
    static member sortable (x: System.Boolean) = "Sortable" => x
    static member sorterCompare (fn) = "SorterCompare" => (System.Func<'TData, 'TData, System.Int32>fn)
    static member sorterMultiple (x: System.Int32) = "SorterMultiple" => x
    static member showSorterTooltip (x: System.Boolean) = "ShowSorterTooltip" => x
    static member sortDirections (x: AntDesign.SortDirection[]) = "SortDirections" => x
    static member defaultSortOrder (x: AntDesign.SortDirection) = "DefaultSortOrder" => x
    static member onCell (fn) = "OnCell" => (System.Func<AntDesign.TableModels.CellData, System.Collections.Generic.Dictionary<System.String, System.Object>>fn)
    static member onHeaderCell (fn) = "OnHeaderCell" => (System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>fn)
    static member filterable (x: System.Boolean) = "Filterable" => x
    static member filters (x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = "Filters" => x
    static member filterMultiple (x: System.Boolean) = "FilterMultiple" => x
    static member onFilter (x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = "OnFilter" => x
                    

type selection<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Selection>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Selection>() { yield! attrs }

    static member type' (x: System.String) = "Type" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member key (x: System.String) = "Key" => x
    static member checkStrictly (x: System.Boolean) = "CheckStrictly" => x
                    

type summaryCell<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SummaryCell>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SummaryCell>() { yield! attrs }


                    

type typographyBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TypographyBase>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TypographyBase>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.TypographyBase>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.TypographyBase>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.TypographyBase>(){ x }
    static member copyable (x: System.Boolean) = "Copyable" => x
    static member copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x
    static member delete (x: System.Boolean) = "Delete" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member editable (x: System.Boolean) = "Editable" => x
    static member editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x
    static member ellipsis (x: System.Boolean) = "Ellipsis" => x
    static member ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x
    static member mark (x: System.Boolean) = "Mark" => x
    static member underline (x: System.Boolean) = "Underline" => x
    static member strong (x: System.Boolean) = "Strong" => x
    static member onChange (x: System.Action) = "OnChange" => x
    static member type' (x: System.String) = "Type" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type link<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Link>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Link>() { yield! attrs }

    static member code (x: System.Boolean) = "Code" => x
    static member keyboard (x: System.Boolean) = "Keyboard" => x
                    

type paragraph<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Paragraph>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Paragraph>() { yield! attrs }

    static member code (x: System.Boolean) = "Code" => x
    static member keyboard (x: System.Boolean) = "Keyboard" => x
                    

type text<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Text>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Text>() { yield! attrs }

    static member code (x: System.Boolean) = "Code" => x
    static member keyboard (x: System.Boolean) = "Keyboard" => x
                    

type title<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Title>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Title>() { yield! attrs }

    static member level (x: System.Int32) = "Level" => x
                    

type affix<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Affix>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Affix>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Affix>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Affix>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Affix>(){ x }
    static member offsetBottom (x: System.Int32) = "OffsetBottom" => x
    static member offsetTop (x: System.Int32) = "OffsetTop" => x
    static member targetSelector (x: System.String) = "TargetSelector" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member onChange fn = html.callback<System.Boolean>("OnChange", fn)
                    

type alert<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Alert>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Alert>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Alert>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Alert>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Alert>(){ x }
    static member afterClose fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("AfterClose", fn)
    static member banner (x: System.Boolean) = "Banner" => x
    static member closable (x: System.Boolean) = "Closable" => x
    static member closeText (x: System.String) = "CloseText" => x
    static member description (x: System.String) = "Description" => x
    static member icon (x: string) = html.renderFragment("Icon", html.text x)
    static member icon (node) = html.renderFragment("Icon", node)
    static member icon (nodes) = html.renderFragment("Icon", fragment { yield! nodes })
    static member message (x: System.String) = "Message" => x
    static member messageTemplate (x: string) = html.renderFragment("MessageTemplate", html.text x)
    static member messageTemplate (node) = html.renderFragment("MessageTemplate", node)
    static member messageTemplate (nodes) = html.renderFragment("MessageTemplate", fragment { yield! nodes })
    static member showIcon (x: System.Nullable<System.Boolean>) = "ShowIcon" => x
    static member type' (x: System.String) = "Type" => x
    static member onClose fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClose", fn)
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type anchor<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Anchor>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Anchor>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Anchor>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Anchor>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Anchor>(){ x }
    static member key (x: System.String) = "Key" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member affix (x: System.Boolean) = "Affix" => x
    static member bounds (x: System.Int32) = "Bounds" => x
    static member getContainer (fn) = "GetContainer" => (System.Func<System.String>fn)
    static member offsetBottom (x: System.Nullable<System.Int32>) = "OffsetBottom" => x
    static member offsetTop (x: System.Nullable<System.Int32>) = "OffsetTop" => x
    static member showInkInFixed (x: System.Boolean) = "ShowInkInFixed" => x
    static member onClick fn = html.callback<System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink>>("OnClick", fn)
    static member getCurrentAnchor (fn) = "GetCurrentAnchor" => (System.Func<System.String>fn)
    static member targetOffset (x: System.Nullable<System.Int32>) = "TargetOffset" => x
    static member onChange fn = html.callback<System.String>("OnChange", fn)
                    

type anchorLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AnchorLink>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AnchorLink>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.AnchorLink>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.AnchorLink>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.AnchorLink>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member href (x: System.String) = "Href" => x
    static member title (x: System.String) = "Title" => x
    static member target (x: System.String) = "Target" => x
                    

type autoCompleteOptGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AutoCompleteOptGroup>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteOptGroup>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.AutoCompleteOptGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.AutoCompleteOptGroup>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.AutoCompleteOptGroup>(){ x }
    static member label (x: System.String) = "Label" => x
    static member labelFragment (x: string) = html.renderFragment("LabelFragment", html.text x)
    static member labelFragment (node) = html.renderFragment("LabelFragment", node)
    static member labelFragment (nodes) = html.renderFragment("LabelFragment", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type autoCompleteOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AutoCompleteOption>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteOption>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.AutoCompleteOption>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.AutoCompleteOption>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.AutoCompleteOption>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member value (x: System.Object) = "Value" => x
    static member label (x: System.String) = "Label" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member autoComplete (x: AntDesign.IAutoCompleteRef) = "AutoComplete" => x
                    

type avatar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Avatar>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Avatar>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Avatar>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Avatar>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Avatar>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member shape (x: System.String) = "Shape" => x
    static member size (x: System.String) = "Size" => x
    static member text (x: System.String) = "Text" => x
    static member src (x: System.String) = "Src" => x
    static member srcSet (x: System.String) = "SrcSet" => x
    static member alt (x: System.String) = "Alt" => x
    static member icon (x: System.String) = "Icon" => x
    static member onError fn = html.callback<Microsoft.AspNetCore.Components.Web.ErrorEventArgs>("OnError", fn)
                    

type avatarGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AvatarGroup>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AvatarGroup>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.AvatarGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.AvatarGroup>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.AvatarGroup>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member maxCount (x: System.Int32) = "MaxCount" => x
    static member maxStyle (x: System.String) = "MaxStyle" => x
    static member maxPopoverPlacement (x: AntDesign.Placement) = "MaxPopoverPlacement" => x
                    

type backTop<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.BackTop>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.BackTop>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.BackTop>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.BackTop>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.BackTop>(){ x }
    static member icon (x: System.String) = "Icon" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member visibilityHeight (x: System.Double) = "VisibilityHeight" => x
    static member targetSelector (x: System.String) = "TargetSelector" => x
    static member onClick fn = html.callback<unit>("OnClick", fn)
                    

type badge<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Badge>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Badge>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Badge>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Badge>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Badge>(){ x }
    static member color (x: System.String) = "Color" => x
    static member presetColor (x: System.Nullable<AntDesign.PresetColor>) = "PresetColor" => x
    static member count (x: System.Nullable<System.Int32>) = "Count" => x
    static member countTemplate (x: string) = html.renderFragment("CountTemplate", html.text x)
    static member countTemplate (node) = html.renderFragment("CountTemplate", node)
    static member countTemplate (nodes) = html.renderFragment("CountTemplate", fragment { yield! nodes })
    static member dot (x: System.Boolean) = "Dot" => x
    static member offset (x: System.ValueTuple<System.Int32, System.Int32>) = "Offset" => x
    static member overflowCount (x: System.Int32) = "OverflowCount" => x
    static member showZero (x: System.Boolean) = "ShowZero" => x
    static member status (x: System.String) = "Status" => x
    static member text (x: System.String) = "Text" => x
    static member title (x: System.String) = "Title" => x
    static member size (x: System.String) = "Size" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type badgeRibbon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.BadgeRibbon>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.BadgeRibbon>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.BadgeRibbon>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.BadgeRibbon>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.BadgeRibbon>(){ x }
    static member color (x: System.String) = "Color" => x
    static member text (x: System.String) = "Text" => x
    static member textTemplate (x: string) = html.renderFragment("TextTemplate", html.text x)
    static member textTemplate (node) = html.renderFragment("TextTemplate", node)
    static member textTemplate (nodes) = html.renderFragment("TextTemplate", fragment { yield! nodes })
    static member placement (x: System.String) = "Placement" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type breadcrumb<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Breadcrumb>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Breadcrumb>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Breadcrumb>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Breadcrumb>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Breadcrumb>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member autoGenerate (x: System.Boolean) = "AutoGenerate" => x
    static member separator (x: System.String) = "Separator" => x
    static member routeLabel (x: System.String) = "RouteLabel" => x
                    

type button<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Button>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Button>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Button>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Button>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Button>(){ x }
    static member color (x: AntDesign.Color) = "Color" => x
    static member block (x: System.Boolean) = "Block" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member danger (x: System.Boolean) = "Danger" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member ghost (x: System.Boolean) = "Ghost" => x
    static member htmlType (x: System.String) = "HtmlType" => x
    static member icon (x: System.String) = "Icon" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x
    static member shape (x: System.String) = "Shape" => x
    static member size (x: System.String) = "Size" => x
    static member type' (x: System.String) = "Type" => x
    static member noSpanWrap (x: System.Boolean) = "NoSpanWrap" => x
                    

type buttonGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ButtonGroup>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ButtonGroup>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.ButtonGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.ButtonGroup>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.ButtonGroup>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member size (x: System.String) = "Size" => x
                    

type calendar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Calendar>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Calendar>() { yield! attrs }

    static member value (x: System.DateTime) = "Value" => x
    static member defaultValue (x: System.DateTime) = "DefaultValue" => x
    static member validRange (x: System.DateTime[]) = "ValidRange" => x
    static member mode (x: System.String) = "Mode" => x
    static member fullScreen (x: System.Boolean) = "FullScreen" => x
    static member onSelect fn = html.callback<System.DateTime>("OnSelect", fn)
    static member onChange fn = html.callback<System.DateTime>("OnChange", fn)
    static member headerRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "HeaderRender", box (System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member dateCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DateCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member dateFullCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DateFullCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member monthCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "MonthCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member monthFullCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "MonthFullCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member onPanelChange (fn) = "OnPanelChange" => (System.Action<System.DateTime, System.String>fn)
    static member disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn)
    static member locale (x: AntDesign.DatePickerLocale) = "Locale" => x
    static member cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x
                    

type card<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Card>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Card>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Card>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Card>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Card>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member body (x: string) = html.renderFragment("Body", html.text x)
    static member body (node) = html.renderFragment("Body", node)
    static member body (nodes) = html.renderFragment("Body", fragment { yield! nodes })
    static member actionTemplate (x: string) = html.renderFragment("ActionTemplate", html.text x)
    static member actionTemplate (node) = html.renderFragment("ActionTemplate", node)
    static member actionTemplate (nodes) = html.renderFragment("ActionTemplate", fragment { yield! nodes })
    static member bordered (x: System.Boolean) = "Bordered" => x
    static member hoverable (x: System.Boolean) = "Hoverable" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member bodyStyle (x: System.String) = "BodyStyle" => x
    static member cover (x: string) = html.renderFragment("Cover", html.text x)
    static member cover (node) = html.renderFragment("Cover", node)
    static member cover (nodes) = html.renderFragment("Cover", fragment { yield! nodes })
    static member actions (x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x
    static member type' (x: System.String) = "Type" => x
    static member size (x: System.String) = "Size" => x
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member extra (x: string) = html.renderFragment("Extra", html.text x)
    static member extra (node) = html.renderFragment("Extra", node)
    static member extra (nodes) = html.renderFragment("Extra", fragment { yield! nodes })
    static member cardTabs (x: string) = html.renderFragment("CardTabs", html.text x)
    static member cardTabs (node) = html.renderFragment("CardTabs", node)
    static member cardTabs (nodes) = html.renderFragment("CardTabs", fragment { yield! nodes })
                    

type cardAction<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.CardAction>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CardAction>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.CardAction>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.CardAction>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.CardAction>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type cardGrid<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.CardGrid>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CardGrid>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.CardGrid>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.CardGrid>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.CardGrid>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member hoverable (x: System.Boolean) = "Hoverable" => x
                    

type carousel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Carousel>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Carousel>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Carousel>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Carousel>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Carousel>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member dotPosition (x: System.String) = "DotPosition" => x
    static member autoplay (x: System.TimeSpan) = "Autoplay" => x
    static member effect (x: System.String) = "Effect" => x
                    

type carouselSlick<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.CarouselSlick>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CarouselSlick>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.CarouselSlick>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.CarouselSlick>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.CarouselSlick>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type collapse<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Collapse>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Collapse>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Collapse>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Collapse>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Collapse>(){ x }
    static member accordion (x: System.Boolean) = "Accordion" => x
    static member bordered (x: System.Boolean) = "Bordered" => x
    static member expandIconPosition (x: System.String) = "ExpandIconPosition" => x
    static member defaultActiveKey (x: System.String[]) = "DefaultActiveKey" => x
    static member onChange fn = html.callback<System.String[]>("OnChange", fn)
    static member expandIcon (x: System.String) = "ExpandIcon" => x
    static member expandIconTemplate (render: System.Boolean -> NodeRenderFragment) = html.renderFragment("ExpandIconTemplate", render)
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type panel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Panel>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Panel>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Panel>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Panel>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Panel>(){ x }
    static member active (x: System.Boolean) = "Active" => x
    static member key (x: System.String) = "Key" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member showArrow (x: System.Boolean) = "ShowArrow" => x
    static member extra (x: System.String) = "Extra" => x
    static member extraTemplate (x: string) = html.renderFragment("ExtraTemplate", html.text x)
    static member extraTemplate (node) = html.renderFragment("ExtraTemplate", node)
    static member extraTemplate (nodes) = html.renderFragment("ExtraTemplate", fragment { yield! nodes })
    static member header (x: System.String) = "Header" => x
    static member headerTemplate (x: string) = html.renderFragment("HeaderTemplate", html.text x)
    static member headerTemplate (node) = html.renderFragment("HeaderTemplate", node)
    static member headerTemplate (nodes) = html.renderFragment("HeaderTemplate", fragment { yield! nodes })
    static member onActiveChange fn = html.callback<System.Boolean>("OnActiveChange", fn)
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type comment<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Comment>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Comment>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Comment>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Comment>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Comment>(){ x }
    static member author (x: System.String) = "Author" => x
    static member authorTemplate (x: string) = html.renderFragment("AuthorTemplate", html.text x)
    static member authorTemplate (node) = html.renderFragment("AuthorTemplate", node)
    static member authorTemplate (nodes) = html.renderFragment("AuthorTemplate", fragment { yield! nodes })
    static member avatar (x: System.String) = "Avatar" => x
    static member avatarTemplate (x: string) = html.renderFragment("AvatarTemplate", html.text x)
    static member avatarTemplate (node) = html.renderFragment("AvatarTemplate", node)
    static member avatarTemplate (nodes) = html.renderFragment("AvatarTemplate", fragment { yield! nodes })
    static member content (x: System.String) = "Content" => x
    static member contentTemplate (x: string) = html.renderFragment("ContentTemplate", html.text x)
    static member contentTemplate (node) = html.renderFragment("ContentTemplate", node)
    static member contentTemplate (nodes) = html.renderFragment("ContentTemplate", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member datetime (x: System.String) = "Datetime" => x
    static member datetimeTemplate (x: string) = html.renderFragment("DatetimeTemplate", html.text x)
    static member datetimeTemplate (node) = html.renderFragment("DatetimeTemplate", node)
    static member datetimeTemplate (nodes) = html.renderFragment("DatetimeTemplate", fragment { yield! nodes })
    static member actions (x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x
                    

type antContainerComponentBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AntContainerComponentBase>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntContainerComponentBase>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.AntContainerComponentBase>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.AntContainerComponentBase>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.AntContainerComponentBase>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member tag (x: System.String) = "Tag" => x
                    

type antInputComponentBase<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AntInputComponentBase<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntInputComponentBase<'TValue>>() { yield! attrs }

    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
    static member value (x: 'TValue) = "Value" => x
    static member value' (value: IStore<'TValue>) = html.bind("Value", value)
    static member value' (value: cval<'TValue>) = html.bind("Value", value)
    static member value' (valueFn: 'TValue * ('TValue -> unit)) = html.bind("Value", valueFn)
    static member valueChanged fn = html.callback<'TValue>("ValueChanged", fn)
    static member valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x
    static member valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x
    static member size (x: System.String) = "Size" => x
    static member cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x
                    

type antInputBoolComponentBase<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.Boolean>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AntInputBoolComponentBase>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntInputBoolComponentBase>() { yield! attrs }

    static member autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member checked' (x: System.Boolean) = "Checked" => x
    static member checked'' (value: IStore<System.Boolean>) = html.bind("Checked", value)
    static member checked'' (value: cval<System.Boolean>) = html.bind("Checked", value)
    static member checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = html.bind("Checked", valueFn)
    static member onChange fn = html.callback<System.Boolean>("OnChange", fn)
    static member checkedChanged fn = html.callback<System.Boolean>("CheckedChanged", fn)
    static member disabled (x: System.Boolean) = "Disabled" => x
                    

type checkbox<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Checkbox>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Checkbox>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Checkbox>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Checkbox>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Checkbox>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member checkedChange fn = html.callback<System.Boolean>("CheckedChange", fn)
    static member checkedExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "CheckedExpression" => x
    static member indeterminate (x: System.Boolean) = "Indeterminate" => x
    static member label (x: System.String) = "Label" => x
                    

type switch<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Switch>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Switch>() { yield! attrs }

    static member loading (x: System.Boolean) = "Loading" => x
    static member checkedChildren (x: System.String) = "CheckedChildren" => x
    static member checkedChildrenTemplate (x: string) = html.renderFragment("CheckedChildrenTemplate", html.text x)
    static member checkedChildrenTemplate (node) = html.renderFragment("CheckedChildrenTemplate", node)
    static member checkedChildrenTemplate (nodes) = html.renderFragment("CheckedChildrenTemplate", fragment { yield! nodes })
    static member control (x: System.Boolean) = "Control" => x
    static member onClick fn = html.callback<unit>("OnClick", fn)
    static member unCheckedChildren (x: System.String) = "UnCheckedChildren" => x
    static member unCheckedChildrenTemplate (x: string) = html.renderFragment("UnCheckedChildrenTemplate", html.text x)
    static member unCheckedChildrenTemplate (node) = html.renderFragment("UnCheckedChildrenTemplate", node)
    static member unCheckedChildrenTemplate (nodes) = html.renderFragment("UnCheckedChildrenTemplate", fragment { yield! nodes })
                    

type autoComplete<'FunBlazorGeneric, 'TOption> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AutoComplete<'TOption>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoComplete<'TOption>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.AutoComplete<'TOption>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.AutoComplete<'TOption>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.AutoComplete<'TOption>>(){ x }
    static member placeholder (x: System.String) = "Placeholder" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x
    static member backfill (x: System.Boolean) = "Backfill" => x
    static member options (x: System.Collections.Generic.IEnumerable<'TOption>) = "Options" => x
    static member optionDataItems (x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionDataItems" => x
    static member onSelectionChange fn = html.callback<AntDesign.AutoCompleteOption>("OnSelectionChange", fn)
    static member onActiveChange fn = html.callback<AntDesign.AutoCompleteOption>("OnActiveChange", fn)
    static member onInput fn = html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInput", fn)
    static member onPanelVisibleChange fn = html.callback<System.Boolean>("OnPanelVisibleChange", fn)
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member optionTemplate (render: AntDesign.AutoCompleteDataItem<'TOption> -> NodeRenderFragment) = html.renderFragment("OptionTemplate", render)
    static member optionFormat (fn) = "OptionFormat" => (System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>fn)
    static member overlayTemplate (x: string) = html.renderFragment("OverlayTemplate", html.text x)
    static member overlayTemplate (node) = html.renderFragment("OverlayTemplate", node)
    static member overlayTemplate (nodes) = html.renderFragment("OverlayTemplate", fragment { yield! nodes })
    static member compareWith (fn) = "CompareWith" => (System.Func<System.Object, System.Object, System.Boolean>fn)
    static member filterExpression (fn) = "FilterExpression" => (System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>fn)
    static member allowFilter (x: System.Boolean) = "AllowFilter" => x
    static member width (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Width" => x
    static member overlayClassName (x: System.String) = "OverlayClassName" => x
    static member overlayStyle (x: System.String) = "OverlayStyle" => x
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member selectedItem (x: AntDesign.AutoCompleteOption) = "SelectedItem" => x
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member showPanel (x: System.Boolean) = "ShowPanel" => x
                    

type cascader<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Cascader>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Cascader>() { yield! attrs }

    static member allowClear (x: System.Boolean) = "AllowClear" => x
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member changeOnSelect (x: System.Boolean) = "ChangeOnSelect" => x
    static member defaultValue (x: System.String) = "DefaultValue" => x
    static member expandTrigger (x: System.String) = "ExpandTrigger" => x
    static member notFoundContent (x: System.String) = "NotFoundContent" => x
    static member placeholder (x: System.String) = "Placeholder" => x
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member showSearch (x: System.Boolean) = "ShowSearch" => x
    static member onChange (fn) = "OnChange" => (System.Action<System.Collections.Generic.List<AntDesign.CascaderNode>, System.String, System.String>fn)
    static member selectedNodesChanged fn = html.callback<AntDesign.CascaderNode[]>("SelectedNodesChanged", fn)
    static member options (x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = "Options" => x
                    

type checkboxGroup<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String[]>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.CheckboxGroup>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CheckboxGroup>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.CheckboxGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.CheckboxGroup>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.CheckboxGroup>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member options (x: OneOf.OneOf<AntDesign.CheckboxOption[], System.String[]>) = "Options" => x
    static member mixedMode (x: AntDesign.CheckboxGroupMixedMode) = "MixedMode" => x
    static member onChange fn = html.callback<System.String[]>("OnChange", fn)
    static member disabled (x: System.Boolean) = "Disabled" => x
                    

type datePickerBase<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.DatePickerBase<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DatePickerBase<'TValue>>() { yield! attrs }

    static member prefixCls (x: System.String) = "PrefixCls" => x
    static member picker (x: System.String) = "Picker" => x
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member disabled (x: OneOf.OneOf<System.Boolean, System.Boolean[]>) = "Disabled" => x
    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member bordered (x: System.Boolean) = "Bordered" => x
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member open' (x: System.Boolean) = "Open" => x
    static member inputReadOnly (x: System.Boolean) = "InputReadOnly" => x
    static member showToday (x: System.Boolean) = "ShowToday" => x
    static member locale (x: AntDesign.DatePickerLocale) = "Locale" => x
    static member cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x
    static member showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x
    static member allowClear (x: System.Boolean) = "AllowClear" => x
    static member placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x
    static member popupStyle (x: System.String) = "PopupStyle" => x
    static member className (x: System.String) = "ClassName" => x
    static member dropdownClassName (x: System.String) = "DropdownClassName" => x
    static member format (x: System.String) = "Format" => x
    static member defaultValue (x: 'TValue) = "DefaultValue" => x
    static member defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x
    static member suffixIcon (x: string) = html.renderFragment("SuffixIcon", html.text x)
    static member suffixIcon (node) = html.renderFragment("SuffixIcon", node)
    static member suffixIcon (nodes) = html.renderFragment("SuffixIcon", fragment { yield! nodes })
    static member renderExtraFooter (x: string) = html.renderFragment("RenderExtraFooter", html.text x)
    static member renderExtraFooter (node) = html.renderFragment("RenderExtraFooter", node)
    static member renderExtraFooter (nodes) = html.renderFragment("RenderExtraFooter", fragment { yield! nodes })
    static member onClearClick fn = html.callback<unit>("OnClearClick", fn)
    static member onOpenChange fn = html.callback<System.Boolean>("OnOpenChange", fn)
    static member onPanelChange fn = html.callback<AntDesign.DateTimeChangedEventArgs>("OnPanelChange", fn)
    static member disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn)
    static member disabledHours (fn) = "DisabledHours" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member disabledMinutes (fn) = "DisabledMinutes" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member disabledSeconds (fn) = "DisabledSeconds" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member disabledTime (fn) = "DisabledTime" => (System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>fn)
    static member dateRender (fn: _ -> _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DateRender", box (System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1 x2).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member monthCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "MonthCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
                    

type datePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.DatePicker<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DatePicker<'TValue>>() { yield! attrs }

    static member onChange fn = html.callback<AntDesign.DateTimeChangedEventArgs>("OnChange", fn)
                    

type monthPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.MonthPicker<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MonthPicker<'TValue>>() { yield! attrs }


                    

type quarterPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.QuarterPicker<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.QuarterPicker<'TValue>>() { yield! attrs }


                    

type weekPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.WeekPicker<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.WeekPicker<'TValue>>() { yield! attrs }


                    

type yearPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.YearPicker<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.YearPicker<'TValue>>() { yield! attrs }


                    

type timePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TimePicker<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TimePicker<'TValue>>() { yield! attrs }


                    

type rangePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.RangePicker<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.RangePicker<'TValue>>() { yield! attrs }

    static member value (x: 'TValue) = "Value" => x
    static member onChange fn = html.callback<AntDesign.DateRangeChangedEventArgs>("OnChange", fn)
                    

type inputNumber<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.InputNumber<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.InputNumber<'TValue>>() { yield! attrs }

    static member formatter (fn) = "Formatter" => (System.Func<'TValue, System.String>fn)
    static member parser (fn) = "Parser" => (System.Func<System.String, System.String>fn)
    static member step (x: 'TValue) = "Step" => x
    static member defaultValue (x: 'TValue) = "DefaultValue" => x
    static member max (x: 'TValue) = "Max" => x
    static member min (x: 'TValue) = "Min" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member onChange fn = html.callback<'TValue>("OnChange", fn)
    static member onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
                    

type input<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Input<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Input<'TValue>>() { yield! attrs }

    static member addOnBefore (x: string) = html.renderFragment("AddOnBefore", html.text x)
    static member addOnBefore (node) = html.renderFragment("AddOnBefore", node)
    static member addOnBefore (nodes) = html.renderFragment("AddOnBefore", fragment { yield! nodes })
    static member addOnAfter (x: string) = html.renderFragment("AddOnAfter", html.text x)
    static member addOnAfter (node) = html.renderFragment("AddOnAfter", node)
    static member addOnAfter (nodes) = html.renderFragment("AddOnAfter", fragment { yield! nodes })
    static member allowClear (x: System.Boolean) = "AllowClear" => x
    static member autoComplete (x: System.Boolean) = "AutoComplete" => x
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member bordered (x: System.Boolean) = "Bordered" => x
    static member debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x
    static member defaultValue (x: 'TValue) = "DefaultValue" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x
    static member maxLength (x: System.Int32) = "MaxLength" => x
    static member onBlur fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    static member onChange fn = html.callback<'TValue>("OnChange", fn)
    static member onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
    static member onInput fn = html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInput", fn)
    static member onkeyDown fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnkeyDown", fn)
    static member onkeyUp fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnkeyUp", fn)
    static member onMouseUp fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnMouseUp", fn)
    static member onPressEnter fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnPressEnter", fn)
    static member placeholder (x: System.String) = "Placeholder" => x
    static member prefix (x: string) = html.renderFragment("Prefix", html.text x)
    static member prefix (node) = html.renderFragment("Prefix", node)
    static member prefix (nodes) = html.renderFragment("Prefix", fragment { yield! nodes })
    static member readOnly (x: System.Boolean) = "ReadOnly" => x
    static member stopPropagation (x: System.Boolean) = "StopPropagation" => x
    static member suffix (x: string) = html.renderFragment("Suffix", html.text x)
    static member suffix (node) = html.renderFragment("Suffix", node)
    static member suffix (nodes) = html.renderFragment("Suffix", fragment { yield! nodes })
    static member type' (x: System.String) = "Type" => x
    static member wrapperStyle (x: System.String) = "WrapperStyle" => x
                    

type search<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Search>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Search>() { yield! attrs }

    static member classicSearchIcon (x: System.Boolean) = "ClassicSearchIcon" => x
    static member enterButton (x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member onSearch fn = html.callback<System.String>("OnSearch", fn)
                    

type autoCompleteSearch<'FunBlazorGeneric> =
    inherit search<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AutoCompleteSearch>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteSearch>() { yield! attrs }


                    

type autoCompleteInput<'FunBlazorGeneric, 'TValue> =
    inherit input<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AutoCompleteInput<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteInput<'TValue>>() { yield! attrs }


                    

type inputPassword<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.InputPassword>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.InputPassword>() { yield! attrs }

    static member iconRender (x: string) = html.renderFragment("IconRender", html.text x)
    static member iconRender (node) = html.renderFragment("IconRender", node)
    static member iconRender (nodes) = html.renderFragment("IconRender", fragment { yield! nodes })
    static member showPassword (x: System.Boolean) = "ShowPassword" => x
    static member visibilityToggle (x: System.Boolean) = "VisibilityToggle" => x
                    

type textArea<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TextArea>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TextArea>() { yield! attrs }

    static member autoSize (x: System.Boolean) = "AutoSize" => x
    static member defaultToEmptyString (x: System.Boolean) = "DefaultToEmptyString" => x
    static member maxRows (x: System.UInt32) = "MaxRows" => x
    static member minRows (x: System.UInt32) = "MinRows" => x
    static member rows (x: System.UInt32) = "Rows" => x
    static member onResize fn = html.callback<AntDesign.OnResizeEventArgs>("OnResize", fn)
    static member showCount (x: System.Boolean) = "ShowCount" => x
    static member value (x: System.String) = "Value" => x
                    

type radioGroup<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.RadioGroup<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.RadioGroup<'TValue>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.RadioGroup<'TValue>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.RadioGroup<'TValue>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.RadioGroup<'TValue>>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member buttonStyle (x: AntDesign.RadioButtonStyle) = "ButtonStyle" => x
    static member name (x: System.String) = "Name" => x
    static member defaultValue (x: 'TValue) = "DefaultValue" => x
    static member onChange fn = html.callback<'TValue>("OnChange", fn)
    static member options (x: OneOf.OneOf<System.String[], AntDesign.RadioOption<'TValue>[]>) = "Options" => x
                    

type enumRadioGroup<'FunBlazorGeneric, 'TEnum> =
    inherit radioGroup<'FunBlazorGeneric, 'TEnum>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.EnumRadioGroup<'TEnum>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.EnumRadioGroup<'TEnum>>() { yield! attrs }


                    

type selectBase<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TItemValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SelectBase<'TItemValue, 'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SelectBase<'TItemValue, 'TItem>>() { yield! attrs }

    static member allowClear (x: System.Boolean) = "AllowClear" => x
    static member autoClearSearchValue (x: System.Boolean) = "AutoClearSearchValue" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member mode (x: System.String) = "Mode" => x
    static member enableSearch (x: System.Boolean) = "EnableSearch" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member open' (x: System.Boolean) = "Open" => x
    static member placeholder (x: System.String) = "Placeholder" => x
    static member onFocus (x: System.Action) = "OnFocus" => x
    static member sortByGroup (x: AntDesign.SortDirection) = "SortByGroup" => x
    static member sortByLabel (x: AntDesign.SortDirection) = "SortByLabel" => x
    static member hideSelected (x: System.Boolean) = "HideSelected" => x
    static member valueChanged fn = html.callback<'TItemValue>("ValueChanged", fn)
    static member valuesChanged fn = html.callback<System.Collections.Generic.IEnumerable<'TItemValue>>("ValuesChanged", fn)
    static member suffixIcon (x: string) = html.renderFragment("SuffixIcon", html.text x)
    static member suffixIcon (node) = html.renderFragment("SuffixIcon", node)
    static member suffixIcon (nodes) = html.renderFragment("SuffixIcon", fragment { yield! nodes })
    static member prefixIcon (x: string) = html.renderFragment("PrefixIcon", html.text x)
    static member prefixIcon (node) = html.renderFragment("PrefixIcon", node)
    static member prefixIcon (nodes) = html.renderFragment("PrefixIcon", fragment { yield! nodes })
    static member defaultValues (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "DefaultValues" => x
    static member onClearSelected (x: System.Action) = "OnClearSelected" => x
    static member onSelectedItemChanged (fn) = "OnSelectedItemChanged" => (System.Action<'TItem>fn)
    static member onSelectedItemsChanged (fn) = "OnSelectedItemsChanged" => (System.Action<System.Collections.Generic.IEnumerable<'TItem>>fn)
    static member values (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "Values" => x
    static member values' (value: IStore<System.Collections.Generic.IEnumerable<'TItemValue>>) = html.bind("Values", value)
    static member values' (value: cval<System.Collections.Generic.IEnumerable<'TItemValue>>) = html.bind("Values", value)
    static member values' (valueFn: System.Collections.Generic.IEnumerable<'TItemValue> * (System.Collections.Generic.IEnumerable<'TItemValue> -> unit)) = html.bind("Values", valueFn)
    static member customTagLabelToValue (fn) = "CustomTagLabelToValue" => (System.Func<System.String, 'TItemValue>fn)
    static member selectOptions (x: string) = html.renderFragment("SelectOptions", html.text x)
    static member selectOptions (node) = html.renderFragment("SelectOptions", node)
    static member selectOptions (nodes) = html.renderFragment("SelectOptions", fragment { yield! nodes })
    static member maxTagTextLength (x: System.Int32) = "MaxTagTextLength" => x
    static member labelInValue (x: System.Boolean) = "LabelInValue" => x
    static member maxTagCount (x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x
    static member valueOnClear (x: 'TItemValue) = "ValueOnClear" => x
                    

type select'<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit selectBase<'FunBlazorGeneric, 'TItemValue, 'TItem>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Select<'TItemValue, 'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Select<'TItemValue, 'TItem>>() { yield! attrs }

    static member boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member bordered (x: System.Boolean) = "Bordered" => x
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member dataSourceEqualityComparer (x: System.Collections.Generic.IEqualityComparer<'TItem>) = "DataSourceEqualityComparer" => x
    static member defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x
    static member disabledName (x: System.String) = "DisabledName" => x
    static member dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x
    static member dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x
    static member dropdownRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DropdownRender", box (System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member groupName (x: System.String) = "GroupName" => x
    static member ignoreItemChanges (x: System.Boolean) = "IgnoreItemChanges" => x
    static member itemTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("ItemTemplate", render)
    static member labelName (x: System.String) = "LabelName" => x
    static member labelTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("LabelTemplate", render)
    static member maxTagPlaceholder (render: System.Collections.Generic.IEnumerable<'TItem> -> NodeRenderFragment) = html.renderFragment("MaxTagPlaceholder", render)
    static member notFoundContent (x: string) = html.renderFragment("NotFoundContent", html.text x)
    static member notFoundContent (node) = html.renderFragment("NotFoundContent", node)
    static member notFoundContent (nodes) = html.renderFragment("NotFoundContent", fragment { yield! nodes })
    static member onBlur (x: System.Action) = "OnBlur" => x
    static member onCreateCustomTag (fn) = "OnCreateCustomTag" => (System.Action<System.String>fn)
    static member onDataSourceChanged (x: System.Action) = "OnDataSourceChanged" => x
    static member onDropdownVisibleChange (fn) = "OnDropdownVisibleChange" => (System.Action<System.Boolean>fn)
    static member onMouseEnter (x: System.Action) = "OnMouseEnter" => x
    static member onMouseLeave (x: System.Action) = "OnMouseLeave" => x
    static member onSearch (fn) = "OnSearch" => (System.Action<System.String>fn)
    static member popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x
    static member showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x
    static member tokenSeparators (x: System.Char[]) = "TokenSeparators" => x
    static member valueChanged fn = html.callback<'TItemValue>("ValueChanged", fn)
    static member valueName (x: System.String) = "ValueName" => x
    static member value (x: 'TItemValue) = "Value" => x
    static member value' (value: IStore<'TItemValue>) = html.bind("Value", value)
    static member value' (value: cval<'TItemValue>) = html.bind("Value", value)
    static member value' (valueFn: 'TItemValue * ('TItemValue -> unit)) = html.bind("Value", valueFn)
    static member defaultValue (x: 'TItemValue) = "DefaultValue" => x
                    

type enumSelect<'FunBlazorGeneric, 'TEnum> =
    inherit select'<'FunBlazorGeneric, 'TEnum, 'TEnum>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.EnumSelect<'TEnum>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.EnumSelect<'TEnum>>() { yield! attrs }


                    

type simpleSelect<'FunBlazorGeneric> =
    inherit select'<'FunBlazorGeneric, System.String, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SimpleSelect>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SimpleSelect>() { yield! attrs }


                    

type treeSelect<'FunBlazorGeneric, 'TItem when 'TItem : not struct> =
    inherit selectBase<'FunBlazorGeneric, System.String, 'TItem>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TreeSelect<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeSelect<'TItem>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.TreeSelect<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.TreeSelect<'TItem>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.TreeSelect<'TItem>>(){ x }
    static member showExpand (x: System.Boolean) = "ShowExpand" => x
    static member multiple (x: System.Boolean) = "Multiple" => x
    static member treeCheckable (x: System.Boolean) = "TreeCheckable" => x
    static member popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member onMouseEnter (x: System.Action) = "OnMouseEnter" => x
    static member onMouseLeave (x: System.Action) = "OnMouseLeave" => x
    static member labelTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("LabelTemplate", render)
    static member showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x
    static member showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x
    static member nodes (x: AntDesign.TreeNode<'TItem>[]) = "Nodes" => x
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member treeDefaultExpandAll (x: System.Boolean) = "TreeDefaultExpandAll" => x
    static member dataItemExpression (fn) = "DataItemExpression" => (System.Func<System.Collections.Generic.IEnumerable<'TItem>, System.String, 'TItem>fn)
    static member dataItemsExpression (fn) = "DataItemsExpression" => (System.Func<System.Collections.Generic.IList<'TItem>, System.Collections.Generic.IEnumerable<System.String>, System.Collections.Generic.IEnumerable<'TItem>>fn)
    static member rootValue (x: System.String) = "RootValue" => x
    static member titleExpression (fn) = "TitleExpression" => (System.Func<'TItem, System.String>fn)
    static member keyExpression (fn) = "KeyExpression" => (System.Func<'TItem, System.String>fn)
    static member iconExpression (fn) = "IconExpression" => (System.Func<'TItem, System.String>fn)
    static member isLeafExpression (fn) = "IsLeafExpression" => (System.Func<'TItem, System.Boolean>fn)
    static member childrenExpression (fn) = "ChildrenExpression" => (System.Func<'TItem, System.Collections.Generic.IList<'TItem>>fn)
    static member disabledExpression (fn) = "DisabledExpression" => (System.Func<'TItem, System.Boolean>fn)
    static member dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x
    static member dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x
    static member popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x
                    

type simpleTreeSelect<'FunBlazorGeneric, 'TItem when 'TItem : not struct> =
    inherit treeSelect<'FunBlazorGeneric, 'TItem>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SimpleTreeSelect<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SimpleTreeSelect<'TItem>>() { yield! attrs }

    static member childrenMethodExpression (fn) = "ChildrenMethodExpression" => (System.Func<System.String, System.Collections.Generic.IList<'TItem>>fn)
                    

type slider<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Slider<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Slider<'TValue>>() { yield! attrs }

    static member defaultValue (x: 'TValue) = "DefaultValue" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member dots (x: System.Boolean) = "Dots" => x
    static member included (x: System.Boolean) = "Included" => x
    static member marks (x: AntDesign.SliderMark[]) = "Marks" => x
    static member max (x: System.Double) = "Max" => x
    static member min (x: System.Double) = "Min" => x
    static member reverse (x: System.Boolean) = "Reverse" => x
    static member step (x: System.Nullable<System.Double>) = "Step" => x
    static member vertical (x: System.Boolean) = "Vertical" => x
    static member onAfterChange (fn) = "OnAfterChange" => (System.Action<'TValue>fn)
    static member onChange (fn) = "OnChange" => (System.Action<'TValue>fn)
    static member hasTooltip (x: System.Boolean) = "HasTooltip" => x
    static member tipFormatter (fn) = "TipFormatter" => (System.Func<System.Double, System.String>fn)
    static member tooltipPlacement (x: AntDesign.Placement) = "TooltipPlacement" => x
    static member tooltipVisible (x: System.Boolean) = "TooltipVisible" => x
    static member getTooltipPopupContainer (x: System.Object) = "GetTooltipPopupContainer" => x
    static member value (x: 'TValue) = "Value" => x
                    

type descriptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Descriptions>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Descriptions>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Descriptions>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Descriptions>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Descriptions>(){ x }
    static member bordered (x: System.Boolean) = "Bordered" => x
    static member layout (x: System.String) = "Layout" => x
    static member column (x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>) = "Column" => x
    static member size (x: System.String) = "Size" => x
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member colon (x: System.Boolean) = "Colon" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type descriptionsItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.DescriptionsItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DescriptionsItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.DescriptionsItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.DescriptionsItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.DescriptionsItem>(){ x }
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member span (x: System.Int32) = "Span" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type divider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Divider>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Divider>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Divider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Divider>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Divider>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member text (x: System.String) = "Text" => x
    static member plain (x: System.Boolean) = "Plain" => x
    static member type' (x: AntDesign.DirectionVHType) = "Type" => x
    static member orientation (x: System.String) = "Orientation" => x
    static member dashed (x: System.Boolean) = "Dashed" => x
                    

type drawer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Drawer>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Drawer>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Drawer>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Drawer>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Drawer>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member content (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Content" => x
    static member closable (x: System.Boolean) = "Closable" => x
    static member maskClosable (x: System.Boolean) = "MaskClosable" => x
    static member mask (x: System.Boolean) = "Mask" => x
    static member keyboard (x: System.Boolean) = "Keyboard" => x
    static member title (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Title" => x
    static member placement (x: System.String) = "Placement" => x
    static member maskStyle (x: System.String) = "MaskStyle" => x
    static member bodyStyle (x: System.String) = "BodyStyle" => x
    static member wrapClassName (x: System.String) = "WrapClassName" => x
    static member width (x: System.Int32) = "Width" => x
    static member height (x: System.Int32) = "Height" => x
    static member zIndex (x: System.Int32) = "ZIndex" => x
    static member offsetX (x: System.Int32) = "OffsetX" => x
    static member offsetY (x: System.Int32) = "OffsetY" => x
    static member visible (x: System.Boolean) = "Visible" => x
    static member onClose fn = html.callback<unit>("OnClose", fn)
    static member handler (x: string) = html.renderFragment("Handler", html.text x)
    static member handler (node) = html.renderFragment("Handler", node)
    static member handler (nodes) = html.renderFragment("Handler", fragment { yield! nodes })
                    

type drawerContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.DrawerContainer>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DrawerContainer>() { yield! attrs }


                    

type empty<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Empty>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Empty>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Empty>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Empty>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Empty>(){ x }
    static member prefixCls (x: System.String) = "PrefixCls" => x
    static member imageStyle (x: System.String) = "ImageStyle" => x
    static member small (x: System.Boolean) = "Small" => x
    static member simple (x: System.Boolean) = "Simple" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member description (x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = "Description" => x
    static member descriptionTemplate (x: string) = html.renderFragment("DescriptionTemplate", html.text x)
    static member descriptionTemplate (node) = html.renderFragment("DescriptionTemplate", node)
    static member descriptionTemplate (nodes) = html.renderFragment("DescriptionTemplate", fragment { yield! nodes })
    static member image (x: System.String) = "Image" => x
    static member imageTemplate (x: string) = html.renderFragment("ImageTemplate", html.text x)
    static member imageTemplate (node) = html.renderFragment("ImageTemplate", node)
    static member imageTemplate (nodes) = html.renderFragment("ImageTemplate", fragment { yield! nodes })
                    

type form<'FunBlazorGeneric, 'TModel> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Form<'TModel>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Form<'TModel>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Form<'TModel>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Form<'TModel>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Form<'TModel>>(){ x }
    static member layout (x: System.String) = "Layout" => x
    static member childContent (render: 'TModel -> NodeRenderFragment) = html.renderFragment("ChildContent", render)
    static member labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x
    static member labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x
    static member labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x
    static member labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x
    static member wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x
    static member wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x
    static member wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x
    static member size (x: System.String) = "Size" => x
    static member name (x: System.String) = "Name" => x
    static member model (x: 'TModel) = "Model" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member onFinish fn = html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnFinish", fn)
    static member onFinishFailed fn = html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnFinishFailed", fn)
    static member onFieldChanged fn = html.callback<Microsoft.AspNetCore.Components.Forms.FieldChangedEventArgs>("OnFieldChanged", fn)
    static member onValidationRequested fn = html.callback<Microsoft.AspNetCore.Components.Forms.ValidationRequestedEventArgs>("OnValidationRequested", fn)
    static member onValidationStateChanged fn = html.callback<Microsoft.AspNetCore.Components.Forms.ValidationStateChangedEventArgs>("OnValidationStateChanged", fn)
    static member validator (x: string) = html.renderFragment("Validator", html.text x)
    static member validator (node) = html.renderFragment("Validator", node)
    static member validator (nodes) = html.renderFragment("Validator", fragment { yield! nodes })
    static member validateOnChange (x: System.Boolean) = "ValidateOnChange" => x
    static member validateMode (x: AntDesign.FormValidateMode) = "ValidateMode" => x
    static member validateMessages (x: AntDesign.FormValidateErrorMessages) = "ValidateMessages" => x
                    

type formItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.FormItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.FormItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.FormItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.FormItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.FormItem>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member label (x: System.String) = "Label" => x
    static member labelTemplate (x: string) = html.renderFragment("LabelTemplate", html.text x)
    static member labelTemplate (node) = html.renderFragment("LabelTemplate", node)
    static member labelTemplate (nodes) = html.renderFragment("LabelTemplate", fragment { yield! nodes })
    static member labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x
    static member labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x
    static member labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x
    static member labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x
    static member wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x
    static member wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x
    static member wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x
    static member noStyle (x: System.Boolean) = "NoStyle" => x
    static member required (x: System.Boolean) = "Required" => x
    static member labelStyle (x: System.String) = "LabelStyle" => x
    static member rules (x: AntDesign.FormValidationRule[]) = "Rules" => x
    static member hasFeedback (x: System.Boolean) = "HasFeedback" => x
    static member validateStatus (x: AntDesign.FormValidateStatus) = "ValidateStatus" => x
    static member help (x: System.String) = "Help" => x
                    

type row<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Row>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Row>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Row>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Row>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Row>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member type' (x: System.String) = "Type" => x
    static member align (x: System.String) = "Align" => x
    static member justify (x: System.String) = "Justify" => x
    static member wrap (x: System.Boolean) = "Wrap" => x
    static member gutter (x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Collections.Generic.Dictionary<System.String, System.Int32>>>) = "Gutter" => x
    static member onBreakpoint fn = html.callback<AntDesign.BreakpointType>("OnBreakpoint", fn)
    static member defaultBreakpoint (x: System.Nullable<AntDesign.BreakpointType>) = "DefaultBreakpoint" => x
                    

type image<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Image>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Image>() { yield! attrs }

    static member alt (x: System.String) = "Alt" => x
    static member fallback (x: System.String) = "Fallback" => x
    static member height (x: System.String) = "Height" => x
    static member width (x: System.String) = "Width" => x
    static member placeholder (x: string) = html.renderFragment("Placeholder", html.text x)
    static member placeholder (node) = html.renderFragment("Placeholder", node)
    static member placeholder (nodes) = html.renderFragment("Placeholder", fragment { yield! nodes })
    static member preview (x: System.Boolean) = "Preview" => x
    static member previewVisible (x: System.Boolean) = "PreviewVisible" => x
    static member src (x: System.String) = "Src" => x
    static member previewSrc (x: System.String) = "PreviewSrc" => x
    static member onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member locale (x: AntDesign.ImageLocale) = "Locale" => x
                    

type imagePreviewContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ImagePreviewContainer>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ImagePreviewContainer>() { yield! attrs }


                    

type inputGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.InputGroup>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.InputGroup>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.InputGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.InputGroup>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.InputGroup>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member compact (x: System.Boolean) = "Compact" => x
    static member size (x: System.String) = "Size" => x
                    

type sider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Sider>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Sider>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Sider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Sider>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Sider>(){ x }
    static member collapsible (x: System.Boolean) = "Collapsible" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member trigger (x: string) = html.renderFragment("Trigger", html.text x)
    static member trigger (node) = html.renderFragment("Trigger", node)
    static member trigger (nodes) = html.renderFragment("Trigger", fragment { yield! nodes })
    static member noTrigger (x: System.Boolean) = "NoTrigger" => x
    static member breakpoint (x: System.Nullable<AntDesign.BreakpointType>) = "Breakpoint" => x
    static member theme (x: AntDesign.SiderTheme) = "Theme" => x
    static member width (x: System.Int32) = "Width" => x
    static member collapsedWidth (x: System.Int32) = "CollapsedWidth" => x
    static member collapsed (x: System.Boolean) = "Collapsed" => x
    static member onCollapse fn = html.callback<System.Boolean>("OnCollapse", fn)
    static member onBreakpoint fn = html.callback<System.Boolean>("OnBreakpoint", fn)
                    

type antList<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AntList<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntList<'TItem>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.AntList<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.AntList<'TItem>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.AntList<'TItem>>(){ x }
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member bordered (x: System.Boolean) = "Bordered" => x
    static member header (x: string) = html.renderFragment("Header", html.text x)
    static member header (node) = html.renderFragment("Header", node)
    static member header (nodes) = html.renderFragment("Header", fragment { yield! nodes })
    static member footer (x: string) = html.renderFragment("Footer", html.text x)
    static member footer (node) = html.renderFragment("Footer", node)
    static member footer (nodes) = html.renderFragment("Footer", fragment { yield! nodes })
    static member loadMore (x: string) = html.renderFragment("LoadMore", html.text x)
    static member loadMore (node) = html.renderFragment("LoadMore", node)
    static member loadMore (nodes) = html.renderFragment("LoadMore", fragment { yield! nodes })
    static member itemLayout (x: AntDesign.ListItemLayout) = "ItemLayout" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member noResult (x: System.String) = "NoResult" => x
    static member size (x: System.String) = "Size" => x
    static member split (x: System.Boolean) = "Split" => x
    static member grid (x: AntDesign.ListGridType) = "Grid" => x
    static member pagination (x: AntDesign.PaginationOptions) = "Pagination" => x
    static member childContent (render: 'TItem -> NodeRenderFragment) = html.renderFragment("ChildContent", render)
                    

type listItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ListItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ListItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.ListItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.ListItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.ListItem>(){ x }
    static member content (x: System.String) = "Content" => x
    static member extra (x: string) = html.renderFragment("Extra", html.text x)
    static member extra (node) = html.renderFragment("Extra", node)
    static member extra (nodes) = html.renderFragment("Extra", fragment { yield! nodes })
    static member actions (x: Microsoft.AspNetCore.Components.RenderFragment[]) = "Actions" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member colStyle (x: System.String) = "ColStyle" => x
    static member itemCount (x: System.Int32) = "ItemCount" => x
    static member onClick fn = html.callback<unit>("OnClick", fn)
    static member noFlex (x: System.Boolean) = "NoFlex" => x
                    

type listItemMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ListItemMeta>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ListItemMeta>() { yield! attrs }

    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member avatar (x: System.String) = "Avatar" => x
    static member avatarTemplate (x: string) = html.renderFragment("AvatarTemplate", html.text x)
    static member avatarTemplate (node) = html.renderFragment("AvatarTemplate", node)
    static member avatarTemplate (nodes) = html.renderFragment("AvatarTemplate", fragment { yield! nodes })
    static member description (x: System.String) = "Description" => x
    static member descriptionTemplate (x: string) = html.renderFragment("DescriptionTemplate", html.text x)
    static member descriptionTemplate (node) = html.renderFragment("DescriptionTemplate", node)
    static member descriptionTemplate (nodes) = html.renderFragment("DescriptionTemplate", fragment { yield! nodes })
                    

type mentions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Mentions>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Mentions>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Mentions>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Mentions>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Mentions>(){ x }
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member disable (x: System.Boolean) = "Disable" => x
    static member readonly (x: System.Boolean) = "Readonly" => x
    static member prefix (x: System.String) = "Prefix" => x
    static member split (x: System.String) = "Split" => x
    static member defaultValue (x: System.String) = "DefaultValue" => x
    static member placeholder (x: System.String) = "Placeholder" => x
    static member value (x: System.String) = "Value" => x
    static member placement (x: System.String) = "Placement" => x
    static member rows (x: System.Int32) = "Rows" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member valueChange fn = html.callback<System.String>("ValueChange", fn)
    static member onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
    static member onBlur fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    static member onSearch fn = html.callback<System.EventArgs>("OnSearch", fn)
    static member noFoundContent (x: string) = html.renderFragment("NoFoundContent", html.text x)
    static member noFoundContent (node) = html.renderFragment("NoFoundContent", node)
    static member noFoundContent (nodes) = html.renderFragment("NoFoundContent", fragment { yield! nodes })
                    

type mentionsOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.MentionsOption>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MentionsOption>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.MentionsOption>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.MentionsOption>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.MentionsOption>(){ x }
    static member value (x: System.String) = "Value" => x
    static member disable (x: System.Boolean) = "Disable" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type menu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Menu>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Menu>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Menu>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Menu>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Menu>(){ x }
    static member theme (x: AntDesign.MenuTheme) = "Theme" => x
    static member mode (x: AntDesign.MenuMode) = "Mode" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member onSubmenuClicked fn = html.callback<AntDesign.SubMenu>("OnSubmenuClicked", fn)
    static member onMenuItemClicked fn = html.callback<AntDesign.MenuItem>("OnMenuItemClicked", fn)
    static member accordion (x: System.Boolean) = "Accordion" => x
    static member selectable (x: System.Boolean) = "Selectable" => x
    static member multiple (x: System.Boolean) = "Multiple" => x
    static member inlineCollapsed (x: System.Boolean) = "InlineCollapsed" => x
    static member inlineIndent (x: System.Int32) = "InlineIndent" => x
    static member autoCloseDropdown (x: System.Boolean) = "AutoCloseDropdown" => x
    static member defaultSelectedKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultSelectedKeys" => x
    static member defaultOpenKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultOpenKeys" => x
    static member openKeys (x: System.String[]) = "OpenKeys" => x
    static member openKeys' (value: IStore<System.String[]>) = html.bind("OpenKeys", value)
    static member openKeys' (value: cval<System.String[]>) = html.bind("OpenKeys", value)
    static member openKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("OpenKeys", valueFn)
    static member openKeysChanged fn = html.callback<System.String[]>("OpenKeysChanged", fn)
    static member onOpenChange fn = html.callback<System.String[]>("OnOpenChange", fn)
    static member selectedKeys (x: System.String[]) = "SelectedKeys" => x
    static member selectedKeys' (value: IStore<System.String[]>) = html.bind("SelectedKeys", value)
    static member selectedKeys' (value: cval<System.String[]>) = html.bind("SelectedKeys", value)
    static member selectedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("SelectedKeys", valueFn)
    static member selectedKeysChanged fn = html.callback<System.String[]>("SelectedKeysChanged", fn)
    static member triggerSubMenuAction (x: AntDesign.Trigger) = "TriggerSubMenuAction" => x
                    

type menuItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.MenuItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MenuItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.MenuItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.MenuItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.MenuItem>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member key (x: System.String) = "Key" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member routerLink (x: System.String) = "RouterLink" => x
    static member routerMatch (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "RouterMatch" => x
    static member title (x: System.String) = "Title" => x
    static member icon (x: System.String) = "Icon" => x
    static member iconTemplate (x: string) = html.renderFragment("IconTemplate", html.text x)
    static member iconTemplate (node) = html.renderFragment("IconTemplate", node)
    static member iconTemplate (nodes) = html.renderFragment("IconTemplate", fragment { yield! nodes })
                    

type menuItemGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.MenuItemGroup>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MenuItemGroup>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.MenuItemGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.MenuItemGroup>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.MenuItemGroup>(){ x }
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member key (x: System.String) = "Key" => x
                    

type menuLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.MenuLink>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MenuLink>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.MenuLink>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.MenuLink>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.MenuLink>(){ x }
    static member activeClass (x: System.String) = "ActiveClass" => x
    static member href (x: System.String) = "Href" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member attributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x
    static member match' (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x
                    

type subMenu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SubMenu>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SubMenu>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.SubMenu>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.SubMenu>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.SubMenu>(){ x }
    static member placement (x: System.Nullable<AntDesign.Placement>) = "Placement" => x
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member key (x: System.String) = "Key" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member isOpen (x: System.Boolean) = "IsOpen" => x
    static member onTitleClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnTitleClick", fn)
                    

type message<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Message>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Message>() { yield! attrs }


                    

type messageItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.MessageItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MessageItem>() { yield! attrs }

    static member config (x: AntDesign.MessageConfig) = "Config" => x
                    

type comfirmContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ComfirmContainer>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ComfirmContainer>() { yield! attrs }


                    

type confirm<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Confirm>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Confirm>() { yield! attrs }

    static member config (x: AntDesign.ConfirmOptions) = "Config" => x
    static member confirmRef (x: AntDesign.ConfirmRef) = "ConfirmRef" => x
    static member onRemove fn = html.callback<AntDesign.ConfirmRef>("OnRemove", fn)
                    

type dialog<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Dialog>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Dialog>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Dialog>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Dialog>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Dialog>(){ x }
    static member config (x: AntDesign.DialogOptions) = "Config" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member visible (x: System.Boolean) = "Visible" => x
                    

type dialogWrapper<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.DialogWrapper>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DialogWrapper>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.DialogWrapper>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.DialogWrapper>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.DialogWrapper>(){ x }
    static member config (x: AntDesign.DialogOptions) = "Config" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x
    static member visible (x: System.Boolean) = "Visible" => x
    static member onBeforeDestroy fn = html.callback<System.ComponentModel.CancelEventArgs>("OnBeforeDestroy", fn)
    static member onAfterShow fn = html.callback<unit>("OnAfterShow", fn)
    static member onAfterHide fn = html.callback<unit>("OnAfterHide", fn)
                    

type modal<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Modal>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Modal>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Modal>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Modal>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Modal>(){ x }
    static member modalRef (x: AntDesign.ModalRef) = "ModalRef" => x
    static member afterClose (fn) = "AfterClose" => (System.Func<System.Threading.Tasks.Task>fn)
    static member bodyStyle (x: System.String) = "BodyStyle" => x
    static member cancelText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "CancelText" => x
    static member centered (x: System.Boolean) = "Centered" => x
    static member closable (x: System.Boolean) = "Closable" => x
    static member draggable (x: System.Boolean) = "Draggable" => x
    static member dragInViewport (x: System.Boolean) = "DragInViewport" => x
    static member closeIcon (x: string) = html.renderFragment("CloseIcon", html.text x)
    static member closeIcon (node) = html.renderFragment("CloseIcon", node)
    static member closeIcon (nodes) = html.renderFragment("CloseIcon", fragment { yield! nodes })
    static member confirmLoading (x: System.Boolean) = "ConfirmLoading" => x
    static member destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x
    static member footer (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Footer" => x
    static member getContainer (x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "GetContainer" => x
    static member keyboard (x: System.Boolean) = "Keyboard" => x
    static member mask (x: System.Boolean) = "Mask" => x
    static member maskClosable (x: System.Boolean) = "MaskClosable" => x
    static member maskStyle (x: System.String) = "MaskStyle" => x
    static member okText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "OkText" => x
    static member okType (x: System.String) = "OkType" => x
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member visible (x: System.Boolean) = "Visible" => x
    static member width (x: OneOf.OneOf<System.String, System.Double>) = "Width" => x
    static member wrapClassName (x: System.String) = "WrapClassName" => x
    static member zIndex (x: System.Int32) = "ZIndex" => x
    static member onCancel fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCancel", fn)
    static member onOk fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnOk", fn)
    static member okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x
    static member cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member locale (x: AntDesign.ModalLocale) = "Locale" => x
                    

type modalContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ModalContainer>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ModalContainer>() { yield! attrs }


                    

type modalFooter<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ModalFooter>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ModalFooter>() { yield! attrs }


                    

type pageHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.PageHeader>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.PageHeader>() { yield! attrs }

    static member ghost (x: System.Boolean) = "Ghost" => x
    static member backIcon (x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = "BackIcon" => x
    static member backIconTemplate (x: string) = html.renderFragment("BackIconTemplate", html.text x)
    static member backIconTemplate (node) = html.renderFragment("BackIconTemplate", node)
    static member backIconTemplate (nodes) = html.renderFragment("BackIconTemplate", fragment { yield! nodes })
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member subtitle (x: System.String) = "Subtitle" => x
    static member subtitleTemplate (x: string) = html.renderFragment("SubtitleTemplate", html.text x)
    static member subtitleTemplate (node) = html.renderFragment("SubtitleTemplate", node)
    static member subtitleTemplate (nodes) = html.renderFragment("SubtitleTemplate", fragment { yield! nodes })
    static member onBack fn = html.callback<unit>("OnBack", fn)
    static member pageHeaderContent (x: string) = html.renderFragment("PageHeaderContent", html.text x)
    static member pageHeaderContent (node) = html.renderFragment("PageHeaderContent", node)
    static member pageHeaderContent (nodes) = html.renderFragment("PageHeaderContent", fragment { yield! nodes })
    static member pageHeaderFooter (x: string) = html.renderFragment("PageHeaderFooter", html.text x)
    static member pageHeaderFooter (node) = html.renderFragment("PageHeaderFooter", node)
    static member pageHeaderFooter (nodes) = html.renderFragment("PageHeaderFooter", fragment { yield! nodes })
    static member pageHeaderBreadcrumb (x: string) = html.renderFragment("PageHeaderBreadcrumb", html.text x)
    static member pageHeaderBreadcrumb (node) = html.renderFragment("PageHeaderBreadcrumb", node)
    static member pageHeaderBreadcrumb (nodes) = html.renderFragment("PageHeaderBreadcrumb", fragment { yield! nodes })
    static member pageHeaderAvatar (x: string) = html.renderFragment("PageHeaderAvatar", html.text x)
    static member pageHeaderAvatar (node) = html.renderFragment("PageHeaderAvatar", node)
    static member pageHeaderAvatar (nodes) = html.renderFragment("PageHeaderAvatar", fragment { yield! nodes })
    static member pageHeaderTitle (x: string) = html.renderFragment("PageHeaderTitle", html.text x)
    static member pageHeaderTitle (node) = html.renderFragment("PageHeaderTitle", node)
    static member pageHeaderTitle (nodes) = html.renderFragment("PageHeaderTitle", fragment { yield! nodes })
    static member pageHeaderSubtitle (x: string) = html.renderFragment("PageHeaderSubtitle", html.text x)
    static member pageHeaderSubtitle (node) = html.renderFragment("PageHeaderSubtitle", node)
    static member pageHeaderSubtitle (nodes) = html.renderFragment("PageHeaderSubtitle", fragment { yield! nodes })
    static member pageHeaderTags (x: string) = html.renderFragment("PageHeaderTags", html.text x)
    static member pageHeaderTags (node) = html.renderFragment("PageHeaderTags", node)
    static member pageHeaderTags (nodes) = html.renderFragment("PageHeaderTags", fragment { yield! nodes })
    static member pageHeaderExtra (x: string) = html.renderFragment("PageHeaderExtra", html.text x)
    static member pageHeaderExtra (node) = html.renderFragment("PageHeaderExtra", node)
    static member pageHeaderExtra (nodes) = html.renderFragment("PageHeaderExtra", fragment { yield! nodes })
                    

type pagination<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Pagination>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Pagination>() { yield! attrs }

    static member total (x: System.Int32) = "Total" => x
    static member defaultCurrent (x: System.Int32) = "DefaultCurrent" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member current (x: System.Int32) = "Current" => x
    static member defaultPageSize (x: System.Int32) = "DefaultPageSize" => x
    static member pageSize (x: System.Int32) = "PageSize" => x
    static member onChange fn = html.callback<AntDesign.PaginationEventArgs>("OnChange", fn)
    static member hideOnSinglePage (x: System.Boolean) = "HideOnSinglePage" => x
    static member showSizeChanger (x: System.Boolean) = "ShowSizeChanger" => x
    static member pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x
    static member onShowSizeChange fn = html.callback<AntDesign.PaginationEventArgs>("OnShowSizeChange", fn)
    static member showQuickJumper (x: System.Boolean) = "ShowQuickJumper" => x
    static member goButton (x: string) = html.renderFragment("GoButton", html.text x)
    static member goButton (node) = html.renderFragment("GoButton", node)
    static member goButton (nodes) = html.renderFragment("GoButton", fragment { yield! nodes })
    static member showTitle (x: System.Boolean) = "ShowTitle" => x
    static member showTotal (x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = "ShowTotal" => x
    static member size (x: System.String) = "Size" => x
    static member responsive (x: System.Boolean) = "Responsive" => x
    static member simple (x: System.Boolean) = "Simple" => x
    static member locale (x: AntDesign.PaginationLocale) = "Locale" => x
    static member itemRender (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("ItemRender", render)
    static member showLessItems (x: System.Boolean) = "ShowLessItems" => x
    static member showPrevNextJumpers (x: System.Boolean) = "ShowPrevNextJumpers" => x
    static member direction (x: System.String) = "Direction" => x
    static member prevIcon (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("PrevIcon", render)
    static member nextIcon (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("NextIcon", render)
    static member jumpPrevIcon (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("JumpPrevIcon", render)
    static member jumpNextIcon (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("JumpNextIcon", render)
    static member totalBoundaryShowSizeChanger (x: System.Int32) = "TotalBoundaryShowSizeChanger" => x
    static member unmatchedAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x
                    

type paginationOptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.PaginationOptions>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.PaginationOptions>() { yield! attrs }

    static member isSmall (x: System.Boolean) = "IsSmall" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member rootPrefixCls (x: System.String) = "RootPrefixCls" => x
    static member changeSize fn = html.callback<System.Int32>("ChangeSize", fn)
    static member current (x: System.Int32) = "Current" => x
    static member pageSize (x: System.Int32) = "PageSize" => x
    static member pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x
    static member quickGo fn = html.callback<System.Int32>("QuickGo", fn)
    static member goButton (x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = "GoButton" => x
                    

type progress<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Progress>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Progress>() { yield! attrs }

    static member size (x: AntDesign.ProgressSize) = "Size" => x
    static member type' (x: AntDesign.ProgressType) = "Type" => x
    static member format (fn) = "Format" => (System.Func<System.Double, System.String>fn)
    static member percent (x: System.Double) = "Percent" => x
    static member showInfo (x: System.Boolean) = "ShowInfo" => x
    static member status (x: AntDesign.ProgressStatus) = "Status" => x
    static member strokeLinecap (x: AntDesign.ProgressStrokeLinecap) = "StrokeLinecap" => x
    static member successPercent (x: System.Double) = "SuccessPercent" => x
    static member trailColor (x: System.String) = "TrailColor" => x
    static member strokeWidth (x: System.Int32) = "StrokeWidth" => x
    static member strokeColor (x: OneOf.OneOf<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>) = "StrokeColor" => x
    static member steps (x: System.Int32) = "Steps" => x
    static member width (x: System.Int32) = "Width" => x
    static member gapDegree (x: System.Int32) = "GapDegree" => x
    static member gapPosition (x: AntDesign.ProgressGapPosition) = "GapPosition" => x
                    

type radio<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Radio<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Radio<'TValue>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Radio<'TValue>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Radio<'TValue>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Radio<'TValue>>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member value (x: 'TValue) = "Value" => x
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member radioButton (x: System.Boolean) = "RadioButton" => x
    static member checked' (x: System.Boolean) = "Checked" => x
    static member checked'' (value: IStore<System.Boolean>) = html.bind("Checked", value)
    static member checked'' (value: cval<System.Boolean>) = html.bind("Checked", value)
    static member checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = html.bind("Checked", valueFn)
    static member defaultChecked (x: System.Boolean) = "DefaultChecked" => x
    static member checkedChanged fn = html.callback<System.Boolean>("CheckedChanged", fn)
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member checkedChange fn = html.callback<System.Boolean>("CheckedChange", fn)
                    

type rate<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Rate>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Rate>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Rate>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Rate>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Rate>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member allowClear (x: System.Boolean) = "AllowClear" => x
    static member allowHalf (x: System.Boolean) = "AllowHalf" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member character (render: AntDesign.RateItemRenderContext -> NodeRenderFragment) = html.renderFragment("Character", render)
    static member count (x: System.Int32) = "Count" => x
    static member value (x: System.Decimal) = "Value" => x
    static member value' (value: IStore<System.Decimal>) = html.bind("Value", value)
    static member value' (value: cval<System.Decimal>) = html.bind("Value", value)
    static member value' (valueFn: System.Decimal * (System.Decimal -> unit)) = html.bind("Value", valueFn)
    static member valueChanged fn = html.callback<System.Decimal>("ValueChanged", fn)
    static member defaultValue (x: System.Decimal) = "DefaultValue" => x
    static member tooltips (x: System.String[]) = "Tooltips" => x
    static member onBlur fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    static member onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
                    

type rateItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.RateItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.RateItem>() { yield! attrs }

    static member allowHalf (x: System.Boolean) = "AllowHalf" => x
    static member onItemHover fn = html.callback<System.Boolean>("OnItemHover", fn)
    static member onItemClick fn = html.callback<System.Boolean>("OnItemClick", fn)
    static member tooltip (x: System.String) = "Tooltip" => x
    static member indexOfGroup (x: System.Int32) = "IndexOfGroup" => x
    static member hoverValue (x: System.Int32) = "HoverValue" => x
    static member hasHalf (x: System.Boolean) = "HasHalf" => x
    static member isFocused (x: System.Boolean) = "IsFocused" => x
                    

type result<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Result>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Result>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Result>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Result>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Result>(){ x }
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member subTitle (x: System.String) = "SubTitle" => x
    static member subTitleTemplate (x: string) = html.renderFragment("SubTitleTemplate", html.text x)
    static member subTitleTemplate (node) = html.renderFragment("SubTitleTemplate", node)
    static member subTitleTemplate (nodes) = html.renderFragment("SubTitleTemplate", fragment { yield! nodes })
    static member extra (x: string) = html.renderFragment("Extra", html.text x)
    static member extra (node) = html.renderFragment("Extra", node)
    static member extra (nodes) = html.renderFragment("Extra", fragment { yield! nodes })
    static member status (x: System.String) = "Status" => x
    static member icon (x: System.String) = "Icon" => x
    static member isShowIcon (x: System.Boolean) = "IsShowIcon" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type selectOption<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SelectOption<'TItemValue, 'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SelectOption<'TItemValue, 'TItem>>() { yield! attrs }

    static member disabled (x: System.Boolean) = "Disabled" => x
    static member label (x: System.String) = "Label" => x
    static member value (x: 'TItemValue) = "Value" => x
                    

type simpleSelectOption<'FunBlazorGeneric> =
    inherit selectOption<'FunBlazorGeneric, System.String, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SimpleSelectOption>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SimpleSelectOption>() { yield! attrs }


                    

type skeleton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Skeleton>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Skeleton>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Skeleton>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Skeleton>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Skeleton>(){ x }
    static member active (x: System.Boolean) = "Active" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member title (x: System.Boolean) = "Title" => x
    static member titleWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "TitleWidth" => x
    static member avatar (x: System.Boolean) = "Avatar" => x
    static member avatarSize (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "AvatarSize" => x
    static member avatarShape (x: System.String) = "AvatarShape" => x
    static member paragraph (x: System.Boolean) = "Paragraph" => x
    static member paragraphRows (x: System.Nullable<System.Int32>) = "ParagraphRows" => x
    static member paragraphWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IList<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = "ParagraphWidth" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type skeletonElement<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SkeletonElement>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SkeletonElement>() { yield! attrs }

    static member active (x: System.Boolean) = "Active" => x
    static member type' (x: System.String) = "Type" => x
    static member size (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Size" => x
    static member shape (x: System.String) = "Shape" => x
                    

type space<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Space>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Space>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Space>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Space>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Space>(){ x }
    static member align (x: System.String) = "Align" => x
    static member direction (x: AntDesign.DirectionVHType) = "Direction" => x
    static member size (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Size" => x
    static member wrap (x: System.Boolean) = "Wrap" => x
    static member split (x: string) = html.renderFragment("Split", html.text x)
    static member split (node) = html.renderFragment("Split", node)
    static member split (nodes) = html.renderFragment("Split", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type spaceItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SpaceItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SpaceItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.SpaceItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.SpaceItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.SpaceItem>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type spin<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Spin>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Spin>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Spin>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Spin>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Spin>(){ x }
    static member size (x: System.String) = "Size" => x
    static member tip (x: System.String) = "Tip" => x
    static member delay (x: System.Int32) = "Delay" => x
    static member spinning (x: System.Boolean) = "Spinning" => x
    static member wrapperClassName (x: System.String) = "WrapperClassName" => x
    static member indicator (x: string) = html.renderFragment("Indicator", html.text x)
    static member indicator (node) = html.renderFragment("Indicator", node)
    static member indicator (nodes) = html.renderFragment("Indicator", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type statisticComponentBase<'FunBlazorGeneric, 'T> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.StatisticComponentBase<'T>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.StatisticComponentBase<'T>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.StatisticComponentBase<'T>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.StatisticComponentBase<'T>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.StatisticComponentBase<'T>>(){ x }
    static member prefix (x: System.String) = "Prefix" => x
    static member prefixTemplate (x: string) = html.renderFragment("PrefixTemplate", html.text x)
    static member prefixTemplate (node) = html.renderFragment("PrefixTemplate", node)
    static member prefixTemplate (nodes) = html.renderFragment("PrefixTemplate", fragment { yield! nodes })
    static member suffix (x: System.String) = "Suffix" => x
    static member suffixTemplate (x: string) = html.renderFragment("SuffixTemplate", html.text x)
    static member suffixTemplate (node) = html.renderFragment("SuffixTemplate", node)
    static member suffixTemplate (nodes) = html.renderFragment("SuffixTemplate", fragment { yield! nodes })
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member value (x: 'T) = "Value" => x
    static member valueStyle (x: System.String) = "ValueStyle" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type countDown<'FunBlazorGeneric> =
    inherit statisticComponentBase<'FunBlazorGeneric, System.DateTime>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.CountDown>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CountDown>() { yield! attrs }

    static member format (x: System.String) = "Format" => x
    static member onFinish fn = html.callback<unit>("OnFinish", fn)
                    

type statistic<'FunBlazorGeneric, 'TValue> =
    inherit statisticComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Statistic<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Statistic<'TValue>>() { yield! attrs }

    static member decimalSeparator (x: System.String) = "DecimalSeparator" => x
    static member groupSeparator (x: System.String) = "GroupSeparator" => x
    static member precision (x: System.Int32) = "Precision" => x
                    

type step<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Step>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Step>() { yield! attrs }

    static member icon (x: System.String) = "Icon" => x
    static member status (x: System.String) = "Status" => x
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member subtitle (x: System.String) = "Subtitle" => x
    static member subtitleTemplate (x: string) = html.renderFragment("SubtitleTemplate", html.text x)
    static member subtitleTemplate (node) = html.renderFragment("SubtitleTemplate", node)
    static member subtitleTemplate (nodes) = html.renderFragment("SubtitleTemplate", fragment { yield! nodes })
    static member description (x: System.String) = "Description" => x
    static member descriptionTemplate (x: string) = html.renderFragment("DescriptionTemplate", html.text x)
    static member descriptionTemplate (node) = html.renderFragment("DescriptionTemplate", node)
    static member descriptionTemplate (nodes) = html.renderFragment("DescriptionTemplate", fragment { yield! nodes })
    static member onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member disabled (x: System.Boolean) = "Disabled" => x
                    

type steps<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Steps>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Steps>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Steps>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Steps>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Steps>(){ x }
    static member current (x: System.Int32) = "Current" => x
    static member percent (x: System.Nullable<System.Double>) = "Percent" => x
    static member progressDot (x: string) = html.renderFragment("ProgressDot", html.text x)
    static member progressDot (node) = html.renderFragment("ProgressDot", node)
    static member progressDot (nodes) = html.renderFragment("ProgressDot", fragment { yield! nodes })
    static member showProgressDot (x: System.Boolean) = "ShowProgressDot" => x
    static member direction (x: System.String) = "Direction" => x
    static member labelPlacement (x: System.String) = "LabelPlacement" => x
    static member type' (x: System.String) = "Type" => x
    static member size (x: System.String) = "Size" => x
    static member startIndex (x: System.Int32) = "StartIndex" => x
    static member status (x: System.String) = "Status" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member onChange fn = html.callback<System.Int32>("OnChange", fn)
                    

type table<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Table<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Table<'TItem>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Table<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Table<'TItem>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Table<'TItem>>(){ x }
    static member renderMode (x: AntDesign.RenderMode) = "RenderMode" => x
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member childContent (render: 'TItem -> NodeRenderFragment) = html.renderFragment("ChildContent", render)
    static member rowTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("RowTemplate", render)
    static member expandTemplate (render: AntDesign.TableModels.RowData<'TItem> -> NodeRenderFragment) = html.renderFragment("ExpandTemplate", render)
    static member defaultExpandAllRows (x: System.Boolean) = "DefaultExpandAllRows" => x
    static member rowExpandable (fn) = "RowExpandable" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>fn)
    static member treeChildren (fn) = "TreeChildren" => (System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>fn)
    static member onChange fn = html.callback<AntDesign.TableModels.QueryModel<'TItem>>("OnChange", fn)
    static member onRow (fn) = "OnRow" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.Dictionary<System.String, System.Object>>fn)
    static member onHeaderRow (fn) = "OnHeaderRow" => (System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>fn)
    static member loading (x: System.Boolean) = "Loading" => x
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member footer (x: System.String) = "Footer" => x
    static member footerTemplate (x: string) = html.renderFragment("FooterTemplate", html.text x)
    static member footerTemplate (node) = html.renderFragment("FooterTemplate", node)
    static member footerTemplate (nodes) = html.renderFragment("FooterTemplate", fragment { yield! nodes })
    static member size (x: AntDesign.TableSize) = "Size" => x
    static member locale (x: AntDesign.TableLocale) = "Locale" => x
    static member bordered (x: System.Boolean) = "Bordered" => x
    static member scrollX (x: System.String) = "ScrollX" => x
    static member scrollY (x: System.String) = "ScrollY" => x
    static member scrollBarWidth (x: System.Int32) = "ScrollBarWidth" => x
    static member indentSize (x: System.Int32) = "IndentSize" => x
    static member expandIconColumnIndex (x: System.Int32) = "ExpandIconColumnIndex" => x
    static member rowClassName (fn) = "RowClassName" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>fn)
    static member expandedRowClassName (fn) = "ExpandedRowClassName" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>fn)
    static member onExpand fn = html.callback<AntDesign.TableModels.RowData<'TItem>>("OnExpand", fn)
    static member sortDirections (x: AntDesign.SortDirection[]) = "SortDirections" => x
    static member tableLayout (x: System.String) = "TableLayout" => x
    static member onRowClick fn = html.callback<AntDesign.TableModels.RowData<'TItem>>("OnRowClick", fn)
    static member remoteDataSource (x: System.Boolean) = "RemoteDataSource" => x
    static member responsive (x: System.Boolean) = "Responsive" => x
    static member hidePagination (x: System.Boolean) = "HidePagination" => x
    static member paginationPosition (x: System.String) = "PaginationPosition" => x
    static member paginationTemplate (x: string) = html.renderFragment("PaginationTemplate", html.text x)
    static member paginationTemplate (node) = html.renderFragment("PaginationTemplate", node)
    static member paginationTemplate (nodes) = html.renderFragment("PaginationTemplate", fragment { yield! nodes })
    static member total (x: System.Int32) = "Total" => x
    static member total' (value: IStore<System.Int32>) = html.bind("Total", value)
    static member total' (value: cval<System.Int32>) = html.bind("Total", value)
    static member total' (valueFn: System.Int32 * (System.Int32 -> unit)) = html.bind("Total", valueFn)
    static member totalChanged fn = html.callback<System.Int32>("TotalChanged", fn)
    static member pageIndex (x: System.Int32) = "PageIndex" => x
    static member pageIndex' (value: IStore<System.Int32>) = html.bind("PageIndex", value)
    static member pageIndex' (value: cval<System.Int32>) = html.bind("PageIndex", value)
    static member pageIndex' (valueFn: System.Int32 * (System.Int32 -> unit)) = html.bind("PageIndex", valueFn)
    static member pageIndexChanged fn = html.callback<System.Int32>("PageIndexChanged", fn)
    static member pageSize (x: System.Int32) = "PageSize" => x
    static member pageSize' (value: IStore<System.Int32>) = html.bind("PageSize", value)
    static member pageSize' (value: cval<System.Int32>) = html.bind("PageSize", value)
    static member pageSize' (valueFn: System.Int32 * (System.Int32 -> unit)) = html.bind("PageSize", valueFn)
    static member pageSizeChanged fn = html.callback<System.Int32>("PageSizeChanged", fn)
    static member onPageIndexChange fn = html.callback<AntDesign.PaginationEventArgs>("OnPageIndexChange", fn)
    static member onPageSizeChange fn = html.callback<AntDesign.PaginationEventArgs>("OnPageSizeChange", fn)
    static member selectedRows (x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedRows" => x
    static member selectedRows' (value: IStore<System.Collections.Generic.IEnumerable<'TItem>>) = html.bind("SelectedRows", value)
    static member selectedRows' (value: cval<System.Collections.Generic.IEnumerable<'TItem>>) = html.bind("SelectedRows", value)
    static member selectedRows' (valueFn: System.Collections.Generic.IEnumerable<'TItem> * (System.Collections.Generic.IEnumerable<'TItem> -> unit)) = html.bind("SelectedRows", valueFn)
    static member selectedRowsChanged fn = html.callback<System.Collections.Generic.IEnumerable<'TItem>>("SelectedRowsChanged", fn)
                    

type reuseTabs<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ReuseTabs>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ReuseTabs>() { yield! attrs }

    static member tabPaneClass (x: System.String) = "TabPaneClass" => x
    static member draggable (x: System.Boolean) = "Draggable" => x
    static member size (x: AntDesign.TabSize) = "Size" => x
    static member body (render: AntDesign.ReuseTabsPageItem -> NodeRenderFragment) = html.renderFragment("Body", render)
    static member locale (x: AntDesign.ReuseTabsLocale) = "Locale" => x
                    

type tabPane<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TabPane>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TabPane>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.TabPane>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.TabPane>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.TabPane>(){ x }
    static member forceRender (x: System.Boolean) = "ForceRender" => x
    static member key (x: System.String) = "Key" => x
    static member tab (x: System.String) = "Tab" => x
    static member tabTemplate (x: string) = html.renderFragment("TabTemplate", html.text x)
    static member tabTemplate (node) = html.renderFragment("TabTemplate", node)
    static member tabTemplate (nodes) = html.renderFragment("TabTemplate", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member tabContextMenu (x: string) = html.renderFragment("TabContextMenu", html.text x)
    static member tabContextMenu (node) = html.renderFragment("TabContextMenu", node)
    static member tabContextMenu (nodes) = html.renderFragment("TabContextMenu", fragment { yield! nodes })
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member closable (x: System.Boolean) = "Closable" => x
                    

type tabs<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Tabs>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Tabs>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Tabs>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Tabs>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Tabs>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member activeKey (x: System.String) = "ActiveKey" => x
    static member activeKey' (value: IStore<System.String>) = html.bind("ActiveKey", value)
    static member activeKey' (value: cval<System.String>) = html.bind("ActiveKey", value)
    static member activeKey' (valueFn: System.String * (System.String -> unit)) = html.bind("ActiveKey", valueFn)
    static member activeKeyChanged fn = html.callback<System.String>("ActiveKeyChanged", fn)
    static member animated (x: System.Boolean) = "Animated" => x
    static member inkBarAnimated (x: System.Boolean) = "InkBarAnimated" => x
    static member renderTabBar (x: System.Object) = "RenderTabBar" => x
    static member defaultActiveKey (x: System.String) = "DefaultActiveKey" => x
    static member hideAdd (x: System.Boolean) = "HideAdd" => x
    static member size (x: AntDesign.TabSize) = "Size" => x
    static member tabBarExtraContent (x: string) = html.renderFragment("TabBarExtraContent", html.text x)
    static member tabBarExtraContent (node) = html.renderFragment("TabBarExtraContent", node)
    static member tabBarExtraContent (nodes) = html.renderFragment("TabBarExtraContent", fragment { yield! nodes })
    static member tabBarExtraContentLeft (x: string) = html.renderFragment("TabBarExtraContentLeft", html.text x)
    static member tabBarExtraContentLeft (node) = html.renderFragment("TabBarExtraContentLeft", node)
    static member tabBarExtraContentLeft (nodes) = html.renderFragment("TabBarExtraContentLeft", fragment { yield! nodes })
    static member tabBarExtraContentRight (x: string) = html.renderFragment("TabBarExtraContentRight", html.text x)
    static member tabBarExtraContentRight (node) = html.renderFragment("TabBarExtraContentRight", node)
    static member tabBarExtraContentRight (nodes) = html.renderFragment("TabBarExtraContentRight", fragment { yield! nodes })
    static member tabBarGutter (x: System.Int32) = "TabBarGutter" => x
    static member tabBarStyle (x: System.String) = "TabBarStyle" => x
    static member tabPosition (x: AntDesign.TabPosition) = "TabPosition" => x
    static member type' (x: AntDesign.TabType) = "Type" => x
    static member onChange fn = html.callback<System.String>("OnChange", fn)
    static member onEdit (fn) = "OnEdit" => (System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>fn)
    static member onClose fn = html.callback<System.String>("OnClose", fn)
    static member onAddClick fn = html.callback<unit>("OnAddClick", fn)
    static member afterTabCreated fn = html.callback<System.String>("AfterTabCreated", fn)
    static member onTabClick fn = html.callback<System.String>("OnTabClick", fn)
    static member draggable (x: System.Boolean) = "Draggable" => x
    static member centered (x: System.Boolean) = "Centered" => x
                    

type tag<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Tag>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Tag>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Tag>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Tag>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Tag>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member closable (x: System.Boolean) = "Closable" => x
    static member checkable (x: System.Boolean) = "Checkable" => x
    static member checked' (x: System.Boolean) = "Checked" => x
    static member checked'' (value: IStore<System.Boolean>) = html.bind("Checked", value)
    static member checked'' (value: cval<System.Boolean>) = html.bind("Checked", value)
    static member checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = html.bind("Checked", valueFn)
    static member checkedChanged fn = html.callback<System.Boolean>("CheckedChanged", fn)
    static member color (x: System.String) = "Color" => x
    static member presetColor (x: System.Nullable<AntDesign.PresetColor>) = "PresetColor" => x
    static member icon (x: System.String) = "Icon" => x
    static member noAnimation (x: System.Boolean) = "NoAnimation" => x
    static member onClose fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClose", fn)
    static member onClosing fn = html.callback<AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>("OnClosing", fn)
    static member onClick fn = html.callback<unit>("OnClick", fn)
    static member visible (x: System.Boolean) = "Visible" => x
                    

type timeline<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Timeline>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Timeline>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Timeline>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Timeline>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Timeline>(){ x }
    static member mode (x: System.Nullable<AntDesign.TimelineMode>) = "Mode" => x
    static member reverse (x: System.Boolean) = "Reverse" => x
    static member pending (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Pending" => x
    static member pendingDot (x: string) = html.renderFragment("PendingDot", html.text x)
    static member pendingDot (node) = html.renderFragment("PendingDot", node)
    static member pendingDot (nodes) = html.renderFragment("PendingDot", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type timelineItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TimelineItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TimelineItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.TimelineItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.TimelineItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.TimelineItem>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member dot (x: string) = html.renderFragment("Dot", html.text x)
    static member dot (node) = html.renderFragment("Dot", node)
    static member dot (nodes) = html.renderFragment("Dot", fragment { yield! nodes })
    static member color (x: System.String) = "Color" => x
    static member label (x: System.String) = "Label" => x
                    

type transfer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Transfer>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Transfer>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Transfer>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Transfer>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Transfer>(){ x }
    static member dataSource (x: System.Collections.Generic.IList<AntDesign.TransferItem>) = "DataSource" => x
    static member titles (x: System.String[]) = "Titles" => x
    static member operations (x: System.String[]) = "Operations" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member showSearch (x: System.Boolean) = "ShowSearch" => x
    static member showSelectAll (x: System.Boolean) = "ShowSelectAll" => x
    static member targetKeys (x: System.String[]) = "TargetKeys" => x
    static member selectedKeys (x: System.String[]) = "SelectedKeys" => x
    static member onChange fn = html.callback<AntDesign.TransferChangeArgs>("OnChange", fn)
    static member onScroll fn = html.callback<AntDesign.TransferScrollArgs>("OnScroll", fn)
    static member onSearch fn = html.callback<AntDesign.TransferSearchArgs>("OnSearch", fn)
    static member onSelectChange fn = html.callback<AntDesign.TransferSelectChangeArgs>("OnSelectChange", fn)
    static member render (fn) = "Render" => (System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>fn)
    static member locale (x: AntDesign.TransferLocale) = "Locale" => x
    static member footer (x: System.String) = "Footer" => x
    static member footerTemplate (x: string) = html.renderFragment("FooterTemplate", html.text x)
    static member footerTemplate (node) = html.renderFragment("FooterTemplate", node)
    static member footerTemplate (nodes) = html.renderFragment("FooterTemplate", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type tree<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Tree<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Tree<'TItem>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Tree<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Tree<'TItem>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Tree<'TItem>>(){ x }
    static member showExpand (x: System.Boolean) = "ShowExpand" => x
    static member showLine (x: System.Boolean) = "ShowLine" => x
    static member showIcon (x: System.Boolean) = "ShowIcon" => x
    static member blockNode (x: System.Boolean) = "BlockNode" => x
    static member draggable (x: System.Boolean) = "Draggable" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member showLeafIcon (x: System.Boolean) = "ShowLeafIcon" => x
    static member switcherIcon (x: System.String) = "SwitcherIcon" => x
    static member nodes (x: string) = html.renderFragment("Nodes", html.text x)
    static member nodes (node) = html.renderFragment("Nodes", node)
    static member nodes (nodes) = html.renderFragment("Nodes", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member selectable (x: System.Boolean) = "Selectable" => x
    static member multiple (x: System.Boolean) = "Multiple" => x
    static member defaultSelectedKeys (x: System.String[]) = "DefaultSelectedKeys" => x
    static member selectedKey (x: System.String) = "SelectedKey" => x
    static member selectedKey' (value: IStore<System.String>) = html.bind("SelectedKey", value)
    static member selectedKey' (value: cval<System.String>) = html.bind("SelectedKey", value)
    static member selectedKey' (valueFn: System.String * (System.String -> unit)) = html.bind("SelectedKey", valueFn)
    static member selectedKeyChanged fn = html.callback<System.String>("SelectedKeyChanged", fn)
    static member selectedNode (x: AntDesign.TreeNode<'TItem>) = "SelectedNode" => x
    static member selectedNode' (value: IStore<AntDesign.TreeNode<'TItem>>) = html.bind("SelectedNode", value)
    static member selectedNode' (value: cval<AntDesign.TreeNode<'TItem>>) = html.bind("SelectedNode", value)
    static member selectedNode' (valueFn: AntDesign.TreeNode<'TItem> * (AntDesign.TreeNode<'TItem> -> unit)) = html.bind("SelectedNode", valueFn)
    static member selectedNodeChanged fn = html.callback<AntDesign.TreeNode<'TItem>>("SelectedNodeChanged", fn)
    static member selectedData (x: 'TItem) = "SelectedData" => x
    static member selectedData' (value: IStore<'TItem>) = html.bind("SelectedData", value)
    static member selectedData' (value: cval<'TItem>) = html.bind("SelectedData", value)
    static member selectedData' (valueFn: 'TItem * ('TItem -> unit)) = html.bind("SelectedData", valueFn)
    static member selectedDataChanged fn = html.callback<'TItem>("SelectedDataChanged", fn)
    static member selectedKeys (x: System.String[]) = "SelectedKeys" => x
    static member selectedKeys' (value: IStore<System.String[]>) = html.bind("SelectedKeys", value)
    static member selectedKeys' (value: cval<System.String[]>) = html.bind("SelectedKeys", value)
    static member selectedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("SelectedKeys", valueFn)
    static member selectedKeysChanged fn = html.callback<System.String[]>("SelectedKeysChanged", fn)
    static member selectedNodes (x: AntDesign.TreeNode<'TItem>[]) = "SelectedNodes" => x
    static member selectedDatas (x: 'TItem[]) = "SelectedDatas" => x
    static member checkable (x: System.Boolean) = "Checkable" => x
    static member checkStrictly (x: System.Boolean) = "CheckStrictly" => x
    static member checkedKeys (x: System.String[]) = "CheckedKeys" => x
    static member checkedKeys' (value: IStore<System.String[]>) = html.bind("CheckedKeys", value)
    static member checkedKeys' (value: cval<System.String[]>) = html.bind("CheckedKeys", value)
    static member checkedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("CheckedKeys", valueFn)
    static member checkedKeysChanged fn = html.callback<System.String[]>("CheckedKeysChanged", fn)
    static member defaultCheckedKeys (x: System.String[]) = "DefaultCheckedKeys" => x
    static member searchValue (x: System.String) = "SearchValue" => x
    static member searchExpression (fn) = "SearchExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn)
    static member matchedStyle (x: System.String) = "MatchedStyle" => x
    static member matchedClass (x: System.String) = "MatchedClass" => x
    static member dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member titleExpression (fn) = "TitleExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn)
    static member keyExpression (fn) = "KeyExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn)
    static member iconExpression (fn) = "IconExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn)
    static member isLeafExpression (fn) = "IsLeafExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn)
    static member childrenExpression (fn) = "ChildrenExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IList<'TItem>>fn)
    static member disabledExpression (fn) = "DisabledExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn)
    static member onNodeLoadDelayAsync fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnNodeLoadDelayAsync", fn)
    static member onClick fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnClick", fn)
    static member onDblClick fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDblClick", fn)
    static member onContextMenu fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnContextMenu", fn)
    static member onCheck fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnCheck", fn)
    static member onSelect fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnSelect", fn)
    static member onUnSelect fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnUnSelect", fn)
    static member onExpandChanged fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnExpandChanged", fn)
    static member indentTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("IndentTemplate", render)
    static member titleTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("TitleTemplate", render)
    static member titleIconTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("TitleIconTemplate", render)
    static member switcherIconTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("SwitcherIconTemplate", render)
    static member onDragStart fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDragStart", fn)
    static member onDragEnter fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDragEnter", fn)
    static member onDragLeave fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDragLeave", fn)
    static member onDrop fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDrop", fn)
    static member onDragEnd fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDragEnd", fn)
    static member defaultExpandAll (x: System.Boolean) = "DefaultExpandAll" => x
    static member defaultExpandParent (x: System.Boolean) = "DefaultExpandParent" => x
    static member defaultExpandedKeys (x: System.String[]) = "DefaultExpandedKeys" => x
    static member expandedKeys (x: System.String[]) = "ExpandedKeys" => x
    static member expandedKeys' (value: IStore<System.String[]>) = html.bind("ExpandedKeys", value)
    static member expandedKeys' (value: cval<System.String[]>) = html.bind("ExpandedKeys", value)
    static member expandedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("ExpandedKeys", valueFn)
    static member expandedKeysChanged fn = html.callback<System.String[]>("ExpandedKeysChanged", fn)
    static member onExpand fn = html.callback<System.ValueTuple<System.String[], AntDesign.TreeNode<'TItem>, System.Boolean>>("OnExpand", fn)
    static member autoExpandParent (x: System.Boolean) = "AutoExpandParent" => x
                    

type directoryTree<'FunBlazorGeneric, 'TItem> =
    inherit tree<'FunBlazorGeneric, 'TItem>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.DirectoryTree<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DirectoryTree<'TItem>>() { yield! attrs }


                    

type treeNode<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TreeNode<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeNode<'TItem>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.TreeNode<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.TreeNode<'TItem>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.TreeNode<'TItem>>(){ x }
    static member nodes (x: string) = html.renderFragment("Nodes", html.text x)
    static member nodes (node) = html.renderFragment("Nodes", node)
    static member nodes (nodes) = html.renderFragment("Nodes", fragment { yield! nodes })
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member key (x: System.String) = "Key" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member selected (x: System.Boolean) = "Selected" => x
    static member loading (x: System.Boolean) = "Loading" => x
    static member isLeaf (x: System.Boolean) = "IsLeaf" => x
    static member expanded (x: System.Boolean) = "Expanded" => x
    static member checked' (x: System.Boolean) = "Checked" => x
    static member indeterminate (x: System.Boolean) = "Indeterminate" => x
    static member disableCheckbox (x: System.Boolean) = "DisableCheckbox" => x
    static member draggable (x: System.Boolean) = "Draggable" => x
    static member icon (x: System.String) = "Icon" => x
    static member iconTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("IconTemplate", render)
    static member switcherIcon (x: System.String) = "SwitcherIcon" => x
    static member switcherIconTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("SwitcherIconTemplate", render)
    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member dataItem (x: 'TItem) = "DataItem" => x
                    

type upload<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Upload>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Upload>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Upload>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Upload>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Upload>(){ x }
    static member beforeUpload (fn) = "BeforeUpload" => (System.Func<AntDesign.UploadFileItem, System.Boolean>fn)
    static member beforeAllUploadAsync (fn) = "BeforeAllUploadAsync" => (System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>fn)
    static member beforeAllUpload (fn) = "BeforeAllUpload" => (System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Boolean>fn)
    static member name (x: System.String) = "Name" => x
    static member action (x: System.String) = "Action" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member data (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x
    static member listType (x: System.String) = "ListType" => x
    static member directory (x: System.Boolean) = "Directory" => x
    static member multiple (x: System.Boolean) = "Multiple" => x
    static member accept (x: System.String) = "Accept" => x
    static member showUploadList (x: System.Boolean) = "ShowUploadList" => x
    static member fileList (x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "FileList" => x
    static member fileList' (value: IStore<System.Collections.Generic.List<AntDesign.UploadFileItem>>) = html.bind("FileList", value)
    static member fileList' (value: cval<System.Collections.Generic.List<AntDesign.UploadFileItem>>) = html.bind("FileList", value)
    static member fileList' (valueFn: System.Collections.Generic.List<AntDesign.UploadFileItem> * (System.Collections.Generic.List<AntDesign.UploadFileItem> -> unit)) = html.bind("FileList", valueFn)
    static member locale (x: AntDesign.UploadLocale) = "Locale" => x
    static member fileListChanged fn = html.callback<System.Collections.Generic.List<AntDesign.UploadFileItem>>("FileListChanged", fn)
    static member defaultFileList (x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "DefaultFileList" => x
    static member headers (x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x
    static member onSingleCompleted fn = html.callback<AntDesign.UploadInfo>("OnSingleCompleted", fn)
    static member onCompleted fn = html.callback<AntDesign.UploadInfo>("OnCompleted", fn)
    static member onChange fn = html.callback<AntDesign.UploadInfo>("OnChange", fn)
    static member onRemove (fn) = "OnRemove" => (System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>fn)
    static member onPreview fn = html.callback<AntDesign.UploadFileItem>("OnPreview", fn)
    static member onDownload fn = html.callback<AntDesign.UploadFileItem>("OnDownload", fn)
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member showButton (x: System.Boolean) = "ShowButton" => x
    static member drag (x: System.Boolean) = "Drag" => x
    static member method (x: System.String) = "Method" => x
                    

type breadcrumbItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.BreadcrumbItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.BreadcrumbItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.BreadcrumbItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.BreadcrumbItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.BreadcrumbItem>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member overlay (x: string) = html.renderFragment("Overlay", html.text x)
    static member overlay (node) = html.renderFragment("Overlay", node)
    static member overlay (nodes) = html.renderFragment("Overlay", fragment { yield! nodes })
    static member href (x: System.String) = "Href" => x
                    

type calendarHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.CalendarHeader>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CalendarHeader>() { yield! attrs }


                    

type cardMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.CardMeta>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CardMeta>() { yield! attrs }

    static member title (x: System.String) = "Title" => x
    static member titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member description (x: System.String) = "Description" => x
    static member descriptionTemplate (x: string) = html.renderFragment("DescriptionTemplate", html.text x)
    static member descriptionTemplate (node) = html.renderFragment("DescriptionTemplate", node)
    static member descriptionTemplate (nodes) = html.renderFragment("DescriptionTemplate", fragment { yield! nodes })
    static member avatar (x: System.String) = "Avatar" => x
    static member avatarTemplate (x: string) = html.renderFragment("AvatarTemplate", html.text x)
    static member avatarTemplate (node) = html.renderFragment("AvatarTemplate", node)
    static member avatarTemplate (nodes) = html.renderFragment("AvatarTemplate", fragment { yield! nodes })
                    

type antContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.AntContainer>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntContainer>() { yield! attrs }


                    

type template<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Template>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Template>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Template>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Template>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Template>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member if' (fn) = "If" => (System.Func<System.Boolean>fn)
                    

type emptyDefaultImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.EmptyDefaultImg>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.EmptyDefaultImg>() { yield! attrs }

    static member prefixCls (x: System.String) = "PrefixCls" => x
                    

type emptySimpleImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.EmptySimpleImg>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.EmptySimpleImg>() { yield! attrs }

    static member prefixCls (x: System.String) = "PrefixCls" => x
                    

type content<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Content>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Content>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Content>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Content>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Content>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type footer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Footer>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Footer>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Footer>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Footer>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Footer>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type header<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Header>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Header>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Header>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Header>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Header>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type layout<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Layout>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Layout>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Layout>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Layout>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Layout>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type menuDivider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.MenuDivider>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MenuDivider>() { yield! attrs }


                    

type paginationPager<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.PaginationPager>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.PaginationPager>() { yield! attrs }

    static member showTitle (x: System.Boolean) = "ShowTitle" => x
    static member page (x: System.Int32) = "Page" => x
    static member rootPrefixCls (x: System.String) = "RootPrefixCls" => x
    static member active (x: System.Boolean) = "Active" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member onClick fn = html.callback<System.Int32>("OnClick", fn)
    static member onKeyPress fn = html.callback<System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action>>("OnKeyPress", fn)
    static member itemRender (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("ItemRender", render)
    static member unmatchedAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x
                    
            
namespace rec AntDesign.DslInternals.Select.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type selectOptionGroup<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>() { yield! attrs }


                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type calendarPanelChooser<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.CalendarPanelChooser>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.CalendarPanelChooser>() { yield! attrs }

    static member calendar (x: AntDesign.Calendar) = "Calendar" => x
    static member onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn)
    static member pickerIndex (x: System.Int32) = "PickerIndex" => x
                    

type element<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.Element>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.Element>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Internal.Element>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Internal.Element>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Internal.Element>(){ x }
    static member htmlTag (x: System.String) = "HtmlTag" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member refChanged fn = html.callback<Microsoft.AspNetCore.Components.ElementReference>("RefChanged", fn)
    static member attributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x
                    

type overlay<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.Overlay>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.Overlay>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Internal.Overlay>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Internal.Overlay>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Internal.Overlay>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member onOverlayMouseEnter fn = html.callback<unit>("OnOverlayMouseEnter", fn)
    static member onOverlayMouseLeave fn = html.callback<unit>("OnOverlayMouseLeave", fn)
    static member onOverlayMouseUp fn = html.callback<unit>("OnOverlayMouseUp", fn)
    static member onShow fn = html.callback<unit>("OnShow", fn)
    static member onHide fn = html.callback<unit>("OnHide", fn)
    static member overlayChildPrefixCls (x: System.String) = "OverlayChildPrefixCls" => x
    static member hideMillisecondsDelay (x: System.Int32) = "HideMillisecondsDelay" => x
    static member waitForHideAnimMilliseconds (x: System.Int32) = "WaitForHideAnimMilliseconds" => x
    static member verticalOffset (x: System.Int32) = "VerticalOffset" => x
    static member horizontalOffset (x: System.Int32) = "HorizontalOffset" => x
    static member hiddenMode (x: System.Boolean) = "HiddenMode" => x
                    

type datePickerPanelChooser<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerPanelChooser<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerPanelChooser<'TValue>>() { yield! attrs }

    static member datePicker (x: AntDesign.DatePickerBase<'TValue>) = "DatePicker" => x
    static member onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn)
    static member pickerIndex (x: System.Int32) = "PickerIndex" => x
                    

type uploadButton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.UploadButton>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.UploadButton>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Internal.UploadButton>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Internal.UploadButton>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Internal.UploadButton>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member listType (x: System.String) = "ListType" => x
    static member showButton (x: System.Boolean) = "ShowButton" => x
    static member name (x: System.String) = "Name" => x
    static member directory (x: System.Boolean) = "Directory" => x
    static member multiple (x: System.Boolean) = "Multiple" => x
    static member accept (x: System.String) = "Accept" => x
    static member data (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x
    static member headers (x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x
    static member action (x: System.String) = "Action" => x
    static member method (x: System.String) = "Method" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
                    

type datePickerInput<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DatePickerInput>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerInput>() { yield! attrs }

    static member prefixCls (x: System.String) = "PrefixCls" => x
    static member size (x: System.String) = "Size" => x
    static member value (x: System.String) = "Value" => x
    static member placeholder (x: System.String) = "Placeholder" => x
    static member readOnly (x: System.Boolean) = "ReadOnly" => x
    static member isRange (x: System.Boolean) = "IsRange" => x
    static member disabled (x: System.Boolean) = "Disabled" => x
    static member autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member showSuffixIcon (x: System.Boolean) = "ShowSuffixIcon" => x
    static member showTime (x: System.Boolean) = "ShowTime" => x
    static member htmlInputSize (x: System.Int32) = "HtmlInputSize" => x
    static member suffixIcon (x: string) = html.renderFragment("SuffixIcon", html.text x)
    static member suffixIcon (node) = html.renderFragment("SuffixIcon", node)
    static member suffixIcon (nodes) = html.renderFragment("SuffixIcon", fragment { yield! nodes })
    static member onClick fn = html.callback<unit>("OnClick", fn)
    static member onfocus fn = html.callback<unit>("Onfocus", fn)
    static member onBlur fn = html.callback<unit>("OnBlur", fn)
    static member onfocusout fn = html.callback<unit>("Onfocusout", fn)
    static member onKeyUp fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyUp", fn)
    static member onKeyDown fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyDown", fn)
    static member onInput fn = html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInput", fn)
    static member allowClear (x: System.Boolean) = "AllowClear" => x
    static member onClickClear fn = html.callback<unit>("OnClickClear", fn)
                    

type dropdownGroupButton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.DropdownGroupButton>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DropdownGroupButton>() { yield! attrs }

    static member leftButton (x: string) = html.renderFragment("LeftButton", html.text x)
    static member leftButton (node) = html.renderFragment("LeftButton", node)
    static member leftButton (nodes) = html.renderFragment("LeftButton", fragment { yield! nodes })
    static member rightButton (x: string) = html.renderFragment("RightButton", html.text x)
    static member rightButton (node) = html.renderFragment("RightButton", node)
    static member rightButton (nodes) = html.renderFragment("RightButton", fragment { yield! nodes })
                    

type tableRow<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.TableRow<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.TableRow<'TItem>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.Internal.TableRow<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.Internal.TableRow<'TItem>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.Internal.TableRow<'TItem>>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    
            
namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type configProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ConfigProvider>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ConfigProvider>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.ConfigProvider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.ConfigProvider>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.ConfigProvider>(){ x }
    static member direction (x: System.String) = "Direction" => x
    static member form (x: AntDesign.FormConfig) = "Form" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type templateComponentBase<'FunBlazorGeneric, 'TComponentOptions> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TemplateComponentBase<'TComponentOptions>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TemplateComponentBase<'TComponentOptions>>() { yield! attrs }

    static member options (x: 'TComponentOptions) = "Options" => x
                    

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions> =
    inherit templateComponentBase<'FunBlazorGeneric, 'TComponentOptions>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions>>() { yield! attrs }

    static member feedbackRef (x: AntDesign.IFeedbackRef) = "FeedbackRef" => x
                    

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions, 'TResult> =
    inherit feedbackComponent<'FunBlazorGeneric, 'TComponentOptions>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>() { yield! attrs }


                    

type formProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.FormProvider>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.FormProvider>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.FormProvider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.FormProvider>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.FormProvider>(){ x }
    static member onFormFinish fn = html.callback<AntDesign.FormProviderFinishEventArgs>("OnFormFinish", fn)
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type component'<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Component>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Component>() { yield! attrs }

    static member type' (x: System.Type) = "Type" => x
    static member typeName (x: System.String) = "TypeName" => x
    static member parameters (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "Parameters" => x
                    

type imagePreview<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ImagePreview>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ImagePreview>() { yield! attrs }

    static member imageRef (x: AntDesign.ImageRef) = "ImageRef" => x
                    

type imagePreviewGroup<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.ImagePreviewGroup>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ImagePreviewGroup>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.ImagePreviewGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.ImagePreviewGroup>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.ImagePreviewGroup>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member previewVisible (x: System.Boolean) = "PreviewVisible" => x
    static member previewVisible' (value: IStore<System.Boolean>) = html.bind("PreviewVisible", value)
    static member previewVisible' (value: cval<System.Boolean>) = html.bind("PreviewVisible", value)
    static member previewVisible' (valueFn: System.Boolean * (System.Boolean -> unit)) = html.bind("PreviewVisible", valueFn)
    static member previewVisibleChanged fn = html.callback<System.Boolean>("PreviewVisibleChanged", fn)
                    

type treeIndent<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TreeIndent<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeIndent<'TItem>>() { yield! attrs }

    static member treeLevel (x: System.Int32) = "TreeLevel" => x
                    

type treeNodeCheckbox<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TreeNodeCheckbox<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeNodeCheckbox<'TItem>>() { yield! attrs }

    static member onCheckBoxClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCheckBoxClick", fn)
                    

type treeNodeSwitcher<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TreeNodeSwitcher<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeNodeSwitcher<'TItem>>() { yield! attrs }

    static member onSwitcherClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnSwitcherClick", fn)
                    

type treeNodeTitle<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.TreeNodeTitle<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeNodeTitle<'TItem>>() { yield! attrs }


                    

type cardLoading<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.CardLoading>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CardLoading>() { yield! attrs }


                    

type summaryRow<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.SummaryRow>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SummaryRow>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<AntDesign.SummaryRow>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<AntDesign.SummaryRow>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<AntDesign.SummaryRow>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    
            
namespace rec AntDesign.DslInternals.statistic

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type statisticComponentBase<'FunBlazorGeneric, 'T> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.statistic.StatisticComponentBase<'T>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.statistic.StatisticComponentBase<'T>>() { yield! attrs }


                    
            
namespace rec AntDesign.DslInternals.Select

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type labelTemplateItem<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>() { yield! attrs }

    static member labelTemplateItemContent (render: 'TItem -> NodeRenderFragment) = html.renderFragment("LabelTemplateItemContent", render)
    static member styles (x: (string * string) seq) = html.styles x
    static member classes (x: string list) = html.classes x
    static member contentStyle (x: System.String) = "ContentStyle" => x
    static member contentClass (x: System.String) = "ContentClass" => x
    static member removeIconStyle (x: System.String) = "RemoveIconStyle" => x
    static member removeIconClass (x: System.String) = "RemoveIconClass" => x
    static member refBack (x: AntDesign.ForwardRef) = "RefBack" => x
                    
            
namespace rec AntDesign.DslInternals.Select.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type selectContent<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>() { yield! attrs }

    static member prefix (x: System.String) = "Prefix" => x
    static member placeholder (x: System.String) = "Placeholder" => x
    static member isOverlayShow (x: System.Boolean) = "IsOverlayShow" => x
    static member showPlaceholder (x: System.Boolean) = "ShowPlaceholder" => x
    static member maxTagCount (x: System.Int32) = "MaxTagCount" => x
    static member onInput fn = html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInput", fn)
    static member onKeyUp fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyUp", fn)
    static member onKeyDown fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyDown", fn)
    static member onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
    static member onBlur fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    static member onClearClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearClick", fn)
    static member onRemoveSelected fn = html.callback<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>>("OnRemoveSelected", fn)
    static member searchValue (x: System.String) = "SearchValue" => x
    static member refBack (x: AntDesign.ForwardRef) = "RefBack" => x
                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type formRulesValidator<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<AntDesign.Internal.FormRulesValidator>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.FormRulesValidator>() { yield! attrs }


                    
            

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
                    
            