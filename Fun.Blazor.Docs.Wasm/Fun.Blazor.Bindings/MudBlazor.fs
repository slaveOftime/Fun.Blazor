namespace rec MudBlazor.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open MudBlazor.DslInternals


type MudComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudComponentBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudComponentBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudComponentBase>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBaseButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudBaseButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudBaseButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonType")>] member this.ButtonType (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudBaseButton>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("StartIcon")>] member this.StartIcon (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "StartIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconClass")>] member this.IconClass (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "IconClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudButton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudButton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudButton>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudButton>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonType")>] member this.ButtonType (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudButton>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudFabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudFabBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudFabBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonType")>] member this.ButtonType (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudFab>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudFab>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudFab>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudIconButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudIconButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudIconButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudIconButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudIconButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudIconButton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudIconButton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudIconButton>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudIconButton>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonType")>] member this.ButtonType (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudIconButton>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudIconButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudIconButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudMenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StartIcon")>] member this.StartIcon (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "StartIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PositionAtCurser")>] member this.PositionAtCurser (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "PositionAtCurser" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorContext<MudBlazor.MudMenu>, nodes) = Bolero.Html.attr.fragment "ActivatorContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorContext<MudBlazor.MudMenu>, x: string) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorContext<MudBlazor.MudMenu>, x: int) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorContext<MudBlazor.MudMenu>, x: float) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivationEvent")>] member this.ActivationEvent (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.MouseEvent) = "ActivationEvent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMenu>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMenu>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMenu>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMenu>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonType")>] member this.ButtonType (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudMenu>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudMenu>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudMenu>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudFileUploaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudFileUploaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudFileUploaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonType")>] member this.ButtonType (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudFileUploader>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBaseItemsControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseItemsControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBaseItemsControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudBaseItemsControlBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudBaseItemsControlBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudBaseItemsControlBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ItemsSource")>] member this.ItemsSource (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: System.Collections.Generic.IEnumerable<'TData>) = "ItemsSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, render: 'TData -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCarouselBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudCarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCarouselBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCarouselBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudCarouselBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ShowArrows")>] member this.ShowArrows (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Boolean) = "ShowArrows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowDelimiters")>] member this.ShowDelimiters (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Boolean) = "ShowDelimiters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoCycle")>] member this.AutoCycle (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Boolean) = "AutoCycle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoCycleTime")>] member this.AutoCycleTime (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.TimeSpan) = "AutoCycleTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, nodes) = Bolero.Html.attr.fragment "NextButtonTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: string) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: int) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: float) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, nodes) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: string) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: int) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: float) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DelimiterTemplate")>] member this.DelimiterTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, render: System.Boolean -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "DelimiterTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemsSource")>] member this.ItemsSource (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Collections.Generic.IEnumerable<'TData>) = "ItemsSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, render: 'TData -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBaseSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBaseSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudBaseSelectItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudBaseSelectItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudBaseSelectItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudNavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudNavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudNavLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudNavLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudNavLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudNavLink>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Match")>] member this.Match (_: FunBlazorContext<MudBlazor.MudNavLink>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavLink>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavLink>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavLink>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavLink>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudNavLink>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudNavLink>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudNavLink>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSelectItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSelectItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudSelectItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudFormComponentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudFormComponentBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudFormComponentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: MudBlazor.Converter<'T, 'U>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBaseInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudBaseInputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudBaseInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudAutocompleteBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudAutocompleteBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudAutocompleteBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenIcon")>] member this.OpenIcon (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "OpenIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Int32) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToStringFunc")>] member this.ToStringFunc (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Func<'T, System.String>) = "ToStringFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SearchFunc")>] member this.SearchFunc (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>) = "SearchFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxItems")>] member this.MaxItems (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Nullable<System.Int32>) = "MaxItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinCharacters")>] member this.MinCharacters (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Int32) = "MinCharacters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ResetValueOnEmptyText")>] member this.ResetValueOnEmptyText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "ResetValueOnEmptyText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Int32) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemSelectedTemplate")>] member this.ItemSelectedTemplate (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemSelectedTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CoerceText")>] member this.CoerceText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "CoerceText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CoerceValue")>] member this.CoerceValue (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "CoerceValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsOpenChanged")>] member this.IsOpenChanged (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsOpenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDebouncedInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudDebouncedInputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudDebouncedInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDebounceIntervalElapsed")>] member this.OnDebounceIntervalElapsed (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudNumericFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudNumericFieldBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudNumericFieldBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: 'T) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: 'T) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: 'T) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSpinButtons")>] member this.HideSpinButtons (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "HideSpinButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDebounceIntervalElapsed")>] member this.OnDebounceIntervalElapsed (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTextFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudTextFieldBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudTextFieldBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDebounceIntervalElapsed")>] member this.OnDebounceIntervalElapsed (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTextFieldStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudTextFieldStringBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudTextFieldStringBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDebounceIntervalElapsed")>] member this.OnDebounceIntervalElapsed (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Converter<System.String, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudInputBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudInputBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudInputBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInput<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnIncrement")>] member this.OnIncrement (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnIncrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDecrement")>] member this.OnDecrement (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnDecrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSpinButtons")>] member this.HideSpinButtons (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "HideSpinButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudInputStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudInputStringBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputStringBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudInputStringBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudInputStringBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudInputStringBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputString>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputString>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputString>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputString>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnIncrement")>] member this.OnIncrement (_: FunBlazorContext<MudBlazor.MudInputString>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnIncrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDecrement")>] member this.OnDecrement (_: FunBlazorContext<MudBlazor.MudInputString>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnDecrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSpinButtons")>] member this.HideSpinButtons (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "HideSpinButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Converter<System.String, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudInputString>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudInputString>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudRangeInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudRangeInputBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRangeInputBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudRangeInputBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudRangeInputBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudRangeInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PlaceholderStart")>] member this.PlaceholderStart (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "PlaceholderStart" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlaceholderEnd")>] member this.PlaceholderEnd (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "PlaceholderEnd" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<MudBlazor.Range<'T>> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Range<'T>) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Converter<MudBlazor.Range<'T>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<MudBlazor.Range<'T>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudSelectBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSelectBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSelectBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSelectBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudSelectBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenIcon")>] member this.OpenIcon (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "OpenIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValuesChanged")>] member this.SelectedValuesChanged (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiSelectionTextFunc")>] member this.MultiSelectionTextFunc (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Func<System.Collections.Generic.List<System.String>, System.String>) = "MultiSelectionTextFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValues")>] member this.SelectedValues (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Collections.Generic.HashSet<'T>) = "SelectedValues" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToStringFunc")>] member this.ToStringFunc (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Func<'T, System.String>) = "ToStringFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Int32) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Strict")>] member this.Strict (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Strict" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBooleanInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudBooleanInputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudBooleanInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: 'T) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, fn) = (Bolero.Html.attr.callback<'T> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: MudBlazor.Converter<'T, System.Nullable<System.Boolean>>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCheckBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudCheckBoxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCheckBoxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCheckBoxBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCheckBoxBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudCheckBoxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedIcon")>] member this.CheckedIcon (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "CheckedIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UncheckedIcon")>] member this.UncheckedIcon (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "UncheckedIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IndeterminateIcon")>] member this.IndeterminateIcon (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "IndeterminateIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriState")>] member this.TriState (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "TriState" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: 'T) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, fn) = (Bolero.Html.attr.callback<'T> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: MudBlazor.Converter<'T, System.Nullable<System.Boolean>>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudSwitchBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSwitchBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSwitchBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSwitchBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudSwitchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: 'T) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, fn) = (Bolero.Html.attr.callback<'T> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: MudBlazor.Converter<'T, System.Nullable<System.Boolean>>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("InputIcon")>] member this.InputIcon (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerOpened")>] member this.PickerOpened (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerClosed")>] member this.PickerClosed (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarClass")>] member this.ToolBarClass (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerVariant")>] member this.PickerVariant (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputVariant")>] member this.InputVariant (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowKeyboardInput")>] member this.AllowKeyboardInput (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: int) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: float) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBaseDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudBaseDatePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudBaseDatePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("MaxDate")>] member this.MaxDate (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DateTime>) = "MaxDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinDate")>] member this.MinDate (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DateTime>) = "MinDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenTo")>] member this.OpenTo (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateFormat")>] member this.DateFormat (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "DateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FirstDayOfWeek")>] member this.FirstDayOfWeek (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerMonth")>] member this.PickerMonth (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DateTime>) = "PickerMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerMonthChanged")>] member this.PickerMonthChanged (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosingDelay")>] member this.ClosingDelay (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Int32) = "ClosingDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisplayMonths")>] member this.DisplayMonths (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Int32) = "DisplayMonths" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxMonthColumns")>] member this.MaxMonthColumns (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.Int32>) = "MaxMonthColumns" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StartMonth")>] member this.StartMonth (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DateTime>) = "StartMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowWeekNumbers")>] member this.ShowWeekNumbers (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "ShowWeekNumbers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleDateFormat")>] member this.TitleDateFormat (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "TitleDateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputIcon")>] member this.InputIcon (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerOpened")>] member this.PickerOpened (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerClosed")>] member this.PickerClosed (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarClass")>] member this.ToolBarClass (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerVariant")>] member this.PickerVariant (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputVariant")>] member this.InputVariant (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowKeyboardInput")>] member this.AllowKeyboardInput (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: int) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: float) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Converter<System.Nullable<System.DateTime>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudDatePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudDatePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DateChanged")>] member this.DateChanged (_: FunBlazorContext<MudBlazor.MudDatePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "DateChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Date")>] member this.Date (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "Date" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoClose")>] member this.AutoClose (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "AutoClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxDate")>] member this.MaxDate (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "MaxDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinDate")>] member this.MinDate (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "MinDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenTo")>] member this.OpenTo (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateFormat")>] member this.DateFormat (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "DateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FirstDayOfWeek")>] member this.FirstDayOfWeek (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerMonth")>] member this.PickerMonth (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "PickerMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerMonthChanged")>] member this.PickerMonthChanged (_: FunBlazorContext<MudBlazor.MudDatePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosingDelay")>] member this.ClosingDelay (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Int32) = "ClosingDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisplayMonths")>] member this.DisplayMonths (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Int32) = "DisplayMonths" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxMonthColumns")>] member this.MaxMonthColumns (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.Int32>) = "MaxMonthColumns" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StartMonth")>] member this.StartMonth (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "StartMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowWeekNumbers")>] member this.ShowWeekNumbers (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "ShowWeekNumbers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleDateFormat")>] member this.TitleDateFormat (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "TitleDateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputIcon")>] member this.InputIcon (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerOpened")>] member this.PickerOpened (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerClosed")>] member this.PickerClosed (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarClass")>] member this.ToolBarClass (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerVariant")>] member this.PickerVariant (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputVariant")>] member this.InputVariant (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowKeyboardInput")>] member this.AllowKeyboardInput (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudDatePicker>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudDatePicker>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: int) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: float) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Converter<System.Nullable<System.DateTime>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudDateRangePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudDateRangePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DateRangeChanged")>] member this.DateRangeChanged (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, fn) = (Bolero.Html.attr.callback<MudBlazor.DateRange> "DateRangeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRange")>] member this.DateRange (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.DateRange) = "DateRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxDate")>] member this.MaxDate (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DateTime>) = "MaxDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinDate")>] member this.MinDate (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DateTime>) = "MinDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenTo")>] member this.OpenTo (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateFormat")>] member this.DateFormat (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "DateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FirstDayOfWeek")>] member this.FirstDayOfWeek (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerMonth")>] member this.PickerMonth (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DateTime>) = "PickerMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerMonthChanged")>] member this.PickerMonthChanged (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosingDelay")>] member this.ClosingDelay (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Int32) = "ClosingDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisplayMonths")>] member this.DisplayMonths (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Int32) = "DisplayMonths" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxMonthColumns")>] member this.MaxMonthColumns (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.Int32>) = "MaxMonthColumns" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StartMonth")>] member this.StartMonth (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DateTime>) = "StartMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowWeekNumbers")>] member this.ShowWeekNumbers (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "ShowWeekNumbers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleDateFormat")>] member this.TitleDateFormat (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "TitleDateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputIcon")>] member this.InputIcon (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerOpened")>] member this.PickerOpened (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerClosed")>] member this.PickerClosed (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarClass")>] member this.ToolBarClass (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerVariant")>] member this.PickerVariant (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputVariant")>] member this.InputVariant (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowKeyboardInput")>] member this.AllowKeyboardInput (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: int) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: float) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Converter<System.Nullable<System.DateTime>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudTimePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudTimePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OpenTo")>] member this.OpenTo (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TimeEditMode")>] member this.TimeEditMode (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.TimeEditMode) = "TimeEditMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AmPm")>] member this.AmPm (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "AmPm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TimeFormat")>] member this.TimeFormat (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "TimeFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Time")>] member this.Time (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Nullable<System.TimeSpan>) = "Time" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TimeChanged")>] member this.TimeChanged (_: FunBlazorContext<MudBlazor.MudTimePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.TimeSpan>> "TimeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputIcon")>] member this.InputIcon (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerOpened")>] member this.PickerOpened (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerClosed")>] member this.PickerClosed (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarClass")>] member this.ToolBarClass (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerVariant")>] member this.PickerVariant (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputVariant")>] member this.InputVariant (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowKeyboardInput")>] member this.AllowKeyboardInput (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<MudBlazor.MudTimePicker>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudTimePicker>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: int) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: float) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Converter<System.Nullable<System.TimeSpan>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.TimeSpan>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudRadioGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudRadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudRadioGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudRadioGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudRadioGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedOption")>] member this.SelectedOption (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: 'T) = "SelectedOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedOptionChanged")>] member this.SelectedOptionChanged (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, fn) = (Bolero.Html.attr.callback<'T> "SelectedOptionChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: MudBlazor.Converter<'T, 'T>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For")>] member this.For (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudAlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudAlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudAlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudAlertBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoIcon")>] member this.NoIcon (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Boolean) = "NoIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Severity")>] member this.Severity (_: FunBlazorContext<MudBlazor.MudAlert>, x: MudBlazor.Severity) = "Severity" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudAlert>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAlert>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAlert>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAlert>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAlert>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudAlert>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudAlert>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudAlert>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudAppBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAppBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudAppBarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudAppBarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudAppBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudAppBar>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAppBar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAppBar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAppBar>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAppBar>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudAppBar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudAppBar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudAvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudAvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudAvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudAvatarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Image")>] member this.Image (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudAvatar>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudAvatar>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAvatar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAvatar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAvatar>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudAvatar>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudAvatar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudAvatar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudBadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudBadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudBadgeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudBadge>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bottom")>] member this.Bottom (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Bottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Left")>] member this.Left (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Left" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Start")>] member this.Start (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Start" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Dot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlap")>] member this.Overlap (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Overlap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Int32) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Object) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBadge>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBadge>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBadge>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudBadge>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBadge>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBadge>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudBreadcrumbsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudBreadcrumbsBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudBreadcrumbsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.Collections.Generic.List<MudBlazor.BreadcrumbItem>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Separator")>] member this.Separator (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.String) = "Separator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, nodes) = Bolero.Html.attr.fragment "SeparatorTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: string) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: int) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: float) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, render: MudBlazor.BreadcrumbItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxItems")>] member this.MaxItems (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.Nullable<System.Byte>) = "MaxItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudButtonGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OverrideStyles")>] member this.OverrideStyles (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Boolean) = "OverrideStyles" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudButtonGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("VerticalAlign")>] member this.VerticalAlign (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Boolean) = "VerticalAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudToggleIconButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudToggleIconButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Toggled")>] member this.Toggled (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Boolean) = "Toggled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledChanged")>] member this.ToggledChanged (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ToggledChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledIcon")>] member this.ToggledIcon (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.String) = "ToggledIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledTitle")>] member this.ToggledTitle (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.String) = "ToggledTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledColor")>] member this.ToggledColor (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Color) = "ToggledColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledSize")>] member this.ToggledSize (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Size) = "ToggledSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudCardBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCard>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCard>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCard>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCard>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCard>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCard>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCardActionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudCardActionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardActionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCardActionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCardActionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudCardActionsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardActions>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardActions>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardActions>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardActions>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCardActions>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCardActions>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCardActions>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCardContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudCardContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCardContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCardContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudCardContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardContent>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardContent>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardContent>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardContent>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCardContent>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCardContent>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCardContent>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCardHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudCardHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCardHeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCardHeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudCardHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorContext<MudBlazor.MudCardHeader>, nodes) = Bolero.Html.attr.fragment "CardHeaderAvatar" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: int) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: float) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, nodes) = Bolero.Html.attr.fragment "CardHeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: int) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: float) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorContext<MudBlazor.MudCardHeader>, nodes) = Bolero.Html.attr.fragment "CardHeaderActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: int) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: float) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCardMediaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudCardMediaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudCardMediaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Image")>] member this.Image (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.Int32) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudCarouselItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCarouselItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCarouselItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCarouselItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudCarouselItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCarouselItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Transition")>] member this.Transition (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: MudBlazor.Transition) = "Transition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomTransitionEnter")>] member this.CustomTransitionEnter (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: System.String) = "CustomTransitionEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomTransitionExit")>] member this.CustomTransitionExit (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: System.String) = "CustomTransitionExit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudChartBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudChartBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorContext<MudBlazor.MudChartBase>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorContext<MudBlazor.MudChartBase>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorContext<MudBlazor.MudChartBase>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.MudChartBase>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudChartBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudChartBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudChartBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudChartBuilder<'FunBlazorGeneric>()

    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorContext<MudBlazor.MudChart>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorContext<MudBlazor.MudChart>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorContext<MudBlazor.MudChart>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorContext<MudBlazor.MudChart>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.MudChart>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudChart>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorContext<MudBlazor.MudChart>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.MudChart>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudChart>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudChart>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals.Charts

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open MudBlazor.DslInternals


