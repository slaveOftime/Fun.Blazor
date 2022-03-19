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


let demoContainer (titleStr: string) fileName (demo: NodeRenderFragment) =
    div {
        style { margin 10 }
        childContent [
            MudText'() {
                Typo Typo.h6
                titleStr
            }
            spaceV2
            MudPaper'() {
                Elevation 40
                demo
            }
            spaceV2
            sourceSection fileName
        ]
    }
