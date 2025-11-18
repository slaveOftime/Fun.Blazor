# Code Generation

```
dotnet tool install -g Fun.Blazor.Cli --version 4.1.1
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

## A demo workthrough

```bash
dotnet new install Fun.Blazor.Templates
dotnet tool install -g Fun.Blazor.Cli --version 4.1.1
```

```bash
dotnet new fun-wasm -o FunWasm
cd FunWasm
```

```bash
dotnet add package MudBlazor
```

Modify the `fsproj` as below:

```text
- <PackageReference Include="MudBlazor" Version="8.14.0" />
+ <PackageReference Include="MudBlazor" Version="8.14.0" FunBlazor="" />
```

```bash
dotnet fun-blazor generate
```

After it is done, you can follow the MudBlazor official document:

For `Startup.fs`:

```text
+ open MudBlazor.Services

+ builder.Services.AddMudServices()
```

For `wwwroot\index.html```

```text
+ <link href="_content/MudBlazor/MudBlazor.min.css" rel="stylesheet" />

+ <script src="_content/MudBlazor/MudBlazor.min.js"></script>
```

Now you can use it in your `App.fs`:

```fsharp
[<AutoOpen>]
module FunWasm.App

open FSharp.Data.Adaptive
open MudBlazor
open Fun.Blazor

let app = fragment {
    MudThemeProvider''
    adapt {
        let amount = 1
        let! count, setCount = cval(1).WithSetter()
        div {
            div { $"Here is the count {count}" }
            MudButton'' {
                Color Color.Primary
                Variant Variant.Filled
                OnClick(fun _ -> setCount (count + amount))
                "Increase by "
                amount
            }
        }
    }
}
```

```bash
dotnet run
```