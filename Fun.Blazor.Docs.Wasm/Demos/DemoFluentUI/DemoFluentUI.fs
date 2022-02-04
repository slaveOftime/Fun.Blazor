[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoFluentUI.Demo

open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components


let private rootDir = "Demos/DemoFluentUI"


let demoFluentUI =
    div {
        simplePage
            "https://www.fast.design/"
            "Fast FluentUI"
            "The adaptive interface system for modern web experiences"
            "Interfaces built with FAST adapt to your design system and can be used with any modern UI Framework by leveraging industry standard Web Components."
            (demoContainer "Skeleton" $"{rootDir}/SkeletonDemo" skeletonDemo)
    }
