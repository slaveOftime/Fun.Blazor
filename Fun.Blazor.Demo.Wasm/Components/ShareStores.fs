module Fun.Blazor.Demo.Wasm.Components.ShareStores

open Fun.Blazor


let isDarkMode (shareStore: IShareStore) = shareStore.Create ("isDarkMode", false)
