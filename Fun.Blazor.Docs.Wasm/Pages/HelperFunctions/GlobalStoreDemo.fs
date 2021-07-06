[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.GlobalStoreDemo

open MudBlazor
open Fun.Blazor

let globalStoreDemo = html.inject (fun (store: IGlobalStore) ->
    let toggle = store.Create ("global-store-toggle", false)
    
    MudPaper'() {
        Styles [ style.padding 20 ]
        ChildContent [
            html.watch (toggle, fun isToggled -> [
                MudText'() {
                    ChildContent "Open two browsers for this page and try to click the toggle button"
                    Typo Typo.subtitle1
                }
                MudSwitch'<bool>() {
                    Checked isToggled
                    CheckedChanged (fun (x: bool) -> toggle.Publish x)
                }
                if isToggled then
                    MudText'() {
                        ChildContent "Toggled successfuly"
                        Typo Typo.subtitle2
                        Color Color.Primary
                    }
                else
                    MudText'() {
                        ChildContent "Toggled off now"
                        Color Color.Secondary
                    }
            ])
        ]
    })
