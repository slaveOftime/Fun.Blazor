namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open Microsoft.AspNetCore.Components.Authorization.DslInternals


type AuthorizeViewCoreBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = AuthorizeViewCoreBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("NotAuthorized")>] member this.NotAuthorized (_: FunBlazorBuilder<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> Bolero.Node) = Bolero.Html.attr.fragmentWith "NotAuthorized" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Authorized")>] member this.Authorized (_: FunBlazorBuilder<'FunBlazorGeneric>, render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Authorized" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Authorizing" nodes |> this.AddAttr
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Authorizing" (html.text x) |> this.AddAttr
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Authorizing" (html.text x) |> this.AddAttr
    [<CustomOperation("Authorizing")>] member this.Authorizing (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Authorizing" (html.text x) |> this.AddAttr
    [<CustomOperation("Resource")>] member this.Resource (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Resource" => x |> this.AddAttr
                

type AuthorizeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AuthorizeViewCoreBuilder<'FunBlazorGeneric>()
    static member create () = AuthorizeViewBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Policy")>] member this.Policy (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Policy" => x |> this.AddAttr
    [<CustomOperation("Roles")>] member this.Roles (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Roles" => x |> this.AddAttr
                

type CascadingAuthenticationStateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = CascadingAuthenticationStateBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" nodes |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
                
            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

[<AutoOpen>]
module DslCE =

    open Microsoft.AspNetCore.Components.Authorization.DslInternals

    type AuthorizeViewCore' = AuthorizeViewCoreBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>
    type AuthorizeView' = AuthorizeViewBuilder<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>
    type CascadingAuthenticationState' = CascadingAuthenticationStateBuilder<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>
            