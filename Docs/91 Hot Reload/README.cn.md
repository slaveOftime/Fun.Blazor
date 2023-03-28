# 热重载

```sh
dotnet tool install --global Fun.Blazor.Cli --version 2.0.0
```

你可以安装一个模板来创建一个设置了热重载的项目：

```sh
dotnet new --install Fun.Blazor.Templates::2.0.0
```

![image](../assets/site-hot-reload.gif)

## 基本步骤

1. 定义入口点

你可以选择一个组件作为入口点，并在组件使用位置替换它为以下代码：

```fsharp
#if DEBUG               
    html.hotReloadComp(yourComponent, "FullNameName.yourComponent", "http://localhost:9025")
#else        
    yourComponent
#endif    
```

当你有多个项目时，你可以为每个项目设置多个入口点，从而获得更好的性能。你可以使用最后一个参数来定位不同的 cli watch hosts。
由于 [dotnet/fsharp#14250](https://github.com/dotnet/fsharp/issues/14250)，您需要将以下目标添加到您的项目中： 

```xml 
<Target Name="ShimReferencePathsWhenCommonTargetsDoesNotUnderstandReferenceAssemblies" 
        BeforeTargets="CoreCompile" 
        Condition="'@(ReferencePathWithRefAssemblies)' == ''"> 
    <ItemGroup> 
        <ReferencePathWithRefAssemblies Include="@(ReferencePath)" /> 
    </ItemGroup> 
</Target> 
```
2. 构建并运行您的项目。

3. 打开终端并运行：

```sh 
fun-blazor watch "包含入口文件的项目的完整路径" --server "http://localhost:9025"
```

默认情况下，服务器运行在9025端口，但是当您有多个项目时，您可能希望使用不同的端口，而且端口应该与您在入口文件中自定义的端口相同。 

4. 编辑和保存

导航到在浏览器上包含**yourComponent**的页面。 此时，它将连接到CLI主机并开始接收更改。 
转到定义**yourComponent**的文件，将**// hot-reload**添加到文件的顶部，更改任何你想要的内容，然后保存。您的UI应该相应地更新。

## 限制

- 入口文件和 **yourComponent** 应该在不同的文件中定义。

- 并非所有的 F# 表达式都能够被正确解析，因此最好将 UI 逻辑和 UI 布局分开到不同的文件中，并只将 **// hot-reload** 添加到 UI 布局文件中。例如，如果要添加一个扩展方法到 IComponentHook 来访问后端服务器，可以将其分离到一个新文件中。

文件结构可能像这样：

```
YourComponent
    Stores.fs
    Hooks.fs
    Control1.fs // hot-reload
    Control2.fs // hot-reload
```

- 第一次保存需要更多时间。

- 要使在其他文件中定义的组件能够热重载：

  - 这些组件必须在同一个项目中定义。
  - 这些组件必须由 **yourComponent** 直接引用。
  - 你还需要在包含这些组件的文件中添加 **// hot-reload**。

- 由于性能问题，不应该启用过多文件进行热重载。

- 它不支持添加新文件、重命名文件或其他类似操作。只支持修改现有文件。

- 只保留在 IGlobalStore 或 IShareStore 中创建的状态。


> 让我们祈祷 F# 将来能够在 .NET 上实现热重载。
