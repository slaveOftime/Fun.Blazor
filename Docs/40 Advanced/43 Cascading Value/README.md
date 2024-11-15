# Cascading values

You can learn more about the concept of cascading values by referring to the [official documentation](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/cascading-values-and-parameters?view=aspnetcore-6.0).

Here's how you can use it in **Fun.Blazor**:

```fsharp
type MyContext() =
    inherit FunComponent()

    // Currently, I have not found any useful APIs to consume CascadingValue directly, and the only way is by attribute. 
    // So, we will first define a class component to consume it.
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
    CascadingValue'' {
        Name "MyContext"
        Value 1
        CascadingValue'' {
            Name "MyContext"
            Value 2 // This value will be consumed because it is more close to the consumer.
            MyContext.Consume (fun x -> div {
                $"data = {x}"
            })
        }
    }
```