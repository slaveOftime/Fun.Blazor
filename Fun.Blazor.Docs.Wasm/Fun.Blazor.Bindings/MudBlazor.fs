namespace rec MudBlazor.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type MudComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MudComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<'FunBlazorGeneric>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UserAttributes")>] member this.UserAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> BoleroAttr |> this.AddProp
                

type MudBaseButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudBaseButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonType")>] member this.ButtonType (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.ButtonType) = "ButtonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("StartIcon")>] member this.StartIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "StartIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconClass")>] member this.IconClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "IconClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
                

type MudFabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    static member create () = MudFabBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
                

type MudIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudIconButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudIconButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudIconButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudIconButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
                

type MudMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StartIcon")>] member this.StartIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "StartIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PositionAtCurser")>] member this.PositionAtCurser (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "PositionAtCurser" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ActivatorContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivationEvent")>] member this.ActivationEvent (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.MouseEvent) = "ActivationEvent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
                

type MudFileUploaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    static member create () = MudFileUploaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>(x) :> IFunBlazorNode
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>()
    static member create () = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData>() :> IFunBlazorNode
    [<CustomOperation("ItemsSource")>] member this.ItemsSource (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TData>) = "ItemsSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TData -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudCarouselBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudCarouselItem, 'TData>()
    static member create () = MudCarouselBuilder<'FunBlazorGeneric, 'TData>() :> IFunBlazorNode
    [<CustomOperation("ShowArrows")>] member this.ShowArrows (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowArrows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowDelimiters")>] member this.ShowDelimiters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowDelimiters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoCycle")>] member this.AutoCycle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoCycle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoCycleTime")>] member this.AutoCycleTime (_: FunBlazorContext<'FunBlazorGeneric>, x: System.TimeSpan) = "AutoCycleTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NextButtonTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DelimiterTemplate")>] member this.DelimiterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: System.Boolean -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "DelimiterTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudBaseSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBaseSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudBaseSelectItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudBaseSelectItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    static member create () = MudNavLinkBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Match")>] member this.Match (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
                

type MudSelectItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    static member create () = MudSelectItemBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
                

type MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U>() :> IFunBlazorNode
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RequiredError" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Converter<'T, 'U>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Validation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("For'")>] member this.For' (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> BoleroAttr |> this.AddProp
                

type MudBaseInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    static member create () = MudBaseInputBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "AdornmentColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Clearable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.InputType) = "InputType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Lines" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "KeyDownPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "KeyPressPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "KeyUpPreventDefault" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
                

type MudAutocompleteBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    static member create () = MudAutocompleteBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenIcon")>] member this.OpenIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OpenIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToStringFunc")>] member this.ToStringFunc (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "ToStringFunc" => (System.Func<'T, System.String>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SearchFunc")>] member this.SearchFunc (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "SearchFunc" => (System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxItems")>] member this.MaxItems (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinCharacters")>] member this.MinCharacters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MinCharacters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ResetValueOnEmptyText")>] member this.ResetValueOnEmptyText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ResetValueOnEmptyText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemSelectedTemplate")>] member this.ItemSelectedTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemSelectedTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CoerceText")>] member this.CoerceText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CoerceText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CoerceValue")>] member this.CoerceValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CoerceValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsOpenChanged")>] member this.IsOpenChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsOpenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudDebouncedInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    static member create () = MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "DebounceInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDebounceIntervalElapsed")>] member this.OnDebounceIntervalElapsed (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudNumericFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    static member create () = MudNumericFieldBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSpinButtons")>] member this.HideSpinButtons (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideSpinButtons" => x |> BoleroAttr |> this.AddProp
                

type MudTextFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    static member create () = MudTextFieldBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
                

type MudTextFieldStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTextFieldBuilder<'FunBlazorGeneric, System.String>()
    static member create () = MudTextFieldStringBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MudInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    new (x: string) as this = MudInputBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudInputBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudInputBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnIncrement")>] member this.OnIncrement (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnIncrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDecrement")>] member this.OnDecrement (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnDecrement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSpinButtons")>] member this.HideSpinButtons (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideSpinButtons" => x |> BoleroAttr |> this.AddProp
                

type MudInputStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudInputBuilder<'FunBlazorGeneric, System.String>()
    static member create () = MudInputStringBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MudRangeInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, MudBlazor.Range<'T>>()
    new (x: string) as this = MudRangeInputBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRangeInputBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudRangeInputBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudRangeInputBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("PlaceholderStart")>] member this.PlaceholderStart (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PlaceholderStart" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlaceholderEnd")>] member this.PlaceholderEnd (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PlaceholderEnd" => x |> BoleroAttr |> this.AddProp
                

type MudSelectBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    new (x: string) as this = MudSelectBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSelectBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSelectBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSelectBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenIcon")>] member this.OpenIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OpenIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValuesChanged")>] member this.SelectedValuesChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiSelectionTextFunc")>] member this.MultiSelectionTextFunc (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "MultiSelectionTextFunc" => (System.Func<System.Collections.Generic.List<System.String>, System.String>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValues")>] member this.SelectedValues (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.HashSet<'T>) = "SelectedValues" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToStringFunc")>] member this.ToStringFunc (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "ToStringFunc" => (System.Func<'T, System.String>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Strict")>] member this.Strict (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Strict" => x |> BoleroAttr |> this.AddProp
                

type MudBooleanInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.Nullable<System.Boolean>>()
    static member create () = MudBooleanInputBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudCheckBoxBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    new (x: string) as this = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedIcon")>] member this.CheckedIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CheckedIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UncheckedIcon")>] member this.UncheckedIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "UncheckedIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IndeterminateIcon")>] member this.IndeterminateIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "IndeterminateIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriState")>] member this.TriState (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "TriState" => x |> BoleroAttr |> this.AddProp
                

type MudSwitchBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    new (x: string) as this = MudSwitchBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSwitchBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSwitchBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSwitchBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
                

type MudPickerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    static member create () = MudPickerBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("InputIcon")>] member this.InputIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "InputIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerOpened")>] member this.PickerOpened (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerOpened" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerClosed")>] member this.PickerClosed (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "PickerClosed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarClass")>] member this.ToolBarClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ToolBarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerVariant")>] member this.PickerVariant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputVariant")>] member this.InputVariant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "InputVariant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowKeyboardInput")>] member this.AllowKeyboardInput (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowKeyboardInput" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PickerActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PickerActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
                

type MudBaseDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    static member create () = MudBaseDatePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("MaxDate")>] member this.MaxDate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "MaxDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinDate")>] member this.MinDate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "MinDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenTo")>] member this.OpenTo (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateFormat")>] member this.DateFormat (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DateFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FirstDayOfWeek")>] member this.FirstDayOfWeek (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerMonth")>] member this.PickerMonth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "PickerMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerMonthChanged")>] member this.PickerMonthChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosingDelay")>] member this.ClosingDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ClosingDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisplayMonths")>] member this.DisplayMonths (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "DisplayMonths" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxMonthColumns")>] member this.MaxMonthColumns (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxMonthColumns" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StartMonth")>] member this.StartMonth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "StartMonth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowWeekNumbers")>] member this.ShowWeekNumbers (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowWeekNumbers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleDateFormat")>] member this.TitleDateFormat (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TitleDateFormat" => x |> BoleroAttr |> this.AddProp
                

type MudDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    static member create () = MudDatePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("DateChanged")>] member this.DateChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "DateChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Date")>] member this.Date (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "Date" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoClose")>] member this.AutoClose (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoClose" => x |> BoleroAttr |> this.AddProp
                

type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    static member create () = MudDateRangePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("DateRangeChanged")>] member this.DateRangeChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.DateRange> "DateRangeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRange")>] member this.DateRange (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.DateRange) = "DateRange" => x |> BoleroAttr |> this.AddProp
                

type MudTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.TimeSpan>>()
    static member create () = MudTimePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("OpenTo")>] member this.OpenTo (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.OpenTo) = "OpenTo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TimeEditMode")>] member this.TimeEditMode (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.TimeEditMode) = "TimeEditMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AmPm")>] member this.AmPm (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AmPm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TimeFormat")>] member this.TimeFormat (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TimeFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Time")>] member this.Time (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.TimeSpan>) = "Time" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TimeChanged")>] member this.TimeChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.TimeSpan>> "TimeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudRadioGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'T>()
    new (x: string) as this = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedOption")>] member this.SelectedOption (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "SelectedOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedOptionChanged")>] member this.SelectedOptionChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "SelectedOptionChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudAlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudAlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudAlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoIcon")>] member this.NoIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "NoIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Severity")>] member this.Severity (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Severity) = "Severity" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudAppBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAppBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudAppBarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudAppBarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
                

type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudAvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudAvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudAvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudAvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Image")>] member this.Image (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
                

type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudBadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudBadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bottom")>] member this.Bottom (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Left")>] member this.Left (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Left" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Start")>] member this.Start (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Start" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlap")>] member this.Overlap (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Overlap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Content" => x |> BoleroAttr |> this.AddProp
                

type MudBreadcrumbsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudBreadcrumbsBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.List<MudBlazor.BreadcrumbItem>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Separator")>] member this.Separator (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Separator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SeparatorTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: MudBlazor.BreadcrumbItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxItems")>] member this.MaxItems (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Byte>) = "MaxItems" => x |> BoleroAttr |> this.AddProp
                

