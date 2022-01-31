[<AutoOpen>]
module Fun.Blazor.FelizDsl

open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components


type FunBlazorSvgEngine(mk, ofStr, empty) =
    inherit Feliz.SvgEngine<NodeRenderFragment>(mk, ofStr, empty)


type FunBlazorAttrEngine(mk, mkBool) =
    inherit Feliz.AttrEngine<AttrRenderFragment>(mk, mkBool)

    member inline _.ref([<InlineIfLambda>] fn: ElementReference -> unit) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, fn)
            index + 1
        )

    member inline _.childContent(nodes: NodeRenderFragment seq) =
        AttrRenderFragment(fun comp builder index -> (nodes |> Seq.fold (>=>) emptyNode).Invoke(comp, builder, index))

    member inline _.childContent(x: string) =
        AttrRenderFragment(fun comp builder index -> (html.text x).Invoke(comp, builder, index))
    
    member inline _.childContent(x: int) =
        AttrRenderFragment(fun comp builder index -> (html.text x).Invoke(comp, builder, index))
    
    member inline _.childContent(x: float) =
        AttrRenderFragment(fun comp builder index -> (html.text x).Invoke(comp, builder, index))

    member inline _.styles x = html.styles x

    member inline _.value x = "value" => x


let svg =
    FunBlazorSvgEngine((fun tag nodes -> EltBuilder tag { yield! nodes }), html.text, (fun () -> emptyNode))

let attr =
    FunBlazorAttrEngine((fun k v -> k => v), (fun k v -> if v then k => null else emptyAttr))

let style = Feliz.CssEngine(fun k v -> k, v)
