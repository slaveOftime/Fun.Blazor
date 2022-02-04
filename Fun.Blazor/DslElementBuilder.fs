namespace Fun.Blazor

open Microsoft.AspNetCore.Components
open Operators


type EltBuilder(name) =
    inherit DomAttrBuilder()

    interface IElementBuilder with
        member _.Name: string = name

    member this.Run(render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    [<CustomOperation("ref")>]
    member _.ref
        (
            render: AttrRenderFragment,
            fn: ElementReference -> unit
        )
        =
        NodeRenderFragment(fun comp builder index ->
            let nextIndex = render.Invoke(comp, builder, index)
            builder.AddElementReferenceCapture(nextIndex, fn)
            nextIndex + 1
        )


type EltWithChildBuilder(name) =
    inherit EltBuilder(name)


    member this.Run(render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, (this :> IElementBuilder).Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )
    

    member _.Yield(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member _.Yield(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member _.Yield(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member _.Yield<'Elt when 'Elt :> IElementBuilder>(x: 'Elt) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member _.Yield<'Comp, 'T1 when 'Comp :> IComponentBuilder<'T1>>(_: 'Comp) =
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
        render1 >>> render2

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
        render >>> (fn ())

    member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> NodeRenderFragment) =
        renders |> Seq.map fn |> Seq.fold (>=>) emptyNode

    member inline _.YieldFrom(renders: NodeRenderFragment seq) =
        renders |> Seq.fold (>=>) emptyNode

    member inline _.Zero() = emptyNode

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
    member _.childContent
        (
            render: AttrRenderFragment,
            renderChild: NodeRenderFragment
        )
        =
        render >>> renderChild

    /// <summary>
    /// It is recommend to use fragment for better performance
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
    member _.childContent(render: AttrRenderFragment, renders: NodeRenderFragment seq) =
        NodeRenderFragment(fun comp builder index ->
            let mutable index = render.Invoke(comp, builder, index)
            for item in renders do
                index <- item.Invoke(comp, builder, index)
            index
        )

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
    member _.childContent(render: AttrRenderFragment, v: string) = render >>> (html.text v)

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
    member _.childContent(render: AttrRenderFragment, v: int) = render >>> (html.text v)

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
    member _.childContent(render: AttrRenderFragment, v: float) = render >>> (html.text v)

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
    member _.childContentRaw(render: AttrRenderFragment, v: string) = render >>> (html.raw v)


[<AutoOpen>]
module Elts =

    let abbr = EltWithChildBuilder "abbr"

    let acronym = EltWithChildBuilder "acronym"

    let address = EltWithChildBuilder "address"

    let applet = EltWithChildBuilder "applet"

    let area = EltWithChildBuilder "area"

    let article = EltWithChildBuilder "article"

    let aside = EltWithChildBuilder "aside"

    let audio = EltWithChildBuilder "audio"

    let b = EltWithChildBuilder "b"

    let base' = EltWithChildBuilder "base"

    let basefont = EltWithChildBuilder "basefont"

    let bdi = EltWithChildBuilder "bdi"

    let bdo = EltWithChildBuilder "bdo"

    let big = EltWithChildBuilder "big"

    let blockquote = EltWithChildBuilder "blockquote"

    let br = EltWithChildBuilder "br"

    let button = EltWithChildBuilder "button"

    let canvas = EltWithChildBuilder "canvas"

    let caption = EltWithChildBuilder "caption"

    let center = EltWithChildBuilder "center"

    let cite = EltWithChildBuilder "cite"

    let code = EltWithChildBuilder "code"

    let col = EltWithChildBuilder "col"

    let colgroup = EltWithChildBuilder "colgroup"

    let content = EltWithChildBuilder "content"

    let data = EltWithChildBuilder "data"

    let datalist = EltWithChildBuilder "datalist"

    let dd = EltWithChildBuilder "dd"

    let del = EltWithChildBuilder "del"

    let details = EltWithChildBuilder "details"

    let dfn = EltWithChildBuilder "dfn"

    let dialog = EltWithChildBuilder "dialog"

    let dir = EltWithChildBuilder "dir"

    let div = EltWithChildBuilder "div"

    let dl = EltWithChildBuilder "dl"

    let dt = EltWithChildBuilder "dt"

    let element = EltWithChildBuilder "element"

    let em = EltWithChildBuilder "em"

    let embed = EltWithChildBuilder "embed"

    let fieldset = EltWithChildBuilder "fieldset"

    let figcaption = EltWithChildBuilder "figcaption"

    let figure = EltWithChildBuilder "figure"

    let font = EltWithChildBuilder "font"

    let footer = EltWithChildBuilder "footer"

    let form = EltWithChildBuilder "form"

    let frame = EltWithChildBuilder "frame"

    let frameset = EltWithChildBuilder "frameset"

    let h1 = EltWithChildBuilder "h1"

    let h2 = EltWithChildBuilder "h2"

    let h3 = EltWithChildBuilder "h3"

    let h4 = EltWithChildBuilder "h4"

    let h5 = EltWithChildBuilder "h5"

    let h6 = EltWithChildBuilder "h6"

    let header = EltWithChildBuilder "header"

    let hr = EltWithChildBuilder "hr"

    let i = EltWithChildBuilder "i"

    let iframe = EltWithChildBuilder "iframe"

    let input = EltWithChildBuilder "input"

    let ins = EltWithChildBuilder "ins"

    let kbd = EltWithChildBuilder "kbd"

    let label = EltWithChildBuilder "label"

    let legend = EltWithChildBuilder "legend"

    let li = EltWithChildBuilder "li"

    let link = EltWithChildBuilder "link"

    let main = EltWithChildBuilder "main"

    let map = EltWithChildBuilder "map"

    let mark = EltWithChildBuilder "mark"

    let menu = EltWithChildBuilder "menu"

    let menuitem = EltWithChildBuilder "menuitem"

    let meter = EltWithChildBuilder "meter"

    let nav = EltWithChildBuilder "nav"

    let noembed = EltWithChildBuilder "noembed"

    let noframes = EltWithChildBuilder "noframes"

    let noscript = EltWithChildBuilder "noscript"

    let object = EltWithChildBuilder "object"

    let ol = EltWithChildBuilder "ol"

    let optgroup = EltWithChildBuilder "optgroup"

    let option = EltWithChildBuilder "option"

    let output = EltWithChildBuilder "output"

    let p = EltWithChildBuilder "p"

    let param = EltWithChildBuilder "param"

    let picture = EltWithChildBuilder "picture"

    let pre = EltWithChildBuilder "pre"

    let progress = EltWithChildBuilder "progress"

    let q = EltWithChildBuilder "q"

    let rb = EltWithChildBuilder "rb"

    let rp = EltWithChildBuilder "rp"

    let rt = EltWithChildBuilder "rt"

    let rtc = EltWithChildBuilder "rtc"

    let ruby = EltWithChildBuilder "ruby"

    let s = EltWithChildBuilder "s"

    let samp = EltWithChildBuilder "samp"

    let script = EltWithChildBuilder "script"

    let section = EltWithChildBuilder "section"

    let select = EltWithChildBuilder "select"

    let shadow = EltWithChildBuilder "shadow"

    let slot = EltWithChildBuilder "slot"

    let small = EltWithChildBuilder "small"

    let source = EltWithChildBuilder "source"

    let span = EltWithChildBuilder "span"

    let strike = EltWithChildBuilder "strike"

    let strong = EltWithChildBuilder "strong"

    let style = EltWithChildBuilder "style"

    let sub = EltWithChildBuilder "sub"

    let summary = EltWithChildBuilder "summary"

    let sup = EltWithChildBuilder "sup"

    let svg = EltWithChildBuilder "svg"

    let table = EltWithChildBuilder "table"

    let tbody = EltWithChildBuilder "tbody"

    let td = EltWithChildBuilder "td"

    let template = EltWithChildBuilder "template"

    let textarea = EltWithChildBuilder "textarea"

    let tfoot = EltWithChildBuilder "tfoot"

    let th = EltWithChildBuilder "th"

    let thead = EltWithChildBuilder "thead"

    let time = EltWithChildBuilder "time"

    let title = EltWithChildBuilder "title"

    let tr = EltWithChildBuilder "tr"

    let track = EltWithChildBuilder "track"

    let tt = EltWithChildBuilder "tt"

    let u = EltWithChildBuilder "u"

    let ul = EltWithChildBuilder "ul"

    let var = EltWithChildBuilder "var"

    let video = EltWithChildBuilder "video"

    let wbr = EltBuilder "wbr"

    let img = EltBuilder "img"

    let html' = EltWithChildBuilder "html"

    let body = EltWithChildBuilder "body"

    let head = EltWithChildBuilder "head"

    let meta = EltWithChildBuilder "meta"


    /// Put raw js into the script tag
    let js (x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, "script")
            builder.AddContent(index + 1, x)
            builder.CloseElement()
            index + 2
        )


    let doctype decl =
        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, $"<!DOCTYPE {decl}>\n")
            index + 1
        )

    let stylesheet (x: string) =
        link {
            rel "stylesheet"
            href x
        }

    let baseUrl (x: string) = base' { href x }


    let styleBuilder = StyleBuilder()

    /// Short name for StyleBuilder
    let style'' = styleBuilder
