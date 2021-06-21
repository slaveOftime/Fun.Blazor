[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoMudBlazor.AlertDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor

let alertDemo =
    mudCard.create [
        mudAlert.create [
            mudAlert.icon Icons.Filled.AccessAlarm
            mudAlert.childContent "This is the way"
        ]
    ]