type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("OverrideStyles")>] member this.OverrideStyles (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OverrideStyles" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("VerticalAlign")>] member this.VerticalAlign (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "VerticalAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableElevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
                

type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudToggleIconButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Toggled")>] member this.Toggled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Toggled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledChanged")>] member this.ToggledChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ToggledChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledIcon")>] member this.ToggledIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ToggledIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledTitle")>] member this.ToggledTitle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ToggledTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledColor")>] member this.ToggledColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "ToggledColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToggledSize")>] member this.ToggledSize (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "ToggledSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
                

type MudCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
                

type MudCardActionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCardActionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardActionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCardActionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCardActionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode

                

type MudCardContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCardContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCardContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCardContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode

                

type MudCardHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCardHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCardHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCardHeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCardHeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CardHeaderAvatar" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CardHeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CardHeaderActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudCardMediaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudCardMediaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Image")>] member this.Image (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Height" => x |> BoleroAttr |> this.AddProp
                

type MudCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCarouselItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCarouselItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCarouselItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCarouselItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Transition")>] member this.Transition (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Transition) = "Transition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomTransitionEnter")>] member this.CustomTransitionEnter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CustomTransitionEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomTransitionExit")>] member this.CustomTransitionExit (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CustomTransitionExit" => x |> BoleroAttr |> this.AddProp
                

type MudChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudChartBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double[]) = "InputData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "InputLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "XAxisLabels" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.ChartType) = "ChartType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Position) = "LegendPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "SelectedIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudChartBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                
            
namespace rec MudBlazor.DslInternals.Charts

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = BarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = DonutBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = LineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = PieBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = LegendBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = "Data" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type MudChipSetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudChipSetBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudChipSetBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudChipSetBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudChipSetBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mandatory")>] member this.Mandatory (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Mandatory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllClosable")>] member this.AllClosable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Filter")>] member this.Filter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Filter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChip")>] member this.SelectedChip (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.MudChip) = "SelectedChip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChipChanged")>] member this.SelectedChipChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "SelectedChipChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChips")>] member this.SelectedChips (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.MudChip[]) = "SelectedChips" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChipsChanged")>] member this.SelectedChipsChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip[]> "SelectedChipsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudChipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudChipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudChipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudChipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudChipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarClass")>] member this.AvatarClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "AvatarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ForceLoad")>] member this.ForceLoad (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Default")>] member this.Default (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Default" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudCollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudCollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudCollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAnimationEnd")>] member this.OnAnimationEnd (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAnimationEnd" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudDialogBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DialogContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DialogContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DialogContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DialogContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DialogActions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DialogActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DialogActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DialogActions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableSidePadding")>] member this.DisableSidePadding (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableSidePadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassContent")>] member this.ClassContent (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ClassContent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ClassActions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentStyle")>] member this.ContentStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ContentStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsVisible")>] member this.IsVisible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsVisibleChanged")>] member this.IsVisibleChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudDialogInstanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudDialogInstanceBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.DialogOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Content" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Guid) = "Id" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudDrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudDrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Anchor")>] member this.Anchor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Anchor) = "Anchor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.DrawerVariant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableOverlay")>] member this.DisableOverlay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableOverlay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreserveOpenState")>] member this.PreserveOpenState (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "PreserveOpenState" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenMiniOnHover")>] member this.OpenMiniOnHover (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OpenMiniOnHover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenChanged")>] member this.OpenChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OpenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MiniWidth")>] member this.MiniWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MiniWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClipMode")>] member this.ClipMode (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.DrawerClipMode) = "ClipMode" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudDrawerContainerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudDrawerContainerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode

                

type MudLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDrawerContainerBuilder<'FunBlazorGeneric>()
    static member create () = MudLayoutBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("RightToLeft")>] member this.RightToLeft (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "RightToLeft" => x |> BoleroAttr |> this.AddProp
                

type MudElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ref")>] member this.Ref (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "Ref" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefChanged")>] member this.RefChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudExpansionPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudExpansionPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudExpansionPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudExpansionPanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudExpansionPanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideIcon")>] member this.HideIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsExpandedChanged")>] member this.IsExpandedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsExpanded")>] member this.IsExpanded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsExpanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                

type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudExpansionPanelsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudExpansionPanelsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudExpansionPanelsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudExpansionPanelsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiExpansion")>] member this.MultiExpansion (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "MultiExpansion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableBorders")>] member this.DisableBorders (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableBorders" => x |> BoleroAttr |> this.AddProp
                

type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudFieldBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudFieldBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "AdornmentIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "AdornmentText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Adornment) = "Adornment" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InnerPadding")>] member this.InnerPadding (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "InnerPadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableUnderLine" => x |> BoleroAttr |> this.AddProp
                

type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudFocusTrapBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFocusTrapBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudFocusTrapBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudFocusTrapBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultFocus")>] member this.DefaultFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.DefaultFocus) = "DefaultFocus" => x |> BoleroAttr |> this.AddProp
                

