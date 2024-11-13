// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.Counter

open FSharp.Data.Adaptive
open Fun.Blazor

let entry =
    adapt {
        let! count1, setCount1 = cval(1).WithSetter()
        div.create [|
            h6 { $"Count1={count1}" }
            button {
                onclick (fun _ -> setCount1 (count1 + 1))
                "Increase count 1"
            }
        |]
    }
