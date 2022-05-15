module Fun.Blazor.Docs.Wasm.Theme

open MudBlazor
open MudBlazor.Utilities


let primaryColor = "#495ca5"
let secondaryColor = "#6677BB"


let defaultTheme =
    MudTheme(Palette = Palette(Primary = primaryColor, Secondary = secondaryColor, Black = MudColor "#202120"))


let darkTheme =
    MudTheme(
        Palette =
            Palette(
                Primary = primaryColor,
                Secondary = secondaryColor,
                Surface= "#1e1e2d",
                Background = "#1a1a27",
                BackgroundGrey = "#151521",
                AppbarText = "#92929f",
                AppbarBackground = "rgba(26,26,39,0.8)",
                DrawerBackground = "#1a1a27",
                ActionDefault = "#74718e",
                ActionDisabled = "#9999994d",
                ActionDisabledBackground = "#605f6d4d",
                TextPrimary = "#b2b0bf",
                TextSecondary = "#92929f",
                TextDisabled = "#ffffff33",
                DrawerIcon = "#92929f",
                DrawerText = "#92929f",
                GrayLight = "#2a2833",
                GrayLighter = "#1e1e2d",
                Info = "#4a86ff",
                Success = "#3dcb6c",
                Warning = "#ffb545",
                Error = "#ff3f5f",
                LinesDefault = "#33323e",
                TableLines = "#33323e",
                Divider = "#292838",
                OverlayLight = "#1e1e2d80"
            )
    )
