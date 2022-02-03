namespace rec AntDesign.ProLayout.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.ProLayout.DslInternals


type AntComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(AntComponentBaseBuilder<'FunBlazorGeneric>())
    [<CustomOperation("RefBack")>] member _.RefBack (render: AttrRenderFragment, x: AntDesign.ForwardRef) = render ==> ("RefBack" => x)
                

type AntDomComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(AntDomComponentBaseBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Id")>] member _.Id (render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    [<CustomOperation("Classes")>] member _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member _.Styles (render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
                
            
namespace rec AntDesign.ProLayout.DslInternals.ProLayout

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open AntDesign.ProLayout.DslInternals


type AntProComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = AntProComponentBaseBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = AntProComponentBaseBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("NavTheme")>] member _.NavTheme (render: AttrRenderFragment, x: AntDesign.MenuTheme) = render ==> ("NavTheme" => x)
    [<CustomOperation("HeaderHeight")>] member _.HeaderHeight (render: AttrRenderFragment, x: System.Int32) = render ==> ("HeaderHeight" => x)
    [<CustomOperation("Layout")>] member _.Layout (render: AttrRenderFragment, x: AntDesign.ProLayout.Layout) = render ==> ("Layout" => x)
    [<CustomOperation("ContentWidth")>] member _.ContentWidth (render: AttrRenderFragment, x: System.String) = render ==> ("ContentWidth" => x)
    [<CustomOperation("FixedHeader")>] member _.FixedHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
    [<CustomOperation("FixSiderbar")>] member _.FixSiderbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixSiderbar" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("IconfontUrl")>] member _.IconfontUrl (render: AttrRenderFragment, x: System.String) = render ==> ("IconfontUrl" => x)
    [<CustomOperation("PrimaryColor")>] member _.PrimaryColor (render: AttrRenderFragment, x: System.String) = render ==> ("PrimaryColor" => x)
    [<CustomOperation("ColorWeak")>] member _.ColorWeak (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ColorWeak" => x)
    [<CustomOperation("SplitMenus")>] member _.SplitMenus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SplitMenus" => x)
    [<CustomOperation("HeaderRender")>] member _.HeaderRender (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HeaderRender" => x)
    [<CustomOperation("FooterRender")>] member _.FooterRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterRender", fragment)
    [<CustomOperation("FooterRender")>] member _.FooterRender (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("FooterRender", fragment { yield! fragments })
    [<CustomOperation("FooterRender")>] member _.FooterRender (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("FooterRender", html.text x)
    [<CustomOperation("FooterRender")>] member _.FooterRender (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("FooterRender", html.text x)
    [<CustomOperation("FooterRender")>] member _.FooterRender (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("FooterRender", html.text x)
    [<CustomOperation("MenuRender")>] member _.MenuRender (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MenuRender" => x)
    [<CustomOperation("MenuHeaderRender")>] member _.MenuHeaderRender (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MenuHeaderRender" => x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                

type BasicLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(BasicLayoutBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Collapsed")>] member _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("HandleOpenChange")>] member _.HandleOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HandleOpenChange", fn)
    [<CustomOperation("IsMobile")>] member _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("MenuData")>] member _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
    [<CustomOperation("Mode")>] member _.Mode (render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnCollapse")>] member _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("OpenKeys")>] member _.OpenKeys (render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
    [<CustomOperation("Theme")>] member _.Theme (render: AttrRenderFragment, x: AntDesign.MenuTheme) = render ==> ("Theme" => x)
    [<CustomOperation("Logo")>] member _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
    [<CustomOperation("BaseURL")>] member _.BaseURL (render: AttrRenderFragment, x: System.String) = render ==> ("BaseURL" => x)
    [<CustomOperation("SiderWidth")>] member _.SiderWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("SiderWidth" => x)
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MenuExtraRender", fragment)
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MenuExtraRender", fragment { yield! fragments })
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MenuExtraRender", html.text x)
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MenuExtraRender", html.text x)
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MenuExtraRender", html.text x)
    [<CustomOperation("CollapsedButtonRender")>] member _.CollapsedButtonRender (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("CollapsedButtonRender", fn)
    [<CustomOperation("Breakpoint")>] member _.Breakpoint (render: AttrRenderFragment, x: AntDesign.BreakpointType) = render ==> ("Breakpoint" => x)
    [<CustomOperation("OnMenuHeaderClick")>] member _.OnMenuHeaderClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnMenuHeaderClick", fn)
    [<CustomOperation("Hide")>] member _.Hide (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hide" => x)
    [<CustomOperation("Links")>] member _.Links (render: AttrRenderFragment, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Links" => x)
    [<CustomOperation("OnOpenChange")>] member _.OnOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("OnOpenChange", fn)
    [<CustomOperation("Pure")>] member _.Pure (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Pure" => x)
    [<CustomOperation("Loading")>] member _.Loading (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    [<CustomOperation("DisableContentMargin")>] member _.DisableContentMargin (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableContentMargin" => x)
    [<CustomOperation("ContentStyle")>] member _.ContentStyle (render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)
    [<CustomOperation("ColSize")>] member _.ColSize (render: AttrRenderFragment, x: System.String) = render ==> ("ColSize" => x)
    [<CustomOperation("RightContentRender")>] member _.RightContentRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("RightContentRender", fragment)
    [<CustomOperation("RightContentRender")>] member _.RightContentRender (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("RightContentRender", fragment { yield! fragments })
    [<CustomOperation("RightContentRender")>] member _.RightContentRender (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("RightContentRender", html.text x)
    [<CustomOperation("RightContentRender")>] member _.RightContentRender (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("RightContentRender", html.text x)
    [<CustomOperation("RightContentRender")>] member _.RightContentRender (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("RightContentRender", html.text x)
                

type GlobalHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(GlobalHeaderBuilder<'FunBlazorGeneric>())
    [<CustomOperation("PrefixCls")>] member _.PrefixCls (render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("OnCollapse")>] member _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("CollapsedButtonRender")>] member _.CollapsedButtonRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CollapsedButtonRender", fragment)
    [<CustomOperation("CollapsedButtonRender")>] member _.CollapsedButtonRender (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("CollapsedButtonRender", fragment { yield! fragments })
    [<CustomOperation("CollapsedButtonRender")>] member _.CollapsedButtonRender (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("CollapsedButtonRender", html.text x)
    [<CustomOperation("CollapsedButtonRender")>] member _.CollapsedButtonRender (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("CollapsedButtonRender", html.text x)
    [<CustomOperation("CollapsedButtonRender")>] member _.CollapsedButtonRender (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("CollapsedButtonRender", html.text x)
    [<CustomOperation("Collapsed")>] member _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("IsMobile")>] member _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("Logo")>] member _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
                

type HeaderViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(HeaderViewBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Collapsed")>] member _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("IsMobile")>] member _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("Logo")>] member _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
    [<CustomOperation("HasSiderMenu")>] member _.HasSiderMenu (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HasSiderMenu" => x)
    [<CustomOperation("SiderWidth")>] member _.SiderWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("SiderWidth" => x)
    [<CustomOperation("HeaderContentRender")>] member _.HeaderContentRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderContentRender", fragment)
    [<CustomOperation("HeaderContentRender")>] member _.HeaderContentRender (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("HeaderContentRender", fragment { yield! fragments })
    [<CustomOperation("HeaderContentRender")>] member _.HeaderContentRender (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("HeaderContentRender", html.text x)
    [<CustomOperation("HeaderContentRender")>] member _.HeaderContentRender (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("HeaderContentRender", html.text x)
    [<CustomOperation("HeaderContentRender")>] member _.HeaderContentRender (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("HeaderContentRender", html.text x)
    [<CustomOperation("MenuData")>] member _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
                

type BaseMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(BaseMenuBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Collapsed")>] member _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("HandleOpenChange")>] member _.HandleOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HandleOpenChange", fn)
    [<CustomOperation("IsMobile")>] member _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("MenuData")>] member _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
    [<CustomOperation("Mode")>] member _.Mode (render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnCollapse")>] member _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("OpenKeys")>] member _.OpenKeys (render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
                

type SiderMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(SiderMenuBuilder<'FunBlazorGeneric>())
    [<CustomOperation("HandleOpenChange")>] member _.HandleOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HandleOpenChange", fn)
    [<CustomOperation("IsMobile")>] member _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("MenuData")>] member _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
    [<CustomOperation("Mode")>] member _.Mode (render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnCollapse")>] member _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("OpenKeys")>] member _.OpenKeys (render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
    [<CustomOperation("Logo")>] member _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
    [<CustomOperation("BaseURL")>] member _.BaseURL (render: AttrRenderFragment, x: System.String) = render ==> ("BaseURL" => x)
    [<CustomOperation("SiderWidth")>] member _.SiderWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("SiderWidth" => x)
    [<CustomOperation("Breakpoint")>] member _.Breakpoint (render: AttrRenderFragment, x: AntDesign.BreakpointType) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Hide")>] member _.Hide (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hide" => x)
    [<CustomOperation("Links")>] member _.Links (render: AttrRenderFragment, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Links" => x)
    [<CustomOperation("OnMenuHeaderClick")>] member _.OnMenuHeaderClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnMenuHeaderClick", fn)
    [<CustomOperation("OnOpenChange")>] member _.OnOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("OnOpenChange", fn)
    [<CustomOperation("SiderTheme")>] member _.SiderTheme (render: AttrRenderFragment, x: AntDesign.SiderTheme) = render ==> ("SiderTheme" => x)
    [<CustomOperation("CollapsedButtonRender")>] member _.CollapsedButtonRender (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("CollapsedButtonRender", fn)
                

type TopNavHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(TopNavHeaderBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Collapsed")>] member _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("HandleOpenChange")>] member _.HandleOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HandleOpenChange", fn)
    [<CustomOperation("IsMobile")>] member _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("MenuData")>] member _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
    [<CustomOperation("Mode")>] member _.Mode (render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnCollapse")>] member _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("OpenKeys")>] member _.OpenKeys (render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
    [<CustomOperation("Theme")>] member _.Theme (render: AttrRenderFragment, x: AntDesign.MenuTheme) = render ==> ("Theme" => x)
    [<CustomOperation("Logo")>] member _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
    [<CustomOperation("SiderWidth")>] member _.SiderWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("SiderWidth" => x)
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MenuExtraRender", fragment)
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("MenuExtraRender", fragment { yield! fragments })
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("MenuExtraRender", html.text x)
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("MenuExtraRender", html.text x)
    [<CustomOperation("MenuExtraRender")>] member _.MenuExtraRender (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("MenuExtraRender", html.text x)
    [<CustomOperation("CollapsedButtonRender")>] member _.CollapsedButtonRender (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("CollapsedButtonRender", fn)
    [<CustomOperation("Breakpoint")>] member _.Breakpoint (render: AttrRenderFragment, x: AntDesign.BreakpointType) = render ==> ("Breakpoint" => x)
    [<CustomOperation("OnMenuHeaderClick")>] member _.OnMenuHeaderClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnMenuHeaderClick", fn)
    [<CustomOperation("Hide")>] member _.Hide (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hide" => x)
    [<CustomOperation("Links")>] member _.Links (render: AttrRenderFragment, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Links" => x)
    [<CustomOperation("OnOpenChange")>] member _.OnOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("OnOpenChange", fn)
                

type FooterViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(FooterViewBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Copyright")>] member _.Copyright (render: AttrRenderFragment, x: System.String) = render ==> ("Copyright" => x)
    [<CustomOperation("Links")>] member _.Links (render: AttrRenderFragment, x: AntDesign.ProLayout.LinkItem[]) = render ==> ("Links" => x)
                

type SiderMenuWrapperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(SiderMenuWrapperBuilder<'FunBlazorGeneric>())

                

type GlobalFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(GlobalFooterBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Copyright")>] member _.Copyright (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Copyright", fragment)
    [<CustomOperation("Copyright")>] member _.Copyright (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Copyright", fragment { yield! fragments })
    [<CustomOperation("Copyright")>] member _.Copyright (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Copyright", html.text x)
    [<CustomOperation("Copyright")>] member _.Copyright (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Copyright", html.text x)
    [<CustomOperation("Copyright")>] member _.Copyright (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Copyright", html.text x)
    [<CustomOperation("Links")>] member _.Links (render: AttrRenderFragment, x: AntDesign.ProLayout.LinkItem[]) = render ==> ("Links" => x)
                

type GridContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = GridContentBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = GridContentBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("ContentWidth")>] member _.ContentWidth (render: AttrRenderFragment, x: System.String) = render ==> ("ContentWidth" => x)
                

type HeaderSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(HeaderSearchBuilder<'FunBlazorGeneric>())
    [<CustomOperation("DefaultValue")>] member _.DefaultValue (render: AttrRenderFragment, x: System.String) = render ==> ("DefaultValue" => x)
    [<CustomOperation("Placeholder")>] member _.Placeholder (render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("OnVisibleChange")>] member _.OnVisibleChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnVisibleChange", fn)
    [<CustomOperation("Options")>] member _.Options (render: AttrRenderFragment, x: System.Collections.Generic.List<AntDesign.AutoCompleteDataItem<System.String>>) = render ==> ("Options" => x)
                

type NoticeIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = NoticeIconBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = NoticeIconBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Visible")>] member _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Count")>] member _.Count (render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    [<CustomOperation("ClearText")>] member _.ClearText (render: AttrRenderFragment, x: System.String) = render ==> ("ClearText" => x)
    [<CustomOperation("ViewMoreText")>] member _.ViewMoreText (render: AttrRenderFragment, x: System.String) = render ==> ("ViewMoreText" => x)
    [<CustomOperation("OnClear")>] member _.OnClear (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnClear", fn)
    [<CustomOperation("OnViewMore")>] member _.OnViewMore (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnViewMore", fn)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                

type NoticeListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(NoticeListBuilder<'FunBlazorGeneric>())
    [<CustomOperation("TabKey")>] member _.TabKey (render: AttrRenderFragment, x: System.String) = render ==> ("TabKey" => x)
    [<CustomOperation("EmptyText")>] member _.EmptyText (render: AttrRenderFragment, x: System.String) = render ==> ("EmptyText" => x)
    [<CustomOperation("Data")>] member _.Data (render: AttrRenderFragment, x: System.Collections.Generic.ICollection<AntDesign.ProLayout.NoticeIconData>) = render ==> ("Data" => x)
    [<CustomOperation("ShowClear")>] member _.ShowClear (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowClear" => x)
    [<CustomOperation("ShowViewMore")>] member _.ShowViewMore (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowViewMore" => x)
    [<CustomOperation("OnClear")>] member _.OnClear (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnClear", fn)
    [<CustomOperation("OnViewMore")>] member _.OnViewMore (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnViewMore", fn)
    [<CustomOperation("OnItemClick")>] member _.OnItemClick (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnItemClick", fn)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("ClearText")>] member _.ClearText (render: AttrRenderFragment, x: System.String) = render ==> ("ClearText" => x)
    [<CustomOperation("ViewMoreText")>] member _.ViewMoreText (render: AttrRenderFragment, x: System.String) = render ==> ("ViewMoreText" => x)
                

type PageContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = PageContainerBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = PageContainerBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("Extra")>] member _.Extra (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Extra", fragment)
    [<CustomOperation("Extra")>] member _.Extra (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Extra", fragment { yield! fragments })
    [<CustomOperation("Extra")>] member _.Extra (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Extra")>] member _.Extra (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("Extra")>] member _.Extra (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Extra", html.text x)
    [<CustomOperation("ExtraContent")>] member _.ExtraContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ExtraContent", fragment)
    [<CustomOperation("ExtraContent")>] member _.ExtraContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ExtraContent", fragment { yield! fragments })
    [<CustomOperation("ExtraContent")>] member _.ExtraContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ExtraContent", html.text x)
    [<CustomOperation("ExtraContent")>] member _.ExtraContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ExtraContent", html.text x)
    [<CustomOperation("ExtraContent")>] member _.ExtraContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ExtraContent", html.text x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Content", fragment { yield! fragments })
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("Content")>] member _.Content (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Content", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Breadcrumb")>] member _.Breadcrumb (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Breadcrumb", fragment)
    [<CustomOperation("Breadcrumb")>] member _.Breadcrumb (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("Breadcrumb", fragment { yield! fragments })
    [<CustomOperation("Breadcrumb")>] member _.Breadcrumb (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("Breadcrumb", html.text x)
    [<CustomOperation("Breadcrumb")>] member _.Breadcrumb (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("Breadcrumb", html.text x)
    [<CustomOperation("Breadcrumb")>] member _.Breadcrumb (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("Breadcrumb", html.text x)
    [<CustomOperation("TabList")>] member _.TabList (render: AttrRenderFragment, x: System.Collections.Generic.IList<AntDesign.ProLayout.TabPaneItem>) = render ==> ("TabList" => x)
    [<CustomOperation("TabActiveKey")>] member _.TabActiveKey (render: AttrRenderFragment, x: System.String) = render ==> ("TabActiveKey" => x)
    [<CustomOperation("OnTabChange")>] member _.OnTabChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnTabChange", fn)
                

type AvatarDropdownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(AvatarDropdownBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Avatar")>] member _.Avatar (render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("Name")>] member _.Name (render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("OnItemSelected")>] member _.OnItemSelected (render: AttrRenderFragment, fn) = render ==> html.callback<AntDesign.MenuItem>("OnItemSelected", fn)
    [<CustomOperation("MenuItems")>] member _.MenuItems (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<AntDesign.ProLayout.AvatarMenuItem>) = render ==> ("MenuItems" => x)
                

type SelectLangBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(SelectLangBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Locales")>] member _.Locales (render: AttrRenderFragment, x: System.String[]) = render ==> ("Locales" => x)
    [<CustomOperation("SelectedLocale")>] member _.SelectedLocale (render: AttrRenderFragment, x: System.String) = render ==> ("SelectedLocale" => x)
    [<CustomOperation("LanguageLabels")>] member _.LanguageLabels (render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.String>) = render ==> ("LanguageLabels" => x)
    [<CustomOperation("LanguageIcons")>] member _.LanguageIcons (render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.String>) = render ==> ("LanguageIcons" => x)
    [<CustomOperation("OnItemSelected")>] member _.OnItemSelected (render: AttrRenderFragment, fn) = render ==> html.callback<AntDesign.MenuItem>("OnItemSelected", fn)
                

type BlockCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(BlockCheckboxBuilder<'FunBlazorGeneric>())
    [<CustomOperation("PrefixCls")>] member _.PrefixCls (render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("List")>] member _.List (render: AttrRenderFragment, x: AntDesign.ProLayout.CheckboxItem[]) = render ==> ("List" => x)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("ValueChanged", fn)
    [<CustomOperation("OnChange")>] member _.OnChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnChange", fn)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
                

type LayoutSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(LayoutSettingBuilder<'FunBlazorGeneric>())

                

type SettingDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(SettingDrawerBuilder<'FunBlazorGeneric>())
    [<CustomOperation("HideHintAlert")>] member _.HideHintAlert (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideHintAlert" => x)
    [<CustomOperation("HideCopyButton")>] member _.HideCopyButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideCopyButton" => x)
                

type ThemeColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(ThemeColorBuilder<'FunBlazorGeneric>())
    [<CustomOperation("Colors")>] member _.Colors (render: AttrRenderFragment, x: AntDesign.ProLayout.ColorItem[]) = render ==> ("Colors" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("ValueChanged")>] member _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("ValueChanged", fn)
    [<CustomOperation("OnChange")>] member _.OnChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnChange", fn)
    [<CustomOperation("Value")>] member _.Value (render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member _.Value' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
                

type WrapContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = WrapContentBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = WrapContentBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("PrefixCls")>] member _.PrefixCls (render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("IsChildrenLayout")>] member _.IsChildrenLayout (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsChildrenLayout" => x)
    [<CustomOperation("ContentHeight")>] member _.ContentHeight (render: AttrRenderFragment, x: System.Int32) = render ==> ("ContentHeight" => x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                

type PageLoadingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(PageLoadingBuilder<'FunBlazorGeneric>())

                

type BodyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create (x: string) = BodyBuilder<'FunBlazorGeneric>(){ x }
    static member inline create (x: NodeRenderFragment seq) = BodyBuilder<'FunBlazorGeneric>(){ yield! x }
    [<CustomOperation("PrefixCls")>] member _.PrefixCls (render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("Title")>] member _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, fragments) = render ==> html.renderFragment("ChildContent", fragment { yield! fragments })
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: string) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: int) = render ==> html.renderFragment("ChildContent", html.text x)
    [<CustomOperation("childContent")>] member _.childContent (render: AttrRenderFragment, x: float) = render ==> html.renderFragment("ChildContent", html.text x)
                

type OtherSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(OtherSettingBuilder<'FunBlazorGeneric>())

                

type RegionalSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(RegionalSettingBuilder<'FunBlazorGeneric>())

                

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentWithDomAndChildAttrBuilder<'FunBlazorGeneric>()
    static member inline create () = html.fromBuilder(_ImportsBuilder<'FunBlazorGeneric>())

                
            

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
            