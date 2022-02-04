[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.DemoContainer

open MudBlazor
open Fun.Blazor


let demoDivider =
    div {
        spaceV4
        MudDivider'()
        spaceV4
    }


let demoContainer (titleStr: string) fileName (contentStr: string) =
    div {
        style'' { margin 10 }
        MudText'() {
            Typo Typo.h6
            titleStr
        }
        spaceV2
        MudPaper'() {
            Elevation 40
            contentStr
        }
        spaceV2
        sourceSection fileName
    }
