// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Demos.GlobalStoreDemo

open MudBlazor
open Fun.Blazor

let entry =
    html.inject (fun (store: IGlobalStore) ->
        let toggle = store.Create("global-store-toggle", false)

        MudPaper'() {
            style { padding 20 }
            html.watch (
                toggle,
                fun isToggled ->
                    [
                        MudText'() {
                            Typo Typo.subtitle1
                            childContent "Open two browsers for this page and try to click the toggle button"
                        }
                        MudText'() {
                            Typo Typo.subtitle2
                            childContent "This only works in server mode blazor which under hook is using SignalR."
                        }
                        MudSwitch'<bool>() {
                            Checked isToggled
                            CheckedChanged(fun (x: bool) -> toggle.Publish x)
                        }
                        if isToggled then
                            MudText'() {
                                Typo Typo.subtitle2
                                Color Color.Primary
                                childContent "Toggled successfuly"
                            }
                        else
                            MudText'() {
                                Color Color.Secondary
                                childContent "Toggled off now"
                            }
                    ]
            )
        }
    )
