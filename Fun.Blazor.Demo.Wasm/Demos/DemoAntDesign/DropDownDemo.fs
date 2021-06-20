[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoAntDesign.DropDownDemo

open Fun.Blazor
open Fun.Blazor.AntDesign


let dropDownDemo =
    dropdown.create [
        dropdown.overlay [
            menu.create [
                menuItemGroup.create [
                    menuItemGroup.title "Group title"
                    menuItemGroup.childContent [
                        menuItem.create (html.text "1st menu item")
                        menuItem.create (html.text "2st menu item")
                    ]
                ]
                subMenu.create [
                    subMenu.title "Sub menu"
                    subMenu.childContent [
                        menuItem.create (html.text "3st menu item")
                        menuItem.create (html.text "4st menu item")
                    ]
                ]
                subMenu.create [
                    subMenu.title "Disabled sub menu"
                    subMenu.disabled true
                    subMenu.childContent [
                        menuItem.create (html.text "5st menu item")
                        menuItem.create (html.text "6st menu item")
                    ]
                ]
            ]
        ]
        dropdown.childContent [
            html.a [
                html.text "Cascading menu"
                icon.create [
                    icon.type' "down"
                ]
            ]
        ]
    ]
