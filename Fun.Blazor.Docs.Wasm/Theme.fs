module Fun.Blazor.Docs.Wasm.Theme

open MudBlazor


let primaryColor = "#495ca5"
let secondaryColor = "#6677BB"


type FunTheme =

    static member Create() =
        MudTheme(
            PaletteLight = PaletteLight(Primary = primaryColor, Secondary = secondaryColor),
            PaletteDark = PaletteDark(Primary = primaryColor, Secondary = secondaryColor, Black = "#202120")
        )
