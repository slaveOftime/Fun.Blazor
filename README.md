# Fun.Blazor [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

![image](./Docs//assets/fun-blazor%3D.png)

This is a project to make F# developer to write blazor easier.

1. Use F# ❤️😊 for blazor
2. Computation expression (CE) style DSL for internal and third party blazor libraries
3. Dependency injection (html.inject/html.comp)
4. [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) model (adaptiview/AdaptivieForm) (**recommend**), [elmish](https://github.com/elmish/elmish) model (html.elmish)
5. Giraffe style routing (html.route)
6. Type safe style (Fun.Css)
7. Convert html to CE style by [Fun.Dev.Tools](https://slaveoftime.github.io/Fun.DevTools.Docs)

Check the [WASM Docs](https://slaveoftime.github.io/Fun.Blazor.Docs/) for more 🚀

## Benchmark

|                         Method |       Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------------------- |-----------:|---------:|---------:|-------:|----------:|
|          RenderWithRazorCSharp |   244.1 ns |  2.60 ns |  2.30 ns | 0.0324 |     408 B |
|          RenderWithFunBlazorCE |   449.9 ns |  5.48 ns |  5.13 ns | 0.0606 |     760 B |
|               RenderWithBolero |   536.0 ns |  5.81 ns |  4.85 ns | 0.1202 |    1512 B |
| RenderWithFunBlazorSSRTemplate |   618.7 ns |  5.74 ns |  5.37 ns | 0.0429 |     544 B |

## Start to use

    dotnet new --install Fun.Blazor.Templates::3.1.0-beta004
    dotnet new fun-blazor -o FunBlazorDemo1

> Requires dotnet 8

## Code sample snipts

```fsharp
// Functional style
let demo (str) = fragment {
    h2 { $"demo {str}" }
}

// Class style
type Foo() =
    inherit FunComponent()

    let mutable count = 0

    override _.Render() = main {
        h1 { "foo" }
        demo $"hi {count}"
        button {
            onclick (fun _ -> count <- count + 1)
            "Click me"
        }
    }
```

## Use it carefully

- There is CE performance [issue](https://github.com/dotnet/fsharp/issues/14429) for large projects.