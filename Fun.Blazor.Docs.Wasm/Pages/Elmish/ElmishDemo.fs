[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.Elmish.ElmishDemo

open MudBlazor
open Fun.Blazor

type Model = { Count: int }

type Msg =
    | Increase
    | Descrease


let init () = { Count = 0 }

let update msg model =
    match msg with
    | Increase -> { model with Count = model.Count + 1 }
    | Descrease -> { model with Count = model.Count - 1 }
    
let view model dispatch =
    html.div [
        mudText() {
            childContentStr (string model.Count)
            typo Typo.h6
            color Color.Primary
            CAST
        }
        mudButtonGroup() {
            variant Variant.Outlined
            childContent [
                mudButton() {
                    childContentStr "Increase"
                    color Color.Primary
                    onClick (fun _ -> Increase |> dispatch)
                }
                mudButton() {
                    childContentStr "Descrease"
                    color Color.Secondary
                    variant Variant.Outlined
                    onClick (fun _ -> Descrease |> dispatch)
                }
            ]
            CAST
        }
    ]


let elmishDemo = html.elmish (init, update, view)
