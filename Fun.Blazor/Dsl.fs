namespace Fun.Blazor

open System
open Bolero.Html
open Elmish
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Routing
open Fun.Blazor.Router


type FunBlazorHtmlEngine (mk, ofStr, empty) =
    inherit Feliz.HtmlEngine<IFunBlazorNode>(mk, ofStr, empty)

    member _.toBolero x = FunBlazorNode.ToBolero x

    member _.blazor<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent> (nodes: IFunBlazorNode list) =
        let nodes, attrs = nodes |> FunBlazorNode.GetBoleroNodesAndAttrs
        BoleroNode (Bolero.Html.comp<'Component> attrs nodes) :> IFunBlazorNode

    member _.bolero x = BoleroNode x :> IFunBlazorNode


    member html.watch (defaultValue: 'T, store: IObservable<'T>, render: 'T -> IFunBlazorNode, ?key) =
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

    member html.watch (observe: IObservable<'T>, render: 'T -> IFunBlazorNode) = html.watch (Unchecked.defaultof<'T>, observe, render, key = box observe)
    member html.watch (observe: IObservable<'T>, render: 'T -> IFunBlazorNode list) = html.watch (observe, render >> Fragment >> (fun x -> x :> IFunBlazorNode))
    
    member html.watch2 (observe1: IObservable<'T1>, observe2: IObservable<'T2>, render: 'T1 -> 'T2 -> IFunBlazorNode) =
        html.watch (observe1, fun o1 ->
            html.watch (observe2, fun o2 ->
                render o1 o2))

    member html.watch2 (observe1: IObservable<'T1>, observe2: IObservable<'T2>, render: 'T1 -> 'T2 -> IFunBlazorNode list) =
        html.watch2 (observe1, observe2, fun o1 o2 -> render o1 o2 |> Fragment :> IFunBlazorNode)

    member html.watch3 (observe1: IObservable<'T1>, observe2: IObservable<'T2>, observe3: IObservable<'T3>, render: 'T1 -> 'T2 -> 'T3 -> IFunBlazorNode list) =
        html.watch (observe1, fun o1 ->
            html.watch (observe2, fun o2 ->
                html.watch (observe3, fun o3 ->
                    render o1 o2 o3)))

    member html.watch3 (observe1: IObservable<'T1>, observe2: IObservable<'T2>, observe3: IObservable<'T3>, render: 'T1 -> 'T2 -> 'T3 -> IFunBlazorNode) =
        html.watch3 (observe1, observe2, observe3, fun o1 o2 o3 -> [ render o1 o2 o3 ])

    member html.watch (store: IStore<'T>, render: 'T -> IFunBlazorNode) = html.watch (store.Current, store.Observable, render, key = store)
    member html.watch (store: IStore<'T>, render: 'T -> IFunBlazorNode list) = html.watch (store.Current, store.Observable, render >> Fragment >> (fun x -> x :> IFunBlazorNode), key = store)
    
    member html.watch2 (store1: IStore<'T1>, store2: IStore<'T2>, render: 'T1 -> 'T2 -> IFunBlazorNode) =
        html.watch (store1, fun s1 ->
            html.watch (store2, fun s2 ->
                render s1 s2))

    member html.watch2 (store1: IStore<'T1>, store2: IStore<'T2>, render: 'T1 -> 'T2 -> IFunBlazorNode list) =
        html.watch2 (store1, store2, fun s1 s2 -> render s1 s2 |> Fragment :> IFunBlazorNode)

    member html.watch3 (store1: IStore<'T1>, store2: IStore<'T2>, store3: IStore<'T3>, render: 'T1 -> 'T2 -> 'T3 -> IFunBlazorNode list) =
        html.watch (store1, fun s1 ->
            html.watch (store2, fun s2 ->
                html.watch (store3, fun s3 ->
                    render s1 s2 s3)))

    member html.watch3 (store1: IStore<'T1>, store2: IStore<'T2>, store3: IStore<'T3>, render: 'T1 -> 'T2 -> 'T3 -> IFunBlazorNode) =
        html.watch3 (store1, store2, store3, fun s1 s2 s3 -> [ render s1 s2 s3 ])

    member html.inject (render: 'T -> IFunBlazorNode) =
        html.bolero 
            (Bolero.Node.BlazorComponent<DIComponent<'T>>
                ([
                    "RenderFn" => render
                    Bolero.Key (Guid.NewGuid().ToString())
                ]
                ,[]))

    member html.inject (key: obj, render: 'T -> IFunBlazorNode) =
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
        ,render: 'Model -> Dispatch<'Msg> -> IFunBlazorNode
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

    member html.elmish (init, update, render) =
        html.elmish
            (fun () -> init(), Cmd.none
            ,fun msg model -> update msg model, Cmd.none
            ,render)


    member _.fragment x = Fragment x :> IFunBlazorNode

    member html.raw x = Bolero.RawHtml x |> BoleroNode :> IFunBlazorNode

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

    member html.script x = html.script [ Attr ("src", Choice1Of2 x) :> IFunBlazorNode ]
    member html.scriptRaw x = html.script [ html.raw x ]
    member html.stylesheet x = html.link [ Attr ("rel", Choice1Of2 "stylesheet"); Attr ("href", Choice1Of2 x) ]
    
    member html.route (render: string list -> IFunBlazorNode) = html.inject (fun (hook: IComponentHook, nav: NavigationManager, interception: INavigationInterception) ->
        let location = hook.UseStore nav.Uri

        hook.OnAfterRender.Subscribe (function
            | true ->
                interception.EnableNavigationInterceptionAsync() |> ignore
                nav.LocationChanged.Subscribe (fun e -> try location.Publish e.Location with _ -> ()) |> hook.AddDispose
            | false ->
                ())
            |> hook.AddDispose

        html.watch (location, fun loc ->
            RouterUtils.urlSegments (Uri loc).PathAndQuery RouteMode.Path
            |> render
        ))

    member html.route (routes: Router<IFunBlazorNode> list) = html.inject (fun (hook: IComponentHook, nav: NavigationManager, interception: INavigationInterception) ->
        let location = hook.UseStore (Uri nav.Uri).PathAndQuery

        hook.OnAfterRender.Subscribe (function
            | true ->
                interception.EnableNavigationInterceptionAsync() |> ignore
                nav.LocationChanged.Subscribe (fun e -> try location.Publish (Uri e.Location).PathAndQuery with _ -> ()) |> hook.AddDispose
            | false ->
                ())
            |> hook.AddDispose

        html.watch (location, choose routes >> Option.defaultValue html.none))


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

