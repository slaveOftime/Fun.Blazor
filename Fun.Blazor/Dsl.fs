namespace Fun.Blazor

open System
open Bolero.Html
open Elmish
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing


type FunBlazorHtmlEngine (mk, ofStr, empty) =
    inherit Feliz.HtmlEngine<FunBlazorNode>(mk, ofStr, empty)

    member _.toBolero x = FunBlazorNode.ToBolero x

    member _.blazor<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> (nodes: FunBlazorNode list) =
        let nodes, attrs = nodes |> FunBlazorNode.GetBoleroNodesAndAttrs
        BoleroNode (Bolero.Html.comp<'Component> attrs nodes)

    member _.bolero x = BoleroNode x


    member html.watch (defaultValue: 'T, store: IObservable<'T>, render: 'T -> FunBlazorNode, ?key) =
        html.bolero 
            (Bolero.Node.BlazorComponent<StoreComponent<'T>>
                ([
                    "DefaultValue" => defaultValue
                    "Store" => store
                    "RenderFn" => render
                    match key with
                    | Some key -> Bolero.Key key
                    | None -> ()
                ]
                ,[]))

    member html.watch (store: IObservable<'T>, render: 'T -> FunBlazorNode, ?key) = html.watch (Unchecked.defaultof<'T>, store, render, key = Option.defaultWith (fun () -> System.Random().Next() |> box) key)
    member html.watch (key, store: IObservable<'T>, render: 'T -> FunBlazorNode) = html.watch (Unchecked.defaultof<'T>, store, render, key = key)
    member html.watch (store: IStore<'T>, render: 'T -> FunBlazorNode, ?key) = html.watch (store.Current, store.Observable, render, key = Option.defaultWith (fun () -> System.Random().Next() |> box) key)
    member html.watch (store: IStore<'T>, render: 'T -> FunBlazorNode list, ?key) = html.watch (store.Current, store.Observable, render >> Fragment, key = Option.defaultWith (fun () -> System.Random().Next() |> box) key)
    member html.watch (key, store: IStore<'T>, render: 'T -> FunBlazorNode) = html.watch (store.Current, store.Observable, render, key = key)


    member html.inject (render: 'T -> FunBlazorNode) =
        html.bolero 
            (Bolero.Node.BlazorComponent<DIComponent<'T>>
                ([
                    "RenderFn" => render
                    Bolero.Key (Guid.NewGuid().ToString())
                ]
                ,[]))

    member html.inject (key: obj, render: 'T -> FunBlazorNode) =
        html.bolero 
            (Bolero.Node.BlazorComponent<DIComponent<'T>>
                ([
                    "RenderFn" => render
                    Bolero.Key key
                ]
                ,[]))


    member html.elmish 
        (initState: unit -> 'Model * Cmd<'Msg>
        ,updateState: 'Msg -> 'Model -> 'Model * Cmd<'Msg>
        ,render: 'Model -> Dispatch<'Msg> -> FunBlazorNode
        ,?mapProgram: Bolero.Program<'Model, 'Msg> -> Bolero.Program<'Model, 'Msg>)
        =
        html.bolero 
            (Bolero.Node.BlazorComponent<ElmComponent<'Model, 'Msg>>
                ([
                    "Init" => initState
                    "Update" => updateState
                    "Render" => render
                    "MapProgram" => Option.defaultValue id mapProgram
                ]
                ,[]))

    member html.elmish (init, update, render, router) =
        html.elmish(init, update, render, Bolero.Program.withRouter router)


    member _.fragment x = Fragment x

    member html.raw x = Bolero.RawHtml x |> BoleroNode

    member html.html (lang: string, nodes) = Bolero.Html.html [ Bolero.Html.attr.lang lang ] (nodes |> List.map FunBlazorNode.ToBolero) |> BoleroNode

    member html.title (x: string) = html.custom ("title", [ html.text x ])
    member html.link x = html.custom ("link", x)
    member html.baseUrl x = html.custom ("base", [ Attr ("href", Choice1Of2 x) ])
    
    member html.meta x = html.custom ("meta", x)

    member html.meta (name, content) = 
        html.custom ("meta", [ 
            Bolero.Attr ("name", name) |> BoleroAttr
            Bolero.Attr ("content", content) |> BoleroAttr
        ])

    member html.script x = html.script [ Attr ("src", Choice1Of2 x) ]
    member html.scriptRaw x = html.script [ html.raw x ]
    member html.stylesheet x = html.link [ Attr ("rel", Choice1Of2 "stylesheet"); Attr ("href", Choice1Of2 x) ]
    
    member html.route (render: string list -> FunBlazorNode) = html.inject (fun (lifecycle: IComponentHook, nav: NavigationManager, interception: INavigationInterception, localStore: ILocalStore) ->
        let location = localStore.Create nav.Uri

        lifecycle.OnAfterRender.Add (function
            | true ->
                interception.EnableNavigationInterceptionAsync() |> ignore
                nav.LocationChanged.Add (fun e -> location.Publish e.Location)
            | false ->
                ())

        html.watch (location, fun loc ->
            Router.urlSegments (Uri loc).PathAndQuery RouteMode.Path
            |> render
        ))


type FunBlazorSvgEngine (mk, ofStr, empty) =
    inherit Feliz.SvgEngine<FunBlazorNode>(mk, ofStr, empty)


type FunBlazorAttrEngine (mk, mkBool) =
    inherit Feliz.AttrEngine<FunBlazorNode>(mk, mkBool)
    
    member _.childContent nodes = Fragment nodes
    member _.childContent x = BoleroNode (Bolero.Html.text x)

    member _.events attrs = BoleroAttrs attrs

    member _.styles (styles: (string * string) list) = 
        Bolero.Html.attr.style (styles |> List.map (fun (k, v) -> $"{k}: {v}") |> String.concat "; ")
        |> BoleroAttr

    member _.value (x: obj) = BoleroAttr (Bolero.Html.attr.value x)


[<AutoOpen>]
module Dsl =
    let html = FunBlazorHtmlEngine((fun tag nodes -> Elt(tag, List.ofSeq nodes)), Text, (fun () -> Fragment []))

    let svg = FunBlazorSvgEngine((fun tag nodes -> Elt(tag, List.ofSeq nodes)), Text, (fun () -> Fragment []))

    let attr = FunBlazorAttrEngine((fun k v -> Attr(k, Choice1Of2 v)), (fun k v -> Attr(k, Choice2Of2 v)))

    let style = Feliz.CssEngine(fun k v -> k, v)

