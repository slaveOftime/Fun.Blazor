namespace Fun.Blazor

open System
open System.Threading.Tasks
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Rendering


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

#if DEBUG
    [<Parameter>]
    member val FunBlazorDebugKey: obj = null with get, set
#endif

    override _.BuildRenderTree(builder: RenderTreeBuilder) = this.Render().Invoke(this, builder, 0) |> ignore

    override _.OnInitialized() =
#if DEBUG
        printfn "Initialized FunBlazorComponent with key: %A" this.FunBlazorDebugKey
#endif
        ()


    member _.StateHasChanged() = base.StateHasChanged()

    member _.ForceRerender() = this.InvokeAsync(fun () -> this.StateHasChanged()) |> ignore

    /// This is used to override the default implementation in base class to avoid trigger StateHasChanged.
    /// Because in Fun.Blazor everytime should be static by default and UI should be rerender if data is changed.
    /// But if you want to create a component for using in csharp project, then you may want to turn this off to avoid maually trigger StateHasChanged.
    /// Because csharp prefer to rerender the whole component when event hanppened, but in Fun.Blazor that will cost redundant calculation.
    member val DisableEventTriggerStateHasChanged = true with get, set


    abstract Render: unit -> NodeRenderFragment


    interface IHandleEvent with
        /// We should be careful with this, because aspnetcore team may change the HandleEventAsync. So we should sync with their implementation.
        /// https://github.com/dotnet/aspnetcore/blob/8b30d862de6c9146f466061d51aa3f1414ee2337/src/Components/Components/src/ComponentBase.cs#L301
        member _.HandleEventAsync(callback, arg) =
            let taskResult = callback.InvokeAsync(arg)
            let shouldAwaitTask =
                taskResult.Status <> TaskStatus.RanToCompletion && taskResult.Status <> TaskStatus.Canceled

            if not this.DisableEventTriggerStateHasChanged then this.StateHasChanged()

            if shouldAwaitTask then
                task {
                    try
                        do! taskResult
                    with e when not taskResult.IsCanceled ->
                        raise e
                }
            else
                Task.CompletedTask


type FunFragmentComponent() as this =
    inherit FunBlazorComponent()

    override _.Render() = this.Fragment

    [<Parameter>]
    member val Fragment = NodeRenderFragment(fun _ _ i -> i) with get, set


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

    abstract AddInitializedTask: makeTask: (unit -> Task) -> unit
    abstract AddAfterRenderTask: makeTask: (bool -> Task) -> unit
    abstract AddFirstAfterRenderTask: makeTask: (unit -> Task) -> unit
    abstract AddParameterSetTask: makeTask: (unit -> Task) -> unit

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
    /// Notify the component that its state has changed. When applicable, this will cause the component to be re-rendered.
    /// </summary>
    abstract StateHasChanged: unit -> unit

    /// With this we can toggle the behavior to the default blazor component behavior when it makes sense to you.
    abstract SetDisableEventTriggerStateHasChanged: bool -> unit

    /// With this we can create extension of the hook and access all resources
    /// which means we can the extension that can be standalone and be reused more easizer
    abstract ServiceProvider: IServiceProvider

    /// <summary>
    /// This is using CascadeValue from blazor. To use this you will need to provider a wrapper around your child components or elements.
    /// You also need to provider a root value for it, otherwise you will get null exception for using it.
    /// </summary>
    /// <example>
    /// <code lang="fsharp">
    /// html.scoped [
    ///     html.inject (fun (hook: IComponentHook ->)
    ///         hook.ScopedServiceProvider ... you can use it then
    ///         ...
    ///     )
    /// ]
    /// </code>
    /// </example>
    abstract ScopedServiceProvider: IServiceProvider


type IStoreManager =

    /// Create an adaptive value and share between components and dispose it after session disposed
    /// This is recommend way because you can use it with adaptiview easier
    abstract CreateCVal: string * 'T -> cval<'T>

    abstract CreateCVal: string * defautValue: 'T * init: (unit -> aval<'T>) -> cval<'T>

    abstract CreateCVal: string * defautValue: 'T * init: (unit -> Task<'T>) -> cval<'T>

    // Help us to access DI container
    abstract ServiceProvider: IServiceProvider

    /// This is for library authors.
    /// For example, with this we can abstract the FSharp.Control.Reactive out to a separate pacakges to consume to help reduce the WASM size. If users do not want to use it.
    abstract GetOrAddDisposableStore: string * (unit -> IDisposable) -> IDisposable

    /// This is for library authors.
    /// Can be used to add subscriptions resources, so we can clean it up when the store manager is disposing.
    abstract AddDispose: IDisposable -> unit


// Will serve as a scoped service
type IShareStore =
    inherit IStoreManager

// Will serve as a singleton service
// * Note this is not distributable
type IGlobalStore =
    inherit IStoreManager
