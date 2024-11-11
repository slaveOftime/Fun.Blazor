# Fun.Blazor [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

![image](./Docs//assets/fun-blazor%3D.png)

This is a project to make F# developer to write blazor easier.

1. Use F# ❤️😊 for blazor
2. Computation expression (CE) style DSL for internal and third party blazor libraries
3. Dependency injection (html.inject)
4. [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) model (adaptiview/AdaptivieForm) (**recommend**), [elmish](https://github.com/elmish/elmish) model (html.elmish)
5. Giraffe style routing (html.route/blazor official style)
6. Type safe css style (Fun.Css)
7. Convert html to CE style by [Fun.Dev.Tools](https://slaveoftime.github.io/Fun.DevTools.Docs)

Check the [WASM Docs](https://slaveoftime.github.io/Fun.Blazor.Docs/) for more 🚀

## Donation

If you find my projects helpful and would like to support my work, consider making a donation via PayPal. Your support is greatly appreciated!

<a href="https://paypal.me/wubinwen" style="display: flex; align-items: center; gap: 12px;">
    <img src="https://www.paypalobjects.com/paypal-ui/logos/svg/paypal-color.svg" height="30">
</a>


## Start to use

    dotnet new install Fun.Blazor.Templates::4.0.2
    dotnet new fun-blazor -o FunBlazorDemo1

> Requires dotnet 8

## Code samples

```fsharp
// Functional style
let count = cval 0
let counter (str: string) = section {
    h2 { "Counter: "; str }
    adaptiview () {
        let! count, setCount = count.WithSetter()
        button {
            onclick (fun _ -> setCount (count + 1))
            "Increase "; count
        }
    }
}

// Class style
type CountPage() =
    inherit FunComponent()

    let mutable count = 0

    override _.Render() = main {
        h1 { "Counter Page" }
        p { "hi here" }
        button {
            onclick (fun _ -> count <- count + 1)
            "Increase "; count
        }
        counter "functional style"
    }
```

## Local development

You can run **dotnet fsi build.fsx -- -h** to check what is available to help you get started.

## Benchmark

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.400
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| RenderWithRazorCSharp          | 245.3 ns |  2.05 ns |  1.82 ns |  1.00 |    0.01 | 0.0296 |     376 B |        1.00 |
| RenderWithFunBlazorInlineCE    | 389.9 ns |  7.82 ns |  9.01 ns |  1.59 |    0.04 | 0.0443 |     560 B |        1.49 |
| RenderWithBolero               | 532.0 ns | 10.18 ns | 11.32 ns |  2.17 |    0.05 | 0.1173 |    1480 B |        3.94 |
| RenderWithFunBlazorArray       | 532.2 ns | 10.60 ns | 16.50 ns |  2.17 |    0.07 | 0.1154 |    1448 B |        3.85 |
| RenderWithFunBlazorSSRTemplate | 483.8 ns |  6.24 ns |  5.84 ns |  1.97 |    0.03 | 0.0401 |     512 B |        1.36 |
| RenderWithFunBlazorTemplate    | 839.0 ns | 16.50 ns | 21.45 ns |  3.42 |    0.09 | 0.1230 |    1544 B |        4.11 |