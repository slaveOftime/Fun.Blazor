namespace Fun.Blazor

open System
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components


type StoreComponent<'T>() as this =
    inherit FunBlazorComponent()

    let mutable subscription = null
    let mutable value = Unchecked.defaultof<'T>
    let mutable isValueSet = false


    [<Parameter>]
    member val DefaultValue = Unchecked.defaultof<'T> with get, set

    [<Parameter>]
    member val Store = Unchecked.defaultof<IObservable<'T>> with get, set

    [<Parameter>]
    member val RenderFn: 'T -> NodeRenderFragment = fun _ -> emptyNode() with get, set

    [<Inject>]
    member val Logger = Unchecked.defaultof<ILogger<StoreComponent<'T>>> with get, set


    override _.Render() =
        this.Logger.LogDebugForPerf(fun () ->
            if not isValueSet && box value = null then emptyNode() else this.RenderFn value
        )


    override _.OnInitialized() =
        base.OnInitialized()

        value <- this.DefaultValue
        isValueSet <- true
        subscription <-
            this.Store.Subscribe(fun x ->
                value <- x
                this.ForceRerender()
            )


    interface IDisposable with
        member _.Dispose() =
            if subscription <> null then subscription.Dispose()
