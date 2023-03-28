# Hook

A Hook is very important for a component because you can use it to access the component's lifecycle, for example, to do something after the first render.

When you use a Hook, it may look like it is from the DI container, but actually, it is not. It is created only when you consume it and is only available for that specific component. You can use **html.inject** to consume it. For example:

{{BasicHookDemo}}


## Extend Hooks

If you do not care about unit testing, you can extend your own functionality like this. But in this way, it is not easy to mock the extension methods.

```fsharp
type IComponentHook with
    member hook.DataCanBeShared =
        let store = hook.ServiceProvider.GetService<IShareStore>()
        store.CreateCVal(nameof hook.DataCanBeShared, LoadingState<...>.NotStartYet)

    member hook.LoadDataAfterRender() =
        hook.AddFirstAfterRenderTask(fun () ->
            task {
                hook.DataCanBeShared.Publish LoadingState.start
                let! result = ... call some API
                hook.DataCanBeShared.Publish (LoadingState.Loaded data)
            }
        )
```


If you want to make your component unit testing friendly, you will need to do more stuff:

1. Define an interface.

    ```fsharp
    type IMyCompHook =
        abstract member DataCanBeShared: ...
        abstract member LoadDataAfterRender: ...
    ```

2. Implement it.

    ```fsharp
    type MyCompHook (hook: IComponentHook) =
        interface IMyCompHook with
            ...
    ```

3. Add it to the DI container at the program start.

    ```fsharp
    // Under the hood, it just registers a singleton factory function for the consumer to use.
    services.AddHookService<IMyCompHook>(MyCompHook)
    ```

4. Use it in your component.

    ```fsharp
    let myComp =
        html.comp (fun (hook: IComponentHook) ->
            // Every time you consume this, it will create a new instance for you.
            let myCompHook = hook.GetHookService<IMyCompHook>()
            ...
        )
    ```

5. Finally, when you do your testing, you can use bUnit to mock the interface as usual.