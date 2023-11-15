namespace rec ApexCharts.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open ApexCharts.DslInternals

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            
namespace rec ApexCharts.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open ApexCharts.DslInternals

/// Main component to create an Apex chart in Blazor
type ApexChartBuilder<'FunBlazorGeneric, 'TItem when 'TItem : not struct and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Tooltip allows you to preview data when user hovers over the chart area.
    [<CustomOperation("ApexPointTooltip")>] member inline _.ApexPointTooltip ([<InlineIfLambda>] render: AttrRenderFragment, fn: ApexCharts.HoverData<'TItem> -> NodeRenderFragment) = render ==> html.renderFragment("ApexPointTooltip", fn)
    /// The options to customize the chart with
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: ApexCharts.ApexChartOptions<'TItem>) = render ==> ("Options" => x)
    /// Text to display as a title of chart
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// Specifies the data type to use for the x-axis
    [<CustomOperation("XAxisType")>] member inline _.XAxisType ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Nullable<ApexCharts.XAxisType>) = render ==> ("XAxisType" => x)
    /// Specifies whether to enable debug mode
    [<CustomOperation("Debug")>] member inline _.Debug ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("Debug" => x)
    /// Width of the chart.
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Width" => x)
    /// Height of the chart. The default value 'auto' is calculated based on the golden ratio 1.618 which roughly translates to a 16:10 aspect ratio. Examples:
    /// 
    /// 
    /// height: 400 
    /// height: '400px' 
    /// height: '100%' 
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Height" => x)
    /// Fires when user clicks on the x-axis labels.
    [<CustomOperation("OnXAxisLabelClick")>] member inline _.OnXAxisLabelClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.XAxisLabelClicked<'TItem>>("OnXAxisLabelClick", fn)
    /// Fires when user clicks on the x-axis labels.
    [<CustomOperation("OnXAxisLabelClick")>] member inline _.OnXAxisLabelClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.XAxisLabelClicked<'TItem>>("OnXAxisLabelClick", fn)
    /// Fires when user clicks on the markers.
    [<CustomOperation("OnMarkerClick")>] member inline _.OnMarkerClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.SelectedData<'TItem>>("OnMarkerClick", fn)
    /// Fires when user clicks on the markers.
    [<CustomOperation("OnMarkerClick")>] member inline _.OnMarkerClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.SelectedData<'TItem>>("OnMarkerClick", fn)
    /// Fires when user clicks on a datapoint (bar/column/marker/bubble/donut-slice).
    [<CustomOperation("OnDataPointSelection")>] member inline _.OnDataPointSelection ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.SelectedData<'TItem>>("OnDataPointSelection", fn)
    /// Fires when user clicks on a datapoint (bar/column/marker/bubble/donut-slice).
    [<CustomOperation("OnDataPointSelection")>] member inline _.OnDataPointSelection ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.SelectedData<'TItem>>("OnDataPointSelection", fn)
    /// Fires when user's mouse enter on a datapoint (bar/column/marker/bubble/donut-slice).
    [<CustomOperation("OnDataPointEnter")>] member inline _.OnDataPointEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.HoverData<'TItem>>("OnDataPointEnter", fn)
    /// Fires when user's mouse enter on a datapoint (bar/column/marker/bubble/donut-slice).
    [<CustomOperation("OnDataPointEnter")>] member inline _.OnDataPointEnter ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.HoverData<'TItem>>("OnDataPointEnter", fn)
    /// MouseLeave event for a datapoint (bar/column/marker/bubble/donut-slice).
    [<CustomOperation("OnDataPointLeave")>] member inline _.OnDataPointLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.HoverData<'TItem>>("OnDataPointLeave", fn)
    /// MouseLeave event for a datapoint (bar/column/marker/bubble/donut-slice).
    [<CustomOperation("OnDataPointLeave")>] member inline _.OnDataPointLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.HoverData<'TItem>>("OnDataPointLeave", fn)
    /// Fires when user clicks on legend.
    [<CustomOperation("OnLegendClicked")>] member inline _.OnLegendClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.LegendClicked<'TItem>>("OnLegendClicked", fn)
    /// Fires when user clicks on legend.
    [<CustomOperation("OnLegendClicked")>] member inline _.OnLegendClicked ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.LegendClicked<'TItem>>("OnLegendClicked", fn)
    /// Fires when user selects rect using the selection tool.
    [<CustomOperation("OnSelection")>] member inline _.OnSelection ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.SelectionData<'TItem>>("OnSelection", fn)
    /// Fires when user selects rect using the selection tool.
    [<CustomOperation("OnSelection")>] member inline _.OnSelection ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.SelectionData<'TItem>>("OnSelection", fn)
    /// Fires when user drags the brush in a brush chart.
    [<CustomOperation("OnBrushScrolled")>] member inline _.OnBrushScrolled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.SelectionData<'TItem>>("OnBrushScrolled", fn)
    /// Fires when user drags the brush in a brush chart.
    [<CustomOperation("OnBrushScrolled")>] member inline _.OnBrushScrolled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.SelectionData<'TItem>>("OnBrushScrolled", fn)
    /// Fires when user zooms in/out the chart using either the selection zooming tool or zoom in/out buttons.
    [<CustomOperation("OnZoomed")>] member inline _.OnZoomed ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.ZoomedData<'TItem>>("OnZoomed", fn)
    /// Fires when user zooms in/out the chart using either the selection zooming tool or zoom in/out buttons.
    [<CustomOperation("OnZoomed")>] member inline _.OnZoomed ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.ZoomedData<'TItem>>("OnZoomed", fn)
    /// Fires when the chart’s initial animation is finished.
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnAnimationEnd", fn)
    /// Fires when the chart’s initial animation is finished.
    [<CustomOperation("OnAnimationEnd")>] member inline _.OnAnimationEnd ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnAnimationEnd", fn)
    /// Fires before the chart has been drawn on screen.
    [<CustomOperation("OnBeforeMount")>] member inline _.OnBeforeMount ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnBeforeMount", fn)
    /// Fires before the chart has been drawn on screen.
    [<CustomOperation("OnBeforeMount")>] member inline _.OnBeforeMount ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnBeforeMount", fn)
    /// Fires after the chart has been drawn on screen.
    [<CustomOperation("OnMounted")>] member inline _.OnMounted ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnMounted", fn)
    /// Fires after the chart has been drawn on screen.
    [<CustomOperation("OnMounted")>] member inline _.OnMounted ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnMounted", fn)
    /// Fires when the chart has been dynamically updated either with UpdateOptionsAsync or UpdateSeriesAsync functions.
    [<CustomOperation("OnUpdated")>] member inline _.OnUpdated ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnUpdated", fn)
    /// Fires when the chart has been dynamically updated either with UpdateOptionsAsync or UpdateSeriesAsync functions.
    [<CustomOperation("OnUpdated")>] member inline _.OnUpdated ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnUpdated", fn)
    /// Fires when user moves mouse on any area of the chart.
    [<CustomOperation("OnMouseMove")>] member inline _.OnMouseMove ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.SelectedData<'TItem>>("OnMouseMove", fn)
    /// Fires when user moves mouse on any area of the chart.
    [<CustomOperation("OnMouseMove")>] member inline _.OnMouseMove ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.SelectedData<'TItem>>("OnMouseMove", fn)
    /// Fires when user moves mouse outside chart area (exclusing axis).
    [<CustomOperation("OnMouseLeave")>] member inline _.OnMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnMouseLeave", fn)
    /// Fires when user moves mouse outside chart area (exclusing axis).
    [<CustomOperation("OnMouseLeave")>] member inline _.OnMouseLeave ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnMouseLeave", fn)
    /// Fires when user clicks on any area of the chart.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.SelectedData<'TItem>>("OnClick", fn)
    /// Fires when user clicks on any area of the chart.
    [<CustomOperation("OnClick")>] member inline _.OnClick ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.SelectedData<'TItem>>("OnClick", fn)
    /// This function, if defined, runs just before zooming in/out of the chart allowing you to set a custom range for zooming in/out.
    [<CustomOperation("OnBeforeZoom")>] member inline _.OnBeforeZoom ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnBeforeZoom" => (System.Func<ApexCharts.SelectionXAxis, ApexCharts.SelectionXAxis>fn))
    /// This function, if defined, runs just before the user hits the HOME button on the toolbar to reset the chart to it’s original state. The function allows you to set a custom axes range for the initial view of the chart.
    [<CustomOperation("OnBeforeResetZoom")>] member inline _.OnBeforeResetZoom ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OnBeforeResetZoom" => (System.Func<System.Object, ApexCharts.SelectionXAxis>fn))
    /// Fires when user scrolls using the pan tool. The 2nd argument includes information of the new xaxis generated after scrolling.
    [<CustomOperation("OnScrolled")>] member inline _.OnScrolled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback<ApexCharts.SelectionData<'TItem>>("OnScrolled", fn)
    /// Fires when user scrolls using the pan tool. The 2nd argument includes information of the new xaxis generated after scrolling.
    [<CustomOperation("OnScrolled")>] member inline _.OnScrolled ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask<ApexCharts.SelectionData<'TItem>>("OnScrolled", fn)
    /// Fires when RenderAsync completes
    [<CustomOperation("OnRendered")>] member inline _.OnRendered ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callback("OnRendered", fn)
    /// Fires when RenderAsync completes
    [<CustomOperation("OnRendered")>] member inline _.OnRendered ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> html.callbackTask("OnRendered", fn)
    /// A custom function to execute for generating Y-axis labels. Only supported in Blazor WebAssembly!
    [<CustomOperation("FormatYAxisLabel")>] member inline _.FormatYAxisLabel ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("FormatYAxisLabel" => (System.Func<System.Decimal, System.String>fn))
    /// Enables merging multiple data points into a single item in the chart
    [<CustomOperation("GroupPoints")>] member inline _.GroupPoints ([<InlineIfLambda>] render: AttrRenderFragment, x: ApexCharts.GroupPoints) = render ==> ("GroupPoints" => x)

