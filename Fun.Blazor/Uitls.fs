[<AutoOpen>]
module Fun.Blazor.Uitls

open System
open System.Diagnostics
open System.Text
open System.Reactive.Linq
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open Microsoft.AspNetCore.Components


let emptyAttr = AttrRenderFragment(fun _ _ i -> i)
let emptyNode = NodeRenderFragment(fun _ _ i -> i)


let makeStyles (rules: (string * string) seq) =
    let sb = new StringBuilder()

    for (k, v) in rules do
        sb.Append(k).Append(": ").Append(v).Append(";") |> ignore

    sb


type ILogger with

    member this.LogDebugForPerf fn =
#if DEBUG
        let sw = Stopwatch.StartNew()
        this.LogDebug($"Function started")
        let result = fn ()
        this.LogDebug($"Function finished in {sw.ElapsedMilliseconds}")
        result
#else
        fn ()
#endif


module Observable =
    let ofTask (x: Task<_>) =
        Observable.FromAsync(fun (token: Threading.CancellationToken) -> x)


type IComponent with

    member comp.Render(fragment: NodeRenderFragment) =
        RenderFragment(fun builder -> fragment.Invoke(comp, builder, 0) |> ignore)

    member comp.Callback<'T>(fn: 'T -> unit) = EventCallback.Factory.Create<'T>(comp, fn)
    member comp.Callback<'T>(fn: 'T -> Task) = EventCallback.Factory.Create<'T>(comp, fn)
