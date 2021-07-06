namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open Microsoft.AspNetCore.Components.Authorization.DslInternals


type AuthorizeViewCoreBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AuthorizeViewCoreBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AuthorizeViewCoreBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AuthorizeViewCoreBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AuthorizeViewCoreBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AuthorizeViewCoreBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotAuthorized")>] member this.NotAuthorized (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NotAuthorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorized")>] member this.Authorized (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Authorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, nodes) = Bolero.Html.attr.fragment "Authorizing" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, x: string) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, x: int) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, x: float) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Resource")>] member this.Resource (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>, x: System.Object) = "Resource" => x |> BoleroAttr |> this.AddProp
                

type AuthorizeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AuthorizeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AuthorizeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AuthorizeViewBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AuthorizeViewBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AuthorizeViewBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Policy")>] member this.Policy (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: System.String) = "Policy" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Roles")>] member this.Roles (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: System.String) = "Roles" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotAuthorized")>] member this.NotAuthorized (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NotAuthorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorized")>] member this.Authorized (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Authorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, nodes) = Bolero.Html.attr.fragment "Authorizing" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: string) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: int) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: float) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Resource")>] member this.Resource (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>, x: System.Object) = "Resource" => x |> BoleroAttr |> this.AddProp
                

type CascadingAuthenticationStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Authorization.DslInternals

    type AuthorizeViewCore' = AuthorizeViewCoreBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>
    type AuthorizeView' = AuthorizeViewBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>
    type CascadingAuthenticationState' = CascadingAuthenticationStateBuilder<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>
            