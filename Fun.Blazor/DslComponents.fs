[<AutoOpen>]
module Fun.Blazor.DslComponents

open System.Diagnostics.CodeAnalysis
open Microsoft.AspNetCore.Components
open Fun.Blazor.Operators


type CascadingValue'<'Value> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<CascadingValue<_>>)>] () =
    inherit ComponentWithChildBuilder<CascadingValue<'Value>>()

    [<CustomOperation "Name">]
    member inline _.List([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("Name" => x)

    [<CustomOperation "Value">]
    member inline _.Value([<InlineIfLambda>] render: AttrRenderFragment, x: 'Value) = render ==> ("Value" => x)

    [<CustomOperation "IsFixed">]
    member inline _.IsFixed([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsFixed" => x)


type FunFragment'<'Value> [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<FunFragmentComponent>)>] () =
    inherit ComponentBuilder<FunFragmentComponent>()

    [<CustomOperation "Fragment">]
    member inline _.Fragment([<InlineIfLambda>] render: AttrRenderFragment, x: NodeRenderFragment) = render ==> ("Fragment" => x)


let CascadingValue''<'Value> = CascadingValue'<'Value>()
let FunFragment''<'Value> = FunFragment'<'Value>()
