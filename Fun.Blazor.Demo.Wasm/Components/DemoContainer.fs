[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Components.DemoContainer

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor


let demoContainer (title: string) fileName content =
    html.div [
        attr.styles [ style.margin 10 ]
        mudText.create [
            mudText.typo Typo.h4
            mudText.children title
        ]
        spaceV2
        mudPaper.create [
            mudPaper.elevation 40
            mudPaper.children [ content ]
        ]
        spaceV2
        sourceSection fileName
    ]
