# Routing

## blazor official style

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

All the page entry should use class component style：

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
            onclick (fun _ -> count <- count + 1)
            "Click me"
        }
    }
```

## Functional style

In Fun.Blazor, we have built-in routing support, but you can always use your own. The built-in routing is very simple and inspired by [Giraffe](https://github.com/giraffe-fsharp/Giraffe).

Under the hood, we will create a component to listen to the route changes and use an adaptive model internally, so if the actual path is not changed, the UI will not be re-rendered.

We also support some helper functions like **routeCi "/demo" demoView**. It is just a function: `UrlString -> 'T option`. So if the return value has something, then it will return that thing. It can just be a view fragment or anything else.

Take the code below as an example:

{{GiraffeStyleRouter}}