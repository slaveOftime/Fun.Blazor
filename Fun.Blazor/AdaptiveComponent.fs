namespace Fun.Blazor

open System
open FSharp.Data.Adaptive
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components
open Operators


type AdaptiveComponent() as this =
    inherit FunBlazorComponent()

    let mutable nodeSubscription: IDisposable option = None
    let mutable node = AList.empty<FunRenderFragment>
    let mutable shouldRerender = true


    [<Parameter>]
    member val Node = AList.empty with get, set

    [<Parameter>]
    member val IsStatic = false with get, set

    [<Inject>]
    member val Logger = Unchecked.defaultof<ILogger<AdaptiveComponent>> with get, set


    member internal _.StateHasChanged() =
        try
            base.StateHasChanged()
        with
            | _ -> ()

    member internal _.Rerender() = this.InvokeAsync(this.StateHasChanged) |> ignore


    override _.Render() =
        this.Logger.LogDebugForPerf(fun _ -> node |> AList.force |> IndexList.toList |> List.fold (&&&) emptyRender)


    override _.OnParametersSet() =
        if this.IsStatic && nodeSubscription.IsSome then
            // Avoid rerender for static mode
            shouldRerender <- false
        else
            shouldRerender <- true
            nodeSubscription |> Option.iter (fun x -> x.Dispose())
            node <- this.Node
            nodeSubscription <- Some(node.AddCallback(fun _ _ -> this.Rerender()))

    override _.ShouldRender() =
        let result = shouldRerender
        if not shouldRerender then shouldRerender <- true
        result


    interface IDisposable with
        member _.Dispose() =
            nodeSubscription |> Option.iter (fun x -> x.Dispose())
