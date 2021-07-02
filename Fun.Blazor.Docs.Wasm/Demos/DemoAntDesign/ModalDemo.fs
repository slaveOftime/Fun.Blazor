[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.ModalDemo

open Fun.Blazor
open Fun.Blazor.DslCE
open AntDesign

let modalDemo = html.inject (fun (hook: IComponentHook) ->
    let isDialogOpen = hook.UseStore false

    html.div [
        button() {
            childContentStr "Try to click 😊"
            onClick (fun _ -> isDialogOpen.Publish not)
            CAST
        }
        watch {
            Store isDialogOpen.Observable
            RenderFn (fun isOpen ->
                modal() {
                    title "Demo modal"
                    visible isOpen
                    onOk (fun _ -> isDialogOpen.Publish not)
                    onCancel (fun _ -> isDialogOpen.Publish not)
                    childContent [
                        result() {
                            status "success"
                            title "Successfully Purchased Cloud Server ECS"
                            childContent [
                                alert() {
                                    type' AlertType.Success
                                    message "Success"
                                }
                                inputGroup [
                                    inputNumber<int>() {
                                        min' 100
                                        max' 150
                                        label "Number"
                                        CAST
                                    }
                                ]
                            ]
                        }
                    ]
                    CAST
                }
            )
            CAST
        }
    ])
