[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.DropDownDemo

open Fun.Blazor
open AntDesign

let dropDownDemo =
    dropdown() {
        overlay [
            menu [
                menuItemGroup() {
                    title "Group title"
                    childContent [
                        menuItem "1st menu item"
                        menuItem "2st menu item"
                    ]
                    CAST
                }
                subMenu() {
                    title "Sub menu"
                    childContent [
                        menuItem "3st menu item"
                        menuItem "4st menu item"
                    ]
                    CAST
                }
                subMenu() {
                    title "Disabled sub menu"
                    disabled true
                    childContent [
                        menuItem "5st menu item"
                        menuItem "6st menu item"
                    ]
                    CAST
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
