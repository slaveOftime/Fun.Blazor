// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Demos.Counter

open FSharp.Data.Adaptive
open Fun.Blazor
open MudBlazor


let counter =
    let count1 = cval 1
    let count2 = cval 1

    adaptiview () {
        let! count1, setCount1 = count1.WithSetter()
        let! count2, setCount2 = count2.WithSetter()
        div {
            h6 { $"Count1={count1}; Count2={count2}" }
            button {
                onclick (fun _ -> setCount1 (count1 + 1))
                "Increase count 1"
            }
            button {
                onclick (fun _ -> setCount2 (count2 + 1))
                "Increase count 2"
            }
        }
    }
