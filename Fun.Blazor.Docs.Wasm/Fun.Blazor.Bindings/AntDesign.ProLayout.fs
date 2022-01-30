namespace rec AntDesign.ProLayout.DslInternals

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.ProLayout.DslInternals


type AntComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()
    [<CustomOperation("RefBack")>] member inline _.RefBack (render: AttrRenderFragment, x: AntDesign.ForwardRef) = render ==> ("RefBack" => x)
                

type AntDomComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Id")>] member inline _.Id (render: AttrRenderFragment, x: System.String) = render ==> ("Id" => x)
    [<CustomOperation("Classes")>] member inline _.Classes (render: AttrRenderFragment, x: string list) = render ==> html.classes x
    [<CustomOperation("Styles")>] member inline _.Styles (render: AttrRenderFragment, x: (string * string) list) = render ==> html.styles x
                
            
namespace rec AntDesign.ProLayout.DslInternals.ProLayout

open FSharp.Data.Adaptive
open Fun.Blazor
open Fun.Blazor.Operators
open Microsoft.AspNetCore.Components.DslInternals
open Microsoft.AspNetCore.Components.Web.DslInternals
open AntDesign.ProLayout.DslInternals


type AntProComponentBaseBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("NavTheme")>] member inline _.NavTheme (render: AttrRenderFragment, x: AntDesign.MenuTheme) = render ==> ("NavTheme" => x)
    [<CustomOperation("HeaderHeight")>] member inline _.HeaderHeight (render: AttrRenderFragment, x: System.Int32) = render ==> ("HeaderHeight" => x)
    [<CustomOperation("Layout")>] member inline _.Layout (render: AttrRenderFragment, x: AntDesign.ProLayout.Layout) = render ==> ("Layout" => x)
    [<CustomOperation("ContentWidth")>] member inline _.ContentWidth (render: AttrRenderFragment, x: System.String) = render ==> ("ContentWidth" => x)
    [<CustomOperation("FixedHeader")>] member inline _.FixedHeader (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixedHeader" => x)
    [<CustomOperation("FixSiderbar")>] member inline _.FixSiderbar (render: AttrRenderFragment, x: System.Boolean) = render ==> ("FixSiderbar" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("IconfontUrl")>] member inline _.IconfontUrl (render: AttrRenderFragment, x: System.String) = render ==> ("IconfontUrl" => x)
    [<CustomOperation("PrimaryColor")>] member inline _.PrimaryColor (render: AttrRenderFragment, x: System.String) = render ==> ("PrimaryColor" => x)
    [<CustomOperation("ColorWeak")>] member inline _.ColorWeak (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ColorWeak" => x)
    [<CustomOperation("SplitMenus")>] member inline _.SplitMenus (render: AttrRenderFragment, x: System.Boolean) = render ==> ("SplitMenus" => x)
    [<CustomOperation("HeaderRender")>] member inline _.HeaderRender (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HeaderRender" => x)
    [<CustomOperation("FooterRender")>] member inline _.FooterRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("FooterRender", fragment)
    [<CustomOperation("MenuRender")>] member inline _.MenuRender (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MenuRender" => x)
    [<CustomOperation("MenuHeaderRender")>] member inline _.MenuHeaderRender (render: AttrRenderFragment, x: System.Boolean) = render ==> ("MenuHeaderRender" => x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
                

type BasicLayoutBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Collapsed")>] member inline _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("HandleOpenChange")>] member inline _.HandleOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HandleOpenChange", fn)
    [<CustomOperation("IsMobile")>] member inline _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("MenuData")>] member inline _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
    [<CustomOperation("Mode")>] member inline _.Mode (render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("OpenKeys")>] member inline _.OpenKeys (render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
    [<CustomOperation("Theme")>] member inline _.Theme (render: AttrRenderFragment, x: AntDesign.MenuTheme) = render ==> ("Theme" => x)
    [<CustomOperation("Logo")>] member inline _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
    [<CustomOperation("BaseURL")>] member inline _.BaseURL (render: AttrRenderFragment, x: System.String) = render ==> ("BaseURL" => x)
    [<CustomOperation("SiderWidth")>] member inline _.SiderWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("SiderWidth" => x)
    [<CustomOperation("MenuExtraRender")>] member inline _.MenuExtraRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MenuExtraRender", fragment)
    [<CustomOperation("CollapsedButtonRender")>] member inline _.CollapsedButtonRender (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("CollapsedButtonRender", fn)
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint (render: AttrRenderFragment, x: AntDesign.BreakpointType) = render ==> ("Breakpoint" => x)
    [<CustomOperation("OnMenuHeaderClick")>] member inline _.OnMenuHeaderClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnMenuHeaderClick", fn)
    [<CustomOperation("Hide")>] member inline _.Hide (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hide" => x)
    [<CustomOperation("Links")>] member inline _.Links (render: AttrRenderFragment, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Links" => x)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("OnOpenChange", fn)
    [<CustomOperation("Pure")>] member inline _.Pure (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Pure" => x)
    [<CustomOperation("Loading")>] member inline _.Loading (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Loading" => x)
    [<CustomOperation("DisableContentMargin")>] member inline _.DisableContentMargin (render: AttrRenderFragment, x: System.Boolean) = render ==> ("DisableContentMargin" => x)
    [<CustomOperation("ContentStyle")>] member inline _.ContentStyle (render: AttrRenderFragment, x: System.String) = render ==> ("ContentStyle" => x)
    [<CustomOperation("ColSize")>] member inline _.ColSize (render: AttrRenderFragment, x: System.String) = render ==> ("ColSize" => x)
    [<CustomOperation("RightContentRender")>] member inline _.RightContentRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("RightContentRender", fragment)
                

type GlobalHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls (render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("CollapsedButtonRender")>] member inline _.CollapsedButtonRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("CollapsedButtonRender", fragment)
    [<CustomOperation("Collapsed")>] member inline _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("IsMobile")>] member inline _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("Logo")>] member inline _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
                

type HeaderViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Collapsed")>] member inline _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("IsMobile")>] member inline _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("Logo")>] member inline _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
    [<CustomOperation("HasSiderMenu")>] member inline _.HasSiderMenu (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HasSiderMenu" => x)
    [<CustomOperation("SiderWidth")>] member inline _.SiderWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("SiderWidth" => x)
    [<CustomOperation("HeaderContentRender")>] member inline _.HeaderContentRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("HeaderContentRender", fragment)
    [<CustomOperation("MenuData")>] member inline _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
                

type BaseMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Collapsed")>] member inline _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("HandleOpenChange")>] member inline _.HandleOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HandleOpenChange", fn)
    [<CustomOperation("IsMobile")>] member inline _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("MenuData")>] member inline _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
    [<CustomOperation("Mode")>] member inline _.Mode (render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("OpenKeys")>] member inline _.OpenKeys (render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
                

type SiderMenuBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("HandleOpenChange")>] member inline _.HandleOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HandleOpenChange", fn)
    [<CustomOperation("IsMobile")>] member inline _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("MenuData")>] member inline _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
    [<CustomOperation("Mode")>] member inline _.Mode (render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("OpenKeys")>] member inline _.OpenKeys (render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
    [<CustomOperation("Logo")>] member inline _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
    [<CustomOperation("BaseURL")>] member inline _.BaseURL (render: AttrRenderFragment, x: System.String) = render ==> ("BaseURL" => x)
    [<CustomOperation("SiderWidth")>] member inline _.SiderWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("SiderWidth" => x)
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint (render: AttrRenderFragment, x: AntDesign.BreakpointType) = render ==> ("Breakpoint" => x)
    [<CustomOperation("Hide")>] member inline _.Hide (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hide" => x)
    [<CustomOperation("Links")>] member inline _.Links (render: AttrRenderFragment, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Links" => x)
    [<CustomOperation("OnMenuHeaderClick")>] member inline _.OnMenuHeaderClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnMenuHeaderClick", fn)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("OnOpenChange", fn)
    [<CustomOperation("SiderTheme")>] member inline _.SiderTheme (render: AttrRenderFragment, x: AntDesign.SiderTheme) = render ==> ("SiderTheme" => x)
    [<CustomOperation("CollapsedButtonRender")>] member inline _.CollapsedButtonRender (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("CollapsedButtonRender", fn)
                

type TopNavHeaderBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Collapsed")>] member inline _.Collapsed (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Collapsed" => x)
    [<CustomOperation("HandleOpenChange")>] member inline _.HandleOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("HandleOpenChange", fn)
    [<CustomOperation("IsMobile")>] member inline _.IsMobile (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsMobile" => x)
    [<CustomOperation("MenuData")>] member inline _.MenuData (render: AttrRenderFragment, x: AntDesign.ProLayout.MenuDataItem[]) = render ==> ("MenuData" => x)
    [<CustomOperation("Mode")>] member inline _.Mode (render: AttrRenderFragment, x: AntDesign.MenuMode) = render ==> ("Mode" => x)
    [<CustomOperation("OnCollapse")>] member inline _.OnCollapse (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnCollapse", fn)
    [<CustomOperation("OpenKeys")>] member inline _.OpenKeys (render: AttrRenderFragment, x: System.String[]) = render ==> ("OpenKeys" => x)
    [<CustomOperation("Theme")>] member inline _.Theme (render: AttrRenderFragment, x: AntDesign.MenuTheme) = render ==> ("Theme" => x)
    [<CustomOperation("Logo")>] member inline _.Logo (render: AttrRenderFragment, x: OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Logo" => x)
    [<CustomOperation("SiderWidth")>] member inline _.SiderWidth (render: AttrRenderFragment, x: System.Int32) = render ==> ("SiderWidth" => x)
    [<CustomOperation("MenuExtraRender")>] member inline _.MenuExtraRender (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("MenuExtraRender", fragment)
    [<CustomOperation("CollapsedButtonRender")>] member inline _.CollapsedButtonRender (render: AttrRenderFragment, fn: System.Boolean -> NodeRenderFragment) = render ==> html.renderFragment("CollapsedButtonRender", fn)
    [<CustomOperation("Breakpoint")>] member inline _.Breakpoint (render: AttrRenderFragment, x: AntDesign.BreakpointType) = render ==> ("Breakpoint" => x)
    [<CustomOperation("OnMenuHeaderClick")>] member inline _.OnMenuHeaderClick (render: AttrRenderFragment, fn) = render ==> html.callback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>("OnMenuHeaderClick", fn)
    [<CustomOperation("Hide")>] member inline _.Hide (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Hide" => x)
    [<CustomOperation("Links")>] member inline _.Links (render: AttrRenderFragment, x: System.Collections.Generic.List<Microsoft.AspNetCore.Components.RenderFragment>) = render ==> ("Links" => x)
    [<CustomOperation("OnOpenChange")>] member inline _.OnOpenChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String[]>("OnOpenChange", fn)
                

type FooterViewBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Copyright")>] member inline _.Copyright (render: AttrRenderFragment, x: System.String) = render ==> ("Copyright" => x)
    [<CustomOperation("Links")>] member inline _.Links (render: AttrRenderFragment, x: AntDesign.ProLayout.LinkItem[]) = render ==> ("Links" => x)
                

type SiderMenuWrapperBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ProLayout.AntProComponentBaseBuilder<'FunBlazorGeneric>()

                

type GlobalFooterBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Copyright")>] member inline _.Copyright (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Copyright", fragment)
    [<CustomOperation("Links")>] member inline _.Links (render: AttrRenderFragment, x: AntDesign.ProLayout.LinkItem[]) = render ==> ("Links" => x)
                

type GridContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("ContentWidth")>] member inline _.ContentWidth (render: AttrRenderFragment, x: System.String) = render ==> ("ContentWidth" => x)
                

type HeaderSearchBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("DefaultValue")>] member inline _.DefaultValue (render: AttrRenderFragment, x: System.String) = render ==> ("DefaultValue" => x)
    [<CustomOperation("Placeholder")>] member inline _.Placeholder (render: AttrRenderFragment, x: System.String) = render ==> ("Placeholder" => x)
    [<CustomOperation("OnVisibleChange")>] member inline _.OnVisibleChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.Boolean>("OnVisibleChange", fn)
    [<CustomOperation("Options")>] member inline _.Options (render: AttrRenderFragment, x: System.Collections.Generic.List<AntDesign.AutoCompleteDataItem<System.String>>) = render ==> ("Options" => x)
                

type NoticeIconBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Visible")>] member inline _.Visible (render: AttrRenderFragment, x: System.Boolean) = render ==> ("Visible" => x)
    [<CustomOperation("Count")>] member inline _.Count (render: AttrRenderFragment, x: System.Int32) = render ==> ("Count" => x)
    [<CustomOperation("ClearText")>] member inline _.ClearText (render: AttrRenderFragment, x: System.String) = render ==> ("ClearText" => x)
    [<CustomOperation("ViewMoreText")>] member inline _.ViewMoreText (render: AttrRenderFragment, x: System.String) = render ==> ("ViewMoreText" => x)
    [<CustomOperation("OnClear")>] member inline _.OnClear (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnClear", fn)
    [<CustomOperation("OnViewMore")>] member inline _.OnViewMore (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnViewMore", fn)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
                

type NoticeListBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("TabKey")>] member inline _.TabKey (render: AttrRenderFragment, x: System.String) = render ==> ("TabKey" => x)
    [<CustomOperation("EmptyText")>] member inline _.EmptyText (render: AttrRenderFragment, x: System.String) = render ==> ("EmptyText" => x)
    [<CustomOperation("Data")>] member inline _.Data (render: AttrRenderFragment, x: System.Collections.Generic.ICollection<AntDesign.ProLayout.NoticeIconData>) = render ==> ("Data" => x)
    [<CustomOperation("ShowClear")>] member inline _.ShowClear (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowClear" => x)
    [<CustomOperation("ShowViewMore")>] member inline _.ShowViewMore (render: AttrRenderFragment, x: System.Boolean) = render ==> ("ShowViewMore" => x)
    [<CustomOperation("OnClear")>] member inline _.OnClear (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnClear", fn)
    [<CustomOperation("OnViewMore")>] member inline _.OnViewMore (render: AttrRenderFragment, fn) = render ==> html.callback<unit>("OnViewMore", fn)
    [<CustomOperation("OnItemClick")>] member inline _.OnItemClick (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnItemClick", fn)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("ClearText")>] member inline _.ClearText (render: AttrRenderFragment, x: System.String) = render ==> ("ClearText" => x)
    [<CustomOperation("ViewMoreText")>] member inline _.ViewMoreText (render: AttrRenderFragment, x: System.String) = render ==> ("ViewMoreText" => x)
                

type PageContainerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Extra")>] member inline _.Extra (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Extra", fragment)
    [<CustomOperation("ExtraContent")>] member inline _.ExtraContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ExtraContent", fragment)
    [<CustomOperation("Content")>] member inline _.Content (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Content", fragment)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("Breadcrumb")>] member inline _.Breadcrumb (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("Breadcrumb", fragment)
    [<CustomOperation("TabList")>] member inline _.TabList (render: AttrRenderFragment, x: System.Collections.Generic.IList<AntDesign.ProLayout.TabPaneItem>) = render ==> ("TabList" => x)
    [<CustomOperation("TabActiveKey")>] member inline _.TabActiveKey (render: AttrRenderFragment, x: System.String) = render ==> ("TabActiveKey" => x)
    [<CustomOperation("OnTabChange")>] member inline _.OnTabChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnTabChange", fn)
                

type AvatarDropdownBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Avatar")>] member inline _.Avatar (render: AttrRenderFragment, x: System.String) = render ==> ("Avatar" => x)
    [<CustomOperation("Name")>] member inline _.Name (render: AttrRenderFragment, x: System.String) = render ==> ("Name" => x)
    [<CustomOperation("OnItemSelected")>] member inline _.OnItemSelected (render: AttrRenderFragment, fn) = render ==> html.callback<AntDesign.MenuItem>("OnItemSelected", fn)
    [<CustomOperation("MenuItems")>] member inline _.MenuItems (render: AttrRenderFragment, x: System.Collections.Generic.IEnumerable<AntDesign.ProLayout.AvatarMenuItem>) = render ==> ("MenuItems" => x)
                

type SelectLangBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Locales")>] member inline _.Locales (render: AttrRenderFragment, x: System.String[]) = render ==> ("Locales" => x)
    [<CustomOperation("SelectedLocale")>] member inline _.SelectedLocale (render: AttrRenderFragment, x: System.String) = render ==> ("SelectedLocale" => x)
    [<CustomOperation("LanguageLabels")>] member inline _.LanguageLabels (render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.String>) = render ==> ("LanguageLabels" => x)
    [<CustomOperation("LanguageIcons")>] member inline _.LanguageIcons (render: AttrRenderFragment, x: System.Collections.Generic.IDictionary<System.String, System.String>) = render ==> ("LanguageIcons" => x)
    [<CustomOperation("OnItemSelected")>] member inline _.OnItemSelected (render: AttrRenderFragment, fn) = render ==> html.callback<AntDesign.MenuItem>("OnItemSelected", fn)
                

type BlockCheckboxBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls (render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("List")>] member inline _.List (render: AttrRenderFragment, x: AntDesign.ProLayout.CheckboxItem[]) = render ==> ("List" => x)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("ValueChanged", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnChange", fn)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
                

type LayoutSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()

                

type SettingDrawerBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("HideHintAlert")>] member inline _.HideHintAlert (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideHintAlert" => x)
    [<CustomOperation("HideCopyButton")>] member inline _.HideCopyButton (render: AttrRenderFragment, x: System.Boolean) = render ==> ("HideCopyButton" => x)
                

type ThemeColorBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("Colors")>] member inline _.Colors (render: AttrRenderFragment, x: AntDesign.ProLayout.ColorItem[]) = render ==> ("Colors" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("ValueChanged")>] member inline _.ValueChanged (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("ValueChanged", fn)
    [<CustomOperation("OnChange")>] member inline _.OnChange (render: AttrRenderFragment, fn) = render ==> html.callback<System.String>("OnChange", fn)
    [<CustomOperation("Value")>] member inline _.Value (render: AttrRenderFragment, x: System.String) = render ==> ("Value" => x)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: IStore<System.String>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, value: cval<System.String>) = render ==> html.bind("Value", value)
    [<CustomOperation("Value'")>] member inline _.Value' (render: AttrRenderFragment, valueFn: System.String * (System.String -> unit)) = render ==> html.bind("Value", valueFn)
                

type WrapContentBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls (render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("IsChildrenLayout")>] member inline _.IsChildrenLayout (render: AttrRenderFragment, x: System.Boolean) = render ==> ("IsChildrenLayout" => x)
    [<CustomOperation("ContentHeight")>] member inline _.ContentHeight (render: AttrRenderFragment, x: System.Int32) = render ==> ("ContentHeight" => x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
                

type PageLoadingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()

                

type BodyBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()
    [<CustomOperation("PrefixCls")>] member inline _.PrefixCls (render: AttrRenderFragment, x: System.String) = render ==> ("PrefixCls" => x)
    [<CustomOperation("Title")>] member inline _.Title (render: AttrRenderFragment, x: System.String) = render ==> ("Title" => x)
    [<CustomOperation("childContent")>] member inline _.childContent (render: AttrRenderFragment, fragment) = render ==> html.renderFragment("ChildContent", fragment)
                

type OtherSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()

                

type RegionalSettingBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit AntDomComponentBaseBuilder<'FunBlazorGeneric>()

                

type _ImportsBuilder<'FunBlazorGeneric when 'FunBlazorGeneric :> Microsoft.AspNetCore.Components.IComponent>() =
    inherit ComponentBuilder<'FunBlazorGeneric>()

                
            

// =======================================================================================================================

namespace AntDesign.ProLayout

[<AutoOpen>]
module DslCE =

    open AntDesign.ProLayout.DslInternals

    let AntComponentBase' = AntComponentBaseBuilder<AntDesign.AntComponentBase>()
    let AntDomComponentBase' = AntDomComponentBaseBuilder<AntDesign.AntDomComponentBase>()
            
namespace AntDesign.ProLayout.ProLayout

[<AutoOpen>]
module DslCE =

    open AntDesign.ProLayout.DslInternals.ProLayout

    let AntProComponentBase' = AntProComponentBaseBuilder<AntDesign.ProLayout.AntProComponentBase>()
    let BasicLayout' = BasicLayoutBuilder<AntDesign.ProLayout.BasicLayout>()
    let GlobalHeader' = GlobalHeaderBuilder<AntDesign.ProLayout.GlobalHeader>()
    let HeaderView' = HeaderViewBuilder<AntDesign.ProLayout.HeaderView>()
    let BaseMenu' = BaseMenuBuilder<AntDesign.ProLayout.BaseMenu>()
    let SiderMenu' = SiderMenuBuilder<AntDesign.ProLayout.SiderMenu>()
    let TopNavHeader' = TopNavHeaderBuilder<AntDesign.ProLayout.TopNavHeader>()
    let FooterView' = FooterViewBuilder<AntDesign.ProLayout.FooterView>()
    let SiderMenuWrapper' = SiderMenuWrapperBuilder<AntDesign.ProLayout.SiderMenuWrapper>()
    let GlobalFooter' = GlobalFooterBuilder<AntDesign.ProLayout.GlobalFooter>()
    let GridContent' = GridContentBuilder<AntDesign.ProLayout.GridContent>()
    let HeaderSearch' = HeaderSearchBuilder<AntDesign.ProLayout.HeaderSearch>()
    let NoticeIcon' = NoticeIconBuilder<AntDesign.ProLayout.NoticeIcon>()
    let NoticeList' = NoticeListBuilder<AntDesign.ProLayout.NoticeList>()
    let PageContainer' = PageContainerBuilder<AntDesign.ProLayout.PageContainer>()
    let AvatarDropdown' = AvatarDropdownBuilder<AntDesign.ProLayout.AvatarDropdown>()
    let SelectLang' = SelectLangBuilder<AntDesign.ProLayout.SelectLang>()
    let BlockCheckbox' = BlockCheckboxBuilder<AntDesign.ProLayout.BlockCheckbox>()
    let LayoutSetting' = LayoutSettingBuilder<AntDesign.ProLayout.LayoutSetting>()
    let SettingDrawer' = SettingDrawerBuilder<AntDesign.ProLayout.SettingDrawer>()
    let ThemeColor' = ThemeColorBuilder<AntDesign.ProLayout.ThemeColor>()
    let WrapContent' = WrapContentBuilder<AntDesign.ProLayout.WrapContent>()
    let PageLoading' = PageLoadingBuilder<AntDesign.ProLayout.PageLoading>()
    let Body' = BodyBuilder<AntDesign.ProLayout.Body>()
    let OtherSetting' = OtherSettingBuilder<AntDesign.ProLayout.OtherSetting>()
    let RegionalSetting' = RegionalSettingBuilder<AntDesign.ProLayout.RegionalSetting>()
    let _Imports' = _ImportsBuilder<AntDesign.ProLayout._Imports>()
            