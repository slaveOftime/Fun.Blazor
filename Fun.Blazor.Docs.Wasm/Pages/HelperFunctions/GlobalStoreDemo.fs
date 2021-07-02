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
                    childContentStr "Open two browsers for this page and try to click the toggle button"
                    typo Typo.subtitle1
                    CAST
                }
                mudSwitch<bool>() {
                    checked' isToggled
                    checkedChanged toggle.Publish
                }
                if isToggled then
                    mudText() {
                        childContentStr "Toggled successfuly"
                        typo Typo.subtitle2
                        color Color.Primary
                    }
                else
                    mudText() {
                        childContentStr "Toggled off now"
                        color Color.Secondary
                    }
            ])
        ]
        CAST
    })
