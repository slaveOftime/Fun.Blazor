[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoMudBlazor.AppBarDemo

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Blazor.Demo.Wasm.Components


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
            mudIconButton.create [
                mudIconButton.icon Icons.Custom.Brands.GitHub
                mudIconButton.color Color.Inherit
                mudIconButton.edge Edge.End
            ]
        ]
    ])
