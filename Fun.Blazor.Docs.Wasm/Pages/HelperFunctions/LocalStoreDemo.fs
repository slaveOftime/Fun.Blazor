[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.LocalStoreDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor

let localStoreDemo = html.inject (fun (hook: IComponentHook) ->
    let toggle = hook.UseStore false
    
    mudPaper.create [
        attr.styles [ style.padding 20 ]
        html.watch (toggle, fun isToggled -> [
            mudSwitch<bool>.create [
                mudSwitch.checked' isToggled
                mudSwitch.checkedChanged toggle.Publish
            ]
            if isToggled then
                mudText.create [
                    mudText.childContent "Toggled successfuly"
                    mudText.typo Typo.subtitle2
                    mudText.color Color.Primary
                ]
            else
                mudText.create [
                    mudText.childContent "Toggled off now"
                    mudText.color Color.Secondary
                ]
        ])
    ])
