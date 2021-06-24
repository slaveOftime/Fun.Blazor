```
dotnet tool install -g Fun.Blazor.Cli
```

Steps:

1. Add any third party blazor components like AntDesign to your application and build in debug mode to pull the nuget packages

   Add attribute `FunBlazorNamespace` to give a namespace

   If you set it to empty like FunBlazorNamespace="" then it will use the Pakage name which is set in the Include attribute.

   ```
    <PackageReference FunBlazorNamespace="Fun.Blazor.AntDesign" Include="AntDesign" Version="0.8.2" />
   ```

2. Run the command

    ```
    fun-blazor generate ./YourApplication.fsproj
    ```

    By default, code will be generated in the `Fun.Blazor.Bindings` folder. All the binding types are in lowercase

3. Enjoy it

    ```fsharp
    open MudBlazor
    open Fun.Blazor
    open Fun.Blazor.MudBlazor

    let alertDemo =
        mudCard.create [
            mudAlert.create [
                mudAlert.icon Icons.Filled.AccessAlarm
                mudAlert.childContent "This is the way"
            ]
        ]
    ```
