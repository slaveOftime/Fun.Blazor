[<AutoOpen>]
module Fun.Blazor.Demo.Wasm.DemoAntDesign.ModalDemo

open AntDesign
open Fun.Blazor
open Fun.Blazor.AntDesign


let modalDemo = html.inject (fun (localStore: ILocalStore) ->
    let isDialogOpen = localStore.Create false

    html.div [
        button.create [
            button.childContent "Try to click 😊"
            button.onClick (fun _ -> isDialogOpen.Publish not)
        ]
        html.watch (isDialogOpen, fun isOpen ->
            modal.create [
                modal.title "Demo modal"
                modal.visible isOpen
                modal.onOk (fun _ -> isDialogOpen.Publish not)
                modal.onCancel (fun _ -> isDialogOpen.Publish not)
                modal.childContent [
                    result.create [
                        result.status "success"
                        result.title "Successfully Purchased Cloud Server ECS"
                        result.childContent [
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
