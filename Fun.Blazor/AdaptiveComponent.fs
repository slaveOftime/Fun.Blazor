namespace Fun.Blazor

open System
open FSharp.Data.Adaptive
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components


type AdaptiveComponent() as this =
    inherit FunBlazorComponent()

    let mutable fragmentSubscription: IDisposable option = None
    let mutable fragment: aval<NodeRenderFragment> = AVal.init emptyNode
    let mutable shouldRerender = true


    [<Parameter>]
    member val Fragment: aval<NodeRenderFragment> = AVal.init emptyNode with get, set

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
        this.Logger.LogDebugForPerf(fun _ -> fragment |> AVal.force)


    override _.OnParametersSet() =
        if this.IsStatic && fragmentSubscription.IsSome then
            // Avoid rerender for static mode
            shouldRerender <- false
        else
            shouldRerender <- true
            fragmentSubscription |> Option.iter (fun x -> x.Dispose())
            fragment <- this.Fragment
            fragmentSubscription <- Some(fragment.AddCallback(fun _ -> this.Rerender()))

    override _.ShouldRender() =
        let result = shouldRerender
        if not shouldRerender then shouldRerender <- true
        result


    interface IDisposable with
        member _.Dispose() =
            fragmentSubscription |> Option.iter (fun x -> x.Dispose())
