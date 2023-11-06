// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.CounterClassStyle

open Fun.Blazor

type Counter() =
    inherit FunComponent()

    let mutable count = 0

    override _.Render() = fragment {
        p { $"Current count: {count}" }
        button {
            onclick (fun _ -> count <- count + 1)
            "Click me"
        }
    }

let entry = html.blazor<Counter>()
