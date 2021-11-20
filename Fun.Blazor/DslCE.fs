namespace Fun.Blazor

open Bolero
open Bolero.Html
open Fun.Blazor
open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web


type FunBlazorBuilderWithDomAttrs<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorBuilder<'Component>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'Component>, v: Node list) = this.AddNodes v
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'Component>, v: string) = Text v |> this.AddNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'Component>, v: int) = Text (string v) |> this.AddNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'Component>, v: float) = Text (string v) |> this.AddNode
    [<CustomOperation("childContentRaw")>] member this.childContentRaw (_: FunBlazorBuilder<'Component>, v: string) = RawHtml v |> this.AddNode
    
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorBuilder<'Component>, v: string list) = attr.classes v |> this.AddAttr
    
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
    member this.css (_: FunBlazorBuilder<'Component>, css: string) =
        let result =
            if String.IsNullOrEmpty css then ""
            elif css.StartsWith "_{" then
                let lastEndIndex = css.LastIndexOf "}"
                if css.Substring(lastEndIndex + 1).Trim().Split("\n") |> Seq.filter (String.IsNullOrEmpty >> not) |> Seq.length = 0 then
                    css.Substring(2, lastEndIndex - 2).Split("\n") |> Seq.map (fun x -> x.Trim()) |> String.concat " "
                else
                    css
            else
                css            
                
        attr.style result |> this.AddAttr

    
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorBuilder<'Component>, v: (string * string) list) = makeStyles v |> attr.style |> this.AddAttr
    
    [<CustomOperation("class'")>] member this.class' (_: FunBlazorBuilder<'Component>, v: string) = attr.``class`` v |> this.AddAttr
    [<CustomOperation("bindRef")>] member this.bindRef (_: FunBlazorBuilder<'Component>, v: obj) = "bindRef" => v |> this.AddAttr
    [<CustomOperation("key")>] member this.key (_: FunBlazorBuilder<'Component>, v: obj) = "key" => v |> this.AddAttr
    [<CustomOperation("accept")>] member this.accept (_: FunBlazorBuilder<'Component>, v: obj) = "accept" => v |> this.AddAttr
    [<CustomOperation("acceptCharset")>] member this.acceptCharset (_: FunBlazorBuilder<'Component>, v: obj) = "acceptCharset" => v |> this.AddAttr
    [<CustomOperation("accesskey")>] member this.accesskey (_: FunBlazorBuilder<'Component>, v: obj) = "accesskey" => v |> this.AddAttr
    [<CustomOperation("action")>] member this.action (_: FunBlazorBuilder<'Component>, v: obj) = "action" => v |> this.AddAttr
    [<CustomOperation("align")>] member this.align (_: FunBlazorBuilder<'Component>, v: obj) = "align" => v |> this.AddAttr
    [<CustomOperation("allow")>] member this.allow (_: FunBlazorBuilder<'Component>, v: obj) = "allow" => v |> this.AddAttr
    [<CustomOperation("alt")>] member this.alt (_: FunBlazorBuilder<'Component>, v: obj) = "alt" => v |> this.AddAttr
    [<CustomOperation("async'")>] member this.async' (_: FunBlazorBuilder<'Component>, v: obj) = "async'" => v |> this.AddAttr
    [<CustomOperation("autocapitalize")>] member this.autocapitalize (_: FunBlazorBuilder<'Component>, v: obj) = "autocapitalize" => v |> this.AddAttr
    [<CustomOperation("autocomplete")>] member this.autocomplete (_: FunBlazorBuilder<'Component>, v: obj) = "autocomplete" => v |> this.AddAttr
    [<CustomOperation("autofocus")>] member this.autofocus (_: FunBlazorBuilder<'Component>, v: obj) = "autofocus" => v |> this.AddAttr
    [<CustomOperation("autoplay")>] member this.autoplay (_: FunBlazorBuilder<'Component>, v: obj) = "autoplay" => v |> this.AddAttr
    [<CustomOperation("bgcolor")>] member this.bgcolor (_: FunBlazorBuilder<'Component>, v: obj) = "bgcolor" => v |> this.AddAttr
    [<CustomOperation("border")>] member this.border (_: FunBlazorBuilder<'Component>, v: obj) = "border" => v |> this.AddAttr
    [<CustomOperation("buffered")>] member this.buffered (_: FunBlazorBuilder<'Component>, v: obj) = "buffered" => v |> this.AddAttr
    [<CustomOperation("challenge")>] member this.challenge (_: FunBlazorBuilder<'Component>, v: obj) = "challenge" => v |> this.AddAttr
    [<CustomOperation("charset")>] member this.charset (_: FunBlazorBuilder<'Component>, v: obj) = "charset" => v |> this.AddAttr
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorBuilder<'Component>, v: obj) = "checked" => v |> this.AddAttr
    [<CustomOperation("cite")>] member this.cite (_: FunBlazorBuilder<'Component>, v: obj) = "cite" => v |> this.AddAttr
    [<CustomOperation("code")>] member this.code (_: FunBlazorBuilder<'Component>, v: obj) = "code" => v |> this.AddAttr
    [<CustomOperation("codebase")>] member this.codebase (_: FunBlazorBuilder<'Component>, v: obj) = "codebase" => v |> this.AddAttr
    [<CustomOperation("color")>] member this.color (_: FunBlazorBuilder<'Component>, v: obj) = "color" => v |> this.AddAttr
    [<CustomOperation("cols")>] member this.cols (_: FunBlazorBuilder<'Component>, v: obj) = "cols" => v |> this.AddAttr
    [<CustomOperation("colspan")>] member this.colspan (_: FunBlazorBuilder<'Component>, v: obj) = "colspan" => v |> this.AddAttr
    [<CustomOperation("content")>] member this.content (_: FunBlazorBuilder<'Component>, v: obj) = "content" => v |> this.AddAttr
    [<CustomOperation("contenteditable")>] member this.contenteditable (_: FunBlazorBuilder<'Component>, v: obj) = "contenteditable" => v |> this.AddAttr
    [<CustomOperation("contextmenu")>] member this.contextmenu (_: FunBlazorBuilder<'Component>, v: obj) = "contextmenu" => v |> this.AddAttr
    [<CustomOperation("controls")>] member this.controls (_: FunBlazorBuilder<'Component>, v: obj) = "controls" => v |> this.AddAttr
    [<CustomOperation("coords")>] member this.coords (_: FunBlazorBuilder<'Component>, v: obj) = "coords" => v |> this.AddAttr
    [<CustomOperation("crossorigin")>] member this.crossorigin (_: FunBlazorBuilder<'Component>, v: obj) = "crossorigin" => v |> this.AddAttr
    [<CustomOperation("csp")>] member this.csp (_: FunBlazorBuilder<'Component>, v: obj) = "csp" => v |> this.AddAttr
    [<CustomOperation("data")>] member this.data (_: FunBlazorBuilder<'Component>, v: obj) = "data" => v |> this.AddAttr
    [<CustomOperation("datetime")>] member this.datetime (_: FunBlazorBuilder<'Component>, v: obj) = "datetime" => v |> this.AddAttr
    [<CustomOperation("decoding")>] member this.decoding (_: FunBlazorBuilder<'Component>, v: obj) = "decoding" => v |> this.AddAttr
    [<CustomOperation("default'")>] member this.default' (_: FunBlazorBuilder<'Component>, v: obj) = "default" => v |> this.AddAttr
    [<CustomOperation("defer")>] member this.defer (_: FunBlazorBuilder<'Component>, v: obj) = "defer" => v |> this.AddAttr
    [<CustomOperation("dir")>] member this.dir (_: FunBlazorBuilder<'Component>, v: obj) = "dir" => v |> this.AddAttr
    [<CustomOperation("dirname")>] member this.dirname (_: FunBlazorBuilder<'Component>, v: obj) = "dirname" => v |> this.AddAttr
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorBuilder<'Component>, v: obj) = "disabled" => v |> this.AddAttr
    [<CustomOperation("download")>] member this.download (_: FunBlazorBuilder<'Component>, v: obj) = "download" => v |> this.AddAttr
    [<CustomOperation("draggable")>] member this.draggable (_: FunBlazorBuilder<'Component>, v: bool) = Attr ("draggable", if v then "true" else "false") |> this.AddAttr
    [<CustomOperation("dropzone")>] member this.dropzone (_: FunBlazorBuilder<'Component>, v: obj) = "dropzone" => v |> this.AddAttr
    [<CustomOperation("enctype")>] member this.enctype (_: FunBlazorBuilder<'Component>, v: obj) = "enctype" => v |> this.AddAttr
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorBuilder<'Component>, v: obj) = "for" => v |> this.AddAttr
    [<CustomOperation("form")>] member this.form (_: FunBlazorBuilder<'Component>, v: obj) = "form" => v |> this.AddAttr
    [<CustomOperation("formaction")>] member this.formaction (_: FunBlazorBuilder<'Component>, v: obj) = "formaction" => v |> this.AddAttr
    [<CustomOperation("headers")>] member this.headers (_: FunBlazorBuilder<'Component>, v: obj) = "headers" => v |> this.AddAttr
    [<CustomOperation("height")>] member this.height (_: FunBlazorBuilder<'Component>, v: obj) = "height" => v |> this.AddAttr
    [<CustomOperation("hidden")>] member this.hidden (_: FunBlazorBuilder<'Component>, v: obj) = "hidden" => v |> this.AddAttr
    [<CustomOperation("high")>] member this.high (_: FunBlazorBuilder<'Component>, v: obj) = "high" => v |> this.AddAttr
    [<CustomOperation("href")>] member this.href (_: FunBlazorBuilder<'Component>, v: obj) = "href" => v |> this.AddAttr
    [<CustomOperation("hreflang")>] member this.hreflang (_: FunBlazorBuilder<'Component>, v: obj) = "hreflang" => v |> this.AddAttr
    [<CustomOperation("httpEquiv")>] member this.httpEquiv (_: FunBlazorBuilder<'Component>, v: obj) = "httpEquiv" => v |> this.AddAttr
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorBuilder<'Component>, v: obj) = "icon" => v |> this.AddAttr
    [<CustomOperation("id")>] member this.id (_: FunBlazorBuilder<'Component>, v: obj) = "id" => v |> this.AddAttr
    [<CustomOperation("importance")>] member this.importance (_: FunBlazorBuilder<'Component>, v: obj) = "importance" => v |> this.AddAttr
    [<CustomOperation("integrity")>] member this.integrity (_: FunBlazorBuilder<'Component>, v: obj) = "integrity" => v |> this.AddAttr
    [<CustomOperation("ismap")>] member this.ismap (_: FunBlazorBuilder<'Component>, v: obj) = "ismap" => v |> this.AddAttr
    [<CustomOperation("itemprop")>] member this.itemprop (_: FunBlazorBuilder<'Component>, v: obj) = "itemprop" => v |> this.AddAttr
    [<CustomOperation("keytype")>] member this.keytype (_: FunBlazorBuilder<'Component>, v: obj) = "keytype" => v |> this.AddAttr
    [<CustomOperation("kind")>] member this.kind (_: FunBlazorBuilder<'Component>, v: obj) = "kind" => v |> this.AddAttr
    [<CustomOperation("label")>] member this.label (_: FunBlazorBuilder<'Component>, v: obj) = "label" => v |> this.AddAttr
    [<CustomOperation("lang")>] member this.lang (_: FunBlazorBuilder<'Component>, v: obj) = "lang" => v |> this.AddAttr
    [<CustomOperation("language")>] member this.language (_: FunBlazorBuilder<'Component>, v: obj) = "language" => v |> this.AddAttr
    [<CustomOperation("lazyload")>] member this.lazyload (_: FunBlazorBuilder<'Component>, v: obj) = "lazyload" => v |> this.AddAttr
    [<CustomOperation("list")>] member this.list (_: FunBlazorBuilder<'Component>, v: obj) = "list" => v |> this.AddAttr
    [<CustomOperation("loop")>] member this.loop (_: FunBlazorBuilder<'Component>, v: obj) = "loop" => v |> this.AddAttr
    [<CustomOperation("low")>] member this.low (_: FunBlazorBuilder<'Component>, v: obj) = "low" => v |> this.AddAttr
    [<CustomOperation("manifest")>] member this.manifest (_: FunBlazorBuilder<'Component>, v: obj) = "manifest" => v |> this.AddAttr
    [<CustomOperation("max")>] member this.max (_: FunBlazorBuilder<'Component>, v: obj) = "max" => v |> this.AddAttr
    [<CustomOperation("maxlength")>] member this.maxlength (_: FunBlazorBuilder<'Component>, v: obj) = "maxlength" => v |> this.AddAttr
    [<CustomOperation("media")>] member this.media (_: FunBlazorBuilder<'Component>, v: obj) = "media" => v |> this.AddAttr
    [<CustomOperation("method")>] member this.method (_: FunBlazorBuilder<'Component>, v: obj) = "method" => v |> this.AddAttr
    [<CustomOperation("min")>] member this.min (_: FunBlazorBuilder<'Component>, v: obj) = "min" => v |> this.AddAttr
    [<CustomOperation("minlength")>] member this.minlength (_: FunBlazorBuilder<'Component>, v: obj) = "minlength" => v |> this.AddAttr
    [<CustomOperation("multiple")>] member this.multiple (_: FunBlazorBuilder<'Component>, v: obj) = "multiple" => v |> this.AddAttr
    [<CustomOperation("muted")>] member this.muted (_: FunBlazorBuilder<'Component>, v: obj) = "muted" => v |> this.AddAttr
    [<CustomOperation("name")>] member this.name (_: FunBlazorBuilder<'Component>, v: obj) = "name" => v |> this.AddAttr
    [<CustomOperation("novalidate")>] member this.novalidate (_: FunBlazorBuilder<'Component>, v: obj) = "novalidate" => v |> this.AddAttr
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorBuilder<'Component>, v: obj) = "open" => v |> this.AddAttr
    [<CustomOperation("optimum")>] member this.optimum (_: FunBlazorBuilder<'Component>, v: obj) = "optimum" => v |> this.AddAttr
    [<CustomOperation("pattern")>] member this.pattern (_: FunBlazorBuilder<'Component>, v: obj) = "pattern" => v |> this.AddAttr
    [<CustomOperation("ping")>] member this.ping (_: FunBlazorBuilder<'Component>, v: obj) = "ping" => v |> this.AddAttr
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorBuilder<'Component>, v: obj) = "placeholder" => v |> this.AddAttr
    [<CustomOperation("poster")>] member this.poster (_: FunBlazorBuilder<'Component>, v: obj) = "poster" => v |> this.AddAttr
    [<CustomOperation("preload")>] member this.preload (_: FunBlazorBuilder<'Component>, v: obj) = "preload" => v |> this.AddAttr
    [<CustomOperation("readonly")>] member this.readonly (_: FunBlazorBuilder<'Component>, v: obj) = "readonly" => v |> this.AddAttr
    [<CustomOperation("rel")>] member this.rel (_: FunBlazorBuilder<'Component>, v: obj) = "rel" => v |> this.AddAttr
    [<CustomOperation("required")>] member this.required (_: FunBlazorBuilder<'Component>, v: obj) = "required" => v |> this.AddAttr
    [<CustomOperation("reversed")>] member this.reversed (_: FunBlazorBuilder<'Component>, v: obj) = "reversed" => v |> this.AddAttr
    [<CustomOperation("rows")>] member this.rows (_: FunBlazorBuilder<'Component>, v: obj) = "rows" => v |> this.AddAttr
    [<CustomOperation("rowspan")>] member this.rowspan (_: FunBlazorBuilder<'Component>, v: obj) = "rowspan" => v |> this.AddAttr
    [<CustomOperation("sandbox")>] member this.sandbox (_: FunBlazorBuilder<'Component>, v: obj) = "sandbox" => v |> this.AddAttr
    [<CustomOperation("scope")>] member this.scope (_: FunBlazorBuilder<'Component>, v: obj) = "scope" => v |> this.AddAttr
    [<CustomOperation("selected")>] member this.selected (_: FunBlazorBuilder<'Component>, v: obj) = "selected" => v |> this.AddAttr
    [<CustomOperation("shape")>] member this.shape (_: FunBlazorBuilder<'Component>, v: obj) = "shape" => v |> this.AddAttr
    [<CustomOperation("size")>] member this.size (_: FunBlazorBuilder<'Component>, v: obj) = "size" => v |> this.AddAttr
    [<CustomOperation("sizes")>] member this.sizes (_: FunBlazorBuilder<'Component>, v: obj) = "sizes" => v |> this.AddAttr
    [<CustomOperation("slot")>] member this.slot (_: FunBlazorBuilder<'Component>, v: obj) = "slot" => v |> this.AddAttr
    [<CustomOperation("span")>] member this.span (_: FunBlazorBuilder<'Component>, v: obj) = "span" => v |> this.AddAttr
    [<CustomOperation("spellcheck")>] member this.spellcheck (_: FunBlazorBuilder<'Component>, v: obj) = "spellcheck" => v |> this.AddAttr
    [<CustomOperation("src")>] member this.src (_: FunBlazorBuilder<'Component>, v: obj) = "src" => v |> this.AddAttr
    [<CustomOperation("srcdoc")>] member this.srcdoc (_: FunBlazorBuilder<'Component>, v: obj) = "srcdoc" => v |> this.AddAttr
    [<CustomOperation("srclang")>] member this.srclang (_: FunBlazorBuilder<'Component>, v: obj) = "srclang" => v |> this.AddAttr
    [<CustomOperation("srcset")>] member this.srcset (_: FunBlazorBuilder<'Component>, v: obj) = "srcset" => v |> this.AddAttr
    [<CustomOperation("start")>] member this.start (_: FunBlazorBuilder<'Component>, v: obj) = "start" => v |> this.AddAttr
    [<CustomOperation("step")>] member this.step (_: FunBlazorBuilder<'Component>, v: obj) = "step" => v |> this.AddAttr
    [<CustomOperation("style'")>] member this.style' (_: FunBlazorBuilder<'Component>, v: obj) = "style" => v |> this.AddAttr
    [<CustomOperation("summary")>] member this.summary (_: FunBlazorBuilder<'Component>, v: obj) = "summary" => v |> this.AddAttr
    [<CustomOperation("tabindex")>] member this.tabindex (_: FunBlazorBuilder<'Component>, v: obj) = "tabindex" => v |> this.AddAttr
    [<CustomOperation("target")>] member this.target (_: FunBlazorBuilder<'Component>, v: obj) = "target" => v |> this.AddAttr
    [<CustomOperation("title")>] member this.title (_: FunBlazorBuilder<'Component>, v: obj) = "title" => v |> this.AddAttr
    [<CustomOperation("translate")>] member this.translate (_: FunBlazorBuilder<'Component>, v: obj) = "translate" => v |> this.AddAttr
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorBuilder<'Component>, v: obj) = "type" => v |> this.AddAttr
    [<CustomOperation("usemap")>] member this.usemap (_: FunBlazorBuilder<'Component>, v: obj) = "usemap" => v |> this.AddAttr
    [<CustomOperation("value")>] member this.value (_: FunBlazorBuilder<'Component>, v: obj) = "value" => v |> this.AddAttr
    [<CustomOperation("width")>] member this.width (_: FunBlazorBuilder<'Component>, v: obj) = "width" => v |> this.AddAttr
    [<CustomOperation("wrap")>] member this.wrap (_: FunBlazorBuilder<'Component>, v: obj) = "wrap" => v |> this.AddAttr


    [<CustomOperation("onfocus")>] member this.onfocus (_: FunBlazorBuilder<'Component>, callback: FocusEventArgs -> unit) = on.focus callback |> this.AddAttr
    [<CustomOperation("onfocusAsync")>] member this.onfocusAsync (_: FunBlazorBuilder<'Component>, callback: FocusEventArgs -> Async<unit>) = on.async.focus callback |> this.AddAttr
    [<CustomOperation("onblur")>] member this.onblur (_: FunBlazorBuilder<'Component>, callback: FocusEventArgs -> unit) = on.blur callback |> this.AddAttr
    [<CustomOperation("onblurAsync")>] member this.onblurAsync (_: FunBlazorBuilder<'Component>, callback: FocusEventArgs -> Async<unit>) = on.async.blur callback |> this.AddAttr
    [<CustomOperation("onfocusin")>] member this.onfocusin (_: FunBlazorBuilder<'Component>, callback: FocusEventArgs -> unit) = on.focusin callback |> this.AddAttr
    [<CustomOperation("onfocusinAsync")>] member this.onfocusinAsync (_: FunBlazorBuilder<'Component>, callback: FocusEventArgs -> Async<unit>) = on.async.focusin callback |> this.AddAttr
    [<CustomOperation("onfocusout")>] member this.onfocusout (_: FunBlazorBuilder<'Component>, callback: FocusEventArgs -> unit) = on.focusout callback |> this.AddAttr
    [<CustomOperation("onfocusoutAsync")>] member this.onfocusoutAsync (_: FunBlazorBuilder<'Component>, callback: FocusEventArgs -> Async<unit>) = on.async.focusout callback |> this.AddAttr
    [<CustomOperation("onmouseover")>] member this.onmouseover (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.mouseover callback |> this.AddAttr
    [<CustomOperation("onmouseoverAsync")>] member this.onmouseoverAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.mouseover callback |> this.AddAttr
    [<CustomOperation("onmouseout")>] member this.onmouseout (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.mouseout callback |> this.AddAttr
    [<CustomOperation("onmouseoutAsync")>] member this.onmouseoutAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.mouseout callback |> this.AddAttr
    [<CustomOperation("onmousemove")>] member this.onmousemove (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.mousemove callback |> this.AddAttr
    [<CustomOperation("onmousemoveAsync")>] member this.onmousemoveAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.mousemove callback |> this.AddAttr
    [<CustomOperation("onmousedown")>] member this.onmousedown (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.mousedown callback |> this.AddAttr
    [<CustomOperation("onmousedownAsync")>] member this.onmousedownAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.mousedown callback |> this.AddAttr
    [<CustomOperation("onmouseup")>] member this.onmouseup (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.mouseup callback |> this.AddAttr
    [<CustomOperation("onmouseupAsync")>] member this.onmouseupAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.mouseup callback |> this.AddAttr
    [<CustomOperation("onclick")>] member this.onclick (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.click callback |> this.AddAttr
    [<CustomOperation("onclickAsync")>] member this.onclickAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.click callback |> this.AddAttr
    [<CustomOperation("ondblclick")>] member this.ondblclick (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.dblclick callback |> this.AddAttr
    [<CustomOperation("ondblclickAsync")>] member this.ondblclickAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.dblclick callback |> this.AddAttr
    [<CustomOperation("onwheel")>] member this.onwheel (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.wheel callback |> this.AddAttr
    [<CustomOperation("onwheelAsync")>] member this.onwheelAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.wheel callback |> this.AddAttr
    [<CustomOperation("onmousewheel")>] member this.onmousewheel (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.mousewheel callback |> this.AddAttr
    [<CustomOperation("onmousewheelAsync")>] member this.onmousewheelAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.mousewheel callback |> this.AddAttr
    [<CustomOperation("oncontextmenu")>] member this.oncontextmenu (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> unit) = on.contextmenu callback |> this.AddAttr
    [<CustomOperation("oncontextmenuAsync")>] member this.oncontextmenuAsync (_: FunBlazorBuilder<'Component>, callback: MouseEventArgs -> Async<unit>) = on.async.contextmenu callback |> this.AddAttr
    [<CustomOperation("ondrag")>] member this.ondrag (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> unit) = on.drag callback |> this.AddAttr
    [<CustomOperation("ondragAsync")>] member this.ondragAsync (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> Async<unit>) = on.async.drag callback |> this.AddAttr
    [<CustomOperation("ondragend")>] member this.ondragend (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> unit) = on.dragend callback |> this.AddAttr
    [<CustomOperation("ondragendAsync")>] member this.ondragendAsync (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> Async<unit>) = on.async.dragend callback |> this.AddAttr
    [<CustomOperation("ondragenter")>] member this.ondragenter (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> unit) = on.dragenter callback |> this.AddAttr
    [<CustomOperation("ondragenterAsync")>] member this.ondragenterAsync (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> Async<unit>) = on.async.dragenter callback |> this.AddAttr
    [<CustomOperation("ondragleave")>] member this.ondragleave (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> unit) = on.dragleave callback |> this.AddAttr
    [<CustomOperation("ondragleaveAsync")>] member this.ondragleaveAsync (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> Async<unit>) = on.async.dragleave callback |> this.AddAttr
    [<CustomOperation("ondragover")>] member this.ondragover (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> unit) = on.dragover callback |> this.AddAttr
    [<CustomOperation("ondragoverAsync")>] member this.ondragoverAsync (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> Async<unit>) = on.async.dragover callback |> this.AddAttr
    [<CustomOperation("ondragstart")>] member this.ondragstart (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> unit) = on.dragstart callback |> this.AddAttr
    [<CustomOperation("ondragstartAsync")>] member this.ondragstartAsync (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> Async<unit>) = on.async.dragstart callback |> this.AddAttr
    [<CustomOperation("ondrop")>] member this.ondrop (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> unit) = on.drop callback |> this.AddAttr
    [<CustomOperation("ondropAsync")>] member this.ondropAsync (_: FunBlazorBuilder<'Component>, callback: DragEventArgs -> Async<unit>) = on.async.drop callback |> this.AddAttr
    [<CustomOperation("onkeydown")>] member this.onkeydown (_: FunBlazorBuilder<'Component>, callback: KeyboardEventArgs -> unit) = on.keydown callback |> this.AddAttr
    [<CustomOperation("onkeydownAsync")>] member this.onkeydownAsync (_: FunBlazorBuilder<'Component>, callback: KeyboardEventArgs -> Async<unit>) = on.async.keydown callback |> this.AddAttr
    [<CustomOperation("onkeyup")>] member this.onkeyup (_: FunBlazorBuilder<'Component>, callback: KeyboardEventArgs -> unit) = on.keyup callback |> this.AddAttr
    [<CustomOperation("onkeyupAsync")>] member this.onkeyupAsync (_: FunBlazorBuilder<'Component>, callback: KeyboardEventArgs -> Async<unit>) = on.async.keyup callback |> this.AddAttr
    [<CustomOperation("onkeypress")>] member this.onkeypress (_: FunBlazorBuilder<'Component>, callback: KeyboardEventArgs -> unit) = on.keypress callback |> this.AddAttr
    [<CustomOperation("onkeypressAsync")>] member this.onkeypressAsync (_: FunBlazorBuilder<'Component>, callback: KeyboardEventArgs -> Async<unit>) = on.async.keypress callback |> this.AddAttr
    [<CustomOperation("onchange")>] member this.onchange (_: FunBlazorBuilder<'Component>, callback: ChangeEventArgs -> unit) = on.change callback |> this.AddAttr
    [<CustomOperation("onchangeAsync")>] member this.onchangeAsync (_: FunBlazorBuilder<'Component>, callback: ChangeEventArgs -> Async<unit>) = on.async.change callback |> this.AddAttr
    [<CustomOperation("oninput")>] member this.oninput (_: FunBlazorBuilder<'Component>, callback: ChangeEventArgs -> unit) = on.input callback |> this.AddAttr
    [<CustomOperation("oninputAsync")>] member this.oninputAsync (_: FunBlazorBuilder<'Component>, callback: ChangeEventArgs -> Async<unit>) = on.async.input callback |> this.AddAttr
    [<CustomOperation("oninvalid")>] member this.oninvalid (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.invalid callback |> this.AddAttr
    [<CustomOperation("oninvalidAsync")>] member this.oninvalidAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.invalid callback |> this.AddAttr
    [<CustomOperation("onreset")>] member this.onreset (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.reset callback |> this.AddAttr
    [<CustomOperation("onresetAsync")>] member this.onresetAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.reset callback |> this.AddAttr
    [<CustomOperation("onselect")>] member this.onselect (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.select callback |> this.AddAttr
    [<CustomOperation("onselectAsync")>] member this.onselectAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.select callback |> this.AddAttr
    [<CustomOperation("onselectstart")>] member this.onselectstart (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.selectstart callback |> this.AddAttr
    [<CustomOperation("onselectstartAsync")>] member this.onselectstartAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.selectstart callback |> this.AddAttr
    [<CustomOperation("onselectionchange")>] member this.onselectionchange (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.selectionchange callback |> this.AddAttr
    [<CustomOperation("onselectionchangeAsync")>] member this.onselectionchangeAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.selectionchange callback |> this.AddAttr
    [<CustomOperation("onsubmit")>] member this.onsubmit (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.submit callback |> this.AddAttr
    [<CustomOperation("onsubmitAsync")>] member this.onsubmitAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.submit callback |> this.AddAttr
    [<CustomOperation("onbeforecopy")>] member this.onbeforecopy (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.beforecopy callback |> this.AddAttr
    [<CustomOperation("onbeforecopyAsync")>] member this.onbeforecopyAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.beforecopy callback |> this.AddAttr
    [<CustomOperation("onbeforecut")>] member this.onbeforecut (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.beforecut callback |> this.AddAttr
    [<CustomOperation("onbeforecutAsync")>] member this.onbeforecutAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.beforecut callback |> this.AddAttr
    [<CustomOperation("onbeforepaste")>] member this.onbeforepaste (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.beforepaste callback |> this.AddAttr
    [<CustomOperation("onbeforepasteAsync")>] member this.onbeforepasteAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.beforepaste callback |> this.AddAttr
    [<CustomOperation("oncopy")>] member this.oncopy (_: FunBlazorBuilder<'Component>, callback: ClipboardEventArgs -> unit) = on.copy callback |> this.AddAttr
    [<CustomOperation("oncopyAsync")>] member this.oncopyAsync (_: FunBlazorBuilder<'Component>, callback: ClipboardEventArgs -> Async<unit>) = on.async.copy callback |> this.AddAttr
    [<CustomOperation("oncut")>] member this.oncut (_: FunBlazorBuilder<'Component>, callback: ClipboardEventArgs -> unit) = on.cut callback |> this.AddAttr
    [<CustomOperation("oncutAsync")>] member this.oncutAsync (_: FunBlazorBuilder<'Component>, callback: ClipboardEventArgs -> Async<unit>) = on.async.cut callback |> this.AddAttr
    [<CustomOperation("onpaste")>] member this.onpaste (_: FunBlazorBuilder<'Component>, callback: ClipboardEventArgs -> unit) = on.paste callback |> this.AddAttr
    [<CustomOperation("onpasteAsync")>] member this.onpasteAsync (_: FunBlazorBuilder<'Component>, callback: ClipboardEventArgs -> Async<unit>) = on.async.paste callback |> this.AddAttr
    [<CustomOperation("ontouchcancel")>] member this.ontouchcancel (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> unit) = on.touchcancel callback |> this.AddAttr
    [<CustomOperation("ontouchcancelAsync")>] member this.ontouchcancelAsync (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> Async<unit>) = on.async.touchcancel callback |> this.AddAttr
    [<CustomOperation("ontouchend")>] member this.ontouchend (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> unit) = on.touchend callback |> this.AddAttr
    [<CustomOperation("ontouchendAsync")>] member this.ontouchendAsync (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> Async<unit>) = on.async.touchend callback |> this.AddAttr
    [<CustomOperation("ontouchmove")>] member this.ontouchmove (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> unit) = on.touchmove callback |> this.AddAttr
    [<CustomOperation("ontouchmoveAsync")>] member this.ontouchmoveAsync (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> Async<unit>) = on.async.touchmove callback |> this.AddAttr
    [<CustomOperation("ontouchstart")>] member this.ontouchstart (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> unit) = on.touchstart callback |> this.AddAttr
    [<CustomOperation("ontouchstartAsync")>] member this.ontouchstartAsync (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> Async<unit>) = on.async.touchstart callback |> this.AddAttr
    [<CustomOperation("ontouchenter")>] member this.ontouchenter (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> unit) = on.touchenter callback |> this.AddAttr
    [<CustomOperation("ontouchenterAsync")>] member this.ontouchenterAsync (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> Async<unit>) = on.async.touchenter callback |> this.AddAttr
    [<CustomOperation("ontouchleave")>] member this.ontouchleave (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> unit) = on.touchleave callback |> this.AddAttr
    [<CustomOperation("ontouchleaveAsync")>] member this.ontouchleaveAsync (_: FunBlazorBuilder<'Component>, callback: TouchEventArgs -> Async<unit>) = on.async.touchleave callback |> this.AddAttr
    [<CustomOperation("onpointercapture")>] member this.onpointercapture (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointercapture callback |> this.AddAttr
    [<CustomOperation("onpointercaptureAsync")>] member this.onpointercaptureAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointercapture callback |> this.AddAttr
    [<CustomOperation("onlostpointercapture")>] member this.onlostpointercapture (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.lostpointercapture callback |> this.AddAttr
    [<CustomOperation("onlostpointercaptureAsync")>] member this.onlostpointercaptureAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.lostpointercapture callback |> this.AddAttr
    [<CustomOperation("onpointercancel")>] member this.onpointercancel (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointercancel callback |> this.AddAttr
    [<CustomOperation("onpointercancelAsync")>] member this.onpointercancelAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointercancel callback |> this.AddAttr
    [<CustomOperation("onpointerdown")>] member this.onpointerdown (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointerdown callback |> this.AddAttr
    [<CustomOperation("onpointerdownAsync")>] member this.onpointerdownAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointerdown callback |> this.AddAttr
    [<CustomOperation("onpointerenter")>] member this.onpointerenter (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointerenter callback |> this.AddAttr
    [<CustomOperation("onpointerenterAsync")>] member this.onpointerenterAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointerenter callback |> this.AddAttr
    [<CustomOperation("onpointerleave")>] member this.onpointerleave (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointerleave callback |> this.AddAttr
    [<CustomOperation("onpointerleaveAsync")>] member this.onpointerleaveAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointerleave callback |> this.AddAttr
    [<CustomOperation("onpointermove")>] member this.onpointermove (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointermove callback |> this.AddAttr
    [<CustomOperation("onpointermoveAsync")>] member this.onpointermoveAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointermove callback |> this.AddAttr
    [<CustomOperation("onpointerout")>] member this.onpointerout (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointerout callback |> this.AddAttr
    [<CustomOperation("onpointeroutAsync")>] member this.onpointeroutAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointerout callback |> this.AddAttr
    [<CustomOperation("onpointerover")>] member this.onpointerover (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointerover callback |> this.AddAttr
    [<CustomOperation("onpointeroverAsync")>] member this.onpointeroverAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointerover callback |> this.AddAttr
    [<CustomOperation("onpointerup")>] member this.onpointerup (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> unit) = on.pointerup callback |> this.AddAttr
    [<CustomOperation("onpointerupAsync")>] member this.onpointerupAsync (_: FunBlazorBuilder<'Component>, callback: PointerEventArgs -> Async<unit>) = on.async.pointerup callback |> this.AddAttr
    [<CustomOperation("oncanplay")>] member this.oncanplay (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.canplay callback |> this.AddAttr
    [<CustomOperation("oncanplayAsync")>] member this.oncanplayAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.canplay callback |> this.AddAttr
    [<CustomOperation("oncanplaythrough")>] member this.oncanplaythrough (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.canplaythrough callback |> this.AddAttr
    [<CustomOperation("oncanplaythroughAsync")>] member this.oncanplaythroughAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.canplaythrough callback |> this.AddAttr
    [<CustomOperation("oncuechange")>] member this.oncuechange (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.cuechange callback |> this.AddAttr
    [<CustomOperation("oncuechangeAsync")>] member this.oncuechangeAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.cuechange callback |> this.AddAttr
    [<CustomOperation("ondurationchange")>] member this.ondurationchange (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.durationchange callback |> this.AddAttr
    [<CustomOperation("ondurationchangeAsync")>] member this.ondurationchangeAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.durationchange callback |> this.AddAttr
    [<CustomOperation("onemptied")>] member this.onemptied (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.emptied callback |> this.AddAttr
    [<CustomOperation("onemptiedAsync")>] member this.onemptiedAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.emptied callback |> this.AddAttr
    [<CustomOperation("onpause")>] member this.onpause (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.pause callback |> this.AddAttr
    [<CustomOperation("onpauseAsync")>] member this.onpauseAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.pause callback |> this.AddAttr
    [<CustomOperation("onplay")>] member this.onplay (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.play callback |> this.AddAttr
    [<CustomOperation("onplayAsync")>] member this.onplayAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.play callback |> this.AddAttr
    [<CustomOperation("onplaying")>] member this.onplaying (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.playing callback |> this.AddAttr
    [<CustomOperation("onplayingAsync")>] member this.onplayingAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.playing callback |> this.AddAttr
    [<CustomOperation("onratechange")>] member this.onratechange (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.ratechange callback |> this.AddAttr
    [<CustomOperation("onratechangeAsync")>] member this.onratechangeAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.ratechange callback |> this.AddAttr
    [<CustomOperation("onseeked")>] member this.onseeked (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.seeked callback |> this.AddAttr
    [<CustomOperation("onseekedAsync")>] member this.onseekedAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.seeked callback |> this.AddAttr
    [<CustomOperation("onseeking")>] member this.onseeking (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.seeking callback |> this.AddAttr
    [<CustomOperation("onseekingAsync")>] member this.onseekingAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.seeking callback |> this.AddAttr
    [<CustomOperation("onstalled")>] member this.onstalled (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.stalled callback |> this.AddAttr
    [<CustomOperation("onstalledAsync")>] member this.onstalledAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.stalled callback |> this.AddAttr
    [<CustomOperation("onstop")>] member this.onstop (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.stop callback |> this.AddAttr
    [<CustomOperation("onstopAsync")>] member this.onstopAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.stop callback |> this.AddAttr
    [<CustomOperation("onsuspend")>] member this.onsuspend (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.suspend callback |> this.AddAttr
    [<CustomOperation("onsuspendAsync")>] member this.onsuspendAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.suspend callback |> this.AddAttr
    [<CustomOperation("ontimeupdate")>] member this.ontimeupdate (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.timeupdate callback |> this.AddAttr
    [<CustomOperation("ontimeupdateAsync")>] member this.ontimeupdateAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.timeupdate callback |> this.AddAttr
    [<CustomOperation("onvolumechange")>] member this.onvolumechange (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.volumechange callback |> this.AddAttr
    [<CustomOperation("onvolumechangeAsync")>] member this.onvolumechangeAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.volumechange callback |> this.AddAttr
    [<CustomOperation("onwaiting")>] member this.onwaiting (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.waiting callback |> this.AddAttr
    [<CustomOperation("onwaitingAsync")>] member this.onwaitingAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.waiting callback |> this.AddAttr
    [<CustomOperation("onloadstart")>] member this.onloadstart (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> unit) = on.loadstart callback |> this.AddAttr
    [<CustomOperation("onloadstartAsync")>] member this.onloadstartAsync (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> Async<unit>) = on.async.loadstart callback |> this.AddAttr
    [<CustomOperation("ontimeout")>] member this.ontimeout (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> unit) = on.timeout callback |> this.AddAttr
    [<CustomOperation("ontimeoutAsync")>] member this.ontimeoutAsync (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> Async<unit>) = on.async.timeout callback |> this.AddAttr
    [<CustomOperation("onabort")>] member this.onabort (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> unit) = on.abort callback |> this.AddAttr
    [<CustomOperation("onabortAsync")>] member this.onabortAsync (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> Async<unit>) = on.async.abort callback |> this.AddAttr
    [<CustomOperation("onload")>] member this.onload (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> unit) = on.load callback |> this.AddAttr
    [<CustomOperation("onloadAsync")>] member this.onloadAsync (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> Async<unit>) = on.async.load callback |> this.AddAttr
    [<CustomOperation("onloadend")>] member this.onloadend (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> unit) = on.loadend callback |> this.AddAttr
    [<CustomOperation("onloadendAsync")>] member this.onloadendAsync (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> Async<unit>) = on.async.loadend callback |> this.AddAttr
    [<CustomOperation("onprogress")>] member this.onprogress (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> unit) = on.progress callback |> this.AddAttr
    [<CustomOperation("onprogressAsync")>] member this.onprogressAsync (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> Async<unit>) = on.async.progress callback |> this.AddAttr
    [<CustomOperation("onerror")>] member this.onerror (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> unit) = on.error callback |> this.AddAttr
    [<CustomOperation("onerrorAsync")>] member this.onerrorAsync (_: FunBlazorBuilder<'Component>, callback: ProgressEventArgs -> Async<unit>) = on.async.error callback |> this.AddAttr
    [<CustomOperation("onactivate")>] member this.onactivate (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.activate callback |> this.AddAttr
    [<CustomOperation("onactivateAsync")>] member this.onactivateAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.activate callback |> this.AddAttr
    [<CustomOperation("onbeforeactivate")>] member this.onbeforeactivate (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.beforeactivate callback |> this.AddAttr
    [<CustomOperation("onbeforeactivateAsync")>] member this.onbeforeactivateAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.beforeactivate callback |> this.AddAttr
    [<CustomOperation("onbeforedeactivate")>] member this.onbeforedeactivate (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.beforedeactivate callback |> this.AddAttr
    [<CustomOperation("onbeforedeactivateAsync")>] member this.onbeforedeactivateAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.beforedeactivate callback |> this.AddAttr
    [<CustomOperation("ondeactivate")>] member this.ondeactivate (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.deactivate callback |> this.AddAttr
    [<CustomOperation("ondeactivateAsync")>] member this.ondeactivateAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.deactivate callback |> this.AddAttr
    [<CustomOperation("onended")>] member this.onended (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.ended callback |> this.AddAttr
    [<CustomOperation("onendedAsync")>] member this.onendedAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.ended callback |> this.AddAttr
    [<CustomOperation("onfullscreenchange")>] member this.onfullscreenchange (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.fullscreenchange callback |> this.AddAttr
    [<CustomOperation("onfullscreenchangeAsync")>] member this.onfullscreenchangeAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.fullscreenchange callback |> this.AddAttr
    [<CustomOperation("onfullscreenerror")>] member this.onfullscreenerror (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.fullscreenerror callback |> this.AddAttr
    [<CustomOperation("onfullscreenerrorAsync")>] member this.onfullscreenerrorAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.fullscreenerror callback |> this.AddAttr
    [<CustomOperation("onloadeddata")>] member this.onloadeddata (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.loadeddata callback |> this.AddAttr
    [<CustomOperation("onloadeddataAsync")>] member this.onloadeddataAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.loadeddata callback |> this.AddAttr
    [<CustomOperation("onloadedmetadata")>] member this.onloadedmetadata (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.loadedmetadata callback |> this.AddAttr
    [<CustomOperation("onloadedmetadataAsync")>] member this.onloadedmetadataAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.loadedmetadata callback |> this.AddAttr
    [<CustomOperation("onpointerlockchange")>] member this.onpointerlockchange (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.pointerlockchange callback |> this.AddAttr
    [<CustomOperation("onpointerlockchangeAsync")>] member this.onpointerlockchangeAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.pointerlockchange callback |> this.AddAttr
    [<CustomOperation("onpointerlockerror")>] member this.onpointerlockerror (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.pointerlockerror callback |> this.AddAttr
    [<CustomOperation("onpointerlockerrorAsync")>] member this.onpointerlockerrorAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.pointerlockerror callback |> this.AddAttr
    [<CustomOperation("onreadystatechange")>] member this.onreadystatechange (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.readystatechange callback |> this.AddAttr
    [<CustomOperation("onreadystatechangeAsync")>] member this.onreadystatechangeAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.readystatechange callback |> this.AddAttr
    [<CustomOperation("onscroll")>] member this.onscroll (_: FunBlazorBuilder<'Component>, callback: EventArgs -> unit) = on.scroll callback |> this.AddAttr
    [<CustomOperation("onscrollAsync")>] member this.onscrollAsync (_: FunBlazorBuilder<'Component>, callback: EventArgs -> Async<unit>) = on.async.scroll callback |> this.AddAttr
    

type EltEmptyComponent() =
    interface IComponent with
        member _.Attach _ = ()
        member _.SetParametersAsync _ = Task.FromResult() :> Task


[<AbstractClass>]
type FunBlazorEltBuilder () =
    inherit FunBlazorBuilderWithDomAttrs<EltEmptyComponent>()

    abstract MakeNode: Bolero.Attr list * Bolero.Node list -> Bolero.Node
        
    member this.Run _ =
        let attrs, child = this.Props()
        this.MakeNode(List.ofSeq attrs, List.ofSeq child)
    

[<AutoOpen>]
module elt =
    
    type ABuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ABuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.a [] [ html.text x ]
        static member create (x: int) = Html.a [] [ html.text x ]
        static member create (x: float) = Html.a [] [ html.text x ]
        static member create (x: Node) = Html.a [] [ x ]
        static member create (x: Node list) = Html.a [] x
        member this.Yield _ = ABuilder()
        override this.MakeNode (x, y) = Html.a x y

    type a = ABuilder


    type AbbrBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = AbbrBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.abbr [] [ html.text x ]
        static member create (x: int) = Html.abbr [] [ html.text x ]
        static member create (x: float) = Html.abbr [] [ html.text x ]
        static member create (x: Node) = Html.abbr [] [ x ]
        static member create (x: Node list) = Html.abbr [] x
        member this.Yield _ = AbbrBuilder()
        override this.MakeNode (x, y) = Html.abbr x y

    type abbr = AbbrBuilder


    type AcronymBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = AcronymBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.acronym [] [ html.text x ]
        static member create (x: int) = Html.acronym [] [ html.text x ]
        static member create (x: float) = Html.acronym [] [ html.text x ]
        static member create (x: Node) = Html.acronym [] [ x ]
        static member create (x: Node list) = Html.acronym [] x
        member this.Yield _ = AcronymBuilder()
        override this.MakeNode (x, y) = Html.acronym x y

    type acronym = AcronymBuilder


    type AddressBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = AddressBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.address [] [ html.text x ]
        static member create (x: int) = Html.address [] [ html.text x ]
        static member create (x: float) = Html.address [] [ html.text x ]
        static member create (x: Node) = Html.address [] [ x ]
        static member create (x: Node list) = Html.address [] x
        member this.Yield _ = AddressBuilder()
        override this.MakeNode (x, y) = Html.address x y

    type address = AddressBuilder


    type AppletBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = AppletBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.applet [] [ html.text x ]
        static member create (x: int) = Html.applet [] [ html.text x ]
        static member create (x: float) = Html.applet [] [ html.text x ]
        static member create (x: Node) = Html.applet [] [ x ]
        static member create (x: Node list) = Html.applet [] x
        member this.Yield _ = AppletBuilder()
        override this.MakeNode (x, y) = Html.applet x y

    type applet = AppletBuilder


    type AreaBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = AreaBuilder()
        override this.MakeNode (x, y) = Html.area x

    type area = AreaBuilder


    type ArticleBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ArticleBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.article [] [ html.text x ]
        static member create (x: int) = Html.article [] [ html.text x ]
        static member create (x: float) = Html.article [] [ html.text x ]
        static member create (x: Node) = Html.article [] [ x ]
        static member create (x: Node list) = Html.article [] x
        member this.Yield _ = ArticleBuilder()
        override this.MakeNode (x, y) = Html.article x y

    type article = ArticleBuilder


    type AsideBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = AsideBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.aside [] [ html.text x ]
        static member create (x: int) = Html.aside [] [ html.text x ]
        static member create (x: float) = Html.aside [] [ html.text x ]
        static member create (x: Node) = Html.aside [] [ x ]
        static member create (x: Node list) = Html.aside [] x
        member this.Yield _ = AsideBuilder()
        override this.MakeNode (x, y) = Html.aside x y

    type aside = AsideBuilder


    type AudioBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = AudioBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.audio [] [ html.text x ]
        static member create (x: int) = Html.audio [] [ html.text x ]
        static member create (x: float) = Html.audio [] [ html.text x ]
        static member create (x: Node) = Html.audio [] [ x ]
        static member create (x: Node list) = Html.audio [] x
        member this.Yield _ = AudioBuilder()
        override this.MakeNode (x, y) = Html.audio x y

    type audio = AudioBuilder


    type BBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = BBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.b [] [ html.text x ]
        static member create (x: int) = Html.b [] [ html.text x ]
        static member create (x: float) = Html.b [] [ html.text x ]
        static member create (x: Node) = Html.b [] [ x ]
        static member create (x: Node list) = Html.b [] x
        member this.Yield _ = BBuilder()
        override this.MakeNode (x, y) = Html.b x y

    type b = BBuilder


    type BaseBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = BaseBuilder()
        override this.MakeNode (x, y) = Html.``base`` x

    type base' = BaseBuilder


    type BasefontBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = BasefontBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.basefont [] [ html.text x ]
        static member create (x: int) = Html.basefont [] [ html.text x ]
        static member create (x: float) = Html.basefont [] [ html.text x ]
        static member create (x: Node) = Html.basefont [] [ x ]
        static member create (x: Node list) = Html.basefont [] x
        member this.Yield _ = BasefontBuilder()
        override this.MakeNode (x, y) = Html.basefont x y

    type basefont = BasefontBuilder


    type BdiBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = BdiBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.bdi [] [ html.text x ]
        static member create (x: int) = Html.bdi [] [ html.text x ]
        static member create (x: float) = Html.bdi [] [ html.text x ]
        static member create (x: Node) = Html.bdi [] [ x ]
        static member create (x: Node list) = Html.bdi [] x
        member this.Yield _ = BdiBuilder()
        override this.MakeNode (x, y) = Html.bdi x y

    type bdi = BdiBuilder


    type BdoBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = BdoBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.bdo [] [ html.text x ]
        static member create (x: int) = Html.bdo [] [ html.text x ]
        static member create (x: float) = Html.bdo [] [ html.text x ]
        static member create (x: Node) = Html.bdo [] [ x ]
        static member create (x: Node list) = Html.bdo [] x
        member this.Yield _ = BdoBuilder()
        override this.MakeNode (x, y) = Html.bdo x y

    type bdo = BdoBuilder


    type BigBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = BigBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.big [] [ html.text x ]
        static member create (x: int) = Html.big [] [ html.text x ]
        static member create (x: float) = Html.big [] [ html.text x ]
        static member create (x: Node) = Html.big [] [ x ]
        static member create (x: Node list) = Html.big [] x
        member this.Yield _ = BigBuilder()
        override this.MakeNode (x, y) = Html.big x y

    type big = BigBuilder


    type BlockquoteBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = BlockquoteBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.blockquote [] [ html.text x ]
        static member create (x: int) = Html.blockquote [] [ html.text x ]
        static member create (x: float) = Html.blockquote [] [ html.text x ]
        static member create (x: Node) = Html.blockquote [] [ x ]
        static member create (x: Node list) = Html.blockquote [] x
        member this.Yield _ = BlockquoteBuilder()
        override this.MakeNode (x, y) = Html.blockquote x y

    type blockquote = BlockquoteBuilder


    type BodyBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = BodyBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.body [] [ html.text x ]
        static member create (x: int) = Html.body [] [ html.text x ]
        static member create (x: float) = Html.body [] [ html.text x ]
        static member create (x: Node) = Html.body [] [ x ]
        static member create (x: Node list) = Html.body [] x
        member this.Yield _ = BodyBuilder()
        override this.MakeNode (x, y) = Html.body x y

    type body = BodyBuilder


    type BrBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = BrBuilder()
        override this.MakeNode (x, y) = Html.br x

    type br = BrBuilder


    type ButtonBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ButtonBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.button [] [ html.text x ]
        static member create (x: int) = Html.button [] [ html.text x ]
        static member create (x: float) = Html.button [] [ html.text x ]
        static member create (x: Node) = Html.button [] [ x ]
        static member create (x: Node list) = Html.button [] x
        member this.Yield _ = ButtonBuilder()
        override this.MakeNode (x, y) = Html.button x y

    type button = ButtonBuilder


    type CanvasBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = CanvasBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.canvas [] [ html.text x ]
        static member create (x: int) = Html.canvas [] [ html.text x ]
        static member create (x: float) = Html.canvas [] [ html.text x ]
        static member create (x: Node) = Html.canvas [] [ x ]
        static member create (x: Node list) = Html.canvas [] x
        member this.Yield _ = CanvasBuilder()
        override this.MakeNode (x, y) = Html.canvas x y

    type canvas = CanvasBuilder


    type CaptionBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = CaptionBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.caption [] [ html.text x ]
        static member create (x: int) = Html.caption [] [ html.text x ]
        static member create (x: float) = Html.caption [] [ html.text x ]
        static member create (x: Node) = Html.caption [] [ x ]
        static member create (x: Node list) = Html.caption [] x
        member this.Yield _ = CaptionBuilder()
        override this.MakeNode (x, y) = Html.caption x y

    type caption = CaptionBuilder


    type CenterBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = CenterBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.center [] [ html.text x ]
        static member create (x: int) = Html.center [] [ html.text x ]
        static member create (x: float) = Html.center [] [ html.text x ]
        static member create (x: Node) = Html.center [] [ x ]
        static member create (x: Node list) = Html.center [] x
        member this.Yield _ = CenterBuilder()
        override this.MakeNode (x, y) = Html.center x y

    type center = CenterBuilder


    type CiteBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = CiteBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.cite [] [ html.text x ]
        static member create (x: int) = Html.cite [] [ html.text x ]
        static member create (x: float) = Html.cite [] [ html.text x ]
        static member create (x: Node) = Html.cite [] [ x ]
        static member create (x: Node list) = Html.cite [] x
        member this.Yield _ = CiteBuilder()
        override this.MakeNode (x, y) = Html.cite x y

    type cite = CiteBuilder


    type CodeBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = CodeBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.code [] [ html.text x ]
        static member create (x: int) = Html.code [] [ html.text x ]
        static member create (x: float) = Html.code [] [ html.text x ]
        static member create (x: Node) = Html.code [] [ x ]
        static member create (x: Node list) = Html.code [] x
        member this.Yield _ = CodeBuilder()
        override this.MakeNode (x, y) = Html.code x y

    type code = CodeBuilder


    type ColBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = ColBuilder()
        override this.MakeNode (x, y) = Html.col x

    type col = ColBuilder


    type ColgroupBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ColgroupBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.colgroup [] [ html.text x ]
        static member create (x: int) = Html.colgroup [] [ html.text x ]
        static member create (x: float) = Html.colgroup [] [ html.text x ]
        static member create (x: Node) = Html.colgroup [] [ x ]
        static member create (x: Node list) = Html.colgroup [] x
        member this.Yield _ = ColgroupBuilder()
        override this.MakeNode (x, y) = Html.colgroup x y

    type colgroup = ColgroupBuilder


    type ContentBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ContentBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.content [] [ html.text x ]
        static member create (x: int) = Html.content [] [ html.text x ]
        static member create (x: float) = Html.content [] [ html.text x ]
        static member create (x: Node) = Html.content [] [ x ]
        static member create (x: Node list) = Html.content [] x
        member this.Yield _ = ContentBuilder()
        override this.MakeNode (x, y) = Html.content x y

    type content = ContentBuilder


    type DataBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DataBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.data [] [ html.text x ]
        static member create (x: int) = Html.data [] [ html.text x ]
        static member create (x: float) = Html.data [] [ html.text x ]
        static member create (x: Node) = Html.data [] [ x ]
        static member create (x: Node list) = Html.data [] x
        member this.Yield _ = DataBuilder()
        override this.MakeNode (x, y) = Html.data x y

    type data = DataBuilder


    type DatalistBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DatalistBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.datalist [] [ html.text x ]
        static member create (x: int) = Html.datalist [] [ html.text x ]
        static member create (x: float) = Html.datalist [] [ html.text x ]
        static member create (x: Node) = Html.datalist [] [ x ]
        static member create (x: Node list) = Html.datalist [] x
        member this.Yield _ = DatalistBuilder()
        override this.MakeNode (x, y) = Html.datalist x y

    type datalist = DatalistBuilder


    type DdBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DdBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.dd [] [ html.text x ]
        static member create (x: int) = Html.dd [] [ html.text x ]
        static member create (x: float) = Html.dd [] [ html.text x ]
        static member create (x: Node) = Html.dd [] [ x ]
        static member create (x: Node list) = Html.dd [] x
        member this.Yield _ = DdBuilder()
        override this.MakeNode (x, y) = Html.dd x y

    type dd = DdBuilder


    type DelBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DelBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.del [] [ html.text x ]
        static member create (x: int) = Html.del [] [ html.text x ]
        static member create (x: float) = Html.del [] [ html.text x ]
        static member create (x: Node) = Html.del [] [ x ]
        static member create (x: Node list) = Html.del [] x
        member this.Yield _ = DelBuilder()
        override this.MakeNode (x, y) = Html.del x y

    type del = DelBuilder


    type DetailsBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DetailsBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.details [] [ html.text x ]
        static member create (x: int) = Html.details [] [ html.text x ]
        static member create (x: float) = Html.details [] [ html.text x ]
        static member create (x: Node) = Html.details [] [ x ]
        static member create (x: Node list) = Html.details [] x
        member this.Yield _ = DetailsBuilder()
        override this.MakeNode (x, y) = Html.details x y

    type details = DetailsBuilder


    type DfnBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DfnBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.dfn [] [ html.text x ]
        static member create (x: int) = Html.dfn [] [ html.text x ]
        static member create (x: float) = Html.dfn [] [ html.text x ]
        static member create (x: Node) = Html.dfn [] [ x ]
        static member create (x: Node list) = Html.dfn [] x
        member this.Yield _ = DfnBuilder()
        override this.MakeNode (x, y) = Html.dfn x y

    type dfn = DfnBuilder


    type DialogBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DialogBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.dialog [] [ html.text x ]
        static member create (x: int) = Html.dialog [] [ html.text x ]
        static member create (x: float) = Html.dialog [] [ html.text x ]
        static member create (x: Node) = Html.dialog [] [ x ]
        static member create (x: Node list) = Html.dialog [] x
        member this.Yield _ = DialogBuilder()
        override this.MakeNode (x, y) = Html.dialog x y

    type dialog = DialogBuilder


    type DirBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DirBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.dir [] [ html.text x ]
        static member create (x: int) = Html.dir [] [ html.text x ]
        static member create (x: float) = Html.dir [] [ html.text x ]
        static member create (x: Node) = Html.dir [] [ x ]
        static member create (x: Node list) = Html.dir [] x
        member this.Yield _ = DirBuilder()
        override this.MakeNode (x, y) = Html.dir x y

    type dir = DirBuilder


    type DivBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DivBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.div [] [ html.text x ]
        static member create (x: int) = Html.div [] [ html.text x ]
        static member create (x: float) = Html.div [] [ html.text x ]
        static member create (x: Node) = Html.div [] [ x ]
        static member create (x: Node list) = Html.div [] x
        member this.Yield _ = DivBuilder()
        override this.MakeNode (x, y) = Html.div x y

    type div = DivBuilder


    type DlBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DlBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.dl [] [ html.text x ]
        static member create (x: int) = Html.dl [] [ html.text x ]
        static member create (x: float) = Html.dl [] [ html.text x ]
        static member create (x: Node) = Html.dl [] [ x ]
        static member create (x: Node list) = Html.dl [] x
        member this.Yield _ = DlBuilder()
        override this.MakeNode (x, y) = Html.dl x y

    type dl = DlBuilder


    type DtBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = DtBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.dt [] [ html.text x ]
        static member create (x: int) = Html.dt [] [ html.text x ]
        static member create (x: float) = Html.dt [] [ html.text x ]
        static member create (x: Node) = Html.dt [] [ x ]
        static member create (x: Node list) = Html.dt [] x
        member this.Yield _ = DtBuilder()
        override this.MakeNode (x, y) = Html.dt x y

    type dt = DtBuilder


    type ElementBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ElementBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.element [] [ html.text x ]
        static member create (x: int) = Html.element [] [ html.text x ]
        static member create (x: float) = Html.element [] [ html.text x ]
        static member create (x: Node) = Html.element [] [ x ]
        static member create (x: Node list) = Html.element [] x
        member this.Yield _ = ElementBuilder()
        override this.MakeNode (x, y) = Html.element x y

    type element = ElementBuilder


    type EmBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = EmBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.em [] [ html.text x ]
        static member create (x: int) = Html.em [] [ html.text x ]
        static member create (x: float) = Html.em [] [ html.text x ]
        static member create (x: Node) = Html.em [] [ x ]
        static member create (x: Node list) = Html.em [] x
        member this.Yield _ = EmBuilder()
        override this.MakeNode (x, y) = Html.em x y

    type em = EmBuilder


    type EmbedBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = EmbedBuilder()
        override this.MakeNode (x, y) = Html.embed x

    type embed = EmbedBuilder


    type FieldsetBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = FieldsetBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.fieldset [] [ html.text x ]
        static member create (x: int) = Html.fieldset [] [ html.text x ]
        static member create (x: float) = Html.fieldset [] [ html.text x ]
        static member create (x: Node) = Html.fieldset [] [ x ]
        static member create (x: Node list) = Html.fieldset [] x
        member this.Yield _ = FieldsetBuilder()
        override this.MakeNode (x, y) = Html.fieldset x y

    type fieldset = FieldsetBuilder


    type FigcaptionBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = FigcaptionBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.figcaption [] [ html.text x ]
        static member create (x: int) = Html.figcaption [] [ html.text x ]
        static member create (x: float) = Html.figcaption [] [ html.text x ]
        static member create (x: Node) = Html.figcaption [] [ x ]
        static member create (x: Node list) = Html.figcaption [] x
        member this.Yield _ = FigcaptionBuilder()
        override this.MakeNode (x, y) = Html.figcaption x y

    type figcaption = FigcaptionBuilder


    type FigureBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = FigureBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.figure [] [ html.text x ]
        static member create (x: int) = Html.figure [] [ html.text x ]
        static member create (x: float) = Html.figure [] [ html.text x ]
        static member create (x: Node) = Html.figure [] [ x ]
        static member create (x: Node list) = Html.figure [] x
        member this.Yield _ = FigureBuilder()
        override this.MakeNode (x, y) = Html.figure x y

    type figure = FigureBuilder


    type FontBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = FontBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.font [] [ html.text x ]
        static member create (x: int) = Html.font [] [ html.text x ]
        static member create (x: float) = Html.font [] [ html.text x ]
        static member create (x: Node) = Html.font [] [ x ]
        static member create (x: Node list) = Html.font [] x
        member this.Yield _ = FontBuilder()
        override this.MakeNode (x, y) = Html.font x y

    type font = FontBuilder


    type FooterBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = FooterBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.footer [] [ html.text x ]
        static member create (x: int) = Html.footer [] [ html.text x ]
        static member create (x: float) = Html.footer [] [ html.text x ]
        static member create (x: Node) = Html.footer [] [ x ]
        static member create (x: Node list) = Html.footer [] x
        member this.Yield _ = FooterBuilder()
        override this.MakeNode (x, y) = Html.footer x y

    type footer = FooterBuilder


    type FormBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = FormBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.form [] [ html.text x ]
        static member create (x: int) = Html.form [] [ html.text x ]
        static member create (x: float) = Html.form [] [ html.text x ]
        static member create (x: Node) = Html.form [] [ x ]
        static member create (x: Node list) = Html.form [] x
        member this.Yield _ = FormBuilder()
        override this.MakeNode (x, y) = Html.form x y

    type form = FormBuilder


    type FrameBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = FrameBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.frame [] [ html.text x ]
        static member create (x: int) = Html.frame [] [ html.text x ]
        static member create (x: float) = Html.frame [] [ html.text x ]
        static member create (x: Node) = Html.frame [] [ x ]
        static member create (x: Node list) = Html.frame [] x
        member this.Yield _ = FrameBuilder()
        override this.MakeNode (x, y) = Html.frame x y

    type frame = FrameBuilder


    type FramesetBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = FramesetBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.frameset [] [ html.text x ]
        static member create (x: int) = Html.frameset [] [ html.text x ]
        static member create (x: float) = Html.frameset [] [ html.text x ]
        static member create (x: Node) = Html.frameset [] [ x ]
        static member create (x: Node list) = Html.frameset [] x
        member this.Yield _ = FramesetBuilder()
        override this.MakeNode (x, y) = Html.frameset x y

    type frameset = FramesetBuilder


    type H1Builder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = H1Builder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.h1 [] [ html.text x ]
        static member create (x: int) = Html.h1 [] [ html.text x ]
        static member create (x: float) = Html.h1 [] [ html.text x ]
        static member create (x: Node) = Html.h1 [] [ x ]
        static member create (x: Node list) = Html.h1 [] x
        member this.Yield _ = H1Builder()
        override this.MakeNode (x, y) = Html.h1 x y

    type h1 = H1Builder


    type H2Builder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = H2Builder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.h2 [] [ html.text x ]
        static member create (x: int) = Html.h2 [] [ html.text x ]
        static member create (x: float) = Html.h2 [] [ html.text x ]
        static member create (x: Node) = Html.h2 [] [ x ]
        static member create (x: Node list) = Html.h2 [] x
        member this.Yield _ = H2Builder()
        override this.MakeNode (x, y) = Html.h2 x y

    type h2 = H2Builder


    type H3Builder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = H3Builder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.h3 [] [ html.text x ]
        static member create (x: int) = Html.h3 [] [ html.text x ]
        static member create (x: float) = Html.h3 [] [ html.text x ]
        static member create (x: Node) = Html.h3 [] [ x ]
        static member create (x: Node list) = Html.h3 [] x
        member this.Yield _ = H3Builder()
        override this.MakeNode (x, y) = Html.h3 x y

    type h3 = H3Builder


    type H4Builder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = H4Builder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.h4 [] [ html.text x ]
        static member create (x: int) = Html.h4 [] [ html.text x ]
        static member create (x: float) = Html.h4 [] [ html.text x ]
        static member create (x: Node) = Html.h4 [] [ x ]
        static member create (x: Node list) = Html.h4 [] x
        member this.Yield _ = H4Builder()
        override this.MakeNode (x, y) = Html.h4 x y

    type h4 = H4Builder


    type H5Builder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = H5Builder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.h5 [] [ html.text x ]
        static member create (x: int) = Html.h5 [] [ html.text x ]
        static member create (x: float) = Html.h5 [] [ html.text x ]
        static member create (x: Node) = Html.h5 [] [ x ]
        static member create (x: Node list) = Html.h5 [] x
        member this.Yield _ = H5Builder()
        override this.MakeNode (x, y) = Html.h5 x y

    type h5 = H5Builder


    type H6Builder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = H6Builder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.h6 [] [ html.text x ]
        static member create (x: int) = Html.h6 [] [ html.text x ]
        static member create (x: float) = Html.h6 [] [ html.text x ]
        static member create (x: Node) = Html.h6 [] [ x ]
        static member create (x: Node list) = Html.h6 [] x
        member this.Yield _ = H6Builder()
        override this.MakeNode (x, y) = Html.h6 x y

    type h6 = H6Builder


    type HeadBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = HeadBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.head [] [ html.text x ]
        static member create (x: int) = Html.head [] [ html.text x ]
        static member create (x: float) = Html.head [] [ html.text x ]
        static member create (x: Node) = Html.head [] [ x ]
        static member create (x: Node list) = Html.head [] x
        member this.Yield _ = HeadBuilder()
        override this.MakeNode (x, y) = Html.head x y

    type head = HeadBuilder


    type HeaderBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = HeaderBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.header [] [ html.text x ]
        static member create (x: int) = Html.header [] [ html.text x ]
        static member create (x: float) = Html.header [] [ html.text x ]
        static member create (x: Node) = Html.header [] [ x ]
        static member create (x: Node list) = Html.header [] x
        member this.Yield _ = HeaderBuilder()
        override this.MakeNode (x, y) = Html.header x y

    type header = HeaderBuilder


    type HrBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = HrBuilder()
        override this.MakeNode (x, y) = Html.hr x

    type hr = HrBuilder


    type HtmlBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = HtmlBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.html [] [ html.text x ]
        static member create (x: int) = Html.html [] [ html.text x ]
        static member create (x: float) = Html.html [] [ html.text x ]
        static member create (x: Node) = Html.html [] [ x ]
        static member create (x: Node list) = Html.html [] x
        member this.Yield _ = HtmlBuilder()
        override this.MakeNode (x, y) = Html.html x y

    type html' = HtmlBuilder


    type IBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = IBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.i [] [ html.text x ]
        static member create (x: int) = Html.i [] [ html.text x ]
        static member create (x: float) = Html.i [] [ html.text x ]
        static member create (x: Node) = Html.i [] [ x ]
        static member create (x: Node list) = Html.i [] x
        member this.Yield _ = IBuilder()
        override this.MakeNode (x, y) = Html.i x y

    type i = IBuilder


    type IframeBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = IframeBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.iframe [] [ html.text x ]
        static member create (x: int) = Html.iframe [] [ html.text x ]
        static member create (x: float) = Html.iframe [] [ html.text x ]
        static member create (x: Node) = Html.iframe [] [ x ]
        static member create (x: Node list) = Html.iframe [] x
        member this.Yield _ = IframeBuilder()
        override this.MakeNode (x, y) = Html.iframe x y

    type iframe = IframeBuilder


    type ImgBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = ImgBuilder()
        override this.MakeNode (x, y) = Html.img x

    type img = ImgBuilder


    type InputBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = InputBuilder()
        override this.MakeNode (x, y) = Html.input x

    type input = InputBuilder


    type InsBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = InsBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.ins [] [ html.text x ]
        static member create (x: int) = Html.ins [] [ html.text x ]
        static member create (x: float) = Html.ins [] [ html.text x ]
        static member create (x: Node) = Html.ins [] [ x ]
        static member create (x: Node list) = Html.ins [] x
        member this.Yield _ = InsBuilder()
        override this.MakeNode (x, y) = Html.ins x y

    type ins = InsBuilder


    type KbdBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = KbdBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.kbd [] [ html.text x ]
        static member create (x: int) = Html.kbd [] [ html.text x ]
        static member create (x: float) = Html.kbd [] [ html.text x ]
        static member create (x: Node) = Html.kbd [] [ x ]
        static member create (x: Node list) = Html.kbd [] x
        member this.Yield _ = KbdBuilder()
        override this.MakeNode (x, y) = Html.kbd x y

    type kbd = KbdBuilder


    type LabelBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = LabelBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.label [] [ html.text x ]
        static member create (x: int) = Html.label [] [ html.text x ]
        static member create (x: float) = Html.label [] [ html.text x ]
        static member create (x: Node) = Html.label [] [ x ]
        static member create (x: Node list) = Html.label [] x
        member this.Yield _ = LabelBuilder()
        override this.MakeNode (x, y) = Html.label x y

    type label = LabelBuilder


    type LegendBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = LegendBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.legend [] [ html.text x ]
        static member create (x: int) = Html.legend [] [ html.text x ]
        static member create (x: float) = Html.legend [] [ html.text x ]
        static member create (x: Node) = Html.legend [] [ x ]
        static member create (x: Node list) = Html.legend [] x
        member this.Yield _ = LegendBuilder()
        override this.MakeNode (x, y) = Html.legend x y

    type legend = LegendBuilder


    type LiBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = LiBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.li [] [ html.text x ]
        static member create (x: int) = Html.li [] [ html.text x ]
        static member create (x: float) = Html.li [] [ html.text x ]
        static member create (x: Node) = Html.li [] [ x ]
        static member create (x: Node list) = Html.li [] x
        member this.Yield _ = LiBuilder()
        override this.MakeNode (x, y) = Html.li x y

    type li = LiBuilder


    type LinkBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = LinkBuilder()
        override this.MakeNode (x, y) = Html.link x

    type link = LinkBuilder


    type MainBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = MainBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.main [] [ html.text x ]
        static member create (x: int) = Html.main [] [ html.text x ]
        static member create (x: float) = Html.main [] [ html.text x ]
        static member create (x: Node) = Html.main [] [ x ]
        static member create (x: Node list) = Html.main [] x
        member this.Yield _ = MainBuilder()
        override this.MakeNode (x, y) = Html.main x y

    type main = MainBuilder


    type MapBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = MapBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.map [] [ html.text x ]
        static member create (x: int) = Html.map [] [ html.text x ]
        static member create (x: float) = Html.map [] [ html.text x ]
        static member create (x: Node) = Html.map [] [ x ]
        static member create (x: Node list) = Html.map [] x
        member this.Yield _ = MapBuilder()
        override this.MakeNode (x, y) = Html.map x y

    type map = MapBuilder


    type MarkBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = MarkBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.mark [] [ html.text x ]
        static member create (x: int) = Html.mark [] [ html.text x ]
        static member create (x: float) = Html.mark [] [ html.text x ]
        static member create (x: Node) = Html.mark [] [ x ]
        static member create (x: Node list) = Html.mark [] x
        member this.Yield _ = MarkBuilder()
        override this.MakeNode (x, y) = Html.mark x y

    type mark = MarkBuilder


    type MenuBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = MenuBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.menu [] [ html.text x ]
        static member create (x: int) = Html.menu [] [ html.text x ]
        static member create (x: float) = Html.menu [] [ html.text x ]
        static member create (x: Node) = Html.menu [] [ x ]
        static member create (x: Node list) = Html.menu [] x
        member this.Yield _ = MenuBuilder()
        override this.MakeNode (x, y) = Html.menu x y

    type menu = MenuBuilder


    type MenuitemBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = MenuitemBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.menuitem [] [ html.text x ]
        static member create (x: int) = Html.menuitem [] [ html.text x ]
        static member create (x: float) = Html.menuitem [] [ html.text x ]
        static member create (x: Node) = Html.menuitem [] [ x ]
        static member create (x: Node list) = Html.menuitem [] x
        member this.Yield _ = MenuitemBuilder()
        override this.MakeNode (x, y) = Html.menuitem x y

    type menuitem = MenuitemBuilder


    type MetaBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = MetaBuilder()
        override this.MakeNode (x, y) = Html.meta x

    type meta = MetaBuilder


    type MeterBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = MeterBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.meter [] [ html.text x ]
        static member create (x: int) = Html.meter [] [ html.text x ]
        static member create (x: float) = Html.meter [] [ html.text x ]
        static member create (x: Node) = Html.meter [] [ x ]
        static member create (x: Node list) = Html.meter [] x
        member this.Yield _ = MeterBuilder()
        override this.MakeNode (x, y) = Html.meter x y

    type meter = MeterBuilder


    type NavBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = NavBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.nav [] [ html.text x ]
        static member create (x: int) = Html.nav [] [ html.text x ]
        static member create (x: float) = Html.nav [] [ html.text x ]
        static member create (x: Node) = Html.nav [] [ x ]
        static member create (x: Node list) = Html.nav [] x
        member this.Yield _ = NavBuilder()
        override this.MakeNode (x, y) = Html.nav x y

    type nav = NavBuilder


    type NoembedBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = NoembedBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.noembed [] [ html.text x ]
        static member create (x: int) = Html.noembed [] [ html.text x ]
        static member create (x: float) = Html.noembed [] [ html.text x ]
        static member create (x: Node) = Html.noembed [] [ x ]
        static member create (x: Node list) = Html.noembed [] x
        member this.Yield _ = NoembedBuilder()
        override this.MakeNode (x, y) = Html.noembed x y

    type noembed = NoembedBuilder


    type NoframesBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = NoframesBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.noframes [] [ html.text x ]
        static member create (x: int) = Html.noframes [] [ html.text x ]
        static member create (x: float) = Html.noframes [] [ html.text x ]
        static member create (x: Node) = Html.noframes [] [ x ]
        static member create (x: Node list) = Html.noframes [] x
        member this.Yield _ = NoframesBuilder()
        override this.MakeNode (x, y) = Html.noframes x y

    type noframes = NoframesBuilder


    type NoscriptBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = NoscriptBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.noscript [] [ html.text x ]
        static member create (x: int) = Html.noscript [] [ html.text x ]
        static member create (x: float) = Html.noscript [] [ html.text x ]
        static member create (x: Node) = Html.noscript [] [ x ]
        static member create (x: Node list) = Html.noscript [] x
        member this.Yield _ = NoscriptBuilder()
        override this.MakeNode (x, y) = Html.noscript x y

    type noscript = NoscriptBuilder


    type ObjectBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ObjectBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.object [] [ html.text x ]
        static member create (x: int) = Html.object [] [ html.text x ]
        static member create (x: float) = Html.object [] [ html.text x ]
        static member create (x: Node) = Html.object [] [ x ]
        static member create (x: Node list) = Html.object [] x
        member this.Yield _ = ObjectBuilder()
        override this.MakeNode (x, y) = Html.object x y

    type object = ObjectBuilder


    type OlBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = OlBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.ol [] [ html.text x ]
        static member create (x: int) = Html.ol [] [ html.text x ]
        static member create (x: float) = Html.ol [] [ html.text x ]
        static member create (x: Node) = Html.ol [] [ x ]
        static member create (x: Node list) = Html.ol [] x
        member this.Yield _ = OlBuilder()
        override this.MakeNode (x, y) = Html.ol x y

    type ol = OlBuilder


    type OptgroupBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = OptgroupBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.optgroup [] [ html.text x ]
        static member create (x: int) = Html.optgroup [] [ html.text x ]
        static member create (x: float) = Html.optgroup [] [ html.text x ]
        static member create (x: Node) = Html.optgroup [] [ x ]
        static member create (x: Node list) = Html.optgroup [] x
        member this.Yield _ = OptgroupBuilder()
        override this.MakeNode (x, y) = Html.optgroup x y

    type optgroup = OptgroupBuilder


    type OptionBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = OptionBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.option [] [ html.text x ]
        static member create (x: int) = Html.option [] [ html.text x ]
        static member create (x: float) = Html.option [] [ html.text x ]
        static member create (x: Node) = Html.option [] [ x ]
        static member create (x: Node list) = Html.option [] x
        member this.Yield _ = OptionBuilder()
        override this.MakeNode (x, y) = Html.option x y

    type option = OptionBuilder


    type OutputBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = OutputBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.output [] [ html.text x ]
        static member create (x: int) = Html.output [] [ html.text x ]
        static member create (x: float) = Html.output [] [ html.text x ]
        static member create (x: Node) = Html.output [] [ x ]
        static member create (x: Node list) = Html.output [] x
        member this.Yield _ = OutputBuilder()
        override this.MakeNode (x, y) = Html.output x y

    type output = OutputBuilder


    type PBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = PBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.p [] [ html.text x ]
        static member create (x: int) = Html.p [] [ html.text x ]
        static member create (x: float) = Html.p [] [ html.text x ]
        static member create (x: Node) = Html.p [] [ x ]
        static member create (x: Node list) = Html.p [] x
        member this.Yield _ = PBuilder()
        override this.MakeNode (x, y) = Html.p x y

    type p = PBuilder


    type ParamBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = ParamBuilder()
        override this.MakeNode (x, y) = Html.param x

    type param = ParamBuilder


    type PictureBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = PictureBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.picture [] [ html.text x ]
        static member create (x: int) = Html.picture [] [ html.text x ]
        static member create (x: float) = Html.picture [] [ html.text x ]
        static member create (x: Node) = Html.picture [] [ x ]
        static member create (x: Node list) = Html.picture [] x
        member this.Yield _ = PictureBuilder()
        override this.MakeNode (x, y) = Html.picture x y

    type picture = PictureBuilder


    type PreBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = PreBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.pre [] [ html.text x ]
        static member create (x: int) = Html.pre [] [ html.text x ]
        static member create (x: float) = Html.pre [] [ html.text x ]
        static member create (x: Node) = Html.pre [] [ x ]
        static member create (x: Node list) = Html.pre [] x
        member this.Yield _ = PreBuilder()
        override this.MakeNode (x, y) = Html.pre x y

    type pre = PreBuilder


    type ProgressBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ProgressBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.progress [] [ html.text x ]
        static member create (x: int) = Html.progress [] [ html.text x ]
        static member create (x: float) = Html.progress [] [ html.text x ]
        static member create (x: Node) = Html.progress [] [ x ]
        static member create (x: Node list) = Html.progress [] x
        member this.Yield _ = ProgressBuilder()
        override this.MakeNode (x, y) = Html.progress x y

    type progress = ProgressBuilder


    type QBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = QBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.q [] [ html.text x ]
        static member create (x: int) = Html.q [] [ html.text x ]
        static member create (x: float) = Html.q [] [ html.text x ]
        static member create (x: Node) = Html.q [] [ x ]
        static member create (x: Node list) = Html.q [] x
        member this.Yield _ = QBuilder()
        override this.MakeNode (x, y) = Html.q x y

    type q = QBuilder


    type RbBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = RbBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.rb [] [ html.text x ]
        static member create (x: int) = Html.rb [] [ html.text x ]
        static member create (x: float) = Html.rb [] [ html.text x ]
        static member create (x: Node) = Html.rb [] [ x ]
        static member create (x: Node list) = Html.rb [] x
        member this.Yield _ = RbBuilder()
        override this.MakeNode (x, y) = Html.rb x y

    type rb = RbBuilder


    type RpBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = RpBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.rp [] [ html.text x ]
        static member create (x: int) = Html.rp [] [ html.text x ]
        static member create (x: float) = Html.rp [] [ html.text x ]
        static member create (x: Node) = Html.rp [] [ x ]
        static member create (x: Node list) = Html.rp [] x
        member this.Yield _ = RpBuilder()
        override this.MakeNode (x, y) = Html.rp x y

    type rp = RpBuilder


    type RtBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = RtBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.rt [] [ html.text x ]
        static member create (x: int) = Html.rt [] [ html.text x ]
        static member create (x: float) = Html.rt [] [ html.text x ]
        static member create (x: Node) = Html.rt [] [ x ]
        static member create (x: Node list) = Html.rt [] x
        member this.Yield _ = RtBuilder()
        override this.MakeNode (x, y) = Html.rt x y

    type rt = RtBuilder


    type RtcBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = RtcBuilder()
        override this.MakeNode (x, y) = Html.rtc x

    type rtc = RtcBuilder


    type RubyBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = RubyBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.ruby [] [ html.text x ]
        static member create (x: int) = Html.ruby [] [ html.text x ]
        static member create (x: float) = Html.ruby [] [ html.text x ]
        static member create (x: Node) = Html.ruby [] [ x ]
        static member create (x: Node list) = Html.ruby [] x
        member this.Yield _ = RubyBuilder()
        override this.MakeNode (x, y) = Html.ruby x y

    type ruby = RubyBuilder


    type SBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.s [] [ html.text x ]
        static member create (x: int) = Html.s [] [ html.text x ]
        static member create (x: float) = Html.s [] [ html.text x ]
        static member create (x: Node) = Html.s [] [ x ]
        static member create (x: Node list) = Html.s [] x
        member this.Yield _ = SBuilder()
        override this.MakeNode (x, y) = Html.s x y

    type s = SBuilder


    type SampBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SampBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.samp [] [ html.text x ]
        static member create (x: int) = Html.samp [] [ html.text x ]
        static member create (x: float) = Html.samp [] [ html.text x ]
        static member create (x: Node) = Html.samp [] [ x ]
        static member create (x: Node list) = Html.samp [] x
        member this.Yield _ = SampBuilder()
        override this.MakeNode (x, y) = Html.samp x y

    type samp = SampBuilder


    type ScriptBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ScriptBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.script [] [ html.text x ]
        static member create (x: int) = Html.script [] [ html.text x ]
        static member create (x: float) = Html.script [] [ html.text x ]
        static member create (x: Node) = Html.script [] [ x ]
        static member create (x: Node list) = Html.script [] x
        member this.Yield _ = ScriptBuilder()
        override this.MakeNode (x, y) = Html.script x y

    type script = ScriptBuilder


    type SectionBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SectionBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.section [] [ html.text x ]
        static member create (x: int) = Html.section [] [ html.text x ]
        static member create (x: float) = Html.section [] [ html.text x ]
        static member create (x: Node) = Html.section [] [ x ]
        static member create (x: Node list) = Html.section [] x
        member this.Yield _ = SectionBuilder()
        override this.MakeNode (x, y) = Html.section x y

    type section = SectionBuilder


    type SelectBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SelectBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.select [] [ html.text x ]
        static member create (x: int) = Html.select [] [ html.text x ]
        static member create (x: float) = Html.select [] [ html.text x ]
        static member create (x: Node) = Html.select [] [ x ]
        static member create (x: Node list) = Html.select [] x
        member this.Yield _ = SelectBuilder()
        override this.MakeNode (x, y) = Html.select x y

    type select = SelectBuilder


    type ShadowBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ShadowBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.shadow [] [ html.text x ]
        static member create (x: int) = Html.shadow [] [ html.text x ]
        static member create (x: float) = Html.shadow [] [ html.text x ]
        static member create (x: Node) = Html.shadow [] [ x ]
        static member create (x: Node list) = Html.shadow [] x
        member this.Yield _ = ShadowBuilder()
        override this.MakeNode (x, y) = Html.shadow x y

    type shadow = ShadowBuilder


    type SlotBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SlotBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.slot [] [ html.text x ]
        static member create (x: int) = Html.slot [] [ html.text x ]
        static member create (x: float) = Html.slot [] [ html.text x ]
        static member create (x: Node) = Html.slot [] [ x ]
        static member create (x: Node list) = Html.slot [] x
        member this.Yield _ = SlotBuilder()
        override this.MakeNode (x, y) = Html.slot x y

    type slot = SlotBuilder


    type SmallBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SmallBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.small [] [ html.text x ]
        static member create (x: int) = Html.small [] [ html.text x ]
        static member create (x: float) = Html.small [] [ html.text x ]
        static member create (x: Node) = Html.small [] [ x ]
        static member create (x: Node list) = Html.small [] x
        member this.Yield _ = SmallBuilder()
        override this.MakeNode (x, y) = Html.small x y

    type small = SmallBuilder


    type SourceBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = SourceBuilder()
        override this.MakeNode (x, y) = Html.source x

    type source = SourceBuilder


    type SpanBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SpanBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.span [] [ html.text x ]
        static member create (x: int) = Html.span [] [ html.text x ]
        static member create (x: float) = Html.span [] [ html.text x ]
        static member create (x: Node) = Html.span [] [ x ]
        static member create (x: Node list) = Html.span [] x
        member this.Yield _ = SpanBuilder()
        override this.MakeNode (x, y) = Html.span x y

    type span = SpanBuilder


    type StrikeBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = StrikeBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.strike [] [ html.text x ]
        static member create (x: int) = Html.strike [] [ html.text x ]
        static member create (x: float) = Html.strike [] [ html.text x ]
        static member create (x: Node) = Html.strike [] [ x ]
        static member create (x: Node list) = Html.strike [] x
        member this.Yield _ = StrikeBuilder()
        override this.MakeNode (x, y) = Html.strike x y

    type strike = StrikeBuilder


    type StrongBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = StrongBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.strong [] [ html.text x ]
        static member create (x: int) = Html.strong [] [ html.text x ]
        static member create (x: float) = Html.strong [] [ html.text x ]
        static member create (x: Node) = Html.strong [] [ x ]
        static member create (x: Node list) = Html.strong [] x
        member this.Yield _ = StrongBuilder()
        override this.MakeNode (x, y) = Html.strong x y

    type strong = StrongBuilder


    type StyleBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = StyleBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.style [] [ html.text x ]
        static member create (x: int) = Html.style [] [ html.text x ]
        static member create (x: float) = Html.style [] [ html.text x ]
        static member create (x: Node) = Html.style [] [ x ]
        static member create (x: Node list) = Html.style [] x
        member this.Yield _ = StyleBuilder()
        override this.MakeNode (x, y) = Html.style x y

    type style' = StyleBuilder


    type SubBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SubBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.sub [] [ html.text x ]
        static member create (x: int) = Html.sub [] [ html.text x ]
        static member create (x: float) = Html.sub [] [ html.text x ]
        static member create (x: Node) = Html.sub [] [ x ]
        static member create (x: Node list) = Html.sub [] x
        member this.Yield _ = SubBuilder()
        override this.MakeNode (x, y) = Html.sub x y

    type sub = SubBuilder


    type SummaryBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SummaryBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.summary [] [ html.text x ]
        static member create (x: int) = Html.summary [] [ html.text x ]
        static member create (x: float) = Html.summary [] [ html.text x ]
        static member create (x: Node) = Html.summary [] [ x ]
        static member create (x: Node list) = Html.summary [] x
        member this.Yield _ = SummaryBuilder()
        override this.MakeNode (x, y) = Html.summary x y

    type summary = SummaryBuilder


    type SupBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SupBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.sup [] [ html.text x ]
        static member create (x: int) = Html.sup [] [ html.text x ]
        static member create (x: float) = Html.sup [] [ html.text x ]
        static member create (x: Node) = Html.sup [] [ x ]
        static member create (x: Node list) = Html.sup [] x
        member this.Yield _ = SupBuilder()
        override this.MakeNode (x, y) = Html.sup x y

    type sup = SupBuilder


    type SvgBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = SvgBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.svg [] [ html.text x ]
        static member create (x: int) = Html.svg [] [ html.text x ]
        static member create (x: float) = Html.svg [] [ html.text x ]
        static member create (x: Node) = Html.svg [] [ x ]
        static member create (x: Node list) = Html.svg [] x
        member this.Yield _ = SvgBuilder()
        override this.MakeNode (x, y) = Html.svg x y

    type svg = SvgBuilder


    type TableBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TableBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.table [] [ html.text x ]
        static member create (x: int) = Html.table [] [ html.text x ]
        static member create (x: float) = Html.table [] [ html.text x ]
        static member create (x: Node) = Html.table [] [ x ]
        static member create (x: Node list) = Html.table [] x
        member this.Yield _ = TableBuilder()
        override this.MakeNode (x, y) = Html.table x y

    type table = TableBuilder


    type TbodyBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TbodyBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.tbody [] [ html.text x ]
        static member create (x: int) = Html.tbody [] [ html.text x ]
        static member create (x: float) = Html.tbody [] [ html.text x ]
        static member create (x: Node) = Html.tbody [] [ x ]
        static member create (x: Node list) = Html.tbody [] x
        member this.Yield _ = TbodyBuilder()
        override this.MakeNode (x, y) = Html.tbody x y

    type tbody = TbodyBuilder


    type TdBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TdBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.td [] [ html.text x ]
        static member create (x: int) = Html.td [] [ html.text x ]
        static member create (x: float) = Html.td [] [ html.text x ]
        static member create (x: Node) = Html.td [] [ x ]
        static member create (x: Node list) = Html.td [] x
        member this.Yield _ = TdBuilder()
        override this.MakeNode (x, y) = Html.td x y

    type td = TdBuilder


    type TemplateBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TemplateBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.template [] [ html.text x ]
        static member create (x: int) = Html.template [] [ html.text x ]
        static member create (x: float) = Html.template [] [ html.text x ]
        static member create (x: Node) = Html.template [] [ x ]
        static member create (x: Node list) = Html.template [] x
        member this.Yield _ = TemplateBuilder()
        override this.MakeNode (x, y) = Html.template x y

    type template = TemplateBuilder


    type TextareaBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TextareaBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.textarea [] [ html.text x ]
        static member create (x: int) = Html.textarea [] [ html.text x ]
        static member create (x: float) = Html.textarea [] [ html.text x ]
        static member create (x: Node) = Html.textarea [] [ x ]
        static member create (x: Node list) = Html.textarea [] x
        member this.Yield _ = TextareaBuilder()
        override this.MakeNode (x, y) = Html.textarea x y

    type textarea = TextareaBuilder


    type TfootBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TfootBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.tfoot [] [ html.text x ]
        static member create (x: int) = Html.tfoot [] [ html.text x ]
        static member create (x: float) = Html.tfoot [] [ html.text x ]
        static member create (x: Node) = Html.tfoot [] [ x ]
        static member create (x: Node list) = Html.tfoot [] x
        member this.Yield _ = TfootBuilder()
        override this.MakeNode (x, y) = Html.tfoot x y

    type tfoot = TfootBuilder


    type ThBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = ThBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.th [] [ html.text x ]
        static member create (x: int) = Html.th [] [ html.text x ]
        static member create (x: float) = Html.th [] [ html.text x ]
        static member create (x: Node) = Html.th [] [ x ]
        static member create (x: Node list) = Html.th [] x
        member this.Yield _ = ThBuilder()
        override this.MakeNode (x, y) = Html.th x y

    type th = ThBuilder


    type TheadBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TheadBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.thead [] [ html.text x ]
        static member create (x: int) = Html.thead [] [ html.text x ]
        static member create (x: float) = Html.thead [] [ html.text x ]
        static member create (x: Node) = Html.thead [] [ x ]
        static member create (x: Node list) = Html.thead [] x
        member this.Yield _ = TheadBuilder()
        override this.MakeNode (x, y) = Html.thead x y

    type thead = TheadBuilder


    type TimeBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TimeBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.time [] [ html.text x ]
        static member create (x: int) = Html.time [] [ html.text x ]
        static member create (x: float) = Html.time [] [ html.text x ]
        static member create (x: Node) = Html.time [] [ x ]
        static member create (x: Node list) = Html.time [] x
        member this.Yield _ = TimeBuilder()
        override this.MakeNode (x, y) = Html.time x y

    type time = TimeBuilder


    type TitleBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TitleBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.title [] [ html.text x ]
        static member create (x: int) = Html.title [] [ html.text x ]
        static member create (x: float) = Html.title [] [ html.text x ]
        static member create (x: Node) = Html.title [] [ x ]
        static member create (x: Node list) = Html.title [] x
        member this.Yield _ = TitleBuilder()
        override this.MakeNode (x, y) = Html.title x y

    type title = TitleBuilder


    type TrBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TrBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.tr [] [ html.text x ]
        static member create (x: int) = Html.tr [] [ html.text x ]
        static member create (x: float) = Html.tr [] [ html.text x ]
        static member create (x: Node) = Html.tr [] [ x ]
        static member create (x: Node list) = Html.tr [] x
        member this.Yield _ = TrBuilder()
        override this.MakeNode (x, y) = Html.tr x y

    type tr = TrBuilder


    type TrackBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = TrackBuilder()
        override this.MakeNode (x, y) = Html.track x

    type track = TrackBuilder


    type TtBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = TtBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.tt [] [ html.text x ]
        static member create (x: int) = Html.tt [] [ html.text x ]
        static member create (x: float) = Html.tt [] [ html.text x ]
        static member create (x: Node) = Html.tt [] [ x ]
        static member create (x: Node list) = Html.tt [] x
        member this.Yield _ = TtBuilder()
        override this.MakeNode (x, y) = Html.tt x y

    type tt = TtBuilder


    type UBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = UBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.u [] [ html.text x ]
        static member create (x: int) = Html.u [] [ html.text x ]
        static member create (x: float) = Html.u [] [ html.text x ]
        static member create (x: Node) = Html.u [] [ x ]
        static member create (x: Node list) = Html.u [] x
        member this.Yield _ = UBuilder()
        override this.MakeNode (x, y) = Html.u x y

    type u = UBuilder


    type UlBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = UlBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.ul [] [ html.text x ]
        static member create (x: int) = Html.ul [] [ html.text x ]
        static member create (x: float) = Html.ul [] [ html.text x ]
        static member create (x: Node) = Html.ul [] [ x ]
        static member create (x: Node list) = Html.ul [] x
        member this.Yield _ = UlBuilder()
        override this.MakeNode (x, y) = Html.ul x y

    type ul = UlBuilder


    type VarBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = VarBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.var [] [ html.text x ]
        static member create (x: int) = Html.var [] [ html.text x ]
        static member create (x: float) = Html.var [] [ html.text x ]
        static member create (x: Node) = Html.var [] [ x ]
        static member create (x: Node list) = Html.var [] x
        member this.Yield _ = VarBuilder()
        override this.MakeNode (x, y) = Html.var x y

    type var = VarBuilder


    type VideoBuilder () =
        inherit FunBlazorEltBuilder()
        new (x: string) as this = VideoBuilder() then Text x |> this.AddNode |> ignore
        static member create (x: string) = Html.video [] [ html.text x ]
        static member create (x: int) = Html.video [] [ html.text x ]
        static member create (x: float) = Html.video [] [ html.text x ]
        static member create (x: Node) = Html.video [] [ x ]
        static member create (x: Node list) = Html.video [] x
        member this.Yield _ = VideoBuilder()
        override this.MakeNode (x, y) = Html.video x y

    type video = VideoBuilder


    type WbrBuilder () =
        inherit FunBlazorEltBuilder()
               
        member this.Yield _ = WbrBuilder()
        override this.MakeNode (x, y) = Html.wbr x

    type wbr = WbrBuilder
