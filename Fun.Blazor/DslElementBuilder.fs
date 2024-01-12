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

    member inline this.Run((render1, render2): struct (AttrRenderFragment * PostRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = (render1 ===> render2).Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )


    [<CustomOperation("ref")>]
    member inline _.ref([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: 'T -> unit) =
        struct (render,
                PostRenderFragment(fun _ builder index ->
                    builder.AddElementReferenceCapture(index, (fun x -> fn (unbox<'T> x)))
                    index + 1
                ))

    [<CustomOperation("ref")>]
    member inline _.ref((render1, render2): struct (AttrRenderFragment * PostRenderFragment), [<InlineIfLambda>] fn: 'T -> unit) =
        struct (render1,
                PostRenderFragment(fun comp builder index ->
                    let nextIndex = render2.Invoke(comp, builder, index)
                    builder.AddElementReferenceCapture(nextIndex, (fun x -> fn (unbox<'T> x)))
                    nextIndex + 1
                ))

    member inline _.Delay([<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * PostRenderFragment)) = fn ()

    /// Create empty element
    member inline this.create() =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            builder.CloseElement()
            index + 1
        )

    member inline this.create(childItems: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = html.fragment(childItems).Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
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

    member inline this.Run((render1, render2, render3): struct (AttrRenderFragment * PostRenderFragment * NodeRenderFragment)) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = index + 1
            let nextIndex = (render1 ===> render2 >>> render3).Invoke(comp, builder, nextIndex)
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

    /// We should only allow merge AttrRenderFragment with NodeRenderFragment.
    /// Instead of merge NodeRenderFragment with AttrRenderFragment because blazor only allow add attribute then child.
    /// Also it is clear for the DSL
    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >>> render2

    member inline _.Combine([<InlineIfLambda>] render1: NodeRenderFragment, [<InlineIfLambda>] render2: NodeRenderFragment) = render1 >=> render2


    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = NodeRenderFragment(fun c b i -> fn().Invoke(c, b, i))

    member inline _.Delay([<InlineIfLambda>] fn: unit -> struct (AttrRenderFragment * PostRenderFragment * NodeRenderFragment)) = fn ()


    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = render >>> (fn ())

    member inline _.For([<InlineIfLambda>] render: NodeRenderFragment, [<InlineIfLambda>] fn: unit -> NodeRenderFragment) = render >=> (fn ())

    member inline _.For((render1, render2): struct (AttrRenderFragment * PostRenderFragment), [<InlineIfLambda>] fn: unit -> NodeRenderFragment) =
        struct (render1, render2, fn ())

    member inline _.For(renders: 'Data seq, [<InlineIfLambda>] fn: 'Data -> NodeRenderFragment) =
        renders |> Seq.map fn |> Seq.fold (>=>) (emptyNode ()) |> html.region

    member inline _.YieldFrom(renders: NodeRenderFragment seq) = renders |> Seq.fold (>=>) (emptyNode ()) |> html.region

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
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, renders: NodeRenderFragment seq) = render >>> html.region (renders)

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
    member inline _.childContent
        (
            (render1, render2): struct (AttrRenderFragment * PostRenderFragment),
            [<InlineIfLambda>] renderChild: NodeRenderFragment
        )
        =
        render1 ===> render2 >>> renderChild

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), renders: NodeRenderFragment seq) =
        struct (render1, render2, html.region renders)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: string) =
        render1 ===> render2 >>> (html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: int) =
        render1 ===> render2 >>> (html.text v)

    [<CustomOperation("childContent")>]
    member inline _.childContent((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: float) =
        render1 ===> render2 >>> (html.text v)

    [<CustomOperation("childContentRaw")>]
    member inline _.childContentRaw((render1, render2): struct (AttrRenderFragment * PostRenderFragment), v: string) =
        render1 ===> render2 >>> (html.raw v)


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


[<AutoOpen>]
module AutoOpenGlobalAttrs =

    type EltWithChildBuilder with

        /// Keyboard shortcut to activate or add focus to the element.
        [<CustomOperation("accesskey")>]
        member inline _.accesskey([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accesskey" => v)

        /// Sets whether input is automatically capitalized when entered by user
        [<CustomOperation("autocapitalize")>]
        member inline _.autocapitalize([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("autocapitalize" =>>> defaultArg v true)

        /// Indicating that an element should be focused on page load, or when the <dialog> that it is part of is displayed.
        [<CustomOperation("autofocus")>]
        member inline _.autofocus([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("autofocus" =>>> defaultArg v true)

        /// Indicates whether the element's content is editable.
        [<CustomOperation("contenteditable")>]
        member inline _.contenteditable([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("contenteditable" =>>> defaultArg v true)

        /// Lets you attach custom attributes to an HTML element.
        [<CustomOperation("data")>]
        member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, k, v) = render ==> ("data-" + k => v)

        /// Lets you attach custom attributes to an HTML element.
        [<CustomOperation("data")>]
        member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("data" => v)

        /// Defines whether the element can be dragged.
        [<CustomOperation("draggable")>]
        member inline _.draggable([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("draggable" =>>> defaultArg v true)

        /// Prevents rendering of given element, while keeping child elements, e.g. script elements, active.
        [<CustomOperation("hidden")>]
        member inline _.hidden([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("hidden" =>>> defaultArg v true)

        /// Often used with CSS to style a specific element. The value of this attribute must be unique.
        [<CustomOperation("id")>]
        member inline _.id([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("id" => v)

        /// Defines the language used in the element.
        [<CustomOperation("lang")>]
        member inline _.lang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lang" => v)

        /// Defining a cryptographic nonce ("number used once") which can be used by Content Security Policy to determine whether or not a given fetch will be allowed to proceed for a given element.
        [<CustomOperation("nonce")>]
        member inline _.nonce([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("nonce" => v)

        /// Used to designate an element as a popover element
        [<CustomOperation("popover")>]
        member inline _.popover([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("popover" => v)

        /// Defines an explicit role for an element for use by assistive technologies.
        [<CustomOperation("role")>]
        member inline _.role([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("role" => v)

        /// Overrides the browser's default tab order and follows the one specified instead.
        [<CustomOperation("tabindex")>]
        member inline _.tabindex([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("tabindex" => v)

        /// Text to be displayed in a tooltip when hovering over the element.
        [<CustomOperation("title'")>]
        member inline _.title'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("title" => v)


/// Some attributes are not used very often, there is no need to auto open it which may reduce CE performance
module GlobalAttrs =

    type EltWithChildBuilder with

        /// Defines the text direction. Allowed values are ltr (Left-To-Right) or rtl (Right-To-Left)
        [<CustomOperation("dir_ltr")>]
        member inline _.dir_ltr([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("dir" => "ltr")

        /// Defines the text direction. Allowed values are ltr (Left-To-Right) or rtl (Right-To-Left)
        [<CustomOperation("dir_rtl")>]
        member inline _.dir_rtl([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("dir" => "rtl")


        /// Defining what action label (or icon) to present for the enter key on virtual keyboards.
        [<CustomOperation("enterkeyhint")>]
        member inline _.enterkeyhint([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("enterkeyhint" => v)

        /// Allows you to select and style elements existing in nested shadow trees, by exporting their part names.
        [<CustomOperation("exportparts")>]
        member inline _.exportparts([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("exportparts" => v)

        /// Indicating that the browser will ignore the element. With the inert attribute, all of the element's flat tree descendants (such as modal <dialog>s) that don't otherwise escape inertness are ignored. The inert attribute also makes the browser ignore input events sent by the user, including focus-related events and events from assistive technologies.
        [<CustomOperation("inert")>]
        member inline _.inert([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("inert" =>>> defaultArg v true)

        /// Hints at the type of data that might be entered by the user while editing the element or its contents. This allows a browser to display an appropriate virtual keyboard.
        [<CustomOperation("inputmode")>]
        member inline _.inputmode([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("inputmode" => v)

        /// Specify that a standard HTML element should behave like a defined custom built-in element (see Using custom elements for more details).
        [<CustomOperation("is")>]
        member inline _.is([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("is" =>> v)


        /// Provides microdata in the form of a unique, global identifier of an item
        [<CustomOperation("itemid")>]
        member inline _.itemid([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemid" => v)

        /// Used to add properties to an item. Every HTML element can have an itemprop attribute specified, and an itemprop consists of a name-value pair. Each name-value pair is called a property, and a group of one or more properties forms an item. Property values are either a string or a URL and can be associated with a very wide range of elements including <audio>, <embed>, <iframe>, <img>, <link>, <object>, <source>, <track>, and <video>.
        [<CustomOperation("itemprop")>]
        member inline _.itemprop([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemprop" => v)

        /// Provides a list of element IDs (not itemids) elsewhere in the document, with additional properties
        [<CustomOperation("itemref")>]
        member inline _.itemref([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemref" => v)

        /// Defines the scope of associated metadata. Specifying the itemscope attribute for an element creates a new item, which results in a number of name-value pairs that are associated with the element.
        [<CustomOperation("itemscope")>]
        member inline _.itemscope([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemscope" => v)

        /// Used to set the scope of where in the data structure the vocabulary set by itemtype will be active.
        [<CustomOperation("itemtype")>]
        member inline _.itemtype([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemtype" => v)


        /// Contains a space-separated list of the part names of the element. Part names allows CSS to select and style specific elements in a shadow tree via the ::part pseudo-element.
        [<CustomOperation("part")>]
        member inline _.part([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("part" => v)

                /// Assigns a slot in a shadow DOM shadow tree to an element.
        [<CustomOperation("slot")>]
        member inline _.slot([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("slot" => v)

        /// Indicates whether spell checking is allowed for the element.
        [<CustomOperation("spellcheck")>]
        member inline _.spellcheck([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("spellcheck" =>>> defaultArg v true)
        
        /// Specify whether an element's attribute values and the values of its Text node children are to be translated when the page is localized, or whether to leave them unchanged.
        [<CustomOperation("translate")>]
        member inline _.translate([<InlineIfLambda>] render: AttrRenderFragment, ?v) = render ==> ("translate" =>>> defaultArg v true)
