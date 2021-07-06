[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.Common

open MudBlazor
open Fun.Blazor


let private spaceV (x: int) = 
    html.div [
        attr.styles [ style.height x ]
    ]

let private spaceH (x: int) = 
    html.span [
        attr.styles [ style.width x ]
    ]

let spaceV1 = spaceV 2
let spaceV2 = spaceV 6
let spaceV3 = spaceV 10
let spaceV4 = spaceV 16

let spaceH1 = spaceH 2
let spaceH2 = spaceH 6
let spaceH3 = spaceH 10
let spaceH4 = spaceH 16

let simplePage (url: string) (titleStr: string) (subTitle: string) (description: string) demos =
    html.div [
        attr.styles [
            style.marginTop 20
            style.marginBottom 20
        ]
        mudContainer() {
            maxWidth MaxWidth.Large
            childContent [
                mudContainer() {
                    maxWidth MaxWidth.Medium
                    childContent [
                        mudLink() {
                            href url
                            color Color.Primary
                            underline Underline.Always
                            childContent [
                                mudText() {
                                    typo Typo.h4
                                    align Align.Center
                                    color Color.Primary
                                    childContent titleStr
                                }
                                mudText() {
                                    typo Typo.h5
                                    align Align.Center
                                    childContent subTitle
                                }
                            ]
                        }
                        spaceV3
                        mudText() {
                            typo Typo.body1
                            align Align.Center
                            childContent description
                        }
                    ]
                }

                spaceV4

                yield! demos
            ]
        }
    ]
