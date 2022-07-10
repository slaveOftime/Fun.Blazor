# Cli

```
dotnet tool install -g Fun.Blazor.Cli
```

Steps:

1. Add any third party blazor components like MudBlazor to your application

    `FunBlazor`
        
        Add this empty attribute to below line in your project file you will get the default generating settings
        Will generate code in namespace of the package name (MudBlazor), with computation expression style
        No need this if you have any attribute which start with FunBlazor

    ```
    <PackageReference FunBlazor="" Include="MudBlazor" Version="6.0.6" />
    ```

    `FunBlazorNamespace`: Give namespace

    `FunBlazorAssemblyName`: Sometimes the assembly name is different with the package name, so you can use this to specify it
        
    `FunBlazorStyle`: CE, this will override the settings in the commandline

    `FunBlazorInline`: Inline to improve performance but may increase bundle size, turned on by default. This will override the settings in the commandline
   

2. Run the command

    ```
    fun-blazor generate ./YourApplication.fsproj
    ```

    By default, code will be generated in the `Fun.Blazor.Bindings` folder.

    `-o|--outDir`: Customize the generated folder name

    `-s|--style`: Customize the style (CE)


3. Enjoy it

    CE style (You need set LangVersion to preview for your project if you are using dotnet 5, because CustomOperation override is in preview):

    ```fsharp
    open Fun.Blazor
    open MudBlazor

    let alertDemo =
        MudCard' [
            MudAlert'() {
                Icon Icons.Filled.AccessAlarm
                childContent "This is the way"
            }
        ]
    ```
