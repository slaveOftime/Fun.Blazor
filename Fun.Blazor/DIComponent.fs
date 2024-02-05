namespace Fun.Blazor

open System
open System.Threading.Tasks
open System.Collections.Generic
open System.Diagnostics.CodeAnalysis
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components
open Internal


[<AutoOpen>]
module ServiceProviderExtensions =
    type IServiceProvider with

        member sp.GetMultipleServices(depsType: Type, handleNotFoundType) =
            let inline getSvc ty =
                let svc = sp.GetService(ty)
                if svc = null then handleNotFoundType ty else svc

            if depsType = typeof<unit> then
                box ()
            elif Reflection.FSharpType.IsTuple depsType then
                let svcs = depsType |> Reflection.FSharpType.GetTupleElements |> Array.map getSvc
                Reflection.FSharpValue.MakeTuple(svcs, depsType)
            else
                getSvc depsType

        member sp.GetMultipleServices(depsType: Type) = sp.GetMultipleServices(depsType, (fun x -> failwith $"Service {x} is not registered"))

        /// 'Types must be a tuple or unit
        member sp.GetMultipleServices<'Types>() =
            sp.GetMultipleServices(typeof<'Types>, (fun x -> failwith $"Service {x} is not registered"))
            |> unbox<'Types>


    type IComponentHook with

        /// This will get service from DI container. The service 'T is registered by AddHookService<'T>().
        /// With this we can have better unit testing experience. If you do not want to do UT, you can just create extension method directly on IComponentHook
        member hook.GetHookService<'T>() = hook.ServiceProvider.GetService<IComponentHook -> 'T> () (hook)


type DIComponent<'T> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<DIComponent<_>>)>] () as this =
    inherit FunBlazorComponent()

    let mutable node = ValueNone
    let mutable shouldRerender = true


    let mutable initializedEvent: Event<unit> voption = ValueNone
    let mutable afterRenderEvent: Event<bool> voption = ValueNone
    let mutable firstAfterRenderEvent: Event<unit> voption = ValueNone
    let mutable disposeEvent: Event<unit> voption = ValueNone

    let mutable parameterSetTasks: List<unit -> Task> = null
    let mutable initializedTasks: List<unit -> Task> = null
    let mutable afterRenderTasks: List<bool -> Task> = null
    let mutable firstAfterRenderTasks: List<unit -> Task> = null
    let mutable disposes: List<IDisposable> = null

    let mutable hook: IComponentHook voption = ValueNone


    member private _.HandleNotFoundType ty =
        if ty = typeof<IComponentHook> then
            if hook.IsNone then
                hook <-
                    ValueSome
                        { new IComponentHook with
                            member _.OnAfterRender =
                                if afterRenderEvent.IsNone then afterRenderEvent <- ValueSome(Event<_>())
                                afterRenderEvent.Value.Publish

                            member _.OnInitialized =
                                if initializedEvent.IsNone then initializedEvent <- ValueSome(Event<_>())
                                initializedEvent.Value.Publish

                            member _.OnFirstAfterRender =
                                if firstAfterRenderEvent.IsNone then
                                    firstAfterRenderEvent <- ValueSome(Event<_>())
                                firstAfterRenderEvent.Value.Publish

                            member _.OnDispose =
                                if disposeEvent.IsNone then disposeEvent <- ValueSome(Event<_>())
                                disposeEvent.Value.Publish

                            member _.AddInitializedTask makeTask =
                                if initializedTasks = null then initializedTasks <- new List<_>()
                                initializedTasks.Add makeTask

                            member _.AddAfterRenderTask makeTask =
                                if afterRenderTasks = null then afterRenderTasks <- new List<_>()
                                afterRenderTasks.Add makeTask

                            member _.AddFirstAfterRenderTask makeTask =
                                if firstAfterRenderTasks = null then firstAfterRenderTasks <- new List<_>()
                                firstAfterRenderTasks.Add makeTask

                            member _.AddParameterSetTask makeTask =
                                if parameterSetTasks = null then parameterSetTasks <- new List<_>()
                                parameterSetTasks.Add makeTask

                            member _.AddDispose dispose =
                                if disposes = null then disposes <- new List<_>()
                                disposes.Add dispose

                            member _.AddDisposes ds =
                                if disposes = null then disposes <- new List<_>()
                                disposes.AddRange(ds)

                            member _.StateHasChanged() = this.ForceRerender()
                            member _.SetDisableEventTriggerStateHasChanged(x) = this.DisableEventTriggerStateHasChanged <- x
                            member _.ServiceProvider = this.Services

                            member _.ScopedServiceProvider =
                                if isNull this.ScopedServices then
                                    failwithf
                                        "You should use html.scoped to wrap your components. Or create a CascadeValue component to provide a IServiceProvider with name '%s'"
                                        Internal.FunBlazorScopedServicesName
                                this.ScopedServices
                        }
            box hook.Value
        else
            null


    [<Parameter>]
    member val RenderFn: 'T -> Task<NodeRenderFragment> = fun _ -> Task.FromResult(emptyNode ()) with get, set

    /// With this we can avoid rerender when parameter reset
    /// If component is not recreated then all the rerender will use the closure state created by the first RenderFn
    [<Parameter>]
    member val IsStatic = false with get, set

    [<CascadingParameter(Name = Internal.FunBlazorScopedServicesName)>]
    member val ScopedServices = Unchecked.defaultof<IServiceProvider> with get, set

    [<Inject>]
    member val Services = Unchecked.defaultof<IServiceProvider> with get, set

    [<Inject>]
    member val Logger = Unchecked.defaultof<ILogger<DIComponent<'T>>> with get, set


    override _.Render() =
        html.region (
            this.Logger.LogDebugForPerf(fun () ->
                match node with
                | ValueNone -> emptyNode ()
                | ValueSome node -> node
            )
        )


    override _.OnInitializedAsync() = task {
        let depsType, _ = Reflection.FSharpType.GetFunctionElements(this.RenderFn.GetType())
        let services =
            this.Services.GetMultipleServices(depsType, this.HandleNotFoundType) :?> 'T
        let! newNode = this.RenderFn services
        node <- newNode |> ValueSome

        if initializedEvent.IsSome then initializedEvent.Value.Trigger()

        if initializedTasks <> null then
            for makeTask in initializedTasks do
                do! makeTask ()
    }


    override _.OnParametersSet() =
        if this.IsStatic && node.IsSome then
            // Avoid rerender for static mode
            shouldRerender <- false

    override _.OnParametersSetAsync() = task {
        if parameterSetTasks <> null then
            for makeTask in parameterSetTasks do
                do! makeTask ()
    }


    override _.ShouldRender() =
        let result = shouldRerender
        if not shouldRerender then shouldRerender <- true
        result


    override _.OnAfterRender firstRender =
        if afterRenderEvent.IsSome then afterRenderEvent.Value.Trigger firstRender
        if firstAfterRenderEvent.IsSome && firstRender then
            firstAfterRenderEvent.Value.Trigger()

    override _.OnAfterRenderAsync firstRender = task {
        if afterRenderTasks <> null then
            for makeTask in afterRenderTasks do
                do! makeTask firstRender
        if firstRender && firstAfterRenderTasks <> null then
            for makeTask in firstAfterRenderTasks do
                do! makeTask ()
    }


    interface IDisposable with
        member _.Dispose() =
            if disposeEvent.IsSome then disposeEvent.Value.Trigger()
            if disposes <> null then
                for dispose in disposes do
                    dispose.Dispose()
