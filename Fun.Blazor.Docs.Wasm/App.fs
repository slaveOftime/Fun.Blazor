// hot-reload
[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.App

open FSharp.Data.Adaptive
open Fun.Result
open Fun.Blazor
open Fun.Blazor.Router
open MudBlazor
open Fun.Blazor.Docs.Controls


let app =
    html.inject (fun (hook: IComponentHook, shareStore: IShareStore) ->
        let isOpen = cval true

        let theme =
            adaptiview () {
                let! isDark = shareStore.IsDarkMode

                MudThemeProvider'() { Theme(if isDark then Theme.darkTheme else Theme.defaultTheme) }

                if isDark then
                    stylesheet "css/github-markdown-dark.css"
                else
                    stylesheet "css/github-markdown-light.css"
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
                style {
                    custom "backdrop-filter" "blur(15px)"
                    backgroundColor "transparent"
                    color Theme.primaryColor
                }
                Elevation 25
                Dense true
                childContent [
                    menuBtn
                    MudText'() {
                        Typo Typo.h6
                        Color Color.Default
                        "Fun Blazor"
                    }
                    MudImage'() {
                        style { margin 10 }
                        Height 35
                        Width 35
                        Src $"fun-blazor.png"
                    }
                    MudSpacer'.create ()
                    adaptiview () {
                        let! isDark, setIsDark = shareStore.IsDarkMode.WithSetter()
                        MudIconButton'() {
                            Color Color.Inherit
                            Icon(if isDark then Icons.Filled.Brightness4 else Icons.Filled.Brightness3)
                            OnClick(fun _ -> setIsDark (not isDark))
                        }
                    }
                    MudIconButton'() {
                        Icon Icons.Custom.Brands.GitHub
                        Color Color.Inherit
                        Link "https://github.com/slaveOftime/Fun.Blazor"
                    }
                ]
            }

        let drawer =
            adaptiview () {
                let! isOpen = isOpen
                MudDrawer'() {
                    Open isOpen
                    Elevation 25
                    Variant DrawerVariant.Persistent
                    ClipMode DrawerClipMode.Always
                    navmenu
                }
            }


        html.fragment [
            theme
            MudDialogProvider'.create ()
            MudSnackbarProvider'.create ()
            MudLayout'.create [
                appBar
                drawer
                MudMainContent'() {
                    style {
                        paddingTop 100
                        paddingBottom 64
                    }
                    adaptiview () {
                        match! hook.GetOrLoadDocsTree() with
                        | LoadingState.NotStartYet -> notFound
                        | LoadingState.Loading -> MudProgressLinear'.create ()
                        | LoadingState.Loaded docs
                        | LoadingState.Reloading docs ->
                            html.route [
                                // For host on slaveoftime.fun server mode
                                docRouting docs
                                Demos.GiraffeStyleRouter.demoRouting
                                // For host on github-pages WASM mode
                                subRouteCi "/Fun.Blazor.Docs" [ docRouting docs; Demos.GiraffeStyleRouter.demoRouting ]
                                routeAny (
                                    docs
                                    |> Seq.tryHead
                                    |> Option.map (
                                        function
                                        | DocTreeNode.Category (doc, _, _)
                                        | DocTreeNode.Doc doc -> docView doc
                                    )
                                    |> Option.defaultValue notFound
                                )
                            ]
                    }
                    MudScrollToTop'() {
                        TopOffset 400
                        MudFab'() {
                            Icon Icons.Material.Filled.KeyboardArrowUp
                            Color Color.Primary
                        }
                    }
                }
            ]
            interopScript
        ]
    )
