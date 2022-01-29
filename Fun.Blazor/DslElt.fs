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
    [<CustomOperation("title")>]
    member inline _.title([<InlineIfLambda>] render: FunRenderFragment, v: obj) = render &&& ("title" => v)
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

    type ABuilder() =
        inherit EltWithChild "a"

        static member inline create(x: string) = ABuilder() { childContent (html.text x) }
        static member inline create(x: int) = ABuilder() { childContent (html.text x) }
        static member inline create(x: float) = ABuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ABuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ABuilder() { childContent x }

    let a = ABuilder


    type AbbrBuilder() =
        inherit EltWithChild "abbr"

        static member inline create(x: string) = AbbrBuilder() { childContent (html.text x) }
        static member inline create(x: int) = AbbrBuilder() { childContent (html.text x) }
        static member inline create(x: float) = AbbrBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = AbbrBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = AbbrBuilder() { childContent x }

    let abbr = AbbrBuilder()


    type AcronymBuilder() =
        inherit EltWithChild "acronym"

        static member inline create(x: string) = AcronymBuilder() { childContent (html.text x) }
        static member inline create(x: int) = AcronymBuilder() { childContent (html.text x) }
        static member inline create(x: float) = AcronymBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = AcronymBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = AcronymBuilder() { childContent x }

    let acronym = AcronymBuilder()


    type AddressBuilder() =
        inherit EltWithChild "address"

        static member inline create(x: string) = AddressBuilder() { childContent (html.text x) }
        static member inline create(x: int) = AddressBuilder() { childContent (html.text x) }
        static member inline create(x: float) = AddressBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = AddressBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = AddressBuilder() { childContent x }

    let address = AddressBuilder()


    type AppletBuilder() =
        inherit EltWithChild "applet"

        static member inline create(x: string) = AppletBuilder() { childContent (html.text x) }
        static member inline create(x: int) = AppletBuilder() { childContent (html.text x) }
        static member inline create(x: float) = AppletBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = AppletBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = AppletBuilder() { childContent x }

    let applet = AppletBuilder()


    type AreaBuilder() =
        inherit EltWithChild "area"

        static member inline create(x: string) = AreaBuilder() { childContent (html.text x) }
        static member inline create(x: int) = AreaBuilder() { childContent (html.text x) }
        static member inline create(x: float) = AreaBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = AreaBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = AreaBuilder() { childContent x }

    let area = AreaBuilder()


    type ArticleBuilder() =
        inherit EltWithChild "article"

        static member inline create(x: string) = ArticleBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ArticleBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ArticleBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ArticleBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ArticleBuilder() { childContent x }

    let article = ArticleBuilder()


    type AsideBuilder() =
        inherit EltWithChild "aside"

        static member inline create(x: string) = AsideBuilder() { childContent (html.text x) }
        static member inline create(x: int) = AsideBuilder() { childContent (html.text x) }
        static member inline create(x: float) = AsideBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = AsideBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = AsideBuilder() { childContent x }

    let aside = AsideBuilder()


    type AudioBuilder() =
        inherit EltWithChild "audio"

        static member inline create(x: string) = AudioBuilder() { childContent (html.text x) }
        static member inline create(x: int) = AudioBuilder() { childContent (html.text x) }
        static member inline create(x: float) = AudioBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = AudioBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = AudioBuilder() { childContent x }

    let audio = AudioBuilder()


    type BBuilder() =
        inherit EltWithChild "b"

        static member inline create(x: string) = BBuilder() { childContent (html.text x) }
        static member inline create(x: int) = BBuilder() { childContent (html.text x) }
        static member inline create(x: float) = BBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BBuilder() { childContent x }

    let b = BBuilder()


    type BaseBuilder() =
        inherit EltWithChild "base'"

        static member inline create(x: string) = BaseBuilder() { childContent (html.text x) }
        static member inline create(x: int) = BaseBuilder() { childContent (html.text x) }
        static member inline create(x: float) = BaseBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BaseBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BaseBuilder() { childContent x }

    let base' = BaseBuilder()


    type BasefontBuilder() =
        inherit EltWithChild "basefont"

        static member inline create(x: string) = BasefontBuilder() { childContent (html.text x) }
        static member inline create(x: int) = BasefontBuilder() { childContent (html.text x) }
        static member inline create(x: float) = BasefontBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BasefontBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BasefontBuilder() { childContent x }

    let basefont = BasefontBuilder()


    type BdiBuilder() =
        inherit EltWithChild "bdi"

        static member inline create(x: string) = BdiBuilder() { childContent (html.text x) }
        static member inline create(x: int) = BdiBuilder() { childContent (html.text x) }
        static member inline create(x: float) = BdiBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BdiBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BdiBuilder() { childContent x }

    let bdi = BdiBuilder()


    type BdoBuilder() =
        inherit EltWithChild "bdo"

        static member inline create(x: string) = BdoBuilder() { childContent (html.text x) }
        static member inline create(x: int) = BdoBuilder() { childContent (html.text x) }
        static member inline create(x: float) = BdoBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BdoBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BdoBuilder() { childContent x }

    let bdo = BdoBuilder()


    type BigBuilder() =
        inherit EltWithChild "big"

        static member inline create(x: string) = BigBuilder() { childContent (html.text x) }
        static member inline create(x: int) = BigBuilder() { childContent (html.text x) }
        static member inline create(x: float) = BigBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BigBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BigBuilder() { childContent x }

    let big = BigBuilder()


    type BlockquoteBuilder() =
        inherit EltWithChild "blockquote"

        static member inline create(x: string) =
            BlockquoteBuilder() { childContent (html.text x) }
        static member inline create(x: int) =
            BlockquoteBuilder() { childContent (html.text x) }
        static member inline create(x: float) =
            BlockquoteBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BlockquoteBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BlockquoteBuilder() { childContent x }

    let blockquote = BlockquoteBuilder()


    type BodyBuilder() =
        inherit EltWithChild "body"

        static member inline create(x: string) = BodyBuilder() { childContent (html.text x) }
        static member inline create(x: int) = BodyBuilder() { childContent (html.text x) }
        static member inline create(x: float) = BodyBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BodyBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BodyBuilder() { childContent x }

    let body = BodyBuilder()


    type BrBuilder() =
        inherit EltWithChild "br"

        static member inline create(x: string) = BrBuilder() { childContent (html.text x) }
        static member inline create(x: int) = BrBuilder() { childContent (html.text x) }
        static member inline create(x: float) = BrBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = BrBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = BrBuilder() { childContent x }

    let br = BrBuilder()


    type ButtonBuilder() =
        inherit EltWithChild "button"

        static member inline create(x: string) = ButtonBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ButtonBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ButtonBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ButtonBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ButtonBuilder() { childContent x }

    let button = ButtonBuilder()


    type CanvasBuilder() =
        inherit EltWithChild "canvas"

        static member inline create(x: string) = CanvasBuilder() { childContent (html.text x) }
        static member inline create(x: int) = CanvasBuilder() { childContent (html.text x) }
        static member inline create(x: float) = CanvasBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = CanvasBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = CanvasBuilder() { childContent x }

    let canvas = CanvasBuilder()


    type CaptionBuilder() =
        inherit EltWithChild "caption"

        static member inline create(x: string) = CaptionBuilder() { childContent (html.text x) }
        static member inline create(x: int) = CaptionBuilder() { childContent (html.text x) }
        static member inline create(x: float) = CaptionBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = CaptionBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = CaptionBuilder() { childContent x }

    let caption = CaptionBuilder()


    type CenterBuilder() =
        inherit EltWithChild "center"

        static member inline create(x: string) = CenterBuilder() { childContent (html.text x) }
        static member inline create(x: int) = CenterBuilder() { childContent (html.text x) }
        static member inline create(x: float) = CenterBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = CenterBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = CenterBuilder() { childContent x }

    let center = CenterBuilder()


    type CiteBuilder() =
        inherit EltWithChild "cite"

        static member inline create(x: string) = CiteBuilder() { childContent (html.text x) }
        static member inline create(x: int) = CiteBuilder() { childContent (html.text x) }
        static member inline create(x: float) = CiteBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = CiteBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = CiteBuilder() { childContent x }

    let cite = CiteBuilder()


    type CodeBuilder() =
        inherit EltWithChild "code"

        static member inline create(x: string) = CodeBuilder() { childContent (html.text x) }
        static member inline create(x: int) = CodeBuilder() { childContent (html.text x) }
        static member inline create(x: float) = CodeBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = CodeBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = CodeBuilder() { childContent x }

    let code = CodeBuilder()


    type ColBuilder() =
        inherit EltWithChild "col"

        static member inline create(x: string) = ColBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ColBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ColBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ColBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ColBuilder() { childContent x }

    let col = ColBuilder()


    type ColgroupBuilder() =
        inherit EltWithChild "colgroup"

        static member inline create(x: string) = ColgroupBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ColgroupBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ColgroupBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ColgroupBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ColgroupBuilder() { childContent x }

    let colgroup = ColgroupBuilder()


    type ContentBuilder() =
        inherit EltWithChild "content"

        static member inline create(x: string) = ContentBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ContentBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ContentBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ContentBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ContentBuilder() { childContent x }

    let content = ContentBuilder()


    type DataBuilder() =
        inherit EltWithChild "data"

        static member inline create(x: string) = DataBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DataBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DataBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DataBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DataBuilder() { childContent x }

    let data = DataBuilder()


    type DatalistBuilder() =
        inherit EltWithChild "datalist"

        static member inline create(x: string) = DatalistBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DatalistBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DatalistBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DatalistBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DatalistBuilder() { childContent x }

    let datalist = DatalistBuilder()


    type DdBuilder() =
        inherit EltWithChild "dd"

        static member inline create(x: string) = DdBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DdBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DdBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DdBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DdBuilder() { childContent x }

    let dd = DdBuilder()


    type DelBuilder() =
        inherit EltWithChild "del"

        static member inline create(x: string) = DelBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DelBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DelBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DelBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DelBuilder() { childContent x }

    let del = DelBuilder()


    type DetailsBuilder() =
        inherit EltWithChild "details"

        static member inline create(x: string) = DetailsBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DetailsBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DetailsBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DetailsBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DetailsBuilder() { childContent x }

    let details = DetailsBuilder()


    type DfnBuilder() =
        inherit EltWithChild "dfn"

        static member inline create(x: string) = DfnBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DfnBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DfnBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DfnBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DfnBuilder() { childContent x }

    let dfn = DfnBuilder()


    type DialogBuilder() =
        inherit EltWithChild "dialog"

        static member inline create(x: string) = DialogBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DialogBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DialogBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DialogBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DialogBuilder() { childContent x }

    let dialog = DialogBuilder()


    type DirBuilder() =
        inherit EltWithChild "dir"

        static member inline create(x: string) = DirBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DirBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DirBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DirBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DirBuilder() { childContent x }

    let dir = DirBuilder()


    type DivBuilder() =
        inherit EltWithChild "div"

        static member inline create(x: string) = DivBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DivBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DivBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DivBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DivBuilder() { childContent x }

    let div = DivBuilder()


    type DlBuilder() =
        inherit EltWithChild "dl"

        static member inline create(x: string) = DlBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DlBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DlBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DlBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DlBuilder() { childContent x }

    let dl = DlBuilder()


    type DtBuilder() =
        inherit EltWithChild "dt"

        static member inline create(x: string) = DtBuilder() { childContent (html.text x) }
        static member inline create(x: int) = DtBuilder() { childContent (html.text x) }
        static member inline create(x: float) = DtBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = DtBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = DtBuilder() { childContent x }

    let dt = DtBuilder()


    type ElementBuilder() =
        inherit EltWithChild "element"

        static member inline create(x: string) = ElementBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ElementBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ElementBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ElementBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ElementBuilder() { childContent x }

    let element = ElementBuilder()


    type EmBuilder() =
        inherit EltWithChild "em"

        static member inline create(x: string) = EmBuilder() { childContent (html.text x) }
        static member inline create(x: int) = EmBuilder() { childContent (html.text x) }
        static member inline create(x: float) = EmBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = EmBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = EmBuilder() { childContent x }

    let em = EmBuilder()


    type EmbedBuilder() =
        inherit EltWithChild "embed"

        static member inline create(x: string) = EmbedBuilder() { childContent (html.text x) }
        static member inline create(x: int) = EmbedBuilder() { childContent (html.text x) }
        static member inline create(x: float) = EmbedBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = EmbedBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = EmbedBuilder() { childContent x }

    let embed = EmbedBuilder()


    type FieldsetBuilder() =
        inherit EltWithChild "fieldset"

        static member inline create(x: string) = FieldsetBuilder() { childContent (html.text x) }
        static member inline create(x: int) = FieldsetBuilder() { childContent (html.text x) }
        static member inline create(x: float) = FieldsetBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = FieldsetBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = FieldsetBuilder() { childContent x }

    let fieldset = FieldsetBuilder()


    type FigcaptionBuilder() =
        inherit EltWithChild "figcaption"

        static member inline create(x: string) =
            FigcaptionBuilder() { childContent (html.text x) }
        static member inline create(x: int) =
            FigcaptionBuilder() { childContent (html.text x) }
        static member inline create(x: float) =
            FigcaptionBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = FigcaptionBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = FigcaptionBuilder() { childContent x }

    let figcaption = FigcaptionBuilder()


    type FigureBuilder() =
        inherit EltWithChild "figure"

        static member inline create(x: string) = FigureBuilder() { childContent (html.text x) }
        static member inline create(x: int) = FigureBuilder() { childContent (html.text x) }
        static member inline create(x: float) = FigureBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = FigureBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = FigureBuilder() { childContent x }

    let figure = FigureBuilder()


    type FontBuilder() =
        inherit EltWithChild "font"

        static member inline create(x: string) = FontBuilder() { childContent (html.text x) }
        static member inline create(x: int) = FontBuilder() { childContent (html.text x) }
        static member inline create(x: float) = FontBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = FontBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = FontBuilder() { childContent x }

    let font = FontBuilder()


    type FooterBuilder() =
        inherit EltWithChild "footer"

        static member inline create(x: string) = FooterBuilder() { childContent (html.text x) }
        static member inline create(x: int) = FooterBuilder() { childContent (html.text x) }
        static member inline create(x: float) = FooterBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = FooterBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = FooterBuilder() { childContent x }

    let footer = FooterBuilder()


    type FormBuilder() =
        inherit EltWithChild "form"

        static member inline create(x: string) = FormBuilder() { childContent (html.text x) }
        static member inline create(x: int) = FormBuilder() { childContent (html.text x) }
        static member inline create(x: float) = FormBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = FormBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = FormBuilder() { childContent x }

    let form = FormBuilder()


    type FrameBuilder() =
        inherit EltWithChild "frame"

        static member inline create(x: string) = FrameBuilder() { childContent (html.text x) }
        static member inline create(x: int) = FrameBuilder() { childContent (html.text x) }
        static member inline create(x: float) = FrameBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = FrameBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = FrameBuilder() { childContent x }

    let frame = FrameBuilder()


    type FramesetBuilder() =
        inherit EltWithChild "frameset"

        static member inline create(x: string) = FramesetBuilder() { childContent (html.text x) }
        static member inline create(x: int) = FramesetBuilder() { childContent (html.text x) }
        static member inline create(x: float) = FramesetBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = FramesetBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = FramesetBuilder() { childContent x }

    let frameset = FramesetBuilder()


    type H1Builder() =
        inherit EltWithChild "h1"

        static member inline create(x: string) = H1Builder() { childContent (html.text x) }
        static member inline create(x: int) = H1Builder() { childContent (html.text x) }
        static member inline create(x: float) = H1Builder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = H1Builder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = H1Builder() { childContent x }

    let h1 = H1Builder()


    type H2Builder() =
        inherit EltWithChild "h2"

        static member inline create(x: string) = H2Builder() { childContent (html.text x) }
        static member inline create(x: int) = H2Builder() { childContent (html.text x) }
        static member inline create(x: float) = H2Builder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = H2Builder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = H2Builder() { childContent x }

    let h2 = H2Builder()


    type H3Builder() =
        inherit EltWithChild "h3"

        static member inline create(x: string) = H3Builder() { childContent (html.text x) }
        static member inline create(x: int) = H3Builder() { childContent (html.text x) }
        static member inline create(x: float) = H3Builder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = H3Builder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = H3Builder() { childContent x }

    let h3 = H3Builder()


    type H4Builder() =
        inherit EltWithChild "h4"

        static member inline create(x: string) = H4Builder() { childContent (html.text x) }
        static member inline create(x: int) = H4Builder() { childContent (html.text x) }
        static member inline create(x: float) = H4Builder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = H4Builder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = H4Builder() { childContent x }

    let h4 = H4Builder()


    type H5Builder() =
        inherit EltWithChild "h5"

        static member inline create(x: string) = H5Builder() { childContent (html.text x) }
        static member inline create(x: int) = H5Builder() { childContent (html.text x) }
        static member inline create(x: float) = H5Builder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = H5Builder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = H5Builder() { childContent x }

    let h5 = H5Builder()


    type H6Builder() =
        inherit EltWithChild "h6"

        static member inline create(x: string) = H6Builder() { childContent (html.text x) }
        static member inline create(x: int) = H6Builder() { childContent (html.text x) }
        static member inline create(x: float) = H6Builder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = H6Builder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = H6Builder() { childContent x }

    let h6 = H6Builder()


    type HeadBuilder() =
        inherit EltWithChild "head"

        static member inline create(x: string) = HeadBuilder() { childContent (html.text x) }
        static member inline create(x: int) = HeadBuilder() { childContent (html.text x) }
        static member inline create(x: float) = HeadBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = HeadBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = HeadBuilder() { childContent x }

    let head = HeadBuilder()


    type HeaderBuilder() =
        inherit EltWithChild "header"

        static member inline create(x: string) = HeaderBuilder() { childContent (html.text x) }
        static member inline create(x: int) = HeaderBuilder() { childContent (html.text x) }
        static member inline create(x: float) = HeaderBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = HeaderBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = HeaderBuilder() { childContent x }

    let header = HeaderBuilder()


    type HrBuilder() =
        inherit EltWithChild "hr"

        static member inline create(x: string) = HrBuilder() { childContent (html.text x) }
        static member inline create(x: int) = HrBuilder() { childContent (html.text x) }
        static member inline create(x: float) = HrBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = HrBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = HrBuilder() { childContent x }

    let hr = HrBuilder()


    type HtmlBuilder() =
        inherit EltWithChild "html'"

        static member inline create(x: string) = HtmlBuilder() { childContent (html.text x) }
        static member inline create(x: int) = HtmlBuilder() { childContent (html.text x) }
        static member inline create(x: float) = HtmlBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = HtmlBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = HtmlBuilder() { childContent x }

    let html' = HtmlBuilder()


    type IBuilder() =
        inherit EltWithChild "i"

        static member inline create(x: string) = IBuilder() { childContent (html.text x) }
        static member inline create(x: int) = IBuilder() { childContent (html.text x) }
        static member inline create(x: float) = IBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = IBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = IBuilder() { childContent x }

    let i = IBuilder()


    type IframeBuilder() =
        inherit EltWithChild "iframe"

        static member inline create(x: string) = IframeBuilder() { childContent (html.text x) }
        static member inline create(x: int) = IframeBuilder() { childContent (html.text x) }
        static member inline create(x: float) = IframeBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = IframeBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = IframeBuilder() { childContent x }

    let iframe = IframeBuilder()


    type InputBuilder() =
        inherit EltWithChild "input"

        static member inline create(x: string) = InputBuilder() { childContent (html.text x) }
        static member inline create(x: int) = InputBuilder() { childContent (html.text x) }
        static member inline create(x: float) = InputBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = InputBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = InputBuilder() { childContent x }

    let input = InputBuilder()


    type InsBuilder() =
        inherit EltWithChild "ins"

        static member inline create(x: string) = InsBuilder() { childContent (html.text x) }
        static member inline create(x: int) = InsBuilder() { childContent (html.text x) }
        static member inline create(x: float) = InsBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = InsBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = InsBuilder() { childContent x }

    let ins = InsBuilder()


    type KbdBuilder() =
        inherit EltWithChild "kbd"

        static member inline create(x: string) = KbdBuilder() { childContent (html.text x) }
        static member inline create(x: int) = KbdBuilder() { childContent (html.text x) }
        static member inline create(x: float) = KbdBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = KbdBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = KbdBuilder() { childContent x }

    let kbd = KbdBuilder()


    type LabelBuilder() =
        inherit EltWithChild "label"

        static member inline create(x: string) = LabelBuilder() { childContent (html.text x) }
        static member inline create(x: int) = LabelBuilder() { childContent (html.text x) }
        static member inline create(x: float) = LabelBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = LabelBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = LabelBuilder() { childContent x }

    let label = LabelBuilder()


    type LegendBuilder() =
        inherit EltWithChild "legend"

        static member inline create(x: string) = LegendBuilder() { childContent (html.text x) }
        static member inline create(x: int) = LegendBuilder() { childContent (html.text x) }
        static member inline create(x: float) = LegendBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = LegendBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = LegendBuilder() { childContent x }

    let legend = LegendBuilder()


    type LiBuilder() =
        inherit EltWithChild "li"

        static member inline create(x: string) = LiBuilder() { childContent (html.text x) }
        static member inline create(x: int) = LiBuilder() { childContent (html.text x) }
        static member inline create(x: float) = LiBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = LiBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = LiBuilder() { childContent x }

    let li = LiBuilder()


    type LinkBuilder() =
        inherit EltWithChild "link"

        static member inline create(x: string) = LinkBuilder() { childContent (html.text x) }
        static member inline create(x: int) = LinkBuilder() { childContent (html.text x) }
        static member inline create(x: float) = LinkBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = LinkBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = LinkBuilder() { childContent x }

    let link = LinkBuilder()


    type MainBuilder() =
        inherit EltWithChild "main"

        static member inline create(x: string) = MainBuilder() { childContent (html.text x) }
        static member inline create(x: int) = MainBuilder() { childContent (html.text x) }
        static member inline create(x: float) = MainBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = MainBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = MainBuilder() { childContent x }

    let main = MainBuilder()


    type MapBuilder() =
        inherit EltWithChild "map"

        static member inline create(x: string) = MapBuilder() { childContent (html.text x) }
        static member inline create(x: int) = MapBuilder() { childContent (html.text x) }
        static member inline create(x: float) = MapBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = MapBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = MapBuilder() { childContent x }

    let map = MapBuilder()


    type MarkBuilder() =
        inherit EltWithChild "mark"

        static member inline create(x: string) = MarkBuilder() { childContent (html.text x) }
        static member inline create(x: int) = MarkBuilder() { childContent (html.text x) }
        static member inline create(x: float) = MarkBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = MarkBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = MarkBuilder() { childContent x }

    let mark = MarkBuilder()


    type MenuBuilder() =
        inherit EltWithChild "menu"

        static member inline create(x: string) = MenuBuilder() { childContent (html.text x) }
        static member inline create(x: int) = MenuBuilder() { childContent (html.text x) }
        static member inline create(x: float) = MenuBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = MenuBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = MenuBuilder() { childContent x }

    let menu = MenuBuilder()


    type MenuitemBuilder() =
        inherit EltWithChild "menuitem"

        static member inline create(x: string) = MenuitemBuilder() { childContent (html.text x) }
        static member inline create(x: int) = MenuitemBuilder() { childContent (html.text x) }
        static member inline create(x: float) = MenuitemBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = MenuitemBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = MenuitemBuilder() { childContent x }

    let menuitem = MenuitemBuilder()


    type MetaBuilder() =
        inherit EltWithChild "meta"

        static member inline create(x: string) = MetaBuilder() { childContent (html.text x) }
        static member inline create(x: int) = MetaBuilder() { childContent (html.text x) }
        static member inline create(x: float) = MetaBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = MetaBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = MetaBuilder() { childContent x }

    let meta = MetaBuilder()


    type MeterBuilder() =
        inherit EltWithChild "meter"

        static member inline create(x: string) = MeterBuilder() { childContent (html.text x) }
        static member inline create(x: int) = MeterBuilder() { childContent (html.text x) }
        static member inline create(x: float) = MeterBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = MeterBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = MeterBuilder() { childContent x }

    let meter = MeterBuilder()


    type NavBuilder() =
        inherit EltWithChild "nav"

        static member inline create(x: string) = NavBuilder() { childContent (html.text x) }
        static member inline create(x: int) = NavBuilder() { childContent (html.text x) }
        static member inline create(x: float) = NavBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = NavBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = NavBuilder() { childContent x }

    let nav = NavBuilder()


    type NoembedBuilder() =
        inherit EltWithChild "noembed"

        static member inline create(x: string) = NoembedBuilder() { childContent (html.text x) }
        static member inline create(x: int) = NoembedBuilder() { childContent (html.text x) }
        static member inline create(x: float) = NoembedBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = NoembedBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = NoembedBuilder() { childContent x }

    let noembed = NoembedBuilder()


    type NoframesBuilder() =
        inherit EltWithChild "noframes"

        static member inline create(x: string) = NoframesBuilder() { childContent (html.text x) }
        static member inline create(x: int) = NoframesBuilder() { childContent (html.text x) }
        static member inline create(x: float) = NoframesBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = NoframesBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = NoframesBuilder() { childContent x }

    let noframes = NoframesBuilder()


    type NoscriptBuilder() =
        inherit EltWithChild "noscript"

        static member inline create(x: string) = NoscriptBuilder() { childContent (html.text x) }
        static member inline create(x: int) = NoscriptBuilder() { childContent (html.text x) }
        static member inline create(x: float) = NoscriptBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = NoscriptBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = NoscriptBuilder() { childContent x }

    let noscript = NoscriptBuilder()


    type ObjectBuilder() =
        inherit EltWithChild "object"

        static member inline create(x: string) = ObjectBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ObjectBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ObjectBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ObjectBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ObjectBuilder() { childContent x }

    let object = ObjectBuilder()


    type OlBuilder() =
        inherit EltWithChild "ol"

        static member inline create(x: string) = OlBuilder() { childContent (html.text x) }
        static member inline create(x: int) = OlBuilder() { childContent (html.text x) }
        static member inline create(x: float) = OlBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = OlBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = OlBuilder() { childContent x }

    let ol = OlBuilder()


    type OptgroupBuilder() =
        inherit EltWithChild "optgroup"

        static member inline create(x: string) = OptgroupBuilder() { childContent (html.text x) }
        static member inline create(x: int) = OptgroupBuilder() { childContent (html.text x) }
        static member inline create(x: float) = OptgroupBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = OptgroupBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = OptgroupBuilder() { childContent x }

    let optgroup = OptgroupBuilder()


    type OptionBuilder() =
        inherit EltWithChild "option"

        static member inline create(x: string) = OptionBuilder() { childContent (html.text x) }
        static member inline create(x: int) = OptionBuilder() { childContent (html.text x) }
        static member inline create(x: float) = OptionBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = OptionBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = OptionBuilder() { childContent x }

    let option = OptionBuilder()


    type OutputBuilder() =
        inherit EltWithChild "output"

        static member inline create(x: string) = OutputBuilder() { childContent (html.text x) }
        static member inline create(x: int) = OutputBuilder() { childContent (html.text x) }
        static member inline create(x: float) = OutputBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = OutputBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = OutputBuilder() { childContent x }

    let output = OutputBuilder()


    type PBuilder() =
        inherit EltWithChild "p"

        static member inline create(x: string) = PBuilder() { childContent (html.text x) }
        static member inline create(x: int) = PBuilder() { childContent (html.text x) }
        static member inline create(x: float) = PBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = PBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = PBuilder() { childContent x }

    let p = PBuilder()


    type ParamBuilder() =
        inherit EltWithChild "param"

        static member inline create(x: string) = ParamBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ParamBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ParamBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ParamBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ParamBuilder() { childContent x }

    let param = ParamBuilder()


    type PictureBuilder() =
        inherit EltWithChild "picture"

        static member inline create(x: string) = PictureBuilder() { childContent (html.text x) }
        static member inline create(x: int) = PictureBuilder() { childContent (html.text x) }
        static member inline create(x: float) = PictureBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = PictureBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = PictureBuilder() { childContent x }

    let picture = PictureBuilder()


    type PreBuilder() =
        inherit EltWithChild "pre"

        static member inline create(x: string) = PreBuilder() { childContent (html.text x) }
        static member inline create(x: int) = PreBuilder() { childContent (html.text x) }
        static member inline create(x: float) = PreBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = PreBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = PreBuilder() { childContent x }

    let pre = PreBuilder()


    type ProgressBuilder() =
        inherit EltWithChild "progress"

        static member inline create(x: string) = ProgressBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ProgressBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ProgressBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ProgressBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ProgressBuilder() { childContent x }

    let progress = ProgressBuilder()


    type QBuilder() =
        inherit EltWithChild "q"

        static member inline create(x: string) = QBuilder() { childContent (html.text x) }
        static member inline create(x: int) = QBuilder() { childContent (html.text x) }
        static member inline create(x: float) = QBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = QBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = QBuilder() { childContent x }

    let q = QBuilder()


    type RbBuilder() =
        inherit EltWithChild "rb"

        static member inline create(x: string) = RbBuilder() { childContent (html.text x) }
        static member inline create(x: int) = RbBuilder() { childContent (html.text x) }
        static member inline create(x: float) = RbBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = RbBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = RbBuilder() { childContent x }

    let rb = RbBuilder()


    type RpBuilder() =
        inherit EltWithChild "rp"

        static member inline create(x: string) = RpBuilder() { childContent (html.text x) }
        static member inline create(x: int) = RpBuilder() { childContent (html.text x) }
        static member inline create(x: float) = RpBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = RpBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = RpBuilder() { childContent x }

    let rp = RpBuilder()


    type RtBuilder() =
        inherit EltWithChild "rt"

        static member inline create(x: string) = RtBuilder() { childContent (html.text x) }
        static member inline create(x: int) = RtBuilder() { childContent (html.text x) }
        static member inline create(x: float) = RtBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = RtBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = RtBuilder() { childContent x }

    let rt = RtBuilder()


    type RtcBuilder() =
        inherit EltWithChild "rtc"

        static member inline create(x: string) = RtcBuilder() { childContent (html.text x) }
        static member inline create(x: int) = RtcBuilder() { childContent (html.text x) }
        static member inline create(x: float) = RtcBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = RtcBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = RtcBuilder() { childContent x }

    let rtc = RtcBuilder()


    type RubyBuilder() =
        inherit EltWithChild "ruby"

        static member inline create(x: string) = RubyBuilder() { childContent (html.text x) }
        static member inline create(x: int) = RubyBuilder() { childContent (html.text x) }
        static member inline create(x: float) = RubyBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = RubyBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = RubyBuilder() { childContent x }

    let ruby = RubyBuilder()


    type SBuilder() =
        inherit EltWithChild "s"

        static member inline create(x: string) = SBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SBuilder() { childContent x }

    let s = SBuilder()


    type SampBuilder() =
        inherit EltWithChild "samp"

        static member inline create(x: string) = SampBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SampBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SampBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SampBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SampBuilder() { childContent x }

    let samp = SampBuilder()


    type ScriptBuilder() =
        inherit EltWithChild "script"

        static member inline create(x: string) = ScriptBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ScriptBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ScriptBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ScriptBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ScriptBuilder() { childContent x }

    let script = ScriptBuilder()


    type SectionBuilder() =
        inherit EltWithChild "section"

        static member inline create(x: string) = SectionBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SectionBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SectionBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SectionBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SectionBuilder() { childContent x }

    let section = SectionBuilder()


    type SelectBuilder() =
        inherit EltWithChild "select"

        static member inline create(x: string) = SelectBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SelectBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SelectBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SelectBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SelectBuilder() { childContent x }

    let select = SelectBuilder()


    type ShadowBuilder() =
        inherit EltWithChild "shadow"

        static member inline create(x: string) = ShadowBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ShadowBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ShadowBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ShadowBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ShadowBuilder() { childContent x }

    let shadow = ShadowBuilder()


    type SlotBuilder() =
        inherit EltWithChild "slot"

        static member inline create(x: string) = SlotBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SlotBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SlotBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SlotBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SlotBuilder() { childContent x }

    let slot = SlotBuilder()


    type SmallBuilder() =
        inherit EltWithChild "small"

        static member inline create(x: string) = SmallBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SmallBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SmallBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SmallBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SmallBuilder() { childContent x }

    let small = SmallBuilder()


    type SourceBuilder() =
        inherit EltWithChild "source"

        static member inline create(x: string) = SourceBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SourceBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SourceBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SourceBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SourceBuilder() { childContent x }

    let source = SourceBuilder()


    type SpanBuilder() =
        inherit EltWithChild "span"

        static member inline create(x: string) = SpanBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SpanBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SpanBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SpanBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SpanBuilder() { childContent x }

    let span = SpanBuilder()


    type StrikeBuilder() =
        inherit EltWithChild "strike"

        static member inline create(x: string) = StrikeBuilder() { childContent (html.text x) }
        static member inline create(x: int) = StrikeBuilder() { childContent (html.text x) }
        static member inline create(x: float) = StrikeBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = StrikeBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = StrikeBuilder() { childContent x }

    let strike = StrikeBuilder()


    type StrongBuilder() =
        inherit EltWithChild "strong"

        static member inline create(x: string) = StrongBuilder() { childContent (html.text x) }
        static member inline create(x: int) = StrongBuilder() { childContent (html.text x) }
        static member inline create(x: float) = StrongBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = StrongBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = StrongBuilder() { childContent x }

    let strong = StrongBuilder()


    type StyleBuilder() =
        inherit EltWithChild "style'"

        static member inline create(x: string) = StyleBuilder() { childContent (html.text x) }
        static member inline create(x: int) = StyleBuilder() { childContent (html.text x) }
        static member inline create(x: float) = StyleBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = StyleBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = StyleBuilder() { childContent x }

    let style' = StyleBuilder()


    type SubBuilder() =
        inherit EltWithChild "sub"

        static member inline create(x: string) = SubBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SubBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SubBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SubBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SubBuilder() { childContent x }

    let sub = SubBuilder()


    type SummaryBuilder() =
        inherit EltWithChild "summary"

        static member inline create(x: string) = SummaryBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SummaryBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SummaryBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SummaryBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SummaryBuilder() { childContent x }

    let summary = SummaryBuilder()


    type SupBuilder() =
        inherit EltWithChild "sup"

        static member inline create(x: string) = SupBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SupBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SupBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SupBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SupBuilder() { childContent x }

    let sup = SupBuilder()


    type SvgBuilder() =
        inherit EltWithChild "svg"

        static member inline create(x: string) = SvgBuilder() { childContent (html.text x) }
        static member inline create(x: int) = SvgBuilder() { childContent (html.text x) }
        static member inline create(x: float) = SvgBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = SvgBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = SvgBuilder() { childContent x }

    let svg = SvgBuilder()


    type TableBuilder() =
        inherit EltWithChild "table"

        static member inline create(x: string) = TableBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TableBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TableBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TableBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TableBuilder() { childContent x }

    let table = TableBuilder()


    type TbodyBuilder() =
        inherit EltWithChild "tbody"

        static member inline create(x: string) = TbodyBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TbodyBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TbodyBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TbodyBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TbodyBuilder() { childContent x }

    let tbody = TbodyBuilder()


    type TdBuilder() =
        inherit EltWithChild "td"

        static member inline create(x: string) = TdBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TdBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TdBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TdBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TdBuilder() { childContent x }

    let td = TdBuilder()


    type TemplateBuilder() =
        inherit EltWithChild "template"

        static member inline create(x: string) = TemplateBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TemplateBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TemplateBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TemplateBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TemplateBuilder() { childContent x }

    let template = TemplateBuilder()


    type TextareaBuilder() =
        inherit EltWithChild "textarea"

        static member inline create(x: string) = TextareaBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TextareaBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TextareaBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TextareaBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TextareaBuilder() { childContent x }

    let textarea = TextareaBuilder()


    type TfootBuilder() =
        inherit EltWithChild "tfoot"

        static member inline create(x: string) = TfootBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TfootBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TfootBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TfootBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TfootBuilder() { childContent x }

    let tfoot = TfootBuilder()


    type ThBuilder() =
        inherit EltWithChild "th"

        static member inline create(x: string) = ThBuilder() { childContent (html.text x) }
        static member inline create(x: int) = ThBuilder() { childContent (html.text x) }
        static member inline create(x: float) = ThBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = ThBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = ThBuilder() { childContent x }

    let th = ThBuilder()


    type TheadBuilder() =
        inherit EltWithChild "thead"

        static member inline create(x: string) = TheadBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TheadBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TheadBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TheadBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TheadBuilder() { childContent x }

    let thead = TheadBuilder()


    type TimeBuilder() =
        inherit EltWithChild "time"

        static member inline create(x: string) = TimeBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TimeBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TimeBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TimeBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TimeBuilder() { childContent x }

    let time = TimeBuilder()


    type TitleBuilder() =
        inherit EltWithChild "title"

        static member inline create(x: string) = TitleBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TitleBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TitleBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TitleBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TitleBuilder() { childContent x }

    let title = TitleBuilder()


    type TrBuilder() =
        inherit EltWithChild "tr"

        static member inline create(x: string) = TrBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TrBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TrBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TrBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TrBuilder() { childContent x }

    let tr = TrBuilder()


    type TrackBuilder() =
        inherit EltWithChild "track"

        static member inline create(x: string) = TrackBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TrackBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TrackBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TrackBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TrackBuilder() { childContent x }

    let track = TrackBuilder()


    type TtBuilder() =
        inherit EltWithChild "tt"

        static member inline create(x: string) = TtBuilder() { childContent (html.text x) }
        static member inline create(x: int) = TtBuilder() { childContent (html.text x) }
        static member inline create(x: float) = TtBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = TtBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = TtBuilder() { childContent x }

    let tt = TtBuilder()


    type UBuilder() =
        inherit EltWithChild "u"

        static member inline create(x: string) = UBuilder() { childContent (html.text x) }
        static member inline create(x: int) = UBuilder() { childContent (html.text x) }
        static member inline create(x: float) = UBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = UBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = UBuilder() { childContent x }

    let u = UBuilder()


    type UlBuilder() =
        inherit EltWithChild "ul"

        static member inline create(x: string) = UlBuilder() { childContent (html.text x) }
        static member inline create(x: int) = UlBuilder() { childContent (html.text x) }
        static member inline create(x: float) = UlBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = UlBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = UlBuilder() { childContent x }

    let ul = UlBuilder()


    type VarBuilder() =
        inherit EltWithChild "var"

        static member inline create(x: string) = VarBuilder() { childContent (html.text x) }
        static member inline create(x: int) = VarBuilder() { childContent (html.text x) }
        static member inline create(x: float) = VarBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = VarBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = VarBuilder() { childContent x }

    let var = VarBuilder()


    type VideoBuilder() =
        inherit EltWithChild "video"

        static member inline create(x: string) = VideoBuilder() { childContent (html.text x) }
        static member inline create(x: int) = VideoBuilder() { childContent (html.text x) }
        static member inline create(x: float) = VideoBuilder() { childContent (html.text x) }
        static member inline create(x: FunRenderFragment) = VideoBuilder() { childContent x }
        static member inline create(x: FunRenderFragment seq) = VideoBuilder() { childContent x }

    let video = VideoBuilder()


    type WbrBuilder() =
        inherit EltWithDomAttrs "wbr"

    type wbr = WbrBuilder


    type ImgBuilder() =
        inherit EltWithDomAttrs "img"

    let img = ImgBuilder()
