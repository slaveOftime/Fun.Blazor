[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.ShareStores

open Fun.Blazor


type IShareStore with

    member store.isDarkMode = store.CreateCVal("isDarkMode", false)
