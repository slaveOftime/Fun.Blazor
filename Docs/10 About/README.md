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

1. The F# compiler has performance issues with intellisense for some large computation expressions (CEs). It is better to keep single CE blocks, or use sequences like `array` with `childContent` for better intellisense. [issue tracked in fsharp repo](https://github.com/dotnet/fsharp/issues/14429).

    There are some tests in [here](https://github.com/albertwoo/CEPerfDemo), in summary, below are some recommend ways for better build time performance (but it can reduce runtime performance because we cannot inline and need to allocate memory on head for creating array or list)

    - The best result is **list-with-local-vars** for multiple child items

        ```fsharp
        let demo1 = div {
            class' "font-bold"
            "demo1"
        }

        let demo2 = div {
            class' "font-bold"
            "demo2"
        }

        let comp = div {
            style { color "red" }
            childContent [| // 👌✅
                demo1
                demo2
            |]
        }
        ```

        But you can also write like below even it will not **build** as fast as the above:

        ```fsharp
        let comp = div {
            style { color "red" }
            childContent [| // 👌✅
                div {
                    class' "font-bold"
                    "demo1"
                }
                div {
                    class' "font-bold"
                    "demo2"
                }
            |]
        }
        ```

    - **nested-one** is kind of ok

        ```fsharp
        let comp = div {
            class' "font-bold"
            div { // 👌✅
                class' "font-bold"
                "demo1"
            }
        }
        ```

        but still prefer childContent:

        ```fsharp
        let comp = div {
            class' "font-bold"
            childContet (div { // 👌✅✅
                class' "font-bold"
                "demo1"
            })
        }
        ```


    - **nested-one-one** is not ok (bad for build perf)

        ```fsharp
        let comp = div {
            class' "font-bold"
            div {
                class' "font-bold"
                div { // ⛔🙅
                    class' "font-bold"
                    "demo1"
                }
            }
        }
        ```

        Write like below:

        ```fsharp
        let comp = div {
            class' "font-bold"
            div {
                class' "font-bold"
                childContent [| // 👌✅
                    div { 
                        class' "font-bold"
                        "demo1"
                    }
                |]
            }
        }
        ```

    - inline local vars is not ok (bad for build perf)

        ```fsharp
        let comp = div {
            class' "font-bold"
            let temp = div { // ⛔🙅
                class' "font-bold"
                "demo1"
            }
            temp
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

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

| Method                      | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| RenderWithRazorCSharp       | 237.0 ns |  4.62 ns |  7.46 ns |  1.00 |    0.00 | 0.0296 |     376 B |        1.00 |
| RenderWithFunBlazorInlineCE | 372.5 ns |  7.26 ns |  9.94 ns |  1.58 |    0.07 | 0.0443 |     560 B |        1.49 |
| RenderWithFunBlazorArray    | 518.8 ns | 10.21 ns | 14.64 ns |  2.20 |    0.07 | 0.1154 |    1448 B |        3.85 |
| RenderWithBolero            | 538.5 ns | 10.59 ns | 19.89 ns |  2.27 |    0.10 | 0.1173 |    1480 B |        3.94 |
