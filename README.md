# Fun.Blazor [![Nuget](https://img.shields.io/nuget/v/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine) before. \
Now the dependency of bolero is removed to make it lighter. Feliz style is also not recommend because it will cause more allocation and render loop than CE style.

[Server side docs](https://funblazor.slaveoftime.fun)

[WASM side docs](https://slaveoftime.github.io/Fun.Blazor/)


## What you can get with this project?

1. Use F# ❤️😊 for blazor
2. Template, computation expression style DSL for internal and third party blazor libraries
4. Dependency injection (html.inject)
3. Elmish model (html.elmish), obervable model (html.watch), adaptive model(adaptiview)


## Please check the samples for quick start

https://github.com/slaveOftime/Fun.Blazor.Samples

Template is also available (thanks: @AngelMunoz):
```shell
dotnet new --install Fun.Blazor.Templates::2.0.0-beta-001
```

## Some tips

1. Fun.Blazor

```fsharp
    let demo =
        adaptiview(){
            let! v, setValue = FSharp.Data.Adaptive.cval(1).WithSetter()
            button {
                onclick (fun _ -> setValue (v + 1))
                "Increase"
            }
            div {
                style'' {
                    color "red"
                }
                $"value = {v}"
            }
        }
```

2. Fun.Blazor.HtmlTemplate: is help you to convert plain string to dom tree. And with VSCode + Ionide-fsharp + Highlight HTML/SQL templates you can get embeded intellicense. You can check more detail in [shoelacejs + tailwind demo](https://github.com/slaveOftime/Fun.Blazor.Samples/tree/main/templates/MinimalBlazorWASMAppWithShoelaceAndTailwind)

```fsharp
    let congratulations =
        Template.html $"""
            <div style="color: hotpink;">Congratulations! You made it ❤️</div>
        """
```


3. Fun.Blazor.Cli: you can generate CE style automatically for any blazor third party libraries

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
|   BuildRenderTreeWithCSharp |   380.1 ns |  7.18 ns |  8.81 ns | 0.0610 |      - |     384 B |
|   BuildRenderTreeWithBolero | 1,906.9 ns | 35.35 ns | 31.34 ns | 0.6943 | 0.0038 |   4,368 B |
|       BuildRenderTreeWithCE | 1,009.8 ns | 19.78 ns | 34.64 ns | 0.3128 |      - |   1,968 B |
| BuildRenderTreeWithTemplate | 2,507.6 ns | 49.90 ns | 64.88 ns | 0.6752 | 0.0038 |   4,256 B |
|    BuildRenderTreeWithFeliz | 2,302.9 ns | 42.20 ns | 39.48 ns | 1.1864 | 0.0114 |   7,448 B |


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
