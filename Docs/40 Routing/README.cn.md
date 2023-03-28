# 路由

在 Fun.Blazor 中，我们内置了路由支持，但你也可以使用自己的路由。内置路由非常简单，受 [Giraffe](https://github.com/giraffe-fsharp/Giraffe) 的启发。

在底层，我们会创建一个组件来监听路由变化并内部使用自适应模型，因此如果实际路径未更改，则 UI 不会重新渲染。

我们还支持一些辅助函数，如 **routeCi "/demo" demoView**。它只是一个函数：`UrlString -> 'T option`。因此，如果返回值有内容，则会返回该内容。它可以只是一个视图片段或其他任何东西。

以下面的代码为例：

{{GiraffeStyleRouter}}