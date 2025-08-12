module Fun.Blazor.Tests.StyleTests

open Xunit
open Bunit
open Fun.Blazor
open Fun.Css


[<Fact>]
let ``basic style should work``() =
    let textContext = new TestContext()
    let count = 3

    let dom = fragment {
        styleElt {
            ruleset ".style-elt-demo button" {
                backgroundColor color.blue
                color color.white
                padding 5
                margin "10px 10px 10px 0px"
                borderRadius 5
            }
            ruleset ".style-elt-demo .count" {
                color color.green
                backgroundColor color.pink
                textAlignCenter
                width 100
                padding 10
                borderRadius 10
                if count > 2 then
                    css {
                        borderStyleSolid
                        borderColor color.red
                        borderWidth 2
                    }
            }
            ruleset ".style-elt-demo .count:hover" {
                color color.white
                fontSize 20
            }
            ruleset ".keyframes-demo img" {
                displayBlock
                marginTop 50
                marginLeft 50
                width 50
                height 50
                transformOrigin "25px 0"
            }
            keyframes "animationRotation" {
                keyframeFrom { transformRotate 0 }
                keyframe 30 { opacity 0.0 }
                keyframe 50 { opacity 1.0 }
                keyframe 70 { opacity 0.0 }
                keyframeTo { transformRotate 359 }
            }
            """
            .free-style {
                height: 100px;
            }
            """
        }
    }

    textContext.RenderNode(dom).MarkupMatches("""
    <style>
    .style-elt-demo button {
        background-color: #0000FF; color: #FFFFFF; padding: 5px; margin: 10px 10px 10px 0px; border-radius: 5px;
    }
    .style-elt-demo .count {
        color: #008000; background-color: #FFC0CB; text-align: center; width: 100px; padding: 10px; border-radius: 10px; border-style: solid; border-color: #FF0000; border-width: 2px;
    }
    .style-elt-demo .count:hover {
        color: #FFFFFF; font-size: 20px;
    }
    .keyframes-demo img {
        display: block; margin-top: 50px; margin-left: 50px; width: 50px; height: 50px; transform-origin: 25px 0;
    }
    @keyframes animationRotation {
        from {
            transform: rotate(0deg);
        }
        30% {
            opacity: 0;
        }
        50% {
            opacity: 1;
        }
        70% {
            opacity: 0;
        }
        to {
            transform: rotate(359deg);
        }
    }
    .free-style {
        height: 100px;
    }
    </style>
    """)
