[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoFluentUI.Demo

open MudBlazor
open Microsoft.Fast.Components.FluentUI
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Blazor.FluentUI

open Fun.Blazor.Demo.Wasm.Components


let private rootDir = "Demos/DemoFluentUI"


let demoFluentUI = html.inject (fun () ->
    html.div [
        mudContainer.create [
            mudContainer.maxWidth MaxWidth.Medium
            mudContainer.childContent [
                mudLink.create [
                    mudLink.href "https://www.fast.design/"
                    mudLink.color Color.Primary
                    mudLink.underline Underline.Always
                    mudLink.childContent [
                        mudText.create [
                            mudText.typo Typo.h4
                            mudText.align Align.Center
                            mudText.color Color.Primary
                            mudText.childContent "The adaptive interface system for modern web experiences"
                        ]
                    ]
                ]
                spaceV3
                mudText.create [
                    mudText.typo Typo.body1
                    mudText.align Align.Center
                    mudText.childContent "Interfaces built with FAST adapt to your design system and can be used with any modern UI Framework by leveraging industry standard Web Components."
                ]
            ]
        ]
        spaceV4
        mudContainer.create [
            mudContainer.maxWidth MaxWidth.Large
            mudContainer.childContent [
                fluentDesignSystemProvider.create [
                    demoContainer "Skeleton" $"{rootDir}/SkeletonDemo" skeletonDemo
                ]
            ]
        ]
        html.script [
            attr.src "https://unpkg.com/@fluentui/web-components"
            attr.type' "module"
        ]
    ])
