[<AutoOpen>]
module Fun.Blazor.Demo.AntDesignDemo

open AntDesign
open Fun.Blazor
open Fun.Blazor.AntDesign


let antDesignDemo = html.inject (fun (localStore: ILocalStore) ->
    let isDialogOpen = localStore.Create false

    html.div [
        button.button [
            button.children "Open modal"
            button.onClick (fun _ -> isDialogOpen.Publish not)
        ]
        html.watch (isDialogOpen, fun isOpen ->
            modal.modal [
                modal.title "Demo modal"
                modal.visible isOpen
                modal.onOk (fun _ -> isDialogOpen.Publish not)
                modal.onCancel (fun _ -> isDialogOpen.Publish not)
                modal.children [
                    result.result [
                        result.status "success"
                        result.title "Successfully Purchased Cloud Server ECS"
                        result.children [
                            alert.alert [
                                alert.``type`` AlertType.Success
                                alert.message "Success"
                            ]
                        ]
                    ]
                ]
            ]
        )
    ])
