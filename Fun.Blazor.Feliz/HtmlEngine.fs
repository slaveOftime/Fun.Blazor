[<AutoOpen>]
module Fun.Blazor.HtmlEngine

open Fun.Blazor


type html with

    /// Create a custom element
    ///
    /// You generally shouldn't need to use this, if you notice an element missing please submit an issue.
    static member inline custom(key: string, children: seq<NodeRenderFragment>) = EltWithChildBuilder key { yield! children }

    static member inline script(x: string) = script { src x }
    static member inline stylesheet(x: string) = stylesheet x

    static member inline a(children: NodeRenderFragment seq) = a { yield! children }

    static member inline abbr(v: float) = abbr { v }
    static member inline abbr(v: int) = abbr { v }
    static member inline abbr(v: NodeRenderFragment) = abbr { v }
    static member inline abbr(v: string) = abbr { v }
    static member inline abbr(attrs: AttrRenderFragment seq) = abbr { html.mergeAttrs attrs }
    static member inline abbr(children: NodeRenderFragment seq) = abbr { yield! children }

    static member inline address(v: float) = address { v }
    static member inline address(v: int) = address { v }
    static member inline address(v: NodeRenderFragment) = address { v }
    static member inline address(v: string) = address { v }
    static member inline address(attrs: AttrRenderFragment seq) = address { html.mergeAttrs attrs }
    static member inline address(children: NodeRenderFragment seq) = address { yield! children }

    static member inline anchor(attrs: AttrRenderFragment seq) = anchor { html.mergeAttrs attrs }
    static member inline anchor(children: NodeRenderFragment seq) = a { yield! children }

    static member inline area(attrs: AttrRenderFragment seq) = area { html.mergeAttrs attrs }
    static member inline area(children: NodeRenderFragment seq) = area { yield! children }

    static member inline article(attrs: AttrRenderFragment seq) = article { html.mergeAttrs attrs }
    static member inline article(children: NodeRenderFragment seq) = article { yield! children }

    static member inline aside(attrs: AttrRenderFragment seq) = aside { html.mergeAttrs attrs }
    static member inline aside(children: NodeRenderFragment seq) = aside { yield! children }

    static member inline audio(attrs: AttrRenderFragment seq) = audio { html.mergeAttrs attrs }
    static member inline audio(children: NodeRenderFragment seq) = audio { yield! children }

    static member inline b(v: float) = b { v }
    static member inline b(v: int) = b { v }
    static member inline b(v: NodeRenderFragment) = b { v }
    static member inline b(v: string) = b { v }
    static member inline b(attrs: AttrRenderFragment seq) = b { html.mergeAttrs attrs }
    static member inline b(children: NodeRenderFragment seq) = b { yield! children }

    static member inline base'(attrs: AttrRenderFragment seq) = base' { html.mergeAttrs attrs }
    static member inline base'(children: NodeRenderFragment seq) = base' { yield! children }

    static member inline bdi(v: float) = bdi { v }
    static member inline bdi(v: int) = bdi { v }
    static member inline bdi(v: NodeRenderFragment) = bdi { v }
    static member inline bdi(v: string) = bdi { v }
    static member inline bdi(attrs: AttrRenderFragment seq) = bdi { html.mergeAttrs attrs }
    static member inline bdi(children: NodeRenderFragment seq) = bdi { yield! children }

    static member inline bdo(v: float) = bdo { v }
    static member inline bdo(v: int) = bdo { v }
    static member inline bdo(v: NodeRenderFragment) = bdo { v }
    static member inline bdo(v: string) = bdo { v }
    static member inline bdo(attrs: AttrRenderFragment seq) = bdo { html.mergeAttrs attrs }
    static member inline bdo(children: NodeRenderFragment seq) = bdo { yield! children }

    static member inline blockquote(v: float) = blockquote { v }
    static member inline blockquote(v: int) = blockquote { v }
    static member inline blockquote(v: NodeRenderFragment) = blockquote { v }
    static member inline blockquote(v: string) = blockquote { v }
    static member inline blockquote(attrs: AttrRenderFragment seq) = blockquote { html.mergeAttrs attrs }
    static member inline blockquote(children: NodeRenderFragment seq) = blockquote { yield! children }

    static member inline body(v: float) = body { v }
    static member inline body(v: int) = body { v }
    static member inline body(v: NodeRenderFragment) = body { v }
    static member inline body(v: string) = body { v }
    static member inline body(attrs: AttrRenderFragment seq) = body { html.mergeAttrs attrs }
    static member inline body(children: NodeRenderFragment seq) = body { yield! children }

    static member inline br(attrs: AttrRenderFragment seq) = br { html.mergeAttrs attrs }
    static member inline br(children: NodeRenderFragment seq) = br { yield! children }

    static member inline button(attrs: AttrRenderFragment seq) = button { html.mergeAttrs attrs }
    static member inline button(children: NodeRenderFragment seq) = button { yield! children }

    static member inline canvas(attrs: AttrRenderFragment seq) = canvas { html.mergeAttrs attrs }
    static member inline canvas(children: NodeRenderFragment seq) = canvas { yield! children }

    static member inline caption(v: float) = caption { v }
    static member inline caption(v: int) = caption { v }
    static member inline caption(v: NodeRenderFragment) = caption { v }
    static member inline caption(v: string) = caption { v }
    static member inline caption(attrs: AttrRenderFragment seq) = caption { html.mergeAttrs attrs }
    static member inline caption(children: NodeRenderFragment seq) = caption { yield! children }

    static member inline cite(v: float) = cite { v }
    static member inline cite(v: int) = cite { v }
    static member inline cite(v: NodeRenderFragment) = cite { v }
    static member inline cite(v: string) = cite { v }
    static member inline cite(attrs: AttrRenderFragment seq) = cite { html.mergeAttrs attrs }
    static member inline cite(children: NodeRenderFragment seq) = cite { yield! children }

    // static member inline code (v: bool) = code" value
    static member inline code(v: float) = code { v }
    static member inline code(v: int) = code { v }
    static member inline code(v: NodeRenderFragment) = code { v }
    static member inline code(v: string) = code { v }
    static member inline code(attrs: AttrRenderFragment seq) = code { html.mergeAttrs attrs }
    static member inline code(children: NodeRenderFragment seq) = code { yield! children }

    static member inline col(attrs: AttrRenderFragment seq) = col { html.mergeAttrs attrs }
    static member inline col(children: NodeRenderFragment seq) = col { yield! children }

    static member inline colgroup(attrs: AttrRenderFragment seq) = colgroup { html.mergeAttrs attrs }
    static member inline colgroup(children: NodeRenderFragment seq) = colgroup { yield! children }

    static member inline data(v: float) = data { v }
    static member inline data(v: int) = data { v }
    static member inline data(v: NodeRenderFragment) = data { v }
    static member inline data(v: string) = data { v }
    static member inline data(attrs: AttrRenderFragment seq) = data { html.mergeAttrs attrs }
    static member inline data(children: NodeRenderFragment seq) = data { yield! children }

    static member inline datalist(v: float) = datalist { v }
    static member inline datalist(v: int) = datalist { v }
    static member inline datalist(v: NodeRenderFragment) = datalist { v }
    static member inline datalist(v: string) = datalist { v }
    static member inline datalist(attrs: AttrRenderFragment seq) = datalist { html.mergeAttrs attrs }
    static member inline datalist(children: NodeRenderFragment seq) = datalist { yield! children }

    static member inline dd(v: float) = dd { v }
    static member inline dd(v: int) = dd { v }
    static member inline dd(v: NodeRenderFragment) = dd { v }
    static member inline dd(v: string) = dd { v }
    static member inline dd(attrs: AttrRenderFragment seq) = dd { html.mergeAttrs attrs }
    static member inline dd(children: NodeRenderFragment seq) = dd { yield! children }

    static member inline del(v: float) = del { v }
    static member inline del(v: int) = del { v }
    static member inline del(v: NodeRenderFragment) = del { v }
    static member inline del(v: string) = del { v }
    static member inline del(attrs: AttrRenderFragment seq) = del { html.mergeAttrs attrs }
    static member inline del(children: NodeRenderFragment seq) = del { yield! children }

    static member inline details(attrs: AttrRenderFragment seq) = details { html.mergeAttrs attrs }
    static member inline details(children: NodeRenderFragment seq) = details { yield! children }

    static member inline dfn(v: float) = dfn { v }
    static member inline dfn(v: int) = dfn { v }
    static member inline dfn(v: NodeRenderFragment) = dfn { v }
    static member inline dfn(v: string) = dfn { v }
    static member inline dfn(attrs: AttrRenderFragment seq) = dfn { html.mergeAttrs attrs }
    static member inline dfn(children: NodeRenderFragment seq) = dfn { yield! children }

    static member inline dialog(v: float) = dialog { v }
    static member inline dialog(v: int) = dialog { v }
    static member inline dialog(v: NodeRenderFragment) = dialog { v }
    static member inline dialog(v: string) = dialog { v }
    static member inline dialog(attrs: AttrRenderFragment seq) = dialog { html.mergeAttrs attrs }
    static member inline dialog(children: NodeRenderFragment seq) = dialog { yield! children }

    static member inline div(v: float) = div { v }
    static member inline div(v: int) = div { v }
    static member inline div(v: NodeRenderFragment) = div { v }
    static member inline div(v: string) = div { v }
    /// The `<div>` tag defines a division or a section in an HTML document
    static member inline div(attrs: AttrRenderFragment seq) = div { html.mergeAttrs attrs }
    static member inline div(children: NodeRenderFragment seq) = div { yield! children }

    static member inline dl(attrs: AttrRenderFragment seq) = dl { html.mergeAttrs attrs }
    static member inline dl(children: NodeRenderFragment seq) = dl { yield! children }

    static member inline dt(v: float) = dt { v }
    static member inline dt(v: int) = dt { v }
    static member inline dt(v: NodeRenderFragment) = dt { v }
    static member inline dt(v: string) = dt { v }
    static member inline dt(attrs: AttrRenderFragment seq) = dt { html.mergeAttrs attrs }
    static member inline dt(children: NodeRenderFragment seq) = dt { yield! children }

    static member inline em(v: float) = em { v }
    static member inline em(v: int) = em { v }
    static member inline em(v: NodeRenderFragment) = em { v }
    static member inline em(v: string) = em { v }
    static member inline em(attrs: AttrRenderFragment seq) = em { html.mergeAttrs attrs }
    static member inline em(children: NodeRenderFragment seq) = em { yield! children }

    static member inline fieldset(attrs: AttrRenderFragment seq) = fieldset { html.mergeAttrs attrs }
    static member inline fieldset(children: NodeRenderFragment seq) = fieldset { yield! children }

    static member inline figcaption(attrs: AttrRenderFragment seq) = figcaption { html.mergeAttrs attrs }
    static member inline figcaption(children: NodeRenderFragment seq) = figcaption { yield! children }

    static member inline figure(attrs: AttrRenderFragment seq) = figure { html.mergeAttrs attrs }
    static member inline figure(children: NodeRenderFragment seq) = figure { yield! children }

    static member inline footer(attrs: AttrRenderFragment seq) = footer { html.mergeAttrs attrs }
    static member inline footer(children: NodeRenderFragment seq) = footer { yield! children }

    static member inline form(attrs: AttrRenderFragment seq) = form { html.mergeAttrs attrs }
    static member inline form(children: NodeRenderFragment seq) = form { yield! children }

    static member inline h1(v: float) = h1 { v }
    static member inline h1(v: int) = h1 { v }
    static member inline h1(v: NodeRenderFragment) = h1 { v }
    static member inline h1(v: string) = h1 { v }
    static member inline h1(attrs: AttrRenderFragment seq) = h1 { html.mergeAttrs attrs }
    static member inline h1(children: NodeRenderFragment seq) = h1 { yield! children }
    static member inline h2(v: float) = h2 { v }
    static member inline h2(v: int) = h2 { v }
    static member inline h2(v: NodeRenderFragment) = h2 { v }
    static member inline h2(v: string) = h2 { v }
    static member inline h2(attrs: AttrRenderFragment seq) = h2 { html.mergeAttrs attrs }
    static member inline h2(children: NodeRenderFragment seq) = h2 { yield! children }

    static member inline h3(v: float) = h3 { v }
    static member inline h3(v: int) = h3 { v }
    static member inline h3(v: NodeRenderFragment) = h3 { v }
    static member inline h3(v: string) = h3 { v }
    static member inline h3(attrs: AttrRenderFragment seq) = h3 { html.mergeAttrs attrs }
    static member inline h3(children: NodeRenderFragment seq) = h3 { yield! children }

    static member inline h4(v: float) = h4 { v }
    static member inline h4(v: int) = h4 { v }
    static member inline h4(v: NodeRenderFragment) = h4 { v }
    static member inline h4(v: string) = h4 { v }
    static member inline h4(attrs: AttrRenderFragment seq) = h4 { html.mergeAttrs attrs }
    static member inline h4(children: NodeRenderFragment seq) = h4 { yield! children }

    static member inline h5(v: float) = h5 { v }
    static member inline h5(v: int) = h5 { v }
    static member inline h5(v: NodeRenderFragment) = h5 { v }
    static member inline h5(v: string) = h5 { v }
    static member inline h5(attrs: AttrRenderFragment seq) = h5 { html.mergeAttrs attrs }
    static member inline h5(children: NodeRenderFragment seq) = h5 { yield! children }

    static member inline h6(v: float) = h6 { v }
    static member inline h6(v: int) = h6 { v }
    static member inline h6(v: NodeRenderFragment) = h6 { v }
    static member inline h6(v: string) = h6 { v }
    static member inline h6(attrs: AttrRenderFragment seq) = h6 { html.mergeAttrs attrs }
    static member inline h6(children: NodeRenderFragment seq) = h6 { yield! children }

    static member inline head(attrs: AttrRenderFragment seq) = head { html.mergeAttrs attrs }
    static member inline head(children: NodeRenderFragment seq) = head { yield! children }

    static member inline header(attrs: AttrRenderFragment seq) = header { html.mergeAttrs attrs }
    static member inline header(children: NodeRenderFragment seq) = header { yield! children }

    static member inline hr(attrs: AttrRenderFragment seq) = hr { html.mergeAttrs attrs }
    static member inline hr(children: NodeRenderFragment seq) = hr { yield! children }

    static member inline html(attrs: AttrRenderFragment seq) = html' { html.mergeAttrs attrs }
    static member inline html(children: NodeRenderFragment seq) = html' { yield! children }

    static member inline i(v: float) = i { v }
    static member inline i(v: int) = i { v }
    static member inline i(v: NodeRenderFragment) = i { v }
    static member inline i(v: string) = i { v }
    static member inline i(attrs: AttrRenderFragment seq) = i { html.mergeAttrs attrs }
    static member inline i(children: NodeRenderFragment seq) = i { yield! children }

    static member inline iframe(attrs: AttrRenderFragment seq) = iframe { html.mergeAttrs attrs }
    static member inline iframe(children: NodeRenderFragment seq) = iframe { yield! children }

    static member inline img(attrs: AttrRenderFragment seq) = img { html.mergeAttrs attrs }

    static member inline input(attrs: AttrRenderFragment seq) = input { html.mergeAttrs attrs }
    static member inline input(children: NodeRenderFragment seq) = input { yield! children }

    static member inline ins(v: float) = ins { v }
    static member inline ins(v: int) = ins { v }
    static member inline ins(v: NodeRenderFragment) = ins { v }
    static member inline ins(v: string) = ins { v }
    static member inline ins(attrs: AttrRenderFragment seq) = ins { html.mergeAttrs attrs }
    static member inline ins(children: NodeRenderFragment seq) = ins { yield! children }

    static member inline kbd(v: float) = kbd { v }
    static member inline kbd(v: int) = kbd { v }
    static member inline kbd(v: NodeRenderFragment) = kbd { v }
    static member inline kbd(v: string) = kbd { v }
    static member inline kbd(attrs: AttrRenderFragment seq) = kbd { html.mergeAttrs attrs }
    static member inline kbd(children: NodeRenderFragment seq) = kbd { yield! children }

    static member inline label(attrs: AttrRenderFragment seq) = label { html.mergeAttrs attrs }
    static member inline label(children: NodeRenderFragment seq) = label { yield! children }

    static member inline legend(v: float) = legend { v }
    static member inline legend(v: int) = legend { v }
    static member inline legend(v: NodeRenderFragment) = legend { v }
    static member inline legend(v: string) = legend { v }
    static member inline legend(attrs: AttrRenderFragment seq) = legend { html.mergeAttrs attrs }
    static member inline legend(children: NodeRenderFragment seq) = legend { yield! children }

    static member inline li(v: float) = li { v }
    static member inline li(v: int) = li { v }
    static member inline li(v: NodeRenderFragment) = li { v }
    static member inline li(v: string) = li { v }
    static member inline li(attrs: AttrRenderFragment seq) = li { html.mergeAttrs attrs }
    static member inline li(children: NodeRenderFragment seq) = li { yield! children }

    static member inline listItem(v: float) = li { v }
    static member inline listItem(v: int) = li { v }
    static member inline listItem(v: NodeRenderFragment) = li { v }
    static member inline listItem(v: string) = li { v }
    static member inline listItem(attrs: AttrRenderFragment seq) = li { html.mergeAttrs attrs }
    static member inline listItem(children: NodeRenderFragment seq) = li { yield! children }

    static member inline main(attrs: AttrRenderFragment seq) = main { html.mergeAttrs attrs }
    static member inline main(children: NodeRenderFragment seq) = main { yield! children }

    static member inline map(attrs: AttrRenderFragment seq) = map { html.mergeAttrs attrs }
    static member inline map(children: NodeRenderFragment seq) = map { yield! children }

    static member inline mark(v: float) = mark { v }
    static member inline mark(v: int) = mark { v }
    static member inline mark(v: NodeRenderFragment) = mark { v }
    static member inline mark(v: string) = mark { v }
    static member inline mark(attrs: AttrRenderFragment seq) = mark { html.mergeAttrs attrs }
    static member inline mark(children: NodeRenderFragment seq) = mark { yield! children }

    static member inline meta(attrs: AttrRenderFragment seq) = meta { html.mergeAttrs attrs }
    static member inline meta(children: NodeRenderFragment seq) = meta { yield! children }

    static member inline meter(v: float) = meter { v }
    static member inline meter(v: int) = meter { v }
    static member inline meter(v: NodeRenderFragment) = meter { v }
    static member inline meter(v: string) = meter { v }
    static member inline meter(attrs: AttrRenderFragment seq) = meter { html.mergeAttrs attrs }
    static member inline meter(children: NodeRenderFragment seq) = meter { yield! children }

    static member inline nav(attrs: AttrRenderFragment seq) = nav { html.mergeAttrs attrs }
    static member inline nav(children: NodeRenderFragment seq) = nav { yield! children }

    static member inline noscript(attrs: AttrRenderFragment seq) = noscript { html.mergeAttrs attrs }
    static member inline noscript(children: NodeRenderFragment seq) = noscript { yield! children }

    static member inline object(attrs: AttrRenderFragment seq) = object { html.mergeAttrs attrs }
    static member inline object(children: NodeRenderFragment seq) = object { yield! children }

    static member inline ol(attrs: AttrRenderFragment seq) = ol { html.mergeAttrs attrs }
    static member inline ol(children: NodeRenderFragment seq) = ol { yield! children }

    static member inline option(v: float) = option { v }
    static member inline option(v: int) = option { v }
    static member inline option(v: NodeRenderFragment) = option { v }
    static member inline option(v: string) = option { v }
    static member inline option(attrs: AttrRenderFragment seq) = option { html.mergeAttrs attrs }
    static member inline option(children: NodeRenderFragment seq) = option { yield! children }

    static member inline optgroup(attrs: AttrRenderFragment seq) = optgroup { html.mergeAttrs attrs }
    static member inline optgroup(children: NodeRenderFragment seq) = optgroup { yield! children }

    static member inline orderedList(attrs: AttrRenderFragment seq) = ol { html.mergeAttrs attrs }
    static member inline orderedList(children: NodeRenderFragment seq) = ol { yield! children }

    static member inline output(v: float) = output { v }
    static member inline output(v: int) = output { v }
    static member inline output(v: NodeRenderFragment) = output { v }
    static member inline output(v: string) = output { v }
    static member inline output(attrs: AttrRenderFragment seq) = output { html.mergeAttrs attrs }
    static member inline output(children: NodeRenderFragment seq) = output { yield! children }

    static member inline p(v: float) = p { v }
    static member inline p(v: int) = p { v }
    static member inline p(v: NodeRenderFragment) = p { v }
    static member inline p(v: string) = p { v }
    static member inline p(attrs: AttrRenderFragment seq) = p { html.mergeAttrs attrs }
    static member inline p(children: NodeRenderFragment seq) = p { yield! children }

    static member inline paragraph(v: float) = p { v }
    static member inline paragraph(v: int) = p { v }
    static member inline paragraph(v: NodeRenderFragment) = p { v }
    static member inline paragraph(v: string) = p { v }
    static member inline paragraph(attrs: AttrRenderFragment seq) = p { html.mergeAttrs attrs }
    static member inline paragraph(children: NodeRenderFragment seq) = p { yield! children }

    static member inline picture(attrs: AttrRenderFragment seq) = picture { html.mergeAttrs attrs }
    static member inline picture(children: NodeRenderFragment seq) = picture { yield! children }

    // static member inline pre (v: bool) = pre" value
    static member inline pre(v: float) = pre { v }
    static member inline pre(v: int) = pre { v }
    static member inline pre(v: NodeRenderFragment) = pre { v }
    static member inline pre(v: string) = pre { v }
    static member inline pre(attrs: AttrRenderFragment seq) = pre { html.mergeAttrs attrs }
    static member inline pre(children: NodeRenderFragment seq) = pre { yield! children }

    static member inline progress(attrs: AttrRenderFragment seq) = progress { html.mergeAttrs attrs }
    static member inline progress(children: NodeRenderFragment seq) = progress { yield! children }

    static member inline q(attrs: AttrRenderFragment seq) = q { html.mergeAttrs attrs }
    static member inline q(children: NodeRenderFragment seq) = q { yield! children }

    static member inline rb(v: float) = rb { v }
    static member inline rb(v: int) = rb { v }
    static member inline rb(v: NodeRenderFragment) = rb { v }
    static member inline rb(v: string) = rb { v }
    static member inline rb(attrs: AttrRenderFragment seq) = rb { html.mergeAttrs attrs }
    static member inline rb(children: NodeRenderFragment seq) = rb { yield! children }

    static member inline rp(v: float) = rp { v }
    static member inline rp(v: int) = rp { v }
    static member inline rp(v: NodeRenderFragment) = rp { v }
    static member inline rp(v: string) = rp { v }
    static member inline rp(attrs: AttrRenderFragment seq) = rp { html.mergeAttrs attrs }
    static member inline rp(children: NodeRenderFragment seq) = rp { yield! children }

    static member inline rt(v: float) = rt { v }
    static member inline rt(v: int) = rt { v }
    static member inline rt(v: NodeRenderFragment) = rt { v }
    static member inline rt(v: string) = rt { v }
    static member inline rt(attrs: AttrRenderFragment seq) = rt { html.mergeAttrs attrs }
    static member inline rt(children: NodeRenderFragment seq) = rt { yield! children }

    static member inline rtc(v: float) = rtc { v }
    static member inline rtc(v: int) = rtc { v }
    static member inline rtc(v: NodeRenderFragment) = rtc { v }
    static member inline rtc(v: string) = rtc { v }
    static member inline rtc(attrs: AttrRenderFragment seq) = rtc { html.mergeAttrs attrs }
    static member inline rtc(children: NodeRenderFragment seq) = rtc { yield! children }

    static member inline ruby(v: float) = ruby { v }
    static member inline ruby(v: int) = ruby { v }
    static member inline ruby(v: NodeRenderFragment) = ruby { v }
    static member inline ruby(v: string) = ruby { v }
    static member inline ruby(attrs: AttrRenderFragment seq) = ruby { html.mergeAttrs attrs }
    static member inline ruby(children: NodeRenderFragment seq) = ruby { yield! children }

    static member inline s(v: float) = s { v }
    static member inline s(v: int) = s { v }
    static member inline s(v: NodeRenderFragment) = s { v }
    static member inline s(v: string) = s { v }
    static member inline s(attrs: AttrRenderFragment seq) = s { html.mergeAttrs attrs }
    static member inline s(children: NodeRenderFragment seq) = s { yield! children }

    static member inline samp(v: float) = samp { v }
    static member inline samp(v: int) = samp { v }
    static member inline samp(v: NodeRenderFragment) = samp { v }
    static member inline samp(v: string) = samp { v }
    static member inline samp(attrs: AttrRenderFragment seq) = samp { html.mergeAttrs attrs }
    static member inline samp(children: NodeRenderFragment seq) = samp { yield! children }

    static member inline script(attrs: AttrRenderFragment seq) = script { html.mergeAttrs attrs }
    static member inline script(children: NodeRenderFragment seq) = script { yield! children }

    static member inline section(attrs: AttrRenderFragment seq) = section { html.mergeAttrs attrs }
    static member inline section(children: NodeRenderFragment seq) = section { yield! children }

    static member inline select(attrs: AttrRenderFragment seq) = select { html.mergeAttrs attrs }
    static member inline select(children: NodeRenderFragment seq) = select { yield! children }
    static member inline small(v: float) = small { v }
    static member inline small(v: int) = small { v }
    static member inline small(v: NodeRenderFragment) = small { v }
    static member inline small(v: string) = small { v }
    static member inline small(attrs: AttrRenderFragment seq) = small { html.mergeAttrs attrs }
    static member inline small(children: NodeRenderFragment seq) = small { yield! children }

    static member inline source(attrs: AttrRenderFragment seq) = source { html.mergeAttrs attrs }
    static member inline source(children: NodeRenderFragment seq) = source { yield! children }

    static member inline span(v: float) = span { v }
    static member inline span(v: int) = span { v }
    static member inline span(v: NodeRenderFragment) = span { v }
    static member inline span(v: string) = span { v }
    static member inline span(attrs: AttrRenderFragment seq) = span { html.mergeAttrs attrs }
    static member inline span(children: NodeRenderFragment seq) = span { yield! children }

    static member inline strong(v: float) = strong { v }
    static member inline strong(v: int) = strong { v }
    static member inline strong(v: NodeRenderFragment) = strong { v }
    static member inline strong(v: string) = strong { v }
    static member inline strong(attrs: AttrRenderFragment seq) = strong { html.mergeAttrs attrs }
    static member inline strong(children: NodeRenderFragment seq) = strong { yield! children }

    static member inline style(v: string) = styleElt { v }

    static member inline sub(v: float) = sub { v }
    static member inline sub(v: int) = sub { v }
    static member inline sub(v: NodeRenderFragment) = sub { v }
    static member inline sub(v: string) = sub { v }
    static member inline sub(attrs: AttrRenderFragment seq) = sub { html.mergeAttrs attrs }
    static member inline sub(children: NodeRenderFragment seq) = sub { yield! children }

    static member inline summary(v: float) = summary { v }
    static member inline summary(v: int) = summary { v }
    static member inline summary(v: NodeRenderFragment) = summary { v }
    static member inline summary(v: string) = summary { v }
    static member inline summary(attrs: AttrRenderFragment seq) = summary { html.mergeAttrs attrs }
    static member inline summary(children: NodeRenderFragment seq) = summary { yield! children }

    static member inline sup(v: float) = sup { v }
    static member inline sup(v: int) = sup { v }
    static member inline sup(v: NodeRenderFragment) = sup { v }
    static member inline sup(v: string) = sup { v }
    static member inline sup(attrs: AttrRenderFragment seq) = sup { html.mergeAttrs attrs }
    static member inline sup(children: NodeRenderFragment seq) = sup { yield! children }

    static member inline table(attrs: AttrRenderFragment seq) = table { html.mergeAttrs attrs }
    static member inline table(children: NodeRenderFragment seq) = table { yield! children }

    static member inline tableBody(attrs: AttrRenderFragment seq) = tbody { html.mergeAttrs attrs }
    static member inline tableBody(children: NodeRenderFragment seq) = tbody { yield! children }

    static member inline tableCell(attrs: AttrRenderFragment seq) = td { html.mergeAttrs attrs }
    static member inline tableCell(children: NodeRenderFragment seq) = td { yield! children }

    static member inline tableHeader(attrs: AttrRenderFragment seq) = th { html.mergeAttrs attrs }
    static member inline tableHeader(children: NodeRenderFragment seq) = th { yield! children }

    static member inline tableRow(attrs: AttrRenderFragment seq) = tr { html.mergeAttrs attrs }
    static member inline tableRow(children: NodeRenderFragment seq) = tr { yield! children }

    static member inline tbody(attrs: AttrRenderFragment seq) = tbody { html.mergeAttrs attrs }
    static member inline tbody(children: NodeRenderFragment seq) = tbody { yield! children }

    static member inline td(v: float) = td { v }
    static member inline td(v: int) = td { v }
    static member inline td(v: NodeRenderFragment) = td { v }
    static member inline td(v: string) = td { v }
    static member inline td(attrs: AttrRenderFragment seq) = td { html.mergeAttrs attrs }
    static member inline td(children: NodeRenderFragment seq) = td { yield! children }

    static member inline template(attrs: AttrRenderFragment seq) = template { html.mergeAttrs attrs }
    static member inline template(children: NodeRenderFragment seq) = template { yield! children }

    static member inline textarea(attrs: AttrRenderFragment seq) = textarea { html.mergeAttrs attrs }
    static member inline textarea(children: NodeRenderFragment seq) = textarea { yield! children }

    static member inline tfoot(attrs: AttrRenderFragment seq) = tfoot { html.mergeAttrs attrs }
    static member inline tfoot(children: NodeRenderFragment seq) = tfoot { yield! children }

    static member inline th(v: float) = th { v }
    static member inline th(v: int) = th { v }
    static member inline th(v: NodeRenderFragment) = th { v }
    static member inline th(v: string) = th { v }
    static member inline th(attrs: AttrRenderFragment seq) = th { html.mergeAttrs attrs }
    static member inline th(children: NodeRenderFragment seq) = th { yield! children }

    static member inline thead(attrs: AttrRenderFragment seq) = thead { html.mergeAttrs attrs }
    static member inline thead(children: NodeRenderFragment seq) = thead { yield! children }

    static member inline time(attrs: AttrRenderFragment seq) = time { html.mergeAttrs attrs }
    static member inline time(children: NodeRenderFragment seq) = time { yield! children }

    static member inline tr(attrs: AttrRenderFragment seq) = tr { html.mergeAttrs attrs }
    static member inline tr(children: NodeRenderFragment seq) = tr { yield! children }

    static member inline track(attrs: AttrRenderFragment seq) = track { html.mergeAttrs attrs }
    static member inline track(children: NodeRenderFragment seq) = track { yield! children }

    static member inline u(v: float) = u { v }
    static member inline u(v: int) = u { v }
    static member inline u(v: NodeRenderFragment) = u { v }
    static member inline u(v: string) = u { v }
    static member inline u(attrs: AttrRenderFragment seq) = u { html.mergeAttrs attrs }
    static member inline u(children: NodeRenderFragment seq) = u { yield! children }

    static member inline ul(attrs: AttrRenderFragment seq) = ul { html.mergeAttrs attrs }
    static member inline ul(children: NodeRenderFragment seq) = ul { yield! children }

    static member inline unorderedList(attrs: AttrRenderFragment seq) = li { html.mergeAttrs attrs }
    static member inline unorderedList(children: NodeRenderFragment seq) = ul { yield! children }

    static member inline var(v: float) = var { v }
    static member inline var(v: int) = var { v }
    static member inline var(v: NodeRenderFragment) = var { v }
    static member inline var(v: string) = var { v }
    static member inline var(attrs: AttrRenderFragment seq) = var { html.mergeAttrs attrs }
    static member inline var(children: NodeRenderFragment seq) = var { yield! children }

    static member inline video(attrs: AttrRenderFragment seq) = video { html.mergeAttrs attrs }
    static member inline video(children: NodeRenderFragment seq) = video { yield! children }

    static member inline wbr(attrs: AttrRenderFragment seq) = wbr { html.mergeAttrs attrs }
