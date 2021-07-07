[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.ModalDemo

open Fun.Blazor
open Fun.Blazor.DslCE
open AntDesign

let modalDemo = html.inject (fun (hook: IComponentHook) ->
    let isDialogOpen = hook.UseStore false

    html.div [
        button.create [
            button.childContent "Try to click 😊"
            button.onClick (fun _ -> isDialogOpen.Publish not)
        ]
        watch {
            Store isDialogOpen.Observable
            RenderFn (fun isOpen ->
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
                                inputGroup.create [
                                    inputNumber<int>.create [
                                        inputNumber.min 100
                                        inputNumber.max 150
                                        inputNumber.value 123
                                    ]
                                ]
                            ]
                        ]
                    ]
                 ]
            )
        }
    ])
