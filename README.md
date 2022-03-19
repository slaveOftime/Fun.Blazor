# Fun.Blazor [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor)](https://www.nuget.org/packages/Fun.Blazor)

> This project is under developing and in beta, api are expected to be changed, please use it carefully. Also please check the [Pitfalls](#pitfalls) before you try.

## Table of contents

- [Docs](#docs)
- [What you can get from this project](#what-you-can-get-with-this-project)
- [Templates](#please-check-the-samples-for-quick-start)
- [Main projects](#main-projects)
- [Pitfalls](#pitfalls)
- [Code structure example](#code-structure-example)
- [Benchmark](#benchmark)
- [Migration from v1](#migrate-from-v1)


## What

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine) before. \
Now **(in V2)** the dependency of bolero is removed to make it lighter. Feliz style is deprecated because it will cause more allocation and render loop than CE style, also it is too verbose as a DSL.


## Docs

Now the docs are only written as an experimental playground and simple introduction, so it is not well organized. A new design may needed.

[Server side docs](https://funblazor.slaveoftime.fun)

[Wasm side docs (may take a while to load)](https://slaveoftime.github.io/Fun.Blazor.Docs/)


## What you can get with this project?

1. Use F# ❤️😊 for blazor
2. Template, computation expression style DSL for internal and third party blazor libraries
4. Dependency injection (html.inject)
3. [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) model (adaptiview) (**recommend**), [elmish](https://github.com/elmish/elmish) model (html.elmish), [obervable](https://github.com/fsprojects/FSharp.Control.Reactive) model (html.watch)


## Please check the samples for quick start

https://github.com/slaveOftime/Slaveoftime.Site
https://github.com/slaveOftime/Fun.Blazor.Samples

Below version may not be updated, please check here [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor.Templates)](https://www.nuget.org/packages/Fun.Blazor.Templates)

```shell
dotnet new --install Fun.Blazor.Templates::2.0.0-beta013
```


## Main projects

1. **Fun.Blazor**: help you to use basic dom DSL and state management helpers.

    ```fsharp
    let demo =
        adaptiview(){ // this is more recommend than html.watch and html.elmish
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

2. **Fun.Blazor.HtmlTemplate**: help you to convert plain string to dom tree. And with VSCode + Ionide-fsharp + Highlight HTML/SQL templates you can get embeded intellicense. You can check more detail in [shoelacejs + tailwind demo](https://github.com/slaveOftime/Fun.Blazor.Samples/tree/main/templates/MinimalBlazorWASMAppWithShoelaceAndTailwind)

    ```fsharp
    // If there is no argument for formatable string then it will be very efficient. So it is better to always keep static part and dynamic part in different places.
    let staticPart =
        Static.html """
            <div style="color: hotpink;">Congratulations! You made it ❤️</div>
        """

    // The performance will not be good as CE DSL for initial start. Because it need to parse at runtime and cache for next usage.
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


3. **Fun.Blazor.Cli**: support hot-reload, help you to generate CE style binding automatically for any blazor third party libraries.

    [Docs for how to use it](https://funblazor.slaveoftime.fun/cli-usage)
    
    [Samples for using MudBlazor](https://github.com/slaveOftime/Fun.Blazor.Samples/tree/main/templates/BlazorWASMAppWithMudBlazor)

    ```shell
    dotnet tool install --global Fun.Blazor.Cli --version 2.0.0-beta023
    ```
    

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


## Pitfalls

1. FSharp compiler cannot handle large computation expression. It is better to make simple CE block smaller and single file smaller. Or use sequence like seq/list/array with childContent:

    ```fsharp
    div {
        onclick ignore
        other attrs
        childContent [ ✅
            div { "hi" }
            ...a lot of child items
        ]
    }
    ```

    Instead of below:

    ```fsharp
    div {
        onclick ignore
        other attrs
        div { "hi" }
        ...a lot of child items  ❌
    }
    ```

2. Hot-reload

    Now the default templates contain limited hot-reload support. Because blazor wasm json serialization is very slow, so I created a side project (blazor server mode) to boot up it.  
    It is also very slow to have too much file to be hot-reloaded, so you need to add **// hot-reload** at the top of the file you want to enable hot-reload.
    For more detail you can check my blog post [Hot-reload in Fun.Blazor](https://www.slaveoftime.fun/blog/d959e36a-f4fe-4a10-88af-5e738633db0f?title=%20Hot-reload%20in%20Fun.Blazor).  


3. ref position

    When you want to use ref attribute, you need to put it like below

    ```fsharp
    div {
        some other attibutes
        ref ... ✅
        child items like: div {} or use childContent [ ... ]
    }
    ```


## Code structure example

This project support multiple pattern for state management. From my experience it is not good to use elmish for your whole project. Because the performance and state share concern, also sometimes it feels a little verbose.  

You can try this:

**Db**  
**Domain**  
**Services**  
**UI**  
|--- Stores.fs // contains shared store or global store

```fsharp
    type IShareStore with // scoped for the session in blazor server mode
        member store.IsDark = store.CreateCVal("IsDark", true)

    type IGlobalStore with // Singleton store, shared for all
        ...
```

|--- Hooks.fs // standalone UI logic

```fsharp
    type IComponentHook with
        member hook.TryLoadPosts(page) =
            task {
                ...
            }

        member hook.UseSettingsForm() =
            hook
                .UseAdaptiveForm({| Name = "foo"; ... |})
                .AddValidators(...)
                .AddValidators(...)
```

|--- Controls.fs // Some small shared controls  
|--- Comp1.fs // Your business component  

```fsharp
    // Make your fragment smaller, so you can compose it in cleaner way and get better inline optimization, hot-reload speeding and intellisense performance
    let private fragment1 = div {...}

    let private fragment2 (shareStore: IShareStore) =
        adaptiview {
            let! isDark, setIsDark = shareStore.IsDark.WithSetter()   
            div { ... } 
        }

    // or use elmish if you like
    let private fragment3 = html.elmish (init, update, view)

    let comp1 =
        html.inject (fun (svc1, shareStore: IShareStore, ...) ->
            div {
                childContent [
                    fragment1
                    fragment2 shareStore
                    fragment3
                ]
            }
        )
```

|--- Comp2.Hooks.fs // in case you have large component, or you can even create separate folder for the whole component  
|--- Comp2.Control1.fs // manage large control which is only for your business Comp2  
|--- Comp2.fs // The entry for your comp2  
|--- App.fs // compose your components or pages

```fsharp
let private routes =
    html.route [
        routeCi "/page1" comp1
        routeAny comp2
    ]

let app =
    div {
        header
        routes
        footer
    }
```

|--- Index.fs // if you are using blazor server mode, you need to have this. You can check the template.  
|--- Startup.fs

> You can check repo https://github.com/slaveOftime/Slaveoftime.Site as a reference for those practical tips.


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
