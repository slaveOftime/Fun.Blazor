[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.DemoContainer

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor


let demoDivider =
    html.div [
        spaceV4
        mudDivider.create []
        spaceV4
    ]


let demoContainer (title: string) fileName content =
    html.div [
        attr.styles [ style.margin 10 ]
        mudText.create [
            mudText.typo Typo.h6
            mudText.childContent title
        ]
        spaceV2
        mudPaper.create [
            mudPaper.elevation 40
            mudPaper.childContent [ content ]
        ]
        spaceV2
        sourceSection fileName
    ]