type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudFormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudFormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("IsValid")>] member this.IsValid (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsValid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsTouched")>] member this.IsTouched (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsTouched" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValidationDelay")>] member this.ValidationDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ValidationDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuppressRenderingOnValidation")>] member this.SuppressRenderingOnValidation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "SuppressRenderingOnValidation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuppressImplicitSubmission")>] member this.SuppressImplicitSubmission (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "SuppressImplicitSubmission" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsValidChanged")>] member this.IsValidChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsValidChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsTouchedChanged")>] member this.IsTouchedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsTouchedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Errors")>] member this.Errors (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "Errors" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorsChanged")>] member this.ErrorsChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "ErrorsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudHiddenBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudHiddenBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudHiddenBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudHiddenBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Invert")>] member this.Invert (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Invert" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsHidden")>] member this.IsHidden (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsHidden" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsHiddenChanged")>] member this.IsHiddenChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsHiddenChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudIconBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudIconBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ViewBox")>] member this.ViewBox (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ViewBox" => x |> BoleroAttr |> this.AddProp
                

type MudInputControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudInputControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudInputControlBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudInputControlBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "InputContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "InputContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "InputContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "InputContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ErrorText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HelperText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                

type MudInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudInputLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudInputLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudInputLabelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudInputLabelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Error" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> BoleroAttr |> this.AddProp
                

type MudLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Typo")>] member this.Typo (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Typo) = "Typo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Underline) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                

type MudListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudListBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudListBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Clickable")>] member this.Clickable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Clickable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisablePadding")>] member this.DisablePadding (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisablePadding" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.MudListItem) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItemChanged")>] member this.SelectedItemChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudListItem> "SelectedItemChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarClass")>] member this.AvatarClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "AvatarClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Inset")>] member this.Inset (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Inset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("InitiallyExpanded")>] member this.InitiallyExpanded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "InitiallyExpanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NestedList" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NestedList" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NestedList" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NestedList" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudListSubheaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudListSubheaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudListSubheaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudListSubheaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Inset")>] member this.Inset (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Inset" => x |> BoleroAttr |> this.AddProp
                

type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudMenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudMenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Link" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ForceLoad")>] member this.ForceLoad (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ForceLoad" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudMessageBoxBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Message")>] member this.Message (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "MessageContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "MessageContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "MessageContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "MessageContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelText")>] member this.CancelText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CancelButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CancelButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CancelButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CancelButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoText")>] member this.NoText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "NoText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NoButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesText")>] member this.YesText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "YesText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "YesButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "YesButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "YesButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "YesButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnYes")>] member this.OnYes (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnYes" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnNo")>] member this.OnNo (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnNo" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancel")>] member this.OnCancel (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsVisible")>] member this.IsVisible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsVisibleChanged")>] member this.IsVisibleChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudNavGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudNavGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudNavGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudNavGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideExpandIcon")>] member this.HideExpandIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideExpandIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIcon")>] member this.ExpandIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ExpandIcon" => x |> BoleroAttr |> this.AddProp
                

type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudNavMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudNavMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudNavMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudNavMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode

                

type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudOverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudOverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudOverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudOverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("VisibleChanged")>] member this.VisibleChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "VisibleChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoClose")>] member this.AutoClose (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LockScroll")>] member this.LockScroll (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "LockScroll" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LockScrollClass")>] member this.LockScrollClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "LockScrollClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DarkBackground")>] member this.DarkBackground (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DarkBackground" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LightBackground")>] member this.LightBackground (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "LightBackground" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Absolute")>] member this.Absolute (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Absolute" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ZIndex")>] member this.ZIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudPopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudPopoverBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudPopoverBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Direction) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OffsetY" => x |> BoleroAttr |> this.AddProp
                

type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudProgressCircularBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Minimum")>] member this.Minimum (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Minimum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Maximum")>] member this.Maximum (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Maximum" => x |> BoleroAttr |> this.AddProp
                

type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudProgressLinearBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Buffer")>] member this.Buffer (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Buffer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Static")>] member this.Static (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Static" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BufferValue")>] member this.BufferValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "BufferValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Minimum")>] member this.Minimum (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Minimum" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Maximum")>] member this.Maximum (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Maximum" => x |> BoleroAttr |> this.AddProp
                

type MudRadioBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudRadioBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudRadioBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudRadioBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudRadioBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Placement) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Option")>] member this.Option (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Option" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                

type MudRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudRatingBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("RatingItemsClass")>] member this.RatingItemsClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RatingItemsClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RatingItemsStyle")>] member this.RatingItemsStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RatingItemsStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxValue")>] member this.MaxValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MaxValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullIcon")>] member this.FullIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "FullIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EmptyIcon")>] member this.EmptyIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "EmptyIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValueChanged")>] member this.SelectedValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValue")>] member this.SelectedValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "SelectedValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HoveredValueChanged")>] member this.HoveredValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "HoveredValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudRatingItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("ItemValue")>] member this.ItemValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ItemValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemClicked")>] member this.ItemClicked (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "ItemClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemHovered")>] member this.ItemHovered (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "ItemHovered" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudScrollToTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudScrollToTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudScrollToTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudScrollToTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Selector")>] member this.Selector (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Selector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("VisibleCssClass")>] member this.VisibleCssClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "VisibleCssClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenCssClass")>] member this.HiddenCssClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HiddenCssClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TopOffset")>] member this.TopOffset (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "TopOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollBehavior")>] member this.ScrollBehavior (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.ScrollBehavior) = "ScrollBehavior" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnScroll")>] member this.OnScroll (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.ScrollEventArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudSkeletonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SkeletonType")>] member this.SkeletonType (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.SkeletonType) = "SkeletonType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Animation")>] member this.Animation (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Animation) = "Animation" => x |> BoleroAttr |> this.AddProp
                

type MudSliderBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudSliderBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSliderBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSliderBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSliderBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Converter<'T>) = "Converter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Immediate" => x |> BoleroAttr |> this.AddProp
                

type MudSnackbarElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudSnackbarElementBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Snackbar")>] member this.Snackbar (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Snackbar) = "Snackbar" => x |> BoleroAttr |> this.AddProp
                

type MudSnackbarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudSnackbarProviderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudSwipeAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSwipeAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSwipeAreaBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSwipeAreaBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("OnSwipe")>] member this.OnSwipe (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "OnSwipe" => (System.Action<MudBlazor.SwipeDirection>fn) |> BoleroAttr |> this.AddProp
                

type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudSimpleTableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudSimpleTableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudSimpleTableBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudSimpleTableBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Hover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Striped" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> this.AddProp
                

type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudTableBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Hover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Striped" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FixedHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FixedFooter")>] member this.FixedFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FixedFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortLabel")>] member this.SortLabel (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "SortLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowUnsorted")>] member this.AllowUnsorted (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowUnsorted" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowsPerPage")>] member this.RowsPerPage (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "RowsPerPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CurrentPage")>] member this.CurrentPage (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "CurrentPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "MultiSelection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ToolBarContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadingProgressColor")>] member this.LoadingProgressColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "LoadingProgressColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "HeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "HeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomHeader")>] member this.CustomHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CustomHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderClass")>] member this.HeaderClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HeaderClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "FooterContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "FooterContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomFooter")>] member this.CustomFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CustomFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterClass")>] member this.FooterClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "FooterClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ColGroup" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ColGroup" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PagerContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PagerContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCommitEditClick")>] member this.OnCommitEditClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancelEditClick")>] member this.OnCancelEditClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditCommand")>] member this.CommitEditCommand (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "CommitEditCommand" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditCommandParameter")>] member this.CommitEditCommandParameter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "CommitEditCommandParameter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditTooltip")>] member this.CommitEditTooltip (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CommitEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelEditTooltip")>] member this.CancelEditTooltip (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CancelEditTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CommitEditIcon")>] member this.CommitEditIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CommitEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelEditIcon")>] member this.CancelEditIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CancelEditIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CanCancelEdit")>] member this.CanCancelEdit (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CanCancelEdit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditPreview")>] member this.RowEditPreview (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "RowEditPreview" => (System.Action<System.Object>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditCommit")>] member this.RowEditCommit (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "RowEditCommit" => (System.Action<System.Object>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditCancel")>] member this.RowEditCancel (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "RowEditCancel" => (System.Action<System.Object>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TotalItems")>] member this.TotalItems (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "TotalItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowClass")>] member this.RowClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RowClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowStyle")>] member this.RowStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RowStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightAlignSmall")>] member this.RightAlignSmall (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "RightAlignSmall" => x |> BoleroAttr |> this.AddProp
                

type MudTableBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTableBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudTableBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode
    [<CustomOperation("RowTemplate")>] member this.RowTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildRowContent")>] member this.ChildRowContent (_: FunBlazorContext<'FunBlazorGeneric>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildRowContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowEditingTemplate")>] member this.RowEditingTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowEditingTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HorizontalScrollbar")>] member this.HorizontalScrollbar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HorizontalScrollbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Filter")>] member this.Filter (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "Filter" => (System.Func<'T, System.Boolean>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.TableRowClickEventArgs<'T>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowClassFunc")>] member this.RowClassFunc (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowStyleFunc")>] member this.RowStyleFunc (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItemChanged")>] member this.SelectedItemChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "SelectedItemChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItems")>] member this.SelectedItems (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.HashSet<'T>) = "SelectedItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItemsChanged")>] member this.SelectedItemsChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedItemsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ServerData")>] member this.ServerData (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "ServerData" => (System.Func<MudBlazor.TableState, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>fn) |> BoleroAttr |> this.AddProp
                

type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudTablePagerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("DisableRowsPerPage")>] member this.DisableRowsPerPage (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRowsPerPage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSizeOptions")>] member this.PageSizeOptions (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InfoFormat")>] member this.InfoFormat (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "InfoFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowsPerPageString")>] member this.RowsPerPageString (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RowsPerPageString" => x |> BoleroAttr |> this.AddProp
                

type MudTableSortLabelBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("InitialDirection")>] member this.InitialDirection (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.SortDirection) = "InitialDirection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Enabled")>] member this.Enabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Enabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortIcon")>] member this.SortIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "SortIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AppendIcon")>] member this.AppendIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AppendIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortDirection")>] member this.SortDirection (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.SortDirection) = "SortDirection" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortDirectionChanged")>] member this.SortDirectionChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.SortDirection> "SortDirectionChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortBy")>] member this.SortBy (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "SortBy" => (System.Func<'T, System.Object>fn) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortLabel")>] member this.SortLabel (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "SortLabel" => x |> BoleroAttr |> this.AddProp
                

type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTdBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTdBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTdBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTdBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("DataLabel")>] member this.DataLabel (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DataLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSmall")>] member this.HideSmall (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideSmall" => x |> BoleroAttr |> this.AddProp
                

type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTFootRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTFootRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTFootRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTFootRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreCheckbox")>] member this.IgnoreCheckbox (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreEditable")>] member this.IgnoreEditable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudThBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudThBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudThBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudThBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode

                

