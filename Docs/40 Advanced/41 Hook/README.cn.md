# Hook 钩子

钩子是组件中非常重要的, 因为你可以使用它来访问组件的生命周期,例如在第一次渲染后做一些事情。

当你使用一个 Hook 时，它看起来像来自 DI 容器，但实际上它不是。它仅在你调用它时才会被创建，并且仅对该特定的组件可用。 您可以使用 **html.inject** 进行调用。例如：

{{BasicHookDemo}}

## 扩展 Hooks

如果您不关心单元测试，可以像这样扩展您自己的功能。但用这种方式，很难 Mock 扩展方法。

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

如果你想让你的组件单元测试友好，你需要进行一些额外的工作：

1. 定义一个接口。

    ```fsharp
    type IMyCompHook =
        abstract member DataCanBeShared: ...
        abstract member LoadDataAfterRender: ...
    ```

2. 实现它。

    ```fsharp
    type MyCompHook (hook: IComponentHook) =
        interface IMyCompHook with
            ...
    ```

3. 在程序启动时将其添加到 DI 容器中。

    ```fsharp
    // 其中使用 `services.AddHookService<IMyCompHook>(MyCompHook)` 方法注册一个单例工厂函数，以供消费者使用。
    services.AddHookService<IMyCompHook>(MyCompHook)
    ```

3. 在组件中使用它。

    ```fsharp
    let myComp =
        html.inject (fun (hook: IComponentHook) ->
            // 每次消费时都会创建一个新的实例
            let myCompHook = hook.GetHookService<IMyCompHook>()
            ...
        )
    ```

4. 最后，在测试时，可以像往常一样使用 bUnit 来 mock 这个接口。
