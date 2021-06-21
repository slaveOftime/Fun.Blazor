[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Pages.HelperFunctions.HelperFunctions

open Fun.Blazor.Demo.Wasm.Components


let private root = "Pages/HelperFunctions"

let helperFunctions =
    simplePage
        ""
        "Useful helper functions"
        ""
        ""
        [
            demoContainer "Local storage" $"{root}/LocalStoreDemo" localStoreDemo
        ]
