namespace Fun.Blazor

open System
open System.Text
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators


type StyleBuilder() =
    inherit Fun.Css.CssBuilder()

    member _.Run(combine: Fun.Css.Internal.CombineKeyValue) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, "style", combine.Invoke(StringBuilder()).ToString())
            index + 1
        )


type DomAttrBuilder() =
    
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
        renders |> Seq.map fn |> Seq.fold (==>) emptyAttr

    member inline _.YieldFrom(renders: AttrRenderFragment seq) =
        renders |> Seq.fold (==>) emptyAttr


    member inline _.Zero() = emptyAttr


    /// key for blazor
    [<CustomOperation("key")>]
    member _.key(render: AttrRenderFragment, k) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
            index
        )

    
    [<CustomOperation("callback")>]
    member _.callback
        (
            render: AttrRenderFragment,
            eventName,
            callback: 'T -> unit
        )
        =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action<'T> callback))
            index + 1
        )

    [<CustomOperation("callback")>]
    member _.callback
        (
            render: AttrRenderFragment,
            eventName,
            callback: 'T -> Task
        )
        =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Func<'T, Task> callback))
            index + 1
        )

    [<CustomOperation("preventDefault")>]
    member _.preventDefault(render: AttrRenderFragment, eventName, value) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddEventPreventDefaultAttribute(index, eventName, value)
            index + 1
        )

    [<CustomOperation("stopPropagation")>]
    member _.stopPropagation(render: AttrRenderFragment, eventName, value) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddEventPreventDefaultAttribute(index, eventName, value)
            index + 1
        )


    /// <summary>
    /// A list of strings to be applied as classes
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// div {
    ///   classes [ "flex"; "flex-row"; "space-betwen" ]
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("classes")>]
    member _.classes(render: AttrRenderFragment, v: string list) =
        render ==> (html.class' (String.concat " " v))

    [<CustomOperation("class'")>]
    member _.class'(render: AttrRenderFragment, v: string) = render ==> (html.class' v)

    /// This is a helper function which can be used together with VSCode extension "Highlight HTML/SQL templates in F#"
    /// You must follow below format
    /// css """_{
    ///     color: red;
    /// }"""
    ///
    /// Please be careful when you want to interop some values in it or you have special char like % you should do things like:
    /// css $"""_{{
    ///     width: {yourWeight}px;
    ///     height: 100%%;
    /// }}"""
    ///
    [<CustomOperation("css")>]
    member _.css(render: AttrRenderFragment, css: string) =
        let result =
            if String.IsNullOrEmpty css then
                ""
            elif css.StartsWith "_{" then
                let lastEndIndex = css.LastIndexOf "}"
                if css.Substring(lastEndIndex + 1).Trim().Split("\n")
                   |> Seq.filter (String.IsNullOrEmpty >> not)
                   |> Seq.length = 0 then
                    css.Substring(2, lastEndIndex - 2).Split("\n") |> Seq.map (fun x -> x.Trim()) |> String.concat " "
                else
                    css
            else
                css

        render ==> (html.style result)

    [<CustomOperation("style'")>]
    member _.style(render: AttrRenderFragment, x: string) = render ==> ("style" => x)

    [<CustomOperation("styles")>]
    member _.styles(render: AttrRenderFragment, v: (string * string) seq) =
        render ==> (html.style ((makeStyles v).ToString()))

    [<CustomOperation("bindRef")>]
    member _.bindRef(render: AttrRenderFragment, v) = render ==> ("bindRef" => v)
    [<CustomOperation("key'")>]
    member _.key'(render: AttrRenderFragment, v) = render ==> ("key" => v)
    [<CustomOperation("accept")>]
    member _.accept(render: AttrRenderFragment, v) = render ==> ("accept" => v)
    [<CustomOperation("acceptCharset")>]
    member _.acceptCharset(render: AttrRenderFragment, v) = render ==> ("acceptCharset" => v)
    [<CustomOperation("accesskey")>]
    member _.accesskey(render: AttrRenderFragment, v) = render ==> ("accesskey" => v)
    [<CustomOperation("action")>]
    member _.action(render: AttrRenderFragment, v) = render ==> ("action" => v)
    [<CustomOperation("align")>]
    member _.align(render: AttrRenderFragment, v) = render ==> ("align" => v)
    [<CustomOperation("allow")>]
    member _.allow(render: AttrRenderFragment, v) = render ==> ("allow" => v)
    [<CustomOperation("alt")>]
    member _.alt(render: AttrRenderFragment, v) = render ==> ("alt" => v)
    [<CustomOperation("async'")>]
    member _.async'(render: AttrRenderFragment, v) = render ==> ("async" => v)
    [<CustomOperation("autocapitalize")>]
    member _.autocapitalize(render: AttrRenderFragment, v) = render ==> ("autocapitalize" => v)
    [<CustomOperation("autocomplete")>]
    member _.autocomplete(render: AttrRenderFragment, v) = render ==> ("autocomplete" => v)
    [<CustomOperation("autofocus")>]
    member _.autofocus(render: AttrRenderFragment, v) = render ==> ("autofocus" => v)
    [<CustomOperation("autoplay")>]
    member _.autoplay(render: AttrRenderFragment, v) = render ==> ("autoplay" => v)
    [<CustomOperation("bgcolor")>]
    member _.bgcolor(render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)
    [<CustomOperation("border")>]
    member _.border(render: AttrRenderFragment, v) = render ==> ("border" => v)
    [<CustomOperation("buffered")>]
    member _.buffered(render: AttrRenderFragment, v) = render ==> ("buffered" => v)
    [<CustomOperation("challenge")>]
    member _.challenge(render: AttrRenderFragment, v) = render ==> ("challenge" => v)
    [<CustomOperation("charset")>]
    member _.charset(render: AttrRenderFragment, v) = render ==> ("charset" => v)
    [<CustomOperation("checked")>]
    member _.checked'(render: AttrRenderFragment, v) = render ==> ("checked" => v)
    [<CustomOperation("cite")>]
    member _.cite(render: AttrRenderFragment, v) = render ==> ("cite" => v)
    [<CustomOperation("code")>]
    member _.code(render: AttrRenderFragment, v) = render ==> ("code" => v)
    [<CustomOperation("codebase")>]
    member _.codebase(render: AttrRenderFragment, v) = render ==> ("codebase" => v)
    [<CustomOperation("color")>]
    member _.color(render: AttrRenderFragment, v) = render ==> ("color" => v)
    [<CustomOperation("cols")>]
    member _.cols(render: AttrRenderFragment, v) = render ==> ("cols" => v)
    [<CustomOperation("colspan")>]
    member _.colspan(render: AttrRenderFragment, v) = render ==> ("colspan" => v)
    [<CustomOperation("content")>]
    member _.content(render: AttrRenderFragment, v) = render ==> ("content" => v)
    [<CustomOperation("contenteditable")>]
    member _.contenteditable(render: AttrRenderFragment, v) = render ==> ("contenteditable" => v)
    [<CustomOperation("contextmenu")>]
    member _.contextmenu(render: AttrRenderFragment, v) = render ==> ("contextmenu" => v)
    [<CustomOperation("controls")>]
    member _.controls(render: AttrRenderFragment, v) = render ==> ("controls" => v)
    [<CustomOperation("coords")>]
    member _.coords(render: AttrRenderFragment, v) = render ==> ("coords" => v)
    [<CustomOperation("crossorigin")>]
    member _.crossorigin(render: AttrRenderFragment, v) = render ==> ("crossorigin" => v)
    [<CustomOperation("csp")>]
    member _.csp(render: AttrRenderFragment, v) = render ==> ("csp" => v)
    [<CustomOperation("data")>]
    member _.data(render: AttrRenderFragment, v) = render ==> ("data" => v)
    [<CustomOperation("datetime")>]
    member _.datetime(render: AttrRenderFragment, v) = render ==> ("datetime" => v)
    [<CustomOperation("decoding")>]
    member _.decoding(render: AttrRenderFragment, v) = render ==> ("decoding" => v)
    [<CustomOperation("default")>]
    member _.default'(render: AttrRenderFragment, v) = render ==> ("default" => v)
    [<CustomOperation("defer")>]
    member _.defer(render: AttrRenderFragment, v) = render ==> ("defer" => v)
    [<CustomOperation("dir")>]
    member _.dir(render: AttrRenderFragment, v) = render ==> ("dir" => v)
    [<CustomOperation("dirname")>]
    member _.dirname(render: AttrRenderFragment, v) = render ==> ("dirname" => v)
    [<CustomOperation("disabled")>]
    member _.disabled(render: AttrRenderFragment, v) = render ==> ("disabled" => v)
    [<CustomOperation("download")>]
    member _.download(render: AttrRenderFragment, v) = render ==> ("download" => v)
    [<CustomOperation("draggable")>]
    member _.draggable(render: AttrRenderFragment, v: bool) = render ==> ("draggable" => (if v then "true" else "false"))
    [<CustomOperation("dropzone")>]
    member _.dropzone(render: AttrRenderFragment, v) = render ==> ("dropzone" => v)
    [<CustomOperation("enctype")>]
    member _.enctype(render: AttrRenderFragment, v) = render ==> ("enctype" => v)
    [<CustomOperation("for")>]
    member _.for'(render: AttrRenderFragment, v) = render ==> ("for" => v)
    [<CustomOperation("form")>]
    member _.form(render: AttrRenderFragment, v) = render ==> ("form" => v)
    [<CustomOperation("formaction")>]
    member _.formaction(render: AttrRenderFragment, v) = render ==> ("formaction" => v)
    [<CustomOperation("headers")>]
    member _.headers(render: AttrRenderFragment, v) = render ==> ("headers" => v)
    [<CustomOperation("height")>]
    member _.height(render: AttrRenderFragment, v) = render ==> ("height" => v)
    [<CustomOperation("hidden")>]
    member _.hidden(render: AttrRenderFragment, v) = render ==> ("hidden" => v)
    [<CustomOperation("high")>]
    member _.high(render: AttrRenderFragment, v) = render ==> ("high" => v)
    [<CustomOperation("href")>]
    member _.href(render: AttrRenderFragment, v) = render ==> ("href" => v)
    [<CustomOperation("hreflang")>]
    member _.hreflang(render: AttrRenderFragment, v) = render ==> ("hreflang" => v)
    [<CustomOperation("httpEquiv")>]
    member _.httpEquiv(render: AttrRenderFragment, v) = render ==> ("httpEquiv" => v)
    [<CustomOperation("icon")>]
    member _.icon(render: AttrRenderFragment, v) = render ==> ("icon" => v)
    [<CustomOperation("id")>]
    member _.id(render: AttrRenderFragment, v) = render ==> ("id" => v)
    [<CustomOperation("importance")>]
    member _.importance(render: AttrRenderFragment, v) = render ==> ("importance" => v)
    [<CustomOperation("integrity")>]
    member _.integrity(render: AttrRenderFragment, v) = render ==> ("integrity" => v)
    [<CustomOperation("ismap")>]
    member _.ismap(render: AttrRenderFragment, v) = render ==> ("ismap" => v)
    [<CustomOperation("itemprop")>]
    member _.itemprop(render: AttrRenderFragment, v) = render ==> ("itemprop" => v)
    [<CustomOperation("keytype")>]
    member _.keytype(render: AttrRenderFragment, v) = render ==> ("keytype" => v)
    [<CustomOperation("kind")>]
    member _.kind(render: AttrRenderFragment, v) = render ==> ("kind" => v)
    [<CustomOperation("label")>]
    member _.label(render: AttrRenderFragment, v) = render ==> ("label" => v)
    [<CustomOperation("lang")>]
    member _.lang(render: AttrRenderFragment, v) = render ==> ("lang" => v)
    [<CustomOperation("language")>]
    member _.language(render: AttrRenderFragment, v) = render ==> ("language" => v)
    [<CustomOperation("lazyload")>]
    member _.lazyload(render: AttrRenderFragment, v) = render ==> ("lazyload" => v)
    [<CustomOperation("list")>]
    member _.list(render: AttrRenderFragment, v) = render ==> ("list" => v)
    [<CustomOperation("loop")>]
    member _.loop(render: AttrRenderFragment, v) = render ==> ("loop" => v)
    [<CustomOperation("low")>]
    member _.low(render: AttrRenderFragment, v) = render ==> ("low" => v)
    [<CustomOperation("manifest")>]
    member _.manifest(render: AttrRenderFragment, v) = render ==> ("manifest" => v)
    [<CustomOperation("max")>]
    member _.max(render: AttrRenderFragment, v) = render ==> ("max" => v)
    [<CustomOperation("maxlength")>]
    member _.maxlength(render: AttrRenderFragment, v) = render ==> ("maxlength" => v)
    [<CustomOperation("media")>]
    member _.media(render: AttrRenderFragment, v) = render ==> ("media" => v)
    [<CustomOperation("method")>]
    member _.method(render: AttrRenderFragment, v) = render ==> ("method" => v)
    [<CustomOperation("min")>]
    member _.min(render: AttrRenderFragment, v) = render ==> ("min" => v)
    [<CustomOperation("minlength")>]
    member _.minlength(render: AttrRenderFragment, v) = render ==> ("minlength" => v)
    [<CustomOperation("multiple")>]
    member _.multiple(render: AttrRenderFragment, v) = render ==> ("multiple" => v)
    [<CustomOperation("muted")>]
    member _.muted(render: AttrRenderFragment, v) = render ==> ("muted" => v)
    [<CustomOperation("name")>]
    member _.name(render: AttrRenderFragment, v: string) = render ==> ("name" => v)
    [<CustomOperation("novalidate")>]
    member _.novalidate(render: AttrRenderFragment, v) = render ==> ("novalidate" => v)
    [<CustomOperation("open")>]
    member _.open'(render: AttrRenderFragment, v) = render ==> ("open" => v)
    [<CustomOperation("optimum")>]
    member _.optimum(render: AttrRenderFragment, v) = render ==> ("optimum" => v)
    [<CustomOperation("pattern")>]
    member _.pattern(render: AttrRenderFragment, v) = render ==> ("pattern" => v)
    [<CustomOperation("ping")>]
    member _.ping(render: AttrRenderFragment, v) = render ==> ("ping" => v)
    [<CustomOperation("placeholder")>]
    member _.placeholder(render: AttrRenderFragment, v) = render ==> ("placeholder" => v)
    [<CustomOperation("poster")>]
    member _.poster(render: AttrRenderFragment, v) = render ==> ("poster" => v)
    [<CustomOperation("preload")>]
    member _.preload(render: AttrRenderFragment, v) = render ==> ("preload" => v)
    [<CustomOperation("readonly")>]
    member _.readonly(render: AttrRenderFragment, v) = render ==> ("readonly" => v)
    [<CustomOperation("rel")>]
    member _.rel(render: AttrRenderFragment, v) = render ==> ("rel" => v)
    [<CustomOperation("required")>]
    member _.required(render: AttrRenderFragment, v) = render ==> ("required" => v)
    [<CustomOperation("reversed")>]
    member _.reversed(render: AttrRenderFragment, v) = render ==> ("reversed" => v)
    [<CustomOperation("rows")>]
    member _.rows(render: AttrRenderFragment, v) = render ==> ("rows" => v)
    [<CustomOperation("rowspan")>]
    member _.rowspan(render: AttrRenderFragment, v) = render ==> ("rowspan" => v)
    [<CustomOperation("sandbox")>]
    member _.sandbox(render: AttrRenderFragment, v) = render ==> ("sandbox" => v)
    [<CustomOperation("scope")>]
    member _.scope(render: AttrRenderFragment, v) = render ==> ("scope" => v)
    [<CustomOperation("selected")>]
    member _.selected(render: AttrRenderFragment, v) = render ==> ("selected" => v)
    [<CustomOperation("shape")>]
    member _.shape(render: AttrRenderFragment, v) = render ==> ("shape" => v)
    [<CustomOperation("size")>]
    member _.size(render: AttrRenderFragment, v) = render ==> ("size" => v)
    [<CustomOperation("sizes")>]
    member _.sizes(render: AttrRenderFragment, v) = render ==> ("sizes" => v)
    [<CustomOperation("slot")>]
    member _.slot(render: AttrRenderFragment, v) = render ==> ("slot" => v)
    [<CustomOperation("span'")>]
    member _.span'(render: AttrRenderFragment, v) = render ==> ("span" => v)
    [<CustomOperation("spellcheck")>]
    member _.spellcheck(render: AttrRenderFragment, v) = render ==> ("spellcheck" => v)
    [<CustomOperation("src")>]
    member _.src(render: AttrRenderFragment, v) = render ==> ("src" => v)
    [<CustomOperation("srcdoc")>]
    member _.srcdoc(render: AttrRenderFragment, v) = render ==> ("srcdoc" => v)
    [<CustomOperation("srclang")>]
    member _.srclang(render: AttrRenderFragment, v) = render ==> ("srclang" => v)
    [<CustomOperation("srcset")>]
    member _.srcset(render: AttrRenderFragment, v) = render ==> ("srcset" => v)
    [<CustomOperation("start")>]
    member _.start(render: AttrRenderFragment, v) = render ==> ("start" => v)
    [<CustomOperation("step")>]
    member _.step(render: AttrRenderFragment, v) = render ==> ("step" => v)
    [<CustomOperation("summary")>]
    member _.summary(render: AttrRenderFragment, v) = render ==> ("summary" => v)
    [<CustomOperation("tabindex")>]
    member _.tabindex(render: AttrRenderFragment, v) = render ==> ("tabindex" => v)
    [<CustomOperation("target")>]
    member _.target(render: AttrRenderFragment, v) = render ==> ("target" => v)
    [<CustomOperation("title'")>]
    member _.title'(render: AttrRenderFragment, v) = render ==> ("title" => v)
    [<CustomOperation("translate")>]
    member _.translate(render: AttrRenderFragment, v) = render ==> ("translate" => v)
    [<CustomOperation("type'")>]
    member _.type'(render: AttrRenderFragment, v) = render ==> ("type" => v)
    [<CustomOperation("usemap")>]
    member _.usemap(render: AttrRenderFragment, v) = render ==> ("usemap" => v)
    [<CustomOperation("value")>]
    member _.value(render: AttrRenderFragment, v) = render ==> ("value" => v)
    [<CustomOperation("width")>]
    member _.width(render: AttrRenderFragment, v) = render ==> ("width" => v)
    [<CustomOperation("wrap")>]
    member _.wrap(render: AttrRenderFragment, v) = render ==> ("wrap" => v)


    [<CustomOperation("onfocus")>]
    member this.onfocus
        (
            render: AttrRenderFragment,
            callback: FocusEventArgs -> unit
        )
        =
        this.callback (render, "onfocus", callback)
    [<CustomOperation("onfocus")>]
    member this.onfocus
        (
            render: AttrRenderFragment,
            callback: FocusEventArgs -> Task
        )
        =
        this.callback (render, "onfocus", callback)
    [<CustomOperation("onblur")>]
    member this.onblur
        (
            render: AttrRenderFragment,
            callback: FocusEventArgs -> unit
        )
        =
        this.callback (render, "onblur", callback)
    [<CustomOperation("onblur")>]
    member this.onblur
        (
            render: AttrRenderFragment,
            callback: FocusEventArgs -> Task
        )
        =
        this.callback (render, "onblur", callback)
    [<CustomOperation("onfocusin")>]
    member this.onfocusin
        (
            render: AttrRenderFragment,
            callback: FocusEventArgs -> unit
        )
        =
        this.callback (render, "onfocusin", callback)
    [<CustomOperation("onfocusin")>]
    member this.onfocusin
        (
            render: AttrRenderFragment,
            callback: FocusEventArgs -> Task
        )
        =
        this.callback (render, "onfocusin", callback)
    [<CustomOperation("onfocusout")>]
    member this.onfocusout
        (
            render: AttrRenderFragment,
            callback: FocusEventArgs -> unit
        )
        =
        this.callback (render, "onfocusout", callback)
    [<CustomOperation("onfocusout")>]
    member this.onfocusout
        (
            render: AttrRenderFragment,
            callback: FocusEventArgs -> Task
        )
        =
        this.callback (render, "onfocusout", callback)
    [<CustomOperation("onmouseover")>]
    member this.onmouseover
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "onmouseover", callback)
    [<CustomOperation("onmouseover")>]
    member this.onmouseover
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "onmouseover", callback)
    [<CustomOperation("onmouseout")>]
    member this.onmouseout
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "onmouseout", callback)
    [<CustomOperation("onmouseout")>]
    member this.onmouseout
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "onmouseout", callback)
    [<CustomOperation("onmousemove")>]
    member this.onmousemove
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "onmousemove", callback)
    [<CustomOperation("onmousemove")>]
    member this.onmousemove
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "onmousemove", callback)
    [<CustomOperation("onmousedown")>]
    member this.onmousedown
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "onmousedown", callback)
    [<CustomOperation("onmousedown")>]
    member this.onmousedown
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "onmousedown", callback)
    [<CustomOperation("onmouseup")>]
    member this.onmouseup
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "onmouseup", callback)
    [<CustomOperation("onmouseup")>]
    member this.onmouseup
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "onmouseup", callback)
    [<CustomOperation("onclick")>]
    member this.onclick
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "onclick", callback)
    [<CustomOperation("onclick")>]
    member this.onclick
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "onclick", callback)
    [<CustomOperation("ondblclick")>]
    member this.ondblclick
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "ondblclick", callback)
    [<CustomOperation("ondblclick")>]
    member this.ondblclick
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "ondblclick", callback)
    [<CustomOperation("onwheel")>]
    member this.onwheel
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "onwheel", callback)
    [<CustomOperation("onwheel")>]
    member this.onwheel
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "onwheel", callback)
    [<CustomOperation("onmousewheel")>]
    member this.onmousewheel
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "onmousewheel", callback)
    [<CustomOperation("onmousewheel")>]
    member this.onmousewheel
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "onmousewheel", callback)
    [<CustomOperation("oncontextmenu")>]
    member this.oncontextmenu
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> unit
        )
        =
        this.callback (render, "oncontextmenu", callback)
    [<CustomOperation("oncontextmenu")>]
    member this.oncontextmenu
        (
            render: AttrRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.callback (render, "oncontextmenu", callback)
    [<CustomOperation("ondrag")>]
    member this.ondrag
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> unit
        )
        =
        this.callback (render, "ondrag", callback)
    [<CustomOperation("ondrag")>]
    member this.ondrag
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> Task
        )
        =
        this.callback (render, "ondrag", callback)
    [<CustomOperation("ondragend")>]
    member this.ondragend
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> unit
        )
        =
        this.callback (render, "ondragend", callback)
    [<CustomOperation("ondragend")>]
    member this.ondragend
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> Task
        )
        =
        this.callback (render, "ondragend", callback)
    [<CustomOperation("ondragenter")>]
    member this.ondragenter
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> unit
        )
        =
        this.callback (render, "ondragenter", callback)
    [<CustomOperation("ondragenter")>]
    member this.ondragenter
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> Task
        )
        =
        this.callback (render, "ondragenter", callback)
    [<CustomOperation("ondragleave")>]
    member this.ondragleave
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> unit
        )
        =
        this.callback (render, "ondragleave", callback)
    [<CustomOperation("ondragleave")>]
    member this.ondragleave
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> Task
        )
        =
        this.callback (render, "ondragleave", callback)
    [<CustomOperation("ondragover")>]
    member this.ondragover
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> unit
        )
        =
        this.callback (render, "ondragover", callback)
    [<CustomOperation("ondragover")>]
    member this.ondragover
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> Task
        )
        =
        this.callback (render, "ondragover", callback)
    [<CustomOperation("ondragstart")>]
    member this.ondragstart
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> unit
        )
        =
        this.callback (render, "ondragstart", callback)
    [<CustomOperation("ondragstart")>]
    member this.ondragstart
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> Task
        )
        =
        this.callback (render, "ondragstart", callback)
    [<CustomOperation("ondrop")>]
    member this.ondrop
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> unit
        )
        =
        this.callback (render, "ondrop", callback)
    [<CustomOperation("ondrop")>]
    member this.ondrop
        (
            render: AttrRenderFragment,
            callback: DragEventArgs -> Task
        )
        =
        this.callback (render, "ondrop", callback)
    [<CustomOperation("onkeydown")>]
    member this.onkeydown
        (
            render: AttrRenderFragment,
            callback: KeyboardEventArgs -> unit
        )
        =
        this.callback (render, "onkeydown", callback)
    [<CustomOperation("onkeydown")>]
    member this.onkeydown
        (
            render: AttrRenderFragment,
            callback: KeyboardEventArgs -> Task
        )
        =
        this.callback (render, "onkeydown", callback)
    [<CustomOperation("onkeyup")>]
    member this.onkeyup
        (
            render: AttrRenderFragment,
            callback: KeyboardEventArgs -> unit
        )
        =
        this.callback (render, "onkeyup", callback)
    [<CustomOperation("onkeyup")>]
    member this.onkeyup
        (
            render: AttrRenderFragment,
            callback: KeyboardEventArgs -> Task
        )
        =
        this.callback (render, "onkeyup", callback)
    [<CustomOperation("onkeypress")>]
    member this.onkeypress
        (
            render: AttrRenderFragment,
            callback: KeyboardEventArgs -> unit
        )
        =
        this.callback (render, "onkeypress", callback)
    [<CustomOperation("onkeypress")>]
    member this.onkeypress
        (
            render: AttrRenderFragment,
            callback: KeyboardEventArgs -> Task
        )
        =
        this.callback (render, "onkeypress", callback)
    [<CustomOperation("onchange")>]
    member this.onchange
        (
            render: AttrRenderFragment,
            callback: ChangeEventArgs -> unit
        )
        =
        this.callback (render, "onchange", callback)
    [<CustomOperation("onchange")>]
    member this.onchange
        (
            render: AttrRenderFragment,
            callback: ChangeEventArgs -> Task
        )
        =
        this.callback (render, "onchange", callback)
    [<CustomOperation("oninput")>]
    member this.oninput
        (
            render: AttrRenderFragment,
            callback: ChangeEventArgs -> unit
        )
        =
        this.callback (render, "oninput", callback)
    [<CustomOperation("oninput")>]
    member this.oninput
        (
            render: AttrRenderFragment,
            callback: ChangeEventArgs -> Task
        )
        =
        this.callback (render, "oninput", callback)
    [<CustomOperation("oninvalid")>]
    member this.oninvalid
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "oninvalid", callback)
    [<CustomOperation("oninvalid")>]
    member this.oninvalid
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "oninvalid", callback)
    [<CustomOperation("onreset")>]
    member this.onreset
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onreset", callback)
    [<CustomOperation("onreset")>]
    member this.onreset
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onreset", callback)
    [<CustomOperation("onselect")>]
    member this.onselect
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onselect", callback)
    [<CustomOperation("onselect")>]
    member this.onselect
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onselect", callback)
    [<CustomOperation("onselectstart")>]
    member this.onselectstart
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onselectstart", callback)
    [<CustomOperation("onselectstart")>]
    member this.onselectstart
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onselectstart", callback)
    [<CustomOperation("onselectionchange")>]
    member this.onselectionchange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onselectionchange", callback)
    [<CustomOperation("onselectionchange")>]
    member this.onselectionchange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onselectionchange", callback)
    [<CustomOperation("onsubmit")>]
    member this.onsubmit
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onsubmit", callback)
    [<CustomOperation("onsubmit")>]
    member this.onsubmit
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onsubmit", callback)
    [<CustomOperation("onbeforecopy")>]
    member this.onbeforecopy
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onbeforecopy", callback)
    [<CustomOperation("onbeforecopy")>]
    member this.onbeforecopy
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onbeforecopy", callback)
    [<CustomOperation("onbeforecut")>]
    member this.onbeforecut
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onbeforecut", callback)
    [<CustomOperation("onbeforecut")>]
    member this.onbeforecut
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onbeforecut", callback)
    [<CustomOperation("onbeforepaste")>]
    member this.onbeforepaste
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onbeforepaste", callback)
    [<CustomOperation("onbeforepaste")>]
    member this.onbeforepaste
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onbeforepaste", callback)
    [<CustomOperation("oncopy")>]
    member this.oncopy
        (
            render: AttrRenderFragment,
            callback: ClipboardEventArgs -> unit
        )
        =
        this.callback (render, "oncopy", callback)
    [<CustomOperation("oncopy")>]
    member this.oncopy
        (
            render: AttrRenderFragment,
            callback: ClipboardEventArgs -> Task
        )
        =
        this.callback (render, "oncopy", callback)
    [<CustomOperation("oncut")>]
    member this.oncut
        (
            render: AttrRenderFragment,
            callback: ClipboardEventArgs -> unit
        )
        =
        this.callback (render, "oncut", callback)
    [<CustomOperation("oncut")>]
    member this.oncut
        (
            render: AttrRenderFragment,
            callback: ClipboardEventArgs -> Task
        )
        =
        this.callback (render, "oncut", callback)
    [<CustomOperation("onpaste")>]
    member this.onpaste
        (
            render: AttrRenderFragment,
            callback: ClipboardEventArgs -> unit
        )
        =
        this.callback (render, "onpaste", callback)
    [<CustomOperation("onpaste")>]
    member this.onpaste
        (
            render: AttrRenderFragment,
            callback: ClipboardEventArgs -> Task
        )
        =
        this.callback (render, "onpaste", callback)
    [<CustomOperation("ontouchcancel")>]
    member this.ontouchcancel
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> unit
        )
        =
        this.callback (render, "ontouchcancel", callback)
    [<CustomOperation("ontouchcancel")>]
    member this.ontouchcancel
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.callback (render, "ontouchcancel", callback)
    [<CustomOperation("ontouchend")>]
    member this.ontouchend
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> unit
        )
        =
        this.callback (render, "ontouchend", callback)
    [<CustomOperation("ontouchend")>]
    member this.ontouchend
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.callback (render, "ontouchend", callback)
    [<CustomOperation("ontouchmove")>]
    member this.ontouchmove
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> unit
        )
        =
        this.callback (render, "ontouchmove", callback)
    [<CustomOperation("ontouchmove")>]
    member this.ontouchmove
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.callback (render, "ontouchmove", callback)
    [<CustomOperation("ontouchstart")>]
    member this.ontouchstart
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> unit
        )
        =
        this.callback (render, "ontouchstart", callback)
    [<CustomOperation("ontouchstart")>]
    member this.ontouchstart
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.callback (render, "ontouchstart", callback)
    [<CustomOperation("ontouchenter")>]
    member this.ontouchenter
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> unit
        )
        =
        this.callback (render, "ontouchenter", callback)
    [<CustomOperation("ontouchenter")>]
    member this.ontouchenter
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.callback (render, "ontouchenter", callback)
    [<CustomOperation("ontouchleave")>]
    member this.ontouchleave
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> unit
        )
        =
        this.callback (render, "ontouchleave", callback)
    [<CustomOperation("ontouchleave")>]
    member this.ontouchleave
        (
            render: AttrRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.callback (render, "ontouchleave", callback)
    [<CustomOperation("onpointercapture")>]
    member this.onpointercapture
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointercapture", callback)
    [<CustomOperation("onpointercapture")>]
    member this.onpointercapture
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointercapture", callback)
    [<CustomOperation("onlostpointercapture")>]
    member this.onlostpointercapture
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onlostpointercapture", callback)
    [<CustomOperation("onlostpointercapture")>]
    member this.onlostpointercapture
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onlostpointercapture", callback)
    [<CustomOperation("onpointercancel")>]
    member this.onpointercancel
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointercancel", callback)
    [<CustomOperation("onpointercancel")>]
    member this.onpointercancel
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointercancel", callback)
    [<CustomOperation("onpointerdown")>]
    member this.onpointerdown
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointerdown", callback)
    [<CustomOperation("onpointerdown")>]
    member this.onpointerdown
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointerdown", callback)
    [<CustomOperation("onpointerenter")>]
    member this.onpointerenter
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointerenter", callback)
    [<CustomOperation("onpointerenter")>]
    member this.onpointerenter
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointerenter", callback)
    [<CustomOperation("onpointerleave")>]
    member this.onpointerleave
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointerleave", callback)
    [<CustomOperation("onpointerleave")>]
    member this.onpointerleave
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointerleave", callback)
    [<CustomOperation("onpointermove")>]
    member this.onpointermove
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointermove", callback)
    [<CustomOperation("onpointermove")>]
    member this.onpointermove
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointermove", callback)
    [<CustomOperation("onpointerout")>]
    member this.onpointerout
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointerout", callback)
    [<CustomOperation("onpointerout")>]
    member this.onpointerout
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointerout", callback)
    [<CustomOperation("onpointerover")>]
    member this.onpointerover
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointerover", callback)
    [<CustomOperation("onpointerover")>]
    member this.onpointerover
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointerover", callback)
    [<CustomOperation("onpointerup")>]
    member this.onpointerup
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.callback (render, "onpointerup", callback)
    [<CustomOperation("onpointerup")>]
    member this.onpointerup
        (
            render: AttrRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.callback (render, "onpointerup", callback)
    [<CustomOperation("oncanplay")>]
    member this.oncanplay
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "oncanplay", callback)
    [<CustomOperation("oncanplay")>]
    member this.oncanplay
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "oncanplay", callback)
    [<CustomOperation("oncanplaythrough")>]
    member this.oncanplaythrough
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "oncanplaythrough", callback)
    [<CustomOperation("oncanplaythrough")>]
    member this.oncanplaythrough
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "oncanplaythrough", callback)
    [<CustomOperation("oncuechange")>]
    member this.oncuechange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "oncuechange", callback)
    [<CustomOperation("oncuechange")>]
    member this.oncuechange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "oncuechange", callback)
    [<CustomOperation("ondurationchange")>]
    member this.ondurationchange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "ondurationchange", callback)
    [<CustomOperation("ondurationchange")>]
    member this.ondurationchange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "ondurationchange", callback)
    [<CustomOperation("onemptied")>]
    member this.onemptied
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onemptied", callback)
    [<CustomOperation("onemptied")>]
    member this.onemptied
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onemptied", callback)
    [<CustomOperation("onpause")>]
    member this.onpause
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onpause", callback)
    [<CustomOperation("onpause")>]
    member this.onpause
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onpause", callback)
    [<CustomOperation("onplay")>]
    member this.onplay
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onplay", callback)
    [<CustomOperation("onplay")>]
    member this.onplay
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onplay", callback)
    [<CustomOperation("onplaying")>]
    member this.onplaying
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onplaying", callback)
    [<CustomOperation("onplaying")>]
    member this.onplaying
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onplaying", callback)
    [<CustomOperation("onratechange")>]
    member this.onratechange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onratechange", callback)
    [<CustomOperation("onratechange")>]
    member this.onratechange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onratechange", callback)
    [<CustomOperation("onseeked")>]
    member this.onseeked
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onseeked", callback)
    [<CustomOperation("onseeked")>]
    member this.onseeked
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onseeked", callback)
    [<CustomOperation("onseeking")>]
    member this.onseeking
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onseeking", callback)
    [<CustomOperation("onseeking")>]
    member this.onseeking
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onseeking", callback)
    [<CustomOperation("onstalled")>]
    member this.onstalled
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onstalled", callback)
    [<CustomOperation("onstalled")>]
    member this.onstalled
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onstalled", callback)
    [<CustomOperation("onstop")>]
    member this.onstop
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onstop", callback)
    [<CustomOperation("onstop")>]
    member this.onstop
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onstop", callback)
    [<CustomOperation("onsuspend")>]
    member this.onsuspend
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onsuspend", callback)
    [<CustomOperation("onsuspend")>]
    member this.onsuspend
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onsuspend", callback)
    [<CustomOperation("ontimeupdate")>]
    member this.ontimeupdate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "ontimeupdate", callback)
    [<CustomOperation("ontimeupdate")>]
    member this.ontimeupdate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "ontimeupdate", callback)
    [<CustomOperation("onvolumechange")>]
    member this.onvolumechange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onvolumechange", callback)
    [<CustomOperation("onvolumechange")>]
    member this.onvolumechange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onvolumechange", callback)
    [<CustomOperation("onwaiting")>]
    member this.onwaiting
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onwaiting", callback)
    [<CustomOperation("onwaiting")>]
    member this.onwaiting
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onwaiting", callback)
    [<CustomOperation("onloadstart")>]
    member this.onloadstart
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> unit
        )
        =
        this.callback (render, "onloadstart", callback)
    [<CustomOperation("onloadstart")>]
    member this.onloadstart
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.callback (render, "onloadstart", callback)
    [<CustomOperation("ontimeout")>]
    member this.ontimeout
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> unit
        )
        =
        this.callback (render, "ontimeout", callback)
    [<CustomOperation("ontimeout")>]
    member this.ontimeout
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.callback (render, "ontimeout", callback)
    [<CustomOperation("onabort")>]
    member this.onabort
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> unit
        )
        =
        this.callback (render, "onabort", callback)
    [<CustomOperation("onabort")>]
    member this.onabort
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.callback (render, "onabort", callback)
    [<CustomOperation("onload")>]
    member this.onload
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> unit
        )
        =
        this.callback (render, "onload", callback)
    [<CustomOperation("onload")>]
    member this.onload
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.callback (render, "onload", callback)
    [<CustomOperation("onloadend")>]
    member this.onloadend
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> unit
        )
        =
        this.callback (render, "onloadend", callback)
    [<CustomOperation("onloadend")>]
    member this.onloadend
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.callback (render, "onloadend", callback)
    [<CustomOperation("onprogress")>]
    member this.onprogress
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> unit
        )
        =
        this.callback (render, "onprogress", callback)
    [<CustomOperation("onprogress")>]
    member this.onprogress
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.callback (render, "onprogress", callback)
    [<CustomOperation("onerror")>]
    member this.onerror
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> unit
        )
        =
        this.callback (render, "onerror", callback)
    [<CustomOperation("onerror")>]
    member this.onerror
        (
            render: AttrRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.callback (render, "onerror", callback)
    [<CustomOperation("onactivate")>]
    member this.onactivate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onactivate", callback)
    [<CustomOperation("onactivate")>]
    member this.onactivate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onactivate", callback)
    [<CustomOperation("onbeforeactivate")>]
    member this.onbeforeactivate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onbeforeactivate", callback)
    [<CustomOperation("onbeforeactivate")>]
    member this.onbeforeactivate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onbeforeactivate", callback)
    [<CustomOperation("onbeforedeactivate")>]
    member this.onbeforedeactivate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onbeforedeactivate", callback)
    [<CustomOperation("onbeforedeactivate")>]
    member this.onbeforedeactivate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onbeforedeactivate", callback)
    [<CustomOperation("ondeactivate")>]
    member this.ondeactivate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "ondeactivate", callback)
    [<CustomOperation("ondeactivate")>]
    member this.ondeactivate
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "ondeactivate", callback)
    [<CustomOperation("onended")>]
    member this.onended
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onended", callback)
    [<CustomOperation("onended")>]
    member this.onended
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onended", callback)
    [<CustomOperation("onfullscreenchange")>]
    member this.onfullscreenchange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onfullscreenchange", callback)
    [<CustomOperation("onfullscreenchange")>]
    member this.onfullscreenchange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onfullscreenchange", callback)
    [<CustomOperation("onfullscreenerror")>]
    member this.onfullscreenerror
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onfullscreenerror", callback)
    [<CustomOperation("onfullscreenerror")>]
    member this.onfullscreenerror
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onfullscreenerror", callback)
    [<CustomOperation("onloadeddata")>]
    member this.onloadeddata
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onloadeddata", callback)
    [<CustomOperation("onloadeddata")>]
    member this.onloadeddata
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onloadeddata", callback)
    [<CustomOperation("onloadedmetadata")>]
    member this.onloadedmetadata
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onloadedmetadata", callback)
    [<CustomOperation("onloadedmetadata")>]
    member this.onloadedmetadata
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onloadedmetadata", callback)
    [<CustomOperation("onpointerlockchange")>]
    member this.onpointerlockchange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onpointerlockchange", callback)
    [<CustomOperation("onpointerlockchange")>]
    member this.onpointerlockchange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onpointerlockchange", callback)
    [<CustomOperation("onpointerlockerror")>]
    member this.onpointerlockerror
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onpointerlockerror", callback)
    [<CustomOperation("onpointerlockerror")>]
    member this.onpointerlockerror
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onpointerlockerror", callback)
    [<CustomOperation("onreadystatechange")>]
    member this.onreadystatechange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onreadystatechange", callback)
    [<CustomOperation("onreadystatechange")>]
    member this.onreadystatechange
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onreadystatechange", callback)
    [<CustomOperation("onscroll")>]
    member this.onscroll
        (
            render: AttrRenderFragment,
            callback: EventArgs -> unit
        )
        =
        this.callback (render, "onscroll", callback)
    [<CustomOperation("onscroll")>]
    member this.onscroll
        (
            render: AttrRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.callback (render, "onscroll", callback)
