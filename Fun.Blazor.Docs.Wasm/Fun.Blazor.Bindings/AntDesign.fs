namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type antComponentBase<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<AntDesign.AntComponentBase>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntComponentBase>() { html.mergeAttrs attrs }

    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x
                    

type antDomComponentBase<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AntDomComponentBase>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntDomComponentBase>() { html.mergeAttrs attrs }

    static member inline id (x: System.String) = "Id" => x
    static member inline classes (x: string list) = html.classes x
    static member inline styles (x: (string * string) seq) = html.styles x
                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type overlayTrigger<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.OverlayTrigger>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.OverlayTrigger>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Internal.OverlayTrigger>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Internal.OverlayTrigger>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Internal.OverlayTrigger>(){ x }
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline complexAutoCloseAndVisible (x: System.Boolean) = "ComplexAutoCloseAndVisible" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x
    static member inline inlineFlexMode (x: System.Boolean) = "InlineFlexMode" => x
    static member inline isButton (x: System.Boolean) = "IsButton" => x
    static member inline onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member inline onMaskClick fn = html.callback<unit>("OnMaskClick", fn)
    static member inline onMouseEnter fn = html.callback<unit>("OnMouseEnter", fn)
    static member inline onMouseLeave fn = html.callback<unit>("OnMouseLeave", fn)
    static member inline onOverlayHiding fn = html.callback<System.Boolean>("OnOverlayHiding", fn)
    static member inline onVisibleChange fn = html.callback<System.Boolean>("OnVisibleChange", fn)
    static member inline overlay (x: string) = html.renderFragment("Overlay", html.text x)
    static member inline overlay (node) = html.renderFragment("Overlay", node)
    static member inline overlay (nodes) = html.renderFragment("Overlay", fragment { yield! nodes })
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x
    static member inline overlayEnterCls (x: System.String) = "OverlayEnterCls" => x
    static member inline overlayHiddenCls (x: System.String) = "OverlayHiddenCls" => x
    static member inline overlayLeaveCls (x: System.String) = "OverlayLeaveCls" => x
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x
    static member inline placement (x: AntDesign.Placement) = "Placement" => x
    static member inline placementCls (x: System.String) = "PlacementCls" => x
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member inline trigger (x: AntDesign.Trigger[]) = "Trigger" => x
    static member inline triggerCls (x: System.String) = "TriggerCls" => x
    static member inline triggerReference (x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x
    static member inline unbound (render: AntDesign.ForwardRef -> NodeRenderFragment) = html.renderFragment("Unbound", render)
    static member inline visible (x: System.Boolean) = "Visible" => x
                    
            
namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type dropdown<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Dropdown>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Dropdown>() { html.mergeAttrs attrs }


                    

type dropdownButton<'FunBlazorGeneric> =
    inherit dropdown<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.DropdownButton>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DropdownButton>() { html.mergeAttrs attrs }

    static member inline block (x: System.Boolean) = "Block" => x
    static member inline buttonsRender (fn: _ -> _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "ButtonsRender", box (System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1 x2).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline buttonsClass (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "ButtonsClass" => x
    static member inline buttonsStyle (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "ButtonsStyle" => x
    static member inline danger (x: System.Boolean) = "Danger" => x
    static member inline ghost (x: System.Boolean) = "Ghost" => x
    static member inline icon (x: System.String) = "Icon" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline type' (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Type" => x
                    

type popconfirm<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Popconfirm>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Popconfirm>() { html.mergeAttrs attrs }

    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline cancelText (x: System.String) = "CancelText" => x
    static member inline okText (x: System.String) = "OkText" => x
    static member inline okType (x: System.String) = "OkType" => x
    static member inline okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x
    static member inline cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x
    static member inline icon (x: System.String) = "Icon" => x
    static member inline iconTemplate (x: string) = html.renderFragment("IconTemplate", html.text x)
    static member inline iconTemplate (node) = html.renderFragment("IconTemplate", node)
    static member inline iconTemplate (nodes) = html.renderFragment("IconTemplate", fragment { yield! nodes })
    static member inline onCancel fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCancel", fn)
    static member inline onConfirm fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnConfirm", fn)
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x
                    

type popover<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Popover>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Popover>() { html.mergeAttrs attrs }

    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline content (x: System.String) = "Content" => x
    static member inline contentTemplate (x: string) = html.renderFragment("ContentTemplate", html.text x)
    static member inline contentTemplate (node) = html.renderFragment("ContentTemplate", node)
    static member inline contentTemplate (nodes) = html.renderFragment("ContentTemplate", fragment { yield! nodes })
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x
                    

type tooltip<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Tooltip>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Tooltip>() { html.mergeAttrs attrs }

    static member inline title (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>) = "Title" => x
    static member inline arrowPointAtCenter (x: System.Boolean) = "ArrowPointAtCenter" => x
    static member inline mouseEnterDelay (x: System.Double) = "MouseEnterDelay" => x
    static member inline mouseLeaveDelay (x: System.Double) = "MouseLeaveDelay" => x
                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type subMenuTrigger<'FunBlazorGeneric> =
    inherit Internal.overlayTrigger<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.SubMenuTrigger>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.SubMenuTrigger>() { html.mergeAttrs attrs }

    static member inline triggerClass (x: System.String) = "TriggerClass" => x
                    

type pickerPanelBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.PickerPanelBase>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.PickerPanelBase>() { html.mergeAttrs attrs }

    static member inline onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn)
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x
                    
            
namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type datePickerPanelBase<'FunBlazorGeneric, 'TValue> =
    inherit Internal.pickerPanelBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.DatePickerPanelBase<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DatePickerPanelBase<'TValue>>() { html.mergeAttrs attrs }

    static member inline prefixCls (x: System.String) = "PrefixCls" => x
    static member inline picker (x: System.String) = "Picker" => x
    static member inline isRange (x: System.Boolean) = "IsRange" => x
    static member inline isCalendar (x: System.Boolean) = "IsCalendar" => x
    static member inline isShowHeader (x: System.Boolean) = "IsShowHeader" => x
    static member inline isShowTime (x: System.Boolean) = "IsShowTime" => x
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x
    static member inline closePanel (x: System.Action) = "ClosePanel" => x
    static member inline changePickerValue (fn) = "ChangePickerValue" => (System.Action<System.DateTime, System.Nullable<System.Int32>>fn)
    static member inline changeValue (fn) = "ChangeValue" => (System.Action<System.DateTime, System.Int32>fn)
    static member inline changePickerType (fn) = "ChangePickerType" => (System.Action<System.String, System.Int32>fn)
    static member inline getIndexPickerValue (fn) = "GetIndexPickerValue" => (System.Func<System.Int32, System.DateTime>fn)
    static member inline getIndexValue (fn) = "GetIndexValue" => (System.Func<System.Int32, System.Nullable<System.DateTime>>fn)
    static member inline disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn)
    static member inline dateRender (fn: _ -> _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DateRender", box (System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1 x2).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline monthCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "MonthCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline calendarDateRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "CalendarDateRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline calendarMonthCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "CalendarMonthCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline renderExtraFooter (x: string) = html.renderFragment("RenderExtraFooter", html.text x)
    static member inline renderExtraFooter (node) = html.renderFragment("RenderExtraFooter", node)
    static member inline renderExtraFooter (nodes) = html.renderFragment("RenderExtraFooter", fragment { yield! nodes })
                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type datePickerDatetimePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>() { html.mergeAttrs attrs }

    static member inline showToday (x: System.Boolean) = "ShowToday" => x
    static member inline showTimeFormat (x: System.String) = "ShowTimeFormat" => x
    static member inline format (x: System.String) = "Format" => x
    static member inline disabledHours (fn) = "DisabledHours" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member inline disabledMinutes (fn) = "DisabledMinutes" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member inline disabledSeconds (fn) = "DisabledSeconds" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member inline disabledTime (fn) = "DisabledTime" => (System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>fn)
    static member inline onOkClick fn = html.callback<unit>("OnOkClick", fn)
                    

type datePickerTemplate<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerTemplate<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerTemplate<'TValue>>() { html.mergeAttrs attrs }

    static member inline renderPickerHeader (x: string) = html.renderFragment("RenderPickerHeader", html.text x)
    static member inline renderPickerHeader (node) = html.renderFragment("RenderPickerHeader", node)
    static member inline renderPickerHeader (nodes) = html.renderFragment("RenderPickerHeader", fragment { yield! nodes })
    static member inline renderTableHeader (x: string) = html.renderFragment("RenderTableHeader", html.text x)
    static member inline renderTableHeader (node) = html.renderFragment("RenderTableHeader", node)
    static member inline renderTableHeader (nodes) = html.renderFragment("RenderTableHeader", fragment { yield! nodes })
    static member inline renderFirstCol (render: System.DateTime -> NodeRenderFragment) = html.renderFragment("RenderFirstCol", render)
    static member inline renderColValue (render: System.DateTime -> NodeRenderFragment) = html.renderFragment("RenderColValue", render)
    static member inline renderLastCol (render: System.DateTime -> NodeRenderFragment) = html.renderFragment("RenderLastCol", render)
    static member inline viewStartDate (x: System.DateTime) = "ViewStartDate" => x
    static member inline getColTitle (fn) = "GetColTitle" => (System.Func<System.DateTime, System.String>fn)
    static member inline getRowClass (fn) = "GetRowClass" => (System.Func<System.DateTime, System.String>fn)
    static member inline getNextColValue (fn) = "GetNextColValue" => (System.Func<System.DateTime, System.DateTime>fn)
    static member inline isInView (fn) = "IsInView" => (System.Func<System.DateTime, System.Boolean>fn)
    static member inline isToday (fn) = "IsToday" => (System.Func<System.DateTime, System.Boolean>fn)
    static member inline isSelected (fn) = "IsSelected" => (System.Func<System.DateTime, System.Boolean>fn)
    static member inline onRowSelect (fn) = "OnRowSelect" => (System.Action<System.DateTime>fn)
    static member inline onValueSelect (fn) = "OnValueSelect" => (System.Action<System.DateTime>fn)
    static member inline showFooter (x: System.Boolean) = "ShowFooter" => x
    static member inline maxRow (x: System.Int32) = "MaxRow" => x
    static member inline maxCol (x: System.Int32) = "MaxCol" => x
    static member inline skipDays (x: System.Int32) = "SkipDays" => x
                    

type datePickerDatePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerDatePanel<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerDatePanel<'TValue>>() { html.mergeAttrs attrs }

    static member inline isWeek (x: System.Boolean) = "IsWeek" => x
    static member inline showToday (x: System.Boolean) = "ShowToday" => x
                    

type datePickerDecadePanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerDecadePanel<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerDecadePanel<'TValue>>() { html.mergeAttrs attrs }


                    

type datePickerFooter<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerFooter<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerFooter<'TValue>>() { html.mergeAttrs attrs }


                    

type datePickerHeader<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerHeader<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerHeader<'TValue>>() { html.mergeAttrs attrs }

    static member inline superChangeDateInterval (x: System.Int32) = "SuperChangeDateInterval" => x
    static member inline changeDateInterval (x: System.Int32) = "ChangeDateInterval" => x
    static member inline showSuperPreChange (x: System.Boolean) = "ShowSuperPreChange" => x
    static member inline showPreChange (x: System.Boolean) = "ShowPreChange" => x
    static member inline showNextChange (x: System.Boolean) = "ShowNextChange" => x
    static member inline showSuperNextChange (x: System.Boolean) = "ShowSuperNextChange" => x
                    

type datePickerMonthPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerMonthPanel<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerMonthPanel<'TValue>>() { html.mergeAttrs attrs }


                    

type datePickerQuarterPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>() { html.mergeAttrs attrs }


                    

type datePickerYearPanel<'FunBlazorGeneric, 'TValue> =
    inherit datePickerPanelBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerYearPanel<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerYearPanel<'TValue>>() { html.mergeAttrs attrs }


                    
            
namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type col<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Col>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Col>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Col>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Col>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Col>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline flex (x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x
    static member inline span (x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x
    static member inline order (x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x
    static member inline offset (x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x
    static member inline push (x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x
    static member inline pull (x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x
    static member inline xs (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x
    static member inline sm (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x
    static member inline md (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x
    static member inline lg (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x
    static member inline xl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x
    static member inline xxl (x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x
                    

type gridCol<'FunBlazorGeneric> =
    inherit col<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.GridCol>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.GridCol>() { html.mergeAttrs attrs }


                    

type icon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Icon>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Icon>() { html.mergeAttrs attrs }

    static member inline spin (x: System.Boolean) = "Spin" => x
    static member inline rotate (x: System.Int32) = "Rotate" => x
    static member inline type' (x: System.String) = "Type" => x
    static member inline theme (x: System.String) = "Theme" => x
    static member inline twotoneColor (x: System.String) = "TwotoneColor" => x
    static member inline iconFont (x: System.String) = "IconFont" => x
    static member inline width (x: System.String) = "Width" => x
    static member inline height (x: System.String) = "Height" => x
    static member inline fill (x: System.String) = "Fill" => x
    static member inline tabIndex (x: System.String) = "TabIndex" => x
    static member inline stopPropagation (x: System.Boolean) = "StopPropagation" => x
    static member inline onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member inline component' (x: string) = html.renderFragment("Component", html.text x)
    static member inline component' (node) = html.renderFragment("Component", node)
    static member inline component' (nodes) = html.renderFragment("Component", fragment { yield! nodes })
                    

type iconFont<'FunBlazorGeneric> =
    inherit icon<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.IconFont>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.IconFont>() { html.mergeAttrs attrs }


                    

type notificationBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.NotificationBase>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.NotificationBase>() { html.mergeAttrs attrs }


                    

type notification<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Notification>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Notification>() { html.mergeAttrs attrs }


                    

type notificationItem<'FunBlazorGeneric> =
    inherit notificationBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.NotificationItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.NotificationItem>() { html.mergeAttrs attrs }

    static member inline config (x: AntDesign.NotificationConfig) = "Config" => x
    static member inline onClose (fn) = "OnClose" => (System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>fn)
                    

type columnBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ColumnBase>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ColumnBase>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.ColumnBase>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.ColumnBase>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.ColumnBase>(){ x }
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline width (x: System.String) = "Width" => x
    static member inline headerStyle (x: System.String) = "HeaderStyle" => x
    static member inline rowSpan (x: System.Int32) = "RowSpan" => x
    static member inline colSpan (x: System.Int32) = "ColSpan" => x
    static member inline headerColSpan (x: System.Int32) = "HeaderColSpan" => x
    static member inline fixed' (x: System.String) = "Fixed" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x
    static member inline hidden (x: System.Boolean) = "Hidden" => x
    static member inline align (x: AntDesign.ColumnAlign) = "Align" => x
    static member inline cellRender (render: AntDesign.TableModels.CellData -> NodeRenderFragment) = html.renderFragment("CellRender", render)
                    

type actionColumn<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ActionColumn>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ActionColumn>() { html.mergeAttrs attrs }


                    

type column<'FunBlazorGeneric, 'TData> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Column<'TData>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Column<'TData>>() { html.mergeAttrs attrs }

    static member inline fieldChanged fn = html.callback<'TData>("FieldChanged", fn)
    static member inline fieldExpression (x: System.Linq.Expressions.Expression<System.Func<'TData>>) = "FieldExpression" => x
    static member inline field (x: 'TData) = "Field" => x
    static member inline field' (value: IStore<'TData>) = html.bind("Field", value)
    static member inline field' (value: cval<'TData>) = html.bind("Field", value)
    static member inline field' (valueFn: 'TData * ('TData -> unit)) = html.bind("Field", valueFn)
    static member inline dataIndex (x: System.String) = "DataIndex" => x
    static member inline format (x: System.String) = "Format" => x
    static member inline sortable (x: System.Boolean) = "Sortable" => x
    static member inline sorterCompare (fn) = "SorterCompare" => (System.Func<'TData, 'TData, System.Int32>fn)
    static member inline sorterMultiple (x: System.Int32) = "SorterMultiple" => x
    static member inline showSorterTooltip (x: System.Boolean) = "ShowSorterTooltip" => x
    static member inline sortDirections (x: AntDesign.SortDirection[]) = "SortDirections" => x
    static member inline defaultSortOrder (x: AntDesign.SortDirection) = "DefaultSortOrder" => x
    static member inline onCell (fn) = "OnCell" => (System.Func<AntDesign.TableModels.CellData, System.Collections.Generic.Dictionary<System.String, System.Object>>fn)
    static member inline onHeaderCell (fn) = "OnHeaderCell" => (System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>fn)
    static member inline filterable (x: System.Boolean) = "Filterable" => x
    static member inline filters (x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = "Filters" => x
    static member inline filterMultiple (x: System.Boolean) = "FilterMultiple" => x
    static member inline onFilter (x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = "OnFilter" => x
                    

type selection<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Selection>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Selection>() { html.mergeAttrs attrs }

    static member inline type' (x: System.String) = "Type" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline key (x: System.String) = "Key" => x
    static member inline checkStrictly (x: System.Boolean) = "CheckStrictly" => x
                    

type summaryCell<'FunBlazorGeneric> =
    inherit columnBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.SummaryCell>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SummaryCell>() { html.mergeAttrs attrs }


                    

type typographyBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.TypographyBase>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TypographyBase>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.TypographyBase>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.TypographyBase>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.TypographyBase>(){ x }
    static member inline copyable (x: System.Boolean) = "Copyable" => x
    static member inline copyConfig (x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x
    static member inline delete (x: System.Boolean) = "Delete" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline editable (x: System.Boolean) = "Editable" => x
    static member inline editConfig (x: AntDesign.TypographyEditableConfig) = "EditConfig" => x
    static member inline ellipsis (x: System.Boolean) = "Ellipsis" => x
    static member inline ellipsisConfig (x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x
    static member inline mark (x: System.Boolean) = "Mark" => x
    static member inline underline (x: System.Boolean) = "Underline" => x
    static member inline strong (x: System.Boolean) = "Strong" => x
    static member inline onChange (x: System.Action) = "OnChange" => x
    static member inline type' (x: System.String) = "Type" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type link<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Link>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Link>() { html.mergeAttrs attrs }

    static member inline code (x: System.Boolean) = "Code" => x
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x
                    

type paragraph<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Paragraph>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Paragraph>() { html.mergeAttrs attrs }

    static member inline code (x: System.Boolean) = "Code" => x
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x
                    

type text<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Text>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Text>() { html.mergeAttrs attrs }

    static member inline code (x: System.Boolean) = "Code" => x
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x
                    

type title<'FunBlazorGeneric> =
    inherit typographyBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Title>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Title>() { html.mergeAttrs attrs }

    static member inline level (x: System.Int32) = "Level" => x
                    

type affix<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Affix>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Affix>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Affix>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Affix>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Affix>(){ x }
    static member inline offsetBottom (x: System.Int32) = "OffsetBottom" => x
    static member inline offsetTop (x: System.Int32) = "OffsetTop" => x
    static member inline targetSelector (x: System.String) = "TargetSelector" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline onChange fn = html.callback<System.Boolean>("OnChange", fn)
                    

type alert<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Alert>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Alert>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Alert>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Alert>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Alert>(){ x }
    static member inline afterClose fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("AfterClose", fn)
    static member inline banner (x: System.Boolean) = "Banner" => x
    static member inline closable (x: System.Boolean) = "Closable" => x
    static member inline closeText (x: System.String) = "CloseText" => x
    static member inline description (x: System.String) = "Description" => x
    static member inline icon (x: string) = html.renderFragment("Icon", html.text x)
    static member inline icon (node) = html.renderFragment("Icon", node)
    static member inline icon (nodes) = html.renderFragment("Icon", fragment { yield! nodes })
    static member inline message (x: System.String) = "Message" => x
    static member inline messageTemplate (x: string) = html.renderFragment("MessageTemplate", html.text x)
    static member inline messageTemplate (node) = html.renderFragment("MessageTemplate", node)
    static member inline messageTemplate (nodes) = html.renderFragment("MessageTemplate", fragment { yield! nodes })
    static member inline showIcon (x: System.Nullable<System.Boolean>) = "ShowIcon" => x
    static member inline type' (x: System.String) = "Type" => x
    static member inline onClose fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClose", fn)
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type anchor<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Anchor>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Anchor>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Anchor>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Anchor>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Anchor>(){ x }
    static member inline key (x: System.String) = "Key" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline affix (x: System.Boolean) = "Affix" => x
    static member inline bounds (x: System.Int32) = "Bounds" => x
    static member inline getContainer (fn) = "GetContainer" => (System.Func<System.String>fn)
    static member inline offsetBottom (x: System.Nullable<System.Int32>) = "OffsetBottom" => x
    static member inline offsetTop (x: System.Nullable<System.Int32>) = "OffsetTop" => x
    static member inline showInkInFixed (x: System.Boolean) = "ShowInkInFixed" => x
    static member inline onClick fn = html.callback<System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink>>("OnClick", fn)
    static member inline getCurrentAnchor (fn) = "GetCurrentAnchor" => (System.Func<System.String>fn)
    static member inline targetOffset (x: System.Nullable<System.Int32>) = "TargetOffset" => x
    static member inline onChange fn = html.callback<System.String>("OnChange", fn)
                    

type anchorLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AnchorLink>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AnchorLink>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.AnchorLink>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.AnchorLink>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.AnchorLink>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline href (x: System.String) = "Href" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline target (x: System.String) = "Target" => x
                    

type autoCompleteOptGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AutoCompleteOptGroup>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteOptGroup>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteOptGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.AutoCompleteOptGroup>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.AutoCompleteOptGroup>(){ x }
    static member inline label (x: System.String) = "Label" => x
    static member inline labelFragment (x: string) = html.renderFragment("LabelFragment", html.text x)
    static member inline labelFragment (node) = html.renderFragment("LabelFragment", node)
    static member inline labelFragment (nodes) = html.renderFragment("LabelFragment", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type autoCompleteOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AutoCompleteOption>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteOption>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteOption>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.AutoCompleteOption>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.AutoCompleteOption>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline value (x: System.Object) = "Value" => x
    static member inline label (x: System.String) = "Label" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline autoComplete (x: AntDesign.IAutoCompleteRef) = "AutoComplete" => x
                    

type avatar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Avatar>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Avatar>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Avatar>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Avatar>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Avatar>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline shape (x: System.String) = "Shape" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline text (x: System.String) = "Text" => x
    static member inline src (x: System.String) = "Src" => x
    static member inline srcSet (x: System.String) = "SrcSet" => x
    static member inline alt (x: System.String) = "Alt" => x
    static member inline icon (x: System.String) = "Icon" => x
    static member inline onError fn = html.callback<Microsoft.AspNetCore.Components.Web.ErrorEventArgs>("OnError", fn)
                    

type avatarGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AvatarGroup>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AvatarGroup>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.AvatarGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.AvatarGroup>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.AvatarGroup>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline maxCount (x: System.Int32) = "MaxCount" => x
    static member inline maxStyle (x: System.String) = "MaxStyle" => x
    static member inline maxPopoverPlacement (x: AntDesign.Placement) = "MaxPopoverPlacement" => x
                    

type backTop<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.BackTop>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.BackTop>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.BackTop>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.BackTop>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.BackTop>(){ x }
    static member inline icon (x: System.String) = "Icon" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline visibilityHeight (x: System.Double) = "VisibilityHeight" => x
    static member inline targetSelector (x: System.String) = "TargetSelector" => x
    static member inline onClick fn = html.callback<unit>("OnClick", fn)
                    

type badge<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Badge>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Badge>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Badge>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Badge>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Badge>(){ x }
    static member inline color (x: System.String) = "Color" => x
    static member inline presetColor (x: System.Nullable<AntDesign.PresetColor>) = "PresetColor" => x
    static member inline count (x: System.Nullable<System.Int32>) = "Count" => x
    static member inline countTemplate (x: string) = html.renderFragment("CountTemplate", html.text x)
    static member inline countTemplate (node) = html.renderFragment("CountTemplate", node)
    static member inline countTemplate (nodes) = html.renderFragment("CountTemplate", fragment { yield! nodes })
    static member inline dot (x: System.Boolean) = "Dot" => x
    static member inline offset (x: System.ValueTuple<System.Int32, System.Int32>) = "Offset" => x
    static member inline overflowCount (x: System.Int32) = "OverflowCount" => x
    static member inline showZero (x: System.Boolean) = "ShowZero" => x
    static member inline status (x: System.String) = "Status" => x
    static member inline text (x: System.String) = "Text" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type badgeRibbon<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.BadgeRibbon>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.BadgeRibbon>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.BadgeRibbon>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.BadgeRibbon>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.BadgeRibbon>(){ x }
    static member inline color (x: System.String) = "Color" => x
    static member inline text (x: System.String) = "Text" => x
    static member inline textTemplate (x: string) = html.renderFragment("TextTemplate", html.text x)
    static member inline textTemplate (node) = html.renderFragment("TextTemplate", node)
    static member inline textTemplate (nodes) = html.renderFragment("TextTemplate", fragment { yield! nodes })
    static member inline placement (x: System.String) = "Placement" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type breadcrumb<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Breadcrumb>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Breadcrumb>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Breadcrumb>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Breadcrumb>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Breadcrumb>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline autoGenerate (x: System.Boolean) = "AutoGenerate" => x
    static member inline separator (x: System.String) = "Separator" => x
    static member inline routeLabel (x: System.String) = "RouteLabel" => x
                    

type button<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Button>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Button>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Button>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Button>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Button>(){ x }
    static member inline color (x: AntDesign.Color) = "Color" => x
    static member inline block (x: System.Boolean) = "Block" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline danger (x: System.Boolean) = "Danger" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline ghost (x: System.Boolean) = "Ghost" => x
    static member inline htmlType (x: System.String) = "HtmlType" => x
    static member inline icon (x: System.String) = "Icon" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member inline onClickStopPropagation (x: System.Boolean) = "OnClickStopPropagation" => x
    static member inline shape (x: System.String) = "Shape" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline type' (x: System.String) = "Type" => x
    static member inline noSpanWrap (x: System.Boolean) = "NoSpanWrap" => x
                    

type buttonGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ButtonGroup>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ButtonGroup>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.ButtonGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.ButtonGroup>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.ButtonGroup>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline size (x: System.String) = "Size" => x
                    

type calendar<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Calendar>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Calendar>() { html.mergeAttrs attrs }

    static member inline value (x: System.DateTime) = "Value" => x
    static member inline defaultValue (x: System.DateTime) = "DefaultValue" => x
    static member inline validRange (x: System.DateTime[]) = "ValidRange" => x
    static member inline mode (x: System.String) = "Mode" => x
    static member inline fullScreen (x: System.Boolean) = "FullScreen" => x
    static member inline onSelect fn = html.callback<System.DateTime>("OnSelect", fn)
    static member inline onChange fn = html.callback<System.DateTime>("OnChange", fn)
    static member inline headerRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "HeaderRender", box (System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline dateCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DateCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline dateFullCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DateFullCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline monthCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "MonthCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline monthFullCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "MonthFullCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline onPanelChange (fn) = "OnPanelChange" => (System.Action<System.DateTime, System.String>fn)
    static member inline disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn)
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x
                    

type card<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Card>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Card>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Card>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Card>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Card>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline body (x: string) = html.renderFragment("Body", html.text x)
    static member inline body (node) = html.renderFragment("Body", node)
    static member inline body (nodes) = html.renderFragment("Body", fragment { yield! nodes })
    static member inline actionTemplate (x: string) = html.renderFragment("ActionTemplate", html.text x)
    static member inline actionTemplate (node) = html.renderFragment("ActionTemplate", node)
    static member inline actionTemplate (nodes) = html.renderFragment("ActionTemplate", fragment { yield! nodes })
    static member inline bordered (x: System.Boolean) = "Bordered" => x
    static member inline hoverable (x: System.Boolean) = "Hoverable" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x
    static member inline cover (x: string) = html.renderFragment("Cover", html.text x)
    static member inline cover (node) = html.renderFragment("Cover", node)
    static member inline cover (nodes) = html.renderFragment("Cover", fragment { yield! nodes })
    static member inline actions (x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x
    static member inline type' (x: System.String) = "Type" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline extra (x: string) = html.renderFragment("Extra", html.text x)
    static member inline extra (node) = html.renderFragment("Extra", node)
    static member inline extra (nodes) = html.renderFragment("Extra", fragment { yield! nodes })
    static member inline cardTabs (x: string) = html.renderFragment("CardTabs", html.text x)
    static member inline cardTabs (node) = html.renderFragment("CardTabs", node)
    static member inline cardTabs (nodes) = html.renderFragment("CardTabs", fragment { yield! nodes })
                    

type cardAction<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.CardAction>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CardAction>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.CardAction>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.CardAction>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.CardAction>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type cardGrid<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.CardGrid>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CardGrid>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.CardGrid>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.CardGrid>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.CardGrid>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline hoverable (x: System.Boolean) = "Hoverable" => x
                    

type carousel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Carousel>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Carousel>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Carousel>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Carousel>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Carousel>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline dotPosition (x: System.String) = "DotPosition" => x
    static member inline autoplay (x: System.TimeSpan) = "Autoplay" => x
    static member inline effect (x: System.String) = "Effect" => x
                    

type carouselSlick<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.CarouselSlick>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CarouselSlick>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.CarouselSlick>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.CarouselSlick>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.CarouselSlick>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type collapse<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Collapse>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Collapse>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Collapse>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Collapse>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Collapse>(){ x }
    static member inline accordion (x: System.Boolean) = "Accordion" => x
    static member inline bordered (x: System.Boolean) = "Bordered" => x
    static member inline expandIconPosition (x: System.String) = "ExpandIconPosition" => x
    static member inline defaultActiveKey (x: System.String[]) = "DefaultActiveKey" => x
    static member inline onChange fn = html.callback<System.String[]>("OnChange", fn)
    static member inline expandIcon (x: System.String) = "ExpandIcon" => x
    static member inline expandIconTemplate (render: System.Boolean -> NodeRenderFragment) = html.renderFragment("ExpandIconTemplate", render)
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type panel<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Panel>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Panel>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Panel>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Panel>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Panel>(){ x }
    static member inline active (x: System.Boolean) = "Active" => x
    static member inline key (x: System.String) = "Key" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline showArrow (x: System.Boolean) = "ShowArrow" => x
    static member inline extra (x: System.String) = "Extra" => x
    static member inline extraTemplate (x: string) = html.renderFragment("ExtraTemplate", html.text x)
    static member inline extraTemplate (node) = html.renderFragment("ExtraTemplate", node)
    static member inline extraTemplate (nodes) = html.renderFragment("ExtraTemplate", fragment { yield! nodes })
    static member inline header (x: System.String) = "Header" => x
    static member inline headerTemplate (x: string) = html.renderFragment("HeaderTemplate", html.text x)
    static member inline headerTemplate (node) = html.renderFragment("HeaderTemplate", node)
    static member inline headerTemplate (nodes) = html.renderFragment("HeaderTemplate", fragment { yield! nodes })
    static member inline onActiveChange fn = html.callback<System.Boolean>("OnActiveChange", fn)
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type comment<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Comment>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Comment>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Comment>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Comment>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Comment>(){ x }
    static member inline author (x: System.String) = "Author" => x
    static member inline authorTemplate (x: string) = html.renderFragment("AuthorTemplate", html.text x)
    static member inline authorTemplate (node) = html.renderFragment("AuthorTemplate", node)
    static member inline authorTemplate (nodes) = html.renderFragment("AuthorTemplate", fragment { yield! nodes })
    static member inline avatar (x: System.String) = "Avatar" => x
    static member inline avatarTemplate (x: string) = html.renderFragment("AvatarTemplate", html.text x)
    static member inline avatarTemplate (node) = html.renderFragment("AvatarTemplate", node)
    static member inline avatarTemplate (nodes) = html.renderFragment("AvatarTemplate", fragment { yield! nodes })
    static member inline content (x: System.String) = "Content" => x
    static member inline contentTemplate (x: string) = html.renderFragment("ContentTemplate", html.text x)
    static member inline contentTemplate (node) = html.renderFragment("ContentTemplate", node)
    static member inline contentTemplate (nodes) = html.renderFragment("ContentTemplate", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline datetime (x: System.String) = "Datetime" => x
    static member inline datetimeTemplate (x: string) = html.renderFragment("DatetimeTemplate", html.text x)
    static member inline datetimeTemplate (node) = html.renderFragment("DatetimeTemplate", node)
    static member inline datetimeTemplate (nodes) = html.renderFragment("DatetimeTemplate", fragment { yield! nodes })
    static member inline actions (x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x
                    

type antContainerComponentBase<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AntContainerComponentBase>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntContainerComponentBase>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.AntContainerComponentBase>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.AntContainerComponentBase>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.AntContainerComponentBase>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline tag (x: System.String) = "Tag" => x
                    

type antInputComponentBase<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AntInputComponentBase<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntInputComponentBase<'TValue>>() { html.mergeAttrs attrs }

    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
    static member inline value (x: 'TValue) = "Value" => x
    static member inline value' (value: IStore<'TValue>) = html.bind("Value", value)
    static member inline value' (value: cval<'TValue>) = html.bind("Value", value)
    static member inline value' (valueFn: 'TValue * ('TValue -> unit)) = html.bind("Value", valueFn)
    static member inline valueChanged fn = html.callback<'TValue>("ValueChanged", fn)
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x
    static member inline valuesExpression (x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x
                    

type antInputBoolComponentBase<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.Boolean>
    static member inline create () = ComponentBuilder<AntDesign.AntInputBoolComponentBase>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntInputBoolComponentBase>() { html.mergeAttrs attrs }

    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member inline checked' (x: System.Boolean) = "Checked" => x
    static member inline checked'' (value: IStore<System.Boolean>) = html.bind("Checked", value)
    static member inline checked'' (value: cval<System.Boolean>) = html.bind("Checked", value)
    static member inline checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = html.bind("Checked", valueFn)
    static member inline onChange fn = html.callback<System.Boolean>("OnChange", fn)
    static member inline checkedChanged fn = html.callback<System.Boolean>("CheckedChanged", fn)
    static member inline disabled (x: System.Boolean) = "Disabled" => x
                    

type checkbox<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Checkbox>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Checkbox>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Checkbox>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Checkbox>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Checkbox>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline checkedChange fn = html.callback<System.Boolean>("CheckedChange", fn)
    static member inline checkedExpression (x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "CheckedExpression" => x
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x
    static member inline label (x: System.String) = "Label" => x
                    

type switch<'FunBlazorGeneric> =
    inherit antInputBoolComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Switch>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Switch>() { html.mergeAttrs attrs }

    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline checkedChildren (x: System.String) = "CheckedChildren" => x
    static member inline checkedChildrenTemplate (x: string) = html.renderFragment("CheckedChildrenTemplate", html.text x)
    static member inline checkedChildrenTemplate (node) = html.renderFragment("CheckedChildrenTemplate", node)
    static member inline checkedChildrenTemplate (nodes) = html.renderFragment("CheckedChildrenTemplate", fragment { yield! nodes })
    static member inline control (x: System.Boolean) = "Control" => x
    static member inline onClick fn = html.callback<unit>("OnClick", fn)
    static member inline unCheckedChildren (x: System.String) = "UnCheckedChildren" => x
    static member inline unCheckedChildrenTemplate (x: string) = html.renderFragment("UnCheckedChildrenTemplate", html.text x)
    static member inline unCheckedChildrenTemplate (node) = html.renderFragment("UnCheckedChildrenTemplate", node)
    static member inline unCheckedChildrenTemplate (nodes) = html.renderFragment("UnCheckedChildrenTemplate", fragment { yield! nodes })
                    

type autoComplete<'FunBlazorGeneric, 'TOption> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<AntDesign.AutoComplete<'TOption>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoComplete<'TOption>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.AutoComplete<'TOption>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.AutoComplete<'TOption>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.AutoComplete<'TOption>>(){ x }
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x
    static member inline backfill (x: System.Boolean) = "Backfill" => x
    static member inline options (x: System.Collections.Generic.IEnumerable<'TOption>) = "Options" => x
    static member inline optionDataItems (x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionDataItems" => x
    static member inline onSelectionChange fn = html.callback<AntDesign.AutoCompleteOption>("OnSelectionChange", fn)
    static member inline onActiveChange fn = html.callback<AntDesign.AutoCompleteOption>("OnActiveChange", fn)
    static member inline onInput fn = html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInput", fn)
    static member inline onPanelVisibleChange fn = html.callback<System.Boolean>("OnPanelVisibleChange", fn)
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline optionTemplate (render: AntDesign.AutoCompleteDataItem<'TOption> -> NodeRenderFragment) = html.renderFragment("OptionTemplate", render)
    static member inline optionFormat (fn) = "OptionFormat" => (System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>fn)
    static member inline overlayTemplate (x: string) = html.renderFragment("OverlayTemplate", html.text x)
    static member inline overlayTemplate (node) = html.renderFragment("OverlayTemplate", node)
    static member inline overlayTemplate (nodes) = html.renderFragment("OverlayTemplate", fragment { yield! nodes })
    static member inline compareWith (fn) = "CompareWith" => (System.Func<System.Object, System.Object, System.Boolean>fn)
    static member inline filterExpression (fn) = "FilterExpression" => (System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>fn)
    static member inline allowFilter (x: System.Boolean) = "AllowFilter" => x
    static member inline width (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Width" => x
    static member inline overlayClassName (x: System.String) = "OverlayClassName" => x
    static member inline overlayStyle (x: System.String) = "OverlayStyle" => x
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member inline selectedItem (x: AntDesign.AutoCompleteOption) = "SelectedItem" => x
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member inline showPanel (x: System.Boolean) = "ShowPanel" => x
                    

type cascader<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<AntDesign.Cascader>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Cascader>() { html.mergeAttrs attrs }

    static member inline allowClear (x: System.Boolean) = "AllowClear" => x
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member inline changeOnSelect (x: System.Boolean) = "ChangeOnSelect" => x
    static member inline defaultValue (x: System.String) = "DefaultValue" => x
    static member inline expandTrigger (x: System.String) = "ExpandTrigger" => x
    static member inline notFoundContent (x: System.String) = "NotFoundContent" => x
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member inline showSearch (x: System.Boolean) = "ShowSearch" => x
    static member inline onChange (fn) = "OnChange" => (System.Action<System.Collections.Generic.List<AntDesign.CascaderNode>, System.String, System.String>fn)
    static member inline selectedNodesChanged fn = html.callback<AntDesign.CascaderNode[]>("SelectedNodesChanged", fn)
    static member inline options (x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = "Options" => x
                    

type checkboxGroup<'FunBlazorGeneric> =
    inherit antInputComponentBase<'FunBlazorGeneric, System.String[]>
    static member inline create () = ComponentBuilder<AntDesign.CheckboxGroup>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CheckboxGroup>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.CheckboxGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.CheckboxGroup>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.CheckboxGroup>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline options (x: OneOf.OneOf<AntDesign.CheckboxOption[], System.String[]>) = "Options" => x
    static member inline mixedMode (x: AntDesign.CheckboxGroupMixedMode) = "MixedMode" => x
    static member inline onChange fn = html.callback<System.String[]>("OnChange", fn)
    static member inline disabled (x: System.Boolean) = "Disabled" => x
                    

type datePickerBase<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.DatePickerBase<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DatePickerBase<'TValue>>() { html.mergeAttrs attrs }

    static member inline prefixCls (x: System.String) = "PrefixCls" => x
    static member inline picker (x: System.String) = "Picker" => x
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member inline disabled (x: OneOf.OneOf<System.Boolean, System.Boolean[]>) = "Disabled" => x
    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member inline bordered (x: System.Boolean) = "Bordered" => x
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member inline open' (x: System.Boolean) = "Open" => x
    static member inline inputReadOnly (x: System.Boolean) = "InputReadOnly" => x
    static member inline showToday (x: System.Boolean) = "ShowToday" => x
    static member inline locale (x: AntDesign.DatePickerLocale) = "Locale" => x
    static member inline cultureInfo (x: System.Globalization.CultureInfo) = "CultureInfo" => x
    static member inline showTime (x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x
    static member inline placeholder (x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x
    static member inline popupStyle (x: System.String) = "PopupStyle" => x
    static member inline className (x: System.String) = "ClassName" => x
    static member inline dropdownClassName (x: System.String) = "DropdownClassName" => x
    static member inline format (x: System.String) = "Format" => x
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x
    static member inline defaultPickerValue (x: 'TValue) = "DefaultPickerValue" => x
    static member inline suffixIcon (x: string) = html.renderFragment("SuffixIcon", html.text x)
    static member inline suffixIcon (node) = html.renderFragment("SuffixIcon", node)
    static member inline suffixIcon (nodes) = html.renderFragment("SuffixIcon", fragment { yield! nodes })
    static member inline renderExtraFooter (x: string) = html.renderFragment("RenderExtraFooter", html.text x)
    static member inline renderExtraFooter (node) = html.renderFragment("RenderExtraFooter", node)
    static member inline renderExtraFooter (nodes) = html.renderFragment("RenderExtraFooter", fragment { yield! nodes })
    static member inline onClearClick fn = html.callback<unit>("OnClearClick", fn)
    static member inline onOpenChange fn = html.callback<System.Boolean>("OnOpenChange", fn)
    static member inline onPanelChange fn = html.callback<AntDesign.DateTimeChangedEventArgs>("OnPanelChange", fn)
    static member inline disabledDate (fn) = "DisabledDate" => (System.Func<System.DateTime, System.Boolean>fn)
    static member inline disabledHours (fn) = "DisabledHours" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member inline disabledMinutes (fn) = "DisabledMinutes" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member inline disabledSeconds (fn) = "DisabledSeconds" => (System.Func<System.DateTime, System.Int32[]>fn)
    static member inline disabledTime (fn) = "DisabledTime" => (System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>fn)
    static member inline dateRender (fn: _ -> _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DateRender", box (System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 x2 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1 x2).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline monthCellRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "MonthCellRender", box (System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
                    

type datePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.DatePicker<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DatePicker<'TValue>>() { html.mergeAttrs attrs }

    static member inline onChange fn = html.callback<AntDesign.DateTimeChangedEventArgs>("OnChange", fn)
                    

type monthPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.MonthPicker<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MonthPicker<'TValue>>() { html.mergeAttrs attrs }


                    

type quarterPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.QuarterPicker<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.QuarterPicker<'TValue>>() { html.mergeAttrs attrs }


                    

type weekPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.WeekPicker<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.WeekPicker<'TValue>>() { html.mergeAttrs attrs }


                    

type yearPicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.YearPicker<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.YearPicker<'TValue>>() { html.mergeAttrs attrs }


                    

type timePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePicker<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.TimePicker<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TimePicker<'TValue>>() { html.mergeAttrs attrs }


                    

type rangePicker<'FunBlazorGeneric, 'TValue> =
    inherit datePickerBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.RangePicker<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.RangePicker<'TValue>>() { html.mergeAttrs attrs }

    static member inline value (x: 'TValue) = "Value" => x
    static member inline onChange fn = html.callback<AntDesign.DateRangeChangedEventArgs>("OnChange", fn)
                    

type inputNumber<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.InputNumber<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.InputNumber<'TValue>>() { html.mergeAttrs attrs }

    static member inline formatter (fn) = "Formatter" => (System.Func<'TValue, System.String>fn)
    static member inline parser (fn) = "Parser" => (System.Func<System.String, System.String>fn)
    static member inline step (x: 'TValue) = "Step" => x
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x
    static member inline max (x: 'TValue) = "Max" => x
    static member inline min (x: 'TValue) = "Min" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline onChange fn = html.callback<'TValue>("OnChange", fn)
    static member inline onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
                    

type input<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Input<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Input<'TValue>>() { html.mergeAttrs attrs }

    static member inline addOnBefore (x: string) = html.renderFragment("AddOnBefore", html.text x)
    static member inline addOnBefore (node) = html.renderFragment("AddOnBefore", node)
    static member inline addOnBefore (nodes) = html.renderFragment("AddOnBefore", fragment { yield! nodes })
    static member inline addOnAfter (x: string) = html.renderFragment("AddOnAfter", html.text x)
    static member inline addOnAfter (node) = html.renderFragment("AddOnAfter", node)
    static member inline addOnAfter (nodes) = html.renderFragment("AddOnAfter", fragment { yield! nodes })
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x
    static member inline autoComplete (x: System.Boolean) = "AutoComplete" => x
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member inline bordered (x: System.Boolean) = "Bordered" => x
    static member inline debounceMilliseconds (x: System.Int32) = "DebounceMilliseconds" => x
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline inputElementSuffixClass (x: System.String) = "InputElementSuffixClass" => x
    static member inline maxLength (x: System.Int32) = "MaxLength" => x
    static member inline onBlur fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    static member inline onChange fn = html.callback<'TValue>("OnChange", fn)
    static member inline onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
    static member inline onInput fn = html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInput", fn)
    static member inline onkeyDown fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnkeyDown", fn)
    static member inline onkeyUp fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnkeyUp", fn)
    static member inline onMouseUp fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnMouseUp", fn)
    static member inline onPressEnter fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnPressEnter", fn)
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline prefix (x: string) = html.renderFragment("Prefix", html.text x)
    static member inline prefix (node) = html.renderFragment("Prefix", node)
    static member inline prefix (nodes) = html.renderFragment("Prefix", fragment { yield! nodes })
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x
    static member inline stopPropagation (x: System.Boolean) = "StopPropagation" => x
    static member inline suffix (x: string) = html.renderFragment("Suffix", html.text x)
    static member inline suffix (node) = html.renderFragment("Suffix", node)
    static member inline suffix (nodes) = html.renderFragment("Suffix", fragment { yield! nodes })
    static member inline type' (x: System.String) = "Type" => x
    static member inline wrapperStyle (x: System.String) = "WrapperStyle" => x
                    

type search<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<AntDesign.Search>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Search>() { html.mergeAttrs attrs }

    static member inline classicSearchIcon (x: System.Boolean) = "ClassicSearchIcon" => x
    static member inline enterButton (x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline onSearch fn = html.callback<System.String>("OnSearch", fn)
                    

type autoCompleteSearch<'FunBlazorGeneric> =
    inherit search<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AutoCompleteSearch>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteSearch>() { html.mergeAttrs attrs }


                    

type autoCompleteInput<'FunBlazorGeneric, 'TValue> =
    inherit input<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.AutoCompleteInput<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AutoCompleteInput<'TValue>>() { html.mergeAttrs attrs }


                    

type inputPassword<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<AntDesign.InputPassword>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.InputPassword>() { html.mergeAttrs attrs }

    static member inline iconRender (x: string) = html.renderFragment("IconRender", html.text x)
    static member inline iconRender (node) = html.renderFragment("IconRender", node)
    static member inline iconRender (nodes) = html.renderFragment("IconRender", fragment { yield! nodes })
    static member inline showPassword (x: System.Boolean) = "ShowPassword" => x
    static member inline visibilityToggle (x: System.Boolean) = "VisibilityToggle" => x
                    

type textArea<'FunBlazorGeneric> =
    inherit input<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<AntDesign.TextArea>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TextArea>() { html.mergeAttrs attrs }

    static member inline autoSize (x: System.Boolean) = "AutoSize" => x
    static member inline defaultToEmptyString (x: System.Boolean) = "DefaultToEmptyString" => x
    static member inline maxRows (x: System.UInt32) = "MaxRows" => x
    static member inline minRows (x: System.UInt32) = "MinRows" => x
    static member inline rows (x: System.UInt32) = "Rows" => x
    static member inline onResize fn = html.callback<AntDesign.OnResizeEventArgs>("OnResize", fn)
    static member inline showCount (x: System.Boolean) = "ShowCount" => x
    static member inline value (x: System.String) = "Value" => x
                    

type radioGroup<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.RadioGroup<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.RadioGroup<'TValue>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.RadioGroup<'TValue>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.RadioGroup<'TValue>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.RadioGroup<'TValue>>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline buttonStyle (x: AntDesign.RadioButtonStyle) = "ButtonStyle" => x
    static member inline name (x: System.String) = "Name" => x
    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x
    static member inline onChange fn = html.callback<'TValue>("OnChange", fn)
    static member inline options (x: OneOf.OneOf<System.String[], AntDesign.RadioOption<'TValue>[]>) = "Options" => x
                    

type enumRadioGroup<'FunBlazorGeneric, 'TEnum> =
    inherit radioGroup<'FunBlazorGeneric, 'TEnum>
    static member inline create () = ComponentBuilder<AntDesign.EnumRadioGroup<'TEnum>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.EnumRadioGroup<'TEnum>>() { html.mergeAttrs attrs }


                    

type selectBase<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TItemValue>
    static member inline create () = ComponentBuilder<AntDesign.SelectBase<'TItemValue, 'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SelectBase<'TItemValue, 'TItem>>() { html.mergeAttrs attrs }

    static member inline allowClear (x: System.Boolean) = "AllowClear" => x
    static member inline autoClearSearchValue (x: System.Boolean) = "AutoClearSearchValue" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline mode (x: System.String) = "Mode" => x
    static member inline enableSearch (x: System.Boolean) = "EnableSearch" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline open' (x: System.Boolean) = "Open" => x
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline onFocus (x: System.Action) = "OnFocus" => x
    static member inline sortByGroup (x: AntDesign.SortDirection) = "SortByGroup" => x
    static member inline sortByLabel (x: AntDesign.SortDirection) = "SortByLabel" => x
    static member inline hideSelected (x: System.Boolean) = "HideSelected" => x
    static member inline valueChanged fn = html.callback<'TItemValue>("ValueChanged", fn)
    static member inline valuesChanged fn = html.callback<System.Collections.Generic.IEnumerable<'TItemValue>>("ValuesChanged", fn)
    static member inline suffixIcon (x: string) = html.renderFragment("SuffixIcon", html.text x)
    static member inline suffixIcon (node) = html.renderFragment("SuffixIcon", node)
    static member inline suffixIcon (nodes) = html.renderFragment("SuffixIcon", fragment { yield! nodes })
    static member inline prefixIcon (x: string) = html.renderFragment("PrefixIcon", html.text x)
    static member inline prefixIcon (node) = html.renderFragment("PrefixIcon", node)
    static member inline prefixIcon (nodes) = html.renderFragment("PrefixIcon", fragment { yield! nodes })
    static member inline defaultValues (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "DefaultValues" => x
    static member inline onClearSelected (x: System.Action) = "OnClearSelected" => x
    static member inline onSelectedItemChanged (fn) = "OnSelectedItemChanged" => (System.Action<'TItem>fn)
    static member inline onSelectedItemsChanged (fn) = "OnSelectedItemsChanged" => (System.Action<System.Collections.Generic.IEnumerable<'TItem>>fn)
    static member inline values (x: System.Collections.Generic.IEnumerable<'TItemValue>) = "Values" => x
    static member inline values' (value: IStore<System.Collections.Generic.IEnumerable<'TItemValue>>) = html.bind("Values", value)
    static member inline values' (value: cval<System.Collections.Generic.IEnumerable<'TItemValue>>) = html.bind("Values", value)
    static member inline values' (valueFn: System.Collections.Generic.IEnumerable<'TItemValue> * (System.Collections.Generic.IEnumerable<'TItemValue> -> unit)) = html.bind("Values", valueFn)
    static member inline customTagLabelToValue (fn) = "CustomTagLabelToValue" => (System.Func<System.String, 'TItemValue>fn)
    static member inline selectOptions (x: string) = html.renderFragment("SelectOptions", html.text x)
    static member inline selectOptions (node) = html.renderFragment("SelectOptions", node)
    static member inline selectOptions (nodes) = html.renderFragment("SelectOptions", fragment { yield! nodes })
    static member inline maxTagTextLength (x: System.Int32) = "MaxTagTextLength" => x
    static member inline labelInValue (x: System.Boolean) = "LabelInValue" => x
    static member inline maxTagCount (x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x
    static member inline valueOnClear (x: 'TItemValue) = "ValueOnClear" => x
                    

type select'<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit selectBase<'FunBlazorGeneric, 'TItemValue, 'TItem>
    static member inline create () = ComponentBuilder<AntDesign.Select<'TItemValue, 'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Select<'TItemValue, 'TItem>>() { html.mergeAttrs attrs }

    static member inline boundaryAdjustMode (x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x
    static member inline bordered (x: System.Boolean) = "Bordered" => x
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member inline dataSourceEqualityComparer (x: System.Collections.Generic.IEqualityComparer<'TItem>) = "DataSourceEqualityComparer" => x
    static member inline defaultActiveFirstOption (x: System.Boolean) = "DefaultActiveFirstOption" => x
    static member inline disabledName (x: System.String) = "DisabledName" => x
    static member inline dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x
    static member inline dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x
    static member inline dropdownRender (fn: _ -> NodeRenderFragment) = AttrRenderFragment(fun comp builder index -> builder.AddAttribute(index, "DropdownRender", box (System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>(fun x1 -> Microsoft.AspNetCore.Components.RenderFragment(fun tb -> (fn x1).Invoke(comp, tb, 0) |> ignore)))); index + 1)
    static member inline groupName (x: System.String) = "GroupName" => x
    static member inline ignoreItemChanges (x: System.Boolean) = "IgnoreItemChanges" => x
    static member inline itemTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("ItemTemplate", render)
    static member inline labelName (x: System.String) = "LabelName" => x
    static member inline labelTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("LabelTemplate", render)
    static member inline maxTagPlaceholder (render: System.Collections.Generic.IEnumerable<'TItem> -> NodeRenderFragment) = html.renderFragment("MaxTagPlaceholder", render)
    static member inline notFoundContent (x: string) = html.renderFragment("NotFoundContent", html.text x)
    static member inline notFoundContent (node) = html.renderFragment("NotFoundContent", node)
    static member inline notFoundContent (nodes) = html.renderFragment("NotFoundContent", fragment { yield! nodes })
    static member inline onBlur (x: System.Action) = "OnBlur" => x
    static member inline onCreateCustomTag (fn) = "OnCreateCustomTag" => (System.Action<System.String>fn)
    static member inline onDataSourceChanged (x: System.Action) = "OnDataSourceChanged" => x
    static member inline onDropdownVisibleChange (fn) = "OnDropdownVisibleChange" => (System.Action<System.Boolean>fn)
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x
    static member inline onSearch (fn) = "OnSearch" => (System.Action<System.String>fn)
    static member inline popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member inline showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x
    static member inline showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x
    static member inline tokenSeparators (x: System.Char[]) = "TokenSeparators" => x
    static member inline valueChanged fn = html.callback<'TItemValue>("ValueChanged", fn)
    static member inline valueName (x: System.String) = "ValueName" => x
    static member inline value (x: 'TItemValue) = "Value" => x
    static member inline value' (value: IStore<'TItemValue>) = html.bind("Value", value)
    static member inline value' (value: cval<'TItemValue>) = html.bind("Value", value)
    static member inline value' (valueFn: 'TItemValue * ('TItemValue -> unit)) = html.bind("Value", valueFn)
    static member inline defaultValue (x: 'TItemValue) = "DefaultValue" => x
                    

type enumSelect<'FunBlazorGeneric, 'TEnum> =
    inherit select'<'FunBlazorGeneric, 'TEnum, 'TEnum>
    static member inline create () = ComponentBuilder<AntDesign.EnumSelect<'TEnum>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.EnumSelect<'TEnum>>() { html.mergeAttrs attrs }


                    

type simpleSelect<'FunBlazorGeneric> =
    inherit select'<'FunBlazorGeneric, System.String, System.String>
    static member inline create () = ComponentBuilder<AntDesign.SimpleSelect>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SimpleSelect>() { html.mergeAttrs attrs }


                    

type treeSelect<'FunBlazorGeneric, 'TItem when 'TItem : not struct> =
    inherit selectBase<'FunBlazorGeneric, System.String, 'TItem>
    static member inline create () = ComponentBuilder<AntDesign.TreeSelect<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeSelect<'TItem>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.TreeSelect<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.TreeSelect<'TItem>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.TreeSelect<'TItem>>(){ x }
    static member inline showExpand (x: System.Boolean) = "ShowExpand" => x
    static member inline multiple (x: System.Boolean) = "Multiple" => x
    static member inline treeCheckable (x: System.Boolean) = "TreeCheckable" => x
    static member inline popupContainerSelector (x: System.String) = "PopupContainerSelector" => x
    static member inline onMouseEnter (x: System.Action) = "OnMouseEnter" => x
    static member inline onMouseLeave (x: System.Action) = "OnMouseLeave" => x
    static member inline labelTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("LabelTemplate", render)
    static member inline showSearchIcon (x: System.Boolean) = "ShowSearchIcon" => x
    static member inline showArrowIcon (x: System.Boolean) = "ShowArrowIcon" => x
    static member inline nodes (x: AntDesign.TreeNode<'TItem>[]) = "Nodes" => x
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline treeDefaultExpandAll (x: System.Boolean) = "TreeDefaultExpandAll" => x
    static member inline dataItemExpression (fn) = "DataItemExpression" => (System.Func<System.Collections.Generic.IEnumerable<'TItem>, System.String, 'TItem>fn)
    static member inline dataItemsExpression (fn) = "DataItemsExpression" => (System.Func<System.Collections.Generic.IList<'TItem>, System.Collections.Generic.IEnumerable<System.String>, System.Collections.Generic.IEnumerable<'TItem>>fn)
    static member inline rootValue (x: System.String) = "RootValue" => x
    static member inline titleExpression (fn) = "TitleExpression" => (System.Func<'TItem, System.String>fn)
    static member inline keyExpression (fn) = "KeyExpression" => (System.Func<'TItem, System.String>fn)
    static member inline iconExpression (fn) = "IconExpression" => (System.Func<'TItem, System.String>fn)
    static member inline isLeafExpression (fn) = "IsLeafExpression" => (System.Func<'TItem, System.Boolean>fn)
    static member inline childrenExpression (fn) = "ChildrenExpression" => (System.Func<'TItem, System.Collections.Generic.IList<'TItem>>fn)
    static member inline disabledExpression (fn) = "DisabledExpression" => (System.Func<'TItem, System.Boolean>fn)
    static member inline dropdownMatchSelectWidth (x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x
    static member inline dropdownMaxWidth (x: System.String) = "DropdownMaxWidth" => x
    static member inline popupContainerMaxHeight (x: System.String) = "PopupContainerMaxHeight" => x
                    

type simpleTreeSelect<'FunBlazorGeneric, 'TItem when 'TItem : not struct> =
    inherit treeSelect<'FunBlazorGeneric, 'TItem>
    static member inline create () = ComponentBuilder<AntDesign.SimpleTreeSelect<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SimpleTreeSelect<'TItem>>() { html.mergeAttrs attrs }

    static member inline childrenMethodExpression (fn) = "ChildrenMethodExpression" => (System.Func<System.String, System.Collections.Generic.IList<'TItem>>fn)
                    

type slider<'FunBlazorGeneric, 'TValue> =
    inherit antInputComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Slider<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Slider<'TValue>>() { html.mergeAttrs attrs }

    static member inline defaultValue (x: 'TValue) = "DefaultValue" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline dots (x: System.Boolean) = "Dots" => x
    static member inline included (x: System.Boolean) = "Included" => x
    static member inline marks (x: AntDesign.SliderMark[]) = "Marks" => x
    static member inline max (x: System.Double) = "Max" => x
    static member inline min (x: System.Double) = "Min" => x
    static member inline reverse (x: System.Boolean) = "Reverse" => x
    static member inline step (x: System.Nullable<System.Double>) = "Step" => x
    static member inline vertical (x: System.Boolean) = "Vertical" => x
    static member inline onAfterChange (fn) = "OnAfterChange" => (System.Action<'TValue>fn)
    static member inline onChange (fn) = "OnChange" => (System.Action<'TValue>fn)
    static member inline hasTooltip (x: System.Boolean) = "HasTooltip" => x
    static member inline tipFormatter (fn) = "TipFormatter" => (System.Func<System.Double, System.String>fn)
    static member inline tooltipPlacement (x: AntDesign.Placement) = "TooltipPlacement" => x
    static member inline tooltipVisible (x: System.Boolean) = "TooltipVisible" => x
    static member inline getTooltipPopupContainer (x: System.Object) = "GetTooltipPopupContainer" => x
    static member inline value (x: 'TValue) = "Value" => x
                    

type descriptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Descriptions>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Descriptions>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Descriptions>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Descriptions>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Descriptions>(){ x }
    static member inline bordered (x: System.Boolean) = "Bordered" => x
    static member inline layout (x: System.String) = "Layout" => x
    static member inline column (x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>) = "Column" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline colon (x: System.Boolean) = "Colon" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type descriptionsItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.DescriptionsItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DescriptionsItem>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.DescriptionsItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.DescriptionsItem>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.DescriptionsItem>(){ x }
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline span (x: System.Int32) = "Span" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type divider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Divider>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Divider>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Divider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Divider>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Divider>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline text (x: System.String) = "Text" => x
    static member inline plain (x: System.Boolean) = "Plain" => x
    static member inline type' (x: AntDesign.DirectionVHType) = "Type" => x
    static member inline orientation (x: System.String) = "Orientation" => x
    static member inline dashed (x: System.Boolean) = "Dashed" => x
                    

type drawer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Drawer>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Drawer>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Drawer>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Drawer>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Drawer>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline content (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Content" => x
    static member inline closable (x: System.Boolean) = "Closable" => x
    static member inline maskClosable (x: System.Boolean) = "MaskClosable" => x
    static member inline mask (x: System.Boolean) = "Mask" => x
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x
    static member inline title (x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Title" => x
    static member inline placement (x: System.String) = "Placement" => x
    static member inline maskStyle (x: System.String) = "MaskStyle" => x
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x
    static member inline wrapClassName (x: System.String) = "WrapClassName" => x
    static member inline width (x: System.Int32) = "Width" => x
    static member inline height (x: System.Int32) = "Height" => x
    static member inline zIndex (x: System.Int32) = "ZIndex" => x
    static member inline offsetX (x: System.Int32) = "OffsetX" => x
    static member inline offsetY (x: System.Int32) = "OffsetY" => x
    static member inline visible (x: System.Boolean) = "Visible" => x
    static member inline onClose fn = html.callback<unit>("OnClose", fn)
    static member inline handler (x: string) = html.renderFragment("Handler", html.text x)
    static member inline handler (node) = html.renderFragment("Handler", node)
    static member inline handler (nodes) = html.renderFragment("Handler", fragment { yield! nodes })
                    

type drawerContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.DrawerContainer>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DrawerContainer>() { html.mergeAttrs attrs }


                    

type empty<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Empty>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Empty>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Empty>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Empty>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Empty>(){ x }
    static member inline prefixCls (x: System.String) = "PrefixCls" => x
    static member inline imageStyle (x: System.String) = "ImageStyle" => x
    static member inline small (x: System.Boolean) = "Small" => x
    static member inline simple (x: System.Boolean) = "Simple" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline description (x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = "Description" => x
    static member inline descriptionTemplate (x: string) = html.renderFragment("DescriptionTemplate", html.text x)
    static member inline descriptionTemplate (node) = html.renderFragment("DescriptionTemplate", node)
    static member inline descriptionTemplate (nodes) = html.renderFragment("DescriptionTemplate", fragment { yield! nodes })
    static member inline image (x: System.String) = "Image" => x
    static member inline imageTemplate (x: string) = html.renderFragment("ImageTemplate", html.text x)
    static member inline imageTemplate (node) = html.renderFragment("ImageTemplate", node)
    static member inline imageTemplate (nodes) = html.renderFragment("ImageTemplate", fragment { yield! nodes })
                    

type form<'FunBlazorGeneric, 'TModel> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Form<'TModel>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Form<'TModel>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Form<'TModel>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Form<'TModel>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Form<'TModel>>(){ x }
    static member inline layout (x: System.String) = "Layout" => x
    static member inline childContent (render: 'TModel -> NodeRenderFragment) = html.renderFragment("ChildContent", render)
    static member inline labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x
    static member inline labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x
    static member inline labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x
    static member inline labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x
    static member inline wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x
    static member inline wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x
    static member inline wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline name (x: System.String) = "Name" => x
    static member inline model (x: 'TModel) = "Model" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline onFinish fn = html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnFinish", fn)
    static member inline onFinishFailed fn = html.callback<Microsoft.AspNetCore.Components.Forms.EditContext>("OnFinishFailed", fn)
    static member inline onFieldChanged fn = html.callback<Microsoft.AspNetCore.Components.Forms.FieldChangedEventArgs>("OnFieldChanged", fn)
    static member inline onValidationRequested fn = html.callback<Microsoft.AspNetCore.Components.Forms.ValidationRequestedEventArgs>("OnValidationRequested", fn)
    static member inline onValidationStateChanged fn = html.callback<Microsoft.AspNetCore.Components.Forms.ValidationStateChangedEventArgs>("OnValidationStateChanged", fn)
    static member inline validator (x: string) = html.renderFragment("Validator", html.text x)
    static member inline validator (node) = html.renderFragment("Validator", node)
    static member inline validator (nodes) = html.renderFragment("Validator", fragment { yield! nodes })
    static member inline validateOnChange (x: System.Boolean) = "ValidateOnChange" => x
    static member inline validateMode (x: AntDesign.FormValidateMode) = "ValidateMode" => x
    static member inline validateMessages (x: AntDesign.FormValidateErrorMessages) = "ValidateMessages" => x
                    

type formItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.FormItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.FormItem>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.FormItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.FormItem>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.FormItem>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline label (x: System.String) = "Label" => x
    static member inline labelTemplate (x: string) = html.renderFragment("LabelTemplate", html.text x)
    static member inline labelTemplate (node) = html.renderFragment("LabelTemplate", node)
    static member inline labelTemplate (nodes) = html.renderFragment("LabelTemplate", fragment { yield! nodes })
    static member inline labelCol (x: AntDesign.ColLayoutParam) = "LabelCol" => x
    static member inline labelAlign (x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x
    static member inline labelColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x
    static member inline labelColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x
    static member inline wrapperCol (x: AntDesign.ColLayoutParam) = "WrapperCol" => x
    static member inline wrapperColSpan (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x
    static member inline wrapperColOffset (x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x
    static member inline noStyle (x: System.Boolean) = "NoStyle" => x
    static member inline required (x: System.Boolean) = "Required" => x
    static member inline labelStyle (x: System.String) = "LabelStyle" => x
    static member inline rules (x: AntDesign.FormValidationRule[]) = "Rules" => x
    static member inline hasFeedback (x: System.Boolean) = "HasFeedback" => x
    static member inline validateStatus (x: AntDesign.FormValidateStatus) = "ValidateStatus" => x
    static member inline help (x: System.String) = "Help" => x
                    

type row<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Row>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Row>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Row>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Row>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Row>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline type' (x: System.String) = "Type" => x
    static member inline align (x: System.String) = "Align" => x
    static member inline justify (x: System.String) = "Justify" => x
    static member inline wrap (x: System.Boolean) = "Wrap" => x
    static member inline gutter (x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Collections.Generic.Dictionary<System.String, System.Int32>>>) = "Gutter" => x
    static member inline onBreakpoint fn = html.callback<AntDesign.BreakpointType>("OnBreakpoint", fn)
    static member inline defaultBreakpoint (x: System.Nullable<AntDesign.BreakpointType>) = "DefaultBreakpoint" => x
                    

type image<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Image>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Image>() { html.mergeAttrs attrs }

    static member inline alt (x: System.String) = "Alt" => x
    static member inline fallback (x: System.String) = "Fallback" => x
    static member inline height (x: System.String) = "Height" => x
    static member inline width (x: System.String) = "Width" => x
    static member inline placeholder (x: string) = html.renderFragment("Placeholder", html.text x)
    static member inline placeholder (node) = html.renderFragment("Placeholder", node)
    static member inline placeholder (nodes) = html.renderFragment("Placeholder", fragment { yield! nodes })
    static member inline preview (x: System.Boolean) = "Preview" => x
    static member inline previewVisible (x: System.Boolean) = "PreviewVisible" => x
    static member inline src (x: System.String) = "Src" => x
    static member inline previewSrc (x: System.String) = "PreviewSrc" => x
    static member inline onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member inline locale (x: AntDesign.ImageLocale) = "Locale" => x
                    

type imagePreviewContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ImagePreviewContainer>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ImagePreviewContainer>() { html.mergeAttrs attrs }


                    

type inputGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.InputGroup>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.InputGroup>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.InputGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.InputGroup>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.InputGroup>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline compact (x: System.Boolean) = "Compact" => x
    static member inline size (x: System.String) = "Size" => x
                    

type sider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Sider>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Sider>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Sider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Sider>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Sider>(){ x }
    static member inline collapsible (x: System.Boolean) = "Collapsible" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline trigger (x: string) = html.renderFragment("Trigger", html.text x)
    static member inline trigger (node) = html.renderFragment("Trigger", node)
    static member inline trigger (nodes) = html.renderFragment("Trigger", fragment { yield! nodes })
    static member inline noTrigger (x: System.Boolean) = "NoTrigger" => x
    static member inline breakpoint (x: System.Nullable<AntDesign.BreakpointType>) = "Breakpoint" => x
    static member inline theme (x: AntDesign.SiderTheme) = "Theme" => x
    static member inline width (x: System.Int32) = "Width" => x
    static member inline collapsedWidth (x: System.Int32) = "CollapsedWidth" => x
    static member inline collapsed (x: System.Boolean) = "Collapsed" => x
    static member inline onCollapse fn = html.callback<System.Boolean>("OnCollapse", fn)
    static member inline onBreakpoint fn = html.callback<System.Boolean>("OnBreakpoint", fn)
                    

type antList<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AntList<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntList<'TItem>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.AntList<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.AntList<'TItem>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.AntList<'TItem>>(){ x }
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member inline bordered (x: System.Boolean) = "Bordered" => x
    static member inline header (x: string) = html.renderFragment("Header", html.text x)
    static member inline header (node) = html.renderFragment("Header", node)
    static member inline header (nodes) = html.renderFragment("Header", fragment { yield! nodes })
    static member inline footer (x: string) = html.renderFragment("Footer", html.text x)
    static member inline footer (node) = html.renderFragment("Footer", node)
    static member inline footer (nodes) = html.renderFragment("Footer", fragment { yield! nodes })
    static member inline loadMore (x: string) = html.renderFragment("LoadMore", html.text x)
    static member inline loadMore (node) = html.renderFragment("LoadMore", node)
    static member inline loadMore (nodes) = html.renderFragment("LoadMore", fragment { yield! nodes })
    static member inline itemLayout (x: AntDesign.ListItemLayout) = "ItemLayout" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline noResult (x: System.String) = "NoResult" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline split (x: System.Boolean) = "Split" => x
    static member inline grid (x: AntDesign.ListGridType) = "Grid" => x
    static member inline pagination (x: AntDesign.PaginationOptions) = "Pagination" => x
    static member inline childContent (render: 'TItem -> NodeRenderFragment) = html.renderFragment("ChildContent", render)
                    

type listItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ListItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ListItem>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.ListItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.ListItem>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.ListItem>(){ x }
    static member inline content (x: System.String) = "Content" => x
    static member inline extra (x: string) = html.renderFragment("Extra", html.text x)
    static member inline extra (node) = html.renderFragment("Extra", node)
    static member inline extra (nodes) = html.renderFragment("Extra", fragment { yield! nodes })
    static member inline actions (x: Microsoft.AspNetCore.Components.RenderFragment[]) = "Actions" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline colStyle (x: System.String) = "ColStyle" => x
    static member inline itemCount (x: System.Int32) = "ItemCount" => x
    static member inline onClick fn = html.callback<unit>("OnClick", fn)
    static member inline noFlex (x: System.Boolean) = "NoFlex" => x
                    

type listItemMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ListItemMeta>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ListItemMeta>() { html.mergeAttrs attrs }

    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline avatar (x: System.String) = "Avatar" => x
    static member inline avatarTemplate (x: string) = html.renderFragment("AvatarTemplate", html.text x)
    static member inline avatarTemplate (node) = html.renderFragment("AvatarTemplate", node)
    static member inline avatarTemplate (nodes) = html.renderFragment("AvatarTemplate", fragment { yield! nodes })
    static member inline description (x: System.String) = "Description" => x
    static member inline descriptionTemplate (x: string) = html.renderFragment("DescriptionTemplate", html.text x)
    static member inline descriptionTemplate (node) = html.renderFragment("DescriptionTemplate", node)
    static member inline descriptionTemplate (nodes) = html.renderFragment("DescriptionTemplate", fragment { yield! nodes })
                    

type mentions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Mentions>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Mentions>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Mentions>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Mentions>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Mentions>(){ x }
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member inline disable (x: System.Boolean) = "Disable" => x
    static member inline readonly (x: System.Boolean) = "Readonly" => x
    static member inline prefix (x: System.String) = "Prefix" => x
    static member inline split (x: System.String) = "Split" => x
    static member inline defaultValue (x: System.String) = "DefaultValue" => x
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline value (x: System.String) = "Value" => x
    static member inline placement (x: System.String) = "Placement" => x
    static member inline rows (x: System.Int32) = "Rows" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline valueChange fn = html.callback<System.String>("ValueChange", fn)
    static member inline onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
    static member inline onBlur fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    static member inline onSearch fn = html.callback<System.EventArgs>("OnSearch", fn)
    static member inline noFoundContent (x: string) = html.renderFragment("NoFoundContent", html.text x)
    static member inline noFoundContent (node) = html.renderFragment("NoFoundContent", node)
    static member inline noFoundContent (nodes) = html.renderFragment("NoFoundContent", fragment { yield! nodes })
                    

type mentionsOption<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.MentionsOption>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MentionsOption>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.MentionsOption>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.MentionsOption>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.MentionsOption>(){ x }
    static member inline value (x: System.String) = "Value" => x
    static member inline disable (x: System.Boolean) = "Disable" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type menu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Menu>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Menu>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Menu>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Menu>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Menu>(){ x }
    static member inline theme (x: AntDesign.MenuTheme) = "Theme" => x
    static member inline mode (x: AntDesign.MenuMode) = "Mode" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline onSubmenuClicked fn = html.callback<AntDesign.SubMenu>("OnSubmenuClicked", fn)
    static member inline onMenuItemClicked fn = html.callback<AntDesign.MenuItem>("OnMenuItemClicked", fn)
    static member inline accordion (x: System.Boolean) = "Accordion" => x
    static member inline selectable (x: System.Boolean) = "Selectable" => x
    static member inline multiple (x: System.Boolean) = "Multiple" => x
    static member inline inlineCollapsed (x: System.Boolean) = "InlineCollapsed" => x
    static member inline inlineIndent (x: System.Int32) = "InlineIndent" => x
    static member inline autoCloseDropdown (x: System.Boolean) = "AutoCloseDropdown" => x
    static member inline defaultSelectedKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultSelectedKeys" => x
    static member inline defaultOpenKeys (x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultOpenKeys" => x
    static member inline openKeys (x: System.String[]) = "OpenKeys" => x
    static member inline openKeys' (value: IStore<System.String[]>) = html.bind("OpenKeys", value)
    static member inline openKeys' (value: cval<System.String[]>) = html.bind("OpenKeys", value)
    static member inline openKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("OpenKeys", valueFn)
    static member inline openKeysChanged fn = html.callback<System.String[]>("OpenKeysChanged", fn)
    static member inline onOpenChange fn = html.callback<System.String[]>("OnOpenChange", fn)
    static member inline selectedKeys (x: System.String[]) = "SelectedKeys" => x
    static member inline selectedKeys' (value: IStore<System.String[]>) = html.bind("SelectedKeys", value)
    static member inline selectedKeys' (value: cval<System.String[]>) = html.bind("SelectedKeys", value)
    static member inline selectedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("SelectedKeys", valueFn)
    static member inline selectedKeysChanged fn = html.callback<System.String[]>("SelectedKeysChanged", fn)
    static member inline triggerSubMenuAction (x: AntDesign.Trigger) = "TriggerSubMenuAction" => x
                    

type menuItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.MenuItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MenuItem>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.MenuItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.MenuItem>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.MenuItem>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline key (x: System.String) = "Key" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member inline routerLink (x: System.String) = "RouterLink" => x
    static member inline routerMatch (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "RouterMatch" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline icon (x: System.String) = "Icon" => x
    static member inline iconTemplate (x: string) = html.renderFragment("IconTemplate", html.text x)
    static member inline iconTemplate (node) = html.renderFragment("IconTemplate", node)
    static member inline iconTemplate (nodes) = html.renderFragment("IconTemplate", fragment { yield! nodes })
                    

type menuItemGroup<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.MenuItemGroup>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MenuItemGroup>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.MenuItemGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.MenuItemGroup>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.MenuItemGroup>(){ x }
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline key (x: System.String) = "Key" => x
                    

type menuLink<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.MenuLink>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MenuLink>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.MenuLink>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.MenuLink>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.MenuLink>(){ x }
    static member inline activeClass (x: System.String) = "ActiveClass" => x
    static member inline href (x: System.String) = "Href" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline attributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x
    static member inline match' (x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x
                    

type subMenu<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.SubMenu>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SubMenu>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.SubMenu>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.SubMenu>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.SubMenu>(){ x }
    static member inline placement (x: System.Nullable<AntDesign.Placement>) = "Placement" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline key (x: System.String) = "Key" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline isOpen (x: System.Boolean) = "IsOpen" => x
    static member inline onTitleClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnTitleClick", fn)
                    

type message<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Message>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Message>() { html.mergeAttrs attrs }


                    

type messageItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.MessageItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MessageItem>() { html.mergeAttrs attrs }

    static member inline config (x: AntDesign.MessageConfig) = "Config" => x
                    

type comfirmContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ComfirmContainer>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ComfirmContainer>() { html.mergeAttrs attrs }


                    

type confirm<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Confirm>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Confirm>() { html.mergeAttrs attrs }

    static member inline config (x: AntDesign.ConfirmOptions) = "Config" => x
    static member inline confirmRef (x: AntDesign.ConfirmRef) = "ConfirmRef" => x
    static member inline onRemove fn = html.callback<AntDesign.ConfirmRef>("OnRemove", fn)
                    

type dialog<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Dialog>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Dialog>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Dialog>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Dialog>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Dialog>(){ x }
    static member inline config (x: AntDesign.DialogOptions) = "Config" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline visible (x: System.Boolean) = "Visible" => x
                    

type dialogWrapper<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.DialogWrapper>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DialogWrapper>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.DialogWrapper>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.DialogWrapper>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.DialogWrapper>(){ x }
    static member inline config (x: AntDesign.DialogOptions) = "Config" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x
    static member inline visible (x: System.Boolean) = "Visible" => x
    static member inline onBeforeDestroy fn = html.callback<System.ComponentModel.CancelEventArgs>("OnBeforeDestroy", fn)
    static member inline onAfterShow fn = html.callback<unit>("OnAfterShow", fn)
    static member inline onAfterHide fn = html.callback<unit>("OnAfterHide", fn)
                    

type modal<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Modal>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Modal>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Modal>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Modal>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Modal>(){ x }
    static member inline modalRef (x: AntDesign.ModalRef) = "ModalRef" => x
    static member inline afterClose (fn) = "AfterClose" => (System.Func<System.Threading.Tasks.Task>fn)
    static member inline bodyStyle (x: System.String) = "BodyStyle" => x
    static member inline cancelText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "CancelText" => x
    static member inline centered (x: System.Boolean) = "Centered" => x
    static member inline closable (x: System.Boolean) = "Closable" => x
    static member inline draggable (x: System.Boolean) = "Draggable" => x
    static member inline dragInViewport (x: System.Boolean) = "DragInViewport" => x
    static member inline closeIcon (x: string) = html.renderFragment("CloseIcon", html.text x)
    static member inline closeIcon (node) = html.renderFragment("CloseIcon", node)
    static member inline closeIcon (nodes) = html.renderFragment("CloseIcon", fragment { yield! nodes })
    static member inline confirmLoading (x: System.Boolean) = "ConfirmLoading" => x
    static member inline destroyOnClose (x: System.Boolean) = "DestroyOnClose" => x
    static member inline footer (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Footer" => x
    static member inline getContainer (x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "GetContainer" => x
    static member inline keyboard (x: System.Boolean) = "Keyboard" => x
    static member inline mask (x: System.Boolean) = "Mask" => x
    static member inline maskClosable (x: System.Boolean) = "MaskClosable" => x
    static member inline maskStyle (x: System.String) = "MaskStyle" => x
    static member inline okText (x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "OkText" => x
    static member inline okType (x: System.String) = "OkType" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline visible (x: System.Boolean) = "Visible" => x
    static member inline width (x: OneOf.OneOf<System.String, System.Double>) = "Width" => x
    static member inline wrapClassName (x: System.String) = "WrapClassName" => x
    static member inline zIndex (x: System.Int32) = "ZIndex" => x
    static member inline onCancel fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCancel", fn)
    static member inline onOk fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnOk", fn)
    static member inline okButtonProps (x: AntDesign.ButtonProps) = "OkButtonProps" => x
    static member inline cancelButtonProps (x: AntDesign.ButtonProps) = "CancelButtonProps" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline locale (x: AntDesign.ModalLocale) = "Locale" => x
                    

type modalContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ModalContainer>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ModalContainer>() { html.mergeAttrs attrs }


                    

type modalFooter<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ModalFooter>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ModalFooter>() { html.mergeAttrs attrs }


                    

type pageHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.PageHeader>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.PageHeader>() { html.mergeAttrs attrs }

    static member inline ghost (x: System.Boolean) = "Ghost" => x
    static member inline backIcon (x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = "BackIcon" => x
    static member inline backIconTemplate (x: string) = html.renderFragment("BackIconTemplate", html.text x)
    static member inline backIconTemplate (node) = html.renderFragment("BackIconTemplate", node)
    static member inline backIconTemplate (nodes) = html.renderFragment("BackIconTemplate", fragment { yield! nodes })
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline subtitle (x: System.String) = "Subtitle" => x
    static member inline subtitleTemplate (x: string) = html.renderFragment("SubtitleTemplate", html.text x)
    static member inline subtitleTemplate (node) = html.renderFragment("SubtitleTemplate", node)
    static member inline subtitleTemplate (nodes) = html.renderFragment("SubtitleTemplate", fragment { yield! nodes })
    static member inline onBack fn = html.callback<unit>("OnBack", fn)
    static member inline pageHeaderContent (x: string) = html.renderFragment("PageHeaderContent", html.text x)
    static member inline pageHeaderContent (node) = html.renderFragment("PageHeaderContent", node)
    static member inline pageHeaderContent (nodes) = html.renderFragment("PageHeaderContent", fragment { yield! nodes })
    static member inline pageHeaderFooter (x: string) = html.renderFragment("PageHeaderFooter", html.text x)
    static member inline pageHeaderFooter (node) = html.renderFragment("PageHeaderFooter", node)
    static member inline pageHeaderFooter (nodes) = html.renderFragment("PageHeaderFooter", fragment { yield! nodes })
    static member inline pageHeaderBreadcrumb (x: string) = html.renderFragment("PageHeaderBreadcrumb", html.text x)
    static member inline pageHeaderBreadcrumb (node) = html.renderFragment("PageHeaderBreadcrumb", node)
    static member inline pageHeaderBreadcrumb (nodes) = html.renderFragment("PageHeaderBreadcrumb", fragment { yield! nodes })
    static member inline pageHeaderAvatar (x: string) = html.renderFragment("PageHeaderAvatar", html.text x)
    static member inline pageHeaderAvatar (node) = html.renderFragment("PageHeaderAvatar", node)
    static member inline pageHeaderAvatar (nodes) = html.renderFragment("PageHeaderAvatar", fragment { yield! nodes })
    static member inline pageHeaderTitle (x: string) = html.renderFragment("PageHeaderTitle", html.text x)
    static member inline pageHeaderTitle (node) = html.renderFragment("PageHeaderTitle", node)
    static member inline pageHeaderTitle (nodes) = html.renderFragment("PageHeaderTitle", fragment { yield! nodes })
    static member inline pageHeaderSubtitle (x: string) = html.renderFragment("PageHeaderSubtitle", html.text x)
    static member inline pageHeaderSubtitle (node) = html.renderFragment("PageHeaderSubtitle", node)
    static member inline pageHeaderSubtitle (nodes) = html.renderFragment("PageHeaderSubtitle", fragment { yield! nodes })
    static member inline pageHeaderTags (x: string) = html.renderFragment("PageHeaderTags", html.text x)
    static member inline pageHeaderTags (node) = html.renderFragment("PageHeaderTags", node)
    static member inline pageHeaderTags (nodes) = html.renderFragment("PageHeaderTags", fragment { yield! nodes })
    static member inline pageHeaderExtra (x: string) = html.renderFragment("PageHeaderExtra", html.text x)
    static member inline pageHeaderExtra (node) = html.renderFragment("PageHeaderExtra", node)
    static member inline pageHeaderExtra (nodes) = html.renderFragment("PageHeaderExtra", fragment { yield! nodes })
                    

type pagination<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Pagination>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Pagination>() { html.mergeAttrs attrs }

    static member inline total (x: System.Int32) = "Total" => x
    static member inline defaultCurrent (x: System.Int32) = "DefaultCurrent" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline current (x: System.Int32) = "Current" => x
    static member inline defaultPageSize (x: System.Int32) = "DefaultPageSize" => x
    static member inline pageSize (x: System.Int32) = "PageSize" => x
    static member inline onChange fn = html.callback<AntDesign.PaginationEventArgs>("OnChange", fn)
    static member inline hideOnSinglePage (x: System.Boolean) = "HideOnSinglePage" => x
    static member inline showSizeChanger (x: System.Boolean) = "ShowSizeChanger" => x
    static member inline pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x
    static member inline onShowSizeChange fn = html.callback<AntDesign.PaginationEventArgs>("OnShowSizeChange", fn)
    static member inline showQuickJumper (x: System.Boolean) = "ShowQuickJumper" => x
    static member inline goButton (x: string) = html.renderFragment("GoButton", html.text x)
    static member inline goButton (node) = html.renderFragment("GoButton", node)
    static member inline goButton (nodes) = html.renderFragment("GoButton", fragment { yield! nodes })
    static member inline showTitle (x: System.Boolean) = "ShowTitle" => x
    static member inline showTotal (x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = "ShowTotal" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline responsive (x: System.Boolean) = "Responsive" => x
    static member inline simple (x: System.Boolean) = "Simple" => x
    static member inline locale (x: AntDesign.PaginationLocale) = "Locale" => x
    static member inline itemRender (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("ItemRender", render)
    static member inline showLessItems (x: System.Boolean) = "ShowLessItems" => x
    static member inline showPrevNextJumpers (x: System.Boolean) = "ShowPrevNextJumpers" => x
    static member inline direction (x: System.String) = "Direction" => x
    static member inline prevIcon (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("PrevIcon", render)
    static member inline nextIcon (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("NextIcon", render)
    static member inline jumpPrevIcon (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("JumpPrevIcon", render)
    static member inline jumpNextIcon (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("JumpNextIcon", render)
    static member inline totalBoundaryShowSizeChanger (x: System.Int32) = "TotalBoundaryShowSizeChanger" => x
    static member inline unmatchedAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x
                    

type paginationOptions<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.PaginationOptions>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.PaginationOptions>() { html.mergeAttrs attrs }

    static member inline isSmall (x: System.Boolean) = "IsSmall" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline rootPrefixCls (x: System.String) = "RootPrefixCls" => x
    static member inline changeSize fn = html.callback<System.Int32>("ChangeSize", fn)
    static member inline current (x: System.Int32) = "Current" => x
    static member inline pageSize (x: System.Int32) = "PageSize" => x
    static member inline pageSizeOptions (x: System.Int32[]) = "PageSizeOptions" => x
    static member inline quickGo fn = html.callback<System.Int32>("QuickGo", fn)
    static member inline goButton (x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = "GoButton" => x
                    

type progress<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Progress>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Progress>() { html.mergeAttrs attrs }

    static member inline size (x: AntDesign.ProgressSize) = "Size" => x
    static member inline type' (x: AntDesign.ProgressType) = "Type" => x
    static member inline format (fn) = "Format" => (System.Func<System.Double, System.String>fn)
    static member inline percent (x: System.Double) = "Percent" => x
    static member inline showInfo (x: System.Boolean) = "ShowInfo" => x
    static member inline status (x: AntDesign.ProgressStatus) = "Status" => x
    static member inline strokeLinecap (x: AntDesign.ProgressStrokeLinecap) = "StrokeLinecap" => x
    static member inline successPercent (x: System.Double) = "SuccessPercent" => x
    static member inline trailColor (x: System.String) = "TrailColor" => x
    static member inline strokeWidth (x: System.Int32) = "StrokeWidth" => x
    static member inline strokeColor (x: OneOf.OneOf<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>) = "StrokeColor" => x
    static member inline steps (x: System.Int32) = "Steps" => x
    static member inline width (x: System.Int32) = "Width" => x
    static member inline gapDegree (x: System.Int32) = "GapDegree" => x
    static member inline gapPosition (x: AntDesign.ProgressGapPosition) = "GapPosition" => x
                    

type radio<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Radio<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Radio<'TValue>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Radio<'TValue>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Radio<'TValue>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Radio<'TValue>>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline value (x: 'TValue) = "Value" => x
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member inline radioButton (x: System.Boolean) = "RadioButton" => x
    static member inline checked' (x: System.Boolean) = "Checked" => x
    static member inline checked'' (value: IStore<System.Boolean>) = html.bind("Checked", value)
    static member inline checked'' (value: cval<System.Boolean>) = html.bind("Checked", value)
    static member inline checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = html.bind("Checked", valueFn)
    static member inline defaultChecked (x: System.Boolean) = "DefaultChecked" => x
    static member inline checkedChanged fn = html.callback<System.Boolean>("CheckedChanged", fn)
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline checkedChange fn = html.callback<System.Boolean>("CheckedChange", fn)
                    

type rate<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Rate>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Rate>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Rate>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Rate>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Rate>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x
    static member inline allowHalf (x: System.Boolean) = "AllowHalf" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member inline character (render: AntDesign.RateItemRenderContext -> NodeRenderFragment) = html.renderFragment("Character", render)
    static member inline count (x: System.Int32) = "Count" => x
    static member inline value (x: System.Decimal) = "Value" => x
    static member inline value' (value: IStore<System.Decimal>) = html.bind("Value", value)
    static member inline value' (value: cval<System.Decimal>) = html.bind("Value", value)
    static member inline value' (valueFn: System.Decimal * (System.Decimal -> unit)) = html.bind("Value", valueFn)
    static member inline valueChanged fn = html.callback<System.Decimal>("ValueChanged", fn)
    static member inline defaultValue (x: System.Decimal) = "DefaultValue" => x
    static member inline tooltips (x: System.String[]) = "Tooltips" => x
    static member inline onBlur fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    static member inline onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
                    

type rateItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.RateItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.RateItem>() { html.mergeAttrs attrs }

    static member inline allowHalf (x: System.Boolean) = "AllowHalf" => x
    static member inline onItemHover fn = html.callback<System.Boolean>("OnItemHover", fn)
    static member inline onItemClick fn = html.callback<System.Boolean>("OnItemClick", fn)
    static member inline tooltip (x: System.String) = "Tooltip" => x
    static member inline indexOfGroup (x: System.Int32) = "IndexOfGroup" => x
    static member inline hoverValue (x: System.Int32) = "HoverValue" => x
    static member inline hasHalf (x: System.Boolean) = "HasHalf" => x
    static member inline isFocused (x: System.Boolean) = "IsFocused" => x
                    

type result<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Result>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Result>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Result>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Result>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Result>(){ x }
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline subTitle (x: System.String) = "SubTitle" => x
    static member inline subTitleTemplate (x: string) = html.renderFragment("SubTitleTemplate", html.text x)
    static member inline subTitleTemplate (node) = html.renderFragment("SubTitleTemplate", node)
    static member inline subTitleTemplate (nodes) = html.renderFragment("SubTitleTemplate", fragment { yield! nodes })
    static member inline extra (x: string) = html.renderFragment("Extra", html.text x)
    static member inline extra (node) = html.renderFragment("Extra", node)
    static member inline extra (nodes) = html.renderFragment("Extra", fragment { yield! nodes })
    static member inline status (x: System.String) = "Status" => x
    static member inline icon (x: System.String) = "Icon" => x
    static member inline isShowIcon (x: System.Boolean) = "IsShowIcon" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type selectOption<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.SelectOption<'TItemValue, 'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SelectOption<'TItemValue, 'TItem>>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline label (x: System.String) = "Label" => x
    static member inline value (x: 'TItemValue) = "Value" => x
                    

type simpleSelectOption<'FunBlazorGeneric> =
    inherit selectOption<'FunBlazorGeneric, System.String, System.String>
    static member inline create () = ComponentBuilder<AntDesign.SimpleSelectOption>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SimpleSelectOption>() { html.mergeAttrs attrs }


                    

type skeleton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Skeleton>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Skeleton>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Skeleton>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Skeleton>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Skeleton>(){ x }
    static member inline active (x: System.Boolean) = "Active" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline title (x: System.Boolean) = "Title" => x
    static member inline titleWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "TitleWidth" => x
    static member inline avatar (x: System.Boolean) = "Avatar" => x
    static member inline avatarSize (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "AvatarSize" => x
    static member inline avatarShape (x: System.String) = "AvatarShape" => x
    static member inline paragraph (x: System.Boolean) = "Paragraph" => x
    static member inline paragraphRows (x: System.Nullable<System.Int32>) = "ParagraphRows" => x
    static member inline paragraphWidth (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IList<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = "ParagraphWidth" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type skeletonElement<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.SkeletonElement>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SkeletonElement>() { html.mergeAttrs attrs }

    static member inline active (x: System.Boolean) = "Active" => x
    static member inline type' (x: System.String) = "Type" => x
    static member inline size (x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Size" => x
    static member inline shape (x: System.String) = "Shape" => x
                    

type space<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Space>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Space>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Space>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Space>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Space>(){ x }
    static member inline align (x: System.String) = "Align" => x
    static member inline direction (x: AntDesign.DirectionVHType) = "Direction" => x
    static member inline size (x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Size" => x
    static member inline wrap (x: System.Boolean) = "Wrap" => x
    static member inline split (x: string) = html.renderFragment("Split", html.text x)
    static member inline split (node) = html.renderFragment("Split", node)
    static member inline split (nodes) = html.renderFragment("Split", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type spaceItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.SpaceItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SpaceItem>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.SpaceItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.SpaceItem>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.SpaceItem>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type spin<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Spin>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Spin>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Spin>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Spin>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Spin>(){ x }
    static member inline size (x: System.String) = "Size" => x
    static member inline tip (x: System.String) = "Tip" => x
    static member inline delay (x: System.Int32) = "Delay" => x
    static member inline spinning (x: System.Boolean) = "Spinning" => x
    static member inline wrapperClassName (x: System.String) = "WrapperClassName" => x
    static member inline indicator (x: string) = html.renderFragment("Indicator", html.text x)
    static member inline indicator (node) = html.renderFragment("Indicator", node)
    static member inline indicator (nodes) = html.renderFragment("Indicator", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type statisticComponentBase<'FunBlazorGeneric, 'T> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.StatisticComponentBase<'T>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.StatisticComponentBase<'T>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.StatisticComponentBase<'T>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.StatisticComponentBase<'T>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.StatisticComponentBase<'T>>(){ x }
    static member inline prefix (x: System.String) = "Prefix" => x
    static member inline prefixTemplate (x: string) = html.renderFragment("PrefixTemplate", html.text x)
    static member inline prefixTemplate (node) = html.renderFragment("PrefixTemplate", node)
    static member inline prefixTemplate (nodes) = html.renderFragment("PrefixTemplate", fragment { yield! nodes })
    static member inline suffix (x: System.String) = "Suffix" => x
    static member inline suffixTemplate (x: string) = html.renderFragment("SuffixTemplate", html.text x)
    static member inline suffixTemplate (node) = html.renderFragment("SuffixTemplate", node)
    static member inline suffixTemplate (nodes) = html.renderFragment("SuffixTemplate", fragment { yield! nodes })
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline value (x: 'T) = "Value" => x
    static member inline valueStyle (x: System.String) = "ValueStyle" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type countDown<'FunBlazorGeneric> =
    inherit statisticComponentBase<'FunBlazorGeneric, System.DateTime>
    static member inline create () = ComponentBuilder<AntDesign.CountDown>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CountDown>() { html.mergeAttrs attrs }

    static member inline format (x: System.String) = "Format" => x
    static member inline onFinish fn = html.callback<unit>("OnFinish", fn)
                    

type statistic<'FunBlazorGeneric, 'TValue> =
    inherit statisticComponentBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<AntDesign.Statistic<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Statistic<'TValue>>() { html.mergeAttrs attrs }

    static member inline decimalSeparator (x: System.String) = "DecimalSeparator" => x
    static member inline groupSeparator (x: System.String) = "GroupSeparator" => x
    static member inline precision (x: System.Int32) = "Precision" => x
                    

type step<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Step>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Step>() { html.mergeAttrs attrs }

    static member inline icon (x: System.String) = "Icon" => x
    static member inline status (x: System.String) = "Status" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline subtitle (x: System.String) = "Subtitle" => x
    static member inline subtitleTemplate (x: string) = html.renderFragment("SubtitleTemplate", html.text x)
    static member inline subtitleTemplate (node) = html.renderFragment("SubtitleTemplate", node)
    static member inline subtitleTemplate (nodes) = html.renderFragment("SubtitleTemplate", fragment { yield! nodes })
    static member inline description (x: System.String) = "Description" => x
    static member inline descriptionTemplate (x: string) = html.renderFragment("DescriptionTemplate", html.text x)
    static member inline descriptionTemplate (node) = html.renderFragment("DescriptionTemplate", node)
    static member inline descriptionTemplate (nodes) = html.renderFragment("DescriptionTemplate", fragment { yield! nodes })
    static member inline onClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClick", fn)
    static member inline disabled (x: System.Boolean) = "Disabled" => x
                    

type steps<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Steps>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Steps>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Steps>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Steps>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Steps>(){ x }
    static member inline current (x: System.Int32) = "Current" => x
    static member inline percent (x: System.Nullable<System.Double>) = "Percent" => x
    static member inline progressDot (x: string) = html.renderFragment("ProgressDot", html.text x)
    static member inline progressDot (node) = html.renderFragment("ProgressDot", node)
    static member inline progressDot (nodes) = html.renderFragment("ProgressDot", fragment { yield! nodes })
    static member inline showProgressDot (x: System.Boolean) = "ShowProgressDot" => x
    static member inline direction (x: System.String) = "Direction" => x
    static member inline labelPlacement (x: System.String) = "LabelPlacement" => x
    static member inline type' (x: System.String) = "Type" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline startIndex (x: System.Int32) = "StartIndex" => x
    static member inline status (x: System.String) = "Status" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline onChange fn = html.callback<System.Int32>("OnChange", fn)
                    

type table<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Table<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Table<'TItem>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Table<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Table<'TItem>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Table<'TItem>>(){ x }
    static member inline renderMode (x: AntDesign.RenderMode) = "RenderMode" => x
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member inline childContent (render: 'TItem -> NodeRenderFragment) = html.renderFragment("ChildContent", render)
    static member inline rowTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("RowTemplate", render)
    static member inline expandTemplate (render: AntDesign.TableModels.RowData<'TItem> -> NodeRenderFragment) = html.renderFragment("ExpandTemplate", render)
    static member inline defaultExpandAllRows (x: System.Boolean) = "DefaultExpandAllRows" => x
    static member inline rowExpandable (fn) = "RowExpandable" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>fn)
    static member inline treeChildren (fn) = "TreeChildren" => (System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>fn)
    static member inline onChange fn = html.callback<AntDesign.TableModels.QueryModel<'TItem>>("OnChange", fn)
    static member inline onRow (fn) = "OnRow" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.Dictionary<System.String, System.Object>>fn)
    static member inline onHeaderRow (fn) = "OnHeaderRow" => (System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>fn)
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline footer (x: System.String) = "Footer" => x
    static member inline footerTemplate (x: string) = html.renderFragment("FooterTemplate", html.text x)
    static member inline footerTemplate (node) = html.renderFragment("FooterTemplate", node)
    static member inline footerTemplate (nodes) = html.renderFragment("FooterTemplate", fragment { yield! nodes })
    static member inline size (x: AntDesign.TableSize) = "Size" => x
    static member inline locale (x: AntDesign.TableLocale) = "Locale" => x
    static member inline bordered (x: System.Boolean) = "Bordered" => x
    static member inline scrollX (x: System.String) = "ScrollX" => x
    static member inline scrollY (x: System.String) = "ScrollY" => x
    static member inline scrollBarWidth (x: System.Int32) = "ScrollBarWidth" => x
    static member inline indentSize (x: System.Int32) = "IndentSize" => x
    static member inline expandIconColumnIndex (x: System.Int32) = "ExpandIconColumnIndex" => x
    static member inline rowClassName (fn) = "RowClassName" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>fn)
    static member inline expandedRowClassName (fn) = "ExpandedRowClassName" => (System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>fn)
    static member inline onExpand fn = html.callback<AntDesign.TableModels.RowData<'TItem>>("OnExpand", fn)
    static member inline sortDirections (x: AntDesign.SortDirection[]) = "SortDirections" => x
    static member inline tableLayout (x: System.String) = "TableLayout" => x
    static member inline onRowClick fn = html.callback<AntDesign.TableModels.RowData<'TItem>>("OnRowClick", fn)
    static member inline remoteDataSource (x: System.Boolean) = "RemoteDataSource" => x
    static member inline responsive (x: System.Boolean) = "Responsive" => x
    static member inline hidePagination (x: System.Boolean) = "HidePagination" => x
    static member inline paginationPosition (x: System.String) = "PaginationPosition" => x
    static member inline paginationTemplate (x: string) = html.renderFragment("PaginationTemplate", html.text x)
    static member inline paginationTemplate (node) = html.renderFragment("PaginationTemplate", node)
    static member inline paginationTemplate (nodes) = html.renderFragment("PaginationTemplate", fragment { yield! nodes })
    static member inline total (x: System.Int32) = "Total" => x
    static member inline total' (value: IStore<System.Int32>) = html.bind("Total", value)
    static member inline total' (value: cval<System.Int32>) = html.bind("Total", value)
    static member inline total' (valueFn: System.Int32 * (System.Int32 -> unit)) = html.bind("Total", valueFn)
    static member inline totalChanged fn = html.callback<System.Int32>("TotalChanged", fn)
    static member inline pageIndex (x: System.Int32) = "PageIndex" => x
    static member inline pageIndex' (value: IStore<System.Int32>) = html.bind("PageIndex", value)
    static member inline pageIndex' (value: cval<System.Int32>) = html.bind("PageIndex", value)
    static member inline pageIndex' (valueFn: System.Int32 * (System.Int32 -> unit)) = html.bind("PageIndex", valueFn)
    static member inline pageIndexChanged fn = html.callback<System.Int32>("PageIndexChanged", fn)
    static member inline pageSize (x: System.Int32) = "PageSize" => x
    static member inline pageSize' (value: IStore<System.Int32>) = html.bind("PageSize", value)
    static member inline pageSize' (value: cval<System.Int32>) = html.bind("PageSize", value)
    static member inline pageSize' (valueFn: System.Int32 * (System.Int32 -> unit)) = html.bind("PageSize", valueFn)
    static member inline pageSizeChanged fn = html.callback<System.Int32>("PageSizeChanged", fn)
    static member inline onPageIndexChange fn = html.callback<AntDesign.PaginationEventArgs>("OnPageIndexChange", fn)
    static member inline onPageSizeChange fn = html.callback<AntDesign.PaginationEventArgs>("OnPageSizeChange", fn)
    static member inline selectedRows (x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedRows" => x
    static member inline selectedRows' (value: IStore<System.Collections.Generic.IEnumerable<'TItem>>) = html.bind("SelectedRows", value)
    static member inline selectedRows' (value: cval<System.Collections.Generic.IEnumerable<'TItem>>) = html.bind("SelectedRows", value)
    static member inline selectedRows' (valueFn: System.Collections.Generic.IEnumerable<'TItem> * (System.Collections.Generic.IEnumerable<'TItem> -> unit)) = html.bind("SelectedRows", valueFn)
    static member inline selectedRowsChanged fn = html.callback<System.Collections.Generic.IEnumerable<'TItem>>("SelectedRowsChanged", fn)
                    

type reuseTabs<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ReuseTabs>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ReuseTabs>() { html.mergeAttrs attrs }

    static member inline tabPaneClass (x: System.String) = "TabPaneClass" => x
    static member inline draggable (x: System.Boolean) = "Draggable" => x
    static member inline size (x: AntDesign.TabSize) = "Size" => x
    static member inline body (render: AntDesign.ReuseTabsPageItem -> NodeRenderFragment) = html.renderFragment("Body", render)
    static member inline locale (x: AntDesign.ReuseTabsLocale) = "Locale" => x
                    

type tabPane<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.TabPane>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TabPane>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.TabPane>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.TabPane>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.TabPane>(){ x }
    static member inline forceRender (x: System.Boolean) = "ForceRender" => x
    static member inline key (x: System.String) = "Key" => x
    static member inline tab (x: System.String) = "Tab" => x
    static member inline tabTemplate (x: string) = html.renderFragment("TabTemplate", html.text x)
    static member inline tabTemplate (node) = html.renderFragment("TabTemplate", node)
    static member inline tabTemplate (nodes) = html.renderFragment("TabTemplate", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline tabContextMenu (x: string) = html.renderFragment("TabContextMenu", html.text x)
    static member inline tabContextMenu (node) = html.renderFragment("TabContextMenu", node)
    static member inline tabContextMenu (nodes) = html.renderFragment("TabContextMenu", fragment { yield! nodes })
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline closable (x: System.Boolean) = "Closable" => x
                    

type tabs<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Tabs>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Tabs>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Tabs>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Tabs>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Tabs>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline activeKey (x: System.String) = "ActiveKey" => x
    static member inline activeKey' (value: IStore<System.String>) = html.bind("ActiveKey", value)
    static member inline activeKey' (value: cval<System.String>) = html.bind("ActiveKey", value)
    static member inline activeKey' (valueFn: System.String * (System.String -> unit)) = html.bind("ActiveKey", valueFn)
    static member inline activeKeyChanged fn = html.callback<System.String>("ActiveKeyChanged", fn)
    static member inline animated (x: System.Boolean) = "Animated" => x
    static member inline inkBarAnimated (x: System.Boolean) = "InkBarAnimated" => x
    static member inline renderTabBar (x: System.Object) = "RenderTabBar" => x
    static member inline defaultActiveKey (x: System.String) = "DefaultActiveKey" => x
    static member inline hideAdd (x: System.Boolean) = "HideAdd" => x
    static member inline size (x: AntDesign.TabSize) = "Size" => x
    static member inline tabBarExtraContent (x: string) = html.renderFragment("TabBarExtraContent", html.text x)
    static member inline tabBarExtraContent (node) = html.renderFragment("TabBarExtraContent", node)
    static member inline tabBarExtraContent (nodes) = html.renderFragment("TabBarExtraContent", fragment { yield! nodes })
    static member inline tabBarExtraContentLeft (x: string) = html.renderFragment("TabBarExtraContentLeft", html.text x)
    static member inline tabBarExtraContentLeft (node) = html.renderFragment("TabBarExtraContentLeft", node)
    static member inline tabBarExtraContentLeft (nodes) = html.renderFragment("TabBarExtraContentLeft", fragment { yield! nodes })
    static member inline tabBarExtraContentRight (x: string) = html.renderFragment("TabBarExtraContentRight", html.text x)
    static member inline tabBarExtraContentRight (node) = html.renderFragment("TabBarExtraContentRight", node)
    static member inline tabBarExtraContentRight (nodes) = html.renderFragment("TabBarExtraContentRight", fragment { yield! nodes })
    static member inline tabBarGutter (x: System.Int32) = "TabBarGutter" => x
    static member inline tabBarStyle (x: System.String) = "TabBarStyle" => x
    static member inline tabPosition (x: AntDesign.TabPosition) = "TabPosition" => x
    static member inline type' (x: AntDesign.TabType) = "Type" => x
    static member inline onChange fn = html.callback<System.String>("OnChange", fn)
    static member inline onEdit (fn) = "OnEdit" => (System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>fn)
    static member inline onClose fn = html.callback<System.String>("OnClose", fn)
    static member inline onAddClick fn = html.callback<unit>("OnAddClick", fn)
    static member inline afterTabCreated fn = html.callback<System.String>("AfterTabCreated", fn)
    static member inline onTabClick fn = html.callback<System.String>("OnTabClick", fn)
    static member inline draggable (x: System.Boolean) = "Draggable" => x
    static member inline centered (x: System.Boolean) = "Centered" => x
                    

type tag<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Tag>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Tag>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Tag>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Tag>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Tag>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline closable (x: System.Boolean) = "Closable" => x
    static member inline checkable (x: System.Boolean) = "Checkable" => x
    static member inline checked' (x: System.Boolean) = "Checked" => x
    static member inline checked'' (value: IStore<System.Boolean>) = html.bind("Checked", value)
    static member inline checked'' (value: cval<System.Boolean>) = html.bind("Checked", value)
    static member inline checked'' (valueFn: System.Boolean * (System.Boolean -> unit)) = html.bind("Checked", valueFn)
    static member inline checkedChanged fn = html.callback<System.Boolean>("CheckedChanged", fn)
    static member inline color (x: System.String) = "Color" => x
    static member inline presetColor (x: System.Nullable<AntDesign.PresetColor>) = "PresetColor" => x
    static member inline icon (x: System.String) = "Icon" => x
    static member inline noAnimation (x: System.Boolean) = "NoAnimation" => x
    static member inline onClose fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClose", fn)
    static member inline onClosing fn = html.callback<AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>("OnClosing", fn)
    static member inline onClick fn = html.callback<unit>("OnClick", fn)
    static member inline visible (x: System.Boolean) = "Visible" => x
                    

type timeline<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Timeline>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Timeline>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Timeline>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Timeline>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Timeline>(){ x }
    static member inline mode (x: System.Nullable<AntDesign.TimelineMode>) = "Mode" => x
    static member inline reverse (x: System.Boolean) = "Reverse" => x
    static member inline pending (x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Pending" => x
    static member inline pendingDot (x: string) = html.renderFragment("PendingDot", html.text x)
    static member inline pendingDot (node) = html.renderFragment("PendingDot", node)
    static member inline pendingDot (nodes) = html.renderFragment("PendingDot", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type timelineItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.TimelineItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TimelineItem>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.TimelineItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.TimelineItem>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.TimelineItem>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline dot (x: string) = html.renderFragment("Dot", html.text x)
    static member inline dot (node) = html.renderFragment("Dot", node)
    static member inline dot (nodes) = html.renderFragment("Dot", fragment { yield! nodes })
    static member inline color (x: System.String) = "Color" => x
    static member inline label (x: System.String) = "Label" => x
                    

type transfer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Transfer>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Transfer>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Transfer>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Transfer>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Transfer>(){ x }
    static member inline dataSource (x: System.Collections.Generic.IList<AntDesign.TransferItem>) = "DataSource" => x
    static member inline titles (x: System.String[]) = "Titles" => x
    static member inline operations (x: System.String[]) = "Operations" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline showSearch (x: System.Boolean) = "ShowSearch" => x
    static member inline showSelectAll (x: System.Boolean) = "ShowSelectAll" => x
    static member inline targetKeys (x: System.String[]) = "TargetKeys" => x
    static member inline selectedKeys (x: System.String[]) = "SelectedKeys" => x
    static member inline onChange fn = html.callback<AntDesign.TransferChangeArgs>("OnChange", fn)
    static member inline onScroll fn = html.callback<AntDesign.TransferScrollArgs>("OnScroll", fn)
    static member inline onSearch fn = html.callback<AntDesign.TransferSearchArgs>("OnSearch", fn)
    static member inline onSelectChange fn = html.callback<AntDesign.TransferSelectChangeArgs>("OnSelectChange", fn)
    static member inline render (fn) = "Render" => (System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>fn)
    static member inline locale (x: AntDesign.TransferLocale) = "Locale" => x
    static member inline footer (x: System.String) = "Footer" => x
    static member inline footerTemplate (x: string) = html.renderFragment("FooterTemplate", html.text x)
    static member inline footerTemplate (node) = html.renderFragment("FooterTemplate", node)
    static member inline footerTemplate (nodes) = html.renderFragment("FooterTemplate", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type tree<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Tree<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Tree<'TItem>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Tree<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Tree<'TItem>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Tree<'TItem>>(){ x }
    static member inline showExpand (x: System.Boolean) = "ShowExpand" => x
    static member inline showLine (x: System.Boolean) = "ShowLine" => x
    static member inline showIcon (x: System.Boolean) = "ShowIcon" => x
    static member inline blockNode (x: System.Boolean) = "BlockNode" => x
    static member inline draggable (x: System.Boolean) = "Draggable" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline showLeafIcon (x: System.Boolean) = "ShowLeafIcon" => x
    static member inline switcherIcon (x: System.String) = "SwitcherIcon" => x
    static member inline nodes (x: string) = html.renderFragment("Nodes", html.text x)
    static member inline nodes (node) = html.renderFragment("Nodes", node)
    static member inline nodes (nodes) = html.renderFragment("Nodes", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline selectable (x: System.Boolean) = "Selectable" => x
    static member inline multiple (x: System.Boolean) = "Multiple" => x
    static member inline defaultSelectedKeys (x: System.String[]) = "DefaultSelectedKeys" => x
    static member inline selectedKey (x: System.String) = "SelectedKey" => x
    static member inline selectedKey' (value: IStore<System.String>) = html.bind("SelectedKey", value)
    static member inline selectedKey' (value: cval<System.String>) = html.bind("SelectedKey", value)
    static member inline selectedKey' (valueFn: System.String * (System.String -> unit)) = html.bind("SelectedKey", valueFn)
    static member inline selectedKeyChanged fn = html.callback<System.String>("SelectedKeyChanged", fn)
    static member inline selectedNode (x: AntDesign.TreeNode<'TItem>) = "SelectedNode" => x
    static member inline selectedNode' (value: IStore<AntDesign.TreeNode<'TItem>>) = html.bind("SelectedNode", value)
    static member inline selectedNode' (value: cval<AntDesign.TreeNode<'TItem>>) = html.bind("SelectedNode", value)
    static member inline selectedNode' (valueFn: AntDesign.TreeNode<'TItem> * (AntDesign.TreeNode<'TItem> -> unit)) = html.bind("SelectedNode", valueFn)
    static member inline selectedNodeChanged fn = html.callback<AntDesign.TreeNode<'TItem>>("SelectedNodeChanged", fn)
    static member inline selectedData (x: 'TItem) = "SelectedData" => x
    static member inline selectedData' (value: IStore<'TItem>) = html.bind("SelectedData", value)
    static member inline selectedData' (value: cval<'TItem>) = html.bind("SelectedData", value)
    static member inline selectedData' (valueFn: 'TItem * ('TItem -> unit)) = html.bind("SelectedData", valueFn)
    static member inline selectedDataChanged fn = html.callback<'TItem>("SelectedDataChanged", fn)
    static member inline selectedKeys (x: System.String[]) = "SelectedKeys" => x
    static member inline selectedKeys' (value: IStore<System.String[]>) = html.bind("SelectedKeys", value)
    static member inline selectedKeys' (value: cval<System.String[]>) = html.bind("SelectedKeys", value)
    static member inline selectedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("SelectedKeys", valueFn)
    static member inline selectedKeysChanged fn = html.callback<System.String[]>("SelectedKeysChanged", fn)
    static member inline selectedNodes (x: AntDesign.TreeNode<'TItem>[]) = "SelectedNodes" => x
    static member inline selectedDatas (x: 'TItem[]) = "SelectedDatas" => x
    static member inline checkable (x: System.Boolean) = "Checkable" => x
    static member inline checkStrictly (x: System.Boolean) = "CheckStrictly" => x
    static member inline checkedKeys (x: System.String[]) = "CheckedKeys" => x
    static member inline checkedKeys' (value: IStore<System.String[]>) = html.bind("CheckedKeys", value)
    static member inline checkedKeys' (value: cval<System.String[]>) = html.bind("CheckedKeys", value)
    static member inline checkedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("CheckedKeys", valueFn)
    static member inline checkedKeysChanged fn = html.callback<System.String[]>("CheckedKeysChanged", fn)
    static member inline defaultCheckedKeys (x: System.String[]) = "DefaultCheckedKeys" => x
    static member inline searchValue (x: System.String) = "SearchValue" => x
    static member inline searchExpression (fn) = "SearchExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn)
    static member inline matchedStyle (x: System.String) = "MatchedStyle" => x
    static member inline matchedClass (x: System.String) = "MatchedClass" => x
    static member inline dataSource (x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x
    static member inline titleExpression (fn) = "TitleExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn)
    static member inline keyExpression (fn) = "KeyExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn)
    static member inline iconExpression (fn) = "IconExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.String>fn)
    static member inline isLeafExpression (fn) = "IsLeafExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn)
    static member inline childrenExpression (fn) = "ChildrenExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IList<'TItem>>fn)
    static member inline disabledExpression (fn) = "DisabledExpression" => (System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>fn)
    static member inline onNodeLoadDelayAsync fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnNodeLoadDelayAsync", fn)
    static member inline onClick fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnClick", fn)
    static member inline onDblClick fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDblClick", fn)
    static member inline onContextMenu fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnContextMenu", fn)
    static member inline onCheck fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnCheck", fn)
    static member inline onSelect fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnSelect", fn)
    static member inline onUnSelect fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnUnSelect", fn)
    static member inline onExpandChanged fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnExpandChanged", fn)
    static member inline indentTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("IndentTemplate", render)
    static member inline titleTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("TitleTemplate", render)
    static member inline titleIconTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("TitleIconTemplate", render)
    static member inline switcherIconTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("SwitcherIconTemplate", render)
    static member inline onDragStart fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDragStart", fn)
    static member inline onDragEnter fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDragEnter", fn)
    static member inline onDragLeave fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDragLeave", fn)
    static member inline onDrop fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDrop", fn)
    static member inline onDragEnd fn = html.callback<AntDesign.TreeEventArgs<'TItem>>("OnDragEnd", fn)
    static member inline defaultExpandAll (x: System.Boolean) = "DefaultExpandAll" => x
    static member inline defaultExpandParent (x: System.Boolean) = "DefaultExpandParent" => x
    static member inline defaultExpandedKeys (x: System.String[]) = "DefaultExpandedKeys" => x
    static member inline expandedKeys (x: System.String[]) = "ExpandedKeys" => x
    static member inline expandedKeys' (value: IStore<System.String[]>) = html.bind("ExpandedKeys", value)
    static member inline expandedKeys' (value: cval<System.String[]>) = html.bind("ExpandedKeys", value)
    static member inline expandedKeys' (valueFn: System.String[] * (System.String[] -> unit)) = html.bind("ExpandedKeys", valueFn)
    static member inline expandedKeysChanged fn = html.callback<System.String[]>("ExpandedKeysChanged", fn)
    static member inline onExpand fn = html.callback<System.ValueTuple<System.String[], AntDesign.TreeNode<'TItem>, System.Boolean>>("OnExpand", fn)
    static member inline autoExpandParent (x: System.Boolean) = "AutoExpandParent" => x
                    

type directoryTree<'FunBlazorGeneric, 'TItem> =
    inherit tree<'FunBlazorGeneric, 'TItem>
    static member inline create () = ComponentBuilder<AntDesign.DirectoryTree<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.DirectoryTree<'TItem>>() { html.mergeAttrs attrs }


                    

type treeNode<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.TreeNode<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeNode<'TItem>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.TreeNode<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.TreeNode<'TItem>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.TreeNode<'TItem>>(){ x }
    static member inline nodes (x: string) = html.renderFragment("Nodes", html.text x)
    static member inline nodes (node) = html.renderFragment("Nodes", node)
    static member inline nodes (nodes) = html.renderFragment("Nodes", fragment { yield! nodes })
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline key (x: System.String) = "Key" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline selected (x: System.Boolean) = "Selected" => x
    static member inline loading (x: System.Boolean) = "Loading" => x
    static member inline isLeaf (x: System.Boolean) = "IsLeaf" => x
    static member inline expanded (x: System.Boolean) = "Expanded" => x
    static member inline checked' (x: System.Boolean) = "Checked" => x
    static member inline indeterminate (x: System.Boolean) = "Indeterminate" => x
    static member inline disableCheckbox (x: System.Boolean) = "DisableCheckbox" => x
    static member inline draggable (x: System.Boolean) = "Draggable" => x
    static member inline icon (x: System.String) = "Icon" => x
    static member inline iconTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("IconTemplate", render)
    static member inline switcherIcon (x: System.String) = "SwitcherIcon" => x
    static member inline switcherIconTemplate (render: AntDesign.TreeNode<'TItem> -> NodeRenderFragment) = html.renderFragment("SwitcherIconTemplate", render)
    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline dataItem (x: 'TItem) = "DataItem" => x
                    

type upload<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Upload>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Upload>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Upload>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Upload>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Upload>(){ x }
    static member inline beforeUpload (fn) = "BeforeUpload" => (System.Func<AntDesign.UploadFileItem, System.Boolean>fn)
    static member inline beforeAllUploadAsync (fn) = "BeforeAllUploadAsync" => (System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>fn)
    static member inline beforeAllUpload (fn) = "BeforeAllUpload" => (System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Boolean>fn)
    static member inline name (x: System.String) = "Name" => x
    static member inline action (x: System.String) = "Action" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline data (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x
    static member inline listType (x: System.String) = "ListType" => x
    static member inline directory (x: System.Boolean) = "Directory" => x
    static member inline multiple (x: System.Boolean) = "Multiple" => x
    static member inline accept (x: System.String) = "Accept" => x
    static member inline showUploadList (x: System.Boolean) = "ShowUploadList" => x
    static member inline fileList (x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "FileList" => x
    static member inline fileList' (value: IStore<System.Collections.Generic.List<AntDesign.UploadFileItem>>) = html.bind("FileList", value)
    static member inline fileList' (value: cval<System.Collections.Generic.List<AntDesign.UploadFileItem>>) = html.bind("FileList", value)
    static member inline fileList' (valueFn: System.Collections.Generic.List<AntDesign.UploadFileItem> * (System.Collections.Generic.List<AntDesign.UploadFileItem> -> unit)) = html.bind("FileList", valueFn)
    static member inline locale (x: AntDesign.UploadLocale) = "Locale" => x
    static member inline fileListChanged fn = html.callback<System.Collections.Generic.List<AntDesign.UploadFileItem>>("FileListChanged", fn)
    static member inline defaultFileList (x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "DefaultFileList" => x
    static member inline headers (x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x
    static member inline onSingleCompleted fn = html.callback<AntDesign.UploadInfo>("OnSingleCompleted", fn)
    static member inline onCompleted fn = html.callback<AntDesign.UploadInfo>("OnCompleted", fn)
    static member inline onChange fn = html.callback<AntDesign.UploadInfo>("OnChange", fn)
    static member inline onRemove (fn) = "OnRemove" => (System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>fn)
    static member inline onPreview fn = html.callback<AntDesign.UploadFileItem>("OnPreview", fn)
    static member inline onDownload fn = html.callback<AntDesign.UploadFileItem>("OnDownload", fn)
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline showButton (x: System.Boolean) = "ShowButton" => x
    static member inline drag (x: System.Boolean) = "Drag" => x
    static member inline method (x: System.String) = "Method" => x
                    

type breadcrumbItem<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.BreadcrumbItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.BreadcrumbItem>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.BreadcrumbItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.BreadcrumbItem>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.BreadcrumbItem>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline overlay (x: string) = html.renderFragment("Overlay", html.text x)
    static member inline overlay (node) = html.renderFragment("Overlay", node)
    static member inline overlay (nodes) = html.renderFragment("Overlay", fragment { yield! nodes })
    static member inline href (x: System.String) = "Href" => x
                    

type calendarHeader<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.CalendarHeader>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CalendarHeader>() { html.mergeAttrs attrs }


                    

type cardMeta<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.CardMeta>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CardMeta>() { html.mergeAttrs attrs }

    static member inline title (x: System.String) = "Title" => x
    static member inline titleTemplate (x: string) = html.renderFragment("TitleTemplate", html.text x)
    static member inline titleTemplate (node) = html.renderFragment("TitleTemplate", node)
    static member inline titleTemplate (nodes) = html.renderFragment("TitleTemplate", fragment { yield! nodes })
    static member inline description (x: System.String) = "Description" => x
    static member inline descriptionTemplate (x: string) = html.renderFragment("DescriptionTemplate", html.text x)
    static member inline descriptionTemplate (node) = html.renderFragment("DescriptionTemplate", node)
    static member inline descriptionTemplate (nodes) = html.renderFragment("DescriptionTemplate", fragment { yield! nodes })
    static member inline avatar (x: System.String) = "Avatar" => x
    static member inline avatarTemplate (x: string) = html.renderFragment("AvatarTemplate", html.text x)
    static member inline avatarTemplate (node) = html.renderFragment("AvatarTemplate", node)
    static member inline avatarTemplate (nodes) = html.renderFragment("AvatarTemplate", fragment { yield! nodes })
                    

type antContainer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.AntContainer>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.AntContainer>() { html.mergeAttrs attrs }


                    

type template<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Template>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Template>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Template>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Template>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Template>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline if' (fn) = "If" => (System.Func<System.Boolean>fn)
                    

type emptyDefaultImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.EmptyDefaultImg>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.EmptyDefaultImg>() { html.mergeAttrs attrs }

    static member inline prefixCls (x: System.String) = "PrefixCls" => x
                    

type emptySimpleImg<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.EmptySimpleImg>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.EmptySimpleImg>() { html.mergeAttrs attrs }

    static member inline prefixCls (x: System.String) = "PrefixCls" => x
                    

type content<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Content>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Content>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Content>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Content>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Content>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type footer<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Footer>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Footer>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Footer>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Footer>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Footer>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type header<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Header>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Header>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Header>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Header>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Header>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type layout<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Layout>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Layout>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Layout>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Layout>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Layout>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type menuDivider<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.MenuDivider>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.MenuDivider>() { html.mergeAttrs attrs }


                    

type paginationPager<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.PaginationPager>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.PaginationPager>() { html.mergeAttrs attrs }

    static member inline showTitle (x: System.Boolean) = "ShowTitle" => x
    static member inline page (x: System.Int32) = "Page" => x
    static member inline rootPrefixCls (x: System.String) = "RootPrefixCls" => x
    static member inline active (x: System.Boolean) = "Active" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline onClick fn = html.callback<System.Int32>("OnClick", fn)
    static member inline onKeyPress fn = html.callback<System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action>>("OnKeyPress", fn)
    static member inline itemRender (render: AntDesign.PaginationItemRenderContext -> NodeRenderFragment) = html.renderFragment("ItemRender", render)
    static member inline unmatchedAttributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x
                    
            
namespace rec AntDesign.DslInternals.Select.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type selectOptionGroup<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>() { html.mergeAttrs attrs }


                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type calendarPanelChooser<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.CalendarPanelChooser>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.CalendarPanelChooser>() { html.mergeAttrs attrs }

    static member inline calendar (x: AntDesign.Calendar) = "Calendar" => x
    static member inline onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn)
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x
                    

type element<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.Element>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.Element>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Internal.Element>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Internal.Element>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Internal.Element>(){ x }
    static member inline htmlTag (x: System.String) = "HtmlTag" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline refChanged fn = html.callback<Microsoft.AspNetCore.Components.ElementReference>("RefChanged", fn)
    static member inline attributes (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x
                    

type overlay<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.Overlay>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.Overlay>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Internal.Overlay>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Internal.Overlay>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Internal.Overlay>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline onOverlayMouseEnter fn = html.callback<unit>("OnOverlayMouseEnter", fn)
    static member inline onOverlayMouseLeave fn = html.callback<unit>("OnOverlayMouseLeave", fn)
    static member inline onOverlayMouseUp fn = html.callback<unit>("OnOverlayMouseUp", fn)
    static member inline onShow fn = html.callback<unit>("OnShow", fn)
    static member inline onHide fn = html.callback<unit>("OnHide", fn)
    static member inline overlayChildPrefixCls (x: System.String) = "OverlayChildPrefixCls" => x
    static member inline hideMillisecondsDelay (x: System.Int32) = "HideMillisecondsDelay" => x
    static member inline waitForHideAnimMilliseconds (x: System.Int32) = "WaitForHideAnimMilliseconds" => x
    static member inline verticalOffset (x: System.Int32) = "VerticalOffset" => x
    static member inline horizontalOffset (x: System.Int32) = "HorizontalOffset" => x
    static member inline hiddenMode (x: System.Boolean) = "HiddenMode" => x
                    

type datePickerPanelChooser<'FunBlazorGeneric, 'TValue> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerPanelChooser<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerPanelChooser<'TValue>>() { html.mergeAttrs attrs }

    static member inline datePicker (x: AntDesign.DatePickerBase<'TValue>) = "DatePicker" => x
    static member inline onSelect (fn) = "OnSelect" => (System.Action<System.DateTime, System.Int32>fn)
    static member inline pickerIndex (x: System.Int32) = "PickerIndex" => x
                    

type uploadButton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.UploadButton>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.UploadButton>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Internal.UploadButton>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Internal.UploadButton>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Internal.UploadButton>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline listType (x: System.String) = "ListType" => x
    static member inline showButton (x: System.Boolean) = "ShowButton" => x
    static member inline name (x: System.String) = "Name" => x
    static member inline directory (x: System.Boolean) = "Directory" => x
    static member inline multiple (x: System.Boolean) = "Multiple" => x
    static member inline accept (x: System.String) = "Accept" => x
    static member inline data (x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x
    static member inline headers (x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x
    static member inline action (x: System.String) = "Action" => x
    static member inline method (x: System.String) = "Method" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
                    

type datePickerInput<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DatePickerInput>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DatePickerInput>() { html.mergeAttrs attrs }

    static member inline prefixCls (x: System.String) = "PrefixCls" => x
    static member inline size (x: System.String) = "Size" => x
    static member inline value (x: System.String) = "Value" => x
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline readOnly (x: System.Boolean) = "ReadOnly" => x
    static member inline isRange (x: System.Boolean) = "IsRange" => x
    static member inline disabled (x: System.Boolean) = "Disabled" => x
    static member inline autoFocus (x: System.Boolean) = "AutoFocus" => x
    static member inline showSuffixIcon (x: System.Boolean) = "ShowSuffixIcon" => x
    static member inline showTime (x: System.Boolean) = "ShowTime" => x
    static member inline htmlInputSize (x: System.Int32) = "HtmlInputSize" => x
    static member inline suffixIcon (x: string) = html.renderFragment("SuffixIcon", html.text x)
    static member inline suffixIcon (node) = html.renderFragment("SuffixIcon", node)
    static member inline suffixIcon (nodes) = html.renderFragment("SuffixIcon", fragment { yield! nodes })
    static member inline onClick fn = html.callback<unit>("OnClick", fn)
    static member inline onfocus fn = html.callback<unit>("Onfocus", fn)
    static member inline onBlur fn = html.callback<unit>("OnBlur", fn)
    static member inline onfocusout fn = html.callback<unit>("Onfocusout", fn)
    static member inline onKeyUp fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyUp", fn)
    static member inline onKeyDown fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyDown", fn)
    static member inline onInput fn = html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInput", fn)
    static member inline allowClear (x: System.Boolean) = "AllowClear" => x
    static member inline onClickClear fn = html.callback<unit>("OnClickClear", fn)
                    

type dropdownGroupButton<'FunBlazorGeneric> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.DropdownGroupButton>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.DropdownGroupButton>() { html.mergeAttrs attrs }

    static member inline leftButton (x: string) = html.renderFragment("LeftButton", html.text x)
    static member inline leftButton (node) = html.renderFragment("LeftButton", node)
    static member inline leftButton (nodes) = html.renderFragment("LeftButton", fragment { yield! nodes })
    static member inline rightButton (x: string) = html.renderFragment("RightButton", html.text x)
    static member inline rightButton (node) = html.renderFragment("RightButton", node)
    static member inline rightButton (nodes) = html.renderFragment("RightButton", fragment { yield! nodes })
                    

type tableRow<'FunBlazorGeneric, 'TItem> =
    inherit antDomComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.Internal.TableRow<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.TableRow<'TItem>>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.Internal.TableRow<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.Internal.TableRow<'TItem>>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.Internal.TableRow<'TItem>>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    
            
namespace rec AntDesign.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type configProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.ConfigProvider>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ConfigProvider>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.ConfigProvider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.ConfigProvider>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.ConfigProvider>(){ x }
    static member inline direction (x: System.String) = "Direction" => x
    static member inline form (x: AntDesign.FormConfig) = "Form" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type templateComponentBase<'FunBlazorGeneric, 'TComponentOptions> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.TemplateComponentBase<'TComponentOptions>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TemplateComponentBase<'TComponentOptions>>() { html.mergeAttrs attrs }

    static member inline options (x: 'TComponentOptions) = "Options" => x
                    

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions> =
    inherit templateComponentBase<'FunBlazorGeneric, 'TComponentOptions>
    static member inline create () = ComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions>>() { html.mergeAttrs attrs }

    static member inline feedbackRef (x: AntDesign.IFeedbackRef) = "FeedbackRef" => x
                    

type feedbackComponent<'FunBlazorGeneric, 'TComponentOptions, 'TResult> =
    inherit feedbackComponent<'FunBlazorGeneric, 'TComponentOptions>
    static member inline create () = ComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>() { html.mergeAttrs attrs }


                    

type formProvider<'FunBlazorGeneric> =
    inherit antComponentBase<'FunBlazorGeneric>
    static member inline create () = ComponentBuilder<AntDesign.FormProvider>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.FormProvider>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.FormProvider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.FormProvider>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.FormProvider>(){ x }
    static member inline onFormFinish fn = html.callback<AntDesign.FormProviderFinishEventArgs>("OnFormFinish", fn)
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type component'<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<AntDesign.Component>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Component>() { html.mergeAttrs attrs }

    static member inline type' (x: System.Type) = "Type" => x
    static member inline typeName (x: System.String) = "TypeName" => x
    static member inline parameters (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "Parameters" => x
                    

type imagePreview<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<AntDesign.ImagePreview>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ImagePreview>() { html.mergeAttrs attrs }

    static member inline imageRef (x: AntDesign.ImageRef) = "ImageRef" => x
                    

type imagePreviewGroup<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<AntDesign.ImagePreviewGroup>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.ImagePreviewGroup>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.ImagePreviewGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.ImagePreviewGroup>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.ImagePreviewGroup>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline previewVisible (x: System.Boolean) = "PreviewVisible" => x
    static member inline previewVisible' (value: IStore<System.Boolean>) = html.bind("PreviewVisible", value)
    static member inline previewVisible' (value: cval<System.Boolean>) = html.bind("PreviewVisible", value)
    static member inline previewVisible' (valueFn: System.Boolean * (System.Boolean -> unit)) = html.bind("PreviewVisible", valueFn)
    static member inline previewVisibleChanged fn = html.callback<System.Boolean>("PreviewVisibleChanged", fn)
                    

type treeIndent<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = ComponentBuilder<AntDesign.TreeIndent<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeIndent<'TItem>>() { html.mergeAttrs attrs }

    static member inline treeLevel (x: System.Int32) = "TreeLevel" => x
                    

type treeNodeCheckbox<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = ComponentBuilder<AntDesign.TreeNodeCheckbox<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeNodeCheckbox<'TItem>>() { html.mergeAttrs attrs }

    static member inline onCheckBoxClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnCheckBoxClick", fn)
                    

type treeNodeSwitcher<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = ComponentBuilder<AntDesign.TreeNodeSwitcher<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeNodeSwitcher<'TItem>>() { html.mergeAttrs attrs }

    static member inline onSwitcherClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnSwitcherClick", fn)
                    

type treeNodeTitle<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = ComponentBuilder<AntDesign.TreeNodeTitle<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.TreeNodeTitle<'TItem>>() { html.mergeAttrs attrs }


                    

type cardLoading<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<AntDesign.CardLoading>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.CardLoading>() { html.mergeAttrs attrs }


                    

type summaryRow<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<AntDesign.SummaryRow>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.SummaryRow>() { html.mergeAttrs attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentBuilder<AntDesign.SummaryRow>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentBuilder<AntDesign.SummaryRow>() { node }
    static member inline create (x: string) = ComponentBuilder<AntDesign.SummaryRow>(){ x }
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    
            
namespace rec AntDesign.DslInternals.statistic

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type statisticComponentBase<'FunBlazorGeneric, 'T> =
    
    static member inline create () = ComponentBuilder<AntDesign.statistic.StatisticComponentBase<'T>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.statistic.StatisticComponentBase<'T>>() { html.mergeAttrs attrs }


                    
            
namespace rec AntDesign.DslInternals.Select

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type labelTemplateItem<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member inline create () = ComponentBuilder<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>() { html.mergeAttrs attrs }

    static member inline labelTemplateItemContent (render: 'TItem -> NodeRenderFragment) = html.renderFragment("LabelTemplateItemContent", render)
    static member inline styles (x: (string * string) seq) = html.styles x
    static member inline classes (x: string list) = html.classes x
    static member inline contentStyle (x: System.String) = "ContentStyle" => x
    static member inline contentClass (x: System.String) = "ContentClass" => x
    static member inline removeIconStyle (x: System.String) = "RemoveIconStyle" => x
    static member inline removeIconClass (x: System.String) = "RemoveIconClass" => x
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x
                    
            
namespace rec AntDesign.DslInternals.Select.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type selectContent<'FunBlazorGeneric, 'TItemValue, 'TItem> =
    
    static member inline create () = ComponentBuilder<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>() { html.mergeAttrs attrs }

    static member inline prefix (x: System.String) = "Prefix" => x
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline isOverlayShow (x: System.Boolean) = "IsOverlayShow" => x
    static member inline showPlaceholder (x: System.Boolean) = "ShowPlaceholder" => x
    static member inline maxTagCount (x: System.Int32) = "MaxTagCount" => x
    static member inline onInput fn = html.callback<Microsoft.AspNetCore.Components.ChangeEventArgs>("OnInput", fn)
    static member inline onKeyUp fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyUp", fn)
    static member inline onKeyDown fn = html.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>("OnKeyDown", fn)
    static member inline onFocus fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnFocus", fn)
    static member inline onBlur fn = html.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs>("OnBlur", fn)
    static member inline onClearClick fn = html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnClearClick", fn)
    static member inline onRemoveSelected fn = html.callback<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>>("OnRemoveSelected", fn)
    static member inline searchValue (x: System.String) = "SearchValue" => x
    static member inline refBack (x: AntDesign.ForwardRef) = "RefBack" => x
                    
            
namespace rec AntDesign.DslInternals.Internal

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.DslInternals


type formRulesValidator<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<AntDesign.Internal.FormRulesValidator>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<AntDesign.Internal.FormRulesValidator>() { html.mergeAttrs attrs }


                    
            

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
                    
            