namespace rec Blazor.Diagrams.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Blazor.Diagrams.DslInternals

type DiagramCanvasBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Widgets")>] member inline _.Widgets ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Widgets", fragment)
    [<CustomOperation("Widgets")>] member inline _.Widgets ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Widgets", fragment { yield! fragments })
    [<CustomOperation("Widgets")>] member inline _.Widgets ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Widgets", html.text x)
    [<CustomOperation("Widgets")>] member inline _.Widgets ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Widgets", html.text x)
    [<CustomOperation("Widgets")>] member inline _.Widgets ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Widgets", html.text x)
    [<CustomOperation("AdditionalSvg")>] member inline _.AdditionalSvg ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("AdditionalSvg", fragment)
    [<CustomOperation("AdditionalSvg")>] member inline _.AdditionalSvg ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("AdditionalSvg", fragment { yield! fragments })
    [<CustomOperation("AdditionalSvg")>] member inline _.AdditionalSvg ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AdditionalSvg", html.text x)
    [<CustomOperation("AdditionalSvg")>] member inline _.AdditionalSvg ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AdditionalSvg", html.text x)
    [<CustomOperation("AdditionalSvg")>] member inline _.AdditionalSvg ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AdditionalSvg", html.text x)
    [<CustomOperation("AdditionalHtml")>] member inline _.AdditionalHtml ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("AdditionalHtml", fragment)
    [<CustomOperation("AdditionalHtml")>] member inline _.AdditionalHtml ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("AdditionalHtml", fragment { yield! fragments })
    [<CustomOperation("AdditionalHtml")>] member inline _.AdditionalHtml ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("AdditionalHtml", html.text x)
    [<CustomOperation("AdditionalHtml")>] member inline _.AdditionalHtml ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("AdditionalHtml", html.text x)
    [<CustomOperation("AdditionalHtml")>] member inline _.AdditionalHtml ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("AdditionalHtml", html.text x)

type LinkWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Link")>] member inline _.Link ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.LinkModel) = render ==> ("Link" => x)

type DefaultGroupWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.GroupModel) = render ==> ("Group" => x)

type DefaultLinkLabelWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.LinkLabelModel) = render ==> ("Label" => x)

type GroupNodesBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.GroupModel) = render ==> ("Group" => x)

type NodeWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Node")>] member inline _.Node ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.NodeModel) = render ==> ("Node" => x)

type SvgNodeWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Node")>] member inline _.Node ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.NodeModel) = render ==> ("Node" => x)

            
namespace rec Blazor.Diagrams.DslInternals.Widgets

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Blazor.Diagrams.DslInternals

type GridWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Size")>] member inline _.Size ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Size" => x)
    [<CustomOperation("ZoomThreshold")>] member inline _.ZoomThreshold ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("ZoomThreshold" => x)
    [<CustomOperation("Mode")>] member inline _.Mode ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Components.Widgets.GridMode) = render ==> ("Mode" => x)
    [<CustomOperation("BackgroundColor")>] member inline _.BackgroundColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("BackgroundColor" => x)

type NavigatorWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("UseNodeShape")>] member inline _.UseNodeShape ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("UseNodeShape" =>>> true)
    [<CustomOperation("UseNodeShape")>] member inline _.UseNodeShape ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("UseNodeShape" =>>> x)
    [<CustomOperation("Width")>] member inline _.Width ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Width" => x)
    [<CustomOperation("Height")>] member inline _.Height ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Height" => x)
    [<CustomOperation("Margin")>] member inline _.Margin ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Double) = render ==> ("Margin" => x)
    [<CustomOperation("NodeColor")>] member inline _.NodeColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("NodeColor" => x)
    [<CustomOperation("GroupColor")>] member inline _.GroupColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("GroupColor" => x)
    [<CustomOperation("ViewStrokeColor")>] member inline _.ViewStrokeColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("ViewStrokeColor" => x)
    [<CustomOperation("ViewStrokeWidth")>] member inline _.ViewStrokeWidth ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Int32) = render ==> ("ViewStrokeWidth" => x)

type SelectionBoxWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Background")>] member inline _.Background ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Background" => x)

            
namespace rec Blazor.Diagrams.DslInternals.Renderers

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Blazor.Diagrams.DslInternals

type GroupRendererBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Group")>] member inline _.Group ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.GroupModel) = render ==> ("Group" => x)

type LinkLabelRendererBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Label")>] member inline _.Label ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.LinkLabelModel) = render ==> ("Label" => x)
    [<CustomOperation("Path")>] member inline _.Path ([<InlineIfLambda>] render: AttrRenderFragment, x: SvgPathProperties.SvgPath) = render ==> ("Path" => x)

type LinkRendererBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Link")>] member inline _.Link ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.Base.BaseLinkModel) = render ==> ("Link" => x)

type LinkVertexRendererBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Vertex")>] member inline _.Vertex ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.LinkVertexModel) = render ==> ("Vertex" => x)
    [<CustomOperation("Color")>] member inline _.Color ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Color" => x)
    [<CustomOperation("SelectedColor")>] member inline _.SelectedColor ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("SelectedColor" => x)

type NodeRendererBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Node")>] member inline _.Node ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.NodeModel) = render ==> ("Node" => x)

type PortRendererBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Port")>] member inline _.Port ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.PortModel) = render ==> ("Port" => x)

            
namespace rec Blazor.Diagrams.DslInternals.Controls

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Blazor.Diagrams.DslInternals

type ControlsLayerRendererBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Svg")>] member inline _.Svg ([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("Svg" =>>> true)
    [<CustomOperation("Svg")>] member inline _.Svg ([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Svg" =>>> x)

type ArrowHeadControlWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Control")>] member inline _.Control ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Controls.Default.ArrowHeadControl) = render ==> ("Control" => x)
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.Base.BaseLinkModel) = render ==> ("Model" => x)

type BoundaryControlWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Control")>] member inline _.Control ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Controls.Default.BoundaryControl) = render ==> ("Control" => x)
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.Base.Model) = render ==> ("Model" => x)

type DragNewLinkControlWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Control")>] member inline _.Control ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Controls.Default.DragNewLinkControl) = render ==> ("Control" => x)
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.Base.Model) = render ==> ("Model" => x)

type RemoveControlWidgetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Control")>] member inline _.Control ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Controls.Default.RemoveControl) = render ==> ("Control" => x)
    [<CustomOperation("Model")>] member inline _.Model ([<InlineIfLambda>] render: AttrRenderFragment, x: Blazor.Diagrams.Core.Models.Base.Model) = render ==> ("Model" => x)

            

// =======================================================================================================================

namespace Blazor.Diagrams

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Blazor.Diagrams.DslInternals

    type DiagramCanvas' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.DiagramCanvas>)>] () = inherit DiagramCanvasBuilder<Blazor.Diagrams.Components.DiagramCanvas>()
    type LinkWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.LinkWidget>)>] () = inherit LinkWidgetBuilder<Blazor.Diagrams.Components.LinkWidget>()
    type DefaultGroupWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.DefaultGroupWidget>)>] () = inherit DefaultGroupWidgetBuilder<Blazor.Diagrams.Components.DefaultGroupWidget>()
    type DefaultLinkLabelWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.DefaultLinkLabelWidget>)>] () = inherit DefaultLinkLabelWidgetBuilder<Blazor.Diagrams.Components.DefaultLinkLabelWidget>()
    type GroupNodes' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.GroupNodes>)>] () = inherit GroupNodesBuilder<Blazor.Diagrams.Components.GroupNodes>()
    type NodeWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.NodeWidget>)>] () = inherit NodeWidgetBuilder<Blazor.Diagrams.Components.NodeWidget>()
    type SvgNodeWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.SvgNodeWidget>)>] () = inherit SvgNodeWidgetBuilder<Blazor.Diagrams.Components.SvgNodeWidget>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Blazor.Diagrams.DslInternals

    let DiagramCanvas'' = DiagramCanvas'()
    let LinkWidget'' = LinkWidget'()
    let DefaultGroupWidget'' = DefaultGroupWidget'()
    let DefaultLinkLabelWidget'' = DefaultLinkLabelWidget'()
    let GroupNodes'' = GroupNodes'()
    let NodeWidget'' = NodeWidget'()
    let SvgNodeWidget'' = SvgNodeWidget'()
            
