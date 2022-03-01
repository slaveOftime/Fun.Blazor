# Fun.Blazor [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine) before. \
Now (V2) the dependency of bolero is removed to make it lighter. Feliz style is also not recommend because it will cause more allocation and render loop than CE style.

[Server side docs](https://funblazor.slaveoftime.fun)

[Wasm side docs (may take a while to load)](https://slaveoftime.github.io/Fun.Blazor.Docs/)


## What you can get with this project?

1. Use F# ❤️😊 for blazor
2. Template, computation expression style DSL for internal and third party blazor libraries
4. Dependency injection (html.inject)
3. Elmish model (html.elmish), obervable model (html.watch), adaptive model (adaptiview)


## Please check the samples for quick start

https://github.com/slaveOftime/Fun.Blazor.Samples

Template is also available (thanks: @AngelMunoz):
```shell
dotnet new --install Fun.Blazor.Templates::2.0.0-beta012
```

## Some tips

1. Fun.Blazor: help you to use basic dom DSL and state management helpers.

```fsharp
    let demo =
        adaptiview(){
            let! v, setValue = FSharp.Data.Adaptive.cval(1).WithSetter()
            button {
                onclick (fun _ -> setValue (v + 1))
                "Increase"
            }
            div {
                style'' { color "red" }
                $"value = {v}"
            }
        }
```

2. Fun.Blazor.HtmlTemplate: help you to convert plain string to dom tree. And with VSCode + Ionide-fsharp + Highlight HTML/SQL templates you can get embeded intellicense. You can check more detail in [shoelacejs + tailwind demo](https://github.com/slaveOftime/Fun.Blazor.Samples/tree/main/templates/MinimalBlazorWASMAppWithShoelaceAndTailwind)

```fsharp
    // If there is no arugment for formatable string then it will be very efficient. So it is better to always keep static part and dynamic part in different places.
    let staticPart =
        Template.html $"""
            <div style="color: hotpink;">Congratulations! You made it ❤️</div>
        """

    let dynamicPart =
        adaptiview(){
            let! v, setValue = FSharp.Data.Adaptive.cval(1).WithSetter()
            Template.html $"""
                <div>
                    {staticPart}
                    {v}
                    <button onclick={fun _ -> setValue (v + 1)}></button>
                </div>
            """
        }
```


3. Fun.Blazor.Cli: help you to generate CE style binding automatically for any blazor third party libraries

    [Docs for how to use it](https://funblazor.slaveoftime.fun/cli-usage)
    
    [Samples for using MudBlazor](https://github.com/slaveOftime/Fun.Blazor.Samples/tree/main/templates/MinimalBlazorWASMAppWithMudBlazor)
    

```fsharp
    open Fun.Blazor
    open MudBlazor

    let alertDemo =
        MudCard'() {
            MudAlert'() {
                Icon Icons.Filled.AccessAlarm
                "This is the way"
            }
        }
```


## Benchmark

|                      Method |       Mean |    Error |    StdDev |     Median |  Gen 0 |  Gen 1 | Allocated |
|---------------------------- |-----------:|---------:|----------:|-----------:|-------:|-------:|----------:|
|   BuildRenderTreeWithCSharp |   387.0 ns |  6.54 ns |   6.12 ns |   388.2 ns | 0.0610 |      - |     384 B |
|   BuildRenderTreeWithBolero | 2,097.9 ns | 41.77 ns | 112.20 ns | 2,057.3 ns | 0.6943 | 0.0038 |   4,368 B |
|       BuildRenderTreeWithCE |   808.5 ns | 16.01 ns |  39.26 ns |   794.1 ns | 0.1745 |      - |   1,096 B |
| BuildRenderTreeWithTemplate | 3,817.9 ns | 84.19 ns | 248.24 ns | 3,769.4 ns | 0.7668 | 0.0076 |   4,832 B |
|    BuildRenderTreeWithFeliz | 2,616.5 ns | 51.97 ns | 123.52 ns | 2,618.0 ns | 1.2474 | 0.0114 |   7,832 B |
|  BuildRenderTreeWithCEFeliz | 1,456.7 ns | 34.21 ns | 100.32 ns | 1,452.7 ns | 0.6180 | 0.0038 |   3,880 B |


|                   Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|------------------------- |---------:|---------:|---------:|-------:|----------:|
| BuildStyleWithCssBuilder | 375.8 ns |  7.87 ns | 22.44 ns | 0.1211 |     760 B |
|      BuildStyleWithFeliz | 693.1 ns | 13.05 ns | 13.96 ns | 0.2918 |   1,832 B |


## Migrate from V1

- For all the internal dom element like div, we should change
```fsharp
div() {}
```
to
```fsharp
div {}
```

- For server side, we should add nuget packages: Fun.Blazor.Server

    AddFunBlazor is changed to AddFunBlazorServer \
    MapFallbackToBolero is changed to MapFunBlazor

- For wasm side, we should add nuget packages: Fun.Blazor.Wasm

    AddFunBlazor is changed to AddFunBlazorWasm \
    AddFunBlazorNode is changed to AddFunBlazor
