[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.CECssDemo

open Fun.Blazor
open Fun.Css


let ceCssDemo =
    div(){
        css (CssBuilder(){
            color "red"
            backgroundColor "green"
            height (length.perc 10)
            borderRadius 10
            displayFlex
            flexDirectionRow
            flexWrapWrap
        })
        childContent [
            for _ in 1..10 do
                div(){
                    css (CssBuilder(){
                        width 100
                        height 30
                        borderRadius 15
                        backgroundColor "yellow"
                        margin 10
                    })
                }
        ]
    }
