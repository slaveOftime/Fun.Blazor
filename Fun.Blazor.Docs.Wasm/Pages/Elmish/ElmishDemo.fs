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
    div {
        MudText' {
            Typo Typo.h6
            Color Color.Primary
            model.Count
        }
        MudButtonGroup' {
            Variant Variant.Outlined
            MudButton' {
                Color Color.Primary
                OnClick (fun _ -> Increase |> dispatch)
                "Increase"
            }
            MudButton' {
                Color Color.Secondary
                Variant Variant.Outlined
                OnClick (fun _ -> Descrease |> dispatch)
                "Descrease"
            }
        }
    }


let elmishDemo = emptyNode //html.elmish (init, update, view)
