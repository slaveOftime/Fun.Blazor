module Fun.Blazor.Docs.Wasm.Theme

open MudBlazor


let primaryColor = "#2c364d"
let secondaryColor = "#2e6f91"


type FunTheme =

    static member Create() =
        MudTheme(
            PaletteLight = PaletteLight(Primary = primaryColor, Secondary = secondaryColor),
            PaletteDark =
                PaletteDark(Primary = primaryColor, Secondary = secondaryColor, Black = "#0d1121", Surface = "#18202c", Background = "#161926")
        )
