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


## Please check the samples for quick start

https://github.com/slaveOftime/Slaveoftime.Site

https://github.com/slaveOftime/Fun.Blazor.Samples

Below version may not be updated, please check here [![Nuget](https://img.shields.io/nuget/vpre/Fun.Blazor.Templates)](https://www.nuget.org/packages/Fun.Blazor.Templates)

```shell
dotnet new --install Fun.Blazor.Templates::2.0.0-beta*
```


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


## Pitfalls

1. FSharp compiler cannot handle some large computation expression. It is better to make single CE block smaller and single file smaller. Or use sequence like seq/list/array with childContent:

    ```fsharp
    div {
        onclick ignore
        other attrs
        childContent [ // ✅ it is recommended to use this when you got more than one child items
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

    Now the default templates contain limited hot-reload support.
    It is very slow to have too much file to be hot-reloaded, so you need to add **// hot-reload** at the top of the file you want to enable hot-reload.
    For more detail you can check my blog post [Hot-reload in Fun.Blazor](https://www.slaveoftime.fun/blog/d959e36a-f4fe-4a10-88af-5e738633db0f?title=%20Hot-reload%20in%20Fun.Blazor).  
    Or check the [document](https://funblazor.slaveoftime.fun/hot-reload)

3. attribute, items position in CE

    When you want to use ref attribute, you need to put it like below

    ```fsharp
    div {
        onclick (fun _ -> ())
        some other attibutes
        ref (fun x -> ()) // ✅
        childContent [ ... ]
    }
    ```

    Or

    ```fsharp
    div {
        some other attibutes
        onclick (fun _ -> ())
        ref (fun x -> ()) // ✅
        div { 1 }
        div { 1 }
        // ...
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

|                      Method |       Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------------------- |-----------:|---------:|---------:|-------:|----------:|
|   BuildRenderTreeWithCSharp |   383.3 ns |  7.47 ns | 14.03 ns | 0.0916 |     384 B |
|   BuildRenderTreeWithBolero |   908.4 ns | 11.39 ns | 17.74 ns | 0.3824 |   1,600 B |
|       BuildRenderTreeWithCE |   708.3 ns |  9.00 ns |  7.51 ns | 0.1755 |     736 B |
| BuildRenderTreeWithTemplate | 2,638.0 ns | 49.19 ns | 43.61 ns | 1.0109 |   4,240 B |
