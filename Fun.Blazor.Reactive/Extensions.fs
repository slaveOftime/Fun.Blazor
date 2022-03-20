[<AutoOpen>]
module Fun.Blazor.Extensions

open System
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Fun.Result
open Fun.Blazor


type IStore<'T> with

    /// <summary>
    /// This can be used for bind value
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// MudTextInput'() {
    ///     Value' (store.ToWithSetter())
    /// }
    /// </code>
    /// </example>
    member this.WithSetter() = this.Current, (fun x -> this.Publish(fun _ -> x))


type IStoreManager with

    member this.Create(key: string, defaultValue: 'T) =
        this.GetOrAddDisposableStore(key, (fun _ -> new Store<'T>(defaultValue) :> IDisposable)) :?> IStore<'T>


    member this.CreateDeferred(key: string, getData: unit -> IObservable<DeferredState<'T, 'Error>>) =
        this.GetOrAddDisposableStore(
            key,
            fun _ ->
                let store = new Store<_>(DeferredState.NotStartYet)
                let subscription = getData().Subscribe(fun x -> (store :> IStore<_>).Publish(x))
                this.AddDispose subscription
                store :> IDisposable
        )
        :?> IStore<DeferredState<'T, 'Error>>


    member this.Create(defaultValue: 'T) =
        let key = typeof<'T>.FullName
        this.Create(key, defaultValue)


type IComponentHook with
    /// <summary>
    /// Creates a new Store, you should hold a reference to this store and use it on your components
    /// </summary>
    /// <remarks>
    /// To prevent performance issues you should always dispose the store when you are done with it.
    /// </remarks>
    /// <example>
    /// <code lang="fsharp">
    ///
    /// let view (hook: IComponentHook) =
    ///     let state = hook.UseStore 0
    ///     // ... use the store or subscribe to it ...
    ///     // ensure disposal
    ///     hook.AddDispose state
    ///     html.watch (state, fun state'-> ...)
    ///
    /// html.inject("my-view", view)
    /// </code>
    /// </example>
    member hook.UseStore<'T>(x: 'T) : IStore<'T> =
        let newStore = new Store<'T>(x)
        hook.AddDispose newStore
        newStore :> IStore<'T>

    /// <summary>
    /// Convert a store into an adaptive value which should be updated with other adaptive values
    /// which should enable performant and incremental computations
    /// </summary>
    member hook.UseAVal<'T>(store: IStore<'T>) : aval<'T> =
        let value' = cval store.Current
        store.Observable.Subscribe(fun x -> transact (fun _ -> value'.Value <- x)) |> hook.AddDispose
        value' :> aval<'T>

    /// <summary>
    /// Create an adaptive value from a default value and an observable which should be updated with other adaptive values
    /// which should enable performant and incremental computations
    /// </summary>
    member hook.UseAVal<'T>(defaultValue: 'T, obser: IObservable<'T>) : aval<'T> =
        let value' = cval defaultValue
        obser.Subscribe(fun x -> transact (fun _ -> value'.Value <- x)) |> hook.AddDispose
        value' :> aval<'T>

    /// <summary>
    /// Convert a store into a changeable value which you can use it in adaptiview
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let view (hook: IComponentHook) =
    ///     let state = hook.UseStore 0
    ///     // ... use the store or subscribe to it ...
    ///     // ensure disposal
    ///     hook.AddDispose state
    ///     adaptiview() {
    ///        let! value, setValue = hook.UseCVal state
    ///     }
    ///
    /// html.inject("my-view", view)
    /// </code>
    /// </example>
    member hook.UseCVal<'T>(store: IStore<'T>) : cval<'T> =
        let value' = cval store.Current
        store.Observable.Subscribe(fun x -> transact (fun _ -> value'.Value <- x)) |> hook.AddDispose
        value'.AddCallback(fun (x: 'T) -> store.Publish x) |> hook.AddDispose
        value'


type html with

    static member bind<'T>(name: string, store: IStore<'T>) =
        AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, name, store.Current)
            builder.AddAttribute(index + 1, name + "Changed", EventCallback.Factory.Create(comp, Action<'T> store.Publish))
            index + 2
        )
