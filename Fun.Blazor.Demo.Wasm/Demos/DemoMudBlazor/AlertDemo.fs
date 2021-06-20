[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoMudBlazor.AlertDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor


let alertDemo = html.inject (fun () ->
    
    mudCard.create [
        mudAlert.create [
            mudAlert.icon Icons.Filled.AccessAlarm
            mudAlert.children "This is the way"
        ]
    ])
