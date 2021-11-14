namespace Fun.Blazor

open System
open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components


type AdaptiveComponent () as this =
    inherit FunBlazorComponent()
    
    let mutable nodeSubscription: IDisposable option = None

    [<Parameter>]
    member val Node = Unchecked.defaultof<alist<IFunBlazorNode>> with get, set
        

    member internal _.StateHasChanged() = try base.StateHasChanged() with _ -> ()
    member internal _.Rerender() = this.InvokeAsync(this.StateHasChanged) |> ignore


    override _.Render() = 
        this.Node 
        |> AList.force
        |> IndexList.toList 
        |> FunBlazorNode.Fragment
        :> IFunBlazorNode


    override _.OnParametersSet() =
        nodeSubscription |> Option.iter (fun x -> x.Dispose())
        nodeSubscription <- Some (this.Node.AddCallback (fun _ _ ->
            this.Rerender()))


    interface IDisposable with
        member _.Dispose() =
            nodeSubscription |> Option.iter (fun x -> x.Dispose())
