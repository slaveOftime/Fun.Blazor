[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.Common

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor


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

let simplePage (url: string) (title: string) (subTitle: string) (description: string) demos =
    html.div [
        attr.styles [
            style.marginTop 20
            style.marginBottom 20
        ]
        mudContainer.create [
            mudContainer.maxWidth MaxWidth.Large
            mudContainer.childContent [
                mudContainer.create [
                    mudContainer.maxWidth MaxWidth.Medium
                    mudContainer.childContent [
                        mudLink.create [
                            mudLink.href url
                            mudLink.color Color.Primary
                            mudLink.underline Underline.Always
                            mudLink.childContent [
                                mudText.create [
                                    mudText.typo Typo.h4
                                    mudText.align Align.Center
                                    mudText.color Color.Primary
                                    mudText.childContent title
                                ]
                                mudText.create [
                                    mudText.typo Typo.h5
                                    mudText.align Align.Center
                                    mudText.childContent subTitle
                                ]
                            ]
                        ]
                        spaceV3
                        mudText.create [
                            mudText.typo Typo.body1
                            mudText.align Align.Center
                            mudText.childContent description
                        ]
                    ]
                ]

                spaceV4

                yield! demos
            ]
        ]
    ]
