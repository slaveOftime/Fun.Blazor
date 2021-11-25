[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.App

open Fun.Blazor
open Fun.Blazor.Router
open MudBlazor
open MudBlazor.Utilities
open Fun.Blazor.Docs.Wasm.DemoMudBlazor
open Fun.Blazor.Docs.Wasm.DemoAntDesign
open Fun.Blazor.Docs.Wasm.DemoFluentUI
open Fun.Blazor.Docs.Wasm.DemoDragDrop
open Fun.Blazor.Docs.Wasm.Components
open Fun.Blazor.Docs.Wasm.Pages



let defaultTheme =
    MudTheme
        (Palette =
            Palette(
                Primary = MudColor "#289c8e",
                Secondary = MudColor "#47cacf",
                Black = MudColor "#202120"))

let darkTheme =
    MudTheme
        (Palette =
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
                TextDisabled = MudColor "rgba(255,255,255, 0.2)"))


let navmenu =
    MudNavMenu'.create [
        MudNavLink'() {
            Href "./quick-start"
            childContent "Quick start"
        }
        MudNavLink'() {
            Href "./router"
            childContent "Router"
        }
        MudNavLink'() {
            Href "./elmish"
            childContent "Elmish"
        }
        MudNavLink'() {
            Href "./cli-usage"
            childContent "Cli usage"
        }
        MudNavLink'() {
            Href "./tests"
            childContent "Tests"
        }
        MudNavGroup'() {
            Title "Helper functions"
            Icon Icons.Material.Filled.LiveHelp
            Expanded true
            childContent [
                MudNavLink'() {
                    Href "./helper-functions/html-inject"
                    childContent "html.inject"
                }
                MudNavLink'() {
                    Href "./helper-functions/html-watch"
                    childContent "html.watch"
                }
                MudNavLink'() {
                    Href "./helper-functions/adaptiview"
                    childContent "adaptiview"
                }
                MudNavLink'() {
                    Href "./helper-functions/component-hook"
                    childContent "IComponentHook"
                }
                MudNavLink'() {
                    Href "./helper-functions/global-store"
                    childContent "Global store"
                }
                MudNavLink'() {
                    Href "./helper-functions/adaptive-form"
                    childContent "Adaptive Form"
                }
                MudNavLink'() {
                    Href "./helper-functions/performance"
                    childContent "Performance"
                }
                MudNavLink'() {
                    Href "./helper-functions/ce-css-builder"
                    childContent "CE style css builder"
                }
            ]
        }
        MudNavGroup'() {
            Title "Demos"
            Icon Icons.Material.Filled.School
            Expanded true
            childContent [
                MudNavLink'() {
                    Href "./mudblazor"
                    childContent "MudBlazor"
                }
                MudNavLink'() {
                    Href "./antdesign"
                    childContent "Antdesign"
                }
                MudNavLink'() {
                    Href "./fluentui"
                    childContent "FluentUI"
                }
                MudNavLink'() {
                    Href "./drag-drop"
                    childContent "Drag Drop"
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
        subRouteCi "/helper-functions" [
            routeCi "/html-inject"          (demoContainer "html.inject" "Pages/HelperFunctions/InjectDemo" HelperFunctions.InjectDemo.injectDemo)
            routeCi "/html-watch"           (demoContainer "html.watch" $"Pages/HelperFunctions/HtmlWatchDemo" HelperFunctions.HtmlWatchDemo.htmlWatchDemo)
            routeCi "/adaptiview"           (demoContainer "adapt" $"Pages/HelperFunctions/AdaptiveDemo" HelperFunctions.AdaptiviewDemo.adaptiviewDemo)
            routeCi "/component-hook"       (demoContainer "IComponentHook" $"Pages/HelperFunctions/ComponentHookDemo" HelperFunctions.ComponentHookDemo.componentHookDemo)
            routeCi "/global-store"         (demoContainer "Global storage" $"Pages/HelperFunctions/GlobalStoreDemo" HelperFunctions.GlobalStoreDemo.globalStoreDemo)
            routeCi "/adaptive-form"        (demoContainer "Adaptive Form" $"Pages/HelperFunctions/AdaptiveFromDemo" HelperFunctions.AdaptiveFormDemo.adaptiveFormDemo)
            routeCi "/performance"          (demoContainer "Performance" $"Pages/HelperFunctions/PerformanceDemo" HelperFunctions.PerformanceDemo.performanceDemo)
            routeCi "/ce-css-builder"       (demoContainer "CE style css builde" $"Pages/HelperFunctions/CECssDemo" HelperFunctions.CECssDemo.ceCssDemo)
        ]
        routeCi "/cli-usage"            CliUsage.CliUsage.cliUsage
        routeCi "/tests"                Tests.Tests.tests
        routeCi "/antdesign"            demoAntDesign
        routeCi "/fluentui"             demoFluentUI
        routeCi "/drag-drop"            demoDragDrop
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
            childContent [
                MudAppBar'() {
                    Color Color.Primary
                    Elevation 25
                    Dense true
                    childContent [
                        MudIconButton'() {
                            Icon Icons.Material.Filled.Menu
                            Color Color.Inherit
                            Edge Edge.Start
                            OnClick (fun _ -> openMenu.Publish not)
                        }
                        MudText'() {
                            Typo Typo.h6
                            Color Color.Default
                            childContent "Fun Blazor"
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
                        childContent [
                            MudDrawerHeader'() {
                                LinkToIndex true
                                childContent [
                                    MudText'() {
                                        Color Color.Primary
                                        Typo Typo.h5
                                        childContent "Have fun ✌"
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
                    childContent [
                        html.route [
                            // For host on slaveoftime.fun server mode
                            yield! routes
                            // For host on github-pages WASM mode
                            subRouteCi "/Fun.Blazor" routes
                            routeAny QuickStart.QuickStart.quickStart
                        ]
                        MudScrollToTop'() {
                            TopOffset 400
                            childContent [
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
