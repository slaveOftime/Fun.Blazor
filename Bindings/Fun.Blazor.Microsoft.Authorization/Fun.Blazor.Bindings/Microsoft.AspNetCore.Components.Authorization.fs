namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open System.Threading.Tasks
open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.Authorization.DslInternals

/// A base class for components that display differing content depending on the user's authorization status.
type AuthorizeViewCoreBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    /// The content that will be displayed if the user is authorized.
    [<CustomOperation("ChildContent")>] member inline _.ChildContent ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    /// The content that will be displayed if the user is not authorized.
    [<CustomOperation("NotAuthorized")>] member inline _.NotAuthorized ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("NotAuthorized", fn)
    /// The content that will be displayed if the user is authorized.
    /// If you specify a value for this parameter, do not also specify a value for ChildContent.
    [<CustomOperation("Authorized")>] member inline _.Authorized ([<InlineIfLambda>] render: AttrRenderFragment, [<InlineIfLambda>] fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("Authorized", fn)
    /// The content that will be displayed while asynchronous authorization is in progress.
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, fragment: NodeRenderFragment) = render ==> html.renderFragment("Authorizing", fragment)
    /// The content that will be displayed while asynchronous authorization is in progress.
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, fragments: NodeRenderFragment seq) = render ==> html.renderFragment("Authorizing", fragment { yield! fragments })
    /// The content that will be displayed while asynchronous authorization is in progress.
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Authorizing", html.text x)
    /// The content that will be displayed while asynchronous authorization is in progress.
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Authorizing", html.text x)
    /// The content that will be displayed while asynchronous authorization is in progress.
    [<CustomOperation("Authorizing")>] member inline _.Authorizing ([<InlineIfLambda>] render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Authorizing", html.text x)
    /// The resource to which access is being controlled.
    [<CustomOperation("Resource")>] member inline _.Resource ([<InlineIfLambda>] render: AttrRenderFragment, x: System.Object) = render ==> ("Resource" => x)

/// Displays differing content depending on the user's authorization status.
type AuthorizeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AuthorizeViewCoreBuilder<'FunBlazorGeneric>()
    /// The policy name that determines whether the content can be displayed.
    [<CustomOperation("Policy")>] member inline _.Policy ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Policy" => x)
    /// A comma delimited list of roles that are allowed to display the content.
    [<CustomOperation("Roles")>] member inline _.Roles ([<InlineIfLambda>] render: AttrRenderFragment, x: System.String) = render ==> ("Roles" => x)

type CascadingAuthenticationStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()


            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module DslCE =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.Authorization.DslInternals


    /// A base class for components that display differing content depending on the user's authorization status.
    type AuthorizeViewCore' 
        /// A base class for components that display differing content depending on the user's authorization status.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>)>] () = inherit AuthorizeViewCoreBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>()

    /// Displays differing content depending on the user's authorization status.
    type AuthorizeView' 
        /// Displays differing content depending on the user's authorization status.
        [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>)>] () = inherit AuthorizeViewBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>()
    type CascadingAuthenticationState' [<DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>)>] () = inherit CascadingAuthenticationStateBuilder<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>()

[<AutoOpen>]
module DslCEInstances =
  
    open System.Diagnostics.CodeAnalysis
    open Microsoft.AspNetCore.Components.Authorization.DslInternals

    let AuthorizeViewCore'' = AuthorizeViewCore'()
    let AuthorizeView'' = AuthorizeView'()
    let CascadingAuthenticationState'' = CascadingAuthenticationState'()
            