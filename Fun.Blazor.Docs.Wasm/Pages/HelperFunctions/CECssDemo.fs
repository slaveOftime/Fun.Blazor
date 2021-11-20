[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.CECssDemo

open Fun.Blazor
open Fun.Css

type CssBuilder with
    [<CustomOperation("myStyles")>]
    member this.myStyles (_) =
        this.AddCss("border-top", "4px dashed blue")
            .AddCss("border-bottom", "8px solid blue")

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
            myStyles
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
