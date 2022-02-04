[<AutoOpen>]
module Fun.Blazor.Bolero

open System
open Bolero
open Bolero.Html
open Microsoft.AspNetCore.Components


let private matchCache = lazy (fun () -> Render.makeMatchCache ())


type html with

    /// Resuse bolero render function directly
    static member bolero(node: Node, ?cache) =
        NodeRenderFragment(fun comp builder index -> 
            let cache = defaultArg cache matchCache
            Render.renderNode comp builder (cache.Value()) index node
        )


    /// Will wrap fragment with a section.
    /// In this way we can avoid create a component for it. So it is lighter.
    static member funFragment(fragment: NodeRenderFragment) =
        Html.section [
            ExplicitAttr(
                Func<_, _, _, _>(fun builder index comp ->
                    fragment.Invoke(unbox<IComponent> comp, builder, index)
                )
            )
        ] []


    /// Wrap fragment with a component.
    static member funComponent(fragment: NodeRenderFragment) =
        Html.comp<FunFragmentComponent> [
            "Fragment" => fragment
        ] []


type EltWithChildBuilder with
    member _.Yield(x: Node) = Fun.Blazor.html.bolero x


type FragmentBuilder with
    member _.Yield(x: Node) = Fun.Blazor.html.bolero x


type ComponentWithChildBuilder<'T when 'T :> IComponent> with
    member _.Yield(x: Node) = Fun.Blazor.html.bolero x


type ComponentWithDomAndChildAttrBuilder<'T when 'T :> IComponent> with
    member _.Yield(x: Node) = Fun.Blazor.html.bolero x
