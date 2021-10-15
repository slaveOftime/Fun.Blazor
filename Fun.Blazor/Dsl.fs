namespace Fun.Blazor

open System
open Bolero.Html


type FunBlazorHtmlEngine (mk, ofStr, empty) =
    inherit Feliz.HtmlEngine<IFunBlazorNode>(mk, ofStr, empty)

    member _.toBolero x = FunBlazorNode.ToBolero x

    member _.blazor<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> (nodes: IFunBlazorNode list) =
        let nodes, attrs = nodes |> FunBlazorNode.GetBoleroNodesAndAttrs
        BoleroNode (Bolero.Html.comp<'Component> attrs nodes) :> IFunBlazorNode

    member _.bolero x = BoleroNode x :> IFunBlazorNode

    member _.fragment x = Fragment x :> IFunBlazorNode

    member html.raw x = Bolero.RawHtml x |> BoleroNode :> IFunBlazorNode

    member html.html (lang: string, nodes) = Bolero.Html.html [ Bolero.Html.attr.lang lang ] (nodes |> List.map FunBlazorNode.ToBolero) |> BoleroNode

    member html.doctype decl = html.raw $"<!DOCTYPE {decl}>\n"

    member html.doctypeHtml (nodes, ?lang) =
        let lang = defaultArg lang "en"
        Bolero.Concat [
            html.doctype "html" |> html.toBolero
            html.html (lang, nodes) |> html.toBolero
        ]

    member html.doctypeHtml (lang: string, nodes: IFunBlazorNode list) = html.doctypeHtml (nodes, lang)

    member html.title (x: string) = html.custom ("title", [ html.text x ])
    member html.link x = html.custom ("link", x)
    member html.baseUrl x = html.custom ("base", [ Attr ("href", Choice1Of2 x) ])
    
    member html.meta x = html.custom ("meta", x)

    member html.meta (name, content) = 
        html.custom ("meta", [ 
            Bolero.Attr ("name", name) |> BoleroAttr
            Bolero.Attr ("content", content) |> BoleroAttr
        ])

    member html.script x = html.script [ Attr ("src", Choice1Of2 x) :> IFunBlazorNode ]
    member html.scriptRaw x = html.script [ html.raw x ]
    member html.stylesheet x = html.link [ Attr ("rel", Choice1Of2 "stylesheet"); Attr ("href", Choice1Of2 x) ]


type FunBlazorSvgEngine (mk, ofStr, empty) =
    inherit Feliz.SvgEngine<IFunBlazorNode>(mk, ofStr, empty)


type FunBlazorAttrEngine (mk, mkBool) =
    inherit Feliz.AttrEngine<IFunBlazorNode>(mk, mkBool)
        
    member _.ref x = Bolero.Html.attr.ref x |> BoleroAttr

    member _.childContent nodes = Fragment nodes :> IFunBlazorNode
    member _.childContent x = BoleroNode (Bolero.Html.text x) :> IFunBlazorNode

    member _.events attrs = BoleroAttrs attrs :> IFunBlazorNode

    member _.styles (styles: (string * string) list) = 
        Bolero.Html.attr.style (styles |> List.map (fun (k, v) -> $"{k}: {v}") |> String.concat "; ")
        |> BoleroAttr
        :> IFunBlazorNode

    member _.value (x: obj) = BoleroAttr (Bolero.Html.attr.value x) :> IFunBlazorNode


[<AutoOpen>]
module Dsl =
    let html = FunBlazorHtmlEngine((fun tag nodes -> Elt(tag, List.ofSeq nodes) :> IFunBlazorNode), Text >> (fun x -> x :> IFunBlazorNode), (fun () -> Fragment [] :> IFunBlazorNode))

    let svg = FunBlazorSvgEngine((fun tag nodes -> Elt(tag, List.ofSeq nodes) :> IFunBlazorNode), Text >> (fun x -> x :> IFunBlazorNode), (fun () -> Fragment [] :> IFunBlazorNode))

    let attr = FunBlazorAttrEngine((fun k v -> Attr(k, Choice1Of2 v) :> IFunBlazorNode), (fun k v -> Attr(k, Choice2Of2 v) :> IFunBlazorNode))

    let style = Feliz.CssEngine(fun k v -> k, v)
