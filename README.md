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
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


| Method                         | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| RenderWithRazorCSharp          | 252.1 ns |  3.31 ns |  3.09 ns |  1.00 |    0.02 | 0.0291 |     368 B |        1.00 |
| RenderWithFunBlazorInlineCE    | 372.9 ns |  7.48 ns |  7.00 ns |  1.48 |    0.03 | 0.0439 |     552 B |        1.50 |
| RenderWithFunBlazorSSRTemplate | 467.9 ns |  5.83 ns |  5.45 ns |  1.86 |    0.03 | 0.0420 |     528 B |        1.43 |
| RenderWithBolero               | 495.3 ns |  8.74 ns |  8.18 ns |  1.96 |    0.04 | 0.1192 |    1496 B |        4.07 |
| RenderWithFunBlazorArray       | 539.8 ns |  9.13 ns | 16.69 ns |  2.14 |    0.07 | 0.1163 |    1464 B |        3.98 |
| RenderWithFunBlazorTemplate    | 771.2 ns | 12.50 ns | 11.69 ns |  3.06 |    0.06 | 0.1240 |    1560 B |        4.24 |