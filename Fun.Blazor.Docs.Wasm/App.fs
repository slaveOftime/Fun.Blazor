// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.App

open FSharp.Data.Adaptive
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Router
open MudBlazor
open Fun.Blazor.Docs.Controls
open Fun.Blazor.Docs.Wasm


let private isReadyIndicator =
    html.inject (fun (hook: IComponentHook) ->
        let mutable showMessage = true

        hook.OnFirstAfterRender.Add(fun _ ->
            showMessage <- false
            hook.StateHasChanged()
        )

        div {
            if showMessage then
                div {
                    style { margin -40 10 40 10 }
                    childContent [|
                        MudProgressLinear'' {
                            Color Color.Warning
                            Indeterminate
                        }
                        spaceV2
                        MudText'' {
                            Color Color.Warning
                            Typo Typo.subtitle2
                            ".NET WASM is still loading. You can interact in this page after it's fully loaded."
                        }
                        MudText'' {
                            Color Color.Info
                            Typo Typo.body2
                            "Current page is prerendered."
                        }
                    |]
                }
        }
    )


let app =
    html.inject (fun (hook: IComponentHook, shareStore: IShareStore) ->
        hook.SetPrerenderStore(fun _ -> hook.SetDataToPrerenderStore(nameof hook.DocsTree, hook.DocsTree.Value))

        let isOpen = cval true

        let theme = adaptiview () {
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
        }

        let menuBtn = adaptiview () {
            let! isOpen, setIsOpen = isOpen.WithSetter()
            MudIconButton'' {
                Icon Icons.Material.Filled.Menu
                Color Color.Inherit
                Edge Edge.Start
                OnClick(fun _ -> setIsOpen (not isOpen))
            }
        }

        let appBar = MudAppBar'' {
            style {
                "backdrop-filter: blur(15px)"
                backgroundColor "transparent"
                color Theme.primaryColor
            }
            Elevation 3
            Dense
            childContent [|
                menuBtn
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

        let drawer = adaptiview () {
            let! binding = isOpen.WithSetter()
            MudDrawer'' {
                Open' binding
                Elevation 25
                ClipMode DrawerClipMode.Always
                navmenu
            }
        }

        let routesView = adaptiview () {
            match! hook.GetOrLoadDocsTree() with
            | LoadingState.NotStartYet -> notFound
            | LoadingState.Loading -> MudProgressLinear'.create ()
            | LoadingState.Loaded docs
            | LoadingState.Reloading docs ->
                let routes = [ docRouting docs; Demos.GiraffeStyleRouter.demoRouting ]
                html.route (
                    docs,
                    [|
                        // For host on slaveoftime.fun server mode
                        yield! routes
                        // For host on github-pages WASM mode
                        subRouteCi "/Fun.Blazor.Docs" routes
                        routeAny (
                            docs
                            |> Seq.tryHead
                            |> Option.map (
                                function
                                | DocTreeNode.Category(doc, _, _)
                                | DocTreeNode.Doc doc -> docView doc
                            )
                            |> Option.defaultValue notFound
                        )
                    |]
                )
        }


        div.create [|
            theme
            MudDialogProvider'.create ()
            MudSnackbarProvider'.create ()
            MudPopoverProvider'.create ()
            MudLayout'.create [|
                appBar
                drawer
                MudMainContent'' {
                    style {
                        paddingTop 100
                        paddingBottom 64
                    }
                    childContent [|
                        isReadyIndicator
                        errorBundary routesView
                        MudScrollToTop'' {
                            TopOffset 400
                            MudFab'' {
                                StartIcon Icons.Material.Filled.KeyboardArrowUp
                                Color Color.Primary
                            }
                        }
                    |]
                }
            |]
            interopScript
            styleElt { ruleset ".markdown-body li" { listStyleTypeInitial } }
        |]
    )


type App() =
    inherit FunComponent()
    override _.Render() =
#if DEBUG
        html.hotReloadComp (app, "Fun.Blazor.Docs.Wasm.App.app")
#else
        app
#endif
