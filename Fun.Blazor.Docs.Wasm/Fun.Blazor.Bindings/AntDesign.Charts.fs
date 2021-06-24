namespace rec AntDesign.Charts.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open AntDesign.Charts.DslInternals


type chartComponentBase<'FunBlazorGeneric, 'TItem, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig)> =
    
    static member inline create () = [] |> html.blazor<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>

    static member inline ref x = attr.ref<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: 'TItem) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: 'TConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type columnLine<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.ColumnLineConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.ColumnLine<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.ColumnLine<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.ColumnLine<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.ColumnLineConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type dualLine<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.DualLineConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.DualLine<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.DualLine<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.DualLine<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.DualLineConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type groupedColumnLine<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.GroupedColumnLineConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.GroupedColumnLine<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.GroupedColumnLine<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.GroupedColumnLine<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.GroupedColumnLineConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type stackedColumnLine<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StackedColumnLineConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.StackedColumnLine<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.StackedColumnLine<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.StackedColumnLine<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.StackedColumnLineConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type area<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.AreaConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Area<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Area<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Area<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.AreaConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type bar<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.BarConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Bar<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Bar<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Bar<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.BarConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type bubble<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.BubbleConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Bubble<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Bubble<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Bubble<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.BubbleConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type bullet<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.BulletConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Bullet<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Bullet<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Bullet<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.BulletConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type calendar<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.CalendarConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Calendar<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Calendar<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Calendar<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.CalendarConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type column<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.ColumnConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Column<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Column<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Column<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.ColumnConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type densityHeatmap<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.DensityHeatmapConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.DensityHeatmap<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.DensityHeatmap<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.DensityHeatmap<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.DensityHeatmapConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type donut<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.DonutConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Donut<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Donut<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Donut<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.DonutConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type funnel<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.FunnelConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Funnel<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Funnel<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Funnel<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.FunnelConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type gauge<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.GaugeConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Gauge<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Gauge<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Gauge<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.GaugeConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type groupedBar<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.GroupedBarConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.GroupedBar<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.GroupedBar<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.GroupedBar<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.GroupedBarConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type groupedColumn<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.GroupedColumnConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.GroupedColumn<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.GroupedColumn<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.GroupedColumn<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.GroupedColumnConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type heatmap<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.HeatmapConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Heatmap<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Heatmap<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Heatmap<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.HeatmapConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type histogram<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.HistogramConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Histogram<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Histogram<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Histogram<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.HistogramConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type line<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.LineConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Line<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Line<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Line<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.LineConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type liquid<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.LiquidConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Liquid<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Liquid<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Liquid<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.LiquidConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type percentStackedArea<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.PercentStackedAreaConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.PercentStackedArea<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.PercentStackedArea<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.PercentStackedArea<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.PercentStackedAreaConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type percentStackedBar<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.PercentStackedBarConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.PercentStackedBar<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.PercentStackedBar<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.PercentStackedBar<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.PercentStackedBarConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type percentStackedColumn<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.PercentStackedColumnConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.PercentStackedColumn<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.PercentStackedColumn<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.PercentStackedColumn<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.PercentStackedColumnConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type pie<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.PieConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Pie<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Pie<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Pie<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.PieConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type radar<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.RadarConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Radar<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Radar<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Radar<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.RadarConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type rangeBar<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.RangeBarConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.RangeBar<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.RangeBar<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.RangeBar<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.RangeBarConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type rangeColumn<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.RangeColumnConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.RangeColumn<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.RangeColumn<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.RangeColumn<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.RangeColumnConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type rose<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.RoseConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Rose<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Rose<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Rose<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.RoseConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type scatter<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.ScatterConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Scatter<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Scatter<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Scatter<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.ScatterConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type stackedArea<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StackedAreaConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.StackedArea<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.StackedArea<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.StackedArea<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.StackedAreaConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type stackedBar<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StackedBarConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.StackedBar<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.StackedBar<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.StackedBar<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.StackedBarConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type stackedColumn<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StackedColumnConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.StackedColumn<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.StackedColumn<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.StackedColumn<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.StackedColumnConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type stepLine<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.StepLineConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.StepLine<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.StepLine<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.StepLine<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.StepLineConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type treemap<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, AntDesign.Charts.ITreemapData<'TItem>, AntDesign.Charts.TreemapConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Treemap<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Treemap<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Treemap<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: AntDesign.Charts.ITreemapData<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.TreemapConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type waterfall<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.WaterfallConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Waterfall<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Waterfall<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Waterfall<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.WaterfallConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type progress<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Double, AntDesign.Charts.ProgressConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Progress<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Progress<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Progress<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Double) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.ProgressConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type ringProgress<'FunBlazorGeneric> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Double, AntDesign.Charts.RingProgressConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.RingProgress>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.RingProgress>

    static member inline ref x = attr.ref<AntDesign.Charts.RingProgress> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Double) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.RingProgressConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type tinyArea<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.TinyAreaConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.TinyArea<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.TinyArea<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.TinyArea<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.TinyAreaConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type tinyColumn<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.TinyColumnConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.TinyColumn<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.TinyColumn<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.TinyColumn<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.TinyColumnConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type tinyLine<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, System.Collections.Generic.IEnumerable<'TItem>, AntDesign.Charts.TinyLineConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.TinyLine<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.TinyLine<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.TinyLine<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.TinyLineConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type temp<'FunBlazorGeneric, 'TItem> =
    inherit chartComponentBase<'FunBlazorGeneric, 'TItem, AntDesign.Charts.BarConfig>
    static member inline create () = [] |> html.blazor<AntDesign.Charts.Temp<'TItem>>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<AntDesign.Charts.Temp<'TItem>>

    static member inline ref x = attr.ref<AntDesign.Charts.Temp<'TItem>> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline data (x: 'TItem) = "Data" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline config (x: AntDesign.Charts.BarConfig) = "Config" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline otherConfig (x: System.Object) = "OtherConfig" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onCreateAfter fn = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline onTitleClick fn = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            

