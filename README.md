# Fun.Blazor [![Nuget](https://img.shields.io/nuget/v/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine)

[WASM docs](https://github.com/slaveOftime/Fun.Blazor)


## Fun.Blazor

```
dotnet add package Fun.Blazor
```

```
services.AddFunBlazor()
```

Then you are good to go:

```fsharp
open AntDesign
open Fun.Blazor
open Fun.Blazor.AntDesign

let antDesignDemo = html.inject (fun (localStore: ILocalStore) ->
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
                modal.childContent [
                    result.create [
                        result.status "success"
                        result.title "Successfully Purchased Cloud Server ECS"
                        result.children [
                            alert.create [
                                alert.``type`` AlertType.Success
                                alert.message "Success"
                            ]
                        ]
                    ]
                ]
            ]
        )
    ])
```

There are couple of helper functions you may need

1. FunBlazorNode can be easily convert to Bolero node to combine with exsiting Bolero application

    ```fsharp
    antDesignDemo.ToBoleroNode()
    // Or
    antDesignDemo |> html.toBoleroNode
    ```

2. You can inject any services by html.inject

    ```fsharp
    let antDesignDemo = html.inject (fun (localStore: ILocalStore) ->
        let isDialogOpen = localStore.Create false
    ```

3. You can inject ILocalStore, IShareStore, IComponentHook to manage state and component lifecycle event

4. You can watch some IObervable or IStore for some component

    ```fsharp
    html.watch (isDialogOpen, fun isOpen ->
        modal.modal [
            modal.title "Demo modal"
            modal.visible isOpen
    ```

    Then you can use isDialogOpen.Publish to change its state at anytime
