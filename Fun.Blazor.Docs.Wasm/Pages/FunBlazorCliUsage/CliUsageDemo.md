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

Tips:

1. There is a `create` method for all the generated components bindings

2. Generic type safe

    ```fsharp
    matCheckbox<bool>.create [
        matCheckbox.label "Check a go"
        matCheckbox.value isMenuOpen
    ]
    ```

3. Use basic dom attribute with generated component

    ```fsharp
    matDrawer.create [
        !!(evt.click (fun _ -> isMenuOpen.Publish not))
        // Or
        evt.click (fun _ -> isMenuOpen.Publish not) |> genericFunBlazor
    ```    
