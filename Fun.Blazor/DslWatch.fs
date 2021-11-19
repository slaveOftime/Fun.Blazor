[<AutoOpen>]
module Fun.Blazor.DslWatch

open System
open Bolero


type html with
    static member watch (store: IObservable<'T>, render: 'T -> Node, defaultValue: 'T, ?key) =
        Bolero.Node.BlazorComponent<StoreComponent<'T>>
            ([
                "DefaultValue" => defaultValue
                "Store" => store
                "RenderFn" => render
                match key with
                | Some key -> Bolero.Key key
                | None -> ()
            ]
            ,[])


    static member watch (store: IStore<'T>, render: 'T -> Node) = html.watch (store.Observable, render, store.Current)
    static member watch (store: IStore<'T>, render: 'T -> Node list) = html.watch (store.Observable, render >> ForEach, store.Current)
    static member watch (key, store: IStore<'T>, render: 'T -> Node) = html.watch (store.Observable, render, store.Current, key = key)
    static member watch (key, store: IStore<'T>, render: 'T -> Node list) = html.watch (store.Observable, render >> ForEach, store.Current, key = key)
    
    static member watch2 (store1: IStore<'T1>, store2: IStore<'T2>, render: 'T1 -> 'T2 -> Node) =
        html.watch (store1, fun s1 ->
            html.watch (store2, fun s2 ->
                render s1 s2))

    static member watch2 (store1: IStore<'T1>, store2: IStore<'T2>, render: 'T1 -> 'T2 -> Node list) =
        html.watch2 (store1, store2, fun s1 s2 -> render s1 s2 |> ForEach)

    static member watch3 (store1: IStore<'T1>, store2: IStore<'T2>, store3: IStore<'T3>, render: 'T1 -> 'T2 -> 'T3 -> Node list) =
        html.watch (store1, fun s1 ->
            html.watch (store2, fun s2 ->
                html.watch (store3, fun s3 ->
                    render s1 s2 s3)))

    static member watch3 (store1: IStore<'T1>, store2: IStore<'T2>, store3: IStore<'T3>, render: 'T1 -> 'T2 -> 'T3 -> Node) =
        html.watch3 (store1, store2, store3, fun s1 s2 s3 -> [ render s1 s2 s3 ])
