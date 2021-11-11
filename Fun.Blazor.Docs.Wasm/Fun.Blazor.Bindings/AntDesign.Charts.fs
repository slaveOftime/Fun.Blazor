namespace rec AntDesign.Charts.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.Charts.DslInternals


type ChartComponentBaseBuilder<'FunBlazorGeneric, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig) and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ChartComponentBaseBuilder<'FunBlazorGeneric, 'TConfig>() :> IFunBlazorNode
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("JsonConfig")>] member this.JsonConfig (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "JsonConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("JsConfig")>] member this.JsConfig (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "JsConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OtherConfig")>] member this.OtherConfig (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateAfter")>] member this.OnCreateAfter (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFirstRender")>] member this.OnFirstRender (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnFirstRender" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type AreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.AreaConfig>()
    static member create () = AreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BarConfig>()
    static member create () = BarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type BulletBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BulletConfig>()
    static member create () = BulletBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type ColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ColumnConfig>()
    static member create () = ColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type DensityHeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.DensityHeatmapConfig>()
    static member create () = DensityHeatmapBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type DualAxesBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.DualAxesConfig>()
    static member create () = DualAxesBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type FunnelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.FunnelConfig>()
    static member create () = FunnelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type GaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.GaugeConfig>()
    static member create () = GaugeBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type HeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.HeatmapConfig>()
    static member create () = HeatmapBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type HistogramBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.HistogramConfig>()
    static member create () = HistogramBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.LineConfig>()
    static member create () = LineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type LiquidBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.LiquidConfig>()
    static member create () = LiquidBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.PieConfig>()
    static member create () = PieBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type RadarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RadarConfig>()
    static member create () = RadarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type RoseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RoseConfig>()
    static member create () = RoseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type ScatterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ScatterConfig>()
    static member create () = ScatterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TreemapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TreemapConfig>()
    static member create () = TreemapBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type WaterfallBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.WaterfallConfig>()
    static member create () = WaterfallBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.ProgressConfig>()
    static member create () = ProgressBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type RingProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.RingProgressConfig>()
    static member create () = RingProgressBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TinyAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyAreaConfig>()
    static member create () = TinyAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TinyColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyColumnConfig>()
    static member create () = TinyColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TinyLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.TinyLineConfig>()
    static member create () = TinyLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TempBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ChartComponentBaseBuilder<'FunBlazorGeneric, AntDesign.Charts.BarConfig>()
    static member create () = TempBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                
            

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
            