// =======================================================================================================================

namespace AntDesign.Charts

open AntDesign.Charts.DslInternals


type IChartComponentBaseNode<'TItem, 'TConfig> = interface end
type chartComponentBase<'TItem, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig)> =
    class
        inherit chartComponentBase<IChartComponentBaseNode<'TItem, 'TConfig>, 'TItem, 'TConfig>
    end
                    

type IColumnLineNode<'TItem> = interface end
type columnLine<'TItem> =
    class
        inherit columnLine<IColumnLineNode<'TItem>, 'TItem>
    end
                    

type IDualLineNode<'TItem> = interface end
type dualLine<'TItem> =
    class
        inherit dualLine<IDualLineNode<'TItem>, 'TItem>
    end
                    

type IGroupedColumnLineNode<'TItem> = interface end
type groupedColumnLine<'TItem> =
    class
        inherit groupedColumnLine<IGroupedColumnLineNode<'TItem>, 'TItem>
    end
                    

type IStackedColumnLineNode<'TItem> = interface end
type stackedColumnLine<'TItem> =
    class
        inherit stackedColumnLine<IStackedColumnLineNode<'TItem>, 'TItem>
    end
                    

type IAreaNode<'TItem> = interface end
type area<'TItem> =
    class
        inherit area<IAreaNode<'TItem>, 'TItem>
    end
                    

type IBarNode<'TItem> = interface end
type bar<'TItem> =
    class
        inherit bar<IBarNode<'TItem>, 'TItem>
    end
                    

type IBubbleNode<'TItem> = interface end
type bubble<'TItem> =
    class
        inherit bubble<IBubbleNode<'TItem>, 'TItem>
    end
                    

type IBulletNode<'TItem> = interface end
type bullet<'TItem> =
    class
        inherit bullet<IBulletNode<'TItem>, 'TItem>
    end
                    

type ICalendarNode<'TItem> = interface end
type calendar<'TItem> =
    class
        inherit calendar<ICalendarNode<'TItem>, 'TItem>
    end
                    

type IColumnNode<'TItem> = interface end
type column<'TItem> =
    class
        inherit column<IColumnNode<'TItem>, 'TItem>
    end
                    

type IDensityHeatmapNode<'TItem> = interface end
type densityHeatmap<'TItem> =
    class
        inherit densityHeatmap<IDensityHeatmapNode<'TItem>, 'TItem>
    end
                    

type IDonutNode<'TItem> = interface end
type donut<'TItem> =
    class
        inherit donut<IDonutNode<'TItem>, 'TItem>
    end
                    

type IFunnelNode<'TItem> = interface end
type funnel<'TItem> =
    class
        inherit funnel<IFunnelNode<'TItem>, 'TItem>
    end
                    

type IGaugeNode<'TItem> = interface end
type gauge<'TItem> =
    class
        inherit gauge<IGaugeNode<'TItem>, 'TItem>
    end
                    

type IGroupedBarNode<'TItem> = interface end
type groupedBar<'TItem> =
    class
        inherit groupedBar<IGroupedBarNode<'TItem>, 'TItem>
    end
                    

