[<AutoOpen>]
module Fun.Blazor.Demo.MatBlazorDemo

open MatBlazor
open Feliz
open Fun.Blazor
open Fun.Blazor.MatBlazor


let theme =
    MatTheme
        (Primary = MatThemeColors.Blue._500.Value
        ,Secondary = MatThemeColors.Red._300.Value)


let matBlazorDemo = html.inject (fun (localStore: ILocalStore) ->
    let isMenuOpen = localStore.Create false

    matThemeProvider.matThemeProvider [
        matThemeProvider.theme theme
        matThemeProvider.children [
            matAppBarContainer.matAppBarContainer [
                matAppBar.matAppBar [
                    matAppBar.``fixed`` true
                    matAppBar.children [
                        matAppBarRow.matAppBarRow [
                            matAppBarSection.matAppBarSection [
                                matIconButton.matIconButton [
                                    matIconButton.icon "menu"
                                    matIconButton.onClick (fun _ -> isMenuOpen.Publish not)
                                ]
                                matAppBarTitle.matAppBarTitle [
                                    html.text "Slaveoftime"
                                ]
                            ]
                            matAppBarSection.matAppBarSection [
                                matAppBarSection.align MatAppBarSectionAlign.End
                                matAppBarSection.children [
                                    matIconButton.matIconButton [
                                        matIconButton.icon "favorite"
                                    ]                            
                                ]
                            ]
                        ]
                    ]
                ]
                matAppBarContent.matAppBarContent [
                    matSelect<string>.matSelect [
                        matSelect.label "Pick a item"
                        matSelect.value ""
                        matSelect.children [
                            for i in [1..10] do
                                matOptionString.matOptionString [
                                    matOptionString.value (string i)
                                    matOptionString.children (string i)
                                ]
                        ]
                    ]
                    
                    matDivider.matDivider []

                    matTextField<string>.matTextField [
                        matTextField.value "test"
                        matTextField.label "World"
                    ]

                    html.watch (isMenuOpen, fun isMenuOpen ->
                        matCheckbox<bool>.matCheckbox [
                            matCheckbox.label "Check a go"
                            matCheckbox.value isMenuOpen
                        ]
                    )
                    html.watch (isMenuOpen, fun isOpen ->
                        if isOpen then
                            matDrawerContainer.matDrawerContainer [
                                matDrawerContainer.styles [ 
                                    style.positionAbsolute
                                    style.top 0
                                    style.width (length.vw 100)
                                    style.height (length.vh 100)
                                ]
                                matDrawerContainer.children [
                                    matDrawer.matDrawer [
                                        !!(evt.click (fun _ -> isMenuOpen.Publish not))
                                        matDrawer.opened isOpen
                                        matDrawer.mode MatDrawerMode.Modal
                                        matDrawer.children [
                                            html.text "Drawer"
                                            matTextField<string>.matTextField [
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
