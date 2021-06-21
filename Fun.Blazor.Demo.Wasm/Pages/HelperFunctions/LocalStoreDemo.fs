[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Pages.HelperFunctions.LocalStoreDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor

let localStoreDemo = html.inject (fun (store: ILocalStore) ->
    let toggle = store.Create false
    
    html.div [
        mudButton.create [
            mudButton.childContent "Toggle me"
            mudButton.onClick (fun _ -> toggle.Publish not)
        ]
        mudPaper.create [
            html.watch (toggle, function
                | true -> 
                    mudText.create [
                        mudText.childContent "Toggled successfuly"
                        mudText.typo Typo.subtitle2
                        mudText.color Color.Primary
                    ]
                | false ->
                    mudText.create [
                        mudText.childContent "Toggled off now"
                        mudText.color Color.Secondary
                    ])
        ]
    ])
