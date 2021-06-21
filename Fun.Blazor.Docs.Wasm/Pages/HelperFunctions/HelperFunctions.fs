[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.HelperFunctions

open Fun.Blazor.Docs.Wasm.Components


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