type IGroupedColumnNode<'TItem> = interface end
type groupedColumn<'TItem> =
    class
        inherit groupedColumn<IGroupedColumnNode<'TItem>, 'TItem>
    end
                    

type IHeatmapNode<'TItem> = interface end
type heatmap<'TItem> =
    class
        inherit heatmap<IHeatmapNode<'TItem>, 'TItem>
    end
                    

type IHistogramNode<'TItem> = interface end
type histogram<'TItem> =
    class
        inherit histogram<IHistogramNode<'TItem>, 'TItem>
    end
                    

type ILineNode<'TItem> = interface end
type line<'TItem> =
    class
        inherit line<ILineNode<'TItem>, 'TItem>
    end
                    

type ILiquidNode<'TItem> = interface end
type liquid<'TItem> =
    class
        inherit liquid<ILiquidNode<'TItem>, 'TItem>
    end
                    

type IPercentStackedAreaNode<'TItem> = interface end
type percentStackedArea<'TItem> =
    class
        inherit percentStackedArea<IPercentStackedAreaNode<'TItem>, 'TItem>
    end
                    

type IPercentStackedBarNode<'TItem> = interface end
type percentStackedBar<'TItem> =
    class
        inherit percentStackedBar<IPercentStackedBarNode<'TItem>, 'TItem>
    end
                    

type IPercentStackedColumnNode<'TItem> = interface end
type percentStackedColumn<'TItem> =
    class
        inherit percentStackedColumn<IPercentStackedColumnNode<'TItem>, 'TItem>
    end
                    

type IPieNode<'TItem> = interface end
type pie<'TItem> =
    class
        inherit pie<IPieNode<'TItem>, 'TItem>
    end
                    

type IRadarNode<'TItem> = interface end
type radar<'TItem> =
    class
        inherit radar<IRadarNode<'TItem>, 'TItem>
    end
                    

type IRangeBarNode<'TItem> = interface end
type rangeBar<'TItem> =
    class
        inherit rangeBar<IRangeBarNode<'TItem>, 'TItem>
    end
                    

type IRangeColumnNode<'TItem> = interface end
type rangeColumn<'TItem> =
    class
        inherit rangeColumn<IRangeColumnNode<'TItem>, 'TItem>
    end
                    

type IRoseNode<'TItem> = interface end
type rose<'TItem> =
    class
        inherit rose<IRoseNode<'TItem>, 'TItem>
    end
                    

type IScatterNode<'TItem> = interface end
type scatter<'TItem> =
    class
        inherit scatter<IScatterNode<'TItem>, 'TItem>
    end
                    

type IStackedAreaNode<'TItem> = interface end
type stackedArea<'TItem> =
    class
        inherit stackedArea<IStackedAreaNode<'TItem>, 'TItem>
    end
                    

type IStackedBarNode<'TItem> = interface end
type stackedBar<'TItem> =
    class
        inherit stackedBar<IStackedBarNode<'TItem>, 'TItem>
    end
                    

type IStackedColumnNode<'TItem> = interface end
type stackedColumn<'TItem> =
    class
        inherit stackedColumn<IStackedColumnNode<'TItem>, 'TItem>
    end
                    

type IStepLineNode<'TItem> = interface end
type stepLine<'TItem> =
    class
        inherit stepLine<IStepLineNode<'TItem>, 'TItem>
    end
                    

type ITreemapNode<'TItem> = interface end
type treemap<'TItem> =
    class
        inherit treemap<ITreemapNode<'TItem>, 'TItem>
    end
                    

type IWaterfallNode<'TItem> = interface end
type waterfall<'TItem> =
    class
        inherit waterfall<IWaterfallNode<'TItem>, 'TItem>
    end
                    

type IProgressNode<'TItem> = interface end
type progress<'TItem> =
    class
        inherit progress<IProgressNode<'TItem>, 'TItem>
    end
                    

type IRingProgressNode = interface end
type ringProgress =
    class
        inherit ringProgress<IRingProgressNode>
    end
                    

type ITinyAreaNode<'TItem> = interface end
type tinyArea<'TItem> =
    class
        inherit tinyArea<ITinyAreaNode<'TItem>, 'TItem>
    end
                    

type ITinyColumnNode<'TItem> = interface end
type tinyColumn<'TItem> =
    class
        inherit tinyColumn<ITinyColumnNode<'TItem>, 'TItem>
    end
                    

type ITinyLineNode<'TItem> = interface end
type tinyLine<'TItem> =
    class
        inherit tinyLine<ITinyLineNode<'TItem>, 'TItem>
    end
                    

type ITempNode<'TItem> = interface end
type temp<'TItem> =
    class
        inherit temp<ITempNode<'TItem>, 'TItem>
    end
                    
            