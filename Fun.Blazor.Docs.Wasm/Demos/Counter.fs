// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.Counter

open FSharp.Data.Adaptive
open Fun.Blazor

let entry =
    adaptiview () {
        let! count1, setCount1 = cval(1).WithSetter()
        div {
            h6 { $"Count1={count1}" }
            button {
                on.click (fun _ -> setCount1 (count1 + 1))
                "Increase count 1"
            }
        }
    }
