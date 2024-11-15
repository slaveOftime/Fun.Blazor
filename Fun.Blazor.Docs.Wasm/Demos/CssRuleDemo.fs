// hot-reload
module Fun.Blazor.Docs.Wasm.Demos.CssRuleDemo

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Css

let entry = adapt {
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
