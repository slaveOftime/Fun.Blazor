# About

This is a project to make F# developer to write blazor easier.

It is based on [bolero](https://github.com/fsbolero/Bolero) and  [Feliz.Engine](https://github.com/alfonsogarciacaro/Feliz.Engine) before. \
Now **(in V2)** the dependency of bolero is removed to make it lighter. **Feliz style is deprecated** because it will cause more allocation and render loop than CE style, also it is too verbose as a DSL.

Anyway it is opinionated project, because I really like CE style, even its intellisense is not that good. Also I prefer adaptive model instead of Elmish. But you are not limited to use that, there is a package **Fun.Blazor.Elmish** to support that. Another thing is about dependency injection, I like that idea and find it is very useful when manage big application. I know, I know, some functional programmers may not like that.


Below is a very simple counter which is using adaptive model.

{{Counter}}


## Before you consider to use it:

There are some pitfalls which you may keep in mind:

1. FSharp compiler cannot handle some large computation expression. It is better to make single CE block smaller and single file smaller. Or use sequence like seq/list/array with childContent for better intellisense experience:

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