[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoMudBlazor.AlertDemo

open MudBlazor
open Bolero
open Fun.Blazor
open Fun.Blazor.MudBlazor

let alertDemo = html.inject (fun (hook: IComponentHook) ->
    let ref = Ref<MudCard>()
    let str = hook.UseStore "This is the way"

    hook.OnFirstAfterRender.Add (fun () ->
        match ref.Value with
        | None -> str.Publish "Did not get ref"
        | Some _ -> str.Publish "Got ref")

    mudCard.create [
        mudCard.ref ref
        mudCard.childContent [
            html.watch (str, fun str ->
                mudAlert.create [
                    mudAlert.icon Icons.Filled.AccessAlarm
                    mudAlert.childContent str
                ])
        ]
    ])
