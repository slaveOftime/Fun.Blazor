[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.ModalDemo

open Fun.Blazor
open Fun.Blazor.DslCE
open AntDesign

let modalDemo = html.inject (fun (hook: IComponentHook) ->
    let isDialogOpen = hook.UseStore false

    html.div [
        Button'() {
            ChildContent "Try to click 😊"
            OnClick (fun _ -> isDialogOpen.Publish not)
        }
        watch {
            Store isDialogOpen.Observable
            RenderFn (fun isOpen ->
                Modal'() {
                    Title "Demo modal"
                    Visible isOpen
                    OnOk (fun _ -> isDialogOpen.Publish not)
                    OnCancel (fun _ -> isDialogOpen.Publish not)
                    ChildContent [
                        Result'() {
                            Status "success"
                            Title "Successfully Purchased Cloud Server ECS"
                            ChildContent [
                                Alert'() {
                                    Type AlertType.Success
                                    Message "Success"
                                }
                                InputGroup'.create [
                                    InputNumber'<int>() {
                                        Min 100
                                        Max 150
                                        attrs [ attr.custom ("label", "Number") ]
                                    }
                                ]
                            ]
                        }
                    ]
                }
            )
        }
    ])
