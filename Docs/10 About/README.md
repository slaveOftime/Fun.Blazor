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
        div { }
    }
    ```


## Benchmarks

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
