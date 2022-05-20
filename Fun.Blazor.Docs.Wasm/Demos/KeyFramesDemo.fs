// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.KeyFramesDemo

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Css

let entry =
    let isAnimated = cval false
    let animationRotation = "rotation"
    div {
        class' "keyframes-demo"
        button {
            onclick (fun _ -> isAnimated.Publish not)
            "Start/Stop"
        }
        div { class' "rectangle" }
        styleElt {
            ruleset ".keyframes-demo .rectangle" {
                backgroundColor color.hotPink
                color color.white
                padding 5
                width 100
                height 100
            }
            keyframes animationRotation {
                keyframeFrom { transformRotate 0 }
                keyframe 50 { backgroundColor color.green }
                keyframeTo { transformRotate 359 }
            }
        }
        adaptiview () {
            let! isAnimated = isAnimated
            if isAnimated then
                styleElt {
                    ruleset ".keyframes-demo .rectangle" {
                        animationName animationRotation
                        animationDuration 5
                        animationIterationCountInfinite
                        animationTimingFunctionEase
                    }
                }
        }
    }
