[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoMudBlazor.Demo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Blazor.Demo.Wasm.Components


let private demoDivider =
    html.div [
        spaceV4
        mudDivider.create []
        spaceV4
    ]

let private rootDir = "Demos/DemoMudBlazor"


let demoMudBlazor = html.inject (fun () ->
    
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
                            mudLink.href "https://mudblazor.com/"
                            mudLink.color Color.Primary
                            mudLink.underline Underline.Always
                            mudLink.childContent [
                                mudText.create [
                                    mudText.typo Typo.h4
                                    mudText.align Align.Center
                                    mudText.color Color.Primary
                                    mudText.childContent "MudBlazor"
                                ]
                                mudText.create [
                                    mudText.typo Typo.h5
                                    mudText.align Align.Center
                                    mudText.childContent "For faster and easier web development"
                                ]
                            ]
                        ]
                        spaceV3
                        mudText.create [
                            mudText.typo Typo.body1
                            mudText.align Align.Center
                            mudText.childContent "MudBlazor is perfect for .NET developers who want to rapidly build amazing web applications without having to struggle with CSS and Javascript. Being written entirely in C#, it empowers you to adapt or extend the framework."
                        ]
                    ]
                ]

                spaceV4

                demoContainer "Alert" $"{rootDir}/AlertDemo" alertDemo
                demoDivider
                demoContainer "AppBar" $"{rootDir}/AppBarDemo" appBarDemo
            ]
        ]
    ])
