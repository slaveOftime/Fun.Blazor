[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.Router.Router

open Fun.Blazor
open Fun.Blazor.Docs.Wasm.Components


let private root = "Pages/Router"

let router =
    simplePage
        ""
        "Router"
        "The main functional code is copy from Feliz.Router and Giraffe"
        "Simple and easy to use"
        (fragment {
            demoContainer "Giraffe style Router" $"{root}/GiraffeStyleRouterDemo" giraffeStyleRouterDemo
            demoDivider
            demoContainer "Feliz style Router" $"{root}/RouterDemo" routerDemo
         })
