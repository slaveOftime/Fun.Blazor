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

| Method                      | Mean     | Error   | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|---------------------------- |---------:|--------:|---------:|------:|--------:|-------:|----------:|------------:|
| RenderWithRazorCSharp       | 234.1 ns | 3.59 ns |  3.36 ns |  1.00 |    0.00 | 0.0298 |     376 B |        1.00 |
| RenderWithFunBlazorInlineCE | 363.5 ns | 4.14 ns |  3.67 ns |  1.55 |    0.03 | 0.0443 |     560 B |        1.49 |
| RenderWithFunBlazorArray    | 499.0 ns | 9.82 ns | 10.91 ns |  2.14 |    0.05 | 0.1154 |    1448 B |        3.85 |
| RenderWithBolero            | 507.9 ns | 9.74 ns | 11.21 ns |  2.17 |    0.07 | 0.1173 |    1480 B |        3.94 |
