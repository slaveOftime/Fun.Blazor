namespace Fun.Blazor

open System
open Bolero

type html() =

    static member fragment x = ForEach x

    /// With this, we can add any Bolero.Node to the attribute which expect RenderFragment.
    /// Sometimes third party libray will have complex attributes which will be used to inject other components in.
    /// Those complex atrribute types cannot be generated automatically by the cli.
    static member renderFragment(node: Bolero.Node) =
        Microsoft.AspNetCore.Components.RenderFragment(fun tb ->
            tb.OpenComponent<SingleNodeComponent>(1)
            tb.AddAttribute(2, "Node", node)
            tb.CloseComponent()
        )

    /// With this, we can add any Bolero.Node to the attribute which expect RenderFragment.
    /// Sometimes third party libray will have complex attributes which will be used to inject other components in.
    /// Those complex atrribute types cannot be generated automatically by the cli.
    static member renderFragment(nodes: Bolero.Node list) = html.renderFragment (html.fragment nodes)

    static member raw x = Bolero.RawHtml x

    static member html(lang: string, nodes) =
        Bolero.Html.html [ Bolero.Html.attr.lang lang ] nodes

    static member doctype decl = html.raw $"<!DOCTYPE {decl}>\n"

    static member doctypeHtml(nodes, ?lang) =
        let lang = defaultArg lang "en"
        Bolero.Concat [
            html.doctype "html"
            html.html (lang, nodes)
        ]

    static member doctypeHtml(lang: string, nodes: Node list) = html.doctypeHtml (nodes, lang)

    static member text(x: int) = Text(string x)
    static member text(x: float) = Text(string x)
    static member text(x: Guid) = Text(string x)
    static member text(x: string) = Text x

    static member title(x: string) = Elt("title", [], [ Text x ])
    static member link x = Elt("link", x, [])
    static member baseUrl(x: string) = Elt("base", [ Attr("href", x) ], [])

    static member meta(name: string, content: string) =
        Elt("meta", [ Attr("name", name); Attr("content", content) ], [])

    static member script(x: string) = Elt("script", [ Attr("src", x) ], [])

    static member scriptRaw(x: string) =
        html.raw $"""
    <script>
        {x}
    </script>
    """

    static member stylesheet(x: string) =
        html.link [
            Attr("rel", "stylesheet")
            Attr("href", x)
        ]

    static member none = Html.empty
