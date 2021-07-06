[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.App

open Fun.Blazor
open Fun.Blazor.Router
open MudBlazor
open Fun.Blazor.Docs.Wasm.DemoMudBlazor
open Fun.Blazor.Docs.Wasm.DemoAntDesign
open Fun.Blazor.Docs.Wasm.DemoFluentUI
open Fun.Blazor.Docs.Wasm.Components
open Fun.Blazor.Docs.Wasm.Pages



let defaultTheme =
    MudTheme
        (Palette =
            Palette(
                Primary = "#289c8e",
                Secondary = "#47cacf",
                Black = "#202120"))

let darkTheme =
    MudTheme
        (Palette =
            Palette(
                Primary = "#289c8e",
                Secondary = "#47cacf",
                Black = "#27272f",
                Background = "#32333d",
                BackgroundGrey = "#27272f",
                Surface = "#373740",
                DrawerBackground = "#27272f",
                DrawerText = "rgba(255,255,255, 0.50)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                AppbarBackground = "#27272f",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "#289c8e",
                TextSecondary = "#33d0e8",
                ActionDefault = "#adadb1",
                ActionDisabled = "rgba(255,255,255, 0.26)",
                ActionDisabledBackground = "rgba(255,255,255, 0.12)",
                Divider = "rgba(255,255,255, 0.12)",
                DividerLight = "rgba(255,255,255, 0.06)",
                TableLines = "rgba(255,255,255, 0.12)",
                LinesDefault = "rgba(255,255,255, 0.12)",
                LinesInputs = "rgba(255,255,255, 0.3)",
                TextDisabled = "rgba(255,255,255, 0.2)"))


let navmenu =
    MudNavMenu'.create [
        MudNavLink'() {
            Href "./quick-start"
            ChildContent "Quick start"
        }
        MudNavLink'() {
            Href "./router"
            ChildContent "Router"
        }
        MudNavLink'() {
            Href "./elmish"
            ChildContent "Elmish"
        }
        MudNavLink'() {
            Href "./helper-functions"
            ChildContent "Helper functions"
        }
        MudNavLink'() {
            Href "./cli-usage"
            ChildContent "Cli usage"
        }
        MudNavLink'() {
            Href "./tests"
            ChildContent "Tests"
        }
        MudNavGroup'() {
            Title "Demos"
            Icon Icons.Material.Filled.School
            Expanded true
            ChildContent [
                MudNavLink'() {
                    Href "./mudblazor"
                    ChildContent "MudBlazor"
                }
                MudNavLink'() {
                    Href "./antdesign"
                    ChildContent "Antdesign"
                }
                MudNavLink'() {
                    Href "./fluentui"
                    ChildContent "FluentUI"
                }
            ]
        }
    ]


let app = html.inject (fun (hook: IComponentHook, shareStore: IShareStore) ->
    let isDarkMode = ShareStores.isDarkMode shareStore
    let openMenu = hook.UseStore false
    
    let routes = [
        subRouteCi "/router"            [ routeAny Router.Router.router ]
        routeCi "/elmish"               Elmish.Elmish.elmish
        routeCi "/helper-functions"     HelperFunctions.HelperFunctions.helperFunctions
        routeCi "/cli-usage"            CliUsage.CliUsage.cliUsage
        routeCi "/tests"                Tests.Tests.tests
        routeCi "/antdesign"            demoAntDesign
        routeCi "/fluentui"             demoFluentUI
        routeCi "/mudblazor"            demoMudBlazor
    ]

    html.div [
        html.watch (isDarkMode, fun isDark ->
            MudThemeProvider'() {
                Theme (if isDark then darkTheme else defaultTheme)
            })

        MudDialogProvider'.create()
        MudSnackbarProvider'.create()
     
        MudLayout'() {
            RightToLeft false
            ChildContent [
                MudAppBar'() {
                    Color Color.Primary
                    Elevation 25
                    Dense true
                    ChildContent [
                        MudIconButton'() {
                            Icon Icons.Material.Filled.Menu
                            Color Color.Inherit
                            Edge Edge.Start
                            OnClick (fun _ -> openMenu.Publish not)
                        }
                        MudText'() {
                            Typo Typo.h6
                            Color Color.Default
                            ChildContent "Fun Blazor"
                        }
                        MudSpacer'.create()
                        MudIconButton'() {
                            Icon Icons.Custom.Brands.GitHub
                            Color Color.Inherit
                            Link "https://github.com/slaveOftime/Fun.Blazor"
                        }
                    ]
                }
                html.watch (openMenu, fun isOpen ->
                    MudDrawer'() {
                        Open isOpen
                        Elevation 25
                        Variant DrawerVariant.Persistent
                        ChildContent [
                            MudDrawerHeader'() {
                                LinkToIndex true
                                ChildContent [
                                    MudText'() {
                                        Color Color.Primary
                                        Typo Typo.h5
                                        ChildContent "Have fun ✌"
                                    }
                                ]
                            }
                            navmenu
                        ]
                    }
                )
                MudMainContent'() {
                    Styles [
                        style.paddingTop 100
                        style.paddingBottom 64
                    ]
                    ChildContent [
                        html.route [
                            // For host on slaveoftime.fun server mode
                            yield! routes
                            // For host on github-pages WASM mode
                            subRouteCi "/Fun.Blazor" routes
                            routeAny QuickStart.QuickStart.quickStart
                        ]
                        MudScrollToTop'() {
                            TopOffset 400
                            ChildContent [
                                MudFab'() {
                                    Icon Icons.Material.Filled.KeyboardArrowUp
                                    Color Color.Primary
                                }
                            ]
                        }
                    ]
                }
            ]
        }
    ])
