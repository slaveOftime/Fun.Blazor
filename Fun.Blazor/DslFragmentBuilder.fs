namespace Fun.Blazor

open Operators
open Internal


type FragmentBuilder() =

    member inline _.Run([<InlineIfLambda>] node: NodeRenderFragment) = html.region node


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

    member inline _.Yield<'T when 'T :> IElementBuilder>(x: 'T) =
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

    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = NodeRenderFragment(fun c b i -> fn().Invoke(c, b, i))

    member inline _.Combine([<InlineIfLambda>] render1: NodeRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >=> render2

    member inline _.For(items: 'T seq, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) =
        NodeRenderFragment(fun comp builder i ->
            let mutable i = i
            for item in items do
                i <- fn(item).Invoke(comp, builder, i)
            i
        )

    member inline _.YieldFrom(renders: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder i ->
            let mutable i = i
            for node in renders do
                i <- node.Invoke(comp, builder, i)
            i
        )


    member inline _.Zero() = emptyNode ()


[<AutoOpen>]
module FragmentBuilderUtils =

    /// It will use region under the hood to have better diff perf when its content is dynamic.
    let fragment = FragmentBuilder()

    /// It is alias of fragment but with more explicity meaning for open a region with new sequence numbers.
    let region = FragmentBuilder()
