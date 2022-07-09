namespace Fun.Blazor

open Microsoft.AspNetCore.Components
open Fun.Blazor.Operators


type CascadingValue'<'Value>() =
    inherit ComponentWithChildBuilder<CascadingValue<'Value>>()

    [<CustomOperation "Name">]
    member inline _.List([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("Name" => x)

    [<CustomOperation "Value">]
    member inline _.Value([<InlineIfLambda>] render: AttrRenderFragment, x: 'Value) = render ==> ("Value" => x)

    [<CustomOperation "IsFixed">]
    member inline _.IsFixed([<InlineIfLambda>] render: AttrRenderFragment, x: bool) = render ==> ("IsFixed" => x)
