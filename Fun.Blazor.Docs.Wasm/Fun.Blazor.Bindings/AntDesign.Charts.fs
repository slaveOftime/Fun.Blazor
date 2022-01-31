namespace rec AntDesign.Charts.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.Charts.DslInternals


type ChartComponentBaseBuilder<'FunBlazorGeneric, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig) and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Data")>] member inline _.Data (render: AttrRenderFragment, x: System.Object) = render ==> ("Data" => x)
    [<CustomOperation("Config")>] member inline _.Config (render: AttrRenderFragment, x: 'TConfig) = render ==> ("Config" => x)
    [<CustomOperation("JsonConfig")>] member inline _.JsonConfig (render: AttrRenderFragment, x: System.String) = render ==> ("JsonConfig" => x)
    [<CustomOperation("JsConfig")>] member inline _.JsConfig (render: AttrRenderFragment, x: System.String) = render ==> ("JsConfig" => x)
    [<CustomOperation("OtherConfig")>] member inline _.OtherConfig (render: AttrRenderFragment, x: System.Object) = render ==> ("OtherConfig" => x)
    [<CustomOperation("OnCreateAfter")>] member inline _.OnCreateAfter (render: AttrRenderFragment, fn) = render ==> html.callback<AntDesign.Charts.IChartComponent>("OnCreateAfter", fn)
    [<CustomOperation("OnFirstRender")>] member inline _.OnFirstRender (render: AttrRenderFragment, fn) = render ==> html.callback<AntDesign.Charts.IChartComponent>("OnFirstRender", fn)
    [<CustomOperation("OnTitleClick")>] member inline _.OnTitleClick (render: AttrRenderFragment, fn) = render ==> html.callback<AntDesign.Charts.ChartEvent>("OnTitleClick", fn)
                

type AreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.AreaConfig>()

                

type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BarConfig>()

                

type BulletBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BulletConfig>()

                

type ColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ColumnConfig>()

                

type DensityHeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.DensityHeatmapConfig>()

                

type DualAxesBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.DualAxesConfig>()

                

type FunnelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.FunnelConfig>()

                

type GaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.GaugeConfig>()

                

type HeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.HeatmapConfig>()

                

type HistogramBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.HistogramConfig>()

                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.LineConfig>()

                

type LiquidBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.LiquidConfig>()

                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.PieConfig>()

                

type RadarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RadarConfig>()

                

type RoseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RoseConfig>()

                

type ScatterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ScatterConfig>()

                

type TreemapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TreemapConfig>()

                

type WaterfallBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.WaterfallConfig>()

                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ProgressConfig>()

                

type RingProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RingProgressConfig>()

                

type TinyAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyAreaConfig>()

                

type TinyColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyColumnConfig>()

                

type TinyLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyLineConfig>()

                

type TempBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BarConfig>()

                
            

// =======================================================================================================================

namespace AntDesign.Charts

[<AutoOpen>]
module DslCE =

    open AntDesign.Charts.DslInternals

    let ChartComponentBase'<'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig)> = ChartComponentBaseBuilder<AntDesign.Charts.ChartComponentBase<'TConfig>, 'TConfig>()
    let Area' = AreaBuilder<AntDesign.Charts.Area>()
    let Bar' = BarBuilder<AntDesign.Charts.Bar>()
    let Bullet' = BulletBuilder<AntDesign.Charts.Bullet>()
    let Column' = ColumnBuilder<AntDesign.Charts.Column>()
    let DensityHeatmap' = DensityHeatmapBuilder<AntDesign.Charts.DensityHeatmap>()
    let DualAxes' = DualAxesBuilder<AntDesign.Charts.DualAxes>()
    let Funnel' = FunnelBuilder<AntDesign.Charts.Funnel>()
    let Gauge' = GaugeBuilder<AntDesign.Charts.Gauge>()
    let Heatmap' = HeatmapBuilder<AntDesign.Charts.Heatmap>()
    let Histogram' = HistogramBuilder<AntDesign.Charts.Histogram>()
    let Line' = LineBuilder<AntDesign.Charts.Line>()
    let Liquid' = LiquidBuilder<AntDesign.Charts.Liquid>()
    let Pie' = PieBuilder<AntDesign.Charts.Pie>()
    let Radar' = RadarBuilder<AntDesign.Charts.Radar>()
    let Rose' = RoseBuilder<AntDesign.Charts.Rose>()
    let Scatter' = ScatterBuilder<AntDesign.Charts.Scatter>()
    let Treemap' = TreemapBuilder<AntDesign.Charts.Treemap>()
    let Waterfall' = WaterfallBuilder<AntDesign.Charts.Waterfall>()
    let Progress' = ProgressBuilder<AntDesign.Charts.Progress>()
    let RingProgress' = RingProgressBuilder<AntDesign.Charts.RingProgress>()
    let TinyArea' = TinyAreaBuilder<AntDesign.Charts.TinyArea>()
    let TinyColumn' = TinyColumnBuilder<AntDesign.Charts.TinyColumn>()
    let TinyLine' = TinyLineBuilder<AntDesign.Charts.TinyLine>()
    let Temp' = TempBuilder<AntDesign.Charts.Temp>()
            