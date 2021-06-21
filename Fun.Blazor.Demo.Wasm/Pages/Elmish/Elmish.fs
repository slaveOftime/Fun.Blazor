[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Pages.Elmish.Elmish

open Fun.Blazor.Demo.Wasm.Components


let root = "Pages/Elmish"

let elmish =
    simplePage 
        "https://elmish.github.io/elmish/"
        "Elmish MVU"
        "Loved by a lot of F# developers"
        "Elmish implements core abstractions that can be used to build Fable applications following the “model view update” style of architecture, as made famous by Elm."
        [
            demoContainer "Elmish" $"{root}/ElmishDemo" elmishDemo
        ]
