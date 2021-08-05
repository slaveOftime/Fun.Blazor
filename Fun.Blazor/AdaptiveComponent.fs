namespace Fun.Blazor

open System
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Bolero


type AdaptiveComponent () as this =
    inherit Component()
    
    let mutable nodeSubscription = null

    [<Parameter>]
    member val Node = Unchecked.defaultof<alist<IFunBlazorNode>> with get, set
        

    member internal _.StateHasChanged() = try base.StateHasChanged() with _ -> ()
    member internal _.Rerender() = this.InvokeAsync(this.StateHasChanged) |> ignore


    override _.Render() = 
        this.Node 
        |> AList.force
        |> IndexList.toList 
        |> FunBlazorNode.Fragment
        |> FunBlazorNode.ToBolero

    override _.OnInitialized() =
        nodeSubscription <- this.Node.AddCallback (fun _ _ ->
            this.Rerender())

    override _.OnParametersSet() = this.Rerender()


    interface IDisposable with
        member _.Dispose() =
            if nodeSubscription <> null then
                nodeSubscription.Dispose()
