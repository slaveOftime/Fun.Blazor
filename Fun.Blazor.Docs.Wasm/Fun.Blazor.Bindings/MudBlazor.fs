namespace rec MudBlazor.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open MudBlazor.DslInternals


type MudComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudComponentBase>, x) = attr.ref<MudBlazor.MudComponentBase> x |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudComponentBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudComponentBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudComponentBase>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudComponentBase>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBaseButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudBaseButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBaseButton>, x) = attr.ref<MudBlazor.MudBaseButton> x |> this.AddProp
    [<CustomOperation("htmlTag")>] member this.htmlTag (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buttonType")>] member this.buttonType (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("link")>] member this.link (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableElevation")>] member this.disableElevation (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudBaseButton>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBaseButton>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudButton>, x) = attr.ref<MudBlazor.MudButton> x |> this.AddProp
    [<CustomOperation("startIcon")>] member this.startIcon (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "StartIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("endIcon")>] member this.endIcon (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconClass")>] member this.iconClass (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "IconClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudButton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudButton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("htmlTag")>] member this.htmlTag (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buttonType")>] member this.buttonType (_: FunBlazorContext<MudBlazor.MudButton>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("link")>] member this.link (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudButton>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableElevation")>] member this.disableElevation (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudButton>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudButton>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudFabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudFabBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudFab>, x) = attr.ref<MudBlazor.MudFab> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("htmlTag")>] member this.htmlTag (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buttonType")>] member this.buttonType (_: FunBlazorContext<MudBlazor.MudFab>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("link")>] member this.link (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudFab>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableElevation")>] member this.disableElevation (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudFab>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudFab>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudFab>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudFab>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudIconButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudIconButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudIconButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudIconButton>, x) = attr.ref<MudBlazor.MudIconButton> x |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("edge")>] member this.edge (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudIconButton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudIconButton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("htmlTag")>] member this.htmlTag (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buttonType")>] member this.buttonType (_: FunBlazorContext<MudBlazor.MudIconButton>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("link")>] member this.link (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableElevation")>] member this.disableElevation (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudIconButton>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudIconButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudIconButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudIconButton>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudMenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudMenu>, x) = attr.ref<MudBlazor.MudMenu> x |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("startIcon")>] member this.startIcon (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "StartIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("endIcon")>] member this.endIcon (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("positionAtCurser")>] member this.positionAtCurser (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "PositionAtCurser" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("activatorContent")>] member this.activatorContent (_: FunBlazorContext<MudBlazor.MudMenu>, nodes) = Bolero.Html.attr.fragment "ActivatorContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("activatorContentStr")>] member this.activatorContentStr (_: FunBlazorContext<MudBlazor.MudMenu>, x: string) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("activationEvent")>] member this.activationEvent (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.MouseEvent) = "ActivationEvent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetY")>] member this.offsetY (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetX")>] member this.offsetX (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudMenu>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudMenu>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("htmlTag")>] member this.htmlTag (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buttonType")>] member this.buttonType (_: FunBlazorContext<MudBlazor.MudMenu>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("link")>] member this.link (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableElevation")>] member this.disableElevation (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudMenu>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudMenu>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudMenu>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudMenu>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudFileUploaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudFileUploaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudFileUploader>, x) = attr.ref<MudBlazor.MudFileUploader> x |> this.AddProp
    [<CustomOperation("htmlTag")>] member this.htmlTag (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buttonType")>] member this.buttonType (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("link")>] member this.link (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableElevation")>] member this.disableElevation (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudFileUploader>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudFileUploader>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBaseItemsControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseItemsControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBaseItemsControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudBaseItemsControlBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x) = attr.ref<MudBlazor.MudBaseItemsControl<'TChildComponent>> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBaseItemsControl<'TChildComponent>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x) = attr.ref<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>> x |> this.AddProp
    [<CustomOperation("itemsSource")>] member this.itemsSource (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: System.Collections.Generic.IEnumerable<'TData>) = "ItemsSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemTemplate")>] member this.itemTemplate (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, render: 'TData -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCarouselBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudCarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudCarouselBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x) = attr.ref<MudBlazor.MudCarousel<'TData>> x |> this.AddProp
    [<CustomOperation("showArrows")>] member this.showArrows (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Boolean) = "ShowArrows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showDelimiters")>] member this.showDelimiters (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Boolean) = "ShowDelimiters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoCycle")>] member this.autoCycle (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Boolean) = "AutoCycle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoCycleTime")>] member this.autoCycleTime (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.TimeSpan) = "AutoCycleTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("nextButtonTemplate")>] member this.nextButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, nodes) = Bolero.Html.attr.fragment "NextButtonTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nextButtonTemplateStr")>] member this.nextButtonTemplateStr (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: string) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("previousButtonTemplate")>] member this.previousButtonTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, nodes) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("previousButtonTemplateStr")>] member this.previousButtonTemplateStr (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: string) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("delimiterTemplate")>] member this.delimiterTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, render: System.Boolean -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "DelimiterTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemsSource")>] member this.itemsSource (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Collections.Generic.IEnumerable<'TData>) = "ItemsSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemTemplate")>] member this.itemTemplate (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, render: 'TData -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCarousel<'TData>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBaseSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBaseSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudBaseSelectItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x) = attr.ref<MudBlazor.MudBaseSelectItem> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBaseSelectItem>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudNavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudNavLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudNavLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudNavLink>, x) = attr.ref<MudBlazor.MudNavLink> x |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudNavLink>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("match'")>] member this.match' (_: FunBlazorContext<MudBlazor.MudNavLink>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudNavLink>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudNavLink>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudNavLink>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudNavLink>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudNavLink>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudNavLink>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudSelectItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x) = attr.ref<MudBlazor.MudSelectItem<'T>> x |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSelectItem<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudFormComponentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudFormComponentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x) = attr.ref<MudBlazor.MudFormComponent<'T, 'U>> x |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: MudBlazor.Converter<'T, 'U>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudFormComponent<'T, 'U>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBaseInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudBaseInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x) = attr.ref<MudBlazor.MudBaseInput<'T>> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBaseInput<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudAutocompleteBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudAutocompleteBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x) = attr.ref<MudBlazor.MudAutocomplete<'T>> x |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetX")>] member this.offsetX (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetY")>] member this.offsetY (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openIcon")>] member this.openIcon (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "OpenIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeIcon")>] member this.closeIcon (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Int32) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toStringFunc")>] member this.toStringFunc (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Func<'T, System.String>) = "ToStringFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("searchFunc")>] member this.searchFunc (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>) = "SearchFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxItems")>] member this.maxItems (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Nullable<System.Int32>) = "MaxItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minCharacters")>] member this.minCharacters (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Int32) = "MinCharacters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("resetValueOnEmptyText")>] member this.resetValueOnEmptyText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "ResetValueOnEmptyText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceInterval")>] member this.debounceInterval (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Int32) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemTemplate")>] member this.itemTemplate (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemSelectedTemplate")>] member this.itemSelectedTemplate (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemSelectedTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("coerceText")>] member this.coerceText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "CoerceText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("coerceValue")>] member this.coerceValue (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "CoerceValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isOpenChanged")>] member this.isOpenChanged (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsOpenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudAutocomplete<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDebouncedInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudDebouncedInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x) = attr.ref<MudBlazor.MudDebouncedInput<'T>> x |> this.AddProp
    [<CustomOperation("debounceInterval")>] member this.debounceInterval (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDebounceIntervalElapsed")>] member this.onDebounceIntervalElapsed (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDebouncedInput<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudNumericFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudNumericFieldBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x) = attr.ref<MudBlazor.MudNumericField<'T>> x |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("min'")>] member this.min' (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: 'T) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max'")>] member this.max' (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: 'T) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("step")>] member this.step (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: 'T) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideSpinButtons")>] member this.hideSpinButtons (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "HideSpinButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceInterval")>] member this.debounceInterval (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDebounceIntervalElapsed")>] member this.onDebounceIntervalElapsed (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudNumericField<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTextFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudTextFieldBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x) = attr.ref<MudBlazor.MudTextField<'T>> x |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceInterval")>] member this.debounceInterval (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDebounceIntervalElapsed")>] member this.onDebounceIntervalElapsed (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTextField<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTextFieldStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudTextFieldStringBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x) = attr.ref<MudBlazor.MudTextFieldString> x |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceInterval")>] member this.debounceInterval (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDebounceIntervalElapsed")>] member this.onDebounceIntervalElapsed (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudTextFieldString>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: MudBlazor.Converter<System.String, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTextFieldString>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudInputBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x) = attr.ref<MudBlazor.MudInput<'T>> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudInput<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onIncrement")>] member this.onIncrement (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnIncrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDecrement")>] member this.onDecrement (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnDecrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideSpinButtons")>] member this.hideSpinButtons (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "HideSpinButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudInput<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudInput<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudInputStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudInputStringBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputStringBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudInputStringBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudInputString>, x) = attr.ref<MudBlazor.MudInputString> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudInputString>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudInputString>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onIncrement")>] member this.onIncrement (_: FunBlazorContext<MudBlazor.MudInputString>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnIncrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDecrement")>] member this.onDecrement (_: FunBlazorContext<MudBlazor.MudInputString>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnDecrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideSpinButtons")>] member this.hideSpinButtons (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "HideSpinButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudInputString>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudInputString>, x: MudBlazor.Converter<System.String, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudInputString>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudInputString>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudInputString>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudRangeInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudRangeInputBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRangeInputBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudRangeInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x) = attr.ref<MudBlazor.MudRangeInput<'T>> x |> this.AddProp
    [<CustomOperation("placeholderStart")>] member this.placeholderStart (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "PlaceholderStart" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholderEnd")>] member this.placeholderEnd (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "PlaceholderEnd" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, fn) = (Bolero.Html.attr.callback<MudBlazor.Range<'T>> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Range<'T>) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: MudBlazor.Converter<MudBlazor.Range<'T>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<MudBlazor.Range<'T>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudRangeInput<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudSelectBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSelectBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudSelectBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x) = attr.ref<MudBlazor.MudSelect<'T>> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openIcon")>] member this.openIcon (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "OpenIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeIcon")>] member this.closeIcon (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedValuesChanged")>] member this.selectedValuesChanged (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiSelectionTextFunc")>] member this.multiSelectionTextFunc (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Func<System.Collections.Generic.List<System.String>, System.String>) = "MultiSelectionTextFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedValues")>] member this.selectedValues (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Collections.Generic.HashSet<'T>) = "SelectedValues" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toStringFunc")>] member this.toStringFunc (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Func<'T, System.String>) = "ToStringFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiSelection")>] member this.multiSelection (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Int32) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetX")>] member this.offsetX (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetY")>] member this.offsetY (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strict")>] member this.strict (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Strict" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentColor")>] member this.adornmentColor (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clearable")>] member this.clearable (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearButtonClick")>] member this.onClearButtonClick (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputType")>] member this.inputType (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lines")>] member this.lines (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInternalInputChanged")>] member this.onInternalInputChanged (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyDownPreventDefault")>] member this.keyDownPreventDefault (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyPressPreventDefault")>] member this.keyPressPreventDefault (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyUpPreventDefault")>] member this.keyUpPreventDefault (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSelect<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBooleanInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudBooleanInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x) = attr.ref<MudBlazor.MudBooleanInput<'T>> x |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: 'T) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChanged")>] member this.checkedChanged (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, fn) = (Bolero.Html.attr.callback<'T> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: MudBlazor.Converter<'T, System.Nullable<System.Boolean>>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBooleanInput<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCheckBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudCheckBoxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCheckBoxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudCheckBoxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x) = attr.ref<MudBlazor.MudCheckBox<'T>> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedIcon")>] member this.checkedIcon (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "CheckedIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("uncheckedIcon")>] member this.uncheckedIcon (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "UncheckedIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("indeterminateIcon")>] member this.indeterminateIcon (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "IndeterminateIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("triState")>] member this.triState (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "TriState" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: 'T) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChanged")>] member this.checkedChanged (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, fn) = (Bolero.Html.attr.callback<'T> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: MudBlazor.Converter<'T, System.Nullable<System.Boolean>>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCheckBox<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudSwitchBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSwitchBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudSwitchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x) = attr.ref<MudBlazor.MudSwitch<'T>> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: 'T) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChanged")>] member this.checkedChanged (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, fn) = (Bolero.Html.attr.callback<'T> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: MudBlazor.Converter<'T, System.Nullable<System.Boolean>>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSwitch<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x) = attr.ref<MudBlazor.MudPicker<'T>> x |> this.AddProp
    [<CustomOperation("inputIcon")>] member this.inputIcon (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerOpened")>] member this.pickerOpened (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerClosed")>] member this.pickerClosed (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rounded")>] member this.rounded (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableToolbar")>] member this.disableToolbar (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarClass")>] member this.toolBarClass (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerVariant")>] member this.pickerVariant (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputVariant")>] member this.inputVariant (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowKeyboardInput")>] member this.allowKeyboardInput (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classActions")>] member this.classActions (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActions")>] member this.pickerActions (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActionsStr")>] member this.pickerActionsStr (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: MudBlazor.Converter<'T, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudPicker<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBaseDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudBaseDatePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x) = attr.ref<MudBlazor.MudBaseDatePicker> x |> this.AddProp
    [<CustomOperation("maxDate")>] member this.maxDate (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DateTime>) = "MaxDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minDate")>] member this.minDate (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DateTime>) = "MinDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openTo")>] member this.openTo (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateFormat")>] member this.dateFormat (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "DateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("firstDayOfWeek")>] member this.firstDayOfWeek (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerMonth")>] member this.pickerMonth (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DateTime>) = "PickerMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerMonthChanged")>] member this.pickerMonthChanged (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("closingDelay")>] member this.closingDelay (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Int32) = "ClosingDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayMonths")>] member this.displayMonths (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Int32) = "DisplayMonths" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxMonthColumns")>] member this.maxMonthColumns (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.Int32>) = "MaxMonthColumns" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("startMonth")>] member this.startMonth (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Nullable<System.DateTime>) = "StartMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showWeekNumbers")>] member this.showWeekNumbers (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "ShowWeekNumbers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleDateFormat")>] member this.titleDateFormat (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "TitleDateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputIcon")>] member this.inputIcon (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerOpened")>] member this.pickerOpened (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerClosed")>] member this.pickerClosed (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rounded")>] member this.rounded (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableToolbar")>] member this.disableToolbar (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarClass")>] member this.toolBarClass (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerVariant")>] member this.pickerVariant (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputVariant")>] member this.inputVariant (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowKeyboardInput")>] member this.allowKeyboardInput (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classActions")>] member this.classActions (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActions")>] member this.pickerActions (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActionsStr")>] member this.pickerActionsStr (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: MudBlazor.Converter<System.Nullable<System.DateTime>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBaseDatePicker>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudDatePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDatePicker>, x) = attr.ref<MudBlazor.MudDatePicker> x |> this.AddProp
    [<CustomOperation("dateChanged")>] member this.dateChanged (_: FunBlazorContext<MudBlazor.MudDatePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "DateChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("date")>] member this.date (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "Date" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoClose")>] member this.autoClose (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "AutoClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxDate")>] member this.maxDate (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "MaxDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minDate")>] member this.minDate (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "MinDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openTo")>] member this.openTo (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateFormat")>] member this.dateFormat (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "DateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("firstDayOfWeek")>] member this.firstDayOfWeek (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerMonth")>] member this.pickerMonth (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "PickerMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerMonthChanged")>] member this.pickerMonthChanged (_: FunBlazorContext<MudBlazor.MudDatePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("closingDelay")>] member this.closingDelay (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Int32) = "ClosingDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayMonths")>] member this.displayMonths (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Int32) = "DisplayMonths" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxMonthColumns")>] member this.maxMonthColumns (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.Int32>) = "MaxMonthColumns" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("startMonth")>] member this.startMonth (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Nullable<System.DateTime>) = "StartMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showWeekNumbers")>] member this.showWeekNumbers (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "ShowWeekNumbers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleDateFormat")>] member this.titleDateFormat (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "TitleDateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputIcon")>] member this.inputIcon (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerOpened")>] member this.pickerOpened (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerClosed")>] member this.pickerClosed (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rounded")>] member this.rounded (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableToolbar")>] member this.disableToolbar (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarClass")>] member this.toolBarClass (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerVariant")>] member this.pickerVariant (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputVariant")>] member this.inputVariant (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowKeyboardInput")>] member this.allowKeyboardInput (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudDatePicker>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classActions")>] member this.classActions (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActions")>] member this.pickerActions (_: FunBlazorContext<MudBlazor.MudDatePicker>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActionsStr")>] member this.pickerActionsStr (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: MudBlazor.Converter<System.Nullable<System.DateTime>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDatePicker>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudDateRangePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x) = attr.ref<MudBlazor.MudDateRangePicker> x |> this.AddProp
    [<CustomOperation("dateRangeChanged")>] member this.dateRangeChanged (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, fn) = (Bolero.Html.attr.callback<MudBlazor.DateRange> "DateRangeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRange")>] member this.dateRange (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.DateRange) = "DateRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxDate")>] member this.maxDate (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DateTime>) = "MaxDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minDate")>] member this.minDate (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DateTime>) = "MinDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openTo")>] member this.openTo (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateFormat")>] member this.dateFormat (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "DateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("firstDayOfWeek")>] member this.firstDayOfWeek (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerMonth")>] member this.pickerMonth (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DateTime>) = "PickerMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerMonthChanged")>] member this.pickerMonthChanged (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("closingDelay")>] member this.closingDelay (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Int32) = "ClosingDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("displayMonths")>] member this.displayMonths (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Int32) = "DisplayMonths" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxMonthColumns")>] member this.maxMonthColumns (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.Int32>) = "MaxMonthColumns" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("startMonth")>] member this.startMonth (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Nullable<System.DateTime>) = "StartMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showWeekNumbers")>] member this.showWeekNumbers (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "ShowWeekNumbers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleDateFormat")>] member this.titleDateFormat (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "TitleDateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputIcon")>] member this.inputIcon (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerOpened")>] member this.pickerOpened (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerClosed")>] member this.pickerClosed (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rounded")>] member this.rounded (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableToolbar")>] member this.disableToolbar (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarClass")>] member this.toolBarClass (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerVariant")>] member this.pickerVariant (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputVariant")>] member this.inputVariant (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowKeyboardInput")>] member this.allowKeyboardInput (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classActions")>] member this.classActions (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActions")>] member this.pickerActions (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActionsStr")>] member this.pickerActionsStr (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: MudBlazor.Converter<System.Nullable<System.DateTime>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.DateTime>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDateRangePicker>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudTimePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTimePicker>, x) = attr.ref<MudBlazor.MudTimePicker> x |> this.AddProp
    [<CustomOperation("openTo")>] member this.openTo (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("timeEditMode")>] member this.timeEditMode (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.TimeEditMode) = "TimeEditMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("amPm")>] member this.amPm (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "AmPm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("timeFormat")>] member this.timeFormat (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "TimeFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("time")>] member this.time (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Nullable<System.TimeSpan>) = "Time" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("timeChanged")>] member this.timeChanged (_: FunBlazorContext<MudBlazor.MudTimePicker>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.TimeSpan>> "TimeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputIcon")>] member this.inputIcon (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerOpened")>] member this.pickerOpened (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerClosed")>] member this.pickerClosed (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rounded")>] member this.rounded (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableToolbar")>] member this.disableToolbar (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarClass")>] member this.toolBarClass (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerVariant")>] member this.pickerVariant (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputVariant")>] member this.inputVariant (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowKeyboardInput")>] member this.allowKeyboardInput (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textChanged")>] member this.textChanged (_: FunBlazorContext<MudBlazor.MudTimePicker>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classActions")>] member this.classActions (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActions")>] member this.pickerActions (_: FunBlazorContext<MudBlazor.MudTimePicker>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerActionsStr")>] member this.pickerActionsStr (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: MudBlazor.Converter<System.Nullable<System.TimeSpan>, System.String>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Linq.Expressions.Expression<System.Func<System.Nullable<System.TimeSpan>>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTimePicker>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudRadioGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudRadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudRadioGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x) = attr.ref<MudBlazor.MudRadioGroup<'T>> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedOption")>] member this.selectedOption (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: 'T) = "SelectedOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedOptionChanged")>] member this.selectedOptionChanged (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, fn) = (Bolero.Html.attr.callback<'T> "SelectedOptionChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("requiredError")>] member this.requiredError (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: MudBlazor.Converter<'T, 'T>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validation")>] member this.validation (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("for'")>] member this.for' (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudRadioGroup<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudAlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudAlertBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudAlert>, x) = attr.ref<MudBlazor.MudAlert> x |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("noIcon")>] member this.noIcon (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Boolean) = "NoIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("severity")>] member this.severity (_: FunBlazorContext<MudBlazor.MudAlert>, x: MudBlazor.Severity) = "Severity" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudAlert>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudAlert>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudAlert>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudAlert>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudAlert>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudAlert>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudAlert>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudAppBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAppBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudAppBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudAppBar>, x) = attr.ref<MudBlazor.MudAppBar> x |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudAppBar>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixed'")>] member this.fixed' (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudAppBar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudAppBar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudAppBar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudAppBar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudAppBar>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudAvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudAvatarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudAvatar>, x) = attr.ref<MudBlazor.MudAvatar> x |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rounded")>] member this.rounded (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("image")>] member this.image (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudAvatar>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudAvatar>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudAvatar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudAvatar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudAvatar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudAvatar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudAvatar>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudBadgeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBadge>, x) = attr.ref<MudBlazor.MudBadge> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudBadge>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bottom")>] member this.bottom (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Bottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("left")>] member this.left (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Left" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("start")>] member this.start (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Start" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dot")>] member this.dot (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Dot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlap")>] member this.overlap (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Overlap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max'")>] member this.max' (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Int32) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("content")>] member this.content (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Object) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudBadge>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudBadge>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBadge>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBadge>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBadge>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBreadcrumbsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudBreadcrumbsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x) = attr.ref<MudBlazor.MudBreadcrumbs> x |> this.AddProp
    [<CustomOperation("items")>] member this.items (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.Collections.Generic.List<MudBlazor.BreadcrumbItem>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("separator")>] member this.separator (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.String) = "Separator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("separatorTemplate")>] member this.separatorTemplate (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, nodes) = Bolero.Html.attr.fragment "SeparatorTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("separatorTemplateStr")>] member this.separatorTemplateStr (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: string) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemTemplate")>] member this.itemTemplate (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, render: MudBlazor.BreadcrumbItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxItems")>] member this.maxItems (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.Nullable<System.Byte>) = "MaxItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudBreadcrumbs>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudButtonGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x) = attr.ref<MudBlazor.MudButtonGroup> x |> this.AddProp
    [<CustomOperation("overrideStyles")>] member this.overrideStyles (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Boolean) = "OverrideStyles" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudButtonGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("verticalAlign")>] member this.verticalAlign (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Boolean) = "VerticalAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableElevation")>] member this.disableElevation (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudButtonGroup>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudToggleIconButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x) = attr.ref<MudBlazor.MudToggleIconButton> x |> this.AddProp
    [<CustomOperation("toggled")>] member this.toggled (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Boolean) = "Toggled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toggledChanged")>] member this.toggledChanged (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ToggledChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toggledIcon")>] member this.toggledIcon (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.String) = "ToggledIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toggledTitle")>] member this.toggledTitle (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.String) = "ToggledTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toggledColor")>] member this.toggledColor (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Color) = "ToggledColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toggledSize")>] member this.toggledSize (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Size) = "ToggledSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("edge")>] member this.edge (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudToggleIconButton>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudCardBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCard>, x) = attr.ref<MudBlazor.MudCard> x |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("outlined")>] member this.outlined (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudCard>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudCard>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCard>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCard>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCard>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCardActionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudCardActionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardActionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudCardActionsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCardActions>, x) = attr.ref<MudBlazor.MudCardActions> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudCardActions>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudCardActions>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCardActions>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCardActions>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCardActions>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCardActions>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCardContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudCardContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudCardContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCardContent>, x) = attr.ref<MudBlazor.MudCardContent> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudCardContent>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudCardContent>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCardContent>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCardContent>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCardContent>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCardContent>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCardHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudCardHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudCardHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCardHeader>, x) = attr.ref<MudBlazor.MudCardHeader> x |> this.AddProp
    [<CustomOperation("cardHeaderAvatar")>] member this.cardHeaderAvatar (_: FunBlazorContext<MudBlazor.MudCardHeader>, nodes) = Bolero.Html.attr.fragment "CardHeaderAvatar" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardHeaderAvatarStr")>] member this.cardHeaderAvatarStr (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardHeaderContent")>] member this.cardHeaderContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, nodes) = Bolero.Html.attr.fragment "CardHeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardHeaderContentStr")>] member this.cardHeaderContentStr (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardHeaderActions")>] member this.cardHeaderActions (_: FunBlazorContext<MudBlazor.MudCardHeader>, nodes) = Bolero.Html.attr.fragment "CardHeaderActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardHeaderActionsStr")>] member this.cardHeaderActionsStr (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudCardHeader>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCardHeader>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCardMediaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudCardMediaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCardMedia>, x) = attr.ref<MudBlazor.MudCardMedia> x |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("image")>] member this.image (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.Int32) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCardMedia>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudCarouselItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCarouselItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudCarouselItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x) = attr.ref<MudBlazor.MudCarouselItem> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudCarouselItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("transition")>] member this.transition (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: MudBlazor.Transition) = "Transition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("customTransitionEnter")>] member this.customTransitionEnter (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: System.String) = "CustomTransitionEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("customTransitionExit")>] member this.customTransitionExit (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: System.String) = "CustomTransitionExit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCarouselItem>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudChartBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudChartBase>, x) = attr.ref<MudBlazor.MudChartBase> x |> this.AddProp
    [<CustomOperation("inputData")>] member this.inputData (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputLabels")>] member this.inputLabels (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xAxisLabels")>] member this.xAxisLabels (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartSeries")>] member this.chartSeries (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartOptions")>] member this.chartOptions (_: FunBlazorContext<MudBlazor.MudChartBase>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartType")>] member this.chartType (_: FunBlazorContext<MudBlazor.MudChartBase>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("legendPosition")>] member this.legendPosition (_: FunBlazorContext<MudBlazor.MudChartBase>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.MudChartBase>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudChartBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudChartBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudChartBase>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudChartBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudChart>, x) = attr.ref<MudBlazor.MudChart> x |> this.AddProp
    [<CustomOperation("inputData")>] member this.inputData (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputLabels")>] member this.inputLabels (_: FunBlazorContext<MudBlazor.MudChart>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xAxisLabels")>] member this.xAxisLabels (_: FunBlazorContext<MudBlazor.MudChart>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartSeries")>] member this.chartSeries (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartOptions")>] member this.chartOptions (_: FunBlazorContext<MudBlazor.MudChart>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartType")>] member this.chartType (_: FunBlazorContext<MudBlazor.MudChart>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.MudChart>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudChart>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("legendPosition")>] member this.legendPosition (_: FunBlazorContext<MudBlazor.MudChart>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.MudChart>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudChart>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudChart>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudChart>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals.Charts

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open MudBlazor.DslInternals


type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = BarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.Charts.Bar>, x) = attr.ref<MudBlazor.Charts.Bar> x |> this.AddProp
    [<CustomOperation("inputData")>] member this.inputData (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputLabels")>] member this.inputLabels (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xAxisLabels")>] member this.xAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartSeries")>] member this.chartSeries (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartOptions")>] member this.chartOptions (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartType")>] member this.chartType (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("legendPosition")>] member this.legendPosition (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Bar>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.Charts.Bar>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = DonutBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.Charts.Donut>, x) = attr.ref<MudBlazor.Charts.Donut> x |> this.AddProp
    [<CustomOperation("inputData")>] member this.inputData (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputLabels")>] member this.inputLabels (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xAxisLabels")>] member this.xAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartSeries")>] member this.chartSeries (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartOptions")>] member this.chartOptions (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartType")>] member this.chartType (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("legendPosition")>] member this.legendPosition (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Donut>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.Charts.Donut>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = LineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.Charts.Line>, x) = attr.ref<MudBlazor.Charts.Line> x |> this.AddProp
    [<CustomOperation("inputData")>] member this.inputData (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputLabels")>] member this.inputLabels (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xAxisLabels")>] member this.xAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartSeries")>] member this.chartSeries (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartOptions")>] member this.chartOptions (_: FunBlazorContext<MudBlazor.Charts.Line>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartType")>] member this.chartType (_: FunBlazorContext<MudBlazor.Charts.Line>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("legendPosition")>] member this.legendPosition (_: FunBlazorContext<MudBlazor.Charts.Line>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Line>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.Charts.Line>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.Charts.Line>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.Charts.Line>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = PieBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.Charts.Pie>, x) = attr.ref<MudBlazor.Charts.Pie> x |> this.AddProp
    [<CustomOperation("inputData")>] member this.inputData (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputLabels")>] member this.inputLabels (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xAxisLabels")>] member this.xAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartSeries")>] member this.chartSeries (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartOptions")>] member this.chartOptions (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartType")>] member this.chartType (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("legendPosition")>] member this.legendPosition (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Pie>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.Charts.Pie>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = LegendBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.Charts.Legend>, x) = attr.ref<MudBlazor.Charts.Legend> x |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputData")>] member this.inputData (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputLabels")>] member this.inputLabels (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xAxisLabels")>] member this.xAxisLabels (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartSeries")>] member this.chartSeries (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartOptions")>] member this.chartOptions (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("chartType")>] member this.chartType (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("legendPosition")>] member this.legendPosition (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndex")>] member this.selectedIndex (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedIndexChanged")>] member this.selectedIndexChanged (_: FunBlazorContext<MudBlazor.Charts.Legend>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.Charts.Legend>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open MudBlazor.DslInternals


type MudChipSetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudChipSetBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudChipSetBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudChipSetBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudChipSet>, x) = attr.ref<MudBlazor.MudChipSet> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudChipSet>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudChipSet>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiSelection")>] member this.multiSelection (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mandatory")>] member this.mandatory (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Boolean) = "Mandatory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allClosable")>] member this.allClosable (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Boolean) = "AllClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("filter")>] member this.filter (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Boolean) = "Filter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedChip")>] member this.selectedChip (_: FunBlazorContext<MudBlazor.MudChipSet>, x: MudBlazor.MudChip) = "SelectedChip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedChipChanged")>] member this.selectedChipChanged (_: FunBlazorContext<MudBlazor.MudChipSet>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "SelectedChipChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedChips")>] member this.selectedChips (_: FunBlazorContext<MudBlazor.MudChipSet>, x: MudBlazor.MudChip[]) = "SelectedChips" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedChipsChanged")>] member this.selectedChipsChanged (_: FunBlazorContext<MudBlazor.MudChipSet>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip[]> "SelectedChipsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClose")>] member this.onClose (_: FunBlazorContext<MudBlazor.MudChipSet>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudChipSet>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudChipSet>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudChipSet>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudChipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudChipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudChipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudChipBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudChip>, x) = attr.ref<MudBlazor.MudChip> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudChip>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudChip>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudChip>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatar")>] member this.avatar (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarClass")>] member this.avatarClass (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "AvatarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudChip>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeIcon")>] member this.closeIcon (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudChip>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudChip>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("link")>] member this.link (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudChip>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("forceLoad")>] member this.forceLoad (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("default'")>] member this.default' (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Boolean) = "Default" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudChip>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClose")>] member this.onClose (_: FunBlazorContext<MudBlazor.MudChip>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudChip>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudChip>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudChip>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudCollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudCollapseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudCollapse>, x) = attr.ref<MudBlazor.MudCollapse> x |> this.AddProp
    [<CustomOperation("expanded")>] member this.expanded (_: FunBlazorContext<MudBlazor.MudCollapse>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudCollapse>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudCollapse>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudCollapse>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAnimationEnd")>] member this.onAnimationEnd (_: FunBlazorContext<MudBlazor.MudCollapse>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAnimationEnd" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandedChanged")>] member this.expandedChanged (_: FunBlazorContext<MudBlazor.MudCollapse>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudCollapse>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudCollapse>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudCollapse>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudCollapse>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudDialogBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDialog>, x) = attr.ref<MudBlazor.MudDialog> x |> this.AddProp
    [<CustomOperation("titleContent")>] member this.titleContent (_: FunBlazorContext<MudBlazor.MudDialog>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleContentStr")>] member this.titleContentStr (_: FunBlazorContext<MudBlazor.MudDialog>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dialogContent")>] member this.dialogContent (_: FunBlazorContext<MudBlazor.MudDialog>, nodes) = Bolero.Html.attr.fragment "DialogContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dialogContentStr")>] member this.dialogContentStr (_: FunBlazorContext<MudBlazor.MudDialog>, x: string) = Bolero.Html.attr.fragment "DialogContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dialogActions")>] member this.dialogActions (_: FunBlazorContext<MudBlazor.MudDialog>, nodes) = Bolero.Html.attr.fragment "DialogActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dialogActionsStr")>] member this.dialogActionsStr (_: FunBlazorContext<MudBlazor.MudDialog>, x: string) = Bolero.Html.attr.fragment "DialogActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableSidePadding")>] member this.disableSidePadding (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.Boolean) = "DisableSidePadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classContent")>] member this.classContent (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.String) = "ClassContent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classActions")>] member this.classActions (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentStyle")>] member this.contentStyle (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.String) = "ContentStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isVisible")>] member this.isVisible (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.Boolean) = "IsVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isVisibleChanged")>] member this.isVisibleChanged (_: FunBlazorContext<MudBlazor.MudDialog>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDialog>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDialog>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDialog>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDialogInstanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudDialogInstanceBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x) = attr.ref<MudBlazor.MudDialogInstance> x |> this.AddProp
    [<CustomOperation("options")>] member this.options (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: MudBlazor.DialogOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleContent")>] member this.titleContent (_: FunBlazorContext<MudBlazor.MudDialogInstance>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleContentStr")>] member this.titleContentStr (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("content")>] member this.content (_: FunBlazorContext<MudBlazor.MudDialogInstance>, nodes) = Bolero.Html.attr.fragment "Content" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentStr")>] member this.contentStr (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: System.Guid) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDialogInstance>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudDrawerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDrawer>, x) = attr.ref<MudBlazor.MudDrawer> x |> this.AddProp
    [<CustomOperation("fixed'")>] member this.fixed' (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("anchor")>] member this.anchor (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.Anchor) = "Anchor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.DrawerVariant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudDrawer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudDrawer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableOverlay")>] member this.disableOverlay (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "DisableOverlay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("preserveOpenState")>] member this.preserveOpenState (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "PreserveOpenState" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openMiniOnHover")>] member this.openMiniOnHover (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "OpenMiniOnHover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("breakpoint")>] member this.breakpoint (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openChanged")>] member this.openChanged (_: FunBlazorContext<MudBlazor.MudDrawer>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OpenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("miniWidth")>] member this.miniWidth (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.String) = "MiniWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("clipMode")>] member this.clipMode (_: FunBlazorContext<MudBlazor.MudDrawer>, x: MudBlazor.DrawerClipMode) = "ClipMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDrawer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDrawer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDrawer>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudDrawerContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x) = attr.ref<MudBlazor.MudDrawerContainer> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDrawerContainer>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudLayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudLayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudLayoutBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudLayout>, x) = attr.ref<MudBlazor.MudLayout> x |> this.AddProp
    [<CustomOperation("rightToLeft")>] member this.rightToLeft (_: FunBlazorContext<MudBlazor.MudLayout>, x: System.Boolean) = "RightToLeft" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudLayout>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudLayout>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudLayout>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudLayout>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudLayout>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudLayout>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudElementBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudElement>, x) = attr.ref<MudBlazor.MudElement> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudElement>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudElement>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("htmlTag")>] member this.htmlTag (_: FunBlazorContext<MudBlazor.MudElement>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ref")>] member this.ref (_: FunBlazorContext<MudBlazor.MudElement>, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "Ref" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("refChanged")>] member this.refChanged (_: FunBlazorContext<MudBlazor.MudElement>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudElement>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudElement>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudElement>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudElement>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudExpansionPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudExpansionPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudExpansionPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudExpansionPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x) = attr.ref<MudBlazor.MudExpansionPanel> x |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleContent")>] member this.titleContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleContentStr")>] member this.titleContentStr (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideIcon")>] member this.hideIcon (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "HideIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableGutters")>] member this.disableGutters (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isExpandedChanged")>] member this.isExpandedChanged (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("isExpanded")>] member this.isExpanded (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "IsExpanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudExpansionPanel>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudExpansionPanelsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudExpansionPanelsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudExpansionPanelsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x) = attr.ref<MudBlazor.MudExpansionPanels> x |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiExpansion")>] member this.multiExpansion (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "MultiExpansion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableGutters")>] member this.disableGutters (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableBorders")>] member this.disableBorders (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Boolean) = "DisableBorders" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudExpansionPanels>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudFieldBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudField>, x) = attr.ref<MudBlazor.MudField> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudField>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudField>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudField>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudField>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentIcon")>] member this.adornmentIcon (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentText")>] member this.adornmentText (_: FunBlazorContext<MudBlazor.MudField>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornment")>] member this.adornment (_: FunBlazorContext<MudBlazor.MudField>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconSize")>] member this.iconSize (_: FunBlazorContext<MudBlazor.MudField>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAdornmentClick")>] member this.onAdornmentClick (_: FunBlazorContext<MudBlazor.MudField>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("innerPadding")>] member this.innerPadding (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "InnerPadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableUnderLine")>] member this.disableUnderLine (_: FunBlazorContext<MudBlazor.MudField>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudField>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudField>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudField>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudField>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudFocusTrapBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFocusTrapBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudFocusTrapBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x) = attr.ref<MudBlazor.MudFocusTrap> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudFocusTrap>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultFocus")>] member this.defaultFocus (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: MudBlazor.DefaultFocus) = "DefaultFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudFocusTrap>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudFormBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudForm>, x) = attr.ref<MudBlazor.MudForm> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudForm>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudForm>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("isValid")>] member this.isValid (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Boolean) = "IsValid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isTouched")>] member this.isTouched (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Boolean) = "IsTouched" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validationDelay")>] member this.validationDelay (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Int32) = "ValidationDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suppressRenderingOnValidation")>] member this.suppressRenderingOnValidation (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Boolean) = "SuppressRenderingOnValidation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suppressImplicitSubmission")>] member this.suppressImplicitSubmission (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Boolean) = "SuppressImplicitSubmission" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isValidChanged")>] member this.isValidChanged (_: FunBlazorContext<MudBlazor.MudForm>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsValidChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("isTouchedChanged")>] member this.isTouchedChanged (_: FunBlazorContext<MudBlazor.MudForm>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsTouchedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("errors")>] member this.errors (_: FunBlazorContext<MudBlazor.MudForm>, x: System.String[]) = "Errors" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorsChanged")>] member this.errorsChanged (_: FunBlazorContext<MudBlazor.MudForm>, fn) = (Bolero.Html.attr.callback<System.String[]> "ErrorsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudForm>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudForm>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudForm>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudHiddenBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudHiddenBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudHiddenBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudHidden>, x) = attr.ref<MudBlazor.MudHidden> x |> this.AddProp
    [<CustomOperation("breakpoint")>] member this.breakpoint (_: FunBlazorContext<MudBlazor.MudHidden>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("invert")>] member this.invert (_: FunBlazorContext<MudBlazor.MudHidden>, x: System.Boolean) = "Invert" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isHidden")>] member this.isHidden (_: FunBlazorContext<MudBlazor.MudHidden>, x: System.Boolean) = "IsHidden" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isHiddenChanged")>] member this.isHiddenChanged (_: FunBlazorContext<MudBlazor.MudHidden>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsHiddenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudHidden>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudHidden>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudHidden>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudHidden>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudHidden>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudHidden>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudIconBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudIcon>, x) = attr.ref<MudBlazor.MudIcon> x |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudIcon>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudIcon>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("viewBox")>] member this.viewBox (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.String) = "ViewBox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudIcon>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudIcon>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudIcon>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudIcon>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudIcon>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudInputControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudInputControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudInputControlBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudInputControl>, x) = attr.ref<MudBlazor.MudInputControl> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudInputControl>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudInputControl>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputContent")>] member this.inputContent (_: FunBlazorContext<MudBlazor.MudInputControl>, nodes) = Bolero.Html.attr.fragment "InputContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputContentStr")>] member this.inputContentStr (_: FunBlazorContext<MudBlazor.MudInputControl>, x: string) = Bolero.Html.attr.fragment "InputContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudInputControl>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("errorText")>] member this.errorText (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("helperText")>] member this.helperText (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudInputControl>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudInputControl>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudInputControl>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudInputControl>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudInputLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudInputLabelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudInputLabel>, x) = attr.ref<MudBlazor.MudInputLabel> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudInputLabel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("error")>] member this.error (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("variant")>] member this.variant (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("margin")>] member this.margin (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudInputLabel>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudLink>, x) = attr.ref<MudBlazor.MudLink> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudLink>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("typo")>] member this.typo (_: FunBlazorContext<MudBlazor.MudLink>, x: MudBlazor.Typo) = "Typo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("underline")>] member this.underline (_: FunBlazorContext<MudBlazor.MudLink>, x: MudBlazor.Underline) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<MudBlazor.MudLink>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudLink>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudLink>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudLink>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudLink>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudLink>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudLink>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudLink>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudLink>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudListBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudList>, x) = attr.ref<MudBlazor.MudList> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudList>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudList>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("clickable")>] member this.clickable (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "Clickable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disablePadding")>] member this.disablePadding (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "DisablePadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableGutters")>] member this.disableGutters (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudList>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedItem")>] member this.selectedItem (_: FunBlazorContext<MudBlazor.MudList>, x: MudBlazor.MudListItem) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedItemChanged")>] member this.selectedItemChanged (_: FunBlazorContext<MudBlazor.MudList>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudListItem> "SelectedItemChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudList>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudList>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudList>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudList>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudListItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudListItem>, x) = attr.ref<MudBlazor.MudListItem> x |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatar")>] member this.avatar (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarClass")>] member this.avatarClass (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "AvatarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudListItem>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inset")>] member this.inset (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "Inset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableGutters")>] member this.disableGutters (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expanded")>] member this.expanded (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandedChanged")>] member this.expandedChanged (_: FunBlazorContext<MudBlazor.MudListItem>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("initiallyExpanded")>] member this.initiallyExpanded (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Boolean) = "InitiallyExpanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudListItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudListItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nestedList")>] member this.nestedList (_: FunBlazorContext<MudBlazor.MudListItem>, nodes) = Bolero.Html.attr.fragment "NestedList" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nestedListStr")>] member this.nestedListStr (_: FunBlazorContext<MudBlazor.MudListItem>, x: string) = Bolero.Html.attr.fragment "NestedList" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudListItem>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudListItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudListItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudListItem>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudListSubheaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListSubheaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudListSubheaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudListSubheader>, x) = attr.ref<MudBlazor.MudListSubheader> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudListSubheader>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableGutters")>] member this.disableGutters (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inset")>] member this.inset (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: System.Boolean) = "Inset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudListSubheader>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudMenuItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudMenuItem>, x) = attr.ref<MudBlazor.MudMenuItem> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudMenuItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("link")>] member this.link (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("forceLoad")>] member this.forceLoad (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudMenuItem>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudMenuItem>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudMessageBoxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudMessageBox>, x) = attr.ref<MudBlazor.MudMessageBox> x |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleContent")>] member this.titleContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleContentStr")>] member this.titleContentStr (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("message")>] member this.message (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("messageContent")>] member this.messageContent (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "MessageContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("messageContentStr")>] member this.messageContentStr (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "MessageContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelText")>] member this.cancelText (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelButton")>] member this.cancelButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "CancelButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelButtonStr")>] member this.cancelButtonStr (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "CancelButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("noText")>] member this.noText (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "NoText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("noButton")>] member this.noButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "NoButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("noButtonStr")>] member this.noButtonStr (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "NoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("yesText")>] member this.yesText (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.String) = "YesText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("yesButton")>] member this.yesButton (_: FunBlazorContext<MudBlazor.MudMessageBox>, nodes) = Bolero.Html.attr.fragment "YesButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("yesButtonStr")>] member this.yesButtonStr (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string) = Bolero.Html.attr.fragment "YesButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onYes")>] member this.onYes (_: FunBlazorContext<MudBlazor.MudMessageBox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnYes" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onNo")>] member this.onNo (_: FunBlazorContext<MudBlazor.MudMessageBox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnNo" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCancel")>] member this.onCancel (_: FunBlazorContext<MudBlazor.MudMessageBox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("isVisible")>] member this.isVisible (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.Boolean) = "IsVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isVisibleChanged")>] member this.isVisibleChanged (_: FunBlazorContext<MudBlazor.MudMessageBox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudMessageBox>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudNavGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudNavGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudNavGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudNavGroup>, x) = attr.ref<MudBlazor.MudNavGroup> x |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expanded")>] member this.expanded (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandedChanged")>] member this.expandedChanged (_: FunBlazorContext<MudBlazor.MudNavGroup>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideExpandIcon")>] member this.hideExpandIcon (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Boolean) = "HideExpandIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandIcon")>] member this.expandIcon (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.String) = "ExpandIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudNavGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudNavGroup>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudNavMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudNavMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudNavMenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudNavMenu>, x) = attr.ref<MudBlazor.MudNavMenu> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudNavMenu>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudNavMenu>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudOverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudOverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudOverlayBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudOverlay>, x) = attr.ref<MudBlazor.MudOverlay> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudOverlay>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudOverlay>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visibleChanged")>] member this.visibleChanged (_: FunBlazorContext<MudBlazor.MudOverlay>, fn) = (Bolero.Html.attr.callback<System.Boolean> "VisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoClose")>] member this.autoClose (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "AutoClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lockScroll")>] member this.lockScroll (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "LockScroll" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lockScrollClass")>] member this.lockScrollClass (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.String) = "LockScrollClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("darkBackground")>] member this.darkBackground (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "DarkBackground" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lightBackground")>] member this.lightBackground (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "LightBackground" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("absolute")>] member this.absolute (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Boolean) = "Absolute" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("zIndex")>] member this.zIndex (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commandParameter")>] member this.commandParameter (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudOverlay>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudOverlay>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudOverlay>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudOverlay>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudPopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudPopoverBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudPopover>, x) = attr.ref<MudBlazor.MudPopover> x |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<MudBlazor.MudPopover>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetX")>] member this.offsetX (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetY")>] member this.offsetY (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudPopover>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudPopover>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudPopover>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudPopover>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudPopover>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudProgressCircularBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x) = attr.ref<MudBlazor.MudProgressCircular> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("indeterminate")>] member this.indeterminate (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("min'")>] member this.min' (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max'")>] member this.max' (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strokeWidth")>] member this.strokeWidth (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minimum")>] member this.minimum (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Minimum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maximum")>] member this.maximum (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Double) = "Maximum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudProgressCircular>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudProgressLinearBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x) = attr.ref<MudBlazor.MudProgressLinear> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("indeterminate")>] member this.indeterminate (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buffer")>] member this.buffer (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Boolean) = "Buffer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("static'")>] member this.static' (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Boolean) = "Static" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strokeWidth")>] member this.strokeWidth (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("min'")>] member this.min' (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max'")>] member this.max' (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bufferValue")>] member this.bufferValue (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "BufferValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minimum")>] member this.minimum (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Minimum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maximum")>] member this.maximum (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Double) = "Maximum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudProgressLinear>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudRadioBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudRadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudRadioBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x) = attr.ref<MudBlazor.MudRadio<'T>> x |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: MudBlazor.Placement) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("option")>] member this.option (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: 'T) = "Option" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudRadio<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudRatingBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudRating>, x) = attr.ref<MudBlazor.MudRating> x |> this.AddProp
    [<CustomOperation("ratingItemsClass")>] member this.ratingItemsClass (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "RatingItemsClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ratingItemsStyle")>] member this.ratingItemsStyle (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "RatingItemsStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxValue")>] member this.maxValue (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Int32) = "MaxValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullIcon")>] member this.fullIcon (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "FullIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("emptyIcon")>] member this.emptyIcon (_: FunBlazorContext<MudBlazor.MudRating>, x: System.String) = "EmptyIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudRating>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudRating>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedValueChanged")>] member this.selectedValueChanged (_: FunBlazorContext<MudBlazor.MudRating>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedValue")>] member this.selectedValue (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Int32) = "SelectedValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hoveredValueChanged")>] member this.hoveredValueChanged (_: FunBlazorContext<MudBlazor.MudRating>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "HoveredValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudRating>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudRating>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudRating>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudRatingItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudRatingItem>, x) = attr.ref<MudBlazor.MudRatingItem> x |> this.AddProp
    [<CustomOperation("itemValue")>] member this.itemValue (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Int32) = "ItemValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemClicked")>] member this.itemClicked (_: FunBlazorContext<MudBlazor.MudRatingItem>, fn) = (Bolero.Html.attr.callback<System.Int32> "ItemClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemHovered")>] member this.itemHovered (_: FunBlazorContext<MudBlazor.MudRatingItem>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "ItemHovered" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudRatingItem>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudScrollToTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudScrollToTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudScrollToTopBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x) = attr.ref<MudBlazor.MudScrollToTop> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudScrollToTop>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selector")>] member this.selector (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.String) = "Selector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("visibleCssClass")>] member this.visibleCssClass (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.String) = "VisibleCssClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenCssClass")>] member this.hiddenCssClass (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.String) = "HiddenCssClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("topOffset")>] member this.topOffset (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.Int32) = "TopOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("scrollBehavior")>] member this.scrollBehavior (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: MudBlazor.ScrollBehavior) = "ScrollBehavior" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onScroll")>] member this.onScroll (_: FunBlazorContext<MudBlazor.MudScrollToTop>, fn) = (Bolero.Html.attr.callback<MudBlazor.ScrollEventArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudScrollToTop>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudSkeletonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSkeleton>, x) = attr.ref<MudBlazor.MudSkeleton> x |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("skeletonType")>] member this.skeletonType (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: MudBlazor.SkeletonType) = "SkeletonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("animation")>] member this.animation (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: MudBlazor.Animation) = "Animation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSkeleton>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSliderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudSliderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSliderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudSliderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x) = attr.ref<MudBlazor.MudSlider<'T>> x |> this.AddProp
    [<CustomOperation("min'")>] member this.min' (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: 'T) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max'")>] member this.max' (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: 'T) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("step")>] member this.step (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: 'T) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("converter")>] member this.converter (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: MudBlazor.Converter<'T>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("immediate")>] member this.immediate (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSlider<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSnackbarElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudSnackbarElementBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x) = attr.ref<MudBlazor.MudSnackbarElement> x |> this.AddProp
    [<CustomOperation("snackbar")>] member this.snackbar (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: MudBlazor.Snackbar) = "Snackbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSnackbarElement>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSnackbarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudSnackbarProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSnackbarProvider>, x) = attr.ref<MudBlazor.MudSnackbarProvider> x |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSnackbarProvider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSnackbarProvider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSnackbarProvider>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSnackbarProvider>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudSwipeAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSwipeAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudSwipeAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x) = attr.ref<MudBlazor.MudSwipeArea> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudSwipeArea>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSwipe")>] member this.onSwipe (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: System.Action<MudBlazor.SwipeDirection>) = "OnSwipe" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSwipeArea>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudSimpleTableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSimpleTableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudSimpleTableBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x) = attr.ref<MudBlazor.MudSimpleTable> x |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hover")>] member this.hover (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Hover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("outlined")>] member this.outlined (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("striped")>] member this.striped (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "Striped" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixedHeader")>] member this.fixedHeader (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudSimpleTable>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSimpleTable>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudTableBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTableBase>, x) = attr.ref<MudBlazor.MudTableBase> x |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("outlined")>] member this.outlined (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hover")>] member this.hover (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Hover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("striped")>] member this.striped (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Striped" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("breakpoint")>] member this.breakpoint (_: FunBlazorContext<MudBlazor.MudTableBase>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixedHeader")>] member this.fixedHeader (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixedFooter")>] member this.fixedFooter (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "FixedFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortLabel")>] member this.sortLabel (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "SortLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowUnsorted")>] member this.allowUnsorted (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "AllowUnsorted" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowsPerPage")>] member this.rowsPerPage (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Int32) = "RowsPerPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("currentPage")>] member this.currentPage (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Int32) = "CurrentPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiSelection")>] member this.multiSelection (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarContent")>] member this.toolBarContent (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "ToolBarContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarContentStr")>] member this.toolBarContentStr (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loadingProgressColor")>] member this.loadingProgressColor (_: FunBlazorContext<MudBlazor.MudTableBase>, x: MudBlazor.Color) = "LoadingProgressColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerContent")>] member this.headerContent (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "HeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerContentStr")>] member this.headerContentStr (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("customHeader")>] member this.customHeader (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "CustomHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerClass")>] member this.headerClass (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "HeaderClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerContent")>] member this.footerContent (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "FooterContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerContentStr")>] member this.footerContentStr (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("customFooter")>] member this.customFooter (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "CustomFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerClass")>] member this.footerClass (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "FooterClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("colGroup")>] member this.colGroup (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "ColGroup" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("colGroupStr")>] member this.colGroupStr (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pagerContent")>] member this.pagerContent (_: FunBlazorContext<MudBlazor.MudTableBase>, nodes) = Bolero.Html.attr.fragment "PagerContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pagerContentStr")>] member this.pagerContentStr (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCommitEditClick")>] member this.onCommitEditClick (_: FunBlazorContext<MudBlazor.MudTableBase>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCancelEditClick")>] member this.onCancelEditClick (_: FunBlazorContext<MudBlazor.MudTableBase>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("commitEditCommand")>] member this.commitEditCommand (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Windows.Input.ICommand) = "CommitEditCommand" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commitEditCommandParameter")>] member this.commitEditCommandParameter (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Object) = "CommitEditCommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commitEditTooltip")>] member this.commitEditTooltip (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "CommitEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelEditTooltip")>] member this.cancelEditTooltip (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "CancelEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commitEditIcon")>] member this.commitEditIcon (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "CommitEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelEditIcon")>] member this.cancelEditIcon (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "CancelEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("canCancelEdit")>] member this.canCancelEdit (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "CanCancelEdit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowEditPreview")>] member this.rowEditPreview (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Action<System.Object>) = "RowEditPreview" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowEditCommit")>] member this.rowEditCommit (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Action<System.Object>) = "RowEditCommit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowEditCancel")>] member this.rowEditCancel (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Action<System.Object>) = "RowEditCancel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("totalItems")>] member this.totalItems (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Int32) = "TotalItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowClass")>] member this.rowClass (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "RowClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowStyle")>] member this.rowStyle (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.String) = "RowStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rightAlignSmall")>] member this.rightAlignSmall (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Boolean) = "RightAlignSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTableBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTableBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTableBase>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudTableBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x) = attr.ref<MudBlazor.MudTable<'T>> x |> this.AddProp
    [<CustomOperation("rowTemplate")>] member this.rowTemplate (_: FunBlazorContext<MudBlazor.MudTable<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childRowContent")>] member this.childRowContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildRowContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowEditingTemplate")>] member this.rowEditingTemplate (_: FunBlazorContext<MudBlazor.MudTable<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowEditingTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("horizontalScrollbar")>] member this.horizontalScrollbar (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "HorizontalScrollbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("items")>] member this.items (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Collections.Generic.IEnumerable<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("filter")>] member this.filter (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Func<'T, System.Boolean>) = "Filter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRowClick")>] member this.onRowClick (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<MudBlazor.TableRowClickEventArgs<'T>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowClassFunc")>] member this.rowClassFunc (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Func<'T, System.Int32, System.String>) = "RowClassFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowStyleFunc")>] member this.rowStyleFunc (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Func<'T, System.Int32, System.String>) = "RowStyleFunc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedItem")>] member this.selectedItem (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: 'T) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedItemChanged")>] member this.selectedItemChanged (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<'T> "SelectedItemChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedItems")>] member this.selectedItems (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Collections.Generic.HashSet<'T>) = "SelectedItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedItemsChanged")>] member this.selectedItemsChanged (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedItemsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("serverData")>] member this.serverData (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Func<MudBlazor.TableState, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>) = "ServerData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("outlined")>] member this.outlined (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hover")>] member this.hover (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Hover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("striped")>] member this.striped (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Striped" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("breakpoint")>] member this.breakpoint (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixedHeader")>] member this.fixedHeader (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixedFooter")>] member this.fixedFooter (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "FixedFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortLabel")>] member this.sortLabel (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "SortLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowUnsorted")>] member this.allowUnsorted (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "AllowUnsorted" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowsPerPage")>] member this.rowsPerPage (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Int32) = "RowsPerPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("currentPage")>] member this.currentPage (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Int32) = "CurrentPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiSelection")>] member this.multiSelection (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarContent")>] member this.toolBarContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "ToolBarContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolBarContentStr")>] member this.toolBarContentStr (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loadingProgressColor")>] member this.loadingProgressColor (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: MudBlazor.Color) = "LoadingProgressColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerContent")>] member this.headerContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "HeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerContentStr")>] member this.headerContentStr (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("customHeader")>] member this.customHeader (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "CustomHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerClass")>] member this.headerClass (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "HeaderClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerContent")>] member this.footerContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "FooterContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerContentStr")>] member this.footerContentStr (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("customFooter")>] member this.customFooter (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "CustomFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerClass")>] member this.footerClass (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "FooterClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("colGroup")>] member this.colGroup (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "ColGroup" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("colGroupStr")>] member this.colGroupStr (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pagerContent")>] member this.pagerContent (_: FunBlazorContext<MudBlazor.MudTable<'T>>, nodes) = Bolero.Html.attr.fragment "PagerContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pagerContentStr")>] member this.pagerContentStr (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCommitEditClick")>] member this.onCommitEditClick (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCancelEditClick")>] member this.onCancelEditClick (_: FunBlazorContext<MudBlazor.MudTable<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("commitEditCommand")>] member this.commitEditCommand (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Windows.Input.ICommand) = "CommitEditCommand" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commitEditCommandParameter")>] member this.commitEditCommandParameter (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Object) = "CommitEditCommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commitEditTooltip")>] member this.commitEditTooltip (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "CommitEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelEditTooltip")>] member this.cancelEditTooltip (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "CancelEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("commitEditIcon")>] member this.commitEditIcon (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "CommitEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelEditIcon")>] member this.cancelEditIcon (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "CancelEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("canCancelEdit")>] member this.canCancelEdit (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "CanCancelEdit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowEditPreview")>] member this.rowEditPreview (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Action<System.Object>) = "RowEditPreview" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowEditCommit")>] member this.rowEditCommit (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Action<System.Object>) = "RowEditCommit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowEditCancel")>] member this.rowEditCancel (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Action<System.Object>) = "RowEditCancel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("totalItems")>] member this.totalItems (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Int32) = "TotalItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowClass")>] member this.rowClass (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "RowClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowStyle")>] member this.rowStyle (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.String) = "RowStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rightAlignSmall")>] member this.rightAlignSmall (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Boolean) = "RightAlignSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTable<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudTablePagerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTablePager>, x) = attr.ref<MudBlazor.MudTablePager> x |> this.AddProp
    [<CustomOperation("disableRowsPerPage")>] member this.disableRowsPerPage (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.Boolean) = "DisableRowsPerPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageSizeOptions")>] member this.pageSizeOptions (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("infoFormat")>] member this.infoFormat (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.String) = "InfoFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowsPerPageString")>] member this.rowsPerPageString (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.String) = "RowsPerPageString" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTablePager>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTablePager>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTablePager>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTableSortLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTableSortLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTableSortLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTableSortLabelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x) = attr.ref<MudBlazor.MudTableSortLabel<'T>> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("initialDirection")>] member this.initialDirection (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: MudBlazor.SortDirection) = "InitialDirection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("enabled")>] member this.enabled (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Boolean) = "Enabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortIcon")>] member this.sortIcon (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.String) = "SortIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("appendIcon")>] member this.appendIcon (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Boolean) = "AppendIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortDirection")>] member this.sortDirection (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: MudBlazor.SortDirection) = "SortDirection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortDirectionChanged")>] member this.sortDirectionChanged (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, fn) = (Bolero.Html.attr.callback<MudBlazor.SortDirection> "SortDirectionChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortBy")>] member this.sortBy (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Func<'T, System.Object>) = "SortBy" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortLabel")>] member this.sortLabel (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.String) = "SortLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTableSortLabel<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTdBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTdBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTdBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTd>, x) = attr.ref<MudBlazor.MudTd> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTd>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTd>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dataLabel")>] member this.dataLabel (_: FunBlazorContext<MudBlazor.MudTd>, x: System.String) = "DataLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideSmall")>] member this.hideSmall (_: FunBlazorContext<MudBlazor.MudTd>, x: System.Boolean) = "HideSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTd>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTd>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTd>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTd>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTFootRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTFootRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTFootRowBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTFootRow>, x) = attr.ref<MudBlazor.MudTFootRow> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTFootRow>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCheckable")>] member this.isCheckable (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ignoreCheckbox")>] member this.ignoreCheckbox (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Boolean) = "IgnoreCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ignoreEditable")>] member this.ignoreEditable (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Boolean) = "IgnoreEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRowClick")>] member this.onRowClick (_: FunBlazorContext<MudBlazor.MudTFootRow>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTFootRow>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudThBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudThBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudThBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTh>, x) = attr.ref<MudBlazor.MudTh> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTh>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTh>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTh>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTh>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTh>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTh>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTHeadRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTHeadRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTHeadRowBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x) = attr.ref<MudBlazor.MudTHeadRow> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTHeadRow>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCheckable")>] member this.isCheckable (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ignoreCheckbox")>] member this.ignoreCheckbox (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Boolean) = "IgnoreCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ignoreEditable")>] member this.ignoreEditable (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Boolean) = "IgnoreEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRowClick")>] member this.onRowClick (_: FunBlazorContext<MudBlazor.MudTHeadRow>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTHeadRow>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTrBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTrBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTrBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTr>, x) = attr.ref<MudBlazor.MudTr> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTr>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTr>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("item")>] member this.item (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Object) = "Item" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCheckable")>] member this.isCheckable (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isEditable")>] member this.isEditable (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isHeader")>] member this.isHeader (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isFooter")>] member this.isFooter (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCheckedChanged")>] member this.isCheckedChanged (_: FunBlazorContext<MudBlazor.MudTr>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsCheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("isChecked")>] member this.isChecked (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Boolean) = "IsChecked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTr>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTr>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTr>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTabsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTabs>, x) = attr.ref<MudBlazor.MudTabs> x |> this.AddProp
    [<CustomOperation("keepPanelsAlive")>] member this.keepPanelsAlive (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "KeepPanelsAlive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rounded")>] member this.rounded (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("border")>] member this.border (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "Border" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("outlined")>] member this.outlined (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("centered")>] member this.centered (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "Centered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideSlider")>] member this.hideSlider (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "HideSlider" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prevIcon")>] member this.prevIcon (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.String) = "PrevIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("nextIcon")>] member this.nextIcon (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.String) = "NextIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("alwaysShowScrollButtons")>] member this.alwaysShowScrollButtons (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "AlwaysShowScrollButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("position")>] member this.position (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Position) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sliderColor")>] member this.sliderColor (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Color) = "SliderColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("scrollIconColor")>] member this.scrollIconColor (_: FunBlazorContext<MudBlazor.MudTabs>, x: MudBlazor.Color) = "ScrollIconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("applyEffectsToContainer")>] member this.applyEffectsToContainer (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "ApplyEffectsToContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableRipple")>] member this.disableRipple (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTabs>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTabs>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabPanelClass")>] member this.tabPanelClass (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.String) = "TabPanelClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("panelClass")>] member this.panelClass (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.String) = "PanelClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("activePanelIndex")>] member this.activePanelIndex (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Int32) = "ActivePanelIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("activePanelIndexChanged")>] member this.activePanelIndexChanged (_: FunBlazorContext<MudBlazor.MudTabs>, fn) = (Bolero.Html.attr.callback<System.Int32> "ActivePanelIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTabs>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTabs>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTabs>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTimeLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTimeLineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTimeLineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTimeLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTimeLine>, x) = attr.ref<MudBlazor.MudTimeLine> x |> this.AddProp
    [<CustomOperation("rounded")>] member this.rounded (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("border")>] member this.border (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Boolean) = "Border" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("outlined")>] member this.outlined (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTimeLine>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTimeLine>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTimeLineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTimeLineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTimeLineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTimeLineItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x) = attr.ref<MudBlazor.MudTimeLineItem> x |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("align")>] member this.align (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: MudBlazor.Align) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTimeLineItem>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTooltipBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTooltip>, x) = attr.ref<MudBlazor.MudTooltip> x |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("delay")>] member this.delay (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Double) = "Delay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("delayed")>] member this.delayed (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Double) = "Delayed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<MudBlazor.MudTooltip>, x: MudBlazor.Placement) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTooltip>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTooltip>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tooltipContent")>] member this.tooltipContent (_: FunBlazorContext<MudBlazor.MudTooltip>, nodes) = Bolero.Html.attr.fragment "TooltipContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tooltipContentStr")>] member this.tooltipContentStr (_: FunBlazorContext<MudBlazor.MudTooltip>, x: string) = Bolero.Html.attr.fragment "TooltipContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inline'")>] member this.inline' (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Boolean) = "Inline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTooltip>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTooltip>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTooltip>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTreeViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTreeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTreeViewBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTreeViewBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x) = attr.ref<MudBlazor.MudTreeView<'T>> x |> this.AddProp
    [<CustomOperation("canSelect")>] member this.canSelect (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "CanSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("canActivate")>] member this.canActivate (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "CanActivate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandOnClick")>] member this.expandOnClick (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "ExpandOnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("canHover")>] member this.canHover (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "CanHover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.String) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("items")>] member this.items (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("activatedValueChanged")>] member this.activatedValueChanged (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, fn) = (Bolero.Html.attr.callback<'T> "ActivatedValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedValuesChanged")>] member this.selectedValuesChanged (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemTemplate")>] member this.itemTemplate (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("serverData")>] member this.serverData (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.HashSet<'T>>>) = "ServerData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTreeView<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTreeViewItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTreeViewItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTreeViewItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTreeViewItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x) = attr.ref<MudBlazor.MudTreeViewItem<'T>> x |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("culture")>] member this.culture (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textTypo")>] member this.textTypo (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: MudBlazor.Typo) = "TextTypo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textClass")>] member this.textClass (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "TextClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("endText")>] member this.endText (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "EndText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("endTextTypo")>] member this.endTextTypo (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: MudBlazor.Typo) = "EndTextTypo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("endTextClass")>] member this.endTextClass (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "EndTextClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("content")>] member this.content (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, nodes) = Bolero.Html.attr.fragment "Content" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentStr")>] member this.contentStr (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("items")>] member this.items (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("command")>] member this.command (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expanded")>] member this.expanded (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("activated")>] member this.activated (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Boolean) = "Activated" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selected")>] member this.selected (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Boolean) = "Selected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconColor")>] member this.iconColor (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("endIcon")>] member this.endIcon (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("endIconColor")>] member this.endIconColor (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: MudBlazor.Color) = "EndIconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("activatedChanged")>] member this.activatedChanged (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ActivatedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandedChanged")>] member this.expandedChanged (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedChanged")>] member this.selectedChanged (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTreeViewItem<'T>>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTextBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudText>, x) = attr.ref<MudBlazor.MudText> x |> this.AddProp
    [<CustomOperation("typo")>] member this.typo (_: FunBlazorContext<MudBlazor.MudText>, x: MudBlazor.Typo) = "Typo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("align")>] member this.align (_: FunBlazorContext<MudBlazor.MudText>, x: MudBlazor.Align) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudText>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("gutterBottom")>] member this.gutterBottom (_: FunBlazorContext<MudBlazor.MudText>, x: System.Boolean) = "GutterBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudText>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudText>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("inline'")>] member this.inline' (_: FunBlazorContext<MudBlazor.MudText>, x: System.Boolean) = "Inline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudText>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudText>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudText>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudText>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudContainer>, x) = attr.ref<MudBlazor.MudContainer> x |> this.AddProp
    [<CustomOperation("fixed'")>] member this.fixed' (_: FunBlazorContext<MudBlazor.MudContainer>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxWidth")>] member this.maxWidth (_: FunBlazorContext<MudBlazor.MudContainer>, x: MudBlazor.MaxWidth) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudContainer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudContainer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudContainer>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudContainer>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudDividerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDivider>, x) = attr.ref<MudBlazor.MudDivider> x |> this.AddProp
    [<CustomOperation("absolute")>] member this.absolute (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Boolean) = "Absolute" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("flexItem")>] member this.flexItem (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Boolean) = "FlexItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("light")>] member this.light (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Boolean) = "Light" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("vertical")>] member this.vertical (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Boolean) = "Vertical" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dividerType")>] member this.dividerType (_: FunBlazorContext<MudBlazor.MudDivider>, x: MudBlazor.DividerType) = "DividerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDivider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDivider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDivider>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudDrawerHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x) = attr.ref<MudBlazor.MudDrawerHeader> x |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("linkToIndex")>] member this.linkToIndex (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: System.Boolean) = "LinkToIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudDrawerHeader>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudGridBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudGrid>, x) = attr.ref<MudBlazor.MudGrid> x |> this.AddProp
    [<CustomOperation("spacing")>] member this.spacing (_: FunBlazorContext<MudBlazor.MudGrid>, x: System.Int32) = "Spacing" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("justify")>] member this.justify (_: FunBlazorContext<MudBlazor.MudGrid>, x: MudBlazor.Justify) = "Justify" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudGrid>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudGrid>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudGrid>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudGrid>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudGrid>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudGrid>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudItem>, x) = attr.ref<MudBlazor.MudItem> x |> this.AddProp
    [<CustomOperation("xs")>] member this.xs (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "xs" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sm")>] member this.sm (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "sm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("md")>] member this.md (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "md" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lg")>] member this.lg (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "lg" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xl")>] member this.xl (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Int32) = "xl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudItem>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudHighlighterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudHighlighter>, x) = attr.ref<MudBlazor.MudHighlighter> x |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("highlightedText")>] member this.highlightedText (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.String) = "HighlightedText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("caseSensitive")>] member this.caseSensitive (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.Boolean) = "CaseSensitive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("untilNextBoundary")>] member this.untilNextBoundary (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.Boolean) = "UntilNextBoundary" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudHighlighter>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudMainContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudMainContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMainContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudMainContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudMainContent>, x) = attr.ref<MudBlazor.MudMainContent> x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudMainContent>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudMainContent>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudMainContent>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudMainContent>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudMainContent>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudMainContent>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudPaperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudPaperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPaperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudPaperBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudPaper>, x) = attr.ref<MudBlazor.MudPaper> x |> this.AddProp
    [<CustomOperation("elevation")>] member this.elevation (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("square")>] member this.square (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("outlined")>] member this.outlined (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxHeight")>] member this.maxHeight (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxWidth")>] member this.maxWidth (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minHeight")>] member this.minHeight (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "MinHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minWidth")>] member this.minWidth (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.String) = "MinWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudPaper>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudPaper>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudPaper>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudPaper>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudPaper>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudSparkLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudSparkLineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSparkLine>, x) = attr.ref<MudBlazor.MudSparkLine> x |> this.AddProp
    [<CustomOperation("strokeWidth")>] member this.strokeWidth (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudSparkLine>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudTabPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTabPanel>, x) = attr.ref<MudBlazor.MudTabPanel> x |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("badgeData")>] member this.badgeData (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Object) = "BadgeData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("badgeColor")>] member this.badgeColor (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: MudBlazor.Color) = "BadgeColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iD")>] member this.iD (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Object) = "ID" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<MudBlazor.MudTabPanel>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudTabPanel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("toolTip")>] member this.toolTip (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.String) = "ToolTip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudTabPanel>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudToolBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudToolBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudToolBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudToolBarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudToolBar>, x) = attr.ref<MudBlazor.MudToolBar> x |> this.AddProp
    [<CustomOperation("dense")>] member this.dense (_: FunBlazorContext<MudBlazor.MudToolBar>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableGutters")>] member this.disableGutters (_: FunBlazorContext<MudBlazor.MudToolBar>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudToolBar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudToolBar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudToolBar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudToolBar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<MudBlazor.MudToolBar>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("userAttributes")>] member this.userAttributes (_: FunBlazorContext<MudBlazor.MudToolBar>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudDialogProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x) = attr.ref<MudBlazor.MudDialogProvider> x |> this.AddProp
    [<CustomOperation("noHeader")>] member this.noHeader (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<System.Boolean>) = "NoHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeButton")>] member this.closeButton (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<System.Boolean>) = "CloseButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableBackdropClick")>] member this.disableBackdropClick (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<System.Boolean>) = "DisableBackdropClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullWidth")>] member this.fullWidth (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<System.Boolean>) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("position")>] member this.position (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<MudBlazor.DialogPosition>) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxWidth")>] member this.maxWidth (_: FunBlazorContext<MudBlazor.MudDialogProvider>, x: System.Nullable<MudBlazor.MaxWidth>) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
                

type BaseMudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = BaseMudThemeProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.BaseMudThemeProvider>, x) = attr.ref<MudBlazor.BaseMudThemeProvider> x |> this.AddProp
    [<CustomOperation("theme")>] member this.theme (_: FunBlazorContext<MudBlazor.BaseMudThemeProvider>, x: MudBlazor.MudTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
                

type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudThemeProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudThemeProvider>, x) = attr.ref<MudBlazor.MudThemeProvider> x |> this.AddProp
    [<CustomOperation("theme")>] member this.theme (_: FunBlazorContext<MudBlazor.MudThemeProvider>, x: MudBlazor.MudTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
                

type MudAppBarSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudAppBarSpacerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudAppBarSpacer>, x) = attr.ref<MudBlazor.MudAppBarSpacer> x |> this.AddProp

                

type BreadcrumbLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = BreadcrumbLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.BreadcrumbLink>, x) = attr.ref<MudBlazor.BreadcrumbLink> x |> this.AddProp
    [<CustomOperation("item")>] member this.item (_: FunBlazorContext<MudBlazor.BreadcrumbLink>, x: MudBlazor.BreadcrumbItem) = "Item" => x |> BoleroAttr |> this.AddProp
                

type BreadcrumbSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = BreadcrumbSeparatorBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.BreadcrumbSeparator>, x) = attr.ref<MudBlazor.BreadcrumbSeparator> x |> this.AddProp

                

type MudPickerContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudPickerContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPickerContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudPickerContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudPickerContent>, x) = attr.ref<MudBlazor.MudPickerContent> x |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudPickerContent>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudPickerContent>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudPickerContent>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudPickerToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudPickerToolbarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPickerToolbarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    
    member this.Yield _ = MudPickerToolbarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x) = attr.ref<MudBlazor.MudPickerToolbar> x |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("disableToolbar")>] member this.disableToolbar (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContentStr")>] member this.childContentStr (_: FunBlazorContext<MudBlazor.MudPickerToolbar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudSpacerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudSpacer>, x) = attr.ref<MudBlazor.MudSpacer> x |> this.AddProp

                

type MudToolBarSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudToolBarSpacerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudToolBarSpacer>, x) = attr.ref<MudBlazor.MudToolBarSpacer> x |> this.AddProp

                

type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x) = attr.ref<MudBlazor.MudTreeViewItemToggleButton> x |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expanded")>] member this.expanded (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandedChanged")>] member this.expandedChanged (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandedIcon")>] member this.expandedIcon (_: FunBlazorContext<MudBlazor.MudTreeViewItemToggleButton>, x: System.String) = "ExpandedIcon" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open MudBlazor.DslInternals


type MudInputAdornmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = MudInputAdornmentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x) = attr.ref<MudBlazor.Internal.MudInputAdornment> x |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("edge")>] member this.edge (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("adornmentClick")>] member this.adornmentClick (_: FunBlazorContext<MudBlazor.Internal.MudInputAdornment>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals.Charts

open Bolero.Html
open Fun.Blazor
open Fun.Blazor.Web.DslInternals
open MudBlazor.DslInternals


type FiltersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()

    
    member this.Yield _ = FiltersBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ref'")>] member this.ref' (_: FunBlazorContext<MudBlazor.Charts.Filters>, x) = attr.ref<MudBlazor.Charts.Filters> x |> this.AddProp

                
            

// =======================================================================================================================

namespace MudBlazor

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals

    type mudComponentBase = MudComponentBaseBuilder<MudBlazor.MudComponentBase>
    type mudBaseButton = MudBaseButtonBuilder<MudBlazor.MudBaseButton>
    type mudButton = MudButtonBuilder<MudBlazor.MudButton>
    type mudFab = MudFabBuilder<MudBlazor.MudFab>
    type mudIconButton = MudIconButtonBuilder<MudBlazor.MudIconButton>
    type mudMenu = MudMenuBuilder<MudBlazor.MudMenu>
    type mudFileUploader = MudFileUploaderBuilder<MudBlazor.MudFileUploader>
    type mudBaseItemsControl<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseItemsControlBuilder<MudBlazor.MudBaseItemsControl<'TChildComponent>>
    type mudBaseBindableItemsControl<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseBindableItemsControlBuilder<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>>
    type mudCarousel<'TData> = MudCarouselBuilder<MudBlazor.MudCarousel<'TData>>
    type mudBaseSelectItem = MudBaseSelectItemBuilder<MudBlazor.MudBaseSelectItem>
    type mudNavLink = MudNavLinkBuilder<MudBlazor.MudNavLink>
    type mudSelectItem<'T> = MudSelectItemBuilder<MudBlazor.MudSelectItem<'T>>
    type mudFormComponent<'T, 'U> = MudFormComponentBuilder<MudBlazor.MudFormComponent<'T, 'U>>
    type mudBaseInput<'T> = MudBaseInputBuilder<MudBlazor.MudBaseInput<'T>>
    type mudAutocomplete<'T> = MudAutocompleteBuilder<MudBlazor.MudAutocomplete<'T>>
    type mudDebouncedInput<'T> = MudDebouncedInputBuilder<MudBlazor.MudDebouncedInput<'T>>
    type mudNumericField<'T> = MudNumericFieldBuilder<MudBlazor.MudNumericField<'T>>
    type mudTextField<'T> = MudTextFieldBuilder<MudBlazor.MudTextField<'T>>
    type mudTextFieldString = MudTextFieldStringBuilder<MudBlazor.MudTextFieldString>
    type mudInput<'T> = MudInputBuilder<MudBlazor.MudInput<'T>>
    type mudInputString = MudInputStringBuilder<MudBlazor.MudInputString>
    type mudRangeInput<'T> = MudRangeInputBuilder<MudBlazor.MudRangeInput<'T>>
    type mudSelect<'T> = MudSelectBuilder<MudBlazor.MudSelect<'T>>
    type mudBooleanInput<'T> = MudBooleanInputBuilder<MudBlazor.MudBooleanInput<'T>>
    type mudCheckBox<'T> = MudCheckBoxBuilder<MudBlazor.MudCheckBox<'T>>
    type mudSwitch<'T> = MudSwitchBuilder<MudBlazor.MudSwitch<'T>>
    type mudPicker<'T> = MudPickerBuilder<MudBlazor.MudPicker<'T>>
    type mudBaseDatePicker = MudBaseDatePickerBuilder<MudBlazor.MudBaseDatePicker>
    type mudDatePicker = MudDatePickerBuilder<MudBlazor.MudDatePicker>
    type mudDateRangePicker = MudDateRangePickerBuilder<MudBlazor.MudDateRangePicker>
    type mudTimePicker = MudTimePickerBuilder<MudBlazor.MudTimePicker>
    type mudRadioGroup<'T> = MudRadioGroupBuilder<MudBlazor.MudRadioGroup<'T>>
    type mudAlert = MudAlertBuilder<MudBlazor.MudAlert>
    type mudAppBar = MudAppBarBuilder<MudBlazor.MudAppBar>
    type mudAvatar = MudAvatarBuilder<MudBlazor.MudAvatar>
    type mudBadge = MudBadgeBuilder<MudBlazor.MudBadge>
    type mudBreadcrumbs = MudBreadcrumbsBuilder<MudBlazor.MudBreadcrumbs>
    type mudButtonGroup = MudButtonGroupBuilder<MudBlazor.MudButtonGroup>
    type mudToggleIconButton = MudToggleIconButtonBuilder<MudBlazor.MudToggleIconButton>
    type mudCard = MudCardBuilder<MudBlazor.MudCard>
    type mudCardActions = MudCardActionsBuilder<MudBlazor.MudCardActions>
    type mudCardContent = MudCardContentBuilder<MudBlazor.MudCardContent>
    type mudCardHeader = MudCardHeaderBuilder<MudBlazor.MudCardHeader>
    type mudCardMedia = MudCardMediaBuilder<MudBlazor.MudCardMedia>
    type mudCarouselItem = MudCarouselItemBuilder<MudBlazor.MudCarouselItem>
    type mudChartBase = MudChartBaseBuilder<MudBlazor.MudChartBase>
    type mudChart = MudChartBuilder<MudBlazor.MudChart>
    type mudChipSet = MudChipSetBuilder<MudBlazor.MudChipSet>
    type mudChip = MudChipBuilder<MudBlazor.MudChip>
    type mudCollapse = MudCollapseBuilder<MudBlazor.MudCollapse>
    type mudDialog = MudDialogBuilder<MudBlazor.MudDialog>
    type mudDialogInstance = MudDialogInstanceBuilder<MudBlazor.MudDialogInstance>
    type mudDrawer = MudDrawerBuilder<MudBlazor.MudDrawer>
    type mudDrawerContainer = MudDrawerContainerBuilder<MudBlazor.MudDrawerContainer>
    type mudLayout = MudLayoutBuilder<MudBlazor.MudLayout>
    type mudElement = MudElementBuilder<MudBlazor.MudElement>
    type mudExpansionPanel = MudExpansionPanelBuilder<MudBlazor.MudExpansionPanel>
    type mudExpansionPanels = MudExpansionPanelsBuilder<MudBlazor.MudExpansionPanels>
    type mudField = MudFieldBuilder<MudBlazor.MudField>
    type mudFocusTrap = MudFocusTrapBuilder<MudBlazor.MudFocusTrap>
    type mudForm = MudFormBuilder<MudBlazor.MudForm>
    type mudHidden = MudHiddenBuilder<MudBlazor.MudHidden>
    type mudIcon = MudIconBuilder<MudBlazor.MudIcon>
    type mudInputControl = MudInputControlBuilder<MudBlazor.MudInputControl>
    type mudInputLabel = MudInputLabelBuilder<MudBlazor.MudInputLabel>
    type mudLink = MudLinkBuilder<MudBlazor.MudLink>
    type mudList = MudListBuilder<MudBlazor.MudList>
    type mudListItem = MudListItemBuilder<MudBlazor.MudListItem>
    type mudListSubheader = MudListSubheaderBuilder<MudBlazor.MudListSubheader>
    type mudMenuItem = MudMenuItemBuilder<MudBlazor.MudMenuItem>
    type mudMessageBox = MudMessageBoxBuilder<MudBlazor.MudMessageBox>
    type mudNavGroup = MudNavGroupBuilder<MudBlazor.MudNavGroup>
    type mudNavMenu = MudNavMenuBuilder<MudBlazor.MudNavMenu>
    type mudOverlay = MudOverlayBuilder<MudBlazor.MudOverlay>
    type mudPopover = MudPopoverBuilder<MudBlazor.MudPopover>
    type mudProgressCircular = MudProgressCircularBuilder<MudBlazor.MudProgressCircular>
    type mudProgressLinear = MudProgressLinearBuilder<MudBlazor.MudProgressLinear>
    type mudRadio<'T> = MudRadioBuilder<MudBlazor.MudRadio<'T>>
    type mudRating = MudRatingBuilder<MudBlazor.MudRating>
    type mudRatingItem = MudRatingItemBuilder<MudBlazor.MudRatingItem>
    type mudScrollToTop = MudScrollToTopBuilder<MudBlazor.MudScrollToTop>
    type mudSkeleton = MudSkeletonBuilder<MudBlazor.MudSkeleton>
    type mudSlider<'T> = MudSliderBuilder<MudBlazor.MudSlider<'T>>
    type mudSnackbarElement = MudSnackbarElementBuilder<MudBlazor.MudSnackbarElement>
    type mudSnackbarProvider = MudSnackbarProviderBuilder<MudBlazor.MudSnackbarProvider>
    type mudSwipeArea = MudSwipeAreaBuilder<MudBlazor.MudSwipeArea>
    type mudSimpleTable = MudSimpleTableBuilder<MudBlazor.MudSimpleTable>
    type mudTableBase = MudTableBaseBuilder<MudBlazor.MudTableBase>
    type mudTable<'T> = MudTableBuilder<MudBlazor.MudTable<'T>>
    type mudTablePager = MudTablePagerBuilder<MudBlazor.MudTablePager>
    type mudTableSortLabel<'T> = MudTableSortLabelBuilder<MudBlazor.MudTableSortLabel<'T>>
    type mudTd = MudTdBuilder<MudBlazor.MudTd>
    type mudTFootRow = MudTFootRowBuilder<MudBlazor.MudTFootRow>
    type mudTh = MudThBuilder<MudBlazor.MudTh>
    type mudTHeadRow = MudTHeadRowBuilder<MudBlazor.MudTHeadRow>
    type mudTr = MudTrBuilder<MudBlazor.MudTr>
    type mudTabs = MudTabsBuilder<MudBlazor.MudTabs>
    type mudTimeLine = MudTimeLineBuilder<MudBlazor.MudTimeLine>
    type mudTimeLineItem = MudTimeLineItemBuilder<MudBlazor.MudTimeLineItem>
    type mudTooltip = MudTooltipBuilder<MudBlazor.MudTooltip>
    type mudTreeView<'T> = MudTreeViewBuilder<MudBlazor.MudTreeView<'T>>
    type mudTreeViewItem<'T> = MudTreeViewItemBuilder<MudBlazor.MudTreeViewItem<'T>>
    type mudText = MudTextBuilder<MudBlazor.MudText>
    type mudContainer = MudContainerBuilder<MudBlazor.MudContainer>
    type mudDivider = MudDividerBuilder<MudBlazor.MudDivider>
    type mudDrawerHeader = MudDrawerHeaderBuilder<MudBlazor.MudDrawerHeader>
    type mudGrid = MudGridBuilder<MudBlazor.MudGrid>
    type mudItem = MudItemBuilder<MudBlazor.MudItem>
    type mudHighlighter = MudHighlighterBuilder<MudBlazor.MudHighlighter>
    type mudMainContent = MudMainContentBuilder<MudBlazor.MudMainContent>
    type mudPaper = MudPaperBuilder<MudBlazor.MudPaper>
    type mudSparkLine = MudSparkLineBuilder<MudBlazor.MudSparkLine>
    type mudTabPanel = MudTabPanelBuilder<MudBlazor.MudTabPanel>
    type mudToolBar = MudToolBarBuilder<MudBlazor.MudToolBar>
    type mudDialogProvider = MudDialogProviderBuilder<MudBlazor.MudDialogProvider>
    type baseMudThemeProvider = BaseMudThemeProviderBuilder<MudBlazor.BaseMudThemeProvider>
    type mudThemeProvider = MudThemeProviderBuilder<MudBlazor.MudThemeProvider>
    type mudAppBarSpacer = MudAppBarSpacerBuilder<MudBlazor.MudAppBarSpacer>
    type breadcrumbLink = BreadcrumbLinkBuilder<MudBlazor.BreadcrumbLink>
    type breadcrumbSeparator = BreadcrumbSeparatorBuilder<MudBlazor.BreadcrumbSeparator>
    type mudPickerContent = MudPickerContentBuilder<MudBlazor.MudPickerContent>
    type mudPickerToolbar = MudPickerToolbarBuilder<MudBlazor.MudPickerToolbar>
    type mudSpacer = MudSpacerBuilder<MudBlazor.MudSpacer>
    type mudToolBarSpacer = MudToolBarSpacerBuilder<MudBlazor.MudToolBarSpacer>
    type mudTreeViewItemToggleButton = MudTreeViewItemToggleButtonBuilder<MudBlazor.MudTreeViewItemToggleButton>
            
namespace MudBlazor.Charts

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Charts

    type bar = BarBuilder<MudBlazor.Charts.Bar>
    type donut = DonutBuilder<MudBlazor.Charts.Donut>
    type line = LineBuilder<MudBlazor.Charts.Line>
    type pie = PieBuilder<MudBlazor.Charts.Pie>
    type legend = LegendBuilder<MudBlazor.Charts.Legend>
    type filters = FiltersBuilder<MudBlazor.Charts.Filters>
            
namespace MudBlazor.Internal

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Internal

    type mudInputAdornment = MudInputAdornmentBuilder<MudBlazor.Internal.MudInputAdornment>
            