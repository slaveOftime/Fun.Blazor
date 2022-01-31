namespace rec AntDesign.Charts.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.Charts.DslInternals


type ChartComponentBaseBuilder<'FunBlazorGeneric, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig) and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    static member inline create () = ChartComponentBaseBuilder<'FunBlazorGeneric, 'TConfig>()
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
    static member inline create () = AreaBuilder<'FunBlazorGeneric>()

                

type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BarConfig>()
    static member inline create () = BarBuilder<'FunBlazorGeneric>()

                

type BulletBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BulletConfig>()
    static member inline create () = BulletBuilder<'FunBlazorGeneric>()

                

type ColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ColumnConfig>()
    static member inline create () = ColumnBuilder<'FunBlazorGeneric>()

                

type DensityHeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.DensityHeatmapConfig>()
    static member inline create () = DensityHeatmapBuilder<'FunBlazorGeneric>()

                

type DualAxesBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.DualAxesConfig>()
    static member inline create () = DualAxesBuilder<'FunBlazorGeneric>()

                

type FunnelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.FunnelConfig>()
    static member inline create () = FunnelBuilder<'FunBlazorGeneric>()

                

type GaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.GaugeConfig>()
    static member inline create () = GaugeBuilder<'FunBlazorGeneric>()

                

type HeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.HeatmapConfig>()
    static member inline create () = HeatmapBuilder<'FunBlazorGeneric>()

                

type HistogramBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.HistogramConfig>()
    static member inline create () = HistogramBuilder<'FunBlazorGeneric>()

                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.LineConfig>()
    static member inline create () = LineBuilder<'FunBlazorGeneric>()

                

type LiquidBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.LiquidConfig>()
    static member inline create () = LiquidBuilder<'FunBlazorGeneric>()

                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.PieConfig>()
    static member inline create () = PieBuilder<'FunBlazorGeneric>()

                

type RadarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RadarConfig>()
    static member inline create () = RadarBuilder<'FunBlazorGeneric>()

                

type RoseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RoseConfig>()
    static member inline create () = RoseBuilder<'FunBlazorGeneric>()

                

type ScatterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ScatterConfig>()
    static member inline create () = ScatterBuilder<'FunBlazorGeneric>()

                

type TreemapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TreemapConfig>()
    static member inline create () = TreemapBuilder<'FunBlazorGeneric>()

                

type WaterfallBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.WaterfallConfig>()
    static member inline create () = WaterfallBuilder<'FunBlazorGeneric>()

                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ProgressConfig>()
    static member inline create () = ProgressBuilder<'FunBlazorGeneric>()

                

type RingProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RingProgressConfig>()
    static member inline create () = RingProgressBuilder<'FunBlazorGeneric>()

                

type TinyAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyAreaConfig>()
    static member inline create () = TinyAreaBuilder<'FunBlazorGeneric>()

                

type TinyColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyColumnConfig>()
    static member inline create () = TinyColumnBuilder<'FunBlazorGeneric>()

                

type TinyLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyLineConfig>()
    static member inline create () = TinyLineBuilder<'FunBlazorGeneric>()

                

type TempBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BarConfig>()
    static member inline create () = TempBuilder<'FunBlazorGeneric>()

                
            

// =======================================================================================================================

namespace AntDesign.Charts

[<AutoOpen>]
module DslCE =

    open AntDesign.Charts.DslInternals

    type ChartComponentBase'<'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig)>() = inherit ChartComponentBaseBuilder<AntDesign.Charts.ChartComponentBase<'TConfig>, 'TConfig>()
    type Area'() = inherit AreaBuilder<AntDesign.Charts.Area>()
    type Bar'() = inherit BarBuilder<AntDesign.Charts.Bar>()
    type Bullet'() = inherit BulletBuilder<AntDesign.Charts.Bullet>()
    type Column'() = inherit ColumnBuilder<AntDesign.Charts.Column>()
    type DensityHeatmap'() = inherit DensityHeatmapBuilder<AntDesign.Charts.DensityHeatmap>()
    type DualAxes'() = inherit DualAxesBuilder<AntDesign.Charts.DualAxes>()
    type Funnel'() = inherit FunnelBuilder<AntDesign.Charts.Funnel>()
    type Gauge'() = inherit GaugeBuilder<AntDesign.Charts.Gauge>()
    type Heatmap'() = inherit HeatmapBuilder<AntDesign.Charts.Heatmap>()
    type Histogram'() = inherit HistogramBuilder<AntDesign.Charts.Histogram>()
    type Line'() = inherit LineBuilder<AntDesign.Charts.Line>()
    type Liquid'() = inherit LiquidBuilder<AntDesign.Charts.Liquid>()
    type Pie'() = inherit PieBuilder<AntDesign.Charts.Pie>()
    type Radar'() = inherit RadarBuilder<AntDesign.Charts.Radar>()
    type Rose'() = inherit RoseBuilder<AntDesign.Charts.Rose>()
    type Scatter'() = inherit ScatterBuilder<AntDesign.Charts.Scatter>()
    type Treemap'() = inherit TreemapBuilder<AntDesign.Charts.Treemap>()
    type Waterfall'() = inherit WaterfallBuilder<AntDesign.Charts.Waterfall>()
    type Progress'() = inherit ProgressBuilder<AntDesign.Charts.Progress>()
    type RingProgress'() = inherit RingProgressBuilder<AntDesign.Charts.RingProgress>()
    type TinyArea'() = inherit TinyAreaBuilder<AntDesign.Charts.TinyArea>()
    type TinyColumn'() = inherit TinyColumnBuilder<AntDesign.Charts.TinyColumn>()
    type TinyLine'() = inherit TinyLineBuilder<AntDesign.Charts.TinyLine>()
    type Temp'() = inherit TempBuilder<AntDesign.Charts.Temp>()
            