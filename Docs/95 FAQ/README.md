# FAQ


## Can I use third party blazor components?

Yes. You can just add package reference to the fsharp project and use the cli to generate the Fun.Blazor CE DSL for you. You can check the [cli docs](documents/Cli) for how to do that.


## Can I use my existing csharp blazor components?

Yes. You can just add project reference to the fsharp project and use the cli to generate the Fun.Blazor CE DSL for you. You can check the [cli docs](documents/Cli) for how to do that.


## Can I use Fun.Blazor to build component for my existing csharp blazor projects?

Yes. It is same as what you can do with csharp. For example:

```fsharp
type Counter() as this =
    inherit FunBlazorComponent()

    do this.DisableEventTriggerStateHasChanged <- false

    [<Parameter>]
    member val Count = 0 with get, set

    override _.Render() = div {
        this.Count
        button {
            onclick (fun _ -> this.Count <- this.Count + 1)
            "Increase"
        }
    }
```
