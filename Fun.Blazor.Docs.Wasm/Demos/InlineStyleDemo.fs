// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Demos.InlineStyleDemo

open Fun.Blazor
open Fun.Css
open Fun.Css.Internal


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


let entry = div {
    style {
        color color.darkRed
        backgroundColor color.green
        borderRadius 10
        displayFlex
        flexDirectionRow
        flexWrapWrap
        myStyles
    }
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
}
