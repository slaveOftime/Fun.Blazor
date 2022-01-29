namespace Fun.Blazor

open System
open Microsoft.AspNetCore.Components
open Operators


type html() =

    static member inline none = emptyRender

    static member inline fragment = FragmentBuilder()

    static member inline elt name = EltBuilder name

    static member inline comp<'T when 'T :> IComponent>() = ComponentBuilder<'T>()

    static member inline key k =
        FunRenderFragment(fun builder index ->
            builder.SetKey k
            index
        )


    /// With this, we can add any FunBlazor fragment to the attribute which expect RenderFragment.
    /// Sometimes third party libray will have complex attributes which will be used to inject other components in.
    /// Those complex atrribute types cannot be generated automatically by the cli.
    static member inline renderFragment(render: FunRenderFragment) =
        Microsoft.AspNetCore.Components.RenderFragment(fun builder -> render.Invoke(builder, 0) |> ignore)

    static member inline raw x =
        FunRenderFragment(fun builder index ->
            builder.AddMarkupContent(index, x)
            index + 1
        )


    //static member doctypeHtml(nodes, ?lang) =
    //    html.fragment {
    //        html.doctype "html"

    //        html.html {
    //            "lang" => (defaultArg lang "en")

    //        }
    //    }

    //static member doctypeHtml(lang: string, nodes: Node list) = html.doctypeHtml (nodes, lang)

    static member inline text(x: int) =
        FunRenderFragment(fun builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member text(x: float) =
        FunRenderFragment(fun builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member text(x: Guid) =
        FunRenderFragment(fun builder index ->
            builder.AddContent(index, string x)
            index + 1
        )

    static member inline text(x: string) =
        FunRenderFragment(fun builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    static member inline style(x: string) = "style" => x
    static member inline class'(x: string) = "class" => x
    static member inline classes(x: string seq) = "class" => (String.concat " " x)

    //static member title(x: string) = Elt("title", [], [ Text x ])
    //static member link x = Elt("link", x, [])
    //static member baseUrl(x: string) = Elt("base", [ Attr("href", x) ], [])

    static member meta(name: string, content: string) =
        html.elt "meta" {
            "name" => name
            "content" => content
        }

    static member script(x: string) = html.elt "script" { "src" => x }

    static member scriptRaw(x: string) =
        html.raw
            $"""
    <script>
        {x}
    </script>
    """

//static member stylesheet(x: string) =
//    html.link [ Attr("rel", "stylesheet"); Attr("href", x) ]
