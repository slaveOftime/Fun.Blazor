[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.DropDownDemo

open Fun.Blazor
open AntDesign

let dropDownDemo =
    dropdown() {
        overlay [
            menu.create [
                menuItemGroup() {
                    title "Group title"
                    childContent [
                        menuItem.create "1st menu item"
                        menuItem.create "2st menu item"
                    ]
                }
                subMenu() {
                    title "Sub menu"
                    childContent [
                        menuItem.create "3st menu item"
                        menuItem.create "4st menu item"
                    ]
                }
                subMenu() {
                    title "Disabled sub menu"
                    disabled true
                    childContent [
                        menuItem.create "5st menu item"
                        menuItem.create "6st menu item"
                    ]
                }
            ]
        ]
        childContent [
            html.a [
                html.div "Cascading menu"
                icon() {
                    type' "down"
                }
            ]
        ]
    }
