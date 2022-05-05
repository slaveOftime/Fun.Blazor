[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.CECssDemo

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Css
open Fun.Css.Internal
open Fun.Blazor.Docs.Wasm.Components


type CssBuilder with

    /// Inline them to get better performance (faster and less allocation)
    /// CombineKeyValue is just a delegate which can pass StringBuilder in and out to concat piece of string together
    /// Finally when style execute, it will invoke the delegate and append all strings together, then make an attribute for blazor element or componennt
    [<CustomOperation("myStyles")>]
    member inline _.myStyles([<InlineIfLambda>] comb: CombineKeyValue) =
        comb
        &&& css {
            custom "border-bottom" "8px solid blue"
            backgroundBlendModeColor
        }


let styleEltDemo =
    adaptiview () {
        let! count, setCount = cval(0).WithSetter()

        div {
            class' "style-elt-demo"
            button {
                onclick (fun _ -> setCount (count + 1))
                "Increase"
            }
            button {
                onclick (fun _ -> setCount (count - 1))
                "Decrease"
            }
            div {
                class' "count"
                count
            }
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
            }
        }
    }


let ceCssDemo =
    html.fragment [
        styleEltDemo
        spaceV4
        div {
            style {
                color color.darkRed
                backgroundColor color.green
                height "10%"
                borderRadius 10
                displayFlex
                flexDirectionRow
                flexWrapWrap
                myStyles
            }
            childContent [
                for _ in 1..10 do
                    div {
                        style {
                            width 100
                            height 30
                            // only support if
                            if 1 < 2 then
                                borderRadius 15
                                backgroundColor color.yellow
                                margin 10
                        //else
                        //    borderBottom (length.px 4) borderStyle.solid color.hotPink
                        // FS3086	A custom operation may not be used in conjunction with 'use', 'try/with', 'try/finally', 'if/then/else' or 'match' operators within this computation expression	Fun.Blazor.Docs.Wasm	C:\Users\woo\Documents\Code\Slaveoftime\Fun.Blazor\Fun.Blazor.Docs.Wasm\Pages\HelperFunctions\CECssDemo.fs	32	Active
                        }
                    }
                div {
                    style {
                        width 100
                        height 30
                        // But you can yield another CombineKeyValue delegate like:
                        // css is short name to build a CssBuilder which will return as a CombineKeyValue delegate
                        match 1 with
                        | 1 -> css { backgroundColor "red" }
                        | 2 -> css { backgroundColor "blue" }
                        | _ -> css { backgroundColor "green" }
                    }
                }
            ]
        }
    ]
