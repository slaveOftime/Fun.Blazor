[<AutoOpen>]
module Fun.Blazor.Uitls

open System
open System.Diagnostics
open System.Text
open System.Reactive.Linq
open System.Threading.Tasks
open Microsoft.Extensions.Logging
open Bolero


let inline (=>) key value = Attr(key, value)


let makeStyles (rules: (string * string) seq) =
    rules
    |> Seq.fold
        (fun (sb: StringBuilder) (k, v) -> sb.Append(k).Append(": ").Append(v).Append(";"))
        (new StringBuilder())


type ILogger with
    member this.LogDebugForPerf fn =
        #if DEBUG
        let sw = Stopwatch.StartNew()
        this.LogDebug($"Function started")
        let result = fn()
        this.LogDebug($"Function finished in {sw.ElapsedMilliseconds}")
        result
        #else
        fn()
        #endif


module Observable =
    let ofTask (x: Task<_>) = Observable.FromAsync (fun (token: Threading.CancellationToken) -> x)
