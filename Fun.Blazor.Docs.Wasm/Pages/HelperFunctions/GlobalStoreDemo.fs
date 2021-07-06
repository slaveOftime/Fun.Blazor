[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.GlobalStoreDemo

open MudBlazor
open Fun.Blazor

let globalStoreDemo = html.inject (fun (store: IGlobalStore) ->
    let toggle = store.Create ("global-store-toggle", false)
    
    mudPaper() {
        styles [ style.padding 20 ]
        childContent [
            html.watch (toggle, fun isToggled -> [
                mudText() {
                    childContent "Open two browsers for this page and try to click the toggle button"
                    typo Typo.subtitle1
                }
                mudSwitch<bool>() {
                    checked' isToggled
                    checkedChanged (fun x -> toggle.Publish x)
                }
                if isToggled then
                    mudText() {
                        childContent "Toggled successfuly"
                        typo Typo.subtitle2
                        color Color.Primary
                    }
                else
                    mudText() {
                        childContent "Toggled off now"
                        color Color.Secondary
                    }
            ])
        ]
    })
