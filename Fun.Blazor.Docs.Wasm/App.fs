// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.App

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Router
open MudBlazor
open MudBlazor.Utilities
open Fun.Blazor.Docs.Wasm.Components
open Fun.Blazor.Docs.Wasm.Pages



let defaultTheme =
    MudTheme(Palette = Palette(Primary = MudColor "#289c8e", Secondary = MudColor "#47cacf", Black = MudColor "#202120"))

let darkTheme =
    MudTheme(
        Palette =
            Palette(
                Primary = MudColor "#289c8e",
                Secondary = MudColor "#47cacf",
                Black = MudColor "#27272f",
                Background = MudColor "#32333d",
                BackgroundGrey = MudColor "#27272f",
                Surface = MudColor "#373740",
                DrawerBackground = MudColor "#27272f",
                DrawerText = MudColor "rgba(255,255,255, 0.50)",
                DrawerIcon = MudColor "rgba(255,255,255, 0.50)",
                AppbarBackground = MudColor "#27272f",
                AppbarText = MudColor "rgba(255,255,255, 0.70)",
                TextPrimary = MudColor "#289c8e",
                TextSecondary = MudColor "#33d0e8",
                ActionDefault = MudColor "#adadb1",
                ActionDisabled = MudColor "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = MudColor "rgba(255,255,255, 0.12)",
                Divider = MudColor "rgba(255,255,255, 0.12)",
                DividerLight = MudColor "rgba(255,255,255, 0.06)",
                TableLines = MudColor "rgba(255,255,255, 0.12)",
                LinesDefault = MudColor "rgba(255,255,255, 0.12)",
                LinesInputs = MudColor "rgba(255,255,255, 0.3)",
                TextDisabled = MudColor "rgba(255,255,255, 0.2)"
            )
    )


let app =
    html.inject (fun (hook: IComponentHook, shareStore: IShareStore) ->
        let isOpen = cval (false)

        let theme =
            adaptiview () {
                let! isDark = shareStore.isDarkMode
                MudThemeProvider'() { Theme(if isDark then darkTheme else defaultTheme) }
            }

        let menuBtn =
            adaptiview () {
                let! isOpen, setIsOpen = isOpen.WithSetter()
                MudIconButton'() {
                    Icon Icons.Material.Filled.Menu
                    Color Color.Inherit
                    Edge Edge.Start
                    OnClick(fun _ -> setIsOpen (not isOpen))
                }
            }

        let appBar =
            MudAppBar'() {
                Color Color.Primary
                Elevation 25
                Dense true
                menuBtn
                MudText'() {
                    Typo Typo.h6
                    Color Color.Default
                    "Fun Blazor"
                }
                MudSpacer'.create ()
                MudIconButton'() {
                    Icon Icons.Custom.Brands.GitHub
                    Color Color.Inherit
                    Link "https://github.com/slaveOftime/Fun.Blazor"
                }
            }

        let drawer =
            adaptiview () {
                let! isOpen = isOpen
                MudDrawer'() {
                    Open isOpen
                    Elevation 25
                    Variant DrawerVariant.Persistent
                    MudDrawerHeader'() {
                        LinkToIndex true
                        MudText'() {
                            Color Color.Primary
                            Typo Typo.h5
                            "Have fun ✌"
                        }
                    }
                    navmenu
                }
            }

        let routing =
            html.route [
                // For host on slaveoftime.fun server mode
                yield! routes
                // For host on github-pages WASM mode
                subRouteCi "/Fun.Blazor.Docs" routes
                routeAny QuickStart.QuickStart.quickStart
            ]

        adaptiview () {
            theme
            MudDialogProvider'.create()
            MudSnackbarProvider'.create()
            MudLayout'() {
                appBar
                drawer
                MudMainContent'() {
                    styleBuilder {
                        paddingTop 100
                        paddingBottom 64
                    }
                    routing
                    MudScrollToTop'() {
                        TopOffset 400
                        MudFab'() {
                            Icon Icons.Material.Filled.KeyboardArrowUp
                            Color Color.Primary
                        }
                    }
                }
            }
        }
    )
