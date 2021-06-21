namespace Fun.Blazor.Docs.Wasm

open Bolero


type App () =
    inherit Component()
    
    override _.Render() = home.ToBolero()
