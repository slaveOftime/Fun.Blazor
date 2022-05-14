# Fun.Blazor [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

> This project is under developing and in beta, api are expected to be changed, please use it carefully. Also please check the [Pitfalls](#pitfalls) before you try.

## What

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine) before. \
Now **(in V2)** the dependency of bolero is removed to make it lighter. **Feliz style is deprecated** because it will cause more allocation and render loop than CE style, also it is too verbose as a DSL.


## Docs

Now the docs are only written as an experimental playground and simple introduction, so it is not well organized. A new design may needed.

[Server side docs](https://funblazor.slaveoftime.fun)

[Wasm side docs (may take a while to load)](https://slaveoftime.github.io/Fun.Blazor.Docs/)


## What you can get with this project?

1. Use F# ❤️😊 for blazor
2. Template, computation expression style DSL for internal and third party blazor libraries
4. Dependency injection (html.inject)
3. [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) model (adaptiview) (**recommend**), [elmish](https://github.com/elmish/elmish) model (html.elmish), [obervable](https://github.com/fsprojects/FSharp.Control.Reactive) model (html.watch)


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

    [Docs for how to use it](https://funblazor.slaveoftime.fun/cli-usage)

    [Docs for hot-reload](https://funblazor.slaveoftime.fun/hot-reload)]
    
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

## Benchmark

|                      Method |       Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------------------- |-----------:|---------:|---------:|-------:|----------:|
|   BuildRenderTreeWithCSharp |   383.3 ns |  7.47 ns | 14.03 ns | 0.0916 |     384 B |
|   BuildRenderTreeWithBolero |   908.4 ns | 11.39 ns | 17.74 ns | 0.3824 |   1,600 B |
|       BuildRenderTreeWithCE |   708.3 ns |  9.00 ns |  7.51 ns | 0.1755 |     736 B |
| BuildRenderTreeWithTemplate | 2,638.0 ns | 49.19 ns | 43.61 ns | 1.0109 |   4,240 B |
