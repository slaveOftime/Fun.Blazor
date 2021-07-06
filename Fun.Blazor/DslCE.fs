namespace Fun.Blazor

open Bolero
open Bolero.Html
open Fun.Blazor
open System
open System.Threading.Tasks
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web


type FunBlazorContextWithAttrs<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'Component>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'Component>, v: IFunBlazorNode list) = Fragment v :> IFunBlazorNode |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'Component>, v: string) = Fragment [ html.text v ] :> IFunBlazorNode |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'Component>, v: int) = Fragment [ html.text v ] :> IFunBlazorNode |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'Component>, v: float) = Fragment [ html.text v ] :> IFunBlazorNode |> this.AddProp
    [<CustomOperation("childContentRaw")>] member this.childContentRaw (_: FunBlazorContext<'Component>, v: string) = Fragment [ html.raw v ] :> IFunBlazorNode |> this.AddProp
    
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<'Component>, v: string seq) = attr.classes v |> this.AddProp
    
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<'Component>, v: (string * string) list) = attr.styles v |> this.AddProp
    
    [<CustomOperation("class'")>] member this.class' (_: FunBlazorContext<'Component>, v: string) = attr.className v |> this.AddProp
    [<CustomOperation("bindRef")>] member this.bindRef (_: FunBlazorContext<'Component>, v: obj) = "bindRef" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<'Component>, v: obj) = "key" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("accept")>] member this.accept (_: FunBlazorContext<'Component>, v: obj) = "accept" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("acceptCharset")>] member this.acceptCharset (_: FunBlazorContext<'Component>, v: obj) = "acceptCharset" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("accesskey")>] member this.accesskey (_: FunBlazorContext<'Component>, v: obj) = "accesskey" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("action")>] member this.action (_: FunBlazorContext<'Component>, v: obj) = "action" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("align")>] member this.align (_: FunBlazorContext<'Component>, v: obj) = "align" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("allow")>] member this.allow (_: FunBlazorContext<'Component>, v: obj) = "allow" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("alt")>] member this.alt (_: FunBlazorContext<'Component>, v: obj) = "alt" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("async'")>] member this.async' (_: FunBlazorContext<'Component>, v: obj) = "async'" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("autocapitalize")>] member this.autocapitalize (_: FunBlazorContext<'Component>, v: obj) = "autocapitalize" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("autocomplete")>] member this.autocomplete (_: FunBlazorContext<'Component>, v: obj) = "autocomplete" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("autofocus")>] member this.autofocus (_: FunBlazorContext<'Component>, v: obj) = "autofocus" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoplay")>] member this.autoplay (_: FunBlazorContext<'Component>, v: obj) = "autoplay" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("bgcolor")>] member this.bgcolor (_: FunBlazorContext<'Component>, v: obj) = "bgcolor" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("border")>] member this.border (_: FunBlazorContext<'Component>, v: obj) = "border" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("buffered")>] member this.buffered (_: FunBlazorContext<'Component>, v: obj) = "buffered" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("challenge")>] member this.challenge (_: FunBlazorContext<'Component>, v: obj) = "challenge" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("charset")>] member this.charset (_: FunBlazorContext<'Component>, v: obj) = "charset" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.``checked`` (_: FunBlazorContext<'Component>, v: obj) = "``checked``" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("cite")>] member this.cite (_: FunBlazorContext<'Component>, v: obj) = "cite" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("class'")>] member this.``class`` (_: FunBlazorContext<'Component>, v: obj) = "``class``" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("code")>] member this.code (_: FunBlazorContext<'Component>, v: obj) = "code" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("codebase")>] member this.codebase (_: FunBlazorContext<'Component>, v: obj) = "codebase" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<'Component>, v: obj) = "color" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("cols")>] member this.cols (_: FunBlazorContext<'Component>, v: obj) = "cols" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("colspan")>] member this.colspan (_: FunBlazorContext<'Component>, v: obj) = "colspan" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("content")>] member this.content (_: FunBlazorContext<'Component>, v: obj) = "content" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("contenteditable")>] member this.contenteditable (_: FunBlazorContext<'Component>, v: obj) = "contenteditable" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("contextmenu")>] member this.contextmenu (_: FunBlazorContext<'Component>, v: obj) = "contextmenu" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("controls")>] member this.controls (_: FunBlazorContext<'Component>, v: obj) = "controls" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("coords")>] member this.coords (_: FunBlazorContext<'Component>, v: obj) = "coords" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("crossorigin")>] member this.crossorigin (_: FunBlazorContext<'Component>, v: obj) = "crossorigin" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("csp")>] member this.csp (_: FunBlazorContext<'Component>, v: obj) = "csp" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<'Component>, v: obj) = "data" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("datetime")>] member this.datetime (_: FunBlazorContext<'Component>, v: obj) = "datetime" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("decoding")>] member this.decoding (_: FunBlazorContext<'Component>, v: obj) = "decoding" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("default'")>] member this.``default`` (_: FunBlazorContext<'Component>, v: obj) = "``default``" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("defer")>] member this.defer (_: FunBlazorContext<'Component>, v: obj) = "defer" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("dir")>] member this.dir (_: FunBlazorContext<'Component>, v: obj) = "dir" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("dirname")>] member this.dirname (_: FunBlazorContext<'Component>, v: obj) = "dirname" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<'Component>, v: obj) = "disabled" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("download")>] member this.download (_: FunBlazorContext<'Component>, v: obj) = "download" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("draggable")>] member this.draggable (_: FunBlazorContext<'Component>, v: obj) = "draggable" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropzone")>] member this.dropzone (_: FunBlazorContext<'Component>, v: obj) = "dropzone" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("enctype")>] member this.enctype (_: FunBlazorContext<'Component>, v: obj) = "enctype" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.``for`` (_: FunBlazorContext<'Component>, v: obj) = "``for``" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("form")>] member this.form (_: FunBlazorContext<'Component>, v: obj) = "form" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("formaction")>] member this.formaction (_: FunBlazorContext<'Component>, v: obj) = "formaction" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("headers")>] member this.headers (_: FunBlazorContext<'Component>, v: obj) = "headers" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<'Component>, v: obj) = "height" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("hidden")>] member this.hidden (_: FunBlazorContext<'Component>, v: obj) = "hidden" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("high")>] member this.high (_: FunBlazorContext<'Component>, v: obj) = "high" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<'Component>, v: obj) = "href" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("hreflang")>] member this.hreflang (_: FunBlazorContext<'Component>, v: obj) = "hreflang" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("httpEquiv")>] member this.httpEquiv (_: FunBlazorContext<'Component>, v: obj) = "httpEquiv" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<'Component>, v: obj) = "icon" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<'Component>, v: obj) = "id" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("importance")>] member this.importance (_: FunBlazorContext<'Component>, v: obj) = "importance" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("integrity")>] member this.integrity (_: FunBlazorContext<'Component>, v: obj) = "integrity" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("ismap")>] member this.ismap (_: FunBlazorContext<'Component>, v: obj) = "ismap" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemprop")>] member this.itemprop (_: FunBlazorContext<'Component>, v: obj) = "itemprop" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("keytype")>] member this.keytype (_: FunBlazorContext<'Component>, v: obj) = "keytype" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("kind")>] member this.kind (_: FunBlazorContext<'Component>, v: obj) = "kind" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<'Component>, v: obj) = "label" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("lang")>] member this.lang (_: FunBlazorContext<'Component>, v: obj) = "lang" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("language")>] member this.language (_: FunBlazorContext<'Component>, v: obj) = "language" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("lazyload")>] member this.lazyload (_: FunBlazorContext<'Component>, v: obj) = "lazyload" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("list")>] member this.list (_: FunBlazorContext<'Component>, v: obj) = "list" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("loop")>] member this.loop (_: FunBlazorContext<'Component>, v: obj) = "loop" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("low")>] member this.low (_: FunBlazorContext<'Component>, v: obj) = "low" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("manifest")>] member this.manifest (_: FunBlazorContext<'Component>, v: obj) = "manifest" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("max")>] member this.max (_: FunBlazorContext<'Component>, v: obj) = "max" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxlength")>] member this.maxlength (_: FunBlazorContext<'Component>, v: obj) = "maxlength" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("media")>] member this.media (_: FunBlazorContext<'Component>, v: obj) = "media" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("method")>] member this.method (_: FunBlazorContext<'Component>, v: obj) = "method" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("min")>] member this.min (_: FunBlazorContext<'Component>, v: obj) = "min" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("minlength")>] member this.minlength (_: FunBlazorContext<'Component>, v: obj) = "minlength" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiple")>] member this.multiple (_: FunBlazorContext<'Component>, v: obj) = "multiple" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("muted")>] member this.muted (_: FunBlazorContext<'Component>, v: obj) = "muted" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<'Component>, v: obj) = "name" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("novalidate")>] member this.novalidate (_: FunBlazorContext<'Component>, v: obj) = "novalidate" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.``open`` (_: FunBlazorContext<'Component>, v: obj) = "``open``" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("optimum")>] member this.optimum (_: FunBlazorContext<'Component>, v: obj) = "optimum" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("pattern")>] member this.pattern (_: FunBlazorContext<'Component>, v: obj) = "pattern" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("ping")>] member this.ping (_: FunBlazorContext<'Component>, v: obj) = "ping" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<'Component>, v: obj) = "placeholder" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("poster")>] member this.poster (_: FunBlazorContext<'Component>, v: obj) = "poster" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("preload")>] member this.preload (_: FunBlazorContext<'Component>, v: obj) = "preload" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("readonly")>] member this.readonly (_: FunBlazorContext<'Component>, v: obj) = "readonly" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("rel")>] member this.rel (_: FunBlazorContext<'Component>, v: obj) = "rel" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<'Component>, v: obj) = "required" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("reversed")>] member this.reversed (_: FunBlazorContext<'Component>, v: obj) = "reversed" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("rows")>] member this.rows (_: FunBlazorContext<'Component>, v: obj) = "rows" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowspan")>] member this.rowspan (_: FunBlazorContext<'Component>, v: obj) = "rowspan" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("sandbox")>] member this.sandbox (_: FunBlazorContext<'Component>, v: obj) = "sandbox" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("scope")>] member this.scope (_: FunBlazorContext<'Component>, v: obj) = "scope" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("selected")>] member this.selected (_: FunBlazorContext<'Component>, v: obj) = "selected" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("shape")>] member this.shape (_: FunBlazorContext<'Component>, v: obj) = "shape" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<'Component>, v: obj) = "size" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("sizes")>] member this.sizes (_: FunBlazorContext<'Component>, v: obj) = "sizes" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("slot")>] member this.slot (_: FunBlazorContext<'Component>, v: obj) = "slot" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("span")>] member this.span (_: FunBlazorContext<'Component>, v: obj) = "span" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("spellcheck")>] member this.spellcheck (_: FunBlazorContext<'Component>, v: obj) = "spellcheck" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("src")>] member this.src (_: FunBlazorContext<'Component>, v: obj) = "src" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("srcdoc")>] member this.srcdoc (_: FunBlazorContext<'Component>, v: obj) = "srcdoc" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("srclang")>] member this.srclang (_: FunBlazorContext<'Component>, v: obj) = "srclang" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("srcset")>] member this.srcset (_: FunBlazorContext<'Component>, v: obj) = "srcset" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("start")>] member this.start (_: FunBlazorContext<'Component>, v: obj) = "start" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("step")>] member this.step (_: FunBlazorContext<'Component>, v: obj) = "step" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("style'")>] member this.style' (_: FunBlazorContext<'Component>, v: obj) = "style" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("summary")>] member this.summary (_: FunBlazorContext<'Component>, v: obj) = "summary" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabindex")>] member this.tabindex (_: FunBlazorContext<'Component>, v: obj) = "tabindex" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<'Component>, v: obj) = "target" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<'Component>, v: obj) = "title" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("translate")>] member this.translate (_: FunBlazorContext<'Component>, v: obj) = "translate" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.``type`` (_: FunBlazorContext<'Component>, v: obj) = "``type``" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("usemap")>] member this.usemap (_: FunBlazorContext<'Component>, v: obj) = "usemap" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<'Component>, v: obj) = "value" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<'Component>, v: obj) = "width" => v |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrap")>] member this.wrap (_: FunBlazorContext<'Component>, v: obj) = "wrap" => v |> BoleroAttr |> this.AddProp


    [<CustomOperation("onfocus")>] member this.onfocus (_: FunBlazorContext<'Component>, callback: FocusEventArgs -> unit) = evt.focus callback |> this.AddProp
    [<CustomOperation("onfocusAsync")>] member this.onfocusAsync (_: FunBlazorContext<'Component>, callback: FocusEventArgs -> Async<unit>) = evt.async.focus callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onblur")>] member this.onblur (_: FunBlazorContext<'Component>, callback: FocusEventArgs -> unit) = evt.blur callback |> this.AddProp
    [<CustomOperation("onblurAsync")>] member this.onblurAsync (_: FunBlazorContext<'Component>, callback: FocusEventArgs -> Async<unit>) = evt.async.blur callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onfocusin")>] member this.onfocusin (_: FunBlazorContext<'Component>, callback: FocusEventArgs -> unit) = evt.focusin callback |> this.AddProp
    [<CustomOperation("onfocusinAsync")>] member this.onfocusinAsync (_: FunBlazorContext<'Component>, callback: FocusEventArgs -> Async<unit>) = evt.async.focusin callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onfocusout")>] member this.onfocusout (_: FunBlazorContext<'Component>, callback: FocusEventArgs -> unit) = evt.focusout callback |> this.AddProp
    [<CustomOperation("onfocusoutAsync")>] member this.onfocusoutAsync (_: FunBlazorContext<'Component>, callback: FocusEventArgs -> Async<unit>) = evt.async.focusout callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onmouseover")>] member this.onmouseover (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.mouseover callback |> this.AddProp
    [<CustomOperation("onmouseoverAsync")>] member this.onmouseoverAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.mouseover callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onmouseout")>] member this.onmouseout (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.mouseout callback |> this.AddProp
    [<CustomOperation("onmouseoutAsync")>] member this.onmouseoutAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.mouseout callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onmousemove")>] member this.onmousemove (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.mousemove callback |> this.AddProp
    [<CustomOperation("onmousemoveAsync")>] member this.onmousemoveAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.mousemove callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onmousedown")>] member this.onmousedown (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.mousedown callback |> this.AddProp
    [<CustomOperation("onmousedownAsync")>] member this.onmousedownAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.mousedown callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onmouseup")>] member this.onmouseup (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.mouseup callback |> this.AddProp
    [<CustomOperation("onmouseupAsync")>] member this.onmouseupAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.mouseup callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onclick")>] member this.onclick (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.click callback |> this.AddProp
    [<CustomOperation("onclickAsync")>] member this.onclickAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.click callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondblclick")>] member this.ondblclick (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.dblclick callback |> this.AddProp
    [<CustomOperation("ondblclickAsync")>] member this.ondblclickAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.dblclick callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onwheel")>] member this.onwheel (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.wheel callback |> this.AddProp
    [<CustomOperation("onwheelAsync")>] member this.onwheelAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.wheel callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onmousewheel")>] member this.onmousewheel (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.mousewheel callback |> this.AddProp
    [<CustomOperation("onmousewheelAsync")>] member this.onmousewheelAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.mousewheel callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("oncontextmenu")>] member this.oncontextmenu (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> unit) = evt.contextmenu callback |> this.AddProp
    [<CustomOperation("oncontextmenuAsync")>] member this.oncontextmenuAsync (_: FunBlazorContext<'Component>, callback: MouseEventArgs -> Async<unit>) = evt.async.contextmenu callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondrag")>] member this.ondrag (_: FunBlazorContext<'Component>, callback: DragEventArgs -> unit) = evt.drag callback |> this.AddProp
    [<CustomOperation("ondragAsync")>] member this.ondragAsync (_: FunBlazorContext<'Component>, callback: DragEventArgs -> Async<unit>) = evt.async.drag callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondragend")>] member this.ondragend (_: FunBlazorContext<'Component>, callback: DragEventArgs -> unit) = evt.dragend callback |> this.AddProp
    [<CustomOperation("ondragendAsync")>] member this.ondragendAsync (_: FunBlazorContext<'Component>, callback: DragEventArgs -> Async<unit>) = evt.async.dragend callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondragenter")>] member this.ondragenter (_: FunBlazorContext<'Component>, callback: DragEventArgs -> unit) = evt.dragenter callback |> this.AddProp
    [<CustomOperation("ondragenterAsync")>] member this.ondragenterAsync (_: FunBlazorContext<'Component>, callback: DragEventArgs -> Async<unit>) = evt.async.dragenter callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondragleave")>] member this.ondragleave (_: FunBlazorContext<'Component>, callback: DragEventArgs -> unit) = evt.dragleave callback |> this.AddProp
    [<CustomOperation("ondragleaveAsync")>] member this.ondragleaveAsync (_: FunBlazorContext<'Component>, callback: DragEventArgs -> Async<unit>) = evt.async.dragleave callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondragover")>] member this.ondragover (_: FunBlazorContext<'Component>, callback: DragEventArgs -> unit) = evt.dragover callback |> this.AddProp
    [<CustomOperation("ondragoverAsync")>] member this.ondragoverAsync (_: FunBlazorContext<'Component>, callback: DragEventArgs -> Async<unit>) = evt.async.dragover callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondragstart")>] member this.ondragstart (_: FunBlazorContext<'Component>, callback: DragEventArgs -> unit) = evt.dragstart callback |> this.AddProp
    [<CustomOperation("ondragstartAsync")>] member this.ondragstartAsync (_: FunBlazorContext<'Component>, callback: DragEventArgs -> Async<unit>) = evt.async.dragstart callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondrop")>] member this.ondrop (_: FunBlazorContext<'Component>, callback: DragEventArgs -> unit) = evt.drop callback |> this.AddProp
    [<CustomOperation("ondropAsync")>] member this.ondropAsync (_: FunBlazorContext<'Component>, callback: DragEventArgs -> Async<unit>) = evt.async.drop callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeydown")>] member this.onkeydown (_: FunBlazorContext<'Component>, callback: KeyboardEventArgs -> unit) = evt.keydown callback |> this.AddProp
    [<CustomOperation("onkeydownAsync")>] member this.onkeydownAsync (_: FunBlazorContext<'Component>, callback: KeyboardEventArgs -> Async<unit>) = evt.async.keydown callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyup")>] member this.onkeyup (_: FunBlazorContext<'Component>, callback: KeyboardEventArgs -> unit) = evt.keyup callback |> this.AddProp
    [<CustomOperation("onkeyupAsync")>] member this.onkeyupAsync (_: FunBlazorContext<'Component>, callback: KeyboardEventArgs -> Async<unit>) = evt.async.keyup callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeypress")>] member this.onkeypress (_: FunBlazorContext<'Component>, callback: KeyboardEventArgs -> unit) = evt.keypress callback |> this.AddProp
    [<CustomOperation("onkeypressAsync")>] member this.onkeypressAsync (_: FunBlazorContext<'Component>, callback: KeyboardEventArgs -> Async<unit>) = evt.async.keypress callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onchange")>] member this.onchange (_: FunBlazorContext<'Component>, callback: ChangeEventArgs -> unit) = evt.change callback |> this.AddProp
    [<CustomOperation("onchangeAsync")>] member this.onchangeAsync (_: FunBlazorContext<'Component>, callback: ChangeEventArgs -> Async<unit>) = evt.async.change callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("oninput")>] member this.oninput (_: FunBlazorContext<'Component>, callback: ChangeEventArgs -> unit) = evt.input callback |> this.AddProp
    [<CustomOperation("oninputAsync")>] member this.oninputAsync (_: FunBlazorContext<'Component>, callback: ChangeEventArgs -> Async<unit>) = evt.async.input callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("oninvalid")>] member this.oninvalid (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.invalid callback |> this.AddProp
    [<CustomOperation("oninvalidAsync")>] member this.oninvalidAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.invalid callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onreset")>] member this.onreset (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.reset callback |> this.AddProp
    [<CustomOperation("onresetAsync")>] member this.onresetAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.reset callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onselect")>] member this.onselect (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.select callback |> this.AddProp
    [<CustomOperation("onselectAsync")>] member this.onselectAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.select callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onselectstart")>] member this.onselectstart (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.selectstart callback |> this.AddProp
    [<CustomOperation("onselectstartAsync")>] member this.onselectstartAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.selectstart callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onselectionchange")>] member this.onselectionchange (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.selectionchange callback |> this.AddProp
    [<CustomOperation("onselectionchangeAsync")>] member this.onselectionchangeAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.selectionchange callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onsubmit")>] member this.onsubmit (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.submit callback |> this.AddProp
    [<CustomOperation("onsubmitAsync")>] member this.onsubmitAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.submit callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onbeforecopy")>] member this.onbeforecopy (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.beforecopy callback |> this.AddProp
    [<CustomOperation("onbeforecopyAsync")>] member this.onbeforecopyAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.beforecopy callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onbeforecut")>] member this.onbeforecut (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.beforecut callback |> this.AddProp
    [<CustomOperation("onbeforecutAsync")>] member this.onbeforecutAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.beforecut callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onbeforepaste")>] member this.onbeforepaste (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.beforepaste callback |> this.AddProp
    [<CustomOperation("onbeforepasteAsync")>] member this.onbeforepasteAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.beforepaste callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("oncopy")>] member this.oncopy (_: FunBlazorContext<'Component>, callback: ClipboardEventArgs -> unit) = evt.copy callback |> this.AddProp
    [<CustomOperation("oncopyAsync")>] member this.oncopyAsync (_: FunBlazorContext<'Component>, callback: ClipboardEventArgs -> Async<unit>) = evt.async.copy callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("oncut")>] member this.oncut (_: FunBlazorContext<'Component>, callback: ClipboardEventArgs -> unit) = evt.cut callback |> this.AddProp
    [<CustomOperation("oncutAsync")>] member this.oncutAsync (_: FunBlazorContext<'Component>, callback: ClipboardEventArgs -> Async<unit>) = evt.async.cut callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpaste")>] member this.onpaste (_: FunBlazorContext<'Component>, callback: ClipboardEventArgs -> unit) = evt.paste callback |> this.AddProp
    [<CustomOperation("onpasteAsync")>] member this.onpasteAsync (_: FunBlazorContext<'Component>, callback: ClipboardEventArgs -> Async<unit>) = evt.async.paste callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ontouchcancel")>] member this.ontouchcancel (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> unit) = evt.touchcancel callback |> this.AddProp
    [<CustomOperation("ontouchcancelAsync")>] member this.ontouchcancelAsync (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> Async<unit>) = evt.async.touchcancel callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ontouchend")>] member this.ontouchend (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> unit) = evt.touchend callback |> this.AddProp
    [<CustomOperation("ontouchendAsync")>] member this.ontouchendAsync (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> Async<unit>) = evt.async.touchend callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ontouchmove")>] member this.ontouchmove (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> unit) = evt.touchmove callback |> this.AddProp
    [<CustomOperation("ontouchmoveAsync")>] member this.ontouchmoveAsync (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> Async<unit>) = evt.async.touchmove callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ontouchstart")>] member this.ontouchstart (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> unit) = evt.touchstart callback |> this.AddProp
    [<CustomOperation("ontouchstartAsync")>] member this.ontouchstartAsync (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> Async<unit>) = evt.async.touchstart callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ontouchenter")>] member this.ontouchenter (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> unit) = evt.touchenter callback |> this.AddProp
    [<CustomOperation("ontouchenterAsync")>] member this.ontouchenterAsync (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> Async<unit>) = evt.async.touchenter callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ontouchleave")>] member this.ontouchleave (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> unit) = evt.touchleave callback |> this.AddProp
    [<CustomOperation("ontouchleaveAsync")>] member this.ontouchleaveAsync (_: FunBlazorContext<'Component>, callback: TouchEventArgs -> Async<unit>) = evt.async.touchleave callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointercapture")>] member this.onpointercapture (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointercapture callback |> this.AddProp
    [<CustomOperation("onpointercaptureAsync")>] member this.onpointercaptureAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointercapture callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onlostpointercapture")>] member this.onlostpointercapture (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.lostpointercapture callback |> this.AddProp
    [<CustomOperation("onlostpointercaptureAsync")>] member this.onlostpointercaptureAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.lostpointercapture callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointercancel")>] member this.onpointercancel (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointercancel callback |> this.AddProp
    [<CustomOperation("onpointercancelAsync")>] member this.onpointercancelAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointercancel callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointerdown")>] member this.onpointerdown (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointerdown callback |> this.AddProp
    [<CustomOperation("onpointerdownAsync")>] member this.onpointerdownAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointerdown callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointerenter")>] member this.onpointerenter (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointerenter callback |> this.AddProp
    [<CustomOperation("onpointerenterAsync")>] member this.onpointerenterAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointerenter callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointerleave")>] member this.onpointerleave (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointerleave callback |> this.AddProp
    [<CustomOperation("onpointerleaveAsync")>] member this.onpointerleaveAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointerleave callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointermove")>] member this.onpointermove (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointermove callback |> this.AddProp
    [<CustomOperation("onpointermoveAsync")>] member this.onpointermoveAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointermove callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointerout")>] member this.onpointerout (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointerout callback |> this.AddProp
    [<CustomOperation("onpointeroutAsync")>] member this.onpointeroutAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointerout callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointerover")>] member this.onpointerover (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointerover callback |> this.AddProp
    [<CustomOperation("onpointeroverAsync")>] member this.onpointeroverAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointerover callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointerup")>] member this.onpointerup (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> unit) = evt.pointerup callback |> this.AddProp
    [<CustomOperation("onpointerupAsync")>] member this.onpointerupAsync (_: FunBlazorContext<'Component>, callback: PointerEventArgs -> Async<unit>) = evt.async.pointerup callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("oncanplay")>] member this.oncanplay (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.canplay callback |> this.AddProp
    [<CustomOperation("oncanplayAsync")>] member this.oncanplayAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.canplay callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("oncanplaythrough")>] member this.oncanplaythrough (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.canplaythrough callback |> this.AddProp
    [<CustomOperation("oncanplaythroughAsync")>] member this.oncanplaythroughAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.canplaythrough callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("oncuechange")>] member this.oncuechange (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.cuechange callback |> this.AddProp
    [<CustomOperation("oncuechangeAsync")>] member this.oncuechangeAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.cuechange callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondurationchange")>] member this.ondurationchange (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.durationchange callback |> this.AddProp
    [<CustomOperation("ondurationchangeAsync")>] member this.ondurationchangeAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.durationchange callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onemptied")>] member this.onemptied (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.emptied callback |> this.AddProp
    [<CustomOperation("onemptiedAsync")>] member this.onemptiedAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.emptied callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpause")>] member this.onpause (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.pause callback |> this.AddProp
    [<CustomOperation("onpauseAsync")>] member this.onpauseAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.pause callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onplay")>] member this.onplay (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.play callback |> this.AddProp
    [<CustomOperation("onplayAsync")>] member this.onplayAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.play callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onplaying")>] member this.onplaying (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.playing callback |> this.AddProp
    [<CustomOperation("onplayingAsync")>] member this.onplayingAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.playing callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onratechange")>] member this.onratechange (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.ratechange callback |> this.AddProp
    [<CustomOperation("onratechangeAsync")>] member this.onratechangeAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.ratechange callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onseeked")>] member this.onseeked (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.seeked callback |> this.AddProp
    [<CustomOperation("onseekedAsync")>] member this.onseekedAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.seeked callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onseeking")>] member this.onseeking (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.seeking callback |> this.AddProp
    [<CustomOperation("onseekingAsync")>] member this.onseekingAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.seeking callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onstalled")>] member this.onstalled (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.stalled callback |> this.AddProp
    [<CustomOperation("onstalledAsync")>] member this.onstalledAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.stalled callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onstop")>] member this.onstop (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.stop callback |> this.AddProp
    [<CustomOperation("onstopAsync")>] member this.onstopAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.stop callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onsuspend")>] member this.onsuspend (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.suspend callback |> this.AddProp
    [<CustomOperation("onsuspendAsync")>] member this.onsuspendAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.suspend callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ontimeupdate")>] member this.ontimeupdate (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.timeupdate callback |> this.AddProp
    [<CustomOperation("ontimeupdateAsync")>] member this.ontimeupdateAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.timeupdate callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onvolumechange")>] member this.onvolumechange (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.volumechange callback |> this.AddProp
    [<CustomOperation("onvolumechangeAsync")>] member this.onvolumechangeAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.volumechange callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onwaiting")>] member this.onwaiting (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.waiting callback |> this.AddProp
    [<CustomOperation("onwaitingAsync")>] member this.onwaitingAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.waiting callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onloadstart")>] member this.onloadstart (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> unit) = evt.loadstart callback |> this.AddProp
    [<CustomOperation("onloadstartAsync")>] member this.onloadstartAsync (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> Async<unit>) = evt.async.loadstart callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ontimeout")>] member this.ontimeout (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> unit) = evt.timeout callback |> this.AddProp
    [<CustomOperation("ontimeoutAsync")>] member this.ontimeoutAsync (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> Async<unit>) = evt.async.timeout callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onabort")>] member this.onabort (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> unit) = evt.abort callback |> this.AddProp
    [<CustomOperation("onabortAsync")>] member this.onabortAsync (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> Async<unit>) = evt.async.abort callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onload")>] member this.onload (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> unit) = evt.load callback |> this.AddProp
    [<CustomOperation("onloadAsync")>] member this.onloadAsync (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> Async<unit>) = evt.async.load callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onloadend")>] member this.onloadend (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> unit) = evt.loadend callback |> this.AddProp
    [<CustomOperation("onloadendAsync")>] member this.onloadendAsync (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> Async<unit>) = evt.async.loadend callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onprogress")>] member this.onprogress (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> unit) = evt.progress callback |> this.AddProp
    [<CustomOperation("onprogressAsync")>] member this.onprogressAsync (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> Async<unit>) = evt.async.progress callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onerror")>] member this.onerror (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> unit) = evt.error callback |> this.AddProp
    [<CustomOperation("onerrorAsync")>] member this.onerrorAsync (_: FunBlazorContext<'Component>, callback: ProgressEventArgs -> Async<unit>) = evt.async.error callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onactivate")>] member this.onactivate (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.activate callback |> this.AddProp
    [<CustomOperation("onactivateAsync")>] member this.onactivateAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.activate callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onbeforeactivate")>] member this.onbeforeactivate (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.beforeactivate callback |> this.AddProp
    [<CustomOperation("onbeforeactivateAsync")>] member this.onbeforeactivateAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.beforeactivate callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onbeforedeactivate")>] member this.onbeforedeactivate (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.beforedeactivate callback |> this.AddProp
    [<CustomOperation("onbeforedeactivateAsync")>] member this.onbeforedeactivateAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.beforedeactivate callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("ondeactivate")>] member this.ondeactivate (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.deactivate callback |> this.AddProp
    [<CustomOperation("ondeactivateAsync")>] member this.ondeactivateAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.deactivate callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onended")>] member this.onended (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.ended callback |> this.AddProp
    [<CustomOperation("onendedAsync")>] member this.onendedAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.ended callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onfullscreenchange")>] member this.onfullscreenchange (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.fullscreenchange callback |> this.AddProp
    [<CustomOperation("onfullscreenchangeAsync")>] member this.onfullscreenchangeAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.fullscreenchange callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onfullscreenerror")>] member this.onfullscreenerror (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.fullscreenerror callback |> this.AddProp
    [<CustomOperation("onfullscreenerrorAsync")>] member this.onfullscreenerrorAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.fullscreenerror callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onloadeddata")>] member this.onloadeddata (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.loadeddata callback |> this.AddProp
    [<CustomOperation("onloadeddataAsync")>] member this.onloadeddataAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.loadeddata callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onloadedmetadata")>] member this.onloadedmetadata (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.loadedmetadata callback |> this.AddProp
    [<CustomOperation("onloadedmetadataAsync")>] member this.onloadedmetadataAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.loadedmetadata callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointerlockchange")>] member this.onpointerlockchange (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.pointerlockchange callback |> this.AddProp
    [<CustomOperation("onpointerlockchangeAsync")>] member this.onpointerlockchangeAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.pointerlockchange callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onpointerlockerror")>] member this.onpointerlockerror (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.pointerlockerror callback |> this.AddProp
    [<CustomOperation("onpointerlockerrorAsync")>] member this.onpointerlockerrorAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.pointerlockerror callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onreadystatechange")>] member this.onreadystatechange (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.readystatechange callback |> this.AddProp
    [<CustomOperation("onreadystatechangeAsync")>] member this.onreadystatechangeAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.readystatechange callback |> BoleroAttr |> this.AddProp
    [<CustomOperation("onscroll")>] member this.onscroll (_: FunBlazorContext<'Component>, callback: EventArgs -> unit) = evt.scroll callback |> this.AddProp
    [<CustomOperation("onscrollAsync")>] member this.onscrollAsync (_: FunBlazorContext<'Component>, callback: EventArgs -> Async<unit>) = evt.async.scroll callback |> BoleroAttr |> this.AddProp
    

type FakeComponent =
    interface IComponent with
        member _.Attach _ = ()
        member _.SetParametersAsync _ = Task.FromResult() :> Task

[<AbstractClass>]
type FunBlazorNodeBuilder () =
    inherit FunBlazorContextWithAttrs<FakeComponent>()

    abstract MakeNode: Bolero.Attr list * Bolero.Node list -> Bolero.Node
        
    interface IFunBlazorNode with
        member this.Node () = 
            let nodes, attrs = FunBlazorNode.GetBoleroNodesAndAttrs (this.Props())
            this.MakeNode (attrs, nodes) |> BoleroNode

    

namespace Fun.Blazor.DslCE

open System
open Bolero
open Bolero.Html
open Fun.Blazor


[<AutoOpen>]
module elt =
    
    type ABuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ABuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ABuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ABuilder()
        override this.MakeNode (x, y) = Html.a x y

    type a = ABuilder


    type AbbrBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = AbbrBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = AbbrBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = AbbrBuilder()
        override this.MakeNode (x, y) = Html.abbr x y

    type abbr = AbbrBuilder


    type AcronymBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = AcronymBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = AcronymBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = AcronymBuilder()
        override this.MakeNode (x, y) = Html.acronym x y

    type acronym = AcronymBuilder


    type AddressBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = AddressBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = AddressBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = AddressBuilder()
        override this.MakeNode (x, y) = Html.address x y

    type address = AddressBuilder


    type AppletBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = AppletBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = AppletBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = AppletBuilder()
        override this.MakeNode (x, y) = Html.applet x y

    type applet = AppletBuilder


    type AreaBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = AreaBuilder()
        override this.MakeNode (x, y) = Html.area x

    type area = AreaBuilder


    type ArticleBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ArticleBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ArticleBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ArticleBuilder()
        override this.MakeNode (x, y) = Html.article x y

    type article = ArticleBuilder


    type AsideBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = AsideBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = AsideBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = AsideBuilder()
        override this.MakeNode (x, y) = Html.aside x y

    type aside = AsideBuilder


    type AudioBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = AudioBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = AudioBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = AudioBuilder()
        override this.MakeNode (x, y) = Html.audio x y

    type audio = AudioBuilder


    type BBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = BBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = BBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = BBuilder()
        override this.MakeNode (x, y) = Html.b x y

    type b = BBuilder


    type BaseBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = BaseBuilder()
        override this.MakeNode (x, y) = Html.``base`` x

    type base' = BaseBuilder


    type BasefontBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = BasefontBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = BasefontBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = BasefontBuilder()
        override this.MakeNode (x, y) = Html.basefont x y

    type basefont = BasefontBuilder


    type BdiBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = BdiBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = BdiBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = BdiBuilder()
        override this.MakeNode (x, y) = Html.bdi x y

    type bdi = BdiBuilder


    type BdoBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = BdoBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = BdoBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = BdoBuilder()
        override this.MakeNode (x, y) = Html.bdo x y

    type bdo = BdoBuilder


    type BigBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = BigBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = BigBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = BigBuilder()
        override this.MakeNode (x, y) = Html.big x y

    type big = BigBuilder


    type BlockquoteBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = BlockquoteBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = BlockquoteBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = BlockquoteBuilder()
        override this.MakeNode (x, y) = Html.blockquote x y

    type blockquote = BlockquoteBuilder


    type BodyBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = BodyBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = BodyBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = BodyBuilder()
        override this.MakeNode (x, y) = Html.body x y

    type body = BodyBuilder


    type BrBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = BrBuilder()
        override this.MakeNode (x, y) = Html.br x

    type br = BrBuilder


    type ButtonBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ButtonBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ButtonBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ButtonBuilder()
        override this.MakeNode (x, y) = Html.button x y

    type button = ButtonBuilder


    type CanvasBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = CanvasBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = CanvasBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = CanvasBuilder()
        override this.MakeNode (x, y) = Html.canvas x y

    type canvas = CanvasBuilder


    type CaptionBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = CaptionBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = CaptionBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = CaptionBuilder()
        override this.MakeNode (x, y) = Html.caption x y

    type caption = CaptionBuilder


    type CenterBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = CenterBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = CenterBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = CenterBuilder()
        override this.MakeNode (x, y) = Html.center x y

    type center = CenterBuilder


    type CiteBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = CiteBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = CiteBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = CiteBuilder()
        override this.MakeNode (x, y) = Html.cite x y

    type cite = CiteBuilder


    type CodeBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = CodeBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = CodeBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = CodeBuilder()
        override this.MakeNode (x, y) = Html.code x y

    type code = CodeBuilder


    type ColBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = ColBuilder()
        override this.MakeNode (x, y) = Html.col x

    type col = ColBuilder


    type ColgroupBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ColgroupBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ColgroupBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ColgroupBuilder()
        override this.MakeNode (x, y) = Html.colgroup x y

    type colgroup = ColgroupBuilder


    type ContentBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ContentBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ContentBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ContentBuilder()
        override this.MakeNode (x, y) = Html.content x y

    type content = ContentBuilder


    type DataBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DataBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DataBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DataBuilder()
        override this.MakeNode (x, y) = Html.data x y

    type data = DataBuilder


    type DatalistBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DatalistBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DatalistBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DatalistBuilder()
        override this.MakeNode (x, y) = Html.datalist x y

    type datalist = DatalistBuilder


    type DdBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DdBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DdBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DdBuilder()
        override this.MakeNode (x, y) = Html.dd x y

    type dd = DdBuilder


    type DelBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DelBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DelBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DelBuilder()
        override this.MakeNode (x, y) = Html.del x y

    type del = DelBuilder


    type DetailsBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DetailsBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DetailsBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DetailsBuilder()
        override this.MakeNode (x, y) = Html.details x y

    type details = DetailsBuilder


    type DfnBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DfnBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DfnBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DfnBuilder()
        override this.MakeNode (x, y) = Html.dfn x y

    type dfn = DfnBuilder


    type DialogBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DialogBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DialogBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DialogBuilder()
        override this.MakeNode (x, y) = Html.dialog x y

    type dialog = DialogBuilder


    type DirBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DirBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DirBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DirBuilder()
        override this.MakeNode (x, y) = Html.dir x y

    type dir = DirBuilder


    type DivBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DivBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DivBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DivBuilder()
        override this.MakeNode (x, y) = Html.div x y

    type div = DivBuilder


    type DlBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DlBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DlBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DlBuilder()
        override this.MakeNode (x, y) = Html.dl x y

    type dl = DlBuilder


    type DtBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = DtBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = DtBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = DtBuilder()
        override this.MakeNode (x, y) = Html.dt x y

    type dt = DtBuilder


    type ElementBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ElementBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ElementBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ElementBuilder()
        override this.MakeNode (x, y) = Html.element x y

    type element = ElementBuilder


    type EmBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = EmBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = EmBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = EmBuilder()
        override this.MakeNode (x, y) = Html.em x y

    type em = EmBuilder


    type EmbedBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = EmbedBuilder()
        override this.MakeNode (x, y) = Html.embed x

    type embed = EmbedBuilder


    type FieldsetBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = FieldsetBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = FieldsetBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = FieldsetBuilder()
        override this.MakeNode (x, y) = Html.fieldset x y

    type fieldset = FieldsetBuilder


    type FigcaptionBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = FigcaptionBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = FigcaptionBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = FigcaptionBuilder()
        override this.MakeNode (x, y) = Html.figcaption x y

    type figcaption = FigcaptionBuilder


    type FigureBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = FigureBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = FigureBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = FigureBuilder()
        override this.MakeNode (x, y) = Html.figure x y

    type figure = FigureBuilder


    type FontBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = FontBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = FontBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = FontBuilder()
        override this.MakeNode (x, y) = Html.font x y

    type font = FontBuilder


    type FooterBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = FooterBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = FooterBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = FooterBuilder()
        override this.MakeNode (x, y) = Html.footer x y

    type footer = FooterBuilder


    type FormBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = FormBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = FormBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = FormBuilder()
        override this.MakeNode (x, y) = Html.form x y

    type form = FormBuilder


    type FrameBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = FrameBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = FrameBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = FrameBuilder()
        override this.MakeNode (x, y) = Html.frame x y

    type frame = FrameBuilder


    type FramesetBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = FramesetBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = FramesetBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = FramesetBuilder()
        override this.MakeNode (x, y) = Html.frameset x y

    type frameset = FramesetBuilder


    type H1Builder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = H1Builder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = H1Builder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = H1Builder()
        override this.MakeNode (x, y) = Html.h1 x y

    type h1 = H1Builder


    type H2Builder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = H2Builder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = H2Builder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = H2Builder()
        override this.MakeNode (x, y) = Html.h2 x y

    type h2 = H2Builder


    type H3Builder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = H3Builder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = H3Builder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = H3Builder()
        override this.MakeNode (x, y) = Html.h3 x y

    type h3 = H3Builder


    type H4Builder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = H4Builder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = H4Builder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = H4Builder()
        override this.MakeNode (x, y) = Html.h4 x y

    type h4 = H4Builder


    type H5Builder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = H5Builder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = H5Builder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = H5Builder()
        override this.MakeNode (x, y) = Html.h5 x y

    type h5 = H5Builder


    type H6Builder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = H6Builder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = H6Builder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = H6Builder()
        override this.MakeNode (x, y) = Html.h6 x y

    type h6 = H6Builder


    type HeadBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = HeadBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = HeadBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = HeadBuilder()
        override this.MakeNode (x, y) = Html.head x y

    type head = HeadBuilder


    type HeaderBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = HeaderBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = HeaderBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = HeaderBuilder()
        override this.MakeNode (x, y) = Html.header x y

    type header = HeaderBuilder


    type HrBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = HrBuilder()
        override this.MakeNode (x, y) = Html.hr x

    type hr = HrBuilder


    type HtmlBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = HtmlBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = HtmlBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = HtmlBuilder()
        override this.MakeNode (x, y) = Html.html x y

    type html' = HtmlBuilder


    type IBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = IBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = IBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = IBuilder()
        override this.MakeNode (x, y) = Html.i x y

    type i = IBuilder


    type IframeBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = IframeBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = IframeBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = IframeBuilder()
        override this.MakeNode (x, y) = Html.iframe x y

    type iframe = IframeBuilder


    type ImgBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = ImgBuilder()
        override this.MakeNode (x, y) = Html.img x

    type img = ImgBuilder


    type InputBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = InputBuilder()
        override this.MakeNode (x, y) = Html.input x

    type input = InputBuilder


    type InsBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = InsBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = InsBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = InsBuilder()
        override this.MakeNode (x, y) = Html.ins x y

    type ins = InsBuilder


    type KbdBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = KbdBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = KbdBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = KbdBuilder()
        override this.MakeNode (x, y) = Html.kbd x y

    type kbd = KbdBuilder


    type LabelBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = LabelBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = LabelBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = LabelBuilder()
        override this.MakeNode (x, y) = Html.label x y

    type label = LabelBuilder


    type LegendBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = LegendBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = LegendBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = LegendBuilder()
        override this.MakeNode (x, y) = Html.legend x y

    type legend = LegendBuilder


    type LiBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = LiBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = LiBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = LiBuilder()
        override this.MakeNode (x, y) = Html.li x y

    type li = LiBuilder


    type LinkBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = LinkBuilder()
        override this.MakeNode (x, y) = Html.link x

    type link = LinkBuilder


    type MainBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = MainBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = MainBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = MainBuilder()
        override this.MakeNode (x, y) = Html.main x y

    type main = MainBuilder


    type MapBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = MapBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = MapBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = MapBuilder()
        override this.MakeNode (x, y) = Html.map x y

    type map = MapBuilder


    type MarkBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = MarkBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = MarkBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = MarkBuilder()
        override this.MakeNode (x, y) = Html.mark x y

    type mark = MarkBuilder


    type MenuBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = MenuBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = MenuBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = MenuBuilder()
        override this.MakeNode (x, y) = Html.menu x y

    type menu = MenuBuilder


    type MenuitemBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = MenuitemBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = MenuitemBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = MenuitemBuilder()
        override this.MakeNode (x, y) = Html.menuitem x y

    type menuitem = MenuitemBuilder


    type MetaBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = MetaBuilder()
        override this.MakeNode (x, y) = Html.meta x

    type meta = MetaBuilder


    type MeterBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = MeterBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = MeterBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = MeterBuilder()
        override this.MakeNode (x, y) = Html.meter x y

    type meter = MeterBuilder


    type NavBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = NavBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = NavBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = NavBuilder()
        override this.MakeNode (x, y) = Html.nav x y

    type nav = NavBuilder


    type NoembedBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = NoembedBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = NoembedBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = NoembedBuilder()
        override this.MakeNode (x, y) = Html.noembed x y

    type noembed = NoembedBuilder


    type NoframesBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = NoframesBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = NoframesBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = NoframesBuilder()
        override this.MakeNode (x, y) = Html.noframes x y

    type noframes = NoframesBuilder


    type NoscriptBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = NoscriptBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = NoscriptBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = NoscriptBuilder()
        override this.MakeNode (x, y) = Html.noscript x y

    type noscript = NoscriptBuilder


    type ObjectBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ObjectBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ObjectBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ObjectBuilder()
        override this.MakeNode (x, y) = Html.object x y

    type object = ObjectBuilder


    type OlBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = OlBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = OlBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = OlBuilder()
        override this.MakeNode (x, y) = Html.ol x y

    type ol = OlBuilder


    type OptgroupBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = OptgroupBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = OptgroupBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = OptgroupBuilder()
        override this.MakeNode (x, y) = Html.optgroup x y

    type optgroup = OptgroupBuilder


    type OptionBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = OptionBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = OptionBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = OptionBuilder()
        override this.MakeNode (x, y) = Html.option x y

    type option = OptionBuilder


    type OutputBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = OutputBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = OutputBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = OutputBuilder()
        override this.MakeNode (x, y) = Html.output x y

    type output = OutputBuilder


    type PBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = PBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = PBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = PBuilder()
        override this.MakeNode (x, y) = Html.p x y

    type p = PBuilder


    type ParamBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = ParamBuilder()
        override this.MakeNode (x, y) = Html.param x

    type param = ParamBuilder


    type PictureBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = PictureBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = PictureBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = PictureBuilder()
        override this.MakeNode (x, y) = Html.picture x y

    type picture = PictureBuilder


    type PreBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = PreBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = PreBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = PreBuilder()
        override this.MakeNode (x, y) = Html.pre x y

    type pre = PreBuilder


    type ProgressBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ProgressBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ProgressBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ProgressBuilder()
        override this.MakeNode (x, y) = Html.progress x y

    type progress = ProgressBuilder


    type QBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = QBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = QBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = QBuilder()
        override this.MakeNode (x, y) = Html.q x y

    type q = QBuilder


    type RbBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = RbBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = RbBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = RbBuilder()
        override this.MakeNode (x, y) = Html.rb x y

    type rb = RbBuilder


    type RpBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = RpBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = RpBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = RpBuilder()
        override this.MakeNode (x, y) = Html.rp x y

    type rp = RpBuilder


    type RtBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = RtBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = RtBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = RtBuilder()
        override this.MakeNode (x, y) = Html.rt x y

    type rt = RtBuilder


    type RtcBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = RtcBuilder()
        override this.MakeNode (x, y) = Html.rtc x

    type rtc = RtcBuilder


    type RubyBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = RubyBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = RubyBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = RubyBuilder()
        override this.MakeNode (x, y) = Html.ruby x y

    type ruby = RubyBuilder


    type SBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SBuilder()
        override this.MakeNode (x, y) = Html.s x y

    type s = SBuilder


    type SampBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SampBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SampBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SampBuilder()
        override this.MakeNode (x, y) = Html.samp x y

    type samp = SampBuilder


    type ScriptBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ScriptBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ScriptBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ScriptBuilder()
        override this.MakeNode (x, y) = Html.script x y

    type script = ScriptBuilder


    type SectionBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SectionBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SectionBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SectionBuilder()
        override this.MakeNode (x, y) = Html.section x y

    type section = SectionBuilder


    type SelectBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SelectBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SelectBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SelectBuilder()
        override this.MakeNode (x, y) = Html.select x y

    type select = SelectBuilder


    type ShadowBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ShadowBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ShadowBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ShadowBuilder()
        override this.MakeNode (x, y) = Html.shadow x y

    type shadow = ShadowBuilder


    type SlotBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SlotBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SlotBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SlotBuilder()
        override this.MakeNode (x, y) = Html.slot x y

    type slot = SlotBuilder


    type SmallBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SmallBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SmallBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SmallBuilder()
        override this.MakeNode (x, y) = Html.small x y

    type small = SmallBuilder


    type SourceBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = SourceBuilder()
        override this.MakeNode (x, y) = Html.source x

    type source = SourceBuilder


    type SpanBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SpanBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SpanBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SpanBuilder()
        override this.MakeNode (x, y) = Html.span x y

    type span = SpanBuilder


    type StrikeBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = StrikeBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = StrikeBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = StrikeBuilder()
        override this.MakeNode (x, y) = Html.strike x y

    type strike = StrikeBuilder


    type StrongBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = StrongBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = StrongBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = StrongBuilder()
        override this.MakeNode (x, y) = Html.strong x y

    type strong = StrongBuilder


    type StyleBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = StyleBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = StyleBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = StyleBuilder()
        override this.MakeNode (x, y) = Html.style x y

    type style' = StyleBuilder


    type SubBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SubBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SubBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SubBuilder()
        override this.MakeNode (x, y) = Html.sub x y

    type sub = SubBuilder


    type SummaryBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SummaryBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SummaryBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SummaryBuilder()
        override this.MakeNode (x, y) = Html.summary x y

    type summary = SummaryBuilder


    type SupBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SupBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SupBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SupBuilder()
        override this.MakeNode (x, y) = Html.sup x y

    type sup = SupBuilder


    type SvgBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = SvgBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = SvgBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = SvgBuilder()
        override this.MakeNode (x, y) = Html.svg x y

    type svg = SvgBuilder


    type TableBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TableBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TableBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TableBuilder()
        override this.MakeNode (x, y) = Html.table x y

    type table = TableBuilder


    type TbodyBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TbodyBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TbodyBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TbodyBuilder()
        override this.MakeNode (x, y) = Html.tbody x y

    type tbody = TbodyBuilder


    type TdBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TdBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TdBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TdBuilder()
        override this.MakeNode (x, y) = Html.td x y

    type td = TdBuilder


    type TemplateBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TemplateBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TemplateBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TemplateBuilder()
        override this.MakeNode (x, y) = Html.template x y

    type template = TemplateBuilder


    type TextareaBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TextareaBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TextareaBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TextareaBuilder()
        override this.MakeNode (x, y) = Html.textarea x y

    type textarea = TextareaBuilder


    type TfootBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TfootBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TfootBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TfootBuilder()
        override this.MakeNode (x, y) = Html.tfoot x y

    type tfoot = TfootBuilder


    type ThBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = ThBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = ThBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = ThBuilder()
        override this.MakeNode (x, y) = Html.th x y

    type th = ThBuilder


    type TheadBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TheadBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TheadBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TheadBuilder()
        override this.MakeNode (x, y) = Html.thead x y

    type thead = TheadBuilder


    type TimeBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TimeBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TimeBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TimeBuilder()
        override this.MakeNode (x, y) = Html.time x y

    type time = TimeBuilder


    type TitleBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TitleBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TitleBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TitleBuilder()
        override this.MakeNode (x, y) = Html.title x y

    type title = TitleBuilder


    type TrBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TrBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TrBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TrBuilder()
        override this.MakeNode (x, y) = Html.tr x y

    type tr = TrBuilder


    type TrackBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = TrackBuilder()
        override this.MakeNode (x, y) = Html.track x

    type track = TrackBuilder


    type TtBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = TtBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = TtBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = TtBuilder()
        override this.MakeNode (x, y) = Html.tt x y

    type tt = TtBuilder


    type UBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = UBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = UBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = UBuilder()
        override this.MakeNode (x, y) = Html.u x y

    type u = UBuilder


    type UlBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = UlBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = UlBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = UlBuilder()
        override this.MakeNode (x, y) = Html.ul x y

    type ul = UlBuilder


    type VarBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = VarBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = VarBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = VarBuilder()
        override this.MakeNode (x, y) = Html.var x y

    type var = VarBuilder


    type VideoBuilder () =
        inherit FunBlazorNodeBuilder()
        new (x: string) as this = VideoBuilder() then Fragment [ html.text x ] |> this.AddProp |> ignore
        new (x: IFunBlazorNode list) as this = VideoBuilder() then Fragment x |> this.AddProp |> ignore       
        member this.Yield _ = VideoBuilder()
        override this.MakeNode (x, y) = Html.video x y

    type video = VideoBuilder


    type WbrBuilder () =
        inherit FunBlazorNodeBuilder()
               
        member this.Yield _ = WbrBuilder()
        override this.MakeNode (x, y) = Html.wbr x

    type wbr = WbrBuilder



[<AutoOpen>]
module dsl =
    type WatchBuilder<'T>() =
        inherit FunBlazorContext<StoreComponent<'T>>()
        
        member this.Yield _ = WatchBuilder<'T>()

        [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'Component>, x: 'T) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
        [<CustomOperation("Store")>] member this.Store (_: FunBlazorContext<'Component>, x: IObservable<'T>) = "Store" => x |> BoleroAttr |> this.AddProp
        [<CustomOperation("RenderFn")>] member this.RenderFn (_: FunBlazorContext<'Component>, x: 'T -> IFunBlazorNode) = "RenderFn" => x |> BoleroAttr |> this.AddProp

    let watch<'T> = WatchBuilder<'T>()

