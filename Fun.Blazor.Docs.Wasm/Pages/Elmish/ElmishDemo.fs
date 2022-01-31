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
        MudText'() {
            Typo Typo.h6
            Color Color.Primary
            childContent (string model.Count)
        }
        MudButtonGroup'() {
            Variant Variant.Outlined
            childContent [
                MudButton'() {
                    Color Color.Primary
                    OnClick (fun _ -> Increase |> dispatch)
                    childContent "Increase"
                }
                MudButton'() {
                    Color Color.Secondary
                    Variant Variant.Outlined
                    OnClick (fun _ -> Descrease |> dispatch)
                    childContent "Descrease"
                }
            ]
        }
    ]


let elmishDemo = html.elmish (init, update, view)
