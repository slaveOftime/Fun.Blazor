namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators


type ComponentBuilder<'T when 'T :> Microsoft.AspNetCore.Components.IComponent>() =
    
    interface IComponentBuilder<'T>


    member inline _.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )

    
    member inline _.Yield(_: unit) = emptyAttr

    member inline _.Yield([<InlineIfLambda>] x: AttrRenderFragment) = x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> AttrRenderFragment) = fn ()

    member inline _.Combine
        (
            [<InlineIfLambda>] render1: AttrRenderFragment,
            [<InlineIfLambda>] render2: AttrRenderFragment
        )
        =
        render1 ==> render2

    member inline _.For
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] fn: unit -> AttrRenderFragment
        )
        =
        render ==> (fn ())

    member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> AttrRenderFragment) =
        renders |> Seq.map fn |> Seq.fold (==>) (emptyAttr)


    member inline _.Zero() = emptyAttr


    /// key for blazor
    [<CustomOperation("key")>]
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, k) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
            index
        )

    [<CustomOperation("ref")>]
    member inline _.ref
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] fn: ElementReference -> unit
        )
        =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, fn)
            index + 1
        )

    [<CustomOperation("callback")>]
    member inline _.callback
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            eventName,
            [<InlineIfLambda>] callback: 'T -> unit
        )
        =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action<'T> callback))
            index + 1
        )

    [<CustomOperation("callback")>]
    member inline _.callback
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            eventName,
            [<InlineIfLambda>] callback: 'T -> Task
        )
        =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<'T, Task> callback))
            index + 1
        )

    [<CustomOperation("preventDefault")>]
    member inline _.preventDefault([<InlineIfLambda>] render: AttrRenderFragment, eventName, value) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddEventPreventDefaultAttribute(index, eventName, value)
            index + 1
        )

    [<CustomOperation("stopPropagation")>]
    member inline _.stopPropagation([<InlineIfLambda>] render: AttrRenderFragment, eventName, value) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddEventPreventDefaultAttribute(index, eventName, value)
            index + 1
        )


type ComponentWithChildBuilder<'T when 'T :> IComponent>() =
    inherit ComponentBuilder<'T>()
    

    member inline _.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            builder.AddAttribute(
                index + 1,
                "ChildContent",
                RenderFragment(fun tb -> render.Invoke(comp, tb, 0) |> ignore)
            )
            builder.CloseComponent()
            index + 2
        )

    /// We should handle this because in Blazor, component need an Attribute called ChildContent for its child elements or components.
    /// So we cannot merge AttrRenderFragment and NodeRenderFragment directly.
    /// Instead, we should first invoke AttrRenderFragment then add ChildContent RenderFragment as attribute and switch builder context.
    /// Other method like Delay, For, Combine should also have appropriate implementation to seperate Attr and Node so we can Invoke them standalone.
    member inline _.Run(renders: AttrRenderFragment * NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            let render1, render2 = renders
            let mutable nextIndex = index
            builder.OpenComponent<'T>(index)
            nextIndex <- render1.Invoke(comp, builder, index + 1)
            builder.AddAttribute(
                nextIndex,
                "ChildContent",
                RenderFragment(fun tb -> render2.Invoke(comp, tb, 0) |> ignore)
            )
            builder.CloseComponent()
            nextIndex + 1
        )


    member inline _.Yield(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield<'Elt when 'Elt :> IEltBuilder>(x: 'Elt) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield<'Comp, 'T1 when 'Comp :> IComponentBuilder<'T1>>(_: 'Comp) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T1>(index)
            builder.CloseComponent()
            index + 1
        )

    member inline _.Yield([<InlineIfLambda>] x: NodeRenderFragment) = x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = fn ()

    /// We should only allow merge AttrRenderFragment with NodeRenderFragment.
    /// Instead of merge NodeRenderFragment with AttrRenderFragment because blazor only allow add attribute then child.
    /// Also it is clear for the DSL
    member inline _.Combine
        (
            [<InlineIfLambda>] render1: AttrRenderFragment,
            [<InlineIfLambda>] render2: NodeRenderFragment
        )
        =
        render1, render2

    member inline _.Combine
        (
            [<InlineIfLambda>] render1: NodeRenderFragment,
            [<InlineIfLambda>] render2: NodeRenderFragment
        )
        =
        render1 >=> render2

    member inline _.For
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] fn: unit -> NodeRenderFragment
        )
        =
        render, (fn ())

    member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) =
        renders |> Seq.map fn |> Seq.fold (>=>) (emptyNode)

    member inline _.YieldFrom(renders: NodeRenderFragment seq) =
        renders |> Seq.fold (>=>) (emptyNode)

    member inline _.Zero() = emptyNode


    [<CustomOperation("childContent")>]
    member inline _.childContent
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] renderChild: NodeRenderFragment
        )
        =
        render ==> html.renderFragment ("ChildContent", renderChild)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, renders: NodeRenderFragment seq) =
        render ==> html.renderFragment ("ChildContent", html.mergeNodes renders)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: string) =
        render ==> html.renderFragment ("ChildContent", html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: int) =
        render ==> html.renderFragment ("ChildContent", html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: float) =
        render ==> html.renderFragment ("ChildContent", html.text v)


