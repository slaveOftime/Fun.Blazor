[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.DropDownDemo

open Fun.Blazor
open AntDesign

let dropDownDemo =
    dropdown.create [
        dropdown.overlay [
            menu.create [
                menuItemGroup.create [
                    menuItemGroup.title "Group title"
                    menuItemGroup.childContent [
                        menuItem.create "1st menu item"
                        menuItem.create "2st menu item"
                    ]
                ]
                subMenu.create [
                    subMenu.title "Sub menu"
                    subMenu.childContent [
                        menuItem.create "3st menu item"
                        menuItem.create "4st menu item"
                    ]
                ]
                subMenu.create [
                    subMenu.title "Disabled sub menu"
                    subMenu.disabled true
                    subMenu.childContent [
                        menuItem.create "5st menu item"
                        menuItem.create "6st menu item"
                    ]
                 ]
            ]
        ]
        dropdown.childContent [
            html.a [
                html.div "Cascading menu"
                html.div [
                    attr.styles []
                    attr.childContent [
                    ]
                ]
                icon.create [
                    icon.type' "down"
                ]
            ]
        ]
    ]
