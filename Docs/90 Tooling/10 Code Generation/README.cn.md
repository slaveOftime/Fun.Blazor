# 代码生成

```
dotnet tool install -g Fun.Blazor.Cli --version 3.2.0
```

为一个**包**或**项目**生成 CE DSL。

## 步骤：

1. 将第三方 Blazor 组件，如 MudBlazor，添加到您的应用程序中。

    `FunBlazor`
    
    在您的项目文件中，在下面一行中加入这个空的属性，您将得到默认的生成设置。它会在包名称 (MudBlazor) 的名称空间中生成代码，使用计算表达式样式。如果您拥有任何以 `FunBlazor` 开头的属性，则不需要这个。

    ```
        <PackageReference FunBlazor="" Include="MudBlazor" Version="6.0.6" />
    ```

    对于项目也是类似的：

    ```
    <ProjectReference FunBlazor="" Include="..\CSharpComponents\CSharpComponents.csproj" />
    ```
    
    `FunBlazorNamespace`
    
    为生成的代码提供一个命名空间。

    `FunBlazorAssemblyName`
    
    有时程序集名称不同于包名称，因此您可以使用此名称指定程序集名称。

    `FunBlazorInline`
    
    内联以提高性能，但可能会增加包大小，它默认开启。这也将覆盖命令行中的设置。

2. 运行命令：

    ```
    fun-blazor generate ./YourApplication.fsproj
    ```

    默认情况下，代码将生成在 `Fun.Blazor.Bindings` 文件夹中。

    `-o|--outDir`: 自定义生成的文件夹名称。


3. 尽情使用吧。

    CE 样式 (如果您正在使用 dotnet 5，您需要为您的项目设置 LangVersion 为 preview，因为 CustomOperation 覆盖是预览状态)：

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