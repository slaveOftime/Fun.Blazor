# 如何贡献

如果你想为源代码做出贡献，只需创建一个 PR 并在 @ 后面提到我，我会尽快审核。

如果你想为文档做出贡献（也非常欢迎，因为我的英语不是很好，所以我的文档可能不太易读），这里有一些约定：

- 所有文档都位于 **Docs** 下。它们只是 markdown 文件，所以您可以相应地进行更改。

- markdown 文件的第一行应该是这样的：**# 你的主题**。

- 每个主题文件夹前都有一个数字；这用于对最终菜单进行排序。

- 在每个文件夹下，都有一个 **README.md** 文件，这是主题的主入口点。

- 如果你的主题有很多内容，你可以创建子目录和另一个 **README.md** 文件，以创建更好地内容组织的 **树**。

- 你也可以包含一些实时演示。要这样做，你只需添加这个：**{{Fun.Blazor.Docs.Wasm/Demos下的演示名称}}**。可以以 **Counter** 为例：

{{Counter}}

- 你也可以通过以下方式在本地测试文档：

   a. 更改文档。
   
   b. 在存储库的根目录下，运行：dotnet fsi build.fsx -- -p docs。
   
   c. 运行：dotnet run --project .\Fun.Blazor.Docs.Server\Fun.Blazor.Docs.Server.fsproj。

- 要编写演示组件，必须创建类似以下内容的代码:

    ```fsharp
    // 命名空间名必须完全相同
    module Fun.Blazor.Docs.Wasm.Demos.DemoName

    open Fun.Blazor

    // 必须以不带参数的名为 entry 的方式进行调用
    let entry = div { "hi" }
    ```