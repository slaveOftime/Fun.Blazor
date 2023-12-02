# Code Generation

```
dotnet tool install -g Fun.Blazor.Cli --version 3.2.0
```

Generate CE DSL for a **package** or **project**.

## Steps:

1. Add any third-party Blazor components like MudBlazor to your application.

    `FunBlazor`
        
    Add this empty attribute to the line below in your project file, and you will get the default generating settings. It generates code in the namespace of the package name (MudBlazor), with computation expression style. No need for this if you have any attribute that starts with `FunBlazor`.

    ```
    <PackageReference FunBlazor="" Include="MudBlazor" Version="6.0.6" />
    ```

    For the project, it is similar:

    ```
    <ProjectReference FunBlazor="" Include="..\CSharpComponents\CSharpComponents.csproj" />
    ```
    
    `FunBlazorNamespace`
    
    Give a namespace to the generated code.

    `FunBlazorAssemblyName`
    
    Sometimes the assembly name is different from the package name, so you can use this to specify it.

    `FunBlazorInline`
    
    Inline to improve performance but may increase bundle size, turned on by default. This will also override the settings in the command line.
   

2. Run the command:

    ```
    fun-blazor generate ./YourApplication.fsproj
    ```

    By default, code will be generated in the `Fun.Blazor.Bindings` folder.

    `-o|--outDir`: Customize the generated folder name.


3. Enjoy it.

    CE style (You need to set the LangVersion to preview for your project if you are using dotnet 5 because CustomOperation override is in preview):

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