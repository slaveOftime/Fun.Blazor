[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.HelperFunctions.HtmlTemplateDemo

open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor


let htmlTemplateDemo =
    adaptiview () {
        let! count, setCount = cval(1).WithSetter()

        let increaseBy2 () = setCount (count + 2)

        let increaseBtn =
            MudButton'() {
                OnClick(fun _ -> setCount (count + 1))
                Variant Variant.Filled
                Color Color.Primary
                childContent "Mud Increase Btn"
            }

        let congratulations = Template.html <@ """<div>Congratulations! You made it ❤️""" @>

        Template.html
            <@ Template.html
                $"""
                <div>
                    {congratulations}
                    <p style="background-color: hotpink; padding: 10px; color: white;">
                        The whole fsharp quotation will be evaluated to a bolero node dom tree and rendered by blazor
                    </p>
                    <br/>
                    Here is the count: {count}
                    <div>
                        <button onclick="{fun _ -> setCount (count + 1)}">Increase</button>
                        <button onclick="{ignore >> increaseBy2}">Increase by 2</button>
                        {increaseBtn}
                    </div>
                    {match count with
                     | 1 -> html.div "Match 1"
                     | _ -> html.div "Match _"}
                </div>
            """ @>
    }
