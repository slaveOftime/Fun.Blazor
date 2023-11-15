module Fun.Blazor.Docs.Wasm.Theme

open MudBlazor
open MudBlazor.Utilities


let primaryColor = "#495ca5"
let secondaryColor = "#6677BB"


type FunDarkPalette() =
    inherit PaletteDark()

    override val Primary = MudColor primaryColor
    override val Secondary = MudColor secondaryColor
    override val Black = MudColor "#202120"


type FunLightPalette() =
    inherit PaletteLight()

    override val Primary = MudColor primaryColor
    override val Secondary = MudColor secondaryColor
    override val Surface = MudColor "#1e1e2d"
    override val Background = MudColor "#1a1a27"
    override val BackgroundGrey = MudColor "#151521"
    override val AppbarText = MudColor "#92929f"
    override val AppbarBackground = MudColor "rgba(26,26,39,0.8)"
    override val DrawerBackground = MudColor "#1a1a27"
    override val ActionDefault = MudColor "#74718e"
    override val ActionDisabled = MudColor "#9999994d"
    override val ActionDisabledBackground = MudColor "#605f6d4d"
    override val TextPrimary = MudColor "#b2b0bf"
    override val TextSecondary = MudColor "#92929f"
    override val TextDisabled = MudColor "#ffffff33"
    override val DrawerIcon = MudColor "#92929f"
    override val DrawerText = MudColor "#92929f"
    override val Info = MudColor "#4a86ff"
    override val Success = MudColor "#3dcb6c"
    override val Warning = MudColor "#ffb545"
    override val Error = MudColor "#ff3f5f"
    override val LinesDefault = MudColor "#33323e"
    override val TableLines = MudColor "#33323e"
    override val Divider = MudColor "#292838"


let defaultTheme = MudTheme(Palette = FunDarkPalette())

let darkTheme = MudTheme(Palette = FunLightPalette())
