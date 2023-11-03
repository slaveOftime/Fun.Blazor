# 常见问题解答

## 我可以使用第三方的 Blazor 组件吗？

可以。你只需将包引用添加到 F# 项目中，然后使用 CLI 为你生成 Fun.Blazor CE DSL。有关更多信息，请参阅 [CLI 文档](documents/Cli)。

## 我可以使用现有的 C# Blazor 组件吗？

可以。你只需将项目引用添加到 F# 项目中，然后使用 CLI 为你生成 Fun.Blazor CE DSL。有关更多信息，请参阅 [CLI 文档](documents/Cli)。

## 我可以使用 Fun.Blazor 为我的现有 C# Blazor 项目构建组件吗？

可以。与 C# 的使用方式相同。例如：

```fsharp
type Counter() as this =
    inherit FunComponent()

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