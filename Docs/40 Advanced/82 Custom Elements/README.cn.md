# 自定义元素

您需要安装 **Fun.Blazor.CustomElements**。

我创建了这个功能，因为在某些用例中，我只想让 ASP.NET Core 使用 Fun.Blazor 来预渲染静态内容，而不连接到 Blazor 服务器。但是对于某些页面或组件，我希望临时连接到 Blazor 服务器。因此，我仍然可以使用 Blazor 并使用单个 WebSocket 隐藏后端 API 进行交互。

它是由 **Microsoft.AspNetCore.Components.CustomElements** 驱动的，这在 .NET 7 中得到了官方支持。

下面有一些计数器，但它们共享同一个 `IShareStore`。所以在 Blazor 服务器模式下，当您单击一个按钮时，另一个按钮也会自动增加，这意味着它们共享同一个 WebSocket 连接。

{{CustomElementDemo}}