# Cascading value

You can check the concept in [blazor official documents](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/cascading-values-and-parameters?view=aspnetcore-6.0)

How use it in **Fun.Blazor**?

```fsharp
type MyContext() =
    inherit FunBlazorComponent()

    // Currently I did not find any usable apis to consume CascadingValue directly, and the only way is by attribute. So we will first define a class component to consume it
    [<CascadingParameter(Name = "MyContext")>]
    member val Context = 0 with get, set

     [<Parameter>]
    member val ContentView = (fun (_: int) -> html.none) with get, set

    override _.Render() = this.ContentView this.Context

    static member consume(view: int -> NodeRenderFragment) =
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
            Value 2 // This value will be consumed because it is more close to the consumer
            MyContext.consume (fun x -> div {
                $"data = {x}"
            })
        }
    }
```

