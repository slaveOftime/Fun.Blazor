[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.Pages.QuickStart.QuickStart

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor
open Fun.Blazor.Docs.Wasm.Components


let root = "Pages/QuickStart"

let quickStart =
    simplePage
        "https://github.com/slaveOftime/Fun.Blazor"
        "Fun.Blazor"
        "This is a project to make F# developer to write blazor easier."
        "It is based on Bolero and Feliz.Engine"
        [
            html.div [
                attr.styles [ style.margin 20 ]
                attr.className "d-flex justify-center"
                attr.childContent [
                    mudButton.create [
                        mudButton.link "./cli-usage"
                        mudButton.variant Variant.Filled
                        mudButton.color Color.Secondary
                        mudButton.childContent "Check thrid party dsl generating cli"
                    ]
                ]
            ]
            sourceSection "README"
            //demoDivider
            //demoContainer "Basic usage" $"{root}/BasicUsageDemo" basicUsageDemo
        ]
