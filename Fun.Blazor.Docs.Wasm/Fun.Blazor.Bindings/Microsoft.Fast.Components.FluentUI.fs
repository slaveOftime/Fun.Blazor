namespace rec Microsoft.Fast.Components.FluentUI.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.Fast.Components.FluentUI.DslInternals


type fluentAccordion<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordion>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline expandMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.ExpandMode>) = "ExpandMode" => x
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentAccordionItem<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAccordionItem>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentAnchor<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchor>() { html.mergeAttrs attrs }

    static member inline href (x: System.String) = "Href" => x
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentAnchoredRegion<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentAnchoredRegion>() { html.mergeAttrs attrs }

    static member inline anchor (x: System.String) = "Anchor" => x
    static member inline viewport (x: System.String) = "Viewport" => x
    static member inline horizontalPositioningMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Positioning>) = "HorizontalPositioningMode" => x
    static member inline horizontalDefaultPosition (x: System.Nullable<Microsoft.Fast.Components.FluentUI.HorizontalPosition>) = "HorizontalDefaultPosition" => x
    static member inline horizontalInset (x: System.Boolean) = "HorizontalInset" => x
    static member inline horizontalThreshold (x: System.Int32) = "HorizontalThreshold" => x
    static member inline horizontalScaling (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Scaling>) = "HorizontalScaling" => x
    static member inline verticalPositioningMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Positioning>) = "VerticalPositioningMode" => x
    static member inline verticalDefaultPosition (x: System.Nullable<Microsoft.Fast.Components.FluentUI.VerticalPosition>) = "VerticalDefaultPosition" => x
    static member inline verticalInset (x: System.Boolean) = "VerticalInset" => x
    static member inline verticalThreshold (x: System.Int32) = "VerticalThreshold" => x
    static member inline verticalScaling (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Scaling>) = "VerticalScaling" => x
    static member inline autoUpdateMode (x: System.Nullable<Microsoft.Fast.Components.FluentUI.UpdateMode>) = "AutoUpdateMode" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentBadge<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBadge>() { html.mergeAttrs attrs }

    static member inline color (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Color>) = "Color" => x
    static member inline fill (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Fill>) = "Fill" => x
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentBreadcrumb<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumb>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentBreadcrumbItem<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentBreadcrumbItem>() { html.mergeAttrs attrs }

    static member inline href (x: System.String) = "Href" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentButton<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentButton>() { html.mergeAttrs attrs }

    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentCard<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCard>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDataGrid<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGrid<'TItem>>() { html.mergeAttrs attrs }

    static member inline generateHeader (x: System.Nullable<Microsoft.Fast.Components.FluentUI.GenerateHeaderOptions>) = "GenerateHeader" => x
    static member inline gridTemplateColumns (x: System.String) = "GridTemplateColumns" => x
    static member inline rowsData (x: System.Collections.Generic.List<'TItem>) = "RowsData" => x
    static member inline columnDefinitions (x: System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem>>) = "ColumnDefinitions" => x
    static member inline headerCellTemplate (render: Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem> -> NodeRenderFragment) = html.renderFragment("HeaderCellTemplate", render)
    static member inline rowItemTemplate (render: 'TItem -> NodeRenderFragment) = html.renderFragment("RowItemTemplate", render)
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDataGridCell<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridCell>() { html.mergeAttrs attrs }

    static member inline cellType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.DataGridCellType>) = "CellType" => x
    static member inline gridColumn (x: System.Int32) = "GridColumn" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDataGridRow<'FunBlazorGeneric, 'TItem> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDataGridRow<'TItem>>() { html.mergeAttrs attrs }

    static member inline rowIndex (x: System.Nullable<System.Int32>) = "RowIndex" => x
    static member inline gridTemplateColumns (x: System.String) = "GridTemplateColumns" => x
    static member inline rowType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.DataGridRowType>) = "RowType" => x
    static member inline rowData (x: 'TItem) = "RowData" => x
    static member inline columnDefinitions (x: System.Collections.Generic.IEnumerable<Microsoft.Fast.Components.FluentUI.ColumnDefinition<'TItem>>) = "ColumnDefinitions" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDesignSystemProvider<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDesignSystemProvider>() { html.mergeAttrs attrs }

    static member inline noPaint (x: System.Nullable<System.Boolean>) = "NoPaint" => x
    static member inline fillColor (x: System.String) = "FillColor" => x
    static member inline accentBaseColor (x: System.String) = "AccentBaseColor" => x
    static member inline neutralBaseColor (x: System.String) = "NeutralBaseColor" => x
    static member inline density (x: System.Nullable<System.Int32>) = "Density" => x
    static member inline designUnit (x: System.Nullable<System.Int32>) = "DesignUnit" => x
    static member inline direction (x: System.Nullable<Microsoft.Fast.Components.FluentUI.LocalizationDirection>) = "Direction" => x
    static member inline baseHeightMultiplier (x: System.Nullable<System.Int32>) = "BaseHeightMultiplier" => x
    static member inline baseHorizontalSpacingMultiplier (x: System.Nullable<System.Int32>) = "BaseHorizontalSpacingMultiplier" => x
    static member inline controlCornerRadius (x: System.Nullable<System.Int32>) = "ControlCornerRadius" => x
    static member inline strokeWidth (x: System.Nullable<System.Int32>) = "StrokeWidth" => x
    static member inline focusStrokeWidth (x: System.Nullable<System.Int32>) = "FocusStrokeWidth" => x
    static member inline disabledOpacity (x: System.Nullable<System.Single>) = "DisabledOpacity" => x
    static member inline typeRampMinus2FontSize (x: System.Nullable<System.Single>) = "TypeRampMinus2FontSize" => x
    static member inline typeRampMinus2LineHeight (x: System.Nullable<System.Single>) = "TypeRampMinus2LineHeight" => x
    static member inline typeRampMinus1FontSize (x: System.Nullable<System.Single>) = "TypeRampMinus1FontSize" => x
    static member inline typeRampMinus1LineHeight (x: System.Nullable<System.Single>) = "TypeRampMinus1LineHeight" => x
    static member inline typeRampBaseFontSize (x: System.Nullable<System.Single>) = "TypeRampBaseFontSize" => x
    static member inline typeRampBaseLineHeight (x: System.Nullable<System.Single>) = "TypeRampBaseLineHeight" => x
    static member inline typeRampPlus1FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus1FontSize" => x
    static member inline typeRampPlus1LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus1LineHeight" => x
    static member inline typeRampPlus2FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus2FontSize" => x
    static member inline typeRampPlus2LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus2LineHeight" => x
    static member inline typeRampPlus3FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus3FontSize" => x
    static member inline typeRampPlus3LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus3LineHeight" => x
    static member inline typeRampPlus4FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus4FontSize" => x
    static member inline typeRampPlus4LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus4LineHeight" => x
    static member inline typeRampPlus5FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus5FontSize" => x
    static member inline typeRampPlus5LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus5LineHeight" => x
    static member inline typeRampPlus6FontSize (x: System.Nullable<System.Single>) = "TypeRampPlus6FontSize" => x
    static member inline typeRampPlus6LineHeight (x: System.Nullable<System.Single>) = "TypeRampPlus6LineHeight" => x
    static member inline accentFillRestDelta (x: System.Nullable<System.Int32>) = "AccentFillRestDelta" => x
    static member inline accentFillHoverDelta (x: System.Nullable<System.Int32>) = "AccentFillHoverDelta" => x
    static member inline accentFillActiveDelta (x: System.Nullable<System.Int32>) = "AccentFillActiveDelta" => x
    static member inline accentFillFocusDelta (x: System.Nullable<System.Int32>) = "AccentFillFocusDelta" => x
    static member inline accentForegroundRestDelta (x: System.Nullable<System.Int32>) = "AccentForegroundRestDelta" => x
    static member inline accentForegroundHoverDelta (x: System.Nullable<System.Int32>) = "AccentForegroundHoverDelta" => x
    static member inline accentForegroundActiveDelta (x: System.Nullable<System.Int32>) = "AccentForegroundActiveDelta" => x
    static member inline accentForegroundFocusDelta (x: System.Nullable<System.Int32>) = "AccentForegroundFocusDelta" => x
    static member inline neutralFillRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillRestDelta" => x
    static member inline neutralFillHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillHoverDelta" => x
    static member inline neutralFillActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillActiveDelta" => x
    static member inline neutralFillFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillFocusDelta" => x
    static member inline neutralFillInputRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputRestDelta" => x
    static member inline neutralFillInputHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputHoverDelta" => x
    static member inline neutralFillInputActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputActiveDelta" => x
    static member inline neutralFillInputFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillInputFocusDelta" => x
    static member inline neutralFillLayerRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillLayerRestDelta" => x
    static member inline neutralFillStealthRestDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthRestDelta" => x
    static member inline neutralFillStealthHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthHoverDelta" => x
    static member inline neutralFillStealthActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthActiveDelta" => x
    static member inline neutralFillStealthFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillStealthFocusDelta" => x
    static member inline neutralFillStrongHoverDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongHoverDelta" => x
    static member inline neutralFillStrongActiveDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongActiveDelta" => x
    static member inline neutralFillStrongFocusDelta (x: System.Nullable<System.Int32>) = "NeutralFillStrongFocusDelta" => x
    static member inline neutralStrokeDividerRestDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeDividerRestDelta" => x
    static member inline neutralStrokeRestDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeRestDelta" => x
    static member inline neutralStrokeHoverDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeHoverDelta" => x
    static member inline neutralStrokeActiveDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeActiveDelta" => x
    static member inline neutralStrokeFocusDelta (x: System.Nullable<System.Int32>) = "NeutralStrokeFocusDelta" => x
    static member inline baseLayerLuminance (x: System.Nullable<System.Single>) = "BaseLayerLuminance" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentDialog<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDialog>() { html.mergeAttrs attrs }

    static member inline modal (x: System.Nullable<System.Boolean>) = "Modal" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
    static member inline hidden (x: System.Boolean) = "Hidden" => x
                    

type fluentDivider<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentDivider>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentFlipper<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentFlipper>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline direction (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Direction>) = "Direction" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentHorizontalScroll<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentHorizontalScroll>() { html.mergeAttrs attrs }

    static member inline speed (x: System.Int32) = "Speed" => x
    static member inline easing (x: System.String) = "Easing" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentMenu<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentMenu>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentMenuItem<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentMenuItem>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline checked' (x: System.Nullable<System.Boolean>) = "Checked" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentOption<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentOption>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentOption>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline value (x: System.String) = "Value" => x
    static member inline name (x: System.String) = "Name" => x
    static member inline selected (x: System.Nullable<System.Boolean>) = "Selected" => x
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentProgress<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentProgress>() { html.mergeAttrs attrs }

    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x
    static member inline value (x: System.String) = "Value" => x
    static member inline paused (x: System.Nullable<System.Boolean>) = "Paused" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentProgressRing<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentProgressRing>() { html.mergeAttrs attrs }

    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x
    static member inline value (x: System.String) = "Value" => x
    static member inline paused (x: System.Nullable<System.Boolean>) = "Paused" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentRadio<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentRadio>() { html.mergeAttrs attrs }

    static member inline value (x: System.String) = "Value" => x
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member inline checked' (x: System.Nullable<System.Boolean>) = "Checked" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentSkeleton<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSkeleton>() { html.mergeAttrs attrs }

    static member inline shape (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Shape>) = "Shape" => x
    static member inline shimmer (x: System.Nullable<System.Boolean>) = "Shimmer" => x
    static member inline pattern (x: System.String) = "Pattern" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentSliderLabel<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSliderLabel>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline position (x: System.Nullable<System.Int32>) = "Position" => x
    static member inline hideMark (x: System.Nullable<System.Boolean>) = "HideMark" => x
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTab<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTab>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTabPanel<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTabPanel>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTabPanel>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTabs<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTabs>() { html.mergeAttrs attrs }

    static member inline activeIndicator (x: System.Nullable<System.Boolean>) = "ActiveIndicator" => x
    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentToolbar<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentToolbar>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentToolbar>() { html.mergeAttrs attrs }

    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTooltip<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltip>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTooltip>() { html.mergeAttrs attrs }

    static member inline anchor (x: System.String) = "Anchor" => x
    static member inline position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.TooltipPosition>) = "Position" => x
    static member inline delay (x: System.Nullable<System.Int32>) = "Delay" => x
    static member inline visible (x: System.Nullable<System.Boolean>) = "Visible" => x
    static member inline horizontalViewportLock (x: System.Nullable<System.Boolean>) = "HorizontalViewportLock" => x
    static member inline verticalViewportLock (x: System.Nullable<System.Boolean>) = "VerticalViewportLock" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTreeItem<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeItem>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline selected (x: System.Nullable<System.Boolean>) = "Selected" => x
    static member inline expanded (x: System.Nullable<System.Boolean>) = "Expanded" => x
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentTreeView<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTreeView>() { html.mergeAttrs attrs }

    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline renderCollapsedNodes (x: System.Nullable<System.Boolean>) = "RenderCollapsedNodes" => x
    static member inline additionalAttributes (x: System.Collections.Generic.IDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
                    

type fluentInputBase<'FunBlazorGeneric, 'TValue> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentInputBase<'TValue>>() { html.mergeAttrs attrs }

    static member inline additionalAttributes (x: System.Collections.Generic.IReadOnlyDictionary<System.String, System.Object>) = "AdditionalAttributes" => x
    static member inline value (x: 'TValue) = "Value" => x
    static member inline value' (value: IStore<'TValue>) = html.bind("Value", value)
    static member inline value' (value: cval<'TValue>) = html.bind("Value", value)
    static member inline value' (valueFn: 'TValue * ('TValue -> unit)) = html.bind("Value", valueFn)
    static member inline valueChanged fn = html.callback<'TValue>("ValueChanged", fn)
    static member inline valueExpression (x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x
    static member inline displayName (x: System.String) = "DisplayName" => x
                    

type fluentCheckbox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Boolean>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCheckbox>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentCombobox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentCombobox>() { html.mergeAttrs attrs }

    static member inline name (x: System.String) = "Name" => x
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member inline autocomplete (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Autocomplete>) = "Autocomplete" => x
    static member inline position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentListbox<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentListbox>() { html.mergeAttrs attrs }

    static member inline name (x: System.String) = "Name" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentNumberField<'FunBlazorGeneric, 'TValue> =
    inherit fluentInputBase<'FunBlazorGeneric, 'TValue>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentNumberField<'TValue>>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x
    static member inline size (x: System.Int32) = "Size" => x
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline parsingErrorMessage (x: System.String) = "ParsingErrorMessage" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
    static member inline min (x: System.String) = "Min" => x
    static member inline max (x: System.String) = "Max" => x
    static member inline minLength (x: System.Int32) = "MinLength" => x
    static member inline maxLength (x: System.Int32) = "MaxLength" => x
    static member inline step (x: System.Int32) = "Step" => x
                    

type fluentRadioGroup<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentRadioGroup>() { html.mergeAttrs attrs }

    static member inline name (x: System.String) = "Name" => x
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentSelect<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSelect>() { html.mergeAttrs attrs }

    static member inline name (x: System.String) = "Name" => x
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member inline position (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Position>) = "Position" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentSlider<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Int32>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSlider>() { html.mergeAttrs attrs }

    static member inline orientation (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Orientation>) = "Orientation" => x
    static member inline min (x: System.Nullable<System.Int32>) = "Min" => x
    static member inline max (x: System.Nullable<System.Int32>) = "Max" => x
    static member inline step (x: System.Nullable<System.Int32>) = "Step" => x
    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentSwitch<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.Boolean>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentSwitch>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline checked' (x: System.Nullable<System.Boolean>) = "Checked" => x
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentTextArea<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTextArea>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x
    static member inline resize (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Resize>) = "Resize" => x
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type fluentTextField<'FunBlazorGeneric> =
    inherit fluentInputBase<'FunBlazorGeneric, System.String>
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI.FluentTextField>() { html.mergeAttrs attrs }

    static member inline disabled (x: System.Nullable<System.Boolean>) = "Disabled" => x
    static member inline readonly (x: System.Nullable<System.Boolean>) = "Readonly" => x
    static member inline required (x: System.Nullable<System.Boolean>) = "Required" => x
    static member inline autofocus (x: System.Nullable<System.Boolean>) = "Autofocus" => x
    static member inline size (x: System.Nullable<System.Int32>) = "Size" => x
    static member inline appearance (x: System.Nullable<Microsoft.Fast.Components.FluentUI.Appearance>) = "Appearance" => x
    static member inline textFieldType (x: System.Nullable<Microsoft.Fast.Components.FluentUI.TextFieldType>) = "TextFieldType" => x
    static member inline placeholder (x: System.String) = "Placeholder" => x
    static member inline minLength (x: System.Nullable<System.Int32>) = "MinLength" => x
    static member inline maxLength (x: System.Nullable<System.Int32>) = "MaxLength" => x
    static member inline spellcheck (x: System.Nullable<System.Boolean>) = "Spellcheck" => x
    static member inline childContent (x: string) = html.renderFragment("ChildContent", html.text x)
    static member inline childContent (node) = html.renderFragment("ChildContent", node)
    static member inline childContent (nodes) = html.renderFragment("ChildContent", fragment { yield! nodes })
                    

type _Imports<'FunBlazorGeneric> =
    
    static member inline create () = ComponentBuilder<Microsoft.Fast.Components.FluentUI._Imports>()
    static member inline create (attrs: AttrRenderFragment seq) = ComponentBuilder<Microsoft.Fast.Components.FluentUI._Imports>() { html.mergeAttrs attrs }


                    
            

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
                    
            