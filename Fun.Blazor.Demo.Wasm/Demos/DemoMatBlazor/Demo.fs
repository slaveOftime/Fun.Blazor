[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoMatBlazor.Demo

open MatBlazor
open Feliz
open Fun.Blazor
open Fun.Blazor.MatBlazor


let theme =
    MatTheme
        (Primary = MatThemeColors.Blue._500.Value
        ,Secondary = MatThemeColors.Red._300.Value)


let demoMatBlazor = html.inject (fun (localStore: ILocalStore) ->
    let isMenuOpen = localStore.Create false

    matThemeProvider.create [
        matThemeProvider.theme theme
        matThemeProvider.children [
            matAppBarContainer.create [
                matAppBar.create [
                    matAppBar.fixed' true
                    matAppBar.children [
                        matAppBarRow.create [
                            matAppBarSection.create [
                                matIconButton.create [
                                    matIconButton.icon "menu"
                                    matIconButton.onClick (fun _ -> isMenuOpen.Publish not)
                                ]
                                matAppBarTitle.create [
                                    html.text "Slaveoftime"
                                ]
                            ]
                            matAppBarSection.create [
                                matAppBarSection.align MatAppBarSectionAlign.End
                                matAppBarSection.children [
                                    matIconButton.create [
                                        matIconButton.icon "favorite"
                                    ]                            
                                ]
                            ]
                        ]
                    ]
                ]
                matAppBarContent.create [
                    matSelect<string>.create [
                        matSelect.label "Pick a item"
                        matSelect.value ""
                        matSelect.children [
                            for i in [1..10] do
                                matOptionString.create [
                                    matOptionString.value (string i)
                                    matOptionString.children (string i)
                                ]
                        ]
                    ]
                    
                    matDivider.create []

                    matTextField<string>.create [
                        matTextField.value "test"
                        matTextField.label "World"
                    ]

                    html.watch (isMenuOpen, fun isMenuOpen ->
                        matCheckbox<bool>.create [
                            matCheckbox.label "Check a go"
                            matCheckbox.value isMenuOpen
                        ]
                    )
                    html.watch (isMenuOpen, fun isOpen ->
                        if isOpen then
                            matDrawerContainer.create [
                                matDrawerContainer.styles [ 
                                    style.positionAbsolute
                                    style.top 0
                                    style.width (length.vw 100)
                                    style.height (length.vh 100)
                                ]
                                matDrawerContainer.children [
                                    matDrawer.create [
                                        !!(evt.click (fun _ -> isMenuOpen.Publish not))
                                        matDrawer.opened isOpen
                                        matDrawer.mode MatDrawerMode.Modal
                                        matDrawer.children [
                                            html.text "Drawer"
                                            matTextField<string>.create [
                                                matTextField.value "test"
                                                matTextField.label "World"
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        else
                            html.none
                    )
                ]
            ]
        ]
    ])
