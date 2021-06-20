[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoFluentUI.Demo

open Microsoft.Fast.Components.FluentUI
open Fun.Blazor
open Fun.Blazor.FluentUI


let demoFluentUI = html.inject (fun () ->
    fluentDesignSystemProvider.create [
        fluentCard.create [
            fluentProgress.create [
                fluentProgress.children "progress"
            ]
            fluentMenu.create [
                for i in 0..10 do
                    fluentMenuItem.create [
                        html.text $"hi {i}"
                    ]
            ]
            html.div [
                attr.styles [ style.margin 10 ]
                fluentSkeleton.create [
                    fluentSkeleton.shape Shape.Circle
                    !!(attr.styles [
                        style.width 50
                        style.height 50
                    ])
                ]
                for _ in 1..3 do
                    fluentSkeleton.create [
                        fluentSkeleton.shape Shape.Rect
                        !!(attr.styles [
                            style.borderRadius 4
                            style.marginTop 10
                            style.height 10
                        ])
                    ]
                fluentSkeleton.create [
                    fluentSkeleton.shape Shape.Rect
                    !!(attr.styles [
                        style.borderRadius 4
                        style.marginTop 10
                        style.height 10
                        style.width 200
                    ])
                ]
            ]
        ]
    ])
