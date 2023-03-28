# Elmish

**Fun.Blazor.Elmish** 是支持 Elmish 的包。

我知道 Elmish 受到许多 F# 开发者的喜爱，包括我自己。当我开始处理我的第一个 F# 相关任务时，我使用了 Fable+Elmish，然后迁移到 Feliz+Elmish hooks + Recoil，当时我非常享受这个过程。

您可以查看 [官方文档](https://elmish.github.io/elmish/) 了解其核心概念。

{{ElmishDemo}}

在 IComponentHook 下还有一些辅助函数，可以将自适应与 elmish 结合使用，以获得更好的性能在简单应用程序中。因为在自适应数据中，您可以订阅您感兴趣的数据并在实际更改数据片段时触发特定的 UI 部分。与普通的 Elmish 模型不同，您需要调用整个 **视图** 函数来重新渲染整个 DOM 树而不管哪个数据部分发生了变化。

{{AdaptiveElmish}}