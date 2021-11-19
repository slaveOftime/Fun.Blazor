[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.DemoContainer

open MudBlazor
open Fun.Blazor


let demoDivider =
    html.div [
        spaceV4
        MudDivider'.create()
        spaceV4
    ]


let demoContainer (titleStr: string) fileName contentStr =
    html.div [
        attr.styles [ style.margin 10 ]
        attr.childContent [
            MudText'() {
                Typo Typo.h6
                childContent titleStr
            }
            spaceV2
            MudPaper'() {
                Elevation 40
                childContent [ contentStr ]
            }
            spaceV2
            sourceSection fileName
        ]
    ]
