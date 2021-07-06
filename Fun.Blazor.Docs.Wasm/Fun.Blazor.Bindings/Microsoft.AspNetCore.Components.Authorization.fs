namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Microsoft.AspNetCore.Components.Authorization.DslInternals


type AuthorizeViewCoreBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AuthorizeViewCoreBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AuthorizeViewCoreBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AuthorizeViewCoreBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AuthorizeViewCoreBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AuthorizeViewCoreBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("notAuthorized")>] member this.notAuthorized (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NotAuthorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorized")>] member this.authorized (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Authorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorizing")>] member this.authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, nodes) = Bolero.Html.attr.fragment "Authorizing" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorizing")>] member this.authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, x: string) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorizing")>] member this.authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, x: int) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorizing")>] member this.authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, x: float) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("resource")>] member this.resource (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, x: System.Object) = "Resource" => x |> BoleroAttr |> this.AddProp
                

type AuthorizeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AuthorizeViewCoreBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AuthorizeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AuthorizeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AuthorizeViewBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AuthorizeViewBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AuthorizeViewBuilder<'FunBlazorGeneric>()

    [<CustomOperation("policy")>] member this.policy (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: System.String) = "Policy" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("roles")>] member this.roles (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: System.String) = "Roles" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("notAuthorized")>] member this.notAuthorized (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NotAuthorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorized")>] member this.authorized (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Authorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorizing")>] member this.authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, nodes) = Bolero.Html.attr.fragment "Authorizing" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorizing")>] member this.authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: string) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorizing")>] member this.authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: int) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorizing")>] member this.authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: float) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("resource")>] member this.resource (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: System.Object) = "Resource" => x |> BoleroAttr |> this.AddProp
                

type CascadingAuthenticationStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Authorization.DslInternals

    type authorizeViewCore = AuthorizeViewCoreBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>
    type authorizeView = AuthorizeViewBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>
    type cascadingAuthenticationState = CascadingAuthenticationStateBuilder<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>
            