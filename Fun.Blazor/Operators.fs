module Fun.Blazor.Operators

/// Add Attribute with name and value
let inline (=>) (name: string) (value: 'Value) =
    AttrRenderFragment(fun _ builder index ->
        builder.AddAttribute(index, name, box value)
        index + 1
    )

/// Add Attribute with name and string value
let inline (=>>) (name: string) (value: string) =
    AttrRenderFragment(fun _ builder index ->
        builder.AddAttribute(index, name, value)
        index + 1
    )

/// Add Attribute with name and bool value
/// If true then add the name to attribute else do nothing
let inline (=>>>) (name: string) (value: bool) =
    AttrRenderFragment(fun _ builder index ->
        builder.AddAttribute(index, name, value)
        index + 1
    )

/// Merge two AttrRenderFragment together
let inline (==>) ([<InlineIfLambda>] render1: AttrRenderFragment) ([<InlineIfLambda>] render2: AttrRenderFragment) =
    AttrRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

/// Merge AttrRenderFragment and PostRenderFragment together
let inline (===>) ([<InlineIfLambda>] render1: AttrRenderFragment) ([<InlineIfLambda>] render2: PostRenderFragment) =
    PostRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

/// Merge PostRenderFragment and PostRenderFragment together
let inline (====>) ([<InlineIfLambda>] render1: PostRenderFragment) ([<InlineIfLambda>] render2: PostRenderFragment) =
    PostRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

/// Merge two NodeRenderFragment together
let inline (>=>) ([<InlineIfLambda>] render1: NodeRenderFragment) ([<InlineIfLambda>] render2: NodeRenderFragment) =
    NodeRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

/// Merge AttrRenderFragment and NodeRenderFragment together.
/// This should be used together for building element only. For component we should not use this, because it treat ChildContent different in Blazor
let inline (>>>) ([<InlineIfLambda>] render1: AttrRenderFragment) ([<InlineIfLambda>] render2: NodeRenderFragment) =
    NodeRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

/// Merge PostRenderFragment and NodeRenderFragment together.
/// This should be used together for building element only. For component we should not use this, because it treat ChildContent different in Blazor
let inline (>>>>) ([<InlineIfLambda>] render1: PostRenderFragment) ([<InlineIfLambda>] render2: NodeRenderFragment) =
    NodeRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))
