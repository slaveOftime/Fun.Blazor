[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoMudBlazor.AppBarDemo

open MudBlazor
open Fun.Blazor

let appBarDemo = html.inject (fun () ->
    mudAppBar() {
        fixed' false
        color Color.Primary
        childContent [
            mudIconButton() {
                icon Icons.Filled.Menu
                color Color.Inherit
                edge Edge.Start
            }
            mudSpacer ()
            mudIconButton() {
                icon Icons.Custom.Brands.GitHub
                color Color.Inherit
                edge Edge.End
            }
        ]
        CAST
    })
