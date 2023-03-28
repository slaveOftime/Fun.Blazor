# 级联值

你可以通过参考[官方文档](https://docs.microsoft.com/zh-cn/aspnet/core/blazor/components/cascading-values-and-parameters?view=aspnetcore-6.0)来了解级联值的概念。

以下是在 **Fun.Blazor** 中如何使用它：

```fsharp
type MyContext() =
    inherit FunBlazorComponent()

    // 目前，我没有找到任何有用的 API 来直接使用 CascadingValue，唯一的方法是通过属性。 
    // 因此，我们将首先定义一个类组件来使用它。
    [<CascadingParameter(Name = "MyContext")>]
    member val Context = 0 with get, set

    [<Parameter>]
    member val ContentView = (fun (_: int) -> html.none) with get, set

    override this.Render() = this.ContentView this.Context

    static member Consume(view: int -> NodeRenderFragment) =
        NodeRenderFragment(fun _ builder index ->
            builder.OpenComponent<MyContext>(index)
            builder.AddAttribute(index + 1, "ContentView", view)
            builder.CloseComponent()
            index + 2
        )


let demo =
    CascadingValue'() {
        Name "MyContext"
        Value 1
        CascadingValue'() {
            Name "MyContext"
            Value 2 // 这个值会被消费，因为它更接近消费者。
            MyContext.Consume (fun x -> div {
                $"data = {x}"
            })
        }
    }
```
