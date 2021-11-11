namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open Microsoft.AspNetCore.Components.Authorization.DslInternals


type AuthorizeViewCoreBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = AuthorizeViewCoreBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotAuthorized")>] member this.NotAuthorized (_: FunBlazorContext<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NotAuthorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorized")>] member this.Authorized (_: FunBlazorContext<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Authorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Authorizing" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Resource")>] member this.Resource (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Resource" => x |> BoleroAttr |> this.AddProp
                

type AuthorizeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AuthorizeViewCoreBuilder<'FunBlazorGeneric>()
    static member create () = AuthorizeViewBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Policy")>] member this.Policy (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Policy" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Roles")>] member this.Roles (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Roles" => x |> BoleroAttr |> this.AddProp
                

type CascadingAuthenticationStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Authorization.DslInternals

    type AuthorizeViewCore' = AuthorizeViewCoreBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>
    type AuthorizeView' = AuthorizeViewBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>
    type CascadingAuthenticationState' = CascadingAuthenticationStateBuilder<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>
            