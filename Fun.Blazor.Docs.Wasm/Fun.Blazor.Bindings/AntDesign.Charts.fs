namespace rec AntDesign.Charts.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open AntDesign.Charts.DslInternals


type ChartComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = ChartComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, x) = attr.ref<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, x: 'TItem) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, x: 'TConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ColumnLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = ColumnLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, x) = attr.ref<AntDesign.Charts.ColumnLine<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, x: AntDesign.Charts.ColumnLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.ColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type DualLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = DualLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, x) = attr.ref<AntDesign.Charts.DualLine<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, x: AntDesign.Charts.DualLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.DualLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type GroupedColumnLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = GroupedColumnLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, x) = attr.ref<AntDesign.Charts.GroupedColumnLine<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, x: AntDesign.Charts.GroupedColumnLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.GroupedColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StackedColumnLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = StackedColumnLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, x) = attr.ref<AntDesign.Charts.StackedColumnLine<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, x: AntDesign.Charts.StackedColumnLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.StackedColumnLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type AreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = AreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, x) = attr.ref<AntDesign.Charts.Area<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, x: AntDesign.Charts.AreaConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Area<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = BarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, x) = attr.ref<AntDesign.Charts.Bar<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, x: AntDesign.Charts.BarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Bar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type BubbleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = BubbleBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, x) = attr.ref<AntDesign.Charts.Bubble<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, x: AntDesign.Charts.BubbleConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Bubble<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type BulletBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = BulletBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, x) = attr.ref<AntDesign.Charts.Bullet<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, x: AntDesign.Charts.BulletConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Bullet<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type CalendarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = CalendarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, x) = attr.ref<AntDesign.Charts.Calendar<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, x: AntDesign.Charts.CalendarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Calendar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = ColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, x) = attr.ref<AntDesign.Charts.Column<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, x: AntDesign.Charts.ColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Column<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type DensityHeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = DensityHeatmapBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, x) = attr.ref<AntDesign.Charts.DensityHeatmap<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, x: AntDesign.Charts.DensityHeatmapConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.DensityHeatmap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = DonutBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, x) = attr.ref<AntDesign.Charts.Donut<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, x: AntDesign.Charts.DonutConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Donut<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type FunnelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = FunnelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, x) = attr.ref<AntDesign.Charts.Funnel<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, x: AntDesign.Charts.FunnelConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Funnel<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type GaugeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = GaugeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, x) = attr.ref<AntDesign.Charts.Gauge<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, x: AntDesign.Charts.GaugeConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Gauge<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type GroupedBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = GroupedBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, x) = attr.ref<AntDesign.Charts.GroupedBar<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, x: AntDesign.Charts.GroupedBarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.GroupedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type GroupedColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = GroupedColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, x) = attr.ref<AntDesign.Charts.GroupedColumn<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, x: AntDesign.Charts.GroupedColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.GroupedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type HeatmapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = HeatmapBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, x) = attr.ref<AntDesign.Charts.Heatmap<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, x: AntDesign.Charts.HeatmapConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Heatmap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type HistogramBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = HistogramBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, x) = attr.ref<AntDesign.Charts.Histogram<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, x: AntDesign.Charts.HistogramConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Histogram<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = LineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, x) = attr.ref<AntDesign.Charts.Line<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, x: AntDesign.Charts.LineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Line<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type LiquidBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = LiquidBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, x) = attr.ref<AntDesign.Charts.Liquid<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, x: AntDesign.Charts.LiquidConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Liquid<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type PercentStackedAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = PercentStackedAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, x) = attr.ref<AntDesign.Charts.PercentStackedArea<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, x: AntDesign.Charts.PercentStackedAreaConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.PercentStackedArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type PercentStackedBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = PercentStackedBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, x) = attr.ref<AntDesign.Charts.PercentStackedBar<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, x: AntDesign.Charts.PercentStackedBarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.PercentStackedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type PercentStackedColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = PercentStackedColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, x) = attr.ref<AntDesign.Charts.PercentStackedColumn<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, x: AntDesign.Charts.PercentStackedColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.PercentStackedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = PieBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, x) = attr.ref<AntDesign.Charts.Pie<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, x: AntDesign.Charts.PieConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Pie<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RadarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = RadarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, x) = attr.ref<AntDesign.Charts.Radar<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, x: AntDesign.Charts.RadarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Radar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RangeBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = RangeBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, x) = attr.ref<AntDesign.Charts.RangeBar<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, x: AntDesign.Charts.RangeBarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.RangeBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RangeColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = RangeColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, x) = attr.ref<AntDesign.Charts.RangeColumn<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, x: AntDesign.Charts.RangeColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.RangeColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RoseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = RoseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, x) = attr.ref<AntDesign.Charts.Rose<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, x: AntDesign.Charts.RoseConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Rose<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ScatterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = ScatterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, x) = attr.ref<AntDesign.Charts.Scatter<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, x: AntDesign.Charts.ScatterConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Scatter<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StackedAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = StackedAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, x) = attr.ref<AntDesign.Charts.StackedArea<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, x: AntDesign.Charts.StackedAreaConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.StackedArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StackedBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = StackedBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, x) = attr.ref<AntDesign.Charts.StackedBar<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, x: AntDesign.Charts.StackedBarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.StackedBar<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StackedColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = StackedColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, x) = attr.ref<AntDesign.Charts.StackedColumn<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, x: AntDesign.Charts.StackedColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.StackedColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type StepLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = StepLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, x) = attr.ref<AntDesign.Charts.StepLine<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, x: AntDesign.Charts.StepLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.StepLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TreemapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = TreemapBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, x) = attr.ref<AntDesign.Charts.Treemap<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, x: AntDesign.Charts.ITreemapData<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, x: AntDesign.Charts.TreemapConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Treemap<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type WaterfallBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = WaterfallBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, x) = attr.ref<AntDesign.Charts.Waterfall<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, x: AntDesign.Charts.WaterfallConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Waterfall<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = ProgressBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, x) = attr.ref<AntDesign.Charts.Progress<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, x: System.Double) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, x: AntDesign.Charts.ProgressConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Progress<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RingProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = RingProgressBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.RingProgress>, x) = attr.ref<AntDesign.Charts.RingProgress> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.RingProgress>, x: System.Double) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.RingProgress>, x: AntDesign.Charts.RingProgressConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.RingProgress>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.RingProgress>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.RingProgress>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TinyAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = TinyAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, x) = attr.ref<AntDesign.Charts.TinyArea<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, x: AntDesign.Charts.TinyAreaConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.TinyArea<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TinyColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = TinyColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, x) = attr.ref<AntDesign.Charts.TinyColumn<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, x: AntDesign.Charts.TinyColumnConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.TinyColumn<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TinyLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = TinyLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, x) = attr.ref<AntDesign.Charts.TinyLine<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, x: AntDesign.Charts.TinyLineConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.TinyLine<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TempBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = TempBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, x) = attr.ref<AntDesign.Charts.Temp<'TItem>> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, x: 'TItem) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, x: AntDesign.Charts.BarConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("otherConfig")>] member this.otherConfig (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, x: System.Object) = "OtherConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateAfter")>] member this.onCreateAfter (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.IChartComponent> "OnCreateAfter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.Charts.Temp<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Charts.ChartEvent> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                
            

// =======================================================================================================================

namespace AntDesign.Charts

[<AutoOpen>]
module DslCE =

    open AntDesign.Charts.DslInternals

    type chartComponentBase<'TItem, 'TConfig when 'TConfig : not struct and 'TConfig : (new : unit -> 'TConfig)> = ChartComponentBaseBuilder<AntDesign.Charts.ChartComponentBase<'TItem, 'TConfig>>
    type columnLine<'TItem> = ColumnLineBuilder<AntDesign.Charts.ColumnLine<'TItem>>
    type dualLine<'TItem> = DualLineBuilder<AntDesign.Charts.DualLine<'TItem>>
    type groupedColumnLine<'TItem> = GroupedColumnLineBuilder<AntDesign.Charts.GroupedColumnLine<'TItem>>
    type stackedColumnLine<'TItem> = StackedColumnLineBuilder<AntDesign.Charts.StackedColumnLine<'TItem>>
    type area<'TItem> = AreaBuilder<AntDesign.Charts.Area<'TItem>>
    type bar<'TItem> = BarBuilder<AntDesign.Charts.Bar<'TItem>>
    type bubble<'TItem> = BubbleBuilder<AntDesign.Charts.Bubble<'TItem>>
    type bullet<'TItem> = BulletBuilder<AntDesign.Charts.Bullet<'TItem>>
    type calendar<'TItem> = CalendarBuilder<AntDesign.Charts.Calendar<'TItem>>
    type column<'TItem> = ColumnBuilder<AntDesign.Charts.Column<'TItem>>
    type densityHeatmap<'TItem> = DensityHeatmapBuilder<AntDesign.Charts.DensityHeatmap<'TItem>>
    type donut<'TItem> = DonutBuilder<AntDesign.Charts.Donut<'TItem>>
    type funnel<'TItem> = FunnelBuilder<AntDesign.Charts.Funnel<'TItem>>
    type gauge<'TItem> = GaugeBuilder<AntDesign.Charts.Gauge<'TItem>>
    type groupedBar<'TItem> = GroupedBarBuilder<AntDesign.Charts.GroupedBar<'TItem>>
    type groupedColumn<'TItem> = GroupedColumnBuilder<AntDesign.Charts.GroupedColumn<'TItem>>
    type heatmap<'TItem> = HeatmapBuilder<AntDesign.Charts.Heatmap<'TItem>>
    type histogram<'TItem> = HistogramBuilder<AntDesign.Charts.Histogram<'TItem>>
    type line<'TItem> = LineBuilder<AntDesign.Charts.Line<'TItem>>
    type liquid<'TItem> = LiquidBuilder<AntDesign.Charts.Liquid<'TItem>>
    type percentStackedArea<'TItem> = PercentStackedAreaBuilder<AntDesign.Charts.PercentStackedArea<'TItem>>
    type percentStackedBar<'TItem> = PercentStackedBarBuilder<AntDesign.Charts.PercentStackedBar<'TItem>>
    type percentStackedColumn<'TItem> = PercentStackedColumnBuilder<AntDesign.Charts.PercentStackedColumn<'TItem>>
    type pie<'TItem> = PieBuilder<AntDesign.Charts.Pie<'TItem>>
    type radar<'TItem> = RadarBuilder<AntDesign.Charts.Radar<'TItem>>
    type rangeBar<'TItem> = RangeBarBuilder<AntDesign.Charts.RangeBar<'TItem>>
    type rangeColumn<'TItem> = RangeColumnBuilder<AntDesign.Charts.RangeColumn<'TItem>>
    type rose<'TItem> = RoseBuilder<AntDesign.Charts.Rose<'TItem>>
    type scatter<'TItem> = ScatterBuilder<AntDesign.Charts.Scatter<'TItem>>
    type stackedArea<'TItem> = StackedAreaBuilder<AntDesign.Charts.StackedArea<'TItem>>
    type stackedBar<'TItem> = StackedBarBuilder<AntDesign.Charts.StackedBar<'TItem>>
    type stackedColumn<'TItem> = StackedColumnBuilder<AntDesign.Charts.StackedColumn<'TItem>>
    type stepLine<'TItem> = StepLineBuilder<AntDesign.Charts.StepLine<'TItem>>
    type treemap<'TItem> = TreemapBuilder<AntDesign.Charts.Treemap<'TItem>>
    type waterfall<'TItem> = WaterfallBuilder<AntDesign.Charts.Waterfall<'TItem>>
    type progress<'TItem> = ProgressBuilder<AntDesign.Charts.Progress<'TItem>>
    type ringProgress = RingProgressBuilder<AntDesign.Charts.RingProgress>
    type tinyArea<'TItem> = TinyAreaBuilder<AntDesign.Charts.TinyArea<'TItem>>
    type tinyColumn<'TItem> = TinyColumnBuilder<AntDesign.Charts.TinyColumn<'TItem>>
    type tinyLine<'TItem> = TinyLineBuilder<AntDesign.Charts.TinyLine<'TItem>>
    type temp<'TItem> = TempBuilder<AntDesign.Charts.Temp<'TItem>>
            