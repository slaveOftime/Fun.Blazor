# Hook

Hook is very important for a component because you can use to access component's lifecycle like: do something after first render etc.

When you use it, it looks like it is from DI container but actually it is not, it is created when you actually consume it and is only available for that specific component.

You can use **html.inject** or **html.comp** to consume it. For example:

{{BasicHookDemo}}


## Extend hooks

If you do not care about unit testing, then you can extend your own functionality like this. But in this way it is not easy to mock the extension methods.

```fsharp
type IComponentHook with
    member hook.DataCanBeShared =
        let store = hook.ServiceProvider.GetService<IShareStore>()
        store.CreateCVal(nameof hook.DataCanBeShared, LoadingState<...>.NotStartYet)

    member hook.LoadDataAfterRender() =
        hook.AddFirstAfterRenderTask(fun () ->
            task {
                hook.DataCanBeShared.Publish LoadingState.start
                let! result = ... call some api
                hook.DataCanBeShared.Publish (LoadingState.Loaded data)
            }
        )
```

If you want to make your component unit testing friendly, you will need to do more stuff:

1. Define an interface
    ```fsharp
    type IMyCompHook =
        abstract member DataCanBeShared: ...
        abstract member LoadDataAfterRender: ...
    ```

2. Implement it like:
    ```fsharp
    type MyCompHook (hook: IComponentHook) =
        interface IMyCompHook with
            ...
    ```

3. Add to the DI at the program start
    ```fsharp
    // Under the hood, it just register a singleton factory function for consumer to use
    services.AddHookService<IMyCompHook>(MyCompHook)
    ```

4. Use it in your component

    ```fsharp
    let myComp =
        html.comp (fun (hook: IComponentHook) ->
            // Every time you consume this, it will create a new instance for you
            let myCompHook = hook.GetHookService<IMyCompHook>()
            ...
        )
    ```

5. Finally when you do your testing, you can use bUnit to moq the interface as usual
