namespace Fun.Blazor

open System
open Microsoft.AspNetCore.Components
open Operators


type html() =

    static member inline none = emptyNode

    static member inline fragment = fragment

    static member inline comp<'T when 'T :> IComponent>() = ComponentBuilder<'T>()

    static member inline key k =
        AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
            index
        )


    /// With this, we can add any FunBlazor fragment to the attribute which expect RenderFragment.
    /// Sometimes third party libray will have complex attributes which will be used to inject other components in.
    /// Those complex atrribute types cannot be generated automatically by the cli.
    static member inline renderFragment(render: NodeRenderFragment) =
        Microsoft.AspNetCore.Components.RenderFragment(fun builder -> render.Invoke(null, builder, 0) |> ignore)

    static member inline raw x =
        NodeRenderFragment(fun _ builder index ->
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
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member text(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, box x)
            index + 1
        )

    static member text(x: Guid) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, string x)
            index + 1
        )

    static member inline text(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    static member inline style(x: string) = "style" => x
    static member inline class'(x: string) = "class" => x
    static member inline classes(x: string seq) = "class" => (String.concat " " x)
