[<AutoOpen>]
module Fun.Blazor.DslWatch

open System
open Operators


type html with
    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by an observable
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View() =
    ///   // uses http://fsprojects.github.io/FSharp.Control.Reactive
    ///   let obs = Observable.interval (TimeSpan.FromSeconds(2.))
    ///
    ///   let _view num =
    ///     p() { childContent $"Number: {num}" }
    ///
    ///   html.watch(obs, _view)
    /// </code>
    /// </example>
    static member inline watch(store: IObservable<'T>, render: 'T -> NodeRenderFragment, defaultValue: 'T, ?k) =
        html.comp<StoreComponent<'T>> () {
            "DefaultValue" => defaultValue
            "Store" => store
            "RenderFn" => render
            match k with
            | Some k -> html.key k
            | None -> emptyAttr
        }

    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by the store
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View (hook: IComponentHook) =
    ///   let store = hook.UseStore 10
    ///
    ///   Observable.interval (TimeSpan.FromSeconds(2.))
    ///   // update the store every two seconds
    ///   |> Observable.subscribe store.Publish
    ///   |> hook.AddDispose
    ///
    ///   let _view num =
    ///     p() { childContent $"Number: {num}" }
    ///
    ///   html.watch(store, _view)
    /// </code>
    /// </example>
    static member watch(store: IStore<'T>, render: 'T -> NodeRenderFragment) =
        html.watch (store.Observable, render, store.Current)
    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by the store
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View (hook: IComponentHook) =
    ///   let store = hook.UseStore 10
    ///
    ///   Observable.interval (TimeSpan.FromSeconds(2.))
    ///   // update the store every two seconds
    ///   |> Observable.subscribe store.Publish
    ///   |> hook.AddDispose
    ///   let _view num =
    ///     [ p() { class' "red"; childContent $"Number: {num}" }
    ///       p() { class' "blue"; childContent $"Number: {num}" } ]
    ///
    ///   html.watch(store, _view)
    /// </code>
    /// </example>
    static member watch(store: IStore<'T>, render: 'T -> NodeRenderFragment list) =
        html.watch (store.Observable, render >> html.mergeNodes, store.Current)
    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by the store
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View (hook: IComponentHook) =
    ///   let store = hook.UseStore 10
    ///
    ///   Observable.interval (TimeSpan.FromSeconds(2.))
    ///   // update the store every two seconds
    ///   |> Observable.subscribe store.Publish
    ///   |> hook.AddDispose
    ///
    ///   let _view num =
    ///     p() { childContent $"Number: {num}" }
    ///
    ///   html.watch("my-element", store, _view)
    /// </code>
    /// </example>
    static member watch(key, store: IStore<'T>, render: 'T -> NodeRenderFragment) =
        html.watch (store.Observable, render, store.Current, k = key)
    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by the store
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View (hook: IComponentHook) =
    ///   let store = hook.UseStore 10
    ///
    ///   Observable.interval (TimeSpan.FromSeconds(2.))
    ///   // update the store every two seconds
    ///   |> Observable.subscribe store.Publish
    ///   |> hook.AddDispose
    ///
    ///   let _view num =
    ///     [ p() { class' "red"; childContent $"Number: {num}" }
    ///       p() { class' "blue"; childContent $"Number: {num}" } ]
    ///
    ///   html.watch("my-element", store, _view)
    /// </code>
    /// </example>
    static member watch(key, store: IStore<'T>, render: 'T -> NodeRenderFragment list) =
        html.watch (store.Observable, render >> html.mergeNodes, store.Current, k = key)

    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by the stores
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View (hook: IComponentHook) =
    ///   let age = hook.UseStore 10
    ///   let name = hook.UseStore "Frank"
    ///
    ///   let _view age name =
    ///     p() { childContent $"{name} is {num} years old" }
    ///
    ///   html.watch(age, name, _view)
    /// </code>
    /// </example>
    static member watch2(store1: IStore<'T1>, store2: IStore<'T2>, render: 'T1 -> 'T2 -> NodeRenderFragment) =
        html.watch (store1, (fun s1 -> html.watch (store2, (fun s2 -> render s1 s2))))
    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by the stores
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View (hook: IComponentHook) =
    ///   let age = hook.UseStore 10
    ///   let name = hook.UseStore "Frank"
    ///
    ///   let _view age name =
    ///     [ p() { class' "red"; childContent $"{name} is {num} years old" }
    ///       p() { class' "blue"; childContent $"{name} is {num} years old" } ]
    ///
    ///   html.watch(age, name, _view)
    /// </code>
    /// </example>
    static member watch2(store1: IStore<'T1>, store2: IStore<'T2>, render: 'T1 -> 'T2 -> NodeRenderFragment list) =
        html.watch2 (store1, store2, (fun s1 s2 -> html.mergeNodes (render s1 s2)))

    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by the stores
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View (hook: IComponentHook) =
    ///   let age = hook.UseStore 10
    ///   let name = hook.UseStore "Frank"
    ///   let isAtSchool = hook.UseStore false
    ///
    ///   let _view age name  isAtSchool =
    ///     let msg = if isAtSchool then ", Who is attending school" else ", Who is not attending school"
    ///     [ p() { class' "red"; childContent $"{name} is {num} years old{msg}" }
    ///       p() { class' "blue"; childContent $"{name} is {num} years old{msg}" } ]
    ///
    ///   html.watch(age, name, isAtSchool, _view)
    /// </code>
    /// </example>
    static member watch3
        (
            store1: IStore<'T1>,
            store2: IStore<'T2>,
            store3: IStore<'T3>,
            render: 'T1 -> 'T2 -> 'T3 -> NodeRenderFragment list
        )
        =
        html.watch (
            store1,
            fun s1 -> html.watch (store2, (fun s2 -> html.watch (store3, (fun s3 -> render s1 s2 s3))))
        )

    /// <summary>
    /// Renders Nodes dynamically based on what is emitted by the stores
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let View (hook: IComponentHook) =
    ///   let age = hook.UseStore 10
    ///   let name = hook.UseStore "Frank"
    ///   let isAtSchool = hook.UseStore false
    ///
    ///   let _view age name  isAtSchool =
    ///     let msg = if isAtSchool then ", Who is attending school" else ", Who is not attending school"
    ///     p() {childContent $"{name} is {num} years old{msg}" }
    ///
    ///   html.watch(age, name, isAtSchool, _view)
    /// </code>
    /// </example>
    static member watch3
        (
            store1: IStore<'T1>,
            store2: IStore<'T2>,
            store3: IStore<'T3>,
            render: 'T1 -> 'T2 -> 'T3 -> NodeRenderFragment
        )
        =
        html.watch3 (store1, store2, store3, (fun s1 s2 s3 -> [ render s1 s2 s3 ]))
