[<AutoOpen>]
module Fun.Blazor.DslReactive

open System
open Bolero.Html


type FunBlazorHtmlEngine with
    member html.watch (store: IObservable<'T>, render: 'T -> IFunBlazorNode, defaultValue: 'T, ?key) =
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

    member html.watch (observe: IObservable<'T>, render: 'T -> IFunBlazorNode) = html.watch (observe, render, Unchecked.defaultof<'T>)
    member html.watch (observe: IObservable<'T>, render: 'T -> IFunBlazorNode list) = html.watch (observe, render >> Fragment >> (fun x -> x :> IFunBlazorNode))
    member html.watch (key: obj, observe: IObservable<'T>, render: 'T -> IFunBlazorNode) = html.watch (observe, render, Unchecked.defaultof<'T>, key = key)
    member html.watch (key: obj, observe: IObservable<'T>, render: 'T -> IFunBlazorNode list) = html.watch (key, observe, render >> Fragment >> (fun x -> x :> IFunBlazorNode))
    
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

    member html.watch (store: IStore<'T>, render: 'T -> IFunBlazorNode) = html.watch (store.Observable, render, store.Current)
    member html.watch (store: IStore<'T>, render: 'T -> IFunBlazorNode list) = html.watch (store.Observable, render >> Fragment >> (fun x -> x :> IFunBlazorNode), store.Current)
    member html.watch (key, store: IStore<'T>, render: 'T -> IFunBlazorNode) = html.watch (store.Observable, render, store.Current, key = key)
    member html.watch (key, store: IStore<'T>, render: 'T -> IFunBlazorNode list) = html.watch (store.Observable, render >> Fragment >> (fun x -> x :> IFunBlazorNode), store.Current, key = key)
    
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
