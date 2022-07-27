# Publish trim

In dotnet blazor WASM, when you run **dotnet publish -c Release** it will try to trim the IL code and reduce the application's bundle size.

In Fun.Blazor, for both the internal or third party libraries, you will no need to worry about this as long as those libraries works expected with the IL linker.

But if you want to define your own blazor component, for example:


```fsharp
type Autocomplete<'T when 'T: equality>() =

    [<Parameter>]
    member val Clearable = true with get, set

    ...


type Autocomplete'<'T when 'T: equality> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Autocomplete<_>>)>] () =
    inherit DslInternals.MudBaseInputBuilder<Autocomplete<'T>, 'T option>()

    [<CustomOperation("Clearable")>]
    member inline _.Clearable([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("Clearable" => x)

    ...
```

You will need to add **[<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Autocomplete<_>>)>]** to the default constructor. The reason is, in blazor it is using string to find the key to set its parameters. So the IL linker will trim all of its content. Because only the type is referenced, but nothing are directly consumed anywhere.

Also for things like **[< Inject>]**, the set method will be trimmed, because the set will never be consumed directly.

So to simplify the trim logic, I use **DynamicallyAccessedMemberTypes.All** to try to keep all of the logic for the type AutoComplete.

In the **Fun.Blazor.Cli**, it will automatically add those attribute to help the IL linker to trim things correctly. So if you are using MudBlazor which start from 6.0.10 it supports trim by default now, you can use the latest version of the cli to regenerate the bindings after you upgraded its version.
