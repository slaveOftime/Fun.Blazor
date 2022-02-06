[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.InteropWithBlazorDemo

open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Fun.Blazor
open Fun.Blazor.Operators
open MudBlazor


type CompForBlazor() as this =
    inherit FunBlazorComponent()

    let mutable c = 0

    [<Parameter>]
    member val Count = 0 with get, set


    override _.Render() =
        div {
            p { $"This is for blazor. Count = {c}" }
            button {
                onclick (fun _ -> c <- c + 1)
                "Increase"
            }
        }


let interopWithBlazorDemo =
    div {
        p { "We have cli to generate third party blazor component which should have better performance." }
        p { "But sometimes we may want to build it directly, we can do it like this:" }
        br
        html.blazor (fun ctx ->
            MudAlert(
                Severity = Severity.Success,
                ChildContent = ctx.Render(html.text "Hi")
            )
        )
        br
        adaptiview () {
            let! count, setCount = cval(0).WithSetter()
            html.blazor (fun _ -> CompForBlazor(Count = count))
            MudButton'() {
                Color Color.Primary
                OnClick(fun _ -> setCount 5)
                "Set count to 5"
            }
        }
    }
