[<AutoOpen>]
module Fun.Blazor.Demo.FluentUIDemo

open Microsoft.Fast.Components.FluentUI
open Fun.Blazor
open Fun.Blazor.FluentUI


let fluentUIDemo = html.inject (fun () ->
    fluentDesignSystemProvider.fluentDesignSystemProvider [
        fluentCard.fluentCard [
            fluentProgress.fluentProgress [
                fluentProgress.children "progress"
            ]
            fluentMenu.fluentMenu [
                for i in 0..10 do
                    fluentMenuItem.fluentMenuItem [
                        html.text $"hi {i}"
                    ]
            ]
            html.div [
                attr.styles [ style.margin 10 ]
                fluentSkeleton.fluentSkeleton [
                    fluentSkeleton.shape Shape.Circle
                    !!(attr.styles [
                        style.width 50
                        style.height 50
                    ])
                ]
                for _ in 1..3 do
                    fluentSkeleton.fluentSkeleton [
                        fluentSkeleton.shape Shape.Rect
                        !!(attr.styles [
                            style.borderRadius 4
                            style.marginTop 10
                            style.height 10
                        ])
                    ]
                fluentSkeleton.fluentSkeleton [
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
