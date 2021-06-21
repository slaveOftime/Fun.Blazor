[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.Router.Router

open Fun.Blazor.Docs.Wasm.Components


let private root = "Pages/Router"

let router =
    simplePage
        "https://github.com/Zaid-Ajaj/Feliz.Router"
        "Router"
        "The main functional code is copy from Feliz.Router"
        "Simple and easy to use"
        [
            demoContainer "Basic Router" $"{root}/RouterDemo" routerDemo
        ]
