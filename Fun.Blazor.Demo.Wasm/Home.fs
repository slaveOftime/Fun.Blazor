[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.Home

open Fun.Blazor
open Fun.Blazor.MatBlazor
open Fun.Blazor.Demo.Wasm.MudBlazorDemo
open Fun.Blazor.Demo.Wasm.MatBlazorDemo
open Fun.Blazor.Demo.Wasm.AntDesignDemo
open Fun.Blazor.Demo.Wasm.FluentUIDemo


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
            | 0 -> mudBlazorDemo
            | 1 -> matBlazorDemo
            | 2 -> antDesignDemo
            | 3 -> fluentUIDemo
            | _ -> html.none
        )
    ])