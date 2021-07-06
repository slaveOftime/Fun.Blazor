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

    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AntComponentBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ConfigProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ConfigProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ConfigProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ConfigProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ConfigProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ConfigProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<AntDesign.ConfigProvider>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ConfigProvider>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ConfigProvider>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ConfigProvider>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ConfigProvider>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ConfigProvider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntDomComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntDomComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntDomComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AntDomComponentBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AntDomComponentBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AntDomComponentBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AntDomComponentBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AffixBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AffixBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AffixBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AffixBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AffixBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AffixBuilder<'FunBlazorGeneric>()

    [<CustomOperation("offsetBottom")>] member this.offsetBottom (_: FunBlazorContext<AntDesign.Affix>, x: System.Int32) = "OffsetBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetTop")>] member this.offsetTop (_: FunBlazorContext<AntDesign.Affix>, x: System.Int32) = "OffsetTop" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("targetSelector")>] member this.targetSelector (_: FunBlazorContext<AntDesign.Affix>, x: System.String) = "TargetSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Affix>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Affix>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Affix>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Affix>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Affix>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Affix>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Affix>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Affix>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Affix>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AlertBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AlertBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AlertBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AlertBuilder<'FunBlazorGeneric>()

    [<CustomOperation("afterClose")>] member this.afterClose (_: FunBlazorContext<AntDesign.Alert>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "AfterClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("banner")>] member this.banner (_: FunBlazorContext<AntDesign.Alert>, x: System.Boolean) = "Banner" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closable")>] member this.closable (_: FunBlazorContext<AntDesign.Alert>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeText")>] member this.closeText (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "CloseText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("description")>] member this.description (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Alert>, nodes) = Bolero.Html.attr.fragment "Icon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Alert>, x: string) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Alert>, x: int) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Alert>, x: float) = Bolero.Html.attr.fragment "Icon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("message")>] member this.message (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("messageTemplate")>] member this.messageTemplate (_: FunBlazorContext<AntDesign.Alert>, nodes) = Bolero.Html.attr.fragment "MessageTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("messageTemplate")>] member this.messageTemplate (_: FunBlazorContext<AntDesign.Alert>, x: string) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("messageTemplate")>] member this.messageTemplate (_: FunBlazorContext<AntDesign.Alert>, x: int) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("messageTemplate")>] member this.messageTemplate (_: FunBlazorContext<AntDesign.Alert>, x: float) = Bolero.Html.attr.fragment "MessageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("showIcon")>] member this.showIcon (_: FunBlazorContext<AntDesign.Alert>, x: System.Nullable<System.Boolean>) = "ShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClose")>] member this.onClose (_: FunBlazorContext<AntDesign.Alert>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Alert>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Alert>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Alert>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Alert>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Alert>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Alert>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Alert>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Alert>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AnchorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AnchorBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AnchorBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AnchorBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AnchorBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AnchorBuilder<'FunBlazorGeneric>()

    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<AntDesign.Anchor>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Anchor>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Anchor>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Anchor>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Anchor>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("affix")>] member this.affix (_: FunBlazorContext<AntDesign.Anchor>, x: System.Boolean) = "Affix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bounds")>] member this.bounds (_: FunBlazorContext<AntDesign.Anchor>, x: System.Int32) = "Bounds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getContainer")>] member this.getContainer (_: FunBlazorContext<AntDesign.Anchor>, x: System.Func<System.String>) = "GetContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetBottom")>] member this.offsetBottom (_: FunBlazorContext<AntDesign.Anchor>, x: System.Nullable<System.Int32>) = "OffsetBottom" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetTop")>] member this.offsetTop (_: FunBlazorContext<AntDesign.Anchor>, x: System.Nullable<System.Int32>) = "OffsetTop" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showInkInFixed")>] member this.showInkInFixed (_: FunBlazorContext<AntDesign.Anchor>, x: System.Boolean) = "ShowInkInFixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Anchor>, fn) = (Bolero.Html.attr.callback<System.Tuple<Microsoft.AspNetCore.Components.Web.MouseEventArgs, AntDesign.AnchorLink>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("getCurrentAnchor")>] member this.getCurrentAnchor (_: FunBlazorContext<AntDesign.Anchor>, x: System.Func<System.String>) = "GetCurrentAnchor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("targetOffset")>] member this.targetOffset (_: FunBlazorContext<AntDesign.Anchor>, x: System.Nullable<System.Int32>) = "TargetOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Anchor>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Anchor>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Anchor>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Anchor>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Anchor>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AnchorLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AnchorLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AnchorLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AnchorLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AnchorLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AnchorLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AnchorLink>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AnchorLink>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AnchorLink>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AnchorLink>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<AntDesign.AnchorLink>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.AnchorLink>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("target")>] member this.target (_: FunBlazorContext<AntDesign.AnchorLink>, x: System.String) = "Target" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AnchorLink>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AnchorLink>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AnchorLink>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AnchorLink>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteOptGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteOptGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelFragment")>] member this.labelFragment (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, nodes) = Bolero.Html.attr.fragment "LabelFragment" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelFragment")>] member this.labelFragment (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: string) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelFragment")>] member this.labelFragment (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: int) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelFragment")>] member this.labelFragment (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: float) = Bolero.Html.attr.fragment "LabelFragment" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AutoCompleteOptGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AutoCompleteOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AutoCompleteOption>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: System.Object) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoComplete")>] member this.autoComplete (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: AntDesign.IAutoCompleteRef) = "AutoComplete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AutoCompleteOption>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AvatarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AvatarBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AvatarBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AvatarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Avatar>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Avatar>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Avatar>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Avatar>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("shape")>] member this.shape (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("src")>] member this.src (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Src" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("srcSet")>] member this.srcSet (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "SrcSet" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("alt")>] member this.alt (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Alt" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onError")>] member this.onError (_: FunBlazorContext<AntDesign.Avatar>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.ErrorEventArgs> "OnError" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Avatar>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Avatar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Avatar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Avatar>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AvatarGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AvatarGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AvatarGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AvatarGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AvatarGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AvatarGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AvatarGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AvatarGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AvatarGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AvatarGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxCount")>] member this.maxCount (_: FunBlazorContext<AntDesign.AvatarGroup>, x: System.Int32) = "MaxCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxStyle")>] member this.maxStyle (_: FunBlazorContext<AntDesign.AvatarGroup>, x: System.String) = "MaxStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxPopoverPlacement")>] member this.maxPopoverPlacement (_: FunBlazorContext<AntDesign.AvatarGroup>, x: AntDesign.PlacementType) = "MaxPopoverPlacement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AvatarGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AvatarGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AvatarGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AvatarGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BackTopBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BackTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BackTopBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BackTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BackTopBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BackTopBuilder<'FunBlazorGeneric>()

    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.BackTop>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BackTop>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BackTop>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BackTop>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BackTop>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visibilityHeight")>] member this.visibilityHeight (_: FunBlazorContext<AntDesign.BackTop>, x: System.Double) = "VisibilityHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("targetSelector")>] member this.targetSelector (_: FunBlazorContext<AntDesign.BackTop>, x: System.String) = "TargetSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.BackTop>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.BackTop>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.BackTop>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.BackTop>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.BackTop>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BadgeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BadgeBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BadgeBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BadgeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("count")>] member this.count (_: FunBlazorContext<AntDesign.Badge>, x: System.Nullable<System.Int32>) = "Count" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("countTemplate")>] member this.countTemplate (_: FunBlazorContext<AntDesign.Badge>, nodes) = Bolero.Html.attr.fragment "CountTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("countTemplate")>] member this.countTemplate (_: FunBlazorContext<AntDesign.Badge>, x: string) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("countTemplate")>] member this.countTemplate (_: FunBlazorContext<AntDesign.Badge>, x: int) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("countTemplate")>] member this.countTemplate (_: FunBlazorContext<AntDesign.Badge>, x: float) = Bolero.Html.attr.fragment "CountTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dot")>] member this.dot (_: FunBlazorContext<AntDesign.Badge>, x: System.Boolean) = "Dot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offset")>] member this.offset (_: FunBlazorContext<AntDesign.Badge>, x: System.ValueTuple<System.Int32, System.Int32>) = "Offset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overflowCount")>] member this.overflowCount (_: FunBlazorContext<AntDesign.Badge>, x: System.Int32) = "OverflowCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showZero")>] member this.showZero (_: FunBlazorContext<AntDesign.Badge>, x: System.Boolean) = "ShowZero" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("status")>] member this.status (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Badge>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Badge>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Badge>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Badge>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Badge>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Badge>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Badge>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Badge>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BadgeRibbonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BadgeRibbonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BadgeRibbonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BadgeRibbonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BadgeRibbonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BadgeRibbonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("textTemplate")>] member this.textTemplate (_: FunBlazorContext<AntDesign.BadgeRibbon>, nodes) = Bolero.Html.attr.fragment "TextTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("textTemplate")>] member this.textTemplate (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: string) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("textTemplate")>] member this.textTemplate (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: int) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("textTemplate")>] member this.textTemplate (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: float) = Bolero.Html.attr.fragment "TextTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BadgeRibbon>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.BadgeRibbon>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BreadcrumbBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BreadcrumbBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BreadcrumbBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BreadcrumbBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BreadcrumbBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BreadcrumbBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Breadcrumb>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Breadcrumb>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Breadcrumb>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Breadcrumb>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoGenerate")>] member this.autoGenerate (_: FunBlazorContext<AntDesign.Breadcrumb>, x: System.Boolean) = "AutoGenerate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("separator")>] member this.separator (_: FunBlazorContext<AntDesign.Breadcrumb>, x: System.String) = "Separator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("routeLabel")>] member this.routeLabel (_: FunBlazorContext<AntDesign.Breadcrumb>, x: System.String) = "RouteLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Breadcrumb>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Breadcrumb>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Breadcrumb>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Breadcrumb>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("block")>] member this.block (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Block" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Button>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Button>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Button>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Button>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("danger")>] member this.danger (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Danger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ghost")>] member this.ghost (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("htmlType")>] member this.htmlType (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "HtmlType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Button>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClickStopPropagation")>] member this.onClickStopPropagation (_: FunBlazorContext<AntDesign.Button>, x: System.Boolean) = "OnClickStopPropagation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("shape")>] member this.shape (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Button>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Button>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Button>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Button>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ButtonGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ButtonGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ButtonGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ButtonGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ButtonGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ButtonGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ButtonGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ButtonGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.ButtonGroup>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ButtonGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ButtonGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ButtonGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ButtonGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CalendarBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CalendarBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CalendarBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Calendar>, x: System.DateTime) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.Calendar>, x: System.DateTime) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("validRange")>] member this.validRange (_: FunBlazorContext<AntDesign.Calendar>, x: System.DateTime[]) = "ValidRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mode")>] member this.mode (_: FunBlazorContext<AntDesign.Calendar>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fullScreen")>] member this.fullScreen (_: FunBlazorContext<AntDesign.Calendar>, x: System.Boolean) = "FullScreen" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Calendar>, fn) = (Bolero.Html.attr.callback<System.DateTime> "OnSelect" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Calendar>, fn) = (Bolero.Html.attr.callback<System.DateTime> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerRender")>] member this.headerRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<AntDesign.CalendarHeaderRenderArgs, Microsoft.AspNetCore.Components.RenderFragment>) = "HeaderRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateCellRender")>] member this.dateCellRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateFullCellRender")>] member this.dateFullCellRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateFullCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthFullCellRender")>] member this.monthFullCellRender (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthFullCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.Calendar>, x: System.Action<System.DateTime, System.String>) = "OnPanelChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Calendar>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Calendar>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Calendar>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Calendar>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Calendar>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Calendar>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Calendar>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CardBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CardBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("body")>] member this.body (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "Body" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("body")>] member this.body (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("body")>] member this.body (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("body")>] member this.body (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "Body" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("actionTemplate")>] member this.actionTemplate (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "ActionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("actionTemplate")>] member this.actionTemplate (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("actionTemplate")>] member this.actionTemplate (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("actionTemplate")>] member this.actionTemplate (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "ActionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.Card>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hoverable")>] member this.hoverable (_: FunBlazorContext<AntDesign.Card>, x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Card>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bodyStyle")>] member this.bodyStyle (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cover")>] member this.cover (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "Cover" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cover")>] member this.cover (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cover")>] member this.cover (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cover")>] member this.cover (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "Cover" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("actions")>] member this.actions (_: FunBlazorContext<AntDesign.Card>, x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardTabs")>] member this.cardTabs (_: FunBlazorContext<AntDesign.Card>, nodes) = Bolero.Html.attr.fragment "CardTabs" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardTabs")>] member this.cardTabs (_: FunBlazorContext<AntDesign.Card>, x: string) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardTabs")>] member this.cardTabs (_: FunBlazorContext<AntDesign.Card>, x: int) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cardTabs")>] member this.cardTabs (_: FunBlazorContext<AntDesign.Card>, x: float) = Bolero.Html.attr.fragment "CardTabs" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Card>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Card>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Card>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Card>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CardActionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CardActionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardActionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardActionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardActionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CardActionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CardAction>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CardAction>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CardAction>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CardAction>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.CardAction>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.CardAction>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.CardAction>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.CardAction>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CardGridBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CardGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CardGridBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CardGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CardGridBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CardGridBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CardGrid>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CardGrid>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CardGrid>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CardGrid>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("hoverable")>] member this.hoverable (_: FunBlazorContext<AntDesign.CardGrid>, x: System.Boolean) = "Hoverable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.CardGrid>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.CardGrid>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.CardGrid>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.CardGrid>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CarouselBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CarouselBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CarouselBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CarouselBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CarouselBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Carousel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Carousel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Carousel>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Carousel>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dotPosition")>] member this.dotPosition (_: FunBlazorContext<AntDesign.Carousel>, x: System.String) = "DotPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoplay")>] member this.autoplay (_: FunBlazorContext<AntDesign.Carousel>, x: System.TimeSpan) = "Autoplay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("effect")>] member this.effect (_: FunBlazorContext<AntDesign.Carousel>, x: System.String) = "Effect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Carousel>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Carousel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Carousel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Carousel>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CarouselSlickBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CarouselSlickBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CarouselSlickBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CarouselSlickBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CarouselSlickBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CarouselSlickBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CarouselSlick>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CarouselSlick>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CarouselSlick>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CarouselSlick>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.CarouselSlick>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.CarouselSlick>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.CarouselSlick>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.CarouselSlick>, x: (string * string) list) = attr.styles x |> this.AddProp
                

type CollapseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CollapseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CollapseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CollapseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("accordion")>] member this.accordion (_: FunBlazorContext<AntDesign.Collapse>, x: System.Boolean) = "Accordion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.Collapse>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandIconPosition")>] member this.expandIconPosition (_: FunBlazorContext<AntDesign.Collapse>, x: System.String) = "ExpandIconPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultActiveKey")>] member this.defaultActiveKey (_: FunBlazorContext<AntDesign.Collapse>, x: System.String[]) = "DefaultActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Collapse>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandIcon")>] member this.expandIcon (_: FunBlazorContext<AntDesign.Collapse>, x: System.String) = "ExpandIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandIconTemplate")>] member this.expandIconTemplate (_: FunBlazorContext<AntDesign.Collapse>, render: System.Boolean -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ExpandIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Collapse>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Collapse>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Collapse>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Collapse>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Collapse>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Collapse>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Collapse>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Collapse>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = PanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = PanelBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = PanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = PanelBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = PanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("active")>] member this.active (_: FunBlazorContext<AntDesign.Panel>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<AntDesign.Panel>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Panel>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showArrow")>] member this.showArrow (_: FunBlazorContext<AntDesign.Panel>, x: System.Boolean) = "ShowArrow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Panel>, x: System.String) = "Extra" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("extraTemplate")>] member this.extraTemplate (_: FunBlazorContext<AntDesign.Panel>, nodes) = Bolero.Html.attr.fragment "ExtraTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extraTemplate")>] member this.extraTemplate (_: FunBlazorContext<AntDesign.Panel>, x: string) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extraTemplate")>] member this.extraTemplate (_: FunBlazorContext<AntDesign.Panel>, x: int) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extraTemplate")>] member this.extraTemplate (_: FunBlazorContext<AntDesign.Panel>, x: float) = Bolero.Html.attr.fragment "ExtraTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("header")>] member this.header (_: FunBlazorContext<AntDesign.Panel>, x: System.String) = "Header" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerTemplate")>] member this.headerTemplate (_: FunBlazorContext<AntDesign.Panel>, nodes) = Bolero.Html.attr.fragment "HeaderTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerTemplate")>] member this.headerTemplate (_: FunBlazorContext<AntDesign.Panel>, x: string) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerTemplate")>] member this.headerTemplate (_: FunBlazorContext<AntDesign.Panel>, x: int) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerTemplate")>] member this.headerTemplate (_: FunBlazorContext<AntDesign.Panel>, x: float) = Bolero.Html.attr.fragment "HeaderTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onActiveChange")>] member this.onActiveChange (_: FunBlazorContext<AntDesign.Panel>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Panel>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Panel>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Panel>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Panel>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Panel>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Panel>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Panel>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Panel>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CommentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CommentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CommentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CommentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CommentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CommentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("author")>] member this.author (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Author" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorTemplate")>] member this.authorTemplate (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "AuthorTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorTemplate")>] member this.authorTemplate (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorTemplate")>] member this.authorTemplate (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("authorTemplate")>] member this.authorTemplate (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "AuthorTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatar")>] member this.avatar (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("content")>] member this.content (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentTemplate")>] member this.contentTemplate (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentTemplate")>] member this.contentTemplate (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentTemplate")>] member this.contentTemplate (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentTemplate")>] member this.contentTemplate (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("datetime")>] member this.datetime (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Datetime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("datetimeTemplate")>] member this.datetimeTemplate (_: FunBlazorContext<AntDesign.Comment>, nodes) = Bolero.Html.attr.fragment "DatetimeTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("datetimeTemplate")>] member this.datetimeTemplate (_: FunBlazorContext<AntDesign.Comment>, x: string) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("datetimeTemplate")>] member this.datetimeTemplate (_: FunBlazorContext<AntDesign.Comment>, x: int) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("datetimeTemplate")>] member this.datetimeTemplate (_: FunBlazorContext<AntDesign.Comment>, x: float) = Bolero.Html.attr.fragment "DatetimeTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("actions")>] member this.actions (_: FunBlazorContext<AntDesign.Comment>, x: System.Collections.Generic.IList<Microsoft.AspNetCore.Components.RenderFragment>) = "Actions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Comment>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Comment>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Comment>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Comment>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntContainerComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AntContainerComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AntContainerComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AntContainerComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AntContainerComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AntContainerComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tag")>] member this.tag (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: System.String) = "Tag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AntContainerComponentBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntInputComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntInputComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntInputComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AntInputComponentBase<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AutoCompleteBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AutoCompleteBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AutoCompleteBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AutoCompleteBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteBuilder<'FunBlazorGeneric>()

    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultActiveFirstOption")>] member this.defaultActiveFirstOption (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("backfill")>] member this.backfill (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "Backfill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("options")>] member this.options (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Collections.Generic.IEnumerable<'TOption>) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("optionDataItems")>] member this.optionDataItems (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Collections.Generic.IEnumerable<AntDesign.AutoCompleteDataItem<'TOption>>) = "OptionDataItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelectionChange")>] member this.onSelectionChange (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnSelectionChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onActiveChange")>] member this.onActiveChange (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<AntDesign.AutoCompleteOption> "OnActiveChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelVisibleChange")>] member this.onPanelVisibleChange (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnPanelVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("optionTemplate")>] member this.optionTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, render: AntDesign.AutoCompleteDataItem<'TOption> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "OptionTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("optionFormat")>] member this.optionFormat (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String>) = "OptionFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayTemplate")>] member this.overlayTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, nodes) = Bolero.Html.attr.fragment "OverlayTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayTemplate")>] member this.overlayTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: string) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayTemplate")>] member this.overlayTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: int) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayTemplate")>] member this.overlayTemplate (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: float) = Bolero.Html.attr.fragment "OverlayTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("compareWith")>] member this.compareWith (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Func<System.Object, System.Object, System.Boolean>) = "CompareWith" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("filterExpression")>] member this.filterExpression (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Func<AntDesign.AutoCompleteDataItem<'TOption>, System.String, System.Boolean>) = "FilterExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowFilter")>] member this.allowFilter (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "AllowFilter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayClassName")>] member this.overlayClassName (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayStyle")>] member this.overlayStyle (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedItem")>] member this.selectedItem (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: AntDesign.AutoCompleteOption) = "SelectedItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showPanel")>] member this.showPanel (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Boolean) = "ShowPanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AutoComplete<'TOption>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CascaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CascaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CascaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.Cascader>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeOnSelect")>] member this.changeOnSelect (_: FunBlazorContext<AntDesign.Cascader>, x: System.Boolean) = "ChangeOnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandTrigger")>] member this.expandTrigger (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "ExpandTrigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "NotFoundContent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSearch")>] member this.showSearch (_: FunBlazorContext<AntDesign.Cascader>, x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Cascader>, x: System.Action<System.Collections.Generic.List<AntDesign.CascaderNode>, System.String, System.String>) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedNodesChanged")>] member this.selectedNodesChanged (_: FunBlazorContext<AntDesign.Cascader>, fn) = (Bolero.Html.attr.callback<AntDesign.CascaderNode[]> "SelectedNodesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("options")>] member this.options (_: FunBlazorContext<AntDesign.Cascader>, x: System.Collections.Generic.IEnumerable<AntDesign.CascaderNode>) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.Cascader>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.Cascader>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.Cascader>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Cascader>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Cascader>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Cascader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Cascader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Cascader>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CheckboxGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CheckboxGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CheckboxGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CheckboxGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CheckboxGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CheckboxGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("options")>] member this.options (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: OneOf.OneOf<AntDesign.CheckboxOption[], System.String[]>) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mixedMode")>] member this.mixedMode (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: AntDesign.CheckboxGroupMixedMode) = "MixedMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.CheckboxGroup>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.String[]) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.CheckboxGroup>, fn) = (Bolero.Html.attr.callback<System.String[]> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.Linq.Expressions.Expression<System.Func<System.String[]>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String[]>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.CheckboxGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntInputBoolComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChanged")>] member this.checkedChanged (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Boolean) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AntInputBoolComponentBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CheckboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CheckboxBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CheckboxBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CheckboxBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CheckboxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("checkedChange")>] member this.checkedChange (_: FunBlazorContext<AntDesign.Checkbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedExpression")>] member this.checkedExpression (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "CheckedExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("indeterminate")>] member this.indeterminate (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<AntDesign.Checkbox>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Checkbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChanged")>] member this.checkedChanged (_: FunBlazorContext<AntDesign.Checkbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Boolean) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.Checkbox>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Checkbox>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Checkbox>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Checkbox>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Checkbox>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Checkbox>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Checkbox>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SwitchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputBoolComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SwitchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SwitchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChildren")>] member this.checkedChildren (_: FunBlazorContext<AntDesign.Switch>, x: System.String) = "CheckedChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChildrenTemplate")>] member this.checkedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, nodes) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChildrenTemplate")>] member this.checkedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: string) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChildrenTemplate")>] member this.checkedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: int) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChildrenTemplate")>] member this.checkedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: float) = Bolero.Html.attr.fragment "CheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("control")>] member this.control (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Control" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Switch>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unCheckedChildren")>] member this.unCheckedChildren (_: FunBlazorContext<AntDesign.Switch>, x: System.String) = "UnCheckedChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unCheckedChildrenTemplate")>] member this.unCheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, nodes) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("unCheckedChildrenTemplate")>] member this.unCheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: string) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("unCheckedChildrenTemplate")>] member this.unCheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: int) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("unCheckedChildrenTemplate")>] member this.unCheckedChildrenTemplate (_: FunBlazorContext<AntDesign.Switch>, x: float) = Bolero.Html.attr.fragment "UnCheckedChildrenTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Switch>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChanged")>] member this.checkedChanged (_: FunBlazorContext<AntDesign.Switch>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Switch>, x: System.Boolean) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.Switch>, fn) = (Bolero.Html.attr.callback<System.Boolean> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.Switch>, x: System.Linq.Expressions.Expression<System.Func<System.Boolean>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.Switch>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.Boolean>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Switch>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Switch>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Switch>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Switch>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Switch>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Switch>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputReadOnly")>] member this.inputReadOnly (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupStyle")>] member this.popupStyle (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("className")>] member this.className (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownClassName")>] member this.dropdownClassName (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPickerValue")>] member this.defaultPickerValue (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.DatePickerBase<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputReadOnly")>] member this.inputReadOnly (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupStyle")>] member this.popupStyle (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("className")>] member this.className (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownClassName")>] member this.dropdownClassName (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPickerValue")>] member this.defaultPickerValue (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.DatePicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MonthPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerBuilder<'FunBlazorGeneric>()
    static member create () = MonthPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MonthPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputReadOnly")>] member this.inputReadOnly (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupStyle")>] member this.popupStyle (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("className")>] member this.className (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownClassName")>] member this.dropdownClassName (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPickerValue")>] member this.defaultPickerValue (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.MonthPicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type QuarterPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerBuilder<'FunBlazorGeneric>()
    static member create () = QuarterPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = QuarterPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputReadOnly")>] member this.inputReadOnly (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupStyle")>] member this.popupStyle (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("className")>] member this.className (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownClassName")>] member this.dropdownClassName (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPickerValue")>] member this.defaultPickerValue (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.QuarterPicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type WeekPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerBuilder<'FunBlazorGeneric>()
    static member create () = WeekPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = WeekPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputReadOnly")>] member this.inputReadOnly (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupStyle")>] member this.popupStyle (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("className")>] member this.className (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownClassName")>] member this.dropdownClassName (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPickerValue")>] member this.defaultPickerValue (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.WeekPicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type YearPickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerBuilder<'FunBlazorGeneric>()
    static member create () = YearPickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = YearPickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputReadOnly")>] member this.inputReadOnly (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupStyle")>] member this.popupStyle (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("className")>] member this.className (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownClassName")>] member this.dropdownClassName (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPickerValue")>] member this.defaultPickerValue (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.YearPicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TimePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerBuilder<'FunBlazorGeneric>()
    static member create () = TimePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TimePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputReadOnly")>] member this.inputReadOnly (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupStyle")>] member this.popupStyle (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("className")>] member this.className (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownClassName")>] member this.dropdownClassName (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPickerValue")>] member this.defaultPickerValue (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.TimePicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RangePickerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerBaseBuilder<'FunBlazorGeneric>()
    static member create () = RangePickerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RangePickerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateRangeChangedEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputReadOnly")>] member this.inputReadOnly (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "InputReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: OneOf.OneOf<System.Boolean, System.String>) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: OneOf.OneOf<System.String, System.String[]>) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupStyle")>] member this.popupStyle (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "PopupStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("className")>] member this.className (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "ClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownClassName")>] member this.dropdownClassName (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "DropdownClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPickerValue")>] member this.defaultPickerValue (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: 'TValue) = "DefaultPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClearClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPanelChange")>] member this.onPanelChange (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<AntDesign.DateTimeChangedEventArgs> "OnPanelChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.RangePicker<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type InputNumberBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = InputNumberBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputNumberBuilder<'FunBlazorGeneric>()

    [<CustomOperation("formatter")>] member this.formatter (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Func<'TValue, System.String>) = "Formatter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("parser")>] member this.parser (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Func<System.String, System.String>) = "Parser" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("step")>] member this.step (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max")>] member this.max (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("min")>] member this.min (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.InputNumber<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type InputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = InputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.Input<'TValue>>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.Input<'TValue>>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceMilliseconds")>] member this.debounceMilliseconds (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputElementSuffixClass")>] member this.inputElementSuffixClass (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxLength")>] member this.maxLength (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyDown")>] member this.onkeyDown (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyUp")>] member this.onkeyUp (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseUp")>] member this.onMouseUp (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPressEnter")>] member this.onPressEnter (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Input<'TValue>>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Input<'TValue>>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperStyle")>] member this.wrapperStyle (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.Input<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Input<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBuilder<'FunBlazorGeneric>()
    static member create () = AutoCompleteInputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceMilliseconds")>] member this.debounceMilliseconds (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputElementSuffixClass")>] member this.inputElementSuffixClass (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxLength")>] member this.maxLength (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyDown")>] member this.onkeyDown (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyUp")>] member this.onkeyUp (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseUp")>] member this.onMouseUp (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPressEnter")>] member this.onPressEnter (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperStyle")>] member this.wrapperStyle (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AutoCompleteInput<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type InputPasswordBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBuilder<'FunBlazorGeneric>()
    static member create () = InputPasswordBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = InputPasswordBuilder<'FunBlazorGeneric>()

    [<CustomOperation("iconRender")>] member this.iconRender (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "IconRender" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconRender")>] member this.iconRender (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconRender")>] member this.iconRender (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconRender")>] member this.iconRender (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "IconRender" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("showPassword")>] member this.showPassword (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "ShowPassword" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("visibilityToggle")>] member this.visibilityToggle (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "VisibilityToggle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceMilliseconds")>] member this.debounceMilliseconds (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputElementSuffixClass")>] member this.inputElementSuffixClass (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxLength")>] member this.maxLength (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyDown")>] member this.onkeyDown (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyUp")>] member this.onkeyUp (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseUp")>] member this.onMouseUp (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPressEnter")>] member this.onPressEnter (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.InputPassword>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.InputPassword>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.InputPassword>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.InputPassword>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperStyle")>] member this.wrapperStyle (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.InputPassword>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.InputPassword>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.InputPassword>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.InputPassword>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.InputPassword>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.InputPassword>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBuilder<'FunBlazorGeneric>()
    static member create () = SearchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SearchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("classicSearchIcon")>] member this.classicSearchIcon (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("enterButton")>] member this.enterButton (_: FunBlazorContext<AntDesign.Search>, x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSearch")>] member this.onSearch (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.Search>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.Search>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.Search>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.Search>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.Search>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.Search>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.Search>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.Search>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceMilliseconds")>] member this.debounceMilliseconds (_: FunBlazorContext<AntDesign.Search>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputElementSuffixClass")>] member this.inputElementSuffixClass (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxLength")>] member this.maxLength (_: FunBlazorContext<AntDesign.Search>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyDown")>] member this.onkeyDown (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyUp")>] member this.onkeyUp (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseUp")>] member this.onMouseUp (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPressEnter")>] member this.onPressEnter (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Search>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Search>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Search>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Search>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<AntDesign.Search>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Search>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Search>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Search>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Search>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperStyle")>] member this.wrapperStyle (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.Search>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.Search>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.Search>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Search>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Search>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Search>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Search>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Search>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AutoCompleteSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit SearchBuilder<'FunBlazorGeneric>()
    static member create () = AutoCompleteSearchBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AutoCompleteSearchBuilder<'FunBlazorGeneric>()

    [<CustomOperation("classicSearchIcon")>] member this.classicSearchIcon (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "ClassicSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("enterButton")>] member this.enterButton (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: OneOf.OneOf<System.Boolean, System.String>) = "EnterButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSearch")>] member this.onSearch (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<System.String> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceMilliseconds")>] member this.debounceMilliseconds (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputElementSuffixClass")>] member this.inputElementSuffixClass (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxLength")>] member this.maxLength (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyDown")>] member this.onkeyDown (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyUp")>] member this.onkeyUp (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseUp")>] member this.onMouseUp (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPressEnter")>] member this.onPressEnter (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperStyle")>] member this.wrapperStyle (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AutoCompleteSearch>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TextAreaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit InputBuilder<'FunBlazorGeneric>()
    static member create () = TextAreaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TextAreaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("autoSize")>] member this.autoSize (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "AutoSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultToEmptyString")>] member this.defaultToEmptyString (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "DefaultToEmptyString" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxRows")>] member this.maxRows (_: FunBlazorContext<AntDesign.TextArea>, x: System.UInt32) = "MaxRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("minRows")>] member this.minRows (_: FunBlazorContext<AntDesign.TextArea>, x: System.UInt32) = "MinRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onResize")>] member this.onResize (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<AntDesign.OnResizeEventArgs> "OnResize" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("showCount")>] member this.showCount (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "ShowCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.TextArea>, nodes) = Bolero.Html.attr.fragment "AddOnBefore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.TextArea>, x: string) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.TextArea>, x: int) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnBefore")>] member this.addOnBefore (_: FunBlazorContext<AntDesign.TextArea>, x: float) = Bolero.Html.attr.fragment "AddOnBefore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.TextArea>, nodes) = Bolero.Html.attr.fragment "AddOnAfter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.TextArea>, x: string) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.TextArea>, x: int) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("addOnAfter")>] member this.addOnAfter (_: FunBlazorContext<AntDesign.TextArea>, x: float) = Bolero.Html.attr.fragment "AddOnAfter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("debounceMilliseconds")>] member this.debounceMilliseconds (_: FunBlazorContext<AntDesign.TextArea>, x: System.Int32) = "DebounceMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inputElementSuffixClass")>] member this.inputElementSuffixClass (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "InputElementSuffixClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxLength")>] member this.maxLength (_: FunBlazorContext<AntDesign.TextArea>, x: System.Int32) = "MaxLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyDown")>] member this.onkeyDown (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onkeyUp")>] member this.onkeyUp (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnkeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseUp")>] member this.onMouseUp (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMouseUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPressEnter")>] member this.onPressEnter (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnPressEnter" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.TextArea>, nodes) = Bolero.Html.attr.fragment "Prefix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.TextArea>, x: string) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.TextArea>, x: int) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.TextArea>, x: float) = Bolero.Html.attr.fragment "Prefix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<AntDesign.TextArea>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.TextArea>, nodes) = Bolero.Html.attr.fragment "Suffix" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.TextArea>, x: string) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.TextArea>, x: int) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.TextArea>, x: float) = Bolero.Html.attr.fragment "Suffix" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperStyle")>] member this.wrapperStyle (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "WrapperStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.TextArea>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.TextArea>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.TextArea>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.TextArea>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.TextArea>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.TextArea>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.TextArea>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.TextArea>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RadioGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = RadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RadioGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RadioGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RadioGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = RadioGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buttonStyle")>] member this.buttonStyle (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.String) = "ButtonStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.RadioGroup<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SelectBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SelectBuilder<'FunBlazorGeneric>()

    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoClearSearchValue")>] member this.autoClearSearchValue (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateCustomTag")>] member this.onCreateCustomTag (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultActiveFirstOption")>] member this.defaultActiveFirstOption (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledName")>] member this.disabledName (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "DisabledName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownRender")>] member this.dropdownRender (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("enableSearch")>] member this.enableSearch (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("groupName")>] member this.groupName (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "GroupName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideSelected")>] member this.hideSelected (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ignoreItemChanges")>] member this.ignoreItemChanges (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemTemplate")>] member this.itemTemplate (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelInValue")>] member this.labelInValue (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelName")>] member this.labelName (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "LabelName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelTemplate")>] member this.labelTemplate (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxTagTextLength")>] member this.maxTagTextLength (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxTagCount")>] member this.maxTagCount (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxTagPlaceholder")>] member this.maxTagPlaceholder (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, render: System.Collections.Generic.IEnumerable<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "MaxTagPlaceholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("mode")>] member this.mode (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, nodes) = Bolero.Html.attr.fragment "NotFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: int) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: float) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnBlur" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearSelected")>] member this.onClearSelected (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDataSourceChanged")>] member this.onDataSourceChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDropdownVisibleChange")>] member this.onDropdownVisibleChange (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSearch")>] member this.onSearch (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelectedItemChanged")>] member this.onSelectedItemChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<'TItem>) = "OnSelectedItemChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelectedItemsChanged")>] member this.onSelectedItemsChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Action<System.Collections.Generic.IEnumerable<'TItem>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerMaxHeight")>] member this.popupContainerMaxHeight (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownMatchSelectWidth")>] member this.dropdownMatchSelectWidth (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownMaxWidth")>] member this.dropdownMaxWidth (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showArrowIcon")>] member this.showArrowIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSearchIcon")>] member this.showSearchIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortByGroup")>] member this.sortByGroup (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortByLabel")>] member this.sortByLabel (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixIcon")>] member this.prefixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, nodes) = Bolero.Html.attr.fragment "PrefixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixIcon")>] member this.prefixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixIcon")>] member this.prefixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: int) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixIcon")>] member this.prefixIcon (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: float) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tokenSeparators")>] member this.tokenSeparators (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Char[]) = "TokenSeparators" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<'TItemValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueName")>] member this.valueName (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "ValueName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesChanged")>] member this.valuesChanged (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItemValue>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("customTagLabelToValue")>] member this.customTagLabelToValue (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Func<System.String, 'TItemValue>) = "CustomTagLabelToValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dataSource")>] member this.dataSource (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: 'TItemValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: 'TItemValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("values")>] member this.values (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Collections.Generic.IEnumerable<'TItemValue>) = "Values" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValues")>] member this.defaultValues (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Collections.Generic.IEnumerable<'TItemValue>) = "DefaultValues" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectOptions")>] member this.selectOptions (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, nodes) = Bolero.Html.attr.fragment "SelectOptions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectOptions")>] member this.selectOptions (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectOptions")>] member this.selectOptions (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: int) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectOptions")>] member this.selectOptions (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: float) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Linq.Expressions.Expression<System.Func<'TItemValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TItemValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Select<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SimpleSelectBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit SelectBuilder<'FunBlazorGeneric>()
    static member create () = SimpleSelectBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SimpleSelectBuilder<'FunBlazorGeneric>()

    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoClearSearchValue")>] member this.autoClearSearchValue (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "AutoClearSearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCreateCustomTag")>] member this.onCreateCustomTag (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.String>) = "OnCreateCustomTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultActiveFirstOption")>] member this.defaultActiveFirstOption (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "DefaultActiveFirstOption" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledName")>] member this.disabledName (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "DisabledName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownRender")>] member this.dropdownRender (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "DropdownRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("enableSearch")>] member this.enableSearch (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "EnableSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("groupName")>] member this.groupName (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "GroupName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideSelected")>] member this.hideSelected (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "HideSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ignoreItemChanges")>] member this.ignoreItemChanges (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "IgnoreItemChanges" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemTemplate")>] member this.itemTemplate (_: FunBlazorContext<AntDesign.SimpleSelect>, render: System.String -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelInValue")>] member this.labelInValue (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "LabelInValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelName")>] member this.labelName (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "LabelName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelTemplate")>] member this.labelTemplate (_: FunBlazorContext<AntDesign.SimpleSelect>, render: System.String -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxTagTextLength")>] member this.maxTagTextLength (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Int32) = "MaxTagTextLength" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxTagCount")>] member this.maxTagCount (_: FunBlazorContext<AntDesign.SimpleSelect>, x: OneOf.OneOf<System.Int32, AntDesign.Select.ResponsiveTag>) = "MaxTagCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxTagPlaceholder")>] member this.maxTagPlaceholder (_: FunBlazorContext<AntDesign.SimpleSelect>, render: System.Collections.Generic.IEnumerable<System.String> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "MaxTagPlaceholder" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("mode")>] member this.mode (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.SimpleSelect>, nodes) = Bolero.Html.attr.fragment "NotFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.SimpleSelect>, x: int) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("notFoundContent")>] member this.notFoundContent (_: FunBlazorContext<AntDesign.SimpleSelect>, x: float) = Bolero.Html.attr.fragment "NotFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnBlur" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearSelected")>] member this.onClearSelected (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnClearSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDataSourceChanged")>] member this.onDataSourceChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnDataSourceChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDropdownVisibleChange")>] member this.onDropdownVisibleChange (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.Boolean>) = "OnDropdownVisibleChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSearch")>] member this.onSearch (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.String>) = "OnSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelectedItemChanged")>] member this.onSelectedItemChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.String>) = "OnSelectedItemChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelectedItemsChanged")>] member this.onSelectedItemsChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Action<System.Collections.Generic.IEnumerable<System.String>>) = "OnSelectedItemsChanged" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("open'")>] member this.open' (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "Open" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerMaxHeight")>] member this.popupContainerMaxHeight (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "PopupContainerMaxHeight" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownMatchSelectWidth")>] member this.dropdownMatchSelectWidth (_: FunBlazorContext<AntDesign.SimpleSelect>, x: OneOf.OneOf<System.Boolean, System.String>) = "DropdownMatchSelectWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dropdownMaxWidth")>] member this.dropdownMaxWidth (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "DropdownMaxWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showArrowIcon")>] member this.showArrowIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "ShowArrowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSearchIcon")>] member this.showSearchIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Boolean) = "ShowSearchIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortByGroup")>] member this.sortByGroup (_: FunBlazorContext<AntDesign.SimpleSelect>, x: AntDesign.SortDirection) = "SortByGroup" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortByLabel")>] member this.sortByLabel (_: FunBlazorContext<AntDesign.SimpleSelect>, x: AntDesign.SortDirection) = "SortByLabel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixIcon")>] member this.prefixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, nodes) = Bolero.Html.attr.fragment "PrefixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixIcon")>] member this.prefixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixIcon")>] member this.prefixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: int) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixIcon")>] member this.prefixIcon (_: FunBlazorContext<AntDesign.SimpleSelect>, x: float) = Bolero.Html.attr.fragment "PrefixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tokenSeparators")>] member this.tokenSeparators (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Char[]) = "TokenSeparators" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueName")>] member this.valueName (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "ValueName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesChanged")>] member this.valuesChanged (_: FunBlazorContext<AntDesign.SimpleSelect>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<System.String>> "ValuesChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("customTagLabelToValue")>] member this.customTagLabelToValue (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Func<System.String, System.String>) = "CustomTagLabelToValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dataSource")>] member this.dataSource (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Collections.Generic.IEnumerable<System.String>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("values")>] member this.values (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Collections.Generic.IEnumerable<System.String>) = "Values" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValues")>] member this.defaultValues (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultValues" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectOptions")>] member this.selectOptions (_: FunBlazorContext<AntDesign.SimpleSelect>, nodes) = Bolero.Html.attr.fragment "SelectOptions" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectOptions")>] member this.selectOptions (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectOptions")>] member this.selectOptions (_: FunBlazorContext<AntDesign.SimpleSelect>, x: int) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectOptions")>] member this.selectOptions (_: FunBlazorContext<AntDesign.SimpleSelect>, x: float) = Bolero.Html.attr.fragment "SelectOptions" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Linq.Expressions.Expression<System.Func<System.String>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<System.String>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.SimpleSelect>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.SimpleSelect>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.SimpleSelect>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.SimpleSelect>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SliderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntInputComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SliderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SliderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: 'TValue) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dots")>] member this.dots (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Dots" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("included")>] member this.included (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Included" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("marks")>] member this.marks (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: AntDesign.SliderMark[]) = "Marks" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("max")>] member this.max (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Double) = "Max" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("min")>] member this.min (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Double) = "Min" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("reverse")>] member this.reverse (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Reverse" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("step")>] member this.step (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Nullable<System.Double>) = "Step" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("vertical")>] member this.vertical (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "Vertical" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAfterChange")>] member this.onAfterChange (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Action<'TValue>) = "OnAfterChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Action<'TValue>) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hasTooltip")>] member this.hasTooltip (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "HasTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tipFormatter")>] member this.tipFormatter (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Func<System.Double, System.String>) = "TipFormatter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tooltipPlacement")>] member this.tooltipPlacement (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: AntDesign.PlacementType) = "TooltipPlacement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tooltipVisible")>] member this.tooltipVisible (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Boolean) = "TooltipVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getTooltipPopupContainer")>] member this.getTooltipPopupContainer (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Object) = "GetTooltipPopupContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.Slider<'TValue>>, fn) = (Bolero.Html.attr.callback<'TValue> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueExpression")>] member this.valueExpression (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<'TValue>>) = "ValueExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valuesExpression")>] member this.valuesExpression (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Linq.Expressions.Expression<System.Func<System.Collections.Generic.IEnumerable<'TValue>>>) = "ValuesExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Slider<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DescriptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DescriptionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DescriptionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DescriptionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DescriptionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DescriptionsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.Descriptions>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("layout")>] member this.layout (_: FunBlazorContext<AntDesign.Descriptions>, x: System.String) = "Layout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("column")>] member this.column (_: FunBlazorContext<AntDesign.Descriptions>, x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>) = "Column" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Descriptions>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Descriptions>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Descriptions>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Descriptions>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Descriptions>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Descriptions>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("colon")>] member this.colon (_: FunBlazorContext<AntDesign.Descriptions>, x: System.Boolean) = "Colon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Descriptions>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Descriptions>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Descriptions>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Descriptions>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Descriptions>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Descriptions>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Descriptions>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Descriptions>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DescriptionsItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DescriptionsItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DescriptionsItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DescriptionsItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DescriptionsItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DescriptionsItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.DescriptionsItem>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("span")>] member this.span (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: System.Int32) = "Span" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DescriptionsItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.DescriptionsItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DividerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DividerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DividerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DividerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DividerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Divider>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Divider>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Divider>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Divider>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("text")>] member this.text (_: FunBlazorContext<AntDesign.Divider>, x: System.String) = "Text" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("plain")>] member this.plain (_: FunBlazorContext<AntDesign.Divider>, x: System.Boolean) = "Plain" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Divider>, x: AntDesign.DirectionVHType) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("orientation")>] member this.orientation (_: FunBlazorContext<AntDesign.Divider>, x: System.String) = "Orientation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dashed")>] member this.dashed (_: FunBlazorContext<AntDesign.Divider>, x: System.Boolean) = "Dashed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Divider>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Divider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Divider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Divider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DrawerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DrawerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DrawerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Drawer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Drawer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Drawer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Drawer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("content")>] member this.content (_: FunBlazorContext<AntDesign.Drawer>, x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closable")>] member this.closable (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maskClosable")>] member this.maskClosable (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mask")>] member this.mask (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "Mask" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("noAnimation")>] member this.noAnimation (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "NoAnimation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyboard")>] member this.keyboard (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Drawer>, x: OneOf.OneOf<Microsoft.AspNetCore.Components.RenderFragment, System.String>) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maskStyle")>] member this.maskStyle (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "MaskStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bodyStyle")>] member this.bodyStyle (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapClassName")>] member this.wrapClassName (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "WrapClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("zIndex")>] member this.zIndex (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetX")>] member this.offsetX (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "OffsetX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offsetY")>] member this.offsetY (_: FunBlazorContext<AntDesign.Drawer>, x: System.Int32) = "OffsetY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Drawer>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClose")>] member this.onClose (_: FunBlazorContext<AntDesign.Drawer>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("handler")>] member this.handler (_: FunBlazorContext<AntDesign.Drawer>, nodes) = Bolero.Html.attr.fragment "Handler" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("handler")>] member this.handler (_: FunBlazorContext<AntDesign.Drawer>, x: string) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("handler")>] member this.handler (_: FunBlazorContext<AntDesign.Drawer>, x: int) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("handler")>] member this.handler (_: FunBlazorContext<AntDesign.Drawer>, x: float) = Bolero.Html.attr.fragment "Handler" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Drawer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Drawer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Drawer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Drawer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DrawerContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DrawerContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DrawerContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.DrawerContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.DrawerContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.DrawerContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.DrawerContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type EmptyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = EmptyBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = EmptyBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = EmptyBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = EmptyBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = EmptyBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Empty>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("imageStyle")>] member this.imageStyle (_: FunBlazorContext<AntDesign.Empty>, x: System.String) = "ImageStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("small")>] member this.small (_: FunBlazorContext<AntDesign.Empty>, x: System.Boolean) = "Small" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("simple")>] member this.simple (_: FunBlazorContext<AntDesign.Empty>, x: System.Boolean) = "Simple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Empty>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Empty>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Empty>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Empty>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("description")>] member this.description (_: FunBlazorContext<AntDesign.Empty>, x: OneOf.OneOf<System.String, System.Nullable<System.Boolean>>) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.Empty>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.Empty>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.Empty>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.Empty>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("image")>] member this.image (_: FunBlazorContext<AntDesign.Empty>, x: System.String) = "Image" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("imageTemplate")>] member this.imageTemplate (_: FunBlazorContext<AntDesign.Empty>, nodes) = Bolero.Html.attr.fragment "ImageTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("imageTemplate")>] member this.imageTemplate (_: FunBlazorContext<AntDesign.Empty>, x: string) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("imageTemplate")>] member this.imageTemplate (_: FunBlazorContext<AntDesign.Empty>, x: int) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("imageTemplate")>] member this.imageTemplate (_: FunBlazorContext<AntDesign.Empty>, x: float) = Bolero.Html.attr.fragment "ImageTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Empty>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Empty>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Empty>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Empty>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FormBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = FormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FormBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FormBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = FormBuilder<'FunBlazorGeneric>()

    [<CustomOperation("layout")>] member this.layout (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.String) = "Layout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Form<'TModel>>, render: 'TModel -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelCol")>] member this.labelCol (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelAlign")>] member this.labelAlign (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelColSpan")>] member this.labelColSpan (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelColOffset")>] member this.labelColOffset (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperCol")>] member this.wrapperCol (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperColSpan")>] member this.wrapperColSpan (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperColOffset")>] member this.wrapperColOffset (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("model")>] member this.model (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: 'TModel) = "Model" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFinish")>] member this.onFinish (_: FunBlazorContext<AntDesign.Form<'TModel>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinish" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFinishFailed")>] member this.onFinishFailed (_: FunBlazorContext<AntDesign.Form<'TModel>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Forms.EditContext> "OnFinishFailed" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("validator")>] member this.validator (_: FunBlazorContext<AntDesign.Form<'TModel>>, nodes) = Bolero.Html.attr.fragment "Validator" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("validator")>] member this.validator (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: string) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("validator")>] member this.validator (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: int) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("validator")>] member this.validator (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: float) = Bolero.Html.attr.fragment "Validator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("validateOnChange")>] member this.validateOnChange (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.Boolean) = "ValidateOnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Form<'TModel>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FormItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = FormItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FormItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FormItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FormItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = FormItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.FormItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.FormItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.FormItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.FormItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<AntDesign.FormItem>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelTemplate")>] member this.labelTemplate (_: FunBlazorContext<AntDesign.FormItem>, nodes) = Bolero.Html.attr.fragment "LabelTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelTemplate")>] member this.labelTemplate (_: FunBlazorContext<AntDesign.FormItem>, x: string) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelTemplate")>] member this.labelTemplate (_: FunBlazorContext<AntDesign.FormItem>, x: int) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelTemplate")>] member this.labelTemplate (_: FunBlazorContext<AntDesign.FormItem>, x: float) = Bolero.Html.attr.fragment "LabelTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelCol")>] member this.labelCol (_: FunBlazorContext<AntDesign.FormItem>, x: AntDesign.ColLayoutParam) = "LabelCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelAlign")>] member this.labelAlign (_: FunBlazorContext<AntDesign.FormItem>, x: System.Nullable<AntDesign.AntLabelAlignType>) = "LabelAlign" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelColSpan")>] member this.labelColSpan (_: FunBlazorContext<AntDesign.FormItem>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelColOffset")>] member this.labelColOffset (_: FunBlazorContext<AntDesign.FormItem>, x: OneOf.OneOf<System.String, System.Int32>) = "LabelColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperCol")>] member this.wrapperCol (_: FunBlazorContext<AntDesign.FormItem>, x: AntDesign.ColLayoutParam) = "WrapperCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperColSpan")>] member this.wrapperColSpan (_: FunBlazorContext<AntDesign.FormItem>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperColOffset")>] member this.wrapperColOffset (_: FunBlazorContext<AntDesign.FormItem>, x: OneOf.OneOf<System.String, System.Int32>) = "WrapperColOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("noStyle")>] member this.noStyle (_: FunBlazorContext<AntDesign.FormItem>, x: System.Boolean) = "NoStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("required")>] member this.required (_: FunBlazorContext<AntDesign.FormItem>, x: System.Boolean) = "Required" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.FormItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.FormItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.FormItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.FormItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ColBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ColBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Col>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Col>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Col>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Col>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("flex")>] member this.flex (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("span")>] member this.span (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("order")>] member this.order (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offset")>] member this.offset (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("push")>] member this.push (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pull")>] member this.pull (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xs")>] member this.xs (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sm")>] member this.sm (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("md")>] member this.md (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lg")>] member this.lg (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xl")>] member this.xl (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xxl")>] member this.xxl (_: FunBlazorContext<AntDesign.Col>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Col>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Col>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Col>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Col>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type GridColBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit ColBuilder<'FunBlazorGeneric>()
    new (x: string) as this = GridColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = GridColBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = GridColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = GridColBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = GridColBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.GridCol>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.GridCol>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.GridCol>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.GridCol>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("flex")>] member this.flex (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Flex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("span")>] member this.span (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Span" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("order")>] member this.order (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Order" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("offset")>] member this.offset (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Offset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("push")>] member this.push (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Push" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pull")>] member this.pull (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.String, System.Int32>) = "Pull" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xs")>] member this.xs (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xs" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sm")>] member this.sm (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Sm" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("md")>] member this.md (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Md" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("lg")>] member this.lg (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Lg" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xl")>] member this.xl (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("xxl")>] member this.xxl (_: FunBlazorContext<AntDesign.GridCol>, x: OneOf.OneOf<System.Int32, AntDesign.EmbeddedProperty>) = "Xxl" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.GridCol>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.GridCol>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.GridCol>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.GridCol>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RowBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = RowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RowBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RowBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = RowBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Row>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Row>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Row>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Row>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Row>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("align")>] member this.align (_: FunBlazorContext<AntDesign.Row>, x: System.String) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("justify")>] member this.justify (_: FunBlazorContext<AntDesign.Row>, x: System.String) = "Justify" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrap")>] member this.wrap (_: FunBlazorContext<AntDesign.Row>, x: System.Boolean) = "Wrap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("gutter")>] member this.gutter (_: FunBlazorContext<AntDesign.Row>, x: OneOf.OneOf<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>, System.ValueTuple<System.Int32, System.Int32>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Int32>, System.ValueTuple<System.Int32, System.Collections.Generic.Dictionary<System.String, System.Int32>>, System.ValueTuple<System.Collections.Generic.Dictionary<System.String, System.Int32>, System.Collections.Generic.Dictionary<System.String, System.Int32>>>) = "Gutter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBreakpoint")>] member this.onBreakpoint (_: FunBlazorContext<AntDesign.Row>, fn) = (Bolero.Html.attr.callback<AntDesign.BreakpointType> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultBreakpoint")>] member this.defaultBreakpoint (_: FunBlazorContext<AntDesign.Row>, x: AntDesign.BreakpointType) = "DefaultBreakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Row>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Row>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Row>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Row>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type IconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = IconBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = IconBuilder<'FunBlazorGeneric>()

    [<CustomOperation("spin")>] member this.spin (_: FunBlazorContext<AntDesign.Icon>, x: System.Boolean) = "Spin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rotate")>] member this.rotate (_: FunBlazorContext<AntDesign.Icon>, x: System.Int32) = "Rotate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("theme")>] member this.theme (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("twotoneColor")>] member this.twotoneColor (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "TwotoneColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconFont")>] member this.iconFont (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "IconFont" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fill")>] member this.fill (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Fill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabIndex")>] member this.tabIndex (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "TabIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("stopPropagation")>] member this.stopPropagation (_: FunBlazorContext<AntDesign.Icon>, x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Icon>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("component'")>] member this.component' (_: FunBlazorContext<AntDesign.Icon>, nodes) = Bolero.Html.attr.fragment "Component" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("component'")>] member this.component' (_: FunBlazorContext<AntDesign.Icon>, x: string) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("component'")>] member this.component' (_: FunBlazorContext<AntDesign.Icon>, x: int) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("component'")>] member this.component' (_: FunBlazorContext<AntDesign.Icon>, x: float) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Icon>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Icon>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Icon>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Icon>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type IconFontBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit IconBuilder<'FunBlazorGeneric>()
    static member create () = IconFontBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = IconFontBuilder<'FunBlazorGeneric>()

    [<CustomOperation("spin")>] member this.spin (_: FunBlazorContext<AntDesign.IconFont>, x: System.Boolean) = "Spin" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rotate")>] member this.rotate (_: FunBlazorContext<AntDesign.IconFont>, x: System.Int32) = "Rotate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("theme")>] member this.theme (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("twotoneColor")>] member this.twotoneColor (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "TwotoneColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconFont")>] member this.iconFont (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "IconFont" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fill")>] member this.fill (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Fill" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabIndex")>] member this.tabIndex (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "TabIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("stopPropagation")>] member this.stopPropagation (_: FunBlazorContext<AntDesign.IconFont>, x: System.Boolean) = "StopPropagation" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.IconFont>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("component'")>] member this.component' (_: FunBlazorContext<AntDesign.IconFont>, nodes) = Bolero.Html.attr.fragment "Component" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("component'")>] member this.component' (_: FunBlazorContext<AntDesign.IconFont>, x: string) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("component'")>] member this.component' (_: FunBlazorContext<AntDesign.IconFont>, x: int) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("component'")>] member this.component' (_: FunBlazorContext<AntDesign.IconFont>, x: float) = Bolero.Html.attr.fragment "Component" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.IconFont>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.IconFont>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.IconFont>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.IconFont>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ImageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ImageBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ImageBuilder<'FunBlazorGeneric>()

    [<CustomOperation("alt")>] member this.alt (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Alt" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fallback")>] member this.fallback (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Fallback" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("height")>] member this.height (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Height" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Image>, nodes) = Bolero.Html.attr.fragment "Placeholder" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Image>, x: string) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Image>, x: int) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Image>, x: float) = Bolero.Html.attr.fragment "Placeholder" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("preview")>] member this.preview (_: FunBlazorContext<AntDesign.Image>, x: System.Boolean) = "Preview" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("src")>] member this.src (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Src" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("previewSrc")>] member this.previewSrc (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "PreviewSrc" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Image>, x: AntDesign.ImageLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Image>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Image>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Image>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Image>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ImagePreviewContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ImagePreviewContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ImagePreviewContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ImagePreviewContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ImagePreviewContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ImagePreviewContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type InputGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = InputGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = InputGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = InputGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = InputGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = InputGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.InputGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.InputGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.InputGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.InputGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("compact")>] member this.compact (_: FunBlazorContext<AntDesign.InputGroup>, x: System.Boolean) = "Compact" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.InputGroup>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.InputGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.InputGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.InputGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.InputGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SiderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SiderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SiderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SiderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SiderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SiderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("collapsible")>] member this.collapsible (_: FunBlazorContext<AntDesign.Sider>, x: System.Boolean) = "Collapsible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Sider>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Sider>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Sider>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Sider>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Sider>, nodes) = Bolero.Html.attr.fragment "Trigger" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Sider>, x: string) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Sider>, x: int) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Sider>, x: float) = Bolero.Html.attr.fragment "Trigger" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("noTrigger")>] member this.noTrigger (_: FunBlazorContext<AntDesign.Sider>, x: System.Boolean) = "NoTrigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("breakpoint")>] member this.breakpoint (_: FunBlazorContext<AntDesign.Sider>, x: AntDesign.BreakpointType) = "Breakpoint" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("theme")>] member this.theme (_: FunBlazorContext<AntDesign.Sider>, x: AntDesign.SiderTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.Sider>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("collapsedWidth")>] member this.collapsedWidth (_: FunBlazorContext<AntDesign.Sider>, x: System.Int32) = "CollapsedWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("collapsed")>] member this.collapsed (_: FunBlazorContext<AntDesign.Sider>, x: System.Boolean) = "Collapsed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCollapse")>] member this.onCollapse (_: FunBlazorContext<AntDesign.Sider>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBreakpoint")>] member this.onBreakpoint (_: FunBlazorContext<AntDesign.Sider>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnBreakpoint" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Sider>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Sider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Sider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Sider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AntListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = AntListBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = AntListBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = AntListBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = AntListBuilder<'FunBlazorGeneric>()

    [<CustomOperation("dataSource")>] member this.dataSource (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("header")>] member this.header (_: FunBlazorContext<AntDesign.AntList<'TItem>>, nodes) = Bolero.Html.attr.fragment "Header" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("header")>] member this.header (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: string) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("header")>] member this.header (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: int) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("header")>] member this.header (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: float) = Bolero.Html.attr.fragment "Header" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footer")>] member this.footer (_: FunBlazorContext<AntDesign.AntList<'TItem>>, nodes) = Bolero.Html.attr.fragment "Footer" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footer")>] member this.footer (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: string) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footer")>] member this.footer (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: int) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footer")>] member this.footer (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: float) = Bolero.Html.attr.fragment "Footer" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("loadMore")>] member this.loadMore (_: FunBlazorContext<AntDesign.AntList<'TItem>>, nodes) = Bolero.Html.attr.fragment "LoadMore" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("loadMore")>] member this.loadMore (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: string) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("loadMore")>] member this.loadMore (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: int) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("loadMore")>] member this.loadMore (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: float) = Bolero.Html.attr.fragment "LoadMore" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemLayout")>] member this.itemLayout (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: AntDesign.ListItemLayout) = "ItemLayout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("noResult")>] member this.noResult (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.String) = "NoResult" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("split")>] member this.split (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.Boolean) = "Split" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onItemClick")>] member this.onItemClick (_: FunBlazorContext<AntDesign.AntList<'TItem>>, fn) = (Bolero.Html.attr.callback<'TItem> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("grid")>] member this.grid (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pagination")>] member this.pagination (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: AntDesign.PaginationOptions) = "Pagination" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.AntList<'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AntList<'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ListItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ListItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ListItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ListItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("content")>] member this.content (_: FunBlazorContext<AntDesign.ListItem>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.ListItem>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.ListItem>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.ListItem>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.ListItem>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("actions")>] member this.actions (_: FunBlazorContext<AntDesign.ListItem>, x: Microsoft.AspNetCore.Components.RenderFragment[]) = "Actions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("grid")>] member this.grid (_: FunBlazorContext<AntDesign.ListItem>, x: AntDesign.ListGridType) = "Grid" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ListItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ListItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ListItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ListItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("colStyle")>] member this.colStyle (_: FunBlazorContext<AntDesign.ListItem>, x: System.String) = "ColStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemCount")>] member this.itemCount (_: FunBlazorContext<AntDesign.ListItem>, x: System.Int32) = "ItemCount" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.ListItem>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("noFlex")>] member this.noFlex (_: FunBlazorContext<AntDesign.ListItem>, x: System.Boolean) = "NoFlex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ListItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ListItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ListItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ListItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ListItemMetaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ListItemMetaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ListItemMetaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.ListItemMeta>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatar")>] member this.avatar (_: FunBlazorContext<AntDesign.ListItemMeta>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("description")>] member this.description (_: FunBlazorContext<AntDesign.ListItemMeta>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.ListItemMeta>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ListItemMeta>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ListItemMeta>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ListItemMeta>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ListItemMeta>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MentionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MentionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MentionsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MentionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MentionsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MentionsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.Mentions>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disable")>] member this.disable (_: FunBlazorContext<AntDesign.Mentions>, x: System.Boolean) = "Disable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readonly")>] member this.readonly (_: FunBlazorContext<AntDesign.Mentions>, x: System.Boolean) = "Readonly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("split")>] member this.split (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Split" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rows")>] member this.rows (_: FunBlazorContext<AntDesign.Mentions>, x: System.Int32) = "Rows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Mentions>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Mentions>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Mentions>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Mentions>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Mentions>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChange")>] member this.valueChange (_: FunBlazorContext<AntDesign.Mentions>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.Mentions>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.Mentions>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSearch")>] member this.onSearch (_: FunBlazorContext<AntDesign.Mentions>, fn) = (Bolero.Html.attr.callback<System.EventArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("noFoundContent")>] member this.noFoundContent (_: FunBlazorContext<AntDesign.Mentions>, nodes) = Bolero.Html.attr.fragment "NoFoundContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("noFoundContent")>] member this.noFoundContent (_: FunBlazorContext<AntDesign.Mentions>, x: string) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("noFoundContent")>] member this.noFoundContent (_: FunBlazorContext<AntDesign.Mentions>, x: int) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("noFoundContent")>] member this.noFoundContent (_: FunBlazorContext<AntDesign.Mentions>, x: float) = Bolero.Html.attr.fragment "NoFoundContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Mentions>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Mentions>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Mentions>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Mentions>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MentionsOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MentionsOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MentionsOptionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MentionsOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MentionsOptionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MentionsOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.MentionsOption>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disable")>] member this.disable (_: FunBlazorContext<AntDesign.MentionsOption>, x: System.Boolean) = "Disable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MentionsOption>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MentionsOption>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MentionsOption>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MentionsOption>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.MentionsOption>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.MentionsOption>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.MentionsOption>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.MentionsOption>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("theme")>] member this.theme (_: FunBlazorContext<AntDesign.Menu>, x: AntDesign.MenuTheme) = "Theme" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mode")>] member this.mode (_: FunBlazorContext<AntDesign.Menu>, x: AntDesign.MenuMode) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Menu>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Menu>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Menu>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Menu>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSubmenuClicked")>] member this.onSubmenuClicked (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<AntDesign.SubMenu> "OnSubmenuClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMenuItemClicked")>] member this.onMenuItemClicked (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<AntDesign.MenuItem> "OnMenuItemClicked" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("accordion")>] member this.accordion (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "Accordion" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectable")>] member this.selectable (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "Selectable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiple")>] member this.multiple (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineCollapsed")>] member this.inlineCollapsed (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "InlineCollapsed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineIndent")>] member this.inlineIndent (_: FunBlazorContext<AntDesign.Menu>, x: System.Int32) = "InlineIndent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoCloseDropdown")>] member this.autoCloseDropdown (_: FunBlazorContext<AntDesign.Menu>, x: System.Boolean) = "AutoCloseDropdown" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultSelectedKeys")>] member this.defaultSelectedKeys (_: FunBlazorContext<AntDesign.Menu>, x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultSelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultOpenKeys")>] member this.defaultOpenKeys (_: FunBlazorContext<AntDesign.Menu>, x: System.Collections.Generic.IEnumerable<System.String>) = "DefaultOpenKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openKeys")>] member this.openKeys (_: FunBlazorContext<AntDesign.Menu>, x: System.String[]) = "OpenKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("openKeysChanged")>] member this.openKeysChanged (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<System.String[]> "OpenKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOpenChange")>] member this.onOpenChange (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnOpenChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedKeys")>] member this.selectedKeys (_: FunBlazorContext<AntDesign.Menu>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedKeysChanged")>] member this.selectedKeysChanged (_: FunBlazorContext<AntDesign.Menu>, fn) = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("triggerSubMenuAction")>] member this.triggerSubMenuAction (_: FunBlazorContext<AntDesign.Menu>, x: AntDesign.TriggerType) = "TriggerSubMenuAction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Menu>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Menu>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Menu>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Menu>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MenuItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.MenuItem>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.MenuItem>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("routerLink")>] member this.routerLink (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "RouterLink" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("routerMatch")>] member this.routerMatch (_: FunBlazorContext<AntDesign.MenuItem>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "RouterMatch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.MenuItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.MenuItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.MenuItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.MenuItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuItemGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MenuItemGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuItemGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuItemGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuItemGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MenuItemGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.MenuItemGroup>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuItemGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.MenuItemGroup>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuLinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = MenuLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = MenuLinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = MenuLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = MenuLinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = MenuLinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("activeClass")>] member this.activeClass (_: FunBlazorContext<AntDesign.MenuLink>, x: System.String) = "ActiveClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("href")>] member this.href (_: FunBlazorContext<AntDesign.MenuLink>, x: System.String) = "Href" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuLink>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuLink>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuLink>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.MenuLink>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("attributes")>] member this.attributes (_: FunBlazorContext<AntDesign.MenuLink>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("match'")>] member this.match' (_: FunBlazorContext<AntDesign.MenuLink>, x: Microsoft.AspNetCore.Components.Routing.NavLinkMatch) = "Match" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.MenuLink>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.MenuLink>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.MenuLink>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.MenuLink>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SubMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SubMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SubMenuBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SubMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SubMenuBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SubMenuBuilder<'FunBlazorGeneric>()

    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.SubMenu>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.SubMenu>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.SubMenu>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.SubMenu>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.SubMenu>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.SubMenu>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SubMenu>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SubMenu>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SubMenu>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SubMenu>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<AntDesign.SubMenu>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.SubMenu>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isOpen")>] member this.isOpen (_: FunBlazorContext<AntDesign.SubMenu>, x: System.Boolean) = "IsOpen" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTitleClick")>] member this.onTitleClick (_: FunBlazorContext<AntDesign.SubMenu>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnTitleClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.SubMenu>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.SubMenu>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.SubMenu>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.SubMenu>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MessageBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MessageBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MessageBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Message>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Message>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Message>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Message>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MessageItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MessageItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MessageItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.MessageItem>, x: AntDesign.MessageConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.MessageItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.MessageItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.MessageItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.MessageItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ComfirmContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ComfirmContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ComfirmContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ComfirmContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ComfirmContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ComfirmContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ComfirmContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ConfirmBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ConfirmBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ConfirmBuilder<'FunBlazorGeneric>()

    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Confirm>, x: AntDesign.ConfirmOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("confirmRef")>] member this.confirmRef (_: FunBlazorContext<AntDesign.Confirm>, x: AntDesign.ConfirmRef) = "ConfirmRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRemove")>] member this.onRemove (_: FunBlazorContext<AntDesign.Confirm>, fn) = (Bolero.Html.attr.callback<AntDesign.ConfirmRef> "OnRemove" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Confirm>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Confirm>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Confirm>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Confirm>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DialogBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DialogBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DialogBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DialogBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DialogBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DialogBuilder<'FunBlazorGeneric>()

    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.Dialog>, x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Dialog>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Dialog>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Dialog>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Dialog>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Dialog>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Dialog>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Dialog>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Dialog>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Dialog>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DialogWrapperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DialogWrapperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DialogWrapperBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DialogWrapperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DialogWrapperBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DialogWrapperBuilder<'FunBlazorGeneric>()

    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.DialogWrapper>, x: AntDesign.DialogOptions) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DialogWrapper>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DialogWrapper>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DialogWrapper>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DialogWrapper>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("destroyOnClose")>] member this.destroyOnClose (_: FunBlazorContext<AntDesign.DialogWrapper>, x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.DialogWrapper>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBeforeDestroy")>] member this.onBeforeDestroy (_: FunBlazorContext<AntDesign.DialogWrapper>, fn) = (Bolero.Html.attr.callback<System.ComponentModel.CancelEventArgs> "OnBeforeDestroy" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAfterShow")>] member this.onAfterShow (_: FunBlazorContext<AntDesign.DialogWrapper>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAfterHide")>] member this.onAfterHide (_: FunBlazorContext<AntDesign.DialogWrapper>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAfterHide" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.DialogWrapper>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.DialogWrapper>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.DialogWrapper>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.DialogWrapper>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ModalBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ModalBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ModalBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ModalBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ModalBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ModalBuilder<'FunBlazorGeneric>()

    [<CustomOperation("modalRef")>] member this.modalRef (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ModalRef) = "ModalRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("afterClose")>] member this.afterClose (_: FunBlazorContext<AntDesign.Modal>, x: System.Func<System.Threading.Tasks.Task>) = "AfterClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bodyStyle")>] member this.bodyStyle (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "BodyStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelText")>] member this.cancelText (_: FunBlazorContext<AntDesign.Modal>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("centered")>] member this.centered (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Centered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closable")>] member this.closable (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("draggable")>] member this.draggable (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dragInViewport")>] member this.dragInViewport (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "DragInViewport" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeIcon")>] member this.closeIcon (_: FunBlazorContext<AntDesign.Modal>, nodes) = Bolero.Html.attr.fragment "CloseIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeIcon")>] member this.closeIcon (_: FunBlazorContext<AntDesign.Modal>, x: string) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeIcon")>] member this.closeIcon (_: FunBlazorContext<AntDesign.Modal>, x: int) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("closeIcon")>] member this.closeIcon (_: FunBlazorContext<AntDesign.Modal>, x: float) = Bolero.Html.attr.fragment "CloseIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("confirmLoading")>] member this.confirmLoading (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "ConfirmLoading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("destroyOnClose")>] member this.destroyOnClose (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "DestroyOnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("footer")>] member this.footer (_: FunBlazorContext<AntDesign.Modal>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getContainer")>] member this.getContainer (_: FunBlazorContext<AntDesign.Modal>, x: System.Nullable<Microsoft.AspNetCore.Components.ElementReference>) = "GetContainer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyboard")>] member this.keyboard (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mask")>] member this.mask (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Mask" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maskClosable")>] member this.maskClosable (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "MaskClosable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maskStyle")>] member this.maskStyle (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "MaskStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("okText")>] member this.okText (_: FunBlazorContext<AntDesign.Modal>, x: System.Nullable<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "OkText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("okType")>] member this.okType (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "OkType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Modal>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Modal>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Modal>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Modal>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Modal>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.Modal>, x: OneOf.OneOf<System.String, System.Double>) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapClassName")>] member this.wrapClassName (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "WrapClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("zIndex")>] member this.zIndex (_: FunBlazorContext<AntDesign.Modal>, x: System.Int32) = "ZIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCancel")>] member this.onCancel (_: FunBlazorContext<AntDesign.Modal>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOk")>] member this.onOk (_: FunBlazorContext<AntDesign.Modal>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnOk" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("okButtonProps")>] member this.okButtonProps (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelButtonProps")>] member this.cancelButtonProps (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Modal>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Modal>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Modal>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Modal>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ModalLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Modal>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Modal>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Modal>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Modal>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ModalContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ModalContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ModalContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ModalContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ModalContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ModalContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ModalContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ModalFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ModalFooterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ModalFooterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ModalFooter>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ModalFooter>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ModalFooter>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ModalFooter>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type NotificationBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = NotificationBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = NotificationBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.NotificationBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.NotificationBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.NotificationBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.NotificationBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type NotificationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit NotificationBaseBuilder<'FunBlazorGeneric>()
    static member create () = NotificationBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = NotificationBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Notification>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Notification>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Notification>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Notification>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type NotificationItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit NotificationBaseBuilder<'FunBlazorGeneric>()
    static member create () = NotificationItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = NotificationItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("config")>] member this.config (_: FunBlazorContext<AntDesign.NotificationItem>, x: AntDesign.NotificationConfig) = "Config" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClose")>] member this.onClose (_: FunBlazorContext<AntDesign.NotificationItem>, x: System.Func<AntDesign.NotificationConfig, System.Threading.Tasks.Task>) = "OnClose" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.NotificationItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.NotificationItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.NotificationItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.NotificationItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PageHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PageHeaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PageHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("ghost")>] member this.ghost (_: FunBlazorContext<AntDesign.PageHeader>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("backIcon")>] member this.backIcon (_: FunBlazorContext<AntDesign.PageHeader>, x: OneOf.OneOf<System.Nullable<System.Boolean>, System.String>) = "BackIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("backIconTemplate")>] member this.backIconTemplate (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "BackIconTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("backIconTemplate")>] member this.backIconTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("backIconTemplate")>] member this.backIconTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("backIconTemplate")>] member this.backIconTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "BackIconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.PageHeader>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitle")>] member this.subtitle (_: FunBlazorContext<AntDesign.PageHeader>, x: System.String) = "Subtitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitleTemplate")>] member this.subtitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitleTemplate")>] member this.subtitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitleTemplate")>] member this.subtitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitleTemplate")>] member this.subtitleTemplate (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBack")>] member this.onBack (_: FunBlazorContext<AntDesign.PageHeader>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnBack" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderContent")>] member this.pageHeaderContent (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderContent")>] member this.pageHeaderContent (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderContent")>] member this.pageHeaderContent (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderContent")>] member this.pageHeaderContent (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderFooter")>] member this.pageHeaderFooter (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderFooter")>] member this.pageHeaderFooter (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderFooter")>] member this.pageHeaderFooter (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderFooter")>] member this.pageHeaderFooter (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderBreadcrumb")>] member this.pageHeaderBreadcrumb (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderBreadcrumb")>] member this.pageHeaderBreadcrumb (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderBreadcrumb")>] member this.pageHeaderBreadcrumb (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderBreadcrumb")>] member this.pageHeaderBreadcrumb (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderBreadcrumb" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderAvatar")>] member this.pageHeaderAvatar (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderAvatar" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderAvatar")>] member this.pageHeaderAvatar (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderAvatar")>] member this.pageHeaderAvatar (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderAvatar")>] member this.pageHeaderAvatar (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderAvatar" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderTitle")>] member this.pageHeaderTitle (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderTitle" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderTitle")>] member this.pageHeaderTitle (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderTitle")>] member this.pageHeaderTitle (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderTitle")>] member this.pageHeaderTitle (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderTitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderSubtitle")>] member this.pageHeaderSubtitle (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderSubtitle")>] member this.pageHeaderSubtitle (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderSubtitle")>] member this.pageHeaderSubtitle (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderSubtitle")>] member this.pageHeaderSubtitle (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderSubtitle" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderTags")>] member this.pageHeaderTags (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderTags" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderTags")>] member this.pageHeaderTags (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderTags")>] member this.pageHeaderTags (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderTags")>] member this.pageHeaderTags (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderTags" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderExtra")>] member this.pageHeaderExtra (_: FunBlazorContext<AntDesign.PageHeader>, nodes) = Bolero.Html.attr.fragment "PageHeaderExtra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderExtra")>] member this.pageHeaderExtra (_: FunBlazorContext<AntDesign.PageHeader>, x: string) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderExtra")>] member this.pageHeaderExtra (_: FunBlazorContext<AntDesign.PageHeader>, x: int) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageHeaderExtra")>] member this.pageHeaderExtra (_: FunBlazorContext<AntDesign.PageHeader>, x: float) = Bolero.Html.attr.fragment "PageHeaderExtra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.PageHeader>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.PageHeader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.PageHeader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.PageHeader>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PaginationBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PaginationBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PaginationBuilder<'FunBlazorGeneric>()

    [<CustomOperation("total")>] member this.total (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "Total" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultCurrent")>] member this.defaultCurrent (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "DefaultCurrent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("current")>] member this.current (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultPageSize")>] member this.defaultPageSize (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "DefaultPageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageSize")>] member this.pageSize (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Pagination>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideOnSinglePage")>] member this.hideOnSinglePage (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "HideOnSinglePage" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSizeChanger")>] member this.showSizeChanger (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowSizeChanger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageSizeOptions")>] member this.pageSizeOptions (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onShowSizeChange")>] member this.onShowSizeChange (_: FunBlazorContext<AntDesign.Pagination>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnShowSizeChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("showQuickJumper")>] member this.showQuickJumper (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowQuickJumper" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("goButton")>] member this.goButton (_: FunBlazorContext<AntDesign.Pagination>, nodes) = Bolero.Html.attr.fragment "GoButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("goButton")>] member this.goButton (_: FunBlazorContext<AntDesign.Pagination>, x: string) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("goButton")>] member this.goButton (_: FunBlazorContext<AntDesign.Pagination>, x: int) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("goButton")>] member this.goButton (_: FunBlazorContext<AntDesign.Pagination>, x: float) = Bolero.Html.attr.fragment "GoButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTitle")>] member this.showTitle (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTotal")>] member this.showTotal (_: FunBlazorContext<AntDesign.Pagination>, x: System.Nullable<OneOf.OneOf<System.Func<AntDesign.PaginationTotalContext, System.String>, Microsoft.AspNetCore.Components.RenderFragment<AntDesign.PaginationTotalContext>>>) = "ShowTotal" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Pagination>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("responsive")>] member this.responsive (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "Responsive" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("simple")>] member this.simple (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "Simple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Pagination>, x: AntDesign.PaginationLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemRender")>] member this.itemRender (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("showLessItems")>] member this.showLessItems (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowLessItems" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showPrevNextJumpers")>] member this.showPrevNextJumpers (_: FunBlazorContext<AntDesign.Pagination>, x: System.Boolean) = "ShowPrevNextJumpers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<AntDesign.Pagination>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prevIcon")>] member this.prevIcon (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "PrevIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nextIcon")>] member this.nextIcon (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "NextIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("jumpPrevIcon")>] member this.jumpPrevIcon (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "JumpPrevIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("jumpNextIcon")>] member this.jumpNextIcon (_: FunBlazorContext<AntDesign.Pagination>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "JumpNextIcon" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("totalBoundaryShowSizeChanger")>] member this.totalBoundaryShowSizeChanger (_: FunBlazorContext<AntDesign.Pagination>, x: System.Int32) = "TotalBoundaryShowSizeChanger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unmatchedAttributes")>] member this.unmatchedAttributes (_: FunBlazorContext<AntDesign.Pagination>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Pagination>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Pagination>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Pagination>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Pagination>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PaginationOptionsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PaginationOptionsBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PaginationOptionsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("isSmall")>] member this.isSmall (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Boolean) = "IsSmall" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rootPrefixCls")>] member this.rootPrefixCls (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeSize")>] member this.changeSize (_: FunBlazorContext<AntDesign.PaginationOptions>, fn) = (Bolero.Html.attr.callback<System.Int32> "ChangeSize" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("current")>] member this.current (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageSize")>] member this.pageSize (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageSizeOptions")>] member this.pageSizeOptions (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Int32[]) = "PageSizeOptions" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("quickGo")>] member this.quickGo (_: FunBlazorContext<AntDesign.PaginationOptions>, fn) = (Bolero.Html.attr.callback<System.Int32> "QuickGo" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("goButton")>] member this.goButton (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.Nullable<OneOf.OneOf<System.Boolean, Microsoft.AspNetCore.Components.RenderFragment>>) = "GoButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.PaginationOptions>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.PaginationOptions>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.PaginationOptions>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.PaginationOptions>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ProgressBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ProgressBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ProgressBuilder<'FunBlazorGeneric>()

    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressSize) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressType) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.Progress>, x: System.Func<System.Double, System.String>) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("percent")>] member this.percent (_: FunBlazorContext<AntDesign.Progress>, x: System.Double) = "Percent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showInfo")>] member this.showInfo (_: FunBlazorContext<AntDesign.Progress>, x: System.Boolean) = "ShowInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("status")>] member this.status (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressStatus) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strokeLinecap")>] member this.strokeLinecap (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressStrokeLinecap) = "StrokeLinecap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("successPercent")>] member this.successPercent (_: FunBlazorContext<AntDesign.Progress>, x: System.Double) = "SuccessPercent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("trailColor")>] member this.trailColor (_: FunBlazorContext<AntDesign.Progress>, x: System.String) = "TrailColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strokeWidth")>] member this.strokeWidth (_: FunBlazorContext<AntDesign.Progress>, x: System.Int32) = "StrokeWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strokeColor")>] member this.strokeColor (_: FunBlazorContext<AntDesign.Progress>, x: OneOf.OneOf<System.String, System.Collections.Generic.Dictionary<System.String, System.String>>) = "StrokeColor" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("steps")>] member this.steps (_: FunBlazorContext<AntDesign.Progress>, x: System.Int32) = "Steps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.Progress>, x: System.Int32) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("gapDegree")>] member this.gapDegree (_: FunBlazorContext<AntDesign.Progress>, x: System.Int32) = "GapDegree" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("gapPosition")>] member this.gapPosition (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ProgressGapPosition) = "GapPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Progress>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Progress>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Progress>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Progress>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RadioBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = RadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RadioBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RadioBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RadioBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = RadioBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Radio<'TValue>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("radioButton")>] member this.radioButton (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "RadioButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultChecked")>] member this.defaultChecked (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "DefaultChecked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChanged")>] member this.checkedChanged (_: FunBlazorContext<AntDesign.Radio<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChange")>] member this.checkedChange (_: FunBlazorContext<AntDesign.Radio<'TValue>>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Radio<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = RateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = RateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = RateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = RateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = RateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Rate>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Rate>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Rate>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Rate>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.Rate>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowHalf")>] member this.allowHalf (_: FunBlazorContext<AntDesign.Rate>, x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Rate>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.Rate>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("character")>] member this.character (_: FunBlazorContext<AntDesign.Rate>, render: AntDesign.RateItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Character" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("count")>] member this.count (_: FunBlazorContext<AntDesign.Rate>, x: System.Int32) = "Count" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Rate>, x: System.Decimal) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueChanged")>] member this.valueChanged (_: FunBlazorContext<AntDesign.Rate>, fn) = (Bolero.Html.attr.callback<System.Decimal> "ValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultValue")>] member this.defaultValue (_: FunBlazorContext<AntDesign.Rate>, x: System.Decimal) = "DefaultValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tooltips")>] member this.tooltips (_: FunBlazorContext<AntDesign.Rate>, x: System.String[]) = "Tooltips" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.Rate>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.Rate>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Rate>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Rate>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Rate>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Rate>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type RateItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = RateItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = RateItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("allowHalf")>] member this.allowHalf (_: FunBlazorContext<AntDesign.RateItem>, x: System.Boolean) = "AllowHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onItemHover")>] member this.onItemHover (_: FunBlazorContext<AntDesign.RateItem>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnItemHover" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onItemClick")>] member this.onItemClick (_: FunBlazorContext<AntDesign.RateItem>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnItemClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tooltip")>] member this.tooltip (_: FunBlazorContext<AntDesign.RateItem>, x: System.String) = "Tooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("indexOfGroup")>] member this.indexOfGroup (_: FunBlazorContext<AntDesign.RateItem>, x: System.Int32) = "IndexOfGroup" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hoverValue")>] member this.hoverValue (_: FunBlazorContext<AntDesign.RateItem>, x: System.Int32) = "HoverValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hasHalf")>] member this.hasHalf (_: FunBlazorContext<AntDesign.RateItem>, x: System.Boolean) = "HasHalf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isFocused")>] member this.isFocused (_: FunBlazorContext<AntDesign.RateItem>, x: System.Boolean) = "IsFocused" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.RateItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.RateItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.RateItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.RateItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ResultBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ResultBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ResultBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ResultBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ResultBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ResultBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Result>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Result>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Result>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Result>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subTitle")>] member this.subTitle (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "SubTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("subTitleTemplate")>] member this.subTitleTemplate (_: FunBlazorContext<AntDesign.Result>, nodes) = Bolero.Html.attr.fragment "SubTitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subTitleTemplate")>] member this.subTitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: string) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subTitleTemplate")>] member this.subTitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: int) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subTitleTemplate")>] member this.subTitleTemplate (_: FunBlazorContext<AntDesign.Result>, x: float) = Bolero.Html.attr.fragment "SubTitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Result>, nodes) = Bolero.Html.attr.fragment "Extra" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Result>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Result>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("extra")>] member this.extra (_: FunBlazorContext<AntDesign.Result>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("status")>] member this.status (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowIcon")>] member this.isShowIcon (_: FunBlazorContext<AntDesign.Result>, x: System.Boolean) = "IsShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Result>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Result>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Result>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Result>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Result>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Result>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Result>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Result>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SelectOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SelectOptionBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SelectOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: 'TItemValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.SelectOption<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SimpleSelectOptionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit SelectOptionBuilder<'FunBlazorGeneric>()
    static member create () = SimpleSelectOptionBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SimpleSelectOptionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("label")>] member this.label (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: System.String) = "Label" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.SimpleSelectOption>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SkeletonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SkeletonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SkeletonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SkeletonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SkeletonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SkeletonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("active")>] member this.active (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleWidth")>] member this.titleWidth (_: FunBlazorContext<AntDesign.Skeleton>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "TitleWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatar")>] member this.avatar (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarSize")>] member this.avatarSize (_: FunBlazorContext<AntDesign.Skeleton>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "AvatarSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarShape")>] member this.avatarShape (_: FunBlazorContext<AntDesign.Skeleton>, x: System.String) = "AvatarShape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("paragraph")>] member this.paragraph (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Boolean) = "Paragraph" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("paragraphRows")>] member this.paragraphRows (_: FunBlazorContext<AntDesign.Skeleton>, x: System.Nullable<System.Int32>) = "ParagraphRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("paragraphWidth")>] member this.paragraphWidth (_: FunBlazorContext<AntDesign.Skeleton>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String, System.Collections.Generic.IList<OneOf.OneOf<System.Nullable<System.Int32>, System.String>>>) = "ParagraphWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Skeleton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Skeleton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Skeleton>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Skeleton>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Skeleton>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Skeleton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Skeleton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Skeleton>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SkeletonElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SkeletonElementBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SkeletonElementBuilder<'FunBlazorGeneric>()

    [<CustomOperation("active")>] member this.active (_: FunBlazorContext<AntDesign.SkeletonElement>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.SkeletonElement>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.SkeletonElement>, x: OneOf.OneOf<System.Nullable<System.Int32>, System.String>) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("shape")>] member this.shape (_: FunBlazorContext<AntDesign.SkeletonElement>, x: System.String) = "Shape" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.SkeletonElement>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.SkeletonElement>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.SkeletonElement>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.SkeletonElement>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SpaceBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SpaceBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpaceBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpaceBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpaceBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SpaceBuilder<'FunBlazorGeneric>()

    [<CustomOperation("align")>] member this.align (_: FunBlazorContext<AntDesign.Space>, x: System.String) = "Align" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<AntDesign.Space>, x: AntDesign.DirectionVHType) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Space>, x: OneOf.OneOf<System.String, System.ValueTuple<System.String, System.String>>) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrap")>] member this.wrap (_: FunBlazorContext<AntDesign.Space>, x: System.Boolean) = "Wrap" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("split")>] member this.split (_: FunBlazorContext<AntDesign.Space>, nodes) = Bolero.Html.attr.fragment "Split" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("split")>] member this.split (_: FunBlazorContext<AntDesign.Space>, x: string) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("split")>] member this.split (_: FunBlazorContext<AntDesign.Space>, x: int) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("split")>] member this.split (_: FunBlazorContext<AntDesign.Space>, x: float) = Bolero.Html.attr.fragment "Split" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Space>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Space>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Space>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Space>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Space>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Space>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Space>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Space>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SpaceItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SpaceItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpaceItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpaceItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpaceItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SpaceItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SpaceItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SpaceItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SpaceItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SpaceItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.SpaceItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.SpaceItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.SpaceItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.SpaceItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SpinBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SpinBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SpinBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SpinBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SpinBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SpinBuilder<'FunBlazorGeneric>()

    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Spin>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tip")>] member this.tip (_: FunBlazorContext<AntDesign.Spin>, x: System.String) = "Tip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("delay")>] member this.delay (_: FunBlazorContext<AntDesign.Spin>, x: System.Int32) = "Delay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("spinning")>] member this.spinning (_: FunBlazorContext<AntDesign.Spin>, x: System.Boolean) = "Spinning" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("wrapperClassName")>] member this.wrapperClassName (_: FunBlazorContext<AntDesign.Spin>, x: System.String) = "WrapperClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("indicator")>] member this.indicator (_: FunBlazorContext<AntDesign.Spin>, nodes) = Bolero.Html.attr.fragment "Indicator" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("indicator")>] member this.indicator (_: FunBlazorContext<AntDesign.Spin>, x: string) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("indicator")>] member this.indicator (_: FunBlazorContext<AntDesign.Spin>, x: int) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("indicator")>] member this.indicator (_: FunBlazorContext<AntDesign.Spin>, x: float) = Bolero.Html.attr.fragment "Indicator" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Spin>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Spin>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Spin>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Spin>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Spin>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Spin>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Spin>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Spin>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type StatisticComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = StatisticComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = StatisticComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = StatisticComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = StatisticComponentBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = StatisticComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: int) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: float) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "Suffix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: int) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: float) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: 'T) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueStyle")>] member this.valueStyle (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "ValueStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.StatisticComponentBase<'T>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CountDownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit StatisticComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = CountDownBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = CountDownBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = CountDownBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = CountDownBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = CountDownBuilder<'FunBlazorGeneric>()

    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFinish")>] member this.onFinish (_: FunBlazorContext<AntDesign.CountDown>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnFinish" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.CountDown>, nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: int) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: float) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Suffix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.CountDown>, nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: int) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: float) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.CountDown>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.CountDown>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.CountDown>, x: System.DateTime) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueStyle")>] member this.valueStyle (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "ValueStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CountDown>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CountDown>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CountDown>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.CountDown>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.CountDown>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.CountDown>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.CountDown>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.CountDown>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type StatisticBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit StatisticComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = StatisticBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = StatisticBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = StatisticBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = StatisticBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = StatisticBuilder<'FunBlazorGeneric>()

    [<CustomOperation("decimalSeparator")>] member this.decimalSeparator (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "DecimalSeparator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("groupSeparator")>] member this.groupSeparator (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "GroupSeparator" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("precision")>] member this.precision (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.Int32) = "Precision" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, nodes) = Bolero.Html.attr.fragment "PrefixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: int) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixTemplate")>] member this.prefixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: float) = Bolero.Html.attr.fragment "PrefixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffix")>] member this.suffix (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "Suffix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, nodes) = Bolero.Html.attr.fragment "SuffixTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: int) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixTemplate")>] member this.suffixTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: float) = Bolero.Html.attr.fragment "SuffixTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: 'TValue) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("valueStyle")>] member this.valueStyle (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "ValueStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Statistic<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type StepBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = StepBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = StepBuilder<'FunBlazorGeneric>()

    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("status")>] member this.status (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Step>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Step>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Step>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Step>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitle")>] member this.subtitle (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Subtitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitleTemplate")>] member this.subtitleTemplate (_: FunBlazorContext<AntDesign.Step>, nodes) = Bolero.Html.attr.fragment "SubtitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitleTemplate")>] member this.subtitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: string) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitleTemplate")>] member this.subtitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: int) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("subtitleTemplate")>] member this.subtitleTemplate (_: FunBlazorContext<AntDesign.Step>, x: float) = Bolero.Html.attr.fragment "SubtitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("description")>] member this.description (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.Step>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.Step>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.Step>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.Step>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Step>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Step>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Step>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Step>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Step>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Step>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type StepsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = StepsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = StepsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = StepsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = StepsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = StepsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("current")>] member this.current (_: FunBlazorContext<AntDesign.Steps>, x: System.Int32) = "Current" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("percent")>] member this.percent (_: FunBlazorContext<AntDesign.Steps>, x: System.Nullable<System.Double>) = "Percent" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("progressDot")>] member this.progressDot (_: FunBlazorContext<AntDesign.Steps>, nodes) = Bolero.Html.attr.fragment "ProgressDot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("progressDot")>] member this.progressDot (_: FunBlazorContext<AntDesign.Steps>, x: string) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("progressDot")>] member this.progressDot (_: FunBlazorContext<AntDesign.Steps>, x: int) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("progressDot")>] member this.progressDot (_: FunBlazorContext<AntDesign.Steps>, x: float) = Bolero.Html.attr.fragment "ProgressDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("showProgressDot")>] member this.showProgressDot (_: FunBlazorContext<AntDesign.Steps>, x: System.Boolean) = "ShowProgressDot" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("direction")>] member this.direction (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Direction" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("labelPlacement")>] member this.labelPlacement (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "LabelPlacement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("startIndex")>] member this.startIndex (_: FunBlazorContext<AntDesign.Steps>, x: System.Int32) = "StartIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("status")>] member this.status (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Status" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Steps>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Steps>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Steps>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Steps>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Steps>, fn) = (Bolero.Html.attr.callback<System.Int32> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Steps>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Steps>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Steps>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Steps>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ColumnBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ColumnBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ColumnBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ColumnBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ColumnBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ColumnBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ColumnBase>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ColumnBase>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ColumnBase>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ColumnBase>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerStyle")>] member this.headerStyle (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowSpan")>] member this.rowSpan (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("colSpan")>] member this.colSpan (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerColSpan")>] member this.headerColSpan (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixed'")>] member this.fixed' (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ColumnBase>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ColumnBase>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ColumnBase>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ColumnBase>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ColumnBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ColumnBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ColumnBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ColumnBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ActionColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ActionColumnBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ActionColumnBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ActionColumnBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ActionColumnBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ActionColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ActionColumn>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ActionColumn>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ActionColumn>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.ActionColumn>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerStyle")>] member this.headerStyle (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowSpan")>] member this.rowSpan (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("colSpan")>] member this.colSpan (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerColSpan")>] member this.headerColSpan (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixed'")>] member this.fixed' (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ActionColumn>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ActionColumn>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ActionColumn>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ActionColumn>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.ActionColumn>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.ActionColumn>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.ActionColumn>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.ActionColumn>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ColumnBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ColumnBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ColumnBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ColumnBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ColumnBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ColumnBuilder<'FunBlazorGeneric>()

    [<CustomOperation("fieldChanged")>] member this.fieldChanged (_: FunBlazorContext<AntDesign.Column<'TData>>, fn) = (Bolero.Html.attr.callback<'TData> "FieldChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("fieldExpression")>] member this.fieldExpression (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Linq.Expressions.Expression<System.Func<'TData>>) = "FieldExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cellRender")>] member this.cellRender (_: FunBlazorContext<AntDesign.Column<'TData>>, render: 'TData -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "CellRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("field")>] member this.field (_: FunBlazorContext<AntDesign.Column<'TData>>, x: 'TData) = "Field" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dataIndex")>] member this.dataIndex (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "DataIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortable")>] member this.sortable (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "Sortable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sorterCompare")>] member this.sorterCompare (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Func<'TData, 'TData, System.Int32>) = "SorterCompare" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sorterMultiple")>] member this.sorterMultiple (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Int32) = "SorterMultiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSorterTooltip")>] member this.showSorterTooltip (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "ShowSorterTooltip" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortDirections")>] member this.sortDirections (_: FunBlazorContext<AntDesign.Column<'TData>>, x: AntDesign.SortDirection[]) = "SortDirections" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultSortOrder")>] member this.defaultSortOrder (_: FunBlazorContext<AntDesign.Column<'TData>>, x: AntDesign.SortDirection) = "DefaultSortOrder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCell")>] member this.onCell (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Func<AntDesign.TableModels.RowData, System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnCell" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onHeaderCell")>] member this.onHeaderCell (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnHeaderCell" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("filterable")>] member this.filterable (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "Filterable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("filters")>] member this.filters (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Collections.Generic.IEnumerable<AntDesign.TableFilter<'TData>>) = "Filters" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("filterMultiple")>] member this.filterMultiple (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "FilterMultiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFilter")>] member this.onFilter (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Linq.Expressions.Expression<System.Func<'TData, 'TData, System.Boolean>>) = "OnFilter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Column<'TData>>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Column<'TData>>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Column<'TData>>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Column<'TData>>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerStyle")>] member this.headerStyle (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowSpan")>] member this.rowSpan (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("colSpan")>] member this.colSpan (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerColSpan")>] member this.headerColSpan (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixed'")>] member this.fixed' (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Column<'TData>>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Column<'TData>>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Column<'TData>>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Column<'TData>>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Column<'TData>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Column<'TData>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Column<'TData>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Column<'TData>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SelectionBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SelectionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SelectionBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SelectionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SelectionBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SelectionBuilder<'FunBlazorGeneric>()

    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Selection>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkStrictly")>] member this.checkStrictly (_: FunBlazorContext<AntDesign.Selection>, x: System.Boolean) = "CheckStrictly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Selection>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Selection>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Selection>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Selection>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerStyle")>] member this.headerStyle (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowSpan")>] member this.rowSpan (_: FunBlazorContext<AntDesign.Selection>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("colSpan")>] member this.colSpan (_: FunBlazorContext<AntDesign.Selection>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerColSpan")>] member this.headerColSpan (_: FunBlazorContext<AntDesign.Selection>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixed'")>] member this.fixed' (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Selection>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Selection>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Selection>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Selection>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.Selection>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Selection>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Selection>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Selection>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Selection>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type SummaryCellBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit ColumnBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SummaryCellBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SummaryCellBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SummaryCellBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SummaryCellBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SummaryCellBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.SummaryCell>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.SummaryCell>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.SummaryCell>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.SummaryCell>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("width")>] member this.width (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "Width" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerStyle")>] member this.headerStyle (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "HeaderStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowSpan")>] member this.rowSpan (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.Int32) = "RowSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("colSpan")>] member this.colSpan (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.Int32) = "ColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headerColSpan")>] member this.headerColSpan (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.Int32) = "HeaderColSpan" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fixed'")>] member this.fixed' (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "Fixed" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SummaryCell>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SummaryCell>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SummaryCell>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SummaryCell>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.SummaryCell>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.SummaryCell>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.SummaryCell>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.SummaryCell>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TableBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TableBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TableBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TableBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TableBuilder<'FunBlazorGeneric>()

    [<CustomOperation("renderMode")>] member this.renderMode (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.RenderMode) = "RenderMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dataSource")>] member this.dataSource (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Table<'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ChildContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowTemplate")>] member this.rowTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RowTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandTemplate")>] member this.expandTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, render: AntDesign.TableModels.RowData<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ExpandTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowExpandable")>] member this.rowExpandable (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Boolean>) = "RowExpandable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("treeChildren")>] member this.treeChildren (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<'TItem, System.Collections.Generic.IEnumerable<'TItem>>) = "TreeChildren" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.QueryModel<'TItem>> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRow")>] member this.onRow (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onHeaderRow")>] member this.onHeaderRow (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<System.Collections.Generic.Dictionary<System.String, System.Object>>) = "OnHeaderRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footer")>] member this.footer (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerTemplate")>] member this.footerTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerTemplate")>] member this.footerTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerTemplate")>] member this.footerTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: int) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerTemplate")>] member this.footerTemplate (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: float) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.TableSize) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.TableLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("bordered")>] member this.bordered (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Boolean) = "Bordered" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("scrollX")>] member this.scrollX (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "ScrollX" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("scrollY")>] member this.scrollY (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "ScrollY" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("scrollBarWidth")>] member this.scrollBarWidth (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "ScrollBarWidth" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("indentSize")>] member this.indentSize (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "IndentSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandIconColumnIndex")>] member this.expandIconColumnIndex (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "ExpandIconColumnIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rowClassName")>] member this.rowClassName (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "RowClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expandedRowClassName")>] member this.expandedRowClassName (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Func<AntDesign.TableModels.RowData<'TItem>, System.String>) = "ExpandedRowClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onExpand")>] member this.onExpand (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnExpand" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("sortDirections")>] member this.sortDirections (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.SortDirection[]) = "SortDirections" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tableLayout")>] member this.tableLayout (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "TableLayout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRowClick")>] member this.onRowClick (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TableModels.RowData<'TItem>> "OnRowClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("hidePagination")>] member this.hidePagination (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Boolean) = "HidePagination" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("paginationPosition")>] member this.paginationPosition (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "PaginationPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("total")>] member this.total (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "Total" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("totalChanged")>] member this.totalChanged (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<System.Int32> "TotalChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageIndex")>] member this.pageIndex (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "PageIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageIndexChanged")>] member this.pageIndexChanged (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<System.Int32> "PageIndexChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageSize")>] member this.pageSize (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Int32) = "PageSize" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pageSizeChanged")>] member this.pageSizeChanged (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<System.Int32> "PageSizeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPageIndexChange")>] member this.onPageIndexChange (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageIndexChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPageSizeChange")>] member this.onPageSizeChange (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.PaginationEventArgs> "OnPageSizeChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedRows")>] member this.selectedRows (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.Collections.Generic.IEnumerable<'TItem>) = "SelectedRows" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedRowsChanged")>] member this.selectedRowsChanged (_: FunBlazorContext<AntDesign.Table<'TItem>>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.IEnumerable<'TItem>> "SelectedRowsChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Table<'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TabPaneBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TabPaneBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TabPaneBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TabPaneBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TabPaneBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TabPaneBuilder<'FunBlazorGeneric>()

    [<CustomOperation("forceRender")>] member this.forceRender (_: FunBlazorContext<AntDesign.TabPane>, x: System.Boolean) = "ForceRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<AntDesign.TabPane>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tab")>] member this.tab (_: FunBlazorContext<AntDesign.TabPane>, nodes) = Bolero.Html.attr.fragment "Tab" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tab")>] member this.tab (_: FunBlazorContext<AntDesign.TabPane>, x: string) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tab")>] member this.tab (_: FunBlazorContext<AntDesign.TabPane>, x: int) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tab")>] member this.tab (_: FunBlazorContext<AntDesign.TabPane>, x: float) = Bolero.Html.attr.fragment "Tab" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TabPane>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TabPane>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TabPane>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TabPane>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.TabPane>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closable")>] member this.closable (_: FunBlazorContext<AntDesign.TabPane>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.TabPane>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.TabPane>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.TabPane>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.TabPane>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TabsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TabsBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TabsBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TabsBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tabs>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tabs>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tabs>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tabs>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("activeKey")>] member this.activeKey (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "ActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("activeKeyChanged")>] member this.activeKeyChanged (_: FunBlazorContext<AntDesign.Tabs>, fn) = (Bolero.Html.attr.callback<System.String> "ActiveKeyChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("animated")>] member this.animated (_: FunBlazorContext<AntDesign.Tabs>, x: System.Boolean) = "Animated" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderTabBar")>] member this.renderTabBar (_: FunBlazorContext<AntDesign.Tabs>, x: System.Object) = "RenderTabBar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultActiveKey")>] member this.defaultActiveKey (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "DefaultActiveKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideAdd")>] member this.hideAdd (_: FunBlazorContext<AntDesign.Tabs>, x: System.Boolean) = "HideAdd" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabBarExtraContent")>] member this.tabBarExtraContent (_: FunBlazorContext<AntDesign.Tabs>, nodes) = Bolero.Html.attr.fragment "TabBarExtraContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabBarExtraContent")>] member this.tabBarExtraContent (_: FunBlazorContext<AntDesign.Tabs>, x: string) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabBarExtraContent")>] member this.tabBarExtraContent (_: FunBlazorContext<AntDesign.Tabs>, x: int) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabBarExtraContent")>] member this.tabBarExtraContent (_: FunBlazorContext<AntDesign.Tabs>, x: float) = Bolero.Html.attr.fragment "TabBarExtraContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabBarGutter")>] member this.tabBarGutter (_: FunBlazorContext<AntDesign.Tabs>, x: System.Int32) = "TabBarGutter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabBarStyle")>] member this.tabBarStyle (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "TabBarStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("tabPosition")>] member this.tabPosition (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "TabPosition" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Tabs>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onEdit")>] member this.onEdit (_: FunBlazorContext<AntDesign.Tabs>, x: System.Func<System.String, System.String, System.Threading.Tasks.Task<System.Boolean>>) = "OnEdit" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onAddClick")>] member this.onAddClick (_: FunBlazorContext<AntDesign.Tabs>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnAddClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("afterTabCreated")>] member this.afterTabCreated (_: FunBlazorContext<AntDesign.Tabs>, fn) = (Bolero.Html.attr.callback<System.String> "AfterTabCreated" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onNextClick")>] member this.onNextClick (_: FunBlazorContext<AntDesign.Tabs>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnNextClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPrevClick")>] member this.onPrevClick (_: FunBlazorContext<AntDesign.Tabs>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnPrevClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onTabClick")>] member this.onTabClick (_: FunBlazorContext<AntDesign.Tabs>, fn) = (Bolero.Html.attr.callback<System.String> "OnTabClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyboard")>] member this.keyboard (_: FunBlazorContext<AntDesign.Tabs>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("draggable")>] member this.draggable (_: FunBlazorContext<AntDesign.Tabs>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Tabs>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Tabs>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Tabs>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Tabs>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TagBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TagBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TagBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TagBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TagBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TagBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tag>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tag>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tag>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tag>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("closable")>] member this.closable (_: FunBlazorContext<AntDesign.Tag>, x: System.Boolean) = "Closable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkable")>] member this.checkable (_: FunBlazorContext<AntDesign.Tag>, x: System.Boolean) = "Checkable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<AntDesign.Tag>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkedChange")>] member this.checkedChange (_: FunBlazorContext<AntDesign.Tag>, fn) = (Bolero.Html.attr.callback<System.Boolean> "CheckedChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<AntDesign.Tag>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Tag>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClose")>] member this.onClose (_: FunBlazorContext<AntDesign.Tag>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClose" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClosing")>] member this.onClosing (_: FunBlazorContext<AntDesign.Tag>, fn) = (Bolero.Html.attr.callback<AntDesign.CloseEventArgs<Microsoft.AspNetCore.Components.Web.MouseEventArgs>> "OnClosing" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Tag>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Tag>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Tag>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Tag>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Tag>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Tag>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TimelineBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TimelineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TimelineBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TimelineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TimelineBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TimelineBuilder<'FunBlazorGeneric>()

    [<CustomOperation("mode")>] member this.mode (_: FunBlazorContext<AntDesign.Timeline>, x: System.String) = "Mode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("reverse")>] member this.reverse (_: FunBlazorContext<AntDesign.Timeline>, x: System.Boolean) = "Reverse" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pending")>] member this.pending (_: FunBlazorContext<AntDesign.Timeline>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Pending" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pendingDot")>] member this.pendingDot (_: FunBlazorContext<AntDesign.Timeline>, nodes) = Bolero.Html.attr.fragment "PendingDot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pendingDot")>] member this.pendingDot (_: FunBlazorContext<AntDesign.Timeline>, x: string) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pendingDot")>] member this.pendingDot (_: FunBlazorContext<AntDesign.Timeline>, x: int) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("pendingDot")>] member this.pendingDot (_: FunBlazorContext<AntDesign.Timeline>, x: float) = Bolero.Html.attr.fragment "PendingDot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Timeline>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Timeline>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Timeline>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Timeline>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Timeline>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Timeline>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Timeline>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Timeline>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TimelineItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TimelineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TimelineItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TimelineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TimelineItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TimelineItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TimelineItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TimelineItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TimelineItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TimelineItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dot")>] member this.dot (_: FunBlazorContext<AntDesign.TimelineItem>, nodes) = Bolero.Html.attr.fragment "Dot" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dot")>] member this.dot (_: FunBlazorContext<AntDesign.TimelineItem>, x: string) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dot")>] member this.dot (_: FunBlazorContext<AntDesign.TimelineItem>, x: int) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("dot")>] member this.dot (_: FunBlazorContext<AntDesign.TimelineItem>, x: float) = Bolero.Html.attr.fragment "Dot" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("color")>] member this.color (_: FunBlazorContext<AntDesign.TimelineItem>, x: System.String) = "Color" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.TimelineItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.TimelineItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.TimelineItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.TimelineItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TransferBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TransferBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TransferBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TransferBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TransferBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TransferBuilder<'FunBlazorGeneric>()

    [<CustomOperation("dataSource")>] member this.dataSource (_: FunBlazorContext<AntDesign.Transfer>, x: System.Collections.Generic.IList<AntDesign.TransferItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titles")>] member this.titles (_: FunBlazorContext<AntDesign.Transfer>, x: System.String[]) = "Titles" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("operations")>] member this.operations (_: FunBlazorContext<AntDesign.Transfer>, x: System.String[]) = "Operations" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Transfer>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSearch")>] member this.showSearch (_: FunBlazorContext<AntDesign.Transfer>, x: System.Boolean) = "ShowSearch" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSelectAll")>] member this.showSelectAll (_: FunBlazorContext<AntDesign.Transfer>, x: System.Boolean) = "ShowSelectAll" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("targetKeys")>] member this.targetKeys (_: FunBlazorContext<AntDesign.Transfer>, x: System.String[]) = "TargetKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedKeys")>] member this.selectedKeys (_: FunBlazorContext<AntDesign.Transfer>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Transfer>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferChangeArgs> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onScroll")>] member this.onScroll (_: FunBlazorContext<AntDesign.Transfer>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferScrollArgs> "OnScroll" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSearch")>] member this.onSearch (_: FunBlazorContext<AntDesign.Transfer>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferSearchArgs> "OnSearch" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelectChange")>] member this.onSelectChange (_: FunBlazorContext<AntDesign.Transfer>, fn) = (Bolero.Html.attr.callback<AntDesign.TransferSelectChangeArgs> "OnSelectChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("render")>] member this.render (_: FunBlazorContext<AntDesign.Transfer>, x: System.Func<AntDesign.TransferItem, OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>) = "Render" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Transfer>, x: AntDesign.TransferLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("footer")>] member this.footer (_: FunBlazorContext<AntDesign.Transfer>, x: System.String) = "Footer" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerTemplate")>] member this.footerTemplate (_: FunBlazorContext<AntDesign.Transfer>, nodes) = Bolero.Html.attr.fragment "FooterTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerTemplate")>] member this.footerTemplate (_: FunBlazorContext<AntDesign.Transfer>, x: string) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerTemplate")>] member this.footerTemplate (_: FunBlazorContext<AntDesign.Transfer>, x: int) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("footerTemplate")>] member this.footerTemplate (_: FunBlazorContext<AntDesign.Transfer>, x: float) = Bolero.Html.attr.fragment "FooterTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Transfer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Transfer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Transfer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Transfer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Transfer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Transfer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Transfer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Transfer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TreeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = TreeBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("showExpand")>] member this.showExpand (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "ShowExpand" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showLine")>] member this.showLine (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "ShowLine" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showIcon")>] member this.showIcon (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "ShowIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("blockNode")>] member this.blockNode (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "BlockNode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("draggable")>] member this.draggable (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("nodes")>] member this.nodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nodes")>] member this.nodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nodes")>] member this.nodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: int) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nodes")>] member this.nodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: float) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childNodes")>] member this.childNodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Collections.Generic.List<AntDesign.TreeNode<'TItem>>) = "ChildNodes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiple")>] member this.multiple (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedKey")>] member this.selectedKey (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.String) = "SelectedKey" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedKeyChanged")>] member this.selectedKeyChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<System.String> "SelectedKeyChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedNode")>] member this.selectedNode (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: AntDesign.TreeNode<'TItem>) = "SelectedNode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedNodeChanged")>] member this.selectedNodeChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeNode<'TItem>> "SelectedNodeChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedData")>] member this.selectedData (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: 'TItem) = "SelectedData" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedDataChanged")>] member this.selectedDataChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<'TItem> "SelectedDataChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedKeys")>] member this.selectedKeys (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.String[]) = "SelectedKeys" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedKeysChanged")>] member this.selectedKeysChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<System.String[]> "SelectedKeysChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedNodes")>] member this.selectedNodes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: AntDesign.TreeNode<'TItem>[]) = "SelectedNodes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selectedDatas")>] member this.selectedDatas (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: 'TItem[]) = "SelectedDatas" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checkable")>] member this.checkable (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Boolean) = "Checkable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("searchValue")>] member this.searchValue (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.String) = "SearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("searchExpression")>] member this.searchExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "SearchExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dataSource")>] member this.dataSource (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Collections.Generic.IList<'TItem>) = "DataSource" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleExpression")>] member this.titleExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "TitleExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyExpression")>] member this.keyExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "KeyExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconExpression")>] member this.iconExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.String>) = "IconExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isLeafExpression")>] member this.isLeafExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Boolean>) = "IsLeafExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childrenExpression")>] member this.childrenExpression (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.Func<AntDesign.TreeNode<'TItem>, System.Collections.Generic.IList<'TItem>>) = "ChildrenExpression" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onNodeLoadDelayAsync")>] member this.onNodeLoadDelayAsync (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnNodeLoadDelayAsync" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDblClick")>] member this.onDblClick (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnDblClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onContextMenu")>] member this.onContextMenu (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnContextMenu" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCheckBoxChanged")>] member this.onCheckBoxChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnCheckBoxChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onExpandChanged")>] member this.onExpandChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnExpandChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSearchValueChanged")>] member this.onSearchValueChanged (_: FunBlazorContext<AntDesign.Tree<'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.TreeEventArgs<'TItem>> "OnSearchValueChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("indentTemplate")>] member this.indentTemplate (_: FunBlazorContext<AntDesign.Tree<'TItem>>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "IndentTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Tree<'TItem>>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "TitleTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleIconTemplate")>] member this.titleIconTemplate (_: FunBlazorContext<AntDesign.Tree<'TItem>>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "TitleIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("switcherIconTemplate")>] member this.switcherIconTemplate (_: FunBlazorContext<AntDesign.Tree<'TItem>>, render: AntDesign.TreeNode<'TItem> -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "SwitcherIconTemplate" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Tree<'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TreeNodeBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = TreeNodeBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeNodeBuilder<'FunBlazorGeneric>()

    [<CustomOperation("nodes")>] member this.nodes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, nodes) = Bolero.Html.attr.fragment "Nodes" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nodes")>] member this.nodes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: string) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nodes")>] member this.nodes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: int) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("nodes")>] member this.nodes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: float) = Bolero.Html.attr.fragment "Nodes" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("key")>] member this.key (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.String) = "Key" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("selected")>] member this.selected (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Selected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isLeaf")>] member this.isLeaf (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "IsLeaf" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("expanded")>] member this.expanded (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Expanded" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("checked'")>] member this.checked' (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Checked" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("indeterminate")>] member this.indeterminate (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Indeterminate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disableCheckbox")>] member this.disableCheckbox (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "DisableCheckbox" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("draggable")>] member this.draggable (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.Boolean) = "Draggable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dataItem")>] member this.dataItem (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: 'TItem) = "DataItem" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.TreeNode<'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TypographyBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TypographyBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TypographyBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TypographyBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TypographyBaseBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TypographyBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("copyable")>] member this.copyable (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyConfig")>] member this.copyConfig (_: FunBlazorContext<AntDesign.TypographyBase>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("delete")>] member this.delete (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editConfig")>] member this.editConfig (_: FunBlazorContext<AntDesign.TypographyBase>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsisConfig")>] member this.ellipsisConfig (_: FunBlazorContext<AntDesign.TypographyBase>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mark")>] member this.mark (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("underline")>] member this.underline (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strong")>] member this.strong (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TypographyBase>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TypographyBase>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TypographyBase>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.TypographyBase>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.TypographyBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.TypographyBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.TypographyBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.TypographyBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type LinkBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = LinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = LinkBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = LinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = LinkBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = LinkBuilder<'FunBlazorGeneric>()

    [<CustomOperation("code")>] member this.code (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyboard")>] member this.keyboard (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyable")>] member this.copyable (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyConfig")>] member this.copyConfig (_: FunBlazorContext<AntDesign.Link>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("delete")>] member this.delete (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editConfig")>] member this.editConfig (_: FunBlazorContext<AntDesign.Link>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsisConfig")>] member this.ellipsisConfig (_: FunBlazorContext<AntDesign.Link>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mark")>] member this.mark (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("underline")>] member this.underline (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strong")>] member this.strong (_: FunBlazorContext<AntDesign.Link>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Link>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Link>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Link>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Link>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Link>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Link>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Link>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Link>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Link>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Link>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ParagraphBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ParagraphBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ParagraphBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ParagraphBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ParagraphBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ParagraphBuilder<'FunBlazorGeneric>()

    [<CustomOperation("code")>] member this.code (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyboard")>] member this.keyboard (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyable")>] member this.copyable (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyConfig")>] member this.copyConfig (_: FunBlazorContext<AntDesign.Paragraph>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("delete")>] member this.delete (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editConfig")>] member this.editConfig (_: FunBlazorContext<AntDesign.Paragraph>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsisConfig")>] member this.ellipsisConfig (_: FunBlazorContext<AntDesign.Paragraph>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mark")>] member this.mark (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("underline")>] member this.underline (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strong")>] member this.strong (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Paragraph>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Paragraph>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Paragraph>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Paragraph>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Paragraph>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Paragraph>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Paragraph>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Paragraph>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Paragraph>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Paragraph>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TextBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TextBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TextBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TextBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TextBuilder<'FunBlazorGeneric>()

    [<CustomOperation("code")>] member this.code (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Code" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("keyboard")>] member this.keyboard (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Keyboard" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyable")>] member this.copyable (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyConfig")>] member this.copyConfig (_: FunBlazorContext<AntDesign.Text>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("delete")>] member this.delete (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editConfig")>] member this.editConfig (_: FunBlazorContext<AntDesign.Text>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsisConfig")>] member this.ellipsisConfig (_: FunBlazorContext<AntDesign.Text>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mark")>] member this.mark (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("underline")>] member this.underline (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strong")>] member this.strong (_: FunBlazorContext<AntDesign.Text>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Text>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Text>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Text>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Text>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Text>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Text>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Text>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Text>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Text>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Text>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TitleBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit TypographyBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TitleBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TitleBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TitleBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TitleBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TitleBuilder<'FunBlazorGeneric>()

    [<CustomOperation("level")>] member this.level (_: FunBlazorContext<AntDesign.Title>, x: System.Int32) = "Level" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyable")>] member this.copyable (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Copyable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("copyConfig")>] member this.copyConfig (_: FunBlazorContext<AntDesign.Title>, x: AntDesign.TypographyCopyableConfig) = "CopyConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("delete")>] member this.delete (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Delete" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editable")>] member this.editable (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Editable" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("editConfig")>] member this.editConfig (_: FunBlazorContext<AntDesign.Title>, x: AntDesign.TypographyEditableConfig) = "EditConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsis")>] member this.ellipsis (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Ellipsis" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ellipsisConfig")>] member this.ellipsisConfig (_: FunBlazorContext<AntDesign.Title>, x: AntDesign.TypographyEllipsisConfig) = "EllipsisConfig" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mark")>] member this.mark (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Mark" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("underline")>] member this.underline (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Underline" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("strong")>] member this.strong (_: FunBlazorContext<AntDesign.Title>, x: System.Boolean) = "Strong" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Title>, x: System.Action) = "OnChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.Title>, x: System.String) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Title>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Title>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Title>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Title>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Title>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Title>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Title>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Title>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type UploadBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = UploadBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = UploadBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = UploadBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = UploadBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = UploadBuilder<'FunBlazorGeneric>()

    [<CustomOperation("beforeUpload")>] member this.beforeUpload (_: FunBlazorContext<AntDesign.Upload>, x: System.Func<AntDesign.UploadFileItem, System.Boolean>) = "BeforeUpload" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("beforeAllUploadAsync")>] member this.beforeAllUploadAsync (_: FunBlazorContext<AntDesign.Upload>, x: System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Threading.Tasks.Task<System.Boolean>>) = "BeforeAllUploadAsync" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("beforeAllUpload")>] member this.beforeAllUpload (_: FunBlazorContext<AntDesign.Upload>, x: System.Func<System.Collections.Generic.List<AntDesign.UploadFileItem>, System.Boolean>) = "BeforeAllUpload" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("action")>] member this.action (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "Action" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Upload>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("listType")>] member this.listType (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "ListType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("directory")>] member this.directory (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "Directory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiple")>] member this.multiple (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("accept")>] member this.accept (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "Accept" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showUploadList")>] member this.showUploadList (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "ShowUploadList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fileList")>] member this.fileList (_: FunBlazorContext<AntDesign.Upload>, x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "FileList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Upload>, x: AntDesign.UploadLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("fileListChanged")>] member this.fileListChanged (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<System.Collections.Generic.List<AntDesign.UploadFileItem>> "FileListChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("defaultFileList")>] member this.defaultFileList (_: FunBlazorContext<AntDesign.Upload>, x: System.Collections.Generic.List<AntDesign.UploadFileItem>) = "DefaultFileList" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headers")>] member this.headers (_: FunBlazorContext<AntDesign.Upload>, x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSingleCompleted")>] member this.onSingleCompleted (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnSingleCompleted" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCompleted")>] member this.onCompleted (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnCompleted" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onChange")>] member this.onChange (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadInfo> "OnChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRemove")>] member this.onRemove (_: FunBlazorContext<AntDesign.Upload>, x: System.Func<AntDesign.UploadFileItem, System.Threading.Tasks.Task<System.Boolean>>) = "OnRemove" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onPreview")>] member this.onPreview (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnPreview" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onDownload")>] member this.onDownload (_: FunBlazorContext<AntDesign.Upload>, fn) = (Bolero.Html.attr.callback<AntDesign.UploadFileItem> "OnDownload" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Upload>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Upload>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Upload>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Upload>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("showButton")>] member this.showButton (_: FunBlazorContext<AntDesign.Upload>, x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Upload>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Upload>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Upload>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Upload>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type BreadcrumbItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BreadcrumbItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = BreadcrumbItemBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = BreadcrumbItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = BreadcrumbItemBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = BreadcrumbItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BreadcrumbItem>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: System.Object) = "Overlay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.BreadcrumbItem>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CalendarHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CalendarHeaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CalendarHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.CalendarHeader>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.CalendarHeader>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.CalendarHeader>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.CalendarHeader>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type CardMetaBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CardMetaBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CardMetaBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.CardMeta>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.CardMeta>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("description")>] member this.description (_: FunBlazorContext<AntDesign.CardMeta>, x: System.String) = "Description" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.CardMeta>, nodes) = Bolero.Html.attr.fragment "DescriptionTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: string) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: int) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("descriptionTemplate")>] member this.descriptionTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: float) = Bolero.Html.attr.fragment "DescriptionTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatar")>] member this.avatar (_: FunBlazorContext<AntDesign.CardMeta>, x: System.String) = "Avatar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.CardMeta>, nodes) = Bolero.Html.attr.fragment "AvatarTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: string) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: int) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("avatarTemplate")>] member this.avatarTemplate (_: FunBlazorContext<AntDesign.CardMeta>, x: float) = Bolero.Html.attr.fragment "AvatarTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.CardMeta>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.CardMeta>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.CardMeta>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.CardMeta>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type AntContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntContainerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = AntContainerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.AntContainer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.AntContainer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.AntContainer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.AntContainer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TemplateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TemplateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TemplateBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TemplateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TemplateBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TemplateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Template>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Template>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Template>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Template>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("if'")>] member this.if' (_: FunBlazorContext<AntDesign.Template>, x: System.Func<System.Boolean>) = "If" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Template>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Template>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Template>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Template>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type EmptyDefaultImgBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = EmptyDefaultImgBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = EmptyDefaultImgBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.EmptyDefaultImg>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type EmptySimpleImgBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = EmptySimpleImgBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = EmptySimpleImgBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.EmptySimpleImg>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ContentBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ContentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Content>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Content>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Content>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Content>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Content>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Content>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Content>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Content>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = FooterBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FooterBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FooterBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FooterBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = FooterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Footer>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Footer>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Footer>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Footer>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Footer>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Footer>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Footer>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Footer>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type HeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = HeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = HeaderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = HeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = HeaderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = HeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Header>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Header>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Header>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Header>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Header>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Header>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Header>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Header>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type LayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = LayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = LayoutBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = LayoutBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = LayoutBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = LayoutBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Layout>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Layout>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Layout>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Layout>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Layout>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Layout>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Layout>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Layout>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type MenuDividerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = MenuDividerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = MenuDividerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.MenuDivider>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.MenuDivider>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.MenuDivider>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.MenuDivider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PaginationPagerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PaginationPagerBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PaginationPagerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("showTitle")>] member this.showTitle (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Boolean) = "ShowTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("page")>] member this.page (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Int32) = "Page" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("rootPrefixCls")>] member this.rootPrefixCls (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.String) = "RootPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("active")>] member this.active (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Boolean) = "Active" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.PaginationPager>, fn) = (Bolero.Html.attr.callback<System.Int32> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyPress")>] member this.onKeyPress (_: FunBlazorContext<AntDesign.PaginationPager>, fn) = (Bolero.Html.attr.callback<System.ValueTuple<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs, System.Action>> "OnKeyPress" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("itemRender")>] member this.itemRender (_: FunBlazorContext<AntDesign.PaginationPager>, render: AntDesign.PaginationItemRenderContext -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "ItemRender" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("unmatchedAttributes")>] member this.unmatchedAttributes (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "UnmatchedAttributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.PaginationPager>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.PaginationPager>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.PaginationPager>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.PaginationPager>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Select.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type SelectOptionGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SelectOptionGroupBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = SelectOptionGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type CalendarPanelChooserBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = CalendarPanelChooserBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = CalendarPanelChooserBuilder<'FunBlazorGeneric>()

    [<CustomOperation("calendar")>] member this.calendar (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: AntDesign.Calendar) = "Calendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.CalendarPanelChooser>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type ElementBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = ElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ElementBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ElementBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ElementBuilder<'FunBlazorGeneric>()

    [<CustomOperation("htmlTag")>] member this.htmlTag (_: FunBlazorContext<AntDesign.Internal.Element>, x: System.String) = "HtmlTag" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.Element>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.Element>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.Element>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.Element>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("refChanged")>] member this.refChanged (_: FunBlazorContext<AntDesign.Internal.Element>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ElementReference> "RefChanged" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("attributes")>] member this.attributes (_: FunBlazorContext<AntDesign.Internal.Element>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Attributes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.Element>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.Element>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.Element>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.Element>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type OverlayBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = OverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = OverlayBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = OverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = OverlayBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = OverlayBuilder<'FunBlazorGeneric>()

    [<CustomOperation("overlayChildPrefixCls")>] member this.overlayChildPrefixCls (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.String) = "OverlayChildPrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.Overlay>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayMouseEnter")>] member this.onOverlayMouseEnter (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayMouseLeave")>] member this.onOverlayMouseLeave (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnOverlayMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onShow")>] member this.onShow (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Action) = "OnShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onHide")>] member this.onHide (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Action) = "OnHide" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hideMillisecondsDelay")>] member this.hideMillisecondsDelay (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Int32) = "HideMillisecondsDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("waitForHideAnimMilliseconds")>] member this.waitForHideAnimMilliseconds (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Int32) = "WaitForHideAnimMilliseconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("verticalOffset")>] member this.verticalOffset (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Int32) = "VerticalOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("horizontalOffset")>] member this.horizontalOffset (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Int32) = "HorizontalOffset" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenMode")>] member this.hiddenMode (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.Overlay>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type OverlayTriggerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = OverlayTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = OverlayTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = OverlayTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = OverlayTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = OverlayTriggerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("boundaryAdjustMode")>] member this.boundaryAdjustMode (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("complexAutoCloseAndVisible")>] member this.complexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenMode")>] member this.hiddenMode (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineFlexMode")>] member this.inlineFlexMode (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isButton")>] member this.isButton (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMaskClick")>] member this.onMaskClick (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayHiding")>] member this.onOverlayHiding (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onVisibleChange")>] member this.onVisibleChange (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayClassName")>] member this.overlayClassName (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayEnterCls")>] member this.overlayEnterCls (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayHiddenCls")>] member this.overlayHiddenCls (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayLeaveCls")>] member this.overlayLeaveCls (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayStyle")>] member this.overlayStyle (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placementCls")>] member this.placementCls (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("triggerReference")>] member this.triggerReference (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unbound")>] member this.unbound (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.OverlayTrigger>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type DropdownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DropdownBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DropdownBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DropdownBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DropdownBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DropdownBuilder<'FunBlazorGeneric>()

    [<CustomOperation("boundaryAdjustMode")>] member this.boundaryAdjustMode (_: FunBlazorContext<AntDesign.Dropdown>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Dropdown>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Dropdown>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Dropdown>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Dropdown>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("complexAutoCloseAndVisible")>] member this.complexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenMode")>] member this.hiddenMode (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineFlexMode")>] member this.inlineFlexMode (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isButton")>] member this.isButton (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Dropdown>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMaskClick")>] member this.onMaskClick (_: FunBlazorContext<AntDesign.Dropdown>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayHiding")>] member this.onOverlayHiding (_: FunBlazorContext<AntDesign.Dropdown>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onVisibleChange")>] member this.onVisibleChange (_: FunBlazorContext<AntDesign.Dropdown>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Dropdown>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Dropdown>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Dropdown>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Dropdown>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayClassName")>] member this.overlayClassName (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayEnterCls")>] member this.overlayEnterCls (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayHiddenCls")>] member this.overlayHiddenCls (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayLeaveCls")>] member this.overlayLeaveCls (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayStyle")>] member this.overlayStyle (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.Dropdown>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placementCls")>] member this.placementCls (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Dropdown>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("triggerReference")>] member this.triggerReference (_: FunBlazorContext<AntDesign.Dropdown>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unbound")>] member this.unbound (_: FunBlazorContext<AntDesign.Dropdown>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Dropdown>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Dropdown>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Dropdown>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Dropdown>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Dropdown>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DropdownButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DropdownBuilder<'FunBlazorGeneric>()
    new (x: string) as this = DropdownButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = DropdownButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = DropdownButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = DropdownButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = DropdownButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("block")>] member this.block (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Block" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("buttonsRender")>] member this.buttonsRender (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Func<Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.RenderFragment>) = "ButtonsRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("danger")>] member this.danger (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Danger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("ghost")>] member this.ghost (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Ghost" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("loading")>] member this.loading (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Loading" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("type'")>] member this.type' (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.ValueTuple<System.String, System.String>) = "Type" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("boundaryAdjustMode")>] member this.boundaryAdjustMode (_: FunBlazorContext<AntDesign.DropdownButton>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DropdownButton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DropdownButton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DropdownButton>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.DropdownButton>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("complexAutoCloseAndVisible")>] member this.complexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenMode")>] member this.hiddenMode (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineFlexMode")>] member this.inlineFlexMode (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isButton")>] member this.isButton (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.DropdownButton>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMaskClick")>] member this.onMaskClick (_: FunBlazorContext<AntDesign.DropdownButton>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayHiding")>] member this.onOverlayHiding (_: FunBlazorContext<AntDesign.DropdownButton>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onVisibleChange")>] member this.onVisibleChange (_: FunBlazorContext<AntDesign.DropdownButton>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.DropdownButton>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.DropdownButton>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.DropdownButton>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.DropdownButton>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayClassName")>] member this.overlayClassName (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayEnterCls")>] member this.overlayEnterCls (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayHiddenCls")>] member this.overlayHiddenCls (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayLeaveCls")>] member this.overlayLeaveCls (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayStyle")>] member this.overlayStyle (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.DropdownButton>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placementCls")>] member this.placementCls (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.DropdownButton>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("triggerReference")>] member this.triggerReference (_: FunBlazorContext<AntDesign.DropdownButton>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unbound")>] member this.unbound (_: FunBlazorContext<AntDesign.DropdownButton>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.DropdownButton>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.DropdownButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.DropdownButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.DropdownButton>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PopconfirmBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    new (x: string) as this = PopconfirmBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = PopconfirmBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = PopconfirmBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = PopconfirmBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = PopconfirmBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelText")>] member this.cancelText (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "CancelText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("okText")>] member this.okText (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OkText" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("okType")>] member this.okType (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OkType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("okButtonProps")>] member this.okButtonProps (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.ButtonProps) = "OkButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cancelButtonProps")>] member this.cancelButtonProps (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.ButtonProps) = "CancelButtonProps" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("icon")>] member this.icon (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "Icon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconTemplate")>] member this.iconTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, nodes) = Bolero.Html.attr.fragment "IconTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconTemplate")>] member this.iconTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: string) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconTemplate")>] member this.iconTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: int) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("iconTemplate")>] member this.iconTemplate (_: FunBlazorContext<AntDesign.Popconfirm>, x: float) = Bolero.Html.attr.fragment "IconTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onCancel")>] member this.onCancel (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCancel" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onConfirm")>] member this.onConfirm (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnConfirm" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("arrowPointAtCenter")>] member this.arrowPointAtCenter (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mouseEnterDelay")>] member this.mouseEnterDelay (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mouseLeaveDelay")>] member this.mouseLeaveDelay (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("boundaryAdjustMode")>] member this.boundaryAdjustMode (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Popconfirm>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Popconfirm>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Popconfirm>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Popconfirm>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("complexAutoCloseAndVisible")>] member this.complexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenMode")>] member this.hiddenMode (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineFlexMode")>] member this.inlineFlexMode (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isButton")>] member this.isButton (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMaskClick")>] member this.onMaskClick (_: FunBlazorContext<AntDesign.Popconfirm>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayHiding")>] member this.onOverlayHiding (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onVisibleChange")>] member this.onVisibleChange (_: FunBlazorContext<AntDesign.Popconfirm>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Popconfirm>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Popconfirm>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Popconfirm>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Popconfirm>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayClassName")>] member this.overlayClassName (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayEnterCls")>] member this.overlayEnterCls (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayHiddenCls")>] member this.overlayHiddenCls (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayLeaveCls")>] member this.overlayLeaveCls (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayStyle")>] member this.overlayStyle (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placementCls")>] member this.placementCls (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("triggerReference")>] member this.triggerReference (_: FunBlazorContext<AntDesign.Popconfirm>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unbound")>] member this.unbound (_: FunBlazorContext<AntDesign.Popconfirm>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Popconfirm>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Popconfirm>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Popconfirm>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Popconfirm>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PopoverBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    new (x: string) as this = PopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = PopoverBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = PopoverBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = PopoverBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = PopoverBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Popover>, nodes) = Bolero.Html.attr.fragment "TitleTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Popover>, x: string) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Popover>, x: int) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("titleTemplate")>] member this.titleTemplate (_: FunBlazorContext<AntDesign.Popover>, x: float) = Bolero.Html.attr.fragment "TitleTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("content")>] member this.content (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "Content" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentTemplate")>] member this.contentTemplate (_: FunBlazorContext<AntDesign.Popover>, nodes) = Bolero.Html.attr.fragment "ContentTemplate" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentTemplate")>] member this.contentTemplate (_: FunBlazorContext<AntDesign.Popover>, x: string) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentTemplate")>] member this.contentTemplate (_: FunBlazorContext<AntDesign.Popover>, x: int) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentTemplate")>] member this.contentTemplate (_: FunBlazorContext<AntDesign.Popover>, x: float) = Bolero.Html.attr.fragment "ContentTemplate" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("arrowPointAtCenter")>] member this.arrowPointAtCenter (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mouseEnterDelay")>] member this.mouseEnterDelay (_: FunBlazorContext<AntDesign.Popover>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mouseLeaveDelay")>] member this.mouseLeaveDelay (_: FunBlazorContext<AntDesign.Popover>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("boundaryAdjustMode")>] member this.boundaryAdjustMode (_: FunBlazorContext<AntDesign.Popover>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Popover>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Popover>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Popover>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Popover>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("complexAutoCloseAndVisible")>] member this.complexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenMode")>] member this.hiddenMode (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineFlexMode")>] member this.inlineFlexMode (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isButton")>] member this.isButton (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Popover>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMaskClick")>] member this.onMaskClick (_: FunBlazorContext<AntDesign.Popover>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.Popover>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.Popover>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayHiding")>] member this.onOverlayHiding (_: FunBlazorContext<AntDesign.Popover>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onVisibleChange")>] member this.onVisibleChange (_: FunBlazorContext<AntDesign.Popover>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Popover>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Popover>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Popover>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Popover>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayClassName")>] member this.overlayClassName (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayEnterCls")>] member this.overlayEnterCls (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayHiddenCls")>] member this.overlayHiddenCls (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayLeaveCls")>] member this.overlayLeaveCls (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayStyle")>] member this.overlayStyle (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.Popover>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placementCls")>] member this.placementCls (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Popover>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("triggerReference")>] member this.triggerReference (_: FunBlazorContext<AntDesign.Popover>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unbound")>] member this.unbound (_: FunBlazorContext<AntDesign.Popover>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Popover>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Popover>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Popover>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Popover>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Popover>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type TooltipBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    new (x: string) as this = TooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = TooltipBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = TooltipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = TooltipBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = TooltipBuilder<'FunBlazorGeneric>()

    [<CustomOperation("title")>] member this.title (_: FunBlazorContext<AntDesign.Tooltip>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment, Microsoft.AspNetCore.Components.MarkupString>) = "Title" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("arrowPointAtCenter")>] member this.arrowPointAtCenter (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "ArrowPointAtCenter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mouseEnterDelay")>] member this.mouseEnterDelay (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Double) = "MouseEnterDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("mouseLeaveDelay")>] member this.mouseLeaveDelay (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Double) = "MouseLeaveDelay" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("boundaryAdjustMode")>] member this.boundaryAdjustMode (_: FunBlazorContext<AntDesign.Tooltip>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tooltip>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tooltip>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tooltip>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Tooltip>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("complexAutoCloseAndVisible")>] member this.complexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenMode")>] member this.hiddenMode (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineFlexMode")>] member this.inlineFlexMode (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isButton")>] member this.isButton (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Tooltip>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMaskClick")>] member this.onMaskClick (_: FunBlazorContext<AntDesign.Tooltip>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayHiding")>] member this.onOverlayHiding (_: FunBlazorContext<AntDesign.Tooltip>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onVisibleChange")>] member this.onVisibleChange (_: FunBlazorContext<AntDesign.Tooltip>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Tooltip>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Tooltip>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Tooltip>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Tooltip>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayClassName")>] member this.overlayClassName (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayEnterCls")>] member this.overlayEnterCls (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayHiddenCls")>] member this.overlayHiddenCls (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayLeaveCls")>] member this.overlayLeaveCls (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayStyle")>] member this.overlayStyle (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.Tooltip>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placementCls")>] member this.placementCls (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Tooltip>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("triggerReference")>] member this.triggerReference (_: FunBlazorContext<AntDesign.Tooltip>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unbound")>] member this.unbound (_: FunBlazorContext<AntDesign.Tooltip>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Tooltip>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Tooltip>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Tooltip>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Tooltip>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Tooltip>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type SubMenuTriggerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit Internal.OverlayTriggerBuilder<'FunBlazorGeneric>()
    new (x: string) as this = SubMenuTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = SubMenuTriggerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = SubMenuTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = SubMenuTriggerBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = SubMenuTriggerBuilder<'FunBlazorGeneric>()

    [<CustomOperation("triggerClass")>] member this.triggerClass (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "TriggerClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("boundaryAdjustMode")>] member this.boundaryAdjustMode (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: AntDesign.TriggerBoundaryAdjustMode) = "BoundaryAdjustMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("complexAutoCloseAndVisible")>] member this.complexAutoCloseAndVisible (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "ComplexAutoCloseAndVisible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("hiddenMode")>] member this.hiddenMode (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "HiddenMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("inlineFlexMode")>] member this.inlineFlexMode (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "InlineFlexMode" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isButton")>] member this.isButton (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "IsButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMaskClick")>] member this.onMaskClick (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnMaskClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseEnter")>] member this.onMouseEnter (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Action) = "OnMouseEnter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onMouseLeave")>] member this.onMouseLeave (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Action) = "OnMouseLeave" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onOverlayHiding")>] member this.onOverlayHiding (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnOverlayHiding" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onVisibleChange")>] member this.onVisibleChange (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, nodes) = Bolero.Html.attr.fragment "Overlay" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: string) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: int) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlay")>] member this.overlay (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: float) = Bolero.Html.attr.fragment "Overlay" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayClassName")>] member this.overlayClassName (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayClassName" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayEnterCls")>] member this.overlayEnterCls (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayEnterCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayHiddenCls")>] member this.overlayHiddenCls (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayHiddenCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayLeaveCls")>] member this.overlayLeaveCls (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayLeaveCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("overlayStyle")>] member this.overlayStyle (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "OverlayStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placement")>] member this.placement (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: AntDesign.PlacementType) = "Placement" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placementCls")>] member this.placementCls (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "PlacementCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("popupContainerSelector")>] member this.popupContainerSelector (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "PopupContainerSelector" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("trigger")>] member this.trigger (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: AntDesign.TriggerType[]) = "Trigger" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("triggerReference")>] member this.triggerReference (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: Microsoft.AspNetCore.Components.ElementReference) = "TriggerReference" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("unbound")>] member this.unbound (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, render: AntDesign.ForwardRef -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "Unbound" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("visible")>] member this.visible (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.Boolean) = "Visible" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.SubMenuTrigger>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerPanelChooserBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerPanelChooserBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerPanelChooserBuilder<'FunBlazorGeneric>()

    [<CustomOperation("datePicker")>] member this.datePicker (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: AntDesign.DatePickerBase<'TValue>) = "DatePicker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerPanelChooser<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type PickerPanelBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PickerPanelBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = PickerPanelBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.PickerPanelBase>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type DatePickerPanelBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit Internal.PickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerPanelBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerPanelBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.DatePickerPanelBase<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type DatePickerDatetimePanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerDatetimePanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerDatetimePanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowTime")>] member this.isShowTime (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "IsShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTimeFormat")>] member this.showTimeFormat (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "ShowTimeFormat" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("format")>] member this.format (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "Format" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledHours")>] member this.disabledHours (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledHours" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledMinutes")>] member this.disabledMinutes (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledMinutes" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledSeconds")>] member this.disabledSeconds (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.Int32[]>) = "DisabledSeconds" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledTime")>] member this.disabledTime (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, AntDesign.DatePickerDisabledTime>) = "DisabledTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerTemplateBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerTemplateBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerTemplateBuilder<'FunBlazorGeneric>()

    [<CustomOperation("renderPickerHeader")>] member this.renderPickerHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderPickerHeader" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderPickerHeader")>] member this.renderPickerHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderPickerHeader")>] member this.renderPickerHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderPickerHeader")>] member this.renderPickerHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderPickerHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderTableHeader")>] member this.renderTableHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderTableHeader" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderTableHeader")>] member this.renderTableHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderTableHeader")>] member this.renderTableHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderTableHeader")>] member this.renderTableHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderTableHeader" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderFirstCol")>] member this.renderFirstCol (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderFirstCol" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderColValue")>] member this.renderColValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderColValue" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderLastCol")>] member this.renderLastCol (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, render: System.DateTime -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "RenderLastCol" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("viewStartDate")>] member this.viewStartDate (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.DateTime) = "ViewStartDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getColTitle")>] member this.getColTitle (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.String>) = "GetColTitle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getRowClass")>] member this.getRowClass (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.String>) = "GetRowClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getNextColValue")>] member this.getNextColValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.DateTime>) = "GetNextColValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isInView")>] member this.isInView (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "IsInView" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isToday")>] member this.isToday (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "IsToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isSelected")>] member this.isSelected (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "IsSelected" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRowSelect")>] member this.onRowSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime>) = "OnRowSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onValueSelect")>] member this.onValueSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime>) = "OnValueSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showFooter")>] member this.showFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Boolean) = "ShowFooter" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxRow")>] member this.maxRow (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Int32) = "MaxRow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("maxCol")>] member this.maxCol (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Int32) = "MaxCol" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerTemplate<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerDatePanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerDatePanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerDatePanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("isWeek")>] member this.isWeek (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "IsWeek" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showToday")>] member this.showToday (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "ShowToday" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerDatePanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerDecadePanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerDecadePanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerDecadePanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerDecadePanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerFooterBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerFooterBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerFooter<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerHeaderBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerHeaderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("superChangeDateInterval")>] member this.superChangeDateInterval (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Int32) = "SuperChangeDateInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeDateInterval")>] member this.changeDateInterval (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Int32) = "ChangeDateInterval" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSuperPreChange")>] member this.showSuperPreChange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "ShowSuperPreChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showPreChange")>] member this.showPreChange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "ShowPreChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showNextChange")>] member this.showNextChange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "ShowNextChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSuperNextChange")>] member this.showSuperNextChange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "ShowSuperNextChange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerHeader<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerMonthPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerMonthPanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerMonthPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerMonthPanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerQuarterPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerQuarterPanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerQuarterPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerYearPanelBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit DatePickerPanelBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerYearPanelBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerYearPanelBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("picker")>] member this.picker (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.String) = "Picker" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isCalendar")>] member this.isCalendar (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Boolean) = "IsCalendar" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isShowHeader")>] member this.isShowHeader (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Boolean) = "IsShowHeader" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("locale")>] member this.locale (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: AntDesign.DatePickerLocale) = "Locale" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("cultureInfo")>] member this.cultureInfo (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Globalization.CultureInfo) = "CultureInfo" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("closePanel")>] member this.closePanel (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action) = "ClosePanel" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerValue")>] member this.changePickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action<System.DateTime, System.Nullable<System.Int32>>) = "ChangePickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changeValue")>] member this.changeValue (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "ChangeValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("changePickerType")>] member this.changePickerType (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action<System.String, System.Int32>) = "ChangePickerType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexPickerValue")>] member this.getIndexPickerValue (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.Int32, System.DateTime>) = "GetIndexPickerValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("getIndexValue")>] member this.getIndexValue (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.Int32, System.Nullable<System.DateTime>>) = "GetIndexValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabledDate")>] member this.disabledDate (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, System.Boolean>) = "DisabledDate" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("dateRender")>] member this.dateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "DateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("monthCellRender")>] member this.monthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "MonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarDateRender")>] member this.calendarDateRender (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarDateRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("calendarMonthCellRender")>] member this.calendarMonthCellRender (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Func<System.DateTime, Microsoft.AspNetCore.Components.RenderFragment>) = "CalendarMonthCellRender" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, nodes) = Bolero.Html.attr.fragment "RenderExtraFooter" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: string) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: int) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("renderExtraFooter")>] member this.renderExtraFooter (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: float) = Bolero.Html.attr.fragment "RenderExtraFooter" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onSelect")>] member this.onSelect (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Action<System.DateTime, System.Int32>) = "OnSelect" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("pickerIndex")>] member this.pickerIndex (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.Int32) = "PickerIndex" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerYearPanel<'TValue>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DatePickerInputBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DatePickerInputBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DatePickerInputBuilder<'FunBlazorGeneric>()

    [<CustomOperation("prefixCls")>] member this.prefixCls (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "PrefixCls" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("size")>] member this.size (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "Size" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("value")>] member this.value (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "Value" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("readOnly")>] member this.readOnly (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "ReadOnly" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isRange")>] member this.isRange (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "IsRange" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("autoFocus")>] member this.autoFocus (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "AutoFocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showSuffixIcon")>] member this.showSuffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "ShowSuffixIcon" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showTime")>] member this.showTime (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "ShowTime" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, nodes) = Bolero.Html.attr.fragment "SuffixIcon" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: string) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: int) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("suffixIcon")>] member this.suffixIcon (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: float) = Bolero.Html.attr.fragment "SuffixIcon" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClick")>] member this.onClick (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClick" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onfocus")>] member this.onfocus (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocus" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnBlur" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onfocusout")>] member this.onfocusout (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "Onfocusout" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("allowClear")>] member this.allowClear (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.Boolean) = "AllowClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClickClear")>] member this.onClickClear (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: Microsoft.AspNetCore.Components.EventCallback) = "OnClickClear" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DatePickerInput>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type DropdownGroupButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = DropdownGroupButtonBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = DropdownGroupButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("leftButton")>] member this.leftButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, nodes) = Bolero.Html.attr.fragment "LeftButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("leftButton")>] member this.leftButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: string) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("leftButton")>] member this.leftButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: int) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("leftButton")>] member this.leftButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: float) = Bolero.Html.attr.fragment "LeftButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("rightButton")>] member this.rightButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, nodes) = Bolero.Html.attr.fragment "RightButton" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("rightButton")>] member this.rightButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: string) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("rightButton")>] member this.rightButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: int) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("rightButton")>] member this.rightButton (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: float) = Bolero.Html.attr.fragment "RightButton" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("id")>] member this.id (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: System.String) = "Id" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.DropdownGroupButton>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type TemplateComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = TemplateComponentBaseBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TemplateComponentBaseBuilder<'FunBlazorGeneric>()

    [<CustomOperation("options")>] member this.options (_: FunBlazorContext<AntDesign.TemplateComponentBase<'TComponentOptions>>, x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.TemplateComponentBase<'TComponentOptions>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FeedbackComponentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit TemplateComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = FeedbackComponentBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FeedbackComponentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("feedbackRef")>] member this.feedbackRef (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions>>, x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("options")>] member this.options (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions>>, x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FeedbackComponentBuilder2<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FeedbackComponentBuilder<'FunBlazorGeneric>()
    static member create () = FeedbackComponentBuilder2<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FeedbackComponentBuilder2<'FunBlazorGeneric>()

    [<CustomOperation("feedbackRef")>] member this.feedbackRef (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>, x: AntDesign.IFeedbackRef) = "FeedbackRef" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("options")>] member this.options (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>, x: 'TComponentOptions) = "Options" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                

type FormProviderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = FormProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = FormProviderBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = FormProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = FormProviderBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = FormProviderBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onFormFinish")>] member this.onFormFinish (_: FunBlazorContext<AntDesign.FormProvider>, fn) = (Bolero.Html.attr.callback<AntDesign.FormProviderFinishEventArgs> "OnFormFinish" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.FormProvider>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.FormProvider>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.FormProvider>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.FormProvider>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.FormProvider>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
namespace rec AntDesign.DslInternals.Internal

open Bolero.Html
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslCE.DslInternals
open Microsoft.AspNetCore.Components.Web.DslCE.DslInternals
open AntDesign.DslInternals


type UploadButtonBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = UploadButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = UploadButtonBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = UploadButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = UploadButtonBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = UploadButtonBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.UploadButton>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("listType")>] member this.listType (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.String) = "ListType" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showButton")>] member this.showButton (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Boolean) = "ShowButton" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("name")>] member this.name (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.String) = "Name" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("directory")>] member this.directory (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Boolean) = "Directory" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("multiple")>] member this.multiple (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Boolean) = "Multiple" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("accept")>] member this.accept (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.String) = "Accept" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("data")>] member this.data (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Collections.Generic.Dictionary<System.String, System.Object>) = "Data" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("headers")>] member this.headers (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Collections.Generic.Dictionary<System.String, System.String>) = "Headers" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("action")>] member this.action (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.String) = "Action" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("disabled")>] member this.disabled (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: System.Boolean) = "Disabled" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Internal.UploadButton>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
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

    [<CustomOperation("control")>] member this.control (_: FunBlazorContext<AntDesign.FormValidationMessage<'TValue>>, x: AntDesign.AntInputComponentBase<'TValue>) = "Control" => x |> BoleroAttr |> this.AddProp
                

type FormValidationMessageItemBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContextWithAttrs<'FunBlazorGeneric>()
    static member create () = FormValidationMessageItemBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = FormValidationMessageItemBuilder<'FunBlazorGeneric>()

    [<CustomOperation("message")>] member this.message (_: FunBlazorContext<AntDesign.FormValidationMessageItem>, x: System.String) = "Message" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = ImagePreviewBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = ImagePreviewBuilder<'FunBlazorGeneric>()

    [<CustomOperation("imageRef")>] member this.imageRef (_: FunBlazorContext<AntDesign.ImagePreview>, x: AntDesign.ImageRef) = "ImageRef" => x |> BoleroAttr |> this.AddProp
                

type ImagePreviewGroupBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    new (x: string) as this = ImagePreviewGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    new (x: IFunBlazorNode list) as this = ImagePreviewGroupBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp |> ignore
    static member create (x: string) = ImagePreviewGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    static member create (x: IFunBlazorNode list) = ImagePreviewGroupBuilder<'FunBlazorGeneric>(x) :> IFunBlazorNode
    
    member this.Yield _ = ImagePreviewGroupBuilder<'FunBlazorGeneric>()

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ImagePreviewGroup>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ImagePreviewGroup>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ImagePreviewGroup>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.ImagePreviewGroup>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                

type TreeIndentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeIndentBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeIndentBuilder<'FunBlazorGeneric>()

    [<CustomOperation("treeLevel")>] member this.treeLevel (_: FunBlazorContext<AntDesign.TreeIndent<'TItem>>, x: System.Int32) = "TreeLevel" => x |> BoleroAttr |> this.AddProp
                

type TreeNodeCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeCheckboxBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeNodeCheckboxBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onCheckBoxClick")>] member this.onCheckBoxClick (_: FunBlazorContext<AntDesign.TreeNodeCheckbox<'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnCheckBoxClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

type TreeNodeSwitcherBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent> () =
    inherit FunBlazorContext<'FunBlazorGeneric>()
    static member create () = TreeNodeSwitcherBuilder<'FunBlazorGeneric>() :> IFunBlazorNode
    
    member this.Yield _ = TreeNodeSwitcherBuilder<'FunBlazorGeneric>()

    [<CustomOperation("onSwitcherClick")>] member this.onSwitcherClick (_: FunBlazorContext<AntDesign.TreeNodeSwitcher<'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnSwitcherClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
                

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

    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SummaryRow>, nodes) = Bolero.Html.attr.fragment "ChildContent" (nodes |> html.fragment |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SummaryRow>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SummaryRow>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorContext<AntDesign.SummaryRow>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x |> html.toBolero) |> BoleroAttr |> this.AddProp
                
            
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

    [<CustomOperation("labelTemplateItemContent")>] member this.labelTemplateItemContent (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, render: 'TItem -> IFunBlazorNode) = Bolero.Html.attr.fragmentWith "LabelTemplateItemContent" (fun x -> render x |> html.toBolero) |> BoleroAttr |> this.AddProp
    [<CustomOperation("styles")>] member this.styles (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: (string * string) list) = attr.styles x |> this.AddProp
    [<CustomOperation("classes")>] member this.classes (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: string list) = attr.classes x |> this.AddProp
    [<CustomOperation("contentStyle")>] member this.contentStyle (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: System.String) = "ContentStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("contentClass")>] member this.contentClass (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: System.String) = "ContentClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("removeIconStyle")>] member this.removeIconStyle (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: System.String) = "RemoveIconStyle" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("removeIconClass")>] member this.removeIconClass (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: System.String) = "RemoveIconClass" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            
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

    [<CustomOperation("prefix")>] member this.prefix (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.String) = "Prefix" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("placeholder")>] member this.placeholder (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.String) = "Placeholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("isOverlayShow")>] member this.isOverlayShow (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.Boolean) = "IsOverlayShow" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("showPlaceholder")>] member this.showPlaceholder (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.Boolean) = "ShowPlaceholder" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("onInput")>] member this.onInput (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.ChangeEventArgs> "OnInput" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyUp")>] member this.onKeyUp (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyUp" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onKeyDown")>] member this.onKeyDown (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs> "OnKeyDown" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onFocus")>] member this.onFocus (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnFocus" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onBlur")>] member this.onBlur (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.FocusEventArgs> "OnBlur" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onClearClick")>] member this.onClearClick (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnClearClick" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("onRemoveSelected")>] member this.onRemoveSelected (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, fn) = (Bolero.Html.attr.callback<AntDesign.Select.Internal.SelectOptionItem<'TItemValue, 'TItem>> "OnRemoveSelected" (fun e -> fn e)) |> BoleroAttr |> this.AddProp
    [<CustomOperation("searchValue")>] member this.searchValue (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: System.String) = "SearchValue" => x |> BoleroAttr |> this.AddProp
    [<CustomOperation("refBack")>] member this.refBack (_: FunBlazorContext<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>, x: AntDesign.ForwardRef) = "RefBack" => x |> BoleroAttr |> this.AddProp
                
            

// =======================================================================================================================

namespace AntDesign

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals

    type antComponentBase = AntComponentBaseBuilder<AntDesign.AntComponentBase>
    type configProvider = ConfigProviderBuilder<AntDesign.ConfigProvider>
    type antDomComponentBase = AntDomComponentBaseBuilder<AntDesign.AntDomComponentBase>
    type affix = AffixBuilder<AntDesign.Affix>
    type alert = AlertBuilder<AntDesign.Alert>
    type anchor = AnchorBuilder<AntDesign.Anchor>
    type anchorLink = AnchorLinkBuilder<AntDesign.AnchorLink>
    type autoCompleteOptGroup = AutoCompleteOptGroupBuilder<AntDesign.AutoCompleteOptGroup>
    type autoCompleteOption = AutoCompleteOptionBuilder<AntDesign.AutoCompleteOption>
    type avatar = AvatarBuilder<AntDesign.Avatar>
    type avatarGroup = AvatarGroupBuilder<AntDesign.AvatarGroup>
    type backTop = BackTopBuilder<AntDesign.BackTop>
    type badge = BadgeBuilder<AntDesign.Badge>
    type badgeRibbon = BadgeRibbonBuilder<AntDesign.BadgeRibbon>
    type breadcrumb = BreadcrumbBuilder<AntDesign.Breadcrumb>
    type button = ButtonBuilder<AntDesign.Button>
    type buttonGroup = ButtonGroupBuilder<AntDesign.ButtonGroup>
    type calendar = CalendarBuilder<AntDesign.Calendar>
    type card = CardBuilder<AntDesign.Card>
    type cardAction = CardActionBuilder<AntDesign.CardAction>
    type cardGrid = CardGridBuilder<AntDesign.CardGrid>
    type carousel = CarouselBuilder<AntDesign.Carousel>
    type carouselSlick = CarouselSlickBuilder<AntDesign.CarouselSlick>
    type collapse = CollapseBuilder<AntDesign.Collapse>
    type panel = PanelBuilder<AntDesign.Panel>
    type comment = CommentBuilder<AntDesign.Comment>
    type antContainerComponentBase = AntContainerComponentBaseBuilder<AntDesign.AntContainerComponentBase>
    type antInputComponentBase<'TValue> = AntInputComponentBaseBuilder<AntDesign.AntInputComponentBase<'TValue>>
    type autoComplete<'TOption> = AutoCompleteBuilder<AntDesign.AutoComplete<'TOption>>
    type cascader = CascaderBuilder<AntDesign.Cascader>
    type checkboxGroup = CheckboxGroupBuilder<AntDesign.CheckboxGroup>
    type antInputBoolComponentBase = AntInputBoolComponentBaseBuilder<AntDesign.AntInputBoolComponentBase>
    type checkbox = CheckboxBuilder<AntDesign.Checkbox>
    type switch = SwitchBuilder<AntDesign.Switch>
    type datePickerBase<'TValue> = DatePickerBaseBuilder<AntDesign.DatePickerBase<'TValue>>
    type datePicker<'TValue> = DatePickerBuilder<AntDesign.DatePicker<'TValue>>
    type monthPicker<'TValue> = MonthPickerBuilder<AntDesign.MonthPicker<'TValue>>
    type quarterPicker<'TValue> = QuarterPickerBuilder<AntDesign.QuarterPicker<'TValue>>
    type weekPicker<'TValue> = WeekPickerBuilder<AntDesign.WeekPicker<'TValue>>
    type yearPicker<'TValue> = YearPickerBuilder<AntDesign.YearPicker<'TValue>>
    type timePicker<'TValue> = TimePickerBuilder<AntDesign.TimePicker<'TValue>>
    type rangePicker<'TValue> = RangePickerBuilder<AntDesign.RangePicker<'TValue>>
    type inputNumber<'TValue> = InputNumberBuilder<AntDesign.InputNumber<'TValue>>
    type input<'TValue> = InputBuilder<AntDesign.Input<'TValue>>
    type autoCompleteInput<'TValue> = AutoCompleteInputBuilder<AntDesign.AutoCompleteInput<'TValue>>
    type inputPassword = InputPasswordBuilder<AntDesign.InputPassword>
    type search = SearchBuilder<AntDesign.Search>
    type autoCompleteSearch = AutoCompleteSearchBuilder<AntDesign.AutoCompleteSearch>
    type textArea = TextAreaBuilder<AntDesign.TextArea>
    type radioGroup<'TValue> = RadioGroupBuilder<AntDesign.RadioGroup<'TValue>>
    type select<'TItemValue, 'TItem> = SelectBuilder<AntDesign.Select<'TItemValue, 'TItem>>
    type simpleSelect = SimpleSelectBuilder<AntDesign.SimpleSelect>
    type slider<'TValue> = SliderBuilder<AntDesign.Slider<'TValue>>
    type descriptions = DescriptionsBuilder<AntDesign.Descriptions>
    type descriptionsItem = DescriptionsItemBuilder<AntDesign.DescriptionsItem>
    type divider = DividerBuilder<AntDesign.Divider>
    type drawer = DrawerBuilder<AntDesign.Drawer>
    type drawerContainer = DrawerContainerBuilder<AntDesign.DrawerContainer>
    type empty = EmptyBuilder<AntDesign.Empty>
    type form<'TModel> = FormBuilder<AntDesign.Form<'TModel>>
    type formItem = FormItemBuilder<AntDesign.FormItem>
    type col = ColBuilder<AntDesign.Col>
    type gridCol = GridColBuilder<AntDesign.GridCol>
    type row = RowBuilder<AntDesign.Row>
    type icon = IconBuilder<AntDesign.Icon>
    type iconFont = IconFontBuilder<AntDesign.IconFont>
    type image = ImageBuilder<AntDesign.Image>
    type imagePreviewContainer = ImagePreviewContainerBuilder<AntDesign.ImagePreviewContainer>
    type inputGroup = InputGroupBuilder<AntDesign.InputGroup>
    type sider = SiderBuilder<AntDesign.Sider>
    type antList<'TItem> = AntListBuilder<AntDesign.AntList<'TItem>>
    type listItem = ListItemBuilder<AntDesign.ListItem>
    type listItemMeta = ListItemMetaBuilder<AntDesign.ListItemMeta>
    type mentions = MentionsBuilder<AntDesign.Mentions>
    type mentionsOption = MentionsOptionBuilder<AntDesign.MentionsOption>
    type menu = MenuBuilder<AntDesign.Menu>
    type menuItem = MenuItemBuilder<AntDesign.MenuItem>
    type menuItemGroup = MenuItemGroupBuilder<AntDesign.MenuItemGroup>
    type menuLink = MenuLinkBuilder<AntDesign.MenuLink>
    type subMenu = SubMenuBuilder<AntDesign.SubMenu>
    type message = MessageBuilder<AntDesign.Message>
    type messageItem = MessageItemBuilder<AntDesign.MessageItem>
    type comfirmContainer = ComfirmContainerBuilder<AntDesign.ComfirmContainer>
    type confirm = ConfirmBuilder<AntDesign.Confirm>
    type dialog = DialogBuilder<AntDesign.Dialog>
    type dialogWrapper = DialogWrapperBuilder<AntDesign.DialogWrapper>
    type modal = ModalBuilder<AntDesign.Modal>
    type modalContainer = ModalContainerBuilder<AntDesign.ModalContainer>
    type modalFooter = ModalFooterBuilder<AntDesign.ModalFooter>
    type notificationBase = NotificationBaseBuilder<AntDesign.NotificationBase>
    type notification = NotificationBuilder<AntDesign.Notification>
    type notificationItem = NotificationItemBuilder<AntDesign.NotificationItem>
    type pageHeader = PageHeaderBuilder<AntDesign.PageHeader>
    type pagination = PaginationBuilder<AntDesign.Pagination>
    type paginationOptions = PaginationOptionsBuilder<AntDesign.PaginationOptions>
    type progress = ProgressBuilder<AntDesign.Progress>
    type radio<'TValue> = RadioBuilder<AntDesign.Radio<'TValue>>
    type rate = RateBuilder<AntDesign.Rate>
    type rateItem = RateItemBuilder<AntDesign.RateItem>
    type result = ResultBuilder<AntDesign.Result>
    type selectOption<'TItemValue, 'TItem> = SelectOptionBuilder<AntDesign.SelectOption<'TItemValue, 'TItem>>
    type simpleSelectOption = SimpleSelectOptionBuilder<AntDesign.SimpleSelectOption>
    type skeleton = SkeletonBuilder<AntDesign.Skeleton>
    type skeletonElement = SkeletonElementBuilder<AntDesign.SkeletonElement>
    type space = SpaceBuilder<AntDesign.Space>
    type spaceItem = SpaceItemBuilder<AntDesign.SpaceItem>
    type spin = SpinBuilder<AntDesign.Spin>
    type statisticComponentBase<'T> = StatisticComponentBaseBuilder<AntDesign.StatisticComponentBase<'T>>
    type countDown = CountDownBuilder<AntDesign.CountDown>
    type statistic<'TValue> = StatisticBuilder<AntDesign.Statistic<'TValue>>
    type step = StepBuilder<AntDesign.Step>
    type steps = StepsBuilder<AntDesign.Steps>
    type columnBase = ColumnBaseBuilder<AntDesign.ColumnBase>
    type actionColumn = ActionColumnBuilder<AntDesign.ActionColumn>
    type column<'TData> = ColumnBuilder<AntDesign.Column<'TData>>
    type selection = SelectionBuilder<AntDesign.Selection>
    type summaryCell = SummaryCellBuilder<AntDesign.SummaryCell>
    type table<'TItem> = TableBuilder<AntDesign.Table<'TItem>>
    type tabPane = TabPaneBuilder<AntDesign.TabPane>
    type tabs = TabsBuilder<AntDesign.Tabs>
    type tag = TagBuilder<AntDesign.Tag>
    type timeline = TimelineBuilder<AntDesign.Timeline>
    type timelineItem = TimelineItemBuilder<AntDesign.TimelineItem>
    type transfer = TransferBuilder<AntDesign.Transfer>
    type tree<'TItem> = TreeBuilder<AntDesign.Tree<'TItem>>
    type treeNode<'TItem> = TreeNodeBuilder<AntDesign.TreeNode<'TItem>>
    type typographyBase = TypographyBaseBuilder<AntDesign.TypographyBase>
    type link = LinkBuilder<AntDesign.Link>
    type paragraph = ParagraphBuilder<AntDesign.Paragraph>
    type text = TextBuilder<AntDesign.Text>
    type title = TitleBuilder<AntDesign.Title>
    type upload = UploadBuilder<AntDesign.Upload>
    type breadcrumbItem = BreadcrumbItemBuilder<AntDesign.BreadcrumbItem>
    type calendarHeader = CalendarHeaderBuilder<AntDesign.CalendarHeader>
    type cardMeta = CardMetaBuilder<AntDesign.CardMeta>
    type antContainer = AntContainerBuilder<AntDesign.AntContainer>
    type template = TemplateBuilder<AntDesign.Template>
    type emptyDefaultImg = EmptyDefaultImgBuilder<AntDesign.EmptyDefaultImg>
    type emptySimpleImg = EmptySimpleImgBuilder<AntDesign.EmptySimpleImg>
    type content = ContentBuilder<AntDesign.Content>
    type footer = FooterBuilder<AntDesign.Footer>
    type header = HeaderBuilder<AntDesign.Header>
    type layout = LayoutBuilder<AntDesign.Layout>
    type menuDivider = MenuDividerBuilder<AntDesign.MenuDivider>
    type paginationPager = PaginationPagerBuilder<AntDesign.PaginationPager>
    type dropdown = DropdownBuilder<AntDesign.Dropdown>
    type dropdownButton = DropdownButtonBuilder<AntDesign.DropdownButton>
    type popconfirm = PopconfirmBuilder<AntDesign.Popconfirm>
    type popover = PopoverBuilder<AntDesign.Popover>
    type tooltip = TooltipBuilder<AntDesign.Tooltip>
    type datePickerPanelBase<'TValue> = DatePickerPanelBaseBuilder<AntDesign.DatePickerPanelBase<'TValue>>
    type templateComponentBase<'TComponentOptions> = TemplateComponentBaseBuilder<AntDesign.TemplateComponentBase<'TComponentOptions>>
    type feedbackComponent<'TComponentOptions> = FeedbackComponentBuilder<AntDesign.FeedbackComponent<'TComponentOptions>>
    type feedbackComponent<'TComponentOptions, 'TResult> = FeedbackComponentBuilder2<AntDesign.FeedbackComponent<'TComponentOptions, 'TResult>>
    type formProvider = FormProviderBuilder<AntDesign.FormProvider>
    type formValidationMessage<'TValue> = FormValidationMessageBuilder<AntDesign.FormValidationMessage<'TValue>>
    type formValidationMessageItem = FormValidationMessageItemBuilder<AntDesign.FormValidationMessageItem>
    type imagePreview = ImagePreviewBuilder<AntDesign.ImagePreview>
    type imagePreviewGroup = ImagePreviewGroupBuilder<AntDesign.ImagePreviewGroup>
    type treeIndent<'TItem> = TreeIndentBuilder<AntDesign.TreeIndent<'TItem>>
    type treeNodeCheckbox<'TItem> = TreeNodeCheckboxBuilder<AntDesign.TreeNodeCheckbox<'TItem>>
    type treeNodeSwitcher<'TItem> = TreeNodeSwitcherBuilder<AntDesign.TreeNodeSwitcher<'TItem>>
    type treeNodeTitle<'TItem> = TreeNodeTitleBuilder<AntDesign.TreeNodeTitle<'TItem>>
    type cardLoading = CardLoadingBuilder<AntDesign.CardLoading>
    type summaryRow = SummaryRowBuilder<AntDesign.SummaryRow>
            
namespace AntDesign.Select.Internal

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Select.Internal

    type selectOptionGroup<'TItemValue, 'TItem> = SelectOptionGroupBuilder<AntDesign.Select.Internal.SelectOptionGroup<'TItemValue, 'TItem>>
    type selectContent<'TItemValue, 'TItem> = SelectContentBuilder<AntDesign.Select.Internal.SelectContent<'TItemValue, 'TItem>>
            
namespace AntDesign.Internal

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Internal

    type calendarPanelChooser = CalendarPanelChooserBuilder<AntDesign.Internal.CalendarPanelChooser>
    type element = ElementBuilder<AntDesign.Internal.Element>
    type overlay = OverlayBuilder<AntDesign.Internal.Overlay>
    type overlayTrigger = OverlayTriggerBuilder<AntDesign.Internal.OverlayTrigger>
    type subMenuTrigger = SubMenuTriggerBuilder<AntDesign.Internal.SubMenuTrigger>
    type datePickerPanelChooser<'TValue> = DatePickerPanelChooserBuilder<AntDesign.Internal.DatePickerPanelChooser<'TValue>>
    type pickerPanelBase = PickerPanelBaseBuilder<AntDesign.Internal.PickerPanelBase>
    type datePickerDatetimePanel<'TValue> = DatePickerDatetimePanelBuilder<AntDesign.Internal.DatePickerDatetimePanel<'TValue>>
    type datePickerTemplate<'TValue> = DatePickerTemplateBuilder<AntDesign.Internal.DatePickerTemplate<'TValue>>
    type datePickerDatePanel<'TValue> = DatePickerDatePanelBuilder<AntDesign.Internal.DatePickerDatePanel<'TValue>>
    type datePickerDecadePanel<'TValue> = DatePickerDecadePanelBuilder<AntDesign.Internal.DatePickerDecadePanel<'TValue>>
    type datePickerFooter<'TValue> = DatePickerFooterBuilder<AntDesign.Internal.DatePickerFooter<'TValue>>
    type datePickerHeader<'TValue> = DatePickerHeaderBuilder<AntDesign.Internal.DatePickerHeader<'TValue>>
    type datePickerMonthPanel<'TValue> = DatePickerMonthPanelBuilder<AntDesign.Internal.DatePickerMonthPanel<'TValue>>
    type datePickerQuarterPanel<'TValue> = DatePickerQuarterPanelBuilder<AntDesign.Internal.DatePickerQuarterPanel<'TValue>>
    type datePickerYearPanel<'TValue> = DatePickerYearPanelBuilder<AntDesign.Internal.DatePickerYearPanel<'TValue>>
    type datePickerInput = DatePickerInputBuilder<AntDesign.Internal.DatePickerInput>
    type dropdownGroupButton = DropdownGroupButtonBuilder<AntDesign.Internal.DropdownGroupButton>
    type uploadButton = UploadButtonBuilder<AntDesign.Internal.UploadButton>
            
namespace AntDesign.statistic

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.statistic

    type statisticComponentBase<'T> = StatisticComponentBaseBuilder<AntDesign.statistic.StatisticComponentBase<'T>>
            
namespace AntDesign.Select

[<AutoOpen>]
module DslCE =

    open AntDesign.DslInternals.Select

    type labelTemplateItem<'TItemValue, 'TItem> = LabelTemplateItemBuilder<AntDesign.Select.LabelTemplateItem<'TItemValue, 'TItem>>
            