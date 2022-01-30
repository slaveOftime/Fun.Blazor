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

    member inline _.childContent(nodes: NodeRenderFragment seq) = nodes |> Seq.fold (>=>) emptyNode
    member inline _.childContent(x: string) = html.text x
    member inline _.childContent(x: int) = html.text x
    member inline _.childContent(x: float) = html.text x

    member inline _.styles x = html.styles x

    member inline _.value x = "value" => x


let svg =
    FunBlazorSvgEngine((fun tag nodes -> EltBuilder tag { yield! nodes }), html.text, (fun () -> emptyNode))

let attr =
    FunBlazorAttrEngine((fun k v -> k => v), (fun k v -> if v then k => null else emptyAttr))

let styl = Feliz.CssEngine(fun k v -> k, v)
