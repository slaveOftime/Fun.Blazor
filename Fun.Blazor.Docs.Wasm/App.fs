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
    mudNavMenu.create [
        mudNavLink() {
            href "./quick-start"
            childContent "Quick start"
        }
        mudNavLink() {
            href "./router"
            childContent "Router"
        }
        mudNavLink() {
            href "./elmish"
            childContent "Elmish"
        }
        mudNavLink() {
            href "./helper-functions"
            childContent "Helper functions"
        }
        mudNavLink() {
            href "./cli-usage"
            childContent "Cli usage"
        }
        mudNavLink() {
            href "./tests"
            childContent "Tests"
        }
        mudNavGroup() {
            title "Demos"
            icon Icons.Material.Filled.School
            expanded true
            childContent [
                mudNavLink() {
                    href "./mudblazor"
                    childContent "MudBlazor"
                }
                mudNavLink() {
                    href "./antdesign"
                    childContent "Antdesign"
                }
                mudNavLink() {
                    href "./fluentui"
                    childContent "FluentUI"
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
            mudThemeProvider() {
                theme (if isDark then darkTheme else defaultTheme)
            })

        mudDialogProvider.create()
        mudSnackbarProvider.create()
     
        mudLayout() {
            rightToLeft false
            childContent [
                mudAppBar() {
                    color Color.Primary
                    elevation 25
                    dense true
                    childContent [
                        mudIconButton() {
                            icon Icons.Material.Filled.Menu
                            color Color.Inherit
                            edge Edge.Start
                            onClick (fun _ -> openMenu.Publish not)
                        }
                        mudText() {
                            typo Typo.h6
                            color Color.Default
                            childContent "Fun Blazor"
                        }
                        mudSpacer.create()
                        mudTooltip() {
                            text "Github repository"
                            childContent [
                                mudIconButton() {
                                    icon Icons.Custom.Brands.GitHub
                                    color Color.Inherit
                                    link "https://github.com/slaveOftime/Fun.Blazor"
                                }
                            ]
                        }
                    ]
                }
                html.watch (openMenu, fun isOpen ->
                    mudDrawer() {
                        open' isOpen
                        elevation 25
                        variant DrawerVariant.Persistent
                        childContent [
                            mudDrawerHeader() {
                                linkToIndex true
                                childContent [
                                    mudText() {
                                        color Color.Primary
                                        typo Typo.h5
                                        childContent "Have fun ✌"
                                    }
                                ]
                            }
                            navmenu
                        ]
                    }
                )
                mudMainContent() {
                    styles [
                        style.paddingTop 100
                        style.paddingBottom 64
                    ]
                    childContent [
                        html.route [
                            // For host on slaveoftime.fun server mode
                            yield! routes
                            // For host on github-pages WASM mode
                            subRouteCi "/Fun.Blazor" routes
                            routeAny QuickStart.QuickStart.quickStart
                        ]
                        mudScrollToTop() {
                            topOffset 400
                            childContent [
                                mudFab() {
                                    icon Icons.Material.Filled.KeyboardArrowUp
                                    color Color.Primary
                                }
                            ]
                        }
                    ]
                }
            ]
        }
    ])
