[<AutoOpen>]
module Fun.Blazor.Docs.Wasm.DemoAntDesign.ModalDemo

open FSharp.Data.Adaptive
open Fun.Blazor
open AntDesign

let modalDemo = html.inject (fun (hook: IComponentHook) ->
    let isDialogOpen = hook.UseStore false
    let number1 = hook.UseStore 100
    let number2 = cval 100

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
                            inputGroup.create [
                                inputNumber<int>.create [
                                    inputNumber.min 100
                                    inputNumber.max 150
                                    inputNumber.value' number1
                                ]
                                adaptiview(){
                                    let! _ = number2
                                    inputNumber<int>.create [
                                        inputNumber.min 100
                                        inputNumber.max 150
                                        inputNumber.value' number2
                                    ]
                                }
                            ]
                            button.create [
                                button.childContent "Increase"
                                button.onClick (fun _ ->
                                    number1.Publish ((+) 1)
                                    number2.Publish ((+) 2))
                            ]
                        ]
                    ]
                    calendar.create [
                        calendar.monthCellRender (fun d -> html.text $"My {d.Month}")
                    ]
                ]
                ]
        )
    ])
