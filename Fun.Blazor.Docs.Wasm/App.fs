[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.App

open FSharp.Data.Adaptive
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
    MudTheme(
        Palette = Palette(Primary = MudColor "#289c8e", Secondary = MudColor "#47cacf", Black = MudColor "#202120")
    )

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


let navmenu =
    MudNavMenu'() {
        MudNavLink'() {
            Href "./quick-start"
            "Quick start"
        }
        MudNavLink'() {
            Href "./router"
            "Router"
        }
        MudNavLink'() {
            Href "./adaptive-form"
            "Adaptive Form"
        }
        MudNavLink'() {
            Href "./elmish"
            "Elmish"
        }
        MudNavLink'() {
            Href "./cli-usage"
            "Cli usage"
        }
        MudNavLink'() {
            Href "./tests"
            "Tests"
        }
        MudNavGroup'() {
            Title "Helper functions"
            Icon Icons.Material.Filled.LiveHelp
            Expanded true
            MudNavLink'() {
                Href "./helper-functions/html-inject"
                "html.inject"
            }
            MudNavLink'() {
                Href "./helper-functions/component-hook"
                "IComponentHook"
            }
            MudNavLink'() {
                Href "./helper-functions/adaptiview"
                "adaptiview"
            }
            MudNavLink'() {
                Href "./helper-functions/html-watch"
                "html.watch"
            }
            MudNavLink'() {
                Href "./helper-functions/html-template-demo"
                "Html Template Demo"
            }
            MudNavLink'() {
                Href "./helper-functions/global-store"
                "Global store"
            }
            MudNavLink'() {
                Href "./helper-functions/performance"
                "Performance"
            }
            MudNavLink'() {
                Href "./helper-functions/ce-css-builder"
                "CE style css builder"
            }
            MudNavLink'() {
                Href "./helper-functions/bolero"
                "Bolero interop"
            }
        }
        MudNavGroup'() {
            Title "Demos"
            Icon Icons.Material.Filled.School
            Expanded true
            MudNavLink'() {
                Href "./mudblazor"
                "MudBlazor"
            }
            MudNavLink'() {
                Href "./antdesign"
                "Antdesign"
            }
            MudNavLink'() {
                Href "./fluentui"
                "FluentUI"
            }
            MudNavLink'() {
                Href "./drag-drop"
                "Drag Drop"
            }
        }
    }

let routes =
    [
        subRouteCi "/router" [ routeAny Router.Router.router ]
        routeCi
            "/adaptive-form"
            (demoContainer
                "Adaptive Form"
                $"Pages/HelperFunctions/AdaptiveFromDemo"
                HelperFunctions.AdaptiveFormDemo.adaptiveFormDemo)
        routeCi "/elmish" Elmish.Elmish.elmish
        subRouteCi
            "/helper-functions"
            [
                routeCi
                    "/html-inject"
                    (demoContainer
                        "html.inject"
                        "Pages/HelperFunctions/InjectDemo"
                        HelperFunctions.InjectDemo.injectDemo)
                routeCi
                    "/html-watch"
                    (demoContainer
                        "html.watch"
                        $"Pages/HelperFunctions/HtmlWatchDemo"
                        HelperFunctions.HtmlWatchDemo.htmlWatchDemo)
                routeCi
                    "/adaptiview"
                    (demoContainer
                        "adapt"
                        $"Pages/HelperFunctions/AdaptiveDemo"
                        HelperFunctions.AdaptiviewDemo.adaptiviewDemo)
                routeCi
                    "/component-hook"
                    (demoContainer
                        "IComponentHook"
                        $"Pages/HelperFunctions/ComponentHookDemo"
                        HelperFunctions.ComponentHookDemo.componentHookDemo)
                routeCi
                    "/global-store"
                    (demoContainer
                        "Global storage"
                        $"Pages/HelperFunctions/GlobalStoreDemo"
                        HelperFunctions.GlobalStoreDemo.globalStoreDemo)
                routeCi
                    "/performance"
                    (demoContainer
                        "Performance"
                        $"Pages/HelperFunctions/PerformanceDemo"
                        HelperFunctions.PerformanceDemo.performanceDemo)
                routeCi
                    "/ce-css-builder"
                    (demoContainer
                        "CE style css builde"
                        $"Pages/HelperFunctions/CECssDemo"
                        HelperFunctions.CECssDemo.ceCssDemo)
                routeCi
                    "/bolero"
                    (demoContainer
                        "Bolero interop"
                        "Pages/HelperFunctions/InteropWithBoleroDemo"
                        HelperFunctions.InteropWithBoleroDemo.interopWithBoleroDemo)
                routeCi
                    "/html-template-demo"
                    (demoContainer
                        "Html Template Demo"
                        $"Pages/HelperFunctions/HtmlTemplateDemo"
                        HelperFunctions.HtmlTemplateDemo.htmlTemplateDemo)
            ]
        routeCi "/cli-usage" CliUsage.CliUsage.cliUsage
        routeCi "/tests" Tests.Tests.tests
        routeCi "/antdesign" demoAntDesign
        routeCi "/fluentui" demoFluentUI
        routeCi "/drag-drop" demoDragDrop
        routeCi "/mudblazor" demoMudBlazor
    ]


let app =
    html.inject (fun (hook: IComponentHook, shareStore: IShareStore) ->
        let isOpen = cval (false)

        adaptiview () {
            adaptiview () {
                let! isDark = shareStore.isDarkMode
                MudThemeProvider'() { Theme(if isDark then darkTheme else defaultTheme) }
            }

            MudDialogProvider'()
            MudSnackbarProvider'()

            MudLayout'() {
                MudAppBar'() {
                    Color Color.Primary
                    Elevation 25
                    Dense true
                    adaptiview () {
                        let! isOpen, setIsOpen = isOpen.WithSetter()
                        MudIconButton'() {
                            Icon Icons.Material.Filled.Menu
                            Color Color.Inherit
                            Edge Edge.Start
                            OnClick(fun _ -> setIsOpen (not isOpen))
                        }
                    }
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
                MudMainContent'() {
                    styleBuilder {
                        paddingTop 100
                        paddingBottom 64
                    }
                    html.route [
                        // For host on slaveoftime.fun server mode
                        yield! routes
                        // For host on github-pages WASM mode
                        subRouteCi "/Fun.Blazor" routes
                        routeAny QuickStart.QuickStart.quickStart
                    ]
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
