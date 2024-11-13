# About

![image](../assets/fun-blazor%3D.png)

This is a project aimed at making it easier for F# developers to write Blazor applications.

Features include:

1. Allows F# for Blazor development
2. Use computation expression (CE) style DSL for internal and third-party Blazor libraries
3. Use dependency injection with function style html.inject
4. Leverages the [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) model (adaptiview/AdaptiveForm) (**highly recommended**), or the [elmish](https://github.com/elmish/elmish) model (html.elmish)
5. Implements Giraffe-style routing (html.route)
6. Provides type-safe stylesheet creation using Fun.Css
7. Converts HTML to CE style with [Fun.Dev.Tools](https://slaveoftime.github.io/Fun.DevTools.Docs)
8. All the official blazor stuff works the same way


## Simple demo

Basic counter in class style:

{{CounterClassStyle}}

Basic counter that uses an adaptive model:

{{Counter}}

Basic counter that uses html.inject:

{{BlazorStyleComp}}

## How does this work?

Fun.Blazor provides a series of delegates for Blazor to handle. For example, when you write:

```fsharp
let demo =
    div {
        class' "cool"
    }
```

This code essentially becomes:

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

In essence, you have created a delegate that will be passed to a component, which will manage the rendering or building of the DOM tree. This approach is similar to what the Razor engine would generate in the C# world.

Components can be created using `adaptiview`, `html.inject`, etc. These components are normal Blazor components that inherit from `ComponentBase`.

## Considerations before using Fun.Blazor:

There are a few things to keep in mind:

1. No support for hot-reload

   The default templates provide limited hot-reload support. Too many files can slow down the hot-reload process, so for best results, add `// hot-reload` at the top of files you want to enable hot-reload for. For more information, see the [Hot-reload in Fun.Blazor](https://www.slaveoftime.fun/blog/d959e36a-f4fe-4a10-88af-5e738633db0f?title=%20Hot-reload%20in%20Fun.Blazor) blog post or [document](https://slaveoftime.github.io/Fun.Blazor.Docs/?doc=/Hot%20Reload).

2. Attribute, items position in CE

    When using a `ref` or `renderMode` attribute etc., you should place it like below, because blazor treat them very special and can only add them after other attributes:

    ```fsharp
    div {
        attributes ...
        ref (fun x -> ()) // ✅
        childContent [| ... |]
    }
    ```

    Or:

    ```fsharp
    div {
        attributes ...
        ref (fun x -> ()) // ✅
        div { 1 }
    }
    ```


## Benchmarks

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
