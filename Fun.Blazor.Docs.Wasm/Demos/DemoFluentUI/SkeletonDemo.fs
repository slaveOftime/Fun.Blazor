[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoFluentUI.SkeletonDemo

open Fun.Blazor
open Microsoft.Fast.Components.FluentUI

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
        fluentCheckbox.create [
            fluentCheckbox.value true
            fluentCheckbox.displayName "Check me"
            fluentCheckbox.required true
        ]
    ]