/// Component to create a single-value RadialBar chart in Blazor
type ApexGaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// Text to display as a title of chart
    [<CustomOperation("Title")>] member inline _.Title ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    /// The value to assign to the radial bar chart
    [<CustomOperation("Percentage")>] member inline _.Percentage ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Decimal) = render ==> ("Percentage" => x)
    /// The text name for the data series in the chart
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Label" => x)
    /// The options to customize the radial bar chart with
    [<CustomOperation("Options")>] member inline _.Options ([<InlineIfLambda>] render: AttrRenderFragment, x: ApexCharts.ApexChartOptions<ApexCharts.GaugeValue>) = render ==> ("Options" => x)

/// Base class to create a data series for a chart
type ApexBaseSeriesBuilder<'FunBlazorGeneric, 'TItem when 'TItem : not struct and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Name")>] member inline _.Name ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("XValue")>] member inline _.XValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("XValue" => (System.Func<'TItem, System.Object>fn))
    [<CustomOperation("ShowDataLabels")>] member inline _.ShowDataLabels ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowDataLabels" => x)
    [<CustomOperation("Items")>] member inline _.Items ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<'TItem>) = render ==> ("Items" => x)
    [<CustomOperation("Stroke")>] member inline _.Stroke ([<InlineIfLambda>] render: AttrRenderFragment, x: ApexCharts.SeriesStroke) = render ==> ("Stroke" => x)
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    /// A function to provide a custom color for data points in the series
    [<CustomOperation("PointColor")>] member inline _.PointColor ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("PointColor" => (System.Func<'TItem, System.String>fn))
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Group" => x)

/// Component to create a BoxPlot data series in Blazor
type ApexBoxPlotSeriesBuilder<'FunBlazorGeneric, 'TItem when 'TItem : not struct and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ApexBaseSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Expression to get the lowest Y-Value for each X-Value. This will determine where the lower whisker is drawn.
    [<CustomOperation("Min")>] member inline _.Min ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Min" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the Q1 Y-Value for each X-Value. This will determine where the bottom of the box is drawn.
    [<CustomOperation("Quantile1")>] member inline _.Quantile1 ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Quantile1" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the median Y-Value for each X-Value. This will determine where the separator line between Q1 and Q3 is drawn.
    [<CustomOperation("Median")>] member inline _.Median ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Median" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the Q3 Y-Value for each X-Value. This will determine where the top of the box is drawn.
    [<CustomOperation("Quantile3")>] member inline _.Quantile3 ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Quantile3" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the highest Y-Value for each X-Value. This will determine where the upper whisker is drawn.
    [<CustomOperation("Max")>] member inline _.Max ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Max" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to determine the ordering of X-Values in the series
    [<CustomOperation("OrderBy")>] member inline _.OrderBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderBy" => (System.Func<ApexCharts.ListPoint<'TItem>, System.Object>fn))
    /// Expression to determine the inverse ordering of X-Values in the series
    [<CustomOperation("OrderByDescending")>] member inline _.OrderByDescending ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderByDescending" => (System.Func<ApexCharts.ListPoint<'TItem>, System.Object>fn))
    /// Function to conditionally modify individual data points in the series
    [<CustomOperation("DataPointMutator")>] member inline _.DataPointMutator ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DataPointMutator" => (System.Action<ApexCharts.ListPoint<'TItem>>fn))

/// Component to create a Bubble data series in Blazor
type ApexBubbleSeriesBuilder<'FunBlazorGeneric, 'TItem when 'TItem : not struct and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ApexBaseSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Expression to group Y-Values with. This will determine where each bubble is drawn on the Y-axis.
    [<CustomOperation("YAggregate")>] member inline _.YAggregate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("YAggregate" => (System.Func<System.Collections.Generic.IEnumerable<'TItem>, System.Decimal>fn))
    /// Expression to group Z-Values with. This will determine the size of each bubble.
    [<CustomOperation("ZAggregate")>] member inline _.ZAggregate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("ZAggregate" => (System.Func<System.Collections.Generic.IEnumerable<'TItem>, System.Decimal>fn))
    /// Expression to determine the ordering of X-Values in the series
    [<CustomOperation("OrderBy")>] member inline _.OrderBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderBy" => (System.Func<ApexCharts.BubblePoint<'TItem>, System.Object>fn))
    /// Expression to determine the inverse ordering of X-Values in the series
    [<CustomOperation("OrderByDescending")>] member inline _.OrderByDescending ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderByDescending" => (System.Func<ApexCharts.BubblePoint<'TItem>, System.Object>fn))
    /// Function to conditionally modify individual data points in the series
    [<CustomOperation("DataPointMutator")>] member inline _.DataPointMutator ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DataPointMutator" => (System.Action<ApexCharts.BubblePoint<'TItem>>fn))

/// Component to create a Candlestick data series in Blazor
type ApexCandleSeriesBuilder<'FunBlazorGeneric, 'TItem when 'TItem : not struct and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ApexBaseSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Expression to get the starting Y-Value for each X-Value. This will determine where the top and bottom of the box are drawn.
    [<CustomOperation("Open")>] member inline _.Open ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Open" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the highest Y-Value for each X-Value. This will determine where the top of the wick is drawn.
    [<CustomOperation("High")>] member inline _.High ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("High" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the lowest Y-Value for each X-Value. This will determine where the bottom of the wick is drawn.
    [<CustomOperation("Low")>] member inline _.Low ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Low" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the starting Y-Value for each X-Value. This will determine where the top and bottom of the box are drawn.
    [<CustomOperation("Close")>] member inline _.Close ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Close" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to determine the ordering of X-Values in the series
    [<CustomOperation("OrderBy")>] member inline _.OrderBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderBy" => (System.Func<ApexCharts.ListPoint<'TItem>, System.Object>fn))
    /// Expression to determine the inverse ordering of X-Values in the series
    [<CustomOperation("OrderByDescending")>] member inline _.OrderByDescending ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderByDescending" => (System.Func<ApexCharts.ListPoint<'TItem>, System.Object>fn))
    /// Function to conditionally modify individual data points in the series
    [<CustomOperation("DataPointMutator")>] member inline _.DataPointMutator ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DataPointMutator" => (System.Action<ApexCharts.ListPoint<'TItem>>fn))

/// Component to create various data series types in Blazor
type ApexPointSeriesBuilder<'FunBlazorGeneric, 'TItem when 'TItem : not struct and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ApexBaseSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Expression to get the Y-value for each X-Value. Use when a single Y-value is available.
    [<CustomOperation("YValue")>] member inline _.YValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("YValue" => (System.Func<'TItem, System.Nullable<System.Decimal>>fn))
    /// Expression to group Y-values for each X-Value. Use when a multiple Y-values are available.
    [<CustomOperation("YAggregate")>] member inline _.YAggregate ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("YAggregate" => (System.Func<System.Collections.Generic.IEnumerable<'TItem>, System.Nullable<System.Decimal>>fn))
    /// Expression to determine the ordering of X-Values in the series
    [<CustomOperation("OrderBy")>] member inline _.OrderBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderBy" => (System.Func<ApexCharts.DataPoint<'TItem>, System.Object>fn))
    /// Expression to determine the inverse ordering of X-Values in the series
    [<CustomOperation("OrderByDescending")>] member inline _.OrderByDescending ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderByDescending" => (System.Func<ApexCharts.DataPoint<'TItem>, System.Object>fn))
    /// Determines the type of data series to draw on the chart
    [<CustomOperation("SeriesType")>] member inline _.SeriesType ([<InlineIfLambda>] render: AttrRenderFragment, x: ApexCharts.SeriesType) = render ==> ("SeriesType" => x)
    /// Function to conditionally modify individual data points in the series
    [<CustomOperation("DataPointMutator")>] member inline _.DataPointMutator ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DataPointMutator" => (System.Action<ApexCharts.DataPoint<'TItem>>fn))

/// Component to create a RangeArea data series in Blazor
type ApexRangeAreaSeriesBuilder<'FunBlazorGeneric, 'TItem when 'TItem : not struct and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ApexBaseSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Expression to get the upper Y-Value for each X-Value
    [<CustomOperation("Top")>] member inline _.Top ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Top" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the lower Y-Value for each X-Value
    [<CustomOperation("Bottom")>] member inline _.Bottom ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("Bottom" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to determine the ordering of X-Values in the series
    [<CustomOperation("OrderBy")>] member inline _.OrderBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderBy" => (System.Func<ApexCharts.ListPoint<'TItem>, System.Object>fn))
    /// Expression to determine the inverse ordering of X-Values in the series
    [<CustomOperation("OrderByDescending")>] member inline _.OrderByDescending ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderByDescending" => (System.Func<ApexCharts.ListPoint<'TItem>, System.Object>fn))
    /// Function to conditionally modify individual data points in the series
    [<CustomOperation("DataPointMutator")>] member inline _.DataPointMutator ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DataPointMutator" => (System.Action<ApexCharts.ListPoint<'TItem>>fn))

/// Component to create a RangeBar data series in Blazor
type ApexRangeSeriesBuilder<'FunBlazorGeneric, 'TItem when 'TItem : not struct and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ApexBaseSeriesBuilder<'FunBlazorGeneric, 'TItem>()
    /// Expression to get the Y-values for each X-Value. This will determine the starting and ending points for each individual bar.
    [<CustomOperation("YValue")>] member inline _.YValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("YValue" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to determine the ordering of X-Values in the series
    [<CustomOperation("OrderBy")>] member inline _.OrderBy ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderBy" => (System.Func<ApexCharts.ListPoint<'TItem>, System.Object>fn))
    /// Expression to determine the inverse ordering of X-Values in the series
    [<CustomOperation("OrderByDescending")>] member inline _.OrderByDescending ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("OrderByDescending" => (System.Func<ApexCharts.ListPoint<'TItem>, System.Object>fn))
    /// Expression to get the minumum Y-value for each X-Value. This will be the starting point for an individual bar.
    [<CustomOperation("YMinValue")>] member inline _.YMinValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("YMinValue" => (System.Func<'TItem, System.Decimal>fn))
    /// Expression to get the maximum Y-value for each X-Value. This will be the ending point for an individual bar.
    [<CustomOperation("YMaxValue")>] member inline _.YMaxValue ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("YMaxValue" => (System.Func<'TItem, System.Decimal>fn))
    /// Function to conditionally modify individual data points in the series
    [<CustomOperation("DataPointMutator")>] member inline _.DataPointMutator ([<InlineIfLambda>] render: AttrRenderFragment, fn) = render ==> ("DataPointMutator" => (System.Action<ApexCharts.ListPoint<'TItem>>fn))

            

// =======================================================================================================================

namespace ApexCharts

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open ApexCharts.DslInternals

    type _Imports' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor_ApexCharts._Imports>)>] () = inherit _ImportsBuilder<Blazor_ApexCharts._Imports>()

    /// Main component to create an Apex chart in Blazor
    type ApexChart'<'TItem when 'TItem : not struct> 
        /// Main component to create an Apex chart in Blazor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexChart<_>>)>] () = inherit ApexChartBuilder<ApexCharts.ApexChart<'TItem>, 'TItem>()

    /// Component to create a single-value RadialBar chart in Blazor
    type ApexGauge' 
        /// Component to create a single-value RadialBar chart in Blazor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexGauge>)>] () = inherit ApexGaugeBuilder<ApexCharts.ApexGauge>()

    /// Base class to create a data series for a chart
    type ApexBaseSeries'<'TItem when 'TItem : not struct> 
        /// Base class to create a data series for a chart
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexBaseSeries<_>>)>] () = inherit ApexBaseSeriesBuilder<ApexCharts.ApexBaseSeries<'TItem>, 'TItem>()

    /// Component to create a BoxPlot data series in Blazor
    type ApexBoxPlotSeries'<'TItem when 'TItem : not struct> 
        /// Component to create a BoxPlot data series in Blazor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexBoxPlotSeries<_>>)>] () = inherit ApexBoxPlotSeriesBuilder<ApexCharts.ApexBoxPlotSeries<'TItem>, 'TItem>()

    /// Component to create a Bubble data series in Blazor
    type ApexBubbleSeries'<'TItem when 'TItem : not struct> 
        /// Component to create a Bubble data series in Blazor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexBubbleSeries<_>>)>] () = inherit ApexBubbleSeriesBuilder<ApexCharts.ApexBubbleSeries<'TItem>, 'TItem>()

    /// Component to create a Candlestick data series in Blazor
    type ApexCandleSeries'<'TItem when 'TItem : not struct> 
        /// Component to create a Candlestick data series in Blazor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexCandleSeries<_>>)>] () = inherit ApexCandleSeriesBuilder<ApexCharts.ApexCandleSeries<'TItem>, 'TItem>()

    /// Component to create various data series types in Blazor
    type ApexPointSeries'<'TItem when 'TItem : not struct> 
        /// Component to create various data series types in Blazor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexPointSeries<_>>)>] () = inherit ApexPointSeriesBuilder<ApexCharts.ApexPointSeries<'TItem>, 'TItem>()

    /// Component to create a RangeArea data series in Blazor
    type ApexRangeAreaSeries'<'TItem when 'TItem : not struct> 
        /// Component to create a RangeArea data series in Blazor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexRangeAreaSeries<_>>)>] () = inherit ApexRangeAreaSeriesBuilder<ApexCharts.ApexRangeAreaSeries<'TItem>, 'TItem>()

    /// Component to create a RangeBar data series in Blazor
    type ApexRangeSeries'<'TItem when 'TItem : not struct> 
        /// Component to create a RangeBar data series in Blazor
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<ApexCharts.ApexRangeSeries<_>>)>] () = inherit ApexRangeSeriesBuilder<ApexCharts.ApexRangeSeries<'TItem>, 'TItem>()
            