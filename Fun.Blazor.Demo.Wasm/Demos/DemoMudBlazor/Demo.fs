[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoMudBlazor.Demo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Blazor.Demo.Wasm.Components


let private demoDivider =
    html.div [
        spaceV3
        mudDivider.create [ 
            mudDivider.dividerType DividerType.Inset
            mudDivider.light false
        ]
        spaceV3
    ]

let private rootDir = "Demos/DemoMudBlazor"


let demoMudBlazor = html.inject (fun () ->
    
    html.div [
        attr.styles [
            style.marginTop 20
            style.marginBottom 20
        ]
        mudThemeProvider.create []
        mudDialogProvider.create []
        mudSnackbarProvider.create []
        mudContainer.create [
            mudContainer.maxWidth MaxWidth.Large
            mudContainer.children [ 
                mudLink.create [
                    mudLink.href "https://mudblazor.com/"
                    mudLink.color Color.Primary
                    mudLink.children [
                        mudText.create [
                            mudText.typo Typo.h2
                            mudText.align Align.Center
                            mudText.color Color.Primary
                            mudText.children "Blazor components"
                        ]
                        mudText.create [
                            mudText.typo Typo.h2
                            mudText.align Align.Center
                            mudText.color Color.Secondary
                            mudText.children "Blazor components For faster and easier web development"
                        ]
                    ]
                ]
                spaceV2
                mudText.create [
                    mudText.typo Typo.body1
                    mudText.align Align.Center
                    mudText.children "MudBlazor is perfect for .NET developers who want to rapidly build amazing web applications without having to struggle with CSS and Javascript. Being written entirely in C#, it empowers you to adapt or extend the framework."
                ]

                spaceV4

                demoContainer "Alert" $"{rootDir}/AlertDemo" alertDemo
                demoDivider
                demoContainer "AppBar" $"{rootDir}/AppBarDemo" appBarDemo
            ]
        ]
    ])
