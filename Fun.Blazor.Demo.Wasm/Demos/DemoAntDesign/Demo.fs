[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoAntDesign.Demo

open AntDesign
open Fun.Blazor
open Fun.Blazor.AntDesign


let DemoAntDesign = html.inject (fun (localStore: ILocalStore) ->
    let isDialogOpen = localStore.Create false

    html.div [
        button.create [
            button.children "Open modal"
            button.onClick (fun _ -> isDialogOpen.Publish not)
        ]
        html.watch (isDialogOpen, fun isOpen ->
            modal.create [
                modal.title "Demo modal"
                modal.visible isOpen
                modal.onOk (fun _ -> isDialogOpen.Publish not)
                modal.onCancel (fun _ -> isDialogOpen.Publish not)
                modal.children [
                    result.create [
                        result.status "success"
                        result.title "Successfully Purchased Cloud Server ECS"
                        result.children [
                            alert.create [
                                alert.type' AlertType.Success
                                alert.message "Success"
                            ]
                        ]
                    ]
                ]
            ]
        )
    ])
