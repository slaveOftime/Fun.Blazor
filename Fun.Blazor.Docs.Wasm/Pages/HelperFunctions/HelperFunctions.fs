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
            demoContainer "ComponentHook" $"{root}/ComponentHookDemo" componentHookDemo
            demoDivider
            demoContainer "Global storage" $"{root}/GlobalStoreDemo" globalStoreDemo
        ]
