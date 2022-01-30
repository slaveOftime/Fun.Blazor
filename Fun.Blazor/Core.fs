namespace Fun.Blazor

open System
open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Microsoft.AspNetCore.Components.Rendering
open Fun.Result


type AttrRenderFragment = delegate of IComponent * RenderTreeBuilder * int -> int
type NodeRenderFragment = delegate of IComponent * RenderTreeBuilder * int -> int


module Operators =
    let inline (=>) (name: string) (value: 'Value) =
        AttrRenderFragment(fun _ builder index ->
            builder.AddAttribute(index, name, box value)
            index + 1
        )

    let inline (==>) ([<InlineIfLambda>] render1: AttrRenderFragment) ([<InlineIfLambda>] render2: AttrRenderFragment) =
        AttrRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

    let inline (>=>) ([<InlineIfLambda>] render1: NodeRenderFragment) ([<InlineIfLambda>] render2: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))

    let inline (>>>) ([<InlineIfLambda>] render1: AttrRenderFragment) ([<InlineIfLambda>] render2: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index -> render2.Invoke(comp, builder, render1.Invoke(comp, builder, index)))


open Operators


type FragmentBuilder() =

    member inline _.Yield(_: unit) = AttrRenderFragment(fun _ _ i -> i)

    member inline _.Yield(x: int) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: string) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield(x: float) =
        NodeRenderFragment(fun _ builder index ->
            builder.AddContent(index, x)
            index + 1
        )

    member inline _.Yield([<InlineIfLambda>] x: AttrRenderFragment) = x
    member inline _.Yield([<InlineIfLambda>] x: NodeRenderFragment) = x

    member inline _.Delay([<InlineIfLambda>] fn: unit -> AttrRenderFragment) = fn ()
    member inline _.Delay([<InlineIfLambda>] fn: unit -> NodeRenderFragment) = fn ()

    member inline _.Combine
        (
            [<InlineIfLambda>] render1: AttrRenderFragment,
            [<InlineIfLambda>] render2: AttrRenderFragment
        )
        =
        render1 ==> render2

    member inline _.Combine
        (
            [<InlineIfLambda>] render1: AttrRenderFragment,
            [<InlineIfLambda>] render2: NodeRenderFragment
        )
        =
        render1 >>> render2

    member inline _.Combine
        (
            [<InlineIfLambda>] render1: NodeRenderFragment,
            [<InlineIfLambda>] render2: NodeRenderFragment
        )
        =
        render1 >=> render2

    
    member inline _.For
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] fn: unit -> AttrRenderFragment
        )
        =
        render ==> (fn ())

    member inline _.For
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] fn: unit -> NodeRenderFragment
        )
        =
        render >>> (fn ())

    member inline _.Zero() = NodeRenderFragment(fun _ _ i -> i)


    [<CustomOperation("ref")>]
    member inline _.ref
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            [<InlineIfLambda>] fn: ElementReference -> unit
        )
        =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddElementReferenceCapture(index, fn)
            index + 1
        )

    [<CustomOperation("on")>]
    member inline _.on
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            eventName,
            [<InlineIfLambda>] callback: 'T -> unit
        )
        =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, "on" + eventName, EventCallback.Factory.Create(comp, Action<'T> callback))
            index + 1
        )

    [<CustomOperation("onTask")>]
    member inline _.onTask
        (
            [<InlineIfLambda>] render: AttrRenderFragment,
            eventName,
            [<InlineIfLambda>] callback: 'T -> Task
        )
        =
        render
        ==> AttrRenderFragment(fun comp builder index ->
            builder.AddAttribute(index, "on" + eventName, EventCallback.Factory.Create(comp, Func<'T, Task> callback))
            index + 1
        )

    [<CustomOperation("preventDefault")>]
    member inline _.preventDefault([<InlineIfLambda>] render: AttrRenderFragment, eventName, value) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddEventPreventDefaultAttribute(index, "on" + eventName, value)
            index + 1
        )

    [<CustomOperation("stopPropagation")>]
    member inline _.stopPropagation([<InlineIfLambda>] render: AttrRenderFragment, eventName, value) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.AddEventPreventDefaultAttribute(index, "on" + eventName, value)
            index + 1
        )


type EltBuilder(name) =
    inherit FragmentBuilder()

    member _.Name: string = name


    member inline this.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, this.Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    member inline this.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenElement(index, this.Name)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )


    member inline _.Yield(x: EltBuilder) =
        AttrRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield(_: ComponentBuilder<'T>) =
        AttrRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T>(index)
            builder.CloseComponent()
            index + 1
        )


and ComponentBuilder<'T when 'T :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FragmentBuilder()


    member inline _.Run([<InlineIfLambda>] render: AttrRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )

    member inline _.Run([<InlineIfLambda>] render: NodeRenderFragment) =
        NodeRenderFragment(fun comp builder index ->
            builder.OpenComponent<'T>(index)
            let nextIndex = render.Invoke(comp, builder, index + 1)
            builder.CloseElement()
            nextIndex
        )


    member inline _.Yield(x: EltBuilder) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenElement(index, x.Name)
            builder.CloseElement()
            index + 1
        )

    member inline _.Yield(_: ComponentBuilder<'T>) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<'T>(index)
            builder.CloseComponent()
            index + 1
        )


    [<CustomOperation("key")>] 
    member inline _.key([<InlineIfLambda>] render: AttrRenderFragment, k) =
        render
        ==> AttrRenderFragment(fun _ builder index ->
            builder.SetKey k
            index
        )


[<AbstractClass>]
type FunBlazorComponent() as this =
    inherit ComponentBase()

    override _.BuildRenderTree(builder: RenderTreeBuilder) = this.Render().Invoke(this, builder, 0) |> ignore

    abstract Render : unit -> NodeRenderFragment


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
    abstract CreateDeferred :
        string * (unit -> IObservable<DeferredState<'T, 'Error>>) -> IStore<DeferredState<'T, 'Error>>

    /// Create an adaptive value and share between components and dispose it after session disposed
    /// This is recommend way because you can use it with adaptiview easier
    abstract CreateCVal : string * 'T -> cval<'T>


// Will serve as a singleton service
// * Note this is not distributable
type IGlobalStore =
    inherit IShareStore
