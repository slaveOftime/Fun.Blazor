[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.HtmlTemplateDemo

open System
open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor


let private alert =
    MudAlert'() {
        Severity Severity.Error
        childContent "This is the way"
    }

let htmlTemplateDemo =
    adaptiview () {
        let! count, setCount = cval(1).WithSetter()

        let increaseBtn =
            MudButton'() {
                OnClick(fun _ -> setCount (count + 1))
                childContent "Increase"
            }

        HtmlTemplate
            <@ Template.html
                $"""
                <div style="color: red;">
                    <p style="background-color: hotpink; padding: 10px;">
                        The whole fsharp quotation will be evaluated to a bolero node dom tree
                    </p>
                    <br/>
                    Here is the count: {count}
                    <button onclick="{fun (_: EventArgs) -> setCount (count + 1)}">Increase</button>
                    {increaseBtn}
                    <br/>
                    You can inline any other bolero node just by fsharp string interpolation like this {alert}
                </div>
            """ @>
    }
