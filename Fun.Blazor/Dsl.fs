namespace Fun.Blazor

open System
open Bolero
open Bolero.Html
open Microsoft.AspNetCore.Components


type FunBlazorHtmlEngine (mk, ofStr, ofNode, empty) =
    inherit FunHtmlEngine<Attr, Node>(mk, ofStr, ofNode, empty)

    member _.blazor<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> (nodes: Attr list) =
        let attrs, childContent = getAttrsAndChildren nodes
        Bolero.Html.comp<'Component> attrs childContent

    member _.fragment x = ForEach x

    member html.raw x = Bolero.RawHtml x

    member html.html (lang: string, nodes) = Bolero.Html.html [ Bolero.Html.attr.lang lang ] nodes 

    member html.doctype decl = html.raw $"<!DOCTYPE {decl}>\n"

    member html.doctypeHtml (nodes, ?lang) =
        let lang = defaultArg lang "en"
        Bolero.Concat [
            html.doctype "html"
            html.html (lang, nodes)
        ]

    member html.doctypeHtml (lang: string, nodes: Node list) = html.doctypeHtml (nodes, lang)

    member html.text (x: int) = Text (string x)
    member html.text (x: float) = Text (string x)
    member html.text (x: Guid) = Text (string x)
    member html.text (x: string) = Text x

    member html.title (x: string) = Elt ("title", [], [ Text x ])
    member html.link x = Elt ("link", x, [])
    member html.baseUrl x = Elt ("base", [ Attr ("href", x) ], [])
    
    member html.meta x = html.custom ("meta", x)

    member html.meta (name, content) = Elt ("meta", [ Attr ("name", name); Attr ("content", content) ], [])

    member html.script x = Elt ("script", [ Attr ("src", x) ], [])
    member html.scriptRaw x = html.script [ html.raw x ]
    member html.stylesheet x = html.link [ Attr ("rel", "stylesheet"); Attr ("href", x) ]


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

    
[<AutoOpen>]
module Dsl =
    let html =
        FunBlazorHtmlEngine
            (fun tag nodes ->
                let attrs, childs = getAttrsAndChildren nodes
                Elt(tag, attrs, childs)
            ,fun x -> Text x
            ,fun x -> Attr (_childContentKey, x)
            ,fun () -> Html.empty)

    let svg = FunBlazorSvgEngine((fun tag nodes -> Elt(tag, [], List.ofSeq nodes)), Text >> (fun x -> x), (fun () -> Html.empty))

    let attr = FunBlazorAttrEngine((fun k v -> Attr(k, Choice1Of2 v)), (fun k v -> Attr(k, Choice2Of2 v)))

    let style = Feliz.CssEngine(fun k v -> k, v)


module evts = on