type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTHeadRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTHeadRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTHeadRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTHeadRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreCheckbox")>] member this.IgnoreCheckbox (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreEditable")>] member this.IgnoreEditable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTrBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTrBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTrBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTrBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Item")>] member this.Item (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Item" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsCheckable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsEditable")>] member this.IsEditable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsEditable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsHeader")>] member this.IsHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsFooter")>] member this.IsFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCheckedChanged")>] member this.IsCheckedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsCheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsChecked")>] member this.IsChecked (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsChecked" => x |> BoleroAttr |> this.AddProp
                

type MudTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("KeepPanelsAlive")>] member this.KeepPanelsAlive (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "KeepPanelsAlive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Border")>] member this.Border (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Border" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Centered")>] member this.Centered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Centered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSlider")>] member this.HideSlider (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideSlider" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrevIcon")>] member this.PrevIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PrevIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "NextIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AlwaysShowScrollButtons")>] member this.AlwaysShowScrollButtons (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AlwaysShowScrollButtons" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Position")>] member this.Position (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Position) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SliderColor")>] member this.SliderColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "SliderColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollIconColor")>] member this.ScrollIconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "ScrollIconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ApplyEffectsToContainer")>] member this.ApplyEffectsToContainer (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ApplyEffectsToContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabPanelClass")>] member this.TabPanelClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TabPanelClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PanelClass")>] member this.PanelClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PanelClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivePanelIndex")>] member this.ActivePanelIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ActivePanelIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivePanelIndexChanged")>] member this.ActivePanelIndexChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "ActivePanelIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudTimeLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTimeLineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTimeLineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTimeLineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTimeLineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Border")>] member this.Border (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Border" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
                

type MudTimeLineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTimeLineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTimeLineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTimeLineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTimeLineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Align")>] member this.Align (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Align) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
                

type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTooltipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTooltipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delay'")>] member this.Delay' (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Delay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delayed")>] member this.Delayed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Delayed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Placement) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TooltipContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TooltipContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TooltipContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TooltipContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Inline")>] member this.Inline (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Inline" => x |> BoleroAttr |> this.AddProp
                

type MudTreeViewBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTreeViewBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTreeViewBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTreeViewBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTreeViewBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("CanSelect")>] member this.CanSelect (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CanSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CanActivate")>] member this.CanActivate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CanActivate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandOnClick")>] member this.ExpandOnClick (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ExpandOnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CanHover")>] member this.CanHover (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CanHover" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatedValueChanged")>] member this.ActivatedValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "ActivatedValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedValuesChanged")>] member this.SelectedValuesChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'T -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ServerData")>] member this.ServerData (_: FunBlazorContext<'FunBlazorGeneric>, fn) = "ServerData" => (System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.HashSet<'T>>>fn) |> BoleroAttr |> this.AddProp
                

type MudTreeViewItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Globalization.CultureInfo) = "Culture" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTypo")>] member this.TextTypo (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Typo) = "TextTypo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextClass")>] member this.TextClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TextClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndText")>] member this.EndText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "EndText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndTextTypo")>] member this.EndTextTypo (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Typo) = "EndTextTypo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndTextClass")>] member this.EndTextClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "EndTextClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Content" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Content" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Activated")>] member this.Activated (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Activated" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Selected")>] member this.Selected (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Selected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "EndIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EndIconColor")>] member this.EndIconColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "EndIconColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActivatedChanged")>] member this.ActivatedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ActivatedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedChanged")>] member this.SelectedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTextBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTextBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Typo")>] member this.Typo (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Typo) = "Typo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Align")>] member this.Align (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Align) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GutterBottom")>] member this.GutterBottom (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "GutterBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Inline")>] member this.Inline (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Inline" => x |> BoleroAttr |> this.AddProp
                

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudContainerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudContainerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.MaxWidth) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
                

type MudDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudDividerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Absolute")>] member this.Absolute (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Absolute" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FlexItem")>] member this.FlexItem (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FlexItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Light")>] member this.Light (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Light" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Vertical")>] member this.Vertical (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Vertical" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DividerType")>] member this.DividerType (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.DividerType) = "DividerType" => x |> BoleroAttr |> this.AddProp
                

type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudDrawerHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudDrawerHeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudDrawerHeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LinkToIndex")>] member this.LinkToIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "LinkToIndex" => x |> BoleroAttr |> this.AddProp
                

type MudGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Spacing")>] member this.Spacing (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Spacing" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Justify")>] member this.Justify (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Justify) = "Justify" => x |> BoleroAttr |> this.AddProp
                

type MudItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("xs")>] member this.xs (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "xs" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sm")>] member this.sm (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "sm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("md")>] member this.md (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "md" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lg")>] member this.lg (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "lg" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xl")>] member this.xl (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "xl" => x |> BoleroAttr |> this.AddProp
                

type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudHighlighterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HighlightedText")>] member this.HighlightedText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HighlightedText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CaseSensitive")>] member this.CaseSensitive (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CaseSensitive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UntilNextBoundary")>] member this.UntilNextBoundary (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "UntilNextBoundary" => x |> BoleroAttr |> this.AddProp
                

type MudMainContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudMainContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudMainContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudMainContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudMainContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode

                

type MudPaperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudPaperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPaperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudPaperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudPaperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinHeight")>] member this.MinHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MinHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinWidth")>] member this.MinWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MinWidth" => x |> BoleroAttr |> this.AddProp
                

type MudSparkLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudSparkLineBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
                

type MudTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudTabPanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudTabPanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BadgeData")>] member this.BadgeData (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "BadgeData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BadgeColor")>] member this.BadgeColor (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "BadgeColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ID")>] member this.ID (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "ID" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ToolTip")>] member this.ToolTip (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ToolTip" => x |> BoleroAttr |> this.AddProp
                

type MudToolBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudToolBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudToolBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudToolBarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudToolBarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> BoleroAttr |> this.AddProp
                

type MudDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudDialogProviderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("NoHeader")>] member this.NoHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "NoHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseButton")>] member this.CloseButton (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "CloseButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableBackdropClick")>] member this.DisableBackdropClick (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "DisableBackdropClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "FullWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Position")>] member this.Position (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<MudBlazor.DialogPosition>) = "Position" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<MudBlazor.MaxWidth>) = "MaxWidth" => x |> BoleroAttr |> this.AddProp
                

type BaseMudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BaseMudThemeProviderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.MudTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
                

type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit BaseMudThemeProviderBuilder<'FunBlazorGeneric>()
    static member create () = MudThemeProviderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MudAppBarSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudAppBarSpacerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type BreadcrumbLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BreadcrumbLinkBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Item")>] member this.Item (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.BreadcrumbItem) = "Item" => x |> BoleroAttr |> this.AddProp
                

type BreadcrumbSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = BreadcrumbSeparatorBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MudPickerContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudPickerContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPickerContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudPickerContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudPickerContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudPickerToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MudPickerToolbarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MudPickerToolbarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MudPickerToolbarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MudPickerToolbarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<'FunBlazorGeneric>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableToolbar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Orientation) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudSpacerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MudToolBarSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudToolBarSpacerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedIcon")>] member this.ExpandedIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ExpandedIcon" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type MudInputAdornmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MudInputAdornmentBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Edge) = "Edge" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AdornmentClick")>] member this.AdornmentClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AdornmentClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                
            
namespace rec MudBlazor.DslInternals.Charts

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type FiltersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = FiltersBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                
            

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
    type MudBaseItemsControl'<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseItemsControlBuilder<MudBlazor.MudBaseItemsControl<'TChildComponent>, 'TChildComponent>
    type MudBaseBindableItemsControl'<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase> = MudBaseBindableItemsControlBuilder<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>, 'TChildComponent, 'TData>
    type MudCarousel'<'TData> = MudCarouselBuilder<MudBlazor.MudCarousel<'TData>, 'TData>
    type MudBaseSelectItem' = MudBaseSelectItemBuilder<MudBlazor.MudBaseSelectItem>
    type MudNavLink' = MudNavLinkBuilder<MudBlazor.MudNavLink>
    type MudSelectItem'<'T> = MudSelectItemBuilder<MudBlazor.MudSelectItem<'T>, 'T>
    type MudFormComponent'<'T, 'U> = MudFormComponentBuilder<MudBlazor.MudFormComponent<'T, 'U>, 'T, 'U>
    type MudBaseInput'<'T> = MudBaseInputBuilder<MudBlazor.MudBaseInput<'T>, 'T>
    type MudAutocomplete'<'T> = MudAutocompleteBuilder<MudBlazor.MudAutocomplete<'T>, 'T>
    type MudDebouncedInput'<'T> = MudDebouncedInputBuilder<MudBlazor.MudDebouncedInput<'T>, 'T>
    type MudNumericField'<'T> = MudNumericFieldBuilder<MudBlazor.MudNumericField<'T>, 'T>
    type MudTextField'<'T> = MudTextFieldBuilder<MudBlazor.MudTextField<'T>, 'T>
    type MudTextFieldString' = MudTextFieldStringBuilder<MudBlazor.MudTextFieldString>
    type MudInput'<'T> = MudInputBuilder<MudBlazor.MudInput<'T>, 'T>
    type MudInputString' = MudInputStringBuilder<MudBlazor.MudInputString>
    type MudRangeInput'<'T> = MudRangeInputBuilder<MudBlazor.MudRangeInput<'T>, 'T>
    type MudSelect'<'T> = MudSelectBuilder<MudBlazor.MudSelect<'T>, 'T>
    type MudBooleanInput'<'T> = MudBooleanInputBuilder<MudBlazor.MudBooleanInput<'T>, 'T>
    type MudCheckBox'<'T> = MudCheckBoxBuilder<MudBlazor.MudCheckBox<'T>, 'T>
    type MudSwitch'<'T> = MudSwitchBuilder<MudBlazor.MudSwitch<'T>, 'T>
    type MudPicker'<'T> = MudPickerBuilder<MudBlazor.MudPicker<'T>, 'T>
    type MudBaseDatePicker' = MudBaseDatePickerBuilder<MudBlazor.MudBaseDatePicker>
    type MudDatePicker' = MudDatePickerBuilder<MudBlazor.MudDatePicker>
    type MudDateRangePicker' = MudDateRangePickerBuilder<MudBlazor.MudDateRangePicker>
    type MudTimePicker' = MudTimePickerBuilder<MudBlazor.MudTimePicker>
    type MudRadioGroup'<'T> = MudRadioGroupBuilder<MudBlazor.MudRadioGroup<'T>, 'T>
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
    type MudRadio'<'T> = MudRadioBuilder<MudBlazor.MudRadio<'T>, 'T>
    type MudRating' = MudRatingBuilder<MudBlazor.MudRating>
    type MudRatingItem' = MudRatingItemBuilder<MudBlazor.MudRatingItem>
    type MudScrollToTop' = MudScrollToTopBuilder<MudBlazor.MudScrollToTop>
    type MudSkeleton' = MudSkeletonBuilder<MudBlazor.MudSkeleton>
    type MudSlider'<'T> = MudSliderBuilder<MudBlazor.MudSlider<'T>, 'T>
    type MudSnackbarElement' = MudSnackbarElementBuilder<MudBlazor.MudSnackbarElement>
    type MudSnackbarProvider' = MudSnackbarProviderBuilder<MudBlazor.MudSnackbarProvider>
    type MudSwipeArea' = MudSwipeAreaBuilder<MudBlazor.MudSwipeArea>
    type MudSimpleTable' = MudSimpleTableBuilder<MudBlazor.MudSimpleTable>
    type MudTableBase' = MudTableBaseBuilder<MudBlazor.MudTableBase>
    type MudTable'<'T> = MudTableBuilder<MudBlazor.MudTable<'T>, 'T>
    type MudTablePager' = MudTablePagerBuilder<MudBlazor.MudTablePager>
    type MudTableSortLabel'<'T> = MudTableSortLabelBuilder<MudBlazor.MudTableSortLabel<'T>, 'T>
    type MudTd' = MudTdBuilder<MudBlazor.MudTd>
    type MudTFootRow' = MudTFootRowBuilder<MudBlazor.MudTFootRow>
    type MudTh' = MudThBuilder<MudBlazor.MudTh>
    type MudTHeadRow' = MudTHeadRowBuilder<MudBlazor.MudTHeadRow>
    type MudTr' = MudTrBuilder<MudBlazor.MudTr>
    type MudTabs' = MudTabsBuilder<MudBlazor.MudTabs>
    type MudTimeLine' = MudTimeLineBuilder<MudBlazor.MudTimeLine>
    type MudTimeLineItem' = MudTimeLineItemBuilder<MudBlazor.MudTimeLineItem>
    type MudTooltip' = MudTooltipBuilder<MudBlazor.MudTooltip>
    type MudTreeView'<'T> = MudTreeViewBuilder<MudBlazor.MudTreeView<'T>, 'T>
    type MudTreeViewItem'<'T> = MudTreeViewItemBuilder<MudBlazor.MudTreeViewItem<'T>, 'T>
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
            