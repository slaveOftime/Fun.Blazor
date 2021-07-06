[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.DemoContainer

open MudBlazor
open Fun.Blazor


let demoDivider =
    html.div [
        spaceV4
        mudDivider.create()
        spaceV4
    ]


let demoContainer (titleStr: string) fileName contentStr =
    html.div [
        attr.styles [ style.margin 10 ]
        mudText() {
            typo Typo.h6
            childContent titleStr
        }
        spaceV2
        mudPaper() {
            elevation 40
            childContent [ contentStr ]
        }
        spaceV2
        sourceSection fileName
    ]
