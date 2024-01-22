[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Demos.AdaptiveElmish

open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor
open Elmish
open Fun.Blazor.Docs.Controls

type private Model = { Count1: int; Count2: int }

type private Msg =
    | Increase
    | Decrease
    | IncreaseCount2

let private delayDecrease =
    Cmd.OfAsync.perform
        (fun () ->
            async {
                do! Async.Sleep 3000
                return Decrease
            }
        )
        ()
        (id)

let private init () = { Count1 = 1; Count2 = 2 }, delayDecrease

let private update msg model =
    match msg with
    | Increase -> { model with Count1 = model.Count1 + 1 }, Cmd.none
    | Decrease -> { model with Count1 = model.Count1 - 1 }, delayDecrease
    | IncreaseCount2 -> { model with Count2 = model.Count2 + 1 }, Cmd.none


let entry =
    html.inject (fun (hook: IComponentHook) ->
        let state, dispatch = hook.UseElmish(init, update)
        div.create [|
            adaptiview () {
                let! count = state |> AVal.map (fun x -> x.Count1) // only intrested in Count1
                MudText'() {
                    Typo Typo.h6
                    $"Count1={count} "
                }
            }
            adaptiview () {
                let! count = state |> AVal.map (fun x -> x.Count2) // only intrested in Count2
                MudText'() {
                    Typo Typo.h6
                    $"Count2={count}"
                }
            }
            spaceV2
            MudButtonGroup'() {
                Variant Variant.Outlined
                childContent [|
                    MudButton'() {
                        OnClick(fun _ -> Increase |> dispatch)
                        "Increase Count1"
                    }
                    MudButton'() {
                        OnClick(fun _ -> IncreaseCount2 |> dispatch)
                        "Increase Count2"
                    }
                |]
            }
        |]
    )
