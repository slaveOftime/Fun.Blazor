# Fun.Blazor [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

![image](./Docs//assets/fun-blazor%3D.png)

This is a project to make F# developer to write blazor easier.

1. Use F# ❤️😊 for blazor
2. Computation expression (CE) style DSL for internal and third party blazor libraries
3. Dependency injection (html.inject)
4. [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) model (adaptiview/AdaptivieForm) (**recommend**), [elmish](https://github.com/elmish/elmish) model (html.elmish)
5. Giraffe style routing (html.route/blazor official style)
6. Type safe style (Fun.Css)
7. Convert html to CE style by [Fun.Dev.Tools](https://slaveoftime.github.io/Fun.DevTools.Docs)

Check the [WASM Docs](https://slaveoftime.github.io/Fun.Blazor.Docs/) for more 🚀

## Start to use

    dotnet new install Fun.Blazor.Templates::3.2.0
    dotnet new fun-blazor -o FunBlazorDemo1

> Requires dotnet 8

## Code samples

```fsharp
// Functional style
let demo (str) = fragment {
    h2 { $"demo {str}" }
    p { "hi here" }
}

// Class style
type Foo() =
    inherit FunComponent()

    let mutable count = 0

    override _.Render() = main {
        h1 { "foo" }
        demo $"hi {count}"
        button {
            on.click (fun _ -> count <- count + 1)
            "Click me"
        }
    }
```

## CE build performance

- There is CE performance [issue](https://github.com/dotnet/fsharp/issues/14429) for inline or nest too much CE block.

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

- **nested-one** is ok

```fsharp
let comp = div {
    class' "font-bold"
    div { // 👌✅
        class' "font-bold"
        div { "demo1" }
    }
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
            div { "demo1" }
        }
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

## Local development

You can run **dotnet fsi build.fsx -- -h** to check what is available to help you get started.

## Benchmark

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3007/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2


| Method                      | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| RenderWithRazorCSharp       | 235.1 ns |  3.50 ns |  3.27 ns |  1.00 |    0.00 | 0.0296 |     376 B |        1.00 |
| RenderWithFunBlazorInlineCE | 426.7 ns |  5.13 ns |  4.80 ns |  1.82 |    0.04 | 0.0577 |     728 B |        1.94 |
| RenderWithBolero            | 533.4 ns |  8.54 ns |  7.57 ns |  2.27 |    0.05 | 0.1173 |    1480 B |        3.94 |
| RenderWithFunBlazorArray    | 650.6 ns | 12.18 ns | 11.39 ns |  2.77 |    0.08 | 0.1478 |    1856 B |        4.94 |
