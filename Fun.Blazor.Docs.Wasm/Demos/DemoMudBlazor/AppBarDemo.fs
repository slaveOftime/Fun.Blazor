[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoMudBlazor.AppBarDemo

open MudBlazor
open Fun.Blazor

let appBarDemo = html.inject (fun () ->
    MudAppBar' {
        Fixed false
        Color Color.Primary
        MudIconButton' {
            Icon Icons.Filled.Menu
            Color Color.Inherit
            Edge Edge.Start
        }
        MudSpacer'
        MudIconButton' {
            Icon Icons.Custom.Brands.GitHub
            Color Color.Inherit
            Edge Edge.End
        }
    })
