namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators
open Internal


type StyleBuilder() =
    inherit Fun.Css.CssBuilder()

    member inline _.Run([<InlineIfLambda>] combine: Fun.Css.Internal.CombineKeyValue) =
        AttrRenderFragment(fun _ builder index ->
            let sb = stringBuilderPool.Get()
            builder.AddAttribute(index, "style", combine.Invoke(sb).ToString())
            stringBuilderPool.Return sb
            index + 1
        )


type DomAttrBuilder() =

    member inline _.Yield(_: unit) = emptyAttr ()

    member inline _.Yield([<InlineIfLambda>] x: AttrRenderFragment) = x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> AttrRenderFragment) =
        AttrRenderFragment(fun c b i -> fn().Invoke(c, b, i))

    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: AttrRenderFragment) = render1 ==> render2

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> AttrRenderFragment) = render ==> (fn ())

    //member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> AttrRenderFragment) =
    //    renders |> Seq.map fn |> Seq.fold (==>) (emptyAttr ())

    member inline _.YieldFrom(renders: AttrRenderFragment seq) = renders |> Seq.fold (==>) (emptyAttr ())


    member inline _.Zero() = emptyAttr ()


    /// key for blazor
    [<CustomOperation("key")>]
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, k) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
            index
        )


    [<CustomOperation("callback")>]
    member inline _.callback([<InlineIfLambda>] render: AttrRenderFragment, eventName, [<InlineIfLambda>] callback: 'T -> unit) =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, eventName, EventCallback.Factory.Create(comp, Action<'T> callback))
            index + 1
        )

    [<CustomOperation("callback")>]
    member inline _.callback([<InlineIfLambda>] render: AttrRenderFragment, eventName, [<InlineIfLambda>] callback: 'T -> Task) =
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
            builder.AddEventStopPropagationAttribute(index, eventName, value)
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
    member inline _.classes([<InlineIfLambda>] render: AttrRenderFragment, v: string list) = render ==> (html.class' (String.concat " " v))

    [<CustomOperation("class'")>]
    member inline _.class'([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render ==> (html.class' v)

    [<CustomOperation("style'")>]
    member inline _.style([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.style x

    [<CustomOperation("styles")>]
    member _.styles(render: AttrRenderFragment, v: (string * string) seq) = render ==> html.style (makeStyles v)

    [<CustomOperation("bindRef")>]
    member inline _.bindRef([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bindRef" => v)
    [<CustomOperation("key'")>]
    member inline _.key'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("key" => v)
    [<CustomOperation("accept")>]
    member inline _.accept([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accept" => v)
    [<CustomOperation("acceptCharset")>]
    member inline _.acceptCharset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("acceptCharset" =>> v)
    [<CustomOperation("accesskey")>]
    member inline _.accesskey([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accesskey" =>> v)
    [<CustomOperation("action")>]
    member inline _.action([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("action" => v)
    [<CustomOperation("align")>]
    member inline _.align([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("align" => v)
    [<CustomOperation("allow")>]
    member inline _.allow([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("allow" => v)
    [<CustomOperation("alt")>]
    member inline _.alt([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("alt" =>> v)
    [<CustomOperation("async'")>]
    member inline _.async'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("async" => v)
    [<CustomOperation("autocapitalize")>]
    member inline _.autocapitalize([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocapitalize" => v)
    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" =>>> v)
    [<CustomOperation("autofocus")>]
    member inline _.autofocus([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autofocus" =>>> v)
    [<CustomOperation("autoplay")>]
    member inline _.autoplay([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autoplay" =>>> v)
    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" =>> v)
    [<CustomOperation("border")>]
    member inline _.border([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("border" => v)
    [<CustomOperation("buffered")>]
    member inline _.buffered([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("buffered" =>>> v)
    [<CustomOperation("challenge")>]
    member inline _.challenge([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("challenge" => v)
    [<CustomOperation("charset")>]
    member inline _.charset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("charset" =>> v)
    [<CustomOperation("checked")>]
    member inline _.checked'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("checked" =>>> v)
    [<CustomOperation("cite")>]
    member inline _.cite([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cite" => v)
    [<CustomOperation("code")>]
    member inline _.code([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("code" =>> v)
    [<CustomOperation("codebase")>]
    member inline _.codebase([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("codebase" =>> v)
    [<CustomOperation("color")>]
    member inline _.color([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("color" =>> v)
    [<CustomOperation("cols")>]
    member inline _.cols([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cols" => v)
    [<CustomOperation("colspan")>]
    member inline _.colspan([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("colspan" => v)
    [<CustomOperation("content")>]
    member inline _.content([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("content" => v)
    [<CustomOperation("contenteditable")>]
    member inline _.contenteditable([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("contenteditable" => v)
    [<CustomOperation("contextmenu")>]
    member inline _.contextmenu([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("contextmenu" => v)
    [<CustomOperation("controls")>]
    member inline _.controls([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("controls" => v)
    [<CustomOperation("coords")>]
    member inline _.coords([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("coords" => v)
    [<CustomOperation("crossorigin")>]
    member inline _.crossorigin([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("crossorigin" => v)
    [<CustomOperation("csp")>]
    member inline _.csp([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("csp" => v)
    [<CustomOperation("data")>]
    member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("data" => v)
    [<CustomOperation("datetime")>]
    member inline _.datetime([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("datetime" => v)
    [<CustomOperation("decoding")>]
    member inline _.decoding([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("decoding" => v)
    [<CustomOperation("default")>]
    member inline _.default'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("default" => v)
    [<CustomOperation("defer")>]
    member inline _.defer([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("defer" => v)
    [<CustomOperation("dir")>]
    member inline _.dir([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dir" =>> v)
    [<CustomOperation("dirname")>]
    member inline _.dirname([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dirname" =>> v)
    [<CustomOperation("disabled")>]
    member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)
    [<CustomOperation("download")>]
    member inline _.download([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("download" => v)
    [<CustomOperation("draggable")>]
    member _.draggable(render: AttrRenderFragment, v: bool) =
        render ==> ("draggable" => (if v then "true" else "false"))
    [<CustomOperation("dropzone")>]
    member inline _.dropzone([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dropzone" => v)
    [<CustomOperation("enctype")>]
    member inline _.enctype([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("enctype" => v)
    [<CustomOperation("for")>]
    member inline _.for'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("for" => v)
    [<CustomOperation("form")>]
    member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" => v)
    [<CustomOperation("formaction")>]
    member inline _.formaction([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formaction" => v)
    [<CustomOperation("headers")>]
    member inline _.headers([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("headers" => v)
    [<CustomOperation("height")>]
    member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)
    [<CustomOperation("hidden")>]
    member inline _.hidden([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("hidden" =>>> v)
    [<CustomOperation("high")>]
    member inline _.high([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("high" => v)
    [<CustomOperation("href")>]
    member inline _.href([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("href" =>> v)
    [<CustomOperation("hreflang")>]
    member inline _.hreflang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("hreflang" =>> v)
    [<CustomOperation("httpEquiv")>]
    member inline _.httpEquiv([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("httpEquiv" => v)
    [<CustomOperation("icon")>]
    member inline _.icon([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("icon" => v)
    [<CustomOperation("id")>]
    member inline _.id([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("id" => v)
    [<CustomOperation("importance")>]
    member inline _.importance([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("importance" =>>> v)
    [<CustomOperation("integrity")>]
    member inline _.integrity([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("integrity" => v)
    [<CustomOperation("ismap")>]
    member inline _.ismap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("ismap" => v)
    [<CustomOperation("itemprop")>]
    member inline _.itemprop([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("itemprop" => v)
    [<CustomOperation("keytype")>]
    member inline _.keytype([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("keytype" => v)
    [<CustomOperation("kind")>]
    member inline _.kind([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("kind" => v)
    [<CustomOperation("label")>]
    member inline _.label([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("label" =>> v)
    [<CustomOperation("lang")>]
    member inline _.lang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lang" =>> v)
    [<CustomOperation("language")>]
    member inline _.language([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("language" =>> v)
    [<CustomOperation("lazyload")>]
    member inline _.lazyload([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lazyload" =>>> v)
    [<CustomOperation("list")>]
    member inline _.list([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("list" => v)
    [<CustomOperation("loop")>]
    member inline _.loop([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("loop" => v)
    [<CustomOperation("low")>]
    member inline _.low([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("low" => v)
    [<CustomOperation("manifest")>]
    member inline _.manifest([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("manifest" => v)
    [<CustomOperation("max")>]
    member inline _.max([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("max" => v)
    [<CustomOperation("maxlength")>]
    member inline _.maxlength([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("maxlength" => v)
    [<CustomOperation("media")>]
    member inline _.media([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("media" => v)
    [<CustomOperation("method")>]
    member inline _.method([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("method" => v)
    [<CustomOperation("min")>]
    member inline _.min([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("min" => v)
    [<CustomOperation("minlength")>]
    member inline _.minlength([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("minlength" => v)
    [<CustomOperation("multiple")>]
    member inline _.multiple([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("multiple" => v)
    [<CustomOperation("muted")>]
    member inline _.muted([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("muted" => v)
    [<CustomOperation("name")>]
    member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render ==> ("name" =>> v)
    [<CustomOperation("novalidate")>]
    member inline _.novalidate([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("novalidate" => v)
    [<CustomOperation("open")>]
    member inline _.open'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("open" => v)
    [<CustomOperation("optimum")>]
    member inline _.optimum([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("optimum" => v)
    [<CustomOperation("pattern")>]
    member inline _.pattern([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("pattern" =>> v)
    [<CustomOperation("ping")>]
    member inline _.ping([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("ping" => v)
    [<CustomOperation("placeholder")>]
    member inline _.placeholder([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("placeholder" =>> v)
    [<CustomOperation("poster")>]
    member inline _.poster([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("poster" => v)
    [<CustomOperation("preload")>]
    member inline _.preload([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("preload" => v)
    [<CustomOperation("readonly")>]
    member inline _.readonly([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("readonly" =>>> v)
    [<CustomOperation("rel")>]
    member inline _.rel([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rel" => v)
    [<CustomOperation("required")>]
    member inline _.required([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("required" =>>> v)
    [<CustomOperation("reversed")>]
    member inline _.reversed([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("reversed" => v)
    [<CustomOperation("rows")>]
    member inline _.rows([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rows" => v)
    [<CustomOperation("rowspan")>]
    member inline _.rowspan([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rowspan" => v)
    [<CustomOperation("sandbox")>]
    member inline _.sandbox([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("sandbox" => v)
    [<CustomOperation("scope")>]
    member inline _.scope([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("scope" => v)
    [<CustomOperation("selected")>]
    member inline _.selected([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("selected" =>>> v)
    [<CustomOperation("shape")>]
    member inline _.shape([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("shape" => v)
    [<CustomOperation("size")>]
    member inline _.size([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("size" => v)
    [<CustomOperation("sizes")>]
    member inline _.sizes([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("sizes" => v)
    [<CustomOperation("slot")>]
    member inline _.slot([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("slot" => v)
    [<CustomOperation("span'")>]
    member inline _.span'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("span" => v)
    [<CustomOperation("spellcheck")>]
    member inline _.spellcheck([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("spellcheck" => v)
    [<CustomOperation("src")>]
    member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" =>> v)
    [<CustomOperation("srcdoc")>]
    member inline _.srcdoc([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srcdoc" =>> v)
    [<CustomOperation("srclang")>]
    member inline _.srclang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srclang" =>> v)
    [<CustomOperation("srcset")>]
    member inline _.srcset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srcset" => v)
    [<CustomOperation("start")>]
    member inline _.start([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("start" => v)
    [<CustomOperation("step")>]
    member inline _.step([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("step" => v)
    [<CustomOperation("summary")>]
    member inline _.summary([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("summary" =>> v)
    [<CustomOperation("tabindex")>]
    member inline _.tabindex([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("tabindex" => v)
    [<CustomOperation("target")>]
    member inline _.target([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("target" => v)
    [<CustomOperation("title'")>]
    member inline _.title'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("title" =>> v)
    [<CustomOperation("translate")>]
    member inline _.translate([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("translate" => v)
    [<CustomOperation("type'")>]
    member inline _.type'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("type" => v)
    [<CustomOperation("usemap")>]
    member inline _.usemap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("usemap" => v)
    [<CustomOperation("value")>]
    member inline _.value([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("value" => v)
    [<CustomOperation("width")>]
    member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)
    [<CustomOperation("wrap")>]
    member inline _.wrap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("wrap" => v)


    [<CustomOperation("onfocus")>]
    member inline this.onfocus([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
        this.callback (render, "onfocus", callback)
    [<CustomOperation("onfocus")>]
    member inline this.onfocus([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
        this.callback (render, "onfocus", callback)
    [<CustomOperation("onblur")>]
    member inline this.onblur([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
        this.callback (render, "onblur", callback)
    [<CustomOperation("onblur")>]
    member inline this.onblur([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
        this.callback (render, "onblur", callback)
    [<CustomOperation("onfocusin")>]
    member inline this.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
        this.callback (render, "onfocusin", callback)
    [<CustomOperation("onfocusin")>]
    member inline this.onfocusin([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
        this.callback (render, "onfocusin", callback)
    [<CustomOperation("onfocusout")>]
    member inline this.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> unit) =
        this.callback (render, "onfocusout", callback)
    [<CustomOperation("onfocusout")>]
    member inline this.onfocusout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: FocusEventArgs -> Task) =
        this.callback (render, "onfocusout", callback)
    [<CustomOperation("onmouseover")>]
    member inline this.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "onmouseover", callback)
    [<CustomOperation("onmouseover")>]
    member inline this.onmouseover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "onmouseover", callback)
    [<CustomOperation("onmouseout")>]
    member inline this.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "onmouseout", callback)
    [<CustomOperation("onmouseout")>]
    member inline this.onmouseout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "onmouseout", callback)
    [<CustomOperation("onmousemove")>]
    member inline this.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "onmousemove", callback)
    [<CustomOperation("onmousemove")>]
    member inline this.onmousemove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "onmousemove", callback)
    [<CustomOperation("onmousedown")>]
    member inline this.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "onmousedown", callback)
    [<CustomOperation("onmousedown")>]
    member inline this.onmousedown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "onmousedown", callback)
    [<CustomOperation("onmouseup")>]
    member inline this.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "onmouseup", callback)
    [<CustomOperation("onmouseup")>]
    member inline this.onmouseup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "onmouseup", callback)
    [<CustomOperation("onclick")>]
    member inline this.onclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "onclick", callback)
    [<CustomOperation("onclick")>]
    member inline this.onclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "onclick", callback)
    [<CustomOperation("ondblclick")>]
    member inline this.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "ondblclick", callback)
    [<CustomOperation("ondblclick")>]
    member inline this.ondblclick([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "ondblclick", callback)
    [<CustomOperation("onwheel")>]
    member inline this.onwheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "onwheel", callback)
    [<CustomOperation("onwheel")>]
    member inline this.onwheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "onwheel", callback)
    [<CustomOperation("onmousewheel")>]
    member inline this.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "onmousewheel", callback)
    [<CustomOperation("onmousewheel")>]
    member inline this.onmousewheel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "onmousewheel", callback)
    [<CustomOperation("oncontextmenu")>]
    member inline this.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> unit) =
        this.callback (render, "oncontextmenu", callback)
    [<CustomOperation("oncontextmenu")>]
    member inline this.oncontextmenu([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: MouseEventArgs -> Task) =
        this.callback (render, "oncontextmenu", callback)
    [<CustomOperation("ondrag")>]
    member inline this.ondrag([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
        this.callback (render, "ondrag", callback)
    [<CustomOperation("ondrag")>]
    member inline this.ondrag([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
        this.callback (render, "ondrag", callback)
    [<CustomOperation("ondragend")>]
    member inline this.ondragend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
        this.callback (render, "ondragend", callback)
    [<CustomOperation("ondragend")>]
    member inline this.ondragend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
        this.callback (render, "ondragend", callback)
    [<CustomOperation("ondragenter")>]
    member inline this.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
        this.callback (render, "ondragenter", callback)
    [<CustomOperation("ondragenter")>]
    member inline this.ondragenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
        this.callback (render, "ondragenter", callback)
    [<CustomOperation("ondragleave")>]
    member inline this.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
        this.callback (render, "ondragleave", callback)
    [<CustomOperation("ondragleave")>]
    member inline this.ondragleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
        this.callback (render, "ondragleave", callback)
    [<CustomOperation("ondragover")>]
    member inline this.ondragover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
        this.callback (render, "ondragover", callback)
    [<CustomOperation("ondragover")>]
    member inline this.ondragover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
        this.callback (render, "ondragover", callback)
    [<CustomOperation("ondragstart")>]
    member inline this.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
        this.callback (render, "ondragstart", callback)
    [<CustomOperation("ondragstart")>]
    member inline this.ondragstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
        this.callback (render, "ondragstart", callback)
    [<CustomOperation("ondrop")>]
    member inline this.ondrop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> unit) =
        this.callback (render, "ondrop", callback)
    [<CustomOperation("ondrop")>]
    member inline this.ondrop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: DragEventArgs -> Task) =
        this.callback (render, "ondrop", callback)
    [<CustomOperation("onkeydown")>]
    member inline this.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
        this.callback (render, "onkeydown", callback)
    [<CustomOperation("onkeydown")>]
    member inline this.onkeydown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
        this.callback (render, "onkeydown", callback)
    [<CustomOperation("onkeyup")>]
    member inline this.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
        this.callback (render, "onkeyup", callback)
    [<CustomOperation("onkeyup")>]
    member inline this.onkeyup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
        this.callback (render, "onkeyup", callback)
    [<CustomOperation("onkeypress")>]
    member inline this.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> unit) =
        this.callback (render, "onkeypress", callback)
    [<CustomOperation("onkeypress")>]
    member inline this.onkeypress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: KeyboardEventArgs -> Task) =
        this.callback (render, "onkeypress", callback)
    [<CustomOperation("onchange")>]
    member inline this.onchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> unit) =
        this.callback (render, "onchange", callback)
    [<CustomOperation("onchange")>]
    member inline this.onchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task) =
        this.callback (render, "onchange", callback)
    [<CustomOperation("oninput")>]
    member inline this.oninput([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> unit) =
        this.callback (render, "oninput", callback)
    [<CustomOperation("oninput")>]
    member inline this.oninput([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ChangeEventArgs -> Task) =
        this.callback (render, "oninput", callback)
    [<CustomOperation("oninvalid")>]
    member inline this.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "oninvalid", callback)
    [<CustomOperation("oninvalid")>]
    member inline this.oninvalid([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "oninvalid", callback)
    [<CustomOperation("onreset")>]
    member inline this.onreset([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onreset", callback)
    [<CustomOperation("onreset")>]
    member inline this.onreset([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onreset", callback)
    [<CustomOperation("onselect")>]
    member inline this.onselect([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onselect", callback)
    [<CustomOperation("onselect")>]
    member inline this.onselect([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onselect", callback)
    [<CustomOperation("onselectstart")>]
    member inline this.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onselectstart", callback)
    [<CustomOperation("onselectstart")>]
    member inline this.onselectstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onselectstart", callback)
    [<CustomOperation("onselectionchange")>]
    member inline this.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onselectionchange", callback)
    [<CustomOperation("onselectionchange")>]
    member inline this.onselectionchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onselectionchange", callback)
    [<CustomOperation("onsubmit")>]
    member inline this.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onsubmit", callback)
    [<CustomOperation("onsubmit")>]
    member inline this.onsubmit([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onsubmit", callback)
    [<CustomOperation("onbeforecopy")>]
    member inline this.onbeforecopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onbeforecopy", callback)
    [<CustomOperation("onbeforecopy")>]
    member inline this.onbeforecopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onbeforecopy", callback)
    [<CustomOperation("onbeforecut")>]
    member inline this.onbeforecut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onbeforecut", callback)
    [<CustomOperation("onbeforecut")>]
    member inline this.onbeforecut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onbeforecut", callback)
    [<CustomOperation("onbeforepaste")>]
    member inline this.onbeforepaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onbeforepaste", callback)
    [<CustomOperation("onbeforepaste")>]
    member inline this.onbeforepaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onbeforepaste", callback)
    [<CustomOperation("oncopy")>]
    member inline this.oncopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
        this.callback (render, "oncopy", callback)
    [<CustomOperation("oncopy")>]
    member inline this.oncopy([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
        this.callback (render, "oncopy", callback)
    [<CustomOperation("oncut")>]
    member inline this.oncut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
        this.callback (render, "oncut", callback)
    [<CustomOperation("oncut")>]
    member inline this.oncut([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
        this.callback (render, "oncut", callback)
    [<CustomOperation("onpaste")>]
    member inline this.onpaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> unit) =
        this.callback (render, "onpaste", callback)
    [<CustomOperation("onpaste")>]
    member inline this.onpaste([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ClipboardEventArgs -> Task) =
        this.callback (render, "onpaste", callback)
    [<CustomOperation("ontouchcancel")>]
    member inline this.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
        this.callback (render, "ontouchcancel", callback)
    [<CustomOperation("ontouchcancel")>]
    member inline this.ontouchcancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
        this.callback (render, "ontouchcancel", callback)
    [<CustomOperation("ontouchend")>]
    member inline this.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
        this.callback (render, "ontouchend", callback)
    [<CustomOperation("ontouchend")>]
    member inline this.ontouchend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
        this.callback (render, "ontouchend", callback)
    [<CustomOperation("ontouchmove")>]
    member inline this.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
        this.callback (render, "ontouchmove", callback)
    [<CustomOperation("ontouchmove")>]
    member inline this.ontouchmove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
        this.callback (render, "ontouchmove", callback)
    [<CustomOperation("ontouchstart")>]
    member inline this.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
        this.callback (render, "ontouchstart", callback)
    [<CustomOperation("ontouchstart")>]
    member inline this.ontouchstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
        this.callback (render, "ontouchstart", callback)
    [<CustomOperation("ontouchenter")>]
    member inline this.ontouchenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
        this.callback (render, "ontouchenter", callback)
    [<CustomOperation("ontouchenter")>]
    member inline this.ontouchenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
        this.callback (render, "ontouchenter", callback)
    [<CustomOperation("ontouchleave")>]
    member inline this.ontouchleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> unit) =
        this.callback (render, "ontouchleave", callback)
    [<CustomOperation("ontouchleave")>]
    member inline this.ontouchleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: TouchEventArgs -> Task) =
        this.callback (render, "ontouchleave", callback)
    [<CustomOperation("onpointercapture")>]
    member inline this.onpointercapture([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointercapture", callback)
    [<CustomOperation("onpointercapture")>]
    member inline this.onpointercapture([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointercapture", callback)
    [<CustomOperation("onlostpointercapture")>]
    member inline this.onlostpointercapture([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onlostpointercapture", callback)
    [<CustomOperation("onlostpointercapture")>]
    member inline this.onlostpointercapture([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onlostpointercapture", callback)
    [<CustomOperation("onpointercancel")>]
    member inline this.onpointercancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointercancel", callback)
    [<CustomOperation("onpointercancel")>]
    member inline this.onpointercancel([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointercancel", callback)
    [<CustomOperation("onpointerdown")>]
    member inline this.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointerdown", callback)
    [<CustomOperation("onpointerdown")>]
    member inline this.onpointerdown([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointerdown", callback)
    [<CustomOperation("onpointerenter")>]
    member inline this.onpointerenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointerenter", callback)
    [<CustomOperation("onpointerenter")>]
    member inline this.onpointerenter([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointerenter", callback)
    [<CustomOperation("onpointerleave")>]
    member inline this.onpointerleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointerleave", callback)
    [<CustomOperation("onpointerleave")>]
    member inline this.onpointerleave([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointerleave", callback)
    [<CustomOperation("onpointermove")>]
    member inline this.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointermove", callback)
    [<CustomOperation("onpointermove")>]
    member inline this.onpointermove([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointermove", callback)
    [<CustomOperation("onpointerout")>]
    member inline this.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointerout", callback)
    [<CustomOperation("onpointerout")>]
    member inline this.onpointerout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointerout", callback)
    [<CustomOperation("onpointerover")>]
    member inline this.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointerover", callback)
    [<CustomOperation("onpointerover")>]
    member inline this.onpointerover([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointerover", callback)
    [<CustomOperation("onpointerup")>]
    member inline this.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> unit) =
        this.callback (render, "onpointerup", callback)
    [<CustomOperation("onpointerup")>]
    member inline this.onpointerup([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: PointerEventArgs -> Task) =
        this.callback (render, "onpointerup", callback)
    [<CustomOperation("oncanplay")>]
    member inline this.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "oncanplay", callback)
    [<CustomOperation("oncanplay")>]
    member inline this.oncanplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "oncanplay", callback)
    [<CustomOperation("oncanplaythrough")>]
    member inline this.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "oncanplaythrough", callback)
    [<CustomOperation("oncanplaythrough")>]
    member inline this.oncanplaythrough([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "oncanplaythrough", callback)
    [<CustomOperation("oncuechange")>]
    member inline this.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "oncuechange", callback)
    [<CustomOperation("oncuechange")>]
    member inline this.oncuechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "oncuechange", callback)
    [<CustomOperation("ondurationchange")>]
    member inline this.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "ondurationchange", callback)
    [<CustomOperation("ondurationchange")>]
    member inline this.ondurationchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "ondurationchange", callback)
    [<CustomOperation("onemptied")>]
    member inline this.onemptied([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onemptied", callback)
    [<CustomOperation("onemptied")>]
    member inline this.onemptied([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onemptied", callback)
    [<CustomOperation("onpause")>]
    member inline this.onpause([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onpause", callback)
    [<CustomOperation("onpause")>]
    member inline this.onpause([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onpause", callback)
    [<CustomOperation("onplay")>]
    member inline this.onplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onplay", callback)
    [<CustomOperation("onplay")>]
    member inline this.onplay([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onplay", callback)
    [<CustomOperation("onplaying")>]
    member inline this.onplaying([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onplaying", callback)
    [<CustomOperation("onplaying")>]
    member inline this.onplaying([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onplaying", callback)
    [<CustomOperation("onratechange")>]
    member inline this.onratechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onratechange", callback)
    [<CustomOperation("onratechange")>]
    member inline this.onratechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onratechange", callback)
    [<CustomOperation("onseeked")>]
    member inline this.onseeked([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onseeked", callback)
    [<CustomOperation("onseeked")>]
    member inline this.onseeked([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onseeked", callback)
    [<CustomOperation("onseeking")>]
    member inline this.onseeking([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onseeking", callback)
    [<CustomOperation("onseeking")>]
    member inline this.onseeking([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onseeking", callback)
    [<CustomOperation("onstalled")>]
    member inline this.onstalled([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onstalled", callback)
    [<CustomOperation("onstalled")>]
    member inline this.onstalled([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onstalled", callback)
    [<CustomOperation("onstop")>]
    member inline this.onstop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onstop", callback)
    [<CustomOperation("onstop")>]
    member inline this.onstop([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onstop", callback)
    [<CustomOperation("onsuspend")>]
    member inline this.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onsuspend", callback)
    [<CustomOperation("onsuspend")>]
    member inline this.onsuspend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onsuspend", callback)
    [<CustomOperation("ontimeupdate")>]
    member inline this.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "ontimeupdate", callback)
    [<CustomOperation("ontimeupdate")>]
    member inline this.ontimeupdate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "ontimeupdate", callback)
    [<CustomOperation("onvolumechange")>]
    member inline this.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onvolumechange", callback)
    [<CustomOperation("onvolumechange")>]
    member inline this.onvolumechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onvolumechange", callback)
    [<CustomOperation("onwaiting")>]
    member inline this.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onwaiting", callback)
    [<CustomOperation("onwaiting")>]
    member inline this.onwaiting([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onwaiting", callback)
    [<CustomOperation("onloadstart")>]
    member inline this.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
        this.callback (render, "onloadstart", callback)
    [<CustomOperation("onloadstart")>]
    member inline this.onloadstart([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
        this.callback (render, "onloadstart", callback)
    [<CustomOperation("ontimeout")>]
    member inline this.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
        this.callback (render, "ontimeout", callback)
    [<CustomOperation("ontimeout")>]
    member inline this.ontimeout([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
        this.callback (render, "ontimeout", callback)
    [<CustomOperation("onabort")>]
    member inline this.onabort([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
        this.callback (render, "onabort", callback)
    [<CustomOperation("onabort")>]
    member inline this.onabort([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
        this.callback (render, "onabort", callback)
    [<CustomOperation("onload")>]
    member inline this.onload([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
        this.callback (render, "onload", callback)
    [<CustomOperation("onload")>]
    member inline this.onload([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
        this.callback (render, "onload", callback)
    [<CustomOperation("onloadend")>]
    member inline this.onloadend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
        this.callback (render, "onloadend", callback)
    [<CustomOperation("onloadend")>]
    member inline this.onloadend([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
        this.callback (render, "onloadend", callback)
    [<CustomOperation("onprogress")>]
    member inline this.onprogress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
        this.callback (render, "onprogress", callback)
    [<CustomOperation("onprogress")>]
    member inline this.onprogress([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
        this.callback (render, "onprogress", callback)
    [<CustomOperation("onerror")>]
    member inline this.onerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> unit) =
        this.callback (render, "onerror", callback)
    [<CustomOperation("onerror")>]
    member inline this.onerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: ProgressEventArgs -> Task) =
        this.callback (render, "onerror", callback)
    [<CustomOperation("onactivate")>]
    member inline this.onactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onactivate", callback)
    [<CustomOperation("onactivate")>]
    member inline this.onactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onactivate", callback)
    [<CustomOperation("onbeforeactivate")>]
    member inline this.onbeforeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onbeforeactivate", callback)
    [<CustomOperation("onbeforeactivate")>]
    member inline this.onbeforeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onbeforeactivate", callback)
    [<CustomOperation("onbeforedeactivate")>]
    member inline this.onbeforedeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onbeforedeactivate", callback)
    [<CustomOperation("onbeforedeactivate")>]
    member inline this.onbeforedeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onbeforedeactivate", callback)
    [<CustomOperation("ondeactivate")>]
    member inline this.ondeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "ondeactivate", callback)
    [<CustomOperation("ondeactivate")>]
    member inline this.ondeactivate([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "ondeactivate", callback)
    [<CustomOperation("onended")>]
    member inline this.onended([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onended", callback)
    [<CustomOperation("onended")>]
    member inline this.onended([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onended", callback)
    [<CustomOperation("onfullscreenchange")>]
    member inline this.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onfullscreenchange", callback)
    [<CustomOperation("onfullscreenchange")>]
    member inline this.onfullscreenchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onfullscreenchange", callback)
    [<CustomOperation("onfullscreenerror")>]
    member inline this.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onfullscreenerror", callback)
    [<CustomOperation("onfullscreenerror")>]
    member inline this.onfullscreenerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onfullscreenerror", callback)
    [<CustomOperation("onloadeddata")>]
    member inline this.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onloadeddata", callback)
    [<CustomOperation("onloadeddata")>]
    member inline this.onloadeddata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onloadeddata", callback)
    [<CustomOperation("onloadedmetadata")>]
    member inline this.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onloadedmetadata", callback)
    [<CustomOperation("onloadedmetadata")>]
    member inline this.onloadedmetadata([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onloadedmetadata", callback)
    [<CustomOperation("onpointerlockchange")>]
    member inline this.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onpointerlockchange", callback)
    [<CustomOperation("onpointerlockchange")>]
    member inline this.onpointerlockchange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onpointerlockchange", callback)
    [<CustomOperation("onpointerlockerror")>]
    member inline this.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onpointerlockerror", callback)
    [<CustomOperation("onpointerlockerror")>]
    member inline this.onpointerlockerror([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onpointerlockerror", callback)
    [<CustomOperation("onreadystatechange")>]
    member inline this.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onreadystatechange", callback)
    [<CustomOperation("onreadystatechange")>]
    member inline this.onreadystatechange([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onreadystatechange", callback)
    [<CustomOperation("onscroll")>]
    member inline this.onscroll([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> unit) =
        this.callback (render, "onscroll", callback)
    [<CustomOperation("onscroll")>]
    member inline this.onscroll([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] callback: EventArgs -> Task) =
        this.callback (render, "onscroll", callback)
