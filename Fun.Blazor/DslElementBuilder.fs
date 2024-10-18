namespace Fun.Blazor

open Microsoft.AspNetCore.Components
open Operators
open Internal


type EltBuilder(name) =
    inherit DomAttrBuilder()

    interface IElementBuilder with
        member _.Name: string = name


    member inline this.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    member inline this.Run([<InlineIfLambda>] render: PostRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )


    [<CustomOperation("ref")>]
    member inline _.ref([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) =
        render
        ===> PostRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, (fun x -> fn (unbox<'T> x)))
            index + 1
        )

    [<CustomOperation("ref")>]
    member inline _.ref(render: PostRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) =
        render
        ====> PostRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, (fun x -> fn (unbox<'T> x)))
            index + 1
        )

    member inline _.Delay([<InlineIfLambda>] fn: unit -> PostRenderFragment) = fn ()

    /// Create empty element
    member inline this.create() =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            builder.CloseElement()
            index + 1
        )

    member inline this.create(childItems: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder sequence ->
            builder.OpenElement(sequence, (this :> IElementBuilder).Name)
            builder.OpenRegion(sequence + 1)

            let mutable i = 0
            for node in childItems do
                i <- node.Invoke(comp, builder, i)

            builder.CloseRegion()
            builder.CloseElement()
            sequence + 2
        )

    member inline this.create(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            builder.AddContent(index + 1, x)
            builder.CloseElement()
            index + 2
        )

    member inline this.create(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            builder.AddContent(index + 1, x)
            builder.CloseElement()
            index + 2
        )


type EltWithChildBuilder(name) =
    inherit EltBuilder(name)

    member inline this.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    member inline this.Run((render1, render2): (PostRenderFragment * NodeRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = index + 1
            let nextIndex = render1.Invoke(comp, builder, nextIndex)
            let nextIndex = render2.Invoke(comp, builder, nextIndex)
            builder.CloseElement()
            nextIndex
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

    member inline _.Yield<'Elt when 'Elt :> IElementBuilder>(x: 'Elt) =
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

    member inline _.Yield(x: RenderFragment) = html.renderFragment x

    member inline _.Yield([<InlineIfLambda>] x: NodeRenderFragment) = x

    member inline _.Yield(x: NodeRenderFragment seq) = html.region x

    /// We should only allow merge AttrRenderFragment with NodeRenderFragment.
    /// Instead of merge NodeRenderFragment with AttrRenderFragment because blazor only allow add attribute then child.
    /// Also it is clear for the DSL
    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >>> render2

    member inline _.Combine([<InlineIfLambda>] render1: PostRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >>>> render2

    //[<Obsolete("Please use childContent [| ... |] for multiple child items for better CE build performance", DiagnosticId = "FB0044")>]
    member inline _.Combine([<InlineIfLambda>] render1: NodeRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >=> render2


    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = NodeRenderFragment(fun c b i -> fn().Invoke(c, b, i))

    member inline _.Delay([<InlineIfLambda>] fn: unit -> (PostRenderFragment * NodeRenderFragment)) = fn ()


    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = render >>> (fn ())

    member inline _.For([<InlineIfLambda>] render: PostRenderFragment, [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = render >>>> (fn ())

    member inline _.For([<InlineIfLambda>] render: NodeRenderFragment, [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = render >=> (fn ())


    member inline _.For(items: 'Data seq, [<InlineIfLambda>] fn: 'Data -> NodeRenderFragment) =
        NodeRenderFragment(fun comp builder sequence ->
            builder.OpenRegion(sequence)

            let mutable i = 0
            for item in items do
                i <- fn(item).Invoke(comp, builder, i)

            builder.CloseRegion()
            sequence + 1
        )

    member inline _.YieldFrom(renders: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder sequence ->
            builder.OpenRegion(sequence)

            let mutable i = 0
            for node in renders do
                i <- node.Invoke(comp, builder, i)

            builder.CloseRegion()
            sequence + 1
        )

    member inline _.Zero() = emptyNode ()

    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// // &lt;div>
    /// //   &lt;p>This is my content&lt;/p>
    /// // &lt;/div>
    /// let myText content =
    ///   p {
    ///    class' "my-class"
    ///    childContent content
    ///   }
    /// div {
    ///   childContent (myText "This is my content")
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] renderChild: NodeRenderFragment) =
        render >>> renderChild

    /// <summary>
    /// Multiple Nodes that are going to be added to the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// // &lt;div>
    /// //   &lt;p>&lt;/p>
    /// //   &lt;p>&lt;p/>
    /// // &lt;/div>
    /// div {
    ///   childContent [ p; p ]
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, renders: NodeRenderFragment seq) = render >>> makeRegion renders

    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// // &lt;div>
    /// // This is my content
    /// // &lt;/div>
    /// div {
    ///   childContent "This is my content"
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render >>> (html.text v)

    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// // &lt;div>
    /// // 10
    /// // &lt;/div>
    /// div {
    ///   childContent 10
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: int) = render >>> (html.text v)

    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// // &lt;div>
    /// // 100.25
    /// // &lt;/div>
    /// div {
    ///   childContent 100.25
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, v: float) = render >>> (html.text v)

    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// div {
    ///   childContentRaw ("""
    ///     &lt;section>
    ///       Watch out for XSS attacks if you use this,
    ///       remember to sanitize your html!
    ///     &lt;/section>
    ///   """
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContentRaw")>]
    member inline _.childContentRaw([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render >>> (html.raw v)


    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: PostRenderFragment, [<InlineIfLambda>] renderChild: NodeRenderFragment) =
        render >>>> renderChild

    [<CustomOperation("childContent")>]
    member inline _.childContent(render: PostRenderFragment, renders: NodeRenderFragment seq) = render >>>> makeRegion renders

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: PostRenderFragment, v: string) = render >>>> (html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: PostRenderFragment, v: int) = render >>>> (html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: PostRenderFragment, v: float) = render >>>> (html.text v)

    [<CustomOperation("childContentRaw")>]
    member inline _.childContentRaw([<InlineIfLambda>] render: PostRenderFragment, v: string) = render >>>> (html.raw v)


type EltBuilder_script() =
    inherit EltBuilder("script")

    member inline this.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    member inline _.Yield(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, x)
            index + 1
        )


    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >>> render2

    member inline _.Combine([<InlineIfLambda>] render1: NodeRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >=> render2

    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = NodeRenderFragment(fun c b i -> fn().Invoke(c, b, i))

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = render >>> (fn ())
