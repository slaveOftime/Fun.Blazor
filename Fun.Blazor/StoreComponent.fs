namespace Fun.Blazor

open System
open Microsoft.AspNetCore.Components
open Bolero


type StoreComponent<'T> () as this =
    inherit Component()
    
    let mutable subscription = null
    let mutable value = Unchecked.defaultof<'T>
    let mutable isValueSet = false

    
    [<Parameter>]
    member val DefaultValue = Unchecked.defaultof<'T> with get, set

    [<Parameter>]
    member val Store = Unchecked.defaultof<IObservable<'T>> with get, set

    [<Parameter>]
    member val RenderFn = Unchecked.defaultof<'T -> IFunBlazorNode> with get, set


    member internal _.StateHasChanged() = try base.StateHasChanged() with _ -> ()
    member internal _.Rerender() = this.InvokeAsync(this.StateHasChanged) |> ignore


    override _.Render() =
        if not isValueSet && box value = null then Html.empty
        else this.RenderFn value |> FunBlazorNode.ToBolero

        
    override _.OnInitialized() =
        base.OnInitialized()

        value <- this.DefaultValue
        isValueSet <- true
        subscription <- this.Store.Subscribe(fun x ->
            value <- x
            this.Rerender())


    interface IDisposable with
        member _.Dispose() =
            if subscription <> null then
                subscription.Dispose()
