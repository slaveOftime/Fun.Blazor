namespace Fun.Blazor

open Operators
open Internal


type FragmentBuilder() =

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

    member inline _.Combine
        (
            [<InlineIfLambda>] render1: NodeRenderFragment,
            [<InlineIfLambda>] render2: NodeRenderFragment
        )
        =
        render1 >=> render2

    //member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) =
    //    renders |> Seq.map fn |> Seq.fold (>=>) (emptyNode())

    member inline _.YieldFrom(renders: NodeRenderFragment seq) = renders |> Seq.fold (>=>) (emptyNode())


    member inline _.Zero() = emptyNode()


[<AutoOpen>]
module FragmentBuilderUtils =

    /// When child items are not too much, we can use this.
    /// To handling a lot of items, please use html.fragment for better intellicense performance
    let fragment = FragmentBuilder()
