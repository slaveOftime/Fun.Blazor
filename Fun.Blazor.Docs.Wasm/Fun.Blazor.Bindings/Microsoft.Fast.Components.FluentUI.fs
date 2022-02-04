namespace rec Microsoft.Fast.Components.FluentUI.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.Fast.Components.FluentUI.DslInternals


type fluentAccordion<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member expandMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.ExpandMode>) = "ExpandMode" => x
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentAccordionItem<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentAnchor<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>(){ x }
    static member href (x: System.String) = "Href" => x
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentAnchoredRegion<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>(){ x }
    static member anchor (x: System.String) = "Anchor" => x
    static member viewport (x: System.String) = "Viewport" => x
    static member horizontalPositioningMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Positioning>) = "HorizontalPositioningMode" => x
    static member horizontalDefaultPosition (x: System.Nullable<Microsoft.Fast.Components.FluentUI.HorizontalPosition>) = "HorizontalDefaultPosition" => x
    static member horizontalInset (x: System.Boolean) = "HorizontalInset" => x
    static member horizontalThreshold (x: System.Int32) = "HorizontalThreshold" => x
    static member horizontalScaling (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Scaling>) = "HorizontalScaling" => x
    static member verticalPositioningMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Positioning>) = "VerticalPositioningMode" => x
    static member verticalDefaultPosition (x: System.Nullable<Microsoft.Fast.Components.FluentUI.VerticalPosition>) = "VerticalDefaultPosition" => x
    static member verticalInset (x: System.Boolean) = "VerticalInset" => x
    static member verticalThreshold (x: System.Int32) = "VerticalThreshold" => x
    static member verticalScaling (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Scaling>) = "VerticalScaling" => x
    static member autoUpdateMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.UpdateMode>) = "AutoUpdateMode" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentBadge<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>(){ x }
    static member color (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = "Color" => x
    static member fill (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Fill>) = "Fill" => x
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentBreadcrumb<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentBreadcrumbItem<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>(){ x }
    static member href (x: System.String) = "Href" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentButton<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>(){ x }
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentCard<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDataGrid<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>(){ x }
    static member generateHeader (x: System.Nullable<Microsoft.Fast.Components.FluentUI.GenerateHeaderOptions>) = "GenerateHeader" => x
    static member gridTemplateColumns (x: System.String) = "GridTemplateColumns" => x
    static member rowsData (x: System.Collections.Generic.List<'TItem>) = "RowsData" => x
    static member columnDefinitions (x: System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem>>) = "ColumnDefinitions" => x
    static member headerCellTemplate (render: Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem> -> NodeRenderFragment) = html.renderFragment("HeaderCellTemplate", render)
    static member rowItemTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("RowItemTemplate", render)
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDataGridCell<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>(){ x }
    static member cellType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.DataGridCellType>) = "CellType" => x
    static member gridColumn (x: System.Int32) = "GridColumn" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDataGridRow<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>(){ x }
    static member rowIndex (x: System.Nullable<System.Int32>) = "RowIndex" => x
    static member gridTemplateColumns (x: System.String) = "GridTemplateColumns" => x
    static member rowType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.DataGridRowType>) = "RowType" => x
    static member rowData (x: 'TItem) = "RowData" => x
    static member columnDefinitions (x: System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem>>) = "ColumnDefinitions" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDesignSystemProvider<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>(){ x }
    static member noPaint (x: System.Nullable<System.Boolean>) = "NoPaint" => x
    static member fillColor (x: System.String) = "FillColor" => x
    static member accentBaseColor (x: System.String) = "AccentBaseColor" => x
    static member neutralBaseColor (x: System.String) = "NeutralBaseColor" => x
    static member density (x: System.Nullable<System.Int32>) = "Density" => x
    static member designUnit (x: System.Nullable<System.Int32>) = "DesignUnit" => x
    static member direction (x: System.Nullable<Microsoft.Fast.Components.FluentUI.LocalizationDirection>) = "Direction" => x
    static member baseHeightMultiplier (x: System.Nullable<System.Int32>) = "BaseHeightMultiplier" => x
    static member baseHorizontalSpacingMultiplier (x: System.Nullable<System.Int32>) = "BaseHorizontalSpacingMultiplier" => x
    static member controlCornerRadius (x: System.Nullable<System.Int32>) = "ControlCornerRadius" => x
    static member strokeWidth (x: System.Nullable<System.Int32>) = "StrokeWidth" => x
    static member focusStrokeWidth (x: System.Nullable<System.Int32>) = "FocusStrokeWidth" => x
    static member disabledOpacity (x: System.Nullable<System.Single>) = "DisabledOpacity" => x
    static member typeRampMinus2FontSize (x: System.Nullable<System.Single>) = "TypeRampMinus2FontSize" => x
    static member typeRampMinus2LineHeight (x: System.Nullable<System.Single>) = "TypeRampMinus2LineHeight" => x
    static member typeRampMinus1FontSize (x: System.Nullable<System.Single>) = "TypeRampMinus1FontSize" => x
    static member typeRampMinus1LineHeight (x: System.Nullable<System.Single>) = "TypeRampMinus1LineHeight" => x
    static member typeRampBaseFontSize (x: System.Nullable<System.Single>) = "TypeRampBaseFontSize" => x
    static member typeRampBaseLineHeight (x: System.Nullable<System.Single>) = "TypeRampBaseLineHeight" => x
    static member typeRampPlus1FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus1FontSize" => x
    static member typeRampPlus1LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus1LineHeight" => x
    static member typeRampPlus2FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus2FontSize" => x
    static member typeRampPlus2LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus2LineHeight" => x
    static member typeRampPlus3FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus3FontSize" => x
    static member typeRampPlus3LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus3LineHeight" => x
    static member typeRampPlus4FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus4FontSize" => x
    static member typeRampPlus4LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus4LineHeight" => x
    static member typeRampPlus5FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus5FontSize" => x
    static member typeRampPlus5LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus5LineHeight" => x
    static member typeRampPlus6FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus6FontSize" => x
    static member typeRampPlus6LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus6LineHeight" => x
    static member accentFillRestDelta (x: System.Nullable<System.Int32>) = "AccentFillRestDelta" => x
    static member accentFillHoverDelta (x: System.Nullable<System.Int32>) = "AccentFillHoverDelta" => x
    static member accentFillActiveDelta (x: System.Nullable<System.Int32>) = "AccentFillActiveDelta" => x
    static member accentFillFocusDelta (x: System.Nullable<System.Int32>) = "AccentFillFocusDelta" => x
    static member accentForegroundRestDelta (x: System.Nullable<System.Int32>) = "AccentForegroundRestDelta" => x
    static member accentForegroundHoverDelta (x: System.Nullable<System.Int32>) = "AccentForegroundHoverDelta" => x
    static member accentForegroundActiveDelta (x: System.Nullable<System.Int32>) = "AccentForegroundActiveDelta" => x
    static member accentForegroundFocusDelta (x: System.Nullable<System.Int32>) = "AccentForegroundFocusDelta" => x
    static member neutralFillRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillRestDelta" => x
    static member neutralFillHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillHoverDelta" => x
    static member neutralFillActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillActiveDelta" => x
    static member neutralFillFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillFocusDelta" => x
    static member neutralFillInputRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputRestDelta" => x
    static member neutralFillInputHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputHoverDelta" => x
    static member neutralFillInputActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputActiveDelta" => x
    static member neutralFillInputFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputFocusDelta" => x
    static member neutralFillLayerRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillLayerRestDelta" => x
    static member neutralFillStealthRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthRestDelta" => x
    static member neutralFillStealthHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthHoverDelta" => x
    static member neutralFillStealthActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthActiveDelta" => x
    static member neutralFillStealthFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthFocusDelta" => x
    static member neutralFillStrongHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongHoverDelta" => x
    static member neutralFillStrongActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongActiveDelta" => x
    static member neutralFillStrongFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongFocusDelta" => x
    static member neutralStrokeDividerRestDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeDividerRestDelta" => x
    static member neutralStrokeRestDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeRestDelta" => x
    static member neutralStrokeHoverDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeHoverDelta" => x
    static member neutralStrokeActiveDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeActiveDelta" => x
    static member neutralStrokeFocusDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeFocusDelta" => x
    static member baseLayerLuminance (x: System.Nullable<System.Single>) = "BaseLayerLuminance" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDialog<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>(){ x }
    static member modal (x: System.Nullable<System.Boolean>) = "Modal" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
    static member hidden (x: System.Boolean) = "Hidden" => x
                    

type fluentDivider<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentFlipper<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>(){ x }
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member direction (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Direction>) = "Direction" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentHorizontalScroll<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>(){ x }
    static member speed (x: System.Int32) = "Speed" => x
    static member easing (x: System.String) = "Easing" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentMenu<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentMenuItem<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>(){ x }
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member checked' (x: System.Nullable<System.Boolean>) = "Checked" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentOption<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentOption>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentOption>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentOption>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentOption>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentOption>(){ x }
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member value (x: System.String) = "Value" => x
    static member name (x: System.String) = "Name" => x
    static member selected (x: System.Nullable<System.Boolean>) = "Selected" => x
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentProgress<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>(){ x }
    static member min (x: System.Nullable<System.Int32>) = "Min" => x
    static member max (x: System.Nullable<System.Int32>) = "Max" => x
    static member value (x: System.String) = "Value" => x
    static member paused (x: System.Nullable<System.Boolean>) = "Paused" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentProgressRing<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>(){ x }
    static member min (x: System.Nullable<System.Int32>) = "Min" => x
    static member max (x: System.Nullable<System.Int32>) = "Max" => x
    static member value (x: System.String) = "Value" => x
    static member paused (x: System.Nullable<System.Boolean>) = "Paused" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentRadio<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio>(){ x }
    static member value (x: System.String) = "Value" => x
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member checked' (x: System.Nullable<System.Boolean>) = "Checked" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentSkeleton<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>(){ x }
    static member shape (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Shape>) = "Shape" => x
    static member shimmer (x: System.Nullable<System.Boolean>) = "Shimmer" => x
    static member pattern (x: System.String) = "Pattern" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentSliderLabel<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member position (x: System.Nullable<System.Int32>) = "Position" => x
    static member hideMark (x: System.Nullable<System.Boolean>) = "HideMark" => x
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTab<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTabPanel<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTabPanel>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTabPanel>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTabPanel>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTabPanel>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTabPanel>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTabs<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>(){ x }
    static member activeIndicator (x: System.Nullable<System.Boolean>) = "ActiveIndicator" => x
    static member orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentToolbar<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentToolbar>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentToolbar>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentToolbar>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentToolbar>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentToolbar>(){ x }
    static member orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTooltip<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltip>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltip>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltip>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltip>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltip>(){ x }
    static member anchor (x: System.String) = "Anchor" => x
    static member position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.TooltipPosition>) = "Position" => x
    static member delay (x: System.Nullable<System.Int32>) = "Delay" => x
    static member visible (x: System.Nullable<System.Boolean>) = "Visible" => x
    static member horizontalViewportLock (x: System.Nullable<System.Boolean>) = "HorizontalViewportLock" => x
    static member verticalViewportLock (x: System.Nullable<System.Boolean>) = "VerticalViewportLock" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTreeItem<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member selected (x: System.Nullable<System.Boolean>) = "Selected" => x
    static member expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTreeView<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>(){ x }
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member renderCollapsedNodes (x: System.Nullable<System.Boolean>) = "RenderCollapsedNodes" => x
    static member additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentInputBase<'FunBlazorGeneric, 'TValue> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>() { yield! attrs }

    static member additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
    static member value (x: 'TValue) = "Value" => x
    static member value' (value: IStore<'TValue>) = html.bind("Value", value)
    static member value' (value: cval<'TValue>) = html.bind("Value", value)
    static member value' (valueFn: 'TValue * ('TValue -> unit)) = html.bind("Value", valueFn)
    static member valueChanged fn = html.callback<'TValue>("ValueChanged", fn)
    static member valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x
    static member displayName (x: System.String) = "DisplayName" => x
                    

type fluentCheckbox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Boolean>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>(){ x }
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentCombobox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox>(){ x }
    static member name (x: System.String) = "Name" => x
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member autocomplete (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Autocomplete>) = "Autocomplete" => x
    static member position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentListbox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox>(){ x }
    static member name (x: System.String) = "Name" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentNumberField<'FunBlazorGeneric, 'TValue> =
    inherit fluentInputBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>(){ x }
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x
    static member size (x: System.Int32) = "Size" => x
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member placeholder (x: System.String) = "Placeholder" => x
    static member parsingErrorMessage (x: System.String) = "ParsingErrorMessage" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member min (x: System.String) = "Min" => x
    static member max (x: System.String) = "Max" => x
    static member minLength (x: System.Int32) = "MinLength" => x
    static member maxLength (x: System.Int32) = "MaxLength" => x
    static member step (x: System.Int32) = "Step" => x
                    

type fluentRadioGroup<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>(){ x }
    static member name (x: System.String) = "Name" => x
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentSelect<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect>(){ x }
    static member name (x: System.String) = "Name" => x
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentSlider<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Int32>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider>(){ x }
    static member orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x
    static member min (x: System.Nullable<System.Int32>) = "Min" => x
    static member max (x: System.Nullable<System.Int32>) = "Max" => x
    static member step (x: System.Nullable<System.Int32>) = "Step" => x
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentSwitch<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Boolean>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>(){ x }
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member checked' (x: System.Nullable<System.Boolean>) = "Checked" => x
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentTextArea<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>(){ x }
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x
    static member resize (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member placeholder (x: System.String) = "Placeholder" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentTextField<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>() { yield! attrs }
    static member inline create (nodes: NodeRenderFragment seq) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>() { yield! nodes }
    static member inline create (node: NodeRenderFragment) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>() { node }
    static member inline create (x: string) = ComponentWithChildBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>(){ x }
    static member disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x
    static member size (x: System.Nullable<System.Int32>) = "Size" => x
    static member appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member textFieldType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.TextFieldType>) = "TextFieldType" => x
    static member placeholder (x: System.String) = "Placeholder" => x
    static member minLength (x: System.Nullable<System.Int32>) = "MinLength" => x
    static member maxLength (x: System.Nullable<System.Int32>) = "MaxLength" => x
    static member spellcheck (x: System.Nullable<System.Boolean>) = "Spellcheck" => x
    static member childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member childContent (node) = html.renderFragment("ChildContent", node)
    static member childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type _Imports<'FunBlazorGeneric> =
    
    static member inline create () = html.fromBuilder(ComponentBuilder<Microsoft.Fast.Components.FluentUI._Imports>())
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI._Imports>() { yield! attrs }


                    
            

// =======================================================================================================================

namespace Microsoft.Fast.Components.FluentUI

open Microsoft.Fast.Components.FluentUI.DslInternals


type IFluentAccordionNode = interface end
type fluentAccordion =
    class
        inherit fluentAccordion<IFluentAccordionNode>
    end
                    

type IFluentAccordionItemNode = interface end
type fluentAccordionItem =
    class
        inherit fluentAccordionItem<IFluentAccordionItemNode>
    end
                    

type IFluentAnchorNode = interface end
type fluentAnchor =
    class
        inherit fluentAnchor<IFluentAnchorNode>
    end
                    

type IFluentAnchoredRegionNode = interface end
type fluentAnchoredRegion =
    class
        inherit fluentAnchoredRegion<IFluentAnchoredRegionNode>
    end
                    

type IFluentBadgeNode = interface end
type fluentBadge =
    class
        inherit fluentBadge<IFluentBadgeNode>
    end
                    

type IFluentBreadcrumbNode = interface end
type fluentBreadcrumb =
    class
        inherit fluentBreadcrumb<IFluentBreadcrumbNode>
    end
                    

type IFluentBreadcrumbItemNode = interface end
type fluentBreadcrumbItem =
    class
        inherit fluentBreadcrumbItem<IFluentBreadcrumbItemNode>
    end
                    

type IFluentButtonNode = interface end
type fluentButton =
    class
        inherit fluentButton<IFluentButtonNode>
    end
                    

type IFluentCardNode = interface end
type fluentCard =
    class
        inherit fluentCard<IFluentCardNode>
    end
                    

type IFluentDataGridNode<'TItem> = interface end
type fluentDataGrid<'TItem> =
    class
        inherit fluentDataGrid<IFluentDataGridNode<'TItem>, 'TItem>
    end
                    

type IFluentDataGridCellNode = interface end
type fluentDataGridCell =
    class
        inherit fluentDataGridCell<IFluentDataGridCellNode>
    end
                    

type IFluentDataGridRowNode<'TItem> = interface end
type fluentDataGridRow<'TItem> =
    class
        inherit fluentDataGridRow<IFluentDataGridRowNode<'TItem>, 'TItem>
    end
                    

type IFluentDesignSystemProviderNode = interface end
type fluentDesignSystemProvider =
    class
        inherit fluentDesignSystemProvider<IFluentDesignSystemProviderNode>
    end
                    

type IFluentDialogNode = interface end
type fluentDialog =
    class
        inherit fluentDialog<IFluentDialogNode>
    end
                    

type IFluentDividerNode = interface end
type fluentDivider =
    class
        inherit fluentDivider<IFluentDividerNode>
    end
                    

type IFluentFlipperNode = interface end
type fluentFlipper =
    class
        inherit fluentFlipper<IFluentFlipperNode>
    end
                    

type IFluentHorizontalScrollNode = interface end
type fluentHorizontalScroll =
    class
        inherit fluentHorizontalScroll<IFluentHorizontalScrollNode>
    end
                    

type IFluentMenuNode = interface end
type fluentMenu =
    class
        inherit fluentMenu<IFluentMenuNode>
    end
                    

type IFluentMenuItemNode = interface end
type fluentMenuItem =
    class
        inherit fluentMenuItem<IFluentMenuItemNode>
    end
                    

type IFluentOptionNode = interface end
type fluentOption =
    class
        inherit fluentOption<IFluentOptionNode>
    end
                    

type IFluentProgressNode = interface end
type fluentProgress =
    class
        inherit fluentProgress<IFluentProgressNode>
    end
                    

type IFluentProgressRingNode = interface end
type fluentProgressRing =
    class
        inherit fluentProgressRing<IFluentProgressRingNode>
    end
                    

type IFluentRadioNode = interface end
type fluentRadio =
    class
        inherit fluentRadio<IFluentRadioNode>
    end
                    

type IFluentSkeletonNode = interface end
type fluentSkeleton =
    class
        inherit fluentSkeleton<IFluentSkeletonNode>
    end
                    

type IFluentSliderLabelNode = interface end
type fluentSliderLabel =
    class
        inherit fluentSliderLabel<IFluentSliderLabelNode>
    end
                    

type IFluentTabNode = interface end
type fluentTab =
    class
        inherit fluentTab<IFluentTabNode>
    end
                    

type IFluentTabPanelNode = interface end
type fluentTabPanel =
    class
        inherit fluentTabPanel<IFluentTabPanelNode>
    end
                    

type IFluentTabsNode = interface end
type fluentTabs =
    class
        inherit fluentTabs<IFluentTabsNode>
    end
                    

type IFluentToolbarNode = interface end
type fluentToolbar =
    class
        inherit fluentToolbar<IFluentToolbarNode>
    end
                    

type IFluentTooltipNode = interface end
type fluentTooltip =
    class
        inherit fluentTooltip<IFluentTooltipNode>
    end
                    

type IFluentTreeItemNode = interface end
type fluentTreeItem =
    class
        inherit fluentTreeItem<IFluentTreeItemNode>
    end
                    

type IFluentTreeViewNode = interface end
type fluentTreeView =
    class
        inherit fluentTreeView<IFluentTreeViewNode>
    end
                    

type IFluentInputBaseNode<'TValue> = interface end
type fluentInputBase<'TValue> =
    class
        inherit fluentInputBase<IFluentInputBaseNode<'TValue>, 'TValue>
    end
                    

type IFluentCheckboxNode = interface end
type fluentCheckbox =
    class
        inherit fluentCheckbox<IFluentCheckboxNode>
    end
                    

type IFluentComboboxNode = interface end
type fluentCombobox =
    class
        inherit fluentCombobox<IFluentComboboxNode>
    end
                    

type IFluentListboxNode = interface end
type fluentListbox =
    class
        inherit fluentListbox<IFluentListboxNode>
    end
                    

type IFluentNumberFieldNode<'TValue> = interface end
type fluentNumberField<'TValue> =
    class
        inherit fluentNumberField<IFluentNumberFieldNode<'TValue>, 'TValue>
    end
                    

type IFluentRadioGroupNode = interface end
type fluentRadioGroup =
    class
        inherit fluentRadioGroup<IFluentRadioGroupNode>
    end
                    

type IFluentSelectNode = interface end
type fluentSelect =
    class
        inherit fluentSelect<IFluentSelectNode>
    end
                    

type IFluentSliderNode = interface end
type fluentSlider =
    class
        inherit fluentSlider<IFluentSliderNode>
    end
                    

type IFluentSwitchNode = interface end
type fluentSwitch =
    class
        inherit fluentSwitch<IFluentSwitchNode>
    end
                    

type IFluentTextAreaNode = interface end
type fluentTextArea =
    class
        inherit fluentTextArea<IFluentTextAreaNode>
    end
                    

type IFluentTextFieldNode = interface end
type fluentTextField =
    class
        inherit fluentTextField<IFluentTextFieldNode>
    end
                    

type I_ImportsNode = interface end
type _Imports =
    class
        inherit _Imports<I_ImportsNode>
    end
                    
            