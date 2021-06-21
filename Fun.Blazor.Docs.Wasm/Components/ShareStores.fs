module Fun.Blazor.Docs.Wasm.Components.ShareStores

open Fun.Blazor


let isDarkMode (shareStore: IShareStore) = shareStore.Create ("isDarkMode", false)
