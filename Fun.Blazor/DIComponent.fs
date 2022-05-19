namespace Fun.Blazor

open System
open System.Threading.Tasks
open System.Collections.Generic
open FSharp.Data.Adaptive
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components
open Internal


[<AutoOpen>]
module ServiceProviderExtensions =
    type IServiceProvider with

        member sp.GetMultipleServices(depsType: Type, handleNotFoundType) =
            let getSvc x =
                let svc = sp.GetService(x)
                if svc = null then handleNotFoundType x else svc

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
        member hook.GetHookService<'T>() = hook.ServiceProvider.GetService<IComponentHook -> 'T>() (hook)


type DIComponent<'T>() as this =
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


    member _.InitializedEvent
        with private get () =
            if initializedEvent.IsNone then initializedEvent <- ValueSome(Event<_>())
            initializedEvent.Value

    member _.AfterRenderEvent
        with private get () =
            if afterRenderEvent.IsNone then afterRenderEvent <- ValueSome(Event<_>())
            afterRenderEvent.Value

    member _.FirstAfterRenderEvent
        with private get () =
            if firstAfterRenderEvent.IsNone then
                firstAfterRenderEvent <- ValueSome(Event<_>())
            firstAfterRenderEvent.Value

    member _.DisposeEvent
        with private get () =
            if disposeEvent.IsNone then disposeEvent <- ValueSome(Event<_>())
            disposeEvent.Value

    member _.ParameterSetTasks
        with private get () =
            if parameterSetTasks = null then parameterSetTasks <- new List<_>()
            parameterSetTasks

    member _.InitializedTasks
        with private get () =
            if initializedTasks = null then initializedTasks <- new List<_>()
            initializedTasks

    member _.AfterRenderTasks
        with private get () =
            if afterRenderTasks = null then afterRenderTasks <- new List<_>()
            afterRenderTasks

    member _.FirstAfterRenderTasks
        with private get () =
            if firstAfterRenderTasks = null then firstAfterRenderTasks <- new List<_>()
            firstAfterRenderTasks

    member _.Disposes
        with private get () =
            if disposes = null then disposes <- new List<_>()
            disposes


    member private _.HandleNotFoundType ty =
        if ty = typeof<IComponentHook> then
            if hook.IsNone then
                hook <-
                    ValueSome
                        { new IComponentHook with
                            member _.OnAfterRender = this.AfterRenderEvent.Publish
                            member _.OnInitialized = this.InitializedEvent.Publish
                            member _.OnFirstAfterRender = this.FirstAfterRenderEvent.Publish
                            member _.OnDispose = this.DisposeEvent.Publish
                            member _.AddInitializedTask makeTask = this.InitializedTasks.Add makeTask
                            member _.AddAfterRenderTask makeTask = this.AfterRenderTasks.Add makeTask
                            member _.AddFirstAfterRenderTask makeTask = this.FirstAfterRenderTasks.Add makeTask
                            member _.AddParameterSetTask makeTask = this.ParameterSetTasks.Add makeTask
                            member _.AddDispose dispose = this.Disposes.Add dispose
                            member _.AddDisposes ds = this.Disposes.AddRange(ds)
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
    member val RenderFn: 'T -> NodeRenderFragment = fun _ -> emptyNode () with get, set

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
        this.Logger.LogDebugForPerf(fun () ->
            match node with
            | ValueNone -> emptyNode ()
            | ValueSome node -> node
        )


    override _.OnInitialized() =
        let depsType, _ = Reflection.FSharpType.GetFunctionElements(this.RenderFn.GetType())
        let services =
            this.Services.GetMultipleServices(depsType, this.HandleNotFoundType) :?> 'T
        let newNode = this.RenderFn services
        node <- newNode |> ValueSome

        if initializedEvent.IsSome then initializedEvent.Value.Trigger()

    override _.OnInitializedAsync() =
        task {
            if initializedTasks <> null then
                for makeTask in initializedTasks do
                    do! makeTask ()
        }


    override _.OnParametersSet() =
        if this.IsStatic && node.IsSome then
            // Avoid rerender for static mode
            shouldRerender <- false

    override _.OnParametersSetAsync() =
        task {
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

    override _.OnAfterRenderAsync firstRender =
        task {
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
            if disposes <> null then disposes |> Seq.iter (fun x -> x.Dispose())
