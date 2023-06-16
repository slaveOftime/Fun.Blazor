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

BenchmarkDotNet=v0.13.5, OS=Windows 11 (10.0.22621.1848/22H2/2022Update/SunValley2)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2 DEBUG
  DefaultJob : .NET 7.0.7 (7.0.723.27404), X64 RyuJIT AVX2

|                         Method |       Mean |    Error |    StdDev |   Gen0 | Allocated |
|------------------------------- |-----------:|---------:|----------:|-------:|----------:|
|          RenderWithRazorCSharp |   411.4 ns |  8.22 ns |  11.52 ns | 0.0896 |     376 B |
|       RenderWithBolero 0.22.44 |   986.7 ns | 19.21 ns |  36.08 ns | 0.3529 |    1480 B |
|          RenderWithFunBlazorCE |   793.1 ns | 15.77 ns |  32.57 ns | 0.1736 |     728 B |
|    RenderWithFunBlazorTemplate | 2,901.1 ns | 57.36 ns | 101.96 ns | 1.0109 |    4232 B |
| RenderWithFunBlazorSSRTemplate | 1,029.7 ns | 20.52 ns |  37.00 ns | 0.1221 |     512 B |


## Main projects

1. **Fun.Blazor**: help you to use basic dom DSL and state management helpers.

    ```fsharp
    let demo =
        adaptiview(){
            let! count, setCount = FSharp.Data.Adaptive.cval(1).WithSetter()
            button {
                onclick (fun _ -> setCount (count + 1))
                "Increase"
            }
            div {
                style { color "red" }
                $"value = {count}"
            }
        }
    ```

2. **Fun.Blazor.HtmlTemplate**: help you to convert plain string to dom tree. And with VSCode + Ionide-fsharp + Highlight HTML/SQL templates you can get embeded intellicense. You can check more detail in [shoelacejs + tailwind demo](https://github.com/slaveOftime/Fun.Blazor.Samples/tree/main/templates/MinimalBlazorWASMAppWithShoelaceAndTailwind)

    ```fsharp
    let staticPart =
        Static.html """
            <div style="color: hotpink;">Congratulations! You made it ❤️</div>
        """

    // The performance will not be good as CE DSL for initial start. Because it need to parse at runtime and cache for next usage.
    let dynamicPart =
        adaptiview(){
            let! count, setCount = FSharp.Data.Adaptive.cval(1).WithSetter()
            Template.html $"""
                <div>
                    {staticPart}
                    {count}
                    <button onclick={fun _ -> setCount (count + 1)}></button>
                </div>
            """
        }
    ```


3. **Fun.Blazor.Cli**: support hot-reload and help you to generate CE style binding automatically for any blazor third party libraries.

    [Docs for how to use it](https://slaveoftime.github.io/Fun.Blazor.Docs/?doc=/Cli)

    [Docs for hot-reload](https://slaveoftime.github.io/Fun.Blazor.Docs/?doc=/Hot%20Reload)
    
    [Samples for using MudBlazor](https://github.com/slaveOftime/Fun.Blazor.Samples/tree/main/templates/BlazorWASMAppWithMudBlazor)

    ```fsharp
    open Fun.Blazor
    open MudBlazor

    let alertDemo =
        MudCard'.create [
            MudAlert'() {
                Icon Icons.Filled.AccessAlarm
                "This is the way"
            }
        ]
    ```
