namespace Fun.Blazor

open System
open System.Text
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators


type DomBuilder() =

    inherit FragmentBuilder()


    [<CustomOperation("style")>]
    member inline _.Style([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("style" => x)

    /// <summary>
    /// A list of strings to be applied as classes
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// div() {
    ///   classes [ "flex"; "flex-row"; "space-betwen" ]
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("classes")>]
    member inline _.classes([<InlineIfLambda>] render: AttrRenderFragment, v: string list) =
        render ==> (html.class' (String.concat " " v))

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
    member inline _.css([<InlineIfLambda>] render: AttrRenderFragment, css: string) =
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


    [<CustomOperation("styles")>]
    member inline _.styles([<InlineIfLambda>] render: AttrRenderFragment, v: (string * string) seq) =
        render ==> (html.style ((makeStyles v).ToString()))

    [<CustomOperation("class")>]
    member inline _.class'([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render ==> (html.class' v)
    [<CustomOperation("bindRef")>]
    member inline _.bindRef([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bindRef" => v)
    [<CustomOperation("key")>]
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("key" => v)
    [<CustomOperation("accept")>]
    member inline _.accept([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accept" => v)
    [<CustomOperation("acceptCharset")>]
    member inline _.acceptCharset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("acceptCharset" => v)
    [<CustomOperation("accesskey")>]
    member inline _.accesskey([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("accesskey" => v)
    [<CustomOperation("action")>]
    member inline _.action([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("action" => v)
    [<CustomOperation("align")>]
    member inline _.align([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("align" => v)
    [<CustomOperation("allow")>]
    member inline _.allow([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("allow" => v)
    [<CustomOperation("alt")>]
    member inline _.alt([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("alt" => v)
    [<CustomOperation("async")>]
    member inline _.async'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("async" => v)
    [<CustomOperation("autocapitalize")>]
    member inline _.autocapitalize([<InlineIfLambda>] render: AttrRenderFragment, v) =
        render ==> ("autocapitalize" => v)
    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autocomplete" => v)
    [<CustomOperation("autofocus")>]
    member inline _.autofocus([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autofocus" => v)
    [<CustomOperation("autoplay")>]
    member inline _.autoplay([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autoplay" => v)
    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" => v)
    [<CustomOperation("border")>]
    member inline _.border([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("border" => v)
    [<CustomOperation("buffered")>]
    member inline _.buffered([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("buffered" => v)
    [<CustomOperation("challenge")>]
    member inline _.challenge([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("challenge" => v)
    [<CustomOperation("charset")>]
    member inline _.charset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("charset" => v)
    [<CustomOperation("checked")>]
    member inline _.checked'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("checked" => v)
    [<CustomOperation("cite")>]
    member inline _.cite([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cite" => v)
    [<CustomOperation("code")>]
    member inline _.code([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("code" => v)
    [<CustomOperation("codebase")>]
    member inline _.codebase([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("codebase" => v)
    [<CustomOperation("color")>]
    member inline _.color([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("color" => v)
    [<CustomOperation("cols")>]
    member inline _.cols([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("cols" => v)
    [<CustomOperation("colspan")>]
    member inline _.colspan([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("colspan" => v)
    [<CustomOperation("content")>]
    member inline _.content([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("content" => v)
    [<CustomOperation("contenteditable")>]
    member inline _.contenteditable([<InlineIfLambda>] render: AttrRenderFragment, v) =
        render ==> ("contenteditable" => v)
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
    member inline _.dir([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dir" => v)
    [<CustomOperation("dirname")>]
    member inline _.dirname([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dirname" => v)
    [<CustomOperation("disabled")>]
    member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" => v)
    [<CustomOperation("download")>]
    member inline _.download([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("download" => v)
    [<CustomOperation("draggable")>]
    member inline _.draggable([<InlineIfLambda>] render: AttrRenderFragment, v: bool) =
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
    member inline _.hidden([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("hidden" => v)
    [<CustomOperation("high")>]
    member inline _.high([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("high" => v)
    [<CustomOperation("href")>]
    member inline _.href([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("href" => v)
    [<CustomOperation("hreflang")>]
    member inline _.hreflang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("hreflang" => v)
    [<CustomOperation("httpEquiv")>]
    member inline _.httpEquiv([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("httpEquiv" => v)
    [<CustomOperation("icon")>]
    member inline _.icon([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("icon" => v)
    [<CustomOperation("id")>]
    member inline _.id([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("id" => v)
    [<CustomOperation("importance")>]
    member inline _.importance([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("importance" => v)
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
    member inline _.label([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("label" => v)
    [<CustomOperation("lang")>]
    member inline _.lang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lang" => v)
    [<CustomOperation("language")>]
    member inline _.language([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("language" => v)
    [<CustomOperation("lazyload")>]
    member inline _.lazyload([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lazyload" => v)
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
    member inline _.name([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render ==> ("name" => v)
    [<CustomOperation("novalidate")>]
    member inline _.novalidate([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("novalidate" => v)
    [<CustomOperation("open")>]
    member inline _.open'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("open" => v)
    [<CustomOperation("optimum")>]
    member inline _.optimum([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("optimum" => v)
    [<CustomOperation("pattern")>]
    member inline _.pattern([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("pattern" => v)
    [<CustomOperation("ping")>]
    member inline _.ping([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("ping" => v)
    [<CustomOperation("placeholder")>]
    member inline _.placeholder([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("placeholder" => v)
    [<CustomOperation("poster")>]
    member inline _.poster([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("poster" => v)
    [<CustomOperation("preload")>]
    member inline _.preload([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("preload" => v)
    [<CustomOperation("readonly")>]
    member inline _.readonly([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("readonly" => v)
    [<CustomOperation("rel")>]
    member inline _.rel([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rel" => v)
    [<CustomOperation("required")>]
    member inline _.required([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("required" => v)
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
    member inline _.selected([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("selected" => v)
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
    member inline _.src([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("src" => v)
    [<CustomOperation("srcdoc")>]
    member inline _.srcdoc([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srcdoc" => v)
    [<CustomOperation("srclang")>]
    member inline _.srclang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srclang" => v)
    [<CustomOperation("srcset")>]
    member inline _.srcset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("srcset" => v)
    [<CustomOperation("start")>]
    member inline _.start([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("start" => v)
    [<CustomOperation("step")>]
    member inline _.step([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("step" => v)
    [<CustomOperation("summary")>]
    member inline _.summary([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("summary" => v)
    [<CustomOperation("tabindex")>]
    member inline _.tabindex([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("tabindex" => v)
    [<CustomOperation("target")>]
    member inline _.target([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("target" => v)
    [<CustomOperation("title'")>]
    member inline _.title'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("title" => v)
    [<CustomOperation("translate")>]
    member inline _.translate([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("translate" => v)
    [<CustomOperation("type")>]
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
    member inline this.onfocus
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: FocusEventArgs -> unit
        )
        =
        this.on (render, "focus", callback)

    [<CustomOperation("onfocusAsync")>]
    member inline this.onfocusAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: FocusEventArgs -> Task
        )
        =
        this.onTask (render, "focus", callback)

    [<CustomOperation("onblur")>]
    member inline this.onblur
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: FocusEventArgs -> unit
        )
        =
        this.on (render, "blur", callback)
    [<CustomOperation("onblurAsync")>]
    member inline this.onblurAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: FocusEventArgs -> Task
        )
        =
        this.onTask (render, "blur", callback)
    [<CustomOperation("onfocusin")>]
    member inline this.onfocusin
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: FocusEventArgs -> unit
        )
        =
        this.on (render, "focusin", callback)
    [<CustomOperation("onfocusinAsync")>]
    member inline this.onfocusinAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: FocusEventArgs -> Task
        )
        =
        this.onTask (render, "focusin", callback)
    [<CustomOperation("onfocusout")>]
    member inline this.onfocusout
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: FocusEventArgs -> unit
        )
        =
        this.on (render, "focusout", callback)
    [<CustomOperation("onfocusoutAsync")>]
    member inline this.onfocusoutAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: FocusEventArgs -> Task
        )
        =
        this.onTask (render, "focusout", callback)
    [<CustomOperation("onmouseover")>]
    member inline this.onmouseover
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "mouseover", callback)
    [<CustomOperation("onmouseoverAsync")>]
    member inline this.onmouseoverAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mouseover", callback)
    [<CustomOperation("onmouseout")>]
    member inline this.onmouseout
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "mouseout", callback)
    [<CustomOperation("onmouseoutAsync")>]
    member inline this.onmouseoutAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mouseout", callback)
    [<CustomOperation("onmousemove")>]
    member inline this.onmousemove
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "mousemove", callback)
    [<CustomOperation("onmousemoveAsync")>]
    member inline this.onmousemoveAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mousemove", callback)
    [<CustomOperation("onmousedown")>]
    member inline this.onmousedown
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "mousedown", callback)
    [<CustomOperation("onmousedownAsync")>]
    member inline this.onmousedownAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mousedown", callback)
    [<CustomOperation("onmouseup")>]
    member inline this.onmouseup
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "mouseup", callback)
    [<CustomOperation("onmouseupAsync")>]
    member inline this.onmouseupAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mouseup", callback)
    [<CustomOperation("onclick")>]
    member inline this.onclick
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "click", callback)
    [<CustomOperation("onclickAsync")>]
    member inline this.onclickAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "click", callback)
    [<CustomOperation("ondblclick")>]
    member inline this.ondblclick
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "dblclick", callback)
    [<CustomOperation("ondblclickAsync")>]
    member inline this.ondblclickAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "dblclick", callback)
    [<CustomOperation("onwheel")>]
    member inline this.onwheel
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "wheel", callback)
    [<CustomOperation("onwheelAsync")>]
    member inline this.onwheelAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "wheel", callback)
    [<CustomOperation("onmousewheel")>]
    member inline this.onmousewheel
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "mousewheel", callback)
    [<CustomOperation("onmousewheelAsync")>]
    member inline this.onmousewheelAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mousewheel", callback)
    [<CustomOperation("oncontextmenu")>]
    member inline this.oncontextmenu
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> unit
        )
        =
        this.on (render, "contextmenu", callback)
    [<CustomOperation("oncontextmenuAsync")>]
    member inline this.oncontextmenuAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "contextmenu", callback)
    [<CustomOperation("ondrag")>]
    member inline this.ondrag
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> unit
        )
        =
        this.on (render, "drag", callback)
    [<CustomOperation("ondragAsync")>]
    member inline this.ondragAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> Task
        )
        =
        this.onTask (render, "drag", callback)
    [<CustomOperation("ondragend")>]
    member inline this.ondragend
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> unit
        )
        =
        this.on (render, "dragend", callback)
    [<CustomOperation("ondragendAsync")>]
    member inline this.ondragendAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> Task
        )
        =
        this.onTask (render, "dragend", callback)
    [<CustomOperation("ondragenter")>]
    member inline this.ondragenter
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> unit
        )
        =
        this.on (render, "dragenter", callback)
    [<CustomOperation("ondragenterAsync")>]
    member inline this.ondragenterAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> Task
        )
        =
        this.onTask (render, "dragenter", callback)
    [<CustomOperation("ondragleave")>]
    member inline this.ondragleave
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> unit
        )
        =
        this.on (render, "dragleave", callback)
    [<CustomOperation("ondragleaveAsync")>]
    member inline this.ondragleaveAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> Task
        )
        =
        this.onTask (render, "dragleave", callback)
    [<CustomOperation("ondragover")>]
    member inline this.ondragover
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> unit
        )
        =
        this.on (render, "dragover", callback)
    [<CustomOperation("ondragoverAsync")>]
    member inline this.ondragoverAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> Task
        )
        =
        this.onTask (render, "dragover", callback)
    [<CustomOperation("ondragstart")>]
    member inline this.ondragstart
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> unit
        )
        =
        this.on (render, "dragstart", callback)
    [<CustomOperation("ondragstartAsync")>]
    member inline this.ondragstartAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> Task
        )
        =
        this.onTask (render, "dragstart", callback)
    [<CustomOperation("ondrop")>]
    member inline this.ondrop
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> unit
        )
        =
        this.on (render, "drop", callback)
    [<CustomOperation("ondropAsync")>]
    member inline this.ondropAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: DragEventArgs -> Task
        )
        =
        this.onTask (render, "drop", callback)
    [<CustomOperation("onkeydown")>]
    member inline this.onkeydown
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: KeyboardEventArgs -> unit
        )
        =
        this.on (render, "keydown", callback)
    [<CustomOperation("onkeydownAsync")>]
    member inline this.onkeydownAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: KeyboardEventArgs -> Task
        )
        =
        this.onTask (render, "keydown", callback)
    [<CustomOperation("onkeyup")>]
    member inline this.onkeyup
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: KeyboardEventArgs -> unit
        )
        =
        this.on (render, "keyup", callback)
    [<CustomOperation("onkeyupAsync")>]
    member inline this.onkeyupAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: KeyboardEventArgs -> Task
        )
        =
        this.onTask (render, "keyup", callback)
    [<CustomOperation("onkeypress")>]
    member inline this.onkeypress
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: KeyboardEventArgs -> unit
        )
        =
        this.on (render, "keypress", callback)
    [<CustomOperation("onkeypressAsync")>]
    member inline this.onkeypressAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: KeyboardEventArgs -> Task
        )
        =
        this.onTask (render, "keypress", callback)
    [<CustomOperation("onchange")>]
    member inline this.onchange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ChangeEventArgs -> unit
        )
        =
        this.on (render, "change", callback)
    [<CustomOperation("onchangeAsync")>]
    member inline this.onchangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ChangeEventArgs -> Task
        )
        =
        this.onTask (render, "change", callback)
    [<CustomOperation("oninput")>]
    member inline this.oninput
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ChangeEventArgs -> unit
        )
        =
        this.on (render, "input", callback)
    [<CustomOperation("oninputAsync")>]
    member inline this.oninputAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ChangeEventArgs -> Task
        )
        =
        this.onTask (render, "input", callback)
    [<CustomOperation("oninvalid")>]
    member inline this.oninvalid
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "invalid", callback)
    [<CustomOperation("oninvalidAsync")>]
    member inline this.oninvalidAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "invalid", callback)
    [<CustomOperation("onreset")>]
    member inline this.onreset
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "reset", callback)
    [<CustomOperation("onresetAsync")>]
    member inline this.onresetAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "reset", callback)
    [<CustomOperation("onselect")>]
    member inline this.onselect
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "select", callback)
    [<CustomOperation("onselectAsync")>]
    member inline this.onselectAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "select", callback)
    [<CustomOperation("onselectstart")>]
    member inline this.onselectstart
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "selectstart", callback)
    [<CustomOperation("onselectstartAsync")>]
    member inline this.onselectstartAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "selectstart", callback)
    [<CustomOperation("onselectionchange")>]
    member inline this.onselectionchange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "selectionchange", callback)
    [<CustomOperation("onselectionchangeAsync")>]
    member inline this.onselectionchangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "selectionchange", callback)
    [<CustomOperation("onsubmit")>]
    member inline this.onsubmit
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "submit", callback)
    [<CustomOperation("onsubmitAsync")>]
    member inline this.onsubmitAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "submit", callback)
    [<CustomOperation("onbeforecopy")>]
    member inline this.onbeforecopy
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "beforecopy", callback)
    [<CustomOperation("onbeforecopyAsync")>]
    member inline this.onbeforecopyAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "beforecopy", callback)
    [<CustomOperation("onbeforecut")>]
    member inline this.onbeforecut
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "beforecut", callback)
    [<CustomOperation("onbeforecutAsync")>]
    member inline this.onbeforecutAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "beforecut", callback)
    [<CustomOperation("onbeforepaste")>]
    member inline this.onbeforepaste
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "beforepaste", callback)
    [<CustomOperation("onbeforepasteAsync")>]
    member inline this.onbeforepasteAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "beforepaste", callback)
    [<CustomOperation("oncopy")>]
    member inline this.oncopy
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ClipboardEventArgs -> unit
        )
        =
        this.on (render, "copy", callback)
    [<CustomOperation("oncopyAsync")>]
    member inline this.oncopyAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ClipboardEventArgs -> Task
        )
        =
        this.onTask (render, "copy", callback)
    [<CustomOperation("oncut")>]
    member inline this.oncut
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ClipboardEventArgs -> unit
        )
        =
        this.on (render, "cut", callback)
    [<CustomOperation("oncutAsync")>]
    member inline this.oncutAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ClipboardEventArgs -> Task
        )
        =
        this.onTask (render, "cut", callback)
    [<CustomOperation("onpaste")>]
    member inline this.onpaste
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ClipboardEventArgs -> unit
        )
        =
        this.on (render, "paste", callback)
    [<CustomOperation("onpasteAsync")>]
    member inline this.onpasteAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ClipboardEventArgs -> Task
        )
        =
        this.onTask (render, "paste", callback)
    [<CustomOperation("ontouchcancel")>]
    member inline this.ontouchcancel
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> unit
        )
        =
        this.on (render, "touchcancel", callback)
    [<CustomOperation("ontouchcancelAsync")>]
    member inline this.ontouchcancelAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchcancel", callback)
    [<CustomOperation("ontouchend")>]
    member inline this.ontouchend
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> unit
        )
        =
        this.on (render, "touchend", callback)
    [<CustomOperation("ontouchendAsync")>]
    member inline this.ontouchendAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchend", callback)
    [<CustomOperation("ontouchmove")>]
    member inline this.ontouchmove
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> unit
        )
        =
        this.on (render, "touchmove", callback)
    [<CustomOperation("ontouchmoveAsync")>]
    member inline this.ontouchmoveAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchmove", callback)
    [<CustomOperation("ontouchstart")>]
    member inline this.ontouchstart
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> unit
        )
        =
        this.on (render, "touchstart", callback)
    [<CustomOperation("ontouchstartAsync")>]
    member inline this.ontouchstartAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchstart", callback)
    [<CustomOperation("ontouchenter")>]
    member inline this.ontouchenter
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> unit
        )
        =
        this.on (render, "touchenter", callback)
    [<CustomOperation("ontouchenterAsync")>]
    member inline this.ontouchenterAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchenter", callback)
    [<CustomOperation("ontouchleave")>]
    member inline this.ontouchleave
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> unit
        )
        =
        this.on (render, "touchleave", callback)
    [<CustomOperation("ontouchleaveAsync")>]
    member inline this.ontouchleaveAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchleave", callback)
    [<CustomOperation("onpointercapture")>]
    member inline this.onpointercapture
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointercapture", callback)
    [<CustomOperation("onpointercaptureAsync")>]
    member inline this.onpointercaptureAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointercapture", callback)
    [<CustomOperation("onlostpointercapture")>]
    member inline this.onlostpointercapture
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "lostpointercapture", callback)
    [<CustomOperation("onlostpointercaptureAsync")>]
    member inline this.onlostpointercaptureAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "lostpointercapture", callback)
    [<CustomOperation("onpointercancel")>]
    member inline this.onpointercancel
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointercancel", callback)
    [<CustomOperation("onpointercancelAsync")>]
    member inline this.onpointercancelAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointercancel", callback)
    [<CustomOperation("onpointerdown")>]
    member inline this.onpointerdown
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointerdown", callback)
    [<CustomOperation("onpointerdownAsync")>]
    member inline this.onpointerdownAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerdown", callback)
    [<CustomOperation("onpointerenter")>]
    member inline this.onpointerenter
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointerenter", callback)
    [<CustomOperation("onpointerenterAsync")>]
    member inline this.onpointerenterAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerenter", callback)
    [<CustomOperation("onpointerleave")>]
    member inline this.onpointerleave
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointerleave", callback)
    [<CustomOperation("onpointerleaveAsync")>]
    member inline this.onpointerleaveAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerleave", callback)
    [<CustomOperation("onpointermove")>]
    member inline this.onpointermove
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointermove", callback)
    [<CustomOperation("onpointermoveAsync")>]
    member inline this.onpointermoveAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointermove", callback)
    [<CustomOperation("onpointerout")>]
    member inline this.onpointerout
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointerout", callback)
    [<CustomOperation("onpointeroutAsync")>]
    member inline this.onpointeroutAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerout", callback)
    [<CustomOperation("onpointerover")>]
    member inline this.onpointerover
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointerover", callback)
    [<CustomOperation("onpointeroverAsync")>]
    member inline this.onpointeroverAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerover", callback)
    [<CustomOperation("onpointerup")>]
    member inline this.onpointerup
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointerup", callback)
    [<CustomOperation("onpointerupAsync")>]
    member inline this.onpointerupAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerup", callback)
    [<CustomOperation("oncanplay")>]
    member inline this.oncanplay
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "canplay", callback)
    [<CustomOperation("oncanplayAsync")>]
    member inline this.oncanplayAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "canplay", callback)
    [<CustomOperation("oncanplaythrough")>]
    member inline this.oncanplaythrough
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "canplaythrough", callback)
    [<CustomOperation("oncanplaythroughAsync")>]
    member inline this.oncanplaythroughAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "canplaythrough", callback)
    [<CustomOperation("oncuechange")>]
    member inline this.oncuechange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "cuechange", callback)
    [<CustomOperation("oncuechangeAsync")>]
    member inline this.oncuechangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "cuechange", callback)
    [<CustomOperation("ondurationchange")>]
    member inline this.ondurationchange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "durationchange", callback)
    [<CustomOperation("ondurationchangeAsync")>]
    member inline this.ondurationchangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "durationchange", callback)
    [<CustomOperation("onemptied")>]
    member inline this.onemptied
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "emptied", callback)
    [<CustomOperation("onemptiedAsync")>]
    member inline this.onemptiedAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "emptied", callback)
    [<CustomOperation("onpause")>]
    member inline this.onpause
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "pause", callback)
    [<CustomOperation("onpauseAsync")>]
    member inline this.onpauseAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "pause", callback)
    [<CustomOperation("onplay")>]
    member inline this.onplay
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "play", callback)
    [<CustomOperation("onplayAsync")>]
    member inline this.onplayAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "play", callback)
    [<CustomOperation("onplaying")>]
    member inline this.onplaying
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "playing", callback)
    [<CustomOperation("onplayingAsync")>]
    member inline this.onplayingAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "playing", callback)
    [<CustomOperation("onratechange")>]
    member inline this.onratechange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "ratechange", callback)
    [<CustomOperation("onratechangeAsync")>]
    member inline this.onratechangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "ratechange", callback)
    [<CustomOperation("onseeked")>]
    member inline this.onseeked
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "seeked", callback)
    [<CustomOperation("onseekedAsync")>]
    member inline this.onseekedAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "seeked", callback)
    [<CustomOperation("onseeking")>]
    member inline this.onseeking
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "seeking", callback)
    [<CustomOperation("onseekingAsync")>]
    member inline this.onseekingAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "seeking", callback)
    [<CustomOperation("onstalled")>]
    member inline this.onstalled
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "stalled", callback)
    [<CustomOperation("onstalledAsync")>]
    member inline this.onstalledAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "stalled", callback)
    [<CustomOperation("onstop")>]
    member inline this.onstop
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "stop", callback)
    [<CustomOperation("onstopAsync")>]
    member inline this.onstopAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "stop", callback)
    [<CustomOperation("onsuspend")>]
    member inline this.onsuspend
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "suspend", callback)
    [<CustomOperation("onsuspendAsync")>]
    member inline this.onsuspendAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "suspend", callback)
    [<CustomOperation("ontimeupdate")>]
    member inline this.ontimeupdate
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "timeupdate", callback)
    [<CustomOperation("ontimeupdateAsync")>]
    member inline this.ontimeupdateAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "timeupdate", callback)
    [<CustomOperation("onvolumechange")>]
    member inline this.onvolumechange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "volumechange", callback)
    [<CustomOperation("onvolumechangeAsync")>]
    member inline this.onvolumechangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "volumechange", callback)
    [<CustomOperation("onwaiting")>]
    member inline this.onwaiting
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "waiting", callback)
    [<CustomOperation("onwaitingAsync")>]
    member inline this.onwaitingAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "waiting", callback)
    [<CustomOperation("onloadstart")>]
    member inline this.onloadstart
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> unit
        )
        =
        this.on (render, "loadstart", callback)
    [<CustomOperation("onloadstartAsync")>]
    member inline this.onloadstartAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "loadstart", callback)
    [<CustomOperation("ontimeout")>]
    member inline this.ontimeout
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> unit
        )
        =
        this.on (render, "timeout", callback)
    [<CustomOperation("ontimeoutAsync")>]
    member inline this.ontimeoutAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "timeout", callback)
    [<CustomOperation("onabort")>]
    member inline this.onabort
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> unit
        )
        =
        this.on (render, "abort", callback)
    [<CustomOperation("onabortAsync")>]
    member inline this.onabortAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "abort", callback)
    [<CustomOperation("onload")>]
    member inline this.onload
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> unit
        )
        =
        this.on (render, "load", callback)
    [<CustomOperation("onloadAsync")>]
    member inline this.onloadAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "load", callback)
    [<CustomOperation("onloadend")>]
    member inline this.onloadend
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> unit
        )
        =
        this.on (render, "loadend", callback)
    [<CustomOperation("onloadendAsync")>]
    member inline this.onloadendAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "loadend", callback)
    [<CustomOperation("onprogress")>]
    member inline this.onprogress
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> unit
        )
        =
        this.on (render, "progress", callback)
    [<CustomOperation("onprogressAsync")>]
    member inline this.onprogressAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "progress", callback)
    [<CustomOperation("onerror")>]
    member inline this.onerror
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> unit
        )
        =
        this.on (render, "error", callback)
    [<CustomOperation("onerrorAsync")>]
    member inline this.onerrorAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "error", callback)
    [<CustomOperation("onactivate")>]
    member inline this.onactivate
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "activate", callback)
    [<CustomOperation("onactivateAsync")>]
    member inline this.onactivateAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "activate", callback)
    [<CustomOperation("onbeforeactivate")>]
    member inline this.onbeforeactivate
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "beforeactivate", callback)
    [<CustomOperation("onbeforeactivateAsync")>]
    member inline this.onbeforeactivateAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "beforeactivate", callback)
    [<CustomOperation("onbeforedeactivate")>]
    member inline this.onbeforedeactivate
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "beforedeactivate", callback)
    [<CustomOperation("onbeforedeactivateAsync")>]
    member inline this.onbeforedeactivateAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "beforedeactivate", callback)
    [<CustomOperation("ondeactivate")>]
    member inline this.ondeactivate
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "deactivate", callback)
    [<CustomOperation("ondeactivateAsync")>]
    member inline this.ondeactivateAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "deactivate", callback)
    [<CustomOperation("onended")>]
    member inline this.onended
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "ended", callback)
    [<CustomOperation("onendedAsync")>]
    member inline this.onendedAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "ended", callback)
    [<CustomOperation("onfullscreenchange")>]
    member inline this.onfullscreenchange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "fullscreenchange", callback)
    [<CustomOperation("onfullscreenchangeAsync")>]
    member inline this.onfullscreenchangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "fullscreenchange", callback)
    [<CustomOperation("onfullscreenerror")>]
    member inline this.onfullscreenerror
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "fullscreenerror", callback)
    [<CustomOperation("onfullscreenerrorAsync")>]
    member inline this.onfullscreenerrorAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "fullscreenerror", callback)
    [<CustomOperation("onloadeddata")>]
    member inline this.onloadeddata
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "loadeddata", callback)
    [<CustomOperation("onloadeddataAsync")>]
    member inline this.onloadeddataAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "loadeddata", callback)
    [<CustomOperation("onloadedmetadata")>]
    member inline this.onloadedmetadata
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "loadedmetadata", callback)
    [<CustomOperation("onloadedmetadataAsync")>]
    member inline this.onloadedmetadataAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "loadedmetadata", callback)
    [<CustomOperation("onpointerlockchange")>]
    member inline this.onpointerlockchange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "pointerlockchange", callback)
    [<CustomOperation("onpointerlockchangeAsync")>]
    member inline this.onpointerlockchangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "pointerlockchange", callback)
    [<CustomOperation("onpointerlockerror")>]
    member inline this.onpointerlockerror
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "pointerlockerror", callback)
    [<CustomOperation("onpointerlockerrorAsync")>]
    member inline this.onpointerlockerrorAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "pointerlockerror", callback)
    [<CustomOperation("onreadystatechange")>]
    member inline this.onreadystatechange
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "readystatechange", callback)
    [<CustomOperation("onreadystatechangeAsync")>]
    member inline this.onreadystatechangeAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "readystatechange", callback)
    [<CustomOperation("onscroll")>]
    member inline this.onscroll
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> unit
        )
        =
        this.on (render, "scroll", callback)
    [<CustomOperation("onscrollAsync")>]
    member inline this.onscrollAsync
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] callback: EventArgs -> Task
        )
        =
        this.onTask (render, "scroll", callback)


