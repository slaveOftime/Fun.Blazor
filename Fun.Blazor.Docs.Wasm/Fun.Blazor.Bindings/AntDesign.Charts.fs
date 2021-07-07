namespace rec AntDesign.Charts.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.Charts.DslInternals


type ChartComponentBaseBuilder<'FunBlazorGeneric, 'TItem, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig) and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ChartComponentBaseBuilder<'FunBlazorGeneric, 'TItem, 'TConfig>() :> IFunBlazorNode
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TItem) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ColumnLineBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.ColumnLineConfig>()
    static member create () = ColumnLineBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type DualLineBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.DualLineConfig>()
    static member create () = DualLineBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type GroupedColumnLineBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.GroupedColumnLineConfig>()
    static member create () = GroupedColumnLineBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type StackedColumnLineBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StackedColumnLineConfig>()
    static member create () = StackedColumnLineBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type AreaBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.AreaConfig>()
    static member create () = AreaBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type BarBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.BarConfig>()
    static member create () = BarBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type BubbleBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.BubbleConfig>()
    static member create () = BubbleBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type BulletBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.BulletConfig>()
    static member create () = BulletBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type CalendarBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.CalendarConfig>()
    static member create () = CalendarBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type ColumnBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.ColumnConfig>()
    static member create () = ColumnBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type DensityHeatmapBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.DensityHeatmapConfig>()
    static member create () = DensityHeatmapBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type DonutBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.DonutConfig>()
    static member create () = DonutBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type FunnelBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.FunnelConfig>()
    static member create () = FunnelBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type GaugeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.GaugeConfig>()
    static member create () = GaugeBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type GroupedBarBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.GroupedBarConfig>()
    static member create () = GroupedBarBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type GroupedColumnBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.GroupedColumnConfig>()
    static member create () = GroupedColumnBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type HeatmapBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.HeatmapConfig>()
    static member create () = HeatmapBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type HistogramBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.HistogramConfig>()
    static member create () = HistogramBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type LineBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.LineConfig>()
    static member create () = LineBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type LiquidBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.LiquidConfig>()
    static member create () = LiquidBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type PercentStackedAreaBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.PercentStackedAreaConfig>()
    static member create () = PercentStackedAreaBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type PercentStackedBarBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.PercentStackedBarConfig>()
    static member create () = PercentStackedBarBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type PercentStackedColumnBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.PercentStackedColumnConfig>()
    static member create () = PercentStackedColumnBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type PieBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.PieConfig>()
    static member create () = PieBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type RadarBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.RadarConfig>()
    static member create () = RadarBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type RangeBarBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.RangeBarConfig>()
    static member create () = RangeBarBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type RangeColumnBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.RangeColumnConfig>()
    static member create () = RangeColumnBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type RoseBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.RoseConfig>()
    static member create () = RoseBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type ScatterBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.ScatterConfig>()
    static member create () = ScatterBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type StackedAreaBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StackedAreaConfig>()
    static member create () = StackedAreaBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type StackedBarBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StackedBarConfig>()
    static member create () = StackedBarBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type StackedColumnBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StackedColumnConfig>()
    static member create () = StackedColumnBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type StepLineBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StepLineConfig>()
    static member create () = StepLineBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type TreemapBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ITreemapData<'TItem>, AntDesign.Charts.TreemapConfig>()
    static member create () = TreemapBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type WaterfallBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.WaterfallConfig>()
    static member create () = WaterfallBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type ProgressBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Double, AntDesign.Charts.ProgressConfig>()
    static member create () = ProgressBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type RingProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Double, AntDesign.Charts.RingProgressConfig>()
    static member create () = RingProgressBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TinyAreaBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.TinyAreaConfig>()
    static member create () = TinyAreaBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type TinyColumnBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.TinyColumnConfig>()
    static member create () = TinyColumnBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type TinyLineBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.TinyLineConfig>()
    static member create () = TinyLineBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type TempBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, 'TItem, AntDesign.Charts.BarConfig>()
    static member create () = TempBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                
            

// =======================================================================================================================

namespace AntDesign.Charts

