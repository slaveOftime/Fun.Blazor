[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Components.DemoContainer

open MudBlazor
open Fun.Blazor
open Fun.Blazor.MudBlazor


let demoContainer (title: string) fileName content = html.inject (fun (store: ILocalStore, hook: IComponentHook) ->

    html.div [
        attr.styles [ style.margin 10 ]
        mudContainer.create [
            mudContainer.maxWidth MaxWidth.Medium
            mudContainer.children [
                mudText.create [
                    mudText.typo Typo.h4
                    mudText.children title
                ]
                spaceV2
                mudPaper.create [
                    mudPaper.elevation 30
                    mudPaper.children [ content ]
                ]
                spaceV2
                sourceSection fileName
            ]
        ]
    ])
