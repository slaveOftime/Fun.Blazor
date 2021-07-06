namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type AntComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = AntComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AntComponentBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ConfigProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ConfigProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ConfigProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ConfigProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ConfigProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ConfigProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<AntDesign.ConfigProvider>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ConfigProvider>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ConfigProvider>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ConfigProvider>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ConfigProvider>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ConfigProvider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntDomComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = AntDomComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntDomComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AntDomComponentBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AntDomComponentBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AntDomComponentBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AntDomComponentBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AffixBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AffixBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AffixBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AffixBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AffixBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AffixBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OffsetBottom")>] member this.OffsetBottom (_: FunBlazorContext<AntDesign.Affix>, x: System.Int32) = "OffsetBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetTop")>] member this.OffsetTop (_: FunBlazorContext<AntDesign.Affix>, x: System.Int32) = "OffsetTop" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TargetSelector")>] member this.TargetSelector (_: FunBlazorContext<AntDesign.Affix>, x: System.String) = "TargetSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Affix>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Affix>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Affix>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Affix>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Affix>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Affix>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Affix>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Affix>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Affix>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AlertBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AfterClose")>] member this.AfterClose (_: FunBlazorContext<AntDesign.Alert>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AfterClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Banner")>] member this.Banner (_: FunBlazorContext<AntDesign.Alert>, x: System.Boolean) = "Banner" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<AntDesign.Alert>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseText")>] member this.CloseText (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "CloseText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Alert>, nodes) = Bolero.Html.attr.fragment "Icon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Alert>, x: string) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Alert>, x: int) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Alert>, x: float) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Message")>] member this.Message (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageTemplate")>] member this.MessageTemplate (_: FunBlazorContext<AntDesign.Alert>, nodes) = Bolero.Html.attr.fragment "MessageTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageTemplate")>] member this.MessageTemplate (_: FunBlazorContext<AntDesign.Alert>, x: string) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageTemplate")>] member this.MessageTemplate (_: FunBlazorContext<AntDesign.Alert>, x: int) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MessageTemplate")>] member this.MessageTemplate (_: FunBlazorContext<AntDesign.Alert>, x: float) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowIcon")>] member this.ShowIcon (_: FunBlazorContext<AntDesign.Alert>, x: System.Nullable<System.Boolean>) = "ShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<AntDesign.Alert>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Alert>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Alert>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Alert>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Alert>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Alert>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Alert>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Alert>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AnchorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AnchorBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AnchorBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AnchorBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AnchorBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AnchorBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<AntDesign.Anchor>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Anchor>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Anchor>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Anchor>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Anchor>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Affix")>] member this.Affix (_: FunBlazorContext<AntDesign.Anchor>, x: System.Boolean) = "Affix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bounds")>] member this.Bounds (_: FunBlazorContext<AntDesign.Anchor>, x: System.Int32) = "Bounds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetContainer")>] member this.GetContainer (_: FunBlazorContext<AntDesign.Anchor>, x: System.Func<System.String>) = "GetContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetBottom")>] member this.OffsetBottom (_: FunBlazorContext<AntDesign.Anchor>, x: System.Nullable<System.Int32>) = "OffsetBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetTop")>] member this.OffsetTop (_: FunBlazorContext<AntDesign.Anchor>, x: System.Nullable<System.Int32>) = "OffsetTop" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowInkInFixed")>] member this.ShowInkInFixed (_: FunBlazorContext<AntDesign.Anchor>, x: System.Boolean) = "ShowInkInFixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Anchor>, fn) = (Bolero.Html.attr.callback<System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetCurrentAnchor")>] member this.GetCurrentAnchor (_: FunBlazorContext<AntDesign.Anchor>, x: System.Func<System.String>) = "GetCurrentAnchor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TargetOffset")>] member this.TargetOffset (_: FunBlazorContext<AntDesign.Anchor>, x: System.Nullable<System.Int32>) = "TargetOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Anchor>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Anchor>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Anchor>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Anchor>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Anchor>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AnchorLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AnchorLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AnchorLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AnchorLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AnchorLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AnchorLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AnchorLink>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AnchorLink>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AnchorLink>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AnchorLink>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<AntDesign.AnchorLink>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.AnchorLink>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Target")>] member this.Target (_: FunBlazorContext<AntDesign.AnchorLink>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AnchorLink>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AnchorLink>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AnchorLink>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AnchorLink>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteOptGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelFragment")>] member this.LabelFragment (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, nodes) = Bolero.Html.attr.fragment "LabelFragment" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelFragment")>] member this.LabelFragment (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: string) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelFragment")>] member this.LabelFragment (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: int) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelFragment")>] member this.LabelFragment (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: float) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AutoCompleteOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoCompleteOption>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: System.Object) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoComplete")>] member this.AutoComplete (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: AntDesign.IAutoCompleteRef) = "AutoComplete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AvatarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Avatar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Avatar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Avatar>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Avatar>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Shape")>] member this.Shape (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Src")>] member this.Src (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Src" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SrcSet")>] member this.SrcSet (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "SrcSet" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Alt")>] member this.Alt (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Alt" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnError")>] member this.OnError (_: FunBlazorContext<AntDesign.Avatar>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.ErrorEventArgs> "OnError" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Avatar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Avatar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Avatar>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AvatarGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AvatarGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AvatarGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AvatarGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AvatarGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AvatarGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AvatarGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AvatarGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AvatarGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxCount")>] member this.MaxCount (_: FunBlazorContext<AntDesign.AvatarGroup>, x: System.Int32) = "MaxCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxStyle")>] member this.MaxStyle (_: FunBlazorContext<AntDesign.AvatarGroup>, x: System.String) = "MaxStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxPopoverPlacement")>] member this.MaxPopoverPlacement (_: FunBlazorContext<AntDesign.AvatarGroup>, x: AntDesign.PlacementType) = "MaxPopoverPlacement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AvatarGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AvatarGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AvatarGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AvatarGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BackTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = BackTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BackTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BackTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BackTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BackTopBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.BackTop>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BackTop>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BackTop>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BackTop>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BackTop>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("VisibilityHeight")>] member this.VisibilityHeight (_: FunBlazorContext<AntDesign.BackTop>, x: System.Double) = "VisibilityHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TargetSelector")>] member this.TargetSelector (_: FunBlazorContext<AntDesign.BackTop>, x: System.String) = "TargetSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.BackTop>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.BackTop>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.BackTop>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.BackTop>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.BackTop>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = BadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BadgeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Count")>] member this.Count (_: FunBlazorContext<AntDesign.Badge>, x: System.Nullable<System.Int32>) = "Count" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CountTemplate")>] member this.CountTemplate (_: FunBlazorContext<AntDesign.Badge>, nodes) = Bolero.Html.attr.fragment "CountTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CountTemplate")>] member this.CountTemplate (_: FunBlazorContext<AntDesign.Badge>, x: string) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CountTemplate")>] member this.CountTemplate (_: FunBlazorContext<AntDesign.Badge>, x: int) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CountTemplate")>] member this.CountTemplate (_: FunBlazorContext<AntDesign.Badge>, x: float) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<AntDesign.Badge>, x: System.Boolean) = "Dot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Offset")>] member this.Offset (_: FunBlazorContext<AntDesign.Badge>, x: System.ValueTuple<System.Int32, System.Int32>) = "Offset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverflowCount")>] member this.OverflowCount (_: FunBlazorContext<AntDesign.Badge>, x: System.Int32) = "OverflowCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowZero")>] member this.ShowZero (_: FunBlazorContext<AntDesign.Badge>, x: System.Boolean) = "ShowZero" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Badge>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Badge>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Badge>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Badge>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Badge>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Badge>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Badge>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BadgeRibbonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = BadgeRibbonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BadgeRibbonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BadgeRibbonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BadgeRibbonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BadgeRibbonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTemplate")>] member this.TextTemplate (_: FunBlazorContext<AntDesign.BadgeRibbon>, nodes) = Bolero.Html.attr.fragment "TextTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTemplate")>] member this.TextTemplate (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: string) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTemplate")>] member this.TextTemplate (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: int) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TextTemplate")>] member this.TextTemplate (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: float) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BadgeRibbon>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BreadcrumbBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = BreadcrumbBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BreadcrumbBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BreadcrumbBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BreadcrumbBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BreadcrumbBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Breadcrumb>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Breadcrumb>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Breadcrumb>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Breadcrumb>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoGenerate")>] member this.AutoGenerate (_: FunBlazorContext<AntDesign.Breadcrumb>, x: System.Boolean) = "AutoGenerate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Separator")>] member this.Separator (_: FunBlazorContext<AntDesign.Breadcrumb>, x: System.String) = "Separator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RouteLabel")>] member this.RouteLabel (_: FunBlazorContext<AntDesign.Breadcrumb>, x: System.String) = "RouteLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Breadcrumb>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Breadcrumb>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Breadcrumb>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Breadcrumb>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Block")>] member this.Block (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Block" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Button>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Button>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Button>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Button>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Danger")>] member this.Danger (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Danger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ghost")>] member this.Ghost (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HtmlType")>] member this.HtmlType (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "HtmlType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Button>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClickStopPropagation")>] member this.OnClickStopPropagation (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Shape")>] member this.Shape (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Button>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Button>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Button>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ButtonGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ButtonGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ButtonGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ButtonGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ButtonGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.ButtonGroup>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ButtonGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ButtonGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ButtonGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ButtonGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CalendarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = CalendarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CalendarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Calendar>, x: System.DateTime) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.Calendar>, x: System.DateTime) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValidRange")>] member this.ValidRange (_: FunBlazorContext<AntDesign.Calendar>, x: System.DateTime[]) = "ValidRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<AntDesign.Calendar>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FullScreen")>] member this.FullScreen (_: FunBlazorContext<AntDesign.Calendar>, x: System.Boolean) = "FullScreen" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Calendar>, fn) = (Bolero.Html.attr.callback<System.DateTime> "OnSelect" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Calendar>, fn) = (Bolero.Html.attr.callback<System.DateTime> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderRender")>] member this.HeaderRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>) = "HeaderRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateCellRender")>] member this.DateCellRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateFullCellRender")>] member this.DateFullCellRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateFullCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthFullCellRender")>] member this.MonthFullCellRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthFullCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.Calendar>, x: System.Action<System.DateTime, System.String>) = "OnPanelChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Calendar>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Calendar>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Calendar>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Calendar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Calendar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Calendar>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CardBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Body")>] member this.Body (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "Body" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Body")>] member this.Body (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Body")>] member this.Body (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Body")>] member this.Body (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActionTemplate")>] member this.ActionTemplate (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "ActionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActionTemplate")>] member this.ActionTemplate (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActionTemplate")>] member this.ActionTemplate (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActionTemplate")>] member this.ActionTemplate (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.Card>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hoverable")>] member this.Hoverable (_: FunBlazorContext<AntDesign.Card>, x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Card>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BodyStyle")>] member this.BodyStyle (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Cover")>] member this.Cover (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "Cover" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Cover")>] member this.Cover (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Cover")>] member this.Cover (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Cover")>] member this.Cover (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Actions")>] member this.Actions (_: FunBlazorContext<AntDesign.Card>, x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardTabs")>] member this.CardTabs (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "CardTabs" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardTabs")>] member this.CardTabs (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardTabs")>] member this.CardTabs (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CardTabs")>] member this.CardTabs (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Card>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Card>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Card>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CardActionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CardActionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardActionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardActionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardActionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CardActionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CardAction>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CardAction>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CardAction>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CardAction>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.CardAction>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.CardAction>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.CardAction>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.CardAction>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CardGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CardGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CardGridBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CardGrid>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CardGrid>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CardGrid>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CardGrid>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Hoverable")>] member this.Hoverable (_: FunBlazorContext<AntDesign.CardGrid>, x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.CardGrid>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.CardGrid>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.CardGrid>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.CardGrid>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CarouselBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CarouselBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CarouselBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CarouselBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Carousel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Carousel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Carousel>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Carousel>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DotPosition")>] member this.DotPosition (_: FunBlazorContext<AntDesign.Carousel>, x: System.String) = "DotPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Autoplay")>] member this.Autoplay (_: FunBlazorContext<AntDesign.Carousel>, x: System.TimeSpan) = "Autoplay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Effect")>] member this.Effect (_: FunBlazorContext<AntDesign.Carousel>, x: System.String) = "Effect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Carousel>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Carousel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Carousel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Carousel>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CarouselSlickBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CarouselSlickBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CarouselSlickBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CarouselSlickBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CarouselSlickBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CarouselSlickBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CarouselSlick>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CarouselSlick>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CarouselSlick>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CarouselSlick>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.CarouselSlick>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.CarouselSlick>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CollapseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Accordion")>] member this.Accordion (_: FunBlazorContext<AntDesign.Collapse>, x: System.Boolean) = "Accordion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.Collapse>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIconPosition")>] member this.ExpandIconPosition (_: FunBlazorContext<AntDesign.Collapse>, x: System.String) = "ExpandIconPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveKey")>] member this.DefaultActiveKey (_: FunBlazorContext<AntDesign.Collapse>, x: System.String[]) = "DefaultActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Collapse>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIcon")>] member this.ExpandIcon (_: FunBlazorContext<AntDesign.Collapse>, x: System.String) = "ExpandIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIconTemplate")>] member this.ExpandIconTemplate (_: FunBlazorContext<AntDesign.Collapse>, render: System.Boolean -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ExpandIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Collapse>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Collapse>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Collapse>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Collapse>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Collapse>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Collapse>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Collapse>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Collapse>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = PanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = PanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = PanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = PanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = PanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Active")>] member this.Active (_: FunBlazorContext<AntDesign.Panel>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<AntDesign.Panel>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Panel>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowArrow")>] member this.ShowArrow (_: FunBlazorContext<AntDesign.Panel>, x: System.Boolean) = "ShowArrow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Panel>, x: System.String) = "Extra" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExtraTemplate")>] member this.ExtraTemplate (_: FunBlazorContext<AntDesign.Panel>, nodes) = Bolero.Html.attr.fragment "ExtraTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExtraTemplate")>] member this.ExtraTemplate (_: FunBlazorContext<AntDesign.Panel>, x: string) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExtraTemplate")>] member this.ExtraTemplate (_: FunBlazorContext<AntDesign.Panel>, x: int) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExtraTemplate")>] member this.ExtraTemplate (_: FunBlazorContext<AntDesign.Panel>, x: float) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<AntDesign.Panel>, x: System.String) = "Header" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorContext<AntDesign.Panel>, nodes) = Bolero.Html.attr.fragment "HeaderTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorContext<AntDesign.Panel>, x: string) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorContext<AntDesign.Panel>, x: int) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderTemplate")>] member this.HeaderTemplate (_: FunBlazorContext<AntDesign.Panel>, x: float) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnActiveChange")>] member this.OnActiveChange (_: FunBlazorContext<AntDesign.Panel>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Panel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Panel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Panel>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Panel>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Panel>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Panel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Panel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Panel>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CommentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CommentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CommentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CommentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CommentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CommentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Author")>] member this.Author (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Author" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AuthorTemplate")>] member this.AuthorTemplate (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "AuthorTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AuthorTemplate")>] member this.AuthorTemplate (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AuthorTemplate")>] member this.AuthorTemplate (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AuthorTemplate")>] member this.AuthorTemplate (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Datetime")>] member this.Datetime (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Datetime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DatetimeTemplate")>] member this.DatetimeTemplate (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "DatetimeTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DatetimeTemplate")>] member this.DatetimeTemplate (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DatetimeTemplate")>] member this.DatetimeTemplate (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DatetimeTemplate")>] member this.DatetimeTemplate (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Actions")>] member this.Actions (_: FunBlazorContext<AntDesign.Comment>, x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Comment>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Comment>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Comment>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntContainerComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AntContainerComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AntContainerComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AntContainerComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AntContainerComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AntContainerComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tag")>] member this.Tag (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: System.String) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntInputComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = AntInputComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntInputComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = AutoCompleteBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveFirstOption")>] member this.DefaultActiveFirstOption (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Backfill")>] member this.Backfill (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "Backfill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Collections.Generic.IEnumerable<'TOption>) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OptionDataItems")>] member this.OptionDataItems (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionDataItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectionChange")>] member this.OnSelectionChange (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnSelectionChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnActiveChange")>] member this.OnActiveChange (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelVisibleChange")>] member this.OnPanelVisibleChange (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnPanelVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OptionTemplate")>] member this.OptionTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, render: AntDesign.AutoCompleteDataItem<'TOption> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "OptionTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OptionFormat")>] member this.OptionFormat (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>) = "OptionFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayTemplate")>] member this.OverlayTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, nodes) = Bolero.Html.attr.fragment "OverlayTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayTemplate")>] member this.OverlayTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: string) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayTemplate")>] member this.OverlayTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: int) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayTemplate")>] member this.OverlayTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: float) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CompareWith")>] member this.CompareWith (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Func<System.Object, System.Object, System.Boolean>) = "CompareWith" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FilterExpression")>] member this.FilterExpression (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>) = "FilterExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowFilter")>] member this.AllowFilter (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "AllowFilter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedItem")>] member this.SelectedItem (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: AntDesign.AutoCompleteOption) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPanel")>] member this.ShowPanel (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "ShowPanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CascaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = CascaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CascaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.Cascader>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeOnSelect")>] member this.ChangeOnSelect (_: FunBlazorContext<AntDesign.Cascader>, x: System.Boolean) = "ChangeOnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandTrigger")>] member this.ExpandTrigger (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "ExpandTrigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "NotFoundContent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSearch")>] member this.ShowSearch (_: FunBlazorContext<AntDesign.Cascader>, x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Cascader>, x: System.Action<System.Collections.Generic.List<AntDesign.CascaderNode>, System.String, System.String>) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedNodesChanged")>] member this.SelectedNodesChanged (_: FunBlazorContext<AntDesign.Cascader>, fn) = (Bolero.Html.attr.callback<AntDesign.CascaderNode[]> "SelectedNodesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<AntDesign.Cascader>, x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.Cascader>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.Cascader>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.Cascader>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Cascader>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Cascader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Cascader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Cascader>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CheckboxGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = CheckboxGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CheckboxGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CheckboxGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CheckboxGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CheckboxGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CheckboxGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: OneOf.OneOf<AntDesign.CheckboxOption[], System.String[]>) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MixedMode")>] member this.MixedMode (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: AntDesign.CheckboxGroupMixedMode) = "MixedMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.CheckboxGroup>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.String[]) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.CheckboxGroup>, fn) = (Bolero.Html.attr.callback<System.String[]> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.Linq.Expressions.Expression<System.Func<System.String[]>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String[]>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntInputBoolComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Boolean) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = CheckboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CheckboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CheckboxBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CheckboxBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CheckboxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Checkbox>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Checkbox>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Checkbox>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Checkbox>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChange")>] member this.CheckedChange (_: FunBlazorContext<AntDesign.Checkbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedExpression")>] member this.CheckedExpression (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "CheckedExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<AntDesign.Checkbox>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Checkbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<AntDesign.Checkbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.Checkbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Checkbox>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Checkbox>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Checkbox>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Checkbox>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Checkbox>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = SwitchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SwitchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildren")>] member this.CheckedChildren (_: FunBlazorContext<AntDesign.Switch>, x: System.String) = "CheckedChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildrenTemplate")>] member this.CheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, nodes) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildrenTemplate")>] member this.CheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: string) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildrenTemplate")>] member this.CheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: int) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChildrenTemplate")>] member this.CheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: float) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Control")>] member this.Control (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Control" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Switch>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildren")>] member this.UnCheckedChildren (_: FunBlazorContext<AntDesign.Switch>, x: System.String) = "UnCheckedChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildrenTemplate")>] member this.UnCheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, nodes) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildrenTemplate")>] member this.UnCheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: string) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildrenTemplate")>] member this.UnCheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: int) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnCheckedChildrenTemplate")>] member this.UnCheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: float) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Switch>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<AntDesign.Switch>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.Switch>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.Switch>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.Switch>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Switch>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Switch>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Switch>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Switch>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Switch>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Switch>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = DatePickerBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = DatePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MonthPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = MonthPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MonthPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type QuarterPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = QuarterPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = QuarterPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type WeekPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = WeekPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = WeekPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type YearPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = YearPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = YearPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = TimePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TimePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = RangePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RangePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateRangeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputReadOnly")>] member this.InputReadOnly (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupStyle")>] member this.PopupStyle (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClassName")>] member this.ClassName (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownClassName")>] member this.DropdownClassName (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPickerValue")>] member this.DefaultPickerValue (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPanelChange")>] member this.OnPanelChange (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type InputNumberBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputNumberBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputNumberBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Formatter")>] member this.Formatter (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Func<'TValue, System.String>) = "Formatter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Parser")>] member this.Parser (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Func<System.String, System.String>) = "Parser" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type InputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.Input<'TValue>>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.Input<'TValue>>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceMilliseconds")>] member this.DebounceMilliseconds (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputElementSuffixClass")>] member this.InputElementSuffixClass (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxLength")>] member this.MaxLength (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyDown")>] member this.OnkeyDown (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyUp")>] member this.OnkeyUp (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseUp")>] member this.OnMouseUp (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPressEnter")>] member this.OnPressEnter (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Input<'TValue>>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Input<'TValue>>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperStyle")>] member this.WrapperStyle (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = AutoCompleteInputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceMilliseconds")>] member this.DebounceMilliseconds (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputElementSuffixClass")>] member this.InputElementSuffixClass (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxLength")>] member this.MaxLength (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyDown")>] member this.OnkeyDown (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyUp")>] member this.OnkeyUp (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseUp")>] member this.OnMouseUp (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPressEnter")>] member this.OnPressEnter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperStyle")>] member this.WrapperStyle (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type InputPasswordBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = InputPasswordBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputPasswordBuilder<'FunBlazorGeneric>()

    [<CustomOperation("IconRender")>] member this.IconRender (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "IconRender" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconRender")>] member this.IconRender (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconRender")>] member this.IconRender (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconRender")>] member this.IconRender (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPassword")>] member this.ShowPassword (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "ShowPassword" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("VisibilityToggle")>] member this.VisibilityToggle (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "VisibilityToggle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceMilliseconds")>] member this.DebounceMilliseconds (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputElementSuffixClass")>] member this.InputElementSuffixClass (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxLength")>] member this.MaxLength (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyDown")>] member this.OnkeyDown (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyUp")>] member this.OnkeyUp (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseUp")>] member this.OnMouseUp (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPressEnter")>] member this.OnPressEnter (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperStyle")>] member this.WrapperStyle (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.InputPassword>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.InputPassword>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.InputPassword>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = SearchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SearchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ClassicSearchIcon")>] member this.ClassicSearchIcon (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EnterButton")>] member this.EnterButton (_: FunBlazorContext<AntDesign.Search>, x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.Search>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.Search>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.Search>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.Search>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.Search>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.Search>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.Search>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.Search>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceMilliseconds")>] member this.DebounceMilliseconds (_: FunBlazorContext<AntDesign.Search>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputElementSuffixClass")>] member this.InputElementSuffixClass (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxLength")>] member this.MaxLength (_: FunBlazorContext<AntDesign.Search>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyDown")>] member this.OnkeyDown (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyUp")>] member this.OnkeyUp (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseUp")>] member this.OnMouseUp (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPressEnter")>] member this.OnPressEnter (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Search>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Search>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Search>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Search>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Search>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Search>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Search>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Search>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperStyle")>] member this.WrapperStyle (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.Search>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.Search>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Search>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Search>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Search>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Search>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = AutoCompleteSearchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteSearchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ClassicSearchIcon")>] member this.ClassicSearchIcon (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EnterButton")>] member this.EnterButton (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceMilliseconds")>] member this.DebounceMilliseconds (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputElementSuffixClass")>] member this.InputElementSuffixClass (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxLength")>] member this.MaxLength (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyDown")>] member this.OnkeyDown (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyUp")>] member this.OnkeyUp (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseUp")>] member this.OnMouseUp (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPressEnter")>] member this.OnPressEnter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperStyle")>] member this.WrapperStyle (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = TextAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TextAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AutoSize")>] member this.AutoSize (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "AutoSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultToEmptyString")>] member this.DefaultToEmptyString (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "DefaultToEmptyString" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxRows")>] member this.MaxRows (_: FunBlazorContext<AntDesign.TextArea>, x: System.UInt32) = "MaxRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MinRows")>] member this.MinRows (_: FunBlazorContext<AntDesign.TextArea>, x: System.UInt32) = "MinRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnResize")>] member this.OnResize (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<AntDesign.OnResizeEventArgs> "OnResize" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowCount")>] member this.ShowCount (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "ShowCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.TextArea>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.TextArea>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.TextArea>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnBefore")>] member this.AddOnBefore (_: FunBlazorContext<AntDesign.TextArea>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.TextArea>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.TextArea>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.TextArea>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AddOnAfter")>] member this.AddOnAfter (_: FunBlazorContext<AntDesign.TextArea>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DebounceMilliseconds")>] member this.DebounceMilliseconds (_: FunBlazorContext<AntDesign.TextArea>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InputElementSuffixClass")>] member this.InputElementSuffixClass (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxLength")>] member this.MaxLength (_: FunBlazorContext<AntDesign.TextArea>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyDown")>] member this.OnkeyDown (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnkeyUp")>] member this.OnkeyUp (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseUp")>] member this.OnMouseUp (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPressEnter")>] member this.OnPressEnter (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.TextArea>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.TextArea>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.TextArea>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.TextArea>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.TextArea>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.TextArea>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.TextArea>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.TextArea>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperStyle")>] member this.WrapperStyle (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.TextArea>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.TextArea>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.TextArea>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.TextArea>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.TextArea>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.TextArea>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RadioGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    new (x: string) as this = RadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RadioGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RadioGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = RadioGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonStyle")>] member this.ButtonStyle (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.String) = "ButtonStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = SelectBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SelectBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoClearSearchValue")>] member this.AutoClearSearchValue (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateCustomTag")>] member this.OnCreateCustomTag (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveFirstOption")>] member this.DefaultActiveFirstOption (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledName")>] member this.DisabledName (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "DisabledName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownRender")>] member this.DropdownRender (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EnableSearch")>] member this.EnableSearch (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GroupName")>] member this.GroupName (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "GroupName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSelected")>] member this.HideSelected (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreItemChanges")>] member this.IgnoreItemChanges (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelInValue")>] member this.LabelInValue (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelName")>] member this.LabelName (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "LabelName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagTextLength")>] member this.MaxTagTextLength (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagCount")>] member this.MaxTagCount (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagPlaceholder")>] member this.MaxTagPlaceholder (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, render: System.Collections.Generic.IEnumerable<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "MaxTagPlaceholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, nodes) = Bolero.Html.attr.fragment "NotFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: int) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: float) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnBlur" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearSelected")>] member this.OnClearSelected (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDataSourceChanged")>] member this.OnDataSourceChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDropdownVisibleChange")>] member this.OnDropdownVisibleChange (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectedItemChanged")>] member this.OnSelectedItemChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<'TItem>) = "OnSelectedItemChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectedItemsChanged")>] member this.OnSelectedItemsChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<System.Collections.Generic.IEnumerable<'TItem>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerMaxHeight")>] member this.PopupContainerMaxHeight (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownMatchSelectWidth")>] member this.DropdownMatchSelectWidth (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownMaxWidth")>] member this.DropdownMaxWidth (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowArrowIcon")>] member this.ShowArrowIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSearchIcon")>] member this.ShowSearchIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortByGroup")>] member this.SortByGroup (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortByLabel")>] member this.SortByLabel (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, nodes) = Bolero.Html.attr.fragment "PrefixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: int) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: float) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TokenSeparators")>] member this.TokenSeparators (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Char[]) = "TokenSeparators" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<'TItemValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueName")>] member this.ValueName (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "ValueName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesChanged")>] member this.ValuesChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItemValue>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomTagLabelToValue")>] member this.CustomTagLabelToValue (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Func<System.String, 'TItemValue>) = "CustomTagLabelToValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: 'TItemValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: 'TItemValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Values")>] member this.Values (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Collections.Generic.IEnumerable<'TItemValue>) = "Values" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValues")>] member this.DefaultValues (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Collections.Generic.IEnumerable<'TItemValue>) = "DefaultValues" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, nodes) = Bolero.Html.attr.fragment "SelectOptions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: int) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: float) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Linq.Expressions.Expression<System.Func<'TItemValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TItemValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SimpleSelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = SimpleSelectBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SimpleSelectBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoClearSearchValue")>] member this.AutoClearSearchValue (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCreateCustomTag")>] member this.OnCreateCustomTag (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveFirstOption")>] member this.DefaultActiveFirstOption (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledName")>] member this.DisabledName (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "DisabledName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownRender")>] member this.DropdownRender (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EnableSearch")>] member this.EnableSearch (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GroupName")>] member this.GroupName (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "GroupName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideSelected")>] member this.HideSelected (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IgnoreItemChanges")>] member this.IgnoreItemChanges (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemTemplate")>] member this.ItemTemplate (_: FunBlazorContext<AntDesign.SimpleSelect>, render: System.String -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelInValue")>] member this.LabelInValue (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelName")>] member this.LabelName (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "LabelName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<AntDesign.SimpleSelect>, render: System.String -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagTextLength")>] member this.MaxTagTextLength (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagCount")>] member this.MaxTagCount (_: FunBlazorContext<AntDesign.SimpleSelect>, x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxTagPlaceholder")>] member this.MaxTagPlaceholder (_: FunBlazorContext<AntDesign.SimpleSelect>, render: System.Collections.Generic.IEnumerable<System.String> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "MaxTagPlaceholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.SimpleSelect>, nodes) = Bolero.Html.attr.fragment "NotFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.SimpleSelect>, x: int) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NotFoundContent")>] member this.NotFoundContent (_: FunBlazorContext<AntDesign.SimpleSelect>, x: float) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnBlur" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearSelected")>] member this.OnClearSelected (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDataSourceChanged")>] member this.OnDataSourceChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDropdownVisibleChange")>] member this.OnDropdownVisibleChange (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectedItemChanged")>] member this.OnSelectedItemChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.String>) = "OnSelectedItemChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectedItemsChanged")>] member this.OnSelectedItemsChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.Collections.Generic.IEnumerable<System.String>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Open")>] member this.Open (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerMaxHeight")>] member this.PopupContainerMaxHeight (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownMatchSelectWidth")>] member this.DropdownMatchSelectWidth (_: FunBlazorContext<AntDesign.SimpleSelect>, x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DropdownMaxWidth")>] member this.DropdownMaxWidth (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowArrowIcon")>] member this.ShowArrowIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSearchIcon")>] member this.ShowSearchIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortByGroup")>] member this.SortByGroup (_: FunBlazorContext<AntDesign.SimpleSelect>, x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortByLabel")>] member this.SortByLabel (_: FunBlazorContext<AntDesign.SimpleSelect>, x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, nodes) = Bolero.Html.attr.fragment "PrefixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: int) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixIcon")>] member this.PrefixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: float) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TokenSeparators")>] member this.TokenSeparators (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Char[]) = "TokenSeparators" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueName")>] member this.ValueName (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "ValueName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesChanged")>] member this.ValuesChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CustomTagLabelToValue")>] member this.CustomTagLabelToValue (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Func<System.String, System.String>) = "CustomTagLabelToValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Collections.Generic.IEnumerable<System.String>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Values")>] member this.Values (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Collections.Generic.IEnumerable<System.String>) = "Values" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValues")>] member this.DefaultValues (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultValues" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<AntDesign.SimpleSelect>, nodes) = Bolero.Html.attr.fragment "SelectOptions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<AntDesign.SimpleSelect>, x: int) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectOptions")>] member this.SelectOptions (_: FunBlazorContext<AntDesign.SimpleSelect>, x: float) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.SimpleSelect>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.SimpleSelect>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SliderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = SliderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SliderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dots")>] member this.Dots (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Dots" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Included")>] member this.Included (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Included" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Marks")>] member this.Marks (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: AntDesign.SliderMark[]) = "Marks" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Max")>] member this.Max (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Min")>] member this.Min (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Reverse")>] member this.Reverse (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Reverse" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Step")>] member this.Step (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Nullable<System.Double>) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Vertical")>] member this.Vertical (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Vertical" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAfterChange")>] member this.OnAfterChange (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Action<'TValue>) = "OnAfterChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Action<'TValue>) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HasTooltip")>] member this.HasTooltip (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "HasTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TipFormatter")>] member this.TipFormatter (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Func<System.Double, System.String>) = "TipFormatter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipPlacement")>] member this.TooltipPlacement (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: AntDesign.PlacementType) = "TooltipPlacement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TooltipVisible")>] member this.TooltipVisible (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "TooltipVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetTooltipPopupContainer")>] member this.GetTooltipPopupContainer (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Object) = "GetTooltipPopupContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.Slider<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueExpression")>] member this.ValueExpression (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValuesExpression")>] member this.ValuesExpression (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DescriptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = DescriptionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DescriptionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DescriptionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DescriptionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DescriptionsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.Descriptions>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Layout")>] member this.Layout (_: FunBlazorContext<AntDesign.Descriptions>, x: System.String) = "Layout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Column")>] member this.Column (_: FunBlazorContext<AntDesign.Descriptions>, x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>) = "Column" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Descriptions>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Descriptions>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Descriptions>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Descriptions>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Descriptions>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Descriptions>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Colon")>] member this.Colon (_: FunBlazorContext<AntDesign.Descriptions>, x: System.Boolean) = "Colon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Descriptions>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Descriptions>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Descriptions>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Descriptions>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Descriptions>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Descriptions>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Descriptions>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Descriptions>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DescriptionsItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = DescriptionsItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DescriptionsItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DescriptionsItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DescriptionsItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DescriptionsItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.DescriptionsItem>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Span")>] member this.Span (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: System.Int32) = "Span" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DescriptionsItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = DividerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DividerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DividerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DividerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DividerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Divider>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Divider>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Divider>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Divider>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Text")>] member this.Text (_: FunBlazorContext<AntDesign.Divider>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Plain")>] member this.Plain (_: FunBlazorContext<AntDesign.Divider>, x: System.Boolean) = "Plain" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Divider>, x: AntDesign.DirectionVHType) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Orientation")>] member this.Orientation (_: FunBlazorContext<AntDesign.Divider>, x: System.String) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dashed")>] member this.Dashed (_: FunBlazorContext<AntDesign.Divider>, x: System.Boolean) = "Dashed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Divider>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Divider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Divider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Divider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = DrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DrawerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Drawer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Drawer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Drawer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Drawer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<AntDesign.Drawer>, x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaskClosable")>] member this.MaskClosable (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mask")>] member this.Mask (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "Mask" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoAnimation")>] member this.NoAnimation (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "NoAnimation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Drawer>, x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaskStyle")>] member this.MaskStyle (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "MaskStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BodyStyle")>] member this.BodyStyle (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapClassName")>] member this.WrapClassName (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "WrapClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ZIndex")>] member this.ZIndex (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetX")>] member this.OffsetX (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OffsetY")>] member this.OffsetY (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<AntDesign.Drawer>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Handler")>] member this.Handler (_: FunBlazorContext<AntDesign.Drawer>, nodes) = Bolero.Html.attr.fragment "Handler" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Handler")>] member this.Handler (_: FunBlazorContext<AntDesign.Drawer>, x: string) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Handler")>] member this.Handler (_: FunBlazorContext<AntDesign.Drawer>, x: int) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Handler")>] member this.Handler (_: FunBlazorContext<AntDesign.Drawer>, x: float) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Drawer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Drawer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Drawer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DrawerContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DrawerContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.DrawerContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.DrawerContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.DrawerContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.DrawerContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type EmptyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = EmptyBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = EmptyBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = EmptyBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = EmptyBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = EmptyBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Empty>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageStyle")>] member this.ImageStyle (_: FunBlazorContext<AntDesign.Empty>, x: System.String) = "ImageStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Small")>] member this.Small (_: FunBlazorContext<AntDesign.Empty>, x: System.Boolean) = "Small" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Simple")>] member this.Simple (_: FunBlazorContext<AntDesign.Empty>, x: System.Boolean) = "Simple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Empty>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Empty>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Empty>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Empty>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<AntDesign.Empty>, x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.Empty>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.Empty>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.Empty>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.Empty>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Image")>] member this.Image (_: FunBlazorContext<AntDesign.Empty>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageTemplate")>] member this.ImageTemplate (_: FunBlazorContext<AntDesign.Empty>, nodes) = Bolero.Html.attr.fragment "ImageTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageTemplate")>] member this.ImageTemplate (_: FunBlazorContext<AntDesign.Empty>, x: string) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageTemplate")>] member this.ImageTemplate (_: FunBlazorContext<AntDesign.Empty>, x: int) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ImageTemplate")>] member this.ImageTemplate (_: FunBlazorContext<AntDesign.Empty>, x: float) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Empty>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Empty>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Empty>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Empty>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = FormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = FormBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Layout")>] member this.Layout (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.String) = "Layout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Form<'TModel>>, render: 'TModel -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelCol")>] member this.LabelCol (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelAlign")>] member this.LabelAlign (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelColSpan")>] member this.LabelColSpan (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelColOffset")>] member this.LabelColOffset (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperCol")>] member this.WrapperCol (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperColSpan")>] member this.WrapperColSpan (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperColOffset")>] member this.WrapperColOffset (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Model")>] member this.Model (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: 'TModel) = "Model" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFinish")>] member this.OnFinish (_: FunBlazorContext<AntDesign.Form<'TModel>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinish" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFinishFailed")>] member this.OnFinishFailed (_: FunBlazorContext<AntDesign.Form<'TModel>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinishFailed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validator")>] member this.Validator (_: FunBlazorContext<AntDesign.Form<'TModel>>, nodes) = Bolero.Html.attr.fragment "Validator" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validator")>] member this.Validator (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: string) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validator")>] member this.Validator (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: int) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Validator")>] member this.Validator (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: float) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValidateOnChange")>] member this.ValidateOnChange (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.Boolean) = "ValidateOnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FormItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = FormItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FormItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FormItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FormItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = FormItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.FormItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.FormItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.FormItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.FormItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<AntDesign.FormItem>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<AntDesign.FormItem>, nodes) = Bolero.Html.attr.fragment "LabelTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<AntDesign.FormItem>, x: string) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<AntDesign.FormItem>, x: int) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelTemplate")>] member this.LabelTemplate (_: FunBlazorContext<AntDesign.FormItem>, x: float) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelCol")>] member this.LabelCol (_: FunBlazorContext<AntDesign.FormItem>, x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelAlign")>] member this.LabelAlign (_: FunBlazorContext<AntDesign.FormItem>, x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelColSpan")>] member this.LabelColSpan (_: FunBlazorContext<AntDesign.FormItem>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelColOffset")>] member this.LabelColOffset (_: FunBlazorContext<AntDesign.FormItem>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperCol")>] member this.WrapperCol (_: FunBlazorContext<AntDesign.FormItem>, x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperColSpan")>] member this.WrapperColSpan (_: FunBlazorContext<AntDesign.FormItem>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperColOffset")>] member this.WrapperColOffset (_: FunBlazorContext<AntDesign.FormItem>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoStyle")>] member this.NoStyle (_: FunBlazorContext<AntDesign.FormItem>, x: System.Boolean) = "NoStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Required")>] member this.Required (_: FunBlazorContext<AntDesign.FormItem>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.FormItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.FormItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.FormItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.FormItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ColBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ColBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Col>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Col>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Col>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Col>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Flex")>] member this.Flex (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Span")>] member this.Span (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Order")>] member this.Order (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Offset")>] member this.Offset (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Push")>] member this.Push (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Pull")>] member this.Pull (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xs")>] member this.Xs (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Sm")>] member this.Sm (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Md")>] member this.Md (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lg")>] member this.Lg (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xl")>] member this.Xl (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xxl")>] member this.Xxl (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Col>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Col>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Col>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Col>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type GridColBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = GridColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = GridColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = GridColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = GridColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = GridColBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.GridCol>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.GridCol>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.GridCol>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.GridCol>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Flex")>] member this.Flex (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Span")>] member this.Span (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Order")>] member this.Order (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Offset")>] member this.Offset (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Push")>] member this.Push (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Pull")>] member this.Pull (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xs")>] member this.Xs (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Sm")>] member this.Sm (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Md")>] member this.Md (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Lg")>] member this.Lg (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xl")>] member this.Xl (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Xxl")>] member this.Xxl (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.GridCol>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.GridCol>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.GridCol>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.GridCol>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = RowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = RowBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Row>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Row>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Row>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Row>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Row>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Align")>] member this.Align (_: FunBlazorContext<AntDesign.Row>, x: System.String) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Justify")>] member this.Justify (_: FunBlazorContext<AntDesign.Row>, x: System.String) = "Justify" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Wrap")>] member this.Wrap (_: FunBlazorContext<AntDesign.Row>, x: System.Boolean) = "Wrap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Gutter")>] member this.Gutter (_: FunBlazorContext<AntDesign.Row>, x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Collections.Generic.Dictionary<System.String, System.Int32>>>) = "Gutter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBreakpoint")>] member this.OnBreakpoint (_: FunBlazorContext<AntDesign.Row>, fn) = (Bolero.Html.attr.callback<AntDesign.BreakpointType> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultBreakpoint")>] member this.DefaultBreakpoint (_: FunBlazorContext<AntDesign.Row>, x: AntDesign.BreakpointType) = "DefaultBreakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Row>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Row>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Row>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Row>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type IconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = IconBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = IconBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Spin")>] member this.Spin (_: FunBlazorContext<AntDesign.Icon>, x: System.Boolean) = "Spin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rotate")>] member this.Rotate (_: FunBlazorContext<AntDesign.Icon>, x: System.Int32) = "Rotate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TwotoneColor")>] member this.TwotoneColor (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "TwotoneColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconFont")>] member this.IconFont (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "IconFont" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fill")>] member this.Fill (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Fill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabIndex")>] member this.TabIndex (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "TabIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StopPropagation")>] member this.StopPropagation (_: FunBlazorContext<AntDesign.Icon>, x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Icon>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<AntDesign.Icon>, nodes) = Bolero.Html.attr.fragment "Component" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<AntDesign.Icon>, x: string) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<AntDesign.Icon>, x: int) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<AntDesign.Icon>, x: float) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Icon>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Icon>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Icon>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type IconFontBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = IconFontBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = IconFontBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Spin")>] member this.Spin (_: FunBlazorContext<AntDesign.IconFont>, x: System.Boolean) = "Spin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rotate")>] member this.Rotate (_: FunBlazorContext<AntDesign.IconFont>, x: System.Int32) = "Rotate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TwotoneColor")>] member this.TwotoneColor (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "TwotoneColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconFont")>] member this.IconFont (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "IconFont" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fill")>] member this.Fill (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Fill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabIndex")>] member this.TabIndex (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "TabIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StopPropagation")>] member this.StopPropagation (_: FunBlazorContext<AntDesign.IconFont>, x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.IconFont>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<AntDesign.IconFont>, nodes) = Bolero.Html.attr.fragment "Component" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<AntDesign.IconFont>, x: string) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<AntDesign.IconFont>, x: int) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Component")>] member this.Component (_: FunBlazorContext<AntDesign.IconFont>, x: float) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.IconFont>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.IconFont>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.IconFont>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ImageBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ImageBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Alt")>] member this.Alt (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Alt" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fallback")>] member this.Fallback (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Fallback" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Height")>] member this.Height (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Image>, nodes) = Bolero.Html.attr.fragment "Placeholder" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Image>, x: string) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Image>, x: int) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Image>, x: float) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Preview")>] member this.Preview (_: FunBlazorContext<AntDesign.Image>, x: System.Boolean) = "Preview" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Src")>] member this.Src (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Src" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PreviewSrc")>] member this.PreviewSrc (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "PreviewSrc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Image>, x: AntDesign.ImageLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Image>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Image>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Image>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ImagePreviewContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ImagePreviewContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ImagePreviewContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ImagePreviewContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ImagePreviewContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ImagePreviewContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type InputGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = InputGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = InputGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = InputGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = InputGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = InputGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.InputGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.InputGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.InputGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.InputGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Compact")>] member this.Compact (_: FunBlazorContext<AntDesign.InputGroup>, x: System.Boolean) = "Compact" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.InputGroup>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.InputGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.InputGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.InputGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.InputGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SiderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SiderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SiderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SiderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SiderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SiderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Collapsible")>] member this.Collapsible (_: FunBlazorContext<AntDesign.Sider>, x: System.Boolean) = "Collapsible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Sider>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Sider>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Sider>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Sider>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Sider>, nodes) = Bolero.Html.attr.fragment "Trigger" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Sider>, x: string) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Sider>, x: int) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Sider>, x: float) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoTrigger")>] member this.NoTrigger (_: FunBlazorContext<AntDesign.Sider>, x: System.Boolean) = "NoTrigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorContext<AntDesign.Sider>, x: AntDesign.BreakpointType) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<AntDesign.Sider>, x: AntDesign.SiderTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.Sider>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CollapsedWidth")>] member this.CollapsedWidth (_: FunBlazorContext<AntDesign.Sider>, x: System.Int32) = "CollapsedWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Collapsed")>] member this.Collapsed (_: FunBlazorContext<AntDesign.Sider>, x: System.Boolean) = "Collapsed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCollapse")>] member this.OnCollapse (_: FunBlazorContext<AntDesign.Sider>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBreakpoint")>] member this.OnBreakpoint (_: FunBlazorContext<AntDesign.Sider>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Sider>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Sider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Sider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Sider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = AntListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AntListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AntListBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AntListBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AntListBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<AntDesign.AntList<'TItem>>, nodes) = Bolero.Html.attr.fragment "Header" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: string) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: int) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Header")>] member this.Header (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: float) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<AntDesign.AntList<'TItem>>, nodes) = Bolero.Html.attr.fragment "Footer" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: string) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: int) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: float) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadMore")>] member this.LoadMore (_: FunBlazorContext<AntDesign.AntList<'TItem>>, nodes) = Bolero.Html.attr.fragment "LoadMore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadMore")>] member this.LoadMore (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: string) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadMore")>] member this.LoadMore (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: int) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LoadMore")>] member this.LoadMore (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: float) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemLayout")>] member this.ItemLayout (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: AntDesign.ListItemLayout) = "ItemLayout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoResult")>] member this.NoResult (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.String) = "NoResult" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.Boolean) = "Split" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnItemClick")>] member this.OnItemClick (_: FunBlazorContext<AntDesign.AntList<'TItem>>, fn) = (Bolero.Html.attr.callback<'TItem> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Grid")>] member this.Grid (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Pagination")>] member this.Pagination (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: AntDesign.PaginationOptions) = "Pagination" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.AntList<'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ListItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<AntDesign.ListItem>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.ListItem>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.ListItem>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.ListItem>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.ListItem>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Actions")>] member this.Actions (_: FunBlazorContext<AntDesign.ListItem>, x: Microsoft.AspNetCore.Components.RenderFragment[]) = "Actions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Grid")>] member this.Grid (_: FunBlazorContext<AntDesign.ListItem>, x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ListItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ListItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ListItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ListItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColStyle")>] member this.ColStyle (_: FunBlazorContext<AntDesign.ListItem>, x: System.String) = "ColStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemCount")>] member this.ItemCount (_: FunBlazorContext<AntDesign.ListItem>, x: System.Int32) = "ItemCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.ListItem>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFlex")>] member this.NoFlex (_: FunBlazorContext<AntDesign.ListItem>, x: System.Boolean) = "NoFlex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ListItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ListItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ListItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ListItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ListItemMetaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ListItemMetaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ListItemMetaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.ListItemMeta>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<AntDesign.ListItemMeta>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<AntDesign.ListItemMeta>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ListItemMeta>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ListItemMeta>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ListItemMeta>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ListItemMeta>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MentionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MentionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MentionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MentionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MentionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MentionsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.Mentions>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disable")>] member this.Disable (_: FunBlazorContext<AntDesign.Mentions>, x: System.Boolean) = "Disable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Readonly")>] member this.Readonly (_: FunBlazorContext<AntDesign.Mentions>, x: System.Boolean) = "Readonly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Split" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Rows")>] member this.Rows (_: FunBlazorContext<AntDesign.Mentions>, x: System.Int32) = "Rows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Mentions>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Mentions>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Mentions>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Mentions>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Mentions>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChange")>] member this.ValueChange (_: FunBlazorContext<AntDesign.Mentions>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.Mentions>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.Mentions>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<AntDesign.Mentions>, fn) = (Bolero.Html.attr.callback<System.EventArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFoundContent")>] member this.NoFoundContent (_: FunBlazorContext<AntDesign.Mentions>, nodes) = Bolero.Html.attr.fragment "NoFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFoundContent")>] member this.NoFoundContent (_: FunBlazorContext<AntDesign.Mentions>, x: string) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFoundContent")>] member this.NoFoundContent (_: FunBlazorContext<AntDesign.Mentions>, x: int) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NoFoundContent")>] member this.NoFoundContent (_: FunBlazorContext<AntDesign.Mentions>, x: float) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Mentions>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Mentions>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Mentions>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MentionsOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MentionsOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MentionsOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MentionsOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MentionsOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MentionsOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.MentionsOption>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disable")>] member this.Disable (_: FunBlazorContext<AntDesign.MentionsOption>, x: System.Boolean) = "Disable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MentionsOption>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MentionsOption>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MentionsOption>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MentionsOption>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.MentionsOption>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.MentionsOption>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.MentionsOption>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.MentionsOption>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorContext<AntDesign.Menu>, x: AntDesign.MenuTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<AntDesign.Menu>, x: AntDesign.MenuMode) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Menu>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Menu>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Menu>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Menu>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSubmenuClicked")>] member this.OnSubmenuClicked (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<AntDesign.SubMenu> "OnSubmenuClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMenuItemClicked")>] member this.OnMenuItemClicked (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<AntDesign.MenuItem> "OnMenuItemClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Accordion")>] member this.Accordion (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "Accordion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Selectable")>] member this.Selectable (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "Selectable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Multiple")>] member this.Multiple (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineCollapsed")>] member this.InlineCollapsed (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "InlineCollapsed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineIndent")>] member this.InlineIndent (_: FunBlazorContext<AntDesign.Menu>, x: System.Int32) = "InlineIndent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoCloseDropdown")>] member this.AutoCloseDropdown (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "AutoCloseDropdown" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultSelectedKeys")>] member this.DefaultSelectedKeys (_: FunBlazorContext<AntDesign.Menu>, x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultSelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultOpenKeys")>] member this.DefaultOpenKeys (_: FunBlazorContext<AntDesign.Menu>, x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultOpenKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenKeys")>] member this.OpenKeys (_: FunBlazorContext<AntDesign.Menu>, x: System.String[]) = "OpenKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OpenKeysChanged")>] member this.OpenKeysChanged (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<System.String[]> "OpenKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeys")>] member this.SelectedKeys (_: FunBlazorContext<AntDesign.Menu>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeysChanged")>] member this.SelectedKeysChanged (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerSubMenuAction")>] member this.TriggerSubMenuAction (_: FunBlazorContext<AntDesign.Menu>, x: AntDesign.TriggerType) = "TriggerSubMenuAction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Menu>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Menu>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Menu>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Menu>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MenuItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.MenuItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.MenuItem>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RouterLink")>] member this.RouterLink (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "RouterLink" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RouterMatch")>] member this.RouterMatch (_: FunBlazorContext<AntDesign.MenuItem>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "RouterMatch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.MenuItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.MenuItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.MenuItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuItemGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MenuItemGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuItemGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuItemGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuItemGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MenuItemGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.MenuItemGroup>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuItemGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = MenuLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MenuLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ActiveClass")>] member this.ActiveClass (_: FunBlazorContext<AntDesign.MenuLink>, x: System.String) = "ActiveClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Href")>] member this.Href (_: FunBlazorContext<AntDesign.MenuLink>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuLink>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuLink>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuLink>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.MenuLink>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Attributes")>] member this.Attributes (_: FunBlazorContext<AntDesign.MenuLink>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Match")>] member this.Match (_: FunBlazorContext<AntDesign.MenuLink>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.MenuLink>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.MenuLink>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.MenuLink>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.MenuLink>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SubMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SubMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SubMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SubMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SubMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SubMenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.SubMenu>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.SubMenu>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.SubMenu>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.SubMenu>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.SubMenu>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.SubMenu>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SubMenu>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SubMenu>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SubMenu>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SubMenu>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<AntDesign.SubMenu>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.SubMenu>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsOpen")>] member this.IsOpen (_: FunBlazorContext<AntDesign.SubMenu>, x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTitleClick")>] member this.OnTitleClick (_: FunBlazorContext<AntDesign.SubMenu>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.SubMenu>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.SubMenu>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.SubMenu>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.SubMenu>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MessageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MessageBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MessageBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Message>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Message>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Message>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Message>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MessageItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MessageItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MessageItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.MessageItem>, x: AntDesign.MessageConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.MessageItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.MessageItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.MessageItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.MessageItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ComfirmContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ComfirmContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ComfirmContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ComfirmContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ComfirmContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ComfirmContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ComfirmContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ConfirmBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ConfirmBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ConfirmBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Confirm>, x: AntDesign.ConfirmOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ConfirmRef")>] member this.ConfirmRef (_: FunBlazorContext<AntDesign.Confirm>, x: AntDesign.ConfirmRef) = "ConfirmRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRemove")>] member this.OnRemove (_: FunBlazorContext<AntDesign.Confirm>, fn) = (Bolero.Html.attr.callback<AntDesign.ConfirmRef> "OnRemove" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Confirm>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Confirm>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Confirm>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Confirm>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = DialogBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DialogBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DialogBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DialogBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DialogBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.Dialog>, x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Dialog>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Dialog>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Dialog>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Dialog>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Dialog>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Dialog>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Dialog>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Dialog>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Dialog>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DialogWrapperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = DialogWrapperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DialogWrapperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DialogWrapperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DialogWrapperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DialogWrapperBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.DialogWrapper>, x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DialogWrapper>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DialogWrapper>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DialogWrapper>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DialogWrapper>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DestroyOnClose")>] member this.DestroyOnClose (_: FunBlazorContext<AntDesign.DialogWrapper>, x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.DialogWrapper>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBeforeDestroy")>] member this.OnBeforeDestroy (_: FunBlazorContext<AntDesign.DialogWrapper>, fn) = (Bolero.Html.attr.callback<System.ComponentModel.CancelEventArgs> "OnBeforeDestroy" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAfterShow")>] member this.OnAfterShow (_: FunBlazorContext<AntDesign.DialogWrapper>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAfterHide")>] member this.OnAfterHide (_: FunBlazorContext<AntDesign.DialogWrapper>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterHide" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.DialogWrapper>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.DialogWrapper>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.DialogWrapper>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.DialogWrapper>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ModalBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ModalBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ModalBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ModalBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ModalBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ModalBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ModalRef")>] member this.ModalRef (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ModalRef) = "ModalRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AfterClose")>] member this.AfterClose (_: FunBlazorContext<AntDesign.Modal>, x: System.Func<System.Threading.Tasks.Task>) = "AfterClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BodyStyle")>] member this.BodyStyle (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelText")>] member this.CancelText (_: FunBlazorContext<AntDesign.Modal>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Centered")>] member this.Centered (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Centered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Draggable")>] member this.Draggable (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DragInViewport")>] member this.DragInViewport (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "DragInViewport" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<AntDesign.Modal>, nodes) = Bolero.Html.attr.fragment "CloseIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<AntDesign.Modal>, x: string) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<AntDesign.Modal>, x: int) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CloseIcon")>] member this.CloseIcon (_: FunBlazorContext<AntDesign.Modal>, x: float) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ConfirmLoading")>] member this.ConfirmLoading (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "ConfirmLoading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DestroyOnClose")>] member this.DestroyOnClose (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<AntDesign.Modal>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetContainer")>] member this.GetContainer (_: FunBlazorContext<AntDesign.Modal>, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "GetContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mask")>] member this.Mask (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Mask" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaskClosable")>] member this.MaskClosable (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaskStyle")>] member this.MaskStyle (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "MaskStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkText")>] member this.OkText (_: FunBlazorContext<AntDesign.Modal>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "OkText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkType")>] member this.OkType (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "OkType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Modal>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Modal>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Modal>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Modal>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.Modal>, x: OneOf.OneOf<System.String, System.Double>) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapClassName")>] member this.WrapClassName (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "WrapClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ZIndex")>] member this.ZIndex (_: FunBlazorContext<AntDesign.Modal>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancel")>] member this.OnCancel (_: FunBlazorContext<AntDesign.Modal>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOk")>] member this.OnOk (_: FunBlazorContext<AntDesign.Modal>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnOk" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkButtonProps")>] member this.OkButtonProps (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButtonProps")>] member this.CancelButtonProps (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Modal>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Modal>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Modal>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Modal>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ModalLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Modal>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Modal>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ModalContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ModalContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ModalContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ModalContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ModalContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ModalContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ModalContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ModalFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ModalFooterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ModalFooterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ModalFooter>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ModalFooter>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ModalFooter>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ModalFooter>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type NotificationBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = NotificationBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = NotificationBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.NotificationBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.NotificationBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.NotificationBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.NotificationBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type NotificationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = NotificationBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = NotificationBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Notification>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Notification>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Notification>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Notification>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type NotificationItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = NotificationItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = NotificationItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Config")>] member this.Config (_: FunBlazorContext<AntDesign.NotificationItem>, x: AntDesign.NotificationConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<AntDesign.NotificationItem>, x: System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>) = "OnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.NotificationItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.NotificationItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.NotificationItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.NotificationItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PageHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PageHeaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PageHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Ghost")>] member this.Ghost (_: FunBlazorContext<AntDesign.PageHeader>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIcon")>] member this.BackIcon (_: FunBlazorContext<AntDesign.PageHeader>, x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = "BackIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIconTemplate")>] member this.BackIconTemplate (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "BackIconTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIconTemplate")>] member this.BackIconTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIconTemplate")>] member this.BackIconTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("BackIconTemplate")>] member this.BackIconTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.PageHeader>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Subtitle")>] member this.Subtitle (_: FunBlazorContext<AntDesign.PageHeader>, x: System.String) = "Subtitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBack")>] member this.OnBack (_: FunBlazorContext<AntDesign.PageHeader>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnBack" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderContent")>] member this.PageHeaderContent (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderContent")>] member this.PageHeaderContent (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderContent")>] member this.PageHeaderContent (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderContent")>] member this.PageHeaderContent (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderFooter")>] member this.PageHeaderFooter (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderFooter")>] member this.PageHeaderFooter (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderFooter")>] member this.PageHeaderFooter (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderFooter")>] member this.PageHeaderFooter (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderBreadcrumb")>] member this.PageHeaderBreadcrumb (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderBreadcrumb")>] member this.PageHeaderBreadcrumb (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderBreadcrumb")>] member this.PageHeaderBreadcrumb (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderBreadcrumb")>] member this.PageHeaderBreadcrumb (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderAvatar")>] member this.PageHeaderAvatar (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderAvatar" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderAvatar")>] member this.PageHeaderAvatar (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderAvatar")>] member this.PageHeaderAvatar (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderAvatar")>] member this.PageHeaderAvatar (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTitle")>] member this.PageHeaderTitle (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderTitle" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTitle")>] member this.PageHeaderTitle (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTitle")>] member this.PageHeaderTitle (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTitle")>] member this.PageHeaderTitle (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderSubtitle")>] member this.PageHeaderSubtitle (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderSubtitle")>] member this.PageHeaderSubtitle (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderSubtitle")>] member this.PageHeaderSubtitle (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderSubtitle")>] member this.PageHeaderSubtitle (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTags")>] member this.PageHeaderTags (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderTags" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTags")>] member this.PageHeaderTags (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTags")>] member this.PageHeaderTags (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderTags")>] member this.PageHeaderTags (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderExtra")>] member this.PageHeaderExtra (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderExtra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderExtra")>] member this.PageHeaderExtra (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderExtra")>] member this.PageHeaderExtra (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageHeaderExtra")>] member this.PageHeaderExtra (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.PageHeader>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.PageHeader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.PageHeader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.PageHeader>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PaginationBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PaginationBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Total")>] member this.Total (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "Total" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultCurrent")>] member this.DefaultCurrent (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "DefaultCurrent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Current")>] member this.Current (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultPageSize")>] member this.DefaultPageSize (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "DefaultPageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSize")>] member this.PageSize (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Pagination>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideOnSinglePage")>] member this.HideOnSinglePage (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "HideOnSinglePage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSizeChanger")>] member this.ShowSizeChanger (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowSizeChanger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSizeOptions")>] member this.PageSizeOptions (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnShowSizeChange")>] member this.OnShowSizeChange (_: FunBlazorContext<AntDesign.Pagination>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnShowSizeChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowQuickJumper")>] member this.ShowQuickJumper (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowQuickJumper" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<AntDesign.Pagination>, nodes) = Bolero.Html.attr.fragment "GoButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<AntDesign.Pagination>, x: string) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<AntDesign.Pagination>, x: int) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<AntDesign.Pagination>, x: float) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTitle")>] member this.ShowTitle (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTotal")>] member this.ShowTotal (_: FunBlazorContext<AntDesign.Pagination>, x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = "ShowTotal" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Pagination>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Responsive")>] member this.Responsive (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "Responsive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Simple")>] member this.Simple (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "Simple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Pagination>, x: AntDesign.PaginationLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemRender")>] member this.ItemRender (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowLessItems")>] member this.ShowLessItems (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowLessItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPrevNextJumpers")>] member this.ShowPrevNextJumpers (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowPrevNextJumpers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<AntDesign.Pagination>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrevIcon")>] member this.PrevIcon (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "PrevIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("NextIcon")>] member this.NextIcon (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NextIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("JumpPrevIcon")>] member this.JumpPrevIcon (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "JumpPrevIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("JumpNextIcon")>] member this.JumpNextIcon (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "JumpNextIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TotalBoundaryShowSizeChanger")>] member this.TotalBoundaryShowSizeChanger (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "TotalBoundaryShowSizeChanger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnmatchedAttributes")>] member this.UnmatchedAttributes (_: FunBlazorContext<AntDesign.Pagination>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Pagination>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Pagination>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Pagination>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Pagination>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PaginationOptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PaginationOptionsBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PaginationOptionsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("IsSmall")>] member this.IsSmall (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Boolean) = "IsSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RootPrefixCls")>] member this.RootPrefixCls (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeSize")>] member this.ChangeSize (_: FunBlazorContext<AntDesign.PaginationOptions>, fn) = (Bolero.Html.attr.callback<System.Int32> "ChangeSize" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Current")>] member this.Current (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSize")>] member this.PageSize (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSizeOptions")>] member this.PageSizeOptions (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("QuickGo")>] member this.QuickGo (_: FunBlazorContext<AntDesign.PaginationOptions>, fn) = (Bolero.Html.attr.callback<System.Int32> "QuickGo" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("GoButton")>] member this.GoButton (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = "GoButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.PaginationOptions>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.PaginationOptions>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.PaginationOptions>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ProgressBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ProgressBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressSize) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressType) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.Progress>, x: System.Func<System.Double, System.String>) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Percent")>] member this.Percent (_: FunBlazorContext<AntDesign.Progress>, x: System.Double) = "Percent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowInfo")>] member this.ShowInfo (_: FunBlazorContext<AntDesign.Progress>, x: System.Boolean) = "ShowInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressStatus) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeLinecap")>] member this.StrokeLinecap (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressStrokeLinecap) = "StrokeLinecap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuccessPercent")>] member this.SuccessPercent (_: FunBlazorContext<AntDesign.Progress>, x: System.Double) = "SuccessPercent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TrailColor")>] member this.TrailColor (_: FunBlazorContext<AntDesign.Progress>, x: System.String) = "TrailColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeWidth")>] member this.StrokeWidth (_: FunBlazorContext<AntDesign.Progress>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StrokeColor")>] member this.StrokeColor (_: FunBlazorContext<AntDesign.Progress>, x: OneOf.OneOf<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>) = "StrokeColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Steps")>] member this.Steps (_: FunBlazorContext<AntDesign.Progress>, x: System.Int32) = "Steps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.Progress>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GapDegree")>] member this.GapDegree (_: FunBlazorContext<AntDesign.Progress>, x: System.Int32) = "GapDegree" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GapPosition")>] member this.GapPosition (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressGapPosition) = "GapPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Progress>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Progress>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Progress>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RadioBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = RadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RadioBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RadioBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = RadioBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Radio<'TValue>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RadioButton")>] member this.RadioButton (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "RadioButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultChecked")>] member this.DefaultChecked (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "DefaultChecked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChanged")>] member this.CheckedChanged (_: FunBlazorContext<AntDesign.Radio<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChange")>] member this.CheckedChange (_: FunBlazorContext<AntDesign.Radio<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = RateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = RateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Rate>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Rate>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Rate>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Rate>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.Rate>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowHalf")>] member this.AllowHalf (_: FunBlazorContext<AntDesign.Rate>, x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Rate>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.Rate>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Character")>] member this.Character (_: FunBlazorContext<AntDesign.Rate>, render: AntDesign.RateItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Character" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Count")>] member this.Count (_: FunBlazorContext<AntDesign.Rate>, x: System.Int32) = "Count" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Rate>, x: System.Decimal) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorContext<AntDesign.Rate>, fn) = (Bolero.Html.attr.callback<System.Decimal> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorContext<AntDesign.Rate>, x: System.Decimal) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tooltips")>] member this.Tooltips (_: FunBlazorContext<AntDesign.Rate>, x: System.String[]) = "Tooltips" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.Rate>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.Rate>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Rate>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Rate>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Rate>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Rate>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RateItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = RateItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RateItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("AllowHalf")>] member this.AllowHalf (_: FunBlazorContext<AntDesign.RateItem>, x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnItemHover")>] member this.OnItemHover (_: FunBlazorContext<AntDesign.RateItem>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnItemHover" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnItemClick")>] member this.OnItemClick (_: FunBlazorContext<AntDesign.RateItem>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tooltip")>] member this.Tooltip (_: FunBlazorContext<AntDesign.RateItem>, x: System.String) = "Tooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IndexOfGroup")>] member this.IndexOfGroup (_: FunBlazorContext<AntDesign.RateItem>, x: System.Int32) = "IndexOfGroup" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HoverValue")>] member this.HoverValue (_: FunBlazorContext<AntDesign.RateItem>, x: System.Int32) = "HoverValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HasHalf")>] member this.HasHalf (_: FunBlazorContext<AntDesign.RateItem>, x: System.Boolean) = "HasHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsFocused")>] member this.IsFocused (_: FunBlazorContext<AntDesign.RateItem>, x: System.Boolean) = "IsFocused" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.RateItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.RateItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.RateItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.RateItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ResultBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ResultBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ResultBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ResultBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ResultBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ResultBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Result>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitle")>] member this.SubTitle (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "SubTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitleTemplate")>] member this.SubTitleTemplate (_: FunBlazorContext<AntDesign.Result>, nodes) = Bolero.Html.attr.fragment "SubTitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitleTemplate")>] member this.SubTitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: string) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitleTemplate")>] member this.SubTitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: int) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubTitleTemplate")>] member this.SubTitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: float) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Result>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Result>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Result>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorContext<AntDesign.Result>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowIcon")>] member this.IsShowIcon (_: FunBlazorContext<AntDesign.Result>, x: System.Boolean) = "IsShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Result>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Result>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Result>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Result>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Result>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Result>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Result>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SelectOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = SelectOptionBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SelectOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: 'TItemValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SimpleSelectOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = SimpleSelectOptionBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SimpleSelectOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Label")>] member this.Label (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SkeletonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SkeletonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SkeletonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SkeletonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SkeletonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Active")>] member this.Active (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleWidth")>] member this.TitleWidth (_: FunBlazorContext<AntDesign.Skeleton>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "TitleWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarSize")>] member this.AvatarSize (_: FunBlazorContext<AntDesign.Skeleton>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "AvatarSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarShape")>] member this.AvatarShape (_: FunBlazorContext<AntDesign.Skeleton>, x: System.String) = "AvatarShape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Paragraph")>] member this.Paragraph (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Paragraph" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ParagraphRows")>] member this.ParagraphRows (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Nullable<System.Int32>) = "ParagraphRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ParagraphWidth")>] member this.ParagraphWidth (_: FunBlazorContext<AntDesign.Skeleton>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IList<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = "ParagraphWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Skeleton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Skeleton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Skeleton>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Skeleton>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Skeleton>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Skeleton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Skeleton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Skeleton>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SkeletonElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = SkeletonElementBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SkeletonElementBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Active")>] member this.Active (_: FunBlazorContext<AntDesign.SkeletonElement>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.SkeletonElement>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.SkeletonElement>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Shape")>] member this.Shape (_: FunBlazorContext<AntDesign.SkeletonElement>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.SkeletonElement>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.SkeletonElement>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.SkeletonElement>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.SkeletonElement>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SpaceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SpaceBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpaceBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpaceBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpaceBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SpaceBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Align")>] member this.Align (_: FunBlazorContext<AntDesign.Space>, x: System.String) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<AntDesign.Space>, x: AntDesign.DirectionVHType) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Space>, x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Wrap")>] member this.Wrap (_: FunBlazorContext<AntDesign.Space>, x: System.Boolean) = "Wrap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<AntDesign.Space>, nodes) = Bolero.Html.attr.fragment "Split" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<AntDesign.Space>, x: string) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<AntDesign.Space>, x: int) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Split")>] member this.Split (_: FunBlazorContext<AntDesign.Space>, x: float) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Space>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Space>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Space>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Space>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Space>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Space>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Space>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Space>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SpaceItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SpaceItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpaceItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpaceItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpaceItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SpaceItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SpaceItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SpaceItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SpaceItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SpaceItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.SpaceItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.SpaceItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.SpaceItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.SpaceItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SpinBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SpinBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpinBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpinBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpinBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SpinBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Spin>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tip")>] member this.Tip (_: FunBlazorContext<AntDesign.Spin>, x: System.String) = "Tip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delay")>] member this.Delay (_: FunBlazorContext<AntDesign.Spin>, x: System.Int32) = "Delay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Spinning")>] member this.Spinning (_: FunBlazorContext<AntDesign.Spin>, x: System.Boolean) = "Spinning" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WrapperClassName")>] member this.WrapperClassName (_: FunBlazorContext<AntDesign.Spin>, x: System.String) = "WrapperClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indicator")>] member this.Indicator (_: FunBlazorContext<AntDesign.Spin>, nodes) = Bolero.Html.attr.fragment "Indicator" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indicator")>] member this.Indicator (_: FunBlazorContext<AntDesign.Spin>, x: string) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indicator")>] member this.Indicator (_: FunBlazorContext<AntDesign.Spin>, x: int) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indicator")>] member this.Indicator (_: FunBlazorContext<AntDesign.Spin>, x: float) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Spin>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Spin>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Spin>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Spin>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Spin>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Spin>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Spin>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Spin>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type StatisticComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = StatisticComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = StatisticComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = StatisticComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = StatisticComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = StatisticComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: int) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: float) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "Suffix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: int) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: float) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueStyle")>] member this.ValueStyle (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "ValueStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CountDownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = CountDownBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CountDownBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CountDownBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CountDownBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CountDownBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFinish")>] member this.OnFinish (_: FunBlazorContext<AntDesign.CountDown>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnFinish" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.CountDown>, nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: int) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: float) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Suffix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.CountDown>, nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: int) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: float) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.CountDown>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.CountDown>, x: System.DateTime) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueStyle")>] member this.ValueStyle (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "ValueStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CountDown>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CountDown>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CountDown>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.CountDown>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.CountDown>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.CountDown>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.CountDown>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type StatisticBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = StatisticBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = StatisticBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = StatisticBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = StatisticBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = StatisticBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DecimalSeparator")>] member this.DecimalSeparator (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "DecimalSeparator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GroupSeparator")>] member this.GroupSeparator (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "GroupSeparator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Precision")>] member this.Precision (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.Int32) = "Precision" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: int) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixTemplate")>] member this.PrefixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: float) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Suffix")>] member this.Suffix (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "Suffix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixTemplate")>] member this.SuffixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ValueStyle")>] member this.ValueStyle (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "ValueStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type StepBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = StepBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = StepBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Step>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Subtitle")>] member this.Subtitle (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Subtitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<AntDesign.Step>, nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: int) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SubtitleTemplate")>] member this.SubtitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: float) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.Step>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.Step>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.Step>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.Step>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Step>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Step>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Step>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Step>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Step>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type StepsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = StepsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = StepsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = StepsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = StepsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = StepsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Current")>] member this.Current (_: FunBlazorContext<AntDesign.Steps>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Percent")>] member this.Percent (_: FunBlazorContext<AntDesign.Steps>, x: System.Nullable<System.Double>) = "Percent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ProgressDot")>] member this.ProgressDot (_: FunBlazorContext<AntDesign.Steps>, nodes) = Bolero.Html.attr.fragment "ProgressDot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ProgressDot")>] member this.ProgressDot (_: FunBlazorContext<AntDesign.Steps>, x: string) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ProgressDot")>] member this.ProgressDot (_: FunBlazorContext<AntDesign.Steps>, x: int) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ProgressDot")>] member this.ProgressDot (_: FunBlazorContext<AntDesign.Steps>, x: float) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowProgressDot")>] member this.ShowProgressDot (_: FunBlazorContext<AntDesign.Steps>, x: System.Boolean) = "ShowProgressDot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Direction")>] member this.Direction (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("LabelPlacement")>] member this.LabelPlacement (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "LabelPlacement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("StartIndex")>] member this.StartIndex (_: FunBlazorContext<AntDesign.Steps>, x: System.Int32) = "StartIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Status")>] member this.Status (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Steps>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Steps>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Steps>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Steps>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Steps>, fn) = (Bolero.Html.attr.callback<System.Int32> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Steps>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Steps>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Steps>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ColumnBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ColumnBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ColumnBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ColumnBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ColumnBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ColumnBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ColumnBase>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ColumnBase>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ColumnBase>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ColumnBase>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowSpan")>] member this.RowSpan (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColSpan")>] member this.ColSpan (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderColSpan")>] member this.HeaderColSpan (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ColumnBase>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ColumnBase>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ColumnBase>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ColumnBase>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ColumnBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ColumnBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ColumnBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ActionColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ActionColumnBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ActionColumnBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ActionColumnBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ActionColumnBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ActionColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ActionColumn>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ActionColumn>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ActionColumn>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.ActionColumn>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowSpan")>] member this.RowSpan (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColSpan")>] member this.ColSpan (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderColSpan")>] member this.HeaderColSpan (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ActionColumn>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ActionColumn>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ActionColumn>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ActionColumn>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.ActionColumn>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.ActionColumn>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.ActionColumn>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ColumnBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ColumnBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ColumnBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ColumnBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("FieldChanged")>] member this.FieldChanged (_: FunBlazorContext<AntDesign.Column<'TData>>, fn) = (Bolero.Html.attr.callback<'TData> "FieldChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FieldExpression")>] member this.FieldExpression (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Linq.Expressions.Expression<System.Func<'TData>>) = "FieldExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CellRender")>] member this.CellRender (_: FunBlazorContext<AntDesign.Column<'TData>>, render: 'TData -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "CellRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Field")>] member this.Field (_: FunBlazorContext<AntDesign.Column<'TData>>, x: 'TData) = "Field" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataIndex")>] member this.DataIndex (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "DataIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Sortable")>] member this.Sortable (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "Sortable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SorterCompare")>] member this.SorterCompare (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Func<'TData, 'TData, System.Int32>) = "SorterCompare" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SorterMultiple")>] member this.SorterMultiple (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Int32) = "SorterMultiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSorterTooltip")>] member this.ShowSorterTooltip (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "ShowSorterTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortDirections")>] member this.SortDirections (_: FunBlazorContext<AntDesign.Column<'TData>>, x: AntDesign.SortDirection[]) = "SortDirections" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultSortOrder")>] member this.DefaultSortOrder (_: FunBlazorContext<AntDesign.Column<'TData>>, x: AntDesign.SortDirection) = "DefaultSortOrder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCell")>] member this.OnCell (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Func<AntDesign.TableModels.RowData, System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnCell" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnHeaderCell")>] member this.OnHeaderCell (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnHeaderCell" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Filterable")>] member this.Filterable (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "Filterable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Filters")>] member this.Filters (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = "Filters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FilterMultiple")>] member this.FilterMultiple (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "FilterMultiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFilter")>] member this.OnFilter (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = "OnFilter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Column<'TData>>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Column<'TData>>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Column<'TData>>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Column<'TData>>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowSpan")>] member this.RowSpan (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColSpan")>] member this.ColSpan (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderColSpan")>] member this.HeaderColSpan (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Column<'TData>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Column<'TData>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Column<'TData>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Column<'TData>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Column<'TData>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Column<'TData>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Column<'TData>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SelectionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SelectionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SelectionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SelectionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SelectionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SelectionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Selection>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckStrictly")>] member this.CheckStrictly (_: FunBlazorContext<AntDesign.Selection>, x: System.Boolean) = "CheckStrictly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Selection>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Selection>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Selection>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Selection>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowSpan")>] member this.RowSpan (_: FunBlazorContext<AntDesign.Selection>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColSpan")>] member this.ColSpan (_: FunBlazorContext<AntDesign.Selection>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderColSpan")>] member this.HeaderColSpan (_: FunBlazorContext<AntDesign.Selection>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Selection>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Selection>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Selection>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Selection>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.Selection>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Selection>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Selection>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Selection>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SummaryCellBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SummaryCellBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SummaryCellBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SummaryCellBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SummaryCellBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SummaryCellBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.SummaryCell>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.SummaryCell>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.SummaryCell>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.SummaryCell>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Width")>] member this.Width (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderStyle")>] member this.HeaderStyle (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowSpan")>] member this.RowSpan (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ColSpan")>] member this.ColSpan (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HeaderColSpan")>] member this.HeaderColSpan (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Fixed")>] member this.Fixed (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SummaryCell>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SummaryCell>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SummaryCell>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SummaryCell>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.SummaryCell>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.SummaryCell>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.SummaryCell>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TableBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TableBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TableBuilder<'FunBlazorGeneric>()

    [<CustomOperation("RenderMode")>] member this.RenderMode (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.RenderMode) = "RenderMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Table<'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowTemplate")>] member this.RowTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandTemplate")>] member this.ExpandTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, render: AntDesign.TableModels.RowData<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ExpandTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowExpandable")>] member this.RowExpandable (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>) = "RowExpandable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TreeChildren")>] member this.TreeChildren (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>) = "TreeChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.QueryModel<'TItem>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRow")>] member this.OnRow (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnHeaderRow")>] member this.OnHeaderRow (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnHeaderRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: int) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: float) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.TableSize) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.TableLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Bordered")>] member this.Bordered (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollX")>] member this.ScrollX (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "ScrollX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollY")>] member this.ScrollY (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "ScrollY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ScrollBarWidth")>] member this.ScrollBarWidth (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "ScrollBarWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IndentSize")>] member this.IndentSize (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "IndentSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandIconColumnIndex")>] member this.ExpandIconColumnIndex (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "ExpandIconColumnIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RowClassName")>] member this.RowClassName (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "RowClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ExpandedRowClassName")>] member this.ExpandedRowClassName (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "ExpandedRowClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnExpand")>] member this.OnExpand (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnExpand" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SortDirections")>] member this.SortDirections (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.SortDirection[]) = "SortDirections" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TableLayout")>] member this.TableLayout (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "TableLayout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowClick")>] member this.OnRowClick (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("HidePagination")>] member this.HidePagination (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Boolean) = "HidePagination" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PaginationPosition")>] member this.PaginationPosition (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "PaginationPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Total")>] member this.Total (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "Total" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TotalChanged")>] member this.TotalChanged (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<System.Int32> "TotalChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageIndex")>] member this.PageIndex (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "PageIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageIndexChanged")>] member this.PageIndexChanged (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<System.Int32> "PageIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSize")>] member this.PageSize (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PageSizeChanged")>] member this.PageSizeChanged (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<System.Int32> "PageSizeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPageIndexChange")>] member this.OnPageIndexChange (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageIndexChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPageSizeChange")>] member this.OnPageSizeChange (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageSizeChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedRows")>] member this.SelectedRows (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedRowsChanged")>] member this.SelectedRowsChanged (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItem>> "SelectedRowsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TabPaneBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TabPaneBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TabPaneBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TabPaneBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TabPaneBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TabPaneBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ForceRender")>] member this.ForceRender (_: FunBlazorContext<AntDesign.TabPane>, x: System.Boolean) = "ForceRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<AntDesign.TabPane>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tab")>] member this.Tab (_: FunBlazorContext<AntDesign.TabPane>, nodes) = Bolero.Html.attr.fragment "Tab" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tab")>] member this.Tab (_: FunBlazorContext<AntDesign.TabPane>, x: string) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tab")>] member this.Tab (_: FunBlazorContext<AntDesign.TabPane>, x: int) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Tab")>] member this.Tab (_: FunBlazorContext<AntDesign.TabPane>, x: float) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TabPane>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TabPane>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TabPane>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TabPane>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.TabPane>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<AntDesign.TabPane>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.TabPane>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.TabPane>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.TabPane>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.TabPane>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TabsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tabs>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tabs>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tabs>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tabs>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActiveKey")>] member this.ActiveKey (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "ActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ActiveKeyChanged")>] member this.ActiveKeyChanged (_: FunBlazorContext<AntDesign.Tabs>, fn) = (Bolero.Html.attr.callback<System.String> "ActiveKeyChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Animated")>] member this.Animated (_: FunBlazorContext<AntDesign.Tabs>, x: System.Boolean) = "Animated" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTabBar")>] member this.RenderTabBar (_: FunBlazorContext<AntDesign.Tabs>, x: System.Object) = "RenderTabBar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultActiveKey")>] member this.DefaultActiveKey (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "DefaultActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideAdd")>] member this.HideAdd (_: FunBlazorContext<AntDesign.Tabs>, x: System.Boolean) = "HideAdd" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarExtraContent")>] member this.TabBarExtraContent (_: FunBlazorContext<AntDesign.Tabs>, nodes) = Bolero.Html.attr.fragment "TabBarExtraContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarExtraContent")>] member this.TabBarExtraContent (_: FunBlazorContext<AntDesign.Tabs>, x: string) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarExtraContent")>] member this.TabBarExtraContent (_: FunBlazorContext<AntDesign.Tabs>, x: int) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarExtraContent")>] member this.TabBarExtraContent (_: FunBlazorContext<AntDesign.Tabs>, x: float) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarGutter")>] member this.TabBarGutter (_: FunBlazorContext<AntDesign.Tabs>, x: System.Int32) = "TabBarGutter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabBarStyle")>] member this.TabBarStyle (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "TabBarStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TabPosition")>] member this.TabPosition (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "TabPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Tabs>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnEdit")>] member this.OnEdit (_: FunBlazorContext<AntDesign.Tabs>, x: System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>) = "OnEdit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnAddClick")>] member this.OnAddClick (_: FunBlazorContext<AntDesign.Tabs>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAddClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AfterTabCreated")>] member this.AfterTabCreated (_: FunBlazorContext<AntDesign.Tabs>, fn) = (Bolero.Html.attr.callback<System.String> "AfterTabCreated" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnNextClick")>] member this.OnNextClick (_: FunBlazorContext<AntDesign.Tabs>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnNextClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPrevClick")>] member this.OnPrevClick (_: FunBlazorContext<AntDesign.Tabs>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnPrevClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnTabClick")>] member this.OnTabClick (_: FunBlazorContext<AntDesign.Tabs>, fn) = (Bolero.Html.attr.callback<System.String> "OnTabClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<AntDesign.Tabs>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Draggable")>] member this.Draggable (_: FunBlazorContext<AntDesign.Tabs>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Tabs>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Tabs>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Tabs>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TagBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TagBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TagBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TagBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TagBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TagBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tag>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tag>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tag>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tag>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Closable")>] member this.Closable (_: FunBlazorContext<AntDesign.Tag>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checkable")>] member this.Checkable (_: FunBlazorContext<AntDesign.Tag>, x: System.Boolean) = "Checkable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<AntDesign.Tag>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CheckedChange")>] member this.CheckedChange (_: FunBlazorContext<AntDesign.Tag>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<AntDesign.Tag>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Tag>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClose")>] member this.OnClose (_: FunBlazorContext<AntDesign.Tag>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClosing")>] member this.OnClosing (_: FunBlazorContext<AntDesign.Tag>, fn) = (Bolero.Html.attr.callback<AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs>> "OnClosing" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Tag>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Tag>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Tag>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Tag>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Tag>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Tag>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TimelineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TimelineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TimelineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TimelineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TimelineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorContext<AntDesign.Timeline>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Reverse")>] member this.Reverse (_: FunBlazorContext<AntDesign.Timeline>, x: System.Boolean) = "Reverse" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Pending")>] member this.Pending (_: FunBlazorContext<AntDesign.Timeline>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Pending" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PendingDot")>] member this.PendingDot (_: FunBlazorContext<AntDesign.Timeline>, nodes) = Bolero.Html.attr.fragment "PendingDot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PendingDot")>] member this.PendingDot (_: FunBlazorContext<AntDesign.Timeline>, x: string) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PendingDot")>] member this.PendingDot (_: FunBlazorContext<AntDesign.Timeline>, x: int) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("PendingDot")>] member this.PendingDot (_: FunBlazorContext<AntDesign.Timeline>, x: float) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Timeline>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Timeline>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Timeline>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Timeline>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Timeline>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Timeline>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Timeline>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Timeline>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TimelineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TimelineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TimelineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TimelineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TimelineItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TimelineItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TimelineItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TimelineItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TimelineItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<AntDesign.TimelineItem>, nodes) = Bolero.Html.attr.fragment "Dot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<AntDesign.TimelineItem>, x: string) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<AntDesign.TimelineItem>, x: int) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Dot")>] member this.Dot (_: FunBlazorContext<AntDesign.TimelineItem>, x: float) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Color")>] member this.Color (_: FunBlazorContext<AntDesign.TimelineItem>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.TimelineItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.TimelineItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.TimelineItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.TimelineItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TransferBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TransferBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TransferBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TransferBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TransferBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TransferBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<AntDesign.Transfer>, x: System.Collections.Generic.IList<AntDesign.TransferItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Titles")>] member this.Titles (_: FunBlazorContext<AntDesign.Transfer>, x: System.String[]) = "Titles" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Operations")>] member this.Operations (_: FunBlazorContext<AntDesign.Transfer>, x: System.String[]) = "Operations" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Transfer>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSearch")>] member this.ShowSearch (_: FunBlazorContext<AntDesign.Transfer>, x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSelectAll")>] member this.ShowSelectAll (_: FunBlazorContext<AntDesign.Transfer>, x: System.Boolean) = "ShowSelectAll" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TargetKeys")>] member this.TargetKeys (_: FunBlazorContext<AntDesign.Transfer>, x: System.String[]) = "TargetKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeys")>] member this.SelectedKeys (_: FunBlazorContext<AntDesign.Transfer>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Transfer>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferChangeArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnScroll")>] member this.OnScroll (_: FunBlazorContext<AntDesign.Transfer>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferScrollArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearch")>] member this.OnSearch (_: FunBlazorContext<AntDesign.Transfer>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferSearchArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelectChange")>] member this.OnSelectChange (_: FunBlazorContext<AntDesign.Transfer>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferSelectChangeArgs> "OnSelectChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Render")>] member this.Render (_: FunBlazorContext<AntDesign.Transfer>, x: System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Render" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Transfer>, x: AntDesign.TransferLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Footer")>] member this.Footer (_: FunBlazorContext<AntDesign.Transfer>, x: System.String) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<AntDesign.Transfer>, nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<AntDesign.Transfer>, x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<AntDesign.Transfer>, x: int) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("FooterTemplate")>] member this.FooterTemplate (_: FunBlazorContext<AntDesign.Transfer>, x: float) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Transfer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Transfer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Transfer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Transfer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Transfer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Transfer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Transfer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Transfer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TreeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ShowExpand")>] member this.ShowExpand (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "ShowExpand" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowLine")>] member this.ShowLine (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "ShowLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowIcon")>] member this.ShowIcon (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "ShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BlockNode")>] member this.BlockNode (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "BlockNode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Draggable")>] member this.Draggable (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: int) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: float) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildNodes")>] member this.ChildNodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Collections.Generic.List<AntDesign.TreeNode<'TItem>>) = "ChildNodes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Multiple")>] member this.Multiple (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKey")>] member this.SelectedKey (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.String) = "SelectedKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeyChanged")>] member this.SelectedKeyChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<System.String> "SelectedKeyChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedNode")>] member this.SelectedNode (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: AntDesign.TreeNode<'TItem>) = "SelectedNode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedNodeChanged")>] member this.SelectedNodeChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeNode<'TItem>> "SelectedNodeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedData")>] member this.SelectedData (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: 'TItem) = "SelectedData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedDataChanged")>] member this.SelectedDataChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<'TItem> "SelectedDataChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeys")>] member this.SelectedKeys (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedKeysChanged")>] member this.SelectedKeysChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedNodes")>] member this.SelectedNodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: AntDesign.TreeNode<'TItem>[]) = "SelectedNodes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SelectedDatas")>] member this.SelectedDatas (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: 'TItem[]) = "SelectedDatas" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checkable")>] member this.Checkable (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "Checkable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SearchValue")>] member this.SearchValue (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.String) = "SearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SearchExpression")>] member this.SearchExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "SearchExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataSource")>] member this.DataSource (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Collections.Generic.IList<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleExpression")>] member this.TitleExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "TitleExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("KeyExpression")>] member this.KeyExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "KeyExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconExpression")>] member this.IconExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "IconExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsLeafExpression")>] member this.IsLeafExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "IsLeafExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildrenExpression")>] member this.ChildrenExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IList<'TItem>>) = "ChildrenExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnNodeLoadDelayAsync")>] member this.OnNodeLoadDelayAsync (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnNodeLoadDelayAsync" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDblClick")>] member this.OnDblClick (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDblClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnContextMenu")>] member this.OnContextMenu (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnContextMenu" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCheckBoxChanged")>] member this.OnCheckBoxChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnCheckBoxChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnExpandChanged")>] member this.OnExpandChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnExpandChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSearchValueChanged")>] member this.OnSearchValueChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnSearchValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IndentTemplate")>] member this.IndentTemplate (_: FunBlazorContext<AntDesign.Tree<'TItem>>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "IndentTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Tree<'TItem>>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "TitleTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleIconTemplate")>] member this.TitleIconTemplate (_: FunBlazorContext<AntDesign.Tree<'TItem>>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "TitleIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SwitcherIconTemplate")>] member this.SwitcherIconTemplate (_: FunBlazorContext<AntDesign.Tree<'TItem>>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "SwitcherIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TreeNodeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeNodeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: int) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Nodes")>] member this.Nodes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: float) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Key")>] member this.Key (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Selected")>] member this.Selected (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Selected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsLeaf")>] member this.IsLeaf (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "IsLeaf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Expanded")>] member this.Expanded (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Checked")>] member this.Checked (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Indeterminate")>] member this.Indeterminate (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisableCheckbox")>] member this.DisableCheckbox (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "DisableCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Draggable")>] member this.Draggable (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DataItem")>] member this.DataItem (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: 'TItem) = "DataItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TypographyBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TypographyBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TypographyBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TypographyBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TypographyBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TypographyBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Copyable")>] member this.Copyable (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CopyConfig")>] member this.CopyConfig (_: FunBlazorContext<AntDesign.TypographyBase>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delete")>] member this.Delete (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EditConfig")>] member this.EditConfig (_: FunBlazorContext<AntDesign.TypographyBase>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EllipsisConfig")>] member this.EllipsisConfig (_: FunBlazorContext<AntDesign.TypographyBase>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mark")>] member this.Mark (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Strong")>] member this.Strong (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TypographyBase>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TypographyBase>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TypographyBase>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.TypographyBase>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.TypographyBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.TypographyBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.TypographyBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type LinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = LinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = LinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = LinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = LinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = LinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Code")>] member this.Code (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Copyable")>] member this.Copyable (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CopyConfig")>] member this.CopyConfig (_: FunBlazorContext<AntDesign.Link>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delete")>] member this.Delete (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EditConfig")>] member this.EditConfig (_: FunBlazorContext<AntDesign.Link>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EllipsisConfig")>] member this.EllipsisConfig (_: FunBlazorContext<AntDesign.Link>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mark")>] member this.Mark (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Strong")>] member this.Strong (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Link>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Link>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Link>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Link>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Link>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Link>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Link>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Link>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Link>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Link>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ParagraphBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ParagraphBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ParagraphBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ParagraphBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ParagraphBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ParagraphBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Code")>] member this.Code (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Copyable")>] member this.Copyable (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CopyConfig")>] member this.CopyConfig (_: FunBlazorContext<AntDesign.Paragraph>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delete")>] member this.Delete (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EditConfig")>] member this.EditConfig (_: FunBlazorContext<AntDesign.Paragraph>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EllipsisConfig")>] member this.EllipsisConfig (_: FunBlazorContext<AntDesign.Paragraph>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mark")>] member this.Mark (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Strong")>] member this.Strong (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Paragraph>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Paragraph>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Paragraph>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Paragraph>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Paragraph>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Paragraph>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Paragraph>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Paragraph>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Paragraph>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TextBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TextBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TextBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Code")>] member this.Code (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Keyboard")>] member this.Keyboard (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Copyable")>] member this.Copyable (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CopyConfig")>] member this.CopyConfig (_: FunBlazorContext<AntDesign.Text>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delete")>] member this.Delete (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EditConfig")>] member this.EditConfig (_: FunBlazorContext<AntDesign.Text>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EllipsisConfig")>] member this.EllipsisConfig (_: FunBlazorContext<AntDesign.Text>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mark")>] member this.Mark (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Strong")>] member this.Strong (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Text>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Text>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Text>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Text>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Text>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Text>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Text>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Text>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Text>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Text>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TitleBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TitleBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TitleBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TitleBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TitleBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Level")>] member this.Level (_: FunBlazorContext<AntDesign.Title>, x: System.Int32) = "Level" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Copyable")>] member this.Copyable (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CopyConfig")>] member this.CopyConfig (_: FunBlazorContext<AntDesign.Title>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Delete")>] member this.Delete (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Editable")>] member this.Editable (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EditConfig")>] member this.EditConfig (_: FunBlazorContext<AntDesign.Title>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ellipsis")>] member this.Ellipsis (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("EllipsisConfig")>] member this.EllipsisConfig (_: FunBlazorContext<AntDesign.Title>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Mark")>] member this.Mark (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Underline")>] member this.Underline (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Strong")>] member this.Strong (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Title>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.Title>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Title>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Title>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Title>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Title>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Title>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Title>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Title>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Title>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type UploadBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = UploadBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = UploadBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = UploadBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = UploadBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = UploadBuilder<'FunBlazorGeneric>()

    [<CustomOperation("BeforeUpload")>] member this.BeforeUpload (_: FunBlazorContext<AntDesign.Upload>, x: System.Func<AntDesign.UploadFileItem, System.Boolean>) = "BeforeUpload" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BeforeAllUploadAsync")>] member this.BeforeAllUploadAsync (_: FunBlazorContext<AntDesign.Upload>, x: System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>) = "BeforeAllUploadAsync" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BeforeAllUpload")>] member this.BeforeAllUpload (_: FunBlazorContext<AntDesign.Upload>, x: System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Boolean>) = "BeforeAllUpload" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Action")>] member this.Action (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "Action" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Upload>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ListType")>] member this.ListType (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "ListType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Directory")>] member this.Directory (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "Directory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Multiple")>] member this.Multiple (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Accept")>] member this.Accept (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "Accept" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowUploadList")>] member this.ShowUploadList (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "ShowUploadList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FileList")>] member this.FileList (_: FunBlazorContext<AntDesign.Upload>, x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "FileList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Upload>, x: AntDesign.UploadLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("FileListChanged")>] member this.FileListChanged (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.List<AntDesign.UploadFileItem>> "FileListChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DefaultFileList")>] member this.DefaultFileList (_: FunBlazorContext<AntDesign.Upload>, x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "DefaultFileList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Headers")>] member this.Headers (_: FunBlazorContext<AntDesign.Upload>, x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSingleCompleted")>] member this.OnSingleCompleted (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnSingleCompleted" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCompleted")>] member this.OnCompleted (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnCompleted" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRemove")>] member this.OnRemove (_: FunBlazorContext<AntDesign.Upload>, x: System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>) = "OnRemove" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnPreview")>] member this.OnPreview (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnPreview" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnDownload")>] member this.OnDownload (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnDownload" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Upload>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Upload>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Upload>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Upload>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowButton")>] member this.ShowButton (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Upload>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Upload>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Upload>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BreadcrumbItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = BreadcrumbItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BreadcrumbItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BreadcrumbItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BreadcrumbItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BreadcrumbItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BreadcrumbItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: System.Object) = "Overlay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CalendarHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = CalendarHeaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CalendarHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.CalendarHeader>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.CalendarHeader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.CalendarHeader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.CalendarHeader>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CardMetaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = CardMetaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CardMetaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.CardMeta>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.CardMeta>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Description")>] member this.Description (_: FunBlazorContext<AntDesign.CardMeta>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.CardMeta>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("DescriptionTemplate")>] member this.DescriptionTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorContext<AntDesign.CardMeta>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.CardMeta>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AvatarTemplate")>] member this.AvatarTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.CardMeta>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.CardMeta>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.CardMeta>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.CardMeta>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = AntContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.AntContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.AntContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.AntContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.AntContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TemplateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TemplateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TemplateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TemplateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TemplateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TemplateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Template>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Template>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Template>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Template>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("If")>] member this.If (_: FunBlazorContext<AntDesign.Template>, x: System.Func<System.Boolean>) = "If" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Template>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Template>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Template>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Template>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type EmptyDefaultImgBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = EmptyDefaultImgBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = EmptyDefaultImgBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type EmptySimpleImgBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = EmptySimpleImgBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = EmptySimpleImgBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Content>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Content>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Content>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Content>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Content>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Content>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Content>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Content>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = FooterBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FooterBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FooterBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FooterBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = FooterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Footer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Footer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Footer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Footer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Footer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Footer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Footer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Footer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type HeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = HeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = HeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = HeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = HeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = HeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Header>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Header>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Header>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Header>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Header>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Header>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Header>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Header>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type LayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = LayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = LayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = LayoutBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = LayoutBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = LayoutBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Layout>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Layout>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Layout>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Layout>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Layout>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Layout>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Layout>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Layout>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = MenuDividerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MenuDividerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.MenuDivider>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.MenuDivider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.MenuDivider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.MenuDivider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PaginationPagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PaginationPagerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PaginationPagerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ShowTitle")>] member this.ShowTitle (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Page")>] member this.Page (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Int32) = "Page" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RootPrefixCls")>] member this.RootPrefixCls (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Active")>] member this.Active (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.PaginationPager>, fn) = (Bolero.Html.attr.callback<System.Int32> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyPress")>] member this.OnKeyPress (_: FunBlazorContext<AntDesign.PaginationPager>, fn) = (Bolero.Html.attr.callback<System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action>> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ItemRender")>] member this.ItemRender (_: FunBlazorContext<AntDesign.PaginationPager>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("UnmatchedAttributes")>] member this.UnmatchedAttributes (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.PaginationPager>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.PaginationPager>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.PaginationPager>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Select.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type SelectOptionGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = SelectOptionGroupBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SelectOptionGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type CalendarPanelChooserBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = CalendarPanelChooserBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CalendarPanelChooserBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Calendar")>] member this.Calendar (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: AntDesign.Calendar) = "Calendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ElementBuilder<'FunBlazorGeneric>()

    [<CustomOperation("HtmlTag")>] member this.HtmlTag (_: FunBlazorContext<AntDesign.Internal.Element>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.Element>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.Element>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.Element>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.Element>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefChanged")>] member this.RefChanged (_: FunBlazorContext<AntDesign.Internal.Element>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Attributes")>] member this.Attributes (_: FunBlazorContext<AntDesign.Internal.Element>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.Element>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.Element>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.Element>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.Element>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type OverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = OverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = OverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = OverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = OverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = OverlayBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OverlayChildPrefixCls")>] member this.OverlayChildPrefixCls (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.String) = "OverlayChildPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.Overlay>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayMouseEnter")>] member this.OnOverlayMouseEnter (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayMouseLeave")>] member this.OnOverlayMouseLeave (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnShow")>] member this.OnShow (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Action) = "OnShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnHide")>] member this.OnHide (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Action) = "OnHide" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HideMillisecondsDelay")>] member this.HideMillisecondsDelay (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Int32) = "HideMillisecondsDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("WaitForHideAnimMilliseconds")>] member this.WaitForHideAnimMilliseconds (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Int32) = "WaitForHideAnimMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("VerticalOffset")>] member this.VerticalOffset (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Int32) = "VerticalOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HorizontalOffset")>] member this.HorizontalOffset (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Int32) = "HorizontalOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type OverlayTriggerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = OverlayTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = OverlayTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = OverlayTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = OverlayTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = OverlayTriggerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("BoundaryAdjustMode")>] member this.BoundaryAdjustMode (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member this.ComplexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineFlexMode")>] member this.InlineFlexMode (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsButton")>] member this.IsButton (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMaskClick")>] member this.OnMaskClick (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayHiding")>] member this.OnOverlayHiding (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayEnterCls")>] member this.OverlayEnterCls (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayHiddenCls")>] member this.OverlayHiddenCls (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayLeaveCls")>] member this.OverlayLeaveCls (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlacementCls")>] member this.PlacementCls (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerReference")>] member this.TriggerReference (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Unbound")>] member this.Unbound (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type DropdownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = DropdownBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DropdownBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DropdownBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DropdownBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DropdownBuilder<'FunBlazorGeneric>()

    [<CustomOperation("BoundaryAdjustMode")>] member this.BoundaryAdjustMode (_: FunBlazorContext<AntDesign.Dropdown>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Dropdown>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Dropdown>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Dropdown>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Dropdown>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member this.ComplexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineFlexMode")>] member this.InlineFlexMode (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsButton")>] member this.IsButton (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Dropdown>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMaskClick")>] member this.OnMaskClick (_: FunBlazorContext<AntDesign.Dropdown>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayHiding")>] member this.OnOverlayHiding (_: FunBlazorContext<AntDesign.Dropdown>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorContext<AntDesign.Dropdown>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Dropdown>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Dropdown>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Dropdown>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Dropdown>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayEnterCls")>] member this.OverlayEnterCls (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayHiddenCls")>] member this.OverlayHiddenCls (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayLeaveCls")>] member this.OverlayLeaveCls (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.Dropdown>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlacementCls")>] member this.PlacementCls (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Dropdown>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerReference")>] member this.TriggerReference (_: FunBlazorContext<AntDesign.Dropdown>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Unbound")>] member this.Unbound (_: FunBlazorContext<AntDesign.Dropdown>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Dropdown>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Dropdown>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Dropdown>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DropdownButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = DropdownButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DropdownButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DropdownButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DropdownButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DropdownButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Block")>] member this.Block (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Block" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ButtonsRender")>] member this.ButtonsRender (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "ButtonsRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Danger")>] member this.Danger (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Danger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Ghost")>] member this.Ghost (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Type")>] member this.Type (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.ValueTuple<System.String, System.String>) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BoundaryAdjustMode")>] member this.BoundaryAdjustMode (_: FunBlazorContext<AntDesign.DropdownButton>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DropdownButton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DropdownButton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DropdownButton>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.DropdownButton>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member this.ComplexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineFlexMode")>] member this.InlineFlexMode (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsButton")>] member this.IsButton (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.DropdownButton>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMaskClick")>] member this.OnMaskClick (_: FunBlazorContext<AntDesign.DropdownButton>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayHiding")>] member this.OnOverlayHiding (_: FunBlazorContext<AntDesign.DropdownButton>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorContext<AntDesign.DropdownButton>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.DropdownButton>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.DropdownButton>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.DropdownButton>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.DropdownButton>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayEnterCls")>] member this.OverlayEnterCls (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayHiddenCls")>] member this.OverlayHiddenCls (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayLeaveCls")>] member this.OverlayLeaveCls (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.DropdownButton>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlacementCls")>] member this.PlacementCls (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.DropdownButton>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerReference")>] member this.TriggerReference (_: FunBlazorContext<AntDesign.DropdownButton>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Unbound")>] member this.Unbound (_: FunBlazorContext<AntDesign.DropdownButton>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.DropdownButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.DropdownButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.DropdownButton>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PopconfirmBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = PopconfirmBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = PopconfirmBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = PopconfirmBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = PopconfirmBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = PopconfirmBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelText")>] member this.CancelText (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkText")>] member this.OkText (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OkText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkType")>] member this.OkType (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OkType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OkButtonProps")>] member this.OkButtonProps (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CancelButtonProps")>] member this.CancelButtonProps (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Icon")>] member this.Icon (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconTemplate")>] member this.IconTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, nodes) = Bolero.Html.attr.fragment "IconTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconTemplate")>] member this.IconTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: string) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconTemplate")>] member this.IconTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: int) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("IconTemplate")>] member this.IconTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: float) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnCancel")>] member this.OnCancel (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnConfirm")>] member this.OnConfirm (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnConfirm" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ArrowPointAtCenter")>] member this.ArrowPointAtCenter (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseEnterDelay")>] member this.MouseEnterDelay (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseLeaveDelay")>] member this.MouseLeaveDelay (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BoundaryAdjustMode")>] member this.BoundaryAdjustMode (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Popconfirm>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Popconfirm>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Popconfirm>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Popconfirm>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member this.ComplexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineFlexMode")>] member this.InlineFlexMode (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsButton")>] member this.IsButton (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMaskClick")>] member this.OnMaskClick (_: FunBlazorContext<AntDesign.Popconfirm>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayHiding")>] member this.OnOverlayHiding (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Popconfirm>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Popconfirm>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Popconfirm>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Popconfirm>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayEnterCls")>] member this.OverlayEnterCls (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayHiddenCls")>] member this.OverlayHiddenCls (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayLeaveCls")>] member this.OverlayLeaveCls (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlacementCls")>] member this.PlacementCls (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerReference")>] member this.TriggerReference (_: FunBlazorContext<AntDesign.Popconfirm>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Unbound")>] member this.Unbound (_: FunBlazorContext<AntDesign.Popconfirm>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Popconfirm>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Popconfirm>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = PopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = PopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = PopoverBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = PopoverBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = PopoverBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Popover>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Popover>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Popover>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("TitleTemplate")>] member this.TitleTemplate (_: FunBlazorContext<AntDesign.Popover>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<AntDesign.Popover>, nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<AntDesign.Popover>, x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<AntDesign.Popover>, x: int) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentTemplate")>] member this.ContentTemplate (_: FunBlazorContext<AntDesign.Popover>, x: float) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ArrowPointAtCenter")>] member this.ArrowPointAtCenter (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseEnterDelay")>] member this.MouseEnterDelay (_: FunBlazorContext<AntDesign.Popover>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseLeaveDelay")>] member this.MouseLeaveDelay (_: FunBlazorContext<AntDesign.Popover>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BoundaryAdjustMode")>] member this.BoundaryAdjustMode (_: FunBlazorContext<AntDesign.Popover>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Popover>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Popover>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Popover>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Popover>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member this.ComplexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineFlexMode")>] member this.InlineFlexMode (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsButton")>] member this.IsButton (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Popover>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMaskClick")>] member this.OnMaskClick (_: FunBlazorContext<AntDesign.Popover>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.Popover>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.Popover>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayHiding")>] member this.OnOverlayHiding (_: FunBlazorContext<AntDesign.Popover>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorContext<AntDesign.Popover>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Popover>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Popover>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Popover>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Popover>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayEnterCls")>] member this.OverlayEnterCls (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayHiddenCls")>] member this.OverlayHiddenCls (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayLeaveCls")>] member this.OverlayLeaveCls (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.Popover>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlacementCls")>] member this.PlacementCls (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Popover>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerReference")>] member this.TriggerReference (_: FunBlazorContext<AntDesign.Popover>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Unbound")>] member this.Unbound (_: FunBlazorContext<AntDesign.Popover>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Popover>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Popover>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Popover>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = TooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TooltipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TooltipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TooltipBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Title")>] member this.Title (_: FunBlazorContext<AntDesign.Tooltip>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ArrowPointAtCenter")>] member this.ArrowPointAtCenter (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseEnterDelay")>] member this.MouseEnterDelay (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MouseLeaveDelay")>] member this.MouseLeaveDelay (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BoundaryAdjustMode")>] member this.BoundaryAdjustMode (_: FunBlazorContext<AntDesign.Tooltip>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tooltip>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tooltip>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tooltip>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Tooltip>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member this.ComplexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineFlexMode")>] member this.InlineFlexMode (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsButton")>] member this.IsButton (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Tooltip>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMaskClick")>] member this.OnMaskClick (_: FunBlazorContext<AntDesign.Tooltip>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayHiding")>] member this.OnOverlayHiding (_: FunBlazorContext<AntDesign.Tooltip>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorContext<AntDesign.Tooltip>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Tooltip>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Tooltip>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Tooltip>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Tooltip>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayEnterCls")>] member this.OverlayEnterCls (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayHiddenCls")>] member this.OverlayHiddenCls (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayLeaveCls")>] member this.OverlayLeaveCls (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.Tooltip>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlacementCls")>] member this.PlacementCls (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Tooltip>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerReference")>] member this.TriggerReference (_: FunBlazorContext<AntDesign.Tooltip>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Unbound")>] member this.Unbound (_: FunBlazorContext<AntDesign.Tooltip>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Tooltip>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Tooltip>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Tooltip>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type SubMenuTriggerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SubMenuTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SubMenuTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SubMenuTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SubMenuTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SubMenuTriggerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("TriggerClass")>] member this.TriggerClass (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "TriggerClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("BoundaryAdjustMode")>] member this.BoundaryAdjustMode (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ComplexAutoCloseAndVisible")>] member this.ComplexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("HiddenMode")>] member this.HiddenMode (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("InlineFlexMode")>] member this.InlineFlexMode (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsButton")>] member this.IsButton (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMaskClick")>] member this.OnMaskClick (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseEnter")>] member this.OnMouseEnter (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnMouseLeave")>] member this.OnMouseLeave (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnOverlayHiding")>] member this.OnOverlayHiding (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Overlay")>] member this.Overlay (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayClassName")>] member this.OverlayClassName (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayEnterCls")>] member this.OverlayEnterCls (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayHiddenCls")>] member this.OverlayHiddenCls (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayLeaveCls")>] member this.OverlayLeaveCls (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OverlayStyle")>] member this.OverlayStyle (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placement")>] member this.Placement (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PlacementCls")>] member this.PlacementCls (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PopupContainerSelector")>] member this.PopupContainerSelector (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Trigger")>] member this.Trigger (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("TriggerReference")>] member this.TriggerReference (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Unbound")>] member this.Unbound (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerPanelChooserBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerPanelChooserBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerPanelChooserBuilder<'FunBlazorGeneric>()

    [<CustomOperation("DatePicker")>] member this.DatePicker (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: AntDesign.DatePickerBase<'TValue>) = "DatePicker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PickerPanelBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = PickerPanelBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PickerPanelBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type DatePickerPanelBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerPanelBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerPanelBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type DatePickerDatetimePanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerDatetimePanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerDatetimePanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowTime")>] member this.IsShowTime (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "IsShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTimeFormat")>] member this.ShowTimeFormat (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "ShowTimeFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Format")>] member this.Format (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledHours")>] member this.DisabledHours (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledMinutes")>] member this.DisabledMinutes (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledSeconds")>] member this.DisabledSeconds (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledTime")>] member this.DisabledTime (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerTemplateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerTemplateBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerTemplateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("RenderPickerHeader")>] member this.RenderPickerHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderPickerHeader" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderPickerHeader")>] member this.RenderPickerHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderPickerHeader")>] member this.RenderPickerHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderPickerHeader")>] member this.RenderPickerHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTableHeader")>] member this.RenderTableHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderTableHeader" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTableHeader")>] member this.RenderTableHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTableHeader")>] member this.RenderTableHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderTableHeader")>] member this.RenderTableHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderFirstCol")>] member this.RenderFirstCol (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderFirstCol" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderColValue")>] member this.RenderColValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderColValue" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderLastCol")>] member this.RenderLastCol (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderLastCol" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ViewStartDate")>] member this.ViewStartDate (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.DateTime) = "ViewStartDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetColTitle")>] member this.GetColTitle (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.String>) = "GetColTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetRowClass")>] member this.GetRowClass (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.String>) = "GetRowClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetNextColValue")>] member this.GetNextColValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.DateTime>) = "GetNextColValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsInView")>] member this.IsInView (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "IsInView" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsToday")>] member this.IsToday (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "IsToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsSelected")>] member this.IsSelected (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "IsSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRowSelect")>] member this.OnRowSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime>) = "OnRowSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnValueSelect")>] member this.OnValueSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime>) = "OnValueSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowFooter")>] member this.ShowFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Boolean) = "ShowFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxRow")>] member this.MaxRow (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Int32) = "MaxRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MaxCol")>] member this.MaxCol (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Int32) = "MaxCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerDatePanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerDatePanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerDatePanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("IsWeek")>] member this.IsWeek (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "IsWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowToday")>] member this.ShowToday (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerDecadePanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerDecadePanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerDecadePanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerFooterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerFooterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerHeaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("SuperChangeDateInterval")>] member this.SuperChangeDateInterval (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Int32) = "SuperChangeDateInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeDateInterval")>] member this.ChangeDateInterval (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Int32) = "ChangeDateInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSuperPreChange")>] member this.ShowSuperPreChange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "ShowSuperPreChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPreChange")>] member this.ShowPreChange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "ShowPreChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowNextChange")>] member this.ShowNextChange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "ShowNextChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSuperNextChange")>] member this.ShowSuperNextChange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "ShowSuperNextChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerMonthPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerMonthPanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerMonthPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerQuarterPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerQuarterPanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerQuarterPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerYearPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerYearPanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerYearPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Picker")>] member this.Picker (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsCalendar")>] member this.IsCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsShowHeader")>] member this.IsShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Locale")>] member this.Locale (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CultureInfo")>] member this.CultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ClosePanel")>] member this.ClosePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerValue")>] member this.ChangePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangeValue")>] member this.ChangeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChangePickerType")>] member this.ChangePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexPickerValue")>] member this.GetIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("GetIndexValue")>] member this.GetIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DisabledDate")>] member this.DisabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("DateRender")>] member this.DateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("MonthCellRender")>] member this.MonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarDateRender")>] member this.CalendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("CalendarMonthCellRender")>] member this.CalendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RenderExtraFooter")>] member this.RenderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnSelect")>] member this.OnSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("PickerIndex")>] member this.PickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DatePickerInputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Size")>] member this.Size (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ReadOnly")>] member this.ReadOnly (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsRange")>] member this.IsRange (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("AutoFocus")>] member this.AutoFocus (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowSuffixIcon")>] member this.ShowSuffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "ShowSuffixIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowTime")>] member this.ShowTime (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SuffixIcon")>] member this.SuffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClick")>] member this.OnClick (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Onfocus")>] member this.Onfocus (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnBlur" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Onfocusout")>] member this.Onfocusout (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocusout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("AllowClear")>] member this.AllowClear (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClickClear")>] member this.OnClickClear (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClickClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DropdownGroupButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = DropdownGroupButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DropdownGroupButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("LeftButton")>] member this.LeftButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, nodes) = Bolero.Html.attr.fragment "LeftButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LeftButton")>] member this.LeftButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: string) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LeftButton")>] member this.LeftButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: int) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("LeftButton")>] member this.LeftButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: float) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightButton")>] member this.RightButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, nodes) = Bolero.Html.attr.fragment "RightButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightButton")>] member this.RightButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: string) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightButton")>] member this.RightButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: int) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RightButton")>] member this.RightButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: float) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type TemplateComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TemplateComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TemplateComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<AntDesign.TemplateComponentBase<'TComponentOptions>>, x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.TemplateComponentBase<'TComponentOptions>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FeedbackComponentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = FeedbackComponentBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FeedbackComponentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("FeedbackRef")>] member this.FeedbackRef (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions>>, x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions>>, x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FeedbackComponentBuilder2<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = FeedbackComponentBuilder2<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FeedbackComponentBuilder2<'FunBlazorGeneric>()

    [<CustomOperation("FeedbackRef")>] member this.FeedbackRef (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>, x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>, x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FormProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = FormProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FormProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FormProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FormProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = FormProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnFormFinish")>] member this.OnFormFinish (_: FunBlazorContext<AntDesign.FormProvider>, fn) = (Bolero.Html.attr.callback<AntDesign.FormProviderFinishEventArgs> "OnFormFinish" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.FormProvider>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.FormProvider>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.FormProvider>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.FormProvider>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.FormProvider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type UploadButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = UploadButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = UploadButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = UploadButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = UploadButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = UploadButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.UploadButton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ListType")>] member this.ListType (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.String) = "ListType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowButton")>] member this.ShowButton (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Directory")>] member this.Directory (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Boolean) = "Directory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Multiple")>] member this.Multiple (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Accept")>] member this.Accept (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.String) = "Accept" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Headers")>] member this.Headers (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Action")>] member this.Action (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.String) = "Action" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Disabled")>] member this.Disabled (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type FormValidationMessageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = FormValidationMessageBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FormValidationMessageBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Control")>] member this.Control (_: FunBlazorContext<AntDesign.FormValidationMessage<'TValue>>, x: AntDesign.AntInputComponentBase<'TValue>) = "Control" => x |> BoleroAttr |> this.AddProp
                

type FormValidationMessageItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = FormValidationMessageItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FormValidationMessageItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Message")>] member this.Message (_: FunBlazorContext<AntDesign.FormValidationMessageItem>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ImagePreviewBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ImagePreviewBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ImageRef")>] member this.ImageRef (_: FunBlazorContext<AntDesign.ImagePreview>, x: AntDesign.ImageRef) = "ImageRef" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ImagePreviewGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ImagePreviewGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ImagePreviewGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ImagePreviewGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ImagePreviewGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ImagePreviewGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ImagePreviewGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ImagePreviewGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.ImagePreviewGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type TreeIndentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeIndentBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeIndentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("TreeLevel")>] member this.TreeLevel (_: FunBlazorContext<AntDesign.TreeIndent<'TItem>>, x: System.Int32) = "TreeLevel" => x |> BoleroAttr |> this.AddProp
                

type TreeNodeCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeCheckboxBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeNodeCheckboxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnCheckBoxClick")>] member this.OnCheckBoxClick (_: FunBlazorContext<AntDesign.TreeNodeCheckbox<'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCheckBoxClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TreeNodeSwitcherBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeSwitcherBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeNodeSwitcherBuilder<'FunBlazorGeneric>()

    [<CustomOperation("OnSwitcherClick")>] member this.OnSwitcherClick (_: FunBlazorContext<AntDesign.TreeNodeSwitcher<'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnSwitcherClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TreeNodeTitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeTitleBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeNodeTitleBuilder<'FunBlazorGeneric>()


                

type CardLoadingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = CardLoadingBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CardLoadingBuilder<'FunBlazorGeneric>()


                

type SummaryRowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = SummaryRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SummaryRowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SummaryRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SummaryRowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SummaryRowBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SummaryRow>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SummaryRow>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SummaryRow>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ChildContent")>] member this.ChildContent (_: FunBlazorContext<AntDesign.SummaryRow>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.statistic

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type StatisticComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = StatisticComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = StatisticComponentBaseBuilder<'FunBlazorGeneric>()


                
            
namespace rec AntDesign.DslInternals.Select

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type LabelTemplateItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = LabelTemplateItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = LabelTemplateItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("LabelTemplateItemContent")>] member this.LabelTemplateItemContent (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplateItemContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("ContentStyle")>] member this.ContentStyle (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: System.String) = "ContentStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ContentClass")>] member this.ContentClass (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: System.String) = "ContentClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RemoveIconStyle")>] member this.RemoveIconStyle (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: System.String) = "RemoveIconStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RemoveIconClass")>] member this.RemoveIconClass (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: System.String) = "RemoveIconClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Select.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type SelectContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = SelectContentBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SelectContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("Prefix")>] member this.Prefix (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("IsOverlayShow")>] member this.IsOverlayShow (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.Boolean) = "IsOverlayShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ShowPlaceholder")>] member this.ShowPlaceholder (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.Boolean) = "ShowPlaceholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnInput")>] member this.OnInput (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyUp")>] member this.OnKeyUp (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnKeyDown")>] member this.OnKeyDown (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnFocus")>] member this.OnFocus (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnBlur")>] member this.OnBlur (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnClearClick")>] member this.OnClearClick (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("OnRemoveSelected")>] member this.OnRemoveSelected (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>> "OnRemoveSelected" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("SearchValue")>] member this.SearchValue (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.String) = "SearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            

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
    type AntInputComponentBase'<'TValue> = AntInputComponentBaseBuilder<AntDesign.AntInputComponentBase<'TValue>>
    type AutoComplete'<'TOption> = AutoCompleteBuilder<AntDesign.AutoComplete<'TOption>>
    type Cascader' = CascaderBuilder<AntDesign.Cascader>
    type CheckboxGroup' = CheckboxGroupBuilder<AntDesign.CheckboxGroup>
    type AntInputBoolComponentBase' = AntInputBoolComponentBaseBuilder<AntDesign.AntInputBoolComponentBase>
    type Checkbox' = CheckboxBuilder<AntDesign.Checkbox>
    type Switch' = SwitchBuilder<AntDesign.Switch>
    type DatePickerBase'<'TValue> = DatePickerBaseBuilder<AntDesign.DatePickerBase<'TValue>>
    type DatePicker'<'TValue> = DatePickerBuilder<AntDesign.DatePicker<'TValue>>
    type MonthPicker'<'TValue> = MonthPickerBuilder<AntDesign.MonthPicker<'TValue>>
    type QuarterPicker'<'TValue> = QuarterPickerBuilder<AntDesign.QuarterPicker<'TValue>>
    type WeekPicker'<'TValue> = WeekPickerBuilder<AntDesign.WeekPicker<'TValue>>
    type YearPicker'<'TValue> = YearPickerBuilder<AntDesign.YearPicker<'TValue>>
    type TimePicker'<'TValue> = TimePickerBuilder<AntDesign.TimePicker<'TValue>>
    type RangePicker'<'TValue> = RangePickerBuilder<AntDesign.RangePicker<'TValue>>
    type InputNumber'<'TValue> = InputNumberBuilder<AntDesign.InputNumber<'TValue>>
    type Input'<'TValue> = InputBuilder<AntDesign.Input<'TValue>>
    type AutoCompleteInput'<'TValue> = AutoCompleteInputBuilder<AntDesign.AutoCompleteInput<'TValue>>
    type InputPassword' = InputPasswordBuilder<AntDesign.InputPassword>
    type Search' = SearchBuilder<AntDesign.Search>
    type AutoCompleteSearch' = AutoCompleteSearchBuilder<AntDesign.AutoCompleteSearch>
    type TextArea' = TextAreaBuilder<AntDesign.TextArea>
    type RadioGroup'<'TValue> = RadioGroupBuilder<AntDesign.RadioGroup<'TValue>>
    type Select'<'TItemValue, 'TItem> = SelectBuilder<AntDesign.Select<'TItemValue, 'TItem>>
    type SimpleSelect' = SimpleSelectBuilder<AntDesign.SimpleSelect>
    type Slider'<'TValue> = SliderBuilder<AntDesign.Slider<'TValue>>
    type Descriptions' = DescriptionsBuilder<AntDesign.Descriptions>
    type DescriptionsItem' = DescriptionsItemBuilder<AntDesign.DescriptionsItem>
    type Divider' = DividerBuilder<AntDesign.Divider>
    type Drawer' = DrawerBuilder<AntDesign.Drawer>
    type DrawerContainer' = DrawerContainerBuilder<AntDesign.DrawerContainer>
    type Empty' = EmptyBuilder<AntDesign.Empty>
    type Form'<'TModel> = FormBuilder<AntDesign.Form<'TModel>>
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
    type AntList'<'TItem> = AntListBuilder<AntDesign.AntList<'TItem>>
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
    type Radio'<'TValue> = RadioBuilder<AntDesign.Radio<'TValue>>
    type Rate' = RateBuilder<AntDesign.Rate>
    type RateItem' = RateItemBuilder<AntDesign.RateItem>
    type Result' = ResultBuilder<AntDesign.Result>
    type SelectOption'<'TItemValue, 'TItem> = SelectOptionBuilder<AntDesign.SelectOption<'TItemValue, 'TItem>>
    type SimpleSelectOption' = SimpleSelectOptionBuilder<AntDesign.SimpleSelectOption>
    type Skeleton' = SkeletonBuilder<AntDesign.Skeleton>
    type SkeletonElement' = SkeletonElementBuilder<AntDesign.SkeletonElement>
    type Space' = SpaceBuilder<AntDesign.Space>
    type SpaceItem' = SpaceItemBuilder<AntDesign.SpaceItem>
    type Spin' = SpinBuilder<AntDesign.Spin>
    type StatisticComponentBase'<'T> = StatisticComponentBaseBuilder<AntDesign.StatisticComponentBase<'T>>
    type CountDown' = CountDownBuilder<AntDesign.CountDown>
    type Statistic'<'TValue> = StatisticBuilder<AntDesign.Statistic<'TValue>>
    type Step' = StepBuilder<AntDesign.Step>
    type Steps' = StepsBuilder<AntDesign.Steps>
    type ColumnBase' = ColumnBaseBuilder<AntDesign.ColumnBase>
    type ActionColumn' = ActionColumnBuilder<AntDesign.ActionColumn>
    type Column'<'TData> = ColumnBuilder<AntDesign.Column<'TData>>
    type Selection' = SelectionBuilder<AntDesign.Selection>
    type SummaryCell' = SummaryCellBuilder<AntDesign.SummaryCell>
    type Table'<'TItem> = TableBuilder<AntDesign.Table<'TItem>>
    type TabPane' = TabPaneBuilder<AntDesign.TabPane>
    type Tabs' = TabsBuilder<AntDesign.Tabs>
    type Tag' = TagBuilder<AntDesign.Tag>
    type Timeline' = TimelineBuilder<AntDesign.Timeline>
    type TimelineItem' = TimelineItemBuilder<AntDesign.TimelineItem>
    type Transfer' = TransferBuilder<AntDesign.Transfer>
    type Tree'<'TItem> = TreeBuilder<AntDesign.Tree<'TItem>>
    type TreeNode'<'TItem> = TreeNodeBuilder<AntDesign.TreeNode<'TItem>>
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
    type DatePickerPanelBase'<'TValue> = DatePickerPanelBaseBuilder<AntDesign.DatePickerPanelBase<'TValue>>
    type TemplateComponentBase'<'TComponentOptions> = TemplateComponentBaseBuilder<AntDesign.TemplateComponentBase<'TComponentOptions>>
    type FeedbackComponent'<'TComponentOptions> = FeedbackComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions>>
    type FeedbackComponent'<'TComponentOptions, 'TResult> = FeedbackComponentBuilder2<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>
    type FormProvider' = FormProviderBuilder<AntDesign.FormProvider>
    type FormValidationMessage'<'TValue> = FormValidationMessageBuilder<AntDesign.FormValidationMessage<'TValue>>
    type FormValidationMessageItem' = FormValidationMessageItemBuilder<AntDesign.FormValidationMessageItem>
    type ImagePreview' = ImagePreviewBuilder<AntDesign.ImagePreview>
    type ImagePreviewGroup' = ImagePreviewGroupBuilder<AntDesign.ImagePreviewGroup>
    type TreeIndent'<'TItem> = TreeIndentBuilder<AntDesign.TreeIndent<'TItem>>
    type TreeNodeCheckbox'<'TItem> = TreeNodeCheckboxBuilder<AntDesign.TreeNodeCheckbox<'TItem>>
    type TreeNodeSwitcher'<'TItem> = TreeNodeSwitcherBuilder<AntDesign.TreeNodeSwitcher<'TItem>>
    type TreeNodeTitle'<'TItem> = TreeNodeTitleBuilder<AntDesign.TreeNodeTitle<'TItem>>
    type CardLoading' = CardLoadingBuilder<AntDesign.CardLoading>
    type SummaryRow' = SummaryRowBuilder<AntDesign.SummaryRow>
            
