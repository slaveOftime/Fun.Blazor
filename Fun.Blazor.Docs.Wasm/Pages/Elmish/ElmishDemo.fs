[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.Elmish.ElmishDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor


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
        mudText.create [
            mudText.childContent (string model.Count)
            mudText.typo Typo.h6
            mudText.color Color.Primary
        ]
        mudButtonGroup.create [
            mudButtonGroup.variant Variant.Outlined
            mudButtonGroup.childContent [
                mudButton.create [
                    mudButton.childContent "Increase"
                    mudButton.color Color.Primary
                    mudButton.onClick (fun _ -> Increase |> dispatch)
                ]
                mudButton.create [
                    mudButton.childContent "Descrease"
                    mudButton.color Color.Secondary
                    mudButton.variant Variant.Outlined
                    mudButton.onClick (fun _ -> Descrease |> dispatch)
                ]
            ]
        ]
    ]


let elmishDemo = html.elmish (init, update, view)
