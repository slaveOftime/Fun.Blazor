# About

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine) before. 
Now **(in V2)** the dependency of bolero is removed to make it lighter. **Feliz style is deprecated** because it will cause more allocation and render loop than CE style in my previous implementation.

Anyway it is opinionated project, because I really like CE style, even its intellisense is not that good. Also I prefer adaptive model instead of Elmish. But you are not limited to use that, there is a package **Fun.Blazor.Elmish** to support that. Another thing is about dependency injection, I like that idea and find it is very useful when manage big applications. I know, I know, some functional programmers may not like that.


Below is a very simple counter which is using adaptive model.

{{Counter}}


## How is this work

Fun.Blazor's concept is very simple, provide a bunch of delegates to let **blazor** to handle.

When you write things like:

```fsharp
let demo =
    div {
        class' "cool"
    }
```

Under the hood, it just becomes:

```fsharp
let demo =
    NodeRenderFragment(fun comp builder index ->
        builder.OpenElement(index, "div")
        bulder.AddAttribute(index + 1, "class", "cool")
        builer.CloseElement()
        index + 2
    )

type NodeRenderFragment = delegate of root: IComponent * builder: RenderTreeBuilder * sequence: int -> int
```

So basically, you just created a delegate and finally it will be passed to a component and let the component to manage when to render or build the dom tree. It is similar with what the razor engine will generate in csharp world. 

The component can be created by **adaptiview / html.comp / html.inject** etc. Those components are just normal blazor components which are inherited from ComponentBase.


## Before you consider to use it:

There are some pitfalls which you may keep in mind:

1. FSharp compiler has performance issue on intellisense for some large computation expression (CE). It is better to make single CE block smaller and single file smaller. Or use sequence like seq/list/array with childContent for better intellisense experience:

    ```fsharp
    div {
        attributes ...
        childContent [ // ✅ it is recommended to use this when you got more than one child items
            div { "hi" }
            ...a lot of child items
        ]
    }
    ```

    Instead of below:

    ```fsharp
    div {
        attributes ...
        div { "hi" }
        ...a lot of child items  ❌
    }
    ```

2. Hot-reload

    Now the default templates contain limited hot-reload support.
    It is very slow to have too much file to be hot-reloaded, so you need to add **// hot-reload** at the top of the file you want to enable hot-reload.
    For more detail you can check my blog post [Hot-reload in Fun.Blazor](https://www.slaveoftime.fun/blog/d959e36a-f4fe-4a10-88af-5e738633db0f?title=%20Hot-reload%20in%20Fun.Blazor).  
    Or check the [document](https://slaveoftime.github.io/Fun.Blazor.Docs/?doc=/Hot%20Reload)

3. Attribute, items position in CE

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