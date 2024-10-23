// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.App

open Fun.Blazor
open MudBlazor
open Fun.Blazor.Docs.Controls
open Fun.Blazor.Docs.Wasm


let private theme =
    html.injectWithNoKey (fun (shareStore: IShareStore) -> adaptiview () {
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


let app =
    html.inject (fun (hook: IComponentHook, shareStore: IShareStore) ->
        hook.SetPrerenderStore(fun _ -> hook.SetDataToPrerenderStore(nameof hook.DocsTree, hook.DocsTree.Value))

        let appBar = MudAppBar'' {
            style {
                "backdrop-filter: blur(15px)"
                backgroundColor "transparent"
                color Theme.primaryColor
            }
            Elevation 3
            Dense
            childContent [|
                SectionOutlet'() { SectionName "toolbar-start" }
                a {
                    href ""
                    MudText'' {
                        Typo Typo.h6
                        Color Color.Primary
                        "Fun Blazor"
                    }
                }
                MudImage'' {
                    style { margin 10 }
                    Height 35
                    Width 35
                    Src $"fun-blazor.png"
                }
                MudSpacer'.create ()
                adaptiview () {
                    let! langStr, setLang = hook.Lang.WithSetter()
                    MudMenu'' {
                        style { maxWidth 120 }
                        Label langStr
                        StartIcon Icons.Material.Filled.Translate
                        EndIcon Icons.Material.Filled.KeyboardArrowDown
                        childContent [|
                            MudMenuItem'' {
                                OnClick(fun _ -> setLang "en")
                                "English"
                            }
                            MudMenuItem'' {
                                OnClick(fun _ -> setLang "cn")
                                "中文"
                            }
                        |]
                    }
                }
                adaptiview () {
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
                }
                MudIconButton'' {
                    Icon Icons.Custom.Brands.GitHub
                    Color Color.Inherit
                    Href "https://github.com/slaveOftime/Fun.Blazor"
                }
            |]
        }

        div {
            theme

            MudDialogProvider''
            MudSnackbarProvider''
            MudPopoverProvider''

            MudLayout'' {
                appBar
                SectionOutlet'() { SectionName "drawer" }
                MudMainContent'' {
                    style {
                        paddingTop 100
                        paddingBottom 64
                    }
                    isAppReadyIndicator
                    errorBundary routes
                    MudScrollToTop'' {
                        TopOffset 400
                        MudFab'' {
                            StartIcon Icons.Material.Filled.KeyboardArrowUp
                            Color Color.Primary
                        }
                    }
                }
            }

            interopScript

            styleElt { ruleset ".markdown-body li" { listStyleTypeInitial } }
        }
    )


type App() =
    inherit FunComponent()
    override _.Render() =
#if DEBUG
        html.hotReloadComp (app, "Fun.Blazor.Docs.Wasm.App.app")
#else
        app
#endif
