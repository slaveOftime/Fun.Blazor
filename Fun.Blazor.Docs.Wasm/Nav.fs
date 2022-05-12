[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Nav

open Fun.Blazor
open Fun.Blazor.Router
open MudBlazor
open Fun.Blazor.Docs.Wasm.Components
open Fun.Blazor.Docs.Wasm.Pages


let navmenu =
    MudNavMenu'() {
        childContent [
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
                Href "./hot-reload"
                "HotReload"
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
                childContent [
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
                        Href "./helper-functions/blazor"
                        "Blazor interop"
                    }
                    MudNavLink'() {
                        Href "./helper-functions/bolero"
                        "Bolero interop"
                    }
                ]
            }
        ]
    }


let routes =
    [
        subRouteCi "/router" [ routeAny Router.Router.router ]
        routeCi
            "/adaptive-form"
            (demoContainer "Adaptive Form" $"Pages/HelperFunctions/AdaptiveFormDemo" HelperFunctions.AdaptiveFormDemo.adaptiveFormDemo)
        routeCi "/hot-reload" HotReload.HotReload.hotReload
        routeCi "/elmish" Elmish.Elmish.elmish
        subRouteCi
            "/helper-functions"
            [
                routeCi "/html-inject" (demoContainer "html.inject" "Pages/HelperFunctions/InjectDemo" HelperFunctions.InjectDemo.injectDemo)
                routeCi "/html-watch" (demoContainer "html.watch" $"Pages/HelperFunctions/HtmlWatchDemo" HelperFunctions.HtmlWatchDemo.htmlWatchDemo)
                routeCi "/adaptiview" (demoContainer "adapt" $"Pages/HelperFunctions/AdaptiveDemo" HelperFunctions.AdaptiviewDemo.adaptiviewDemo)
                routeCi
                    "/component-hook"
                    (demoContainer "IComponentHook" $"Pages/HelperFunctions/ComponentHookDemo" HelperFunctions.ComponentHookDemo.componentHookDemo)
                routeCi
                    "/global-store"
                    (demoContainer "Global storage" $"Pages/HelperFunctions/GlobalStoreDemo" HelperFunctions.GlobalStoreDemo.globalStoreDemo)
                routeCi
                    "/performance"
                    (demoContainer "Performance" $"Pages/HelperFunctions/PerformanceDemo" HelperFunctions.PerformanceDemo.performanceDemo)
                routeCi "/ce-css-builder" (demoContainer "CE style css builder" $"Pages/HelperFunctions/CECssDemo" HelperFunctions.CECssDemo.ceCssDemo)
                routeCi
                    "/blazor"
                    (demoContainer
                        "Blazor interop"
                        "Pages/HelperFunctions/InteropWithBlazorDemo"
                        HelperFunctions.InteropWithBlazorDemo.interopWithBlazorDemo)
                routeCi
                    "/html-template-demo"
                    (demoContainer "Html Template Demo" $"Pages/HelperFunctions/HtmlTemplateDemo" HelperFunctions.HtmlTemplateDemo.htmlTemplateDemo)
            ]
        routeCi "/cli-usage" CliUsage.CliUsage.cliUsage
        routeCi "/tests" Tests.Tests.tests
    ]
