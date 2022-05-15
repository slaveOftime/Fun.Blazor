﻿[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Demos.ElmishDemo

open System.Threading.Tasks
open MudBlazor
open Fun.Blazor
open Elmish


type Model = { Count: int }

type Msg =
    | Increase
    | Decrease
    | IncreaseTask


let delayDecrease =
    Cmd.OfAsync.result (
        async {
            do! Async.Sleep 3000
            return Decrease
        }
    )


let init () = { Count = 0 }, delayDecrease

let update msg model =
    match msg with
    | Increase -> { model with Count = model.Count + 1 }, Cmd.none
    | Decrease -> { model with Count = model.Count - 1 }, delayDecrease
    | IncreaseTask ->
        model,
        Cmd.OfTask.result (
            task {
                do! Task.Delay 1000
                return Increase
            }
        )

let view model (dispatch: Msg -> unit) =
    div.create [
        MudText'() {
            Typo Typo.h6
            Color Color.Primary
            model.Count
        }
        MudButtonGroup'() {
            Variant Variant.Outlined
            childContent [
                MudButton'() {
                    Color Color.Primary
                    OnClick(fun _ -> Increase |> dispatch)
                    "Increase"
                }
                MudButton'() {
                    Color Color.Primary
                    OnClick(fun _ -> IncreaseTask |> dispatch)
                    "Increase task (delayed in 1s)"
                }
                MudButton'() {
                    Color Color.Secondary
                    Variant Variant.Outlined
                    OnClick(fun _ -> Decrease |> dispatch)
                    "Decrease (loop in 3s)"
                }
            ]
        }
    ]


let entry = html.elmish (init, update, view)