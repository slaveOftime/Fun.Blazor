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

    dotnet new install Fun.Blazor.Templates::4.1.1
    dotnet new fun-blazor -o FunBlazorDemo1

> The template is upgraded to dotnet 9, but you can downgrade it according to your needs.

## Code samples

```fsharp
// Functional style
let count = cval 0
let counter (str: string) = section {
    h2 { "Counter: "; str }
    adapt {
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
| RenderWithRazorCSharp          | 247.7 ns |  3.80 ns |  3.37 ns |  1.00 |    0.02 | 0.0291 |     368 B |        1.00 |
| RenderWithFunBlazorInlineCE    | 374.1 ns |  5.53 ns |  4.91 ns |  1.51 |    0.03 | 0.0439 |     552 B |        1.50 |
| RenderWithFunBlazorSSRTemplate | 475.6 ns |  5.78 ns |  5.40 ns |  1.92 |    0.03 | 0.0420 |     528 B |        1.43 |
| RenderWithBolero               | 497.9 ns |  8.46 ns | 10.07 ns |  2.01 |    0.05 | 0.1192 |    1496 B |        4.07 |
| RenderWithFunBlazorArray       | 525.2 ns | 10.44 ns | 11.17 ns |  2.12 |    0.05 | 0.1144 |    1440 B |        3.91 |
| RenderWithFunBlazorTemplate    | 785.9 ns |  7.95 ns |  7.44 ns |  3.17 |    0.05 | 0.1240 |    1560 B |        4.24 |
