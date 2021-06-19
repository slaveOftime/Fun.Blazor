[<AutoOpen>]
module Fun.Blazor.Demo.Home

open Fun.Blazor
open Fun.Blazor.MatBlazor


let home = html.inject (fun (localStore: ILocalStore) ->
    let index = localStore.Create 0
    
    html.div [
        html.watch (index, fun d ->
            matTabGroup.create [
                matTabGroup.activeIndex d
                matTabGroup.activeIndexChanged index.Publish
                matTabGroup.children [
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
            | 0 -> matBlazorDemo
            | 1 -> antDesignDemo
            | 2 -> fluentUIDemo
            | _ -> html.none
        )
    ])