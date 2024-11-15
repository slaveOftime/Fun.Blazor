# 关于

Adaptive 基于 [FSharp.Data.Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive)。在 Fun.Blazor 中，我们只使用了其功能中很小的一部分 **ChangableValue**，而结果已经很好了。关于其核心概念，您可以查看他们的文档。

在 Fun.Blazor 中，我们用它来隔离动态的 UI 部分。因为大多数情况下，您的数据更改只会影响整个 UI 的特定部分。所以你可以定义如下的内容：

```fsharp
let yourUI =
    div {
        style { ... }
        ... 很多东西
        adapt {
            let! msg = from store
            // 只有下面的部分会重新渲染。
            div {
                style { ... }
                msg
            }
        } 
        ... 很多东西
    }
```

请记住，自适应模型是可选的。如果你不喜欢它，你可以使用自己的模型。

您可能会注意到，您也可以执行以下操作，并且从另一个角度来看，它可能看起来更整洁。但是 **DisableEventTriggerStateHasChanged** 默认情况下是开启的。原因是为了减少虚拟 DOM 的计算量。使用 **adaptiview**，我们可以将 DOM 缩小到特定部分，以一种隔离的方式重新计算 DOM。如果您查看 **Form** 文档，您会发现它经常使用这种模式。有了它，我们可以更好地处理大型 UI DOM 树的性能。 

{{BlazorStyleComp}}

而 **adaptiview** 也可以接受像 `isStatic/key` 这样的参数。有了这个，即使您重新调用 `yourUI`，它也不会影响隔离的部分。

{{AdaptiviewDemo}}

{{AdaptiviewMathDemo}}