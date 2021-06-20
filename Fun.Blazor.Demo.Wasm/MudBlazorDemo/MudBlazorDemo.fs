[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.MudBlazorDemo.MudBlazorDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor


let mudBlazorDemo = html.inject (fun () ->
    
    html.div [
        mudThemeProvider.create []
        mudDialogProvider.create []
        mudSnackbarProvider.create []
        mudCard.create [
            mudAlert.create [
                mudAlert.icon Icons.Filled.AccessAlarm
                mudAlert.children "This is the way"
            ]
        ]
    ])
