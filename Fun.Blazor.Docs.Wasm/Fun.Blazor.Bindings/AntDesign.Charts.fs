namespace rec AntDesign.Charts.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.Charts.DslInternals


type ChartComponentBaseBuilder<'FunBlazorGeneric, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig) and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = ChartComponentBaseBuilder<'FunBlazorGeneric, 'TConfig>().CreateNode()
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Data" => x |> this.AddAttr
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'TConfig) = "Config" => x |> this.AddAttr
    [<CustomOperation("JsonConfig")>] member this.JsonConfig (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "JsonConfig" => x |> this.AddAttr
    [<CustomOperation("JsConfig")>] member this.JsConfig (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "JsConfig" => x |> this.AddAttr
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "OtherConfig" => x |> this.AddAttr
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnFirstRender")>] member this.OnFirstRender (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnFirstRender" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> this.AddAttr
                

type AreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.AreaConfig>()
    static member create () = AreaBuilder<'FunBlazorGeneric>().CreateNode()

                

type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BarConfig>()
    static member create () = BarBuilder<'FunBlazorGeneric>().CreateNode()

                

type BulletBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BulletConfig>()
    static member create () = BulletBuilder<'FunBlazorGeneric>().CreateNode()

                

type ColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ColumnConfig>()
    static member create () = ColumnBuilder<'FunBlazorGeneric>().CreateNode()

                

type DensityHeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.DensityHeatmapConfig>()
    static member create () = DensityHeatmapBuilder<'FunBlazorGeneric>().CreateNode()

                

type DualAxesBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.DualAxesConfig>()
    static member create () = DualAxesBuilder<'FunBlazorGeneric>().CreateNode()

                

type FunnelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.FunnelConfig>()
    static member create () = FunnelBuilder<'FunBlazorGeneric>().CreateNode()

                

type GaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.GaugeConfig>()
    static member create () = GaugeBuilder<'FunBlazorGeneric>().CreateNode()

                

type HeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.HeatmapConfig>()
    static member create () = HeatmapBuilder<'FunBlazorGeneric>().CreateNode()

                

type HistogramBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.HistogramConfig>()
    static member create () = HistogramBuilder<'FunBlazorGeneric>().CreateNode()

                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.LineConfig>()
    static member create () = LineBuilder<'FunBlazorGeneric>().CreateNode()

                

type LiquidBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.LiquidConfig>()
    static member create () = LiquidBuilder<'FunBlazorGeneric>().CreateNode()

                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.PieConfig>()
    static member create () = PieBuilder<'FunBlazorGeneric>().CreateNode()

                

type RadarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RadarConfig>()
    static member create () = RadarBuilder<'FunBlazorGeneric>().CreateNode()

                

type RoseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RoseConfig>()
    static member create () = RoseBuilder<'FunBlazorGeneric>().CreateNode()

                

type ScatterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ScatterConfig>()
    static member create () = ScatterBuilder<'FunBlazorGeneric>().CreateNode()

                

type TreemapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TreemapConfig>()
    static member create () = TreemapBuilder<'FunBlazorGeneric>().CreateNode()

                

type WaterfallBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.WaterfallConfig>()
    static member create () = WaterfallBuilder<'FunBlazorGeneric>().CreateNode()

                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ProgressConfig>()
    static member create () = ProgressBuilder<'FunBlazorGeneric>().CreateNode()

                

type RingProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RingProgressConfig>()
    static member create () = RingProgressBuilder<'FunBlazorGeneric>().CreateNode()

                

type TinyAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyAreaConfig>()
    static member create () = TinyAreaBuilder<'FunBlazorGeneric>().CreateNode()

                

type TinyColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyColumnConfig>()
    static member create () = TinyColumnBuilder<'FunBlazorGeneric>().CreateNode()

                

type TinyLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyLineConfig>()
    static member create () = TinyLineBuilder<'FunBlazorGeneric>().CreateNode()

                

type TempBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BarConfig>()
    static member create () = TempBuilder<'FunBlazorGeneric>().CreateNode()

                
            

// =======================================================================================================================

namespace AntDesign.Charts

[<AutoOpen>]
module DslCE =

    open AntDesign.Charts.DslInternals

    type ChartComponentBase'<'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig)> = ChartComponentBaseBuilder<AntDesign.Charts.ChartComponentBase<'TConfig>, 'TConfig>
    type Area' = AreaBuilder<AntDesign.Charts.Area>
    type Bar' = BarBuilder<AntDesign.Charts.Bar>
    type Bullet' = BulletBuilder<AntDesign.Charts.Bullet>
    type Column' = ColumnBuilder<AntDesign.Charts.Column>
    type DensityHeatmap' = DensityHeatmapBuilder<AntDesign.Charts.DensityHeatmap>
    type DualAxes' = DualAxesBuilder<AntDesign.Charts.DualAxes>
    type Funnel' = FunnelBuilder<AntDesign.Charts.Funnel>
    type Gauge' = GaugeBuilder<AntDesign.Charts.Gauge>
    type Heatmap' = HeatmapBuilder<AntDesign.Charts.Heatmap>
    type Histogram' = HistogramBuilder<AntDesign.Charts.Histogram>
    type Line' = LineBuilder<AntDesign.Charts.Line>
    type Liquid' = LiquidBuilder<AntDesign.Charts.Liquid>
    type Pie' = PieBuilder<AntDesign.Charts.Pie>
    type Radar' = RadarBuilder<AntDesign.Charts.Radar>
    type Rose' = RoseBuilder<AntDesign.Charts.Rose>
    type Scatter' = ScatterBuilder<AntDesign.Charts.Scatter>
    type Treemap' = TreemapBuilder<AntDesign.Charts.Treemap>
    type Waterfall' = WaterfallBuilder<AntDesign.Charts.Waterfall>
    type Progress' = ProgressBuilder<AntDesign.Charts.Progress>
    type RingProgress' = RingProgressBuilder<AntDesign.Charts.RingProgress>
    type TinyArea' = TinyAreaBuilder<AntDesign.Charts.TinyArea>
    type TinyColumn' = TinyColumnBuilder<AntDesign.Charts.TinyColumn>
    type TinyLine' = TinyLineBuilder<AntDesign.Charts.TinyLine>
    type Temp' = TempBuilder<AntDesign.Charts.Temp>
            