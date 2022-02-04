[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoMudBlazor.AlertDemo

open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor

let alertDemo =
    html.inject (fun (hook: IComponentHook) ->
        let cardRef = hook.UseStore None
        let divRef = hook.UseStore None
        let str = hook.UseStore "This is the way"

        let number1 = hook.UseStore 100
        let number2 = cval 100

        hook.OnFirstAfterRender.Add(fun () ->
            match cardRef.Current, divRef.Current with
            | None, None -> str.Publish "Did not get ref"
            | Some _, None -> str.Publish "Got comp ref"
            | Some _, Some _ -> str.Publish "Got comp and div ref"
            | None, Some _ -> str.Publish "Got div ref"
        )

        MudCard'() {
            ref (Some >> cardRef.Publish)
            MudNumericField'<int64>() {
                Label "Good number"
                Value 123L
                Format ""
            }
            div {
                styleBuilder {
                    width 100
                    height 100
                    backgroundColor "red"
                    padding "10px"
                }
                ref (Some >> divRef.Publish)
            }
            html.watch (
                str,
                fun s ->
                    [
                        MudTextField'<string>() {
                            Label "Message"
                            Value s
                            ValueChanged str.Publish
                        }
                        MudAlert'() {
                            Icon Icons.Filled.AccessAlarm
                            childContent s
                        }
                    ]
            )

            html.watch (
                number1,
                fun _ ->
                    MudTextField'() {
                        Label "Number 1"
                        Value' number1
                    }
            )
            adaptiview () {
                let! _ = number2
                MudTextField'() {
                    Label "Number 2"
                    Value' number2
                }
            }
            MudButton'() {
                OnClick(fun _ ->
                    number1.Publish((+) 1)
                    number2.Publish((+) 2)
                )
                childContent "Increase"
            }

            MudAutocomplete'() {
                SearchFunc(fun str ->
                    task {
                        return
                            seq {
                                for i in 1 .. 5 do
                                    $"item {str} {i}"
                            }
                    }
                )
            }
            MudDialog'() { TitleContent [ MudText'.create "123123" ] }
        }
    )
