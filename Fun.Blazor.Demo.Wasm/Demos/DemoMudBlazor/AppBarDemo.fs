[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoMudBlazor.AppBarDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor

let appBarDemo = html.inject (fun () ->
    mudAppBar.create [
        mudAppBar.color Color.Primary
        mudAppBar.fixed' false
        mudAppBar.childContent [
            mudIconButton.create [
                mudIconButton.icon Icons.Filled.Menu
                mudIconButton.color Color.Inherit
                mudIconButton.edge Edge.Start
            ]
            mudSpacer.create ()
            mudIconButton.create [
                mudIconButton.icon Icons.Custom.Brands.GitHub
                mudIconButton.color Color.Inherit
                mudIconButton.edge Edge.End
            ]
        ]
    ])
