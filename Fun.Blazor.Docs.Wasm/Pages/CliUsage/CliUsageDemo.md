```
dotnet tool install -g Fun.Blazor.Cli
dotnet add package Fun.Blazor.Feliz
```

Steps:

1. Add any third party blazor components like AntDesign to your application and build in debug mode or restore it to pull the nuget packages

    `FunBlazor`
        
        Add this empty attribute to below line in your project file you will get the default generating settings
        Will generate code in namespace of the package name (AntDesign), with computation expression style

   ```
    <PackageReference FunBlazor="" Include="AntDesign" Version="0.8.2" />
   ```

   `FunBlazorNamespace`: Give namespace
   
   `FunBlazorStyle`: Feliz | CE, this will override the settings in the commandline
   

2. Run the command

    ```
    fun-blazor generate ./YourApplication.fsproj
    ```

    By default, code will be generated in the `Fun.Blazor.Bindings` folder. All the binding types are in lowercase

    `-o|--outDir`: Customize the generated folder name

    `-s|--style`: Customize the style (Feliz | CE)


3. Enjoy it

    CE style (You need set LangVersion to preview for your project, because CustomOperation override is in preview):

    ```fsharp
    open Fun.Blazor
    open MudBlazor

    let alertDemo =
        MudCard' [
            MudAlert' {
                Icon Icons.Filled.AccessAlarm
                "This is the way"
            }
        ]
    ```

    Feliz style

    ```fsharp
    open Fun.Blazor
    open MudBlazor

    let alertDemo =
        mudCard.create [
            mudAlert.create [
                mudAlert.icon Icons.Filled.AccessAlarm
                mudAlert."This is the way"
            ]
        ]
    ```
