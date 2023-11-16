# 热重载

```sh
dotnet tool install --global Fun.Blazor.Cli --version 3.2.0
```

您可以安装一个模板来创建一个配置了热重载的项目：

```sh
dotnet new --install Fun.Blazor.Templates::3.2.0
```

![image](../../assets/site-hot-reload.gif)

## 基本步骤

1. 定义一个入口点

    您可以将一个组件作为入口点，并在组件使用位置替换为以下代码：

    当您有多个项目时，通过为每个项目拥有多个入口点，您可以获得更好的性能。您可以使用最后一个参数来定位不同的 cli watch hosts。

    ```fsharp
    #if DEBUG       
        html.hotReloadComp(yourComponent, "FullNameName.yourComponent", "http://localhost:9025")
    #else
        yourComponent
    #endif
    ```

    因为 [dotnet/fsharp#14250](https://github.com/dotnet/fsharp/issues/14250) 的原因，您需要将以下目标添加到您的项目中：

    ```xml
    <Target Name="ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssemblies"
        BeforeTargets="CoreCompile"
        Condition="'@(ReferencePathWithRefAssemblies)' == ''">
        <ItemGroup>
            <ReferencePathWithRefAssemblies Include="@(ReferencePath)" />
        </ItemGroup>
    </Target>
    ```

2. 构建您的项目并运行。

3. 打开终端并运行：

    ```sh
    fun-blazor watch "包含入口文件的项目完整路径" --server "http://localhost:9025"
    ```

    默认情况下，服务器在9025端口运行，但当您有多个项目时，您可能想要使用不同的端口，并且端口应与您在入口文件中自定义的端口相同。

4. 编辑和保存

    导航到包含 **yourComponent** 的页面。此时，它将连接到 CLI 服务并开始接收更改。

    转到定义 **yourComponent** 的文件，在文件顶部添加 **// hot-reload**，更改任何您想要更改的内容，然后保存即可。您的用户界面应相应地更新。

## 限制

- 入口文件和 **yourComponent** 应该定义在不同的文件中。

- 并非所有的 F# 表达式都能正确解析，因此最好将UI逻辑和UI布局分开到不同的文件中，只在UI布局文件中添加 **// hot-reload**。

  例如，如果您想要添加一个扩展方法到IComponentHook以访问后台服务器，可以将其分离到一个新文件中。

  文件结构可能如下：

  ```
  YourComponent
      Stores.fs
      Hooks.fs
      Control1.fs // hot-reload
      Control2.fs // hot-reload
  ```

- 第一次保存需要更长的时间。

- 要让其他定义在不同文件中的组件能够进行热重载：

  - 这些组件必须定义在同一项目中。
  - 这些组件必须被 **yourComponent** 直接引用。
  - 您还需要在包含组件的文件中添加 **// hot-reload**。

- 由于性能问题，不应该将太多的文件启用热重载。

- 它不支持添加新文件、重命名文件或其他类似的操作。只支持修改现有文件。

- 只有在 IGlobalStore 或 IShareStore 中创建的状态才会被保留。


> 让我们一起期待F#将来能在dotnet中实现热重载。
