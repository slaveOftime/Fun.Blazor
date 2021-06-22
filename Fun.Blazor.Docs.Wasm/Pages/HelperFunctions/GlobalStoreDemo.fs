[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.GlobalStoreDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor

let globalStoreDemo = html.inject (fun (store: IGlobalStore) ->
    let toggle = store.Create ("global-store-toggle", false)
    
    mudPaper.create [
        attr.styles [ style.padding 20 ]
        html.watch (toggle, fun isToggled -> [
            mudText.create [
                mudText.childContent "Open two browsers for this page and try to click the toggle button"
                mudText.typo Typo.subtitle1
            ]
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
