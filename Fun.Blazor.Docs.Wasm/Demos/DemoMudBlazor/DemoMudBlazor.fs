[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoMudBlazor.Demo

open Fun.Blazor.Docs.Wasm.Components


let private rootDir = "Demos/DemoMudBlazor"


let demoMudBlazor =
    simplePage
        "https://mudblazor.com/"
        "MudBlazor"
        "For faster and easier web development"
        "MudBlazor is perfect for .NET developers who want to rapidly build amazing web applications without having to struggle with CSS and Javascript. Being written entirely in C#, it empowers you to adapt or extend the framework."
        [
            demoContainer "Alert" $"{rootDir}/AlertDemo" alertDemo
            demoDivider
            demoContainer "AppBar" $"{rootDir}/AppBarDemo" appBarDemo
        ]
