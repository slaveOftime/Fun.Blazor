[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.InteropWithBlazorDemo

open FSharp.Data.Adaptive
open Microsoft.AspNetCore.Components
open Fun.Blazor
open MudBlazor


type CompForBlazor() as this =
    inherit FunBlazorComponent()

    let increase () =
        this.Count <- this.Count + 1
        this.StateHasChanged()


    [<Parameter>]
    member val Count = 0 with get, set


    override _.Render() =
        div {
            p { $"This is for blazor. Count = {this.Count}" }
            button {
                onclick (fun _ -> increase())
                "Increase"
            }
        }


let interopWithBlazorDemo =
    div {
        p { "We have cli to generate third party blazor component which should have better performance." }
        p { "But sometimes we may want to build it directly, we can do it like this:" }
        br
        html.component (fun root ->
            MudAlert(
                Severity = Severity.Success,
                ChildContent = root.Render(html.text "Hi")
            )
        )
        br
        adaptiview () {
            let! count, setCount = cval(0).WithSetter()
            html.component (fun _ -> CompForBlazor(Count = count))
            MudButton'() {
                Color Color.Primary
                OnClick(fun _ -> setCount 5)
                "Set count to 5"
            }
        }
    }
