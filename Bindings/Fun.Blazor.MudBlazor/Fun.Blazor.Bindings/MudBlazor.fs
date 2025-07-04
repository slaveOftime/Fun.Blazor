namespace rec MudBlazor.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

/// Represents a base class for designing components which maintain state.
type ComponentBaseWithStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


/// Represents a base class for designing MudBlazor components.
type MudComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBaseWithStateBuilder<'FunBlazorGeneric>()
    /// The arbitrary object to link to this component.
    [<CustomOperation("Tag")>] member inline _.Tag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Tag" => x)
    /// The additional HTML attributes to apply to this component.
    [<CustomOperation("UserAttributes")>] member inline _.UserAttributes ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = render ==> ("UserAttributes" => x)

/// Shared a base class for designing category MudChart and MudTimeSeriesChart components.
type MudChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The display options applied to the chart.
    [<CustomOperation("ChartOptions")>] member inline _.ChartOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ChartOptions) = render ==> ("ChartOptions" => x)
    /// Display options for axis-based charts.
    [<CustomOperation("AxisChartOptions")>] member inline _.AxisChartOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.AxisChartOptions) = render ==> ("AxisChartOptions" => x)
    /// The custom graphics within this chart.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("CustomGraphics", fragment)
    /// The custom graphics within this chart.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("CustomGraphics", fragment { yield! fragments })
    /// The custom graphics within this chart.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CustomGraphics", html.text x)
    /// The custom graphics within this chart.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CustomGraphics", html.text x)
    /// The custom graphics within this chart.
    [<CustomOperation("CustomGraphics")>] member inline _.CustomGraphics ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CustomGraphics", html.text x)
    /// The type of chart to display.
    [<CustomOperation("ChartType")>] member inline _.ChartType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ChartType) = render ==> ("ChartType" => x)
    /// The width of the chart, as a CSS style.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// The height of the chart, as a CSS style.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// The location of series labels.
    [<CustomOperation("LegendPosition")>] member inline _.LegendPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("LegendPosition" => x)
    /// The currently selected data point.
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// The currently selected data point.
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    /// Occurs when the SelectedIndex has changed.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("SelectedIndexChanged", fn)
    /// Occurs when the SelectedIndex has changed.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedIndexChanged", fn)
    /// Allows series to be hidden when ChartType is Line.
    [<CustomOperation("CanHideSeries")>] member inline _.CanHideSeries ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CanHideSeries" =>>> true)
    /// Allows series to be hidden when ChartType is Line.
    [<CustomOperation("CanHideSeries")>] member inline _.CanHideSeries ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CanHideSeries" =>>> x)

/// Represents a base class for designing category MudChart components.
type MudCategoryChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    /// The data to be displayed.
    [<CustomOperation("InputData")>] member inline _.InputData ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double[]) = render ==> ("InputData" => x)
    /// The labels describing data values.
    [<CustomOperation("InputLabels")>] member inline _.InputLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("InputLabels" => x)
    /// The labels applied to the horizontal axis.
    [<CustomOperation("XAxisLabels")>] member inline _.XAxisLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("XAxisLabels" => x)
    /// The series of values to display.
    [<CustomOperation("ChartSeries")>] member inline _.ChartSeries ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = render ==> ("ChartSeries" => x)

type MudCategoryAxisChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudCategoryChartBaseBuilder<'FunBlazorGeneric>()


            
namespace rec MudBlazor.DslInternals.Charts

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

/// Represents a chart which displays series values as rectangular bars.
type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudCategoryAxisChartBaseBuilder<'FunBlazorGeneric>()


/// Represents a chart which displays series values as connected lines.
type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudCategoryAxisChartBaseBuilder<'FunBlazorGeneric>()


/// Represents a chart which displays series values as portions of vertical rectangles.
type StackedBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudCategoryAxisChartBaseBuilder<'FunBlazorGeneric>()


            
namespace rec MudBlazor.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

/// Represents a graphic display of data values in a line, bar, stacked bar, pie, heat map, or donut shape.
type MudChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudCategoryChartBaseBuilder<'FunBlazorGeneric>()


            
namespace rec MudBlazor.DslInternals.Charts

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

/// Represents a chart which displays values as a percentage of a circle.
type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudCategoryChartBaseBuilder<'FunBlazorGeneric>()


type HeatMapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudCategoryChartBaseBuilder<'FunBlazorGeneric>()


/// Represents a chart which displays values as a percentage of a circle.
type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudCategoryChartBaseBuilder<'FunBlazorGeneric>()
    /// Defines the ratio of the circle to the donut hole.
    [<CustomOperation("CircleDonutRatio")>] member inline _.CircleDonutRatio ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("CircleDonutRatio" => x)

            
namespace rec MudBlazor.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type MudTimeSeriesChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    /// The series of values to display.
    [<CustomOperation("ChartSeries")>] member inline _.ChartSeries ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.TimeSeriesChartSeries>) = render ==> ("ChartSeries" => x)
    /// A way to have minimum spacing between timestamp labels, default of 5 minutes.
    [<CustomOperation("TimeLabelSpacing")>] member inline _.TimeLabelSpacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("TimeLabelSpacing" => x)
    /// Determines whether timestamp labels should be rounded to the nearest spacing value. 
    [<CustomOperation("TimeLabelSpacingRounding")>] member inline _.TimeLabelSpacingRounding ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TimeLabelSpacingRounding" =>>> true)
    /// Determines whether timestamp labels should be rounded to the nearest spacing value. 
    [<CustomOperation("TimeLabelSpacingRounding")>] member inline _.TimeLabelSpacingRounding ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TimeLabelSpacingRounding" =>>> x)
    /// Determines how timestamp labels are adjusted when TimeLabelSpacingRounding is enabled.
    [<CustomOperation("TimeLabelSpacingRoundingPadSeries")>] member inline _.TimeLabelSpacingRoundingPadSeries ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TimeLabelSpacingRoundingPadSeries" =>>> true)
    /// Determines how timestamp labels are adjusted when TimeLabelSpacingRounding is enabled.
    [<CustomOperation("TimeLabelSpacingRoundingPadSeries")>] member inline _.TimeLabelSpacingRoundingPadSeries ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TimeLabelSpacingRoundingPadSeries" =>>> x)
    /// Specifies the datetime format for timestamp labels. 
    [<CustomOperation("TimeLabelFormat")>] member inline _.TimeLabelFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeLabelFormat" => x)
    /// Specifies the DateTime format for Timestamp labels in DataPoint marker tooltips. 
    [<CustomOperation("DataMarkerTooltipTimeLabelFormat")>] member inline _.DataMarkerTooltipTimeLabelFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataMarkerTooltipTimeLabelFormat" => x)
    /// Specifies the title for the X axis.
    [<CustomOperation("XAxisTitle")>] member inline _.XAxisTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("XAxisTitle" => x)
    /// Specifies the title for the Y axis.
    [<CustomOperation("YAxisTitle")>] member inline _.YAxisTitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("YAxisTitle" => x)
    /// Determines if the chart should derive its bounds from the parent chart.
    [<CustomOperation("MatchBoundsToSize")>] member inline _.MatchBoundsToSize ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MatchBoundsToSize" =>>> true)
    /// Determines if the chart should derive its bounds from the parent chart.
    [<CustomOperation("MatchBoundsToSize")>] member inline _.MatchBoundsToSize ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MatchBoundsToSize" =>>> x)

type MudTimeSeriesChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTimeSeriesChartBaseBuilder<'FunBlazorGeneric>()


            
namespace rec MudBlazor.DslInternals.Charts

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

/// A chart which displays values over time.
type TimeSeriesBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTimeSeriesChartBaseBuilder<'FunBlazorGeneric>()


/// Represents a set of text labels which describe data values in a MudChart.
type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    /// The data labels for this legend.
    [<CustomOperation("Data")>] member inline _.Data ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.SvgLegend>) = render ==> ("Data" => x)

            
namespace rec MudBlazor.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

/// Represents a bar used to display actions, branding, navigation and screen titles.
type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Places the appbar at the bottom of the screen instead of the top.
    [<CustomOperation("Bottom")>] member inline _.Bottom ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Bottom" =>>> true)
    /// Places the appbar at the bottom of the screen instead of the top.
    [<CustomOperation("Bottom")>] member inline _.Bottom ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Bottom" =>>> x)
    /// Allows the app bar to be overridden with page specific actions
    [<CustomOperation("Contextual")>] member inline _.Contextual ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Contextual" =>>> true)
    /// Allows the app bar to be overridden with page specific actions
    [<CustomOperation("Contextual")>] member inline _.Contextual ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Contextual" =>>> x)
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Adds left and right padding to this appbar.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Gutters" =>>> true)
    /// Adds left and right padding to this appbar.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Gutters" =>>> x)
    /// The color of this appbar.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Fixes this appbar in place as the page is scrolled.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Fixed" =>>> true)
    /// Fixes this appbar in place as the page is scrolled.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Fixed" =>>> x)
    /// Allows appbar content to wrap.
    [<CustomOperation("WrapContent")>] member inline _.WrapContent ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("WrapContent" =>>> true)
    /// Allows appbar content to wrap.
    [<CustomOperation("WrapContent")>] member inline _.WrapContent ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("WrapContent" =>>> x)
    /// The CSS classes applied to the nested toolbar.
    [<CustomOperation("ToolBarClass")>] member inline _.ToolBarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToolBarClass" => x)

/// A contextual app bar.
type MudContextualActionBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudAppBarBuilder<'FunBlazorGeneric>()
    /// Determines if the action bar is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Determines if the action bar is visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)

/// Represents a base class for designing button components.
type MudBaseButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The HTML tag rendered for this component.
    [<CustomOperation("HtmlTag")>] member inline _.HtmlTag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    /// The type of button.
    [<CustomOperation("ButtonType")>] member inline _.ButtonType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ButtonType) = render ==> ("ButtonType" => x)
    /// The URL to navigate to when the button is clicked.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// The browser tab/window opened when a click occurs and Href is set.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// The relationship between the current document and the linked document when Href is set.
    [<CustomOperation("Rel")>] member inline _.Rel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Rel" => x)
    /// Allows the user to interact with this button.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Allows the user to interact with this button.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Allows the click event to bubble up to the parent component.
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ClickPropagation" =>>> true)
    /// Allows the click event to bubble up to the parent component.
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ClickPropagation" =>>> x)
    /// Displays a shadow.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DropShadow" =>>> true)
    /// Displays a shadow.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DropShadow" =>>> x)
    /// Shows a ripple effect when the user clicks the button.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when the user clicks the button.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Occurs when this button has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when this button has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// Represents a button for actions, links, and commands.
type MudButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    /// The icon displayed before the text.
    [<CustomOperation("StartIcon")>] member inline _.StartIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    /// The icon displayed after the text.
    [<CustomOperation("EndIcon")>] member inline _.EndIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    /// The color of icons.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The size of icons.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Size>) = render ==> ("IconSize" => x)
    /// The CSS classes applied to icons.
    [<CustomOperation("IconClass")>] member inline _.IconClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconClass" => x)
    /// The color of the button.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the button.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The display variation to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Expands the button to 100% of the container width.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FullWidth" =>>> true)
    /// Expands the button to 100% of the container width.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FullWidth" =>>> x)

/// Represents a floating action button.
type MudFabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    /// The color of the button.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the button.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The icon shown before any text.
    [<CustomOperation("StartIcon")>] member inline _.StartIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    /// The icon shown after any text.
    [<CustomOperation("EndIcon")>] member inline _.EndIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    /// The color of any icons.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The size of the icon.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// The text displayed in the button.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)

/// Represents a button consisting of an icon.
type MudIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    /// The icon to display.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the button.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the button.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The amount of negative margin applied.
    [<CustomOperation("Edge")>] member inline _.Edge ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    /// The display variation to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)

/// A container for a MudDrawer component.
type MudDrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


/// A component which defines a common structure for multiple pages.
type MudLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDrawerContainerBuilder<'FunBlazorGeneric>()


/// A base class for implementing Popover components.
type MudPopoverBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Shows the popover.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Open" =>>> true)
    /// Shows the popover.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Open" =>>> x)

/// Displays content as a window over other content.
type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPopoverBaseBuilder<'FunBlazorGeneric>()
    /// Sets the maximum height, in pixels, of this popover.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// Displays content within a MudPaper.
    [<CustomOperation("Paper")>] member inline _.Paper ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Paper" =>>> true)
    /// Displays content within a MudPaper.
    [<CustomOperation("Paper")>] member inline _.Paper ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Paper" =>>> x)
    /// Shows a drop shadow to help this popover stand out.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DropShadow" =>>> true)
    /// Shows a drop shadow to help this popover stand out.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DropShadow" =>>> x)
    /// The amount of drop shadow to apply.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Displays square borders around this popover.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Displays square borders around this popover.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Displays this popover in a fixed position, even through scrolling.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Fixed" =>>> true)
    /// Displays this popover in a fixed position, even through scrolling.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Fixed" =>>> x)
    /// The length of time that the opening transition takes to complete.
    [<CustomOperation("Duration")>] member inline _.Duration ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Duration" => x)
    /// The amount of time, in milliseconds, from opening the popover to beginning the transition. 
    [<CustomOperation("Delay'")>] member inline _.Delay' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Delay" => x)
    /// The location this popover will appear relative to its parent container.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// The direction this popover will appear relative to the Origin.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// The behavior applied when there is not enough space for this popover to be visible.
    [<CustomOperation("OverflowBehavior")>] member inline _.OverflowBehavior ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.OverflowBehavior) = render ==> ("OverflowBehavior" => x)
    /// Determines the width of this popover in relation the parent container.
    [<CustomOperation("RelativeWidth")>] member inline _.RelativeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DropdownWidth) = render ==> ("RelativeWidth" => x)

/// A base class for designing table components.
type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Forces a row being edited to be saved or canceled before a new row can be selected.
    [<CustomOperation("IsEditRowSwitchingBlocked")>] member inline _.IsEditRowSwitchingBlocked ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsEditRowSwitchingBlocked" =>>> true)
    /// Forces a row being edited to be saved or canceled before a new row can be selected.
    [<CustomOperation("IsEditRowSwitchingBlocked")>] member inline _.IsEditRowSwitchingBlocked ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsEditRowSwitchingBlocked" =>>> x)
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Uses square corners for the table.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Uses square corners for the table.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Shows borders around the table.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Shows borders around the table.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)
    /// Shows left and right borders for each table cell.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Bordered" =>>> true)
    /// Shows left and right borders for each table cell.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Bordered" =>>> x)
    /// Uses compact padding for all rows.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact padding for all rows.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// The CSS classes applied to all cells of the table.
    [<CustomOperation("CellClass")>] member inline _.CellClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CellClass" => x)
    /// Highlights rows when hovering over them.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hover" =>>> true)
    /// Highlights rows when hovering over them.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hover" =>>> x)
    /// Uses alternating colors for table rows.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Striped" =>>> true)
    /// Uses alternating colors for table rows.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Striped" =>>> x)
    /// The screen width at which this table switches to small-device mode.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// Fixes the table header in place while the table is scrolled.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FixedHeader" =>>> true)
    /// Fixes the table header in place while the table is scrolled.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FixedHeader" =>>> x)
    /// Fixes the table footer in place while the table is scrolled.
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FixedFooter" =>>> true)
    /// Fixes the table footer in place while the table is scrolled.
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FixedFooter" =>>> x)
    /// The fixed height of this table, as a CSS Value.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// The sort label shown when this table is in small-device mode and is sorting by a column.
    [<CustomOperation("SortLabel")>] member inline _.SortLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)
    /// Allows a sort direction of None in addition to Ascending and Descending.
    [<CustomOperation("AllowUnsorted")>] member inline _.AllowUnsorted ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowUnsorted" =>>> true)
    /// Allows a sort direction of None in addition to Ascending and Descending.
    [<CustomOperation("AllowUnsorted")>] member inline _.AllowUnsorted ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowUnsorted" =>>> x)
    /// The maximum rows to display per page.
    [<CustomOperation("RowsPerPage")>] member inline _.RowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    /// The maximum rows to display per page.
    [<CustomOperation("RowsPerPage'")>] member inline _.RowsPerPage' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("RowsPerPage", valueFn)
    /// Occurs when RowsPerPage has changed.
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("RowsPerPageChanged", fn)
    /// Occurs when RowsPerPage has changed.
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("RowsPerPageChanged", fn)
    /// The index of the current page.
    [<CustomOperation("CurrentPage")>] member inline _.CurrentPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    /// The index of the current page.
    [<CustomOperation("CurrentPage'")>] member inline _.CurrentPage' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("CurrentPage", valueFn)
    /// Occurs when CurrentPage has changed.
    [<CustomOperation("CurrentPageChanged")>] member inline _.CurrentPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("CurrentPageChanged", fn)
    /// Occurs when CurrentPage has changed.
    [<CustomOperation("CurrentPageChanged")>] member inline _.CurrentPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("CurrentPageChanged", fn)
    /// Allows multiple rows to be selected with checkboxes.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MultiSelection" =>>> true)
    /// Allows multiple rows to be selected with checkboxes.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MultiSelection" =>>> x)
    /// Disables the selection of rows but keep showing the selected rows.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectionChangeable" =>>> true)
    /// Disables the selection of rows but keep showing the selected rows.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectionChangeable" =>>> x)
    /// Toggles the checkbox when a row is clicked.
    [<CustomOperation("SelectOnRowClick")>] member inline _.SelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectOnRowClick" =>>> true)
    /// Toggles the checkbox when a row is clicked.
    [<CustomOperation("SelectOnRowClick")>] member inline _.SelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectOnRowClick" =>>> x)
    /// The custom content for the toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ToolBarContent", fragment)
    /// The custom content for the toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ToolBarContent", fragment { yield! fragments })
    /// The custom content for the toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// The custom content for the toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// The custom content for the toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Displays a loading animation while ServerData executes.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Loading" =>>> true)
    /// Displays a loading animation while ServerData executes.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Loading" =>>> x)
    /// The color of the MudProgressLinear while Loading is true.
    [<CustomOperation("LoadingProgressColor")>] member inline _.LoadingProgressColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingProgressColor" => x)
    /// The content of this table's header.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("HeaderContent", fragment)
    /// The content of this table's header.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("HeaderContent", fragment { yield! fragments })
    /// The content of this table's header.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderContent", html.text x)
    /// The content of this table's header.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderContent", html.text x)
    /// The content of this table's header.
    [<CustomOperation("HeaderContent")>] member inline _.HeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderContent", html.text x)
    /// Enables customized headers beyond basic header columns.
    [<CustomOperation("CustomHeader")>] member inline _.CustomHeader ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CustomHeader" =>>> true)
    /// Enables customized headers beyond basic header columns.
    [<CustomOperation("CustomHeader")>] member inline _.CustomHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CustomHeader" =>>> x)
    /// The CSS classes applied to the header.
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// The CSS styles applied to this table.
    [<CustomOperation("ContainerStyle")>] member inline _.ContainerStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContainerStyle" => x)
    /// The CSS classes applied to this table.
    [<CustomOperation("ContainerClass")>] member inline _.ContainerClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContainerClass" => x)
    /// The content of this table's footer.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("FooterContent", fragment)
    /// The content of this table's footer.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("FooterContent", fragment { yield! fragments })
    /// The content of this table's footer.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterContent", html.text x)
    /// The content of this table's footer.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterContent", html.text x)
    /// The content of this table's footer.
    [<CustomOperation("FooterContent")>] member inline _.FooterContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterContent", html.text x)
    /// Enables customized footers beyond basic footer columns.
    [<CustomOperation("CustomFooter")>] member inline _.CustomFooter ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CustomFooter" =>>> true)
    /// Enables customized footers beyond basic footer columns.
    [<CustomOperation("CustomFooter")>] member inline _.CustomFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CustomFooter" =>>> x)
    /// Add a class to the tfoot tag
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    /// Specifies formatting information for this table's columns such as size and style.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ColGroup", fragment)
    /// Specifies formatting information for this table's columns such as size and style.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ColGroup", fragment { yield! fragments })
    /// Specifies formatting information for this table's columns such as size and style.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Specifies formatting information for this table's columns such as size and style.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Specifies formatting information for this table's columns such as size and style.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColGroup", html.text x)
    /// The custom pagination content for this table.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("PagerContent", fragment)
    /// The custom pagination content for this table.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("PagerContent", fragment { yield! fragments })
    /// The custom pagination content for this table.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PagerContent", html.text x)
    /// The custom pagination content for this table.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PagerContent", html.text x)
    /// The custom pagination content for this table.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PagerContent", html.text x)
    /// Prevents rows from being edited inline.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents rows from being edited inline.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Occurs when changes to a row being edited are committed.
    [<CustomOperation("OnCommitEditClick")>] member inline _.OnCommitEditClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnCommitEditClick", fn)
    /// Occurs when changes to a row being edited are committed.
    [<CustomOperation("OnCommitEditClick")>] member inline _.OnCommitEditClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCommitEditClick", fn)
    /// Occurs when changes to a row being edited are canceled.
    [<CustomOperation("OnCancelEditClick")>] member inline _.OnCancelEditClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnCancelEditClick", fn)
    /// Occurs when changes to a row being edited are canceled.
    [<CustomOperation("OnCancelEditClick")>] member inline _.OnCancelEditClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnCancelEditClick", fn)
    /// Occurs before inline editing is enabled for a row.
    [<CustomOperation("OnPreviewEditClick")>] member inline _.OnPreviewEditClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> unit) = render ==> html.callback("OnPreviewEditClick", fn)
    /// Occurs before inline editing is enabled for a row.
    [<CustomOperation("OnPreviewEditClick")>] member inline _.OnPreviewEditClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Object -> Task<unit>) = render ==> html.callbackTask("OnPreviewEditClick", fn)
    /// The tooltip shown next to the button which commits inline edits.
    [<CustomOperation("CommitEditTooltip")>] member inline _.CommitEditTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CommitEditTooltip" => x)
    /// The tooltip shown next to the button which cancels inline edits.
    [<CustomOperation("CancelEditTooltip")>] member inline _.CancelEditTooltip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelEditTooltip" => x)
    /// The icon shown for the button which commits inline edits.
    [<CustomOperation("CommitEditIcon")>] member inline _.CommitEditIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CommitEditIcon" => x)
    /// The icon shown for the button which cancels inline edits.
    [<CustomOperation("CancelEditIcon")>] member inline _.CancelEditIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelEditIcon" => x)
    /// Shows the cancel button during inline editing.
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CanCancelEdit" =>>> true)
    /// Shows the cancel button during inline editing.
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CanCancelEdit" =>>> x)
    /// The position of the button which commits inline edits.
    [<CustomOperation("ApplyButtonPosition")>] member inline _.ApplyButtonPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableApplyButtonPosition) = render ==> ("ApplyButtonPosition" => x)
    /// The position of the button which begins inline editing.
    [<CustomOperation("EditButtonPosition")>] member inline _.EditButtonPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableEditButtonPosition) = render ==> ("EditButtonPosition" => x)
    /// The behavior which begins inline editing.
    [<CustomOperation("EditTrigger")>] member inline _.EditTrigger ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableEditTrigger) = render ==> ("EditTrigger" => x)
    /// The content of the Edit button which starts inline editing.
    [<CustomOperation("EditButtonContent")>] member inline _.EditButtonContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.EditButtonContext -> NodeRenderFragment) = render ==> html.renderFragment("EditButtonContent", fn)
    /// Occurs before inline editing begins for a row.
    [<CustomOperation("RowEditPreview")>] member inline _.RowEditPreview ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowEditPreview" => (System.Action<System.Object>fn))
    /// Occurs when changes are committed for an row being edited.
    [<CustomOperation("RowEditCommit")>] member inline _.RowEditCommit ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowEditCommit" => (System.Action<System.Object>fn))
    /// Occurs when changed are canceled for a row being edited.
    [<CustomOperation("RowEditCancel")>] member inline _.RowEditCancel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowEditCancel" => (System.Action<System.Object>fn))
    /// The total number of rows (excluding pages) when using ServerData for data.
    [<CustomOperation("TotalItems")>] member inline _.TotalItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TotalItems" => x)
    /// The CSS classes applied to each row.
    [<CustomOperation("RowClass")>] member inline _.RowClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    /// The CSS styles applied to each row.
    [<CustomOperation("RowStyle")>] member inline _.RowStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    /// Uses virtualization to display large amounts of items efficiently.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Virtualize" =>>> true)
    /// Uses virtualization to display large amounts of items efficiently.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Virtualize" =>>> x)
    /// The number of additional items to render outside of view when Virtualize is true.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// The height of each row, in pixels, when Virtualize is true.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)

/// A sortable, filterable table with multiselection and pagination.
type MudTableBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTableBaseBuilder<'FunBlazorGeneric>()
    /// The columns for each row in this table.
    [<CustomOperation("RowTemplate")>] member inline _.RowTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("RowTemplate", fn)
    /// The optional nested content underneath each row.
    [<CustomOperation("ChildRowContent")>] member inline _.ChildRowContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildRowContent", fn)
    /// The columns for each row when a row is being edited.
    [<CustomOperation("RowEditingTemplate")>] member inline _.RowEditingTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("RowEditingTemplate", fn)
    /// The function which determines if a row can be edited.
    [<CustomOperation("RowEditableFunc")>] member inline _.RowEditableFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowEditableFunc" => (System.Func<'T, System.Boolean>fn))
    /// The columns for each row in this table.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("Columns", fn)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NoRecordsContent", fragment { yield! fragments })
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// The content shown while table data is loading and the table has no rows.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LoadingContent", fragment)
    /// The content shown while table data is loading and the table has no rows.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LoadingContent", fragment { yield! fragments })
    /// The content shown while table data is loading and the table has no rows.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// The content shown while table data is loading and the table has no rows.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// The content shown while table data is loading and the table has no rows.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// Shows a horizontal scroll bar if the content exceeds the maximum width.
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HorizontalScrollbar" =>>> true)
    /// Shows a horizontal scroll bar if the content exceeds the maximum width.
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HorizontalScrollbar" =>>> x)
    /// The data to display.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    /// The function which determines whether an item should be displayed.
    [<CustomOperation("Filter")>] member inline _.Filter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Filter" => (System.Func<'T, System.Boolean>fn))
    /// Occurs when a row has been clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableRowClickEventArgs<'T> -> unit) = render ==> html.callback("OnRowClick", fn)
    /// Occurs when a row has been clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableRowClickEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)
    /// Occurs when the pointer hovers over a row.
    [<CustomOperation("OnRowMouseEnter")>] member inline _.OnRowMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableRowHoverEventArgs<'T> -> unit) = render ==> html.callback("OnRowMouseEnter", fn)
    /// Occurs when the pointer hovers over a row.
    [<CustomOperation("OnRowMouseEnter")>] member inline _.OnRowMouseEnter ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableRowHoverEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("OnRowMouseEnter", fn)
    /// Occurs when the pointer is no longer hovering over a row.
    [<CustomOperation("OnRowMouseLeave")>] member inline _.OnRowMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableRowHoverEventArgs<'T> -> unit) = render ==> html.callback("OnRowMouseLeave", fn)
    /// Occurs when the pointer is no longer hovering over a row.
    [<CustomOperation("OnRowMouseLeave")>] member inline _.OnRowMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableRowHoverEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("OnRowMouseLeave", fn)
    /// The function which returns CSS classes for a row.
    [<CustomOperation("RowClassFunc")>] member inline _.RowClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// The function which returns CSS styles for a row.
    [<CustomOperation("RowStyleFunc")>] member inline _.RowStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// The currently selected item when MultiSelection is false.
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    /// The currently selected item when MultiSelection is false.
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Occurs when SelectedItem has changed.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Occurs when SelectedItem has changed.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// The currently selected item when MultiSelection is true.
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    /// The currently selected item when MultiSelection is true.
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    /// The comparer used to determine selected items.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// Occurs when SelectedItems has changed.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.HashSet<'T> -> unit) = render ==> html.callback("SelectedItemsChanged", fn)
    /// Occurs when SelectedItems has changed.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.HashSet<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedItemsChanged", fn)
    /// Defines how rows are grouped together.
    [<CustomOperation("GroupBy")>] member inline _.GroupBy ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableGroupDefinition<'T>) = render ==> ("GroupBy" => x)
    /// The custom CSS classes to apply to the table.
    [<CustomOperation("TableClass")>] member inline _.TableClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TableClass" => x)
    /// The content for the header of each group when GroupBy is set.
    [<CustomOperation("GroupHeaderTemplate")>] member inline _.GroupHeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupHeaderTemplate", fn)
    /// The custom CSS classes to apply to each group header row.
    [<CustomOperation("GroupHeaderClass")>] member inline _.GroupHeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupHeaderClass" => x)
    /// The custom CSS styles to apply to each group header row.
    [<CustomOperation("GroupHeaderStyle")>] member inline _.GroupHeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupHeaderStyle" => x)
    /// The custom CSS classes to apply to each group footer row.
    [<CustomOperation("GroupFooterClass")>] member inline _.GroupFooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterClass" => x)
    /// The custom CSS styles to apply to each group footer row.
    [<CustomOperation("GroupFooterStyle")>] member inline _.GroupFooterStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupFooterStyle" => x)
    /// The content for the footer of each group when GroupBy is set.
    [<CustomOperation("GroupFooterTemplate")>] member inline _.GroupFooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupFooterTemplate", fn)
    /// Gets the sorted and paginated data for the table.
    [<CustomOperation("ServerData")>] member inline _.ServerData ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<MudBlazor.TableState, System.Threading.CancellationToken, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>fn))

/// A set of views organized into one or more MudTabPanel components.
type MudTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Persists the content of tabs when they are not visible.
    [<CustomOperation("KeepPanelsAlive")>] member inline _.KeepPanelsAlive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("KeepPanelsAlive" =>>> true)
    /// Persists the content of tabs when they are not visible.
    [<CustomOperation("KeepPanelsAlive")>] member inline _.KeepPanelsAlive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("KeepPanelsAlive" =>>> x)
    /// Uses rounded corners on the tab's edges.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Rounded" =>>> true)
    /// Uses rounded corners on the tab's edges.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Rounded" =>>> x)
    /// Shows a border between the tab content and tab header.
    [<CustomOperation("Border")>] member inline _.Border ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Border" =>>> true)
    /// Shows a border between the tab content and tab header.
    [<CustomOperation("Border")>] member inline _.Border ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Border" =>>> x)
    /// Shows an outline around the tab header.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Shows an outline around the tab header.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)
    /// Centers tabs horizontally in the tab header.
    [<CustomOperation("Centered")>] member inline _.Centered ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Centered" =>>> true)
    /// Centers tabs horizontally in the tab header.
    [<CustomOperation("Centered")>] member inline _.Centered ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Centered" =>>> x)
    /// Hides the slider underneath the tab header.
    [<CustomOperation("HideSlider")>] member inline _.HideSlider ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideSlider" =>>> true)
    /// Hides the slider underneath the tab header.
    [<CustomOperation("HideSlider")>] member inline _.HideSlider ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideSlider" =>>> x)
    /// The icon for scrolling to the previous page of tabs.
    [<CustomOperation("PrevIcon")>] member inline _.PrevIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PrevIcon" => x)
    /// The icon for scrolling to the next page of tabs.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// Shows the scroll buttons even if all tabs are visible.
    [<CustomOperation("AlwaysShowScrollButtons")>] member inline _.AlwaysShowScrollButtons ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AlwaysShowScrollButtons" =>>> true)
    /// Shows the scroll buttons even if all tabs are visible.
    [<CustomOperation("AlwaysShowScrollButtons")>] member inline _.AlwaysShowScrollButtons ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AlwaysShowScrollButtons" =>>> x)
    /// The maximum height for this component, in pixels.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// The minimum width of each tab panel.
    [<CustomOperation("MinimumTabWidth")>] member inline _.MinimumTabWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinimumTabWidth" => x)
    /// The location of the tab header.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("Position" => x)
    /// The color of the tab header.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The color of the tab slider.
    [<CustomOperation("SliderColor")>] member inline _.SliderColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("SliderColor" => x)
    /// The color of each tab panel's icon.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The color of the scroll icon buttons.
    [<CustomOperation("ScrollIconColor")>] member inline _.ScrollIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ScrollIconColor" => x)
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Applies the Elevation, Rounded and Outlined effects to the tab panel.
    [<CustomOperation("ApplyEffectsToContainer")>] member inline _.ApplyEffectsToContainer ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ApplyEffectsToContainer" =>>> true)
    /// Applies the Elevation, Rounded and Outlined effects to the tab panel.
    [<CustomOperation("ApplyEffectsToContainer")>] member inline _.ApplyEffectsToContainer ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ApplyEffectsToContainer" =>>> x)
    /// Shows a ripple effect when a tab is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when a tab is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Shows an animated line which slides to the selected tab.
    [<CustomOperation("SliderAnimation")>] member inline _.SliderAnimation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SliderAnimation" =>>> true)
    /// Shows an animated line which slides to the selected tab.
    [<CustomOperation("SliderAnimation")>] member inline _.SliderAnimation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SliderAnimation" =>>> x)
    /// This fragment is placed between tabHeader and panels. 
    /// It can be used to display additional content like an address line in a browser.
    /// The active tab will be the content of this RenderFragement
    [<CustomOperation("PrePanelContent")>] member inline _.PrePanelContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("PrePanelContent", fn)
    /// The CSS classes applied to tab panels.
    [<CustomOperation("TabPanelClass")>] member inline _.TabPanelClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabPanelClass" => x)
    /// The CSS classes applied to the tab header.
    [<CustomOperation("TabHeaderClass")>] member inline _.TabHeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TabHeaderClass" => x)
    /// The CSS classes applied to the currently selected tab.
    [<CustomOperation("ActiveTabClass")>] member inline _.ActiveTabClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveTabClass" => x)
    /// The CSS classes applied to all tab panels.
    [<CustomOperation("PanelClass")>] member inline _.PanelClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PanelClass" => x)
    /// The index of the currently selected tab panel.
    [<CustomOperation("ActivePanelIndex")>] member inline _.ActivePanelIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ActivePanelIndex" => x)
    /// The index of the currently selected tab panel.
    [<CustomOperation("ActivePanelIndex'")>] member inline _.ActivePanelIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("ActivePanelIndex", valueFn)
    /// Occurs when ActivePanelIndex has changed.
    [<CustomOperation("ActivePanelIndexChanged")>] member inline _.ActivePanelIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("ActivePanelIndexChanged", fn)
    /// Occurs when ActivePanelIndex has changed.
    [<CustomOperation("ActivePanelIndexChanged")>] member inline _.ActivePanelIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ActivePanelIndexChanged", fn)
    /// The custom content added before or after the list of tabs.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudTabs -> NodeRenderFragment) = render ==> html.renderFragment("Header", fn)
    /// The location of custom header content provided in Header.
    [<CustomOperation("HeaderPosition")>] member inline _.HeaderPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TabHeaderPosition) = render ==> ("HeaderPosition" => x)
    /// Custom content added before or after each tab panel.
    [<CustomOperation("TabPanelHeader")>] member inline _.TabPanelHeader ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudTabPanel -> NodeRenderFragment) = render ==> html.renderFragment("TabPanelHeader", fn)
    /// The location of custom tab panel content provided in TabPanelHeader.
    [<CustomOperation("TabPanelHeaderPosition")>] member inline _.TabPanelHeaderPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TabHeaderPosition) = render ==> ("TabPanelHeaderPosition" => x)
    /// Occurs before a panel is activated.
    [<CustomOperation("OnPreviewInteraction")>] member inline _.OnPreviewInteraction ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnPreviewInteraction" => (System.Func<MudBlazor.TabInteractionEventArgs, System.Threading.Tasks.Task>fn))
    /// Sort tab labels lexicographically by Text or SortKey. Ignored if SortComparer is set.
    [<CustomOperation("SortDirection")>] member inline _.SortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("SortDirection" => x)
    /// Specify a custom Comparer to sort tabs. When set, SortDirection is not used.
    [<CustomOperation("SortComparer")>] member inline _.SortComparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IComparer<MudBlazor.MudTabPanel>) = render ==> ("SortComparer" => x)

/// A tab component where the tabs are controlled dynamically, similar to browser tabs.
type MudDynamicTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTabsBuilder<'FunBlazorGeneric>()
    /// The icon for the add button.
    [<CustomOperation("AddTabIcon")>] member inline _.AddTabIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddTabIcon" => x)
    /// The icon for the close button.
    [<CustomOperation("CloseTabIcon")>] member inline _.CloseTabIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseTabIcon" => x)
    /// Occurs when the "Add" button has been clicked.
    [<CustomOperation("AddTab")>] member inline _.AddTab ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("AddTab", fn)
    /// Occurs when the "Add" button has been clicked.
    [<CustomOperation("AddTab")>] member inline _.AddTab ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("AddTab", fn)
    /// Occurs when a tab has been closed.
    [<CustomOperation("CloseTab")>] member inline _.CloseTab ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudTabPanel -> unit) = render ==> html.callback("CloseTab", fn)
    /// Occurs when a tab has been closed.
    [<CustomOperation("CloseTab")>] member inline _.CloseTab ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudTabPanel -> Task<unit>) = render ==> html.callbackTask("CloseTab", fn)
    /// The CSS classes applied to the "Add" button.
    [<CustomOperation("AddIconClass")>] member inline _.AddIconClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddIconClass" => x)
    /// The CSS styles applied to the "Add" button.
    [<CustomOperation("AddIconStyle")>] member inline _.AddIconStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddIconStyle" => x)
    /// The CSS classes applied to the "Close" button.
    [<CustomOperation("CloseIconClass")>] member inline _.CloseIconClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconClass" => x)
    /// The CSS styles applied to the "Close" button.
    [<CustomOperation("CloseIconStyle")>] member inline _.CloseIconStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconStyle" => x)
    /// The text shown when the user hovers over the "Add" button.
    [<CustomOperation("AddIconToolTip")>] member inline _.AddIconToolTip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AddIconToolTip" => x)
    /// The text shown when the user hovers over the "Close" button.
    [<CustomOperation("CloseIconToolTip")>] member inline _.CloseIconToolTip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIconToolTip" => x)

/// Represents a base class for designing components which contain items.
type MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The index of the currently selected item.
    [<CustomOperation("SelectedIndex")>] member inline _.SelectedIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedIndex" => x)
    /// The index of the currently selected item.
    [<CustomOperation("SelectedIndex'")>] member inline _.SelectedIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedIndex", valueFn)
    /// Occurs when the SelectedIndex has changed.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("SelectedIndexChanged", fn)
    /// Occurs when the SelectedIndex has changed.
    [<CustomOperation("SelectedIndexChanged")>] member inline _.SelectedIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedIndexChanged", fn)

/// Represents a base class for designing components with bindable items.
type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>()
    /// The alternate source of items if Items is not set.
    [<CustomOperation("ItemsSource")>] member inline _.ItemsSource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TData>) = render ==> ("ItemsSource" => x)
    /// The template used to display each item.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'TData -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)

/// Represents a set of slides which transition after a delay.
type MudCarouselBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudCarouselItem, 'TData>()
    /// Displays "Next" and "Previous" arrows.
    [<CustomOperation("ShowArrows")>] member inline _.ShowArrows ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowArrows" =>>> true)
    /// Displays "Next" and "Previous" arrows.
    [<CustomOperation("ShowArrows")>] member inline _.ShowArrows ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowArrows" =>>> x)
    /// The position where the arrows are displayed, if ShowArrows is true.
    [<CustomOperation("ArrowsPosition")>] member inline _.ArrowsPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("ArrowsPosition" => x)
    /// Displays a bullet for each MudCarouselItem.
    [<CustomOperation("ShowBullets")>] member inline _.ShowBullets ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowBullets" =>>> true)
    /// Displays a bullet for each MudCarouselItem.
    [<CustomOperation("ShowBullets")>] member inline _.ShowBullets ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowBullets" =>>> x)
    /// The location of the bullets when ShowBullets is true.
    [<CustomOperation("BulletsPosition")>] member inline _.BulletsPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Position) = render ==> ("BulletsPosition" => x)
    /// The color of bullets when ShowBullets is true.
    [<CustomOperation("BulletsColor")>] member inline _.BulletsColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("BulletsColor" => x)
    /// Automatically cycles items based on AutoCycleTime.
    [<CustomOperation("AutoCycle")>] member inline _.AutoCycle ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoCycle" =>>> true)
    /// Automatically cycles items based on AutoCycleTime.
    [<CustomOperation("AutoCycle")>] member inline _.AutoCycle ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoCycle" =>>> x)
    /// The delay before displaying the next MudCarouselItem when AutoCycle is true.
    [<CustomOperation("AutoCycleTime")>] member inline _.AutoCycleTime ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("AutoCycleTime" => x)
    /// The custom CSS classes for the "Next" and "Previous" icons when ShowArrows is true.
    [<CustomOperation("NavigationButtonsClass")>] member inline _.NavigationButtonsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NavigationButtonsClass" => x)
    /// The custom CSS classes for bullets when ShowBullets is true.
    [<CustomOperation("BulletsClass")>] member inline _.BulletsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BulletsClass" => x)
    /// The "Previous" button icon when ShowBullets is true and no PreviousButtonTemplate is set.
    [<CustomOperation("PreviousIcon")>] member inline _.PreviousIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviousIcon" => x)
    /// The icon displayed for the current MudCarouselItem when no BulletTemplate is set.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The icon displayed for unselected MudCarouselItems when no BulletTemplate is set.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// The "Next" button icon when ShowBullets is true and no NextButtonTemplate is set.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// The custom template for the "Next" button.
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NextButtonTemplate", fragment)
    /// The custom template for the "Next" button.
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NextButtonTemplate", fragment { yield! fragments })
    /// The custom template for the "Next" button.
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    /// The custom template for the "Next" button.
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    /// The custom template for the "Next" button.
    [<CustomOperation("NextButtonTemplate")>] member inline _.NextButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NextButtonTemplate", html.text x)
    /// The custom template for the "Previous" button.
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("PreviousButtonTemplate", fragment)
    /// The custom template for the "Previous" button.
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("PreviousButtonTemplate", fragment { yield! fragments })
    /// The custom template for the "Previous" button.
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    /// The custom template for the "Previous" button.
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    /// The custom template for the "Previous" button.
    [<CustomOperation("PreviousButtonTemplate")>] member inline _.PreviousButtonTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PreviousButtonTemplate", html.text x)
    /// The custom template for bullets.
    [<CustomOperation("BulletTemplate")>] member inline _.BulletTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("BulletTemplate", fn)
    /// Allows swipe gestures for touch devices.
    [<CustomOperation("EnableSwipeGesture")>] member inline _.EnableSwipeGesture ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("EnableSwipeGesture" =>>> true)
    /// Allows swipe gestures for touch devices.
    [<CustomOperation("EnableSwipeGesture")>] member inline _.EnableSwipeGesture ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("EnableSwipeGesture" =>>> x)

/// Displays items in chronological order.
type MudTimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudTimelineItem>()
    /// The orientation of the timeline and its items.
    [<CustomOperation("TimelineOrientation")>] member inline _.TimelineOrientation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimelineOrientation) = render ==> ("TimelineOrientation" => x)
    /// The position the timeline and how its items are displayed.
    [<CustomOperation("TimelinePosition")>] member inline _.TimelinePosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimelinePosition) = render ==> ("TimelinePosition" => x)
    /// The position of each item's dot relative to its text.
    [<CustomOperation("TimelineAlign")>] member inline _.TimelineAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimelineAlign) = render ==> ("TimelineAlign" => x)
    /// Reverses the order of items when TimelinePosition is Alternate.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Reverse" =>>> true)
    /// Reverses the order of items when TimelinePosition is Alternate.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Reverse" =>>> x)
    /// Enables modifiers for items, such as adding a caret for a MudCard.
    [<CustomOperation("Modifiers")>] member inline _.Modifiers ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Modifiers" =>>> true)
    /// Enables modifiers for items, such as adding a caret for a MudCard.
    [<CustomOperation("Modifiers")>] member inline _.Modifiers ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Modifiers" =>>> x)

/// Represents a base class for designing form input components.
type MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Requires an input value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Requires an input value.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// The text displayed during validation if no input was given.
    [<CustomOperation("RequiredError")>] member inline _.RequiredError ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RequiredError" => x)
    /// The text displayed if the Error property is true.
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// Displays an error.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Error" =>>> true)
    /// Displays an error.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Error" =>>> x)
    /// The ID of the error description element, for use by aria-describedby when Error is true.
    [<CustomOperation("ErrorId")>] member inline _.ErrorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorId" => x)
    /// The type converter for this input.
    [<CustomOperation("Converter")>] member inline _.Converter ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Converter<'T, 'U>) = render ==> ("Converter" => x)
    /// The culture used to format and interpret values such as dates and currency.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// The function used to detect problems with the input.
    [<CustomOperation("Validation")>] member inline _.Validation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Validation" => x)
    /// The model field containing validation attributes.
    [<CustomOperation("For'")>] member inline _.For' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T>>) = render ==> ("For" => x)

/// Represents a base class for designing form input components.
type MudBaseInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    /// Allows the component to receive input.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Allows the component to receive input.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents the input from being changed by the user.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents the input from being changed by the user.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Fills the full width of the parent container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FullWidth" =>>> true)
    /// Fills the full width of the parent container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FullWidth" =>>> x)
    /// Changes the Value as soon as input is received.
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Immediate" =>>> true)
    /// Changes the Value as soon as input is received.
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Immediate" =>>> x)
    /// Displays an underline for the input.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Underline" =>>> true)
    /// Displays an underline for the input.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Underline" =>>> x)
    /// The ID of the helper element, for use by aria-describedby.
    [<CustomOperation("HelperId")>] member inline _.HelperId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperId" => x)
    /// The text displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// Displays the HelperText only when this input has focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HelperTextOnFocus" =>>> true)
    /// Displays the HelperText only when this input has focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HelperTextOnFocus" =>>> x)
    /// The icon displayed for the adornment.
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    /// The text displayed for the adornment.
    [<CustomOperation("AdornmentText")>] member inline _.AdornmentText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    /// The location of the adornment icon or text.
    [<CustomOperation("Adornment")>] member inline _.Adornment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    /// Limits validation to when the user changes the Value.
    [<CustomOperation("OnlyValidateIfDirty")>] member inline _.OnlyValidateIfDirty ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OnlyValidateIfDirty" =>>> true)
    /// Limits validation to when the user changes the Value.
    [<CustomOperation("OnlyValidateIfDirty")>] member inline _.OnlyValidateIfDirty ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OnlyValidateIfDirty" =>>> x)
    /// The color of AdornmentText or AdornmentIcon.
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    /// The aria-label for the adornment.
    [<CustomOperation("AdornmentAriaLabel")>] member inline _.AdornmentAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentAriaLabel" => x)
    /// The size of the icon.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// Occurs when the adornment text or icon has been clicked.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnAdornmentClick", fn)
    /// Occurs when the adornment text or icon has been clicked.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnAdornmentClick", fn)
    /// The appearance variation to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// The amount of vertical spacing for this input.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// Typography for the input text.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    /// The text displayed in the input if no Value is specified.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// The optional character count and stop count.
    [<CustomOperation("Counter")>] member inline _.Counter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Counter" => x)
    /// The maximum number of characters allowed.
    [<CustomOperation("MaxLength")>] member inline _.MaxLength ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLength" => x)
    /// The label for this input.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Automatically receives focus.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoFocus" =>>> true)
    /// Automatically receives focus.
    [<CustomOperation("AutoFocus")>] member inline _.AutoFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoFocus" =>>> x)
    /// A multiline input (textarea) will be shown, if set to more than one line.
    ///             
    [<CustomOperation("Lines")>] member inline _.Lines ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Lines" => x)
    /// The text displayed in the input.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The text displayed in the input.
    [<CustomOperation("Text'")>] member inline _.Text' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Text", valueFn)
    /// Prevents the text from being updated via a bound value.
    [<CustomOperation("TextUpdateSuppression")>] member inline _.TextUpdateSuppression ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TextUpdateSuppression" =>>> true)
    /// Prevents the text from being updated via a bound value.
    [<CustomOperation("TextUpdateSuppression")>] member inline _.TextUpdateSuppression ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TextUpdateSuppression" =>>> x)
    /// The type of input expected.
    [<CustomOperation("InputMode")>] member inline _.InputMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    /// The regular expression used to validate the Value property.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)
    /// Shows the label inside the input if no Value is specified.
    [<CustomOperation("ShrinkLabel")>] member inline _.ShrinkLabel ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShrinkLabel" =>>> true)
    /// Shows the label inside the input if no Value is specified.
    [<CustomOperation("ShrinkLabel")>] member inline _.ShrinkLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShrinkLabel" =>>> x)
    /// Occurs when the Text property has changed.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("TextChanged", fn)
    /// Occurs when the Text property has changed.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("TextChanged", fn)
    /// Occurs when the input loses focus.
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> unit) = render ==> html.callback("OnBlur", fn)
    /// Occurs when the input loses focus.
    [<CustomOperation("OnBlur")>] member inline _.OnBlur ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.FocusEventArgs -> Task<unit>) = render ==> html.callbackTask("OnBlur", fn)
    /// Occurs when the internal text value has changed.
    [<CustomOperation("OnInternalInputChanged")>] member inline _.OnInternalInputChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> unit) = render ==> html.callback("OnInternalInputChanged", fn)
    /// Occurs when the internal text value has changed.
    [<CustomOperation("OnInternalInputChanged")>] member inline _.OnInternalInputChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.ChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnInternalInputChanged", fn)
    /// Occurs when a key has been pressed down.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyDown", fn)
    /// Occurs when a key has been pressed down.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyDown", fn)
    /// Allows the default key-down action to occur.
    [<CustomOperation("KeyDownPreventDefault")>] member inline _.KeyDownPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("KeyDownPreventDefault" =>>> true)
    /// Allows the default key-down action to occur.
    [<CustomOperation("KeyDownPreventDefault")>] member inline _.KeyDownPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("KeyDownPreventDefault" =>>> x)
    /// Occurs when a pressed key has been released.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyUp", fn)
    /// Occurs when a pressed key has been released.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyUp", fn)
    /// Prevents the default key-up action.
    [<CustomOperation("KeyUpPreventDefault")>] member inline _.KeyUpPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("KeyUpPreventDefault" =>>> true)
    /// Prevents the default key-up action.
    [<CustomOperation("KeyUpPreventDefault")>] member inline _.KeyUpPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("KeyUpPreventDefault" =>>> x)
    /// Occurs when the Value property has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Occurs when the Value property has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// The value for this input.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The value for this input.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// The format applied to values.
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)
    /// The ID of the input element.
    [<CustomOperation("InputId")>] member inline _.InputId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputId" => x)

/// Represents a component with simple and flexible type-ahead functionality.
type MudAutocompleteBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// Input's classnames, separated by space.
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// The CSS classes applied to the popover.
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    /// The CSS classes applied to the internal list.
    [<CustomOperation("ListClass")>] member inline _.ListClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    /// The CSS classes applied to internal list items.
    [<CustomOperation("ListItemClass")>] member inline _.ListItemClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListItemClass" => x)
    /// The location where the popover will open from.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// The transform origin point for the popover.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// The "open" Autocomplete icon.
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    /// The "close" Autocomplete icon.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// The maximum height, in pixels, of the Autocomplete when it is open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    /// The function used to get the display text for each item.
    [<CustomOperation("ToStringFunc")>] member inline _.ToStringFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    /// Shows the progress indicator during searches.
    [<CustomOperation("ShowProgressIndicator")>] member inline _.ShowProgressIndicator ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowProgressIndicator" =>>> true)
    /// Shows the progress indicator during searches.
    [<CustomOperation("ShowProgressIndicator")>] member inline _.ShowProgressIndicator ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowProgressIndicator" =>>> x)
    /// The color of the progress indicator.
    [<CustomOperation("ProgressIndicatorColor")>] member inline _.ProgressIndicatorColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ProgressIndicatorColor" => x)
    /// The function used to search for items.
    [<CustomOperation("SearchFunc")>] member inline _.SearchFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SearchFunc" => (System.Func<System.String, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>fn))
    /// The maximum number of items to display.
    [<CustomOperation("MaxItems")>] member inline _.MaxItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxItems" => x)
    /// The minimum number of characters typed to initiate a search.
    [<CustomOperation("MinCharacters")>] member inline _.MinCharacters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinCharacters" => x)
    /// Reset the selected value if the user deletes the text.
    [<CustomOperation("ResetValueOnEmptyText")>] member inline _.ResetValueOnEmptyText ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ResetValueOnEmptyText" =>>> true)
    /// Reset the selected value if the user deletes the text.
    [<CustomOperation("ResetValueOnEmptyText")>] member inline _.ResetValueOnEmptyText ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ResetValueOnEmptyText" =>>> x)
    /// Highlights the text when the component receives focus.
    [<CustomOperation("SelectOnActivation")>] member inline _.SelectOnActivation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectOnActivation" =>>> true)
    /// Highlights the text when the component receives focus.
    [<CustomOperation("SelectOnActivation")>] member inline _.SelectOnActivation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectOnActivation" =>>> x)
    /// Selects items without resetting the Value.
    [<CustomOperation("Strict")>] member inline _.Strict ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Strict" =>>> true)
    /// Selects items without resetting the Value.
    [<CustomOperation("Strict")>] member inline _.Strict ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Strict" =>>> x)
    /// The debounce interval, in milliseconds.
    [<CustomOperation("DebounceInterval")>] member inline _.DebounceInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DebounceInterval" => x)
    /// The custom template used to display unselected items.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// The custom template used to display selected items.
    [<CustomOperation("ItemSelectedTemplate")>] member inline _.ItemSelectedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemSelectedTemplate", fn)
    /// The custom template used to display disabled items.
    [<CustomOperation("ItemDisabledTemplate")>] member inline _.ItemDisabledTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemDisabledTemplate", fn)
    /// The custom template used when the number of items returned by SearchFunc is more than the value of the MaxItems property.
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("MoreItemsTemplate", fragment)
    /// The custom template used when the number of items returned by SearchFunc is more than the value of the MaxItems property.
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("MoreItemsTemplate", fragment { yield! fragments })
    /// The custom template used when the number of items returned by SearchFunc is more than the value of the MaxItems property.
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MoreItemsTemplate", html.text x)
    /// The custom template used when the number of items returned by SearchFunc is more than the value of the MaxItems property.
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MoreItemsTemplate", html.text x)
    /// The custom template used when the number of items returned by SearchFunc is more than the value of the MaxItems property.
    [<CustomOperation("MoreItemsTemplate")>] member inline _.MoreItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MoreItemsTemplate", html.text x)
    /// The custom template used when no items are returned by SearchFunc.
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NoItemsTemplate", fragment)
    /// The custom template used when no items are returned by SearchFunc.
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NoItemsTemplate", fragment { yield! fragments })
    /// The custom template used when no items are returned by SearchFunc.
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoItemsTemplate", html.text x)
    /// The custom template used when no items are returned by SearchFunc.
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoItemsTemplate", html.text x)
    /// The custom template used when no items are returned by SearchFunc.
    [<CustomOperation("NoItemsTemplate")>] member inline _.NoItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoItemsTemplate", html.text x)
    /// The custom template shown above the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("BeforeItemsTemplate", fragment)
    /// The custom template shown above the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("BeforeItemsTemplate", fragment { yield! fragments })
    /// The custom template shown above the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("BeforeItemsTemplate", html.text x)
    /// The custom template shown above the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("BeforeItemsTemplate", html.text x)
    /// The custom template shown above the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("BeforeItemsTemplate")>] member inline _.BeforeItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("BeforeItemsTemplate", html.text x)
    /// The custom template shown below the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("AfterItemsTemplate", fragment)
    /// The custom template shown below the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("AfterItemsTemplate", fragment { yield! fragments })
    /// The custom template shown below the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AfterItemsTemplate", html.text x)
    /// The custom template shown below the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AfterItemsTemplate", html.text x)
    /// The custom template shown below the list of items, if SearchFunc returns items to display.  Otherwise, the fragment is hidden.
    [<CustomOperation("AfterItemsTemplate")>] member inline _.AfterItemsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AfterItemsTemplate", html.text x)
    /// The custom template used for the progress indicator when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ProgressIndicatorTemplate", fragment)
    /// The custom template used for the progress indicator when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ProgressIndicatorTemplate", fragment { yield! fragments })
    /// The custom template used for the progress indicator when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ProgressIndicatorTemplate", html.text x)
    /// The custom template used for the progress indicator when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ProgressIndicatorTemplate", html.text x)
    /// The custom template used for the progress indicator when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorTemplate")>] member inline _.ProgressIndicatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ProgressIndicatorTemplate", html.text x)
    /// The custom template used for the progress indicator inside the popover when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", fragment)
    /// The custom template used for the progress indicator inside the popover when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", fragment { yield! fragments })
    /// The custom template used for the progress indicator inside the popover when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", html.text x)
    /// The custom template used for the progress indicator inside the popover when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", html.text x)
    /// The custom template used for the progress indicator inside the popover when ShowProgressIndicator is true.
    [<CustomOperation("ProgressIndicatorInPopoverTemplate")>] member inline _.ProgressIndicatorInPopoverTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ProgressIndicatorInPopoverTemplate", html.text x)
    /// Prevents interaction with background elements while this list is open.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Modal" =>>> true)
    /// Prevents interaction with background elements while this list is open.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Modal" =>>> x)
    /// Determines the width of this Popover dropdown in relation to the parent container.
    [<CustomOperation("RelativeWidth")>] member inline _.RelativeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DropdownWidth) = render ==> ("RelativeWidth" => x)
    /// Overrides the Text property when an item is selected.
    [<CustomOperation("CoerceText")>] member inline _.CoerceText ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CoerceText" =>>> true)
    /// Overrides the Text property when an item is selected.
    [<CustomOperation("CoerceText")>] member inline _.CoerceText ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CoerceText" =>>> x)
    /// Sets the Value property even if no match is found by SearchFunc.
    [<CustomOperation("CoerceValue")>] member inline _.CoerceValue ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CoerceValue" =>>> true)
    /// Sets the Value property even if no match is found by SearchFunc.
    [<CustomOperation("CoerceValue")>] member inline _.CoerceValue ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CoerceValue" =>>> x)
    /// The behavior of the dropdown popover menu
    [<CustomOperation("DropdownSettings")>] member inline _.DropdownSettings ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DropdownSettings) = render ==> ("DropdownSettings" => x)
    /// The function used to determine if an item should be disabled.
    [<CustomOperation("ItemDisabledFunc")>] member inline _.ItemDisabledFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemDisabledFunc" => (System.Func<'T, System.Boolean>fn))
    /// Occurs when the Open property has changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OpenChanged", fn)
    /// Occurs when the Open property has changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenChanged", fn)
    /// Updates the Value to the currently selected item when pressing the Tab key.
    [<CustomOperation("SelectValueOnTab")>] member inline _.SelectValueOnTab ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectValueOnTab" =>>> true)
    /// Updates the Value to the currently selected item when pressing the Tab key.
    [<CustomOperation("SelectValueOnTab")>] member inline _.SelectValueOnTab ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectValueOnTab" =>>> x)
    /// Additionally, opens the list when focus is received on the input element; otherwise only opens on click.
    [<CustomOperation("OpenOnFocus")>] member inline _.OpenOnFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OpenOnFocus" =>>> true)
    /// Additionally, opens the list when focus is received on the input element; otherwise only opens on click.
    [<CustomOperation("OpenOnFocus")>] member inline _.OpenOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OpenOnFocus" =>>> x)
    /// Displays the Clear icon button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clearable" =>>> true)
    /// Displays the Clear icon button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" =>>> x)
    /// Custom clear icon when Clearable is enabled.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    /// Occurs when the Clear button has been clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Occurs when the Clear button has been clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// Occurs when the number of items returned by SearchFunc has changed.
    [<CustomOperation("ReturnedItemsCountChanged")>] member inline _.ReturnedItemsCountChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("ReturnedItemsCountChanged", fn)
    /// Occurs when the number of items returned by SearchFunc has changed.
    [<CustomOperation("ReturnedItemsCountChanged")>] member inline _.ReturnedItemsCountChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ReturnedItemsCountChanged", fn)
    /// Prevents scrolling while the dropdown is open.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("LockScroll" =>>> true)
    /// Prevents scrolling while the dropdown is open.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("LockScroll" =>>> x)

/// A base class for designing input components which update after a delay.
type MudDebouncedInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// The number of milliseconds to wait before updating the Text value.
    [<CustomOperation("DebounceInterval")>] member inline _.DebounceInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("DebounceInterval" => x)
    /// Occurs when the DebounceInterval has elapsed.
    [<CustomOperation("OnDebounceIntervalElapsed")>] member inline _.OnDebounceIntervalElapsed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("OnDebounceIntervalElapsed", fn)
    /// Occurs when the DebounceInterval has elapsed.
    [<CustomOperation("OnDebounceIntervalElapsed")>] member inline _.OnDebounceIntervalElapsed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("OnDebounceIntervalElapsed", fn)

/// A field for numeric values from users. 
type MudNumericFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    /// Shows a button to clear the value.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clearable" =>>> true)
    /// Shows a button to clear the value.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" =>>> x)
    /// The icon of the clear button when Clearable is true.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    /// Reverses the mouse wheel direction.
    [<CustomOperation("InvertMouseWheel")>] member inline _.InvertMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("InvertMouseWheel" =>>> true)
    /// Reverses the mouse wheel direction.
    [<CustomOperation("InvertMouseWheel")>] member inline _.InvertMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("InvertMouseWheel" =>>> x)
    /// The minimum allowed value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    /// The maximum allowed value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    /// The amount added or subtracted when changing values.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    /// Hides the up and down buttons.
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideSpinButtons" =>>> true)
    /// Hides the up and down buttons.
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideSpinButtons" =>>> x)
    /// The type of value collected by this field.
    [<CustomOperation("InputMode")>] member inline _.InputMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputMode) = render ==> ("InputMode" => x)
    /// The regular expression used to constrain values.
    [<CustomOperation("Pattern")>] member inline _.Pattern ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Pattern" => x)

/// An input for collecting text values.
type MudTextFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    /// The type of input collected by this component.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// Shows a button to clear this input's value.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clearable" =>>> true)
    /// Shows a button to clear this input's value.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" =>>> x)
    /// The icon to display when Clearable is true.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    /// Occurs when the clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Occurs when the clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// The mask to apply to text values.
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.IMask) = render ==> ("Mask" => x)
    /// Stretches this input vertically to accommodate the Text value.
    [<CustomOperation("AutoGrow")>] member inline _.AutoGrow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoGrow" =>>> true)
    /// Stretches this input vertically to accommodate the Text value.
    [<CustomOperation("AutoGrow")>] member inline _.AutoGrow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoGrow" =>>> x)
    /// The maximum vertical lines to display when AutoGrow is true.
    [<CustomOperation("MaxLines")>] member inline _.MaxLines ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLines" => x)

/// A component for collecting an input value.
type MudInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// The type of input collected by this component.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// Occurs when the Up arrow button is clicked.
    [<CustomOperation("OnIncrement")>] member inline _.OnIncrement ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnIncrement", fn)
    /// Occurs when the Up arrow button is clicked.
    [<CustomOperation("OnIncrement")>] member inline _.OnIncrement ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnIncrement", fn)
    /// Occurs when the Down arrow button is clicked.
    [<CustomOperation("OnDecrement")>] member inline _.OnDecrement ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnDecrement", fn)
    /// Occurs when the Down arrow button is clicked.
    [<CustomOperation("OnDecrement")>] member inline _.OnDecrement ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnDecrement", fn)
    /// For MudNumericField`1, hides the spin buttons.
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideSpinButtons" =>>> true)
    /// For MudNumericField`1, hides the spin buttons.
    [<CustomOperation("HideSpinButtons")>] member inline _.HideSpinButtons ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideSpinButtons" =>>> x)
    /// Shows a button to clear this input's value.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clearable" =>>> true)
    /// Shows a button to clear this input's value.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" =>>> x)
    /// Occurs when the clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Occurs when the clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// Occurs when a mouse wheel event is raised.
    [<CustomOperation("OnMouseWheel")>] member inline _.OnMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.WheelEventArgs -> unit) = render ==> html.callback("OnMouseWheel", fn)
    /// Occurs when a mouse wheel event is raised.
    [<CustomOperation("OnMouseWheel")>] member inline _.OnMouseWheel ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.WheelEventArgs -> Task<unit>) = render ==> html.callbackTask("OnMouseWheel", fn)
    /// The icon to display when Clearable is true.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    /// The icon to display for the Up arrow button.
    [<CustomOperation("NumericUpIcon")>] member inline _.NumericUpIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NumericUpIcon" => x)
    /// The icon to display for the Down arrow button.
    [<CustomOperation("NumericDownIcon")>] member inline _.NumericDownIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NumericDownIcon" => x)
    /// Stretches this input vertically to accommodate the Text value.
    [<CustomOperation("AutoGrow")>] member inline _.AutoGrow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoGrow" =>>> true)
    /// Stretches this input vertically to accommodate the Text value.
    [<CustomOperation("AutoGrow")>] member inline _.AutoGrow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoGrow" =>>> x)
    /// The maximum vertical lines to display when AutoGrow is true.
    [<CustomOperation("MaxLines")>] member inline _.MaxLines ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxLines" => x)

/// An input component for collecting alphanumeric values.
type MudInputStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudInputBuilder<'FunBlazorGeneric, System.String>()


/// A component for collecting start and end values which define a range.
type MudRangeInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, MudBlazor.Range<'T>>()
    /// The type of input collected by this component.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// The hint displayed before the user enters a starting value.
    [<CustomOperation("PlaceholderStart")>] member inline _.PlaceholderStart ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderStart" => x)
    /// The hint displayed before the user enters an ending value.
    [<CustomOperation("PlaceholderEnd")>] member inline _.PlaceholderEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderEnd" => x)
    /// Occurs when the Clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Occurs when the Clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// Shows a button at the end of the input to clear the value.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clearable" =>>> true)
    /// Shows a button at the end of the input to clear the value.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" =>>> x)
    /// The icon shown in between start and end values.
    [<CustomOperation("SeparatorIcon")>] member inline _.SeparatorIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SeparatorIcon" => x)

/// A text input which conforms user input to a specific format while typing.
/// 
/// Note that MudMask is recommended to be used in WASM projects only because it has known problems
/// in BSS, especially with high network latency.
type MudMaskBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, System.String>()
    /// The mask to apply to text values.
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.IMask) = render ==> ("Mask" => x)
    /// The type of the underlying input.
    [<CustomOperation("InputType")>] member inline _.InputType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.InputType) = render ==> ("InputType" => x)
    /// Shows the clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clearable" =>>> true)
    /// Shows the clear button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" =>>> x)
    /// Occurs when the clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Occurs when the clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// The icon displayed when Clearable is true.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)

/// A component for choosing an item from a list of options.
type MudSelectBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    /// The behavior of the dropdown popover menu
    [<CustomOperation("DropdownSettings")>] member inline _.DropdownSettings ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DropdownSettings) = render ==> ("DropdownSettings" => x)
    /// Determines the width of this Popover dropdown in relation to the parent container.
    [<CustomOperation("RelativeWidth")>] member inline _.RelativeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DropdownWidth) = render ==> ("RelativeWidth" => x)
    /// Sets the container width to match its contents.
    [<CustomOperation("FitContent")>] member inline _.FitContent ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FitContent" =>>> true)
    /// Sets the container width to match its contents.
    [<CustomOperation("FitContent")>] member inline _.FitContent ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FitContent" =>>> x)
    /// The CSS classes applied to the outer div.
    [<CustomOperation("OuterClass")>] member inline _.OuterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OuterClass" => x)
    /// The CSS classes applied to the input.
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// Occurs when this drop-down opens.
    [<CustomOperation("OnOpen")>] member inline _.OnOpen ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnOpen", fn)
    /// Occurs when this drop-down opens.
    [<CustomOperation("OnOpen")>] member inline _.OnOpen ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnOpen", fn)
    /// Occurs when this drop-down closes.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnClose", fn)
    /// Occurs when this drop-down closes.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)
    /// Prevents interaction with background elements while this list is open.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Modal" =>>> true)
    /// Prevents interaction with background elements while this list is open.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Modal" =>>> x)
    /// The CSS classes applied to the popover.
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    /// The CSS classes applied to the internal list.
    [<CustomOperation("ListClass")>] member inline _.ListClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    /// Uses compact vertical padding for all items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact vertical padding for all items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// The icon for opening the popover of items.
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    /// The icon for closing the popover of items.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// Shows a "Select all" checkbox to select all items.
    [<CustomOperation("SelectAll")>] member inline _.SelectAll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectAll" =>>> true)
    /// Shows a "Select all" checkbox to select all items.
    [<CustomOperation("SelectAll")>] member inline _.SelectAll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectAll" =>>> x)
    /// The text of the "Select all" checkbox.
    [<CustomOperation("SelectAllText")>] member inline _.SelectAllText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectAllText" => x)
    /// Occurs when SelectedValues has changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'T> -> unit) = render ==> html.callback("SelectedValuesChanged", fn)
    /// Occurs when SelectedValues has changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedValuesChanged", fn)
    /// The custom function for setting the Text from a list of selected items.
    [<CustomOperation("MultiSelectionTextFunc")>] member inline _.MultiSelectionTextFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("MultiSelectionTextFunc" => (System.Func<System.Collections.Generic.List<System.String>, System.String>fn))
    /// The string used to separate multiple selected values.
    [<CustomOperation("Delimiter")>] member inline _.Delimiter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Delimiter" => x)
    /// The TimeSpan interval for accepting characters for search input.
    [<CustomOperation("QuickSearchInterval")>] member inline _.QuickSearchInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.TimeSpan) = render ==> ("QuickSearchInterval" => x)
    /// The currently selected values.
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("SelectedValues" => x)
    /// The currently selected values.
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'T> * (System.Collections.Generic.IEnumerable<'T> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    /// The comparer for testing equality of selected values.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// The function for the Text in drop-down items.
    [<CustomOperation("ToStringFunc")>] member inline _.ToStringFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ToStringFunc" => (System.Func<'T, System.String>fn))
    /// Allows multiple values to be selected via checkboxes.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MultiSelection" =>>> true)
    /// Allows multiple values to be selected via checkboxes.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MultiSelection" =>>> x)
    /// The maximum height, in pixels, of the popover of items.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxHeight" => x)
    /// The location where the popover will open from.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// The transform origin point for the popover.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// Restricts the selected values to the ones defined in MudSelectItem`1 items.
    [<CustomOperation("Strict")>] member inline _.Strict ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Strict" =>>> true)
    /// Restricts the selected values to the ones defined in MudSelectItem`1 items.
    [<CustomOperation("Strict")>] member inline _.Strict ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Strict" =>>> x)
    /// Shows a button for clearing any selected values.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clearable" =>>> true)
    /// Shows a button for clearing any selected values.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" =>>> x)
    /// The icon displayed for the clear button when Clearable is true.
    [<CustomOperation("ClearIcon")>] member inline _.ClearIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClearIcon" => x)
    /// Prevents scrolling while the dropdown is open.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("LockScroll" =>>> true)
    /// Prevents scrolling while the dropdown is open.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("LockScroll" =>>> x)
    /// Occurs when the clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClearButtonClick", fn)
    /// Occurs when the clear button is clicked.
    [<CustomOperation("OnClearButtonClick")>] member inline _.OnClearButtonClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClearButtonClick", fn)
    /// The icon used for selected items.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The icon used for unselected items.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// The icon used when at least one, but not all, items are selected.
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)

/// Represents a form input component which stores a boolean value.
type MudBooleanInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.Nullable<System.Boolean>>()
    /// Prevents the user from interacting with this input.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this input.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents the user from changing the input.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents the user from changing the input.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// The currently selected value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The currently selected value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// Prevents the parent component from receiving click events.
    [<CustomOperation("StopClickPropagation")>] member inline _.StopClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StopClickPropagation" =>>> true)
    /// Prevents the parent component from receiving click events.
    [<CustomOperation("StopClickPropagation")>] member inline _.StopClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StopClickPropagation" =>>> x)
    /// The location of the label relative to the input icon.
    [<CustomOperation("LabelPlacement")>] member inline _.LabelPlacement ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Placement) = render ==> ("LabelPlacement" => x)
    /// The text/label will be displayed next to the switch if set.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Gets or sets whether to show a ripple effect when the user clicks the button. Default is true.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Gets or sets whether to show a ripple effect when the user clicks the button. Default is true.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// The Size of the component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Occurs when the Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Occurs when the Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)

/// Represents a form input for boolean values or selecting multiple items in a list.
type MudCheckBoxBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    /// The color of the checkbox when its Value is false or null.
    [<CustomOperation("UncheckedColor")>] member inline _.UncheckedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("UncheckedColor" => x)
    /// Allows this checkbox to be controlled via the keyboard.
    [<CustomOperation("KeyboardEnabled")>] member inline _.KeyboardEnabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("KeyboardEnabled" =>>> true)
    /// Allows this checkbox to be controlled via the keyboard.
    [<CustomOperation("KeyboardEnabled")>] member inline _.KeyboardEnabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("KeyboardEnabled" =>>> x)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// The icon to display for a checked state.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The icon to display for an unchecked state.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// The icon to display for an indeterminate state.
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)
    /// Allows the checkbox to have an indeterminate state.
    [<CustomOperation("TriState")>] member inline _.TriState ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TriState" =>>> true)
    /// Allows the checkbox to have an indeterminate state.
    [<CustomOperation("TriState")>] member inline _.TriState ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TriState" =>>> x)

/// An option from a set of mutually exclusive options, often as part of a MudRadioGroup`1.
type MudRadioBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    /// The color to use when in an unchecked state.
    [<CustomOperation("UncheckedColor")>] member inline _.UncheckedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("UncheckedColor" => x)
    /// Uses compact vertical padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact vertical padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// The icon displayed when in a checked state.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The icon displayed when in an unchecked state.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// The icon to display for an indeterminate state.
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)

/// A component which switches between two values.
type MudSwitchBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    /// The color of this switch when in an unchecked state.
    [<CustomOperation("UncheckedColor")>] member inline _.UncheckedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("UncheckedColor" => x)
    /// The icon to display for the switch thumb.
    [<CustomOperation("ThumbIcon")>] member inline _.ThumbIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ThumbIcon" => x)
    /// The color of the thumb icon.
    [<CustomOperation("ThumbIconColor")>] member inline _.ThumbIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ThumbIconColor" => x)

/// A form component for uploading one or more files.  For T, use either IBrowserFile for a single file or IReadOnlyList<IBrowserFile> for multiple files.
type MudFileUploadBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    /// The uploaded file or files.
    [<CustomOperation("Files")>] member inline _.Files ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Files" => x)
    /// The uploaded file or files.
    [<CustomOperation("Files'")>] member inline _.Files' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Files", valueFn)
    /// Occurs when Files has changed.
    [<CustomOperation("FilesChanged")>] member inline _.FilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("FilesChanged", fn)
    /// Occurs when Files has changed.
    [<CustomOperation("FilesChanged")>] member inline _.FilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("FilesChanged", fn)
    /// Occurs when the internal files have changed.
    [<CustomOperation("OnFilesChanged")>] member inline _.OnFilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs -> unit) = render ==> html.callback("OnFilesChanged", fn)
    /// Occurs when the internal files have changed.
    [<CustomOperation("OnFilesChanged")>] member inline _.OnFilesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnFilesChanged", fn)
    /// Appends additional files to the existing list.
    [<CustomOperation("AppendMultipleFiles")>] member inline _.AppendMultipleFiles ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AppendMultipleFiles" =>>> true)
    /// Appends additional files to the existing list.
    [<CustomOperation("AppendMultipleFiles")>] member inline _.AppendMultipleFiles ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AppendMultipleFiles" =>>> x)
    /// The custom content which, when clicked, opens the file picker.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ActivatorContent", fragment)
    /// The custom content which, when clicked, opens the file picker.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ActivatorContent", fragment { yield! fragments })
    /// The custom content which, when clicked, opens the file picker.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// The custom content which, when clicked, opens the file picker.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// The custom content which, when clicked, opens the file picker.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// The template used for selected files.
    [<CustomOperation("SelectedTemplate")>] member inline _.SelectedTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("SelectedTemplate", fn)
    /// Prevents raising OnFilesChanged if validation fails during an upload.
    [<CustomOperation("SuppressOnChangeWhenInvalid")>] member inline _.SuppressOnChangeWhenInvalid ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SuppressOnChangeWhenInvalid" =>>> true)
    /// Prevents raising OnFilesChanged if validation fails during an upload.
    [<CustomOperation("SuppressOnChangeWhenInvalid")>] member inline _.SuppressOnChangeWhenInvalid ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SuppressOnChangeWhenInvalid" =>>> x)
    /// The accepted file extensions, separated by commas.
    [<CustomOperation("Accept")>] member inline _.Accept ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Accept" => x)
    /// Hides the inner InputFile component.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hidden" =>>> true)
    /// Hides the inner InputFile component.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hidden" =>>> x)
    /// The CSS classes applied to the internal InputFile.
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// The CSS styles applied to the internal InputFile.
    [<CustomOperation("InputStyle")>] member inline _.InputStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputStyle" => x)
    /// The maximum number of files retrieved during a call to GetMultipleFiles.
    [<CustomOperation("MaximumFileCount")>] member inline _.MaximumFileCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaximumFileCount" => x)
    /// Prevents the user from uploading files.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from uploading files.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// A component for selecting date, time, and color values.
type MudPickerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    /// The color of the AdornmentIcon.
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    /// The icon shown next to the text input.
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    /// The aria-label for the adornment.
    [<CustomOperation("AdornmentAriaLabel")>] member inline _.AdornmentAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentAriaLabel" => x)
    /// The text displayed in the input if no value is specified.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    /// Occurs when this picker has opened.
    [<CustomOperation("PickerOpened")>] member inline _.PickerOpened ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("PickerOpened", fn)
    /// Occurs when this picker has opened.
    [<CustomOperation("PickerOpened")>] member inline _.PickerOpened ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("PickerOpened", fn)
    /// Occurs when this picker has closed.
    [<CustomOperation("PickerClosed")>] member inline _.PickerClosed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("PickerClosed", fn)
    /// Occurs when this picker has closed.
    [<CustomOperation("PickerClosed")>] member inline _.PickerClosed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("PickerClosed", fn)
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Elevation" => x)
    /// Disables rounded corners.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Disables rounded corners.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Shows rounded corners.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Rounded" =>>> true)
    /// Shows rounded corners.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Rounded" =>>> x)
    /// The text displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// Displays the HelperText only when this input has focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HelperTextOnFocus" =>>> true)
    /// Displays the HelperText only when this input has focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HelperTextOnFocus" =>>> x)
    /// The label for this input.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Displays the Clear icon button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Clearable" =>>> true)
    /// Displays the Clear icon button.
    [<CustomOperation("Clearable")>] member inline _.Clearable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" =>>> x)
    /// Prevents the user from interacting with this button.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this button.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Shows an underline under the input text.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Underline" =>>> true)
    /// Shows an underline under the input text.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Underline" =>>> x)
    /// Prevents the input from being changed by the user.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents the input from being changed by the user.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Allows the value to be edited.
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Editable" =>>> true)
    /// Allows the value to be edited.
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Editable" =>>> x)
    /// Shows the toolbar.
    [<CustomOperation("ShowToolbar")>] member inline _.ShowToolbar ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowToolbar" =>>> true)
    /// Shows the toolbar.
    [<CustomOperation("ShowToolbar")>] member inline _.ShowToolbar ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowToolbar" =>>> x)
    /// The CSS classes for the toolbar when ShowToolbar is true.
    [<CustomOperation("ToolbarClass")>] member inline _.ToolbarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToolbarClass" => x)
    /// The display variant for this picker.
    [<CustomOperation("PickerVariant")>] member inline _.PickerVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.PickerVariant) = render ==> ("PickerVariant" => x)
    /// The display variant of the text input.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// The location of the AdornmentIcon for the input.
    [<CustomOperation("Adornment")>] member inline _.Adornment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    /// The orientation of the picker when PickerVariant is Static.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    /// The size of the icon in the input field.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// The color of the toolbar, selected, and active values.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Occurs when Text has changed.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> unit) = render ==> html.callback("TextChanged", fn)
    /// Occurs when Text has changed.
    [<CustomOperation("TextChanged")>] member inline _.TextChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String -> Task<unit>) = render ==> html.callbackTask("TextChanged", fn)
    /// Updates Text immediately upon typing when Editable is true.
    [<CustomOperation("ImmediateText")>] member inline _.ImmediateText ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ImmediateText" =>>> true)
    /// Updates Text immediately upon typing when Editable is true.
    [<CustomOperation("ImmediateText")>] member inline _.ImmediateText ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ImmediateText" =>>> x)
    /// Occurs when the text input has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when the text input has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// The currently selected value, as a string.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The currently selected value, as a string.
    [<CustomOperation("Text'")>] member inline _.Text' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Text", valueFn)
    /// The CSS classes applied to the action buttons container.
    [<CustomOperation("ActionsClass")>] member inline _.ActionsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActionsClass" => x)
    /// The custom action buttons to display.
    [<CustomOperation("PickerActions")>] member inline _.PickerActions ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudPicker<'T> -> NodeRenderFragment) = render ==> html.renderFragment("PickerActions", fn)
    /// The amount of vertical spacing for the text input.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// Shows the label inside the text input if no Text is specified.
    [<CustomOperation("ShrinkLabel")>] member inline _.ShrinkLabel ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShrinkLabel" =>>> true)
    /// Shows the label inside the text input if no Text is specified.
    [<CustomOperation("ShrinkLabel")>] member inline _.ShrinkLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShrinkLabel" =>>> x)
    /// The mask to apply to input values when Editable is true.
    [<CustomOperation("Mask")>] member inline _.Mask ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.IMask) = render ==> ("Mask" => x)
    /// Prevents interaction with background elements while the picker is open.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Modal" =>>> true)
    /// Prevents interaction with background elements while the picker is open.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Modal" =>>> x)
    /// The location the popover opens, relative to its container.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("AnchorOrigin" => x)
    /// The direction the popover opens, relative to its container.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// The behavior of the popover when it overflows its container.
    [<CustomOperation("OverflowBehavior")>] member inline _.OverflowBehavior ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.OverflowBehavior) = render ==> ("OverflowBehavior" => x)
    /// Determines the width of the Popover dropdown in relation the parent container.
    [<CustomOperation("RelativeWidth")>] member inline _.RelativeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DropdownWidth) = render ==> ("RelativeWidth" => x)

/// Represents a base class for designing date picker components.
type MudBaseDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    /// The maximum selectable date.
    [<CustomOperation("MaxDate")>] member inline _.MaxDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("MaxDate" => x)
    /// The minimum selectable date.
    [<CustomOperation("MinDate")>] member inline _.MinDate ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("MinDate" => x)
    /// The initial view to display.
    [<CustomOperation("OpenTo")>] member inline _.OpenTo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.OpenTo) = render ==> ("OpenTo" => x)
    /// The format for selected dates.
    [<CustomOperation("DateFormat")>] member inline _.DateFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DateFormat" => x)
    /// The day representing the first day of the week.
    [<CustomOperation("FirstDayOfWeek")>] member inline _.FirstDayOfWeek ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DayOfWeek>) = render ==> ("FirstDayOfWeek" => x)
    /// The current month shown in the date picker.
    [<CustomOperation("PickerMonth")>] member inline _.PickerMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("PickerMonth" => x)
    /// The current month shown in the date picker.
    [<CustomOperation("PickerMonth'")>] member inline _.PickerMonth' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("PickerMonth", valueFn)
    /// Occurs when PickerMonth has changed.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.DateTime> -> unit) = render ==> html.callback("PickerMonthChanged", fn)
    /// Occurs when PickerMonth has changed.
    [<CustomOperation("PickerMonthChanged")>] member inline _.PickerMonthChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.DateTime> -> Task<unit>) = render ==> html.callbackTask("PickerMonthChanged", fn)
    /// The delay, in milliseconds, before closing the picker after a value is selected.
    [<CustomOperation("ClosingDelay")>] member inline _.ClosingDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    /// The number of months to display in the calendar.
    [<CustomOperation("DisplayMonths")>] member inline _.DisplayMonths ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("DisplayMonths" => x)
    /// The maximum number of months allowed in one row.
    [<CustomOperation("MaxMonthColumns")>] member inline _.MaxMonthColumns ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxMonthColumns" => x)
    /// The start month when opening the picker. 
    [<CustomOperation("StartMonth")>] member inline _.StartMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("StartMonth" => x)
    /// Shows week numbers at the start of each week.
    [<CustomOperation("ShowWeekNumbers")>] member inline _.ShowWeekNumbers ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowWeekNumbers" =>>> true)
    /// Shows week numbers at the start of each week.
    [<CustomOperation("ShowWeekNumbers")>] member inline _.ShowWeekNumbers ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowWeekNumbers" =>>> x)
    /// The format of the selected date in the title.
    [<CustomOperation("TitleDateFormat")>] member inline _.TitleDateFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleDateFormat" => x)
    /// Closes this picker when a value is selected.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoClose" =>>> true)
    /// Closes this picker when a value is selected.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoClose" =>>> x)
    /// The function used to disable one or more dates.
    [<CustomOperation("IsDateDisabledFunc")>] member inline _.IsDateDisabledFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("IsDateDisabledFunc" => (System.Func<System.DateTime, System.Boolean>fn))
    /// The function which returns CSS classes for a date.
    [<CustomOperation("AdditionalDateClassesFunc")>] member inline _.AdditionalDateClassesFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("AdditionalDateClassesFunc" => (System.Func<System.DateTime, System.String>fn))
    /// The icon for the button that navigates to the previous month or year.
    [<CustomOperation("PreviousIcon")>] member inline _.PreviousIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviousIcon" => x)
    /// The icon for the button which navigates to the next month or year.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// The year to use, which cannot be changed.
    [<CustomOperation("FixYear")>] member inline _.FixYear ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixYear" => x)
    /// The month to use, which cannot be changed.
    [<CustomOperation("FixMonth")>] member inline _.FixMonth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixMonth" => x)
    /// The day to use, which cannot be changed.
    [<CustomOperation("FixDay")>] member inline _.FixDay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("FixDay" => x)

/// Represents a picker for dates.
type MudDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    /// Occurs when the Date has changed.
    [<CustomOperation("DateChanged")>] member inline _.DateChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.DateTime> -> unit) = render ==> html.callback("DateChanged", fn)
    /// Occurs when the Date has changed.
    [<CustomOperation("DateChanged")>] member inline _.DateChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.DateTime> -> Task<unit>) = render ==> html.callbackTask("DateChanged", fn)
    /// The currently selected date.
    [<CustomOperation("Date")>] member inline _.Date ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.DateTime>) = render ==> ("Date" => x)
    /// The currently selected date.
    [<CustomOperation("Date'")>] member inline _.Date' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = render ==> html.bind("Date", valueFn)

/// Represents a picker for a range of dates.
type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    /// The maximum number of selectable days.
    [<CustomOperation("MaxDays")>] member inline _.MaxDays ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxDays" => x)
    /// The minimum number of selectable days.
    [<CustomOperation("MinDays")>] member inline _.MinDays ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MinDays" => x)
    /// Include disabled dates within the valid min/max days range.
    [<CustomOperation("AllowDisabledDatesInCount")>] member inline _.AllowDisabledDatesInCount ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowDisabledDatesInCount" =>>> true)
    /// Include disabled dates within the valid min/max days range.
    [<CustomOperation("AllowDisabledDatesInCount")>] member inline _.AllowDisabledDatesInCount ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowDisabledDatesInCount" =>>> x)
    /// The text displayed in the start input if no date is specified.
    [<CustomOperation("PlaceholderStart")>] member inline _.PlaceholderStart ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderStart" => x)
    /// The text displayed in the end input if no date is specified.
    [<CustomOperation("PlaceholderEnd")>] member inline _.PlaceholderEnd ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PlaceholderEnd" => x)
    /// The icon displayed between start and end dates.
    [<CustomOperation("SeparatorIcon")>] member inline _.SeparatorIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SeparatorIcon" => x)
    /// Occurs when DateRange has changed.
    [<CustomOperation("DateRangeChanged")>] member inline _.DateRangeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.DateRange -> unit) = render ==> html.callback("DateRangeChanged", fn)
    /// Occurs when DateRange has changed.
    [<CustomOperation("DateRangeChanged")>] member inline _.DateRangeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.DateRange -> Task<unit>) = render ==> html.callbackTask("DateRangeChanged", fn)
    /// The currently selected date range.
    [<CustomOperation("DateRange")>] member inline _.DateRange ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DateRange) = render ==> ("DateRange" => x)
    /// The currently selected date range.
    [<CustomOperation("DateRange'")>] member inline _.DateRange' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.DateRange * (MudBlazor.DateRange -> unit)) = render ==> html.bind("DateRange", valueFn)
    /// Enables capture for disabled dates within the selected date range.
    [<CustomOperation("AllowDisabledDatesInRange")>] member inline _.AllowDisabledDatesInRange ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowDisabledDatesInRange" =>>> true)
    /// Enables capture for disabled dates within the selected date range.
    [<CustomOperation("AllowDisabledDatesInRange")>] member inline _.AllowDisabledDatesInRange ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowDisabledDatesInRange" =>>> x)

/// Represents a sophisticated and customizable pop-up for choosing a color.
type MudColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, MudBlazor.Utilities.MudColor>()
    /// Shows alpha transparency options.
    [<CustomOperation("ShowAlpha")>] member inline _.ShowAlpha ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowAlpha" =>>> true)
    /// Shows alpha transparency options.
    [<CustomOperation("ShowAlpha")>] member inline _.ShowAlpha ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowAlpha" =>>> x)
    /// Displays the color field.
    [<CustomOperation("ShowColorField")>] member inline _.ShowColorField ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowColorField" =>>> true)
    /// Displays the color field.
    [<CustomOperation("ShowColorField")>] member inline _.ShowColorField ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowColorField" =>>> x)
    /// Displays the switch to change the color mode.
    [<CustomOperation("ShowModeSwitch")>] member inline _.ShowModeSwitch ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowModeSwitch" =>>> true)
    /// Displays the switch to change the color mode.
    [<CustomOperation("ShowModeSwitch")>] member inline _.ShowModeSwitch ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowModeSwitch" =>>> x)
    /// Displays the text inputs, current mode, and mode switch.
    [<CustomOperation("ShowInputs")>] member inline _.ShowInputs ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowInputs" =>>> true)
    /// Displays the text inputs, current mode, and mode switch.
    [<CustomOperation("ShowInputs")>] member inline _.ShowInputs ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowInputs" =>>> x)
    /// Displays hue and alpha sliders.
    [<CustomOperation("ShowSliders")>] member inline _.ShowSliders ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowSliders" =>>> true)
    /// Displays hue and alpha sliders.
    [<CustomOperation("ShowSliders")>] member inline _.ShowSliders ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowSliders" =>>> x)
    /// Displays a preview of the color.
    [<CustomOperation("ShowPreview")>] member inline _.ShowPreview ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowPreview" =>>> true)
    /// Displays a preview of the color.
    [<CustomOperation("ShowPreview")>] member inline _.ShowPreview ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowPreview" =>>> x)
    /// The initial color channels shown.
    [<CustomOperation("ColorPickerMode")>] member inline _.ColorPickerMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ColorPickerMode) = render ==> ("ColorPickerMode" => x)
    /// The initial view.
    [<CustomOperation("ColorPickerView")>] member inline _.ColorPickerView ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ColorPickerView) = render ==> ("ColorPickerView" => x)
    /// Limits updates to the bound value to when HSL values change.
    [<CustomOperation("UpdateBindingIfOnlyHSLChanged")>] member inline _.UpdateBindingIfOnlyHSLChanged ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UpdateBindingIfOnlyHSLChanged" =>>> true)
    /// Limits updates to the bound value to when HSL values change.
    [<CustomOperation("UpdateBindingIfOnlyHSLChanged")>] member inline _.UpdateBindingIfOnlyHSLChanged ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UpdateBindingIfOnlyHSLChanged" =>>> x)
    /// The currently selected color as a MudColor.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Utilities.MudColor) = render ==> ("Value" => x)
    /// The currently selected color as a MudColor.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.Utilities.MudColor * (MudBlazor.Utilities.MudColor -> unit)) = render ==> html.bind("Value", valueFn)
    /// Occurs when the Value property has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Utilities.MudColor -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Occurs when the Value property has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Utilities.MudColor -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// The list of quick colors to display.
    [<CustomOperation("Palette")>] member inline _.Palette ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<MudBlazor.Utilities.MudColor>) = render ==> ("Palette" => x)
    /// Continues to update the selected color while the mouse button is down.
    [<CustomOperation("DragEffect")>] member inline _.DragEffect ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DragEffect" =>>> true)
    /// Continues to update the selected color while the mouse button is down.
    [<CustomOperation("DragEffect")>] member inline _.DragEffect ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DragEffect" =>>> x)
    /// The custom icon to dislay for the close button.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// The icon to display for the spectrum mode button.
    [<CustomOperation("SpectrumIcon")>] member inline _.SpectrumIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SpectrumIcon" => x)
    /// The icon to display for the grid mode button.
    [<CustomOperation("GridIcon")>] member inline _.GridIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GridIcon" => x)
    /// The icon to display for the custom palette button.
    [<CustomOperation("PaletteIcon")>] member inline _.PaletteIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PaletteIcon" => x)
    /// The icon to display for the import/export button.
    [<CustomOperation("ImportExportIcon")>] member inline _.ImportExportIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ImportExportIcon" => x)
    /// The delay, in milliseconds, between updates to the selected color when DragEffect is true.
    [<CustomOperation("ThrottleInterval")>] member inline _.ThrottleInterval ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ThrottleInterval" => x)

/// A component for selecting time values.
type MudTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.TimeSpan>>()
    /// The initial view for this picker.
    [<CustomOperation("OpenTo")>] member inline _.OpenTo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.OpenTo) = render ==> ("OpenTo" => x)
    /// Controls which values can be edited.
    [<CustomOperation("TimeEditMode")>] member inline _.TimeEditMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimeEditMode) = render ==> ("TimeEditMode" => x)
    /// The amount of time, in milliseconds, to wait before closing the picker.
    [<CustomOperation("ClosingDelay")>] member inline _.ClosingDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ClosingDelay" => x)
    /// Closes this picker when the value is set or cleared.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoClose" =>>> true)
    /// Closes this picker when the value is set or cleared.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoClose" =>>> x)
    /// The step interval when selecting minutes.
    [<CustomOperation("MinuteSelectionStep")>] member inline _.MinuteSelectionStep ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MinuteSelectionStep" => x)
    /// Shows a 12-hour selection clock.
    [<CustomOperation("AmPm")>] member inline _.AmPm ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AmPm" =>>> true)
    /// Shows a 12-hour selection clock.
    [<CustomOperation("AmPm")>] member inline _.AmPm ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AmPm" =>>> x)
    /// The format applied to time values.
    [<CustomOperation("TimeFormat")>] member inline _.TimeFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TimeFormat" => x)
    /// The currently selected time.
    [<CustomOperation("Time")>] member inline _.Time ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.TimeSpan>) = render ==> ("Time" => x)
    /// The currently selected time.
    [<CustomOperation("Time'")>] member inline _.Time' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<System.TimeSpan> * (System.Nullable<System.TimeSpan> -> unit)) = render ==> html.bind("Time", valueFn)
    /// Occurs when Time has changed.
    [<CustomOperation("TimeChanged")>] member inline _.TimeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.TimeSpan> -> unit) = render ==> html.callback("TimeChanged", fn)
    /// Occurs when Time has changed.
    [<CustomOperation("TimeChanged")>] member inline _.TimeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.TimeSpan> -> Task<unit>) = render ==> html.callbackTask("TimeChanged", fn)

/// A group of MudRadio`1 components.
type MudRadioGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'T>()
    /// The CSS classes for this button group.
    [<CustomOperation("InputClass")>] member inline _.InputClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputClass" => x)
    /// The CSS styles for this button group.
    [<CustomOperation("InputStyle")>] member inline _.InputStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InputStyle" => x)
    /// The unique name for this button group.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// Prevents the user from interacting with this group.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this group.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents the selected value from being changed.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents the selected value from being changed.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// The current value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The current value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// Occurs whenever Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Occurs whenever Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)

/// Represents an alert used to display an important message which is statically embedded in the page content.
type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Gets or sets the position of the text to the start (Left in LTR and right in RTL).
    [<CustomOperation("ContentAlignment")>] member inline _.ContentAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("ContentAlignment" => x)
    /// Occurs when the close button has been clicked.
    [<CustomOperation("CloseIconClicked")>] member inline _.CloseIconClicked ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudAlert -> unit) = render ==> html.callback("CloseIconClicked", fn)
    /// Occurs when the close button has been clicked.
    [<CustomOperation("CloseIconClicked")>] member inline _.CloseIconClicked ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudAlert -> Task<unit>) = render ==> html.callbackTask("CloseIconClicked", fn)
    /// Gets or sets the icon used for the close button.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// Gets or sets whether a close icon is displayed.
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowCloseIcon" =>>> true)
    /// Gets or sets whether a close icon is displayed.
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowCloseIcon" =>>> x)
    /// Gets or sets the size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Gets or sets whether rounded corners are disabled.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Gets or sets whether rounded corners are disabled.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Gets or sets whether compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Gets or sets whether compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Gets or sets whether no icon is displayed.
    [<CustomOperation("NoIcon")>] member inline _.NoIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("NoIcon" =>>> true)
    /// Gets or sets whether no icon is displayed.
    [<CustomOperation("NoIcon")>] member inline _.NoIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("NoIcon" =>>> x)
    /// Gets or sets the severity of the alert.
    [<CustomOperation("Severity")>] member inline _.Severity ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Severity) = render ==> ("Severity" => x)
    /// Gets or sets the display variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Gets or sets the icon displayed for this alert.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Occurs when the alert has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when the alert has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// Represents a component which displays circular user profile pictures, icons or text.
type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Disables rounded corners.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Disables rounded corners.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Uses rounded corners instead of a circle.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Rounded" =>>> true)
    /// Uses rounded corners instead of a circle.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Rounded" =>>> x)
    /// The color of the avatar.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the avatar.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The display variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)

/// Represents a grouping of multiple MudAvatar components.
type MudAvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The amount of space between avatars, between 0 and 16.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Displays an outline for the group.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Displays an outline for the group.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)
    /// The color of the outline when Outlined is true.
    [<CustomOperation("OutlineColor")>] member inline _.OutlineColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("OutlineColor" => x)
    /// The size of the drop shadow when the number of avatars exceeds Max.
    [<CustomOperation("MaxElevation")>] member inline _.MaxElevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxElevation" => x)
    /// Disables rounded corners when the number of avatars exceeds Max.
    [<CustomOperation("MaxSquare")>] member inline _.MaxSquare ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MaxSquare" =>>> true)
    /// Disables rounded corners when the number of avatars exceeds Max.
    [<CustomOperation("MaxSquare")>] member inline _.MaxSquare ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MaxSquare" =>>> x)
    /// Shows rounded corners when the number of avatars exceeds Max.
    [<CustomOperation("MaxRounded")>] member inline _.MaxRounded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MaxRounded" =>>> true)
    /// Shows rounded corners when the number of avatars exceeds Max.
    [<CustomOperation("MaxRounded")>] member inline _.MaxRounded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MaxRounded" =>>> x)
    /// The color of the avatar when the number of avatars exceeds Max.
    [<CustomOperation("MaxColor")>] member inline _.MaxColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("MaxColor" => x)
    /// The size of the avatar when the number of avatars exceeds Max.
    [<CustomOperation("MaxSize")>] member inline _.MaxSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("MaxSize" => x)
    /// The display variant to use when the number of avatars exceeds Max.
    [<CustomOperation("MaxVariant")>] member inline _.MaxVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("MaxVariant" => x)
    /// The maximum allowed avatars to display.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    /// The CSS class applied when the number of avatars exceeds Max.
    [<CustomOperation("MaxAvatarClass")>] member inline _.MaxAvatarClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxAvatarClass" => x)
    /// The template used to render avatars when the number of avatars exceeds Max.
    [<CustomOperation("MaxAvatarsTemplate")>] member inline _.MaxAvatarsTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> NodeRenderFragment) = render ==> html.renderFragment("MaxAvatarsTemplate", fn)

/// Represents an overlay added to an icon or button to add information such as a number of new items.
type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The location of the badge.
    [<CustomOperation("Origin")>] member inline _.Origin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("Origin" => x)
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Displays this badge.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Displays this badge.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// The color of the badge.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Displays a dot instead of any content.
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dot" =>>> true)
    /// Displays a dot instead of any content.
    [<CustomOperation("Dot")>] member inline _.Dot ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dot" =>>> x)
    /// Displays ChildContent over the main badge content.
    [<CustomOperation("Overlap")>] member inline _.Overlap ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Overlap" =>>> true)
    /// Displays ChildContent over the main badge content.
    [<CustomOperation("Overlap")>] member inline _.Overlap ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Overlap" =>>> x)
    /// Displays a border around the badge.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Bordered" =>>> true)
    /// Displays a border around the badge.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Bordered" =>>> x)
    /// The icon to display in the badge.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The maximum number allowed in the Content property.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Max" => x)
    /// The string or int value to display inside the badge.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Content" => x)
    /// The CSS classes applied to the badge.
    [<CustomOperation("BadgeClass")>] member inline _.BadgeClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BadgeClass" => x)
    /// The aria-label for the badge.
    [<CustomOperation("BadgeAriaLabel")>] member inline _.BadgeAriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BadgeAriaLabel" => x)
    /// Occurs when the badge has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when the badge has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// Represents a series of links used to show the user's current location.
type MudBreadcrumbsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The list of items to display.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyList<MudBlazor.BreadcrumbItem>) = render ==> ("Items" => x)
    /// The separator shown between items.
    [<CustomOperation("Separator")>] member inline _.Separator ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Separator" => x)
    /// The content shown between items.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("SeparatorTemplate", fragment)
    /// The content shown between items.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("SeparatorTemplate", fragment { yield! fragments })
    /// The content shown between items.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    /// The content shown between items.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    /// The content shown between items.
    [<CustomOperation("SeparatorTemplate")>] member inline _.SeparatorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("SeparatorTemplate", html.text x)
    /// The custom template used to display items.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.BreadcrumbItem -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// The maximum number of items to display.
    [<CustomOperation("MaxItems")>] member inline _.MaxItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Byte>) = render ==> ("MaxItems" => x)
    /// The icon to display when items are collapsed.
    [<CustomOperation("ExpanderIcon")>] member inline _.ExpanderIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpanderIcon" => x)

/// Represents a cascading parameter which exposes the window's current breakpoint (xs, sm, md, lg, xl).
type MudBreakpointProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Occurs when Breakpoint has changed.
    [<CustomOperation("OnBreakpointChanged")>] member inline _.OnBreakpointChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Breakpoint -> unit) = render ==> html.callback("OnBreakpointChanged", fn)
    /// Occurs when Breakpoint has changed.
    [<CustomOperation("OnBreakpointChanged")>] member inline _.OnBreakpointChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Breakpoint -> Task<unit>) = render ==> html.callbackTask("OnBreakpointChanged", fn)

/// Represents a button consisting of an icon that can be toggled between two distinct states.
type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Whether the icon is in the toggled state.
    [<CustomOperation("Toggled")>] member inline _.Toggled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Toggled" =>>> true)
    /// Whether the icon is in the toggled state.
    [<CustomOperation("Toggled")>] member inline _.Toggled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Toggled" =>>> x)
    /// Whether the icon is in the toggled state.
    [<CustomOperation("Toggled'")>] member inline _.Toggled' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Toggled", valueFn)
    /// Occurs when Toggled is changed.
    [<CustomOperation("ToggledChanged")>] member inline _.ToggledChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ToggledChanged", fn)
    /// Occurs when Toggled is changed.
    [<CustomOperation("ToggledChanged")>] member inline _.ToggledChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ToggledChanged", fn)
    /// The icon to use.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// An alternative icon to use in the toggled state.
    [<CustomOperation("ToggledIcon")>] member inline _.ToggledIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToggledIcon" => x)
    /// The color of the button.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// An alternative color to use in the toggled state.
    [<CustomOperation("ToggledColor")>] member inline _.ToggledColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("ToggledColor" => x)
    /// The size of the button.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// An alternative size to use in the toggled state.
    [<CustomOperation("ToggledSize")>] member inline _.ToggledSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Size>) = render ==> ("ToggledSize" => x)
    /// The display variation to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// An alternative variant to use in the toggled state.
    [<CustomOperation("ToggledVariant")>] member inline _.ToggledVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Variant>) = render ==> ("ToggledVariant" => x)
    /// Applies a negative margin.
    [<CustomOperation("Edge")>] member inline _.Edge ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Edge) = render ==> ("Edge" => x)
    /// Shows a ripple effect when the user clicks the button.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when the user clicks the button.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Displays a shadow.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DropShadow" =>>> true)
    /// Displays a shadow.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DropShadow" =>>> x)
    /// Disables interaction with the button.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Disables interaction with the button.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Allows the click event to bubble up to the parent component.
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ClickPropagation" =>>> true)
    /// Allows the click event to bubble up to the parent component.
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ClickPropagation" =>>> x)

/// Represents a group of connected MudButton components.
type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Overrides individual button styles with this group's style.
    [<CustomOperation("OverrideStyles")>] member inline _.OverrideStyles ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OverrideStyles" =>>> true)
    /// Overrides individual button styles with this group's style.
    [<CustomOperation("OverrideStyles")>] member inline _.OverrideStyles ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OverrideStyles" =>>> x)
    /// Displays buttons vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Vertical" =>>> true)
    /// Displays buttons vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Vertical" =>>> x)
    /// Displays a shadow.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DropShadow" =>>> true)
    /// Displays a shadow.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DropShadow" =>>> x)
    /// The color of all buttons in this group.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of all buttons in the group.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The display variant of all buttons in the group.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// If true, the button group will take up 100% of available width.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FullWidth" =>>> true)
    /// If true, the button group will take up 100% of available width.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FullWidth" =>>> x)

/// Represents a block of content which can include a header, image, content, and actions.
type MudCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Disables rounded corners.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Disables rounded corners.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Displays an outline.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Displays an outline.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)

/// Represents a set of buttons displayed as part of a MudCard.
type MudCardActionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


/// Represents the primary content displayed within a MudCard.
type MudCardContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


/// Represents the top portion of a MudCard.
type MudCardHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The avatar to display within this header.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("CardHeaderAvatar", fragment)
    /// The avatar to display within this header.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("CardHeaderAvatar", fragment { yield! fragments })
    /// The avatar to display within this header.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    /// The avatar to display within this header.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    /// The avatar to display within this header.
    [<CustomOperation("CardHeaderAvatar")>] member inline _.CardHeaderAvatar ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderAvatar", html.text x)
    /// The main content of this header.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("CardHeaderContent", fragment)
    /// The main content of this header.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("CardHeaderContent", fragment { yield! fragments })
    /// The main content of this header.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    /// The main content of this header.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    /// The main content of this header.
    [<CustomOperation("CardHeaderContent")>] member inline _.CardHeaderContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderContent", html.text x)
    /// The actions displayed within this header.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("CardHeaderActions", fragment)
    /// The actions displayed within this header.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("CardHeaderActions", fragment { yield! fragments })
    /// The actions displayed within this header.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CardHeaderActions", html.text x)
    /// The actions displayed within this header.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CardHeaderActions", html.text x)
    /// The actions displayed within this header.
    [<CustomOperation("CardHeaderActions")>] member inline _.CardHeaderActions ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CardHeaderActions", html.text x)

/// Represents an image displayed as part of a MudCard.
type MudCardMediaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Text for the title attribute which provides a basic tooltip.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The URL of the image to display.
    [<CustomOperation("Image")>] member inline _.Image ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Image" => x)
    /// The height, in pixels, of the Image.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Height" => x)

/// Represents a slide displayed within a MudCarousel`1.
type MudCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of this item. 
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The effect used to blend from this item to a different MudCarouselItem.
    [<CustomOperation("Transition")>] member inline _.Transition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Transition) = render ==> ("Transition" => x)
    /// The custom CSS transition used to blend into this carousel item.
    [<CustomOperation("CustomTransitionEnter")>] member inline _.CustomTransitionEnter ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomTransitionEnter" => x)
    /// The custom CSS transition used to blend away from this carousel item.
    [<CustomOperation("CustomTransitionExit")>] member inline _.CustomTransitionExit ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CustomTransitionExit" => x)

/// Represents a single cell in a HeatMap. You can override the value from the ChartSeries 
/// or provide a custom graphic to be shown inside the cell. You should provide a width and height for the custom graphic you are including
/// so the Heat Map can resize it dynamically. 
type MudHeatMapCellBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The row of the cell you want to modify. Rows use a 0 based index.
    [<CustomOperation("Row")>] member inline _.Row ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Row" => x)
    /// The column of the cell you want to modify. Columns use a 0 based index.
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Column" => x)
    /// If supplied this will overwrite the value in ChartSeries
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("Value" => x)
    /// Optional, Override the color of the cell
    [<CustomOperation("MudColor")>] member inline _.MudColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Utilities.MudColor) = render ==> ("MudColor" => x)
    /// Optional, The width of the custom svg element you want to include. Please note the custom svg elements you provide are resized according to this value if supplied.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)
    /// Optional, The height of the custom svg element you want to include. Please note the custom svg elements you provide are resized according to this value if supplied.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Height" => x)
    /// Optional, setting this will set the minimum value for the heatmap range, by default the range is calculated from the data. This only needs to be set on one
    /// MudHeatMapCell in the HeatMap."/> Only the last value set will be used.
    [<CustomOperation("MinValue")>] member inline _.MinValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("MinValue" => x)
    /// Optional, setting this will set the maximum value for the heatmap range, by default the range is calculated from the data. This only needs to be set on one
    /// MudHeatMapCell in the HeatMap."/> Only the last value set will be used.
    [<CustomOperation("MaxValue")>] member inline _.MaxValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Double>) = render ==> ("MaxValue" => x)

type MudChatBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Child chat bubbles default color, can be overridden by bubble.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Gets or sets the display variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Chat bubble position.
    [<CustomOperation("ChatPosition")>] member inline _.ChatPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ChatBubblePosition) = render ==> ("ChatPosition" => x)
    /// The Chat Bubble Arrow Position.
    [<CustomOperation("ArrowPosition")>] member inline _.ArrowPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ChatArrowPosition) = render ==> ("ArrowPosition" => x)
    /// Gets or sets the size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Gets or sets whether rounded corners are disabled.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Gets or sets whether rounded corners are disabled.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Gets or sets whether compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Gets or sets whether compact padding will be used.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)

/// Represents the content displayed within a MudChat.
type MudChatBubbleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("Color" => x)
    /// The color of the component. It supports the theme colors.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Variant>) = render ==> ("Variant" => x)
    /// Occurs when the chat bubble has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when the chat bubble has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Occurs when the chat bubble has been right-clicked.
    [<CustomOperation("OnContextClick")>] member inline _.OnContextClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnContextClick", fn)
    /// Occurs when the chat bubble has been right-clicked.
    [<CustomOperation("OnContextClick")>] member inline _.OnContextClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnContextClick", fn)

/// Represents the footer of a MudChat.
type MudChatFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The time to display within this header.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)

/// Represents the header of a MudChat.
type MudChatHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The name to display within this header.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// The time to display within this header.
    [<CustomOperation("Time")>] member inline _.Time ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Time" => x)

/// Represents a compact element used to enter information, select a choice, filter content, or trigger an action.
type MudChipBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of this chip.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("Color" => x)
    /// The color of the chip when it is selected.
    [<CustomOperation("SelectedColor")>] member inline _.SelectedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("SelectedColor" => x)
    /// The size of the chip.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Size>) = render ==> ("Size" => x)
    /// The display variation to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Variant>) = render ==> ("Variant" => x)
    /// The avatar content to display inside the chip.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("AvatarContent", fragment)
    /// The avatar content to display inside the chip.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("AvatarContent", fragment { yield! fragments })
    /// The avatar content to display inside the chip.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AvatarContent", html.text x)
    /// The avatar content to display inside the chip.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AvatarContent", html.text x)
    /// The avatar content to display inside the chip.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AvatarContent", html.text x)
    /// Uses the theme border radius for chip edges.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Label" => x)
    /// Prevents the user from interacting with this chip.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this chip.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The icon to display within the chip.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The icon to display when Selected is true.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The color of the Icon.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("IconColor" => x)
    /// The close icon to display when OnClose is set.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// Displays a ripple effect when this chip is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Ripple" => x)
    /// The URL to navigate to when the chip is clicked.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// The target to open URLs if Href is set.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// The relationship between the current document and the linked document when Href is set.
    [<CustomOperation("Rel")>] member inline _.Rel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Rel" => x)
    /// The text label for the chip.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The value applied when the chip is selected.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Selects this chip by default when part of a MudChipSet`1.
    [<CustomOperation("Default")>] member inline _.Default ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Default" => x)
    /// Occurs when this chip is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when this chip is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Occurs when this chip has been closed.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudChip<'T> -> unit) = render ==> html.callback("OnClose", fn)
    /// Occurs when this chip has been closed.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudChip<'T> -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)
    /// Selects this chip.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Selects this chip.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Selects this chip.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// Occurs when the Selected property has changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Occurs when the Selected property has changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)

/// Represents a set of multiple MudChip`1 components.
type MudChipSetBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The mode controlling how many selections are allowed.
    [<CustomOperation("SelectionMode")>] member inline _.SelectionMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SelectionMode) = render ==> ("SelectionMode" => x)
    /// Allows all chips in this set to be closed.
    [<CustomOperation("AllClosable")>] member inline _.AllClosable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllClosable" =>>> true)
    /// Allows all chips in this set to be closed.
    [<CustomOperation("AllClosable")>] member inline _.AllClosable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllClosable" =>>> x)
    /// The default variant for all chips in this set.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// The default color for all chips in this set.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The default color for all selected chips in this set.
    [<CustomOperation("SelectedColor")>] member inline _.SelectedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("SelectedColor" => x)
    /// The default icon color for all chips in this set.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The default size for all chips in this set.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Shows checkmarks for selected chips.
    [<CustomOperation("CheckMark")>] member inline _.CheckMark ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CheckMark" =>>> true)
    /// Shows checkmarks for selected chips.
    [<CustomOperation("CheckMark")>] member inline _.CheckMark ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CheckMark" =>>> x)
    /// The default icon shown for selected chips in this set.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The default close icon shown for closeable chips in this set.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)
    /// Shows a ripple effect when a chip is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when a chip is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Uses the theme border radius for chips in this set.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Label" =>>> true)
    /// Uses the theme border radius for chips in this set.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Label" =>>> x)
    /// Prevents the user from interacting with chips in this set.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with chips in this set.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents chips in this set from being clicked.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents chips in this set from being clicked.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// The comparer used to determine when a selection has changed.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// The currently selected value.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedValue" => x)
    /// The currently selected value.
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Occurs when SelectedValue has changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("SelectedValueChanged", fn)
    /// Occurs when SelectedValue has changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedValueChanged", fn)
    /// The currently selected chips in this set. 
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyCollection<'T>) = render ==> ("SelectedValues" => x)
    /// The currently selected chips in this set. 
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IReadOnlyCollection<'T> * (System.Collections.Generic.IReadOnlyCollection<'T> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    /// Occurs when SelectedValues has changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyCollection<'T> -> unit) = render ==> html.callback("SelectedValuesChanged", fn)
    /// Occurs when SelectedValues has changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyCollection<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedValuesChanged", fn)
    /// Occurs when any chip has been closed.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudChip<'T> -> unit) = render ==> html.callback("OnClose", fn)
    /// Occurs when any chip has been closed.
    [<CustomOperation("OnClose")>] member inline _.OnClose ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudChip<'T> -> Task<unit>) = render ==> html.callbackTask("OnClose", fn)

/// Represents a container for content which can be collapsed and expanded.
type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Displays content within this panel.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Displays content within this panel.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Displays content within this panel.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// The maximum allowed height of this panel, in pixels.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// Occurs when the collapse or expand animation has finished.
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnAnimationEnd", fn)
    /// Occurs when the collapse or expand animation has finished.
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnAnimationEnd", fn)
    /// Occurs when the Expanded property has changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Occurs when the Expanded property has changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)

/// Represents a vertical set of values.
type ColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The value stored in this column.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The value stored in this column.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// Occurs when the Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Occurs when the Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// The display text for this column.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Hides this column.
    [<CustomOperation("HideSmall")>] member inline _.HideSmall ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideSmall" =>>> true)
    /// Hides this column.
    [<CustomOperation("HideSmall")>] member inline _.HideSmall ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideSmall" =>>> x)
    /// The number of columns spanned by this column in the footer.
    [<CustomOperation("FooterColSpan")>] member inline _.FooterColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("FooterColSpan" => x)
    /// The number of columns spanned by this column in the header.
    [<CustomOperation("HeaderColSpan")>] member inline _.HeaderColSpan ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("HeaderColSpan" => x)
    /// The template used to display this column's header.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.HeaderContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    /// The template used to display this column's value cells.
    [<CustomOperation("CellTemplate")>] member inline _.CellTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("CellTemplate", fn)
    /// The template used to display this column's footer.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.FooterContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fn)
    /// The template used to display this column's grouping.
    [<CustomOperation("GroupTemplate")>] member inline _.GroupTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.GroupDefinition<'T> -> NodeRenderFragment) = render ==> html.renderFragment("GroupTemplate", fn)
    /// The template used to display this column's aggregate.
    [<CustomOperation("AggregateTemplate")>] member inline _.AggregateTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'T> -> NodeRenderFragment) = render ==> html.renderFragment("AggregateTemplate", fn)
    /// The function which groups values in this column.
    [<CustomOperation("GroupBy")>] member inline _.GroupBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupBy" => (System.Func<'T, System.Object>fn))
    /// The order in which values are grouped when there are more than one group
    [<CustomOperation("GroupByOrder")>] member inline _.GroupByOrder ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("GroupByOrder" => x)
    /// The order in which values are grouped when there are more than one group
    [<CustomOperation("GroupByOrder'")>] member inline _.GroupByOrder' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("GroupByOrder", valueFn)
    /// Occurs when the GroupByOrder property has changed.
    [<CustomOperation("GroupByOrderChanged")>] member inline _.GroupByOrderChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("GroupByOrderChanged", fn)
    /// Occurs when the GroupByOrder property has changed.
    [<CustomOperation("GroupByOrderChanged")>] member inline _.GroupByOrderChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("GroupByOrderChanged", fn)
    /// Whether the column is indented 48px beyond it's parent when grouped.
    [<CustomOperation("GroupIndented")>] member inline _.GroupIndented ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GroupIndented" =>>> true)
    /// Whether the column is indented 48px beyond it's parent when grouped.
    [<CustomOperation("GroupIndented")>] member inline _.GroupIndented ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GroupIndented" =>>> x)
    /// Whether groups created from this column are expanded. Toggling the value will Toggle all grouped rows of this column.
    [<CustomOperation("GroupExpanded")>] member inline _.GroupExpanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GroupExpanded" =>>> true)
    /// Whether groups created from this column are expanded. Toggling the value will Toggle all grouped rows of this column.
    [<CustomOperation("GroupExpanded")>] member inline _.GroupExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GroupExpanded" =>>> x)
    /// Whether groups created from this column are expanded. Toggling the value will Toggle all grouped rows of this column.
    [<CustomOperation("GroupExpanded'")>] member inline _.GroupExpanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("GroupExpanded", valueFn)
    /// Occurs when the GroupExpanded property has changed.
    [<CustomOperation("GroupExpandedChanged")>] member inline _.GroupExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("GroupExpandedChanged", fn)
    /// Occurs when the GroupExpanded property has changed.
    [<CustomOperation("GroupExpandedChanged")>] member inline _.GroupExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("GroupExpandedChanged", fn)
    /// Requires a value to be set.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Requires a value to be set.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// The CSS class applied to the header.
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// The function which calculates CSS classes for the header.
    [<CustomOperation("HeaderClassFunc")>] member inline _.HeaderClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderClassFunc" => (System.Func<System.Collections.Generic.IEnumerable<'T>, System.String>fn))
    /// The CSS style applied to this column's header.
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    /// The function which calculates CSS styles for the header.
    [<CustomOperation("HeaderStyleFunc")>] member inline _.HeaderStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderStyleFunc" => (System.Func<System.Collections.Generic.IEnumerable<'T>, System.String>fn))
    /// Sorts values in this column.
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    /// Allows this column's width to be changed.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Resizable" => x)
    /// Allows this column to be reordered via drag-and-drop operations.
    [<CustomOperation("DragAndDropEnabled")>] member inline _.DragAndDropEnabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DragAndDropEnabled" => x)
    /// Allows filters to be used on this column.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filterable" => x)
    /// Shows the filter icon.
    [<CustomOperation("ShowFilterIcon")>] member inline _.ShowFilterIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowFilterIcon" => x)
    /// Allows this column to be hidden.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Hideable" => x)
    /// Hides this column.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hidden" =>>> true)
    /// Hides this column.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hidden" =>>> x)
    /// Hides this column.
    [<CustomOperation("Hidden'")>] member inline _.Hidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Hidden", valueFn)
    /// Occurs when the Hidden property has changed.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("HiddenChanged", fn)
    /// Occurs when the Hidden property has changed.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("HiddenChanged", fn)
    /// Shows options for this column.
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowColumnOptions" => x)
    /// The comparison used for values in this column.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IComparer<System.Object>) = render ==> ("Comparer" => x)
    /// The function used to sort values in this column.
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    /// The sorting direction applied when Sortable is true.
    [<CustomOperation("InitialDirection")>] member inline _.InitialDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    /// The icon shown when Sortable is true.
    [<CustomOperation("SortIcon")>] member inline _.SortIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    /// Allows values in this column to be grouped.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Groupable" => x)
    /// Indicates whether this column is currently grouped.
    [<CustomOperation("Grouping")>] member inline _.Grouping ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Grouping" =>>> true)
    /// Indicates whether this column is currently grouped.
    [<CustomOperation("Grouping")>] member inline _.Grouping ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Grouping" =>>> x)
    /// Indicates whether this column is currently grouped.
    [<CustomOperation("Grouping'")>] member inline _.Grouping' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Grouping", valueFn)
    /// Occurs when the Grouping property has changed.
    [<CustomOperation("GroupingChanged")>] member inline _.GroupingChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("GroupingChanged", fn)
    /// Occurs when the Grouping property has changed.
    [<CustomOperation("GroupingChanged")>] member inline _.GroupingChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("GroupingChanged", fn)
    /// Fixes this column to the left side.
    [<CustomOperation("StickyLeft")>] member inline _.StickyLeft ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StickyLeft" =>>> true)
    /// Fixes this column to the left side.
    [<CustomOperation("StickyLeft")>] member inline _.StickyLeft ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StickyLeft" =>>> x)
    /// Fixes this column to the right side.
    [<CustomOperation("StickyRight")>] member inline _.StickyRight ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("StickyRight" =>>> true)
    /// Fixes this column to the right side.
    [<CustomOperation("StickyRight")>] member inline _.StickyRight ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("StickyRight" =>>> x)
    /// The template used to display this column's filter.
    [<CustomOperation("FilterTemplate")>] member inline _.FilterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.FilterContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FilterTemplate", fn)
    /// The operators to use for this column's filter.
    [<CustomOperation("FilterOperators")>] member inline _.FilterOperators ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<System.String>) = render ==> ("FilterOperators" => x)
    /// The culture used to parse, filter, and display values in this column.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// The CSS classes to apply to the cell.
    [<CustomOperation("CellClass")>] member inline _.CellClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CellClass" => x)
    /// The function used to determine CSS classes for this cell.
    [<CustomOperation("CellClassFunc")>] member inline _.CellClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CellClassFunc" => (System.Func<'T, System.String>fn))
    /// The CSS styles to apply to this cell.
    [<CustomOperation("CellStyle")>] member inline _.CellStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CellStyle" => x)
    /// The function which calculates CSS styles for this cell.
    [<CustomOperation("CellStyleFunc")>] member inline _.CellStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CellStyleFunc" => (System.Func<'T, System.String>fn))
    /// Allows editing for this cell.
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Editable" =>>> true)
    /// Allows editing for this cell.
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Editable" =>>> x)
    /// The template for editing values in this cell.
    [<CustomOperation("EditTemplate")>] member inline _.EditTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("EditTemplate", fn)
    /// The CSS classes applied to this column's footer.
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    /// The function which calculates CSS classes for this column's footer.
    [<CustomOperation("FooterClassFunc")>] member inline _.FooterClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FooterClassFunc" => (System.Func<System.Collections.Generic.IEnumerable<'T>, System.String>fn))
    /// The CSS styles to apply to this column's footer.
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    /// The function which calculates CSS styles for this column's footer.
    [<CustomOperation("FooterStyleFunc")>] member inline _.FooterStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FooterStyleFunc" => (System.Func<System.Collections.Generic.IEnumerable<'T>, System.String>fn))
    /// Allows the footer to be selected.
    [<CustomOperation("EnableFooterSelection")>] member inline _.EnableFooterSelection ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("EnableFooterSelection" =>>> true)
    /// Allows the footer to be selected.
    [<CustomOperation("EnableFooterSelection")>] member inline _.EnableFooterSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("EnableFooterSelection" =>>> x)
    /// The function which calculates aggregates for this column.
    [<CustomOperation("AggregateDefinition")>] member inline _.AggregateDefinition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.AggregateDefinition<'T>) = render ==> ("AggregateDefinition" => x)

/// Represents a column in a MudDataGrid`1 associated with an object's property.
type PropertyColumnBuilder<'FunBlazorGeneric, 'T, 'TProperty when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBuilder<'FunBlazorGeneric, 'T>()
    /// The property whose values are displayed in the column.
    [<CustomOperation("Property")>] member inline _.Property ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.Expressions.Expression<System.Func<'T, 'TProperty>>) = render ==> ("Property" => x)
    /// The format applied to property values.
    [<CustomOperation("Format")>] member inline _.Format ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Format" => x)

/// Represents an additional column for a MudDataGrid`1 which isn't tied to data.
type TemplateColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBuilder<'FunBlazorGeneric, 'T>()
    /// Allows filters to be used on this column.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Filterable" => x)
    /// Sorts values in this column.
    [<CustomOperation("Sortable")>] member inline _.Sortable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Sortable" => x)
    /// Allows this column to be reordered via drag-and-drop operations.
    [<CustomOperation("DragAndDropEnabled")>] member inline _.DragAndDropEnabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DragAndDropEnabled" => x)
    /// Allows this column's width to be changed.
    [<CustomOperation("Resizable")>] member inline _.Resizable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Resizable" => x)
    /// Shows options for this column.
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ShowColumnOptions" => x)

type DataGridGroupRowBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataGrid")>] member inline _.DataGrid ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudDataGrid<'T>) = render ==> ("DataGrid" => x)
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, 'T, System.Int32> -> unit) = render ==> html.callback("RowClick", fn)
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, 'T, System.Int32> -> Task<unit>) = render ==> html.callbackTask("RowClick", fn)
    [<CustomOperation("ContextRowClick")>] member inline _.ContextRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, 'T, System.Int32> -> unit) = render ==> html.callback("ContextRowClick", fn)
    [<CustomOperation("ContextRowClick")>] member inline _.ContextRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, 'T, System.Int32> -> Task<unit>) = render ==> html.callbackTask("ContextRowClick", fn)
    /// The definition for this grouping level
    [<CustomOperation("GroupDefinition")>] member inline _.GroupDefinition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.GroupDefinition<'T>) = render ==> ("GroupDefinition" => x)
    /// The groups and items within this grouping.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.IGrouping<System.Object, 'T>) = render ==> ("Items" => x)
    [<CustomOperation("GroupClass")>] member inline _.GroupClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupClass" => x)
    [<CustomOperation("GroupStyle")>] member inline _.GroupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupStyle" => x)
    [<CustomOperation("GroupClassFunc")>] member inline _.GroupClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupClassFunc" => (System.Func<MudBlazor.GroupDefinition<'T>, System.String>fn))
    [<CustomOperation("GroupStyleFunc")>] member inline _.GroupStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupStyleFunc" => (System.Func<MudBlazor.GroupDefinition<'T>, System.String>fn))
    [<CustomOperation("StyleClass")>] member inline _.StyleClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StyleClass" => x)

type DataGridVirtualizeRowBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DataGrid")>] member inline _.DataGrid ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudDataGrid<'T>) = render ==> ("DataGrid" => x)
    [<CustomOperation("GroupedItems")>] member inline _.GroupedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.IGrouping<System.Object, 'T>) = render ==> ("GroupedItems" => x)
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, 'T, System.Int32> -> unit) = render ==> html.callback("RowClick", fn)
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, 'T, System.Int32> -> Task<unit>) = render ==> html.callbackTask("RowClick", fn)
    [<CustomOperation("ContextRowClick")>] member inline _.ContextRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, 'T, System.Int32> -> unit) = render ==> html.callback("ContextRowClick", fn)
    [<CustomOperation("ContextRowClick")>] member inline _.ContextRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.ValueTuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, 'T, System.Int32> -> Task<unit>) = render ==> html.callbackTask("ContextRowClick", fn)

/// Represents a column filter shown when FilterMode is ColumnFilterRow.
type FilterHeaderCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The column associated with this filter cell.
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Column<'T>) = render ==> ("Column" => x)

/// Represents a cell displayed at the bottom of a column.
type FooterCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The column related to this footer cell.
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Column<'T>) = render ==> ("Column" => x)
    /// The current values related to this footer cell.
    [<CustomOperation("CurrentItems")>] member inline _.CurrentItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("CurrentItems" => x)

/// Represents a cell displayed at the top of a MudDataGrid`1 column.
type HeaderCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The column associated with this header cell.
    [<CustomOperation("Column")>] member inline _.Column ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Column<'T>) = render ==> ("Column" => x)
    /// The direction to sort values in this column.
    [<CustomOperation("SortDirection")>] member inline _.SortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("SortDirection" => x)

/// Represents a column in a MudDataGrid`1 which can be expanded to show additional information.
type HierarchyColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The icon to display for the close button.
    [<CustomOperation("ClosedIcon")>] member inline _.ClosedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ClosedIcon" => x)
    /// The icon to display for the open button.
    [<CustomOperation("OpenIcon")>] member inline _.OpenIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("OpenIcon" => x)
    /// The size of the open and close icons.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// The function which determines whether buttons are disabled.
    [<CustomOperation("ButtonDisabledFunc")>] member inline _.ButtonDisabledFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ButtonDisabledFunc" => (System.Func<'T, System.Boolean>fn))
    /// Allows this column to be reordered via drag-and-drop operations.
    [<CustomOperation("DragAndDropEnabled")>] member inline _.DragAndDropEnabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DragAndDropEnabled" => x)
    /// Allows this column to be hidden.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Hideable" => x)
    /// Hides this column.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hidden" =>>> true)
    /// Hides this column.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hidden" =>>> x)
    /// Hides this column.
    [<CustomOperation("Hidden'")>] member inline _.Hidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Hidden", valueFn)
    /// Occurs when the Hidden property has changed.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("HiddenChanged", fn)
    /// Occurs when the Hidden property has changed.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("HiddenChanged", fn)
    /// Whether or not to show a button in the header to expand/collapse all columns.
    [<CustomOperation("EnableHeaderToggle")>] member inline _.EnableHeaderToggle ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("EnableHeaderToggle" =>>> true)
    /// Whether or not to show a button in the header to expand/collapse all columns.
    [<CustomOperation("EnableHeaderToggle")>] member inline _.EnableHeaderToggle ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("EnableHeaderToggle" =>>> x)
    /// The CSS class applied to the header.
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// The function which calculates CSS classes for the header.
    [<CustomOperation("HeaderClassFunc")>] member inline _.HeaderClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderClassFunc" => (System.Func<System.Collections.Generic.IEnumerable<'T>, System.String>fn))
    /// The CSS style applied to this column's header.
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    /// The function which calculates CSS styles for the header.
    [<CustomOperation("HeaderStyleFunc")>] member inline _.HeaderStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("HeaderStyleFunc" => (System.Func<System.Collections.Generic.IEnumerable<'T>, System.String>fn))
    /// The template used to display this column's header.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.HeaderContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    /// The template used to display this column's value cells.
    [<CustomOperation("CellTemplate")>] member inline _.CellTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("CellTemplate", fn)
    /// The function which determines whether the row should be initially expanded.
    [<CustomOperation("InitiallyExpandedFunc")>] member inline _.InitiallyExpandedFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("InitiallyExpandedFunc" => (System.Func<'T, System.Boolean>fn))

/// Represents a sortable, filterable data grid with multiselection and pagination.
type MudDataGridBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Occurs when the SelectedItem has changed.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("SelectedItemChanged", fn)
    /// Occurs when the SelectedItem has changed.
    [<CustomOperation("SelectedItemChanged")>] member inline _.SelectedItemChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedItemChanged", fn)
    /// Occurs when the SelectedItems have changed.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.HashSet<'T> -> unit) = render ==> html.callback("SelectedItemsChanged", fn)
    /// Occurs when the SelectedItems have changed.
    [<CustomOperation("SelectedItemsChanged")>] member inline _.SelectedItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.HashSet<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedItemsChanged", fn)
    /// Occurs when a row has been clicked.
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.DataGridRowClickEventArgs<'T> -> unit) = render ==> html.callback("RowClick", fn)
    /// Occurs when a row has been clicked.
    [<CustomOperation("RowClick")>] member inline _.RowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.DataGridRowClickEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("RowClick", fn)
    /// Occurs when a row has been right-clicked.
    [<CustomOperation("RowContextMenuClick")>] member inline _.RowContextMenuClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.DataGridRowClickEventArgs<'T> -> unit) = render ==> html.callback("RowContextMenuClick", fn)
    /// Occurs when a row has been right-clicked.
    [<CustomOperation("RowContextMenuClick")>] member inline _.RowContextMenuClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.DataGridRowClickEventArgs<'T> -> Task<unit>) = render ==> html.callbackTask("RowContextMenuClick", fn)
    /// Occurs when edit mode begins for an item.
    [<CustomOperation("StartedEditingItem")>] member inline _.StartedEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("StartedEditingItem", fn)
    /// Occurs when edit mode begins for an item.
    [<CustomOperation("StartedEditingItem")>] member inline _.StartedEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("StartedEditingItem", fn)
    /// Occurs when editing of an item has been canceled.
    [<CustomOperation("CanceledEditingItem")>] member inline _.CanceledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("CanceledEditingItem", fn)
    /// Occurs when editing of an item has been canceled.
    [<CustomOperation("CanceledEditingItem")>] member inline _.CanceledEditingItem ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("CanceledEditingItem", fn)
    /// Occurs when the user saved changes to an item.
    [<CustomOperation("CommittedItemChanges")>] member inline _.CommittedItemChanges ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("CommittedItemChanges", fn)
    /// Occurs when the user saved changes to an item.
    [<CustomOperation("CommittedItemChanges")>] member inline _.CommittedItemChanges ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("CommittedItemChanges", fn)
    /// Occurs when a field changes in the edit dialog.
    [<CustomOperation("FormFieldChanged")>] member inline _.FormFieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Utilities.FormFieldChangedEventArgs -> unit) = render ==> html.callback("FormFieldChanged", fn)
    /// Occurs when a field changes in the edit dialog.
    [<CustomOperation("FormFieldChanged")>] member inline _.FormFieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Utilities.FormFieldChangedEventArgs -> Task<unit>) = render ==> html.callbackTask("FormFieldChanged", fn)
    /// Allows columns to be reordered via the columns panel.
    [<CustomOperation("ColumnsPanelReordering")>] member inline _.ColumnsPanelReordering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ColumnsPanelReordering" =>>> true)
    /// Allows columns to be reordered via the columns panel.
    [<CustomOperation("ColumnsPanelReordering")>] member inline _.ColumnsPanelReordering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ColumnsPanelReordering" =>>> x)
    /// Allows columns to be reordered via drag-and-drop.
    [<CustomOperation("DragDropColumnReordering")>] member inline _.DragDropColumnReordering ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DragDropColumnReordering" =>>> true)
    /// Allows columns to be reordered via drag-and-drop.
    [<CustomOperation("DragDropColumnReordering")>] member inline _.DragDropColumnReordering ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DragDropColumnReordering" =>>> x)
    /// The icon displayed when hovering over a draggable column.
    [<CustomOperation("DragIndicatorIcon")>] member inline _.DragIndicatorIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DragIndicatorIcon" => x)
    /// The size of the icon displayed when hovering over a draggable column.
    [<CustomOperation("DragIndicatorSize")>] member inline _.DragIndicatorSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("DragIndicatorSize" => x)
    /// The CSS class applied to columns where a dragged column can be dropped.
    [<CustomOperation("DropAllowedClass")>] member inline _.DropAllowedClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropAllowedClass" => x)
    /// The CSS class applied to columns where a dragged column cannot be dropped.
    [<CustomOperation("DropNotAllowedClass")>] member inline _.DropNotAllowedClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DropNotAllowedClass" => x)
    /// Shows drop locations for columns even when not currently dragging a column.
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ApplyDropClassesOnDragStarted" =>>> true)
    /// Shows drop locations for columns even when not currently dragging a column.
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ApplyDropClassesOnDragStarted" =>>> x)
    /// Sorts data in the grid.
    [<CustomOperation("SortMode")>] member inline _.SortMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortMode) = render ==> ("SortMode" => x)
    /// Allows filtering of data in this grid.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Filterable" =>>> true)
    /// Allows filtering of data in this grid.
    [<CustomOperation("Filterable")>] member inline _.Filterable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Filterable" =>>> x)
    /// Allows columns to be hidden.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hideable" =>>> true)
    /// Allows columns to be hidden.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hideable" =>>> x)
    /// Shows options for columns.
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowColumnOptions" =>>> true)
    /// Shows options for columns.
    [<CustomOperation("ShowColumnOptions")>] member inline _.ShowColumnOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowColumnOptions" =>>> x)
    /// The breakpoint at which the grid switches to mobile layout.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Disables rounded corners.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Disables rounded corners.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Shows an outline around this grid.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Shows an outline around this grid.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)
    /// Shows left and right borders for each column.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Bordered" =>>> true)
    /// Shows left and right borders for each column.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Bordered" =>>> x)
    /// The content for any column groupings.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ColGroup", fragment)
    /// The content for any column groupings.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ColGroup", fragment { yield! fragments })
    /// The content for any column groupings.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ColGroup", html.text x)
    /// The content for any column groupings.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ColGroup", html.text x)
    /// The content for any column groupings.
    [<CustomOperation("ColGroup")>] member inline _.ColGroup ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ColGroup", html.text x)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Highlights rows when hovering over them.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hover" =>>> true)
    /// Highlights rows when hovering over them.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hover" =>>> x)
    /// Shows alternating row styles.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Striped" =>>> true)
    /// Shows alternating row styles.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Striped" =>>> x)
    /// Fixes the header in place even as the grid is scrolled.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FixedHeader" =>>> true)
    /// Fixes the header in place even as the grid is scrolled.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FixedHeader" =>>> x)
    /// Fixes the footer in place even as the grid is scrolled.
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FixedFooter" =>>> true)
    /// Fixes the footer in place even as the grid is scrolled.
    [<CustomOperation("FixedFooter")>] member inline _.FixedFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FixedFooter" =>>> x)
    /// Shows icons for each column filter.
    [<CustomOperation("ShowFilterIcons")>] member inline _.ShowFilterIcons ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowFilterIcons" =>>> true)
    /// Shows icons for each column filter.
    [<CustomOperation("ShowFilterIcons")>] member inline _.ShowFilterIcons ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowFilterIcons" =>>> x)
    /// The way that this grid filters data.
    [<CustomOperation("FilterMode")>] member inline _.FilterMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DataGridFilterMode) = render ==> ("FilterMode" => x)
    /// The case sensitivity setting for columns with string values.
    [<CustomOperation("FilterCaseSensitivity")>] member inline _.FilterCaseSensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DataGridFilterCaseSensitivity) = render ==> ("FilterCaseSensitivity" => x)
    /// The template used to display each filter.
    [<CustomOperation("FilterTemplate")>] member inline _.FilterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudDataGrid<'T> -> NodeRenderFragment) = render ==> html.renderFragment("FilterTemplate", fn)
    /// The filter definitions for all columns.
    [<CustomOperation("FilterDefinitions")>] member inline _.FilterDefinitions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.List<MudBlazor.IFilterDefinition<'T>>) = render ==> ("FilterDefinitions" => x)
    /// The sort definitions for all columns.
    [<CustomOperation("SortDefinitions")>] member inline _.SortDefinitions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.Dictionary<System.String, MudBlazor.SortDefinition<'T>>) = render ==> ("SortDefinitions" => x)
    /// Renders only visible items instead of all items.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Virtualize" =>>> true)
    /// Renders only visible items instead of all items.
    [<CustomOperation("Virtualize")>] member inline _.Virtualize ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Virtualize" =>>> x)
    /// A RenderFragment that will be used as a placeholder when the Virtualize component is asynchronously loading data.
    /// This placeholder is displayed for each item in the data source that is yet to be loaded. Useful for presenting a loading indicator 
    /// in a data grid row while the actual data is being fetched from the server.
    [<CustomOperation("RowLoadingContent")>] member inline _.RowLoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("RowLoadingContent", fragment)
    /// A RenderFragment that will be used as a placeholder when the Virtualize component is asynchronously loading data.
    /// This placeholder is displayed for each item in the data source that is yet to be loaded. Useful for presenting a loading indicator 
    /// in a data grid row while the actual data is being fetched from the server.
    [<CustomOperation("RowLoadingContent")>] member inline _.RowLoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("RowLoadingContent", fragment { yield! fragments })
    /// A RenderFragment that will be used as a placeholder when the Virtualize component is asynchronously loading data.
    /// This placeholder is displayed for each item in the data source that is yet to be loaded. Useful for presenting a loading indicator 
    /// in a data grid row while the actual data is being fetched from the server.
    [<CustomOperation("RowLoadingContent")>] member inline _.RowLoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("RowLoadingContent", html.text x)
    /// A RenderFragment that will be used as a placeholder when the Virtualize component is asynchronously loading data.
    /// This placeholder is displayed for each item in the data source that is yet to be loaded. Useful for presenting a loading indicator 
    /// in a data grid row while the actual data is being fetched from the server.
    [<CustomOperation("RowLoadingContent")>] member inline _.RowLoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("RowLoadingContent", html.text x)
    /// A RenderFragment that will be used as a placeholder when the Virtualize component is asynchronously loading data.
    /// This placeholder is displayed for each item in the data source that is yet to be loaded. Useful for presenting a loading indicator 
    /// in a data grid row while the actual data is being fetched from the server.
    [<CustomOperation("RowLoadingContent")>] member inline _.RowLoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("RowLoadingContent", html.text x)
    /// The number of additional items rendered outside the visible region when Virtualize is true.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// The height of each row, in pixels, when Virtualize is true.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    /// The CSS class applied to each row.
    [<CustomOperation("RowClass")>] member inline _.RowClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowClass" => x)
    /// The CSS styles applied to each row.
    [<CustomOperation("RowStyle")>] member inline _.RowStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowStyle" => x)
    /// The function which calculates CSS classes for each row.
    [<CustomOperation("RowClassFunc")>] member inline _.RowClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// The function which calculates CSS styles for each row.
    [<CustomOperation("RowStyleFunc")>] member inline _.RowStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn))
    /// Allows selection of more than one row.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MultiSelection" =>>> true)
    /// Allows selection of more than one row.
    [<CustomOperation("MultiSelection")>] member inline _.MultiSelection ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MultiSelection" =>>> x)
    /// Toggles the row checkbox when the row is clicked.
    [<CustomOperation("SelectOnRowClick")>] member inline _.SelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectOnRowClick" =>>> true)
    /// Toggles the row checkbox when the row is clicked.
    [<CustomOperation("SelectOnRowClick")>] member inline _.SelectOnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectOnRowClick" =>>> x)
    /// Controls how cell values are edited.
    [<CustomOperation("EditMode")>] member inline _.EditMode ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.DataGridEditMode>) = render ==> ("EditMode" => x)
    /// The behavior which begins editing a cell when EditMode is Form.
    [<CustomOperation("EditTrigger")>] member inline _.EditTrigger ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.DataGridEditTrigger>) = render ==> ("EditTrigger" => x)
    /// Any options applied to the edit dialog when EditMode is Form.
    [<CustomOperation("EditDialogOptions")>] member inline _.EditDialogOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("EditDialogOptions" => x)
    /// The technique used to copy items for editing.
    [<CustomOperation("CloneStrategy")>] member inline _.CloneStrategy ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Utilities.Clone.ICloneStrategy<'T>) = render ==> ("CloneStrategy" => x)
    /// The data for this grid when ServerData is not set.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    /// Shows a loading animation while querying data.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Loading" =>>> true)
    /// Shows a loading animation while querying data.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Loading" =>>> x)
    /// Shows a cancel button during inline editing when EditMode is Cell.
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CanCancelEdit" =>>> true)
    /// Shows a cancel button during inline editing when EditMode is Cell.
    [<CustomOperation("CanCancelEdit")>] member inline _.CanCancelEdit ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CanCancelEdit" =>>> x)
    /// The color of the loading progress indicator while Loading is true.
    [<CustomOperation("LoadingProgressColor")>] member inline _.LoadingProgressColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingProgressColor" => x)
    /// Any custom content to show in this grid's toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ToolBarContent", fragment)
    /// Any custom content to show in this grid's toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ToolBarContent", fragment { yield! fragments })
    /// Any custom content to show in this grid's toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Any custom content to show in this grid's toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Any custom content to show in this grid's toolbar.
    [<CustomOperation("ToolBarContent")>] member inline _.ToolBarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ToolBarContent", html.text x)
    /// Shows a horizontal scrollbar.
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HorizontalScrollbar" =>>> true)
    /// Shows a horizontal scrollbar.
    [<CustomOperation("HorizontalScrollbar")>] member inline _.HorizontalScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HorizontalScrollbar" =>>> x)
    /// The column resizing behavior for this grid.
    [<CustomOperation("ColumnResizeMode")>] member inline _.ColumnResizeMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ResizeMode) = render ==> ("ColumnResizeMode" => x)
    /// The CSS classes applied to the grid header.
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// The height of this grid.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// The CSS classes applied to the grid footer.
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    /// The function which determines visibility of each item in this grid.
    [<CustomOperation("QuickFilter")>] member inline _.QuickFilter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("QuickFilter" => (System.Func<'T, System.Boolean>fn))
    /// Any custom content for this grid's header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Header", fragment)
    /// Any custom content for this grid's header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Header", fragment { yield! fragments })
    /// Any custom content for this grid's header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Header", html.text x)
    /// Any custom content for this grid's header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Header", html.text x)
    /// Any custom content for this grid's header.
    [<CustomOperation("Header")>] member inline _.Header ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Header", html.text x)
    /// Any custom content for this grid's columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Columns", fragment)
    /// Any custom content for this grid's columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Columns", fragment { yield! fragments })
    /// Any custom content for this grid's columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Columns", html.text x)
    /// Any custom content for this grid's columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Columns", html.text x)
    /// Any custom content for this grid's columns.
    [<CustomOperation("Columns")>] member inline _.Columns ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Columns", html.text x)
    /// The culture used to format numeric and date values.  Can be overridden by Culture.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// The content shown for each cell.
    [<CustomOperation("ChildRowContent")>] member inline _.ChildRowContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.CellContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("ChildRowContent", fn)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NoRecordsContent", fragment { yield! fragments })
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// The content shown while Loading is true.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("LoadingContent", fragment)
    /// The content shown while Loading is true.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("LoadingContent", fragment { yield! fragments })
    /// The content shown while Loading is true.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// The content shown while Loading is true.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// The content shown while Loading is true.
    [<CustomOperation("LoadingContent")>] member inline _.LoadingContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("LoadingContent", html.text x)
    /// The content shown for pagination.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("PagerContent", fragment)
    /// The content shown for pagination.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("PagerContent", fragment { yield! fragments })
    /// The content shown for pagination.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("PagerContent", html.text x)
    /// The content shown for pagination.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("PagerContent", html.text x)
    /// The content shown for pagination.
    [<CustomOperation("PagerContent")>] member inline _.PagerContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("PagerContent", html.text x)
    /// The function which gets data for this grid.
    [<CustomOperation("ServerData")>] member inline _.ServerData ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<MudBlazor.GridState<'T>, System.Threading.Tasks.Task<MudBlazor.GridData<'T>>>fn))
    /// The function which gets data for this grid.
    [<CustomOperation("VirtualizeServerData")>] member inline _.VirtualizeServerData ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("VirtualizeServerData" => (System.Func<MudBlazor.GridStateVirtualize<'T>, System.Threading.CancellationToken, System.Threading.Tasks.Task<MudBlazor.GridData<'T>>>fn))
    /// The number of rows displayed for each page.
    [<CustomOperation("RowsPerPage")>] member inline _.RowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("RowsPerPage" => x)
    /// The number of rows displayed for each page.
    [<CustomOperation("RowsPerPage'")>] member inline _.RowsPerPage' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("RowsPerPage", valueFn)
    /// Occurs when the RowsPerPage has changed.
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("RowsPerPageChanged", fn)
    /// Occurs when the RowsPerPage has changed.
    [<CustomOperation("RowsPerPageChanged")>] member inline _.RowsPerPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("RowsPerPageChanged", fn)
    /// The current page being displayed.
    [<CustomOperation("CurrentPage")>] member inline _.CurrentPage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("CurrentPage" => x)
    /// The current page being displayed.
    [<CustomOperation("CurrentPage'")>] member inline _.CurrentPage' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("CurrentPage", valueFn)
    /// Occurs when CurrentPage has changed.
    [<CustomOperation("CurrentPageChanged")>] member inline _.CurrentPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("CurrentPageChanged", fn)
    /// Occurs when CurrentPage has changed.
    [<CustomOperation("CurrentPageChanged")>] member inline _.CurrentPageChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("CurrentPageChanged", fn)
    /// Prevents values from being edited.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents values from being edited.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// The currently selected rows when MultiSelection is true.
    [<CustomOperation("SelectedItems")>] member inline _.SelectedItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.HashSet<'T>) = render ==> ("SelectedItems" => x)
    /// The currently selected rows when MultiSelection is true.
    [<CustomOperation("SelectedItems'")>] member inline _.SelectedItems' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = render ==> html.bind("SelectedItems", valueFn)
    /// The currently selected row when MultiSelection is false.
    [<CustomOperation("SelectedItem")>] member inline _.SelectedItem ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedItem" => x)
    /// The currently selected row when MultiSelection is false.
    [<CustomOperation("SelectedItem'")>] member inline _.SelectedItem' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedItem", valueFn)
    /// Allows grouping of columns in this grid.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Groupable" =>>> true)
    /// Allows grouping of columns in this grid.
    [<CustomOperation("Groupable")>] member inline _.Groupable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Groupable" =>>> x)
    /// Expands grouped columns by default. Overrides GroupExpanded
    [<CustomOperation("GroupExpanded")>] member inline _.GroupExpanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GroupExpanded" =>>> true)
    /// Expands grouped columns by default. Overrides GroupExpanded
    [<CustomOperation("GroupExpanded")>] member inline _.GroupExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GroupExpanded" =>>> x)
    /// The CSS classes applied to column groups.
    [<CustomOperation("GroupClass")>] member inline _.GroupClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupClass" => x)
    /// The CSS styles applied to column groups.
    [<CustomOperation("GroupStyle")>] member inline _.GroupStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupStyle" => x)
    /// The function which determines CSS classes for column groups.
    [<CustomOperation("GroupClassFunc")>] member inline _.GroupClassFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupClassFunc" => (System.Func<MudBlazor.GroupDefinition<'T>, System.String>fn))
    /// The function which determines CSS styles for column groups.
    [<CustomOperation("GroupStyleFunc")>] member inline _.GroupStyleFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("GroupStyleFunc" => (System.Func<MudBlazor.GroupDefinition<'T>, System.String>fn))
    /// Shows the settings icon in the grid header.
    [<CustomOperation("ShowMenuIcon")>] member inline _.ShowMenuIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowMenuIcon" =>>> true)
    /// Shows the settings icon in the grid header.
    [<CustomOperation("ShowMenuIcon")>] member inline _.ShowMenuIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowMenuIcon" =>>> x)
    /// Ensures the user can only expand one Hierarchy row at a time. This only has an effect if you are using a Hierarchy column.
    [<CustomOperation("ExpandSingleRow")>] member inline _.ExpandSingleRow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ExpandSingleRow" =>>> true)
    /// Ensures the user can only expand one Hierarchy row at a time. This only has an effect if you are using a Hierarchy column.
    [<CustomOperation("ExpandSingleRow")>] member inline _.ExpandSingleRow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ExpandSingleRow" =>>> x)
    /// The comparer used to determine row selection.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// The validator which validates values in each row.
    [<CustomOperation("Validator")>] member inline _.Validator ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Interfaces.IForm) = render ==> ("Validator" => x)

/// Represents a pager for navigating pages of a MudDataGrid`1.
type MudDataGridPagerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Shows the page-size drop-down list.
    [<CustomOperation("PageSizeSelector")>] member inline _.PageSizeSelector ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PageSizeSelector" =>>> true)
    /// Shows the page-size drop-down list.
    [<CustomOperation("PageSizeSelector")>] member inline _.PageSizeSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PageSizeSelector" =>>> x)
    /// Disables the back button, forward button, and page-size drop-down list.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Disables the back button, forward button, and page-size drop-down list.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The allowed page sizes when PageSizeSelector is true.  Defaults to 10, 25, 50, 100.
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    /// The format for the first item, last item, and number of total items.
    [<CustomOperation("InfoFormat")>] member inline _.InfoFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InfoFormat" => x)
    /// The text to show for the "Rows per page:" label.
    [<CustomOperation("RowsPerPageString")>] member inline _.RowsPerPageString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowsPerPageString" => x)
    /// Shows the pagination buttons.
    [<CustomOperation("ShowNavigation")>] member inline _.ShowNavigation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowNavigation" =>>> true)
    /// Shows the pagination buttons.
    [<CustomOperation("ShowNavigation")>] member inline _.ShowNavigation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowNavigation" =>>> x)
    /// Shows the current page number.
    [<CustomOperation("ShowPageNumber")>] member inline _.ShowPageNumber ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowPageNumber" =>>> true)
    /// Shows the current page number.
    [<CustomOperation("ShowPageNumber")>] member inline _.ShowPageNumber ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowPageNumber" =>>> x)
    /// Defines the text shown in the items per page dropdown when a user provides int.MaxValue as an option
    [<CustomOperation("AllItemsText")>] member inline _.AllItemsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AllItemsText" => x)

/// An overlay providing the user with information, a choice, or other input.
type MudDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The custom content for this dialog's title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleContent", fragment)
    /// The custom content for this dialog's title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    /// The custom content for this dialog's title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The custom content for this dialog's title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The custom content for this dialog's title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The main content for this dialog.
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("DialogContent", fragment)
    /// The main content for this dialog.
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("DialogContent", fragment { yield! fragments })
    /// The main content for this dialog.
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DialogContent", html.text x)
    /// The main content for this dialog.
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DialogContent", html.text x)
    /// The main content for this dialog.
    [<CustomOperation("DialogContent")>] member inline _.DialogContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DialogContent", html.text x)
    /// The custom actions for this dialog.
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("DialogActions", fragment)
    /// The custom actions for this dialog.
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("DialogActions", fragment { yield! fragments })
    /// The custom actions for this dialog.
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("DialogActions", html.text x)
    /// The custom actions for this dialog.
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("DialogActions", html.text x)
    /// The custom actions for this dialog.
    [<CustomOperation("DialogActions")>] member inline _.DialogActions ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("DialogActions", html.text x)
    /// The default options for this dialog.
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("Options" => x)
    /// Occurs when the area outside the dialog has been clicked if BackdropClick is true.
    [<CustomOperation("OnBackdropClick")>] member inline _.OnBackdropClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnBackdropClick", fn)
    /// Occurs when the area outside the dialog has been clicked if BackdropClick is true.
    [<CustomOperation("OnBackdropClick")>] member inline _.OnBackdropClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnBackdropClick", fn)
    /// Occurs when a key has been pressed down.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyDown", fn)
    /// Occurs when a key has been pressed down.
    [<CustomOperation("OnKeyDown")>] member inline _.OnKeyDown ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyDown", fn)
    /// Occurs when a pressed key has been released.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> unit) = render ==> html.callback("OnKeyUp", fn)
    /// Occurs when a pressed key has been released.
    [<CustomOperation("OnKeyUp")>] member inline _.OnKeyUp ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.KeyboardEventArgs -> Task<unit>) = render ==> html.callbackTask("OnKeyUp", fn)
    /// Adds padding to the sides of this dialog.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Gutters" =>>> true)
    /// Adds padding to the sides of this dialog.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Gutters" =>>> x)
    /// The CSS classes to apply to the title.
    [<CustomOperation("TitleClass")>] member inline _.TitleClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TitleClass" => x)
    /// The CSS classes applied to the main dialog content.
    [<CustomOperation("ContentClass")>] member inline _.ContentClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContentClass" => x)
    /// The CSS classes applied to the action buttons content.
    [<CustomOperation("ActionsClass")>] member inline _.ActionsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActionsClass" => x)
    /// The CSS styles applied to the main dialog content.
    [<CustomOperation("ContentStyle")>] member inline _.ContentStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)
    /// For inline dialogs, shows this dialog.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// For inline dialogs, shows this dialog.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// For inline dialogs, shows this dialog.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// Occurs when Visible has changed.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    /// Occurs when Visible has changed.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)
    /// The element which will receive focus when this dialog is shown.
    [<CustomOperation("DefaultFocus")>] member inline _.DefaultFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DefaultFocus) = render ==> ("DefaultFocus" => x)

/// An instance of a MudDialog.
type MudDialogContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The options used for this dialog.
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DialogOptions) = render ==> ("Options" => x)
    /// The text displayed at the top of this dialog if TitleContent is not set.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The custom content at the top of this dialog.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleContent", fragment)
    /// The custom content at the top of this dialog.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    /// The custom content at the top of this dialog.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The custom content at the top of this dialog.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The custom content at the top of this dialog.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The content within this dialog.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Content", fragment)
    /// The content within this dialog.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    /// The content within this dialog.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    /// The content within this dialog.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    /// The content within this dialog.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    /// The unique ID for this instance.
    [<CustomOperation("Id")>] member inline _.Id ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Guid) = render ==> ("Id" => x)
    /// The custom icon displayed in the upper-right corner for closing this dialog.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)

/// A thin line that groups content in lists and layouts.
type MudDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Uses an absolute position for this divider.
    [<CustomOperation("Absolute")>] member inline _.Absolute ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Absolute" =>>> true)
    /// Uses an absolute position for this divider.
    [<CustomOperation("Absolute")>] member inline _.Absolute ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Absolute" =>>> x)
    /// For vertical dividers, uses the correct height within a flex container.
    [<CustomOperation("FlexItem")>] member inline _.FlexItem ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FlexItem" =>>> true)
    /// For vertical dividers, uses the correct height within a flex container.
    [<CustomOperation("FlexItem")>] member inline _.FlexItem ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FlexItem" =>>> x)
    /// Uses a lighter color.
    [<CustomOperation("Light")>] member inline _.Light ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Light" =>>> true)
    /// Uses a lighter color.
    [<CustomOperation("Light")>] member inline _.Light ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Light" =>>> x)
    /// Displays the divider vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Vertical" =>>> true)
    /// Displays the divider vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Vertical" =>>> x)
    /// The type of divider to display.
    [<CustomOperation("DividerType")>] member inline _.DividerType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DividerType) = render ==> ("DividerType" => x)

/// Represents a navigation panel docked to the side of the page.
type MudDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Shows the drawer in the same position even if the page is scrolled.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Fixed" =>>> true)
    /// Shows the drawer in the same position even if the page is scrolled.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Fixed" =>>> x)
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// The edge of the container that the drawer will appear.
    [<CustomOperation("Anchor")>] member inline _.Anchor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Anchor) = render ==> ("Anchor" => x)
    /// The color of the drawer.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The display variant of this drawer.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DrawerVariant) = render ==> ("Variant" => x)
    /// For responsive and temporary drawers, darkens the screen with an overlay when displaying this drawer.
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Overlay" =>>> true)
    /// For responsive and temporary drawers, darkens the screen with an overlay when displaying this drawer.
    [<CustomOperation("Overlay")>] member inline _.Overlay ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Overlay" =>>> x)
    /// Sets a value indicating whether the overlay should automatically close when clicked.
    [<CustomOperation("OverlayAutoClose")>] member inline _.OverlayAutoClose ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OverlayAutoClose" =>>> true)
    /// Sets a value indicating whether the overlay should automatically close when clicked.
    [<CustomOperation("OverlayAutoClose")>] member inline _.OverlayAutoClose ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OverlayAutoClose" =>>> x)
    /// For mini drawers, opens this drawer when the pointer hovers over it.
    [<CustomOperation("OpenMiniOnHover")>] member inline _.OpenMiniOnHover ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OpenMiniOnHover" =>>> true)
    /// For mini drawers, opens this drawer when the pointer hovers over it.
    [<CustomOperation("OpenMiniOnHover")>] member inline _.OpenMiniOnHover ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OpenMiniOnHover" =>>> x)
    /// The browser width at which responsive drawers are hidden.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// Displays this drawer.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Open" =>>> true)
    /// Displays this drawer.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Open" =>>> x)
    /// Displays this drawer.
    [<CustomOperation("Open'")>] member inline _.Open' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    /// Occurs when the Open value has changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OpenChanged", fn)
    /// Occurs when the Open value has changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenChanged", fn)
    /// For non-fixed or temporary drawers, the width of this drawer.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// For mini drawers, the width of this drawer.
    [<CustomOperation("MiniWidth")>] member inline _.MiniWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MiniWidth" => x)
    /// The height of this drawer.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// The position of this drawer when opened, relative to a MudAppBar when inside a MudLayout.
    [<CustomOperation("ClipMode")>] member inline _.ClipMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DrawerClipMode) = render ==> ("ClipMode" => x)

/// Represents content at the top of a MudDrawer.
type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Navigates to the index page on click.
    [<CustomOperation("LinkToIndex")>] member inline _.LinkToIndex ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("LinkToIndex" =>>> true)
    /// Navigates to the index page on click.
    [<CustomOperation("LinkToIndex")>] member inline _.LinkToIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("LinkToIndex" =>>> x)

/// A container of MudDropZone`1 components for drag-and-drop operations.
type MudDropContainerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The items that can be dragged and dropped within this container.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Items" => x)
    /// The template used to render items within a drop zone.
    [<CustomOperation("ItemRenderer")>] member inline _.ItemRenderer ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemRenderer", fn)
    /// The function which determines whether an item can be dropped within a drop zone.
    [<CustomOperation("ItemsSelector")>] member inline _.ItemsSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemsSelector" => (System.Func<'T, System.String, System.Boolean>fn))
    /// Occurs when an item has been dropped into a MudDropZone`1.
    [<CustomOperation("ItemDropped")>] member inline _.ItemDropped ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudItemDropInfo<'T> -> unit) = render ==> html.callback("ItemDropped", fn)
    /// Occurs when an item has been dropped into a MudDropZone`1.
    [<CustomOperation("ItemDropped")>] member inline _.ItemDropped ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudItemDropInfo<'T> -> Task<unit>) = render ==> html.callbackTask("ItemDropped", fn)
    /// Occurs when an item starts being dragged.
    [<CustomOperation("ItemPicked")>] member inline _.ItemPicked ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudDragAndDropItemTransaction<'T> -> unit) = render ==> html.callback("ItemPicked", fn)
    /// Occurs when an item starts being dragged.
    [<CustomOperation("ItemPicked")>] member inline _.ItemPicked ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudDragAndDropItemTransaction<'T> -> Task<unit>) = render ==> html.callbackTask("ItemPicked", fn)
    /// The function which determines whether an item can be dropped within a drop zone.
    [<CustomOperation("CanDrop")>] member inline _.CanDrop ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CanDrop" => (System.Func<'T, System.String, System.Boolean>fn))
    /// The CSS classes applied to valid drop zones.
    [<CustomOperation("CanDropClass")>] member inline _.CanDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CanDropClass" => x)
    /// The CSS classes applied to invalid drop zones.
    [<CustomOperation("NoDropClass")>] member inline _.NoDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoDropClass" => x)
    /// Applies either CanDropClass or NoDropClass to drop zones during a drag-and-drop transaction.
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ApplyDropClassesOnDragStarted" =>>> true)
    /// Applies either CanDropClass or NoDropClass to drop zones during a drag-and-drop transaction.
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ApplyDropClassesOnDragStarted" =>>> x)
    /// The function which determines whether an item cannot be dragged.
    [<CustomOperation("ItemDisabled")>] member inline _.ItemDisabled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemDisabled" => (System.Func<'T, System.Boolean>fn))
    /// The CSS classes applied to disabled drop items.
    [<CustomOperation("DisabledClass")>] member inline _.DisabledClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledClass" => x)
    /// The CSS classes applied to drop zones during a drag-and-drop operation.
    [<CustomOperation("DraggingClass")>] member inline _.DraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DraggingClass" => x)
    /// The CSS classes applied to items during a drag-and-drop operation.
    [<CustomOperation("ItemDraggingClass")>] member inline _.ItemDraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ItemDraggingClass" => x)
    /// The function which determines the CSS classes for each item.
    [<CustomOperation("ItemsClassSelector")>] member inline _.ItemsClassSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemsClassSelector" => (System.Func<'T, System.String, System.String>fn))

/// A location which can participate in a drag-and-drop operation.
type MudDropZoneBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The unique identifier for this drop zone.
    [<CustomOperation("Identifier")>] member inline _.Identifier ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Identifier" => x)
    /// The template used to render items within this drop zone.
    [<CustomOperation("ItemRenderer")>] member inline _.ItemRenderer ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ItemRenderer", fn)
    /// The function which determines whether an item can be dropped within this drop zone.
    [<CustomOperation("ItemsSelector")>] member inline _.ItemsSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemsSelector" => (System.Func<'T, System.Boolean>fn))
    /// The function which determines whether an item can be dropped within a drop zone.
    [<CustomOperation("CanDrop")>] member inline _.CanDrop ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("CanDrop" => (System.Func<'T, System.Boolean>fn))
    /// The CSS classes applied to valid drop zones.
    [<CustomOperation("CanDropClass")>] member inline _.CanDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CanDropClass" => x)
    /// The CSS classes applied to invalid drop zones.
    [<CustomOperation("NoDropClass")>] member inline _.NoDropClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoDropClass" => x)
    /// Applies either CanDropClass or NoDropClass to drop zones during a drag-and-drop transaction.
    [<CustomOperation("ApplyDropClassesOnDragStarted")>] member inline _.ApplyDropClassesOnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("ApplyDropClassesOnDragStarted" => x)
    /// The function which determines whether an item cannot be dragged.
    [<CustomOperation("ItemDisabled")>] member inline _.ItemDisabled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemDisabled" => (System.Func<'T, System.Boolean>fn))
    /// The CSS classes applied to disabled drop items.
    [<CustomOperation("DisabledClass")>] member inline _.DisabledClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledClass" => x)
    /// The CSS classes applied to drop zones during a drag-and-drop operation.
    [<CustomOperation("DraggingClass")>] member inline _.DraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DraggingClass" => x)
    /// The CSS classes applied to items during a drag-and-drop operation.
    [<CustomOperation("ItemDraggingClass")>] member inline _.ItemDraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ItemDraggingClass" => x)
    /// The function which determines the CSS classes for each item.
    [<CustomOperation("ItemsClassSelector")>] member inline _.ItemsClassSelector ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ItemsClassSelector" => (System.Func<'T, System.String>fn))
    /// Allows items to be reordered within a zone.
    [<CustomOperation("AllowReorder")>] member inline _.AllowReorder ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AllowReorder" =>>> true)
    /// Allows items to be reordered within a zone.
    [<CustomOperation("AllowReorder")>] member inline _.AllowReorder ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AllowReorder" =>>> x)
    /// Allows this zone to only receive dropped items.
    [<CustomOperation("OnlyZone")>] member inline _.OnlyZone ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OnlyZone" =>>> true)
    /// Allows this zone to only receive dropped items.
    [<CustomOperation("OnlyZone")>] member inline _.OnlyZone ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OnlyZone" =>>> x)

type MudDynamicDropItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The zone identifier of the corresponding drop zone
    [<CustomOperation("ZoneIdentifier")>] member inline _.ZoneIdentifier ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ZoneIdentifier" => x)
    /// the data item that is represented by this item
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Item" => x)
    /// An additional class that is applied to this element when a drag operation is in progress
    [<CustomOperation("DraggingClass")>] member inline _.DraggingClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DraggingClass" => x)
    /// An event callback set fires, when a drag operation has been started
    [<CustomOperation("OnDragStarted")>] member inline _.OnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("OnDragStarted", fn)
    /// An event callback set fires, when a drag operation has been started
    [<CustomOperation("OnDragStarted")>] member inline _.OnDragStarted ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("OnDragStarted", fn)
    /// An event callback set fires, when a drag operation has been ended. This included also a canceled transaction
    [<CustomOperation("OnDragEnded")>] member inline _.OnDragEnded ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("OnDragEnded", fn)
    /// An event callback set fires, when a drag operation has been ended. This included also a canceled transaction
    [<CustomOperation("OnDragEnded")>] member inline _.OnDragEnded ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("OnDragEnded", fn)
    /// When true, the item can't be dragged. defaults to false
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// When true, the item can't be dragged. defaults to false
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The class that is applied when disabled Disabled is set to true
    [<CustomOperation("DisabledClass")>] member inline _.DisabledClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DisabledClass" => x)
    [<CustomOperation("Index")>] member inline _.Index ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Index" => x)
    [<CustomOperation("HideContent")>] member inline _.HideContent ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideContent" =>>> true)
    [<CustomOperation("HideContent")>] member inline _.HideContent ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideContent" =>>> x)

/// A primitive component which allows dynamically changing the HTML element rendered under the hood.
type MudElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The HTML tag rendered for this element.
    [<CustomOperation("HtmlTag")>] member inline _.HtmlTag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)
    /// The ElementReference to bind to.
    [<CustomOperation("Ref")>] member inline _.Ref ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = render ==> ("Ref" => x)
    /// The ElementReference to bind to.
    [<CustomOperation("Ref'")>] member inline _.Ref' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<Microsoft.AspNetCore.Components.ElementReference> * (System.Nullable<Microsoft.AspNetCore.Components.ElementReference> -> unit)) = render ==> html.bind("Ref", valueFn)
    /// Occurs when Ref has changed.
    [<CustomOperation("RefChanged")>] member inline _.RefChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.ElementReference -> unit) = render ==> html.callback("RefChanged", fn)
    /// Occurs when Ref has changed.
    [<CustomOperation("RefChanged")>] member inline _.RefChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.ElementReference -> Task<unit>) = render ==> html.callbackTask("RefChanged", fn)
    /// Propagates click events beyond this element.
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ClickPropagation" =>>> true)
    /// Propagates click events beyond this element.
    [<CustomOperation("ClickPropagation")>] member inline _.ClickPropagation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ClickPropagation" =>>> x)
    /// Prevents the default action when this element is clicked.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventDefault" =>>> true)
    /// Prevents the default action when this element is clicked.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventDefault" =>>> x)

/// A component which can be expanded to show more content or collapsed to show only its header.
type MudExpansionPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The maximum allowed height, in pixels.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// User class names, separated by space.
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleContent", fragment)
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The text displayed in this panel, if TitleContent is not set.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Hides the expand icon.
    [<CustomOperation("HideIcon")>] member inline _.HideIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideIcon" =>>> true)
    /// Hides the expand icon.
    [<CustomOperation("HideIcon")>] member inline _.HideIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideIcon" =>>> x)
    /// The icon for expanding this panel.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Removes vertical padding from the panel.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Removes vertical padding from the panel.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Adds left and right padding.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Gutters" =>>> true)
    /// Adds left and right padding.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Gutters" =>>> x)
    /// Occurs when Expanded has changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Occurs when Expanded has changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// Displays the panel content.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Displays the panel content.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Displays the panel content.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Disables user interaction and prevents ToggleExpansionAsync.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Disables user interaction and prevents ToggleExpansionAsync.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// A container which manages MudExpansionPanel components such that when one panel is expanded the others are collapsed automatically.
type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Uses square corners for the panel.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Uses square corners for the panel.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Allows multiple panels to be expanded at the same time.
    [<CustomOperation("MultiExpansion")>] member inline _.MultiExpansion ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("MultiExpansion" =>>> true)
    /// Allows multiple panels to be expanded at the same time.
    [<CustomOperation("MultiExpansion")>] member inline _.MultiExpansion ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("MultiExpansion" =>>> x)
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Uses compact padding for all panels.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact padding for all panels.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Adds left and right padding to all panels.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Gutters" =>>> true)
    /// Adds left and right padding to all panels.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Gutters" =>>> x)
    /// Shows borders around each panel.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Shows borders around each panel.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)

/// A component similar to MudTextField`1 which supports custom content.
type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The vertical spacing for this field.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// Typography for the field text.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    /// Displays the error in ErrorText.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Error" =>>> true)
    /// Displays the error in ErrorText.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Error" =>>> x)
    /// A description of this field's error that is displayed under the field when Error is true.
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// The text displayed below the text field.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// Sets the width of the field to the width of the container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FullWidth" =>>> true)
    /// Sets the width of the field to the width of the container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FullWidth" =>>> x)
    /// The label for this input.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// The display variant of the field.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Prevents the user from interacting with this field.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this field.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The icon displayed for the adornment.
    [<CustomOperation("AdornmentIcon")>] member inline _.AdornmentIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentIcon" => x)
    /// The text displayed for the adornment.
    [<CustomOperation("AdornmentText")>] member inline _.AdornmentText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AdornmentText" => x)
    /// The location of the adornment icon or text.
    [<CustomOperation("Adornment")>] member inline _.Adornment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Adornment" => x)
    /// The color of AdornmentText or AdornmentIcon.
    [<CustomOperation("AdornmentColor")>] member inline _.AdornmentColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("AdornmentColor" => x)
    /// The size of the icon.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// Occurs when the adornment text or icon has been clicked.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnAdornmentClick", fn)
    /// Occurs when the adornment text or icon has been clicked.
    [<CustomOperation("OnAdornmentClick")>] member inline _.OnAdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnAdornmentClick", fn)
    /// Displays padding for the content within this field.
    [<CustomOperation("InnerPadding")>] member inline _.InnerPadding ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("InnerPadding" =>>> true)
    /// Displays padding for the content within this field.
    [<CustomOperation("InnerPadding")>] member inline _.InnerPadding ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("InnerPadding" =>>> x)
    /// Displays an underline for this field.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Underline" =>>> true)
    /// Displays an underline for this field.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Underline" =>>> x)

/// A component which prevents the keyboard focus from cycling out of its child content.
type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prevents the user from interacting with this focus trap.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this focus trap.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The element which receives focus when this focus trap is created or enabled.
    [<CustomOperation("DefaultFocus")>] member inline _.DefaultFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DefaultFocus) = render ==> ("DefaultFocus" => x)

/// A component for collecting and validating user input. Every input derived from MudFormComponent 
/// within it is monitored and validated.
type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Whether all inputs and child forms passed validation.
    [<CustomOperation("IsValid")>] member inline _.IsValid ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsValid" =>>> true)
    /// Whether all inputs and child forms passed validation.
    [<CustomOperation("IsValid")>] member inline _.IsValid ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsValid" =>>> x)
    /// Whether all inputs and child forms passed validation.
    [<CustomOperation("IsValid'")>] member inline _.IsValid' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsValid", valueFn)
    /// Whether any input's value has changed.
    [<CustomOperation("IsTouched")>] member inline _.IsTouched ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsTouched" =>>> true)
    /// Whether any input's value has changed.
    [<CustomOperation("IsTouched")>] member inline _.IsTouched ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsTouched" =>>> x)
    /// Whether any input's value has changed.
    [<CustomOperation("IsTouched'")>] member inline _.IsTouched' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsTouched", valueFn)
    /// Prevents the user from interacting with this form.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this form.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents the user from changing any inputs.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents the user from changing any inputs.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// The delay, in milliseconds, before performing validation.
    [<CustomOperation("ValidationDelay")>] member inline _.ValidationDelay ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ValidationDelay" => x)
    /// Prevents child components from rendering when IsValid changes.
    [<CustomOperation("SuppressRenderingOnValidation")>] member inline _.SuppressRenderingOnValidation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SuppressRenderingOnValidation" =>>> true)
    /// Prevents child components from rendering when IsValid changes.
    [<CustomOperation("SuppressRenderingOnValidation")>] member inline _.SuppressRenderingOnValidation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SuppressRenderingOnValidation" =>>> x)
    /// Prevents this form from being submitted when Enter is pressed.
    [<CustomOperation("SuppressImplicitSubmission")>] member inline _.SuppressImplicitSubmission ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SuppressImplicitSubmission" =>>> true)
    /// Prevents this form from being submitted when Enter is pressed.
    [<CustomOperation("SuppressImplicitSubmission")>] member inline _.SuppressImplicitSubmission ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SuppressImplicitSubmission" =>>> x)
    /// The amount of spacing between input components, in increments of 4px.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Occurs when IsValid has changed.
    [<CustomOperation("IsValidChanged")>] member inline _.IsValidChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("IsValidChanged", fn)
    /// Occurs when IsValid has changed.
    [<CustomOperation("IsValidChanged")>] member inline _.IsValidChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsValidChanged", fn)
    /// Occurs when IsTouched has changed.
    [<CustomOperation("IsTouchedChanged")>] member inline _.IsTouchedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("IsTouchedChanged", fn)
    /// Occurs when IsTouched has changed.
    [<CustomOperation("IsTouchedChanged")>] member inline _.IsTouchedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsTouchedChanged", fn)
    /// Occurs when an IFormComponent within this form has changed.
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Utilities.FormFieldChangedEventArgs -> unit) = render ==> html.callback("FieldChanged", fn)
    /// Occurs when an IFormComponent within this form has changed.
    [<CustomOperation("FieldChanged")>] member inline _.FieldChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Utilities.FormFieldChangedEventArgs -> Task<unit>) = render ==> html.callbackTask("FieldChanged", fn)
    /// The default function or attribute used to validate form components which cannot validate themselves.
    [<CustomOperation("Validation")>] member inline _.Validation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Validation" => x)
    /// Overrides input validation with the function or attribute in Validation.
    [<CustomOperation("OverrideFieldValidation")>] member inline _.OverrideFieldValidation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("OverrideFieldValidation" => x)
    /// The validation errors for inputs within this form.
    [<CustomOperation("Errors")>] member inline _.Errors ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("Errors" => x)
    /// The validation errors for inputs within this form.
    [<CustomOperation("Errors'")>] member inline _.Errors' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.String[] * (System.String[] -> unit)) = render ==> html.bind("Errors", valueFn)
    /// Occurs when Errors has changed.
    [<CustomOperation("ErrorsChanged")>] member inline _.ErrorsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String[] -> unit) = render ==> html.callback("ErrorsChanged", fn)
    /// Occurs when Errors has changed.
    [<CustomOperation("ErrorsChanged")>] member inline _.ErrorsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.String[] -> Task<unit>) = render ==> html.callbackTask("ErrorsChanged", fn)
    /// The model populated by this form.
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Model" => x)

/// A component for breaking a flex display using CSS styles.
type MudFlexBreakBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


/// A component for organizing the layout of page content.
type MudGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The gap between items, measured in increments of 4px.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Defines the distribution of children along the main axis within a MudStack component.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Justify) = render ==> ("Justify" => x)

/// A portion of a MudGrid.
type MudItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Sets the number of columns to occupy at the 'extra small' breakpoint.
    [<CustomOperation("xs")>] member inline _.xs ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("xs" => x)
    /// Sets the number of columns to occupy at the 'small' breakpoint.
    ///  
    [<CustomOperation("sm")>] member inline _.sm ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("sm" => x)
    /// Sets the number of columns to occupy at the 'medium' breakpoint.
    [<CustomOperation("md")>] member inline _.md ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("md" => x)
    /// Sets the number of columns to occupy at the 'large' breakpoint.
    [<CustomOperation("lg")>] member inline _.lg ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("lg" => x)
    /// Sets the number of columns to occupy at the 'extra large' breakpoint.
    [<CustomOperation("xl")>] member inline _.xl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("xl" => x)
    /// Sets the number of columns to occupy at the 'extra extra large' breakpoint.
    [<CustomOperation("xxl")>] member inline _.xxl ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("xxl" => x)

/// A component which conditionally renders content depending on the screen size.
type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The breakpoint at which component is not rendered, when Invert is false.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)
    /// Causes the Breakpoint to control when content is displayed.
    [<CustomOperation("Invert")>] member inline _.Invert ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Invert" =>>> true)
    /// Causes the Breakpoint to control when content is displayed.
    [<CustomOperation("Invert")>] member inline _.Invert ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Invert" =>>> x)
    /// Hides the content within this component.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hidden" =>>> true)
    /// Hides the content within this component.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hidden" =>>> x)
    /// Hides the content within this component.
    [<CustomOperation("Hidden'")>] member inline _.Hidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Hidden", valueFn)
    /// Occurs when Hidden has changed.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("HiddenChanged", fn)
    /// Occurs when Hidden has changed.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("HiddenChanged", fn)

/// A component which highlights words or phrases within text.
type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The text to consider for highlighting.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The text to highlight within Text.
    [<CustomOperation("HighlightedText")>] member inline _.HighlightedText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HighlightedText" => x)
    /// The multiple text fragments to highlight within Text.
    [<CustomOperation("HighlightedTexts")>] member inline _.HighlightedTexts ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<System.String>) = render ==> ("HighlightedTexts" => x)
    /// Whether highlighted text is case sensitive.
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CaseSensitive" =>>> true)
    /// Whether highlighted text is case sensitive.
    [<CustomOperation("CaseSensitive")>] member inline _.CaseSensitive ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CaseSensitive" =>>> x)
    /// Highlights text until the next RegEx boundary.
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UntilNextBoundary" =>>> true)
    /// Highlights text until the next RegEx boundary.
    [<CustomOperation("UntilNextBoundary")>] member inline _.UntilNextBoundary ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UntilNextBoundary" =>>> x)
    /// Renders text as a RenderFragment.
    [<CustomOperation("Markup")>] member inline _.Markup ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Markup" =>>> true)
    /// Renders text as a RenderFragment.
    [<CustomOperation("Markup")>] member inline _.Markup ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Markup" =>>> x)

/// A picture displayed via an SVG path or font.
type MudIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The SVG path or Font Awesome font icon to display.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The text to display for the tooltip.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The size of this icon.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Ignores any custom color.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Ignores any custom color.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The color of this icon.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// For SVG icons, the size of the SVG viewbox.
    [<CustomOperation("ViewBox")>] member inline _.ViewBox ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ViewBox" => x)

/// A simple component that displays an image.
type MudImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Scales this image to the parent container.
    [<CustomOperation("Fluid")>] member inline _.Fluid ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Fluid" =>>> true)
    /// Scales this image to the parent container.
    [<CustomOperation("Fluid")>] member inline _.Fluid ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Fluid" =>>> x)
    /// The path to the image.
    [<CustomOperation("Src")>] member inline _.Src ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Src" => x)
    /// The fallback image path to use if Src fails to load.
    [<CustomOperation("FallbackSrc")>] member inline _.FallbackSrc ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FallbackSrc" => x)
    /// The alternate text for this image.
    [<CustomOperation("Alt")>] member inline _.Alt ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Alt" => x)
    /// The height of this image, in pixels.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Height" => x)
    /// The width of this image, in pixels.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("Width" => x)
    /// The size of the drop shadow for this image.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Controls how this image is resized.
    [<CustomOperation("ObjectFit")>] member inline _.ObjectFit ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ObjectFit) = render ==> ("ObjectFit" => x)
    /// Controls how this image is positioned within its container.
    [<CustomOperation("ObjectPosition")>] member inline _.ObjectPosition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ObjectPosition) = render ==> ("ObjectPosition" => x)

/// A label which describes a MudInput`1 component.
type MudInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prevents the user from interacting with this label.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this label.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Displays this label in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Error" =>>> true)
    /// Displays this label in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Error" =>>> x)
    /// The display variant of this label.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// The amount of vertical spacing to apply.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// For WCAG accessibility, the ID of the input component related to this label.
    [<CustomOperation("ForId")>] member inline _.ForId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ForId" => x)

/// A base class for designing input components.
type MudInputControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The input component within this component.
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("InputContent", fragment)
    /// The input component within this component.
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("InputContent", fragment { yield! fragments })
    /// The input component within this component.
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("InputContent", html.text x)
    /// The input component within this component.
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("InputContent", html.text x)
    /// The input component within this component.
    [<CustomOperation("InputContent")>] member inline _.InputContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("InputContent", html.text x)
    /// The spacing above and below this component.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// Displays an asterisk to indicate an input is required.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Required" =>>> true)
    /// Displays an asterisk to indicate an input is required.
    [<CustomOperation("Required")>] member inline _.Required ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Required" =>>> x)
    /// Displays the Label in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Error" =>>> true)
    /// Displays the Label in an error state.
    [<CustomOperation("Error")>] member inline _.Error ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Error" =>>> x)
    /// The description of the error to display when Error is true.
    [<CustomOperation("ErrorText")>] member inline _.ErrorText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorText" => x)
    /// The ID that will be used by aria-describedby if ErrorText is set.
    [<CustomOperation("ErrorId")>] member inline _.ErrorId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ErrorId" => x)
    /// The text which describes which kind of input is expected.
    [<CustomOperation("HelperText")>] member inline _.HelperText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperText" => x)
    /// The ID that will be used by aria-describedby if HelperText is set.
    [<CustomOperation("HelperId")>] member inline _.HelperId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HelperId" => x)
    /// Displays the HelperText only when this input has focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HelperTextOnFocus" =>>> true)
    /// Displays the HelperText only when this input has focus.
    [<CustomOperation("HelperTextOnFocus")>] member inline _.HelperTextOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HelperTextOnFocus" =>>> x)
    /// The current and maximum number of characters, displayed below the text field.
    [<CustomOperation("CounterText")>] member inline _.CounterText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CounterText" => x)
    /// Expands this input to the width of its container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FullWidth" =>>> true)
    /// Expands this input to the width of its container.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FullWidth" =>>> x)
    /// The label for this input.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// The display variant for this input.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Prevents the user from changing this input's value.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from changing this input's value.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The ID of the input component related to the label specified in Label.
    [<CustomOperation("ForId")>] member inline _.ForId ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ForId" => x)

/// A clickable link which can navigate to a URL.
type MudLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the link.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The typography variant to use.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    /// Applies an underline to the link.
    [<CustomOperation("Underline")>] member inline _.Underline ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Underline) = render ==> ("Underline" => x)
    /// The URL to navigate to upon click.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// The browser frame to open this link when Href is specified.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Prevents user interaction with this link.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents user interaction with this link.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Occurs when this link has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when this link has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// A scrollable list for displaying text, avatars, and icons.
type MudListBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the selected list item.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The color of checkboxes when SelectionMode is MultiSelection.
    [<CustomOperation("CheckBoxColor")>] member inline _.CheckBoxColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("CheckBoxColor" => x)
    /// Prevents list items from being selected.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents list items from being selected.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Applies vertical padding to this list.
    [<CustomOperation("Padding")>] member inline _.Padding ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Padding" =>>> true)
    /// Applies vertical padding to this list.
    [<CustomOperation("Padding")>] member inline _.Padding ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Padding" =>>> x)
    /// Uses less vertical space for list items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses less vertical space for list items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Applies left and right padding to all list items.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Gutters" =>>> true)
    /// Applies left and right padding to all list items.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Gutters" =>>> x)
    /// Prevents any list item from being clicked.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents any list item from being clicked.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Controls how list items are selected.
    [<CustomOperation("SelectionMode")>] member inline _.SelectionMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SelectionMode) = render ==> ("SelectionMode" => x)
    /// The currently selected value.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedValue" => x)
    /// The currently selected value.
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Occurs when SelectedValue has changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("SelectedValueChanged", fn)
    /// Occurs when SelectedValue has changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedValueChanged", fn)
    /// The currently selected values.
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyCollection<'T>) = render ==> ("SelectedValues" => x)
    /// The currently selected values.
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IReadOnlyCollection<'T> * (System.Collections.Generic.IReadOnlyCollection<'T> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    /// Occurs when SelectedValues has changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyCollection<'T> -> unit) = render ==> html.callback("SelectedValuesChanged", fn)
    /// Occurs when SelectedValues has changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyCollection<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedValuesChanged", fn)
    /// The comparer used to see if two list items are equal.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// The icon to use for checked checkboxes when SelectionMode is MultiSelection.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The icon to use for unchecked checkboxes when SelectionMode is MultiSelection.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)

/// An item within a MudList`1 component.
type MudListItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The text to display.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The secondary text displayed.
    [<CustomOperation("SecondaryText")>] member inline _.SecondaryText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SecondaryText" => x)
    /// The value associated with this item.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The custom MudAvatar to display to the left of Text.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("AvatarContent", fragment)
    /// The custom MudAvatar to display to the left of Text.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("AvatarContent", fragment { yield! fragments })
    /// The custom MudAvatar to display to the left of Text.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AvatarContent", html.text x)
    /// The custom MudAvatar to display to the left of Text.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AvatarContent", html.text x)
    /// The custom MudAvatar to display to the left of Text.
    [<CustomOperation("AvatarContent")>] member inline _.AvatarContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AvatarContent", html.text x)
    /// The URL to navigate to upon click.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// The browser frame to open this link when Href is specified.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Causes a full page refresh when this list item is clicked and Href is set.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ForceLoad" =>>> true)
    /// Causes a full page refresh when this list item is clicked and Href is set.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ForceLoad" =>>> x)
    /// Prevents this list item from being clicked.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents this list item from being clicked.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Shows a ripple effect when this item is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when this item is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// The icon to display for this list item.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the Icon.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The size of the Icon.
    [<CustomOperation("IconSize")>] member inline _.IconSize ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("IconSize" => x)
    /// The color of the ExpandLessIcon and ExpandMoreIcon icons.
    [<CustomOperation("ExpandIconColor")>] member inline _.ExpandIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandIconColor" => x)
    /// The icon displayed when Expanded is true.
    [<CustomOperation("ExpandLessIcon")>] member inline _.ExpandLessIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandLessIcon" => x)
    /// The icon displayed when Expanded is false.
    [<CustomOperation("ExpandMoreIcon")>] member inline _.ExpandMoreIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandMoreIcon" => x)
    /// Applies an indent to this list item.
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Inset" =>>> true)
    /// Applies an indent to this list item.
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Inset" =>>> x)
    /// Uses less vertical padding between items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Dense" => x)
    /// Applies left and right padding to this list items.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Gutters" => x)
    /// Expand or collapse nested list. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will initialize the nested list's expansion state.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Expand or collapse nested list. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will initialize the nested list's expansion state.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Expand or collapse nested list. Two-way bindable. Note: if you directly set this to
    /// true or false (instead of using two-way binding) it will initialize the nested list's expansion state.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// If set, clicking the list item will only execute the OnClick handler and prevent all other
    /// functionality such as following Href or selection.
    [<CustomOperation("OnClickPreventDefault")>] member inline _.OnClickPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("OnClickPreventDefault" =>>> true)
    /// If set, clicking the list item will only execute the OnClick handler and prevent all other
    /// functionality such as following Href or selection.
    [<CustomOperation("OnClickPreventDefault")>] member inline _.OnClickPreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("OnClickPreventDefault" =>>> x)
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NestedList", fragment)
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NestedList", fragment { yield! fragments })
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NestedList", html.text x)
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NestedList", html.text x)
    /// Add child list items here to create a nested list.
    [<CustomOperation("NestedList")>] member inline _.NestedList ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NestedList", html.text x)
    /// List click event.
    /// Also called when Href is set
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// List click event.
    /// Also called when Href is set
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// A header displayed as part of a MudList`1.
type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Applies left and right padding to all list items.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Gutters" =>>> true)
    /// Applies left and right padding to all list items.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Gutters" =>>> x)
    /// Applies an indent to this header.
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Inset" =>>> true)
    /// Applies an indent to this header.
    [<CustomOperation("Inset")>] member inline _.Inset ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Inset" =>>> x)

/// Represents the main content area of the MudLayout.
type MudMainContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


/// An interactive menu that displays a list of options.
type MudMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The text shown for this menu.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// The aria-label for the menu button when ActivatorContent is not set.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// The CSS classes applied to items in this menu.
    [<CustomOperation("ListClass")>] member inline _.ListClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ListClass" => x)
    /// The CSS classes applied to the popover for this menu.
    [<CustomOperation("PopoverClass")>] member inline _.PopoverClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PopoverClass" => x)
    /// The icon displayed for this menu.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon when Icon is set.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// The icon displayed before the text.
    [<CustomOperation("StartIcon")>] member inline _.StartIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StartIcon" => x)
    /// The icon displayed after the text.
    [<CustomOperation("EndIcon")>] member inline _.EndIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    /// The color of this menu's button when Icon is not set.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of this menu's button when Icon is not set.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The display variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Applies compact vertical padding to all menu items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Applies compact vertical padding to all menu items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Expands this menu to the same width as its parent.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FullWidth" =>>> true)
    /// Expands this menu to the same width as its parent.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FullWidth" =>>> x)
    /// Sets the maximum allowed height for this menu, when open.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// Opens this menu at the cursor's location instead of the button's location.
    [<CustomOperation("PositionAtCursor")>] member inline _.PositionAtCursor ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PositionAtCursor" =>>> true)
    /// Opens this menu at the cursor's location instead of the button's location.
    [<CustomOperation("PositionAtCursor")>] member inline _.PositionAtCursor ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PositionAtCursor" =>>> x)
    /// Overrides the default button with a custom component.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ActivatorContent", fragment)
    /// Overrides the default button with a custom component.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ActivatorContent", fragment { yield! fragments })
    /// Overrides the default button with a custom component.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// Overrides the default button with a custom component.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// Overrides the default button with a custom component.
    [<CustomOperation("ActivatorContent")>] member inline _.ActivatorContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ActivatorContent", html.text x)
    /// The action which opens the menu, when ActivatorContent is set.
    [<CustomOperation("ActivationEvent")>] member inline _.ActivationEvent ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MouseEvent) = render ==> ("ActivationEvent" => x)
    /// The origin point for the menu's anchor. If set, overrides Nested Menus, and PositionatCursor Anchor points.
    [<CustomOperation("AnchorOrigin")>] member inline _.AnchorOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Origin>) = render ==> ("AnchorOrigin" => x)
    /// Sets the direction the menu will open from the anchor.
    [<CustomOperation("TransformOrigin")>] member inline _.TransformOrigin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Origin) = render ==> ("TransformOrigin" => x)
    /// The behavior of the dropdown popover menu
    [<CustomOperation("DropdownSettings")>] member inline _.DropdownSettings ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DropdownSettings) = render ==> ("DropdownSettings" => x)
    /// Determines the width of the Popover dropdown in relation the parent container.
    [<CustomOperation("RelativeWidth")>] member inline _.RelativeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.DropdownWidth) = render ==> ("RelativeWidth" => x)
    /// Prevents the page from scrolling while this menu is open.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("LockScroll" =>>> true)
    /// Prevents the page from scrolling while this menu is open.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("LockScroll" =>>> x)
    /// Prevents the user from interacting with this menu.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this menu.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Shows a ripple animation when the user clicks the activator button.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple animation when the user clicks the activator button.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Displays a drop shadow under the activator button.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DropShadow" =>>> true)
    /// Displays a drop shadow under the activator button.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DropShadow" =>>> x)
    /// Prevents interaction with background elements while this menu is open.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Modal" =>>> true)
    /// Prevents interaction with background elements while this menu is open.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Modal" =>>> x)
    /// Whether this menu is open and the menu items are visible.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Open" =>>> true)
    /// Whether this menu is open and the menu items are visible.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Open" =>>> x)
    /// Whether this menu is open and the menu items are visible.
    [<CustomOperation("Open'")>] member inline _.Open' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Open", valueFn)
    /// Occurs when Open has changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OpenChanged", fn)
    /// Occurs when Open has changed.
    [<CustomOperation("OpenChanged")>] member inline _.OpenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OpenChanged", fn)

/// A choice displayed as part of a list within a MudMenu component.
type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The text shown on this menu item if ChildContent is not set.
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// Prevents the user from interacting with this item.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this item.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The URL to navigate to when this menu item is clicked.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// The browser tab/window opened when a click occurs and Href is set.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// Performs a full page load during navigation.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ForceLoad" =>>> true)
    /// Performs a full page load during navigation.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ForceLoad" =>>> x)
    /// The icon displayed at the start of this menu item.  The size depends on whether or not the menu is using the dense variant.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon when Icon is set.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Closes the menu when this item is clicked.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoClose" =>>> true)
    /// Closes the menu when this item is clicked.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoClose" =>>> x)
    /// Occurs when this menu item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when this menu item is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// A pop-up dialog with a simple message and button choices.
type MudMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The title of this message box.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The custom content within the title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleContent", fragment)
    /// The custom content within the title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    /// The custom content within the title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The custom content within the title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The custom content within the title.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The content within this message box.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Message" => x)
    /// The markup content within this message box.
    [<CustomOperation("MarkupMessage")>] member inline _.MarkupMessage ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.MarkupString) = render ==> ("MarkupMessage" => x)
    /// The custom content within this message box.
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("MessageContent", fragment)
    /// The custom content within this message box.
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("MessageContent", fragment { yield! fragments })
    /// The custom content within this message box.
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MessageContent", html.text x)
    /// The custom content within this message box.
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MessageContent", html.text x)
    /// The custom content within this message box.
    [<CustomOperation("MessageContent")>] member inline _.MessageContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MessageContent", html.text x)
    /// The text of the Cancel button.
    [<CustomOperation("CancelText")>] member inline _.CancelText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CancelText" => x)
    /// The custom content for the Cancel button.
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("CancelButton", fragment)
    /// The custom content for the Cancel button.
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("CancelButton", fragment { yield! fragments })
    /// The custom content for the Cancel button.
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CancelButton", html.text x)
    /// The custom content for the Cancel button.
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CancelButton", html.text x)
    /// The custom content for the Cancel button.
    [<CustomOperation("CancelButton")>] member inline _.CancelButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CancelButton", html.text x)
    /// The text of the No button.
    [<CustomOperation("NoText")>] member inline _.NoText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NoText" => x)
    /// The custom content for the No button.
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NoButton", fragment)
    /// The custom content for the No button.
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NoButton", fragment { yield! fragments })
    /// The custom content for the No button.
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoButton", html.text x)
    /// The custom content for the No button.
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoButton", html.text x)
    /// The custom content for the No button.
    [<CustomOperation("NoButton")>] member inline _.NoButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoButton", html.text x)
    /// The text of the Yes/OK button.
    [<CustomOperation("YesText")>] member inline _.YesText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("YesText" => x)
    /// The custom content for the Yes button.
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("YesButton", fragment)
    /// The custom content for the Yes button.
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("YesButton", fragment { yield! fragments })
    /// The custom content for the Yes button.
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("YesButton", html.text x)
    /// The custom content for the Yes button.
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("YesButton", html.text x)
    /// The custom content for the Yes button.
    [<CustomOperation("YesButton")>] member inline _.YesButton ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("YesButton", html.text x)
    /// Occurs when the Yes button is clicked.
    [<CustomOperation("OnYes")>] member inline _.OnYes ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OnYes", fn)
    /// Occurs when the Yes button is clicked.
    [<CustomOperation("OnYes")>] member inline _.OnYes ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnYes", fn)
    /// Occurs when the No button is clicked.
    [<CustomOperation("OnNo")>] member inline _.OnNo ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OnNo", fn)
    /// Occurs when the No button is clicked.
    [<CustomOperation("OnNo")>] member inline _.OnNo ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnNo", fn)
    /// Occurs when the Cancel button is clicked, or this message box is closed via the Close button.
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("OnCancel", fn)
    /// Occurs when the Cancel button is clicked, or this message box is closed via the Close button.
    [<CustomOperation("OnCancel")>] member inline _.OnCancel ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("OnCancel", fn)
    /// Shows this message box.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Shows this message box.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Shows this message box.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// Occurs when Visible has changed.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    /// Occurs when Visible has changed.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)

/// A deeper level of navigation links as part of a MudNavMenu.
type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The CSS classes applied to this nav group title.
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TitleContent", fragment)
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TitleContent", fragment { yield! fragments })
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The content within the title area.
    [<CustomOperation("TitleContent")>] member inline _.TitleContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TitleContent", html.text x)
    /// The text shown for this group.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The icon displayed next to the Title.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon when Icon is set.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Prevents the user from interacting with this group.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this group.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Shows a ripple effect when the user clicks this group.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when the user clicks this group.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Displays the items within this group.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Displays the items within this group.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Displays the items within this group.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Hides the expand/collapse icon.
    [<CustomOperation("HideExpandIcon")>] member inline _.HideExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideExpandIcon" =>>> true)
    /// Hides the expand/collapse icon.
    [<CustomOperation("HideExpandIcon")>] member inline _.HideExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideExpandIcon" =>>> x)
    /// The maximum height, in pixels, of this group.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Int32>) = render ==> ("MaxHeight" => x)
    /// The icon for expanding and collapsing this group.
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
    /// Occurs when Expanded has changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Occurs when Expanded has changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)

/// A navigation link as part of a MudNavMenu.
type MudNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The icon displayed for this link.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of the icon when Icon is set.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Controls when this link is highlighted.
    [<CustomOperation("Match")>] member inline _.Match ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = render ==> ("Match" => x)
    /// The browser frame to open this link when Href is specified.
    [<CustomOperation("Target")>] member inline _.Target ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Target" => x)
    /// The CSS applied when this link is active.
    [<CustomOperation("ActiveClass")>] member inline _.ActiveClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ActiveClass" => x)
    /// Prevents the user from interacting with this link.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this link.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Shows a ripple effect when the user clicks this link.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when the user clicks this link.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// The URL to navigate to when this link is clicked.
    [<CustomOperation("Href")>] member inline _.Href ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Href" => x)
    /// Performs a full page load during navigation.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ForceLoad" =>>> true)
    /// Performs a full page load during navigation.
    [<CustomOperation("ForceLoad")>] member inline _.ForceLoad ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ForceLoad" =>>> x)
    /// Occurs when this link has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when this link has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// A list of navigation links with support for groups.
type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the active MudNavLink.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Shows a border on the active MudNavLink.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Bordered" =>>> true)
    /// Shows a border on the active MudNavLink.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Bordered" =>>> x)
    /// Shows a rounded border for all MudNavLink items.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Rounded" =>>> true)
    /// Shows a rounded border for all MudNavLink items.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Rounded" =>>> x)
    /// The vertical spacing between MudNavLink items.
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Margin) = render ==> ("Margin" => x)
    /// Uses compact vertical padding to all MudNavLink items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact vertical padding to all MudNavLink items.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)

/// A layer which darkens a window, often as part of showing a MudDialog.
type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Makes the overlay visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Makes the overlay visible.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Makes the overlay visible.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// Occurs when Visible changes.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    /// Occurs when Visible changes.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)
    /// Sets Visible to false when the overlay is clicked and calls OnClosed.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoClose" =>>> true)
    /// Sets Visible to false when the overlay is clicked and calls OnClosed.
    [<CustomOperation("AutoClose")>] member inline _.AutoClose ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoClose" =>>> x)
    /// Prevents the Document.body element from scrolling.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("LockScroll" =>>> true)
    /// Prevents the Document.body element from scrolling.
    [<CustomOperation("LockScroll")>] member inline _.LockScroll ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("LockScroll" =>>> x)
    /// The css class that will be added to body if lockscroll is used.
    [<CustomOperation("LockScrollClass")>] member inline _.LockScrollClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LockScrollClass" => x)
    /// Prevents interaction with background elements.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Modal" =>>> true)
    /// Prevents interaction with background elements.
    [<CustomOperation("Modal")>] member inline _.Modal ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Modal" =>>> x)
    /// Applies the theme's dark overlay color.
    [<CustomOperation("DarkBackground")>] member inline _.DarkBackground ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DarkBackground" =>>> true)
    /// Applies the theme's dark overlay color.
    [<CustomOperation("DarkBackground")>] member inline _.DarkBackground ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DarkBackground" =>>> x)
    /// Applies the theme's light overlay color.
    [<CustomOperation("LightBackground")>] member inline _.LightBackground ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("LightBackground" =>>> true)
    /// Applies the theme's light overlay color.
    [<CustomOperation("LightBackground")>] member inline _.LightBackground ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("LightBackground" =>>> x)
    /// Uses absolute positioning for the overlay.
    [<CustomOperation("Absolute")>] member inline _.Absolute ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Absolute" =>>> true)
    /// Uses absolute positioning for the overlay.
    [<CustomOperation("Absolute")>] member inline _.Absolute ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Absolute" =>>> x)
    /// Sets the z-index of the overlay.
    [<CustomOperation("ZIndex")>] member inline _.ZIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ZIndex" => x)
    /// Occurs when the overlay is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when the overlay is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Occurs when the overlay is closed due to AutoClose.
    [<CustomOperation("OnClosed")>] member inline _.OnClosed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> unit) = render ==> html.callback("OnClosed", fn)
    /// Occurs when the overlay is closed due to AutoClose.
    [<CustomOperation("OnClosed")>] member inline _.OnClosed ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> Task<unit>) = render ==> html.callbackTask("OnClosed", fn)

/// A drawer used to navigate sections on a page.
type MudPageContentNavigationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The text displayed about the section links. Defaults to "Contents"
    [<CustomOperation("Headline")>] member inline _.Headline ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Headline" => x)
    /// The CSS selector used to identify the scroll container
    [<CustomOperation("ScrollContainerSelector")>] member inline _.ScrollContainerSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ScrollContainerSelector" => x)
    /// The class name (without .) to identify the HTML elements that should be observed for viewport changes
    [<CustomOperation("SectionClassSelector")>] member inline _.SectionClassSelector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SectionClassSelector" => x)
    /// If there are multiple levels, this can specified to make a mapping between a level class like "second-level" and the level in the hierarchy
    [<CustomOperation("HierarchyMapper")>] member inline _.HierarchyMapper ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.Int32>) = render ==> ("HierarchyMapper" => x)
    /// If there are multiple levels, this property controls they visibility of them.
    [<CustomOperation("ExpandBehaviour")>] member inline _.ExpandBehaviour ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ContentNavigationExpandBehaviour) = render ==> ("ExpandBehaviour" => x)
    /// If this option is true the first added section will become active when there is no other indication of an active session. Default value is false  
    [<CustomOperation("ActivateFirstSectionAsDefault")>] member inline _.ActivateFirstSectionAsDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ActivateFirstSectionAsDefault" =>>> true)
    /// If this option is true the first added section will become active when there is no other indication of an active session. Default value is false  
    [<CustomOperation("ActivateFirstSectionAsDefault")>] member inline _.ActivateFirstSectionAsDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ActivateFirstSectionAsDefault" =>>> x)

/// A list of clickable page numbers along with navigation buttons.
type MudPaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The total number of pages.
    [<CustomOperation("Count")>] member inline _.Count ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    /// The number of pages shown before and after the ellipsis.
    [<CustomOperation("BoundaryCount")>] member inline _.BoundaryCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("BoundaryCount" => x)
    /// The number of pages shown between the ellipsis.
    [<CustomOperation("MiddleCount")>] member inline _.MiddleCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MiddleCount" => x)
    /// The selected page number.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Selected" => x)
    /// The selected page number.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("Selected", valueFn)
    /// The display variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// The color of the selected page button.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Shows rectangular-shaped page buttons.
    [<CustomOperation("Rectangular")>] member inline _.Rectangular ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Rectangular" =>>> true)
    /// Shows rectangular-shaped page buttons.
    [<CustomOperation("Rectangular")>] member inline _.Rectangular ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Rectangular" =>>> x)
    /// The size of the page buttons.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Shows a drop shadow under each page button.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DropShadow" =>>> true)
    /// Shows a drop shadow under each page button.
    [<CustomOperation("DropShadow")>] member inline _.DropShadow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DropShadow" =>>> x)
    /// Prevents the user from clicking page buttons.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from clicking page buttons.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Shows the button which selects the first page.
    [<CustomOperation("ShowFirstButton")>] member inline _.ShowFirstButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowFirstButton" =>>> true)
    /// Shows the button which selects the first page.
    [<CustomOperation("ShowFirstButton")>] member inline _.ShowFirstButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowFirstButton" =>>> x)
    /// Shows the button which selects the last page.
    [<CustomOperation("ShowLastButton")>] member inline _.ShowLastButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowLastButton" =>>> true)
    /// Shows the button which selects the last page.
    [<CustomOperation("ShowLastButton")>] member inline _.ShowLastButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowLastButton" =>>> x)
    /// Shows the button which selects the previous page.
    [<CustomOperation("ShowPreviousButton")>] member inline _.ShowPreviousButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowPreviousButton" =>>> true)
    /// Shows the button which selects the previous page.
    [<CustomOperation("ShowPreviousButton")>] member inline _.ShowPreviousButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowPreviousButton" =>>> x)
    /// Shows the button which selects the next page.
    [<CustomOperation("ShowNextButton")>] member inline _.ShowNextButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowNextButton" =>>> true)
    /// Shows the button which selects the next page.
    [<CustomOperation("ShowNextButton")>] member inline _.ShowNextButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowNextButton" =>>> x)
    /// Shows numeric buttons for pages.
    [<CustomOperation("ShowPageButtons")>] member inline _.ShowPageButtons ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowPageButtons" =>>> true)
    /// Shows numeric buttons for pages.
    [<CustomOperation("ShowPageButtons")>] member inline _.ShowPageButtons ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowPageButtons" =>>> x)
    /// Occurs when the First, Previous, Next, or Last button is clicked.
    [<CustomOperation("ControlButtonClicked")>] member inline _.ControlButtonClicked ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Page -> unit) = render ==> html.callback("ControlButtonClicked", fn)
    /// Occurs when the First, Previous, Next, or Last button is clicked.
    [<CustomOperation("ControlButtonClicked")>] member inline _.ControlButtonClicked ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.Page -> Task<unit>) = render ==> html.callbackTask("ControlButtonClicked", fn)
    /// Occurs when Selected has changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Occurs when Selected has changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
    /// The icon for the First button.
    [<CustomOperation("FirstIcon")>] member inline _.FirstIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstIcon" => x)
    /// The icon for the Before button.
    [<CustomOperation("BeforeIcon")>] member inline _.BeforeIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BeforeIcon" => x)
    /// The icon for the Next button.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// The icon for the Last button.
    [<CustomOperation("LastIcon")>] member inline _.LastIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastIcon" => x)

/// A surface for grouping other components.
type MudPaperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Displays a square shape.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Displays a square shape.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Displays an outline around this component.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Displays an outline around this component.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)
    /// The height of this component.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// The width of this component.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// The maximum height of this component.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// The maximum width of this component.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxWidth" => x)
    /// The minimum height of this component.
    [<CustomOperation("MinHeight")>] member inline _.MinHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinHeight" => x)
    /// The minimum width of this component.
    [<CustomOperation("MinWidth")>] member inline _.MinWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MinWidth" => x)

/// The content within a MudPicker`1.
type MudPickerContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


/// The toolbar content of a MudPicker`1.
type MudPickerToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Shows the toolbar.
    [<CustomOperation("ShowToolbar")>] member inline _.ShowToolbar ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowToolbar" =>>> true)
    /// Shows the toolbar.
    [<CustomOperation("ShowToolbar")>] member inline _.ShowToolbar ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowToolbar" =>>> x)
    /// The display orientation of this toolbar.
    [<CustomOperation("Orientation")>] member inline _.Orientation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Orientation) = render ==> ("Orientation" => x)
    /// The display variant for this toolbar.
    [<CustomOperation("PickerVariant")>] member inline _.PickerVariant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.PickerVariant) = render ==> ("PickerVariant" => x)
    /// The color of the toolbar, selected, and active values.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)

/// A circle-shaped indicator of progress for an ongoing operation.
type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of this component.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of this component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Displays a constant animation without any value.
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Indeterminate" =>>> true)
    /// Displays a constant animation without any value.
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Indeterminate" =>>> x)
    /// Displays a rounded border.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Rounded" =>>> true)
    /// Displays a rounded border.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Rounded" =>>> x)
    /// The lowest possible value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    /// The highest possible value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    /// The current progress amount.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    /// The thickness of the circle.
    [<CustomOperation("StrokeWidth")>] member inline _.StrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("StrokeWidth" => x)

/// A line-shaped indicator of progress for an ongoing operation.
type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of this component.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of this component.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Displays a constant animation without any value.
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Indeterminate" =>>> true)
    /// Displays a constant animation without any value.
    [<CustomOperation("Indeterminate")>] member inline _.Indeterminate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Indeterminate" =>>> x)
    /// Displays an additional value ahead of Value.
    [<CustomOperation("Buffer")>] member inline _.Buffer ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Buffer" =>>> true)
    /// Displays an additional value ahead of Value.
    [<CustomOperation("Buffer")>] member inline _.Buffer ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Buffer" =>>> x)
    /// Displays a rounded border.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Rounded" =>>> true)
    /// Displays a rounded border.
    [<CustomOperation("Rounded")>] member inline _.Rounded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Rounded" =>>> x)
    /// Displays animated stripes for the value portion of this progress bar.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Striped" =>>> true)
    /// Displays animated stripes for the value portion of this progress bar.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Striped" =>>> x)
    /// Displays this progress bar vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Vertical" =>>> true)
    /// Displays this progress bar vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Vertical" =>>> x)
    /// The lowest possible value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Min" => x)
    /// The highest possible value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Max" => x)
    /// The current progress amount.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Value" => x)
    /// The amount to display ahead of the value.
    [<CustomOperation("BufferValue")>] member inline _.BufferValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("BufferValue" => x)

/// A component for collecting and displaying ratings.
type MudRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The CSS classes to apply to each MudRatingItem.
    [<CustomOperation("RatingItemsClass")>] member inline _.RatingItemsClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RatingItemsClass" => x)
    /// The CSS styles to apply to each MudRatingItem.
    [<CustomOperation("RatingItemsStyle")>] member inline _.RatingItemsStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RatingItemsStyle" => x)
    /// The name of this input.
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    /// The number of MudRatingItem items to display.
    [<CustomOperation("MaxValue")>] member inline _.MaxValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("MaxValue" => x)
    /// The icon displayed for selected items.
    [<CustomOperation("FullIcon")>] member inline _.FullIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FullIcon" => x)
    /// The icon displayed for unselected items.
    [<CustomOperation("EmptyIcon")>] member inline _.EmptyIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EmptyIcon" => x)
    /// The color of the FullIcon for selected items.
    [<CustomOperation("FullIconColor")>] member inline _.FullIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("FullIconColor" => x)
    /// The color of the EmptyIcon for unselected items.
    [<CustomOperation("EmptyIconColor")>] member inline _.EmptyIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("EmptyIconColor" => x)
    /// The color of each item.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the FullIcon and EmptyIcon icons.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Shows a ripple effect when an item is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when an item is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Prevents the user from interacting with this rating and shows a disabled color.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this rating and shows a disabled color.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents this rating from being changed.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents this rating from being changed.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Occurs when SelectedValue has changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("SelectedValueChanged", fn)
    /// Occurs when SelectedValue has changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("SelectedValueChanged", fn)
    /// The currently selected value.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("SelectedValue" => x)
    /// The currently selected value.
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Occurs when HoveredValue has changed.
    [<CustomOperation("HoveredValueChanged")>] member inline _.HoveredValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int32> -> unit) = render ==> html.callback("HoveredValueChanged", fn)
    /// Occurs when HoveredValue has changed.
    [<CustomOperation("HoveredValueChanged")>] member inline _.HoveredValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int32> -> Task<unit>) = render ==> html.callbackTask("HoveredValueChanged", fn)

/// A clickable item as part of a MudRating.
type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The value for this item.
    [<CustomOperation("ItemValue")>] member inline _.ItemValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ItemValue" => x)
    /// The size of this item.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The color of this item.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Show a ripple effect when the user clicks the button.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Show a ripple effect when the user clicks the button.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Prevents the user from interacting with this item, and uses a disabled style.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this item, and uses a disabled style.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents thid item from being changed.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents thid item from being changed.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Occurs when this item is clicked.
    [<CustomOperation("ItemClicked")>] member inline _.ItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("ItemClicked", fn)
    /// Occurs when this item is clicked.
    [<CustomOperation("ItemClicked")>] member inline _.ItemClicked ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ItemClicked", fn)
    /// Occurs when the user hovers over this item.
    [<CustomOperation("ItemHovered")>] member inline _.ItemHovered ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int32> -> unit) = render ==> html.callback("ItemHovered", fn)
    /// Occurs when the user hovers over this item.
    [<CustomOperation("ItemHovered")>] member inline _.ItemHovered ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<System.Int32> -> Task<unit>) = render ==> html.callbackTask("ItemHovered", fn)

/// A language support provider for Right-to-Left (RTL) languages such as Arabic, Hebrew, and Persian.
type MudRTLProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Displays text Right-to-Left (RTL).
    [<CustomOperation("RightToLeft")>] member inline _.RightToLeft ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("RightToLeft" =>>> true)
    /// Displays text Right-to-Left (RTL).
    [<CustomOperation("RightToLeft")>] member inline _.RightToLeft ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("RightToLeft" =>>> x)

/// A button which lets the user jump to the top of the page.
type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The CSS selector to which the scroll event will be attached.
    [<CustomOperation("Selector")>] member inline _.Selector ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Selector" => x)
    /// Displays this button.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Displays this button.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// The CSS classes applied when Visible becomes true.
    [<CustomOperation("VisibleCssClass")>] member inline _.VisibleCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("VisibleCssClass" => x)
    /// The CSS classes applied when Visible becomes false.
    [<CustomOperation("HiddenCssClass")>] member inline _.HiddenCssClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HiddenCssClass" => x)
    /// The number of pixels scrolled before the scroll-to-top button becomes visible.
    [<CustomOperation("TopOffset")>] member inline _.TopOffset ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("TopOffset" => x)
    /// The scroll behavior when the scroll-to-top button is clicked.
    [<CustomOperation("ScrollBehavior")>] member inline _.ScrollBehavior ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.ScrollBehavior) = render ==> ("ScrollBehavior" => x)
    /// Occurs when the page is scrolled.
    [<CustomOperation("OnScroll")>] member inline _.OnScroll ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.ScrollEventArgs -> unit) = render ==> html.callback("OnScroll", fn)
    /// Occurs when the page is scrolled.
    [<CustomOperation("OnScroll")>] member inline _.OnScroll ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.ScrollEventArgs -> Task<unit>) = render ==> html.callbackTask("OnScroll", fn)
    /// Occurs when the scroll-to-top button is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when the scroll-to-top button is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// A selectable option displayed within a MudSelect`1 component.
type MudSelectItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The custom value associated with this item.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// Prevents the user from interacting with this item.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this item.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// A temporary placeholder for content while data is loaded.
type MudSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The width of this skeleton.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// The height of this skeleton.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// The shape of this skeleton.
    [<CustomOperation("SkeletonType")>] member inline _.SkeletonType ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SkeletonType) = render ==> ("SkeletonType" => x)
    /// The type of animation to display.
    [<CustomOperation("Animation")>] member inline _.Animation ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Animation) = render ==> ("Animation" => x)

/// A component which allows users to select a value within a specified range.
type MudSliderBuilder<'FunBlazorGeneric, 'T when 'T : struct and 'T : (new : unit -> 'T) and System.Numerics.INumber<'T> and 'T :> System.ValueType and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The minimum allowed value.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Min" => x)
    /// The maximum allowed value.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Max" => x)
    /// How much the value changes on each move.
    [<CustomOperation("Step")>] member inline _.Step ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Step" => x)
    /// Prevents the user from interacting with this slider.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this slider.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Occurs when Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Occurs when Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// Occurs when NullableValue has changed.
    [<CustomOperation("NullableValueChanged")>] member inline _.NullableValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<'T> -> unit) = render ==> html.callback("NullableValueChanged", fn)
    /// Occurs when NullableValue has changed.
    [<CustomOperation("NullableValueChanged")>] member inline _.NullableValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Nullable<'T> -> Task<unit>) = render ==> html.callbackTask("NullableValueChanged", fn)
    /// The value of this slider.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The value of this slider.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// The nullable value of this slider.
    [<CustomOperation("NullableValue")>] member inline _.NullableValue ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<'T>) = render ==> ("NullableValue" => x)
    /// The nullable value of this slider.
    [<CustomOperation("NullableValue'")>] member inline _.NullableValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Nullable<'T> * (System.Nullable<'T> -> unit)) = render ==> html.bind("NullableValue", valueFn)
    /// The color of this slider.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Controls when the value is updated.
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Immediate" =>>> true)
    /// Controls when the value is updated.
    [<CustomOperation("Immediate")>] member inline _.Immediate ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Immediate" =>>> x)
    /// Displays this slider vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Vertical" =>>> true)
    /// Displays this slider vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Vertical" =>>> x)
    /// Displays tick marks along the track.
    [<CustomOperation("TickMarks")>] member inline _.TickMarks ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TickMarks" =>>> true)
    /// Displays tick marks along the track.
    [<CustomOperation("TickMarks")>] member inline _.TickMarks ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TickMarks" =>>> x)
    /// The tick mark labels for each step.
    [<CustomOperation("TickMarkLabels")>] member inline _.TickMarkLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String[]) = render ==> ("TickMarkLabels" => x)
    /// The size of this slider.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The display variant to use.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// Displays the value over the slider thumb.
    [<CustomOperation("ValueLabel")>] member inline _.ValueLabel ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ValueLabel" =>>> true)
    /// Displays the value over the slider thumb.
    [<CustomOperation("ValueLabel")>] member inline _.ValueLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ValueLabel" =>>> x)
    /// The culture used to format the value label.
    [<CustomOperation("Culture")>] member inline _.Culture ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Globalization.CultureInfo) = render ==> ("Culture" => x)
    /// The format of the value label.
    [<CustomOperation("ValueLabelFormat")>] member inline _.ValueLabelFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ValueLabelFormat" => x)
    /// The custom content for value labels.
    [<CustomOperation("ValueLabelContent")>] member inline _.ValueLabelContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.SliderContext<'T> -> NodeRenderFragment) = render ==> html.renderFragment("ValueLabelContent", fn)

type MudSnackbarElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Snackbar")>] member inline _.Snackbar ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Snackbar) = render ==> ("Snackbar" => x)
    /// Custom close icon.
    [<CustomOperation("CloseIcon")>] member inline _.CloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CloseIcon" => x)

type MudSnackbarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


/// A component for aligning child items horizontally or vertically.
type MudStackBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Displays items horizontally.
    [<CustomOperation("Row")>] member inline _.Row ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Row" =>>> true)
    /// Displays items horizontally.
    [<CustomOperation("Row")>] member inline _.Row ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Row" =>>> x)
    /// Reverses the order of items.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Reverse" =>>> true)
    /// Reverses the order of items.
    [<CustomOperation("Reverse")>] member inline _.Reverse ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Reverse" =>>> x)
    /// The gap between items in increments of 4px.
    [<CustomOperation("Spacing")>] member inline _.Spacing ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Spacing" => x)
    /// Defines the distribution of child items.
    [<CustomOperation("Justify")>] member inline _.Justify ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Justify>) = render ==> ("Justify" => x)
    /// Defines the vertical alignment of child items.
    [<CustomOperation("AlignItems")>] member inline _.AlignItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.AlignItems>) = render ==> ("AlignItems" => x)
    /// Defines the stretching behaviour of children along the main axis within a MudStack component.
    [<CustomOperation("StretchItems")>] member inline _.StretchItems ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.StretchItems>) = render ==> ("StretchItems" => x)
    /// Controls how items are wrapped.
    [<CustomOperation("Wrap")>] member inline _.Wrap ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Wrap>) = render ==> ("Wrap" => x)
    /// The breakpoint at which the Stack should switch to a row or column layout.
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Breakpoint) = render ==> ("Breakpoint" => x)

/// A individual step as part of a MudStepper.
type MudStepBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The title of this step.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The subtitle describing this step.
    [<CustomOperation("SecondaryText")>] member inline _.SecondaryText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SecondaryText" => x)
    /// The color used when this step is completed.
    [<CustomOperation("CompletedStepColor")>] member inline _.CompletedStepColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("CompletedStepColor" => x)
    /// The color used when this step has an error.
    [<CustomOperation("ErrorStepColor")>] member inline _.ErrorStepColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.Color>) = render ==> ("ErrorStepColor" => x)
    /// Whether the user can skip this step.
    [<CustomOperation("Skippable")>] member inline _.Skippable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Skippable" =>>> true)
    /// Whether the user can skip this step.
    [<CustomOperation("Skippable")>] member inline _.Skippable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Skippable" =>>> x)
    /// Whether this step is completed.
    [<CustomOperation("Completed")>] member inline _.Completed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Completed" =>>> true)
    /// Whether this step is completed.
    [<CustomOperation("Completed")>] member inline _.Completed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Completed" =>>> x)
    /// Whether this step is completed.
    [<CustomOperation("Completed'")>] member inline _.Completed' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Completed", valueFn)
    /// Occurs when Completed has changed.
    [<CustomOperation("CompletedChanged")>] member inline _.CompletedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("CompletedChanged", fn)
    /// Occurs when Completed has changed.
    [<CustomOperation("CompletedChanged")>] member inline _.CompletedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CompletedChanged", fn)
    /// Prevents this step from being selected.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents this step from being selected.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents this step from being selected.
    [<CustomOperation("Disabled'")>] member inline _.Disabled' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Disabled", valueFn)
    /// Occurs when Disabled has changed.
    [<CustomOperation("DisabledChanged")>] member inline _.DisabledChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("DisabledChanged", fn)
    /// Occurs when Disabled has changed.
    [<CustomOperation("DisabledChanged")>] member inline _.DisabledChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("DisabledChanged", fn)
    /// Whether this step has an error.
    [<CustomOperation("HasError")>] member inline _.HasError ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HasError" =>>> true)
    /// Whether this step has an error.
    [<CustomOperation("HasError")>] member inline _.HasError ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HasError" =>>> x)
    /// Whether this step has an error.
    [<CustomOperation("HasError'")>] member inline _.HasError' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("HasError", valueFn)
    /// Occurs when HasError has changed.
    [<CustomOperation("HasErrorChanged")>] member inline _.HasErrorChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("HasErrorChanged", fn)
    /// Occurs when HasError has changed.
    [<CustomOperation("HasErrorChanged")>] member inline _.HasErrorChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("HasErrorChanged", fn)
    /// Occurs when this step is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when this step is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)

/// A wizard that guides the user through a series of steps to complete a transaction.
type MudStepperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The index of the currently active step.
    [<CustomOperation("ActiveIndex")>] member inline _.ActiveIndex ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ActiveIndex" => x)
    /// The index of the currently active step.
    [<CustomOperation("ActiveIndex'")>] member inline _.ActiveIndex' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Int32 * (System.Int32 -> unit)) = render ==> html.bind("ActiveIndex", valueFn)
    /// Occurs when ActiveIndex has changed.
    [<CustomOperation("ActiveIndexChanged")>] member inline _.ActiveIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> unit) = render ==> html.callback("ActiveIndexChanged", fn)
    /// Occurs when ActiveIndex has changed.
    [<CustomOperation("ActiveIndexChanged")>] member inline _.ActiveIndexChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Int32 -> Task<unit>) = render ==> html.callbackTask("ActiveIndexChanged", fn)
    /// The color of completed steps.
    [<CustomOperation("CompletedStepColor")>] member inline _.CompletedStepColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("CompletedStepColor" => x)
    /// The color of the current step.
    [<CustomOperation("CurrentStepColor")>] member inline _.CurrentStepColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("CurrentStepColor" => x)
    /// The color of steps with errors.
    [<CustomOperation("ErrorStepColor")>] member inline _.ErrorStepColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ErrorStepColor" => x)
    /// The icon shown for completed steps.
    [<CustomOperation("StepCompleteIcon")>] member inline _.StepCompleteIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StepCompleteIcon" => x)
    /// The icon shown for steps with errors.
    [<CustomOperation("StepErrorIcon")>] member inline _.StepErrorIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StepErrorIcon" => x)
    /// The icon shown for the reset button.
    [<CustomOperation("ResetButtonIcon")>] member inline _.ResetButtonIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ResetButtonIcon" => x)
    /// The icon shown for the Previous button.
    [<CustomOperation("PreviousButtonIcon")>] member inline _.PreviousButtonIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("PreviousButtonIcon" => x)
    /// The icon shown for the Skip button.
    [<CustomOperation("SkipButtonIcon")>] member inline _.SkipButtonIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SkipButtonIcon" => x)
    /// The icon shown for the Next button.
    [<CustomOperation("NextButtonIcon")>] member inline _.NextButtonIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextButtonIcon" => x)
    /// The icon shown for the Complete button.
    [<CustomOperation("CompleteButtonIcon")>] member inline _.CompleteButtonIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CompleteButtonIcon" => x)
    /// The CSS classes applied to the navigation bar.
    [<CustomOperation("NavClass")>] member inline _.NavClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NavClass" => x)
    /// Allows users to move between steps arbitrarily.
    [<CustomOperation("NonLinear")>] member inline _.NonLinear ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("NonLinear" =>>> true)
    /// Allows users to move between steps arbitrarily.
    [<CustomOperation("NonLinear")>] member inline _.NonLinear ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("NonLinear" =>>> x)
    /// Shows a button to start over at the first step.
    [<CustomOperation("ShowResetButton")>] member inline _.ShowResetButton ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowResetButton" =>>> true)
    /// Shows a button to start over at the first step.
    [<CustomOperation("ShowResetButton")>] member inline _.ShowResetButton ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowResetButton" =>>> x)
    /// Renders steps vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Vertical" =>>> true)
    /// Renders steps vertically.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Vertical" =>>> x)
    /// The CSS classes applied to all steps.
    [<CustomOperation("StepClass")>] member inline _.StepClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StepClass" => x)
    /// The CSS styles applied to all steps.
    [<CustomOperation("StepStyle")>] member inline _.StepStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("StepStyle" => x)
    /// Centers the labels for each step below the circle.
    [<CustomOperation("CenterLabels")>] member inline _.CenterLabels ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CenterLabels" =>>> true)
    /// Centers the labels for each step below the circle.
    [<CustomOperation("CenterLabels")>] member inline _.CenterLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CenterLabels" =>>> x)
    /// Displays a ripple effect when a step is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Displays a ripple effect when a step is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// Shows a scroll bar for steps if needed.
    [<CustomOperation("ScrollableNavigation")>] member inline _.ScrollableNavigation ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ScrollableNavigation" =>>> true)
    /// Shows a scroll bar for steps if needed.
    [<CustomOperation("ScrollableNavigation")>] member inline _.ScrollableNavigation ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ScrollableNavigation" =>>> x)
    /// Occurs when the user attempts to go to a step.
    [<CustomOperation("OnPreviewInteraction")>] member inline _.OnPreviewInteraction ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnPreviewInteraction" => (System.Func<MudBlazor.StepperInteractionEventArgs, System.Threading.Tasks.Task>fn))
    /// The custom template for displaying each step's title.
    [<CustomOperation("TitleTemplate")>] member inline _.TitleTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudStep -> NodeRenderFragment) = render ==> html.renderFragment("TitleTemplate", fn)
    /// The custom template for displaying each step's index and icon.
    [<CustomOperation("LabelTemplate")>] member inline _.LabelTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudStep -> NodeRenderFragment) = render ==> html.renderFragment("LabelTemplate", fn)
    /// The custom template for displaying lines connecting each step.
    [<CustomOperation("ConnectorTemplate")>] member inline _.ConnectorTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudStep -> NodeRenderFragment) = render ==> html.renderFragment("ConnectorTemplate", fn)
    /// This content is displayed when all steps are completed
    [<CustomOperation("CompletedContent")>] member inline _.CompletedContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("CompletedContent", fragment)
    /// This content is displayed when all steps are completed
    [<CustomOperation("CompletedContent")>] member inline _.CompletedContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("CompletedContent", fragment { yield! fragments })
    /// This content is displayed when all steps are completed
    [<CustomOperation("CompletedContent")>] member inline _.CompletedContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CompletedContent", html.text x)
    /// This content is displayed when all steps are completed
    [<CustomOperation("CompletedContent")>] member inline _.CompletedContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CompletedContent", html.text x)
    /// This content is displayed when all steps are completed
    [<CustomOperation("CompletedContent")>] member inline _.CompletedContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CompletedContent", html.text x)
    /// Use this to override the default action buttons of the stepper
    [<CustomOperation("ActionContent")>] member inline _.ActionContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudStepper -> NodeRenderFragment) = render ==> html.renderFragment("ActionContent", fn)

/// An area which receives swipe events.
type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Occurs when a swipe has on progress. Ignores sensitivity.
    [<CustomOperation("OnSwipeMove")>] member inline _.OnSwipeMove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MultiDimensionSwipeEventArgs -> unit) = render ==> html.callback("OnSwipeMove", fn)
    /// Occurs when a swipe has on progress. Ignores sensitivity.
    [<CustomOperation("OnSwipeMove")>] member inline _.OnSwipeMove ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MultiDimensionSwipeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnSwipeMove", fn)
    /// Occurs when a swipe has ended.
    [<CustomOperation("OnSwipeEnd")>] member inline _.OnSwipeEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.SwipeEventArgs -> unit) = render ==> html.callback("OnSwipeEnd", fn)
    /// Occurs when a swipe has ended.
    [<CustomOperation("OnSwipeEnd")>] member inline _.OnSwipeEnd ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.SwipeEventArgs -> Task<unit>) = render ==> html.callbackTask("OnSwipeEnd", fn)
    /// Occurs when a swipe leaves the area.
    [<CustomOperation("OnSwipeLeave")>] member inline _.OnSwipeLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.PointerEventArgs -> unit) = render ==> html.callback("OnSwipeLeave", fn)
    /// Occurs when a swipe leaves the area.
    [<CustomOperation("OnSwipeLeave")>] member inline _.OnSwipeLeave ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.PointerEventArgs -> Task<unit>) = render ==> html.callbackTask("OnSwipeLeave", fn)
    /// Occurs when a swipe cancelled.
    [<CustomOperation("OnSwipeCancel")>] member inline _.OnSwipeCancel ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.PointerEventArgs -> unit) = render ==> html.callback("OnSwipeCancel", fn)
    /// Occurs when a swipe cancelled.
    [<CustomOperation("OnSwipeCancel")>] member inline _.OnSwipeCancel ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.PointerEventArgs -> Task<unit>) = render ==> html.callbackTask("OnSwipeCancel", fn)
    /// The amount of pixels which must be swiped to raise the OnSwipeEnd event.
    [<CustomOperation("Sensitivity")>] member inline _.Sensitivity ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Sensitivity" => x)
    /// Prevents the default behavior of the browser when swiping.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("PreventDefault" =>>> true)
    /// Prevents the default behavior of the browser when swiping.
    [<CustomOperation("PreventDefault")>] member inline _.PreventDefault ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("PreventDefault" =>>> x)

/// A grouping of values for a column in a MudTable`1.
type MudTableGroupRowBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The definition for this grouping level.
    [<CustomOperation("GroupDefinition")>] member inline _.GroupDefinition ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TableGroupDefinition<'T>) = render ==> ("GroupDefinition" => x)
    /// The groups and items within this grouping.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Linq.IGrouping<System.Object, 'T>) = render ==> ("Items" => x)
    /// The custom content for this group's header.
    [<CustomOperation("HeaderTemplate")>] member inline _.HeaderTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("HeaderTemplate", fn)
    /// The custom content for this group's footer.
    [<CustomOperation("FooterTemplate")>] member inline _.FooterTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TableGroupData<System.Object, 'T> -> NodeRenderFragment) = render ==> html.renderFragment("FooterTemplate", fn)
    /// Displays a checkbox which selects or unselects all items within this group.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Checkable" =>>> true)
    /// Displays a checkbox which selects or unselects all items within this group.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Checkable" =>>> x)
    /// Prevents the change of the current selection of all items withing this group.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectionChangeable" =>>> true)
    /// Prevents the change of the current selection of all items withing this group.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectionChangeable" =>>> x)
    /// The CSS classes applied to this group's header.
    [<CustomOperation("HeaderClass")>] member inline _.HeaderClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderClass" => x)
    /// The CSS classes applied to this group's footer.
    [<CustomOperation("FooterClass")>] member inline _.FooterClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterClass" => x)
    /// The CSS styles applied to this group's header.
    [<CustomOperation("HeaderStyle")>] member inline _.HeaderStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HeaderStyle" => x)
    /// The CSS styles applied to this group's footer.
    [<CustomOperation("FooterStyle")>] member inline _.FooterStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FooterStyle" => x)
    /// The icon of the expand button when Expandable is true.
    [<CustomOperation("ExpandIcon")>] member inline _.ExpandIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandIcon" => x)
    /// The icon of the collapse button when Expandable is true.
    [<CustomOperation("CollapseIcon")>] member inline _.CollapseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CollapseIcon" => x)
    /// Occurs when a grouping row is clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnRowClick", fn)
    /// Occurs when a grouping row is clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)

/// A component which changes pages and page size for a MudTable`1.
type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Hides the list of page sizes.
    [<CustomOperation("HideRowsPerPage")>] member inline _.HideRowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideRowsPerPage" =>>> true)
    /// Hides the list of page sizes.
    [<CustomOperation("HideRowsPerPage")>] member inline _.HideRowsPerPage ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideRowsPerPage" =>>> x)
    /// Hides the current page number.
    [<CustomOperation("HidePageNumber")>] member inline _.HidePageNumber ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HidePageNumber" =>>> true)
    /// Hides the current page number.
    [<CustomOperation("HidePageNumber")>] member inline _.HidePageNumber ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HidePageNumber" =>>> x)
    /// Hides the list of page numbers.
    [<CustomOperation("HidePagination")>] member inline _.HidePagination ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HidePagination" =>>> true)
    /// Hides the list of page numbers.
    [<CustomOperation("HidePagination")>] member inline _.HidePagination ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HidePagination" =>>> x)
    /// The location of this pager relative to the parent MudTable`1.
    [<CustomOperation("HorizontalAlignment")>] member inline _.HorizontalAlignment ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.HorizontalAlignment) = render ==> ("HorizontalAlignment" => x)
    /// The list of page sizes.
    [<CustomOperation("PageSizeOptions")>] member inline _.PageSizeOptions ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32[]) = render ==> ("PageSizeOptions" => x)
    /// The format of the text label.
    [<CustomOperation("InfoFormat")>] member inline _.InfoFormat ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("InfoFormat" => x)
    /// The text displayed in the page-size dropdown when PageSizeOptions contains MaxValue.
    [<CustomOperation("AllItemsText")>] member inline _.AllItemsText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AllItemsText" => x)
    /// The text label for the current rows per page.
    [<CustomOperation("RowsPerPageString")>] member inline _.RowsPerPageString ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RowsPerPageString" => x)
    /// The icon for the "First Page" button.
    [<CustomOperation("FirstIcon")>] member inline _.FirstIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("FirstIcon" => x)
    /// The icon for the "Previous Page" button.
    [<CustomOperation("BeforeIcon")>] member inline _.BeforeIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BeforeIcon" => x)
    /// The icon for the "Next Page" button.
    [<CustomOperation("NextIcon")>] member inline _.NextIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NextIcon" => x)
    /// The icon for the "Last Page" button.
    [<CustomOperation("LastIcon")>] member inline _.LastIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LastIcon" => x)

/// A clickable column which toggles the sort column and direction for a MudTable`1.
type MudTableSortLabelBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The sort direction when the MudTable`1 is first displayed.
    [<CustomOperation("InitialDirection")>] member inline _.InitialDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("InitialDirection" => x)
    /// Allows sorting by this column.
    [<CustomOperation("Enabled")>] member inline _.Enabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Enabled" =>>> true)
    /// Allows sorting by this column.
    [<CustomOperation("Enabled")>] member inline _.Enabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Enabled" =>>> x)
    /// The icon for the sort button.
    [<CustomOperation("SortIcon")>] member inline _.SortIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortIcon" => x)
    /// Displays the icon before the label text.
    [<CustomOperation("AppendIcon")>] member inline _.AppendIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AppendIcon" =>>> true)
    /// Displays the icon before the label text.
    [<CustomOperation("AppendIcon")>] member inline _.AppendIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AppendIcon" =>>> x)
    /// The current sort direction of this column.
    [<CustomOperation("SortDirection")>] member inline _.SortDirection ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SortDirection) = render ==> ("SortDirection" => x)
    /// The current sort direction of this column.
    [<CustomOperation("SortDirection'")>] member inline _.SortDirection' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: MudBlazor.SortDirection * (MudBlazor.SortDirection -> unit)) = render ==> html.bind("SortDirection", valueFn)
    /// Occurs when SortDirection has changed.
    [<CustomOperation("SortDirectionChanged")>] member inline _.SortDirectionChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.SortDirection -> unit) = render ==> html.callback("SortDirectionChanged", fn)
    /// Occurs when SortDirection has changed.
    [<CustomOperation("SortDirectionChanged")>] member inline _.SortDirectionChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.SortDirection -> Task<unit>) = render ==> html.callbackTask("SortDirectionChanged", fn)
    /// The custom function for sorting rows for this sort label.
    [<CustomOperation("SortBy")>] member inline _.SortBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("SortBy" => (System.Func<'T, System.Object>fn))
    /// The text for this sort label.
    [<CustomOperation("SortLabel")>] member inline _.SortLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortLabel" => x)

/// A cell within a MudTr, MudTHeadRow, or MudTFootRow row component.
type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The label for this cell when the table is in small-device mode.
    [<CustomOperation("DataLabel")>] member inline _.DataLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DataLabel" => x)
    /// Hides this cell if the breakpoint is smaller than Breakpoint.
    [<CustomOperation("HideSmall")>] member inline _.HideSmall ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideSmall" =>>> true)
    /// Hides this cell if the breakpoint is smaller than Breakpoint.
    [<CustomOperation("HideSmall")>] member inline _.HideSmall ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideSmall" =>>> x)

/// A footer row displayed at the bottom of a MudTable`1 and each group.
type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Shows a checkbox which selects or deselects every row in the group.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Checkable" =>>> true)
    /// Shows a checkbox which selects or deselects every row in the group.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Checkable" =>>> x)
    /// Prevents the change of the current selection of rows in the group.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectionChangeable" =>>> true)
    /// Prevents the change of the current selection of rows in the group.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectionChangeable" =>>> x)
    /// Hides the extra column displayed when MultiSelection is true.
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IgnoreCheckbox" =>>> true)
    /// Hides the extra column displayed when MultiSelection is true.
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IgnoreCheckbox" =>>> x)
    /// Hides the extra column displayed when Editable is true.
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IgnoreEditable" =>>> true)
    /// Hides the extra column displayed when Editable is true.
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IgnoreEditable" =>>> x)
    /// Shows an additional left and right margin when the parent group is expandable.
    [<CustomOperation("Expandable")>] member inline _.Expandable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expandable" =>>> true)
    /// Shows an additional left and right margin when the parent group is expandable.
    [<CustomOperation("Expandable")>] member inline _.Expandable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expandable" =>>> x)
    /// Occurs when this footer row is clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnRowClick", fn)
    /// Occurs when this footer row is clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)

/// A header cell which labels a column of data for a MudTable`1.
type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()


/// A header row displayed at the top of a MudTable`1 and each group.
type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Shows a checkbox which selects or deselects every row in the group.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Checkable" =>>> true)
    /// Shows a checkbox which selects or deselects every row in the group.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Checkable" =>>> x)
    /// Prevents the change of the current selection of rows in the group.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectionChangeable" =>>> true)
    /// Prevents the change of the current selection of rows in the group.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectionChangeable" =>>> x)
    /// Hides the extra column displayed when MultiSelection is true.
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IgnoreCheckbox" =>>> true)
    /// Hides the extra column displayed when MultiSelection is true.
    [<CustomOperation("IgnoreCheckbox")>] member inline _.IgnoreCheckbox ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IgnoreCheckbox" =>>> x)
    /// Hides the extra column displayed when Editable is true.
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IgnoreEditable" =>>> true)
    /// Hides the extra column displayed when Editable is true.
    [<CustomOperation("IgnoreEditable")>] member inline _.IgnoreEditable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IgnoreEditable" =>>> x)
    /// Shows an additional left and right margin when the parent group is expandable.
    [<CustomOperation("Expandable")>] member inline _.Expandable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expandable" =>>> true)
    /// Shows an additional left and right margin when the parent group is expandable.
    [<CustomOperation("Expandable")>] member inline _.Expandable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expandable" =>>> x)
    /// Occurs when this header row is clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnRowClick", fn)
    /// Occurs when this header row is clicked.
    [<CustomOperation("OnRowClick")>] member inline _.OnRowClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnRowClick", fn)

/// A row of data within a MudTable`1.
type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The data being displayed for this row.
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Item" => x)
    /// Displays a checkbox at the start of this row.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Checkable" =>>> true)
    /// Displays a checkbox at the start of this row.
    [<CustomOperation("Checkable")>] member inline _.Checkable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Checkable" =>>> x)
    /// Prevents the change of the current selection.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("SelectionChangeable" =>>> true)
    /// Prevents the change of the current selection.
    [<CustomOperation("SelectionChangeable")>] member inline _.SelectionChangeable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("SelectionChangeable" =>>> x)
    /// Allows this row to be edited.
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Editable" =>>> true)
    /// Allows this row to be edited.
    [<CustomOperation("Editable")>] member inline _.Editable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Editable" =>>> x)
    /// Allows this row to expand to display nested content.
    [<CustomOperation("Expandable")>] member inline _.Expandable ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expandable" =>>> true)
    /// Allows this row to expand to display nested content.
    [<CustomOperation("Expandable")>] member inline _.Expandable ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expandable" =>>> x)
    /// Occurs when Checked has changed.
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("CheckedChanged", fn)
    /// Occurs when Checked has changed.
    [<CustomOperation("CheckedChanged")>] member inline _.CheckedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("CheckedChanged", fn)
    /// The state of the checkbox when Checkable is true.
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Checked" =>>> true)
    /// The state of the checkbox when Checkable is true.
    [<CustomOperation("Checked")>] member inline _.Checked ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Checked" =>>> x)
    /// The state of the checkbox when Checkable is true.
    [<CustomOperation("Checked'")>] member inline _.Checked' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Checked", valueFn)

/// A table similar to MudTable`1 but with basic styling features.
type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The size of the drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Highlights rows when hovering over them.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hover" =>>> true)
    /// Highlights rows when hovering over them.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hover" =>>> x)
    /// Uses square corners for the table.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Square" =>>> true)
    /// Uses square corners for the table.
    [<CustomOperation("Square")>] member inline _.Square ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Square" =>>> x)
    /// Uses compact padding for all rows.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact padding for all rows.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Shows borders around the table.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Shows borders around the table.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)
    /// Shows left and right borders for each table cell.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Bordered" =>>> true)
    /// Shows left and right borders for each table cell.
    [<CustomOperation("Bordered")>] member inline _.Bordered ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Bordered" =>>> x)
    /// Uses alternating colors for table rows.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Striped" =>>> true)
    /// Uses alternating colors for table rows.
    [<CustomOperation("Striped")>] member inline _.Striped ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Striped" =>>> x)
    /// Fixes the table header in place while the table is scrolled.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FixedHeader" =>>> true)
    /// Fixes the table header in place while the table is scrolled.
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FixedHeader" =>>> x)

/// A tab as part of a MudTabs or MudDynamicTabs component.
type MudTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The title of this tab panel.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The icon for this tab.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The color of this tab's icon.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Prevents the user from interacting with this panel.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this panel.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Shows the tab.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Shows the tab.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// For dynamic tabs, shows a "Close" icon for this tab.
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowCloseIcon" =>>> true)
    /// For dynamic tabs, shows a "Close" icon for this tab.
    [<CustomOperation("ShowCloseIcon")>] member inline _.ShowCloseIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowCloseIcon" =>>> x)
    /// The badge shown for this tab.
    [<CustomOperation("BadgeData")>] member inline _.BadgeData ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("BadgeData" => x)
    /// Optional icon to be shown in the badge instead of text.
    [<CustomOperation("BadgeIcon")>] member inline _.BadgeIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BadgeIcon" => x)
    /// Shows a dot instead of text or icon for the badge.
    [<CustomOperation("BadgeDot")>] member inline _.BadgeDot ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("BadgeDot" =>>> true)
    /// Shows a dot instead of text or icon for the badge.
    [<CustomOperation("BadgeDot")>] member inline _.BadgeDot ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("BadgeDot" =>>> x)
    /// The color of the badge.
    [<CustomOperation("BadgeColor")>] member inline _.BadgeColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("BadgeColor" => x)
    /// The unique ID for this panel.
    [<CustomOperation("ID")>] member inline _.ID ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("ID" => x)
    /// Occurs when this tab is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when this tab is clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// The content within this tab's title.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TabContent", fragment)
    /// The content within this tab's title.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TabContent", fragment { yield! fragments })
    /// The content within this tab's title.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TabContent", html.text x)
    /// The content within this tab's title.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TabContent", html.text x)
    /// The content within this tab's title.
    [<CustomOperation("TabContent")>] member inline _.TabContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TabContent", html.text x)
    /// The content enclosing this tab.
    [<CustomOperation("TabWrapperContent")>] member inline _.TabWrapperContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.RenderFragment -> NodeRenderFragment) = render ==> html.renderFragment("TabWrapperContent", fn)
    /// The tooltip displayed for this tab.
    [<CustomOperation("ToolTip")>] member inline _.ToolTip ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ToolTip" => x)
    /// Value to use when ordering tabs lexicographically, in place of Text.
    [<CustomOperation("SortKey")>] member inline _.SortKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SortKey" => x)

/// A chronological item displayed as part of a MudTimeline
type MudTimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// (Obsolete) The icon displayed for the dot.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The display variant for the dot.
    [<CustomOperation("Variant")>] member inline _.Variant ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Variant) = render ==> ("Variant" => x)
    /// The CSS styles applied to the dot.
    [<CustomOperation("DotStyle")>] member inline _.DotStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("DotStyle" => x)
    /// The color of the dot.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The size of the dot.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The size of the dot's drop shadow.
    [<CustomOperation("Elevation")>] member inline _.Elevation ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("Elevation" => x)
    /// Overrides TimelineAlign with a custom value.
    [<CustomOperation("TimelineAlign")>] member inline _.TimelineAlign ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.TimelineAlign) = render ==> ("TimelineAlign" => x)
    /// Hides the dot for this item.
    [<CustomOperation("HideDot")>] member inline _.HideDot ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("HideDot" =>>> true)
    /// Hides the dot for this item.
    [<CustomOperation("HideDot")>] member inline _.HideDot ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("HideDot" =>>> x)
    /// The custom content for the opposite side of this item.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ItemOpposite", fragment)
    /// The custom content for the opposite side of this item.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ItemOpposite", fragment { yield! fragments })
    /// The custom content for the opposite side of this item.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemOpposite", html.text x)
    /// The custom content for the opposite side of this item.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemOpposite", html.text x)
    /// The custom content for the opposite side of this item.
    [<CustomOperation("ItemOpposite")>] member inline _.ItemOpposite ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemOpposite", html.text x)
    /// The custom content for this item.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ItemContent", fragment)
    /// The custom content for this item.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ItemContent", fragment { yield! fragments })
    /// The custom content for this item.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemContent", html.text x)
    /// The custom content for this item.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemContent", html.text x)
    /// The custom content for this item.
    [<CustomOperation("ItemContent")>] member inline _.ItemContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemContent", html.text x)
    /// The custom content for the dot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("ItemDot", fragment)
    /// The custom content for the dot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("ItemDot", fragment { yield! fragments })
    /// The custom content for the dot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ItemDot", html.text x)
    /// The custom content for the dot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ItemDot", html.text x)
    /// The custom content for the dot.
    [<CustomOperation("ItemDot")>] member inline _.ItemDot ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ItemDot", html.text x)

/// Maintains the selection of a group of MudToggleItem`1 components.
type MudToggleGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prevents the user from interacting with this toggle group.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this toggle group.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The currently selected value.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The currently selected value.
    [<CustomOperation("Value'")>] member inline _.Value' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("Value", valueFn)
    /// Occurs when Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("ValueChanged", fn)
    /// Occurs when Value has changed.
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("ValueChanged", fn)
    /// The currently selected values.
    [<CustomOperation("Values")>] member inline _.Values ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'T>) = render ==> ("Values" => x)
    /// The currently selected values.
    [<CustomOperation("Values'")>] member inline _.Values' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IEnumerable<'T> * (System.Collections.Generic.IEnumerable<'T> -> unit)) = render ==> html.bind("Values", valueFn)
    /// Occurs when Values has changed.
    [<CustomOperation("ValuesChanged")>] member inline _.ValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'T> -> unit) = render ==> html.callback("ValuesChanged", fn)
    /// Occurs when Values has changed.
    [<CustomOperation("ValuesChanged")>] member inline _.ValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IEnumerable<'T> -> Task<unit>) = render ==> html.callbackTask("ValuesChanged", fn)
    /// The CSS classes applied to selected items.
    [<CustomOperation("SelectedClass")>] member inline _.SelectedClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedClass" => x)
    /// The CSS classes applied to checkmark icons.
    [<CustomOperation("CheckMarkClass")>] member inline _.CheckMarkClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckMarkClass" => x)
    /// Uses a vertical layout for items.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Vertical" =>>> true)
    /// Uses a vertical layout for items.
    [<CustomOperation("Vertical")>] member inline _.Vertical ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Vertical" =>>> x)
    /// Shows an outline border.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Outlined" =>>> true)
    /// Shows an outline border.
    [<CustomOperation("Outlined")>] member inline _.Outlined ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Outlined" =>>> x)
    /// Shows a line delimiter between each item.
    [<CustomOperation("Delimiters")>] member inline _.Delimiters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Delimiters" =>>> true)
    /// Shows a line delimiter between each item.
    [<CustomOperation("Delimiters")>] member inline _.Delimiters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Delimiters" =>>> x)
    /// Show a ripple effect when the user clicks an item.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Show a ripple effect when the user clicks an item.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// The size of each toggle item.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The selection behavior for this group.
    [<CustomOperation("SelectionMode")>] member inline _.SelectionMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SelectionMode) = render ==> ("SelectionMode" => x)
    /// The color of borders and the current selections.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Shows a checkmark next to each item.
    [<CustomOperation("CheckMark")>] member inline _.CheckMark ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CheckMark" =>>> true)
    /// Shows a checkmark next to each item.
    [<CustomOperation("CheckMark")>] member inline _.CheckMark ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CheckMark" =>>> x)
    /// Reserves space for checkmarks even when CheckMark is false.
    [<CustomOperation("FixedContent")>] member inline _.FixedContent ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("FixedContent" =>>> true)
    /// Reserves space for checkmarks even when CheckMark is false.
    [<CustomOperation("FixedContent")>] member inline _.FixedContent ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("FixedContent" =>>> x)

/// An item as part of a MudToggleGroup`1
type MudToggleItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Prevents the user from interacting with this item.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this item.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// The value associated with this item.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The icon shown for the unselected checkmark.
    [<CustomOperation("UnselectedIcon")>] member inline _.UnselectedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UnselectedIcon" => x)
    /// The icon shown for the selected checkmark.
    [<CustomOperation("SelectedIcon")>] member inline _.SelectedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedIcon" => x)
    /// The text shown for this item.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The custom content shown for this item.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)

/// A set of action buttons.  
type MudToolBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Uses compact vertical padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact vertical padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Adds left and right padding.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Gutters" =>>> true)
    /// Adds left and right padding.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Gutters" =>>> x)
    /// Allows the toolbar's content to wrap.
    [<CustomOperation("WrapContent")>] member inline _.WrapContent ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("WrapContent" =>>> true)
    /// Allows the toolbar's content to wrap.
    [<CustomOperation("WrapContent")>] member inline _.WrapContent ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("WrapContent" =>>> x)

/// A small popup which provides more information.
type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The tooltip color.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The tooltip text.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// Displays an arrow pointing towards the tooltip content.
    [<CustomOperation("Arrow")>] member inline _.Arrow ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Arrow" =>>> true)
    /// Displays an arrow pointing towards the tooltip content.
    [<CustomOperation("Arrow")>] member inline _.Arrow ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Arrow" =>>> x)
    /// The length of time to animate the opening transition.
    [<CustomOperation("Duration")>] member inline _.Duration ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Duration" => x)
    /// The amount of time, in milliseconds, to wait from opening the popover before performing the transition. 
    [<CustomOperation("Delay'")>] member inline _.Delay' ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Delay" => x)
    /// The location of the tooltip relative to its content.
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Placement) = render ==> ("Placement" => x)
    /// The content of the tooltip.
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("TooltipContent", fragment)
    /// The content of the tooltip.
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("TooltipContent", fragment { yield! fragments })
    /// The content of the tooltip.
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("TooltipContent", html.text x)
    /// The content of the tooltip.
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("TooltipContent", html.text x)
    /// The content of the tooltip.
    [<CustomOperation("TooltipContent")>] member inline _.TooltipContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("TooltipContent", html.text x)
    /// Displays this tooltip inline with its container.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Inline" =>>> true)
    /// Displays this tooltip inline with its container.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Inline" =>>> x)
    /// Any CSS styles applied to the tooltip.
    [<CustomOperation("RootStyle")>] member inline _.RootStyle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootStyle" => x)
    /// Any CSS classes applied to the tooltip.
    [<CustomOperation("RootClass")>] member inline _.RootClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("RootClass" => x)
    /// Shows this tooltip when hovering over its content.
    [<CustomOperation("ShowOnHover")>] member inline _.ShowOnHover ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowOnHover" =>>> true)
    /// Shows this tooltip when hovering over its content.
    [<CustomOperation("ShowOnHover")>] member inline _.ShowOnHover ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowOnHover" =>>> x)
    /// Shows this tooltip when its content is focused.
    [<CustomOperation("ShowOnFocus")>] member inline _.ShowOnFocus ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowOnFocus" =>>> true)
    /// Shows this tooltip when its content is focused.
    [<CustomOperation("ShowOnFocus")>] member inline _.ShowOnFocus ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowOnFocus" =>>> x)
    /// Shows this tooltip when its content is clicked.
    [<CustomOperation("ShowOnClick")>] member inline _.ShowOnClick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowOnClick" =>>> true)
    /// Shows this tooltip when its content is clicked.
    [<CustomOperation("ShowOnClick")>] member inline _.ShowOnClick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowOnClick" =>>> x)
    /// Shows this tooltip.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Shows this tooltip.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Shows this tooltip.
    [<CustomOperation("Visible'")>] member inline _.Visible' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Visible", valueFn)
    /// Occurs when Visible has changed.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("VisibleChanged", fn)
    /// Occurs when Visible has changed.
    [<CustomOperation("VisibleChanged")>] member inline _.VisibleChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("VisibleChanged", fn)
    /// Prevents this tooltip from being displayed.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents this tooltip from being displayed.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)

/// A hierarchical tree of expandable items with optional value selection.
type MudTreeViewBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The color of the selected item.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The color of checkboxes.
    [<CustomOperation("CheckBoxColor")>] member inline _.CheckBoxColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("CheckBoxColor" => x)
    /// Controls how many items can be selected at one time.
    [<CustomOperation("SelectionMode")>] member inline _.SelectionMode ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.SelectionMode) = render ==> ("SelectionMode" => x)
    /// Uses checkboxes which support an undetermined state.
    [<CustomOperation("TriState")>] member inline _.TriState ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("TriState" =>>> true)
    /// Uses checkboxes which support an undetermined state.
    [<CustomOperation("TriState")>] member inline _.TriState ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("TriState" =>>> x)
    /// Automatically checks an item if all children are selected.
    [<CustomOperation("AutoSelectParent")>] member inline _.AutoSelectParent ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoSelectParent" =>>> true)
    /// Automatically checks an item if all children are selected.
    [<CustomOperation("AutoSelectParent")>] member inline _.AutoSelectParent ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoSelectParent" =>>> x)
    /// Expands an item with children if it is clicked anywhere (not just the expand/collapse buttons).
    [<CustomOperation("ExpandOnClick")>] member inline _.ExpandOnClick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ExpandOnClick" =>>> true)
    /// Expands an item with children if it is clicked anywhere (not just the expand/collapse buttons).
    [<CustomOperation("ExpandOnClick")>] member inline _.ExpandOnClick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ExpandOnClick" =>>> x)
    /// Expands an item with children if it is double-clicked anywhere (not just the expand/collapse buttons).
    [<CustomOperation("ExpandOnDoubleClick")>] member inline _.ExpandOnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ExpandOnDoubleClick" =>>> true)
    /// Expands an item with children if it is double-clicked anywhere (not just the expand/collapse buttons).
    [<CustomOperation("ExpandOnDoubleClick")>] member inline _.ExpandOnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ExpandOnDoubleClick" =>>> x)
    /// Automatically expands items to show selected children.
    [<CustomOperation("AutoExpand")>] member inline _.AutoExpand ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("AutoExpand" =>>> true)
    /// Automatically expands items to show selected children.
    [<CustomOperation("AutoExpand")>] member inline _.AutoExpand ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("AutoExpand" =>>> x)
    /// Shows an effect when items are hovered over.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hover" =>>> true)
    /// Shows an effect when items are hovered over.
    [<CustomOperation("Hover")>] member inline _.Hover ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hover" =>>> x)
    /// Uses compact vertical padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Dense" =>>> true)
    /// Uses compact vertical padding.
    [<CustomOperation("Dense")>] member inline _.Dense ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Dense" =>>> x)
    /// Sets a fixed height.
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Height" => x)
    /// Sets a maximum height.
    [<CustomOperation("MaxHeight")>] member inline _.MaxHeight ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("MaxHeight" => x)
    /// Sets a fixed width.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Width" => x)
    /// Prevents the user from interacting with any items.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with any items.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Determines whether items are displayed.
    [<CustomOperation("FilterFunc")>] member inline _.FilterFunc ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FilterFunc" => (System.Func<MudBlazor.TreeItemData<'T>, System.Threading.Tasks.Task<System.Boolean>>fn))
    /// Shows a ripple effect when an item is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Ripple" =>>> true)
    /// Shows a ripple effect when an item is clicked.
    [<CustomOperation("Ripple")>] member inline _.Ripple ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Ripple" =>>> x)
    /// The items being displayed.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T>>) = render ==> ("Items" => x)
    /// The currently selected value.
    [<CustomOperation("SelectedValue")>] member inline _.SelectedValue ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("SelectedValue" => x)
    /// The currently selected value.
    [<CustomOperation("SelectedValue'")>] member inline _.SelectedValue' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: 'T * ('T -> unit)) = render ==> html.bind("SelectedValue", valueFn)
    /// Occurs when SelectedValue has changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) = render ==> html.callback("SelectedValueChanged", fn)
    /// Occurs when SelectedValue has changed.
    [<CustomOperation("SelectedValueChanged")>] member inline _.SelectedValueChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> Task<unit>) = render ==> html.callbackTask("SelectedValueChanged", fn)
    /// The currently selected values.
    [<CustomOperation("SelectedValues")>] member inline _.SelectedValues ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyCollection<'T>) = render ==> ("SelectedValues" => x)
    /// The currently selected values.
    [<CustomOperation("SelectedValues'")>] member inline _.SelectedValues' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IReadOnlyCollection<'T> * (System.Collections.Generic.IReadOnlyCollection<'T> -> unit)) = render ==> html.bind("SelectedValues", valueFn)
    /// Occurs when SelectedValues has changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyCollection<'T> -> unit) = render ==> html.callback("SelectedValuesChanged", fn)
    /// Occurs when SelectedValues has changed.
    [<CustomOperation("SelectedValuesChanged")>] member inline _.SelectedValuesChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyCollection<'T> -> Task<unit>) = render ==> html.callbackTask("SelectedValuesChanged", fn)
    /// The template for rendering each item.
    [<CustomOperation("ItemTemplate")>] member inline _.ItemTemplate ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.TreeItemData<'T> -> NodeRenderFragment) = render ==> html.renderFragment("ItemTemplate", fn)
    /// The comparer used to check if two items are equal.
    [<CustomOperation("Comparer")>] member inline _.Comparer ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEqualityComparer<'T>) = render ==> ("Comparer" => x)
    /// The function for asynchronously loading items.
    [<CustomOperation("ServerData")>] member inline _.ServerData ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ServerData" => (System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T>>>>fn))
    /// Prevents selections from being changed.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents selections from being changed.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// The icon displayed for checked items.
    [<CustomOperation("CheckedIcon")>] member inline _.CheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("CheckedIcon" => x)
    /// The icon displayed for unchecked items.
    [<CustomOperation("UncheckedIcon")>] member inline _.UncheckedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("UncheckedIcon" => x)
    /// The icon displayed for indeterminate items.
    [<CustomOperation("IndeterminateIcon")>] member inline _.IndeterminateIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IndeterminateIcon" => x)

/// An expandable branch of a MudTreeView`1.
type MudTreeViewItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The value associated with this item.
    [<CustomOperation("Value")>] member inline _.Value ([<InlineIfLambda>] render: AttrRenderFragment, x: 'T) = render ==> ("Value" => x)
    /// The text to display.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The size of the text.
    [<CustomOperation("TextTypo")>] member inline _.TextTypo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("TextTypo" => x)
    /// The CSS classes applied to the Text parameter.
    [<CustomOperation("TextClass")>] member inline _.TextClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("TextClass" => x)
    /// The text at the end of the item.
    [<CustomOperation("EndText")>] member inline _.EndText ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndText" => x)
    /// The size of the end text.
    [<CustomOperation("EndTextTypo")>] member inline _.EndTextTypo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("EndTextTypo" => x)
    /// The CSS classes applied to the EndText parameter.
    [<CustomOperation("EndTextClass")>] member inline _.EndTextClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndTextClass" => x)
    /// Whether this item and its children are displayed.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Whether this item and its children are displayed.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Prevents the user from interacting with this item.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this item.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Prevents this item from being selected.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ReadOnly" =>>> true)
    /// Prevents this item from being selected.
    [<CustomOperation("ReadOnly")>] member inline _.ReadOnly ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ReadOnly" =>>> x)
    /// Allows this item to expand to display children.
    [<CustomOperation("CanExpand")>] member inline _.CanExpand ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("CanExpand" =>>> true)
    /// Allows this item to expand to display children.
    [<CustomOperation("CanExpand")>] member inline _.CanExpand ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("CanExpand" =>>> x)
    /// The custom content within this item.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Content", fragment)
    /// The custom content within this item.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    /// The custom content within this item.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    /// The custom content within this item.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    /// The custom content within this item.
    [<CustomOperation("Content")>] member inline _.Content ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    /// The custom content for the text, end text, and end icon.
    [<CustomOperation("BodyContent")>] member inline _.BodyContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: MudBlazor.MudTreeViewItem<'T> -> NodeRenderFragment) = render ==> html.renderFragment("BodyContent", fn)
    /// The child items underneath this item.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T>>) = render ==> ("Items" => x)
    /// The child items underneath this item.
    [<CustomOperation("Items'")>] member inline _.Items' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T>> * (System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T>> -> unit)) = render ==> html.bind("Items", valueFn)
    /// Occurs when Items has changed.
    [<CustomOperation("ItemsChanged")>] member inline _.ItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T>> -> unit) = render ==> html.callback("ItemsChanged", fn)
    /// Occurs when Items has changed.
    [<CustomOperation("ItemsChanged")>] member inline _.ItemsChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Collections.Generic.IReadOnlyCollection<MudBlazor.TreeItemData<'T>> -> Task<unit>) = render ==> html.callbackTask("ItemsChanged", fn)
    /// Shows the children items underneath this item.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Shows the children items underneath this item.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Shows the children items underneath this item.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Occurs when Expanded has changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Occurs when Expanded has changed.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// Selects this item.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Selected" =>>> true)
    /// Selects this item.
    [<CustomOperation("Selected")>] member inline _.Selected ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Selected" =>>> x)
    /// Selects this item.
    [<CustomOperation("Selected'")>] member inline _.Selected' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Selected", valueFn)
    /// The item shown before the text.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// The icon shown when this item is expanded.
    [<CustomOperation("IconExpanded")>] member inline _.IconExpanded ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("IconExpanded" => x)
    /// The color of the icon when Icon is set.
    [<CustomOperation("IconColor")>] member inline _.IconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("IconColor" => x)
    /// Icon placed after the text if set.
    [<CustomOperation("EndIcon")>] member inline _.EndIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("EndIcon" => x)
    /// The color of the end icon when EndIcon is set.
    [<CustomOperation("EndIconColor")>] member inline _.EndIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("EndIconColor" => x)
    /// The icon shown for the expand/collapse button.
    [<CustomOperation("ExpandButtonIcon")>] member inline _.ExpandButtonIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandButtonIcon" => x)
    /// The color of the expand/collapse button.
    [<CustomOperation("ExpandButtonIconColor")>] member inline _.ExpandButtonIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandButtonIconColor" => x)
    /// The icon shown while this item is loading.
    [<CustomOperation("LoadingIcon")>] member inline _.LoadingIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LoadingIcon" => x)
    /// The color of the loading icon.
    [<CustomOperation("LoadingIconColor")>] member inline _.LoadingIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingIconColor" => x)
    /// Occurs when Selected has changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("SelectedChanged", fn)
    /// Occurs when Selected has changed.
    [<CustomOperation("SelectedChanged")>] member inline _.SelectedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("SelectedChanged", fn)
    /// Occurs when this item has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnClick", fn)
    /// Occurs when this item has been clicked.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnClick", fn)
    /// Occurs when this item has been double-clicked.
    [<CustomOperation("OnDoubleClick")>] member inline _.OnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("OnDoubleClick", fn)
    /// Occurs when this item has been double-clicked.
    [<CustomOperation("OnDoubleClick")>] member inline _.OnDoubleClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("OnDoubleClick", fn)

/// Toggles the expansion state of a MudTreeViewItem`1.
type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Shows this button.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Visible" =>>> true)
    /// Shows this button.
    [<CustomOperation("Visible")>] member inline _.Visible ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Visible" =>>> x)
    /// Prevents the user from interacting with this button.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Disabled" =>>> true)
    /// Prevents the user from interacting with this button.
    [<CustomOperation("Disabled")>] member inline _.Disabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Disabled" =>>> x)
    /// Whether this button is in the "expanded" state.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Expanded" =>>> true)
    /// Whether this button is in the "expanded" state.
    [<CustomOperation("Expanded")>] member inline _.Expanded ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Expanded" =>>> x)
    /// Whether this button is in the "expanded" state.
    [<CustomOperation("Expanded'")>] member inline _.Expanded' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Expanded", valueFn)
    /// Displays the loading icon.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Loading" =>>> true)
    /// Displays the loading icon.
    [<CustomOperation("Loading")>] member inline _.Loading ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Loading" =>>> x)
    /// Occurs when Expanded.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("ExpandedChanged", fn)
    /// Occurs when Expanded.
    [<CustomOperation("ExpandedChanged")>] member inline _.ExpandedChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("ExpandedChanged", fn)
    /// The icon shown when in the "loading" state.
    [<CustomOperation("LoadingIcon")>] member inline _.LoadingIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("LoadingIcon" => x)
    /// The color of the loading icon.
    [<CustomOperation("LoadingIconColor")>] member inline _.LoadingIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("LoadingIconColor" => x)
    /// The expand/collapse icon.
    [<CustomOperation("ExpandedIcon")>] member inline _.ExpandedIcon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ExpandedIcon" => x)
    /// The color of the expand/collapse icon.
    [<CustomOperation("ExpandedIconColor")>] member inline _.ExpandedIconColor ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("ExpandedIconColor" => x)

/// A customizable piece of text.
type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// The theme style of the text.
    [<CustomOperation("Typo")>] member inline _.Typo ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Typo) = render ==> ("Typo" => x)
    /// The horizontal alignment of this text.
    [<CustomOperation("Align")>] member inline _.Align ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Align) = render ==> ("Align" => x)
    /// The color of this text.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// Adds a bottom margin.
    [<CustomOperation("GutterBottom")>] member inline _.GutterBottom ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("GutterBottom" =>>> true)
    /// Adds a bottom margin.
    [<CustomOperation("GutterBottom")>] member inline _.GutterBottom ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("GutterBottom" =>>> x)
    /// Whether this text continues on the same line.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Inline" =>>> true)
    /// Whether this text continues on the same line.
    [<CustomOperation("Inline")>] member inline _.Inline ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Inline" =>>> x)
    /// The HTML element used for this text.         that will be rendered (Example: span, p, h1).
    [<CustomOperation("HtmlTag")>] member inline _.HtmlTag ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("HtmlTag" => x)

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    /// Set the max-width to match the min-width of the current breakpoint. This is useful if you'd prefer to design for a fixed set of sizes instead of trying to accommodate a fully fluid viewport. It's fluid by default.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Fixed" =>>> true)
    /// Set the max-width to match the min-width of the current breakpoint. This is useful if you'd prefer to design for a fixed set of sizes instead of trying to accommodate a fully fluid viewport. It's fluid by default.
    [<CustomOperation("Fixed")>] member inline _.Fixed ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Fixed" =>>> x)
    /// Determine the max-width of the container. The container width grows with the size of the screen. Set to false to disable maxWidth.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MaxWidth) = render ==> ("MaxWidth" => x)
    /// Adds left and right padding to the container itself.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Gutters" =>>> true)
    /// Adds left and right padding to the container itself.
    [<CustomOperation("Gutters")>] member inline _.Gutters ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Gutters" =>>> x)

/// Provides a standard set of colors, shapes, sizes and shadows to a layout.
type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBaseWithStateBuilder<'FunBlazorGeneric>()
    /// The theme used by the application.
    [<CustomOperation("Theme")>] member inline _.Theme ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.MudTheme) = render ==> ("Theme" => x)
    /// Uses the browser default scrollbar instead of the MudBlazor scrollbar. 
    [<CustomOperation("DefaultScrollbar")>] member inline _.DefaultScrollbar ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("DefaultScrollbar" =>>> true)
    /// Uses the browser default scrollbar instead of the MudBlazor scrollbar. 
    [<CustomOperation("DefaultScrollbar")>] member inline _.DefaultScrollbar ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("DefaultScrollbar" =>>> x)
    /// Detects when the system theme has changed between Light Mode and Dark Mode.
    [<CustomOperation("ObserveSystemThemeChange")>] member inline _.ObserveSystemThemeChange ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ObserveSystemThemeChange" =>>> true)
    /// Detects when the system theme has changed between Light Mode and Dark Mode.
    [<CustomOperation("ObserveSystemThemeChange")>] member inline _.ObserveSystemThemeChange ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ObserveSystemThemeChange" =>>> x)
    /// Uses darker colors for all MudBlazor components.
    [<CustomOperation("IsDarkMode")>] member inline _.IsDarkMode ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("IsDarkMode" =>>> true)
    /// Uses darker colors for all MudBlazor components.
    [<CustomOperation("IsDarkMode")>] member inline _.IsDarkMode ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsDarkMode" =>>> x)
    /// Uses darker colors for all MudBlazor components.
    [<CustomOperation("IsDarkMode'")>] member inline _.IsDarkMode' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("IsDarkMode", valueFn)
    /// Occurs when IsDarkMode has changed.
    [<CustomOperation("IsDarkModeChanged")>] member inline _.IsDarkModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("IsDarkModeChanged", fn)
    /// Occurs when IsDarkMode has changed.
    [<CustomOperation("IsDarkModeChanged")>] member inline _.IsDarkModeChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("IsDarkModeChanged", fn)

/// Represents a segment in a list of breadcrumbs.
type BreadcrumbLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// The item to display.
    [<CustomOperation("Item")>] member inline _.Item ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.BreadcrumbItem) = render ==> ("Item" => x)

/// Represents a divider between breadcrumb items.
type BreadcrumbSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


/// Represents a checkbox column used to select rows in a MudDataGrid`1.
type SelectColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Shows a checkbox in the header.
    [<CustomOperation("ShowInHeader")>] member inline _.ShowInHeader ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowInHeader" =>>> true)
    /// Shows a checkbox in the header.
    [<CustomOperation("ShowInHeader")>] member inline _.ShowInHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowInHeader" =>>> x)
    /// Shows a checkbox in the footer.
    [<CustomOperation("ShowInFooter")>] member inline _.ShowInFooter ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("ShowInFooter" =>>> true)
    /// Shows a checkbox in the footer.
    [<CustomOperation("ShowInFooter")>] member inline _.ShowInFooter ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("ShowInFooter" =>>> x)
    /// The size of the checkbox icon.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// Allows this column to be reordered via drag-and-drop operations.
    [<CustomOperation("DragAndDropEnabled")>] member inline _.DragAndDropEnabled ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("DragAndDropEnabled" => x)
    /// Allows this column to be hidden.
    [<CustomOperation("Hideable")>] member inline _.Hideable ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("Hideable" => x)
    /// Hides this column.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Hidden" =>>> true)
    /// Hides this column.
    [<CustomOperation("Hidden")>] member inline _.Hidden ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Hidden" =>>> x)
    /// Hides this column.
    [<CustomOperation("Hidden'")>] member inline _.Hidden' ([<InlineIfLambda>] render: AttrRenderFragment, valueFn: System.Boolean * (System.Boolean -> unit)) = render ==> html.bind("Hidden", valueFn)
    /// Occurs when the Hidden property has changed.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> unit) = render ==> html.callback("HiddenChanged", fn)
    /// Occurs when the Hidden property has changed.
    [<CustomOperation("HiddenChanged")>] member inline _.HiddenChanged ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: System.Boolean -> Task<unit>) = render ==> html.callbackTask("HiddenChanged", fn)

/// A manager for MudDialog instances.
type MudDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Hides headers for all dialogs by default.
    [<CustomOperation("NoHeader")>] member inline _.NoHeader ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("NoHeader" => x)
    /// Shows a close button in the top-right corner for all dialogs by default.
    [<CustomOperation("CloseButton")>] member inline _.CloseButton ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseButton" => x)
    /// Allows dialogs to be closed by clicking outside of them by default.
    [<CustomOperation("BackdropClick")>] member inline _.BackdropClick ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("BackdropClick" => x)
    /// Allows dialogs to be closed by pressing the Escape key by default.
    [<CustomOperation("CloseOnEscapeKey")>] member inline _.CloseOnEscapeKey ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("CloseOnEscapeKey" => x)
    /// Sets the width of dialogs to the width of the screen by default.
    [<CustomOperation("FullWidth")>] member inline _.FullWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<System.Boolean>) = render ==> ("FullWidth" => x)
    /// The location of dialogs by default.
    [<CustomOperation("Position")>] member inline _.Position ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.DialogPosition>) = render ==> ("Position" => x)
    /// The maximum allowed with of the dialog.
    [<CustomOperation("MaxWidth")>] member inline _.MaxWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<MudBlazor.MaxWidth>) = render ==> ("MaxWidth" => x)
    /// The custom CSS classes to apply to dialogs by default.
    [<CustomOperation("BackgroundClass")>] member inline _.BackgroundClass ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundClass" => x)

/// A required component which manages all MudBlazor popovers.
type MudPopoverProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


type MudVirtualizeBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Set false to turn off virtualization
    [<CustomOperation("Enabled")>] member inline _.Enabled ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Enabled" =>>> true)
    /// Set false to turn off virtualization
    [<CustomOperation("Enabled")>] member inline _.Enabled ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Enabled" =>>> x)
    /// Gets or sets the item template for the list.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// Gets or sets the template for the items that have not yet been loaded in memory.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Placeholder", fragment)
    /// Gets or sets the template for the items that have not yet been loaded in memory.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Placeholder", fragment { yield! fragments })
    /// Gets or sets the template for the items that have not yet been loaded in memory.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Placeholder", html.text x)
    /// Gets or sets the template for the items that have not yet been loaded in memory.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Placeholder", html.text x)
    /// Gets or sets the template for the items that have not yet been loaded in memory.
    [<CustomOperation("Placeholder")>] member inline _.Placeholder ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Placeholder", html.text x)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("NoRecordsContent", fragment)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("NoRecordsContent", fragment { yield! fragments })
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// The content shown when there are no rows to display.
    [<CustomOperation("NoRecordsContent")>] member inline _.NoRecordsContent ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("NoRecordsContent", html.text x)
    /// Gets or sets the fixed item source.
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.ICollection<'T>) = render ==> ("Items" => x)
    /// Gets or sets the function providing items to the list.
    [<CustomOperation("ItemsProvider")>] member inline _.ItemsProvider ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.Web.Virtualization.ItemsProviderDelegate<'T>) = render ==> ("ItemsProvider" => x)
    /// Gets or sets a value that determines how many additional items will be rendered
    /// before and after the visible region. This help to reduce the frequency of rendering
    /// during scrolling. However, higher values mean that more elements will be present
    /// in the page.
    [<CustomOperation("OverscanCount")>] member inline _.OverscanCount ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("OverscanCount" => x)
    /// Gets the size of each item in pixels. Defaults to 50px.
    [<CustomOperation("ItemSize")>] member inline _.ItemSize ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Single) = render ==> ("ItemSize" => x)
    /// Gets or sets tag name of the HTML element that will be used as virtualization spacer. Default is div.
    [<CustomOperation("SpacerElement")>] member inline _.SpacerElement ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SpacerElement" => x)

type MudRenderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


            
namespace rec MudBlazor.DslInternals.Internal

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

/// An icon displayed within an input component.
type MudInputAdornmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// The text for this adornment.
    [<CustomOperation("Text")>] member inline _.Text ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Text" => x)
    /// The icon for this adornment.
    [<CustomOperation("Icon")>] member inline _.Icon ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Icon" => x)
    /// Specifies the position of the adornment within the field.
    [<CustomOperation("Placement")>] member inline _.Placement ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Adornment) = render ==> ("Placement" => x)
    /// The size of the icon.
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Size) = render ==> ("Size" => x)
    /// The color of the icon button.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: MudBlazor.Color) = render ==> ("Color" => x)
    /// The accessible name for this adornment.
    [<CustomOperation("AriaLabel")>] member inline _.AriaLabel ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("AriaLabel" => x)
    /// Occurs when this adornment is clicked.
    [<CustomOperation("AdornmentClick")>] member inline _.AdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> unit) = render ==> html.callback("AdornmentClick", fn)
    /// Occurs when this adornment is clicked.
    [<CustomOperation("AdornmentClick")>] member inline _.AdornmentClick ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Web.MouseEventArgs -> Task<unit>) = render ==> html.callbackTask("AdornmentClick", fn)

            
namespace rec MudBlazor.DslInternals.Components.Snackbar.InternalComponents

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type SnackbarMessageMarkupStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Sets the message to be displayed as HTML content.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: Microsoft.AspNetCore.Components.MarkupString) = render ==> ("Message" => x)

type SnackbarMessageRenderFragmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Sets the message to be rendered as a custom fragment of UI.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Message", fragment)
    /// Sets the message to be rendered as a custom fragment of UI.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Message", fragment { yield! fragments })
    /// Sets the message to be rendered as a custom fragment of UI.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Message", html.text x)
    /// Sets the message to be rendered as a custom fragment of UI.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Message", html.text x)
    /// Sets the message to be rendered as a custom fragment of UI.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Message", html.text x)

type SnackbarMessageTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// Gets or sets the plain text message to be displayed.
    [<CustomOperation("Message")>] member inline _.Message ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Message" => x)

            
namespace rec MudBlazor.DslInternals.Charts

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor.DslInternals

type ChartTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()
    /// The title of the tooltip.
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The subtitle of the tooltip.
    [<CustomOperation("Subtitle")>] member inline _.Subtitle ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Subtitle" => x)
    /// The X coordinate of the tooltip anchor.
    [<CustomOperation("X")>] member inline _.X ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("X" => x)
    /// The Y coordinate of the tooltip anchor.
    [<CustomOperation("Y")>] member inline _.Y ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Y" => x)
    /// The color of the tooltip.
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)

type FiltersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAttrBuilder<'FunBlazorGeneric>()


            

// =======================================================================================================================

namespace MudBlazor

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals


    /// Represents a base class for designing components which maintain state.
    type ComponentBaseWithState' 
        /// Represents a base class for designing components which maintain state.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.ComponentBaseWithState>)>] () = inherit ComponentBaseWithStateBuilder<MudBlazor.ComponentBaseWithState>()

    /// Represents a base class for designing MudBlazor components.
    type MudComponentBase' 
        /// Represents a base class for designing MudBlazor components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudComponentBase>)>] () = inherit MudComponentBaseBuilder<MudBlazor.MudComponentBase>()

    /// Shared a base class for designing category MudChart and MudTimeSeriesChart components.
    type MudChartBase' 
        /// Shared a base class for designing category MudChart and MudTimeSeriesChart components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChartBase>)>] () = inherit MudChartBaseBuilder<MudBlazor.MudChartBase>()

    /// Represents a base class for designing category MudChart components.
    type MudCategoryChartBase' 
        /// Represents a base class for designing category MudChart components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCategoryChartBase>)>] () = inherit MudCategoryChartBaseBuilder<MudBlazor.MudCategoryChartBase>()
    type MudCategoryAxisChartBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCategoryAxisChartBase>)>] () = inherit MudCategoryAxisChartBaseBuilder<MudBlazor.MudCategoryAxisChartBase>()

    /// Represents a graphic display of data values in a line, bar, stacked bar, pie, heat map, or donut shape.
    type MudChart' 
        /// Represents a graphic display of data values in a line, bar, stacked bar, pie, heat map, or donut shape.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChart>)>] () = inherit MudChartBuilder<MudBlazor.MudChart>()
    type MudTimeSeriesChartBase' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTimeSeriesChartBase>)>] () = inherit MudTimeSeriesChartBaseBuilder<MudBlazor.MudTimeSeriesChartBase>()
    type MudTimeSeriesChart' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTimeSeriesChart>)>] () = inherit MudTimeSeriesChartBuilder<MudBlazor.MudTimeSeriesChart>()

    /// Represents a bar used to display actions, branding, navigation and screen titles.
    type MudAppBar' 
        /// Represents a bar used to display actions, branding, navigation and screen titles.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAppBar>)>] () = inherit MudAppBarBuilder<MudBlazor.MudAppBar>()

    /// A contextual app bar.
    type MudContextualActionBar' 
        /// A contextual app bar.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudContextualActionBar>)>] () = inherit MudContextualActionBarBuilder<MudBlazor.MudContextualActionBar>()

    /// Represents a base class for designing button components.
    type MudBaseButton' 
        /// Represents a base class for designing button components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseButton>)>] () = inherit MudBaseButtonBuilder<MudBlazor.MudBaseButton>()

    /// Represents a button for actions, links, and commands.
    type MudButton' 
        /// Represents a button for actions, links, and commands.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudButton>)>] () = inherit MudButtonBuilder<MudBlazor.MudButton>()

    /// Represents a floating action button.
    type MudFab' 
        /// Represents a floating action button.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFab>)>] () = inherit MudFabBuilder<MudBlazor.MudFab>()

    /// Represents a button consisting of an icon.
    type MudIconButton' 
        /// Represents a button consisting of an icon.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudIconButton>)>] () = inherit MudIconButtonBuilder<MudBlazor.MudIconButton>()

    /// A container for a MudDrawer component.
    type MudDrawerContainer' 
        /// A container for a MudDrawer component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDrawerContainer>)>] () = inherit MudDrawerContainerBuilder<MudBlazor.MudDrawerContainer>()

    /// A component which defines a common structure for multiple pages.
    type MudLayout' 
        /// A component which defines a common structure for multiple pages.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudLayout>)>] () = inherit MudLayoutBuilder<MudBlazor.MudLayout>()

    /// A base class for implementing Popover components.
    type MudPopoverBase' 
        /// A base class for implementing Popover components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPopoverBase>)>] () = inherit MudPopoverBaseBuilder<MudBlazor.MudPopoverBase>()

    /// Displays content as a window over other content.
    type MudPopover' 
        /// Displays content as a window over other content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPopover>)>] () = inherit MudPopoverBuilder<MudBlazor.MudPopover>()

    /// A base class for designing table components.
    type MudTableBase' 
        /// A base class for designing table components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTableBase>)>] () = inherit MudTableBaseBuilder<MudBlazor.MudTableBase>()

    /// A sortable, filterable table with multiselection and pagination.
    type MudTable'<'T> 
        /// A sortable, filterable table with multiselection and pagination.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTable<_>>)>] () = inherit MudTableBuilder<MudBlazor.MudTable<'T>, 'T>()

    /// A set of views organized into one or more MudTabPanel components.
    type MudTabs' 
        /// A set of views organized into one or more MudTabPanel components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTabs>)>] () = inherit MudTabsBuilder<MudBlazor.MudTabs>()

    /// A tab component where the tabs are controlled dynamically, similar to browser tabs.
    type MudDynamicTabs' 
        /// A tab component where the tabs are controlled dynamically, similar to browser tabs.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDynamicTabs>)>] () = inherit MudDynamicTabsBuilder<MudBlazor.MudDynamicTabs>()

    /// Represents a base class for designing components which contain items.
    type MudBaseItemsControl'<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> 
        /// Represents a base class for designing components which contain items.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseItemsControl<_>>)>] () = inherit MudBaseItemsControlBuilder<MudBlazor.MudBaseItemsControl<'TChildComponent>, 'TChildComponent>()

    /// Represents a base class for designing components with bindable items.
    type MudBaseBindableItemsControl'<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase> 
        /// Represents a base class for designing components with bindable items.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseBindableItemsControl<_, _>>)>] () = inherit MudBaseBindableItemsControlBuilder<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>, 'TChildComponent, 'TData>()

    /// Represents a set of slides which transition after a delay.
    type MudCarousel'<'TData> 
        /// Represents a set of slides which transition after a delay.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCarousel<_>>)>] () = inherit MudCarouselBuilder<MudBlazor.MudCarousel<'TData>, 'TData>()

    /// Displays items in chronological order.
    type MudTimeline' 
        /// Displays items in chronological order.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTimeline>)>] () = inherit MudTimelineBuilder<MudBlazor.MudTimeline>()

    /// Represents a base class for designing form input components.
    type MudFormComponent'<'T, 'U> 
        /// Represents a base class for designing form input components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFormComponent<_, _>>)>] () = inherit MudFormComponentBuilder<MudBlazor.MudFormComponent<'T, 'U>, 'T, 'U>()

    /// Represents a base class for designing form input components.
    type MudBaseInput'<'T> 
        /// Represents a base class for designing form input components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseInput<_>>)>] () = inherit MudBaseInputBuilder<MudBlazor.MudBaseInput<'T>, 'T>()

    /// Represents a component with simple and flexible type-ahead functionality.
    type MudAutocomplete'<'T> 
        /// Represents a component with simple and flexible type-ahead functionality.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAutocomplete<_>>)>] () = inherit MudAutocompleteBuilder<MudBlazor.MudAutocomplete<'T>, 'T>()

    /// A base class for designing input components which update after a delay.
    type MudDebouncedInput'<'T> 
        /// A base class for designing input components which update after a delay.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDebouncedInput<_>>)>] () = inherit MudDebouncedInputBuilder<MudBlazor.MudDebouncedInput<'T>, 'T>()

    /// A field for numeric values from users. 
    type MudNumericField'<'T> 
        /// A field for numeric values from users. 
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudNumericField<_>>)>] () = inherit MudNumericFieldBuilder<MudBlazor.MudNumericField<'T>, 'T>()

    /// An input for collecting text values.
    type MudTextField'<'T> 
        /// An input for collecting text values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTextField<_>>)>] () = inherit MudTextFieldBuilder<MudBlazor.MudTextField<'T>, 'T>()

    /// A component for collecting an input value.
    type MudInput'<'T> 
        /// A component for collecting an input value.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudInput<_>>)>] () = inherit MudInputBuilder<MudBlazor.MudInput<'T>, 'T>()

    /// An input component for collecting alphanumeric values.
    type MudInputString' 
        /// An input component for collecting alphanumeric values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudInputString>)>] () = inherit MudInputStringBuilder<MudBlazor.MudInputString>()

    /// A component for collecting start and end values which define a range.
    type MudRangeInput'<'T> 
        /// A component for collecting start and end values which define a range.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRangeInput<_>>)>] () = inherit MudRangeInputBuilder<MudBlazor.MudRangeInput<'T>, 'T>()

    /// A text input which conforms user input to a specific format while typing.
    /// 
    /// Note that MudMask is recommended to be used in WASM projects only because it has known problems
    /// in BSS, especially with high network latency.
    type MudMask' 
        /// A text input which conforms user input to a specific format while typing.
        /// 
        /// Note that MudMask is recommended to be used in WASM projects only because it has known problems
        /// in BSS, especially with high network latency.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMask>)>] () = inherit MudMaskBuilder<MudBlazor.MudMask>()

    /// A component for choosing an item from a list of options.
    type MudSelect'<'T> 
        /// A component for choosing an item from a list of options.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSelect<_>>)>] () = inherit MudSelectBuilder<MudBlazor.MudSelect<'T>, 'T>()

    /// Represents a form input component which stores a boolean value.
    type MudBooleanInput'<'T> 
        /// Represents a form input component which stores a boolean value.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBooleanInput<_>>)>] () = inherit MudBooleanInputBuilder<MudBlazor.MudBooleanInput<'T>, 'T>()

    /// Represents a form input for boolean values or selecting multiple items in a list.
    type MudCheckBox'<'T> 
        /// Represents a form input for boolean values or selecting multiple items in a list.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCheckBox<_>>)>] () = inherit MudCheckBoxBuilder<MudBlazor.MudCheckBox<'T>, 'T>()

    /// An option from a set of mutually exclusive options, often as part of a MudRadioGroup`1.
    type MudRadio'<'T> 
        /// An option from a set of mutually exclusive options, often as part of a MudRadioGroup`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRadio<_>>)>] () = inherit MudRadioBuilder<MudBlazor.MudRadio<'T>, 'T>()

    /// A component which switches between two values.
    type MudSwitch'<'T> 
        /// A component which switches between two values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSwitch<_>>)>] () = inherit MudSwitchBuilder<MudBlazor.MudSwitch<'T>, 'T>()

    /// A form component for uploading one or more files.  For T, use either IBrowserFile for a single file or IReadOnlyList<IBrowserFile> for multiple files.
    type MudFileUpload'<'T> 
        /// A form component for uploading one or more files.  For T, use either IBrowserFile for a single file or IReadOnlyList<IBrowserFile> for multiple files.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFileUpload<_>>)>] () = inherit MudFileUploadBuilder<MudBlazor.MudFileUpload<'T>, 'T>()

    /// A component for selecting date, time, and color values.
    type MudPicker'<'T> 
        /// A component for selecting date, time, and color values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPicker<_>>)>] () = inherit MudPickerBuilder<MudBlazor.MudPicker<'T>, 'T>()

    /// Represents a base class for designing date picker components.
    type MudBaseDatePicker' 
        /// Represents a base class for designing date picker components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBaseDatePicker>)>] () = inherit MudBaseDatePickerBuilder<MudBlazor.MudBaseDatePicker>()

    /// Represents a picker for dates.
    type MudDatePicker' 
        /// Represents a picker for dates.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDatePicker>)>] () = inherit MudDatePickerBuilder<MudBlazor.MudDatePicker>()

    /// Represents a picker for a range of dates.
    type MudDateRangePicker' 
        /// Represents a picker for a range of dates.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDateRangePicker>)>] () = inherit MudDateRangePickerBuilder<MudBlazor.MudDateRangePicker>()

    /// Represents a sophisticated and customizable pop-up for choosing a color.
    type MudColorPicker' 
        /// Represents a sophisticated and customizable pop-up for choosing a color.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudColorPicker>)>] () = inherit MudColorPickerBuilder<MudBlazor.MudColorPicker>()

    /// A component for selecting time values.
    type MudTimePicker' 
        /// A component for selecting time values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTimePicker>)>] () = inherit MudTimePickerBuilder<MudBlazor.MudTimePicker>()

    /// A group of MudRadio`1 components.
    type MudRadioGroup'<'T> 
        /// A group of MudRadio`1 components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRadioGroup<_>>)>] () = inherit MudRadioGroupBuilder<MudBlazor.MudRadioGroup<'T>, 'T>()

    /// Represents an alert used to display an important message which is statically embedded in the page content.
    type MudAlert' 
        /// Represents an alert used to display an important message which is statically embedded in the page content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAlert>)>] () = inherit MudAlertBuilder<MudBlazor.MudAlert>()

    /// Represents a component which displays circular user profile pictures, icons or text.
    type MudAvatar' 
        /// Represents a component which displays circular user profile pictures, icons or text.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAvatar>)>] () = inherit MudAvatarBuilder<MudBlazor.MudAvatar>()

    /// Represents a grouping of multiple MudAvatar components.
    type MudAvatarGroup' 
        /// Represents a grouping of multiple MudAvatar components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudAvatarGroup>)>] () = inherit MudAvatarGroupBuilder<MudBlazor.MudAvatarGroup>()

    /// Represents an overlay added to an icon or button to add information such as a number of new items.
    type MudBadge' 
        /// Represents an overlay added to an icon or button to add information such as a number of new items.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBadge>)>] () = inherit MudBadgeBuilder<MudBlazor.MudBadge>()

    /// Represents a series of links used to show the user's current location.
    type MudBreadcrumbs' 
        /// Represents a series of links used to show the user's current location.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBreadcrumbs>)>] () = inherit MudBreadcrumbsBuilder<MudBlazor.MudBreadcrumbs>()

    /// Represents a cascading parameter which exposes the window's current breakpoint (xs, sm, md, lg, xl).
    type MudBreakpointProvider' 
        /// Represents a cascading parameter which exposes the window's current breakpoint (xs, sm, md, lg, xl).
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudBreakpointProvider>)>] () = inherit MudBreakpointProviderBuilder<MudBlazor.MudBreakpointProvider>()

    /// Represents a button consisting of an icon that can be toggled between two distinct states.
    type MudToggleIconButton' 
        /// Represents a button consisting of an icon that can be toggled between two distinct states.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudToggleIconButton>)>] () = inherit MudToggleIconButtonBuilder<MudBlazor.MudToggleIconButton>()

    /// Represents a group of connected MudButton components.
    type MudButtonGroup' 
        /// Represents a group of connected MudButton components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudButtonGroup>)>] () = inherit MudButtonGroupBuilder<MudBlazor.MudButtonGroup>()

    /// Represents a block of content which can include a header, image, content, and actions.
    type MudCard' 
        /// Represents a block of content which can include a header, image, content, and actions.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCard>)>] () = inherit MudCardBuilder<MudBlazor.MudCard>()

    /// Represents a set of buttons displayed as part of a MudCard.
    type MudCardActions' 
        /// Represents a set of buttons displayed as part of a MudCard.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCardActions>)>] () = inherit MudCardActionsBuilder<MudBlazor.MudCardActions>()

    /// Represents the primary content displayed within a MudCard.
    type MudCardContent' 
        /// Represents the primary content displayed within a MudCard.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCardContent>)>] () = inherit MudCardContentBuilder<MudBlazor.MudCardContent>()

    /// Represents the top portion of a MudCard.
    type MudCardHeader' 
        /// Represents the top portion of a MudCard.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCardHeader>)>] () = inherit MudCardHeaderBuilder<MudBlazor.MudCardHeader>()

    /// Represents an image displayed as part of a MudCard.
    type MudCardMedia' 
        /// Represents an image displayed as part of a MudCard.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCardMedia>)>] () = inherit MudCardMediaBuilder<MudBlazor.MudCardMedia>()

    /// Represents a slide displayed within a MudCarousel`1.
    type MudCarouselItem' 
        /// Represents a slide displayed within a MudCarousel`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCarouselItem>)>] () = inherit MudCarouselItemBuilder<MudBlazor.MudCarouselItem>()

    /// Represents a single cell in a HeatMap. You can override the value from the ChartSeries 
    /// or provide a custom graphic to be shown inside the cell. You should provide a width and height for the custom graphic you are including
    /// so the Heat Map can resize it dynamically. 
    type MudHeatMapCell' 
        /// Represents a single cell in a HeatMap. You can override the value from the ChartSeries 
        /// or provide a custom graphic to be shown inside the cell. You should provide a width and height for the custom graphic you are including
        /// so the Heat Map can resize it dynamically. 
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudHeatMapCell>)>] () = inherit MudHeatMapCellBuilder<MudBlazor.MudHeatMapCell>()
    type MudChat' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChat>)>] () = inherit MudChatBuilder<MudBlazor.MudChat>()

    /// Represents the content displayed within a MudChat.
    type MudChatBubble' 
        /// Represents the content displayed within a MudChat.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChatBubble>)>] () = inherit MudChatBubbleBuilder<MudBlazor.MudChatBubble>()

    /// Represents the footer of a MudChat.
    type MudChatFooter' 
        /// Represents the footer of a MudChat.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChatFooter>)>] () = inherit MudChatFooterBuilder<MudBlazor.MudChatFooter>()

    /// Represents the header of a MudChat.
    type MudChatHeader' 
        /// Represents the header of a MudChat.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChatHeader>)>] () = inherit MudChatHeaderBuilder<MudBlazor.MudChatHeader>()

    /// Represents a compact element used to enter information, select a choice, filter content, or trigger an action.
    type MudChip'<'T> 
        /// Represents a compact element used to enter information, select a choice, filter content, or trigger an action.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChip<_>>)>] () = inherit MudChipBuilder<MudBlazor.MudChip<'T>, 'T>()

    /// Represents a set of multiple MudChip`1 components.
    type MudChipSet'<'T> 
        /// Represents a set of multiple MudChip`1 components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudChipSet<_>>)>] () = inherit MudChipSetBuilder<MudBlazor.MudChipSet<'T>, 'T>()

    /// Represents a container for content which can be collapsed and expanded.
    type MudCollapse' 
        /// Represents a container for content which can be collapsed and expanded.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudCollapse>)>] () = inherit MudCollapseBuilder<MudBlazor.MudCollapse>()

    /// Represents a vertical set of values.
    type Column'<'T> 
        /// Represents a vertical set of values.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Column<_>>)>] () = inherit ColumnBuilder<MudBlazor.Column<'T>, 'T>()

    /// Represents a column in a MudDataGrid`1 associated with an object's property.
    type PropertyColumn'<'T, 'TProperty> 
        /// Represents a column in a MudDataGrid`1 associated with an object's property.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.PropertyColumn<_, _>>)>] () = inherit PropertyColumnBuilder<MudBlazor.PropertyColumn<'T, 'TProperty>, 'T, 'TProperty>()

    /// Represents an additional column for a MudDataGrid`1 which isn't tied to data.
    type TemplateColumn'<'T> 
        /// Represents an additional column for a MudDataGrid`1 which isn't tied to data.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.TemplateColumn<_>>)>] () = inherit TemplateColumnBuilder<MudBlazor.TemplateColumn<'T>, 'T>()
    type DataGridGroupRow'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.DataGridGroupRow<_>>)>] () = inherit DataGridGroupRowBuilder<MudBlazor.DataGridGroupRow<'T>, 'T>()
    type DataGridVirtualizeRow'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.DataGridVirtualizeRow<_>>)>] () = inherit DataGridVirtualizeRowBuilder<MudBlazor.DataGridVirtualizeRow<'T>, 'T>()

    /// Represents a column filter shown when FilterMode is ColumnFilterRow.
    type FilterHeaderCell'<'T> 
        /// Represents a column filter shown when FilterMode is ColumnFilterRow.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.FilterHeaderCell<_>>)>] () = inherit FilterHeaderCellBuilder<MudBlazor.FilterHeaderCell<'T>, 'T>()

    /// Represents a cell displayed at the bottom of a column.
    type FooterCell'<'T> 
        /// Represents a cell displayed at the bottom of a column.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.FooterCell<_>>)>] () = inherit FooterCellBuilder<MudBlazor.FooterCell<'T>, 'T>()

    /// Represents a cell displayed at the top of a MudDataGrid`1 column.
    type HeaderCell'<'T> 
        /// Represents a cell displayed at the top of a MudDataGrid`1 column.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.HeaderCell<_>>)>] () = inherit HeaderCellBuilder<MudBlazor.HeaderCell<'T>, 'T>()

    /// Represents a column in a MudDataGrid`1 which can be expanded to show additional information.
    type HierarchyColumn'<'T> 
        /// Represents a column in a MudDataGrid`1 which can be expanded to show additional information.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.HierarchyColumn<_>>)>] () = inherit HierarchyColumnBuilder<MudBlazor.HierarchyColumn<'T>, 'T>()

    /// Represents a sortable, filterable data grid with multiselection and pagination.
    type MudDataGrid'<'T> 
        /// Represents a sortable, filterable data grid with multiselection and pagination.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDataGrid<_>>)>] () = inherit MudDataGridBuilder<MudBlazor.MudDataGrid<'T>, 'T>()

    /// Represents a pager for navigating pages of a MudDataGrid`1.
    type MudDataGridPager'<'T> 
        /// Represents a pager for navigating pages of a MudDataGrid`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDataGridPager<_>>)>] () = inherit MudDataGridPagerBuilder<MudBlazor.MudDataGridPager<'T>, 'T>()

    /// An overlay providing the user with information, a choice, or other input.
    type MudDialog' 
        /// An overlay providing the user with information, a choice, or other input.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDialog>)>] () = inherit MudDialogBuilder<MudBlazor.MudDialog>()

    /// An instance of a MudDialog.
    type MudDialogContainer' 
        /// An instance of a MudDialog.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDialogContainer>)>] () = inherit MudDialogContainerBuilder<MudBlazor.MudDialogContainer>()

    /// A thin line that groups content in lists and layouts.
    type MudDivider' 
        /// A thin line that groups content in lists and layouts.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDivider>)>] () = inherit MudDividerBuilder<MudBlazor.MudDivider>()

    /// Represents a navigation panel docked to the side of the page.
    type MudDrawer' 
        /// Represents a navigation panel docked to the side of the page.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDrawer>)>] () = inherit MudDrawerBuilder<MudBlazor.MudDrawer>()

    /// Represents content at the top of a MudDrawer.
    type MudDrawerHeader' 
        /// Represents content at the top of a MudDrawer.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDrawerHeader>)>] () = inherit MudDrawerHeaderBuilder<MudBlazor.MudDrawerHeader>()

    /// A container of MudDropZone`1 components for drag-and-drop operations.
    type MudDropContainer'<'T> 
        /// A container of MudDropZone`1 components for drag-and-drop operations.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDropContainer<_>>)>] () = inherit MudDropContainerBuilder<MudBlazor.MudDropContainer<'T>, 'T>()

    /// A location which can participate in a drag-and-drop operation.
    type MudDropZone'<'T> 
        /// A location which can participate in a drag-and-drop operation.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDropZone<_>>)>] () = inherit MudDropZoneBuilder<MudBlazor.MudDropZone<'T>, 'T>()
    type MudDynamicDropItem'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDynamicDropItem<_>>)>] () = inherit MudDynamicDropItemBuilder<MudBlazor.MudDynamicDropItem<'T>, 'T>()

    /// A primitive component which allows dynamically changing the HTML element rendered under the hood.
    type MudElement' 
        /// A primitive component which allows dynamically changing the HTML element rendered under the hood.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudElement>)>] () = inherit MudElementBuilder<MudBlazor.MudElement>()

    /// A component which can be expanded to show more content or collapsed to show only its header.
    type MudExpansionPanel' 
        /// A component which can be expanded to show more content or collapsed to show only its header.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudExpansionPanel>)>] () = inherit MudExpansionPanelBuilder<MudBlazor.MudExpansionPanel>()

    /// A container which manages MudExpansionPanel components such that when one panel is expanded the others are collapsed automatically.
    type MudExpansionPanels' 
        /// A container which manages MudExpansionPanel components such that when one panel is expanded the others are collapsed automatically.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudExpansionPanels>)>] () = inherit MudExpansionPanelsBuilder<MudBlazor.MudExpansionPanels>()

    /// A component similar to MudTextField`1 which supports custom content.
    type MudField' 
        /// A component similar to MudTextField`1 which supports custom content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudField>)>] () = inherit MudFieldBuilder<MudBlazor.MudField>()

    /// A component which prevents the keyboard focus from cycling out of its child content.
    type MudFocusTrap' 
        /// A component which prevents the keyboard focus from cycling out of its child content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFocusTrap>)>] () = inherit MudFocusTrapBuilder<MudBlazor.MudFocusTrap>()

    /// A component for collecting and validating user input. Every input derived from MudFormComponent 
    /// within it is monitored and validated.
    type MudForm' 
        /// A component for collecting and validating user input. Every input derived from MudFormComponent 
        /// within it is monitored and validated.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudForm>)>] () = inherit MudFormBuilder<MudBlazor.MudForm>()

    /// A component for breaking a flex display using CSS styles.
    type MudFlexBreak' 
        /// A component for breaking a flex display using CSS styles.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudFlexBreak>)>] () = inherit MudFlexBreakBuilder<MudBlazor.MudFlexBreak>()

    /// A component for organizing the layout of page content.
    type MudGrid' 
        /// A component for organizing the layout of page content.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudGrid>)>] () = inherit MudGridBuilder<MudBlazor.MudGrid>()

    /// A portion of a MudGrid.
    type MudItem' 
        /// A portion of a MudGrid.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudItem>)>] () = inherit MudItemBuilder<MudBlazor.MudItem>()

    /// A component which conditionally renders content depending on the screen size.
    type MudHidden' 
        /// A component which conditionally renders content depending on the screen size.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudHidden>)>] () = inherit MudHiddenBuilder<MudBlazor.MudHidden>()

    /// A component which highlights words or phrases within text.
    type MudHighlighter' 
        /// A component which highlights words or phrases within text.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudHighlighter>)>] () = inherit MudHighlighterBuilder<MudBlazor.MudHighlighter>()

    /// A picture displayed via an SVG path or font.
    type MudIcon' 
        /// A picture displayed via an SVG path or font.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudIcon>)>] () = inherit MudIconBuilder<MudBlazor.MudIcon>()

    /// A simple component that displays an image.
    type MudImage' 
        /// A simple component that displays an image.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudImage>)>] () = inherit MudImageBuilder<MudBlazor.MudImage>()

    /// A label which describes a MudInput`1 component.
    type MudInputLabel' 
        /// A label which describes a MudInput`1 component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudInputLabel>)>] () = inherit MudInputLabelBuilder<MudBlazor.MudInputLabel>()

    /// A base class for designing input components.
    type MudInputControl' 
        /// A base class for designing input components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudInputControl>)>] () = inherit MudInputControlBuilder<MudBlazor.MudInputControl>()

    /// A clickable link which can navigate to a URL.
    type MudLink' 
        /// A clickable link which can navigate to a URL.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudLink>)>] () = inherit MudLinkBuilder<MudBlazor.MudLink>()

    /// A scrollable list for displaying text, avatars, and icons.
    type MudList'<'T> 
        /// A scrollable list for displaying text, avatars, and icons.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudList<_>>)>] () = inherit MudListBuilder<MudBlazor.MudList<'T>, 'T>()

    /// An item within a MudList`1 component.
    type MudListItem'<'T> 
        /// An item within a MudList`1 component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudListItem<_>>)>] () = inherit MudListItemBuilder<MudBlazor.MudListItem<'T>, 'T>()

    /// A header displayed as part of a MudList`1.
    type MudListSubheader' 
        /// A header displayed as part of a MudList`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudListSubheader>)>] () = inherit MudListSubheaderBuilder<MudBlazor.MudListSubheader>()

    /// Represents the main content area of the MudLayout.
    type MudMainContent' 
        /// Represents the main content area of the MudLayout.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMainContent>)>] () = inherit MudMainContentBuilder<MudBlazor.MudMainContent>()

    /// An interactive menu that displays a list of options.
    type MudMenu' 
        /// An interactive menu that displays a list of options.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMenu>)>] () = inherit MudMenuBuilder<MudBlazor.MudMenu>()

    /// A choice displayed as part of a list within a MudMenu component.
    type MudMenuItem' 
        /// A choice displayed as part of a list within a MudMenu component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMenuItem>)>] () = inherit MudMenuItemBuilder<MudBlazor.MudMenuItem>()

    /// A pop-up dialog with a simple message and button choices.
    type MudMessageBox' 
        /// A pop-up dialog with a simple message and button choices.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudMessageBox>)>] () = inherit MudMessageBoxBuilder<MudBlazor.MudMessageBox>()

    /// A deeper level of navigation links as part of a MudNavMenu.
    type MudNavGroup' 
        /// A deeper level of navigation links as part of a MudNavMenu.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudNavGroup>)>] () = inherit MudNavGroupBuilder<MudBlazor.MudNavGroup>()

    /// A navigation link as part of a MudNavMenu.
    type MudNavLink' 
        /// A navigation link as part of a MudNavMenu.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudNavLink>)>] () = inherit MudNavLinkBuilder<MudBlazor.MudNavLink>()

    /// A list of navigation links with support for groups.
    type MudNavMenu' 
        /// A list of navigation links with support for groups.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudNavMenu>)>] () = inherit MudNavMenuBuilder<MudBlazor.MudNavMenu>()

    /// A layer which darkens a window, often as part of showing a MudDialog.
    type MudOverlay' 
        /// A layer which darkens a window, often as part of showing a MudDialog.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudOverlay>)>] () = inherit MudOverlayBuilder<MudBlazor.MudOverlay>()

    /// A drawer used to navigate sections on a page.
    type MudPageContentNavigation' 
        /// A drawer used to navigate sections on a page.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPageContentNavigation>)>] () = inherit MudPageContentNavigationBuilder<MudBlazor.MudPageContentNavigation>()

    /// A list of clickable page numbers along with navigation buttons.
    type MudPagination' 
        /// A list of clickable page numbers along with navigation buttons.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPagination>)>] () = inherit MudPaginationBuilder<MudBlazor.MudPagination>()

    /// A surface for grouping other components.
    type MudPaper' 
        /// A surface for grouping other components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPaper>)>] () = inherit MudPaperBuilder<MudBlazor.MudPaper>()

    /// The content within a MudPicker`1.
    type MudPickerContent' 
        /// The content within a MudPicker`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPickerContent>)>] () = inherit MudPickerContentBuilder<MudBlazor.MudPickerContent>()

    /// The toolbar content of a MudPicker`1.
    type MudPickerToolbar' 
        /// The toolbar content of a MudPicker`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPickerToolbar>)>] () = inherit MudPickerToolbarBuilder<MudBlazor.MudPickerToolbar>()

    /// A circle-shaped indicator of progress for an ongoing operation.
    type MudProgressCircular' 
        /// A circle-shaped indicator of progress for an ongoing operation.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudProgressCircular>)>] () = inherit MudProgressCircularBuilder<MudBlazor.MudProgressCircular>()

    /// A line-shaped indicator of progress for an ongoing operation.
    type MudProgressLinear' 
        /// A line-shaped indicator of progress for an ongoing operation.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudProgressLinear>)>] () = inherit MudProgressLinearBuilder<MudBlazor.MudProgressLinear>()

    /// A component for collecting and displaying ratings.
    type MudRating' 
        /// A component for collecting and displaying ratings.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRating>)>] () = inherit MudRatingBuilder<MudBlazor.MudRating>()

    /// A clickable item as part of a MudRating.
    type MudRatingItem' 
        /// A clickable item as part of a MudRating.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRatingItem>)>] () = inherit MudRatingItemBuilder<MudBlazor.MudRatingItem>()

    /// A language support provider for Right-to-Left (RTL) languages such as Arabic, Hebrew, and Persian.
    type MudRTLProvider' 
        /// A language support provider for Right-to-Left (RTL) languages such as Arabic, Hebrew, and Persian.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRTLProvider>)>] () = inherit MudRTLProviderBuilder<MudBlazor.MudRTLProvider>()

    /// A button which lets the user jump to the top of the page.
    type MudScrollToTop' 
        /// A button which lets the user jump to the top of the page.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudScrollToTop>)>] () = inherit MudScrollToTopBuilder<MudBlazor.MudScrollToTop>()

    /// A selectable option displayed within a MudSelect`1 component.
    type MudSelectItem'<'T> 
        /// A selectable option displayed within a MudSelect`1 component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSelectItem<_>>)>] () = inherit MudSelectItemBuilder<MudBlazor.MudSelectItem<'T>, 'T>()

    /// A temporary placeholder for content while data is loaded.
    type MudSkeleton' 
        /// A temporary placeholder for content while data is loaded.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSkeleton>)>] () = inherit MudSkeletonBuilder<MudBlazor.MudSkeleton>()

    /// A component which allows users to select a value within a specified range.
    type MudSlider'<'T when 'T : struct and 'T : (new : unit -> 'T) and System.Numerics.INumber<'T> and 'T :> System.ValueType> 
        /// A component which allows users to select a value within a specified range.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSlider<_>>)>] () = inherit MudSliderBuilder<MudBlazor.MudSlider<'T>, 'T>()
    type MudSnackbarElement' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSnackbarElement>)>] () = inherit MudSnackbarElementBuilder<MudBlazor.MudSnackbarElement>()
    type MudSnackbarProvider' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSnackbarProvider>)>] () = inherit MudSnackbarProviderBuilder<MudBlazor.MudSnackbarProvider>()

    /// A component for aligning child items horizontally or vertically.
    type MudStack' 
        /// A component for aligning child items horizontally or vertically.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudStack>)>] () = inherit MudStackBuilder<MudBlazor.MudStack>()

    /// A individual step as part of a MudStepper.
    type MudStep' 
        /// A individual step as part of a MudStepper.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudStep>)>] () = inherit MudStepBuilder<MudBlazor.MudStep>()

    /// A wizard that guides the user through a series of steps to complete a transaction.
    type MudStepper' 
        /// A wizard that guides the user through a series of steps to complete a transaction.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudStepper>)>] () = inherit MudStepperBuilder<MudBlazor.MudStepper>()

    /// An area which receives swipe events.
    type MudSwipeArea' 
        /// An area which receives swipe events.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSwipeArea>)>] () = inherit MudSwipeAreaBuilder<MudBlazor.MudSwipeArea>()

    /// A grouping of values for a column in a MudTable`1.
    type MudTableGroupRow'<'T> 
        /// A grouping of values for a column in a MudTable`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTableGroupRow<_>>)>] () = inherit MudTableGroupRowBuilder<MudBlazor.MudTableGroupRow<'T>, 'T>()

    /// A component which changes pages and page size for a MudTable`1.
    type MudTablePager' 
        /// A component which changes pages and page size for a MudTable`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTablePager>)>] () = inherit MudTablePagerBuilder<MudBlazor.MudTablePager>()

    /// A clickable column which toggles the sort column and direction for a MudTable`1.
    type MudTableSortLabel'<'T> 
        /// A clickable column which toggles the sort column and direction for a MudTable`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTableSortLabel<_>>)>] () = inherit MudTableSortLabelBuilder<MudBlazor.MudTableSortLabel<'T>, 'T>()

    /// A cell within a MudTr, MudTHeadRow, or MudTFootRow row component.
    type MudTd' 
        /// A cell within a MudTr, MudTHeadRow, or MudTFootRow row component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTd>)>] () = inherit MudTdBuilder<MudBlazor.MudTd>()

    /// A footer row displayed at the bottom of a MudTable`1 and each group.
    type MudTFootRow' 
        /// A footer row displayed at the bottom of a MudTable`1 and each group.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTFootRow>)>] () = inherit MudTFootRowBuilder<MudBlazor.MudTFootRow>()

    /// A header cell which labels a column of data for a MudTable`1.
    type MudTh' 
        /// A header cell which labels a column of data for a MudTable`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTh>)>] () = inherit MudThBuilder<MudBlazor.MudTh>()

    /// A header row displayed at the top of a MudTable`1 and each group.
    type MudTHeadRow' 
        /// A header row displayed at the top of a MudTable`1 and each group.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTHeadRow>)>] () = inherit MudTHeadRowBuilder<MudBlazor.MudTHeadRow>()

    /// A row of data within a MudTable`1.
    type MudTr' 
        /// A row of data within a MudTable`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTr>)>] () = inherit MudTrBuilder<MudBlazor.MudTr>()

    /// A table similar to MudTable`1 but with basic styling features.
    type MudSimpleTable' 
        /// A table similar to MudTable`1 but with basic styling features.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSimpleTable>)>] () = inherit MudSimpleTableBuilder<MudBlazor.MudSimpleTable>()

    /// A tab as part of a MudTabs or MudDynamicTabs component.
    type MudTabPanel' 
        /// A tab as part of a MudTabs or MudDynamicTabs component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTabPanel>)>] () = inherit MudTabPanelBuilder<MudBlazor.MudTabPanel>()

    /// A chronological item displayed as part of a MudTimeline
    type MudTimelineItem' 
        /// A chronological item displayed as part of a MudTimeline
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTimelineItem>)>] () = inherit MudTimelineItemBuilder<MudBlazor.MudTimelineItem>()

    /// Maintains the selection of a group of MudToggleItem`1 components.
    type MudToggleGroup'<'T> 
        /// Maintains the selection of a group of MudToggleItem`1 components.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudToggleGroup<_>>)>] () = inherit MudToggleGroupBuilder<MudBlazor.MudToggleGroup<'T>, 'T>()

    /// An item as part of a MudToggleGroup`1
    type MudToggleItem'<'T> 
        /// An item as part of a MudToggleGroup`1
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudToggleItem<_>>)>] () = inherit MudToggleItemBuilder<MudBlazor.MudToggleItem<'T>, 'T>()

    /// A set of action buttons.  
    type MudToolBar' 
        /// A set of action buttons.  
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudToolBar>)>] () = inherit MudToolBarBuilder<MudBlazor.MudToolBar>()

    /// A small popup which provides more information.
    type MudTooltip' 
        /// A small popup which provides more information.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTooltip>)>] () = inherit MudTooltipBuilder<MudBlazor.MudTooltip>()

    /// A hierarchical tree of expandable items with optional value selection.
    type MudTreeView'<'T> 
        /// A hierarchical tree of expandable items with optional value selection.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTreeView<_>>)>] () = inherit MudTreeViewBuilder<MudBlazor.MudTreeView<'T>, 'T>()

    /// An expandable branch of a MudTreeView`1.
    type MudTreeViewItem'<'T> 
        /// An expandable branch of a MudTreeView`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTreeViewItem<_>>)>] () = inherit MudTreeViewItemBuilder<MudBlazor.MudTreeViewItem<'T>, 'T>()

    /// Toggles the expansion state of a MudTreeViewItem`1.
    type MudTreeViewItemToggleButton' 
        /// Toggles the expansion state of a MudTreeViewItem`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudTreeViewItemToggleButton>)>] () = inherit MudTreeViewItemToggleButtonBuilder<MudBlazor.MudTreeViewItemToggleButton>()

    /// A customizable piece of text.
    type MudText' 
        /// A customizable piece of text.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudText>)>] () = inherit MudTextBuilder<MudBlazor.MudText>()
    type MudContainer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudContainer>)>] () = inherit MudContainerBuilder<MudBlazor.MudContainer>()

    /// Provides a standard set of colors, shapes, sizes and shadows to a layout.
    type MudThemeProvider' 
        /// Provides a standard set of colors, shapes, sizes and shadows to a layout.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudThemeProvider>)>] () = inherit MudThemeProviderBuilder<MudBlazor.MudThemeProvider>()

    /// Represents a segment in a list of breadcrumbs.
    type BreadcrumbLink' 
        /// Represents a segment in a list of breadcrumbs.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.BreadcrumbLink>)>] () = inherit BreadcrumbLinkBuilder<MudBlazor.BreadcrumbLink>()

    /// Represents a divider between breadcrumb items.
    type BreadcrumbSeparator' 
        /// Represents a divider between breadcrumb items.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.BreadcrumbSeparator>)>] () = inherit BreadcrumbSeparatorBuilder<MudBlazor.BreadcrumbSeparator>()

    /// Represents a checkbox column used to select rows in a MudDataGrid`1.
    type SelectColumn'<'T> 
        /// Represents a checkbox column used to select rows in a MudDataGrid`1.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.SelectColumn<_>>)>] () = inherit SelectColumnBuilder<MudBlazor.SelectColumn<'T>, 'T>()

    /// A manager for MudDialog instances.
    type MudDialogProvider' 
        /// A manager for MudDialog instances.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudDialogProvider>)>] () = inherit MudDialogProviderBuilder<MudBlazor.MudDialogProvider>()

    /// A required component which manages all MudBlazor popovers.
    type MudPopoverProvider' 
        /// A required component which manages all MudBlazor popovers.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudPopoverProvider>)>] () = inherit MudPopoverProviderBuilder<MudBlazor.MudPopoverProvider>()
    type MudVirtualize'<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudVirtualize<_>>)>] () = inherit MudVirtualizeBuilder<MudBlazor.MudVirtualize<'T>, 'T>()
    type MudRender' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudRender>)>] () = inherit MudRenderBuilder<MudBlazor.MudRender>()
    type MudSpacer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.MudSpacer>)>] () = inherit MudSpacerBuilder<MudBlazor.MudSpacer>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals

    let ComponentBaseWithState'' = ComponentBaseWithState'()
    let MudComponentBase'' = MudComponentBase'()
    let MudChartBase'' = MudChartBase'()
    let MudCategoryChartBase'' = MudCategoryChartBase'()
    let MudCategoryAxisChartBase'' = MudCategoryAxisChartBase'()
    let MudChart'' = MudChart'()
    let MudTimeSeriesChartBase'' = MudTimeSeriesChartBase'()
    let MudTimeSeriesChart'' = MudTimeSeriesChart'()
    let MudAppBar'' = MudAppBar'()
    let MudContextualActionBar'' = MudContextualActionBar'()
    let MudBaseButton'' = MudBaseButton'()
    let MudButton'' = MudButton'()
    let MudFab'' = MudFab'()
    let MudIconButton'' = MudIconButton'()
    let MudDrawerContainer'' = MudDrawerContainer'()
    let MudLayout'' = MudLayout'()
    let MudPopoverBase'' = MudPopoverBase'()
    let MudPopover'' = MudPopover'()
    let MudTableBase'' = MudTableBase'()
    let MudTable''<'T> = MudTable'<'T>()
    let MudTabs'' = MudTabs'()
    let MudDynamicTabs'' = MudDynamicTabs'()
    let MudBaseItemsControl''<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseItemsControl'<'TChildComponent>()
    let MudBaseBindableItemsControl''<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseBindableItemsControl'<'TChildComponent, 'TData>()
    let MudCarousel''<'TData> = MudCarousel'<'TData>()
    let MudTimeline'' = MudTimeline'()
    let MudFormComponent''<'T, 'U> = MudFormComponent'<'T, 'U>()
    let MudBaseInput''<'T> = MudBaseInput'<'T>()
    let MudAutocomplete''<'T> = MudAutocomplete'<'T>()
    let MudDebouncedInput''<'T> = MudDebouncedInput'<'T>()
    let MudNumericField''<'T> = MudNumericField'<'T>()
    let MudTextField''<'T> = MudTextField'<'T>()
    let MudInput''<'T> = MudInput'<'T>()
    let MudInputString'' = MudInputString'()
    let MudRangeInput''<'T> = MudRangeInput'<'T>()
    let MudMask'' = MudMask'()
    let MudSelect''<'T> = MudSelect'<'T>()
    let MudBooleanInput''<'T> = MudBooleanInput'<'T>()
    let MudCheckBox''<'T> = MudCheckBox'<'T>()
    let MudRadio''<'T> = MudRadio'<'T>()
    let MudSwitch''<'T> = MudSwitch'<'T>()
    let MudFileUpload''<'T> = MudFileUpload'<'T>()
    let MudPicker''<'T> = MudPicker'<'T>()
    let MudBaseDatePicker'' = MudBaseDatePicker'()
    let MudDatePicker'' = MudDatePicker'()
    let MudDateRangePicker'' = MudDateRangePicker'()
    let MudColorPicker'' = MudColorPicker'()
    let MudTimePicker'' = MudTimePicker'()
    let MudRadioGroup''<'T> = MudRadioGroup'<'T>()
    let MudAlert'' = MudAlert'()
    let MudAvatar'' = MudAvatar'()
    let MudAvatarGroup'' = MudAvatarGroup'()
    let MudBadge'' = MudBadge'()
    let MudBreadcrumbs'' = MudBreadcrumbs'()
    let MudBreakpointProvider'' = MudBreakpointProvider'()
    let MudToggleIconButton'' = MudToggleIconButton'()
    let MudButtonGroup'' = MudButtonGroup'()
    let MudCard'' = MudCard'()
    let MudCardActions'' = MudCardActions'()
    let MudCardContent'' = MudCardContent'()
    let MudCardHeader'' = MudCardHeader'()
    let MudCardMedia'' = MudCardMedia'()
    let MudCarouselItem'' = MudCarouselItem'()
    let MudHeatMapCell'' = MudHeatMapCell'()
    let MudChat'' = MudChat'()
    let MudChatBubble'' = MudChatBubble'()
    let MudChatFooter'' = MudChatFooter'()
    let MudChatHeader'' = MudChatHeader'()
    let MudChip''<'T> = MudChip'<'T>()
    let MudChipSet''<'T> = MudChipSet'<'T>()
    let MudCollapse'' = MudCollapse'()
    let Column''<'T> = Column'<'T>()
    let PropertyColumn''<'T, 'TProperty> = PropertyColumn'<'T, 'TProperty>()
    let TemplateColumn''<'T> = TemplateColumn'<'T>()
    let DataGridGroupRow''<'T> = DataGridGroupRow'<'T>()
    let DataGridVirtualizeRow''<'T> = DataGridVirtualizeRow'<'T>()
    let FilterHeaderCell''<'T> = FilterHeaderCell'<'T>()
    let FooterCell''<'T> = FooterCell'<'T>()
    let HeaderCell''<'T> = HeaderCell'<'T>()
    let HierarchyColumn''<'T> = HierarchyColumn'<'T>()
    let MudDataGrid''<'T> = MudDataGrid'<'T>()
    let MudDataGridPager''<'T> = MudDataGridPager'<'T>()
    let MudDialog'' = MudDialog'()
    let MudDialogContainer'' = MudDialogContainer'()
    let MudDivider'' = MudDivider'()
    let MudDrawer'' = MudDrawer'()
    let MudDrawerHeader'' = MudDrawerHeader'()
    let MudDropContainer''<'T> = MudDropContainer'<'T>()
    let MudDropZone''<'T> = MudDropZone'<'T>()
    let MudDynamicDropItem''<'T> = MudDynamicDropItem'<'T>()
    let MudElement'' = MudElement'()
    let MudExpansionPanel'' = MudExpansionPanel'()
    let MudExpansionPanels'' = MudExpansionPanels'()
    let MudField'' = MudField'()
    let MudFocusTrap'' = MudFocusTrap'()
    let MudForm'' = MudForm'()
    let MudFlexBreak'' = MudFlexBreak'()
    let MudGrid'' = MudGrid'()
    let MudItem'' = MudItem'()
    let MudHidden'' = MudHidden'()
    let MudHighlighter'' = MudHighlighter'()
    let MudIcon'' = MudIcon'()
    let MudImage'' = MudImage'()
    let MudInputLabel'' = MudInputLabel'()
    let MudInputControl'' = MudInputControl'()
    let MudLink'' = MudLink'()
    let MudList''<'T> = MudList'<'T>()
    let MudListItem''<'T> = MudListItem'<'T>()
    let MudListSubheader'' = MudListSubheader'()
    let MudMainContent'' = MudMainContent'()
    let MudMenu'' = MudMenu'()
    let MudMenuItem'' = MudMenuItem'()
    let MudMessageBox'' = MudMessageBox'()
    let MudNavGroup'' = MudNavGroup'()
    let MudNavLink'' = MudNavLink'()
    let MudNavMenu'' = MudNavMenu'()
    let MudOverlay'' = MudOverlay'()
    let MudPageContentNavigation'' = MudPageContentNavigation'()
    let MudPagination'' = MudPagination'()
    let MudPaper'' = MudPaper'()
    let MudPickerContent'' = MudPickerContent'()
    let MudPickerToolbar'' = MudPickerToolbar'()
    let MudProgressCircular'' = MudProgressCircular'()
    let MudProgressLinear'' = MudProgressLinear'()
    let MudRating'' = MudRating'()
    let MudRatingItem'' = MudRatingItem'()
    let MudRTLProvider'' = MudRTLProvider'()
    let MudScrollToTop'' = MudScrollToTop'()
    let MudSelectItem''<'T> = MudSelectItem'<'T>()
    let MudSkeleton'' = MudSkeleton'()
    let MudSlider''<'T when 'T : struct and 'T : (new : unit -> 'T) and System.Numerics.INumber<'T> and 'T :> System.ValueType> = MudSlider'<'T>()
    let MudSnackbarElement'' = MudSnackbarElement'()
    let MudSnackbarProvider'' = MudSnackbarProvider'()
    let MudStack'' = MudStack'()
    let MudStep'' = MudStep'()
    let MudStepper'' = MudStepper'()
    let MudSwipeArea'' = MudSwipeArea'()
    let MudTableGroupRow''<'T> = MudTableGroupRow'<'T>()
    let MudTablePager'' = MudTablePager'()
    let MudTableSortLabel''<'T> = MudTableSortLabel'<'T>()
    let MudTd'' = MudTd'()
    let MudTFootRow'' = MudTFootRow'()
    let MudTh'' = MudTh'()
    let MudTHeadRow'' = MudTHeadRow'()
    let MudTr'' = MudTr'()
    let MudSimpleTable'' = MudSimpleTable'()
    let MudTabPanel'' = MudTabPanel'()
    let MudTimelineItem'' = MudTimelineItem'()
    let MudToggleGroup''<'T> = MudToggleGroup'<'T>()
    let MudToggleItem''<'T> = MudToggleItem'<'T>()
    let MudToolBar'' = MudToolBar'()
    let MudTooltip'' = MudTooltip'()
    let MudTreeView''<'T> = MudTreeView'<'T>()
    let MudTreeViewItem''<'T> = MudTreeViewItem'<'T>()
    let MudTreeViewItemToggleButton'' = MudTreeViewItemToggleButton'()
    let MudText'' = MudText'()
    let MudContainer'' = MudContainer'()
    let MudThemeProvider'' = MudThemeProvider'()
    let BreadcrumbLink'' = BreadcrumbLink'()
    let BreadcrumbSeparator'' = BreadcrumbSeparator'()
    let SelectColumn''<'T> = SelectColumn'<'T>()
    let MudDialogProvider'' = MudDialogProvider'()
    let MudPopoverProvider'' = MudPopoverProvider'()
    let MudVirtualize''<'T> = MudVirtualize'<'T>()
    let MudRender'' = MudRender'()
    let MudSpacer'' = MudSpacer'()
            
namespace MudBlazor.Charts

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Charts


    /// Represents a chart which displays series values as rectangular bars.
    type Bar' 
        /// Represents a chart which displays series values as rectangular bars.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Bar>)>] () = inherit BarBuilder<MudBlazor.Charts.Bar>()

    /// Represents a chart which displays series values as connected lines.
    type Line' 
        /// Represents a chart which displays series values as connected lines.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Line>)>] () = inherit LineBuilder<MudBlazor.Charts.Line>()

    /// Represents a chart which displays series values as portions of vertical rectangles.
    type StackedBar' 
        /// Represents a chart which displays series values as portions of vertical rectangles.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.StackedBar>)>] () = inherit StackedBarBuilder<MudBlazor.Charts.StackedBar>()

    /// Represents a chart which displays values as a percentage of a circle.
    type Donut' 
        /// Represents a chart which displays values as a percentage of a circle.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Donut>)>] () = inherit DonutBuilder<MudBlazor.Charts.Donut>()
    type HeatMap' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.HeatMap>)>] () = inherit HeatMapBuilder<MudBlazor.Charts.HeatMap>()

    /// Represents a chart which displays values as a percentage of a circle.
    type Pie' 
        /// Represents a chart which displays values as a percentage of a circle.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Pie>)>] () = inherit PieBuilder<MudBlazor.Charts.Pie>()

    /// A chart which displays values over time.
    type TimeSeries' 
        /// A chart which displays values over time.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.TimeSeries>)>] () = inherit TimeSeriesBuilder<MudBlazor.Charts.TimeSeries>()

    /// Represents a set of text labels which describe data values in a MudChart.
    type Legend' 
        /// Represents a set of text labels which describe data values in a MudChart.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Legend>)>] () = inherit LegendBuilder<MudBlazor.Charts.Legend>()
    type ChartTooltip' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.ChartTooltip>)>] () = inherit ChartTooltipBuilder<MudBlazor.Charts.ChartTooltip>()
    type Filters' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Charts.Filters>)>] () = inherit FiltersBuilder<MudBlazor.Charts.Filters>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Charts

    let Bar'' = Bar'()
    let Line'' = Line'()
    let StackedBar'' = StackedBar'()
    let Donut'' = Donut'()
    let HeatMap'' = HeatMap'()
    let Pie'' = Pie'()
    let TimeSeries'' = TimeSeries'()
    let Legend'' = Legend'()
    let ChartTooltip'' = ChartTooltip'()
    let Filters'' = Filters'()
            
namespace MudBlazor.Internal

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Internal


    /// An icon displayed within an input component.
    type MudInputAdornment' 
        /// An icon displayed within an input component.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Internal.MudInputAdornment>)>] () = inherit MudInputAdornmentBuilder<MudBlazor.Internal.MudInputAdornment>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Internal

    let MudInputAdornment'' = MudInputAdornment'()
            
namespace MudBlazor.Components.Snackbar.InternalComponents

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Components.Snackbar.InternalComponents

    type SnackbarMessageMarkupString' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageMarkupString>)>] () = inherit SnackbarMessageMarkupStringBuilder<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageMarkupString>()
    type SnackbarMessageRenderFragment' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageRenderFragment>)>] () = inherit SnackbarMessageRenderFragmentBuilder<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageRenderFragment>()
    type SnackbarMessageText' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageText>)>] () = inherit SnackbarMessageTextBuilder<MudBlazor.Components.Snackbar.InternalComponents.SnackbarMessageText>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open MudBlazor.DslInternals.Components.Snackbar.InternalComponents

    let SnackbarMessageMarkupString'' = SnackbarMessageMarkupString'()
    let SnackbarMessageRenderFragment'' = SnackbarMessageRenderFragment'()
    let SnackbarMessageText'' = SnackbarMessageText'()
            