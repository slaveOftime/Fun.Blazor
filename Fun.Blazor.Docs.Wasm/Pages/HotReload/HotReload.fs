[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HotReload.HotReload

open Fun.Blazor.Docs.Wasm.Components


let hotReload =
    simplePage
        ""
        "HotReload"
        "Limited hot-reload powered by FSharp.Compiler.PortaCode"
        ""
        (sourceSection "Pages/HotReload/HotReloadDemo")
