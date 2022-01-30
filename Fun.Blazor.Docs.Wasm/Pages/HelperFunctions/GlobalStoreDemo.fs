[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.GlobalStoreDemo

open MudBlazor
open Fun.Blazor

let globalStoreDemo =
    html.inject (fun (store: IGlobalStore) ->
        let toggle = store.Create("global-store-toggle", false)

        MudPaper' {
            Styles [ styl.padding 20 ]
            html.watch (
                toggle,
                fun isToggled ->
                    [
                        MudText' {
                            Typo Typo.subtitle1
                            "Open two browsers for this page and try to click the toggle button"
                        }
                        MudSwitch'<bool> {
                            Checked isToggled
                            CheckedChanged(fun (x: bool) -> toggle.Publish x)
                        }
                        if isToggled then
                            MudText' {
                                Typo Typo.subtitle2
                                Color Color.Primary
                                "Toggled successfuly"
                            }
                        else
                            MudText' {
                                Color Color.Secondary
                                "Toggled off now"
                            }
                    ]
            )
        }
    )
