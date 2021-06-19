namespace Fun.Blazor.Demo.Wasm

open Bolero


type App () =
    inherit Component()
    
    override _.Render() = home.ToBolero()
