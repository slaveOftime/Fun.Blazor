[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.App

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web
open Fun.Blazor
open MudBlazor
open Fun.Blazor.Docs.Controls
open Fun.Blazor.Docs.Wasm


let theme =
    html.injectWithNoKey (fun (shareStore: IShareStore) -> adapt {
        let! isDark = shareStore.IsDarkMode
        MudThemeProvider'' {
            IsDarkMode isDark
            Theme(Theme.FunTheme.Create())
        }
        stylesheet (
            if isDark then
                "css/github-markdown-dark.css"
            else
                "css/github-markdown-light.css"
        )
    })

let private themeSwitcher =
    html.inject (fun (shareStore: IShareStore) -> adapt {
        let! isDark, setIsDark = shareStore.IsDarkMode.WithSetter()
        MudIconButton'' {
            Color Color.Inherit
            Icon(
                if isDark then
                    Icons.Material.Filled.Brightness4
                else
                    Icons.Material.Filled.Brightness3
            )
            OnClick(fun _ -> setIsDark (not isDark))
        }
    })


let private appBar = MudAppBar'' {
    style {
        "backdrop-filter: blur(15px)"
        backgroundColor "transparent"
        color Theme.secondaryColor
    }
    Elevation 1
    Dense

    SectionOutlet'' { SectionName "toolbar-start" }

    MudImage'' {
        style { margin 10 }
        Height 35
        Width 35
        Src "fun-blazor.png"
    }
    a {
        href ""
        MudText'' {
            Typo Typo.h6
            Color Color.Secondary
            class' "animated-glow-secondary-text"
            "Fun.Blazor"
        }
    }

    section {
        style {
            margin 0 24
            displayFlex
            alignItemsCenter
            gap 8
        }
        MudLink'' {
            Href "docs"
            Color Color.Secondary
            "Docs"
        }
    }

    MudSpacer'' { }

    SectionOutlet'' { SectionName "toolbar-end" }

    MudIconButton'' {
        Icon Icons.Custom.Brands.GitHub
        Color Color.Inherit
        Href "https://github.com/slaveOftime/Fun.Blazor"
    }
}


let app =
    html.inject (fun (hook: IComponentHook) ->
        hook.SetPrerenderStore(fun _ -> hook.SetDataToPrerenderStore(nameof hook.DocsTree, hook.DocsTree.Value))

        fragment {
            theme

            MudDialogProvider'' { }
            MudSnackbarProvider'' { }
            MudPopoverProvider'' { }

            MudLayout'' {
                appBar
                SectionOutlet'' { SectionName "drawer" }
                MudMainContent'' {
                    style {
                        paddingTop 100
                        paddingBottom 64
                    }
                    isAppReadyIndicator
                    errorBundary routes
                    MudScrollToTop'' {
                        MudFab'' {
                            StartIcon Icons.Material.Filled.KeyboardArrowUp
                            Color Color.Primary
                        }
                    }
                }
            }

            interopScript
        }
    )


type App() =
    inherit FunComponent()
    override _.Render() = app
