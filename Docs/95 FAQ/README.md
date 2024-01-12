# FAQ

## Can I use third-party Blazor components?

Yes, you can simply add package references to the F# project and use the CLI to generate the Fun.Blazor CE DSL for you. Refer to the [CLI documentation](Tooling/Code-Generation) for more information. 


## Can I use my existing C# Blazor components?

Yes, you can just add project references to the F# project and use the CLI to generate the Fun.Blazor CE DSL for you. Refer to the [CLI documentation](Tooling/Code-Generation) for more information. 


## Can I use Fun.Blazor to build components for my existing C# Blazor projects?

Yes, it is the same as what you can do with C#. For example:

```fsharp
type Counter() as this =
    inherit FunComponent()

    [<Parameter>]
    member val Count = 0 with get, set

    override _.Render() = div {
        this.Count
        button {
            on.click (fun _ -> this.Count <- this.Count + 1)
            "Increase"
        }
    }
```