[<AutoOpen>]
module Fun.Blazor.Utils

open System
open System.Threading.Tasks
open System.Reactive.Linq


module Observable =
    let ofTask (x: Task<_>) = Observable.FromAsync(fun (token: Threading.CancellationToken) -> x)
