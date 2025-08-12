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

/// In blazor, we cannot add attribute after add ref or rendemode etc., so we need a clear position to seperate them
type PostRenderFragment = delegate of root: IComponent * builder: RenderTreeBuilder * sequence: int -> int


/// Type to represent a CE builder for Fun.Blazor
type IFunBlazorBuilder = interface end

/// Type to represent a CE builder for Fun.Blazor element
type IElementBuilder =
    inherit IFunBlazorBuilder
    abstract member Name: string

/// Type to represent a CE builder for Fun.Blazor component
type IComponentBuilder<'T when 'T :> Microsoft.AspNetCore.Components.IComponent> =
    inherit IFunBlazorBuilder


/// Basic class for user to hook CE style into Blazor component.
/// ```fsharp
/// type MyComponent() =
///     inherit FunComponent()
///     override _.Render() = div {
///         "Hello World"
///     }
/// ```
[<AbstractClass>]
type FunComponent() as this =
    inherit ComponentBase()

    override _.BuildRenderTree(builder: RenderTreeBuilder) = this.Render().Invoke(this, builder, 0) |> ignore

    abstract Render: unit -> NodeRenderFragment

    member _.StateHasChanged() = base.StateHasChanged()

    member _.ForceRerender() = this.InvokeAsync(fun () -> this.StateHasChanged()) |> ignore

#if NET9_0_OR_GREATER
    member _.MapAsset(x) = base.Assets[x]
    member _.AssignedRenderMode = base.AssignedRenderMode
    member _.RendererInfo = base.RendererInfo
#endif

#if DEBUG
    /// Should not be used in production, only for debug purpose
    static member val EnablePrintDebugInfo = false with get, set

    /// Should not be used in production, only for debug purpose
    [<Parameter>]
    member val FunBlazorDebugKey: obj = null with get, set
#endif

    override _.OnInitialized() =
#if DEBUG
        if FunComponent.EnablePrintDebugInfo then
            printfn "Initialized FunComponent with key: %A" this.FunBlazorDebugKey
#endif
        ()

/// This is a helper abstract class which will disable event trigger StateHasChanged,
/// because for internal Fun Blazor components they are using adaptive model and will not need event triger re-render.
/// And event trigger re-render may cause unnecessary cost.
/// When you use adaptive, elmish, reative models etc., and also want to use component style, you can use this one.
[<AbstractClass>]
type FunBlazorComponent() as this =
    inherit FunComponent()

    /// This is used to override the default implementation in base class to avoid trigger StateHasChanged.
    /// Because in Fun.Blazor everytime should be static by default and UI should be rerender if data is changed.
    /// But if you want to create a component for using in csharp project, then you may want to turn this off to avoid maually trigger StateHasChanged.
    /// Because csharp prefer to rerender the whole component when event hanppened, but in Fun.Blazor that will cost redundant calculation.
    member val DisableEventTriggerStateHasChanged = true with get, set


    interface IHandleEvent with
        /// We should be careful with this, because aspnetcore team may change the HandleEventAsync. So we should sync with their implementation.
        /// https://github.com/dotnet/aspnetcore/blob/8b30d862de6c9146f466061d51aa3f1414ee2337/src/Components/Components/src/ComponentBase.cs#L301
        member _.HandleEventAsync(callback, arg) =
            let taskResult = callback.InvokeAsync(arg)
            let shouldAwaitTask =
                taskResult.Status <> TaskStatus.RanToCompletion && taskResult.Status <> TaskStatus.Canceled

            if not this.DisableEventTriggerStateHasChanged then this.ForceRerender()

            if shouldAwaitTask then
                task {
                    try
                        do! taskResult
                    with e when not taskResult.IsCanceled ->
                        raise e
                }
            else
                Task.CompletedTask


/// This is a helper class for places which need to component and need a NodeRenderFragment as the parameter to be passed in
type FunFragmentComponent() as this =
    inherit FunComponent()

    override _.Render() = this.Fragment

    [<Parameter>]
    member val Fragment = NodeRenderFragment(fun _ _ i -> i) with get, set


#if !NET6_0
/// Wrapper class to make a function style component to be streamable
[<StreamRendering>]
type FunStreamingComponent() =
    inherit FunComponent()

    [<Parameter>]
    member val Content: NodeRenderFragment = NodeRenderFragment(fun _ _ i -> i) with get, set

    override this.Render() = this.Content

/// Mark a component as InteractiveAuto
type FunInteractiveAutoAttribute() =
    inherit RenderModeAttribute()

    override _.Mode = Web.RenderMode.InteractiveAuto

/// Mark a component as InteractiveServer
type FunInteractiveServerAttribute() =
    inherit RenderModeAttribute()

    override _.Mode = Web.RenderMode.InteractiveServer

/// Mark a component as InteractiveWebAssembly
type FunInteractiveWebAssemblyAttribute() =
    inherit RenderModeAttribute()

    override _.Mode = Web.RenderMode.InteractiveWebAssembly
#endif
