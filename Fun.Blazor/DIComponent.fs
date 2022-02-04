namespace Fun.Blazor

open System
open System.Collections.Generic
open FSharp.Data.Adaptive
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components


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

        member sp.GetMultipleServices(depsType: Type) = sp.GetMultipleServices(depsType, (fun _ -> null))

        member sp.GetMultipleServices<'Types>() =
            sp.GetMultipleServices(typeof<'Types>, (fun _ -> null)) |> unbox<'Types>


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

            member _.UseStore<'T>(x: 'T) : IStore<'T> =
                let newStore = new Store<'T>(x)
                disposes.Add newStore
                newStore :> IStore<'T>

            member _.UseAVal<'T>(store: IStore<'T>) : aval<'T> =
                let value' = cval store.Current
                store.Observable.Subscribe(fun x -> transact (fun _ -> value'.Value <- x)) |> disposes.Add
                value' :> aval<'T>

            member _.UseAVal<'T>(defaultValue: 'T, obser: IObservable<'T>) : aval<'T> =
                let value' = cval defaultValue
                obser.Subscribe(fun x -> transact (fun _ -> value'.Value <- x)) |> disposes.Add
                value' :> aval<'T>

            member _.UseCVal<'T>(store: IStore<'T>) : cval<'T> =
                let value' = cval store.Current
                store.Observable.Subscribe(fun x -> transact (fun _ -> value'.Value <- x)) |> disposes.Add
                value'.AddCallback(fun (x: 'T) -> store.Publish x) |> disposes.Add
                value'
        }


    let handleNotFoundType ty =
        if ty = typeof<IComponentHook> then box blazorLifecycle else null


    [<Parameter>]
    member val RenderFn: 'T -> NodeRenderFragment = fun _ -> emptyNode with get, set

    /// With this we can avoid rerender when parameter reset
    /// If component is not recreated then all the rerender will use the closure state created by the first RenderFn
    [<Parameter>]
    member val IsStatic = false with get, set

    [<Inject>]
    member val Services = Unchecked.defaultof<IServiceProvider> with get, set

    [<Inject>]
    member val Logger = Unchecked.defaultof<ILogger<DIComponent<'T>>> with get, set


    override _.Render() =
        this.Logger.LogDebugForPerf(fun () ->
            match node with
            | None -> emptyNode
            | Some node -> node
        )


    override _.OnInitialized() =
        let depsType, _ = Reflection.FSharpType.GetFunctionElements(this.RenderFn.GetType())
        let services = this.Services.GetMultipleServices(depsType, handleNotFoundType) :?> 'T
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
