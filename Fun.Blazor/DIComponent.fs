namespace Fun.Blazor

open System
open System.Collections.Generic
open Microsoft.AspNetCore.Components
open Bolero


[<AutoOpen>]
module ServiceProviderExtensions =
    type IServiceProvider with
        member sp.GetMultipleServices(depsType: Type, handleNotFoundType) =
            let getSvc x =
                let svc = sp.GetService(x)
                if svc = null then handleNotFoundType x
                else svc

            if depsType = typeof<unit> then
                box ()
            elif Reflection.FSharpType.IsTuple depsType then
                let svcs =
                    depsType
                    |> Reflection.FSharpType.GetTupleElements
                    |> Array.map getSvc
                Reflection.FSharpValue.MakeTuple(svcs, depsType)
            else
                getSvc depsType

        member sp.GetMultipleServices(depsType: Type) = sp.GetMultipleServices(depsType, fun _ -> null)

        member sp.GetMultipleServices<'Types>() =
            sp.GetMultipleServices(typeof<'Types>, fun _ -> null)
            |> unbox<'Types>


type DIComponent<'T>() as this =
    inherit Component()
    
    let mutable node = None

    let parametersSet = new Event<unit>()
    let initialized = new Event<unit>()
    let afterRenderEvent = new Event<bool>()
    let firstAfterRenderEvent = new Event<unit>()
    let disposeEvent = new Event<unit>()
    let disposes = new List<IDisposable>()

    let blazorLifecycle =
        { new IComponentHook with
            //member _.ParametersSet = parametersSet.Publish
            //member _.Initialized = initialized.Publish
            member _.OnAfterRender = afterRenderEvent.Publish
            member _.OnFirstAfterRender = firstAfterRenderEvent.Publish
            member _.OnDispose = disposeEvent.Publish
            member _.AddDispose dispose = disposes.Add dispose
            member _.AddDisposes ds = disposes.AddRange(ds)
            member _.StateHasChanged () = this.ForceSetState()
            member _.UseStore<'T> x =
                let store = new Store<'T>(x)
                disposes.Add store
                store :> IStore<'T> }

    let handleNotFoundType ty =
        if ty = typeof<IComponentHook> then box blazorLifecycle
        else null

    [<Parameter>]
    member val RenderFn = Unchecked.defaultof<'T -> IFunBlazorNode> with get, set

    [<Inject>]
    member val Services = Unchecked.defaultof<IServiceProvider> with get, set

    member internal _.StateHasChanged() = base.StateHasChanged()
    member internal _.ForceSetState() = this.InvokeAsync(this.StateHasChanged) |> ignore

    override _.Render() =
        match node with
        | None ->
            let depsType, tailFunc = Reflection.FSharpType.GetFunctionElements(this.RenderFn.GetType())
            let services = this.Services.GetMultipleServices(depsType, handleNotFoundType) :?> 'T
            let newNode = this.RenderFn services |> FunBlazorNode.ToBolero
            node <- Some newNode
            newNode

        | Some node ->
            node
        
    override _.OnParametersSet () =
        base.OnParametersSet()
        parametersSet.Trigger()

    override _.OnInitialized () =
        base.OnInitialized()
        initialized.Trigger()

    override _.OnAfterRender firstRender =
        base.OnAfterRender firstRender
        afterRenderEvent.Trigger firstRender
        if firstRender then firstAfterRenderEvent.Trigger()

    interface IDisposable with
        member _.Dispose () =
            disposeEvent.Trigger()
            disposes |> Seq.iter (fun x -> x.Dispose())
