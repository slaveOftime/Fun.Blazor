namespace Fun.Blazor

open System
open System.Collections.Generic
open FSharp.Data.Adaptive
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


type DIComponent<'T>() as this =
    inherit FunBlazorComponent()

    let mutable node = None
    let mutable shouldRerender = true

    let initialized = new Event<unit>()
    let afterRenderEvent = new Event<bool>()
    let firstAfterRenderEvent = new Event<unit>()
    let disposeEvent = new Event<unit>()
    let disposes = new List<IDisposable>()


    let blazorLifecycle =
        { new IComponentHook with
            member _.OnAfterRender = afterRenderEvent.Publish
            member _.OnInitialized = initialized.Publish
            member _.OnFirstAfterRender = firstAfterRenderEvent.Publish
            member _.OnDispose = disposeEvent.Publish
            member _.AddDispose dispose = disposes.Add dispose
            member _.AddDisposes ds = disposes.AddRange(ds)
            member _.StateHasChanged() = this.ForceRerender()
            member _.ServiceProvider = this.Services
            member _.ScopedServiceProvider =
                if isNull this.ScopedServices then
                    failwithf
                        "You should use html.scoped to wrap your components. Or create a CascadeValue component to provide a IServiceProvider with name '%s'"
                        Internal.FunBlazorScopedServicesName
                this.ScopedServices
        }


    let handleNotFoundType ty = if ty = typeof<IComponentHook> then box blazorLifecycle else null


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
            | None -> emptyNode ()
            | Some node -> node
        )


    override _.OnInitialized() =
        let depsType, _ = Reflection.FSharpType.GetFunctionElements(this.RenderFn.GetType())
        let services =
            this.Services.GetMultipleServices(depsType, handleNotFoundType) :?> 'T
        let newNode = this.RenderFn services
        node <- newNode |> Some

        initialized.Trigger()


    override _.OnParametersSet() =
        if this.IsStatic && node.IsSome then
            // Avoid rerender for static mode
            shouldRerender <- false


    override _.ShouldRender() =
        let result = shouldRerender
        if not shouldRerender then shouldRerender <- true
        result


    override _.OnAfterRender firstRender =
        afterRenderEvent.Trigger firstRender
        if firstRender then firstAfterRenderEvent.Trigger()


    interface IDisposable with
        member _.Dispose() =
            disposeEvent.Trigger()
            disposes |> Seq.iter (fun x -> x.Dispose())
