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

        let congratulations = Template.html $"<div>Congratulations! You made it ❤️</div>"

        Template.html
            $"""
            <div>
                {congratulations}
                <p>
                    You need to bring <span style="font-weight: bold; color: green; padding: 5px;">Fun.Blazor.HtmlTemplate</span> package to make this work!!!
                </p>
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
                <div style="color: {if count = 3 then "red" else "green"};">Cool!!</div>
                <div style="{if count = 4 then "color: red;" else "color: green;"}">Cool!!</div>

                <sl-button onclick="{ignore >> increaseBy2}">Increase by 2</sl-button>
                <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.0.0-beta.62/dist/themes/light.css">
                <script type="module" src="https://cdn.jsdelivr.net/npm/@shoelace-style/shoelace@2.0.0-beta.62/dist/shoelace.js"></script>
            </div>
        """
    }
