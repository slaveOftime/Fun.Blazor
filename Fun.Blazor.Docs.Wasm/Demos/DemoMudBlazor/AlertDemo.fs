[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoMudBlazor.AlertDemo

open MudBlazor
open Bolero
open Fun.Blazor

let alertDemo = html.inject (fun (hook: IComponentHook) ->
    let cardRef = Ref<MudCard>()
    let str = hook.UseStore "This is the way"

    hook.OnFirstAfterRender.Add (fun () ->
        match cardRef.Value with
        | None -> str.Publish "Did not get ref"
        | Some _ -> str.Publish "Got ref")

    MudCard'() {
        ref cardRef
        childContent [
            MudNumericField'<int64>() {
                Label "Good number"
                Value 123L
                Format ""
            }
            html.watch (str, fun s -> [
                MudTextField'<string>() {
                    Label "Message"
                    Value s
                    ValueChanged str.Publish
                }
                MudAlert'() {
                    Icon Icons.Filled.AccessAlarm
                    childContent s
                }
            ])
            MudAutocomplete'(){
                SearchFunc (fun str -> task {
                    return seq { for i in 1..5 do $"item {str} {i}" }
                })
            }
        ]
    })
