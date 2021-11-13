[<AutoOpen>]
module Fun.Blazor.Uitls

open System
open System.Reactive.Linq
open System.Threading.Tasks


let inline (!!) (node: IFunBlazorNode) = GenericFunBlazorNode.create node

let inline genericFunBlazor node = GenericFunBlazorNode.create node


module Observable =
    let ofTask (x: Task<_>) = Observable.FromAsync (fun (token: Threading.CancellationToken) -> x)
