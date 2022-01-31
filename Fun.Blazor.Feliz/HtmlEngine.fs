[<AutoOpen>]
module Fun.Blazor.HtmlEngine

open Fun.Blazor


type html with

    /// Create a custom element
    ///
    /// You generally shouldn't need to use this, if you notice an element missing please submit an issue.
    static member inline custom(key: string, children: seq<NodeRenderFragment>) =
        EltWithChildBuilder key { yield! children }

    /// The empty element, renders nothing on screen
    static member inline none = emptyNode

    static member inline script (x: string) = script { src x }

    static member inline a(children: NodeRenderFragment seq) = EltWithChildBuilder "a" { yield! children }

    static member inline abbr(v: float) = EltWithChildBuilder "abbr" { v }
    static member inline abbr(v: int) = EltWithChildBuilder "abbr" { v }
    static member inline abbr(v: NodeRenderFragment) = EltWithChildBuilder "abbr" { v }
    static member inline abbr(v: string) = EltWithChildBuilder "abbr" { v }
    static member inline abbr(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "abbr" { html.mergeAttrs attrs }
    static member inline abbr(children: NodeRenderFragment seq) = EltWithChildBuilder "abbr" { yield! children }

    static member inline address(v: float) = EltWithChildBuilder "address" { v }
    static member inline address(v: int) = EltWithChildBuilder "address" { v }
    static member inline address(v: NodeRenderFragment) = EltWithChildBuilder "address" { v }
    static member inline address(v: string) = EltWithChildBuilder "address" { v }
    static member inline address(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "address" { html.mergeAttrs attrs }
    static member inline address(children: NodeRenderFragment seq) = EltWithChildBuilder "address" { yield! children }

    static member inline anchor(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "anchor" { html.mergeAttrs attrs }
    static member inline anchor(children: NodeRenderFragment seq) = EltWithChildBuilder "a" { yield! children }

    static member inline area(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "area" { html.mergeAttrs attrs }
    static member inline area(children: NodeRenderFragment seq) = EltWithChildBuilder "area" { yield! children }

    static member inline article(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "article" { html.mergeAttrs attrs }
    static member inline article(children: NodeRenderFragment seq) = EltWithChildBuilder "article" { yield! children }

    static member inline aside(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "aside" { html.mergeAttrs attrs }
    static member inline aside(children: NodeRenderFragment seq) = EltWithChildBuilder "aside" { yield! children }

    static member inline audio(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "audio" { html.mergeAttrs attrs }
    static member inline audio(children: NodeRenderFragment seq) = EltWithChildBuilder "audio" { yield! children }

    static member inline b(v: float) = EltWithChildBuilder "b" { v }
    static member inline b(v: int) = EltWithChildBuilder "b" { v }
    static member inline b(v: NodeRenderFragment) = EltWithChildBuilder "b" { v }
    static member inline b(v: string) = EltWithChildBuilder "b" { v }
    static member inline b(attrs: AttrRenderFragment seq) = EltWithChildBuilder "b" { html.mergeAttrs attrs }
    static member inline b(children: NodeRenderFragment seq) = EltWithChildBuilder "b" { yield! children }

    static member inline base'(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "base'" { html.mergeAttrs attrs }
    static member inline base'(children: NodeRenderFragment seq) = EltWithChildBuilder "base" { yield! children }

    static member inline bdi(v: float) = EltWithChildBuilder "bdi" { v }
    static member inline bdi(v: int) = EltWithChildBuilder "bdi" { v }
    static member inline bdi(v: NodeRenderFragment) = EltWithChildBuilder "bdi" { v }
    static member inline bdi(v: string) = EltWithChildBuilder "bdi" { v }
    static member inline bdi(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "bdi" { html.mergeAttrs attrs }
    static member inline bdi(children: NodeRenderFragment seq) = EltWithChildBuilder "bdi" { yield! children }

    static member inline bdo(v: float) = EltWithChildBuilder "bdo" { v }
    static member inline bdo(v: int) = EltWithChildBuilder "bdo" { v }
    static member inline bdo(v: NodeRenderFragment) = EltWithChildBuilder "bdo" { v }
    static member inline bdo(v: string) = EltWithChildBuilder "bdo" { v }
    static member inline bdo(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "bdo" { html.mergeAttrs attrs }
    static member inline bdo(children: NodeRenderFragment seq) = EltWithChildBuilder "bdo" { yield! children }

    static member inline blockquote(v: float) = EltWithChildBuilder "blockquote" { v }
    static member inline blockquote(v: int) = EltWithChildBuilder "blockquote" { v }
    static member inline blockquote(v: NodeRenderFragment) = EltWithChildBuilder "blockquote" { v }
    static member inline blockquote(v: string) = EltWithChildBuilder "blockquote" { v }
    static member inline blockquote(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "blockquote" { html.mergeAttrs attrs }
    static member inline blockquote(children: NodeRenderFragment seq) =
        EltWithChildBuilder "blockquote" { yield! children }

    static member inline body(v: float) = EltWithChildBuilder "body" { v }
    static member inline body(v: int) = EltWithChildBuilder "body" { v }
    static member inline body(v: NodeRenderFragment) = EltWithChildBuilder "body" { v }
    static member inline body(v: string) = EltWithChildBuilder "body" { v }
    static member inline body(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "body" { html.mergeAttrs attrs }
    static member inline body(children: NodeRenderFragment seq) = EltWithChildBuilder "body" { yield! children }

    static member inline br(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "br" { html.mergeAttrs attrs }
    static member inline br(children: NodeRenderFragment seq) = EltWithChildBuilder "br" { yield! children }

    static member inline button(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "button" { html.mergeAttrs attrs }
    static member inline button(children: NodeRenderFragment seq) = EltWithChildBuilder "button" { yield! children }

    static member inline canvas(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "canvas" { html.mergeAttrs attrs }
    static member inline canvas(children: NodeRenderFragment seq) = EltWithChildBuilder "canvas" { yield! children }

    static member inline caption(v: float) = EltWithChildBuilder "caption" { v }
    static member inline caption(v: int) = EltWithChildBuilder "caption" { v }
    static member inline caption(v: NodeRenderFragment) = EltWithChildBuilder "caption" { v }
    static member inline caption(v: string) = EltWithChildBuilder "caption" { v }
    static member inline caption(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "caption" { html.mergeAttrs attrs }
    static member inline caption(children: NodeRenderFragment seq) = EltWithChildBuilder "caption" { yield! children }

    static member inline cite(v: float) = EltWithChildBuilder "cite" { v }
    static member inline cite(v: int) = EltWithChildBuilder "cite" { v }
    static member inline cite(v: NodeRenderFragment) = EltWithChildBuilder "cite" { v }
    static member inline cite(v: string) = EltWithChildBuilder "cite" { v }
    static member inline cite(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "cite" { html.mergeAttrs attrs }
    static member inline cite(children: NodeRenderFragment seq) = EltWithChildBuilder "cite" { yield! children }

    // static member inline code (v: bool) = EltWithChildBuilder "code" value
    static member inline code(v: float) = EltWithChildBuilder "code" { v }
    static member inline code(v: int) = EltWithChildBuilder "code" { v }
    static member inline code(v: NodeRenderFragment) = EltWithChildBuilder "code" { v }
    static member inline code(v: string) = EltWithChildBuilder "code" { v }
    static member inline code(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "code" { html.mergeAttrs attrs }
    static member inline code(children: NodeRenderFragment seq) = EltWithChildBuilder "code" { yield! children }

    static member inline col(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "col" { html.mergeAttrs attrs }
    static member inline col(children: NodeRenderFragment seq) = EltWithChildBuilder "col" { yield! children }

    static member inline colgroup(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "colgroup" { html.mergeAttrs attrs }
    static member inline colgroup(children: NodeRenderFragment seq) =
        EltWithChildBuilder "colgroup" { yield! children }

    static member inline data(v: float) = EltWithChildBuilder "data" { v }
    static member inline data(v: int) = EltWithChildBuilder "data" { v }
    static member inline data(v: NodeRenderFragment) = EltWithChildBuilder "data" { v }
    static member inline data(v: string) = EltWithChildBuilder "data" { v }
    static member inline data(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "data" { html.mergeAttrs attrs }
    static member inline data(children: NodeRenderFragment seq) = EltWithChildBuilder "data" { yield! children }

    static member inline datalist(v: float) = EltWithChildBuilder "datalist" { v }
    static member inline datalist(v: int) = EltWithChildBuilder "datalist" { v }
    static member inline datalist(v: NodeRenderFragment) = EltWithChildBuilder "datalist" { v }
    static member inline datalist(v: string) = EltWithChildBuilder "datalist" { v }
    static member inline datalist(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "datalist" { html.mergeAttrs attrs }
    static member inline datalist(children: NodeRenderFragment seq) =
        EltWithChildBuilder "datalist" { yield! children }

    static member inline dd(v: float) = EltWithChildBuilder "dd" { v }
    static member inline dd(v: int) = EltWithChildBuilder "dd" { v }
    static member inline dd(v: NodeRenderFragment) = EltWithChildBuilder "dd" { v }
    static member inline dd(v: string) = EltWithChildBuilder "dd" { v }
    static member inline dd(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "dd" { html.mergeAttrs attrs }
    static member inline dd(children: NodeRenderFragment seq) = EltWithChildBuilder "dd" { yield! children }

    static member inline del(v: float) = EltWithChildBuilder "del" { v }
    static member inline del(v: int) = EltWithChildBuilder "del" { v }
    static member inline del(v: NodeRenderFragment) = EltWithChildBuilder "del" { v }
    static member inline del(v: string) = EltWithChildBuilder "del" { v }
    static member inline del(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "del" { html.mergeAttrs attrs }
    static member inline del(children: NodeRenderFragment seq) = EltWithChildBuilder "del" { yield! children }

    static member inline details(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "details" { html.mergeAttrs attrs }
    static member inline details(children: NodeRenderFragment seq) = EltWithChildBuilder "details" { yield! children }

    static member inline dfn(v: float) = EltWithChildBuilder "dfn" { v }
    static member inline dfn(v: int) = EltWithChildBuilder "dfn" { v }
    static member inline dfn(v: NodeRenderFragment) = EltWithChildBuilder "dfn" { v }
    static member inline dfn(v: string) = EltWithChildBuilder "dfn" { v }
    static member inline dfn(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "dfn" { html.mergeAttrs attrs }
    static member inline dfn(children: NodeRenderFragment seq) = EltWithChildBuilder "dfn" { yield! children }

    static member inline dialog(v: float) = EltWithChildBuilder "dialog" { v }
    static member inline dialog(v: int) = EltWithChildBuilder "dialog" { v }
    static member inline dialog(v: NodeRenderFragment) = EltWithChildBuilder "dialog" { v }
    static member inline dialog(v: string) = EltWithChildBuilder "dialog" { v }
    static member inline dialog(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "dialog" { html.mergeAttrs attrs }
    static member inline dialog(children: NodeRenderFragment seq) = EltWithChildBuilder "dialog" { yield! children }

    static member inline div(v: float) = EltWithChildBuilder "div" { v }
    static member inline div(v: int) = EltWithChildBuilder "div" { v }
    static member inline div(v: NodeRenderFragment) = EltWithChildBuilder "div" { v }
    static member inline div(v: string) = EltWithChildBuilder "div" { v }
    /// The `<div>` tag defines a division or a section in an HTML document
    static member inline div(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "div" { html.mergeAttrs attrs }
    static member inline div(children: NodeRenderFragment seq) = EltWithChildBuilder "div" { yield! children }

    static member inline dl(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "dl" { html.mergeAttrs attrs }
    static member inline dl(children: NodeRenderFragment seq) = EltWithChildBuilder "dl" { yield! children }

    static member inline dt(v: float) = EltWithChildBuilder "dt" { v }
    static member inline dt(v: int) = EltWithChildBuilder "dt" { v }
    static member inline dt(v: NodeRenderFragment) = EltWithChildBuilder "dt" { v }
    static member inline dt(v: string) = EltWithChildBuilder "dt" { v }
    static member inline dt(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "dt" { html.mergeAttrs attrs }
    static member inline dt(children: NodeRenderFragment seq) = EltWithChildBuilder "dt" { yield! children }

    static member inline em(v: float) = EltWithChildBuilder "em" { v }
    static member inline em(v: int) = EltWithChildBuilder "em" { v }
    static member inline em(v: NodeRenderFragment) = EltWithChildBuilder "em" { v }
    static member inline em(v: string) = EltWithChildBuilder "em" { v }
    static member inline em(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "em" { html.mergeAttrs attrs }
    static member inline em(children: NodeRenderFragment seq) = EltWithChildBuilder "em" { yield! children }

    static member inline fieldSet(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "fieldSet" { html.mergeAttrs attrs }
    static member inline fieldSet(children: NodeRenderFragment seq) =
        EltWithChildBuilder "fieldset" { yield! children }

    static member inline figcaption(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "figcaption" { html.mergeAttrs attrs }
    static member inline figcaption(children: NodeRenderFragment seq) =
        EltWithChildBuilder "figcaption" { yield! children }

    static member inline figure(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "figure" { html.mergeAttrs attrs }
    static member inline figure(children: NodeRenderFragment seq) = EltWithChildBuilder "figure" { yield! children }

    static member inline footer(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "footer" { html.mergeAttrs attrs }
    static member inline footer(children: NodeRenderFragment seq) = EltWithChildBuilder "footer" { yield! children }

    static member inline form(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "form" { html.mergeAttrs attrs }
    static member inline form(children: NodeRenderFragment seq) = EltWithChildBuilder "form" { yield! children }

    static member inline h1(v: float) = EltWithChildBuilder "h1" { v }
    static member inline h1(v: int) = EltWithChildBuilder "h1" { v }
    static member inline h1(v: NodeRenderFragment) = EltWithChildBuilder "h1" { v }
    static member inline h1(v: string) = EltWithChildBuilder "h1" { v }
    static member inline h1(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "h1" { html.mergeAttrs attrs }
    static member inline h1(children: NodeRenderFragment seq) = EltWithChildBuilder "h1" { yield! children }
    static member inline h2(v: float) = EltWithChildBuilder "h2" { v }
    static member inline h2(v: int) = EltWithChildBuilder "h2" { v }
    static member inline h2(v: NodeRenderFragment) = EltWithChildBuilder "h2" { v }
    static member inline h2(v: string) = EltWithChildBuilder "h2" { v }
    static member inline h2(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "h2" { html.mergeAttrs attrs }
    static member inline h2(children: NodeRenderFragment seq) = EltWithChildBuilder "h2" { yield! children }

    static member inline h3(v: float) = EltWithChildBuilder "h3" { v }
    static member inline h3(v: int) = EltWithChildBuilder "h3" { v }
    static member inline h3(v: NodeRenderFragment) = EltWithChildBuilder "h3" { v }
    static member inline h3(v: string) = EltWithChildBuilder "h3" { v }
    static member inline h3(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "h3" { html.mergeAttrs attrs }
    static member inline h3(children: NodeRenderFragment seq) = EltWithChildBuilder "h3" { yield! children }

    static member inline h4(v: float) = EltWithChildBuilder "h4" { v }
    static member inline h4(v: int) = EltWithChildBuilder "h4" { v }
    static member inline h4(v: NodeRenderFragment) = EltWithChildBuilder "h4" { v }
    static member inline h4(v: string) = EltWithChildBuilder "h4" { v }
    static member inline h4(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "h4" { html.mergeAttrs attrs }
    static member inline h4(children: NodeRenderFragment seq) = EltWithChildBuilder "h4" { yield! children }

    static member inline h5(v: float) = EltWithChildBuilder "h5" { v }
    static member inline h5(v: int) = EltWithChildBuilder "h5" { v }
    static member inline h5(v: NodeRenderFragment) = EltWithChildBuilder "h5" { v }
    static member inline h5(v: string) = EltWithChildBuilder "h5" { v }
    static member inline h5(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "h5" { html.mergeAttrs attrs }
    static member inline h5(children: NodeRenderFragment seq) = EltWithChildBuilder "h5" { yield! children }

    static member inline h6(v: float) = EltWithChildBuilder "h6" { v }
    static member inline h6(v: int) = EltWithChildBuilder "h6" { v }
    static member inline h6(v: NodeRenderFragment) = EltWithChildBuilder "h6" { v }
    static member inline h6(v: string) = EltWithChildBuilder "h6" { v }
    static member inline h6(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "h6" { html.mergeAttrs attrs }
    static member inline h6(children: NodeRenderFragment seq) = EltWithChildBuilder "h6" { yield! children }

    static member inline head(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "head" { html.mergeAttrs attrs }
    static member inline head(children: NodeRenderFragment seq) = EltWithChildBuilder "head" { yield! children }

    static member inline header(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "header" { html.mergeAttrs attrs }
    static member inline header(children: NodeRenderFragment seq) = EltWithChildBuilder "header" { yield! children }

    static member inline hr(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "hr" { html.mergeAttrs attrs }
    static member inline hr(children: NodeRenderFragment seq) = EltWithChildBuilder "hr" { yield! children }

    static member inline html(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "html" { html.mergeAttrs attrs }
    static member inline html(children: NodeRenderFragment seq) = EltWithChildBuilder "html" { yield! children }

    static member inline i(v: float) = EltWithChildBuilder "i" { v }
    static member inline i(v: int) = EltWithChildBuilder "i" { v }
    static member inline i(v: NodeRenderFragment) = EltWithChildBuilder "i" { v }
    static member inline i(v: string) = EltWithChildBuilder "i" { v }
    static member inline i(attrs: AttrRenderFragment seq) = EltWithChildBuilder "i" { html.mergeAttrs attrs }
    static member inline i(children: NodeRenderFragment seq) = EltWithChildBuilder "i" { yield! children }

    static member inline iframe(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "iframe" { html.mergeAttrs attrs }
    static member inline iframe(children: NodeRenderFragment seq) = EltWithChildBuilder "iframe" { yield! children }

    static member inline img(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "img" { html.mergeAttrs attrs }
    static member inline img(children: NodeRenderFragment seq) = EltWithChildBuilder "img" { yield! children }

    static member inline input(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "input" { html.mergeAttrs attrs }
    static member inline input(children: NodeRenderFragment seq) = EltWithChildBuilder "input" { yield! children }

    static member inline ins(v: float) = EltWithChildBuilder "ins" { v }
    static member inline ins(v: int) = EltWithChildBuilder "ins" { v }
    static member inline ins(v: NodeRenderFragment) = EltWithChildBuilder "ins" { v }
    static member inline ins(v: string) = EltWithChildBuilder "ins" { v }
    static member inline ins(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "ins" { html.mergeAttrs attrs }
    static member inline ins(children: NodeRenderFragment seq) = EltWithChildBuilder "ins" { yield! children }

    static member inline kbd(v: float) = EltWithChildBuilder "kbd" { v }
    static member inline kbd(v: int) = EltWithChildBuilder "kbd" { v }
    static member inline kbd(v: NodeRenderFragment) = EltWithChildBuilder "kbd" { v }
    static member inline kbd(v: string) = EltWithChildBuilder "kbd" { v }
    static member inline kbd(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "kbd" { html.mergeAttrs attrs }
    static member inline kbd(children: NodeRenderFragment seq) = EltWithChildBuilder "kbd" { yield! children }

    static member inline label(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "label" { html.mergeAttrs attrs }
    static member inline label(children: NodeRenderFragment seq) = EltWithChildBuilder "label" { yield! children }

    static member inline legend(v: float) = EltWithChildBuilder "legend" { v }
    static member inline legend(v: int) = EltWithChildBuilder "legend" { v }
    static member inline legend(v: NodeRenderFragment) = EltWithChildBuilder "legend" { v }
    static member inline legend(v: string) = EltWithChildBuilder "legend" { v }
    static member inline legend(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "legend" { html.mergeAttrs attrs }
    static member inline legend(children: NodeRenderFragment seq) = EltWithChildBuilder "legend" { yield! children }

    static member inline li(v: float) = EltWithChildBuilder "li" { v }
    static member inline li(v: int) = EltWithChildBuilder "li" { v }
    static member inline li(v: NodeRenderFragment) = EltWithChildBuilder "li" { v }
    static member inline li(v: string) = EltWithChildBuilder "li" { v }
    static member inline li(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "li" { html.mergeAttrs attrs }
    static member inline li(children: NodeRenderFragment seq) = EltWithChildBuilder "li" { yield! children }

    static member inline listItem(v: float) = EltWithChildBuilder "li" { v }
    static member inline listItem(v: int) = EltWithChildBuilder "li" { v }
    static member inline listItem(v: NodeRenderFragment) = EltWithChildBuilder "li" { v }
    static member inline listItem(v: string) = EltWithChildBuilder "li" { v }
    static member inline listItem(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "listItem" { html.mergeAttrs attrs }
    static member inline listItem(children: NodeRenderFragment seq) = EltWithChildBuilder "li" { yield! children }

    static member inline main(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "main" { html.mergeAttrs attrs }
    static member inline main(children: NodeRenderFragment seq) = EltWithChildBuilder "main" { yield! children }

    static member inline map(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "map" { html.mergeAttrs attrs }
    static member inline map(children: NodeRenderFragment seq) = EltWithChildBuilder "map" { yield! children }

    static member inline mark(v: float) = EltWithChildBuilder "mark" { v }
    static member inline mark(v: int) = EltWithChildBuilder "mark" { v }
    static member inline mark(v: NodeRenderFragment) = EltWithChildBuilder "mark" { v }
    static member inline mark(v: string) = EltWithChildBuilder "mark" { v }
    static member inline mark(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "mark" { html.mergeAttrs attrs }
    static member inline mark(children: NodeRenderFragment seq) = EltWithChildBuilder "mark" { yield! children }

    static member inline metadata(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "metadata" { html.mergeAttrs attrs }
    static member inline metadata(children: NodeRenderFragment seq) =
        EltWithChildBuilder "metadata" { yield! children }

    static member inline meter(v: float) = EltWithChildBuilder "meter" { v }
    static member inline meter(v: int) = EltWithChildBuilder "meter" { v }
    static member inline meter(v: NodeRenderFragment) = EltWithChildBuilder "meter" { v }
    static member inline meter(v: string) = EltWithChildBuilder "meter" { v }
    static member inline meter(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "meter" { html.mergeAttrs attrs }
    static member inline meter(children: NodeRenderFragment seq) = EltWithChildBuilder "meter" { yield! children }

    static member inline nav(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "nav" { html.mergeAttrs attrs }
    static member inline nav(children: NodeRenderFragment seq) = EltWithChildBuilder "nav" { yield! children }

    static member inline noscript(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "noscript" { html.mergeAttrs attrs }
    static member inline noscript(children: NodeRenderFragment seq) =
        EltWithChildBuilder "noscript" { yield! children }

    static member inline object(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "object" { html.mergeAttrs attrs }
    static member inline object(children: NodeRenderFragment seq) = EltWithChildBuilder "object" { yield! children }

    static member inline ol(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "ol" { html.mergeAttrs attrs }
    static member inline ol(children: NodeRenderFragment seq) = EltWithChildBuilder "ol" { yield! children }

    static member inline option(v: float) = EltWithChildBuilder "option" { v }
    static member inline option(v: int) = EltWithChildBuilder "option" { v }
    static member inline option(v: NodeRenderFragment) = EltWithChildBuilder "option" { v }
    static member inline option(v: string) = EltWithChildBuilder "option" { v }
    static member inline option(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "option" { html.mergeAttrs attrs }
    static member inline option(children: NodeRenderFragment seq) = EltWithChildBuilder "option" { yield! children }

    static member inline optgroup(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "optgroup" { html.mergeAttrs attrs }
    static member inline optgroup(children: NodeRenderFragment seq) =
        EltWithChildBuilder "optgroup" { yield! children }

    static member inline orderedList(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "orderedList" { html.mergeAttrs attrs }
    static member inline orderedList(children: NodeRenderFragment seq) = EltWithChildBuilder "ol" { yield! children }

    static member inline output(v: float) = EltWithChildBuilder "output" { v }
    static member inline output(v: int) = EltWithChildBuilder "output" { v }
    static member inline output(v: NodeRenderFragment) = EltWithChildBuilder "output" { v }
    static member inline output(v: string) = EltWithChildBuilder "output" { v }
    static member inline output(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "output" { html.mergeAttrs attrs }
    static member inline output(children: NodeRenderFragment seq) = EltWithChildBuilder "output" { yield! children }

    static member inline p(v: float) = EltWithChildBuilder "p" { v }
    static member inline p(v: int) = EltWithChildBuilder "p" { v }
    static member inline p(v: NodeRenderFragment) = EltWithChildBuilder "p" { v }
    static member inline p(v: string) = EltWithChildBuilder "p" { v }
    static member inline p(attrs: AttrRenderFragment seq) = EltWithChildBuilder "p" { html.mergeAttrs attrs }
    static member inline p(children: NodeRenderFragment seq) = EltWithChildBuilder "p" { yield! children }

    static member inline paragraph(v: float) = EltWithChildBuilder "p" { v }
    static member inline paragraph(v: int) = EltWithChildBuilder "p" { v }
    static member inline paragraph(v: NodeRenderFragment) = EltWithChildBuilder "p" { v }
    static member inline paragraph(v: string) = EltWithChildBuilder "p" { v }
    static member inline paragraph(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "paragraph" { html.mergeAttrs attrs }
    static member inline paragraph(children: NodeRenderFragment seq) = EltWithChildBuilder "p" { yield! children }

    static member inline picture(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "picture" { html.mergeAttrs attrs }
    static member inline picture(children: NodeRenderFragment seq) = EltWithChildBuilder "picture" { yield! children }

    // static member inline pre (v: bool) = EltWithChildBuilder "pre" value
    static member inline pre(v: float) = EltWithChildBuilder "pre" { v }
    static member inline pre(v: int) = EltWithChildBuilder "pre" { v }
    static member inline pre(v: NodeRenderFragment) = EltWithChildBuilder "pre" { v }
    static member inline pre(v: string) = EltWithChildBuilder "pre" { v }
    static member inline pre(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "pre" { html.mergeAttrs attrs }
    static member inline pre(children: NodeRenderFragment seq) = EltWithChildBuilder "pre" { yield! children }

    static member inline progress(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "progress" { html.mergeAttrs attrs }
    static member inline progress(children: NodeRenderFragment seq) =
        EltWithChildBuilder "progress" { yield! children }

    static member inline q(attrs: AttrRenderFragment seq) = EltWithChildBuilder "q" { html.mergeAttrs attrs }
    static member inline q(children: NodeRenderFragment seq) = EltWithChildBuilder "q" { yield! children }

    static member inline rb(v: float) = EltWithChildBuilder "rb" { v }
    static member inline rb(v: int) = EltWithChildBuilder "rb" { v }
    static member inline rb(v: NodeRenderFragment) = EltWithChildBuilder "rb" { v }
    static member inline rb(v: string) = EltWithChildBuilder "rb" { v }
    static member inline rb(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "rb" { html.mergeAttrs attrs }
    static member inline rb(children: NodeRenderFragment seq) = EltWithChildBuilder "rb" { yield! children }

    static member inline rp(v: float) = EltWithChildBuilder "rp" { v }
    static member inline rp(v: int) = EltWithChildBuilder "rp" { v }
    static member inline rp(v: NodeRenderFragment) = EltWithChildBuilder "rp" { v }
    static member inline rp(v: string) = EltWithChildBuilder "rp" { v }
    static member inline rp(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "rp" { html.mergeAttrs attrs }
    static member inline rp(children: NodeRenderFragment seq) = EltWithChildBuilder "rp" { yield! children }

    static member inline rt(v: float) = EltWithChildBuilder "rt" { v }
    static member inline rt(v: int) = EltWithChildBuilder "rt" { v }
    static member inline rt(v: NodeRenderFragment) = EltWithChildBuilder "rt" { v }
    static member inline rt(v: string) = EltWithChildBuilder "rt" { v }
    static member inline rt(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "rt" { html.mergeAttrs attrs }
    static member inline rt(children: NodeRenderFragment seq) = EltWithChildBuilder "rt" { yield! children }

    static member inline rtc(v: float) = EltWithChildBuilder "rtc" { v }
    static member inline rtc(v: int) = EltWithChildBuilder "rtc" { v }
    static member inline rtc(v: NodeRenderFragment) = EltWithChildBuilder "rtc" { v }
    static member inline rtc(v: string) = EltWithChildBuilder "rtc" { v }
    static member inline rtc(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "rtc" { html.mergeAttrs attrs }
    static member inline rtc(children: NodeRenderFragment seq) = EltWithChildBuilder "rtc" { yield! children }

    static member inline ruby(v: float) = EltWithChildBuilder "ruby" { v }
    static member inline ruby(v: int) = EltWithChildBuilder "ruby" { v }
    static member inline ruby(v: NodeRenderFragment) = EltWithChildBuilder "ruby" { v }
    static member inline ruby(v: string) = EltWithChildBuilder "ruby" { v }
    static member inline ruby(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "ruby" { html.mergeAttrs attrs }
    static member inline ruby(children: NodeRenderFragment seq) = EltWithChildBuilder "ruby" { yield! children }

    static member inline s(v: float) = EltWithChildBuilder "s" { v }
    static member inline s(v: int) = EltWithChildBuilder "s" { v }
    static member inline s(v: NodeRenderFragment) = EltWithChildBuilder "s" { v }
    static member inline s(v: string) = EltWithChildBuilder "s" { v }
    static member inline s(attrs: AttrRenderFragment seq) = EltWithChildBuilder "s" { html.mergeAttrs attrs }
    static member inline s(children: NodeRenderFragment seq) = EltWithChildBuilder "s" { yield! children }

    static member inline samp(v: float) = EltWithChildBuilder "samp" { v }
    static member inline samp(v: int) = EltWithChildBuilder "samp" { v }
    static member inline samp(v: NodeRenderFragment) = EltWithChildBuilder "samp" { v }
    static member inline samp(v: string) = EltWithChildBuilder "samp" { v }
    static member inline samp(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "samp" { html.mergeAttrs attrs }
    static member inline samp(children: NodeRenderFragment seq) = EltWithChildBuilder "samp" { yield! children }

    static member inline script(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "script" { html.mergeAttrs attrs }
    static member inline script(children: NodeRenderFragment seq) = EltWithChildBuilder "script" { yield! children }

    static member inline section(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "section" { html.mergeAttrs attrs }
    static member inline section(children: NodeRenderFragment seq) = EltWithChildBuilder "section" { yield! children }

    static member inline select(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "select" { html.mergeAttrs attrs }
    static member inline select(children: NodeRenderFragment seq) = EltWithChildBuilder "select" { yield! children }
    static member inline small(v: float) = EltWithChildBuilder "small" { v }
    static member inline small(v: int) = EltWithChildBuilder "small" { v }
    static member inline small(v: NodeRenderFragment) = EltWithChildBuilder "small" { v }
    static member inline small(v: string) = EltWithChildBuilder "small" { v }
    static member inline small(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "small" { html.mergeAttrs attrs }
    static member inline small(children: NodeRenderFragment seq) = EltWithChildBuilder "small" { yield! children }

    static member inline source(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "source" { html.mergeAttrs attrs }
    static member inline source(children: NodeRenderFragment seq) = EltWithChildBuilder "source" { yield! children }

    static member inline span(v: float) = EltWithChildBuilder "span" { v }
    static member inline span(v: int) = EltWithChildBuilder "span" { v }
    static member inline span(v: NodeRenderFragment) = EltWithChildBuilder "span" { v }
    static member inline span(v: string) = EltWithChildBuilder "span" { v }
    static member inline span(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "span" { html.mergeAttrs attrs }
    static member inline span(children: NodeRenderFragment seq) = EltWithChildBuilder "span" { yield! children }

    static member inline strong(v: float) = EltWithChildBuilder "strong" { v }
    static member inline strong(v: int) = EltWithChildBuilder "strong" { v }
    static member inline strong(v: NodeRenderFragment) = EltWithChildBuilder "strong" { v }
    static member inline strong(v: string) = EltWithChildBuilder "strong" { v }
    static member inline strong(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "strong" { html.mergeAttrs attrs }
    static member inline strong(children: NodeRenderFragment seq) = EltWithChildBuilder "strong" { yield! children }

    static member inline style(v: string) = EltWithChildBuilder "style" { v }

    static member inline sub(v: float) = EltWithChildBuilder "sub" { v }
    static member inline sub(v: int) = EltWithChildBuilder "sub" { v }
    static member inline sub(v: NodeRenderFragment) = EltWithChildBuilder "sub" { v }
    static member inline sub(v: string) = EltWithChildBuilder "sub" { v }
    static member inline sub(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "sub" { html.mergeAttrs attrs }
    static member inline sub(children: NodeRenderFragment seq) = EltWithChildBuilder "sub" { yield! children }

    static member inline summary(v: float) = EltWithChildBuilder "summary" { v }
    static member inline summary(v: int) = EltWithChildBuilder "summary" { v }
    static member inline summary(v: NodeRenderFragment) = EltWithChildBuilder "summary" { v }
    static member inline summary(v: string) = EltWithChildBuilder "summary" { v }
    static member inline summary(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "summary" { html.mergeAttrs attrs }
    static member inline summary(children: NodeRenderFragment seq) = EltWithChildBuilder "summary" { yield! children }

    static member inline sup(v: float) = EltWithChildBuilder "sup" { v }
    static member inline sup(v: int) = EltWithChildBuilder "sup" { v }
    static member inline sup(v: NodeRenderFragment) = EltWithChildBuilder "sup" { v }
    static member inline sup(v: string) = EltWithChildBuilder "sup" { v }
    static member inline sup(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "sup" { html.mergeAttrs attrs }
    static member inline sup(children: NodeRenderFragment seq) = EltWithChildBuilder "sup" { yield! children }

    static member inline table(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "table" { html.mergeAttrs attrs }
    static member inline table(children: NodeRenderFragment seq) = EltWithChildBuilder "table" { yield! children }

    static member inline tableBody(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "tableBody" { html.mergeAttrs attrs }
    static member inline tableBody(children: NodeRenderFragment seq) = EltWithChildBuilder "tbody" { yield! children }

    static member inline tableCell(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "tableCell" { html.mergeAttrs attrs }
    static member inline tableCell(children: NodeRenderFragment seq) = EltWithChildBuilder "td" { yield! children }

    static member inline tableHeader(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "tableHeader" { html.mergeAttrs attrs }
    static member inline tableHeader(children: NodeRenderFragment seq) = EltWithChildBuilder "th" { yield! children }

    static member inline tableRow(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "tableRow" { html.mergeAttrs attrs }
    static member inline tableRow(children: NodeRenderFragment seq) = EltWithChildBuilder "tr" { yield! children }

    static member inline tbody(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "tbody" { html.mergeAttrs attrs }
    static member inline tbody(children: NodeRenderFragment seq) = EltWithChildBuilder "tbody" { yield! children }

    static member inline td(v: float) = EltWithChildBuilder "td" { v }
    static member inline td(v: int) = EltWithChildBuilder "td" { v }
    static member inline td(v: NodeRenderFragment) = EltWithChildBuilder "td" { v }
    static member inline td(v: string) = EltWithChildBuilder "td" { v }
    static member inline td(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "td" { html.mergeAttrs attrs }
    static member inline td(children: NodeRenderFragment seq) = EltWithChildBuilder "td" { yield! children }

    static member inline template(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "template" { html.mergeAttrs attrs }
    static member inline template(children: NodeRenderFragment seq) =
        EltWithChildBuilder "template" { yield! children }

    static member inline textarea(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "textarea" { html.mergeAttrs attrs }
    static member inline textarea(children: NodeRenderFragment seq) =
        EltWithChildBuilder "textarea" { yield! children }

    static member inline tfoot(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "tfoot" { html.mergeAttrs attrs }
    static member inline tfoot(children: NodeRenderFragment seq) = EltWithChildBuilder "tfoot" { yield! children }

    static member inline th(v: float) = EltWithChildBuilder "th" { v }
    static member inline th(v: int) = EltWithChildBuilder "th" { v }
    static member inline th(v: NodeRenderFragment) = EltWithChildBuilder "th" { v }
    static member inline th(v: string) = EltWithChildBuilder "th" { v }
    static member inline th(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "th" { html.mergeAttrs attrs }
    static member inline th(children: NodeRenderFragment seq) = EltWithChildBuilder "th" { yield! children }

    static member inline thead(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "thead" { html.mergeAttrs attrs }
    static member inline thead(children: NodeRenderFragment seq) = EltWithChildBuilder "thead" { yield! children }

    static member inline time(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "time" { html.mergeAttrs attrs }
    static member inline time(children: NodeRenderFragment seq) = EltWithChildBuilder "time" { yield! children }

    static member inline tr(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "tr" { html.mergeAttrs attrs }
    static member inline tr(children: NodeRenderFragment seq) = EltWithChildBuilder "tr" { yield! children }

    static member inline track(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "track" { html.mergeAttrs attrs }
    static member inline track(children: NodeRenderFragment seq) = EltWithChildBuilder "track" { yield! children }

    static member inline u(v: float) = EltWithChildBuilder "u" { v }
    static member inline u(v: int) = EltWithChildBuilder "u" { v }
    static member inline u(v: NodeRenderFragment) = EltWithChildBuilder "u" { v }
    static member inline u(v: string) = EltWithChildBuilder "u" { v }
    static member inline u(attrs: AttrRenderFragment seq) = EltWithChildBuilder "u" { html.mergeAttrs attrs }
    static member inline u(children: NodeRenderFragment seq) = EltWithChildBuilder "u" { yield! children }

    static member inline ul(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "ul" { html.mergeAttrs attrs }
    static member inline ul(children: NodeRenderFragment seq) = EltWithChildBuilder "ul" { yield! children }

    static member inline unorderedList(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "unorderedList" { html.mergeAttrs attrs }
    static member inline unorderedList(children: NodeRenderFragment seq) = EltWithChildBuilder "ul" { yield! children }

    static member inline var(v: float) = EltWithChildBuilder "var" { v }
    static member inline var(v: int) = EltWithChildBuilder "var" { v }
    static member inline var(v: NodeRenderFragment) = EltWithChildBuilder "var" { v }
    static member inline var(v: string) = EltWithChildBuilder "var" { v }
    static member inline var(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "var" { html.mergeAttrs attrs }
    static member inline var(children: NodeRenderFragment seq) = EltWithChildBuilder "var" { yield! children }

    static member inline video(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "video" { html.mergeAttrs attrs }
    static member inline video(children: NodeRenderFragment seq) = EltWithChildBuilder "video" { yield! children }

    static member inline wbr(attrs: AttrRenderFragment seq) =
        EltWithChildBuilder "wbr" { html.mergeAttrs attrs }
    static member inline wbr(children: NodeRenderFragment seq) = EltWithChildBuilder "wbr" { yield! children }
