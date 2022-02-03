namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.Authorization.DslInternals


type AuthorizeViewCoreBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(AuthorizeViewCoreBuilder<'FunBlazorGeneric>())
    [<CustomOperation("ChildContent")>] member _.ChildContent (render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("ChildContent", fn)
    [<CustomOperation("NotAuthorized")>] member _.NotAuthorized (render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("NotAuthorized", fn)
    [<CustomOperation("Authorized")>] member _.Authorized (render: AttrRenderFragment, fn: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> NodeRenderFragment) = render ==> html.renderFragment("Authorized", fn)
    [<CustomOperation("Authorizing")>] member _.Authorizing (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Authorizing", fragment)
    [<CustomOperation("Authorizing")>] member _.Authorizing (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Authorizing", fragment { yield! fragments })
    [<CustomOperation("Authorizing")>] member _.Authorizing (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Authorizing", html.text x)
    [<CustomOperation("Authorizing")>] member _.Authorizing (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Authorizing", html.text x)
    [<CustomOperation("Authorizing")>] member _.Authorizing (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Authorizing", html.text x)
    [<CustomOperation("Resource")>] member _.Resource (render: AttrRenderFragment, x: System.Object) = render ==> ("Resource" => x)
                

type AuthorizeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AuthorizeViewCoreBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(AuthorizeViewBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Policy")>] member _.Policy (render: AttrRenderFragment, x: System.String) = render ==> ("Policy" => x)
    [<CustomOperation("Roles")>] member _.Roles (render: AttrRenderFragment, x: System.String) = render ==> ("Roles" => x)
                

type CascadingAuthenticationStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                
            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Authorization.DslInternals

    type AuthorizeViewCore'() = inherit AuthorizeViewCoreBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>()
    type AuthorizeView'() = inherit AuthorizeViewBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>()
    type CascadingAuthenticationState'() = inherit CascadingAuthenticationStateBuilder<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>()
            