namespace rec MudBlazor.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type MudBaseColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = MudBaseColumnBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> this.AddAttr
    [<CustomOperation("HeaderText")>] member this.HeaderText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderText" => x |> this.AddAttr
                

type MudColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    static member create () = MudColumnBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("FooterValue")>] member this.FooterValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "FooterValue" => x |> this.AddAttr
    [<CustomOperation("FooterText")>] member this.FooterText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterText" => x |> this.AddAttr
    [<CustomOperation("DataFormatString")>] member this.DataFormatString (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "DataFormatString" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
                

type MudSortableColumnBuilder<'FunBlazorGeneric, 'T, 'ModelType when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    static member create () = MudSortableColumnBuilder<'FunBlazorGeneric, 'T, 'ModelType>().CreateNode()
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("FooterValue")>] member this.FooterValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "FooterValue" => x |> this.AddAttr
    [<CustomOperation("FooterText")>] member this.FooterText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterText" => x |> this.AddAttr
    [<CustomOperation("DataFormatString")>] member this.DataFormatString (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "DataFormatString" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("SortLabel")>] member this.SortLabel (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SortLabel" => x |> this.AddAttr
    [<CustomOperation("SortBy")>] member this.SortBy (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "SortBy" => (System.Func<'ModelType, System.Object>fn) |> this.AddAttr
                

type MudAvatarColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    static member create () = MudAvatarColumnBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Value" => x |> this.AddAttr
                

type MudTemplateColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseColumnBuilder<'FunBlazorGeneric>()
    static member create () = MudTemplateColumnBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("DataContext")>] member this.DataContext (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "DataContext" => x |> this.AddAttr
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Header" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Row")>] member this.Row (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Row" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Edit")>] member this.Edit (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Edit" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Footer" (fun x -> render x) |> this.AddAttr
                

type MudComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilderWithDomAttrs<'FunBlazorGeneric>()
    static member create () = MudComponentBaseBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddAttr
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorBuilder<'FunBlazorGeneric>, x: (string * string) list) = attr.styles x |> this.AddAttr
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Tag" => x |> this.AddAttr
    [<CustomOperation("UserAttributes")>] member this.UserAttributes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UserAttributes" => x |> this.AddAttr
                

type MudBaseButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudBaseButtonBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HtmlTag" => x |> this.AddAttr
    [<CustomOperation("ButtonType")>] member this.ButtonType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ButtonType) = "ButtonType" => x |> this.AddAttr
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Link" => x |> this.AddAttr
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Target" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableElevation" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> this.AddAttr
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
                

type MudButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudButtonBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudButtonBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("StartIcon")>] member this.StartIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "StartIcon" => x |> this.AddAttr
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "EndIcon" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("IconClass")>] member this.IconClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "IconClass" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> this.AddAttr
                

type MudFabBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    static member create () = MudFabBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("StartIcon")>] member this.StartIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "StartIcon" => x |> this.AddAttr
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "EndIcon" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> this.AddAttr
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Label" => x |> this.AddAttr
                

type MudIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudIconButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudIconButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudIconButtonBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudIconButtonBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Edge) = "Edge" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
                

type MudFileUploaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseButtonBuilder<'FunBlazorGeneric>()
    static member create () = MudFileUploaderBuilder<'FunBlazorGeneric>().CreateNode()

                

type MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>(x).CreateNode()
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "SelectedIndex" => x |> this.AddAttr
    [<CustomOperation("SelectedIndex'")>] member this.SelectedIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Int32>) = this.AddBinding("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member this.SelectedIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Int32>) = this.AddBinding("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member this.SelectedIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Int32 * (System.Int32 -> unit)) = this.AddBinding("SelectedIndex", valueFn)
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase and 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent>()
    static member create () = MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, 'TChildComponent, 'TData>().CreateNode()
    [<CustomOperation("ItemsSource")>] member this.ItemsSource (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TData>) = "ItemsSource" => x |> this.AddAttr
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'TData -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x) |> this.AddAttr
                

type MudCarouselBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseBindableItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudCarouselItem, 'TData>()
    static member create () = MudCarouselBuilder<'FunBlazorGeneric, 'TData>().CreateNode()
    [<CustomOperation("ShowArrows")>] member this.ShowArrows (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowArrows" => x |> this.AddAttr
    [<CustomOperation("ArrowsPosition")>] member this.ArrowsPosition (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Position) = "ArrowsPosition" => x |> this.AddAttr
    [<CustomOperation("ShowBullets")>] member this.ShowBullets (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowBullets" => x |> this.AddAttr
    [<CustomOperation("BulletsPosition")>] member this.BulletsPosition (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Position) = "BulletsPosition" => x |> this.AddAttr
    [<CustomOperation("BulletsColor")>] member this.BulletsColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<MudBlazor.Color>) = "BulletsColor" => x |> this.AddAttr
    [<CustomOperation("ShowDelimiters")>] member this.ShowDelimiters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowDelimiters" => x |> this.AddAttr
    [<CustomOperation("DelimitersColor")>] member this.DelimitersColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<MudBlazor.Color>) = "DelimitersColor" => x |> this.AddAttr
    [<CustomOperation("AutoCycle")>] member this.AutoCycle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AutoCycle" => x |> this.AddAttr
    [<CustomOperation("AutoCycleTime")>] member this.AutoCycleTime (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.TimeSpan) = "AutoCycleTime" => x |> this.AddAttr
    [<CustomOperation("NavigationButtonsClass")>] member this.NavigationButtonsClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NavigationButtonsClass" => x |> this.AddAttr
    [<CustomOperation("BulletsClass")>] member this.BulletsClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "BulletsClass" => x |> this.AddAttr
    [<CustomOperation("DelimitersClass")>] member this.DelimitersClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "DelimitersClass" => x |> this.AddAttr
    [<CustomOperation("PreviousIcon")>] member this.PreviousIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PreviousIcon" => x |> this.AddAttr
    [<CustomOperation("CheckedIcon")>] member this.CheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CheckedIcon" => x |> this.AddAttr
    [<CustomOperation("UncheckedIcon")>] member this.UncheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "UncheckedIcon" => x |> this.AddAttr
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NextIcon" => x |> this.AddAttr
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("NextButtonTemplate")>] member this.NextButtonTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NextButtonTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("PreviousButtonTemplate")>] member this.PreviousButtonTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PreviousButtonTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("BulletTemplate")>] member this.BulletTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: System.Boolean -> Bolero.Node) = Bolero.Html.attr.fragmentWith "BulletTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("DelimiterTemplate")>] member this.DelimiterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: System.Boolean -> Bolero.Node) = Bolero.Html.attr.fragmentWith "DelimiterTemplate" (fun x -> render x) |> this.AddAttr
                

type MudTimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseItemsControlBuilder<'FunBlazorGeneric, MudBlazor.MudTimelineItem>()
    static member create () = MudTimelineBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("TimelineOrientation")>] member this.TimelineOrientation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TimelineOrientation) = "TimelineOrientation" => x |> this.AddAttr
    [<CustomOperation("TimelinePosition")>] member this.TimelinePosition (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TimelinePosition) = "TimelinePosition" => x |> this.AddAttr
    [<CustomOperation("TimelineAlign")>] member this.TimelineAlign (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TimelineAlign) = "TimelineAlign" => x |> this.AddAttr
    [<CustomOperation("Reverse")>] member this.Reverse (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Reverse" => x |> this.AddAttr
    [<CustomOperation("DisableModifiers")>] member this.DisableModifiers (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableModifiers" => x |> this.AddAttr
                

type MudBaseSelectItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudBaseSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudBaseSelectItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudBaseSelectItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudBaseSelectItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Href" => x |> this.AddAttr
    [<CustomOperation("ForceLoad")>] member this.ForceLoad (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ForceLoad" => x |> this.AddAttr
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> this.AddAttr
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
                

type MudNavLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    static member create () = MudNavLinkBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("Match")>] member this.Match (_: FunBlazorBuilder<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> this.AddAttr
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Target" => x |> this.AddAttr
                

type MudSelectItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseSelectItemBuilder<'FunBlazorGeneric>()
    static member create () = MudSelectItemBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Value" => x |> this.AddAttr
                

type MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'U>().CreateNode()
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Required" => x |> this.AddAttr
    [<CustomOperation("RequiredError")>] member this.RequiredError (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RequiredError" => x |> this.AddAttr
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ErrorText" => x |> this.AddAttr
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Error" => x |> this.AddAttr
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Converter<'T, 'U>) = "Converter" => x |> this.AddAttr
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Globalization.CultureInfo) = "Culture" => x |> this.AddAttr
    [<CustomOperation("Validation")>] member this.Validation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Validation" => x |> this.AddAttr
    [<CustomOperation("For'")>] member this.For' (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'T>>) = "For" => x |> this.AddAttr
                

type MudBaseInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    static member create () = MudBaseInputBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> this.AddAttr
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Immediate" => x |> this.AddAttr
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableUnderLine" => x |> this.AddAttr
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HelperText" => x |> this.AddAttr
    [<CustomOperation("HelperTextOnFocus")>] member this.HelperTextOnFocus (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HelperTextOnFocus" => x |> this.AddAttr
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AdornmentIcon" => x |> this.AddAttr
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AdornmentText" => x |> this.AddAttr
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Adornment) = "Adornment" => x |> this.AddAttr
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "AdornmentColor" => x |> this.AddAttr
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> this.AddAttr
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> this.AddAttr
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> this.AddAttr
    [<CustomOperation("Counter")>] member this.Counter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "Counter" => x |> this.AddAttr
    [<CustomOperation("MaxLength")>] member this.MaxLength (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "MaxLength" => x |> this.AddAttr
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Label" => x |> this.AddAttr
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> this.AddAttr
    [<CustomOperation("Lines")>] member this.Lines (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Lines" => x |> this.AddAttr
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("Text'")>] member this.Text' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.String>) = this.AddBinding("Text", value)
    [<CustomOperation("Text'")>] member this.Text' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.String>) = this.AddBinding("Text", value)
    [<CustomOperation("Text'")>] member this.Text' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.String * (System.String -> unit)) = this.AddBinding("Text", valueFn)
    [<CustomOperation("TextUpdateSuppression")>] member this.TextUpdateSuppression (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "TextUpdateSuppression" => x |> this.AddAttr
    [<CustomOperation("InputMode")>] member this.InputMode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.InputMode) = "InputMode" => x |> this.AddAttr
    [<CustomOperation("Pattern")>] member this.Pattern (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Pattern" => x |> this.AddAttr
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnInternalInputChanged")>] member this.OnInternalInputChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInternalInputChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("KeyDownPreventDefault")>] member this.KeyDownPreventDefault (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "KeyDownPreventDefault" => x |> this.AddAttr
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyPress" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("KeyPressPreventDefault")>] member this.KeyPressPreventDefault (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "KeyPressPreventDefault" => x |> this.AddAttr
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("KeyUpPreventDefault")>] member this.KeyUpPreventDefault (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "KeyUpPreventDefault" => x |> this.AddAttr
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("Value", valueFn)
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Format" => x |> this.AddAttr
                

type MudAutocompleteBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    static member create () = MudAutocompleteBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("PopoverClass")>] member this.PopoverClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PopoverClass" => x |> this.AddAttr
    [<CustomOperation("AnchorOrigin")>] member this.AnchorOrigin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "AnchorOrigin" => x |> this.AddAttr
    [<CustomOperation("TransformOrigin")>] member this.TransformOrigin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "TransformOrigin" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("OpenIcon")>] member this.OpenIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "OpenIcon" => x |> this.AddAttr
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> this.AddAttr
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("ToStringFunc")>] member this.ToStringFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "ToStringFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("SearchFunc")>] member this.SearchFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "SearchFunc" => (System.Func<System.String, System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<'T>>>fn) |> this.AddAttr
    [<CustomOperation("MaxItems")>] member this.MaxItems (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxItems" => x |> this.AddAttr
    [<CustomOperation("MinCharacters")>] member this.MinCharacters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "MinCharacters" => x |> this.AddAttr
    [<CustomOperation("ResetValueOnEmptyText")>] member this.ResetValueOnEmptyText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ResetValueOnEmptyText" => x |> this.AddAttr
    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "DebounceInterval" => x |> this.AddAttr
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("ItemSelectedTemplate")>] member this.ItemSelectedTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemSelectedTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("ItemDisabledTemplate")>] member this.ItemDisabledTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemDisabledTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("CoerceText")>] member this.CoerceText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "CoerceText" => x |> this.AddAttr
    [<CustomOperation("CoerceValue")>] member this.CoerceValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "CoerceValue" => x |> this.AddAttr
    [<CustomOperation("ItemDisabledFunc")>] member this.ItemDisabledFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "ItemDisabledFunc" => (System.Func<'T, System.Boolean>fn) |> this.AddAttr
    [<CustomOperation("IsOpenChanged")>] member this.IsOpenChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsOpenChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectValueOnTab")>] member this.SelectValueOnTab (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "SelectValueOnTab" => x |> this.AddAttr
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Clearable" => x |> this.AddAttr
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> this.AddAttr
                

type MudDebouncedInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    static member create () = MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("DebounceInterval")>] member this.DebounceInterval (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "DebounceInterval" => x |> this.AddAttr
    [<CustomOperation("OnDebounceIntervalElapsed")>] member this.OnDebounceIntervalElapsed (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnDebounceIntervalElapsed" (fun e -> fn e)) |> this.AddAttr
                

type MudNumericFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    static member create () = MudNumericFieldBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Clearable" => x |> this.AddAttr
    [<CustomOperation("InvertMouseWheel")>] member this.InvertMouseWheel (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "InvertMouseWheel" => x |> this.AddAttr
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Min" => x |> this.AddAttr
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Max" => x |> this.AddAttr
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Step" => x |> this.AddAttr
    [<CustomOperation("HideSpinButtons")>] member this.HideSpinButtons (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideSpinButtons" => x |> this.AddAttr
    [<CustomOperation("InputMode")>] member this.InputMode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.InputMode) = "InputMode" => x |> this.AddAttr
    [<CustomOperation("Pattern")>] member this.Pattern (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Pattern" => x |> this.AddAttr
                

type MudTextFieldBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDebouncedInputBuilder<'FunBlazorGeneric, 'T>()
    static member create () = MudTextFieldBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.InputType) = "InputType" => x |> this.AddAttr
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Clearable" => x |> this.AddAttr
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> this.AddAttr
                

type MudInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    new (x: string) as this = MudInputBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudInputBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudInputBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudInputBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.InputType) = "InputType" => x |> this.AddAttr
    [<CustomOperation("OnIncrement")>] member this.OnIncrement (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = attr.callbackOfUnit("OnIncrement", fn) |> this.AddAttr
    [<CustomOperation("OnDecrement")>] member this.OnDecrement (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = attr.callbackOfUnit("OnDecrement", fn) |> this.AddAttr
    [<CustomOperation("HideSpinButtons")>] member this.HideSpinButtons (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideSpinButtons" => x |> this.AddAttr
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Clearable" => x |> this.AddAttr
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnMouseWheel")>] member this.OnMouseWheel (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.WheelEventArgs> "OnMouseWheel" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("ClearIcon")>] member this.ClearIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ClearIcon" => x |> this.AddAttr
    [<CustomOperation("NumericUpIcon")>] member this.NumericUpIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NumericUpIcon" => x |> this.AddAttr
    [<CustomOperation("NumericDownIcon")>] member this.NumericDownIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NumericDownIcon" => x |> this.AddAttr
                

type MudInputStringBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudInputBuilder<'FunBlazorGeneric, System.String>()
    static member create () = MudInputStringBuilder<'FunBlazorGeneric>().CreateNode()

                

type MudRangeInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, MudBlazor.Range<'T>>()
    new (x: string) as this = MudRangeInputBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudRangeInputBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudRangeInputBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudRangeInputBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("InputType")>] member this.InputType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.InputType) = "InputType" => x |> this.AddAttr
    [<CustomOperation("PlaceholderStart")>] member this.PlaceholderStart (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PlaceholderStart" => x |> this.AddAttr
    [<CustomOperation("PlaceholderEnd")>] member this.PlaceholderEnd (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PlaceholderEnd" => x |> this.AddAttr
    [<CustomOperation("SeparatorIcon")>] member this.SeparatorIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SeparatorIcon" => x |> this.AddAttr
                

type MudSelectBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseInputBuilder<'FunBlazorGeneric, 'T>()
    new (x: string) as this = MudSelectBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudSelectBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudSelectBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudSelectBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("PopoverClass")>] member this.PopoverClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PopoverClass" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("OpenIcon")>] member this.OpenIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "OpenIcon" => x |> this.AddAttr
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> this.AddAttr
    [<CustomOperation("SelectAll")>] member this.SelectAll (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "SelectAll" => x |> this.AddAttr
    [<CustomOperation("SelectAllText")>] member this.SelectAllText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SelectAllText" => x |> this.AddAttr
    [<CustomOperation("SelectedValuesChanged")>] member this.SelectedValuesChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("MultiSelectionTextFunc")>] member this.MultiSelectionTextFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "MultiSelectionTextFunc" => (System.Func<System.Collections.Generic.List<System.String>, System.String>fn) |> this.AddAttr
    [<CustomOperation("Delimiter")>] member this.Delimiter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Delimiter" => x |> this.AddAttr
    [<CustomOperation("SelectedValues")>] member this.SelectedValues (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'T>) = "SelectedValues" => x |> this.AddAttr
    [<CustomOperation("SelectedValues'")>] member this.SelectedValues' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Collections.Generic.IEnumerable<'T>>) = this.AddBinding("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member this.SelectedValues' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Collections.Generic.IEnumerable<'T>>) = this.AddBinding("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member this.SelectedValues' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Collections.Generic.IEnumerable<'T> * (System.Collections.Generic.IEnumerable<'T> -> unit)) = this.AddBinding("SelectedValues", valueFn)
    [<CustomOperation("Comparer")>] member this.Comparer (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IEqualityComparer<'T>) = "Comparer" => x |> this.AddAttr
    [<CustomOperation("ToStringFunc")>] member this.ToStringFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "ToStringFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MultiSelection" => x |> this.AddAttr
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("AnchorOrigin")>] member this.AnchorOrigin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "AnchorOrigin" => x |> this.AddAttr
    [<CustomOperation("TransformOrigin")>] member this.TransformOrigin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "TransformOrigin" => x |> this.AddAttr
    [<CustomOperation("Strict")>] member this.Strict (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Strict" => x |> this.AddAttr
    [<CustomOperation("Clearable")>] member this.Clearable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Clearable" => x |> this.AddAttr
    [<CustomOperation("LockScroll")>] member this.LockScroll (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "LockScroll" => x |> this.AddAttr
    [<CustomOperation("OnClearButtonClick")>] member this.OnClearButtonClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearButtonClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("CheckedIcon")>] member this.CheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CheckedIcon" => x |> this.AddAttr
    [<CustomOperation("UncheckedIcon")>] member this.UncheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "UncheckedIcon" => x |> this.AddAttr
    [<CustomOperation("IndeterminateIcon")>] member this.IndeterminateIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "IndeterminateIcon" => x |> this.AddAttr
                

type MudBooleanInputBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.Nullable<System.Boolean>>()
    static member create () = MudBooleanInputBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Checked" => x |> this.AddAttr
    [<CustomOperation("Checked'")>] member this.Checked' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("Checked", value)
    [<CustomOperation("Checked'")>] member this.Checked' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("Checked", value)
    [<CustomOperation("Checked'")>] member this.Checked' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("Checked", valueFn)
    [<CustomOperation("StopClickPropagation")>] member this.StopClickPropagation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "StopClickPropagation" => x |> this.AddAttr
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "CheckedChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudCheckBoxBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    new (x: string) as this = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudCheckBoxBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Label" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("CheckedIcon")>] member this.CheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CheckedIcon" => x |> this.AddAttr
    [<CustomOperation("UncheckedIcon")>] member this.UncheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "UncheckedIcon" => x |> this.AddAttr
    [<CustomOperation("IndeterminateIcon")>] member this.IndeterminateIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "IndeterminateIcon" => x |> this.AddAttr
    [<CustomOperation("TriState")>] member this.TriState (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "TriState" => x |> this.AddAttr
                

type MudSwitchBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBooleanInputBuilder<'FunBlazorGeneric, 'T>()
    new (x: string) as this = MudSwitchBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudSwitchBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudSwitchBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudSwitchBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Label" => x |> this.AddAttr
    [<CustomOperation("ThumbIcon")>] member this.ThumbIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ThumbIcon" => x |> this.AddAttr
    [<CustomOperation("ThumbIconColor")>] member this.ThumbIconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "ThumbIconColor" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
                

type MudPickerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, System.String>()
    static member create () = MudPickerBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "AdornmentColor" => x |> this.AddAttr
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AdornmentIcon" => x |> this.AddAttr
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> this.AddAttr
    [<CustomOperation("PickerOpened")>] member this.PickerOpened (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = attr.callbackOfUnit("PickerOpened", fn) |> this.AddAttr
    [<CustomOperation("PickerClosed")>] member this.PickerClosed (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = attr.callbackOfUnit("PickerClosed", fn) |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> this.AddAttr
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HelperText" => x |> this.AddAttr
    [<CustomOperation("HelperTextOnFocus")>] member this.HelperTextOnFocus (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HelperTextOnFocus" => x |> this.AddAttr
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Label" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Editable" => x |> this.AddAttr
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableToolbar" => x |> this.AddAttr
    [<CustomOperation("ToolBarClass")>] member this.ToolBarClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ToolBarClass" => x |> this.AddAttr
    [<CustomOperation("PickerVariant")>] member this.PickerVariant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.PickerVariant) = "PickerVariant" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Adornment) = "Adornment" => x |> this.AddAttr
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Orientation) = "Orientation" => x |> this.AddAttr
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("AllowKeyboardInput")>] member this.AllowKeyboardInput (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AllowKeyboardInput" => x |> this.AddAttr
    [<CustomOperation("TextChanged")>] member this.TextChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "TextChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("Text'")>] member this.Text' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.String>) = this.AddBinding("Text", value)
    [<CustomOperation("Text'")>] member this.Text' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.String>) = this.AddBinding("Text", value)
    [<CustomOperation("Text'")>] member this.Text' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.String * (System.String -> unit)) = this.AddBinding("Text", valueFn)
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ClassActions" => x |> this.AddAttr
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PickerActions" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PickerActions" (html.text x) |> this.AddAttr
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PickerActions" (html.text x) |> this.AddAttr
    [<CustomOperation("PickerActions")>] member this.PickerActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PickerActions" (html.text x) |> this.AddAttr
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> this.AddAttr
                

type MudColorPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, MudBlazor.Utilities.MudColor>()
    static member create () = MudColorPickerBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("DisableAlpha")>] member this.DisableAlpha (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableAlpha" => x |> this.AddAttr
    [<CustomOperation("DisableColorField")>] member this.DisableColorField (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableColorField" => x |> this.AddAttr
    [<CustomOperation("DisableModeSwitch")>] member this.DisableModeSwitch (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableModeSwitch" => x |> this.AddAttr
    [<CustomOperation("DisableInputs")>] member this.DisableInputs (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableInputs" => x |> this.AddAttr
    [<CustomOperation("DisableSliders")>] member this.DisableSliders (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableSliders" => x |> this.AddAttr
    [<CustomOperation("DisablePreview")>] member this.DisablePreview (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisablePreview" => x |> this.AddAttr
    [<CustomOperation("ColorPickerMode")>] member this.ColorPickerMode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ColorPickerMode) = "ColorPickerMode" => x |> this.AddAttr
    [<CustomOperation("ColorPickerView")>] member this.ColorPickerView (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ColorPickerView) = "ColorPickerView" => x |> this.AddAttr
    [<CustomOperation("UpdateBindingIfOnlyHSLChanged")>] member this.UpdateBindingIfOnlyHSLChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "UpdateBindingIfOnlyHSLChanged" => x |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Utilities.MudColor) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<MudBlazor.Utilities.MudColor>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<MudBlazor.Utilities.MudColor>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: MudBlazor.Utilities.MudColor * (MudBlazor.Utilities.MudColor -> unit)) = this.AddBinding("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.Utilities.MudColor> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Palette")>] member this.Palette (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<MudBlazor.Utilities.MudColor>) = "Palette" => x |> this.AddAttr
    [<CustomOperation("DisableDragEffect")>] member this.DisableDragEffect (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableDragEffect" => x |> this.AddAttr
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> this.AddAttr
    [<CustomOperation("SpectrumIcon")>] member this.SpectrumIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SpectrumIcon" => x |> this.AddAttr
    [<CustomOperation("GridIcon")>] member this.GridIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "GridIcon" => x |> this.AddAttr
    [<CustomOperation("PaletteIcon")>] member this.PaletteIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PaletteIcon" => x |> this.AddAttr
    [<CustomOperation("ImportExportIcon")>] member this.ImportExportIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ImportExportIcon" => x |> this.AddAttr
                

type MudBaseDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.DateTime>>()
    static member create () = MudBaseDatePickerBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("MaxDate")>] member this.MaxDate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "MaxDate" => x |> this.AddAttr
    [<CustomOperation("MinDate")>] member this.MinDate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "MinDate" => x |> this.AddAttr
    [<CustomOperation("OpenTo")>] member this.OpenTo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.OpenTo) = "OpenTo" => x |> this.AddAttr
    [<CustomOperation("DateFormat")>] member this.DateFormat (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "DateFormat" => x |> this.AddAttr
    [<CustomOperation("FirstDayOfWeek")>] member this.FirstDayOfWeek (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.DayOfWeek>) = "FirstDayOfWeek" => x |> this.AddAttr
    [<CustomOperation("PickerMonth")>] member this.PickerMonth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "PickerMonth" => x |> this.AddAttr
    [<CustomOperation("PickerMonth'")>] member this.PickerMonth' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Nullable<System.DateTime>>) = this.AddBinding("PickerMonth", value)
    [<CustomOperation("PickerMonth'")>] member this.PickerMonth' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Nullable<System.DateTime>>) = this.AddBinding("PickerMonth", value)
    [<CustomOperation("PickerMonth'")>] member this.PickerMonth' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = this.AddBinding("PickerMonth", valueFn)
    [<CustomOperation("PickerMonthChanged")>] member this.PickerMonthChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "PickerMonthChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("ClosingDelay")>] member this.ClosingDelay (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ClosingDelay" => x |> this.AddAttr
    [<CustomOperation("DisplayMonths")>] member this.DisplayMonths (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "DisplayMonths" => x |> this.AddAttr
    [<CustomOperation("MaxMonthColumns")>] member this.MaxMonthColumns (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxMonthColumns" => x |> this.AddAttr
    [<CustomOperation("StartMonth")>] member this.StartMonth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "StartMonth" => x |> this.AddAttr
    [<CustomOperation("ShowWeekNumbers")>] member this.ShowWeekNumbers (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowWeekNumbers" => x |> this.AddAttr
    [<CustomOperation("TitleDateFormat")>] member this.TitleDateFormat (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "TitleDateFormat" => x |> this.AddAttr
    [<CustomOperation("IsDateDisabledFunc")>] member this.IsDateDisabledFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "IsDateDisabledFunc" => (System.Func<System.DateTime, System.Boolean>fn) |> this.AddAttr
    [<CustomOperation("PreviousIcon")>] member this.PreviousIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PreviousIcon" => x |> this.AddAttr
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NextIcon" => x |> this.AddAttr
    [<CustomOperation("FixYear")>] member this.FixYear (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "FixYear" => x |> this.AddAttr
    [<CustomOperation("FixMonth")>] member this.FixMonth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "FixMonth" => x |> this.AddAttr
    [<CustomOperation("FixDay")>] member this.FixDay (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "FixDay" => x |> this.AddAttr
                

type MudDatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    static member create () = MudDatePickerBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("DateChanged")>] member this.DateChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.DateTime>> "DateChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Date")>] member this.Date (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.DateTime>) = "Date" => x |> this.AddAttr
    [<CustomOperation("Date'")>] member this.Date' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Nullable<System.DateTime>>) = this.AddBinding("Date", value)
    [<CustomOperation("Date'")>] member this.Date' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Nullable<System.DateTime>>) = this.AddBinding("Date", value)
    [<CustomOperation("Date'")>] member this.Date' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Nullable<System.DateTime> * (System.Nullable<System.DateTime> -> unit)) = this.AddBinding("Date", valueFn)
    [<CustomOperation("AutoClose")>] member this.AutoClose (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AutoClose" => x |> this.AddAttr
                

type MudDateRangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudBaseDatePickerBuilder<'FunBlazorGeneric>()
    static member create () = MudDateRangePickerBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("DateRangeChanged")>] member this.DateRangeChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.DateRange> "DateRangeChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("DateRange")>] member this.DateRange (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.DateRange) = "DateRange" => x |> this.AddAttr
    [<CustomOperation("DateRange'")>] member this.DateRange' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<MudBlazor.DateRange>) = this.AddBinding("DateRange", value)
    [<CustomOperation("DateRange'")>] member this.DateRange' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<MudBlazor.DateRange>) = this.AddBinding("DateRange", value)
    [<CustomOperation("DateRange'")>] member this.DateRange' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: MudBlazor.DateRange * (MudBlazor.DateRange -> unit)) = this.AddBinding("DateRange", valueFn)
                

type MudTimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudPickerBuilder<'FunBlazorGeneric, System.Nullable<System.TimeSpan>>()
    static member create () = MudTimePickerBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("OpenTo")>] member this.OpenTo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.OpenTo) = "OpenTo" => x |> this.AddAttr
    [<CustomOperation("TimeEditMode")>] member this.TimeEditMode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TimeEditMode) = "TimeEditMode" => x |> this.AddAttr
    [<CustomOperation("ClosingDelay")>] member this.ClosingDelay (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ClosingDelay" => x |> this.AddAttr
    [<CustomOperation("AutoClose")>] member this.AutoClose (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AutoClose" => x |> this.AddAttr
    [<CustomOperation("AmPm")>] member this.AmPm (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AmPm" => x |> this.AddAttr
    [<CustomOperation("TimeFormat")>] member this.TimeFormat (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "TimeFormat" => x |> this.AddAttr
    [<CustomOperation("Time")>] member this.Time (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.TimeSpan>) = "Time" => x |> this.AddAttr
    [<CustomOperation("Time'")>] member this.Time' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Nullable<System.TimeSpan>>) = this.AddBinding("Time", value)
    [<CustomOperation("Time'")>] member this.Time' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Nullable<System.TimeSpan>>) = this.AddBinding("Time", value)
    [<CustomOperation("Time'")>] member this.Time' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Nullable<System.TimeSpan> * (System.Nullable<System.TimeSpan> -> unit)) = this.AddBinding("Time", valueFn)
    [<CustomOperation("TimeChanged")>] member this.TimeChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.TimeSpan>> "TimeChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudRadioGroupBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudFormComponentBuilder<'FunBlazorGeneric, 'T, 'T>()
    new (x: string) as this = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudRadioGroupBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Name" => x |> this.AddAttr
    [<CustomOperation("SelectedOption")>] member this.SelectedOption (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "SelectedOption" => x |> this.AddAttr
    [<CustomOperation("SelectedOption'")>] member this.SelectedOption' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("SelectedOption", value)
    [<CustomOperation("SelectedOption'")>] member this.SelectedOption' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("SelectedOption", value)
    [<CustomOperation("SelectedOption'")>] member this.SelectedOption' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("SelectedOption", valueFn)
    [<CustomOperation("SelectedOptionChanged")>] member this.SelectedOptionChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "SelectedOptionChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudAlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudAlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudAlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudAlertBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudAlertBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("ContentAlignment")>] member this.ContentAlignment (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.HorizontalAlignment) = "ContentAlignment" => x |> this.AddAttr
    [<CustomOperation("CloseIconClicked")>] member this.CloseIconClicked (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudAlert> "CloseIconClicked" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> this.AddAttr
    [<CustomOperation("ShowCloseIcon")>] member this.ShowCloseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowCloseIcon" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("NoIcon")>] member this.NoIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "NoIcon" => x |> this.AddAttr
    [<CustomOperation("Severity")>] member this.Severity (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Severity) = "Severity" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
                

type MudAppBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudAppBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudAppBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudAppBarBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudAppBarBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Bottom")>] member this.Bottom (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Bottom" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Fixed" => x |> this.AddAttr
    [<CustomOperation("ToolBarClass")>] member this.ToolBarClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ToolBarClass" => x |> this.AddAttr
                

type MudAvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudAvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudAvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudAvatarBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudAvatarBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> this.AddAttr
    [<CustomOperation("Image")>] member this.Image (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Image" => x |> this.AddAttr
    [<CustomOperation("Alt")>] member this.Alt (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Alt" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
                

type MudAvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudAvatarGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudAvatarGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudAvatarGroupBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudAvatarGroupBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Spacing")>] member this.Spacing (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Spacing" => x |> this.AddAttr
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> this.AddAttr
    [<CustomOperation("OutlineColor")>] member this.OutlineColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "OutlineColor" => x |> this.AddAttr
    [<CustomOperation("MaxElevation")>] member this.MaxElevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "MaxElevation" => x |> this.AddAttr
    [<CustomOperation("MaxSquare")>] member this.MaxSquare (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MaxSquare" => x |> this.AddAttr
    [<CustomOperation("MaxRounded")>] member this.MaxRounded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MaxRounded" => x |> this.AddAttr
    [<CustomOperation("MaxColor")>] member this.MaxColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "MaxColor" => x |> this.AddAttr
    [<CustomOperation("MaxSize")>] member this.MaxSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "MaxSize" => x |> this.AddAttr
    [<CustomOperation("MaxVariant")>] member this.MaxVariant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "MaxVariant" => x |> this.AddAttr
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Max" => x |> this.AddAttr
    [<CustomOperation("MaxAvatarClass")>] member this.MaxAvatarClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "MaxAvatarClass" => x |> this.AddAttr
                

type MudBadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudBadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudBadgeBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudBadgeBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Origin")>] member this.Origin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "Origin" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dot" => x |> this.AddAttr
    [<CustomOperation("Overlap")>] member this.Overlap (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Overlap" => x |> this.AddAttr
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Max" => x |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Content" => x |> this.AddAttr
    [<CustomOperation("BadgeClass")>] member this.BadgeClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "BadgeClass" => x |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
                

type MudBreadcrumbsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudBreadcrumbsBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.List<MudBlazor.BreadcrumbItem>) = "Items" => x |> this.AddAttr
    [<CustomOperation("Separator")>] member this.Separator (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Separator" => x |> this.AddAttr
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("SeparatorTemplate")>] member this.SeparatorTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SeparatorTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: MudBlazor.BreadcrumbItem -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("MaxItems")>] member this.MaxItems (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Byte>) = "MaxItems" => x |> this.AddAttr
    [<CustomOperation("ExpanderIcon")>] member this.ExpanderIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ExpanderIcon" => x |> this.AddAttr
                

type MudBreakpointProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudBreakpointProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudBreakpointProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudBreakpointProviderBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudBreakpointProviderBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("OnBreakpointChanged")>] member this.OnBreakpointChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.Breakpoint> "OnBreakpointChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudButtonGroupBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudButtonGroupBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("OverrideStyles")>] member this.OverrideStyles (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "OverrideStyles" => x |> this.AddAttr
    [<CustomOperation("VerticalAlign")>] member this.VerticalAlign (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "VerticalAlign" => x |> this.AddAttr
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableElevation" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
                

type MudToggleIconButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudToggleIconButtonBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Toggled")>] member this.Toggled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Toggled" => x |> this.AddAttr
    [<CustomOperation("Toggled'")>] member this.Toggled' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Toggled", value)
    [<CustomOperation("Toggled'")>] member this.Toggled' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Toggled", value)
    [<CustomOperation("Toggled'")>] member this.Toggled' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Toggled", valueFn)
    [<CustomOperation("ToggledChanged")>] member this.ToggledChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ToggledChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("ToggledIcon")>] member this.ToggledIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ToggledIcon" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("ToggledTitle")>] member this.ToggledTitle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ToggledTitle" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("ToggledColor")>] member this.ToggledColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "ToggledColor" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("ToggledSize")>] member this.ToggledSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "ToggledSize" => x |> this.AddAttr
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Edge) = "Edge" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
                

type MudCardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudCardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudCardBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudCardBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> this.AddAttr
                

type MudCardActionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCardActionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudCardActionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudCardActionsBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudCardActionsBuilder<'FunBlazorGeneric>(x).CreateNode()

                

type MudCardContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCardContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudCardContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudCardContentBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudCardContentBuilder<'FunBlazorGeneric>(x).CreateNode()

                

type MudCardHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCardHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudCardHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudCardHeaderBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudCardHeaderBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x) |> this.AddAttr
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x) |> this.AddAttr
    [<CustomOperation("CardHeaderAvatar")>] member this.CardHeaderAvatar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CardHeaderAvatar" (html.text x) |> this.AddAttr
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CardHeaderContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x) |> this.AddAttr
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x) |> this.AddAttr
    [<CustomOperation("CardHeaderContent")>] member this.CardHeaderContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CardHeaderContent" (html.text x) |> this.AddAttr
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CardHeaderActions" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x) |> this.AddAttr
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x) |> this.AddAttr
    [<CustomOperation("CardHeaderActions")>] member this.CardHeaderActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CardHeaderActions" (html.text x) |> this.AddAttr
                

type MudCardMediaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudCardMediaBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("Image")>] member this.Image (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Image" => x |> this.AddAttr
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Height" => x |> this.AddAttr
                

type MudCarouselItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCarouselItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudCarouselItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudCarouselItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudCarouselItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Transition")>] member this.Transition (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Transition) = "Transition" => x |> this.AddAttr
    [<CustomOperation("CustomTransitionEnter")>] member this.CustomTransitionEnter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CustomTransitionEnter" => x |> this.AddAttr
    [<CustomOperation("CustomTransitionExit")>] member this.CustomTransitionExit (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CustomTransitionExit" => x |> this.AddAttr
                

type MudChartBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudChartBaseBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("InputData")>] member this.InputData (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double[]) = "InputData" => x |> this.AddAttr
    [<CustomOperation("InputLabels")>] member this.InputLabels (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String[]) = "InputLabels" => x |> this.AddAttr
    [<CustomOperation("XAxisLabels")>] member this.XAxisLabels (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String[]) = "XAxisLabels" => x |> this.AddAttr
    [<CustomOperation("ChartSeries")>] member this.ChartSeries (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.List<MudBlazor.ChartSeries>) = "ChartSeries" => x |> this.AddAttr
    [<CustomOperation("ChartOptions")>] member this.ChartOptions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ChartOptions) = "ChartOptions" => x |> this.AddAttr
    [<CustomOperation("CustomGraphics")>] member this.CustomGraphics (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CustomGraphics" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("CustomGraphics")>] member this.CustomGraphics (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CustomGraphics" (html.text x) |> this.AddAttr
    [<CustomOperation("CustomGraphics")>] member this.CustomGraphics (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CustomGraphics" (html.text x) |> this.AddAttr
    [<CustomOperation("CustomGraphics")>] member this.CustomGraphics (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CustomGraphics" (html.text x) |> this.AddAttr
    [<CustomOperation("ChartType")>] member this.ChartType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ChartType) = "ChartType" => x |> this.AddAttr
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Width" => x |> this.AddAttr
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Height" => x |> this.AddAttr
    [<CustomOperation("LegendPosition")>] member this.LegendPosition (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Position) = "LegendPosition" => x |> this.AddAttr
    [<CustomOperation("SelectedIndex")>] member this.SelectedIndex (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "SelectedIndex" => x |> this.AddAttr
    [<CustomOperation("SelectedIndex'")>] member this.SelectedIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Int32>) = this.AddBinding("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member this.SelectedIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Int32>) = this.AddBinding("SelectedIndex", value)
    [<CustomOperation("SelectedIndex'")>] member this.SelectedIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Int32 * (System.Int32 -> unit)) = this.AddBinding("SelectedIndex", valueFn)
    [<CustomOperation("SelectedIndexChanged")>] member this.SelectedIndexChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedIndexChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudChartBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudChartBuilder<'FunBlazorGeneric>().CreateNode()

                
            
namespace rec MudBlazor.DslInternals.Charts

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type BarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = BarBuilder<'FunBlazorGeneric>().CreateNode()

                

type DonutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = DonutBuilder<'FunBlazorGeneric>().CreateNode()

                

type LineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = LineBuilder<'FunBlazorGeneric>().CreateNode()

                

type PieBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = PieBuilder<'FunBlazorGeneric>().CreateNode()

                

type LegendBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudChartBaseBuilder<'FunBlazorGeneric>()
    static member create () = LegendBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.List<MudBlazor.Charts.SVG.Models.SvgLegend>) = "Data" => x |> this.AddAttr
                
            
namespace rec MudBlazor.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type MudChipSetBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudChipSetBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudChipSetBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudChipSetBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudChipSetBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MultiSelection" => x |> this.AddAttr
    [<CustomOperation("Mandatory")>] member this.Mandatory (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Mandatory" => x |> this.AddAttr
    [<CustomOperation("AllClosable")>] member this.AllClosable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AllClosable" => x |> this.AddAttr
    [<CustomOperation("Filter")>] member this.Filter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Filter" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("SelectedChip")>] member this.SelectedChip (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.MudChip) = "SelectedChip" => x |> this.AddAttr
    [<CustomOperation("SelectedChip'")>] member this.SelectedChip' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<MudBlazor.MudChip>) = this.AddBinding("SelectedChip", value)
    [<CustomOperation("SelectedChip'")>] member this.SelectedChip' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<MudBlazor.MudChip>) = this.AddBinding("SelectedChip", value)
    [<CustomOperation("SelectedChip'")>] member this.SelectedChip' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: MudBlazor.MudChip * (MudBlazor.MudChip -> unit)) = this.AddBinding("SelectedChip", valueFn)
    [<CustomOperation("SelectedChipChanged")>] member this.SelectedChipChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "SelectedChipChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedChips")>] member this.SelectedChips (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.MudChip[]) = "SelectedChips" => x |> this.AddAttr
    [<CustomOperation("SelectedChips'")>] member this.SelectedChips' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<MudBlazor.MudChip[]>) = this.AddBinding("SelectedChips", value)
    [<CustomOperation("SelectedChips'")>] member this.SelectedChips' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<MudBlazor.MudChip[]>) = this.AddBinding("SelectedChips", value)
    [<CustomOperation("SelectedChips'")>] member this.SelectedChips' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: MudBlazor.MudChip[] * (MudBlazor.MudChip[] -> unit)) = this.AddBinding("SelectedChips", valueFn)
    [<CustomOperation("Comparer")>] member this.Comparer (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IEqualityComparer<System.Object>) = "Comparer" => x |> this.AddAttr
    [<CustomOperation("SelectedChipsChanged")>] member this.SelectedChipsChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip[]> "SelectedChipsChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedValues")>] member this.SelectedValues (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.ICollection<System.Object>) = "SelectedValues" => x |> this.AddAttr
    [<CustomOperation("SelectedValues'")>] member this.SelectedValues' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Collections.Generic.ICollection<System.Object>>) = this.AddBinding("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member this.SelectedValues' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Collections.Generic.ICollection<System.Object>>) = this.AddBinding("SelectedValues", value)
    [<CustomOperation("SelectedValues'")>] member this.SelectedValues' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Collections.Generic.ICollection<System.Object> * (System.Collections.Generic.ICollection<System.Object> -> unit)) = this.AddBinding("SelectedValues", valueFn)
    [<CustomOperation("SelectedValuesChanged")>] member this.SelectedValuesChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.ICollection<System.Object>> "SelectedValuesChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> this.AddAttr
                

type MudChipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudChipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudChipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudChipBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudChipBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("SelectedColor")>] member this.SelectedColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "SelectedColor" => x |> this.AddAttr
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Avatar" => x |> this.AddAttr
    [<CustomOperation("AvatarClass")>] member this.AvatarClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AvatarClass" => x |> this.AddAttr
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Label" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("CheckedIcon")>] member this.CheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CheckedIcon" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Link" => x |> this.AddAttr
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Target" => x |> this.AddAttr
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Value" => x |> this.AddAttr
    [<CustomOperation("ForceLoad")>] member this.ForceLoad (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ForceLoad" => x |> this.AddAttr
    [<CustomOperation("Default")>] member this.Default (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "Default" => x |> this.AddAttr
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> this.AddAttr
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudChip> "OnClose" (fun e -> fn e)) |> this.AddAttr
                

type MudCollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudCollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudCollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudCollapseBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudCollapseBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> this.AddAttr
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Expanded", valueFn)
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("OnAnimationEnd")>] member this.OnAnimationEnd (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = attr.callbackOfUnit("OnAnimationEnd", fn) |> this.AddAttr
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> this.AddAttr
                

type CellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CellBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("Item")>] member this.Item (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Item" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("Field")>] member this.Field (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Field" => x |> this.AddAttr
    [<CustomOperation("CellTemplate")>] member this.CellTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "CellTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("EditTemplate")>] member this.EditTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "EditTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("ColumnType")>] member this.ColumnType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ColumnType) = "ColumnType" => x |> this.AddAttr
    [<CustomOperation("IsEditable")>] member this.IsEditable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsEditable" => x |> this.AddAttr
    [<CustomOperation("CellClass")>] member this.CellClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CellClass" => x |> this.AddAttr
    [<CustomOperation("CellStyle")>] member this.CellStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CellStyle" => x |> this.AddAttr
    [<CustomOperation("CellClassFunc")>] member this.CellClassFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "CellClassFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("CellStyleFunc")>] member this.CellStyleFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "CellStyleFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
                

type ColumnBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ColumnBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = ColumnBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = ColumnBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = ColumnBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("Value", valueFn)
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> this.AddAttr
    [<CustomOperation("Field")>] member this.Field (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Field" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("HideSmall")>] member this.HideSmall (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideSmall" => x |> this.AddAttr
    [<CustomOperation("FooterColSpan")>] member this.FooterColSpan (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "FooterColSpan" => x |> this.AddAttr
    [<CustomOperation("HeaderColSpan")>] member this.HeaderColSpan (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "HeaderColSpan" => x |> this.AddAttr
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ColumnType) = "Type" => x |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "HeaderTemplate" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("CellTemplate")>] member this.CellTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "CellTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "FooterTemplate" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderClass")>] member this.HeaderClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderClass" => x |> this.AddAttr
    [<CustomOperation("HeaderClassFunc")>] member this.HeaderClassFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "HeaderClassFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderStyle" => x |> this.AddAttr
    [<CustomOperation("HeaderStyleFunc")>] member this.HeaderStyleFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "HeaderStyleFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("Sortable")>] member this.Sortable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "Sortable" => x |> this.AddAttr
    [<CustomOperation("Filterable")>] member this.Filterable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "Filterable" => x |> this.AddAttr
    [<CustomOperation("ShowColumnOptions")>] member this.ShowColumnOptions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "ShowColumnOptions" => x |> this.AddAttr
    [<CustomOperation("SortBy")>] member this.SortBy (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "SortBy" => (System.Func<'T, System.Object>fn) |> this.AddAttr
    [<CustomOperation("InitialDirection")>] member this.InitialDirection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.SortDirection) = "InitialDirection" => x |> this.AddAttr
    [<CustomOperation("SortIcon")>] member this.SortIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SortIcon" => x |> this.AddAttr
    [<CustomOperation("CellClass")>] member this.CellClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CellClass" => x |> this.AddAttr
    [<CustomOperation("CellClassFunc")>] member this.CellClassFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "CellClassFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("CellStyle")>] member this.CellStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CellStyle" => x |> this.AddAttr
    [<CustomOperation("CellStyleFunc")>] member this.CellStyleFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "CellStyleFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("IsEditable")>] member this.IsEditable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "IsEditable" => x |> this.AddAttr
    [<CustomOperation("EditTemplate")>] member this.EditTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "EditTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("FooterClass")>] member this.FooterClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterClass" => x |> this.AddAttr
    [<CustomOperation("FooterClassFunc")>] member this.FooterClassFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "FooterClassFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("FooterStyle")>] member this.FooterStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterStyle" => x |> this.AddAttr
    [<CustomOperation("FooterStyleFunc")>] member this.FooterStyleFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "FooterStyleFunc" => (System.Func<'T, System.String>fn) |> this.AddAttr
    [<CustomOperation("EnableFooterSelection")>] member this.EnableFooterSelection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "EnableFooterSelection" => x |> this.AddAttr
                

type FooterCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = FooterCellBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = FooterCellBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = FooterCellBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = FooterCellBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("ColSpan")>] member this.ColSpan (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ColSpan" => x |> this.AddAttr
    [<CustomOperation("ColumnType")>] member this.ColumnType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ColumnType) = "ColumnType" => x |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "FooterTemplate" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterClass")>] member this.FooterClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterClass" => x |> this.AddAttr
    [<CustomOperation("FooterStyle")>] member this.FooterStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterStyle" => x |> this.AddAttr
                

type HeaderCellBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = HeaderCellBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = HeaderCellBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = HeaderCellBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = HeaderCellBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("Field")>] member this.Field (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Field" => x |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "HeaderTemplate" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x) |> this.AddAttr
    [<CustomOperation("ColSpan")>] member this.ColSpan (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ColSpan" => x |> this.AddAttr
    [<CustomOperation("ColumnType")>] member this.ColumnType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ColumnType) = "ColumnType" => x |> this.AddAttr
    [<CustomOperation("SortBy")>] member this.SortBy (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "SortBy" => (System.Func<'T, System.Object>fn) |> this.AddAttr
    [<CustomOperation("SortIcon")>] member this.SortIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SortIcon" => x |> this.AddAttr
    [<CustomOperation("InitialDirection")>] member this.InitialDirection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.SortDirection) = "InitialDirection" => x |> this.AddAttr
    [<CustomOperation("Sortable")>] member this.Sortable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "Sortable" => x |> this.AddAttr
    [<CustomOperation("Filterable")>] member this.Filterable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "Filterable" => x |> this.AddAttr
    [<CustomOperation("ShowColumnOptions")>] member this.ShowColumnOptions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "ShowColumnOptions" => x |> this.AddAttr
    [<CustomOperation("HeaderClass")>] member this.HeaderClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderClass" => x |> this.AddAttr
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderStyle" => x |> this.AddAttr
                

type MudDataGridBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudDataGridBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("SelectedItemChanged")>] member this.SelectedItemChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "SelectedItemChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedItemsChanged")>] member this.SelectedItemsChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedItemsChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("RowClick")>] member this.RowClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.DataGridRowClickEventArgs<'T>> "RowClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("StartedEditingItem")>] member this.StartedEditingItem (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "StartedEditingItem" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("EditingItemCancelled")>] member this.EditingItemCancelled (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "EditingItemCancelled" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("StartedCommittingItemChanges")>] member this.StartedCommittingItemChanges (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "StartedCommittingItemChanges" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Sortable")>] member this.Sortable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Sortable" => x |> this.AddAttr
    [<CustomOperation("Filterable")>] member this.Filterable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Filterable" => x |> this.AddAttr
    [<CustomOperation("ShowColumnOptions")>] member this.ShowColumnOptions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowColumnOptions" => x |> this.AddAttr
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> this.AddAttr
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> this.AddAttr
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ColGroup" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x) |> this.AddAttr
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ColGroup" (html.text x) |> this.AddAttr
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ColGroup" (html.text x) |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Hover" => x |> this.AddAttr
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Striped" => x |> this.AddAttr
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FixedHeader" => x |> this.AddAttr
    [<CustomOperation("FixedFooter")>] member this.FixedFooter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FixedFooter" => x |> this.AddAttr
    [<CustomOperation("FilterDefinitions")>] member this.FilterDefinitions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.List<MudBlazor.FilterDefinition<'T>>) = "FilterDefinitions" => x |> this.AddAttr
    [<CustomOperation("Virtualize")>] member this.Virtualize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Virtualize" => x |> this.AddAttr
    [<CustomOperation("RowClass")>] member this.RowClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RowClass" => x |> this.AddAttr
    [<CustomOperation("RowStyle")>] member this.RowStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RowStyle" => x |> this.AddAttr
    [<CustomOperation("RowClassFunc")>] member this.RowClassFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn) |> this.AddAttr
    [<CustomOperation("RowStyleFunc")>] member this.RowStyleFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn) |> this.AddAttr
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MultiSelection" => x |> this.AddAttr
    [<CustomOperation("EditMode")>] member this.EditMode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<MudBlazor.DataGridEditMode>) = "EditMode" => x |> this.AddAttr
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'T>) = "Items" => x |> this.AddAttr
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> this.AddAttr
    [<CustomOperation("CanCancelEdit")>] member this.CanCancelEdit (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "CanCancelEdit" => x |> this.AddAttr
    [<CustomOperation("LoadingProgressColor")>] member this.LoadingProgressColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "LoadingProgressColor" => x |> this.AddAttr
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ToolBarContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x) |> this.AddAttr
    [<CustomOperation("HorizontalScrollbar")>] member this.HorizontalScrollbar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HorizontalScrollbar" => x |> this.AddAttr
    [<CustomOperation("HeaderClass")>] member this.HeaderClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderClass" => x |> this.AddAttr
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Height" => x |> this.AddAttr
    [<CustomOperation("FooterClass")>] member this.FooterClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterClass" => x |> this.AddAttr
    [<CustomOperation("QuickFilter")>] member this.QuickFilter (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "QuickFilter" => (System.Func<'T, System.Boolean>fn) |> this.AddAttr
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Header" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Header" (html.text x) |> this.AddAttr
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Header" (html.text x) |> this.AddAttr
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Header" (html.text x) |> this.AddAttr
    [<CustomOperation("Columns")>] member this.Columns (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Columns" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Columns")>] member this.Columns (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Columns" (html.text x) |> this.AddAttr
    [<CustomOperation("Columns")>] member this.Columns (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Columns" (html.text x) |> this.AddAttr
    [<CustomOperation("Columns")>] member this.Columns (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Columns" (html.text x) |> this.AddAttr
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Footer" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Footer" (html.text x) |> this.AddAttr
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Footer" (html.text x) |> this.AddAttr
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Footer" (html.text x) |> this.AddAttr
    [<CustomOperation("ChildRowContent")>] member this.ChildRowContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildRowContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("NoRecordsContent")>] member this.NoRecordsContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NoRecordsContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("NoRecordsContent")>] member this.NoRecordsContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NoRecordsContent" (html.text x) |> this.AddAttr
    [<CustomOperation("NoRecordsContent")>] member this.NoRecordsContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NoRecordsContent" (html.text x) |> this.AddAttr
    [<CustomOperation("NoRecordsContent")>] member this.NoRecordsContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NoRecordsContent" (html.text x) |> this.AddAttr
    [<CustomOperation("LoadingContent")>] member this.LoadingContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "LoadingContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("LoadingContent")>] member this.LoadingContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "LoadingContent" (html.text x) |> this.AddAttr
    [<CustomOperation("LoadingContent")>] member this.LoadingContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "LoadingContent" (html.text x) |> this.AddAttr
    [<CustomOperation("LoadingContent")>] member this.LoadingContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "LoadingContent" (html.text x) |> this.AddAttr
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PagerContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x) |> this.AddAttr
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PagerContent" (html.text x) |> this.AddAttr
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PagerContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ServerData")>] member this.ServerData (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "ServerData" => (System.Func<MudBlazor.GridState<'T>, System.Threading.Tasks.Task<MudBlazor.GridData<'T>>>fn) |> this.AddAttr
    [<CustomOperation("RowsPerPage")>] member this.RowsPerPage (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "RowsPerPage" => x |> this.AddAttr
    [<CustomOperation("CurrentPage")>] member this.CurrentPage (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "CurrentPage" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("SelectedItems")>] member this.SelectedItems (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.HashSet<'T>) = "SelectedItems" => x |> this.AddAttr
    [<CustomOperation("SelectedItems'")>] member this.SelectedItems' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Collections.Generic.HashSet<'T>>) = this.AddBinding("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member this.SelectedItems' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Collections.Generic.HashSet<'T>>) = this.AddBinding("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member this.SelectedItems' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = this.AddBinding("SelectedItems", valueFn)
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "SelectedItem" => x |> this.AddAttr
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("SelectedItem", valueFn)
                

type MudDataGridPagerBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudDataGridPagerBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("DisableRowsPerPage")>] member this.DisableRowsPerPage (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRowsPerPage" => x |> this.AddAttr
    [<CustomOperation("PageSizeOptions")>] member this.PageSizeOptions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32[]) = "PageSizeOptions" => x |> this.AddAttr
    [<CustomOperation("InfoFormat")>] member this.InfoFormat (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "InfoFormat" => x |> this.AddAttr
    [<CustomOperation("RowsPerPageString")>] member this.RowsPerPageString (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RowsPerPageString" => x |> this.AddAttr
                

type RowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = RowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = RowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = RowBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = RowBuilder<'FunBlazorGeneric>(x).CreateNode()

                

type MudDialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudDialogBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DialogContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DialogContent" (html.text x) |> this.AddAttr
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DialogContent" (html.text x) |> this.AddAttr
    [<CustomOperation("DialogContent")>] member this.DialogContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DialogContent" (html.text x) |> this.AddAttr
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DialogActions" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DialogActions" (html.text x) |> this.AddAttr
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DialogActions" (html.text x) |> this.AddAttr
    [<CustomOperation("DialogActions")>] member this.DialogActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DialogActions" (html.text x) |> this.AddAttr
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.DialogOptions) = "Options" => x |> this.AddAttr
    [<CustomOperation("DisableSidePadding")>] member this.DisableSidePadding (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableSidePadding" => x |> this.AddAttr
    [<CustomOperation("ClassContent")>] member this.ClassContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ClassContent" => x |> this.AddAttr
    [<CustomOperation("ClassActions")>] member this.ClassActions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ClassActions" => x |> this.AddAttr
    [<CustomOperation("ContentStyle")>] member this.ContentStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ContentStyle" => x |> this.AddAttr
    [<CustomOperation("IsVisible")>] member this.IsVisible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsVisible" => x |> this.AddAttr
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member this.IsVisibleChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudDialogInstanceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudDialogInstanceBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.DialogOptions) = "Options" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Content" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Guid) = "Id" => x |> this.AddAttr
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> this.AddAttr
                

type MudDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudDrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudDrawerBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudDrawerBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Fixed" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Anchor")>] member this.Anchor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Anchor) = "Anchor" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.DrawerVariant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("DisableOverlay")>] member this.DisableOverlay (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableOverlay" => x |> this.AddAttr
    [<CustomOperation("PreserveOpenState")>] member this.PreserveOpenState (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "PreserveOpenState" => x |> this.AddAttr
    [<CustomOperation("OpenMiniOnHover")>] member this.OpenMiniOnHover (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "OpenMiniOnHover" => x |> this.AddAttr
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> this.AddAttr
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Open" => x |> this.AddAttr
    [<CustomOperation("Open'")>] member this.Open' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Open", value)
    [<CustomOperation("Open'")>] member this.Open' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Open", value)
    [<CustomOperation("Open'")>] member this.Open' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Open", valueFn)
    [<CustomOperation("OpenChanged")>] member this.OpenChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OpenChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Width" => x |> this.AddAttr
    [<CustomOperation("MiniWidth")>] member this.MiniWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "MiniWidth" => x |> this.AddAttr
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Height" => x |> this.AddAttr
    [<CustomOperation("ClipMode")>] member this.ClipMode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.DrawerClipMode) = "ClipMode" => x |> this.AddAttr
                

type MudDrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudDrawerContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudDrawerContainerBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudDrawerContainerBuilder<'FunBlazorGeneric>(x).CreateNode()

                

type MudLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudDrawerContainerBuilder<'FunBlazorGeneric>()
    static member create () = MudLayoutBuilder<'FunBlazorGeneric>().CreateNode()

                

type MudElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudElementBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudElementBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HtmlTag" => x |> this.AddAttr
    [<CustomOperation("Ref")>] member this.Ref (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "Ref" => x |> this.AddAttr
    [<CustomOperation("Ref'")>] member this.Ref' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Nullable<Microsoft.AspNetCore.Components.ElementReference>>) = this.AddBinding("Ref", value)
    [<CustomOperation("Ref'")>] member this.Ref' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Nullable<Microsoft.AspNetCore.Components.ElementReference>>) = this.AddBinding("Ref", value)
    [<CustomOperation("Ref'")>] member this.Ref' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Nullable<Microsoft.AspNetCore.Components.ElementReference> * (System.Nullable<Microsoft.AspNetCore.Components.ElementReference> -> unit)) = this.AddBinding("Ref", valueFn)
    [<CustomOperation("RefChanged")>] member this.RefChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudExpansionPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudExpansionPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudExpansionPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudExpansionPanelBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudExpansionPanelBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("HideIcon")>] member this.HideIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideIcon" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> this.AddAttr
    [<CustomOperation("IsExpandedChanged")>] member this.IsExpandedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsExpandedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("IsExpanded")>] member this.IsExpanded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsExpanded" => x |> this.AddAttr
    [<CustomOperation("IsExpanded'")>] member this.IsExpanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsExpanded", value)
    [<CustomOperation("IsExpanded'")>] member this.IsExpanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsExpanded", value)
    [<CustomOperation("IsExpanded'")>] member this.IsExpanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsExpanded", valueFn)
    [<CustomOperation("IsInitiallyExpanded")>] member this.IsInitiallyExpanded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsInitiallyExpanded" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
                

type MudExpansionPanelsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudExpansionPanelsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudExpansionPanelsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudExpansionPanelsBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudExpansionPanelsBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("MultiExpansion")>] member this.MultiExpansion (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MultiExpansion" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> this.AddAttr
    [<CustomOperation("DisableBorders")>] member this.DisableBorders (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableBorders" => x |> this.AddAttr
                

type MudFieldBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudFieldBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudFieldBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudFieldBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> this.AddAttr
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Error" => x |> this.AddAttr
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ErrorText" => x |> this.AddAttr
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HelperText" => x |> this.AddAttr
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> this.AddAttr
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Label" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("AdornmentIcon")>] member this.AdornmentIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AdornmentIcon" => x |> this.AddAttr
    [<CustomOperation("AdornmentText")>] member this.AdornmentText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AdornmentText" => x |> this.AddAttr
    [<CustomOperation("Adornment")>] member this.Adornment (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Adornment) = "Adornment" => x |> this.AddAttr
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "AdornmentColor" => x |> this.AddAttr
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> this.AddAttr
    [<CustomOperation("OnAdornmentClick")>] member this.OnAdornmentClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnAdornmentClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("InnerPadding")>] member this.InnerPadding (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "InnerPadding" => x |> this.AddAttr
    [<CustomOperation("DisableUnderLine")>] member this.DisableUnderLine (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableUnderLine" => x |> this.AddAttr
                

type MudFocusTrapBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudFocusTrapBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudFocusTrapBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudFocusTrapBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudFocusTrapBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("DefaultFocus")>] member this.DefaultFocus (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.DefaultFocus) = "DefaultFocus" => x |> this.AddAttr
                

type MudFormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudFormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudFormBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudFormBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("IsValid")>] member this.IsValid (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsValid" => x |> this.AddAttr
    [<CustomOperation("IsValid'")>] member this.IsValid' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsValid", value)
    [<CustomOperation("IsValid'")>] member this.IsValid' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsValid", value)
    [<CustomOperation("IsValid'")>] member this.IsValid' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsValid", valueFn)
    [<CustomOperation("IsTouched")>] member this.IsTouched (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsTouched" => x |> this.AddAttr
    [<CustomOperation("IsTouched'")>] member this.IsTouched' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsTouched", value)
    [<CustomOperation("IsTouched'")>] member this.IsTouched' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsTouched", value)
    [<CustomOperation("IsTouched'")>] member this.IsTouched' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsTouched", valueFn)
    [<CustomOperation("ValidationDelay")>] member this.ValidationDelay (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ValidationDelay" => x |> this.AddAttr
    [<CustomOperation("SuppressRenderingOnValidation")>] member this.SuppressRenderingOnValidation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "SuppressRenderingOnValidation" => x |> this.AddAttr
    [<CustomOperation("SuppressImplicitSubmission")>] member this.SuppressImplicitSubmission (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "SuppressImplicitSubmission" => x |> this.AddAttr
    [<CustomOperation("IsValidChanged")>] member this.IsValidChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsValidChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("IsTouchedChanged")>] member this.IsTouchedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsTouchedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Errors")>] member this.Errors (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String[]) = "Errors" => x |> this.AddAttr
    [<CustomOperation("Errors'")>] member this.Errors' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.String[]>) = this.AddBinding("Errors", value)
    [<CustomOperation("Errors'")>] member this.Errors' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.String[]>) = this.AddBinding("Errors", value)
    [<CustomOperation("Errors'")>] member this.Errors' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.String[] * (System.String[] -> unit)) = this.AddBinding("Errors", valueFn)
    [<CustomOperation("ErrorsChanged")>] member this.ErrorsChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "ErrorsChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Model")>] member this.Model (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Model" => x |> this.AddAttr
                

type MudHiddenBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudHiddenBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudHiddenBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudHiddenBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudHiddenBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> this.AddAttr
    [<CustomOperation("Invert")>] member this.Invert (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Invert" => x |> this.AddAttr
    [<CustomOperation("IsHidden")>] member this.IsHidden (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsHidden" => x |> this.AddAttr
    [<CustomOperation("IsHidden'")>] member this.IsHidden' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsHidden", value)
    [<CustomOperation("IsHidden'")>] member this.IsHidden' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsHidden", value)
    [<CustomOperation("IsHidden'")>] member this.IsHidden' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsHidden", valueFn)
    [<CustomOperation("IsHiddenChanged")>] member this.IsHiddenChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsHiddenChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudIconBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudIconBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("ViewBox")>] member this.ViewBox (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ViewBox" => x |> this.AddAttr
                

type MudInputControlBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudInputControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudInputControlBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudInputControlBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudInputControlBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "InputContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "InputContent" (html.text x) |> this.AddAttr
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "InputContent" (html.text x) |> this.AddAttr
    [<CustomOperation("InputContent")>] member this.InputContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "InputContent" (html.text x) |> this.AddAttr
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> this.AddAttr
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Required" => x |> this.AddAttr
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Error" => x |> this.AddAttr
    [<CustomOperation("ErrorText")>] member this.ErrorText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ErrorText" => x |> this.AddAttr
    [<CustomOperation("HelperText")>] member this.HelperText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HelperText" => x |> this.AddAttr
    [<CustomOperation("HelperTextOnFocus")>] member this.HelperTextOnFocus (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HelperTextOnFocus" => x |> this.AddAttr
    [<CustomOperation("CounterText")>] member this.CounterText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CounterText" => x |> this.AddAttr
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> this.AddAttr
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Label" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
                

type MudInputLabelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudInputLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudInputLabelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudInputLabelBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudInputLabelBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("Error")>] member this.Error (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Error" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> this.AddAttr
                

type MudLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudLinkBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudLinkBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Typo")>] member this.Typo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Typo) = "Typo" => x |> this.AddAttr
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Underline) = "Underline" => x |> this.AddAttr
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Href" => x |> this.AddAttr
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Target" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
                

type MudListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudListBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudListBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Clickable")>] member this.Clickable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Clickable" => x |> this.AddAttr
    [<CustomOperation("DisablePadding")>] member this.DisablePadding (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisablePadding" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.MudListItem) = "SelectedItem" => x |> this.AddAttr
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<MudBlazor.MudListItem>) = this.AddBinding("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<MudBlazor.MudListItem>) = this.AddBinding("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: MudBlazor.MudListItem * (MudBlazor.MudListItem -> unit)) = this.AddBinding("SelectedItem", valueFn)
    [<CustomOperation("SelectedItemChanged")>] member this.SelectedItemChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudListItem> "SelectedItemChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedValue")>] member this.SelectedValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "SelectedValue" => x |> this.AddAttr
    [<CustomOperation("SelectedValue'")>] member this.SelectedValue' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Object>) = this.AddBinding("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member this.SelectedValue' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Object>) = this.AddBinding("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member this.SelectedValue' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Object * (System.Object -> unit)) = this.AddBinding("SelectedValue", valueFn)
    [<CustomOperation("SelectedValueChanged")>] member this.SelectedValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Object> "SelectedValueChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudListItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudListItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Value" => x |> this.AddAttr
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Avatar" => x |> this.AddAttr
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Href" => x |> this.AddAttr
    [<CustomOperation("ForceLoad")>] member this.ForceLoad (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ForceLoad" => x |> this.AddAttr
    [<CustomOperation("AvatarClass")>] member this.AvatarClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AvatarClass" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("IconSize")>] member this.IconSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "IconSize" => x |> this.AddAttr
    [<CustomOperation("AdornmentColor")>] member this.AdornmentColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "AdornmentColor" => x |> this.AddAttr
    [<CustomOperation("ExpandLessIcon")>] member this.ExpandLessIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ExpandLessIcon" => x |> this.AddAttr
    [<CustomOperation("ExpandMoreIcon")>] member this.ExpandMoreIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ExpandMoreIcon" => x |> this.AddAttr
    [<CustomOperation("Inset")>] member this.Inset (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Inset" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> this.AddAttr
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> this.AddAttr
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("InitiallyExpanded")>] member this.InitiallyExpanded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "InitiallyExpanded" => x |> this.AddAttr
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> this.AddAttr
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> this.AddAttr
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NestedList" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NestedList" (html.text x) |> this.AddAttr
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NestedList" (html.text x) |> this.AddAttr
    [<CustomOperation("NestedList")>] member this.NestedList (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NestedList" (html.text x) |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
                

type MudListSubheaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudListSubheaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudListSubheaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudListSubheaderBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudListSubheaderBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> this.AddAttr
    [<CustomOperation("Inset")>] member this.Inset (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Inset" => x |> this.AddAttr
                

type MudMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudMenuBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudMenuBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Label" => x |> this.AddAttr
    [<CustomOperation("ListClass")>] member this.ListClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ListClass" => x |> this.AddAttr
    [<CustomOperation("PopoverClass")>] member this.PopoverClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PopoverClass" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("StartIcon")>] member this.StartIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "StartIcon" => x |> this.AddAttr
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "EndIcon" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FullWidth" => x |> this.AddAttr
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("PositionAtCursor")>] member this.PositionAtCursor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "PositionAtCursor" => x |> this.AddAttr
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ActivatorContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ActivatorContent")>] member this.ActivatorContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ActivatorContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ActivationEvent")>] member this.ActivationEvent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.MouseEvent) = "ActivationEvent" => x |> this.AddAttr
    [<CustomOperation("AnchorOrigin")>] member this.AnchorOrigin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "AnchorOrigin" => x |> this.AddAttr
    [<CustomOperation("TransformOrigin")>] member this.TransformOrigin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "TransformOrigin" => x |> this.AddAttr
    [<CustomOperation("LockScroll")>] member this.LockScroll (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "LockScroll" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableElevation" => x |> this.AddAttr
                

type MudMenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudMenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudMenuItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudMenuItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("Link")>] member this.Link (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Link" => x |> this.AddAttr
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Target" => x |> this.AddAttr
    [<CustomOperation("ForceLoad")>] member this.ForceLoad (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ForceLoad" => x |> this.AddAttr
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> this.AddAttr
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
                

type MudMessageBoxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudMessageBoxBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TitleContent")>] member this.TitleContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleContent" (html.text x) |> this.AddAttr
    [<CustomOperation("Message")>] member this.Message (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Message" => x |> this.AddAttr
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "MessageContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "MessageContent" (html.text x) |> this.AddAttr
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "MessageContent" (html.text x) |> this.AddAttr
    [<CustomOperation("MessageContent")>] member this.MessageContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "MessageContent" (html.text x) |> this.AddAttr
    [<CustomOperation("CancelText")>] member this.CancelText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CancelText" => x |> this.AddAttr
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CancelButton" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CancelButton" (html.text x) |> this.AddAttr
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CancelButton" (html.text x) |> this.AddAttr
    [<CustomOperation("CancelButton")>] member this.CancelButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CancelButton" (html.text x) |> this.AddAttr
    [<CustomOperation("NoText")>] member this.NoText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NoText" => x |> this.AddAttr
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NoButton" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NoButton" (html.text x) |> this.AddAttr
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NoButton" (html.text x) |> this.AddAttr
    [<CustomOperation("NoButton")>] member this.NoButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NoButton" (html.text x) |> this.AddAttr
    [<CustomOperation("YesText")>] member this.YesText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "YesText" => x |> this.AddAttr
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "YesButton" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "YesButton" (html.text x) |> this.AddAttr
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "YesButton" (html.text x) |> this.AddAttr
    [<CustomOperation("YesButton")>] member this.YesButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "YesButton" (html.text x) |> this.AddAttr
    [<CustomOperation("OnYes")>] member this.OnYes (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnYes" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnNo")>] member this.OnNo (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnNo" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnCancel")>] member this.OnCancel (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCancel" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("IsVisible")>] member this.IsVisible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsVisible" => x |> this.AddAttr
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member this.IsVisibleChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudNavGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudNavGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudNavGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudNavGroupBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudNavGroupBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> this.AddAttr
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("HideExpandIcon")>] member this.HideExpandIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideExpandIcon" => x |> this.AddAttr
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("ExpandIcon")>] member this.ExpandIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ExpandIcon" => x |> this.AddAttr
                

type MudNavMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudNavMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudNavMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudNavMenuBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudNavMenuBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> this.AddAttr
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> this.AddAttr
    [<CustomOperation("Margin")>] member this.Margin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Margin) = "Margin" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
                

type MudOverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudOverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudOverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudOverlayBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudOverlayBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("VisibleChanged")>] member this.VisibleChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "VisibleChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> this.AddAttr
    [<CustomOperation("Visible'")>] member this.Visible' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Visible", value)
    [<CustomOperation("Visible'")>] member this.Visible' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Visible", value)
    [<CustomOperation("Visible'")>] member this.Visible' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Visible", valueFn)
    [<CustomOperation("AutoClose")>] member this.AutoClose (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AutoClose" => x |> this.AddAttr
    [<CustomOperation("LockScroll")>] member this.LockScroll (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "LockScroll" => x |> this.AddAttr
    [<CustomOperation("LockScrollClass")>] member this.LockScrollClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "LockScrollClass" => x |> this.AddAttr
    [<CustomOperation("DarkBackground")>] member this.DarkBackground (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DarkBackground" => x |> this.AddAttr
    [<CustomOperation("LightBackground")>] member this.LightBackground (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "LightBackground" => x |> this.AddAttr
    [<CustomOperation("Absolute")>] member this.Absolute (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Absolute" => x |> this.AddAttr
    [<CustomOperation("ZIndex")>] member this.ZIndex (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ZIndex" => x |> this.AddAttr
    [<CustomOperation("CommandParameter")>] member this.CommandParameter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "CommandParameter" => x |> this.AddAttr
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
                

type MudPageContentNavigationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudPageContentNavigationBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Headline")>] member this.Headline (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Headline" => x |> this.AddAttr
    [<CustomOperation("SectionClassSelector")>] member this.SectionClassSelector (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SectionClassSelector" => x |> this.AddAttr
    [<CustomOperation("ActivateFirstSectionAsDefault")>] member this.ActivateFirstSectionAsDefault (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ActivateFirstSectionAsDefault" => x |> this.AddAttr
                

type MudPaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudPaginationBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Count")>] member this.Count (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Count" => x |> this.AddAttr
    [<CustomOperation("BoundaryCount")>] member this.BoundaryCount (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "BoundaryCount" => x |> this.AddAttr
    [<CustomOperation("MiddleCount")>] member this.MiddleCount (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "MiddleCount" => x |> this.AddAttr
    [<CustomOperation("Selected")>] member this.Selected (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Selected" => x |> this.AddAttr
    [<CustomOperation("Selected'")>] member this.Selected' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Int32>) = this.AddBinding("Selected", value)
    [<CustomOperation("Selected'")>] member this.Selected' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Int32>) = this.AddBinding("Selected", value)
    [<CustomOperation("Selected'")>] member this.Selected' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Int32 * (System.Int32 -> unit)) = this.AddBinding("Selected", valueFn)
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Rectangular")>] member this.Rectangular (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Rectangular" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("DisableElevation")>] member this.DisableElevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableElevation" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("ShowFirstButton")>] member this.ShowFirstButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowFirstButton" => x |> this.AddAttr
    [<CustomOperation("ShowLastButton")>] member this.ShowLastButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowLastButton" => x |> this.AddAttr
    [<CustomOperation("ShowPreviousButton")>] member this.ShowPreviousButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowPreviousButton" => x |> this.AddAttr
    [<CustomOperation("ShowNextButton")>] member this.ShowNextButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowNextButton" => x |> this.AddAttr
    [<CustomOperation("ControlButtonClicked")>] member this.ControlButtonClicked (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.Page> "ControlButtonClicked" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedChanged")>] member this.SelectedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("FirstIcon")>] member this.FirstIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FirstIcon" => x |> this.AddAttr
    [<CustomOperation("BeforeIcon")>] member this.BeforeIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "BeforeIcon" => x |> this.AddAttr
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NextIcon" => x |> this.AddAttr
    [<CustomOperation("LastIcon")>] member this.LastIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "LastIcon" => x |> this.AddAttr
                

type MudPopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudPopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudPopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudPopoverBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudPopoverBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("Paper")>] member this.Paper (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Paper" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Open" => x |> this.AddAttr
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Fixed" => x |> this.AddAttr
    [<CustomOperation("Duration")>] member this.Duration (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Duration" => x |> this.AddAttr
    [<CustomOperation("Delay'")>] member this.Delay' (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Delay" => x |> this.AddAttr
    [<CustomOperation("AnchorOrigin")>] member this.AnchorOrigin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "AnchorOrigin" => x |> this.AddAttr
    [<CustomOperation("TransformOrigin")>] member this.TransformOrigin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Origin) = "TransformOrigin" => x |> this.AddAttr
    [<CustomOperation("OverflowBehavior")>] member this.OverflowBehavior (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.OverflowBehavior) = "OverflowBehavior" => x |> this.AddAttr
    [<CustomOperation("RelativeWidth")>] member this.RelativeWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "RelativeWidth" => x |> this.AddAttr
                

type MudProgressCircularBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudProgressCircularBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Indeterminate" => x |> this.AddAttr
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Min" => x |> this.AddAttr
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Max" => x |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Value" => x |> this.AddAttr
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "StrokeWidth" => x |> this.AddAttr
                

type MudProgressLinearBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudProgressLinearBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudProgressLinearBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudProgressLinearBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudProgressLinearBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Indeterminate" => x |> this.AddAttr
    [<CustomOperation("Buffer")>] member this.Buffer (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Buffer" => x |> this.AddAttr
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> this.AddAttr
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Striped" => x |> this.AddAttr
    [<CustomOperation("Vertical")>] member this.Vertical (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Vertical" => x |> this.AddAttr
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Min" => x |> this.AddAttr
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Max" => x |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Value" => x |> this.AddAttr
    [<CustomOperation("BufferValue")>] member this.BufferValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "BufferValue" => x |> this.AddAttr
                

type MudRadioBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudRadioBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudRadioBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudRadioBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudRadioBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Placement) = "Placement" => x |> this.AddAttr
    [<CustomOperation("Option")>] member this.Option (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Option" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
                

type MudRatingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudRatingBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("RatingItemsClass")>] member this.RatingItemsClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RatingItemsClass" => x |> this.AddAttr
    [<CustomOperation("RatingItemsStyle")>] member this.RatingItemsStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RatingItemsStyle" => x |> this.AddAttr
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Name" => x |> this.AddAttr
    [<CustomOperation("MaxValue")>] member this.MaxValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "MaxValue" => x |> this.AddAttr
    [<CustomOperation("FullIcon")>] member this.FullIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FullIcon" => x |> this.AddAttr
    [<CustomOperation("EmptyIcon")>] member this.EmptyIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "EmptyIcon" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("SelectedValueChanged")>] member this.SelectedValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "SelectedValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedValue")>] member this.SelectedValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "SelectedValue" => x |> this.AddAttr
    [<CustomOperation("SelectedValue'")>] member this.SelectedValue' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Int32>) = this.AddBinding("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member this.SelectedValue' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Int32>) = this.AddBinding("SelectedValue", value)
    [<CustomOperation("SelectedValue'")>] member this.SelectedValue' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Int32 * (System.Int32 -> unit)) = this.AddBinding("SelectedValue", valueFn)
    [<CustomOperation("HoveredValueChanged")>] member this.HoveredValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "HoveredValueChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudRatingItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudRatingItemBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("ItemValue")>] member this.ItemValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ItemValue" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("ItemClicked")>] member this.ItemClicked (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "ItemClicked" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("ItemHovered")>] member this.ItemHovered (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Nullable<System.Int32>> "ItemHovered" (fun e -> fn e)) |> this.AddAttr
                

type MudRTLProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudRTLProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudRTLProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudRTLProviderBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudRTLProviderBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("RightToLeft")>] member this.RightToLeft (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "RightToLeft" => x |> this.AddAttr
                

type MudScrollToTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudScrollToTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudScrollToTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudScrollToTopBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudScrollToTopBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Selector")>] member this.Selector (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Selector" => x |> this.AddAttr
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> this.AddAttr
    [<CustomOperation("VisibleCssClass")>] member this.VisibleCssClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "VisibleCssClass" => x |> this.AddAttr
    [<CustomOperation("HiddenCssClass")>] member this.HiddenCssClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HiddenCssClass" => x |> this.AddAttr
    [<CustomOperation("TopOffset")>] member this.TopOffset (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "TopOffset" => x |> this.AddAttr
    [<CustomOperation("ScrollBehavior")>] member this.ScrollBehavior (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.ScrollBehavior) = "ScrollBehavior" => x |> this.AddAttr
    [<CustomOperation("OnScroll")>] member this.OnScroll (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.ScrollEventArgs> "OnScroll" (fun e -> fn e)) |> this.AddAttr
                

type MudSkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudSkeletonBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Width" => x |> this.AddAttr
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Height" => x |> this.AddAttr
    [<CustomOperation("SkeletonType")>] member this.SkeletonType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.SkeletonType) = "SkeletonType" => x |> this.AddAttr
    [<CustomOperation("Animation")>] member this.Animation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Animation) = "Animation" => x |> this.AddAttr
                

type MudSliderBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudSliderBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudSliderBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudSliderBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudSliderBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Min" => x |> this.AddAttr
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Max" => x |> this.AddAttr
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Step" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("Converter")>] member this.Converter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Converter<'T>) = "Converter" => x |> this.AddAttr
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("Value", valueFn)
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Immediate")>] member this.Immediate (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Immediate" => x |> this.AddAttr
                

type MudSnackbarElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudSnackbarElementBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Snackbar")>] member this.Snackbar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Snackbar) = "Snackbar" => x |> this.AddAttr
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIcon" => x |> this.AddAttr
                

type MudSnackbarProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudSnackbarProviderBuilder<'FunBlazorGeneric>().CreateNode()

                

type MudSwipeAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudSwipeAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudSwipeAreaBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudSwipeAreaBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudSwipeAreaBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("OnSwipe")>] member this.OnSwipe (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "OnSwipe" => (System.Action<MudBlazor.SwipeDirection>fn) |> this.AddAttr
                

type MudSimpleTableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudSimpleTableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudSimpleTableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudSimpleTableBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudSimpleTableBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Hover" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> this.AddAttr
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> this.AddAttr
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Striped" => x |> this.AddAttr
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FixedHeader" => x |> this.AddAttr
                

type MudTableBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudTableBaseBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("IsEditRowSwitchingBlocked")>] member this.IsEditRowSwitchingBlocked (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsEditRowSwitchingBlocked" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> this.AddAttr
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Hover" => x |> this.AddAttr
    [<CustomOperation("Striped")>] member this.Striped (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Striped" => x |> this.AddAttr
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Breakpoint) = "Breakpoint" => x |> this.AddAttr
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FixedHeader" => x |> this.AddAttr
    [<CustomOperation("FixedFooter")>] member this.FixedFooter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FixedFooter" => x |> this.AddAttr
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Height" => x |> this.AddAttr
    [<CustomOperation("SortLabel")>] member this.SortLabel (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SortLabel" => x |> this.AddAttr
    [<CustomOperation("AllowUnsorted")>] member this.AllowUnsorted (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AllowUnsorted" => x |> this.AddAttr
    [<CustomOperation("RowsPerPage")>] member this.RowsPerPage (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "RowsPerPage" => x |> this.AddAttr
    [<CustomOperation("RowsPerPage'")>] member this.RowsPerPage' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Int32>) = this.AddBinding("RowsPerPage", value)
    [<CustomOperation("RowsPerPage'")>] member this.RowsPerPage' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Int32>) = this.AddBinding("RowsPerPage", value)
    [<CustomOperation("RowsPerPage'")>] member this.RowsPerPage' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Int32 * (System.Int32 -> unit)) = this.AddBinding("RowsPerPage", valueFn)
    [<CustomOperation("RowsPerPageChanged")>] member this.RowsPerPageChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "RowsPerPageChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("CurrentPage")>] member this.CurrentPage (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "CurrentPage" => x |> this.AddAttr
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MultiSelection" => x |> this.AddAttr
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ToolBarContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ToolBarContent")>] member this.ToolBarContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ToolBarContent" (html.text x) |> this.AddAttr
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> this.AddAttr
    [<CustomOperation("LoadingProgressColor")>] member this.LoadingProgressColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "LoadingProgressColor" => x |> this.AddAttr
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "HeaderContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "HeaderContent" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "HeaderContent" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderContent")>] member this.HeaderContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "HeaderContent" (html.text x) |> this.AddAttr
    [<CustomOperation("CustomHeader")>] member this.CustomHeader (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "CustomHeader" => x |> this.AddAttr
    [<CustomOperation("HeaderClass")>] member this.HeaderClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderClass" => x |> this.AddAttr
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "FooterContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "FooterContent" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "FooterContent" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterContent")>] member this.FooterContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "FooterContent" (html.text x) |> this.AddAttr
    [<CustomOperation("CustomFooter")>] member this.CustomFooter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "CustomFooter" => x |> this.AddAttr
    [<CustomOperation("FooterClass")>] member this.FooterClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterClass" => x |> this.AddAttr
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ColGroup" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ColGroup" (html.text x) |> this.AddAttr
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ColGroup" (html.text x) |> this.AddAttr
    [<CustomOperation("ColGroup")>] member this.ColGroup (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ColGroup" (html.text x) |> this.AddAttr
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PagerContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PagerContent" (html.text x) |> this.AddAttr
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PagerContent" (html.text x) |> this.AddAttr
    [<CustomOperation("PagerContent")>] member this.PagerContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PagerContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> this.AddAttr
    [<CustomOperation("OnCommitEditClick")>] member this.OnCommitEditClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCommitEditClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnCancelEditClick")>] member this.OnCancelEditClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancelEditClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnPreviewEditClick")>] member this.OnPreviewEditClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Object> "OnPreviewEditClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("CommitEditCommand")>] member this.CommitEditCommand (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "CommitEditCommand" => x |> this.AddAttr
    [<CustomOperation("CommitEditCommandParameter")>] member this.CommitEditCommandParameter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "CommitEditCommandParameter" => x |> this.AddAttr
    [<CustomOperation("CommitEditTooltip")>] member this.CommitEditTooltip (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CommitEditTooltip" => x |> this.AddAttr
    [<CustomOperation("CancelEditTooltip")>] member this.CancelEditTooltip (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CancelEditTooltip" => x |> this.AddAttr
    [<CustomOperation("CommitEditIcon")>] member this.CommitEditIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CommitEditIcon" => x |> this.AddAttr
    [<CustomOperation("CancelEditIcon")>] member this.CancelEditIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CancelEditIcon" => x |> this.AddAttr
    [<CustomOperation("CanCancelEdit")>] member this.CanCancelEdit (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "CanCancelEdit" => x |> this.AddAttr
    [<CustomOperation("RowEditPreview")>] member this.RowEditPreview (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "RowEditPreview" => (System.Action<System.Object>fn) |> this.AddAttr
    [<CustomOperation("RowEditCommit")>] member this.RowEditCommit (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "RowEditCommit" => (System.Action<System.Object>fn) |> this.AddAttr
    [<CustomOperation("RowEditCancel")>] member this.RowEditCancel (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "RowEditCancel" => (System.Action<System.Object>fn) |> this.AddAttr
    [<CustomOperation("TotalItems")>] member this.TotalItems (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "TotalItems" => x |> this.AddAttr
    [<CustomOperation("RowClass")>] member this.RowClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RowClass" => x |> this.AddAttr
    [<CustomOperation("RowStyle")>] member this.RowStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RowStyle" => x |> this.AddAttr
    [<CustomOperation("Virtualize")>] member this.Virtualize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Virtualize" => x |> this.AddAttr
                

type MudTableBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTableBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudTableBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("RowTemplate")>] member this.RowTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("ChildRowContent")>] member this.ChildRowContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildRowContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("RowEditingTemplate")>] member this.RowEditingTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "RowEditingTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Columns")>] member this.Columns (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Columns" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("QuickColumns")>] member this.QuickColumns (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "QuickColumns" => x |> this.AddAttr
    [<CustomOperation("NoRecordsContent")>] member this.NoRecordsContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NoRecordsContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("NoRecordsContent")>] member this.NoRecordsContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NoRecordsContent" (html.text x) |> this.AddAttr
    [<CustomOperation("NoRecordsContent")>] member this.NoRecordsContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NoRecordsContent" (html.text x) |> this.AddAttr
    [<CustomOperation("NoRecordsContent")>] member this.NoRecordsContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NoRecordsContent" (html.text x) |> this.AddAttr
    [<CustomOperation("LoadingContent")>] member this.LoadingContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "LoadingContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("LoadingContent")>] member this.LoadingContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "LoadingContent" (html.text x) |> this.AddAttr
    [<CustomOperation("LoadingContent")>] member this.LoadingContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "LoadingContent" (html.text x) |> this.AddAttr
    [<CustomOperation("LoadingContent")>] member this.LoadingContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "LoadingContent" (html.text x) |> this.AddAttr
    [<CustomOperation("HorizontalScrollbar")>] member this.HorizontalScrollbar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HorizontalScrollbar" => x |> this.AddAttr
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'T>) = "Items" => x |> this.AddAttr
    [<CustomOperation("Filter")>] member this.Filter (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "Filter" => (System.Func<'T, System.Boolean>fn) |> this.AddAttr
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.TableRowClickEventArgs<'T>> "OnRowClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("RowClassFunc")>] member this.RowClassFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "RowClassFunc" => (System.Func<'T, System.Int32, System.String>fn) |> this.AddAttr
    [<CustomOperation("RowStyleFunc")>] member this.RowStyleFunc (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "RowStyleFunc" => (System.Func<'T, System.Int32, System.String>fn) |> this.AddAttr
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "SelectedItem" => x |> this.AddAttr
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<'T>) = this.AddBinding("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<'T>) = this.AddBinding("SelectedItem", value)
    [<CustomOperation("SelectedItem'")>] member this.SelectedItem' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: 'T * ('T -> unit)) = this.AddBinding("SelectedItem", valueFn)
    [<CustomOperation("SelectedItemChanged")>] member this.SelectedItemChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "SelectedItemChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedItems")>] member this.SelectedItems (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.HashSet<'T>) = "SelectedItems" => x |> this.AddAttr
    [<CustomOperation("SelectedItems'")>] member this.SelectedItems' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Collections.Generic.HashSet<'T>>) = this.AddBinding("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member this.SelectedItems' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Collections.Generic.HashSet<'T>>) = this.AddBinding("SelectedItems", value)
    [<CustomOperation("SelectedItems'")>] member this.SelectedItems' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Collections.Generic.HashSet<'T> * (System.Collections.Generic.HashSet<'T> -> unit)) = this.AddBinding("SelectedItems", valueFn)
    [<CustomOperation("SelectedItemsChanged")>] member this.SelectedItemsChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedItemsChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("GroupBy")>] member this.GroupBy (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TableGroupDefinition<'T>) = "GroupBy" => x |> this.AddAttr
    [<CustomOperation("GroupHeaderTemplate")>] member this.GroupHeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: MudBlazor.TableGroupData<System.Object, 'T> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "GroupHeaderTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("GroupHeaderClass")>] member this.GroupHeaderClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "GroupHeaderClass" => x |> this.AddAttr
    [<CustomOperation("GroupHeaderStyle")>] member this.GroupHeaderStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "GroupHeaderStyle" => x |> this.AddAttr
    [<CustomOperation("GroupFooterClass")>] member this.GroupFooterClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "GroupFooterClass" => x |> this.AddAttr
    [<CustomOperation("GroupFooterStyle")>] member this.GroupFooterStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "GroupFooterStyle" => x |> this.AddAttr
    [<CustomOperation("GroupFooterTemplate")>] member this.GroupFooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: MudBlazor.TableGroupData<System.Object, 'T> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "GroupFooterTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("ServerData")>] member this.ServerData (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "ServerData" => (System.Func<MudBlazor.TableState, System.Threading.Tasks.Task<MudBlazor.TableData<'T>>>fn) |> this.AddAttr
                

type MudTableGroupRowBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudTableGroupRowBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("GroupDefinition")>] member this.GroupDefinition (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TableGroupDefinition<'T>) = "GroupDefinition" => x |> this.AddAttr
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Linq.IGrouping<System.Object, 'T>) = "Items" => x |> this.AddAttr
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: MudBlazor.TableGroupData<System.Object, 'T> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "HeaderTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: MudBlazor.TableGroupData<System.Object, 'T> -> Bolero.Node) = Bolero.Html.attr.fragmentWith "FooterTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsCheckable" => x |> this.AddAttr
    [<CustomOperation("HeaderClass")>] member this.HeaderClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderClass" => x |> this.AddAttr
    [<CustomOperation("FooterClass")>] member this.FooterClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterClass" => x |> this.AddAttr
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HeaderStyle" => x |> this.AddAttr
    [<CustomOperation("FooterStyle")>] member this.FooterStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FooterStyle" => x |> this.AddAttr
    [<CustomOperation("ExpandIcon")>] member this.ExpandIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ExpandIcon" => x |> this.AddAttr
    [<CustomOperation("CollapseIcon")>] member this.CollapseIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CollapseIcon" => x |> this.AddAttr
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> this.AddAttr
                

type MudTablePagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudTablePagerBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("HideRowsPerPage")>] member this.HideRowsPerPage (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideRowsPerPage" => x |> this.AddAttr
    [<CustomOperation("HidePageNumber")>] member this.HidePageNumber (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HidePageNumber" => x |> this.AddAttr
    [<CustomOperation("HidePagination")>] member this.HidePagination (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HidePagination" => x |> this.AddAttr
    [<CustomOperation("HorizontalAlignment")>] member this.HorizontalAlignment (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.HorizontalAlignment) = "HorizontalAlignment" => x |> this.AddAttr
    [<CustomOperation("PageSizeOptions")>] member this.PageSizeOptions (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32[]) = "PageSizeOptions" => x |> this.AddAttr
    [<CustomOperation("InfoFormat")>] member this.InfoFormat (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "InfoFormat" => x |> this.AddAttr
    [<CustomOperation("RowsPerPageString")>] member this.RowsPerPageString (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "RowsPerPageString" => x |> this.AddAttr
    [<CustomOperation("FirstIcon")>] member this.FirstIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "FirstIcon" => x |> this.AddAttr
    [<CustomOperation("BeforeIcon")>] member this.BeforeIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "BeforeIcon" => x |> this.AddAttr
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NextIcon" => x |> this.AddAttr
    [<CustomOperation("LastIcon")>] member this.LastIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "LastIcon" => x |> this.AddAttr
                

type MudTableSortLabelBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTableSortLabelBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("InitialDirection")>] member this.InitialDirection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.SortDirection) = "InitialDirection" => x |> this.AddAttr
    [<CustomOperation("Enabled")>] member this.Enabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Enabled" => x |> this.AddAttr
    [<CustomOperation("SortIcon")>] member this.SortIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SortIcon" => x |> this.AddAttr
    [<CustomOperation("AppendIcon")>] member this.AppendIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AppendIcon" => x |> this.AddAttr
    [<CustomOperation("SortDirection")>] member this.SortDirection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.SortDirection) = "SortDirection" => x |> this.AddAttr
    [<CustomOperation("SortDirection'")>] member this.SortDirection' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<MudBlazor.SortDirection>) = this.AddBinding("SortDirection", value)
    [<CustomOperation("SortDirection'")>] member this.SortDirection' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<MudBlazor.SortDirection>) = this.AddBinding("SortDirection", value)
    [<CustomOperation("SortDirection'")>] member this.SortDirection' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: MudBlazor.SortDirection * (MudBlazor.SortDirection -> unit)) = this.AddBinding("SortDirection", valueFn)
    [<CustomOperation("SortDirectionChanged")>] member this.SortDirectionChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.SortDirection> "SortDirectionChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SortBy")>] member this.SortBy (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "SortBy" => (System.Func<'T, System.Object>fn) |> this.AddAttr
    [<CustomOperation("SortLabel")>] member this.SortLabel (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SortLabel" => x |> this.AddAttr
                

type MudTdBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTdBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTdBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTdBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTdBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("DataLabel")>] member this.DataLabel (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "DataLabel" => x |> this.AddAttr
    [<CustomOperation("HideSmall")>] member this.HideSmall (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideSmall" => x |> this.AddAttr
                

type MudTFootRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTFootRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTFootRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTFootRowBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTFootRowBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsCheckable" => x |> this.AddAttr
    [<CustomOperation("IgnoreCheckbox")>] member this.IgnoreCheckbox (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreCheckbox" => x |> this.AddAttr
    [<CustomOperation("IgnoreEditable")>] member this.IgnoreEditable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreEditable" => x |> this.AddAttr
    [<CustomOperation("IsExpandable")>] member this.IsExpandable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsExpandable" => x |> this.AddAttr
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> this.AddAttr
                

type MudThBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudThBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudThBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudThBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudThBuilder<'FunBlazorGeneric>(x).CreateNode()

                

type MudTHeadRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTHeadRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTHeadRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTHeadRowBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTHeadRowBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsCheckable" => x |> this.AddAttr
    [<CustomOperation("IgnoreCheckbox")>] member this.IgnoreCheckbox (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreCheckbox" => x |> this.AddAttr
    [<CustomOperation("IgnoreEditable")>] member this.IgnoreEditable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreEditable" => x |> this.AddAttr
    [<CustomOperation("IsExpandable")>] member this.IsExpandable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsExpandable" => x |> this.AddAttr
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnRowClick" (fun e -> fn e)) |> this.AddAttr
                

type MudTrBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTrBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTrBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTrBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTrBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Item")>] member this.Item (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Item" => x |> this.AddAttr
    [<CustomOperation("IsCheckable")>] member this.IsCheckable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsCheckable" => x |> this.AddAttr
    [<CustomOperation("IsEditable")>] member this.IsEditable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsEditable" => x |> this.AddAttr
    [<CustomOperation("IsEditing")>] member this.IsEditing (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsEditing" => x |> this.AddAttr
    [<CustomOperation("IsEditSwitchBlocked")>] member this.IsEditSwitchBlocked (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsEditSwitchBlocked" => x |> this.AddAttr
    [<CustomOperation("IsExpandable")>] member this.IsExpandable (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsExpandable" => x |> this.AddAttr
    [<CustomOperation("IsHeader")>] member this.IsHeader (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsHeader" => x |> this.AddAttr
    [<CustomOperation("IsFooter")>] member this.IsFooter (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsFooter" => x |> this.AddAttr
    [<CustomOperation("IsCheckedChanged")>] member this.IsCheckedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsCheckedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("IsChecked")>] member this.IsChecked (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsChecked" => x |> this.AddAttr
    [<CustomOperation("IsChecked'")>] member this.IsChecked' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsChecked", value)
    [<CustomOperation("IsChecked'")>] member this.IsChecked' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsChecked", value)
    [<CustomOperation("IsChecked'")>] member this.IsChecked' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsChecked", valueFn)
                

type MudTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTabsBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTabsBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("KeepPanelsAlive")>] member this.KeepPanelsAlive (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "KeepPanelsAlive" => x |> this.AddAttr
    [<CustomOperation("Rounded")>] member this.Rounded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Rounded" => x |> this.AddAttr
    [<CustomOperation("Border")>] member this.Border (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Border" => x |> this.AddAttr
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> this.AddAttr
    [<CustomOperation("Centered")>] member this.Centered (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Centered" => x |> this.AddAttr
    [<CustomOperation("HideSlider")>] member this.HideSlider (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideSlider" => x |> this.AddAttr
    [<CustomOperation("PrevIcon")>] member this.PrevIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PrevIcon" => x |> this.AddAttr
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "NextIcon" => x |> this.AddAttr
    [<CustomOperation("AlwaysShowScrollButtons")>] member this.AlwaysShowScrollButtons (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "AlwaysShowScrollButtons" => x |> this.AddAttr
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("Position")>] member this.Position (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Position) = "Position" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("SliderColor")>] member this.SliderColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "SliderColor" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("ScrollIconColor")>] member this.ScrollIconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "ScrollIconColor" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("ApplyEffectsToContainer")>] member this.ApplyEffectsToContainer (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ApplyEffectsToContainer" => x |> this.AddAttr
    [<CustomOperation("DisableRipple")>] member this.DisableRipple (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableRipple" => x |> this.AddAttr
    [<CustomOperation("DisableSliderAnimation")>] member this.DisableSliderAnimation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableSliderAnimation" => x |> this.AddAttr
    [<CustomOperation("PrePanelContent")>] member this.PrePanelContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: MudBlazor.MudTabPanel -> Bolero.Node) = Bolero.Html.attr.fragmentWith "PrePanelContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("TabPanelClass")>] member this.TabPanelClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "TabPanelClass" => x |> this.AddAttr
    [<CustomOperation("PanelClass")>] member this.PanelClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PanelClass" => x |> this.AddAttr
    [<CustomOperation("ActivePanelIndex")>] member this.ActivePanelIndex (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ActivePanelIndex" => x |> this.AddAttr
    [<CustomOperation("ActivePanelIndex'")>] member this.ActivePanelIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Int32>) = this.AddBinding("ActivePanelIndex", value)
    [<CustomOperation("ActivePanelIndex'")>] member this.ActivePanelIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Int32>) = this.AddBinding("ActivePanelIndex", value)
    [<CustomOperation("ActivePanelIndex'")>] member this.ActivePanelIndex' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Int32 * (System.Int32 -> unit)) = this.AddBinding("ActivePanelIndex", valueFn)
    [<CustomOperation("ActivePanelIndexChanged")>] member this.ActivePanelIndexChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "ActivePanelIndexChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorBuilder<'FunBlazorGeneric>, render: MudBlazor.MudTabs -> Bolero.Node) = Bolero.Html.attr.fragmentWith "Header" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("HeaderPosition")>] member this.HeaderPosition (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TabHeaderPosition) = "HeaderPosition" => x |> this.AddAttr
    [<CustomOperation("TabPanelHeader")>] member this.TabPanelHeader (_: FunBlazorBuilder<'FunBlazorGeneric>, render: MudBlazor.MudTabPanel -> Bolero.Node) = Bolero.Html.attr.fragmentWith "TabPanelHeader" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("TabPanelHeaderPosition")>] member this.TabPanelHeaderPosition (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TabHeaderPosition) = "TabPanelHeaderPosition" => x |> this.AddAttr
                

type MudDynamicTabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudTabsBuilder<'FunBlazorGeneric>()
    static member create () = MudDynamicTabsBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("AddTabIcon")>] member this.AddTabIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AddTabIcon" => x |> this.AddAttr
    [<CustomOperation("CloseTabIcon")>] member this.CloseTabIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseTabIcon" => x |> this.AddAttr
    [<CustomOperation("AddTab")>] member this.AddTab (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = attr.callbackOfUnit("AddTab", fn) |> this.AddAttr
    [<CustomOperation("CloseTab")>] member this.CloseTab (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<MudBlazor.MudTabPanel> "CloseTab" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("AddIconClass")>] member this.AddIconClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AddIconClass" => x |> this.AddAttr
    [<CustomOperation("AddIconStyle")>] member this.AddIconStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AddIconStyle" => x |> this.AddAttr
    [<CustomOperation("CloseIconClass")>] member this.CloseIconClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIconClass" => x |> this.AddAttr
    [<CustomOperation("CloseIconStyle")>] member this.CloseIconStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIconStyle" => x |> this.AddAttr
    [<CustomOperation("AddIconToolTip")>] member this.AddIconToolTip (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "AddIconToolTip" => x |> this.AddAttr
    [<CustomOperation("CloseIconToolTip")>] member this.CloseIconToolTip (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CloseIconToolTip" => x |> this.AddAttr
                

type MudTimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTimelineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTimelineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTimelineItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTimelineItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("Variant")>] member this.Variant (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Variant) = "Variant" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("TimelineAlign")>] member this.TimelineAlign (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.TimelineAlign) = "TimelineAlign" => x |> this.AddAttr
    [<CustomOperation("HideDot")>] member this.HideDot (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideDot" => x |> this.AddAttr
    [<CustomOperation("ItemOpposite")>] member this.ItemOpposite (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ItemOpposite" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ItemOpposite")>] member this.ItemOpposite (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ItemOpposite" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemOpposite")>] member this.ItemOpposite (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ItemOpposite" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemOpposite")>] member this.ItemOpposite (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ItemOpposite" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemContent")>] member this.ItemContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ItemContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ItemContent")>] member this.ItemContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ItemContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemContent")>] member this.ItemContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ItemContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemContent")>] member this.ItemContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ItemContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemDot")>] member this.ItemDot (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ItemDot" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ItemDot")>] member this.ItemDot (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ItemDot" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemDot")>] member this.ItemDot (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ItemDot" (html.text x) |> this.AddAttr
    [<CustomOperation("ItemDot")>] member this.ItemDot (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ItemDot" (html.text x) |> this.AddAttr
                

type MudTooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTooltipBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTooltipBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("Arrow")>] member this.Arrow (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Arrow" => x |> this.AddAttr
    [<CustomOperation("Duration")>] member this.Duration (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Duration" => x |> this.AddAttr
    [<CustomOperation("Delay'")>] member this.Delay' (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Double) = "Delay" => x |> this.AddAttr
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Placement) = "Placement" => x |> this.AddAttr
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TooltipContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TooltipContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TooltipContent" (html.text x) |> this.AddAttr
    [<CustomOperation("TooltipContent")>] member this.TooltipContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TooltipContent" (html.text x) |> this.AddAttr
    [<CustomOperation("Inline")>] member this.Inline (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Inline" => x |> this.AddAttr
    [<CustomOperation("IsVisible")>] member this.IsVisible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsVisible" => x |> this.AddAttr
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsVisible", value)
    [<CustomOperation("IsVisible'")>] member this.IsVisible' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsVisible", valueFn)
    [<CustomOperation("IsVisibleChanged")>] member this.IsVisibleChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsVisibleChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudTreeViewBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTreeViewBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTreeViewBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTreeViewBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTreeViewBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("CheckBoxColor")>] member this.CheckBoxColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "CheckBoxColor" => x |> this.AddAttr
    [<CustomOperation("MultiSelection")>] member this.MultiSelection (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MultiSelection" => x |> this.AddAttr
    [<CustomOperation("ExpandOnClick")>] member this.ExpandOnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ExpandOnClick" => x |> this.AddAttr
    [<CustomOperation("Hover")>] member this.Hover (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Hover" => x |> this.AddAttr
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Height" => x |> this.AddAttr
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Width" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> this.AddAttr
    [<CustomOperation("SelectedValueChanged")>] member this.SelectedValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'T> "SelectedValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedValuesChanged")>] member this.SelectedValuesChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.HashSet<'T>> "SelectedValuesChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("ServerData")>] member this.ServerData (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = "ServerData" => (System.Func<'T, System.Threading.Tasks.Task<System.Collections.Generic.HashSet<'T>>>fn) |> this.AddAttr
                

type MudTreeViewItemBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTreeViewItemBuilder<'FunBlazorGeneric, 'T>(x).CreateNode()
    [<CustomOperation("CheckedIcon")>] member this.CheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "CheckedIcon" => x |> this.AddAttr
    [<CustomOperation("UncheckedIcon")>] member this.UncheckedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "UncheckedIcon" => x |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: 'T) = "Value" => x |> this.AddAttr
    [<CustomOperation("Culture")>] member this.Culture (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Globalization.CultureInfo) = "Culture" => x |> this.AddAttr
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("TextTypo")>] member this.TextTypo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Typo) = "TextTypo" => x |> this.AddAttr
    [<CustomOperation("TextClass")>] member this.TextClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "TextClass" => x |> this.AddAttr
    [<CustomOperation("EndText")>] member this.EndText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "EndText" => x |> this.AddAttr
    [<CustomOperation("EndTextTypo")>] member this.EndTextTypo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Typo) = "EndTextTypo" => x |> this.AddAttr
    [<CustomOperation("EndTextClass")>] member this.EndTextClass (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "EndTextClass" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Content" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.HashSet<'T>) = "Items" => x |> this.AddAttr
    [<CustomOperation("Command")>] member this.Command (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Windows.Input.ICommand) = "Command" => x |> this.AddAttr
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> this.AddAttr
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Expanded", valueFn)
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Activated")>] member this.Activated (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Activated" => x |> this.AddAttr
    [<CustomOperation("Activated'")>] member this.Activated' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Activated", value)
    [<CustomOperation("Activated'")>] member this.Activated' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Activated", value)
    [<CustomOperation("Activated'")>] member this.Activated' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Activated", valueFn)
    [<CustomOperation("Selected")>] member this.Selected (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Selected" => x |> this.AddAttr
    [<CustomOperation("Selected'")>] member this.Selected' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Selected", value)
    [<CustomOperation("Selected'")>] member this.Selected' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Selected", value)
    [<CustomOperation("Selected'")>] member this.Selected' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Selected", valueFn)
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("IconColor")>] member this.IconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "IconColor" => x |> this.AddAttr
    [<CustomOperation("EndIcon")>] member this.EndIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "EndIcon" => x |> this.AddAttr
    [<CustomOperation("EndIconColor")>] member this.EndIconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "EndIconColor" => x |> this.AddAttr
    [<CustomOperation("ExpandedIcon")>] member this.ExpandedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ExpandedIcon" => x |> this.AddAttr
    [<CustomOperation("ExpandedIconColor")>] member this.ExpandedIconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "ExpandedIconColor" => x |> this.AddAttr
    [<CustomOperation("LoadingIcon")>] member this.LoadingIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "LoadingIcon" => x |> this.AddAttr
    [<CustomOperation("LoadingIconColor")>] member this.LoadingIconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "LoadingIconColor" => x |> this.AddAttr
    [<CustomOperation("ActivatedChanged")>] member this.ActivatedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ActivatedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SelectedChanged")>] member this.SelectedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "SelectedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
                

type MudTextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTextBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTextBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Typo")>] member this.Typo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Typo) = "Typo" => x |> this.AddAttr
    [<CustomOperation("Align")>] member this.Align (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Align) = "Align" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("GutterBottom")>] member this.GutterBottom (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "GutterBottom" => x |> this.AddAttr
    [<CustomOperation("Inline")>] member this.Inline (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Inline" => x |> this.AddAttr
                

type MudContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudContainerBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudContainerBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Fixed" => x |> this.AddAttr
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.MaxWidth) = "MaxWidth" => x |> this.AddAttr
                

type MudDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudDividerBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Absolute")>] member this.Absolute (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Absolute" => x |> this.AddAttr
    [<CustomOperation("FlexItem")>] member this.FlexItem (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FlexItem" => x |> this.AddAttr
    [<CustomOperation("Light")>] member this.Light (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Light" => x |> this.AddAttr
    [<CustomOperation("Vertical")>] member this.Vertical (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Vertical" => x |> this.AddAttr
    [<CustomOperation("DividerType")>] member this.DividerType (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.DividerType) = "DividerType" => x |> this.AddAttr
                

type MudDrawerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudDrawerHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudDrawerHeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudDrawerHeaderBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudDrawerHeaderBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("LinkToIndex")>] member this.LinkToIndex (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "LinkToIndex" => x |> this.AddAttr
                

type MudGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudGridBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudGridBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Spacing")>] member this.Spacing (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Spacing" => x |> this.AddAttr
    [<CustomOperation("Justify")>] member this.Justify (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Justify) = "Justify" => x |> this.AddAttr
                

type MudItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudItemBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("xs")>] member this.xs (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "xs" => x |> this.AddAttr
    [<CustomOperation("sm")>] member this.sm (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "sm" => x |> this.AddAttr
    [<CustomOperation("md")>] member this.md (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "md" => x |> this.AddAttr
    [<CustomOperation("lg")>] member this.lg (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "lg" => x |> this.AddAttr
    [<CustomOperation("xl")>] member this.xl (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "xl" => x |> this.AddAttr
    [<CustomOperation("xxl")>] member this.xxl (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "xxl" => x |> this.AddAttr
                

type MudHighlighterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudHighlighterBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("HighlightedText")>] member this.HighlightedText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "HighlightedText" => x |> this.AddAttr
    [<CustomOperation("CaseSensitive")>] member this.CaseSensitive (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "CaseSensitive" => x |> this.AddAttr
    [<CustomOperation("UntilNextBoundary")>] member this.UntilNextBoundary (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "UntilNextBoundary" => x |> this.AddAttr
                

type MudMainContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudMainContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudMainContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudMainContentBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudMainContentBuilder<'FunBlazorGeneric>(x).CreateNode()

                

type MudPaperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudPaperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudPaperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudPaperBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudPaperBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Elevation")>] member this.Elevation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Elevation" => x |> this.AddAttr
    [<CustomOperation("Square")>] member this.Square (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Square" => x |> this.AddAttr
    [<CustomOperation("Outlined")>] member this.Outlined (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Outlined" => x |> this.AddAttr
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Height" => x |> this.AddAttr
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Width" => x |> this.AddAttr
    [<CustomOperation("MaxHeight")>] member this.MaxHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "MaxHeight" => x |> this.AddAttr
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "MaxWidth" => x |> this.AddAttr
    [<CustomOperation("MinHeight")>] member this.MinHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "MinHeight" => x |> this.AddAttr
    [<CustomOperation("MinWidth")>] member this.MinWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "MinWidth" => x |> this.AddAttr
                

type MudSparkLineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MudSparkLineBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "StrokeWidth" => x |> this.AddAttr
                

type MudTabPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudTabPanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudTabPanelBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudTabPanelBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> this.AddAttr
    [<CustomOperation("BadgeData")>] member this.BadgeData (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "BadgeData" => x |> this.AddAttr
    [<CustomOperation("BadgeDot")>] member this.BadgeDot (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "BadgeDot" => x |> this.AddAttr
    [<CustomOperation("BadgeColor")>] member this.BadgeColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "BadgeColor" => x |> this.AddAttr
    [<CustomOperation("ID")>] member this.ID (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "ID" => x |> this.AddAttr
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("ToolTip")>] member this.ToolTip (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ToolTip" => x |> this.AddAttr
                

type MudToolBarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit MudComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudToolBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudToolBarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudToolBarBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudToolBarBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Dense")>] member this.Dense (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Dense" => x |> this.AddAttr
    [<CustomOperation("DisableGutters")>] member this.DisableGutters (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableGutters" => x |> this.AddAttr
                

type FilterBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = FilterBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Guid) = "Id" => x |> this.AddAttr
    [<CustomOperation("Field")>] member this.Field (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Field" => x |> this.AddAttr
    [<CustomOperation("Field'")>] member this.Field' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.String>) = this.AddBinding("Field", value)
    [<CustomOperation("Field'")>] member this.Field' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.String>) = this.AddBinding("Field", value)
    [<CustomOperation("Field'")>] member this.Field' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.String * (System.String -> unit)) = this.AddBinding("Field", valueFn)
    [<CustomOperation("Operator")>] member this.Operator (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Operator" => x |> this.AddAttr
    [<CustomOperation("Operator'")>] member this.Operator' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.String>) = this.AddBinding("Operator", value)
    [<CustomOperation("Operator'")>] member this.Operator' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.String>) = this.AddBinding("Operator", value)
    [<CustomOperation("Operator'")>] member this.Operator' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.String * (System.String -> unit)) = this.AddBinding("Operator", valueFn)
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Object) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Object>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Object>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Object * (System.Object -> unit)) = this.AddBinding("Value", valueFn)
    [<CustomOperation("FieldChanged")>] member this.FieldChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "FieldChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OperatorChanged")>] member this.OperatorChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OperatorChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Object> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudDialogProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = MudDialogProviderBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("NoHeader")>] member this.NoHeader (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "NoHeader" => x |> this.AddAttr
    [<CustomOperation("CloseButton")>] member this.CloseButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "CloseButton" => x |> this.AddAttr
    [<CustomOperation("DisableBackdropClick")>] member this.DisableBackdropClick (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "DisableBackdropClick" => x |> this.AddAttr
    [<CustomOperation("CloseOnEscapeKey")>] member this.CloseOnEscapeKey (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "CloseOnEscapeKey" => x |> this.AddAttr
    [<CustomOperation("FullWidth")>] member this.FullWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "FullWidth" => x |> this.AddAttr
    [<CustomOperation("Position")>] member this.Position (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<MudBlazor.DialogPosition>) = "Position" => x |> this.AddAttr
    [<CustomOperation("MaxWidth")>] member this.MaxWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Nullable<MudBlazor.MaxWidth>) = "MaxWidth" => x |> this.AddAttr
                

type MudPopoverProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = MudPopoverProviderBuilder<'FunBlazorGeneric>().CreateNode()

                

type BaseMudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = BaseMudThemeProviderBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.MudTheme) = "Theme" => x |> this.AddAttr
    [<CustomOperation("DefaultScrollbar")>] member this.DefaultScrollbar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DefaultScrollbar" => x |> this.AddAttr
    [<CustomOperation("IsDarkMode")>] member this.IsDarkMode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsDarkMode" => x |> this.AddAttr
    [<CustomOperation("IsDarkMode'")>] member this.IsDarkMode' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("IsDarkMode", value)
    [<CustomOperation("IsDarkMode'")>] member this.IsDarkMode' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("IsDarkMode", value)
    [<CustomOperation("IsDarkMode'")>] member this.IsDarkMode' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("IsDarkMode", valueFn)
    [<CustomOperation("IsDarkModeChanged")>] member this.IsDarkModeChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "IsDarkModeChanged" (fun e -> fn e)) |> this.AddAttr
                

type MudThemeProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit BaseMudThemeProviderBuilder<'FunBlazorGeneric>()
    static member create () = MudThemeProviderBuilder<'FunBlazorGeneric>().CreateNode()

                

type MudVirtualizeBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = MudVirtualizeBuilder<'FunBlazorGeneric, 'T>().CreateNode()
    [<CustomOperation("IsEnabled")>] member this.IsEnabled (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsEnabled" => x |> this.AddAttr
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorBuilder<'FunBlazorGeneric>, render: 'T -> Bolero.Node) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Items")>] member this.Items (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.ICollection<'T>) = "Items" => x |> this.AddAttr
                

type BreadcrumbLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = BreadcrumbLinkBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Item")>] member this.Item (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.BreadcrumbItem) = "Item" => x |> this.AddAttr
                

type BreadcrumbSeparatorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = BreadcrumbSeparatorBuilder<'FunBlazorGeneric>().CreateNode()

                

type MudPickerContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudPickerContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudPickerContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudPickerContentBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudPickerContentBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
                

type MudPickerToolbarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MudPickerToolbarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = MudPickerToolbarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = MudPickerToolbarBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = MudPickerToolbarBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddAttr
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorBuilder<'FunBlazorGeneric>, x: (string * string) list) = attr.styles x |> this.AddAttr
    [<CustomOperation("DisableToolbar")>] member this.DisableToolbar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableToolbar" => x |> this.AddAttr
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Orientation) = "Orientation" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
                

type MudSpacerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = MudSpacerBuilder<'FunBlazorGeneric>().CreateNode()

                

type MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = MudTreeViewItemToggleButtonBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> this.AddAttr
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> this.AddAttr
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.Boolean>) = this.AddBinding("Expanded", value)
    [<CustomOperation("Expanded'")>] member this.Expanded' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.Boolean * (System.Boolean -> unit)) = this.AddBinding("Expanded", valueFn)
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> this.AddAttr
    [<CustomOperation("ExpandedChanged")>] member this.ExpandedChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ExpandedChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("LoadingIcon")>] member this.LoadingIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "LoadingIcon" => x |> this.AddAttr
    [<CustomOperation("LoadingIconColor")>] member this.LoadingIconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "LoadingIconColor" => x |> this.AddAttr
    [<CustomOperation("ExpandedIcon")>] member this.ExpandedIcon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ExpandedIcon" => x |> this.AddAttr
    [<CustomOperation("ExpandedIconColor")>] member this.ExpandedIconColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "ExpandedIconColor" => x |> this.AddAttr
                

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = _ImportsBuilder<'FunBlazorGeneric>().CreateNode()

                
            
namespace rec MudBlazor.DslInternals.Internal

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type MudInputAdornmentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = MudInputAdornmentBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddAttr
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Text" => x |> this.AddAttr
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> this.AddAttr
    [<CustomOperation("Edge")>] member this.Edge (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Edge) = "Edge" => x |> this.AddAttr
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Size) = "Size" => x |> this.AddAttr
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorBuilder<'FunBlazorGeneric>, x: MudBlazor.Color) = "Color" => x |> this.AddAttr
    [<CustomOperation("AdornmentClick")>] member this.AdornmentClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AdornmentClick" (fun e -> fn e)) |> this.AddAttr
                
            
namespace rec MudBlazor.DslInternals.Charts

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open MudBlazor.DslInternals


type FiltersBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = FiltersBuilder<'FunBlazorGeneric>().CreateNode()

                
            

// =======================================================================================================================

namespace MudBlazor

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals

    type MudBaseColumn'() = inherit MudBaseColumnBuilder<MudBlazor.MudBaseColumn>()
    type MudColumn'<'T>() = inherit MudColumnBuilder<MudBlazor.MudColumn<'T>, 'T>()
    type MudSortableColumn'<'T, 'ModelType>() = inherit MudSortableColumnBuilder<MudBlazor.MudSortableColumn<'T, 'ModelType>, 'T, 'ModelType>()
    type MudAvatarColumn'<'T>() = inherit MudAvatarColumnBuilder<MudBlazor.MudAvatarColumn<'T>, 'T>()
    type MudTemplateColumn'<'T>() = inherit MudTemplateColumnBuilder<MudBlazor.MudTemplateColumn<'T>, 'T>()
    type MudComponentBase'() = inherit MudComponentBaseBuilder<MudBlazor.MudComponentBase>()
    type MudBaseButton'() = inherit MudBaseButtonBuilder<MudBlazor.MudBaseButton>()
    type MudButton'() = inherit MudButtonBuilder<MudBlazor.MudButton>()
    type MudFab'() = inherit MudFabBuilder<MudBlazor.MudFab>()
    type MudIconButton'() = inherit MudIconButtonBuilder<MudBlazor.MudIconButton>()
    type MudFileUploader'() = inherit MudFileUploaderBuilder<MudBlazor.MudFileUploader>()
    type MudBaseItemsControl'<'TChildComponent when 'TChildComponent :> MudBlazor.MudComponentBase>() = inherit MudBaseItemsControlBuilder<MudBlazor.MudBaseItemsControl<'TChildComponent>, 'TChildComponent>()
    type MudBaseBindableItemsControl'<'TChildComponent, 'TData when 'TChildComponent :> MudBlazor.MudComponentBase>() = inherit MudBaseBindableItemsControlBuilder<MudBlazor.MudBaseBindableItemsControl<'TChildComponent, 'TData>, 'TChildComponent, 'TData>()
    type MudCarousel'<'TData>() = inherit MudCarouselBuilder<MudBlazor.MudCarousel<'TData>, 'TData>()
    type MudTimeline'() = inherit MudTimelineBuilder<MudBlazor.MudTimeline>()
    type MudBaseSelectItem'() = inherit MudBaseSelectItemBuilder<MudBlazor.MudBaseSelectItem>()
    type MudNavLink'() = inherit MudNavLinkBuilder<MudBlazor.MudNavLink>()
    type MudSelectItem'<'T>() = inherit MudSelectItemBuilder<MudBlazor.MudSelectItem<'T>, 'T>()
    type MudFormComponent'<'T, 'U>() = inherit MudFormComponentBuilder<MudBlazor.MudFormComponent<'T, 'U>, 'T, 'U>()
    type MudBaseInput'<'T>() = inherit MudBaseInputBuilder<MudBlazor.MudBaseInput<'T>, 'T>()
    type MudAutocomplete'<'T>() = inherit MudAutocompleteBuilder<MudBlazor.MudAutocomplete<'T>, 'T>()
    type MudDebouncedInput'<'T>() = inherit MudDebouncedInputBuilder<MudBlazor.MudDebouncedInput<'T>, 'T>()
    type MudNumericField'<'T>() = inherit MudNumericFieldBuilder<MudBlazor.MudNumericField<'T>, 'T>()
    type MudTextField'<'T>() = inherit MudTextFieldBuilder<MudBlazor.MudTextField<'T>, 'T>()
    type MudInput'<'T>() = inherit MudInputBuilder<MudBlazor.MudInput<'T>, 'T>()
    type MudInputString'() = inherit MudInputStringBuilder<MudBlazor.MudInputString>()
    type MudRangeInput'<'T>() = inherit MudRangeInputBuilder<MudBlazor.MudRangeInput<'T>, 'T>()
    type MudSelect'<'T>() = inherit MudSelectBuilder<MudBlazor.MudSelect<'T>, 'T>()
    type MudBooleanInput'<'T>() = inherit MudBooleanInputBuilder<MudBlazor.MudBooleanInput<'T>, 'T>()
    type MudCheckBox'<'T>() = inherit MudCheckBoxBuilder<MudBlazor.MudCheckBox<'T>, 'T>()
    type MudSwitch'<'T>() = inherit MudSwitchBuilder<MudBlazor.MudSwitch<'T>, 'T>()
    type MudPicker'<'T>() = inherit MudPickerBuilder<MudBlazor.MudPicker<'T>, 'T>()
    type MudColorPicker'() = inherit MudColorPickerBuilder<MudBlazor.MudColorPicker>()
    type MudBaseDatePicker'() = inherit MudBaseDatePickerBuilder<MudBlazor.MudBaseDatePicker>()
    type MudDatePicker'() = inherit MudDatePickerBuilder<MudBlazor.MudDatePicker>()
    type MudDateRangePicker'() = inherit MudDateRangePickerBuilder<MudBlazor.MudDateRangePicker>()
    type MudTimePicker'() = inherit MudTimePickerBuilder<MudBlazor.MudTimePicker>()
    type MudRadioGroup'<'T>() = inherit MudRadioGroupBuilder<MudBlazor.MudRadioGroup<'T>, 'T>()
    type MudAlert'() = inherit MudAlertBuilder<MudBlazor.MudAlert>()
    type MudAppBar'() = inherit MudAppBarBuilder<MudBlazor.MudAppBar>()
    type MudAvatar'() = inherit MudAvatarBuilder<MudBlazor.MudAvatar>()
    type MudAvatarGroup'() = inherit MudAvatarGroupBuilder<MudBlazor.MudAvatarGroup>()
    type MudBadge'() = inherit MudBadgeBuilder<MudBlazor.MudBadge>()
    type MudBreadcrumbs'() = inherit MudBreadcrumbsBuilder<MudBlazor.MudBreadcrumbs>()
    type MudBreakpointProvider'() = inherit MudBreakpointProviderBuilder<MudBlazor.MudBreakpointProvider>()
    type MudButtonGroup'() = inherit MudButtonGroupBuilder<MudBlazor.MudButtonGroup>()
    type MudToggleIconButton'() = inherit MudToggleIconButtonBuilder<MudBlazor.MudToggleIconButton>()
    type MudCard'() = inherit MudCardBuilder<MudBlazor.MudCard>()
    type MudCardActions'() = inherit MudCardActionsBuilder<MudBlazor.MudCardActions>()
    type MudCardContent'() = inherit MudCardContentBuilder<MudBlazor.MudCardContent>()
    type MudCardHeader'() = inherit MudCardHeaderBuilder<MudBlazor.MudCardHeader>()
    type MudCardMedia'() = inherit MudCardMediaBuilder<MudBlazor.MudCardMedia>()
    type MudCarouselItem'() = inherit MudCarouselItemBuilder<MudBlazor.MudCarouselItem>()
    type MudChartBase'() = inherit MudChartBaseBuilder<MudBlazor.MudChartBase>()
    type MudChart'() = inherit MudChartBuilder<MudBlazor.MudChart>()
    type MudChipSet'() = inherit MudChipSetBuilder<MudBlazor.MudChipSet>()
    type MudChip'() = inherit MudChipBuilder<MudBlazor.MudChip>()
    type MudCollapse'() = inherit MudCollapseBuilder<MudBlazor.MudCollapse>()
    type Cell'<'T>() = inherit CellBuilder<MudBlazor.Cell<'T>, 'T>()
    type Column'<'T>() = inherit ColumnBuilder<MudBlazor.Column<'T>, 'T>()
    type FooterCell'<'T>() = inherit FooterCellBuilder<MudBlazor.FooterCell<'T>, 'T>()
    type HeaderCell'<'T>() = inherit HeaderCellBuilder<MudBlazor.HeaderCell<'T>, 'T>()
    type MudDataGrid'<'T>() = inherit MudDataGridBuilder<MudBlazor.MudDataGrid<'T>, 'T>()
    type MudDataGridPager'<'T>() = inherit MudDataGridPagerBuilder<MudBlazor.MudDataGridPager<'T>, 'T>()
    type Row'() = inherit RowBuilder<MudBlazor.Row>()
    type MudDialog'() = inherit MudDialogBuilder<MudBlazor.MudDialog>()
    type MudDialogInstance'() = inherit MudDialogInstanceBuilder<MudBlazor.MudDialogInstance>()
    type MudDrawer'() = inherit MudDrawerBuilder<MudBlazor.MudDrawer>()
    type MudDrawerContainer'() = inherit MudDrawerContainerBuilder<MudBlazor.MudDrawerContainer>()
    type MudLayout'() = inherit MudLayoutBuilder<MudBlazor.MudLayout>()
    type MudElement'() = inherit MudElementBuilder<MudBlazor.MudElement>()
    type MudExpansionPanel'() = inherit MudExpansionPanelBuilder<MudBlazor.MudExpansionPanel>()
    type MudExpansionPanels'() = inherit MudExpansionPanelsBuilder<MudBlazor.MudExpansionPanels>()
    type MudField'() = inherit MudFieldBuilder<MudBlazor.MudField>()
    type MudFocusTrap'() = inherit MudFocusTrapBuilder<MudBlazor.MudFocusTrap>()
    type MudForm'() = inherit MudFormBuilder<MudBlazor.MudForm>()
    type MudHidden'() = inherit MudHiddenBuilder<MudBlazor.MudHidden>()
    type MudIcon'() = inherit MudIconBuilder<MudBlazor.MudIcon>()
    type MudInputControl'() = inherit MudInputControlBuilder<MudBlazor.MudInputControl>()
    type MudInputLabel'() = inherit MudInputLabelBuilder<MudBlazor.MudInputLabel>()
    type MudLink'() = inherit MudLinkBuilder<MudBlazor.MudLink>()
    type MudList'() = inherit MudListBuilder<MudBlazor.MudList>()
    type MudListItem'() = inherit MudListItemBuilder<MudBlazor.MudListItem>()
    type MudListSubheader'() = inherit MudListSubheaderBuilder<MudBlazor.MudListSubheader>()
    type MudMenu'() = inherit MudMenuBuilder<MudBlazor.MudMenu>()
    type MudMenuItem'() = inherit MudMenuItemBuilder<MudBlazor.MudMenuItem>()
    type MudMessageBox'() = inherit MudMessageBoxBuilder<MudBlazor.MudMessageBox>()
    type MudNavGroup'() = inherit MudNavGroupBuilder<MudBlazor.MudNavGroup>()
    type MudNavMenu'() = inherit MudNavMenuBuilder<MudBlazor.MudNavMenu>()
    type MudOverlay'() = inherit MudOverlayBuilder<MudBlazor.MudOverlay>()
    type MudPageContentNavigation'() = inherit MudPageContentNavigationBuilder<MudBlazor.MudPageContentNavigation>()
    type MudPagination'() = inherit MudPaginationBuilder<MudBlazor.MudPagination>()
    type MudPopover'() = inherit MudPopoverBuilder<MudBlazor.MudPopover>()
    type MudProgressCircular'() = inherit MudProgressCircularBuilder<MudBlazor.MudProgressCircular>()
    type MudProgressLinear'() = inherit MudProgressLinearBuilder<MudBlazor.MudProgressLinear>()
    type MudRadio'<'T>() = inherit MudRadioBuilder<MudBlazor.MudRadio<'T>, 'T>()
    type MudRating'() = inherit MudRatingBuilder<MudBlazor.MudRating>()
    type MudRatingItem'() = inherit MudRatingItemBuilder<MudBlazor.MudRatingItem>()
    type MudRTLProvider'() = inherit MudRTLProviderBuilder<MudBlazor.MudRTLProvider>()
    type MudScrollToTop'() = inherit MudScrollToTopBuilder<MudBlazor.MudScrollToTop>()
    type MudSkeleton'() = inherit MudSkeletonBuilder<MudBlazor.MudSkeleton>()
    type MudSlider'<'T>() = inherit MudSliderBuilder<MudBlazor.MudSlider<'T>, 'T>()
    type MudSnackbarElement'() = inherit MudSnackbarElementBuilder<MudBlazor.MudSnackbarElement>()
    type MudSnackbarProvider'() = inherit MudSnackbarProviderBuilder<MudBlazor.MudSnackbarProvider>()
    type MudSwipeArea'() = inherit MudSwipeAreaBuilder<MudBlazor.MudSwipeArea>()
    type MudSimpleTable'() = inherit MudSimpleTableBuilder<MudBlazor.MudSimpleTable>()
    type MudTableBase'() = inherit MudTableBaseBuilder<MudBlazor.MudTableBase>()
    type MudTable'<'T>() = inherit MudTableBuilder<MudBlazor.MudTable<'T>, 'T>()
    type MudTableGroupRow'<'T>() = inherit MudTableGroupRowBuilder<MudBlazor.MudTableGroupRow<'T>, 'T>()
    type MudTablePager'() = inherit MudTablePagerBuilder<MudBlazor.MudTablePager>()
    type MudTableSortLabel'<'T>() = inherit MudTableSortLabelBuilder<MudBlazor.MudTableSortLabel<'T>, 'T>()
    type MudTd'() = inherit MudTdBuilder<MudBlazor.MudTd>()
    type MudTFootRow'() = inherit MudTFootRowBuilder<MudBlazor.MudTFootRow>()
    type MudTh'() = inherit MudThBuilder<MudBlazor.MudTh>()
    type MudTHeadRow'() = inherit MudTHeadRowBuilder<MudBlazor.MudTHeadRow>()
    type MudTr'() = inherit MudTrBuilder<MudBlazor.MudTr>()
    type MudTabs'() = inherit MudTabsBuilder<MudBlazor.MudTabs>()
    type MudDynamicTabs'() = inherit MudDynamicTabsBuilder<MudBlazor.MudDynamicTabs>()
    type MudTimelineItem'() = inherit MudTimelineItemBuilder<MudBlazor.MudTimelineItem>()
    type MudTooltip'() = inherit MudTooltipBuilder<MudBlazor.MudTooltip>()
    type MudTreeView'<'T>() = inherit MudTreeViewBuilder<MudBlazor.MudTreeView<'T>, 'T>()
    type MudTreeViewItem'<'T>() = inherit MudTreeViewItemBuilder<MudBlazor.MudTreeViewItem<'T>, 'T>()
    type MudText'() = inherit MudTextBuilder<MudBlazor.MudText>()
    type MudContainer'() = inherit MudContainerBuilder<MudBlazor.MudContainer>()
    type MudDivider'() = inherit MudDividerBuilder<MudBlazor.MudDivider>()
    type MudDrawerHeader'() = inherit MudDrawerHeaderBuilder<MudBlazor.MudDrawerHeader>()
    type MudGrid'() = inherit MudGridBuilder<MudBlazor.MudGrid>()
    type MudItem'() = inherit MudItemBuilder<MudBlazor.MudItem>()
    type MudHighlighter'() = inherit MudHighlighterBuilder<MudBlazor.MudHighlighter>()
    type MudMainContent'() = inherit MudMainContentBuilder<MudBlazor.MudMainContent>()
    type MudPaper'() = inherit MudPaperBuilder<MudBlazor.MudPaper>()
    type MudSparkLine'() = inherit MudSparkLineBuilder<MudBlazor.MudSparkLine>()
    type MudTabPanel'() = inherit MudTabPanelBuilder<MudBlazor.MudTabPanel>()
    type MudToolBar'() = inherit MudToolBarBuilder<MudBlazor.MudToolBar>()
    type Filter'<'T>() = inherit FilterBuilder<MudBlazor.Filter<'T>, 'T>()
    type MudDialogProvider'() = inherit MudDialogProviderBuilder<MudBlazor.MudDialogProvider>()
    type MudPopoverProvider'() = inherit MudPopoverProviderBuilder<MudBlazor.MudPopoverProvider>()
    type BaseMudThemeProvider'() = inherit BaseMudThemeProviderBuilder<MudBlazor.BaseMudThemeProvider>()
    type MudThemeProvider'() = inherit MudThemeProviderBuilder<MudBlazor.MudThemeProvider>()
    type MudVirtualize'<'T>() = inherit MudVirtualizeBuilder<MudBlazor.MudVirtualize<'T>, 'T>()
    type BreadcrumbLink'() = inherit BreadcrumbLinkBuilder<MudBlazor.BreadcrumbLink>()
    type BreadcrumbSeparator'() = inherit BreadcrumbSeparatorBuilder<MudBlazor.BreadcrumbSeparator>()
    type MudPickerContent'() = inherit MudPickerContentBuilder<MudBlazor.MudPickerContent>()
    type MudPickerToolbar'() = inherit MudPickerToolbarBuilder<MudBlazor.MudPickerToolbar>()
    type MudSpacer'() = inherit MudSpacerBuilder<MudBlazor.MudSpacer>()
    type MudTreeViewItemToggleButton'() = inherit MudTreeViewItemToggleButtonBuilder<MudBlazor.MudTreeViewItemToggleButton>()
    type _Imports'() = inherit _ImportsBuilder<MudBlazor._Imports>()
            
namespace MudBlazor.Charts

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Charts

    type Bar'() = inherit BarBuilder<MudBlazor.Charts.Bar>()
    type Donut'() = inherit DonutBuilder<MudBlazor.Charts.Donut>()
    type Line'() = inherit LineBuilder<MudBlazor.Charts.Line>()
    type Pie'() = inherit PieBuilder<MudBlazor.Charts.Pie>()
    type Legend'() = inherit LegendBuilder<MudBlazor.Charts.Legend>()
    type Filters'() = inherit FiltersBuilder<MudBlazor.Charts.Filters>()
            
namespace MudBlazor.Internal

[<AutoOpen>]
module DslCE =

    open MudBlazor.DslInternals.Internal

    type MudInputAdornment'() = inherit MudInputAdornmentBuilder<MudBlazor.Internal.MudInputAdornment>()
            