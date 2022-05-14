[<AutoOpen>]
module Fun.Blazor.Docs.Controls.Common

open MudBlazor
open Fun.Blazor


let private spaceV (x: int) = div { style { height x } }

let private spaceH (x: int) = span { style { width x } }

let spaceV1 = spaceV 2
let spaceV2 = spaceV 6
let spaceV3 = spaceV 10
let spaceV4 = spaceV 16

let spaceH1 = spaceH 2
let spaceH2 = spaceH 6
let spaceH3 = spaceH 10
let spaceH4 = spaceH 16


let linearProgress =
    MudProgressLinear'() {
        Indeterminate true
        Color Color.Primary
    }


let notFound =
    div {
        style { padding 20 }
        MudText'() {
            Typo Typo.subtitle1
            "Content not found"
        }
    }
