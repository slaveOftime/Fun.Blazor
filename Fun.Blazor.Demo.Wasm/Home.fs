[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Home

open Fun.Blazor
open Fun.Blazor.MatBlazor
open Fun.Blazor.Demo.Wasm.DemoMudBlazor
open Fun.Blazor.Demo.Wasm.DemoMatBlazor
open Fun.Blazor.Demo.Wasm.DemoAntDesign
open Fun.Blazor.Demo.Wasm.DemoFluentUI


let home = html.inject (fun (localStore: ILocalStore) ->
    let index = localStore.Create 0
    
    html.div [
        html.watch (index, fun d ->
            matTabGroup.create [
                matTabGroup.activeIndex d
                matTabGroup.activeIndexChanged index.Publish
                matTabGroup.children [
                    matTab.create [
                        matTab.label "MudBlazor"
                    ]
                    matTab.create [
                        matTab.label "MatBlazor"
                    ]
                    matTab.create [
                        matTab.label "AntDesign"
                    ]
                    matTab.create [
                        matTab.label "FluentDesign"
                    ]
                ]
            ]
        )
        html.watch (index, function
            | 0 -> demoMudBlazor
            | 1 -> demoMatBlazor
            | 2 -> DemoAntDesign
            | 3 -> demoFluentUI
            | _ -> html.none
        )
    ])