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

    mudCard() {
        ref' cardRef
        childContent [
            html.watch (str, fun str ->
                mudAlert() {
                    icon Icons.Filled.AccessAlarm
                    childContentStr str
                    CAST
                })
        ]
        CAST
    })
