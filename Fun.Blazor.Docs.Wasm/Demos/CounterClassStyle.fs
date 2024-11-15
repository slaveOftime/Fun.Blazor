// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.CounterClassStyle

open Fun.Blazor
open MudBlazor

type Counter() =
    inherit FunComponent()

    let amount = 1
    let mutable count = 0

    override _.Render() =  div {
        p { "Count="; count }
        MudButton'' {
            Size Size.Small
            Variant Variant.Outlined
            OnClick (fun _ -> count <- count + amount)
            "Increase count by "; amount
        }
    }

let entry = html.blazor<Counter>()
