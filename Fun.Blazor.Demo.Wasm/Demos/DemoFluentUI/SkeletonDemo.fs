[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoFluentUI.SkeletonDemo

open Microsoft.Fast.Components.FluentUI
open Fun.Blazor
open Fun.Blazor.FluentUI

let skeletonDemo =
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
