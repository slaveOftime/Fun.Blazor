# Fun.Blazor [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

![image](./Docs//assets/fun-blazor%3D.png)

This is a project to make F# developer to write blazor easier.

1. Use F# ❤️😊 for blazor
2. Template, computation expression style DSL for internal and third party blazor libraries
3. Dependency injection (html.inject/html.comp)
4. [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) model (adaptiview/AdaptivieForm) (**recommend**), [elmish](https://github.com/elmish/elmish) model (html.elmish)
5. Giraffe style routing (html.route)
6. Type safe style (Fun.Css)

## Benchmark

|               Method |       Mean |    Error |   StdDev |  Gen 0 | Allocated |
|--------------------- |-----------:|---------:|---------:|-------:|----------:|
|    Build_RazorCSharp |   400.3 ns |  6.99 ns |  6.20 ns | 0.0610 |     384 B |
|         Build_Bolero |   926.1 ns | 17.49 ns | 17.96 ns | 0.2546 |   1,600 B |
|       Build_FunCssCE |   731.1 ns | 14.07 ns | 21.49 ns | 0.1173 |     736 B |
| Build_FunCssTemplate | 2,569.9 ns | 42.22 ns | 39.50 ns | 0.6752 |   4,240 B |


## Main projects

1. **Fun.Blazor**: help you to use basic dom DSL and state management helpers.

    ```fsharp
    let demo =
        adaptiview(){ // this is more recommend than html.watch and html.elmish
            let! count, setCount = FSharp.Data.Adaptive.cval(1).WithSetter()
            button {
                onclick (fun _ -> setValue (count + 1))
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

    [Docs for hot-reload](https://slaveoftime.github.io/Fun.Blazor.Docs/?doc=/Hot%20Reload)]
    
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
