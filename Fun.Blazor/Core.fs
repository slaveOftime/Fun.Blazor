namespace Fun.Blazor

open System
open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Rendering
open Fun.Result


/// Provide a delegate so we can extend how we plug piece of attribute into blazor RenderTree
/// root should be the nearest root component, builder should be passed by the context, sequence is the usable sequence number.
/// Return int should be the next useable sequence
type AttrRenderFragment = delegate of root: IComponent * builder: RenderTreeBuilder * sequence: int -> int

/// Provide a delegate so we can extend how we plug piece of node into blazor RenderTree
/// root should be the nearest root component, builder should be passed by the context, sequence is the usable sequence number.
/// Return int should be the next useable sequence
type NodeRenderFragment = delegate of root: IComponent * builder: RenderTreeBuilder * sequence: int -> int

/// In blazor, we cannot add attribute after add ref, so we need a clear position to seperate them
type RefRenderFragment = delegate of root: IComponent * builder: RenderTreeBuilder * sequence: int -> int


module Operators =

    /// Add Attribute with name and value
    let inline (=>) (name: string) (value: 'Value) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, name, box value)
            index + 1
        )

    /// Add Attribute with name and string value
    let inline (=>>) (name: string) (value: string) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, name, value)
            index + 1
        )

    /// Add Attribute with name and bool value
    /// If true then add the name to attribute else do nothing
    let inline (=>>>) (name: string) (value: bool) =
        AttrRenderFragment(fun _ builder index ->
            if value then
                builder.AddAttribute(index, name)
                index + 1
            else
                index
        )

    /// Merge two AttrRenderFragment together
    let inline (==>) ([<InlineIfLambda>] render1: AttrRenderFragment) ([<InlineIfLambda>] render2: AttrRenderFragment) =
        AttrRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

    /// Merge two NodeRenderFragment together
    let inline (>=>) ([<InlineIfLambda>] render1: NodeRenderFragment) ([<InlineIfLambda>] render2: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

    /// Merge AttrRenderFragment and NodeRenderFragment together.
    /// This should be used together for building element only. For component we should not use this, because it treat ChildContent different in Blazor
    let inline (>>>) ([<InlineIfLambda>] render1: AttrRenderFragment) ([<InlineIfLambda>] render2: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))


type IElementBuilder =
    abstract member Name: string

type IComponentBuilder<'T when 'T :> Microsoft.AspNetCore.Components.IComponent> =
    interface
    end


[<AbstractClass>]
type FunBlazorComponent() as this =
    inherit ComponentBase()

    override _.BuildRenderTree(builder: RenderTreeBuilder) = this.Render().Invoke(this, builder, 0) |> ignore

    member _.StateHasChanged() = base.StateHasChanged()

    member _.ForceRerender() =
        this.InvokeAsync(fun () -> this.StateHasChanged()) |> ignore

    abstract Render: unit -> NodeRenderFragment


type FunFragmentComponent() as this =
    inherit FunBlazorComponent()

    override _.Render() = this.Fragment

    [<Parameter>]
    member val Fragment = NodeRenderFragment(fun _ _ i -> i) with get, set


type IStore<'T> =
    /// <summary>
    /// Takes an identity function, useful for updating or computing new values from previous ones
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// users.Publish(fun user -> { user with name = newName })
    /// </code>
    /// </example>
    abstract Publish: ('T -> 'T) -> unit
    /// <summary>
    /// Takes a new value and replaces the content of the store completely
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// users.Publish(newUser)
    /// </code>
    /// </example>
    abstract Publish: 'T -> unit

    /// <summary>
    /// An observable that contains the changes made to the store over the time
    /// </summary>
    abstract Observable: IObservable<'T>
    /// <summary>
    /// The current value in the store, defaults to the initial value supplied when creating the store
    /// </summary>
    abstract Current: 'T
    /// <summary>
    /// A unique identifier for the current store, this can help to track the origin in shared or global stores
    /// </summary>
    abstract Key: string


type IObserveValue<'T> =
    abstract member Current: 'T


type IComponentHook =
    //abstract OnParametersSet: IEvent<unit>
    /// <summary>
    /// Invoked after each time the component has been rendered.
    /// The parameter will be true if the event corresponds to the first render otherwise it will be false.
    /// </summary>
    abstract OnAfterRender: IEvent<bool>
    /// <summary>
    /// Method invoked when the component is ready to start, having received its initial parameters from its parent in the render tree.
    /// </summary>
    abstract OnInitialized: IEvent<unit>
    ///<summary>
    /// Invoked the first time the component has been rendered.
    /// This is a convenience event from OnAfterRender
    /// </summary>
    abstract OnFirstAfterRender: IEvent<unit>

    /// <summary>
    /// The component is being disposed, you can cleanup manually managed resources or log any information here.
    /// </summary>
    abstract OnDispose: IEvent<unit>

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
    abstract AddDispose: IDisposable -> unit
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
    abstract AddDisposes: IDisposable seq -> unit
    /// <summary>
    /// Notifies the component that its state has changed. When applicable, this will cause the component to be re-rendered.
    /// </summary>
    abstract StateHasChanged: unit -> unit
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
    abstract UseStore: 'T -> IStore<'T>

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
    abstract UseCVal: IStore<'T> -> cval<'T>

    /// <summary>
    /// Convert a store into an adaptive value which should be updated with other adaptive values
    /// which should enable performant and incremental computations
    /// </summary>
    abstract UseAVal: IStore<'T> -> aval<'T>
    /// <summary>
    /// Create an adaptive value from a default value and an observable which should be updated with other adaptive values
    /// which should enable performant and incremental computations
    /// </summary>
    abstract UseAVal: defaultValue: 'T * IObservable<'T> -> aval<'T>

    /// With this we can create extension of the hook and access all resources
    /// which means we can the extension that can be standalone and be reused more easizer
    abstract ServiceProvider: IServiceProvider


type IStoreManager =
    /// Create an IStore and share between components and dispose it after session disposed
    abstract Create: string * 'T -> IStore<'T>

    /// Create an IStore and share between components and dispose it after session disposed
    abstract Create: 'T -> IStore<'T>

    /// Create an IStore and share between components and dispose it after session disposed
    /// Default state will be NotStartedYet
    abstract CreateDeferred: string * (unit -> IObservable<DeferredState<'T, 'Error>>) -> IStore<DeferredState<'T, 'Error>>

    /// Create an adaptive value and share between components and dispose it after session disposed
    /// This is recommend way because you can use it with adaptiview easier
    abstract CreateCVal: string * 'T -> cval<'T>

    abstract CreateCVal: string * defautValue: 'T * init: (unit -> aval<'T>) -> cval<'T>

    abstract CreateCVal: string * defautValue: 'T * init: (unit -> Task<'T>) -> cval<'T>

    // Help us to access DI container
    abstract ServiceProvider: IServiceProvider


// Will serve as a scoped service
type IShareStore =
    inherit IStoreManager

// Will serve as a singleton service
// * Note this is not distributable
type IGlobalStore =
    inherit IStoreManager
