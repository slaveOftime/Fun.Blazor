[<AutoOpen>]
module Fun.Blazor.DslSections

#if !NET6_0
open System.Diagnostics.CodeAnalysis
open Microsoft.AspNetCore.Components.Sections
open Operators

/// <summary>
/// Renders content provided by <see cref="T:Microsoft.AspNetCore.Components.Sections.SectionContent" /> components with matching <see cref="P:Microsoft.AspNetCore.Components.Sections.SectionOutlet.SectionId" />s.
/// </summary>
type SectionOutlet' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<SectionOutlet>)>] () =
    inherit ComponentBuilder<SectionOutlet>()

    [<CustomOperation "SectionId">]
    member inline _.SectionId([<InlineIfLambda>] render: AttrRenderFragment, x: obj) = render ==> ("SectionId" => x)

    [<CustomOperation "SectionName">]
    member inline _.SectionName([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("SectionName" => x)

/// <summary>
/// Provides content to <see cref="T:Microsoft.AspNetCore.Components.Sections.SectionOutlet" /> components with matching <see cref="P:Microsoft.AspNetCore.Components.Sections.SectionContent.SectionId" />s.
/// </summary>
type SectionContent' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<SectionContent>)>] () =
    inherit ComponentWithChildBuilder<SectionContent>()

    [<CustomOperation "SectionId">]
    member inline _.SectionId([<InlineIfLambda>] render: AttrRenderFragment, x: obj) = render ==> ("SectionId" => x)

    [<CustomOperation "SectionName">]
    member inline _.SectionName([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> ("SectionName" => x)
#endif
