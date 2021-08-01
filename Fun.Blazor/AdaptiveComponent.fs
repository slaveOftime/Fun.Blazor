namespace Fun.Blazor

open System
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Bolero


type AdaptiveComponent () as this =
    inherit Component()
    
    let mutable subscription = null
    let mutable node = None

    [<Parameter>]
    member val RenderFn = Unchecked.defaultof<aval<IFunBlazorNode>> with get, set
        
    [<Parameter>]
    member val OnDisposeFn = Unchecked.defaultof<unit -> unit> with get, set


    member internal _.StateHasChanged() = try base.StateHasChanged() with _ -> ()
    member internal _.Rerender() = this.InvokeAsync(this.StateHasChanged) |> ignore


    override _.Render() =
        match node with
        | None -> Html.empty
        | Some node -> FunBlazorNode.ToBolero node

        
    override _.OnInitialized() =
        base.OnInitialized()

        node <- this.RenderFn |> AVal.force |> Some
        subscription <- this.RenderFn.AddCallback (fun x ->
            node <- Some x
            this.Rerender())


    interface IDisposable with
        member _.Dispose() =
            if subscription <> null then
                subscription.Dispose()

            if box this.OnDisposeFn <> null then
                this.OnDisposeFn()
