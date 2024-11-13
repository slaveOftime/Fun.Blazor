// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Demos.GlobalStoreDemo

open MudBlazor
open Fun.Blazor

let entry =
    html.inject (fun (store: IGlobalStore) ->
        let toggle = store.CreateCVal("global-store-toggle", false)

        MudPaper'' {
            style { padding 20 }
            MudText'' {
                Typo Typo.subtitle1
                "Open two browsers for this page and try to click the toggle button"
            }
            MudText'' {
                Typo Typo.subtitle2
                "This only works in server mode blazor which under hook is using SignalR."
            }
            adapt {
                let! isToggled, toggle = toggle.WithSetter()
                MudSwitch''<bool> {
                    Value isToggled
                    ValueChanged(fun (x: bool) -> toggle x)
                }
                region {
                    if isToggled then
                        MudText'' {
                            Typo Typo.subtitle2
                            Color Color.Primary
                            "Toggled successfuly"
                        }
                    else
                        MudText'' {
                            Color Color.Secondary
                            "Toggled off now"
                        }
                }
            }
        }
    )
