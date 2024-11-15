// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.KeyFramesDemo

open FSharp.Data.Adaptive
open Fun.Blazor

let private isAnimated = cval false
let private animationRotation = "rotation"

let entry = div {
    class' "keyframes-demo"
    button {
        onclick (fun _ -> isAnimated.Publish not)
        "Start/Stop"
    }
    img { src "fun-blazor.png" }
    styleElt {
        ruleset ".keyframes-demo img" {
            displayBlock
            marginTop 50
            marginLeft 50
            width 50
            height 50
            transformOrigin "25px 0"
        }
        keyframes animationRotation {
            keyframeFrom { transformRotate 0 }
            keyframe 30 { opacity 0.0 }
            keyframe 50 { opacity 1.0 }
            keyframe 70 { opacity 0.0 }
            keyframeTo { transformRotate 359 }
        }
    }
    adapt {
        let! isAnimated = isAnimated
        if isAnimated then
            styleElt {
                ruleset ".keyframes-demo img" {
                    animationName animationRotation
                    animationDuration 5
                    animationIterationCountInfinite
                    animationTimingFunctionEase
                }
            }
    }
}
