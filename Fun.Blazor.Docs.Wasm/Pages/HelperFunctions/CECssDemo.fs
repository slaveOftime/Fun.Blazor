[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.CECssDemo

open Fun.Blazor
open Fun.Css
open Fun.Css.Internal


type CssBuilder with

    [<CustomOperation("myStyles")>]
    member _.myStyles(comb: CombineKeyValue) = comb &>> ("border-bottom", "8px solid blue") // use own rule


let ceCssDemo =
    div {
        styleBuilder {
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
            for _ in 1 .. 10 do
                div {
                    styleBuilder {
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
        ]
    }
