namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type AntComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = AntComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ConfigProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ConfigProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ConfigProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ConfigProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ConfigProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type AntDomComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntDomComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<'FunBlazorGeneric>, x: (string * string) list) = attr.styles x |> this.AddProp
                

type AffixBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AffixBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AffixBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AffixBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AffixBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("OffsetBottom")>] member this.OffsetBottom (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "OffsetBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetTop")>] member this.OffsetTop (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "OffsetTop" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TargetSelector")>] member this.TargetSelector (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TargetSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type AlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("AfterClose")>] member this.AfterClose (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AfterClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Banner")>] member this.Banner (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Banner" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseText")>] member this.CloseText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CloseText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Icon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Message")>] member this.Message (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageTemplate")>] member this.MessageTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "MessageTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageTemplate")>] member this.MessageTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageTemplate")>] member this.MessageTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageTemplate")>] member this.MessageTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowIcon")>] member this.ShowIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Boolean>) = "ShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type AnchorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AnchorBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AnchorBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AnchorBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AnchorBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Affix")>] member this.Affix (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Affix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bounds")>] member this.Bounds (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Bounds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetContainer")>] member this.GetContainer (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.String>) = "GetContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetBottom")>] member this.OffsetBottom (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "OffsetBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetTop")>] member this.OffsetTop (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "OffsetTop" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowInkInFixed")>] member this.ShowInkInFixed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowInkInFixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetCurrentAnchor")>] member this.GetCurrentAnchor (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.String>) = "GetCurrentAnchor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TargetOffset")>] member this.TargetOffset (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "TargetOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type AnchorLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AnchorLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AnchorLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AnchorLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AnchorLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteOptGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelFragment")>] member this.LabelFragment (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "LabelFragment" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelFragment")>] member this.LabelFragment (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelFragment")>] member this.LabelFragment (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelFragment")>] member this.LabelFragment (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type AutoCompleteOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AutoCompleteOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoComplete")>] member this.AutoComplete (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.IAutoCompleteRef) = "AutoComplete" => x |> BoleroAttr |> this.AddProp
                

type AvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Shape")>] member this.Shape (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Src")>] member this.Src (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Src" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SrcSet")>] member this.SrcSet (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "SrcSet" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Alt")>] member this.Alt (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Alt" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnError")>] member this.OnError (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.ErrorEventArgs> "OnError" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type AvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AvatarGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AvatarGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AvatarGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AvatarGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxCount")>] member this.MaxCount (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MaxCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxStyle")>] member this.MaxStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MaxStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxPopoverPlacement")>] member this.MaxPopoverPlacement (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.PlacementType) = "MaxPopoverPlacement" => x |> BoleroAttr |> this.AddProp
                

type BackTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BackTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BackTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BackTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BackTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("VisibilityHeight")>] member this.VisibilityHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "VisibilityHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TargetSelector")>] member this.TargetSelector (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TargetSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
                

type BadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Count")>] member this.Count (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "Count" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CountTemplate")>] member this.CountTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CountTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CountTemplate")>] member this.CountTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CountTemplate")>] member this.CountTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CountTemplate")>] member this.CountTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Offset")>] member this.Offset (_: FunBlazorContext<'FunBlazorGeneric>, x: System.ValueTuple<System.Int32, System.Int32>) = "Offset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverflowCount")>] member this.OverflowCount (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "OverflowCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowZero")>] member this.ShowZero (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowZero" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type BadgeRibbonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BadgeRibbonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BadgeRibbonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BadgeRibbonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BadgeRibbonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTemplate")>] member this.TextTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TextTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTemplate")>] member this.TextTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTemplate")>] member this.TextTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTemplate")>] member this.TextTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type BreadcrumbBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BreadcrumbBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BreadcrumbBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BreadcrumbBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BreadcrumbBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoGenerate")>] member this.AutoGenerate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoGenerate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Separator")>] member this.Separator (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Separator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RouteLabel")>] member this.RouteLabel (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RouteLabel" => x |> BoleroAttr |> this.AddProp
                

type ButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Block")>] member this.Block (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Block" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Danger")>] member this.Danger (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Danger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ghost")>] member this.Ghost (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HtmlType")>] member this.HtmlType (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HtmlType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClickStopPropagation")>] member this.OnClickStopPropagation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Shape")>] member this.Shape (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
                

type ButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
                

type CalendarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CalendarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: System.DateTime) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.DateTime) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValidRange")>] member this.ValidRange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.DateTime[]) = "ValidRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullScreen")>] member this.FullScreen (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FullScreen" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.DateTime> "OnSelect" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.DateTime> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderRender")>] member this.HeaderRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>) = "HeaderRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateCellRender")>] member this.DateCellRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateFullCellRender")>] member this.DateFullCellRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateFullCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthFullCellRender")>] member this.MonthFullCellRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthFullCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.DateTime, System.String>) = "OnPanelChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
                

type CardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Body")>] member this.Body (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Body" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Body")>] member this.Body (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Body")>] member this.Body (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Body")>] member this.Body (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActionTemplate")>] member this.ActionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ActionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActionTemplate")>] member this.ActionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActionTemplate")>] member this.ActionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActionTemplate")>] member this.ActionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hoverable")>] member this.Hoverable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BodyStyle")>] member this.BodyStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Cover")>] member this.Cover (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Cover" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Cover")>] member this.Cover (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Cover")>] member this.Cover (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Cover")>] member this.Cover (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Actions")>] member this.Actions (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardTabs")>] member this.CardTabs (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CardTabs" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardTabs")>] member this.CardTabs (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardTabs")>] member this.CardTabs (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardTabs")>] member this.CardTabs (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type CardActionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CardActionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardActionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardActionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardActionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type CardGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CardGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hoverable")>] member this.Hoverable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> this.AddProp
                

type CarouselBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CarouselBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CarouselBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DotPosition")>] member this.DotPosition (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DotPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Autoplay")>] member this.Autoplay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.TimeSpan) = "Autoplay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Effect")>] member this.Effect (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Effect" => x |> BoleroAttr |> this.AddProp
                

type CarouselSlickBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CarouselSlickBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CarouselSlickBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CarouselSlickBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CarouselSlickBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type CollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Accordion")>] member this.Accordion (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Accordion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIconPosition")>] member this.ExpandIconPosition (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ExpandIconPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveKey")>] member this.DefaultActiveKey (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "DefaultActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIcon")>] member this.ExpandIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ExpandIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIconTemplate")>] member this.ExpandIconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: System.Boolean -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ExpandIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type PanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = PanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = PanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = PanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = PanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Active")>] member this.Active (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowArrow")>] member this.ShowArrow (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowArrow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Extra" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExtraTemplate")>] member this.ExtraTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ExtraTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExtraTemplate")>] member this.ExtraTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExtraTemplate")>] member this.ExtraTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExtraTemplate")>] member this.ExtraTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Header" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "HeaderTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnActiveChange")>] member this.OnActiveChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type CommentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CommentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CommentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CommentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CommentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Author")>] member this.Author (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Author" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AuthorTemplate")>] member this.AuthorTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "AuthorTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AuthorTemplate")>] member this.AuthorTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AuthorTemplate")>] member this.AuthorTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AuthorTemplate")>] member this.AuthorTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Datetime")>] member this.Datetime (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Datetime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DatetimeTemplate")>] member this.DatetimeTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DatetimeTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DatetimeTemplate")>] member this.DatetimeTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DatetimeTemplate")>] member this.DatetimeTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DatetimeTemplate")>] member this.DatetimeTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Actions")>] member this.Actions (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> this.AddProp
                

type AntContainerComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AntContainerComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AntContainerComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AntContainerComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AntContainerComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Tag" => x |> BoleroAttr |> this.AddProp
                

type AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteBuilder<'FunBlazorGeneric, 'TOption when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, System.String>()
    new (x: string) as this = AutoCompleteBuilder<'FunBlazorGeneric, 'TOption>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteBuilder<'FunBlazorGeneric, 'TOption>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteBuilder<'FunBlazorGeneric, 'TOption>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteBuilder<'FunBlazorGeneric, 'TOption>(x) :> IFunBlazorNode
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveFirstOption")>] member this.DefaultActiveFirstOption (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Backfill")>] member this.Backfill (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Backfill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TOption>) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OptionDataItems")>] member this.OptionDataItems (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionDataItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectionChange")>] member this.OnSelectionChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnSelectionChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnActiveChange")>] member this.OnActiveChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelVisibleChange")>] member this.OnPanelVisibleChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnPanelVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OptionTemplate")>] member this.OptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.AutoCompleteDataItem<'TOption> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "OptionTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OptionFormat")>] member this.OptionFormat (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>) = "OptionFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayTemplate")>] member this.OverlayTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "OverlayTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayTemplate")>] member this.OverlayTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayTemplate")>] member this.OverlayTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayTemplate")>] member this.OverlayTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CompareWith")>] member this.CompareWith (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Object, System.Object, System.Boolean>) = "CompareWith" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FilterExpression")>] member this.FilterExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>) = "FilterExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowFilter")>] member this.AllowFilter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowFilter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.AutoCompleteOption) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPanel")>] member this.ShowPanel (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowPanel" => x |> BoleroAttr |> this.AddProp
                

type CascaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, System.String>()
    static member create () = CascaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeOnSelect")>] member this.ChangeOnSelect (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ChangeOnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandTrigger")>] member this.ExpandTrigger (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ExpandTrigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "NotFoundContent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSearch")>] member this.ShowSearch (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.Collections.Generic.List<AntDesign.CascaderNode>, System.String, System.String>) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedNodesChanged")>] member this.SelectedNodesChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.CascaderNode[]> "SelectedNodesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = "Options" => x |> BoleroAttr |> this.AddProp
                

type CheckboxGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, System.String[]>()
    new (x: string) as this = CheckboxGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CheckboxGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CheckboxGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CheckboxGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<AntDesign.CheckboxOption[], System.String[]>) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MixedMode")>] member this.MixedMode (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.CheckboxGroupMixedMode) = "MixedMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                

type AntInputBoolComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, System.Boolean>()
    static member create () = AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                

type CheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CheckboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CheckboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CheckboxBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CheckboxBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChange")>] member this.CheckedChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedExpression")>] member this.CheckedExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "CheckedExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
                

type SwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SwitchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildren")>] member this.CheckedChildren (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CheckedChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildrenTemplate")>] member this.CheckedChildrenTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildrenTemplate")>] member this.CheckedChildrenTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildrenTemplate")>] member this.CheckedChildrenTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildrenTemplate")>] member this.CheckedChildrenTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Control")>] member this.Control (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Control" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildren")>] member this.UnCheckedChildren (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "UnCheckedChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildrenTemplate")>] member this.UnCheckedChildrenTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildrenTemplate")>] member this.UnCheckedChildrenTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildrenTemplate")>] member this.UnCheckedChildrenTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildrenTemplate")>] member this.UnCheckedChildrenTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type DatePickerBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerBaseBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
                

type DatePickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MonthPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = MonthPickerBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type QuarterPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = QuarterPickerBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type WeekPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = WeekPickerBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type YearPickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = YearPickerBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type TimePickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = TimePickerBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type RangePickerBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = RangePickerBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.DateRangeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type InputNumberBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = InputNumberBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("Formatter")>] member this.Formatter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<'TValue, System.String>) = "Formatter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Parser")>] member this.Parser (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.String, System.String>) = "Parser" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type InputBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = InputBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceMilliseconds")>] member this.DebounceMilliseconds (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputElementSuffixClass")>] member this.InputElementSuffixClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxLength")>] member this.MaxLength (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyDown")>] member this.OnkeyDown (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyUp")>] member this.OnkeyUp (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseUp")>] member this.OnMouseUp (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPressEnter")>] member this.OnPressEnter (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperStyle")>] member this.WrapperStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteInputBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = AutoCompleteInputBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type InputPasswordBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBuilder<'FunBlazorGeneric, System.String>()
    static member create () = InputPasswordBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("IconRender")>] member this.IconRender (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "IconRender" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconRender")>] member this.IconRender (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconRender")>] member this.IconRender (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconRender")>] member this.IconRender (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPassword")>] member this.ShowPassword (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowPassword" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("VisibilityToggle")>] member this.VisibilityToggle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "VisibilityToggle" => x |> BoleroAttr |> this.AddProp
                

type SearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBuilder<'FunBlazorGeneric, System.String>()
    static member create () = SearchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("ClassicSearchIcon")>] member this.ClassicSearchIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EnterButton")>] member this.EnterButton (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type AutoCompleteSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SearchBuilder<'FunBlazorGeneric>()
    static member create () = AutoCompleteSearchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit InputBuilder<'FunBlazorGeneric, System.String>()
    static member create () = TextAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("AutoSize")>] member this.AutoSize (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultToEmptyString")>] member this.DefaultToEmptyString (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DefaultToEmptyString" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxRows")>] member this.MaxRows (_: FunBlazorContext<'FunBlazorGeneric>, x: System.UInt32) = "MaxRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinRows")>] member this.MinRows (_: FunBlazorContext<'FunBlazorGeneric>, x: System.UInt32) = "MinRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnResize")>] member this.OnResize (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.OnResizeEventArgs> "OnResize" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowCount")>] member this.ShowCount (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowCount" => x |> BoleroAttr |> this.AddProp
                

type RadioGroupBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    new (x: string) as this = RadioGroupBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RadioGroupBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RadioGroupBuilder<'FunBlazorGeneric, 'TValue>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RadioGroupBuilder<'FunBlazorGeneric, 'TValue>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonStyle")>] member this.ButtonStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ButtonStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type SelectBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TItemValue>()
    static member create () = SelectBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoClearSearchValue")>] member this.AutoClearSearchValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateCustomTag")>] member this.OnCreateCustomTag (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveFirstOption")>] member this.DefaultActiveFirstOption (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledName")>] member this.DisabledName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DisabledName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownRender")>] member this.DropdownRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EnableSearch")>] member this.EnableSearch (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GroupName")>] member this.GroupName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "GroupName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSelected")>] member this.HideSelected (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreItemChanges")>] member this.IgnoreItemChanges (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelInValue")>] member this.LabelInValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelName")>] member this.LabelName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "LabelName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagTextLength")>] member this.MaxTagTextLength (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagCount")>] member this.MaxTagCount (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagPlaceholder")>] member this.MaxTagPlaceholder (_: FunBlazorContext<'FunBlazorGeneric>, render: System.Collections.Generic.IEnumerable<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "MaxTagPlaceholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NotFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnBlur" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearSelected")>] member this.OnClearSelected (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDataSourceChanged")>] member this.OnDataSourceChanged (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDropdownVisibleChange")>] member this.OnDropdownVisibleChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectedItemChanged")>] member this.OnSelectedItemChanged (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<'TItem>) = "OnSelectedItemChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectedItemsChanged")>] member this.OnSelectedItemsChanged (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.Collections.Generic.IEnumerable<'TItem>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerMaxHeight")>] member this.PopupContainerMaxHeight (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownMatchSelectWidth")>] member this.DropdownMatchSelectWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownMaxWidth")>] member this.DropdownMaxWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowArrowIcon")>] member this.ShowArrowIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSearchIcon")>] member this.ShowSearchIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortByGroup")>] member this.SortByGroup (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortByLabel")>] member this.SortByLabel (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PrefixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TokenSeparators")>] member this.TokenSeparators (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Char[]) = "TokenSeparators" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TItemValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueName")>] member this.ValueName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ValueName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesChanged")>] member this.ValuesChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItemValue>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomTagLabelToValue")>] member this.CustomTagLabelToValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.String, 'TItemValue>) = "CustomTagLabelToValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TItemValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TItemValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Values")>] member this.Values (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TItemValue>) = "Values" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValues")>] member this.DefaultValues (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TItemValue>) = "DefaultValues" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SelectOptions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type SimpleSelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SelectBuilder<'FunBlazorGeneric, System.String, System.String>()
    static member create () = SimpleSelectBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type SliderBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = SliderBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dots")>] member this.Dots (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dots" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Included")>] member this.Included (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Included" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Marks")>] member this.Marks (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.SliderMark[]) = "Marks" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Reverse")>] member this.Reverse (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Reverse" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Double>) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Vertical")>] member this.Vertical (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Vertical" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAfterChange")>] member this.OnAfterChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<'TValue>) = "OnAfterChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<'TValue>) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HasTooltip")>] member this.HasTooltip (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HasTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TipFormatter")>] member this.TipFormatter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Double, System.String>) = "TipFormatter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipPlacement")>] member this.TooltipPlacement (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.PlacementType) = "TooltipPlacement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipVisible")>] member this.TooltipVisible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "TooltipVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetTooltipPopupContainer")>] member this.GetTooltipPopupContainer (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "GetTooltipPopupContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
                

type DescriptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DescriptionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DescriptionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DescriptionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DescriptionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Layout")>] member this.Layout (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Layout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Column")>] member this.Column (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>) = "Column" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Colon")>] member this.Colon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Colon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type DescriptionsItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DescriptionsItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DescriptionsItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DescriptionsItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DescriptionsItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Span")>] member this.Span (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Span" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type DividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DividerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DividerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DividerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DividerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Plain")>] member this.Plain (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Plain" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.DirectionVHType) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dashed")>] member this.Dashed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Dashed" => x |> BoleroAttr |> this.AddProp
                

type DrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaskClosable")>] member this.MaskClosable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mask")>] member this.Mask (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Mask" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoAnimation")>] member this.NoAnimation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "NoAnimation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaskStyle")>] member this.MaskStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MaskStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BodyStyle")>] member this.BodyStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapClassName")>] member this.WrapClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "WrapClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ZIndex")>] member this.ZIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Handler")>] member this.Handler (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Handler" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Handler")>] member this.Handler (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Handler")>] member this.Handler (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Handler")>] member this.Handler (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type DrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DrawerContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type EmptyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = EmptyBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = EmptyBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = EmptyBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = EmptyBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageStyle")>] member this.ImageStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ImageStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Small")>] member this.Small (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Small" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Simple")>] member this.Simple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Simple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Image")>] member this.Image (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageTemplate")>] member this.ImageTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ImageTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageTemplate")>] member this.ImageTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageTemplate")>] member this.ImageTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageTemplate")>] member this.ImageTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type FormBuilder<'FunBlazorGeneric, 'TModel when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = FormBuilder<'FunBlazorGeneric, 'TModel>() :> IFunBlazorNode
    [<CustomOperation("Layout")>] member this.Layout (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Layout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TModel -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelCol")>] member this.LabelCol (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelAlign")>] member this.LabelAlign (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelColSpan")>] member this.LabelColSpan (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelColOffset")>] member this.LabelColOffset (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperCol")>] member this.WrapperCol (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperColSpan")>] member this.WrapperColSpan (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperColOffset")>] member this.WrapperColOffset (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Model")>] member this.Model (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TModel) = "Model" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFinish")>] member this.OnFinish (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinish" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFinishFailed")>] member this.OnFinishFailed (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinishFailed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validator")>] member this.Validator (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Validator" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validator")>] member this.Validator (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validator")>] member this.Validator (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validator")>] member this.Validator (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValidateOnChange")>] member this.ValidateOnChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ValidateOnChange" => x |> BoleroAttr |> this.AddProp
                

type FormItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = FormItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FormItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FormItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FormItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "LabelTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelCol")>] member this.LabelCol (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelAlign")>] member this.LabelAlign (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelColSpan")>] member this.LabelColSpan (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelColOffset")>] member this.LabelColOffset (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperCol")>] member this.WrapperCol (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperColSpan")>] member this.WrapperColSpan (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperColOffset")>] member this.WrapperColOffset (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoStyle")>] member this.NoStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "NoStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
                

type ColBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Flex")>] member this.Flex (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Span")>] member this.Span (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Order")>] member this.Order (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Offset")>] member this.Offset (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Push")>] member this.Push (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Pull")>] member this.Pull (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xs")>] member this.Xs (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Sm")>] member this.Sm (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Md")>] member this.Md (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lg")>] member this.Lg (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xl")>] member this.Xl (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xxl")>] member this.Xxl (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> this.AddProp
                

type GridColBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColBuilder<'FunBlazorGeneric>()
    static member create () = GridColBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type RowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = RowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Align")>] member this.Align (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Justify")>] member this.Justify (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Justify" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Wrap")>] member this.Wrap (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Wrap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Gutter")>] member this.Gutter (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Collections.Generic.Dictionary<System.String, System.Int32>>>) = "Gutter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBreakpoint")>] member this.OnBreakpoint (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.BreakpointType> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultBreakpoint")>] member this.DefaultBreakpoint (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.BreakpointType) = "DefaultBreakpoint" => x |> BoleroAttr |> this.AddProp
                

type IconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = IconBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Spin")>] member this.Spin (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Spin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rotate")>] member this.Rotate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Rotate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TwotoneColor")>] member this.TwotoneColor (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TwotoneColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconFont")>] member this.IconFont (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "IconFont" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fill")>] member this.Fill (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Fill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabIndex")>] member this.TabIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TabIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StopPropagation")>] member this.StopPropagation (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Component" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type IconFontBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit IconBuilder<'FunBlazorGeneric>()
    static member create () = IconFontBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type ImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ImageBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Alt")>] member this.Alt (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Alt" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fallback")>] member this.Fallback (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Fallback" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Placeholder" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Preview")>] member this.Preview (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Preview" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Src")>] member this.Src (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Src" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviewSrc")>] member this.PreviewSrc (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PreviewSrc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ImageLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ImagePreviewContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type InputGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = InputGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = InputGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = InputGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = InputGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Compact")>] member this.Compact (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Compact" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
                

type SiderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SiderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SiderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SiderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SiderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Collapsible")>] member this.Collapsible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Collapsible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Trigger" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoTrigger")>] member this.NoTrigger (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "NoTrigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.BreakpointType) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.SiderTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CollapsedWidth")>] member this.CollapsedWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "CollapsedWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Collapsed")>] member this.Collapsed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Collapsed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCollapse")>] member this.OnCollapse (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBreakpoint")>] member this.OnBreakpoint (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type AntListBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntListBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Header" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Footer" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadMore")>] member this.LoadMore (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "LoadMore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadMore")>] member this.LoadMore (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadMore")>] member this.LoadMore (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadMore")>] member this.LoadMore (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemLayout")>] member this.ItemLayout (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ListItemLayout) = "ItemLayout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoResult")>] member this.NoResult (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "NoResult" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Split" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnItemClick")>] member this.OnItemClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TItem> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Grid")>] member this.Grid (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Pagination")>] member this.Pagination (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.PaginationOptions) = "Pagination" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type ListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Actions")>] member this.Actions (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.RenderFragment[]) = "Actions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Grid")>] member this.Grid (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColStyle")>] member this.ColStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ColStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemCount")>] member this.ItemCount (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ItemCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFlex")>] member this.NoFlex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "NoFlex" => x |> BoleroAttr |> this.AddProp
                

type ListItemMetaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ListItemMetaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MentionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MentionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MentionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MentionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MentionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disable")>] member this.Disable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Readonly")>] member this.Readonly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Readonly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Split" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rows")>] member this.Rows (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Rows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChange")>] member this.ValueChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.EventArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFoundContent")>] member this.NoFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "NoFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFoundContent")>] member this.NoFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFoundContent")>] member this.NoFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFoundContent")>] member this.NoFoundContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MentionsOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MentionsOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MentionsOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MentionsOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MentionsOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disable")>] member this.Disable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.MenuTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.MenuMode) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSubmenuClicked")>] member this.OnSubmenuClicked (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.SubMenu> "OnSubmenuClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMenuItemClicked")>] member this.OnMenuItemClicked (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.MenuItem> "OnMenuItemClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Accordion")>] member this.Accordion (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Accordion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Selectable")>] member this.Selectable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Selectable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Multiple")>] member this.Multiple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineCollapsed")>] member this.InlineCollapsed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "InlineCollapsed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineIndent")>] member this.InlineIndent (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "InlineIndent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoCloseDropdown")>] member this.AutoCloseDropdown (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoCloseDropdown" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultSelectedKeys")>] member this.DefaultSelectedKeys (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultSelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultOpenKeys")>] member this.DefaultOpenKeys (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultOpenKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenKeys")>] member this.OpenKeys (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "OpenKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenKeysChanged")>] member this.OpenKeysChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "OpenKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeys")>] member this.SelectedKeys (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeysChanged")>] member this.SelectedKeysChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerSubMenuAction")>] member this.TriggerSubMenuAction (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TriggerType) = "TriggerSubMenuAction" => x |> BoleroAttr |> this.AddProp
                

type MenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RouterLink")>] member this.RouterLink (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RouterLink" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RouterMatch")>] member this.RouterMatch (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "RouterMatch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
                

type MenuItemGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MenuItemGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuItemGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuItemGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuItemGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
                

type MenuLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MenuLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("ActiveClass")>] member this.ActiveClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ActiveClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Attributes")>] member this.Attributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Match")>] member this.Match (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> this.AddProp
                

type SubMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SubMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SubMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SubMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SubMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsOpen")>] member this.IsOpen (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type MessageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MessageBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type MessageItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MessageItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.MessageConfig) = "Config" => x |> BoleroAttr |> this.AddProp
                

type ComfirmContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ComfirmContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type ConfirmBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ConfirmBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ConfirmOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ConfirmRef")>] member this.ConfirmRef (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ConfirmRef) = "ConfirmRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRemove")>] member this.OnRemove (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.ConfirmRef> "OnRemove" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type DialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DialogBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DialogBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DialogBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DialogBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
                

type DialogWrapperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DialogWrapperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DialogWrapperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DialogWrapperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DialogWrapperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DestroyOnClose")>] member this.DestroyOnClose (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBeforeDestroy")>] member this.OnBeforeDestroy (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.ComponentModel.CancelEventArgs> "OnBeforeDestroy" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAfterShow")>] member this.OnAfterShow (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAfterHide")>] member this.OnAfterHide (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterHide" => x |> BoleroAttr |> this.AddProp
                

type ModalBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ModalBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ModalBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ModalBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ModalBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("ModalRef")>] member this.ModalRef (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ModalRef) = "ModalRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AfterClose")>] member this.AfterClose (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Threading.Tasks.Task>) = "AfterClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BodyStyle")>] member this.BodyStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelText")>] member this.CancelText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Centered")>] member this.Centered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Centered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Draggable")>] member this.Draggable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DragInViewport")>] member this.DragInViewport (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DragInViewport" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CloseIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ConfirmLoading")>] member this.ConfirmLoading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ConfirmLoading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DestroyOnClose")>] member this.DestroyOnClose (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetContainer")>] member this.GetContainer (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "GetContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mask")>] member this.Mask (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Mask" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaskClosable")>] member this.MaskClosable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaskStyle")>] member this.MaskStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "MaskStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkText")>] member this.OkText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "OkText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkType")>] member this.OkType (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OkType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Double>) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapClassName")>] member this.WrapClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "WrapClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ZIndex")>] member this.ZIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancel")>] member this.OnCancel (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOk")>] member this.OnOk (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnOk" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkButtonProps")>] member this.OkButtonProps (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButtonProps")>] member this.CancelButtonProps (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ModalLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
                

type ModalContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ModalContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type ModalFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ModalFooterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type NotificationBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = NotificationBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type NotificationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit NotificationBaseBuilder<'FunBlazorGeneric>()
    static member create () = NotificationBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type NotificationItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit NotificationBaseBuilder<'FunBlazorGeneric>()
    static member create () = NotificationItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.NotificationConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>) = "OnClose" => x |> BoleroAttr |> this.AddProp
                

type PageHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PageHeaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Ghost")>] member this.Ghost (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIcon")>] member this.BackIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = "BackIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIconTemplate")>] member this.BackIconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "BackIconTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIconTemplate")>] member this.BackIconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIconTemplate")>] member this.BackIconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIconTemplate")>] member this.BackIconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Subtitle")>] member this.Subtitle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Subtitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBack")>] member this.OnBack (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnBack" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderContent")>] member this.PageHeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PageHeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderContent")>] member this.PageHeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderContent")>] member this.PageHeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderContent")>] member this.PageHeaderContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderFooter")>] member this.PageHeaderFooter (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PageHeaderFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderFooter")>] member this.PageHeaderFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderFooter")>] member this.PageHeaderFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderFooter")>] member this.PageHeaderFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderBreadcrumb")>] member this.PageHeaderBreadcrumb (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderBreadcrumb")>] member this.PageHeaderBreadcrumb (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderBreadcrumb")>] member this.PageHeaderBreadcrumb (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderBreadcrumb")>] member this.PageHeaderBreadcrumb (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderAvatar")>] member this.PageHeaderAvatar (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PageHeaderAvatar" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderAvatar")>] member this.PageHeaderAvatar (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderAvatar")>] member this.PageHeaderAvatar (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderAvatar")>] member this.PageHeaderAvatar (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTitle")>] member this.PageHeaderTitle (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PageHeaderTitle" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTitle")>] member this.PageHeaderTitle (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTitle")>] member this.PageHeaderTitle (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTitle")>] member this.PageHeaderTitle (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderSubtitle")>] member this.PageHeaderSubtitle (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderSubtitle")>] member this.PageHeaderSubtitle (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderSubtitle")>] member this.PageHeaderSubtitle (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderSubtitle")>] member this.PageHeaderSubtitle (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTags")>] member this.PageHeaderTags (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PageHeaderTags" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTags")>] member this.PageHeaderTags (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTags")>] member this.PageHeaderTags (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTags")>] member this.PageHeaderTags (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderExtra")>] member this.PageHeaderExtra (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PageHeaderExtra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderExtra")>] member this.PageHeaderExtra (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderExtra")>] member this.PageHeaderExtra (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderExtra")>] member this.PageHeaderExtra (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type PaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PaginationBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Total")>] member this.Total (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Total" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultCurrent")>] member this.DefaultCurrent (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "DefaultCurrent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Current")>] member this.Current (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPageSize")>] member this.DefaultPageSize (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "DefaultPageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSize")>] member this.PageSize (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideOnSinglePage")>] member this.HideOnSinglePage (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideOnSinglePage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSizeChanger")>] member this.ShowSizeChanger (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSizeChanger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSizeOptions")>] member this.PageSizeOptions (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnShowSizeChange")>] member this.OnShowSizeChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnShowSizeChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowQuickJumper")>] member this.ShowQuickJumper (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowQuickJumper" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "GoButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTitle")>] member this.ShowTitle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTotal")>] member this.ShowTotal (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = "ShowTotal" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Responsive")>] member this.Responsive (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Responsive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Simple")>] member this.Simple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Simple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.PaginationLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemRender")>] member this.ItemRender (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowLessItems")>] member this.ShowLessItems (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowLessItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPrevNextJumpers")>] member this.ShowPrevNextJumpers (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowPrevNextJumpers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrevIcon")>] member this.PrevIcon (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "PrevIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NextIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("JumpPrevIcon")>] member this.JumpPrevIcon (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "JumpPrevIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("JumpNextIcon")>] member this.JumpNextIcon (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "JumpNextIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TotalBoundaryShowSizeChanger")>] member this.TotalBoundaryShowSizeChanger (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "TotalBoundaryShowSizeChanger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnmatchedAttributes")>] member this.UnmatchedAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> BoleroAttr |> this.AddProp
                

type PaginationOptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PaginationOptionsBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("IsSmall")>] member this.IsSmall (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RootPrefixCls")>] member this.RootPrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeSize")>] member this.ChangeSize (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "ChangeSize" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Current")>] member this.Current (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSize")>] member this.PageSize (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSizeOptions")>] member this.PageSizeOptions (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("QuickGo")>] member this.QuickGo (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "QuickGo" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = "GoButton" => x |> BoleroAttr |> this.AddProp
                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ProgressBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ProgressSize) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ProgressType) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Double, System.String>) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Percent")>] member this.Percent (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "Percent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowInfo")>] member this.ShowInfo (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ProgressStatus) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeLinecap")>] member this.StrokeLinecap (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ProgressStrokeLinecap) = "StrokeLinecap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuccessPercent")>] member this.SuccessPercent (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "SuccessPercent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TrailColor")>] member this.TrailColor (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TrailColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeColor")>] member this.StrokeColor (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>) = "StrokeColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Steps")>] member this.Steps (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Steps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GapDegree")>] member this.GapDegree (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "GapDegree" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GapPosition")>] member this.GapPosition (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ProgressGapPosition) = "GapPosition" => x |> BoleroAttr |> this.AddProp
                

type RadioBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = RadioBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RadioBuilder<'FunBlazorGeneric, 'TValue>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RadioBuilder<'FunBlazorGeneric, 'TValue>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RadioBuilder<'FunBlazorGeneric, 'TValue>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RadioButton")>] member this.RadioButton (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "RadioButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultChecked")>] member this.DefaultChecked (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DefaultChecked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChange")>] member this.CheckedChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = RateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowHalf")>] member this.AllowHalf (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Character")>] member this.Character (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.RateItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Character" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Count")>] member this.Count (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Count" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Decimal) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Decimal> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Decimal) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tooltips")>] member this.Tooltips (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "Tooltips" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type RateItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = RateItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("AllowHalf")>] member this.AllowHalf (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnItemHover")>] member this.OnItemHover (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnItemHover" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnItemClick")>] member this.OnItemClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tooltip")>] member this.Tooltip (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Tooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IndexOfGroup")>] member this.IndexOfGroup (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "IndexOfGroup" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HoverValue")>] member this.HoverValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "HoverValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HasHalf")>] member this.HasHalf (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HasHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsFocused")>] member this.IsFocused (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsFocused" => x |> BoleroAttr |> this.AddProp
                

type ResultBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ResultBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ResultBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ResultBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ResultBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitle")>] member this.SubTitle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "SubTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitleTemplate")>] member this.SubTitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SubTitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitleTemplate")>] member this.SubTitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitleTemplate")>] member this.SubTitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitleTemplate")>] member this.SubTitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowIcon")>] member this.IsShowIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type SelectOptionBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SelectOptionBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TItemValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                

type SimpleSelectOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit SelectOptionBuilder<'FunBlazorGeneric, System.String, System.String>()
    static member create () = SimpleSelectOptionBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type SkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SkeletonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SkeletonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SkeletonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SkeletonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Active")>] member this.Active (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleWidth")>] member this.TitleWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "TitleWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarSize")>] member this.AvatarSize (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "AvatarSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarShape")>] member this.AvatarShape (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "AvatarShape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Paragraph")>] member this.Paragraph (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Paragraph" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ParagraphRows")>] member this.ParagraphRows (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Int32>) = "ParagraphRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ParagraphWidth")>] member this.ParagraphWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IList<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = "ParagraphWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type SkeletonElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SkeletonElementBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Active")>] member this.Active (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Shape")>] member this.Shape (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
                

type SpaceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SpaceBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpaceBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpaceBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpaceBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Align")>] member this.Align (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.DirectionVHType) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Wrap")>] member this.Wrap (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Wrap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Split" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type SpaceItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SpaceItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpaceItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpaceItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpaceItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type SpinBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SpinBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpinBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpinBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpinBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tip")>] member this.Tip (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Tip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delay")>] member this.Delay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Delay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Spinning")>] member this.Spinning (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Spinning" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperClassName")>] member this.WrapperClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "WrapperClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indicator")>] member this.Indicator (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Indicator" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indicator")>] member this.Indicator (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indicator")>] member this.Indicator (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indicator")>] member this.Indicator (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T>(x) :> IFunBlazorNode
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Suffix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueStyle")>] member this.ValueStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ValueStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type CountDownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit StatisticComponentBaseBuilder<'FunBlazorGeneric, System.DateTime>()
    static member create () = CountDownBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFinish")>] member this.OnFinish (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnFinish" => x |> BoleroAttr |> this.AddProp
                

type StatisticBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit StatisticComponentBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = StatisticBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("DecimalSeparator")>] member this.DecimalSeparator (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DecimalSeparator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GroupSeparator")>] member this.GroupSeparator (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "GroupSeparator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Precision")>] member this.Precision (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Precision" => x |> BoleroAttr |> this.AddProp
                

type StepBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = StepBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Subtitle")>] member this.Subtitle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Subtitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                

type StepsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = StepsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = StepsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = StepsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = StepsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Current")>] member this.Current (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Percent")>] member this.Percent (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Nullable<System.Double>) = "Percent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ProgressDot")>] member this.ProgressDot (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ProgressDot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ProgressDot")>] member this.ProgressDot (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ProgressDot")>] member this.ProgressDot (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ProgressDot")>] member this.ProgressDot (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowProgressDot")>] member this.ShowProgressDot (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowProgressDot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelPlacement")>] member this.LabelPlacement (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "LabelPlacement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StartIndex")>] member this.StartIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "StartIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type ColumnBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ColumnBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ColumnBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ColumnBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ColumnBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowSpan")>] member this.RowSpan (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColSpan")>] member this.ColSpan (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderColSpan")>] member this.HeaderColSpan (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
                

type ActionColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    static member create () = ActionColumnBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type ColumnBuilder<'FunBlazorGeneric, 'TData when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    static member create () = ColumnBuilder<'FunBlazorGeneric, 'TData>() :> IFunBlazorNode
    [<CustomOperation("FieldChanged")>] member this.FieldChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TData> "FieldChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FieldExpression")>] member this.FieldExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'TData>>) = "FieldExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CellRender")>] member this.CellRender (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TData -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "CellRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Field")>] member this.Field (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TData) = "Field" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataIndex")>] member this.DataIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DataIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Sortable")>] member this.Sortable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Sortable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SorterCompare")>] member this.SorterCompare (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<'TData, 'TData, System.Int32>) = "SorterCompare" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SorterMultiple")>] member this.SorterMultiple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "SorterMultiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSorterTooltip")>] member this.ShowSorterTooltip (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSorterTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortDirections")>] member this.SortDirections (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.SortDirection[]) = "SortDirections" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultSortOrder")>] member this.DefaultSortOrder (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.SortDirection) = "DefaultSortOrder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCell")>] member this.OnCell (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TableModels.RowData, System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnCell" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnHeaderCell")>] member this.OnHeaderCell (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnHeaderCell" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Filterable")>] member this.Filterable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Filterable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Filters")>] member this.Filters (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = "Filters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FilterMultiple")>] member this.FilterMultiple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "FilterMultiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFilter")>] member this.OnFilter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = "OnFilter" => x |> BoleroAttr |> this.AddProp
                

type SelectionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    static member create () = SelectionBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckStrictly")>] member this.CheckStrictly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "CheckStrictly" => x |> BoleroAttr |> this.AddProp
                

type SummaryCellBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    static member create () = SummaryCellBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TableBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = TableBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("RenderMode")>] member this.RenderMode (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.RenderMode) = "RenderMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowTemplate")>] member this.RowTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandTemplate")>] member this.ExpandTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.TableModels.RowData<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ExpandTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowExpandable")>] member this.RowExpandable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>) = "RowExpandable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TreeChildren")>] member this.TreeChildren (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>) = "TreeChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.QueryModel<'TItem>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRow")>] member this.OnRow (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnHeaderRow")>] member this.OnHeaderRow (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnHeaderRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TableSize) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TableLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollX")>] member this.ScrollX (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ScrollX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollY")>] member this.ScrollY (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ScrollY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollBarWidth")>] member this.ScrollBarWidth (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ScrollBarWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IndentSize")>] member this.IndentSize (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "IndentSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIconColumnIndex")>] member this.ExpandIconColumnIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ExpandIconColumnIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowClassName")>] member this.RowClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "RowClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedRowClassName")>] member this.ExpandedRowClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "ExpandedRowClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnExpand")>] member this.OnExpand (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnExpand" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortDirections")>] member this.SortDirections (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.SortDirection[]) = "SortDirections" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TableLayout")>] member this.TableLayout (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TableLayout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HidePagination")>] member this.HidePagination (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HidePagination" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PaginationPosition")>] member this.PaginationPosition (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PaginationPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Total")>] member this.Total (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Total" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TotalChanged")>] member this.TotalChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "TotalChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageIndex")>] member this.PageIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "PageIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageIndexChanged")>] member this.PageIndexChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "PageIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSize")>] member this.PageSize (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSizeChanged")>] member this.PageSizeChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "PageSizeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPageIndexChange")>] member this.OnPageIndexChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageIndexChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPageSizeChange")>] member this.OnPageSizeChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageSizeChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedRows")>] member this.SelectedRows (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedRowsChanged")>] member this.SelectedRowsChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItem>> "SelectedRowsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TabPaneBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TabPaneBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TabPaneBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TabPaneBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TabPaneBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("ForceRender")>] member this.ForceRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ForceRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tab")>] member this.Tab (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Tab" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tab")>] member this.Tab (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tab")>] member this.Tab (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tab")>] member this.Tab (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
                

type TabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActiveKey")>] member this.ActiveKey (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActiveKeyChanged")>] member this.ActiveKeyChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "ActiveKeyChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Animated")>] member this.Animated (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Animated" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTabBar")>] member this.RenderTabBar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "RenderTabBar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveKey")>] member this.DefaultActiveKey (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "DefaultActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideAdd")>] member this.HideAdd (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HideAdd" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarExtraContent")>] member this.TabBarExtraContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TabBarExtraContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarExtraContent")>] member this.TabBarExtraContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarExtraContent")>] member this.TabBarExtraContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarExtraContent")>] member this.TabBarExtraContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarGutter")>] member this.TabBarGutter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "TabBarGutter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarStyle")>] member this.TabBarStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TabBarStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabPosition")>] member this.TabPosition (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TabPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnEdit")>] member this.OnEdit (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>) = "OnEdit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAddClick")>] member this.OnAddClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAddClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AfterTabCreated")>] member this.AfterTabCreated (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "AfterTabCreated" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnNextClick")>] member this.OnNextClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnNextClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPrevClick")>] member this.OnPrevClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnPrevClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTabClick")>] member this.OnTabClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnTabClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Draggable")>] member this.Draggable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
                

type TagBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TagBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TagBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TagBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TagBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checkable")>] member this.Checkable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Checkable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChange")>] member this.CheckedChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClosing")>] member this.OnClosing (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs>> "OnClosing" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
                

type TimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TimelineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TimelineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TimelineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TimelineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Reverse")>] member this.Reverse (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Reverse" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Pending")>] member this.Pending (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Pending" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PendingDot")>] member this.PendingDot (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "PendingDot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PendingDot")>] member this.PendingDot (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PendingDot")>] member this.PendingDot (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PendingDot")>] member this.PendingDot (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type TimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TimelineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TimelineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TimelineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TimelineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Dot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
                

type TransferBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TransferBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TransferBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TransferBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TransferBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IList<AntDesign.TransferItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Titles")>] member this.Titles (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "Titles" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Operations")>] member this.Operations (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "Operations" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSearch")>] member this.ShowSearch (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSelectAll")>] member this.ShowSelectAll (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSelectAll" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TargetKeys")>] member this.TargetKeys (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "TargetKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeys")>] member this.SelectedKeys (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferChangeArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnScroll")>] member this.OnScroll (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferScrollArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferSearchArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectChange")>] member this.OnSelectChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferSelectChangeArgs> "OnSelectChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Render")>] member this.Render (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Render" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TransferLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type TreeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = TreeBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("ShowExpand")>] member this.ShowExpand (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowExpand" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowLine")>] member this.ShowLine (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowIcon")>] member this.ShowIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BlockNode")>] member this.BlockNode (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "BlockNode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Draggable")>] member this.Draggable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildNodes")>] member this.ChildNodes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.List<AntDesign.TreeNode<'TItem>>) = "ChildNodes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Multiple")>] member this.Multiple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKey")>] member this.SelectedKey (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "SelectedKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeyChanged")>] member this.SelectedKeyChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "SelectedKeyChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedNode")>] member this.SelectedNode (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TreeNode<'TItem>) = "SelectedNode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedNodeChanged")>] member this.SelectedNodeChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeNode<'TItem>> "SelectedNodeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedData")>] member this.SelectedData (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TItem) = "SelectedData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedDataChanged")>] member this.SelectedDataChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<'TItem> "SelectedDataChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeys")>] member this.SelectedKeys (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeysChanged")>] member this.SelectedKeysChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedNodes")>] member this.SelectedNodes (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TreeNode<'TItem>[]) = "SelectedNodes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedDatas")>] member this.SelectedDatas (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TItem[]) = "SelectedDatas" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checkable")>] member this.Checkable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Checkable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SearchValue")>] member this.SearchValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "SearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SearchExpression")>] member this.SearchExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "SearchExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.IList<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleExpression")>] member this.TitleExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "TitleExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyExpression")>] member this.KeyExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "KeyExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconExpression")>] member this.IconExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "IconExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsLeafExpression")>] member this.IsLeafExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "IsLeafExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildrenExpression")>] member this.ChildrenExpression (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IList<'TItem>>) = "ChildrenExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnNodeLoadDelayAsync")>] member this.OnNodeLoadDelayAsync (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnNodeLoadDelayAsync" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDblClick")>] member this.OnDblClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDblClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnContextMenu")>] member this.OnContextMenu (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnContextMenu" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCheckBoxChanged")>] member this.OnCheckBoxChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnCheckBoxChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnExpandChanged")>] member this.OnExpandChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnExpandChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearchValueChanged")>] member this.OnSearchValueChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnSearchValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IndentTemplate")>] member this.IndentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "IndentTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "TitleTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleIconTemplate")>] member this.TitleIconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "TitleIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SwitcherIconTemplate")>] member this.SwitcherIconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "SwitcherIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type TreeNodeBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = TreeNodeBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Selected")>] member this.Selected (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Selected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsLeaf")>] member this.IsLeaf (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsLeaf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableCheckbox")>] member this.DisableCheckbox (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "DisableCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Draggable")>] member this.Draggable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataItem")>] member this.DataItem (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TItem) = "DataItem" => x |> BoleroAttr |> this.AddProp
                

type TypographyBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TypographyBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TypographyBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TypographyBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TypographyBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("Copyable")>] member this.Copyable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CopyConfig")>] member this.CopyConfig (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delete")>] member this.Delete (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EditConfig")>] member this.EditConfig (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EllipsisConfig")>] member this.EllipsisConfig (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mark")>] member this.Mark (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Strong")>] member this.Strong (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type LinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    static member create () = LinkBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Code")>] member this.Code (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
                

type ParagraphBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    static member create () = ParagraphBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Code")>] member this.Code (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
                

type TextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    static member create () = TextBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Code")>] member this.Code (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
                

type TitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    static member create () = TitleBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Level")>] member this.Level (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Level" => x |> BoleroAttr |> this.AddProp
                

type UploadBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = UploadBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = UploadBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = UploadBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = UploadBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("BeforeUpload")>] member this.BeforeUpload (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.UploadFileItem, System.Boolean>) = "BeforeUpload" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BeforeAllUploadAsync")>] member this.BeforeAllUploadAsync (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>) = "BeforeAllUploadAsync" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BeforeAllUpload")>] member this.BeforeAllUpload (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Boolean>) = "BeforeAllUpload" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Action")>] member this.Action (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Action" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ListType")>] member this.ListType (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ListType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Directory")>] member this.Directory (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Directory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Multiple")>] member this.Multiple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Accept")>] member this.Accept (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Accept" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowUploadList")>] member this.ShowUploadList (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowUploadList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FileList")>] member this.FileList (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "FileList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.UploadLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FileListChanged")>] member this.FileListChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.List<AntDesign.UploadFileItem>> "FileListChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultFileList")>] member this.DefaultFileList (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "DefaultFileList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Headers")>] member this.Headers (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSingleCompleted")>] member this.OnSingleCompleted (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnSingleCompleted" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCompleted")>] member this.OnCompleted (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnCompleted" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRemove")>] member this.OnRemove (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>) = "OnRemove" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPreview")>] member this.OnPreview (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnPreview" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDownload")>] member this.OnDownload (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnDownload" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowButton")>] member this.ShowButton (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> this.AddProp
                

type BreadcrumbItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BreadcrumbItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BreadcrumbItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BreadcrumbItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BreadcrumbItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Object) = "Overlay" => x |> BoleroAttr |> this.AddProp
                

type CalendarHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CalendarHeaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type CardMetaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CardMetaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type AntContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type TemplateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TemplateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TemplateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TemplateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TemplateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("If")>] member this.If (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Boolean>) = "If" => x |> BoleroAttr |> this.AddProp
                

type EmptyDefaultImgBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = EmptyDefaultImgBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
                

type EmptySimpleImgBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = EmptySimpleImgBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
                

type ContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type FooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = FooterBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FooterBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FooterBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FooterBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type HeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = HeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = HeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = HeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = HeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type LayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = LayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = LayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = LayoutBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = LayoutBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type MenuDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MenuDividerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type PaginationPagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PaginationPagerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("ShowTitle")>] member this.ShowTitle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Page")>] member this.Page (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "Page" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RootPrefixCls")>] member this.RootPrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Active")>] member this.Active (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Int32> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action>> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemRender")>] member this.ItemRender (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnmatchedAttributes")>] member this.UnmatchedAttributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Select.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type SelectOptionGroupBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SelectOptionGroupBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem>() :> IFunBlazorNode

                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type CalendarPanelChooserBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CalendarPanelChooserBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Calendar")>] member this.Calendar (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.Calendar) = "Calendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
                

type ElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefChanged")>] member this.RefChanged (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Attributes")>] member this.Attributes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> BoleroAttr |> this.AddProp
                

type OverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = OverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = OverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = OverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = OverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("OverlayChildPrefixCls")>] member this.OverlayChildPrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OverlayChildPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayMouseEnter")>] member this.OnOverlayMouseEnter (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayMouseLeave")>] member this.OnOverlayMouseLeave (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnShow")>] member this.OnShow (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnHide")>] member this.OnHide (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnHide" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideMillisecondsDelay")>] member this.HideMillisecondsDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "HideMillisecondsDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WaitForHideAnimMilliseconds")>] member this.WaitForHideAnimMilliseconds (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "WaitForHideAnimMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("VerticalOffset")>] member this.VerticalOffset (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "VerticalOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HorizontalOffset")>] member this.HorizontalOffset (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "HorizontalOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
                

type OverlayTriggerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = OverlayTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = OverlayTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = OverlayTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = OverlayTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("BoundaryAdjustMode")>] member this.BoundaryAdjustMode (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member this.ComplexAutoCloseAndVisible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineFlexMode")>] member this.InlineFlexMode (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsButton")>] member this.IsButton (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMaskClick")>] member this.OnMaskClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayHiding")>] member this.OnOverlayHiding (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayEnterCls")>] member this.OverlayEnterCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayHiddenCls")>] member this.OverlayHiddenCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayLeaveCls")>] member this.OverlayLeaveCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlacementCls")>] member this.PlacementCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerReference")>] member this.TriggerReference (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Unbound")>] member this.Unbound (_: FunBlazorContext<'FunBlazorGeneric>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type DropdownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    static member create () = DropdownBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type DropdownButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DropdownBuilder<'FunBlazorGeneric>()
    static member create () = DropdownButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Block")>] member this.Block (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Block" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonsRender")>] member this.ButtonsRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "ButtonsRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Danger")>] member this.Danger (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Danger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ghost")>] member this.Ghost (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<'FunBlazorGeneric>, x: System.ValueTuple<System.String, System.String>) = "Type" => x |> BoleroAttr |> this.AddProp
                

type PopconfirmBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    static member create () = PopconfirmBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelText")>] member this.CancelText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkText")>] member this.OkText (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OkText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkType")>] member this.OkType (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "OkType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkButtonProps")>] member this.OkButtonProps (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButtonProps")>] member this.CancelButtonProps (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconTemplate")>] member this.IconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "IconTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconTemplate")>] member this.IconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconTemplate")>] member this.IconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconTemplate")>] member this.IconTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancel")>] member this.OnCancel (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnConfirm")>] member this.OnConfirm (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnConfirm" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ArrowPointAtCenter")>] member this.ArrowPointAtCenter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseEnterDelay")>] member this.MouseEnterDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseLeaveDelay")>] member this.MouseLeaveDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
                

type PopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    static member create () = PopoverBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ArrowPointAtCenter")>] member this.ArrowPointAtCenter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseEnterDelay")>] member this.MouseEnterDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseLeaveDelay")>] member this.MouseLeaveDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
                

type TooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    static member create () = TooltipBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ArrowPointAtCenter")>] member this.ArrowPointAtCenter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseEnterDelay")>] member this.MouseEnterDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseLeaveDelay")>] member this.MouseLeaveDelay (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type SubMenuTriggerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    static member create () = SubMenuTriggerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("TriggerClass")>] member this.TriggerClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "TriggerClass" => x |> BoleroAttr |> this.AddProp
                

type DatePickerPanelChooserBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerPanelChooserBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("DatePicker")>] member this.DatePicker (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.DatePickerBase<'TValue>) = "DatePicker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
                

type PickerPanelBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PickerPanelBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit Internal.PickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type DatePickerDatetimePanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerDatetimePanelBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowTime")>] member this.IsShowTime (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTimeFormat")>] member this.ShowTimeFormat (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ShowTimeFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
                

type DatePickerTemplateBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerTemplateBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("RenderPickerHeader")>] member this.RenderPickerHeader (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "RenderPickerHeader" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderPickerHeader")>] member this.RenderPickerHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderPickerHeader")>] member this.RenderPickerHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderPickerHeader")>] member this.RenderPickerHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTableHeader")>] member this.RenderTableHeader (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "RenderTableHeader" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTableHeader")>] member this.RenderTableHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTableHeader")>] member this.RenderTableHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTableHeader")>] member this.RenderTableHeader (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderFirstCol")>] member this.RenderFirstCol (_: FunBlazorContext<'FunBlazorGeneric>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderFirstCol" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderColValue")>] member this.RenderColValue (_: FunBlazorContext<'FunBlazorGeneric>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderColValue" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderLastCol")>] member this.RenderLastCol (_: FunBlazorContext<'FunBlazorGeneric>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderLastCol" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ViewStartDate")>] member this.ViewStartDate (_: FunBlazorContext<'FunBlazorGeneric>, x: System.DateTime) = "ViewStartDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetColTitle")>] member this.GetColTitle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.String>) = "GetColTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetRowClass")>] member this.GetRowClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.String>) = "GetRowClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetNextColValue")>] member this.GetNextColValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.DateTime>) = "GetNextColValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsInView")>] member this.IsInView (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Boolean>) = "IsInView" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsToday")>] member this.IsToday (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Boolean>) = "IsToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsSelected")>] member this.IsSelected (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Func<System.DateTime, System.Boolean>) = "IsSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowSelect")>] member this.OnRowSelect (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.DateTime>) = "OnRowSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnValueSelect")>] member this.OnValueSelect (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Action<System.DateTime>) = "OnValueSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowFooter")>] member this.ShowFooter (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxRow")>] member this.MaxRow (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MaxRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxCol")>] member this.MaxCol (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "MaxCol" => x |> BoleroAttr |> this.AddProp
                

type DatePickerDatePanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerDatePanelBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("IsWeek")>] member this.IsWeek (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
                

type DatePickerDecadePanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerDecadePanelBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type DatePickerFooterBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerFooterBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type DatePickerHeaderBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerHeaderBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("SuperChangeDateInterval")>] member this.SuperChangeDateInterval (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "SuperChangeDateInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeDateInterval")>] member this.ChangeDateInterval (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "ChangeDateInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSuperPreChange")>] member this.ShowSuperPreChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSuperPreChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPreChange")>] member this.ShowPreChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowPreChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowNextChange")>] member this.ShowNextChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowNextChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSuperNextChange")>] member this.ShowSuperNextChange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSuperNextChange" => x |> BoleroAttr |> this.AddProp
                

type DatePickerMonthPanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerMonthPanelBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type DatePickerQuarterPanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerQuarterPanelBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type DatePickerYearPanelBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric, 'TValue>()
    static member create () = DatePickerYearPanelBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode

                

type DatePickerInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerInputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSuffixIcon")>] member this.ShowSuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowSuffixIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Onfocus")>] member this.Onfocus (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnBlur" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Onfocusout")>] member this.Onfocusout (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocusout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClickClear")>] member this.OnClickClear (_: FunBlazorContext<'FunBlazorGeneric>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClickClear" => x |> BoleroAttr |> this.AddProp
                

type DropdownGroupButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DropdownGroupButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("LeftButton")>] member this.LeftButton (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "LeftButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LeftButton")>] member this.LeftButton (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LeftButton")>] member this.LeftButton (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LeftButton")>] member this.LeftButton (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightButton")>] member this.RightButton (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "RightButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightButton")>] member this.RightButton (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightButton")>] member this.RightButton (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightButton")>] member this.RightButton (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type TemplateComponentBaseBuilder<'FunBlazorGeneric, 'TComponentOptions when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = TemplateComponentBaseBuilder<'FunBlazorGeneric, 'TComponentOptions>() :> IFunBlazorNode
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<'FunBlazorGeneric>, x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> this.AddProp
                

type FeedbackComponentBuilder<'FunBlazorGeneric, 'TComponentOptions when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit TemplateComponentBaseBuilder<'FunBlazorGeneric, 'TComponentOptions>()
    static member create () = FeedbackComponentBuilder<'FunBlazorGeneric, 'TComponentOptions>() :> IFunBlazorNode
    [<CustomOperation("FeedbackRef")>] member this.FeedbackRef (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> this.AddProp
                

type FeedbackComponentBuilder2<'FunBlazorGeneric, 'TComponentOptions, 'TResult when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FeedbackComponentBuilder<'FunBlazorGeneric, 'TComponentOptions>()
    static member create () = FeedbackComponentBuilder2<'FunBlazorGeneric, 'TComponentOptions, 'TResult>() :> IFunBlazorNode

                

type FormProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = FormProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FormProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FormProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FormProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("OnFormFinish")>] member this.OnFormFinish (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.FormProviderFinishEventArgs> "OnFormFinish" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type UploadButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = UploadButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = UploadButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = UploadButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = UploadButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ListType")>] member this.ListType (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ListType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowButton")>] member this.ShowButton (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Directory")>] member this.Directory (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Directory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Multiple")>] member this.Multiple (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Accept")>] member this.Accept (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Accept" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Headers")>] member this.Headers (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Action")>] member this.Action (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Action" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type FormValidationMessageBuilder<'FunBlazorGeneric, 'TValue when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = FormValidationMessageBuilder<'FunBlazorGeneric, 'TValue>() :> IFunBlazorNode
    [<CustomOperation("Control")>] member this.Control (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.AntInputComponentBase<'TValue>) = "Control" => x |> BoleroAttr |> this.AddProp
                

type FormValidationMessageItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = FormValidationMessageItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("Message")>] member this.Message (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ImagePreviewBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    [<CustomOperation("ImageRef")>] member this.ImageRef (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ImageRef) = "ImageRef" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ImagePreviewGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ImagePreviewGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ImagePreviewGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ImagePreviewGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type TreeIndentBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeIndentBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("TreeLevel")>] member this.TreeLevel (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Int32) = "TreeLevel" => x |> BoleroAttr |> this.AddProp
                

type TreeNodeCheckboxBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeCheckboxBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("OnCheckBoxClick")>] member this.OnCheckBoxClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCheckBoxClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TreeNodeSwitcherBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeSwitcherBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("OnSwitcherClick")>] member this.OnSwitcherClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnSwitcherClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TreeNodeTitleBuilder<'FunBlazorGeneric, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeTitleBuilder<'FunBlazorGeneric, 'TItem>() :> IFunBlazorNode

                

type CardLoadingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = CardLoadingBuilder<'FunBlazorGeneric>() :> IFunBlazorNode

                

type SummaryRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SummaryRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SummaryRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SummaryRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SummaryRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.statistic

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = StatisticComponentBaseBuilder<'FunBlazorGeneric, 'T>() :> IFunBlazorNode

                
            
namespace rec AntDesign.DslInternals.Select

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type LabelTemplateItemBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = LabelTemplateItemBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("LabelTemplateItemContent")>] member this.LabelTemplateItemContent (_: FunBlazorContext<'FunBlazorGeneric>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplateItemContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<'FunBlazorGeneric>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("ContentStyle")>] member this.ContentStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ContentStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentClass")>] member this.ContentClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "ContentClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RemoveIconStyle")>] member this.RemoveIconStyle (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RemoveIconStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RemoveIconClass")>] member this.RemoveIconClass (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "RemoveIconClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Select.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.DslInternals


type SelectContentBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = SelectContentBuilder<'FunBlazorGeneric, 'TItemValue, 'TItem>() :> IFunBlazorNode
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsOverlayShow")>] member this.IsOverlayShow (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "IsOverlayShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPlaceholder")>] member this.ShowPlaceholder (_: FunBlazorContext<'FunBlazorGeneric>, x: System.Boolean) = "ShowPlaceholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRemoveSelected")>] member this.OnRemoveSelected (_: FunBlazorContext<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>> "OnRemoveSelected" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SearchValue")>] member this.SearchValue (_: FunBlazorContext<'FunBlazorGeneric>, x: System.String) = "SearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<'FunBlazorGeneric>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            

// =======================================================================================================================

namespace AntDesign

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals

    type AntComponentBase' = AntComponentBaseBuilder<AntDesign.AntComponentBase>
    type ConfigProvider' = ConfigProviderBuilder<AntDesign.ConfigProvider>
    type AntDomComponentBase' = AntDomComponentBaseBuilder<AntDesign.AntDomComponentBase>
    type Affix' = AffixBuilder<AntDesign.Affix>
    type Alert' = AlertBuilder<AntDesign.Alert>
    type Anchor' = AnchorBuilder<AntDesign.Anchor>
    type AnchorLink' = AnchorLinkBuilder<AntDesign.AnchorLink>
    type AutoCompleteOptGroup' = AutoCompleteOptGroupBuilder<AntDesign.AutoCompleteOptGroup>
    type AutoCompleteOption' = AutoCompleteOptionBuilder<AntDesign.AutoCompleteOption>
    type Avatar' = AvatarBuilder<AntDesign.Avatar>
    type AvatarGroup' = AvatarGroupBuilder<AntDesign.AvatarGroup>
    type BackTop' = BackTopBuilder<AntDesign.BackTop>
    type Badge' = BadgeBuilder<AntDesign.Badge>
    type BadgeRibbon' = BadgeRibbonBuilder<AntDesign.BadgeRibbon>
    type Breadcrumb' = BreadcrumbBuilder<AntDesign.Breadcrumb>
    type Button' = ButtonBuilder<AntDesign.Button>
    type ButtonGroup' = ButtonGroupBuilder<AntDesign.ButtonGroup>
    type Calendar' = CalendarBuilder<AntDesign.Calendar>
    type Card' = CardBuilder<AntDesign.Card>
    type CardAction' = CardActionBuilder<AntDesign.CardAction>
    type CardGrid' = CardGridBuilder<AntDesign.CardGrid>
    type Carousel' = CarouselBuilder<AntDesign.Carousel>
    type CarouselSlick' = CarouselSlickBuilder<AntDesign.CarouselSlick>
    type Collapse' = CollapseBuilder<AntDesign.Collapse>
    type Panel' = PanelBuilder<AntDesign.Panel>
    type Comment' = CommentBuilder<AntDesign.Comment>
    type AntContainerComponentBase' = AntContainerComponentBaseBuilder<AntDesign.AntContainerComponentBase>
    type AntInputComponentBase'<'TValue> = AntInputComponentBaseBuilder<AntDesign.AntInputComponentBase<'TValue>, 'TValue>
    type AutoComplete'<'TOption> = AutoCompleteBuilder<AntDesign.AutoComplete<'TOption>, 'TOption>
    type Cascader' = CascaderBuilder<AntDesign.Cascader>
    type CheckboxGroup' = CheckboxGroupBuilder<AntDesign.CheckboxGroup>
    type AntInputBoolComponentBase' = AntInputBoolComponentBaseBuilder<AntDesign.AntInputBoolComponentBase>
    type Checkbox' = CheckboxBuilder<AntDesign.Checkbox>
    type Switch' = SwitchBuilder<AntDesign.Switch>
    type DatePickerBase'<'TValue> = DatePickerBaseBuilder<AntDesign.DatePickerBase<'TValue>, 'TValue>
    type DatePicker'<'TValue> = DatePickerBuilder<AntDesign.DatePicker<'TValue>, 'TValue>
    type MonthPicker'<'TValue> = MonthPickerBuilder<AntDesign.MonthPicker<'TValue>, 'TValue>
    type QuarterPicker'<'TValue> = QuarterPickerBuilder<AntDesign.QuarterPicker<'TValue>, 'TValue>
    type WeekPicker'<'TValue> = WeekPickerBuilder<AntDesign.WeekPicker<'TValue>, 'TValue>
    type YearPicker'<'TValue> = YearPickerBuilder<AntDesign.YearPicker<'TValue>, 'TValue>
    type TimePicker'<'TValue> = TimePickerBuilder<AntDesign.TimePicker<'TValue>, 'TValue>
    type RangePicker'<'TValue> = RangePickerBuilder<AntDesign.RangePicker<'TValue>, 'TValue>
    type InputNumber'<'TValue> = InputNumberBuilder<AntDesign.InputNumber<'TValue>, 'TValue>
    type Input'<'TValue> = InputBuilder<AntDesign.Input<'TValue>, 'TValue>
    type AutoCompleteInput'<'TValue> = AutoCompleteInputBuilder<AntDesign.AutoCompleteInput<'TValue>, 'TValue>
    type InputPassword' = InputPasswordBuilder<AntDesign.InputPassword>
    type Search' = SearchBuilder<AntDesign.Search>
    type AutoCompleteSearch' = AutoCompleteSearchBuilder<AntDesign.AutoCompleteSearch>
    type TextArea' = TextAreaBuilder<AntDesign.TextArea>
    type RadioGroup'<'TValue> = RadioGroupBuilder<AntDesign.RadioGroup<'TValue>, 'TValue>
    type Select'<'TItemValue, 'TItem> = SelectBuilder<AntDesign.Select<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    type SimpleSelect' = SimpleSelectBuilder<AntDesign.SimpleSelect>
    type Slider'<'TValue> = SliderBuilder<AntDesign.Slider<'TValue>, 'TValue>
    type Descriptions' = DescriptionsBuilder<AntDesign.Descriptions>
    type DescriptionsItem' = DescriptionsItemBuilder<AntDesign.DescriptionsItem>
    type Divider' = DividerBuilder<AntDesign.Divider>
    type Drawer' = DrawerBuilder<AntDesign.Drawer>
    type DrawerContainer' = DrawerContainerBuilder<AntDesign.DrawerContainer>
    type Empty' = EmptyBuilder<AntDesign.Empty>
    type Form'<'TModel> = FormBuilder<AntDesign.Form<'TModel>, 'TModel>
    type FormItem' = FormItemBuilder<AntDesign.FormItem>
    type Col' = ColBuilder<AntDesign.Col>
    type GridCol' = GridColBuilder<AntDesign.GridCol>
    type Row' = RowBuilder<AntDesign.Row>
    type Icon' = IconBuilder<AntDesign.Icon>
    type IconFont' = IconFontBuilder<AntDesign.IconFont>
    type Image' = ImageBuilder<AntDesign.Image>
    type ImagePreviewContainer' = ImagePreviewContainerBuilder<AntDesign.ImagePreviewContainer>
    type InputGroup' = InputGroupBuilder<AntDesign.InputGroup>
    type Sider' = SiderBuilder<AntDesign.Sider>
    type AntList'<'TItem> = AntListBuilder<AntDesign.AntList<'TItem>, 'TItem>
    type ListItem' = ListItemBuilder<AntDesign.ListItem>
    type ListItemMeta' = ListItemMetaBuilder<AntDesign.ListItemMeta>
    type Mentions' = MentionsBuilder<AntDesign.Mentions>
    type MentionsOption' = MentionsOptionBuilder<AntDesign.MentionsOption>
    type Menu' = MenuBuilder<AntDesign.Menu>
    type MenuItem' = MenuItemBuilder<AntDesign.MenuItem>
    type MenuItemGroup' = MenuItemGroupBuilder<AntDesign.MenuItemGroup>
    type MenuLink' = MenuLinkBuilder<AntDesign.MenuLink>
    type SubMenu' = SubMenuBuilder<AntDesign.SubMenu>
    type Message' = MessageBuilder<AntDesign.Message>
    type MessageItem' = MessageItemBuilder<AntDesign.MessageItem>
    type ComfirmContainer' = ComfirmContainerBuilder<AntDesign.ComfirmContainer>
    type Confirm' = ConfirmBuilder<AntDesign.Confirm>
    type Dialog' = DialogBuilder<AntDesign.Dialog>
    type DialogWrapper' = DialogWrapperBuilder<AntDesign.DialogWrapper>
    type Modal' = ModalBuilder<AntDesign.Modal>
    type ModalContainer' = ModalContainerBuilder<AntDesign.ModalContainer>
    type ModalFooter' = ModalFooterBuilder<AntDesign.ModalFooter>
    type NotificationBase' = NotificationBaseBuilder<AntDesign.NotificationBase>
    type Notification' = NotificationBuilder<AntDesign.Notification>
    type NotificationItem' = NotificationItemBuilder<AntDesign.NotificationItem>
    type PageHeader' = PageHeaderBuilder<AntDesign.PageHeader>
    type Pagination' = PaginationBuilder<AntDesign.Pagination>
    type PaginationOptions' = PaginationOptionsBuilder<AntDesign.PaginationOptions>
    type Progress' = ProgressBuilder<AntDesign.Progress>
    type Radio'<'TValue> = RadioBuilder<AntDesign.Radio<'TValue>, 'TValue>
    type Rate' = RateBuilder<AntDesign.Rate>
    type RateItem' = RateItemBuilder<AntDesign.RateItem>
    type Result' = ResultBuilder<AntDesign.Result>
    type SelectOption'<'TItemValue, 'TItem> = SelectOptionBuilder<AntDesign.SelectOption<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    type SimpleSelectOption' = SimpleSelectOptionBuilder<AntDesign.SimpleSelectOption>
    type Skeleton' = SkeletonBuilder<AntDesign.Skeleton>
    type SkeletonElement' = SkeletonElementBuilder<AntDesign.SkeletonElement>
    type Space' = SpaceBuilder<AntDesign.Space>
    type SpaceItem' = SpaceItemBuilder<AntDesign.SpaceItem>
    type Spin' = SpinBuilder<AntDesign.Spin>
    type StatisticComponentBase'<'T> = StatisticComponentBaseBuilder<AntDesign.StatisticComponentBase<'T>, 'T>
    type CountDown' = CountDownBuilder<AntDesign.CountDown>
    type Statistic'<'TValue> = StatisticBuilder<AntDesign.Statistic<'TValue>, 'TValue>
    type Step' = StepBuilder<AntDesign.Step>
    type Steps' = StepsBuilder<AntDesign.Steps>
    type ColumnBase' = ColumnBaseBuilder<AntDesign.ColumnBase>
    type ActionColumn' = ActionColumnBuilder<AntDesign.ActionColumn>
    type Column'<'TData> = ColumnBuilder<AntDesign.Column<'TData>, 'TData>
    type Selection' = SelectionBuilder<AntDesign.Selection>
    type SummaryCell' = SummaryCellBuilder<AntDesign.SummaryCell>
    type Table'<'TItem> = TableBuilder<AntDesign.Table<'TItem>, 'TItem>
    type TabPane' = TabPaneBuilder<AntDesign.TabPane>
    type Tabs' = TabsBuilder<AntDesign.Tabs>
    type Tag' = TagBuilder<AntDesign.Tag>
    type Timeline' = TimelineBuilder<AntDesign.Timeline>
    type TimelineItem' = TimelineItemBuilder<AntDesign.TimelineItem>
    type Transfer' = TransferBuilder<AntDesign.Transfer>
    type Tree'<'TItem> = TreeBuilder<AntDesign.Tree<'TItem>, 'TItem>
    type TreeNode'<'TItem> = TreeNodeBuilder<AntDesign.TreeNode<'TItem>, 'TItem>
    type TypographyBase' = TypographyBaseBuilder<AntDesign.TypographyBase>
    type Link' = LinkBuilder<AntDesign.Link>
    type Paragraph' = ParagraphBuilder<AntDesign.Paragraph>
    type Text' = TextBuilder<AntDesign.Text>
    type Title' = TitleBuilder<AntDesign.Title>
    type Upload' = UploadBuilder<AntDesign.Upload>
    type BreadcrumbItem' = BreadcrumbItemBuilder<AntDesign.BreadcrumbItem>
    type CalendarHeader' = CalendarHeaderBuilder<AntDesign.CalendarHeader>
    type CardMeta' = CardMetaBuilder<AntDesign.CardMeta>
    type AntContainer' = AntContainerBuilder<AntDesign.AntContainer>
    type Template' = TemplateBuilder<AntDesign.Template>
    type EmptyDefaultImg' = EmptyDefaultImgBuilder<AntDesign.EmptyDefaultImg>
    type EmptySimpleImg' = EmptySimpleImgBuilder<AntDesign.EmptySimpleImg>
    type Content' = ContentBuilder<AntDesign.Content>
    type Footer' = FooterBuilder<AntDesign.Footer>
    type Header' = HeaderBuilder<AntDesign.Header>
    type Layout' = LayoutBuilder<AntDesign.Layout>
    type MenuDivider' = MenuDividerBuilder<AntDesign.MenuDivider>
    type PaginationPager' = PaginationPagerBuilder<AntDesign.PaginationPager>
    type Dropdown' = DropdownBuilder<AntDesign.Dropdown>
    type DropdownButton' = DropdownButtonBuilder<AntDesign.DropdownButton>
    type Popconfirm' = PopconfirmBuilder<AntDesign.Popconfirm>
    type Popover' = PopoverBuilder<AntDesign.Popover>
    type Tooltip' = TooltipBuilder<AntDesign.Tooltip>
    type DatePickerPanelBase'<'TValue> = DatePickerPanelBaseBuilder<AntDesign.DatePickerPanelBase<'TValue>, 'TValue>
    type TemplateComponentBase'<'TComponentOptions> = TemplateComponentBaseBuilder<AntDesign.TemplateComponentBase<'TComponentOptions>, 'TComponentOptions>
    type FeedbackComponent'<'TComponentOptions> = FeedbackComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions>, 'TComponentOptions>
    type FeedbackComponent'<'TComponentOptions, 'TResult> = FeedbackComponentBuilder2<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>, 'TComponentOptions, 'TResult>
    type FormProvider' = FormProviderBuilder<AntDesign.FormProvider>
    type FormValidationMessage'<'TValue> = FormValidationMessageBuilder<AntDesign.FormValidationMessage<'TValue>, 'TValue>
    type FormValidationMessageItem' = FormValidationMessageItemBuilder<AntDesign.FormValidationMessageItem>
    type ImagePreview' = ImagePreviewBuilder<AntDesign.ImagePreview>
    type ImagePreviewGroup' = ImagePreviewGroupBuilder<AntDesign.ImagePreviewGroup>
    type TreeIndent'<'TItem> = TreeIndentBuilder<AntDesign.TreeIndent<'TItem>, 'TItem>
    type TreeNodeCheckbox'<'TItem> = TreeNodeCheckboxBuilder<AntDesign.TreeNodeCheckbox<'TItem>, 'TItem>
    type TreeNodeSwitcher'<'TItem> = TreeNodeSwitcherBuilder<AntDesign.TreeNodeSwitcher<'TItem>, 'TItem>
    type TreeNodeTitle'<'TItem> = TreeNodeTitleBuilder<AntDesign.TreeNodeTitle<'TItem>, 'TItem>
    type CardLoading' = CardLoadingBuilder<AntDesign.CardLoading>
    type SummaryRow' = SummaryRowBuilder<AntDesign.SummaryRow>
            
namespace AntDesign.Select.Internal

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Select.Internal

    type SelectOptionGroup'<'TItemValue, 'TItem> = SelectOptionGroupBuilder<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
    type SelectContent'<'TItemValue, 'TItem> = SelectContentBuilder<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
            
namespace AntDesign.Internal

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Internal

    type CalendarPanelChooser' = CalendarPanelChooserBuilder<AntDesign.Internal.CalendarPanelChooser>
    type Element' = ElementBuilder<AntDesign.Internal.Element>
    type Overlay' = OverlayBuilder<AntDesign.Internal.Overlay>
    type OverlayTrigger' = OverlayTriggerBuilder<AntDesign.Internal.OverlayTrigger>
    type SubMenuTrigger' = SubMenuTriggerBuilder<AntDesign.Internal.SubMenuTrigger>
    type DatePickerPanelChooser'<'TValue> = DatePickerPanelChooserBuilder<AntDesign.Internal.DatePickerPanelChooser<'TValue>, 'TValue>
    type PickerPanelBase' = PickerPanelBaseBuilder<AntDesign.Internal.PickerPanelBase>
    type DatePickerDatetimePanel'<'TValue> = DatePickerDatetimePanelBuilder<AntDesign.Internal.DatePickerDatetimePanel<'TValue>, 'TValue>
    type DatePickerTemplate'<'TValue> = DatePickerTemplateBuilder<AntDesign.Internal.DatePickerTemplate<'TValue>, 'TValue>
    type DatePickerDatePanel'<'TValue> = DatePickerDatePanelBuilder<AntDesign.Internal.DatePickerDatePanel<'TValue>, 'TValue>
    type DatePickerDecadePanel'<'TValue> = DatePickerDecadePanelBuilder<AntDesign.Internal.DatePickerDecadePanel<'TValue>, 'TValue>
    type DatePickerFooter'<'TValue> = DatePickerFooterBuilder<AntDesign.Internal.DatePickerFooter<'TValue>, 'TValue>
    type DatePickerHeader'<'TValue> = DatePickerHeaderBuilder<AntDesign.Internal.DatePickerHeader<'TValue>, 'TValue>
    type DatePickerMonthPanel'<'TValue> = DatePickerMonthPanelBuilder<AntDesign.Internal.DatePickerMonthPanel<'TValue>, 'TValue>
    type DatePickerQuarterPanel'<'TValue> = DatePickerQuarterPanelBuilder<AntDesign.Internal.DatePickerQuarterPanel<'TValue>, 'TValue>
    type DatePickerYearPanel'<'TValue> = DatePickerYearPanelBuilder<AntDesign.Internal.DatePickerYearPanel<'TValue>, 'TValue>
    type DatePickerInput' = DatePickerInputBuilder<AntDesign.Internal.DatePickerInput>
    type DropdownGroupButton' = DropdownGroupButtonBuilder<AntDesign.Internal.DropdownGroupButton>
    type UploadButton' = UploadButtonBuilder<AntDesign.Internal.UploadButton>
            
namespace AntDesign.statistic

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.statistic

    type StatisticComponentBase'<'T> = StatisticComponentBaseBuilder<AntDesign.statistic.StatisticComponentBase<'T>, 'T>
            
namespace AntDesign.Select

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Select

    type LabelTemplateItem'<'TItemValue, 'TItem> = LabelTemplateItemBuilder<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>, 'TItemValue, 'TItem>
            