namespace Blazor.Diagrams.Widgets

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Blazor.Diagrams.DslInternals.Widgets

    type GridWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Widgets.GridWidget>)>] () = inherit GridWidgetBuilder<Blazor.Diagrams.Components.Widgets.GridWidget>()
    type NavigatorWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Widgets.NavigatorWidget>)>] () = inherit NavigatorWidgetBuilder<Blazor.Diagrams.Components.Widgets.NavigatorWidget>()
    type SelectionBoxWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Widgets.SelectionBoxWidget>)>] () = inherit SelectionBoxWidgetBuilder<Blazor.Diagrams.Components.Widgets.SelectionBoxWidget>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Blazor.Diagrams.DslInternals.Widgets

    let GridWidget'' = GridWidget'()
    let NavigatorWidget'' = NavigatorWidget'()
    let SelectionBoxWidget'' = SelectionBoxWidget'()
            
namespace Blazor.Diagrams.Renderers

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Blazor.Diagrams.DslInternals.Renderers

    type GroupRenderer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Renderers.GroupRenderer>)>] () = inherit GroupRendererBuilder<Blazor.Diagrams.Components.Renderers.GroupRenderer>()
    type LinkLabelRenderer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Renderers.LinkLabelRenderer>)>] () = inherit LinkLabelRendererBuilder<Blazor.Diagrams.Components.Renderers.LinkLabelRenderer>()
    type LinkRenderer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Renderers.LinkRenderer>)>] () = inherit LinkRendererBuilder<Blazor.Diagrams.Components.Renderers.LinkRenderer>()
    type LinkVertexRenderer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Renderers.LinkVertexRenderer>)>] () = inherit LinkVertexRendererBuilder<Blazor.Diagrams.Components.Renderers.LinkVertexRenderer>()
    type NodeRenderer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Renderers.NodeRenderer>)>] () = inherit NodeRendererBuilder<Blazor.Diagrams.Components.Renderers.NodeRenderer>()
    type PortRenderer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Renderers.PortRenderer>)>] () = inherit PortRendererBuilder<Blazor.Diagrams.Components.Renderers.PortRenderer>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Blazor.Diagrams.DslInternals.Renderers

    let GroupRenderer'' = GroupRenderer'()
    let LinkLabelRenderer'' = LinkLabelRenderer'()
    let LinkRenderer'' = LinkRenderer'()
    let LinkVertexRenderer'' = LinkVertexRenderer'()
    let NodeRenderer'' = NodeRenderer'()
    let PortRenderer'' = PortRenderer'()
            
namespace Blazor.Diagrams.Controls

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Blazor.Diagrams.DslInternals.Controls

    type ControlsLayerRenderer' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Controls.ControlsLayerRenderer>)>] () = inherit ControlsLayerRendererBuilder<Blazor.Diagrams.Components.Controls.ControlsLayerRenderer>()
    type ArrowHeadControlWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Controls.ArrowHeadControlWidget>)>] () = inherit ArrowHeadControlWidgetBuilder<Blazor.Diagrams.Components.Controls.ArrowHeadControlWidget>()
    type BoundaryControlWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Controls.BoundaryControlWidget>)>] () = inherit BoundaryControlWidgetBuilder<Blazor.Diagrams.Components.Controls.BoundaryControlWidget>()
    type DragNewLinkControlWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Controls.DragNewLinkControlWidget>)>] () = inherit DragNewLinkControlWidgetBuilder<Blazor.Diagrams.Components.Controls.DragNewLinkControlWidget>()
    type RemoveControlWidget' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Blazor.Diagrams.Components.Controls.RemoveControlWidget>)>] () = inherit RemoveControlWidgetBuilder<Blazor.Diagrams.Components.Controls.RemoveControlWidget>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Blazor.Diagrams.DslInternals.Controls

    let ControlsLayerRenderer'' = ControlsLayerRenderer'()
    let ArrowHeadControlWidget'' = ArrowHeadControlWidget'()
    let BoundaryControlWidget'' = BoundaryControlWidget'()
    let DragNewLinkControlWidget'' = DragNewLinkControlWidget'()
    let RemoveControlWidget'' = RemoveControlWidget'()
            