[<AutoOpen>]
module Fun.Blazor.Uitls

open System
open System.Text
open System.Reactive.Linq
open System.Threading.Tasks
open Bolero


let inline (=>) key value = Attr(key, value)


let makeStyles (rules: (string * string) seq) =
    rules
    |> Seq.fold
        (fun (sb: StringBuilder) (k, v) -> sb.Append(k).Append(": ").Append(v).Append(";"))
        (new StringBuilder())


module Observable =
    let ofTask (x: Task<_>) = Observable.FromAsync (fun (token: Threading.CancellationToken) -> x)