type EltBuilder(name) =
    inherit DomBuilder()

    member _.Name: string = name

    member inline this.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, this.Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    member inline this.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, this.Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

        
    member inline _.Yield(x: EltBuilder) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield<'T, 'T1 when 'T :> IComponentBuilder<'T1>>(_: 'T) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T1>(index)
            builder.CloseComponent()
            index + 1
        )


and IComponentBuilder<'T when 'T :> Microsoft.AspNetCore.Components.IComponent> = interface end


and ComponentBuilder<'T when 'T :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FragmentBuilder()

    interface IComponentBuilder<'T>

    member inline _.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    member inline _.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )


    member inline _.Yield(x: EltBuilder) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield<'T, 'T1 when 'T :> IComponentBuilder<'T1>>(_: 'T) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T1>(index)
            builder.CloseComponent()
            index + 1
        )


    [<CustomOperation("key")>] 
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, k) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
            index
        )


and ComponentWithDomAttrBuilder<'T when 'T :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DomBuilder()
    
    interface IComponentBuilder<'T>

    member inline _.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    member inline _.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )


    member inline _.Yield(x: EltBuilder) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield<'T, 'T1 when 'T :> IComponentBuilder<'T1>>(_: 'T) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T1>(index)
            builder.CloseComponent()
            index + 1
        )


    [<CustomOperation("key")>] 
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, k) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
            index
        )


