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
            childContent (string model.Count)
            Typo Typo.h6
            Color Color.Primary
        }
        MudButtonGroup'() {
            Variant Variant.Outlined
            childContent [
                MudButton'() {
                    childContent "Increase"
                    Color Color.Primary
                    OnClick (fun _ -> Increase |> dispatch)
                }
                MudButton'() {
                    childContent "Descrease"
                    Color Color.Secondary
                    Variant Variant.Outlined
                    OnClick (fun _ -> Descrease |> dispatch)
                }
            ]
        }
    ]


let elmishDemo = html.elmish (init, update, view)
