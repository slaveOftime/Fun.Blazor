[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Home

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Blazor.Demo.Wasm.DemoMudBlazor
open Fun.Blazor.Demo.Wasm.DemoAntDesign
open Fun.Blazor.Demo.Wasm.DemoFluentUI
open Fun.Blazor.Demo.Wasm.Components


let defaultTheme =
    MudTheme
        (Palette =
            Palette(
                Primary = "#64a689",
                Secondary = "#a664a2",
                Black = "#212121"))

let darkTheme =
    MudTheme
        (Palette =
            Palette(
                Primary = "#64a689",
                Secondary = "#a664a2",
                Black = "#27272f",
                Background = "#32333d",
                BackgroundGrey = "#27272f",
                Surface = "#373740",
                DrawerBackground = "#27272f",
                DrawerText = "rgba(255,255,255, 0.50)",
                DrawerIcon = "rgba(255,255,255, 0.50)",
                AppbarBackground = "#27272f",
                AppbarText = "rgba(255,255,255, 0.70)",
                TextPrimary = "#64a689",
                TextSecondary = "#a664a2",
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
        mudNavGroup.create [
            mudNavGroup.title "Demos"
            mudNavGroup.icon Icons.Material.Filled.School
            mudNavGroup.expanded true
            mudNavGroup.childContent [
                mudNavLink.create [
                    mudNavLink.href "./mudblazor"
                    mudNavLink.childContent "MudBlazor"
                ]
                mudNavLink.create [
                    mudNavLink.href "./antdesign"
                    mudNavLink.childContent "Antdesign"
                ]
                mudNavLink.create [
                    mudNavLink.href "./fluentui"
                    mudNavLink.childContent "FluentUI"
                ]
            ]
        ]
    ]


let home = html.inject (fun (localStore: ILocalStore, shareStore: IShareStore) ->
    let isDarkMode = ShareStores.isDarkMode shareStore
    let openMenu = localStore.Create false
    
    html.div [
        html.watch (isDarkMode, fun isDark ->
            mudThemeProvider.create [
                mudThemeProvider.theme (if isDark then darkTheme else defaultTheme)
            ]
        )
        mudDialogProvider.create []
        mudSnackbarProvider.create []

        mudSwipeArea.create [
            mudSwipeArea.onSwipe (fun _ -> openMenu.Publish not)
            mudSwipeArea.childContent [
                mudLayout.create [
                    mudLayout.rightToLeft false
                    mudLayout.childContent [
                        mudAppBar.create [
                            mudAppBar.color Color.Primary
                            mudAppBar.elevation 25
                            mudAppBar.dense true
                            mudAppBar.childContent [
                                mudIconButton.create [
                                    mudIconButton.icon Icons.Material.Filled.Menu
                                    mudIconButton.color Color.Inherit
                                    mudIconButton.edge Edge.Start
                                    mudIconButton.onClick (fun _ -> openMenu.Publish not)
                                ]
                                mudText.create [
                                    mudText.typo Typo.h6
                                    mudText.color Color.Default
                                    mudText.childContent "Fun Blazor"
                                ]
                                mudSpacer.create ()
                                mudTooltip.create [
                                    mudTooltip.text "Toggel light/dark theme"
                                    mudTooltip.childContent [
                                        mudIconButton.create [
                                            mudIconButton.icon Icons.Material.Filled.Brightness4
                                            mudIconButton.color Color.Inherit
                                            mudIconButton.onClick (fun _ -> isDarkMode.Publish not)
                                        ]
                                    ]
                                ]
                                mudTooltip.create [
                                    mudTooltip.text "Github repository"
                                    mudTooltip.childContent [
                                        mudIconButton.create [
                                            mudIconButton.icon Icons.Custom.Brands.GitHub
                                            mudIconButton.color Color.Inherit
                                            mudIconButton.link "https://github.com/slaveOftime/Fun.Blazor"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        html.watch (openMenu, fun isOpen ->
                            mudDrawer.create [
                                mudDrawer.open' isOpen
                                mudDrawer.elevation 25
                                mudDrawer.openChanged openMenu.Publish
                                mudDrawer.childContent [
                                    //mudDrawerHeader.create [
                                    //    mudDrawerHeader.linkToIndex true
                                    //    mudDrawerHeader.childContent [
                                    //        mudIconButton.create [
                                    //            mudIconButton.color Color.Primary
                                    //            mudIconButton.icon Icons.Custom.Brands.GitHub
                                    //        ]
                                    //    ]
                                    //]
                                    navmenu
                                ]
                            ]
                        )
                        mudMainContent.create [
                            mudMainContent.styles [
                                style.paddingTop 100
                                style.paddingBottom 64
                                style.paddingRight 30
                            ]
                            mudMainContent.childContent [ 
                                html.route (function
                                    | [ _; "antdesign" ]
                                    | [ "antdesign" ] -> demoAntDesign
                                    | [ _; "fluentui" ]
                                    | [ "fluentui" ] -> demoFluentUI
                                    | [ "mudblazor" ]
                                    | _ -> demoMudBlazor
                                )
                                mudScrollToTop.create [
                                    mudScrollToTop.topOffset 400
                                    mudScrollToTop.childContent [
                                    
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

        html.stylesheet "https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"
        html.stylesheet "_content/MudBlazor/MudBlazor.min.css"
        html.script "_content/MudBlazor/MudBlazor.min.js"
    ])
