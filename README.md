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
dotnet new --install Fun.Blazor.Templates::2.0.0-beta002
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

|                      Method |       Mean |    Error |   StdDev |  Gen 0 |  Gen 1 | Allocated |
|---------------------------- |-----------:|---------:|---------:|-------:|-------:|----------:|
|   BuildRenderTreeWithCSharp |   367.9 ns |  6.45 ns |  6.03 ns | 0.0610 |      - |     384 B |
|   BuildRenderTreeWithBolero | 2,017.4 ns | 37.50 ns | 38.51 ns | 0.6943 | 0.0038 |   4,368 B |
|       BuildRenderTreeWithCE |   807.7 ns |  9.99 ns |  8.34 ns | 0.2861 |      - |   1,800 B |
| BuildRenderTreeWithTemplate | 3,348.9 ns | 53.01 ns | 47.00 ns | 0.7668 | 0.0076 |   4,832 B |
|    BuildRenderTreeWithFeliz | 2,334.7 ns | 33.95 ns | 31.76 ns | 1.2970 | 0.0153 |   8,152 B |


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