namespace AntDesign.Select.Internal

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Select.Internal

    type SelectOptionGroup'<'TItemValue, 'TItem> = SelectOptionGroupBuilder<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>
    type SelectContent'<'TItemValue, 'TItem> = SelectContentBuilder<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>
            
namespace AntDesign.Internal

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Internal

    type CalendarPanelChooser' = CalendarPanelChooserBuilder<AntDesign.Internal.CalendarPanelChooser>
    type Element' = ElementBuilder<AntDesign.Internal.Element>
    type Overlay' = OverlayBuilder<AntDesign.Internal.Overlay>
    type OverlayTrigger' = OverlayTriggerBuilder<AntDesign.Internal.OverlayTrigger>
    type SubMenuTrigger' = SubMenuTriggerBuilder<AntDesign.Internal.SubMenuTrigger>
    type DatePickerPanelChooser'<'TValue> = DatePickerPanelChooserBuilder<AntDesign.Internal.DatePickerPanelChooser<'TValue>>
    type PickerPanelBase' = PickerPanelBaseBuilder<AntDesign.Internal.PickerPanelBase>
    type DatePickerDatetimePanel'<'TValue> = DatePickerDatetimePanelBuilder<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>
    type DatePickerTemplate'<'TValue> = DatePickerTemplateBuilder<AntDesign.Internal.DatePickerTemplate<'TValue>>
    type DatePickerDatePanel'<'TValue> = DatePickerDatePanelBuilder<AntDesign.Internal.DatePickerDatePanel<'TValue>>
    type DatePickerDecadePanel'<'TValue> = DatePickerDecadePanelBuilder<AntDesign.Internal.DatePickerDecadePanel<'TValue>>
    type DatePickerFooter'<'TValue> = DatePickerFooterBuilder<AntDesign.Internal.DatePickerFooter<'TValue>>
    type DatePickerHeader'<'TValue> = DatePickerHeaderBuilder<AntDesign.Internal.DatePickerHeader<'TValue>>
    type DatePickerMonthPanel'<'TValue> = DatePickerMonthPanelBuilder<AntDesign.Internal.DatePickerMonthPanel<'TValue>>
    type DatePickerQuarterPanel'<'TValue> = DatePickerQuarterPanelBuilder<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>
    type DatePickerYearPanel'<'TValue> = DatePickerYearPanelBuilder<AntDesign.Internal.DatePickerYearPanel<'TValue>>
    type DatePickerInput' = DatePickerInputBuilder<AntDesign.Internal.DatePickerInput>
    type DropdownGroupButton' = DropdownGroupButtonBuilder<AntDesign.Internal.DropdownGroupButton>
    type UploadButton' = UploadButtonBuilder<AntDesign.Internal.UploadButton>
            
namespace AntDesign.statistic

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.statistic

    type StatisticComponentBase'<'T> = StatisticComponentBaseBuilder<AntDesign.statistic.StatisticComponentBase<'T>>
            
namespace AntDesign.Select

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Select

    type LabelTemplateItem'<'TItemValue, 'TItem> = LabelTemplateItemBuilder<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>
            