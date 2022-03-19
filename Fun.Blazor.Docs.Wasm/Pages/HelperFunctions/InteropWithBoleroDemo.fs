[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.InteropWithBoleroDemo

open Fun.Blazor
open MudBlazor
open Bolero


let private boleroDemo =
    Html.div [
        Html.attr.style "background-color: red;"
    ] [
        Html.text "Below we are using Fun.Blazor in bolero node tree"
        html.funFragment (
            div {
                style {
                    padding 10
                    color "white"
                    backgroundColor "blue"
                }
                "Fun blazor"
            }
        )
    ]


let interopWithBoleroDemo =
    div {
        p { "This interop will need nuget package Fun.Bolero" }
        p { "Below we are using bolero node directly" }
        html.bolero boleroDemo
        br
        br
        p { "Or you can even yield from a fragment or any ce builder which support child content like div" }
        boleroDemo
        br
        MudPaper'() {
            Elevation 10
            boleroDemo
        }
        br
        Html.text "Text from bolero"
    }
