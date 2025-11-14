# 关于

![image](../assets/fun-blazor%3D.png)

这是一个旨在让 F# 开发者更容易编写 Blazor 应用的项目。

其功能包括：

1. 允许使用 F# 进行 Blazor 开发
2. 使用计算表达式 (CE) 风格的 DSL 用于内部和第三方 Blazor 库
3. 使用依赖注入（html.inject）
4. 利用 [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) 模型（adaptiview/AdaptiveForm）(**推荐**), 或 [elmish](https://github.com/elmish/elmish) 模型 (html.elmish)
5. 实现了 Giraffe 风格的路由 (html.route/blazor 官方风格)
6. 提供了使用 Fun.Css，为CSS编辑真假类型安全
7. 使用 [Fun.Dev.Tools](https://slaveoftime.github.io/Fun.DevTools.Docs) 将 HTML 转换为 CE 风格


## 简单演示

Class 风格的计数器：

{{CounterClassStyle}}

这是一个使用自适应模型的基本计数器：

{{Counter}}

另一个使用 html.inject 的演示：

{{BlazorStyleComp}}

## 这是如何工作的？

Fun.Blazor 为 Blazor 提供了一系列委托进行处理。例如，当您编写：
```fsharp
let demo =
    div {
        class' "cool"
    }
```

这段代码本质上变成了：

```fsharp
let demo =
    NodeRenderFragment(fun comp builder index ->  // 委托
        builder.OpenElement(index, "div")
        bulder.AddAttribute(index + 1, "class", "cool")
        builer.CloseElement()
        index + 2
    )

type NodeRenderFragment = delegate of root: IComponent * builder: RenderTreeBuilder * sequence: int -> int
```

本质上，你已经创建了一个委托，该委托将传递给一个组件，该组件将管理 DOM 树的渲染或构建。这种方法类似于 Razor 引擎在 C# 世界中生成的内容。

可以使用 `adaptiview`、`html.inject` 等创建组件。这些组件是从 `ComponentBase` 继承的普通 Blazor 组件。

## 在使用 Fun.Blazor 之前要考虑以下几点：

1. 不支持热重载

2. 对于组件元素中的属性和子元素，最好按以下方式排列：
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
        div { }
        div { }
        // ...
    }
    ```


## 基准测试

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.7019)
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3 DEBUG
  DefaultJob : .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3

| Method                         | Mean       | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |-----------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| RenderWithRazorCSharp          |   331.6 ns |  6.38 ns | 11.66 ns |  1.00 |    0.05 | 0.0587 |     368 B |        1.00 |
| RenderWithFunBlazorInlineCE ❤️ |   484.2 ns |  9.68 ns |  9.51 ns |  1.46 |    0.06 | 0.0777 |     488 B |        1.33 |
| RenderWithBolero               |   581.2 ns | 11.37 ns | 17.70 ns |  1.75 |    0.08 | 0.1364 |     856 B |        2.33 |
| RenderWithFunBlazorSSRTemplate |   648.5 ns | 17.72 ns | 48.20 ns |  1.96 |    0.16 | 0.0839 |     528 B |        1.43 |
| RenderWithFunBlazorArray       |   671.0 ns | 13.41 ns | 21.27 ns |  2.03 |    0.09 | 0.2174 |    1368 B |        3.72 |
| RenderWithFunBlazorTemplate    | 1,055.6 ns | 20.98 ns | 46.50 ns |  3.19 |    0.18 | 0.2384 |    1496 B |        4.07 |

