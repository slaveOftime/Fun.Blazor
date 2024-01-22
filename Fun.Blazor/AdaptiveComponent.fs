namespace Fun.Blazor

open System
open System.Diagnostics.CodeAnalysis
open FSharp.Data.Adaptive
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components
open Internal


type AdaptiveComponent [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<AdaptiveComponent>)>] () as this =
    inherit FunBlazorComponent()

    let mutable fragmentSubscription: IDisposable voption = ValueNone
    let mutable fragment = AVal.constant (emptyNode ())
    let mutable shouldRerender = true


    [<Parameter>]
    member val Fragment: aval<NodeRenderFragment> = AVal.constant (emptyNode ()) with get, set

    [<Parameter>]
    member val IsStatic = false with get, set

    [<Parameter>]
    member val DisableEventTriggerStateHasChangedParam = true with get, set

    [<Inject>]
    member val Logger = Unchecked.defaultof<ILogger<AdaptiveComponent>> with get, set


    override _.Render() = html.region (this.Logger.LogDebugForPerf(fun _ -> fragment |> AVal.force))


    override _.OnParametersSet() =
        this.DisableEventTriggerStateHasChanged <- this.DisableEventTriggerStateHasChangedParam

        if this.IsStatic && fragmentSubscription.IsSome then
            // Avoid rerender for static mode
            shouldRerender <- false
        else
            shouldRerender <- true
            fragmentSubscription |> ValueOption.iter (fun x -> x.Dispose())
            fragment <- this.Fragment
            fragmentSubscription <- ValueSome(fragment.AddCallback(fun _ -> this.ForceRerender()))

    override _.ShouldRender() =
        let result = shouldRerender
        if not shouldRerender then shouldRerender <- true
        result


    interface IDisposable with
        member _.Dispose() = fragmentSubscription |> ValueOption.iter (fun x -> x.Dispose())
