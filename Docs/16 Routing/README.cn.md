# 路由

## blazor 官方风格

```fsharp
type MainLayout() as this =
    inherit LayoutComponentBase()

    let content = div {
        nav {
            // your nav code
        }
        main { this.Body }
    }

    override _.BuildRenderTree(builder) = content.Invoke(this, builder, 0) |> ignore


type Routes() =
    inherit FunComponent()

    override _.Render() = Router'() {
        AppAssembly(Assembly.GetExecutingAssembly())
        Found(fun routeData -> RouteView'() {
            RouteData routeData
            DefaultLayout typeof<MainLayout>
        })
    }
```

所有的 page 入口则应该也用 class component：

```fsharp
[<Route "/counter">]
[<RenderModeInteractiveServer>]
type Counter() =
    inherit FunComponent()

    let mutable count = 0

    override _.Render() = fragment {
        PageTitle'() { "Counter" }
        p { $"Current count: {count}" }
        button {
            on.click (fun _ -> count <- count + 1)
            "Click me"
        }
    }
```

## 函数式风格

在 Fun.Blazor 中，我们内置了路由支持，但你也可以使用自己的路由。内置路由非常简单，受 [Giraffe](https://github.com/giraffe-fsharp/Giraffe) 的启发。

在底层，我们会创建一个组件来监听路由变化并内部使用自适应模型，因此如果实际路径未更改，则 UI 不会重新渲染。

我们还支持一些辅助函数，如 **routeCi "/demo" demoView**。它只是一个函数：`UrlString -> 'T option`。因此，如果返回值有内容，则会返回该内容。它可以只是一个视图片段或其他任何东西。

以下面的代码为例：

{{GiraffeStyleRouter}}