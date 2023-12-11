namespace Fun.Blazor

open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Operators
open Internal


type DomAttrBuilder() =
    interface IFunBlazorBuilder

    member inline _.Run([<InlineIfLambda>] x: AttrRenderFragment) = AttrRenderFragment(fun c b i -> x.Invoke(c, b, i))
    member inline _.Run(AttrRenderFragmentWrapper x) = x


    member inline _.Yield(_: unit) = emptyAttr ()

    member inline _.Yield([<InlineIfLambda>] x: AttrRenderFragment) = x


    member inline _.Yield((key, value): string * string) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, key, value)
            index + 1
        )

    member inline _.Yield((key, value): string * int) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, key, value)
            index + 1
        )

    member inline _.Yield((key, value): string * float) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, key, value)
            index + 1
        )

    member inline _.Yield((key, value): string * bool) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, key, value)
            index + 1
        )

    member inline _.Yield((key, fn): string * (unit -> unit)) = html.callback (key, fn)
    member inline _.Yield((key, fn): string * ('T -> unit)) = html.callback (key, fn)
    member inline _.Yield((key, fn): string * (unit -> Task<unit>)) = html.callbackTask (key, fn)
    member inline _.Yield((key, fn): string * ('T -> Task<unit>)) = html.callbackTask (key, fn)


    member inline _.Delay([<InlineIfLambda>] fn: unit -> AttrRenderFragment) = AttrRenderFragment(fun c b i -> fn().Invoke(c, b, i))
    member inline _.Delay([<InlineIfLambda>] fn: unit -> AttrRenderFragmentWrapper) = fn ()

    member inline _.Combine([<InlineIfLambda>] render1: AttrRenderFragment, [<InlineIfLambda>] render2: AttrRenderFragment) = render1 ==> render2

    member inline _.For([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: unit -> AttrRenderFragment) = render ==> (fn ())

    //member inline _.For(renders: 'T seq, [<InlineIfLambda>] fn: 'T -> AttrRenderFragment) =
    //    renders |> Seq.map fn |> Seq.fold (==>) (emptyAttr ())

    member inline _.YieldFrom(renders: AttrRenderFragment seq) = renders |> Seq.fold (==>) (emptyAttr ())


    member inline _.Zero() = emptyAttr ()

    
    /// key for blazor
    [<CustomOperation("key")>]
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, k) = render ==> html.key k

    /// A helper to make CE work without set any real attributes.
    [<CustomOperation("empty")>]
    member inline _.empty([<InlineIfLambda>] render: AttrRenderFragment) = render

    [<CustomOperation("asAttrRenderFragment")>]
    member inline _.asAttrRenderFragment(render: AttrRenderFragment) = AttrRenderFragmentWrapper render


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

    [<CustomOperation("callback")>]
    member inline _.callback([<InlineIfLambda>] render: AttrRenderFragment, eventName, [<InlineIfLambda>] callback: 'T -> Task<unit>) =
        render ==> html.callbackTask (eventName, callback)


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

#if !NET6_0
    /// Enhanced navigation is enabled by default, but it can be controlled hierarchically and on a per-link basis using the data-enhance-nav HTML attribute.
    [<CustomOperation("dataEnhanceNav")>]
    member inline _.dataEnhanceNav([<InlineIfLambda>] render: AttrRenderFragment, value: bool) =
        render ==> ("data-enhance-nav" => (if value then "true" else "false"))

    /// Enhanced navigation is enabled by default, but it can be controlled hierarchically and on a per-link basis using the data-enhance-nav HTML attribute.
    [<CustomOperation("dataEnhanceNav")>]
    member inline this.dataEnhanceNav([<InlineIfLambda>] render: AttrRenderFragment) = this.dataEnhanceNav(render, true)

    /// Blazor's enhanced navigation and form handing may undo dynamic changes to the DOM if the updated content isn't part of the server rendering. To preserve the content of an element, use the data-permanent attribute.
    [<CustomOperation("dataPermanent")>]
    member inline _.dataPermanent([<InlineIfLambda>] render: AttrRenderFragment, value: bool) =
        render ==> ("permanent" => (if value then "true" else "false"))

    /// Blazor's enhanced navigation and form handing may undo dynamic changes to the DOM if the updated content isn't part of the server rendering. To preserve the content of an element, use the data-permanent attribute.
    [<CustomOperation("dataPermanent")>]
    member inline this.dataPermanent([<InlineIfLambda>] render: AttrRenderFragment) = this.dataPermanent(render, true)
#endif

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
    /// true is for "on", false is for "off"
    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v: bool) = render ==> ("autocomplete" =>> (if v then "on" else "off"))
    [<CustomOperation("autocomplete")>]
    member inline this.autocomplete([<InlineIfLambda>] render: AttrRenderFragment) = this.autocomplete(render, true)
    /// You can use AutoCompleteValues to get available values
    [<CustomOperation("autocomplete")>]
    member inline _.autocomplete([<InlineIfLambda>] render: AttrRenderFragment, v: string) = render ==> ("autocomplete" => v)
    [<CustomOperation("autofocus")>]
    member inline _.autofocus([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autofocus" =>>> v)
    [<CustomOperation("autofocus")>]
    member inline this.autofocus([<InlineIfLambda>] render: AttrRenderFragment) = this.autofocus(render, true)
    [<CustomOperation("autoplay")>]
    member inline _.autoplay([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("autoplay" =>>> v)
    [<CustomOperation("autoplay")>]
    member inline this.autoplay([<InlineIfLambda>] render: AttrRenderFragment) = this.autoplay(render, true)
    [<CustomOperation("bgcolor")>]
    member inline _.bgcolor([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("bgcolor" =>> v)
    [<CustomOperation("border")>]
    member inline _.border([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("border" => v)
    [<CustomOperation("buffered")>]
    member inline _.buffered([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("buffered" =>>> v)
    [<CustomOperation("buffered")>]
    member inline this.buffered([<InlineIfLambda>] render: AttrRenderFragment) = this.buffered(render, true)
    [<CustomOperation("challenge")>]
    member inline _.challenge([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("challenge" => v)
    [<CustomOperation("charset")>]
    member inline _.charset([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("charset" =>> v)
    [<CustomOperation("checked'")>]
    member inline _.checked'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("checked" =>>> v)
    [<CustomOperation("checked'")>]
    member inline this.checked'([<InlineIfLambda>] render: AttrRenderFragment) = this.checked'(render, true)
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
    member inline _.controls([<InlineIfLambda>] render: AttrRenderFragment) = render ==> ("controls" =>>> true)
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
    [<CustomOperation("data")>]
    member inline _.data([<InlineIfLambda>] render: AttrRenderFragment, key: string, v) = render ==> ("data-" + key => v)
    [<CustomOperation("datetime")>]
    member inline _.datetime([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("datetime" => v)
    [<CustomOperation("decoding")>]
    member inline _.decoding([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("decoding" => v)
    [<CustomOperation("default'")>]
    member inline _.default'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("default" => v)
    [<CustomOperation("defer")>]
    member inline _.defer([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("defer" => v)
    [<CustomOperation("dir")>]
    member inline _.dir([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dir" =>> v)
    [<CustomOperation("dirname")>]
    member inline _.dirname([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dirname" =>> v)
    [<CustomOperation("disabled")>]
    member inline _.disabled([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("disabled" =>>> v)
    [<CustomOperation("disabled")>]
    member inline this.disabled([<InlineIfLambda>] render: AttrRenderFragment) = this.disabled(render, true)
    [<CustomOperation("download")>]
    member inline _.download([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("download" =>>> v)
    [<CustomOperation("draggable")>]
    member _.draggable(render: AttrRenderFragment, v: bool) = render ==> ("draggable" => (if v then "true" else "false"))
    [<CustomOperation("draggable")>]
    member this.draggable(render: AttrRenderFragment) = this.draggable(render, true)
    [<CustomOperation("dropzone")>]
    member inline _.dropzone([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("dropzone" => v)
    [<CustomOperation("enctype")>]
    member inline _.enctype([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("enctype" => v)
    [<CustomOperation("for'")>]
    member inline _.for'([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("for" => v)
    [<CustomOperation("form'")>]
    member inline _.form([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("form" => v)
    [<CustomOperation("formaction")>]
    member inline _.formaction([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("formaction" => v)
    [<CustomOperation("headers")>]
    member inline _.headers([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("headers" => v)
    [<CustomOperation("height")>]
    member inline _.height([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("height" => v)
    [<CustomOperation("hidden")>]
    member inline _.hidden([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("hidden" =>>> v)
    [<CustomOperation("hidden")>]
    member inline this.hidden([<InlineIfLambda>] render: AttrRenderFragment) = this.hidden(render, true)
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
    [<CustomOperation("importance")>]
    member inline this.importance([<InlineIfLambda>] render: AttrRenderFragment, v) = this.importance(render, true)
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
    [<CustomOperation("label'")>]
    member inline _.label([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("label" =>> v)
    [<CustomOperation("lang")>]
    member inline _.lang([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lang" =>> v)
    [<CustomOperation("language")>]
    member inline _.language([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("language" =>> v)
    [<CustomOperation("lazyload")>]
    member inline _.lazyload([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("lazyload" =>>> v)
    [<CustomOperation("lazyload")>]
    member inline this.lazyload([<InlineIfLambda>] render: AttrRenderFragment) = this.lazyload(render, true)
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
    [<CustomOperation("open'")>]
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
    [<CustomOperation("readonly")>]
    member inline this.readonly([<InlineIfLambda>] render: AttrRenderFragment) = this.readonly(render, true)
    [<CustomOperation("rel")>]
    member inline _.rel([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("rel" => v)
    [<CustomOperation("required")>]
    member inline _.required([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("required" =>>> v)
    [<CustomOperation("required")>]
    member inline this.required([<InlineIfLambda>] render: AttrRenderFragment) = this.required(render, true)
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
    [<CustomOperation("selected")>]
    member inline this.selected([<InlineIfLambda>] render: AttrRenderFragment) = this.selected(render, true)
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
    [<CustomOperation("usemap")>]
    member inline _.usemap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("usemap" => v)
    
    [<CustomOperation("value")>]
    member inline _.value<'T>([<InlineIfLambda>] render: AttrRenderFragment, v: 'T) =
        render ==> ("value" => (if typeof<'T> = typeof<bool> then box (string v) else box v))

    [<CustomOperation("width")>]
    member inline _.width([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("width" => v)
    [<CustomOperation("wrap")>]
    member inline _.wrap([<InlineIfLambda>] render: AttrRenderFragment, v) = render ==> ("wrap" => v)