[<AutoOpen>]
module DslCE =

    open AntDesign.Charts.DslInternals

    type ChartComponentBase'<'TItem, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig)> = ChartComponentBaseBuilder<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>, 'TItem, 'TConfig>
    type ColumnLine'<'TItem> = ColumnLineBuilder<AntDesign.Charts.ColumnLine<'TItem>, 'TItem>
    type DualLine'<'TItem> = DualLineBuilder<AntDesign.Charts.DualLine<'TItem>, 'TItem>
    type GroupedColumnLine'<'TItem> = GroupedColumnLineBuilder<AntDesign.Charts.GroupedColumnLine<'TItem>, 'TItem>
    type StackedColumnLine'<'TItem> = StackedColumnLineBuilder<AntDesign.Charts.StackedColumnLine<'TItem>, 'TItem>
    type Area'<'TItem> = AreaBuilder<AntDesign.Charts.Area<'TItem>, 'TItem>
    type Bar'<'TItem> = BarBuilder<AntDesign.Charts.Bar<'TItem>, 'TItem>
    type Bubble'<'TItem> = BubbleBuilder<AntDesign.Charts.Bubble<'TItem>, 'TItem>
    type Bullet'<'TItem> = BulletBuilder<AntDesign.Charts.Bullet<'TItem>, 'TItem>
    type Calendar'<'TItem> = CalendarBuilder<AntDesign.Charts.Calendar<'TItem>, 'TItem>
    type Column'<'TItem> = ColumnBuilder<AntDesign.Charts.Column<'TItem>, 'TItem>
    type DensityHeatmap'<'TItem> = DensityHeatmapBuilder<AntDesign.Charts.DensityHeatmap<'TItem>, 'TItem>
    type Donut'<'TItem> = DonutBuilder<AntDesign.Charts.Donut<'TItem>, 'TItem>
    type Funnel'<'TItem> = FunnelBuilder<AntDesign.Charts.Funnel<'TItem>, 'TItem>
    type Gauge'<'TItem> = GaugeBuilder<AntDesign.Charts.Gauge<'TItem>, 'TItem>
    type GroupedBar'<'TItem> = GroupedBarBuilder<AntDesign.Charts.GroupedBar<'TItem>, 'TItem>
    type GroupedColumn'<'TItem> = GroupedColumnBuilder<AntDesign.Charts.GroupedColumn<'TItem>, 'TItem>
    type Heatmap'<'TItem> = HeatmapBuilder<AntDesign.Charts.Heatmap<'TItem>, 'TItem>
    type Histogram'<'TItem> = HistogramBuilder<AntDesign.Charts.Histogram<'TItem>, 'TItem>
    type Line'<'TItem> = LineBuilder<AntDesign.Charts.Line<'TItem>, 'TItem>
    type Liquid'<'TItem> = LiquidBuilder<AntDesign.Charts.Liquid<'TItem>, 'TItem>
    type PercentStackedArea'<'TItem> = PercentStackedAreaBuilder<AntDesign.Charts.PercentStackedArea<'TItem>, 'TItem>
    type PercentStackedBar'<'TItem> = PercentStackedBarBuilder<AntDesign.Charts.PercentStackedBar<'TItem>, 'TItem>
    type PercentStackedColumn'<'TItem> = PercentStackedColumnBuilder<AntDesign.Charts.PercentStackedColumn<'TItem>, 'TItem>
    type Pie'<'TItem> = PieBuilder<AntDesign.Charts.Pie<'TItem>, 'TItem>
    type Radar'<'TItem> = RadarBuilder<AntDesign.Charts.Radar<'TItem>, 'TItem>
    type RangeBar'<'TItem> = RangeBarBuilder<AntDesign.Charts.RangeBar<'TItem>, 'TItem>
    type RangeColumn'<'TItem> = RangeColumnBuilder<AntDesign.Charts.RangeColumn<'TItem>, 'TItem>
    type Rose'<'TItem> = RoseBuilder<AntDesign.Charts.Rose<'TItem>, 'TItem>
    type Scatter'<'TItem> = ScatterBuilder<AntDesign.Charts.Scatter<'TItem>, 'TItem>
    type StackedArea'<'TItem> = StackedAreaBuilder<AntDesign.Charts.StackedArea<'TItem>, 'TItem>
    type StackedBar'<'TItem> = StackedBarBuilder<AntDesign.Charts.StackedBar<'TItem>, 'TItem>
    type StackedColumn'<'TItem> = StackedColumnBuilder<AntDesign.Charts.StackedColumn<'TItem>, 'TItem>
    type StepLine'<'TItem> = StepLineBuilder<AntDesign.Charts.StepLine<'TItem>, 'TItem>
    type Treemap'<'TItem> = TreemapBuilder<AntDesign.Charts.Treemap<'TItem>, 'TItem>
    type Waterfall'<'TItem> = WaterfallBuilder<AntDesign.Charts.Waterfall<'TItem>, 'TItem>
    type Progress'<'TItem> = ProgressBuilder<AntDesign.Charts.Progress<'TItem>, 'TItem>
    type RingProgress' = RingProgressBuilder<AntDesign.Charts.RingProgress>
    type TinyArea'<'TItem> = TinyAreaBuilder<AntDesign.Charts.TinyArea<'TItem>, 'TItem>
    type TinyColumn'<'TItem> = TinyColumnBuilder<AntDesign.Charts.TinyColumn<'TItem>, 'TItem>
    type TinyLine'<'TItem> = TinyLineBuilder<AntDesign.Charts.TinyLine<'TItem>, 'TItem>
    type Temp'<'TItem> = TempBuilder<AntDesign.Charts.Temp<'TItem>, 'TItem>
            