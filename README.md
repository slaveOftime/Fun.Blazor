# Fun.Blazor [![Nuget](https://img.shields.io/nuget/v/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine)


## Table of contents

- [Getting Started](#Fun.Blazor)
- [Use third party blazor components](Fun.Blazor.Cli)


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


## Fun.Blazor.Cli

```
dotnet tool install -g Fun.Blazor.Cli
```

Steps:

1. Add any third party blazor components like AntDesign to your application and build in debug mode to pull the nuget packages

   Add attribute `FunBlazorNamespace` to give a namespace

   ```
    <PackageReference FunBlazorNamespace="Fun.Blazor.AntDesign" Include="AntDesign" Version="0.8.2" />
   ```

2. Run the command

    ```
    fun-blazor generate ./YourApplication.fsproj
    ```

    By default code will generated in the `Fun.Blazor.Bindings` folder. All the binding types are in lowercase

    ```fsharp
    modal.visible isOpen
    ```

3. Enjoy it

    ```fsharp
    open Fun.Blazor.AntDesign
    ```
