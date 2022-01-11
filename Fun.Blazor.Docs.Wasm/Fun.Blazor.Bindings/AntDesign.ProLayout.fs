namespace rec AntDesign.ProLayout.DslInternals

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.ProLayout.DslInternals


type AntComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = AntComponentBaseBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("RefBack")>] member this.RefBack (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ForwardRef) = "RefBack" => x |> this.AddAttr
                

type AntDomComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AntDomComponentBaseBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Id")>] member this.Id (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Id" => x |> this.AddAttr
    [<CustomOperation("Classes")>] member this.Classes (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string list) = attr.classes x |> this.AddAttr
    [<CustomOperation("Styles")>] member this.Styles (_: FunBlazorBuilder<'FunBlazorGeneric>, x: (string * string) list) = attr.styles x |> this.AddAttr
                
            
namespace rec AntDesign.ProLayout.DslInternals.ProLayout

open Bolero.Html
open FSharp.Data.Adaptive
open Fun.Blazor
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.ProLayout.DslInternals


type AntProComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = AntProComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = AntProComponentBaseBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = AntProComponentBaseBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = AntProComponentBaseBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("NavTheme")>] member this.NavTheme (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.MenuTheme) = "NavTheme" => x |> this.AddAttr
    [<CustomOperation("HeaderHeight")>] member this.HeaderHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "HeaderHeight" => x |> this.AddAttr
    [<CustomOperation("Layout")>] member this.Layout (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.Layout) = "Layout" => x |> this.AddAttr
    [<CustomOperation("ContentWidth")>] member this.ContentWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ContentWidth" => x |> this.AddAttr
    [<CustomOperation("FixedHeader")>] member this.FixedHeader (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FixedHeader" => x |> this.AddAttr
    [<CustomOperation("FixSiderbar")>] member this.FixSiderbar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "FixSiderbar" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("IconfontUrl")>] member this.IconfontUrl (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "IconfontUrl" => x |> this.AddAttr
    [<CustomOperation("PrimaryColor")>] member this.PrimaryColor (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PrimaryColor" => x |> this.AddAttr
    [<CustomOperation("ColorWeak")>] member this.ColorWeak (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ColorWeak" => x |> this.AddAttr
    [<CustomOperation("SplitMenus")>] member this.SplitMenus (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "SplitMenus" => x |> this.AddAttr
    [<CustomOperation("HeaderRender")>] member this.HeaderRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HeaderRender" => x |> this.AddAttr
    [<CustomOperation("FooterRender")>] member this.FooterRender (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "FooterRender" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("FooterRender")>] member this.FooterRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "FooterRender" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterRender")>] member this.FooterRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "FooterRender" (html.text x) |> this.AddAttr
    [<CustomOperation("FooterRender")>] member this.FooterRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "FooterRender" (html.text x) |> this.AddAttr
    [<CustomOperation("MenuRender")>] member this.MenuRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MenuRender" => x |> this.AddAttr
    [<CustomOperation("MenuHeaderRender")>] member this.MenuHeaderRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "MenuHeaderRender" => x |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
                

type BasicLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = BasicLayoutBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Collapsed")>] member this.Collapsed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Collapsed" => x |> this.AddAttr
    [<CustomOperation("HandleOpenChange")>] member this.HandleOpenChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "HandleOpenChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("IsMobile")>] member this.IsMobile (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsMobile" => x |> this.AddAttr
    [<CustomOperation("MenuData")>] member this.MenuData (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.MenuDataItem[]) = "MenuData" => x |> this.AddAttr
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.MenuMode) = "Mode" => x |> this.AddAttr
    [<CustomOperation("OnCollapse")>] member this.OnCollapse (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OpenKeys")>] member this.OpenKeys (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String[]) = "OpenKeys" => x |> this.AddAttr
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.MenuTheme) = "Theme" => x |> this.AddAttr
    [<CustomOperation("Logo")>] member this.Logo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Logo" => x |> this.AddAttr
    [<CustomOperation("BaseURL")>] member this.BaseURL (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "BaseURL" => x |> this.AddAttr
    [<CustomOperation("SiderWidth")>] member this.SiderWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "SiderWidth" => x |> this.AddAttr
    [<CustomOperation("MenuExtraRender")>] member this.MenuExtraRender (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "MenuExtraRender" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("MenuExtraRender")>] member this.MenuExtraRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "MenuExtraRender" (html.text x) |> this.AddAttr
    [<CustomOperation("MenuExtraRender")>] member this.MenuExtraRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "MenuExtraRender" (html.text x) |> this.AddAttr
    [<CustomOperation("MenuExtraRender")>] member this.MenuExtraRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "MenuExtraRender" (html.text x) |> this.AddAttr
    [<CustomOperation("CollapsedButtonRender")>] member this.CollapsedButtonRender (_: FunBlazorBuilder<'FunBlazorGeneric>, render: System.Boolean -> Bolero.Node) = Bolero.Html.attr.fragmentWith "CollapsedButtonRender" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.BreakpointType) = "Breakpoint" => x |> this.AddAttr
    [<CustomOperation("OnMenuHeaderClick")>] member this.OnMenuHeaderClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMenuHeaderClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Hide")>] member this.Hide (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Hide" => x |> this.AddAttr
    [<CustomOperation("Links")>] member this.Links (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = "Links" => x |> this.AddAttr
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnOpenChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Pure")>] member this.Pure (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Pure" => x |> this.AddAttr
    [<CustomOperation("Loading")>] member this.Loading (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Loading" => x |> this.AddAttr
    [<CustomOperation("DisableContentMargin")>] member this.DisableContentMargin (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "DisableContentMargin" => x |> this.AddAttr
    [<CustomOperation("ContentStyle")>] member this.ContentStyle (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ContentStyle" => x |> this.AddAttr
    [<CustomOperation("ColSize")>] member this.ColSize (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ColSize" => x |> this.AddAttr
    [<CustomOperation("RightContentRender")>] member this.RightContentRender (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "RightContentRender" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("RightContentRender")>] member this.RightContentRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "RightContentRender" (html.text x) |> this.AddAttr
    [<CustomOperation("RightContentRender")>] member this.RightContentRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "RightContentRender" (html.text x) |> this.AddAttr
    [<CustomOperation("RightContentRender")>] member this.RightContentRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "RightContentRender" (html.text x) |> this.AddAttr
                

type GlobalHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = GlobalHeaderBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> this.AddAttr
    [<CustomOperation("OnCollapse")>] member this.OnCollapse (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("CollapsedButtonRender")>] member this.CollapsedButtonRender (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "CollapsedButtonRender" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("CollapsedButtonRender")>] member this.CollapsedButtonRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "CollapsedButtonRender" (html.text x) |> this.AddAttr
    [<CustomOperation("CollapsedButtonRender")>] member this.CollapsedButtonRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "CollapsedButtonRender" (html.text x) |> this.AddAttr
    [<CustomOperation("CollapsedButtonRender")>] member this.CollapsedButtonRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "CollapsedButtonRender" (html.text x) |> this.AddAttr
    [<CustomOperation("Collapsed")>] member this.Collapsed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Collapsed" => x |> this.AddAttr
    [<CustomOperation("IsMobile")>] member this.IsMobile (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsMobile" => x |> this.AddAttr
    [<CustomOperation("Logo")>] member this.Logo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Logo" => x |> this.AddAttr
                

type HeaderViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = HeaderViewBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Collapsed")>] member this.Collapsed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Collapsed" => x |> this.AddAttr
    [<CustomOperation("IsMobile")>] member this.IsMobile (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsMobile" => x |> this.AddAttr
    [<CustomOperation("Logo")>] member this.Logo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Logo" => x |> this.AddAttr
    [<CustomOperation("HasSiderMenu")>] member this.HasSiderMenu (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HasSiderMenu" => x |> this.AddAttr
    [<CustomOperation("SiderWidth")>] member this.SiderWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "SiderWidth" => x |> this.AddAttr
    [<CustomOperation("HeaderContentRender")>] member this.HeaderContentRender (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "HeaderContentRender" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("HeaderContentRender")>] member this.HeaderContentRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "HeaderContentRender" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderContentRender")>] member this.HeaderContentRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "HeaderContentRender" (html.text x) |> this.AddAttr
    [<CustomOperation("HeaderContentRender")>] member this.HeaderContentRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "HeaderContentRender" (html.text x) |> this.AddAttr
    [<CustomOperation("MenuData")>] member this.MenuData (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.MenuDataItem[]) = "MenuData" => x |> this.AddAttr
                

type BaseMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = BaseMenuBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Collapsed")>] member this.Collapsed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Collapsed" => x |> this.AddAttr
    [<CustomOperation("HandleOpenChange")>] member this.HandleOpenChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "HandleOpenChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("IsMobile")>] member this.IsMobile (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsMobile" => x |> this.AddAttr
    [<CustomOperation("MenuData")>] member this.MenuData (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.MenuDataItem[]) = "MenuData" => x |> this.AddAttr
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.MenuMode) = "Mode" => x |> this.AddAttr
    [<CustomOperation("OnCollapse")>] member this.OnCollapse (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OpenKeys")>] member this.OpenKeys (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String[]) = "OpenKeys" => x |> this.AddAttr
                

type SiderMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SiderMenuBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("HandleOpenChange")>] member this.HandleOpenChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "HandleOpenChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("IsMobile")>] member this.IsMobile (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsMobile" => x |> this.AddAttr
    [<CustomOperation("MenuData")>] member this.MenuData (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.MenuDataItem[]) = "MenuData" => x |> this.AddAttr
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.MenuMode) = "Mode" => x |> this.AddAttr
    [<CustomOperation("OnCollapse")>] member this.OnCollapse (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OpenKeys")>] member this.OpenKeys (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String[]) = "OpenKeys" => x |> this.AddAttr
    [<CustomOperation("Logo")>] member this.Logo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Logo" => x |> this.AddAttr
    [<CustomOperation("BaseURL")>] member this.BaseURL (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "BaseURL" => x |> this.AddAttr
    [<CustomOperation("SiderWidth")>] member this.SiderWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "SiderWidth" => x |> this.AddAttr
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.BreakpointType) = "Breakpoint" => x |> this.AddAttr
    [<CustomOperation("Hide")>] member this.Hide (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Hide" => x |> this.AddAttr
    [<CustomOperation("Links")>] member this.Links (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = "Links" => x |> this.AddAttr
    [<CustomOperation("OnMenuHeaderClick")>] member this.OnMenuHeaderClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMenuHeaderClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnOpenChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("SiderTheme")>] member this.SiderTheme (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.SiderTheme) = "SiderTheme" => x |> this.AddAttr
    [<CustomOperation("CollapsedButtonRender")>] member this.CollapsedButtonRender (_: FunBlazorBuilder<'FunBlazorGeneric>, render: System.Boolean -> Bolero.Node) = Bolero.Html.attr.fragmentWith "CollapsedButtonRender" (fun x -> render x) |> this.AddAttr
                

type TopNavHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = TopNavHeaderBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Collapsed")>] member this.Collapsed (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Collapsed" => x |> this.AddAttr
    [<CustomOperation("HandleOpenChange")>] member this.HandleOpenChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "HandleOpenChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("IsMobile")>] member this.IsMobile (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsMobile" => x |> this.AddAttr
    [<CustomOperation("MenuData")>] member this.MenuData (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.MenuDataItem[]) = "MenuData" => x |> this.AddAttr
    [<CustomOperation("Mode")>] member this.Mode (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.MenuMode) = "Mode" => x |> this.AddAttr
    [<CustomOperation("OnCollapse")>] member this.OnCollapse (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnCollapse" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OpenKeys")>] member this.OpenKeys (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String[]) = "OpenKeys" => x |> this.AddAttr
    [<CustomOperation("Theme")>] member this.Theme (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.MenuTheme) = "Theme" => x |> this.AddAttr
    [<CustomOperation("Logo")>] member this.Logo (_: FunBlazorBuilder<'FunBlazorGeneric>, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = "Logo" => x |> this.AddAttr
    [<CustomOperation("SiderWidth")>] member this.SiderWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "SiderWidth" => x |> this.AddAttr
    [<CustomOperation("MenuExtraRender")>] member this.MenuExtraRender (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "MenuExtraRender" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("MenuExtraRender")>] member this.MenuExtraRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "MenuExtraRender" (html.text x) |> this.AddAttr
    [<CustomOperation("MenuExtraRender")>] member this.MenuExtraRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "MenuExtraRender" (html.text x) |> this.AddAttr
    [<CustomOperation("MenuExtraRender")>] member this.MenuExtraRender (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "MenuExtraRender" (html.text x) |> this.AddAttr
    [<CustomOperation("CollapsedButtonRender")>] member this.CollapsedButtonRender (_: FunBlazorBuilder<'FunBlazorGeneric>, render: System.Boolean -> Bolero.Node) = Bolero.Html.attr.fragmentWith "CollapsedButtonRender" (fun x -> render x) |> this.AddAttr
    [<CustomOperation("Breakpoint")>] member this.Breakpoint (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.BreakpointType) = "Breakpoint" => x |> this.AddAttr
    [<CustomOperation("OnMenuHeaderClick")>] member this.OnMenuHeaderClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs> "OnMenuHeaderClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Hide")>] member this.Hide (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Hide" => x |> this.AddAttr
    [<CustomOperation("Links")>] member this.Links (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = "Links" => x |> this.AddAttr
    [<CustomOperation("OnOpenChange")>] member this.OnOpenChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String[]> "OnOpenChange" (fun e -> fn e)) |> this.AddAttr
                

type FooterViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = FooterViewBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Copyright")>] member this.Copyright (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Copyright" => x |> this.AddAttr
    [<CustomOperation("Links")>] member this.Links (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.LinkItem[]) = "Links" => x |> this.AddAttr
                

type SiderMenuWrapperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SiderMenuWrapperBuilder<'FunBlazorGeneric>().CreateNode()

                

type GlobalFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = GlobalFooterBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Copyright")>] member this.Copyright (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Copyright" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Copyright")>] member this.Copyright (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Copyright" (html.text x) |> this.AddAttr
    [<CustomOperation("Copyright")>] member this.Copyright (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Copyright" (html.text x) |> this.AddAttr
    [<CustomOperation("Copyright")>] member this.Copyright (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Copyright" (html.text x) |> this.AddAttr
    [<CustomOperation("Links")>] member this.Links (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.LinkItem[]) = "Links" => x |> this.AddAttr
                

type GridContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = GridContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = GridContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = GridContentBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = GridContentBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ContentWidth")>] member this.ContentWidth (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ContentWidth" => x |> this.AddAttr
                

type HeaderSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = HeaderSearchBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("DefaultValue")>] member this.DefaultValue (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "DefaultValue" => x |> this.AddAttr
    [<CustomOperation("Placeholder")>] member this.Placeholder (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Placeholder" => x |> this.AddAttr
    [<CustomOperation("OnVisibleChange")>] member this.OnVisibleChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.Boolean> "OnVisibleChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Options")>] member this.Options (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.List<AntDesign.AutoCompleteDataItem<System.String>>) = "Options" => x |> this.AddAttr
                

type NoticeIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = NoticeIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = NoticeIconBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = NoticeIconBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = NoticeIconBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Visible")>] member this.Visible (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "Visible" => x |> this.AddAttr
    [<CustomOperation("Count")>] member this.Count (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "Count" => x |> this.AddAttr
    [<CustomOperation("ClearText")>] member this.ClearText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ClearText" => x |> this.AddAttr
    [<CustomOperation("ViewMoreText")>] member this.ViewMoreText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ViewMoreText" => x |> this.AddAttr
    [<CustomOperation("OnClear")>] member this.OnClear (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnClear" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnViewMore")>] member this.OnViewMore (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnViewMore" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
                

type NoticeListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = NoticeListBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("TabKey")>] member this.TabKey (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "TabKey" => x |> this.AddAttr
    [<CustomOperation("EmptyText")>] member this.EmptyText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "EmptyText" => x |> this.AddAttr
    [<CustomOperation("Data")>] member this.Data (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.ICollection<AntDesign.ProLayout.NoticeIconData>) = "Data" => x |> this.AddAttr
    [<CustomOperation("ShowClear")>] member this.ShowClear (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowClear" => x |> this.AddAttr
    [<CustomOperation("ShowViewMore")>] member this.ShowViewMore (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "ShowViewMore" => x |> this.AddAttr
    [<CustomOperation("OnClear")>] member this.OnClear (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = attr.callbackOfUnit("OnClear", fn) |> this.AddAttr
    [<CustomOperation("OnViewMore")>] member this.OnViewMore (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = attr.callbackOfUnit("OnViewMore", fn) |> this.AddAttr
    [<CustomOperation("OnItemClick")>] member this.OnItemClick (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnItemClick" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("ClearText")>] member this.ClearText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ClearText" => x |> this.AddAttr
    [<CustomOperation("ViewMoreText")>] member this.ViewMoreText (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "ViewMoreText" => x |> this.AddAttr
                

type PageContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = PageContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = PageContainerBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = PageContainerBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = PageContainerBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Extra" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Extra" (html.text x) |> this.AddAttr
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Extra" (html.text x) |> this.AddAttr
    [<CustomOperation("Extra")>] member this.Extra (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Extra" (html.text x) |> this.AddAttr
    [<CustomOperation("ExtraContent")>] member this.ExtraContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ExtraContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("ExtraContent")>] member this.ExtraContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ExtraContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ExtraContent")>] member this.ExtraContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ExtraContent" (html.text x) |> this.AddAttr
    [<CustomOperation("ExtraContent")>] member this.ExtraContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ExtraContent" (html.text x) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Content" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("Content")>] member this.Content (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Content" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("Breadcrumb")>] member this.Breadcrumb (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "Breadcrumb" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("Breadcrumb")>] member this.Breadcrumb (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "Breadcrumb" (html.text x) |> this.AddAttr
    [<CustomOperation("Breadcrumb")>] member this.Breadcrumb (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "Breadcrumb" (html.text x) |> this.AddAttr
    [<CustomOperation("Breadcrumb")>] member this.Breadcrumb (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "Breadcrumb" (html.text x) |> this.AddAttr
    [<CustomOperation("TabList")>] member this.TabList (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IList<AntDesign.ProLayout.TabPaneItem>) = "TabList" => x |> this.AddAttr
    [<CustomOperation("TabActiveKey")>] member this.TabActiveKey (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "TabActiveKey" => x |> this.AddAttr
    [<CustomOperation("OnTabChange")>] member this.OnTabChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnTabChange" (fun e -> fn e)) |> this.AddAttr
                

type AvatarDropdownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = AvatarDropdownBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Avatar")>] member this.Avatar (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Avatar" => x |> this.AddAttr
    [<CustomOperation("Name")>] member this.Name (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Name" => x |> this.AddAttr
    [<CustomOperation("OnItemSelected")>] member this.OnItemSelected (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.MenuItem> "OnItemSelected" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("MenuItems")>] member this.MenuItems (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IEnumerable<AntDesign.ProLayout.AvatarMenuItem>) = "MenuItems" => x |> this.AddAttr
                

type SelectLangBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SelectLangBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Locales")>] member this.Locales (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String[]) = "Locales" => x |> this.AddAttr
    [<CustomOperation("SelectedLocale")>] member this.SelectedLocale (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "SelectedLocale" => x |> this.AddAttr
    [<CustomOperation("LanguageLabels")>] member this.LanguageLabels (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IDictionary<System.String, System.String>) = "LanguageLabels" => x |> this.AddAttr
    [<CustomOperation("LanguageIcons")>] member this.LanguageIcons (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Collections.Generic.IDictionary<System.String, System.String>) = "LanguageIcons" => x |> this.AddAttr
    [<CustomOperation("OnItemSelected")>] member this.OnItemSelected (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<AntDesign.MenuItem> "OnItemSelected" (fun e -> fn e)) |> this.AddAttr
                

type BlockCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = BlockCheckboxBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> this.AddAttr
    [<CustomOperation("List")>] member this.List (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.CheckboxItem[]) = "List" => x |> this.AddAttr
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.String>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.String>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.String * (System.String -> unit)) = this.AddBinding("Value", valueFn)
                

type LayoutSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = LayoutSettingBuilder<'FunBlazorGeneric>().CreateNode()

                

type SettingDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = SettingDrawerBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("HideHintAlert")>] member this.HideHintAlert (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideHintAlert" => x |> this.AddAttr
    [<CustomOperation("HideCopyButton")>] member this.HideCopyButton (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "HideCopyButton" => x |> this.AddAttr
                

type ThemeColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = ThemeColorBuilder<'FunBlazorGeneric>().CreateNode()
    [<CustomOperation("Colors")>] member this.Colors (_: FunBlazorBuilder<'FunBlazorGeneric>, x: AntDesign.ProLayout.ColorItem[]) = "Colors" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("ValueChanged")>] member this.ValueChanged (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "ValueChanged" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("OnChange")>] member this.OnChange (_: FunBlazorBuilder<'FunBlazorGeneric>, fn) = (Bolero.Html.attr.callback<System.String> "OnChange" (fun e -> fn e)) |> this.AddAttr
    [<CustomOperation("Value")>] member this.Value (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Value" => x |> this.AddAttr
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: IStore<System.String>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, value: cval<System.String>) = this.AddBinding("Value", value)
    [<CustomOperation("Value'")>] member this.Value' (_: FunBlazorBuilder<'FunBlazorGeneric>, valueFn: System.String * (System.String -> unit)) = this.AddBinding("Value", valueFn)
                

type WrapContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = WrapContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = WrapContentBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = WrapContentBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = WrapContentBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> this.AddAttr
    [<CustomOperation("IsChildrenLayout")>] member this.IsChildrenLayout (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Boolean) = "IsChildrenLayout" => x |> this.AddAttr
    [<CustomOperation("ContentHeight")>] member this.ContentHeight (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.Int32) = "ContentHeight" => x |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
                

type PageLoadingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = PageLoadingBuilder<'FunBlazorGeneric>().CreateNode()

                

type BodyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    new (x: string) as this = BodyBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.text) |> this.AddAttr |> ignore
    new (x: Bolero.Node list) as this = BodyBuilder<'FunBlazorGeneric>() then Bolero.Html.attr.fragment "ChildContent" (x |> html.fragment) |> this.AddAttr |> ignore
    static member create (x: string) = BodyBuilder<'FunBlazorGeneric>(x).CreateNode()
    static member create (x: Bolero.Node list) = BodyBuilder<'FunBlazorGeneric>(x).CreateNode()
    [<CustomOperation("PrefixCls")>] member this.PrefixCls (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "PrefixCls" => x |> this.AddAttr
    [<CustomOperation("Title")>] member this.Title (_: FunBlazorBuilder<'FunBlazorGeneric>, x: System.String) = "Title" => x |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, nodes) = Bolero.Html.attr.fragment "ChildContent" (html.fragment nodes) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: string) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: int) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
    [<CustomOperation("childContent")>] member this.childContent (_: FunBlazorBuilder<'FunBlazorGeneric>, x: float) = Bolero.Html.attr.fragment "ChildContent" (html.text x) |> this.AddAttr
                

type OtherSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = OtherSettingBuilder<'FunBlazorGeneric>().CreateNode()

                

type RegionalSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member create () = RegionalSettingBuilder<'FunBlazorGeneric>().CreateNode()

                

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit FunBlazorBuilder<'FunBlazorGeneric>()
    static member create () = _ImportsBuilder<'FunBlazorGeneric>().CreateNode()

                
            

// =======================================================================================================================

namespace AntDesign.ProLayout

[<AutoOpen>]
module DslCE =

    open AntDesign.ProLayout.DslInternals

    type AntComponentBase'() = inherit AntComponentBaseBuilder<AntDesign.AntComponentBase>()
    type AntDomComponentBase'() = inherit AntDomComponentBaseBuilder<AntDesign.AntDomComponentBase>()
            
namespace AntDesign.ProLayout.ProLayout

[<AutoOpen>]
module DslCE =

    open AntDesign.ProLayout.DslInternals.ProLayout

    type AntProComponentBase'() = inherit AntProComponentBaseBuilder<AntDesign.ProLayout.AntProComponentBase>()
    type BasicLayout'() = inherit BasicLayoutBuilder<AntDesign.ProLayout.BasicLayout>()
    type GlobalHeader'() = inherit GlobalHeaderBuilder<AntDesign.ProLayout.GlobalHeader>()
    type HeaderView'() = inherit HeaderViewBuilder<AntDesign.ProLayout.HeaderView>()
    type BaseMenu'() = inherit BaseMenuBuilder<AntDesign.ProLayout.BaseMenu>()
    type SiderMenu'() = inherit SiderMenuBuilder<AntDesign.ProLayout.SiderMenu>()
    type TopNavHeader'() = inherit TopNavHeaderBuilder<AntDesign.ProLayout.TopNavHeader>()
    type FooterView'() = inherit FooterViewBuilder<AntDesign.ProLayout.FooterView>()
    type SiderMenuWrapper'() = inherit SiderMenuWrapperBuilder<AntDesign.ProLayout.SiderMenuWrapper>()
    type GlobalFooter'() = inherit GlobalFooterBuilder<AntDesign.ProLayout.GlobalFooter>()
    type GridContent'() = inherit GridContentBuilder<AntDesign.ProLayout.GridContent>()
    type HeaderSearch'() = inherit HeaderSearchBuilder<AntDesign.ProLayout.HeaderSearch>()
    type NoticeIcon'() = inherit NoticeIconBuilder<AntDesign.ProLayout.NoticeIcon>()
    type NoticeList'() = inherit NoticeListBuilder<AntDesign.ProLayout.NoticeList>()
    type PageContainer'() = inherit PageContainerBuilder<AntDesign.ProLayout.PageContainer>()
    type AvatarDropdown'() = inherit AvatarDropdownBuilder<AntDesign.ProLayout.AvatarDropdown>()
    type SelectLang'() = inherit SelectLangBuilder<AntDesign.ProLayout.SelectLang>()
    type BlockCheckbox'() = inherit BlockCheckboxBuilder<AntDesign.ProLayout.BlockCheckbox>()
    type LayoutSetting'() = inherit LayoutSettingBuilder<AntDesign.ProLayout.LayoutSetting>()
    type SettingDrawer'() = inherit SettingDrawerBuilder<AntDesign.ProLayout.SettingDrawer>()
    type ThemeColor'() = inherit ThemeColorBuilder<AntDesign.ProLayout.ThemeColor>()
    type WrapContent'() = inherit WrapContentBuilder<AntDesign.ProLayout.WrapContent>()
    type PageLoading'() = inherit PageLoadingBuilder<AntDesign.ProLayout.PageLoading>()
    type Body'() = inherit BodyBuilder<AntDesign.ProLayout.Body>()
    type OtherSetting'() = inherit OtherSettingBuilder<AntDesign.ProLayout.OtherSetting>()
    type RegionalSetting'() = inherit RegionalSettingBuilder<AntDesign.ProLayout.RegionalSetting>()
    type _Imports'() = inherit _ImportsBuilder<AntDesign.ProLayout._Imports>()
            