type StyleBuilder () =
    inherit Fun.Css.CssBuilder()

    member inline _.Run([<InlineIfLambda>] combine: Fun.Css.CombineKeyValue) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, "style", combine.Invoke(StringBuilder()))
            index + 1
        )


type EltWithChildBuilder(name) =
    inherit EltBuilder(name)

    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// // &lt;div>
    /// //   &lt;p>This is my content&lt;/p>
    /// // &lt;/div>
    /// let myText content =
    ///   p() {
    ///    class' "my-class"
    ///    childContent content
    ///   }
    /// div() {
    ///   childContent (myText "This is my content")
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] renderChild: NodeRenderFragment
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
    ///   childContent [ p() {}; p() {} }
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: AttrRenderFragment, renders: NodeRenderFragment seq) =
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

    let base' = EltWithChildBuilder "base'"

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

    let style' = EltWithChildBuilder "style'"

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
    let inline js (x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, "script")
            builder.AddContent(index + 1, x)
            builder.CloseElement()
            index + 2
        )


    let inline doctype decl =
        NodeRenderFragment(fun _ builder index ->
            builder.AddMarkupContent(index, $"<!DOCTYPE {decl}>\n")
            index + 1
        )

    let inline stylesheet (x: string) =
        link {
            rel "stylesheet"
            href x
        }

    let inline baseUrl (x: string) = base' { href x }

    let styleBuilder = StyleBuilder()


    type html =
        
        static member inline comp<'T when 'T :> IComponent>() = ComponentBuilder<'T>()

        static member inline fromBuilder<'T, 'T1 when 'T :> ComponentBuilder<'T1>> (x: 'T) =
            NodeRenderFragment(fun _ builder index ->
                builder.OpenComponent<'T1>(index)
                builder.CloseComponent()
                index + 1
            )

        static member inline fromBuilder2<'T, 'T1 when 'T :> ComponentWithDomAttrBuilder<'T1>> (x: 'T) =
            NodeRenderFragment(fun _ builder index ->
                builder.OpenComponent<'T1>(index)
                builder.CloseComponent()
                index + 1
            )
