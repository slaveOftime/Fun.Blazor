# 打包发布

在 .NET Blazor WebAssembly 中，当你运行 `dotnet publish -c Release` 命令时，它会尝试裁剪 IL 代码并减少应用程序包的大小。

在 Fun.Blazor 中，无论是内部还是第三方库，只要这些库与 IL 编译器一起按预期工作，您就不需要担心这个问题。

但是，如果您想定义自己的 Blazor 组件，例如：

```fsharp
// The Blazor component
type Autocomplete<'T when 'T: equality>() =
    inherit MudBaseInput<'T option>()    
    
    [<Parameter>]
    member val Clearable = true with get, set

    ...


// The DSL for Fun.Blazor 
type Autocomplete'<'T when 'T : equality> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Autocomplete<_>>)>] () =
    inherit DslInternals.MudBaseInputBuilder<Autocomplete<'T>, 'T option>()

    [<CustomOperation("Clearable")>]
    member inline _.Clearable([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" => x)

    ...
```

你需要为默认构造函数添加 `[<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Autocomplete<_>>)>]`。这是因为 Blazor 使用字符串查找并设置其参数。因此，IL 链接器将删除所有的内容，因为只有引用了类型，但没有在任何地方直接使用。

对于 `[< Inject>]` 等类似的东西，由于 set 方法永远不会直接被使用，因此 set 方法将被删除。

因此，为了简化修剪逻辑，我使用了 `DynamicallyAccessedMemberTypes.All` 来尝试保留类型 Autocomplete 的所有逻辑。

在 `Fun.Blazor.Cli` 中，它将自动添加这些属性，以帮助 IL 链接器正确修剪。如果您使用的是 MudBlazor 6.0.10 及以上版本，它现在默认支持修剪，您可以使用最新版本的 cli，在升级其版本后重新生成绑定。

## 手动控制程序集的链接行为

dotnet core 支持在根项目文件中添加一些配置来设置程序集的修剪行为。下面是 Fun.Blazor.Docs.Wasm.fsproj 文件中使用的演示配置。它意味着我想用链接模式修剪 FSharp.Data 和 FSharp.Control.Reactive，因为这些库默认情况下不设置修剪模式。

但是你需要小心，因为这可能会导致运行时错误。因此，请仔细验证已发布的应用程序。


```xml
<Target Name="ConfigureTrimming" BeforeTargets="PrepareForILLink">
    <ItemGroup>
        <ManagedAssemblyToLink Condition="'%(Filename)' == 'FSharp.Data'">
            <TrimMode>link</TrimMode>
            <IsTrimmable>true</IsTrimmable>
        </ManagedAssemblyToLink>
        <ManagedAssemblyToLink Condition="'%(Filename)' == 'FSharp.Control.Reactive'">
            <TrimMode>link</TrimMode>
            <IsTrimmable>true</IsTrimmable>
        </ManagedAssemblyToLink>
    </ItemGroup>
</Target>
```
