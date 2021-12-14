namespace rec Fun.Blazor

open System
open FSharp.Data.Adaptive
open Bolero
open Bolero.Html
open Fun.Result


type FunBlazorRef<'T> = Ref<'T>


type FunBlazorComponent = Bolero.Component


/// Base class for Computation Expression style DSL
type FunBlazorBuilder<'Component when 'Component :> Microsoft.AspNetCore.Components.IComponent>() =
    let attrs = Collections.Generic.List<Attr>()
    let nodes = Collections.Generic.List<Node>()

    member this.AddAttr x =
        attrs.Add x
        this
    member this.AddNode x =
        nodes.Add x
        this
    member this.AddNodes x =
        nodes.AddRange x
        this

    member this.AddBinding(name, value: IStore<'T>) =
        name => value.Current |> this.AddAttr |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" value.Publish |> this.AddAttr

    member this.AddBinding(name, value: cval<'T>) =
        name => AVal.force value |> this.AddAttr |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" (fun x -> transact (fun _ -> value.Value <- x))
        |> this.AddAttr

    member this.AddBinding(name, (value: 'T, fn)) =
        name => value |> this.AddAttr |> ignore
        Bolero.Html.attr.callback<'T> $"{name}Changed" fn |> this.AddAttr


    member this.Props() = attrs, nodes

    member this.CreateNode() =
        Bolero.Html.comp<'Component> (Seq.toList attrs) (Seq.toList nodes)

    // Executes a computation expression
    member this.Run _ =
        Bolero.Html.comp<'Component> (Seq.toList attrs) (Seq.toList nodes)

    member this.Yield _ = this

    member this.Zero _ = Html.empty

    [<CustomOperation("ref")>]
    member this.ref(_: FunBlazorBuilder<'Component>, v) = Bolero.Html.attr.ref v |> this.AddAttr

    [<CustomOperation("onevent")>]
    member this.event(_: FunBlazorBuilder<'Component>, eventName, callback) =
        Bolero.Html.on.event eventName callback |> this.AddAttr

    [<CustomOperation("preventDefault")>]
    member this.preventDefault(_: FunBlazorBuilder<'Component>, eventName, value) =
        Bolero.Html.on.preventDefault eventName value |> this.AddAttr

    [<CustomOperation("stopPropagation")>]
    member this.stopPropagation(_: FunBlazorBuilder<'Component>, eventName, value) =
        Bolero.Html.on.stopPropagation eventName value |> this.AddAttr


type IStore<'T> =
    /// <summary>
    /// Takes an identity function, useful for updating or computing new values from previous ones
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// users.Publish(fun user -> { user with name = newName })
    /// </code>
    /// </example>
    abstract Publish : ('T -> 'T) -> unit
    /// <summary>
    /// Takes a new value and replaces the content of the store completely
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// users.Publish(newUser)
    /// </code>
    /// </example>
    abstract Publish : 'T -> unit

    /// <summary>
    /// An observable that contains the changes made to the store over the time
    /// </summary>
    abstract Observable : IObservable<'T>
    /// <summary>
    /// The current value in the store, defaults to the initial value supplied when creating the store
    /// </summary>
    abstract Current : 'T
    /// <summary>
    /// A unique identifier for the current store, this can help to track the origin in shared or global stores
    /// </summary>
    abstract Key : string


type IObserveValue<'T> =
    abstract member Current : 'T


type IComponentHook =
    //abstract OnParametersSet: IEvent<unit>
    /// <summary>
    /// Invoked after each time the component has been rendered.
    /// The parameter will be true if the event corresponds to the first render otherwise it will be false.
    /// </summary>
    abstract OnAfterRender : IEvent<bool>
    /// <summary>
    /// Method invoked when the component is ready to start, having received its initial parameters from its parent in the render tree.
    /// </summary>
    abstract OnInitialized : IEvent<unit>
    ///<summary>
    /// Invoked the first time the component has been rendered.
    /// This is a convenience event from OnAfterRender
    /// </summary>
    abstract OnFirstAfterRender : IEvent<unit>

    /// <summary>
    /// The component is being disposed, you can cleanup manually managed resources or log any information here.
    /// </summary>
    abstract OnDispose : IEvent<unit>

    /// <summary>
    /// Adds a disposable object to the disposables list, these will be disposed together with the current component
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let view (hook: IComponentHook) =
    ///     let store = hook.UseStore 10
    ///     hook.AddDispose store
    /// html.inject("my-component", view)
    /// </code>
    /// </example>
    abstract AddDispose : IDisposable -> unit
    /// <summary>
    /// Adds multiple objects to the disposables list, these will be disposed together with the current component
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// let view (hook: IComponentHook) =
    ///     let ageStore = hook.UseStore 10
    ///     let usernameStore = hook.UseStore ""
    ///     hook.AddDisposes [ageStore; usernameStore]
    /// html.inject("my-component", view)
    /// </code>
    /// </example>
    abstract AddDisposes : IDisposable seq -> unit
    /// <summary>
    /// Notifies the component that its state has changed. When applicable, this will cause the component to be re-rendered.
    /// </summary>
    abstract StateHasChanged : unit -> unit
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
    abstract UseStore : 'T -> IStore<'T>

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
    abstract UseCVal : IStore<'T> -> cval<'T>

    /// <summary>
    /// Convert a store into an adaptive value which should be updated with other adaptive values
    /// which should enable performant and incremental computations
    /// </summary>
    abstract UseAVal : IStore<'T> -> aval<'T>
    /// <summary>
    /// Create an adaptive value from a default value and an observable which should be updated with other adaptive values
    /// which should enable performant and incremental computations
    /// </summary>
    abstract UseAVal : defaultValue: 'T * IObservable<'T> -> aval<'T>


// Will serve as a scoped service
type IShareStore =
    /// Create an IStore and share between components and dispose it after session disposed
    abstract Create : string * 'T -> IStore<'T>

    /// Create an IStore and share between components and dispose it after session disposed
    abstract Create : 'T -> IStore<'T>

    /// Create an IStore and share between components and dispose it after session disposed
    /// Default state will be NotStartedYet
    abstract CreateDeferred : string * (unit -> IObservable<DeferredState<'T, 'Error>>) -> IStore<DeferredState<'T, 'Error>>

    /// Create an adaptive value and share between components and dispose it after session disposed
    /// This is recommend way because you can use it with adaptiview easier
    abstract CreateCVal : string * 'T -> cval<'T>


// Will serve as a singleton service
// * Note this is not distributable
type IGlobalStore =
    inherit IShareStore
