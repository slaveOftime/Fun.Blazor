# About

![image](../assets/fun-blazor%3D.png)

This is a project aimed at making it easier for F# developers to write Blazor applications.

Features include:

1. Allows F# for Blazor development
2. Use computation expression (CE) style DSL for internal and third-party Blazor libraries
3. Use dependency injection (html.inject/html.comp)
4. Leverages the [Adaptive](https://github.com/fsprojects/FSharp.Data.Adaptive) model (adaptiview/AdaptiveForm) (**highly recommended**), or the [elmish](https://github.com/elmish/elmish) model (html.elmish)
5. Implements Giraffe-style routing (html.route)
6. Provides type-safe stylesheet creation using Fun.Css
7. Converts HTML to CE style with [Fun.Dev.Tools](https://slaveoftime.github.io/Fun.DevTools.Docs)

## Benchmarks

|                         Method |       Mean |    Error |   StdDev |   Gen0 | Allocated |
|------------------------------- |-----------:|---------:|---------:|-------:|----------:|
|          RenderWithRazorCSharp |   244.1 ns |  2.60 ns |  2.30 ns | 0.0324 |     408 B |
|          RenderWithFunBlazorCE |   449.9 ns |  5.48 ns |  5.13 ns | 0.0606 |     760 B |
|               RenderWithBolero |   536.0 ns |  5.81 ns |  4.85 ns | 0.1202 |    1512 B |
| RenderWithFunBlazorSSRTemplate |   618.7 ns |  5.74 ns |  5.37 ns | 0.0429 |     544 B |


## Simple demo

Here is a basic counter that uses an adaptive model:

{{Counter}}

Another demo that uses html.inject:

{{BlazorStyleComp}}

## How does this work?

Fun.Blazor provides a series of delegates for Blazor to handle. For example, when you write:

```fsharp
let demo =
    div {
        class' "cool"
    }
```

This code essentially becomes:

```fsharp
let demo =
    NodeRenderFragment(fun comp builder index ->  // delegate
        builder.OpenElement(index, "div")
        bulder.AddAttribute(index + 1, "class", "cool")
        builer.CloseElement()
        index + 2
    )

type NodeRenderFragment = delegate of root: IComponent * builder: RenderTreeBuilder * sequence: int -> int
```

In essence, you have created a delegate that will be passed to a component, which will manage the rendering or building of the DOM tree. This approach is similar to what the Razor engine would generate in the C# world.

Components can be created using `adaptiview`, `html.inject`, etc. These components are normal Blazor components that inherit from `ComponentBase`.

## Considerations before using Fun.Blazor:

There are a few things to keep in mind:

1. The F# compiler has performance issues with intellisense for some large computation expressions (CEs). It is better to keep single CE blocks and files small, or use sequences like `seq`, `list`, or `array` with `childContent` for better intellisense:

    ```fsharp
    div {
        attributes ...
        childContent [ // ✅ recommended for more than one child item
            div { "hi" }
            ...a lot of child items
        ]
    }
    ```

    instead of:

    ```fsharp
    div {
        attributes ...
        div { "hi" }
        ...a lot of child items  ❌
    }
    ```

2. Hot-reload

   The default templates provide limited hot-reload support. Too many files can slow down the hot-reload process, so for best results, add `// hot-reload` at the top of files you want to enable hot-reload for. For more information, see the [Hot-reload in Fun.Blazor](https://www.slaveoftime.fun/blog/d959e36a-f4fe-4a10-88af-5e738633db0f?title=%20Hot-reload%20in%20Fun.Blazor) blog post or [document](https://slaveoftime.github.io/Fun.Blazor.Docs/?doc=/Hot%20Reload).

3. Attribute, items position in CE

    When using a `ref` attribute, you should place it like so:

    ```fsharp
    div {
        attributes ...
        ref (fun x -> ()) // ✅
        childContent [ ... ]
    }
    ```

    Or:

    ```fsharp
    div {
        attributes ...
        ref (fun x -> ()) // ✅
        div { 1 }
        div { 1 }
        // ...
    }
    ```