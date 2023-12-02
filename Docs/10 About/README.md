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

1. The F# compiler has performance issues with intellisense for some large computation expressions (CEs). It is better to keep single CE blocks and files small, or use sequences like `seq`, `list`, or `array` with `childContent` for better intellisense:

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

2. Hot-reload

   The default templates provide limited hot-reload support. Too many files can slow down the hot-reload process, so for best results, add `// hot-reload` at the top of files you want to enable hot-reload for. For more information, see the [Hot-reload in Fun.Blazor](https://www.slaveoftime.fun/blog/d959e36a-f4fe-4a10-88af-5e738633db0f?title=%20Hot-reload%20in%20Fun.Blazor) blog post or [document](https://slaveoftime.github.io/Fun.Blazor.Docs/?doc=/Hot%20Reload).

3. Attribute, items position in CE

    When using a `ref` or `renderMode` attribute etc., you should place it like below, because blazor treat them very special and can only add them after other attributes:

    ```fsharp
    div {
        attributes ...
        ref (fun x -> ()) // ✅
        childContent [ ... ]
    }
    ```

    Or:

    ```fsharp
    div {
        attributes ...
        ref (fun x -> ()) // ✅
        div { 1 }
        div { 1 }
        // ...
    }
    ```


## Benchmarks

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2

| Method                | Mean     | Error    | StdDev    | Median   | Gen0   | Allocated |
|---------------------- |---------:|---------:|----------:|---------:|-------:|----------:|
| RenderWithRazorCSharp | 580.4 ns | 24.14 ns |  70.41 ns | 566.4 ns | 0.0935 |     392 B |
| RenderWithFunBlazorCE | 677.9 ns | 11.49 ns |  18.23 ns | 675.5 ns | 0.1774 |     744 B |
| RenderWithBolero      | 905.4 ns | 34.92 ns | 102.95 ns | 872.0 ns | 0.3567 |    1496 B |
