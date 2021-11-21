[<AutoOpen>]
module Fun.Blazor.FelizDsl

open System
open Bolero
open Microsoft.AspNetCore.Components


type FunBlazorSvgEngine (mk, ofStr, empty) =
    inherit Feliz.SvgEngine<Node>(mk, ofStr, empty)


type FunBlazorAttrEngine (mk, mkBool) as this =
    inherit Feliz.AttrEngine<Attr>(mk, mkBool)
        
    member _.ref x = Bolero.Html.attr.ref x

    member _.childContent (nodes: Node list) = Attr (_childContentKey, nodes)
    member _.childContent x = this.childContent [ Bolero.Html.text x ]

    member _.styles (styles: (string * string) list) = 
        Bolero.Html.attr.style (styles |> List.map (fun (k, v) -> $"{k}: {v}") |> String.concat "; ")

    member _.value (x: obj) = Bolero.Html.attr.value x

    member _.callbackOfUnit (name, fn) =
        ExplicitAttr (Func<_,_,_,_>(fun builder sequence receiver ->
            builder.AddAttribute(sequence, name, EventCallback.Factory.Create(receiver, Action(fn)))
            sequence + 1))


type html with    
    static member blazor<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> (nodes: Attr list) =
        let attrs, childContent = getAttrsAndChildren nodes
        Bolero.Html.comp<'Component> attrs childContent

    static member meta x = Elt ("meta", x, [])
    

let svg = FunBlazorSvgEngine((fun tag nodes -> Elt(tag, [], List.ofSeq nodes)), Text >> (fun x -> x), (fun () -> Html.empty))

let attr = FunBlazorAttrEngine((fun k v -> Attr(k, v)), (fun k v -> if v then Attr(k, "") else Attrs []))

let style = Feliz.CssEngine(fun k v -> k, v)
