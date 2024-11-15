// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.Counter

open FSharp.Data.Adaptive
open Fun.Blazor
open MudBlazor

let entry =
    adapt {
        let amount = 1
        let! count, setCount = cval(1).WithSetter()
        div {
            p { "Count="; count }
            MudButton'' {
                Size Size.Small
                Variant Variant.Outlined
                OnClick (fun _ -> setCount (count + amount))
                "Increase count by "; amount
            }
        }
    }
