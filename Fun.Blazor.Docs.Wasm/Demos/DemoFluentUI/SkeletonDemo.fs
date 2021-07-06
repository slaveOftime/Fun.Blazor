[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoFluentUI.SkeletonDemo

open Fun.Blazor
open Microsoft.Fast.Components.FluentUI

let skeletonDemo =
    html.div [
        attr.styles [ style.margin 10 ]
        fluentSkeleton() {
            shape Shape.Circle
            styles [
                style.width 50
                style.height 50
            ]
        }
        for _ in 1..3 do
            fluentSkeleton() {
                shape Shape.Rect
                styles [
                    style.borderRadius 4
                    style.marginTop 10
                    style.height 10
                ]
            }
        fluentSkeleton() {
            shape Shape.Rect
            styles [
                style.borderRadius 4
                style.marginTop 10
                style.height 10
                style.width 200
            ]
        }
    ]
