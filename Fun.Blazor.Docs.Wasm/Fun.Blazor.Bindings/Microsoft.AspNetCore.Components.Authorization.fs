namespace rec Microsoft.AspNetCore.Components.Authorization.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open Microsoft.AspNetCore.Components.Authorization.DslInternals


type authorizeViewCore<'FunBlazorGeneric> =
    
    static member inline create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>
    static member inline create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>
    static member inline create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore>
    static member inline ref x = attr.ref<Microsoft.AspNetCore.Components.Authorization.AuthorizeViewCore> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notAuthorized (render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NotAuthorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorized (render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Authorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorizing (x: string) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorizing (node) = Bolero.Html.attr.fragment "Authorizing" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorizing (nodes) = Bolero.Html.attr.fragment "Authorizing" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline resource (x: System.Object) = "Resource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type authorizeView<'FunBlazorGeneric> =
    inherit authorizeViewCore<'FunBlazorGeneric>
    static member inline create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>
    static member inline create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>
    static member inline create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>
    static member inline ref x = attr.ref<Microsoft.AspNetCore.Components.Authorization.AuthorizeView> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline policy (x: System.String) = "Policy" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline roles (x: System.String) = "Roles" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline notAuthorized (render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NotAuthorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorized (render: Microsoft.AspNetCore.Components.Authorization.AuthenticationState -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Authorized" (fun x -> render x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorizing (x: string) = Bolero.Html.attr.fragment "Authorizing" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorizing (node) = Bolero.Html.attr.fragment "Authorizing" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline authorizing (nodes) = Bolero.Html.attr.fragment "Authorizing" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline resource (x: System.Object) = "Resource" => x |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    

type cascadingAuthenticationState<'FunBlazorGeneric> =
    
    static member inline create () = [] |> html.blazor<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>
    static member inline create (nodes: GenericFunBlazorNode<'FunBlazorGeneric> list) = nodes |> List.map (fun x -> x.Node) |> html.blazor<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>
    static member inline create (nodes: IFunBlazorNode list) = nodes |> html.blazor<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>
    static member inline create (node: IFunBlazorNode) = [ node ] |> html.blazor<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>
    static member inline ref x = attr.ref<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState> x |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (node) = Bolero.Html.attr.fragment "ChildContent" (html.toBolero node) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
    static member inline childContent (nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> GenericFunBlazorNode<'FunBlazorGeneric>.create
                    
            

// =======================================================================================================================

namespace Microsoft.AspNetCore.Components.Authorization

open Microsoft.AspNetCore.Components.Authorization.DslInternals


type IAuthorizeViewCoreNode = interface end
type authorizeViewCore =
    class
        inherit authorizeViewCore<IAuthorizeViewCoreNode>
    end
                    

type IAuthorizeViewNode = interface end
type authorizeView =
    class
        inherit authorizeView<IAuthorizeViewNode>
    end
                    

type ICascadingAuthenticationStateNode = interface end
type cascadingAuthenticationState =
    class
        inherit cascadingAuthenticationState<ICascadingAuthenticationStateNode>
    end
                    
            