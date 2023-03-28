# Publish Trim

In dotnet Blazor WebAssembly, when you run `dotnet publish -c Release`, it will try to trim the IL code and reduce the size of the application’s bundle.

In Fun.Blazor, for both internal or third-party libraries, you will not need to worry about this as long as those libraries work as expected with the IL linker.

But if you want to define your Blazor component, for example:


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

You will need to add `[<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Autocomplete<_>>)>]` to the default constructor. The reason is in Blazor, it uses a string to find the key to set its parameters. So the IL linker will trim all of its content because only the type is referenced, but nothing is directly consumed anywhere.

Also for things like `[< Inject>]`, the set method will be trimmed because the set will never be consumed directly.

So to simplify the trim logic, I use `DynamicallyAccessedMemberTypes.All` to try to keep all of the logic for the type Autocomplete.

In the `Fun.Blazor.Cli`, it will automatically add those attributes to help the IL linker to trim things correctly. If you are using MudBlazor which starts from 6.0.10, it supports trim by default now, and you can use the latest version of the cli to regenerate the bindings after you have upgraded its version.

## Manually Control Link Behavior for Assemblies

dotnet core supports adding some configuration in the root project file to set the trim behavior for assemblies. Below is a demo configuration which is used in the Fun.Blazor.Docs.Wasm.fsproj file. It means I want to trim FSharp.Data and FSharp.Control.Reactive with the link mode because by default those libraries are not set to trim mode.

But you will need to be careful as it may cause issues. So please verify the published application carefully.


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