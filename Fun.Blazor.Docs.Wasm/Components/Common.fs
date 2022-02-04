[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.Common

open MudBlazor
open Fun.Blazor


let private spaceV (x: int) = div { style'' { height x } }

let private spaceH (x: int) = span { style'' { width x } }

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


let simplePage
    (url: string)
    (titleStr: string)
    (subTitle: string)
    (description: string)
    (demos: NodeRenderFragment)
    =
    html.div [
        attr.styles [ style.marginTop 20; style.marginBottom 20 ]
        attr.childContent [
            MudContainer'() {
                MaxWidth MaxWidth.Large
                MudContainer'() {
                    MaxWidth MaxWidth.Medium
                    MudLink'() {
                        Href url
                        Color Color.Primary
                        Underline Underline.Always
                        MudText'() {
                            Typo Typo.h4
                            Align Align.Center
                            Color Color.Primary
                            childContent titleStr
                        }
                        MudText'() {
                            Typo Typo.h5
                            Align Align.Center
                            childContent subTitle
                        }
                    }
                    spaceV3
                    MudText'() {
                        Typo Typo.body1
                        Align Align.Center
                        childContent description
                    }
                }
                spaceV4
                demos
            }
        ]
    ]
