# 关于

![image](../assets/fun-blazor%3D.png)

这个项目旨在让 F# 开发者更轻松地编写 Blazor 应用程序。

其特点包括：

1. 允许使用 F# 进行 Blazor 开发。

2. 使用计算表达式 (CE) 风格 DSL 来支持内部和第三方 Blazor 库。

3. 使用依赖注入 (html.inject/html.comp)。

4. 利用 [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) 模型 (adaptiview/AdaptiveForm) (强烈推荐)，或者 [elmish](https://github.com/elmish/elmish) 模型 (html.elmish)。

5. 实现了 Giraffe 风格的路由 (html.route)。

6. 使用 Fun.Css 提供了类型安全的样式表创建功能。

7. 使用 [Fun.Dev.Tools](https://slaveoftime.github.io/Fun.DevTools.Docs) 将 HTML 转换为 CE 风格。

## 基准测试

|               Method        |       Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------------------- |-----------:|---------:|---------:|-------:|----------:|
|       RenderWithRazorCSharp |   400.3 ns |  6.99 ns |  6.20 ns | 0.0610 |     384 B |
|            RenderWithBolero |   926.1 ns | 17.49 ns | 17.96 ns | 0.2546 |   1,600 B |
|       RenderWithFunBlazorCE |   731.1 ns | 14.07 ns | 21.49 ns | 0.1173 |     736 B |
| RenderWithFunBlazorTemplate | 2,569.9 ns | 42.22 ns | 39.50 ns | 0.6752 |   4,240 B |

## 简单演示这里是一个使用自适应模型的基本计数器：

{{Counter}}

另一个演示使用 html.inject：

{{BlazorStyleComp}}

## 这是怎么工作的？

Fun.Blazor 提供了一系列委托来处理 Blazor。例如，当你写入：

```fsharp
let demo =
    div {
        class' "cool"
    }
```

这段代码实际上会变成：

```fsharp
let demo =
    NodeRenderFragment(fun comp builder index ->  // delegate
        builder.OpenElement(index, "div")
        bulder.AddAttribute(index + 1, "class", "cool")
        builer.CloseElement()
        index + 2
    )

type NodeRenderFragment = delegate of root: IComponent * builder: RenderTreeBuilder * sequence: int -> int
```

本质上，你创建了一个委托，将被传递给一个组件，该组件将管理DOM树的渲染或构建。这种方法类似于Razor引擎在C＃世界中生成的方法。组件可以使用`adaptiview`，`html.inject`等创建。这些组件是普通的Blazor组件，继承自`ComponentBase`。

## 在使用Fun.Blazor之前需要考虑的几件事：

有一些事情需要记住：

1. F＃编译器存在性能问题，在处理一些大型计算表达式（CE）时智能提示功能比较差。最好保持单个CE块和文件的大小较小，或者使用像`seq`，`list`或`array`这样的序列和`childContent`，以获得更好的智能提示。    

    ```fsharp
    div {
        attributes ...
        childContent [ // ✅ recommended for more than one child item
            div { "hi" }
            ...a lot of child items
        ]
    }
    ```

    instead of:

    ```fsharp
    div {
        attributes ...
        div { "hi" }
        ...a lot of child items  ❌
    }
    ```

2. hot-reload

    默认模板提供有限的热重载支持。太多的文件会减慢热重载的速度，因此为了获得最佳效果，请在想要启用热重载的文件顶部添加 `// hot-reload`。有关更多信息，请参见[Fun.Blazor中的热重载](https://www.slaveoftime.fun/blog/d959e36a-f4fe-4a10-88af-5e738633db0f?title=%20Hot-reload%20in%20Fun.Blazor) 博客文章或[文档](https://slaveoftime.github.io/Fun.Blazor.Docs/?doc=/Hot%20Reload)。
    
3. 属性、子项在CE中的位置

    当使用`ref`属性时，应该像这样放置：
    
    ```fsharp
    div {
        attributes ...
        ref (fun x -> ()) // ✅
        childContent [ ... ]
    }
    ```

    或者：
    
    ```fsharp
    div {
        attributes ...
        ref (fun x -> ()) // ✅
        div { 1 }
        div { 1 }
        // ...
    }
    ```
