[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Components.JsInterop

open Microsoft.JSInterop
open Fun.Blazor


let private highlightCode =
    js """
        window.highlightCode = () => {
            if (!!Prism) {
                Prism.highlightAll();
            } else {
                setTimeout(Prism.highlightAll, 5000)
            }
        }
    """


let interopScript =
    fragment {
        highlightCode
    }


type IJSRuntime with
    member js.highlightCode() = js.InvokeAsync("highlightCode")
