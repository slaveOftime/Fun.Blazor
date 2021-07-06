[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.DropDownDemo

open Fun.Blazor
open AntDesign

let dropDownDemo =
    Dropdown'() {
        Overlay [
            Menu'.create [
                MenuItemGroup'() {
                    Title "Group title"
                    ChildContent [
                        MenuItem'.create "1st menu item"
                        MenuItem'.create "2st menu item"
                    ]
                }
                SubMenu'() {
                    Title "Sub menu"
                    ChildContent [
                        MenuItem'.create "3st menu item"
                        MenuItem'.create "4st menu item"
                    ]
                }
                SubMenu'() {
                    Title "Disabled sub menu"
                    Disabled true
                    ChildContent [
                        MenuItem'.create "5st menu item"
                        MenuItem'.create "6st menu item"
                    ]
                }
            ]
        ]
        ChildContent [
            html.a [
                html.div "Cascading menu"
                Icon'() {
                    Type "down"
                }
            ]
        ]
    }
