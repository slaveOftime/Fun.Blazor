# 热重载 (实验性)

在运行时解释 F# 代码更改（通过 PortaCode），无需重启应用即可更新 UI。当内置的 `dotnet watch` 热重载可用时请优先使用它；仅在需要时使用本功能。

```sh
dotnet tool install --global Fun.Blazor.Cli
```

可以使用预配置热重载的模板创建项目：

```sh
dotnet new --install Fun.Blazor.Templates
```

![image](../../assets/site-hot-reload.gif)

## 使用方法

1. 标记入口点。在组件使用位置进行包装：

    ```fsharp
    #if DEBUG
        html.hotReloadComp(yourComponent, "FullName.yourComponent", "http://localhost:9025")
    #else
        yourComponent
    #endif
    ```

    有多个项目时，为每个项目使用一个入口（并使用不同的端口）以获得更好的性能。

2. 构建并运行您的项目。

3. 在终端中启动监视器（端口需与入口一致）：

    ```sh
    fun-blazor watch "包含入口文件的项目完整路径" --server "http://localhost:9025"
    ```

4. 在浏览器中打开包含 **yourComponent** 的页面——它会连接到监视器。在您想要编辑的文件顶部添加 `// hot-reload`，做出更改并保存，UI 会就地更新。

## 性能

解释器和 F# 编译器服务在多次保存之间复用，因此第一次保存最慢，同一入口的后续保存会快很多（通常几百毫秒）。监视器只重新检查发生更改的文件，并重新计算到入口的依赖链。尽量少标记文件可以让每次保存更快。

## 限制

- 并非所有 F# 表达式都能被解释。但这是可容忍的而非致命的：无法解释的声明会被跳过并在浏览器控制台中报告，之前的渲染会保留在屏幕上。为获得最佳体验，请将复杂逻辑（扩展方法、后端访问等）放在未标记的文件中，只标记布局文件：

    ```
    YourComponent
        Stores.fs
        Hooks.fs          // 扩展方法、后端访问（无需标记）
        Control1.fs       // hot-reload
        Control2.fs       // hot-reload
    ```

- 跨文件组件只要在同一项目中并被入口（传递）引用即可更新。只需在您实际编辑的文件中添加 `// hot-reload`——被编辑文件与入口之间的中间文件会被自动重新计算，无需标记。标记只控制*哪些保存会触发重新编译*。

- 第一次保存较慢（初始检查 + shell 类型生成）；后续保存会复用解释器。

- 仅支持修改现有文件——添加、重命名或删除文件需要重新构建。

- 只有在 `IGlobalStore` 或 `IShareStore` 中创建的状态才会在重载后保留。

> 让我们一起期待 F# 将来能在 dotnet 中实现热重载。