type ComponentWithDomAttrBuilder<'T when 'T :> IComponent>() =
    inherit DomAttrBuilder()

    interface IComponentBuilder<'T>

    member inline _.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseComponent()
            nextIndex
        )


type ComponentWithDomAndChildAttrBuilder<'T when 'T :> IComponent>() =
    inherit ComponentWithDomAttrBuilder<'T>()

    member inline _.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            builder.AddAttribute(
                index + 1,
                "ChildContent",
                RenderFragment(fun tb -> render.Invoke(comp, tb, 0) |> ignore)
            )
            builder.CloseComponent()
            index + 2
        )

    /// We should handle this because in Blazor, component need an Attribute called ChildContent for its child elements or components.
    /// So we cannot merge AttrRenderFragment and NodeRenderFragment directly.
    /// Instead, we should first invoke AttrRenderFragment then add ChildContent RenderFragment as attribute and switch builder context.
    /// Other method like Delay, For, Combine should also have appropriate implementation to seperate Attr and Node so we can Invoke them standalone.
    member inline _.Run(renders: AttrRenderFragment * NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            let render1, render2 = renders
            let mutable nextIndex = index
            builder.OpenComponent<'T>(index)
            nextIndex <- render1.Invoke(comp, builder, index + 1)
            builder.AddAttribute(
                nextIndex,
                "ChildContent",
                RenderFragment(fun tb -> render2.Invoke(comp, tb, 0) |> ignore)
            )
            builder.CloseComponent()
            nextIndex + 1
        )


    member inline _.Yield(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield<'Elt when 'Elt :> IEltBuilder>(x: 'Elt) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield<'Comp, 'T1 when 'Comp :> IComponentBuilder<'T1>>(_: 'Comp) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T1>(index)
            builder.CloseComponent()
            index + 1
        )

    member inline _.Yield([<InlineIfLambda>] x: NodeRenderFragment) = x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = fn ()

    /// We should only allow merge AttrRenderFragment with NodeRenderFragment.
    /// Instead of merge NodeRenderFragment with AttrRenderFragment because blazor only allow add attribute then child.
    /// Also it is clear for the DSL
    member inline _.Combine
        (
            [<InlineIfLambda>] render1: AttrRenderFragment,
            [<InlineIfLambda>] render2: NodeRenderFragment
        )
        =
        render1, render2

    member inline _.Combine
        (
            [<InlineIfLambda>] render1: NodeRenderFragment,
            [<InlineIfLambda>] render2: NodeRenderFragment
        )
        =
        render1 >=> render2

    member inline _.For
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] fn: unit -> NodeRenderFragment
        )
        =
        render, (fn ())

    member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) =
        renders |> Seq.map fn |> Seq.fold (>=>) (emptyNode)

    member inline _.YieldFrom(renders: NodeRenderFragment seq) =
        renders |> Seq.fold (>=>) (emptyNode)

    member inline _.Zero() = emptyNode


    [<CustomOperation("childContent")>]
    member inline _.childContent
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] renderChild: NodeRenderFragment
        )
        =
        render ==> html.renderFragment ("ChildContent", renderChild)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, renders: NodeRenderFragment seq) =
        render ==> html.renderFragment ("ChildContent", html.mergeNodes renders)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: string) =
        render ==> html.renderFragment ("ChildContent", html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: int) =
        render ==> html.renderFragment ("ChildContent", html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: float) =
        render ==> html.renderFragment ("ChildContent", html.text v)
