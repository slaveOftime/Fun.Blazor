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

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| RenderWithRazorCSharp          | 247.7 ns |  3.80 ns |  3.37 ns |  1.00 |    0.02 | 0.0291 |     368 B |        1.00 |
| RenderWithFunBlazorInlineCE    | 374.1 ns |  5.53 ns |  4.91 ns |  1.51 |    0.03 | 0.0439 |     552 B |        1.50 |
| RenderWithFunBlazorSSRTemplate | 475.6 ns |  5.78 ns |  5.40 ns |  1.92 |    0.03 | 0.0420 |     528 B |        1.43 |
| RenderWithBolero               | 497.9 ns |  8.46 ns | 10.07 ns |  2.01 |    0.05 | 0.1192 |    1496 B |        4.07 |
| RenderWithFunBlazorArray       | 525.2 ns | 10.44 ns | 11.17 ns |  2.12 |    0.05 | 0.1144 |    1440 B |        3.91 |
| RenderWithFunBlazorTemplate    | 785.9 ns |  7.95 ns |  7.44 ns |  3.17 |    0.05 | 0.1240 |    1560 B |        4.24 |
