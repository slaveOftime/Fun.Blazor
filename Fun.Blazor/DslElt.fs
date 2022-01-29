namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators


type EltWithDomAttrs(name) =

    inherit EltBuilder(name)


    [<CustomOperation("style")>]
    member inline _.Style([<InlineIfLambda>] render: FunRenderFragment, x: string) = render &&& ("style" => x)

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
    member inline _.classes([<InlineIfLambda>] render: FunRenderFragment, v: string list) =
        render &&& (html.class' (String.concat " " v))

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
    member inline _.css([<InlineIfLambda>] render: FunRenderFragment, css: string) =
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

        render &&& (html.style result)


    [<CustomOperation("styles")>]
    member inline _.styles([<InlineIfLambda>] render: FunRenderFragment, v: (string * string) seq) =
        render &&& (html.style ((makeStyles v).ToString()))

    [<CustomOperation("class'")>]
    member inline _.class'([<InlineIfLambda>] render: FunRenderFragment, v: string) = render &&& (html.class' v)
    [<CustomOperation("bindRef")>]
    member inline _.bindRef([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("bindRef" => v)
    [<CustomOperation("key")>]
    member inline _.key([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("key" => v)
    [<CustomOperation("accept")>]
    member inline _.accept([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("accept" => v)
    [<CustomOperation("acceptCharset")>]
    member inline _.acceptCharset([<InlineIfLambda>] render: FunRenderFragment, v: obj) =
        render &&& ("acceptCharset" => v)
    [<CustomOperation("accesskey")>]
    member inline _.accesskey([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("accesskey" => v)
    [<CustomOperation("action")>]
    member inline _.action([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("action" => v)
    [<CustomOperation("align")>]
    member inline _.align([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("align" => v)
    [<CustomOperation("allow")>]
    member inline _.allow([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("allow" => v)
    [<CustomOperation("alt")>]
    member inline _.alt([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("alt" => v)
    [<CustomOperation("async'")>]
    member inline _.async'([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("async'" => v)
    [<CustomOperation("autocapitalize")>]
    member inline _.autocapitalize([<InlineIfLambda>] render: FunRenderFragment, v: obj) =
        render &&& ("autocapitalize" => v)
    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete([<InlineIfLambda>] render: FunRenderFragment, v: obj) =
        render &&& ("autocomplete" => v)
    [<CustomOperation("autofocus")>]
    member inline _.autofocus([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("autofocus" => v)
    [<CustomOperation("autoplay")>]
    member inline _.autoplay([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("autoplay" => v)
    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("bgcolor" => v)
    [<CustomOperation("border")>]
    member inline _.border([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("border" => v)
    [<CustomOperation("buffered")>]
    member inline _.buffered([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("buffered" => v)
    [<CustomOperation("challenge")>]
    member inline _.challenge([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("challenge" => v)
    [<CustomOperation("charset")>]
    member inline _.charset([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("charset" => v)
    [<CustomOperation("checked'")>]
    member inline _.checked'([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("checked" => v)
    [<CustomOperation("cite")>]
    member inline _.cite([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("cite" => v)
    [<CustomOperation("code")>]
    member inline _.code([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("code" => v)
    [<CustomOperation("codebase")>]
    member inline _.codebase([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("codebase" => v)
    [<CustomOperation("color")>]
    member inline _.color([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("color" => v)
    [<CustomOperation("cols")>]
    member inline _.cols([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("cols" => v)
    [<CustomOperation("colspan")>]
    member inline _.colspan([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("colspan" => v)
    [<CustomOperation("content")>]
    member inline _.content([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("content" => v)
    [<CustomOperation("contenteditable")>]
    member inline _.contenteditable([<InlineIfLambda>] render: FunRenderFragment, v: obj) =
        render &&& ("contenteditable" => v)
    [<CustomOperation("contextmenu")>]
    member inline _.contextmenu([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("contextmenu" => v)
    [<CustomOperation("controls")>]
    member inline _.controls([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("controls" => v)
    [<CustomOperation("coords")>]
    member inline _.coords([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("coords" => v)
    [<CustomOperation("crossorigin")>]
    member inline _.crossorigin([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("crossorigin" => v)
    [<CustomOperation("csp")>]
    member inline _.csp([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("csp" => v)
    [<CustomOperation("data")>]
    member inline _.data([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("data" => v)
    [<CustomOperation("datetime")>]
    member inline _.datetime([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("datetime" => v)
    [<CustomOperation("decoding")>]
    member inline _.decoding([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("decoding" => v)
    [<CustomOperation("default'")>]
    member inline _.default'([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("default" => v)
    [<CustomOperation("defer")>]
    member inline _.defer([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("defer" => v)
    [<CustomOperation("dir")>]
    member inline _.dir([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("dir" => v)
    [<CustomOperation("dirname")>]
    member inline _.dirname([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("dirname" => v)
    [<CustomOperation("disabled")>]
    member inline _.disabled([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("disabled" => v)
    [<CustomOperation("download")>]
    member inline _.download([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("download" => v)
    [<CustomOperation("draggable")>]
    member inline _.draggable([<InlineIfLambda>] render: FunRenderFragment, v: bool) =
        render &&& ("draggable" => (if v then "true" else "false"))
    [<CustomOperation("dropzone")>]
    member inline _.dropzone([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("dropzone" => v)
    [<CustomOperation("enctype")>]
    member inline _.enctype([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("enctype" => v)
    [<CustomOperation("for'")>]
    member inline _.for'([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("for" => v)
    [<CustomOperation("form")>]
    member inline _.form([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("form" => v)
    [<CustomOperation("formaction")>]
    member inline _.formaction([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("formaction" => v)
    [<CustomOperation("headers")>]
    member inline _.headers([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("headers" => v)
    [<CustomOperation("height")>]
    member inline _.height([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("height" => v)
    [<CustomOperation("hidden")>]
    member inline _.hidden([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("hidden" => v)
    [<CustomOperation("high")>]
    member inline _.high([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("high" => v)
    [<CustomOperation("href")>]
    member inline _.href([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("href" => v)
    [<CustomOperation("hreflang")>]
    member inline _.hreflang([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("hreflang" => v)
    [<CustomOperation("httpEquiv")>]
    member inline _.httpEquiv([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("httpEquiv" => v)
    [<CustomOperation("icon")>]
    member inline _.icon([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("icon" => v)
    [<CustomOperation("id")>]
    member inline _.id([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("id" => v)
    [<CustomOperation("importance")>]
    member inline _.importance([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("importance" => v)
    [<CustomOperation("integrity")>]
    member inline _.integrity([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("integrity" => v)
    [<CustomOperation("ismap")>]
    member inline _.ismap([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("ismap" => v)
    [<CustomOperation("itemprop")>]
    member inline _.itemprop([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("itemprop" => v)
    [<CustomOperation("keytype")>]
    member inline _.keytype([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("keytype" => v)
    [<CustomOperation("kind")>]
    member inline _.kind([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("kind" => v)
    [<CustomOperation("label")>]
    member inline _.label([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("label" => v)
    [<CustomOperation("lang")>]
    member inline _.lang([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("lang" => v)
    [<CustomOperation("language")>]
    member inline _.language([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("language" => v)
    [<CustomOperation("lazyload")>]
    member inline _.lazyload([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("lazyload" => v)
    [<CustomOperation("list")>]
    member inline _.list([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("list" => v)
    [<CustomOperation("loop")>]
    member inline _.loop([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("loop" => v)
    [<CustomOperation("low")>]
    member inline _.low([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("low" => v)
    [<CustomOperation("manifest")>]
    member inline _.manifest([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("manifest" => v)
    [<CustomOperation("max")>]
    member inline _.max([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("max" => v)
    [<CustomOperation("maxlength")>]
    member inline _.maxlength([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("maxlength" => v)
    [<CustomOperation("media")>]
    member inline _.media([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("media" => v)
    [<CustomOperation("method")>]
    member inline _.method([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("method" => v)
    [<CustomOperation("min")>]
    member inline _.min([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("min" => v)
    [<CustomOperation("minlength")>]
    member inline _.minlength([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("minlength" => v)
    [<CustomOperation("multiple")>]
    member inline _.multiple([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("multiple" => v)
    [<CustomOperation("muted")>]
    member inline _.muted([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("muted" => v)
    [<CustomOperation("name")>]
    member inline _.name([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("name" => v)
    [<CustomOperation("novalidate")>]
    member inline _.novalidate([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("novalidate" => v)
    [<CustomOperation("open'")>]
    member inline _.open'([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("open" => v)
    [<CustomOperation("optimum")>]
    member inline _.optimum([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("optimum" => v)
    [<CustomOperation("pattern")>]
    member inline _.pattern([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("pattern" => v)
    [<CustomOperation("ping")>]
    member inline _.ping([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("ping" => v)
    [<CustomOperation("placeholder")>]
    member inline _.placeholder([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("placeholder" => v)
    [<CustomOperation("poster")>]
    member inline _.poster([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("poster" => v)
    [<CustomOperation("preload")>]
    member inline _.preload([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("preload" => v)
    [<CustomOperation("readonly")>]
    member inline _.readonly([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("readonly" => v)
    [<CustomOperation("rel")>]
    member inline _.rel([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("rel" => v)
    [<CustomOperation("required")>]
    member inline _.required([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("required" => v)
    [<CustomOperation("reversed")>]
    member inline _.reversed([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("reversed" => v)
    [<CustomOperation("rows")>]
    member inline _.rows([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("rows" => v)
    [<CustomOperation("rowspan")>]
    member inline _.rowspan([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("rowspan" => v)
    [<CustomOperation("sandbox")>]
    member inline _.sandbox([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("sandbox" => v)
    [<CustomOperation("scope")>]
    member inline _.scope([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("scope" => v)
    [<CustomOperation("selected")>]
    member inline _.selected([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("selected" => v)
    [<CustomOperation("shape")>]
    member inline _.shape([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("shape" => v)
    [<CustomOperation("size")>]
    member inline _.size([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("size" => v)
    [<CustomOperation("sizes")>]
    member inline _.sizes([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("sizes" => v)
    [<CustomOperation("slot")>]
    member inline _.slot([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("slot" => v)
    [<CustomOperation("span")>]
    member inline _.span([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("span" => v)
    [<CustomOperation("spellcheck")>]
    member inline _.spellcheck([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("spellcheck" => v)
    [<CustomOperation("src")>]
    member inline _.src([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("src" => v)
    [<CustomOperation("srcdoc")>]
    member inline _.srcdoc([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("srcdoc" => v)
    [<CustomOperation("srclang")>]
    member inline _.srclang([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("srclang" => v)
    [<CustomOperation("srcset")>]
    member inline _.srcset([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("srcset" => v)
    [<CustomOperation("start")>]
    member inline _.start([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("start" => v)
    [<CustomOperation("step")>]
    member inline _.step([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("step" => v)
    [<CustomOperation("style'")>]
    member inline _.style'([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("style" => v)
    [<CustomOperation("summary")>]
    member inline _.summary([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("summary" => v)
    [<CustomOperation("tabindex")>]
    member inline _.tabindex([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("tabindex" => v)
    [<CustomOperation("target")>]
    member inline _.target([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("target" => v)
    [<CustomOperation("title'")>]
    member inline _.title'([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("title" => v)
    [<CustomOperation("translate")>]
    member inline _.translate([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("translate" => v)
    [<CustomOperation("type'")>]
    member inline _.type'([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("type" => v)
    [<CustomOperation("usemap")>]
    member inline _.usemap([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("usemap" => v)
    [<CustomOperation("value")>]
    member inline _.value([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("value" => v)
    [<CustomOperation("width")>]
    member inline _.width([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("width" => v)
    [<CustomOperation("wrap")>]
    member inline _.wrap([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("wrap" => v)


    [<CustomOperation("onfocus")>]
    member inline this.onfocus([<InlineIfLambda>] render: FunRenderFragment, callback: FocusEventArgs -> unit) =
        this.on (render, "focus", callback)

    [<CustomOperation("onfocusAsync")>]
    member inline this.onfocusAsync([<InlineIfLambda>] render: FunRenderFragment, callback: FocusEventArgs -> Task) =
        this.onTask (render, "focus", callback)

    [<CustomOperation("onblur")>]
    member inline this.onblur([<InlineIfLambda>] render: FunRenderFragment, callback: FocusEventArgs -> unit) =
        this.on (render, "blur", callback)
    [<CustomOperation("onblurAsync")>]
    member inline this.onblurAsync([<InlineIfLambda>] render: FunRenderFragment, callback: FocusEventArgs -> Task) =
        this.onTask (render, "blur", callback)
    [<CustomOperation("onfocusin")>]
    member inline this.onfocusin([<InlineIfLambda>] render: FunRenderFragment, callback: FocusEventArgs -> unit) =
        this.on (render, "focusin", callback)
    [<CustomOperation("onfocusinAsync")>]
    member inline this.onfocusinAsync([<InlineIfLambda>] render: FunRenderFragment, callback: FocusEventArgs -> Task) =
        this.onTask (render, "focusin", callback)
    [<CustomOperation("onfocusout")>]
    member inline this.onfocusout([<InlineIfLambda>] render: FunRenderFragment, callback: FocusEventArgs -> unit) =
        this.on (render, "focusout", callback)
    [<CustomOperation("onfocusoutAsync")>]
    member inline this.onfocusoutAsync([<InlineIfLambda>] render: FunRenderFragment, callback: FocusEventArgs -> Task) =
        this.onTask (render, "focusout", callback)
    [<CustomOperation("onmouseover")>]
    member inline this.onmouseover([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "mouseover", callback)
    [<CustomOperation("onmouseoverAsync")>]
    member inline this.onmouseoverAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mouseover", callback)
    [<CustomOperation("onmouseout")>]
    member inline this.onmouseout([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "mouseout", callback)
    [<CustomOperation("onmouseoutAsync")>]
    member inline this.onmouseoutAsync([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> Task) =
        this.onTask (render, "mouseout", callback)
    [<CustomOperation("onmousemove")>]
    member inline this.onmousemove([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "mousemove", callback)
    [<CustomOperation("onmousemoveAsync")>]
    member inline this.onmousemoveAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mousemove", callback)
    [<CustomOperation("onmousedown")>]
    member inline this.onmousedown([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "mousedown", callback)
    [<CustomOperation("onmousedownAsync")>]
    member inline this.onmousedownAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mousedown", callback)
    [<CustomOperation("onmouseup")>]
    member inline this.onmouseup([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "mouseup", callback)
    [<CustomOperation("onmouseupAsync")>]
    member inline this.onmouseupAsync([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> Task) =
        this.onTask (render, "mouseup", callback)
    [<CustomOperation("onclick")>]
    member inline this.onclick([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "click", callback)
    [<CustomOperation("onclickAsync")>]
    member inline this.onclickAsync([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> Task) =
        this.onTask (render, "click", callback)
    [<CustomOperation("ondblclick")>]
    member inline this.ondblclick([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "dblclick", callback)
    [<CustomOperation("ondblclickAsync")>]
    member inline this.ondblclickAsync([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> Task) =
        this.onTask (render, "dblclick", callback)
    [<CustomOperation("onwheel")>]
    member inline this.onwheel([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "wheel", callback)
    [<CustomOperation("onwheelAsync")>]
    member inline this.onwheelAsync([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> Task) =
        this.onTask (render, "wheel", callback)
    [<CustomOperation("onmousewheel")>]
    member inline this.onmousewheel([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "mousewheel", callback)
    [<CustomOperation("onmousewheelAsync")>]
    member inline this.onmousewheelAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "mousewheel", callback)
    [<CustomOperation("oncontextmenu")>]
    member inline this.oncontextmenu([<InlineIfLambda>] render: FunRenderFragment, callback: MouseEventArgs -> unit) =
        this.on (render, "contextmenu", callback)
    [<CustomOperation("oncontextmenuAsync")>]
    member inline this.oncontextmenuAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: MouseEventArgs -> Task
        )
        =
        this.onTask (render, "contextmenu", callback)
    [<CustomOperation("ondrag")>]
    member inline this.ondrag([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> unit) =
        this.on (render, "drag", callback)
    [<CustomOperation("ondragAsync")>]
    member inline this.ondragAsync([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> Task) =
        this.onTask (render, "drag", callback)
    [<CustomOperation("ondragend")>]
    member inline this.ondragend([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> unit) =
        this.on (render, "dragend", callback)
    [<CustomOperation("ondragendAsync")>]
    member inline this.ondragendAsync([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> Task) =
        this.onTask (render, "dragend", callback)
    [<CustomOperation("ondragenter")>]
    member inline this.ondragenter([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> unit) =
        this.on (render, "dragenter", callback)
    [<CustomOperation("ondragenterAsync")>]
    member inline this.ondragenterAsync([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> Task) =
        this.onTask (render, "dragenter", callback)
    [<CustomOperation("ondragleave")>]
    member inline this.ondragleave([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> unit) =
        this.on (render, "dragleave", callback)
    [<CustomOperation("ondragleaveAsync")>]
    member inline this.ondragleaveAsync([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> Task) =
        this.onTask (render, "dragleave", callback)
    [<CustomOperation("ondragover")>]
    member inline this.ondragover([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> unit) =
        this.on (render, "dragover", callback)
    [<CustomOperation("ondragoverAsync")>]
    member inline this.ondragoverAsync([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> Task) =
        this.onTask (render, "dragover", callback)
    [<CustomOperation("ondragstart")>]
    member inline this.ondragstart([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> unit) =
        this.on (render, "dragstart", callback)
    [<CustomOperation("ondragstartAsync")>]
    member inline this.ondragstartAsync([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> Task) =
        this.onTask (render, "dragstart", callback)
    [<CustomOperation("ondrop")>]
    member inline this.ondrop([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> unit) =
        this.on (render, "drop", callback)
    [<CustomOperation("ondropAsync")>]
    member inline this.ondropAsync([<InlineIfLambda>] render: FunRenderFragment, callback: DragEventArgs -> Task) =
        this.onTask (render, "drop", callback)
    [<CustomOperation("onkeydown")>]
    member inline this.onkeydown([<InlineIfLambda>] render: FunRenderFragment, callback: KeyboardEventArgs -> unit) =
        this.on (render, "keydown", callback)
    [<CustomOperation("onkeydownAsync")>]
    member inline this.onkeydownAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: KeyboardEventArgs -> Task
        )
        =
        this.onTask (render, "keydown", callback)
    [<CustomOperation("onkeyup")>]
    member inline this.onkeyup([<InlineIfLambda>] render: FunRenderFragment, callback: KeyboardEventArgs -> unit) =
        this.on (render, "keyup", callback)
    [<CustomOperation("onkeyupAsync")>]
    member inline this.onkeyupAsync([<InlineIfLambda>] render: FunRenderFragment, callback: KeyboardEventArgs -> Task) =
        this.onTask (render, "keyup", callback)
    [<CustomOperation("onkeypress")>]
    member inline this.onkeypress([<InlineIfLambda>] render: FunRenderFragment, callback: KeyboardEventArgs -> unit) =
        this.on (render, "keypress", callback)
    [<CustomOperation("onkeypressAsync")>]
    member inline this.onkeypressAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: KeyboardEventArgs -> Task
        )
        =
        this.onTask (render, "keypress", callback)
    [<CustomOperation("onchange")>]
    member inline this.onchange([<InlineIfLambda>] render: FunRenderFragment, callback: ChangeEventArgs -> unit) =
        this.on (render, "change", callback)
    [<CustomOperation("onchangeAsync")>]
    member inline this.onchangeAsync([<InlineIfLambda>] render: FunRenderFragment, callback: ChangeEventArgs -> Task) =
        this.onTask (render, "change", callback)
    [<CustomOperation("oninput")>]
    member inline this.oninput([<InlineIfLambda>] render: FunRenderFragment, callback: ChangeEventArgs -> unit) =
        this.on (render, "input", callback)
    [<CustomOperation("oninputAsync")>]
    member inline this.oninputAsync([<InlineIfLambda>] render: FunRenderFragment, callback: ChangeEventArgs -> Task) =
        this.onTask (render, "input", callback)
    [<CustomOperation("oninvalid")>]
    member inline this.oninvalid([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "invalid", callback)
    [<CustomOperation("oninvalidAsync")>]
    member inline this.oninvalidAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "invalid", callback)
    [<CustomOperation("onreset")>]
    member inline this.onreset([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "reset", callback)
    [<CustomOperation("onresetAsync")>]
    member inline this.onresetAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "reset", callback)
    [<CustomOperation("onselect")>]
    member inline this.onselect([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "select", callback)
    [<CustomOperation("onselectAsync")>]
    member inline this.onselectAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "select", callback)
    [<CustomOperation("onselectstart")>]
    member inline this.onselectstart([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "selectstart", callback)
    [<CustomOperation("onselectstartAsync")>]
    member inline this.onselectstartAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "selectstart", callback)
    [<CustomOperation("onselectionchange")>]
    member inline this.onselectionchange([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "selectionchange", callback)
    [<CustomOperation("onselectionchangeAsync")>]
    member inline this.onselectionchangeAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "selectionchange", callback)
    [<CustomOperation("onsubmit")>]
    member inline this.onsubmit([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "submit", callback)
    [<CustomOperation("onsubmitAsync")>]
    member inline this.onsubmitAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "submit", callback)
    [<CustomOperation("onbeforecopy")>]
    member inline this.onbeforecopy([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "beforecopy", callback)
    [<CustomOperation("onbeforecopyAsync")>]
    member inline this.onbeforecopyAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "beforecopy", callback)
    [<CustomOperation("onbeforecut")>]
    member inline this.onbeforecut([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "beforecut", callback)
    [<CustomOperation("onbeforecutAsync")>]
    member inline this.onbeforecutAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "beforecut", callback)
    [<CustomOperation("onbeforepaste")>]
    member inline this.onbeforepaste([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "beforepaste", callback)
    [<CustomOperation("onbeforepasteAsync")>]
    member inline this.onbeforepasteAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "beforepaste", callback)
    [<CustomOperation("oncopy")>]
    member inline this.oncopy([<InlineIfLambda>] render: FunRenderFragment, callback: ClipboardEventArgs -> unit) =
        this.on (render, "copy", callback)
    [<CustomOperation("oncopyAsync")>]
    member inline this.oncopyAsync([<InlineIfLambda>] render: FunRenderFragment, callback: ClipboardEventArgs -> Task) =
        this.onTask (render, "copy", callback)
    [<CustomOperation("oncut")>]
    member inline this.oncut([<InlineIfLambda>] render: FunRenderFragment, callback: ClipboardEventArgs -> unit) =
        this.on (render, "cut", callback)
    [<CustomOperation("oncutAsync")>]
    member inline this.oncutAsync([<InlineIfLambda>] render: FunRenderFragment, callback: ClipboardEventArgs -> Task) =
        this.onTask (render, "cut", callback)
    [<CustomOperation("onpaste")>]
    member inline this.onpaste([<InlineIfLambda>] render: FunRenderFragment, callback: ClipboardEventArgs -> unit) =
        this.on (render, "paste", callback)
    [<CustomOperation("onpasteAsync")>]
    member inline this.onpasteAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: ClipboardEventArgs -> Task
        )
        =
        this.onTask (render, "paste", callback)
    [<CustomOperation("ontouchcancel")>]
    member inline this.ontouchcancel([<InlineIfLambda>] render: FunRenderFragment, callback: TouchEventArgs -> unit) =
        this.on (render, "touchcancel", callback)
    [<CustomOperation("ontouchcancelAsync")>]
    member inline this.ontouchcancelAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchcancel", callback)
    [<CustomOperation("ontouchend")>]
    member inline this.ontouchend([<InlineIfLambda>] render: FunRenderFragment, callback: TouchEventArgs -> unit) =
        this.on (render, "touchend", callback)
    [<CustomOperation("ontouchendAsync")>]
    member inline this.ontouchendAsync([<InlineIfLambda>] render: FunRenderFragment, callback: TouchEventArgs -> Task) =
        this.onTask (render, "touchend", callback)
    [<CustomOperation("ontouchmove")>]
    member inline this.ontouchmove([<InlineIfLambda>] render: FunRenderFragment, callback: TouchEventArgs -> unit) =
        this.on (render, "touchmove", callback)
    [<CustomOperation("ontouchmoveAsync")>]
    member inline this.ontouchmoveAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchmove", callback)
    [<CustomOperation("ontouchstart")>]
    member inline this.ontouchstart([<InlineIfLambda>] render: FunRenderFragment, callback: TouchEventArgs -> unit) =
        this.on (render, "touchstart", callback)
    [<CustomOperation("ontouchstartAsync")>]
    member inline this.ontouchstartAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchstart", callback)
    [<CustomOperation("ontouchenter")>]
    member inline this.ontouchenter([<InlineIfLambda>] render: FunRenderFragment, callback: TouchEventArgs -> unit) =
        this.on (render, "touchenter", callback)
    [<CustomOperation("ontouchenterAsync")>]
    member inline this.ontouchenterAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchenter", callback)
    [<CustomOperation("ontouchleave")>]
    member inline this.ontouchleave([<InlineIfLambda>] render: FunRenderFragment, callback: TouchEventArgs -> unit) =
        this.on (render, "touchleave", callback)
    [<CustomOperation("ontouchleaveAsync")>]
    member inline this.ontouchleaveAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: TouchEventArgs -> Task
        )
        =
        this.onTask (render, "touchleave", callback)
    [<CustomOperation("onpointercapture")>]
    member inline this.onpointercapture
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointercapture", callback)
    [<CustomOperation("onpointercaptureAsync")>]
    member inline this.onpointercaptureAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointercapture", callback)
    [<CustomOperation("onlostpointercapture")>]
    member inline this.onlostpointercapture
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "lostpointercapture", callback)
    [<CustomOperation("onlostpointercaptureAsync")>]
    member inline this.onlostpointercaptureAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "lostpointercapture", callback)
    [<CustomOperation("onpointercancel")>]
    member inline this.onpointercancel
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointercancel", callback)
    [<CustomOperation("onpointercancelAsync")>]
    member inline this.onpointercancelAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointercancel", callback)
    [<CustomOperation("onpointerdown")>]
    member inline this.onpointerdown([<InlineIfLambda>] render: FunRenderFragment, callback: PointerEventArgs -> unit) =
        this.on (render, "pointerdown", callback)
    [<CustomOperation("onpointerdownAsync")>]
    member inline this.onpointerdownAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerdown", callback)
    [<CustomOperation("onpointerenter")>]
    member inline this.onpointerenter
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointerenter", callback)
    [<CustomOperation("onpointerenterAsync")>]
    member inline this.onpointerenterAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerenter", callback)
    [<CustomOperation("onpointerleave")>]
    member inline this.onpointerleave
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> unit
        )
        =
        this.on (render, "pointerleave", callback)
    [<CustomOperation("onpointerleaveAsync")>]
    member inline this.onpointerleaveAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerleave", callback)
    [<CustomOperation("onpointermove")>]
    member inline this.onpointermove([<InlineIfLambda>] render: FunRenderFragment, callback: PointerEventArgs -> unit) =
        this.on (render, "pointermove", callback)
    [<CustomOperation("onpointermoveAsync")>]
    member inline this.onpointermoveAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointermove", callback)
    [<CustomOperation("onpointerout")>]
    member inline this.onpointerout([<InlineIfLambda>] render: FunRenderFragment, callback: PointerEventArgs -> unit) =
        this.on (render, "pointerout", callback)
    [<CustomOperation("onpointeroutAsync")>]
    member inline this.onpointeroutAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerout", callback)
    [<CustomOperation("onpointerover")>]
    member inline this.onpointerover([<InlineIfLambda>] render: FunRenderFragment, callback: PointerEventArgs -> unit) =
        this.on (render, "pointerover", callback)
    [<CustomOperation("onpointeroverAsync")>]
    member inline this.onpointeroverAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerover", callback)
    [<CustomOperation("onpointerup")>]
    member inline this.onpointerup([<InlineIfLambda>] render: FunRenderFragment, callback: PointerEventArgs -> unit) =
        this.on (render, "pointerup", callback)
    [<CustomOperation("onpointerupAsync")>]
    member inline this.onpointerupAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: PointerEventArgs -> Task
        )
        =
        this.onTask (render, "pointerup", callback)
    [<CustomOperation("oncanplay")>]
    member inline this.oncanplay([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "canplay", callback)
    [<CustomOperation("oncanplayAsync")>]
    member inline this.oncanplayAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "canplay", callback)
    [<CustomOperation("oncanplaythrough")>]
    member inline this.oncanplaythrough([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "canplaythrough", callback)
    [<CustomOperation("oncanplaythroughAsync")>]
    member inline this.oncanplaythroughAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "canplaythrough", callback)
    [<CustomOperation("oncuechange")>]
    member inline this.oncuechange([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "cuechange", callback)
    [<CustomOperation("oncuechangeAsync")>]
    member inline this.oncuechangeAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "cuechange", callback)
    [<CustomOperation("ondurationchange")>]
    member inline this.ondurationchange([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "durationchange", callback)
    [<CustomOperation("ondurationchangeAsync")>]
    member inline this.ondurationchangeAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "durationchange", callback)
    [<CustomOperation("onemptied")>]
    member inline this.onemptied([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "emptied", callback)
    [<CustomOperation("onemptiedAsync")>]
    member inline this.onemptiedAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "emptied", callback)
    [<CustomOperation("onpause")>]
    member inline this.onpause([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "pause", callback)
    [<CustomOperation("onpauseAsync")>]
    member inline this.onpauseAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "pause", callback)
    [<CustomOperation("onplay")>]
    member inline this.onplay([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "play", callback)
    [<CustomOperation("onplayAsync")>]
    member inline this.onplayAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "play", callback)
    [<CustomOperation("onplaying")>]
    member inline this.onplaying([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "playing", callback)
    [<CustomOperation("onplayingAsync")>]
    member inline this.onplayingAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "playing", callback)
    [<CustomOperation("onratechange")>]
    member inline this.onratechange([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "ratechange", callback)
    [<CustomOperation("onratechangeAsync")>]
    member inline this.onratechangeAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "ratechange", callback)
    [<CustomOperation("onseeked")>]
    member inline this.onseeked([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "seeked", callback)
    [<CustomOperation("onseekedAsync")>]
    member inline this.onseekedAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "seeked", callback)
    [<CustomOperation("onseeking")>]
    member inline this.onseeking([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "seeking", callback)
    [<CustomOperation("onseekingAsync")>]
    member inline this.onseekingAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "seeking", callback)
    [<CustomOperation("onstalled")>]
    member inline this.onstalled([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "stalled", callback)
    [<CustomOperation("onstalledAsync")>]
    member inline this.onstalledAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "stalled", callback)
    [<CustomOperation("onstop")>]
    member inline this.onstop([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "stop", callback)
    [<CustomOperation("onstopAsync")>]
    member inline this.onstopAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "stop", callback)
    [<CustomOperation("onsuspend")>]
    member inline this.onsuspend([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "suspend", callback)
    [<CustomOperation("onsuspendAsync")>]
    member inline this.onsuspendAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "suspend", callback)
    [<CustomOperation("ontimeupdate")>]
    member inline this.ontimeupdate([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "timeupdate", callback)
    [<CustomOperation("ontimeupdateAsync")>]
    member inline this.ontimeupdateAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "timeupdate", callback)
    [<CustomOperation("onvolumechange")>]
    member inline this.onvolumechange([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "volumechange", callback)
    [<CustomOperation("onvolumechangeAsync")>]
    member inline this.onvolumechangeAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "volumechange", callback)
    [<CustomOperation("onwaiting")>]
    member inline this.onwaiting([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "waiting", callback)
    [<CustomOperation("onwaitingAsync")>]
    member inline this.onwaitingAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "waiting", callback)
    [<CustomOperation("onloadstart")>]
    member inline this.onloadstart([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> unit) =
        this.on (render, "loadstart", callback)
    [<CustomOperation("onloadstartAsync")>]
    member inline this.onloadstartAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "loadstart", callback)
    [<CustomOperation("ontimeout")>]
    member inline this.ontimeout([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> unit) =
        this.on (render, "timeout", callback)
    [<CustomOperation("ontimeoutAsync")>]
    member inline this.ontimeoutAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "timeout", callback)
    [<CustomOperation("onabort")>]
    member inline this.onabort([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> unit) =
        this.on (render, "abort", callback)
    [<CustomOperation("onabortAsync")>]
    member inline this.onabortAsync([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> Task) =
        this.onTask (render, "abort", callback)
    [<CustomOperation("onload")>]
    member inline this.onload([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> unit) =
        this.on (render, "load", callback)
    [<CustomOperation("onloadAsync")>]
    member inline this.onloadAsync([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> Task) =
        this.onTask (render, "load", callback)
    [<CustomOperation("onloadend")>]
    member inline this.onloadend([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> unit) =
        this.on (render, "loadend", callback)
    [<CustomOperation("onloadendAsync")>]
    member inline this.onloadendAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "loadend", callback)
    [<CustomOperation("onprogress")>]
    member inline this.onprogress([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> unit) =
        this.on (render, "progress", callback)
    [<CustomOperation("onprogressAsync")>]
    member inline this.onprogressAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: ProgressEventArgs -> Task
        )
        =
        this.onTask (render, "progress", callback)
    [<CustomOperation("onerror")>]
    member inline this.onerror([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> unit) =
        this.on (render, "error", callback)
    [<CustomOperation("onerrorAsync")>]
    member inline this.onerrorAsync([<InlineIfLambda>] render: FunRenderFragment, callback: ProgressEventArgs -> Task) =
        this.onTask (render, "error", callback)
    [<CustomOperation("onactivate")>]
    member inline this.onactivate([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "activate", callback)
    [<CustomOperation("onactivateAsync")>]
    member inline this.onactivateAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "activate", callback)
    [<CustomOperation("onbeforeactivate")>]
    member inline this.onbeforeactivate([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "beforeactivate", callback)
    [<CustomOperation("onbeforeactivateAsync")>]
    member inline this.onbeforeactivateAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "beforeactivate", callback)
    [<CustomOperation("onbeforedeactivate")>]
    member inline this.onbeforedeactivate([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "beforedeactivate", callback)
    [<CustomOperation("onbeforedeactivateAsync")>]
    member inline this.onbeforedeactivateAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "beforedeactivate", callback)
    [<CustomOperation("ondeactivate")>]
    member inline this.ondeactivate([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "deactivate", callback)
    [<CustomOperation("ondeactivateAsync")>]
    member inline this.ondeactivateAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "deactivate", callback)
    [<CustomOperation("onended")>]
    member inline this.onended([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "ended", callback)
    [<CustomOperation("onendedAsync")>]
    member inline this.onendedAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "ended", callback)
    [<CustomOperation("onfullscreenchange")>]
    member inline this.onfullscreenchange([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "fullscreenchange", callback)
    [<CustomOperation("onfullscreenchangeAsync")>]
    member inline this.onfullscreenchangeAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "fullscreenchange", callback)
    [<CustomOperation("onfullscreenerror")>]
    member inline this.onfullscreenerror([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "fullscreenerror", callback)
    [<CustomOperation("onfullscreenerrorAsync")>]
    member inline this.onfullscreenerrorAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "fullscreenerror", callback)
    [<CustomOperation("onloadeddata")>]
    member inline this.onloadeddata([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "loadeddata", callback)
    [<CustomOperation("onloadeddataAsync")>]
    member inline this.onloadeddataAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "loadeddata", callback)
    [<CustomOperation("onloadedmetadata")>]
    member inline this.onloadedmetadata([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "loadedmetadata", callback)
    [<CustomOperation("onloadedmetadataAsync")>]
    member inline this.onloadedmetadataAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "loadedmetadata", callback)
    [<CustomOperation("onpointerlockchange")>]
    member inline this.onpointerlockchange([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "pointerlockchange", callback)
    [<CustomOperation("onpointerlockchangeAsync")>]
    member inline this.onpointerlockchangeAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "pointerlockchange", callback)
    [<CustomOperation("onpointerlockerror")>]
    member inline this.onpointerlockerror([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "pointerlockerror", callback)
    [<CustomOperation("onpointerlockerrorAsync")>]
    member inline this.onpointerlockerrorAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "pointerlockerror", callback)
    [<CustomOperation("onreadystatechange")>]
    member inline this.onreadystatechange([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "readystatechange", callback)
    [<CustomOperation("onreadystatechangeAsync")>]
    member inline this.onreadystatechangeAsync
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            callback: EventArgs -> Task
        )
        =
        this.onTask (render, "readystatechange", callback)
    [<CustomOperation("onscroll")>]
    member inline this.onscroll([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> unit) =
        this.on (render, "scroll", callback)
    [<CustomOperation("onscrollAsync")>]
    member inline this.onscrollAsync([<InlineIfLambda>] render: FunRenderFragment, callback: EventArgs -> Task) =
        this.onTask (render, "scroll", callback)


type EltWithChild(name) =
    inherit EltWithDomAttrs(name)

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
    member inline _.ChildContent
        (
            [<InlineIfLambda>] render: FunRenderFragment,
            [<InlineIfLambda>] renderChild: FunRenderFragment
        )
        =
        render &&& renderChild

    /// <summary>
    /// It is recommend to use frags for better performance
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
    member inline _.ChildContent([<InlineIfLambda>] render: FunRenderFragment, renders: FunRenderFragment seq) =
        FunRenderFragment(fun builder index ->
            let mutable index = render.Invoke(builder, index)
            for item in renders do
                index <- item.Invoke(builder, index)
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
    member inline _.childContent([<InlineIfLambda>] render: FunRenderFragment, v: string) = render &&& (html.text v)

    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// // &lt;div>
    /// // 10
    /// // &lt;/div>
    /// div() {
    ///   childContent 10
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: FunRenderFragment, v: int) = render &&& (html.text v)
    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// // &lt;div>
    /// // 100.25
    /// // &lt;/div>
    /// div() {
    ///   childContent 100.25
    /// }
    /// </code>
    /// </example>
    [<CustomOperation("childContent")>]
    member inline _.childContent([<InlineIfLambda>] render: FunRenderFragment, v: float) = render &&& (html.text v)
    /// <summary>
    /// Single child node to be added into the element's children
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// div() {
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
    member inline _.childContentRaw([<InlineIfLambda>] render: FunRenderFragment, v: string) = render &&& (html.raw v)


[<AutoOpen>]
module Elts =

    type abbr' =
        static member inline create(x: string) = EltWithChild "abbr" { html.text x }
        static member inline create(x: int) = EltWithChild "abbr" { html.text x }
        static member inline create(x: float) = EltWithChild "abbr" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "abbr" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "abbr" { childContent x }

    let abbr = EltWithChild "abbr"


    type acronym' =
        static member inline create(x: string) = EltWithChild "acronym" { html.text x }
        static member inline create(x: int) = EltWithChild "acronym" { html.text x }
        static member inline create(x: float) = EltWithChild "acronym" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "acronym" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "acronym" { childContent x }

    let acronym = EltWithChild "acronym"


    type address' =
        static member inline create(x: string) = EltWithChild "address" { html.text x }
        static member inline create(x: int) = EltWithChild "address" { html.text x }
        static member inline create(x: float) = EltWithChild "address" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "address" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "address" { childContent x }

    let address = EltWithChild "address"


    type applet' =
        static member inline create(x: string) = EltWithChild "applet" { html.text x }
        static member inline create(x: int) = EltWithChild "applet" { html.text x }
        static member inline create(x: float) = EltWithChild "applet" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "applet" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "applet" { childContent x }

    let applet = EltWithChild "applet"


    type area' =
        static member inline create(x: string) = EltWithChild "area" { html.text x }
        static member inline create(x: int) = EltWithChild "area" { html.text x }
        static member inline create(x: float) = EltWithChild "area" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "area" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "area" { childContent x }

    let area = EltWithChild "area"


    type article' =
        static member inline create(x: string) = EltWithChild "article" { html.text x }
        static member inline create(x: int) = EltWithChild "article" { html.text x }
        static member inline create(x: float) = EltWithChild "article" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "article" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "article" { childContent x }

    let article = EltWithChild "article"


    type aside' =
        static member inline create(x: string) = EltWithChild "aside" { html.text x }
        static member inline create(x: int) = EltWithChild "aside" { html.text x }
        static member inline create(x: float) = EltWithChild "aside" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "aside" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "aside" { childContent x }

    let aside = EltWithChild "aside"


    type audio' =
        static member inline create(x: string) = EltWithChild "audio" { html.text x }
        static member inline create(x: int) = EltWithChild "audio" { html.text x }
        static member inline create(x: float) = EltWithChild "audio" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "audio" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "audio" { childContent x }

    let audio = EltWithChild "audio"


    type b' =
        static member inline create(x: string) = EltWithChild "b" { html.text x }
        static member inline create(x: int) = EltWithChild "b" { html.text x }
        static member inline create(x: float) = EltWithChild "b" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "b" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "b" { childContent x }

    let b = EltWithChild "b"


    type base'' =
        static member inline create(x: string) = EltWithChild "base'" { html.text x }
        static member inline create(x: int) = EltWithChild "base'" { html.text x }
        static member inline create(x: float) = EltWithChild "base'" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "base'" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "base'" { childContent x }

    let base' = EltWithChild "base'"


    type basefont' =
        static member inline create(x: string) = EltWithChild "basefont" { html.text x }
        static member inline create(x: int) = EltWithChild "basefont" { html.text x }
        static member inline create(x: float) = EltWithChild "basefont" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "basefont" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "basefont" { childContent x }

    let basefont = EltWithChild "basefont"


    type bdi' =
        static member inline create(x: string) = EltWithChild "bdi" { html.text x }
        static member inline create(x: int) = EltWithChild "bdi" { html.text x }
        static member inline create(x: float) = EltWithChild "bdi" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "bdi" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "bdi" { childContent x }

    let bdi = EltWithChild "bdi"


    type bdo' =
        static member inline create(x: string) = EltWithChild "bdo" { html.text x }
        static member inline create(x: int) = EltWithChild "bdo" { html.text x }
        static member inline create(x: float) = EltWithChild "bdo" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "bdo" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "bdo" { childContent x }

    let bdo = EltWithChild "bdo"


    type big' =
        static member inline create(x: string) = EltWithChild "big" { html.text x }
        static member inline create(x: int) = EltWithChild "big" { html.text x }
        static member inline create(x: float) = EltWithChild "big" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "big" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "big" { childContent x }

    let big = EltWithChild "big"


    type blockquote' =
        static member inline create(x: string) = EltWithChild "blockquote" { html.text x }
        static member inline create(x: int) = EltWithChild "blockquote" { html.text x }
        static member inline create(x: float) = EltWithChild "blockquote" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "blockquote" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "blockquote" { childContent x }

    let blockquote = EltWithChild "blockquote"


    type br' =
        static member inline create(x: string) = EltWithChild "br" { html.text x }
        static member inline create(x: int) = EltWithChild "br" { html.text x }
        static member inline create(x: float) = EltWithChild "br" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "br" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "br" { childContent x }

    let br = EltWithChild "br"


    type button' =
        static member inline create(x: string) = EltWithChild "button" { html.text x }
        static member inline create(x: int) = EltWithChild "button" { html.text x }
        static member inline create(x: float) = EltWithChild "button" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "button" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "button" { childContent x }

    let button = EltWithChild "button"


    type canvas' =
        static member inline create(x: string) = EltWithChild "canvas" { html.text x }
        static member inline create(x: int) = EltWithChild "canvas" { html.text x }
        static member inline create(x: float) = EltWithChild "canvas" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "canvas" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "canvas" { childContent x }

    let canvas = EltWithChild "canvas"


    type caption' =
        static member inline create(x: string) = EltWithChild "caption" { html.text x }
        static member inline create(x: int) = EltWithChild "caption" { html.text x }
        static member inline create(x: float) = EltWithChild "caption" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "caption" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "caption" { childContent x }

    let caption = EltWithChild "caption"


    type center' =
        static member inline create(x: string) = EltWithChild "center" { html.text x }
        static member inline create(x: int) = EltWithChild "center" { html.text x }
        static member inline create(x: float) = EltWithChild "center" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "center" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "center" { childContent x }

    let center = EltWithChild "center"


    type cite' =
        static member inline create(x: string) = EltWithChild "cite" { html.text x }
        static member inline create(x: int) = EltWithChild "cite" { html.text x }
        static member inline create(x: float) = EltWithChild "cite" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "cite" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "cite" { childContent x }

    let cite = EltWithChild "cite"


    type code' =
        static member inline create(x: string) = EltWithChild "code" { html.text x }
        static member inline create(x: int) = EltWithChild "code" { html.text x }
        static member inline create(x: float) = EltWithChild "code" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "code" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "code" { childContent x }

    let code = EltWithChild "code"


    type col' =
        static member inline create(x: string) = EltWithChild "col" { html.text x }
        static member inline create(x: int) = EltWithChild "col" { html.text x }
        static member inline create(x: float) = EltWithChild "col" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "col" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "col" { childContent x }

    let col = EltWithChild "col"


    type colgroup' =
        static member inline create(x: string) = EltWithChild "colgroup" { html.text x }
        static member inline create(x: int) = EltWithChild "colgroup" { html.text x }
        static member inline create(x: float) = EltWithChild "colgroup" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "colgroup" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "colgroup" { childContent x }

    let colgroup = EltWithChild "colgroup"


    type content' =
        static member inline create(x: string) = EltWithChild "content" { html.text x }
        static member inline create(x: int) = EltWithChild "content" { html.text x }
        static member inline create(x: float) = EltWithChild "content" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "content" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "content" { childContent x }

    let content = EltWithChild "content"


    type data' =
        static member inline create(x: string) = EltWithChild "data" { html.text x }
        static member inline create(x: int) = EltWithChild "data" { html.text x }
        static member inline create(x: float) = EltWithChild "data" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "data" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "data" { childContent x }

    let data = EltWithChild "data"


    type datalist' =
        static member inline create(x: string) = EltWithChild "datalist" { html.text x }
        static member inline create(x: int) = EltWithChild "datalist" { html.text x }
        static member inline create(x: float) = EltWithChild "datalist" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "datalist" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "datalist" { childContent x }

    let datalist = EltWithChild "datalist"


    type dd' =
        static member inline create(x: string) = EltWithChild "dd" { html.text x }
        static member inline create(x: int) = EltWithChild "dd" { html.text x }
        static member inline create(x: float) = EltWithChild "dd" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "dd" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "dd" { childContent x }

    let dd = EltWithChild "dd"


    type del' =
        static member inline create(x: string) = EltWithChild "del" { html.text x }
        static member inline create(x: int) = EltWithChild "del" { html.text x }
        static member inline create(x: float) = EltWithChild "del" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "del" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "del" { childContent x }

    let del = EltWithChild "del"


    type details' =
        static member inline create(x: string) = EltWithChild "details" { html.text x }
        static member inline create(x: int) = EltWithChild "details" { html.text x }
        static member inline create(x: float) = EltWithChild "details" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "details" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "details" { childContent x }

    let details = EltWithChild "details"


    type dfn' =
        static member inline create(x: string) = EltWithChild "dfn" { html.text x }
        static member inline create(x: int) = EltWithChild "dfn" { html.text x }
        static member inline create(x: float) = EltWithChild "dfn" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "dfn" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "dfn" { childContent x }

    let dfn = EltWithChild "dfn"


    type dialog' =
        static member inline create(x: string) = EltWithChild "dialog" { html.text x }
        static member inline create(x: int) = EltWithChild "dialog" { html.text x }
        static member inline create(x: float) = EltWithChild "dialog" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "dialog" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "dialog" { childContent x }

    let dialog = EltWithChild "dialog"


    type dir' =
        static member inline create(x: string) = EltWithChild "dir" { html.text x }
        static member inline create(x: int) = EltWithChild "dir" { html.text x }
        static member inline create(x: float) = EltWithChild "dir" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "dir" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "dir" { childContent x }

    let dir = EltWithChild "dir"


    type div' =
        static member inline create(x: string) = EltWithChild "div" { html.text x }
        static member inline create(x: int) = EltWithChild "div" { html.text x }
        static member inline create(x: float) = EltWithChild "div" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "div" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "div" { childContent x }

    let div = EltWithChild "div"


    type dl' =
        static member inline create(x: string) = EltWithChild "dl" { html.text x }
        static member inline create(x: int) = EltWithChild "dl" { html.text x }
        static member inline create(x: float) = EltWithChild "dl" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "dl" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "dl" { childContent x }

    let dl = EltWithChild "dl"


    type dt' =
        static member inline create(x: string) = EltWithChild "dt" { html.text x }
        static member inline create(x: int) = EltWithChild "dt" { html.text x }
        static member inline create(x: float) = EltWithChild "dt" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "dt" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "dt" { childContent x }

    let dt = EltWithChild "dt"


    type element' =
        static member inline create(x: string) = EltWithChild "element" { html.text x }
        static member inline create(x: int) = EltWithChild "element" { html.text x }
        static member inline create(x: float) = EltWithChild "element" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "element" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "element" { childContent x }

    let element = EltWithChild "element"


    type em' =
        static member inline create(x: string) = EltWithChild "em" { html.text x }
        static member inline create(x: int) = EltWithChild "em" { html.text x }
        static member inline create(x: float) = EltWithChild "em" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "em" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "em" { childContent x }

    let em = EltWithChild "em"


    type embed' =
        static member inline create(x: string) = EltWithChild "embed" { html.text x }
        static member inline create(x: int) = EltWithChild "embed" { html.text x }
        static member inline create(x: float) = EltWithChild "embed" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "embed" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "embed" { childContent x }

    let embed = EltWithChild "embed"


    type fieldset' =
        static member inline create(x: string) = EltWithChild "fieldset" { html.text x }
        static member inline create(x: int) = EltWithChild "fieldset" { html.text x }
        static member inline create(x: float) = EltWithChild "fieldset" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "fieldset" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "fieldset" { childContent x }

    let fieldset = EltWithChild "fieldset"


    type figcaption' =
        static member inline create(x: string) = EltWithChild "figcaption" { html.text x }
        static member inline create(x: int) = EltWithChild "figcaption" { html.text x }
        static member inline create(x: float) = EltWithChild "figcaption" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "figcaption" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "figcaption" { childContent x }

    let figcaption = EltWithChild "figcaption"


    type figure' =
        static member inline create(x: string) = EltWithChild "figure" { html.text x }
        static member inline create(x: int) = EltWithChild "figure" { html.text x }
        static member inline create(x: float) = EltWithChild "figure" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "figure" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "figure" { childContent x }

    let figure = EltWithChild "figure"


    type font' =
        static member inline create(x: string) = EltWithChild "font" { html.text x }
        static member inline create(x: int) = EltWithChild "font" { html.text x }
        static member inline create(x: float) = EltWithChild "font" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "font" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "font" { childContent x }

    let font = EltWithChild "font"


    type footer' =
        static member inline create(x: string) = EltWithChild "footer" { html.text x }
        static member inline create(x: int) = EltWithChild "footer" { html.text x }
        static member inline create(x: float) = EltWithChild "footer" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "footer" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "footer" { childContent x }

    let footer = EltWithChild "footer"


    type form' =
        static member inline create(x: string) = EltWithChild "form" { html.text x }
        static member inline create(x: int) = EltWithChild "form" { html.text x }
        static member inline create(x: float) = EltWithChild "form" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "form" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "form" { childContent x }

    let form = EltWithChild "form"


    type frame' =
        static member inline create(x: string) = EltWithChild "frame" { html.text x }
        static member inline create(x: int) = EltWithChild "frame" { html.text x }
        static member inline create(x: float) = EltWithChild "frame" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "frame" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "frame" { childContent x }

    let frame = EltWithChild "frame"


    type frameset' =
        static member inline create(x: string) = EltWithChild "frameset" { html.text x }
        static member inline create(x: int) = EltWithChild "frameset" { html.text x }
        static member inline create(x: float) = EltWithChild "frameset" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "frameset" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "frameset" { childContent x }

    let frameset = EltWithChild "frameset"


    type h1' =
        static member inline create(x: string) = EltWithChild "h1" { html.text x }
        static member inline create(x: int) = EltWithChild "h1" { html.text x }
        static member inline create(x: float) = EltWithChild "h1" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "h1" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "h1" { childContent x }

    let h1 = EltWithChild "h1"


    type h2' =
        static member inline create(x: string) = EltWithChild "h2" { html.text x }
        static member inline create(x: int) = EltWithChild "h2" { html.text x }
        static member inline create(x: float) = EltWithChild "h2" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "h2" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "h2" { childContent x }

    let h2 = EltWithChild "h2"


    type h3' =
        static member inline create(x: string) = EltWithChild "h3" { html.text x }
        static member inline create(x: int) = EltWithChild "h3" { html.text x }
        static member inline create(x: float) = EltWithChild "h3" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "h3" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "h3" { childContent x }

    let h3 = EltWithChild "h3"


    type h4' =
        static member inline create(x: string) = EltWithChild "h4" { html.text x }
        static member inline create(x: int) = EltWithChild "h4" { html.text x }
        static member inline create(x: float) = EltWithChild "h4" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "h4" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "h4" { childContent x }

    let h4 = EltWithChild "h4"


    type h5' =
        static member inline create(x: string) = EltWithChild "h5" { html.text x }
        static member inline create(x: int) = EltWithChild "h5" { html.text x }
        static member inline create(x: float) = EltWithChild "h5" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "h5" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "h5" { childContent x }

    let h5 = EltWithChild "h5"


    type h6' =
        static member inline create(x: string) = EltWithChild "h6" { html.text x }
        static member inline create(x: int) = EltWithChild "h6" { html.text x }
        static member inline create(x: float) = EltWithChild "h6" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "h6" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "h6" { childContent x }

    let h6 = EltWithChild "h6"


    type header' =
        static member inline create(x: string) = EltWithChild "header" { html.text x }
        static member inline create(x: int) = EltWithChild "header" { html.text x }
        static member inline create(x: float) = EltWithChild "header" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "header" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "header" { childContent x }

    let header = EltWithChild "header"


    type hr' =
        static member inline create(x: string) = EltWithChild "hr" { html.text x }
        static member inline create(x: int) = EltWithChild "hr" { html.text x }
        static member inline create(x: float) = EltWithChild "hr" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "hr" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "hr" { childContent x }

    let hr = EltWithChild "hr"


    type i' =
        static member inline create(x: string) = EltWithChild "i" { html.text x }
        static member inline create(x: int) = EltWithChild "i" { html.text x }
        static member inline create(x: float) = EltWithChild "i" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "i" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "i" { childContent x }

    let i = EltWithChild "i"


    type iframe' =
        static member inline create(x: string) = EltWithChild "iframe" { html.text x }
        static member inline create(x: int) = EltWithChild "iframe" { html.text x }
        static member inline create(x: float) = EltWithChild "iframe" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "iframe" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "iframe" { childContent x }

    let iframe = EltWithChild "iframe"


    type input' =
        static member inline create(x: string) = EltWithChild "input" { html.text x }
        static member inline create(x: int) = EltWithChild "input" { html.text x }
        static member inline create(x: float) = EltWithChild "input" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "input" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "input" { childContent x }

    let input = EltWithChild "input"


    type ins' =
        static member inline create(x: string) = EltWithChild "ins" { html.text x }
        static member inline create(x: int) = EltWithChild "ins" { html.text x }
        static member inline create(x: float) = EltWithChild "ins" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "ins" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "ins" { childContent x }

    let ins = EltWithChild "ins"


    type kbd' =
        static member inline create(x: string) = EltWithChild "kbd" { html.text x }
        static member inline create(x: int) = EltWithChild "kbd" { html.text x }
        static member inline create(x: float) = EltWithChild "kbd" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "kbd" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "kbd" { childContent x }

    let kbd = EltWithChild "kbd"


    type label' =
        static member inline create(x: string) = EltWithChild "label" { html.text x }
        static member inline create(x: int) = EltWithChild "label" { html.text x }
        static member inline create(x: float) = EltWithChild "label" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "label" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "label" { childContent x }

    let label = EltWithChild "label"


    type legend' =
        static member inline create(x: string) = EltWithChild "legend" { html.text x }
        static member inline create(x: int) = EltWithChild "legend" { html.text x }
        static member inline create(x: float) = EltWithChild "legend" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "legend" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "legend" { childContent x }

    let legend = EltWithChild "legend"


    type li' =
        static member inline create(x: string) = EltWithChild "li" { html.text x }
        static member inline create(x: int) = EltWithChild "li" { html.text x }
        static member inline create(x: float) = EltWithChild "li" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "li" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "li" { childContent x }

    let li = EltWithChild "li"


    type link' =
        static member inline create(x: string) = EltWithChild "link" { html.text x }
        static member inline create(x: int) = EltWithChild "link" { html.text x }
        static member inline create(x: float) = EltWithChild "link" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "link" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "link" { childContent x }

    let link = EltWithChild "link"


    type main' =
        static member inline create(x: string) = EltWithChild "main" { html.text x }
        static member inline create(x: int) = EltWithChild "main" { html.text x }
        static member inline create(x: float) = EltWithChild "main" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "main" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "main" { childContent x }

    let main = EltWithChild "main"


    type map' =
        static member inline create(x: string) = EltWithChild "map" { html.text x }
        static member inline create(x: int) = EltWithChild "map" { html.text x }
        static member inline create(x: float) = EltWithChild "map" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "map" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "map" { childContent x }

    let map = EltWithChild "map"


    type mark' =
        static member inline create(x: string) = EltWithChild "mark" { html.text x }
        static member inline create(x: int) = EltWithChild "mark" { html.text x }
        static member inline create(x: float) = EltWithChild "mark" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "mark" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "mark" { childContent x }

    let mark = EltWithChild "mark"


    type menu' =
        static member inline create(x: string) = EltWithChild "menu" { html.text x }
        static member inline create(x: int) = EltWithChild "menu" { html.text x }
        static member inline create(x: float) = EltWithChild "menu" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "menu" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "menu" { childContent x }

    let menu = EltWithChild "menu"


    type menuitem' =
        static member inline create(x: string) = EltWithChild "menuitem" { html.text x }
        static member inline create(x: int) = EltWithChild "menuitem" { html.text x }
        static member inline create(x: float) = EltWithChild "menuitem" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "menuitem" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "menuitem" { childContent x }

    let menuitem = EltWithChild "menuitem"


    type meter' =
        static member inline create(x: string) = EltWithChild "meter" { html.text x }
        static member inline create(x: int) = EltWithChild "meter" { html.text x }
        static member inline create(x: float) = EltWithChild "meter" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "meter" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "meter" { childContent x }

    let meter = EltWithChild "meter"


    type nav' =
        static member inline create(x: string) = EltWithChild "nav" { html.text x }
        static member inline create(x: int) = EltWithChild "nav" { html.text x }
        static member inline create(x: float) = EltWithChild "nav" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "nav" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "nav" { childContent x }

    let nav = EltWithChild "nav"


    type noembed' =
        static member inline create(x: string) = EltWithChild "noembed" { html.text x }
        static member inline create(x: int) = EltWithChild "noembed" { html.text x }
        static member inline create(x: float) = EltWithChild "noembed" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "noembed" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "noembed" { childContent x }

    let noembed = EltWithChild "noembed"


    type noframes' =
        static member inline create(x: string) = EltWithChild "noframes" { html.text x }
        static member inline create(x: int) = EltWithChild "noframes" { html.text x }
        static member inline create(x: float) = EltWithChild "noframes" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "noframes" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "noframes" { childContent x }

    let noframes = EltWithChild "noframes"


    type noscript' =
        static member inline create(x: string) = EltWithChild "noscript" { html.text x }
        static member inline create(x: int) = EltWithChild "noscript" { html.text x }
        static member inline create(x: float) = EltWithChild "noscript" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "noscript" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "noscript" { childContent x }

    let noscript = EltWithChild "noscript"


    type object' =
        static member inline create(x: string) = EltWithChild "object" { html.text x }
        static member inline create(x: int) = EltWithChild "object" { html.text x }
        static member inline create(x: float) = EltWithChild "object" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "object" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "object" { childContent x }

    let object = EltWithChild "object"


    type ol' =
        static member inline create(x: string) = EltWithChild "ol" { html.text x }
        static member inline create(x: int) = EltWithChild "ol" { html.text x }
        static member inline create(x: float) = EltWithChild "ol" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "ol" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "ol" { childContent x }

    let ol = EltWithChild "ol"


    type optgroup' =
        static member inline create(x: string) = EltWithChild "optgroup" { html.text x }
        static member inline create(x: int) = EltWithChild "optgroup" { html.text x }
        static member inline create(x: float) = EltWithChild "optgroup" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "optgroup" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "optgroup" { childContent x }

    let optgroup = EltWithChild "optgroup"


    type option' =
        static member inline create(x: string) = EltWithChild "option" { html.text x }
        static member inline create(x: int) = EltWithChild "option" { html.text x }
        static member inline create(x: float) = EltWithChild "option" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "option" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "option" { childContent x }

    let option = EltWithChild "option"


    type output' =
        static member inline create(x: string) = EltWithChild "output" { html.text x }
        static member inline create(x: int) = EltWithChild "output" { html.text x }
        static member inline create(x: float) = EltWithChild "output" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "output" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "output" { childContent x }

    let output = EltWithChild "output"


    type p' =
        static member inline create(x: string) = EltWithChild "p" { html.text x }
        static member inline create(x: int) = EltWithChild "p" { html.text x }
        static member inline create(x: float) = EltWithChild "p" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "p" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "p" { childContent x }

    let p = EltWithChild "p"


    type param' =
        static member inline create(x: string) = EltWithChild "param" { html.text x }
        static member inline create(x: int) = EltWithChild "param" { html.text x }
        static member inline create(x: float) = EltWithChild "param" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "param" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "param" { childContent x }

    let param = EltWithChild "param"


    type picture' =
        static member inline create(x: string) = EltWithChild "picture" { html.text x }
        static member inline create(x: int) = EltWithChild "picture" { html.text x }
        static member inline create(x: float) = EltWithChild "picture" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "picture" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "picture" { childContent x }

    let picture = EltWithChild "picture"


    type pre' =
        static member inline create(x: string) = EltWithChild "pre" { html.text x }
        static member inline create(x: int) = EltWithChild "pre" { html.text x }
        static member inline create(x: float) = EltWithChild "pre" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "pre" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "pre" { childContent x }

    let pre = EltWithChild "pre"


    type progress' =
        static member inline create(x: string) = EltWithChild "progress" { html.text x }
        static member inline create(x: int) = EltWithChild "progress" { html.text x }
        static member inline create(x: float) = EltWithChild "progress" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "progress" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "progress" { childContent x }

    let progress = EltWithChild "progress"


    type q' =
        static member inline create(x: string) = EltWithChild "q" { html.text x }
        static member inline create(x: int) = EltWithChild "q" { html.text x }
        static member inline create(x: float) = EltWithChild "q" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "q" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "q" { childContent x }

    let q = EltWithChild "q"


    type rb' =
        static member inline create(x: string) = EltWithChild "rb" { html.text x }
        static member inline create(x: int) = EltWithChild "rb" { html.text x }
        static member inline create(x: float) = EltWithChild "rb" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "rb" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "rb" { childContent x }

    let rb = EltWithChild "rb"


    type rp' =
        static member inline create(x: string) = EltWithChild "rp" { html.text x }
        static member inline create(x: int) = EltWithChild "rp" { html.text x }
        static member inline create(x: float) = EltWithChild "rp" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "rp" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "rp" { childContent x }

    let rp = EltWithChild "rp"


    type rt' =
        static member inline create(x: string) = EltWithChild "rt" { html.text x }
        static member inline create(x: int) = EltWithChild "rt" { html.text x }
        static member inline create(x: float) = EltWithChild "rt" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "rt" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "rt" { childContent x }

    let rt = EltWithChild "rt"


    type rtc' =
        static member inline create(x: string) = EltWithChild "rtc" { html.text x }
        static member inline create(x: int) = EltWithChild "rtc" { html.text x }
        static member inline create(x: float) = EltWithChild "rtc" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "rtc" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "rtc" { childContent x }

    let rtc = EltWithChild "rtc"


    type ruby' =
        static member inline create(x: string) = EltWithChild "ruby" { html.text x }
        static member inline create(x: int) = EltWithChild "ruby" { html.text x }
        static member inline create(x: float) = EltWithChild "ruby" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "ruby" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "ruby" { childContent x }

    let ruby = EltWithChild "ruby"


    type s' =
        static member inline create(x: string) = EltWithChild "s" { html.text x }
        static member inline create(x: int) = EltWithChild "s" { html.text x }
        static member inline create(x: float) = EltWithChild "s" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "s" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "s" { childContent x }

    let s = EltWithChild "s"


    type samp' =
        static member inline create(x: string) = EltWithChild "samp" { html.text x }
        static member inline create(x: int) = EltWithChild "samp" { html.text x }
        static member inline create(x: float) = EltWithChild "samp" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "samp" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "samp" { childContent x }

    let samp = EltWithChild "samp"


    type script' =
        static member inline create(x: string) = EltWithChild "script" { html.text x }
        static member inline create(x: int) = EltWithChild "script" { html.text x }
        static member inline create(x: float) = EltWithChild "script" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "script" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "script" { childContent x }

    let script = EltWithChild "script"


    type section' =
        static member inline create(x: string) = EltWithChild "section" { html.text x }
        static member inline create(x: int) = EltWithChild "section" { html.text x }
        static member inline create(x: float) = EltWithChild "section" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "section" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "section" { childContent x }

    let section = EltWithChild "section"


    type select' =
        static member inline create(x: string) = EltWithChild "select" { html.text x }
        static member inline create(x: int) = EltWithChild "select" { html.text x }
        static member inline create(x: float) = EltWithChild "select" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "select" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "select" { childContent x }

    let select = EltWithChild "select"


    type shadow' =
        static member inline create(x: string) = EltWithChild "shadow" { html.text x }
        static member inline create(x: int) = EltWithChild "shadow" { html.text x }
        static member inline create(x: float) = EltWithChild "shadow" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "shadow" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "shadow" { childContent x }

    let shadow = EltWithChild "shadow"


    type slot' =
        static member inline create(x: string) = EltWithChild "slot" { html.text x }
        static member inline create(x: int) = EltWithChild "slot" { html.text x }
        static member inline create(x: float) = EltWithChild "slot" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "slot" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "slot" { childContent x }

    let slot = EltWithChild "slot"


    type small' =
        static member inline create(x: string) = EltWithChild "small" { html.text x }
        static member inline create(x: int) = EltWithChild "small" { html.text x }
        static member inline create(x: float) = EltWithChild "small" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "small" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "small" { childContent x }

    let small = EltWithChild "small"


    type source' =
        static member inline create(x: string) = EltWithChild "source" { html.text x }
        static member inline create(x: int) = EltWithChild "source" { html.text x }
        static member inline create(x: float) = EltWithChild "source" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "source" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "source" { childContent x }

    let source = EltWithChild "source"


    type span' =
        static member inline create(x: string) = EltWithChild "span" { html.text x }
        static member inline create(x: int) = EltWithChild "span" { html.text x }
        static member inline create(x: float) = EltWithChild "span" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "span" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "span" { childContent x }

    let span = EltWithChild "span"


    type strike' =
        static member inline create(x: string) = EltWithChild "strike" { html.text x }
        static member inline create(x: int) = EltWithChild "strike" { html.text x }
        static member inline create(x: float) = EltWithChild "strike" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "strike" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "strike" { childContent x }

    let strike = EltWithChild "strike"


    type strong' =
        static member inline create(x: string) = EltWithChild "strong" { html.text x }
        static member inline create(x: int) = EltWithChild "strong" { html.text x }
        static member inline create(x: float) = EltWithChild "strong" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "strong" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "strong" { childContent x }

    let strong = EltWithChild "strong"


    type style'' =
        static member inline create(x: string) = EltWithChild "style'" { html.text x }
        static member inline create(x: int) = EltWithChild "style'" { html.text x }
        static member inline create(x: float) = EltWithChild "style'" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "style'" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "style'" { childContent x }

    let style' = EltWithChild "style'"


    type sub' =
        static member inline create(x: string) = EltWithChild "sub" { html.text x }
        static member inline create(x: int) = EltWithChild "sub" { html.text x }
        static member inline create(x: float) = EltWithChild "sub" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "sub" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "sub" { childContent x }

    let sub = EltWithChild "sub"


    type summary' =
        static member inline create(x: string) = EltWithChild "summary" { html.text x }
        static member inline create(x: int) = EltWithChild "summary" { html.text x }
        static member inline create(x: float) = EltWithChild "summary" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "summary" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "summary" { childContent x }

    let summary = EltWithChild "summary"


    type sup' =
        static member inline create(x: string) = EltWithChild "sup" { html.text x }
        static member inline create(x: int) = EltWithChild "sup" { html.text x }
        static member inline create(x: float) = EltWithChild "sup" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "sup" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "sup" { childContent x }

    let sup = EltWithChild "sup"


    type svg' =
        static member inline create(x: string) = EltWithChild "svg" { html.text x }
        static member inline create(x: int) = EltWithChild "svg" { html.text x }
        static member inline create(x: float) = EltWithChild "svg" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "svg" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "svg" { childContent x }

    let svg = EltWithChild "svg"


    type table' =
        static member inline create(x: string) = EltWithChild "table" { html.text x }
        static member inline create(x: int) = EltWithChild "table" { html.text x }
        static member inline create(x: float) = EltWithChild "table" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "table" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "table" { childContent x }

    let table = EltWithChild "table"


    type tbody' =
        static member inline create(x: string) = EltWithChild "tbody" { html.text x }
        static member inline create(x: int) = EltWithChild "tbody" { html.text x }
        static member inline create(x: float) = EltWithChild "tbody" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "tbody" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "tbody" { childContent x }

    let tbody = EltWithChild "tbody"


    type td' =
        static member inline create(x: string) = EltWithChild "td" { html.text x }
        static member inline create(x: int) = EltWithChild "td" { html.text x }
        static member inline create(x: float) = EltWithChild "td" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "td" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "td" { childContent x }

    let td = EltWithChild "td"


    type template' =
        static member inline create(x: string) = EltWithChild "template" { html.text x }
        static member inline create(x: int) = EltWithChild "template" { html.text x }
        static member inline create(x: float) = EltWithChild "template" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "template" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "template" { childContent x }

    let template = EltWithChild "template"


    type textarea' =
        static member inline create(x: string) = EltWithChild "textarea" { html.text x }
        static member inline create(x: int) = EltWithChild "textarea" { html.text x }
        static member inline create(x: float) = EltWithChild "textarea" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "textarea" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "textarea" { childContent x }

    let textarea = EltWithChild "textarea"


    type tfoot' =
        static member inline create(x: string) = EltWithChild "tfoot" { html.text x }
        static member inline create(x: int) = EltWithChild "tfoot" { html.text x }
        static member inline create(x: float) = EltWithChild "tfoot" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "tfoot" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "tfoot" { childContent x }

    let tfoot = EltWithChild "tfoot"


    type th' =
        static member inline create(x: string) = EltWithChild "th" { html.text x }
        static member inline create(x: int) = EltWithChild "th" { html.text x }
        static member inline create(x: float) = EltWithChild "th" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "th" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "th" { childContent x }

    let th = EltWithChild "th"


    type thead' =
        static member inline create(x: string) = EltWithChild "thead" { html.text x }
        static member inline create(x: int) = EltWithChild "thead" { html.text x }
        static member inline create(x: float) = EltWithChild "thead" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "thead" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "thead" { childContent x }

    let thead = EltWithChild "thead"


    type time' =
        static member inline create(x: string) = EltWithChild "time" { html.text x }
        static member inline create(x: int) = EltWithChild "time" { html.text x }
        static member inline create(x: float) = EltWithChild "time" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "time" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "time" { childContent x }

    let time = EltWithChild "time"


    type title' =
        static member inline create(x: string) = EltWithChild "title" { html.text x }
        static member inline create(x: int) = EltWithChild "title" { html.text x }
        static member inline create(x: float) = EltWithChild "title" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "title" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "title" { childContent x }

    let title = EltWithChild "title"


    type tr' =
        static member inline create(x: string) = EltWithChild "tr" { html.text x }
        static member inline create(x: int) = EltWithChild "tr" { html.text x }
        static member inline create(x: float) = EltWithChild "tr" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "tr" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "tr" { childContent x }

    let tr = EltWithChild "tr"


    type track' =
        static member inline create(x: string) = EltWithChild "track" { html.text x }
        static member inline create(x: int) = EltWithChild "track" { html.text x }
        static member inline create(x: float) = EltWithChild "track" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "track" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "track" { childContent x }

    let track = EltWithChild "track"


    type tt' =
        static member inline create(x: string) = EltWithChild "tt" { html.text x }
        static member inline create(x: int) = EltWithChild "tt" { html.text x }
        static member inline create(x: float) = EltWithChild "tt" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "tt" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "tt" { childContent x }

    let tt = EltWithChild "tt"


    type u' =
        static member inline create(x: string) = EltWithChild "u" { html.text x }
        static member inline create(x: int) = EltWithChild "u" { html.text x }
        static member inline create(x: float) = EltWithChild "u" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "u" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "u" { childContent x }

    let u = EltWithChild "u"


    type ul' =
        static member inline create(x: string) = EltWithChild "ul" { html.text x }
        static member inline create(x: int) = EltWithChild "ul" { html.text x }
        static member inline create(x: float) = EltWithChild "ul" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "ul" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "ul" { childContent x }

    let ul = EltWithChild "ul"


    type var' =
        static member inline create(x: string) = EltWithChild "var" { html.text x }
        static member inline create(x: int) = EltWithChild "var" { html.text x }
        static member inline create(x: float) = EltWithChild "var" { html.text x }
        static member inline create(x: FunRenderFragment) = EltWithChild "var" { childContent x }
        static member inline create(x: FunRenderFragment seq) = EltWithChild "var" { childContent x }

    let var = EltWithChild "var"


    let video = EltWithChild "video"

    let wbr = EltWithDomAttrs "wbr"

    let img = EltWithDomAttrs "img"

    let html' = EltWithChild "html"

    let body = EltWithChild "body"

    let head = EltWithChild "head"


    type meta' =
        static member inline create(n, v) =
            EltWithChild "meta" {
                name n
                value v
            }

    let meta = EltWithChild "meta"


    let doctype decl = html.raw $"<!DOCTYPE {decl}>\n"