type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = BarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = BarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Bar>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = DonutBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DonutBuilder<'FunBlazorGeneric>()

    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Donut>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = LineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = LineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorContext<MudBlazor.Charts.Line>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorContext<MudBlazor.Charts.Line>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorContext<MudBlazor.Charts.Line>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Line>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.Charts.Line>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.Charts.Line>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = PieBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PieBuilder<'FunBlazorGeneric>()

    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Pie>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = LegendBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = LegendBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Legend>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open MudBlazor.DslInternals


type MudChipSetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudChipSetBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudChipSetBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudChipSetBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudChipSetBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudChipSetBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudChipSet>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudChipSet>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudChipSet>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudChipSet>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mandatory")>] member this.Mandatory (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Boolean) = "Mandatory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllClosable")>] member this.AllClosable (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Boolean) = "AllClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Filter")>] member this.Filter (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Boolean) = "Filter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChip")>] member this.SelectedChip (_: FunBlazorContext<MudBlazor.MudChipSet>, x: MudBlazor.MudChip) = "SelectedChip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChipChanged")>] member this.SelectedChipChanged (_: FunBlazorContext<MudBlazor.MudChipSet>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "SelectedChipChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChips")>] member this.SelectedChips (_: FunBlazorContext<MudBlazor.MudChipSet>, x: MudBlazor.MudChip[]) = "SelectedChips" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChipsChanged")>] member this.SelectedChipsChanged (_: FunBlazorContext<MudBlazor.MudChipSet>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip[]> "SelectedChipsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<MudBlazor.MudChipSet>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudChipSet>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudChipSet>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudChipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudChipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudChipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudChipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudChipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudChipBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudChip>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudChip>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudChip>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarClass")>] member this.AvatarClass (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "AvatarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudChip>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudChip>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudChip>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudChip>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudChip>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ForceLoad")>] member this.ForceLoad (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Default")>] member this.Default (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "Default" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudChip>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<MudBlazor.MudChip>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudChip>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudChip>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudCollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudCollapseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<MudBlazor.MudCollapse>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudCollapse>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCollapse>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCollapse>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCollapse>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudCollapse>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAnimationEnd")>] member this.OnAnimationEnd (_: FunBlazorContext<MudBlazor.MudCollapse>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAnimationEnd" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<MudBlazor.MudCollapse>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudCollapse>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudCollapse>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudCollapse>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudDialogBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudDialogBuilder<'FunBlazorGeneric>()

    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudDialog>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudDialog>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudDialog>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudDialog>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorContext<MudBlazor.MudDialog>, nodes) = Bolero.Html.attr.fragment "DialogContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorContext<MudBlazor.MudDialog>, x: string) = Bolero.Html.attr.fragment "DialogContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorContext<MudBlazor.MudDialog>, x: int) = Bolero.Html.attr.fragment "DialogContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorContext<MudBlazor.MudDialog>, x: float) = Bolero.Html.attr.fragment "DialogContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorContext<MudBlazor.MudDialog>, nodes) = Bolero.Html.attr.fragment "DialogActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorContext<MudBlazor.MudDialog>, x: string) = Bolero.Html.attr.fragment "DialogActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorContext<MudBlazor.MudDialog>, x: int) = Bolero.Html.attr.fragment "DialogActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorContext<MudBlazor.MudDialog>, x: float) = Bolero.Html.attr.fragment "DialogActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableSidePadding")>] member this.DisableSidePadding (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.Boolean) = "DisableSidePadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassContent")>] member this.ClassContent (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.String) = "ClassContent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentStyle")>] member this.ContentStyle (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.String) = "ContentStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsVisible")>] member this.IsVisible (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.Boolean) = "IsVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsVisibleChanged")>] member this.IsVisibleChanged (_: FunBlazorContext<MudBlazor.MudDialog>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDialog>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDialog>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDialogInstanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudDialogInstanceBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudDialogInstanceBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: MudBlazor.DialogOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudDialogInstance>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudDialogInstance>, nodes) = Bolero.Html.attr.fragment "Content" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: int) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: float) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: System.Guid) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudDrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudDrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudDrawerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Anchor")>] member this.Anchor (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.Anchor) = "Anchor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.DrawerVariant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableOverlay")>] member this.DisableOverlay (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "DisableOverlay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreserveOpenState")>] member this.PreserveOpenState (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "PreserveOpenState" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenMiniOnHover")>] member this.OpenMiniOnHover (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "OpenMiniOnHover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenChanged")>] member this.OpenChanged (_: FunBlazorContext<MudBlazor.MudDrawer>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OpenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MiniWidth")>] member this.MiniWidth (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.String) = "MiniWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClipMode")>] member this.ClipMode (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.DrawerClipMode) = "ClipMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDrawer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDrawer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudDrawerContainerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudDrawerContainerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudDrawerContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudLayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudLayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudLayoutBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudLayoutBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudLayoutBuilder<'FunBlazorGeneric>()

    [<CustomOperation("RightToLeft")>] member this.RightToLeft (_: FunBlazorContext<MudBlazor.MudLayout>, x: System.Boolean) = "RightToLeft" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudLayout>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudLayout>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudLayout>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudLayout>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudLayout>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudLayout>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudLayout>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudElementBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudElement>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudElement>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudElement>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudElement>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<MudBlazor.MudElement>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ref")>] member this.Ref (_: FunBlazorContext<MudBlazor.MudElement>, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "Ref" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefChanged")>] member this.RefChanged (_: FunBlazorContext<MudBlazor.MudElement>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudElement>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudElement>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudElement>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudExpansionPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudExpansionPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudExpansionPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudExpansionPanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudExpansionPanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudExpansionPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideIcon")>] member this.HideIcon (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "HideIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsExpandedChanged")>] member this.IsExpandedChanged (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsExpanded")>] member this.IsExpanded (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "IsExpanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudExpansionPanelsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudExpansionPanelsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudExpansionPanelsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudExpansionPanelsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudExpansionPanelsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiExpansion")>] member this.MultiExpansion (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "MultiExpansion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableBorders")>] member this.DisableBorders (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "DisableBorders" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudFieldBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudFieldBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudFieldBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudField>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudField>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudField>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudField>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudField>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudField>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<MudBlazor.MudField>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<MudBlazor.MudField>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<MudBlazor.MudField>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InnerPadding")>] member this.InnerPadding (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "InnerPadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudField>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudField>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudField>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudFocusTrapBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFocusTrapBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudFocusTrapBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudFocusTrapBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudFocusTrapBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudFocusTrap>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultFocus")>] member this.DefaultFocus (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: MudBlazor.DefaultFocus) = "DefaultFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudFormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudFormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudFormBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudForm>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudForm>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudForm>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudForm>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsValid")>] member this.IsValid (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Boolean) = "IsValid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsTouched")>] member this.IsTouched (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Boolean) = "IsTouched" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValidationDelay")>] member this.ValidationDelay (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Int32) = "ValidationDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuppressRenderingOnValidation")>] member this.SuppressRenderingOnValidation (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Boolean) = "SuppressRenderingOnValidation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuppressImplicitSubmission")>] member this.SuppressImplicitSubmission (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Boolean) = "SuppressImplicitSubmission" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsValidChanged")>] member this.IsValidChanged (_: FunBlazorContext<MudBlazor.MudForm>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsValidChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsTouchedChanged")>] member this.IsTouchedChanged (_: FunBlazorContext<MudBlazor.MudForm>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsTouchedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Errors")>] member this.Errors (_: FunBlazorContext<MudBlazor.MudForm>, x: System.String[]) = "Errors" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorsChanged")>] member this.ErrorsChanged (_: FunBlazorContext<MudBlazor.MudForm>, fn) = (Bolero.Html.attr.callback<System.String[]> "ErrorsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudForm>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudForm>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudHiddenBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudHiddenBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudHiddenBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudHiddenBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudHiddenBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<MudBlazor.MudHidden>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Invert")>] member this.Invert (_: FunBlazorContext<MudBlazor.MudHidden>, x: System.Boolean) = "Invert" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsHidden")>] member this.IsHidden (_: FunBlazorContext<MudBlazor.MudHidden>, x: System.Boolean) = "IsHidden" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsHiddenChanged")>] member this.IsHiddenChanged (_: FunBlazorContext<MudBlazor.MudHidden>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsHiddenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudHidden>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudHidden>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudHidden>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudHidden>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudHidden>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudHidden>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudHidden>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudIconBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudIconBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudIconBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudIcon>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudIcon>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ViewBox")>] member this.ViewBox (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.String) = "ViewBox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudIcon>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudIcon>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudIcon>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudIcon>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudIcon>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudIcon>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudInputControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudInputControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudInputControlBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudInputControlBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudInputControlBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputControl>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputControl>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputControl>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputControl>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorContext<MudBlazor.MudInputControl>, nodes) = Bolero.Html.attr.fragment "InputContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorContext<MudBlazor.MudInputControl>, x: string) = Bolero.Html.attr.fragment "InputContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorContext<MudBlazor.MudInputControl>, x: int) = Bolero.Html.attr.fragment "InputContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorContext<MudBlazor.MudInputControl>, x: float) = Bolero.Html.attr.fragment "InputContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudInputControl>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudInputControl>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudInputControl>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudInputControl>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudInputLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudInputLabelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudInputLabelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudInputLabelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputLabel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudLink>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Typo")>] member this.Typo (_: FunBlazorContext<MudBlazor.MudLink>, x: MudBlazor.Typo) = "Typo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorContext<MudBlazor.MudLink>, x: MudBlazor.Underline) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<MudBlazor.MudLink>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudLink>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudLink>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudLink>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudLink>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudLink>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudLink>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudLink>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudLink>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudLink>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudListBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudListBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudListBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudList>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudList>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudList>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudList>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clickable")>] member this.Clickable (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "Clickable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisablePadding")>] member this.DisablePadding (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "DisablePadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorContext<MudBlazor.MudList>, x: MudBlazor.MudListItem) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItemChanged")>] member this.SelectedItemChanged (_: FunBlazorContext<MudBlazor.MudList>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudListItem> "SelectedItemChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudList>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudList>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudList>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudListItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarClass")>] member this.AvatarClass (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "AvatarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudListItem>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Inset")>] member this.Inset (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "Inset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<MudBlazor.MudListItem>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InitiallyExpanded")>] member this.InitiallyExpanded (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "InitiallyExpanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudListItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudListItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudListItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudListItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorContext<MudBlazor.MudListItem>, nodes) = Bolero.Html.attr.fragment "NestedList" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorContext<MudBlazor.MudListItem>, x: string) = Bolero.Html.attr.fragment "NestedList" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorContext<MudBlazor.MudListItem>, x: int) = Bolero.Html.attr.fragment "NestedList" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorContext<MudBlazor.MudListItem>, x: float) = Bolero.Html.attr.fragment "NestedList" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudListItem>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudListItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudListItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudListSubheaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListSubheaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudListSubheaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudListSubheaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudListSubheaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudListSubheader>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Inset")>] member this.Inset (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: System.Boolean) = "Inset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudMenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudMenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudMenuItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMenuItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ForceLoad")>] member this.ForceLoad (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudMenuItem>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudMessageBoxBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudMessageBoxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Message")>] member this.Message (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "MessageContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "MessageContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: int) = Bolero.Html.attr.fragment "MessageContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: float) = Bolero.Html.attr.fragment "MessageContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelText")>] member this.CancelText (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "CancelButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "CancelButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: int) = Bolero.Html.attr.fragment "CancelButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: float) = Bolero.Html.attr.fragment "CancelButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoText")>] member this.NoText (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "NoText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "NoButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "NoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: int) = Bolero.Html.attr.fragment "NoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: float) = Bolero.Html.attr.fragment "NoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesText")>] member this.YesText (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "YesText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "YesButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "YesButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: int) = Bolero.Html.attr.fragment "YesButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: float) = Bolero.Html.attr.fragment "YesButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnYes")>] member this.OnYes (_: FunBlazorContext<MudBlazor.MudMessageBox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnYes" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnNo")>] member this.OnNo (_: FunBlazorContext<MudBlazor.MudMessageBox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnNo" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancel")>] member this.OnCancel (_: FunBlazorContext<MudBlazor.MudMessageBox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsVisible")>] member this.IsVisible (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.Boolean) = "IsVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsVisibleChanged")>] member this.IsVisibleChanged (_: FunBlazorContext<MudBlazor.MudMessageBox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudNavGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudNavGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudNavGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudNavGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudNavGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<MudBlazor.MudNavGroup>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideExpandIcon")>] member this.HideExpandIcon (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Boolean) = "HideExpandIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIcon")>] member this.ExpandIcon (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.String) = "ExpandIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudNavMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudNavMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudNavMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudNavMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudNavMenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavMenu>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudOverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudOverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudOverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudOverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudOverlayBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudOverlay>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudOverlay>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudOverlay>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudOverlay>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("VisibleChanged")>] member this.VisibleChanged (_: FunBlazorContext<MudBlazor.MudOverlay>, fn) = (Bolero.Html.attr.callback<System.Boolean> "VisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoClose")>] member this.AutoClose (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "AutoClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LockScroll")>] member this.LockScroll (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "LockScroll" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LockScrollClass")>] member this.LockScrollClass (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.String) = "LockScrollClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DarkBackground")>] member this.DarkBackground (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "DarkBackground" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LightBackground")>] member this.LightBackground (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "LightBackground" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Absolute")>] member this.Absolute (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "Absolute" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ZIndex")>] member this.ZIndex (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudOverlay>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudOverlay>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudOverlay>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudPopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudPopoverBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudPopoverBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudPopoverBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<MudBlazor.MudPopover>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPopover>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPopover>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPopover>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPopover>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudPopover>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudPopover>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudProgressCircularBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudProgressCircularBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Minimum")>] member this.Minimum (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Minimum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Maximum")>] member this.Maximum (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Maximum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudProgressLinearBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudProgressLinearBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Buffer")>] member this.Buffer (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Boolean) = "Buffer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Static")>] member this.Static (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Boolean) = "Static" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BufferValue")>] member this.BufferValue (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "BufferValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Minimum")>] member this.Minimum (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Minimum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Maximum")>] member this.Maximum (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Maximum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudRadioBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudRadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudRadioBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudRadioBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudRadioBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: MudBlazor.Placement) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Option")>] member this.Option (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: 'T) = "Option" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudRatingBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudRatingBuilder<'FunBlazorGeneric>()

    [<CustomOperation("RatingItemsClass")>] member this.RatingItemsClass (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "RatingItemsClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RatingItemsStyle")>] member this.RatingItemsStyle (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "RatingItemsStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxValue")>] member this.MaxValue (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Int32) = "MaxValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullIcon")>] member this.FullIcon (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "FullIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EmptyIcon")>] member this.EmptyIcon (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "EmptyIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudRating>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudRating>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValueChanged")>] member this.SelectedValueChanged (_: FunBlazorContext<MudBlazor.MudRating>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValue")>] member this.SelectedValue (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Int32) = "SelectedValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HoveredValueChanged")>] member this.HoveredValueChanged (_: FunBlazorContext<MudBlazor.MudRating>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "HoveredValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudRating>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudRating>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudRatingItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudRatingItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ItemValue")>] member this.ItemValue (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Int32) = "ItemValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemClicked")>] member this.ItemClicked (_: FunBlazorContext<MudBlazor.MudRatingItem>, fn) = (Bolero.Html.attr.callback<System.Int32> "ItemClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemHovered")>] member this.ItemHovered (_: FunBlazorContext<MudBlazor.MudRatingItem>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "ItemHovered" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudScrollToTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudScrollToTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudScrollToTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudScrollToTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudScrollToTopBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudScrollToTop>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Selector")>] member this.Selector (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.String) = "Selector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("VisibleCssClass")>] member this.VisibleCssClass (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.String) = "VisibleCssClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenCssClass")>] member this.HiddenCssClass (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.String) = "HiddenCssClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TopOffset")>] member this.TopOffset (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.Int32) = "TopOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollBehavior")>] member this.ScrollBehavior (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: MudBlazor.ScrollBehavior) = "ScrollBehavior" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnScroll")>] member this.OnScroll (_: FunBlazorContext<MudBlazor.MudScrollToTop>, fn) = (Bolero.Html.attr.callback<MudBlazor.ScrollEventArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudSkeletonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudSkeletonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SkeletonType")>] member this.SkeletonType (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: MudBlazor.SkeletonType) = "SkeletonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Animation")>] member this.Animation (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: MudBlazor.Animation) = "Animation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSliderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudSliderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSliderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSliderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSliderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudSliderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: 'T) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: 'T) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: 'T) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: MudBlazor.Converter<'T>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSnackbarElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudSnackbarElementBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudSnackbarElementBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Snackbar")>] member this.Snackbar (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: MudBlazor.Snackbar) = "Snackbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSnackbarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudSnackbarProviderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudSnackbarProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSnackbarProvider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSnackbarProvider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSnackbarProvider>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudSwipeAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSwipeAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSwipeAreaBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSwipeAreaBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudSwipeAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSwipeArea>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSwipe")>] member this.OnSwipe (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: System.Action<MudBlazor.SwipeDirection>) = "OnSwipe" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudSimpleTableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSimpleTableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSimpleTableBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSimpleTableBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudSimpleTableBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Hover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Striped" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSimpleTable>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudTableBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudTableBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Hover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Striped" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<MudBlazor.MudTableBase>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FixedFooter")>] member this.FixedFooter (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "FixedFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortLabel")>] member this.SortLabel (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "SortLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowUnsorted")>] member this.AllowUnsorted (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "AllowUnsorted" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowsPerPage")>] member this.RowsPerPage (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Int32) = "RowsPerPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CurrentPage")>] member this.CurrentPage (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Int32) = "CurrentPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "ToolBarContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: int) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: float) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadingProgressColor")>] member this.LoadingProgressColor (_: FunBlazorContext<MudBlazor.MudTableBase>, x: MudBlazor.Color) = "LoadingProgressColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "HeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: int) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: float) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomHeader")>] member this.CustomHeader (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "CustomHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderClass")>] member this.HeaderClass (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "HeaderClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "FooterContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: int) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: float) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomFooter")>] member this.CustomFooter (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "CustomFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterClass")>] member this.FooterClass (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "FooterClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "ColGroup" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<MudBlazor.MudTableBase>, x: int) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<MudBlazor.MudTableBase>, x: float) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "PagerContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: int) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<MudBlazor.MudTableBase>, x: float) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCommitEditClick")>] member this.OnCommitEditClick (_: FunBlazorContext<MudBlazor.MudTableBase>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancelEditClick")>] member this.OnCancelEditClick (_: FunBlazorContext<MudBlazor.MudTableBase>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditCommand")>] member this.CommitEditCommand (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Windows.Input.ICommand) = "CommitEditCommand" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditCommandParameter")>] member this.CommitEditCommandParameter (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Object) = "CommitEditCommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditTooltip")>] member this.CommitEditTooltip (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "CommitEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelEditTooltip")>] member this.CancelEditTooltip (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "CancelEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditIcon")>] member this.CommitEditIcon (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "CommitEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelEditIcon")>] member this.CancelEditIcon (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "CancelEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CanCancelEdit")>] member this.CanCancelEdit (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "CanCancelEdit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditPreview")>] member this.RowEditPreview (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Action<System.Object>) = "RowEditPreview" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditCommit")>] member this.RowEditCommit (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Action<System.Object>) = "RowEditCommit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditCancel")>] member this.RowEditCancel (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Action<System.Object>) = "RowEditCancel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TotalItems")>] member this.TotalItems (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Int32) = "TotalItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowClass")>] member this.RowClass (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "RowClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowStyle")>] member this.RowStyle (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "RowStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightAlignSmall")>] member this.RightAlignSmall (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "RightAlignSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTableBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudTableBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudTableBuilder<'FunBlazorGeneric>()

    [<CustomOperation("RowTemplate")>] member this.RowTemplate (_: FunBlazorContext<MudBlazor.MudTable<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildRowContent")>] member this.ChildRowContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildRowContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditingTemplate")>] member this.RowEditingTemplate (_: FunBlazorContext<MudBlazor.MudTable<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowEditingTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HorizontalScrollbar")>] member this.HorizontalScrollbar (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "HorizontalScrollbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Collections.Generic.IEnumerable<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Filter")>] member this.Filter (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Func<'T, System.Boolean>) = "Filter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<MudBlazor.TableRowClickEventArgs<'T>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowClassFunc")>] member this.RowClassFunc (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Func<'T, System.Int32, System.String>) = "RowClassFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowStyleFunc")>] member this.RowStyleFunc (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Func<'T, System.Int32, System.String>) = "RowStyleFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: 'T) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItemChanged")>] member this.SelectedItemChanged (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<'T> "SelectedItemChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItems")>] member this.SelectedItems (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Collections.Generic.HashSet<'T>) = "SelectedItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItemsChanged")>] member this.SelectedItemsChanged (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedItemsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ServerData")>] member this.ServerData (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Func<MudBlazor.TableState, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>) = "ServerData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Hover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Striped" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FixedFooter")>] member this.FixedFooter (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "FixedFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortLabel")>] member this.SortLabel (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "SortLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowUnsorted")>] member this.AllowUnsorted (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "AllowUnsorted" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowsPerPage")>] member this.RowsPerPage (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Int32) = "RowsPerPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CurrentPage")>] member this.CurrentPage (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Int32) = "CurrentPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "ToolBarContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: int) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: float) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadingProgressColor")>] member this.LoadingProgressColor (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: MudBlazor.Color) = "LoadingProgressColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "HeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: int) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: float) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomHeader")>] member this.CustomHeader (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "CustomHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderClass")>] member this.HeaderClass (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "HeaderClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "FooterContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: int) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: float) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomFooter")>] member this.CustomFooter (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "CustomFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterClass")>] member this.FooterClass (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "FooterClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "ColGroup" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: int) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: float) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "PagerContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: int) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: float) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCommitEditClick")>] member this.OnCommitEditClick (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancelEditClick")>] member this.OnCancelEditClick (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditCommand")>] member this.CommitEditCommand (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Windows.Input.ICommand) = "CommitEditCommand" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditCommandParameter")>] member this.CommitEditCommandParameter (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Object) = "CommitEditCommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditTooltip")>] member this.CommitEditTooltip (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "CommitEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelEditTooltip")>] member this.CancelEditTooltip (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "CancelEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditIcon")>] member this.CommitEditIcon (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "CommitEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelEditIcon")>] member this.CancelEditIcon (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "CancelEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CanCancelEdit")>] member this.CanCancelEdit (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "CanCancelEdit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditPreview")>] member this.RowEditPreview (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Action<System.Object>) = "RowEditPreview" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditCommit")>] member this.RowEditCommit (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Action<System.Object>) = "RowEditCommit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditCancel")>] member this.RowEditCancel (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Action<System.Object>) = "RowEditCancel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TotalItems")>] member this.TotalItems (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Int32) = "TotalItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowClass")>] member this.RowClass (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "RowClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowStyle")>] member this.RowStyle (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "RowStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightAlignSmall")>] member this.RightAlignSmall (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "RightAlignSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudTablePagerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudTablePagerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DisableRowsPerPage")>] member this.DisableRowsPerPage (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.Boolean) = "DisableRowsPerPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSizeOptions")>] member this.PageSizeOptions (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InfoFormat")>] member this.InfoFormat (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.String) = "InfoFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowsPerPageString")>] member this.RowsPerPageString (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.String) = "RowsPerPageString" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTablePager>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTablePager>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTableSortLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTableSortLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTableSortLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTableSortLabelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTableSortLabelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTableSortLabelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InitialDirection")>] member this.InitialDirection (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: MudBlazor.SortDirection) = "InitialDirection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Enabled")>] member this.Enabled (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Boolean) = "Enabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortIcon")>] member this.SortIcon (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.String) = "SortIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AppendIcon")>] member this.AppendIcon (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Boolean) = "AppendIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortDirection")>] member this.SortDirection (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: MudBlazor.SortDirection) = "SortDirection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortDirectionChanged")>] member this.SortDirectionChanged (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, fn) = (Bolero.Html.attr.callback<MudBlazor.SortDirection> "SortDirectionChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortBy")>] member this.SortBy (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Func<'T, System.Object>) = "SortBy" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortLabel")>] member this.SortLabel (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.String) = "SortLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTdBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTdBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTdBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTdBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTdBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTd>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTd>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTd>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTd>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataLabel")>] member this.DataLabel (_: FunBlazorContext<MudBlazor.MudTd>, x: System.String) = "DataLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSmall")>] member this.HideSmall (_: FunBlazorContext<MudBlazor.MudTd>, x: System.Boolean) = "HideSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTd>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTd>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTd>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTFootRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTFootRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTFootRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTFootRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTFootRowBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTFootRow>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreCheckbox")>] member this.IgnoreCheckbox (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Boolean) = "IgnoreCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreEditable")>] member this.IgnoreEditable (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Boolean) = "IgnoreEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorContext<MudBlazor.MudTFootRow>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudThBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudThBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudThBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudThBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudThBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTh>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTh>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTh>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTh>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTh>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTh>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTh>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTHeadRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTHeadRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTHeadRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTHeadRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTHeadRowBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTHeadRow>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreCheckbox")>] member this.IgnoreCheckbox (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Boolean) = "IgnoreCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreEditable")>] member this.IgnoreEditable (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Boolean) = "IgnoreEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorContext<MudBlazor.MudTHeadRow>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTrBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTrBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTrBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTrBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTrBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTr>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTr>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTr>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTr>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Item")>] member this.Item (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Object) = "Item" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsEditable")>] member this.IsEditable (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsHeader")>] member this.IsHeader (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsFooter")>] member this.IsFooter (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCheckedChanged")>] member this.IsCheckedChanged (_: FunBlazorContext<MudBlazor.MudTr>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsCheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsChecked")>] member this.IsChecked (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsChecked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTr>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTr>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTabsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("KeepPanelsAlive")>] member this.KeepPanelsAlive (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "KeepPanelsAlive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Border")>] member this.Border (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "Border" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Centered")>] member this.Centered (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "Centered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSlider")>] member this.HideSlider (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "HideSlider" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrevIcon")>] member this.PrevIcon (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.String) = "PrevIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.String) = "NextIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AlwaysShowScrollButtons")>] member this.AlwaysShowScrollButtons (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "AlwaysShowScrollButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Position")>] member this.Position (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Position) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SliderColor")>] member this.SliderColor (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Color) = "SliderColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollIconColor")>] member this.ScrollIconColor (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Color) = "ScrollIconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ApplyEffectsToContainer")>] member this.ApplyEffectsToContainer (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "ApplyEffectsToContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTabs>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTabs>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTabs>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTabs>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabPanelClass")>] member this.TabPanelClass (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.String) = "TabPanelClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PanelClass")>] member this.PanelClass (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.String) = "PanelClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivePanelIndex")>] member this.ActivePanelIndex (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Int32) = "ActivePanelIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivePanelIndexChanged")>] member this.ActivePanelIndexChanged (_: FunBlazorContext<MudBlazor.MudTabs>, fn) = (Bolero.Html.attr.callback<System.Int32> "ActivePanelIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTabs>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTabs>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTimeLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTimeLineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTimeLineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTimeLineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTimeLineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTimeLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Border")>] member this.Border (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Boolean) = "Border" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTimeLine>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTimeLineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTimeLineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTimeLineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTimeLineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTimeLineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTimeLineItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Align")>] member this.Align (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: MudBlazor.Align) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTooltipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTooltipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTooltipBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delay")>] member this.Delay (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Double) = "Delay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delayed")>] member this.Delayed (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Double) = "Delayed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<MudBlazor.MudTooltip>, x: MudBlazor.Placement) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTooltip>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTooltip>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTooltip>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTooltip>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorContext<MudBlazor.MudTooltip>, nodes) = Bolero.Html.attr.fragment "TooltipContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorContext<MudBlazor.MudTooltip>, x: string) = Bolero.Html.attr.fragment "TooltipContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorContext<MudBlazor.MudTooltip>, x: int) = Bolero.Html.attr.fragment "TooltipContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorContext<MudBlazor.MudTooltip>, x: float) = Bolero.Html.attr.fragment "TooltipContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Inline")>] member this.Inline (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Boolean) = "Inline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTooltip>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTooltip>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTreeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTreeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTreeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTreeViewBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTreeViewBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTreeViewBuilder<'FunBlazorGeneric>()

    [<CustomOperation("CanSelect")>] member this.CanSelect (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "CanSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CanActivate")>] member this.CanActivate (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "CanActivate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandOnClick")>] member this.ExpandOnClick (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "ExpandOnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CanHover")>] member this.CanHover (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "CanHover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.String) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatedValueChanged")>] member this.ActivatedValueChanged (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ActivatedValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValuesChanged")>] member this.SelectedValuesChanged (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ServerData")>] member this.ServerData (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.HashSet<'T>>>) = "ServerData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTreeViewItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTreeViewItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTreeViewItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTreeViewItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTreeViewItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTreeViewItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTypo")>] member this.TextTypo (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: MudBlazor.Typo) = "TextTypo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextClass")>] member this.TextClass (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "TextClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndText")>] member this.EndText (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "EndText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndTextTypo")>] member this.EndTextTypo (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: MudBlazor.Typo) = "EndTextTypo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndTextClass")>] member this.EndTextClass (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "EndTextClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, nodes) = Bolero.Html.attr.fragment "Content" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: int) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: float) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Activated")>] member this.Activated (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Boolean) = "Activated" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Selected")>] member this.Selected (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Boolean) = "Selected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndIconColor")>] member this.EndIconColor (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: MudBlazor.Color) = "EndIconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatedChanged")>] member this.ActivatedChanged (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ActivatedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChanged")>] member this.SelectedChanged (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTextBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTextBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTextBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Typo")>] member this.Typo (_: FunBlazorContext<MudBlazor.MudText>, x: MudBlazor.Typo) = "Typo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Align")>] member this.Align (_: FunBlazorContext<MudBlazor.MudText>, x: MudBlazor.Align) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudText>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GutterBottom")>] member this.GutterBottom (_: FunBlazorContext<MudBlazor.MudText>, x: System.Boolean) = "GutterBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudText>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudText>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudText>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudText>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Inline")>] member this.Inline (_: FunBlazorContext<MudBlazor.MudText>, x: System.Boolean) = "Inline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudText>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudText>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudText>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudContainerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudContainerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<MudBlazor.MudContainer>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorContext<MudBlazor.MudContainer>, x: MudBlazor.MaxWidth) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudContainer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudContainer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudContainer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudContainer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudContainer>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudDividerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudDividerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Absolute")>] member this.Absolute (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Boolean) = "Absolute" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FlexItem")>] member this.FlexItem (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Boolean) = "FlexItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Light")>] member this.Light (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Boolean) = "Light" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Vertical")>] member this.Vertical (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Boolean) = "Vertical" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DividerType")>] member this.DividerType (_: FunBlazorContext<MudBlazor.MudDivider>, x: MudBlazor.DividerType) = "DividerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDivider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDivider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudDrawerHeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudDrawerHeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudDrawerHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LinkToIndex")>] member this.LinkToIndex (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: System.Boolean) = "LinkToIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudGridBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Spacing")>] member this.Spacing (_: FunBlazorContext<MudBlazor.MudGrid>, x: System.Int32) = "Spacing" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Justify")>] member this.Justify (_: FunBlazorContext<MudBlazor.MudGrid>, x: MudBlazor.Justify) = "Justify" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudGrid>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudGrid>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudGrid>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudGrid>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudGrid>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudGrid>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudGrid>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("xs")>] member this.xs (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "xs" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sm")>] member this.sm (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "sm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("md")>] member this.md (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "md" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lg")>] member this.lg (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "lg" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xl")>] member this.xl (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "xl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudHighlighterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudHighlighterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HighlightedText")>] member this.HighlightedText (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.String) = "HighlightedText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CaseSensitive")>] member this.CaseSensitive (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.Boolean) = "CaseSensitive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UntilNextBoundary")>] member this.UntilNextBoundary (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.Boolean) = "UntilNextBoundary" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudMainContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudMainContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMainContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudMainContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudMainContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudMainContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMainContent>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMainContent>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMainContent>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudMainContent>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudMainContent>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudMainContent>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudMainContent>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudPaperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudPaperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPaperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudPaperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudPaperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudPaperBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinHeight")>] member this.MinHeight (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "MinHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinWidth")>] member this.MinWidth (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "MinWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPaper>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPaper>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPaper>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPaper>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudPaper>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudPaper>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudSparkLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudSparkLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudSparkLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTabPanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTabPanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudTabPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BadgeData")>] member this.BadgeData (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Object) = "BadgeData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BadgeColor")>] member this.BadgeColor (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: MudBlazor.Color) = "BadgeColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ID")>] member this.ID (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Object) = "ID" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<MudBlazor.MudTabPanel>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTabPanel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolTip")>] member this.ToolTip (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.String) = "ToolTip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudToolBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = MudToolBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudToolBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudToolBarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudToolBarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudToolBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<MudBlazor.MudToolBar>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<MudBlazor.MudToolBar>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudToolBar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudToolBar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudToolBar>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudToolBar>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudToolBar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudToolBar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<MudBlazor.MudToolBar>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type MudDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudDialogProviderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudDialogProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("NoHeader")>] member this.NoHeader (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<System.Boolean>) = "NoHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseButton")>] member this.CloseButton (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<System.Boolean>) = "CloseButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableBackdropClick")>] member this.DisableBackdropClick (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<System.Boolean>) = "DisableBackdropClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<System.Boolean>) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Position")>] member this.Position (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<MudBlazor.DialogPosition>) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<MudBlazor.MaxWidth>) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
                

type BaseMudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BaseMudThemeProviderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = BaseMudThemeProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<MudBlazor.BaseMudThemeProvider>, x: MudBlazor.MudTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
                

type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudThemeProviderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudThemeProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<MudBlazor.MudThemeProvider>, x: MudBlazor.MudTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
                

type MudAppBarSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudAppBarSpacerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudAppBarSpacerBuilder<'FunBlazorGeneric>()


                

type BreadcrumbLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BreadcrumbLinkBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = BreadcrumbLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Item")>] member this.Item (_: FunBlazorContext<MudBlazor.BreadcrumbLink>, x: MudBlazor.BreadcrumbItem) = "Item" => x |> BoleroAttr |> this.AddProp
                

type BreadcrumbSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BreadcrumbSeparatorBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = BreadcrumbSeparatorBuilder<'FunBlazorGeneric>()


                

type MudPickerContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudPickerContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPickerContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudPickerContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudPickerContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudPickerContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudPickerContent>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPickerContent>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPickerContent>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPickerContent>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPickerContent>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudPickerToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudPickerToolbarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPickerToolbarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudPickerToolbarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudPickerToolbarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MudPickerToolbarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudSpacerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudSpacerBuilder<'FunBlazorGeneric>()


                

type MudToolBarSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudToolBarSpacerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudToolBarSpacerBuilder<'FunBlazorGeneric>()


                

type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedIcon")>] member this.ExpandedIcon (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x: System.String) = "ExpandedIcon" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open MudBlazor.DslInternals


type MudInputAdornmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudInputAdornmentBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MudInputAdornmentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentClick")>] member this.AdornmentClick (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals.Charts

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open MudBlazor.DslInternals


type FiltersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = FiltersBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FiltersBuilder<'FunBlazorGeneric>()


                
            

// =======================================================================================================================

namespace MudBlazor

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals

    type MudComponentBase' = MudComponentBaseBuilder<MudBlazor.MudComponentBase>
    type MudBaseButton' = MudBaseButtonBuilder<MudBlazor.MudBaseButton>
    type MudButton' = MudButtonBuilder<MudBlazor.MudButton>
    type MudFab' = MudFabBuilder<MudBlazor.MudFab>
    type MudIconButton' = MudIconButtonBuilder<MudBlazor.MudIconButton>
    type MudMenu' = MudMenuBuilder<MudBlazor.MudMenu>
    type MudFileUploader' = MudFileUploaderBuilder<MudBlazor.MudFileUploader>
    type MudBaseItemsControl'<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseItemsControlBuilder<MudBlazor.MudBaseItemsControl<'TChildComponent>>
    type MudBaseBindableItemsControl'<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseBindableItemsControlBuilder<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>
    type MudCarousel'<'TData> = MudCarouselBuilder<MudBlazor.MudCarousel<'TData>>
    type MudBaseSelectItem' = MudBaseSelectItemBuilder<MudBlazor.MudBaseSelectItem>
    type MudNavLink' = MudNavLinkBuilder<MudBlazor.MudNavLink>
    type MudSelectItem'<'T> = MudSelectItemBuilder<MudBlazor.MudSelectItem<'T>>
    type MudFormComponent'<'T, 'U> = MudFormComponentBuilder<MudBlazor.MudFormComponent<'T, 'U>>
    type MudBaseInput'<'T> = MudBaseInputBuilder<MudBlazor.MudBaseInput<'T>>
    type MudAutocomplete'<'T> = MudAutocompleteBuilder<MudBlazor.MudAutocomplete<'T>>
    type MudDebouncedInput'<'T> = MudDebouncedInputBuilder<MudBlazor.MudDebouncedInput<'T>>
    type MudNumericField'<'T> = MudNumericFieldBuilder<MudBlazor.MudNumericField<'T>>
    type MudTextField'<'T> = MudTextFieldBuilder<MudBlazor.MudTextField<'T>>
    type MudTextFieldString' = MudTextFieldStringBuilder<MudBlazor.MudTextFieldString>
    type MudInput'<'T> = MudInputBuilder<MudBlazor.MudInput<'T>>
    type MudInputString' = MudInputStringBuilder<MudBlazor.MudInputString>
    type MudRangeInput'<'T> = MudRangeInputBuilder<MudBlazor.MudRangeInput<'T>>
    type MudSelect'<'T> = MudSelectBuilder<MudBlazor.MudSelect<'T>>
    type MudBooleanInput'<'T> = MudBooleanInputBuilder<MudBlazor.MudBooleanInput<'T>>
    type MudCheckBox'<'T> = MudCheckBoxBuilder<MudBlazor.MudCheckBox<'T>>
    type MudSwitch'<'T> = MudSwitchBuilder<MudBlazor.MudSwitch<'T>>
    type MudPicker'<'T> = MudPickerBuilder<MudBlazor.MudPicker<'T>>
    type MudBaseDatePicker' = MudBaseDatePickerBuilder<MudBlazor.MudBaseDatePicker>
    type MudDatePicker' = MudDatePickerBuilder<MudBlazor.MudDatePicker>
    type MudDateRangePicker' = MudDateRangePickerBuilder<MudBlazor.MudDateRangePicker>
    type MudTimePicker' = MudTimePickerBuilder<MudBlazor.MudTimePicker>
    type MudRadioGroup'<'T> = MudRadioGroupBuilder<MudBlazor.MudRadioGroup<'T>>
    type MudAlert' = MudAlertBuilder<MudBlazor.MudAlert>
    type MudAppBar' = MudAppBarBuilder<MudBlazor.MudAppBar>
    type MudAvatar' = MudAvatarBuilder<MudBlazor.MudAvatar>
    type MudBadge' = MudBadgeBuilder<MudBlazor.MudBadge>
    type MudBreadcrumbs' = MudBreadcrumbsBuilder<MudBlazor.MudBreadcrumbs>
    type MudButtonGroup' = MudButtonGroupBuilder<MudBlazor.MudButtonGroup>
    type MudToggleIconButton' = MudToggleIconButtonBuilder<MudBlazor.MudToggleIconButton>
    type MudCard' = MudCardBuilder<MudBlazor.MudCard>
    type MudCardActions' = MudCardActionsBuilder<MudBlazor.MudCardActions>
    type MudCardContent' = MudCardContentBuilder<MudBlazor.MudCardContent>
    type MudCardHeader' = MudCardHeaderBuilder<MudBlazor.MudCardHeader>
    type MudCardMedia' = MudCardMediaBuilder<MudBlazor.MudCardMedia>
    type MudCarouselItem' = MudCarouselItemBuilder<MudBlazor.MudCarouselItem>
    type MudChartBase' = MudChartBaseBuilder<MudBlazor.MudChartBase>
    type MudChart' = MudChartBuilder<MudBlazor.MudChart>
    type MudChipSet' = MudChipSetBuilder<MudBlazor.MudChipSet>
    type MudChip' = MudChipBuilder<MudBlazor.MudChip>
    type MudCollapse' = MudCollapseBuilder<MudBlazor.MudCollapse>
    type MudDialog' = MudDialogBuilder<MudBlazor.MudDialog>
    type MudDialogInstance' = MudDialogInstanceBuilder<MudBlazor.MudDialogInstance>
    type MudDrawer' = MudDrawerBuilder<MudBlazor.MudDrawer>
    type MudDrawerContainer' = MudDrawerContainerBuilder<MudBlazor.MudDrawerContainer>
    type MudLayout' = MudLayoutBuilder<MudBlazor.MudLayout>
    type MudElement' = MudElementBuilder<MudBlazor.MudElement>
    type MudExpansionPanel' = MudExpansionPanelBuilder<MudBlazor.MudExpansionPanel>
    type MudExpansionPanels' = MudExpansionPanelsBuilder<MudBlazor.MudExpansionPanels>
    type MudField' = MudFieldBuilder<MudBlazor.MudField>
    type MudFocusTrap' = MudFocusTrapBuilder<MudBlazor.MudFocusTrap>
    type MudForm' = MudFormBuilder<MudBlazor.MudForm>
    type MudHidden' = MudHiddenBuilder<MudBlazor.MudHidden>
    type MudIcon' = MudIconBuilder<MudBlazor.MudIcon>
    type MudInputControl' = MudInputControlBuilder<MudBlazor.MudInputControl>
    type MudInputLabel' = MudInputLabelBuilder<MudBlazor.MudInputLabel>
    type MudLink' = MudLinkBuilder<MudBlazor.MudLink>
    type MudList' = MudListBuilder<MudBlazor.MudList>
    type MudListItem' = MudListItemBuilder<MudBlazor.MudListItem>
    type MudListSubheader' = MudListSubheaderBuilder<MudBlazor.MudListSubheader>
    type MudMenuItem' = MudMenuItemBuilder<MudBlazor.MudMenuItem>
    type MudMessageBox' = MudMessageBoxBuilder<MudBlazor.MudMessageBox>
    type MudNavGroup' = MudNavGroupBuilder<MudBlazor.MudNavGroup>
    type MudNavMenu' = MudNavMenuBuilder<MudBlazor.MudNavMenu>
    type MudOverlay' = MudOverlayBuilder<MudBlazor.MudOverlay>
    type MudPopover' = MudPopoverBuilder<MudBlazor.MudPopover>
    type MudProgressCircular' = MudProgressCircularBuilder<MudBlazor.MudProgressCircular>
    type MudProgressLinear' = MudProgressLinearBuilder<MudBlazor.MudProgressLinear>
    type MudRadio'<'T> = MudRadioBuilder<MudBlazor.MudRadio<'T>>
    type MudRating' = MudRatingBuilder<MudBlazor.MudRating>
    type MudRatingItem' = MudRatingItemBuilder<MudBlazor.MudRatingItem>
    type MudScrollToTop' = MudScrollToTopBuilder<MudBlazor.MudScrollToTop>
    type MudSkeleton' = MudSkeletonBuilder<MudBlazor.MudSkeleton>
    type MudSlider'<'T> = MudSliderBuilder<MudBlazor.MudSlider<'T>>
    type MudSnackbarElement' = MudSnackbarElementBuilder<MudBlazor.MudSnackbarElement>
    type MudSnackbarProvider' = MudSnackbarProviderBuilder<MudBlazor.MudSnackbarProvider>
    type MudSwipeArea' = MudSwipeAreaBuilder<MudBlazor.MudSwipeArea>
    type MudSimpleTable' = MudSimpleTableBuilder<MudBlazor.MudSimpleTable>
    type MudTableBase' = MudTableBaseBuilder<MudBlazor.MudTableBase>
    type MudTable'<'T> = MudTableBuilder<MudBlazor.MudTable<'T>>
    type MudTablePager' = MudTablePagerBuilder<MudBlazor.MudTablePager>
    type MudTableSortLabel'<'T> = MudTableSortLabelBuilder<MudBlazor.MudTableSortLabel<'T>>
    type MudTd' = MudTdBuilder<MudBlazor.MudTd>
    type MudTFootRow' = MudTFootRowBuilder<MudBlazor.MudTFootRow>
    type MudTh' = MudThBuilder<MudBlazor.MudTh>
    type MudTHeadRow' = MudTHeadRowBuilder<MudBlazor.MudTHeadRow>
    type MudTr' = MudTrBuilder<MudBlazor.MudTr>
    type MudTabs' = MudTabsBuilder<MudBlazor.MudTabs>
    type MudTimeLine' = MudTimeLineBuilder<MudBlazor.MudTimeLine>
    type MudTimeLineItem' = MudTimeLineItemBuilder<MudBlazor.MudTimeLineItem>
    type MudTooltip' = MudTooltipBuilder<MudBlazor.MudTooltip>
    type MudTreeView'<'T> = MudTreeViewBuilder<MudBlazor.MudTreeView<'T>>
    type MudTreeViewItem'<'T> = MudTreeViewItemBuilder<MudBlazor.MudTreeViewItem<'T>>
    type MudText' = MudTextBuilder<MudBlazor.MudText>
    type MudContainer' = MudContainerBuilder<MudBlazor.MudContainer>
    type MudDivider' = MudDividerBuilder<MudBlazor.MudDivider>
    type MudDrawerHeader' = MudDrawerHeaderBuilder<MudBlazor.MudDrawerHeader>
    type MudGrid' = MudGridBuilder<MudBlazor.MudGrid>
    type MudItem' = MudItemBuilder<MudBlazor.MudItem>
    type MudHighlighter' = MudHighlighterBuilder<MudBlazor.MudHighlighter>
    type MudMainContent' = MudMainContentBuilder<MudBlazor.MudMainContent>
    type MudPaper' = MudPaperBuilder<MudBlazor.MudPaper>
    type MudSparkLine' = MudSparkLineBuilder<MudBlazor.MudSparkLine>
    type MudTabPanel' = MudTabPanelBuilder<MudBlazor.MudTabPanel>
    type MudToolBar' = MudToolBarBuilder<MudBlazor.MudToolBar>
    type MudDialogProvider' = MudDialogProviderBuilder<MudBlazor.MudDialogProvider>
    type BaseMudThemeProvider' = BaseMudThemeProviderBuilder<MudBlazor.BaseMudThemeProvider>
    type MudThemeProvider' = MudThemeProviderBuilder<MudBlazor.MudThemeProvider>
    type MudAppBarSpacer' = MudAppBarSpacerBuilder<MudBlazor.MudAppBarSpacer>
    type BreadcrumbLink' = BreadcrumbLinkBuilder<MudBlazor.BreadcrumbLink>
    type BreadcrumbSeparator' = BreadcrumbSeparatorBuilder<MudBlazor.BreadcrumbSeparator>
    type MudPickerContent' = MudPickerContentBuilder<MudBlazor.MudPickerContent>
    type MudPickerToolbar' = MudPickerToolbarBuilder<MudBlazor.MudPickerToolbar>
    type MudSpacer' = MudSpacerBuilder<MudBlazor.MudSpacer>
    type MudToolBarSpacer' = MudToolBarSpacerBuilder<MudBlazor.MudToolBarSpacer>
    type MudTreeViewItemToggleButton' = MudTreeViewItemToggleButtonBuilder<MudBlazor.MudTreeViewItemToggleButton>
            
namespace MudBlazor.Charts

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Charts

    type Bar' = BarBuilder<MudBlazor.Charts.Bar>
    type Donut' = DonutBuilder<MudBlazor.Charts.Donut>
    type Line' = LineBuilder<MudBlazor.Charts.Line>
    type Pie' = PieBuilder<MudBlazor.Charts.Pie>
    type Legend' = LegendBuilder<MudBlazor.Charts.Legend>
    type Filters' = FiltersBuilder<MudBlazor.Charts.Filters>
            
namespace MudBlazor.Internal

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Internal

    type MudInputAdornment' = MudInputAdornmentBuilder<MudBlazor.Internal.MudInputAdornment>
            