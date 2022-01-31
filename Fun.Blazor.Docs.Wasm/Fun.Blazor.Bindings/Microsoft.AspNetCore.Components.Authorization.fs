namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.Authorization.DslInternals


type AuthorizeViewCoreBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("ChildContent")>] member inline _.ChildContent (render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("NotAuthorized")>] member inline _.NotAuthorized (render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("NotAuthorized", fn)
    [<CustomOperation("Authorized")>] member inline _.Authorized (render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("Authorized", fn)
    [<CustomOperation("Authorizing")>] member inline _.Authorizing (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Authorizing", fragment)
    [<CustomOperation("Authorizing")>] member inline _.Authorizing (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Authorizing", html.text x)
    [<CustomOperation("Authorizing")>] member inline _.Authorizing (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Authorizing", html.text x)
    [<CustomOperation("Authorizing")>] member inline _.Authorizing (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Authorizing", html.text x)
    [<CustomOperation("Resource")>] member inline _.Resource (render: AttrRenderFragment, x: System.Object) = render ==> ("Resource" => x)
                

type AuthorizeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AuthorizeViewCoreBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Policy")>] member inline _.Policy (render: AttrRenderFragment, x: System.String) = render ==> ("Policy" => x)
    [<CustomOperation("Roles")>] member inline _.Roles (render: AttrRenderFragment, x: System.String) = render ==> ("Roles" => x)
                

type CascadingAuthenticationStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                
            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Authorization.DslInternals

    let AuthorizeViewCore' = AuthorizeViewCoreBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>()
    let AuthorizeView' = AuthorizeViewBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>()
    let CascadingAuthenticationState' = CascadingAuthenticationStateBuilder<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>()
            