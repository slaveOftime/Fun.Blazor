namespace Fun.Blazor

open System
open Bolero.Html
open Elmish
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing


type BoleroHtmlEngine (mk, ofStr, empty) =
    inherit Feliz.HtmlEngine<FelizNode>(mk, ofStr, empty)

    member _.toBolero x = FelizNode.ToBoleroNode x

    member _.blazor<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> (nodes: FelizNode list) =
        let nodes, attrs = nodes |> FelizNode.GetBoleroNodesAndAttrs
        BoleroNode (Bolero.Html.comp<'Component> attrs nodes)

    member _.bolero x = BoleroNode x


    member html.watch (defaultValue: 'T, store: IObservable<'T>, render: 'T -> FelizNode, ?key) =
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

    member html.watch (store: IObservable<'T>, render: 'T -> FelizNode, ?key) = html.watch (Unchecked.defaultof<'T>, store, render, key = Option.defaultWith (fun () -> System.Random().Next() |> box) key)
    member html.watch (key, store: IObservable<'T>, render: 'T -> FelizNode) = html.watch (Unchecked.defaultof<'T>, store, render, key = key)
    member html.watch (store: IStore<'T>, render: 'T -> FelizNode, ?key) = html.watch (store.Current, store.Observable, render, key = Option.defaultWith (fun () -> System.Random().Next() |> box) key)
    member html.watch (key, store: IStore<'T>, render: 'T -> FelizNode) = html.watch (store.Current, store.Observable, render, key = key)


    member html.inject (render: 'T -> FelizNode) =
        html.bolero 
            (Bolero.Node.BlazorComponent<DIComponent<'T>>
                ([
                    "RenderFn" => render
                    Bolero.Key (Guid.NewGuid().ToString())
                ]
                ,[]))

    member html.inject (key: obj, render: 'T -> FelizNode) =
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
        ,render: 'Model -> Dispatch<'Msg> -> FelizNode
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


    member html.raw x = Bolero.RawHtml x |> BoleroNode

    member html.doctype (nodes) = Bolero.Server.Html.doctypeHtml [] (nodes |> List.map FelizNode.ToBoleroNode) |> BoleroNode
    member html.html (lang: string, nodes) = Bolero.Html.html [ Bolero.Html.attr.lang lang ] (nodes |> List.map FelizNode.ToBoleroNode) |> BoleroNode

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
    
    member html.route (render) = html.inject (fun (lifecycle: IComponentLifecycle, nav: NavigationManager, interception: INavigationInterception, localStore: ILocalStore) ->
        let location = localStore.Create nav.Uri

        lifecycle.AfterRender.Add (function
            | true ->
                interception.EnableNavigationInterceptionAsync() |> ignore
                nav.LocationChanged.Add (fun e -> location.Publish e.Location)
            | false ->
                ())

        html.watch (location, fun loc ->
            Router.urlSegments (Uri loc).PathAndQuery RouteMode.Path
            |> render
        ))


type BoleroAttrEngine (mk, mkBool) =
    inherit Feliz.AttrEngine<FelizNode>(mk, mkBool)
    
    member _.children nodes = Fragment nodes
    member _.children x = BoleroNode (Bolero.Html.text x)

    member _.events attrs = BoleroAttrs attrs

    member _.styles (styles: (string * string) list) = 
        Bolero.Html.attr.style (styles |> List.map (fun (k, v) -> $"{k}: {v}") |> String.concat "; ")
        |> BoleroAttr

    member _.value (x: obj) = BoleroAttr (Bolero.Html.attr.value x)


[<AutoOpen>]
module Dsl =
    let html = BoleroHtmlEngine((fun tag nodes -> Elt(tag, List.ofSeq nodes)), Text, (fun () -> Fragment []))

    let attr = BoleroAttrEngine((fun k v -> Attr(k, Choice1Of2 v)), (fun k v -> Attr(k, Choice2Of2 v)))

    let style = Feliz.CssEngine(fun k v -> k, v)
