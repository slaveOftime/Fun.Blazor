[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Demos.ElmishDemo

open System.Threading.Tasks
open MudBlazor
open Fun.Blazor
open Elmish


type private Model = { Count: int }

type private Msg =
    | Increase
    | Decrease
    | IncreaseTask


let private delayDecrease =
    Cmd.OfAsync.perform
        (fun () -> async {
            do! Async.Sleep 3000
            return Decrease
        })
        ()
        (id)

let private init () = { Count = 0 }, delayDecrease

let private update msg model =
    match msg with
    | Increase -> { Count = model.Count + 1 }, Cmd.none
    | Decrease -> { Count = model.Count - 1 }, delayDecrease
    | IncreaseTask ->
        model,
        Cmd.OfTask.perform
            (fun () -> task {
                do! Task.Delay 1000
                return Increase
            })
            ()
            (id)

let private view model (dispatch: Msg -> unit) =
    div.create [
        MudText'' {
            Typo Typo.h6
            Color Color.Primary
            model.Count
        }
        MudButtonGroup'' {
            Variant Variant.Outlined
            childContent [|
                MudButton'' {
                    Color Color.Primary
                    OnClick(fun _ -> Increase |> dispatch)
                    "Increase"
                }
                MudButton'' {
                    Color Color.Primary
                    OnClick(fun _ -> IncreaseTask |> dispatch)
                    "Increase task (delayed in 1s)"
                }
                MudButton'' {
                    Color Color.Secondary
                    Variant Variant.Outlined
                    OnClick(fun _ -> task {
                        do! System.Threading.Tasks.Task.Delay 1000
                        Increase |> dispatch
                    })
                    "Increase (Delay 1s in click event)"
                }
                MudButton'' {
                    Color Color.Secondary
                    Variant Variant.Outlined
                    OnClick(fun _ -> Decrease |> dispatch)
                    "Decrease (loop in 3s)"
                }
            |]
        }
    ]


let entry = html.elmish (init, update, view)
