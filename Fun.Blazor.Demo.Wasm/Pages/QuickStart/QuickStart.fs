[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Pages.QuickStart.QuickStart

open Fun.Blazor
open Fun.Blazor.Demo.Wasm.Components


let root = "Pages/QuickStart"

let quickStart =
    simplePage
        "https://github.com/slaveOftime/Fun.Blazor"
        "Fun.Blazor"
        "This is a project to make F# developer to write blazor easier."
        "It is based on Bolero and Feliz.Engine"
        [
            demoContainer "Basic usage" $"{root}/BasicUsageDemo" basicUsageDemo
            demoDivider
        ]
