namespace Fun.Blazor

open System
open Microsoft.AspNetCore.Components
open Bolero


type StoreComponent<'T> () as this =
    inherit Component()
    
    let mutable subscription = null
    let mutable value = Unchecked.defaultof<'T>

    
    [<Parameter>]
    member val DefaultValue = Unchecked.defaultof<'T> with get, set

    [<Parameter>]
    member val Store = Unchecked.defaultof<IObservable<'T>> with get, set

    [<Parameter>]
    member val RenderFn = Unchecked.defaultof<'T -> FunBlazorNode> with get, set


    member internal _.StateHasChanged() = base.StateHasChanged()
    member internal _.Rerender() = this.InvokeAsync(this.StateHasChanged) |> ignore


    override _.Render() = this.RenderFn value |> FunBlazorNode.ToBolero

    override _.OnInitialized() =
        base.OnInitialized()

        value <- this.DefaultValue
        subscription <- this.Store.Subscribe(fun x ->
            value <- x
            this.Rerender())


    interface IDisposable with
        member _.Dispose() =
            if subscription <> null then
                subscription.Dispose()
